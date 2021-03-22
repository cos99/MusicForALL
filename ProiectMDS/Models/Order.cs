using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFA.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Date { get; set; }
        public virtual User User { get; set; }
    }
}
