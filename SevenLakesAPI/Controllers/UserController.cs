using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SevenLakesService;

namespace SevenLakesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("GetUser")]
        public ActionResult<User> GetUser(string username)
        {
            var response = _userService.GetUser(username);
            return Ok(response);
        }

        [HttpPost]
        [Route("Login")]
        public ActionResult<string> Login([FromBody]User user)
        {
            var response = _userService.Login(user);
            return Ok(response);
        }

        [Route("ResetPassword")]
        public ActionResult<string> ResetPassword([FromBody]User user)
        {
            var response = _userService.ResetPassword(user);
            return Ok(response);
        }
    }
}
