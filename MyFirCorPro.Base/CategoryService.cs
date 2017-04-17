using Microsoft.EntityFrameworkCore;
using MyFirCorPro.DataLibrary;
using MyFirCorPro.InterfaceDataLibrary;

namespace MyFirCorPro.Base
{
    /// <summary>
    /// 栏目服务类
    /// </summary>
    public class CategoryService
    {
        private InterfaceBaseRepository<Category> _baseRepository;
        public CategoryService(InterfaceBaseRepository<Category> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="id">栏目Id</param>
        /// <returns></returns>
        public Category Find(int id)
        {
            return _baseRepository.Find(m => m.CategoryId == id);
        }
    }
}
