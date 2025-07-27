using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.Entity
{
    public class clsDGRegionENEx : clsDGRegionEN
    {
        public clsViewRegionEN objViewRegionEN = null;

        public clsDGRegionENEx(long lngRegionId)
            : base(lngRegionId)
        {

        }
        private int mintFieldNum;	//字段数

        public int FieldNum
        {
            get { return mintFieldNum; }
            set { mintFieldNum = value; }
        }
    }
}
