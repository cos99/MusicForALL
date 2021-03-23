using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFA.DTOs
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
    }
}
