using AppMVC.Net.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Linq;

namespace AppMVC.Net.Controllers
{
    public class FirstController : Controller
    {
        private readonly ILogger<FirstController> _logger;
        private readonly ProductService _productService;
        public FirstController(ILogger<FirstController> logger, ProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public string Index()
        {
            _logger.LogCritical("Bye Bye I'm hacker");
            _logger.LogInformation("Index Action");
            return "Oke chú bé đần";
        }

        public IActionResult Readme()
        {
            var content = @"
                Danh nhau khum,
                qua day



                Ayzo modo phac co
            ";
            return this.Content(content, "text/html");
        }

        public IActionResult DogBabi()
        {
            //Startup.ContentRootPath
            string filePath = Path.Combine(Startup.ContentRootPath, "Files", "DogTestAspNet.jpg");
            var bytes = System.IO.File.ReadAllBytes(filePath);

            return File(bytes, "image/jpg");
        }

        public IActionResult SamsungPrice()
        {
            return Json(
                new
                {
                    productName = "Samsung ghẻ",
                    Price = "$500"

                }
                );
        }

        public IActionResult Privacy()
        {
            var url = "https://google.com.vn";
            _logger.LogInformation("Chuyen huong den" + url);
            return Redirect(url);
        }

        public IActionResult HelloMotherFucker(string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                userName = "Web của bố mày";
            }
            // View() -> thực thi Razor Engine , đọc .cshtml (template)
            //---------------------------------------------------------
            // View(template) - template đường dẫn tuyệt đối tới .cshtml
            // View(template, model)
                //return View("/MyView/Hacker.cshtml", userName);

            // Hacker2.cshtml -> View/First/Hacker2.cshtml
                // return View("Hacker2", userName);


            // HelloMotherFucker.cshtml -> View/First/HelloMotherFucker.cshtml
            // /View/Controller/Action.cshtml
                // return View((object)userName);

            return View("Hacker3", userName);

            // View();
            // View(Model);

        }

        [TempData]
        public string Notify { get; set; }


        [AcceptVerbs("POST", "GET")]
        public IActionResult ViewProduct(int? id)
        {
            var product = _productService.Where(p => p.Id == id).FirstOrDefault();
            if(product == null)
            {
                // TempData["Notify"] = "San pham k thay tim lgi!!!";
                Notify = "San pham k thay tim lgi!!!";
                return Redirect(Url.Action("Index", "Home"));
            }

            // /View/First/ViewProduct.cshtml
            // Nếu k thấy tìm trên /MyView/First/ViewProduct.cshtml

            // Truyền dl bằng Model
            // return View(product);

            // Truyền dl bằng ViewData
            //this.ViewData["product"] = product;
            //ViewData["Title"] = product.Name;

            // return View("ViewProduct2");

            // Truyền dl bằng ViewBag
            ViewBag.product = product; // dynamic
            return View("ViewProduct3");
        }
    }
}
