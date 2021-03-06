﻿using Registar.Common;
using Register.Repository;
using Register.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcFirst
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            InitProjects();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
             
        }
        private void InitProjects()
        {
            //if we want to create repositoryfactory with autofac we have to use the commented lines
           // RepositoryManager.RegisterFactory(new DefaultRepositoryFactory(new BikeRepository()));
            RepositoryManager.RegisterFactory(new DefaultRepositoryFactory());
            DataContextManager.RegisterFactory(new DataContextRepositoryFactory());
        }
    }
}
