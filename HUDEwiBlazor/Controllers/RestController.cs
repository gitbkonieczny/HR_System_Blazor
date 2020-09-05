using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HUDEwiBlazor.Data;
using Microsoft.EntityFrameworkCore;

namespace HUDEwiBlazor.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RestController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public RestController(ApplicationDBContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var emps = await _context.Employees.ToListAsync();
            return Ok(emps);
        }
    }
}
