using MyFirCorPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MyFirCorPro.DataLibrary
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(DbContext dbContext) : base(dbContext)
        {
        }
        public override Category Find(Expression<Func<Category, bool>> predicate)
        {
            return _dbContext.Set<Category>().Include(m => m.General).Include(m => m.Page).Include(m => m.Link).SingleOrDefault(predicate);
        }
    }
}
