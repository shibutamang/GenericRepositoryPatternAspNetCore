using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Data.Repository
{
    public interface IRepository<TEntity> where TEntity: Book
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(long id);
    }
}
