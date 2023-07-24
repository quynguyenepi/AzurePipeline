using ECM.Api.Authorization;
using ECM.Api.Models;
using ECM.Repo.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECM.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);
            if (response == null)
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }
            return Ok(response);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _userService.GetAll();
            return Ok(response);

        }
    }
}