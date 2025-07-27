
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsASPHtmlTableBLEx
表名:ASPNETHtmlTable(00050218)
生成代码版本:2018.06.22.1
生成日期:2018/06/29 07:56:03
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
using System.Web.UI.HtmlControls;
using AgcCommBase;
using AGC.Entity;

namespace AGC.PureClassEx
{
    /// <summary>
    /// ASPNETHtml表(ASPNETHtmlTable)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPHtmlTableBLEx_Static
    {

        public static void GeneCode(this ASPHtmlTableEx objASPHtmlTableENEx, StringBuilder strCodeForCs)
        {

            strCodeForCs.AppendFormat("\r\n" + "<table");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPHtmlTableENEx, strCodeForCs);

            //生成控件的样式
            clsASPControlBLEx.GC4Style(objASPHtmlTableENEx, strCodeForCs);
            clsASPControlBLEx.GC4Runat(objASPHtmlTableENEx, strCodeForCs);

            strCodeForCs.Append(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPHtmlTableENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</table>");

        }

        public static void GeneCode4Mvc(this ASPHtmlTableEx objASPHtmlTableENEx, StringBuilder strCodeForCs)
        {

            strCodeForCs.AppendFormat("\r\n" + "<table");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4IdName(objASPHtmlTableENEx, strCodeForCs);

            //生成控件的样式
            clsASPControlBLEx.GC4Style(objASPHtmlTableENEx, strCodeForCs);
            clsASPControlBLEx.GC4Runat(objASPHtmlTableENEx, strCodeForCs);

            strCodeForCs.Append(">");

            foreach (ASPControlEx objSubASPControlENEx in objASPHtmlTableENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode4Mvc(strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</table>");

        }


        /// <summary>
        /// 生成该对象相关的代码
        /// </summary>
        /// <param name="objASPHtmlTablelENEx">编辑文本框对象</param>      
        public static void GeneHtmlControl(this ASPHtmlTableEx objASPHtmlTablelENEx, HtmlContainerControl objContainer)
        {
            string strActionId = AgcPubFun.getASPNETID();

            HtmlTable objTable = new HtmlTable();
            objTable.Attributes["class"] = objASPHtmlTablelENEx.Class;
            objTable.ID = objASPHtmlTablelENEx.CtrlId;
            objContainer.Controls.Add(objTable);
            foreach (ASPControlEx objSubASPControlENEx in objASPHtmlTablelENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.Parent = objASPHtmlTablelENEx;
                objSubASPControlENEx.GeneHtmlControl(objTable);
                
            }
            //return objTable;
        }
    }
    /// <summary>
    /// ASPNETHtml表(ASPNETHtmlTable)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsASPHtmlTableBLEx 
    {


        public static ASPHtmlTableEx CreateLayout()
        {
            ASPHtmlTableEx objASPHtmlTableENEx_Layout = new ASPHtmlTableEx();
            objASPHtmlTableENEx_Layout.AspControlId = "tabLayout";
            objASPHtmlTableENEx_Layout.AspControlName = "tabLayout";

            ASPRowEx objASPRowENEx_Title = new ASPRowEx();
            objASPRowENEx_Title.AspControlId = "trTitle";
            objASPRowENEx_Title.AspControlName = "trTitle";
            objASPHtmlTableENEx_Layout.arrSubAspControlLst2.Add(objASPRowENEx_Title);

            ASPColEx objASPColENEx = new ASPColEx();
            objASPColENEx.AspControlId = "tdTitle";
            objASPColENEx.AspControlName = "tdTitle";
            objASPRowENEx_Title.arrSubAspControlLst2.Add(objASPColENEx);

            ASPDivEx objASPDivENEx = new ASPDivEx();
            objASPDivENEx.AspControlName = "divTitle";
            objASPColENEx.arrSubAspControlLst2.Add(objASPDivENEx);

            ASPLabelEx objASPLabelENEx_Title = new ASPLabelEx();
            objASPLabelENEx_Title.AspControlId = "lblViewTitle";
            objASPLabelENEx_Title.AspControlName = "lblViewTitle";

            objASPLabelENEx_Title.Text = "性别表维护";
            objASPLabelENEx_Title.CssClass = "PageTitleH1";
            objASPDivENEx.arrSubAspControlLst2.Add(objASPLabelENEx_Title);


            ASPLabelEx objASPLabelENEx_Msg_List = new ASPLabelEx();
            objASPLabelENEx_Msg_List.AspControlId = "lblMsg_List";
            objASPLabelENEx_Msg_List.AspControlName = "lblMsg_List";

            objASPLabelENEx_Msg_List.Text = "";
            objASPLabelENEx_Msg_List.CssClass = "ErrMsg";
            objASPDivENEx.arrSubAspControlLst2.Add(objASPLabelENEx_Msg_List);

            //

            return objASPHtmlTableENEx_Layout;
        }

        public static ASPHtmlTableEx CreateQueryRegion(clsViewInfoENEx objViewInfoENEx)
        {
            ASPHtmlTableEx objASPHtmlTableENEx_Query = new ASPHtmlTableEx();
            objASPHtmlTableENEx_Query.AspControlId = "tabQueryRegion";
            objASPHtmlTableENEx_Query.AspControlName = "tabQueryRegion";

            int intColNum = objViewInfoENEx.objQueryRegionENEx.ColNum * 2;
            int intCurrRow = 1;
            int intCurrCol = 1;

            ASPRowEx objASPRowENEx = new ASPRowEx();
            objASPRowENEx.AspControlId = string.Format("trQryRow{0}", intCurrRow);
            objASPRowENEx.AspControlName = string.Format("trQryRow{0}", intCurrRow);
            objASPHtmlTableENEx_Query.arrSubAspControlLst2.Add(objASPRowENEx);
            ASPColEx objASPColENEx = null;
            ASPLabelEx objASPLabelENEx = null;
            ASPTextBoxEx objASPTextBoxENEx = null;
            foreach (clsQryRegionFldsENEx objQryRegionFldsENEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                objASPColENEx = new ASPColEx();
                objASPColENEx.AspControlId = string.Format("tdQryCol_{0}_{1}", intCurrRow, intCurrCol);
                objASPColENEx.AspControlName = string.Format("tdQryCol_{0}_{1}", intCurrRow, intCurrCol);
                objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);

                objASPLabelENEx = new ASPLabelEx();
                objASPLabelENEx.AspControlId = string.Format("lbl{0}", objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                objASPLabelENEx.AspControlName = string.Format("lbl{0}", objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

                objASPLabelENEx.Text = string.Format("lbl{0}", objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                objASPLabelENEx.CssClass = "LabelDefa";
                objASPColENEx.arrSubAspControlLst2.Add(objASPLabelENEx);

                intCurrCol++;

                objASPColENEx = new ASPColEx();
                objASPColENEx.AspControlId = string.Format("tdQryCol_{0}_{1}", intCurrRow, intCurrCol);
                objASPColENEx.AspControlName = string.Format("tdQryCol_{0}_{1}", intCurrRow, intCurrCol);
                objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);

                objASPTextBoxENEx = new ASPTextBoxEx();
                objASPTextBoxENEx.AspControlId = string.Format("txt{0}", objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                objASPTextBoxENEx.AspControlName = string.Format("txt{0}", objQryRegionFldsENEx.objPrjTabFldENEx.ObjFieldTabENEx.FldName);

                objASPTextBoxENEx.Text = "";
                objASPTextBoxENEx.CssClass = "TextBoxDefa";
                objASPColENEx.arrSubAspControlLst2.Add(objASPTextBoxENEx);


                intCurrCol++;

                if (intCurrCol > intColNum)
                {
                    intCurrRow++; intCurrCol = 1;
                    objASPRowENEx = new ASPRowEx();
                    objASPRowENEx.AspControlId = string.Format("trQryRow{0}", intCurrRow);
                    objASPRowENEx.AspControlName = string.Format("trQryRow{0}", intCurrRow);
                    objASPHtmlTableENEx_Query.arrSubAspControlLst2.Add(objASPRowENEx);

                }

            }
            if (intCurrCol == intColNum)
            {
                intCurrRow++; intCurrCol = 1;
            }
            bool bolIsAddQueryButton = false;
            while (intCurrCol <= intColNum)
            {
                objASPColENEx = new ASPColEx();
                objASPColENEx.AspControlId = string.Format("tdQryCol_{0}_{1}", intCurrRow, intCurrCol);
                objASPColENEx.AspControlName = string.Format("tdQryCol_{0}_{1}", intCurrRow, intCurrCol);
                objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);
                if (bolIsAddQueryButton == false)
                {
                    ASPButtonEx objASPButtonENEx = new ASPButtonEx();
                    objASPButtonENEx.AspControlId = string.Format("btnQuery");
                    objASPButtonENEx.AspControlName = string.Format("btnQuery");

                    objASPButtonENEx.Text = "";
                    objASPButtonENEx.CssClass = "ButtonDefa";
                    objASPColENEx.arrSubAspControlLst2.Add(objASPButtonENEx);
                    bolIsAddQueryButton = true;
                }
                intCurrCol++;
            }
            //

            return objASPHtmlTableENEx_Query;
        }


        public static ASPHtmlTableEx CreateFeatureRegion(clsViewInfoENEx objViewInfoENEx)
        {
            ASPHtmlTableEx objASPHtmlTableENEx_Func = new ASPHtmlTableEx();
            objASPHtmlTableENEx_Func.AspControlId = "tabFeatureRegion";
            objASPHtmlTableENEx_Func.AspControlName = "tabFeatureRegion";


            ASPRowEx objASPRowENEx = new ASPRowEx();
            objASPRowENEx.AspControlId = string.Format("trFuncRow");
            objASPRowENEx.AspControlName = string.Format("trFuncRow");
            objASPHtmlTableENEx_Func.arrSubAspControlLst2.Add(objASPRowENEx);
            int intCurrCol = 1;

            ASPColEx objASPColENEx = null;
            ASPLabelEx objASPLabelENEx = null;

            ASPButtonEx objASPButtonENEx = null;

            objASPLabelENEx = new ASPLabelEx();
            objASPLabelENEx.AspControlId = string.Format("lbl{0}List", objViewInfoENEx.objMainPrjTab.TabName);
            objASPLabelENEx.AspControlName = string.Format("lbl{0}List", objViewInfoENEx.objMainPrjTab.TabName);
            objASPLabelENEx.CssClass = "h6";
            objASPLabelENEx.Text = string.Format("{0}列表", objViewInfoENEx.objMainPrjTab.TabCnName);

            objASPColENEx = new ASPColEx();
            objASPColENEx.AspControlId = string.Format("tdFuncCol{0}", intCurrCol);
            objASPColENEx.AspControlName = string.Format("tdFuncCol{0}", intCurrCol);
            objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);

            objASPColENEx.arrSubAspControlLst2.Add(objASPLabelENEx);
            intCurrCol++;
            foreach (clsFeatureRegionFldsENEx objFeatureRegionFldsENEx in objViewInfoENEx.arrFeatureRegionFlds)
            {
                objASPColENEx = new ASPColEx();
                objASPColENEx.AspControlId = string.Format("tdFuncCol{0}", intCurrCol);
                objASPColENEx.AspControlName = string.Format("tdFuncCol{0}", intCurrCol);
                objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);

                objASPButtonENEx = new ASPButtonEx();
                objASPButtonENEx.AspControlId = string.Format("btn{0}", objFeatureRegionFldsENEx.ButtonName);
                objASPButtonENEx.AspControlName = string.Format("btn{0}", objFeatureRegionFldsENEx.ButtonName);

                objASPButtonENEx.Text = string.Format("{0}", objFeatureRegionFldsENEx.Text);
                objASPButtonENEx.CssClass = "ButtonDefa";
                objASPColENEx.arrSubAspControlLst2.Add(objASPButtonENEx);
                intCurrCol++;
            }
            //

            return objASPHtmlTableENEx_Func;
        }


        public static ASPHtmlTableEx CreateDGRegion(clsViewInfoENEx objViewInfoENEx)
        {
            ASPHtmlTableEx objASPHtmlTableENEx_DG = new ASPHtmlTableEx();
            objASPHtmlTableENEx_DG.AspControlId = string.Format("tab{0}GridView", objViewInfoENEx.objMainPrjTab.TabName);
            objASPHtmlTableENEx_DG.AspControlName = string.Format("tab{0}GridView", objViewInfoENEx.objMainPrjTab.TabName);


            ASPRowEx objASPRowENEx = new ASPRowEx();
            objASPRowENEx.AspControlId = string.Format("trDGRow");
            objASPRowENEx.AspControlName = string.Format("trDGRow");
            objASPHtmlTableENEx_DG.arrSubAspControlLst2.Add(objASPRowENEx);


            ASPColEx objASPColENEx = null;

            objASPColENEx = new ASPColEx();
            objASPColENEx.AspControlId = string.Format("tdDGCol");
            objASPColENEx.AspControlName = string.Format("tdDGCol");
            objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);



            ASPGridViewEx objASPGridViewENEx_DG = clsASPGridViewBLEx.CreateGridView(objViewInfoENEx);
            objASPColENEx.arrSubAspControlLst2.Add(objASPGridViewENEx_DG);

            return objASPHtmlTableENEx_DG;
        }

        /// <summary>
        /// 生成编辑区域
        /// </summary>
        /// <param name = "objViewInfoENEx"></param>
        /// <returns></returns>
        public static ASPHtmlTableEx CreateEditRegion(clsViewInfoENEx objViewInfoENEx)
        {
            ASPHtmlTableEx objASPHtmlTableENEx_Edit = new ASPHtmlTableEx();
            objASPHtmlTableENEx_Edit.AspControlId = string.Format("tabEdit{0}Region", objViewInfoENEx.objMainPrjTab.TabName);
            objASPHtmlTableENEx_Edit.AspControlName = string.Format("tabEdit{0}Region", objViewInfoENEx.objMainPrjTab.TabName);


            ASPRowEx objASPRowENEx = new ASPRowEx();
            objASPRowENEx.AspControlId = string.Format("trEditRow1");
            objASPRowENEx.AspControlName = string.Format("trEditRow1");
            objASPHtmlTableENEx_Edit.arrSubAspControlLst2.Add(objASPRowENEx);

            int intCurrCol = 1;


            ASPColEx objASPColENEx = null;

            objASPColENEx = new ASPColEx();
            objASPColENEx.AspControlId = string.Format("tdEditCol{0}", intCurrCol);
            objASPColENEx.AspControlName = string.Format("tdEditCol{0}", intCurrCol);
            objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);

            ASPLabelEx objASPLabelENEx = new ASPLabelEx();
            objASPLabelENEx.AspControlId = string.Format("lblEdit{0}", objViewInfoENEx.objMainPrjTab.TabName);
            objASPLabelENEx.AspControlName = string.Format("lblEdit{0}", objViewInfoENEx.objMainPrjTab.TabName);
            objASPLabelENEx.CssClass = "h6";
            objASPLabelENEx.Text = string.Format("{0}编辑区域", objViewInfoENEx.objMainPrjTab.TabCnName);
            objASPColENEx.arrSubAspControlLst2.Add(objASPLabelENEx);

            intCurrCol++;
            //<asp:Label ID = "lblMsg_Edit" Style = "z-index: 105;" runat = "server" Width = "208px" Height = "16px"
            //               CssClass = "ErrMsg"></asp:Label>
            objASPColENEx = new ASPColEx();
            objASPColENEx.AspControlId = string.Format("tdEditCol{0}", intCurrCol);
            objASPColENEx.AspControlName = string.Format("tdEditCol{0}", intCurrCol);
            objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);

