using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFA.Models;

namespace MFA.Repositories.OrderDetailRepository
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> GetAll();
        OrderDetail Get(int Id);
        OrderDetail Create(OrderDetail orderDetail);
        OrderDetail Update(OrderDetail orderDetail);
        OrderDetail Delete(OrderDetail orderDetail);
    }
}
