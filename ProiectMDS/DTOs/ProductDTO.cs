using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFA.DTOs
{
    public class ProductDTO
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }
}
