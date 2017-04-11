using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirCorPro.Base
{
    public class CategoryLink
    {
        [Key]
        public int LinkId { get; set; }
        /// <summary>
        /// 栏目Id
        /// </summary>
        [Required]
        [Display(Name = "栏目Id")]
        public int CategoryId { get; set; }
        /// <summary>
        /// 栏目地址
        /// </summary>
        [Required]
        [DataType(DataType.Url)]
        [StringLength(500)]
        [Display(Name = "栏目地址")]
        public string Url { get; set; }
    }
}
