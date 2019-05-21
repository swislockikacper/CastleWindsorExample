using CastleWindsorExample.Interfaces;
using System.Web.Mvc;

namespace CastleWindsorExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDemoService service;

        public HomeController(IDemoService service)
        {
            this.service = service;
        }

        public ActionResult Index()
            => View(service.GetMessage());
    }
}