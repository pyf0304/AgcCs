
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

using com.taishsoft.util;

namespace AGC.PureClassEx
{
    /// <summary>
    /// ASPNETHtml表(ASPNETHtmlTable)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public static class clsASPHtmlTableBLEx_Static
    {

        public static void GeneCode(this ASPHtmlTableEx objASPHtmlTableENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
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
            strCodeForCs.AppendFormat("\r\n" + "<table");

            //生成控件的Id、Name
            clsASPControlBLEx.GC4Id(objASPHtmlTableENEx, strCodeForCs);

            IEnumerable<string> arrStyle = objASPHtmlTableENEx.Style.Split(";".ToCharArray());
            arrStyle = arrStyle.Where(x => x.Length > 0);
            List<clsCboObject> arrCboObject = arrStyle.Select(x=> {
                string[] sstrDic = x.Split(":".ToCharArray());
                if (sstrDic.Length < 2) return new clsCboObject("","");
                return  new clsCboObject( sstrDic[1], sstrDic[0]);
                })
                .Where(x=>x.Text.Length>0).ToList();
            
            Dictionary<string, string> dicStyle = arrCboObject.ToDictionary(key=>key.Text, value=>value.Value);
            if (objASPHtmlTableENEx.Width > 0)
            {
                dicStyle["width"] = string.Format("{0}px", objASPHtmlTableENEx.Width);
            }
            List<clsCboObject> arrCboObject2 = dicStyle.Select(x=>new clsCboObject(x.Value, x.Key)).ToList();
            List<string> arrStyle2 = arrCboObject2.Select(x=>string.Format("{0}:{1}", x.Text,x.Value)).ToList();
            string strStyles = string.Join(";", arrStyle2);
            objASPHtmlTableENEx.Style = strStyles;
            //生成控件的样式
            clsASPControlBLEx.GC4Style(objASPHtmlTableENEx, strCodeForCs);
            clsASPControlBLEx.GC4Runat(objASPHtmlTableENEx, strCodeForCs);

            strCodeForCs.Append(">");
            strCodeForCs.Append("\r\n" + "<tbody>");
            foreach (ASPControlEx objSubASPControlENEx in objASPHtmlTableENEx.arrSubAspControlLst2)
            {
                objSubASPControlENEx.GeneCode(intApplicationTypeId, strCodeForCs);
            }
            strCodeForCs.Append("\r\n" + "</tbody>");
            strCodeForCs.Append("\r\n" + "</table>");

        }

        //public static void GeneCode4Html(this ASPHtmlTableEx objASPHtmlTableENEx, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        //{

        //    strCodeForCs.AppendFormat("\r\n" + "<table");

        //    //生成控件的Id、Name
        //    clsASPControlBLEx.GC4Id(objASPHtmlTableENEx, strCodeForCs);

        //    IEnumerable<string> arrStyle = objASPHtmlTableENEx.Style.Split(";".ToCharArray());
        //    arrStyle = arrStyle.Where(x => x.Length > 0);
        //    List<clsCboObject> arrCboObject = arrStyle.Select(x => {
        //        string[] sstrDic = x.Split(":".ToCharArray());
        //        if (sstrDic.Length < 2) return new clsCboObject("", "");
        //        return new clsCboObject(sstrDic[1], sstrDic[0]);
        //    })
        //        .Where(x => x.Text.Length > 0).ToList();

        //    Dictionary<string, string> dicStyle = arrCboObject.ToDictionary(key => key.Text, value => value.Value);
        //    if (objASPHtmlTableENEx.Width > 0)
        //    {
        //        dicStyle["width"] = string.Format("{0}px", objASPHtmlTableENEx.Width);
        //    }
        //    List<clsCboObject> arrCboObject2 = dicStyle.Select(x => new clsCboObject(x.Value, x.Key)).ToList();
        //    List<string> arrStyle2 = arrCboObject2.Select(x => string.Format("{0}:{1}", x.Text, x.Value)).ToList();
        //    string strStyles = string.Join(";", arrStyle2);
        //    objASPHtmlTableENEx.Style = strStyles;
        //    //生成控件的样式
        //    clsASPControlBLEx.GC4Style(objASPHtmlTableENEx, strCodeForCs);
        //    clsASPControlBLEx.GC4Runat(objASPHtmlTableENEx, strCodeForCs);

        //    strCodeForCs.Append(">");

        //    foreach (ASPControlEx objSubASPControlENEx in objASPHtmlTableENEx.arrSubAspControlLst2)
        //    {
        //        objSubASPControlENEx.GeneCode4Html(intApplicationTypeId, strCodeForCs);
        //    }
        //    strCodeForCs.Append("\r\n" + "</table>");

        //}


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

      
    

      
        /// <summary>
        /// 生成编辑区域
        /// </summary>
        /// <param name = "objViewInfoENEx"></param>
        /// <returns></returns>
        public static ASPHtmlTableEx CreateEditRegion(clsViewInfoEN objViewInfoENEx)
        {
            ASPHtmlTableEx objASPHtmlTableENEx_Edit = new ASPHtmlTableEx();
            objASPHtmlTableENEx_Edit.AspControlId = string.Format("tabEdit{0}Region", objViewInfoENEx.ObjMainPrjTab().TabName);
            objASPHtmlTableENEx_Edit.AspControlName = string.Format("tabEdit{0}Region", objViewInfoENEx.ObjMainPrjTab().TabName);


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
            objASPLabelENEx.AspControlId = string.Format("lblEdit{0}", objViewInfoENEx.ObjMainPrjTab().TabName);
            objASPLabelENEx.AspControlName = string.Format("lblEdit{0}", objViewInfoENEx.ObjMainPrjTab().TabName);
            objASPLabelENEx.CssClass = "h6";
            objASPLabelENEx.Text = string.Format("{0}编辑区域", objViewInfoENEx.ObjMainPrjTab().TabCnName);
            objASPColENEx.arrSubAspControlLst2.Add(objASPLabelENEx);

            intCurrCol++;
            //<asp:Label ID = "lblMsg_Edit" Style = "z-index: 105;" runat = "server" Width = "208px" Height = "16px"
            //               CssClass = "ErrMsg"></asp:Label>
            objASPColENEx = new ASPColEx();
            objASPColENEx.AspControlId = string.Format("tdEditCol{0}", intCurrCol);
            objASPColENEx.AspControlName = string.Format("tdEditCol{0}", intCurrCol);
            objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);

            objASPLabelENEx = new ASPLabelEx();
            objASPLabelENEx.AspControlId = string.Format("lblMsg_Edit", objViewInfoENEx.ObjMainPrjTab().TabName);
            objASPLabelENEx.AspControlName = string.Format("lblMsg_Edit", objViewInfoENEx.ObjMainPrjTab().TabName);
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
            objASPColENEx.ColSpan_Ctrl = 4;
            objASPRowENEx.arrSubAspControlLst2.Add(objASPColENEx);

            ASPWebUserControlEx objASPWebUserControlENEx = new ASPWebUserControlEx();
            objASPWebUserControlENEx.AspControlId = string.Format("wuc{0}B1", objViewInfoENEx.ObjMainPrjTab().TabName);
            objASPWebUserControlENEx.AspControlName = string.Format("wuc{0}B1", objViewInfoENEx.ObjMainPrjTab().TabName);
            objASPWebUserControlENEx.wucClassName = string.Format("wuc{0}B", objViewInfoENEx.ObjMainPrjTab().TabName);
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

        public static ASPHtmlTableEx GetObj4EditRegion()
        {
            ASPHtmlTableEx objASPHtmlTableENEx = new ASPHtmlTableEx();
            objASPHtmlTableENEx.CtrlId = "tabEdit";
            //objASPHtmlTableENEx.OnClick = "btnAddNewRec4Gv_Click";
            //objASPHtmlTableENEx.Text = "添加记录";
            objASPHtmlTableENEx.Style = "width: 70%; ";
            objASPHtmlTableENEx.Class = "table table-bordered table-hover table td table-sm";
            //objASPHtmlTableENEx.Width = 80;
            //objASPHtmlTableENEx.Height = 0;
            return objASPHtmlTableENEx;
        }

        public static ASPHtmlTableEx GetObj4DetailRegion()
        {
            ASPHtmlTableEx objASPHtmlTableENEx = new ASPHtmlTableEx();
            objASPHtmlTableENEx.CtrlId = "tabEdit";
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
        public static ASPHtmlTableEx PackageByTable4QryRegionBak20200622(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
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
                if (objInFor.ColSpan_Ctrl > 1)
                {
                    intCount += objInFor.ColSpan_Ctrl;
                }
                else
                {
                    intCount++;
                }
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

        public static ASPHtmlTableEx PackageByTable4EditRegion(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        {
            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.GetObj4EditRegion();
            //封装Td
            List<ASPControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageTd).ToList();

            int intCount = 0;
            ASPRowEx objRow = new ASPRowEx();
            Dictionary<long, int> dicEditRegionFldColIndex = new Dictionary<long, int>();
            foreach (ASPControlGroupEx objInFor in arrASPControlGroupObjLst)
            {
                
                if (objInFor.arrSubAspControlLst2.Count == 0) continue;
                int intMaxColSpan1 = objInFor.arrSubAspControlLst2.Max(x => x.ColSpan_Ctrl);
                int intMaxColSpan = objInFor.arrSubAspControlLst2.Select(x => x.ColSpan_Ctrl).Max();
                if (intMaxColSpan > 1 || intMaxColSpan1>1)
                {
                    //string ss = "";
                }
                int intColSpan = intMaxColSpan / 2 + intMaxColSpan % 2;
                if (intCount + intColSpan > intColNum)
                {
                    if (objRow.arrSubAspControlLst2.Count > 0)
                    {
                        objTable.arrSubAspControlLst2.Add(objRow);
                    }
                    objRow = new ASPRowEx();
             
                    intCount = 0;
                    if (string.IsNullOrEmpty(objInFor.GroupName) == true)
                    {
                        objRow.FldName = objInFor.FldName;
                        objRow.arrSubAspControlLst2.AddRange(objInFor.arrSubAspControlLst2);
                    }
                    else
                    {
                        objRow.FldName = objInFor.FldName;
                        objRow.arrSubAspControlLst2.Add(objInFor);
                    }
                    if (objInFor.KeyId > 0)
                    {
                        if (objInFor.ColIndex != intCount + 1)
                        {
                            int intRecNum = clsEditRegionFldsBL.SetFldValue(conEditRegionFlds._CurrTabName, conEditRegionFlds.ColIndex, intCount + 1, string.Format("{0}={1}", conEditRegionFlds.mId, objInFor.KeyId));
                            int ii = intRecNum;
                        }
                    }
                    intCount += intColSpan;
                                       
                    continue;
                }
                else
                {
                    if (string.IsNullOrEmpty(objInFor.GroupName) == true)
                    {
                        objRow.FldName = objInFor.FldName;
                        objRow.arrSubAspControlLst2.AddRange(objInFor.arrSubAspControlLst2);
                    }
                    else
                    {
                        objRow.FldName = objInFor.FldName;
                        objRow.arrSubAspControlLst2.Add(objInFor);
                    }
                    if (objInFor.KeyId > 0)
                    {
                        if (objInFor.ColIndex != intCount + 1)
                        {
                            int intRecNum = clsEditRegionFldsBL.SetFldValue(conEditRegionFlds._CurrTabName, conEditRegionFlds.ColIndex, intCount + 1, string.Format("{0}={1}", conEditRegionFlds.mId, objInFor.KeyId));
                            int ii = intRecNum;
                        }
                    }
                    intCount += intColSpan;
                }
                if (intCount >= intColNum && (arrASPControlGroupObjLst.Count() - intCount) > 1)
                {
                    if (objRow.arrSubAspControlLst2.Count > 0)
                    {
                        objTable.arrSubAspControlLst2.Add(objRow);
                    }
                    objRow = new ASPRowEx();            
                    intCount = 0;
                }

            }
            if (intCount > 0)
            {
                if (objRow.arrSubAspControlLst2.Count > 0)
                {
                    objTable.arrSubAspControlLst2.Add(objRow);
                }
            }
            return objTable;
        }

        //public static ASPHtmlTableEx PackageByTable4EditRegion(IEnumerable<VueControlGroupEx> arrControlGroups, int intColNum)
        //{
        //    ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.GetObj4EditRegion();
        //    //封装Td
        //    List<VueControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsVueControlGroupBLEx.PackageTd).ToList();

        //    int intCount = 0;
        //    ASPRowEx objRow = new ASPRowEx();
        //    Dictionary<long, int> dicEditRegionFldColIndex = new Dictionary<long, int>();
        //    foreach (VueControlGroupEx objInFor in arrASPControlGroupObjLst)
        //    {

        //        if (objInFor.arrSubAspControlLst2.Count == 0) continue;
        //        int intMaxColSpan1 = objInFor.arrSubAspControlLst2.Max(x => x.ColSpan_Ctrl);
        //        int intMaxColSpan = objInFor.arrSubAspControlLst2.Select(x => x.ColSpan_Ctrl).Max();
        //        if (intMaxColSpan > 1 || intMaxColSpan1 > 1)
        //        {
        //            //string ss = "";
        //        }
        //        int intColSpan = intMaxColSpan / 2 + intMaxColSpan % 2;
        //        if (intCount + intColSpan > intColNum)
        //        {
        //            if (objRow.arrSubAspControlLst2.Count > 0)
        //            {
        //                objTable.arrSubAspControlLst2.Add(objRow);
        //            }
        //            objRow = new ASPRowEx();

        //            intCount = 0;
        //            if (string.IsNullOrEmpty(objInFor.GroupName) == true)
        //            {
        //                objRow.FldName = objInFor.FldName;
        //                objRow.arrSubAspControlLst2.AddRange(objInFor.arrSubAspControlLst2);
        //            }
        //            else
        //            {
        //                objRow.FldName = objInFor.FldName;
        //                objRow.arrSubAspControlLst2.Add(objInFor);
        //            }
        //            if (objInFor.KeyId > 0)
        //            {
        //                if (objInFor.ColIndex != intCount + 1)
        //                {
        //                    int intRecNum = clsEditRegionFldsBL.SetFldValue(conEditRegionFlds._CurrTabName, conEditRegionFlds.ColIndex, intCount + 1, string.Format("{0}={1}", conEditRegionFlds.mId, objInFor.KeyId));
        //                    int ii = intRecNum;
        //                }
        //            }
        //            intCount += intColSpan;

        //            continue;
        //        }
        //        else
        //        {
        //            if (string.IsNullOrEmpty(objInFor.GroupName) == true)
        //            {
        //                objRow.FldName = objInFor.FldName;
        //                objRow.arrSubAspControlLst2.AddRange(objInFor.arrSubAspControlLst2);
        //            }
        //            else
        //            {
        //                objRow.FldName = objInFor.FldName;
        //                objRow.arrSubAspControlLst2.Add(objInFor);
        //            }
        //            if (objInFor.KeyId > 0)
        //            {
        //                if (objInFor.ColIndex != intCount + 1)
        //                {
        //                    int intRecNum = clsEditRegionFldsBL.SetFldValue(conEditRegionFlds._CurrTabName, conEditRegionFlds.ColIndex, intCount + 1, string.Format("{0}={1}", conEditRegionFlds.mId, objInFor.KeyId));
        //                    int ii = intRecNum;
        //                }
        //            }
        //            intCount += intColSpan;
        //        }
        //        if (intCount >= intColNum && (arrASPControlGroupObjLst.Count() - intCount) > 1)
        //        {
        //            if (objRow.arrSubAspControlLst2.Count > 0)
        //            {
        //                objTable.arrSubAspControlLst2.Add(objRow);
        //            }
        //            objRow = new ASPRowEx();
        //            intCount = 0;
        //        }

        //    }
        //    if (intCount > 0)
        //    {
        //        if (objRow.arrSubAspControlLst2.Count > 0)
        //        {
        //            objTable.arrSubAspControlLst2.Add(objRow);
        //        }
        //    }
        //    return objTable;
        //}


        public static ASPHtmlTableEx PackageByTable4DetailRegion(IEnumerable<ASPControlGroupEx> arrControlGroups, int intColNum)
        {
            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.GetObj4DetailRegion();
            //封装Td
            List<ASPControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsASPControlGroupBLEx.PackageTd).ToList();

            int intCount = 0;
            ASPRowEx objRow = new ASPRowEx();
            Dictionary<long, int> dicDetailRegionFldColIndex = new Dictionary<long, int>();
            foreach (ASPControlGroupEx objInFor in arrASPControlGroupObjLst)
            {
                if (objInFor.arrSubAspControlLst2.Count == 0) continue;
                int intMaxColSpan1 = objInFor.arrSubAspControlLst2.Max(x => x.ColSpan_Ctrl);
                int intMaxColSpan = objInFor.arrSubAspControlLst2.Select(x => x.ColSpan_Ctrl).Max();
                if (intMaxColSpan > 1 || intMaxColSpan1 > 1)
                {
                    //string ss = "";
                }
                int intColSpan = intMaxColSpan / 2 + intMaxColSpan % 2;
                if (intCount + intColSpan > intColNum)
                {
                    objTable.arrSubAspControlLst2.Add(objRow);
                    objRow = new ASPRowEx();

                    intCount = 0;
                    if (string.IsNullOrEmpty(objInFor.GroupName) == true)
                    {
                        objRow.arrSubAspControlLst2.AddRange(objInFor.arrSubAspControlLst2);
                    }
                    else
                    {
                        objRow.arrSubAspControlLst2.Add(objInFor);
                    }
                    if (objInFor.KeyId > 0)
                    {
                        if (objInFor.ColIndex != intCount + 1)
                        {
                            int intRecNum = clsDetailRegionFldsBL.SetFldValue(conDetailRegionFlds._CurrTabName, conDetailRegionFlds.ColIndex, intCount + 1, string.Format("{0}={1}", conDetailRegionFlds.mId, objInFor.KeyId));
                            int ii = intRecNum;
                        }
                    }
                    intCount += intColSpan;

                    continue;
                }
                else
                {
                    if (string.IsNullOrEmpty(objInFor.GroupName) == true)
                    {
                        objRow.arrSubAspControlLst2.AddRange(objInFor.arrSubAspControlLst2);
                    }
                    else
                    {
                        objRow.arrSubAspControlLst2.Add(objInFor);
                    }
                    if (objInFor.KeyId > 0)
                    {
                        if (objInFor.ColIndex != intCount + 1)
                        {
                            int intRecNum = clsDetailRegionFldsBL.SetFldValue(conDetailRegionFlds._CurrTabName, conDetailRegionFlds.ColIndex, intCount + 1, string.Format("{0}={1}", conDetailRegionFlds.mId, objInFor.KeyId));
                            int ii = intRecNum;
                        }
                    }
                    intCount += intColSpan;
                }
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

        //public static ASPHtmlTableEx PackageByTable4DetailRegion(IEnumerable<VueControlGroupEx> arrControlGroups, int intColNum)
        //{
        //    ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.GetObj4DetailRegion();
        //    //封装Td
        //    List<VueControlGroupEx> arrASPControlGroupObjLst = arrControlGroups.Select(clsVueControlGroupBLEx.PackageTd).ToList();

        //    int intCount = 0;
        //    ASPRowEx objRow = new ASPRowEx();
        //    Dictionary<long, int> dicDetailRegionFldColIndex = new Dictionary<long, int>();
        //    foreach (VueControlGroupEx objInFor in arrASPControlGroupObjLst)
        //    {
        //        if (objInFor.arrSubAspControlLst2.Count == 0) continue;
        //        int intMaxColSpan1 = objInFor.arrSubAspControlLst2.Max(x => x.ColSpan_Ctrl);
        //        int intMaxColSpan = objInFor.arrSubAspControlLst2.Select(x => x.ColSpan_Ctrl).Max();
        //        if (intMaxColSpan > 1 || intMaxColSpan1 > 1)
        //        {
        //            //string ss = "";
        //        }
        //        int intColSpan = intMaxColSpan / 2 + intMaxColSpan % 2;
        //        if (intCount + intColSpan > intColNum)
        //        {
        //            objTable.arrSubAspControlLst2.Add(objRow);
        //            objRow = new ASPRowEx();

        //            intCount = 0;
        //            if (string.IsNullOrEmpty(objInFor.GroupName) == true)
        //            {
        //                objRow.arrSubAspControlLst2.AddRange(objInFor.arrSubAspControlLst2);
        //            }
        //            else
        //            {
        //                objRow.arrSubAspControlLst2.Add(objInFor);
        //            }
        //            if (objInFor.KeyId > 0)
        //            {
        //                if (objInFor.ColIndex != intCount + 1)
        //                {
        //                    int intRecNum = clsDetailRegionFldsBL.SetFldValue(conDetailRegionFlds._CurrTabName, conDetailRegionFlds.ColIndex, intCount + 1, string.Format("{0}={1}", conDetailRegionFlds.mId, objInFor.KeyId));
        //                    int ii = intRecNum;
        //                }
        //            }
        //            intCount += intColSpan;

        //            continue;
        //        }
        //        else
        //        {
        //            if (string.IsNullOrEmpty(objInFor.GroupName) == true)
        //            {
        //                objRow.arrSubAspControlLst2.AddRange(objInFor.arrSubAspControlLst2);
        //            }
        //            else
        //            {
        //                objRow.arrSubAspControlLst2.Add(objInFor);
        //            }
        //            if (objInFor.KeyId > 0)
        //            {
        //                if (objInFor.ColIndex != intCount + 1)
        //                {
        //                    int intRecNum = clsDetailRegionFldsBL.SetFldValue(conDetailRegionFlds._CurrTabName, conDetailRegionFlds.ColIndex, intCount + 1, string.Format("{0}={1}", conDetailRegionFlds.mId, objInFor.KeyId));
        //                    int ii = intRecNum;
        //                }
        //            }
        //            intCount += intColSpan;
        //        }
        //        if (intCount >= intColNum && (arrASPControlGroupObjLst.Count() - intCount) > 1)
        //        {
        //            objTable.arrSubAspControlLst2.Add(objRow);
        //            objRow = new ASPRowEx();
        //            intCount = 0;
        //        }

        //    }
        //    if (intCount > 0)
        //    {
        //        objTable.arrSubAspControlLst2.Add(objRow);
        //    }
        //    return objTable;
        //}


        public static ASPHtmlTableEx PackageByTable4QueryRegion(IEnumerable<ASPControlEx> arrControl, int intColNum)
        {
            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.GetObj4EditRegion();
            //封装Td
            IEnumerable<ASPControlEx> arrASPControlObjLst = arrControl.Select(clsASPControlBLEx.PackageTd);

            int intCount = 0;
            ASPRowEx objRow = new ASPRowEx();
            
            foreach (ASPControlEx objInFor in arrASPControlObjLst)
            {
                //int intMaxColSpan = objInFor.arrSubAspControlLst2.Select(x => x.ColSpan_Ctrl).Max();
                int intColSpan = 1;// intMaxColSpan;
                //if (intColSpan == 0) intColSpan = 1;
                //objInFor.ColSpan_Ctrl = intColSpan;
                if (intCount + intColSpan > intColNum)
                {
                    objTable.arrSubAspControlLst2.Add(objRow);
                    objRow = new ASPRowEx();

                    intCount = 0;
                    if (string.IsNullOrEmpty(objInFor.GroupName) == true)
                    {
                        objRow.arrSubAspControlLst2.Add(objInFor);
                    }
                    else
                    {
                        objRow.arrSubAspControlLst2.Add(objInFor);
                    }
                    if (objInFor.KeyId > 0)
                    {
                        if (objInFor.ColIndex != intCount + 1)
                        {
                            int intRecNum = clsEditRegionFldsBL.SetFldValue(conEditRegionFlds._CurrTabName, conEditRegionFlds.ColIndex, intCount + 1, string.Format("{0}={1}", conEditRegionFlds.mId, objInFor.KeyId));
                            int ii = intRecNum;
                        }
                    }
                    intCount += intColSpan;

                    continue;
                }
                else
                {
                    if (string.IsNullOrEmpty(objInFor.GroupName) == true)
                    {
                        objRow.arrSubAspControlLst2.Add(objInFor);
                    }
                    else
                    {
                        objRow.arrSubAspControlLst2.Add(objInFor);
                    }
                    if (objInFor.KeyId > 0)
                    {
                        if (objInFor.ColIndex != intCount + 1)
                        {
                            int intRecNum = clsEditRegionFldsBL.SetFldValue(conEditRegionFlds._CurrTabName, conEditRegionFlds.ColIndex, intCount + 1, string.Format("{0}={1}", conEditRegionFlds.mId, objInFor.KeyId));
                            int ii = intRecNum;
                        }
                    }
                    intCount += intColSpan;
                }
                if (intCount >= intColNum && (arrASPControlObjLst.Count() - intCount) > 1)
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

        public static ASPHtmlTableEx PackageByTable4QueryRegion(IEnumerable<ASPControlGroupEx> arrControl, int intColNum)
        {
            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.GetObj4EditRegion();
            //封装Td
            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst = arrControl.Select(clsASPControlGroupBLEx.PackageTd);

            int intCount = 0;
            ASPRowEx objRow = new ASPRowEx();

            foreach (ASPControlGroupEx objInFor in arrASPControlGroupObjLst)
            {
                if (objInFor.arrSubAspControlLst2.Count == 0) continue;
                int intMaxColSpan1 = objInFor.arrSubAspControlLst2.Max(x => x.ColSpan_Ctrl);
                int intMaxColSpan = objInFor.arrSubAspControlLst2.Select(x => x.ColSpan_Ctrl).Max();
                if (intMaxColSpan > 1 || intMaxColSpan1 > 1)
                {
                    //string ss = "";
                }
                int intColSpan = intMaxColSpan / 2 + intMaxColSpan % 2;
                if (intCount + intColSpan > intColNum)
                {
                    if (objRow.arrSubAspControlLst2.Count > 0)
                    {
                        objTable.arrSubAspControlLst2.Add(objRow);
                    }
                    objRow = new ASPRowEx();

                    intCount = 0;
                    if (string.IsNullOrEmpty(objInFor.GroupName) == true)
                    {
                        objRow.FldName = objInFor.FldName;
                        objRow.arrSubAspControlLst2.AddRange(objInFor.arrSubAspControlLst2);
                    }
                    else
                    {
                        objRow.FldName = objInFor.FldName;
                        objRow.arrSubAspControlLst2.Add(objInFor);
                    }
                    if (objInFor.KeyId > 0)
                    {
                        if (objInFor.ColIndex != intCount + 1)
                        {
                            int intRecNum = clsEditRegionFldsBL.SetFldValue(conEditRegionFlds._CurrTabName, conEditRegionFlds.ColIndex, intCount + 1, string.Format("{0}={1}", conEditRegionFlds.mId, objInFor.KeyId));
                            int ii = intRecNum;
                        }
                    }
                    intCount += intColSpan;

                    continue;
                }
                else
                {
                    if (string.IsNullOrEmpty(objInFor.GroupName) == true)
                    {
                        objRow.FldName = objInFor.FldName;
                        objRow.arrSubAspControlLst2.AddRange(objInFor.arrSubAspControlLst2);
                    }
                    else
                    {
                        objRow.FldName = objInFor.FldName;
                        objRow.arrSubAspControlLst2.Add(objInFor);
                    }
                    if (objInFor.KeyId > 0)
                    {
                        if (objInFor.ColIndex != intCount + 1)
                        {
                            int intRecNum = clsEditRegionFldsBL.SetFldValue(conEditRegionFlds._CurrTabName, conEditRegionFlds.ColIndex, intCount + 1, string.Format("{0}={1}", conEditRegionFlds.mId, objInFor.KeyId));
                            int ii = intRecNum;
                        }
                    }
                    intCount += intColSpan;
                }
                if (intCount >= intColNum && (arrASPControlGroupObjLst.Count() - intCount) > 1)
                {
                    if (objRow.arrSubAspControlLst2.Count > 0)
                    {
                        objTable.arrSubAspControlLst2.Add(objRow);
                    }
                    objRow = new ASPRowEx();
                    intCount = 0;
                }

            }
            if (intCount > 0)
            {
                if (objRow.arrSubAspControlLst2.Count > 0)
                {
                    objTable.arrSubAspControlLst2.Add(objRow);
                }
            }
            return objTable;
        }

    }
}