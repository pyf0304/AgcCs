using AGC.Entity;
using AgcCommBase;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.Entity
{
    public class clsPrjTabFldENEx : clsPrjTabFldEN, IDnPath
    {
        //public List<clsFieldTabENEx> arrFieldTabExObjLst1Bak = null;			//界面相关详细表字段集合

        private clsFieldTabENEx objFieldTabENEx = null;
       
        public clsFieldTabENEx ObjFieldTabENEx
        {
            get
            {
                if (objFieldTabENEx == null)
                {
                    string strMsg = "字段对象没有被初始化！";
                    throw new Exception(strMsg);
                }
                return objFieldTabENEx;

            }
            set => objFieldTabENEx = value;
        }
        
        public clsFieldTypeEN objFieldTypeEN = null;
        public clsPrimaryTypeEN objPrimaryTypeEN = null;
        /// <summary>
        /// 关键字变量的定义串，例如: string strUserId
        /// </summary>
        public string KeyVarDefineStr
        {
            get
            {
                return this.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + this.ObjFieldTabENEx.PrivFuncName;
            }
        }
        public clsPrjTabFldENEx():base()
        {
            this.ObjFieldTabENEx = new clsFieldTabENEx();
        }

        /// <summary>
        /// 私有函数变量名，前面不加“m”
        /// </summary>
        public string PrivFuncName
        {
            get
            {
                return this.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr + this.ObjFieldTabENEx.FldName;
            }
        }

        /// <summary>
        /// 私有函数列表变量名，字段名前面加“arr”
        /// </summary>
        public string PrivFuncListName
        {
            get
            {
                return string.Format("arr{0}", this.ObjFieldTabENEx.FldName);
            }
        }
        /// <summary>
        /// 关键字的Cs类型
        /// </summary>
        public string CsType
        {
            get
            {
                return this.ObjFieldTabENEx.objDataTypeAbbrEN.CsType;
            }
        }
        public string CsTypeEx
        {
            get
            {
                if (this.IsTabNullable == true && this.objFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
                {
                    return this.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + "?";
                }
                return this.ObjFieldTabENEx.objDataTypeAbbrEN.CsType;
            }
        }
        public string ColCaption
        {
            get
            {
                return this.ObjFieldTabENEx.Caption;
            }
        }

        public string TypeScriptType
        {
            get
            {
                return this.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType;
            }
        }
        /// <summary>
        /// 字段名
        /// </summary>
        public string FldName
        {
            get
            {
                return this.ObjFieldTabENEx.FldName;
            }
        }

        /// <summary>
        /// 字段名，首字母大写
        /// </summary>
        public string FldName_FstUcase
        {
            get
            {
                return this.ObjFieldTabENEx.FldName_FstUcase;
            }
        }
        /// <summary>
        /// 字段名，首字母小写
        /// </summary>
        public string FldName_FstLcase0
        {
            get
            {
                return this.ObjFieldTabENEx.FldName_FstLcase0;
            }
        }
       


        public string JavaType
        {
            get
            {
                return this.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType;
            }
        }
        public string FldName_Java
        {
            get
            {
                return clsString.FstLcaseS(this.ObjFieldTabENEx.FldName.ToLower());
            }
        }
        public string TabName { get; set; }



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
       
        string IDnPath.DnPathId
        {
            get
            {
                return mstrDnPathId;
            }
            set
            {
                mstrDnPathId = value;
            }
        }

       
        bool IDnPath.IsForExtendClass
        {
            get
            {
                return mbolIsForExtendClass;
            }
            set
            {
                mbolIsForExtendClass = value;
            }
        }

        string IDnPath.TabId
        {
            get
            {
                return mstrTabId;
            }
            set
            {
                mstrTabId = value;
            }
        }
        string IDnPath.PrjId
        {
            get { return ""; }
            set { }
        }
        string IDnPath.Caption
        {
            get { return ""; }
            set { }
        }
        //string IDnPath.OutDataNodeId
        //{
        //    get { return ""; }
        //    set { }
        //}
        //string IDnPath.DataPropertyName
        //{
        //    get { return ""; }
        //    set { }
        //}
        //bool IDnPath.IsUseFunc
        //{
        //    get { return false; }
        //    set { }
        //}

    }
}
