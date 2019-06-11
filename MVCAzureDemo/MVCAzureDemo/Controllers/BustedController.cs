using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace MVCAzureDemo.Controllers
{
    public class BustedController : Controller
    {
        // GET: Busted
        public ActionResult Index()
        {

            Trace.WriteLine("Calling Sub Function");

            string name = SubFunction("random thought");

            ViewBag.Message = "Hello " + name;
            return View();
        }

        private string SubFunction(string uselessString)
        {
            string stringVar = "This is a value that can be checked in debugger";
            string message = "We are about to throw the exception" + uselessString;

            int checkError = 11;

            Trace.WriteLine(message);
            if (checkError > 0 && stringVar.Length > 5)
            {
                throw new Exception("This method throws an exception so we can see it in App Insights");
            }

            return message;
        }
    }
}