
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPDivBLEx
表名:ASPNETDiv(00050221)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:55:38
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
using System.Web.UI.HtmlControls;

namespace AGC.PureClassEx
{
    /// <summary>
    /// ASPNET层(ASPNETDiv)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPDivBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPDivENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this ASPDivEx objASPDivENEx, enumApplicationType intApplicationTypeId,
            StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            switch (intApplicationTypeId)
            {
                case enumApplicationType.WebApp_2:
                case enumApplicationType.WebApi_19:
                    if (string.IsNullOrEmpty(objASPDivENEx.mKey) == true)
                    {
                        strKey = "";
                    }
                    else
                    {
                        strKey = string.Format("key=\"{0}\"", objASPDivENEx.mKey);
                    }
                    if (string.IsNullOrEmpty(objASPDivENEx.Comment) == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0}", objASPDivENEx.Comment);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "<div");

                    //生成控件的Id、Name
                    //clsASPControlBLEx.GC4IdName(objASPDivENEx, strCodeForCs);
                    if (string.IsNullOrEmpty(objASPDivENEx.CtrlId) == false)
                    {
                        strCodeForCs.AppendFormat(" id=\"{0}\"",
                        objASPDivENEx.CtrlId);
                    }

                    if (string.IsNullOrEmpty(objASPDivENEx.Ref) == false)
                    {
                        strCodeForCs.AppendFormat(" ref=\"{0}\"",
                        objASPDivENEx.Ref);
                    }

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Style(objASPDivENEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPDivENEx, strCodeForCs);

                    //生成控件的尺寸-高、宽
                    clsASPControlBLEx.GC4Size(objASPDivENEx, strCodeForCs);

                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPDivENEx, strCodeForCs);
                    //生成线性布局的子控件的布局方向-横向、纵向
                    //if (string.IsNullOrEmpty(objASPDivENEx.orientation) == false)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
                    //        objASPDivENEx.orientation);
                    //}
                    clsASPControlBLEx.GC4Role(objASPDivENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Tabindex(objASPDivENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_labelledby(objASPDivENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_hidden(objASPDivENEx, strCodeForCs);

                    strCodeForCs.AppendFormat(">");

                    foreach (ASPControlEx objSubASPControlENEx in objASPDivENEx.arrSubAspControlLst2)
                    {
                        //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                        objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs); ;
                    }
                    if (objASPDivENEx.ContentFunc != null)
                    {
                        string strTemp = objASPDivENEx.ContentFunc();
                        strCodeForCs.AppendFormat("\r\n" + strTemp);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "</div>");
                    break;
                case enumApplicationType.AspMvcAjaxApp_20:
                case enumApplicationType.AspMvcApp_13:
                case enumApplicationType.AspMvcApp_TS_16:
                    if (string.IsNullOrEmpty(objASPDivENEx.mKey) == true)
                    {
                        strKey = "";
                    }
                    else
                    {
                        strKey = string.Format("key=\"{0}\"", objASPDivENEx.mKey);
                    }
                    if (string.IsNullOrEmpty(objASPDivENEx.Comment) == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0}", objASPDivENEx.Comment);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "<div");

                    //生成控件的Id、Name
                    //clsASPControlBLEx.GC4IdName(objASPDivENEx, strCodeForCs);
                    if (string.IsNullOrEmpty(objASPDivENEx.CtrlId) == false)
                    {
                        strCodeForCs.AppendFormat(" id=\"{0}\"",
                        objASPDivENEx.CtrlId);
                    }
                    //生成控件的Tag
                    clsASPControlBLEx.GC4Style(objASPDivENEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPDivENEx, strCodeForCs);

                    //生成控件的尺寸-高、宽
                    clsASPControlBLEx.GC4Size(objASPDivENEx, strCodeForCs);

                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPDivENEx, strCodeForCs);
                    //生成线性布局的子控件的布局方向-横向、纵向
                    //if (string.IsNullOrEmpty(objASPDivENEx.orientation) == false)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
                    //        objASPDivENEx.orientation);
                    //}
                    clsASPControlBLEx.GC4Role(objASPDivENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Tabindex(objASPDivENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_labelledby(objASPDivENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_hidden(objASPDivENEx, strCodeForCs);

                    strCodeForCs.AppendFormat(">");

                    foreach (ASPControlEx objSubASPControlENEx in objASPDivENEx.arrSubAspControlLst2)
                    {
                        //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                        objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs); ;
                    }
                    if (objASPDivENEx.ContentFunc != null)
                    {
                        string strTemp = objASPDivENEx.ContentFunc();
                        strCodeForCs.AppendFormat("\r\n" + strTemp);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "</div>");
                    break;
                case enumApplicationType.SpaAppInCore_TS_18:
                case enumApplicationType.VueAppInCore_TS_30:
                    if (string.IsNullOrEmpty(objASPDivENEx.mKey) == true)
                    {
                        strKey = "";
                    }
                    else
                    {
                        strKey = string.Format("key=\"{0}\"", objASPDivENEx.mKey);
                    }
                    if (string.IsNullOrEmpty(objASPDivENEx.Comment) == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0}", objASPDivENEx.Comment);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "<div");

                    //生成控件的Id、Name
                    //clsASPControlBLEx.GC4IdName(objASPDivENEx, strCodeForCs);
                    if (string.IsNullOrEmpty(objASPDivENEx.CtrlId) == false)
                    {
                        strCodeForCs.AppendFormat(" id=\"{0}\"",
                        objASPDivENEx.CtrlId);
                    }
                    if (string.IsNullOrEmpty(objASPDivENEx.Ref) == false)
                    {
                        strCodeForCs.AppendFormat(" ref=\"{0}\"",
                        objASPDivENEx.Ref);
                    }
                    //生成控件的Tag
                    clsASPControlBLEx.GC4Style(objASPDivENEx, strCodeForCs);

                    //生成控件的Tag
                    clsASPControlBLEx.GC4Tag(objASPDivENEx, strCodeForCs);

                    //生成控件的尺寸-高、宽
                    clsASPControlBLEx.GC4Size(objASPDivENEx, strCodeForCs);

                    //生成控件的边界尺寸-即与四周的距离
                    clsASPControlBLEx.GC4Margin(objASPDivENEx, strCodeForCs);
                    //生成线性布局的子控件的布局方向-横向、纵向
                    //if (string.IsNullOrEmpty(objASPDivENEx.orientation) == false)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
                    //        objASPDivENEx.orientation);
                    //}
                    clsASPControlBLEx.GC4Role(objASPDivENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Tabindex(objASPDivENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_labelledby(objASPDivENEx, strCodeForCs);
                    clsASPControlBLEx.GC4Aria_hidden(objASPDivENEx, strCodeForCs);

                    strCodeForCs.AppendFormat(">");

                    foreach (ASPControlEx objSubASPControlENEx in objASPDivENEx.arrSubAspControlLst2)
                    {
                        //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                        objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs); ;
                    }
                    if (objASPDivENEx.ContentFunc != null)
                    {
                        string strTemp = objASPDivENEx.ContentFunc();
                        strCodeForCs.AppendFormat("\r\n" + strTemp);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "</div>");
                    break;
                default:
                    var objApp = clsApplicationTypeBL.GetObjByApplicationTypeIdCache((int)intApplicationTypeId);
                    var strMsg = string.Format("应用:[{0}]在函数Switch中没有被处理.(in {1})", objApp.ApplicationTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                    //break;
            }
          
     

        }

        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPDivENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        //public static void GeneCode4Html(this ASPDivEx objASPDivENEx, enumApplicationType intApplicationTypeId,
        //    StringBuilder strCodeForCs)
        //{
        //    string strActionId = AgcPubFun.getASPNETID();
        //    string strKey = "";
        //    if (string.IsNullOrEmpty(objASPDivENEx.mKey) == true)
        //    {
        //        strKey = "";
        //    }
        //    else
        //    {
        //        strKey = string.Format("key=\"{0}\"", objASPDivENEx.mKey);
        //    }
        //    if (string.IsNullOrEmpty(objASPDivENEx.Comment) == false)
        //    {
        //        strCodeForCs.AppendFormat("\r\n" + "{0}", objASPDivENEx.Comment);
        //    }
        //    strCodeForCs.AppendFormat("\r\n" + "<div");

        //    //生成控件的Id、Name
        //    //clsASPControlBLEx.GC4IdName(objASPDivENEx, strCodeForCs);
        //    if (string.IsNullOrEmpty(objASPDivENEx.CtrlId) == false)
        //    {
        //        strCodeForCs.AppendFormat(" id=\"{0}\"",
        //        objASPDivENEx.CtrlId);
        //    }
        //    //生成控件的Tag
        //    clsASPControlBLEx.GC4Style(objASPDivENEx, strCodeForCs);

        //    //生成控件的Tag
        //    clsASPControlBLEx.GC4Tag(objASPDivENEx, strCodeForCs);

        //    //生成控件的尺寸-高、宽
        //    clsASPControlBLEx.GC4Size(objASPDivENEx, strCodeForCs);

        //    //生成控件的边界尺寸-即与四周的距离
        //    clsASPControlBLEx.GC4Margin(objASPDivENEx, strCodeForCs);
        //    //生成线性布局的子控件的布局方向-横向、纵向
        //    //if (string.IsNullOrEmpty(objASPDivENEx.orientation) == false)
        //    //{
        //    //    strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
        //    //        objASPDivENEx.orientation);
        //    //}
        //    clsASPControlBLEx.GC4Role(objASPDivENEx, strCodeForCs);
        //    clsASPControlBLEx.GC4Tabindex(objASPDivENEx, strCodeForCs);
        //    clsASPControlBLEx.GC4Aria_labelledby(objASPDivENEx, strCodeForCs);
        //    clsASPControlBLEx.GC4Aria_hidden(objASPDivENEx, strCodeForCs);

        //    strCodeForCs.AppendFormat(">");

        //    foreach (ASPControlEx objSubASPControlENEx in objASPDivENEx.arrSubAspControlLst2)
        //    {
        //        //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
        //        objSubASPControlENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
        //    }
        //    if (objASPDivENEx.ContentFunc != null)
        //    {
        //        string strTemp = objASPDivENEx.ContentFunc();
        //        strCodeForCs.AppendFormat("\r\n" + strTemp);
        //    }
        //    strCodeForCs.AppendFormat("\r\n" + "</div>");

        //}



        public static void GeneCode4Mvc(this ASPDivEx objASPDivENEx,
          StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();
            string strKey = "";
            if (string.IsNullOrEmpty(objASPDivENEx.mKey) == true)
            {
                strKey = "";
            }
            else
            {
                strKey = string.Format("key=\"{0}\"", objASPDivENEx.mKey);
            }

            strCodeForCs.AppendFormat("\r\n" + "<div");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPDivENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Style(objASPDivENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPDivENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPDivENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPDivENEx, strCodeForCs);
            //生成线性布局的子控件的布局方向-横向、纵向
            //if (string.IsNullOrEmpty(objASPDivENEx.orientation) == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "android:orientation=\"{0}\"",
            //        objASPDivENEx.orientation);
            //}
            clsASPControlBLEx.GC4Role(objASPDivENEx, strCodeForCs);
            clsASPControlBLEx.GC4Tabindex(objASPDivENEx, strCodeForCs);
            clsASPControlBLEx.GC4Aria_labelledby(objASPDivENEx, strCodeForCs);
            clsASPControlBLEx.GC4Aria_hidden(objASPDivENEx, strCodeForCs);

            strCodeForCs.AppendFormat(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPDivENEx.arrSubAspControlLst2)
            {
                //if (objSubASPControlENEx.CtlTypeId != enumCtlType.ASPNETAutoresizingMask) continue;
                objSubASPControlENEx.GeneCode4Mvc(strCodeForCs);
            }
            if (objASPDivENEx.ContentFunc != null)
            {
                string strTemp = objASPDivENEx.ContentFunc();
                strCodeForCs.AppendFormat("\r\n" + strTemp);
            }
            strCodeForCs.AppendFormat("\r\n" + "</div>");

        }


        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPLabelENEx">编辑文本框对象</param>      
        public static void GeneHtmlControl(this ASPDivEx objASPDivENEx, HtmlContainerControl objContainer)
        {
            string strActionId = AgcPubFun.getASPNETID();

            HtmlGenericControl objDiv = new HtmlGenericControl("div");
            if (string.IsNullOrEmpty(objASPDivENEx.Class) == true)
            {
                objDiv.Attributes["class"] = objASPDivENEx.CssClass;
            }
            else
            {
                objDiv.Attributes["class"] = objASPDivENEx.Class;
            }
            objDiv.ID = objASPDivENEx.CtrlId;
            objDiv.InnerHtml = objASPDivENEx.Text;
            if (string.IsNullOrEmpty(objASPDivENEx.OnClick4Html) == false)
            {
                objDiv.Attributes.Add("onclick", objASPDivENEx.OnClick4Html);
            }
            objContainer.Controls.Add(objDiv);
            foreach (ASPControlEx objSubASPControlENEx in objASPDivENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneHtmlControl(objDiv);
            }
            //return objDiv;
        }
    }
    
    /// <summary>
     /// ASPNET层(ASPNETDiv)
     /// 数据源类型:SQL表
     /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
     /// </summary>
    public class clsASPDivBLEx 
        {
        
        public static ASPDivEx GetEmptyDiv()
        {
            ASPDivEx objASPDivENEx = new ASPDivEx();
            //objASPDivENEx.CtrlId = "divFunction";
            //objASPDivENEx.OnClick = "btnAddNewRec4Gv_Click";
            //objASPDivENEx.Text = "添加记录";
            //objASPDivENEx.Style = "width: 100%; height: 32px; ";
            //objASPDivENEx.Class = "msgtable";
            //objASPDivENEx.Width = 80;
            //objASPDivENEx.Height = 0;
            return objASPDivENEx;
        }

        public static ASPDivEx GetRowDiv()
        {
            ASPDivEx objASPDivENEx = new ASPDivEx();
            objASPDivENEx.CtrlId = "";
            objASPDivENEx.Class = "row";

            //objASPDivENEx.OnClick = "btnAddNewRec4Gv_Click";
            //objASPDivENEx.Text = "添加记录";
            //objASPDivENEx.Style = "width: 100%; height: 32px; ";
            //objASPDivENEx.Width = 80;
            //objASPDivENEx.Height = 0;
            return objASPDivENEx;
        }

        public static ASPDivEx GetObj4DetailRegion()
        {
            ASPDivEx objASPDivENEx = new ASPDivEx();
            objASPDivENEx.CtrlId = "";
            objASPDivENEx.Class = "row";
            objASPDivENEx.Style = "width: 100%; ";
            return objASPDivENEx;
        }

        public static void GeneCodeBak(ASPDivEx objASPDivENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        {
            strCodeForCs.Append("\r\n" + "<div style = \"position: relative; width: 648px; height: 37px; left: 0px; top: 0px;\">");

            foreach (ASPControlEx objSubASPControlENEx in objASPDivENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);;
            }
            strCodeForCs.Append("\r\n" + "</div>");

        }


    
        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPDivENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPDivEx objASPDivENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private Div tw{0};",
                objASPDivENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPDivENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPDivEx objASPDivENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "tw{0} = (Div)findViewById(R.id.tw{0}); ",
                objASPDivENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPDivENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPDivEx objASPDivENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "tw{0} = (Div)view.findViewById(R.id.tw{0}); ",
                objASPDivENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPDivENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPDivEx objASPDivENEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPDivENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPDivENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
            //    objASPDivENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPDivENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.ObjOutRelaTab().TabName,
               objASPDivENEx.objDGRegionFldsEN.ObjFieldTab_PC().FldName);
            //strCodeForCs.Append("\r\n }");
        }

        public static ASPDivEx PackageByDivTable4DetailRegion(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        {
            ASPDivEx objDivTable = clsASPDivBLEx.GetObj4DetailRegion();

            //封装Td
            List<ASPControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageDiv).ToList();

            //int intCount = 0;
            //ASPLiEx objLi = new ASPLiEx();
            Dictionary<int, string> dicColNumWidth = new Dictionary<int, string>();
            dicColNumWidth.Add(1, "3,9");
            dicColNumWidth.Add(2, "2,4");
            dicColNumWidth.Add(3, "1,3");
            dicColNumWidth.Add(4, "1,2");
            if (intColNum > 4) intColNum = 4;
            foreach (ASPControlGroupEx objInFor in arrASPControlGroupObjLst)
            {
                if (objInFor.arrSubAspControlLst2.Count == 0) continue;
                string strWidths = dicColNumWidth[intColNum];
                string[] strwWidth = strWidths.Split(",".ToCharArray());
                foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
                {
                    if (objInFor2.IsCaption == true)
                    {
                        objInFor2.Class += string.Format(" col-{0} text-right", strwWidth[0]);
                    }
                    else
                    {
                        objInFor2.Class += string.Format(" col-{0}", strwWidth[1]);
                    }
                    objDivTable.arrSubAspControlLst2.Add(objInFor2);
                }
            }

            return objDivTable;
        }

        //public static ASPDivEx PackageByDivTable4DetailRegion(IEnumerable<VueControlGroupEx> arrControlGroups, int intColNum)
        //{
        //    ASPDivEx objDivTable = clsASPDivBLEx.GetObj4DetailRegion();

        //    //封装Td
        //    List<VueControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsVueControlGroupBLEx.PackageDiv).ToList();

        //    //int intCount = 0;
        //    //ASPLiEx objLi = new ASPLiEx();
        //    Dictionary<int, string> dicColNumWidth = new Dictionary<int, string>();
        //    dicColNumWidth.Add(1, "3,9");
        //    dicColNumWidth.Add(2, "2,4");
        //    dicColNumWidth.Add(3, "1,3");
        //    dicColNumWidth.Add(4, "1,2");
        //    if (intColNum > 4) intColNum = 4;
        //    foreach (VueControlGroupEx objInFor in arrASPControlGroupObjLst)
        //    {
        //        if (objInFor.arrSubAspControlLst2.Count == 0) continue;
        //        string strWidths = dicColNumWidth[intColNum];
        //        string[] strwWidth = strWidths.Split(",".ToCharArray());
        //        foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
        //        {
        //            if (objInFor2.IsCaption == true)
        //            {
        //                objInFor2.Class += string.Format(" col-{0} text-right", strwWidth[0]);
        //            }
        //            else
        //            {
        //                objInFor2.Class += string.Format(" col-{0}", strwWidth[1]);
        //            }
        //            objDivTable.arrSubAspControlLst2.Add(objInFor2);
        //        }
        //    }

        //    return objDivTable;
        //}



        public static ASPDivEx PackageByFormControl4DetailRegion(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        {
            ASPDivEx objDivTable = clsASPDivBLEx.GetEmptyDiv();

            //封装Td
            //List<ASPControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageDiv).ToList();

            //int intCount = 0;
            //ASPLiEx objLi = new ASPLiEx();
            Dictionary<int, string> dicColNumWidth = new Dictionary<int, string>();
            dicColNumWidth.Add(1, "3,9");
            dicColNumWidth.Add(2, "2,4");
            dicColNumWidth.Add(3, "1,3");
            dicColNumWidth.Add(4, "1,2");
            if (intColNum > 4) intColNum = 4;
            foreach (ASPControlGroupEx objInFor in arrControlGroups)
            {
                if (objInFor.arrSubAspControlLst2.Count == 0) continue;
                ASPDivEx objDiv = clsASPDivBLEx.GetEmptyDiv();
                objDiv.Class = "form-group";

                foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
                {
                    if (objInFor2.IsCaption == true)
                    {
                        objDiv.arrSubAspControlLst2.Add(objInFor2);
                        //objInFor2.Class += string.Format(" col-{0}", strwWidth[0]);
                    }
                    else
                    {
                        objDiv.arrSubAspControlLst2.Add(objInFor2);
                        //objInFor2.Class += string.Format(" col-{0}", strwWidth[1]);
                    }
                }
                objDivTable.arrSubAspControlLst2.Add(objDiv);
            }

            return objDivTable;
        }


        //public static ASPDivEx PackageByFormControl4DetailRegion(IEnumerable<VueControlGroupEx> arrControlGroups, int intColNum)
        //{
        //    ASPDivEx objDivTable = clsASPDivBLEx.GetEmptyDiv();

        //    //封装Td
        //    //List<VueControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageDiv).ToList();

        //    //int intCount = 0;
        //    //ASPLiEx objLi = new ASPLiEx();
        //    Dictionary<int, string> dicColNumWidth = new Dictionary<int, string>();
        //    dicColNumWidth.Add(1, "3,9");
        //    dicColNumWidth.Add(2, "2,4");
        //    dicColNumWidth.Add(3, "1,3");
        //    dicColNumWidth.Add(4, "1,2");
        //    if (intColNum > 4) intColNum = 4;
        //    foreach (VueControlGroupEx objInFor in arrControlGroups)
        //    {
        //        if (objInFor.arrSubAspControlLst2.Count == 0) continue;
        //        ASPDivEx objDiv = clsASPDivBLEx.GetEmptyDiv();
        //        objDiv.Class = "form-group";

        //        foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
        //        {
        //            if (objInFor2.IsCaption == true)
        //            {
        //                objDiv.arrSubAspControlLst2.Add(objInFor2);
        //                //objInFor2.Class += string.Format(" col-{0}", strwWidth[0]);
        //            }
        //            else
        //            {
        //                objDiv.arrSubAspControlLst2.Add(objInFor2);
        //                //objInFor2.Class += string.Format(" col-{0}", strwWidth[1]);
        //            }
        //        }
        //        objDivTable.arrSubAspControlLst2.Add(objDiv);
        //    }

        //    return objDivTable;
        //}

        public static ASPDivEx PackageByFormInline4DetailRegion(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        {
            ASPDivEx objDivTable = clsASPDivBLEx.GetEmptyDiv();
            objDivTable.Class = "form-inline";
            //封装Td
            //List<VueControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageDiv).ToList();

            Dictionary<int, string> dicColNumWidth = new Dictionary<int, string>();
            dicColNumWidth.Add(1, "3,9");
            dicColNumWidth.Add(2, "2,4");
            dicColNumWidth.Add(3, "1,3");
            dicColNumWidth.Add(4, "1,2");
            if (intColNum > 4) intColNum = 4;
            foreach (ASPControlGroupEx objInFor in arrControlGroups)
            {
                if (objInFor.arrSubAspControlLst2.Count == 0) continue;
                ASPDivEx objDiv = clsASPDivBLEx.GetEmptyDiv();
                objDiv.Class = "form-group";

                foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
                {
                    if (objInFor2.IsCaption == true)
                    {
                        objDiv.arrSubAspControlLst2.Add(objInFor2);
                        //objInFor2.Class += string.Format(" col-{0}", strwWidth[0]);
                    }
                    else
                    {
                        objDiv.arrSubAspControlLst2.Add(objInFor2);
                        //objInFor2.Class += string.Format(" col-{0}", strwWidth[1]);
                    }
                }
                objDivTable.arrSubAspControlLst2.Add(objDiv);
            }

            return objDivTable;
        }


        //public static ASPDivEx PackageByFormInline4DetailRegion(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        //{
        //    ASPDivEx objDivTable = clsASPDivBLEx.GetEmptyDiv();
        //    objDivTable.Class = "form-inline";
        //    //封装Td
        //    //List<VueControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageDiv).ToList();

        //    Dictionary<int, string> dicColNumWidth = new Dictionary<int, string>();
        //    dicColNumWidth.Add(1, "3,9");
        //    dicColNumWidth.Add(2, "2,4");
        //    dicColNumWidth.Add(3, "1,3");
        //    dicColNumWidth.Add(4, "1,2");
        //    if (intColNum > 4) intColNum = 4;
        //    foreach (ASPControlGroupEx objInFor in arrControlGroups)
        //    {
        //        if (objInFor.arrSubAspControlLst2.Count == 0) continue;
        //        ASPDivEx objDiv = clsASPDivBLEx.GetEmptyDiv();
        //        objDiv.Class = "form-group";

        //        foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
        //        {
        //            if (objInFor2.IsCaption == true)
        //            {
        //                objDiv.arrSubAspControlLst2.Add(objInFor2);
        //                //objInFor2.Class += string.Format(" col-{0}", strwWidth[0]);
        //            }
        //            else
        //            {
        //                objDiv.arrSubAspControlLst2.Add(objInFor2);
        //                //objInFor2.Class += string.Format(" col-{0}", strwWidth[1]);
        //            }
        //        }
        //        objDivTable.arrSubAspControlLst2.Add(objDiv);
        //    }

        //    return objDivTable;
        //}

        public static ASPDivEx PackageByDivTable4QueryRegion(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        {
            ASPDivEx objDivTable = clsASPDivBLEx.GetObj4DetailRegion();
            //封装Td
            List<ASPControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageDiv).ToList();

            //int intCount = 0;
            //ASPLiEx objLi = new ASPLiEx();
            Dictionary<int, string> dicColNumWidth = new Dictionary<int, string>();
            dicColNumWidth.Add(1, "3,9");
            dicColNumWidth.Add(2, "2,4");
            dicColNumWidth.Add(3, "1,3");
            dicColNumWidth.Add(4, "1,2");
            if (intColNum > 4) intColNum = 4;
            foreach (ASPControlGroupEx objInFor in arrASPControlGroupObjLst)
            {
                if (objInFor.arrSubAspControlLst2.Count == 0) continue;
                string strWidths = dicColNumWidth[intColNum];
                string[] strwWidth = strWidths.Split(",".ToCharArray());
                foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
                {
                    if (objInFor2.ColSpan_Ctrl > 1)
                    {
                        objInFor2.Class += string.Format(" col-{0}", int.Parse(strwWidth[0]) + int.Parse(strwWidth[1]));
                        objDivTable.arrSubAspControlLst2.Add(objInFor2);
                        continue;
                    }
                    if (objInFor2.IsCaption == true)
                    {
                        objInFor2.Class += string.Format(" col-{0} text-right", strwWidth[0]);
                    }
                    else
                    {
                        objInFor2.Class += string.Format(" col-{0}", strwWidth[1]);
                    }
                    objDivTable.arrSubAspControlLst2.Add(objInFor2);
                }
            }

            return objDivTable;
        }

        //public static ASPDivEx PackageByDivTable4QueryRegion(IEnumerable<VueControlGroupEx> arrControlGroups, int intColNum)
        //{
        //    ASPDivEx objDivTable = clsASPDivBLEx.GetObj4DetailRegion();
        //    //封装Td
        //    List<VueControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsVueControlGroupBLEx.PackageDiv).ToList();

        //    //int intCount = 0;
        //    //ASPLiEx objLi = new ASPLiEx();
        //    Dictionary<int, string> dicColNumWidth = new Dictionary<int, string>();
        //    dicColNumWidth.Add(1, "3,9");
        //    dicColNumWidth.Add(2, "2,4");
        //    dicColNumWidth.Add(3, "1,3");
        //    dicColNumWidth.Add(4, "1,2");
        //    if (intColNum > 4) intColNum = 4;
        //    foreach (VueControlGroupEx objInFor in arrASPControlGroupObjLst)
        //    {
        //        if (objInFor.arrSubAspControlLst2.Count == 0) continue;
        //        string strWidths = dicColNumWidth[intColNum];
        //        string[] strwWidth = strWidths.Split(",".ToCharArray());
        //        foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
        //        {
        //            if (objInFor2.ColSpan_Ctrl > 1)
        //            {
        //                objInFor2.Class += string.Format(" col-{0}", int.Parse(strwWidth[0]) + int.Parse(strwWidth[1]));
        //                objDivTable.arrSubAspControlLst2.Add(objInFor2);
        //                continue;
        //            }
        //            if (objInFor2.IsCaption == true)
        //            {
        //                objInFor2.Class += string.Format(" col-{0} text-right", strwWidth[0]);
        //            }
        //            else
        //            {
        //                objInFor2.Class += string.Format(" col-{0}", strwWidth[1]);
        //            }
        //            objDivTable.arrSubAspControlLst2.Add(objInFor2);
        //        }
        //    }

        //    return objDivTable;
        //}


        public static ASPDivEx PackageByDivTable4EditRegion(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        {
            ASPDivEx objDivTable = clsASPDivBLEx.GetObj4DetailRegion();
            //封装Td
            List<ASPControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageDiv).ToList();

            //int intCount = 0;
            //ASPLiEx objLi = new ASPLiEx();
            Dictionary<int, string> dicColNumWidth = new Dictionary<int, string>();
            dicColNumWidth.Add(1, "3,9");
            dicColNumWidth.Add(2, "2,4");
            dicColNumWidth.Add(3, "1,3");
            dicColNumWidth.Add(4, "1,2");
            if (intColNum > 4) intColNum = 4;
            foreach (ASPControlGroupEx objInFor in arrASPControlGroupObjLst)
            {
                if (objInFor.arrSubAspControlLst2.Count == 0) continue;
                string strWidths = dicColNumWidth[intColNum];
                string[] strwWidth = strWidths.Split(",".ToCharArray());
                foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
                {
                    if (objInFor2.ColSpan_Ctrl>1)
                    {
                        objInFor2.Class += string.Format(" col-{0}", int.Parse( strwWidth[0]) + int.Parse( strwWidth[1]));
                        objDivTable.arrSubAspControlLst2.Add(objInFor2);
                        continue;
                    }
                    if (objInFor2.IsCaption == true)
                    {
                        objInFor2.Class += string.Format(" col-{0} text-right", strwWidth[0]);
                    }
                    else
                    {
                        objInFor2.Class += string.Format(" col-{0}", strwWidth[1]);
                    }
                    objDivTable.arrSubAspControlLst2.Add(objInFor2);
                }
            }

            return objDivTable;
        }

        //public static ASPDivEx PackageByDivTable4EditRegion(IEnumerable<VueControlGroupEx> arrControlGroups, int intColNum)
        //{
        //    ASPDivEx objDivTable = clsASPDivBLEx.GetObj4DetailRegion();
        //    //封装Td
        //    List<VueControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsVueControlGroupBLEx.PackageDiv).ToList();

        //    //int intCount = 0;
        //    //ASPLiEx objLi = new ASPLiEx();
        //    Dictionary<int, string> dicColNumWidth = new Dictionary<int, string>();
        //    dicColNumWidth.Add(1, "3,9");
        //    dicColNumWidth.Add(2, "2,4");
        //    dicColNumWidth.Add(3, "1,3");
        //    dicColNumWidth.Add(4, "1,2");
        //    if (intColNum > 4) intColNum = 4;
        //    foreach (VueControlGroupEx objInFor in arrASPControlGroupObjLst)
        //    {
        //        if (objInFor.arrSubAspControlLst2.Count == 0) continue;
        //        string strWidths = dicColNumWidth[intColNum];
        //        string[] strwWidth = strWidths.Split(",".ToCharArray());
        //        foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
        //        {
        //            if (objInFor2.ColSpan_Ctrl > 1)
        //            {
        //                objInFor2.Class += string.Format(" col-{0}", int.Parse(strwWidth[0]) + int.Parse(strwWidth[1]));
        //                objDivTable.arrSubAspControlLst2.Add(objInFor2);
        //                continue;
        //            }
        //            if (objInFor2.IsCaption == true)
        //            {
        //                objInFor2.Class += string.Format(" col-{0} text-right", strwWidth[0]);
        //            }
        //            else
        //            {
        //                objInFor2.Class += string.Format(" col-{0}", strwWidth[1]);
        //            }
        //            objDivTable.arrSubAspControlLst2.Add(objInFor2);
        //        }
        //    }

        //    return objDivTable;
        //}

        public static ASPDivEx PackageByFormControl4QueryRegion(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        {
            ASPDivEx objDivTable = clsASPDivBLEx.GetEmptyDiv();
            //封装Td
            //List<ASPControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageDiv).ToList();

            //int intCount = 0;
            //ASPLiEx objLi = new ASPLiEx();
            Dictionary<int, string> dicColNumWidth = new Dictionary<int, string>();
            dicColNumWidth.Add(1, "3,9");
            dicColNumWidth.Add(2, "2,4");
            dicColNumWidth.Add(3, "1,3");
            dicColNumWidth.Add(4, "1,2");
            if (intColNum > 4) intColNum = 4;
            foreach (ASPControlGroupEx objInFor in arrControlGroups)
            {
                if (objInFor.arrSubAspControlLst2.Count == 0) continue;
                ASPDivEx objDiv = clsASPDivBLEx.GetEmptyDiv();
                objDiv.Class = "form-group";

                foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
                {
                    if (objInFor2.IsCaption == true)
                    {
                        objDiv.arrSubAspControlLst2.Add(objInFor2);
                        //objInFor2.Class += string.Format(" col-{0}", strwWidth[0]);
                    }
                    else
                    {
                        objDiv.arrSubAspControlLst2.Add(objInFor2);
                        //objInFor2.Class += string.Format(" col-{0}", strwWidth[1]);
                    }
                }
                objDivTable.arrSubAspControlLst2.Add(objDiv);
            }

            return objDivTable;
        }

        //public static ASPDivEx PackageByFormControl4QueryRegion(IEnumerable<VueControlGroupEx> arrControlGroups, int intColNum)
        //{
        //    ASPDivEx objDivTable = clsASPDivBLEx.GetEmptyDiv();
        //    //封装Td
        //    //List<VueControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageDiv).ToList();

        //    //int intCount = 0;
        //    //ASPLiEx objLi = new ASPLiEx();
        //    Dictionary<int, string> dicColNumWidth = new Dictionary<int, string>();
        //    dicColNumWidth.Add(1, "3,9");
        //    dicColNumWidth.Add(2, "2,4");
        //    dicColNumWidth.Add(3, "1,3");
        //    dicColNumWidth.Add(4, "1,2");
        //    if (intColNum > 4) intColNum = 4;
        //    foreach (VueControlGroupEx objInFor in arrControlGroups)
        //    {
        //        if (objInFor.arrSubAspControlLst2.Count == 0) continue;
        //        ASPDivEx objDiv = clsASPDivBLEx.GetEmptyDiv();
        //        objDiv.Class = "form-group";

        //        foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
        //        {
        //            if (objInFor2.IsCaption == true)
        //            {
        //                objDiv.arrSubAspControlLst2.Add(objInFor2);
        //                //objInFor2.Class += string.Format(" col-{0}", strwWidth[0]);
        //            }
        //            else
        //            {
        //                objDiv.arrSubAspControlLst2.Add(objInFor2);
        //                //objInFor2.Class += string.Format(" col-{0}", strwWidth[1]);
        //            }
        //        }
        //        objDivTable.arrSubAspControlLst2.Add(objDiv);
        //    }

        //    return objDivTable;
        //}

        public static ASPDivEx PackageByFormControl4EditRegion(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        {
            ASPDivEx objDivTable = clsASPDivBLEx.GetEmptyDiv();
            //封装Td
            //List<ASPControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageDiv).ToList();

            //int intCount = 0;
            //ASPLiEx objLi = new ASPLiEx();
            Dictionary<int, string> dicColNumWidth = new Dictionary<int, string>();
            dicColNumWidth.Add(1, "3,9");
            dicColNumWidth.Add(2, "2,4");
            dicColNumWidth.Add(3, "1,3");
            dicColNumWidth.Add(4, "1,2");
            if (intColNum > 4) intColNum = 4;
            foreach (ASPControlGroupEx objInFor in arrControlGroups)
            {
                if (objInFor.arrSubAspControlLst2.Count == 0) continue;
                ASPDivEx objDiv = clsASPDivBLEx.GetEmptyDiv();
                objDiv.Class = "form-group";
                          
                foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
                {                  
                    if (objInFor2.IsCaption == true)
                    {
                        objDiv.arrSubAspControlLst2.Add(objInFor2);
                        //objInFor2.Class += string.Format(" col-{0}", strwWidth[0]);
                    }
                    else
                    {
                        objDiv.arrSubAspControlLst2.Add(objInFor2);
                        //objInFor2.Class += string.Format(" col-{0}", strwWidth[1]);
                    }             
                }
                objDivTable.arrSubAspControlLst2.Add(objDiv);
            }

            return objDivTable;
        }

        //public static ASPDivEx PackageByFormControl4EditRegion(IEnumerable<VueControlGroupEx> arrControlGroups, int intColNum)
        //{
        //    ASPDivEx objDivTable = clsASPDivBLEx.GetEmptyDiv();
        //    //封装Td
        //    //List<VueControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageDiv).ToList();

        //    //int intCount = 0;
        //    //ASPLiEx objLi = new ASPLiEx();
        //    Dictionary<int, string> dicColNumWidth = new Dictionary<int, string>();
        //    dicColNumWidth.Add(1, "3,9");
        //    dicColNumWidth.Add(2, "2,4");
        //    dicColNumWidth.Add(3, "1,3");
        //    dicColNumWidth.Add(4, "1,2");
        //    if (intColNum > 4) intColNum = 4;
        //    foreach (VueControlGroupEx objInFor in arrControlGroups)
        //    {
        //        if (objInFor.arrSubAspControlLst2.Count == 0) continue;
        //        ASPDivEx objDiv = clsASPDivBLEx.GetEmptyDiv();
        //        objDiv.Class = "form-group";

        //        foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
        //        {
        //            if (objInFor2.IsCaption == true)
        //            {
        //                objDiv.arrSubAspControlLst2.Add(objInFor2);
        //                //objInFor2.Class += string.Format(" col-{0}", strwWidth[0]);
        //            }
        //            else
        //            {
        //                objDiv.arrSubAspControlLst2.Add(objInFor2);
        //                //objInFor2.Class += string.Format(" col-{0}", strwWidth[1]);
        //            }
        //        }
        //        objDivTable.arrSubAspControlLst2.Add(objDiv);
        //    }

        //    return objDivTable;
        //}


        public static ASPDivEx PackageByFormInline4EditRegion(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        {
            ASPDivEx objDivTable = clsASPDivBLEx.GetEmptyDiv();
            objDivTable.Class = "form-inline";
            //封装Td
            //List<ASPControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageDiv).ToList();

            //int intCount = 0;
            //ASPLiEx objLi = new ASPLiEx();
            Dictionary<int, string> dicColNumWidth = new Dictionary<int, string>();
            dicColNumWidth.Add(1, "3,9");
            dicColNumWidth.Add(2, "2,4");
            dicColNumWidth.Add(3, "1,3");
            dicColNumWidth.Add(4, "1,2");
            if (intColNum > 4) intColNum = 4;
            foreach (ASPControlGroupEx objInFor in arrControlGroups)
            {
                if (objInFor.arrSubAspControlLst2.Count == 0) continue;
                ASPDivEx objDiv = clsASPDivBLEx.GetEmptyDiv();
                objDiv.Class = "form-group";

                foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
                {
                    if (objInFor2.IsCaption == true)
                    {
                        objDiv.arrSubAspControlLst2.Add(objInFor2);
                        //objInFor2.Class += string.Format(" col-{0}", strwWidth[0]);
                    }
                    else
                    {
                        objDiv.arrSubAspControlLst2.Add(objInFor2);
                        //objInFor2.Class += string.Format(" col-{0}", strwWidth[1]);
                    }
                }
                objDivTable.arrSubAspControlLst2.Add(objDiv);
            }

            return objDivTable;
        }

        //public static ASPDivEx PackageByFormInline4EditRegion(IEnumerable<VueControlGroupEx> arrControlGroups, int intColNum)
        //{
        //    ASPDivEx objDivTable = clsASPDivBLEx.GetEmptyDiv();
        //    objDivTable.Class = "form-inline";
        //    //封装Td
        //    //List<VueControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageDiv).ToList();

        //    //int intCount = 0;
        //    //ASPLiEx objLi = new ASPLiEx();
        //    Dictionary<int, string> dicColNumWidth = new Dictionary<int, string>();
        //    dicColNumWidth.Add(1, "3,9");
        //    dicColNumWidth.Add(2, "2,4");
        //    dicColNumWidth.Add(3, "1,3");
        //    dicColNumWidth.Add(4, "1,2");
        //    if (intColNum > 4) intColNum = 4;
        //    foreach (VueControlGroupEx objInFor in arrControlGroups)
        //    {
        //        if (objInFor.arrSubAspControlLst2.Count == 0) continue;
        //        ASPDivEx objDiv = clsASPDivBLEx.GetEmptyDiv();
        //        objDiv.Class = "form-group";

        //        foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
        //        {
        //            if (objInFor2.IsCaption == true)
        //            {
        //                objDiv.arrSubAspControlLst2.Add(objInFor2);
        //                //objInFor2.Class += string.Format(" col-{0}", strwWidth[0]);
        //            }
        //            else
        //            {
        //                objDiv.arrSubAspControlLst2.Add(objInFor2);
        //                //objInFor2.Class += string.Format(" col-{0}", strwWidth[1]);
        //            }
        //        }
        //        objDivTable.arrSubAspControlLst2.Add(objDiv);
        //    }

        //    return objDivTable;
        //}



        public static ASPDivEx PackageByFormInline4QueryRegion(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        {
            ASPDivEx objDivTable = clsASPDivBLEx.GetEmptyDiv();
            objDivTable.Class = "form-inline";
            //封装Td
            //List<ASPControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageDiv).ToList();

            //int intCount = 0;
            //ASPLiEx objLi = new ASPLiEx();
            Dictionary<int, string> dicColNumWidth = new Dictionary<int, string>();
            dicColNumWidth.Add(1, "3,9");
            dicColNumWidth.Add(2, "2,4");
            dicColNumWidth.Add(3, "1,3");
            dicColNumWidth.Add(4, "1,2");
            if (intColNum > 4) intColNum = 4;
            foreach (ASPControlGroupEx objInFor in arrControlGroups)
            {
                if (objInFor.arrSubAspControlLst2.Count == 0) continue;
                ASPDivEx objDiv = clsASPDivBLEx.GetEmptyDiv();
                objDiv.Class = "form-group";

                foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
                {
                    if (objInFor2.IsCaption == true)
                    {
                        objDiv.arrSubAspControlLst2.Add(objInFor2);
                        //objInFor2.Class += string.Format(" col-{0}", strwWidth[0]);
                    }
                    else
                    {
                        objDiv.arrSubAspControlLst2.Add(objInFor2);
                        //objInFor2.Class += string.Format(" col-{0}", strwWidth[1]);
                    }
                }
                objDivTable.arrSubAspControlLst2.Add(objDiv);
            }

            return objDivTable;
        }

        //public static ASPDivEx PackageByFormInline4QueryRegion(IEnumerable<VueControlGroupEx> arrControlGroups, int intColNum)
        //{
        //    ASPDivEx objDivTable = clsASPDivBLEx.GetEmptyDiv();
        //    objDivTable.Class = "form-inline";
        //    //封装Td
        //    //List<VueControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageDiv).ToList();

        //    //int intCount = 0;
        //    //ASPLiEx objLi = new ASPLiEx();
        //    Dictionary<int, string> dicColNumWidth = new Dictionary<int, string>();
        //    dicColNumWidth.Add(1, "3,9");
        //    dicColNumWidth.Add(2, "2,4");
        //    dicColNumWidth.Add(3, "1,3");
        //    dicColNumWidth.Add(4, "1,2");
        //    if (intColNum > 4) intColNum = 4;
        //    foreach (VueControlGroupEx objInFor in arrControlGroups)
        //    {
        //        if (objInFor.arrSubAspControlLst2.Count == 0) continue;
        //        ASPDivEx objDiv = clsASPDivBLEx.GetEmptyDiv();
        //        objDiv.Class = "form-group";

        //        foreach (var objInFor2 in objInFor.arrSubAspControlLst2)
        //        {
        //            if (objInFor2.IsCaption == true)
        //            {
        //                objDiv.arrSubAspControlLst2.Add(objInFor2);
        //                //objInFor2.Class += string.Format(" col-{0}", strwWidth[0]);
        //            }
        //            else
        //            {
        //                objDiv.arrSubAspControlLst2.Add(objInFor2);
        //                //objInFor2.Class += string.Format(" col-{0}", strwWidth[1]);
        //            }
        //        }
        //        objDivTable.arrSubAspControlLst2.Add(objDiv);
        //    }

        //    return objDivTable;
        //}

    }
}