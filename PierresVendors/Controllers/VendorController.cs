
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierresVendors.Models;

namespace PierresVendors.Controllers
{
  public class VendorsControllers : Controller
  {
    [HttpGet("/Vendors/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}