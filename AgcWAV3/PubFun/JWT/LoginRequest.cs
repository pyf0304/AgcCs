using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comm.PubFun
{
    public class LoginRequest
    {
        public string UserId { get; set; }
        public string Password { get; set; }
    }

    public class LoginParams
    {
        public string captchaId { get; set; }
        public string password { get; set; }
        public string username { get; set; }
        public string verifyCode { get; set; }

    }
}
