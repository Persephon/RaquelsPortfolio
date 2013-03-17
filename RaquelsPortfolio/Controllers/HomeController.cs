using System.Web.Mvc;

namespace RaquelsPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("~/pages/home/home.html");
        }

    }
}
