using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_MVC_Repository_UOW.Models
{
    public class UserStories
    {
        public int UserStoryID { get; set; }
        public string Story {get; set;}
        public int ProjectID {get; set;}
    }
}