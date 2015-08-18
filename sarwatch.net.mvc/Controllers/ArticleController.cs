using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SarwatchASPMVC.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Article/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {

        }
        [HttpPost]
        public ActionResult Create(Model model)
        {
            return View();
        }

    }
}
