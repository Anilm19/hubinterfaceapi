using System;
namespace HubService.Data.EntityModel
{
	public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string ContactNumber { get; set; }
        public bool Role { get; set; }
    }
}

