using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFA.Models;
using MFA.Contexts;

namespace MFA.Repositories.OrderDetailRepository
{
    public class OrderDetailRepository: IOrderDetailRepository
    {
        public Context _context { get; set; }
        public OrderDetailRepository(Context context)
        {
            _context = context;
        }
        public OrderDetail Create(OrderDetail orderDetail)
        {
            var result = _context.Add<OrderDetail>(orderDetail);
            _context.SaveChanges();
            return result.Entity;
        }
        public OrderDetail Get(int Id)
        {
            return _context.OrderDetails.SingleOrDefault(x => x.Id == Id);
        }
        public List<OrderDetail> GetAll()
        {
            return _context.OrderDetails.ToList();
        }
        public OrderDetail Update(OrderDetail orderDetail)
        {
            _context.Entry(orderDetail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return orderDetail;
        }
        public OrderDetail Delete(OrderDetail orderDetail)
        {
            var result = _context.Remove(orderDetail);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
