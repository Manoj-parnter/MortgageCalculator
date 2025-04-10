using System.Web.Mvc;
using System.Web.Routing;
using MortgageCalculator.Data;
using MortgageCalculator.Dto.Interfaces;
using MortgageCalculator.Dto.Repos;
using Unity.Injection;
using Unity.Mvc5;
using Unity;
using Microsoft.EntityFrameworkCore;

namespace MortgageCalculator.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Dependency Injection setup
            var container = new UnityContainer();

            // Correct Registration
            container.RegisterType<IMortgage, MortgageRepos>();
            container.RegisterType<MortgageDataContext>(); // Ensure DbContext is registered

            container.RegisterType<MortgageDataContext>(new InjectionFactory(c =>
            {
                var optionsBuilder = new DbContextOptionsBuilder<MortgageDataContext>();
                optionsBuilder.UseSqlServer("Data Source=172.25.17.47;Initial Catalog=MANOJ_IDB;User ID=manoj;Password=D0tnet@24!;connect timeout=0;Max Pool Size=20000;");
                return new MortgageDataContext(optionsBuilder.Options);
            }));

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
