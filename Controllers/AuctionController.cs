using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBidMVC.Controllers
{
    public class AuctionController : Controller
    {
        //  auction/damaged
        public IActionResult Damaged()
        {
            return View();
        }

        //  auction/undamaged
        public IActionResult Undamaged()
        {
            return View();
        }
    }
}
