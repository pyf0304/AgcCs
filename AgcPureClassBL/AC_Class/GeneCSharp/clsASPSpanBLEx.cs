
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPSpanBLEx
表名:ASPNETSpan(00050425)
生成代码版本:2019.03.02.1
生成日期:2019/03/02 15:49:12
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
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.02.22.01
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
using System.Web.UI.HtmlControls;
using AGC.Entity;

namespace AGC.PureClassEx
{
    /// <summary>
    /// ASPNETSpan标签(ASPNETSpan)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public static class clsASPSpanBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPSpanENEx">文本视图对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this ASPSpanEx objASPSpanENEx, enumApplicationType intApplicationTypeId,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            switch (intApplicationTypeId)
            {
                case enumApplicationType.WebApp_2:

                    if (string.IsNullOrEmpty(objASPSpanENEx.mKey) == true)
                    {
                        strKey = "";
                    }
                    else
                    {
                        strKey = string.Format("key=\"{0}\"", objASPSpanENEx.mKey);
                    }

                    strCodeForCs.AppendFormat("\r\n" + "<span");

                    //生成控件的Id、Name
                    clsASPControlBLEx.GC4IdName(objASPSpanENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_hidden(objASPSpanENEx, strCodeForCs);
                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPSpanENEx, strCodeForCs);

                    //生成控件的样式
                    clsASPControlBLEx.GC4Style(objASPSpanENEx, strCodeForCs);

                    //生成控件的尺寸-高、宽
                    //clsASPControlBLEx.GC4Size(objASPSpanENEx, strCodeForCs);
                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPSpanENEx, strCodeForCs);

                    //if (string.IsNullOrEmpty(objASPSpanENEx.OnClick) == false)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "android:onClick=\"{0}\"",
                    //        objASPSpanENEx.OnClick);
                    //}

                    //生成控件的样式
                    //clsASPControlBLEx.GC4Text(objASPSpanENEx, strCodeForCs);

                    //生成控件的约束-即与四周控件的约束关系
                    clsASPControlBLEx.GC4Constraint(objASPSpanENEx, strCodeForCs);
                    //strCodeForCs.AppendFormat(" runat=\"server\" ");
                    strCodeForCs.AppendFormat(">");
                    if (string.IsNullOrEmpty(objASPSpanENEx.Text) == false)
                    {
                        strCodeForCs.AppendFormat("{0}",
                               objASPSpanENEx.Text);
                    }
                    //foreach (ASPControlEx objSubASPControlENEx in objASPSpanENEx.arrSubAspControlLst2)
                    //{
                    //    //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                    //    objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    //}
                    strCodeForCs.AppendFormat("</span>");
                    break;
                case enumApplicationType.AspMvcAjaxApp_20:
                case enumApplicationType.AspMvcApp_13:
                case enumApplicationType.AspMvcApp_TS_16:
                 
                    if (string.IsNullOrEmpty(objASPSpanENEx.mKey) == true)
                    {
                        strKey = "";
                    }
                    else
                    {
                        strKey = string.Format("key=\"{0}\"", objASPSpanENEx.mKey);
                    }

                    strCodeForCs.AppendFormat("\r\n" + "<span");

                    //生成控件的Id、Name
                    clsASPControlBLEx.GC4IdName(objASPSpanENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_hidden(objASPSpanENEx, strCodeForCs);
                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPSpanENEx, strCodeForCs);

                    //生成控件的样式
                    clsASPControlBLEx.GC4Style(objASPSpanENEx, strCodeForCs);

