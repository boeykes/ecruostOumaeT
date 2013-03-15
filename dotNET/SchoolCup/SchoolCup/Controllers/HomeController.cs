using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolCup.Models.DAL;

namespace SchoolCup.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

      private EFDbContext db = new EFDbContext();

        public ActionResult Index()
        {
          var isf = db.ISFs.Single("phonenumber");
          return View(isf);
        }

    }
}
