#region

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

#endregion

namespace TinyShop.Data {
    public class DataContext : IdentityDbContext<UserEntity, RoleEntity, long> {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductEntity>().ToTable("Products");
            modelBuilder.Entity<UserEntity>().ToTable("Identity_Users");
            modelBuilder.Entity<RoleEntity>().ToTable("Identity_Roles");
            modelBuilder.Entity<IdentityUserClaim<long>>().ToTable("Identity_UserClaims");
            modelBuilder.Entity<IdentityUserRole<long>>().ToTable("Identity_UserRoles");
            modelBuilder.Entity<IdentityUserLogin<long>>().ToTable("Identity_UserLogins");
            modelBuilder.Entity<IdentityRoleClaim<long>>().ToTable("Identity_RoleClaims");
            modelBuilder.Entity<IdentityUserToken<long>>().ToTable("Identity_UserTokens");
        }
    }
}