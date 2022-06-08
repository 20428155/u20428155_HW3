﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20428155_HW3.Models;

namespace u20428155_HW3.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult Index()
        {     
            string[] filePaths = Directory.GetFiles(Server.MapPath("~/Media/Images"));
      
            List<FileModel> files = new List<FileModel>();
            foreach (string filePath in filePaths)
            {
                files.Add(new FileModel { FileName = Path.GetFileName(filePath) });
            }

            return View(files);
        }

        public FileResult DownloadFile(string fileName) 
        {
            //Build the File Path.

            string path = Server.MapPath("~/Media/Images/") + fileName;

            //Read the File data into Byte Array.

            byte[] bytes = System.IO.File.ReadAllBytes(path);

            //Send the File to Download.

            //The OCTET-STREAM format is used for file attachments on the Web with an
            //unknown file type. These .octet-stream files are arbitrary binary data
            //files that may be in any multimedia format.

            return File(bytes, "application/octet-stream", fileName);
        }

        public ActionResult DeleteFile(string fileName)
        {
            //Delete requires reading the files and then the allocation of a file path.
            //The file is then deleted based on the identified file path.

            string path = Server.MapPath("~/Media/Images/") + fileName;
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            System.IO.File.Delete(path);

            return RedirectToAction("Index");
        }
    }
}