using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _8tracks.Models;
using System.IO;
using System.Data.SqlClient;
namespace _8tracks.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        Interface1 u;
        public HomeController(Interface1 i)
        {
            u = i;
        }
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Signup()
        {
            return View();
        }
        public ActionResult Signin()
        {
            return View();
        }
        public ActionResult Audio()
        {
            return View();
        }
        public ActionResult Profile()
        {
            if (Session.IsNewSession)
                return View("Signin");
            else
                return View();
        }
        public ActionResult Contact()
        {
            
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        [HttpGet]
        public JsonResult checkUsername()
        {
            Signup s = new Signup();

            var uname = Request["name"];

            bool ch = s.varification(uname);
            return this.Json(ch, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Login(User u)
        {
            Classinterface c = new Classinterface();
            bool flag=c.Login(u);
            if (flag==true)
            {
                Session["key"] = "se";
               return Redirect("/Home/Profile");
            }
            else
            {
                return Redirect("/Home/Signin");
            }
        }
        public bool varification(string uname)
        {
            string conn = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Damon Salvatore\Desktop\8tracks_2014-06-07 18-16-42Z\8tracks\App_Data\Database1.mdf;Integrated Security=True";
            SqlConnection c = new SqlConnection(conn);
            c.Open();
            string q = "select * from [User] where name = '" + uname + "'";
            SqlCommand cmd = new SqlCommand(q, c);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        [HttpPost]
        public ActionResult File()
        {

            if (Request.Files.Count > 0)
            {
                Database1Entities db = new Database1Entities();
                Song s = new Song();

                var file = Request.Files[0];
                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    s.Name = fileName;
                    db.Songs.Add(s);
                    db.SaveChanges();
                    var path = Path.Combine(Server.MapPath("~/Audio/"), fileName);
                    file.SaveAs(path);
                }
                return View("Profile");

            }
            else
                return View("Profile");

        }
        public ActionResult Save(User u)
        {
            Classinterface c = new Classinterface();
            c.Save(u);
            return Redirect("/Home/Profile");
        }
        [HttpGet]
        public JsonResult search()
        {
            var nam=Request["jalebi"];
            List<Song> l = u.search(nam);
            return this.Json(l, JsonRequestBehavior.AllowGet);
        }


    }
}
