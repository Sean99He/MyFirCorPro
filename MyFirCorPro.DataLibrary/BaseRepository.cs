using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirCorPro.DataLibrary
{
    /// <summary>
    /// 仓储基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseRepository<T> where T : class
    {
        private DbContext _dbContext;
        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>实体</returns>
        public T Find(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }
    }
}
