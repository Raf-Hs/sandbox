using Microsoft.AspNetCore.Mvc;
using Sandbox.Mvc.Models;

namespace Sanbox.Mvc.Controllers;

public class ProductController : Controller{
    public IActionResult Details()
    {
        var product = new Product
        {
          Name = "Teclado",
          Price = 100m  
        };

        return View(product);
    }

}