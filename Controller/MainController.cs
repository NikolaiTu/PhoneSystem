using PhoneSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneSystem.Controller
{
    internal class MainController
    {
        public bool CheckIsRegistered(string username, string password)
        {
            using (PhonesDBEntities db = new PhonesDBEntities())
            {
                return db.Users.ToList().Where(u => u.UserName == username && u.Password == password).Any();
            }
        }
    }
}
