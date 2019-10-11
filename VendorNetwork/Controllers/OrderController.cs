using Microsoft.AspNetCore.Mvc;
using VendorNetwork.Models;
using System.Collections.Generic;

namespace VendorNetwork.Controllers
{
  public class OrderController : Controller
  {

    [HttpGet("/orders")]
    public ActionResult Index()
    {
      return View(Order.OrderList);
    }

    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/orders")]
    public ActionResult Create(string description)
    {
      Item myItem = new Item(description);
      return RedirectToAction("Index");
    }

    [HttpGet("/orders/{id}")]
    public ActionResult Show(int id)
    {
      Order foundOrder = Order.FindOrder(id);
      return View(foundOrder);
    }

  }
}