using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using System.Web.SessionState;
using ToDoApp.Data;
using ToDoApp.Web.App_Start;

namespace ToDoApp.Web
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Database.SetInitializer<ToDoStoreContext>(new MigrateDatabaseToLatestVersion<ToDoStoreContext, ToDoApp.Data.Migrations.Configuration>());

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}