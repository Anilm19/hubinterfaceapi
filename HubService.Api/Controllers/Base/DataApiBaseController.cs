using HubService.Data;
using HubService.Data.EntityModel;
using Microsoft.AspNetCore.Mvc;

namespace HubService.Api.Controllers.Base
{
    public class DataApiBaseController<T, TService> : BaseController<TService>
          where T : BaseEntity
          where TService : IGenericEntityService<T>
    {

        public DataApiBaseController(TService service, ILogger logger) : base(service, logger)
        {
        }

        [HttpGet("getAll")]
        public virtual IActionResult GetAll()
        {
            return Ok(Service.GetAll());
        }

        [HttpGet("{id}")]
        public virtual IActionResult Get(int id)
        {

            return Ok(Service.GetById(id));
        }


        [HttpPost("create")]
        public virtual IActionResult Post([FromBody] T item)
        {

            return Ok(Service.Add(item));
        }

        [HttpPut("update")]
        public virtual IActionResult Put([FromBody] T item)
        {
            return Ok(Service.Update(item));
        }

        [HttpDelete("{id}")]
        public virtual IActionResult Delete(int id)
        {
            Service.Delete(id);
            return Ok();
        }

        [HttpGet("getList")]
        public virtual IActionResult GetList(int pageNumber,int pageSize)
        {
            Service.GetList(pageNumber, pageSize,"","");
            return Ok();
        }
    }
}
