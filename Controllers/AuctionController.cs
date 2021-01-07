using CarBidMVC.CarDb;
using CarBidMVC.CarLibary;
using CarBidMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CarBidMVC.Controllers
{
    public class AuctionController : Controller
    {

        private readonly ICarData CarData;
        public IEnumerable<Car> Cars { get; set; }

        public AuctionController(ICarData carData)
        {
            this.CarData = carData;
            //DbContext = new CarDBContext();
        }

        //  auction/damaged
        public IActionResult Damaged()
        {
            Cars = CarData.GetAll();
            return View(Cars);
        }

        //  auction/undamaged
        public IActionResult Undamaged()
        {
            return View();
        }
    }
}
