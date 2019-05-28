using System.IO;
using CsvHelper;
using DotIt.AutoPicker.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace DotIt.AutoPicker.Controllers
{
    public class AdminController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public static bool allowaccess = false;
        public AdminController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult Login(AdminModel objModel)
        {
            TextReader reader = new StreamReader(_hostingEnvironment.WebRootPath + Constant.AdminCredentialsPath);
            var CSVReader = new CsvReader(reader);
            var records = CSVReader.GetRecords<AdminModel>();
            foreach (var credential in records)
            {
                if (objModel.Username == credential.Username)
                {
                    if (objModel.Password == credential.Password)
                    {
                        allowaccess = true;
                        return Json("success");
                    }
                    else
                    {
                        ViewBag.LoginResponse = "Invalid Password";
                        return Json("password wrong");
                    }
                }
            }
            ViewBag.LoginResponse = "Invalid UserName";
            return Json("username wrong");
        }
        public ActionResult Home()
        {
            if (allowaccess == true)
            {
                allowaccess = false;
                return View();
            }
            else
            {
                return View("Index");
            }
        }
    }
}