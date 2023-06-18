using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShoppingSolution.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }


        [Display(Name ="Name")]
        [Required(ErrorMessage ="Field Required")]
        public string Std_name { get; set; }


    }
}