using System.Collections.Generic;

namespace Vendor.Models
{
  public class Vendor
  {
    // Create a Vendor class. This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.

    public string Name { get; }
    public string Description { get; set; }
    public int Id { get; }
    public static List<Vendor> VendorList = new List<Vendor>{};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Id = VendorList.Count;
      VendorList.Add(this);
    }
  }
}