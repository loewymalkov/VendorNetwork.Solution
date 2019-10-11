using Microsoft.AspNetCore.Mvc;
using VendorNetwork.Models;

namespace Vendor.Controllers
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