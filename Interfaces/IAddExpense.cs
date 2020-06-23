using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IAddExpense<TEntity> where TEntity : class
    {
        int Insert(TEntity entity);
    }
}
