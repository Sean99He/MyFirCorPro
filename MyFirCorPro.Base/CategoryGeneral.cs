using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirCorPro.Base
{
    /// <summary>
    /// 常规栏目模型
    /// </summary>
    public class CategoryGeneral
    {
        [Key]
        public int GeneralId { get; set; }
        [Required]
        [Display(Name = "栏目Id")]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(200)]
        [Display(Name = "栏目视图")]
        public string View { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "模块名称")]
        public string Module { get; set; }
        [Required]
        [StringLength(200)]
        [Display(Name ="内容视图")]
        public string ContentView { get; set; }
        [Required]
        [StringLength(200)]
        [Display(Name ="内容排序")]
        public string ContentOrder { get; set; }
        /// <summary>
        /// 栏目
        /// </summary>
        public virtual Category Category { get; set; }
    }
}
