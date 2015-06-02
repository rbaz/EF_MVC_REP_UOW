using manageProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace manageProjects.Repository
{
    public class Context : DbContext
    {
        public Context()
            : base()
        {

        }
        public DbSet<Project> Projects { get; set; }
    }
}