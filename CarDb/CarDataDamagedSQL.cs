using CarBidMVC.CarLibrary;
using CarBidMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBidMVC.CarDb
{
    public class CarDataDamagedSQL : ICarDataDamaged
    {
        private readonly CarDbContext db;

        public CarDataDamagedSQL(CarDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetAllByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetAllDamaged()
        {
            throw new NotImplementedException();
        }

        public Car GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
