using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class Info
    {
        public int Id { get; set; }
        [Display(Name = "姓名")]
        [Required(ErrorMessage = "必須輸入姓名")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "最少需要2個字元")]
        public string Name { get; set; }
        [Display(Name = "手機")]
        [RegularExpression(@"^\d{4}\-?\d{3}\-?\d{3}$", ErrorMessage = "格式需為09xx-xxx-xxx")]
        [Required(ErrorMessage = "必須輸入手機號碼")]
        public string Phone { get; set; }
        [Display(Name = "Email信箱")]
        [Required(ErrorMessage = "必須輸入Email信箱帳號")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "性別")]
        [Required(ErrorMessage = "必須輸入性別")]
        public string Gender { get; set; }
        
    }
}