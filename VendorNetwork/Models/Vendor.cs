using System.Collections.Generic;

namespace VendorNetwork.Models
{
  public class Vendor
  {
    // Create a Vendor class. This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.

    public static List<Vendor> VendorList = new List<Vendor> {};
    public string Name { get; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      VendorList.Add(this);
      Id = VendorList.Count;
      Orders = new List<Order>{};
    }

      public static List<Vendor> GetVendors()
    {
      return VendorList;
    }

     public static Vendor FindVendor(int searchId)
    {
      return VendorList[searchId-1];
    }
  }
}