using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using CodeStruct;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Web.UI.WebControls;

namespace AutoGCLib
{

    partial class WA_ViewScriptCS_TS4TypeScript : clsGeneCodeBase4View
    {
        //protected clsFuncModule_AgcEN objFuncModuleEN = null;
        protected string strCacheVarStr1 = "";//缓存变量串,就是缓存变量在该界面中的表现形式
        protected string strCacheVarStr2 = "";//缓存变量串,就是缓存变量在该界面中的表现形式

        protected string strMapFuncCode = "";
        protected string strMapFuncCode4ExcelExport = "";
        //public List<string> arrTabId4MapFunc = null;// new List<string>();

        protected clsPrjTabENEx objPrjTabEx_ListRegion = null;

        protected string strSqlDsTypeId4ListRegion = "";

        protected string strFuncName4BindGv = "";
        protected List<clsPropertyDef4GC> arrPropertyDef4GC = null;

        //private string strVarDef4GivingValue = "";

        clsBiDimDistribute objBiDimDistribue4Qry = null;
        #region 构造函数
        public WA_ViewScriptCS_TS4TypeScript()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strBaseUrl = "../../TS";
            this.arrImportClass = new List<ImportClass>();
        }
        public WA_ViewScriptCS_TS4TypeScript(string strViewId)
       : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strBaseUrl = "../../TS";
            this.strDataBaseType = clsPubConst.con_MsSql;

