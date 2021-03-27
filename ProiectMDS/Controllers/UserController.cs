using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MFA.Models;
using MFA.Repositories.UserRepository;
using MFA.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MFA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUserRepository iUserRepository { get; set; }

        public UserController(IUserRepository repository)
        {
            iUserRepository = repository;
        }

        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return iUserRepository.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return iUserRepository.Get(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public User Post(UserDTO value)
        {
            User model = new User()
            {
                Name = value.Name,
                Username = value.Username,
                Password = value.Password,
                PhoneNumber = value.PhoneNumber,
                Email = value.Email,
                Adresa = value.Adresa,
            };
            return iUserRepository.Create(model);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public User Put(int id, UserDTO value)
        {
            User model = iUserRepository.Get(id);
            if (value.Name != null)
            {
                model.Name = value.Name;
            }
            if (value.Username != null)
            {
                model.Username = value.Username;
            }
            if (value.Password != null)
            {
                model.Password = value.Password;
            }
            if (value.PhoneNumber != null)
            {
                model.PhoneNumber = value.PhoneNumber;
            }
            if (value.Email != null)
            {
                model.Email = value.Email;
            }
            if (value.Adresa != null)
            {
                model.Adresa = value.Adresa;
            }
            return iUserRepository.Update(model);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public User Delete(int id)
        {
            User user = iUserRepository.Get(id);
            return iUserRepository.Delete(user);
        }
    }
}
