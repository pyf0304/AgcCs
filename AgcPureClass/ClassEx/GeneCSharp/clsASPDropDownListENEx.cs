
/*-- -- -- -- -- -- -- -- -- -- --
类名:ASPDropDownListEx
表名:ASPNETDropDownList(00050414)
生成代码版本:2018.06.28.1
生成日期:2018/06/29 13:56:05
生成者:潘以锋
生成服务器IP:202.121.63.42
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成C#代码
模块英文名:GeneCode
框架-层名:实体扩展层(EntityLayerEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2018.05.31.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using AGC.Entity;

namespace AGC.PureClass
{
    /// <summary>
    /// ASPNET下拉框(ASPNETDropDownList)
    /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCodeEx)
    /// </summary>
    [Serializable]
    public class ASPDropDownListEx : ASPDropDownList
    {
        public ASPDropDownListEx()
        {
            this.ControlType = "ASPDropDownListEx";
        }
        public string CodeText { get; set; }
        /// <summary>
        /// 区域类型
        /// </summary>
        public string RegionTypeId { get; set; }
        public string DdlItemsOptionId { get; set; }
        public string ItemsString { get; set; }
        public string DsCondStr { get; set; }
        public string DsSqlStr { get; set; }
        public string DsTabName { get; set; }
        public string DsTabName4GC {
            get
            {
                string strTabName = this.DsTabName;
                return strTabName;
            }
        }

        public string DsTabId { get; set; }
        public string DivName { get; set; }

        public string TabFeatureId4Ddl { get; set; }
        
        public string FldIdCond1 { get; set; }
        //public string VarTypeIdCond1 { get; set; }
        public string VarIdCond1 { get; set; }
        public string FldIdCond2 { get; set; }
        //public string VarTypeIdCond2 { get; set; }
        public string VarIdCond2 { get; set; }
        public string PrjId { get; set; }


        public clsPrjTabEN objPrjTab_CodeTab = null;
        //public clsFieldTabEN objFieldTab_ValueField = null;
        //public clsFieldTabEN objFieldTab_TextField = null;
        //public clsFieldTabEN objFieldTab_ConditionField = null;
        //public clsFieldTabEN objFieldTab_CacheClassify = null;
        public clsTabFeatureFldsEN objTabFeatureFlds = null;
        public clsTabFeatureEN objTabFeature = null;
        public string TextFieldName { get; set; }
        public string ValueFieldName { get; set; }
    }
}