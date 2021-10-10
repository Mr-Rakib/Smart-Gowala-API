using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartGowala.Business.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartGowala.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionTrackerController : ControllerBase
    {
        private IActionTrackerService _actionTrackerService;

        public ActionTrackerController(IActionTrackerService actionTrackerService)
        {
            _actionTrackerService = actionTrackerService;
        }
        // GET: api/UserRoles
        [HttpGet]
        public async Task<IActionResult> GetUserRoles()
        {
            try
            {
                var trackers = await _actionTrackerService.GetAllAsync();
                return Ok(trackers);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserRole(int id)
        {
            try
            {
                var tracker = await _actionTrackerService.GetByIdAsync(id);
                return Ok(tracker);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
