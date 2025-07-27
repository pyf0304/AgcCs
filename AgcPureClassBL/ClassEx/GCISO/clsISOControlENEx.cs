using AgcCommBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.PureClass
{
    public class ISOControlEx : ISOControl
    {

        public List<ISOControlEx> arrSubIsoControlLst2 = null;
        public ISOControlEx()
        {
            arrSubIsoControlLst2 = new List<ISOControlEx>();
            this.IsoControlId = AgcPubFun.getSwiftID();
        }

    }
}
