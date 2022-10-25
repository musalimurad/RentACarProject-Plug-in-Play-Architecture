using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class HomeController : Controller
    {
        private readonly ICarService _carService;

        public HomeController(ICarService carService)
        {
            _carService = carService;
        }

        // GET: HomeController
        public ActionResult Index()
        {
            var cars = _carService.GetAllCars();
            return View(cars);
        }

    }
}
