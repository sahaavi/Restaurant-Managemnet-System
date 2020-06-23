using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ISalesReport<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        List<TEntity> GetAllDate(DateTime date1, DateTime date2);
        List<TEntity> GetAllItem(string name);
        TEntity Get(int id);
    }
}
