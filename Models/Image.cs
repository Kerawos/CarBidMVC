﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBidMVC.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public Image(string url)
        {
            this.Url = url;
        }

        public Image()
        {

        }
    }
}
