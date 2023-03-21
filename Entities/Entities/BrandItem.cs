using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class BrandItem
    {
        public BrandItem()
        { 
            IsActive = true;
        }
           
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string Contact { get; set; }
    }
}
