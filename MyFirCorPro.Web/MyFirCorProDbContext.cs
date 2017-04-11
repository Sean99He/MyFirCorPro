using Microsoft.EntityFrameworkCore;
using MyFirCorPro.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirCorPro.Web
{
    public class MyFirCorProDbContext:DbContext
    {
        public DbSet<Category> Categorys { get; set; }
        public MyFirCorProDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
