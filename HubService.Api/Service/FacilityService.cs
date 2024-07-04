using HubService.Data;
using HubService.Data.EntityModel;

namespace HubService.Api.Service
{
	public class FacilityService : GenericEntityService<Facility>
	{
		public FacilityService(ApplicationDbContext dbContext) : base(dbContext)
		{

		}

	}

}


