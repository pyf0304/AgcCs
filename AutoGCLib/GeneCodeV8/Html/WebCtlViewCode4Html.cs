using System;
using System.Text;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.util;
using com.taishsoft.file;


using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using AGC.Entity;

using com.taishsoft.datetime;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using System.Reflection;
using AgcCommBase;
using System.Collections.Generic;
using System.Linq;
using AGC.PureClass;
using AGC.PureClassEx;

namespace AutoGCLib
{
    /// <summary>
    /// 自动生成界面控制层的代码类(View of Mvc)
    /// </summary>
    public class WebCtlViewCode4Html : clsGeneCodeBase4View
    {
        clsBiDimDistribute objBiDimDistribue4Qry = null;
        //private string strFolder;   //私有临时变量
                                    //		private objViewInfoENEx.FileName;		//生成的文件名；
        #region 构造函数
        public WebCtlViewCode4Html()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
        }
        public WebCtlViewCode4Html(string strViewId)
       : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public WebCtlViewCode4Html(string strViewId, string strPrjDataBaseId, string strPrjId)
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
            intZIndex = 100;		///控件焦点序号
            intCurrLeft = 10;   ///控件的左边空;
            intCurrTop = 10;
        }

      
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            ////CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;
            //让用户设置属性;

            objViewInfoENEx.CurrDate = clsDateTime.getTodayStr2(0);
            //string strFolder;
            StringBuilder strCodeForCs = new StringBuilder();   ///用来存放WebForm的代码;

            //int intZIndex;
            //			int intCurrLeft;   ///控件的左边空;
            //int intCurrTop;   ///控件的顶面空;
            objViewInfoENEx.WebUserCtlClassName = this.ClsName;
            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + this.ClsName + ".ascx";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;

            strRe_ClsName = objViewInfoENEx.WebUserCtlClassName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(),
                objViewInfoENEx.WebUserCtlFName);

            try
            {
                ///生成插入记录的界面代码;
                ///            strCodeForCs.Append("\r\n" + "///生成与表相关的控件界面层代码");
                //				<%@ Control Language = "C#" AutoEventWireup = "true" CodeBehind = "wucStuBaseInfor.ascx.cs" Inherits = "Webform.wucStuBaseInfor" %>
                if (objViewInfoENEx.ApplicationTypeId2 == "04")
                {
                    strCodeForCs.AppendFormat("\r\n" +
                         "<%@ Control Language = \"C#\" AutoEventWireup = \"true\" CodeFile = \"{0}.ascx.cs\" Inherits = \"{1}.Webform.{0}\" %>",
                         this.ClsName, objViewInfoENEx.NameSpace);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" +
                        "<%@ Control Language = \"C#\" AutoEventWireup = \"true\" CodeBehind = \"{0}.ascx.cs\" Inherits = \"{1}.Webform.{0}\" %>",
                        this.ClsName, objViewInfoENEx.NameSpace);
                }
                //strCodeForCs.AppendFormat("\r\n" + "<link rel = \"stylesheet\" type = \"text/css\" href = \"../../css/tz_base1.css\"/>",
                //    objViewInfoENEx.NameSpace);
                //strCodeForCs.AppendFormat("\r\n" + "<link href = \"../../Content/bootstrap.min.css\" rel = \"stylesheet\" />");
                //strCodeForCs.AppendFormat("\r\n" + "<link href = \"../../Content/bootstrap-grid.css.map\" rel = \"stylesheet\" />");
                foreach (clsViewReferFilesEN objvViewReferFilesENEx in objViewInfoENEx.arrViewReferFiles.Where(x => x.CodeTypeId == objViewInfoENEx.CodeTypeId))
                {
                    objvViewReferFilesENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                }
                //strCodeForCs.Append("\r\n" + "    <style type=\"text/css\">");
                //strCodeForCs.Append("\r\n" + "        body {");
                //strCodeForCs.Append("\r\n" + "            font-size: 0.875rem;");
                //strCodeForCs.Append("\r\n" + "        }");
                //strCodeForCs.Append("\r\n" + "    </style>");

                //				strCodeForCs.Append("\r\n" + "<meta name = \"vs_snapToGrid\" content = \"false\">");
                //				strCodeForCs.Append("\r\n" + "<meta name = \"vs_showGrid\" content = \"true\">");

                if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
                {
                    StringBuilder sbMessage = new StringBuilder();
                    string strViewName = objViewInfoENEx.ViewName;
                    sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                    throw new clsDbObjException(sbMessage.ToString());
                }


                //ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.GetObj4EditRegion(objViewInfoENEx.objMainPrjTab.TabName);
                Func<clsEditRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4AspNet = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, objViewInfoENEx.PrjId, false);

                IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst 
                    = objViewInfoENEx.arrEditRegionFldSet4InUse
                    .Where(x=>x.IsLogUpdDateOrUpdUser(objViewInfoENEx.PrjId) == false)
                    .Select(GetControlGroup_Asp4AspNet);
                //把查询按钮加进来
                //ASPControlGroupEx objASPControlGroup = clsASPControlGroupBLEx.GetbtnQuery();
                //List<ASPControlGroupEx> arrButtonObjLst = new List<ASPControlGroupEx>();
                //arrButtonObjLst.Add(objASPControlGroup);
                //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonObjLst);
                //封装Td
                ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4EditRegion(arrASPControlGroupObjLst, objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0);

                //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Select(clsASPControlGroupBLEx.PackageTr4Wuc);

                //int intCount = 0;
                //ASPRowEx objRow = new ASPRowEx();

                //foreach (ASPControlEx objInFor in arrASPControlGroupObjLst)
                //{
                //    objTable.arrSubAspControlLst2.Add(objInFor);
                //}
                objTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }


            return strCodeForCs.ToString();
        }
        public string GeneCode4EditRegion()
        {
            objViewInfoENEx.CurrDate = clsDateTime.getTodayStr2(0);
            //string strFolder;
            StringBuilder strCodeForCs = new StringBuilder();   ///用来存放WebForm的代码;

            try
            {
                ///生成插入记录的界面代码;
                if (objViewInfoENEx.ApplicationTypeId2 == "04")
                {
                    strCodeForCs.AppendFormat("\r\n" +
                         "<%@ Control Language = \"C#\" AutoEventWireup = \"true\" CodeFile = \"{0}.ascx.cs\" Inherits = \"{1}.Webform.{0}\" %>",
                         this.ClsName, objViewInfoENEx.NameSpace);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" +
                        "<%@ Control Language = \"C#\" AutoEventWireup = \"true\" CodeBehind = \"{0}.ascx.cs\" Inherits = \"{1}.Webform.{0}\" %>",
                        this.ClsName, objViewInfoENEx.NameSpace);
                }
                foreach (clsViewReferFilesEN objvViewReferFilesENEx in objViewInfoENEx.arrViewReferFiles.Where(x => x.CodeTypeId == objViewInfoENEx.CodeTypeId))
                {
                    objvViewReferFilesENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                }
                
                if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
                {
                    StringBuilder sbMessage = new StringBuilder();
                    string strViewName = objViewInfoENEx.ViewName;
                    sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                    throw new clsDbObjException(sbMessage.ToString());
                }


                //ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.GetObj4EditRegion(objViewInfoENEx.objMainPrjTab.TabName);
                Func<clsEditRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4AspNet = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, objViewInfoENEx.PrjId, false);

                IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst
                    = objViewInfoENEx.arrEditRegionFldSet4InUse
                    .Where(x => x.IsLogUpdDateOrUpdUser(objViewInfoENEx.PrjId) == false)
                    .Select(GetControlGroup_Asp4AspNet);
                //把查询按钮加进来
                //ASPControlGroupEx objASPControlGroup = clsASPControlGroupBLEx.GetbtnQuery();
                //List<ASPControlGroupEx> arrButtonObjLst = new List<ASPControlGroupEx>();
                //arrButtonObjLst.Add(objASPControlGroup);
                //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Union(arrButtonObjLst);
                //封装Td
                ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4EditRegion(arrASPControlGroupObjLst, objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0);
               
                objTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }


            return strCodeForCs.ToString();
        }

        public string A_GenCtlViewCodeforTab4Query()
        {

            ////CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;
            //让用户设置属性;
            string strFolder;
            StringBuilder strCodeForCs = new StringBuilder();   ///用来存放WebForm的代码;

            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "Query.ascx";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;
            try
            {
                ///生成插入记录的界面代码;
                ///            strCodeForCs.Append("\r\n" + "///生成与表相关的控件界面层代码");
                ///            

                if (objViewInfoENEx.ApplicationTypeId2  ==  "04")
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
                strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabwuc{0}\" style = \"width:600px; padding:1px;\" border = \"0\">",
                    objViewInfoENEx.TabName);
                intZIndex = 101;
                //				intCurrLeft = 10;
                intCurrTop = 50;
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    ///如果该字段不是标识递增型就生成控件,否则就不生成;
                    if (objQryRegionFldsEx.PrimaryTypeId()  ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    strCodeForCs.AppendFormat("\r\n" + "<tr>");
                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" runat = \"server\" Font-Names = \"Verdana\" Font-Size = \"X-Small\"  Text = \"{2}\"></asp:{3}>",
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
                            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\"  Font-Size = \"X-Small\" Font-Names = \"Verdana\">{1}</asp:Label>",
                                "lbl" + objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.LabelCaption);
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" runat = \"server\"  Font-Size = \"X-Small\" Font-Names = \"Verdana\"></asp:{2}>",
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
                    intZIndex +=  1;
                    intCurrTop +=  25;
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
            if (System.IO.Directory.Exists(strFolder)  ==  false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode   ==  true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebUserCtlFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.BackupFolderName, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
                {
                    string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
                    throw new Exception(strMsg);
                }
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebUserCtlFName, strCodeForCs.ToString());
            return strCodeForCs.ToString();
        }

        ///以下均是界面层内容(VIEW)-------
        ///

        /// <summary>
        /// 专门用于显示打印的表控件
        /// </summary>
        /// <returns></returns>
        public string A_GenCtlViewCodeforTab_Disp()
        {
            //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
            //''该功能主要生成与表相关的控件代码,包括两个文件,;
            //一个是控件的界面文件, ;
            //另一个与之相关的界面类文件;
            //让用户设置属性;
            string strFolder;
            StringBuilder strCodeForCs = new StringBuilder();   ///用来存放WebForm的代码;

            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "_Disp.ascx";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;
            try
            {
                ///生成插入记录的界面代码;
                ///            strCodeForCs.Append("\r\n" + "///生成与表相关的控件界面层代码");
                if (objViewInfoENEx.ApplicationTypeId2  ==  "04")
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
                strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabwuc{0}\" style = \"width:600px; padding:1px;\" border = \"0\">",
                    objViewInfoENEx.TabName);
                intZIndex = 101;
                //				intCurrLeft = 10;
                intCurrTop = 50;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///如果该字段不是标识递增型就生成控件,否则就不生成;
                    if (objEditRegionFldsEx.PrimaryTypeId() ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }

                    strCodeForCs.AppendFormat("\r\n" + "<tr>");
                    switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" runat = \"server\" Font-Names = \"Verdana\" Font-Size = \"X-Small\"  Text = \"{2}\"></asp:{3}>",
                                objEditRegionFldsEx.objCtlType.CtlTypeName, objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.LabelCaption, objEditRegionFldsEx.objCtlType.CtlTypeName);
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\"  Font-Size = \"X-Small\" Font-Names = \"Verdana\">{1}</asp:Label>",
                                "lbl" + objEditRegionFldsEx.FldName,
                                objEditRegionFldsEx.LabelCaption);
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            strCodeForCs.AppendFormat("\r\n" + "<td>");
                            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"lbl{0}_Disp\" runat = \"server\"  Font-Size = \"X-Small\" Font-Names = \"Verdana\"></asp:Label>",
                                objEditRegionFldsEx.FldName);
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            break;
                    }
                    strCodeForCs.AppendFormat("\r\n" + "<td>");
                    strCodeForCs.AppendFormat("\r\n" + "</td>");
                    strCodeForCs.AppendFormat("\r\n" + "<td></td>");
                    strCodeForCs.AppendFormat("\r\n" + "</tr>");
                    intZIndex +=  1;
                    intCurrTop +=  25;
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
            if (System.IO.Directory.Exists(strFolder)  ==  false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode   ==  true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebUserCtlFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.BackupFolderName, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
                {
                    string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
                    throw new Exception(strMsg);
                }
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebUserCtlFName, strCodeForCs.ToString());
            return strCodeForCs.ToString();
        }



        public string GenFileCtlViewCodeforTab()
        {
            //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
            //让用户设置属性;
            string strFolder;
            StringBuilder strCodeForCs = new StringBuilder();   ///用来存放WebForm的代码;

            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "OptFile.ascx";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;
            try
            {
                ///生成插入记录的界面代码;
                ///            strCodeForCs.Append("\r\n" + "///生成与表相关的控件界面层代码");
                if (objViewInfoENEx.ApplicationTypeId2  ==  "04")
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
                strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabwuc{0}\" style = \"width:600px; padding:1px;\" border = \"0\">",
                    objViewInfoENEx.TabName);
                intZIndex = 101;
                //				intCurrLeft = 10;
                intCurrTop = 50;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///如果该字段不是标识递增型就生成控件,否则就不生成;
                    if (objEditRegionFldsEx.PrimaryTypeId() ==  clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
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
                    intZIndex +=  1;
                    intCurrTop +=  25;
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
            if (System.IO.Directory.Exists(strFolder)  ==  false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode   ==  true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebUserCtlFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.BackupFolderName, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
                {
                    string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
                    throw new Exception(strMsg);
                }
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebUserCtlFName, strCodeForCs.ToString());
            return strCodeForCs.ToString();
        }
      
       
        public string GenPicCtlViewCodeforTab()
        {
            //让用户设置属性;
            string strFolder;
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放WebForm的代码;

            objViewInfoENEx.ClsName = "wuc" + objViewInfoENEx.TabName + "OptPic";
            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "OptPic.ascx";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;
            try
            {
                ///生成插入记录的界面代码;
                ///            strCodeForCs.Append("\r\n" + "///生成与表相关的控件界面层代码");
                if (objViewInfoENEx.ApplicationTypeId2  ==  "04")
                {
                    strCodeForCs.AppendFormat("\r\n" +
                         "<%@ Control Language = \"c#\" AutoEventWireup = \"false\" CodeFile = \"{0}.ascx.cs\" Inherits = \"{1}.Webform.{0}\" TargetSchema = \"http://schemas.microsoft.com/intellisense/ie5\"%>",
                         objViewInfoENEx.ClsName, objViewInfoENEx.NameSpace);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" +
                        "<%@ Control Language = \"c#\" AutoEventWireup = \"false\" CodeBehind = \"{0}.ascx.cs\" Inherits = \"{1}.Webform.{0}\" TargetSchema = \"http://schemas.microsoft.com/intellisense/ie5\"%>",
                        objViewInfoENEx.ClsName, objViewInfoENEx.NameSpace);
                }
                strCodeForCs.Append("\r\n" + "<table id = \"Table1\" cellspacing = \"0\" cellpadding = \"0\" width = \"272\" border = \"0\" style = \"width: 272px; height: 295px\">");
                strCodeForCs.Append("\r\n" + "<tr>");
                strCodeForCs.Append("\r\n" + "<td width = \"112\">");
                strCodeForCs.Append("\r\n" + "<asp:Image id = \"imgPic\" Width = \"112px\" Height = \"144px\" runat = \"server\"></asp:Image>");
                strCodeForCs.Append("\r\n" + "</td>");
                strCodeForCs.Append("\r\n" + "</tr>");
                strCodeForCs.Append("\r\n" + "<tr>");
                strCodeForCs.Append("\r\n" + "<td><INPUT id = \"flBrowFile\" title = \"Select File; Upload!\" style = \"width: 320px; height: 22px\"");
                strCodeForCs.Append("\r\n" + "type = \"file\" size = \"34\" name = \"flBrowFile\" runat = \"server\">");
                strCodeForCs.Append("\r\n" + "</td>");
                strCodeForCs.Append("\r\n" + "</tr>");
                strCodeForCs.Append("\r\n" + "<tr>");
                strCodeForCs.Append("\r\n" + "<td style = \"height: 40px\">");
                strCodeForCs.Append("\r\n" + "<table id = \"Table2\" cellspacing = \"0\" cellpadding = \"0\" width = \"256\" border = \"0\" style = \"width: 256px; height: 32px\">");
                strCodeForCs.Append("\r\n" + "<tr>");
                strCodeForCs.Append("\r\n" + "<td style = \"width: 102px\">");
                strCodeForCs.Append("\r\n" + "<asp:Button id = \"btnBrowPic\" Width = \"96px\" Height = \"24px\" runat = \"server\" Text = \"预览照片\"></asp:Button>");
                strCodeForCs.Append("\r\n" + "</td>");
                strCodeForCs.Append("\r\n" + "<td>");
                strCodeForCs.Append("\r\n" + "<asp:Button id = \"btnUpLoadPic\" Width = \"80px\" runat = \"server\" Text = \"上传照片\"></asp:Button>");
                strCodeForCs.Append("\r\n" + "</td>");
                strCodeForCs.Append("\r\n" + "</tr>");
                strCodeForCs.Append("\r\n" + "</table>");
                strCodeForCs.Append("\r\n" + "</td>");
                strCodeForCs.Append("\r\n" + "</tr>");
                strCodeForCs.Append("\r\n" + "<tr>");
                strCodeForCs.Append("\r\n" + "<td>");
                strCodeForCs.Append("\r\n" + "<asp:Label id = \"lblMsg\" runat = \"server\" Height = \"15px\" Width = \"312px\"></asp:Label>");
                strCodeForCs.Append("\r\n" + "</td>");
                strCodeForCs.Append("\r\n" + "</tr>");
                strCodeForCs.Append("\r\n" + "</table>");
                strCodeForCs.Append("\r\n" + "</FONT>");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
            //把生成写到文件中;
            //检查该文件名的文件夹名,并判断是否存在;
            strFolder = clsString.ParentDir_S(objViewInfoENEx.WebUserCtlFName);
            if (System.IO.Directory.Exists(strFolder)  ==  false)
            {
                Directory.CreateDirectory(strFolder);
            }

            if (clsSysParaEN_Local.IsBackupForGeneCode   ==  true)
            {
                string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebUserCtlFName);
                string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.BackupFolderName, strSimpleFileName);
                while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
                {
                    string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
                    throw new Exception(strMsg);
                }
            }
            clsFile.CreateFileByString(objViewInfoENEx.WebUserCtlFName, strCodeForCs.ToString());
            return strCodeForCs.ToString();
        }
        private string GenViewTitle(string strTitle, clsViewInfoENEx objViewInfoENEx)
        {
            //clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetTitleStyleObjByTitleStyleId(objViewInfoENEx.objViewStyleEN.TitleStyleId);
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleIdCache(objViewInfoENEx.objViewStyleEN.TitleStyleId);
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放WebForm的代码;
            //			string strTemp;          ///临时变量;
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

            intZIndex +=  1;
            return strCodeForCs.ToString();


        }
        private string gfunRadioClick()
        {
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleIdCache(objViewInfoENEx.objViewStyleEN.TitleStyleId);
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放WebForm的代码;
            //			string strTemp;          ///临时变量;
            ///生成Label的代码;
            strCodeForCs.Append("\r\n" + "<script language = \"javascript\">");
            strCodeForCs.Append("\r\n" + "<!--");
            strCodeForCs.Append("\r\n" + "function radioClick()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (document.Form1.RadioName != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "for (i = 0; i<document.Form1.RadioName.length; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (document.Form1.RadioName[i].checked  ==  true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "document.Form1.rd.value = document.Form1.RadioName[i].value;");
            //document.getElementById("TextBox1").value = document.Form1.rd.value;
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//-->");
            strCodeForCs.Append("\r\n" + "</script>");

            intZIndex +=  1;
            return strCodeForCs.ToString();


        }


        /// <summary>
        /// 生成查询区域相关代码
        /// </summary>
        /// <returns></returns>
        public string GenQryRegionCode4Div()
        {
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放WebForm的代码;
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
            intCurrTop -=  30;//因为这是在层(div)中
            int intFieldNum = 0;
            objBiDimDistribue4Qry.StartX = intCurrLeft;
            objBiDimDistribue4Qry.StartY = intCurrTop;
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
                intZIndex +=  1;
                intCurrTop +=  28;
                intFieldNum++;
                intCurrLeft = objBiDimDistribue4Qry.GetPosition(intFieldNum).X;
                intCurrTop = objBiDimDistribue4Qry.GetPosition(intFieldNum).Y;

            }
            ///生成查询按钮的代码;
            strCodeForCs.Append("\r\n" + GenButton(objButtonStyle, "btnQuery", "查询", "btnQuery_Click"));
            strCodeForCs.Append("\r\n" + "</div>");

            intCurrTop +=  40;
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成查询区域相关代码
        /// </summary>
        /// <returns></returns>
        public string GenQryRegionCode4Table()
        {
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放WebForm的代码;
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

            strCodeForCs.AppendFormat("\r\n" + "<table> ",
                objViewInfoENEx.TabName, intDivHeight);
            intCurrTop -=  30;//因为这是在层(div)中
            int intFieldNum = 0;
            objBiDimDistribue4Qry.StartX = intCurrLeft;
            objBiDimDistribue4Qry.StartY = intCurrTop;
            ///生成专门用于查询的界面控件的代码;
            ///
            bool bolIsTrEnd = true;
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                if (intFieldNum % objViewInfoENEx.objViewRegion_Query.ColNum  ==  0)
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
                        strCodeForCs.AppendFormat("\r\n" +
                            GenCombineCtlNoPosition(objLabelStyle_Text,
                            "lbl" + objQryRegionFldsEx.FldName + "_q",
                            objQryRegionFldsEx.LabelCaption,
                            objGenCtlStyle,
                            objQryRegionFldsEx.objCtlType.CtlTypeName,
                            objQryRegionFldsEx.CtrlId()));
                        break;
                }

                intZIndex +=  1;
                intCurrTop +=  28;
                intFieldNum++;
                if (intFieldNum % objViewInfoENEx.objViewRegion_Query.ColNum  ==  0)
                {
                    strCodeForCs.Append("\r\n" + "</tr>");
                    bolIsTrEnd = true;
                }
                intCurrLeft = objBiDimDistribue4Qry.GetPosition(intFieldNum).X;
                intCurrTop = objBiDimDistribue4Qry.GetPosition(intFieldNum).Y;

            }
            ///生成查询按钮的代码;
            ///
            if (bolIsTrEnd  ==  true)
            {
                strCodeForCs.Append("\r\n" + "<tr>");
                bolIsTrEnd = false;
            }
            strCodeForCs.Append("\r\n" + "<td>");
            strCodeForCs.Append("\r\n" + GenButtonNoPosition(objButtonStyle, "btnQuery", "查询", "btnQuery_Click"));
            strCodeForCs.Append("\r\n" + "</td>");

            strCodeForCs.Append("\r\n" + "</tr>");
            strCodeForCs.Append("\r\n" + "</table>");

            intCurrTop +=  40;
            return strCodeForCs.ToString();
        }


        public bool DispQryRegionCtrl()
        {

            return true;
        }
      
      
        public string GenUpdRecViewCode(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //让用户设置属性;
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放WebForm的代码;
            //			string strTemp ;          ///临时变量;

            objViewInfoENEx.WebFormName = "wfm" + objViewInfoENEx.TabName + "B_U";
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + "wfm" + objViewInfoENEx.TabName + "B_U.aspx";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {
                ///生成插入记录的界面代码;
                ///            strCodeForCs.Append("///生成修改记录的界面代码(利用控件)");
                strCodeForCs.AppendFormat("\r\n" + "<%@ Register TagPrefix = \"uc1\" TagName = \"wuc{0}B\" Src = \"wuc{1}B.ascx\" %>",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                if (objViewInfoENEx.ApplicationTypeId2  ==  "04")
                {
                    strCodeForCs.AppendFormat("\r\n" + "<%@ Page language = \"c#\" CodeFile = \"{0}.aspx.cs\" AutoEventWireup = \"false\" Inherits = \"{1}.Webform.{2}\" %>",
                         objViewInfoENEx.WebFormName, objViewInfoENEx.NameSpace, objViewInfoENEx.WebFormName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "<%@ Page language = \"c#\" CodeBehind = \"{0}.aspx.cs\" AutoEventWireup = \"false\" Inherits = \"{1}.Webform.{2}\" %>",
                        objViewInfoENEx.WebFormName, objViewInfoENEx.NameSpace, objViewInfoENEx.WebFormName);
                }
                strCodeForCs.Append("\r\n" + "<!DOCTYPE html PUBLIC \"-//W3C//DTD html 4.0 Transitional//EN\" >");
                strCodeForCs.Append("\r\n" + "<html>");
                strCodeForCs.Append("\r\n" + "<head>");
                strCodeForCs.AppendFormat("\r\n" + "<title>表{0}的查询修改记录</title>", objViewInfoENEx.TabName);
             
                strCodeForCs.AppendFormat("\r\n" + "<LINK rel = \"stylesheet\" type = \"text/css\" href = \"../../css/tz_base1.css\"/>",
                    objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "</head>");
                strCodeForCs.Append("\r\n" + "<body MS_POSITIONING = \"GridLayout\">");
                strCodeForCs.Append("\r\n" + "<form id = \"Form1\" method = \"post\" runat = \"server\">");
                strCodeForCs.Append("\r\n" + "<div>");
                intZIndex = 101;
                intCurrLeft = 200;
                intCurrTop = 20;
                strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"lblTitle\" style = \"z-index: {0}; left: {1}px; position: absolute; top: {2}px\" runat = \"server\" ",
                    intZIndex, intCurrLeft, intCurrTop);
                strCodeForCs.AppendFormat("\r\n" + "Width = \"532px\" Height = \"43px\" Font-Names = \"黑体\" Font-Size = \"X-Large\">{0}表的查询并修改</asp:Label>",
                    objViewInfoENEx.TabName);
                intZIndex +=  1;
                intCurrTop +=  35;
                ///生成用于布局的表格代码;
                strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabLayout\" style = \"z-index: {0}; left: 65px; width: 373px; position: absolute; top: {1}px; height: 200px\" ",
                    intZIndex, intCurrTop);
                strCodeForCs.Append("\r\n" + "style = \"width:373px; padding:1px;\" border = \"1\">");
                strCodeForCs.Append("\r\n" + "<tr>");
                strCodeForCs.Append("\r\n" + "<td>");
                strCodeForCs.AppendFormat("\r\n" + "<uc1:wuc{0}B id = \"wuc{1}B1\" runat = \"server\" /></td>",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "</tr>");
                strCodeForCs.Append("\r\n" + "</table>");
                intZIndex +=  1;
                ///生成界面中控件<确定修改>的代码, top与布局表一样;
                strCodeForCs.AppendFormat("\r\n" + "<asp:Button id = \"btnOKUpd\" style = \"z-index: {0}; left: 460px; position: absolute; top: {1}px\" ",
                    intZIndex, intCurrTop);
                strCodeForCs.Append("\r\n" + "runat = \"server\" Width = \"80px\" Height = \"24px\" Text = \"确定修改\"></asp:Button>");
                intZIndex +=  1;
                intCurrTop +=  25;
                ///生成界面中用于显示信息的代码;
                strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"lblMsg\" style = \"z-index: {0}; left: 461px; position: absolute; top: {1}px\" runat = \"server\" Font-Names = \"Verdana\" Font-Size = \"X-Small\" ",
                    intZIndex, intCurrTop);
                strCodeForCs.Append("\r\n" + "Width = \"215px\" Height = \"15px\"></asp:Label>");
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

            //CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();
            //把生成写到文件中;
            //检查该文件名的文件夹名,并判断是否存在;
            //strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            //if (System.IO.Directory.Exists(strFolder)  ==  false)
            //{
            //    Directory.CreateDirectory(strFolder);
            //}

            //if (clsSysParaEN_Local.IsBackupForGeneCode   ==  true)
            //{
            //    string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            //    string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.BackupFolderName, strSimpleFileName);
            //    while (string.IsNullOrEmpty(strFindFileFullFile)  ==  false)
            //    {
            //        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
            //        throw new Exception(strMsg);
            //    }
            //}
            //clsFile.CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString());

            return strCodeForCs.ToString();
        }
      
        #region 生成单个控件的生成函数


        /// <summary>
        /// 生成Label控件
        /// </summary>
        /// <param name = "strDgStyleId"></param>
        /// <returns></returns>
        public string GenLabel(clsLabelStyleEN objLabelStyle, string strLabelId, string strLabelText)
        {
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放WebForm的代码;
            //			string strTemp;          ///临时变量;
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
            intZIndex +=  1;

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成Label控件
        /// </summary>
        /// <param name = "strDgStyleId"></param>
        /// <returns></returns>
        public string GenLabelForTable(clsLabelStyleEN objLabelStyle, string strLabelId, string strLabelText)
        {
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放WebForm的代码;
            //			string strTemp;          ///临时变量;
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
            intZIndex +=  1;

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成通用控件
        /// </summary>
        /// <param name = "strDgStyleId"></param>
        /// <returns></returns>
        public string GeneGenCtl(clsGenCtlStyleEN objGenCtlStyle, string strCtlTypeName, string strCtlId, string strCtlText)
        {
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放WebForm的代码;
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
            intZIndex +=  1;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成TextBox控件
        /// </summary>
        /// <param name = "strDgStyleId"></param>
        /// <returns></returns>
        public string GenTextBox(clsTextBoxStyleEN objTextBoxStyle, string strTextBoxId)
        {
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放WebForm的代码;
            //			string strTemp;          ///临时变量;
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
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; left: {1}px; ",
                    objTextBoxStyle.StyleZindex, objTextBoxStyle.StyleLeft);
                strCodeForCs.AppendFormat("\r\n" + "position: {0}; top: {1}px\" ",
                    objTextBoxStyle.StylePosition, objTextBoxStyle.StyleTop);
                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                    objTextBoxStyle.Runat);
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "Width = \"{0}px\" Height = \"{1}px\" ",
                    objTextBoxStyle.Width, objTextBoxStyle.Height);
                //生成<字号>和<字体>
                strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ",
                    objTextBoxStyle.FontSize, objTextBoxStyle.FontName);
                //生成<是否只读>
                strCodeForCs.AppendFormat("\r\n" + "ReadOnly = \"{0}\" ", objTextBoxStyle.ReadOnly);
                //生成<文本模式> TextMode = "MultiLine"
                strCodeForCs.AppendFormat("\r\n" + "TextMode = \"{0}\"  ", objTextBoxStyle.TextMode);

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "></asp:TextBox>");

                intZIndex +=  1;

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
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放WebForm的代码;
            //			string strTemp;          ///临时变量;
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
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; left: {1}px; ",
                    objCheckStyle.StyleZindex, objCheckStyle.StyleLeft);
                strCodeForCs.AppendFormat("\r\n" + "position: {0}; top: {1}px\" ",
                    objCheckStyle.StylePosition, objCheckStyle.StyleTop);
                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                    objCheckStyle.Runat);
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "Width = \"{0}px\" Height = \"{1}px\" ",
                    objCheckStyle.Width, objCheckStyle.Height);
                //生成<字号>和<字体>
                //strCodeForCs.AppendFormat("\r\n" + "  Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //    objCheckStyle.FontSize, objCheckStyle.FontName);
                //生成<显示文本> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\"  ", strCheckText);

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "CssClass = \"Check_Defa\"></asp:CheckBox>");

                intZIndex +=  1;

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
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放WebForm的代码;
            //			string strTemp;          ///临时变量;
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
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; \" ",
                    objCheckStyle.StyleZindex);
                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                    objCheckStyle.Runat);
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "Width = \"{0}px\" Height = \"{1}px\" ",
                    objCheckStyle.Width, objCheckStyle.Height);
                //生成<字号>和<字体>
                //strCodeForCs.AppendFormat("\r\n" + "  Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //    objCheckStyle.FontSize, objCheckStyle.FontName);
                //生成<显示文本> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\"  ", strCheckText);

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "CssClass = \"Check_Defa\"></asp:CheckBox>");

                strCodeForCs.Append("\r\n" + "</td>");

                intZIndex +=  1;

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
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放WebForm的代码;
            //			string strTemp;          ///临时变量;
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
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; left: {1}px; ",
                    objButtonStyle.StyleZindex, objButtonStyle.StyleLeft);
                strCodeForCs.AppendFormat("\r\n" + "position: relative; top: {1}px\" ",
                    objButtonStyle.StylePosition, objButtonStyle.StyleTop);
                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                    objButtonStyle.Runat);
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "Width = \"{0}px\" Height = \"{1}px\" ",
                    objButtonStyle.Width, objButtonStyle.Height);
                //生成<字号>和<字体>
                //				strCodeForCs.AppendFormat("\r\n" + "  Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //					objButtonStyle.FontSize, objButtonStyle.FontName);
                //生成<显示文本> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" CssClass = \"btn btn-primary btn-sm\" ", strButtonText);
                //生成单击事件
                strCodeForCs.AppendFormat("\r\n" + "OnClick = \"{0}\" ", strOnClick);

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "></asp:Button>");

                intZIndex +=  1;

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
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放WebForm的代码;
            //			string strTemp;          ///临时变量;
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
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0};\" ",
                    objButtonStyle.StyleZindex, objButtonStyle.StyleLeft);
                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                    objButtonStyle.Runat);
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "Width = \"{0}px\" Height = \"{1}px\" ",
                    objButtonStyle.Width, objButtonStyle.Height);
                //生成<字号>和<字体>
                //				strCodeForCs.AppendFormat("\r\n" + "  Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //					objButtonStyle.FontSize, objButtonStyle.FontName);
                //生成<显示文本> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" CssClass = \"btn btn-primary btn-sm\" ", strButtonText);
                //生成单击事件
                strCodeForCs.AppendFormat("\r\n" + "OnClick = \"{0}\" ", strOnClick);

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "></asp:Button>");

                intZIndex +=  1;

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
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放WebForm的代码;
            //			string strTemp;          ///临时变量;
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
                strCodeForCs.AppendFormat("\r\n" + "position: {0}; top: {1}px\" ",
                    objDropDownLstStyle.StylePosition, objDropDownLstStyle.StyleTop);
                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                    objDropDownLstStyle.Runat);
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "Width = \"{0}px\" Height = \"{1}px\" ",
                    objDropDownLstStyle.Width, objDropDownLstStyle.Height);
                //生成<字号>和<字体>
                strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ",
                    objDropDownLstStyle.FontSize, objDropDownLstStyle.FontName);
                //生成<前景色>
                if (objDropDownLstStyle.ForeColor !=  "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "ForeColor = \"{0}\" ", objDropDownLstStyle.ForeColor);
                }
                //生成<背景色>
                if (objDropDownLstStyle.BackColor !=  "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "BackColor = \"{0}\" ", objDropDownLstStyle.BackColor);
                }
                //生成<文本字段>
                if (objDropDownLstStyle.DataTextField !=  "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "DataTextField = \"{0}\" ", objDropDownLstStyle.DataTextField);
                }
                //生成<值字段>
                if (objDropDownLstStyle.DataValueField !=  "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "DataValueField = \"{0}\" ", objDropDownLstStyle.DataValueField);
                }
                //生成<是否可见>
                if (objDropDownLstStyle.Visible  ==  true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "Visible = \"{0}\" ", objDropDownLstStyle.Visible);
                }

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "></asp:DropDownList>");

                intZIndex +=  1;

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
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放WebForm的代码;
            //			string strTemp;          ///临时变量;
            objLabelStyle.StyleZindex = intZIndex + 1;
            objLabelStyle.StyleLeft = (int)intCurrLeft;
            objLabelStyle.StyleTop = (int)intCurrTop;
            ///生成Label的代码;
            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" style = \"z-index: {1}; left: {2}px; position: absolute; top: {4}px\" ",
                strLabelId, objLabelStyle.StyleZindex, objLabelStyle.StyleLeft, objLabelStyle.StylePosition, objLabelStyle.StyleTop);
            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" Width = \"{1}px\" Height = \"{2}px\" CssClass = \"NameLabel\">",
                objLabelStyle.Runat, objLabelStyle.Width, objLabelStyle.Height);
            strCodeForCs.AppendFormat("{0}</asp:Label>",
                strLabelText);

            intZIndex +=  1;

            objGenCtlStyle.StyleZindex = intZIndex + 1;
            objGenCtlStyle.StyleLeft = (int)intCurrLeft + objLabelStyle.Width + 5;
            //objGenCtlStyle.StyleLeft = intCurrLeft + 5;
            objGenCtlStyle.StyleTop = (int)intCurrTop;
            ///生成右边控件的代码;

            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" style = \"z-index: {2}; left: {3}px; ",
                strCtlTypeName, strCtlId, objGenCtlStyle.StyleZindex, objGenCtlStyle.StyleLeft);
            strCodeForCs.AppendFormat("\r\n" + "position: absolute; top: {1}px\" ",
                objGenCtlStyle.StylePosition, objGenCtlStyle.StyleTop);

            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" Width = \"{1}px\" Height = \"{2}px\" CssClass = \"TextBox_Defa\">",
                objGenCtlStyle.Runat, objGenCtlStyle.Width, objGenCtlStyle.Height);
            strCodeForCs.AppendFormat("\r\n" + "</asp:{0}>",
                strCtlTypeName);
            intZIndex +=  1;
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
        public string GenCombineCtlNoPosition(clsLabelStyleEN objLabelStyle, string strLabelId, string strLabelText,
            clsGenCtlStyleEN objGenCtlStyle, string strCtlTypeName, string strCtlId)
        {
            StringBuilder strCodeForCs = new StringBuilder();    ///用来存放WebForm的代码;
            //			string strTemp;          ///临时变量;
            objLabelStyle.StyleZindex = intZIndex + 1;
            objLabelStyle.StyleLeft = (int)intCurrLeft;
            objLabelStyle.StyleTop = (int)intCurrTop;
            ///生成Label的代码;
            ///            
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" style = \"z-index: {1}; \" ",
                strLabelId, objLabelStyle.StyleZindex, objLabelStyle.StyleLeft, objLabelStyle.StylePosition, objLabelStyle.StyleTop);
            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" Width = \"{1}px\" Height = \"{2}px\" CssClass = \"NameLabel\">",
                objLabelStyle.Runat, objLabelStyle.Width, objLabelStyle.Height);
            strCodeForCs.AppendFormat("{0}</asp:Label>",
                strLabelText);
            strCodeForCs.Append("\r\n" + "</td>");

            intZIndex +=  1;

            objGenCtlStyle.StyleZindex = intZIndex + 1;
            objGenCtlStyle.StyleLeft = (int)intCurrLeft + objLabelStyle.Width + 5;
            //objGenCtlStyle.StyleLeft = intCurrLeft + 5;
            objGenCtlStyle.StyleTop = (int)intCurrTop;
            ///生成右边控件的代码;
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" style = \"z-index: {2};\" ",
                strCtlTypeName, strCtlId, objGenCtlStyle.StyleZindex, objGenCtlStyle.StyleLeft);

            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" Width = \"{1}px\" Height = \"{2}px\" CssClass = \"TextBox_Defa\">",
                objGenCtlStyle.Runat, objGenCtlStyle.Width, objGenCtlStyle.Height);
            strCodeForCs.AppendFormat("\r\n" + "</asp:{0}>",
                strCtlTypeName);
            strCodeForCs.Append("\r\n" + "</td>");

            intZIndex +=  1;
            return strCodeForCs.ToString();
        }



        #endregion

        ///以下均是界面层内容(VIEW) ==  == = 

        public string A_GenViewCode_Web(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //switch ((enumViewTypeCodeTab)objViewInfoENEx.ViewTypeCode)
            //{

            //    case enumViewTypeCodeTab.Table_Update_2:// "0002":	//单表修改
            //        return GenUpdRecViewCode(objViewInfoENEx, ref strRe_ClsName, ref strRe_FileNameWithModuleName);

            //    default:
            //        clsViewTypeCodeTabEN objViewTypeCodeTabEN = clsViewTypeCodeTabBL.GetObjByViewTypeCodeCache(objViewInfoENEx.ViewTypeCode);
            //        string strMsg = string.Format("界面类型：[{0}({1})]在函数:[{2}]中没有被处理,请联系管理员!",
            //            objViewTypeCodeTabEN.ViewTypeName,
            //            objViewInfoENEx.ViewTypeCode,
            //            clsStackTrace.GetCurrClassFunction());
            //        throw new Exception(strMsg);
            //}
            return "";
        }
        public string A_GeneFuncCode(clsViewInfoENEx objViewInfoENEx, string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {

                  
                    //case "LogError":
                    //    return GenLogError();
                    default:
                        string strMsg = string.Format("功能名:{1}在Switch没有处理,请检查!({0})",
                            clsStackTrace.GetCurrClassFunction(), strFuncName);
                        throw new Exception(strMsg);
                        //            return "///该1函数不存在:" + strFuncName;
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
        }

        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        public string A_GenCode4Function(clsViewInfoENEx objViewInfoENEx, string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
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
                    strTemp = A_GeneFuncCode(objViewInfoENEx, strFuncName);
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
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WebCtlViewCode4Html);
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

            clsViewRegionENEx obj = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
            if (obj != null && string.IsNullOrEmpty(obj.ClsName) == false)
            {
                this.ClsName = obj.ClsName;
                objViewInfoENEx.ClsName = this.ClsName;
            }
            else
            {
                this.ClsName = string.Format("wuc{0}", objViewInfoENEx.TabName_Out);
                objViewInfoENEx.ClsName = this.ClsName;
            }

        }
  
    }
}
