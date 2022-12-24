using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly DataContext _dataContext;
        public AccountController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost("register")] // api/account/register
        public async Task<ActionResult<User>> Register(string username, string password)
        {
            using var hmac = new HMACSHA512(); // using for automatic disposal, because one of inhereted classes implements IDisposable
            
        }
    }
}