using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using System.Reflection;
using System.Data.Entity;
using System.Configuration;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using LMS.Models;
using LMS.Controllers;
using LMS.DataAccess.Entities;
using LMS.DataAccess.Repositories;
using LMS.DataAccess.DataAccessLayer;
using DataAccess;

namespace LMS
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);            
        }       
    }
}
