using Microsoft.AspNetCore.Mvc;
using Razor_Html_Element.Models;
using System.Diagnostics;

namespace Razor_Html_Element.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            Student s = new Student()
            {

                Email = "emrahelis@gmail.com",
                Name = "Emrah",
                Surname = "Eliþ",
                Password = "1010",

                Lessons = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>()
                {


                    new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem()
                    {
                         Text="Fizik",
                          Value="1"
                    },
                    new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem()
                    {
                         Text="Türkçe",
                         Value="2"
                    },
                     new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem()
                    {
                         Text="Matematik",
                         Value="3"
                    },
                      new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem()
                    {
                         Text="Geometri",
                         Value="4"
                    }
                }


            };
            // modeli view'e gönderdik
            return View(s);
        }
        [HttpPost]
        public IActionResult Index(Student model)
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
