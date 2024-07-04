using HubService.Api.Controllers.Base;
using HubService.Api.Service;
using HubService.Data.EntityModel;
using Microsoft.AspNetCore.Mvc;

namespace HubService.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : DataApiBaseController<User, UserService>
    {
        public UserController(UserService service, ILogger<UserController> logger) : base(service, logger)
        {
        }
        
    }
}

