
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPH4BLEx
表名:ASPH4(00050450)
生成代码版本:2019.04.19.1
生成日期:2019/04/19 17:30:10
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成C#代码
模块英文名:GeneCSharp
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;

using com.taishsoft.comm_db_obj;


using AGC.PureClass;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;
using AgcCommBase;

namespace AGC.PureClassEx
{
    public static class clsASPH4BLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPH4ENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this ASPH4Ex objASPH4ENEx,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();


            strCodeForCs.AppendFormat("\r\n" + "<h4 ");

            clsASPControlBLEx.GC4Type(objASPH4ENEx, strCodeForCs);

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPH4ENEx, strCodeForCs);

            clsASPControlBLEx.GC4Data_dismiss(objASPH4ENEx, strCodeForCs);

            clsASPControlBLEx.GC4Aria_label(objASPH4ENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPH4ENEx, strCodeForCs);

            //生成控件的样式
            clsASPControlBLEx.GC4Style(objASPH4ENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            //clsASPControlBLEx.GC4Size(objASPH4ENEx, strCodeForCs);
            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPH4ENEx, strCodeForCs);

           
            //if (string.IsNullOrEmpty(objASPH4ENEx.Value) == false)
            //{
            //    strCodeForCs.AppendFormat(" value=\"{0}\"",
            //           objASPH4ENEx.Value);
            //}

            clsASPControlBLEx.GC4Tabindex(objASPH4ENEx, strCodeForCs);
            clsASPControlBLEx.GC4Aria_labelledby(objASPH4ENEx, strCodeForCs);
            clsASPControlBLEx.GC4Aria_hidden(objASPH4ENEx, strCodeForCs);

            //生成控件的样式
            //clsASPControlBLEx.GC4Text(objASPH4ENEx, strCodeForCs);

            //生成控件的约束-即与四周控件的约束关系
            //clsASPControlBLEx.GC4Constraint(objASPH4ENEx, strCodeForCs);
            strCodeForCs.AppendFormat(">");
            if (string.IsNullOrEmpty(objASPH4ENEx.Text) == false)
            {
                strCodeForCs.AppendFormat("{0}", objASPH4ENEx.Text);
            }

            strCodeForCs.AppendFormat("</h4>");
           
        }

        public static void GeneCode4Mvc(this ASPH4Ex objASPH4ENEx,
        StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();


            strCodeForCs.AppendFormat("\r\n" + "<h4 ");

            clsASPControlBLEx.GC4Type(objASPH4ENEx, strCodeForCs);

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPH4ENEx, strCodeForCs);

            clsASPControlBLEx.GC4Data_dismiss(objASPH4ENEx, strCodeForCs);

            clsASPControlBLEx.GC4Aria_label(objASPH4ENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPH4ENEx, strCodeForCs);

            //生成控件的样式
            clsASPControlBLEx.GC4Style(objASPH4ENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            //clsASPControlBLEx.GC4Size(objASPH4ENEx, strCodeForCs);
            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPH4ENEx, strCodeForCs);


            //if (string.IsNullOrEmpty(objASPH4ENEx.Value) == false)
            //{
            //    strCodeForCs.AppendFormat(" value=\"{0}\"",
            //           objASPH4ENEx.Value);
            //}

            clsASPControlBLEx.GC4Tabindex(objASPH4ENEx, strCodeForCs);
            clsASPControlBLEx.GC4Aria_labelledby(objASPH4ENEx, strCodeForCs);
            clsASPControlBLEx.GC4Aria_hidden(objASPH4ENEx, strCodeForCs);

            //生成控件的样式
            //clsASPControlBLEx.GC4Text(objASPH4ENEx, strCodeForCs);

            //生成控件的约束-即与四周控件的约束关系
            //clsASPControlBLEx.GC4Constraint(objASPH4ENEx, strCodeForCs);
            strCodeForCs.AppendFormat(">");
            if (string.IsNullOrEmpty(objASPH4ENEx.Text) == false)
            {
                strCodeForCs.AppendFormat("{0}", objASPH4ENEx.Text);
            }

            strCodeForCs.AppendFormat("</h4>");

        }
           
    }
    /// <summary>
    /// ASPH4(ASPH4)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsASPH4BLEx 
    {


    }
}