using System;
using HubService.Data.EntityModel;

namespace HubService.Data
{
    public class GenericEntityService<T> : IGenericEntityService<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext _dbContext;
        public GenericEntityService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return _dbContext.Find<T>(id);
        }
        public T Update(T item)
        {
            item.Modified = DateTime.Now;
            var entity = _dbContext.Update<T>(item)?.Entity;
            _dbContext.SaveChanges();
            return entity;
        }
        public T Add(T item)
        {
            item.Id = 0;
            item.Created = DateTime.Now;
            var entity = _dbContext.Add<T>(item)?.Entity;
            _dbContext.SaveChanges();
            return entity;
        }
        public T Delete(int id)
        {
            var entity = _dbContext.Remove<T>(_dbContext.Find<T>(id))?.Entity;
            _dbContext.SaveChanges();
            return entity;
        }
    }
}

