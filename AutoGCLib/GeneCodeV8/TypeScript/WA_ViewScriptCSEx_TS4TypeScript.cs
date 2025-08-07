using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// 该类专门用生成数据表的表代理层,该代理层是逻辑层的一部分,体系结构从下到下,
    /// 共分以下几层:
    ///		1、界面层
    ///			通用界面层,专门提供一些界面控件的公共操作函数
    ///		2、逻辑层
    ///			2.1 业务逻辑层
    ///			2.2 表代理层。包括:
    ///					1)表记录的添加、
    ///					2)表记录的删除
    ///					3)表记录的修改
    ///					4)表记录的查询
    ///					5)获取某些表记录的有关字段属性
    ///					6)设置表记录的有关字段属性等。
    ///		3、数据层,即通用数据层,专门用于操作数据库的一些操作,以及操作表的一些通用操作
    /// </summary>
    partial class WA_ViewScriptCSEx_TS4TypeScript : clsGeneCodeBase4View
    {
        

        //clsBiDimDistribute objBiDimDistribue4Qry = null;
    
        public WA_ViewScriptCSEx_TS4TypeScript()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.arrImportClass = new List<ImportClass>();
        }
        public WA_ViewScriptCSEx_TS4TypeScript(string strViewId)
       : base( strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            this.arrImportClass = new List<ImportClass>();
        }
        public WA_ViewScriptCSEx_TS4TypeScript( string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            this.arrImportClass = new List<ImportClass>();
        }
        
        public string Gen_WApi_Ts_DdlBind4QueryRegion()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;


                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "boolean")
                        {
                            //strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.BindDdl_TrueAndFalse(ddl{0}_q);",
                            //            objQryRegionFldsEx.FldName);
                        }
                        else
                        {
                            //string strDS_DataValueField;
                            //string strDS_DataTextField;
                            string strDsTabName;
                            string strDS_TabCnName;
                            try
                            {
                                clsPrjTabEN objPrjTab = clsQryRegionFldsBLEx.Ds_PrjTab4Get(objQryRegionFldsEx);
                                strDsTabName = objPrjTab.TabName;
                                strDS_TabCnName = objPrjTab.TabCnName;
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源表名出错:{2}.",
                                objViewInfoENEx.ViewName, "查询区域", objException.Message);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDsTabName) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 数据源表名为空,请检查!({2}).",
                                objViewInfoENEx.ViewName, "查询区域", clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            //try
                            //{
                            //    strDS_DataValueField = clsQryRegionFldsBLEx.Ds_DataValueField4Get(objQryRegionFldsEx);
                            //}
                            //catch (Exception objException)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源值字段名时出错:{2}.<br/>数据源表名为:{3}.",
                            //    objViewInfoENEx.ViewName, "查询区域", objException.Message, strDsTabName);
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            //if (string.IsNullOrEmpty(strDS_DataValueField) == true)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源值字段名时出错.<br/>数据源表名为:{2}.({3})",
                            //        objViewInfoENEx.ViewName, "查询区域", strDsTabName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            //try
                            //{
                            //    strDS_DataTextField = clsQryRegionFldsBLEx.Ds_DataTextField4Get(objQryRegionFldsEx);
                            //}
                            //catch (Exception objException)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源文本字段名时出错:{2}.<br/>数据源表名为:{3},值字段名为:{4}.",
                            //    objViewInfoENEx.ViewName, "查询区域", objException.Message, strDsTabName, strDS_DataValueField);
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            //if (string.IsNullOrEmpty(strDS_DataTextField) == true)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源文本字段名时出错.<br/>数据源表名为:{2},值字段名为:{3}.({4})",
                            //          objViewInfoENEx.ViewName, "查询区域", strDsTabName, strDS_DataValueField,
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
                            switch (objQryRegionFldsEx.DdlItemsOptionId)
                            {
                                case "01": ///列表项串;
                                    //									string strTemp2 ;
                                    string delimStr = " ,.:";
                                    char[] delimiter = delimStr.ToCharArray();
                                    //									string words = "one two,three:four.";
                                    string[] split = null;
                                    int iItemNums;
                                    int i;

                                    strCodeForCs.AppendFormat("\r\n /** 绑定下拉框:ddl{0}的函数。", objQryRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + " **/");

                                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                        objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                                    split = objQryRegionFldsEx.ItemsString.Split(delimiter);
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
                                    strCodeForCs.AppendFormat("\r\n" + "* 为下拉框获取数据,从表:[{0}]中获取",
                                      strDsTabName);
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                    
                                    strCodeForCs.Append("\r\n" + "* returns:获取主键字段、名称字段两列的所有记录记录的DataTable");
                                    strCodeForCs.Append("\r\n" + " **/");
                                    //strCodeForCs.AppendFormat("\r\n" + "public static BindDdl_{1}(ddl{1}: string, strWhereCond:string=\"1=1\") {{",
                                    //  strDsTabName, strDS_DataValueField, strDS_DataTextField);
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
                                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"绑定下拉框(查询区)不成功,${e}.\";");
                                    strCodeForCs.Append("\r\n" + "console.error(strMsg)");
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "});");
                                    strCodeForCs.Append("\r\n" + "}");


                                    break;
                                case "03": ///列表项数据源SQL串;
                                    strCodeForCs.Append("\r\n" + "/**");
                                    strCodeForCs.AppendFormat("\r\n" + "*  为下拉框获取数据,从Sql串:[{0}]中获取",
                                       objQryRegionFldsEx.DsSqlStr);
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                    
                                    strCodeForCs.Append("\r\n" + "* returns:获取自定义的Sql串中两列的所有记录记录的DataTable");
                                    strCodeForCs.Append("\r\n" + " **/");
                                    strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}(string strCondition)",
                                    objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
                                    //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = {0}GetSpecSQLObj();", objViewInfoENEx.TabName);

                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable({0});",
                                    objQryRegionFldsEx.DsSqlStr);
                                    strCodeForCs.Append("\r\n" + "return objDT;");
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.Append("\r\n /** 绑定基于Web的下拉框");
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n * @param objDDL\">需要绑定当前表的下拉框</param>");
                                    strCodeForCs.Append("\r\n" + " **/");

                                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                    objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                                    objQryRegionFldsEx.FldName);
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
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成App页面后台代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //让用户设置属性;
          

            string strFuncName = "";
            string strTemp = ""; ///临时变量;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);
            //if (PrjTabEx_ListRegion.IsUseCache_TS())
            //{
            //    objViewInfoENEx.BaseClsName = string.Format("WApi{0}_QUDICache", objViewInfoENEx.TabName);
            //    objViewInfoENEx.WebFormName = string.Format("WApi{0}_QUDICacheEx", objViewInfoENEx.TabName);
            //    objViewInfoENEx.WebFormFName = string.Format("WApi{0}_QUDICacheEx.ts",
            //        objViewInfoENEx.TabName, objViewInfoENEx.WebFormName);

            //}
            //else
            //{
            //    objViewInfoENEx.BaseClsName = string.Format("WApi{0}_QUDI_TS", objViewInfoENEx.TabName);
            //    objViewInfoENEx.WebFormName = string.Format("WApi{0}_QUDI_TSEx", objViewInfoENEx.TabName);
            //    objViewInfoENEx.WebFormFName = string.Format("WApi{0}_QUDI_TSEx.ts",
            //        objViewInfoENEx.TabName, objViewInfoENEx.WebFormName);
            //}

            objViewInfoENEx.WebFormName = objViewInfoENEx.ClsName;
            objViewInfoENEx.WebFormFName = string.Format("{0}.ts", objViewInfoENEx.ClsName);


            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
                
            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objCodeType, objFuncModule, objViewInfoENEx, objViewInfoENEx.TabName);

            //objViewInfoENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;
            if (objViewInfoENEx.objViewRegion_Edit != null)
            {

                var objPrjTab_ListRegion = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.objViewRegion_Edit.TabId, objViewInfoENEx.PrjId);
            }
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            try
            {
                //类名开始
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx, this.CmPrjId));

                //strCodeForCs.AppendFormat("\r\n" + "///// <reference path=\"../../scripts/typings/jquery/jquery.d.ts\" />");
                //strCodeForCs.AppendFormat("\r\n" + "///// <reference path=\"../../scripts/typings/q/q.d.ts\" />");
                //strCodeForCs.AppendFormat("\r\n" + "///// <reference path=\"../../scripts/typings/handlebars/handlebars.d.ts\" />");
                //strCodeForCs.AppendFormat("\r\n" + "//import * as $ from \"jquery\";");
                //strCodeForCs.AppendFormat("\r\n" + "//import * as QQ from \"q\";");
                strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from \"../PagesBase/{1}/{0}.js\";",
                    this.BaseClsName, objFuncModule.FuncModuleEnName4GC());
                var objViewRegion_Edit = objViewInfoENEx.objViewRegion_Edit;
                if (IsHasEditRegion == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "import {{ {0}Ex }} from \"./{0}Ex.js\";", objViewRegion_Edit.ClsName);
                }

                if (PrjTabEx_EditRegion != null && thisEditTabProp_TS.KeyFldCount > 1)
                {
                    strCodeForCs.Append("\r\n" + "import { GetCheckedKeyLstsInDiv, GetFirstCheckedKeyLstInDiv }   from \"../TS/PubFun/clsCommFunc4Ctrl.js\";");
                    strCodeForCs.AppendFormat("\r\n" + "import {{ {0}_SplitKeyLst }} from \"../TS/L3ForWApi/{1}/cls{0}WApi.js\";",
                        TabName_In4Edit,
                        thisEditTabProp_TS.FuncModuleEnName4GC);

                }
                else
                { 
                    strCodeForCs.Append("\r\n" + "import { GetCheckedKeyIdsInDiv, GetFirstCheckedKeyIdInDiv }   from \"../TS/PubFun/clsCommFunc4Ctrl.js\";");
                }

                strCodeForCs.Append("\r\n" + "import { Format, IsNullOrEmpty } from \"../TS/PubFun/clsString.js\";");
                //strCodeForCs.Append("\r\n" + "declare var $;");
                strCodeForCs.Append("\r\n" + "import { IShowList } from \"../TS/PubFun/IShowList.js\";");
                strCodeForCs.Append("\r\n" + "//import $ from \"jquery\";");


                strCodeForCs.AppendFormat("\r\n /** {0} 的摘要说明。其中Q代表查询,U代表修改",
                    objViewInfoENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "export class  {0} extends {1} implements IShowList", objViewInfoENEx.ClsName, this.BaseClsName);
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "private strInfo = \"\";");
                //strCodeForCs.Append("\r\n" + "private strWhereCond = \"\";");
                
                strCodeForCs.AppendFormat("\r\n" + "//public static mstrSort{0}By = \"{1}\";",
                    objViewInfoENEx.TabName_Out, objKeyField.FldName);

                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 每页记录数,在扩展类可以修改");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public get pageSize():number {");
                strCodeForCs.Append("\r\n" + "return 10;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
        
                strCodeForCs.Append("\r\n" + "BindGv(strType: string, strPara: string) {");
                if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "alert('该类没有绑定该函数：[this.BindGv_{0}]!' + strType + strPara);", objViewInfoENEx.TabName_Out);
                    strCodeForCs.AppendFormat("\r\n" + "//this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "BindGvCache(strType: string, strPara: string) {");
                strCodeForCs.Append("\r\n" + "console.log(\"strPara\", strPara);");
                
                strCodeForCs.Append("\r\n" + "switch(strType)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "case \"{0}\":", objViewInfoENEx.TabName_Out);
                string strSuffix = "Cache";
                if (this.IsUseFunc == true)
                {
                    strSuffix = "4Func";
                }
                if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{0}{1}();",
                            objViewInfoENEx.TabName_Out, strSuffix);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "alert('该类没有绑定该函数：[this.BindGv_{0}{1}]!');", objViewInfoENEx.TabName_Out, strSuffix);
                    strCodeForCs.AppendFormat("\r\n" + "//this.BindGv_{0}{1}();",
                            objViewInfoENEx.TabName_Out, strSuffix);
                }
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.Append("\r\n" + "AccessBindGvDefault(strType);");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");


                /////生成界面中Page_Load代码;
                //strCodeForCs.Append("\r\n" + "#region 页面启动函数");

                /////生成界面中Page_Load代码;
                //strTemp = GenPage_LoadCode(false);
                //strCodeForCs.Append(strTemp);
                //strCodeForCs.Append("\r\n" + "#endregion 页面启动函数");
                //生成所有的函数
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
           clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);

                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                //  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                //  objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);
                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstByFeature = objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst;
                //arrvFunction4GeneCodeObjLstByFeature = arrvFunction4GeneCodeObjLstByFeature.Where(x => x.CodeTypeId == objViewInfoENEx.CodeTypeId);
                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst.Union(arrvFunction4GeneCodeObjLstByFeature, new VFunction4GeneCodeComparer());
                //arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst_All.OrderBy(x => x.FuncName4Code);

                //为所有的函数定义相关输入控件
                List<string> arrValueLst = new List<string>();

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";
                    //if (strFuncName.IndexOf("TS_ScriptCS") > 0)
                    //{
                    //string strFuncName4Code = objvFunction4GeneCodeEN.FuncName4Code;
                    //if (strFuncName4Code.Contains("AddNew") == true
                    //    || strFuncName4Code.Contains("Update") == true
                    //    || strFuncName4Code.Contains("GetObjByKey") == true)
                    //{
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    //string strSource = string.Format("ac{0}_UnitTest", objViewInfoENEx.TabName);
                    //string strTarget = string.Format("ac{0}_UTScript", objViewInfoENEx.TabName);

                    //strTemp = strTemp.Replace(strSource, strTarget);
                    //}
                    //else
                    //{
                    //    strTemp = "";
                    //}
                    //strTemp = A_GeneFuncCode_Java(strFuncName);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
                //strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
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
        /// 功能:单表的查询、修改、插入、删除
        /// </summary>
        /// <returns></returns>

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

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(WA_ViewScriptCSEx_TS4TypeScript));
            //string strFuncName = objvFunction4GeneCodeEN.FuncName;
            //try
            //{
            //    string strCode = "";
            //    Type t = typeof(WA_ViewScriptCSEx_TS4TypeScript);
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

            //if (PrjTabEx_ListRegion.IsUseCache_TS())
            //{
            //    this.ClsName = string.Format("WApi{0}_QUDICacheEx", objViewInfoENEx.TabName);
            //    this.BaseClsName = string.Format("WApi{0}_QUDICache", objViewInfoENEx.TabName);

            //    objViewInfoENEx.ClsName = this.ClsName;

            //}
            //else
            //{
            //    this.ClsName = string.Format("WApi{0}_QUDI_JSEx", objViewInfoENEx.TabName);
            //    this.BaseClsName = string.Format("WApi{0}_QUDI_JS", objViewInfoENEx.TabName);
            //    objViewInfoENEx.ClsName = this.ClsName;
            //}
            this.ClsName = string.Format("{0}Ex", objViewInfoENEx.ViewName);
            this.BaseClsName = string.Format("{0}", objViewInfoENEx.ViewName);
            objViewInfoENEx.ClsName = this.ClsName;
        }
        

        public string Gen_WApi_Ts_GeneEventFuncEx()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {


                var arrQryRegionFlds_ChangeEvent = objViewInfoENEx.arrQryRegionFldSet.Where(x => string.IsNullOrEmpty(x.ChangeEvent) == false && x.InUse == true).ToList();
                arrQryRegionFlds_ChangeEvent.ForEach(x => {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);

                    strCodeForCs.Append("\r\n /** 函数功能:系统生成的Change事件函数");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + " **/");
                    strCodeForCs.AppendFormat("\r\n" + "public async {0}()",
                       x.ChangeEvent);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "alert('请在扩展层:{0}Ex中重写该函数!');", objViewInfoENEx.ClsName);
                    strCodeForCs.Append("\r\n" + "}");
                });

                strCodeForCs.Append("\r\n" + "");

                var arrQryRegionFlds_ClickEvent = objViewInfoENEx.arrQryRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrQryRegionFlds_ClickEvent.ForEach(x => {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);
                    strCodeForCs.Append("\r\n /** 函数功能:系统生成的Click事件函数");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + " **/");

                    strCodeForCs.AppendFormat("\r\n" + "public  async {0}(){{;",
                       x.ClickEvent, objViewInfoENEx.ClsName);
                    strCodeForCs.AppendFormat("\r\n" + "alert('请在扩展层:{0}Ex中重写该函数!');", objViewInfoENEx.ClsName);
                    strCodeForCs.Append("\r\n" + "}");
                });

                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_TS_btn_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds;
            if (objViewInfoENEx.arrFeatureRegionFlds == null)
            {
                string strMsg = string.Format("界面功能区为空,请添加界面功能!界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);

            }
            List<string> arrButtonName = arrFeatureRegionFldsObjLst.Select(x => x.ButtonName)
                .Select(x=>x.Substring(3))
                .ToList();
            var arr = new List<string>  { enumPrjFeature.DefaultFeature_0240, enumPrjFeature.SetFieldValue_0148 };
            List<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst_DefaultFeature = objViewInfoENEx.arrFeatureRegionFlds.Where(x=> arr.Contains( x.FeatureId)).ToList();

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 按钮单击,用于调用Js函数中btnClick");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public static btnClick(strCommandName: string, strKeyId: string) {{", objViewInfoENEx.ClsName);
            //strCodeForCs.AppendFormat("\r\n" + "const objPage:{0} = new {0}();", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "let objPage: {0};", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "let objPageEdit;");
            
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.objPage_CRUD == null)", this.BaseClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}.objPage_CRUD = new {1}();", this.BaseClsName, objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "objPage = <{0}> {1}.objPage_CRUD;", objViewInfoENEx.ClsName, this.BaseClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "objPage = <{0}> {1}.objPage_CRUD;", objViewInfoENEx.ClsName, this.BaseClsName);
            strCodeForCs.Append("\r\n" + "}");

            var objViewRegion_Edit = objViewInfoENEx.objViewRegion_Edit;

            strCodeForCs.Append("\r\n" + "let strMsg = '';");

            //strCodeForCs.Append("\r\n" + "const strKeyId = clsCommFunc4Ctrl.GetFirstCheckedKeyId(objPage.divName4List);");
            string strKeyLstName = "arrKeyIds";
            if (PrjTabEx_EditRegion != null && thisEditTabProp_TS.KeyFldCount>1)
            {
                strKeyLstName = "arrKeyLsts";
                strCodeForCs.Append("\r\n" + "const arrKeyLsts = GetCheckedKeyLstsInDivObj(objPage.divName4DataList);");
                strCodeForCs.Append("\r\n" + "let objKeyLst;");
                strCodeForCs.Append("\r\n" + "let strKeyLst = \"\"; ");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "const arrKeyIds = GetCheckedKeyIdsInDivObj(objPage.divName4DataList);");
            }
            strCodeForCs.Append("\r\n" + "switch (strCommandName)");
            strCodeForCs.Append("\r\n" + "{");

            arrFeatureRegionFldsObjLst_DefaultFeature.ForEach(x =>
            {
                string strCommandName = x.CommandName;
                strCodeForCs.AppendFormat("\r\n" + "case \"{0}\":    //自定义功能:{1}", strCommandName, x.Text);
                if (string.IsNullOrEmpty(x.FuncName) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "objPage.{0}();", x.FuncName);
                }
                strCodeForCs.Append("\r\n" + "break;");
            });

            strCodeForCs.Append("\r\n" + "case \"Query\":    //查询记录");
            strCodeForCs.Append("\r\n" + "objPage.btnQuery_Click();");
            strCodeForCs.Append("\r\n" + "break;");

            if (IsHasEditRegion == true)
            {
                strCodeForCs.Append("\r\n" + "case \"AddNewRecordWithMaxId\":    //添加记录使用最大关键字");

                    strCodeForCs.AppendFormat("\r\n" + "objPageEdit = new {0}Ex('{0}Ex', objPage);", objViewRegion_Edit.ClsName);

                strCodeForCs.AppendFormat("\r\n" + "{0}objPageEdit.btnAddNewRecordWithMaxId_Click();", arrButtonName.Contains("AddNewRecordWithMaxId") ? "" : "//");
                strCodeForCs.Append("\r\n" + "break;");

                strCodeForCs.Append("\r\n" + "case \"CreateWithMaxId\":    //添加记录使用最大关键字");
                strCodeForCs.AppendFormat("\r\n" + "objPageEdit = new {0}Ex('{0}Ex', objPage);", objViewRegion_Edit.ClsName);

                strCodeForCs.AppendFormat("\r\n" + "{0}objPageEdit.btnAddNewRecordWithMaxId_Click();", arrButtonName.Contains("CreateWithMaxId") ? "" : "//");
                strCodeForCs.Append("\r\n" + "break;");


                strCodeForCs.Append("\r\n" + "case \"AddNewRecord\":            //添加记录");
                strCodeForCs.Append("\r\n" + "case \"Create\":            //添加记录");
                strCodeForCs.AppendFormat("\r\n" + "objPageEdit = new {0}Ex('{0}Ex', objPage);", objViewRegion_Edit.ClsName);

                strCodeForCs.Append("\r\n" + "objPageEdit.btnAddNewRecord_Click();");
                strCodeForCs.Append("\r\n" + "break;");


                strCodeForCs.Append("\r\n" + "case \"UpdateRecord\":            //修改记录");
                strCodeForCs.Append("\r\n" + "case \"Update\":            //修改记录");
                strCodeForCs.Append("\r\n" + "case \"UpdateRecordInTab\":            //修改记录InTab");
                if (thisEditTabProp_TS.KeyFldCount == 1)
                {
                    strCodeForCs.Append("\r\n" + "strKeyId = GetFirstCheckedKeyIdInDivObj(objPage.divName4List);");

                    strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty( strKeyId )== true)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = \"请选择需要修改的记录!\";");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "objPageEdit = new {0}Ex('{0}Ex', objPage);", objViewRegion_Edit.ClsName);
                    if (thisEditTabProp_TS.IsNumberType)
                    {

                        strCodeForCs.Append("\r\n" + "if (strCommandName == \"UpdateRecordInTab\")");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "objPageEdit.btnUpdateRecordInTab_Click(Number(strKeyId));");
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "else");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "objPageEdit.btnUpdateRecord_Click(Number(strKeyId));");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "if (strCommandName == \"UpdateRecordInTab\")");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "objPageEdit.btnUpdateRecordInTab_Click(strKeyId);");
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "else");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "objPageEdit.btnUpdateRecord_Click(strKeyId);");
                        strCodeForCs.Append("\r\n" + "}");
                    }

                }
                else
                {
                    strCodeForCs.Append("\r\n" + "strKeyLst = GetFirstCheckedKeyLstInDivObj(objPage.divName4List);");
                    strCodeForCs.AppendFormat("\r\n" + "objKeyLst = {0}_SplitKeyLst(strKeyLst);", TabName_In4Edit);
                    strCodeForCs.AppendFormat("\r\n" + "objPageEdit = new {0}Ex('{0}Ex', objPage);", objViewRegion_Edit.ClsName);

                    strCodeForCs.Append("\r\n" + "if (strCommandName == \"UpdateRecordInTab\")");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "objPageEdit.btnUpdateRecordInTab_Click(objKeyLst);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "objPageEdit.btnUpdateRecord_Click(objKeyLst);");
                    strCodeForCs.Append("\r\n" + "}");
                }
                strCodeForCs.Append("\r\n" + "break;");
            }
            
                strCodeForCs.Append("\r\n" + "case \"CopyRecord\":            //复制记录");
                strCodeForCs.Append("\r\n" + "case \"Clone\":            //复制记录");


                strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"请选择需要复制的记录!\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnCopyRecord_Click();", arrButtonName.Contains("CopyRecord") ? "" : "//");
                strCodeForCs.Append("\r\n" + "break;");

                strCodeForCs.Append("\r\n" + "case \"ExportExcel\":            //导出Excel");
                var objViewRegion_ExportExcel = objViewInfoENEx.objViewRegion_ExportExcel;
                var bolIsHasExcelExport = objViewRegion_ExportExcel != null && arrButtonName.Contains("ExportExcel");
                strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnExportExcel_Click();", bolIsHasExcelExport ? "" : "//");

                strCodeForCs.Append("\r\n" + "//alert(\"导出Excel功能还没有开通!\");");
                //strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "break;");


                strCodeForCs.Append("\r\n" + "case \"DelRecord\":            //删除记录");
                strCodeForCs.Append("\r\n" + "case \"Delete\":            //删除记录");

                strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"请选择需要删除的记录!\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "objPage.btnDelRecord_Click();");
                strCodeForCs.Append("\r\n" + "break;");

                strCodeForCs.Append("\r\n" + "case \"DelRecordInTab\":   //删除记录InTab ");
            if (PrjTabEx_EditRegion != null && thisEditTabProp_TS.KeyFldCount > 1)
            {
                strCodeForCs.AppendFormat("\r\n" + "objKeyLst = {0}_SplitKeyLst(strKeyId);", TabName_In4Edit);
                strCodeForCs.Append("\r\n" + "objPage.btnDelRecordInTab_Click(");
                int intIndex = 0;
                foreach (var objInFor in PrjTabEx_EditRegion.arrKeyFldSet)
                {
                    if (intIndex == 0)
                    {
                        strCodeForCs.AppendFormat("objKeyLst.{0}", objInFor.PropertyName(this.IsFstLcase));
                    }
                    else
                    {
                        strCodeForCs.AppendFormat(", objKeyLst.{0}", objInFor.PropertyName(this.IsFstLcase));
                    }
                    intIndex++;
                }
                strCodeForCs.Append( ");");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "objPage.btnDelRecordInTab_Click(strKeyId);");
            }
                strCodeForCs.Append("\r\n" + "break;");


                strCodeForCs.Append("\r\n" + "case \"DelRecordBySign\":            //按标志删除记录");
                strCodeForCs.Append("\r\n" + "case \"DeleteBySign\":            //按标志删除记录");

            strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
            strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"请选择需要按标志删除的记录!\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnDelRecordBySign_Click();", arrButtonName.Contains("DelRecordBySign") ? "" : "//");
                strCodeForCs.Append("\r\n" + "break;");


                strCodeForCs.Append("\r\n" + "case \"UnDelRecordBySign\":            //按标志恢复删除记录");
                strCodeForCs.Append("\r\n" + "case \"UnDeleteBySign\":            //按标志恢复删除记录");

            strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
            strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"请选择需要恢复删除的记录!\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnUnDelRecordBySign_Click();",
                    arrButtonName.Contains("UnDelRecordBySign") ? "" : "//");
                strCodeForCs.Append("\r\n" + "break;");


                strCodeForCs.Append("\r\n" + "case \"GoTop\":            //置顶记录");

            strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
            strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"请选择需要置顶的记录!\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnGoTop_Click();",
                    arrButtonName.Contains("GoTop") ? "" : "//");
                strCodeForCs.Append("\r\n" + "break;");


                strCodeForCs.Append("\r\n" + "case \"GoBottum\":            //移底记录");

            strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
            strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"请选择需要移底的记录!\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnGoBottum_Click();",
                    arrButtonName.Contains("GoBottum") ? "" : "//");
                strCodeForCs.Append("\r\n" + "break;");


                strCodeForCs.Append("\r\n" + "case \"UpMove\":            //上移记录");

            strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
            strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"请选择需要上移的记录!\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnUpMove_Click();",
                    arrButtonName.Contains("UpMove") ? "" : "//");
                strCodeForCs.Append("\r\n" + "break;");


                strCodeForCs.Append("\r\n" + "case \"DownMove\":            //下移记录");

            strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
            strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"请选择需要下移的记录!\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnDownMove_Click();",
                    arrButtonName.Contains("DownMove") ? "" : "//");
                strCodeForCs.Append("\r\n" + "break;");
            

            strCodeForCs.Append("\r\n" + "case \"ReOrder\":            //重序记录");
            strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnReOrder_Click();",
                arrButtonName.Contains("ReOrder") ? "" : "//");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.AppendFormat("\r\n" + "strMsg = '命令:' + strCommandName + \"在函数({0}.btnClick)中没有被处理!\";", this.ClsName);
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "break;");     
         

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");

            arrFeatureRegionFldsObjLst_DefaultFeature.ForEach(x =>
            {
                if (x.FeatureId == enumPrjFeature.DefaultFeature_0240)
                {
                    if (string.IsNullOrEmpty(x.FuncName) == false)
                    {
                        strCodeForCs.Append("\r\n /**");
                        strCodeForCs.AppendFormat("\r\n * 自定义功能:{0}", x.Text);
                        strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n **/");
                        strCodeForCs.AppendFormat("\r\n" + "public {0}()", x.FuncName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "//自定义功能;");
                        strCodeForCs.Append("\r\n" + "};");
                    }
                }
            });
            //aa

            return strCodeForCs.ToString();
        }

    }
}
