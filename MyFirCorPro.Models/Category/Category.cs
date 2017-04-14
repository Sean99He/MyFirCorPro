using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirCorPro.Models
{
    /// <summary>
    /// 栏目模型
    /// </summary>
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        /// <summary>
        /// 栏目名称
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// 栏目类型
        /// </summary>
        [Required]
        [Display(Name = "栏目类型")]
        public CategoryType Type { get; set; }
        /// <summary>
        /// 上级栏目Id 0表示根目录
        /// </summary>
        [Required]
        [Display(Name = "上级栏目")]
        public int ParentId { get; set; }
        /// <summary>
        /// 排序 数字越小越靠前
        /// </summary>
        [Required]
        [Display(Name = "排序")]
        public int Order { get; set; }
        /// <summary>
        /// 打开目标
        /// </summary>
        [Required]
        [StringLength(20)]
        [Display(Name = "打开目标")]
        public string Target { get; set; }
        /// <summary>
        /// 栏目说明
        /// </summary>
        [Required]
        [StringLength(1000)]
        [Display(Name = "栏目说明")]
        public string Description { get; set; }
        /// <summary>
        /// 常规栏目
        /// </summary>
        public virtual CategoryGeneral General { get; set; }
        /// <summary>
        /// 单页栏目
        /// </summary>
        public virtual CategoryPage Page { get; set; }
        /// <summary>
        /// 连接栏目
        /// </summary>
        public virtual CategoryLink Link { get; set; }
    }
}
