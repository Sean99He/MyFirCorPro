using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirCorPro.Models
{
    public class CategoryPage
    {
        [Key]
        public int PageId { get; set; }
        [Required]
        [Display(Name = "栏目Id")]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(10000)]
        [Display(Name = "栏目内容")]
        public string Content { get; set; }
        [Required]
        [StringLength(200)]
        [Display(Name = "栏目视图")]
        public string View { get; set; }
        /// <summary>
        /// 栏目
        /// </summary>
        public virtual Category Category { get; set; }
        public CategoryPage()
        {
            View = "Index";
        }
    }
}
