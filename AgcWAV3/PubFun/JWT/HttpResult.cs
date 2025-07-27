using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGCWA.PubFun
{
    public class HttpResult
    {
        public bool Success { get; set; }
        public dynamic Data { get; set; }
        public string Message { get; set; }
    }
}
