using FurkanOzden_221103052.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurkanOzden_221103052.Class
{
    internal class LoginValidation
    {
        public DatabaseModel db = new DatabaseModel();
        public bool girisDogrula(string username, string password)
        {
            bool isValid = false;

            var k = db.Kadro.Where(u => u.KullaniciAdi == username && u.Parola==password).SingleOrDefault();

            if (k != null)
            {
                isValid = true;
                USER = k.AdSoyad.ToString();
                USERID = k.ID;
            }
            

            return isValid;
        }

        public static string user;
        public static int userID;

        public string USER
        {
            get { return user; }
            set { user = value; }
        }
        public int USERID
        {
            get { return userID; }
            set { userID = value; }
        }
    }
}
