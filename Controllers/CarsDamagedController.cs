using CarBidMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBidMVC.Controllers
{
    public class CarsDamagedController : Controller
    {
        //GET: CarsDamaged/Auction
        public IActionResult Auction()
        {
            var Car = new Car(1, "Clio");
            return View(Car);
        }
    }
}
