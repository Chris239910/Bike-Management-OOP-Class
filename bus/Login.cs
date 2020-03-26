using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikes.bus
{
    public class Login
    {
        private string userName;
        private string userPassword;

        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public Login()
        {
            this.userName = "Undefined";
            this.userPassword = "Undefined";
        }
        public Login(string userName, string userPassword)
        {
            this.userName = userName;
            this.userPassword = userPassword;
        }
        public override string ToString()
        {
            return this.UserName + ", " + this.UserPassword;
        }
    }
}
