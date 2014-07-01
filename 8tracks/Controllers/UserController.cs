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
    public class UserController : Controller
    {
        //
        // GET: /User/
        Interface1 u;
        public UserController(Interface1 i)
        {
            u = i;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChangeSettings()
        {

            return View();
        }
        public void Settings(User u)
        {
            Classinterface c = new Classinterface();
            c.Settings(u);

            
        }
        public void Comments(User u)
        {
            Classinterface c = new Classinterface();
            c.Comments(u);
        }
    }
}
