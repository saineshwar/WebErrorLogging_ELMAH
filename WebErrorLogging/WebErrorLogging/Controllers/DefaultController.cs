using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebErrorLogging.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception)
            {
                throw;
            }

            return View();
        }
    }
}