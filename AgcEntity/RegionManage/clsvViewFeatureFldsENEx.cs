
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvViewFeatureFldsENEx
表名:vViewFeatureFlds(00050454)
生成代码版本:2019.04.19.1
生成日期:2019/04/21 07:26:04
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
    /// v界面功能字段(vViewFeatureFlds)
    /// (AutoGCLib.EntityLayerEx4CSharp:GeneCode)
    /// </summary>
    [Serializable]
    public class clsvViewFeatureFldsENEx : clsvViewFeatureFldsEN
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayerEx4CSharp:Gen_ENEx_ClassConstructor1)
        /// </summary>
        public clsvViewFeatureFldsENEx()
        {
        }
        private clsFieldTabENEx objFieldTabENEx = null;
        private clsCtlTypeAbbrEN objCtlTypeAbbr = null;

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

        public clsCtlTypeAbbrEN ObjCtlTypeAbbr
        {
            get
            {
                if (objCtlTypeAbbr == null)
                {
                    string strMsg = "控件类型(objCtlTypeAbbr)对象没有被初始化！";
                    throw new Exception(strMsg);
                }
                return objCtlTypeAbbr;
            }
            set => objCtlTypeAbbr = value;
        }

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
 

        public string CSType
        {
            get
            {
                return ObjFieldTabENEx.objDataTypeAbbrEN.CSType;
            }
        }

    }
}