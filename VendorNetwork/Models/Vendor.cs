using System.Collections.Generic;

namespace VendorNetwork.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> { };
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetVendors()
    {
      return _instances;
    }

    public static Vendor FindVendor(int searchId)
    {
      return _instances[searchId - 1];
    }


    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}