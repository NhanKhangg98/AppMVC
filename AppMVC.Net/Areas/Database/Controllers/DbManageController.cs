using Microsoft.AspNetCore.Mvc;

namespace AppMVC.Net.Areas.Database.Controllers
{
    [Area("Database")]
    [Route("/database-manage/[action]")]
    public class DbManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
