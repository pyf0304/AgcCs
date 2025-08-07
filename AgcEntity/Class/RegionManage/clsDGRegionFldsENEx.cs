using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgcCommBase;
using com.taishsoft.common;

namespace AGC.Entity
{
    public class clsDGRegionFldsENEx : clsDGRegionFldsEN, IRegionFlds
    {

        public clsDGRegionFldsENEx()
            : base()
        {
        }
        //public List<clsFieldTabENEx> arrFieldTabExObjLst1Bak = null;			//界面相关详细表字段集合

        private clsFieldTabENEx objFieldTabENEx = null;
        public clsCtlTypeEN objCtlType = null;
        public string CtrlName
        {
            get
            {
                return string.Format("btn{0}", this.mId);
            }
        }
        public string ButtonValue
        {
            get
            {
                if (InUse == true)
                {
                    return string.Format("D:{0}", this.HeaderText);
                }
                else
                {
                    return string.Format("A:{0}", this.HeaderText);
                }
            }
        }
        public string FldName_Java
        {
            get
            {
                return clsString.FstLcaseS(this.ObjFieldTabENEx.FldName.ToLower());
            }
        }
        public string FldName_Lcase
        {
            get
            {
                return clsString.FstLcaseS(this.ObjFieldTabENEx.FldName);
            }
        }
        public string FldName
        {
            get
            {
                return this.ObjFieldTabENEx.FldName;
            }
        }
        private string mstrCtlName;
        public string CtlName
        {
            get
            {
                mstrCtlName = this.objCtlType.CtlTypeAbbr + this.ObjFieldTabENEx.FldName;
                return mstrCtlName;
            }
            set
            {
                mstrCtlName = value;
            }
        }
        public string CtlName4Win
        {
            get
            {
                mstrCtlName = this.objCtlType.CtlTypeAbbr + this.ObjFieldTabENEx.FldName;

                return mstrCtlName.Replace("ddl", "cbo");
            }
            set
            {
                mstrCtlName = value;
            }
        }
     
        public string DS_TabName { get; set; }
      
        //public string TabName
        //{
        //    get
        //    {
        //        return this.ObjPrjTabFldENEx.TabName;
        //    }
        //}


        public clsFieldTabENEx ObjFieldTabENEx
        {
            get
            {
                //if (objPrjTabFldENEx == null)
                //{
                //    string strMsg = "表字段扩展(PrjTabFldEx)对象没有被初始化！";
                //    throw new Exception(strMsg);
                //}
                return objFieldTabENEx;

            }
            set => objFieldTabENEx = value;
        }


        //string IDnPath.FldId
        //{
        //    get
        //    {
        //        return mstrFldId;
        //    }
        //    set
        //    {
        //        mstrFldId = value;
        //    }
        //}
        //string IDnPath.Caption
        //{
        //    get
        //    {
        //        return mstrHeaderText;
        //    }
        //    set
        //    {
        //        mstrHeaderText = value;
        //    }
        //}
        //string IDnPath.DataPropertyName
        //{
        //    get
        //    {
        //        return mstrDataPropertyName;
        //    }
        //    set
        //    {
        //        mstrDataPropertyName = value;
        //    }
        //}
        //string IDnPath.DnPathId
        //{
        //    get
        //    {
        //        return mstrDnPathId;
        //    }
        //    set
        //    {
        //        mstrDnPathId = value;
        //    }
        //}

        //bool IDnPath.IsUseFunc
        //{
        //    get
        //    {
        //        return mbolIsUseFunc;
        //    }
        //    set
        //    {
        //        mbolIsUseFunc = value;
        //    }
        //}
        //string IDnPath.OutDataNodeId
        //{
        //    get
        //    {
        //        return mstrOutDataNodeId;
        //    }
        //    set
        //    {
        //        mstrOutDataNodeId = value;
        //    }
        //}

        //string IDnPath.CmPrjId
        //{
        //    get
        //    {
        //        return mstrCmPrjId;
        //    }
        //    set
        //    {
        //        mstrCmPrjId = value;
        //    }
        //}
        //string IDnPath.TabId
        //{
        //    get { return ""; }
        //    set { }
        //}
        //bool IDnPath.IsForExtendClass
        //{
        //    get { return false; }
        //    set { }
        //}

        string IRegionFlds.OutFldId
        {
            get
            {
                return mstrOutFldId;
            }
            set
            {
                mstrOutFldId = value;
            }
        }

        string IRegionFlds.PrjId
        {
            get
            {
                return mstrPrjId;
            }
            set
            {
                mstrPrjId = value;
            }
        }
        string IRegionFlds.RegionId
        {
            get { return this.RegionId; }
            set { }
        }
        string IRegionFlds.FldId
        {
            get
            {
                return mstrFldId;
            }
            set
            {
                mstrFldId = value;
            }
        }
    }
}
