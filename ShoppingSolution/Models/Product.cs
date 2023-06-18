using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingSolution.Models
{
    public class Product
    {
        [Key]

        public int ProductId { get; set; }



        [Display(Name = "Name")]
        [Required(ErrorMessage = "Field Required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Field Required")]

        public string Description { get; set; }


        [Display(Name = "Price")]
        [Required(ErrorMessage = "Field Required")]
        public int Price { get; set; }






        /**** Product Category Select here ****/

        public virtual Category Category { get; set; }

        public int CategoryId { get; set; }
    }
    public class ProductList
    {

        public int ProductId { get; set; }


        public string Name { get; set; }



        public string Description { get; set; }


        public int Price { get; set; }
        public int Qty { get; set; }
    }
}