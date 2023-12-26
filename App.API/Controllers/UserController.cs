using App.BUSINESS.DTOs.AppUser;
using App.BUSINESS.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromForm] AppUserDto appUserDto)
        {
            var result = await _userService.RegisterUserAsync(appUserDto);

            if (result.Succeeded)
            {
                return Ok("Registration successful");
            }

            return BadRequest(result.Errors);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromForm] AppUserLoginDto appUserLoginDto)
        {
            var result = await _userService.LoginAsync(appUserLoginDto);

            if (result.Succeeded)
            {
                return Ok("Login successful");
            }

            return Unauthorized("Invalid username or password");
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await _userService.LogoutAsync();
            return Ok("Logout successful");
        }
    }
}
