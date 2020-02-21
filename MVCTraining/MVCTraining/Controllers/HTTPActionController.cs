using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTraining.Controllers
{
    public class HTTPActionController : Controller
    {
        // GET: HTTPAction
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost,ActionName("Index")]
        public ActionResult PostAction(string name)
        {
            ViewBag.NameResult = "YOu Clicked Post Action" + name;
            return View("Index");
        }


        [HttpPut, ActionName("Index")]
        public ActionResult PutAction(string name)
        {
            
            ViewBag.NameResult = "YOu Clicked Put Action " + name;
            return View("Index");
        }

        [HttpDelete]
        public ActionResult DeleteAction()
        {
            return View("Index");
        }

        [HttpHead]
        public ActionResult HeadAction()
        {
            return View("Index");
        }

        [HttpOptions]
        public ActionResult OptionsAction()
        {
            return View("Index");
        }

        [HttpPatch]
        public ActionResult PatchAction()
        {
            return View("Index");
        }
    }
}