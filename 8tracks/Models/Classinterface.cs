using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data.SqlClient;
using Ninject.Activation;

namespace _8tracks.Models
{

    public class Classinterface:Interface1
    {
        public void Save(User u)
        {


            Database1Entities db = new Database1Entities();
                db.Users.Add(u);
                db.SaveChanges();
            
        }
        public void Settings(User u)
        {

           string name = u.name;
           Database1Entities db = new Database1Entities();
           User user = db.Users.First(i => i.name.Equals(name));
           user.name = u.name;
           user.pass = u.pass;
           user.cpass = u.cpass;
           user.email = u.email;
           db.SaveChanges();
           

        }

        [HttpPost]
        public bool Login(User u)
        {
            string name = u.name;
            string pass = u.pass;
            Database1Entities db = new Database1Entities();
            u = db.Users.First(i => i.name.Equals(name));
            if (u.pass.Equals(pass))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public List<Song> search(string a)
        {
            using(Database1Entities db=new Database1Entities())
            {
                var q = from c in db.Songs where c.Name.Contains(a) select c;
                List<Song> l = new List<Song>();
                foreach(Song i in q)
                {
                    l.Add(i);
                }
                return l;
            }
            
        }
        public void Comments(User u)
        {
            Database1Entities d = new Database1Entities();
            string name = u.name;
            User user = d.Users.First(i => i.name.Equals(name));
            user.name = u.name;
            user.pass = u.pass;
            user.cpass = u.cpass;
            user.email = u.email;
            user.comments = u.comments;
            d.SaveChanges();

        }
       
       
    }
}