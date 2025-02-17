﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFA.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}
