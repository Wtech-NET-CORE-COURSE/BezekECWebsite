using ECommerceBusinnes.Abstract;
using ECommerceEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _context;
        //private readonly UserManager<User> _userManager;
        public UserController(IUserServices context)
        {
            _context = context;
           // _userManager = userManager;
        }
        //www.geldigitti.com/api/user/create
        [HttpPost("[action]")]
        public async Task<User> Create([FromBody] User user)
        {
            await _context.CreateUser(user);

            return user;
        }
        //[HttpPost("[action]")]
        //public async Task RoleAssign(int id)
        //{
        //    Users user = await _userManager.FindByIdAsync(id.ToString());

        //    await _userManager.AddToRoleAsync(user, "Administrator");
        //    await _userManager.AddToRoleAsync(user, "Moderator");
        //    await _userManager.AddToRoleAsync(user, "Editor");
        //    await _userManager.AddToRoleAsync(user, "tor");

        //}
    }
}
