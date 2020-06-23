using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICategoryList<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity Get(int id);
        //int GetIdByName(string name);
        int Insert(TEntity entity);
        int Update(TEntity entity);
    }
}
