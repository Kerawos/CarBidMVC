using CarBidMVC.CarLibary;
using CarBidMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBidMVC.CarLibrary
{
    public interface ICarDataUndamaged : ICarData
    {
        IEnumerable<Car> GetAllDamaged();
    }
}