            objASPLabelENEx = new ASPLabelEx();
            objASPLabelENEx.AspControlId = string.Format("lblMsg_Edit", objViewInfoENEx.objMainPrjTab.TabName);
            objASPLabelENEx.AspControlName = string.Format("lblMsg_Edit", objViewInfoENEx.objMainPrjTab.TabName);
            objASPLabelENEx.CssClass = "ErrMsg";
            objASPColENEx.arrSubAspControlLst2.Add(objASPLabelENEx);

            intCurrCol++;
            //<asp:Label ID = "lblMsg_Edit" Style = "z-index: 105;" runat = "server" Width = "208px" Height = "16px"
            //               CssClass = "ErrMsg"></asp:Label>
            objASPColENEx = new ASPColEx();
            objASPColENEx.AspControlId = string.Format("tdEditCol{0}", intCurrCol);
            objASPColENEx.AspControlName = string.Format("tdEditCol{0}", intCurrCol);
            objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);


            ASPButtonEx objASPButtonENEx = new ASPButtonEx();
            objASPButtonENEx.AspControlId = string.Format("btnOKUpd");
            objASPButtonENEx.AspControlName = string.Format("btnOKUpd");

            objASPButtonENEx.Text = string.Format("添加");
            objASPButtonENEx.CssClass = "btn btn-outline-info";
            objASPButtonENEx.OnClick = "btnOKUpd_Click";

            objASPColENEx.arrSubAspControlLst2.Add(objASPButtonENEx);

            intCurrCol++;
            //<asp:Label ID = "lblMsg_Edit" Style = "z-index: 105;" runat = "server" Width = "208px" Height = "16px"
            //               CssClass = "ErrMsg"></asp:Label>
            objASPColENEx = new ASPColEx();
            objASPColENEx.AspControlId = string.Format("tdEditCol{0}", intCurrCol);
            objASPColENEx.AspControlName = string.Format("tdEditCol{0}", intCurrCol);
            objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);


            objASPButtonENEx = new ASPButtonEx();
            objASPButtonENEx.AspControlId = string.Format("btnCancelSexEdit");
            objASPButtonENEx.AspControlName = string.Format("btnCancelSexEdit");

            objASPButtonENEx.Text = string.Format("取消编辑");
            objASPButtonENEx.CssClass = "btn btn-outline-info";
            objASPButtonENEx.OnClick = "btnCancelSexEdit_Click";

            objASPColENEx.arrSubAspControlLst2.Add(objASPButtonENEx);


            objASPRowENEx = new ASPRowEx();
            objASPRowENEx.AspControlId = string.Format("trEditRow2");
            objASPRowENEx.AspControlName = string.Format("trEditRow2");
            objASPHtmlTableENEx_Edit.arrSubAspControlLst2.Add(objASPRowENEx);

            objASPColENEx = new ASPColEx();
            objASPColENEx.AspControlId = string.Format("tdEditCol{0}", intCurrCol);
            objASPColENEx.AspControlName = string.Format("tdEditCol{0}", intCurrCol);
            objASPColENEx.ColSpan = 4;
            objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);

            ASPWebUserControlEx objASPWebUserControlENEx = new ASPWebUserControlEx();
            objASPWebUserControlENEx.AspControlId = string.Format("wuc{0}B1", objViewInfoENEx.objMainPrjTab.TabName);
            objASPWebUserControlENEx.AspControlName = string.Format("wuc{0}B1", objViewInfoENEx.objMainPrjTab.TabName);
            objASPWebUserControlENEx.wucClassName = string.Format("wuc{0}B", objViewInfoENEx.objMainPrjTab.TabName);
            objASPWebUserControlENEx.TagPrefix = string.Format("uc1");

            objASPColENEx.arrSubAspControlLst2.Add(objASPWebUserControlENEx);


            return objASPHtmlTableENEx_Edit;
        }


        /// <summary>
        /// 建立[存放功能按钮的表]
        /// </summary>
        /// <returns></returns>
        public static ASPHtmlTableEx GettabGridFunction()
        {
            ASPHtmlTableEx objASPHtmlTableENEx = new ASPHtmlTableEx();
            objASPHtmlTableENEx.CtrlId = "tabGridFunction";
            //objASPHtmlTableENEx.OnClick = "btnAddNewRec4Gv_Click";
            //objASPHtmlTableENEx.Text = "添加记录";
            objASPHtmlTableENEx.Style = "width: 100%; height: 32px; ";
            objASPHtmlTableENEx.Class = "msgtable";
            //objASPHtmlTableENEx.Width = 80;
            //objASPHtmlTableENEx.Height = 0;
            return objASPHtmlTableENEx;
        }

        /// <summary>
        /// 建立[存放功能按钮的表]
        /// </summary>
        /// <returns></returns>
        public static ASPHtmlTableEx GetObj4QueryRegion()
        {
            ASPHtmlTableEx objASPHtmlTableENEx = new ASPHtmlTableEx();
            objASPHtmlTableENEx.CtrlId = "tabQuery";
            //objASPHtmlTableENEx.OnClick = "btnAddNewRec4Gv_Click";
            //objASPHtmlTableENEx.Text = "添加记录";
            objASPHtmlTableENEx.Style = "width: 70%; ";
            objASPHtmlTableENEx.Class = "table table-bordered table-hover table td table-sm";
            //objASPHtmlTableENEx.Width = 80;
            //objASPHtmlTableENEx.Height = 0;
            return objASPHtmlTableENEx;
        }

        public static ASPHtmlTableEx GetObj4ListRegion()
        {
            ASPHtmlTableEx objASPHtmlTableENEx = new ASPHtmlTableEx();
            objASPHtmlTableENEx.CtrlId = "tabList";
            //objASPHtmlTableENEx.OnClick = "btnAddNewRec4Gv_Click";
            //objASPHtmlTableENEx.Text = "添加记录";
            objASPHtmlTableENEx.Style = "width: 100%; ";
            objASPHtmlTableENEx.Class = "table table-bordered table-hover table td table-sm";
            //objASPHtmlTableENEx.Width = 80;
            //objASPHtmlTableENEx.Height = 0;
            return objASPHtmlTableENEx;
        }
        public static ASPHtmlTableEx GetObj4ExcelExportRegion()
        {
            ASPHtmlTableEx objASPHtmlTableENEx = new ASPHtmlTableEx();
            objASPHtmlTableENEx.CtrlId = "tabExcelExport";
            //objASPHtmlTableENEx.OnClick = "btnAddNewRec4Gv_Click";
            //objASPHtmlTableENEx.Text = "添加记录";
            objASPHtmlTableENEx.Style = "width: 100%; ";
            objASPHtmlTableENEx.Class = "table table-bordered table-hover table td table-sm";
            //objASPHtmlTableENEx.Width = 80;
            //objASPHtmlTableENEx.Height = 0;
            return objASPHtmlTableENEx;
        }
        public static ASPHtmlTableEx GetObj4EditRegion(string strTabName)
        {
            //< table id = "tabwucXzMajor" style = "width: 600px; padding: 1px;" border = "0" >
            ASPHtmlTableEx objASPHtmlTableENEx = new ASPHtmlTableEx();
            objASPHtmlTableENEx.CtrlId = string.Format("tabwuc{0}", strTabName);
            //objASPHtmlTableENEx.OnClick = "btnAddNewRec4Gv_Click";
            //objASPHtmlTableENEx.Text = "添加记录";
            objASPHtmlTableENEx.Style = "width: 600px; padding: 1px; border:0px";

            objASPHtmlTableENEx.Class = "table table-bordered table-hover";
            //objASPHtmlTableENEx.Width = 80;
            //objASPHtmlTableENEx.Height = 0;
            return objASPHtmlTableENEx;
        }

        public static ASPHtmlTableEx GetEmptyTable()
        {
            ASPHtmlTableEx objASPHtmlTableENEx = new ASPHtmlTableEx();
            objASPHtmlTableENEx.CtrlId = "tabTest";
            //objASPHtmlTableENEx.OnClick = "btnAddNewRec4Gv_Click";
            //objASPHtmlTableENEx.Text = "添加记录";
            objASPHtmlTableENEx.Style = "width: 100%; ";
            objASPHtmlTableENEx.Class = "table";
            //objASPHtmlTableENEx.Width = 80;
            //objASPHtmlTableENEx.Height = 0;
            return objASPHtmlTableENEx;
        }
        public static ASPHtmlTableEx PackageByTable(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        {
            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.GetObj4QueryRegion();
           //封装Td
            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageTd);

            int intCount = 0;
            ASPRowEx objRow = new ASPRowEx();

            foreach (ASPControlEx objInFor in arrASPControlGroupObjLst)
            {
                if (string.IsNullOrEmpty(objInFor.GroupName) == true)
                {
                    objRow.arrSubAspControlLst2.AddRange(objInFor.arrSubAspControlLst2);
                }
                else
                {
                    objRow.arrSubAspControlLst2.Add(objInFor);
                }
                intCount++;
                if (intCount >= intColNum && (arrASPControlGroupObjLst.Count() - intCount) > 1)
                {
                    objTable.arrSubAspControlLst2.Add(objRow);
                    objRow = new ASPRowEx();
                    intCount = 0;
                }

            }
            if (intCount > 0)
            {
                objTable.arrSubAspControlLst2.Add(objRow);
            }
            return objTable;
        }
    }
}