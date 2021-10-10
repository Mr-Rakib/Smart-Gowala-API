using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartGowala.Business.Business.Services;
using SmartGowala.Data.Data.Context;
using SmartGowala.Data.Data.Models;

namespace SmartGowala.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        private readonly IUserRoleService _userRoleService;

        public UserRolesController(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        // GET: api/UserRoles
        [HttpGet]
        public async Task<IActionResult> GetUserRoles()
        {
            try
            {
                var userRoles = await _userRoleService.GetAllAsync();
                return Ok(userRoles);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserRole(int id)
        {
            try
            {
                var userRole = await _userRoleService.GetByIdAsync(id);
                return Ok(userRole);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

    }
}
