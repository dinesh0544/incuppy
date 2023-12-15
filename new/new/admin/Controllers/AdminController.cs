using admin.context;
using admin.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly appdbcontext _authcontext;
        public AdminController(appdbcontext appdbcontext)
        {
            _authcontext = appdbcontext;
        }
        [HttpPost("adminlogin")]
        public async Task<IActionResult> adminlogin([FromBody] admins userobj)
        {
            if (userobj == null)
                return BadRequest();

            var user = await _authcontext.adminss.FirstOrDefaultAsync(x => x.username == userobj.username && x.password == userobj.password);
            if (user == null)
                return NotFound(new { message = "user not found!" });
            return Ok(new { message = "login sucess!" });
        }
    }
}
