using System.Collections.Generic;
using Vendor.Models;

namespace Order.Models
{
  public class Order
  {
    // Create an Order class. This class should include properties for the title, the description, the price, the date, and any other properties you would like to include.

    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; set; }
    public static List<Order> OrderList = new List<Order>{};

    public Order(string title, string description, int price, string Date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      Id = OrderList.Count;
      OrderList.Add(this);
    }

    // public static List<Order> DisplayAll()
    // {
    //   return OrderList;
    // }


  }
}