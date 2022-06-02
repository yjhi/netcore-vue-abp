using System.Threading.Tasks;
using Sample.Models.TokenAuth;
using Sample.Web.Controllers;
using Shouldly;
using Xunit;

namespace Sample.Web.Tests.Controllers
{
    public class HomeController_Tests: SampleWebTestBase
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