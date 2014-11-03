using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CustomAttributeBinding.Binders;
using CustomAttributeBinding.Models;

namespace CustomAttributeBinding
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {            
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ModelBinders.Binders.Add(typeof(CustomAttributeValueViewModel), new CustomAttributeValueModelBinder());
        }
    }
}