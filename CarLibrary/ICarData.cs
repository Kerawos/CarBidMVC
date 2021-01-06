using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBidMVC.Models
{
    interface ICarData
    {
        IEnumerable<Car> GetAll();
        IEnumerable<Car> GetAllByName(string name);
        Car GetByID(int id);
    }
}
