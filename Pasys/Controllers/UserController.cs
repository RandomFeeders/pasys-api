using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pasys.Models;

namespace Pasys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UserModel>> FetchAllUsers()
        {
            return Ok();
        }
    }
}
