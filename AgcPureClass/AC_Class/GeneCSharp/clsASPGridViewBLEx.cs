
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
        public static void GeneCode(this ASPGridViewEx objASPGridViewENEx,
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
                objSubASPControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.AppendFormat("\r\n" + "</GridView>");

        }

        public static void GeneCode4Mvc(this ASPGridViewEx objASPGridViewENEx,
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
                objSubASPControlENEx.GeneCode(strCodeForCs);
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
        public static void Gen_LvFieldAssignment(ASPGridViewEx objASPGridViewENEx, clsViewInfoENEx objViewInfoENEx,
            StringBuilder strCodeForCs)
        {
            //string strTemp = objASPGridViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;

            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n //设置{0}({1})的值", objASPGridViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
            //    objASPGridViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

            //strCodeForCs.AppendFormat("\r\n public void set{0}_q({1} value)", strTemp, objASPGridViewENEx.objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "tv{1}.setText(obj{0}EN.get{1}());",
               objViewInfoENEx.objOutRelaTab.TabName,
               objASPGridViewENEx.objDGRegionFldsENEx.ObjPrjTabFldENEx.ObjFieldTabENEx.FldName);
            //strCodeForCs.Append("\r\n }");
        }

        public static ASPGridViewEx CreateGridView(clsViewInfoENEx objViewInfoENEx)
        {
            ASPGridViewEx objASPGridViewENEx_DG = new ASPGridViewEx();
            objASPGridViewENEx_DG.AspControlId = string.Format("gv{0}", objViewInfoENEx.objMainPrjTab.TabName);
            objASPGridViewENEx_DG.AspControlName = string.Format("gv{0}", objViewInfoENEx.objMainPrjTab.TabName);


            ASPTemplateFieldEx objASPTemplateFieldENEx = new ASPTemplateFieldEx();
            objASPTemplateFieldENEx.AspControlId = string.Format("tfSelAll");
            objASPTemplateFieldENEx.AspControlName = string.Format("tfSelAll");
            objASPGridViewENEx_DG.arrSubAspControlLst2.Add(objASPTemplateFieldENEx);

            ASPHeaderStyleEx objASPHeaderStyleENEx = new ASPHeaderStyleEx();
            objASPHeaderStyleENEx.AspControlId = string.Format("hsSelAll");
            objASPHeaderStyleENEx.AspControlName = string.Format("hsSelAll");
            objASPHeaderStyleENEx.Width = 30;
            objASPTemplateFieldENEx.arrSubAspControlLst2.Add(objASPHeaderStyleENEx);

            ASPHeaderTemplateEx objASPHeaderTemplateENEx = new ASPHeaderTemplateEx();
            objASPHeaderTemplateENEx.AspControlId = string.Format("htSelAll");
            objASPHeaderTemplateENEx.AspControlName = string.Format("htSelAll");
            objASPHeaderTemplateENEx.Width = 30;
            objASPTemplateFieldENEx.arrSubAspControlLst2.Add(objASPHeaderTemplateENEx);

            ASPLinkButtonEx objASPLinkButtonENEx = new ASPLinkButtonEx();
            objASPLinkButtonENEx.AspControlId = string.Format("lbSelAll");
            objASPLinkButtonENEx.AspControlName = string.Format("lbSelAll");
            objASPLinkButtonENEx.CommandName = "lbSelAll";
            objASPLinkButtonENEx.CssClass = "DgSelAll";
            objASPLinkButtonENEx.Text = "全选";
            //<asp:Button ID = "lbSelAll" CommandName = "lbSelAll" runat = "server" CssClass = "DgSelAll">全选</asp:Button>

            objASPLinkButtonENEx.Width = 30;
            objASPHeaderTemplateENEx.arrSubAspControlLst2.Add(objASPLinkButtonENEx);


            ASPItemTemplateEx objASPItemTemplateENEx = new ASPItemTemplateEx();
            objASPItemTemplateENEx.AspControlId = string.Format("itSelAll");
            objASPItemTemplateENEx.AspControlName = string.Format("itSelAll");
            objASPItemTemplateENEx.Width = 30;
            objASPTemplateFieldENEx.arrSubAspControlLst2.Add(objASPItemTemplateENEx);


            ASPCheckBoxEx objASPCheckBoxENEx = new ASPCheckBoxEx();
            objASPCheckBoxENEx.AspControlId = string.Format("chkCheckRec");
            objASPCheckBoxENEx.AspControlName = string.Format("chkCheckRec");
            //<asp:CheckBox ID = "chkCheckRec" runat = "server"></asp:CheckBox>

            objASPItemTemplateENEx.arrSubAspControlLst2.Add(objASPCheckBoxENEx);


            ASPBoundFieldEx objASPBoundFieldENEx = null;


            foreach (clsQryRegionFldsENEx objQryRegionFldsENEx in objViewInfoENEx.arrQryRegionFldSet)
            {

                objASPBoundFieldENEx = new ASPBoundFieldEx();
                objASPBoundFieldENEx.AspControlId = string.Format("bf{0}", objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                objASPBoundFieldENEx.AspControlName = string.Format("bf{0}", objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                objASPBoundFieldENEx.DataField = objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;
                objASPBoundFieldENEx.SortExpression = objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName;
                objASPBoundFieldENEx.HeaderText = objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption;

                objASPGridViewENEx_DG.arrSubAspControlLst2.Add(objASPBoundFieldENEx);

            }

            //修改按钮－－－－－－－－－－－－－－－－
            //<asp:Button ID = "lbUpdate" runat = "Server" CommandName = "Update" Text = "修改"></asp:Button>

            ASPTemplateFieldEx objASPTemplateFieldENEx_Update = new ASPTemplateFieldEx();
            objASPTemplateFieldENEx_Update.AspControlId = string.Format("tfUpdate");
            objASPTemplateFieldENEx_Update.AspControlName = string.Format("tfUpdate");
            objASPGridViewENEx_DG.arrSubAspControlLst2.Add(objASPTemplateFieldENEx_Update);

            ASPItemTemplateEx objASPItemTemplateENEx_Update = new ASPItemTemplateEx();
            objASPItemTemplateENEx_Update.AspControlId = string.Format("itUpdate");
            objASPItemTemplateENEx_Update.AspControlName = string.Format("itUpdate");
            objASPItemTemplateENEx_Update.Width = 30;
            objASPTemplateFieldENEx_Update.arrSubAspControlLst2.Add(objASPItemTemplateENEx_Update);

            ASPLinkButtonEx objASPLinkButtonENEx_Update = new ASPLinkButtonEx();
            objASPLinkButtonENEx_Update.AspControlId = string.Format("lbUpdate");
            objASPLinkButtonENEx_Update.AspControlName = string.Format("lbUpdate");
            objASPLinkButtonENEx_Update.CommandName = "Update";
            //objASPLinkButtonENEx_Update.CssClass = "DgSelAll";
            objASPLinkButtonENEx_Update.Text = "修改";

            objASPItemTemplateENEx_Update.arrSubAspControlLst2.Add(objASPLinkButtonENEx_Update);

            //修改按钮＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

            //删除按钮－－－－－－－－－－－－－－－－
            //<asp:Button ID = "lbDelete" runat = "Server" CommandName = "Delete" Text = "删除"></asp:Button>

            ASPTemplateFieldEx objASPTemplateFieldENEx_Delete = new ASPTemplateFieldEx();
            objASPTemplateFieldENEx_Delete.AspControlId = string.Format("tfDelete");
            objASPTemplateFieldENEx_Delete.AspControlName = string.Format("tfDelete");
            objASPGridViewENEx_DG.arrSubAspControlLst2.Add(objASPTemplateFieldENEx_Delete);

            ASPItemTemplateEx objASPItemTemplateENEx_Delete = new ASPItemTemplateEx();
            objASPItemTemplateENEx_Delete.AspControlId = string.Format("itDelete");
            objASPItemTemplateENEx_Delete.AspControlName = string.Format("itDelete");
            objASPItemTemplateENEx_Delete.Width = 30;
            objASPTemplateFieldENEx_Delete.arrSubAspControlLst2.Add(objASPItemTemplateENEx_Delete);

            ASPLinkButtonEx objASPLinkButtonENEx_Delete = new ASPLinkButtonEx();
            objASPLinkButtonENEx_Delete.AspControlId = string.Format("lbDelete");
            objASPLinkButtonENEx_Delete.AspControlName = string.Format("lbDelete");
            objASPLinkButtonENEx_Delete.CommandName = "Delete";
            //objASPLinkButtonENEx_Delete.CssClass = "DgSelAll";
            objASPLinkButtonENEx_Delete.Text = "删除";

            objASPItemTemplateENEx_Delete.arrSubAspControlLst2.Add(objASPLinkButtonENEx_Delete);

            //删除按钮＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝

            ASPPagerTemplateEx objASPPagerTemplateENEx = new ASPPagerTemplateEx();
            objASPPagerTemplateENEx.AspControlId = "PagerTemplate";
            objASPPagerTemplateENEx.AspControlName = "PagerTemplate";

            objASPGridViewENEx_DG.objASPPagerTemplateENEx = objASPPagerTemplateENEx;

            return objASPGridViewENEx_DG;
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
            //      objViewInfoENEx.objMainTabKeyFld.ObjFieldTabENEx.FldName);
            //    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
            //    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
            //}
            //if (objViewInfoENEx.objDGRegionENEx.IsCheck  ==  true)	//判断是否需要复选按钮
            //{
            //    strCodeForCs.Append("\r\n" + "<asp:TemplateField HeaderText = \"全选\">");
            //    strCodeForCs.Append("\r\n" + "<HeaderStyle Width = \"30px\" />");
            //    strCodeForCs.Append("\r\n" + "<HeaderTemplate>");
            //    strCodeForCs.Append("\r\n" + "<asp:Button id = \"lbSelAll\" CommandName = \"lbSelAll\" runat = \"server\" CssClass = \"DgSelAll\" >全选</asp:Button>");
            //    strCodeForCs.Append("\r\n" + "</HeaderTemplate>");
            //    strCodeForCs.Append("\r\n" + "<ItemTemplate>");
            //    strCodeForCs.Append("\r\n" + "<asp:CheckBox id = \"chkCheckRec\" runat = \"server\"></asp:CheckBox>");
            //    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
            //    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
            //}

            //foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            //{
            //    if (objDGRegionFldsEx.IsNeedSort)	//判断是否需要排序
            //    {
            //        strSortExpression = "SortExpression = \"" + objDGRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName + "\"";
            //    }
            //    else
            //    {
            //        strSortExpression = "";
            //    }
            //    strCodeForCs.AppendFormat("\r\n" + "<asp:BoundField DataField = \"{0}\" {2} HeaderText = \"{1}\"></asp:BoundField>",
            //        objDGRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName,
            //        objDGRegionFldsEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption,
            //        strSortExpression);
            //}
            //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate  ==  true)	//在DG中是否有修改按钮
            //{
            //    strCodeForCs.Append("\r\n" + "<asp:TemplateField>");
            //    strCodeForCs.Append("\r\n" + "<ItemTemplate>");
            //    strCodeForCs.Append("\r\n" + "<asp:Button id = \"lbUpdate\" runat = \"Server\" CommandName = \"Update\" Text = \"修改\"></asp:Button>");
            //    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
            //    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
            //}
            //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)	//在DG中是否有修改按钮
            //{
            //    strCodeForCs.Append("\r\n" + "<asp:TemplateField>");
            //    strCodeForCs.Append("\r\n" + "<ItemTemplate>");
            //    strCodeForCs.Append("\r\n" + "<asp:Button id = \"lbUpdate\" runat = \"Server\" CommandName = \"Update\" Text = \"修改\"></asp:Button>");
            //    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
            //    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
            //}
            //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel  ==  true)	//在DG中是否有删除按钮
            //{
            //    strCodeForCs.Append("\r\n" + "<asp:TemplateField>");
            //    strCodeForCs.Append("\r\n" + "<ItemTemplate>");
            //    strCodeForCs.Append("\r\n" + "<asp:Button id = \"lbDelete\" runat = \"Server\" CommandName = \"Delete\" Text = \"删除\"></asp:Button>");
            //    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
            //    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
            //}
            //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail  ==  true)  //在DG中是否有详细信息按钮
            //{
            //    strCodeForCs.Append("\r\n" + "<asp:TemplateField>");
            //    strCodeForCs.Append("\r\n" + "<ItemTemplate>");
            //    strCodeForCs.Append("\r\n" + "<asp:Button id = \"lbDetail\" runat = \"Server\" CommandName = \"Detail\" Text = \"详细信息\"></asp:Button>");
            //    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
            //    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
            //}

            //strCodeForCs.Append("\r\n" + "</Columns>");	//列结束
            ////分页模式
            //strCodeForCs.Append("\r\n" + "<PagerTemplate>");
            //strCodeForCs.Append("\r\n" + "<span style = \"background-color: #c0c0c0\">共有记录:</span>");
            //strCodeForCs.Append("\r\n" + "<asp:Label ID = \"lblRecCount\" runat = \"server\" CssClass = \"Label_DefaInPager\" ForeColor = \"#000066\" Width = \"22px\">0</asp:Label>");
            //strCodeForCs.Append("\r\n" + "<span style = \"background-color: #c0c0c0\">");
            //strCodeForCs.Append("\r\n" + "<div style = \"display: inline; width: 16px; height: 13px\">");
            //strCodeForCs.Append("\r\n" + "</div>");
            //strCodeForCs.Append("\r\n" + "</span><span style = \"background-color: #c0c0c0\">总页数:</span>");
            //strCodeForCs.Append("\r\n" + "<asp:Label ID = \"lblAllPages\" runat = \"server\" CssClass = \"Label_DefaInPager\" ForeColor = \"#000066\">0</asp:Label>");
            //strCodeForCs.Append("\r\n" + "<div style = \"display: inline; width: 16px; height: 13px\">");
            //strCodeForCs.Append("\r\n" + "</div>");
            //strCodeForCs.Append("\r\n" + "<span style = \"background-color: #c0c0c0\">当前页:</span>");
            //strCodeForCs.Append("\r\n" + "<asp:Label ID = \"lblCurrentPage\" runat = \"server\" CssClass = \"Label_DefaInPager\" ForeColor = \"#000066\">0</asp:Label>");
            //strCodeForCs.Append("\r\n" + "<div style = \"display: inline; width: 16px; height: 13px\">");
            //strCodeForCs.Append("\r\n" + "</div>");
            //strCodeForCs.Append("\r\n" + "<asp:Button ID = \"btnPrevPage\" runat = \"server\" CssClass = \"Button_DefaInPager\" Text = \"上一页\"");
            //strCodeForCs.Append("\r\n" + "Width = \"50px\" CommandArgument = \"Prev\" CommandName = \"Page\" /><span style = \"font-family: Verdana\">");
            //strCodeForCs.Append("\r\n" + "</span>");
            //strCodeForCs.Append("\r\n" + "<asp:Button ID = \"btnNextPage\" runat = \"server\" CssClass = \"Button_DefaInPager\" Text = \"下一页\"");
            //strCodeForCs.Append("\r\n" + "Width = \"50px\" CommandArgument = \"Next\" CommandName = \"Page\" />");
            //strCodeForCs.Append("\r\n" + "到第");
            //strCodeForCs.Append("\r\n" + "<asp:TextBox ID = \"txtJump2Page\" runat = \"server\" CssClass = \"TextBox_DefaInPager\" Width = \"35px\"></asp:TextBox>页");
            //strCodeForCs.Append("\r\n" + "<asp:Button ID = \"btnJumpPage\" runat = \"server\" CssClass = \"Button_DefaInPager\" OnClick = \"btnJumpPage_Click\"");
            //strCodeForCs.Append("\r\n" + "Text = \"确定\" Width = \"35px\" CommandName = \"Page\" />");

            //strCodeForCs.Append("\r\n" + "<span style = \"background-color: #c0c0c0\">页记录数:</span>");
            //strCodeForCs.Append("\r\n" + "<asp:DropDownList ID = \"ddlPagerRecCount\" runat = \"server\" CssClass = \"DropDown_DefaInPager\"");
            //strCodeForCs.Append("\r\n" + "Width = \"55px\" AutoPostBack = \"True\" OnSelectedIndexChanged = \"ddlPagerRecCount_SelectedIndexChanged\">");
            //strCodeForCs.Append("\r\n" + "<asp:ListItem>5</asp:ListItem>");
            //strCodeForCs.Append("\r\n" + "<asp:ListItem>10</asp:ListItem>");
            //strCodeForCs.Append("\r\n" + "<asp:ListItem>20</asp:ListItem>");
            //strCodeForCs.Append("\r\n" + "<asp:ListItem>30</asp:ListItem>");
            //strCodeForCs.Append("\r\n" + "<asp:ListItem>50</asp:ListItem>");
            //strCodeForCs.Append("\r\n" + "<asp:ListItem>100</asp:ListItem>");
            //strCodeForCs.Append("\r\n" + "<asp:ListItem>1000</asp:ListItem>");
            //strCodeForCs.Append("\r\n" + "</asp:DropDownList>");

            //strCodeForCs.Append("\r\n" + "<asp:CompareValidator ID = \"CompareValidator\" runat = \"server\" ControlToValidate = \"txtJump2Page\"");
            //strCodeForCs.Append("\r\n" + "ErrorMessage = \"错误!\" ForeColor = \"DarkOrange\" Operator = \"DataTypeCheck\" Type = \"Integer\"></asp:CompareValidator>");
            //strCodeForCs.Append("\r\n" + "</PagerTemplate>");
            //strCodeForCs.Append("\r\n" + "<FooterStyle BackColor = \"#B5C7DE\" ForeColor = \"#4A3C8C\" />");
            //strCodeForCs.Append("\r\n" + "<RowStyle BackColor = \"#E7E7FF\" ForeColor = \"#4A3C8C\" />");
            //strCodeForCs.Append("\r\n" + "<SelectedRowStyle BackColor = \"#738A9C\" Font-Bold = \"True\" ForeColor = \"#F7F7F7\" />");
            //strCodeForCs.Append("\r\n" + "<PagerStyle BackColor = \"#E7E7FF\" ForeColor = \"#4A3C8C\" HorizontalAlign = \"Right\" />");
            //strCodeForCs.Append("\r\n" + "<HeaderStyle BackColor = \"#4A3C8C\" Font-Bold = \"True\" ForeColor = \"#F7F7F7\" />");
            //strCodeForCs.Append("\r\n" + "<AlternatingRowStyle BackColor = \"#F7F7F7\" />");
            //strCodeForCs.Append("\r\n" + "</asp:GridView>");

            //strCodeForCs.AppendFormat("\r\n" + "<asp:GridView ID = \"{0}\" Style = \"z-index: 105;\"  runat = \"server\" ", objASPGridViewENEx.AspControlId);
            //if (string.IsNullOrEmpty(objASPGridViewENEx.CssClass)  ==  false)
            //{
            //    strCodeForCs.AppendFormat("CssClass = \"{0}\"  ", objASPGridViewENEx.CssClass);
            //}
            //if (objASPGridViewENEx.Width > 0)
            //{
            //    strCodeForCs.AppendFormat("Width = \"{0}px\"  ", objASPGridViewENEx.Width);
            //}
            //if (objASPGridViewENEx.Height > 0)
            //{
            //    strCodeForCs.AppendFormat("Height = \"{0}px\"  ", objASPGridViewENEx.Height);
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
            //    objSubASPControlENEx.GeneCode(strCodeForCs);
            //}
            //strCodeForCs.Append("\r\n" + "</asp:GridView>");

        }
        public static void GeneCodeBak(ASPGridViewEx objASPGridViewENEx, StringBuilder strCodeForCs)
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
                objSubASPControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</asp:GridView>");

        }

    }
}
