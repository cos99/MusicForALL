using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MFA.Models;
using MFA.Repositories.OrderDetailRepository;
using MFA.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MFA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        public IOrderDetailRepository iOrderDetailRepository { get; set; }
        public OrderDetailController(IOrderDetailRepository repository)
        {
            iOrderDetailRepository = repository;
        }
        // GET: api/<OrderDetailController>
        [HttpGet]
        public ActionResult<IEnumerable<OrderDetail>> Get()
        {
            return iOrderDetailRepository.GetAll();
        }

        // GET api/<OrderDetailController>/5
        [HttpGet("{id}")]
        public ActionResult<OrderDetail> Get(int id)
        {
            return iOrderDetailRepository.Get(id);
        }

        // POST api/<OrderDetailController>
        [HttpPost]
        public OrderDetail Post(OrderDetailDTO value)
        {
            OrderDetail model = new OrderDetail()
            {
                OrderId = value.OrderId,
                ProductId = value.ProductId,
                Price = value.Price,
                Quantity = value.Quantity,

            };
            return iOrderDetailRepository.Create(model);
        }

        // PUT api/<OrderDetailController>/5
        [HttpPut("{id}")]
        public OrderDetail Put(int id, OrderDetailDTO value)
        {
            OrderDetail model = iOrderDetailRepository.Get(id);
            if (value.OrderId != 0)
            {
                model.OrderId = value.OrderId;
            }
            if (value.ProductId != 0)
            {
                model.ProductId = value.ProductId;
            }
            if (value.Price != 0)
            {
                model.Price = value.Price;
            }
            if (value.Quantity != 0)
            {
                model.Quantity = value.Quantity;
            }
            return iOrderDetailRepository.Update(model);
        }

        // DELETE api/<OrderDetailController>/5
        [HttpDelete("{id}")]
        public OrderDetail Delete(int id)
        {
            OrderDetail orderDetail = iOrderDetailRepository.Get(id);
            return iOrderDetailRepository.Delete(orderDetail);
        }
    }
}
