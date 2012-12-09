using System.Web.Mvc;

namespace DependencyInversionPrinciple_WithAnIocContainer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
