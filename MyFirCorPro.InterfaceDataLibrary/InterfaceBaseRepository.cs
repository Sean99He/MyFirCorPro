using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyFirCorPro.InterfaceDataLibrary
{
    public interface InterfaceBaseRepository<T> where T : class
    {
        T Find(Expression<Func<T, bool>> predicate);
    }
}
