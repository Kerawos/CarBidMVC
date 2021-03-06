﻿using CarBidMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBidMVC.CarLibary
{
    public interface ICarData
    {
        IEnumerable<Car> GetAll();
        IEnumerable<Car> GetAllByName(string name);
        Car GetByID(int id);
        Car Add(Car newCar);
        Car Delete(int id);
        int Commit();
    }
}
