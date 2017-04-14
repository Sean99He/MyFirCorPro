using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirCorPro.Models
{
    /// <summary>
    /// 栏目类型 created by Sean.He 2017-04-11 09:30:16
    /// </summary>
    public enum CategoryType
    {
        [Display(Name = "常规栏目")]
        General,
        [Display(Name = "单页栏目")]
        Page,
        [Display(Name = "链接栏目")]
        Link
    }
}
