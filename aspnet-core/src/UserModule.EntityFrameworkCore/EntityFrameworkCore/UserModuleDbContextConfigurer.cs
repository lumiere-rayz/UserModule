using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace UserModule.EntityFrameworkCore
{
    public static class UserModuleDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<UserModuleDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<UserModuleDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