            this.arrImportClass = new List<ImportClass>();
        }
        public WA_ViewScriptCS_TS4TypeScript(string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strBaseUrl = "../../TS";
            this.strDataBaseType = clsPubConst.con_MsSql;

            this.GetClsName();


            this.arrImportClass = new List<ImportClass>();
            GetCacheParaVarStr();
        }


        #endregion

        public string Gen_WApi_Ts_Page_Load()
        {
            if (PrjTabEx_ListRegion.IsUseStorageCache_TS()) return "";

            string strFuncName = "PageLoad";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:页面导入,当页面开始运行时所发生的事件");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public async PageLoad()");

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.PageLoad.name;",
                    ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                //strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //生成PageLoad中的绑定下拉框的代码
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//初始设置，用来初始化一些变量值");
                strCodeForCs.Append("\r\n" + "await this.InitVarSet();");
                //建立缓存
                //strCodeForCs.Append("\r\n" + "//建立缓存");
                //设置事件函数
                //if (strFuncName4BindGv != "")
                //{
                //    strCodeForCs.Append("\r\n" + "this.SetEventFunc();");
                //}
                //strCodeForCs.Append("\r\n" + "clsPubFun.SetCommFun4BL();");
                List<string> arrTabName = new List<string>();
                var objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
                //if (objViewRegion != null
                //    && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true
                //    && objViewRegion.IsDispInViewInfo(objViewInfoENEx) == true)
                //{
                //    strCodeForCs.Append("\r\n // 为查询区绑定下拉框");
                //    strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4QueryRegion();", ThisClsName);
                //}

                //strCodeForCs.Append("\r\n // 为功能区绑定下拉框");
                //strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4FeatureRegion();", ThisClsName);

                strCodeForCs.Append("\r\n" + "//初始化界面控件值，放在绑定下拉框之后");
                strCodeForCs.Append("\r\n" + "await this.InitCtlVar();");

                //strCodeForCs.Append("\r\n" + Gen_WApi_Ts_DdlBind4ViewFeatureInPage_Load());


                //if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                //{
                if (string.IsNullOrEmpty(TabName_Out4ListRegion4GC) == false)
                {

                    strCodeForCs.Append("\r\n" + $"if (viewVarSet.sort{TabName_Out4ListRegion4GC}By == '') viewVarSet.sort{TabName_Out4ListRegion4GC}By = `${{ cls{TabName_Out4ListRegion4GC}EN.con_{objViewInfoENEx.FirstSortField} }} Asc`;");

                    strCodeForCs.Append("\r\n" + "//2、显示无条件的表内容在GridView中");

                    strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `页面启动不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_Page_LoadCache()
        {

            string strFuncName = "PageLoadCache";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:页面导入,当页面开始运行时所发生的事件");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public async PageLoadCache()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.PageLoadCache.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                //strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //生成PageLoad中的绑定下拉框的代码
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//初始设置，用来初始化一些变量值");
                strCodeForCs.Append("\r\n" + "await this.InitVarSet();");
                //建立缓存
                //strCodeForCs.Append("\r\n" + "clsPubFun.SetCommFun4BL();");
                List<string> arrTabName = new List<string>();

                //var objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
                //if (objViewRegion != null
                //    && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true
                //    && objViewRegion.IsDispInViewInfo(objViewInfoENEx) == true)
                //{
                //    strCodeForCs.Append("\r\n // 为查询区绑定下拉框");
                //    strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4QueryRegion();", ThisClsName);
                //}
                //strCodeForCs.Append("\r\n // 为功能区绑定下拉框");
                //strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4FeatureRegion();", ThisClsName);

                strCodeForCs.Append("\r\n" + "//初始化界面控件值，放在绑定下拉框之后");
                strCodeForCs.Append("\r\n" + "await this.InitCtlVar();");

                //strCodeForCs.Append("\r\n" + Gen_WApi_Ts_DdlBind4ViewFeatureInPage_Load());
                if (strFuncName4BindGv != "")
                {
                    //设置事件函数
                    //strCodeForCs.Append("\r\n" + "this.SetEventFunc();");

                    //if (objViewInfoENEx.objViewRegion_List.AllowSorting() == true)
                    //{
                    strCodeForCs.Append("\r\n" + $"if (viewVarSet.sort{TabName_Out4ListRegion4GC}By == '') viewVarSet.sort{TabName_Out4ListRegion4GC}By = `${{ cls{TabName_Out4ListRegion4GC}EN.con_{objViewInfoENEx.FirstSortField} }} Asc`;");

                    strCodeForCs.Append("\r\n" + "//2、显示无条件的表内容在GridView中");

                    strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `页面启动不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_DdlBind()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;


                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        if (objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "boolean")
                        {
                        }
                        else
                        {
                            //string strDS_DataValueField;
                            //string strDS_DataTextField;
                            string strDsTabName;
                            string strDS_TabCnName;
                            try
                            {
                                clsPrjTabEN objPrjTab = clsEditRegionFldsBLEx.InitDs_PrjTab4Get(objEditRegionFldsEx);
                                strDsTabName = objPrjTab.TabName;
                                strDS_TabCnName = objPrjTab.TabCnName;
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源表名出错:{2}.",
                                objViewInfoENEx.ViewName, "编辑区域", objException.Message);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDsTabName) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 数据源表名为空,请检查!({2}).",
                                objViewInfoENEx.ViewName, "编辑区域", clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            //try
                            //{
                            //    strDS_DataValueField = clsEditRegionFldsBLEx.InitDs_DataValueField(objEditRegionFldsEx);
                            //}
                            //catch (Exception objException)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源值字段名时出错:{2}.<br/>数据源表名为:{3}.",
                            //    objViewInfoENEx.ViewName, "编辑区域", objException.Message, strDsTabName);
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            //if (string.IsNullOrEmpty(strDS_DataValueField) == true)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源值字段名时出错.<br/>数据源表名为:{2}.({3})",
                            //        objViewInfoENEx.ViewName, "编辑区域", strDsTabName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            //try
                            //{
                            //    strDS_DataTextField = clsEditRegionFldsBLEx.InitDs_DataTextField(objEditRegionFldsEx);
                            //}
                            //catch (Exception objException)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源文本字段名时出错:{2}.<br/>数据源表名为:{3},值字段名为:{4}.",
                            //    objViewInfoENEx.ViewName, "编辑区域", objException.Message, strDsTabName, strDS_DataValueField);
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            //if (string.IsNullOrEmpty(strDS_DataTextField) == true)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源文本字段名时出错.<br/>数据源表名为:{2},值字段名为:{3}.({4})",
                            //          objViewInfoENEx.ViewName, "编辑区域", strDsTabName, strDS_DataValueField,
                            //          clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            //if (arrDdlKeyIdLst.Contains(strDS_DataValueField) == false)
                            //{
                            //    arrDdlKeyIdLst.Add(strDS_DataValueField);
                            //}
                            //else
                            //{
                            //    continue;
                            //}
                            switch (objEditRegionFldsEx.DdlItemsOptionId)
                            {
                                case "01": ///列表项串;
                                    //									string strTemp2 ;
                                    string delimStr = " ,.:";
                                    char[] delimiter = delimStr.ToCharArray();
                                    //									string words = "one two,three:four.";
                                    string[] split = null;
                                    int iItemNums;
                                    int i;

                                    strCodeForCs.AppendFormat("\r\n /** 绑定下拉框:ddl{0}的函数。", objEditRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + " **/");
                                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                    objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl_{0}.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                                    split = objEditRegionFldsEx.ItemsString.Split(delimiter);
                                    iItemNums = split.GetUpperBound(0);
                                    for (i = split.GetLowerBound(0); i <= iItemNums; i++)
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "objDDL.Items.Add(\"{0}\");", split[i]);
                                    }
                                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                                    strCodeForCs.Append("\r\n" + "//为下拉框设置内容的样例,该下拉框的列表项是直接添加的");
                                    strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"男\");");
                                    strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"女\");");
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "02": ///列表项数据源表;
                                    strCodeForCs.Append("\r\n /**");
                                    strCodeForCs.AppendFormat("\r\n * 为下拉框获取数据,从表:[{0}]中获取",
                                      strDsTabName);
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n * @returns 获取主键字段、名称字段两列的所有记录记录的DataTable");
                                    strCodeForCs.Append("\r\n **/");
                                    //strCodeForCs.AppendFormat("\r\n" + "public BindDdl_{1}(ddl{1}: string, strWhereCond:string=\"1=1\") {{",
                                    //  strDsTabName, strDS_DataValueField, strDS_DataTextField, objEditRegionFldsEx.CtrlId);
                                    //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl_{0}.name;", strDS_DataValueField);
                                    //strCodeForCs.Append("\r\n" + "//let strWhereCond = \" 1 =1 \";");
                                    //strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(ddl{1});",
                                    //    strDsTabName, strDS_DataValueField, strDS_DataTextField);
                                    //strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                                    //strCodeForCs.Append("\r\n" + "{");
                                    //strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"下拉框：{{0}} 不存在!\", ddl{1});",
                                    //    strDsTabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                    strCodeForCs.Append("\r\n" + "//console.trace();");
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

                                    strCodeForCs.Append("\r\n" + "try");
                                    strCodeForCs.Append("\r\n" + "{");


                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "catch (e)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "const strMsg = `绑定下拉框不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                                    strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                    strCodeForCs.Append("\r\n" + "//console.trace();");
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "});");
                                    strCodeForCs.Append("\r\n" + "}");


                                    break;
                                case "03": ///列表项数据源SQL串;
                                    strCodeForCs.Append("\r\n /**");
                                    strCodeForCs.AppendFormat("\r\n * 为下拉框获取数据,从Sql串:[{0}]中获取",
                                       objEditRegionFldsEx.DsSqlStr);
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n * @returns 获取自定义的Sql串中两列的所有记录记录的DataTable");
                                    strCodeForCs.Append("\r\n **/");

                                    strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}(string strCondition)",
                                    objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Get{0}.name;", objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
                                    //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = {0}GetSpecSQLObj();", ViewMainTabName4GC);

                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable({0});",
                                    objEditRegionFldsEx.DsSqlStr);
                                    strCodeForCs.Append("\r\n" + "return objDT;");
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.Append("\r\n /** 绑定基于Web的下拉框");
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n * @param objDDL:需要绑定当前表的下拉框");
                                    strCodeForCs.Append("\r\n" + " **/");
                                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                    objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl_{0}.name;", objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                                    objEditRegionFldsEx.FldName);
                                    //strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};",
                                    //  strDsTabName, strDS_DataValueField);
                                    //strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};",
                                    //  strDsTabName, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = objDT;");
                                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }



        public string Gen_WApi_Ts_BindDdl4QueryRegion()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            List<ASPDropDownListEx> arrASPDropDownListObj_Query
                = objViewInfoENEx.arrASPDropDownListObj.Where(x => x.RegionTypeId == enumRegionType.QueryRegion_0001).ToList();
            try
            {
                strCodeForCs.Append("\r\n /** 函数功能:为查询区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async BindDdl4QueryRegion()", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");

                var objFuncParaLstAll = new FuncParaLst("AllDdlParaLst", this.IsFstLcase, enumAppLevel.InvokeFunc);

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Query)
                {
                    List<string> arrCondFldId;
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true)
                    {
                        if (objInfor.CsType == "bool")
                        {
                            objInfor.CodeText = "\r\n" + $"BindDdl_TrueAndFalseInDivObj(divVarSet.refDivQuery, \"{objInfor.CtrlId}\");";
                            ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Web.js", "BindDdl_TrueAndFalseInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                        }
                        continue;
                    }
                    var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                    var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                    var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                    arrCondFldId = objTabFeature.GetCondFldIdLst();
                    if (arrTabFeatureFlds_Cond.Count == 0)
                    {
                        objInfor.VarIdCond1 = "";
                        objInfor.VarIdCond2 = "";
                        objInfor.FldIdCond1 = "";
                        objInfor.FldIdCond2 = "";
                    }
                    else if (arrTabFeatureFlds_Cond.Count == 1)
                    {
                        objInfor.VarIdCond2 = "";
                        objInfor.FldIdCond2 = "";
                    }

                    try
                    {
                        Tuple<string, string> tup;
                        //if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true)
                        //{
                        //    //tup = this.Gen_WApi_Ts_DefineVar4Ddl(objInfor, objVarManage);
                        //}
                        //else
                        //{
                        tup = this.Gen_WApi_Ts_DefineVar4Ddl4TabFeature(objInfor, arrCondFldId, objFuncParaLstAll);
                        //}
                        //
                        string strVar4Cond = tup.Item1;
                        string strFuncParaLst_Additional = tup.Item2;//函数参数变量列表

                        if (objInfor.CsType == "bool")
                        {
                            objInfor.CodeText = string.Format("\r\n" + $"BindDdl_TrueAndFalseInDivObj(divVarSet.refDivQuery, \"{0}\");",
                                     objInfor.CtrlId);
                            ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Web.js", "BindDdl_TrueAndFalseInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                        }
                        else
                        {
                            objInfor.CodeText = string.Format("\r\n" + "await this.SetDdl_{0}InDiv({1});//{2}",
                                            objInfor.FldName,
                                            strFuncParaLst_Additional,
                                            clsRegionTypeBL.GetNameByRegionTypeIdCache(objInfor.RegionTypeId));
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = objException.Message;
                    }
                }

                strCodeForCs.Append("\r\n" + objFuncParaLstAll.GetVarLstDefStr(ThisClsName, this, this.strBaseUrl));

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Query)
                {
                    strCodeForCs.Append("\r\n" + objInfor.CodeText);
                }


                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_BindDdl4FeatureRegion()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };
            IEnumerable<clsViewFeatureFldsENEx> arrWFF4DropDownLst = objViewInfoENEx.arrViewFeatureFlds.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
            List<ASPDropDownListEx> arrASPDropDownListObj4WFF = arrWFF4DropDownLst
                .Select(GetDdlObj2).Distinct(new ASPDropDownListEx4GCComparer()).ToList();


            try
            {
                strCodeForCs.Append("\r\n /** 函数功能:为功能区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async BindDdl4FeatureRegion()", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");
                //         strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl4QueryRegion.name;",
                //ViewMainTabName4GC, objKeyField.FldName);

                //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager\");");

                var objFuncParaLstAll = new FuncParaLst("AllDdlParaLst", this.IsFstLcase, enumAppLevel.InvokeFunc);

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {
                    List<string> arrCondFldId;
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true)
                    {
                        if (objInfor.CsType == "bool")
                        {
                            objInfor.CodeText = "\r\n" + $"BindDdl_TrueAndFalseInDivObj(divVarSet.refDivFunction, \"{objInfor.CtrlId}\");";
                        }

                        continue;
                    }

                    var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                    var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                    var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                    arrCondFldId = objTabFeature.GetCondFldIdLst();
                    if (arrTabFeatureFlds_Cond.Count == 0)
                    {
                        objInfor.VarIdCond1 = "";
                        objInfor.VarIdCond2 = "";
                        objInfor.FldIdCond1 = "";
                        objInfor.FldIdCond2 = "";
                    }
                    else if (arrTabFeatureFlds_Cond.Count == 1)
                    {
                        objInfor.VarIdCond2 = "";
                        objInfor.FldIdCond2 = "";
                    }

                    try
                    {
                        Tuple<string, string> tup;
                        //if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true)
                        //{
                        //    //tup = this.Gen_WApi_Ts_DefineVar4Ddl(objInfor, objVarManage);
                        //}
                        //else
                        //{
                        tup = this.Gen_WApi_Ts_DefineVar4Ddl4TabFeature(objInfor, arrCondFldId, objFuncParaLstAll);
                        //}
                        //
                        string strVar4Cond = tup.Item1;
                        string strFuncParaLst_Additional = tup.Item2;//函数参数变量列表

                        if (objInfor.CsType == "bool")
                        {
                            objInfor.CodeText = string.Format("\r\n" + $"BindDdl_TrueAndFalseInDivObj(divVarSet.refDivFunction, \"{0}\");",
                                     objInfor.CtrlId);
                        }
                        else
                        {
                            objInfor.CodeText = string.Format("\r\n" + "await this.SetDdl_{0}InDivInFeature({1});//{2}",
                                            objInfor.FldName,
                                            strFuncParaLst_Additional,
                                            clsRegionTypeBL.GetNameByRegionTypeIdCache(objInfor.RegionTypeId));
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = objException.Message;
                    }
                }

                strCodeForCs.Append("\r\n" + objFuncParaLstAll.GetVarLstDefStr(ThisClsName, this, this.strBaseUrl));

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {
                    strCodeForCs.Append("\r\n" + objInfor.CodeText);
                }


                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public Tuple<string, string> Gen_WApi_Ts_DefineVar4Ddl4TabFeature(ASPDropDownListEx objInfor, List<string> arrCondFldId, FuncParaLst objFuncParaLstAll)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            var objFuncParaLst = new FuncParaLst("DdlParaLst", this.IsFstLcase, enumAppLevel.InvokeFunc);
            objFuncParaLst.AddParaByVar(objInfor.VarIdCond1, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);
            objFuncParaLstAll.AddParaByVar(objInfor.VarIdCond1, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);

            objFuncParaLst.AddParaByVar(objInfor.VarIdCond2, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);
            objFuncParaLstAll.AddParaByVar(objInfor.VarIdCond2, enumProgLangType.TypeScript_09, tsVarFunction.tsCondition);
            if (string.IsNullOrEmpty(objInfor.DsTabId) == false)
            {
                var objPrjTabENEx_Ddl = clsPrjTabBLEx.GetObjAllInfoEx(objInfor.DsTabId, objInfor.PrjId);
                var objCacheClassify_TS = clsPrjTabBLEx.GetCacheClassify_TSByObjEx(objPrjTabENEx_Ddl);

                objFuncParaLst.AddParaByCacheClassify4View(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09, objViewInfoENEx.ViewId, this.PrjId);
                objFuncParaLstAll.AddParaByCacheClassify4View(objCacheClassify_TS, arrCondFldId, enumProgLangType.TypeScript_09, objViewInfoENEx.ViewId, this.PrjId);

            }


            string strFuncParaLst_Additional = objFuncParaLst.GetCondFldLst();

            if (objFuncParaLst.GetLst != null)
            {
                foreach (var objInFor in objFuncParaLst.GetLst)
                {
                    if (string.IsNullOrEmpty(objInFor.FilePath) == true) continue;
                    ImportClass objImportClass = AddImportClass(objViewInfoENEx.MainTabId, objInFor.FilePath, objInFor.ClsName, enumImportObjType.CustomFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                    if (objInFor.VarTypeId == tsVarType.tsCache)
                    {
                        clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objInFor.FldLen, objInFor.VarName, this.ClsName);

                    }
                }
            }
            //List<string> arrConditionFldName = new List<string>();

            //clsFieldTabEN objFieldTab_Cond1 =
            //    string.IsNullOrEmpty(objInfor.FldIdCond1) ? null :
            //    clsFieldTabBL.GetObjByFldIdCache(objInfor.FldIdCond1, objViewInfoENEx.PrjId);
            //var objQryRegionFldsENEx = clsQryRegionFldsBLEx.CopyToEx(objInfor.objQryRegionFldsEN);
            //clsFieldTabEN objFieldTab_Cond2 = string.IsNullOrEmpty(objInfor.FldIdCond2) ? null :
            //    clsFieldTabBL.GetObjByFldIdCache(objInfor.FldIdCond2, objQryRegionFldsENEx.PrjId());

            string strVar4Cond = "";

            objInfor.CodeText = strCodeForCs.ToString();
            Tuple<string, string> tup = new Tuple<string, string>(strVar4Cond, strFuncParaLst_Additional);

            return tup;
        }



        Func<clsQryRegionFldsENEx, ASPDropDownListEx> GetDdlObj = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        public string Gen_WApi_Ts_SetBindDdl4QryRegion()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrQryRegionFldSet == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };
                IEnumerable<clsQryRegionFldsENEx> arrERF4DropDownLst = objViewInfoENEx.arrQryRegionFldSet
                    .Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId) && x.InUse == true);
                IEnumerable<ASPDropDownListEx> arrASPDropDownListObj = arrERF4DropDownLst.Select(GetDdlObj);

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj)
                {

                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true) continue;

                    clsTabFeatureEN objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                    //var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                    //var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();

                    var arrTabFeatureFldsEx = objTabFeature.arrTabFeatureFldsSetEx();
                    var arrTabFeatureFlds_Cond = arrTabFeatureFldsEx.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();

                    var arrCondFldId = objTabFeature.GetCondFldIdLst();
                    if (arrTabFeatureFlds_Cond.Count == 0)
                    {
                        objInfor.VarIdCond1 = "";
                        objInfor.VarIdCond2 = "";
                        objInfor.FldIdCond1 = "";
                        objInfor.FldIdCond2 = "";
                    }
                    else if (arrTabFeatureFlds_Cond.Count == 1)
                    {
                        objInfor.VarIdCond2 = "";
                        objInfor.FldIdCond2 = "";
                    }
                    objInfor.objTabFeature = objTabFeature;
                    objInfor.DivName = $"divVarSet.refDivQuery";
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendLine(objInfor.GC_SetBindDdl4Bool_TS4QueryEdit(this, this.strBaseUrl));
                    }
                    else if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == false)
                    {
                        var objPrjTabENEx_Ddl = clsPrjTabBLEx.GetObjAllInfoEx(objInfor.DsTabId, objInfor.PrjId);
                        var objCacheClassify_TS = clsPrjTabBLEx.GetCacheClassify_TSByObjEx(objPrjTabENEx_Ddl);

                        if (string.IsNullOrEmpty(objTabFeature.FuncNameJs) == true)
                        {
                            var tuple = clsTabFeatureBLEx.GetFuncName(objTabFeature);
                            objTabFeature.FuncNameJs = tuple.Item2;
                            //print(tuple.Item1);
                            //print(int.Parse(tuple.Item2));
                        }
                        strCodeForCs.Append(objInfor.GC_SetBindDdl4TabFeature4QueryEdit_TS(this.IsFstLcase, $"divVarSet.refDivQuery", objCacheClassify_TS, arrTabFeatureFlds_Cond, arrCondFldId, null, "",
                            objViewInfoENEx.ViewId,
                            this, this.strBaseUrl));
                    }
                    else
                    {
                        //strCodeForCs.Append(objInfor.GC_SetBindDdl_TS4QryRegion(this, this.strBaseUrl));
                    }
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                ElementType = CodeElementType.Method,              
                Name = "SetBindDdl4QryRegion",
                isPublic = true,
                isAsync = true,
                isStatic = false,
                isVirtual = false,
                isOverride = false,
                isAbstract = false,
                CodeContent = strCodeForCs.ToString(),
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_SetBindDdl4FeatureRegion()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };
                //IEnumerable<clsQryRegionFldsENEx> arrERF4DropDownLst = objViewInfoENEx.arrQryRegionFldSet
                //    .Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId) && x.InUse == true);
                //IEnumerable<ASPDropDownListEx> arrASPDropDownListObj = arrERF4DropDownLst.Select(GetDdlObj);
                IEnumerable<clsViewFeatureFldsENEx> arrWFF4DropDownLst = objViewInfoENEx.arrViewFeatureFlds.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                List<ASPDropDownListEx> arrASPDropDownListObj4WFF = arrWFF4DropDownLst
                    .Select(GetDdlObj2).Distinct(new ASPDropDownListEx4GCComparer()).ToList();
                var objFuncParaLstAll = new FuncParaLst("AllDdlParaLst", this.IsFstLcase, enumAppLevel.InvokeFunc);


                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true) continue;
                    clsTabFeatureEN objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                    var arrTabFeatureFldsEx = objTabFeature.arrTabFeatureFldsSetEx();
                    var arrTabFeatureFlds_Cond = arrTabFeatureFldsEx.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();

                    var arrCondFldId = objTabFeature.GetCondFldIdLst();
                    if (arrTabFeatureFlds_Cond.Count == 0)
                    {
                        objInfor.VarIdCond1 = "";
                        objInfor.VarIdCond2 = "";
                        objInfor.FldIdCond1 = "";
                        objInfor.FldIdCond2 = "";
                    }
                    else if (arrTabFeatureFlds_Cond.Count == 1)
                    {
                        objInfor.VarIdCond2 = "";
                        objInfor.FldIdCond2 = "";
                    }
                    objInfor.objTabFeature = objTabFeature;
                    objInfor.DivName = $"divVarSet.refDivFunction";
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendLine(objInfor.GC_SetBindDdl4Bool_TS4QueryEdit(this, this.strBaseUrl));
                    }
                    else if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == false)
                    {
                        var objPrjTabENEx_Ddl = clsPrjTabBLEx.GetObjAllInfoEx(objInfor.DsTabId, objInfor.PrjId);
                        var objCacheClassify_TS = clsPrjTabBLEx.GetCacheClassify_TSByObjEx(objPrjTabENEx_Ddl);

                        if (string.IsNullOrEmpty(objTabFeature.FuncNameJs) == true)
                        {
                            var tuple = clsTabFeatureBLEx.GetFuncName(objTabFeature);
                            objTabFeature.FuncNameJs = tuple.Item2;
                            //print(tuple.Item1);
                            //print(int.Parse(tuple.Item2));
                        }
                        strCodeForCs.Append(objInfor.GC_SetBindDdl4TabFeature4QueryEdit_TS(this.IsFstLcase, $"divVarSet.refDivFunction", objCacheClassify_TS, arrTabFeatureFlds_Cond, arrCondFldId, null, "InFeature",
                            objViewInfoENEx.ViewId,
                            this, this.strBaseUrl));
                    }
                    else
                    {
                        //strCodeForCs.Append(objInfor.GC_SetBindDdl_TS4QryRegion(this, this.strBaseUrl));
                    }
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_DdlBind4ViewFeatureInPage_Load()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strCacheClassifyFldName4View = "";
            string strCacheClassifyFldName4View2 = "";
            if (thisCacheClassify4View.IsHasCacheClassfyFld == true)
            {
                strCacheClassifyFldName4View = thisCacheClassify4View.FldName;
            }
            if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true)
            {
                strCacheClassifyFldName4View2 = thisCacheClassify4View.FldName2;
            }
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {


                //clsASPDropDownListBLEx.
                List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };

                //从界面功能字段中获取下拉框字段

                IEnumerable<clsViewFeatureFldsENEx> arrWFF4DropDownLst = objViewInfoENEx.arrViewFeatureFlds.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                List<ASPDropDownListEx> arrASPDropDownListObj4WFF = arrWFF4DropDownLst
                    .Select(GetDdlObj2).Distinct(new ASPDropDownListEx4GCComparer()).ToList();
                var objFuncParaLstAll = new FuncParaLst("AllDdlParaLst", this.IsFstLcase, enumAppLevel.InvokeFunc);

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {

                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true) continue;

                    clsTabFeatureEN objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                    var arrTabFeatureFldsEx = objTabFeature.arrTabFeatureFldsSetEx();
                    var arrTabFeatureFlds_Cond = arrTabFeatureFldsEx.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();

                    var arrCondFldId = objTabFeature.GetCondFldIdLst();
                    if (arrTabFeatureFlds_Cond.Count == 0)
                    {
                        objInfor.VarIdCond1 = "";
                        objInfor.VarIdCond2 = "";
                        objInfor.FldIdCond1 = "";
                        objInfor.FldIdCond2 = "";
                    }
                    else if (arrTabFeatureFlds_Cond.Count == 1)
                    {
                        objInfor.VarIdCond2 = "";
                        objInfor.FldIdCond2 = "";
                    }

                    CacheClassify objCacheClassify_TS = null;
                    if (string.IsNullOrEmpty(objInfor.DsTabId) == false)
                    {
                        var objPrjTabENEx_Ddl = clsPrjTabBLEx.GetObjAllInfoEx(objInfor.DsTabId, objInfor.PrjId);
                        objCacheClassify_TS = clsPrjTabBLEx.GetCacheClassify_TSByObjEx(objPrjTabENEx_Ddl);
                    }


                    string strCtrlId = objInfor.CtrlId;
                    if (string.IsNullOrEmpty(strCtrlId) == true)
                    {
                        strCtrlId = string.Format("ddl{0}", objInfor.FldName);
                    }
                    if (objInfor.FeatureId == enumPrjFeature.SetFieldValue_0148)
                    {
                        if (strCtrlId.IndexOf("_SetFldValue") == -1)
                        {
                            strCtrlId = strCtrlId + "_SetFldValue";
                            objInfor.CtrlId = strCtrlId;
                        }
                    }

                    if (string.IsNullOrEmpty(objTabFeature.FuncNameJs) == true)
                    {
                        var tuple = clsTabFeatureBLEx.GetFuncName(objTabFeature);
                        objTabFeature.FuncNameJs = tuple.Item2;
                        //print(tuple.Item1);
                        //print(int.Parse(tuple.Item2));
                    }
                    objInfor.DivName = $"divVarSet.refDivList";


                    objInfor.CodeText = objInfor.GC_SetBindDdl4TabFeature4QueryEdit_TS(this.IsFstLcase, $"divVarSet.refDivFunction", objCacheClassify_TS, arrTabFeatureFldsEx, arrCondFldId, objFuncParaLstAll, "InFeature",
objViewInfoENEx.ViewId, this, this.strBaseUrl);
                    //}
                }

                strCodeForCs.Append("\r\n" + objFuncParaLstAll.GetVarLstDefStr(ThisClsName, this, this.strBaseUrl));

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {
                    strCodeForCs.Append("\r\n" + objInfor.CodeText);
                }

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string GenePubVar4DataListView()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "//专门用于数据列表的界面变量,用于分页功能等");
            strCodeForCs.Append("\r\n" + "public currPageIndex = 0;");
            //strCodeForCs.Append("\r\n" + "public divList: HTMLDivElement;  //列表区的层对象");
            //strCodeForCs.Append("\r\n" + "public static divDataLst: HTMLDivElement;  //列表中数据区的层对象");
            //strCodeForCs.Append("\r\n" + "public static divPager: HTMLDivElement;  //列表中的分页区的层对象");
            //strCodeForCs.Append("\r\n" + "public divName4List = \"divList\";  //列表区的层Id");
            strCodeForCs.Append("\r\n" + "public divName4DataList = \"divDataLst\";  //列表中数据区的层Id");
            strCodeForCs.Append("\r\n" + "public divName4Pager = \"divPager\";  //列表中的分页区的层Id");
            //strCodeForCs.Append("\r\n" + "public bolIsInitShow = false;  //记录是否导入分页区的变量");
            strCodeForCs.Append("\r\n" + "public bolIsTableSm = true;//是否窄行的小表,即表中加样式： table-sm");
            strCodeForCs.Append("\r\n" + "public listPara: ListPara;//是否窄行的小表,即表中加样式： table-sm");

            //strCodeForCs.Append("\r\n" + "//public mstrListDiv = \"divDataLst\";//列表区数据列表层id");
            strCodeForCs.Append("\r\n" + "public objPager: clsPager;");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 设置缓存参数变量
        /// </summary>
        /// <param name="objPrjTab"></param>
        /// <returns></returns>
        private bool GetCacheParaVarStr()
        {
            var strTabId = "";
            if (objViewInfoENEx.objViewRegion_List != null)
            {
                strTabId = objViewInfoENEx.objViewRegion_List.TabId;
            }
            else
            {
                strTabId = objViewInfoENEx.MainTabId;
            }
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, objViewInfoENEx.PrjId);

            if (thisCacheClassify4View.IsHasCacheClassfyFld == true)
            {

            }
            return true;
        }
        /// <summary>
        /// 生成App页面后台代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            var objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            //让用户设置属性;
            if (objViewInfoENEx.arrQryRegionFldSet == null && objViewInfoENEx.arrDGRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("不需要生成代码。当前所选界面名称:{0},类型:{1}.在该界面中没有查询区域和列表区域。请检查!",
                    strViewName, objCodeType.CodeTypeName);
                throw new clsDbObjException(sbMessage.ToString());
            }

            var objPrjTab_ListRegion = clsPrjTabBL.GetObjByTabIdCache(TabId_Out4ListRegion, objViewInfoENEx.PrjId);
            if (objPrjTab_ListRegion != null)
            {
                strSqlDsTypeId4ListRegion = objPrjTab_ListRegion.SqlDsTypeId;
            }

            objPrjTabEx_ListRegion = clsPrjTabBLEx.CopyToEx(objPrjTab_ListRegion);
            objPrjTabEx_ListRegion.GetObjAllInfoEx();

            if (this.IsUseFunc)
            {
                strFuncName4BindGv = string.Format("BindGv_{0}4Func", TabName_Out4ListRegion4GC);
            }
            else
            {
                if (PrjTabEx_ListRegion.IsUseStorageCache_TS())
                {
                    strFuncName4BindGv = string.Format("BindGv_{0}Cache", TabName_Out4ListRegion4GC);
                }
                else
                {
                    strFuncName4BindGv = string.Format("BindGv_{0}", TabName_Out4ListRegion4GC);
                }
            }
            //string strResult = "";

            string strFuncName = "";
            string strTemp = ""; ///临时变量;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);

            objViewInfoENEx.WebFormName = ThisClsName;
            objViewInfoENEx.WebFormFName = string.Format("{0}.ts", ThisClsName);

            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objCodeType, objFuncModuleEN, objViewInfoENEx, ViewMainTabName4GC);

            //strXmlFileName = strXmlFileName.ToLower();
            //objViewInfoENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            try
            {
                //准备数据

                //准备数据
                //获取界面所需要的公共变量

                this.GetViewPubVarLst(this.TabId_In4Edit);


                //生成所有的函数
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                    clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);

                //为所有的函数定义相关输入控件
                List<string> arrValueLst = new List<string>();

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    objvFunction4GeneCodeEN.CodeText = strTemp;
                }

                //类名开始
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx, this.CmPrjId));

                strCodeForCs.Append("\r\n" + "//import $ from \"jquery\";");

                GetImportClassLst(objFuncModuleEN);

                arrImportClass = arrImportClass.Distinct(new ImportClass4GCComparer()).ToList();
                foreach (var objInFor in arrImportClass)
                {
                    strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from \"{1}\";",
                      objInFor.ClsName,
                        objInFor.FilePath);
                }
                               

                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + "* 宣布一个已经在其他地方定义存在的变量strUrl_Session_SetString,");
                strCodeForCs.Append("\r\n" + "* 用于定义处理Session-设置String函数的地址");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "declare var strUrl_Session_SetString:string;");
                strCodeForCs.Append("\r\n" + "declare var strUrl_Session_GetString: string;");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + "* 宣布一个已经在其他地方定义存在的变量strCurrPrjId,");
                strCodeForCs.Append("\r\n" + "* 用于定义当前工程Id");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "declare var strCurrPrjId: string;");

                //strCodeForCs.Append("\r\n" + "declare var $;");

                strCodeForCs.AppendFormat("\r\n /** {0} 的摘要说明。其中Q代表查询,U代表修改",
                    ThisClsName);
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "export abstract class  {0} implements clsOperateList", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "public static objPage_CRUD: {0};", ThisClsName);

                strCodeForCs.Append("\r\n" + "public static sortFunStatic: (ascOrDesc: string) => (x: any, y: any) => number;");
                //if (objViewInfoENEx.objViewRegion_ExportExcel != null)
                //{
                //    strCodeForCs.Append("\r\n" + "public static sortFunExportExcelStatic: (ascOrDesc: string) => (x: any, y: any) => number;");
                //}
                strCodeForCs.Append("\r\n" + "public static ascOrDesc4SortFun = \"Asc\";");
                strCodeForCs.AppendFormat("\r\n" + "public static sort{0}By = \"\";", TabName_Out4ListRegion4GC);

                strCodeForCs.Append("\r\n" + GenePubVar4DataListView());
                //strCodeForCs.Append("\r\n" + GeneViewCacheStaticVar());
                strCodeForCs.Append("\r\n" + GeneViewPubVar_TS(strFuncName));

                strCodeForCs.Append("\r\n" + "public divName4Query = \"divQuery\";  //查询区的层Id");


                strCodeForCs.Append("\r\n" + "public divName4Function = \"divFunction\";  //功能区的层Id");
                strCodeForCs.Append("\r\n" + "public divName4Layout = \"divLayout\";  //界面布局的层Id");
                strCodeForCs.Append("\r\n" + "constructor() {");
                //strCodeForCs.Append("\r\n" + "super();");
                strCodeForCs.AppendFormat("\r\n" + "{0}.objPage_CRUD = this;", ThisClsName);
                strCodeForCs.Append("\r\n" + "this.objPager = new clsPager(this);");

                strCodeForCs.Append("\r\n" + "}");

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "label",
                    CtrlId = string.Format("lblViewTitle", TabName_Out4ListRegion4GC),
                    PropertyName = string.Format("ViewTitle", TabName_Out4ListRegion4GC),
                    Comment = "设置界面标题-相当使用ViewState功能",
                    DataType = "string",
                    ParentDivName = $"divVarSet.refDivLayout"
                });

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "get",
                    ControlType = "label",
                    CtrlId = string.Format("lblViewTitle", TabName_Out4ListRegion4GC),
                    PropertyName = string.Format("ViewTitle", TabName_Out4ListRegion4GC),
                    Comment = "设置界面标题",
                    DataType = "string",
                    ParentDivName = $"divVarSet.refDivLayout"
                });

                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 每页记录数,在扩展类可以修改");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public get pageSize():number {");
                strCodeForCs.Append("\r\n" + "return 5;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "public recCount = 0;");

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "/** ");
                strCodeForCs.Append("\r\n" + "* 函数功能:初始设置，用来初始化一些变量值");
                strCodeForCs.Append("\r\n" + "**/");
                strCodeForCs.Append("\r\n" + "  public abstract InitVarSet() : void; ");

                strCodeForCs.Append("\r\n" + "/** ");
                strCodeForCs.Append("\r\n" + "* 函数功能:初始化界面控件值，放在绑定下拉框之后");
                strCodeForCs.Append("\r\n" + "**/");
                strCodeForCs.Append("\r\n" + "  public abstract InitCtlVar() : void; ");

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (string.IsNullOrEmpty(objvFunction4GeneCodeEN.CodeText) == false)
                    {
                        strCodeForCs.Append("\r\n" + objvFunction4GeneCodeEN.CodeText);
                    }
                }

                clsPubFun4GC.Gen_WApi_Ts_ControlProperty(strCodeForCs, arrPropertyDef4GC, $"divVarSet.refDivQuery", this, this.strBaseUrl);
                //strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public void Gen_WApi_Ts_ControlPropertyBak(StringBuilder strCodeForCs)
        {
            var arrPropertyDef4GC2 = arrPropertyDef4GC.OrderBy(x => x.PropertyName).Distinct(new PropertyDef4GCComparer()).ToList();

            arrPropertyDef4GC2.ForEach(x =>
            {
                if (string.IsNullOrEmpty(x.ParentDivName) == true)
                {
                    Gen_WApi_Ts_ControlProperty4One_NotInDiv(strCodeForCs, x);
                    return;
                }

                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * {0}", x.Comment);
                //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                string strIsStatic = "";
                if (x.IsStatic) strIsStatic = "static";
                switch (x.OperateType)
                {
                    case "get":
                        strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}():{2} {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);
                        strCodeForCs.AppendFormat("\r\n" + "const objDiv = $(`#${{ {0} }}`);", x.ParentDivName);

                        switch (x.ControlType)
                        {
                            case "checkbox":
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + "return objDiv.find(strId).prop(\"checked\");");
                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").prop(\"checked\");", x.CtrlId);
                                break;
                            case "input":
                            case "TextBox":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);

                                if (x.DataType == "number")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " var str{1} = objDiv.find(strId).val();", x.CtrlId, x.PropertyName);
                                    //strCodeForCs.AppendFormat("\r\n" + "const str{1} = $(\"#{0}\").val();", x.CtrlId, x.PropertyName);
                                    strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(str{0})) return 0;", x.PropertyName);
                                    strCodeForCs.AppendFormat("\r\n" + "return Number(str{0});", x.PropertyName);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).val();", x.CtrlId, x.PropertyName);

                                    //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                }
                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                break;
                            case "button":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"button\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"button[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).html();", x.CtrlId, x.PropertyName);

                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").html();", x.CtrlId);
                                break;
                            case "label":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"label\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"label[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).html();", x.CtrlId, x.PropertyName);

                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").html();", x.CtrlId);
                                break;
                            case "dropdownlist":
                            case "DropDownList":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"select\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"select[id ^= '{0}']\");", x.CtrlId);

                                if (x.DataType == "boolean")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " if (objDiv.find(strId).val() == \"0\") return false;", x.CtrlId);
                                    //strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return false;", x.CtrlId);
                                }
                                else if (x.DataType == "number")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " if (objDiv.find(strId).val() == \"0\") return 0;", x.CtrlId);
                                    //strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return 0;", x.CtrlId);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " if (objDiv.find(strId).val() == \"0\") return \"\";", x.CtrlId);
                                    //strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return \"\";", x.CtrlId);
                                }
                                strCodeForCs.AppendFormat("\r\n" + "return objDiv.find(strId).val();", x.CtrlId);
                                break;
                            case "ViewVariable":
                                strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "const strValue = sessionStorage.getItem(strKey) as string;");
                                strCodeForCs.Append("\r\n" + "return strValue;");

                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                break;
                            case "CacheClassifyFieldTS":
                                strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyFieldTS)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "const strValue = sessionStorage.getItem(strKey) as string;");
                                strCodeForCs.Append("\r\n" + "return strValue;");

                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                break;
                            case "GivenValue":
                                strCodeForCs.Append("\r\n" + "//针对给定值(GivenValue)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "const strValue = sessionStorage.getItem(strKey) as string;");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.Append("\r\n" + "return Number(strValue);");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "return strValue;");
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.Append("\r\n" + "return 0;");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "return \"\";");
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                break;
                        }
                        break;
                    case "set":
                        strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}(value: {2}) {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);
                        strCodeForCs.AppendFormat("\r\n" + "const objDiv = $(`#${{ {0} }}`);", x.ParentDivName);


                        switch (x.ControlType)
                        {
                            case "checkbox":
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).attr(\"checked\", value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").attr(\"checked\", value);", x.CtrlId);
                                break;
                            case "input":
                            case "TextBox":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).val(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                            case "button":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"button\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"button[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                                break;
                            case "label":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"label\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"label[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                                break;
                            case "Label":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"label\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"label[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                                break;
                            case "dropdownlist":
                            case "DropDownList":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"select\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"select[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).val(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                            case "ViewVariable":
                                strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");
                                break;
                            case "CacheClassifyFieldTS":
                                strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyFieldTS)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                                break;
                            case "GivenValue":
                                strCodeForCs.Append("\r\n" + "//针对给定值(GivenValue)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                        }
                        break;
                }
                strCodeForCs.Append("\r\n" + "}");
            });
        }

        public void Gen_WApi_Ts_ControlProperty4One_NotInDiv(StringBuilder strCodeForCs, clsPropertyDef4GC x)
        {
            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * {0}", x.Comment);
            //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            string strIsStatic = "";
            if (x.IsStatic) strIsStatic = "static";
            switch (x.OperateType)
            {
                case "get":
                    strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}():{2} {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);

                    switch (x.ControlType)
                    {
                        case "checkbox":
                        case "CheckBox":

                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").prop(\"checked\");", x.CtrlId);
                            break;
                        case "input":
                        case "TextBox":


                            if (x.DataType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "const str{1} = $(\"#{0}\").val();", x.CtrlId, x.PropertyName);
                                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(str{0})) return 0;", x.PropertyName);
                                strCodeForCs.AppendFormat("\r\n" + "return Number(str{0});", x.PropertyName);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            }
                            //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            break;
                        case "button":

                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").html();", x.CtrlId);
                            break;
                        case "dropdownlist":
                        case "DropDownList":

                            if (x.DataType == "boolean")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return false;", x.CtrlId);
                            }
                            else if (x.DataType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return 0;", x.CtrlId);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return \"\";", x.CtrlId);
                            }
                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            break;
                        case "ViewVariable":
                            strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                            strCodeForCs.Append("\r\n" + "const strValue = sessionStorage.getItem(strKey) as string;");
                            strCodeForCs.Append("\r\n" + "return strValue;");

                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "return \"\";");
                            break;
                        case "CacheClassifyFieldTS":
                            strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyFieldTS)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                            strCodeForCs.Append("\r\n" + "const strValue = sessionStorage.getItem(strKey) as string;");
                            strCodeForCs.Append("\r\n" + "return strValue;");

                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "return \"\";");
                            break;
                        case "GivenValue":
                            strCodeForCs.Append("\r\n" + "//针对给定值(GivenValue)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                            strCodeForCs.Append("\r\n" + "copnst strValue = sessionStorage.getItem(strKey) as string;");
                            if (x.DataType == "number")
                            {
                                strCodeForCs.Append("\r\n" + "return Number(strValue);");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "return strValue;");
                            }
                            strCodeForCs.Append("\r\n" + "}");
                            if (x.DataType == "number")
                            {
                                strCodeForCs.Append("\r\n" + "return 0;");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "return \"\";");
                            }
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            break;
                    }
                    break;
                case "set":
                    strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}(value: {2}) {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);


                    switch (x.ControlType)
                    {
                        case "checkbox":
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").attr(\"checked\", value);", x.CtrlId);
                            break;
                        case "input":
                        case "TextBox":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                            break;
                        case "button":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                            break;
                        case "Label":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                            break;
                        case "dropdownlist":
                        case "DropDownList":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                            break;
                        case "ViewVariable":
                            strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                            strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");
                            break;
                        case "CacheClassifyFieldTS":
                            strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyFieldTS)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                            strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                            break;
                        case "GivenValue":
                            strCodeForCs.Append("\r\n" + "//针对给定值(GivenValue)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在,直接返回");
                            strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                            strCodeForCs.Append("\r\n" + "}");
                            if (x.DataType == "number")
                            {
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                            }
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                            break;
                    }
                    break;
            }
            strCodeForCs.Append("\r\n" + "}");

        }

        public string Gen_WApi_Ts_BindTab(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objViewInfoENEx.arrDGRegionFldSet == null) return "";
            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds_GridRegion = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.RegionId == objViewInfoENEx.objViewRegion_Feature.RegionId);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n /** 显示{0}对象的所有属性值", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param divContainer:显示容器，其中包括divDataLst,divPager, divDataLst显示数据, divPager显示分页");
            strCodeForCs.AppendFormat("\r\n * @param arr{0}ObjLst:需要绑定的对象列表",
                ViewMainTabName4GC);
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindTab_{0}(divContainer: HTMLDivElement, arr{0}ObjLst: Array<cls{0}EN>) ",
                TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");



            strCodeForCs.Append("\r\n" + "if (divContainer == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}不存在!\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divContainer, 'divDataLst');");
            ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetDivObjInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            //strCodeForCs.Append("\r\n" + "const sstrFldName: Array < string > = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "const sstrColHeader: Array < string > = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "sstrFldName.push(\"IdentityID\"); sstrColHeader.push(\"身份Id\");");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array < clsDataColumn > =");
            strCodeForCs.Append("\r\n" + "       [");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "fldName: \"\",");
            strCodeForCs.Append("\r\n" + "sortBy: \"\",");
            strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
            strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
            strCodeForCs.Append("\r\n" + "colHeader: \"\",");
            strCodeForCs.Append("\r\n" + "text: \"\",");
            strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
            strCodeForCs.Append("\r\n" + "columnType: \"CheckBox\",");
            strCodeForCs.Append("\r\n" + "orderNum: 1,");
            strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
            strCodeForCs.Append("\r\n" + "},");
            var arrDGRegionFlds = objViewInfoENEx.arrDGRegionFldSet.OrderBy(x => x.SeqNum);
            foreach (clsDGRegionFldsENEx objDGRegionFldsENEx in arrDGRegionFlds)
            {
                if (objDGRegionFldsENEx.ObjFieldTabENEx == null) continue;

                string strSortBy = "";

                if (string.IsNullOrEmpty(objDGRegionFldsENEx.SortExpression) == true)
                {
                    if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName()) == false)
                    {
                        strSortBy = objDGRegionFldsENEx.DataPropertyName_FstLcase(this.IsFstLcase);
                    }
                    else
                    {
                        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDGRegionFldsENEx.FldId, objViewInfoENEx.PrjId);
                        if (objFieldTab != null)
                        {
                            strSortBy = objFieldTab.PropertyName(this.IsFstLcase);
                        }
                    }
                }
                else
                {
                    strSortBy = objDGRegionFldsENEx.SortExpression_FstLcase(this.IsFstLcase);
                }

                strCodeForCs.Append("\r\n" + "{");
                var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(objDGRegionFldsENEx.ObjPrjTab_PC().TabId, objDGRegionFldsENEx.FldId, objViewInfoENEx.PrjId);
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName()) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "fldName: cls{0}ENEx.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.DataPropertyName4GC());
                }
                else if (objPrjTabFld != null && objPrjTabFld.IsForExtendClass)
                {
                    strCodeForCs.AppendFormat("\r\n" + "fldName: cls{0}ENEx.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.FldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "fldName: cls{0}EN.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.FldName);
                }

                if (string.IsNullOrEmpty(objDGRegionFldsENEx.SortExpression) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "sortBy: \"{0}\",", objDGRegionFldsENEx.SortExpression_FstLcase(this.IsFstLcase));
                }
                else if (objPrjTabFld != null && objPrjTabFld.IsForExtendClass)
                {
                    strCodeForCs.AppendFormat("\r\n" + "sortBy: cls{0}ENEx.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.FldName);
                }
                else
                {
                    if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName()) == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "sortBy: cls{0}ENEx.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.DataPropertyName4GC());
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "sortBy: cls{0}EN.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.FldName);
                    }
                }
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"{0}\",", objDGRegionFldsENEx.HeaderText);
                strCodeForCs.Append("\r\n" + "text: \"\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Label\",");
                strCodeForCs.AppendFormat("\r\n" + "orderNum: {0},", objDGRegionFldsENEx.SeqNum + 1);
                strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
                strCodeForCs.Append("\r\n" + "},");
                //strCodeForCs.AppendFormat("\r\n" + "sstrFldName.push(\"{0}\"); sstrColHeader.push(\"{1}\");",
                //    objDGRegionFldsENEx.FldName,
                //    objDGRegionFldsENEx.ColCaption);
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.UpdateRecord_Gv_0174).Count() > 0)  //在DG中是否有修改按钮
            {

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"修改\",");
                strCodeForCs.Append("\r\n" + "text: \"修改\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "const btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");

                strCodeForCs.Append("\r\n" + "btn1.onclick = function() {");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.vuebtn_Click('UpdateRecordInTab', strKeyId);");
                strCodeForCs.Append("\r\n" + "};");
                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DelRecord_Gv_0175).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"删除\",");
                strCodeForCs.Append("\r\n" + "text: \"删除\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "const btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");

                strCodeForCs.Append("\r\n" + "btn1.onclick = function() {");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.vuebtn_Click('DelRecordInTab', strKeyId);");
                strCodeForCs.Append("\r\n" + "};");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DetailRecord_Gv_0181).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"详细信息\",");
                strCodeForCs.Append("\r\n" + "text: \"详细信息\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "const btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");

                strCodeForCs.Append("\r\n" + "btn1.onclick = function() {");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.vuebtn_Click('DetailRecordInTab', strKeyId);");
                strCodeForCs.Append("\r\n" + "};");
                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");

            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.SelectRecord_Gv_0182).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"选择\",");
                strCodeForCs.Append("\r\n" + "text: \"选择\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "const btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");

                strCodeForCs.Append("\r\n" + "btn1.onclick = function() {");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.vuebtn_Click('SelectRecordInTab', strKeyId);");
                strCodeForCs.Append("\r\n" + "};");
                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");

            }
            strCodeForCs.Append("\r\n" + "];");
            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                int intIndex = 0;
                foreach (var objInFor in objPrjTabEx_ListRegion.arrKeyFldSet)
                {
                    if (intIndex == 0)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " const arrKeyLst = [cls{0}EN.con_{1} ",
                            TabName_Out4ListRegion4GC, objInFor.ObjFieldTab0().FldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat(", cls{0}EN.con_{1}", TabName_Out4ListRegion4GC, objInFor.ObjFieldTab0().FldName);
                    }
                    intIndex++;
                }
                strCodeForCs.Append("];");

                //let arrKeyLst = [clsUserCodePrjMainPath_MachineNameEN.con_UserCodePrjMainPathId, clsUserCodePrjMainPath_MachineNameEN.con_MachineName];

                if (strSqlDsTypeId4ListRegion == enumSQLDSType.SqlView_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTab_KeyLst_V(divDataLst, arr{0}ObjLst, arrDataColumn,  arrKeyLst, this); ",
                     TabName_Out4ListRegion4GC, objKeyField.FldName);
                    ImportClass objImportClass3 = AddImportClass("", "/PubFun/clsCommFunc4Web.js", "BindTab_KeyLst_V", enumImportObjType.CustomFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTab_KeyLst(divDataLst, arr{0}ObjLst, arrDataColumn, arrKeyLst, this); ",
                        TabName_Out4ListRegion4GC, objKeyField.FldName);
                    ImportClass objImportClass4 = AddImportClass("", "/PubFun/clsCommFunc4Web.js", "BindTab_KeyLst", enumImportObjType.CustomFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);


                }
            }
            else
            {
                if (strSqlDsTypeId4ListRegion == enumSQLDSType.SqlView_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTab_V(divDataLst, arr{0}ObjLst, arrDataColumn,  cls{0}EN.con_{1}, this); ",
                     TabName_Out4ListRegion4GC, objKeyField.FldName);
                    ImportClass objImportClass5 = AddImportClass("", "/PubFun/clsCommFunc4Web.js", "BindTab_V", enumImportObjType.CustomFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import5 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass5);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import5);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTab(divDataLst, arr{0}ObjLst, arrDataColumn,  cls{0}EN.con_{1}, this); ",
                        TabName_Out4ListRegion4GC, objKeyField.FldName);
                    ImportClass objImportClass6 = AddImportClass("", "/PubFun/clsCommFunc4Web.js", "BindTab", enumImportObjType.CustomFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import6 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass6);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import6);

                }
            }
            strCodeForCs.Append("\r\n" + $"if (this.objPager.IsInit(divContainer, this.divName4Pager) == false)");
            strCodeForCs.Append("\r\n" + $"this.objPager.InitShow(divContainer, this.divName4Pager);");
            strCodeForCs.Append("\r\n" + "this.objPager.recCount = this.recCount;");
            strCodeForCs.Append("\r\n" + "this.objPager.pageSize = this.pageSize;");
            //strCodeForCs.Append("\r\n" + "this.objPager.ShowPager();");
            strCodeForCs.Append("\r\n" + $"this.objPager.ShowPagerV2(divContainer, this, this.divName4Pager);");
            //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager.html\");");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_BindTab4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (this.IsUseFunc == false) return "";

            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds_GridRegion = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.RegionId == objViewInfoENEx.objViewRegion_Feature.RegionId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n /** 显示{0}对象的所有属性值", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param divContainer:显示容器");
            strCodeForCs.AppendFormat("\r\n * @param arr{0}ExObjLst:需要绑定的对象列表",
                ViewMainTabName4GC);
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindTab_{0}4Func(divContainer: HTMLDivElement, arr{0}ExObjLst: Array<cls{0}ENEx>) ",
                TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindTab_{0}4Func.name;", TabName_Out4ListRegion4GC);


            strCodeForCs.Append("\r\n" + "if (divContainer == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}不存在!\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divContainer, 'divDataLst');");
            ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetDivObjInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            //strCodeForCs.Append("\r\n" + "const sstrFldName: Array < string > = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "const sstrColHeader: Array < string > = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "sstrFldName.push(\"IdentityID\"); sstrColHeader.push(\"身份Id\");");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array < clsDataColumn > =");
            strCodeForCs.Append("\r\n" + "       [");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "fldName: \"\",");
            strCodeForCs.Append("\r\n" + "sortBy: \"\",");
            strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
            strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
            strCodeForCs.Append("\r\n" + "colHeader: \"\",");
            strCodeForCs.Append("\r\n" + "text: \"\",");
            strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
            strCodeForCs.Append("\r\n" + "columnType: \"CheckBox\",");
            strCodeForCs.Append("\r\n" + "orderNum: 1,");
            strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
            strCodeForCs.Append("\r\n" + "},");
            var arrDGRegionFlds = objViewInfoENEx.arrDGRegionFldSet.OrderBy(x => x.SeqNum);
            foreach (clsDGRegionFldsENEx objDGRegionFldsENEx in arrDGRegionFlds)
            {
                if (objDGRegionFldsENEx.ObjFieldTabENEx == null) continue;
                string strFldName4Bind = objDGRegionFldsENEx.PropertyName(this.IsFstLcase);
                if (objDGRegionFldsENEx.IsUseFunc())
                {
                    strFldName4Bind = objDGRegionFldsENEx.DataPropertyName_FstLcase(this.IsFstLcase);
                }
                string strSortBy = objDGRegionFldsENEx.SortExpression_FstLcase(this.IsFstLcase);

                if (string.IsNullOrEmpty(objDGRegionFldsENEx.SortExpression) == true)
                {
                    if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName()) == false)
                    {
                        strSortBy = objDGRegionFldsENEx.DataPropertyName_FstLcase(this.IsFstLcase);
                    }
                    else
                    {
                        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDGRegionFldsENEx.FldId, objViewInfoENEx.PrjId);
                        if (objFieldTab != null)
                        {
                            strSortBy = objFieldTab.PropertyName(this.IsFstLcase);
                        }
                    }
                }

                strCodeForCs.Append("\r\n" + "{");
                var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(objDGRegionFldsENEx.ObjPrjTab().TabId, objDGRegionFldsENEx.FldId, objViewInfoENEx.PrjId);
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName()) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "fldName: cls{0}ENEx.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.DataPropertyName4GC());
                }
                else if (objPrjTabFld != null && objPrjTabFld.IsForExtendClass)
                {
                    strCodeForCs.AppendFormat("\r\n" + "fldName: cls{0}ENEx.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.FldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "fldName: cls{0}EN.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.FldName);
                }
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.SortExpression) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "sortBy: \"{0}\",", objDGRegionFldsENEx.SortExpression_FstLcase(this.IsFstLcase));
                }
                else if (objPrjTabFld != null && objPrjTabFld.IsForExtendClass)
                {
                    strCodeForCs.AppendFormat("\r\n" + "sortBy: cls{0}ENEx.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.FldName);
                }
                else
                {
                    if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName()) == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "sortBy: cls{0}ENEx.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.DataPropertyName4GC());
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "sortBy: cls{0}EN.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.FldName);
                    }
                }
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"{0}\",", objDGRegionFldsENEx.HeaderText);
                strCodeForCs.Append("\r\n" + "text: \"\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Label\",");
                strCodeForCs.AppendFormat("\r\n" + "orderNum: {0},", objDGRegionFldsENEx.SeqNum + 1);
                strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
                strCodeForCs.Append("\r\n" + "},");
                //strCodeForCs.AppendFormat("\r\n" + "sstrFldName.push(\"{0}\"); sstrColHeader.push(\"{1}\");",
                //    objDGRegionFldsENEx.FldName,
                //    objDGRegionFldsENEx.ColCaption);
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.UpdateRecord_Gv_0174).Count() > 0)  //在DG中是否有修改按钮
            {

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"修改\",");
                strCodeForCs.Append("\r\n" + "text: \"修改\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "const btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");

                strCodeForCs.Append("\r\n" + "btn1.onclick = function() {");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.vuebtn_Click('UpdateRecordInTab', strKeyId);");
                strCodeForCs.Append("\r\n" + "};");
                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DelRecord_Gv_0175).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"删除\",");
                strCodeForCs.Append("\r\n" + "text: \"删除\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "const btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");

                strCodeForCs.Append("\r\n" + "btn1.onclick = function() {");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.vuebtn_Click('DelRecordInTab', strKeyId);");
                strCodeForCs.Append("\r\n" + "};");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DetailRecord_Gv_0181).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"详细信息\",");
                strCodeForCs.Append("\r\n" + "text: \"详细信息\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "const btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");

                strCodeForCs.Append("\r\n" + "btn1.onclick = function() {");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.vuebtn_Click('DetailRecordInTab', strKeyId);");
                strCodeForCs.Append("\r\n" + "};");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");

            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.SelectRecord_Gv_0182).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"选择\",");
                strCodeForCs.Append("\r\n" + "text: \"选择\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "const btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");

                strCodeForCs.Append("\r\n" + "btn1.onclick = function() {");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.vuebtn_Click('SelectRecordInTab', strKeyId);");
                strCodeForCs.Append("\r\n" + "};");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");

            }
            strCodeForCs.Append("\r\n" + "];");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.ExtendFldFuncMap(arr{0}ExObjLst, arrDataColumn);", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `扩展字段值的映射出错,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                int intIndex = 0;
                foreach (var objInFor in objPrjTabEx_ListRegion.arrKeyFldSet)
                {
                    if (intIndex == 0)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " const arrKeyLst = [cls{0}EN.con_{1} ",
                            TabName_Out4ListRegion4GC, objInFor.ObjFieldTab0().FldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat(", cls{0}EN.con_{1}", TabName_Out4ListRegion4GC, objInFor.ObjFieldTab0().FldName);
                    }
                    intIndex++;
                }
                strCodeForCs.Append("];");

                //let arrKeyLst = [clsUserCodePrjMainPath_MachineNameEN.con_UserCodePrjMainPathId, clsUserCodePrjMainPath_MachineNameEN.con_MachineName];

                if (strSqlDsTypeId4ListRegion == enumSQLDSType.SqlView_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTab_KeyLst_V(divDataLst, arr{0}ExObjLst, arrDataColumn,  arrKeyLst, this); ",
                     TabName_Out4ListRegion4GC, objKeyField.FldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTab_KeyLst(divDataLst, arr{0}ExObjLst, arrDataColumn, arrKeyLst, this); ",
                        TabName_Out4ListRegion4GC, objKeyField.FldName);
                }
            }
            else
            {
                if (strSqlDsTypeId4ListRegion == enumSQLDSType.SqlView_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTab_V(divDataLst, arr{0}ExObjLst, arrDataColumn,  cls{0}EN.con_{1}, this); ",
                     TabName_Out4ListRegion4GC, objKeyField.FldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTab(divDataLst, arr{0}ExObjLst, arrDataColumn,  cls{0}EN.con_{1}, this); ",
                        TabName_Out4ListRegion4GC, objKeyField.FldName);
                }
            }

            strCodeForCs.Append("\r\n" + $"if (this.objPager.IsInit(divContainer, this.divName4Pager) == false)");
            strCodeForCs.Append("\r\n" + $"this.objPager.InitShow(divContainer, this.divName4Pager);");
            strCodeForCs.Append("\r\n" + "this.objPager.recCount = this.recCount;");
            strCodeForCs.Append("\r\n" + "this.objPager.pageSize = this.pageSize;");
            strCodeForCs.Append("\r\n" + $"this.objPager.ShowPagerV2(divContainer, this, this.divName4Pager);");
            //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager.html\");");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_ExtendFldFuncMap(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (string.IsNullOrEmpty(TabName_Out4ListRegion4GC) == true) return "";
            var arrAddiFldId = clsPrjTabFldBLEx.GetEdgeAddiFldIdLst(TabId_Out4ListRegion, this.PrjId);

            if (arrAddiFldId.Count>0)
            {
                foreach(string strEdgeAddiFldId in arrAddiFldId)
                {
                    var obj = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldId(this.ViewId, strEdgeAddiFldId, this.PrjId);
                    if (obj == null)
                    {
                        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(strEdgeAddiFldId, this.PrjId);
                        string strMsg = $"界面:[{this.ViewName}]的列表在字段:[{objFieldTab.FldName}({strEdgeAddiFldId})]映射过程缺乏相应的映射附加变量，请在界面变量中添加！";
                        throw new Exception(strMsg);
                    }
                }
            }

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n /** 扩展字段值的函数映射", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param arr{0}ExObjLst:需要映射的对象列表", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n * @param arrDataColumn:用于绑定表的数据列信息", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public async ExtendFldFuncMap(arr{0}ExObjLst: Array<cls{0}ENEx>, arrDataColumn: Array<clsDataColumn>) {{", TabName_Out4ListRegion4GC);
            ImportClass objImportClass = AddImportClass(objViewInfoENEx.MainTabId, TabName_Out4ListRegion4GC, string.Format("cls{0}EN", TabName_Out4ListRegion4GC), enumImportObjType.ENExClass, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            strCodeForCs.AppendFormat("\r\n" + "const arrFldName = cls{0}EN._AttributeName;", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "for (const objDataColumn of arrDataColumn) {");
            strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(objDataColumn.fldName) == true) continue;");
            ImportClass objImportClass7 = AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

            CodeElement objCodeElement_Import7 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass7);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import7);

            strCodeForCs.Append("\r\n" + "if (arrFldName.indexOf(objDataColumn.fldName) > -1) continue;");
            strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ExObjLst) {{", TabName_Out4ListRegion4GC);
            foreach(string strEdgeAddiFldId in arrAddiFldId)
            {
                var strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldId(objViewInfoENEx.ViewId, strEdgeAddiFldId, objViewInfoENEx.PrjId);
                if (string.IsNullOrEmpty(strViewVarName) == true)
                {
                    var strFldName = objPrefixField.FldName;
                    clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName, objViewInfoENEx.ViewName);
                }
                ImportClass objImportClass8 = AddImportClass("", $"@/views{this.IsShareStr}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", strViewVarName, enumImportObjType.CustomFunc, "");

                CodeElement objCodeElement_Import8 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass8);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import8);

                //strCodeForCs.Append("\r\n" + $"const {objKeyField.PrivFuncName} = {strViewVarName}.value;");
                clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldIdCache(strEdgeAddiFldId, this.PrjId);
                strCodeForCs.AppendFormat("\r\n" + $"objInFor.{objFieldTab.PropertyName(this.isFstLcase)} = {strViewVarName}.value;");
            }

            strCodeForCs.Append("\r\n" + $"await {thisWA_F_InList(WA_F.FuncMapByFldName)}(objDataColumn.fldName, objInFor);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_ExtendTdFldFuncMap(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (string.IsNullOrEmpty(TabName_Out4ListRegion4GC) == true) return "";
            var arrAddiFldId = clsPrjTabFldBLEx.GetEdgeAddiFldIdLst(TabId_Out4ListRegion, this.PrjId);

            if (arrAddiFldId.Count > 0)
            {
                foreach (string strEdgeAddiFldId in arrAddiFldId)
                {
                    var obj = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldId(this.ViewId, strEdgeAddiFldId, this.PrjId);
                    if (obj == null)
                    {
                        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(strEdgeAddiFldId, this.PrjId);
                        string strMsg = $"界面:[{this.ViewName}]的列表在字段:[{objFieldTab.FldName}({strEdgeAddiFldId})]映射过程缺乏相应的映射附加变量，请在界面变量中添加！";
                        throw new Exception(strMsg);
                    }
                }
            }

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n /** 扩展Td字段值的函数映射", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param arr{0}ExObjLst:需要映射的对象列表", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n * @param arrDataColumn:用于绑定表的数据列信息", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public async ExtendTdFldFuncMap(arr{0}ExObjLst: Array<cls{0}ENEx>) {{", TabName_Out4ListRegion4GC);
            ImportClass objImportClass = AddImportClass(objViewInfoENEx.MainTabId, TabName_Out4ListRegion4GC, string.Format("cls{0}EN", TabName_Out4ListRegion4GC), enumImportObjType.ENExClass, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            strCodeForCs.AppendFormat("\r\n" + "const arrFldName = cls{0}EN._AttributeName;", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + $"const tdFieldNames = ref{ThisListClsName}.value?.tdFieldNames;");
            strCodeForCs.Append("\r\n" + "for (const strFldName of tdFieldNames) {");
            strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(strFldName) == true) continue;");
            ImportClass objImportClass2 = AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

            CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

            strCodeForCs.Append("\r\n" + "if (arrFldName.indexOf(strFldName) > -1) continue;");
            strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ExObjLst) {{", TabName_Out4ListRegion4GC);
            foreach (string strEdgeAddiFldId in arrAddiFldId)
            {
                var strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldId(objViewInfoENEx.ViewId, strEdgeAddiFldId, objViewInfoENEx.PrjId);
                if (string.IsNullOrEmpty(strViewVarName) == true)
                {
                    var strFldName = objPrefixField.FldName;
                    clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName, objViewInfoENEx.ViewName);
                }
                ImportClass objImportClass3 = AddImportClass("", $"@/views{this.IsShareStr}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", strViewVarName, enumImportObjType.CustomFunc, "");

                CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);

                //strCodeForCs.Append("\r\n" + $"const {objKeyField.PrivFuncName} = {strViewVarName}.value;");
                clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldIdCache(strEdgeAddiFldId, this.PrjId);
                strCodeForCs.AppendFormat("\r\n" + $"objInFor.{objFieldTab.PropertyName(this.isFstLcase)} = {strViewVarName}.value;");
            }

            strCodeForCs.Append("\r\n" + $"await {thisWA_F_InList(WA_F.FuncMapByFldName)}(strFldName, objInFor);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_Demo_Session(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "* 演示Session 操作");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async Demo_Session()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Demo_Session.name;",
       ViewMainTabName4GC, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//设置Session");
            strCodeForCs.Append("\r\n" + "const strUserId = \"TestUserId\";");
            strCodeForCs.Append("\r\n" + "await this.SetSessionAsync(\"UserId\", strUserId);");
            strCodeForCs.Append("\r\n" + "//获取Session");
            strCodeForCs.Append("\r\n" + "const strUserId_Value1 = await this.GetSessionAsync(\"UserId\");");
            strCodeForCs.Append("\r\n" + "//console.log('strUserId_Value1:' + strUserId_Value1);");
            strCodeForCs.Append("\r\n" + "//获取Session方法2：直接读取页面中的hidUserId");
            //          strCodeForCs.Append("\r\n" + "const strUserId_Value2 = $('#hidUserId').val();");
            strCodeForCs.Append("\r\n" + "const strUserId_Value2 = this.hidUserId;");


            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "get",
                ControlType = "input",
                CtrlId = "hidUserId",
                PropertyName = "hidUserId",
                Comment = "用户Id",
                DataType = "string"
            });
            strCodeForCs.Append("\r\n" + "//console.log('strUserId_Value2:' + strUserId_Value2);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `演示Session不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_SetSessionAsync(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "* 设置Session");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param Key:关键字");
            strCodeForCs.Append("\r\n * @param Value:值");
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public SetSessionAsync(Key: string, Value: string): Promise<void> {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SetSessionAsync.name;",
       ViewMainTabName4GC, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "            $.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl_Session_SetString,");
            strCodeForCs.Append("\r\n" + "cache: false,");
            strCodeForCs.Append("\r\n" + "async: false,");
            strCodeForCs.Append("\r\n" + "type: 'get',");
            strCodeForCs.Append("\r\n" + "dataType: \"json\",");
            strCodeForCs.Append("\r\n" + "data: {");
            strCodeForCs.Append("\r\n" + "Key: Key,");
            strCodeForCs.Append("\r\n" + "Value: Value");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "success: function (data:any) {");
            strCodeForCs.Append("\r\n" + "const strKey = data.key;");
            strCodeForCs.Append("\r\n" + "const strValue = data.value;");


            strCodeForCs.Append("\r\n" + "//console.log('strKey, strValue=' + strKey + strValue);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_GetSessionAsync(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "* 获取Session 关键字的值");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param Key:关键字");
            strCodeForCs.Append("\r\n * @returns 值");
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public GetSessionAsync(Key: string): Promise<string> {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetSessionAsync.name;",
       ViewMainTabName4GC, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "            $.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl_Session_GetString,");
            strCodeForCs.Append("\r\n" + "cache: false,");
            strCodeForCs.Append("\r\n" + "async: false,");
            strCodeForCs.Append("\r\n" + "type: 'get',");
            strCodeForCs.Append("\r\n" + "dataType: \"json\",");
            strCodeForCs.Append("\r\n" + "data: {");
            strCodeForCs.Append("\r\n" + "Key: Key,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "success: function (data) {");
            strCodeForCs.Append("\r\n" + "const strKey = data.key;");
            strCodeForCs.Append("\r\n" + "const strValue = data.value;");

            strCodeForCs.Append("\r\n" + "//console.log('strKey, strValue=' + strKey + strValue);");

            strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"网络错误!访问网络不成功!\");");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_SetKeyReadOnly()
        {
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null) return "";
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //生成私有代码;
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.FldName != objKeyField.ObjFieldTabENEx.FldName) continue;
                        strCodeForCs.Append("\r\n /**");
                        strCodeForCs.Append("\r\n * 在用户自定义控件中,设置关键字的值,是否只读");
                        strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n * @param bolReadonly:是否只读");
                        strCodeForCs.Append("\r\n **/");
                        strCodeForCs.Append("\r\n" + "public SetKeyReadOnly(bolReadonly:boolean)");
                        strCodeForCs.Append("\r\n" + "{");
                        //                 strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SetKeyReadOnly.name;",
                        //ViewMainTabName4GC, objKeyField.FldName);

                        strCodeForCs.AppendFormat("\r\n" + "$('#{0}').attr('ReadOnly', bolReadonly.toString());", objEditRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_Clear()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //生成私有代码;
                strCodeForCs.Append("\r\n /**");
                strCodeForCs.Append("\r\n * 清除用户自定义控件中,所有控件的值");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public Clear()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Clear.name;",
       ViewMainTabName4GC, objKeyField.FldName);

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.InUse == false) continue;

                    if (objEditRegionFldsEx.ObjFieldTabENEx == null) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    try
                    {
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "set",
                            ControlType = objEditRegionFldsEx.CtlTypeName,
                            CtrlId = objEditRegionFldsEx.CtrlId,
                            PropertyName = objEditRegionFldsEx.PropertyName(this.IsFstLcase),
                            Comment = string.Format("{0} (Used In {1})", objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "Clear()"),
                            DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                            ParentDivName = $"this.divEdit"
                        });
                        string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = false;",
                                    objEditRegionFldsEx.PropertyName(this.IsFstLcase));
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                    objEditRegionFldsEx.PropertyName(this.IsFstLcase),
                                    objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "DropDownList": ///如果控件是下拉框;

                                strCodeForCs.AppendFormat("\r\n" + " ClearSelectValueByIdInDivObj(this.divEdit, \"{1}\");", ThisClsName, objEditRegionFldsEx.CtrlId);
                                ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "ClearSelectValueByIdInDivObj", enumImportObjType.CustomFunc, strBaseUrl);

                                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox": ///如果控件类型是文本框;
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                    objEditRegionFldsEx.PropertyName(this.IsFstLcase), strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = \"{1}\";",
                                        objEditRegionFldsEx.PropertyName(this.IsFstLcase), objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }

                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                 objEditRegionFldsEx.PropertyName(this.IsFstLcase), strInitValue);
                                break;
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("生成字段:{0}时出错!{1}(In {2})", objEditRegionFldsEx.PropertyName(this.IsFstLcase),
                            objException.Message,
                            clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_CopyRecord()
        {
            if (objPrjTabEx_ListRegion == null) return "";
            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                return "//多关键字,不支持复制功能!";
            }
            string strTabName_Copy = TabName_Out4ListRegion4GC;
            if (objPrjTabEx_ListRegion.SqlDsTypeId == enumSQLDSType.SqlView_02)
            {
                if (strTabName_Copy.Substring(0, 1) != "v")
                {
                    string strMsg = $"界面列表区的表名：{strTabName_Copy}，起始字符不是'v'，请修正！";
                    throw new Exception(strMsg);
                }
                strTabName_Copy = strTabName_Copy.Substring(1);
            }
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {


                List<clsFeatureRegionFldsENEx> arrFeature_AdditionalCopy = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FieldTypeId == enumFieldType.AdditionalCopyField_15).ToList();
                clsFieldTabEN objFieldTab_Copy = null;
                string strCopyValue = "";
                if (arrFeature_AdditionalCopy.Count() > 0)
                {
                    clsFeatureRegionFldsENEx objFeature_AdditionalCopy = arrFeature_AdditionalCopy[0];
                    strCopyValue = objFeature_AdditionalCopy.DefaultValue;
                    if (string.IsNullOrEmpty(strCopyValue)) strCopyValue = "C_";
                    if (string.IsNullOrEmpty(objFeature_AdditionalCopy.ReleFldId) == false)
                    {
                        objFieldTab_Copy = clsFieldTabBL.GetObjByFldIdCache(objFeature_AdditionalCopy.ReleFldId, objViewInfoENEx.PrjId);
                    }
                }
                strCodeForCs.Append("\r\n /** 复制记录");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async CopyRecord(arr{0}: Array<string>) {{", objKeyField.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.CopyRecord.name;",
         ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const arr{strTabName_Copy}ObjLst = await {thisWA_F_InList(WA_F.GetObjLstByKeyLstAsync_SqlTab)}(arr{objKeyField.FldName});");

                strCodeForCs.Append("\r\n" + "//console.log('responseText=');");
                strCodeForCs.Append("\r\n" + "//console.log(responseText);");
                strCodeForCs.Append("\r\n" + "let intCount = 0;");

                strCodeForCs.Append("\r\n" + $"for (const objInFor of arr{strTabName_Copy}ObjLst)");
                strCodeForCs.Append("\r\n" + "{");
                if (objFieldTab_Copy == null)
                {
                    //strCodeForCs.Append("\r\n" + "objInFor.ExamTypeName = \"C_\" + objInFor.ExamTypeName;");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"objInFor.{objFieldTab_Copy.PropertyName(this.IsFstLcase)} =`{strCopyValue}${{objInFor.{objFieldTab_Copy.PropertyName(this.IsFstLcase)}}}`;");
                }
                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.Append("\r\n" + $"const strMaxStrId = await {thisWA_F_InList(WA_F.GetMaxStrIdAsync)}();");

                    strCodeForCs.Append("\r\n" + "//console.log('strMaxStrId=' + strMaxStrId);");
                    strCodeForCs.AppendFormat("\r\n" + "objInFor.{0} = strMaxStrId;", objKeyField.PropertyName(this.IsFstLcase));
                }
                else if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06)
                {
                    if (objPrefixField == null)
                    {
                        strCodeForCs.AppendFormat("\r\n // 表:{0}的主键是前缀自增,但该表中没有一个相关的前缀字段。请检查!(In {1})",
                                ViewMainTabName4GC, clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + $"const strMaxStrId = await {thisWA_F_InList(WA_F.GetMaxStrIdByPrefixAsync)}(\"\");");

                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"const strMaxStrId = await {thisWA_F_InList(WA_F.GetMaxStrIdByPrefixAsync)}(objInFor.{objPrefixField.PropertyName(this.IsFstLcase)});");
                    }

                    strCodeForCs.Append("\r\n" + "//console.log('strMaxStrId=' + strMaxStrId);");
                    strCodeForCs.AppendFormat("\r\n" + "objInFor.{0} = strMaxStrId;", objKeyField.PropertyName(this.IsFstLcase));
                }


                strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F_InList(WA_F.AddNewRecordAsync)}(objInFor);");

                strCodeForCs.Append("\r\n" + "//console.log('returnBool=');");
                strCodeForCs.Append("\r\n" + "//console.log(returnBool);");

                strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                strCodeForCs.Append("\r\n" + "{");
                if (PrjTabEx_EditRegion.IsUseStoreCache_TS() == false)
                {
                    Gene_ReFreshCache(strCodeForCs);
                }
                //strCodeForCs.Append("\r\n" + "const strInfo = Format(\"克隆记录成功!\");");
                strCodeForCs.Append("\r\n" + "intCount++;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strInfo = Format(\"克隆记录不成功!\");");

                strCodeForCs.Append("\r\n" + "//显示信息框");
                strCodeForCs.Append("\r\n" + "alert(strInfo);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "const strInfo = Format(\"共克隆了{0}条记录!\", intCount);");

                strCodeForCs.Append("\r\n" + "alert(strInfo);");
                strCodeForCs.Append("\r\n" + "//console.log('完成!');");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `复制记录不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_ShowTabObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 显示{0}对象的所有属性值");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n * @param divContainer:显示容器");
            strCodeForCs.AppendFormat("\r\n * @param obj{0}:需要显示的对象",
                ViewMainTabName4GC);
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public Show{0}Obj(divContainer: HTMLDivElement, obj{0}: cls{0}EN) ",
                ViewMainTabName4GC);
            strFuncName = $"Show{ViewMainTabName4GC}Obj";
            strCodeForCs.Append("\r\n" + "{");
            //     strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Show{0}Obj.name;",
            //ViewMainTabName4GC, objKeyField.FldName);


            strCodeForCs.Append("\r\n" + "if (divContainer == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"所给div为空，divContainer为null!\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const sstrKeys = GetObjKeys(obj{0});",
                ViewMainTabName4GC);
            strCodeForCs.Append("\r\n" + "const ul: HTMLUListElement = document.createElement(\"ul\");");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}.GetFldValue(strKey);",
                ViewMainTabName4GC);
            strCodeForCs.Append("\r\n" + "const li: HTMLLIElement = document.createElement(\"li\");");
            strCodeForCs.Append("\r\n" + "li.innerHTML = Format(\"{0}:{1}\", strKey, strValue);");
            strCodeForCs.Append("\r\n" + "ul.appendChild(li);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "divContainer.appendChild(ul);");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_SelectRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (objPrjTabEx_ListRegion == null) return "";
            string strBy = objKeyField.FldName;
            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1) strBy = "KeyLst";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ");
            strCodeForCs.Append("\r\n " + "* 根据关键字选择相应的记录");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param sender:参数列表");
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public async SelectRecord({0}) ",
                 objPrjTabEx_ListRegion.KeyVarDefineLstStr_TS);
            strFuncName = $"SelectRecord";
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SelectRecord.name;",
       ViewMainTabName4GC, objKeyField.FldName);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            //strCodeForCs.AppendFormat("\r\n" + "const strKeyId = $('#txtstrKeyId{0}').val();",
            //        objvFunction4GeneCodeEN.OrderNum);

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                //strCodeForCs.AppendFormat("\r\n" + "const {0}: {1} = strKeyId;",
                //  objKeyField.PrivFuncName,
                //  objKeyField.TypeScriptType);
            }
            else
            {
                switch (objDataTypeAbbrEN.DataTypeId)
                {
                    case enumDataTypeAbbr.float_07:
                    case enumDataTypeAbbr.int_09:
                    case enumDataTypeAbbr.money_11:
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:

                        //strCodeForCs.AppendFormat("\r\n" + "const {1}: {0} = Number(strKeyId);",
                        //    objDataTypeAbbrEN.TypeScriptType,
                        //    objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理!({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            //strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + $"const obj{ViewMainTabName4GC}EN = await {thisWA_F_InList(WA_F.GetObjByKeyId)}({objPrjTabEx_ListRegion.KeyPrivFuncFldNameLstStr_TS});");

            strCodeForCs.AppendFormat("\r\n" + "console.log('完成SelectRecord!', obj{0}EN);", ViewMainTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "Redirect(\"/Index/Main_{0}\");", TabName_Out4ListRegion4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `根据关键字获取相应的${this.thisTabName}记录的对象不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");


            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_QueryLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public Query{0}Lst(strListDiv:string) ",
                TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Query{0}Lst.name;", TabName_Out4ListRegion4GC);
            (string whereCondition, bool bolIsUseObjCond) = GC_WhereCondition(enumRegionType.ListRegion_0002, true);
         strCodeForCs.Append("\r\n" + whereCondition);

            //strCodeForCs.Append("\r\n" + "const1 intCurrPageIndex = this.objPager.CurrPageIndex;//获取当前页");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页");

            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "get",
            //    ControlType = "input",
            //    CtrlId = "hidCurrPageIndex",
            //    PropertyName = "CurrPageIndex",
            //    Comment = "获取当前页序号(Used In QueryLst())",
            //    DataType = "number"

            //});
            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + GC_GetObjExLst(enumRegionType.ListRegion_0002, "", false));

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}]共获取对象列表数：{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
            //    ViewMainTabName4GC);

            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(divList, arr{1}ObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"完成Query{0}Lst!\");", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "resolve(jsonData);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `查询对象列表不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 这是在前台不使用缓存的
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public string Gen_WApi_Ts_BindGv(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (PrjTabEx_ListRegion.IsUseStorageCache_TS()) return "";
            if (IsUseFunc == true) return "";

            if (string.IsNullOrEmpty(TabName_Out4ListRegion4GC) == true) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindGv_{0}(divList: HTMLDivElement) ",
                TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindGv_{0}.name;", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (viewVarSet.sort{0}By == null)", TabName_Out4ListRegion4GC, ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在显示列表时,排序字段(sort{0}By)为空,请检查!(In BindGv_{0})\");", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divList, 'divDataLst');");
            ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetDivObjInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            (string whereCondition, bool bolIsUseObjCond) = GC_WhereCondition(enumRegionType.ListRegion_0002, true);
         strCodeForCs.Append("\r\n" + whereCondition);

            //strCodeForCs.Append("\r\n" + "const1 intCurrPageIndex = this.objPager.CurrPageIndex;//获取当前页");
            strCodeForCs.Append("\r\n" + "let intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页");



            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");
            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ExObjLst: Array <cls{0}ENEx> = [];", TabName_Out4ListRegion4GC);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + GC_RecCount(enumRegionType.ListRegion_0002, ""));


            strCodeForCs.Append("\r\n" + "const intPageCount = this.objPager.GetPageCount(this.recCount, this.pageSize);");
            strCodeForCs.Append("\r\n" + "if (intCurrPageIndex == 0)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "if (intPageCount > 1) intCurrPageIndex = intPageCount;");
            strCodeForCs.Append("\r\n" + "else intCurrPageIndex = 1;");
            //strCodeForCs.Append("\r\n" + "this1.CurrPageIndex = intCurrPageIndex;");
            strCodeForCs.Append("\r\n" + "this.SetCurrPageIndex(intCurrPageIndex);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (intCurrPageIndex > intPageCount)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intCurrPageIndex = intPageCount;");
            //strCodeForCs.Append("\r\n" + "this1.CurrPageIndex = intCurrPageIndex;");
            strCodeForCs.Append("\r\n" + "this.SetCurrPageIndex(intCurrPageIndex);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + GC_GetObjExLst(enumRegionType.ListRegion_0002, "", false));

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定GridView不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "const divPager: HTMLDivElement = < HTMLDivElement > document.getElementById(\"divPager\");");
            strCodeForCs.Append("\r\n" + "if (this.recCount <= this.pageSize)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (divPager != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divPager.style.display = \"none\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (divPager != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divPager.style.display = \"block\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ExObjLst.length == 0)", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement(\"span\");");
            strCodeForCs.Append("\r\n" + "lblMsg.innerHTML = \"根据条件获取的对象列表数为0!\";");

            strCodeForCs.Append("\r\n" + "if (divDataLst != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divDataLst.innerText = \"\";");
            strCodeForCs.Append("\r\n" + "divDataLst.appendChild(lblMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据条件获取的${this.thisTabName}记录数为0!\");");
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");

            strCodeForCs.Append("\r\n" + "ShowEmptyRecNumInfoByDiv(divDataLst, strMsg);");
            ImportClass objImportClass2 = AddImportClass("", "/PubFun/clsOperateList.js", "ShowEmptyRecNumInfoByDiv", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

            strCodeForCs.Append("\r\n" + $"this.objPager.Hide(divList, this.divName4Pager);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}]共获取对象列表数：{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
            //    ViewMainTabName4GC);

            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(divList, arr{1}ExObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"完成BindGv_{0}!\");", TabName_Out4ListRegion4GC);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定${this.thisTabName}对象列表不成功, ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_BindGvCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (PrjTabEx_ListRegion.IsUseStorageCache_TS() == false) return "";
            if (this.IsUseFunc == true) return "";
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";

            var objFuncParaLst = new FuncParaLst("BindGvCache", this.IsFstLcase, enumAppLevel.InvokeFunc);
            List<string> arrCondFldId = new List<string>();
            objFuncParaLst.AddParaByCacheClassify4View(thisCacheClassify_List_TS, arrCondFldId, enumProgLangType.TypeScript_09, objViewInfoENEx.ViewId, this.PrjId);

            //string strFuncParaLst = objFuncParaLst.GetCondFldLst4Para();
            List<string> arrVarNameLst = new List<string>();
            if (thisCacheClassify4View.IsHasCacheClassfyFld == true)
            {
                var strViewVarName = $"{thisCacheClassify4View.ViewVarName}.value";
                arrVarNameLst.Add(strViewVarName);
                ImportClass objImportClass4 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName, enumImportObjType.CustomFunc, "");

                CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);

            }
            if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true)
            {
                var strViewVarName = $"{thisCacheClassify4View.ViewVarName2}.value";
                arrVarNameLst.Add(strViewVarName);
                ImportClass objImportClass5 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName2, enumImportObjType.CustomFunc, "");

                CodeElement objCodeElement_Import5 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass5);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import5);


            }
            string strCondFldLst_Cache = string.Join(",", arrVarNameLst);
            //string strCheckEmptyCode = objFuncParaLst.Gc_CheckVarEmpty_Ts(this.ClsName, strFuncName, true, this, this.strBaseUrl);
            if (strCondFldLst_Cache.Length > 0) strCondFldLst_Cache = "," + strCondFldLst_Cache;

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindGv_{0}Cache(divList: HTMLDivElement) ",
                TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindGv_{0}Cache.name;", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (viewVarSet.sort{0}By == null)", TabName_Out4ListRegion4GC, ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在显示列表时,排序字段(sort{0}By)为空,请检查!(In BindGv_{0}Cache)\");", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            //strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divList, 'divDataLst');");
            //AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetDivObjInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
            bool bolIsUseObjCond = true;
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = await Combine{0}ConditionObj();", TabName_Out4ListRegion4GC);

            ImportClass objImportClass = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", $"Combine{TabName_Out4ListRegion4GC}ConditionObj", enumImportObjType.CustomFunc, "");

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);


            //strCodeForCs.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = JSON.stringify(obj{0}Cond);", TabName_Out4ListRegion4GC);

            //strCodeForCs.Append("\r\n" + "const1 intCurrPageIndex = this.objPager.CurrPageIndex;//获取当前页");
            strCodeForCs.Append("\r\n" + "let intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页");

            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "get",
            //    ControlType = "input",
            //    CtrlId = "hidCurrPageIndex",
            //    PropertyName = "CurrPageIndex",
            //    Comment = "获取当前页序号(Used In BindGvCache)",
            //    DataType = "number"

            //});

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");
            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ExObjLst: Array <cls{0}ENEx> = [];", TabName_Out4ListRegion4GC);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + GC_RecCount(enumRegionType.ListRegion_0002, strCondFldLst_Cache, true));


            strCodeForCs.Append("\r\n" + "const intPageCount = this.objPager.GetPageCount(this.recCount, this.pageSize);");
            strCodeForCs.Append("\r\n" + "if (intCurrPageIndex == 0)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "if (intPageCount > 1) intCurrPageIndex = intPageCount;");
            strCodeForCs.Append("\r\n" + "else intCurrPageIndex = 1;");
            //strCodeForCs.Append("\r\n" + "this1.CurrPageIndex = intCurrPageIndex;");
            strCodeForCs.Append("\r\n" + "this.SetCurrPageIndex(intCurrPageIndex);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (intCurrPageIndex > intPageCount)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intCurrPageIndex = intPageCount;");
            //strCodeForCs.Append("\r\n" + "this1.CurrPageIndex = intCurrPageIndex;");
            strCodeForCs.Append("\r\n" + "this.SetCurrPageIndex(intCurrPageIndex);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + GC_GetObjExLst(enumRegionType.ListRegion_0002, strCondFldLst_Cache, bolIsUseObjCond));

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定GridView不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "const divPager: HTMLDivElement = < HTMLDivElement > document.getElementById(\"divPager\");");
            strCodeForCs.Append("\r\n" + "if (this.recCount <= this.pageSize)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (divPager != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divPager.style.display = \"none\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (divPager != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divPager.style.display = \"block\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ExObjLst.length == 0)", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement(\"span\");");
            strCodeForCs.Append("\r\n" + "lblMsg.innerHTML = \"根据条件获取的对象列表数为0!\";");

            //strCodeForCs.Append("\r\n" + "if (divDataLst != null)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "divDataLst.innerText = \"\";");
            //strCodeForCs.Append("\r\n" + "divDataLst.appendChild(lblMsg);");
            //strCodeForCs.Append("\r\n" + "}");

            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                ViewMainTabName4GC, ThisClsName);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                }
            }
            else
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                }
            }

            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                    ViewMainTabName4GC);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName,
                     thisCacheClassify4View.FldName2);
            }
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");

            strCodeForCs.Append("\r\n" + "ShowEmptyRecNumInfoByDiv(divList, strMsg);");
            ImportClass objImportClass3 = AddImportClass("", "/PubFun/clsOperateList.js", "ShowEmptyRecNumInfoByDiv", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);

            strCodeForCs.Append("\r\n" + $"this.objPager.Hide(divList, this.divName4Pager);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(divList, arr{1}ExObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"完成BindGv_{0}Cache!\");", TabName_Out4ListRegion4GC);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定${this.thisTabName}对象列表不成功, ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_SortFunExportExcel()
        {
            string strFuncName = "";
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * 排序函数。根据表对象中随机两个字段的值进行比较,正常使用时,需用该类的扩展类的同名函数");
            strCodeForCs.AppendFormat("\r\n * 作者:{0}", objViewInfoENEx.UserId);
            strCodeForCs.AppendFormat("\r\n * 日期:{0}", objViewInfoENEx.CurrDate);
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param a:比较的第1个对象");
            strCodeForCs.Append("\r\n * @param b:比较的第1个对象");
            strCodeForCs.AppendFormat("\r\n * @returns 返回两个对象比较的结果",
            TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public SortFunExportExcel(a:cls{0}EN , b:cls{0}EN): number ", TabName_Out4ExportExcel4GC);
            strFuncName = $"SortFunExportExcel";
            strCodeForCs.Append("\r\n" + "{");
            //     strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SortFunExportExcel.name;",
            //ViewMainTabName4GC, objKeyField.FldName);

            clsFieldTabEN objField_1 = null;
            clsFieldTabEN objField_2 = null;
            List<clsFieldTabEN> arrFieldTab = clsFieldTabBLEx.GetObjLstByTabIdCache(TabId_Out4ExportExcel, objViewInfoENEx.PrjId);

            foreach (var objInFor in arrFieldTab)
            {
                var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(TabId_Out4ExportExcel, objInFor.FldId, objInFor.PrjId);
                if (objPrjTabFld.IsForExtendClass == true) continue;
                //if (objInFor.ObjFieldTab().DataTypeId == enumDataTypeAbbr.bit_03) continue;
                if (objField_1 == null) objField_1 = objInFor;
                else if (objField_2 == null)
                {
                    objField_2 = objInFor;
                    break;
                }
            }
            if (objField_1 == null || objField_2 == null) return strCodeForCs.ToString();

            string strReturnStr4Field_1 = "";
            string strReturnStr4Field_2 = "";
            if (objField_1.IsNumberType())
            {
                strReturnStr4Field_1 = string.Format("a.{0} - b.{0}", objField_1.PropertyName(this.IsFstLcase));
            }
            else if (objField_1.IsBoolType())
            {
                strReturnStr4Field_1 = string.Format("a.{0} ? -1:1", objField_1.PropertyName(this.IsFstLcase));
            }
            else
            {
                strReturnStr4Field_1 = string.Format("a.{0}.localeCompare(b.{0})", objField_1.PropertyName(this.IsFstLcase));
            }
            if (objField_2.IsNumberType())
            {
                strReturnStr4Field_2 = string.Format("a.{0} - b.{0}", objField_2.PropertyName(this.IsFstLcase));
            }
            else if (objField_2.IsBoolType())
            {
                strReturnStr4Field_2 = string.Format("a.{0} ? -1:1", objField_2.PropertyName(this.IsFstLcase));
            }
            else
            {
                strReturnStr4Field_2 = string.Format("a.{0}.localeCompare(b.{0})", objField_2.PropertyName(this.IsFstLcase));
            }
            strCodeForCs.AppendFormat("\r\n" + "if (a.{0} == b.{0}) {{", objField_2.PropertyName(this.IsFstLcase));
            strCodeForCs.AppendFormat("\r\n" + "if (a.{0} == null) return -1;", objField_2.PropertyName(this.IsFstLcase));
            strCodeForCs.AppendFormat("\r\n" + "if (b.{0} == null) return 1;", objField_2.PropertyName(this.IsFstLcase));
            strCodeForCs.AppendFormat("\r\n" + "return {0} ;",  strReturnStr4Field_2);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else {");
            strCodeForCs.AppendFormat("\r\n" + "if (b.{0} == null) return -1;", objField_1.PropertyName(this.IsFstLcase));
            strCodeForCs.AppendFormat("\r\n" + "if (a.{0} == null) return 1;", objField_1.PropertyName(this.IsFstLcase));
            strCodeForCs.AppendFormat("\r\n" + "return {0};", strReturnStr4Field_1);
            strCodeForCs.Append("\r\n" + "};");

            //if (a.Id_CourseType == b.Id_CourseType) return a.CourseSeq - b.CourseSeq;
            //else return a.Id_CourseType.localeCompare(b.Id_CourseType);
            //if (objField_1.IsNumberType() && objField_2.IsNumberType())
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "if (a.{0} == b.{0}) return a.{1} - b.{1};", objField_1.FldName, objField_2.FldName);
            //    strCodeForCs.AppendFormat("\r\n" + "else return a.{0} - b.{0};", objField_1.FldName);
            //}
            //else if (objField_1.IsNumberType() && objField_2.IsNumberType() == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "if (a.{0} == b.{0}) return a.{1}.localeCompare(b.{1});", objField_1.FldName, objField_2.FldName);
            //    strCodeForCs.AppendFormat("\r\n" + "else return a.{0} - b.{0};", objField_1.FldName);
            //}
            //else if (objField_1.IsNumberType() == false && objField_2.IsNumberType())
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "if (a.{0} == b.{0}) return a.{1} - b.{1};", objField_1.FldName, objField_2.FldName);
            //    strCodeForCs.AppendFormat("\r\n" + "else return a.{0}.localeCompare(b.{0});", objField_1.FldName);
            //}
            //else if (objField_1.IsNumberType() == false && objField_2.IsNumberType() == false)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "if (a.{0} == b.{0}) return a.{1}.localeCompare(b.{1});", objField_1.FldName, objField_2.FldName);
            //    strCodeForCs.AppendFormat("\r\n" + "else return a.{0}.localeCompare(b.{0});", objField_1.FldName);
            //}

            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_ExportExcel4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (this.IsUseFunc4ExcelExport == false) return "";
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            if (PrjTabEx_ListRegion.IsUseStorageCache_TS() == false)
            {
                return Gen_WApi_Ts_ExportExcel4Func_NoCache(objvFunction4GeneCodeEN);
            }
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";

            List<string> arrCondFldId = new List<string>();
            var objFuncParaLst = new FuncParaLst("ExportExcel4Func", this.IsFstLcase, enumAppLevel.InvokeFunc);
            objFuncParaLst.AddParaByCacheClassify4View(thisCacheClassify_ExportExcel_TS, arrCondFldId, enumProgLangType.TypeScript_09, objViewInfoENEx.ViewId, this.PrjId);

            //string strFuncParaLst = objFuncParaLst.GetCondFldLst4Para();
            List<string> arrVarNameLst = new List<string>();
            if (thisCacheClassify4View.IsHasCacheClassfyFld == true)
            {
                var strViewVarName = $"{thisCacheClassify4View.ViewVarName}.value";
                arrVarNameLst.Add(strViewVarName);
                ImportClass objImportClass6 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName, enumImportObjType.CustomFunc, "");

                CodeElement objCodeElement_Import6 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass6);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import6);

            }
            if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true)
            {
                var strViewVarName = $"{thisCacheClassify4View.ViewVarName2}.value";
                arrVarNameLst.Add(strViewVarName);
                ImportClass objImportClass7 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName2, enumImportObjType.CustomFunc, "");

                CodeElement objCodeElement_Import7 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass7);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import7);

            }
            string strCondFldLst_Cache = string.Join(",", arrVarNameLst);
            //string strCheckEmptyCode = objFuncParaLst.Gc_CheckVarEmpty_Ts(this.ClsName, strFuncName, true, this, this.strBaseUrl);
            if (strCondFldLst_Cache.Length > 0) strCondFldLst_Cache = "," + strCondFldLst_Cache;


            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async ExportExcel_{0}4Func(): Promise<ExportExcelData> ",
                TabName_Out4ExportExcel4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ExportExcel_{0}4Func.name;", TabName_Out4ExportExcel4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (viewVarSet.sort{0}By == null)", TabName_Out4ListRegion4GC, ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在显示列表时,排序字段(sort{0}By)为空,请检查!(In BindGv_{0}Cache)\");", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return { arrObjLst: [], sheetName: '', fileName: '' };");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            bool bolIsUseObjCond = false;
            if (PrjTabEx_ExcelExportRegion.CacheModeId == enumCacheMode.ClientCache_02 ||
                PrjTabEx_ExcelExportRegion.CacheModeId == enumCacheMode.localStorage_03 ||
                PrjTabEx_ExcelExportRegion.CacheModeId == enumCacheMode.sessionStorage_04)
            {
                bolIsUseObjCond = true;
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = await Combine{0}ConditionObj4ExportExcel();", TabName_Out4ExportExcel4GC);
                ImportClass objImportClass8 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", $"Combine{TabName_Out4ListRegion4GC}ConditionObj4ExportExcel", enumImportObjType.CustomFunc, "");

                CodeElement objCodeElement_Import8 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass8);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import8);

            }
            else
            {
                strCodeForCs.Append("\r\n" + $"const strWhereCond = await Combine{TabName_Out4ExportExcel4GC}Condition();");
                ImportClass objImportClass9 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", $"Combine{TabName_Out4ListRegion4GC}Condition", enumImportObjType.CustomFunc, "");

                CodeElement objCodeElement_Import9 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass9);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import9);

            }

            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst: Array <cls{0}EN> = [];", TabName_Out4ExportExcel4GC);
            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ExObjLst: Array <cls{0}ENEx> = [];", TabName_Out4ExportExcel4GC);
            ImportClass objImportClass = AddImportClass(TabId_Out4ExportExcel, TabName_Out4ExportExcel4GC, string.Format("cls{0}EN", ViewMainTabName4GC), enumImportObjType.ENExClass, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + GC_RecCount(enumRegionType.ExcelExportRegion_0007, strCondFldLst_Cache));

            strCodeForCs.Append("\r\n" + GC_GetObjExLst(enumRegionType.ExcelExportRegion_0007, strCondFldLst_Cache, bolIsUseObjCond));

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `导出Excel时获取数据不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return { arrObjLst: [], sheetName: '', fileName: '' };");

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", TabName_Out4ExportExcel4GC);
            strCodeForCs.Append("\r\n" + "{");


            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                ViewMainTabName4GC, ThisClsName);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                }
            }
            else
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                }
            }

            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                    ViewMainTabName4GC);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName,
                     thisCacheClassify4View.FldName2);
            }
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");

            strCodeForCs.Append("\r\n" + "return { arrObjLst: [], sheetName: '', fileName: '' };");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}]共获取对象列表数：{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
            //    ViewMainTabName4GC);

            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array < clsDataColumn > =");
            strCodeForCs.Append("\r\n" + "       [");

            var arrExcelExportRegionFlds = objViewInfoENEx.arrExcelExportRegionFldSet.OrderBy(x => x.SeqNum);
            foreach (clsExcelExportRegionFldsENEx objDGRegionFldsENEx in arrExcelExportRegionFlds)
            {
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.FldName)) continue;


                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"{0}\",", objDGRegionFldsENEx.PropertyName(this.IsFstLcase));
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"{0}\",", "");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"{0}\",", objDGRegionFldsENEx.ColCaption);
                strCodeForCs.Append("\r\n" + "text: \"\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Label\",");
                strCodeForCs.AppendFormat("\r\n" + "orderNum: {0},", objDGRegionFldsENEx.SeqNum + 1);
                strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
                strCodeForCs.Append("\r\n" + "},");
                //strCodeForCs.AppendFormat("\r\n" + "sstrFldName.push(\"{0}\"); sstrColHeader.push(\"{1}\");",
                //    objDGRegionFldsENEx.FldName,
                //    objDGRegionFldsENEx.ColCaption);
            }

            strCodeForCs.Append("\r\n" + "];");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.ExtendFldFuncMap(arr{0}ExObjLst, arrDataColumn);", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `扩展字段值的映射出错,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return { arrObjLst: [], sheetName: '', fileName: '' };");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = arr{0}ObjLst.sort(this.SortFunExportExcel);", TabName_Out4ExportExcel4GC);

            strCodeForCs.AppendFormat("\r\n" + "  return this.CombineData(arr{0}ObjLst, arrDataColumn); ",
                TabName_Out4ExportExcel4GC, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"完成BindGv_{0}!\");", TabName_Out4ExportExcel4GC);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定${this.thisTabName}对象列表不成功, ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return { arrObjLst: [], sheetName: '', fileName: '' };");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_ExportExcel4Func_NoCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (this.IsUseFunc4ExcelExport == false) return "";

            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async ExportExcel_{0}4Func() ",
                TabName_Out4ExportExcel4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ExportExcel_{0}4Func.name;", TabName_Out4ExportExcel4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (viewVarSet.sort{0}By == null)", TabName_Out4ListRegion4GC, ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在显示列表时,排序字段(sort{0}By)为空,请检查!(In BindGv_{0}Cache)\");", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            (string whereCondition, bool bolIsUseObjCond) = GC_WhereCondition(enumRegionType.ExcelExportRegion_0007, true);
            strCodeForCs.Append("\r\n" + whereCondition);

            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst: Array <cls{0}EN> = [];", TabName_Out4ExportExcel4GC);
            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ExObjLst: Array <cls{0}ENEx> = [];", TabName_Out4ExportExcel4GC);
            ImportClass objImportClass = AddImportClass(TabId_Out4ExportExcel, TabName_Out4ExportExcel4GC, string.Format("cls{0}EN", ViewMainTabName4GC), enumImportObjType.ENExClass, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + GC_RecCount(enumRegionType.ExcelExportRegion_0007, ""));

            strCodeForCs.Append("\r\n" + GC_GetObjExLst(enumRegionType.ExcelExportRegion_0007, "", bolIsUseObjCond));

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `导出Excel时获取数据不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", TabName_Out4ExportExcel4GC);
            strCodeForCs.Append("\r\n" + "{");


            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                ViewMainTabName4GC, ThisClsName);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                }
            }
            else
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                }
            }

            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                    ViewMainTabName4GC);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName);
            }
            else
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName,
                     thisCacheClassify4View.FldName2);
            }
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            //strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}]共获取对象列表数：{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
            //    ViewMainTabName4GC);

            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array < clsDataColumn > =");
            strCodeForCs.Append("\r\n" + "       [");

            var arrExcelExportRegionFlds = objViewInfoENEx.arrExcelExportRegionFldSet.OrderBy(x => x.SeqNum);
            foreach (clsExcelExportRegionFldsENEx objDGRegionFldsENEx in arrExcelExportRegionFlds)
            {
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.FldName)) continue;


                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"{0}\",", objDGRegionFldsENEx.FldName_Lcase);
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"{0}\",", "");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"{0}\",", objDGRegionFldsENEx.ColCaption);
                strCodeForCs.Append("\r\n" + "text: \"\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Label\",");
                strCodeForCs.AppendFormat("\r\n" + "orderNum: {0},", objDGRegionFldsENEx.SeqNum + 1);
                strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
                strCodeForCs.Append("\r\n" + "},");
                //strCodeForCs.AppendFormat("\r\n" + "sstrFldName.push(\"{0}\"); sstrColHeader.push(\"{1}\");",
                //    objDGRegionFldsENEx.FldName,
                //    objDGRegionFldsENEx.ColCaption);
            }

            strCodeForCs.Append("\r\n" + "];");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.ExtendFldFuncMap(arr{0}ExObjLst, arrDataColumn);", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `扩展字段值的映射出错,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = arr{0}ObjLst.sort(this.SortFunExportExcel);", TabName_Out4ExportExcel4GC);

            strCodeForCs.AppendFormat("\r\n" + "  return this.CombineData(arr{0}ObjLst, arrDataColumn); ",
                TabName_Out4ExportExcel4GC, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"完成BindGv_{0}!\");", TabName_Out4ExportExcel4GC);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定${this.thisTabName}对象列表不成功, ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_ExportExcelCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            if (PrjTabEx_ExcelExportRegion.IsUseStorageCache_TS() == false) return "";

            if (this.IsUseFunc4ExcelExport == true) return "";
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";

            var objFuncParaLst = new FuncParaLst("ExportExcelCache", this.IsFstLcase, enumAppLevel.InvokeFunc);
            List<string> arrCondFldId = new List<string>();
            objFuncParaLst.AddParaByCacheClassify4View(thisCacheClassify_ExportExcel_TS, arrCondFldId, enumProgLangType.TypeScript_09, objViewInfoENEx.ViewId, this.PrjId);

            //string strFuncParaLst = objFuncParaLst.GetCondFldLst4Para();
            List<string> arrVarNameLst = new List<string>();
            if (thisCacheClassify4View.IsHasCacheClassfyFld == true)
            {
                var strViewVarName = $"{thisCacheClassify4View.ViewVarName}.value";
                arrVarNameLst.Add(strViewVarName);
                ImportClass objImportClass9 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName, enumImportObjType.CustomFunc, "");

                CodeElement objCodeElement_Import9 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass9);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import9);

            }
            if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true)
            {
                var strViewVarName = $"{thisCacheClassify4View.ViewVarName2}.value";
                arrVarNameLst.Add(strViewVarName);
                ImportClass objImportClass2 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName2, enumImportObjType.CustomFunc, "");

                CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

            }
            string strCondFldLst_Cache = string.Join(",", arrVarNameLst);
            if (strCondFldLst_Cache.Length > 0) strCondFldLst_Cache = "," + strCondFldLst_Cache;


            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async ExportExcel_{0}Cache(): Promise<ExportExcelData> ",
                TabName_Out4ExportExcel4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ExportExcel_{0}Cache.name;", TabName_Out4ExportExcel4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (viewVarSet.sort{0}By == null)", TabName_Out4ListRegion4GC, ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在显示列表时,排序字段(sort{0}By)为空,请检查!(In BindGv_{0}Cache)\");", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return { arrObjLst: [], sheetName: '', fileName: '' };");
            strCodeForCs.Append("\r\n" + "}");
            bool bolIsUseObjCond = false;
            bolIsUseObjCond = true;
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = await Combine{0}ConditionObj4ExportExcel();", TabName_Out4ExportExcel4GC);
            ImportClass objImportClass = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", $"Combine{TabName_Out4ExportExcel4GC}ConditionObj4ExportExcel", enumImportObjType.CustomFunc, "");

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            if (thisCacheClassify4View.IsHasCacheClassfyFld == true)
            {
                if (string.IsNullOrEmpty (thisCacheClassify4View.ViewVarName))
                {
                    string strMsg = $"界面变量为空，请检查！（字段名:[{thisCacheClassify4View.FldName}]) in ({clsStackTrace.GetCurrClassFunction()})";
                    throw new Exception(strMsg);
                }
                bolIsUseObjCond = true;
                var strViewVarName = thisCacheClassify4View.ViewVarName + ".value";
                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}, \"=\");",
                        TabName_Out4ExportExcel4GC,
                        thisCacheClassify4View.FldName,
                        strViewVarName);
            }
            if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true)
            {
                bolIsUseObjCond = true;
                var strViewVarName = thisCacheClassify4View.ViewVarName2 + ".value";
                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}, \"=\");",
                        TabName_Out4ExportExcel4GC,
                        thisCacheClassify4View.FldName2,
                        strViewVarName);
            }
                        
            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst: Array <cls{0}EN> = [];", TabName_Out4ExportExcel4GC);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + GC_RecCount(enumRegionType.ExcelExportRegion_0007, strCondFldLst_Cache));

            strCodeForCs.Append("\r\n" + GC_GetObjExLst(enumRegionType.ExcelExportRegion_0007, strCondFldLst_Cache, bolIsUseObjCond));

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const strMsg = `绑定GridView不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return { arrObjLst: [], sheetName: '', fileName: '' };");

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", TabName_Out4ExportExcel4GC);
            strCodeForCs.Append("\r\n" + "{");


            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                ViewMainTabName4GC, ThisClsName);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                }
            }
            else
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                }
            }

            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                    ViewMainTabName4GC);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName,
                     thisCacheClassify4View.FldName2);
            }
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");

            strCodeForCs.Append("\r\n" + "return { arrObjLst: [], sheetName: '', fileName: '' };");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}]共获取对象列表数：{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
            //    ViewMainTabName4GC);

            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array < clsDataColumn > =");
            strCodeForCs.Append("\r\n" + "       [");

            var arrExcelExportRegionFlds = objViewInfoENEx.arrExcelExportRegionFldSet.OrderBy(x => x.SeqNum);
            foreach (clsExcelExportRegionFldsENEx objDGRegionFldsENEx in arrExcelExportRegionFlds)
            {
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.FldName)) continue;


                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"{0}\",", objDGRegionFldsENEx.FldName_Lcase);
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"{0}\",", "");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"{0}\",", objDGRegionFldsENEx.ColCaption);
                strCodeForCs.Append("\r\n" + "text: \"\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Label\",");
                strCodeForCs.AppendFormat("\r\n" + "orderNum: {0},", objDGRegionFldsENEx.SeqNum + 1);
                strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
                strCodeForCs.Append("\r\n" + "},");
                //strCodeForCs.AppendFormat("\r\n" + "sstrFldName.push(\"{0}\"); sstrColHeader.push(\"{1}\");",
                //    objDGRegionFldsENEx.FldName,
                //    objDGRegionFldsENEx.ColCaption);
            }

            strCodeForCs.Append("\r\n" + "];");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = arr{0}ObjLst.sort(this.SortFunExportExcel);", TabName_Out4ExportExcel4GC);

            strCodeForCs.AppendFormat("\r\n" + " return this.CombineData(arr{0}ObjLst, arrDataColumn); ",
                TabName_Out4ExportExcel4GC, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"完成BindGv_{0}!\");", TabName_Out4ExportExcel4GC);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定${this.thisTabName}对象列表不成功, ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return { arrObjLst: [], sheetName: '', fileName: '' };");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_ExportExcel(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            if (PrjTabEx_ExcelExportRegion.IsUseStorageCache_TS()) return "";

            if (this.IsUseFunc4ExcelExport == true) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async ExportExcel_{0}(): Promise<ExportExcelData> ",
                TabName_Out4ExportExcel4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ExportExcel_{0}.name;", TabName_Out4ExportExcel4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (viewVarSet.sort{0}By == null)", TabName_Out4ListRegion4GC, ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在显示列表时,排序字段(sort{0}By)为空,请检查!(In BindGv_{0}Cache)\");", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            
            strCodeForCs.Append("\r\n" + "return { arrObjLst: [], sheetName: '', fileName: '' };");
            strCodeForCs.Append("\r\n" + "}");
            (string whereCondition, bool bolIsUseObjCond) = GC_WhereCondition(enumRegionType.ExcelExportRegion_0007, true);
         strCodeForCs.Append("\r\n" + whereCondition);

            //strCodeForCs.Append("\r\n" + "const1 intCurrPageIndex = this.objPager.CurrPageIndex;//获取当前页");
            //strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页");

            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst: Array <cls{0}EN> = [];", TabName_Out4ExportExcel4GC);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + GC_RecCount(enumRegionType.ExcelExportRegion_0007, ""));

            strCodeForCs.Append("\r\n" + GC_GetObjExLst(enumRegionType.ExcelExportRegion_0007, "", bolIsUseObjCond));

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定GridView不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return { arrObjLst: [], sheetName: '', fileName: '' };");

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", TabName_Out4ExportExcel4GC);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "const strMsg = `在ExportExcel过程中,根据条件获取的${{this.thisTabName}}记录数为0!`;",
                ViewMainTabName4GC);

            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return { arrObjLst: [], sheetName: '', fileName: '' };");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}]共获取对象列表数：{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
            //    ViewMainTabName4GC);

            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array < clsDataColumn > =");
            strCodeForCs.Append("\r\n" + "       [");

            var arrExcelExportRegionFlds = objViewInfoENEx.arrExcelExportRegionFldSet.OrderBy(x => x.SeqNum);
            foreach (clsExcelExportRegionFldsENEx objDGRegionFldsENEx in arrExcelExportRegionFlds)
            {
                try
                {
                    if (objDGRegionFldsENEx.ObjFieldTabENEx == null) continue;
                }
                catch (Exception objEx)
                {
                    Console.WriteLine(objEx);
                    continue;
                }

                if (string.IsNullOrEmpty(objDGRegionFldsENEx.FldName)) continue;


                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"{0}\",", objDGRegionFldsENEx.FldName_Lcase);
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"{0}\",", "");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"{0}\",", objDGRegionFldsENEx.ColCaption);
                strCodeForCs.Append("\r\n" + "text: \"\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Label\",");
                strCodeForCs.AppendFormat("\r\n" + "orderNum: {0},", objDGRegionFldsENEx.SeqNum + 1);
                strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
                strCodeForCs.Append("\r\n" + "},");
                //strCodeForCs.AppendFormat("\r\n" + "sstrFldName.push(\"{0}\"); sstrColHeader.push(\"{1}\");",
                //    objDGRegionFldsENEx.FldName,
                //    objDGRegionFldsENEx.ColCaption);
            }

            strCodeForCs.Append("\r\n" + "];");
            strCodeForCs.Append("\r\n" + $"arr{TabName_Out4ExportExcel4GC}ObjLst = arr{TabName_Out4ExportExcel4GC}ObjLst.sort(this.SortFunExportExcel);");

            strCodeForCs.AppendFormat("\r\n" + "  return this.CombineData(arr{0}ObjLst, arrDataColumn); ",
                TabName_Out4ExportExcel4GC, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"完成BindGv_{0}!\");", TabName_Out4ExportExcel4GC);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定${this.thisTabName}对象列表不成功, ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return { arrObjLst: [], sheetName: '', fileName: '' };");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_BindGv4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (this.IsUseFunc == false) return "";
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            if (PrjTabEx_ListRegion.IsUseStorageCache_TS() == false)
            {
                return Gen_WApi_Ts_BindGv4Func_NoCache(objvFunction4GeneCodeEN);
            }
            var objFuncParaLst = new FuncParaLst("BindGv4Func", this.IsFstLcase, enumAppLevel.InvokeFunc);
            List<string> arrCondFldId = new List<string>();
            objFuncParaLst.AddParaByCacheClassify4View(thisCacheClassify_List_TS, arrCondFldId, enumProgLangType.TypeScript_09, objViewInfoENEx.ViewId, this.PrjId);

            //string strFuncParaLst = objFuncParaLst.GetCondFldLst4Para();
            List<string> arrVarNameLst = new List<string>();
            if (thisCacheClassify4View.IsHasCacheClassfyFld == true)
            {
                var strViewVarName = $"{thisCacheClassify4View.ViewVarName}.value";
                arrVarNameLst.Add(strViewVarName);
                ImportClass objImportClass3 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName, enumImportObjType.CustomFunc, "");

                CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);

            }
            if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true)
            {
                var strViewVarName = $"{thisCacheClassify4View.ViewVarName2}.value";
                arrVarNameLst.Add(strViewVarName);
                ImportClass objImportClass3 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName2, enumImportObjType.CustomFunc, "");

                CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);

            }
            string strCondFldLst_Cache = string.Join(",", arrVarNameLst);
            //string strCheckEmptyCode = objFuncParaLst.Gc_CheckVarEmpty_Ts(this.ClsName, strFuncName, true, this, this.strBaseUrl);
            if (strCondFldLst_Cache.Length > 0) strCondFldLst_Cache = "," + strCondFldLst_Cache;

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindGv_{0}4Func(divList: HTMLDivElement) ",
                TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindGv_{0}4Func.name;", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (viewVarSet.sort{0}By == null)", TabName_Out4ListRegion4GC, ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在显示列表时,排序字段(sort{0}By)为空,请检查!(In BindGv_{0}Cache)\");", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divList, 'divDataLst');");
            ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetDivObjInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            bool bolIsUseObjCond = false;
            if (PrjTabEx_ListRegion.IsUseStoreCache_TS() == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = await Combine{0}Condition();", TabName_Out4ListRegion4GC);
                ImportClass objImportClass3 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", $"Combine{TabName_Out4ListRegion4GC}Condition", enumImportObjType.CustomFunc, "");

                CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);


            }
            else if (PrjTabEx_ListRegion.IsUseStorageCache_TS() == true)
            {
                bolIsUseObjCond = true;
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = await Combine{0}ConditionObj();", TabName_Out4ListRegion4GC);
                ImportClass objImportClass4 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", $"Combine{TabName_Out4ListRegion4GC}ConditionObj", enumImportObjType.CustomFunc, "");

                CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);


                if (thisCacheClassify4View.IsHasCacheClassfyFld == true && thisCacheClassify4View.IsForExtendClass == false)
                {
                    bolIsUseObjCond = true;
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.value, \"=\");",
                            TabName_Out4ListRegion4GC,
                            thisCacheClassify4View.FldName,
                                thisCacheClassify4View.ViewVarName);
                }
                if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true && thisCacheClassify4View.IsForExtendClass2 == false)
                {
                    bolIsUseObjCond = true;
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.value, \"=\");",
                            TabName_Out4ListRegion4GC,
                            thisCacheClassify4View.FldName2,
                                thisCacheClassify4View.ViewVarName2);
                }

                strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = JSON.stringify(obj{0}Cond);", TabName_Out4ListRegion4GC);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = await Combine{0}Condition();", TabName_Out4ListRegion4GC);
                ImportClass objImportClass4 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", $"Combine{TabName_Out4ListRegion4GC}Condition", enumImportObjType.CustomFunc, "");

                CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);


            }
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页");

            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ExObjLst: Array <cls{0}ENEx> = [];", TabName_Out4ListRegion4GC);
            ImportClass objImportClass5 = AddImportClass(objViewInfoENEx.MainTabId, ViewMainTabName4GC, string.Format("cls{0}EN", ViewMainTabName4GC), enumImportObjType.ENExClass, this.strBaseUrl);

            CodeElement objCodeElement_Import5 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass5);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import5);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + GC_RecCount(enumRegionType.ListRegion_0002, strCondFldLst_Cache));

            //strCodeForCs.Append("\r\n" + $"this1.recCount = await {thisWA_F_InList(WA_F.GetRecCountByCondCache)}(obj{TabName_Out4ListRegion4GC}Cond {strCondFldLst_Cache});");


            strCodeForCs.Append("\r\n" + GC_GetObjExLst(enumRegionType.ListRegion_0002, strCondFldLst_Cache, bolIsUseObjCond));


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定GridView不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ExObjLst.length == 0)", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");

            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                ViewMainTabName4GC, ThisClsName);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                }
            }
            else
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                }
            }

            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                    ViewMainTabName4GC);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName,
                     thisCacheClassify4View.FldName2);
            }
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "ShowEmptyRecNumInfoByDiv(divDataLst, strMsg);");
            ImportClass objImportClass2 = AddImportClass("", "/PubFun/clsOperateList.js", "ShowEmptyRecNumInfoByDiv", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

            strCodeForCs.Append("\r\n" + $"this.objPager.Hide(divList, this.divName4Pager);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}4Func(divList, arr{1}ExObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"完成BindGv_{0}4Func!\");", TabName_Out4ListRegion4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定${this.thisTabName}对象列表不成功, ${e}.(in ${this.constructor.name}.${strThisFuncName})`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_BindGv4Func_NoCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (this.IsUseFunc == false) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindGv_{0}4Func(divList: HTMLDivElement) ",
                TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindGv_{0}4Func.name;", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (viewVarSet.sort{0}By == null)", TabName_Out4ListRegion4GC, ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在显示列表时,排序字段(sort{0}By)为空,请检查!(In BindGv_{0}Cache)\");", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divList, 'divDataLst');");
            ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetDivObjInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            (string whereCondition, bool bolIsUseObjCond) = GC_WhereCondition(enumRegionType.ListRegion_0002, true);
         strCodeForCs.Append("\r\n" + whereCondition);

            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页");

            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ExObjLst: Array <cls{0}ENEx> = [];", TabName_Out4ListRegion4GC);
            ImportClass objImportClass2 = AddImportClass(objViewInfoENEx.MainTabId, ViewMainTabName4GC, string.Format("cls{0}EN", ViewMainTabName4GC), enumImportObjType.ENExClass, this.strBaseUrl);

            CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + GC_RecCount(enumRegionType.ListRegion_0002, ""));

            //strCodeForCs.Append("\r\n" + $"this1.recCount = await {thisWA_F_InList(WA_F.GetRecCountByCondAsync)}(strWhereCond);");

            strCodeForCs.Append("\r\n" + GC_GetObjExLst(enumRegionType.ListRegion_0002, "", bolIsUseObjCond));

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定GridView不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ExObjLst.length == 0)", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");

            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                ViewMainTabName4GC, ThisClsName);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                }
            }
            else
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                }
            }

            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                    ViewMainTabName4GC);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName);
            }
            else
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName,
                     thisCacheClassify4View.FldName2);
            }
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            strCodeForCs.Append("\r\n" + "ShowEmptyRecNumInfoByDiv(divDataLst, strMsg);");
            ImportClass objImportClass5 = AddImportClass("", "/PubFun/clsOperateList.js", "ShowEmptyRecNumInfoByDiv", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import5 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass5);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import5);

            strCodeForCs.Append("\r\n" + $"this.objPager.Hide(divList, this.divName4Pager);");
            //strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}4Func(divList, arr{1}ExObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, TabName_Out4ListRegion4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定${this.thisTabName}对象列表不成功, ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }




        public string Gen_WApi_Ts_CombineData4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (this.IsUseFunc == false) return "";
            if (this.IsUseFunc4ExcelExport == false) return "";
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 合并数据");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public CombineData4Func(arr{0}ExObjLst: Array<cls{0}ENEx>, arrDataColumn: Array<clsDataColumn>): ExportExcelData ",
                TabName_Out4ExportExcel4GC);
            strFuncName = $"CombineData4Func";
            ImportClass objImportClass = AddImportClass("", "/PubFun/ExportExcelData.js", "ExportExcelData", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            strCodeForCs.Append("\r\n" + "{");

            ImportClass objImportClass2 = AddImportClass(objViewInfoENEx.MainTabId, ViewMainTabName4GC, string.Format("cls{0}EN", ViewMainTabName4GC), enumImportObjType.ENExClass, this.strBaseUrl);

            CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

            strCodeForCs.AppendFormat("\r\n" + "const intRowNum = arr{0}ExObjLst.length;",
                TabName_Out4ExportExcel4GC);
            strCodeForCs.Append("\r\n" + "const intColNum = arrDataColumn.length;");

            strCodeForCs.Append("\r\n" + "const arrData: Array <Record<string, any>> = [];");

            // Transform each object in arrcc_CourseKnowledgesObjLst
            strCodeForCs.Append("\r\n" + "for (let i = 0; i < intRowNum; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const objEN: cls{TabName_Out4ExportExcel4GC}ENEx = arr{TabName_Out4ExportExcel4GC}ExObjLst[i];");
            strCodeForCs.Append("\r\n" + "const objRow: Record<string, any> = { };");

            strCodeForCs.Append("\r\n" + "for (let j = 0; j < intColNum; j++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const fldName = arrDataColumn[j].fldName;");
            strCodeForCs.Append("\r\n" + "const colHeader = arrDataColumn[j].colHeader;");
            strCodeForCs.Append("\r\n" + "const value = objEN.GetFldValue(fldName); // Get the value using fldName");
            strCodeForCs.Append("\r\n" + "objRow[colHeader] = value; // Use colHeader as the property name");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "arrData.push(objRow);");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "const arrData: Array < Array < any >> = new Array<Array<any>>();");

            //strCodeForCs.Append("\r\n" + "const arrHead: Array < any > = new Array<any>();");
            //strCodeForCs.Append("\r\n" + "for (let j = 0; j < intColNum; j++)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "arrHead.push(arrDataColumn[j] );");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "arrData.push(arrHead);");
            //strCodeForCs.Append("\r\n" + "for (let i = 0; i < intRowNum; i++)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const arrRow: Array < any > = new Array<any>();");
            //strCodeForCs.AppendFormat("\r\n" + "const objEN: cls{0}ENEx = arr{0}ExObjLst[i];",
            //    TabName_Out4ExportExcel4GC);

            //strCodeForCs.Append("\r\n" + "for (let j = 0; j < intColNum; j++)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName));//i + \"\" + j;");

            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "arrData.push(arrRow);");
            //strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//console.log(\"arrData\", arrData);");
            strCodeForCs.AppendFormat("\r\n" + "const strFileName = Format(\"{0}({{0}})导出.xlsx\",", objViewInfoENEx.TabCnName);
            strCodeForCs.AppendFormat("\r\n" + " cls{0}EN._CurrTabName);", TabName_Out4ExportExcel4GC);
            strCodeForCs.AppendFormat("\r\n" + "const strSheetName = \"{0}列表\"; ", objViewInfoENEx.TabCnName);

            strCodeForCs.Append("\r\n" + "return { arrObjLst: arrData, sheetName: strSheetName, fileName: strFileName };");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_CombineDataBak(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 合并数据");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public CombineData(arr{0}ObjLst: Array<cls{0}EN>, arrDataColumn: Array<clsDataColumn>) ",
                TabName_Out4ExportExcel4GC);
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "const intRowNum = arr{0}ObjLst.length;",
                TabName_Out4ExportExcel4GC);
            strCodeForCs.Append("\r\n" + "const intColNum = arrDataColumn.length;");
            strCodeForCs.Append("\r\n" + "const arrData: Array < Array < any >> = new Array<Array<any>>();");

            strCodeForCs.Append("\r\n" + "const arrHead: Array < any > = new Array<any>();");
            strCodeForCs.Append("\r\n" + "for (let j = 0; j < intColNum; j++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "arrHead.push(arrDataColumn[j].colHeader);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "arrData.push(arrHead);");
            strCodeForCs.Append("\r\n" + "for (let i = 0; i < intRowNum; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrRow: Array < any > = new Array<any>();");
            strCodeForCs.AppendFormat("\r\n" + "const objEN: cls{0}EN = arr{0}ObjLst[i];",
                TabName_Out4ExportExcel4GC);

            strCodeForCs.Append("\r\n" + "for (let j = 0; j < intColNum; j++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName));//i + \"\" + j;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "arrData.push(arrRow);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//console.log(\"arrData\", arrData);");
            strCodeForCs.AppendFormat("\r\n" + "const strFileName = Format(\"{0}({{0}})导出.xlsx\",", objViewInfoENEx.TabCnName);
            strCodeForCs.AppendFormat("\r\n" + " cls{0}EN._CurrTabName);", TabName_Out4ExportExcel4GC);
            
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_CombineData(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 合并数据");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public CombineData(arr{0}ObjLst: Array<cls{0}EN>, arrDataColumn: Array<clsDataColumn>): ExportExcelData ",
                TabName_Out4ExportExcel4GC);
            strFuncName = $"CombineData";
            ImportClass objImportClass = AddImportClass("", "/PubFun/ExportExcelData.js", "ExportExcelData", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "const intRowNum = arr{0}ObjLst.length;",
                TabName_Out4ExportExcel4GC);
            strCodeForCs.Append("\r\n" + "const intColNum = arrDataColumn.length;");

            strCodeForCs.Append("\r\n" + "const arrData: Array <Record<string, any>> = [];");

            // Transform each object in arrcc_CourseKnowledgesObjLst
            strCodeForCs.Append("\r\n" + "for (let i = 0; i < intRowNum; i++)");
            strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const objEN: cls{TabName_Out4ExportExcel4GC}EN = arr{TabName_Out4ExportExcel4GC}ObjLst[i];");
                strCodeForCs.Append("\r\n" + "const objRow: Record<string, any> = { };");

                strCodeForCs.Append("\r\n" + "for (let j = 0; j < intColNum; j++)");
                strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const fldName = arrDataColumn[j].fldName;");
                    strCodeForCs.Append("\r\n" + "const colHeader = arrDataColumn[j].colHeader;");
                    strCodeForCs.Append("\r\n" + "const value = objEN.GetFldValue(fldName); // Get the value using fldName");
                    strCodeForCs.Append("\r\n" + "objRow[colHeader] = value; // Use colHeader as the property name");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "arrData.push(objRow);");
            strCodeForCs.Append("\r\n" + "}");

