using HubService.Data.EntityModel;

namespace HubService.Data
{
    public interface IGenericEntityService<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetList(int pageNumber,int pageSize,string sort,string direction);
        T GetById(int id);
        T Update(T item);
        T Add(T item);
        T Delete(int id);
    }
}

