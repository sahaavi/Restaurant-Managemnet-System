using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ILogin<TEntity> where TEntity : class
    {
        TEntity Get(int id);
    }
}
