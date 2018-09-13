using GenericRepositoryPatternAspNetCore;
using GenericRepositoryPatternAspNetCore.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity: class
    {
        private readonly ApplicationContext _dbContext;

        public Repository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            var items = await _dbContext.Set<TEntity>().ToListAsync();
            return items;
        }

        public async Task<TEntity> Get(int id)
        {
            var result = await _dbContext.Set<TEntity>().FindAsync(id);
            return result;
        }

        public async Task Insert(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            await _dbContext.Set<TEntity>().AddAsync(entity);
        }

        public async Task Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public async Task Delete(TEntity entity)
        {
             _dbContext.Set<TEntity>().Remove(entity);
        }

        public async Task SaveChange()
        {
            await _dbContext.SaveChangesAsync();
        }

    }
}
