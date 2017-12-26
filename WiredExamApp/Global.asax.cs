using System.Data.Entity;
using AutoMapper;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WiredExamApp.App_Start;
using WiredExamApp.Persistence.Migrations;
using WiredExamApp.Persistence.Model;

namespace WiredExamApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ApplicationDbContext>());
            GlobalConfiguration.Configure(WebApiConfig.Register);
            Mapper.Initialize(c => c.AddProfile<MappingProfile>());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
