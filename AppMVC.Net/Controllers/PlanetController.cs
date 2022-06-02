using AppMVC.Net.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace AppMVC.Net.Controllers
{
    // [Route("he-mat-troi")]  // ~ phải thiết lập Route ở action
    [Route("he-mat-troi/[action]")]
    public class PlanetController : Controller
    {
        private readonly PlanetService _planetService;
        private readonly ILogger<PlanetController> _logger;

        public PlanetController(PlanetService planetService, ILogger<PlanetController> logger)
        {
            _planetService = planetService;
            _logger = logger;
        }


        // [Route("planet-list.html")]   // he-mat-troi/planet-list.html
        [Route("/planet-list.html")]     // planet-list.html
        public IActionResult Index()  
        {
            return View();
        }

        // route: action


        [BindProperty(SupportsGet =true, Name = "action")]
        public string Name { get; set; } // Action ~ PlanetModel
        
        [Route("")]        
        public IActionResult Mercury()
        {
            var palnet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", palnet);
        }
        public IActionResult Venus()
        {
            var palnet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", palnet);
        }
        public IActionResult Earth()
        {
            var palnet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", palnet);
        }
        public IActionResult Mars()
        {
            var palnet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", palnet);
        }

        [HttpGet("/saomoc.html")]
        public IActionResult Jupiter()
        {
            var palnet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", palnet);
        }
        public IActionResult Saturn()
        {
            var palnet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", palnet);
        }
        public IActionResult Uranus()
        {
            var palnet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", palnet);
        }

        [Route("sao/[action]", Order = 1, Name = "neptune1")] // sao/Neptune
        [Route("sao/[controller]/[action]", Order = 2, Name = "neptune2")]  // * sao/Planet/Neptune
        [Route("[controller]-[action].html", Order = 3, Name = "neptune3")] // Planet-Neptune.html
        public IActionResult Neptune()
        {
            var palnet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", palnet);
        }

        // controller, action, area => [controller] [action] [area]

        [Route("hanhtinh/{id:int}")] // /hanhtinh/1  ~ không chịu ảnh hưởng của MapControllerRoute
        public IActionResult PlanetInfo(int id)
        {
            var palnet = _planetService.Where(p => p.Id == id).FirstOrDefault();
            return View("Detail", palnet);
        }
    }
}
