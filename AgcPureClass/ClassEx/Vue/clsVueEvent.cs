using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agc.PureClass
{
    public class clsVueEvent
    {
        public clsVueEvent(string strEventName, string strEventValue)
        {
            this.EventName = strEventName;
            this.EventValue = strEventValue;
        }
        public string EventName { set; get; }
        public string EventValue { set; get; }

    }
}
