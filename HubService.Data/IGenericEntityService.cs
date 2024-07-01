using HubService.Data.EntityModel;

namespace HubService.Data
{
    public interface IGenericEntityService<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Update(T item);
        T Add(T item);
        T Delete(int id);
    }
}

