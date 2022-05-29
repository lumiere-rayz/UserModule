using System.Threading.Tasks;
using UserModule.Models.TokenAuth;
using UserModule.Web.Controllers;
using Shouldly;
using Xunit;

namespace UserModule.Web.Tests.Controllers
{
    public class HomeController_Tests: UserModuleWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}