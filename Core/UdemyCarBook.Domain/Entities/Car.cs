﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class Car
    {
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public Brand  Brand { get; set; }
        public string Model { get; set; }
        public string CarImageUrl { get; set; }
        public string Km { get; set; }
        public string Transmission { get; set; }
        public byte seat { get; set; }
        public byte LUggage { get; set; }
        public string Fuel { get; set; }
        public string BigImageUrl{ get; set; }
        public List<CarFeature> CarFeatures { get; set; }
        public List<CarDescription> CarDescriptions { get; set; }
        public List<CarPricing> CarPricings { get; set; }
    }
}
