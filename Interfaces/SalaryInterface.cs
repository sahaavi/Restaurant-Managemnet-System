using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interfaces
{
    public interface SalaryInterface<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity Get(int id,String Month,String Year);
        int Insert(TEntity entity);
        int Update(TEntity entity);
        //int Delete(int id);
    }
}
