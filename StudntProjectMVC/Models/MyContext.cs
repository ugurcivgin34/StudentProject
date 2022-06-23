using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudntProjectMVC.Models
{
    public class MyContext:DbContext
    {
        public MyContext():base("name=MyContext")
        {

        }

        public virtual DbSet<Student> Students { get; set; }
    }
}