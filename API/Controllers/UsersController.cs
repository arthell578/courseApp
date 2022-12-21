using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public UsersController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _dataContext.Users.ToList();
            return users;
        } 

        [HttpGet("{id}")]
        public ActionResult<User> GetUserByID(int id)
        {
            var user = _dataContext.Users.FirstOrDefault(u => u.Id == id);
            return user;
        }

    }
}