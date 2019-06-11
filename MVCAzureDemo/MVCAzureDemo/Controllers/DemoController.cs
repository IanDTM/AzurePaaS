using System.Web.Configuration;
using System.Web.Mvc;
using MVCAzureDemo.Models;

namespace MVCAzureDemo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            DemoData data = new DemoData();

            data.ApplicationName = WebConfigurationManager.AppSettings["ApplicationDemoName"];

            return View(data);
        }
    }
}