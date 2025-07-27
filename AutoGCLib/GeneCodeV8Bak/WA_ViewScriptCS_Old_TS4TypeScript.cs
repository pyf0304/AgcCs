using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;


using AGC.Entity;

using com.taishsoft.datetime;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using com.taishsoft.util;
using AgcCommBase;
using System.Reflection;
using System.Linq;
using AGC.PureClass;
using AGC.PureClassEx;

namespace AutoGCLib
{
    public class ASPDropDownListEx4GCComparer : IEqualityComparer<ASPDropDownListEx>
    {
        public bool Equals(ASPDropDownListEx t1, ASPDropDownListEx t2)
        {
            return (t1.CtrlId == t2.CtrlId);
        }
        public int GetHashCode(ASPDropDownListEx t)
        {
            return t.ToString().GetHashCode();
        }
    }
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
    partial class WA_ViewScriptCS_Old_TS4TypeScript : clsGeneCodeBase
    {
        private List<clsPropertyDef4GC> arrPropertyDef4GC = null;
        private string strVarDef4ViewCacheFld = "";
        //private string strVarDef4GivingValue = "";

        int intZIndex;      ///控件焦点序号
        float intCurrLeft;  ///控件的左边空;
        float intCurrTop;  ///控件的顶面空;
        clsBiDimDistribute objBiDimDistribue4Qry = null;
        #region 构造函数
        public WA_ViewScriptCS_Old_TS4TypeScript()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
        }
        public WA_ViewScriptCS_Old_TS4TypeScript(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public WA_ViewScriptCS_Old_TS4TypeScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
            this.GetClsName();
            if (objViewInfoENEx.objCacheClassifyFld4View != null)
            {
                strVarDef4ViewCacheFld = string.Format("{0}.{1}_Cache", objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName);
            }

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
            if (objViewInfoENEx.IsUseCache4List) return "";
    
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /* 函数功能:页面导入,当页面开始运行时所发生的事件");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "public async Page_Load()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                //strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //生成Page_Load中的绑定下拉框的代码
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                //建立缓存
                strCodeForCs.Append("\r\n" + "//建立缓存");

                strCodeForCs.Append("\r\n" + "clsPubFun.SetCommFun4BL();");
                List<string> arrTabName = new List<string>();
                strCodeForCs.Append("\r\n // 为查询区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n" + "const gvBindDdl = await this.BindDdl4QueryRegion();", objViewInfoENEx.ClsName);
                
                strCodeForCs.Append("\r\n" + Gen_WApi_Ts_DdlBind4ViewFeatureInPage_Load());

                    strCodeForCs.AppendFormat("\r\n" + "{2}.sort{1}By = \"{0} Asc\";",
                            objViewInfoENEx.FirstSortField, objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
               

                strCodeForCs.Append("\r\n" + "//2、显示无条件的表内容在GridView中");

                strCodeForCs.AppendFormat("\r\n" + "const gvResult = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"页面启动不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
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
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_Page_Load_Cache()
        {
            if (objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == objViewInfoENEx.objMainPrjTab.CacheClassifyField_TS).Count() > 0)
            {
               objViewInfoENEx.objCacheClassifyFld4View = objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == objViewInfoENEx.objMainPrjTab.CacheClassifyField_TS).First();
            }
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /* 函数功能:页面导入,当页面开始运行时所发生的事件");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "public async Page_Load_Cache()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                //strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //生成Page_Load中的绑定下拉框的代码
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                //建立缓存
                //strCodeForCs.Append("\r\n" + "clsPubFun.SetCommFun4BL();");
                List<string> arrTabName = new List<string>();

                var objViewRegion = objViewInfoENEx.arrViewRegion.Find(x=>x.RegionTypeId == enumRegionType.QueryRegion_0001);
                if (objViewRegion != null
                    && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true
                    && objViewRegion.IsDispInViewInfo(objViewInfoENEx) == true)
                {
                    strCodeForCs.Append("\r\n // 为查询区绑定下拉框");
                    strCodeForCs.AppendFormat("\r\n" + "const gvBindDdl = await this.BindDdl4QueryRegion();", objViewInfoENEx.ClsName);
                }
                strCodeForCs.Append("\r\n" + Gen_WApi_Ts_DdlBind4ViewFeatureInPage_Load());

                    strCodeForCs.AppendFormat("\r\n" + "{2}.sort{1}By = \"{0} Asc\";",
                            objViewInfoENEx.FirstSortField, objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
               

                strCodeForCs.Append("\r\n" + "//2、显示无条件的表内容在GridView中");

                strCodeForCs.AppendFormat("\r\n" + "const gvResult = await this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"页面启动不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
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
                    if (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName == "DropDownList")
                    {
                        if (objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "boolean")
                        {
                        }
                        else
                        {
                            string strDS_DataValueField;
                            string strDS_DataTextField;
                            string strDs_TabName;
                            string strDS_TabCnName;
                            try
                            {
                                clsPrjTabEN objPrjTab = clsEditRegionFldsBLEx.InitDs_PrjTab4Get(objEditRegionFldsEx);
                                strDs_TabName = objPrjTab.TabName;
                                strDS_TabCnName = objPrjTab.TabCnName;
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源表名出错:{2}.",
                                objViewInfoENEx.ViewName, "编辑区域", objException.Message);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDs_TabName) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 数据源表名为空，请检查!({2}).",
                                objViewInfoENEx.ViewName, "编辑区域", clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            try
                            {
                                strDS_DataValueField = clsEditRegionFldsBLEx.InitDs_DataValueField(objEditRegionFldsEx);
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源值字段名时出错:{2}.<br/>数据源表名为:{3}.",
                                objViewInfoENEx.ViewName, "编辑区域", objException.Message, strDs_TabName);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDS_DataValueField) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源值字段名时出错.<br/>数据源表名为:{2}.({3})",
                                    objViewInfoENEx.ViewName, "编辑区域", strDs_TabName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            try
                            {
                                strDS_DataTextField = clsEditRegionFldsBLEx.InitDs_DataTextField(objEditRegionFldsEx);
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源文本字段名时出错:{2}.<br/>数据源表名为:{3},值字段名为:{4}.",
                                objViewInfoENEx.ViewName, "编辑区域", objException.Message, strDs_TabName, strDS_DataValueField);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDS_DataTextField) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源文本字段名时出错.<br/>数据源表名为:{2},值字段名为:{3}.({4})",
                                      objViewInfoENEx.ViewName, "编辑区域", strDs_TabName, strDS_DataValueField,
                                      clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            if (arrDdlKeyIdLst.Contains(strDS_DataValueField) == false)
                            {
                                arrDdlKeyIdLst.Add(strDS_DataValueField);
                            }
                            else
                            {
                                continue;
                            }
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

                                    strCodeForCs.AppendFormat("\r\n /*绑定下拉框:ddl{0}的函数。", objEditRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "*/");
                                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                    objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
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
                                    strCodeForCs.Append("\r\n" + "/// <summary>");
                                    strCodeForCs.AppendFormat("\r\n" + "/// 为下拉框获取数据,从表:[{0}]中获取",
                                      strDs_TabName);
                                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "/// </summary>");
                                    strCodeForCs.Append("\r\n" + "/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>");
                                    strCodeForCs.AppendFormat("\r\n" + "public BindDdl_{1}(ddl{1}: string, strWhereCond:string=\"1=1\") {{",
                                      strDs_TabName, strDS_DataValueField, strDS_DataTextField, objEditRegionFldsEx.CtrlId);
                                    strCodeForCs.Append("\r\n" + "//let strWhereCond = \" 1 =1 \";");
                                    strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(ddl{1});",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"下拉框：{{0}} 不存在！\", ddl{1});",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

