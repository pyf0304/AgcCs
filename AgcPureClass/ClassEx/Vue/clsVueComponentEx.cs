using Agc.PureClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.PureClass
{
    public class VueComponentEx : ASPControlEx
    {
        //public Func<string> ContentFunc = null;
        public string ComponentName { set; get; }
        public string RefName { set; get; }

        public List<clsVueProp> Props { set; get; }
        public List<clsVueEvent> Events { set; get; }

    }
}
