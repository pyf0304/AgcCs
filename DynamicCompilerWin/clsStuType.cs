using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestTree
{
  public  class clsStuType
    {
        private string mstrStuTypeId;

        public string StuTypeId
        {
            get { return mstrStuTypeId; }
            set { mstrStuTypeId = value; }
        }
        private string mstrStuTypeName;

        public string StuTypeName
        {
            get { return mstrStuTypeName; }
            set { mstrStuTypeName = value; }
        }

    }
}
