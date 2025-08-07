
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsDataTypeAbbrENEx
表名:DataTypeAbbr(00050023)
生成代码版本:2018.08.11.1
生成日期:2018/08/12 00:08:21
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:系统参数
模块英文名:SysPara
框架-层名:实体扩展层(EntityLayerEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2018.07.27.01
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
    /// 数据类型(DataTypeAbbr)
    /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCodeEx)
    /// </summary>
    [Serializable]
    public class clsDataTypeAbbrENEx : clsDataTypeAbbrEN
    {
        public string DefaValue
        {
            get
            {
                string strCodeForCs = "";
                switch (this.CsType)
                {
                    case "int":
                        strCodeForCs =  "0";
                        break;
                    case "double":
                        strCodeForCs = "0.0";
                        break;
                    case "DateTime":
                        strCodeForCs = "0";
                        break;
                    case "bool":
                        strCodeForCs = "false";
                        break;
                    case "float":
                        strCodeForCs = "0.0";
                        break;
                    case "long":
                        strCodeForCs = "0";;
                        break;
                    default:

                        strCodeForCs  = "";
                        break;
                }
                return strCodeForCs;
            }
        }
    }
}