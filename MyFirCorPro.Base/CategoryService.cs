using Microsoft.EntityFrameworkCore;
using MyFirCorPro.DataLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirCorPro.Base
{
    /// <summary>
    /// 栏目服务类
    /// </summary>
    public class CategoryService
    {
        private BaseRepository<Category> _baseRepository;
        public CategoryService(DbContext dbContext)
        {
            _baseRepository = new BaseRepository<Category>(dbContext);
        }
        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="id">栏目Id</param>
        /// <returns></returns>
        public Category Find(int id)
        {
            return _baseRepository.Find(id);
        }
    }
}