                                    strCodeForCs.Append("\r\n" + "try");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}_GetObjLstAsync(strWhereCond);",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);

                                    //this.BindTab_{0}(strListDiv, arr{0}ObjLst);
                                    strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.BindDdl_ObjLst(ddl{1}, arr{0}ObjLst, cls{0}EN.con_{1}, cls{0}EN.con_{2}, \"{3}\");",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField, strDS_TabCnName);
                                    strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成BindDdl_{0}!\");", strDS_DataValueField);
                                    
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "catch (e)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"绑定下拉框不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "});");
                                    strCodeForCs.Append("\r\n" + "}");


                                    break;
                                case "03": ///列表项数据源SQL串;
                                    strCodeForCs.Append("\r\n" + "/// <summary>");
                                    strCodeForCs.AppendFormat("\r\n" + "/// 为下拉框获取数据,从Sql串:[{0}]中获取",
                                       objEditRegionFldsEx.Ds_SQLStr);
                                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "/// </summary>");
                                    strCodeForCs.Append("\r\n" + "/// <returns>获取自定义的Sql串中两列的所有记录记录的DataTable</returns>");

                                    strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}(string strCondition)",
                                    objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
                                    //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}BL.GetSpecSQLObj();", objViewInfoENEx.TabName);

                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable({0});",
                                    objEditRegionFldsEx.Ds_SQLStr);
                                    strCodeForCs.Append("\r\n" + "return objDT;");
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.Append("\r\n /* 绑定基于Web的下拉框");
                                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n  <param name = \"objDDL\">需要绑定当前表的下拉框</param>");
                                    strCodeForCs.Append("\r\n" + "*/");
                                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                    objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                                    objEditRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};",
                                      strDs_TabName, strDS_DataValueField);
                                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};",
                                      strDs_TabName, strDS_DataTextField);
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


        public string Gen_WApi_Ts_BindDdl4QueryRegio1nBak()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            IEnumerable<ASPDropDownListEx> arrASPDropDownListObj_Query = 
                objViewInfoENEx.arrASPDropDownListObj.Where(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
            try
            {
                strCodeForCs.Append("\r\n /* 函数功能:为查询区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public async BindDdl4QueryRegion()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl4QueryRegion.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);

                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");

                List<string> arrTabName = new List<string>();
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Query)
                {
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    //if (objInfor.Ds_TabName == objViewInfoENEx.TabName) continue;


                    if (objInfor.CsType == "bool") continue;
                    if (arrTabName.Contains(objInfor.Ds_TabName) == true) continue;
                    arrTabName.Add(objInfor.Ds_TabName);
                    strCodeForCs.AppendFormat("\r\n" + " var obj{0}_Cond:cls{0}EN = new cls{0}EN();//{1}",
                                    objInfor.Ds_TabName, 
                                    clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId));
                }


                //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager\");");
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Query)
                {
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    clsFieldTabEN objFieldTab_Cond = clsFieldTabBL.GetObjByFldId_Cache(objInfor.objQryRegionFldsEN.Ds_CondFieldId, objInfor.objQryRegionFldsEN.PrjId);
                    clsFieldTabEN objFieldTab_Sort = clsFieldTabBL.GetObjByFldId_Cache(objInfor.objQryRegionFldsEN.Ds_SortFieldId, objInfor.objQryRegionFldsEN.PrjId);
                    string strVar4Cond = "";
                    string strVar4Sort = "";
                    string strVar4Cond_2 = "";
                    string strVar4Sort_2 = "";
                    if (objFieldTab_Cond != null)
                    {
                        strVar4Cond = objFieldTab_Cond.PrivFuncName();
                        strVar4Cond_2 = ", " + strVar4Cond;
                    }
                    if (objFieldTab_Sort != null)
                    {
                        strVar4Sort = objFieldTab_Sort.PrivFuncName();
                        strVar4Sort_2 = ", " + strVar4Sort;
                    }
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Ctrl.BindDdl_TrueAndFalse(\"{0}\");",
                                 objInfor.CtrlId);
                    }
                    else
                    {
                        if (objVarManage.AddVariable(new clsVariable(strVar4Cond)) == true)
                        {
                            string strVarDefStr = "";
                            if (objViewInfoENEx.objCacheClassifyFld4View != null)
                            {
                                if (objViewInfoENEx.objCacheClassifyFld4View.FldName == objFieldTab_Cond.FldName)
                                {
                                    strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", strVarDef4ViewCacheFld);
                                }
                                else
                                {
                                    strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", "");
                                }
                            }
                            strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                            //生成缓存分类字段的检查代码，检查是否被赋正确值
                            clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objViewInfoENEx.objCacheClassifyFld4View, objFieldTab_Cond.PrivFuncName(), this.ClsName);
                        }

                        if (objVarManage.AddVariable(new clsVariable(strVar4Sort)) == true)
                        {
                            string strVarDefStr = "";
                            if (objViewInfoENEx.objCacheClassifyFld4View != null)
                            {
                                if (objViewInfoENEx.objCacheClassifyFld4View.FldName == objFieldTab_Sort.FldName)
                                {
                                    strVarDefStr = objVarManage.DefVariable(strVar4Sort, "\"\"", strVarDef4ViewCacheFld);
                                }
                                else
                                {
                                    strVarDefStr = objVarManage.DefVariable(strVar4Sort, "\"\"", "");
                                }
                            }
                            strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                            //生成缓存分类字段的检查代码，检查是否被赋正确值
                            clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objViewInfoENEx.objCacheClassifyFld4View, objFieldTab_Cond.PrivFuncName(), this.ClsName);
                        }


                        if (objInfor.objFieldTab_CacheClassify() == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = await {3}_BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond {6} {7});//{4}",
                                            objInfor.FldName,
                                            objInfor.objFieldTab_ValueField.FldName,
                                            objInfor.CtrlId,
                                            objInfor.Ds_TabName,
                                            clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                                            objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "",
                                        strVar4Cond_2,
                                        strVar4Sort_2);
                        }
                        else
                        {

                            string strVariableName = string.Format("{0}{2}",
                                            objInfor.objFieldTab_CacheClassify().PrivFuncName(), 
                                            objInfor.objFieldTab_CacheClassify().ObjDataTypeAbbr().TypeScriptType,
                                            objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            if (objVarManage.AddVariable(new clsVariable(strVariableName)) == true)
                            {
                                string strVarDefStr = "";
                                if (objViewInfoENEx.objCacheClassifyFld4View != null)
                                {
                                    if (objViewInfoENEx.objCacheClassifyFld4View.FldName == objInfor.objFieldTab_CacheClassify().FldName)
                                    {
                                        strVarDefStr = objVarManage.DefVariable(strVariableName, "\"\"", strVarDef4ViewCacheFld);
                                    }
                                    else
                                    {
                                        strVarDefStr = objVarManage.DefVariable(strVariableName, "\"\"", strVarDef4ViewCacheFld);
                                    }
                                }
                                strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                                //生成缓存分类字段的检查代码，检查是否被赋正确值
                                clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objViewInfoENEx.objCacheClassifyFld4View, objFieldTab_Cond.PrivFuncName(), this.ClsName);
                                strCodeForCs.AppendFormat("\r\n" + "//var {0}{2} = \"\";//定义条件字段",
                                    objInfor.objFieldTab_CacheClassify().PrivFuncName(), objInfor.objFieldTab_CacheClassify().ObjDataTypeAbbr().TypeScriptType,
                                    objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            }
                            //strCodeForCs.AppendFormat("\r\n" + "var {0}{2} = \"\";",
                            //         objInfor.objFieldTab_ConditionField.PrivFuncName(),
                            //         objInfor.objFieldTab_ConditionField.ObjDataTypeAbbr().TypeScriptType,
                            //         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            string strConditionFieldName = "";
                            string strConditionFieldName_2 = "";
                            if (objInfor.objFieldTab_ConditionField != null)
                            {
                                strConditionFieldName = string.Format("{0}{1}", objInfor.objFieldTab_ConditionField.PrivFuncName(),
                                    objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                                strConditionFieldName_2 = string.Format(", {0}{1}", objInfor.objFieldTab_ConditionField.PrivFuncName(),
                                    objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            }
                            if (strConditionFieldName.Replace("_q", "") == strVar4Cond)
                            {
                                strVar4Cond_2 = "";
                            }
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = await {3}_BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond {5} {6});//{4}",
                                 objInfor.FldName,
                                 objInfor.objFieldTab_ValueField.FldName,
                                objInfor.CtrlId, 
                                objInfor.Ds_TabName
                         , clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                         strConditionFieldName_2,                         
                                strVar4Cond_2,
                                strVar4Sort_2);
                        }
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
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_BindDdl4QueryRegion()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            IEnumerable<ASPDropDownListEx> arrASPDropDownListObj_Query = objViewInfoENEx.arrASPDropDownListObj.Where(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
            try
            {
                strCodeForCs.Append("\r\n /* 函数功能:为查询区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public async BindDdl4QueryRegion()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl4QueryRegion.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);

                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");

                //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager\");");
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Query)
                {
                    clsFieldTabEN objFieldTab_Cond = clsFieldTabBL.GetObjByFldId_Cache(objInfor.objQryRegionFldsEN.Ds_CondFieldId, objInfor.objQryRegionFldsEN.PrjId);

                    string strVar4Cond = "";
                    string strVar4Cond_2 = "";
                    if (objFieldTab_Cond != null)
                    {
                        strVar4Cond = objFieldTab_Cond.PrivFuncName();
                        strVar4Cond_2 = ", " + strVar4Cond;
                    }
                    if (objInfor.objFieldTab_CacheClassify() != null)
                    {
                        if (objVarManage.AddVariable(new clsVariable(objInfor.objFieldTab_CacheClassify().PrivFuncName(), objInfor.objFieldTab_CacheClassify().ObjDataTypeAbbr().TypeScriptType)) == true)
                        {
                            string strVarDefStr = "";
                            strVarDefStr = objVarManage.DefVariable(objInfor.objFieldTab_CacheClassify().PrivFuncName(), "\"\"", strVarDef4ViewCacheFld);

                            strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                            //生成缓存分类字段的检查代码，检查是否被赋正确值
                            clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objViewInfoENEx.objCacheClassifyFld4View, objFieldTab_Cond.PrivFuncName(), this.ClsName);
                        }
                    }
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    if (objVarManage.AddVariable(new clsVariable(strVar4Cond)) == true)
                    {
                        string strVarDefStr = "";
                        if (objViewInfoENEx.objCacheClassifyFld4View != null)
                        {
                            if (objViewInfoENEx.objCacheClassifyFld4View.FldName == objFieldTab_Cond.FldName)
                            {
                                strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", strVarDef4ViewCacheFld);
                            }
                            else
                            {
                                strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", "");
                            }

                        }

                        strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                        //生成缓存分类字段的检查代码，检查是否被赋正确值
                        clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objViewInfoENEx.objCacheClassifyFld4View, objFieldTab_Cond.PrivFuncName(), this.ClsName);
                    }
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Ctrl.BindDdl_TrueAndFalse(\"{0}\");",
                                 objInfor.CtrlId);
                    }
                    else
                    {
                        if (objInfor.objFieldTab_CacheClassify() == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = await this.SetDdl_{1}();//{3}",
                                            objInfor.FldName,
                                            objInfor.FldName,
                                            objInfor.CtrlId,
                                            clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId));
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = await this.SetDdl_{1}({4});//{3}",
                                 objInfor.FldName,
                                 objInfor.FldName,
                                objInfor.CtrlId,
                                 clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                                objInfor.objFieldTab_CacheClassify().PrivFuncName());
                        }
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
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_BindDdl4EditRegion()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            IEnumerable<ASPDropDownListEx> arrASPDropDownListObj_Edit = objViewInfoENEx.arrASPDropDownListObj.Where(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
            try
            {
                strCodeForCs.Append("\r\n /* 函数功能:为编辑区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public async BindDdl4EditRegion()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");

                List<string> arrTabName = new List<string>();
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Edit)
                {
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    //if (objInfor.Ds_TabName == objViewInfoENEx.TabName) continue;
                    if (objInfor.CsType == "bool") continue;
                    if (arrTabName.Contains(objInfor.Ds_TabName) == true) continue;
                    arrTabName.Add(objInfor.Ds_TabName);
                    strCodeForCs.AppendFormat("\r\n" + " const obj{0}_Cond = new cls{0}EN();//{1}",
                        objInfor.Ds_TabName, clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId));
                }


                //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager\");");
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Edit)
                {
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    clsFieldTabEN objFieldTab_Cond = clsFieldTabBL.GetObjByFldId_Cache(objInfor.objEditRegionFldsEN.Ds_CondFieldId, objInfor.objEditRegionFldsEN.PrjId);
                    clsFieldTabEN objFieldTab_Sort = clsFieldTabBL.GetObjByFldId_Cache(objInfor.objEditRegionFldsEN.Ds_SortFieldId, objInfor.objEditRegionFldsEN.PrjId);
                    string strVar4Cond = "";
                    string strVar4Sort = "";
                    string strVar4Cond_2 = "";
                    string strVar4Sort_2 = "";
                    if (objFieldTab_Cond != null)
                    {
                        strVar4Cond = objFieldTab_Cond.PrivFuncName();
                        strVar4Cond_2 = ", " + strVar4Cond;
                    }
                    if (objFieldTab_Sort != null)
                    {
                        strVar4Sort = objFieldTab_Sort.PrivFuncName();
                        strVar4Sort_2 = ", " + strVar4Sort;
                    }

                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Ctrl.BindDdl_TrueAndFalse(\"{0}\");",
                                 objInfor.CtrlId);
                    }
                    else
                    {
                        if (objVarManage.AddVariable(new clsVariable(strVar4Cond)) == true)
                        {
                            string strVarDefStr = "";
                            if (objViewInfoENEx.objCacheClassifyFld4View != null)
                            {
                                if (objViewInfoENEx.objCacheClassifyFld4View.FldName == objFieldTab_Cond.FldName)
                                {
                                    strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", strVarDef4ViewCacheFld);
                                }
                                else
                                {
                                    strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", "");
                                }
                            }
                            strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                            //生成缓存分类字段的检查代码，检查是否被赋正确值
                            clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objViewInfoENEx.objCacheClassifyFld4View, objFieldTab_Cond.PrivFuncName(), this.ClsName);
                        }

                        if (objVarManage.AddVariable(new clsVariable(strVar4Sort)) == true)
                        {
                            string strVarDefStr = "";
                            if (objViewInfoENEx.objCacheClassifyFld4View != null)
                            {
                                if (objViewInfoENEx.objCacheClassifyFld4View.FldName == objFieldTab_Sort.FldName)
                                {
                                    strVarDefStr = objVarManage.DefVariable(strVar4Sort, "\"\"", strVarDef4ViewCacheFld);
                                }
                                else
                                {
                                    strVarDefStr = objVarManage.DefVariable(strVar4Sort, "\"\"", "");
                                }
                            }
                            strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                            //生成缓存分类字段的检查代码，检查是否被赋正确值
                            clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objViewInfoENEx.objCacheClassifyFld4View, objFieldTab_Cond.PrivFuncName(), this.ClsName);
                        }

                        if (objInfor.objFieldTab_CacheClassify() == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = await {3}_BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond {6} {7});//{4}",
                                        objInfor.FldName,
                                         objInfor.objFieldTab_ValueField.FldName,
                                        objInfor.CtrlId,
                                        objInfor.Ds_TabName,
                                        clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                                        objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "",
                                        strVar4Cond_2,
                                        strVar4Sort_2);
                        }
                        else
                        {

                            string strVariableName = string.Format("{0}{1}",
                                objInfor.objFieldTab_CacheClassify().PrivFuncName(), 
                                objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            if (objVarManage.AddVariable(new clsVariable(strVariableName)) == true)
                            {
                                string strVarDefStr = "";
                                if (objViewInfoENEx.objCacheClassifyFld4View != null)
                                {
                                    if (objViewInfoENEx.objCacheClassifyFld4View.FldName == objInfor.objFieldTab_CacheClassify().FldName)
                                    {
                                        strVarDefStr = objVarManage.DefVariable(strVariableName, "\"\"", strVarDef4ViewCacheFld);
                                    }
                                    else
                                    {
                                        strVarDefStr = objVarManage.DefVariable(strVariableName, "\"\"", strVarDef4ViewCacheFld);
                                    }
                                }
                                strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                                //生成缓存分类字段的检查代码，检查是否被赋正确值
                                clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objViewInfoENEx.objCacheClassifyFld4View, objFieldTab_Cond.PrivFuncName(), this.ClsName);
                                strCodeForCs.AppendFormat("\r\n" + "//var {0}{2} = \"\";//定义条件字段",
                                    objInfor.objFieldTab_CacheClassify().PrivFuncName(), objInfor.objFieldTab_CacheClassify().ObjDataTypeAbbr().TypeScriptType,
                                    objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            }

                            //strCodeForCs.AppendFormat("\r\n" + "var {0}{2} = \"\";",
                            //         objInfor.objFieldTab_ConditionField.PrivFuncName(),
                            //         objInfor.objFieldTab_ConditionField.ObjDataTypeAbbr().TypeScriptType,
                            //         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            string strVar4CacheClassify = objInfor.objFieldTab_CacheClassify().PrivFuncName();
                            if (strVar4Cond == strVar4CacheClassify)
                            {
                                strVar4Cond_2 = "";
                            }
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = await {3}_BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond, {5}{6} {7});//{4}",
                                 objInfor.FldName,
                                 objInfor.objFieldTab_ValueField.FldName,
                                objInfor.CtrlId, 
                                objInfor.Ds_TabName, 
                                clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                                objInfor.objFieldTab_CacheClassify().PrivFuncName(),
                                objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "",
                                strVar4Cond_2,
                                strVar4Sort_2);
                        }
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
            return strCodeForCs.ToString();
        }

        Func<clsQryRegionFldsENEx, ASPDropDownListEx> GetDdlObj = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        public string Gen_WApi_Ts_SetBindDdl4QryRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                List<string> arrDropDownTypeLst = new List<string> { enumCtlTypeAbbr.DropDownList_06, enumCtlTypeAbbr.DropDownList_Bool_18 };
                IEnumerable<clsQryRegionFldsENEx> arrERF4DropDownLst = objViewInfoENEx.arrQryRegionFldSet
                    .Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId) && x.InUse == true);
                IEnumerable<ASPDropDownListEx> arrASPDropDownListObj = arrERF4DropDownLst.Select(GetDdlObj);

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj)
                {
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendLine(objInfor.GC_SetBindDdl4Bool_TS());
                    }
                    else
                    {
                        strCodeForCs.Append(objInfor.GC_SetBindDdl_TS4QryRegion());
                    }
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
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
                    if (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName == "DropDownList")
                    {
                        if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "boolean")
                        {
                            //strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.BindDdl_TrueAndFalse(ddl{0}_q);",
                            //            objQryRegionFldsEx.FldName);
                        }
                        else
                        {
                            string strDS_DataValueField;
                            string strDS_DataTextField;
                            string strDs_TabName;
                            string strDS_TabCnName;
                            try
                            {
                                clsPrjTabEN objPrjTab = clsQryRegionFldsBLEx.Ds_PrjTab4Get(objQryRegionFldsEx);
                                strDs_TabName = objPrjTab.TabName;
                                strDS_TabCnName = objPrjTab.TabCnName;
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源表名出错:{2}.",
                                objViewInfoENEx.ViewName, "查询区域", objException.Message);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDs_TabName) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 数据源表名为空，请检查!({2}).",
                                objViewInfoENEx.ViewName, "查询区域", clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            try
                            {
                                strDS_DataValueField = clsQryRegionFldsBLEx.Ds_DataValueField4Get(objQryRegionFldsEx);
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源值字段名时出错:{2}.<br/>数据源表名为:{3}.",
                                objViewInfoENEx.ViewName, "查询区域", objException.Message, strDs_TabName);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDS_DataValueField) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源值字段名时出错.<br/>数据源表名为:{2}.({3})",
                                    objViewInfoENEx.ViewName, "查询区域", strDs_TabName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            try
                            {
                                strDS_DataTextField = clsQryRegionFldsBLEx.Ds_DataTextField4Get(objQryRegionFldsEx);
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源文本字段名时出错:{2}.<br/>数据源表名为:{3},值字段名为:{4}.",
                                objViewInfoENEx.ViewName, "查询区域", objException.Message, strDs_TabName, strDS_DataValueField);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDS_DataTextField) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源文本字段名时出错.<br/>数据源表名为:{2},值字段名为:{3}.({4})",
                                      objViewInfoENEx.ViewName, "查询区域", strDs_TabName, strDS_DataValueField,
                                      clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            if (arrDdlKeyIdLst.Contains(strDS_DataValueField) == false)
                            {
                                arrDdlKeyIdLst.Add(strDS_DataValueField);
                            }
                            else
                            {
                                continue;
                            }
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

                                    strCodeForCs.AppendFormat("\r\n /*绑定下拉框:ddl{0}的函数。", objQryRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "*/");

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

                                    strCodeForCs.Append("\r\n" + "/// <summary>");
                                    strCodeForCs.AppendFormat("\r\n" + "/// 为下拉框获取数据,从表:[{0}]中获取",
                                      strDs_TabName);
                                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "/// </summary>");
                                    strCodeForCs.Append("\r\n" + "/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>");
                                    strCodeForCs.AppendFormat("\r\n" + "public BindDdl_{1}(ddl{1}: string, strWhereCond:string=\"1=1\") {{",
                                      strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "//let strWhereCond = \" 1 =1 \";");
                                    strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(ddl{1});",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"下拉框：{{0}} 不存在！\", ddl{1});",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

                                    strCodeForCs.Append("\r\n" + "try");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}_GetObjLstAsync(strWhereCond);",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);

                                    //this.BindTab_{0}(strListDiv, arr{0}ObjLst);
                                    strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.BindDdl_ObjLst(ddl{1}, arr{0}ObjLst, cls{0}EN.con_{1}, cls{0}EN.con_{2}, \"{3}\");",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField, strDS_TabCnName);
                                    strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成BindDdl_{0}!\");", strDS_DataValueField);

                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "catch (e)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "const strMsg = `绑定查询区下拉框不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "});");
                                    strCodeForCs.Append("\r\n" + "}");


                                    break;
                                case "03": ///列表项数据源SQL串;
                                    strCodeForCs.Append("\r\n" + "/// <summary>");
                                    strCodeForCs.AppendFormat("\r\n" + "/// 为下拉框获取数据,从Sql串:[{0}]中获取",
                                       objQryRegionFldsEx.Ds_SQLStr);
                                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "/// </summary>");
                                    strCodeForCs.Append("\r\n" + "/// <returns>获取自定义的Sql串中两列的所有记录记录的DataTable</returns>");

                                    strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}(string strCondition)",
                                    objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
                                    //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}BL.GetSpecSQLObj();", objViewInfoENEx.TabName);

                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable({0});",
                                    objQryRegionFldsEx.Ds_SQLStr);
                                    strCodeForCs.Append("\r\n" + "return objDT;");
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.Append("\r\n /* 绑定基于Web的下拉框");
                                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n  <param name = \"objDDL\">需要绑定当前表的下拉框</param>");
                                    strCodeForCs.Append("\r\n" + "*/");

                                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                    objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                                    objQryRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};",
                                      strDs_TabName, strDS_DataValueField);
                                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};",
                                      strDs_TabName, strDS_DataTextField);
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


        public string Gen_WApi_Ts_DdlBind4ViewFeatureInPage_Load()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strCacheClassifyFldName4View = "";
            if (objViewInfoENEx.objCacheClassifyFld4View != null)
            {
                strCacheClassifyFldName4View = objViewInfoENEx.objCacheClassifyFld4View.FldName;
            }
                string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {


                //clsASPDropDownListBLEx.
                List<string> arrDropDownTypeLst = new List<string> { enumCtlTypeAbbr.DropDownList_06, enumCtlTypeAbbr.DropDownList_Bool_18 };

                //从界面功能字段中获取下拉框字段

                IEnumerable<clsvViewFeatureFldsENEx> arrWFF4DropDownLst = objViewInfoENEx.arrvViewFeatureFlds.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                List<ASPDropDownListEx> arrASPDropDownListObj4WFF = arrWFF4DropDownLst
                    .Select(GetDdlObj2).Distinct(new ASPDropDownListEx4GCComparer()).ToList();

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {
                    string strCtrlId = objInfor.CtrlId;
                    if (objInfor.FeatureId == enumPrjFeature.SetFieldValue_0148)
                    {
                        if (strCtrlId.IndexOf("_SetFldValue") == -1)
                        {
                            strCtrlId = strCtrlId + "_SetFldValue";
                            objInfor.CtrlId = strCtrlId;
                        }
                    }
                    strCodeForCs.AppendFormat("\r\n" + objInfor.GC_BindDdl4WA_TS(objVarManage, strCacheClassifyFldName4View, strVarDef4ViewCacheFld, objInfor.objFieldTab_CacheClassify()));
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
            if (objViewInfoENEx.arrQryRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有查询区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            if (objViewInfoENEx.arrDGRegionFldSet == null || objViewInfoENEx.arrDGRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有DataGrid区域,或者DataGrid区域没有字段。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
          
            string strFuncName = "";
            string strTemp = ""; ///临时变量;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleId_Cache(objViewInfoENEx.objViewStyleEN.DgStyleId);

            objViewInfoENEx.WebFormName = objViewInfoENEx.ClsName;
            objViewInfoENEx.WebFormFName = string.Format("{0}.ts", objViewInfoENEx.ClsName);

            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            
            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeId_Cache(objViewInfoENEx.CodeTypeId);
            if (objCodeType.IsDirByTabName == false)
            {
                strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName, objViewInfoENEx.WebFormFName);
            }
            else
            {
                strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objViewInfoENEx.TabName, objViewInfoENEx.WebFormFName);
            }
            //strXmlFileName = strXmlFileName.ToLower();
            //objViewInfoENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjId_Cache(objViewInfoENEx.PrjId); //
            try
            {
                //类名开始
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx));

                strCodeForCs.AppendFormat("\r\n" + "///// <reference path=\"../../scripts/typings/jquery/jquery.d.ts\" />");
                strCodeForCs.AppendFormat("\r\n" + "///// <reference path=\"../../scripts/typings/q/q.d.ts\" />");
                strCodeForCs.AppendFormat("\r\n" + "///// <reference path=\"../../scripts/typings/handlebars/handlebars.d.ts\" />");
                strCodeForCs.AppendFormat("\r\n" + "//import * as $ from \"jquery\";");
                strCodeForCs.AppendFormat("\r\n" + "//import * as QQ from \"q\";");


                strCodeForCs.AppendFormat("\r\n" + "import {{ cls{1}EN }} from \"../TS/L0_Entity/{0}/cls{1}EN.js\";",
                  objFuncModule.FuncModuleEnName,
                    objViewInfoENEx.TabName);
               
                strCodeForCs.AppendFormat("\r\n" + "import {{ cls{1}WApi, cls{1}BL }} from \"../TS/L3_ForWApi/{0}/cls{1}WApi.js\";",
                     objFuncModule.FuncModuleEnName,
                       objViewInfoENEx.TabName);

                if (objViewInfoENEx.TabName != objViewInfoENEx.TabName_Out)
                {
                    strCodeForCs.AppendFormat("\r\n" + "import {{ cls{1}EN }} from \"../TS/L0_Entity/{0}/cls{1}EN.js\";",
                  objFuncModule.FuncModuleEnName,
                    objViewInfoENEx.TabName_Out);
                    strCodeForCs.AppendFormat("\r\n" + "import {{ cls{1}WApi, cls{1}BL  }} from \"../TS/L3_ForWApi/{0}/cls{1}WApi.js\";",
                         objFuncModule.FuncModuleEnName,
                           objViewInfoENEx.TabName_Out);
                }

                List<string> arrTabId4Ddl = clsViewInfoBLEx.getRelaTabId4Ddl_AllRegion(objViewInfoENEx.ViewId, objViewInfoENEx.PrjId);
                foreach (string strTabId in arrTabId4Ddl)
                {
                    if (strTabId == objViewInfoENEx.MainTabId) continue;
                    clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId_Cache(strTabId, objViewInfoENEx.PrjId);

                    clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabEN.FuncModuleAgcId, objPrjTabEN.PrjId);

                    strCodeForCs.AppendFormat("\r\n" + "import {{ cls{1}EN }} from \"../TS/L0_Entity/{0}/cls{1}EN.js\";",
    objFuncModule_AgcEN.FuncModuleEnName,
      objPrjTabEN.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "import {{ cls{1}WApi }} from \"../TS/L3_ForWApi/{0}/cls{1}WApi.js\";",
                         objFuncModule_AgcEN.FuncModuleEnName,
                          objPrjTabEN.TabName);
                }
                

                strCodeForCs.Append("\r\n" + "import { clsPager } from \"../TS/PubFun/clsPager.js\";");
                strCodeForCs.Append("\r\n" + "import { clsStackTrace } from \"../TS/PubFun/clsStackTrace.js\";");
                strCodeForCs.Append("\r\n" + "import { clsOrderByData } from \"../TS/PubFun/clsOrderByData.js\";");
                strCodeForCs.Append("\r\n" + "import { stuPagerPara } from \"../TS/PubFun/stuPagerPara.js\";");
                strCodeForCs.Append("\r\n" + "import { clsDataColumn } from \"../TS/PubFun/clsDataColumn.js\";");
                strCodeForCs.Append("\r\n" + "import {arrSelectedKeys, clsCommFunc4Web } from \"../TS/PubFun/clsCommFunc4Web.js\";");
                strCodeForCs.Append("\r\n" + "import { TransToBool } from \"../TS/PubFun/jsString.js\";");
                //if (objViewInfoENEx.IsUseCache4List)
                //{
                strCodeForCs.Append("\r\n" + "import { clsPubFun } from \"../TS/PubFun/clsPubFun.js\";");
                strCodeForCs.Append("\r\n" + "import { clsPubSessionStorage } from \"../TS/PubFun/clsPubSessionStorage.js\";");
                strCodeForCs.Append("\r\n" + "import { Format, IsNullOrEmpty } from \"../TS/PubFun/clsString.js\";");
                //}

                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + "* 宣布一个已经在其他地方定义存在的变量strUrl_Session_SetString，");
                strCodeForCs.Append("\r\n" + "* 用于定义处理Session-设置String函数的地址");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "declare var strUrl_Session_SetString:string;");
                strCodeForCs.Append("\r\n" + "declare var strUrl_Session_GetString: string;");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + "* 宣布一个已经在其他地方定义存在的变量strCurrPrjId，");
                strCodeForCs.Append("\r\n" + "* 用于定义当前工程Id");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "declare var strCurrPrjId: string;");

                strCodeForCs.Append("\r\n" + "declare var $;");


                strCodeForCs.AppendFormat("\r\n /* {0} 的摘要说明。其中Q代表查询,U代表修改",
                    objViewInfoENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "export class {0} ", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objCacheClassifyFld4View != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public static {0}_Cache= \"\";//缓存分类字段",
                        objViewInfoENEx.objCacheClassifyFld4View.FldName);
                }
                List<string> arrFldName4StaticKeyId = new List<string>();
                var objFeatureRegionFlds_Detail = objViewInfoENEx.arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.DetailRecord_0239);
                if (objFeatureRegionFlds_Detail != null && objFeatureRegionFlds_Detail.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
                {
                    if (arrFldName4StaticKeyId.Contains(objKeyField.FldName) == false)
                    {
                        arrFldName4StaticKeyId.Add(objKeyField.FldName);
                    }
                }
                List<string> arrFeatureId = new List<string>() { enumPrjFeature.UpdateRecord_0137, enumPrjFeature.UpdateRecord_0199 };
                var objFeatureRegionFlds_Update = objViewInfoENEx.arrFeatureRegionFlds.Find(x => arrFeatureId.Contains(x.FeatureId));

                if (objFeatureRegionFlds_Update != null && objFeatureRegionFlds_Update.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
                {
                    if (arrFldName4StaticKeyId.Contains(objKeyField.FldName) == false)
                    {
                        arrFldName4StaticKeyId.Add(objKeyField.FldName);
                    }
                }
                arrFldName4StaticKeyId.ForEach(x=> {
                    string strDefaValue = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DefaValue;
                    if (string.IsNullOrEmpty(strDefaValue) == true) strDefaValue = "\"\"";
                    strCodeForCs.AppendFormat("\r\n" + "public static {0}_Static: {1} = {2};//静态关键字",
                   x,
                   objKeyField.TypeScriptType, strDefaValue);
                });

                List<string> arrVarName = new List<string>();
                var arrQryRegionFlds = objViewInfoENEx.arrQryRegionFldSet.Where(x => x.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38);
                if (arrQryRegionFlds.Count() > 0)
                {
           
                    foreach (var objInFor in arrQryRegionFlds)
                    {
                        string strVarName = "";
                        string strInitValue = "";
                        var objVar = clsGCVariableBL.GetObjByVarId_Cache(objInFor.VarId, objViewInfoENEx.PrjId);
                        if (objVar != null)
                        {
                            strVarName = objVar.VarExpression;
                            if (objInFor.ObjFieldTabENEx.TypeScriptType == "number")
                            {
                                strInitValue = objVar.InitValue;
                            }
                            else
                            {
                                strInitValue = string.Format("\"{0}\"", objVar.InitValue);
                            }
                        }
                        if (arrVarName.Contains(strVarName) == false && string.IsNullOrEmpty(strVarName) == false)
                        {
                            strCodeForCs.AppendFormat("\r\n" + " public static {0}: {1} = {2};//查询区静态界面变量",

                                    strVarName,
                                    objInFor.ObjFieldTabENEx.TypeScriptType,
                                    strInitValue);
                            arrVarName.Add(strVarName);
                        }
                    }
                }
                var arrEditRegionFlds = objViewInfoENEx.arrEditRegionFldSet.Where(x => x.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38);
                if (arrEditRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrEditRegionFlds)
                    {
                        string strVarName = "";
                        string strInitValue = "";
                        var objVar = clsGCVariableBL.GetObjByVarId_Cache(objInFor.VarId, objViewInfoENEx.PrjId);
                        if (objVar != null)
                        {
                            strVarName = objVar.VarExpression;
                            if (objInFor.ObjFieldTabENEx.TypeScriptType == "number")
                            {
                                strInitValue = objVar.InitValue;
                            }
                            else
                            {
                                strInitValue = string.Format("\"{0}\"", objVar.InitValue);
                            }
                        }
                        if (arrVarName.Contains(strVarName) == false && string.IsNullOrEmpty(strVarName) == false)
                        {
                            strCodeForCs.AppendFormat("\r\n" + " public static {0}: {1} = {2};//编辑区静态界面变量",

                                    strVarName,
                                    objInFor.ObjFieldTabENEx.TypeScriptType,
                                    strInitValue);
                            arrVarName.Add(strVarName);
                        }
                    }
                }

                //strCodeForCs.Append("\r\n" + "private strInfo = \"\";");
                //strCodeForCs.Append("\r\n" + "private strWhereCond = \"\";");
                strCodeForCs.Append("\r\n" + "public mstrListDiv = \"divDataLst\";//列表区数据列表层id");
                strCodeForCs.Append("\r\n" + "public bolIsLoadEditRegion = false;  //记录是否导入编辑区的变量");
                strCodeForCs.Append("\r\n" + "public bolIsLoadDetailRegion = false;  //记录是否导入详细信息区的变量");

                strCodeForCs.Append("\r\n" + "public divName4Edit = \"divEdit\";  //编辑区的Id");
                strCodeForCs.Append("\r\n" + "public divName4Detail = \"divDetail\";  //详细信息区的Id");

                

                strCodeForCs.Append("\r\n" + "public objPager: clsPager = new clsPager();");
                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 每页记录数，在扩展类可以修改");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "public get pageSize():number {");
                strCodeForCs.Append("\r\n" + "return 5;");
                strCodeForCs.Append("\r\n" + "}");
     
                strCodeForCs.Append("\r\n" + "public recCount = 0;");

                strCodeForCs.Append("\r\n" + "");

      

                /////生成界面中Page_Load代码;
                //strCodeForCs.Append("\r\n" + "#region 页面启动函数");

                /////生成界面中Page_Load代码;
                //strTemp = GenPage_LoadCode(false);
                //strCodeForCs.Append(strTemp);
                //strCodeForCs.Append("\r\n" + "#endregion 页面启动函数");
                //生成所有的函数
                IEnumerable <clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                    clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);

                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                //  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                //          objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);
                
                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstByFeature = objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst;
                //arrvFunction4GeneCodeObjLstByFeature = arrvFunction4GeneCodeObjLstByFeature.Where(x => x.CodeTypeId == objViewInfoENEx.CodeTypeId);

                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst.Union(arrvFunction4GeneCodeObjLstByFeature, 
                //    new VFunction4GeneCodeComparer());                
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

                clsPubFun4GC.Gen_WApi_Ts_ControlProperty(strCodeForCs, arrPropertyDef4GC, "this.divName4Query");
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

        public class PropertyDef4GCComparer : IEqualityComparer<clsPropertyDef4GC>
        {
            public bool Equals(clsPropertyDef4GC t1, clsPropertyDef4GC t2)
            {
                return (t1.OperateType == t2.OperateType && t1.PropertyName == t2.PropertyName);
            }
            public int GetHashCode(clsPropertyDef4GC t)
            {
                return t.ToString().GetHashCode();
            }
        }
        public void Gen_WApi_Ts_ControlPropertyBak(StringBuilder strCodeForCs)
        {
            var arrPropertyDef4GC2 = arrPropertyDef4GC.OrderBy(x => x.PropertyName).Distinct(new PropertyDef4GCComparer()).ToList();

            arrPropertyDef4GC2.ForEach(x =>
            {
                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * {0}", x.Comment);
                //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
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
                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                break;
                            case "button":
                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").html();", x.CtrlId);
                                break;
                            case "dropdownlist":
                            case "DropDownList":
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return \"\";", x.CtrlId);

                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                break;
                            case "ViewVariable":
                                strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在，直接返回");
                                strCodeForCs.Append("\r\n" + "var strValue:string = sessionStorage.getItem(strKey) as string;");
                                strCodeForCs.Append("\r\n" + "return strValue;");

                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                break;
                            case "objCacheClassifyFld_TS":
                                strCodeForCs.Append("\r\n" + "//缓存分类字段(objCacheClassifyFld_TS)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在，直接返回");
                                strCodeForCs.Append("\r\n" + "var strValue:string = sessionStorage.getItem(strKey) as string;");
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
                                strCodeForCs.Append("\r\n" + "//缓存存在，直接返回");
                                strCodeForCs.Append("\r\n" + "var strValue:string = sessionStorage.getItem(strKey) as string;");
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
                                strCodeForCs.Append("\r\n" + "//缓存存在，直接返回");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");                                
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");                                
                                break;
                            case "CacheClassifyField_TS":
                                strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyField_TS)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在，直接返回");
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
                                strCodeForCs.Append("\r\n" + "//缓存存在，直接返回");
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

        public string Gen_WApi_Ts_BindTab(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds_GridRegion = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.RegionId == objViewInfoENEx.objViewRegion_Feature.RegionId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n /* 显示{0}对象的所有属性值", objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n  <param name = \"divContainer\">显示容器</param>");
            strCodeForCs.AppendFormat("\r\n  <param name = \"arr{0}ObjLst\">需要绑定的对象列表</param>",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "*/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindTab_{0}(divContainer: string, arr{0}ObjLst: Array<cls{0}EN>) ",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindTab_{0}.name;",
objViewInfoENEx.TabName_Out, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.Append("\r\n" + "const o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;");
            strCodeForCs.Append("\r\n" + "if (o == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}不存在！\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "var sstrFldName: Array < string > = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "var sstrColHeader: Array < string > = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "sstrFldName.push(\"IdentityID\"); sstrColHeader.push(\"身份Id\");");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array < clsDataColumn > =");
            strCodeForCs.Append("\r\n" + "       [");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "fldName: \"\",");
            strCodeForCs.Append("\r\n" + "sortFun: clsPubFun4Web.SortFun,");
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

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"{0}\",", objDGRegionFldsENEx.FldName_Lcase);
                strCodeForCs.Append("\r\n" + "sortFun: clsPubFun4Web.SortFun,");
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
                strCodeForCs.Append("\r\n" + "sortFun: clsPubFun4Web.SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"修改\",");
                strCodeForCs.Append("\r\n" + "text: \"修改\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "var btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", `btnUpdateRecordInTab_Click('${strKeyId}');`);");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");             
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DelRecord_Gv_0175).Count() > 0)            
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: clsPubFun4Web.SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"删除\",");
                strCodeForCs.Append("\r\n" + "text: \"删除\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "var btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", `btnDelRecordInTab_Click('${strKeyId}');`);");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DetailRecord_Gv_0181).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: clsPubFun4Web.SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"详细信息\",");
                strCodeForCs.Append("\r\n" + "text: \"详细信息\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "var btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", `btnDetailRecordInTab_Click('${strKeyId}');`);");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");
                
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.SelectRecord_Gv_0182).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: clsPubFun4Web.SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"选择\",");
                strCodeForCs.Append("\r\n" + "text: \"选择\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "var btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", `btnSelectRecordInTab_Click('${strKeyId}');`);");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");

            }
            strCodeForCs.Append("\r\n" + "];");
            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.BindTabV3(o, arr{0}ObjLst, arrDataColumn,  cls{0}EN.con_{1}, this); ",
                objViewInfoENEx.TabName_Out, objKeyField.FldName);
            
            strCodeForCs.Append("\r\n" + "this.objPager.recCount = this.recCount;");
            strCodeForCs.Append("\r\n" + "this.objPager.pageSize = this.pageSize;");
            strCodeForCs.Append("\r\n" + "this.objPager.ShowPager();");
            
            //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager.html\");");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_Demo_Session(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "演示Session 操作");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public async Demo_Session()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//设置Session");
            strCodeForCs.Append("\r\n" + "var strUserId = \"TestUserId\";");
            strCodeForCs.Append("\r\n" + "await this.SetSessionAsync(\"UserId\", strUserId);");
            strCodeForCs.Append("\r\n" + "//获取Session");
            strCodeForCs.Append("\r\n" + "var strUserId_Value1 = await this.GetSessionAsync(\"UserId\");");
            strCodeForCs.Append("\r\n" + "console.log('strUserId_Value1:' + strUserId_Value1);");
            strCodeForCs.Append("\r\n" + "//获取Session方法2：直接读取页面中的hidUserId");
  //          strCodeForCs.Append("\r\n" + "var strUserId_Value2 = $('#hidUserId').val();");
            strCodeForCs.Append("\r\n" + "var strUserId_Value2 = this.hidUserId;");
        

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "get",
                ControlType = "input",
                CtrlId = "hidUserId",
                PropertyName = "hidUserId",
                Comment = "用户Id",
                DataType = "string"
            });
            strCodeForCs.Append("\r\n" + "console.log('strUserId_Value2:' + strUserId_Value2);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"演示Session不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_SetSessionAsync(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "设置Session");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "<param name = \"Key\">关键字</param>");
            strCodeForCs.Append("\r\n" + "<param name = \"Value\">值</param>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public SetSessionAsync(Key: string, Value: string): Promise<void> {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SetSessionAsync.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

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
            strCodeForCs.Append("\r\n" + "success: function (data) {");
            strCodeForCs.Append("\r\n" + "var strKey = data.key;");
            strCodeForCs.Append("\r\n" + "var strValue = data.value;");

       
            strCodeForCs.Append("\r\n" + "console.log('strKey, strValue=' + strKey + strValue);");

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
            strCodeForCs.Append("\r\n" + "获取Session 关键字的值");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "<param name = \"Key\">关键字</param>");
            strCodeForCs.Append("\r\n" + " <return>值</return>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public GetSessionAsync(Key: string): Promise<string> {");

            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetSessionAsync.name;",
objPrjTabENEx.TabName, objKeyField.FldName);

            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");


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
            strCodeForCs.Append("\r\n" + "var strKey = data.key;");
            strCodeForCs.Append("\r\n" + "var strValue = data.value;");

            strCodeForCs.Append("\r\n" + "console.log('strKey, strValue=' + strKey + strValue);");

            strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"网络错误！访问网络不成功！\");");
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
                        strCodeForCs.Append("\r\n" + "/// <summary>");
                        strCodeForCs.Append("\r\n" + "/// 在用户自定义控件中，设置关键字的值，是否只读");
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + "/// </summary>");
                        strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">是否只读</param>");
                        strCodeForCs.Append("\r\n" + "public SetKeyReadOnly(bolReadonly:boolean)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SetSessionAsync.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
                        //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

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
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_Clear()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //生成私有代码;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 清除用户自定义控件中，所有控件的值");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>	");
                strCodeForCs.Append("\r\n" + "public Clear()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Clear.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.InUse == false) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx == null) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
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
                            PropertyName = objEditRegionFldsEx.PropertyName(),
                            Comment = string.Format("{0} (Used In {1})", objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "Clear()"),
                            DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType
                        });
                        string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = false;",
                                    objEditRegionFldsEx.PropertyName());
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                    objEditRegionFldsEx.PropertyName(),
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
                                strCodeForCs.AppendFormat("\r\n" + "$('#{0} option[0]').attr(\"selected\", true);",
                                objEditRegionFldsEx.CtrlId);
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
                                    objEditRegionFldsEx.PropertyName(), strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = \"{1}\";",
                                        objEditRegionFldsEx.PropertyName(), objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }

                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                 objEditRegionFldsEx.PropertyName(), strInitValue);
                                break;
                        }
                    }
                    catch(Exception objException)
                    {
                        string strMsg = string.Format("生成字段:{0}时出错！{1}(In {2})", objEditRegionFldsEx.PropertyName(),
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
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_CopyRecord()
        {
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
                        objFieldTab_Copy = clsFieldTabBL.GetObjByFldId_Cache(objFeature_AdditionalCopy.ReleFldId, objViewInfoENEx.PrjId);
                    }
                }
                strCodeForCs.Append("\r\n /* 复制记录");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public async CopyRecord(arr{0}: Array<string>) {{", objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}_GetObjLstBy{1}LstAsync(arr{1});",
                    objViewInfoENEx.TabName_In, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "console.log('responseText=');");
                strCodeForCs.Append("\r\n" + "console.log(responseText);");
                strCodeForCs.Append("\r\n" + "let intCount = 0;");

                strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ObjLst)",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "{");
                if (objFieldTab_Copy == null)
                {
                    //strCodeForCs.Append("\r\n" + "objInFor.ExamTypeName = \"C_\" + objInFor.ExamTypeName;");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "objInFor.{0} =\"{1}\" + objInFor.{0};",
                        objFieldTab_Copy.PropertyName(), strCopyValue);
                }
                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strMaxStrId = await {0}_GetMaxStrIdAsync();",
                        objViewInfoENEx.TabName_In);
                    strCodeForCs.Append("\r\n" + "console.log('strMaxStrId=' + strMaxStrId);");
                    strCodeForCs.AppendFormat("\r\n" + "objInFor.{0} = strMaxStrId;", objKeyField.PropertyName());
                }
                strCodeForCs.AppendFormat("\r\n" + "const returnBool = await {0}_AddNewRecordAsync(objInFor);", objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "console.log('returnBool=');");
                strCodeForCs.Append("\r\n" + "console.log(returnBool);");
    
                strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                strCodeForCs.Append("\r\n" + "{");
                Gene_ReFreshCache(strCodeForCs);

                strCodeForCs.Append("\r\n" + "const strInfo = Format(\"克隆记录成功!\");");
                strCodeForCs.Append("\r\n" + "intCount++;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strInfo = Format(\"克隆记录不成功!\");");
                //strCodeForCs.Append("\r\n" + "$('#lblResult20').val(strInfo);");
                strCodeForCs.Append("\r\n" + "//显示信息框");
                strCodeForCs.Append("\r\n" + "alert(strInfo);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "const strInfo = Format(\"共克隆了{0}条记录!\", intCount);");
                //strCodeForCs.Append("\r\n" + "$('#lblResult20').val(strInfo);
                strCodeForCs.Append("\r\n" + "alert(strInfo);");
                strCodeForCs.Append("\r\n" + "console.log('完成！');");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"复制记录不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
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
            return strCodeForCs.ToString();
        }
   
        public string Gen_WApi_Ts_btnOKUpd_Click()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,");
                strCodeForCs.Append("\r\n  具体功能为把界面内容同步数据库中,把界面内容保存到数据库中");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "public async btnSubmit_Click()");
                strCodeForCs.Append("\r\n" + "{");
                
                strCodeForCs.AppendFormat("\r\n" + "const strCommandText: string = this.btnSubmit_{0};", objViewInfoENEx.TabName_In);

                clsPropertyDef4GC objPropertyDef4GC = new clsPropertyDef4GC
                {
                    OperateType = "get",
                    ControlType = "button",
                    CtrlId = string.Format("btnSubmit_{0}", objViewInfoENEx.TabName_In),
                    PropertyName = string.Format("btnSubmit_{0}", objViewInfoENEx.TabName_In),
                    Comment = "获取按钮的标1题",
                    DataType = "string"
                };
                arrPropertyDef4GC.Add(objPropertyDef4GC);

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "get",
                    ControlType = "input",
                    CtrlId = "hidOpType",
                    PropertyName = "OpType",
                    Comment = "设置操作类型：Add||Update||Detail",
                    DataType = "string"
                });

                strCodeForCs.Append("\r\n" + "try {");
                //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN;",
                //objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "switch(strCommandText)");
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                {

                    strCodeForCs.Append("\r\n" + "case \"添加\":");
                    strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_{0} = \"确认添加\";", objViewInfoENEx.TabName_In);
                    strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_{0} = \"取消添加\";", objViewInfoENEx.TabName_In);

                    strCodeForCs.AppendFormat("\r\n" + "const responseText1 = await this.AddNewRecord();",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "break;				");
                    strCodeForCs.Append("\r\n" + "case \"确认添加\":");
                    strCodeForCs.Append("\r\n" + "//这是一个单表的插入的代码,由于逻辑层太简单,");
                    strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");
                    strCodeForCs.Append("\r\n" + "if (this.OpType == \"AddWithMaxId\")");
                    strCodeForCs.Append("\r\n" + "{");
                    if (objKeyField.CsType != "string")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "//const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{{",
                              objViewInfoENEx.TabName);
                        strCodeForCs.Append("\r\n" + "//var returnBool2: boolean = jsonData;");
                        strCodeForCs.Append("\r\n" + "//if (returnBool2 == true)");
                        strCodeForCs.Append("\r\n" + "//{");
                        strCodeForCs.AppendFormat("\r\n" + "//HideDialog_{0}();", objViewInfoENEx.TabName_In);
                        strCodeForCs.AppendFormat("\r\n" + "//this.BindGv_{0}{1}();", objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");
                        strCodeForCs.Append("\r\n" + "//}");
                        strCodeForCs.Append("\r\n" + "//});");

                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "var returnBool2 = await this.AddNewRecordWithMaxIdSave();",
                              objViewInfoENEx.TabName);     
                        strCodeForCs.Append("\r\n" + "if (returnBool2 == true)");
                        strCodeForCs.Append("\r\n" + "{");
                

                        strCodeForCs.AppendFormat("\r\n" + "this.HideDialog_{0}();", objViewInfoENEx.TabName_In);

                        strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List?"_Cache":"");
                        
                        strCodeForCs.Append("\r\n" + "}");
         
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const returnBool = await this.AddNewRecordSave();",
                          objViewInfoENEx.TabName);      
                    strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "this.HideDialog_{0}();", objViewInfoENEx.TabName_In);
                    strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");
                    strCodeForCs.Append("\r\n" + "}");
              
                    strCodeForCs.Append("\r\n" + "}");
                  
                    strCodeForCs.Append("\r\n" + "break;");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    strCodeForCs.Append("\r\n" + "case \"确认修改\":");
                    strCodeForCs.Append("\r\n" + "//这是一个单表的修改的代码,由于逻辑层太简单,");
                    //strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = (cls{0}EN) Session[\"obj{0}EN\"];",
                    //objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "const returnBool = await this.UpdateRecordSave();",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "let strInfo: string = returnBool ? \"修改成功！\" : \"修改不成功！\";");
                    strCodeForCs.AppendFormat("\r\n" + "strInfo += \"(In {0}.btnSubmit_Click)\";",
                        objViewInfoENEx.ClsName);
                    //strCodeForCs.Append("\r\n" + "$('#l1blResult51').val(strInfo);");
                    strCodeForCs.Append("\r\n" + "//显示信息框");
                    strCodeForCs.Append("\r\n" + "console.log(strInfo);");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");

                    strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "this.HideDialog_{0}();", objViewInfoENEx.TabName_In);
                    strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");

                    strCodeForCs.Append("\r\n" + "}");
                    
                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.Append("\r\n" + "default:");
                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"strCommandText:{0}在switch中没有处理！(In btnSubmit_Click())\", strCommandText);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "break;");
                }
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"(errid: WiTsCs0033)在保存记录时({0})时出错!请联系管理员!{1}.(in {2}.{3})\", strCommandText, e, this.constructor.name, strThisFuncName);");
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
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_ShowTabObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 显示{0}对象的所有属性值");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n  <param name = \"divContainer\">显示容器</param>");
            strCodeForCs.AppendFormat("\r\n  <param name = \"obj{0}\">需要显示的对象</param>",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "public Show{0}Obj(divContainer: string, obj{0}: cls{0}EN) ",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Show{0}Obj.name;",
    objViewInfoENEx.TabName, objKeyField.FldName);

            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.Append("\r\n" + "var o = document.getElementById(divContainer);");
            strCodeForCs.Append("\r\n" + "if (o == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}不存在！\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const sstrKeys = clsCommFunc4Web.GetObjKeys(obj{0});",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "var ul: HTMLUListElement = document.createElement(\"ul\");");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}.GetFldValue(strKey);",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "var li: HTMLLIElement = document.createElement(\"li\");");
            strCodeForCs.Append("\r\n" + "li.innerHTML = Format(\"{0}:{1}\", strKey, strValue);");
            strCodeForCs.Append("\r\n" + "ul.appendChild(li);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "o.appendChild(ul);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_UpdateRecordBak(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据关键字获取相应的记录的对象");

            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n  <param name = \"sender\">参数列表</param>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "public async UpdateRecord({0}: {1}) ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            strCodeForCs.Append("\r\n" + "{");
                        
            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = string.Format("btnSubmit_{0}", objViewInfoENEx.TabName_In),
                PropertyName = string.Format("btnSubmit_{0}", objViewInfoENEx.TabName_In),
                Comment = "设置确定按钮的标题(Used In UpdateRecord())",
                DataType = "string"
            });

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            { 
                OperateType = "set",
                ControlType = "button",
                CtrlId = string.Format("btnCancel_{0}", objViewInfoENEx.TabName_In),
                PropertyName = string.Format("btnCancel_{0}", objViewInfoENEx.TabName_In),
                Comment = "设置取消按钮的标题(Used In UpdateRecord())",
                DataType = "string"
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

            //strCodeForCs.AppendFormat("\r\n" + "var strKeyId: string = $('#txtstrKeyId{0}').val();",
            //        objvFunction4GeneCodeEN.OrderNum);

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                //strCodeForCs.AppendFormat("\r\n" + "var {0}: {1} = strKeyId;",
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

                        //strCodeForCs.AppendFormat("\r\n" + "var {1}: {0} = Number(strKeyId);",
                        //    objDataTypeAbbrEN.TypeScriptType,
                        //    objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理！({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
           
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}_GetObjBy{1}Async({2});",
                objViewInfoENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据关键字:[{{0}}]获取对象：{{1}}!\", strKeyId, obj{0}EN.{1});",
            //    objViewInfoENEx.TabName,
            //    objKeyField.FldName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "this.GetDataFrom{0}Class(obj{0}EN);",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成UpdateRecord!\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_SelectRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n " + "根据关键字选择相应的记录");

            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n  <param name = \"sender\">参数列表</param>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "public async SelectRecord({0}: {1}) ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            strCodeForCs.Append("\r\n" + "{");


            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            //strCodeForCs.AppendFormat("\r\n" + "var strKeyId: string = $('#txtstrKeyId{0}').val();",
            //        objvFunction4GeneCodeEN.OrderNum);

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                //strCodeForCs.AppendFormat("\r\n" + "var {0}: {1} = strKeyId;",
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

                        //strCodeForCs.AppendFormat("\r\n" + "var {1}: {0} = Number(strKeyId);",
                        //    objDataTypeAbbrEN.TypeScriptType,
                        //    objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理！({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            //strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}_GetObjBy{1}Async({2});",
                objViewInfoENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);


            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成SelectRecord!\", obj{0}EN);", objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.Redirect(\"/Index/Main_{0}\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_DetailRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            //clsDetailRegionEN objDetailRegion = null;
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n " + "根据关键字详细信息记录");

            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n  <param name = \"sender\">参数列表</param>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "public async DetailRecord({0}: {1}) ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_d_{0} = \"\";", objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_d_{0} = \"关闭\";", objViewInfoENEx.TabName_Out);
            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = string.Format("btnSubmit_d_{0}", objViewInfoENEx.TabName_Out),
                PropertyName = string.Format("btnSubmit_d_{0}", objViewInfoENEx.TabName_Out),
                Comment = "设置确定按钮的标题(Used In DetailRecord())",
                DataType = "string"
            });

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = string.Format("btnCancel_d_{0}", objViewInfoENEx.TabName_Out),
                PropertyName = string.Format("btnCancel_d_{0}", objViewInfoENEx.TabName_Out),
                Comment = "设置取消按钮的标题(Used In DetailRecord())",
                DataType = "string"
            });
      
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
      
            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                //strCodeForCs.AppendFormat("\r\n" + "var {0}: {1} = strKeyId;",
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

                        //strCodeForCs.AppendFormat("\r\n" + "var {1}: {0} = Number(strKeyId);",
                        //    objDataTypeAbbrEN.TypeScriptType,
                        //    objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理！({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}_GetObjBy{1}Async({2});",
                objViewInfoENEx.TabName_Out,
                objKeyField.FldName,
                objKeyField.PrivFuncName);

            strCodeForCs.AppendFormat("\r\n" + "this.ShowDetailDataFrom{0}Class(obj{0}EN);",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成DetailRecord!\");", objViewInfoENEx.TabName_Out);
            
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
                       
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_QueryLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "public Query{0}Lst(strListDiv:string) ",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = this.Combine{0}Condition();", objViewInfoENEx.TabName_Out);
                        
            //strCodeForCs.Append("\r\n" + "var1 intCurrPageIndex = this.CurrPageIndex;//获取当前页");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.currPageIndex);//获取当前页");

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "get",
                ControlType = "input",
                CtrlId = "hidCurrPageIndex",
                PropertyName = "CurrPageIndex",
                Comment = "获取当前页序号(Used In QueryLst())",
                DataType = "number"

            });
            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var objPagerPara: stuPagerPara = {");
            strCodeForCs.Append("\r\n" + "pageIndex: intCurrPageIndex,");
            strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
            strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By,", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "sortFun: (x, y) => { console.log(x,y);return 0;}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = {0}_GetObjLstByPagerAsync(objPagerPara).then((jsonData)=>{{",
                objViewInfoENEx.TabName_Out);

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}]共获取对象列表数：{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
            //    objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(strListDiv, arr{1}ObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成Query{0}Lst!\");", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "resolve(jsonData);");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"查询对象列表不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_BindGv(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objViewInfoENEx.IsUseCache4List) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindGv_{0}() ",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = BindGv_{0}.name;", objViewInfoENEx.TabName_Out);

            strCodeForCs.AppendFormat("\r\n" + "if ({1}.sort{0}By == null)", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在显示列表时，排序字段(sort{0}By)为空，请检查！(In BindGv_{0})\");", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "const strListDiv: string = this.divName4DataList;");

            strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = this.Combine{0}Condition();", objViewInfoENEx.TabName_Out);
            //strCodeForCs.Append("\r\n" + "var1 intCurrPageIndex = this.CurrPageIndex;//获取当前页");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.currPageIndex);//获取当前页");

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "get",
                ControlType = "input",
                CtrlId = "hidCurrPageIndex",
                PropertyName = "CurrPageIndex",
                Comment = "获取当前页序号(Used In BindGv_)",
                DataType = "number"

            });

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");
            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst: Array <cls{0}EN> = [];", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseRecCount = await {0}_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {{",
objViewInfoENEx.TabName_Out);

            strCodeForCs.AppendFormat("\r\n" + "this.recCount = jsonData;");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "var intPageCount = this.objPager.GetPageCount(this.recCount, this.pageSize);");
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

            strCodeForCs.Append("\r\n" + "var objPagerPara: stuPagerPara = {");
            strCodeForCs.Append("\r\n" + "pageIndex: intCurrPageIndex,");
            strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
            strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By,", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "sortFun: (x, y) => { console.log(x,y);return 0;}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const responseObjLst = await {0}_GetObjLstByPagerAsync(objPagerPara).then((jsonData)=>{{",
                objViewInfoENEx.TabName_Out);

            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = < Array<cls{0}EN>>jsonData;",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"绑定GridView不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "var divPager: HTMLDivElement = < HTMLDivElement > document.getElementById(\"divPager\");");
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


            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement(\"span\");");
            strCodeForCs.Append("\r\n" + "lblMsg.innerHTML = \"根据条件获取的对象列表数为0！\";");
            strCodeForCs.Append("\r\n" + "const divDataLst: HTMLDivElement = < HTMLDivElement > document.getElementById(\"divDataLst\");");
            strCodeForCs.Append("\r\n" + "if (divDataLst != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divDataLst.innerText = \"\";");
            strCodeForCs.Append("\r\n" + "divDataLst.appendChild(lblMsg);");
            strCodeForCs.Append("\r\n" + "}");
       
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！\");");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}]共获取对象列表数：{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
            //    objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(strListDiv, arr{1}ObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成BindGv_{0}!\");", objViewInfoENEx.TabName_Out);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");
        

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"绑定对象列表不成功, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_BindGv_Cache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindGv_{0}_Cache() ",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindGv_{0}_Cache.name;", objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "if ({1}.sort{0}By == null)", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在显示列表时，排序字段(sort{0}By)为空，请检查！(In BindGv_{0}_Cache)\");", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "const strListDiv: string = this.divName4DataList;");

            strCodeForCs.AppendFormat("\r\n" + "var obj{0}_Cond = await this.Combine{0}ConditionObj();", objViewInfoENEx.TabName_Out);
            if (objViewInfoENEx.objCacheClassifyFld4View != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.{3}_Cache, \"=\");",
                        objViewInfoENEx.TabName_Out, 
                        objViewInfoENEx.objCacheClassifyFld4View.FldName,
                            objViewInfoENEx.ClsName,
                            objViewInfoENEx.objCacheClassifyFld4View.FldName);
            }
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = cls{0}BL.GetSimObjFromObj(obj{0}_Cond);", objViewInfoENEx.TabName_Out);
            //strCodeForCs.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = JSON.stringify(obj{0}EN_Sim);", objViewInfoENEx.TabName_Out);

            //strCodeForCs.Append("\r\n" + "var1 intCurrPageIndex = this.CurrPageIndex;//获取当前页");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.currPageIndex);//获取当前页");

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "get",
                ControlType = "input",
                CtrlId = "hidCurrPageIndex",
                PropertyName = "CurrPageIndex",
                Comment = "获取当前页序号(Used In BindGv_Cache)",
                DataType = "number"

            });

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");
            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst: Array <cls{0}EN> = [];", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objViewInfoENEx.objCacheClassifyFld4View == null)
            {
                
                strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCond_Cache(obj{0}_Cond);",
                    objViewInfoENEx.TabName_Out);
            }
            else
            {
            
                strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCond_Cache(obj{0}_Cond, {1}.{2}_Cache);",
                    objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName);
            }
            strCodeForCs.Append("\r\n" + "var intPageCount = this.objPager.GetPageCount(this.recCount, this.pageSize);");
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
            strCodeForCs.Append("\r\n" + "var objPagerPara: stuPagerPara = {");
            strCodeForCs.Append("\r\n" + "pageIndex: intCurrPageIndex,");
            strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
            strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By,", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "sortFun: (x, y) => { console.log(x,y);return 0;}");
            strCodeForCs.Append("\r\n" + "}");
            if (objViewInfoENEx.objCacheClassifyFld4View == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = await {0}_GetObjLstByPager_Cache(objPagerPara);",   objViewInfoENEx.TabName_Out);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = await {0}_GetObjLstByPager_Cache(objPagerPara, {1}.{2}_Cache);", objViewInfoENEx.TabName_Out,
                    objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName);
            }
      
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"绑定GridView不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "var divPager: HTMLDivElement = < HTMLDivElement > document.getElementById(\"divPager\");");
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


            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const lblMsg: HTMLSpanElement = < HTMLSpanElement > document.createElement(\"span\");");
            strCodeForCs.Append("\r\n" + "lblMsg.innerHTML = \"根据条件获取的对象列表数为0！\";");
            strCodeForCs.Append("\r\n" + "const divDataLst: HTMLDivElement = < HTMLDivElement > document.getElementById(\"divDataLst\");");
            strCodeForCs.Append("\r\n" + "if (divDataLst != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "divDataLst.innerText = \"\";");
            strCodeForCs.Append("\r\n" + "divDataLst.appendChild(lblMsg);");
            strCodeForCs.Append("\r\n" + "}");

            if (objViewInfoENEx.objCacheClassifyFld4View != null)
            {
                if (objViewInfoENEx.objCacheClassifyFld4View.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache);",
                           objViewInfoENEx.TabName, objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.{2}_Cache);",
                         objViewInfoENEx.TabName, objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName);
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                objViewInfoENEx.TabName, objViewInfoENEx.ClsName );
            }
            if (objViewInfoENEx.objCacheClassifyFld4View == null)
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key={{0}})\", strKey);",
                    objViewInfoENEx.TabName);
            }
            else
            {
                //strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key={0}_{{0}})\", {1}.{2}_Cache);",
                //     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key={{0}})\", strKey);",
                     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName);
            }
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

  
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(strListDiv, arr{1}ObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成BindGv_{0}!\");", objViewInfoENEx.TabName_Out);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"绑定对象列表不成功, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnQuery_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "public async btnQuery_Click() ",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnQuery_Click.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            if (objViewInfoENEx.IsUseCache4List)
            {
                strCodeForCs.AppendFormat("\r\n" + "var obj{0}_Cond = this.Combine{0}ConditionObj();", objViewInfoENEx.TabName_Out);
                if (objViewInfoENEx.objCacheClassifyFld4View != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.{3}_Cache, \"=\");",
                            objViewInfoENEx.TabName_Out,
                            objViewInfoENEx.objCacheClassifyFld4View.FldName,
                            objViewInfoENEx.ClsName,
                            objViewInfoENEx.objCacheClassifyFld4View.FldName);
                }
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = cls{0}BL.GetSimObjFromObj(obj{0}_Cond);", objViewInfoENEx.TabName_Out);
                //strCodeForCs.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = JSON.stringify(obj{0}EN_Sim);", objViewInfoENEx.TabName_Out);

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCond_Cache(obj{0}_Cond);",
                        objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {0}_GetRecCountByCond_Cache(obj{0}_Cond, {1}.{2}_Cache);",
                        objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName);
                }
                          
                strCodeForCs.Append("\r\n" + "var objPagerPara: stuPagerPara = {");
                strCodeForCs.Append("\r\n" + "pageIndex: 1,");
                strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
                strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
                strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By,", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "sortFun: (x, y) => { console.log(x,y);return 0;}");
                strCodeForCs.Append("\r\n" + "}");
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseObjLst = await {0}_GetObjLstByPager_Cache(objPagerPara).then((jsonData) => {{", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseObjLst = await  {0}_GetObjLstByPager_Cache(objPagerPara, {1}.{2}_Cache).then((jsonData) => {{", objViewInfoENEx.TabName_Out,
                        objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName);
                }

                strCodeForCs.AppendFormat("\r\n" + "var arr{0}ObjLst: Array <cls{0}EN> = <Array <cls{0}EN>>jsonData;", objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(this.divName4DataList, arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "});");

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = this.Combine{0}Condition();", objViewInfoENEx.TabName_Out);
                //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const responseRecCount = await {0}_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {{",
        objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "this.recCount = jsonData;");
                strCodeForCs.Append("\r\n" + "});");
                strCodeForCs.Append("\r\n" + "var objPagerPara: stuPagerPara = {");
                strCodeForCs.Append("\r\n" + "pageIndex: 1,");
                strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
                strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
                strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By,", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "sortFun: (x, y) => { console.log(x,y);return 0;}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "const responseObjLst = await {0}_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {{",
                    objViewInfoENEx.TabName_Out);

                strCodeForCs.AppendFormat("\r\n" + "var arr{0}ObjLst : Array<cls{0}EN> = < Array<cls{0}EN>>jsonData;",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(this.divName4DataList, arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "});");

            }
           
        
            
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"查询不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnExportExcel_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "public async btnExportExcel_Click() ",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnExportExcel_Click.name;",
objViewInfoENEx.TabName, objKeyField.FldName);

            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strCodeForCs.Append("\r\n" + "var strWhereCond =\" 1=1 \";");
            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}_GetObjLstAsync(strWhereCond);",
                objViewInfoENEx.TabName_Out);


            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}]共获取对象列表数：{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
            //    objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(this.divName4DataList, arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);
            
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"导出Excel不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_GetObjLst4DdlBind(clsViewInfoENEx objViewInfoENEx, string strTabName, string strValueFld, string strTextFld)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");

            strCodeForCs.AppendFormat("\r\n" + "public async btnGetObjLst_Click() ",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "var arr{0}ObjLst: Array<cls{0}EN> = await {0}_GetObjLstAsync(strWhereCond);",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN objFirstObj = new cls{0}EN();", objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.{0} = \"0\";",
               strValueFld, strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.{0} = \"请选择...\";", strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst.add(0, objFirstObj);",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "{1}.arr{0}ObjLst_Cache = arr{0}ObjLst;",
                strTabName, objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setPrompt(\"请选择您的{0}: \");", objPrjTabENEx.TabCnName);

            strCodeForCs.AppendFormat("\r\n" + "if (mobjDdlAdapter{0} == null)", strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "mobjDdlAdapter{0} = new ddlAdapter{0}(macPage, arr{0}ObjLst);",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            //            userStateAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setAdapter(mobjDdlAdapter{0});",
                strTabName);
            //strCodeForCs.Append("\r\n" + "SendMessage(\"没有使用缓存！\");");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"BindDdl_{0}, 没有使用缓存！\", 1);",
                strTabName);

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据条件获取相应的下拉框对象列表不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

       
        public string Gen_WApi_Ts_btnDelRecordBySign_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 按标志删除记录");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public async btnDelRecordBySign_Click() {");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要按标志删除的记录！\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");

            strCodeForCs.AppendFormat("\r\n" + "const returnInt = await {0}_DelRecordBySignAsync(arrKeyIds);", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");
         
            if (objViewInfoENEx.IsUseCache4List == true)
            {
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {                 
                    strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshCache();", objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshCache({2}.{1}_Cache);", objViewInfoENEx.TabName, 
                        objViewInfoENEx.objCacheClassifyFld4View.FldName, objViewInfoENEx.ClsName);
                }
            }
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"按标志删除记录成功,共删除${ returnInt}条记录!\");");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"按标志删除记录不成功!\");");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "await this.BindGv_{0}{1}();", objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"按标志删除记录不成功. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnUnDelRecordBySign_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 按标志恢复删除记录");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public async btnUnDelRecordBySign_Click() {");
            
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要恢复删除的记录！\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");

            strCodeForCs.AppendFormat("\r\n" + "const returnInt = await {0}_UnDelRecordBySignAsync(arrKeyIds);", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            
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

            strCodeForCs.AppendFormat("\r\n" + "const responseText2 = await this.BindGv_{0}{1}();", objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"按标志恢复记录不成功. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnDelRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 删除记录");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public async btnDelRecord_Click() {");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要删除的记录！\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (clsCommFunc4Web.confirm_del(arrKeyIds.length) == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");

            strCodeForCs.AppendFormat("\r\n" + "const responseText = await this.DelMultiRecord(arrKeyIds);", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            if (objViewInfoENEx.IsUseCache4List)
            {
                strCodeForCs.AppendFormat("\r\n" + "await this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"删除记录不成功. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnDelRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n 在数据表里删除记录");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public async btnDelRecordInTab_Click(strKeyId:string) {");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + " if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要删除的记录！\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (clsCommFunc4Web.confirm_del(0) == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");
                
                strCodeForCs.AppendFormat("\r\n" + "const responseText = await this.DelRecord(lngKeyId);", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const responseText = await this.DelRecord(strKeyId);", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());

            }

            if (objViewInfoENEx.IsUseCache4List)
            {
                strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
            }

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"删除记录不成功. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnSelectRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n 在数据表里选择记录");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public async btnSelectRecordInTab_Click(strKeyId:string) {");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + " if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要删除的记录！\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (clsCommFunc4Web.confirm_del(0) == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.SelectRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.SelectRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"选择记录不成功. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnDetailRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {            
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n 在数据表里详细信息记录");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public async btnDetailRecordInTab_Click(strKeyId:string) {");
            //strCodeForCs.Append("\r\n" + "//$('#hidOpType').val(\"Detail\");");
            strCodeForCs.Append("\r\n" + "this.OpType = \"Detail\";");

            clsPropertyDef4GC objPropertyDef4GC = new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "input",
                CtrlId = "hidOpType",
                PropertyName = "OpType",
                Comment = "设置操作类型：Add||Update||Detail",
                DataType = "string"
            };
            arrPropertyDef4GC.Add(objPropertyDef4GC);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + " if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要详细信息的记录！\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"详细信息记录不成功. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        
        public string Gen_WApi_Ts_btnDetailRecord_Clic1kBak20210330(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            //clsDetailRegionEN objDetailRegion = null;
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            var objFeatureRegionFlds_Detail = objViewInfoENEx.arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.DetailRecord_0239);

             StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public async btnDetailRecord_Click(strKeyId:string) {");
            //strCodeForCs.Append("\r\n" + "$('#hidOpType').val(\"Update\");");
            strCodeForCs.Append("\r\n" + "this.OpType_d = \"Detail\";");
            
            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "input",
                CtrlId = "hidOpType_d",
                PropertyName = "OpType_d",
                Comment = "设置操作类型：Add||Update||Detail",
                DataType = "string"
            });
            if (objFeatureRegionFlds_Detail == null 
                || string.IsNullOrEmpty(objFeatureRegionFlds_Detail.KeyIdGetModeId)
                || objFeatureRegionFlds_Detail.KeyIdGetModeId == enumGCKeyIdGetMode.ListCheckedRecord_0001)
            {

                strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(strKeyId) == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"需要显示详细信息记录的关键字为空，请检查！\";");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");

                strCodeForCs.Append("\r\n" + "}");
            }
            else if (objFeatureRegionFlds_Detail.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
            {
                strCodeForCs.AppendFormat("\r\n" + "var strKeyId = {0}.{1}_Static;", this.ClsName, objKeyField.FldName);
                if (objKeyField.IsNumberType() == true)
                {
                    strCodeForCs.Append("\r\n" + "    if (strKeyId == 0)");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"在显示详细信息时，界面静态关键字为空！(In btnDetailRecord_Click)\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.AppendFormat("\r\n" + "if (this.bolIsLoadDetailRegion == false)  //", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseBool = await this.AddDPV_Detail(this.divName4Detail);", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n // 为编辑区绑定下拉框");
            strCodeForCs.AppendFormat("\r\n" + "//const conBindDdl = await this.BindDdl4DetailRegion();", objViewInfoENEx.ClsName);

            if (objViewRegion.PageDispModeId == enumPageDispMode.PopupBox_01)
            {
                strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Detail');", objViewInfoENEx.TabName_In);
            }
            strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadDetailRegion = true;  //", objViewInfoENEx.ClsName);
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            if (objViewRegion.PageDispModeId == enumPageDispMode.PopupBox_01)
            {
                strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Detail');", objViewInfoENEx.TabName_In);
            }
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnUpdateRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 在数据表里修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public async btnUpdateRecordInTab_Click(strKeyId:string) {");
            //strCodeForCs.Append("\r\n" + "$('#hidOpType').val(\"Update\");");
            strCodeForCs.Append("\r\n" + "this.OpType = \"Update\";");

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "input",
                CtrlId = "hidOpType",
                PropertyName = "OpType",
                Comment = "设置操作类型：Add||Update||Detail",
                DataType = "string"
            });

            strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要修改的记录！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            
            strCodeForCs.AppendFormat("\r\n" + "if (this.bolIsLoadEditRegion == false)  //", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseBool = await this.AddDPV_Edit(this.divName4Edit);", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n // 为编辑区绑定下拉框");
            strCodeForCs.AppendFormat("\r\n" + "const conBindDdl = await this.BindDdl4EditRegion();", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Update');", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadEditRegion = true;  //", objViewInfoENEx.ClsName);
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Update');", objViewInfoENEx.TabName_In);
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_DelMultiRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据关键字列表删除记录");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "public async DelMultiRecord(arr{0}: Array<string>) {{",
                objKeyField.FldName);

            //   GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

            //strCodeForCs.AppendFormat("\r\n" + "var arr{0}:Array<string> = arrKeys;", objKeyField.FldName);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const returnInt = await {0}_Del{0}sAsync(arr{1});",
                objViewInfoENEx.TabName,
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");
            Gene_ReFreshCache(strCodeForCs);

            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"删除记录成功,共删除{0}条记录!\", returnInt);");
            //            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"删除记录不成功!\");");
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成DelMultiRecord!\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"删除记录不成功. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_DelRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n 根据关键字删除记录");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "public async DelRecord({0}: {1}) {{",
                objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);

            //   GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

            //strCodeForCs.AppendFormat("\r\n" + "var arr{0}:Array<string> = arrKeys;", objKeyField.FldName);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const returnInt = await {0}_DelRecordAsync({1});",
                objViewInfoENEx.TabName,
                objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");
            Gene_ReFreshCache(strCodeForCs);

            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"删除记录成功,共删除{0}条记录!\", returnInt);");
            //            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"删除记录不成功!\");");
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成DelRecord!\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"删除记录不成功. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnAddNewRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 添加新记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public async btnAddNewRecord_Click() {");
    //        strCodeForCs.Append("\r\n" + "//$('#hidOpType').val(\"Add\");");
            strCodeForCs.Append("\r\n" + "this.OpType = \"Add\";");

    
            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "input",
                CtrlId = "hidOpType",
                PropertyName = "OpType",
                Comment = "设置操作类型：Add||Update||Detail",
                DataType = "string"
            });

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "if (this.bolIsLoadEditRegion == false)  //", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseBool = await this.AddDPV_Edit(this.divName4Edit);", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n // 为编辑区绑定下拉框");
            strCodeForCs.AppendFormat("\r\n" + "const conBindDdl = await this.BindDdl4EditRegion();", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Add');", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadEditRegion = true;  //", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_{0} = \"确认添加\";", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_{0} = \"取消添加\";", objViewInfoENEx.TabName_In);

            strCodeForCs.AppendFormat("\r\n" + "const responseText = this.AddNewRecord();",
                    objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Add');", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_{0} = \"确认添加\";", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_{0} = \"取消添加\";", objViewInfoENEx.TabName_In);

            strCodeForCs.AppendFormat("\r\n" + "const responseText = await this.AddNewRecord();",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"添加新记录初始化不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 添加新记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public async btnAddNewRecordWithMaxId_Click() {");
            //        strCodeForCs.Append("\r\n" + "//$('#hidOpType').val(\"Add\");");
            strCodeForCs.Append("\r\n" + "this.OpType = \"AddWithMaxId\";");


            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "input",
                CtrlId = "hidOpType",
                PropertyName = "OpType",
                Comment = "设置操作类型：Add||Update||Detail",
                DataType = "string"
            });

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "if (this.bolIsLoadEditRegion == false)  //", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseBool = await this.AddDPV_Edit(this.divName4Edit);", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n // 为编辑区绑定下拉框");
            strCodeForCs.AppendFormat("\r\n" + "const conBindDdl = await this.BindDdl4EditRegion();", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Add');", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadEditRegion = true;  //", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_{0} = \"确认添加\";", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_{0} = \"取消添加\";", objViewInfoENEx.TabName_In);

            strCodeForCs.AppendFormat("\r\n" + "const responseText = this.AddNewRecordWithMaxId();",
                    objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Add');", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_{0} = \"确认添加\";", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_{0} = \"取消添加\";", objViewInfoENEx.TabName_In);

            strCodeForCs.AppendFormat("\r\n" + "const responseText = this.AddNewRecordWithMaxId();",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"添加新记录初始化不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_GetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 获取当前表关键字值的最大值,再加1,避免重复");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");


            strCodeForCs.Append("\r\n" + "public async GetMaxStrId(strKeyCtrlName) {");

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
            strCodeForCs.AppendFormat("\r\n" + "const returnString = await {0}_GetMaxStrIdAsync();",
                objViewInfoENEx.TabName);
            
            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为空，不成功，请检查!\");",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + " $(strKeyCtrlName).val(returnString);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为：{{0}}!\", returnString);",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
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



            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_ScriptCSGetMaxStrIdByPrefix(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");

            strCodeForCs.Append("\r\n" + "public async btnGetMaxStrIdByPrefix_Click() {");
            //            strCodeForCs.AppendFormat("\r\n" + "string strPrefix = \"2\";");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const returnString = await {0}_GetMaxStrIdByPrefixAsync(strPrefix);",
                objViewInfoENEx.TabName);
                        
            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为空，不成功，请检查!\");",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为：{{0}}!\", returnString);",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"获取表关键字的最大值不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }
              
        Func<clsvViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        public string Gen_WApi_Ts_DdlBindFunction4Page_Load()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            //string strDS_DataValueField = "";
            //string strDs_TabName = "";
            try
            {

                foreach (ASPDropDownListEx objInfor in objViewInfoENEx.arrASPDropDownListObj)
                {
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Ctrl.BindDdl_TrueAndFalse(\"{0}\");",
                                 objInfor.CtrlId);
                    }
                    else
                    {
                        if (objInfor.objFieldTab_ConditionField == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {1} = {2}_BindDdl_{0}_Cache(\"{1}\", obj{2}_Cond);//{3}",
                                 objInfor.FldName,
                         objInfor.CtrlId, objInfor.Ds_TabName
                         , clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                        }
                        else
                        {
                            
                            strCodeForCs.AppendFormat("\r\n" + "var {0}{2}: {1} = \"\";",
                                     objInfor.objFieldTab_ConditionField.PrivFuncName(),
                                     objInfor.objFieldTab_ConditionField.ObjDataTypeAbbr().TypeScriptType,
                                     objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            strCodeForCs.AppendFormat("\r\n" + "const {1} = {2}_BindDdl_{0}_Cache(\"{1}\", obj{2}_Cond, {4}{5});//{3}",
                                 objInfor.FldName,
                         objInfor.CtrlId, objInfor.Ds_TabName
                         , clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                         objInfor.objFieldTab_ConditionField.PrivFuncName(), objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                        }
                    }
                }

                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                //    || objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //{
                //    strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
                //    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                //    {
                //        if (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName.Contains("DropDownList") == true)
                //        {
                //            strDS_DataValueField = clsEditRegionFldsBLEx.InitDs_DataValueField(objEditRegionFldsEx);
                //            strDs_TabName = clsEditRegionFldsBLEx.InitDs_TabName4Get(objEditRegionFldsEx);

                //            strCodeForCs.AppendFormat("\r\n" + "const ddl_{1} = {3}_BindDdl_{0}_Cache(\"{2}\", obj{3}_Cond);",
                //            strDS_DataValueField, objEditRegionFldsEx.FldName,
                //            objEditRegionFldsEx.CtrlId, strDs_TabName);
                //        }
                //    }
                //}


                //foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                //{
                //    if (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName.Contains("DropDownList") == true)
                //    {
                //        if (objQryRegionFldsEx.ObjFieldTabENEx.CsType == "bool")
                //        {
                //            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Ctrl.BindDdl_TrueAndFalse(\"{0}\");",
                //                        objQryRegionFldsEx.CtrlId);
                //        }
                //        else
                //        {
                //            clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objQryRegionFldsEx.Ds_TabId);
                //            clsFieldTabEN objFieldTab_ValueField = clsFieldTabBLEx.GetObjByFldID_Cache(objQryRegionFldsEx.Ds_DataValueFieldId, objViewInfoENEx.PrjId);
                //            clsFieldTabEN objFieldTabEN_TextField = clsFieldTabBLEx.GetObjByFldID_Cache(objQryRegionFldsEx.Ds_DataTextFieldId, objViewInfoENEx.PrjId);

                //            if (objPrjTabEN_CodeTab == null)
                //            {
                //                string strMsg = string.Format("在界面查询区，{0}下拉框的数据源表没有设置，请检查！({1})",
                //                    objQryRegionFldsEx.FldName,
                //                    clsStackTrace.GetCurrClassFunction());
                //                throw new Exception(strMsg);
                //            }
                //            if (objFieldTab_ValueField == null)
                //            {
                //                string strMsg = string.Format("在界面查询区，{0}下拉框的数据源值字段没有设置，请检查！({1})",
                //                    objQryRegionFldsEx.FldName,
                //                    clsStackTrace.GetCurrClassFunction());
                //                throw new Exception(strMsg);
                //            }
                //            if (objFieldTabEN_TextField == null)
                //            {
                //                string strMsg = string.Format("在界面查询区，{0}下拉框的数据源文本字段没有设置，请检查！({1})",
                //                    objQryRegionFldsEx.FldName,
                //                    clsStackTrace.GetCurrClassFunction());
                //                throw new Exception(strMsg);
                //            }
                //            strDS_DataValueField = clsQryRegionFldsBLEx.Ds_DataValueField4Get(objQryRegionFldsEx);
                //            strDs_TabName = clsQryRegionFldsBLEx.InitDs_TabName4Get(objQryRegionFldsEx);

                //            strCodeForCs.AppendFormat("\r\n" + "const ddl_{1}_q = {3}_BindDdl_{0}_Cache(\"{2}\", obj{3}_Cond);",
                //                    objFieldTab_ValueField.FldName,
                //                    objQryRegionFldsEx.FldName,
                //                    objQryRegionFldsEx.CtrlId,
                //                    strDs_TabName);
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
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_DdlBindFunction4Page_Load_Cache()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            //string strDS_DataValueField = "";
            //string strDs_TabName = "";
            try
            {

                foreach (ASPDropDownListEx objInfor in objViewInfoENEx.arrASPDropDownListObj)
                {
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Ctrl.BindDdl_TrueAndFalse(\"{0}\");",
                                 objInfor.CtrlId);
                    }
                    else
                    {
                        if (objInfor.objFieldTab_ConditionField == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = {3}_BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond);//{4}",
                                 objInfor.FldName,
                                         objInfor.objFieldTab_ValueField.FldName,
                         objInfor.CtrlId, objInfor.Ds_TabName
                         , clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                        }
                        else
                        {

                            strCodeForCs.AppendFormat("\r\n" + "var {0}{2}: {1} = \"\";",
                                     objInfor.objFieldTab_ConditionField.PrivFuncName(),
                                     objInfor.objFieldTab_ConditionField.ObjDataTypeAbbr().TypeScriptType,
                                     objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = {3}_BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond, {5}{6});//{4}",
                                 objInfor.FldName,
                                 objInfor.objFieldTab_ValueField.FldName,
                         objInfor.CtrlId, objInfor.Ds_TabName
                         , clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                         objInfor.objFieldTab_ConditionField.PrivFuncName(),
                         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                        }
                    }
                }
                //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                //    || objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                //{
                //    strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
                //    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                //    {
                //        if (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName.Contains("DropDownList") == true)
                //        {
                //            strDS_DataValueField = clsEditRegionFldsBLEx.InitDs_DataValueField(objEditRegionFldsEx);
                //            strDs_TabName = clsEditRegionFldsBLEx.InitDs_TabName4Get(objEditRegionFldsEx);

                //            strCodeForCs.AppendFormat("\r\n" + "const ddl_{1} = {3}_BindDdl_{0}_Cache(\"{2}\", obj{3}_Cond);",
                //            strDS_DataValueField, objEditRegionFldsEx.FldName,
                //            objEditRegionFldsEx.CtrlId, strDs_TabName);
                //        }
                //    }
                //}


                //foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                //{
                //    if (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName.Contains("DropDownList") == true)
                //    {
                //        if (objQryRegionFldsEx.ObjFieldTabENEx.CsType == "bool")
                //        {
                //            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Ctrl.BindDdl_TrueAndFalse(\"{0}\");",
                //                        objQryRegionFldsEx.CtrlId);
                //        }
                //        else
                //        {
                //            clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objQryRegionFldsEx.Ds_TabId);
                //            clsFieldTabEN objFieldTab_ValueField = clsFieldTabBLEx.GetObjByFldID_Cache(objQryRegionFldsEx.Ds_DataValueFieldId, objViewInfoENEx.PrjId);
                //            clsFieldTabEN objFieldTabEN_TextField = clsFieldTabBLEx.GetObjByFldID_Cache(objQryRegionFldsEx.Ds_DataTextFieldId, objViewInfoENEx.PrjId);

                //            if (objPrjTabEN_CodeTab == null)
                //            {
                //                string strMsg = string.Format("在界面查询区，{0}下拉框的数据源表没有设置，请检查！({1})",
                //                    objQryRegionFldsEx.FldName,
                //                    clsStackTrace.GetCurrClassFunction());
                //                throw new Exception(strMsg);
                //            }
                //            if (objFieldTab_ValueField == null)
                //            {
                //                string strMsg = string.Format("在界面查询区，{0}下拉框的数据源值字段没有设置，请检查！({1})",
                //                    objQryRegionFldsEx.FldName,
                //                    clsStackTrace.GetCurrClassFunction());
                //                throw new Exception(strMsg);
                //            }
                //            if (objFieldTabEN_TextField == null)
                //            {
                //                string strMsg = string.Format("在界面查询区，{0}下拉框的数据源文本字段没有设置，请检查！({1})",
                //                    objQryRegionFldsEx.FldName,
                //                    clsStackTrace.GetCurrClassFunction());
                //                throw new Exception(strMsg);
                //            }
                //            strDS_DataValueField = clsQryRegionFldsBLEx.Ds_DataValueField4Get(objQryRegionFldsEx);
                //            strDs_TabName = clsQryRegionFldsBLEx.InitDs_TabName4Get(objQryRegionFldsEx);

                //            strCodeForCs.AppendFormat("\r\n" + "const ddl_{1}_q = {3}_BindDdl_{0}_Cache(\"{2}\", obj{3}_Cond);",
                //                    objFieldTab_ValueField.FldName,
                //                    objQryRegionFldsEx.FldName,
                //                    objQryRegionFldsEx.CtrlId,
                //                    strDs_TabName);
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
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_CombineCondition(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成仅有变量;


                strCodeForCs.Append("\r\n /* 把所有的查询控件内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.Append("\r\n  <returns>条件串(strWhereCond)</returns>");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + " public Combine{0}Condition():string ", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\" And \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");
                strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");


                var arrQryRegionFlds = objViewInfoENEx.arrQryRegionFldSet.Where(x => x.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38);
                if (arrQryRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrQryRegionFlds)
                    {
                        string strVarName = "";
                        var objVar = clsGCVariableBL.GetObjByVarId_Cache(objInFor.VarId, objViewInfoENEx.PrjId);
                        if (objVar != null)
                        {
                            strVarName = objVar.VarExpression;
                        }
                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\"{1} ={{0}}\", {2}.{3});",
                            objViewInfoENEx.TabName_Out,
                            objInFor.ObjFieldTab().FldName,
                            objViewInfoENEx.ClsName,
                            strVarName);
                    }
                }

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
                if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                {
                    foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    arrPropertyDef4GC.Add(new clsPropertyDef4GC
                    {
                        OperateType = "get",
                        ControlType = objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName,
                        CtrlId = objQryRegionFldsEx.CtrlId,
                        PropertyName = objQryRegionFldsEx.PropertyName,                        
                        Comment = string.Format("{0} (Used In {1})", objQryRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "CombineCondition()"),

                        DataType = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType
                    });
                    switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName) //objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName
                    {

                        case "CheckBox":
                            //strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                            //            objQryRegionFldsEx.CtrlId);
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0} == true)",
                         objQryRegionFldsEx.PropertyName);
                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", cls{1}EN.con_{0});",
                                     objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                     "{", "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", cls{1}EN.con_{0});",
                                 objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                    "{", "}");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DropDownList": ///如果控件是下拉框;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType == "bool")
                            {

                    //            strCodeForCs.AppendFormat("\r\n" + "var bol{0} = $(\"#{1}\").val();",
                    //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId);

                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").prop(\"SelectedIndex\") == 1)",
                                objQryRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", cls{1}EN.con_{0}); ",
                                      objQryRegionFldsEx.FldName,
                                       objViewInfoENEx.TabName_Out,
                                      "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if ($(\"#{0}\").prop(\"selectedIndex\") == 2)",
                                objQryRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", cls{1}EN.con_{0});",
                                       objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                      "{", "}");
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                                //     strCodeForCs.AppendFormat("\r\n" + "var str{0} = $(\"#{1}\").val();",
                                //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId);
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
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType)
                                {
                                    case "string":


                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        objViewInfoENEx.TabName_Out);
                                        break;
                                    case "int":


                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", cls{2}EN.con_{0}, this.{1});",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        objViewInfoENEx.TabName_Out);
                                        break;
                                    default:


                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        objViewInfoENEx.TabName_Out);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;

                        case "TextBox": ///如果控件类型是文本框;
                            //strCodeForCs.AppendFormat("\r\n" + "var str{0} = $(\"#{1}\").val();",
                            //    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId);

                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType != "string"
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
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.PropertyName,
                                objViewInfoENEx.TabName_Out);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", cls{2}EN.con_{0}, this.{1});",
                             objQryRegionFldsEx.FldName,
                             objQryRegionFldsEx.PropertyName,
                             objViewInfoENEx.TabName_Out);
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} like '% {{1}}%'\", cls{2}EN.con_{0}, this.{1});",
                                   objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.PropertyName,
                                     objViewInfoENEx.TabName_Out);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                            { ///范围查询;
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.PropertyName,
                                objViewInfoENEx.TabName_Out);
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1}), , );",
                                     objQryRegionFldsEx.FldName,
                                      objQryRegionFldsEx.PropertyName,
                                      objViewInfoENEx.TabName_Out);
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

                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameCondition(in old)", "在组合查询条件(CombineTabNameCondition(in Old))时出错!请联系管理员!", "生成代码");
                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "const strMsg:string = Format(\"(errid:{1})在组合查询条件(Combine{0}Condition)时出错!请联系管理员!{{0}}\", objException);",
                   objViewInfoENEx.TabName, strErrId);
                strCodeForCs.Append("\r\n" + "throw strMsg;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strWhereCond;");
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

        public string Gen_WApi_Ts_CombineConditionObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成仅有变量;


                strCodeForCs.Append("\r\n /* 把所有的查询控件内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.Append("\r\n  <returns>条件串(strWhereCond)</returns>");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + " public Combine{0}ConditionObj():cls{0}EN ", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\" And \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");
                strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}_Cond = new cls{0}EN();", objViewInfoENEx.TabName_Out);

                var arrQryRegionFlds = objViewInfoENEx.arrQryRegionFldSet.Where(x => x.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38);
                if (arrQryRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrQryRegionFlds)
                    {
                        string strVarName = "";
                        var objVar = clsGCVariableBL.GetObjByVarId_Cache(objInFor.VarId, objViewInfoENEx.PrjId);
                        if (objVar != null)
                        {
                            strVarName = objVar.VarExpression;
                        }
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.{3}, \"=\");", 
                            objViewInfoENEx.TabName_Out,
                            objInFor.ObjFieldTab().FldName,
                            objViewInfoENEx.ClsName,
                            strVarName);
                    }
                }

                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
                if (objViewRegion != null && objViewRegion.InUseInViewInfo(objViewInfoENEx) == true && objViewRegion.IsDispInViewInfo(objViewInfoENEx))
                {
                    foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                    {
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName,
                            CtrlId = objQryRegionFldsEx.CtrlId,
                            PropertyName = objQryRegionFldsEx.PropertyName,
                            Comment = string.Format("{0} (Used In {1})", objQryRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "CombineConditionObj()"),
                            DataType = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType
                        });
                        switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName) //objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName
                        {

                            case "CheckBox":
                                //strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                                //            objQryRegionFldsEx.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0} == true)",
                             objQryRegionFldsEx.PropertyName);
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", cls{1}EN.con_{0});",
                                         objQryRegionFldsEx.FldName,
                                         objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, true, \"=\");",
                                    objViewInfoENEx.TabName_Out,
                                    objQryRegionFldsEx.FldName);


                                strCodeForCs.Append("\r\n" + "}");

                                strCodeForCs.AppendFormat("\r\n" + "else");
                                strCodeForCs.Append("\r\n" + "{");

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", cls{1}EN.con_{0});",
                                     objQryRegionFldsEx.FldName,
                                         objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, false, \"=\");",
                                objViewInfoENEx.TabName_Out,
                                objQryRegionFldsEx.FldName);

                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "DropDownList": ///如果控件是下拉框;
                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType == "bool")
                                {

                                    //            strCodeForCs.AppendFormat("\r\n" + "var bol{0} = $(\"#{1}\").val();",
                                    //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId);

                                    strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").prop(\"selectedIndex\") == 1)",
                                    objQryRegionFldsEx.CtrlId);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '1'\", cls{1}EN.con_{0}); ",
                                          objQryRegionFldsEx.FldName,
                                           objViewInfoENEx.TabName_Out,
                                          "{", "}");
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, true, \"=\");",
                                        objViewInfoENEx.TabName_Out,
                                        objQryRegionFldsEx.FldName);

                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.AppendFormat("\r\n" + "else if ($(\"#{0}\").prop(\"selectedIndex\") == 2)",
                                    objQryRegionFldsEx.CtrlId);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);

                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '0'\", cls{1}EN.con_{0});",
                                           objQryRegionFldsEx.FldName,
                                         objViewInfoENEx.TabName_Out,
                                          "{", "}");
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, false, \"=\");",
                                        objViewInfoENEx.TabName_Out,
                                        objQryRegionFldsEx.FldName);

                                    strCodeForCs.Append("\r\n" + "}");

                                }
                                else
                                {
                                    //     strCodeForCs.AppendFormat("\r\n" + "var str{0} = $(\"#{1}\").val();",
                                    //objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId);
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
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                    switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType)
                                    {
                                        case "string":


                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                            objQryRegionFldsEx.FldName,
                                            objQryRegionFldsEx.PropertyName,
                                            objViewInfoENEx.TabName_Out);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                        objViewInfoENEx.TabName_Out,
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName);


                                            break;
                                        case "int":


                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", cls{2}EN.con_{0}, this.{1});",
                                            objQryRegionFldsEx.FldName,
                                            objQryRegionFldsEx.PropertyName,
                                            objViewInfoENEx.TabName_Out);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                    objViewInfoENEx.TabName_Out,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName);
                                            break;
                                        default:


                                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                            objQryRegionFldsEx.FldName,
                                            objQryRegionFldsEx.PropertyName,
                                            objViewInfoENEx.TabName_Out);
                                            strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                    objViewInfoENEx.TabName_Out,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName);
                                            break;
                                    }
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                break;

                            case "TextBox": ///如果控件类型是文本框;
                                //strCodeForCs.AppendFormat("\r\n" + "var str{0} = $(\"#{1}\").val();",
                                //    objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId);

                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType != "string"
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
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName,
                                    objViewInfoENEx.TabName_Out);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                    objViewInfoENEx.TabName_Out,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = {{1}}\", cls{2}EN.con_{0}, this.{1});",
                                 objQryRegionFldsEx.FldName,
                                 objQryRegionFldsEx.PropertyName,
                                 objViewInfoENEx.TabName_Out);
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                    objViewInfoENEx.TabName_Out,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName);
                                    }
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} like '% {{1}}%'\", cls{2}EN.con_{0}, this.{1});",
                                       objQryRegionFldsEx.FldName,
                                         objQryRegionFldsEx.PropertyName,
                                         objViewInfoENEx.TabName_Out);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"like\");",
                                    objViewInfoENEx.TabName_Out,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName);

                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                                { ///范围查询;
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1});",
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName,
                                    objViewInfoENEx.TabName_Out);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                objViewInfoENEx.TabName_Out,
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1}), , );",
                                         objQryRegionFldsEx.FldName,
                                          objQryRegionFldsEx.PropertyName,
                                          objViewInfoENEx.TabName_Out);
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1}, this.{2}, \"=\");",
                                objViewInfoENEx.TabName_Out,
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.PropertyName);
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
                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameConditionObj", "在组合查询条件对象(CombineTabNameConditionObj)时出错!请联系管理员!", "生成代码");
                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "const strMsg:string = Format(\"(errid:{1})在组合查询条件对象(Combine{0}ConditionObj)时出错!请联系管理员!{{0}}\", objException);",
                   objViewInfoENEx.TabName, strErrId);
                strCodeForCs.Append("\r\n" + "throw strMsg;");
                strCodeForCs.Append("\r\n" + "}");
                
                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.whereCond = strWhereCond;", objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "return obj{0}_Cond;", objViewInfoENEx.TabName_Out);
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


        private void GC_GetInputValue4Para_TS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, StringBuilder strCodeForCs)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC_Cache(objvFunction4GeneCodeEN.FuncId4GC);

            string strMsg = "";
            //            StringBuilder strCodeForCs = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
            clsFuncPara4CodeBLEx.GetObjListByFuncId4Code_CacheEx(objFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeId_Cache(objFuncPara4CodeEN.DataTypeId);
                    clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                    if (objDataTypeAbbrEN == null)
                    {
                        objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                        if (objSelfDefDataTypeEN_Para == null)
                        {
                            strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理，不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                                objFuncPara4CodeEN.ParameterType);
                            throw new Exception(strMsg);
                        }
                    }
                    if (objFuncPara4CodeEN.IsByRef == true)
                    {
                        strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}]，数据类型：[{1}]没有处理，不能生成相应代码。",
                           objFuncPara4CodeEN.ParaName,
                             objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        if (objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "var {1}: {0} = $('#txt{1}{2}').val();",
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
                                    strCodeForCs.AppendFormat("\r\n" + "var {1}:{0} = Number($('#txt{1}{2}').val());",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.Array_31:
                                    strCodeForCs.AppendFormat("\r\n" + "var {1}:{0} = $('#txt{1}{2}').val();",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                default:
                                    strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理！({3})",
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

                strCodeForCs.Append("\r\n /* 函数功能:把界面上的属性数据传到类对象中");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"pobj{0}EN\">数据传输的目的类对象</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public PutDataTo{0}Class(pobj{2}EN: cls{1}EN)",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    if (objEditRegionFldsEx.InUse == false && objEditRegionFldsEx.FieldTypeId() != enumFieldType.Log_UpdUser_14) continue;

                    string strTemp = GetCode4FieldInPutDataToClass(objEditRegionFldsEx, objViewInfoENEx);
                    strCodeForCs.AppendFormat("{0}", strTemp);
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
            return strCodeForCs.ToString();
        }
        private string GetCode4FieldInPutDataToClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.CtlTypeId != enumCtlTypeAbbr.ViewVariable_38)
            {
                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "get",
                    ControlType = objEditRegionFldsEx.CtlTypeName,
                    CtrlId = objEditRegionFldsEx.CtrlId,
                    PropertyName = objEditRegionFldsEx.PropertyName(),               
                    Comment = string.Format("{0} (Used In {1})", objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "PutDataToClass()"),
                    DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType
                });
            }
            if (objEditRegionFldsEx.FieldTypeId() == enumFieldType.Log_UpdUser_14)
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = clsPubSessionStorage.userId;",
                    objViewInfoENEx.TabName,
                    objEditRegionFldsEx.FldName);
            }
            else
            {
                switch (objEditRegionFldsEx.CtlTypeId)
                {
                    case enumCtlTypeAbbr.CheckBox_02:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.FldName,
         objEditRegionFldsEx.CtrlId);
                        break;
                    case enumCtlTypeAbbr.TextBox_16:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.FldName,
         objEditRegionFldsEx.CtrlId);
                        break;
                    case enumCtlTypeAbbr.DropDownList_06:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.FldName,
         objEditRegionFldsEx.CtrlId);
                        break;
                    case enumCtlTypeAbbr.CacheClassifyField_37:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = {2};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.FldName,
         strVarDef4ViewCacheFld);
                        break;
                    case enumCtlTypeAbbr.ViewVariable_38:
                        string strVarName = "";
                        var objVar = clsGCVariableBL.GetObjByVarId_Cache(objEditRegionFldsEx.VarId, objViewInfoENEx.PrjId);
                        if (objVar != null)
                        {
                            strVarName = objVar.VarExpression;
                        }
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = {2}.{3};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.FldName,
         objViewInfoENEx.ClsName, strVarName);
                        break;
                    case enumCtlTypeAbbr.GivenValue_35:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = {2};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.FldName,
         strVarDef4ViewCacheFld);
                        break;

                    default:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
                objViewInfoENEx.TabName,
                objEditRegionFldsEx.FldName,
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

                strCodeForCs.Append("\r\n /* 函数功能:把类对象的属性内容显示到界面上");
                strCodeForCs.Append("\r\n 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值");
                strCodeForCs.Append("\r\n  如果在设置数据库时,就应该一级字段在前,二级字段在后");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"pobj{0}EN\">表实体类对象</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public GetDataFrom{0}Class(pobj{2}EN: cls{1}EN )",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetDataFrom{0}Class.name;",
objPrjTabENEx.TabName, objKeyField.FldName);

                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");


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
                PropertyName = objDetailRegionFldsEx.PropertyName() + "_d",        
                Comment = string.Format("{0} (Used In {1})", objDetailRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "ShowDetailDataFromClass()"),
                DataType = objDetailRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType
            });
            switch (objDetailRegionFldsEx.CtlTypeId)
            {
                case enumCtlTypeAbbr.CheckBox_02:
                    //7、设置checkbox为选中状态
                    //$('input:checkbox').attr("checked", 'checked');//or
                    //$('input:checkbox').attr("checked", true);
                    //8、设置checkbox为不选中状态
                    //$('input:checkbox').attr("checked", '');//or
                    //$('input:checkbox').attr("checked", false);
                    sbCodeForCs.AppendFormat("\r\n" + "this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName_Out,
                                objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.GivenValue_35:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName_Out,
                                objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.DropDownList_06:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName_Out,
                                objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.CacheClassifyField_37:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2}_d = pobj{1}EN.{2};",
                         objDetailRegionFldsEx.CtrlId,
                         objViewInfoENEx.TabName_Out,
                         objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName_Out,
                                objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
            }

            return sbCodeForCs.ToString();
        }


        private string GetCode4FieldInGetDataFromClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();


            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.CtlTypeId != enumCtlTypeAbbr.ViewVariable_38)
            {
                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = objEditRegionFldsEx.CtlTypeName,
                    CtrlId = objEditRegionFldsEx.CtrlId,
                    PropertyName = objEditRegionFldsEx.PropertyName(),              
                    Comment = string.Format("{0} (Used In {1})", objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "GetDataFromClass()"),
                    DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType
                });
            }
            switch (objEditRegionFldsEx.CtlTypeId)
            {
                case enumCtlTypeAbbr.CheckBox_02:
                    //7、设置checkbox为选中状态
                    //$('input:checkbox').attr("checked", 'checked');//or
                    //$('input:checkbox').attr("checked", true);
                    //8、设置checkbox为不选中状态
                    //$('input:checkbox').attr("checked", '');//or
                    //$('input:checkbox').attr("checked", false);
                    sbCodeForCs.AppendFormat("\r\n" + "this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objEditRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.GivenValue_35:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objEditRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.DropDownList_06:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objEditRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.CacheClassifyField_37:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2} = pobj{1}EN.{2};",
                         objEditRegionFldsEx.CtrlId,
                         objViewInfoENEx.TabName,
                         objEditRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objEditRegionFldsEx.FldName);
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

                strCodeForCs.Append("\r\n /* 函数功能:从界面列表中获取第一个关键字的值");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"pobj{0}EN\">表实体类对象</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n <returns>列表的第一个关键字值</returns>");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "public GetFirstKey(): string {");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetFirstKey.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");


                strCodeForCs.Append("\r\n" + "if (arrSelectedKeys.length == 1) {");
                strCodeForCs.Append("\r\n" + "return arrSelectedKeys[0];");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "else {");

                strCodeForCs.Append("\r\n" + "alert(`请选择一个关键字！目前选择了:${ arrSelectedKeys.length}个关键字。`);");
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
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_SortBy()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /* 函数功能:从界面列表中根据某一个字段排序");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"objAnchorElement\">带有排序字段的Anchors</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "*/");

                strCodeForCs.Append("\r\n" + "public async SortBy(objAnchorElement:any) {");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SortBy.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);

                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                strCodeForCs.Append("\r\n" + " console.log(\"objAnchorElement(In SetAllCkechedKeysV2):\", objAnchorElement);");
                strCodeForCs.Append("\r\n" + "//event = window.event || event;");
                strCodeForCs.Append("\r\n" + "var thisEventObj: HTMLInputElement = objAnchorElement;");

                strCodeForCs.Append("\r\n" + "var strFldName: string = thisEventObj.getAttribute(\"FldName\") as string;");
                strCodeForCs.Append("\r\n" + "  if (IsNullOrEmpty(strFldName) == true) return;");

                strCodeForCs.Append("\r\n" + "var strSortByFld: string = strFldName;");

                strCodeForCs.AppendFormat("\r\n" + "if ({1}.sort{0}By.indexOf(strSortByFld) >= 0)", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if ({1}.sort{0}By.indexOf(\"Asc\") >= 0)", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{1}.sort{0}By = Format(\"{{0}} Desc\", strSortByFld);", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{1}.sort{0}By = Format(\"{{0}} Asc\", strSortByFld);", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{1}.sort{0}By = Format(\"{{0}} Asc\", strSortByFld);", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
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

        public string Gen_WApi_Ts_IndexPage()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /* 函数功能:在数据 列表中跳转到某一页");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"intPageIndex\">页序号</param>",
                        objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "public IndexPage(intPageIndex:number)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (intPageIndex == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "intPageIndex = this.objPager.pageCount;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "console.log(\"跳转到\" + intPageIndex + \"页\");");
                      
                //strCodeForCs.Append("\r\n" + "this1.CurrPageIndex = intPageIndex;");
                strCodeForCs.Append("\r\n" + "this.SetCurrPageIndex(intPageIndex);");
                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "input",
                    CtrlId = "hidCurrPageIndex",
                    PropertyName = "CurrPageIndex",
                    Comment = "设置当前页序号",
                    DataType = "number"

                });
                strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{1}{2}();",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");
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
        public string GenFunctionRegion(clsViewRegionEN objDGRegionENEx, clsViewInfoENEx objViewInfoENEx)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //int iDGHeight;      //DataGrid的高度
            //int iDG_Div_Left;
            if (objViewInfoENEx.arrDGRegionFldSet == null || objViewInfoENEx.arrDGRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有DataGrid区域,或者DataGrid区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }

            //			string strTemp ;     ///临时变量;
            ///判断DataGrid是否需要排序
            //foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            //{
            //    if (objDGRegionFldsEx.IsNeedSort)
            //    {
            //        objViewInfoENEx.objViewRegion_List.AllowSorting() = true;
            //    }
            //}
            try
            {
                ///生成插入记录的界面代码;
                //objViewInfoENEx.objViewRegion_List.Style_Zindex() = intZIndex + 1;
                //objViewInfoENEx.objViewRegion_List.Style_Left = (int)intCurrLeft;
                //objViewInfoENEx.objViewRegion_List.Style_Top = (int)intCurrTop;

                //iDGHeight = objViewInfoENEx.objViewRegion_List.Height + 50;


                strCodeForCs.AppendFormat("\r\n" + "<div id = \"divFunction\" class = \"div_Funttion\" runat = \"server\">",
                  objViewInfoENEx.TabName, intCurrTop);

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
                    //  objViewInfoENEx.TabName);
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
            return strCodeForCs.ToString();
        }
        public string ClsName4WucTabName4Gv()
        {
            string strClsName = string.Format("wuc{0}4Gv", objViewInfoENEx.TabName_Out);
            return strClsName;
        }
        private string gfunRadioClick()
        {
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleId_Cache(objViewInfoENEx.objViewStyleEN.TitleStyleId);
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

        private string GenViewTitle(string strTitle, clsViewInfoENEx objViewInfoENEx)
        {
            if (string.IsNullOrEmpty(objViewInfoENEx.objViewStyleEN.TitleStyleId) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("在界面:{0}中,没有设置标题类型,请检查!", objViewInfoENEx.ViewName);
                throw new Exception(sbMsg.ToString());
            }
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleId_Cache(objViewInfoENEx.objViewStyleEN.TitleStyleId);
            if (objTitleStyle == null)
            {
                string strMsg = string.Format("(errid:BlEx000044)标题模式Id:[{0}]没有相应的对象，请检查!(AutoGC6Cs_VWeb_Net2005:GenViewTitle)", objViewInfoENEx.objViewStyleEN.TitleStyleId);
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
            clsLabelStyleEN objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleId_Cache("0001");
            clsGenCtlStyleEN objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleId_Cache("0001");
            clsCheckStyleEN objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleId_Cache("0001");
            clsButtonStyleEN objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleId_Cache("0001");
            float intDivHeight;
            int intQueryFldNum = 0;

            if (objViewInfoENEx.arrQryRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有查询区域。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            objBiDimDistribue4Qry = new clsBiDimDistribute();

            objBiDimDistribue4Qry.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum;
            objBiDimDistribue4Qry.ColWidth = 250;
            objBiDimDistribue4Qry.LineHeight = 30;
            float intDivWidth = objBiDimDistribue4Qry.GetCtlWidth();

            intQueryFldNum = objViewInfoENEx.arrQryRegionFldSet.Count;

            //			intDivHeight = intQueryFldNum * 28 +40;
            intDivHeight = objBiDimDistribue4Qry.GetCtlHeigh(intQueryFldNum) + 40;

            strCodeForCs.AppendFormat("\r\n" + "<div id = \"divQuery\" class = \"div_query\"> ",
              objViewInfoENEx.TabName, intDivHeight);
            strCodeForCs.AppendFormat("\r\n" + "<table class = \"msgtable\" style = \"width: 80%\"> ",
             objViewInfoENEx.TabName, intDivHeight);

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

                switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
                {
                    case "CheckBox":
                        strCodeForCs.Append("\r\n" + GenCheckBoxNoPosition(objCheckStyle, objQryRegionFldsEx.CtrlId, objQryRegionFldsEx.LabelCaption));
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" +
                          GenCombineCtlNoPosition(objLabelStyle_Text,
                          "lbl" + objQryRegionFldsEx.FldName + "_q",
                          objQryRegionFldsEx.LabelCaption,
                          objGenCtlStyle,
                          objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName,
                          objQryRegionFldsEx.CtrlId));
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
                objCheckStyle.Style_Zindex = intZIndex + 1;
                objCheckStyle.Style_Left = (int)intCurrLeft;
                objCheckStyle.Style_Top = (int)intCurrTop;

                ///生成CheckBox的代码;
                ///
                //生成控件的<开始标志>和<ID>
                strCodeForCs.Append("\r\n" + "<td>");
                strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox id = \"{0}\" ",
                  strCheckId);
                //生成<控件样式Style>
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{1}px; Height:{2}px;\" ",
                  objCheckStyle.Style_Zindex,
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
            objLabelStyle.Style_Zindex = intZIndex + 1;
            objLabelStyle.Style_Left = (int)intCurrLeft;
            objLabelStyle.Style_Top = (int)intCurrTop;
            ///生成Label的代码;
            ///      
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" style = \"z-index: {1};\" ",
              strLabelId, objLabelStyle.Style_Zindex, objLabelStyle.Width, objLabelStyle.Height);
            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"NameLabel\">",
              objLabelStyle.Runat);
            strCodeForCs.AppendFormat("{0}</asp:Label>",
              strLabelText);
            strCodeForCs.Append("\r\n" + "</td>");

            intZIndex += 1;

            objGenCtlStyle.Style_Zindex = intZIndex + 1;
            objGenCtlStyle.Style_Left = (int)intCurrLeft + objLabelStyle.Width + 5;
            //objGenCtlStyle.Style_Left = (int)intCurrLeft + 5;
            objGenCtlStyle.Style_Top = (int)intCurrTop;
            ///生成右边控件的代码;
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" style = \"z-index: {2}; \" ",
              strCtlTypeName, strCtlId, objGenCtlStyle.Style_Zindex, objGenCtlStyle.Width, objGenCtlStyle.Height);

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
                objButtonStyle.Style_Zindex = intZIndex + 1;
                objButtonStyle.Style_Left = (int)intCurrLeft;
                objButtonStyle.Style_Top = (int)intCurrTop;

                ///生成Button的代码;
                ///
                //生成控件的<开始标志>和<ID>
                strCodeForCs.AppendFormat("\r\n" + "<asp:Button id = \"{0}\" ",
                  strButtonId);
                //生成<控件样式Style>
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{2}px; Height:{3}px;\" ",
                  objButtonStyle.Style_Zindex, objButtonStyle.Style_Left,
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
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 定义用于编辑的层Div，该层可以被弹出
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public string Gen_WApi_Ts_DefDiv4EditRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n" + " <div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">", 
                objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " <div class=\"modal-dialog\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-content\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-header\">");
            strCodeForCs.AppendFormat("\r\n" + " <h4 class=\"modal-title\" id=\"lblDialogTitle_{0}\">模态框（Modal）标题</h4>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\">&times;</button>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-body\">");
            strCodeForCs.Append("\r\n" + " <table style=\"width: 100%;\">");

            foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {
                ///如果该字段不是标识递增型就生成控件,否则就不生成;
                if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                strCodeForCs.AppendFormat("\r\n" + "<tr>");
                //strCodeForCs.AppendFormat("\r\n" + "<td>");
                ///插入验证控件代码;
                switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType)
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
                          objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName,
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
            strCodeForCs.AppendFormat("\r\n" + " <button type=\"button\" class=\"btn btn-primary\" onclick=\"Submit_{0}()\">提交更改</button>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal-content -->");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal -->");
            strCodeForCs.Append("\r\n" + " </div>");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_ShowDataBak20211006()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate
|| objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                {
                    strCodeForCs.Append("\r\n /* 函数功能:把以该关键字的记录内容显示在界面上,");
                    strCodeForCs.Append("\r\n 　　　   在这里是把值传到表控件中");
                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n  <param name = \"{0}\">表记录的关键字,显示该表关键字的内容</param>",
                      objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "*/");

                    strCodeForCs.AppendFormat("\r\n" + "  public async Show1Data({0}: {1}) {{",
                        objKeyField.PrivFuncName, objKeyField.TypeScriptType);
                    strCodeForCs.Append("\r\n" + "        //操作步骤:");
                    strCodeForCs.Append("\r\n" + "        //1、检查关键字是否为空；");
                    strCodeForCs.Append("\r\n" + "        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；");
                    strCodeForCs.Append("\r\n" + "        //3、用提供的关键字初始化一个类对象；");
                    strCodeForCs.Append("\r\n" + "        //4、获取类对象的所有属性；");
                    strCodeForCs.Append("\r\n" + "        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中");
                    strCodeForCs.Append("\r\n" + "        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；");

                    strCodeForCs.Append("\r\n" + "        try {");
                    strCodeForCs.AppendFormat("\r\n" + "            const returnBool = await {0}_IsExistAsync({1});",
                        objViewInfoENEx.TabName_In, objKeyField.PrivFuncName);
                    
                    strCodeForCs.Append("\r\n" + "            if (returnBool == false) {");
                    strCodeForCs.AppendFormat("\r\n" + "                const strInfo = Format(\"关键字:[{{0}}] 的记录不存在!\", {0});",
                         objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "                //$('#lblResult1').val(strInfo);");
                    strCodeForCs.Append("\r\n" + "                //显示信息框");
                    strCodeForCs.Append("\r\n" + "                alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "            }");
                    strCodeForCs.Append("\r\n" + "            else {");
                    //                    strCodeForCs.Append("\r\n" + "                const strInfo = Format(\"关键字:[${strExam1TypeId}]的相关记录存在!\");");
                    //                  strCodeForCs.Append("\r\n" + "                //$('#lblResult1').val(strInfo);");
                    //                strCodeForCs.Append("\r\n" + "                //显示信息框");
                    //              strCodeForCs.Append("\r\n" + "                alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "            }");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        catch (e) {");
                    strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"检查相应关键字的记录存在不成功, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        try {");
                    strCodeForCs.AppendFormat("\r\n" + "            const obj{0}EN = await {0}_GetObjBy{1}Async({2});",
                        objViewInfoENEx.TabName_In, objKeyField.FldName, objKeyField.PrivFuncName);
                    
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        catch (e) {");
                    strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "        }");

                    strCodeForCs.Append("\r\n" + "        //3、用提供的关键字初始化一个类对象；");

                    strCodeForCs.AppendFormat("\r\n" + "        this.GetDataFrom{0}Class(obj{0}EN);",
                        objViewInfoENEx.TabName_In);


                    strCodeForCs.Append("\r\n" + "}");
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

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(WA_ViewScriptCS_Old_TS4TypeScript));
            //string strFuncName = objvFunction4GeneCodeEN.FuncName;
            //try
            //{
            //    string strCode = "";
            //    Type t = typeof(WA_ViewScriptCS_Old_TS4TypeScript);
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
            //this.ClsName = string.Format("WApi{0}_QUDI_TS", objViewInfoENEx.TabName);
            //objViewInfoENEx.ClsName = this.ClsName;

            this.ClsName = objViewInfoENEx.ViewName;
            objViewInfoENEx.ClsName = this.ClsName;
        }
        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    return strCodeForCs.ToString();
                }

                if (objvFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                {
                    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                }
                else
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                }

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
        public string Gen_WApi_Ts_btnCopyRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  添加新记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "public async btnCopyRecord_Click() {");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要克隆的记录！\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "const responseText = await this.CopyRecord(arrKeyIds);");
            if (objViewInfoENEx.IsUseCache4List)
            {
                strCodeForCs.AppendFormat("\r\n" + " await this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"复制记录不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnSetFldValue_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {

                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId_Cache(objInFor.ReleFldId, objInFor.PrjId);
                    string strFuncName = string.Format("{0}", objInFor.ButtonName.Substring(3));
                    strCodeForCs.AppendFormat("\r\n /* 设置字段值-{0}", objFieldTabEN.FldName);
                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n **/");

                    strCodeForCs.AppendFormat("\r\n" + "public async {0}_Click() {{", objInFor.ButtonName);
                    //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
                    strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(\"请选择需要克隆的记录！\");");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");

                    clsvViewFeatureFldsENEx objViewFeatureFlds = null;
                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsvViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrvViewFeatureFlds.Where(x =>
                               x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("功能：设置字段值的给值方式是给定值，但缺少相应的界面功能字段，请维护后再生成代码");
                        }
                        objViewFeatureFlds = arrViewFeatureFlds[0];

                    }
                    if (objInFor.FeatureId == enumPrjFeature.SetFieldValue_0148
        && objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsvViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrvViewFeatureFlds.Where(x =>
                        x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("功能：设置字段值的给值方式是给定值，但缺少相应的界面功能字段，请维护后再生成代码");
                        }

                        objViewFeatureFlds = arrViewFeatureFlds[0];
                        ASPControlEx objASPControlENEx = clsASPControlBLEx.GetControl_Asp(objViewFeatureFlds);

                        string strCtrlId = objASPControlENEx.CtrlId.Replace("SetFldValue_SetFldValue", "SetFldValue");
                        switch (objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType)
                        {
                            case "Number":
                                strCodeForCs.AppendFormat("\r\n" + "let str{0}: string = clsCommFunc4Ctrl.getInputValue(this.divName4Function,\"{1}\");",
                  objViewFeatureFlds.ObjFieldTabENEx.FldName,
                  strCtrlId);

                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                            objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return;");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "console.log('str{0}=' + str{0});", objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "let {0} = Number(str{1});",
                                    objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName); break;
                            case "boolean":
                                strCodeForCs.AppendFormat("\r\n" + "let {0}: boolean = $(\"#{1}\").prop(\"checked\");",
                  objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                  strCtrlId);

                                strCodeForCs.AppendFormat("\r\n" + "console.log('{0}=' + {0});", objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                           
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "let str{0}: string = $(\"#{1}\").val();",
                  objViewFeatureFlds.ObjFieldTabENEx.FldName,
                  strCtrlId);

                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                            objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return;");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "console.log('str{0}=' + str{0});", objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "console.log('arrKeyIds=');");
                        strCodeForCs.Append("\r\n" + "console.log(arrKeyIds);");
                        if (objViewFeatureFlds.ObjFieldTabENEx.IsNumberType())
                        {
                            strCodeForCs.AppendFormat("\r\n" + "var {0}:{1} = Number(str{2});", objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                                objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                                objViewFeatureFlds.ObjFieldTabENEx.FldName);
                        }
                        strCodeForCs.AppendFormat("\r\n" + "const responseText = await this.{0}(arrKeyIds, {1});", strFuncName, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "console.log('arrKeyIds=');");
                        strCodeForCs.Append("\r\n" + "console.log(arrKeyIds);");
                        strCodeForCs.AppendFormat("\r\n" + "const responseText = await this.{0}(arrKeyIds);", strFuncName);
                    }
                    if (objViewInfoENEx.IsUseCache4List)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "await this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch(e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"设置记录不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");

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
            return strCodeForCs.ToString();
        }



        public string Gen_WApi_Ts_SetFieldValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {
                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId_Cache(objInFor.ReleFldId, objInFor.PrjId);
                    string strFuncName = string.Format("{0}", objInFor.ButtonName.Substring(3));

                    strCodeForCs.AppendFormat("\r\n /* 设置字段值-{0}", objFieldTabEN.FldName);
                    strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
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


                    clsvViewFeatureFldsENEx objViewFeatureFlds = null;


                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsvViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrvViewFeatureFlds.Where(x =>
                               x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("功能：设置字段值的给值方式是给定值，但缺少相应的界面功能字段，请维护后再生成代码");
                        }
                        objViewFeatureFlds = arrViewFeatureFlds[0];

                        strCodeForCs.AppendFormat("\r\n" + "public async {0}(arr{1}: Array<string>, {3}: {2})",
                                strFuncName,
                                objKeyField.FldName,
                                objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                        strCodeForCs.Append("\r\n" + "{");
                        //ASPDropDownListEx objASPDropDownListENEx = clsASPDropDownListBLEx.GetDropDownLst_Asp(objViewFeatureFlds);
                        switch (objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType )
                        {
                            case "string":
                        
                            strCodeForCs.AppendFormat("\r\n" + "if ({0} == null || {0} == \"\" )",
                                        objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                                objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                objViewFeatureFlds.ObjFieldTabENEx.FldName);
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
                    }

                    strCodeForCs.AppendFormat("\r\n" + "if (arr{0}.length == 0)", objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "let strMsg = \"没有选择记录，不能设置字段值!\";");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}_GetObjLstBy{1}LstAsync(arr{1});",
objViewInfoENEx.TabName_In, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "console.log('responseText=');");
                    strCodeForCs.Append("\r\n" + "console.log(responseText);");
                    strCodeForCs.Append("\r\n" + "let intCount = 0;");

                    strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ObjLst)",
                        objViewInfoENEx.TabName_In);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = new cls{0}EN();", objViewInfoENEx.TabName_In);
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.CopyObjTo(objInFor, obj{0}EN);", objViewInfoENEx.TabName_In);


                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        if (objViewFeatureFlds == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"这里不正确，值为空！\";",
                                                      objViewInfoENEx.TabName_In, objFieldTabEN.FldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                                                      objViewInfoENEx.TabName_In, objFieldTabEN.FldName,
                                                      objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                        }
                    }
                    else
                    {

                        clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeId_Cache(objFieldTabEN.DataTypeId);
                        if (clsDataTypeAbbrBLEx.IsNumberType(objDataTypeAbbrEN) == true)
                        {
                            //strCodeForCs.Append("\r\n" + "objInFor.ExamTypeName = \"C_\" + objInFor.ExamTypeName;");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                                  objViewInfoENEx.TabName_In, objFieldTabEN.FldName, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                        }
                        else
                        {
                            if (objDataTypeAbbrEN.CsType == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = TransToBool(\"{2}\");",
                                                        objViewInfoENEx.TabName_In, objFieldTabEN.FldName, objInFor.DefaultValue);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} =\"{2}\";",
                                    objViewInfoENEx.TabName_In, objFieldTabEN.FldName, objInFor.DefaultValue);
                            }
                        }
                    }
                    strCodeForCs.Append("\r\n" + "var returnBool = false;");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "    obj{0}EN.sf_UpdFldSetStr = obj{0}EN.updFldString;//设置哪些字段被修改(脏字段)", objViewInfoENEx.TabName_In);

                    strCodeForCs.AppendFormat("\r\n" + "returnBool = await {0}_UpdateRecordAsync(obj{0}EN);", objViewInfoENEx.TabName_In);
                
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"设置记录不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                    strCodeForCs.Append("\r\n" + "}");


                    strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strInfo = Format(\"设置记录成功!\");");
                    strCodeForCs.Append("\r\n" + "intCount++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strInfo = Format(\"设置记录不成功!\");");
                    //strCodeForCs.Append("\r\n" + "$('#lblResult20').val(strInfo);");
                    strCodeForCs.Append("\r\n" + "//显示信息框");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "const strInfo = Format(\"共设置了{0}条记录!\", intCount);");
                    //strCodeForCs.Append("\r\n" + "$('#lblResult20').val(strInfo);
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "console.log('完成！');");

                    strCodeForCs.Append("\r\n" + "if (intCount > 0)");
                    strCodeForCs.Append("\r\n" + "{");
                    Gene_ReFreshCache(strCodeForCs);
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"设置记录不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
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
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnGoTop_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";
                                
                strCodeForCs.Append("\r\n /* 置顶");
                strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnGoTop_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        //strCodeForCs.AppendFormat("\r\n" + " var str{0}:string =$('#{1}').val();",
                        //  objInFor.FldName, objInFor.CtrlId);
                        if (objInFor.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38)
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var {3}{0}:{2} ={4}.{1}_Static;",
                              objInFor.FldName, objInFor.VarName,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().DataTypeAbbr,
                              this.ClsName);

                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var str{0}:string ={2}.{1};",
objInFor.FldName, objInFor.CtrlId.Substring(3), this.ClsName);
                            if (objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " var lng{0}:number = Number(str{0});",
                                            objInFor.FldName);
                            }
                        }
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),                      
                            Comment = string.Format("{0} (Used In {1})", objInFor.FldName,
                                        "btnGoTop_Click()"),
                            DataType = "string"
                        });
                    }
                }
                strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"请选择需要置顶的记录！\");");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "var objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "var jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                           objInFor.FldName,
                           objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "var jsonStr:string = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_GoTopAsync(objOrderByData);",
                     objViewInfoENEx.TabName,
                     objKeyField.PrivFuncListName,
                                          objAdjustOrderNum.VarLst);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_GoTopAsync(objOrderByData);",
                     objViewInfoENEx.TabName,
                     objKeyField.PrivFuncListName);
                }
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"置顶出错。错误:{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
                //strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                //    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                //    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strListDiv: string = this.divName4DataList;");
                
                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyId(strListDiv, e));");
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

        public string Gen_WApi_Ts_btnUpMove_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";


                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n 上移");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnUpMove_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        //strCodeForCs.AppendFormat("\r\n" + " var str{0}:string =$('#{1}').val();",
                        //    objInFor.FldName, objInFor.CtrlId);
                        if (objInFor.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38)
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var {3}{0}:{2} ={4}.{1}_Static;",
                              objInFor.FldName, objInFor.VarName,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().DataTypeAbbr,
                              this.ClsName);

                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var str{0}:string ={2}.{1};",
          objInFor.FldName, objInFor.CtrlId.Substring(3), this.ClsName);
                            if (objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " var lng{0}:number = Number(str{0});",
                                            objInFor.FldName);
                            }
                        }
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),                          
                            Comment = string.Format("{0} (Used In {1})", objInFor.FldName,
                                        "btnUpMove_Click()"),
                            DataType = "string"
                        });
                    }
                }
                strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要上移的记录!`);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                //                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "var objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "var jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName,
                            objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "var jsonStr:string = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_UpMoveAsync(objOrderByData);",
                     objViewInfoENEx.TabName,
                     objAdjustOrderNum.VarLst,
                     objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_UpMoveAsync(objOrderByData);",
                     objViewInfoENEx.TabName,
                                          objKeyField.PrivFuncName);
                }
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"上移记录出错。错误:{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
                strCodeForCs.Append("\r\n" + "const strListDiv: string = this.divName4DataList;");
                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyId(strListDiv, e));");
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

        public string Gen_WApi_Ts_MoveRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";



                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n 移动记录，包括上移和下移");
                strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async MoveRecord(strDirect: string)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " var str{0}:string =$('#{1}').val();",
                            objInFor.FldName, objInFor.CtrlId);
                    }
                }
                strCodeForCs.Append("\r\n" + "const strKeyId = clsCommFunc4Ctrl.GetFirstCheckedKeyId(objPage.divName4List);");
                strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要移动(${strDirect})的记录!`);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

               
//                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_AdjustOrderNum(strDirect, {2}, strKeyId);",
                     objViewInfoENEx.TabName,
                     objAdjustOrderNum.VarLst,
                     objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_AdjustOrderNum(strDirect, strKeyId);",
                     objViewInfoENEx.TabName,
                                          objKeyField.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"移动({3})记录出错。错误:{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName, strDirect);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
       
                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
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
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnDownMove_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n 下移");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnDownMove_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        if (objInFor.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38)
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var {3}{0}:{2} ={4}.{1}_Static;",
                              objInFor.FldName, objInFor.VarName,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType, 
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().DataTypeAbbr,
                              this.ClsName);

                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var str{0}:string ={2}.{1};",
                          objInFor.FldName, objInFor.CtrlId.Substring(3), this.ClsName);

                            if (objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " var lng{0}:number = Number(str{0});",
                                            objInFor.FldName);
                            }
                        }
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),                  
                            Comment = string.Format("{0} (Used In {1})", objInFor.FldName,
                                        "btnDownMove_Click()"),
                            DataType = "string"
                        });
                    }
                }
                strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
                strCodeForCs.Append("\r\n" + "    if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`请选择需要下移的记录!`);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                //                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "var objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "var jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName,
                            objInFor.PrivFuncName);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "var jsonStr:string = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_DownMoveAsync(objOrderByData);",
                     objViewInfoENEx.TabName,
                     objAdjustOrderNum.VarLst,
                     objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_DownMoveAsync(objOrderByData);",
                     objViewInfoENEx.TabName,
                                          objKeyField.PrivFuncName);
                }
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"下移记录出错。错误:{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
                strCodeForCs.Append("\r\n" + "const strListDiv: string = this.divName4DataList;");
                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyId(strListDiv, e));");

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
        private void Gene_ReFreshCache(StringBuilder sbCode)
        {
            if (objViewInfoENEx.IsUseCache4List == true)
            {
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache();", objViewInfoENEx.TabName_In);
                }
                else
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache({2}.{1}_Cache);", objViewInfoENEx.TabName, objViewInfoENEx.objCacheClassifyFld4View.FldName, objViewInfoENEx.ClsName);
                }
            }
            else
            {
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache();", objViewInfoENEx.TabName_In);
                }
                else
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache({2}.{1}_Cache);", objViewInfoENEx.TabName, objViewInfoENEx.objCacheClassifyFld4View.FldName, objViewInfoENEx.ClsName);
                }
            }
        }


        public string Gen_WApi_Ts_PreCheck4Order()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsFeatureRegionFldsENEx objFeatureRegionFlds_GoTop = objViewInfoENEx.arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.AdjustOrderNum_1196);
                if (objFeatureRegionFlds_GoTop == null) return "";
                //clsViewFeatureFldsENEx objField_OrderNum = objViewInfoENEx.arrViewFeatureFlds.Find(x => x.FieldTypeId == enumFieldType.OrderNumField_09 && x.ViewFeatureId == objFeatureRegionFlds_GoTop.ViewFeatureId);
                IEnumerable<clsvViewFeatureFldsENEx> arrFieldLst_Classify = objViewInfoENEx.arrvViewFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ClassificationField_10 && x.ViewFeatureId == objFeatureRegionFlds_GoTop.ViewFeatureId);

                List<clsPrjTabFldENEx> arrFldSet = clsPrjTabFldBLEx.GetObjExLst(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);
                //生成仅有变量;
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                //foreach (clsPrjTabFldENEx objField in arrFldSet)
                //{
                //    if (objField.FieldTypeId == enumFieldType.ClassificationField_10)
                //    {
                //        clsFieldTabEN objFieldTabEN = clsFieldTabBLEx.GetObjExByFldID_Cache(objField.FldId, objField.PrjId);
                //        objAdjustOrderNum.ClassificationFieldValue = objFieldTabEN.FldName;
                //    }
                //    if (objField.FieldTypeId == enumFieldType.OrderNumField_09)
                //    {
                //        clsFieldTabEN objFieldTabEN = clsFieldTabBLEx.GetObjExByFldID_Cache(objField.FldId, objField.PrjId);

                //        objAdjustOrderNum.OrderNumFieldName = objFieldTabEN.FldName;
                //    }
                //}
                if (string.IsNullOrEmpty(objFeatureRegionFlds_GoTop.ReleFldId))
                {
                    strCodeForCs.AppendFormat("\r\n" + "//表：[{0}]的序号字段为空，不能生成【预检函数(PreCheck4Order)】;",
                        objViewInfoENEx.TabName);
                    return strCodeForCs.ToString();

                }
                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n 移动记录序号时的预检查函数");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public PreCheck4Order(): boolean");
                strCodeForCs.Append("\r\n" + "{");
                if (arrFieldLst_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsEN objInFor in arrFieldLst_Classify)
                    {
                        // strCodeForCs.AppendFormat("\r\n" + "// var str{0}:string =$('#{1}').val();",
                        //objInFor.FldName, objInFor.CtrlId);
                        if (objInFor.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38)
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var {3}{0}:{2} ={4}.{1}_Static;",
                              objInFor.FldName, objInFor.VarName,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().DataTypeAbbr,
                              this.ClsName);
                            if (objInFor.ObjFieldTab().IsNumberType())
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)",
                             objInFor.ObjFieldTab().PrivFuncName1());
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                objInFor.FldName);
                            }
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"请输入{0}!\");", objInFor.ObjFieldTab().FldName);
                            strCodeForCs.Append("\r\n" + "alert(strMsg);");

                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var str{0}:string ={2}.{1};",
     objInFor.FldName, objInFor.CtrlId.Substring(3), this.ClsName);

                            arrPropertyDef4GC.Add(new clsPropertyDef4GC
                            {
                                OperateType = "get",
                                ControlType = objInFor.CtlTypeName,
                                CtrlId = objInFor.CtrlId,
                                PropertyName = objInFor.CtrlId.Substring(3),
                                Comment = string.Format("{0} (Used In {1})", objInFor.FldName, "PreCheck4Order()"),
                                DataType = "string"
                            });
                            strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                            objInFor.FldName);

                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"请输入{0}!\");", objInFor.ObjFieldTab().FldName);
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
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnGoBottum_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";




                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n 置底");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnGoBottum_Click()");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        if (objInFor.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38)
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var {3}{0}:{2} ={4}.{1}_Static;",
                              objInFor.FldName, objInFor.VarName,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().DataTypeAbbr,
                              this.ClsName);

                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var str{0}:string ={2}.{1};",
     objInFor.FldName, objInFor.CtrlId.Substring(3), this.ClsName);
                            if (objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " var lng{0}:number = Number(str{0});",
                                            objInFor.FldName);
                            }
                        }
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = string.Format("{0} (Used In {1})", objInFor.FldName, "btnGoBottum_Click()"),
                            DataType = "string"
                        });
                    }
                }
                strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"请选择需要置底的记录！\");");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "var objOrderByData: clsOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "var jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");
                  
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},", 
                            objInFor.FldName,
                            objInFor.PrivFuncName);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "var jsonStr:string = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_GoBottomAsync(objOrderByData);",
                         objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_GoBottomAsync(objOrderByData);",
                         objViewInfoENEx.TabName,
                         objKeyField.PrivFuncListName);
                }
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"置底出错。错误:{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
                //strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                //        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                //        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                //strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "const strListDiv: string = this.divName4DataList;");
                strCodeForCs.Append("\r\n" + "arrKeyIds.forEach((e) => SetCheckedItem4KeyId(strListDiv, e));");
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
        public string Gen_WApi_Ts_btnReOrder_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);

                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";
                                             
                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n 重序");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.Append("\r\n" + "public async btnReOrder_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        if (objInFor.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38)
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var {3}{0}:{2} ={4}.{1}_Static;",
                              objInFor.FldName, objInFor.VarName,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType,
                              objInFor.ObjFieldTab().ObjDataTypeAbbr().DataTypeAbbr,
                              this.ClsName);

                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + " var str{0}:string ={2}.{1};",
     objInFor.FldName, objInFor.CtrlId.Substring(3), this.ClsName);
                            if (objInFor.ObjFieldTab().ObjDataTypeAbbr().TypeScriptType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + " var lng{0}:number = Number(str{0});",
                                            objInFor.FldName);
                            }
                        }
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),                            
                            Comment = string.Format("{0} (Used In {1})", objInFor.FldName, "btnReOrder_Click()"),
                            DataType = "string",
                            IsStatic = true
                        });
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "set",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = string.Format("{0} (Used In {1})", objInFor.FldName, "btnReOrder_Click()"),
                            DataType = "string",
                            IsStatic = true
                        });

                    }
                }
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "var objOrderByData: clsOrderByData = new clsOrderByData();");
                
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "var jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName,
                            objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "var jsonStr:string = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");

                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_ReOrderAsync(objOrderByData);",
                   objViewInfoENEx.TabName,
                   objAdjustOrderNum.VarLst);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {0}_ReOrderAsync(objOrderByData);",
                   objViewInfoENEx.TabName);
                }
                Gene_ReFreshCache(strCodeForCs);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"重序出错。错误:{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
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

        public string Gen_WApi_Ts_Code4QueryRegion()
        {
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

            string strClassName = string.Format("WA_{0}_Edit", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClassName) == false)
            {
                strClassName = objViewRegionENEx.ClassName;
            }

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 在当前界面中，导入编辑区域");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public async AddDPV_Edit(divName4Edit:string) {{",
                objViewInfoENEx.ClsName);
            strBuilder.Append("\r\n" + "clsCommFunc4Web.CheckDivExist(divName4Edit);");
            //strBuilder.Append("\r\n" + "var objLst = document.getElementsByTagName(\"div\");");
            //strBuilder.Append("\r\n" + "var strStartName = \"divEditEdit\";");
            //strBuilder.AppendFormat("\r\n" + "let arrElement = WA_{0}_UT_JS.GetArray(objLst) ;", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\n" + "let arrDiv = arrElement ;");
            //strBuilder.Append("\r\n" + "let arrFind = arrDiv.filter(x => x.id.indexOf(strStartName) > -1);");
            //strBuilder.Append("\r\n" + "arrFind.forEach(x => x.innerHTML = \"\");");
            //strBuilder.Append("\r\n" + "//var o = document.getElementById(\"div\") ;");
            strBuilder.AppendFormat("\r\n" + "const strUrl = \"./{0}/\";", strClassName);
            strBuilder.Append("\r\n" + "console.log(\"divName4Edit:(In AddDPV_Edit)\" + divName4Edit);");
            strBuilder.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strBuilder.Append("\r\n" + "$.ajax({");
            strBuilder.Append("\r\n" + "url: strUrl,");
            strBuilder.Append("\r\n" + "method: \"GET\",");
            strBuilder.Append("\r\n" + "dataType: \"html\",");
            strBuilder.Append("\r\n" + "data: { },");
            strBuilder.Append("\r\n" + "success: function(data:any) {");
            strBuilder.Append("\r\n" + "console.log(\"已经成功获取页面:\" + strUrl + \"  字节数: \" + data.length.toString());");
            strBuilder.Append("\r\n" + "$('#' + divName4Edit).html(data);");
            strBuilder.Append("\r\n" + "resolve(true);");
            strBuilder.AppendFormat("\r\n" + "//setTimeout(() => {{ clsEditObj.BindTab(); }}, 100);");
            strBuilder.AppendFormat("\r\n" + "//clsEditObj.BindTab();");
            strBuilder.Append("\r\n" + "},");
            strBuilder.Append("\r\n" + "error: (e:any) => {");
            strBuilder.Append("\r\n" + "console.error(e);");
            strBuilder.Append("\r\n" + "reject(e);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");
            strBuilder.Append("\r\n" + "});");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_WApi_Ts_AddDPV_Detail(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            string strClassName = string.Format("WA_{0}_Detail", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClassName) == false)
            {
                strClassName = objViewRegionENEx.ClassName;
            }

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 在当前界面中，导入编辑区域");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public async AddDPV_Detail(divName4Detail:string) {{",
                objViewInfoENEx.ClsName);
     
            strBuilder.AppendFormat("\r\n" + "const strUrl = \"./{0}/\";", strClassName);
            strBuilder.Append("\r\n" + "console.log(\"divName4Detail:(In AddDPV_Detail)\" + divName4Detail);");
            strBuilder.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strBuilder.Append("\r\n" + "$.ajax({");
            strBuilder.Append("\r\n" + "url: strUrl,");
            strBuilder.Append("\r\n" + "method: \"GET\",");
            strBuilder.Append("\r\n" + "dataType: \"html\",");
            strBuilder.Append("\r\n" + "data: { },");
            strBuilder.Append("\r\n" + "success: function(data:any) {");
            strBuilder.Append("\r\n" + "console.log(\"已经成功获取页面:\" + strUrl + \"  字节数: \" + data.length.toString());");
            strBuilder.Append("\r\n" + "$('#' + divName4Detail).html(data);");
            strBuilder.Append("\r\n" + "resolve(true);");
            strBuilder.AppendFormat("\r\n" + "//setTimeout(() => {{ clsDetailObj.BindTab(); }}, 100);");
            strBuilder.AppendFormat("\r\n" + "//clsDetailObj.BindTab();");
            strBuilder.Append("\r\n" + "},");
            strBuilder.Append("\r\n" + "error: (e:any) => {");
            strBuilder.Append("\r\n" + "console.error(e);");
            strBuilder.Append("\r\n" + "reject(e);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");
            strBuilder.Append("\r\n" + "});");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


    }
}
