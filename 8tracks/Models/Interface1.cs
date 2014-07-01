using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8tracks.Models
{
    public interface Interface1
    {
        void Save(User u);
        List<Song> search(string n);
        bool Login(User u);
        void Settings(User u);
    }
}
