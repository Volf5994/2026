using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableLibrary.Services
{
    public class LoginService
    {
        private static LoginService _instance;

        public static LoginService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LoginService();
                return _instance;
            }
        }

        public string GetLogin()
        {
            var login = string.Concat(Guid.NewGuid().ToString("N").Take(6));
            return login;
        }
    }
}
