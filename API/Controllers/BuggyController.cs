using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    // returning https reponses to the clients
    public class BuggyController : BaseApiController
    {
        private readonly DataContext _dataContext;
        public BuggyController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        
        [Authorize]
        [HttpGet("oauth")]
        public ActionResult<string> GetSecret(){
            return "secret text";
        }
        
        [Authorize]
        [HttpGet("not-found")]
        public ActionResult<User> GetNotFound(){
            var thing = _dataContext.Users.Find(-1);

            if(thing == null) return NotFound();

            return thing;
        }
    }
}