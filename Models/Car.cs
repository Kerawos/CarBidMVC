using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBidMVC.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Car(int id, string title)
        {
            Id = id;
            Title = title;
        }



    }
}
