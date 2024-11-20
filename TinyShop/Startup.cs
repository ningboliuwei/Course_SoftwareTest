#region

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TinyShop.Data;

#endregion

namespace TinyShop {
    public class Startup {
        public Startup(IConfiguration configuration) {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<UserEntity> userManager,
            RoleManager<RoleEntity> roleManager) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            else {
                app.UseExceptionHandler("/Home/Error");
            }

            this.CreateRolesAndUsers(roleManager, userManager).Wait();

            app.UseStaticFiles();
            app.UseRouting();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                    "default",
                    "{controller=Product}/{action=Index}/{id?}");
            });
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddControllersWithViews();

            services.Configure<IdentityOptions>(options => {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 0;
                options.Password.RequiredUniqueChars = 0;
            });

            services.AddIdentity<UserEntity, RoleEntity>()
                .AddEntityFrameworkStores<DataContext>() // 请确保已正确配置 DbContext
                .AddDefaultTokenProviders(); // 默认的令牌提供者

            services.ConfigureApplicationCookie(options => {
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/Login/Index";
                options.AccessDeniedPath = "/Login/Index";
                options.SlidingExpiration = false;
                options.ExpireTimeSpan = TimeSpan.FromDays(365);
            });

            services.AddDbContextPool<DataContext>(
                dbContextOptions => dbContextOptions
                    .UseSqlite(this.Configuration.GetConnectionString("DefaultConnection"),
                        options => { options.MigrationsAssembly("TinyShop"); })
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors()
            );
        }

        // 创建角色和用户的任务方法
        private async Task CreateRolesAndUsers(RoleManager<RoleEntity> roleManager,
            UserManager<UserEntity> userManager) {
            // 检查是否已经存在名为 "User" 的角色
            var role = await roleManager.FindByNameAsync("User");

            // 如果角色不存在，删除角色（可能在某些情况下需要确保没有重复的角色）
            if (role != null) {
                await roleManager.DeleteAsync(role); // 注：此行代码可能是多余的，role 为 null 时不会执行删除
            }

            // 如果角色不存在，则创建一个新的 "User" 角色
            role = new RoleEntity { Name = "User" };
            await roleManager.CreateAsync(role); // 将角色添加到数据库

            // 获取新创建的角色
            var createdRole = await roleManager.FindByNameAsync(role.Name);

            // 查找名为 "Tom" 的用户
            var user = await userManager.FindByNameAsync("Tom");

            // 如果用户已存在，先删除用户（可以避免重复用户或更新旧用户数据）
            if (user != null) {
                await userManager.DeleteAsync(user); // 删除已有用户
            }

            // 创建新的用户 "Tom"
            user = new UserEntity {
                UserName = "Tom", // 用户名为 "Tom"
                Email = "tom@domain.com" // 设置用户的邮箱地址
            };

            // 创建用户并设置密码为 "123"
            var createUserResult = await userManager.CreateAsync(user, "123"); // 设置密码为 "123"

            // 如果用户创建成功
            if (createUserResult.Succeeded) {
                // 查找刚刚创建的用户 "Tom"
                var createdUser = await userManager.FindByNameAsync("Tom");

                // 将用户添加到 "User" 角色中
                await userManager.AddToRoleAsync(createdUser, createdRole.Name); // 给用户赋予角色 "User"
            }
        }
    }
}