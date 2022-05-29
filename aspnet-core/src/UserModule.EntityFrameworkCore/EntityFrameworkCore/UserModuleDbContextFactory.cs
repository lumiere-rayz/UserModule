using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using UserModule.Configuration;
using UserModule.Web;

namespace UserModule.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class UserModuleDbContextFactory : IDesignTimeDbContextFactory<UserModuleDbContext>
    {
        public UserModuleDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<UserModuleDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            UserModuleDbContextConfigurer.Configure(builder, configuration.GetConnectionString(UserModuleConsts.ConnectionStringName));

            return new UserModuleDbContext(builder.Options);
        }
    }
}
