﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace remember.Models
{
    public class Noodle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public bool IsInStock { get; set; }
    }
}
