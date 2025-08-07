using AgcCommBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.Entity
{
    public class clsAndroidControlENEx : clsAndroidControlEN
    {

        public List<clsAndroidControlENEx> arrSubAndroidControlLst2 = null;
        public clsAndroidControlENEx()
        {
            arrSubAndroidControlLst2 = new List<clsAndroidControlENEx>();
            this.AndroidControlId = AgcPubFun.getAndroidID();
        }
        public clsQryRegionFldsENEx objQryRegionFldsENEx = null;
        public clsEditRegionFldsENEx objEditRegionFldsENEx = null;
        public clsDGRegionFldsENEx objDGRegionFldsENEx = null;

    }
}
