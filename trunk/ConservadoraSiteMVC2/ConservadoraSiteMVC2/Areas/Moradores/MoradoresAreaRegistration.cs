using System.Web.Mvc;

namespace ConservadoraSiteMVC2.Areas.Moradores
{
    public class MoradoresAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Moradores";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Moradores_default",
                "Moradores/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
