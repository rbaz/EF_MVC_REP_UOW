﻿using System.Web;
using System.Web.Mvc;

namespace EF_MVC_Repository_UOW
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
