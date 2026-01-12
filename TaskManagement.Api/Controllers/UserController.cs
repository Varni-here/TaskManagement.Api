using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using TaskManagement.Core.Interfaces;
using TaskManagement.Core.RequestModels.Users;
using TaskManagement.Core.ResponseModels;

namespace TaskManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices) 
        { 
            _userServices = userServices;
        }

        [HttpPost] 
        public async Task<ActionResult<CoreResponse>> RegisterUser(UserDtoModel req)
        {
            CoreResponse res = new CoreResponse();
            res = await _userServices.RegisterUser(req);
            if (res.status == false)
                return BadRequest(res);
            return Ok(res);
        }
    }
}