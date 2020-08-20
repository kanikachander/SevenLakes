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
        [Route("Test")]
        public ActionResult<string> TestAPI()
        {
            return Ok("test");
        }

        [HttpPost]
        [Route("Login")]
        public ActionResult<string> Login([FromBody]User user)
        {
            var response = _userService.Login(user);
            return response;
        }

        [Route("ResetPassword")]
        public ActionResult<string> ResetPassword(User user)
        {
            var response = _userService.ResetPassword(user);
            return response;
        }
    }
}