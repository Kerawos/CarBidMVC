using CarBidMVC.CarContextDb;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CarBidMVC.Controllers
{
    public class AuctionController : Controller
    {

        private CarDBContext DbContext;

        public AuctionController()
        {
            DbContext = new CarDBContext();
        }

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
