using Microsoft.AspNetCore.Mvc;
using Workshop.Data;

namespace Workshop.WebApp.Controllers;

public class ArtistsController : Controller {
    private readonly ILogger<ArtistsController> _logger;
    private readonly WorkshopDbContext db;

    public ArtistsController(ILogger<ArtistsController> logger, WorkshopDbContext db) {
        _logger = logger;
        this.db = db;
    }

    public IActionResult Index() {
        var artists = db.Artists;
        return View(artists);
    }
}