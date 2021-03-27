using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MFA.Models;
using MFA.DTOs;
using MFA.Repositories.OrderRepository;
using MFA.Repositories.UserRepository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MFA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public IOrderRepository iOrderRepository { get; set; }
        public IUserRepository iUserRepository { get; set; }

        public OrderController(IOrderRepository repository)
        {
            iOrderRepository = repository;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            return iOrderRepository.GetAll();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            return iOrderRepository.Get(id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public Order Post(OrderDTO value)
        {
            Order model = new Order()
            {
                Date = value.Date,
                UserId = value.UserId
            };
            return iOrderRepository.Create(model);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public Order Put(int id, OrderDTO value)
        {
            Order model = iOrderRepository.Get(id);
            if (value.Date != null)
            {
                model.Date = value.Date;
            }
            if (value.UserId != 0)
            {
                model.UserId = value.UserId;
            }
            return iOrderRepository.Update(model);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public Order Delete(int id)
        {
            Order order = iOrderRepository.Get(id);
            return iOrderRepository.Delete(order);
        }
    }
}
