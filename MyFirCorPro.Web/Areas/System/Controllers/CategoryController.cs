using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirCorPro.Base;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirCorPro.Web.Areas.System.Controllers
{
    /// <summary>
    /// 栏目控制器
    /// </summary>
    [Area("System")]
    public class CategoryController : Controller
    {
        private MyFirCorProDbContext _dbContext;
        private CategoryService _categoryService;
        public CategoryController(MyFirCorProDbContext dbContext)
        {
            _dbContext = dbContext;
            _categoryService = new CategoryService(dbContext);
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Content("zhangsan");
        }
    }
}
