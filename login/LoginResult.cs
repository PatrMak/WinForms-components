
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Login
{
    public class LoginResult
    {
        static LoginResultEnum _loginResult;
        public static LoginResultEnum Result
        {
            get
            {
                return _loginResult;
            }
            set
            {
                _loginResult = value;
            }
        }

        public enum LoginResultEnum
        {
            correct,
            wrong,
        }
    }
}
