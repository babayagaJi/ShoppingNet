using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShoppingSolution.Models
{
    public enum Role
    {
        Customer,
        Admin
    }
    public class User
    {
        [Key]
        public int UserId { get; set; }


        [Display(Name = "Name")]
        [Required(ErrorMessage = "Field Required")]
        public string Name { get; set; }

        [Display(Name = "Role")]
        [Required(ErrorMessage = "Field Required")]
        public Role Role { get; set; }


        [Display(Name = "Email")]
        [Required(ErrorMessage = "Field Required")]
        public string Email { get; set; }


        [Display(Name = "Password")]
        [Required(ErrorMessage = "Field Required")]
        public string Password { get; set; }


    }
}