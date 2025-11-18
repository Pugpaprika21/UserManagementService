using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace UserManagementService.Api.Controllers
{
    public class UserDto { }

    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("get/{id?}")]
        public ActionResult<UserDto> GetDetail(int? id)
        {
            return Ok(new UserDto());
        }
    }
}
