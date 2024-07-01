using Microsoft.AspNetCore.Mvc;

namespace HubService.Api.Controllers.Base
{
    [Produces("application/json")]
    public class BaseController<TService> : Controller
    {
        public BaseController(TService service, ILogger logger)
        {
            Service = service;
            Logger = logger;
        }
        protected TService Service { get; }
        protected ILogger Logger { get; }
    }
}

