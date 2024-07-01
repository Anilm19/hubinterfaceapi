using HubService.Api.Controllers.Base;
using HubService.Api.Service;
using HubService.Data.EntityModel;
using Microsoft.AspNetCore.Mvc;

namespace HubService.Api.Controllers
{
    public class FacilityController : DataApiBaseController<Facility, FacilityService>
    {
        public FacilityController(FacilityService service, ILogger<FacilityController> logger) : base(service, logger)
        {
        }
        
    }
}

