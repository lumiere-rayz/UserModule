using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using UserModule.Authorization.Roles;
using UserModule.Authorization.Users;
using UserModule.MultiTenancy;

namespace UserModule.EntityFrameworkCore
{
    public class UserModuleDbContext : AbpZeroDbContext<Tenant, Role, User, UserModuleDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<ExtendedUser> ExtendedUser { get; set; }

        public UserModuleDbContext(DbContextOptions<UserModuleDbContext> options)
            : base(options)
        {
        }
    }
}
