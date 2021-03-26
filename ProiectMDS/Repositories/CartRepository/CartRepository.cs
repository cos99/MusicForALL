using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFA.Models;
using MFA.Contexts;

namespace MFA.Repositories.CartRepository
{
    public class CartRepository : ICartRepository
    {
        public Context _context { get; set; }
        public CartRepository(Context context)
        {
            _context = context;
        }
        public Cart Create(Cart cart)
        {
            var result = _context.Add<Cart>(cart);
            _context.SaveChanges();
            return result.Entity;
        }
        public Cart Get(int Id)
        {
            return _context.Carts.SingleOrDefault(x => x.Id == Id);
        }
        public List<Cart> GetAll()
        {
            return _context.Carts.ToList();
        }
        public Cart Update(Cart cart)
        {
            _context.Entry(cart).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return cart;
        }
        public Cart Delete(Cart cart)
        {
            var result = _context.Remove(cart);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
