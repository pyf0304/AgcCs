
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsDetailRegionFldsENEx
表名:DetailRegionFlds(00050544)
生成代码版本:2020.05.24.1
生成日期:2020/05/26 02:27:35
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:区域管理
模块英文名:RegionManage
框架-层名:实体扩展层(EntityLayerEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using AgcCommBase;

namespace AGC.Entity
{
    /// <summary>
    /// 详细区域字段(DetailRegionFlds)
    /// (AutoGCLib.EntityLayerEx4CSharp:GeneCode)
    /// </summary>
    [Serializable]
    public class clsDetailRegionFldsENEx : clsDetailRegionFldsEN, IDnPath, IRegionFlds
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayerEx4CSharp:Gen_ENEx_ClassConstructor1)
        /// </summary>
        public clsDetailRegionFldsENEx()
             : base()
        {
        }

        private clsFieldTabENEx objFieldTabENEx = null;
        public clsCtlTypeEN objCtlType = null;
        public clsPrjTabFldEN objPrjTabFld = null;

        //public string FieldTypeId
        //{
        //    get
        //    {
        //        return this.ObjFieldTabENEx.FieldTypeId;
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
        //public bool IsPrimaryKey_Identity
        //{
        //    get
        //    {
        //        if (this.ObjPrjTabFldENEx.PrimaryTypeId == "02") return true;
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

        public string FldName_Java
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
        public string FldName_FstLcase
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
                return mstrLabelCaption;
            }
            set
            {
                mstrLabelCaption = value;
            }
        }
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
    }
}
