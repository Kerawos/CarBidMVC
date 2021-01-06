using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBidMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CarBidMVC.CarDb
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
    }
}
