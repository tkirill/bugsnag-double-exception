using System.Web.Mvc;

namespace DoubleException
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        [Route]
        public ViewResult Index()
        {
            return View();
        }

        [Route("Exception")]
        public ActionResult Exception()
        {
            throw new System.NotImplementedException();
        }
    }
}