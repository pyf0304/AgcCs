
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPHeadBLEx
表名:ASPNETHead(00050214)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:55:50
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成C#代码
模块英文名:GeneCode
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2018.05.31.01
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
using AGC.Entity;

namespace AGC.PureClassEx
{
    /// <summary>
    /// ASPNET头(ASPNETHead)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPHeadBLEx_Static
    {
        public static void GeneCode(this ASPHeadEx objASPHeadENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        {
            switch (intApplicationTypeId)
            {
                case enumApplicationType.WebApp_2:
                    break;
                case enumApplicationType.AspMvcAjaxApp_20:
                case enumApplicationType.AspMvcApp_13:
                case enumApplicationType.AspMvcApp_TS_16:
                    break;
                case enumApplicationType.SpaAppInCore_TS_18:
                case enumApplicationType.VueAppInCore_TS_30:
                    break;
                default:
                    var objApp = clsApplicationTypeBL.GetObjByApplicationTypeIdCache((int)intApplicationTypeId);
                    var strMsg = string.Format("应用:[{0}]在函数Switch中没有被处理.(in {1})", objApp.ApplicationTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;
            }
            strCodeForCs.Append("\r\n" + "<head runat = \"server\">");
            strCodeForCs.Append("\r\n" + "<title>性别表维护的维护</title>");
            strCodeForCs.Append("\r\n" + "<link rel = \"stylesheet\" type = \"text/css\" href = \"../../css/tz_base1.css\" />");

            foreach (ASPControlEx objSubASPControlENEx in objASPHeadENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</head>");

        }

        //public static void GeneCode4Html(this ASPHeadEx objASPHeadENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        //{
        //    strCodeForCs.Append("\r\n" + "<head runat = \"server\">");
        //    strCodeForCs.Append("\r\n" + "<title>性别表维护的维护</title>");
        //    strCodeForCs.Append("\r\n" + "<link rel = \"stylesheet\" type = \"text/css\" href = \"../../css/tz_base1.css\" />");

        //    foreach (ASPControlEx objSubASPControlENEx in objASPHeadENEx.arrSubAspControlLst2)
        //    {
        //        objSubASPControlENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
        //    }
        //    strCodeForCs.Append("\r\n" + "</head>");

        //}


        public static void GeneCode4Mvc(this ASPHeadEx objASPHeadENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n" + "<head runat = \"server\">");
            strCodeForCs.Append("\r\n" + "<title>性别表维护的维护</title>");
            strCodeForCs.Append("\r\n" + "<link rel = \"stylesheet\" type = \"text/css\" href = \"../../css/tz_base1.css\" />");

            foreach (ASPControlEx objSubASPControlENEx in objASPHeadENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</head>");

        }
    }

        /// <summary>
        /// ASPNET头(ASPNETHead)
        /// 数据源类型:SQL表
        /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
        /// </summary>
        public class clsASPHeadBLEx 
        {
        
    
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPHeadENEx">按钮对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCodeBak20180630(ASPHeadEx objASPHeadENEx, enumApplicationType intApplicationTypeId,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();

            strCodeForCs.AppendFormat("\r\n" + "<android.support.constraint.Head ");
         
            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPHeadENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPHeadENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objASPHeadENEx.android) == false)
            {
                //   strCodeForCs.AppendFormat("\r\n" + "xmlns:android=\"http://schemas.android.com/apk/res/android\"");
                strCodeForCs.AppendFormat("\r\n" + "xmlns:android=\"{0}\"",
                    objASPHeadENEx.android);
            }
            if (string.IsNullOrEmpty(objASPHeadENEx.app) == false)
            {
                //      strCodeForCs.AppendFormat("\r\n" + "    xmlns:app=\"http://schemas.android.com/apk/res-auto\"");
                strCodeForCs.AppendFormat("\r\n" + "    xmlns:app=\"{0}\"",
                    objASPHeadENEx.app);
            }
            if (string.IsNullOrEmpty(objASPHeadENEx.tools) == false)
            {
                //  strCodeForCs.AppendFormat("\r\n" + "    xmlns:tools=\"http://schemas.android.com/tools\"");
                strCodeForCs.AppendFormat("\r\n" + "    xmlns:tools=\"{0}\"",
                    objASPHeadENEx.tools);
            }
            //生成控件的样式
            clsASPControlBLEx.GC4Style(objASPHeadENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPHeadENEx, strCodeForCs);

            if (string.IsNullOrEmpty(objASPHeadENEx.layout_behavior) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "    app:layout_behavior=\"@string/appbar_scrolling_view_behavior\"");
            }
            if (string.IsNullOrEmpty(objASPHeadENEx.context) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "    tools:context=\"{0}\"",
                    objASPHeadENEx.context);
            }
            if (string.IsNullOrEmpty(objASPHeadENEx.showIn) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "    tools:showIn=\"{0}\"",
                    objASPHeadENEx.showIn);
            }
            //生成控件的约束-即与四周控件的约束关系
            clsASPControlBLEx.GC4Constraint(objASPHeadENEx, strCodeForCs);
            strCodeForCs.AppendFormat(">");


            foreach (ASPControlEx objSubASPControlENEx in objASPHeadENEx.arrSubAspControlLst2)
            {
                //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.AppendFormat("\r\n" + "</android.support.constraint.Head>");
        }
        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPHeadENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPHeadEx objASPHeadENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private Head {0};",
                objASPHeadENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPHeadENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPHeadEx objASPHeadENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (Head)findViewById(R.id.{0}); ",
                objASPHeadENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPHeadENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPHeadEx objASPHeadENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (Head)view.findViewById(R.id.{0}); ",
                objASPHeadENEx.CtrlId);

        }


        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPHeadENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPHeadEx objASPHeadENEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPHeadENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPHeadENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
            //    objASPHeadENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPHeadENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.ObjOutRelaTab().TabName,
               objASPHeadENEx.objDGRegionFldsEN.ObjFieldTab_PC().FldName);
            //strCodeForCs.Append("\r\n }");
        }

    }
}