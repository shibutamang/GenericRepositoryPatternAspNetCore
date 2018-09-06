using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity: Book
    {
        private readonly ApplicationContext _dbContext;
        private DbSet<TEntity> _entities;

        public Repository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
            _entities = _dbContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public TEntity Get(long id)
        {
            return _entities.SingleOrDefault(s => s.Id == id);
        }

        public void Insert(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _entities.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _dbContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _entities.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
