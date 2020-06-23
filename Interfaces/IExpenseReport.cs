using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IExpenseReport<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        List<TEntity> GetAllDate(DateTime date1, DateTime date2);
        List<TEntity> GetAllItem(string name);
        TEntity Get(int id);
        int Update(TEntity entity);
    }
}
