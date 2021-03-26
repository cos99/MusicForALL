using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFA.Models;
using MFA.Contexts;

namespace MFA.Repositories.OrderRepository
{
    public class OrderRepository : IOrderRepository
    {
        public Context _context { get; set; }
        public OrderRepository(Context context)
        {
            _context = context;
        }
        public Order Create(Order order)
        {
            var result = _context.Add<Order>(order);
            _context.SaveChanges();
            return result.Entity;
        }
        public Order Get(int Id)
        {
            return _context.Orders.SingleOrDefault(x => x.Id == Id);
        }
        public List<Order> GetAll()
        {
            return _context.Orders.ToList();
        }
        public Order Update(Order order)
        {
            _context.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return order;
        }
        public Order Delete(Order order)
        {
            var result = _context.Remove(order);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
