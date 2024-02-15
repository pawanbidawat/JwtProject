using JwtProject.Interfaces;
using JwtProject.Models;
using JwtProject.Request_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JwtProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService; 
        }
      

        // POST api/<AuthController>
        [HttpPost]
        public string Login ([FromBody] LoginRequest Logindata)
        {
            var res = _authService.Login(Logindata);
            return res;
        }

       
        [HttpPost("AddUser")]
        public User AddUser( [FromBody] User value)
        {
            var user = _authService.AddUser(value);
            return user;
        }

     
      
    }
}
