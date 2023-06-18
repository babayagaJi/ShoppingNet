using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingSolution.Models
{
    public class fee
    {
        [Key]
        public int feeid { get; set; }

        public int feeamount { get; set; }

        public virtual Student student {  get; set; }

        public int StudentId { get; set; }
    }
}