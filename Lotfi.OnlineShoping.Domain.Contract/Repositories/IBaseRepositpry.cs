using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Domain.Contract.Repositories
{
    public interface IBaseRepositpry<TEntity>
    {
        void Insert(TEntity entity);
        TEntity Find(int id);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
