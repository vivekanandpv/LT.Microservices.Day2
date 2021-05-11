﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LT.Microservices.Day2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int NPages { get; set; }
        public double Price { get; set; }
    }
}
