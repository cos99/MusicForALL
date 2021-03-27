using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MFA.Models;
using MFA.DTOs;
using MFA.Repositories.CartRepository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MFA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        public ICartRepository iCartRepository { get; set; }
        public CartController(ICartRepository repository)
        {
            iCartRepository = repository;
        }
        // GET: api/<CartController>
        [HttpGet]
        public ActionResult<IEnumerable<Cart>> Get()
        {
            return iCartRepository.GetAll();
        }

        // GET api/<CartController>/5
        [HttpGet("{id}")]
        public ActionResult<Cart> Get(int id)
        {
            return iCartRepository.Get(id);
        }


        // POST api/<CartController>
        [HttpPost]
        public Cart Post(CartDTO value)
        {
            Cart model = new Cart()
            {
                Quantity = value.Quantity,
                UserId = value.UserId,
                ProductId = value.ProductId

            };
            return iCartRepository.Create(model);
        }


        // PUT api/<CartController>/5
        [HttpPut("{id}")]
        public Cart Put(int id, CartDTO value)
        {
            Cart model = iCartRepository.Get(id);
            if (value.Quantity != 0)
            {
                model.Quantity = value.Quantity;
            }
            if (value.UserId != 0)
            {
                model.UserId = value.UserId;
            }
            if (value.ProductId != 0)
            {
                model.ProductId = value.ProductId;
            }
            return iCartRepository.Update(model);
        }

        // DELETE api/<CartController>/5
        [HttpDelete("{id}")]
        public Cart Delete(int id)
        {
            Cart cart = iCartRepository.Get(id);
            return iCartRepository.Delete(cart);
        }
    }
}
