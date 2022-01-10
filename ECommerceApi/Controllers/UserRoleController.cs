using ECommerceBusinnes.Abstract;
using ECommerceEntities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        readonly IUserRoleServices _userRoleServices;
        public UserRoleController(IUserRoleServices userRoleServices)
        {
            _userRoleServices = userRoleServices;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(UserRole  userRole)
        {
            await _userRoleServices.CreateRole(userRole);
            return Ok();
        }
    }
}
