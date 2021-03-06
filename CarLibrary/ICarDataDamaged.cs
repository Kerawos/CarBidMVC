﻿using CarBidMVC.CarLibary;
using CarBidMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBidMVC.CarLibrary
{
    public interface ICarDataDamaged : ICarData
    {
        IEnumerable<Car> GetAllDamaged();
        IEnumerable<Car> GetAllDamagedByName(string name);
    }
}
