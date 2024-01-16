using PhoneSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhoneSystem.Controller
{
    internal class MainController
    {

        public List<User> GetAllUsers()
        {
            using (PhonesDBEntities db = new PhonesDBEntities())
            {
                return db.Users.ToList();
            }
        }

        public bool CheckIsRegistered(string username, string password)
        {
            using (PhonesDBEntities db = new PhonesDBEntities())
            {
                return db.Users.ToList().Where(u => u.UserName == username && u.Password == password).Any();
            }
        }

        public void RegisterUser(string username, string password)
        {
            using (PhonesDBEntities db = new PhonesDBEntities())
            {
                User u = new User();
                if (!db.Users.ToList().Any())
                {
                    u.Id = 1;
                }
                else
                {
                    u.Id = db.Users.ToList().LastOrDefault().Id + 1;
                }
                u.UserName = username;
                u.Password = password;
                db.Users.Add(u);
                db.SaveChanges();                       
            }
        }
    }
}
