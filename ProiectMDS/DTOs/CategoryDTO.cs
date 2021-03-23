using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFA.DTOs
{
    public class CategoryDTO
    {
        public string Name { get; set; }
        public List<int> ProductId { get; set; }
    }
}
