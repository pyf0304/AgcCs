using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestTree
{
    public class clsPerson
    {
        private clsStuType objStuType_Private = null;
        public clsStuType objStuType_Public = null;
        public List<clsStuType> arrStuTypeObjLst = null;
        private clsStuType objStuType = null;

        public clsStuType StuType
        {
            get { return objStuType; }
            set { objStuType = value; }
        }
        private string mstrName;

        public string Name
        {
            get { return mstrName; }
            set { mstrName = value; }
        }
        private string mstrRelation;

        public string Relation
        {
            get { return mstrRelation; }
            set { mstrRelation = value; }
        }
        private int mintAge;

        public int Age
        {
            get { return mintAge; }
            set { mintAge = value; }
        }

    }
}
