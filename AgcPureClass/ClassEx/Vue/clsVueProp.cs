using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agc.PureClass
{
    public class clsVueProp
    {
        public clsVueProp(string strPropName, string strPropValue)
        {
            this.PropName = strPropName;
            this.PropValue = strPropValue;
        }
        public string PropName { set; get; }
        public string PropValue { set; get; }

    }
}
