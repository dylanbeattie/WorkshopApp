using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using Workshop.WebApp.Controllers;

namespace Workshop.WebApp.Tests.Controllers;

public class HomeControllerTests {
    private readonly NullLogger<HomeController> logger;

    public HomeControllerTests() {
        logger = new NullLogger<HomeController>();
    }

    [Fact]
    public void Home_Index_Returns_Page() {
        var c = new HomeController(logger);
        var index = c.Index();
        index.ShouldBeOfType<ViewResult>();
    }
}