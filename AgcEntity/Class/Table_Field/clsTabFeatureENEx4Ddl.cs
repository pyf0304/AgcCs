
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsTabFeatureENEx
表名:TabFeature(00050463)
生成代码版本:2019.05.09.1
生成日期:2019/05/09 23:11:16
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
    /// 表功能(TabFeature)
    /// (AutoGCLib.EntityLayerEx4CSharp:GeneCode)
    /// </summary>
    [Serializable]
    public class clsTabFeatureENEx4Ddl : clsTabFeatureEN
    {
        //public List<clsTabFeatureFldsENEx> arrTabFeatureFldsSet = null;
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayerEx4CSharp:Gen_ENEx_ClassConstructor1)
        /// </summary>
        public clsTabFeatureENEx4Ddl()
        {
        }
        public bool IsHasErr { get; set; }
        public string ErrMsg_Ddl { get; set; }

        public string TextFieldName { get; set; }
        public string ValueFieldName { get; set; }

        public string ConditionFieldName { get; set; }

        public bool IsNumberType { get; set; }

        public string FuncName_Js_Gc { get; set; }
        public string ConditionStr { get; set; }
        public string FilterCondition { get; set; }
        public string SortStr { get; set; }
        public string LetOrConst { get; set; }
        public string LetOrConst2 { get; set; }
        public string TabName4GC { get; set; }
        public string TabCnName4GC { get; set; }
        public string FuncModuleEnName { get; set; }

        public string FuncRemark { get; set; }
        public bool IsForExtendClassFld { get; set; }


    }
}