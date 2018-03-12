using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Domain.Contract.Repositories
{
    public interface IBaseRepositpry<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Find(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
