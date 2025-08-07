using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgcCommBase;
using com.taishsoft.common;

namespace AGC.Entity
{
    public class clsExcelExportRegionFldsENEx : clsExcelExportRegionFldsEN, IDnPath, IRegionFlds
    {
        public clsExcelExportRegionFldsENEx()
            : base()
        {
        }
        private clsFieldTabENEx objFieldTabENEx = null;
        public clsCtlTypeEN objCtlType = null;
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

        public clsFieldTabENEx ObjFieldTabENEx
        {
            get
            {
                if (objFieldTabENEx == null)
                {
                    string strMsg = "表字段扩展(PrjTabFldEx)对象没有被初始化！";
                    throw new Exception(strMsg);
                }
                return objFieldTabENEx;

            }
            set => objFieldTabENEx = value;
        }


        string IDnPath.FldId
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
        string IDnPath.Caption
        {
            get
            {
                return mstrColCaption;
            }
            set
            {
                mstrColCaption = value;
            }
        }
        
        string IDnPath.PrjId
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
        string IDnPath.TabId
        {
            get { return ""; }
            set { }
        }
        string IDnPath.DnPathId
        {
            get { return ""; }
            set { }
        }
        bool IDnPath.IsForExtendClass
        {
            get { return false; }
            set { }
        }

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
        string IRegionFlds.CtlTypeId
        {
            get
            {
                return "";
            }
            set
            {
            }
        }
    }
}
