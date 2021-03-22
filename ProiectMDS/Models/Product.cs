using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFA.Models
{
    public class Product
    {
        public int Id { get; set; }
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }

    }
}