strCodeForCs.Append("\r\n" + "//console.log(\"arrData\", arrData);");
            strCodeForCs.AppendFormat("\r\n" + "const strFileName = Format(\"{0}({{0}})导出.xlsx\",", objViewInfoENEx.TabCnName);
            strCodeForCs.AppendFormat("\r\n" + " cls{0}EN._CurrTabName);", TabName_Out4ExportExcel4GC);
            
            strCodeForCs.AppendFormat("\r\n" + "const strSheetName = \"{0}列表\";", objViewInfoENEx.TabCnName);

            strCodeForCs.Append("\r\n" + "return { arrObjLst: arrData, sheetName: strSheetName, fileName: strFileName };");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnQuery_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (strFuncName4BindGv == "") return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public async btnQuery_Click() ",
                TabName_Out4ListRegion4GC);
            strFuncName = "btnQuery_Click";
            strCodeForCs.Append("\r\n" + "{");
            //     strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnQuery_Click.name;",
            //ViewMainTabName4GC, objKeyField.FldName);

            //strCodeForCs.Append("\r\n" + "this1.CurrPageIndex = 1;");
            strCodeForCs.Append("\r\n" + "this.SetCurrPageIndex(1);");

            strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnExportExcel_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public async btnExportExcel_Click() ",
                TabName_Out4ListRegion4GC);
            strFuncName = "btnExportExcel_Click";
            strCodeForCs.Append("\r\n" + "{");
            //     strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnExportExcel_Click.name;",
            //ViewMainTabName4GC, objKeyField.FldName);

            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            if (this.IsUseFunc4ExcelExport == true && PrjTabEx_ExcelExportRegion.IsUseStorageCache_TS() == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "await this.ExportExcel_{0}4Func();",
                 TabName_Out4ExportExcel4GC);
            }
            else if (PrjTabEx_ExcelExportRegion.IsUseStorageCache_TS() == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "await this.ExportExcel_{0}Cache();",
                    TabName_Out4ExportExcel4GC);
            }
            else if (this.IsUseFunc4ExcelExport == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "await this.ExportExcel_{0}4Func();",
                 TabName_Out4ExportExcel4GC);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "await this.ExportExcel_{0}();",
                 TabName_Out4ExportExcel4GC);
            }
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_GetObjLst4DdlBind(clsViewInfoENEx objViewInfoENEx, string strTabName, string strValueFld, string strTextFld)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async btnGetObjLst_Click() ",
                ViewMainTabName4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnGetObjLst_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const arr{ViewMainTabName4GC}ObjLst: Array<cls{ViewMainTabName4GC}EN> = await {thisWA_F_InView(WA_F.GetObjLstAsync)}(strWhereCond);");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN objFirstObj = new cls{0}EN();", ViewMainTabName4GC);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.{0} = \"0\";",
               strValueFld, strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.{0} = \"请选择...\";", strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst.add(0, objFirstObj);",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "{1}.arr{0}ObjLstCache = arr{0}ObjLst;",
                strTabName, ThisClsName);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setPrompt(\"请选择您的{0}: \");", objViewInfoENEx.TabCnName);

            strCodeForCs.AppendFormat("\r\n" + "if (mobjDdlAdapter{0} == null)", strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "mobjDdlAdapter{0} = new ddlAdapter{0}(macPage, arr{0}ObjLst);",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            //            userStateAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setAdapter(mobjDdlAdapter{0});",
                strTabName);
            //strCodeForCs.Append("\r\n" + "SendMessage(\"没有使用缓存!\");");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"BindDdl_{0}, 没有使用缓存!\", 1);",
                strTabName);

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `根据条件获取相应的下拉框对象列表不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnDelRecordBySign_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 按标志删除记录");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnDelRecordBySign_Click() {");

            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDelRecordBySign_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
            ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(`请选择需要按标志删除的${this.thisTabName}记录!`);");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");

            strCodeForCs.AppendFormat("\r\n" + "const returnInt = await {0}DelRecordBySignAsync(arrKeyIds);", ViewMainTabName4GC, ViewMainTabName4GC.ToLower());
            ImportClass objImportClass2 = AddImportClass(objViewInfoENEx.MainTabId, ViewMainTabName4GC, string.Format("DelRecordBySignAsync", objKeyField.FldName), enumImportObjType.WApiClassFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");

            if (PrjTabEx_ListRegion.IsUseStorageCache_TS() == true)
            {
                if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshCache();", ViewMainTabName4GC);
                }
                else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshCache({1}.value);", ViewMainTabName4GC,
                        thisCacheClassify4View.ViewVarName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshCache({1}.value, {2}.value);", ViewMainTabName4GC,
                        thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                }
            }
            strCodeForCs.Append("\r\n" + "const strInfo = `按标志删除${this.thisTabName}记录成功,共删除${returnInt}条记录!`;");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = `按标志删除${this.thisTabName}记录不成功!`;");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "await this.BindGv_{0}{1}();", TabName_Out4ListRegion4GC, PrjTabEx_ListRegion.IsUseStorageCache_TS() ? "Cache" : "");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `按标志删除${this.thisTabName}记录不成功. ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnUnDelRecordBySign_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 按标志恢复删除记录");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnUnDelRecordBySign_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnUnDelRecordBySign_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
            ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(`请选择需要恢复删除的${this.thisTabName}记录!);");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");

            strCodeForCs.AppendFormat("\r\n" + "const returnInt = await {0}UnDelRecordBySignAsync(arrKeyIds);", ViewMainTabName4GC, ViewMainTabName4GC.ToLower());
            ImportClass objImportClass2 = AddImportClass(objViewInfoENEx.MainTabId, ViewMainTabName4GC, string.Format("UnDelRecordBySignAsync", objKeyField.FldName), enumImportObjType.WApiClassFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");
            Gene_ReFreshCache(strCodeForCs);

            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"按标志恢复记录成功,共恢复了{0}条记录!\",  returnInt);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"按标志恢复记录不成功!\");");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `按标志恢复记录不成功. ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnDelRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (objPrjTabEx_ListRegion == null) return "";
            if (PrjTabEx_View.SqlDsTypeId == enumSQLDSType.SqlView_02)
                return $"//由于当前主表:[${PrjTabEx_View.TabName}]是视图,不需要生成删除功能函数[btnDelRecord_Click];";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 删除记录");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnDelRecord_Click() {");
            strFuncName = "btnDelRecord_Click";
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDelRecord_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count == 1)
            {
                strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要删除的${this.thisTabName}记录!`);");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "if (confirmDel(arrKeyIds.length) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");

                strCodeForCs.AppendFormat("\r\n" + "await this.DelMultiRecord(arrKeyIds);", ViewMainTabName4GC, ViewMainTabName4GC.ToLower());
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"const arrKeyLsts = GetCheckedKeyLstsInDivObj(divVarSet.refDivList);");
                ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyLstsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                strCodeForCs.Append("\r\n" + "if (arrKeyLsts.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要删除的${this.thisTabName}记录!`);");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "if (confirmDel(arrKeyLsts.length) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");

                strCodeForCs.AppendFormat("\r\n" + "await this.DelMultiRecord_KeyLst(arrKeyLsts);", ViewMainTabName4GC, ViewMainTabName4GC.ToLower());
            }
            strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `删除${this.thisTabName}记录不成功. ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnDelRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (objPrjTabEx_ListRegion == null) return "";
            if (PrjTabEx_View.SqlDsTypeId == enumSQLDSType.SqlView_02)
                return $"//由于当前主表:[${PrjTabEx_View.TabName}]是视图,不需要生成删除功能函数[btnDelRecordInTab_Click];";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ");
            strCodeForCs.Append("\r\n * 在数据表里删除记录");
            foreach (var objInFor in objPrjTabEx_ListRegion.arrKeyFldSet)
            {
                strCodeForCs.AppendFormat("\r\n * \"{0}\": 表关键字", objInFor.PrivFuncName);
            }
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.AppendFormat("\r\n" + "public async btnDelRecordInTab_Click({0}) {{",
                    objPrjTabEx_ListRegion.KeyVarDefineLstStr_TS);
                strFuncName = "btnDelRecordInTab_Click";
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDelRecordInTab_Click.name;",
           ViewMainTabName4GC, objKeyField.FldName);

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                foreach (var objInFor in objPrjTabEx_ListRegion.arrKeyFldSet)
                {
                    if (objInFor.IsNumberType() == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " if (IsNullOrEmpty({0}) == true)", objInFor.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + " if ({0} == 0)", objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(`请选择需要删除的${this.thisTabName}记录!`);");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");
                }
                strCodeForCs.Append("\r\n" + "if (confirmDel(0) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");
                strCodeForCs.AppendFormat("\r\n" + "await this.DelRecord({0});", objPrjTabEx_ListRegion.KeyPrivFuncFldNameLstStr_TS);
            }
            else
            {
                strCodeForCs.Append("\r\n" + "public async btnDelRecordInTab_Click(strKeyId:string) {");
                strFuncName = "btnDelRecordInTab_Click";
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDelRecordInTab_Click.name;",
                    ViewMainTabName4GC, objKeyField.FldName);

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + " if (strKeyId == \"\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要删除的${this.thisTabName}记录!`);");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "if (confirmDel(0) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                    strCodeForCs.AppendFormat("\r\n" + "await this.DelRecord(lngKeyId);", ViewMainTabName4GC, ViewMainTabName4GC.ToLower());
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "await this.DelRecord(strKeyId);", ViewMainTabName4GC, ViewMainTabName4GC.ToLower());
                }
            }
            strCodeForCs.Append("\r\n" + $" await this.{strFuncName4BindGv}(divVarSet.refDivList);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `删除${this.thisTabName}记录不成功. ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnSelectRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (objPrjTabEx_ListRegion == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ");
            strCodeForCs.Append("\r\n * 在数据表里选择记录");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public async btnSelectRecordInTab_Click({0}) {{",
                objPrjTabEx_ListRegion.KeyVarDefineLstStr_TS);

            strFuncName = $"btnSelectRecordInTab_Click";
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnSelectRecordInTab_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                foreach (var objInFor in objPrjTabEx_ListRegion.arrKeyFldSet)
                {
                    if (objInFor.IsNumberType() == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}) == true)", objInFor.ObjFieldTab0().PrivFuncName());
                        ImportClass objImportClass = AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

                        CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", objInFor.ObjFieldTab0().PrivFuncName());
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = \"请选择相关记录,请检查!\";");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            else
            {
                if (objKeyField.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", objKeyField.ObjFieldTab0().PrivFuncName());
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = \"请选择相关记录,请检查!\";");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}) == true)", objKeyField.ObjFieldTab0().PrivFuncName());
                    ImportClass objImportClass = AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = \"请选择相关记录,请检查!\";");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }


            strCodeForCs.Append("\r\n" + "if (confirmDel(0) == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            //if (objKeyField.TypeScriptType == "number")
            //{
            //    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

            //    strCodeForCs.AppendFormat("\r\n" + "this.SelectRecord(lngKeyId);",
            //     ViewMainTabName4GC, ViewMainTabName4GC.ToLower());
            //}
            //else
            //{
            strCodeForCs.AppendFormat("\r\n" + "this.SelectRecord({0});",
                objPrjTabEx_ListRegion.KeyPrivFuncFldNameLstStr_TS);
            //}

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `选择记录不成功. ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnDetailRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ");
            strCodeForCs.Append("\r\n * 在数据表里详细信息记录");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnDetailRecordInTab_Click(strKeyId:string) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDetailRecordInTab_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "//$('#hidOpType').val(\"Detail\");");
            strCodeForCs.Append("\r\n" + "this.opType = \"Detail\";");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + " if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(`请选择需要详细信息的${this.thisTabName}记录!`);");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord(lngKeyId);",
                 ViewMainTabName4GC, ViewMainTabName4GC.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord(strKeyId);",
                    ViewMainTabName4GC, ViewMainTabName4GC.ToLower());
            }


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `详细信息记录不成功. ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }



        public string Gen_WApi_Ts_DelMultiRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (objPrjTabEx_ListRegion == null) return "";
            if (PrjTabEx_View.SqlDsTypeId == enumSQLDSType.SqlView_02)
                return $"//由于当前主表:[${PrjTabEx_View.TabName}]是视图,不需要生成删除功能函数[DelMultiRecord];";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据关键字列表删除记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.AppendFormat("\r\n" + "public async DelMultiRecord_KeyLst(arrKeyLsts: Array<string>) {{",
                    objKeyField.FldName);
                strFuncName = $"DelMultiRecord_KeyLst";
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.DelMultiRecord_KeyLst.name;",
           ViewMainTabName4GC, objKeyField.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "public async DelMultiRecord(arr{0}: Array<string>) {{",
                    objKeyField.FldName);
                strFuncName = $"DelMultiRecord";
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.DelMultiRecord.name;",
           ViewMainTabName4GC, objKeyField.FldName);
            }
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.Append("\r\n" + $"const returnInt = await {thisWA_F_InList(WA_F.DelRecKeyLstsAsync)}(arrKeyLsts);");
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"const returnInt = await {thisWA_F_InList(WA_F.DelMultiRecordAsync)}(arr{objKeyField.FldName});");
            }

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");
            StringBuilder sbTemp = new StringBuilder();
            bool bolIsNeedFreshCache = Gene_ReFreshCache(sbTemp);
            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                if (bolIsNeedFreshCache == true)
                {
                    strCodeForCs.Append("\r\n" + "for(const strKeyId of arrKeyLsts){");
                    strCodeForCs.Append(sbTemp.ToString());
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            else
            {
                if (sbTemp.ToString().IndexOf(PrjTabEx_ListRegion.KeyPrivFuncFldNameLstStr_TS) > -1)
                {
                    if (bolIsNeedFreshCache == true)
                    {
                        strCodeForCs.Append("\r\n" + $"for(const {PrjTabEx_ListRegion.KeyPrivFuncFldNameLstStr_TS} of arr{objKeyField.FldName})");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append(sbTemp.ToString());
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                else
                {
                    strCodeForCs.Append(sbTemp.ToString());
                }
            }
            strCodeForCs.Append("\r\n" + "const strInfo = `删除${this.thisTabName}记录成功,共删除${returnInt}条记录!`;");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = `删除${this.thisTabName}记录不成功!`;");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成DelMultiRecord!\");", TabName_Out4ListRegion4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `删除${this.thisTabName}记录不成功. ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_DelRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (objPrjTabEx_ListRegion == null) return "";
            if (PrjTabEx_View.SqlDsTypeId == enumSQLDSType.SqlView_02)
                return $"//由于当前主表:[${PrjTabEx_View.TabName}]是视图,不需要生成删除功能函数[DelRecord];";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /** ");
            strCodeForCs.Append("\r\n * 根据关键字删除记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public async DelRecord({0}) {{",
                objPrjTabEx_ListRegion.KeyVarDefineLstStr_TS);
            strFuncName = $"DelRecord";
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.DelRecord.name;",
       ViewMainTabName4GC, objKeyField.FldName);
            //   GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

            //strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<string> = arrKeys;", objKeyField.FldName);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.Append("\r\n" + $"const returnInt = await {thisWA_F_InView(WA_F.DelRecKeyLstAsync)}({objPrjTabEx_ListRegion.KeyPrivFuncFldNameLstStr_TS});");
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"const returnInt = await {thisWA_F_InView(WA_F.DelRecordAsync)}({objPrjTabEx_ListRegion.KeyPrivFuncFldNameLstStr_TS});");
            }
            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");

            Gene_ReFreshCache(strCodeForCs);

            strCodeForCs.Append("\r\n" + "const strInfo = `删除${this.thisTabName}记录成功,共删除${returnInt}条记录!`;");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = `删除${this.thisTabName}记录不成功!`;");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成DelRecord!\");", TabName_Out4ListRegion4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `删除${this.thisTabName}记录不成功. ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_GetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 获取当前表关键字值的最大值,再加1,避免重复");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");


            strCodeForCs.Append("\r\n" + "public async GetMaxStrId(strKeyCtrlName) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetMaxStrId.name;",
       ViewMainTabName4GC, objKeyField.FldName);

            //strCodeForCs.AppendFormat("\r\n" + "this.divName = \"div{0}\";", objvFunction4GeneCodeEN.FuncName4Code);
            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "set",
            //    ControlType = "input",
            //    CtrlId = "hidDivName",
            //    PropertyName = "divName",
            //    Comment = "添加、修改用的层1名",
            //    DataType = "string"
            //});

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const returnString = await {thisWA_F_InEdit(WA_F.GetMaxStrIdAsync)}();");

            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为空,不成功,请检查!\");",
                ViewMainTabName4GC);


            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + " $(strKeyCtrlName).val(returnString);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为：{{0}}!\", returnString);",
                ViewMainTabName4GC);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + " $(strKeyCtrlName).val(returnString);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `获取表关键字的最大值不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");


            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_ScriptCSGetMaxStrIdByPrefix(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.Append("\r\n" + "public async btnGetMaxStrIdByPrefix_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnGetMaxStrIdByPrefix_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
            //            strCodeForCs.AppendFormat("\r\n" + "string strPrefix = \"2\";");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const returnString = await {thisWA_F_InEdit(WA_F.GetMaxStrIdByPrefixAsync)}(strPrefix);");

            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为空,不成功,请检查!\");",
                ViewMainTabName4GC);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为：{{0}}!\", returnString);",
                ViewMainTabName4GC);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `获取表关键字的最大值不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");


            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        Func<clsViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        public string Gen_WApi_Ts_DdlBindFunction4Page_Load()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            //string strDS_DataValueField = "";
            //string strDsTabName = "";
            try
            {

                foreach (ASPDropDownListEx objInfor in objViewInfoENEx.arrASPDropDownListObj)
                {
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == false)
                    {
                        var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                        var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                        var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                        if (arrTabFeatureFlds_Cond.Count == 0)
                        {
                            objInfor.VarIdCond1 = "";
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond1 = "";
                            objInfor.FldIdCond2 = "";
                        }
                        else if (arrTabFeatureFlds_Cond.Count == 1)
                        {
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond2 = "";
                        }
                    }
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindDdl_TrueAndFalse(\"{0}\");",
                                 objInfor.CtrlId);
                    }
                    else
                    {
                        //if (objInfor.objFieldTab_ConditionField == null)
                        //{
                        //    strCodeForCs.AppendFormat("\r\n" + "const {1} = {2}_BindDdl_{0}Cache(\"{1}\", obj{2}Cond);//{3}",
                        //         objInfor.FldName,
                        // objInfor.CtrlId, objInfor.DsTabName
                        // , clsRegionTypeBL.GetNameByRegionTypeIdCache(objInfor.RegionTypeId),
                        // objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                        //}
                        //else
                        //{

                        //    strCodeForCs.AppendFormat("\r\n" + "const {0}{2} = \"\";",
                        //             objInfor.objFieldTab_ConditionField.PrivFuncName(),
                        //             objInfor.objFieldTab_ConditionField.ObjDataTypeAbbr().TypeScriptType,
                        //             objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                        //    strCodeForCs.AppendFormat("\r\n" + "const {1} = {2}_BindDdl_{0}Cache(\"{1}\", obj{2}Cond, {4}{5});//{3}",
                        //         objInfor.FldName,
                        // objInfor.CtrlId, objInfor.DsTabName
                        // , clsRegionTypeBL.GetNameByRegionTypeIdCache(objInfor.RegionTypeId),
                        // objInfor.objFieldTab_ConditionField.PrivFuncName(), objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                        //}
                    }
                }

                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                //    || objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //{
                //    strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
                //    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                //    {
                //        if (objEditRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                //        {
                //            strDS_DataValueField = clsEditRegionFldsBLEx.InitDs_DataValueField(objEditRegionFldsEx);
                //            strDsTabName = clsEditRegionFldsBLEx.InitDsTabName4Get(objEditRegionFldsEx);

                //            strCodeForCs.AppendFormat("\r\n" + "const ddl_{1} = {3}_BindDdl_{0}Cache(\"{2}\", obj{3}Cond);",
                //            strDS_DataValueField, objEditRegionFldsEx.FldName,
                //            objEditRegionFldsEx.CtrlId, strDsTabName);
                //        }
                //    }
                //}


                //foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                //{
                //    if (objQryRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                //    {
                //        if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                //        {
                //            strCodeForCs.AppendFormat("\r\n" + "BindDdl_TrueAndFalse(\"{0}\");",
                //                        objQryRegionFldsEx.CtrlId());
                //        }
                //        else
                //        {
                //            clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objQryRegionFldsEx.DsTabId);
                //            clsFieldTabEN objFieldTab_ValueField = clsFieldTabBLEx.GetObjByFldIDCache(objQryRegionFldsEx.DsDataValueFieldId, objViewInfoENEx.PrjId);
                //            clsFieldTabEN objFieldTabEN_TextField = clsFieldTabBLEx.GetObjByFldIDCache(objQryRegionFldsEx.Ds_DataTextFieldId, objViewInfoENEx.PrjId);

                //            if (objPrjTabEN_CodeTab == null)
                //            {
                //                string strMsg = string.Format("在界面查询区,{0}下拉框的数据源表没有设置,请检查!({1})",
                //                    objQryRegionFldsEx.FldName,
                //                    clsStackTrace.GetCurrClassFunction());
                //                throw new Exception(strMsg);
                //            }
                //            if (objFieldTab_ValueField == null)
                //            {
                //                string strMsg = string.Format("在界面查询区,{0}下拉框的数据源值字段没有设置,请检查!({1})",
                //                    objQryRegionFldsEx.FldName,
                //                    clsStackTrace.GetCurrClassFunction());
                //                throw new Exception(strMsg);
                //            }
                //            if (objFieldTabEN_TextField == null)
                //            {
                //                string strMsg = string.Format("在界面查询区,{0}下拉框的数据源文本字段没有设置,请检查!({1})",
                //                    objQryRegionFldsEx.FldName,
                //                    clsStackTrace.GetCurrClassFunction());
                //                throw new Exception(strMsg);
                //            }
                //            strDS_DataValueField = clsQryRegionFldsBLEx.Ds_DataValueField4Get(objQryRegionFldsEx);
                //            strDsTabName = clsQryRegionFldsBLEx.InitDsTabName4Get(objQryRegionFldsEx);

                //            strCodeForCs.AppendFormat("\r\n" + "const ddl_{1}_q = {3}_BindDdl_{0}Cache(\"{2}\", obj{3}Cond);",
                //                    objFieldTab_ValueField.FldName,
                //                    objQryRegionFldsEx.FldName,
                //                    objQryRegionFldsEx.CtrlId(),
                //                    strDsTabName);
                //        }
                //    }
                //}               
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_DdlBindFunction4Page_LoadCache()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            //string strDS_DataValueField = "";
            //string strDsTabName = "";
            try
            {

                foreach (ASPDropDownListEx objInfor in objViewInfoENEx.arrASPDropDownListObj)
                {
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == false)
                    {
                        var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                        var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                        var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
                        if (arrTabFeatureFlds_Cond.Count == 0)
                        {
                            objInfor.VarIdCond1 = "";
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond1 = "";
                            objInfor.FldIdCond2 = "";
                        }
                        else if (arrTabFeatureFlds_Cond.Count == 1)
                        {
                            objInfor.VarIdCond2 = "";
                            objInfor.FldIdCond2 = "";
                        }
                    }
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "BindDdl_TrueAndFalse(\"{0}\");",
                                 objInfor.CtrlId);
                    }
                    else
                    {
                        //if (objInfor.objFieldTab_ConditionField == null)
                        //{
                        //    strCodeForCs.AppendFormat("\r\n" + "const {2} = {3}_BindDdl_{1}Cache(\"{2}\", obj{3}Cond);//{4}",
                        //         objInfor.FldName,
                        //                 objInfor.objFieldTab_ValueField.FldName,
                        // objInfor.CtrlId, objInfor.DsTabName
                        // , clsRegionTypeBL.GetNameByRegionTypeIdCache(objInfor.RegionTypeId),
                        // objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                        //}
                        //else
                        //{

                        //    strCodeForCs.AppendFormat("\r\n" + "const {0}{2} = \"\";",
                        //             objInfor.objFieldTab_ConditionField.PrivFuncName(),
                        //             objInfor.objFieldTab_ConditionField.ObjDataTypeAbbr().TypeScriptType,
                        //             objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                        //    strCodeForCs.AppendFormat("\r\n" + "const {2} = {3}_BindDdl_{1}Cache(\"{2}\", obj{3}Cond, {5}{6});//{4}",
                        //         objInfor.FldName,
                        //         objInfor.objFieldTab_ValueField.FldName,
                        // objInfor.CtrlId, objInfor.DsTabName
                        // , clsRegionTypeBL.GetNameByRegionTypeIdCache(objInfor.RegionTypeId),
                        // objInfor.objFieldTab_ConditionField.PrivFuncName(),
                        // objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                        //}
                    }
                }
                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                //    || objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //{
                //    strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
                //    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                //    {
                //        if (objEditRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                //        {
                //            strDS_DataValueField = clsEditRegionFldsBLEx.InitDs_DataValueField(objEditRegionFldsEx);
                //            strDsTabName = clsEditRegionFldsBLEx.InitDsTabName4Get(objEditRegionFldsEx);

                //            strCodeForCs.AppendFormat("\r\n" + "const ddl_{1} = {3}_BindDdl_{0}Cache(\"{2}\", obj{3}Cond);",
                //            strDS_DataValueField, objEditRegionFldsEx.FldName,
                //            objEditRegionFldsEx.CtrlId, strDsTabName);
                //        }
                //    }
                //}


                //foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                //{
                //    if (objQryRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                //    {
                //        if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                //        {
                //            strCodeForCs.AppendFormat("\r\n" + "BindDdl_TrueAndFalse(\"{0}\");",
                //                        objQryRegionFldsEx.CtrlId());
                //        }
                //        else
                //        {
                //            clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objQryRegionFldsEx.DsTabId);
                //            clsFieldTabEN objFieldTab_ValueField = clsFieldTabBLEx.GetObjByFldIDCache(objQryRegionFldsEx.DsDataValueFieldId, objViewInfoENEx.PrjId);
                //            clsFieldTabEN objFieldTabEN_TextField = clsFieldTabBLEx.GetObjByFldIDCache(objQryRegionFldsEx.Ds_DataTextFieldId, objViewInfoENEx.PrjId);

                //            if (objPrjTabEN_CodeTab == null)
                //            {
                //                string strMsg = string.Format("在界面查询区,{0}下拉框的数据源表没有设置,请检查!({1})",
                //                    objQryRegionFldsEx.FldName,
                //                    clsStackTrace.GetCurrClassFunction());
                //                throw new Exception(strMsg);
                //            }
                //            if (objFieldTab_ValueField == null)
                //            {
                //                string strMsg = string.Format("在界面查询区,{0}下拉框的数据源值字段没有设置,请检查!({1})",
                //                    objQryRegionFldsEx.FldName,
                //                    clsStackTrace.GetCurrClassFunction());
                //                throw new Exception(strMsg);
                //            }
                //            if (objFieldTabEN_TextField == null)
                //            {
                //                string strMsg = string.Format("在界面查询区,{0}下拉框的数据源文本字段没有设置,请检查!({1})",
                //                    objQryRegionFldsEx.FldName,
                //                    clsStackTrace.GetCurrClassFunction());
                //                throw new Exception(strMsg);
                //            }
                //            strDS_DataValueField = clsQryRegionFldsBLEx.Ds_DataValueField4Get(objQryRegionFldsEx);
                //            strDsTabName = clsQryRegionFldsBLEx.InitDsTabName4Get(objQryRegionFldsEx);

                //            strCodeForCs.AppendFormat("\r\n" + "const ddl_{1}_q = {3}_BindDdl_{0}Cache(\"{2}\", obj{3}Cond);",
                //                    objFieldTab_ValueField.FldName,
                //                    objQryRegionFldsEx.FldName,
                //                    objQryRegionFldsEx.CtrlId(),
                //                    strDsTabName);
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_CombineCondition(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objViewInfoENEx.arrQryRegionFldSet == null) return "";
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成仅有变量;

                clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);


                strCodeForCs.Append("\r\n /** 把所有的查询控件内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.Append("\r\n * @returns 条件串(strWhereCond)");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + " public async Combine{0}Condition():Promise<string> ", TabName_Out4ListRegion4GC);
                strFuncName = $" public async Combine{TabName_Out4ListRegion4GC}Condition():Promise<string> ";
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");

                StringBuilder sbTemp = new StringBuilder();
                List<string> arrCtlType = new List<string>() { enumCtlType.ViewVariable_38 };
                var arrQryRegionFlds = objViewInfoENEx.arrQryRegionFldSet.Where(x => arrCtlType.Contains(x.CtlTypeId));
                if (arrQryRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrQryRegionFlds)
                    {
                        if (objInFor.QueryOptionId == enumQueryOption.NonQueryField_04) continue;
                        string strVarName = "";
                        var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                        if (objVar != null)
                        {
                            strVarName = objVar.GetVarName4View();
                        }
                        if (objVar.VarTypeId == enumGCVariableType.sessionStorage_0004)
                        {
                            CheckQueryField(objInFor);

                            if (objInFor.ObjFieldTab().ObjDataTypeAbbr().IsNumberType() == false)
                            {
                                sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ='{{0}}'\", {strVarName});");
                            }
                            else
                            {
                                sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ={{0}}\", {strVarName});");
                            }
                        }
                        if (string.IsNullOrEmpty(objVar.ClsName) == false)
                        {
                            ImportClass objImportClass = AddImportClass(objViewInfoENEx.MainTabId, objVar.FilePath, objVar.ClsName, enumImportObjType.CustomFunc, this.strBaseUrl);

                            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                        }

                        else
                        {
                            if (objInFor.ObjFieldTab().ObjDataTypeAbbr().IsNumberType() == false)
                            {
                                sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ='{{0}}'\", {ThisClsName}.{strVarName});");
                            }
                            else
                            {
                                sbTemp.Append("\r\n" + $"strWhereCond += Format(\" and {objInFor.ObjFieldTab().FldName} ={{0}}\", {ThisClsName}.{strVarName});");
                            }
                        }
                    }
                }

                if ((objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    && (objViewInfoENEx.arrQryRegionFldSet.Count > 0))
                {
                    strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                }
                else
                {
                    if (sbTemp.Length > 0)
                    {
                        strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "const strWhereCond = \" 1 = 1 \";");
                    }
                }
                if (objViewInfoENEx.ObjMainPrjTab().IsUseDelSign == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" and {{0}}='0'\", cls{0}EN.con_IsDeleted);", TabName_Out4ListRegion4GC);
                }
                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");

                strCodeForCs.Append("\r\n" + sbTemp.ToString());

                if (objViewInfoENEx.arrQryRegionFldSet.Count > 0)
                {
                    ImportClass objImportClass = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format("cls{0}EN", TabName_Out4ListRegion4GC), enumImportObjType.ENClass, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                    if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    {
                        strCodeForCs.Append("\r\n" + "try");
                        strCodeForCs.Append("\r\n" + "{");

                        foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                        {

                            if (objQryRegionFldsEx.IsUseFunc() && string.IsNullOrEmpty(objQryRegionFldsEx.DataPropertyName()) == false) continue;

                            string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ListRegion4GC);

                            if (objQryRegionFldsEx.CtlTypeId != enumCtlType.ViewVariable_38)
                            {
                                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                                {
                                    OperateType = "get",
                                    ControlType = objQryRegionFldsEx.objCtlType.CtlTypeName,
                                    CtrlId = objQryRegionFldsEx.CtrlId(),
                                    PropertyName = objQryRegionFldsEx.PropertyName,
                                    Comment = string.Format("{0} (Used In {1})", objQryRegionFldsEx.ObjFieldTabENEx.Caption,
                                                    "CombineCondition()"),

                                    DataType = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                                    ParentDivName = $"divVarSet.refDivQuery"
                                });
                                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                                {
                                    OperateType = "set",
                                    ControlType = objQryRegionFldsEx.objCtlType.CtlTypeName,
                                    CtrlId = objQryRegionFldsEx.CtrlId(),
                                    PropertyName = objQryRegionFldsEx.PropertyName,
                                    Comment = string.Format("{0} (Used In {1})", objQryRegionFldsEx.ObjFieldTabENEx.Caption,
                                             "CombineCondition()"),

                                    DataType = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                                    ParentDivName = $"divVarSet.refDivQuery"
                                });
                            }
                            if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                            switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                            {

                                case "CheckBox":
                                    //strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                    //            objQryRegionFldsEx.CtrlId());
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} == true)",
                                 objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0});",
                                             objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.AppendFormat("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", {1}.con_{0});",
                                         objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "DropDownList": ///如果控件是下拉框;
                                case "DropDownList_Bool": ///如果控件是下拉框;

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                    {

                                        //            strCodeForCs.AppendFormat("\r\n" + "const bol{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.Append("\r\n" + $"if (GetSelectSelectedIndexInDivObj(divVarSet.refDivQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 1)");
                                        ImportClass objImportClass2 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectSelectedIndexInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                        CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0}); ",
                                              objQryRegionFldsEx.FldName,
                                               strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                        strCodeForCs.Append("\r\n" + $"else if (GetSelectSelectedIndexInDivObj(divVarSet.refDivQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 2)");
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", {1}.con_{0});",
                                               objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");

                                    }
                                    else
                                    {
                                        //     strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != 0)",
                                                 objQryRegionFldsEx.PropertyName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\" && this.{0} != \"0\")",
                                                    objQryRegionFldsEx.PropertyName);
                                        }
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                        {
                                            case "string":


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, this.{1});",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                break;
                                            case "int":


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", {2}.con_{0}, this.{1});",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                break;
                                            default:


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, this.{1});",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                break;
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    break;

                                case "TextBox": ///如果控件类型是文本框;
                                    //strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                    //    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                        && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                                    {
                                        objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                                    }
                                    if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                                    (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///相等查询;
                                    {
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != 0)",
                                                objQryRegionFldsEx.PropertyName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")",
                                objQryRegionFldsEx.PropertyName);
                                        }

                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, this.{1});",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        strClsName_Fld);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", {2}.con_{0}, this.{1});",
                                     objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.PropertyName,
                                     strClsName_Fld);
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} like '%{{1}}%'\", {2}.con_{0}, this.{1});",
                                           objQryRegionFldsEx.FldName,
                                             objQryRegionFldsEx.PropertyName,
                                             strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                    { ///范围查询;
                                        strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, this.{1}), , );",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, this.{1}), , );",
                                             objQryRegionFldsEx.FldName,
                                              objQryRegionFldsEx.PropertyName,
                                              strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    break;
                                case "HyperLink":
                                    break;
                                case "Image":
                                    break;
                                case "ImageButton":
                                    break;
                                case "Label":
                                    break;
                                case "Link1Button":
                                    break;
                                case "ListBox":
                                    break;
                                case "Panel":
                                    break;
                                case "RadioButton":
                                    break;
                                case "RadioButtonList":
                                    break;
                                case "CheckBoxList":
                                    break;
                                case "DataGrid":
                                    break;
                                case "DataList":
                                    break;
                                case "Button":
                                    break;
                                case "sessionStorage":
                                    break;
                                case "CacheClassifyField":
                                    break;
                                case "ViewVariable":
                                    break;
                                default:
                                    var strMsg = string.Format("(errorId:018)控件类型：{0}在相应函数中没有被处理!({1})", objQryRegionFldsEx.objCtlType.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "catch(objException)");
                        strCodeForCs.Append("\r\n" + "{");
                        string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                          objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameCondition", "在组合查询条件(CombineTabNameCondition)时出错!请联系管理员!", "生成代码");
                        AutoGCPubFuncV6.CheckTabNameIsNotNull(ViewMainTabName4GC);

                        strCodeForCs.AppendFormat("\r\n" + "const strMsg:string = Format(\"(errid:{1})在组合查询条件(Combine{0}Condition)时出错!请联系管理员!{{0}}\", objException);",
                           ViewMainTabName4GC, strErrId);
                        strCodeForCs.Append("\r\n" + "throw strMsg;");
                        strCodeForCs.Append("\r\n" + "}");
                    }


                }
                strCodeForCs.Append("\r\n" + "return strWhereCond;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_CombineConditionObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objViewInfoENEx.arrQryRegionFldSet == null) return "";
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成仅有变量;

                strCodeForCs.Append("\r\n /** 把所有的查询控件内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.Append("\r\n * @returns 条件串(strWhereCond)");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + " public async Combine{0}ConditionObj(): Promise<cls{0}EN> ", TabName_Out4ListRegion4GC);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");
                clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);

                if ((objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    && (objViewInfoENEx.arrQryRegionFldSet.Count > 0))
                {
                    strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "const strWhereCond = \" 1 = 1 \";");
                }
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new cls{0}EN();", TabName_Out4ListRegion4GC);
                if (objViewInfoENEx.ObjMainPrjTab().IsUseDelSign == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" and {{0}}='0'\", cls{0}EN.con_IsDeleted);", TabName_Out4ListRegion4GC);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_IsDeleted, false, \"=\");", TabName_Out4ListRegion4GC);
                }
                List<string> arrCtlType = new List<string>() { enumCtlType.ViewVariable_38 };
                var arrQryRegionFlds = objViewInfoENEx.arrQryRegionFldSet.Where(x => arrCtlType.Contains(x.CtlTypeId));
                var arrQryRegionFldsEx = arrQryRegionFlds.Select(clsQryRegionFldsBLEx.CopyToEx);
                if (arrQryRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrQryRegionFldsEx)
                    {
                        if (objInFor.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                        if (objInFor.IsUseFunc() && string.IsNullOrEmpty(objInFor.DataPropertyName()) == false) continue;
                        if (objInFor.IsForExtendClass() == true) continue;
                        string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ListRegion4GC);

                        string strVarName = "";
                        var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                        if (objVar != null)
                        {
                            strVarName = objVar.GetVarName4View();
                        }
                        if (objVar.VarTypeId == enumGCVariableType.sessionStorage_0004 || objVar.VarTypeId == enumGCVariableType.localStorage_0003)
                        {
                            CheckQueryField(objInFor);

                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({4}.con_{1}, {3}, \"=\");",
                             TabName_Out4ListRegion4GC,
                             objInFor.ObjFieldTab().FldName,
                             ThisClsName,
                             strVarName, strClsName_Fld);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({4}.con_{1}, {2}.{3}, \"=\");",
                                TabName_Out4ListRegion4GC,
                                objInFor.ObjFieldTab().FldName,
                                ThisClsName,
                                strVarName, strClsName_Fld);
                        }
                    }
                }

                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");
                if (objViewInfoENEx.arrQryRegionFldSet.Count > 0)
                {

                    if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    {
                        strCodeForCs.Append("\r\n" + "try");
                        strCodeForCs.Append("\r\n" + "{");
                        foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                        {

                            if (objQryRegionFldsEx.IsUseFunc() && string.IsNullOrEmpty(objQryRegionFldsEx.DataPropertyName()) == false) continue;

                            string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ListRegion4GC);

                            if (objQryRegionFldsEx.CtlTypeId != enumCtlType.ViewVariable_38)
                            {
                                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                                {
                                    OperateType = "get",
                                    ControlType = objQryRegionFldsEx.objCtlType.CtlTypeName,
                                    CtrlId = objQryRegionFldsEx.CtrlId(),
                                    PropertyName = objQryRegionFldsEx.PropertyName,
                                    Comment = string.Format("{0} (Used In {1})", objQryRegionFldsEx.ObjFieldTabENEx.Caption,
                                            "CombineConditionObj()"),
                                    DataType = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                                    ParentDivName = $"divVarSet.refDivQuery"
                                });
                            }
                            if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                            switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                            {

                                case "CheckBox":
                                    //strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                    //            objQryRegionFldsEx.CtrlId());
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} == true)",
                                 objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0});",
                                             objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1}, true, \"=\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.FldName, strClsName_Fld);


                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.AppendFormat("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", {1}.con_{0});",
                                         objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, false, \"=\");",
                                    TabName_Out4ListRegion4GC,
                                    objQryRegionFldsEx.FldName, strClsName_Fld);

                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "DropDownList": ///如果控件是下拉框;
                                case "DropDownList_Bool": ///如果控件是下拉框;

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                    {

                                        //            strCodeForCs.AppendFormat("\r\n" + "const bol{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.Append("\r\n" + $"if (GetSelectSelectedIndexInDivObj(divVarSet.refDivQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 1)");
                                        ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectSelectedIndexInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                        CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0}); ",
                                              objQryRegionFldsEx.FldName,
                                               strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, true, \"=\");",
                                            TabName_Out4ListRegion4GC,
                                            objQryRegionFldsEx.FldName, strClsName_Fld);

                                        strCodeForCs.Append("\r\n" + "}");
                                        strCodeForCs.Append("\r\n" + $"else if (GetSelectSelectedIndexInDivObj(divVarSet.refDivQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 2)");
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", {1}.con_{0});",
                                               objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, false, \"=\");",
                                            TabName_Out4ListRegion4GC,
                                            objQryRegionFldsEx.FldName, strClsName_Fld);

                                        strCodeForCs.Append("\r\n" + "}");

                                    }
                                    else
                                    {
                                        //     strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != 0)",
                                                 objQryRegionFldsEx.PropertyName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\" && this.{0} != \"0\")",
                                                    objQryRegionFldsEx.PropertyName);
                                        }
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                        {
                                            case "string":


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, this.{1});",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                            TabName_Out4ListRegion4GC,
                                            objQryRegionFldsEx.FldName,
                                            objQryRegionFldsEx.PropertyName, strClsName_Fld);


                                                break;
                                            case "int":


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", {2}.con_{0}, this.{1});",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                                break;
                                            default:


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, this.{1});",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                                break;
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    break;

                                case "TextBox": ///如果控件类型是文本框;
                                    //strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                    //    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                        && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                                    {
                                        objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                                    }
                                    if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                                    (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///相等查询;
                                    {
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != 0)",
                                                objQryRegionFldsEx.PropertyName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")",
                                objQryRegionFldsEx.PropertyName);
                                        }

                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, this.{1});",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        strClsName_Fld);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", {2}.con_{0}, this.{1});",
                                     objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.PropertyName,
                                     strClsName_Fld);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} like '%{{1}}%'\", {2}.con_{0}, this.{1});",
                                           objQryRegionFldsEx.FldName,
                                             objQryRegionFldsEx.PropertyName,
                                             strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"like\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);

                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                    { ///范围查询;
                                        strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, this.{1});",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                    TabName_Out4ListRegion4GC,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, this.{1}), , );",
                                             objQryRegionFldsEx.FldName,
                                              objQryRegionFldsEx.PropertyName,
                                              strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                    TabName_Out4ListRegion4GC,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    break;
                                case "HyperLink":
                                    break;
                                case "Image":
                                    break;
                                case "ImageButton":
                                    break;
                                case "Label":
                                    break;
                                case "Link1Button":
                                    break;
                                case "ListBox":
                                    break;
                                case "Panel":
                                    break;
                                case "RadioButton":
                                    break;
                                case "RadioButtonList":
                                    break;
                                case "CheckBoxList":
                                    break;
                                case "DataGrid":
                                    break;
                                case "DataList":
                                    break;
                                case "Button":
                                    break;
                                case "sessionStorage":
                                    break;
                                case "CacheClassifyField":
                                    break;
                                case "ViewVariable":
                                    break;
                                default:
                                    var strMsg = string.Format("(errorId:018)控件类型：{0}在相应函数中没有被处理!({1})", objQryRegionFldsEx.objCtlType.CtlTypeName, clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        //处理针对扩展字段的查询
                        strCodeForCs.Append("\r\n" + Gen_WApi_Ts_CombineConditionInFldValueLst());

                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "catch(objException)");
                        strCodeForCs.Append("\r\n" + "{");
                        string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                          objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameConditionObj", "在组合查询条件对象(CombineTabNameConditionObj)时出错!请联系管理员!", "生成代码");
                        AutoGCPubFuncV6.CheckTabNameIsNotNull(ViewMainTabName4GC);

                        strCodeForCs.AppendFormat("\r\n" + "const strMsg:string = Format(\"(errid:{1})在组合查询条件对象(Combine{0}ConditionObj)时出错!请联系管理员!{{0}}\", objException);",
                           ViewMainTabName4GC, strErrId);
                        strCodeForCs.Append("\r\n" + "throw strMsg;");
                        strCodeForCs.Append("\r\n" + "}");
                    }

                }
                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.whereCond = strWhereCond;", TabName_Out4ListRegion4GC);
                strCodeForCs.AppendFormat("\r\n" + "return obj{0}Cond;", TabName_Out4ListRegion4GC);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string GeneSetOperate(string strFldName, string strDataPropertyName, string strTabName, bool bolIsNumberType)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}_{1} = await {2}Ex_FuncMapKey{1}(obj{2}Cond);",
                                 strFldName, strDataPropertyName, strTabName);
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}Include.length == 0)",
                strFldName, strDataPropertyName);
            strCodeForCs.Append("\r\n" + "{");
            if (bolIsNumberType == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "arr{0}Include = arr{0}_{1}.map(x=>x);",
                    strFldName, strDataPropertyName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "arr{0}Include = intersectSets_Number(arr{0}Include, arr{0}_{1}.map(x=>x)); ",
                    strFldName, strDataPropertyName);
                strCodeForCs.Append("\r\n" + "}");
                ImportClass objImportClass2 = AddImportClass(TabId_Out4ListRegion, "/PubFun/clsCommFunc4Ctrl.js", "intersectSets_Number", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "arr{0}Include = arr{0}_{1}.map(x=>x.toString());",
                    strFldName, strDataPropertyName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "arr{0}Include = intersectSets(arr{0}Include, arr{0}_{1}.map(x=>x.toString())); ",
                    strFldName, strDataPropertyName);
                strCodeForCs.Append("\r\n" + "}");
                ImportClass objImportClass3 = AddImportClass(TabId_Out4ListRegion, "/PubFun/clsCommFunc4Ctrl.js", "intersectSets", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);

            }
            ImportClass objImportClass = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC + "Ex", String.Format("FuncMapKey{0}", strDataPropertyName), enumImportObjType.WApiExtendClassFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);


            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_GetConditionInFldValueLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objViewInfoENEx.arrQryRegionFldSet == null) return "";
            var arrQryRegionFldSetEx = objViewInfoENEx.arrQryRegionFldSet.Where(x => x.IsUseFunc() == true && string.IsNullOrEmpty(x.DataPropertyName()) == false).ToList();
            if (arrQryRegionFldSetEx.Count == 0) return "";
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成仅有变量;
                var arrQryRegionFld_InFld = arrQryRegionFldSetEx.GroupBy(x => x.FldId).ToList();
                foreach (var arrInFld in arrQryRegionFld_InFld)
                {
                    string strFldId = arrInFld.Key;
                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(strFldId, objViewInfoENEx.PrjId);
                    string strInFldIdType = objFieldTab.TypeScriptType();
                    //if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
                    //{
                    //    strReturnString = "string";
                    //}
                    strCodeForCs.Append("\r\n /** 把所有的查询控件内容组合成一个条件串");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                    strCodeForCs.AppendFormat("\r\n * @returns 相关字段的InFldId列表(Array<{0}>)", strInFldIdType);
                    strCodeForCs.Append("\r\n" + " **/");

                    strCodeForCs.AppendFormat("\r\n" + " public async GetCondition_{0}Lst_In(): Promise<Array<{1}>> ", objFieldTab.FldName, strInFldIdType);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                    strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");

                    strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new cls{0}ENEx();", TabName_Out4ListRegion4GC);

                    string strClsName_Fld = string.Format("cls{0}ENEx", TabName_Out4ListRegion4GC);


                    strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");
                    strCodeForCs.AppendFormat("\r\n" + "let arr{0}Include: Array<{1}> = [];", objFieldTab.FldName, strInFldIdType);
                    //if (objViewInfoENEx.arrQryRegionFldSet.Count > 0)
                    //{

                    //    if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    //    {
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (var objQryRegionFldsEx in arrInFld)
                    {

                        if (objQryRegionFldsEx.CtlTypeId != enumCtlType.ViewVariable_38)
                        {

                            arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            {
                                OperateType = "get",
                                ControlType = objQryRegionFldsEx.objCtlType.CtlTypeName,
                                CtrlId = objQryRegionFldsEx.CtrlId(),
                                PropertyName = objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase),
                                Comment = string.Format("{0} (Used In {1})", objQryRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "GetConditionInFldValueLst()"),
                                DataType = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                                ParentDivName = $"divVarSet.refDivQuery"
                            });
                        }
                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                        {

                            case "CheckBox":
                                //strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                //            objQryRegionFldsEx.CtrlId());
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0} == true)",
                             objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0});",
                                         objQryRegionFldsEx.DataPropertyName4GC(),
                                         strClsName_Fld);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, true, \"=\");",
                                    TabName_Out4ListRegion4GC,
                                    objQryRegionFldsEx.DataPropertyName4GC(), strClsName_Fld);


                                strCodeForCs.Append("\r\n" + "}");

                                strCodeForCs.AppendFormat("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, false, \"=\");",
                                TabName_Out4ListRegion4GC,
                                objQryRegionFldsEx.DataPropertyName(), strClsName_Fld);
                                strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName(), objPrjTabEx_ListRegion.TabName, objFieldTab.IsNumberType()));

                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "DropDownList": ///如果控件是下拉框;
                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                {

                                    //            strCodeForCs.AppendFormat("\r\n" + "const bol{0} = $(\"#{1}\").val();",
                                    //objQryRegionFldsEx.DataPropertyName(), objQryRegionFldsEx.CtrlId());

                                    strCodeForCs.Append("\r\n" + $"if (GetSelectSelectedIndexInDivObj(divVarSet.refDivQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 1)");
                                    ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectSelectedIndexInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, true, \"=\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.DataPropertyName4GC(), strClsName_Fld);

                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + $"else if (GetSelectSelectedIndexInDivObj(divVarSet.refDivQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 2)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, false, \"=\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.DataPropertyName4GC(), strClsName_Fld);
                                    strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName4GC(), objPrjTabEx_ListRegion.TabName, objFieldTab.IsNumberType()));

                                    strCodeForCs.Append("\r\n" + "}");

                                }
                                else
                                {
                                    //     strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                    //objQryRegionFldsEx.DataPropertyName4GC(), objQryRegionFldsEx.CtrlId());
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != 0)",
                                             objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\" && this.{0} != \"0\")",
                                                objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    }
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                    switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                    {
                                        case "string":

                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                        TabName_Out4ListRegion4GC,
                                        objQryRegionFldsEx.DataPropertyName4GC(),
                                        objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase), strClsName_Fld);


                                            break;
                                        case "int":

                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                    TabName_Out4ListRegion4GC,
                                    objQryRegionFldsEx.DataPropertyName4GC(),
                                    objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase), strClsName_Fld);
                                            break;
                                        default:

                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                    TabName_Out4ListRegion4GC,
                                    objQryRegionFldsEx.DataPropertyName4GC(),
                                    objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase), strClsName_Fld);
                                            break;
                                    }
                                    strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName4GC(), objPrjTabEx_ListRegion.TabName, objFieldTab.IsNumberType()));
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                break;

                            case "TextBox": ///如果控件类型是文本框;
                                //strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                //    objQryRegionFldsEx.DataPropertyName4GC(), objQryRegionFldsEx.CtrlId());

                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                    && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                                {
                                    objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                                }
                                if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                                (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///相等查询;
                                {
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != 0)",
                                            objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")",
                            objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    }

                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                    {

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                    TabName_Out4ListRegion4GC,
                                    objQryRegionFldsEx.DataPropertyName4GC(),
                                    objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase), strClsName_Fld);
                                    }
                                    else
                                    {

                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                    TabName_Out4ListRegion4GC,
                                    objQryRegionFldsEx.DataPropertyName4GC(),
                                    objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase), strClsName_Fld);
                                    }
                                    strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName4GC(), objPrjTabEx_ListRegion.TabName, objFieldTab.IsNumberType()));

                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\")", objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"like\");",
                                    TabName_Out4ListRegion4GC,
                                    objQryRegionFldsEx.DataPropertyName4GC(),
                                    objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase), strClsName_Fld);
                                    strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName4GC(), objPrjTabEx_ListRegion.TabName, objFieldTab.IsNumberType()));

                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                { ///范围查询;
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                TabName_Out4ListRegion4GC,
                                objQryRegionFldsEx.DataPropertyName4GC(),
                                objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase), strClsName_Fld);
                                    strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName4GC(), objPrjTabEx_ListRegion.TabName, objFieldTab.IsNumberType()));

                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase));
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ListRegion4GC);

                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                TabName_Out4ListRegion4GC,
                                objQryRegionFldsEx.DataPropertyName4GC(),
                                objQryRegionFldsEx.DataPropertyName_Property(this.IsFstLcase), strClsName_Fld);
                                    strCodeForCs.Append("\r\n" + GeneSetOperate(objFieldTab.FldName, objQryRegionFldsEx.DataPropertyName4GC(), objPrjTabEx_ListRegion.TabName, objFieldTab.IsNumberType()));

                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "Button":
                                break;
                        }
                    }

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch(objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                      objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GetConditionInFldValueLst", "在组合查询条件中关键字列表(GetConditionInFldValueLst)时出错!请联系管理员!", "生成代码");
                    AutoGCPubFuncV6.CheckTabNameIsNotNull(ViewMainTabName4GC);

                    strCodeForCs.AppendFormat("\r\n" + "const strMsg:string = Format(\"(errid:{1})在组合查询条件中关键字列表(GetConditionInFldValueLst)时出错!请联系管理员!{{0}}\", objException);",
                       ViewMainTabName4GC, strErrId);
                    strCodeForCs.Append("\r\n" + "throw strMsg;");
                    strCodeForCs.Append("\r\n" + "}");
                    //    }

                    //}

                    strCodeForCs.AppendFormat("\r\n" + "return arr{0}Include;", objFieldTab.FldName);
                    strCodeForCs.Append("\r\n" + "}");

                }

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_CombineConditionInFldValueLst()
        {
            var arrQryRegionFldSetEx = objViewInfoENEx.arrQryRegionFldSet.Where(x => x.IsUseFunc() == true && string.IsNullOrEmpty(x.DataPropertyName()) == false).ToList();
            if (arrQryRegionFldSetEx.Count == 0) return "";
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ListRegion4GC);

                ///生成仅有变量;
                var arrQryRegionFld_InFld = arrQryRegionFldSetEx.GroupBy(x => x.FldId).ToList();
                foreach (var arrInFld in arrQryRegionFld_InFld)
                {
                    string strFldId = arrInFld.Key;
                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(strFldId, objViewInfoENEx.PrjId);
                    string strFldName = objFieldTab.FldName;

                    strCodeForCs.AppendFormat("\r\n" + "//处理针对扩展字段:[{0}]的查询", strFldName);
                    strCodeForCs.AppendFormat("\r\n" + "const arr{0} = await this.GetCondition_{0}Lst_In();", strFldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (arr{0}.length > 0)", strFldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} in ({{1}})\", {0}.con_{1}, arr{1}.join(','));",
                        strClsName_Fld, strFldName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({1}.con_{2}, arr{2}.join(','), \"in\");",
                        TabName_Out4ListRegion4GC, strClsName_Fld, strFldName);
                    strCodeForCs.Append("\r\n" + "}");

                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_CombineConditionObj4ExportExcel(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;


                strCodeForCs.Append("\r\n /** 把所有的查询控件内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.Append("\r\n * @returns 条件串(strWhereCond)");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + " public async Combine{0}ConditionObj4ExportExcel():Promise<cls{0}EN> ", TabName_Out4ExportExcel4GC);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");
                clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);

                if ((objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    && (objViewInfoENEx.arrQryRegionFldSet.Count > 0))
                {
                    strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "const strWhereCond = \" 1 = 1 \";");
                }

                strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new cls{0}ENEx();", TabName_Out4ExportExcel4GC);
                ImportClass objImportClass = AddImportClass(TabId_Out4ExportExcel, TabName_Out4ExportExcel4GC, string.Format("cls{0}EN", TabName_Out4ExportExcel4GC), enumImportObjType.ENExClass, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                if (objViewInfoENEx.ObjMainPrjTab().IsUseDelSign == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" and {{0}}='0'\", cls{0}EN.con_IsDeleted);", TabName_Out4ListRegion4GC);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_IsDeleted, false, \"=\");", TabName_Out4ListRegion4GC);
                }
                List<string> arrCtlType = new List<string>() { enumCtlType.ViewVariable_38 };
                var arrQryRegionFlds = objViewInfoENEx.arrQryRegionFldSet.Where(x => arrCtlType.Contains(x.CtlTypeId));
                if (arrQryRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrQryRegionFlds)
                    {
                        if (objInFor.QueryOptionId == enumQueryOption.NonQueryField_04) continue;
                        if (objInFor.IsForExtendClass()) continue;
                        string strVarName = "";
                        var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                        if (objVar != null)
                        {
                            strVarName = objVar.GetVarName4View();
                        }
                        if (objVar.VarTypeId == enumGCVariableType.sessionStorage_0004 || objVar.VarTypeId == enumGCVariableType.localStorage_0003)
                        {
                            CheckQueryField(objInFor);

                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1}, {3}, \"=\");",
                             TabName_Out4ExportExcel4GC,
                             objInFor.ObjFieldTab().FldName,
                             ThisClsName,
                             strVarName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.{3}, \"=\");",
                                TabName_Out4ExportExcel4GC,
                                objInFor.ObjFieldTab().FldName,
                                ThisClsName,
                                strVarName);
                        }
                        if (string.IsNullOrEmpty(objVar.ClsName) == false)
                        {
                            ImportClass objImportClass2 = AddImportClass(objViewInfoENEx.MainTabId, objVar.FilePath, objVar.ClsName, enumImportObjType.CustomFunc, this.strBaseUrl);

                            CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

                        }
                    }
                }

                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");
                if (objViewInfoENEx.arrQryRegionFldSet.Count() > 0)
                {
                    if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                    {
                        strCodeForCs.Append("\r\n" + "try");
                        strCodeForCs.Append("\r\n" + "{");
                        foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                        {

                            if (objQryRegionFldsEx.IsUseFunc() && string.IsNullOrEmpty(objQryRegionFldsEx.DataPropertyName()) == false) continue;
                            string strClsName_Fld = string.Format("cls{0}EN", TabName_Out4ExportExcel4GC);
                            if (objQryRegionFldsEx.CtlTypeId != enumCtlType.ViewVariable_38)
                            {
                                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                                {
                                    OperateType = "get",
                                    ControlType = objQryRegionFldsEx.objCtlType.CtlTypeName,
                                    CtrlId = objQryRegionFldsEx.CtrlId(),
                                    PropertyName = objQryRegionFldsEx.PropertyName,
                                    Comment = string.Format("{0} (Used In {1})", objQryRegionFldsEx.ObjFieldTabENEx.Caption,
                                            "ConditionObj4ExportExcel()"),
                                    DataType = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                                    ParentDivName = $"divVarSet.refDivQuery"
                                });
                            }
                            if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                            switch (objQryRegionFldsEx.objCtlType.CtlTypeName) //objEditRegionFldsEx.objCtlType.CtlTypeName
                            {

                                case "CheckBox":
                                    //strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                    //            objQryRegionFldsEx.CtrlId());
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} == true)",
                                 objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0});",
                                             objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, true, \"=\");",
                                        TabName_Out4ExportExcel4GC,
                                        objQryRegionFldsEx.FldName, strClsName_Fld);


                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.AppendFormat("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", {1}.con_{0});",
                                         objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, false, \"=\");",
                                    TabName_Out4ExportExcel4GC,
                                    objQryRegionFldsEx.FldName, strClsName_Fld);

                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "DropDownList": ///如果控件是下拉框;
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                    {

                                        //            strCodeForCs.AppendFormat("\r\n" + "const bol{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                        strCodeForCs.Append("\r\n" + $"if (GetSelectSelectedIndexInDivObj(divVarSet.refDivQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 1)");
                                        ImportClass objImportClass2 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectSelectedIndexInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                        CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", {1}.con_{0}); ",
                                              objQryRegionFldsEx.FldName,
                                               strClsName_Fld,
                                              "{", "}");
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, true, \"=\");",
                                            TabName_Out4ExportExcel4GC,
                                            objQryRegionFldsEx.FldName, strClsName_Fld);

                                        strCodeForCs.Append("\r\n" + "}");
                                        strCodeForCs.Append("\r\n" + $"else if (GetSelectSelectedIndexInDivObj(divVarSet.refDivQuery, \"{objQryRegionFldsEx.CtrlId()}\") == 2)");
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);

                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", {1}.con_{0});",
                                               objQryRegionFldsEx.FldName,
                                             strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({2}.con_{1}, false, \"=\");",
                                            TabName_Out4ExportExcel4GC,
                                            objQryRegionFldsEx.FldName, strClsName_Fld);

                                        strCodeForCs.Append("\r\n" + "}");

                                    }
                                    else
                                    {
                                        //     strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                        //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != 0)",
                                                 objQryRegionFldsEx.PropertyName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\" && this.{0} != \"0\")",
                                                    objQryRegionFldsEx.PropertyName);
                                        }
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                        switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                        {
                                            case "string":


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, this.{1});",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                            TabName_Out4ExportExcel4GC,
                                            objQryRegionFldsEx.FldName,
                                            objQryRegionFldsEx.PropertyName, strClsName_Fld);


                                                break;
                                            case "int":


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", {2}.con_{0}, this.{1});",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                        TabName_Out4ExportExcel4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                                break;
                                            default:


                                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, this.{1});",
                                                objQryRegionFldsEx.FldName,
                                                objQryRegionFldsEx.PropertyName,
                                                strClsName_Fld);
                                                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                        TabName_Out4ExportExcel4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                                break;
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    break;

                                case "TextBox": ///如果控件类型是文本框;
                                    //strCodeForCs.AppendFormat("\r\n" + "const str{0} = $(\"#{1}\").val();",
                                    //    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId());

                                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() != "string"
                                        && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                                    {
                                        objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                                    }
                                    if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                                    (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///相等查询;
                                    {
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != 0)",
                                                objQryRegionFldsEx.PropertyName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")",
                                objQryRegionFldsEx.PropertyName);
                                        }

                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                        if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, this.{1});",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        strClsName_Fld);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                        TabName_Out4ExportExcel4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", {2}.con_{0}, this.{1});",
                                     objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.PropertyName,
                                     strClsName_Fld);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                        TabName_Out4ExportExcel4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        }
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} like '%{{1}}%'\", {2}.con_{0}, this.{1});",
                                           objQryRegionFldsEx.FldName,
                                             objQryRegionFldsEx.PropertyName,
                                             strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"like\");",
                                        TabName_Out4ExportExcel4GC,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName, strClsName_Fld);

                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                    { ///范围查询;
                                        strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, this.{1});",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                    TabName_Out4ExportExcel4GC,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName, strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                        strCodeForCs.Append("\r\n" + "{");
                                        AutoGCPubFuncV6.CheckTabNameIsNotNull(TabName_Out4ExportExcel4GC);
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", {2}.con_{0}, this.{1}), , );",
                                             objQryRegionFldsEx.FldName,
                                              objQryRegionFldsEx.PropertyName,
                                              strClsName_Fld);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue({3}N.con_{1}, this.{2}, \"=\");",
                                    TabName_Out4ExportExcel4GC,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName,
                                    strClsName_Fld);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    break;
                                case "HyperLink":
                                    break;
                                case "Image":
                                    break;
                                case "ImageButton":
                                    break;
                                case "Label":
                                    break;
                                case "Link1Button":
                                    break;
                                case "ListBox":
                                    break;
                                case "Panel":
                                    break;
                                case "RadioButton":
                                    break;
                                case "RadioButtonList":
                                    break;
                                case "CheckBoxList":
                                    break;
                                case "DataGrid":
                                    break;
                                case "DataList":
                                    break;
                                case "Button":
                                    break;
                            }
                        }
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "catch(objException)");
                        strCodeForCs.Append("\r\n" + "{");
                        string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                          objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameConditionObj4ExportExcel", "在组合导出Excel条件对象(CombineTabNameConditionObj)时出错!请联系管理员!", "生成代码");
                        AutoGCPubFuncV6.CheckTabNameIsNotNull(ViewMainTabName4GC);

                        strCodeForCs.AppendFormat("\r\n" + "const strMsg:string = Format(\"(errid:{1})在组合导出Excel条件对象(Combine{0}ConditionObj4ExportExcel)时出错!请联系管理员!{{0}}\", objException);",
                           ViewMainTabName4GC, strErrId);
                        strCodeForCs.Append("\r\n" + "throw strMsg;");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.whereCond = strWhereCond;", TabName_Out4ExportExcel4GC);
                strCodeForCs.AppendFormat("\r\n" + "return obj{0}Cond;", TabName_Out4ExportExcel4GC);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }



        private void GC_GetInputValue4Para_TS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, StringBuilder strCodeForCs)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            string strMsg = "";
            //            StringBuilder strCodeForCs = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
            clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                    clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                    if (objDataTypeAbbrEN == null)
                    {
                        objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                        if (objSelfDefDataTypeEN_Para == null)
                        {
                            strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                                objFuncPara4CodeEN.ParameterType);
                            throw new Exception(strMsg);
                        }
                    }
                    if (objFuncPara4CodeEN.IsByRef == true)
                    {
                        strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
                           objFuncPara4CodeEN.ParaName,
                             objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        if (objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {1} = $('#txt{1}{2}').val();",
                                objDataTypeAbbrEN.TypeScriptType,
                                objFuncPara4CodeEN.ParaName,
                                objvFunction4GeneCodeEN.OrderNum);
                        }
                        else
                        {
                            switch (objFuncPara4CodeEN.DataTypeId)
                            {
                                case enumDataTypeAbbr.float_07:
                                case enumDataTypeAbbr.int_09:
                                case enumDataTypeAbbr.bigint_01:
                                case enumDataTypeAbbr.bigintidentity_26:

                                case enumDataTypeAbbr.money_11:
                                    strCodeForCs.AppendFormat("\r\n" + "const {1} = Number($('#txt{1}{2}').val());",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.Array_31:
                                    strCodeForCs.AppendFormat("\r\n" + "const {1} = $('#txt{1}{2}').val();",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                default:
                                    strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理!({3})",
                                        objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                        objDataTypeAbbrEN.TypeScriptType,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        //if (objSelfDefDataTypeEN_Para != null)
                        //{
                        //    sbParaList.AppendFormat("{0} {1},",
                        //        objSelfDefDataTypeEN_Para.CsType,
                        //        objFuncPara4CodeEN.ParaName);
                        //}
                        //else
                        //{
                        //    sbParaList.AppendFormat("{0} {1},",
                        //        objDataTypeAbbrEN.CsType,
                        //        objFuncPara4CodeEN.ParaName);
                        //}
                        //sbParaVarList.AppendFormat("{0},", objFuncPara4CodeEN.ParaName);
                    }
                }
            }

        }

        private string GetCode4FieldInPutDataToClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.CtlTypeId != enumCtlType.ViewVariable_38)
            {
                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "get",
                    ControlType = objEditRegionFldsEx.CtlTypeName,
                    CtrlId = objEditRegionFldsEx.CtrlId,
                    PropertyName = objEditRegionFldsEx.PropertyName(this.IsFstLcase),
                    Comment = string.Format("{0} (Used In {1})", objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "PutDataToClass()"),
                    DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                    ParentDivName = $"this.divEdit"
                });
            }
            if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14)
            {
                string strDefaUserIdExpress = clsPubFun4GC.GetDefaUserIdExpress(objViewInfoENEx.PrjId);
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = {2};",
                    ViewMainTabName4GC,
                    objEditRegionFldsEx.PropertyName(this.IsFstLcase), strDefaUserIdExpress);
                var objGCVariable = clsGCVariableBLEx.GetObjByVarNameAndType("UserId", enumGCVariableType.localStorage_0003, objViewInfoENEx.PrjId);
                if (objGCVariable != null)
                {
                    ImportClass objImportClass = AddImportClass(objViewInfoENEx.MainTabId, objGCVariable.FilePath, objGCVariable.ClsName, enumImportObjType.CustomFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                }
            }
            else
            {
                switch (objEditRegionFldsEx.CtlTypeId)
                {
                    case enumCtlType.CheckBox_02:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
         ViewMainTabName4GC,
         objEditRegionFldsEx.PropertyName(this.IsFstLcase),
         objEditRegionFldsEx.CtrlId);
                        break;
                    case enumCtlType.TextBox_16:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
         ViewMainTabName4GC,
         objEditRegionFldsEx.PropertyName(this.IsFstLcase),
         objEditRegionFldsEx.CtrlId);
                        break;
                    case enumCtlType.TextArea_41:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
         ViewMainTabName4GC,
         objEditRegionFldsEx.PropertyName(this.IsFstLcase),
         objEditRegionFldsEx.CtrlId);
                        break;
                    case enumCtlType.DropDownList_06:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
         ViewMainTabName4GC,
         objEditRegionFldsEx.PropertyName(this.IsFstLcase),
         objEditRegionFldsEx.CtrlId);
                        break;

                    case enumCtlType.ViewVariable_38:
                        string strVarName = "";
                        var objVar = clsGCVariableBL.GetObjByVarIdCache(objEditRegionFldsEx.VarId);
                        if (objVar != null)
                        {
                            strVarName = objVar.GetVarName4View();
                        }
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = {2}.{3};",
         ViewMainTabName4GC,
         objEditRegionFldsEx.PropertyName(this.IsFstLcase),
         ThisClsName, strVarName);
                        break;
                    case enumCtlType.GivenValue_35:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = {2}.value;",
         ViewMainTabName4GC,
         objEditRegionFldsEx.PropertyName(this.IsFstLcase),
         thisCacheClassify4View.ViewVarName);
                        break;

                    default:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
                ViewMainTabName4GC,
                objEditRegionFldsEx.PropertyName(this.IsFstLcase),
                objEditRegionFldsEx.CtrlId);
                        break;
                }
            }
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_GetDataFromClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:把类对象的属性内容显示到界面上");
                strCodeForCs.Append("\r\n * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值");
                strCodeForCs.Append("\r\n * 如果在设置数据库时,就应该一级字段在前,二级字段在后");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param pobj{0}EN:表实体类对象",
                ViewMainTabName4GC);
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async GetDataFrom{0}Class(pobj{2}EN: cls{1}EN )",
                ViewMainTabName4GC, ViewMainTabName4GC, ViewMainTabName4GC);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetDataFrom{0}Class.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    string strTemp = GetCode4FieldInGetDataFromClass(objEditRegionFldsEx, objViewInfoENEx);
                    strCodeForCs.AppendFormat("{0}", strTemp);

                }
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        private string GetCode4FieldInShowDetailDataFromClass(clsDetailRegionFldsENEx objDetailRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();

            if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objDetailRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = objDetailRegionFldsEx.CtlTypeName,
                CtrlId = objDetailRegionFldsEx.CtrlId + "_d",
                PropertyName = objDetailRegionFldsEx.PropertyName(this.IsFstLcase) + "_d",
                Comment = string.Format("{0} (Used In {1})", objDetailRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "ShowDetailDataFromClass()"),
                DataType = objDetailRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                ParentDivName = $"this.divDetail"
            });
            switch (objDetailRegionFldsEx.CtlTypeId)
            {
                case enumCtlType.CheckBox_02:
                    //7、设置checkbox为选中状态
                    //$('input:checkbox').attr("checked", 'checked');//or
                    //$('input:checkbox').attr("checked", true);
                    //8、设置checkbox为不选中状态
                    //$('input:checkbox').attr("checked", '');//or
                    //$('input:checkbox').attr("checked", false);
                    sbCodeForCs.AppendFormat("\r\n" + "this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                TabName_Out4ListRegion4GC,
                                objDetailRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.GivenValue_35:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                TabName_Out4ListRegion4GC,
                                objDetailRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.DropDownList_06:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                TabName_Out4ListRegion4GC,
                                objDetailRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                TabName_Out4ListRegion4GC,
                                objDetailRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
            }

            return sbCodeForCs.ToString();
        }



        private string GetCode4FieldInGetDataFromClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();


            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.CtlTypeId != enumCtlType.ViewVariable_38)
            {
                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = objEditRegionFldsEx.CtlTypeName,
                    CtrlId = objEditRegionFldsEx.CtrlId,
                    PropertyName = objEditRegionFldsEx.PropertyName(this.IsFstLcase),
                    Comment = string.Format("{0} (Used In {1})", objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "GetDataFromClass()"),
                    DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                    ParentDivName = $"this.divEdit"
                });
            }
            switch (objEditRegionFldsEx.CtlTypeId)
            {
                case enumCtlType.CheckBox_02:
                    //7、设置checkbox为选中状态
                    //$('input:checkbox').attr("checked", 'checked');//or
                    //$('input:checkbox').attr("checked", true);
                    //8、设置checkbox为不选中状态
                    //$('input:checkbox').attr("checked", '');//or
                    //$('input:checkbox').attr("checked", false);
                    sbCodeForCs.AppendFormat("\r\n" + "this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                ViewMainTabName4GC,
                                objEditRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.GivenValue_35:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                ViewMainTabName4GC,
                                objEditRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.DropDownList_06:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                ViewMainTabName4GC,
                                objEditRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                ViewMainTabName4GC,
                                objEditRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
            }

            return sbCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_GetFirstKey()
        {
            if (strFuncName4BindGv == "") return "";
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:从界面列表中获取第一个关键字的值");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param pobj{0}EN:表实体类对象",
                ViewMainTabName4GC);
                strCodeForCs.Append("\r\n * @returns 列表的第一个关键字值");
                strCodeForCs.Append("\r\n" + " **/");
                strFuncName = $"GetFirstKey";

                strCodeForCs.Append("\r\n" + "public GetFirstKey(): string {");
                //         strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetFirstKey.name;",
                //ViewMainTabName4GC, objKeyField.FldName);

                strCodeForCs.Append("\r\n" + "if (arrSelectedKeys.length == 1) {");
                strCodeForCs.Append("\r\n" + "return arrSelectedKeys[0];");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "else {");

                strCodeForCs.Append("\r\n" + "alert(`请选择一个关键字!目前选择了:${ arrSelectedKeys.length}个关键字。`);");
                strCodeForCs.Append("\r\n" + "return \"\";");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");


            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_SortByBak()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:从界面列表中根据某一个字段排序");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param objAnchorElement:带有排序字段的Anchors",
                    ViewMainTabName4GC);

                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public async SortBy(objAnchorElement:any) {");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SortBy.name;",
       ViewMainTabName4GC, objKeyField.FldName);

                strCodeForCs.Append("\r\n" + " console.log(\"objAnchorElement(In SetAllCkechedKeysV2):\", objAnchorElement);");
                strCodeForCs.Append("\r\n" + "//event = window.event || event;");
                strCodeForCs.Append("\r\n" + "if (typeof(objAnchorElement) == \"function\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}.sortFunStatic = objAnchorElement;", ThisClsName);

                strCodeForCs.AppendFormat("\r\n" + "if (viewVarSet.ascOrDesc4SortFun.indexOf(\"Asc\") >= 0)", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "viewVarSet.ascOrDesc4SortFun = Format(\"Desc\");", ThisClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "viewVarSet.ascOrDesc4SortFun = Format(\"Asc\");", ThisClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "viewVarSet.sort{0}By = \"\";", TabName_Out4ListRegion4GC, ThisClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "const thisEventObj: HTMLInputElement = objAnchorElement;");

                strCodeForCs.Append("\r\n" + "const strFldName = thisEventObj.getAttribute(\"FldName\") as string;");
                strCodeForCs.Append("\r\n" + "  if (IsNullOrEmpty(strFldName) == true) return;");
                strCodeForCs.Append("\r\n" + "const strSortByFld = strFldName;");

                strCodeForCs.AppendFormat("\r\n" + "if (viewVarSet.sort{0}By.indexOf(strSortByFld) >= 0)", TabName_Out4ListRegion4GC, ThisClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (viewVarSet.sort{0}By.indexOf(\"Asc\") >= 0)", TabName_Out4ListRegion4GC, ThisClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "viewVarSet.sort{0}By = Format(\"{{0}} Desc\", strSortByFld);", TabName_Out4ListRegion4GC, ThisClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "viewVarSet.sort{0}By = Format(\"{{0}} Asc\", strSortByFld);", TabName_Out4ListRegion4GC, ThisClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "viewVarSet.sort{0}By = Format(\"{{0}} Asc\", strSortByFld);", TabName_Out4ListRegion4GC, ThisClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

                strCodeForCs.Append("\r\n" + "}");


            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_SortBy()
        {


            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:特别处理列表中某一个字段排序，特别针对扩展字段");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param sortColumnKey:排序字段名");
                strCodeForCs.AppendFormat("\r\n * @param sortDirection:排序方向，升序还是降序");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "  public abstract SortColumn(sortColumnKey: string, sortDirection: string) : void;");

                strCodeForCs.Append("\r\n /** 函数功能:从界面列表中根据某一个字段排序");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param objAnchorElement:带有排序字段的Anchors",
                    ViewMainTabName4GC);

                strCodeForCs.Append("\r\n" + " **/");
                strFuncName = $"SortBy";

                strCodeForCs.Append("\r\n" + "public async SortBy(objAnchorElement:any) {");
                //         strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SortBy.name;",
                //ViewMainTabName4GC, objKeyField.FldName);
                if (strFuncName4BindGv != "")
                {
                    strCodeForCs.Append("\r\n" + " //console.log(\"objAnchorElement(In SetAllCkechedKeysV2):\", objAnchorElement);");
                    strCodeForCs.Append("\r\n" + "let strSortExpress = \"\";");

                    strCodeForCs.Append("\r\n" + "//event = window.event || event;");
                    strCodeForCs.Append("\r\n" + "if (typeof(objAnchorElement) != \"function\")");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.Append("\r\n" + "const thisEventObj: HTMLInputElement = objAnchorElement;");
                    strCodeForCs.Append("\r\n" + "strSortExpress = thisEventObj.getAttribute(\"FldName\") as string;");
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.AppendFormat("\r\n" + "const {{ sortFun, ascOrDesc4SortFun, sortBy }} = GetSortBy(objAnchorElement, viewVarSet.ascOrDesc4SortFun, viewVarSet.sort{1}By, strSortExpress);", ThisClsName, TabName_Out4ListRegion4GC);

                    strCodeForCs.Append("\r\n" + "// 将 sortBy 按空格分成两部分");
                    strCodeForCs.Append("\r\n" + "const [sortColumnKey, sortDirection] = sortBy.split(' ');");
                    strCodeForCs.Append("\r\n" + $"if (Object.prototype.hasOwnProperty.call(cls{TabName_Out4ListRegion4GC}ENEx, sortColumnKey))");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "// 调用 SortColumn 函数");
                    strCodeForCs.Append("\r\n" + "this.SortColumn(sortColumnKey, sortDirection);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.AppendFormat("\r\n" + "viewVarSet.sort{1}By = sortBy;", ThisClsName, TabName_Out4ListRegion4GC);
                    strCodeForCs.AppendFormat("\r\n" + "viewVarSet.ascOrDesc4SortFun = ascOrDesc4SortFun;", ThisClsName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}.sortFunStatic = sortFun;", ThisClsName);

                    strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(this.listPara.listDiv);");
                }
                strCodeForCs.Append("\r\n" + "}");


            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Name = "SortBy",
                DocumentationComment = "从界面列表中根据某一个字段排序"
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_GetCurrPageIndex()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:获取当前页序号");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public GetCurrPageIndex(strDivName4Pager: string): number {");
                strCodeForCs.Append("\r\n" + "const intCurrPageIndex = this.objPager.currPageIndex;");

                strCodeForCs.Append("\r\n" + "if (intCurrPageIndex == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return 1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "if (intCurrPageIndex < 1) return 1;");
                strCodeForCs.Append("\r\n" + "return intCurrPageIndex;");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_ShowEmptyRecNumInfo()
        {
            string strFuncName = "ShowEmptyRecNumInfoByDiv";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /** 函数功能:清空列表的记录,并显示相关信息");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*@param strListDiv");
                strCodeForCs.Append("\r\n" + "* @param strInfo");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "     public ShowEmptyRecNumInfoByDiv(objDiv: HTMLDivElement, strInfo: string) {");

                strCodeForCs.Append("\r\n" + "objDiv.innerHTML = \"\";");
                strCodeForCs.Append("\r\n" + "const objSpan_Info: HTMLSpanElement = document.createElement(\"span\");");
                strCodeForCs.Append("\r\n" + "objSpan_Info.setAttribute(\"class\", \"text-warning font-weight-bold mt-2\");");
                strCodeForCs.Append("\r\n" + "objSpan_Info.innerHTML = strInfo;");
                strCodeForCs.Append("\r\n" + "objDiv.appendChild(objSpan_Info);");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public ",
                isPublic = true,
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_IndexPage()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:在数据 列表中跳转到某一页");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param intPageIndex:页序号",
                        ViewMainTabName4GC);
                strCodeForCs.Append("\r\n" + " **/");
                strFuncName = $"IndexPage";

                strCodeForCs.Append("\r\n" + "public async IndexPage(intPageIndex:number)");
                strCodeForCs.Append("\r\n" + "{");
                //         strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.IndexPage.name;",
                //ViewMainTabName4GC, objKeyField.FldName);
                if (strFuncName4BindGv != "")
                {
                    strCodeForCs.Append("\r\n" + "if (intPageIndex == 0)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "intPageIndex = this.objPager.pageCount;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//console.log(\"跳转到\" + intPageIndex + \"页\");");

                    //strCodeForCs.Append("\r\n" + "this1.CurrPageIndex = intPageIndex;");
                    strCodeForCs.Append("\r\n" + "this.SetCurrPageIndex(intPageIndex);");
                    //arrPropertyDef4GC.Add(new clsPropertyDef4GC
                    //{
                    //    OperateType = "set",
                    //    ControlType = "input",
                    //    CtrlId = "hidCurrPageIndex",
                    //    PropertyName = "CurrPageIndex",
                    //    Comment = "设置当前页序号",
                    //    DataType = "number"

                    //});
                    strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(this.listPara.listDiv);");
                }
                strCodeForCs.Append("\r\n" + "}");


            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public ",
                isPublic = true,
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_BindInDiv()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:预留函数,在某一个层(div)里绑定数据");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strFuncName = $"BindInDiv";

                strCodeForCs.Append("\r\n" + "public async BindInDiv(divBind: HTMLDivElement) {");
                strCodeForCs.Append("\r\n" + "console.log(divBind);");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_SetCurrPageIndex()
        {
            string strFuncName = "SetCurrPageIndex";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:设置当前页序号");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param value:页序号", ViewMainTabName4GC);
                strCodeForCs.AppendFormat("\r\n * @param strDivName4Pager:当前分页所在的层(div)", ViewMainTabName4GC);
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public SetCurrPageIndex(value: number) {");
                strCodeForCs.Append("\r\n" + "       this.objPager.currPageIndex = value;");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public ",
                isPublic = true,
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_PrevPage()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /** 函数功能:在数据列表中跳转到前一页");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strFuncName = $"PrevPage";

                strCodeForCs.Append("\r\n" + "public async PrevPage()");
                strCodeForCs.Append("\r\n" + "{");
                //         strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.PrevPage.name;",
                //ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "const intCurrPageIndex = this.objPager.currPageIndex;");
                strCodeForCs.Append("\r\n" + "const intPageIndex = Number(intCurrPageIndex) - 1;");
                strCodeForCs.Append("\r\n" + "//console.log(\"跳转到\" + intPageIndex + \"页\");");
                strCodeForCs.Append("\r\n" + "this.IndexPage(intPageIndex);");

                strCodeForCs.Append("\r\n" + "}");


            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public ",
                isPublic = true,
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_NextPage()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /** 函数功能:在数据列表中跳转到下一页");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strFuncName = $"NextPage";

                strCodeForCs.Append("\r\n" + "public async NextPage()");
                strCodeForCs.Append("\r\n" + "{");
                //         strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.NextPage.name;",
                //ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "const intCurrPageIndex = this.objPager.currPageIndex;");
                strCodeForCs.Append("\r\n" + "const intPageIndex = Number(intCurrPageIndex) + 1;");
                strCodeForCs.Append("\r\n" + "//console.log(\"跳转到\" + intPageIndex + \"页\");");
                strCodeForCs.Append("\r\n" + "this.IndexPage(intPageIndex);");

                strCodeForCs.Append("\r\n" + "}");


            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public ",
                isPublic = true,
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 功能:单表的查询、修改、插入、删除
        /// </summary>
        /// <returns></returns>
        public string GenFunctionRegion(clsViewRegionEN objDGRegionENEx, clsViewInfoENEx objViewInfoENEx)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //int iDGHeight;      //DataGrid的高度
            //int iDG_Div_Left;


            try
            {
                ///生成插入记录的界面代码;
                //objViewInfoENEx.objViewRegion_List.StyleZindex() = intZIndex + 1;
                //objViewInfoENEx.objViewRegion_List.StyleLeft = (int)intCurrLeft;
                //objViewInfoENEx.objViewRegion_List.StyleTop = (int)intCurrTop;

                //iDGHeight = objViewInfoENEx.objViewRegion_List.Height + 50;


                strCodeForCs.AppendFormat("\r\n" + "<div id = \"divFunction\" class = \"div_Funttion\" runat = \"server\">",
                  ViewMainTabName4GC, intCurrTop);

                //if (objViewInfoENEx.objViewRegion_List.IsCheck() == true || objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                //{
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
                //  ViewMainTabName4GC);
                //strCodeForCs.AppendFormat("\r\n" + "CssClass = \"h6\" Width = \"250px\">{0}列表</asp:label>",
                //  objViewInfoENEx.objInRelaTab.TabCnName);
                //strCodeForCs.Append("\r\n" + "</td>");

                //iDG_Div_Left = 390;//第一个按钮的左为390
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                  || objViewInfoENEx.objViewTypeCodeTab.IsHaveExeAdd)
                {
                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnAddNewRec4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
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
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnDelete4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate == true)
                {

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnUpdate4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
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
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnUpdate4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
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
                    //clsInpu
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnDetail4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
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
                    //List<ASPHtmlButtonEx> arrAspNetButton4AdjustOrderNum = new List<ASPHtmlButtonEx>();
                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnGoTop();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnUpMove();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnDownMove();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnGoBottum();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnReOrder();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    //foreach (ASPHtmlButtonEx objInfor in arrAspNetButton4AdjustOrderNum)
                    //{
                    //    clsASPHtmlButtonBLEx.GeneCode(objInfor, strCodeForCs);

                    //}
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExcelExport == true)
                {
                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnExportExcel4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
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
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnSetExportExcel4User();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
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

                //}
                //生成GridView的代码;


                strCodeForCs.AppendFormat("\r\n" + "</div>");

                intCurrTop += 45;

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string ClsName4WucTabName4Gv()
        {
            string strClsName = string.Format("wuc{0}4Gv", TabName_Out4ListRegion4GC);
            return strClsName;
        }
        private string gfunRadioClick()
        {
            string strFuncName = "";
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
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public ",
                isPublic = true,
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
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

        /// <summary>
        /// 生成查询区域相关代码
        /// </summary>
        /// <returns></returns>
        public string GenQryRegionCode4Table()
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

            strCodeForCs.AppendFormat("\r\n" + "<div id = \"divQuery\" class = \"div_query\"> ",
              ViewMainTabName4GC, intDivHeight);
            strCodeForCs.AppendFormat("\r\n" + "<table class = \"msgtable\" style = \"width: 80%\"> ",
             ViewMainTabName4GC, intDivHeight);

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
                        strCodeForCs.AppendFormat("\r\n" +
                          GenCombineCtlNoPosition(objLabelStyle_Text,
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
            ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnQuery();

            objASPNETHtmlButtonENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs); //;, "btnQuery", "查询", "btnQuery_Click"));
            strCodeForCs.Append("\r\n" + "</td>");

            strCodeForCs.Append("\r\n" + "</tr>");
            strCodeForCs.Append("\r\n" + "</table>");
            strCodeForCs.Append("\r\n" + "</div>");

            intCurrTop += 40;
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成CheckBox控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenCheckBoxNoPosition(clsCheckStyleEN objCheckStyle, string strCheckId, string strCheckText)
        {
            string strFuncName = "";
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
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
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
        public string GenCombineCtlNoPosition(clsLabelStyleEN objLabelStyle, string strLabelId, string strLabelText,
          clsGenCtlStyleEN objGenCtlStyle, string strCtlTypeName, string strCtlId)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            objLabelStyle.StyleZindex = intZIndex + 1;
            objLabelStyle.StyleLeft = (int)intCurrLeft;
            objLabelStyle.StyleTop = (int)intCurrTop;
            ///生成Label的代码;
            ///      
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" style = \"z-index: {1};\" ",
              strLabelId, objLabelStyle.StyleZindex, objLabelStyle.Width, objLabelStyle.Height);
            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"NameLabel\">",
              objLabelStyle.Runat);
            strCodeForCs.AppendFormat("{0}</asp:Label>",
              strLabelText);
            strCodeForCs.Append("\r\n" + "</td>");

            intZIndex += 1;

            objGenCtlStyle.StyleZindex = intZIndex + 1;
            objGenCtlStyle.StyleLeft = (int)intCurrLeft + objLabelStyle.Width + 5;
            //objGenCtlStyle.StyleLeft = (int)intCurrLeft + 5;
            objGenCtlStyle.StyleTop = (int)intCurrTop;
            ///生成右边控件的代码;
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" style = \"z-index: {2}; \" ",
              strCtlTypeName, strCtlId, objGenCtlStyle.StyleZindex, objGenCtlStyle.Width, objGenCtlStyle.Height);

            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"TextBox_Defa\">",
              objGenCtlStyle.Runat);
            strCodeForCs.AppendFormat("\r\n" + "</asp:{0}>",
              strCtlTypeName);
            strCodeForCs.Append("\r\n" + "</td>");

            intZIndex += 1;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成Button控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenButtonNoPosition(clsButtonStyleEN objButtonStyle, string strButtonId, string strButtonText, string strOnClick)
        {
            string strFuncName = "";
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
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 定义用于编辑的层Div,该层可以被弹出
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public string Gen_WApi_Ts_DefDiv4EditRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n" + " <div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">",
                TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + " <div class=\"modal-dialog modal-dialog-centered modal-dialog-scrollable\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-content\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-header\">");
            strCodeForCs.AppendFormat("\r\n" + " <h4 class=\"modal-title\" id=\"lblDialogTitle_{0}\">模态框（Modal）标题</h4>", TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + " <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\">&times;</button>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-body\">");
            strCodeForCs.Append("\r\n" + " <table style=\"width: 100%;\">");

            foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {
                ///如果该字段不是标识递增型就生成控件,否则就不生成;
                if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                strCodeForCs.AppendFormat("\r\n" + "<tr>");
                //strCodeForCs.AppendFormat("\r\n" + "<td>");
                ///插入验证控件代码;
                switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                {
                    case "bool":
                        strCodeForCs.AppendFormat("\r\n" + "<td colspan='2'>");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox id = \"chk{0}\" runat = \"server\" Text = \"{1}\" CssClass = \"Check_Defa\"></asp:CheckBox>",
                          objEditRegionFldsEx.FldName,
                          objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        //strCodeForCs.AppendFormat("\r\n" + "<td>");
                        //strCodeForCs.AppendFormat("\r\n" + "</td>");
                        break;
                    case "int":
                    case "short":
                    case "long":
                    case "DateTime":
                    case "double":
                    case "float":
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"NameTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\" CssClass = \"NameControl\">{1}</asp:Label>",
                          "lbl" + objEditRegionFldsEx.FldName,
                          objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"ValueTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:TextBox id = \"txt{0}\" runat = \"server\" CssClass = \"ValueControl\"></asp:TextBox>",
                          objEditRegionFldsEx.FldName,
                          objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"NameTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\" CssClass = \"NameControl\">{1}</asp:Label>",
                          "lbl" + objEditRegionFldsEx.FldName,
                          objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"ValueTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" runat = \"server\" CssClass = \"ValueControl\"></asp:{0}>",
                          objEditRegionFldsEx.objCtlType.CtlTypeName,
                            objEditRegionFldsEx.CtrlId,
                          objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        break;
                }
                //                strCodeForCs.AppendFormat("\r\n" + "</td>");
                strCodeForCs.AppendFormat("\r\n" + "<td></td>");
                strCodeForCs.AppendFormat("\r\n" + "</tr>");
                //intZIndex += 1;
                //intCurrTop += 25;

            }

            //strCodeForCs.Append("\r\n" + " <tr>");
            //strCodeForCs.Append("\r\n" + " <td>1&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " <td>2&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " <td>3&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " </tr>");
            //strCodeForCs.Append("\r\n" + " <tr>");
            //strCodeForCs.Append("\r\n" + " <td>4&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " <td>5&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " <td>6&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " </tr>");
            strCodeForCs.Append("\r\n" + " </table>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-footer\">");
            strCodeForCs.Append("\r\n" + " <button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">关闭</button>");
            strCodeForCs.AppendFormat("\r\n" + " <button type=\"button\" class=\"btn btn-primary\" onclick=\"Submit_{0}()\">提交更改</button>", TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal-content -->");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal -->");
            strCodeForCs.Append("\r\n" + " </div>");

            return strCodeForCs.ToString();
        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(WA_ViewScriptCS_TS4TypeScript));
            //string strFuncName = objvFunction4GeneCodeEN.FuncName;
            //try
            //{
            //    string strCode = "";
            //    Type t = typeof(WA_ViewScriptCS_TS4TypeScript);
            //    MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

            //    if (mt == null)
            //    {
            //        string strMsg = string.Format("在类中没有相应的函数:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
            //        throw new Exception(strMsg);
            //    }
            //    else
            //    {
            //        //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
            //        if (mt.GetParameters().Length == 0)
            //        {
            //            strCode = (string)mt.Invoke(this, null);
            //        }
            //        else if (mt.GetParameters().Length == 1)
            //        {
            //            strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
            //        }
            //        //Console.WriteLine(str);
            //    }

            //    return strCode;
            //}
            //catch (Exception objException)
            //{
            //    StringBuilder sbMessage = new StringBuilder();
            //    string strMsg = "";
            //    if (objException.InnerException != null && string.IsNullOrEmpty(objException.InnerException.Message) == false)
            //    {
            //        strMsg = objException.InnerException.Message;
            //    }
            //    else
            //    {
            //        strMsg = objException.Message;
            //    }
            //    sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", strFuncName, strMsg);
            //    throw new Exception(sbMessage.ToString());
            //}
        }
        public override void GetClsName()
        {
            //this.ClsName = string.Format("WApi{0}_QUDI_TS", ViewMainTabName4GC);
            //ThisClsName = this.ClsName;

            this.ClsName = objViewInfoENEx.ViewName;
            objViewInfoENEx.ClsName = this.ClsName;
        }

        public string Gen_WApi_Ts_btnCopyRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (strFuncName4BindGv == "") return "";
            if (objPrjTabEx_ListRegion == null) return "";
            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                return "//多关键字,不支持复制功能!";
            }
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 添加新记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "public async btnCopyRecord_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnCopyRecord_Click.name;",
        ViewMainTabName4GC, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
            ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(`请选择需要克隆的${this.thisTabName}记录!`);");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "await this.CopyRecord(arrKeyIds);");

            strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `复制记录不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnSetFldValue_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (strFuncName4BindGv == "") return "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {

                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldIdCache(objInFor.ReleFldId, objInFor.PrjId());
                    strFuncName = string.Format("{0}", objInFor.ButtonName.Substring(3));
                    strCodeForCs.AppendFormat("\r\n /** 设置字段值-{0}", objFieldTabEN.FldName);
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n **/");

                    strCodeForCs.AppendFormat("\r\n" + "public async {0}_Click() {{", objInFor.ButtonName);
                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}_Click.name;", objInFor.ButtonName);
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                    ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                    strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + $"alert(`请选择需要设置{objInFor.ObjFieldTabENEx.Caption}的${{this.thisTabName}}记录!`);");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");

                    clsViewFeatureFldsENEx objViewFeatureFlds = null;
                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrViewFeatureFlds.Where(x =>
                               x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("功能：设置字段值的给值方式是给定值,但缺少相应的界面功能字段,请维护后再生成代码");
                        }
                        objViewFeatureFlds = arrViewFeatureFlds[0];

                    }
                    if (objInFor.FeatureId == enumPrjFeature.SetFieldValue_0148
        && objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrViewFeatureFlds.Where(x =>
                        x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("功能：设置字段值的给值方式是给定值,但缺少相应的界面功能字段,请维护后再生成代码");
                        }

                        objViewFeatureFlds = arrViewFeatureFlds[0];
                        ASPControlEx objASPControlENEx = clsASPControlBLEx.GetControl_Asp(objViewFeatureFlds);

                        string strCtrlId = objASPControlENEx.CtrlId.Replace("SetFldValue_SetFldValue", "SetFldValue");
                        switch (objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType)
                        {
                            case "Number":
                                strCodeForCs.Append("\r\n" + $"const str{objViewFeatureFlds.ObjFieldTabENEx.FldName} = GetSelectValueInDivObj(divVarSet.refDivFunction, \"{strCtrlId}\");");
                                ImportClass objImportClass2 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectValueInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                            objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return;");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "//console.log('str{0}=' + str{0});", objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "const {0} = Number(str{1});",
                                    objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName); break;
                            case "boolean":
                                if (objViewFeatureFlds.CtlTypeId == enumCtlType.CheckBox_02)
                                {
                                    strCodeForCs.Append("\r\n" + $"const {objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName} = GetCheckBoxValueInDivObj(divVarSet.refDivFunction, '{strCtrlId}');");
                                    ImportClass objImportClass3 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckBoxValueInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                    CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);

                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "const {0}: boolean = $(\"#{1}\").prop(\"checked\");",
                      objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                      strCtrlId);
                                }
                                strCodeForCs.AppendFormat("\r\n" + "//console.log('{0}=' + {0});", objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                                break;
                            default:
                                strCodeForCs.Append("\r\n" + $"const str{objViewFeatureFlds.ObjFieldTabENEx.FldName} = GetSelectValueInDivObj(divVarSet.refDivFunction, \"{strCtrlId}\");");
                                ImportClass objImportClass4 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectValueInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);

                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                            objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return;");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "//console.log('str{0}=' + str{0});", objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "//console.log('arrKeyIds=');");
                        strCodeForCs.Append("\r\n" + "//console.log(arrKeyIds);");
                        if (objViewFeatureFlds.ObjFieldTabENEx.IsNumberType())
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {0} = Number(str{2});", objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                                objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                                objViewFeatureFlds.ObjFieldTabENEx.FldName);
                        }
                        strCodeForCs.AppendFormat("\r\n" + "await this.{0}(arrKeyIds, {1});", strFuncName, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "//console.log('arrKeyIds=');");
                        strCodeForCs.Append("\r\n" + "//console.log(arrKeyIds);");
                        strCodeForCs.AppendFormat("\r\n" + "await this.{0}(arrKeyIds);", strFuncName);
                    }

                    strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch(e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = `设置记录不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");

                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");

                    strCodeForCs.Append("\r\n" + "alert(strMsg);");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                }

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }



        public string Gen_WApi_Ts_SetFieldValue()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {
                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldIdCache(objInFor.ReleFldId, objInFor.PrjId());
                    strFuncName = string.Format("{0}", objInFor.ButtonName.Substring(3));

                    strCodeForCs.AppendFormat("\r\n /** 设置字段值-{0}", objFieldTabEN.FldName);
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n **/");

                    string strKeys = "";
                    ArrayList arrKeysLst = new ArrayList();
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        arrKeysLst.Add("\"" + objPrjTabFldENEx.FldName + "\"");
                    }
                    //objViewInfoENEx.arrKeyPrjTabFldSet.Count.objMainPrjTab.
                    strKeys = clsArray.Join(arrKeysLst, ",");
                    //List<string> lstExam1TypeId = GetAllCheckedKeysFromGv();
                    //if (lstExam1TypeId == null) return;


                    clsViewFeatureFldsENEx objViewFeatureFlds = null;


                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrViewFeatureFlds.Where(x =>
                               x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("功能：设置字段值的给值方式是给定值,但缺少相应的界面功能字段,请维护后再生成代码");
                        }
                        objViewFeatureFlds = arrViewFeatureFlds[0];

                        strCodeForCs.AppendFormat("\r\n" + "public async {0}(arr{1}: Array<string>, {3}: {2})",
                                strFuncName,
                                objKeyField.FldName,
                                objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}.name;", strFuncName);
                        //ASPDropDownListEx objASPDropDownListENEx = clsASPDropDownListBLEx.GetDropDownLst_Asp(objViewFeatureFlds);
                        switch (objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType)
                        {
                            case "string":

                                strCodeForCs.AppendFormat("\r\n" + "if ({0} == null || {0} == \"\" )",
                                            objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "number":

                                strCodeForCs.AppendFormat("\r\n" + "if ({0} == null || {0} == 0 )",
                                            objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public async {0}(arr{1}: Array<string>)",
                                strFuncName, objKeyField.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}.name;", strFuncName);
                    }

                    strCodeForCs.AppendFormat("\r\n" + "if (arr{0}.length == 0)", objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = \"没有选择记录,不能设置字段值!\";");
                    strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                    strCodeForCs.Append("\r\n" + "//console.trace();");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.Append("\r\n" + $"const arr{TabName_In4Edit4GC}ObjLst = await {thisWA_F_InList(WA_F.GetObjLstByKeyLstAsync)}(arr{objKeyField.FldName});");

                    strCodeForCs.Append("\r\n" + "let intCount = 0;");
                    strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ObjLst)",
                        TabName_In4Edit4GC);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = new cls{0}EN();", TabName_In4Edit4GC);
                    strCodeForCs.AppendFormat("\r\n" + "ObjectAssign(obj{0}EN, objInFor);", TabName_In4Edit4GC);
                    ImportClass objImportClass = AddImportClass(objViewInfoENEx.InRelaTabId, "/PubFun/clsCommFunc4Web.js", "ObjectAssign", enumImportObjType.CustomFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                    strCodeForCs.Append("\r\n" + $"obj{TabName_In4Edit4GC}EN.Set{objKeyField.FldName}(objInFor.{objKeyField.PropertyName(this.IsFstLcase)});");

                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        if (objViewFeatureFlds == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(\"这里不正确,值为空!\");",
                                                      TabName_In4Edit4GC, objFieldTabEN.FldName);
                        }
                        else
                        {

                            if (clsPrjTabFldBLEx.IsForExtendClass(TabId_In4Edit, objInFor.ReleFldId, objInFor.PrjId) == true)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "//obj{0}EN.Set{1}({2});",
                                                       TabName_In4Edit4GC, objFieldTabEN.FldName,
                                                       objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}({2});",
                                                          TabName_In4Edit4GC, objFieldTabEN.FldName,
                                                          objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                            }
                        }
                    }
                    else
                    {

                        clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTabEN.DataTypeId);
                        if (clsDataTypeAbbrBLEx.IsNumberType(objDataTypeAbbrEN) == true)
                        {
                            //strCodeForCs.Append("\r\n" + "objInFor.ExamTypeName = \"C_\" + objInFor.ExamTypeName;");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}({2});",
                                  TabName_In4Edit4GC, objFieldTabEN.FldName, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                        }
                        else
                        {
                            if (objDataTypeAbbrEN.CsType == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(TransToBool(\"{2}\"));",
                                                        TabName_In4Edit4GC, objFieldTabEN.FldName, objInFor.DefaultValue);
                                ImportClass objImportClass4 = AddImportClass("", "/PubFun/clsString.js", "TransToBool", enumImportObjType.CustomFunc, this.strBaseUrl);

                                CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(\"{2}\");",
                                    TabName_In4Edit4GC, objFieldTabEN.FldName, objInFor.DefaultValue);
                            }
                        }
                    }
                    strCodeForCs.Append("\r\n" + "let returnBool = false;");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "    obj{0}EN.sfUpdFldSetStr = obj{0}EN.updFldString;//设置哪些字段被修改(脏字段)", TabName_In4Edit4GC);

                    strCodeForCs.Append("\r\n" + $"returnBool = await {thisWA_F_InEdit(WA_F.UpdateRecordAsync)}(obj{TabName_In4Edit4GC}EN);");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (e)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.Append("\r\n" + "const strMsg = `设置记录不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                    strCodeForCs.Append("\r\n" + "}");


                    strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                    strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.Append("\r\n" + "const strInfo = Format(\"设置记录成功!\");");
                    strCodeForCs.Append("\r\n" + "intCount++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strInfo = Format(\"设置记录不成功!\");");

                    strCodeForCs.Append("\r\n" + "//显示信息框");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "const strInfo = Format(\"共设置了{0}条记录!\", intCount);");

                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "//console.log('完成!');");

                    strCodeForCs.Append("\r\n" + "if (intCount > 0)");
                    strCodeForCs.Append("\r\n" + "{");
                    Gene_ReFreshCache(strCodeForCs);
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = `设置记录不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                    strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                    strCodeForCs.Append("\r\n" + "//console.trace();");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");

                }

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnGoTop_Click()
        {
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";

            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /** 置顶");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnGoTop_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnGoTop_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        //strCodeForCs.AppendFormat("\r\n" + " const str{0}:string =$('#{1}').val();",
                        //  objInFor.FldName, objInFor.CtrlId);
                        if (objInFor.CtlTypeId == enumCtlType.ViewVariable_38)
                        {
                            string strVarName = "";
                            var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                            if (objVar != null)
                            {
                                strVarName = objVar.GetVarName4View();
                            }
                            strCodeForCs.Append("\r\n" + $" const {objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().DataTypeAbbr}{objInFor.FldName} = {strVarName}.value;");

                        }
                        else
                        {
                            string strFldName_Classify = objInFor.FldName;
                            string strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldName(objViewInfoENEx.ViewId, strFldName_Classify, this.PrjId);
                            clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName_Classify, objViewInfoENEx.ViewName);
                            //strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={this.ClsName}.{objInFor.CtrlId.Substring(3)};");
                            strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={strViewVarName}.value;");
                            ImportClass objImportClass6 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", strViewVarName, enumImportObjType.CustomFunc, "");

                            CodeElement objCodeElement_Import6 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass6);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import6);

                            if (objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " const {1} = Number(str{0});",
                                            objInFor.FldName, objInFor.PrivFuncName);
                            }

                            arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            {
                                OperateType = "get",
                                ControlType = objInFor.CtlTypeName,
                                CtrlId = objInFor.CtrlId,
                                PropertyName = objInFor.CtrlId.Substring(3),
                                Comment = string.Format("{0} (Used In {1})", objInFor.FldName,
                                            "btnGoTop_Click()"),
                                DataType = "string",
                                ParentDivName = $"divVarSet.refDivFunction"
                            });
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要置顶的${this.thisTabName}记录!`);");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                           objInFor.FldName.ToLower(),
                           objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.GoTopAsync)}(objOrderByData);");

                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.GoTopAsync)}(objOrderByData);");

                }
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `置顶出错。错误:${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.AppendFormat("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

                //strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                //    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                //    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divVarSet.refDivList, 'divDataLst');");

                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyIdInDiv(divDataLst, e));");
                //strCodeForCs.Append("\r\n" + "}");
                ImportClass objImportClass5 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetCheckedItem4KeyIdInDiv", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import5 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass5);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import5);

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnUpMove_Click()
        {
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";


                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 上移");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnUpMove_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnUpMove_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        //strCodeForCs.AppendFormat("\r\n" + " const str{0}:string =$('#{1}').val();",
                        //    objInFor.FldName, objInFor.CtrlId);
                        if (objInFor.CtlTypeId == enumCtlType.ViewVariable_38)
                        {
                            string strVarName = "";
                            var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                            if (objVar != null)
                            {
                                strVarName = objVar.GetVarName4View();
                            }
                            strCodeForCs.Append("\r\n" + $" const {objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().DataTypeAbbr}{objInFor.FldName} = {strVarName}.value;");
                        }
                        else
                        {
                            string strFldName_Classify = objInFor.FldName;
                            string strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldName(objViewInfoENEx.ViewId, strFldName_Classify, this.PrjId);
                            clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName_Classify, objViewInfoENEx.ViewName);
                            //strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={this.ClsName}.{objInFor.CtrlId.Substring(3)};");
                            strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={strViewVarName}.value;");
                            ImportClass objImportClass6 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", strViewVarName, enumImportObjType.CustomFunc, "");

                            CodeElement objCodeElement_Import6 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass6);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import6);

                            if (objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " const {1} = Number(str{0});",
                                            objInFor.FldName, objInFor.PrivFuncName);
                            }

                            arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            {
                                OperateType = "get",
                                ControlType = objInFor.CtlTypeName,
                                CtrlId = objInFor.CtrlId,
                                PropertyName = objInFor.CtrlId.Substring(3),
                                Comment = string.Format("{0} (Used In {1})", objInFor.FldName,
                                            "btnUpMove_Click()"),
                                DataType = "string",
                                ParentDivName = $"divVarSet.refDivFunction"
                            });
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要上移的${this.thisTabName}记录!`);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                //                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName.ToLower(),
                            objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.UpMoveAsync)}(objOrderByData);");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.UpMoveAsync)}(objOrderByData);");

                }
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `上移记录出错。错误:${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

                strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divVarSet.refDivList, 'divDataLst');");

                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyIdInDiv(divDataLst, e));");
                ImportClass objImportClass2 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetCheckedItem4KeyIdInDiv", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

                strCodeForCs.Append("\r\n" + "}");


            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_MoveRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";



                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 移动记录,包括上移和下移");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async MoveRecord(strDirect: string)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.MoveRecord.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " const str{0} =$('#{1}').val();",
                            objInFor.FldName, objInFor.CtrlId);
                    }
                }
                strCodeForCs.Append("\r\n" + "const strKeyId = GetFirstCheckedKeyId(objPage.divName4List);");
                strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要移动(${strDirect})的${this.thisTabName}记录!`);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                //                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "await {0}AdjustOrderNum(strDirect, {2}, strKeyId);",
                     ViewMainTabName4GC,
                     objAdjustOrderNum.VarLst,
                     objKeyField.PrivFuncName);
                    ImportClass objImportClass = AddImportClass(objViewInfoENEx.MainTabId, ViewMainTabName4GC, string.Format("AdjustOrderNum", objKeyField.FldName), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "await {0}AdjustOrderNum(strDirect, strKeyId);",
                     ViewMainTabName4GC,
                                          objKeyField.PrivFuncName);
                    ImportClass objImportClass = AddImportClass(objViewInfoENEx.MainTabId, ViewMainTabName4GC, string.Format("AdjustOrderNum", objKeyField.FldName), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `移动(${strDirect})记录出错。错误:${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

                strCodeForCs.AppendFormat("\r\n" + "//{0}1.SetCheckedItemForGv({1});",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), objKeyField.PrivFuncName);

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnDownMove_Click()
        {
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 下移");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnDownMove_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDownMove_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        if (objInFor.CtlTypeId == enumCtlType.ViewVariable_38)
                        {
                            string strVarName = "";
                            var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                            if (objVar != null)
                            {
                                strVarName = objVar.GetVarName4View();
                            }
                            strCodeForCs.Append("\r\n" + $" const {objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().DataTypeAbbr}{objInFor.FldName} = {strVarName}.value;");
                        }
                        else
                        {
                            string strFldName_Classify = objInFor.FldName;
                            string strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldName(objViewInfoENEx.ViewId, strFldName_Classify, this.PrjId);
                            clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName_Classify, objViewInfoENEx.ViewName);
                            //strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={this.ClsName}.{objInFor.CtrlId.Substring(3)};");
                            strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={strViewVarName}.value;");
                            ImportClass objImportClass7 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", strViewVarName, enumImportObjType.CustomFunc, "");

                            CodeElement objCodeElement_Import7 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass7);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import7);

                            if (objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " const {1} = Number(str{0});",
                                            objInFor.FldName, objInFor.PrivFuncName);
                            }

                            arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            {
                                OperateType = "get",
                                ControlType = objInFor.CtlTypeName,
                                CtrlId = objInFor.CtrlId,
                                PropertyName = objInFor.CtrlId.Substring(3),
                                Comment = string.Format("{0} (Used In {1})", objInFor.FldName,
                                            "btnDownMove_Click()"),
                                DataType = "string",
                                ParentDivName = $"divVarSet.refDivFunction"
                            });
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                strCodeForCs.Append("\r\n" + "    if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要下移的${this.thisTabName}记录!`);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                //                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName.ToLower(),
                            objInFor.PrivFuncName);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.DownMoveAsync)}(objOrderByData);");

                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.DownMoveAsync)}(objOrderByData);");

                }
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `下移记录出错。错误:${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

                strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divVarSet.refDivList, 'divDataLst');");

                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyIdInDiv(divDataLst, e));");
                ImportClass objImportClass8 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetCheckedItem4KeyIdInDiv", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import8 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass8);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import8);

                strCodeForCs.Append("\r\n" + "}");


            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        protected bool Gene_ReFreshCache(StringBuilder sbCode, bool bolIsMultiKey = false)
        {
            //if (PrjTabEx_ListRegion.IsUseStorageCache_TS()== false)
            //{
            //    return;
            //}
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";

            if (PrjTabEx_ListRegion.IsUseStoreCache_TS() == true)
            {

                sbCode.Append("\r\n" + $"const {clsString.FirstLcaseS(TabName_In4Edit4GC)}Store = use{TabName_In4Edit4GC}Store();");
                if (PrjTabEx_EditRegion.KeyFldNum() == 1 && bolIsMultiKey)
                {
                    sbCode.Append("\r\n" + $"arr{PrjTabEx_EditRegion.KeyFldName()}.forEach(async ({PrjTabEx_EditRegion.KeyPrivFuncFldNameLstStr}) => {{");
                        sbCode.Append("\r\n" + $"await {clsString.FirstLcaseS(TabName_In4Edit4GC)}Store.delObj({PrjTabEx_EditRegion.KeyPrivFuncFldNameLstStr});");
                           sbCode.Append("\r\n" + "});");
                }
                else
                {
                    sbCode.Append("\r\n" + $"await {clsString.FirstLcaseS(TabName_In4Edit4GC)}Store.delObj({PrjTabEx_EditRegion.KeyPrivFuncFldNameLstStr});");
                }
                ImportClass objImportClass = AddImportClass(TabId_In4Edit, clsString.FirstLcaseS(TabName_In4Edit4GC), $"use{TabName_In4Edit4GC}Store", enumImportObjType.StoreModule, $"@/store/modules{strIsShare}");

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            }
            else if (PrjTabEx_ListRegion.IsUseStorageCache_TS() == true)
            {
                if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache();", TabName_In4Edit4GC);
                }
                else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache({1}.value);", ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                    ImportClass objImportClass2 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName, enumImportObjType.CustomFunc, "");

                    CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

                }
                else
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache({1}, {2});", ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                    ImportClass objImportClass3 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName, enumImportObjType.CustomFunc, "");

                    CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);

                    ImportClass objImportClass4 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", thisCacheClassify4View.ViewVarName2, enumImportObjType.CustomFunc, "");

                    CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);

                }
                ImportClass objImportClass = AddImportClass(objViewInfoENEx.MainTabId, ViewMainTabName4GC, string.Format("ReFreshCache", objKeyField.FldName), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            }
            else
            {
                if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache();", TabName_In4Edit4GC);
                }
                else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache({1}.value);", ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                }
                else
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache({1}.value, {2}.value);", ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                }
                return false;
            }
            return true;
        }

        public string Gen_WApi_Ts_PreCheck4Order()
        {
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "PreCheck4Order";
            try
            {
                clsFeatureRegionFldsENEx objFeatureRegionFlds_GoTop = objViewInfoENEx.arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.AdjustOrderNum_1196);
                if (objFeatureRegionFlds_GoTop == null) return "";
                //clsViewFeatureFldsENEx objField_OrderNum = objViewInfoENEx.arrViewFeatureFlds.Find(x => x.FieldTypeId == enumFieldType.OrderNumField_09 && x.ViewFeatureId == objFeatureRegionFlds_GoTop.ViewFeatureId);
                IEnumerable<clsViewFeatureFldsENEx> arrFieldLst_Classify = objViewInfoENEx.arrViewFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ClassificationField_10 && x.ViewFeatureId == objFeatureRegionFlds_GoTop.ViewFeatureId);

                List<clsPrjTabFldENEx> arrFldSet = clsPrjTabFldBLEx.GetObjExLst(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);
               
                if (string.IsNullOrEmpty(objFeatureRegionFlds_GoTop.ReleFldId))
                {
                    strCodeForCs.AppendFormat("\r\n" + "//表：[{0}]的序号字段为空,不能生成【预检函数(PreCheck4Order)】;",
                        ViewMainTabName4GC);
                    return strCodeForCs.ToString();

                }
                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 移动记录序号时的预检查函数");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public PreCheck4Order(): boolean");
                strCodeForCs.Append("\r\n" + "{");

                if (arrFieldLst_Classify.Count() > 0)
                {
                    //                 strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.PreCheck4Order.name;",
                    //ViewMainTabName4GC, objKeyField.FldName);
                    foreach (clsViewFeatureFldsENEx objInFor in arrFieldLst_Classify)
                    {
                        // strCodeForCs.AppendFormat("\r\n" + "// const str{0}:string =$('#{1}').val();",
                        //objInFor.FldName, objInFor.CtrlId);
                        if (objInFor.CtlTypeId == enumCtlType.ViewVariable_38)
                        {
                            string strVarName = "";
                            var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                            if (objVar != null)
                            {
                                strVarName = objVar.GetVarName4View();
                            }
                            strCodeForCs.Append("\r\n" + $" const {objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().DataTypeAbbr}{objInFor.FldName} = {strVarName}.value;");

                            if (objInFor.ObjFieldTabENEx.IsNumberType())
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)",
                             objInFor.ObjFieldTabENEx.PrivFuncName1());
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                objInFor.FldName);
                            }
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"请输入{0}!\");", objInFor.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                            strCodeForCs.Append("\r\n" + "//console.trace();");
                            strCodeForCs.Append("\r\n" + "alert(strMsg);");

                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                        }
                        else
                        {
                            string strFldName_Classify = objInFor.FldName;
                            string strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldName(objViewInfoENEx.ViewId, strFldName_Classify, this.PrjId);
                            clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName_Classify, objViewInfoENEx.ViewName);
                            //strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={this.ClsName}.{objInFor.CtrlId.Substring(3)};");
                            strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={strViewVarName}.value;");
                            ImportClass objImportClass = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", strViewVarName, enumImportObjType.CustomFunc, "");

                            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                            arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            {
                                OperateType = "get",
                                ControlType = objInFor.CtlTypeName,
                                CtrlId = objInFor.CtrlId,
                                PropertyName = objInFor.CtrlId.Substring(3),
                                Comment = string.Format("{0} (Used In {1})", objInFor.FldName, "PreCheck4Order()"),
                                DataType = "string"
                            });
                            if (objInFor.ObjFieldTabENEx.IsNumberType())
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == 0)",
                            objInFor.FldName);
                            }
                            else

                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                            objInFor.FldName);
                            }
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"请输入{0}!\");", objInFor.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                            strCodeForCs.Append("\r\n" + "//console.trace();");
                            strCodeForCs.Append("\r\n" + "alert(strMsg);");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                        }

                    }
                }
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public ",
                isPublic = true,
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnGoBottum_Click()
        {
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";




                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 置底");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnGoBottum_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnGoBottum_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        if (objInFor.CtlTypeId == enumCtlType.ViewVariable_38)
                        {
                            string strVarName = "";
                            var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                            if (objVar != null)
                            {
                                strVarName = objVar.GetVarName4View();
                            }
                            strCodeForCs.Append("\r\n" + $" const {objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().DataTypeAbbr}{objInFor.FldName} = {strVarName}.value;");

                        }
                        else
                        {
                            string strFldName_Classify = objInFor.FldName;
                            string strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldName(objViewInfoENEx.ViewId, strFldName_Classify, this.PrjId);
                            clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName_Classify, objViewInfoENEx.ViewName);
                            //strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={this.ClsName}.{objInFor.CtrlId.Substring(3)};");
                            strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={strViewVarName}.value;");
                            ImportClass objImportClass3 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", strViewVarName, enumImportObjType.CustomFunc, "");

                            CodeElement objCodeElement_Import3 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass3);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import3);

                            if (objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " const {1} = Number(str{0});",
                                            objInFor.FldName, objInFor.PrivFuncName);
                            }

                            arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            {
                                OperateType = "get",
                                ControlType = objInFor.CtlTypeName,
                                CtrlId = objInFor.CtrlId,
                                PropertyName = objInFor.CtrlId.Substring(3),
                                Comment = string.Format("{0} (Used In {1})", objInFor.FldName, "btnGoBottum_Click()"),
                                DataType = "string",
                                ParentDivName = $"divVarSet.refDivFunction"
                            });
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要置底的${this.thisTabName}记录!`);");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName.ToLower(),
                            objInFor.PrivFuncName);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.GoBottomAsync)}(objOrderByData);");

                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.GoBottomAsync)}(objOrderByData);");

                }
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `置底出错。错误:${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

                //strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                //        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                //        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                //strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divVarSet.refDivList, 'divDataLst');");

                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyIdInDiv(divDataLst, e));");
                ImportClass objImportClass2 = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "SetCheckedItem4KeyIdInDiv", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

                //strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_btnReOrder_Click()
        {
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum == null || objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 重序");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnReOrder_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnReOrder_Click.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        if (objInFor.CtlTypeId == enumCtlType.ViewVariable_38)
                        {
                            string strVarName = "";
                            var objVar = clsGCVariableBL.GetObjByVarIdCache(objInFor.VarId);
                            if (objVar != null)
                            {
                                strVarName = objVar.GetVarName4View();
                            }
                            //               sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = {2}.{3};",
                            //ViewMainTabName4GC,
                            //objEditRegionFldsEx.PropertyName(this.IsFstLcase),
                            //ThisClsName, strVarName);


                            strCodeForCs.Append("\r\n" + $" const {objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().DataTypeAbbr}{objInFor.FldName} = {strVarName}.value;");

                        }
                        else
                        {
                            string strFldName_Classify = objInFor.FldName;
                            string strViewVarName = clsViewIdGCVariableRelaBLEx.GetViewVarNameByFldName(objViewInfoENEx.ViewId, strFldName_Classify, this.PrjId);
                            clsViewIdGCVariableRelaBLEx.CheckViewVarName(strViewVarName, strFldName_Classify, objViewInfoENEx.ViewName);
                            //strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={this.ClsName}.{objInFor.CtrlId.Substring(3)};");
                            strCodeForCs.Append("\r\n" + $"const str{objInFor.FldName} ={strViewVarName}.value;");
                            ImportClass objImportClass2 = AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{this.GetVueShareClsName()}", strViewVarName, enumImportObjType.CustomFunc, "");

                            CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

                            if (objInFor.ObjFieldTabENEx.ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " const {1} = Number(str{0});",
                                            objInFor.FldName, objInFor.PrivFuncName);
                            }

                            arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            {
                                OperateType = "get",
                                ControlType = objInFor.CtlTypeName,
                                CtrlId = objInFor.CtrlId,
                                PropertyName = objInFor.CtrlId.Substring(3),
                                Comment = string.Format("{0} (Used In {1})", objInFor.FldName, "btnReOrder_Click()"),
                                DataType = "string",
                                IsStatic = false,
                                ParentDivName = $"divVarSet.refDivFunction"
                            });
                            arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            {
                                OperateType = "set",
                                ControlType = objInFor.CtlTypeName,
                                CtrlId = objInFor.CtrlId,
                                PropertyName = objInFor.CtrlId.Substring(3),
                                Comment = string.Format("{0} (Used In {1})", objInFor.FldName, "btnReOrder_Click()"),
                                DataType = "string",
                                IsStatic = false,
                                ParentDivName = $"divVarSet.refDivFunction"
                            });
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData: clsOrderByData = new clsOrderByData();");
                ImportClass objImportClass = AddImportClass("", "/PubFun/clsOrderByData.js", "clsOrderByData", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                         clsString.FstLcaseS(objInFor.FldName),
                            objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");

                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.ReOrderAsync)}(objOrderByData);");

                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"await {thisWA_F_InView(WA_F.ReOrderAsync)}(objOrderByData);");

                }
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `重序出错。错误:${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                strCodeForCs.Append("\r\n" + "//console.trace();");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_Code4QueryRegion()
        {
            string strTemp = "";
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                            objViewInfoENEx.CodeTypeId,
                            enumRegionType.QueryRegion_0001)
                                   .OrderBy(x => x.OrderNum);
            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
            {
                string strFuncName = objvFunction4GeneCodeEN.FuncName;
                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    continue;
                }
                try
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append(strTemp);
                    }
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }

            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_Code4FeatureRegion()
        {
            string strTemp = "";
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                     enumRegionType.FeatureRegion_0008)
                                   .OrderBy(x => x.OrderNum);
            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
            {
                string strFuncName = objvFunction4GeneCodeEN.FuncName;
                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    continue;
                }
                try
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append(strTemp);
                    }
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }

            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_Code4ListRegion()
        {
            string strTemp = "";
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                     enumRegionType.ListRegion_0002)
                                   .OrderBy(x => x.OrderNum);
            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
            {
                string strFuncName = objvFunction4GeneCodeEN.FuncName;
                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    continue;
                }
                try
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append(strTemp);
                    }
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }

            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_Code4DetailRegion()
        {
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp = "";
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                     enumRegionType.DetailRegion_0006)
                                   .OrderBy(x => x.OrderNum);
            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
            {
                string strFuncName = objvFunction4GeneCodeEN.FuncName;
                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    continue;
                }
                try
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append(strTemp);
                    }
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }

            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();

        }



        public string Gen_WApi_Ts_Code4EditRegion()
        {
            string strTemp = "";
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                     enumRegionType.EditRegion_0003)
                                   .OrderBy(x => x.OrderNum);
            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
            {
                string strFuncName = objvFunction4GeneCodeEN.FuncName;
                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    continue;
                }
                try
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append(strTemp);
                    }
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }

            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();

        }
        public string Gen_WApi_Ts_Code4ExcelExportRegion()
        {
            string strTemp = "";
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                     enumRegionType.ExcelExportRegion_0007)
                                   .OrderBy(x => x.OrderNum);
            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
            {
                string strFuncName = objvFunction4GeneCodeEN.FuncName;
                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    continue;
                }
                try
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append(strTemp);
                    }
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }

            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();

        }
        public string Gen_WApi_Ts_AddDPV_Edit(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            string strClassName = string.Format("WA_{0}_Edit", ViewMainTabName4GC);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClsName) == false)
            {
                strClassName = objViewRegionENEx.ClsName;
            }

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 在当前界面中,导入编辑区域");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @returns ");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public async AddDPV_Edit(divName4Edit:string) {{",
                ThisClsName);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddDPV_Edit.name;",
       ViewMainTabName4GC, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "clsCommFunc4Web.CheckDivExist(divName4Edit);");

            strCodeForCs.AppendFormat("\r\n" + "const strUrl = \"./{0}/\";", strClassName);
            strCodeForCs.Append("\r\n" + "//console.log(\"divName4Edit:(In AddDPV_Edit)\" + divName4Edit);");
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "method: \"GET\",");
            strCodeForCs.Append("\r\n" + "dataType: \"html\",");
            strCodeForCs.Append("\r\n" + "data: { },");
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            strCodeForCs.Append("\r\n" + "console.log(\"已经成功获取页面:\" + strUrl + \"  字节数: \" + data.length.toString());");
            strCodeForCs.Append("\r\n" + "$('#' + divName4Edit).html(data);");
            strCodeForCs.Append("\r\n" + "resolve(true);");
            strCodeForCs.AppendFormat("\r\n" + "//setTimeout(() => {{ clsEditObj.BindTab(); }}, 100);");
            strCodeForCs.AppendFormat("\r\n" + "//clsEditObj.BindTab();");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: (e:any) => {");
            strCodeForCs.Append("\r\n" + "console.error(e);");
            strCodeForCs.Append("\r\n" + "reject(e);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_AddDPV_Detail(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            string strClassName = string.Format("WA_{0}_Detail", ViewMainTabName4GC);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClsName) == false)
            {
                strClassName = objViewRegionENEx.ClsName;
            }

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 在当前界面中,导入编辑区域");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @returns ");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public async AddDPV_Detail(divName4Detail:string) {{",
                ThisClsName);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddDPV_Detail.name;",
       ViewMainTabName4GC, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = \"./{0}/\";", strClassName);
            strCodeForCs.Append("\r\n" + "//console.log(\"divName4Detail:(In AddDPV_Detail)\" + divName4Detail);");
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "method: \"GET\",");
            strCodeForCs.Append("\r\n" + "dataType: \"html\",");
            strCodeForCs.Append("\r\n" + "data: { },");
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            strCodeForCs.Append("\r\n" + "//console.log(\"已经成功获取页面:\" + strUrl + \"  字节数: \" + data.length.toString());");
            strCodeForCs.Append("\r\n" + "$('#' + divName4Detail).html(data);");
            strCodeForCs.Append("\r\n" + "resolve(true);");
            strCodeForCs.AppendFormat("\r\n" + "//setTimeout(() => {{ clsDetailObj.BindTab(); }}, 100);");
            strCodeForCs.AppendFormat("\r\n" + "//clsDetailObj.BindTab();");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: (e:any) => {");
            strCodeForCs.Append("\r\n" + "console.error(e);");
            strCodeForCs.Append("\r\n" + "reject(e);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_CopyToEx()
        {
            if (this.IsUseFunc == false && this.IsUseFunc4ExcelExport == false) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 把同一个类的对象,复制到另一个对象");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}ENS:源对象", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n * @returns 目标对象=>cls{0}EN:obj{0}ENT", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n public CopyToEx(obj{0}ENS:cls{0}EN ): cls{0}ENEx", TabName_Out4ListRegion4GC);
            ImportClass objImportClass = AddImportClass(TabId_Out4ListRegion, TabName_Out4ListRegion4GC, string.Format("cls{0}EN", TabName_Out4ListRegion4GC), enumImportObjType.ENClass, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.CopyToEx.name;", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n const obj{0}ENT = new cls{0}ENEx();", TabName_Out4ListRegion4GC);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "ObjectAssign(obj{0}ENT, obj{0}ENS);", TabName_Out4ListRegion4GC);
            ImportClass objImportClass2 = AddImportClass("", "/PubFun/clsCommFunc4Web.js", "ObjectAssign", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

            strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                objViewInfoENEx.PrjId, ThisClsName, "CopyToEx_WApi", "Copy表Ex对象数据出错(TypeScript)!", "生成代码");

            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"(errid:{0})Copy表对象数据出错,{{0}}.(in {{1}}.{{2}})\", e, this.constructor.name, strThisFuncName);", strErrId);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");


            strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_FuncMap4ExcelExport()
        {
            return "";
            //if (string.IsNullOrEmpty(strMapFuncCode4ExcelExport) == false) return strMapFuncCode4ExcelExport;
            //if (bolIsUseFunc4ExcelExport == false) return "";
            //StringBuilder strCodeForCs = new StringBuilder();
            ////获取某一条件值的记录集-----------------------------;
            //strCodeForCs.Append("\r\n /**");
            //strCodeForCs.Append("\r\n * 把一个扩展类的部分属性进行函数转换");
            //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.AppendFormat("\r\n * @param obj{0}S:源对象", TabName_Out4ExportExcel4GC);
            //strCodeForCs.Append("\r\n **/");
            //strCodeForCs.AppendFormat("\r\n public async FuncMap4ExcelExport(obj{0}:cls{0}ENEx )", TabName_Out4ExportExcel4GC);
            //strCodeForCs.Append("\r\n{");
            //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.FuncMap4ExcelExport.name;");
            //strCodeForCs.Append("\r\n" + "try");
            //strCodeForCs.Append("\r\n" + "{");

            //List<clsExcelExportRegionFldsENEx> arrExcelExportRegionFld_Sel = objViewInfoENEx.arrExcelExportRegionFldSet.FindAll(x => x.IsUseFunc() == true);
            ////Graph g1 = clsDataNodeBLEx.InitGraph(objViewInfoENEx.PrjId);
            //foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in arrExcelExportRegionFld_Sel)
            //{
            //    strCodeForCs.Append("\r\n" + "{");
            //    var objDataNode_Curr = clsDataNodeBLEx.GetObjByTabIdAndFldIdCache(TabId_Out4ExportExcel, objExcelExportRegionFldsEx.FldId, 1, objViewInfoENEx.PrjId);
            //    if (objDataNode_Curr == null)
            //    {
            //        string strMsg = string.Format("在生成导出Excel的转换函数时,表TabId={0},字段FldId=[{1}]==>{4}的相关结点为空, VersionNo=1, CmPrjId={2},请检查!(In {3})",
            //            TabId_Out4ExportExcel, objExcelExportRegionFldsEx.FldId, objViewInfoENEx.PrjId, clsStackTrace.GetCurrClassFunction(), objExcelExportRegionFldsEx.DataPropertyName());
            //        throw new Exception(strMsg);
            //    }
            //    //var arrPath = clsDataNodeBLEx.GetGraphPath(g, objDataNode_Start.DataNodeId, objExcelExportRegionFldsEx.OutDataNodeId(), objViewInfoENEx.PrjId);
            //    string strLastVarName = "";
            //    //var strCmPrjId = clsCmProjectPrjTabBLEx.GetFirstCmPrjIdByTabIdCache(TabId_Out4ExportExcel);
            //    string strOutDataNodeId = objExcelExportRegionFldsEx.OutDataNodeId();
            //    List<clsDnFuncMapEN> arrEdge = null;
            //    try
            //    {
            //        clsExcelExportRegionFldsBLEx.CheckOutFldId(objExcelExportRegionFldsEx, objViewInfoENEx.PrjId, objViewInfoENEx.UserId);
            //        strOutDataNodeId = objExcelExportRegionFldsEx.OutDataNodeId();
            //        arrPath = clsDnFuncMapBLEx.GetGraphPath(objDataNode_Curr.DataNodeId, strOutDataNodeId, objViewInfoENEx.PrjId);
            //    }
            //    catch (Exception objException)
            //    {
            //        var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(TabId_Out4ListRegion, objExcelExportRegionFldsEx.PrjId());
            //        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objExcelExportRegionFldsEx.FldId, objExcelExportRegionFldsEx.PrjId());
            //        var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(objViewInfoENEx.PrjId);
            //        string strMsg = string.Format("转换函数中,表TabId={0}({3}),字段FldId=[{1}({4})]==>{8}在获取转换路径时,出错:{7}。 VersionNo=1, CmPrjId={2}({5}),请检查!(In {6})",
            //            TabId_Out4ListRegion,
            //            objExcelExportRegionFldsEx.FldId, objViewInfoENEx.PrjId,
            //            objPrjTab.TabName, objFieldTab.FldName, objCMProject.CmPrjName,
            //            clsStackTrace.GetCurrClassFunction(), objException.Message, objExcelExportRegionFldsEx.DataPropertyName());
            //        throw new Exception(strMsg);
            //    }
            //    foreach (var objInFor in arrPath)
            //    {
            //        var objDataNode_Start = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.InDataNodeId, objInFor.PrjId);
            //        var objDataNode_End = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.OutDataNodeId, objInFor.PrjId);
            //        var objFieldTab_Start = clsFieldTabBL.GetObjByFldIdCache(objDataNode_Start.FldId, objInFor.PrjId);
            //        var objFieldTab_End = clsFieldTabBL.GetObjByFldIdCache(objDataNode_End.FldId, objInFor.PrjId);

            //        switch (objInFor.FuncMapModeId)
            //        {
            //            case enumFuncMapMode.Table_01:
            //                var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
            //                string strCacheClassifyField = "";
            //                if (string.IsNullOrEmpty(objPrjTab.CacheClassifyFieldTS) == false)
            //                {
            //                    var objCacheClassifyField = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyFieldTS, objPrjTab.PrjId);

            //                    strCacheClassifyField += string.Format(", {0}", thisCacheClassify4View.VarDef4Fld);
            //                }
            //                if (string.IsNullOrEmpty(objPrjTab.CacheClassifyField2TS) == false)
            //                {
            //                    var objCacheClassifyField = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyField2TS, objPrjTab.PrjId);

            //                    strCacheClassifyField += string.Format(", {0}", thisCacheClassify4View.VarDef4Fld);
            //                }
            //                if (arrPath.Count == 1)
            //                {
            //                    if (objDataNode_Start.TabId == TabId_Out4ExportExcel)
            //                    {
            //                        strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2};", objDataNode_Start.DataNodeName,
            //                            TabName_Out4ExportExcel4GC,
            //                            objFieldTab_Start.PropertyName(this.IsFstLcase));
            //                    }
            //                    //else
            //                    //{
            //                    //    strCodeForCs.AppendFormat("\r\n const {0} = {1};", objDataNode_Start.DataNodeName, objDataNode_Start.DataNodeName);
            //                    //}
            //                }
            //                strCodeForCs.AppendFormat("\r\n const {0} = await {1}_func(cls{1}EN.con_{2}, cls{1}EN.con_{3}, {4}.toString() {5});",
            //                    objDataNode_End.DataNodeName,
            //                    objPrjTab.TabName,
            //                    objFieldTab_Start.FldName,
            //                    objFieldTab_End.FldName,
            //                    objDataNode_Start.DataNodeName,
            //                    strCacheClassifyField);
            //                            ImportClass objImportClass =AddImportClass(objPrjTab.TabId, objPrjTab.TabName, string.Format("func", objKeyField.FldName), enumImportObjType.WApiClassFunc, this.strBaseUrl);

            //CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            //clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            //                            ImportClass objImportClass =AddImportClass(objPrjTab.TabId, objPrjTab.TabName, string.Format("cls{0}EN", objPrjTab.TabName), enumImportObjType.ENClass, this.strBaseUrl);

            //CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            //clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);


            //                //if (arrTabId4MapFunc.Contains(objPrjTab.TabId) == false)
            //                //{
            //                //    arrTabId4MapFunc.Add(objPrjTab.TabId);
            //                //}
            //                strLastVarName = objDataNode_End.DataNodeName;
            //                break;
            //            case enumFuncMapMode.Function_02:
            //                var objDNFun = clsDnFunctionBL.GetObjByDnFunctionIdCache(objInFor.DnFunctionId, objViewInfoENEx.PrjId);
            //                switch (objDNFun.DnFunctionName)
            //                {
            //                    case "equal":

            //                        if (objDataNode_Start.TabId == TabId_Out4ExportExcel)
            //                        {
            //                            string strIsToString = "";
            //                            //if (objFieldTab_Start.IsNumberType() == true)
            //                            //{
            //                            //    strIsToString = ".toString()";
            //                            //}
            //                            strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2}{3};", objDataNode_End.DataNodeName,
            //                                TabName_Out4ExportExcel4GC,
            //                                objFieldTab_Start.PropertyName(this.IsFstLcase), strIsToString);
            //                        }
            //                        else
            //                        {
            //                            strCodeForCs.AppendFormat("\r\n const {0} = {1};", objDataNode_End.DataNodeName, objDataNode_Start.DataNodeName);
            //                        }
            //                        strLastVarName = objDataNode_End.DataNodeName;
            //                        break;
            //                    case "GetDateTime_Sim":
            //                        var objPrjTab2 = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
            //                        if (objDataNode_Start.TabId == TabId_Out4ExportExcel)
            //                        {
            //                            strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim(obj{1}.{2});",
            //                         objDataNode_End.DataNodeName,
            //                                TabName_Out4ExportExcel4GC,
            //                            objFieldTab_Start.PropertyName(this.IsFstLcase));
            //                        }
            //                        else
            //                        {
            //                            strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim({1});",
            //                            objDataNode_End.DataNodeName,
            //                            objDataNode_Start.DataNodeName);
            //                        }
            //                        strLastVarName = objDataNode_End.DataNodeName;
            //                        break;
            //                    default:
            //                        //var objPrjTab3 = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
            //                        if (objDataNode_Start.TabId == TabId_Out4ExportExcel)
            //                        {
            //                            strCodeForCs.AppendFormat("\r\n const {0} = await {3}(obj{1}.{2});",
            //                         objDataNode_End.DataNodeName,
            //                                TabName_Out4ExportExcel4GC,
            //                            objFieldTab_Start.PropertyName(this.IsFstLcase),
            //                            objDNFun.DnFunctionName);
            //                        }
            //                        else
            //                        {
            //                            strCodeForCs.AppendFormat("\r\n const {0} = await {2}({1});",
            //                            objDataNode_End.DataNodeName,
            //                            objDataNode_Start.DataNodeName,
            //                            objDNFun.DnFunctionName);
            //                        }
            //                        strLastVarName = objDataNode_End.DataNodeName;
            //                        break;
            //                }
            //                break;
            //        }

            //    }
            //    strCodeForCs.AppendFormat("\r\n obj{0}.{1} = {2};",
            //                        TabName_Out4ExportExcel4GC,
            //                        objExcelExportRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase),
            //                        strLastVarName);
            //    strCodeForCs.Append("\r\n" + "}");
            //}

            ////strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", TabName_Out4ExportExcel4GC);
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "catch (e)");
            //strCodeForCs.Append("\r\n" + "{");
            //string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
            //    objViewInfoENEx.PrjId, ThisClsName, "FuncMap4ExcelExport", "函数映射表:{0} 对象数据出错!", "生成代码");

            //strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"(errid:{0})函数映射4ExcelExport表对象数据出错,{{0}}.(in {{1}}.{{2}})\", e, this.constructor.name, strThisFuncName);", strErrId);
            //strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            //strCodeForCs.Append("\r\n" + "alert(strMsg);");

            ////strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy表:{0} 对象数据出错!({1}:CopyTo)\\r\\n\" + objException.Message);",
            ////  objViewInfoENEx, ThisClsName, strErrId);

            ////strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"Copy表:{0} 对象数据出错!({1}: CopyTo)\"+ objException.Message);",
            ////  objViewInfoENEx, ThisClsName);
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n}");
            ////获取某一条件值的记录集 == = ;
            //return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_FuncMap()
        {
            if (string.IsNullOrEmpty(strMapFuncCode) == false) return strMapFuncCode;
            if (this.IsUseFunc == false) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 把一个扩展类的部分属性进行函数转换");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n * @param obj{0}S:源对象", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n public async FuncMap(obj{0}:cls{0}ENEx )", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.FuncMap.name;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            List<clsDGRegionFldsENEx> arrDGRegionFld_Sel = objViewInfoENEx.arrDGRegionFldSet.FindAll(x => x.IsUseFunc() == true);
            //Graph g1 = clsDataNodeBLEx.InitGraph(objViewInfoENEx.PrjId);
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in arrDGRegionFld_Sel)
            {
                if (objDGRegionFldsEx.OutDataNodeId() == 0) continue;

                strCodeForCs.Append("\r\n" + "{");
                var objDataNode_Curr = clsDataNodeBLEx.GetObjByTabIdAndFldIdCache(TabId_Out4ListRegion, objDGRegionFldsEx.FldId, 1, objViewInfoENEx.PrjId);
                if (objDataNode_Curr == null)
                {

                    var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(TabId_Out4ListRegion, objDGRegionFldsEx.PrjId());
                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDGRegionFldsEx.FldId, objDGRegionFldsEx.PrjId());
                    var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(objViewInfoENEx.PrjId);
                    string strMsg = string.Format("转换函数中,表TabId={0}({3}),字段FldId=[{1}({4})]==>{7} 所对应的结点不存在。 VersionNo=1, CmPrjId={2}({5}),请检查!(In {6})",
                        TabId_Out4ListRegion,
                        objDGRegionFldsEx.FldId, objViewInfoENEx.PrjId,
                        objPrjTab.TabName, objFieldTab.FldName, objCMProject.CmPrjName, clsStackTrace.GetCurrClassFunction(), objDGRegionFldsEx.DataPropertyName());
                    throw new Exception(strMsg);
                }
                //var arrPath = clsDataNodeBLEx.GetGraphPath(g, objDataNode_Start.DataNodeId, objDGRegionFldsEx.OutDataNodeId(), objViewInfoENEx.PrjId);
                string strLastVarName = "";
                long strOutDataNodeId = objDGRegionFldsEx.OutDataNodeId();
                //var strCmPrjId = clsCmProjectPrjTabBLEx.GetFirstCmPrjIdByTabIdCache(TabId_Out4ListRegion);
                List<clsDnFuncMapEN> arrEdge = null;
                try
                {

                    clsDGRegionFldsBLEx.CheckOutFldId(objDGRegionFldsEx, this.IsFstLcase, objViewInfoENEx.PrjId, objViewInfoENEx.UserId);
                    strOutDataNodeId = objDGRegionFldsEx.OutDataNodeId();
                    arrEdge = clsDnFuncMapBLEx.GetGraphPath(objDataNode_Curr.DataNodeId, strOutDataNodeId, objViewInfoENEx.PrjId);
                }
                catch (Exception objException)
                {
                    var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(TabId_Out4ListRegion, objDGRegionFldsEx.PrjId());
                    var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDGRegionFldsEx.FldId, objDGRegionFldsEx.PrjId());
                    var objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(objViewInfoENEx.PrjId);
                    string strMsg = string.Format("转换函数中,表TabId={0}({3}),字段FldId=[{1}({4})]==>{8}在获取转换路径时,出错:{7}。 VersionNo=1, CmPrjId={2}({5}),请检查!(In {6})",
                        TabId_Out4ListRegion,
                        objDGRegionFldsEx.FldId, objViewInfoENEx.PrjId,
                        objPrjTab.TabName, objFieldTab.FldName, objCMProject.CmPrjName,
                        clsStackTrace.GetCurrClassFunction(), objException.Message, objDGRegionFldsEx.DataPropertyName());
                    throw new Exception(strMsg);
                }
                List<string> arrConstVar = new List<string>();
                foreach (var objInFor in arrEdge)
                {
                    string strIsToString = "";
                    var objDataNode_Start = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.InDataNodeId, objInFor.PrjId);
                    var objDataNode_End = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.OutDataNodeId, objInFor.PrjId);
                    var objFieldTab_Start = clsFieldTabBL.GetObjByFldIdCache(objDataNode_Start.FldId, objInFor.PrjId);
                    var objFieldTab_End = clsFieldTabBL.GetObjByFldIdCache(objDataNode_End.FldId, objInFor.PrjId);

                    switch (objInFor.FuncMapModeId)
                    {
                        case enumFuncMapMode.Table_01:
                            var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                            string strCacheClassifyField = "";
                            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyFieldTS) == false)
                            {
                                var objCacheClassifyField = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyFieldTS, objPrjTab.PrjId);

                                strCacheClassifyField = string.Format(", obj{0}.{1}", TabName_Out4ListRegion4GC, objCacheClassifyField.PropertyName(this.IsFstLcase));
                            }
                            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyField2TS) == false)
                            {
                                var objCacheClassifyField2 = clsFieldTabBL.GetObjByFldIdCache(objPrjTab.CacheClassifyField2TS, objPrjTab.PrjId);

                                strCacheClassifyField += string.Format(", obj{0}.{1}", TabName_Out4ListRegion4GC, objCacheClassifyField2.PropertyName(this.IsFstLcase));
                            }

                            if (arrEdge.Count == 1)
                            {
                                if (objDataNode_Start.TabId == TabId_Out4ListRegion)
                                {
                                    if (arrConstVar.Contains(objDataNode_Start.DataNodeName) == false)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2};", objDataNode_Start.DataNodeName,
                                        TabName_Out4ListRegion4GC,
                                        objFieldTab_Start.PropertyName(this.IsFstLcase));
                                        arrConstVar.Add(objDataNode_Start.DataNodeName);
                                    }
                                }
                                //else
                                //{
                                //    strCodeForCs.AppendFormat("\r\n const {0} = {1};", objDataNode_Start.DataNodeName, objDataNode_Start.DataNodeName);
                                //}
                            }

                            //if (objFieldTab_Start.IsNumberType() == true)
                            //{
                            //    strIsToString = ".toString()";
                            //}
                            if (arrConstVar.Contains(objDataNode_Start.DataNodeName) == false)
                            {
                                strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2}{3};", objDataNode_Start.DataNodeName,
                                         TabName_Out4ListRegion4GC,
                                         objFieldTab_Start.PropertyName(this.IsFstLcase), strIsToString);
                                arrConstVar.Add(objDataNode_Start.DataNodeName);
                            }
                            strCodeForCs.AppendFormat("\r\n const {0} = await {1}_func(cls{1}EN.con_{2}, cls{1}EN.con_{3}, {4} {5});",
                                objDataNode_End.DataNodeName,
                                objPrjTab.TabName,
                                objFieldTab_Start.FldName,
                                objFieldTab_End.FldName,
                                objDataNode_Start.DataNodeName,
                                strCacheClassifyField);
                            ImportClass objImportClass = AddImportClass(objPrjTab.TabId, objPrjTab.TabName, string.Format("func", objKeyField.FldName), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                            ImportClass objImportClass4 = AddImportClass(objPrjTab.TabId, objPrjTab.TabName, string.Format("cls{0}EN", objPrjTab.TabName), enumImportObjType.ENClass, this.strBaseUrl);

                            CodeElement objCodeElement_Import4 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass4);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import4);



                            arrConstVar.Add(objDataNode_End.DataNodeName);
                            //if (arrTabId4MapFunc.Contains(objPrjTab.TabId) == false)
                            //{
                            //    arrTabId4MapFunc.Add(objPrjTab.TabId);
                            //}
                            strLastVarName = objDataNode_End.DataNodeName;
                            break;
                        case enumFuncMapMode.Function_02:
                            var objDNFun = clsDnFunctionBL.GetObjByDnFunctionIdCache(objInFor.DnFunctionId, objViewInfoENEx.PrjId);
                            switch (objDNFun.DnFunctionName)
                            {
                                case "equal":

                                    if (objDataNode_Start.TabId == TabId_Out4ListRegion)
                                    {
                                        if (arrConstVar.Contains(objDataNode_Start.DataNodeName) == false)
                                        {
                                            //if (objFieldTab_Start.IsNumberType() == true)
                                            //{
                                            //    strIsToString = ".toString()";
                                            //}

                                            strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2}{3};", objDataNode_End.DataNodeName,
                                            TabName_Out4ListRegion4GC,
                                            objFieldTab_Start.PropertyName(this.IsFstLcase), strIsToString);
                                            arrConstVar.Add(objDataNode_End.DataNodeName);
                                        }
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = {1};", objDataNode_End.DataNodeName, objDataNode_Start.DataNodeName);
                                        arrConstVar.Add(objDataNode_End.DataNodeName);
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                                case "GetDateTime_Sim":
                                    var objPrjTab2 = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == TabId_Out4ListRegion)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim(obj{1}.{2});",
                                     objDataNode_End.DataNodeName,
                                            TabName_Out4ListRegion4GC,
                                        objFieldTab_Start.PropertyName(this.IsFstLcase));
                                        arrConstVar.Add(objDataNode_End.DataNodeName);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim({1});",
                                        objDataNode_End.DataNodeName,
                                        objDataNode_Start.DataNodeName);
                                        arrConstVar.Add(objDataNode_End.DataNodeName);
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                                default:
                                    //var objPrjTab3 = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == TabId_Out4ListRegion)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = await {3}(obj{1}.{2});",
                                     objDataNode_End.DataNodeName,
                                            TabName_Out4ListRegion4GC,
                                        objFieldTab_Start.PropertyName(this.IsFstLcase),
                                        objDNFun.DnFunctionName);
                                        arrConstVar.Add(objDataNode_End.DataNodeName);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = await {2}({1});",
                                        objDataNode_End.DataNodeName,
                                        objDataNode_Start.DataNodeName,
                                        objDNFun.DnFunctionName);
                                        arrConstVar.Add(objDataNode_End.DataNodeName);
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                            }
                            break;
                    }

                }
                strCodeForCs.AppendFormat("\r\n obj{0}.{1} = {2};",
                                    TabName_Out4ListRegion4GC,
                                    objDGRegionFldsEx.DataPropertyName_FstLcase(this.IsFstLcase),
                                    strLastVarName);
                strCodeForCs.Append("\r\n" + "}");
            }

            //strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                objViewInfoENEx.PrjId, ThisClsName, "FuncMap", "函数映射表:{0} 对象数据出错!", "生成代码");

            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"(errid:{0})函数映射表对象数据出错,{{0}}.(in {{1}}.{{2}})\", e, this.constructor.name, strThisFuncName);", strErrId);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy表:{0} 对象数据出错!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objViewInfoENEx, ThisClsName, strErrId);

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"Copy表:{0} 对象数据出错!({1}: CopyTo)\"+ objException.Message);",
            //  objViewInfoENEx, ThisClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
        }

        public void GetImportClassLst(clsFuncModule_AgcEN objFuncModule0)
        {
            //List<ImportClass> arrImportClass = new List<ImportClass>();
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";

            arrImportClass.Add(new ImportClass
            {
                ClsName = "divVarSet",
                FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}", "", objFuncModule0.FuncModuleEnName4GC(),
             ViewMainTabName4GC)
            });

            //arrImportClass.Add(new ImportClass
            //{
            //    ClsName = "divVarSet",
            //    FilePath = string.Format($"@/views/{objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}", "", objFuncModule0.FuncModuleEnName4GC(),
            //       ViewMainTabName4GC)
            //});
            arrImportClass.Add(new ImportClass
            {
                ClsName = "viewVarSet",
                FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}", "", objFuncModule0.FuncModuleEnName4GC(),
       ViewMainTabName4GC)
            });
            if (IsHasListRegion)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClsName = "dataColumn",
                    FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}", "", objFuncModule0.FuncModuleEnName4GC(),
                       ViewMainTabName4GC)
                }); 
                arrImportClass.Add(new ImportClass
                {
                    ClsName = "BindTabByList",
                    FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}", "", objFuncModule0.FuncModuleEnName4GC(),
                       ViewMainTabName4GC)
                });
                arrImportClass.Add(new ImportClass
                {
                    ClsName = $"ref{ThisListClsName}",
                    FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}", "", objFuncModule0.FuncModuleEnName4GC(),
                ViewMainTabName4GC)
                });
            }
            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("cls{0}EN", ViewMainTabName4GC),
                FilePath = string.Format("{0}/L0Entity/{1}/cls{2}EN.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC(),
                   ViewMainTabName4GC)
            });



            if (objViewInfoENEx.objViewRegion_ExportExcel != null)
            {

                clsPrjTabEN objPrjTabEN_Excel = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.objViewRegion_ExportExcel.TabId, objViewInfoENEx.PrjId);

                clsFuncModule_AgcEN objFuncModule_AgcEN_Excel = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabEN_Excel.FuncModuleAgcId, objPrjTabEN_Excel.PrjId);
                arrImportClass.Add(new ImportClass
                {
                    ClsName = string.Format("cls{0}EN", objPrjTabEN_Excel.TabName),
                    FilePath = string.Format("{0}/L0Entity/{1}/cls{2}EN.js", this.strBaseUrl, objFuncModule_AgcEN_Excel.FuncModuleEnName4GC(),
                             objPrjTabEN_Excel.TabName)
                });


            }
            if (objPrjTabEx_ListRegion != null && objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                if (strSqlDsTypeId4ListRegion == enumSQLDSType.SqlView_02)
                {
                    arrImportClass.Add(new ImportClass
                    {
                        ClsName = string.Format("BindTab_KeyLst_V", ViewMainTabName4GC),
                        FilePath = string.Format("{0}/PubFun/clsCommFunc4Web.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC(),
                ViewMainTabName4GC)
                    });
                }
                else
                {
                    arrImportClass.Add(new ImportClass
                    {
                        ClsName = string.Format(" BindTab_KeyLst ", ViewMainTabName4GC),
                        FilePath = string.Format("{0}/PubFun/clsCommFunc4Web.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC(),
                ViewMainTabName4GC)
                    });
                }
            }
            else if (objPrjTabEx_ListRegion != null && objPrjTabEx_ListRegion.arrKeyFldSet.Count == 1)
            {
                if (strSqlDsTypeId4ListRegion == enumSQLDSType.SqlView_02)
                {
                    arrImportClass.Add(new ImportClass
                    {
                        ClsName = string.Format("BindTab_V", ViewMainTabName4GC),
                        FilePath = string.Format("{0}/PubFun/clsCommFunc4Web.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC(),
                ViewMainTabName4GC)
                    });
                }
                else
                {
                    arrImportClass.Add(new ImportClass
                    {
                        ClsName = string.Format(" BindTab", ViewMainTabName4GC),
                        FilePath = string.Format("{0}/PubFun/clsCommFunc4Web.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC(),
                ViewMainTabName4GC)
                    });
                }
            }
            if (string.IsNullOrEmpty(strSqlDsTypeId4ListRegion) == false)
            {
                if (strSqlDsTypeId4ListRegion == enumSQLDSType.SqlView_02)
                {
                    arrImportClass.Add(new ImportClass
                    {
                        ClsName = string.Format(" arrSelectedKeys, confirmDel, GetObjKeys, Redirect, SortFun ", ViewMainTabName4GC),
                        FilePath = string.Format("{0}/PubFun/clsCommFunc4Web.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC(),
                ViewMainTabName4GC)
                    });
                }
                else
                {
                    arrImportClass.Add(new ImportClass
                    {
                        ClsName = string.Format(" arrSelectedKeys, confirmDel, GetObjKeys, Redirect, SortFun ", ViewMainTabName4GC),
                        FilePath = string.Format("{0}/PubFun/clsCommFunc4Web.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC(),
                ViewMainTabName4GC)
                    });
                }
            }
            if (objPrjTabEx_ListRegion != null && objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClsName = string.Format("GetLabelHtmlInDivObj, SetLabelHtmlByIdInDivObj", ViewMainTabName4GC),
                    FilePath = string.Format("{0}/PubFun/clsCommFunc4Ctrl.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC(),
       ViewMainTabName4GC)
                });
            }
            else
            {
                arrImportClass.Add(new ImportClass
                {
                    ClsName = string.Format(" GetLabelHtmlInDivObj, SetLabelHtmlByIdInDivObj", ViewMainTabName4GC),
                    FilePath = string.Format("{0}/PubFun/clsCommFunc4Ctrl.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC(),
       ViewMainTabName4GC)
                });
            }

            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("clsPager", ViewMainTabName4GC),
                FilePath = string.Format("{0}/PubFun/clsPager.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC(),
            ViewMainTabName4GC)
            });

            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("stuPagerPara", ViewMainTabName4GC),
                FilePath = string.Format("{0}/PubFun/stuPagerPara.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC(),
            ViewMainTabName4GC)
            });
            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("clsDataColumn", ViewMainTabName4GC),
                FilePath = string.Format("{0}/PubFun/clsDataColumn.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC(),
            ViewMainTabName4GC)
            });

            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("ListPara", ViewMainTabName4GC),
                FilePath = string.Format("{0}/PubFun/clsOperateList.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC(),
         ViewMainTabName4GC)
            });


            //      arrImportClass.Add(new ImportClass
            //      {
            //          ClsName =  string.Format("TransToBool", ViewMainTabName4GC),
            //          FilePath = string.Format("{0}/PubFun/jsString.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC()
            //ViewMainTabName4GC)
            //      });


            //          arrImportClass.Add(new ImportClass
            //          {
            //              ClsName =  string.Format("clsPubSessionStorage", ViewMainTabName4GC),
            //              FilePath = string.Format("{0}/PubFun/clsPubSessionStorage.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC()
            //ViewMainTabName4GC)
            //          });
            //            arrImportClass.Add(new ImportClass
            //            {
            //                ClsName =  string.Format("clsPrivateSessionStorage", ViewMainTabName4GC),
            //                FilePath = string.Format("{0}/PubConfig/clsPrivateSessionStorage.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC()
            //ViewMainTabName4GC)
            //            });

            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("Format", ViewMainTabName4GC),
                FilePath = string.Format("{0}/PubFun/clsString.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC(),
 ViewMainTabName4GC)
            });
            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("clsOperateList, GetCurrPageIndex, GetSortBy", ViewMainTabName4GC),
                FilePath = string.Format("{0}/PubFun/clsOperateList.js", this.strBaseUrl, objFuncModule0.FuncModuleEnName4GC(),
             ViewMainTabName4GC)
            });

        }

        public string Gen_WApi_Ts_SetEventFunc()
        {
            if (objViewInfoENEx.arrQryRegionFldSet == null) return "";
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /** 函数功能:设置事件函数");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public async SetEventFunc()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SetEventFunc.name;",
       ViewMainTabName4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");


                //strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //生成PageLoad中的绑定下拉框的代码
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");

                var arrQryRegionFlds_ChangeEvent = objViewInfoENEx.arrQryRegionFldSet.Where(x => string.IsNullOrEmpty(x.ChangeEvent) == false && x.InUse == true).ToList();
                arrQryRegionFlds_ChangeEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);
                    strCodeForCs.Append("\r\n" + $"const {x.CtrlId()}: {objCtlTypeAbbr.HtmlCtrlTypeName} = GetSelectObjInDivObj(divVarSet.refDivQuery, '{x.CtrlId()}');");
                    strCodeForCs.AppendFormat("\r\n" + "{0}.addEventListener('change', e => {{ console.error(e); this.{1}(); }});",
                      x.CtrlId(), x.ChangeEvent, ThisClsName);
                    ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectObjInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                });

                var arrQryRegionFlds_ClickEvent = objViewInfoENEx.arrQryRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrQryRegionFlds_ClickEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);
                    switch (objCtlTypeAbbr.HtmlCtrlTypeName)
                    {
                        case "HTMLButtonElement":
                            strCodeForCs.Append("\r\n" + $"const {x.CtrlId()}: {objCtlTypeAbbr.HtmlCtrlTypeName} =GetButtonObjInDivObj(divVarSet.refDivQuery, '{x.CtrlId()}');");
                            break;
                        case "HTMLInputElement":
                            strCodeForCs.Append("\r\n" + $"const {x.CtrlId()}: {objCtlTypeAbbr.HtmlCtrlTypeName} =GetInputObjInDivObj(divVarSet.refDivQuery, '{x.CtrlId()}');");
                            break;
                        default:
                            var strMsg = String.Format("控件类型(HtmlCtrlTypeName):{0}在switch中没有被处理!(In {1})", objCtlTypeAbbr.HtmlCtrlTypeName,
                                clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);

                    }
                    strCodeForCs.AppendFormat("\r\n" + "{0}.addEventListener('click', e => {{ this.{1}(); }});",
                      x.CtrlId(), x.ClickEvent, ThisClsName);
                });
                if (arrQryRegionFlds_ChangeEvent.Count == 0 && arrQryRegionFlds_ClickEvent.Count == 0)
                {
                    strCodeForCs.Append("\r\n" + "//没有定义相关事件");
                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = `设置事件函数不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_GeneEventFunc()
        {
            if (objViewInfoENEx.arrQryRegionFldSet == null) return "";
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {


                var arrQryRegionFlds_ChangeEvent = objViewInfoENEx.arrQryRegionFldSet.Where(x => string.IsNullOrEmpty(x.ChangeEvent) == false && x.InUse == true).ToList();
                arrQryRegionFlds_ChangeEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);

                    strCodeForCs.Append("\r\n /** 函数功能:系统生成的Change事件函数");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + " **/");
                    strCodeForCs.AppendFormat("\r\n" + "public abstract {0}():void;//",
                       x.ChangeEvent);
                    //strCodeForCs.AppendFormat("\r\n" + "alert('请在扩展层:{0}Ex中覆盖该函数!');", ThisClsName);
                    //strCodeForCs.Append("\r\n" + "}");
                });

                strCodeForCs.Append("\r\n" + "");

                var arrQryRegionFlds_ClickEvent = objViewInfoENEx.arrQryRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrQryRegionFlds_ClickEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);
                    strCodeForCs.Append("\r\n /** 函数功能:系统生成的Click事件函数");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + " **/");

                    strCodeForCs.AppendFormat("\r\n" + "public abstract {0}():void;",
                       x.ClickEvent, ThisClsName);
                    //strCodeForCs.AppendFormat("\r\n" + "alert('请在扩展层:{0}Ex中覆盖该函数!');", ThisClsName);
                    //strCodeForCs.Append("\r\n" + "}");
                });

                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
            {
                Name = strFuncName,
                CodeContent = strCodeForCs.ToString(),
                ElementType = CodeElementType.Method,
                Modifiers = "public async",
                ReturnType = "void",
            });
            if (strFuncName == "")
            {
                string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }



        //public bool AddImportClass(string strTabId, string strClassName, string strFuncName, string strImportObjType, string strBasePath)
        //{
        //    return clsPubFun4GC.AddImportClass(strTabId, strClassName, strFuncName, strImportObjType, strBasePath, arrImportClass, objViewInfoENEx.PrjId);
        //}
    }
}
