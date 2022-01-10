using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class CreateUserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetById() 
        {
            return Ok();
        }

        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] LoginModel loginModel)
        {
            // Na verdade aqui vai ser retornado o token jwt
            return NoContent();
        }
    }
}
