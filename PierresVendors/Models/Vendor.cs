using System.Collections.Generic;
using System;

namespace PierresVendors.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public int Id { get; }
    public static List<Order> Order { get; set; }

    public Vendor(string name)
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
      Order = new List<Order> { };
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public void AddOrder(Order order)
    {
      Order.Add(order);
    }

    public static Vendor FindById(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}