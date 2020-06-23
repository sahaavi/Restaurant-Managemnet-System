using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IInventory<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        List<TEntity> GetAllItem(string name);
        TEntity Get(int id);
        int Insert(TEntity entity);
        int Update(TEntity entity);
    }
}
