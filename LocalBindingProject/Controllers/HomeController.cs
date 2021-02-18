using LocalBindingProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalBindingProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var orders = GetOrders();

            return View(orders);
        }

        public IActionResult Error()
        {
            return View();
        }

        private List<OrderViewModel> GetOrders()
        {
            var result = Enumerable.Range(1, 50).Select(i => new OrderViewModel
            {
                OrderID = i,
                Freight = i * 10,
                OrderDate = new DateTime(2016, 9, 15).AddDays(i % 7),
                ShipName = "ShipName " + i,
                ShipCity = "ShipCity " + i
            }).ToList();

            return result;
        }
    }
}
