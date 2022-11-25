using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaUygulamasi.Models
{
    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public double Price { get; set; } 
    }
}
