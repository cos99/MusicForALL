﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFA.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
    }
}
