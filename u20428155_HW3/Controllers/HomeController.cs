using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u20428155_HW3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string radioButton, HttpPostedFileBase file)
        {
            if(radioButton == "Image")
            {
                if (file != null && file.ContentLength > 0)
                {
                    // extracting the filename

                    var fileName = Path.GetFileName(file.FileName);

                    // store the file inside ~/Media/Image folder

                    var path = Path.Combine(Server.MapPath("~/Media/Images"), fileName);

                    // The chosen default path for saving

                    file.SaveAs(path);
                }
            }
            if (radioButton == "Video")
            {

                if (file != null && file.ContentLength > 0)
                {
                    // extracting the the filename

                    var fileName = Path.GetFileName(file.FileName);

                    // store the file inside ~/Media/Videos folder

                    var path = Path.Combine(Server.MapPath("~/Media/Videos"), fileName);

                    // The chosen default path for saving

                    file.SaveAs(path);
                }
            }
            if (radioButton == "Document")
            {

                if (file != null && file.ContentLength > 0)
                {
                    // extracting the filename

                    var fileName = Path.GetFileName(file.FileName);

                    // store the file inside ~/Media/Documents folder

                    var path = Path.Combine(Server.MapPath("~/Media/Documents"), fileName);

                    // The chosen default path for saving

                    file.SaveAs(path);
                }
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}