using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LT.Microservices.Day2.ViewModels
{
    public class BookCreateViewModel
    {
        public string Title { get; set; }
        public int NPages { get; set; }
        public double Price { get; set; }
    }
}
