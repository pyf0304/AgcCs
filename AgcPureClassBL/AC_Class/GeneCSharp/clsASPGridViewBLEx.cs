
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPGridViewBLEx
表名:ASPNETGridView(00050225)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:55:46
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
    public static class clsASPGridViewBLEx_Static
    {
        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPGridViewENEx">编辑文本框对象</param>
        /// <param name="strCodeForCs">生成到这个对象中</param>
        public static void GeneCode(this ASPGridViewEx objASPGridViewENEx, enumApplicationType intApplicationTypeId,
            StringBuilder strCodeForCs)
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
            string strActionId = AgcPubFun.getASPNETID();

            strCodeForCs.AppendFormat("\r\n" + "<asp:GridView");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPGridViewENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPGridViewENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPGridViewENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPGridViewENEx, strCodeForCs);
            if (string.IsNullOrEmpty(objASPGridViewENEx.scrollbars) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:scrollbars=\"{0}\"",
                        objASPGridViewENEx.scrollbars);
            }
            //生成控件的约束-即与四周控件的约束关系
            clsASPControlBLEx.GC4Constraint(objASPGridViewENEx, strCodeForCs);

            strCodeForCs.AppendFormat(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPGridViewENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.AppendFormat("\r\n" + "</GridView>");

        }


        //public static void GeneCode4Html(this ASPGridViewEx objASPGridViewENEx, enumApplicationType intApplicationTypeId,
        //  StringBuilder strCodeForCs)
        //{
        //    string strActionId = AgcPubFun.getASPNETID();

        //    strCodeForCs.AppendFormat("\r\n" + "<asp:GridView");

        //    //生成控件的Id、Name
        //    clsASPControlBLEx.GC4IdName(objASPGridViewENEx, strCodeForCs);

        //    //生成控件的Tag
        //    clsASPControlBLEx.GC4Tag(objASPGridViewENEx, strCodeForCs);

        //    //生成控件的尺寸-高、宽
        //    clsASPControlBLEx.GC4Size(objASPGridViewENEx, strCodeForCs);

        //    //生成控件的边界尺寸-即与四周的距离
        //    clsASPControlBLEx.GC4Margin(objASPGridViewENEx, strCodeForCs);
        //    if (string.IsNullOrEmpty(objASPGridViewENEx.scrollbars) == false)
        //    {
        //        strCodeForCs.AppendFormat("\r\n" + "android:scrollbars=\"{0}\"",
        //                objASPGridViewENEx.scrollbars);
        //    }
        //    //生成控件的约束-即与四周控件的约束关系
        //    clsASPControlBLEx.GC4Constraint(objASPGridViewENEx, strCodeForCs);

        //    strCodeForCs.AppendFormat(">");

        //    foreach (ASPControlEx objSubASPControlENEx in objASPGridViewENEx.arrSubAspControlLst2)
        //    {
        //        objSubASPControlENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
        //    }
        //    strCodeForCs.AppendFormat("\r\n" + "</GridView>");

        //}

        public static void GeneCode4Mvc(this ASPGridViewEx objASPGridViewENEx, enumApplicationType intApplicationTypeId,
          StringBuilder strCodeForCs)
        {
            string strActionId = AgcPubFun.getASPNETID();

            strCodeForCs.AppendFormat("\r\n" + "<asp:GridView");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPGridViewENEx, strCodeForCs);

            //生成控件的Tag
            clsASPControlBLEx.GC4Tag(objASPGridViewENEx, strCodeForCs);

            //生成控件的尺寸-高、宽
            clsASPControlBLEx.GC4Size(objASPGridViewENEx, strCodeForCs);

            //生成控件的边界尺寸-即与四周的距离
            clsASPControlBLEx.GC4Margin(objASPGridViewENEx, strCodeForCs);
            if (string.IsNullOrEmpty(objASPGridViewENEx.scrollbars) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "android:scrollbars=\"{0}\"",
                        objASPGridViewENEx.scrollbars);
            }
            //生成控件的约束-即与四周控件的约束关系
            clsASPControlBLEx.GC4Constraint(objASPGridViewENEx, strCodeForCs);

            strCodeForCs.AppendFormat(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPGridViewENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.AppendFormat("\r\n" + "</GridView>");

        }

    }

    /// <summary>
    /// ASPNET表格视图(ASPNETGridView)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsASPGridViewBLEx 
    {

       
        /// <summary>
        /// 生成字段变量定义的代码
        /// </summary>
        /// <param name="objASPGridViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarDef(ASPGridViewEx objASPGridViewENEx,
            StringBuilder strCodeForCs)
        {
            strCodeForCs.AppendFormat("\r\n" + "private GridView {0};",
                objASPGridViewENEx.CtrlId);
        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPGridViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind(ASPGridViewEx objASPGridViewENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "{0} = (GridView)findViewById(R.id.{0}); ",
                objASPGridViewENEx.CtrlId);

        }

        /// <summary>
        /// 生成字段变量定义与脚本的绑定
        /// </summary>
        /// <param name="objASPGridViewENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_FieldVarBind4ListView(ASPGridViewEx objASPGridViewENEx,
            StringBuilder strCodeForCs)
        {
            //txtExamTypeId = (EditText)findViewById(R.id.txtExamTypeId);
            strCodeForCs.AppendFormat("\r\n" + "hsv{0} = (GridView)view.findViewById(R.id.hsv{0}); ",
                objASPGridViewENEx.CtrlId);

        }
        /// <summary>
        /// 生成字段控件的设置控件值(查询区字段)
        /// </summary>
        /// <param name="objASPGridViewENEx"></param>
        /// <param name="objViewInfoENEx"></param>
        /// <param name="strCodeForCs"></param>
        public static void Gen_LvFieldAssignment(ASPGridViewEx objASPGridViewENEx, clsViewInfoEN objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPGridViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPGridViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().Caption,
            //    objASPGridViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPGridViewENEx.objQryRegionFldsEN.ObjFieldTab_PC().ObjDataTypeAbbr_PC().JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.ObjOutRelaTab().TabName,
               objASPGridViewENEx.objDGRegionFldsEN.ObjFieldTab_PC().FldName);
            //strCodeForCs.Append("\r\n }");
        }

        public static void GeneCodeBak2(ASPGridViewEx objASPGridViewENEx, StringBuilder strCodeForCs)
        {
            //<asp:GridView ID = "lblViewTitle" runat = "server" CssClass = "PageTitleH1" Height = "16px">性别表维护
            //       </asp:GridView>

            //if (objViewInfoENEx.objDGRegionENEx.IsInTab  ==  true)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "<asp:GridView id = \"gv{0}\" runat = \"server\" ",
            //        objViewInfoENEx.TabName, objViewInfoENEx.objDGRegionENEx.Style_Zindex, objViewInfoENEx.objDGRegionENEx.Style_Top, objViewInfoENEx.objDGRegionENEx.Style_Position, objViewInfoENEx.objDGRegionENEx.Style_Left);
            //}
            //else
            //{
            //    //					strCodeForCs.AppendFormat("\r\n" + "<asp:DataGrid id = \"dg{0}\" style = \"z-index: {1}; left: {4}px; position: {3}; top: {2}px\" runat = \"server\" ", 
            //    //						objViewInfoENEx.TabName, objViewInfoENEx.objDGRegionENEx.Style_Zindex, objViewInfoENEx.objDGRegionENEx.Style_Top, objViewInfoENEx.objDGRegionENEx.Style_Position,objViewInfoENEx.objDGRegionENEx.Style_Left);
            //    //					隐藏高度
            //    strCodeForCs.AppendFormat("\r\n" + "<asp:GridView id = \"gv{0}\" style = \"z-index: {1};\" runat = \"server\" ",
            //        objViewInfoENEx.TabName, objViewInfoENEx.objDGRegionENEx.Style_Zindex, objViewInfoENEx.objDGRegionENEx.Style_Top, objViewInfoENEx.objDGRegionENEx.Style_Position, objViewInfoENEx.objDGRegionENEx.Style_Left);

            //}
            ////				strCodeForCs.AppendFormat("\r\n" + "Width = \"{0}px\" Height = \"{1}px\" AutoGenerateColumns = \"{2}\" ", 
            ////					objViewInfoENEx.objDGRegionENEx.Width, objViewInfoENEx.objDGRegionENEx.Height, objViewInfoENEx.objDGRegionENEx.AutoGenerateColumns);
            ////					隐藏高度
            //strCodeForCs.AppendFormat("\r\n" + "Width = \"100%\" AutoGenerateColumns = \"{1}\" ",
            //    objViewInfoENEx.objDGRegionENEx.Width, objViewInfoENEx.objDGRegionENEx.AutoGenerateColumns);
            //if (objViewInfoENEx.objDGRegionENEx.AllowPaging  ==  true)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "PageSize = \"{0}\" AllowPaging = \"true\" ",
            //        objViewInfoENEx.objDGRegionENEx.PageSize);
            //}
            //else
            //{
            //}
            /////设置是否排序
            //if (objViewInfoENEx.objDGRegionENEx.AllowSorting  ==  true)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "AllowSorting = \"true\" ");
            //}

            //strCodeForCs.AppendFormat("\r\n" + "OnSorting = \"gv{0}_Sorting\" ",
            //    objViewInfoENEx.TabName);
            ////				strCodeForCs.AppendFormat("\r\n" + "OnSelectedIndexChanged = \"gv{0}_SelectedIndexChanged\" ",
            ////				objViewInfoENEx.TabName);
            //if (objViewInfoENEx.objDGRegionENEx.AllowPaging  ==  true)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "OnPageIndexChanging = \"gv{0}_PageIndexChanging\" ",
            //        objViewInfoENEx.TabName);
            //}
            //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel  ==  true
            //    && objViewInfoENEx.objDGRegionENEx.AllowSorting  ==  true)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "OnRowCreated = \"gv{0}_RowCreated\"",
            //        objViewInfoENEx.TabName);
            //}
            //strCodeForCs.AppendFormat("\r\n" + "OnRowCommand = \"gv{0}_RowCommand\"",
            //    objViewInfoENEx.TabName);
            //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel  ==  true)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "OnRowDeleting = \"gv{0}_RowDeleting\" ",
            //        objViewInfoENEx.TabName);
            //}
            //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate  ==  true)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "OnRowUpdating = \"gv{0}_RowUpdating\" ",
            //        objViewInfoENEx.TabName);
            //}
            //strCodeForCs.Append("\r\n" + "BackColor = \"White\" ");
            //strCodeForCs.Append("\r\n" + "BorderColor = \"#E7E7FF\" ");
            //strCodeForCs.Append("\r\n" + "BorderStyle = \"None\" ");
            //strCodeForCs.Append("\r\n" + "BorderWidth = \"1px\"");
            //strCodeForCs.Append("\r\n" + "cellpadding = \"3\" ");
            //strCodeForCs.Append("\r\n" + "GridLines = \"Horizontal\" ");
            //strCodeForCs.Append("\r\n" + "Height = \"1px\" ");
            //strCodeForCs.AppendFormat("\r\n" + "DataKeyNames = \"{0}\" ",
            //      objViewInfoENEx.KeyFldNameLstStr);
            //strCodeForCs.Append("\r\n" + "CssClass = \"GridValue\">");

            //string strSortExpression;

            //strCodeForCs.Append("\r\n" + "<Columns>");
            //if (objViewInfoENEx.objDGRegionENEx.IsRadio  ==  true)	//判断是否需要单选按钮
            //{
            //    strCodeForCs.Append("\r\n" + "<asp:TemplateField>");
            //    strCodeForCs.Append("\r\n" + "<ItemTemplate>");
            //    strCodeForCs.AppendFormat("\r\n" + "<INPUT onclick = radioClick() type = radio value = '<%# DataBinder.Eval(Container.DataItem, \"{0}\")%>' name = RadioName>",
            //      objViewInfoENEx.objMainTabKeyFld.ObjFieldTab().FldName);
            //    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
            //    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
            //}

            ////if (string.IsNullOrEmpty(objASPGridViewENEx.Text)  ==  false)
            ////{
            ////    strCodeForCs.AppendFormat("Text = \"{0}\"  ", objASPGridViewENEx.Text);
            ////}
            ////if (string.IsNullOrEmpty(objASPGridViewENEx.OnClick)  ==  false)
            ////{
            ////    strCodeForCs.AppendFormat("OnClick = \"{0}\"  ", objASPGridViewENEx.OnClick);
            ////}
            //strCodeForCs.Append(">");

            //foreach (ASPControlEx objSubASPControlENEx in objASPGridViewENEx.arrSubAspControlLst2)
            //{
            //    objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            //}
            //strCodeForCs.Append("\r\n" + "</asp:GridView>");

        }
        public static void GeneCodeBak(ASPGridViewEx objASPGridViewENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        {
            //<asp:GridView ID = "lblViewTitle" runat = "server" CssClass = "PageTitleH1" Height = "16px">性别表维护
            //       </asp:GridView>
            strCodeForCs.AppendFormat("\r\n" + "<asp:GridView ID = \"{0}\" Style = \"z-index: 105;\"  runat = \"server\" ", objASPGridViewENEx.AspControlId);
            if (string.IsNullOrEmpty(objASPGridViewENEx.CssClass) == false)
            {
                strCodeForCs.AppendFormat("CssClass = \"{0}\"  ", objASPGridViewENEx.CssClass);
            }
            if (objASPGridViewENEx.Width > 0)
            {
                strCodeForCs.AppendFormat("Width = \"{0}px\"  ", objASPGridViewENEx.Width);
            }
            if (objASPGridViewENEx.Height > 0)
            {
                strCodeForCs.AppendFormat("Height = \"{0}px\"  ", objASPGridViewENEx.Height);
            }

            //if (string.IsNullOrEmpty(objASPGridViewENEx.Text)  ==  false)
            //{
            //    strCodeForCs.AppendFormat("Text = \"{0}\"  ", objASPGridViewENEx.Text);
            //}
            //if (string.IsNullOrEmpty(objASPGridViewENEx.OnClick)  ==  false)
            //{
            //    strCodeForCs.AppendFormat("OnClick = \"{0}\"  ", objASPGridViewENEx.OnClick);
            //}
            strCodeForCs.Append(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPGridViewENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</asp:GridView>");

        }

    }
}
