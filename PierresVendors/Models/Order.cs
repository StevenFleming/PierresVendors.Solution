using System.Collections.Generic;
using System;

namespace PierresVendors.Models
{
  public class Order
  {
    public string Name { get; set; }
    public int Id { get; }
    public static List<Order> _instances = new List<Order> { };


    public Order(string name)
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }
  }
}