using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgcCommBase
{
    public class MyResult
    {
        public MyResult(bool bol, string str) {
            MyBool = bol;MyString = str;
        }
        public bool MyBool { get; set; }
        public string MyString { get; set; }
    }
}
