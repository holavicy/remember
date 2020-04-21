using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace remember.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="请留下你的名字")]
        [StringLength(50, ErrorMessage ="名字不能超过20个字")]
        public string Name { get; set; }

        [Required(ErrorMessage = "请留下你的邮箱")]
        [StringLength(50, ErrorMessage = "名字不能超过20个字")]
        public string Email { get; set; }

   
        public DateTime CreateDateUTC { get; set; }

        [Required(ErrorMessage = "请留下你的评价")]
        [StringLength(200, ErrorMessage = "名字不能超过100个字")]
        public string Message { get; set; }
    }
}
