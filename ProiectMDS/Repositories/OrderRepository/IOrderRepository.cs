using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFA.Models;

namespace MFA.Repositories.OrderRepository
{
    public interface IOrderRepository
    {
        List<Order> GetAll();
        Order Get(int Id);
        Order Create(Order order);
        Order Update(Order order);
        Order Delete(Order order);
    }
}
