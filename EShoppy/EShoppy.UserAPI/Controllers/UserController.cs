using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.UserAPI.Services;
using EShoppy.UserAPI.Entities;
namespace EShoppy.UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        [Route("GetItem/{itemName}")]
        public IActionResult GetItem(string itemName)
        {
            try
            {
                Item item = userService.GetItem(itemName);
                return Ok(item);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);

            }
        }
        [HttpPost]
        [Route("NewOrder")]
        public IActionResult NewOrder(Order order)
        {
            try
            {
                userService.OrderItem(order);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
                
            }
        }
    }
}
