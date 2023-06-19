using Microsoft.AspNetCore.Mvc;
using SkillsRecommenderAPI.Controllers;
using Xunit;

namespace SkillsRecommenderAPI.Tests.Controllers
{
    public class HelloWorldControllerTests
    {
        [Fact]
        public void HelloWorld_ReturnsHelloWorldString()
        {
            var controller = new HelloWorldController();

            var result = controller.HelloWorld();
            
            var okResult = Assert.IsType<OkObjectResult>(result);
            var helloWorldString = Assert.IsType<string>(okResult.Value);
            Assert.Equal("Hello, World!", helloWorldString);
        }
    }
}
