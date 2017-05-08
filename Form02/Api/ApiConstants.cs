using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form02.Api
{
    class ApiConstants
    {
        public static string BASE_URL = "http://192.168.1.140:8880/apis_v2/";

        public static string URL_USER_LOGIN = BASE_URL + "users/signin";
        public static string URL_USER_REGISTER = BASE_URL + "users/signup";
        public static string URL_USER_FORGOTPWD = BASE_URL + "users/forgotpwd";



    }
}
