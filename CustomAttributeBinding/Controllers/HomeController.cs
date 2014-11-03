using System.Linq;
using System.Text;
using System.Web.Mvc;
using CustomAttributeBinding.Models;

namespace CustomAttributeBinding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save(SomeEntity model)
        {
            // some logic

            return new JsonResult { Data = new { attributes = model.CustomAttributes.Select(x => x.AttributeClassType).ToArray() } };
        }
    }
}