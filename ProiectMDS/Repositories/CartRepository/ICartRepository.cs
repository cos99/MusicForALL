using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFA.Models;

namespace MFA.Repositories.CartRepository
{
    public interface ICartRepository
    {
        List<Cart> GetAll();
        Cart Get(int Id);
        Cart Create(Cart cart);
        Cart Update(Cart cart);
        Cart Delete(Cart cart);
    }
}
