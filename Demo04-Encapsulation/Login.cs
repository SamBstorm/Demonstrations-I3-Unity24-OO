using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_Encapsulation
{
    internal class Login
    {
        private string _email;
        private string _password;

        public void SetEmailAndPassword(string email, string password)
        {
            _email = email;
            _password = password;
        }

        public bool CheckLogin(string email, string password)
        {
            return _password == password && _email == email;
        }
    }
}
