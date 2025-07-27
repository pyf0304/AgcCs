using AgcCommBase;
using com.taishsoft.commexception;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.Entity
{
    public class clsEditRegionFldsENEx : clsEditRegionFldsEN, IComboBox, ISessionStorageVar, IRegionFlds
    {

        public clsEditRegionFldsENEx()
            : base()
        {
        }
        //public List<clsFieldTabENEx> arrFieldTabExObjLst1Bak = null;			//界面相关详细表字段集合
        private string mstrValueFieldName;
        private string mstrTextFieldName;



        public clsCtlTypeEN objCtlType = null;

        //public string FieldTypeId
        //{
        //    get
        //    {
        //        return this.objFieldTabENEx.FieldTypeId;
        //    }
        //}
        //public bool IsLogUpdDateOrUpdUser
        //{
        //    get
        //    {
        //        if (FieldTypeId == "13") return true;
        //        if (FieldTypeId == "14") return true;
        //        return false;
        //    }
        //}
        //public bool IsPrimaryKeyIdentity
        //{
        //    get
        //    {
        //        if (this.objFieldTabENEx.PrimaryTypeId == "02") return true;
        //        return false;
        //    }
        //}
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
                    return string.Format("D:{0}", this.LabelCaption);
                }
                else
                {
                    return string.Format("A:{0}", this.LabelCaption);
                }
            }
        }

        public string FldNameJava
        {
            get
            {
                return clsString.FstLcaseS(this.ObjFieldTabENEx.FldName.ToLower());
            }
        }

        public string FldName
        {
            get
            {
                return this.ObjFieldTabENEx.FldName;
            }
        }
        public string FldNameFstLcase
        {
            get
            {
                return clsString.FstLcaseS(this.ObjFieldTabENEx.FldName);
            }
        }
        public string CtrlId4Win
        {
            get
            {
                mstrCtrlId = this.objCtlType.CtlTypeAbbr + this.ObjFieldTabENEx.FldName;

                return mstrCtrlId.Replace("ddl", "cbo");
            }
            set
            {
                mstrCtrlId = value;
            }
        }
        public string SelectListItemName
        {
            get; set;
        }
        private string mstrCtrlId;

        public string CtrlId
        {
            get
            {
                mstrCtrlId = this.objCtlType.CtlTypeAbbr + this.ObjFieldTabENEx.FldName;
                return mstrCtrlId;
            }
            set { mstrCtrlId = value; }
        }

        public string CtlTypeENName
        {
            get
            {
                return this.objCtlType.CtlTypeENName;
            }
        }
        public string CtlTypeName
        {
            get
            {
                return this.objCtlType.CtlTypeName;
            }
        }

        /// <summary>
        /// 转换代码表
        /// </summary>
        public string CodeTab;
        ///// <summary>
        ///// 转换代码表
        ///// </summary>

        public string DSTabName { get; set; }

        //public string TabName
        //{
        //    get
        //    {
        //        return this.ObjFieldTabENEx.TabName;
        //    }
        //}
        private clsFieldTabENEx objFieldTabENEx = null;

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
        string IComboBox.DsTabId
        {
            get
            {
                return mstrDsTabId;
            }
            set
            {
                mstrDsTabId = value;
            }
        }
        string IComboBox.LabelCaption
        {
            get
            {
                return mstrLabelCaption;
            }
            set
            {
                mstrLabelCaption = value;
            }
        }
    public     string ValueFieldName
        {
            get
            {
 return mstrValueFieldName;

            }
            set
            {
                mstrValueFieldName = value;
            }
        }
     public   string TextFieldName
        {
            get
            {
                return mstrTextFieldName;
            }
            set
            {
                mstrTextFieldName = value;
            }
        }
        string IComboBox.DdlItemOptionId
        {
            get
            {
                return mstrDdlItemsOptionId;
            }
            set
            {
                mstrDdlItemsOptionId = value;
            }
        }

        string IComboBox.TabFeatureId4Ddl
        {
            get
            {
                return mstrTabFeatureId4Ddl;
            }
            set
            {
                mstrTabFeatureId4Ddl = value;
            }
        }
        string IComboBox.VarIdCond1
        {
            get
            {
                return mstrVarIdCond1;
            }
            set
            {
                mstrVarIdCond1 = value;
            }
        }
       
        string IComboBox.FldIdCond1
        {
            get
            {
                return mstrFldIdCond1;
            }
            set
            {
                mstrFldIdCond1 = value;
            }
        }

        string IComboBox.VarIdCond2
        {
            get
            {
                return mstrVarIdCond2;
            }
            set
            {
                mstrVarIdCond2 = value;
            }
        }
       
        string IComboBox.FldIdCond2
        {
            get
            {
                return mstrFldIdCond2;
            }
            set
            {
                mstrFldIdCond2 = value;
            }
        }

        string IComboBox.PrjId
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


        string ISessionStorageVar.PrjId
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
        //string LabelCaption { get; set; }
        string ISessionStorageVar.FldId
        {
            get { return mstrFldId; }
            set { }
        }

        //string CtrlId { get; set; }
        string ISessionStorageVar.VarId
        {
            get { return this.VarId; }
            set { }
        }
        string ISessionStorageVar.LabelCaption
        {
            get
            {
                return mstrLabelCaption;
            }
            set
            {
                mstrLabelCaption = value;
            }
        }

        string IRegionFlds.OutFldId
        {
            get
            {
                return "";
            }
            set
            {

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
