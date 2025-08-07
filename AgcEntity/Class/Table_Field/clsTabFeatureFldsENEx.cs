
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsTabFeatureFldsENEx
表名:TabFeatureFlds(00050455)
生成代码版本:2019.04.27.1
生成日期:2019/04/29 01:56:16
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护
模块英文名:Table_Field
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
    /// 表功能字段(TabFeatureFlds)
    /// (AutoGCLib.EntityLayerEx4CSharp:GeneCode)
    /// </summary>
    [Serializable]
    public class clsTabFeatureFldsENEx : clsTabFeatureFldsEN
    {
        //public string PrjId { set; get; }

        private clsFieldTabENEx objFieldTabENEx = null;
   
        
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

        public string CsType
        {
            get
            {
                return ObjFieldTabENEx.objDataTypeAbbrEN.CsType;
            }
        }
        public bool IsForExtendClass
        {
            set; get;
        }
        public clsFieldTabENEx ObjFieldTabENEx { get => objFieldTabENEx; set => objFieldTabENEx = value; }

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayerEx4CSharp:Gen_ENEx_ClassConstructor1)
        /// </summary>
        public clsTabFeatureFldsENEx()
        {

        }
    }
}