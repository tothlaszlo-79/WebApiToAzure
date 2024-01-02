using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiToAzure.Data;
using WebApiToAzure.Repository;
using WebApiToAzure.Models;
using WebApiToAzure.DTO;


namespace WebApiToAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController() {
            if (UserRepo._Users.Count() == 0)
            {
                AddUsers.AddTestUsers();
            }
            else { return; }
        }

        [HttpPost(Name ="Login")]
        public IActionResult Login(LoginModel user)
        {
            var _result = UserRepo._Users.FirstOrDefault(u => u.Name == user.UID && u.Password == user.PWD);

            if (_result == null) { 
                return NotFound(new { message = "Username or password is incorrect" });
            }

            else
            {
                return Ok(_result);

            }
        }

        [HttpGet] 
        public IActionResult GetAll() {

            return Ok(UserRepo._Users.ToList());
        }
        


    }
}
