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
                .AddEntityFrameworkStores<DataContext>() // ��ȷ������ȷ���� DbContext
                .AddDefaultTokenProviders(); // Ĭ�ϵ������ṩ��

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

        // ������ɫ���û������񷽷�
        private async Task CreateRolesAndUsers(RoleManager<RoleEntity> roleManager,
            UserManager<UserEntity> userManager) {
            // ����Ƿ��Ѿ�������Ϊ "User" �Ľ�ɫ
            var role = await roleManager.FindByNameAsync("User");

            // �����ɫ�����ڣ�ɾ����ɫ��������ĳЩ�������Ҫȷ��û���ظ��Ľ�ɫ��
            if (role != null) {
                await roleManager.DeleteAsync(role); // ע�����д�������Ƕ���ģ�role Ϊ null ʱ����ִ��ɾ��
            }

            // �����ɫ�����ڣ��򴴽�һ���µ� "User" ��ɫ
            role = new RoleEntity { Name = "User" };
            await roleManager.CreateAsync(role); // ����ɫ��ӵ����ݿ�

            // ��ȡ�´����Ľ�ɫ
            var createdRole = await roleManager.FindByNameAsync(role.Name);

            // ������Ϊ "Tom" ���û�
            var user = await userManager.FindByNameAsync("Tom");

            // ����û��Ѵ��ڣ���ɾ���û������Ա����ظ��û�����¾��û����ݣ�
            if (user != null) {
                await userManager.DeleteAsync(user); // ɾ�������û�
            }

            // �����µ��û� "Tom"
            user = new UserEntity {
                UserName = "Tom", // �û���Ϊ "Tom"
                Email = "tom@domain.com" // �����û��������ַ
            };

            // �����û�����������Ϊ "123"
            var createUserResult = await userManager.CreateAsync(user, "123"); // ��������Ϊ "123"

            // ����û������ɹ�
            if (createUserResult.Succeeded) {
                // ���Ҹոմ������û� "Tom"
                var createdUser = await userManager.FindByNameAsync("Tom");

                // ���û���ӵ� "User" ��ɫ��
                await userManager.AddToRoleAsync(createdUser, createdRole.Name); // ���û������ɫ "User"
            }
        }
    }
}