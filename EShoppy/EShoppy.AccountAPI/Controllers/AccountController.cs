using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.AccountAPI.Services;
using EShoppy.AccountAPI.Entities;
using EShoppy.AccountAPI.Model;
namespace EShoppy.AccountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService userService;

        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(User user)
        {
            try
            {
                userService.Register(user);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
               
            }
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(Login login)
        {
            try
            {
                User user=userService.Login(login);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);

            }
        }
    }
}
