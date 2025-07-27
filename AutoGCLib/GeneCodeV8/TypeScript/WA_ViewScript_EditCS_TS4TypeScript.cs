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
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace AutoGCLib
{
    partial class WA_ViewScript_EditCS_TS4TypeScript : clsGeneCodeBase4View
    {

        protected List<clsPropertyDef4GC> arrPropertyDef4GC = null;
        //protected string thisCacheClassify4View.VarDef4Fld = "";
        //protected string thisCacheClassify4View.VarDef4Fld2 = "";
        //protected string this.TabName_In4Edit4GC = "";

        //protected string this.TabId_In4Edit = "";
        //protected string objPrjTabENEx = "";
        //private string strVarDef4GivingValue = "";
        //protected clsFuncModule_AgcEN objFuncModule = null;
        #region 构造函数
        public WA_ViewScript_EditCS_TS4TypeScript()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strBaseUrl = "../../TS";
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        public WA_ViewScript_EditCS_TS4TypeScript(string strViewId)
       : base( strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strBaseUrl = "../../TS";
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
            this.arrImportClass = new List<ImportClass>();
        }
        public WA_ViewScript_EditCS_TS4TypeScript( string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strBaseUrl = "../../TS";
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
            this.GetClsName();
            //if (thisCacheClassify4View.IsHasCacheClassfyFld == true)
            //{
            //    thisCacheClassify4View.VarDef4Fld = string.Format("{0}.{1}Cache", ThisClsName, thisCacheClassify4View.FldName);
            //}
            //if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true)
            //{
            //    thisCacheClassify4View.VarDef4Fld2 = string.Format("{0}.{1}Cache", ThisClsName, thisCacheClassify4View.FldName2);
            //}
            this.arrImportClass = new List<ImportClass>();
        }
        /// <summary>
        /// 初始化页面设置
        /// </summary>
        public void InitPageSetup()
        {
            intZIndex = 100;        ///控件焦点序号
            intCurrLeft = 10;  ///控件的左边空;
            intCurrTop = 10;
        }

        #endregion

        public string Gen_WApi_Ts_Page_Load()
        {
            return "";
        }

        public string Gen_WApi_Ts_SetEventFunc()
        {

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
this.TabName_In4Edit4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");


                //strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //生成PageLoad中的绑定下拉框的代码
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");

                var arrEditRegionFlds_ChangeEvent = objViewInfoENEx.arrEditRegionFldSet.Where(x => string.IsNullOrEmpty(x.ChangeEvent) == false && x.InUse == true).ToList();
                arrEditRegionFlds_ChangeEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);
                    strCodeForCs.AppendFormat("\r\n" + $"const {x.CtrlId}: {objCtlTypeAbbr.HtmlCtrlTypeName} = GetSelectObjInDivObj(divVarSet.refDivEdit, '{x.CtrlId}');");
                    strCodeForCs.AppendFormat("\r\n" + "{0}.addEventListener('change', e => {{ console.error(e); this.{1}({0}); }});",
                       x.CtrlId, x.ChangeEvent, ThisClsName);
                    ImportClass objImportClass = AddImportClass(this.TabId_In4Edit, "/PubFun/clsCommFunc4Ctrl.js", "GetSelectObjInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                });

                var arrEditRegionFlds_ClickEvent = objViewInfoENEx.arrEditRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrEditRegionFlds_ClickEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);
                    switch (objCtlTypeAbbr.HtmlCtrlTypeName)
                    {
                        case "HTMLButtonElement":
                            strCodeForCs.Append("\r\n" + $"const {x.CtrlId}: {objCtlTypeAbbr.HtmlCtrlTypeName} =GetButtonObjInDivObj(divVarSet.refDivEdit, '{x.CtrlId}');");
                            break;
                        case "HTMLInputElement":
                            strCodeForCs.Append("\r\n" + $"const {x.CtrlId}: {objCtlTypeAbbr.HtmlCtrlTypeName} =GetInputObjInDivObj(divVarSet.refDivEdit, '{x.CtrlId}');");
                            break;
                        case "HTMLSelectElement":
                            strCodeForCs.Append("\r\n" + $"const {x.CtrlId}: {objCtlTypeAbbr.HtmlCtrlTypeName} =GetSelectObjInDivObj(divVarSet.refDivEdit, '{x.CtrlId}');");
                            break;

                        default:
                            var strMsg = String.Format("控件类型(HtmlCtrlTypeName):{0}在switch中没有被处理!(In {1})", objCtlTypeAbbr.HtmlCtrlTypeName,
                                clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);

                    }
                    strCodeForCs.AppendFormat("\r\n" + "{0}.addEventListener('click', e => {{ this.{1}({0}); }});",
                       x.CtrlId, x.ClickEvent, ThisClsName);
                });

                if (arrEditRegionFlds_ChangeEvent.Count == 0 && arrEditRegionFlds_ClickEvent.Count == 0)
                {
                    strCodeForCs.Append("\r\n" + "//没有定义相关事件");
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"设置事件函数不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
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

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {


                var arrEditRegionFlds_ChangeEvent = objViewInfoENEx.arrEditRegionFldSet.Where(x => string.IsNullOrEmpty(x.ChangeEvent) == false && x.InUse == true).ToList();
                arrEditRegionFlds_ChangeEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);

                    strCodeForCs.Append("\r\n /** 函数功能:系统生成的Change事件函数");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + " **/");
                    strCodeForCs.AppendFormat("\r\n" + "public abstract {0}({1}: HTMLSelectElement):void;//",
                       x.ChangeEvent, x.CtrlId);
                    //strCodeForCs.AppendFormat("\r\n" + "alert('请在扩展层:{0}Ex中覆盖该函数!');", ThisClsName);
                    //strCodeForCs.Append("\r\n" + "}");
                });

                strCodeForCs.Append("\r\n" + "");

                var arrEditRegionFlds_ClickEvent = objViewInfoENEx.arrEditRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrEditRegionFlds_ClickEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);
                    strCodeForCs.Append("\r\n /** 函数功能:系统生成的Click事件函数");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + " **/");

                    strCodeForCs.AppendFormat("\r\n" + "public abstract {0}({1}:HTMLButtonElement):void;",
                       x.ClickEvent, x.CtrlId);
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
                                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl_{0}.name;", objEditRegionFldsEx.FldName);
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
                                    strCodeForCs.Append("\r\n" + "/**");
                                    strCodeForCs.AppendFormat("\r\n" + " * 为下拉框获取数据,从表:[{0}]中获取",
                                      strDsTabName);
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n * returns:获取主键字段、名称字段两列的所有记录记录的DataTable</returns>");
                                    strCodeForCs.Append("\r\n" + " **/");
                                    //strCodeForCs.AppendFormat("\r\n" + "public async BindDdl_{1}(ddl{1}: string, strWhereCond:string=\"1=1\") {{",
                                    //  strDsTabName, strDS_DataValueField, strDS_DataTextField, objEditRegionFldsEx.CtrlId);
                                    //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl_{0}.name;", strDS_DataValueField);
                                    //strCodeForCs.Append("\r\n" + "//let strWhereCond = \" 1 =1 \";");
                                    //strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(ddl{1});",
                                    //    strDsTabName, strDS_DataValueField, strDS_DataTextField);
                                    //strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                                    //strCodeForCs.Append("\r\n" + "{");
                                    //strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"下拉框：{{0}} 不存在!\", ddl{1});",
                                    //    strDsTabName, strDS_DataValueField, strDS_DataTextField);
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
                                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"绑定下拉框不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "});");
                                    strCodeForCs.Append("\r\n" + "}");


                                    break;
                                case "03": ///列表项数据源SQL串;
                                    strCodeForCs.Append("\r\n" + "/**");
                                    strCodeForCs.AppendFormat("\r\n" + " * 为下拉框获取数据,从Sql串:[{0}]中获取",
                                       objEditRegionFldsEx.DsSqlStr);
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n * returns:获取自定义的Sql串中两列的所有记录记录的DataTable</returns>");
                                    strCodeForCs.Append("\r\n" + " **/");
                                    strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}(string strCondition)",
                                    objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Get{0}.name;", objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
                                    //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = {0}GetSpecSQLObj();", this.TabName_In4Edit4GC);

                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable({0});",
                                    objEditRegionFldsEx.DsSqlStr);
                                    strCodeForCs.Append("\r\n" + "return objDT;");
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.Append("\r\n /** 绑定基于Web的下拉框");
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n * @param  objDDL:需要绑定当前表的下拉框");
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



        public Tuple<string, string> Gen_WApi_Ts_DefineVar4Ddl4TabFeature(ASPDropDownListEx objInfor, List<string> arrCondFldId, FuncParaLst objFuncParaLstAll)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            List<string> arrConditionFldName = new List<string>();
            if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == false)
            {
                var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objViewInfoENEx.PrjId);
                var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objViewInfoENEx.PrjId);
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




            string strVar4Cond = "";

            Tuple<string, string> tup = new Tuple<string, string>(strVar4Cond, strFuncParaLst_Additional);

            return tup;
        }



        public string Gen_WApi_Ts_BindDdl4EditRegion()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            List<ASPDropDownListEx> arrASPDropDownListObj_Edit = objViewInfoENEx.arrASPDropDownListObj.Where(x => x.RegionTypeId == enumRegionType.EditRegion_0003).ToList();
            try
            {
                strCodeForCs.Append("\r\n /** 函数功能:为编辑区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async BindDdl4EditRegion()", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl4EditRegion.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");

                //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager\");");
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Edit)
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
                    try
                    {
                        //Tuple<string, string> tup = this.Gen_WApi_Ts_DefineVar4Ddl(objInfor, objVarManage);
                        ////
                        //string strVar4Cond = tup.Item1;
                        //string strVar4Cond_2 = tup.Item2;

                        //if (objInfor.CsType == "bool")
                        //{
                        //    objInfor.CodeText = string.Format("\r\n" + "BindDdl_TrueAndFalse(\"{0}\");",              objInfor.CtrlId);
                        //}
                        //else
                        //{
                        //    objInfor.CodeText = string.Format("\r\n" + "const {2} = await this.SetDdl_{1}({4});//{3}",
                        //                objInfor.FldName,
                        //                 objInfor.FldName,
                        //                objInfor.CtrlId,
                        //                clsRegionTypeBL.GetNameByRegionTypeIdCache(objInfor.RegionTypeId),
                        //                strVar4Cond_2);

                        //}
                    }
                    catch (Exception objException)
                    {
                        string strMsg = objException.Message;
                    }
                }

                strCodeForCs.Append("\r\n" + objVarManage.GetVarLstDefStr(this, this.strBaseUrl));

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Edit)
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


        public string Gen_WApi_Ts_BindDdl4EditRegionInDiv()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            List<ASPDropDownListEx> arrASPDropDownListObj_Edit = objViewInfoENEx.arrASPDropDownListObj.Where(x => x.RegionTypeId == enumRegionType.EditRegion_0003).ToList();
            try
            {
                strCodeForCs.Append("\r\n /** 函数功能:为编辑区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async BindDdl4EditRegionInDiv()", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");
                //                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl4EditRegionInDiv.name;",
                //this.TabName_In4Edit4GC, objKeyField.FldName);

                //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager\");");

                var objFuncParaLstAll = new FuncParaLst("AllDdlParaLst", this.IsFstLcase, enumAppLevel.InvokeFunc);

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Edit)
                {
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true) continue;

                    var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                    var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);
                    var arrTabFeatureFlds_Cond = arrTabFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();
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

                    Tuple<string, string> tup;
                    //if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true)
                    //{
                    //    tup = this.Gen_WApi_Ts_DefineVar4Ddl(objInfor, objVarManage);
                    //}
                    //else
                    //{
                    if (objInfor.CsType == "bool")
                    {
                        objInfor.CodeText = string.Format("\r\n" + "BindDdl_TrueAndFalse(\"{0}\");", objInfor.CtrlId);
                        ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Web.js", "BindDdl_TrueAndFalse", enumImportObjType.CustomFunc, this.strBaseUrl);

                        CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                        clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                    }
                    else if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true)
                    {
                        string strMsg = string.Format("下拉框:[{0}]没有表:[{0}]的下拉框功能!", objInfor.CtrlId, objInfor.DsTabName);
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        tup = this.Gen_WApi_Ts_DefineVar4Ddl4TabFeature(objInfor, arrCondFldId, objFuncParaLstAll);
                        //}
                        //
                        string strVar4Cond = tup.Item1;
                        string strVar4Cond_2 = tup.Item2;
                        if (objInfor.CsType == "bool")
                        {
                            objInfor.CodeText = string.Format("\r\n" + $"BindDdl_TrueAndFalseInDivObj(divVarSet.refDivEdit, \"{objInfor.CtrlId}\");");
                        }
                        else
                        {
                            objInfor.CodeText = string.Format("\r\n" + "await this.SetDdl_{0}InDiv({1});//{2}",
                                        objInfor.FldName,
                                        strVar4Cond_2,
                                        clsRegionTypeBL.GetNameByRegionTypeIdCache(objInfor.RegionTypeId)
                                        );
                        }
                    }
                }

                strCodeForCs.Append("\r\n" + objFuncParaLstAll.GetVarLstDefStr(ThisClsName, this, this.strBaseUrl));

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Edit)
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
        public void GetImportClassLst(clsFuncModule_AgcEN objFuncModule)
        {
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            arrImportClass.Add(new ImportClass
            {
                ClsName = "divVarSet",
                FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}", "", objFuncModule.FuncModuleEnName4GC(),
                  ViewMainTabName4GC)
            });
            arrImportClass.Add(new ImportClass
            {
                ClsName = $"ref{ThisEditClsName}",
                FilePath = string.Format($"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{this.GetVueShareClsName()}", "", objFuncModule.FuncModuleEnName4GC(),
                  ViewMainTabName4GC)
            });

            //List<ImportClass> arrImportClass = new List<ImportClass>();
            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("cls{0}EN", this.TabName_In4Edit4GC),
                FilePath = string.Format("{0}/L0Entity/{1}/cls{2}EN.js", this.strBaseUrl, objFuncModule.FuncModuleEnName4GC(),
                   this.TabName_In4Edit4GC)
            });


            //if (this.TabName_In4Edit4GC != this.TabName_In4Edit4GC)
            //{
            //    arrImportClass.Add(new ImportClass
            //    {
            //        ClsName =  string.Format("cls{0}EN", this.TabName_In4Edit4GC),
            //        FilePath = string.Format("{0}/L0Entity/{1}/cls{2}EN.js", this.strBaseUrl, objFuncModule.FuncModuleEnName4GC()
            //                    this.TabName_In4Edit4GC)
            //    });
            //}



            if (objViewInfoENEx.CodeTypeId != enumCodeType.WA_ViewScript_EditCS_TS_0248)
            {
                //    arrImportClass.Add(new ImportClass
                //    {
                //        ClsName =  string.Format("HideDialog, ShowDialog", this.TabName_In4Edit4GC),
                //        FilePath = string.Format("{0}/PubFun/clsCommFunc4Web.js", this.strBaseUrl, objFuncModule.FuncModuleEnName4GC()
                //this.TabName_In4Edit4GC)
                //    });
            }
            else
            {
                //    arrImportClass.Add(new ImportClass
                //    {
                //        ClsName =  string.Format("BindDdl_TrueAndFalseInDiv", this.TabName_In4Edit4GC),
                //        FilePath = string.Format("{0}/PubFun/clsCommFunc4Web.js", this.strBaseUrl, objFuncModule.FuncModuleEnName4GC()
                //this.TabName_In4Edit4GC)
                //    });
            }

    //        arrImportClass.Add(new ImportClass
    //        {
    //            ClsName = string.Format(" GetInputValueInDivObj, SetInputValueInDivObj ", this.TabName_In4Edit4GC),
    //            FilePath = string.Format("{0}/PubFun/clsCommFunc4Ctrl.js", this.strBaseUrl, objFuncModule.FuncModuleEnName4GC(),
    //this.TabName_In4Edit4GC)
    //        });
            //          arrImportClass.Add(new ImportClass
            //          {
            //              ClsName =  string.Format("clsPubSessionStorage", this.TabName_In4Edit4GC),
            //              FilePath = string.Format("{0}/PubFun/clsPubSessionStorage.js", this.strBaseUrl, objFuncModule.FuncModuleEnName4GC()
            //this.TabName_In4Edit4GC)
            //          });

            //            arrImportClass.Add(new ImportClass
            //            {
            //                ClsName =  string.Format("clsPrivateSessionStorage", this.TabName_In4Edit4GC),
            //                FilePath = string.Format("{0}/PubConfig/clsPrivateSessionStorage.js", this.strBaseUrl, objFuncModule.FuncModuleEnName4GC()
            //this.TabName_In4Edit4GC)
            //            });

            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("Format", this.TabName_In4Edit4GC),
                FilePath = string.Format("{0}/PubFun/clsString.js", this.strBaseUrl, objFuncModule.FuncModuleEnName4GC(),
 this.TabName_In4Edit4GC)
            });

            //            arrImportClass.Add(new ImportClass
            //            {
            //                ClsName =  string.Format("clsDateTime", this.TabName_In4Edit4GC),
            //                FilePath = string.Format("{0}/PubFun/clsDateTime.js", this.strBaseUrl, objFuncModule.FuncModuleEnName4GC(),
            //this.TabName_In4Edit4GC)
            //            });
            arrImportClass.Add(new ImportClass
            {
                ClsName = string.Format("IShowList", this.TabName_In4Edit4GC),
                FilePath = string.Format("{0}/PubFun/IShowList.js", this.strBaseUrl, objFuncModule.FuncModuleEnName4GC(),
this.TabName_In4Edit4GC)
            });

            var objPrjTab_PageDispMode = clsPrjTabBLEx.GetObjByTabNameExCache(objViewInfoENEx.PrjId, conPageDispMode._CurrTabName);
            if (objPrjTab_PageDispMode != null)
            {
                var objFuncModule_PageDispMode = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTab_PageDispMode.FuncModuleAgcId, objPrjTab_PageDispMode.PrjId);
                arrImportClass.Add(new ImportClass
                {
                    ClsName = string.Format("enumPageDispMode", this.TabName_In4Edit4GC),
                    FilePath = string.Format("{0}/PubFun/enumPageDispMode.js", this.strBaseUrl, objFuncModule_PageDispMode.FuncModuleEnName4GC())
                });

            }

            List<string> arrTabName = new List<string>();


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
                strTabId = this.TabId_In4Edit;
            }
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, objViewInfoENEx.PrjId);

            //if (thisCacheClassify4View.IsHasCacheClassfyFld == true)
            //{

            //    if (string.IsNullOrEmpty(objPrjTab.ParaVar1TS) == false)
            //    {
            //        var objVar = clsGCVariableBL.GetObjByVarIdCache(objPrjTab.ParaVar1TS);
            //        if (objVar.VarTypeId == enumGCVariableType.sessionStorage_0004)
            //        {
            //            thisCacheClassify4View.VarDef4Fld = string.Format("{0}", objVar.VarExpression);
            //        }
            //        else
            //        {
            //            thisCacheClassify4View.VarDef4Fld = string.Format("{0}.{1}Cache", ThisClsName, thisCacheClassify4View.FldName);
            //        }
            //    }
            //    else
            //    {
            //        thisCacheClassify4View.VarDef4Fld = string.Format("{0}.{1}Cache", ThisClsName, thisCacheClassify4View.FldName);
            //    }
            //}
            //if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true)
            //{
            //    if (string.IsNullOrEmpty(objPrjTab.ParaVar2TS) == false)
            //    {
            //        var objVar = clsGCVariableBL.GetObjByVarIdCache(objPrjTab.ParaVar2TS);
            //        if (objVar.VarTypeId == enumGCVariableType.sessionStorage_0004)
            //        {
            //            thisCacheClassify4View.VarDef4Fld2 = string.Format("{0}", objVar.VarExpression);
            //        }
            //        else
            //        {
            //            thisCacheClassify4View.VarDef4Fld2 = string.Format("{0}.{1}Cache", ThisClsName, thisCacheClassify4View.FldName2);
            //        }
            //    }
            //    else
            //    {
            //        thisCacheClassify4View.VarDef4Fld2 = string.Format("{0}.{1}Cache", ThisClsName, thisCacheClassify4View.FldName2);
            //    }
            //}
            return true;
        }
        /// <summary>
        /// 生成App页面后台代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            if (objViewInfoENEx.objViewRegion_Edit == null || objViewInfoENEx.objViewRegion_Edit.IsDispInViewInfo(objViewInfoENEx) == false)
            {
                return "";
            }
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            //让用户设置属性;
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }

            //string strResult = "";
            GetCacheParaVarStr();
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
            this.objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            var objPrjTab_EditRegion = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.objViewRegion_Edit.TabId, objViewInfoENEx.PrjId);

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objCodeType, objFuncModuleEN, objViewInfoENEx, this.TabName_In4Edit4GC);

            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            try
            {
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
                strCodeForCs.Append("\r\n" + "* 宣布一个已经在存在的函数ShowDialog,用于显示对象框,");
                strCodeForCs.Append("\r\n" + "* @param  strOpType：是操作类型,是三种类型之一：Add, Update, Detail");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "declare function ShowDialog(strDialogName:string): void;", this.TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + "* 宣布一个已经在存在的函数HideDialog,用于隐藏对象框,");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "declare function HideDialog(strDialogName:string): void;", this.TabName_In4Edit4GC);

                strCodeForCs.AppendFormat("\r\n /** {0} 的摘要说明。其中Q代表查询,U代表修改",
                    ThisClsName);
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "export abstract class  {0} ", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");
                var objPageDispMode = clsPageDispModeBL.GetObjByPageDispModeIdCache(objViewInfoENEx.objViewRegion_Edit.PageDispModeId);
                if (objPageDispMode == null)
                {
                    string strMsg = string.Format("生成界面:[{0}]编辑区,页面显示模式为空,请重新设置!(In {1})",
                        objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                strCodeForCs.Append("\r\n" + "public opType = \"\";");
                strCodeForCs.Append("\r\n" + "public keyId = \"\";");
                strCodeForCs.Append("\r\n" + GeneViewPubVar_TS(strFuncName));

                strCodeForCs.AppendFormat("\r\n" + "public static strPageDispModeId = \"{0}\";//{1}({2})",
                    objPageDispMode.PageDispModeId, objPageDispMode.PageDispModeENName, objPageDispMode.PageDispModeName);
                strCodeForCs.AppendFormat("\r\n" + "public static objPageEdit: {0};", ThisClsName);

                strCodeForCs.AppendFormat("\r\n" + "public obj{0}: cls{0}EN;", this.TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + "protected iShowList: IShowList|null;");

                strCodeForCs.Append("\r\n" + "public bolIsLoadEditRegion = false;  //记录是否导入编辑区的变量");

                strCodeForCs.Append("\r\n" + "public divName4Edit = \"divEdit\";  //编辑区的Id");

                strCodeForCs.Append("\r\n" + "constructor(objShowList: IShowList|null) {");
                strCodeForCs.Append("\r\n" + "this.iShowList = objShowList;");
                strCodeForCs.AppendFormat("\r\n" + "{0}.objPageEdit = this;", ThisClsName);
                strCodeForCs.AppendFormat("\r\n" + "this.obj{0} = new cls{0}EN();", this.TabName_In4Edit4GC);

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "");

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (string.IsNullOrEmpty(objvFunction4GeneCodeEN.CodeText) == false)
                    {
                        strCodeForCs.Append("\r\n" + objvFunction4GeneCodeEN.CodeText);
                    }
                }
                strFuncName = "clsPubFun4GC.Gen_WApi_Ts_ControlProperty";
                clsPubFun4GC.Gen_WApi_Ts_ControlProperty(strCodeForCs, arrPropertyDef4GC, $"divVarSet.refDivEdit", this, this.strBaseUrl);
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
                            strCodeForCs.Append("\r\n" + "const strValue:string = sessionStorage.getItem(strKey) as string;");
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

        public string Gen_WApi_Ts_SetKeyReadOnly()
        {
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
                        strCodeForCs.Append("\r\n" + "/**");
                        strCodeForCs.Append("\r\n" + "*  在用户自定义控件中,设置关键字的值,是否只读");
                        strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + " * @param bolReadonly:是否只读");
                        strCodeForCs.Append("\r\n" + " **/");
                        strCodeForCs.Append("\r\n" + "public SetKeyReadOnly(bolReadonly:boolean)");
                        strFuncName = $"SetKeyReadOnly";
                        strCodeForCs.Append("\r\n" + "{");
                        //                        strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SetKeyReadOnly.name;",
                        //this.TabName_In4Edit4GC, objKeyField.FldName);

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
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + " * 清除用户自定义控件中,所有控件的值");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public Clear()");
                strCodeForCs.Append("\r\n" + "{");
                //                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Clear.name;",
                //this.TabName_In4Edit4GC, objKeyField.FldName);

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13) continue;
                    if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14) continue;

                    if (objEditRegionFldsEx.InUse == false) continue;
                    
                    if (objEditRegionFldsEx.CtlTypeId == enumCtlType.DefaultValue_36) continue;
                    if (objEditRegionFldsEx.CtlTypeId == enumCtlType.ViewVariable_38) continue;
                    
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
                            ParentDivName = $"divVarSet.refDivEdit"
                        });
                        if (this.objViewInfoENEx.objCodeType == null)
                        {
                            this.objViewInfoENEx.objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(this.objViewInfoENEx.CodeTypeId);
                        }
                        string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue == null || objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
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

                                strCodeForCs.AppendFormat("\r\n" + " ClearSelectValueByIdInDivObj(divVarSet.refDivEdit, \"{1}\");", ThisClsName, objEditRegionFldsEx.CtrlId);
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
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue == null || objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
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
                        string strMsg = string.Format("生成字段:{0}时出错!{1}(In {2})", objEditRegionFldsEx.FldName,
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

        public string Gen_WApi_Ts_AddNewRecord()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                //生成的插入记录准备过程代码for C#

                strCodeForCs.Append("\r\n /** 为插入记录做准备工作");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async AddNewRecord()",
                this.TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddNewRecord.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);

                List<string> arrKey = new List<string>() { enumPrimaryType.Identity_02,
                enumPrimaryType.StringAutoAddPrimaryKey_03,
                enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06,
                enumPrimaryType.PrimaryKey_01 };

                if (arrKey.Contains(objKeyField.PrimaryTypeId) == false)
                {
                    if (objViewInfoENEx.arrEditRegionFldSet4InUse.Where(x => x.FldName == objKeyField.ObjFieldTabENEx.FldName).Count() > 0)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "this.SetKeyReadOnly(false);",
                    this.TabName_In4Edit4GC);
                    }
                }


                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "button",
                    CtrlId = string.Format("btnSubmit{0}", this.TabName_In4Edit4GC),
                    PropertyName = string.Format("btnSubmit{0}", this.TabName_In4Edit4GC),
                    Comment = "设置确定按钮的标题(Used In AddNewRecord())",
                    DataType = "string",
                    ParentDivName = $"divVarSet.refDivEdit",
                    ThisClsName = ThisClsName,
                });

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "button",
                    CtrlId = string.Format("btnCancel{0}", this.TabName_In4Edit4GC),
                    RefVarName = "strCancelButtonText",
                    PropertyName = string.Format("btnCancel{0}", this.TabName_In4Edit4GC),
                    Comment = "设置取消按钮的标题(Used In AddNewRecord())",
                    DataType = "string",
                    ParentDivName = $"divVarSet.refDivEdit",
                    ThisClsName = ThisClsName,
                });

                strCodeForCs.Append("\r\n" + "this.Clear();");

                //获取最大值
                strCodeForCs.AppendFormat("\r\n" + "//wuc{0}B1.{1} = {0}GetMaxStrId_S();",
                this.TabName_In4Edit4GC, objKeyField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objKeyField.ObjFieldTabENEx.FldLength);

                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + $"const returnString = await {thisWA_F_InEdit(WA_F.GetMaxStrIdAsync)}();");

                    strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为空,不成功,请检查!\");",
                        this.TabName_In4Edit4GC);

                    strCodeForCs.Append("\r\n" + "//显示信息框");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "$('#txt{0}').val(returnString);", objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch(e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"获取表关键字的最大值不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");

                }
                else if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06)
                {

                    if (objPrefixField == null)
                    {
                        strCodeForCs.AppendFormat("\r\n // 表:{0}的主键是前缀自增,但该表中没有一个相关的前缀字段。请检查!(In {1})",
                                this.TabName_In4Edit4GC, clsStackTrace.GetCurrClassFunction());

                    }

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    if (objPrefixField == null)
                    {
                        strCodeForCs.AppendFormat("\r\n // 表:{0}的主键是前缀自增,但该表中没有一个相关的前缀字段。请检查!(In {1})",
                                this.TabName_In4Edit4GC, clsStackTrace.GetCurrClassFunction());

                        strCodeForCs.Append("\r\n" + $"const returnString = await {thisWA_F_InEdit(WA_F.GetMaxStrIdByPrefixAsync)}(\"\");");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"const returnString = await {thisWA_F_InEdit(WA_F.GetMaxStrIdByPrefixAsync)}({ThisClsName}.{objPrefixField.FldName}4PrefixStatic);");
                    }

                    strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为空,不成功,请检查!\");",
                        this.TabName_In4Edit4GC);

                    strCodeForCs.Append("\r\n" + "//显示信息框");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "$('#txt{0}').val(returnString);", objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch(e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"获取表关键字的最大值不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");

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


        //生成插入记录准备过程代码
        public string Gen_WApi_Ts_AddNewRecordWithMaxId()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                //生成的插入记录准备过程代码for C#

                strCodeForCs.Append("\r\n /** 为插入记录做准备工作");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public AddNewRecordWithMaxId()",
                this.TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddNewRecordWithMaxId.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);

                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY && objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    if (objViewInfoENEx.arrEditRegionFldSet4InUse.Where(x => x.FldName == objKeyField.ObjFieldTabENEx.FldName).Count() > 0)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "this.SetKeyReadOnly(false);",
                        this.TabName_In4Edit4GC);
                    }
                }


                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "button",
                    CtrlId = string.Format("btnSubmit{0}", this.TabName_In4Edit4GC),
                    PropertyName = string.Format("btnSubmit{0}", this.TabName_In4Edit4GC),
                    Comment = "设置确定按钮的标题(Used In AddNewRecordWithMaxId())",
                    DataType = "string",
                    ThisClsName = ThisClsName,
                });

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "button",
                    CtrlId = string.Format("btnCancel{0}", this.TabName_In4Edit4GC),
                    RefVarName = "strCancelButtonText",
                    PropertyName = string.Format("btnCancel{0}", this.TabName_In4Edit4GC),
                    Comment = "设置取消按钮的标题(Used In AddNewRecordWithMaxId())",
                    DataType = "string",
                    ThisClsName = ThisClsName,
                });

                strCodeForCs.Append("\r\n" + "this.Clear();");

                //获取最大值
                strCodeForCs.AppendFormat("\r\n" + "//wuc{0}B1.{1} = {0}GetMaxStrId_S();",
                this.TabName_In4Edit4GC, objKeyField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objKeyField.ObjFieldTabENEx.FldLength);

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
        public void iShowList_BindGv(StringBuilder strCode, string strReturnVar)
        {
            if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
            {
                strCode.AppendFormat("\r\n" + "if (this.iShowList != null) this.iShowList.BindGvCache(cls{0}EN._CurrTabName, {1});",
                    this.TabName_In4Edit4GC, strReturnVar);
            }
            else
            {
                strCode.AppendFormat("\r\n" + "if (this.iShowList != null) this.iShowList.BindGv(cls{0}EN._CurrTabName, {1});",
                    this.TabName_In4Edit4GC, strReturnVar);
            }
        }
        private void await_iShowList_BindGv(StringBuilder strCode)
        {
            if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
            {
                strCode.AppendFormat("\r\n" + "if (this.iShowList != null) const conShowList = await this.iShowList.BindGvCache(cls{0}EN._CurrTabName, \"\");", this.TabName_In4Edit4GC);
            }
            else
            {
                strCode.AppendFormat("\r\n" + "if (this.iShowList != null) const conShowList = await this.iShowList.BindGv(cls{0}EN._CurrTabName, \"\");", this.TabName_In4Edit4GC);
            }
        }
        public string Gen_WApi_Ts_btnOKUpd_Click()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:事件函数,当单击<确定修改>时发生的事件函数,");
                strCodeForCs.Append("\r\n * 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public async btnSubmit_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnSubmit_Click.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const strCommandText: string = this.btnSubmit{0};", this.TabName_In4Edit4GC);

                clsPropertyDef4GC objPropertyDef4GC = new clsPropertyDef4GC
                {
                    OperateType = "get",
                    ControlType = "button",
                    CtrlId = string.Format("btnSubmit{0}", this.TabName_In4Edit4GC),
                    PropertyName = string.Format("btnSubmit{0}", this.TabName_In4Edit4GC),
                    Comment = "获取按钮的标题",
                    DataType = "string",
                    ParentDivName = $"divVarSet.refDivEdit",
                    ThisClsName = ThisClsName,
                };
                arrPropertyDef4GC.Add(objPropertyDef4GC);

                strCodeForCs.Append("\r\n" + "try {");
                //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN;",
                //this.TabName_In4Edit4GC, this.TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + "let returnBool = false;");
                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06
                    || objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03
                    )
                {
                    strCodeForCs.Append("\r\n" + "let returnKeyId = \"\";");
                }
                else if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
                {
                    strCodeForCs.Append("\r\n" + "const returnKeyId = 0;");
                }
                else
                {
                    if (objKeyField.CsType != "string")
                    {

                        strCodeForCs.Append("\r\n" + "//let returnKeyId = \"\";");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "let returnKeyId = \"\";");
                    }
                }
                strCodeForCs.Append("\r\n" + "let strInfo = \"\";");
                strCodeForCs.Append("\r\n" + "let strMsg = \"\";");

                strCodeForCs.Append("\r\n" + "switch(strCommandText)");
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objViewRegion_Feature.IsHaveAddNewRecord())
                {

                    strCodeForCs.Append("\r\n" + "case \"添加\":");
                    strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit{0} = \"确认添加\";", this.TabName_In4Edit4GC);
                    strCodeForCs.AppendFormat("\r\n" + "this.btnCancel{0} = \"取消添加\";", this.TabName_In4Edit4GC);

                    strCodeForCs.AppendFormat("\r\n" + " await this.AddNewRecord();",
                    this.TabName_In4Edit4GC);
                    strCodeForCs.Append("\r\n" + "break;				");
                    strCodeForCs.Append("\r\n" + "case \"确认添加\":");
                    strCodeForCs.Append("\r\n" + "//这是一个单表的插入的代码,由于逻辑层太简单,");
                    strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");
                    strCodeForCs.Append("\r\n" + "if (this.opType == \"AddWithMaxId\")");
                    strCodeForCs.Append("\r\n" + "{");
                    if (objKeyField.CsType != "string")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "//const returnKeyId = await this.AddNewRecordWithMaxIdSave();",
                              this.TabName_In4Edit4GC);
                        //strCodeForCs.Append("\r\n" + "//const returnKeyId: string = <string>jsonData;");
                        strCodeForCs.Append("\r\n" + "//if (IsNullOrEmpty(returnKeyId) == false)");
                        strCodeForCs.Append("\r\n" + "//{");
                        strCodeForCs.AppendFormat("\r\n" + "//HideDialog_{0}();", this.TabName_In4Edit4GC);

                        strCodeForCs.AppendFormat("\r\n" + "//if (this.iShowList != null) this.iShowList.BindGvCache(cls{0}EN._CurrTabName, \"\");", this.TabName_In4Edit4GC);

                        strCodeForCs.Append("\r\n" + "//}");
                        //strCodeForCs.Append("\r\n" + "//});");

                    }
                    else if (thisEditTabProp_TS.KeyFldCount == 1)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "returnKeyId = await this.AddNewRecordWithMaxIdSave();",
                              this.TabName_In4Edit4GC);
                        //strCodeForCs.Append("\r\n" + "const returnKeyId: string = <string>jsonData;");
                        strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
     ThisClsName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "this.HideDialog_{0}();", this.TabName_In4Edit4GC);
                        strCodeForCs.Append("\r\n" + "}");
                        //strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", this.TabName_In4Edit4GC, PrjTabEx_ListRegion.IsUseCache_TS()?"Cache":"");

                        iShowList_BindGv(strCodeForCs, "returnKeyId");

                        strCodeForCs.Append("\r\n" + "}");
                        //strCodeForCs.Append("\r\n" + "});");
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "returnBool = await this.AddNewRecordSave();",
                          this.TabName_In4Edit4GC);
                    //strCodeForCs.Append("\r\n" + "const returnBool: boolean = jsonData;");
                    strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                    ThisClsName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "this.HideDialog_{0}();", this.TabName_In4Edit4GC);
                    strCodeForCs.Append("\r\n" + "}");
                    //strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", this.TabName_In4Edit4GC, PrjTabEx_ListRegion.IsUseCache_TS()? "Cache" : "");
                    iShowList_BindGv(strCodeForCs, "returnBool.toString()");

                    strCodeForCs.Append("\r\n" + "}");
                    //strCodeForCs.Append("\r\n" + "});");
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n" + "break;");
                }
                if (objViewInfoENEx.objViewRegion_Feature.IsHaveUpdateRecord())
                {
                    strCodeForCs.Append("\r\n" + "case \"确认修改\":");
                    strCodeForCs.Append("\r\n" + "//这是一个单表的修改的代码,由于逻辑层太简单,");
                    //strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = (cls{0}EN) Session[\"obj{0}EN\"];",
                    //this.TabName_In4Edit4GC);
                    strCodeForCs.AppendFormat("\r\n" + "returnBool = await this.UpdateRecordSave();",
                    this.TabName_In4Edit4GC);
                    //strCodeForCs.Append("\r\n" + "const returnBool: boolean = jsonData;");
                    strCodeForCs.Append("\r\n" + "strInfo = returnBool ? \"修改成功!\" : \"修改不成功!\";");
                    strCodeForCs.AppendFormat("\r\n" + "strInfo += \"(In {0}.btnSubmit_Click)\";",
                        ThisClsName);
                    //strCodeForCs.Append("\r\n" + "$('#l1blResult51').val(strInfo);");
                    strCodeForCs.Append("\r\n" + "//显示信息框");
                    strCodeForCs.Append("\r\n" + "//console.log(strInfo);");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");

                    strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
         ThisClsName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "this.HideDialog_{0}();", this.TabName_In4Edit4GC);
                    strCodeForCs.Append("\r\n" + "}");
                    //strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", this.TabName_In4Edit4GC, PrjTabEx_ListRegion.IsUseCache_TS()? "Cache" : "");
                    iShowList_BindGv(strCodeForCs, "returnBool.toString()");

                    strCodeForCs.Append("\r\n" + "}");
                    //strCodeForCs.Append("\r\n" + "});");
                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.Append("\r\n" + "default:");
                    strCodeForCs.Append("\r\n" + "strMsg = Format(\"strCommandText:{0}在switch中没有处理!(In btnSubmit_Click())\", strCommandText);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "break;");
                }
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"(errid: WiTsCs0033)在保存记录时({3})时出错!请联系管理员!{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName, strCommandText);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
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

            strCodeForCs.Append("\r\n * @param divContainer\">显示容器</param>");
            strCodeForCs.AppendFormat("\r\n * @param obj{0}\">需要显示的对象</param>",
                this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public Show{0}Obj(divContainer: HTMLDivElement, obj{0}: cls{0}EN) ",
                this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Show{0}Obj.name;", this.TabName_In4Edit4GC, objKeyField.FldName);


            strCodeForCs.Append("\r\n" + "if (divContainer == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}不存在!\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const sstrKeys = GetObjKeys(obj{0});",
                this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "const ul: HTMLUListElement = document.createElement(\"ul\");");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}.GetFldValue(strKey);",
                this.TabName_In4Edit4GC);
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

        public string Gen_WApi_Ts_UpdateRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            string strBy = objKeyField.FldName;
            if (thisEditTabProp_TS.KeyFldCount > 1) strBy = "KeyLst";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据关键字获取相应的记录的对象");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param sender\">参数列表</param>");
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public async UpdateRecord({0}):Promise<boolean> ",
            thisEditTabProp_TS.KeyVarDefineLstStr);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.UpdateRecord.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = string.Format("btnSubmit{0}", this.TabName_In4Edit4GC),
                PropertyName = string.Format("btnSubmit{0}", this.TabName_In4Edit4GC),
                Comment = "设置确定按钮的标题(Used In UpdateRecord())",
                DataType = "string",
                ParentDivName = $"divVarSet.refDivEdit",
                ThisClsName = ThisClsName,
            });

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = string.Format("btnCancel{0}", this.TabName_In4Edit4GC),
                PropertyName = string.Format("btnCancel{0}", this.TabName_In4Edit4GC),
                RefVarName = "strCancelButtonText",
                Comment = "设置取消按钮的标题(Used In UpdateRecord())",
                DataType = "string",
                ParentDivName = $"divVarSet.refDivEdit",
                ThisClsName = ThisClsName,
            });

            //strCodeForCs.AppendFormat("\r\n" + "//$('#hidKeyId').val({0});", objKeyField.PrivFuncName);
            if (objKeyField.IsNumberType())
            {
                strCodeForCs.AppendFormat("\r\n" + "this.keyId = {0}.toString();", objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.keyId = {0};", objKeyField.PrivFuncName);
            }

            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            //strCodeForCs.AppendFormat("\r\n" + "const strKeyId: string = $('#txtstrKeyId{0}').val();",
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

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + $"const obj{TabName_In4Edit4GC}ENConst = await {thisWA_F_InEdit(WA_F.GetObjByKeyId)}({2});");

            strCodeForCs.AppendFormat("\r\n" + "       if (obj{0}ENConst == null)", this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "        {");

            strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"根据关键字获取相应的记录的对象为空.(in {0}.{1})\", this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "            alert(strMsg);");
            strCodeForCs.Append("\r\n" + "            return false;");
            strCodeForCs.Append("\r\n" + "        }");

            strCodeForCs.AppendFormat("\r\n" + "this.obj{0} = obj{0}ENConst;", this.TabName_In4Edit4GC);

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据关键字:[{{0}}]获取对象：{{1}}!\", strKeyId, obj{0}EN.{1});",
            //    this.TabName_In4Edit4GC,
            //    objKeyField.FldName);

            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "const conGetDataFromClass = await   this.GetDataFrom{0}Class(obj{0}ENConst);",
                this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成UpdateRecord!\");", this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "return true;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;");

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
        Func<clsEditRegionFldsENEx, ASPDropDownListEx> GetDdlObj = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        public string Gen_WApi_Ts_SetBindDdl()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                List<string> arrDropDownTypeLst = new List<string> { enumCtlType.DropDownList_06, enumCtlType.DropDownList_Bool_18 };
                IEnumerable<clsEditRegionFldsENEx> arrERF4DropDownLst = objViewInfoENEx.arrEditRegionFldSet4InUse.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                List<ASPDropDownListEx> arrASPDropDownListObj = arrERF4DropDownLst.Select(GetDdlObj).ToList();

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj)
                {
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true) continue;
                    clsTabFeatureEN objTabFeature = clsTabFeatureBL.GetObjByTabFeatureIdCache(objInfor.TabFeatureId4Ddl, objInfor.PrjId);
                    //var arrTabFeatureFlds = clsTabFeatureFldsBLEx.GetObjLstByTabFeatureIdCache(objTabFeature.TabFeatureId, objInfor.PrjId);

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

                    if (objInfor.CsType == "bool")
                    {
                        objInfor.DivName = $"divVarSet.refDivEdit";
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
                        objInfor.DivName = $"divVarSet.refDivEdit";
                        objInfor.objTabFeature = objTabFeature;
                        strCodeForCs.Append(objInfor.GC_SetBindDdl4TabFeature4QueryEdit_TS(this.IsFstLcase, $"divVarSet.refDivEdit", objCacheClassify_TS, arrTabFeatureFlds_Cond, arrCondFldId, null, "", objViewInfoENEx.ViewId, this, this.strBaseUrl));
                    }
                    else
                    {

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


        public string Gen_WApi_Ts_SelectRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            string strBy = objKeyField.FldName;
            if (thisEditTabProp_TS.KeyFldCount > 1) strBy = "KeyLst";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ");
            strCodeForCs.Append("\r\n " + "* 根据关键字选择相应的记录");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param sender\">参数列表</param>");
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public async SelectRecord({0}: {1}) ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SelectRecord.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);

            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            //strCodeForCs.AppendFormat("\r\n" + "const strKeyId: string = $('#txtstrKeyId{0}').val();",
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

            strCodeForCs.Append("\r\n" + $"const obj{TabName_In4Edit4GC}EN = await {thisWA_F_InEdit(WA_F.GetObjByKeyId)}({objKeyField.PrivFuncName});");

            strCodeForCs.AppendFormat("\r\n" + "       if (obj{0}ENConst == null)", this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "        {");

            strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"根据关键字获取相应的记录的对象为空.(in {0}.{1})\", this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "            alert(strMsg);");
            strCodeForCs.Append("\r\n" + "            return false;");
            strCodeForCs.Append("\r\n" + "        }");

            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"完成SelectRecord!\", obj{0}EN);", this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "Redirect(\"/Index/Main_{0}\");", this.TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
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

        public string Gen_WApi_Ts_btnUpdateRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            List<string> arrFeatureId = new List<string>() { enumPrjFeature.UpdateRecord_0137, enumPrjFeature.UpdateRecord_0199 };
            var objFeatureRegionFlds_Update = objViewInfoENEx.arrFeatureRegionFlds.Find(x => arrFeatureId.Contains(x.FeatureId));

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 修改记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            if (thisEditTabProp_TS.KeyFldCount > 1)
            {
                strCodeForCs.Append("\r\n" + "public async btnUpdateRecord_Click(objKeyLst: any) {");

                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnUpdateRecord_Click.name;",
    this.TabName_In4Edit4GC, objKeyField.FldName);
                //const strUserCodeId = objKeyLst.AAA;
                //const strMachineName = objKeyLst.BBB;
                foreach (var objInFor in PrjTabEx_EditRegion.arrKeyFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const {0} = objKeyLst.{1};",
                        objInFor.ObjFieldTab0().PrivFuncName(), objInFor.ObjFieldTab0().PropertyName(this.IsFstLcase));
                }

                if (objFeatureRegionFlds_Update == null
                    || string.IsNullOrEmpty(objFeatureRegionFlds_Update.KeyIdGetModeId)
                    || objFeatureRegionFlds_Update.KeyIdGetModeId == enumGCKeyIdGetMode.ListCheckedRecord_0001)
                {
                    foreach (var objInFor in PrjTabEx_EditRegion.arrKeyFldSet)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}) == true)", objInFor.ObjFieldTab0().PrivFuncName());
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "const strMsg = \"修改记录的关键字为空,请检查!\";");
                        strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                        strCodeForCs.Append("\r\n" + "alert(strMsg);");
                        strCodeForCs.Append("\r\n" + "return;");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                else if (objFeatureRegionFlds_Update.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
                {
                    foreach (var objInFor in PrjTabEx_EditRegion.arrKeyFldSet)
                    {

                        if (objKeyField.IsNumberType() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)", objInFor.ObjFieldTab0().PrivFuncName());
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if ({0} == \"\")", objInFor.ObjFieldTab0().PrivFuncName());
                        }
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "alert(\"请选择需要修改的记录!\");");
                        strCodeForCs.Append("\r\n" + "return;");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
            }
            else
            {
                strCodeForCs.Append("\r\n" + "public async btnUpdateRecord_Click(strKeyId: string) {");

                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnUpdateRecord_Click.name;",
    this.TabName_In4Edit4GC, objKeyField.FldName);
                //strCodeForCs.Append("\r\n" + "$('#hidOpType').val(\"Update\");");

                if (objFeatureRegionFlds_Update == null
                    || string.IsNullOrEmpty(objFeatureRegionFlds_Update.KeyIdGetModeId)
                    || objFeatureRegionFlds_Update.KeyIdGetModeId == enumGCKeyIdGetMode.ListCheckedRecord_0001)
                {
                    strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(strKeyId) == true)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = \"修改记录的关键字为空,请检查!\";");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objFeatureRegionFlds_Update.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
                {

                    if (objKeyField.IsNumberType() == true)
                    {
                        strCodeForCs.Append("\r\n" + "    if (strKeyId == 0)");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
                    }
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(\"请选择需要修改的记录!\");");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            strCodeForCs.Append("\r\n" + "try {");
            strCodeForCs.AppendFormat("\r\n" + "if (this.bolIsLoadEditRegion == false)  //", ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const responseBool = await this.AddDPV_Edit(divVarSet.refDivEdit);");
            strCodeForCs.Append("\r\n" + "this.opType = \"Update\";");

            strCodeForCs.Append("\r\n // 为编辑区绑定下拉框");
            //strCodeForCs.Append("\r\n" + "if (this.b1olIsUseInDiv == true)");
            //strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const conBindDdl = await this.BindDdl4EditRegionInDiv();", ThisClsName);
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "else");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "const conBindDdl = await this.BindDdl4EditRegion();", ThisClsName);
            //strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "this.SetEventFunc();");
            strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadEditRegion = true;  //", ThisClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit{0} = \"确认修改\";", this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel{0} = \"取消修改\";", this.TabName_In4Edit4GC);

            if (thisEditTabProp_TS.KeyFldCount == 1)
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                    strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord(lngKeyId);",
                     thisEditTabProp_TS.KeyPrivVarNameLstStr);
                }
                else
                {

                    strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord(strKeyId);",
                        thisEditTabProp_TS.KeyPrivVarNameLstStr);
                }
            }
            else
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");
                    strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord(lngKeyId);",
                     thisEditTabProp_TS.KeyPrivVarNameLstStr);
                }
                else
                {

                    strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord({0});",
                        thisEditTabProp_TS.KeyPrivVarNameLstStr);
                }
            }
            strCodeForCs.Append("\r\n" + "if (update == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"在修改记录时,显示记录数据不成功!\");");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Update');", this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "this.opType = \"Update\";");
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit{0} = \"确认修改\";", this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel{0} = \"取消修改\";", this.TabName_In4Edit4GC);
            if (thisEditTabProp_TS.KeyFldCount == 1)
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                    strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord(lngKeyId);",
                     this.TabName_In4Edit4GC, this.TabName_In4Edit4GC.ToLower());
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord(strKeyId);",
                        thisEditTabProp_TS.KeyPrivVarNameLstStr);
                }
            }
            else
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                    strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord(lngKeyId);",
                     this.TabName_In4Edit4GC, this.TabName_In4Edit4GC.ToLower());
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord({0});",
                        thisEditTabProp_TS.KeyPrivVarNameLstStr);
                }
            }
            strCodeForCs.Append("\r\n" + "if (update == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"在修改记录时,显示记录数据不成功!\");");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                ThisClsName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Update');", this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"(errid: WiTsCs0034)在修改记录时出错!请联系管理员!{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
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



        public string Gen_WApi_Ts_btnUpdateRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 在数据表里修改记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            if (thisEditTabProp_TS.KeyFldCount > 1)
            {
                strCodeForCs.Append("\r\n" + "public async btnUpdateRecordInTab_Click(objKeyLst: any) {");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnUpdateRecordInTab_Click.name;",
                        this.TabName_In4Edit4GC, objKeyField.FldName);
                foreach (var objInFor in PrjTabEx_EditRegion.arrKeyFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const {0} = objKeyLst.{1};",
                        objInFor.ObjFieldTab0().PrivFuncName(), objInFor.ObjFieldTab0().PropertyName(this.IsFstLcase));
                }
                //strCodeForCs.Append("\r\n" + "$('#hidOpType').val(\"Update\");");
                foreach (var objInFor in PrjTabEx_EditRegion.arrKeyFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty({0}) == true)", objInFor.ObjFieldTab0().PrivFuncName());
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = \"修改记录的关键字为空,请检查!\";");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            else
            {
                strCodeForCs.Append("\r\n" + "public async btnUpdateRecordInTab_Click(strKeyId:string) {");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnUpdateRecordInTab_Click.name;",
                        this.TabName_In4Edit4GC, objKeyField.FldName);

                //strCodeForCs.Append("\r\n" + "$('#hidOpType').val(\"Update\");");

                strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"请选择需要修改的记录!\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + "try {");
            strCodeForCs.AppendFormat("\r\n" + "if (this.bolIsLoadEditRegion == false)  //", ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const responseBool = await this.AddDPV_Edit(divVarSet.refDivEdit);");
            strCodeForCs.Append("\r\n" + "this.opType = \"Update\";");

            strCodeForCs.Append("\r\n // 为编辑区绑定下拉框");
            //strCodeForCs.Append("\r\n" + "if (this.b1olIsUseInDiv == true)");
            //strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const conBindDdl = await this.BindDdl4EditRegionInDiv();", ThisClsName);
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "else");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "const conBindDdl = await this.BindDdl4EditRegion();", ThisClsName);
            //strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "this.SetEventFunc();");

            strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadEditRegion = true;  //", ThisClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit{0} = \"确认修改\";", this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel{0} = \"取消修改\";", this.TabName_In4Edit4GC);
            if (thisEditTabProp_TS.KeyFldCount == 1)
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                    strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(lngKeyId);",
                     this.TabName_In4Edit4GC, this.TabName_In4Edit4GC.ToLower());
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(strKeyId);",
                        this.TabName_In4Edit4GC, this.TabName_In4Edit4GC.ToLower());
                }
            }
            else
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");
                    strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord(lngKeyId);",
                     thisEditTabProp_TS.KeyPrivVarNameLstStr);
                }
                else
                {

                    strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord({0});",
                        thisEditTabProp_TS.KeyPrivVarNameLstStr);
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Update');", this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "this.opType = \"Update\";");
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit{0} = \"确认修改\";", this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel{0} = \"取消修改\";", this.TabName_In4Edit4GC);
            if (thisEditTabProp_TS.KeyFldCount == 1)
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                    strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(lngKeyId);",
                     this.TabName_In4Edit4GC, this.TabName_In4Edit4GC.ToLower());
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(strKeyId);",
                        this.TabName_In4Edit4GC, this.TabName_In4Edit4GC.ToLower());
                }
            }
            else
            {
                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                    strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord(lngKeyId);",
                     this.TabName_In4Edit4GC, this.TabName_In4Edit4GC.ToLower());
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord({0});",
                        thisEditTabProp_TS.KeyPrivVarNameLstStr);
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Update');", this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"(errid: WiTsCs0034)在修改记录时出错!请联系管理员!{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
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

        /// <summary>
        /// 添加记录保存函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_Ts_AddNewRecordSave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 添加新记录,保存函数");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async AddNewRecordSave(): Promise<boolean>{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddNewRecordSave.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);

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

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = new cls{0}EN();",
               this.TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + $"await {ThisClsName}.EditObj.PutDataTo{this.TabName_In4Edit4GC}Class(obj{this.TabName_In4Edit4GC}EN);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"从界面获取数据不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + $"{thisWA_F_InEdit(WA_F.CheckPropertyNew)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"检查数据不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "//检查唯一性条件");
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objViewInfoENEx.objMainPrjTab.arrPrjConstraintSet())
            {

                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = $"_V{intVerCount}"; intVerCount++;

                strCodeForCs.Append("\r\n" + $"const bolIsExistCond{strVersion} = await this.CheckUniCond4Add(obj{TabName_In4Edit4GC}EN);");
                strCodeForCs.Append("\r\n" + $"if (bolIsExistCond{strVersion} == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + "let returnBool = false;");

            if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
            {
                strCodeForCs.Append("\r\n" + $"returnBool = await {thisWA_F_InEdit(WA_F.AddNewRecordAsync)}(obj{TabName_In4Edit4GC}EN);");
            }
            else if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                //strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(obj{0}EN.dnFuncMapId) == true)", this.TabName_In4Edit4GC);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const returnKeyId = await {thisWA_F_InEdit(WA_F.AddNewRecordWithMaxIdAsync)}(obj{TabName_In4Edit4GC}EN);");

                strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.keyId = returnKeyId;");
                strCodeForCs.Append("\r\n" + "returnBool = true;");
                strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n" + "}");

            }
            else if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06)
            {
                //strCodeForCs.Append("\r\n" + "let returnBool = false;");
                //strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(obj{0}EN.dnFuncMapId) == true)", this.TabName_In4Edit4GC);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"const returnKeyId = await {thisWA_F_InEdit(WA_F.AddNewRecordWithMaxIdAsync)}(obj{TabName_In4Edit4GC}EN);");

                strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "returnBool = true;");
                strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n" + "}");

            }
            else
            {
                if (thisEditTabProp_TS.KeyFldCount > 1)
                {
                    var arrTemp = thisEditTabProp_TS.PropertyNameLstrStr.Split(",".ToCharArray());
                    StringBuilder sbTemp = new StringBuilder();
                    foreach (string strInFor in arrTemp)
                    {
                        sbTemp.Append($"obj{TabName_In4Edit4GC}EN.{strInFor},");
                    }
                    strCodeForCs.Append("\r\n" + $"const bolIsExist = await {thisWA_F_InEdit(WA_F.IsExistAsync)}({sbTemp.ToString()});");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"const bolIsExist = await {thisWA_F_InEdit(WA_F.IsExistAsync)}(obj{TabName_In4Edit4GC}EN.{objKeyField.PropertyName(this.IsFstLcase)});");
                }
                strCodeForCs.Append("\r\n" + "if (bolIsExist == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"添加记录时,关键字：{{0}}已经存在!\", obj{0}EN.{1});",
                    this.TabName_In4Edit4GC, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值,否则会出错!");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"returnBool = await {thisWA_F_InEdit(WA_F.AddNewRecordAsync)}(obj{TabName_In4Edit4GC}EN);");

            }

            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            if (PrjTabEx_EditRegion.IsUseStoreCache_TS() == false)
            {
                Gene_ReFreshCache(strCodeForCs, "");
            }
            strCodeForCs.Append("\r\n" + $"const strInfo = `添加[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]记录成功!`;");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const strInfo = `添加[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]记录不成功!`;");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return returnBool;//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"添加记录不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值,否则会出错!");

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


        public string Gen_WApi_Ts_CheckUniCondition4Add(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            //if (objViewInfoENEx.objMainPrjTab.arrConstraintFieldsSet.Count == 0) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objViewInfoENEx.objMainPrjTab.arrPrjConstraintSet())
            {
                StringBuilder sbTemp_Func = new StringBuilder();
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = $"_V{intVerCount}"; intVerCount++;

                IEnumerable<clsConstraintFieldsEN> arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objViewInfoENEx.PrjId);

                sbTemp_Func.Append("\r\n /** 为添加记录检查唯一性条件");
                sbTemp_Func.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                sbTemp_Func.Append("\r\n" + " **/");
                sbTemp_Func.Append("\r\n" + $"public async CheckUniCond4Add{strVersion}(obj{TabName_In4Edit4GC}EN: cls{TabName_In4Edit4GC}EN): Promise<boolean>{{");
                strFuncName = $"CheckUniCond4Add{strVersion}";
                if (objInFor.IsNullable == true)
                {
                    foreach (var objField in arrObjLst_Flds)
                    {
                        var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(objInFor.TabId, objField.FldId, objViewInfoENEx.PrjId);
                        if (objPrjTabFld.IsTabNullable == false) continue;
                        sbTemp_Func.AppendFormat("\r\n" + "   if (IsNullOrEmpty(obj{0}EN.{1}) == true) return true;", this.TabName_In4Edit4GC, objField.ObjFieldTab().PropertyName(this.IsFstLcase));
                    }
                }

                sbTemp_Func.Append("\r\n" + $"const strUniquenessCondition = {thisWA_F_InEdit(WA_F.GetUniCondStr)}(obj{TabName_In4Edit4GC}EN);");
                ImportClass objImportClass = AddImportClass(this.TabId_In4Edit, this.TabName_In4Edit4GC, string.Format("GetUniCondStr", objInFor.ConstraintName4GC()), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                sbTemp_Func.Append("\r\n" + $"const bolIsExistCondition = await {thisWA_F_InEdit(WA_F.IsExistRecordAsync)}(strUniquenessCondition);");

                sbTemp_Func.Append("\r\n" + "if (bolIsExistCondition == true)");
                sbTemp_Func.Append("\r\n" + "{");
                if (String.IsNullOrEmpty(objInFor.ErrMsg) == false)
                {
                    sbTemp_Func.AppendFormat("\r\n" + "const strMsg = Format(\"{0}.满足条件：{{0}}的记录已经存在!\",  strUniquenessCondition);", objInFor.ErrMsg);
                }
                else
                {
                    sbTemp_Func.Append("\r\n" + "const strMsg = Format(\"不能满足唯一性条件。满足条件：{0}的记录已经存在!\", strUniquenessCondition);");
                }
                sbTemp_Func.Append("\r\n" + "console.error(strMsg);");
                sbTemp_Func.Append("\r\n" + "alert(strMsg);");
                sbTemp_Func.Append("\r\n" + "return false;");
                sbTemp_Func.Append("\r\n" + "}");
                sbTemp_Func.Append("\r\n" + "return true;");

                sbTemp_Func.Append("\r\n" + "}");

                clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
                {
                    Name = strFuncName,
                    CodeContent = sbTemp_Func.ToString(),
                    ElementType = CodeElementType.Method,
                    Modifiers = "public async",
                    ReturnType = "void",
                });
                if (strFuncName == "")
                {
                    string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                strCodeForCs.Append(sbTemp_Func.ToString());
            }
        
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_CheckUniCondition4Update(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objViewInfoENEx.objMainPrjTab.arrPrjConstraintSet())
            {
                StringBuilder sbTemp_Func = new StringBuilder();
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = $"_V{intVerCount}"; intVerCount++;


                IEnumerable<clsConstraintFieldsEN> arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objViewInfoENEx.PrjId);

                sbTemp_Func.Append("\r\n /** 为修改记录检查唯一性条件");
                sbTemp_Func.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                sbTemp_Func.Append("\r\n" + " **/");
                sbTemp_Func.Append("\r\n" + $"public async CheckUniCond4Update{strVersion}(obj{TabName_In4Edit4GC}EN: cls{TabName_In4Edit4GC}EN): Promise<boolean>{{");
                strFuncName = $"CheckUniCond4Update{strVersion}";
                if (objInFor.IsNullable == true)
                {
                    foreach (var objField in arrObjLst_Flds)
                    {
                        var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(objInFor.TabId, objField.FldId, objViewInfoENEx.PrjId);
                        if (objPrjTabFld.IsTabNullable == false) continue;
                        sbTemp_Func.AppendFormat("\r\n" + "   if (IsNullOrEmpty(obj{0}EN.{1}) == true) return true;", this.TabName_In4Edit4GC, objField.ObjFieldTab().PropertyName(this.IsFstLcase));
                    }
                }
                sbTemp_Func.Append("\r\n" + $"const strUniquenessCondition = {thisWA_F_InEdit(WA_F.GetUniCondStr4Update)}(obj{TabName_In4Edit4GC}EN);");
                ImportClass objImportClass = AddImportClass(this.TabId_In4Edit, this.TabName_In4Edit4GC, string.Format("GetUniCondStr4Update", objInFor.ConstraintName4GC()), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                sbTemp_Func.Append("\r\n" + $"const bolIsExistCondition = await {thisWA_F_InEdit(WA_F.IsExistRecordAsync)}(strUniquenessCondition);");

                sbTemp_Func.Append("\r\n" + "if (bolIsExistCondition == true)");
                sbTemp_Func.Append("\r\n" + "{");
                if (String.IsNullOrEmpty(objInFor.ErrMsg) == false)
                {
                    sbTemp_Func.AppendFormat("\r\n" + "const strMsg = Format(\"{0}.满足条件：{{0}}的记录已经存在!\",  strUniquenessCondition);", objInFor.ErrMsg);
                }
                else
                {
                    sbTemp_Func.Append("\r\n" + "const strMsg = Format(\"不能满足唯一性条件。满足条件：{0}的记录已经存在!\", strUniquenessCondition);");
                }
                sbTemp_Func.Append("\r\n" + "console.error(strMsg);");
                sbTemp_Func.Append("\r\n" + "alert(strMsg);");
                sbTemp_Func.Append("\r\n" + "return false;");
                sbTemp_Func.Append("\r\n" + "}");
                sbTemp_Func.Append("\r\n" + "return true;");

                sbTemp_Func.Append("\r\n" + "}");
                clsPubFun4GC.AddCodeElement_Method(this.objCodeElement_Class, new CodeElement
                {
                    Name = strFuncName,
                    CodeContent = sbTemp_Func.ToString(),
                    ElementType = CodeElementType.Method,
                    Modifiers = "public async",
                    ReturnType = "void",
                });
                if (strFuncName == "")
                {
                    string strMsg = string.Format("在生成函数:[{0}]时，函数名不能为空。(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                strCodeForCs.Append(sbTemp_Func.ToString());
            }
   
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 添加记录保存函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_Ts_AddNewRecordWithMaxIdSave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            if (thisEditTabProp_TS.KeyFldCount > 1) return "";

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 添加新记录,由后台自动获取最大值的关键字。保存函数");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async AddNewRecordWithMaxIdSave(): Promise<string>{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddNewRecordWithMaxIdSave.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);

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
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = new cls{0}EN();", this.TabName_In4Edit4GC);
            ImportClass objImportClass = AddImportClass(this.TabId_In4Edit, this.TabName_In4Edit4GC, string.Format("cls{0}EN", this.TabName_In4Edit4GC), enumImportObjType.ENClass, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.PutDataTo{0}Class(obj{0}EN);",
                  this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"从界面获取数据不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "throw(strMsg);//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"{thisWA_F_InEdit(WA_F.CheckPropertyNew)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"检查数据不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "throw(strMsg);//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
            {

            }
            else
            {

            }
            strCodeForCs.Append("\r\n" + "//检查唯一性条件");
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objViewInfoENEx.objMainPrjTab.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = $"_V{intVerCount}"; intVerCount++;

                strCodeForCs.Append("\r\n" + $"const bolIsExistCond{strVersion} = await this.CheckUniCond4Add{strVersion}(obj{TabName_In4Edit4GC}EN);");
                strCodeForCs.Append("\r\n" + $"if (bolIsExistCond{strVersion} == false)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + $"const responseKeyId = await {thisWA_F_InEdit(WA_F.AddNewRecordWithMaxIdAsync)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.AppendFormat("\r\n" + "const returnKeyId: string = responseKeyId;",
                this.TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false)");
            ImportClass objImportClass2 = AddImportClass("", "/PubFun/clsString.js", "IsNullOrEmpty", enumImportObjType.CustomFunc, strBaseUrl);

            CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

            strCodeForCs.Append("\r\n" + "{");
            if (PrjTabEx_EditRegion.IsUseStoreCache_TS() == false)
            {
                Gene_ReFreshCache(strCodeForCs, "");
            }
            strCodeForCs.Append("\r\n" + $"const strInfo = `添加[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]记录成功!`;");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const strInfo = `添加[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]记录不成功!`;");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return responseKeyId;//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"添加记录不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "throw(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return \"\";//一定要有一个返回值,否则会出错!");

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


        public string Gen_WApi_Ts_btnAddNewRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 添加新记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnAddNewRecord_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnAddNewRecord_Click.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);
            //        strCodeForCs.Append("\r\n" + "//$('#hidOpType').val(\"Add\");");



            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "if (this.bolIsLoadEditRegion == false)  //", ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const responseBool = await this.AddDPV_Edit(divVarSet.refDivEdit);");
            strCodeForCs.Append("\r\n" + "this.opType = \"Add\";");

            strCodeForCs.Append("\r\n // 为编辑区绑定下拉框");
            //strCodeForCs.Append("\r\n" + "if (this.b1olIsUseInDiv == true)");
            //strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const conBindDdl = await this.BindDdl4EditRegionInDiv();", ThisClsName);
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "else");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "const conBindDdl = await this.BindDdl4EditRegion();", ThisClsName);
            //strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "this.SetEventFunc();");

            strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadEditRegion = true;  //", ThisClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit{0} = \"确认添加\";", this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel{0} = \"取消添加\";", this.TabName_In4Edit4GC);

            strCodeForCs.AppendFormat("\r\n" + "const responseText = this.AddNewRecord();",
                    this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Add');", this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "this.opType = \"Add\";");
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit{0} = \"确认添加\";", this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel{0} = \"取消添加\";", this.TabName_In4Edit4GC);

            strCodeForCs.AppendFormat("\r\n" + "await this.AddNewRecord();",
                this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Add');", this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"添加新记录初始化不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
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

        public string Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 添加新记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnAddNewRecordWithMaxId_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnAddNewRecordWithMaxId_Click.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);
            //        strCodeForCs.Append("\r\n" + "//$('#hidOpType').val(\"Add\");");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "if (this.bolIsLoadEditRegion == false)  //", ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const responseBool = await this.AddDPV_Edit(divVarSet.refDivEdit);");
            strCodeForCs.Append("\r\n" + "this.opType = \"AddWithMaxId\";");


            strCodeForCs.Append("\r\n // 为编辑区绑定下拉框");
            //strCodeForCs.Append("\r\n" + "if (this.b1olIsUseInDiv == true)");
            //strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "const conBindDdl = await this.BindDdl4EditRegionInDiv();", ThisClsName);
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "else");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "const conBindDdl = await this.BindDdl4EditRegion();", ThisClsName);
            //strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "this.SetEventFunc();");

            strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadEditRegion = true;  //", ThisClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit{0} = \"确认添加\";", this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel{0} = \"取消添加\";", this.TabName_In4Edit4GC);

            strCodeForCs.AppendFormat("\r\n" + "const responseText = this.AddNewRecordWithMaxId();",
                    this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Add');", this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "this.opType = \"AddWithMaxId\";");

            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit{0} = \"确认添加\";", this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel{0} = \"取消添加\";", this.TabName_In4Edit4GC);

            strCodeForCs.AppendFormat("\r\n" + "const responseText = this.AddNewRecordWithMaxId();",
                this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Add');", this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"添加新记录初始化不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
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
this.TabName_In4Edit4GC, objKeyField.FldName);

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
                this.TabName_In4Edit4GC);


            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + " $(strKeyCtrlName).val(returnString);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为：{{0}}!\", returnString);",
                this.TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + " $(strKeyCtrlName).val(returnString);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"获取表关键字的最大值不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
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


        public string Gen_WApi_Ts_UpdateRecordSave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 修改记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async UpdateRecordSave(): Promise<boolean> {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.UpdateRecordSave.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);

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

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = new cls{0}EN();",
           this.TabName_In4Edit4GC);

            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(Number(this.keyId));",
                    this.TabName_In4Edit4GC, objKeyField.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(this.keyId);",
                    this.TabName_In4Edit4GC, objKeyField.FldName);
            }

            strCodeForCs.AppendFormat("\r\n" + "await this.PutDataTo{0}Class(obj{0}EN);",
                this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.sfUpdFldSetStr = obj{0}EN.updFldString;//设置哪些字段被修改(脏字段)",
                this.TabName_In4Edit4GC);
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0 || obj{0}EN.{1} == undefined){{",
                this.TabName_In4Edit4GC, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.Append("\r\n" + "console.error(\"关键字不能为空!\");");
                strCodeForCs.Append("\r\n" + "throw \"关键字不能为空!\";");
                //strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == \"\" || obj{0}EN.{1} == undefined){{",
                        this.TabName_In4Edit4GC, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.Append("\r\n" + "console.error(\"关键字不能为空!\");");
                strCodeForCs.Append("\r\n" + "throw \"关键字不能为空!\";");
                //strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"{thisWA_F_InEdit(WA_F.CheckProperty4Update)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"检查数据不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值,否则会出错!");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//检查唯一性条件");
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objViewInfoENEx.objMainPrjTab.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = $"_V{intVerCount}"; intVerCount++;

                strCodeForCs.Append("\r\n" + $"const bolIsExistCond{strVersion} = await this.CheckUniCond4Update(obj{TabName_In4Edit4GC}EN);");
                strCodeForCs.AppendFormat("\r\n" + $"if (bolIsExistCond{strVersion} == false)", objInFor.ConstraintName4GC());
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F_InEdit(WA_F.UpdateRecordAsync)}(obj{TabName_In4Edit4GC}EN);");

            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            Gene_ReFreshCache(strCodeForCs, PrjTabEx_EditRegion.KeyPropNameLstStrWithObjName_TS);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return returnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"修改记录不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;");
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
        public string Gen_WApi_Ts_PutDataToClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /** 函1数功能:把界面上的属性数据传到类对象中");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param pobj{0}EN\">数据传输的目的类对象</param>",
                this.TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async PutDataTo{0}Class(pobj{2}EN: cls{1}EN)",
                this.TabName_In4Edit4GC, this.TabName_In4Edit4GC, this.TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + "{");
                //                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.PutDataTo{0}Class.name;",
                //this.TabName_In4Edit4GC, objKeyField.FldName);

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {

                    if (objEditRegionFldsEx.InUse == false)
                    {
                        if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14)
                        {
                            //string str1 = "";

                        }
                        else if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13)
                        {
                            //string str2 = "";
                        }
                        else
                        {
                            continue;
                        }
                    }

                    try
                    {
                        string strTemp = GetCode4FieldInPutDataToClass(objEditRegionFldsEx, objViewInfoENEx);
                        strCodeForCs.AppendFormat("{0}", strTemp);
                    }
                    catch (Exception objExceptionIn)
                    {
                        throw objExceptionIn;
                    }
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
        private string GetCode4FieldInPutDataToClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.CtlTypeId != enumCtlType.ViewVariable_38 )
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
                    ParentDivName = $"divVarSet.refDivEdit"
                });
            }
            if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14)
            {
                string strDefaUserIdExpress = clsPubFun4GC.GetDefaUserIdExpress(objViewInfoENEx.PrjId);
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2});",
                    this.TabName_In4Edit4GC,
                    objEditRegionFldsEx.FldName, strDefaUserIdExpress);
                var objGCVariable = clsGCVariableBLEx.GetObjByVarNameAndType("UserId", enumGCVariableType.localStorage_0003, objViewInfoENEx.PrjId);
                if (objGCVariable != null)
                {
                    ImportClass objImportClass = AddImportClass(objViewInfoENEx.MainTabId, objGCVariable.FilePath, objGCVariable.ClsName, enumImportObjType.CustomFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                }
            }
            else if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13)
            {
                string strCurrDateTimeExpress = clsPubFun4GC.GetCurrDateTimeExpress(objViewInfoENEx.PrjId);
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2});",
                    this.TabName_In4Edit4GC,
                    objEditRegionFldsEx.FldName, strCurrDateTimeExpress);
                ImportClass objImportClass = AddImportClass("", "/PubFun/clsDateTime.js", "clsDateTime", enumImportObjType.CustomFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            }
            else
            {
                string strVarName = "";
                clsGCVariableEN objVar = null;
                switch (objEditRegionFldsEx.CtlTypeId)
                {
                    case enumCtlType.CheckBox_02:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(this.{2});",
         this.TabName_In4Edit4GC,
         objEditRegionFldsEx.FldName, objEditRegionFldsEx.PropertyName(this.IsFstLcase),
         objEditRegionFldsEx.CtrlId);
                        break;
                    case enumCtlType.TextBox_16:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(this.{2});",
         this.TabName_In4Edit4GC,
         objEditRegionFldsEx.FldName, objEditRegionFldsEx.PropertyName(this.IsFstLcase),
         objEditRegionFldsEx.CtrlId);
                        break;
                    case enumCtlType.TextArea_41:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(this.{2});",
         this.TabName_In4Edit4GC,
         objEditRegionFldsEx.FldName, objEditRegionFldsEx.PropertyName(this.IsFstLcase),
         objEditRegionFldsEx.CtrlId);
                        break;
                    case enumCtlType.DropDownList_06:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(this.{2});",
         this.TabName_In4Edit4GC,
         objEditRegionFldsEx.FldName, objEditRegionFldsEx.PropertyName(this.IsFstLcase),
         objEditRegionFldsEx.CtrlId);
                        break;

                    case enumCtlType.DefaultValue_36:
                        if (objEditRegionFldsEx.ObjFieldTab().ObjDataTypeAbbr().IsNumberType() == true)
                        {
                            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2});",
         this.TabName_In4Edit4GC,
         objEditRegionFldsEx.FldName,
         objEditRegionFldsEx.DefaultValue);
                        }
                        else if (objEditRegionFldsEx.ObjFieldTab().DataTypeId == enumDataTypeAbbr.bit_03)
                        {
                            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2});",
         this.TabName_In4Edit4GC,
         objEditRegionFldsEx.FldName,
         objEditRegionFldsEx.DefaultValue);
                        }
                        else
                        {
                            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(\"{2}\");",
        this.TabName_In4Edit4GC,
        objEditRegionFldsEx.FldName,
         objEditRegionFldsEx.DefaultValue);
                        }

                        break;
                    case enumCtlType.ViewVariable_38:

                        objVar = clsGCVariableBL.GetObjByVarIdCache(objEditRegionFldsEx.VarId);
                        if (objVar != null)
                        {
                            strVarName = objVar.GetVarName4View();
                        }

                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({3});",
         this.TabName_In4Edit4GC,
         objEditRegionFldsEx.FldName,
         ThisClsName, strVarName);
                        if (string.IsNullOrEmpty(objVar.ClsName) == false)
                        {
                            ImportClass objImportClass = AddImportClass(objViewInfoENEx.MainTabId, objVar.FilePath, objVar.ClsName, enumImportObjType.CustomFunc, this.strBaseUrl);

                            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

                        }
                        break;
                    case enumCtlType.GivenValue_35:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}({2});",
         this.TabName_In4Edit4GC,
         objEditRegionFldsEx.FldName,
         thisCacheClassify4View.VarDef4Fld);
                        break;

                    default:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.Set{1}(this.{2});",
                this.TabName_In4Edit4GC,
                objEditRegionFldsEx.FldName, objEditRegionFldsEx.PropertyName(this.IsFstLcase),
                objEditRegionFldsEx.CtrlId);
                        break;
                }
                if (objVar != null && string.IsNullOrEmpty(objVar.ClsName) == false)
                {
                    ImportClass objImportClass = AddImportClass("", objVar.FilePath, objVar.ClsName, enumImportObjType.CustomFunc, this.strBaseUrl);

                    CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                    clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

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
                strCodeForCs.AppendFormat("\r\n * @param pobj{0}EN\">表实体类对象</param>",
                this.TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async GetDataFrom{0}Class(pobj{2}EN: cls{1}EN )",
                this.TabName_In4Edit4GC, this.TabName_In4Edit4GC, this.TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetDataFrom{0}Class.name;", this.TabName_In4Edit4GC, objKeyField.FldName);

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdDate_13) continue;
                    if (objEditRegionFldsEx.FieldTypeId(objViewInfoENEx.PrjId) == enumFieldType.Log_UpdUser_14) continue;

                    if (objEditRegionFldsEx.CtlTypeId == enumCtlType.DefaultValue_36) continue;
                    
                    if (objEditRegionFldsEx.CtlTypeId == enumCtlType.ViewVariable_38) continue;
                    

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
                                this.TabName_In4Edit4GC,
                                objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.GivenValue_35:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                this.TabName_In4Edit4GC,
                                objDetailRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.DropDownList_06:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                this.TabName_In4Edit4GC,
                                objDetailRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                this.TabName_In4Edit4GC,
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
            if (objEditRegionFldsEx.CtlTypeId != enumCtlType.ViewVariable_38 )
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
                    ParentDivName = $"divVarSet.refDivEdit"
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
                                this.TabName_In4Edit4GC,
                                objEditRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.GivenValue_35:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                this.TabName_In4Edit4GC,
                                objEditRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                case enumCtlType.DropDownList_06:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                this.TabName_In4Edit4GC,
                                objEditRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                this.TabName_In4Edit4GC,
                                objEditRegionFldsEx.PropertyName(this.IsFstLcase));
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
            }

            return sbCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_GetFirstKey()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:从界面列表中获取第一个关键字的值");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param pobj{0}EN\">表实体类对象</param>",
                this.TabName_In4Edit4GC);
                strCodeForCs.Append("\r\n * returns:列表的第一个关键字值</returns>");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public GetFirstKey(): string {");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetFirstKey.name;",
this.TabName_In4Edit4GC, objKeyField.FldName);

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

            //			string strTemp ;     ///临时变量;
            ///判断DataGrid是否需要排序

            try
            {
                ///生成插入记录的界面代码;
                //objViewInfoENEx.objViewRegion_List.StyleZindex() = intZIndex + 1;
                //objViewInfoENEx.objViewRegion_List.StyleLeft = (int)intCurrLeft;
                //objViewInfoENEx.objViewRegion_List.StyleTop = (int)intCurrTop;

                //iDGHeight = objViewInfoENEx.objViewRegion_List.Height + 50;


                strCodeForCs.AppendFormat("\r\n" + "<div id = \"divFunction\" class = \"div_Funttion\" runat = \"server\">",
                  this.TabName_In4Edit4GC, intCurrTop);

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
                    //  this.TabName_In4Edit4GC);
                    //strCodeForCs.AppendFormat("\r\n" + "CssClass = \"h6\" Width = \"250px\">{0}列表</asp:label>",
                    //  objViewInfoENEx.objInRelaTab.TabCnName);
                    //strCodeForCs.Append("\r\n" + "</td>");

                    //iDG_Div_Left = 390;//第一个按钮的左为390
                    if (objViewInfoENEx.objViewRegion_Feature.IsHaveAddNewRecord())
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
                    if (objViewInfoENEx.objViewRegion_Feature.IsHaveDelRecord())
                    {
                        objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                        ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnDelete4Gv();
                        objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                        objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                        //iDG_Div_Left += 85;
                        //strCodeForCs.Append("\r\n" + "<td>");
                        //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnDelete4Gv\" OnClick = \"btnDelete4Gv_Click\" style = \"z-index: 104; \" runat = \"server\"",
                        //  iDG_Div_Left);
                        //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"删除记录\"></asp:button>");
                        //strCodeForCs.Append("\r\n" + "</td>");
                    }
                    if (objViewInfoENEx.objViewRegion_Feature.IsHaveUpdateRecord())
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
                    if (objViewInfoENEx.objViewRegion_Feature.IsHaveUpdateRecord())
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
                    if (objViewInfoENEx.objViewRegion_Feature.IsHaveDetailRecord())
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
                    if (objViewInfoENEx.objViewRegion_Feature.IsHaveExportToFile())
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
                          objViewInfoENEx.objViewRegion_Feature.IsHaveSetExportExcel())
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

                }
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
            string strClsName = string.Format("wuc{0}4Gv", this.TabName_In4Edit4GC);
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
            string strFuncName = "";
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
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n" + " <div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">",
                this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + " <div class=\"modal-dialog modal-dialog-centered modal-dialog-scrollable\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-content\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-header\">");
            strCodeForCs.AppendFormat("\r\n" + " <h4 class=\"modal-title\" id=\"lblDialogTitle_{0}\">模态框（Modal）标题</h4>", this.TabName_In4Edit4GC);
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
            strCodeForCs.AppendFormat("\r\n" + " <button type=\"button\" class=\"btn btn-primary\" onclick=\"Submit_{0}()\">提交更改</button>", this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal-content -->");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal -->");
            strCodeForCs.Append("\r\n" + " </div>");
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

        public string Gen_WApi_Ts_ShowData()
        {
            //string strBy = objKeyField.FldName;
            //if (thisEditTabProp_TS.KeyFldCount > 1) strBy = "KeyLst";
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                if (objViewInfoENEx.objViewRegion_Feature.IsHaveUpdateRecord()
|| objViewInfoENEx.objViewRegion_Feature.IsHaveDetailRecord())
                {
                    strCodeForCs.Append("\r\n /** 函数功能:把以该关键字的记录内容显示在界面上,");
                    strCodeForCs.Append("\r\n" + "* 在这里是把值传到表控件中");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n * @param {0}: 表记录的关键字,显示该表关键字的内容", objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + " **/");
                    strCodeForCs.AppendFormat("\r\n" + "  public async ShowData({0}) {{",
                        thisEditTabProp_TS.KeyVarDefineLstStr);
                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowData.name;", this.TabName_In4Edit4GC);
                    strCodeForCs.Append("\r\n" + "        //操作步骤:");
                    strCodeForCs.Append("\r\n" + "        //1、检查关键字是否为空；");
                    strCodeForCs.Append("\r\n" + "        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；");
                    strCodeForCs.Append("\r\n" + "        //3、用提供的关键字初始化一个类对象；");
                    strCodeForCs.Append("\r\n" + "        //4、获取类对象的所有属性；");
                    strCodeForCs.Append("\r\n" + "        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中");
                    strCodeForCs.Append("\r\n" + "        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；");
                    strCodeForCs.AppendFormat("\r\n" + "        let obj{0}EN = new cls{0}EN();",
                        this.TabName_In4Edit4GC);
                    strCodeForCs.Append("\r\n" + "        try {");

                    if (thisEditTabProp_TS.KeyFldCount > 1)
                    {
                        strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F_InEdit(WA_F.IsExistAsync)}({thisEditTabProp_TS.KeyPrivVarNameLstStr});");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F_InEdit(WA_F.IsExistAsync)}({objKeyField.PrivFuncName});");
                    }
                    strCodeForCs.Append("\r\n" + "            if (returnBool == false) {");
                    strCodeForCs.AppendFormat("\r\n" + "                const strInfo = Format(\"关键字:[{{0}}] 的记录不存在!\", {0});",
                         objKeyField.PrivFuncName);

                    strCodeForCs.Append("\r\n" + "                //显示信息框");
                    strCodeForCs.Append("\r\n" + "                alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "            }");
                    //strCodeForCs.Append("\r\n" + "            else {");
                    ////                    strCodeForCs.Append("\r\n" + "                const strInfo = Format(\"关键字:[${strExam1TypeId}]的相关记录存在!\");");

                    ////                strCodeForCs.Append("\r\n" + "                //显示信息框");
                    ////              strCodeForCs.Append("\r\n" + "                alert(strInfo);");
                    //strCodeForCs.Append("\r\n" + "            }");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        catch (e) {");
                    strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"检查相应关键字的记录存在不成功, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        try {");

                    strCodeForCs.Append("\r\n" + $"const obj{TabName_In4Edit4GC}ENConst = await {thisWA_F_InEdit(WA_F.GetObjByKeyId)}({thisEditTabProp_TS.KeyPrivVarNameLstStr});");

                    strCodeForCs.AppendFormat("\r\n" + "       if (obj{0}ENConst == null)", this.TabName_In4Edit4GC);
                    strCodeForCs.Append("\r\n" + "        {");

                    strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"根据关键字获取相应的记录的对象为空.(in {0}.{1})\", this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "            return;");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.AppendFormat("\r\n" + " obj{0}EN = obj{0}ENConst; ", this.TabName_In4Edit4GC);

                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        catch (e) {");
                    strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "        }");

                    strCodeForCs.Append("\r\n" + "        //3、用提供的关键字初始化一个类对象；");

                    strCodeForCs.AppendFormat("\r\n" + "        this.GetDataFrom{0}Class(obj{0}EN);",
                        this.TabName_In4Edit4GC);


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

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(WA_ViewScript_EditCS_TS4TypeScript));
            //string strFuncName = objvFunction4GeneCodeEN.FuncName;
            //try
            //{
            //    string strCode = "";
            //    Type t = typeof(WA_ViewScript_EditCS_TS4TypeScript);
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

            string strClassName = string.Format("{0}_Edit", this.TabName_In4Edit4GC);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClsName) == false)
            {
                strClassName = objViewRegionENEx.ClsName;
            }
            this.ClsName = strClassName;

            objViewInfoENEx.ClsName = this.ClsName;
        }
       
        private void Gene_ReFreshCache(StringBuilder sbCode, string strParaStr)
        {
            string strIsShare = "";
            if (PrjTabEx_ListRegion.IsShare) strIsShare = "Share";

            if (PrjTabEx_ListRegion.IsUseStoreCache_TS() == true)
            {
                sbCode.Append("\r\n" + $"const {clsString.FirstLcaseS(TabName_In4Edit4GC)}Store = use{TabName_In4Edit4GC}Store();");

                sbCode.Append("\r\n" + $"await {clsString.FirstLcaseS(TabName_In4Edit4GC)}Store.delObj({strParaStr});");
                ImportClass objImportClass = AddImportClass(TabId_In4Edit, clsString.FirstLcaseS(TabName_In4Edit4GC), $"use{TabName_In4Edit4GC}Store", enumImportObjType.StoreModule, $"@/store/modules{strIsShare}");

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            }
            else if (objViewInfoENEx.objMainPrjTab.IsUseCache_TS() == true)
            {
                if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache();", this.TabName_In4Edit4GC);
                }
                else if (objViewInfoENEx.objCacheClassifyFld4View2_TS == null)
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache({1});", this.TabName_In4Edit4GC, thisCacheClassify4View.VarDef4Fld);
                }
                else
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache({1}, {2});", this.TabName_In4Edit4GC, thisCacheClassify4View.VarDef4Fld, thisCacheClassify4View.VarDef4Fld2);
                }
                ImportClass objImportClass = AddImportClass(this.TabId_In4Edit, this.TabName_In4Edit4GC, string.Format("ReFreshCache", this.TabName_In4Edit4GC), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
                clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            }
            else
            {
                if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache();", this.TabName_In4Edit4GC);
                }
                else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache({1});", this.TabName_In4Edit4GC, thisCacheClassify4View.VarDef4Fld);
                }
                else
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache({1}, {2});", this.TabName_In4Edit4GC,
                        thisCacheClassify4View.VarDef4Fld, thisCacheClassify4View.VarDef4Fld2);
                }
            }

        }



        public string Gen_WApi_Ts_Code4EditRegion()
        {
            string strFuncName = "";
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
                 strFuncName = objvFunction4GeneCodeEN.FuncName;
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

        public string Gen_WApi_Ts_AddDPV_Edit(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            string strClassName = string.Format("WA_{0}_Edit", this.TabName_In4Edit4GC);
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
this.TabName_In4Edit4GC, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "CheckDivExist(divName4Edit);");

            strCodeForCs.AppendFormat("\r\n" + "const strUrl = \"../{0}/{1}\";", this.objFuncModuleEN.FuncModuleEnName4GC(), strClassName);
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



        public string Gen_WApi_TS_ShowDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 显示对话框");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public ShowDialog_{0}(strOp:string) {{", this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowDialog_{0}.name;", this.TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + "//检查相关控件是否存在");
            strCodeForCs.Append("\r\n" + $"CheckControlExist(divVarSet.refDivEdit, \"div\", \"divEditDialog_{this.TabName_In4Edit4GC}\");");
            strCodeForCs.Append("\r\n" + $"CheckControlExist(divVarSet.refDivEdit, \"h4\", \"lblDialogTitle_{this.TabName_In4Edit4GC}\");");

            strCodeForCs.Append("\r\n" + "       if (strOp === \"Add\" || strOp === \"AddWithMaxId\") {");
            strCodeForCs.Append("\r\n" + $"SetH4HtmlByIdInDivObj(divVarSet.refDivEdit, 'lblDialogTitle_{this.TabName_In4Edit4GC}', '添加记录');");
            strCodeForCs.AppendFormat("\r\n" + "//{0}Ex.GetMaxStrId('#txt{1}');",
                    ThisClsName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "        }");
            strCodeForCs.Append("\r\n" + "else if (strOp === \"Update\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"SetH4HtmlByIdInDivObj(divVarSet.refDivEdit,'lblDialogTitle_{this.TabName_In4Edit4GC}', '修改记录');");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strOp === \"Detail\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $" const btnSubmit{0} = getButtonObjByIdInDivObj(divVarSet.refDivEdit, 'btnSubmit{this.TabName_In4Edit4GC}');");
            strCodeForCs.AppendFormat("\r\n" + " btnSubmit{0}.hidden = true;", this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + $"SetH4HtmlByIdInDivObj(divVarSet.refDivEdit, 'lblDialogTitle_{this.TabName_In4Edit4GC}', '详细信息');");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "        ShowDialog('#divEditDialog_{0}');", this.TabName_In4Edit4GC);

            strCodeForCs.Append("\r\n" + "}");

            ImportClass objImportClass = AddImportClass(this.TabId_In4Edit, "/PubFun/clsCommFunc4Ctrl.js", "SetH4HtmlByIdInDiv", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            ImportClass objImportClass2 = AddImportClass(this.TabId_In4Edit, "/PubFun/clsCommFunc4Ctrl.js", "getButtonObjByIdInDiv", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import2 = clsPubFun4GC.GetCodeElementByImportClass(objImportClass2);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import2);

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

        public string Gen_WApi_TS_HideDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 隐藏对话框");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public HideDialog_{0}() {{", this.TabName_In4Edit4GC);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.HideDialog_{0}.name;", this.TabName_In4Edit4GC);
            strCodeForCs.Append("\r\n" + $"CheckControlExist(divVarSet.refDivEdit, \"div\", \"divEditDialog_{this.TabName_In4Edit4GC}\");");

            strCodeForCs.AppendFormat("\r\n" + "      HideDialog('#divEditDialog_{0}');", this.TabName_In4Edit4GC);

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
        //public bool AddImportClass(string strTabId, string strClassName, string strFuncName, string strImportObjType, string strBasePath)
        //{
        //    return clsPubFun4GC.AddImportClass(strTabId, strClassName, strFuncName, strImportObjType, strBasePath, arrImportClass, objViewInfoENEx.PrjId);
        //}
    }
}