                    //生成控件的尺寸-高、宽
                    //clsASPControlBLEx.GC4Size(objASPSpanENEx, strCodeForCs);
                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPSpanENEx, strCodeForCs);

                    //if (string.IsNullOrEmpty(objASPSpanENEx.OnClick) == false)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "android:onClick=\"{0}\"",
                    //        objASPSpanENEx.OnClick);
                    //}

                    //生成控件的样式
                    //clsASPControlBLEx.GC4Text(objASPSpanENEx, strCodeForCs);

                    //生成控件的约束-即与四周控件的约束关系
                    clsASPControlBLEx.GC4Constraint(objASPSpanENEx, strCodeForCs);
                    //strCodeForCs.AppendFormat(" runat=\"server\" ");
                    strCodeForCs.AppendFormat(">");
                    if (string.IsNullOrEmpty(objASPSpanENEx.Text) == false)
                    {
                        strCodeForCs.AppendFormat("{0}",
                               objASPSpanENEx.Text);
                    }
                    //foreach (ASPControlEx objSubASPControlENEx in objASPSpanENEx.arrSubAspControlLst2)
                    //{
                    //    //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                    //    objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    //}
                    strCodeForCs.AppendFormat("</span>");
                    break;
                case enumApplicationType.SpaAppInCore_TS_18:
                case enumApplicationType.VueAppInCore_TS_30:

                    if (string.IsNullOrEmpty(objASPSpanENEx.mKey) == true)
                    {
                        strKey = "";
                    }
                    else
                    {
                        strKey = string.Format("key=\"{0}\"", objASPSpanENEx.mKey);
                    }

                    strCodeForCs.AppendFormat("\r\n" + "<span");

                    //生成控件的Id、Name
                    clsASPControlBLEx.GC4IdName(objASPSpanENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_hidden(objASPSpanENEx, strCodeForCs);
                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPSpanENEx, strCodeForCs);

                    //生成控件的样式
                    clsASPControlBLEx.GC4Style(objASPSpanENEx, strCodeForCs);

                    //生成控件的尺寸-高、宽
                    //clsASPControlBLEx.GC4Size(objASPSpanENEx, strCodeForCs);
                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPSpanENEx, strCodeForCs);

                    //if (string.IsNullOrEmpty(objASPSpanENEx.OnClick) == false)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "android:onClick=\"{0}\"",
                    //        objASPSpanENEx.OnClick);
                    //}

                    //生成控件的样式
                    //clsASPControlBLEx.GC4Text(objASPSpanENEx, strCodeForCs);

                    //生成控件的约束-即与四周控件的约束关系
                    clsASPControlBLEx.GC4Constraint(objASPSpanENEx, strCodeForCs);
                    //strCodeForCs.AppendFormat(" runat=\"server\" ");
                    strCodeForCs.AppendFormat(">");
                    if (string.IsNullOrEmpty(objASPSpanENEx.Text) == false)
                    {
                        strCodeForCs.AppendFormat("{0}",
                               objASPSpanENEx.Text);
                    }
                    //foreach (ASPControlEx objSubASPControlENEx in objASPSpanENEx.arrSubAspControlLst2)
                    //{
                    //    //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                    //    objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
                    //}
                    strCodeForCs.AppendFormat("</span>");
                    break;
                default:
                    var objApp = clsApplicationTypeBL.GetObjByApplicationTypeIdCache((int)intApplicationTypeId);
                    var strMsg = string.Format("应用:[{0}]在函数Switch中没有被处理.(in {1})", objApp.ApplicationTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;
            }
         
        }


        //public static void GeneCode4Html(this ASPSpanEx objASPSpanENEx, enumApplicationType intApplicationTypeId,
        //  StringBuilder strCodeForCs)
        //{
        //    string strActionId = AgcPubFun.getASPNETID();
        //    string strKey = "";
        //    if (string.IsNullOrEmpty(objASPSpanENEx.mKey) == true)
        //    {
        //        strKey = "";
        //    }
        //    else
        //    {
        //        strKey = string.Format("key=\"{0}\"", objASPSpanENEx.mKey);
        //    }

        //    strCodeForCs.AppendFormat("\r\n" + "<span");

        //    //生成控件的Id、Name
        //    clsASPControlBLEx.GC4IdName(objASPSpanENEx, strCodeForCs);
        //    clsASPControlBLEx.GC4Aria_hidden(objASPSpanENEx, strCodeForCs);
        //    //生成控件的Tag
        //    clsASPControlBLEx.GC4Tag(objASPSpanENEx, strCodeForCs);

        //    //生成控件的样式
        //    clsASPControlBLEx.GC4Style(objASPSpanENEx, strCodeForCs);

        //    //生成控件的尺寸-高、宽
        //    //clsASPControlBLEx.GC4Size(objASPSpanENEx, strCodeForCs);
        //    //生成控件的边界尺寸-即与四周的距离
        //    clsASPControlBLEx.GC4Margin(objASPSpanENEx, strCodeForCs);


        //    //生成控件的样式
        //    //clsASPControlBLEx.GC4Text(objASPSpanENEx, strCodeForCs);

        //    //生成控件的约束-即与四周控件的约束关系
        //    clsASPControlBLEx.GC4Constraint(objASPSpanENEx, strCodeForCs);
        //    //strCodeForCs.AppendFormat(" runat=\"server\" ");
        //    strCodeForCs.AppendFormat(">");
        //    if (string.IsNullOrEmpty(objASPSpanENEx.Text) == false)
        //    {
        //        strCodeForCs.AppendFormat("{0}",
        //               objASPSpanENEx.Text);
        //    }
        //    foreach (ASPControlEx objSubASPControlENEx in objASPSpanENEx.arrSubAspControlLst2)
        //    {
        //        //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
        //        objSubASPControlENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
        //    }
        //    strCodeForCs.AppendFormat("</span>");
        //}

        public static void GeneCode4Mvc(this ASPSpanEx objASPSpanENEx,
         StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPSpanENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPSpanENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<span");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPSpanENEx, strCodeForCs);
            clsASPControlBLEx.GC4Aria_hidden(objASPSpanENEx, strCodeForCs);
            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPSpanENEx, strCodeForCs);

            //生成控件的样式
            clsASPControlBLEx.GC4Style(objASPSpanENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            //clsASPControlBLEx.GC4Size(objASPSpanENEx, strCodeForCs);
            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPSpanENEx, strCodeForCs);

            //if (string.IsNullOrEmpty(objASPSpanENEx.OnClick) == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:onClick=\"{0}\"",
            //        objASPSpanENEx.OnClick);
            //}

            //生成控件的样式
            //clsASPControlBLEx.GC4Text(objASPSpanENEx, strCodeForCs);

            //生成控件的约束-即与四周控件的约束关系
            clsASPControlBLEx.GC4Constraint(objASPSpanENEx, strCodeForCs);
            //strCodeForCs.AppendFormat(" runat=\"server\" ");
            strCodeForCs.AppendFormat(">");
            if (string.IsNullOrEmpty(objASPSpanENEx.Text) == false)
            {
                strCodeForCs.AppendFormat("{0}",
                       objASPSpanENEx.Text);
            }
            //foreach (ASPControlEx objSubASPControlENEx in objASPSpanENEx.arrSubAspControlLst2)
            //{
            //    //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
            //    objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            //}
            strCodeForCs.AppendFormat("</span>");
        }

        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPSpanENEx">编辑文本框对象</param>      
        public static void GeneHtmlControl(this ASPSpanEx objASPSpanENEx, HtmlContainerControl objContainer)
        {
            string strActionId = AgcPubFun.getASPNETID();
            
            HtmlGenericControl objSpan = new HtmlGenericControl("span");
            objSpan.Attributes["class"] = objASPSpanENEx.Class;
            objSpan.ID = objASPSpanENEx.CtrlId;
            objSpan.InnerHtml = objASPSpanENEx.Text;
            objContainer.Controls.Add(objSpan);
            foreach (ASPControlEx objSubASPControlENEx in objASPSpanENEx.arrSubAspControlLst2)
            {
                 objSubASPControlENEx.GeneHtmlControl(objSpan);
                
            }
            //return objSpan;
        }
    }
    /// <summary>
    /// ASPNETSpan标签(ASPNETSpan)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public class clsASPSpanBLEx 
    {


        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPSpanENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPSpanEx objASPSpanENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private Label {0};",
                objASPSpanENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPSpanENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPSpanEx objASPSpanENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (Label)findViewById(R.id.{0});",
                objASPSpanENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPSpanENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPSpanEx objASPSpanENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (Label)view.findViewById(R.id.{0});",
                objASPSpanENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段控件的获取控件值(查询区字段)
        /// </summary>
        /// <param name="objASPSpanENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Qry(ASPSpanEx objASPSpanENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPSpanENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objASPSpanENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
                objASPSpanENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}_q()", objASPSpanENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n return {0};",
          AgcPubFun.getStringToOtherTypeCode4DataType4Java(objASPSpanENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                  string.Format("{0}.getText().toString()", objASPSpanENEx.CtrlId)));
            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的获取控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPSpanENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_GetValue4FieldCtrl4Edit(ASPSpanEx objASPSpanENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPSpanENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //获取{0}({1})的值", objASPSpanENEx.objEditRegionFldsEN.ObjFieldTab_PC().Caption,
                objASPSpanENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);
            strCodeForCs.AppendFormat("\r\n public {0} get{1}()", objASPSpanENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                strTemp);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n return {0};",
                      AgcPubFun.getStringToOtherTypeCode4DataType4Java(objASPSpanENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                              string.Format("{0}.getText().toString()", objASPSpanENEx.CtrlId)));
            strCodeForCs.Append("\r\n }");

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPSpanENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Qry(ASPSpanEx objASPSpanENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPSpanENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPSpanENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
                objASPSpanENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPSpanENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setText({1});",
    objASPSpanENEx.CtrlId,
    AgcPubFun.getToStringCode4DataType4Java(objASPSpanENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType, "value"));

            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(编辑区字段)
        /// </summary>
        /// <param name="objASPSpanENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_SetValue4FieldCtrl4Edit(ASPSpanEx objASPSpanENEx,
            StringBuilder strCodeForCs)
        {
            string strTemp = objASPSpanENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName;

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPSpanENEx.objEditRegionFldsEN.ObjFieldTab_PC().Caption,
                objASPSpanENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName);

            strCodeForCs.AppendFormat("\r\n public void set{0}({1} value)", strTemp,
                objASPSpanENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n {0}.setText({1});",
                objASPSpanENEx.CtrlId,
                AgcPubFun.getToStringCode4DataType4Java(objASPSpanENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType, "value"));
            strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPSpanENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPSpanEx objASPSpanENEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPSpanENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPSpanENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
            //    objASPSpanENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPSpanENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            //strCodeForCs.Append("\r\n{");
            //strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
            //   objViewInfoENEx.ObjOutRelaTab().TabName,
            //   objASPSpanENEx.objDGRegionFldsEN.ObjFieldTab_PC().FldName);

            strCodeForCs.AppendFormat("\r\n" + "tv{0}.setText({1});",
            objASPSpanENEx.objDGRegionFldsEN.ObjFieldTab_PC().FldName,
            AgcPubFun.getToStringCode4DataType4Java(
                objASPSpanENEx.objDGRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType,
                string.Format("obj{0}EN.get{1}()",
                objViewInfoENEx.ObjOutRelaTab().TabName,
                objASPSpanENEx.objDGRegionFldsEN.ObjFieldTab_PC().FldName)));

            //strCodeForCs.Append("\r\n }");
        }

        /// <summary>
        /// 生成字段控件的清空代码(编辑区字段)
        /// </summary>
        /// <param name="objASPSpanENEx"></param>        
        /// <param name="strCodeForCs"></param>
        public static void Gen_ClearFieldCtrl4Edit(ASPSpanEx objASPSpanENEx, StringBuilder strCodeForCs, string strCmPrjId)
        {
            strCodeForCs.AppendFormat("\r\n" + "tv{0}.setText(\"\");",
               objASPSpanENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldName);
            strCodeForCs.AppendFormat("// {0}", objASPSpanENEx.objEditRegionFldsEN.ObjFieldTab_PC().Caption);
            strCodeForCs.AppendFormat("" + "(说明:{3};字段类型:{0};字段长度:{1};,是否可空:{2})",
            objASPSpanENEx.objEditRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().DataTypeName,
            objASPSpanENEx.objEditRegionFldsEN.ObjFieldTab_PC().FldLength,
            objASPSpanENEx.objEditRegionFldsEN.IsTabNullable(strCmPrjId),
            objASPSpanENEx.objEditRegionFldsEN.MemoInTab(strCmPrjId));

        }

        /// <summary>
        /// 建立[存放功能按钮的表]
        /// </summary>
        /// <returns></returns>
        public static ASPSpanEx GetDataListTitle(string strTabName, string strTabCnName)
        {
            //strCodeForCs.AppendFormat("\r\n" + "<asp:label id = \"lbl{0}List\" runat = \"server\" style = \"z-index: 105; \" ",
            //  objViewInfoENEx.ObjMainPrjTab().TabName);
            //strCodeForCs.AppendFormat("\r\n" + "CssClass = \"h6\" Width = \"250px\">{0}列表</asp:label>",
            //  objViewInfoENEx.ObjInRelaTab().TabCnName);

            ASPSpanEx objASPSpanENEx = new ASPSpanEx();
            objASPSpanENEx.CtrlId = string.Format("lbl{0}List", strTabName);
            objASPSpanENEx.Text = string.Format("{0}列表", strTabCnName);
            //objASPSpanENEx.Style = "z-index: 105; ";
            objASPSpanENEx.Class = "h6";
            objASPSpanENEx.Width = 250;
            objASPSpanENEx.Height = 0;
            return objASPSpanENEx;
        }

        public static ASPSpanEx GetDataListMsg(string lngRegionId)
        {
            //strCodeForCs.AppendFormat("\r\n" + "<asp:label id = \"lbl{0}List\" runat = \"server\" style = \"z-index: 105; \" ",
            //  objViewInfoENEx.ObjMainPrjTab().TabName);
            //strCodeForCs.AppendFormat("\r\n" + "CssClass = \"h6\" Width = \"250px\">{0}列表</asp:label>",
            //  objViewInfoENEx.ObjInRelaTab().TabCnName);

            ASPSpanEx objASPSpanENEx = new ASPSpanEx();
            objASPSpanENEx.CtrlId = string.Format("spnMsg_Lst{0}", lngRegionId);
            //objASPSpanENEx.Style = "z-index: 105; ";
            objASPSpanENEx.Class = "text-warning";
            objASPSpanENEx.Width = 0;
            objASPSpanENEx.Height = 0;
            return objASPSpanENEx;
        }
        public static ASPSpanEx GetspnExportExcel(bool bolIs4Mvc = false)
        {
            ASPSpanEx objASPSpanENEx = new ASPSpanEx();
            objASPSpanENEx.Is4Mvc = bolIs4Mvc;

            //  <input value="下移" id="btnDownMove" name="action:DownMove" type="submit" class="btn btn-default" />
            objASPSpanENEx.CtrlId = "spnExportExcel";

            //objASPSpanENEx.OnClick = "btnAddNewRec4Gv_Click";
            objASPSpanENEx.Value = "";
            objASPSpanENEx.Style = "";
            objASPSpanENEx.Class = "";
            objASPSpanENEx.CssClass = "";
            //objASPSpanENEx.Width = 80;
            //objASPSpanENEx.Height = 0;

            return objASPSpanENEx;
        }

        public static ASPSpanEx GetEmptySpan()
        {
            ASPSpanEx objASPSpanENEx = new ASPSpanEx();
            //objASPSpanENEx.CtrlId = "divFunction";

            return objASPSpanENEx;
        }

    }
}