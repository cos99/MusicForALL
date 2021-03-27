using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MFA.DTOs;
using MFA.Models;
using MFA.Repositories.ProductRepository;
using MFA.Repositories.CategoryRepository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MFA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IProductRepository iProductRepository { get; set; }
        public ProductController(IProductRepository repository)
        {
            iProductRepository = repository;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return iProductRepository.GetAll();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            return iProductRepository.Get(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public Product Post(ProductDTO value)
        {
            Product model = new Product()
            {
                Name = value.Name,
                CategoryId = value.CategoryId,
                Stock = value.Stock,
                Price = value.Price,
                Description = value.Description,
            };
            return iProductRepository.Create(model);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public Product Put(int id, ProductDTO value)
        {
            Product model = iProductRepository.Get(id);
            if (value.Name != null)
            {
                model.Name = value.Name;
            }
            if (value.CategoryId != 0)
            {
                model.CategoryId = value.CategoryId;
            }
            if (value.Stock != 0)
            {
                model.Stock = value.Stock;
            }
            if (value.Price != 0)
            {
                model.Price = value.Price;
            }
            if (value.Description != null)
            {
                model.Description = value.Description;
            }
            return iProductRepository.Update(model);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public Product Delete(int id)
        {
            Product product = iProductRepository.Get(id);
            return iProductRepository.Delete(product);
        }
    }
}
