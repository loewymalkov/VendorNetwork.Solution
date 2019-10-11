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
    public ActionResult Create(string name, string description, int price, string date)
    {
      Order newOrder = new Order(name, description, price, date);
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