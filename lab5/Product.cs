using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab5
{
    public class Product
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ImageUrl { get; set; }
        public int Id { get; set; }
    }
}