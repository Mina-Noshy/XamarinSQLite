using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDApplication.Repository
{
    public interface IAppRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Search(string txt);
        int Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
    }
}
