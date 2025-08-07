using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgcCommBase;
using com.taishsoft.common;

namespace AGC.Entity
{
    public class clsQryRegionFldsENEx : clsQryRegionFldsEN, IComboBox, IDnPath,ISessionStorageVar, IRegionFlds
    {
        public clsQryRegionFldsENEx()
            : base()
        {
        }
        //public List<clsFieldTabENEx> arrFieldTabExObjLst1Bak = null;			//界面相关详细表字段集合

        private clsFieldTabENEx objFieldTabENEx = null;
        public clsCtlTypeEN objCtlType = null;
        private string mstrValueFieldName;
        private string mstrTextFieldName;
        //private string mstrCtlName4Win;

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
        public string CtrlName
        {
            get
            {
                return string.Format("btn{0}", this.mId);
            }
        }
        private bool isForExtendClass;
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
        public string FldName_Java
        {
            get
            {
                return clsString.FstLcaseS(this.ObjFieldTabENEx.FldName.ToLower());
            }
        }
        public string SelectListItemName
        {
            get; set;
        }

        public string CtlTypeENName
        {
            get
            {
                return this.objCtlType.CtlTypeENName;
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

        private string mstrCtrlId;

        //public string CtrlId
        //{
        //    get
        //    {
        //        if (this.IsUseFunc && string.IsNullOrEmpty(this.DataPropertyName) == false)
        //        {
        //            mstrCtrlId = this.objCtlType.CtlTypeAbbr + this.DataPropertyName + "_q";
        //        }
        //        else
        //        { 
        //        mstrCtrlId = this.objCtlType.CtlTypeAbbr + this.ObjFieldTabENEx.FldName + "_q";
        //        }
        //        return mstrCtrlId;
        //    }
        //    set { mstrCtrlId = value; }
        //}
        public string FldName
        {
            get
            {
                return this.ObjFieldTabENEx.FldName;
            }
        }
        public string PropertyName
        {
            get
            {
                return this.ObjFieldTabENEx.FldName_FstLcase0 + "_q";
            }
        }
        public string TabName
        {
            get
            {
                return this.TabName;
            }
        }
       
        public string DS_TabName { get; set; }
        string IComboBox.DsTabId
        {
            get {
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
        public bool IsForExtendClass { get => isForExtendClass; set => isForExtendClass = value; }


        public string ValueFieldName
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
        public string TextFieldName
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
                return mstrLabelCaption;
            }
            set
            {
                mstrLabelCaption = value;
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
        string ISessionStorageVar.VarId {
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
