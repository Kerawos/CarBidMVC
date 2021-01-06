﻿using CarBidMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBidMVC
{
    public class CarBidDbContext : DbContext
    {
        public CarBidDbContext(DbContextOptions<CarBidDbContext> options) 
            : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
    }

}