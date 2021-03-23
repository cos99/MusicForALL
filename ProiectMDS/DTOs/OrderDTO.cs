using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFA.DTOs
{
    public class OrderDTO
    {
        public int UserId { get; set; }
        public int Date { get; set; }
        public List<int> ProductId { get; set; }

    }
}
