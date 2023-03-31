using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ProductItem
    {
        public ProductItem()
        {
            IsActive = true;
            IsPublic = true;
           
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string TypeProduct { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }   
        public decimal Cost { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }
    }
}
