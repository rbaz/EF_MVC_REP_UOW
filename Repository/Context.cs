using EF_MVC_Repository_UOW.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF_MVC_Repository_UOW.Repository
{
    public class Context : DbContext
    {
        public Context(string connString)
            : base("mpDBConnection")
        {

        }
        public DbSet<Project> Projects { get; set; }
    }
}