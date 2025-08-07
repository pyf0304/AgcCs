using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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
    partial class WA_ViewScript_JS4Html : clsGeneCodeBase
    {
        private string strJSPath = "";
    
        clsBiDimDistribute objBiDimDistribue4Qry = null;
        #region 构造函数
        public WA_ViewScript_JS4Html()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
        }
        public WA_ViewScript_JS4Html(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public WA_ViewScript_JS4Html(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        /// <summary>
        /// 初始化页面设置
        /// </summary>
        public void InitPageSetup()
        {
            
        }

        #endregion


        public string Gen_WApi_JS_AddDPV_Pager(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  动态添加分页区域");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function AddDPV_Pager(divName4Pager) {");
            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\"], function({1}) {{",
                    objViewInfoENEx.ClsName, 
                    objViewInfoENEx.TabName.ToLower(), 
                    strJSPath);
            strCodeForCs.AppendFormat("\r\n" + "{0}.{1}Ex.AddDPV_Pager(divName4Pager);", 
                objViewInfoENEx.TabName.ToLower(), 
                objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_JS_AddDPV_Edit(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  动态添加编辑区域");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function AddDPV_Edit(divName4Edit) {");
            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\"], function({1}) {{",
                    objViewInfoENEx.ClsName,
                    objViewInfoENEx.TabName.ToLower(),
                    strJSPath);
            strCodeForCs.AppendFormat("\r\n" + "{0}.{1}Ex.AddDPV_Edit(divName4Edit);",
                objViewInfoENEx.TabName.ToLower(),
                objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }



      
        public string BakGen_WApi_JS_btnAddNewRecordWithMaxId_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  添加新记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function btnAddNewRecordWithMaxId_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\"], function({1}) {{",
        objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            strCodeForCs.Append("\r\n" + "ShowDialog('AddWithMaxId');");
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.btnAddNewRecordWithMaxId_Click();",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_WApi_JS_btn_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  按钮单击,用于调用Js函数中btn_Click");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function btn_Click(strCommandName, strKeyId) {");
            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\"], function({1}) {{",
        objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            
            strCodeForCs.AppendFormat("\r\n" + "{1}.{0}Ex.btn_Click(strCommandName, strKeyId);",
                objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_WApi_JS_Page_Load(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  页面导入-在导入页面后运行的函数");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");

            strCodeForCs.Append("\r\n" + "window.onload = function() {");

            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\"], function({1}) {{",
       objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());
            if (objViewInfoENEx.IsUseCache4List)
            {
                strCodeForCs.AppendFormat("\r\n" + "objPage.Page_Load_Cache();",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "objPage.Page_Load();",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName.ToLower());
            }
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_JS_ShowDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  显示对话框");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "function ShowDialog_{0}(pstrOp) {{", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "   strOp = pstrOp;");
            strCodeForCs.Append("\r\n" + "   require(['jquery', 'bootstrap'], function($) {");
            strCodeForCs.Append("\r\n" + "       if (strOp === \"Add\" || strOp === \"AddWithMaxId\") {");
            strCodeForCs.AppendFormat("\r\n" + "           $('#lblDialogTitle_{0}').html('添加记录');", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "//{0}Ex.GetMaxStrId('#txt{1}');",
                    objViewInfoENEx.ClsName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "        }");
            strCodeForCs.Append("\r\n" + "else if (strOp === \"Update\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "            $('#lblDialogTitle_{0}').html('修改记录');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strOp === \"Detail\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "            $('#btnSubmit_{0}').hide();", objViewInfoENEx.TabName_In);

            strCodeForCs.AppendFormat("\r\n" + "            $('#lblDialogTitle_{0}').html('详细信息');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "        $('#divEditDialog_{0}').modal('show');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "  });");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_JS_HideDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  隐藏对话框");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "function HideDialog_{0}() {{", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "  require(['jquery', 'bootstrap'], function($) {");
            strCodeForCs.AppendFormat("\r\n" + "      $('#divEditDialog_{0}').modal('hide');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "  });");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_JS_UpdateRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function UpdateRecord() {");
            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\", \"clscommonfunc4web\"], function({1}, commonfunc) {{",
         objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);

            strCodeForCs.AppendFormat("\r\n" + "const strKeyId = commonfunc.clsCommFunc4Ctrl.GetFirstCheckedKeyId(objPage.divName4List);",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "if (strKeyId == \"\") ");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要修改的记录！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Update');", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.ShowData(strKeyId);",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "return true;");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_JS_mySubmit(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  提交编辑");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "function Submit_{0}(pstrOp) {{  ", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "//    alert(\"提交\" + strOp);");
            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\"], function({1}) {{",
                objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);

            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "           objPage.btnSubmit_Click();",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "    });");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string BakGen_WApi_JS_btnQuery_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  查询记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function btnQuery_Click()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\"], function({1}) {{",
                objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnQuery_Click\");");
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.btnQuery_Click();",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string BakGen_WApi_JS_btnUpdateRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function btnUpdateRecord_Click() {");

            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\", \"clscommonfunc4web\"], function({1}, commonfunc) {{",
            objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            strCodeForCs.Append("\r\n" + "const strKeyId = commonfunc.clsCommFunc4Ctrl.GetFirstCheckedKeyId(objPage.divName4List);");
            strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要修改的记录！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Update');", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "  objPage.btnUpdateRecord_Click();",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_JS_btnUpdateRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  在数据表里修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function btnUpdateRecordInTab_Click(strKeyId) {");

            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\"], function({1}) {{",
            objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要修改的记录！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "  objPage.btnUpdateRecordInTab_Click(strKeyId);",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }

        public string BakGen_WApi_JS_btnCopyRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  复制记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function btnCopyRecord_Click() {");

            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\", \"clscommonfunc4web\"], function({1}, commonfunc) {{",
            objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            strCodeForCs.Append("\r\n" + "const arrKeyIds = commonfunc.clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要复制的记录！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "  objPage.btnCopyRecord_Click();",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }


        public string BakGen_WApi_JS_btnGoTop_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  记录置顶");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function btnGoTop_Click() {");

            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\", \"clscommonfunc4web\"], function({1}, commonfunc) {{",
            objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            strCodeForCs.Append("\r\n" + "const arrKeyIds = commonfunc.clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要置顶的记录！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "  objPage.btnGoTop_Click();",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }

        public string BakGen_WApi_JS_btnUpMove_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  记录上移");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function btnUpMove_Click() {");

            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\", \"clscommonfunc4web\"], function({1}, commonfunc) {{",
            objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            strCodeForCs.Append("\r\n" + "const arrKeyIds = commonfunc.clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要上移的记录！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "  objPage.btnUpMove_Click();",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }

        public string BakGen_WApi_JS_btnDownMove_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  记录下移");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function btnDownMove_Click() {");

            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\", \"clscommonfunc4web\"], function({1}, commonfunc) {{",
            objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            strCodeForCs.Append("\r\n" + "const arrKeyIds = commonfunc.clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要下移的记录！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "  objPage.btnDownMove_Click();",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }

        public string BakGen_WApi_JS_btnGoBottum_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  记录移底");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function btnGoBottum_Click() {");

            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\", \"clscommonfunc4web\"], function({1}, commonfunc) {{",
            objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            strCodeForCs.Append("\r\n" + "const arrKeyIds = commonfunc.clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要移底的记录！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "  objPage.btnGoBottum_Click();",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }

        public string BakGen_WApi_JS_btnReOrder_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  记录重序");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function btnReOrder_Click() {");

            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\", \"clscommonfunc4web\"], function({1}, commonfunc) {{",
            objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            //strCodeForCs.Append("\r\n" + "const arrKeyIds = commonfunc.clsCommFunc4Ctrl.GetCheckedKeyIds();");
            //strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "alert(\"请选择需要移底的记录！\");");
            //strCodeForCs.Append("\r\n" + "return;");
            //strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "  objPage.btnReOrder_Click();",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_JS_btnSetFldValue_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
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

                    strCodeForCs.AppendFormat("\r\n" + "function {0}_Click() {{", objInFor.ButtonName);
                    //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

                    strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\", \"clscommonfunc4web\"], function({1}, commonfunc) {{",
                    objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
                    strCodeForCs.Append("\r\n" + "const arrKeyIds = commonfunc.clsCommFunc4Ctrl.GetCheckedKeyIds();");
                    strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(\"请选择需要设置字段值的记录！\");");
                    strCodeForCs.Append("\r\n" + "return;");
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

                        strCodeForCs.AppendFormat("\r\n" + "const {0} = $(\"#{1}\").val();",
                            objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                            strCtrlId);

                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == \"\")",
                                    objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                            objViewFeatureFlds.ObjFieldTabENEx.Caption,
                            objViewFeatureFlds.ObjFieldTabENEx.FldName);
                        strCodeForCs.Append("\r\n" + "alert(strMsg);");
                        strCodeForCs.Append("\r\n" + "return;");
                        strCodeForCs.Append("\r\n" + "}");

                    }
                    strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

                    strCodeForCs.AppendFormat("\r\n" + "  objPage.{2}_Click();",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower(), objInFor.ButtonName);
                    strCodeForCs.Append("\r\n" + "});");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "");
                }

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string BakGen_WApi_JS_btnDelRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  删除记录的事件函数");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function btnDelRecord_Click() {");


            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\", \"clscommonfunc4web\"], function({1}, commonfunc) {{",
            objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            strCodeForCs.Append("\r\n" + "const arrKeyIds = commonfunc.clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要删除的记录！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (clsCommFunc4Web.confirm_del(arrKeyIds.length) == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.btnDelRecord_Click();", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_JS_btnDelRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  在数据表里删除记录的事件函数");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function btnDelRecordInTab_Click(strKeyId) {");


            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\"], function({1}) {{",
            objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            //strCodeForCs.Append("\r\n" + "const arrKeyIds = commonfunc.clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");            
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要删除的记录！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (clsCommFunc4Web.confirm_del(0) == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.btnDelRecordInTab_Click(strKeyId);", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_JS_btnDetailRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  在数据表里详细记录信息的事件函数");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function btnDetailRecordInTab_Click(strKeyId) {");


            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\"], function({1}) {{",
            objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            //strCodeForCs.Append("\r\n" + "const arrKeyIds = commonfunc.clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要详细信息的记录！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Detail');", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.btnDetailRecordInTab_Click(strKeyId);", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_JS_btnSelectRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  在数据表里选择记录信息的事件函数");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function btnSelectRecordInTab_Click(strKeyId) {");


            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\"], function({1}) {{",
            objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            //strCodeForCs.Append("\r\n" + "const arrKeyIds = commonfunc.clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要详细信息的记录！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.btnSelectRecordInTab_Click(strKeyId);", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }


        public string BakGen_WApi_JS_btnUnDelRecordBySign_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  恢复被标志删除的事件函数");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function btnUnDelRecordBySign_Click() {");


            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\", \"clscommonfunc4web\"], function({1}, commonfunc) {{",
            objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            strCodeForCs.Append("\r\n" + "const arrKeyIds = commonfunc.clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要恢复删除的记录！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.btnUnDelRecordBySign_Click();", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }

        public string BakGen_WApi_JS_btnDelRecordBySign_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  按标志删除记录的事件函数");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function btnDelRecordBySign_Click() {");


            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\", \"clscommonfunc4web\"], function({1}, commonfunc) {{",
            objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            strCodeForCs.Append("\r\n" + "const arrKeyIds = commonfunc.clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要按标志删除的记录！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.btnDelRecordBySign_Click();", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_JS_ChkClick(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  单击数据列表中每行首列的复选框所引发的事件");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function ChkClick(myThis)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "require([\"{2}/{0}Ex.js\", \"clscommonfunc4web\"], function({1}, commonfunc) {{",
                objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            strCodeForCs.Append("\r\n" + "const strId = myThis.id;");
            strCodeForCs.Append("\r\n" + "const strKey = strId.substring(3);");
            strCodeForCs.Append("\r\n" + "const arrKeys = commonfunc.arrSelectedKeys;");
            strCodeForCs.Append("\r\n" + "if (myThis.checked == true) {");
            strCodeForCs.Append("\r\n" + "if (arrKeys.indexOf(strKey) < 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "arrKeys.push(strKey);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else {");
            strCodeForCs.Append("\r\n" + "const index = arrKeys.indexOf(strKey);");
            strCodeForCs.Append("\r\n" + "if (index > -1)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "arrKeys.splice(index, 1);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "const sstrKey = \"\";");
            strCodeForCs.Append("\r\n" + "for (let strK of arrKeys)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "sstrKey += strK + \",\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "$('#spanResult').html(sstrKey);");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_JS_GetAllCkechedKeys(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  获取数据列表中的所选记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function GetAllCkechedKeys(tabName)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrKeys = tabName.getElementsByTagName('chkInTab');");
            strCodeForCs.Append("\r\n" + "alert(arrKeys.length.toString());");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_JS_SetAllCkechedKeys(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  全选数据列表中的所有记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function SetAllCkechedKeys(tabName)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const thisChk = event.target;");
            strCodeForCs.Append("\r\n" + "require([\"clscommonfunc4web\"], function (commonfunc) { ");
            strCodeForCs.Append("\r\n" + "console.log(tabName);");
            strCodeForCs.Append("\r\n" + "console.log(thisChk);");
            //console.log(commonfunc);
            //console.log(commonfunc.SetAllCkechedKeys);

            strCodeForCs.Append("\r\n" + "commonfunc.clsCommFunc4Web.SetAllCkechedKeys(tabName, thisChk);");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_JS_IndexPage(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function IndexPage(intPageIndex)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.log(\"跳转到\" + intPageIndex + \"页\");");
            strCodeForCs.AppendFormat("\r\n" + "require([\"{2}/{0}Ex.js\"], function({1}) {{",
                objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.IndexPage(intPageIndex);",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_JS_PageNum(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function PageNum(intPageIndex)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.log(\"跳转到\" + intPageIndex + \"页\");");
            strCodeForCs.AppendFormat("\r\n" + "require([\"{2}/{0}Ex.js\"], function({1}) {{",
                objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.IndexPage(intPageIndex);",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_JS_PrevPage(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function PrevPage()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = $('#hidCurrPageIndex').val();");
            strCodeForCs.Append("\r\n" + "const intPageIndex = Number(intCurrPageIndex) - 1;");
            strCodeForCs.Append("\r\n" + "console.log(\"跳转到\" + intPageIndex + \"页\");");
            strCodeForCs.AppendFormat("\r\n" + "require([\"{2}/{0}Ex.js\"], function({1}) {{",
                objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.IndexPage(intPageIndex);",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_JS_NextPage(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function NextPage()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = $('#hidCurrPageIndex').val();");
            strCodeForCs.Append("\r\n" + "const intPageIndex = Number(intCurrPageIndex) + 1;");
            strCodeForCs.Append("\r\n" + "console.log(\"跳转到\" + intPageIndex + \"页\");");
            strCodeForCs.AppendFormat("\r\n" + "require([\"{2}/{0}Ex.js\"], function({1}) {{",
                objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", 
                objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.IndexPage(intPageIndex);",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_JS_JumpToPage(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function JumpToPage()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = $('#input_number').val();");
            strCodeForCs.Append("\r\n" + "const intPageIndex = Number(intCurrPageIndex);");
            strCodeForCs.Append("\r\n" + "console.log(\"跳转到\" + intPageIndex + \"页\");");
            strCodeForCs.AppendFormat("\r\n" + "require([\"{2}/{0}Ex.js\"], function({1}) {{",
                objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.IndexPage(intPageIndex);",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_JS_SortBy(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function SortBy(strFldName)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "console.log(\"按：\" + strFldName + \"排序\");");
            strCodeForCs.AppendFormat("\r\n" + "require([\"{2}/{0}Ex.js\"], function({1}) {{",
                objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());

            strCodeForCs.AppendFormat("\r\n" + "objPage.SortBy(strFldName);",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_JS_ExpandDiv(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "         function ExpandDiv(divName) {");
            strCodeForCs.Append("\r\n" + "//基于RequireJS来调用tzPubFun.ts中的函数OnlyShowDiv。");
            strCodeForCs.Append("\r\n" + "require([\"../js/TS/PubFun/tzPubFun\"], function (pubfun) {");
            strCodeForCs.Append("\r\n" + "      pubfun.OnlyShowDiv(divName, \"function\", \"content\");");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
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
                            strCodeForCs.AppendFormat("\r\n" + "const {1}: {0} = $('#txt{1}{2}').val();",
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
                                    strCodeForCs.AppendFormat("\r\n" + "const {1}:{0} = Number($('#txt{1}{2}').val());",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.Array_31:
                                    strCodeForCs.AppendFormat("\r\n" + "const {1}:{0} = $('#txt{1}{2}').val();",
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
        private string GetCode4FieldInPutDataToClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }

            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = $(\"#{2}\").val();",
            objViewInfoENEx.TabName,
            objEditRegionFldsEx.FldName,
            objEditRegionFldsEx.CtrlId);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

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

            sbCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(pobj{1}EN.{2});",
                        objEditRegionFldsEx.CtrlId,
                        objViewInfoENEx.TabName,
                        objEditRegionFldsEx.FldName);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
           /// <summary>
        /// 功能:单表的查询、修改、插入、删除
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
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
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleId_Cache(objViewInfoENEx.objViewStyleEN.DgStyleId);


            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
  objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);

            //if (objViewInfoENEx.IsUseCache4List)
            //{
            //    objViewInfoENEx.WebFormName = string.Format( "WA_{0}_QUDI_Cache", objViewInfoENEx.TabName );
            //    objViewInfoENEx.WebFormFName = string.Format("{0}WA_{1}_QUDI_Cache.html",
            //        objViewInfoENEx.FolderName, objViewInfoENEx.TabName);
            //}
            //else
            //{
            //    objViewInfoENEx.WebFormName = string.Format("WA_{0}_QUDI_JS", objViewInfoENEx.TabName);
            //    objViewInfoENEx.WebFormFName = string.Format("{0}WA_{1}_QUDI_JS.html",
            //        objViewInfoENEx.FolderName, objViewInfoENEx.TabName);
            //}

            objViewInfoENEx.WebFormName = string.Format("{0}", objViewInfoENEx.ClsName);
            objViewInfoENEx.WebFormFName = string.Format("{0}{1}.html",
                objViewInfoENEx.FolderName, objViewInfoENEx.ClsName);

            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            
            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName, objViewInfoENEx.WebFormFName);

            try
            {
                ///生成插入记录的界面代码;
                ///      strCodeForCs.Append("///生成查询、修改、删除、添加记录的界面代码(利用控件)");
                //strCodeForCs.AppendFormat("\r\n" + "<%@ Register TagPrefix = \"uc1\" TagName = \"wuc{0}B\" Src = \"wuc{1}B.ascx\" %>",
                //  objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "<%@ Register TagPrefix = \"uc2\" TagName = \"{0}\" Src = \"{0}.ascx\" %>",
                //    ClsName4WucTabName4Gv());
                if (objViewInfoENEx.ApplicationTypeId2 == "04")
                {
                    strCodeForCs.AppendFormat("\r\n" + "<%@ Page language = \"c#\" AutoEventWireup = \"true\"  %>",
                       objViewInfoENEx.WebFormName, objViewInfoENEx.NameSpace, objViewInfoENEx.WebFormName);
                    strCodeForCs.Append("\r\n" + "<!DOCTYPE html>");
                    strCodeForCs.Append("\r\n" + "<html xmlns = \"http://www.w3.org/1999/xhtml\">");
                    strCodeForCs.Append("\r\n" + "<head runat = \"server\">");
                    strCodeForCs.Append("\r\n" + "<meta http-equiv = \"Content-Type\" content = \"text/html; charset = utf-8\" />");
                    strCodeForCs.AppendFormat("\r\n" + "<title>{0}的维护</title>", objViewInfoENEx.ViewCnName);
                    strCodeForCs.AppendFormat("\r\n" + "<link rel = \"stylesheet\" type = \"text/css\" href = \"../../css/tz_base1.css\"/>",
                        objViewInfoENEx.NameSpace);
                    strCodeForCs.Append("\r\n" + "     <link href=\"../../Content/bootstrap.css\" rel=\"stylesheet\" />");
                    strCodeForCs.Append("\r\n" + "     <link href=\"../../Content/bootstrap.min.css\" rel=\"stylesheet\" />");
                    strCodeForCs.Append("\r\n" + "<link href=\"../../Css/PagerCss.less\" type = \"text/css\" rel = \"stylesheet/less\" />");
                    strCodeForCs.Append("\r\n" + "<script src = \"../../scripts/less-1.5.1.min.js\" ></script >");
                    strCodeForCs.Append("\r\n" + "<script type = \"text/javascript\" data-main = \"reqconfig.js\" src = \"../../Scripts/require.js\" ></script>");

                }
                else
                {
                    strCodeForCs.Append("\r\n" + "<!DOCTYPE html>");
                    strCodeForCs.Append("\r\n" + "<html>");
                    strCodeForCs.Append("\r\n" + "<head>");
                    strCodeForCs.Append("\r\n" + "<meta charset = \"utf-8\" />");
                    strCodeForCs.AppendFormat("\r\n" + "<title>{0} </title>", objViewInfoENEx.ViewCnName);
                    strCodeForCs.Append("\r\n" + "<link rel=\"shortcut icon\" href=\"../../images/favicon.ico\" type=\"image/x-icon\" />");
                    strCodeForCs.Append("\r\n" + "    <link href=\"../../Content/bootstrap.css\" rel=\"stylesheet\" />");
                    strCodeForCs.Append("\r\n" + "<script src=\"../../Js/PubFun/clsCommFunc4Web.js\"></script>");
                    //strCodeForCs.Append("\r\n" + "    <link href=\"../../Css/site.css\" rel=\"stylesheet\" />");
                    strCodeForCs.Append("\r\n" + "    <script src=\"../../scripts/jquery-3.4.1.min.js\"></script>");
                    //strCodeForCs.Append("\r\n" + "    <script src=\"../../scripts/bootstrap.js\"></script>");
                    //strCodeForCs.Append("\r\n" + "    <script src=\"/js1/site.js\" asp-append-version=\"true\"></script>");
                    //strCodeForCs.Append("\r\n" + "<script src=\"../../scripts/popper.js\"></script>");
                    strCodeForCs.Append("\r\n" + "<script data-main=\"../../js/src/config\" src=\"../../scripts/require.js\"></script>");
                }
       
                strCodeForCs.Append("\r\n" + "<script type=\"text/javascript\">");

                strCodeForCs.Append("\r\n" + "const strUrl_Session_SetString = \"@Model.Url_Session_SetString\";");
                strCodeForCs.Append("\r\n" + "const strUrl_Session_GetString = \"@Model.Url_Session_GetString\";");
                strCodeForCs.Append("\r\n" + "const strCurrPrjId = \"@Model.CurrPrjId\";");
                strJSPath = string.Format(".", objFuncModule.FuncModuleEnName);

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_JS =
                    clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx_JS(objViewInfoENEx);


                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_JS =
                //    clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                //        clsPubConst.LangType.JavaScript, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId).OrderBy(x => x.FuncName4Code);
                
                ////int intCount1 = arrvFunction4GeneCodeObjLst.Count();
                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstByFeature = objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst;
                ////int intCount2 = arrvFunction4GeneCodeObjLstByFeature.Count();
                //arrvFunction4GeneCodeObjLstByFeature = arrvFunction4GeneCodeObjLstByFeature.Where(x => x.CodeTypeId == objViewInfoENEx.CodeTypeId && x.ProgLangTypeId == enumProgLangType.JavaScript_04);
                ////int intCount3 = arrvFunction4GeneCodeObjLstByFeature.Count();

                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_JS_All = arrvFunction4GeneCodeObjLst_JS.Union(arrvFunction4GeneCodeObjLstByFeature, 
                //    new VFunction4GeneCodeComparer());

                ////int intCount4 = arrvFunction4GeneCodeObjLst_All.Count();

                //arrvFunction4GeneCodeObjLst_JS_All = arrvFunction4GeneCodeObjLst_JS_All.OrderBy(x => x.FuncName4Code);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_JS)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);

                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }


                strCodeForCs.Append("\r\n" + "    </script>");

                strCodeForCs.Append("\r\n" + "</head>");


                strCodeForCs.Append("\r\n" + "<body>");
                if (objDGStyleEx.IsRadio == true)
                {
                    strCodeForCs.Append("\r\n" + gfunRadioClick());
                }
                //strCodeForCs.Append("\r\n" + "</head>");

          

                strCodeForCs.Append("\r\n" + "<div id = \"tabLayout\" class = \"tab_layout\" ");
                strCodeForCs.Append("\r\n" + ">");
                
                strCodeForCs.Append("\r\n" + "<!-- 标题层 -->");
                strCodeForCs.AppendFormat("\r\n" + GenViewTitle(string.Format("{0}", objViewInfoENEx.ViewCnName), objViewInfoENEx));
                //生成查询区域代码-------------------------------
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery == true)
                {
                    

                    //生成专门用于查询的界面控件的代码;             
                    strCodeForCs.Append("\r\n" + "<!-- 查询层 -->");

                    strCodeForCs.Append("\r\n" + GenQryRegionCode4Table());
                    
                    strCodeForCs.Append("\r\n" + "<!-- 功能区 -->");
               
                    strCodeForCs.Append("\r\n" + GenFeatureRegion(objViewInfoENEx.objViewRegion_List, objViewInfoENEx));
                    strCodeForCs.Append("\r\n" + "<!-- 列表层 -->");
                    
                    strCodeForCs.Append("\r\n" + "<div id = \"divList\" class = \"div_List\" >");

                    strCodeForCs.Append("\r\n" + "<div id = \"divDataLst\" class = \"div_List\" >");

                    strCodeForCs.Append("\r\n" + "</div>");
                    strCodeForCs.Append("\r\n" + "<div id = \"divPager\" class = \"pager\" value=\"1\" >");
                    //strCodeForCs.Append("\r\n" + "@Html.Partial(\"~/Pages/PubWebClass/pager.cshtml\")");
                    strCodeForCs.Append("\r\n" + "</div>");
                    strCodeForCs.Append("\r\n" + "</div>");

                    //strCodeForCs.Append("\r\n" + GenGridViewNew(objViewInfoENEx.objViewRegion_List, objViewInfoENEx));

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
                    strCodeForCs.Append("\r\n" + "<!-- 编辑层 -->");
                    //strCodeForCs.Append("\r\n" + Gen_WApi_Cs4Ts_DefDiv4EditRegion());
                    strCodeForCs.Append("\r\n" + "<div id=\"divEdit\" value=\"1\"></div>");
                    
                }
                //生成编辑区域代码 == == == == == == == == == == == == == == 

                strCodeForCs.Append("\r\n" + "</div>");
                strCodeForCs.Append("\r\n" + "<input id=\"hidOpType\" type=\"hidden\" />");
                strCodeForCs.Append("\r\n" + "<input id=\"hidKeyId\" type=\"hidden\" />");
                strCodeForCs.Append("\r\n" + "<input id=\"hidUserId\" type = \"hidden\" value = \"@Model.seUserId\" />");
                strCodeForCs.Append("\r\n" + "<input id=\"hidUserId1\" type = \"hidden\" value = \"@strUserId1_Value\" />");
                strCodeForCs.Append("\r\n" + "<input id=\"hidCurrPageIndex\" type = \"hidden\" value = \"1\" />");
                //strCodeForCs.AppendFormat("\r\n" + "<input id=\"h1idSort{0}By\" type = \"hidden\" value = \"\" />", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "<script>");
                strCodeForCs.Append("\r\n" + "   setTimeout(AddDPV_Pager(\"divPager\"), 100);");
                //strCodeForCs.Append("\r\n" + "AddDPV_Edit(\"divEdit\");");
                strCodeForCs.Append("\r\n" + "</script>");

                strCodeForCs.Append("\r\n" + "</body>");
                strCodeForCs.Append("\r\n" + "</html>");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }
        public string GenFeatureRegion(clsViewRegionEN objDGRegionENEx, clsViewInfoENEx objViewInfoENEx)
        {
            string strFuncName = "";
            string lngRegionId = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;


            if (objViewInfoENEx.arrDGRegionFldSet == null || objViewInfoENEx.arrDGRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有DataGrid区域,或者DataGrid区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }

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


                ASPDivEx objASPDivENEx_Function = clsASPDivBLEx.GetEmptyDiv();
                objASPDivENEx_Function.Class = "table table-bordered table-hover";
                objASPDivENEx_Function.Runat = "server";
                objASPDivENEx_Function.CtrlId = "divFunction";
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds;
                if (objViewInfoENEx.arrFeatureRegionFlds == null)
                {
                    string strMsg = string.Format("界面功能区为空，请添加界面功能！界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

                }
                IEnumerable<clsViewRegionENEx> arrViewRegion = objViewInfoENEx.arrViewRegion
                    .Where(x => x.RegionTypeId == enumRegionType.FeatureRegion_0008);
                if (arrViewRegion.Count() == 0)
                {
                    string strMsg = string.Format("界面功能区为空，请添加界面功能！界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

                }
                lngRegionId = arrViewRegion.First().RegionId;
                IEnumerable<ASPControlEx> arrControls = clsFeatureRegionFldsBLEx.GetControlLst4Regoin(lngRegionId, objViewInfoENEx, "");

                List<ASPControlGroupEx> arrControlGroupLst = arrControls
                    .OrderBy(x => x.OrderNum)
                    .Select(clsASPControlGroupBLEx.GetControlGroup)
                    .OrderBy(x => x.GroupName).ToList();


                //IEnumerable<ASPButtonEx> arrButtonLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.ViewImplId == enumViewImplementation.FunctionRegion_0001).Select(clsASPButtonBLEx.GetButton4MvcAjax);
                IEnumerable<ASPControlGroupEx> arrControlGroupLst_New = clsASPControlGroupBLEx.MergeControlGroup(arrControlGroupLst);


                //添加层div
                ASPUlEx objASPUlENEx = clsASPUlBLEx.GetEmptyUl();
                objASPUlENEx.Class = "nav";
                objASPDivENEx_Function.arrSubAspControlLst2.Add(objASPUlENEx);

                ASPLiEx objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                objASPLiENEx.Class = "nav-item";
                objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                //列表标题
                ASPLabelEx objASPNETLabelENEx = clsASPLabelBLEx.GetDataListTitle(objViewInfoENEx, true);
                objASPLiENEx.arrSubAspControlLst2.Add(objASPNETLabelENEx);

                //Action<ASPButtonEx> AddToTd = (x) =>
                //{
                //    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                //    ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
                //    objASPNETColENEx.arrSubAspControlLst2.Add(x);
                //    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                //};
                //< li class="nav-item">

                Action<ASPButtonEx> AddToLi = (x) =>
                {
                    objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                    objASPLiENEx.Class = "nav-item ml-3";
                    ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
                    objASPLiENEx.arrSubAspControlLst2.Add(x);
                    objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                };

                foreach (ASPControlGroupEx objInFor in arrControlGroupLst_New)
                {
                    objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                    objASPLiENEx.Class = "nav-item ml-3";
                    //ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
                    objASPLiENEx.arrSubAspControlLst2.Add(objInFor);
                    objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                }

                objASPDivENEx_Function.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                //生成GridView的代码;

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

            //intZIndex += 1;
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
                    ASPDivEx objDiv = new ASPDivEx();
                    objDiv.Style = "position: relative; width: 648px; height: 37px; left: 0px; top: 0px;";
                    ASPLabelEx objLabel = new ASPLabelEx();
                    objLabel.CtrlId = "lblViewTitle";
                    objLabel.Class = "h5";
                    //objLabel.Is4PureHtml = true;
                    objLabel.Text = strTitle;
                    objDiv.arrSubAspControlLst2.Add(objLabel);
                    ASPLabelEx objLabel_ErrMsg = clsASPLabelBLEx.GetLabel4ErrMsg("lblMsg_List", true);
                    objDiv.arrSubAspControlLst2.Add(objLabel_ErrMsg);
                    objDiv.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                    //strCodeForCs.AppendFormat("\r\n" + "<div style = \"position: relative; width: 648px; height: 37px; left: 0px; top: 0px;\">");
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:Label ID = \"lblViewTitle\" runat = \"server\" CssClass = \"h5\" >{0}",
                    //  strTitle);
                    //strCodeForCs.AppendFormat("\r\n" + "</asp:Label>");
                    ////如果有查询区域
                    //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "<asp:Label ID = \"lblMsg_List\" runat = \"server\" CssClass = \"text-warning\"  Style = \"z-index: 105;");
                    //    strCodeForCs.AppendFormat("\r\n" + "left: 54px; position: relative; top: 4px\" Width = \"347px\"></asp:Label>");
                    //}
                    //strCodeForCs.AppendFormat("\r\n" + "	</div>");
                    break;
            }

            //intZIndex += 1;
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

      
            //intCurrTop -= 30;//因为这是在层(div)中
            //int intFieldNum = 0;
            //objBiDimDistribue4Qry.StartX = (int)intCurrLeft;
            //objBiDimDistribue4Qry.StartY = (int)intCurrTop;
            ///生成专门用于查询的界面控件的代码;
            ///
            //bool bolIsTrEnd = true;
            IEnumerable<clsViewRegionENEx> arrViewRegion = objViewInfoENEx.arrViewRegion.Where(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
            if (arrViewRegion.Count() == 0)
            {
                string strMsg = string.Format("界面功能区为空，请添加界面功能！界面:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);

            }
            clsViewRegionENEx objViewRegion_Qry = arrViewRegion.First();
            string lngRegionId = objViewRegion_Qry.RegionId;



            IEnumerable<ASPControlGroupEx> arrControlGroups = clsQryRegionFldsBLEx.GetControlGroup(lngRegionId, objViewInfoENEx, "Item1");
            //foreach(ASPControlGroupEx objInFor in arrControlGroups)
            //{

            //}
            strCodeForCs.AppendFormat("\r\n" + "<div id = \"divQuery\" class = \"div_query\" style=\"width:{2}px;\"> ",
                objViewInfoENEx.TabName, 
                intDivHeight, 
                objViewRegion_Qry.Width);


            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4QueryRegion(arrControlGroups, objViewInfoENEx.objViewRegion_Query.ColNum);
            objTable.Width = objViewRegion_Qry.Width;
            objTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            strCodeForCs.Append("\r\n" + "</div>");

            //intCurrTop += 40;
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
                //objCheckStyle.Style_Zindex = intZIndex + 1;
                //objCheckStyle.Style_Left = (int)intCurrLeft;
                //objCheckStyle.Style_Top = (int)intCurrTop;

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

                //intZIndex += 1;

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
            //objLabelStyle.Style_Zindex = intZIndex + 1;
            //objLabelStyle.Style_Left = (int)intCurrLeft;
            //objLabelStyle.Style_Top = (int)intCurrTop;
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

            //intZIndex += 1;

            //objGenCtlStyle.Style_Zindex = intZIndex + 1;
            //objGenCtlStyle.Style_Left = (int)intCurrLeft + objLabelStyle.Width + 5;
            ////objGenCtlStyle.Style_Left = (int)intCurrLeft + 5;
            //objGenCtlStyle.Style_Top = (int)intCurrTop;
            ///生成右边控件的代码;
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" style = \"z-index: {2}; \" ",
              strCtlTypeName, strCtlId, objGenCtlStyle.Style_Zindex, objGenCtlStyle.Width, objGenCtlStyle.Height);

            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"TextBox_Defa\">",
              objGenCtlStyle.Runat);
            strCodeForCs.AppendFormat("\r\n" + "</asp:{0}>",
              strCtlTypeName);
            strCodeForCs.Append("\r\n" + "</td>");

            //intZIndex += 1;
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
                //objButtonStyle.Style_Zindex = intZIndex + 1;
                //objButtonStyle.Style_Left = (int)intCurrLeft;
                //objButtonStyle.Style_Top = (int)intCurrTop;

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

                //intZIndex += 1;

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
        public string Gen_WApi_Cs4Ts_DefDiv4EditRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n" + " <div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">", 
                objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " <div class=\"modal-dialog\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-content\" style=\"width: 800px;\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-header\">");
            strCodeForCs.AppendFormat("\r\n" + " <h4 class=\"modal-title\" id=\"lblDialogTitle_{0}\">模态框（Modal）标题</h4>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\">&times;</button>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-body\">");
            
            //ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.GetObj4EditRegion(objViewInfoENEx.objMainPrjTab.TabName);

            Func<clsEditRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4PureHtml = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, true);
            
            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst
                = objViewInfoENEx.arrEditRegionFldSet4InUse
                .Where(x => x.IsLogUpdDateOrUpdUser() == false)
                .Select(GetControlGroup_Asp4PureHtml);
    
            //封装Td
            //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Select(clsASPControlGroupBLEx.PackageTr4Wuc);
            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4EditRegion(arrASPControlGroupObjLst, objViewInfoENEx.objViewRegion_Edit.ColNum);

            //foreach (ASPControlEx objInFor in arrASPControlGroupObjLst)
            //{
            //    objTable.arrSubAspControlLst2.Add(objInFor);
            //}
            objTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
            //foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            //{
            //    ///如果该字段不是标识递增型就生成控件,否则就不生成;
            //    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
            //      && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            //    {
            //        continue;
            //    }
            //    strCodeForCs.AppendFormat("\r\n" + "<tr>");
            //    //strCodeForCs.AppendFormat("\r\n" + "<td>");
            //    ///插入验证控件代码;
            //    switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType)
            //    {
            //        case "bool":
            //            strCodeForCs.AppendFormat("\r\n" + "<td colspan='2'>");
            //            strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox id = \"chk{0}\" runat = \"server\" Text = \"{1}\" CssClass = \"Check_Defa\"></asp:CheckBox>",
            //              objEditRegionFldsEx.FldName,
            //              objEditRegionFldsEx.LabelCaption);
            //            strCodeForCs.AppendFormat("\r\n" + "</td>");
            //            //strCodeForCs.AppendFormat("\r\n" + "<td>");
            //            //strCodeForCs.AppendFormat("\r\n" + "</td>");
            //            break;
            //        case "int":
            //        case "short":
            //        case "long":
            //        case "DateTime":
            //        case "double":
            //        case "float":
            //            strCodeForCs.AppendFormat("\r\n" + "<td class = \"NameTD\">");
            //            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\" CssClass = \"NameControl\">{1}</asp:Label>",
            //              "lbl" + objEditRegionFldsEx.FldName,
            //              objEditRegionFldsEx.LabelCaption);
            //            strCodeForCs.AppendFormat("\r\n" + "</td>");
            //            strCodeForCs.AppendFormat("\r\n" + "<td class = \"ValueTD\">");
            //            strCodeForCs.AppendFormat("\r\n" + "<asp:TextBox id = \"txt{0}\" runat = \"server\" CssClass = \"ValueControl\"></asp:TextBox>",
            //              objEditRegionFldsEx.FldName, 
            //              objEditRegionFldsEx.LabelCaption);
            //            strCodeForCs.AppendFormat("\r\n" + "</td>");
            //            break;
            //        default:
            //            strCodeForCs.AppendFormat("\r\n" + "<td class = \"NameTD\">");
            //            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\" CssClass = \"NameControl\">{1}</asp:Label>",
            //              "lbl" + objEditRegionFldsEx.FldName,
            //              objEditRegionFldsEx.LabelCaption);
            //            strCodeForCs.AppendFormat("\r\n" + "</td>");
            //            strCodeForCs.AppendFormat("\r\n" + "<td class = \"ValueTD\">");
            //            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" runat = \"server\" CssClass = \"ValueControl\"></asp:{0}>",
            //              objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName,
            //                objEditRegionFldsEx.CtrlId, 
            //              objEditRegionFldsEx.LabelCaption);
            //            strCodeForCs.AppendFormat("\r\n" + "</td>");
            //            break;
            //    }
            //    //                strCodeForCs.AppendFormat("\r\n" + "</td>");
            //    strCodeForCs.AppendFormat("\r\n" + "<td></td>");
            //    strCodeForCs.AppendFormat("\r\n" + "</tr>");
            //    //intZIndex += 1;
            //    //intCurrTop += 25;

            //}         
            //strCodeForCs.Append("\r\n" + " </table>");

            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-footer\">");
            strCodeForCs.AppendFormat("\r\n" + " <button  id=\"btnCancel_{0}\" type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">关闭</button>", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + " <button  id=\"btnSubmit_{0}\" type=\"button\" class=\"btn btn-primary\" onclick=\"Submit_{0}()\">添加</button>", objViewInfoENEx.TabName_In);
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
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_ViewScript_JS4Html);
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
            this.ClsName = string.Format("{0}", objViewInfoENEx.ViewName);
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
        public string Gen_WebView_WA_Code4FeatureRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            strCodeForCs.Append("\r\n" + "@*-- 功能区 --*@");
            strCodeForCs.Append("\r\n" + GenFeatureRegion(objViewInfoENEx.objViewRegion_List, objViewInfoENEx));

            return strCodeForCs.ToString();
        }
        public string Gen_WebView_WA_Code4ListRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            strCodeForCs.Append("\r\n" + "@*-- 列表层 --*@");
            strCodeForCs.Append("\r\n" + "<div id = \"divList\" class = \"div_List\" >");

            strCodeForCs.Append("\r\n" + "<div id = \"divDataLst\" class = \"div_List\" >");

            strCodeForCs.Append("\r\n" + "</div>");
            strCodeForCs.Append("\r\n" + "<div id = \"divPager\" class = \"pager\" value=\"1\" >");
            strCodeForCs.Append("\r\n" + "@Html.Partial(\"~/Pages/PubWebClass/pager.cshtml\")");
            strCodeForCs.Append("\r\n" + "</div>");
            strCodeForCs.Append("\r\n" + "</div>");
            return strCodeForCs.ToString();
        }
        public string Gen_WebView_WA_Code4EditRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            strCodeForCs.Append("\r\n" + "@*-- 编辑层 --*@");
            strCodeForCs.Append("\r\n" + Gen_WApi_Cs4Ts_DefDiv4EditRegion());

            return strCodeForCs.ToString();
        }
        public string Gen_WebView_WA_Code4QueryRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            strCodeForCs.Append("\r\n" + "@*-- 查询层 --*@");

            strCodeForCs.Append("\r\n" + GenQryRegionCode4Table());
            return strCodeForCs.ToString();
        }
    }
}
