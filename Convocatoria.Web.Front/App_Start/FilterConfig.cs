﻿using System.Web;
using System.Web.Mvc;

namespace Convocatoria.Web.Front
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
