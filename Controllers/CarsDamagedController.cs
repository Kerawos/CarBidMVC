using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBidMVC.Controllers
{
    public class CarsDamagedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
