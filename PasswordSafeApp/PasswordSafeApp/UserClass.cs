using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSafeApp
{
    class UserClass
    {
        private int userID;
        private  string username;

        public  void setUserID(int uid)
        {

          //  string anan = "SELECT ID FROM passlogin where username= '" + getUserName.Text + "'       ";
            userID = uid;
        }
        public int getUserID()
        {
            return userID;
        }

        public  void setUsername(string uname)
        {
            username = uname;
        }
        public string getUsername()
        {
                
            return username;
        }
    }
}
