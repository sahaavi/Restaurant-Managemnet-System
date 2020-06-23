using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface PInterfce<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        
        List<TEntity> GetById(int id, DateTime Date1, DateTime Date2);
       
        TEntity Get(string name);
        int Insert(TEntity entity);
        int Update(TEntity entity);
        //int Delete(int id);
    }
}
