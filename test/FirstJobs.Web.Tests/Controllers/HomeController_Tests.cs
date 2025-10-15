using System.Threading.Tasks;
using FirstJobs.Models.TokenAuth;
using FirstJobs.Web.Controllers;
using Shouldly;
using Xunit;

namespace FirstJobs.Web.Tests.Controllers
{
    public class HomeController_Tests: FirstJobsWebTestBase
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