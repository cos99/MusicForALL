using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MFA.Models;
using MFA.Repositories.CategoryRepository;
using MFA.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MFA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public ICategoryRepository iCategoryRepository { get; set; }

        public CategoryController(ICategoryRepository repository)
        {
            iCategoryRepository = repository;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get()
        {
            return iCategoryRepository.GetAll();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public ActionResult<Category> Get(int id)
        {
            return iCategoryRepository.Get(id);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public Category Post(CategoryDTO value)
        {
            Category model = new Category()
            {
                Name = value.Name,
            };
            return iCategoryRepository.Create(model);
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public Category Put(int id, CategoryDTO value)
        {
            Category model = iCategoryRepository.Get(id);
            if (value.Name != null)
            {
                model.Name = value.Name;
            }
            return iCategoryRepository.Update(model);
        }
        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public Category Delete(int id)
        {
            Category category = iCategoryRepository.Get(id);
            return iCategoryRepository.Delete(category);
        }
    }
}
