using AgcCommBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.Entity
{
    public class clsISOControlENEx : clsISOControlEN
    {

        public List<clsISOControlENEx> arrSubIsoControlLst2 = null;
        public clsISOControlENEx()
        {
            arrSubIsoControlLst2 = new List<clsISOControlENEx>();
            this.IsoControlId = AgcPubFun.getSwiftID();
        }

    }
}
