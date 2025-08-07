using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.file;
using com.taishsoft.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Web.UI.WebControls;
using TzCommWebServerCtrlLib;

namespace AutoGCLib
{
    /// <summary>
    /// 自动生成界面控制层的代码类(View of Mvc)
    /// </summary>
    public class Mvc_ViewSpa4CSharp : clsGeneCodeBase4View
    {
        clsBiDimDistribute objBiDimDistribue4Qry = null;

        //		private objViewInfoENEx.FileName;		//生成的文件名；
        #region 构造函数
        public Mvc_ViewSpa4CSharp()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
        }
        public Mvc_ViewSpa4CSharp(string strViewId)
       : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public Mvc_ViewSpa4CSharp(string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        #endregion
        /// <summary>
        /// 初始化页面设置
        /// </summary>
        public void InitPageSetup()
        {
            intZIndex = 100;        ///控件焦点序号
            intCurrLeft = 10;  ///控件的左边空;
            intCurrTop = 10;
        }


     



        ///以下均是界面层内容(VIEW)-------
        public string A_GenCtlViewCodeforTab(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;
            //让用户设置属性;

            objViewInfoENEx.CurrDate = clsDateTime.getTodayStr2(0);
            string strFolder;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;

            int intZIndex;
            //			int intCurrLeft;  ///控件的左边空;
            int intCurrTop;  ///控件的顶面空;
            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "B.ascx";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlFName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlFName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {
                ///生成插入记录的界面代码;
                ///      strCodeForCs.Append("\r\n" + "///生成与表相关的控件界面层代码");
                //				<%@ Control Language = "C#" AutoEventWireup = "true" CodeBehind = "wucStuBaseInfor.ascx.cs" Inherits = "Webform.wucStuBaseInfor" %>
                if (objViewInfoENEx.ApplicationTypeId2 == "04")
                {
                    strCodeForCs.AppendFormat("\r\n" +
                       "<%@ Control Language = \"C#\" AutoEventWireup = \"true\" CodeFile = \"wuc{0}B.ascx.cs\" Inherits = \"{1}.Webform.wuc{2}B\" %>",
                       objViewInfoENEx.TabName, objViewInfoENEx.NameSpace, objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" +
                      "<%@ Control Language = \"C#\" AutoEventWireup = \"true\" CodeBehind = \"wuc{0}B.ascx.cs\" Inherits = \"{1}.Webform.wuc{2}B\" %>",
                      objViewInfoENEx.TabName, objViewInfoENEx.NameSpace, objViewInfoENEx.TabName);
                }
                //strCodeForCs.AppendFormat("\r\n" + "<link rel = \"stylesheet\" type = \"text/css\" href = \"../../css/taishweb2.css\"/>",
                //  objViewInfoENEx.NameSpace);
                strCodeForCs.AppendFormat("\r\n" + "<link rel = \"stylesheet\" type = \"text/css\" href = \"../../css/tz_base1.css\"/>",
                    objViewInfoENEx.NameSpace);
                //				strCodeForCs.Append("\r\n" + "<meta name = \"vs_snapToGrid\" content = \"false\">");
                //				strCodeForCs.Append("\r\n" + "<meta name = \"vs_showGrid\" content = \"true\">");
                strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabwuc{0}\" class = \"tab_wucEdit\" >",
                  objViewInfoENEx.TabName);
                intZIndex = 101;
                //				intCurrLeft = 10;
                intCurrTop = 50;
                if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
                {
                    StringBuilder sbMessage = new StringBuilder();
                    string strViewName = objViewInfoENEx.ViewName;
                    sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                    throw new clsDbObjException(sbMessage.ToString());
                }

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///如果该字段不是标识递增型就生成控件,否则就不生成;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                      && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    strCodeForCs.AppendFormat("\r\n" + "<tr>");
                    switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" runat = \"server\" Text = \"{2}\" CssClass = \"Check_Defa\"></asp:{3}>",
                              objEditRegionFldsEx.objCtlType.CtlTypeName, objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.LabelCaption, objEditRegionFldsEx.objCtlType.CtlTypeName);
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            break;
                        default:

                            strCodeForCs.AppendFormat("\r\n" + "<td class = \"NameTD\">");
                            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\" CssClass = \"NameControl\">{1}</asp:Label>",
                              "lbl" + objEditRegionFldsEx.FldName,
                              objEditRegionFldsEx.LabelCaption);
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            strCodeForCs.AppendFormat("\r\n" + "<td class = \"ValueTD\">");
                            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" runat = \"server\" CssClass = \"ValueControl\"></asp:{2}>",
                              objEditRegionFldsEx.objCtlType.CtlTypeName, objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.objCtlType.CtlTypeName);
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            break;
                    }
                    strCodeForCs.AppendFormat("\r\n" + "<td>");
                    ///插入验证控件代码;
                    switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                        case "short":
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"text-warning\" ErrorMessage = \"请输入整型数值!\" ControlToValidate = \"{1}\" ",
                              objEditRegionFldsEx.FldName, objEditRegionFldsEx.CtrlId);
                            strCodeForCs.AppendFormat("\r\n" + "Type = \"Integer\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                            strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                            break;
                        case "DateTime":
                            strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"text-warning\" ErrorMessage = \"请输入日期型数值!\" ControlToValidate = \"{1}\" ",
                              objEditRegionFldsEx.FldName, objEditRegionFldsEx.CtrlId);
                            strCodeForCs.AppendFormat("\r\n" + "Type = \"Date\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                            strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                            break;
                        case "double":
                            strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"text-warning\" ErrorMessage = \"请输入浮点型数值!\" ControlToValidate = \"{1}\" ",
                              objEditRegionFldsEx.FldName, objEditRegionFldsEx.CtrlId);
                            strCodeForCs.AppendFormat("\r\n" + "Type = \"Double\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                            strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                            break;

                        case "float":
                            strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"text-warning\" ErrorMessage = \"请输入浮点型数值!\" ControlToValidate = \"{1}\" ",
                              objEditRegionFldsEx.FldName, objEditRegionFldsEx.CtrlId);
                            strCodeForCs.AppendFormat("\r\n" + "Type = \"Double\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                            strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                            break;
                    }
                    strCodeForCs.AppendFormat("\r\n" + "</td>");
                    strCodeForCs.AppendFormat("\r\n" + "<td></td>");
                    strCodeForCs.AppendFormat("\r\n" + "</tr>");
                    intZIndex += 1;
                    intCurrTop += 25;

                }
                strCodeForCs.AppendFormat("\r\n" + "</table>");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //检查该文件名的文件夹名,并判断是否存在;
            strFolder = clsString.ParentDir_S(objViewInfoENEx.WebUserCtlFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebUserCtlFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.FolderName_Root, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
                    throw new Exception(strMsg);

                }
            }
            //////UTF8Encoding utf8 = new UTF8Encoding(false);
            //clsFile.CreateFileByString(objViewInfoENEx.WebUserCtlFName, strCodeForCs.ToString(), myEncoding); 

            clsFile.CreateFileByString(objViewInfoENEx.WebUserCtlFName, strCodeForCs.ToString());
            return strCodeForCs.ToString();
        }
        ///以下均是界面层内容(VIEW)-------

        public string A_GenCtlViewCodeforTab4Query(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;
            //让用户设置属性;
            string strFolder;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;

            int intZIndex;
            //			int intCurrLeft;  ///控件的左边空;
            int intCurrTop;  ///控件的顶面空;
            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "Query.ascx";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlFName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlFName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {
                ///生成插入记录的界面代码;
                ///      strCodeForCs.Append("\r\n" + "///生成与表相关的控件界面层代码");
                ///      

                if (objViewInfoENEx.ApplicationTypeId2 == "04")
                {
                    strCodeForCs.AppendFormat("\r\n" +
                       "<%@ Control Language = \"c#\" AutoEventWireup = \"false\" CodeFile = \"wuc{0}.ascx.cs\" Inherits = \"{1}.Webform.wuc{2}\" TargetSchema = \"http://schemas.microsoft.com/intellisense/ie5\"%>",
                       objViewInfoENEx.TabName, objViewInfoENEx.NameSpace, objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" +
                      "<%@ Control Language = \"c#\" AutoEventWireup = \"false\" CodeBehind = \"wuc{0}.ascx.cs\" Inherits = \"{1}.Webform.wuc{2}\" TargetSchema = \"http://schemas.microsoft.com/intellisense/ie5\"%>",
                      objViewInfoENEx.TabName, objViewInfoENEx.NameSpace, objViewInfoENEx.TabName);
                }
                strCodeForCs.AppendFormat("\r\n" + "<LINK rel = \"stylesheet\" type = \"text/css\" href = \"../../css/tz_base1.css\"/>",
                  objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "<meta name = \"vs_snapToGrid\" content = \"false\">");
                strCodeForCs.Append("\r\n" + "<meta name = \"vs_showGrid\" content = \"true\">");
                strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabwuc{0}\" cellspacing = \"1\" cellpadding = \"1\" style = \"width:600px;\" border = \"0\">",
                  objViewInfoENEx.TabName);
                intZIndex = 101;
                //				intCurrLeft = 10;
                intCurrTop = 50;
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {                    
                    ///如果该字段不是标识递增型就生成控件,否则就不生成;
                    if (objQryRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    strCodeForCs.AppendFormat("\r\n" + "<tr>");
                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" runat = \"server\" Font-Names = \"Verdana\" Font-Size = \"X-Small\" Text = \"{2}\"></asp:{3}>",
                              objQryRegionFldsEx.objCtlType.CtlTypeName,
                              objQryRegionFldsEx.CtrlId(),
                              objQryRegionFldsEx.LabelCaption,
                              objQryRegionFldsEx.objCtlType.CtlTypeName);
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            break;
                        default:

                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\" Font-Size = \"X-Small\" Font-Names = \"Verdana\">{1}</asp:Label>",
                              "lbl" + objQryRegionFldsEx.FldName,
                              objQryRegionFldsEx.LabelCaption);
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" runat = \"server\" Font-Size = \"X-Small\" Font-Names = \"Verdana\"></asp:{2}>",
                              objQryRegionFldsEx.objCtlType.CtlTypeName,
                              objQryRegionFldsEx.CtrlId(),
                              objQryRegionFldsEx.objCtlType.CtlTypeName);
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            break;
                    }
                    strCodeForCs.AppendFormat("\r\n" + "<td>");
                    ///插入验证控件代码;
                    switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"text-warning\" ErrorMessage = \"请输入整型数值!\" ControlToValidate = \"{1}\" ",
                              objQryRegionFldsEx.FldName,
                              objQryRegionFldsEx.CtrlId());
                            strCodeForCs.Append("\r\n" + "Type = \"Integer\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                            strCodeForCs.Append("\r\n" + "</asp:CompareValidator>");
                            break;
                        case "DateTime":
                            strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"text-warning\" ErrorMessage = \"请输入日期型数值!\" ControlToValidate = \"{1}\" ",
                              objQryRegionFldsEx.FldName,
                              objQryRegionFldsEx.CtrlId());
                            strCodeForCs.Append("\r\n" + "Type = \"Date\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                            strCodeForCs.Append("\r\n" + "</asp:CompareValidator>");
                            break;
                        case "double":
                            break;

                        case "float":
                            strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"text-warning\" ErrorMessage = \"请输入浮点型数值!\" ControlToValidate = \"{1}\" ",
                              objQryRegionFldsEx.FldName,
                              objQryRegionFldsEx.CtrlId());
                            strCodeForCs.Append("\r\n" + "Type = \"Double\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                            strCodeForCs.Append("\r\n" + "</asp:CompareValidator>");
                            break;
                    }
                    strCodeForCs.AppendFormat("\r\n" + "</td>");
                    strCodeForCs.AppendFormat("\r\n" + "<td></td>");
                    strCodeForCs.AppendFormat("\r\n" + "</tr>");
                    intZIndex += 1;
                    intCurrTop += 25;
                }

                strCodeForCs.AppendFormat("\r\n" + "</table>");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //检查该文件名的文件夹名,并判断是否存在;
            strFolder = clsString.ParentDir_S(objViewInfoENEx.WebUserCtlFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebUserCtlFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.FolderName_Root, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
                    throw new Exception(strMsg);
                }
            }
            //////UTF8Encoding utf8 = new UTF8Encoding(false);
            clsFile.CreateFileByString(objViewInfoENEx.WebUserCtlFName, strCodeForCs.ToString());
            return strCodeForCs.ToString();
        }

        ///以下均是界面层内容(VIEW)-------
        ///

        /// <summary>
        /// 专门用于显示打印的表控件
        /// </summary>
        /// <returns></returns>
        public string A_GenCtlViewCodeforTab_Disp(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;
            //让用户设置属性;
            string strFolder;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;

            int intZIndex;
            //			int intCurrLeft;  ///控件的左边空;
            int intCurrTop;  ///控件的顶面空;
            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "_Disp.ascx";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlFName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlFName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {
                ///生成插入记录的界面代码;
                ///      strCodeForCs.Append("\r\n" + "///生成与表相关的控件界面层代码");
                if (objViewInfoENEx.ApplicationTypeId2 == "04")
                {
                    strCodeForCs.AppendFormat("\r\n" +
                       "<%@ Control Language = \"c#\" AutoEventWireup = \"false\" CodeFile = \"wuc{0}_Disp.ascx.cs\" Inherits = \"{1}.Webform.wuc{2}_Disp\" TargetSchema = \"http://schemas.microsoft.com/intellisense/ie5\"%>",
                       objViewInfoENEx.TabName, objViewInfoENEx.NameSpace, objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" +
                      "<%@ Control Language = \"c#\" AutoEventWireup = \"false\" CodeBehind = \"wuc{0}_Disp.ascx.cs\" Inherits = \"{1}.Webform.wuc{2}_Disp\" TargetSchema = \"http://schemas.microsoft.com/intellisense/ie5\"%>",
                      objViewInfoENEx.TabName, objViewInfoENEx.NameSpace, objViewInfoENEx.TabName);
                }
                strCodeForCs.AppendFormat("\r\n" + "<LINK rel = \"stylesheet\" type = \"text/css\" href = \"../../css/tz_base1.css\"/>",
                  objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "<meta name = \"vs_snapToGrid\" content = \"false\">");
                strCodeForCs.Append("\r\n" + "<meta name = \"vs_showGrid\" content = \"true\">");
                strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabwuc{0}\" cellspacing = \"1\" cellpadding = \"1\" style = \"width:600px;\" border = \"0\">",
                  objViewInfoENEx.TabName);
                intZIndex = 101;
                //				intCurrLeft = 10;
                intCurrTop = 50;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///如果该字段不是标识递增型就生成控件,否则就不生成;
                    if (objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "<tr>");
                    switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" runat = \"server\" Font-Names = \"Verdana\" Font-Size = \"X-Small\" Text = \"{2}\"></asp:{3}>",
                              objEditRegionFldsEx.objCtlType.CtlTypeName, objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.LabelCaption, objEditRegionFldsEx.objCtlType.CtlTypeName);
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\" Font-Size = \"X-Small\" Font-Names = \"Verdana\">{1}</asp:Label>",
                              "lbl" + objEditRegionFldsEx.FldName,
                              objEditRegionFldsEx.LabelCaption);
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"lbl{0}_Disp\" runat = \"server\" Font-Size = \"X-Small\" Font-Names = \"Verdana\"></asp:Label>",
                              objEditRegionFldsEx.FldName);
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            break;
                    }
                    strCodeForCs.AppendFormat("\r\n" + "<td>");
                    strCodeForCs.AppendFormat("\r\n" + "</td>");
                    strCodeForCs.AppendFormat("\r\n" + "<td></td>");
                    strCodeForCs.AppendFormat("\r\n" + "</tr>");
                    intZIndex += 1;
                    intCurrTop += 25;
                }

                strCodeForCs.AppendFormat("\r\n" + "</table>");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //检查该文件名的文件夹名,并判断是否存在;
            strFolder = clsString.ParentDir_S(objViewInfoENEx.WebUserCtlFName);
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode == true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebUserCtlFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.FolderName_Root, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                {
                    string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
                    throw new Exception(strMsg);
                }
            }
            //////UTF8Encoding utf8 = new UTF8Encoding(false);
            clsFile.CreateFileByString(objViewInfoENEx.WebUserCtlFName, strCodeForCs.ToString());
            return strCodeForCs.ToString();
        }



        public string GenFileCtlViewCodeforTab(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //让用户设置属性;
            //string strFolder;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;

            int intZIndex;
            //			int intCurrLeft;  ///控件的左边空;
            int intCurrTop;  ///控件的顶面空;
            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "OptFile.ascx";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlFName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlFName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {
                ///生成插入记录的界面代码;
                ///      strCodeForCs.Append("\r\n" + "///生成与表相关的控件界面层代码");
                if (objViewInfoENEx.ApplicationTypeId2 == "04")
                {
                    strCodeForCs.AppendFormat("\r\n" +
                       "<%@ Control Language = \"c#\" AutoEventWireup = \"false\" CodeFile = \"wuc{0}.ascx.cs\" Inherits = \"{1}.Webform.wuc{2}\" TargetSchema = \"http://schemas.microsoft.com/intellisense/ie5\"%>",
                       objViewInfoENEx.TabName, objViewInfoENEx.NameSpace, objViewInfoENEx.TabName);
                }
                else
                {

                    strCodeForCs.AppendFormat("\r\n" +
                      "<%@ Control Language = \"c#\" AutoEventWireup = \"false\" CodeBehind = \"wuc{0}.ascx.cs\" Inherits = \"{1}.Webform.wuc{2}\" TargetSchema = \"http://schemas.microsoft.com/intellisense/ie5\"%>",
                      objViewInfoENEx.TabName, objViewInfoENEx.NameSpace, objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "<meta name = \"vs_snapToGrid\" content = \"false\">");
                strCodeForCs.Append("\r\n" + "<meta name = \"vs_showGrid\" content = \"true\">");
                strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabwuc{0}\" cellspacing = \"1\" cellpadding = \"1\" style = \"width:600px;\" border = \"0\">",
                  objViewInfoENEx.TabName);
                intZIndex = 101;
                //				intCurrLeft = 10;
                intCurrTop = 50;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///如果该字段不是标识递增型就生成控件,否则就不生成;
                    if (objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "<tr>");
                    switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" runat = \"server\" Font-Names = \"Verdana\" Font-Size = \"X-Small\" Text = \"{2}\"></asp:{3}>",
                              objEditRegionFldsEx.objCtlType.CtlTypeName, objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.LabelCaption, objEditRegionFldsEx.objCtlType.CtlTypeName);
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            break;
                        default:

                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\" Font-Names = \"Verdana\" Font-Size = \"X-Small\">{1}</asp:Label>",
                              "lbl" + objEditRegionFldsEx.FldName, objEditRegionFldsEx.LabelCaption);
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" runat = \"server\" Font-Names = \"Verdana\" Font-Size = \"X-Small\"></asp:{2}>",
                              objEditRegionFldsEx.objCtlType.CtlTypeName,
                              objEditRegionFldsEx.CtrlId,
                              objEditRegionFldsEx.objCtlType.CtlTypeName);
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            break;
                    }
                    strCodeForCs.AppendFormat("\r\n" + "<td>");
                    ///插入验证控件代码;
                    switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                            strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"text-warning\" ErrorMessage = \"请输入整型数值!\" ControlToValidate = \"{1}\" ",
                              objEditRegionFldsEx.FldName, objEditRegionFldsEx.CtrlId);
                            strCodeForCs.AppendFormat("\r\n" + "Type = \"Integer\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                            strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                            break;
                        case "DateTime":
                            strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"text-warning\" ErrorMessage = \"请输入日期型数值!\" ControlToValidate = \"{1}\" ",
                              objEditRegionFldsEx.FldName, objEditRegionFldsEx.CtrlId);
                            strCodeForCs.AppendFormat("\r\n" + "Type = \"Date\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                            strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                            break;
                        case "double":
                            break;
                        case "float":
                            strCodeForCs.AppendFormat("\r\n" + "<asp:CompareValidator id = \"ComValid_{0}\" runat = \"server\" CssClass = \"text-warning\" ErrorMessage = \"请输入浮点型数值!\" ControlToValidate = \"{1}\" ",
                              objEditRegionFldsEx.FldName, objEditRegionFldsEx.CtrlId);
                            strCodeForCs.AppendFormat("\r\n" + "Type = \"Double\" Operator = \"DataTypeCheck\" EnableClientScript = \"false\">");
                            strCodeForCs.AppendFormat("\r\n" + "</asp:CompareValidator>");
                            break;
                    }
                    strCodeForCs.AppendFormat("\r\n" + "</td>");
                    strCodeForCs.AppendFormat("\r\n" + "<td></td>");
                    strCodeForCs.AppendFormat("\r\n" + "</tr>");
                    intZIndex += 1;
                    intCurrTop += 25;
                }

                strCodeForCs.AppendFormat("\r\n" + "</table>");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        private string GenViewTitle(string strTitle, clsViewInfoENEx objViewInfoENEx)
        {
            if (string.IsNullOrEmpty(objViewInfoENEx.objViewStyleEN.TitleStyleId) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("在界面:{0}中,没有设置标题类型,请检查!", objViewInfoENEx.ViewName);
                throw new Exception(sbMsg.ToString());
            }
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleIdCache(objViewInfoENEx.objViewStyleEN.TitleStyleId);
            if (objTitleStyle == null)
            {
                string strMsg = string.Format("(errid:BlEx000044)标题模式Id:[{0}]没有相应的对象,请检查!(AutoGC6Cs_VWeb_Net2005:GenViewTitle)", objViewInfoENEx.objViewStyleEN.TitleStyleId);
                throw new Exception(strMsg);
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            ///生成Label的代码;
            switch (objTitleStyle.TitleTypeId)
            {
                case "01":
                    strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabTitle\" style = \"z-index: 102; left: 8px; position: absolute; top: 1px\" cellspacing = \"1\" ");
                    strCodeForCs.AppendFormat("\r\n" + "cellpadding = \"1\" width = \"100%\" bgColor = \"{0}\" border = \"0\">",
                      objTitleStyle.BackColor);
                    strCodeForCs.AppendFormat("\r\n" + "<tr>");
                    strCodeForCs.AppendFormat("\r\n" + "<td bgColor = \"{0}\">",
                      objTitleStyle.BackColor);
                    strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"lblViewTile\" runat = \"server\" Font-Size = \"Small\" Font-Names = \"宋体\" ForeColor = \"{1}\" Font-Bold = \"True\">{0}</asp:Label>",
                      strTitle, objTitleStyle.ForeColor);
                    strCodeForCs.AppendFormat("\r\n" + "</td>");
                    strCodeForCs.AppendFormat("\r\n" + "</tr>");
                    strCodeForCs.AppendFormat("\r\n" + "</table>");
                    break;
                case "02":
                   
                    break;
                case "03":
                    strCodeForCs.AppendFormat("\r\n" + "<div style = \"position: relative; width: 648px; height: 37px; left: 0px; top: 0px;\">");
                    strCodeForCs.AppendFormat("\r\n" + "<asp:Label ID = \"lblViewTitle\" runat = \"server\" CssClass = \"h5\" >{0}",
                      strTitle);
                    strCodeForCs.AppendFormat("\r\n" + "</asp:Label>");
                    //如果有查询区域
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "<asp:Label ID = \"lblMsg_List\" runat = \"server\" CssClass = \"text-warning\"  Style = \"z-index: 105;");
                        strCodeForCs.AppendFormat("\r\n" + "left: 54px; position: relative; top: 4px\" Width = \"347px\"></asp:Label>");
                    }
                    strCodeForCs.AppendFormat("\r\n" + "	</div>");
                    break;
            }

            intZIndex += 1;
            return strCodeForCs.ToString();


        }
        private string gfunRadioClick()
        {
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleIdCache(objViewInfoENEx.objViewStyleEN.TitleStyleId);
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            ///生成Label的代码;
            strCodeForCs.Append("\r\n" + "<script language = \"javascript\">");
            strCodeForCs.Append("\r\n" + "<!--");
            strCodeForCs.Append("\r\n" + "function radioClick()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (document.Form1.RadioName != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "for (i = 0; i<document.Form1.RadioName.length; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (document.Form1.RadioName[i].checked == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "document.Form1.rd.value = document.Form1.RadioName[i].value;");
            //document.getElementById("TextBox1").value = document.Form1.rd.value;
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//-->");
            strCodeForCs.Append("\r\n" + "</script>");

            intZIndex += 1;
            return strCodeForCs.ToString();


        }


        /// <summary>
        /// 生成查询区域相关代码
        /// </summary>
        /// <returns></returns>
        public string GenQryRegionCode4Div()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //用来定义正文的标签类型
            clsLabelStyleEN objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleIdCache("0001");
            clsGenCtlStyleEN objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleIdCache("0001");
            clsCheckStyleEN objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleIdCache("0001");
            clsButtonStyleEN objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleIdCache("0001");
            float intDivHeight;
            int intQueryFldNum = 0;

            objBiDimDistribue4Qry = new clsBiDimDistribute();

            objBiDimDistribue4Qry.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribue4Qry.ColWidth = 250;
            objBiDimDistribue4Qry.LineHeight = 30;
            float intDivWidth = objBiDimDistribue4Qry.GetCtlWidth();

            intQueryFldNum = objViewInfoENEx.arrQryRegionFldSet.Count;

            //			intDivHeight = intQueryFldNum * 28 +40;
            intDivHeight = objBiDimDistribue4Qry.GetCtlHeigh(intQueryFldNum) + 40;

            strCodeForCs.AppendFormat("\r\n" + "<div id = \"div{0}\" style = \"position: relative; width: 600px; height: {1}px\"> ",
              objViewInfoENEx.TabName, intDivHeight);
            intCurrTop -= 30;//因为这是在层(div)中
            int intFieldNum = 0;
            objBiDimDistribue4Qry.StartX = (int)intCurrLeft;
            objBiDimDistribue4Qry.StartY = (int)intCurrTop;
            ///生成专门用于查询的界面控件的代码;
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                {
                    case "CheckBox":
                        strCodeForCs.Append("\r\n" + GenCheckBox(objCheckStyle, objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.LabelCaption));
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" +
                          GenCombineCtl(objLabelStyle_Text,
                          "lbl" + objQryRegionFldsEx.FldName + "_q",
                          objQryRegionFldsEx.LabelCaption,
                          objGenCtlStyle,
                          objQryRegionFldsEx.objCtlType.CtlTypeName,
                          objQryRegionFldsEx.CtrlId()));
                        break;
                }
                intZIndex += 1;
                intCurrTop += 28;
                intFieldNum++;
                intCurrLeft = objBiDimDistribue4Qry.GetPosition(intFieldNum).X;
                intCurrTop = objBiDimDistribue4Qry.GetPosition(intFieldNum).Y;

            }
            ///生成查询按钮的代码;
            strCodeForCs.Append("\r\n" + GenButton(objButtonStyle, "btnQuery", "查询", "btnQuery_Click"));
            strCodeForCs.Append("\r\n" + "</div>");

            intCurrTop += 40;
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成查询区域相关代码
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_QryRegionCode4Table()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //用来定义正文的标签类型
            clsLabelStyleEN objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleIdCache("0001");
            clsGenCtlStyleEN objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleIdCache("0001");
            clsCheckStyleEN objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleIdCache("0001");
            clsButtonStyleEN objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleIdCache("0001");
            float intDivHeight;
            int intQueryFldNum = 0;

            objBiDimDistribue4Qry = new clsBiDimDistribute();

            objBiDimDistribue4Qry.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribue4Qry.ColWidth = 250;
            objBiDimDistribue4Qry.LineHeight = 30;
            float intDivWidth = objBiDimDistribue4Qry.GetCtlWidth();

            intQueryFldNum = objViewInfoENEx.arrQryRegionFldSet.Count;

            //			intDivHeight = intQueryFldNum * 28 +40;
            intDivHeight = objBiDimDistribue4Qry.GetCtlHeigh(intQueryFldNum) + 40;


            strCodeForCs.Append("\r\n" + "<table style = \"width: 90%\"> ");

            intCurrTop -= 30;//因为这是在层(div)中
            int intFieldNum = 0;
            objBiDimDistribue4Qry.StartX = (int)intCurrLeft;
            objBiDimDistribue4Qry.StartY = (int)intCurrTop;
            ///生成专门用于查询的界面控件的代码;
            ///
            bool bolIsTrEnd = true;
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                if (intFieldNum % objViewInfoENEx.objViewRegion_Query.ColNum == 0)
                {
                    strCodeForCs.Append("\r\n" + "<tr>");
                    bolIsTrEnd = false;
                }

                switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                {
                    case "CheckBox":
                        strCodeForCs.Append("\r\n" + GenCheckBoxNoPosition(objCheckStyle, objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.LabelCaption));
                        break;
                    default:
                        string strTemp = Gen_Mvc_CombineCtlWithFor(objLabelStyle_Text,
                            objQryRegionFldsEx.FldName,
                          "lbl" + objQryRegionFldsEx.FldName + "_q",
                          objQryRegionFldsEx.LabelCaption,
                          objGenCtlStyle,
                          objQryRegionFldsEx.objCtlType.CtlTypeName,
                          objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.DsTabId, objQryRegionFldsEx.DdlItemsOptionId);
                        strCodeForCs.Append("\r\n" + strTemp);
                        break;
                }

                intZIndex += 1;
                intCurrTop += 28;
                intFieldNum++;
                if (intFieldNum % objViewInfoENEx.objViewRegion_Query.ColNum == 0)
                {
                    strCodeForCs.Append("\r\n" + "</tr>");
                    bolIsTrEnd = true;
                }
                intCurrLeft = objBiDimDistribue4Qry.GetPosition(intFieldNum).X;
                intCurrTop = objBiDimDistribue4Qry.GetPosition(intFieldNum).Y;

            }
            ///生成查询按钮的代码;
            ///
            if (bolIsTrEnd == true)
            {
                strCodeForCs.Append("\r\n" + "<tr>");
                bolIsTrEnd = false;
            }
            strCodeForCs.Append("\r\n" + "<td>");
            strCodeForCs.Append("\r\n" + Gen_Mvc_ButtonInForm(objButtonStyle, "btnQuery", "查询"));
            strCodeForCs.Append("\r\n" + "</td>");
            strCodeForCs.Append("\r\n" + "<td>");
            strCodeForCs.Append("\r\n" + "<a href = \"javascript:void(0);\" class=\"easyui-linkbutton\" data-options=\"iconCls:'icon-clear' \" onclick=\"resetSearch()\">清空</a>");
            strCodeForCs.Append("\r\n" + "</td>");

            strCodeForCs.Append("\r\n" + "</tr>");
            strCodeForCs.Append("\r\n" + "</table>");

            intCurrTop += 40;
            return strCodeForCs.ToString();
        }


        public bool DispQryRegionCtrl()
        {

            return true;
        }
        public string ClsName4WucTabName4Gv()
        {
            string strClsName = string.Format("wuc{0}4Gv", objViewInfoENEx.TabName_Out);
            return strClsName;
        }
      

        /// <summary>
        /// 功能:单表的查询、修改、插入、删除
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            this.objViewInfoENEx = objViewInfoENEx;
            //让用户设置属性;
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
          
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);

            objViewInfoENEx.WebFormName = string.Format("{0}CRUDSpa", objViewInfoENEx.TabName);
            objViewInfoENEx.WebFormFName = string.Format("{0}{1}.cshtml",
                objViewInfoENEx.FolderName, objViewInfoENEx.WebFormName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            
            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            if (objCodeType.IsDirByTabName == false)
            {
                strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);
            }
            else
            {
                strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objViewInfoENEx.TabName, objViewInfoENEx.WebFormFName);
            }
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                       clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                       objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);
                        
            strCodeForCs.AppendFormat("\r\n" + "@using {0}.Entity", objProjectsENEx.PrjDomain);
            strCodeForCs.AppendFormat("\r\n" + "@using {0}Mvc.HtmlHelpers", objProjectsENEx.PrjDomain);
            strCodeForCs.AppendFormat("\r\n" + "@model {0}Mvc.Models.ViewModel4{1}", objProjectsENEx.PrjDomain, objMainPrjTab.TabName);
            strCodeForCs.Append("\r\n" + "@{");
            strCodeForCs.Append("\r\n" + "    Layout = \"~/Views/Shared/TZ_Layout.cshtml\";");
            strCodeForCs.AppendFormat("\r\n" + "    ViewBag.Title = \"{0}\";", objViewInfoENEx.ViewCnName);
            strCodeForCs.Append("\r\n" + "    string controller = ViewContext.RouteData.Route.GetRouteData(this.Context).Values[\"controller\"].ToString();");
            strCodeForCs.Append("\r\n" + "    string action = ViewContext.RouteData.Values[\"action\"].ToString();");
            strCodeForCs.Append("\r\n" + "    string btnSaveName = \"\";");
            strCodeForCs.Append("\r\n" + "    if (ViewBag.Operate == \"Add\" )");
            strCodeForCs.Append("\r\n" + "    {");
            strCodeForCs.Append("\r\n" + "        btnSaveName = \"确认添加\";");
            strCodeForCs.Append("\r\n" + "    }");
            strCodeForCs.Append("\r\n" + "    else if (ViewBag.Operate == \"Update\" )");
            strCodeForCs.Append("\r\n" + "    {");
            strCodeForCs.Append("\r\n" + "        btnSaveName = \"确认修改\";");
            strCodeForCs.Append("\r\n" + "    }");
            strCodeForCs.Append("\r\n" + "AjaxOptions ajaxOpts = new AjaxOptions");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "UpdateTargetId = \"divLstTab_{0}\"",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "<h2>{0}单页面(Spa)</h2>", objViewInfoENEx.ViewCnName);
            strCodeForCs.Append("\r\n" + "<h3>@ViewBag.Message</h3>");
            strCodeForCs.Append("\r\n" + "<div>");

            try
            {
                clsTzGCScript objTzGCScript = new clsTzGCScript(objViewInfoENEx);
                string strTemp = "";
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }

                    try
                    {
                        if (objvFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                        {
                            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId4View(objvFunction4GeneCodeEN.FuncId4GC,
                                 objViewInfoENEx.ViewId, objViewInfoENEx.PrjDataBaseId, objViewInfoENEx.PrjId);
                        }
                        else
                        {
                            strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.", strFuncName, objException.Message);
                        throw new Exception(strMsg);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }
                strCodeForCs.Append("\r\n" + "</div>");

                strCodeForCs.Append("\r\n" + "<script type=\"text/javascript\">");
                strCodeForCs.Append("\r\n" + "    var strOperate = \"@ViewBag.Operate\";");
                strCodeForCs.Append("\r\n" + "    $(function () {");
                strCodeForCs.Append("\r\n" + "        //    searchExamType();");
                strCodeForCs.Append("\r\n" + "    });");
                strCodeForCs.Append("\r\n" + "    //添加方法");
                strCodeForCs.Append("\r\n" + "    function save() {");
                strCodeForCs.Append("\r\n" + "        $('#add_Form').form('submit', {");
                strCodeForCs.Append("\r\n" + "            url: 'SaveExamType',");
                strCodeForCs.Append("\r\n" + "            onSubmit: function () {");
                strCodeForCs.Append("\r\n" + "                var valid = $('#add_Form').form('validate');");
                strCodeForCs.Append("\r\n" + "                if (valid == false) {");
                strCodeForCs.Append("\r\n" + "                    return false;");
                strCodeForCs.Append("\r\n" + "                }");
                strCodeForCs.Append("\r\n" + "                return true;");
                strCodeForCs.Append("\r\n" + "            },");
                strCodeForCs.Append("\r\n" + "            success: function (data) {");
                strCodeForCs.Append("\r\n" + "                data = eval('(' + data + ')');");
                strCodeForCs.Append("\r\n" + "                if (data.Success) {");
                strCodeForCs.Append("\r\n" + "                    $('#add_dialog').dialog('close');");
                strCodeForCs.Append("\r\n" + "                    $('#tbl').datagrid('reload');");
                strCodeForCs.Append("\r\n" + "                } else {");
                strCodeForCs.Append("\r\n" + "                    $.messager.alert(\"友情提示\", data.Message);");
                strCodeForCs.Append("\r\n" + "                }");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "        });");
                strCodeForCs.Append("\r\n" + "    }");


                strCodeForCs.Append("\r\n" + "    function delExamType(strExamTypeId) {");
                strCodeForCs.Append("\r\n" + "        $.messager.confirm('确认', '是否真的删除?', function (r) {");
                strCodeForCs.Append("\r\n" + "            if (r) {");
                strCodeForCs.Append("\r\n" + "                $.ajax({");
                strCodeForCs.Append("\r\n" + "                    url: \"DelRecord\",");
                strCodeForCs.Append("\r\n" + "                    cache: false,");
                strCodeForCs.Append("\r\n" + "                    async: false,");
                strCodeForCs.Append("\r\n" + "                    type: 'post',");
                strCodeForCs.Append("\r\n" + "                    dataType: \"json\",");
                strCodeForCs.Append("\r\n" + "                    data: { ExamTypeId: strExamTypeId },");
                strCodeForCs.Append("\r\n" + "                    success: function (text) {");
                strCodeForCs.Append("\r\n" + "                        if (text == '1') {");
                strCodeForCs.Append("\r\n" + "                            $('#tbl').datagrid('reload');");
                strCodeForCs.Append("\r\n" + "                            $.messager.alert(\"友情提示\", \"删除成功\");");
                strCodeForCs.Append("\r\n" + "                        }");
                strCodeForCs.Append("\r\n" + "                        else {");
                strCodeForCs.Append("\r\n" + "                            $.messager.alert(\"删除失败\");");
                strCodeForCs.Append("\r\n" + "                        }");
                strCodeForCs.Append("\r\n" + "                    }");
                strCodeForCs.Append("\r\n" + "                });");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "        });");
                strCodeForCs.Append("\r\n" + "    }");
                strCodeForCs.Append("\r\n" + "    //查询清空");
                strCodeForCs.Append("\r\n" + "    function resetSearch() {");
                strCodeForCs.Append("\r\n" + "        $('#search_Form').form('clear');");
                strCodeForCs.Append("\r\n" + "    }");
                strCodeForCs.Append("\r\n" + "    function CheckAllHandler() {");
                strCodeForCs.Append("\r\n" + "        alert('CheckAllHandler');");
                strCodeForCs.Append("\r\n" + "    }");
                strCodeForCs.Append("\r\n" + "    //删除多条记录");
                strCodeForCs.AppendFormat("\r\n" + "    function Delete{0}s() {{",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "        if ($(\".checkboxes:checked\").length == 0) {");
                strCodeForCs.Append("\r\n" + "            alert(\"请选择删除的数据行!\");");
                strCodeForCs.Append("\r\n" + "            return;");
                strCodeForCs.Append("\r\n" + "        }");
                strCodeForCs.Append("\r\n" + "        var objects = new Array();");
                strCodeForCs.Append("\r\n" + "        var obj = null;");
                strCodeForCs.Append("\r\n" + "        $('.table').each(function () {");
                strCodeForCs.Append("\r\n" + "            var objtr = $(this);");
                strCodeForCs.Append("\r\n" + "            if (objtr.find(\".checkboxes\").prop('checked')) {");
                strCodeForCs.Append("\r\n" + "                obj = new Object();");
                strCodeForCs.Append("\r\n" + "                obj.Module_nbr = objtr.find(\".checkboxes\").val();");
                strCodeForCs.Append("\r\n" + "                objects.push(obj);");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "        })");
                strCodeForCs.Append("\r\n" + "        var data = JSON.stringify(objects);");
                strCodeForCs.Append("\r\n" + "        alert(data);");
                strCodeForCs.Append("\r\n" + "    }");
                strCodeForCs.Append("\r\n" + "    function ShowEditDialog() {");
                strCodeForCs.Append("\r\n" + "        //alert('complete');");
                strCodeForCs.AppendFormat("\r\n" + "        $('#divEdit_{0}').modal('show');",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "    }");
                strCodeForCs.Append("\r\n" + "    function GetReturnStr() {");
                strCodeForCs.Append("\r\n" + "        //alert('complete');");
                strCodeForCs.Append("\r\n" + "        //  $('#myModal4Edit').modal('show');");
                strCodeForCs.AppendFormat("\r\n" + "        var {0} = \"ABC\";", objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "        $.post(\"GetReturnStr\", {{ {0}: {1} }}, function (data) {{ alert(data); }});",
                    objKeyField.FldName, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "    }");
                strCodeForCs.Append("\r\n" + "    if (strOperate == \"Add\") {");
                strCodeForCs.Append("\r\n" + "        ShowEditDialog();");
                strCodeForCs.Append("\r\n" + "    }");
                strCodeForCs.Append("\r\n" + "    else if (strOperate == \"Update\") {");
                strCodeForCs.Append("\r\n" + "        ShowEditDialog();");
                strCodeForCs.Append("\r\n" + "    }");
                strCodeForCs.Append("\r\n" + "    else {");
                strCodeForCs.Append("\r\n" + "    }");
                strCodeForCs.Append("\r\n" + "    var EditError = \"@ViewBag.EditError\";");
                strCodeForCs.Append("\r\n" + "    if (EditError == \"true\") {");
                strCodeForCs.Append("\r\n" + "        ShowEditDialog();");
                strCodeForCs.Append("\r\n" + "    }");

                strCodeForCs.Append("\r\n" + "//通过弹出窗口来添加记录");
                strCodeForCs.Append("\r\n" + "function AddRec() {");
                strCodeForCs.Append("\r\n" + "    $('#btnSave').val('确认添加');");
                strCodeForCs.Append("\r\n" + "    $('#Operate').val('Add');");
                strCodeForCs.AppendFormat("\r\n" + "    $('#{0}').attr(\"readonly\", false)", FldName4Key);
                strCodeForCs.Append("\r\n" + "    ShowEditDialog(); ");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "//通过弹出窗口来修改记录");
                strCodeForCs.Append("\r\n" + "function UpdateRec(data) {");
                strCodeForCs.Append("\r\n" + "    $('#btnSave').val('确认修改');");
                strCodeForCs.Append("\r\n" + "    $('#Operate').val('Update');");
                strCodeForCs.Append("\r\n" + "//把传来的对象的属性赋给编辑控件. ");

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    //如果该字段不是标识递增型就生成控件,否则就不生成;                  
                    string strFldName = objEditRegionFldsEx.FldName;
                    string strCaption = objEditRegionFldsEx.LabelCaption;
                    strCodeForCs.AppendFormat("\r\n" + "    $('#{1}').val(data.{1});  //针对字段:[{0}({1})]; ", strCaption, strFldName);
                }
                strCodeForCs.Append("\r\n" + "    ShowEditDialog(); ");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "</script>");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            
            }

            return strCodeForCs.ToString();
        }


        public string A_GenMvcViewLstAjax(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            this.objViewInfoENEx = objViewInfoENEx;
            //让用户设置属性;
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
          
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);

            objViewInfoENEx.WebFormName = string.Format("{0}LstAjax", objViewInfoENEx.TabName);
            objViewInfoENEx.WebFormFName = string.Format("{0}{1}.cshtml",
                objViewInfoENEx.FolderName, objViewInfoENEx.WebFormName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            
            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            if (objCodeType.IsDirByTabName == false)
            {
                strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);
            }
            else
            {
                strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objViewInfoENEx.TabName, objViewInfoENEx.WebFormFName);
            }
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                       clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                       objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);
            

            strCodeForCs.AppendFormat("\r\n" + "@using {0}.Entity", objProjectsENEx.PrjDomain);
            strCodeForCs.AppendFormat("\r\n" + "@using {0}Mvc.HtmlHelpers", objProjectsENEx.PrjDomain);
            strCodeForCs.AppendFormat("\r\n" + "@model {0}Mvc.Models.ViewModel4{1}", objProjectsENEx.PrjDomain, objMainPrjTab.TabName);
            try
            {
                clsTzGCScript objTzGCScript = new clsTzGCScript(objViewInfoENEx);
                string strTemp = "";
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }

                    try
                    {
                        if (objvFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                        {
                            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId4View(objvFunction4GeneCodeEN.FuncId4GC,
                                 objViewInfoENEx.ViewId, objViewInfoENEx.PrjDataBaseId, objViewInfoENEx.PrjId);
                        }
                        else
                        {
                            strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.", strFuncName, objException.Message);
                        throw new Exception(strMsg);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }
             
          
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
          
            }

            return strCodeForCs.ToString();
        }
             
        /// <summary>
        /// 功能:生成查询区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_QueryRegion()
        {

          
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                ///生成插入记录的界面代码;
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的查询区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "<div id=\"user_accordion\" class=\"easyui-accordion\" style=\"width:100%\" data-options=\"multiple:true\">");
                strCodeForCs.Append("\r\n" + "   <div title=\"查询选项\" style=\"padding:10px;\" data-options=\"collapsed:false,collapsible:true\">");
                strCodeForCs.Append("\r\n" + "     <div style=\"width:98%;margin:auto\">");
                strCodeForCs.AppendFormat("\r\n" + "     @using (Html.BeginForm(\"{1}_Query\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "     {");
                string strTemp = Gen_MvcView_QryRegionCode4Table();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);

                strCodeForCs.Append("\r\n" + "     }");
                strCodeForCs.Append("\r\n" + "     </div>");
                strCodeForCs.Append("\r\n" + "   </div>");
                strCodeForCs.Append("\r\n" + "</div>");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 功能:生成查询区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_QueryRegionAjax()
        {

          
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                ///生成插入记录的界面代码;
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的查询区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "<div id=\"user_accordion\" class=\"easyui-accordion\" style=\"width:100%\" data-options=\"multiple:true\">");
                strCodeForCs.Append("\r\n" + "   <div title=\"查询选项\" style=\"padding:10px;\" data-options=\"collapsed:false,collapsible:true\">");
                strCodeForCs.Append("\r\n" + "     <div style=\"width:98%;margin:auto\">");
                strCodeForCs.AppendFormat("\r\n" + "     @using (Ajax.BeginForm(\"QueryAjax\", \"{0}\", ajaxOpts))",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "     {");
                string strTemp = Gen_MvcView_QryRegionCode4Table();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);

                strCodeForCs.Append("\r\n" + "     }");
                strCodeForCs.Append("\r\n" + "     </div>");
                strCodeForCs.Append("\r\n" + "   </div>");
                strCodeForCs.Append("\r\n" + "</div>");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }



        /// <summary>
        /// 功能:生成查询区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_QueryRegionSpa()
        {

          
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                ///生成插入记录的界面代码;
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的查询区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "<div id=\"user_accordion\" class=\"easyui-accordion\" style=\"width:100%\" data-options=\"multiple:true\">");
                strCodeForCs.Append("\r\n" + "   <div title=\"查询选项\" style=\"padding:10px;\" data-options=\"collapsed:false,collapsible:true\">");
                strCodeForCs.Append("\r\n" + "     <div style=\"width:98%;margin:auto\">");
                strCodeForCs.AppendFormat("\r\n" + "     @using (Ajax.BeginForm(\"QueryAjax\", \"{0}\", ajaxOpts))",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "     {");
                string strTemp = Gen_MvcView_QryRegionCode4Table();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);

                strCodeForCs.Append("\r\n" + "     }");
                strCodeForCs.Append("\r\n" + "     </div>");
                strCodeForCs.Append("\r\n" + "   </div>");
                strCodeForCs.Append("\r\n" + "</div>");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 功能:生成编辑区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_EditRegion()
        {

            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                ///生成插入记录的界面代码;
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的编辑区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "<div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "    <div class=\"modal-dialog modal-sm\">");
                strCodeForCs.Append("\r\n" + "        <div class=\"modal-content text-left\" style=\"width: 600px; \">");
                strCodeForCs.Append("\r\n" + "            <div class=\"modal-header\">");
                strCodeForCs.Append("\r\n" + "                <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">×</span></button>");
                strCodeForCs.AppendFormat("\r\n" + "                <h4 class=\"modal-title\" id=\"lblDialogTitle_{1}\">{0}编辑</h4>", 
                    objViewInfoENEx.ViewCnName,
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "                @Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })");
                strCodeForCs.Append("\r\n" + "            </div>");


                strCodeForCs.AppendFormat("\r\n" + "      @using (Html.BeginForm(\"Save\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "                if (ViewBag.Operate == \"Add\")");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                     @Html.Hidden(\"Operate\", \"Add\")");
                strCodeForCs.Append("\r\n" + "                 }");
                strCodeForCs.Append("\r\n" + "                 else");
                strCodeForCs.Append("\r\n" + "                 {");
                strCodeForCs.Append("\r\n" + "                      @Html.Hidden(\"Operate\", \"Update\")");
                if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "@Html.Hidden(\"{0}\", \"@Model.{0}\")", FldName4Key);
                }
                strCodeForCs.Append("\r\n" + "                 }");


                strCodeForCs.Append("\r\n" + "                @Html.AntiForgeryToken()");
                strCodeForCs.Append("\r\n" + "                <div class=\"modal-body\">");
                strCodeForCs.Append("\r\n" + "                    <div class=\"modal-footer\">");
                string strTemp = Gen_MvcView_CtlViewCodeforTab();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);
                strCodeForCs.Append("\r\n" + "                        <div class=\"form-group\">");
                strCodeForCs.Append("\r\n" + "                            <div class=\"col-md-offset-2 col-md-10\">");
                strCodeForCs.Append("\r\n" + "                                <input type=\"submit\" value=\"@btnSaveName\" class=\"btn btn-default\" name=\"btnSave\" id=\"btnSave\" />");
                strCodeForCs.Append("\r\n" + "                                <button class=\"btn btn-default\" data-dismiss=\"modal\">Cancel</button>");
                strCodeForCs.Append("\r\n" + "                            </div>");
                strCodeForCs.Append("\r\n" + "                        </div>");
                strCodeForCs.Append("\r\n" + "                    </div>");
                strCodeForCs.Append("\r\n" + "                </div>");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "        </div>");
                strCodeForCs.Append("\r\n" + "    </div>");
                strCodeForCs.Append("\r\n" + "</div>");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }


      

        /// <summary>
        /// 功能:生成编辑区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_EditRegionSpa()
        {

            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                ///生成插入记录的界面代码;
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的编辑区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "<div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "    <div class=\"modal-dialog modal-sm\">");
                strCodeForCs.Append("\r\n" + "        <div class=\"modal-content text-left\" style=\"width: 600px; \">");
                strCodeForCs.Append("\r\n" + "            <div class=\"modal-header\">");
                strCodeForCs.Append("\r\n" + "                <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">×</span></button>");
                strCodeForCs.AppendFormat("\r\n" + "                <h4 class=\"modal-title\" id=\"lblDialogTitle_{1}\">{0}编辑</h4>", 
                    objViewInfoENEx.ViewCnName,
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "                @Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })");
                strCodeForCs.Append("\r\n" + "            </div>");


                strCodeForCs.AppendFormat("\r\n" + "      @using (Html.BeginForm(\"Save\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "                if (ViewBag.Operate == \"Add\")");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                     @Html.Hidden(\"Operate\", \"Add\")");
                strCodeForCs.Append("\r\n" + "                 }");
                strCodeForCs.Append("\r\n" + "                 else");
                strCodeForCs.Append("\r\n" + "                 {");
                strCodeForCs.Append("\r\n" + "                      @Html.Hidden(\"Operate\", \"Update\")");
                if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "@Html.Hidden(\"{0}\", @Model.{0})", FldName4Key);
                }
                else
                {
                    //strCodeForCs.AppendFormat("\r\n" + "@Html.Hidden(\"{0}\", @Model.{0})", FldName4Key);
                }
                strCodeForCs.Append("\r\n" + "                 }");


                strCodeForCs.Append("\r\n" + "                @Html.AntiForgeryToken()");
                strCodeForCs.Append("\r\n" + "                <div class=\"modal-body\">");
                strCodeForCs.Append("\r\n" + "                    <div class=\"modal-footer\">");
                string strTemp = Gen_MvcView_CtlViewCodeforTab();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);
                strCodeForCs.Append("\r\n" + "                        <div class=\"form-group\">");
                strCodeForCs.Append("\r\n" + "                            <div class=\"col-md-offset-2 col-md-10\">");
                strCodeForCs.Append("\r\n" + "                                <input type=\"submit\" value=\"@btnSaveName\" class=\"btn btn-default\" name=\"btnSave\" id=\"btnSave\" />");
                strCodeForCs.Append("\r\n" + "                                <button class=\"btn btn-default\" data-dismiss=\"modal\">Cancel</button>");
                strCodeForCs.Append("\r\n" + "                            </div>");
                strCodeForCs.Append("\r\n" + "                        </div>");
                strCodeForCs.Append("\r\n" + "                    </div>");
                strCodeForCs.Append("\r\n" + "                </div>");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "        </div>");
                strCodeForCs.Append("\r\n" + "    </div>");
                strCodeForCs.Append("\r\n" + "</div>");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 功能:生成列表区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_ListRegion()
        {

            if (objViewInfoENEx.arrDGRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有列表区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {          
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的列表区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "    <div class=\"panel panel-default\">");
                strCodeForCs.AppendFormat("\r\n" + "        @using (Html.BeginForm(\"Deletes\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "        {");
                strCodeForCs.Append("\r\n" + "            <div class=\"panel-heading\">");
                strCodeForCs.AppendFormat("\r\n" + "                <h3>{0}列表</h3>", objViewInfoENEx.TabCnName);
                strCodeForCs.Append("\r\n" + "            </div>");
                strCodeForCs.Append("\r\n" + "            <div class=\"panel-footer\">");
                strCodeForCs.Append("\r\n" + "                @Html.ActionLink(\"添加\", \"Create\", null,");
                strCodeForCs.Append("\r\n" + "             new { @class = \"btn btn-default\" })");
                strCodeForCs.Append("\r\n" + "                @*@Html.ActionLink(\"删除多条记录\", \"DelRecords\", null,");
                strCodeForCs.Append("\r\n" + "                    new { @class = \"btn btn-default\" })*@");
                strCodeForCs.Append("\r\n" + "                <input type=\"submit\"");
                strCodeForCs.Append("\r\n" + "                       class=\"btn btn-default\"");
                strCodeForCs.Append("\r\n" + "                       value=\"删除多条记录\" />");
                strCodeForCs.Append("\r\n" + "            </div>");
                strCodeForCs.Append("\r\n" + "            <div class=\"panel-body\">");
                string strTemp = Gen_Mvc_DataGrid();
                strCodeForCs.Append("\r\n" + strTemp);
                strCodeForCs.Append("\r\n" + "    </div>");
                strCodeForCs.Append("\r\n" + "        }");
                strCodeForCs.Append("\r\n" + "    </div>");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 功能:生成列表区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_PartialListAjax()
        {

            if (objViewInfoENEx.arrDGRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有列表区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc ViewLstAjax 的列表区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                
                string strTemp = Gen_Mvc_DataGridAjax();
                strCodeForCs.Append("\r\n" + strTemp);
                             
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 功能:生成列表区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_PartialListSpa()
        {

            if (objViewInfoENEx.arrDGRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有列表区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc ViewLstAjax 的列表区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());

                string strTemp = Gen_Mvc_DataGridAjax();
                strCodeForCs.Append("\r\n" + strTemp);

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 功能:生成列表区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_ListRegionAjax()
        {

            if (objViewInfoENEx.arrDGRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有列表区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的列表区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "    <div class=\"panel panel-default\">");
                strCodeForCs.AppendFormat("\r\n" + "        @using (Html.BeginForm(\"Deletes\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "        {");
                strCodeForCs.Append("\r\n" + "            <div class=\"panel-heading\">");
                strCodeForCs.AppendFormat("\r\n" + "                <h3>{0}列表</h3>", objViewInfoENEx.TabCnName);
                strCodeForCs.Append("\r\n" + "            </div>");
                            
                strCodeForCs.Append("\r\n" + "            <div class=\"panel-footer\">");

                strCodeForCs.Append("\r\n" + "<input type = \"button\" class=\"btn btn-default\" value=\"添加记录\" onclick=\"AddRec()\" />");
                            
                strCodeForCs.Append("\r\n" + "                @*@Html.ActionLink(\"删除多条记录\", \"DelRecords\", null,");
                strCodeForCs.Append("\r\n" + "                    new { @class = \"btn btn-default\" })*@");
                strCodeForCs.Append("\r\n" + "                <input type=\"submit\"");
                strCodeForCs.Append("\r\n" + "                       class=\"btn btn-default\"");
                strCodeForCs.Append("\r\n" + "                       value=\"删除多条记录\" />");
                strCodeForCs.Append("\r\n" + "            </div>");
                strCodeForCs.Append("\r\n" + "            <div class=\"panel-body\">");
                strCodeForCs.AppendFormat("\r\n" + "<div id = \"divLstTab_{0}\">",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "@Html.Action(\"QueryAjax\")",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "</div>");
                strCodeForCs.Append("\r\n" + "</div>");


                strCodeForCs.Append("\r\n" + "        }");
                strCodeForCs.Append("\r\n" + "    </div>");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }



        /// <summary>
        /// 功能:生成列表区域
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_ListRegionSpa()
        {

            if (objViewInfoENEx.arrDGRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有列表区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            try
            {
                strCodeForCs.AppendFormat("\r\n" + "@* 生成的针对Mvc View 的列表区域 *@");
                strCodeForCs.AppendFormat("\r\n" + "@* 生成函数:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "    <div class=\"panel panel-default\">");
                strCodeForCs.AppendFormat("\r\n" + "        @using (Html.BeginForm(\"Deletes\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "        {");
                strCodeForCs.Append("\r\n" + "            <div class=\"panel-heading\">");
                strCodeForCs.AppendFormat("\r\n" + "                <h3>{0}列表</h3>", objViewInfoENEx.TabCnName);
                strCodeForCs.Append("\r\n" + "            </div>");

                strCodeForCs.Append("\r\n" + "            <div class=\"panel-footer\">");

                strCodeForCs.Append("\r\n" + "<input type = \"button\" class=\"btn btn-default\" value=\"添加记录\" onclick=\"AddRec()\" />");

                strCodeForCs.Append("\r\n" + "                @*@Html.ActionLink(\"删除多条记录\", \"DelRecords\", null,");
                strCodeForCs.Append("\r\n" + "                    new { @class = \"btn btn-default\" })*@");
                strCodeForCs.Append("\r\n" + "                <input type=\"submit\"");
                strCodeForCs.Append("\r\n" + "                       class=\"btn btn-default\"");
                strCodeForCs.Append("\r\n" + "                       value=\"删除多条记录\" />");
                strCodeForCs.Append("\r\n" + "            </div>");
                strCodeForCs.Append("\r\n" + "            <div class=\"panel-body\">");
                strCodeForCs.AppendFormat("\r\n" + "<div id = \"divLstTab_{0}\">",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "@Html.Action(\"QueryAjax\")",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "</div>");
                strCodeForCs.Append("\r\n" + "</div>");


                strCodeForCs.Append("\r\n" + "        }");
                strCodeForCs.Append("\r\n" + "    </div>");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 功能:单表的查询
        /// </summary>
        /// <returns></returns>
        public string GenInsRecViewCode(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //让用户设置属性;
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
           
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);

            objViewInfoENEx.WebFormName = "wfm" + objViewInfoENEx.TabName + "B_I";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "wfm" + objViewInfoENEx.TabName + "B_I.aspx";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {
                ///生成插入记录的界面代码;
                ///      strCodeForCs.Append("///生成查询、修改、删除、添加记录的界面代码(利用控件)");
                strCodeForCs.AppendFormat("\r\n" + "<%@ Register TagPrefix = \"uc1\" TagName = \"wuc{0}B\" Src = \"wuc{1}B.ascx\" %>",
                  objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                if (objViewInfoENEx.ApplicationTypeId2 == "04")
                {
                    strCodeForCs.AppendFormat("\r\n" + "<%@ Page language = \"c#\" AutoEventWireup = \"true\" CodeFile = \"{0}.aspx.cs\" Inherits = \"{1}.Webform.{2}\" %>",
                       objViewInfoENEx.WebFormName, objViewInfoENEx.NameSpace, objViewInfoENEx.WebFormName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "<%@ Page language = \"c#\" AutoEventWireup = \"true\" CodeBehind = \"{0}.aspx.cs\" Inherits = \"{1}.Webform.{2}\" %>",
                      objViewInfoENEx.WebFormName, objViewInfoENEx.NameSpace, objViewInfoENEx.WebFormName);
                }
                strCodeForCs.Append("\r\n" + "<!DOCTYPE html>");
                strCodeForCs.Append("\r\n" + "<html xmlns = \"http://www.w3.org/1999/xhtml\">");
                strCodeForCs.Append("\r\n" + "<head runat = \"server\">");
                strCodeForCs.Append("\r\n" + "<meta http-equiv = \"Content-Type\" content = \"text/html; charset = utf-8\" />");
                strCodeForCs.AppendFormat("\r\n" + "<title>{0}的维护</title>", objViewInfoENEx.ViewCnName);
                //strCodeForCs.AppendFormat("\r\n" + "<link rel = \"stylesheet\" type = \"text/css\" href = \"../../css/taishweb2.css\"/>",
                //  objViewInfoENEx.NameSpace);
                strCodeForCs.AppendFormat("\r\n" + "<link rel = \"stylesheet\" type = \"text/css\" href = \"../../css/tz_base1.css\"/>",
                    objViewInfoENEx.NameSpace);
                strCodeForCs.AppendFormat("\r\n" + "<script type = \"text/javascript\" src = \"../../JS/tzPubFun.js\"></script>");
                if (objDGStyleEx.IsRadio == true)
                {
                    strCodeForCs.Append("\r\n" + gfunRadioClick());
                }
                strCodeForCs.Append("\r\n" + "</head>");


                strCodeForCs.Append("\r\n" + "<body>");
                strCodeForCs.Append("\r\n" + "<form id = \"form1\" runat = \"server\">");
                intZIndex = 101;
                intCurrLeft = 10;
                intCurrTop = 10;

                //用来定义正文的标签类型
                clsLabelStyleEN objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleIdCache("0001");
                //用来定义1号标题的标签类型
                clsLabelStyleEN objLabelStyle_T1 = clsLabelStyleBL.GetObjByLabelStyleIdCache("0003");
                clsGenCtlStyleEN objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleIdCache("0001");
                clsCheckStyleEN objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleIdCache("0001");
                clsButtonStyleEN objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleIdCache("0001");
                //0003:QUDI模式


                strCodeForCs.Append("\r\n" + "<div id = \"tabLayout\" class = \"tab_layout\" ");
                strCodeForCs.Append("\r\n" + "runat = \"server\">");

                strCodeForCs.Append("\r\n" + "<%-- 标题层 --%>");
                strCodeForCs.AppendFormat("\r\n" + GenViewTitle(string.Format("{0}", objViewInfoENEx.ViewCnName), objViewInfoENEx));
                //strCodeForCs.Append("\r\n" + "</td>");
                //strCodeForCs.Append("\r\n" + "</tr>");
                //生成查询区域代码-------------------------------
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery == true)
                {
                    intZIndex += 1;
                    intCurrTop += 25;
                    intCurrLeft = 10;



                    ///生成专门用于查询的界面控件的代码;
                    strCodeForCs.Append("\r\n" + "<%-- 查询层 --%>");
                    strCodeForCs.Append("\r\n" + Gen_MvcView_QryRegionCode4Table());
                    intCurrTop += 40;
                    //strCodeForCs.Append("\r\n" + "</td>");
                    //strCodeForCs.Append("\r\n" + "<td></td>");
                    //strCodeForCs.Append("\r\n" + "<td></td>");
                    //strCodeForCs.Append("\r\n" + "</tr>");

                    //strCodeForCs.Append("\r\n" + "<tr>");
                    //strCodeForCs.Append("\r\n" + "<td></td>");
                    //strCodeForCs.Append("\r\n" + "<td></td>");
                    //strCodeForCs.Append("\r\n" + "<td></td>");
                    //strCodeForCs.Append("\r\n" + "</tr>");
                    //strCodeForCs.Append("\r\n" + "<tr>");
                    //strCodeForCs.Append("\r\n" + "<td>");

                    //生成GridView的代码;
                    ///
                    //				objViewInfoENEx.objViewRegion_List.IsHaveUpdBtn() = true;
                    //				objViewInfoENEx.objViewRegion_List.IsHaveDelBtn() = true;
                    strCodeForCs.Append("\r\n" + "<%-- 列表层 --%>");
                    strCodeForCs.Append("\r\n" + GenFunctionRegion(objViewInfoENEx.objViewRegion_List, objViewInfoENEx));
                    strCodeForCs.Append("\r\n" + GenGridViewNew(objViewInfoENEx.objViewRegion_List, objViewInfoENEx));

                    if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                    {
                        strCodeForCs.Append("\r\n" + "<INPUT id = \"rd\" style = \"z-index: 109; left: 896px; width: 24px; position: absolute; top: 48px; height: 22px\" type = \"hidden\" size = \"1\" name = \"rd\" runat = \"server\"> ");
                        strCodeForCs.Append("\r\n" + "<INPUT style = \"display: none; z-index: 110; left: 8px; position: absolute; top: 1px\" type = \"radio\" CHECKED name = \"RadioName\">");
                    }


                }
                //生成查询区域代码 == == == == == == == == == == == == == == == 

                //生成编辑区域代码-------------------------------
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                  || objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {

                    intZIndex += 1;
                    intCurrTop += 25;
                    ///生成用于布局的表格代码;
                    strCodeForCs.Append("\r\n" + "<%-- 编辑层 --%>");
                    strCodeForCs.AppendFormat("\r\n" + "<div id = \"tabEdit{2}Region\" class = \"tab_Edit\" ",
                      intZIndex, intCurrTop, objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "runat = \"server\">");
                    strCodeForCs.Append("\r\n" + "<div>");
                    strCodeForCs.Append("\r\n" + "<table style = \"width: 100%;\" class = \"msgtable\">");
                    strCodeForCs.Append("\r\n" + "<tr>");
                    strCodeForCs.Append("\r\n" + "<th style = \"text-align: left\">");

                    strCodeForCs.AppendFormat("\r\n" + "<asp:label id = \"lblEdit{0}\" style = \"z-index: 104; \" runat = \"server\"",
                      objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "CssClass = \"h6\" >{0}编辑区域</asp:label>",
                      objViewInfoENEx.objInRelaTab.TabCnName);


                    strCodeForCs.Append("\r\n" + "<asp:Label id = \"lblMsg_Edit\" style = \"z-index: 105; \" runat = \"server\" ");
                    strCodeForCs.Append("\r\n" + "Width = \"208px\"  CssClass = \"text-warning\" ></asp:Label>");
                    strCodeForCs.Append("\r\n" + "</th>");
                    strCodeForCs.Append("\r\n" + "<th style = \"text-align: right\">");

                    strCodeForCs.Append("\r\n" + "<asp:Button id = \"btnOKUpd\" style = \"z-index: 106; \" runat = \"server\" ");
                    strCodeForCs.Append("\r\n" + "Width = \"80px\" Text = \"添加\" OnClick = \"btnSubmit_Click\" CssClass = \"btn btn-primary btn-sm\"></asp:Button>");
                    strCodeForCs.Append("\r\n" + "&nbsp;");


                    strCodeForCs.AppendFormat("\r\n" + "<asp:Button id = \"btnCancelEdit_{0}\" ",
                      objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "runat = \"server\" Width = \"100px\" CssClass = \"btn btn-primary btn-sm\" Text = \"取消编辑\" OnClick = \"btnCancelEdit_{1}_Click\"></asp:Button>",
                      objViewInfoENEx.objInRelaTab.TabCnName,
                      objViewInfoENEx.TabName);


                    ///生成界面中控件<确定修改>的代码, top与布局表一样;
                    strCodeForCs.Append("\r\n" + "</th>");
                    strCodeForCs.Append("\r\n" + "</tr>");
                    strCodeForCs.Append("\r\n" + "</table>");
                    strCodeForCs.Append("\r\n" + "</div>");
                    strCodeForCs.Append("\r\n" + "<div>");
                    strCodeForCs.AppendFormat("\r\n" + "<uc1:wuc{0}B id = \"wuc{1}B1\" runat = \"server\" />",
                      objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "</div>");
                    strCodeForCs.Append("\r\n" + "</div>");
                    intZIndex += 1;
                    intCurrLeft = 460;

                }
                //生成编辑区域代码 == == == == == == == == == == == == == == 

                strCodeForCs.Append("\r\n" + "</div>");

                strCodeForCs.Append("\r\n" + "</form>");
                strCodeForCs.Append("\r\n" + "</body>");
                strCodeForCs.Append("\r\n" + "</html>");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }



        #region 生成单个控件的生成函数


        public string Gen_Mvc_DataGrid()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            int iDGHeight;      //DataGrid的高度
           
            //			string strTemp ;     ///临时变量;
            ///判断DataGrid是否需要排序
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                if (objDGRegionFldsEx.IsNeedSort)
                {
                    //objViewInfoENEx.objViewRegion_List.AllowSorting() = true;
                }
            }
            try
            {
                ///生成插入记录的界面代码;
                //objViewInfoENEx.objViewRegion_List.StyleZindex() = intZIndex + 1;
                //objViewInfoENEx.objViewRegion_List.StyleLeft = (int)intCurrLeft;
                //objViewInfoENEx.objViewRegion_List.StyleTop = (int)intCurrTop;

                iDGHeight = objViewInfoENEx.objViewRegion_List.Height ?? 0 + 50;
               

                strCodeForCs.Append("\r\n" + "                <table class=\"table table-striped table-condensed table-bordered\">");
                strCodeForCs.Append("\r\n" + "                    <tr>");
                strCodeForCs.Append("\r\n" + "                        <th>");
                strCodeForCs.Append("\r\n" + "                            <label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\">");
                strCodeForCs.Append("\r\n" + "                                <input id=\"btnCheckAll\" type=\"checkbox\" class=\"group-checkable\" data-set=\"#MyTable.checkboxes\" onchange=\"CheckAllHandler()\" />");
                strCodeForCs.Append("\r\n" + "                                <span></span>");
                strCodeForCs.Append("\r\n" + "                            </label>");
                strCodeForCs.Append("\r\n" + "                        </th>");
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    string strFldName = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                    string strCaption = objDGRegionFldsEx.HeaderText;

                    strCodeForCs.Append("\r\n" + " <th class=\"text-left\">");
                    strCodeForCs.AppendFormat("\r\n" + "  @Html.ActionLink(\"{0}\", \"{2}_SortList\", new {{ sortOrder = ViewBag.{1}SortParm }})",
                        strCaption, strFldName, objViewInfoENEx.TabName_Out);
                    strCodeForCs.Append("\r\n" + " </th>");
                }
                strCodeForCs.Append("\r\n" + "                        <th class=\"text-center\">修改</th>");
                strCodeForCs.Append("\r\n" + "                        <th class=\"text-center\">删除</th>");
                strCodeForCs.Append("\r\n" + "                    </tr>");

                string strSortExpression;

                strCodeForCs.AppendFormat("\r\n" + " @foreach (cls{0}EN item in Model.{0}Lst)", 
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + " <tr>");
                if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)    //判断是否需要单选按钮
                {
                    strCodeForCs.Append("\r\n" + "  <td>");
                    strCodeForCs.Append("\r\n" + "     <label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\">");
                    strCodeForCs.AppendFormat("\r\n" + "     <input type=\"checkbox\" class=\"checkboxes\" value=\"@item.{0}\" checked=\"@item._Checked\" id=\"checkedId\" name =\"checkedId\" />",
                        objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "     <span></span>");
                    strCodeForCs.Append("\r\n" + "     </label>");
                    strCodeForCs.Append("\r\n" + "  </td>");
                }
                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)    //判断是否需要复选按钮
                {
                    strCodeForCs.Append("\r\n" + "   <td>");
                    strCodeForCs.Append("\r\n" + "       <label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\">");
                    strCodeForCs.AppendFormat("\r\n" + "           <input type=\"checkbox\" class=\"checkboxes\" value=\"@item.{0}\" checked=\"@item._Checked\" id=\"checkedId\" name =\"checkedId\" />",
                        objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "           <span></span>");
                    strCodeForCs.Append("\r\n" + "       </label>");
                    strCodeForCs.Append("\r\n" + "  </td>");
                }
            
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    string strFldName = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                    if (objDGRegionFldsEx.IsNeedSort)   //判断是否需要排序
                    {
                        strSortExpression = "SortExpression = \"" + objDGRegionFldsEx.ObjFieldTabENEx.FldName + "\"";
                    }
                    else
                    {
                        strSortExpression = "";
                    }
                    strCodeForCs.AppendFormat("\r\n" + "   <td class=\"text-left\">@item.{0}</td>",
                        strFldName);
                }
                if (objViewInfoENEx.objViewRegion_List.IsHaveUpdBtn() == true)   //在DG中是否有修改按钮
                {
                    strCodeForCs.Append("\r\n" + "   <td class=\"text-center\">");
                    strCodeForCs.AppendFormat("\r\n" + "      @Html.ActionLink(\"修改\", \"Update\", \"{0}\", new {{ {1} = @item.{1} }}, new {{ @class = \"btn btn-default\" }})",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "   </td>");
                }
                if (objViewInfoENEx.objViewRegion_List.IsHaveDelBtn() == true)   //在DG中是否有删除按钮
                {
                    strCodeForCs.Append("\r\n" + "   <td class=\"text-center\">");
                    strCodeForCs.AppendFormat("\r\n" + "      @Html.ActionLink(\"删除\", \"Delete\", \"{0}\", new {{ {1} = @item.{1} }}, new {{ @class = \"btn btn-default\" }})",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "   </td>");
                }
                if (objViewInfoENEx.objViewRegion_List.IsHaveDetailBtn() == true) //在DG中是否有详细信息按钮
                {
                    strCodeForCs.Append("\r\n" + "   <td class=\"text-center\">");
                    strCodeForCs.AppendFormat("\r\n" + "      @Html.ActionLink(\"详细信息\", \"Detail\", \"{0}\", new {{ {1} = @item.{1} }}, new {{ @class = \"btn btn-default\" }})",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "   </td>");
                }
                strCodeForCs.Append("\r\n" + "  </tr>");
                strCodeForCs.Append("\r\n" + "  }");
                strCodeForCs.Append("\r\n" + " </table>");
                //strCodeForCs.Append("\r\n" + "</div>");
                if (objViewInfoENEx.objViewRegion_List.IsJumpPage() == true)
                {
                    strCodeForCs.Append("\r\n" + " <div class=\"btn-group pull-right\">");
                    strCodeForCs.AppendFormat("\r\n" + "   @Html.PageLinksV2(Model.PagingInfo, x => Url.Action(\"{0}_Pager\", new {{ page = x }}))",
                        objViewInfoENEx.TabName_Out);
                    strCodeForCs.Append("\r\n" + " </div>");

                    intZIndex += objViewInfoENEx.objViewRegion_List.StyleZindex() + 1;
                    intCurrTop += objViewInfoENEx.objViewRegion_List.Height ?? 0 + 5;
                    intCurrLeft = 10;
                }
                else
                {
                    intZIndex += objViewInfoENEx.objViewRegion_List.StyleZindex() + 1;
                    intCurrTop += objViewInfoENEx.objViewRegion_List.Height ?? 0 + 5;
                    intCurrLeft = 10;
                    clsLabelStyleEN objLabelStyle = clsLabelStyleBL.GetObjByLabelStyleIdCache("0001");
                    strCodeForCs.AppendFormat("\r\n" + GenLabel(objLabelStyle, "lbl" + objViewInfoENEx.TabName + "RecCount", "查询结果记录数:"));
                    intCurrLeft += 120;
                    clsTextBoxStyleEN objTextBoxStyle = clsTextBoxStyleBL.GetObjByTextBoxStyleId("0002");
                    strCodeForCs.Append("\r\n" + GenTextBox(objTextBoxStyle, "txt" + objViewInfoENEx.TabName + "RecCount"));
                }
       
                intCurrTop += 45;

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Mvc_DataGridAjax()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            int iDGHeight;      //DataGrid的高度


            //			string strTemp ;     ///临时变量;
            ///判断DataGrid是否需要排序
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                if (objDGRegionFldsEx.IsNeedSort)
                {
                    //objViewInfoENEx.objViewRegion_List.AllowSorting() = true;
                }
            }
            try
            {
                ///生成插入记录的界面代码;
                //objViewInfoENEx.objViewRegion_List.StyleZindex() = intZIndex + 1;
                //objViewInfoENEx.objViewRegion_List.StyleLeft = (int)intCurrLeft;
                //objViewInfoENEx.objViewRegion_List.StyleTop = (int)intCurrTop;

                iDGHeight = objViewInfoENEx.objViewRegion_List.Height ?? 0 + 50;


                strCodeForCs.Append("\r\n" + "                <table class=\"table table-striped table-condensed table-bordered\">");
                strCodeForCs.Append("\r\n" + "                    <tr>");
                strCodeForCs.Append("\r\n" + "                        <th>");
                strCodeForCs.Append("\r\n" + "                            <label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\">");
                strCodeForCs.Append("\r\n" + "                                <input id=\"btnCheckAll\" type=\"checkbox\" class=\"group-checkable\" data-set=\"#MyTable.checkboxes\" onchange=\"CheckAllHandler()\" />");
                strCodeForCs.Append("\r\n" + "                                <span></span>");
                strCodeForCs.Append("\r\n" + "                            </label>");
                strCodeForCs.Append("\r\n" + "                        </th>");
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    string strFldName = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                    string strCaption = objDGRegionFldsEx.HeaderText;

                    strCodeForCs.Append("\r\n" + " <th class=\"text-left\">");
                    strCodeForCs.AppendFormat("\r\n" + "  @Ajax.ActionLink(\"{0}\", \"SortListAjax\", new {{ sortOrder = ViewBag.{1}SortParm }}, ",
                        strCaption, strFldName, objViewInfoENEx.TabName_Out);
                    strCodeForCs.AppendFormat("\r\n" + "                new AjaxOptions {{ Url = Url.Action(\"SortListAjax\", new {{ sortOrder = ViewBag.{1}SortParm }}), UpdateTargetId = \"divLstTab_{2}\" }})",
                        strCaption, strFldName, objViewInfoENEx.TabName_Out);
                    strCodeForCs.Append("\r\n" + " </th>");
                }
                //strCodeForCs.Append("\r\n" + "                        <th class=\"text-left\">");
                //strCodeForCs.Append("\r\n" + "                            @Html.ActionLink(\"状态名\", \"SortList\", new { sortOrder = ViewBag.UserStateNameSortParm })");
                //strCodeForCs.Append("\r\n" + "                        </th>");
                strCodeForCs.Append("\r\n" + "                        <th class=\"text-center\">修改</th>");
                strCodeForCs.Append("\r\n" + "                        <th class=\"text-center\">删除</th>");
                strCodeForCs.Append("\r\n" + "                    </tr>");

                string strSortExpression;

                strCodeForCs.AppendFormat("\r\n" + " @foreach (cls{0}EN item in Model.{0}Lst)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + " <tr>");
                if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)    //判断是否需要单选按钮
                {
                    strCodeForCs.Append("\r\n" + "  <td>");
                    strCodeForCs.Append("\r\n" + "     <label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\">");
                    strCodeForCs.AppendFormat("\r\n" + "     <input type=\"checkbox\" class=\"checkboxes\" value=\"@item.{0}\" checked=\"@item._Checked\" id=\"checkedId\" name =\"checkedId\" />",
                        objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "     <span></span>");
                    strCodeForCs.Append("\r\n" + "     </label>");
                    strCodeForCs.Append("\r\n" + "  </td>");
                }
                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)    //判断是否需要复选按钮
                {
                    strCodeForCs.Append("\r\n" + "   <td>");
                    strCodeForCs.Append("\r\n" + "       <label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\">");
                    strCodeForCs.AppendFormat("\r\n" + "           <input type=\"checkbox\" class=\"checkboxes\" value=\"@item.{0}\" checked=\"@item._Checked\" id=\"checkedId\" name =\"checkedId\" />",
                        objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "           <span></span>");
                    strCodeForCs.Append("\r\n" + "       </label>");
                    strCodeForCs.Append("\r\n" + "  </td>");
                }

                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    string strFldName = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                    if (objDGRegionFldsEx.IsNeedSort)   //判断是否需要排序
                    {
                        strSortExpression = "SortExpression = \"" + objDGRegionFldsEx.ObjFieldTabENEx.FldName + "\"";
                    }
                    else
                    {
                        strSortExpression = "";
                    }
                    strCodeForCs.AppendFormat("\r\n" + "   <td class=\"text-left\">@item.{0}</td>",
                        strFldName);
                }
                if (objViewInfoENEx.objViewRegion_List.IsHaveUpdBtn() == true)   //在DG中是否有修改按钮
                {
                    strCodeForCs.Append("\r\n" + "   <td class=\"text-center\">");
                    strCodeForCs.AppendFormat("\r\n" + "      @Ajax.ActionLink(\"修改\", \"GetObjBy{1}\", \"{0}\", new {{ {1} = @item.{1} }}, new AjaxOptions {{  Url = Url.Action(\"GetJsonObjBy{1}\", new {{ {1} = @item.{1} }}), OnSuccess=\"UpdateRec\" }}, new {{ @class = \"btn btn-default\" }})",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "   </td>");
                }
                if (objViewInfoENEx.objViewRegion_List.IsHaveDelBtn() == true)   //在DG中是否有删除按钮
                {
                    strCodeForCs.Append("\r\n" + "   <td class=\"text-center\">");
                    strCodeForCs.AppendFormat("\r\n" + "      @Html.ActionLink(\"删除\", \"Delete\", \"{0}\", new {{ {1} = @item.{1} }}, new {{ @class = \"btn btn-default\" }})",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "   </td>");
                }
                if (objViewInfoENEx.objViewRegion_List.IsHaveDetailBtn() == true) //在DG中是否有详细信息按钮
                {
                    strCodeForCs.Append("\r\n" + "   <td class=\"text-center\">");
                    strCodeForCs.AppendFormat("\r\n" + "      @Html.ActionLink(\"详细信息\", \"Detail\", \"{0}\", new {{ {1} = @item.{1} }}, new {{ @class = \"btn btn-default\" }})",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "   </td>");
                }
                strCodeForCs.Append("\r\n" + "  </tr>");
                strCodeForCs.Append("\r\n" + "  }");
                strCodeForCs.Append("\r\n" + " </table>");
                //strCodeForCs.Append("\r\n" + "</div>");
                if (objViewInfoENEx.objViewRegion_List.IsJumpPage() == true)
                {
                    strCodeForCs.Append("\r\n" + " <div class=\"btn-group pull-right\">");
                    strCodeForCs.Append("\r\n" + "   @Ajax.PageLinksAjax(Model.PagingInfo,");
                    strCodeForCs.AppendFormat("\r\n" + "       x => Url.Action(\"{0}_PagerAjax\", new {{ page = x }}), ",
                        objViewInfoENEx.TabName_Out);
                    strCodeForCs.AppendFormat("\r\n" + "        new AjaxOptions {{ Url = Url.Action(\"{0}_PagerAjax\"), UpdateTargetId = \"divLstTab_{0}\" }})",
                        objViewInfoENEx.TabName_Out);

                    strCodeForCs.Append("\r\n" + " </div>");

                    intZIndex += objViewInfoENEx.objViewRegion_List.StyleZindex() + 1;
                    intCurrTop += objViewInfoENEx.objViewRegion_List.Height ?? 0 + 5;
                    intCurrLeft = 10;
                }
                else
                {
                    intZIndex += objViewInfoENEx.objViewRegion_List.StyleZindex() + 1;
                    intCurrTop += objViewInfoENEx.objViewRegion_List.Height ?? 0 + 5;
                    intCurrLeft = 10;
                    clsLabelStyleEN objLabelStyle = clsLabelStyleBL.GetObjByLabelStyleIdCache("0001");
                    strCodeForCs.AppendFormat("\r\n" + GenLabel(objLabelStyle, "lbl" + objViewInfoENEx.TabName + "RecCount", "查询结果记录数:"));
                    intCurrLeft += 120;
                    clsTextBoxStyleEN objTextBoxStyle = clsTextBoxStyleBL.GetObjByTextBoxStyleId("0002");
                    strCodeForCs.Append("\r\n" + GenTextBox(objTextBoxStyle, "txt" + objViewInfoENEx.TabName + "RecCount"));
                }

                intCurrTop += 45;

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string GenFunctionRegion(clsViewRegionEN objDGRegionENEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            int iDGHeight;      //DataGrid的高度

            //			string strTemp ;     ///临时变量;
            ///判断DataGrid是否需要排序
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                if (objDGRegionFldsEx.IsNeedSort)
                {
                    //objViewInfoENEx.objViewRegion_List.AllowSorting() = true;
                }
            }
            try
            {
                ///生成插入记录的界面代码;
                //objViewInfoENEx.objViewRegion_List.StyleZindex() = intZIndex + 1;
                //objViewInfoENEx.objViewRegion_List.StyleLeft = (int)intCurrLeft;
                //objViewInfoENEx.objViewRegion_List.StyleTop = (int)intCurrTop;

                iDGHeight = objViewInfoENEx.objViewRegion_List.Height ?? 0 + 50;
              

                strCodeForCs.AppendFormat("\r\n" + "<div id = \"divFunction\" class = \"div_Funttion\" runat = \"server\">",
                  objViewInfoENEx.TabName, intCurrTop);

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true || objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
                    //strCodeForCs.AppendFormat("\r\n" + "<tr>");
                    //strCodeForCs.AppendFormat("\r\n" + "<td>");
                    //添加层div
                    ASPHtmlTableEx objASPNETHtmlTableENEx = clsASPHtmlTableBLEx.GettabGridFunction();
                    ASPRowEx objASPNETRowENEx = clsASPRowBLEx.GetEmptyTr();
                    objASPNETHtmlTableENEx.arrSubAspControlLst2.Add(objASPNETRowENEx);

                    ASPColEx objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                    //列表标题
                    ASPLabelEx objASPNETLabelENEx = clsASPLabelBLEx.GetDataListTitle(objViewInfoENEx);
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETLabelENEx);

                    //

                    //strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabGridFunction\" style = \"width: 100%; height: 32px\" class = \"msgtable\" >");
                    //strCodeForCs.AppendFormat("\r\n" + "<tr>");
                    //strCodeForCs.Append("\r\n" + "<td>");

                    //strCodeForCs.AppendFormat("\r\n" + "<asp:label id = \"lbl{0}List\" runat = \"server\" style = \"z-index: 105; \" ",
                    //  objViewInfoENEx.TabName);
                    //strCodeForCs.AppendFormat("\r\n" + "CssClass = \"h6\" Width = \"250px\">{0}列表</asp:label>",
                    //  objViewInfoENEx.objInRelaTab.TabCnName);
                    //strCodeForCs.Append("\r\n" + "</td>");

                    //iDG_Div_Left = 390;//第一个按钮的左为390
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                      || objViewInfoENEx.objViewTypeCodeTab.IsHaveExeAdd)
                    {
                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                        //strCodeForCs.Append("\r\n" + "<td>");

                        //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnAddNewRec4Gv\" runat = \"server\" OnClick = \"btnAddNewRec4Gv_Click\" style = \"z-index: 106; \"",
                        //  iDG_Div_Left);
                        //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"添加记录\"></asp:button>");
                        //strCodeForCs.Append("\r\n" + "</td>");
                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel == true)
                    {
                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnDelete4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                        //iDG_Div_Left += 85;
                        //strCodeForCs.Append("\r\n" + "<td>");
                        //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnDelete4Gv\" OnClick = \"btnDelete4Gv_Click\" style = \"z-index: 104; \" runat = \"server\"",
                        //  iDG_Div_Left);
                        //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"删除记录\"></asp:button>");
                        //strCodeForCs.Append("\r\n" + "</td>");
                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate == true)
                    {

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnUpdate4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        //iDG_Div_Left += 85;
                        //strCodeForCs.Append("\r\n" + "<td>");
                        //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnUpdate4Gv\" OnClick = \"btnUpdate4Gv_Click\" style = \"z-index: 105; \" runat = \"server\"",
                        //  iDG_Div_Left);
                        //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"修改记录\"></asp:button>");
                        //strCodeForCs.Append("\r\n" + "</td>");
                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                    {

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnUpdate4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        //iDG_Div_Left += 85;
                        //strCodeForCs.Append("\r\n" + "<td>");
                        //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnUpdate4Gv\" OnClick = \"btnUpdate4Gv_Click\" style = \"z-index: 105; \" runat = \"server\"",
                        //  iDG_Div_Left);
                        //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"修改记录\"></asp:button>");
                        //strCodeForCs.Append("\r\n" + "</td>");
                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail == true)
                    {

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnDetail4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        //iDG_Div_Left += 85;
                        //strCodeForCs.Append("\r\n" + "<td>");
                        //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnDetail4Gv\" style = \"z-index: 105; \" runat = \"server\"",
                        //  iDG_Div_Left);
                        //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"详细信息\"></asp:button>");
                        //strCodeForCs.Append("\r\n" + "</td>");
                    }
                    if (objViewInfoENEx.arrFeatureId.Contains("0142") == true)
                    {
                        //List<ASPButtonEx> arrAspNetButton4AdjustOrderNum = new List<ASPButtonEx>();
                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnGoTop();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        objASPNETButtonENEx = clsASPButtonBLEx.GetbtnUpMove();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        objASPNETButtonENEx = clsASPButtonBLEx.GetbtnDownMove();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        objASPNETButtonENEx = clsASPButtonBLEx.GetbtnGoBottum();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        objASPNETButtonENEx = clsASPButtonBLEx.GetbtnReOrder();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        //foreach (ASPButtonEx objInfor in arrAspNetButton4AdjustOrderNum)
                        //{
                        //    clsASPButtonBLEx.GeneCode(objInfor, strCodeForCs);

                        //}
                    }
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExcelExport == true)
                    {
                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnExportExcel4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        //iDG_Div_Left += 85;
                        //strCodeForCs.Append("\r\n" + "<td>");

                        //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnExportExcel4Gv\" OnClick = \"btnExportExcel4Gv_Click\" ",
                        //  iDG_Div_Left);
                        //strCodeForCs.AppendFormat("\r\n" + "runat = \"server\" Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"导出Excel\"></asp:button>");
                        //strCodeForCs.Append("\r\n" + "</td>");
                    }
                    if (objViewInfoENEx.IsNeedSetExportFld == true &&
                          objViewInfoENEx.objViewTypeCodeTab.IsHaveSetExportExcel == true)
                    {
                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnSetExportExcel4User();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                        //iDG_Div_Left += 85;
                        //strCodeForCs.Append("\r\n" + "<td>");

                        //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnSetExportExcel4User\" OnClick = \"btnSetExportExcel4User_Click\" ",
                        //  iDG_Div_Left);
                        //strCodeForCs.AppendFormat("\r\n" + "runat = \"server\" Width = \"100px\" CssClass = \"btn btn-primary btn-sm\" Text = \"设置导出字段\"></asp:button>");
                        //strCodeForCs.Append("\r\n" + "</td>");
                    }

                    //层结束
                    //strCodeForCs.AppendFormat("\r\n" + "</tr>");
                    //strCodeForCs.Append("\r\n" + "</table>");
                    objASPNETHtmlTableENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                }
                //生成GridView的代码;


                strCodeForCs.AppendFormat("\r\n" + "</div>");

                intCurrTop += 45;

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenGridViewNew(clsViewRegionEN objDGRegionENEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            int iDGHeight;      //DataGrid的高度
            //int iDG_Div_Left;
            
            //			string strTemp ;     ///临时变量;
            ///判断DataGrid是否需要排序
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                if (objDGRegionFldsEx.IsNeedSort)
                {
                    //objViewInfoENEx.objViewRegion_List.AllowSorting() = true;
                }
            }
            try
            {
                ///生成插入记录的界面代码;
                //objViewInfoENEx.objViewRegion_List.StyleZindex() = intZIndex + 1;
                //objViewInfoENEx.objViewRegion_List.StyleLeft = (int)intCurrLeft;
                //objViewInfoENEx.objViewRegion_List.StyleTop = (int)intCurrTop;

                iDGHeight = objViewInfoENEx.objViewRegion_List.Height ?? 0 + 50;
               
                strCodeForCs.AppendFormat("\r\n" + "<div id = \"divList\" class = \"div_List\" ",
                  objViewInfoENEx.TabName, intCurrTop);
                strCodeForCs.AppendFormat("\r\n" + "runat = \"server\">");
                if (objViewInfoENEx.objViewRegion_List.IsInTab() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "<asp:GridView id = \"gv{0}\" runat = \"server\" ",
                      objViewInfoENEx.TabName, objViewInfoENEx.objViewRegion_List.StyleZindex());
                }
                else
                {
                    //					strCodeForCs.AppendFormat("\r\n" + "<asp:DataGrid id = \"dg{0}\" style = \"z-index: {1}; left: {4}px; position: {3}; top: {2}px\" runat = \"server\" ", 
                    //						objViewInfoENEx.TabName, objViewInfoENEx.objViewRegion_List.StyleZindex(), objViewInfoENEx.objViewRegion_List.StyleTop, objViewInfoENEx.objViewRegion_List.StylePosition,objViewInfoENEx.objViewRegion_List.StyleLeft);
                    //					隐藏高度
                    strCodeForCs.AppendFormat("\r\n" + "<asp:GridView id = \"gv{0}\" style = \"z-index: {1};\" runat = \"server\" ",
                      objViewInfoENEx.TabName, objViewInfoENEx.objViewRegion_List.StyleZindex());

                }
                //				strCodeForCs.AppendFormat("\r\n" + "Width = \"{0}px\" Height = \"{1}px\" AutoGenerateColumns = \"{2}\" ", 
                //					objViewInfoENEx.objViewRegion_List.Width, objViewInfoENEx.objViewRegion_List.Height, objViewInfoENEx.objViewRegion_List.AutoGenerateColumns());
                //					隐藏高度
                strCodeForCs.AppendFormat("\r\n" + "Width = \"100%\" AutoGenerateColumns = \"{1}\" ",
                  objViewInfoENEx.objViewRegion_List.Width, objViewInfoENEx.objViewRegion_List.AutoGenerateColumns());
                if (objViewInfoENEx.objViewRegion_List.AllowPaging() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "PageSize = \"{0}\" AllowPaging = \"true\" ",
                      objViewInfoENEx.objViewRegion_List.PageSize());
                }
                else
                {
                }
                ///设置是否排序
                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "AllowSorting = \"true\" ");
                }

                strCodeForCs.AppendFormat("\r\n" + "OnSorting = \"gv{0}_Sorting\" ",
                  objViewInfoENEx.TabName);
                //				strCodeForCs.AppendFormat("\r\n" + "OnSelectedIndexChanged = \"gv{0}_SelectedIndexChanged\" ",
                //				objViewInfoENEx.TabName);
                if (objViewInfoENEx.objViewRegion_List.AllowPaging() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "OnPageIndexChanging = \"gv{0}_PageIndexChanging\" ",
                      objViewInfoENEx.TabName);
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel == true
                  && objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "OnRowCreated = \"gv{0}_RowCreated\"",
                      objViewInfoENEx.TabName);
                }
                strCodeForCs.AppendFormat("\r\n" + "OnRowCommand = \"gv{0}_RowCommand\"",
                  objViewInfoENEx.TabName);
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "OnRowDeleting = \"gv{0}_RowDeleting\" ",
                      objViewInfoENEx.TabName);
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "OnRowUpdating = \"gv{0}_RowUpdating\" ",
                      objViewInfoENEx.TabName);
                }

                strCodeForCs.Append("\r\n" + "BackColor = \"White\" ");
                strCodeForCs.Append("\r\n" + "BorderColor = \"#E7E7FF\" ");
                strCodeForCs.Append("\r\n" + "BorderStyle = \"None\" ");
                strCodeForCs.Append("\r\n" + "BorderWidth = \"1px\"");
                strCodeForCs.Append("\r\n" + "cellpadding = \"3\" ");
                strCodeForCs.Append("\r\n" + "GridLines = \"Horizontal\" ");
                strCodeForCs.Append("\r\n" + "Height = \"1px\" ");
                strCodeForCs.AppendFormat("\r\n" + "DataKeyNames = \"{0}\" ",
                      objViewInfoENEx.KeyFldNameLstStr);
                strCodeForCs.Append("\r\n" + "CssClass = \"GridValue\">");

                string strSortExpression;

                strCodeForCs.Append("\r\n" + "<Columns>");
                if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)    //判断是否需要单选按钮
                {
                    strCodeForCs.Append("\r\n" + "<asp:TemplateField>");
                    strCodeForCs.Append("\r\n" + "<ItemTemplate>");
                    strCodeForCs.AppendFormat("\r\n" + "<INPUT onclick = radioClick() type = radio value = '<%# DataBinder.Eval(Container.DataItem, \"{0}\")%>' name = RadioName>",
                      objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
                }
                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)    //判断是否需要复选按钮
                {
                    strCodeForCs.Append("\r\n" + "<asp:TemplateField HeaderText = \"全选\">");
                    strCodeForCs.Append("\r\n" + "<HeaderStyle Width = \"30px\" />");
                    strCodeForCs.Append("\r\n" + "<HeaderTemplate>");
                    strCodeForCs.Append("\r\n" + "<asp:LinkButton id = \"lbSelAll\" CommandName = \"lbSelAll\" runat = \"server\" CssClass = \"btn btn-link btn-sm text-nowrap\" Text = \"全选\"></asp:LinkButton>");
                    strCodeForCs.Append("\r\n" + "</HeaderTemplate>");
                    strCodeForCs.Append("\r\n" + "<ItemTemplate>");
                    strCodeForCs.AppendFormat("\r\n" + "<a name = \"A_{0}<%# Eval(\"{1}\").ToString().Trim() %>\"></a>",
                       objViewInfoENEx.TabName,
                       objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "<asp:CheckBox id = \"chkCheckRec\" runat = \"server\"></asp:CheckBox>");
                    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
                }

                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (objDGRegionFldsEx.IsNeedSort)   //判断是否需要排序
                    {
                        strSortExpression = "SortExpression = \"" + objDGRegionFldsEx.ObjFieldTabENEx.FldName + "\"";
                    }
                    else
                    {
                        strSortExpression = "";
                    }
                    strCodeForCs.AppendFormat("\r\n" + "<asp:BoundField DataField = \"{0}\" {2} HeaderText = \"{1}\"></asp:BoundField>",
                      objDGRegionFldsEx.ObjFieldTabENEx.FldName,
                      objDGRegionFldsEx.HeaderText,
                      strSortExpression);
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate == true)    //在DG中是否有修改按钮
                {
                    strCodeForCs.Append("\r\n" + "<asp:TemplateField HeaderText = \"修改\">");
                    strCodeForCs.Append("\r\n" + "<ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "<asp:LinkButton id = \"lbUpdate\" runat = \"Server\" CommandName = \"Update\" Text = \"修改\" CssClass = \"LinkButton_DefaInGv\"></asp:LinkButton>");
                    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate) //在DG中是否有修改按钮
                {
                    strCodeForCs.Append("\r\n" + "<asp:TemplateField HeaderText = \"修改\">");
                    strCodeForCs.Append("\r\n" + "<ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "<asp:LinkButton id = \"lbUpdate\" runat = \"Server\" CommandName = \"Update\" Text = \"修改\" CssClass = \"LinkButton_DefaInGv\" ></asp:LinkButton>");
                    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel == true)   //在DG中是否有删除按钮
                {
                    strCodeForCs.Append("\r\n" + "<asp:TemplateField HeaderText = \"删除\">");
                    strCodeForCs.Append("\r\n" + "<ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "<asp:LinkButton id = \"lbDelete\" runat = \"Server\" CommandName = \"Delete\" Text = \"删除\" CssClass = \"LinkButton_DefaInGv\"></asp:LinkButton>");
                    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail == true) //在DG中是否有详细信息按钮
                {
                    strCodeForCs.Append("\r\n" + "<asp:TemplateField>");
                    strCodeForCs.Append("\r\n" + "<ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "<asp:Button id = \"lbDetail\" runat = \"Server\" CommandName = \"Detail\" Text = \"详细信息\" CssClass = \"LinkButton_DefaInGv\"></asp:Button>");
                    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
                }

                strCodeForCs.Append("\r\n" + "</Columns>"); //列结束
                                                            //分页模式
                strCodeForCs.Append("\r\n" + "<PagerTemplate>");
                strCodeForCs.Append("\r\n" + "<span class=\"text-secondary\">共有记录:</span>");
                strCodeForCs.Append("\r\n" + "<asp:Label ID = \"lblRecCount\" runat = \"server\" CssClass = \"text-info col-form-label-sm\" ForeColor = \"#000066\" Width = \"36px\">0</asp:Label>");
                strCodeForCs.Append("\r\n" + "<span class=\"text-secondary\">");
                strCodeForCs.Append("\r\n" + "<div style = \"display: inline; width: 16px; height: 13px\">");
                strCodeForCs.Append("\r\n" + "</div>");
                strCodeForCs.Append("\r\n" + "</span><span class=\"text-secondary\">总页数:</span>");
                strCodeForCs.Append("\r\n" + "<asp:Label ID = \"lblAllPages\" runat = \"server\" CssClass = \"text-info col-form-label-sm\" ForeColor = \"#000066\">0</asp:Label>");
                strCodeForCs.Append("\r\n" + "<div style = \"display: inline; width: 16px; height: 13px\">");
                strCodeForCs.Append("\r\n" + "</div>");
                strCodeForCs.Append("\r\n" + "<span class=\"text-secondary\">当前页:</span>");
                strCodeForCs.Append("\r\n" + "<asp:Label ID = \"lblCurrentPage\" runat = \"server\" CssClass = \"text-info col-form-label-sm\" ForeColor = \"#000066\">0</asp:Label>");
                strCodeForCs.Append("\r\n" + "<div style = \"display: inline; width: 16px; height: 13px\">");
                strCodeForCs.Append("\r\n" + "</div>");
                strCodeForCs.Append("\r\n" + "<asp:Button ID = \"btnPrevPage\" runat = \"server\" CssClass = \"btn btn-info\" Text = \"上一页\"");
                strCodeForCs.Append("\r\n" + "Width = \"50px\" CommandArgument = \"Prev\" CommandName = \"Page\" /><span style = \"font-family: Verdana\">");
                strCodeForCs.Append("\r\n" + "</span>");
                strCodeForCs.Append("\r\n" + "<asp:Button ID = \"btnNextPage\" runat = \"server\" CssClass = \"btn btn-info\" Text = \"下一页\"");
                strCodeForCs.Append("\r\n" + "Width = \"50px\" CommandArgument = \"Next\" CommandName = \"Page\" />");
                strCodeForCs.Append("\r\n" + "到第");
                strCodeForCs.Append("\r\n" + "<asp:TextBox ID = \"txtJump2Page\" runat = \"server\" CssClass = \"form-control form-control-sm\" Width = \"35px\"></asp:TextBox>页");
                strCodeForCs.Append("\r\n" + "<asp:Button ID = \"btnJumpPage\" runat = \"server\" CssClass = \"btn btn-info\" OnClick = \"btnJumpPage_Click\"");
                strCodeForCs.Append("\r\n" + "Text = \"确定\" Width = \"35px\" CommandName = \"Page\" />");

                strCodeForCs.Append("\r\n" + "<span class=\"text-secondary\">页记录数:</span>");
                strCodeForCs.Append("\r\n" + "<asp:DropDownList ID = \"ddlPagerRecCount\" runat = \"server\" CssClass = \"btn btn-outline-info\"");
                strCodeForCs.Append("\r\n" + "Width = \"55px\" AutoPostBack = \"True\" OnSelectedIndexChanged = \"ddlPagerRecCount_SelectedIndexChanged\">");
                strCodeForCs.Append("\r\n" + "<asp:ListItem>5</asp:ListItem>");
                strCodeForCs.Append("\r\n" + "<asp:ListItem>10</asp:ListItem>");
                strCodeForCs.Append("\r\n" + "<asp:ListItem>15</asp:ListItem>");
                strCodeForCs.Append("\r\n" + "<asp:ListItem>20</asp:ListItem>");
                strCodeForCs.Append("\r\n" + "<asp:ListItem>30</asp:ListItem>");
                strCodeForCs.Append("\r\n" + "<asp:ListItem>50</asp:ListItem>");
                strCodeForCs.Append("\r\n" + "<asp:ListItem>100</asp:ListItem>");
                strCodeForCs.Append("\r\n" + "<asp:ListItem>1000</asp:ListItem>");
                strCodeForCs.Append("\r\n" + "</asp:DropDownList>");

                strCodeForCs.Append("\r\n" + "<asp:CompareValidator ID = \"CompareValidator\" runat = \"server\" ControlToValidate = \"txtJump2Page\"");
                strCodeForCs.Append("\r\n" + "ErrorMessage = \"错误!\" ForeColor = \"DarkOrange\" Operator = \"DataTypeCheck\" Type = \"Integer\"></asp:CompareValidator>");
                strCodeForCs.Append("\r\n" + "</PagerTemplate>");
                strCodeForCs.Append("\r\n" + "<EmptyDataTemplate>");
                strCodeForCs.Append("\r\n" + "本列表无数据");
                strCodeForCs.Append("\r\n" + "</EmptyDataTemplate>");
                strCodeForCs.Append("\r\n" + "<FooterStyle CssClass = \"FooterStyle\" />");
                strCodeForCs.Append("\r\n" + "<RowStyle CssClass = \"RowStyle\" />");
                strCodeForCs.Append("\r\n" + "<EmptyDataRowStyle CssClass = \"EmptyDataRowStyle\" />");
                strCodeForCs.Append("\r\n" + "<SelectedRowStyle CssClass = \"SelectedRowStyle\" />");
                strCodeForCs.Append("\r\n" + "<PagerStyle CssClass = \"PagerStyle\" />");
                strCodeForCs.Append("\r\n" + "<HeaderStyle CssClass = \"HeaderStyle\" />");
                strCodeForCs.Append("\r\n" + "<EditRowStyle CssClass = \"EditRowStyle\" />");
                strCodeForCs.Append("\r\n" + "<AlternatingRowStyle CssClass = \"AlternatingRowStyle\" />");
                strCodeForCs.Append("\r\n" + "</asp:GridView>");
                //strCodeForCs.AppendFormat("\r\n" + "</td>");
                //strCodeForCs.AppendFormat("\r\n" + "</tr>");

                //<FooterStyle CssClass = "FooterStyle" />
                // <RowStyle CssClass = "RowStyle" />
                // <EmptyDataRowStyle CssClass = "EmptyDataRowStyle" />
                // <PagerStyle CssClass = "PagerStyle" />
                // <SelectedRowStyle CssClass = "SelectedRowStyle" />
                // <HeaderStyle CssClass = "HeaderStyle" />
                // <EditRowStyle CssClass = "EditRowStyle" />
                // <AlternatingRowStyle CssClass = "AlternatingRowStyle" />

                strCodeForCs.AppendFormat("\r\n" + "</div>");

                intCurrTop += 45;

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenGridView4WucGv(clsViewRegionEN objDGRegionENEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            int iDGHeight;      //DataGrid的高度
            //int iDG_Div_Left;
            
            //			string strTemp ;     ///临时变量;
            ///判断DataGrid是否需要排序
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                if (objDGRegionFldsEx.IsNeedSort)
                {
                    //objViewInfoENEx.objViewRegion_List.AllowSorting() = true;
                }
            }
            try
            {
                ///生成插入记录的界面代码;
                //objViewInfoENEx.objViewRegion_List.StyleZindex() = intZIndex + 1;
                //objViewInfoENEx.objViewRegion_List.StyleLeft = (int)intCurrLeft;
                //objViewInfoENEx.objViewRegion_List.StyleTop = (int)intCurrTop;

                iDGHeight = objViewInfoENEx.objViewRegion_List.Height ?? 0 + 50;
               
                strCodeForCs.AppendFormat("\r\n" + "<div id = \"divList\" class = \"div_List\" ",
                  objViewInfoENEx.TabName, intCurrTop);
                strCodeForCs.AppendFormat("\r\n" + "runat = \"server\">");

                //生成GridView的代码;
                ///

                if (objViewInfoENEx.objViewRegion_List.IsInTab() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "<asp:GridView id = \"gv{0}\" runat = \"server\" ",
                      objViewInfoENEx.TabName, objViewInfoENEx.objViewRegion_List.StyleZindex());
                }
                else
                {
                    //					strCodeForCs.AppendFormat("\r\n" + "<asp:DataGrid id = \"dg{0}\" style = \"z-index: {1}; left: {4}px; position: {3}; top: {2}px\" runat = \"server\" ", 
                    //						objViewInfoENEx.TabName, objViewInfoENEx.objViewRegion_List.StyleZindex(), objViewInfoENEx.objViewRegion_List.StyleTop, objViewInfoENEx.objViewRegion_List.StylePosition,objViewInfoENEx.objViewRegion_List.StyleLeft);
                    //					隐藏高度
                    strCodeForCs.AppendFormat("\r\n" + "<asp:GridView id = \"gv{0}\" style = \"z-index: {1};\" runat = \"server\" ",
                      objViewInfoENEx.TabName, objViewInfoENEx.objViewRegion_List.StyleZindex());

                }
                //				strCodeForCs.AppendFormat("\r\n" + "Width = \"{0}px\" Height = \"{1}px\" AutoGenerateColumns = \"{2}\" ", 
                //					objViewInfoENEx.objViewRegion_List.Width, objViewInfoENEx.objViewRegion_List.Height, objViewInfoENEx.objViewRegion_List.AutoGenerateColumns());
                //					隐藏高度
                strCodeForCs.AppendFormat("\r\n" + "Width = \"100%\" AutoGenerateColumns = \"{1}\" ",
                  objViewInfoENEx.objViewRegion_List.Width, objViewInfoENEx.objViewRegion_List.AutoGenerateColumns());
                if (objViewInfoENEx.objViewRegion_List.AllowPaging() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "PageSize = \"{0}\" AllowPaging = \"true\" ",
                      objViewInfoENEx.objViewRegion_List.PageSize());
                }
                else
                {
                }
                ///设置是否排序
                if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "AllowSorting = \"true\" ");
                }

                strCodeForCs.AppendFormat("\r\n" + "OnSorting = \"gv{0}_Sorting\" ",
                  objViewInfoENEx.TabName);
                //				strCodeForCs.AppendFormat("\r\n" + "OnSelectedIndexChanged = \"gv{0}_SelectedIndexChanged\" ",
                //				objViewInfoENEx.TabName);
                if (objViewInfoENEx.objViewRegion_List.AllowPaging() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "OnPageIndexChanging = \"gv{0}_PageIndexChanging\" ",
                      objViewInfoENEx.TabName);
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel == true
                  && objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "OnRowCreated = \"gv{0}_RowCreated\"",
                      objViewInfoENEx.TabName);
                }
                strCodeForCs.AppendFormat("\r\n" + "OnRowCommand = \"gv{0}_RowCommand\"",
                  objViewInfoENEx.TabName);
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "OnRowDeleting = \"gv{0}_RowDeleting\" ",
                      objViewInfoENEx.TabName);
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "OnRowUpdating = \"gv{0}_RowUpdating\" ",
                      objViewInfoENEx.TabName);
                }

                strCodeForCs.Append("\r\n" + "BackColor = \"White\" ");
                strCodeForCs.Append("\r\n" + "BorderColor = \"#E7E7FF\" ");
                strCodeForCs.Append("\r\n" + "BorderStyle = \"None\" ");
                strCodeForCs.Append("\r\n" + "BorderWidth = \"1px\"");
                strCodeForCs.Append("\r\n" + "cellpadding = \"3\" ");
                strCodeForCs.Append("\r\n" + "GridLines = \"Horizontal\" ");
                strCodeForCs.Append("\r\n" + "Height = \"1px\" ");
                strCodeForCs.AppendFormat("\r\n" + "DataKeyNames = \"{0}\" ",
                      objViewInfoENEx.KeyFldNameLstStr);
                strCodeForCs.Append("\r\n" + "CssClass = \"GridValue\">");

                string strSortExpression;

                strCodeForCs.Append("\r\n" + "<Columns>");
                if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)    //判断是否需要单选按钮
                {
                    strCodeForCs.Append("\r\n" + "<asp:TemplateField>");
                    strCodeForCs.Append("\r\n" + "<ItemTemplate>");
                    strCodeForCs.AppendFormat("\r\n" + "<INPUT onclick = radioClick() type = radio value = '<%# DataBinder.Eval(Container.DataItem, \"{0}\")%>' name = RadioName>",
                      objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
                }
                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)    //判断是否需要复选按钮
                {
                    strCodeForCs.Append("\r\n" + "<asp:TemplateField HeaderText = \"全选\">");
                    strCodeForCs.Append("\r\n" + "<HeaderStyle Width = \"30px\" />");
                    strCodeForCs.Append("\r\n" + "<HeaderTemplate>");
                    strCodeForCs.Append("\r\n" + "<asp:LinkButton id = \"lbSelAll\" CommandName = \"lbSelAll\" runat = \"server\" CssClass = \"btn btn-link btn-sm text-nowrap\" Text = \"全选\"></asp:LinkButton>");
                    strCodeForCs.Append("\r\n" + "</HeaderTemplate>");
                    strCodeForCs.Append("\r\n" + "<ItemTemplate>");
                    strCodeForCs.AppendFormat("\r\n" + "<a name = \"A_{0}<%# Eval(\"{1}\").ToString().Trim() %>\"></a>",
                       objViewInfoENEx.TabName,
                       objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "<asp:CheckBox id = \"chkCheckRec\" runat = \"server\"></asp:CheckBox>");
                    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
                }

                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (objDGRegionFldsEx.IsNeedSort)   //判断是否需要排序
                    {
                        strSortExpression = "SortExpression = \"" + objDGRegionFldsEx.ObjFieldTabENEx.FldName + "\"";
                    }
                    else
                    {
                        strSortExpression = "";
                    }
                    strCodeForCs.AppendFormat("\r\n" + "<asp:BoundField DataField = \"{0}\" {2} HeaderText = \"{1}\"></asp:BoundField>",
                      objDGRegionFldsEx.ObjFieldTabENEx.FldName,
                      objDGRegionFldsEx.HeaderText,
                      strSortExpression);
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate == true)    //在DG中是否有修改按钮
                {
                    strCodeForCs.Append("\r\n" + "<asp:TemplateField HeaderText = \"修改\">");
                    strCodeForCs.Append("\r\n" + "<ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "<asp:LinkButton id = \"lbUpdate\" runat = \"Server\" CommandName = \"Update\" Text = \"修改\" CssClass = \"LinkButton_DefaInGv\"></asp:LinkButton>");
                    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate) //在DG中是否有修改按钮
                {
                    strCodeForCs.Append("\r\n" + "<asp:TemplateField HeaderText = \"修改\">");
                    strCodeForCs.Append("\r\n" + "<ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "<asp:LinkButton id = \"lbUpdate\" runat = \"Server\" CommandName = \"Update\" Text = \"修改\" CssClass = \"LinkButton_DefaInGv\" ></asp:LinkButton>");
                    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel == true)   //在DG中是否有删除按钮
                {
                    strCodeForCs.Append("\r\n" + "<asp:TemplateField HeaderText = \"删除\">");
                    strCodeForCs.Append("\r\n" + "<ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "<asp:LinkButton id = \"lbDelete\" runat = \"Server\" CommandName = \"Delete\" Text = \"删除\" CssClass = \"LinkButton_DefaInGv\"></asp:LinkButton>");
                    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail == true) //在DG中是否有详细信息按钮
                {
                    strCodeForCs.Append("\r\n" + "<asp:TemplateField>");
                    strCodeForCs.Append("\r\n" + "<ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "<asp:Button id = \"lbDetail\" runat = \"Server\" CommandName = \"Detail\" Text = \"详细信息\" CssClass = \"LinkButton_DefaInGv\"></asp:Button>");
                    strCodeForCs.Append("\r\n" + "</ItemTemplate>");
                    strCodeForCs.Append("\r\n" + "</asp:TemplateField>");
                }

                strCodeForCs.Append("\r\n" + "</Columns>"); //列结束
                                                            //分页模式
                strCodeForCs.Append("\r\n" + "<PagerTemplate>");
                strCodeForCs.Append("\r\n" + "<span class=\"text-secondary\">共有记录:</span>");
                strCodeForCs.Append("\r\n" + "<asp:Label ID = \"lblRecCount\" runat = \"server\" CssClass = \"text-info col-form-label-sm\" ForeColor = \"#000066\" Width = \"36px\">0</asp:Label>");
                strCodeForCs.Append("\r\n" + "<span class=\"text-secondary\">");
                strCodeForCs.Append("\r\n" + "<div style = \"display: inline; width: 16px; height: 13px\">");
                strCodeForCs.Append("\r\n" + "</div>");
                strCodeForCs.Append("\r\n" + "</span><span class=\"text-secondary\">总页数:</span>");
                strCodeForCs.Append("\r\n" + "<asp:Label ID = \"lblAllPages\" runat = \"server\" CssClass = \"text-info col-form-label-sm\" ForeColor = \"#000066\">0</asp:Label>");
                strCodeForCs.Append("\r\n" + "<div style = \"display: inline; width: 16px; height: 13px\">");
                strCodeForCs.Append("\r\n" + "</div>");
                strCodeForCs.Append("\r\n" + "<span class=\"text-secondary\">当前页:</span>");
                strCodeForCs.Append("\r\n" + "<asp:Label ID = \"lblCurrentPage\" runat = \"server\" CssClass = \"text-info col-form-label-sm\" ForeColor = \"#000066\">0</asp:Label>");
                strCodeForCs.Append("\r\n" + "<div style = \"display: inline; width: 16px; height: 13px\">");
                strCodeForCs.Append("\r\n" + "</div>");
                strCodeForCs.Append("\r\n" + "<asp:Button ID = \"btnPrevPage\" runat = \"server\" CssClass = \"btn btn-info\" Text = \"上一页\"");
                strCodeForCs.Append("\r\n" + "Width = \"50px\" CommandArgument = \"Prev\" CommandName = \"Page\" /><span style = \"font-family: Verdana\">");
                strCodeForCs.Append("\r\n" + "</span>");
                strCodeForCs.Append("\r\n" + "<asp:Button ID = \"btnNextPage\" runat = \"server\" CssClass = \"btn btn-info\" Text = \"下一页\"");
                strCodeForCs.Append("\r\n" + "Width = \"50px\" CommandArgument = \"Next\" CommandName = \"Page\" />");
                strCodeForCs.Append("\r\n" + "到第");
                strCodeForCs.Append("\r\n" + "<asp:TextBox ID = \"txtJump2Page\" runat = \"server\" CssClass = \"form-control form-control-sm\" Width = \"35px\"></asp:TextBox>页");
                strCodeForCs.Append("\r\n" + "<asp:Button ID = \"btnJumpPage\" runat = \"server\" CssClass = \"btn btn-info\" OnClick = \"btnJumpPage_Click\"");
                strCodeForCs.Append("\r\n" + "Text = \"确定\" Width = \"35px\" CommandName = \"Page\" />");

                strCodeForCs.Append("\r\n" + "<span class=\"text-secondary\">页记录数:</span>");
                strCodeForCs.Append("\r\n" + "<asp:DropDownList ID = \"ddlPagerRecCount\" runat = \"server\" CssClass = \"btn btn-outline-info\"");
                strCodeForCs.Append("\r\n" + "Width = \"55px\" AutoPostBack = \"True\" OnSelectedIndexChanged = \"ddlPagerRecCount_SelectedIndexChanged\">");
                strCodeForCs.Append("\r\n" + "<asp:ListItem>5</asp:ListItem>");
                strCodeForCs.Append("\r\n" + "<asp:ListItem>10</asp:ListItem>");
                strCodeForCs.Append("\r\n" + "<asp:ListItem>15</asp:ListItem>");
                strCodeForCs.Append("\r\n" + "<asp:ListItem>20</asp:ListItem>");
                strCodeForCs.Append("\r\n" + "<asp:ListItem>30</asp:ListItem>");
                strCodeForCs.Append("\r\n" + "<asp:ListItem>50</asp:ListItem>");
                strCodeForCs.Append("\r\n" + "<asp:ListItem>100</asp:ListItem>");
                strCodeForCs.Append("\r\n" + "<asp:ListItem>1000</asp:ListItem>");
                strCodeForCs.Append("\r\n" + "</asp:DropDownList>");

                strCodeForCs.Append("\r\n" + "<asp:CompareValidator ID = \"CompareValidator\" runat = \"server\" ControlToValidate = \"txtJump2Page\"");
                strCodeForCs.Append("\r\n" + "ErrorMessage = \"错误!\" ForeColor = \"DarkOrange\" Operator = \"DataTypeCheck\" Type = \"Integer\"></asp:CompareValidator>");
                strCodeForCs.Append("\r\n" + "</PagerTemplate>");
                strCodeForCs.Append("\r\n" + "<EmptyDataTemplate>");
                strCodeForCs.Append("\r\n" + "本列表无数据");
                strCodeForCs.Append("\r\n" + "</EmptyDataTemplate>");
                strCodeForCs.Append("\r\n" + "<FooterStyle CssClass = \"FooterStyle\" />");
                strCodeForCs.Append("\r\n" + "<RowStyle CssClass = \"RowStyle\" />");
                strCodeForCs.Append("\r\n" + "<EmptyDataRowStyle CssClass = \"EmptyDataRowStyle\" />");
                strCodeForCs.Append("\r\n" + "<SelectedRowStyle CssClass = \"SelectedRowStyle\" />");
                strCodeForCs.Append("\r\n" + "<PagerStyle CssClass = \"PagerStyle\" />");
                strCodeForCs.Append("\r\n" + "<HeaderStyle CssClass = \"HeaderStyle\" />");
                strCodeForCs.Append("\r\n" + "<EditRowStyle CssClass = \"EditRowStyle\" />");
                strCodeForCs.Append("\r\n" + "<AlternatingRowStyle CssClass = \"AlternatingRowStyle\" />");
                strCodeForCs.Append("\r\n" + "</asp:GridView>");
                //strCodeForCs.AppendFormat("\r\n" + "</td>");
                //strCodeForCs.AppendFormat("\r\n" + "</tr>");

                //<FooterStyle CssClass = "FooterStyle" />
                // <RowStyle CssClass = "RowStyle" />
                // <EmptyDataRowStyle CssClass = "EmptyDataRowStyle" />
                // <PagerStyle CssClass = "PagerStyle" />
                // <SelectedRowStyle CssClass = "SelectedRowStyle" />
                // <HeaderStyle CssClass = "HeaderStyle" />
                // <EditRowStyle CssClass = "EditRowStyle" />
                // <AlternatingRowStyle CssClass = "AlternatingRowStyle" />

                strCodeForCs.AppendFormat("\r\n" + "</div>");

                intCurrTop += 45;

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成Label控件
        /// </summary>
        /// <param name = "strDgStyleId"></param>
        /// <returns></returns>
        public string GenLabel(clsLabelStyleEN objLabelStyle, string strLabelId, string strLabelText)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            objLabelStyle.StyleZindex = intZIndex + 1;
            objLabelStyle.StyleLeft = (int)intCurrLeft;
            objLabelStyle.StyleTop = (int)intCurrTop;
            ///生成Label的代码;
            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" style = \"z-index: {1}; left: {2}px; position: {3}; top: {4}px\" ",
              strLabelId, objLabelStyle.StyleZindex, objLabelStyle.StyleLeft, objLabelStyle.StylePosition, objLabelStyle.StyleTop);
            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" Width = \"{1}px\" Height = \"{2}px\" ",
              objLabelStyle.Runat, objLabelStyle.Width, objLabelStyle.Height);
            strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\">",
              objLabelStyle.FontSize, objLabelStyle.FontName);

            strCodeForCs.AppendFormat("\r\n" + "{0}</asp:Label>",
              strLabelText);
            intZIndex += 1;

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成Label控件
        /// </summary>
        /// <param name = "strDgStyleId"></param>
        /// <returns></returns>
        public string GenLabelForTable(clsLabelStyleEN objLabelStyle, string strLabelId, string strLabelText)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            objLabelStyle.StyleZindex = intZIndex + 1;
            objLabelStyle.StyleLeft = (int)intCurrLeft;
            objLabelStyle.StyleTop = (int)intCurrTop;
            ///生成Label的代码;
            ///
            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" style = \"z-index: {1}; left: {2}px; position: {3}; top: {4}px\" ",
              strLabelId, objLabelStyle.StyleZindex, objLabelStyle.StyleLeft, objLabelStyle.StylePosition, objLabelStyle.StyleTop);
            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" Width = \"{1}px\" Height = \"{2}px\" ",
              objLabelStyle.Runat, objLabelStyle.Width, objLabelStyle.Height);
            strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\">",
              objLabelStyle.FontSize, objLabelStyle.FontName);

            strCodeForCs.AppendFormat("\r\n" + "{0}</asp:Label>",
              strLabelText);
            intZIndex += 1;

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成通用控件
        /// </summary>
        /// <param name = "strDgStyleId"></param>
        /// <returns></returns>
        public string GeneGenCtl(clsGenCtlStyleEN objGenCtlStyle, string strCtlTypeName, string strCtlId, string strCtlText)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            objGenCtlStyle.StyleZindex = intZIndex + 1;
            objGenCtlStyle.StyleLeft = (int)intCurrLeft;
            objGenCtlStyle.StyleTop = (int)intCurrTop;
            ///生成Label的代码;

            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" style = \"z-index: {2}; left: {3}px; ",
              strCtlTypeName, strCtlId, objGenCtlStyle.StyleZindex, objGenCtlStyle.StyleLeft);
            strCodeForCs.AppendFormat("\r\n" + "position: {0}; top: {1}px\" ",
              objGenCtlStyle.StylePosition, objGenCtlStyle.StyleTop);

            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" Width = \"{1}px\" Height = \"{2}px\">",
              objGenCtlStyle.Runat, objGenCtlStyle.Width, objGenCtlStyle.Height);
            strCodeForCs.AppendFormat("\r\n" + "</asp:{0}>",
              strCtlTypeName);
            intZIndex += 1;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成TextBox控件
        /// </summary>
        /// <param name = "strDgStyleId"></param>
        /// <returns></returns>
        public string GenTextBox(clsTextBoxStyleEN objTextBoxStyle, string strTextBoxId)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objTextBoxStyle.StyleZindex = intZIndex + 1;
                objTextBoxStyle.StyleLeft = (int)intCurrLeft;
                objTextBoxStyle.StyleTop = (int)intCurrTop;
                ///生成TextBox的代码;
                ///
                //生成控件的<开始标志>和<ID>
                strCodeForCs.AppendFormat("\r\n" + "<asp:TextBox id = \"{0}\" ",
                  strTextBoxId);
                //生成<控件样式Style>
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; left: {1}px; Width:{2}px; Height:{3}px ",
                  objTextBoxStyle.StyleZindex, objTextBoxStyle.StyleLeft,
                  objTextBoxStyle.Width, objTextBoxStyle.Height);
                strCodeForCs.AppendFormat("\r\n" + "position: {0}; top: {1}px\" ",
                  objTextBoxStyle.StylePosition, objTextBoxStyle.StyleTop);
                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objTextBoxStyle.Runat);
                //生成<字号>和<字体>
                strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ",
                  objTextBoxStyle.FontSize, objTextBoxStyle.FontName);
                //生成<是否只读>
                strCodeForCs.AppendFormat("\r\n" + "ReadOnly = \"{0}\" ", objTextBoxStyle.ReadOnly);
                //生成<文本模式> TextMode = "MultiLine"
                strCodeForCs.AppendFormat("\r\n" + "TextMode = \"{0}\" ", objTextBoxStyle.TextMode);

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "></asp:TextBox>");

                intZIndex += 1;

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成CheckBox控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenCheckBox(clsCheckStyleEN objCheckStyle, string strCheckId, string strCheckText)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objCheckStyle.StyleZindex = intZIndex + 1;
                objCheckStyle.StyleLeft = (int)intCurrLeft;
                objCheckStyle.StyleTop = (int)intCurrTop;

                ///生成CheckBox的代码;
                ///
                //生成控件的<开始标志>和<ID>
                strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox id = \"{0}\" ",
                  strCheckId);
                //生成<控件样式Style>
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; left: {1}px; Width:{2}px; Height:{3}px ",
                  objCheckStyle.StyleZindex, objCheckStyle.StyleLeft,
                  objCheckStyle.Width, objCheckStyle.Height);

                strCodeForCs.AppendFormat("\r\n" + "position: {0}; top: {1}px\" ",
                  objCheckStyle.StylePosition, objCheckStyle.StyleTop);
                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objCheckStyle.Runat);

                //生成<字号>和<字体>
                //strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //  objCheckStyle.FontSize, objCheckStyle.FontName);
                //生成<显示文本> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" ", strCheckText);

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "CssClass = \"Check_Defa\"></asp:CheckBox>");

                intZIndex += 1;

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 生成CheckBox控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenCheckBoxNoPosition(clsCheckStyleEN objCheckStyle, string strCheckId, string strCheckText)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objCheckStyle.StyleZindex = intZIndex + 1;
                objCheckStyle.StyleLeft = (int)intCurrLeft;
                objCheckStyle.StyleTop = (int)intCurrTop;

                ///生成CheckBox的代码;
                ///
                //生成控件的<开始标志>和<ID>
                strCodeForCs.Append("\r\n" + "<td>");
                strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox id = \"{0}\" ",
                  strCheckId);
                //生成<控件样式Style>
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{1}px; Height:{2}px;\" ",
                  objCheckStyle.StyleZindex,
                  objCheckStyle.Width, objCheckStyle.Height);
                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objCheckStyle.Runat);

                //生成<字号>和<字体>
                //strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //  objCheckStyle.FontSize, objCheckStyle.FontName);
                //生成<显示文本> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" ", strCheckText);

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "CssClass = \"Check_Defa\"></asp:CheckBox>");

                strCodeForCs.Append("\r\n" + "</td>");

                intZIndex += 1;

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成Button控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenButton(clsButtonStyleEN objButtonStyle, string strButtonId, string strButtonText, string strOnClick)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objButtonStyle.StyleZindex = intZIndex + 1;
                objButtonStyle.StyleLeft = (int)intCurrLeft;
                objButtonStyle.StyleTop = (int)intCurrTop;

                ///生成Button的代码;
                ///
                //生成控件的<开始标志>和<ID>
                strCodeForCs.AppendFormat("\r\n" + "<asp:Button id = \"{0}\" ",
                  strButtonId);
                //生成<控件样式Style>
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; left: {1}px; Width:{0}px; Height:{1}px;\" ",
                  objButtonStyle.StyleZindex, objButtonStyle.StyleLeft,
                  objButtonStyle.Width, objButtonStyle.Height);

                strCodeForCs.AppendFormat("\r\n" + "position: relative; top: {1}px\" ",
                  objButtonStyle.StylePosition, objButtonStyle.StyleTop);
                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objButtonStyle.Runat);

                //生成<字号>和<字体>
                //				strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //					objButtonStyle.FontSize, objButtonStyle.FontName);
                //生成<显示文本> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" CssClass = \"btn btn-primary btn-sm\" ", strButtonText);
                //生成单击事件
                strCodeForCs.AppendFormat("\r\n" + "OnClick = \"{0}\" ", strOnClick);

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "></asp:Button>");

                intZIndex += 1;

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 生成Button控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenButtonNoPosition(clsButtonStyleEN objButtonStyle, string strButtonId, string strButtonText, string strOnClick)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objButtonStyle.StyleZindex = intZIndex + 1;
                objButtonStyle.StyleLeft = (int)intCurrLeft;
                objButtonStyle.StyleTop = (int)intCurrTop;

                ///生成Button的代码;
                ///
                //生成控件的<开始标志>和<ID>
                strCodeForCs.AppendFormat("\r\n" + "<asp:Button id = \"{0}\" ",
                  strButtonId);
                //生成<控件样式Style>
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{2}px; Height:{3}px;\" ",
                  objButtonStyle.StyleZindex, objButtonStyle.StyleLeft,
                  objButtonStyle.Width, objButtonStyle.Height);

                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objButtonStyle.Runat);

                //生成<字号>和<字体>
                //				strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //					objButtonStyle.FontSize, objButtonStyle.FontName);
                //生成<显示文本> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" CssClass = \"btn btn-primary btn-sm\" ", strButtonText);
                //生成单击事件
                strCodeForCs.AppendFormat("\r\n" + "OnClick = \"{0}\" ", strOnClick);

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "></asp:Button>");

                intZIndex += 1;

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成Button控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string Gen_Mvc_ButtonInForm(clsButtonStyleEN objButtonStyle, string strButtonId,
            string strButtonText, string strOnClick = "")
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objButtonStyle.StyleZindex = intZIndex + 1;
                objButtonStyle.StyleLeft = (int)intCurrLeft;
                objButtonStyle.StyleTop = (int)intCurrTop;

                ///生成Button的代码;
                ///   <td>
                //    < input type = "submit" value = "查询" class="btn btn-default" />
                //</td>

                //<td>
                //    <a href = "javascript:void(0);" class="easyui-linkbutton" data-options="iconCls:'icon-clear' " onclick="resetSearch()">清空</a>
                //</td>
                //生成控件的<开始标志>和<ID>
                strCodeForCs.AppendFormat("\r\n" + "<input id = \"{0}\"  type=\"submit\" ",
                  strButtonId);
                //生成<控件样式Style>
                //生成<高度>和<宽度>
                //strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{2}px; Height:{3}px;\" ",
                //  objButtonStyle.StyleZindex, objButtonStyle.StyleLeft,
                //  objButtonStyle.Width, objButtonStyle.Height);

                //生成运行模式是否在服务器运行
                //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                //  objButtonStyle.Runat);

                //生成<字号>和<字体>
                //				strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //					objButtonStyle.FontSize, objButtonStyle.FontName);
                //生成<显示文本> 
                strCodeForCs.AppendFormat("\r\n" + "value = \"{0}\" class = \"btn btn-default\" ", strButtonText);
                //生成单击事件
                if (string.IsNullOrEmpty(strOnClick) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "OnClick = \"{0}\" ", strOnClick);
                }
                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "/>");

                intZIndex += 1;

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成DropDownList控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenDropDownLst(clsDropDownLstStyleEN objDropDownLstStyle, string strDropDownLstId)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objDropDownLstStyle.StyleZindex = intZIndex + 1;
                objDropDownLstStyle.StyleLeft = (int)intCurrLeft;
                objDropDownLstStyle.StyleTop = (int)intCurrTop;

                ///生成DropDownList的代码;

                //生成控件的<开始标志>和<ID>
                strCodeForCs.AppendFormat("\r\n" + "<asp:DropDownList id = \"{0}\" ",
                  strDropDownLstId);
                //生成<控件样式Style>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; left: {1}px; ",
                  objDropDownLstStyle.StyleZindex, objDropDownLstStyle.StyleLeft);
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "position: {0}; top: {1}px; Width:{2}px; Height:{3}px;\" ",
                  objDropDownLstStyle.StylePosition, objDropDownLstStyle.StyleTop,
                  objDropDownLstStyle.Width, objDropDownLstStyle.Height);

                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objDropDownLstStyle.Runat);

                //生成<字号>和<字体>
                strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ",
                  objDropDownLstStyle.FontSize, objDropDownLstStyle.FontName);
                //生成<前景色>
                if (objDropDownLstStyle.ForeColor != "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "ForeColor = \"{0}\" ", objDropDownLstStyle.ForeColor);
                }
                //生成<背景色>
                if (objDropDownLstStyle.BackColor != "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "BackColor = \"{0}\" ", objDropDownLstStyle.BackColor);
                }
                //生成<文本字段>
                if (objDropDownLstStyle.DataTextField != "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "DataTextField = \"{0}\" ", objDropDownLstStyle.DataTextField);
                }
                //生成<值字段>
                if (objDropDownLstStyle.DataValueField != "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "DataValueField = \"{0}\" ", objDropDownLstStyle.DataValueField);
                }
                //生成<是否可见>
                if (objDropDownLstStyle.Visible == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "Visible = \"{0}\" ", objDropDownLstStyle.Visible);
                }

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "></asp:DropDownList>");

                intZIndex += 1;

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成{组合控件},即左边的标签,和右边的输入条件的控件
        /// </summary>
        /// <param name = "objLabelStyle"></param>
        /// <param name = "strLabelId"></param>
        /// <param name = "strLabelText"></param>
        /// <param name = "objGenCtlStyle"></param>
        /// <param name = "strCtlTypeName"></param>
        /// <param name = "strCtlId"></param>
        /// <returns></returns>
        public string GenCombineCtl(clsLabelStyleEN objLabelStyle, string strLabelId, string strLabelText,
          clsGenCtlStyleEN objGenCtlStyle, string strCtlTypeName, string strCtlId)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            objLabelStyle.StyleZindex = intZIndex + 1;
            objLabelStyle.StyleLeft = (int)intCurrLeft;
            objLabelStyle.StyleTop = (int)intCurrTop;
            ///生成Label的代码;
            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" style = \"z-index: {1}; left: {2}px; position: absolute; top: {4}px; Width:{5}px; Height:{6}px;\" ",
              strLabelId, objLabelStyle.StyleZindex, objLabelStyle.StyleLeft, objLabelStyle.StylePosition, objLabelStyle.StyleTop, objLabelStyle.Width, objLabelStyle.Height);
            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"NameLabel\">",
              objLabelStyle.Runat);
            strCodeForCs.AppendFormat("{0}</asp:Label>",
              strLabelText);

            intZIndex += 1;

            objGenCtlStyle.StyleZindex = intZIndex + 1;
            objGenCtlStyle.StyleLeft = (int)intCurrLeft + objLabelStyle.Width + 5;
            //objGenCtlStyle.StyleLeft = (int)intCurrLeft + 5;
            objGenCtlStyle.StyleTop = (int)intCurrTop;
            ///生成右边控件的代码;

            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" style = \"z-index: {2}; left: {3}px; ",
              strCtlTypeName, strCtlId, objGenCtlStyle.StyleZindex, objGenCtlStyle.StyleLeft);
            strCodeForCs.AppendFormat("\r\n" + "position: absolute; top: {1}px; Width:{2}px; Height:{3}px;\" ",
              objGenCtlStyle.StylePosition, objGenCtlStyle.StyleTop, objGenCtlStyle.Width, objGenCtlStyle.Height);

            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"TextBox_Defa\">",
              objGenCtlStyle.Runat);
            strCodeForCs.AppendFormat("\r\n" + "</asp:{0}>",
              strCtlTypeName);
            intZIndex += 1;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成{组合控件},即左边的标签,和右边的输入条件的控件
        /// </summary>
        /// <param name = "objLabelStyle"></param>
        /// <param name = "strLabelId"></param>
        /// <param name = "strLabelText"></param>
        /// <param name = "objGenCtlStyle"></param>
        /// <param name = "strCtlTypeName"></param>
        /// <param name = "strCtlId"></param>
        /// <returns></returns>
        public string Gen_Mvc_CombineCtlWithFor(clsLabelStyleEN objLabelStyle, string strFldName, string strLabelId, string strLabelText,
          clsGenCtlStyleEN objGenCtlStyle, string strCtlTypeName, string strCtlId, string strDsTabId, string strDdlItemsOptionId)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objLabelStyle.StyleZindex = intZIndex + 1;
                objLabelStyle.StyleLeft = (int)intCurrLeft;
                objLabelStyle.StyleTop = (int)intCurrTop;
                ///生成Label的代码;

                strCodeForCs.Append("\r\n" + "<td>");
                strCodeForCs.AppendFormat("\r\n" + "@Html.LabelFor(model => model.qryModel4{0}.{1}, htmlAttributes: new {2} @class = \"control -label col-md-4\", style = \"width:100px\" {3})",
                    objViewInfoENEx.TabName_Out, strFldName, "{", "}");

                //strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" style = \"z-index: {1};\" ",
                //  strLabelId, objLabelStyle.StyleZindex, objLabelStyle.Width, objLabelStyle.Height);
                //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"NameLabel\">",
                //  objLabelStyle.Runat);
                //strCodeForCs.AppendFormat("{0}</asp:Label>",
                //  strLabelText);
                strCodeForCs.Append("\r\n" + "</td>");

                intZIndex += 1;

                objGenCtlStyle.StyleZindex = intZIndex + 1;
                objGenCtlStyle.StyleLeft = (int)intCurrLeft + objLabelStyle.Width + 5;
                //objGenCtlStyle.StyleLeft = (int)intCurrLeft + 5;
                objGenCtlStyle.StyleTop = (int)intCurrTop;
                ///生成右边控件的代码;
                strCodeForCs.Append("\r\n" + "<td>");
                switch (strCtlTypeName)
                {
                    case "TextBox":
                strCodeForCs.AppendFormat("\r\n" + "@Html.EditorFor(model => model.qryModel4{0}.{1}, new {{ htmlAttributes = new {{ @class = \"easyui -textbox\" }} }})",
                    objViewInfoENEx.TabName_Out, strFldName);
                        break;
                    case "DropDownList":
                        if (strDdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "@Html.DropDownListFor(model => model.qryModel4{0}.{1}, ViewData[\"TrueAndFalseList\"] as List<SelectListItem>)",
                                objViewInfoENEx.TabName_Out, strFldName);
                        }
                        else
                        {
                            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strDsTabId, objProjectsENEx.PrjId);
                            strCodeForCs.AppendFormat("\r\n" + "@Html.DropDownListFor(model => model.qryModel4{0}.{1}, ViewData[\"{2}List\"] as List<SelectListItem>)",
                                objViewInfoENEx.TabName_Out, strFldName, objPrjTab.TabName);
                        }
                        break;
                    default:
                        string strMsg = string.Format("控件名:{1}在Switch没有处理,请检查!({0})",
                          clsStackTrace.GetCurrClassFunction(), strCtlTypeName);
                        throw new Exception(strMsg);
                       
            }

                //strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" style = \"z-index: {2}; \" ",
                //  strCtlTypeName, strCtlId, objGenCtlStyle.StyleZindex, objGenCtlStyle.Width, objGenCtlStyle.Height);

                //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"TextBox_Defa\">",
                //  objGenCtlStyle.Runat);
                //strCodeForCs.AppendFormat("\r\n" + "</asp:{0}>",
                //  strCtlTypeName);
                strCodeForCs.Append("\r\n" + "</td>");

                intZIndex += 1;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成组合控件时出错!错误:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }



        #endregion

        ///以下均是界面层内容(VIEW) == == = 



        public bool DispDataGridRegionCtrl(System.Web.UI.WebControls.PlaceHolder phDataGridRegion, clsViewInfoENEx objViewInfoENEx)
        {

            Table objTable = new Table();//创建一个表格
            Table objTable4JumpPage = new Table();//创建一个表格
            objTable.BorderWidth = Unit.Parse("4");
            objTable.BorderColor = System.Drawing.Color.BurlyWood;

            objTable.Width = Unit.Parse("100%");
            TableRow tabRow;
            TableCell cell1;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.TextBox txt1;
            System.Web.UI.WebControls.Button btn1;

            tabRow = new TableRow();//创建一行
            if (objViewInfoENEx.objViewRegion_List.IsRadio() || objViewInfoENEx.objViewRegion_List.IsCheck())
            {
                cell1 = new TableCell();//创建单元格,也就是第一列

                lbl1 = new Label();
                lbl1.Text = objViewInfoENEx.objInRelaTab.TabCnName + "列表";
                lbl1.CssClass = "h6";
                //				lbl1.Style.Add("position","absolute");
                //				lbl1.Style.Add("left","4px");
                //				lbl1.Style.Add("top","4px");
                cell1.Controls.Add(lbl1);
                lbl1 = new Label();
                lbl1.Text = "　　　　";
                lbl1.CssClass = "h6";
                cell1.Controls.Add(lbl1);
                btn1 = MakeButton("添加记录");
                cell1.Controls.Add(btn1);
                tabRow.Cells.Add(cell1);
                btn1 = MakeButton("修改记录");
                cell1.Controls.Add(btn1);
                tabRow.Cells.Add(cell1);
                btn1 = MakeButton("删除记录");
                cell1.Controls.Add(btn1);
                tabRow.Cells.Add(cell1);
                btn1 = MakeButton("导出Excel");
                cell1.Controls.Add(btn1);
                tabRow.Cells.Add(cell1);
                objTable.Rows.Add(tabRow);//添加到表格中
            }
            ///新建表行,专用于放Datagrid
            tabRow = new TableRow();//创建一行
            cell1 = new TableCell();//创建单元格,也就是第一列
            DataGrid dg = MakeGrid();
            cell1.Controls.Add(dg);
            cell1.HorizontalAlign = HorizontalAlign.Left;
            tabRow.Cells.Add(cell1);
            objTable.Rows.Add(tabRow);

            ///新建表行,专用于放跳页
            ///
            tabRow = new TableRow();//创建一行
            cell1 = new TableCell();//创建单元格,也就是第一列
                                    //cell1.Font.Name = "verdana";
                                    //cell1.Font.Size = FontUnit.Parse("x-small");
            cell1.CssClass = "NameLabel";
            cell1.BackColor = System.Drawing.Color.Plum;    // "#c0c0c0";
            cell1.Text = "共有记录:";
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            lbl1 = MakeLabel("0");
            lbl1.Width = 16;
            cell1.Controls.Add(lbl1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
                                    //cell1.Font.Name = "verdana";
                                    //cell1.Font.Size = FontUnit.Parse("x-small");
            cell1.CssClass = "NameLabel";
            cell1.BackColor = System.Drawing.Color.Plum;    // "#c0c0c0";
            cell1.Text = "总页数:";
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            lbl1 = MakeLabel("0");
            lbl1.Width = 16;
            cell1.Controls.Add(lbl1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
                                    //cell1.Font.Name = "verdana";
                                    //cell1.Font.Size = FontUnit.Parse("x-small");
            cell1.CssClass = "NameLabel";
            cell1.BackColor = System.Drawing.Color.Plum;    // "#c0c0c0";
            cell1.Text = "当前页:";
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            lbl1 = MakeLabel("0");
            lbl1.Width = 16;
            cell1.Controls.Add(lbl1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            btn1 = MakeButton("上一页");
            btn1.Width = 50;
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            btn1 = MakeButton("下一页");
            btn1.Width = 50;
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
                                    //cell1.Font.Name = "verdana";
                                    //cell1.Font.Size = FontUnit.Parse("x-small");
            cell1.CssClass = "NameLabel";
            cell1.BackColor = System.Drawing.Color.Plum;    // "#c0c0c0";
            cell1.Text = "到第:";
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            txt1 = MakeTextBox("1");
            txt1.Width = 35;
            cell1.Controls.Add(txt1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//创建单元格,也就是第一列
            btn1 = MakeButton("确定");
            btn1.Width = 35;
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);

            objTable4JumpPage.Rows.Add(tabRow);

            tabRow = new TableRow();
            cell1 = new TableCell();//创建单元格,也就是第一列
            cell1.Controls.Add(objTable4JumpPage);
            tabRow.Cells.Add(cell1);
            objTable.Rows.Add(tabRow);
            phDataGridRegion.Controls.Add(objTable);
            //			phDataGridRegion.Controls.Add(objTable4JumpPage);

            return true;
        }
        public DataGrid MakeGrid()
        {

            DataGrid mygrid = new DataGrid();
            mygrid.CellPadding = 2;
            mygrid.Attributes.Add("align", "center");
            mygrid.CellSpacing = 0;
            mygrid.Width = 700;
            mygrid.BorderWidth = 1;
            mygrid.BorderColor = ColorTranslator.FromHtml("Black");
            mygrid.AutoGenerateColumns = false;
            mygrid.ForeColor = ColorTranslator.FromHtml("Black");
            mygrid.Font.Size = 9;
            mygrid.Font.Name = "宋体";
            mygrid.AllowSorting = true;
            if (objViewInfoENEx.objViewRegion_List.AllowPaging() == true)
            {
                mygrid.AllowPaging = true;
                mygrid.PageSize = objViewInfoENEx.objViewRegion_List.PageSize();
                mygrid.ShowFooter = true;
                mygrid.PagerStyle.Mode = PagerMode.NumericPages;
            }
            ///sort命令的事件处理器

            //			mygrid.SortCommand += new DataGridSortCommandEventHandler(Sort_Grid);

            ///设置headerstyle
            mygrid.HeaderStyle.BackColor = ColorTranslator.FromHtml("Gold");
            mygrid.HeaderStyle.ForeColor = ColorTranslator.FromHtml("Black");
            mygrid.HeaderStyle.Font.Name = "宋体";
            mygrid.HeaderStyle.Font.Size = 9;
            mygrid.HeaderStyle.Font.Bold = true;
            mygrid.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;

            ///设置alternating style
            mygrid.AlternatingItemStyle.BackColor = ColorTranslator.FromHtml("Silver");
            mygrid.AlternatingItemStyle.ForeColor = ColorTranslator.FromHtml("Black");

            ///设置itemstyle
            mygrid.ItemStyle.HorizontalAlign = HorizontalAlign.Left;

            ///创建绑定列和属性
            int intColNo = 0;   //列序号
                                ///如果有单选按钮
            if (objViewInfoENEx.objViewRegion_List.IsRadio())
            {
                TemplateColumn tempCol = new TemplateColumn();
                ColumnTemplate_Radio myColTemp = new ColumnTemplate_Radio();

                ///设置模板列属性和ItemStyle模板
                tempCol.HeaderText = "选择";
                tempCol.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
                tempCol.ItemStyle.BackColor = ColorTranslator.FromHtml("#FFF778");
                tempCol.ItemStyle.HorizontalAlign = HorizontalAlign.Center;

                ///创建列模板。
                ///列模板从ITemplate继承
                tempCol.ItemTemplate = myColTemp;
                mygrid.Columns.AddAt(intColNo++, tempCol);

            }
            ///如果有复选按钮
            if (objViewInfoENEx.objViewRegion_List.IsCheck())
            {
                TemplateColumn tempCol = new TemplateColumn();
                ColumnTemplate_Chk myColTemp = new ColumnTemplate_Chk();

                ///设置模板列属性和ItemStyle模板
                tempCol.HeaderText = "全选";
                tempCol.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
                tempCol.ItemStyle.BackColor = ColorTranslator.FromHtml("#FFF778");
                tempCol.ItemStyle.HorizontalAlign = HorizontalAlign.Center;

                ///创建列模板。
                ///列模板从ITemplate继承
                tempCol.ItemTemplate = myColTemp;
                mygrid.Columns.AddAt(intColNo++, tempCol);

            }
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                BoundColumn boundCol = new BoundColumn();
                boundCol.HeaderText = objDGRegionFldsEx.HeaderText;
                boundCol.DataField = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                boundCol.SortExpression = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                mygrid.Columns.AddAt(intColNo++, boundCol);
                //					mygrid.Columns.AddAt(1, LastName);
            }

            if (objViewInfoENEx.objViewRegion_List.IsHaveUpdBtn())
            {
                ButtonColumn objButtonCol = new ButtonColumn();
                objButtonCol.HeaderText = "修改";
                objButtonCol.Text = "修改";
                //				objButtonCol.DataField = objViewCtlField.FldName;
                //				objButtonCol.SortExpression = objViewCtlField.FldName;
                objButtonCol.CommandName = "Update";
                mygrid.Columns.AddAt(intColNo++, objButtonCol);
            }

            if (objViewInfoENEx.objViewRegion_List.IsHaveDelBtn())
            {
                ButtonColumn objButtonCol = new ButtonColumn();
                objButtonCol.HeaderText = "删除";
                objButtonCol.Text = "删除";
                //				objButtonCol.DataField = objViewCtlField.FldName;
                //				objButtonCol.SortExpression = objViewCtlField.FldName;
                objButtonCol.CommandName = "Delete";
                mygrid.Columns.AddAt(intColNo++, objButtonCol);

                //				TemplateColumn tempCol = new TemplateColumn();
                //				ColumnTemplate myColTemp = new ColumnTemplate();
                //
                //				///设置模板列属性和ItemStyle模板
                //				tempCol.HeaderText = "删除";
                //				tempCol.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
                //				tempCol.ItemStyle.BackColor = ColorTranslator.FromHtml("#FFF778");
                //				tempCol.ItemStyle.HorizontalAlign = HorizontalAlign.Center;
                //				Button lb = new Button();
                //				lb.Text = "删除";
                //				///创建列模板。
                //				///列模板从ITemplate继承
                //				myColTemp.InstantiateIn(lb);
                //				tempCol.ItemTemplate = myColTemp;
                //				
                ////<asp:TemplateColumn>
                ////<ItemTemplate>
                ////<asp:Button id = "lbnDelete" runat = "Server" CommandName = "Delete" Text = "删除"></asp:Button>
                ////</ItemTemplate>
                ////</asp:TemplateColumn>
                ////
                //				mygrid.Columns.AddAt(intColNo++, tempCol);

            }
            if (objViewInfoENEx.objViewRegion_List.IsHaveDetailBtn())
            {
                ButtonColumn objButtonCol = new ButtonColumn();
                objButtonCol.HeaderText = "详细";
                objButtonCol.Text = "详细";
                //				objButtonCol.DataField = objViewCtlField.FldName;
                //				objButtonCol.SortExpression = objViewCtlField.FldName;
                objButtonCol.CommandName = "Update";
                mygrid.Columns.AddAt(intColNo++, objButtonCol);
            }

            mygrid.DataSource = MakeTestTable();

            mygrid.DataBind();
            return mygrid;
        }
        private DataView MakeTestTable()
        {
            // Create a new DataTable.
            System.Data.DataTable myDataTable = new DataTable("TestTable");
            // Declare variables for DataColumn and DataRow objects.
            DataColumn myDataColumn;
            DataRow myDataRow;
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                // Create new DataColumn, set DataType, ColumnName and add to DataTable.  
                myDataColumn = new DataColumn();
                myDataColumn.DataType = System.Type.GetType("System.String");
                myDataColumn.ColumnName = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                myDataColumn.ReadOnly = true;
                myDataColumn.Unique = false;
                // Add the Column to the DataColumnCollection.
                myDataTable.Columns.Add(myDataColumn);
            }
            for (int i = 0; i <= 2; i++)
            {
                myDataRow = myDataTable.NewRow();
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    myDataRow[objDGRegionFldsEx.ObjFieldTabENEx.FldName] = i.ToString();
                }
                //				myDataRow["id"] = i;
                //				myDataRow["ParentItem"] = "ParentItem " + i;
                myDataTable.Rows.Add(myDataRow);
            }
            DataView myView = myDataTable.DefaultView;
            //myView.Sort = SortExpression;
            //Response.Write(sql);
            return myView;
        }

        public static Button MakeButton(string strButtonName)
        {
            System.Web.UI.WebControls.Button btn1;
            btn1 = new Button();
            btn1.Text = strButtonName;
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;
            return btn1;
        }

        public static Label MakeLabel(string strLabelText)
        {
            System.Web.UI.WebControls.Label lbl1;
            lbl1 = new Label();
            lbl1.Text = strLabelText;
            lbl1.CssClass = "NameLabel";

            //lbl1.Font.Name = "verdana";
            //lbl1.Font.Size = FontUnit.Parse("x-small");
            lbl1.Width = 60;
            return lbl1;
        }
        public static TextBox MakeTextBox(string strTextBoxText)
        {
            System.Web.UI.WebControls.TextBox txt1;
            txt1 = new TextBox();
            txt1.Text = "";
            txt1.CssClass = "TextBox_Defa";
            //txt1.Font.Name = "verdana";
            //txt1.Font.Size = FontUnit.Parse("x-small");
            txt1.Width = 60;
            return txt1;
        }
        public static CheckBox MakeCheckBox(string strCheckBoxText)
        {
            System.Web.UI.WebControls.CheckBox chk1;
            chk1 = new CheckBox();
            chk1.Text = strCheckBoxText;
            chk1.CssClass = "Check_Defa";
            //chk1.Font.Name = "verdana";
            //chk1.Font.Size = FontUnit.Parse("x-small");
            chk1.Width = 100;
            return chk1;
        }


        public static bool DispEditRegionCtrl(System.Web.UI.WebControls.PlaceHolder phQryRegion, clsViewInfoENEx objViewInfoENEx)
        {
            int intColNum = objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0;

            Table tb = new Table();//创建一个表格
            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");
            int iCtlNum = 0;
            TableRow tr;
            TableCell cell1, cell2;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.CheckBox chk1;
            System.Web.UI.WebControls.TextBox txt1;
            System.Web.UI.WebControls.DropDownList ddl1;
            System.Web.UI.WebControls.Button btn1;
            System.Web.UI.WebControls.Panel panel1;

            panel1 = new Panel();
            panel1.Width = 700;
            panel1.Height = 32;


            //	<asp:label id = "Label1" style = "z-index: 109; left: 0px; position: absolute; top: 1px" runat = "server"
            //	CssClass = "h6">编辑字段属性</asp:label></DIV>
            lbl1 = new Label();
            lbl1.Text = objViewInfoENEx.objInRelaTab.TabCnName + "字段属性";
            lbl1.CssClass = "h6";
            //lbl1.Style.Add("position", "absolute");
            //lbl1.Style.Add("left", "4px");
            //lbl1.Style.Add("top", "4px");
            lbl1.Width = 400;
            panel1.Controls.Add(lbl1);

            btn1 = new Button();
            btn1.Text = "添加";
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;

            //<asp:Button id = "btnOKUpd" style = "z-index: 106; left: 720px; position: absolute; top: 0px" runat = "server"
            //												Font-Names = "verdana" Font-Size = "x-Small" Height = "24px" Width = "80px" Text = "添加"></asp:Button>

            //btn1.Style.Add("position","absolute");
            //btn1.Style.Add("left","620px");
            //btn1.Style.Add("top","4px");
            panel1.Controls.Add(btn1);

            tr = new TableRow();//创建一行
            cell1 = new TableCell();//创建单元格,也就是第一列
            cell1.Controls.Add(panel1);
            cell1.ColumnSpan = intColNum * 2;
            tr.Cells.Add(cell1);
            //			for(int i = 0; i<intColNum*2-1; i++)
            //			{
            //				cell1 = new TableCell();//创建单元格,也就是第一列
            //				tr.Cells.Add(cell1);   
            //			}
            tb.Rows.Add(tr);//添加到表格中


            tr = new TableRow();//创建一行
            bool bolIsEndRow = false;
            foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {
                if (iCtlNum % (intColNum * 2) == 0)
                {
                    tr = new TableRow();//创建一行
                    bolIsEndRow = false;
                }

                switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                {
                    case "CheckBox":
                        chk1 = new CheckBox();
                        chk1.Text = objEditRegionFldsEx.LabelCaption;
                        //chk1.Font.Name = "verdana";
                        //chk1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        chk1.Width = 100;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(chk1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell1.Text = "";
                        tr.Cells.Add(cell2);

                        break;
                    case "TextBox":
                        lbl1 = new Label();
                        lbl1.Text = objEditRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        txt1 = new TextBox();
                        txt1.Text = "";
                        //txt1.Font.Name = "verdana";
                        //txt1.Font.Size = FontUnit.Parse("x-small");
                        txt1.CssClass = "TextBox_Defa";
                        txt1.Width = 60;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell2.Controls.Add(txt1);
                        tr.Cells.Add(cell2);
                        break;
                    case "DropDownList":
                        lbl1 = new Label();
                        lbl1.Text = objEditRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        ddl1 = new DropDownList();
                        //							ddl1.Text = "";
                        //ddl1.Font.Name = "verdana";
                        //ddl1.Font.Size = FontUnit.Parse("x-small");
                        ddl1.CssClass = "DropDown_Defa";
                        ddl1.Width = 60;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell2.Controls.Add(ddl1);
                        tr.Cells.Add(cell2);
                        break;

                    default:
                        lbl1 = new Label();
                        lbl1.Text = objEditRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.Width = 60;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        txt1 = new TextBox();
                        txt1.Text = "";
                        //txt1.Font.Name = "verdana";
                        //txt1.Font.Size = FontUnit.Parse("x-small");
                        txt1.Width = 60;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell2.Controls.Add(txt1);
                        tr.Cells.Add(cell2);
                        break;
                }

                if (iCtlNum % (intColNum * 2) == (intColNum * 2 - 1))
                {
                    tb.Rows.Add(tr);//添加到表格中
                    bolIsEndRow = true;
                }
                iCtlNum++;
            }
            if (bolIsEndRow == false)
            {
                tb.Rows.Add(tr);//添加到表格中
            }

            ///生成查询按钮的代码;
            //			strCodeForCs.Append("\r\n" + GenButton(objButtonStyle,"btnQuery","查询"));
            phQryRegion.Controls.Add(tb);


            return true;
        }
        //显示预览<Excel导出区域>的控件
        public static bool DispExcelExportRegionCtrl(System.Web.UI.WebControls.PlaceHolder phExcelExportRegion, clsViewInfoENEx objViewInfoENEx)
        {

            Table tb = new Table();//创建一个表格

            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");
            TableRow tr;
            TableCell cell1;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.CheckBox chk1;
            System.Web.UI.WebControls.Button btn1;
            int intColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            int intIndex = 1;
            foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in objViewInfoENEx.arrExcelExportRegionFldSet)
            {
                tr = new TableRow();//创建一行
                                    //序号
                lbl1 = new Label();
                lbl1.Text = intIndex.ToString();
                //lbl1.Font.Name = "verdana";
                //lbl1.Font.Size = FontUnit.Parse("x-small");
                lbl1.CssClass = "NameLabel";
                lbl1.Width = 20;
                cell1 = new TableCell();//创建单元格,也就是第一列
                cell1.Controls.Add(lbl1);
                tr.Cells.Add(cell1);

                //复选框
                chk1 = new CheckBox();
                chk1.Text = "";
                //chk1.Font.Name = "verdana";
                //chk1.Font.Size = FontUnit.Parse("x-small");
                chk1.CssClass = "Check_Defa";
                chk1.Width = 30;
                cell1 = new TableCell();//创建单元格,也就是第一列
                cell1.Controls.Add(chk1);
                tr.Cells.Add(cell1);

                //字段名(列名)
                lbl1 = new Label();
                lbl1.Text = objExcelExportRegionFldsEx.ColCaption;
                //lbl1.Font.Name = "verdana";
                //lbl1.Font.Size = FontUnit.Parse("x-small");
                lbl1.CssClass = "NameLabel";
                lbl1.Width = 120;
                cell1 = new TableCell();//创建单元格,也就是第一列
                cell1.Controls.Add(lbl1);
                tr.Cells.Add(cell1);
                tb.Rows.Add(tr);//添加到表格中
                intIndex++;
            }
            //导出EXCEL的按钮
            tr = new TableRow();//创建一行
                                //空两格
            cell1 = new TableCell();//创建单元格,也就是第一列
            tr.Cells.Add(cell1);
            cell1 = new TableCell();//创建单元格,也就是第一列
            tr.Cells.Add(cell1);

            btn1 = new Button();
            btn1.Text = "导出Excel";
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;
            cell1 = new TableCell();//创建单元格,也就是第一列
            cell1.Controls.Add(btn1);
            tr.Cells.Add(cell1);
            tb.Rows.Add(tr);//添加到表格中
                            ///生成查询按钮的代码;
            //			strCodeForCs.Append("\r\n" + GenButton(objButtonStyle,"btnQuery","查询"));
            phExcelExportRegion.Controls.Add(tb);


            return true;
        }
        //显示预览<ListView区域>的控件
        public static bool DispListViewRegionCtrl(System.Web.UI.WebControls.PlaceHolder phListViewRegion, clsViewInfoENEx objViewInfoENEx)
        {

            Table tb = new Table();//创建一个表格

            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");
            TableRow tr, tabRow;
            TableCell cell1;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.Button btn1;
            int intColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;

            Table objTable = new Table();//创建一个表格

            tabRow = new TableRow();//创建一行

            cell1 = new TableCell();//创建单元格,也就是第一列
            lbl1 = new Label();
            lbl1.Text = objViewInfoENEx.objInRelaTab.TabCnName + "列表";
            lbl1.CssClass = "h6";
            //				lbl1.Style.Add("position","absolute");
            //				lbl1.Style.Add("left","4px");
            //				lbl1.Style.Add("top","4px");
            lbl1.CssClass = "NameLabel";
            cell1.Controls.Add(lbl1);
            lbl1 = new Label();
            lbl1.Text = "　　　　";
            lbl1.CssClass = "h6";
            cell1.Controls.Add(lbl1);
            btn1 = MakeButton("添加记录");
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);
            btn1 = MakeButton("修改记录");
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);
            btn1 = MakeButton("删除记录");
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);
            btn1 = MakeButton("导出Excel");
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);
            objTable.Rows.Add(tabRow);//添加到表格中


            int intIndex = 1;
            tr = new TableRow();//创建一行
            foreach (clsDGRegionFldsENEx ObjLstViewRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                //字段名(列名)
                lbl1 = new Label();
                lbl1.Text = ObjLstViewRegionFldsEx.HeaderText;
                //lbl1.Font.Name = "verdana";
                //lbl1.Font.Size = FontUnit.Parse("x-small");
                lbl1.CssClass = "NameLabel";
                lbl1.Font.Bold = true;
                lbl1.Width = 60;
                cell1 = new TableCell();//创建单元格,也就是第一列
                cell1.Controls.Add(lbl1);
                tr.Cells.Add(cell1);
                intIndex++;
            }
            tb.Rows.Add(tr);//添加到表格中
            for (int i = 0; i < 5; i++)
            {
                tr = new TableRow();//创建一行
                intIndex = 1;
                int intFldNum = objViewInfoENEx.arrDGRegionFldSet.Count;
                for (int j = 0; j < intFldNum; j++)
                {
                    //字段名(列名)
                    lbl1 = new Label();
                    lbl1.Text = intIndex.ToString();
                    //lbl1.Font.Name = "verdana";
                    //lbl1.Font.Size = FontUnit.Parse("x-small");
                    lbl1.CssClass = "NameLabel";
                    lbl1.Width = 60;
                    cell1 = new TableCell();//创建单元格,也就是第一列
                    cell1.Controls.Add(lbl1);
                    tr.Cells.Add(cell1);
                    intIndex++;
                }
                tb.Rows.Add(tr);//添加到表格中
            }

            phListViewRegion.Controls.Add(objTable);
            phListViewRegion.Controls.Add(tb);
            return true;
        }
        //显示预览查询区域的控件
        public static int DispQryRegionCtrl(System.Web.UI.WebControls.PlaceHolder phQryRegion, clsViewInfoENEx objViewInfoENEx)
        {
            int intRow = 0, intCol = 0; //当前行,当前列
            int iCtlNum = 0;
            Table tb = new Table();//创建一个表格

            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");

            TableRow tr;
            TableCell cell1;//, cell2;
                            //System.Web.UI.WebControls.Label lbl1;
                            //System.Web.UI.WebControls.CheckBox chk1;
                            //System.Web.UI.WebControls.TextBox txt1;
                            //System.Web.UI.WebControls.DropDownList ddl1;
            System.Web.UI.WebControls.Button btn1;
            int intColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;//该区域定义的列数
            tr = new TableRow();//创建一行
            //bool bolIsEndRow = false;
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                if (intCol == intColNum)
                {
                    cell1 = new TableCell();//创建单元格,也就是第一列

                    tr.Cells.Add(cell1);
                    intCol++;

                    intRow++;
                    tb.Rows.Add(tr);//添加到表格中

                    tr = new TableRow();//创建一行
                    intCol = 0;
                    //bolIsEndRow = false;
                }
                wccFieldGroup wcc = new wccFieldGroup();
                wcc.Caption = objQryRegionFldsEx.LabelCaption;
                wcc.wccfg_CaptionCss = "NameLabel";
                wcc.wccfg_TextBoxCss = "TextBox_Defa";
                wcc.wccfg_LinkButtonCss = "lkbtn";
                wcc.Attributes.Add("DelThisCtrlClick", "wccFieldGroup2_DelThisCtrlClick");
                //wcc.DelThisCtrlClick += new EventHandler(wccFieldGroup2_DelThisCtrlClick);
                wcc.CtlTypeName = objQryRegionFldsEx.objCtlType.CtlTypeName;
                cell1 = new TableCell();//创建单元格,也就是第一列
                cell1.Controls.Add(wcc);
                tr.Cells.Add(cell1);
                intCol++;


                iCtlNum++;
            }
            //为最后一行添加单元格,使最后单元格不缺
            while (intCol < intColNum)
            {
                cell1 = new TableCell();//创建单元格,也就是第一列

                tr.Cells.Add(cell1);
                intCol++;
            }

            //if (bolIsEndRow == false)
            //{
            //  intRow++;
            //  tb.Rows.Add(tr);//添加到表格中
            //}
            //tr = new TableRow();//创建一行

            btn1 = new Button();
            btn1.Text = "查询";
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;
            cell1 = new TableCell();//创建单元格,也就是第一列
            cell1.Controls.Add(btn1);
            tr.Cells.Add(cell1);
            tb.Rows.Add(tr);//添加到表格中
            intRow++;
            ///生成查询按钮的代码;
            //			strCodeForCs.Append("\r\n" + GenButton(objButtonStyle,"btnQuery","查询"));
            phQryRegion.Controls.Add(tb);


            return intRow;
        }
        //显示预览<详细信息区域>的控件
        public static bool DispDetailRegionCtrl(System.Web.UI.WebControls.PlaceHolder phDetailRegion, clsViewInfoENEx objViewInfoENEx)
        {

            Table tb = new Table();//创建一个表格

            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");
            int iCtlNum = 0;
            TableRow tr;
            TableCell cell1, cell2;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.CheckBox chk1;
            System.Web.UI.WebControls.TextBox txt1;
            System.Web.UI.WebControls.DropDownList ddl1;
            System.Web.UI.WebControls.Button btn1;
            int intColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            tr = new TableRow();//创建一行
            bool bolIsEndRow = false;
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                if (iCtlNum % (intColNum * 2) == 0)
                {
                    tr = new TableRow();//创建一行
                    bolIsEndRow = false;
                }

                switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                {
                    case "CheckBox":
                        chk1 = new CheckBox();
                        chk1.Text = objQryRegionFldsEx.LabelCaption;
                        //chk1.Font.Name = "verdana";
                        //chk1.Font.Size = FontUnit.Parse("x-small");
                        chk1.CssClass = "Check_Defa";
                        chk1.Width = 100;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(chk1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell1.Text = "";
                        tr.Cells.Add(cell2);

                        break;
                    case "TextBox":
                        lbl1 = new Label();
                        lbl1.Text = objQryRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "Label_Defa";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        txt1 = new TextBox();
                        txt1.Text = "";
                        //txt1.Font.Name = "verdana";
                        //txt1.Font.Size = FontUnit.Parse("x-small");
                        txt1.CssClass = "TextBox_Defa";
                        txt1.Width = 60;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell2.Controls.Add(txt1);
                        tr.Cells.Add(cell2);
                        break;
                    case "DropDownList":
                        lbl1 = new Label();
                        lbl1.Text = objQryRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        ddl1 = new DropDownList();
                        //							ddl1.Text = "";
                        //ddl1.Font.Name = "verdana";
                        //ddl1.Font.Size = FontUnit.Parse("x-small");
                        ddl1.CssClass = "DropDown_Defa";
                        ddl1.Width = 60;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell2.Controls.Add(ddl1);
                        tr.Cells.Add(cell2);
                        break;

                    default:
                        lbl1 = new Label();
                        lbl1.Text = objQryRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//创建单元格,也就是第一列
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        txt1 = new TextBox();
                        txt1.Text = "";
                        //txt1.Font.Name = "verdana";
                        //txt1.Font.Size = FontUnit.Parse("x-small");
                        txt1.CssClass = "TextBox_Defa";
                        txt1.Width = 60;
                        cell2 = new TableCell();//创建单元格,也就是第一列
                        cell2.Controls.Add(txt1);
                        tr.Cells.Add(cell2);
                        break;
                }

                if (iCtlNum % (intColNum * 2) == (intColNum * 2 - 1))
                {
                    tb.Rows.Add(tr);//添加到表格中
                    bolIsEndRow = true;
                }
                iCtlNum++;
            }

            if (bolIsEndRow == false)
            {
                tb.Rows.Add(tr);//添加到表格中
            }
            tr = new TableRow();//创建一行
                                //空几个单元格
            for (int i = 0; i < intColNum * 2 - 1; i++)
            {
                cell1 = new TableCell();//创建单元格,也就是第一列
                tr.Cells.Add(cell1);
            }
            btn1 = new Button();
            btn1.Text = "关闭";
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;
            cell1 = new TableCell();//创建单元格,也就是第一列
            cell1.Controls.Add(btn1);
            tr.Cells.Add(cell1);
            tb.Rows.Add(tr);//添加到表格中
                            ///生成查询按钮的代码;
            //			strCodeForCs.Append("\r\n" + GenButton(objButtonStyle,"btnQuery","查询"));
            phDetailRegion.Controls.Add(tb);


            return true;
        }
       
        public string A_Gen_wucTabName4Gv(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;
            //让用户设置属性;

            objViewInfoENEx.CurrDate = clsDateTime.getTodayStr2(0);
            //string strFolder;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;

            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + string.Format("{0}.ascx", ClsName4WucTabName4Gv());
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlFName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlFName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebUserCtlFName);

            try
            {
                ///生成插入记录的界面代码;
                ///      strCodeForCs.Append("\r\n" + "///生成与表相关的控件界面层代码");
                //				<%@ Control Language = "C#" AutoEventWireup = "true" CodeBehind = "wucStuBaseInfor.ascx.cs" Inherits = "Webform.wucStuBaseInfor" %>
                if (objViewInfoENEx.ApplicationTypeId2 == "04")
                {
                    strCodeForCs.AppendFormat("\r\n" +
                       "<%@ Control Language = \"C#\" AutoEventWireup = \"true\" CodeFile = \"{0}.ascx.cs\" Inherits = \"{1}.Webform.{0}\" %>",
                                               ClsName4WucTabName4Gv(), objViewInfoENEx.NameSpace);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" +
                      "<%@ Control Language = \"C#\" AutoEventWireup = \"true\" CodeBehind = \"{0}.ascx.cs\" Inherits = \"{1}.Webform.{0}\" %>",
                                               ClsName4WucTabName4Gv(), objViewInfoENEx.NameSpace);
                }
                //strCodeForCs.AppendFormat("\r\n" + "<link rel = \"stylesheet\" type = \"text/css\" href = \"../../css/taishweb2.css\"/>",
                //  objViewInfoENEx.NameSpace);
                strCodeForCs.AppendFormat("\r\n" + "<link rel = \"stylesheet\" type = \"text/css\" href = \"../../css/tz_base1.css\"/>",
                    objViewInfoENEx.NameSpace);

                intZIndex = 101;
                //				intCurrLeft = 10;
                intCurrTop = 50;

                strCodeForCs.Append("\r\n" + "<%-- 列表层 --%>");
                strCodeForCs.Append("\r\n" + GenGridView4WucGv(objViewInfoENEx.objViewRegion_List, objViewInfoENEx));

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //检查该文件名的文件夹名,并判断是否存在;


            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        public string A_GenCode4Function(clsViewInfoENEx objViewInfoENEx, string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp = ""; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                //if (objFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                //{
                //    //strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
                //    //    objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                //}
                //else
                //{
                //strTemp = A_GeneFuncCode(objViewInfoENEx, strFuncName);
                //}

                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_MvcView_CtlViewCodeforTab()
        {
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;
            //让用户设置属性;

            objViewInfoENEx.CurrDate = clsDateTime.getTodayStr2(0);
            //string strFolder;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;

            int intZIndex;
            //			int intCurrLeft;  ///控件的左边空;
            int intCurrTop;  ///控件的顶面空;
            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "B.ascx";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlFName;


            try
            {
                ///生成插入记录的界面代码;

                intZIndex = 101;
                intCurrTop = 50;
                if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
                {
                    StringBuilder sbMessage = new StringBuilder();
                    string strViewName = objViewInfoENEx.ViewName;
                    sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                    throw new clsDbObjException(sbMessage.ToString());
                }
                strCodeForCs.Append("\r\n" + "<table class=\"col-md-12\">");
                //strCodeForCs.Append("\r\n" + "<tr>");
                //strCodeForCs.Append("\r\n" + "<td class=\"col-md-3\">");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///如果该字段不是标识递增型就生成控件,否则就不生成;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                      && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.Append("\r\n" + "@Html.HiddenFor(model => model.{0})"); 
                    }
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                        && objEditRegionFldsEx.PrimaryTypeId()== enumPrimaryType.StringAutoAddPrimaryKey_03)
                    {
                        continue;
                    }
                    string strFldName = objEditRegionFldsEx.FldName;
                    string strCaption = objEditRegionFldsEx.LabelCaption;
                    //strCodeForCs.Append("\r\n" + "                        <div class=\"form-group\">");
                    strCodeForCs.Append("\r\n" + "<tr>");
                    strCodeForCs.Append("\r\n" + "<td class=\"col-md-3\">");
                    switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "@Html.LabelFor(model => model.{0}, htmlAttributes: new {1} @class = \"control-label\" {2})",
                               strFldName, "{", "}");
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            strCodeForCs.Append("\r\n" + "<td class=\"col-md-9\"  style=\"text-align:left\">");
                            strCodeForCs.AppendFormat("\r\n" + "     @Html.EditorFor(model => model.{0}, new {1} htmlAttributes = new {1} @class = \"form-control\"{2} {2})",
                                 strFldName, "{", "}");

                            //strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" runat = \"server\" Text = \"{2}\" CssClass = \"Check_Defa\"></asp:{3}>",
                            //  objEditRegionFldsEx.objCtlType.CtlTypeName, objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.LabelCaption, objEditRegionFldsEx.objCtlType.CtlTypeName);
                 
                
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            break;
                        case "DropDownList":
                            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objEditRegionFldsEx.DsTabId, objProjectsENEx.PrjId);
                            strCodeForCs.AppendFormat("\r\n" + "@Html.LabelFor(model => model.{0}, htmlAttributes: new {1} @class = \"control-label\" {2})",
                                strFldName, "{", "}");
                            strCodeForCs.Append("\r\n" + "</td>");
                            strCodeForCs.Append("\r\n" + "<td class=\"col-md-9\"  style=\"text-align:left\">");
                            //strCodeForCs.Append("\r\n" + "    <div class=\"col-md-8\">");
                            if (strFldName == FldName4Key)
                            {
                                strCodeForCs.Append("\r\n" + " @if (ViewBag.Operate == \"Add\")");
                                strCodeForCs.Append("\r\n" + " {");

                                strCodeForCs.AppendFormat("\r\n" + "     @Html.DropDownListFor(model => model.{0}, ViewData[\"{1}List\"] as List<SelectListItem>, new {{ htmlAttributes = new {{ @class = \"form-control\" }} }})",
                                    strFldName, objPrjTabEN.TabName);
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.ValidationMessageFor(model => model.{0}, \"\", new {1} @class = \"text-danger\" {2})",
                                    strFldName, "{", "}");
                                strCodeForCs.Append("\r\n" + " }");
                                strCodeForCs.Append("\r\n" + " else");
                                strCodeForCs.Append("\r\n" + " {");

                                strCodeForCs.AppendFormat("\r\n" + "     @Html.DropDownListFor(model => model.{0}, ViewData[\"{1}List\"] as List<SelectListItem>, new {{ htmlAttributes = new {{ @class = \"form-control\" }} }})",
                                    strFldName, objPrjTabEN.TabName);
                                strCodeForCs.Append("\r\n" + " }");
                            }
                            else
                            {

                                strCodeForCs.AppendFormat("\r\n" + "     @Html.DropDownListFor(model => model.{0}, ViewData[\"{1}List\"] as List<SelectListItem>, new {{ htmlAttributes = new {{ @class = \"form-control\" }} }})",
                                    strFldName, objPrjTabEN.TabName);
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.ValidationMessageFor(model => model.{0}, \"{1}不能为空!\", new {2} @class = \"text-danger\" {3})",
                                    strFldName, strCaption, "{", "}");
                                strCodeForCs.Append("\r\n" + "           <asp:RequiredFieldValidator ID=\"RequiredFieldValidator2\" runat=\"server\"");
                                strCodeForCs.AppendFormat("\r\n" + "                 ControlToValidate=\"{0}\" Display=\"None\" ErrorMessage=\"请输入{1}\"></asp:RequiredFieldValidator>",
                                    strFldName, strCaption);
                            }
                            //strCodeForCs.Append("\r\n" + " </div>");
                            strCodeForCs.Append("\r\n" + "</td>");
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "@Html.LabelFor(model => model.{0}, htmlAttributes: new {1} @class = \"control-label\" {2})",
                                strFldName, "{", "}");
                            strCodeForCs.Append("\r\n" + "</td>");
                            strCodeForCs.Append("\r\n" + "<td class=\"col-md-9\">");

                            //strCodeForCs.Append("\r\n" + "    <div class=\"col-md-8\">");
                            if (strFldName == FldName4Key)
                            {
                                strCodeForCs.Append("\r\n" + " @if (ViewBag.Operate == \"Add\")");
                                strCodeForCs.Append("\r\n" + " {");
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.EditorFor(model => model.{0}, new {1} htmlAttributes = new {1} @class = \"form-control\"{2} {2})",
                                    strFldName, "{", "}");
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.ValidationMessageFor(model => model.{0}, \"\", new {1} @class = \"text-danger\" {2})",
                                    strFldName, "{", "}");
                                strCodeForCs.Append("\r\n" + " }");
                                strCodeForCs.Append("\r\n" + " else");
                                strCodeForCs.Append("\r\n" + " {");
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.TextBoxFor(model => model.{0}, new {1} @readonly = \"readonly\", @class = \"form-control\" {2})",
                                    strFldName, "{", "}");
                                strCodeForCs.Append("\r\n" + " }");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.EditorFor(model => model.{0}, new {1} htmlAttributes = new {1} @class = \"form-control\"{2} {2})",
                                  strFldName, "{", "}");
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.ValidationMessageFor(model => model.{0}, \"{1}不能为空!\", new {2} @class = \"text-danger\" {3})",
                                    strFldName, strCaption, "{", "}");
                                strCodeForCs.Append("\r\n" + "           <asp:RequiredFieldValidator ID=\"RequiredFieldValidator2\" runat=\"server\"");
                                strCodeForCs.AppendFormat("\r\n" + "                 ControlToValidate=\"{0}\" Display=\"None\" ErrorMessage=\"请输入{1}\"></asp:RequiredFieldValidator>",
                                    strFldName, strCaption);
                            }
                            //strCodeForCs.Append("\r\n" + " </div>");
                            strCodeForCs.Append("\r\n" + "</td>");

                            break;
                    }
                    //strCodeForCs.Append("\r\n" + "                        </div>");
                    strCodeForCs.Append("\r\n" + "</tr>");


                    intZIndex += 1;
                    intCurrTop += 25;

                }
                strCodeForCs.Append("\r\n" + "  </table>");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }

            return strCodeForCs.ToString();
        }
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(Mvc_ViewSpa4CSharp);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("在类中没有相应的函数:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
                    if (mt.GetParameters().Length == 0)
                    {
                        strCode = (string)mt.Invoke(this, null);
                    }
                    else if (mt.GetParameters().Length == 1)
                    {
                        strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strMsg = "";
                if (objException.InnerException != null && string.IsNullOrEmpty(objException.InnerException.Message) == false)
                {
                    strMsg = objException.InnerException.Message;
                }
                else
                {
                    strMsg = objException.Message;
                }
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", strFuncName, strMsg);
                throw new Exception(sbMessage.ToString());
            }
        }
        public override void GetClsName()
        {
            this.ClsName = string.Format("{0}CRUDSpa", objViewInfoENEx.TabName);
            objViewInfoENEx.ClsName = this.ClsName;
        }
     
    }
}
