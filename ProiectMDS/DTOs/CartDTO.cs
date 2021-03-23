using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFA.DTOs
{
    public class CartDTO
    {
        public int Quantity { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}
