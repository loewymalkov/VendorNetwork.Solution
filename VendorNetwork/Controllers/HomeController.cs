using Microsoft.AspNetCore.Mvc;
using VendorNetwork.Models;

namespace VendorNetwork.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}