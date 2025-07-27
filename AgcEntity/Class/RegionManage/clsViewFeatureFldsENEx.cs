
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsViewFeatureFldsENEx
表名:ViewFeatureFlds(00050453)
生成代码版本:2019.04.19.1
生成日期:2019/04/21 07:26:08
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
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

namespace AGC.Entity
{
    /// <summary>
    /// 界面功能字段(ViewFeatureFlds)
    /// (AutoGCLib.EntityLayerEx4CSharp:GeneCode)
    /// </summary>
    [Serializable]
    public class clsViewFeatureFldsENEx : clsViewFeatureFldsEN
    {
        private clsFieldTabENEx objFieldTabENEx = null;
        private clsCtlTypeEN objCtlType = null;
        private clsFeatureRegionFldsENEx objFeatureRegionFldsENEx = null;
        private string mstrValueFieldName;
        private string mstrTextFieldName;

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
        public string DsTabName { get; set; }
        public string RelaTabName { get; set; }
        public string RegionId { get; set; }
        public string FeatureId { get; set; }
        public string ValueGivingModeId { get; set; }
        public string VarName { get; set; }
        public string CtlTypeName { get; set; }
        public string FldId { get; set; }
        public int SeqNum { get; set; }

        public string GroupName { get; set; }
        public string FldName
        {
            get
            {
                return ObjFieldTabENEx.FldName;
            }
        }
        /// <summary>
        /// 私有函数变量名，前面不加“m”
        /// </summary>
        public string PrivFuncName
        {
            get
            {
                return ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr + this.FldName;
            }
        }
        private new string mstrCtrlId;

        public new string CtrlId
        {
            get
            {

                mstrCtrlId = this.ObjCtlType.CtlTypeAbbr + this.ObjFieldTabENEx.FldName;
                return mstrCtrlId;
            }
            set { mstrCtrlId = value; }
        }

        public string CsType
        {
            get
            {
                return ObjFieldTabENEx.objDataTypeAbbrEN.CsType;
            }
        }

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

        public clsCtlTypeEN ObjCtlType
        {
            get
            {
                if (objCtlType == null)
                {
                    string strMsg = "控件类型(objCtlType)对象没有被初始化！";
                    throw new Exception(strMsg);
                }
                return objCtlType;
            }
            set => objCtlType = value;
        }

        //public clsFeatureRegionFldsENEx ObjFeatureRegionFldsENEx
        //{
        //    get
        //    {
        //        if (objFeatureRegionFldsENEx == null)
        //        {
        //            string strMsg = "界面功能字段(objFeatureRegionFldsENEx)对象没有被初始化！";
        //            throw new Exception(strMsg);
        //        }
        //        return objFeatureRegionFldsENEx;
        //    }
        //    set => objFeatureRegionFldsENEx = value;
        //}

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayerEx4CSharp:Gen_ENEx_ClassConstructor1)
        /// </summary>
        public clsViewFeatureFldsENEx()
        {
        }
    }
}