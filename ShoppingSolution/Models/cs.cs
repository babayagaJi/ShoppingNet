using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ShoppingSolution.Models
{
    public class cs:DbContext
    {
        public DbSet<Student> students { get; set; }

        public DbSet<fee> fees { get; set; }

        public DbSet<User> users { get; set; }


        public DbSet<Product> products { get; set; }

        public DbSet<Category> categories { get; set; }


    }
}