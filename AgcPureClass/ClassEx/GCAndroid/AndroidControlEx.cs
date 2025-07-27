using AGC.Entity;
using AgcCommBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.PureClass
{
    public class AndroidControlEx : AndroidControl
    {

        public List<AndroidControlEx> arrSubAndroidControlLst2 = null;
        public AndroidControlEx()
        {
            arrSubAndroidControlLst2 = new List<AndroidControlEx>();
            this.AndroidControlId = AgcPubFun.getAndroidID();
        }
        //public clsQryRegionFldsENEx objQryRegionFldsENEx = null;
        //public clsEditRegionFldsENEx objEditRegionFldsENEx = null;
        //public clsDGRegionFldsENEx objDGRegionFldsENEx = null;
        public clsQryRegionFldsEN objQryRegionFldsEN = null;
        public clsEditRegionFldsEN objEditRegionFldsEN = null;
        public clsDGRegionFldsEN objDGRegionFldsEN = null;

    }
}
