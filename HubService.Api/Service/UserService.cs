using HubService.Data;
using HubService.Data.EntityModel;

namespace HubService.Api.Service
{
	public class UserService : GenericEntityService<User>
	{

		public UserService(ApplicationDbContext dbContext) : base(dbContext)
		{

		}

	}

}


