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
    partial class AppController4JAVABase : clsGeneCodeBase4Tab
    {       

        public string A_GeneFuncCode_Java_btnClick(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
              string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
               
                switch (strFuncName)
                {                  

                    case "Gen_Controller_Java_btnClickGetFirstJSONObj":
                        return Gen_Controller_Java_btnClickGetFirstJSONObj(objvFunction4GeneCodeEN);

                    case "Gen_Controller_Java_btnClickGetJSONObjByKey":
                        return Gen_Controller_Java_btnClickGetJSONObjByKey(objvFunction4GeneCodeEN);

                    case "Gen_Controller_Java_btnClickDelRecord":
                        return Gen_Controller_Java_btnClickDelRecord(objvFunction4GeneCodeEN);
                    case "Gen_Controller_Java_btnClickDelRecordsByJSON":
                        return Gen_Controller_Java_btnClickDelRecordsByJSON(objvFunction4GeneCodeEN);

                    case "Gen_Controller_Java_btnClickAddNewRecord":
                        return Gen_Controller_Java_btnClickAddNewRecord();

                    case "Gen_Controller_Java_btnClickAddNewRecord4GetMaxStrId":
                        return Gen_Controller_Java_btnClickAddNewRecord4GetMaxStrId();
                    case "Gen_Controller_Java_btnClickGetMaxStrId":
                        return Gen_Controller_Java_btnClickGetMaxStrId(objvFunction4GeneCodeEN);
                    case "Gen_Controller_Java_btnClickGetMaxStrIdByPrefix":
                        return Gen_Controller_Java_btnClickGetMaxStrIdByPrefix(objvFunction4GeneCodeEN);

                    case "Gen_Controller_Java_btnClickUpdateRecord":
                        return Gen_Controller_Java_btnClickUpdateRecord(objvFunction4GeneCodeEN);
                        
                    case "Gen_Controller_Java_btnClickIsExistRecord":
                        return Gen_Controller_Java_btnClickIsExistRecord(objvFunction4GeneCodeEN);

                    case "Gen_Controller_Java_btnClickGetRecCountByCond":
                        return Gen_Controller_Java_btnClickGetRecCountByCond(objvFunction4GeneCodeEN);

                    case "Gen_Controller_Java_btnClickGetJSONObjLst":
                        return Gen_Controller_Java_btnClickGetJSONObjLst(objvFunction4GeneCodeEN);

                    case "Gen_Controller_Java_btnClickGetTopJSONObjLst":
                        return Gen_Controller_Java_btnClickGetTopJSONObjLst(objvFunction4GeneCodeEN);

                    case "Gen_Controller_Java_btnClickGetJSONObjLstByPager":
                        return Gen_Controller_Java_btnClickGetJSONObjLstByPager(objvFunction4GeneCodeEN);

                    case "Gen_Controller_Java_btnClickGetJSONObjLstByRange":
                        return Gen_Controller_Java_btnClickGetJSONObjLstByRange(objvFunction4GeneCodeEN);

                    default:
                        string strMsg = string.Format("功能名:{1}在Switch没有处理,请检查({0})",
                             clsStackTrace.GetCurrClassFunction(), strFuncName);
                        throw new Exception(strMsg);
                        //            return "///该1函数不存在:" + strFuncName;
                }
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

        public string Gen_Controller_Java_btnClickGetJSONObjByKey(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字获取相应的记录的对象");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public void btnGetJSONObjByKey_Click(View myView) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetObjBy{1}Ex iobj{0}GetObjBy{1} = new icls{0}GetObjBy{1}Ex(ac{0}_UnitTest.this);",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetObjBy{1}.main();",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "class icls{0}GetObjBy{1}Ex extends cls{0}_Controller.icls{0}GetObjBy{1}",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public icls{0}GetObjBy{1}Ex(Object pvcParent)",
    objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            //GC_GetInputValue4Para(objvFunction4GeneCodeEN, strBuilder);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            strBuilder.AppendFormat("\r\n" + "String strKeyId = txt{0}.getText().toString();",
                    GetNewParaCtrlName(strFuncId4GC, "strKeyId"));
     
            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "{1} {0} = strKeyId;",
                  objKeyField.PrivFuncName,
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);

            }
            else
            {
                switch (objDataTypeAbbrEN.DataTypeId)
                {
                    case enumDataTypeAbbr.float_07:
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = Float.valueOf(strKeyId);",
                            objDataTypeAbbrEN.JavaType,
                            objKeyField.PrivFuncName);
                        break;
                    case enumDataTypeAbbr.int_09:
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = Integer.valueOf(strKeyId);",
                            objDataTypeAbbrEN.JavaType,
                            objKeyField.PrivFuncName);
                        break;
                    case enumDataTypeAbbr.money_11:
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = Double.valueOf(strKeyId);",
                            objDataTypeAbbrEN.JavaType,
                            objKeyField.PrivFuncName);
                        break;
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:

                        strBuilder.AppendFormat("\r\n" + "{0} {1} = Long.valueOf(strKeyId);",
                            objDataTypeAbbrEN.JavaType,
                            objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("数据类型：[{0}({1})](Java:{2})在函数中没有处理!({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.JavaType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }     
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetObjBy{1}({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjByKey,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObject, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = (cls{0}EN)returnObject;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "String strKeyId = txt{0}.getText().toString();",
             GetNewParaCtrlName(strFuncId4GC, "strKeyId"));

            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据关键字:[%s]获取对象：%s!\", strKeyId, obj{0}EN.get{1}());",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_btnClickGetFirstJSONObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN
            //objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的第一条记录的对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "public void btnGetFirstJSONObj_Click(View myView) {");

            strBuilder.AppendFormat("\r\n" + "icls{0}GetFirstJSONObjEx iobj{0}GetFirstJSONObj = new icls{0}GetFirstJSONObjEx(ac{0}_UnitTest.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetFirstJSONObj.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}GetFirstJSONObjEx extends cls{0}_Controller.icls{0}GetFirstJSONObj",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public icls{0}GetFirstJSONObjEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para(strFuncId4GC, strBuilder);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetFirstJSONObj(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetFirstJSONObj,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObject, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = (cls{0}EN)returnObject;",
                objPrjTabENEx.TabName);
            
            strBuilder.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "strWhereCond"));
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:[%s] 获取第一个记录对象：%s!\", strWhereCond, obj{0}EN.get{1}());",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");


            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }     

        public string Gen_Controller_Java_btnClickGetJSONObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "public void btnGetJSONObjLst_Click(View myView) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetJSONObjLstEx iobj{0}GetJSONObjLst = new icls{0}GetJSONObjLstEx(ac{0}_UnitTest.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}GetJSONObjLstEx extends cls{0}_Controller.icls{0}GetJSONObjLst",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public icls{0}GetJSONObjLstEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
//            strBuilder.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
             //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN.FuncId4Code, strBuilder);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLst,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
                objPrjTabENEx.TabName);
            
            strBuilder.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "strWhereCond"));
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:[%s]共获取对象列表数：%s!\", strWhereCond, arr{0}ObjLst.size());",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

    //    public string Gen_Controller_Java_GetJSONObjLst4DdlBind(string strTabName, string strValueFld, string strTextFld)
    //    {
    //        StringBuilder strBuilder = new StringBuilder();
    //        strBuilder.Append("\r\n /// <summary>");
    //        strBuilder.Append("\r\n /// 根据条件获取相应的对象列表");
    //        strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
    //        strBuilder.Append("\r\n /// </summary>");
    //        strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
    //        strBuilder.Append("\r\n /// <returns></returns>");

    //        strBuilder.AppendFormat("\r\n" + "public void btnGetJSONObjLst_Click(View myView) ",
    //            objPrjTabENEx.TabName);
    //        strBuilder.Append("\r\n" + "{");
    //        strBuilder.AppendFormat("\r\n" + "icls{0}GetJSONObjLstEx iobj{0}GetJSONObjLst = new icls{0}GetJSONObjLstEx({1}.this);",
    //            objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
    //        strBuilder.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
    //            objPrjTabENEx.TabName);
    //        strBuilder.Append("\r\n" + "}");
    //        strBuilder.AppendFormat("\r\n" + "class icls{0}GetJSONObjLstEx extends cls{0}_Controller.icls{0}GetJSONObjLst",
    //            objPrjTabENEx.TabName);
    //        strBuilder.Append("\r\n" + "{");

    //        strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
    //            objPrjTabENEx.TabName);

    //        strBuilder.AppendFormat("\r\n" + "public icls{0}GetJSONObjLstEx(Object pvcParent)",
    //objPrjTabENEx.TabName);
    //        strBuilder.Append("\r\n" + "{");
    //        strBuilder.Append("\r\n" + "super(pvcParent);");
    //        strBuilder.Append("\r\n" + "}");
    //        strBuilder.Append("\r\n" + "@Override");

    //        strBuilder.Append("\r\n" + "public void main()");
    //        strBuilder.Append("\r\n" + "{");

    //        strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
    //            objPrjTabENEx.TabName);
    //        strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
    //            objPrjTabENEx.TabName);
    //        strBuilder.Append("\r\n" + "String strWhereCond =\" 1=1 \";");

    //        strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLst(strWhereCond);",
    //            objPrjTabENEx.TabName);
    //        strBuilder.Append("\r\n" + "}");

    //        strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLst,返回的事件函数,这是正确返回,不需要处理执行错误。");
    //        strBuilder.Append("\r\n" + "@Override");
    //        strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
    //            clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
    //            enumDict4GC_DictKey2.conCorrectFinished));

    //        strBuilder.Append("\r\n" + "{");
    //        strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
    //            objPrjTabENEx.TabName);
    //        strBuilder.AppendFormat("\r\n" + "cls{0}EN objFirstObj = new cls{0}EN();", objPrjTabENEx.TabName);
    //        strBuilder.AppendFormat("\r\n" + "objFirstObj.set{0}(\"0\");",
    //           strValueFld, strTextFld);
    //        strBuilder.AppendFormat("\r\n" + "objFirstObj.set{0}(\"请选择...\");", strTextFld);
    //        strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst.add(0, objFirstObj);",
    //            strTabName);
    //        strBuilder.AppendFormat("\r\n" + "{1}.arr{0}ObjLstCache = arr{0}ObjLst;",
    //            strTabName, objPrjTabENEx.ClsName);
    //        strBuilder.AppendFormat("\r\n" + "mspnObject.setPrompt(\"请选择您的{0}: \");", objPrjTabENEx.TabCnName);

    //        strBuilder.AppendFormat("\r\n" + "if (mobjDdlAdapter{0} == null)", strTabName);
    //        strBuilder.Append("\r\n" + "{");
    //        strBuilder.AppendFormat("\r\n" + "mobjDdlAdapter{0} = new ddlAdapter{0}(macPage, arr{0}ObjLst);",
    //            strTabName);
    //        strBuilder.Append("\r\n" + "}");
    //        //            userStateAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
    //        strBuilder.AppendFormat("\r\n" + "mspnObject.setAdapter(mobjDdlAdapter{0});",
    //            strTabName);
    //        //strBuilder.Append("\r\n" + "SendMessage(\"没有使用缓存!\");");
    //        strBuilder.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"BindDdl_{0}, 没有使用缓存!\", 1);",
    //            strTabName);
    //        //strBuilder.AppendFormat("\r\n" + "String strWhereCond = \" 1 = 1 \"; "); 
    //        //strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:[%s]共获取对象列表数：%s!\", strWhereCond, arr{0}ObjLst.size());",
    //        //    objPrjTabENEx.TabName);
    //        //strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
    //        //strBuilder.Append("\r\n" + "//显示信息框");
    //        //strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

    //        strBuilder.Append("\r\n" + "}");
    //        strBuilder.Append("\r\n" + "}");

    //        return strBuilder.ToString();
    //    }

        public string Gen_Controller_Java_btnClickGetTopJSONObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的顶部对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "public void btnGetTopJSONObjLst_Click(View myView) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetTopJSONObjLstEx iobj{0}GetTopJSONObjLst = new icls{0}GetTopJSONObjLstEx(ac{0}_UnitTest.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetTopJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}GetTopJSONObjLstEx extends cls{0}_Controller.icls{0}GetTopJSONObjLst",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public icls{0}GetTopJSONObjLstEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "Integer intTopSize = 2;");
            //strBuilder.Append("\r\n" + "String strWhereCond =\" 1=1 \";");            
             //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN.FuncId4Code, strBuilder);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetTopJSONObjLst(intTopSize, strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetTopRecordObjLst,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
                objPrjTabENEx.TabName);
            
            strBuilder.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "strWhereCond"));
            strBuilder.Append("\r\n" + "String strTopSize = txtintTopSize.getText().toString();");
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:[%s],顶部数:[%s]共获取顶部对象列表数：%s!\", strWhereCond, strTopSize, arr{0}ObjLst.size());",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");
           
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_btnClickGetJSONObjLstByPager(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的分页对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "public void btnGetJSONObjLstByPager_Click(View myView) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetJSONObjLstByPagerEx iobj{0}GetJSONObjLstByPager = new icls{0}GetJSONObjLstByPagerEx(ac{0}_UnitTest.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetJSONObjLstByPager.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}GetJSONObjLstByPagerEx extends cls{0}_Controller.icls{0}GetJSONObjLstByPager",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public icls{0}GetJSONObjLstByPagerEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "Integer intPageIndex = 2;");
            //strBuilder.Append("\r\n" + "Integer intPageSize = 2;");
            //strBuilder.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
            //strBuilder.Append("\r\n" + "String strOrderBy =\"\";");

             //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN.FuncId4Code, strBuilder);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLstByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLstByPager,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "strWhereCond"));
            strBuilder.AppendFormat("\r\n" + "String strPageIndex = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "intPageIndex"));
            strBuilder.AppendFormat("\r\n" + "String strPageSize = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "intPageSize"));

            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:[%s],每页记录数:[%s],第[%s]页,共获取分页对象列表数：%s!\", strWhereCond, strPageSize, strPageIndex, arr{0}ObjLst.size());",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_btnClickGetJSONObjLstByRange(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取范围内相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "public void btnGetJSONObjLstByRange_Click(View myView) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetJSONObjLstByRangeEx iobj{0}GetJSONObjLstByRange = new icls{0}GetJSONObjLstByRangeEx(ac{0}_UnitTest.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetJSONObjLstByRange.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}GetJSONObjLstByRangeEx extends cls{0}_Controller.icls{0}GetJSONObjLstByRange",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public icls{0}GetJSONObjLstByRangeEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            //int intMinNum = Long.valueOf(txtintMaxNum.getText().toString());
            //int intMinNum = Long.valueOf(txtintMinNum.getText().toString());

            //strBuilder.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
            //strBuilder.Append("\r\n" + "String strOrderBy =\"\";");

             //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN.FuncId4Code, strBuilder);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLstByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLstByRange,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByRange,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "strWhereCond"));
            strBuilder.AppendFormat("\r\n" + "String strOrderBy = txt{0}.getText().toString();",
        GetNewParaCtrlName(strFuncId4GC, "strOrderBy"));

            strBuilder.AppendFormat("\r\n" + "String strMinNum = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "intMinNum"));
            strBuilder.AppendFormat("\r\n" + "String strMaxNum = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "intMaxNum"));

            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:[%s],最小记录号:[%s],最大记录号:[%s],共获取分页对象列表数：%s!\", strWhereCond, strMinNum, strMaxNum, arr{0}ObjLst.size());",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

      
        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Java_btnClickIsExistRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查相应关键字的记录是否存在");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strBuilder.Append("\r\n /// <returns>返回是否存在</returns>");

            strBuilder.Append("\r\n" + "public void btnIsExistRecord_Click(View myView) {");


            strBuilder.AppendFormat("\r\n" + "icls{0}_IsExistRecordEx iobj{0}_IsExistRecord = new icls{0}_IsExistRecordEx(ac{0}_UnitTest.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_IsExistRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "class icls{0}_IsExistRecordEx extends cls{0}_Controller.icls{0}_IsExistRecord",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public icls{0}_IsExistRecordEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "String strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
             //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN.FuncId4Code, strBuilder);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "switch (strClassName) {");
            strBuilder.AppendFormat("\r\n" + "case \"cls{0}WS4Controller\":",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "if (returnBool == false)");
            strBuilder.Append("\r\n" + "{");
     
            strBuilder.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "strWhereCond"));

            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:[%s] 不存在!\", strWhereCond);",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "strWhereCond"));
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:[%s] 存在!\", strWhereCond);",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"cls{0}WS4Controller2\":",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "break;");

            strBuilder.Append("\r\n" + "default: ");

            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Java_btnClickGetRecCountByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查相应关键字的记录是否存在");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strBuilder.Append("\r\n /// <returns>返回是否存在</returns>");

            strBuilder.Append("\r\n" + "public void btnGetRecCountByCond_Click(View myView) {");


            strBuilder.AppendFormat("\r\n" + "icls{0}GetRecCountByCondEx iobj{0}GetRecCountByCond = new icls{0}GetRecCountByCondEx(ac{0}_UnitTest.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetRecCountByCond.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "class icls{0}GetRecCountByCondEx extends cls{0}_Controller.icls{0}GetRecCountByCond",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public icls{0}GetRecCountByCondEx(Object pvcParent)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "String strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
             //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN.FuncId4Code, strBuilder);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetRecCountByCond(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetRecCountByCond,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(int returnInt, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
                GetNewParaCtrlName(strFuncId4GC, "strWhereCond"));

            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:[%s]的记录数:[%s]!\", strWhereCond, returnInt);",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((ac{0}_UnitTest)vcParent, strInfo);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

   

        public string Gen_Controller_Java_btnClickDelRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 删除记录");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "public void btnDelRecord_Click(View myView) {");

            strBuilder.AppendFormat("\r\n" + "icls{0}_DelRecordEx iobj{0}_DelRecord = new icls{0}_DelRecordEx(ac{0}_UnitTest.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_DelRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}_DelRecordEx extends cls{0}_Controller.icls{0}_DelRecord",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public icls{0}_DelRecordEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "String strKeyId = txt{0}.getText().toString();",
                  GetNewParaCtrlName(strFuncId4GC, "strKeyId"));
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "{1} {0} = strKeyId;",
                  objKeyField.PrivFuncName,
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);

            }
            else
            {
                switch (objDataTypeAbbrEN.DataTypeId)
                {
                    case enumDataTypeAbbr.float_07:
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = Float.valueOf(strKeyId);",
                            objDataTypeAbbrEN.JavaType,
                            objKeyField.PrivFuncName);
                        break;
                    case enumDataTypeAbbr.int_09:
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = Integer.valueOf(strKeyId);",
                            objDataTypeAbbrEN.JavaType,
                            objKeyField.PrivFuncName);
                        break;
                    case enumDataTypeAbbr.money_11:
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = Double.valueOf(strKeyId);",
                            objDataTypeAbbrEN.JavaType,
                            objKeyField.PrivFuncName);
                        break;
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:

                        strBuilder.AppendFormat("\r\n" + "{0} {1} = Long.valueOf(strKeyId);",
                            objDataTypeAbbrEN.JavaType,
                            objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("数据类型：[{0}({1})](Java:{2})在函数中没有处理!({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.JavaType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.DelRecord({1});",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName);

            strBuilder.Append("\r\n" + "}");



            strBuilder.Append("\r\n" + "//通过WebService执行DelRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(int returnInt, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conCorrectFinished));
   
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnInt > 0)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "String strInfo = String.format(\"删除记录成功, 共删除了%s条记录!\", returnInt);");
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "String strInfo = String.format(\"删除记录不成功!\");");
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }
        public string Gen_Controller_Java_btnClickDelRecordsByJSON(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 删除记录");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "public void btnDelRecordsByJSON_Click(View myView) {");

            strBuilder.AppendFormat("\r\n" + "icls{0}_DelRecordsByJSONEx iobj{0}_DelRecordsByJSON = new icls{0}_DelRecordsByJSONEx(ac{0}_UnitTest.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_DelRecordsByJSON.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}_DelRecordsByJSONEx extends cls{0}_Controller.icls{0}_DelRecordsByJSON",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public icls{0}_DelRecordsByJSONEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "String strKeyIdLst = txt{0}.getText().toString();",
                  GetNewParaCtrlName(strFuncId4GC, "strKeyIdLst"));
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
                   

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.DelRecordsByJSON(strKeyIdLst);",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName);

            strBuilder.Append("\r\n" + "}");



            strBuilder.Append("\r\n" + "//通过WebService执行DelRecordsByJSON,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(int returnInt, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecordsByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnInt > 0)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "String strInfo = String.format(\"删除记录成功,共删除%s条记录!\", returnInt);");
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "String strInfo = String.format(\"删除记录不成功!\");");
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }


        //public string Gen_Controller_Java_btnClickByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        //{
        //    string strMsg = "";
        //    StringBuilder strBuilder = new StringBuilder();
        //    strBuilder.Append("\r\n /// <summary>");
        //    strBuilder.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
        //    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
        //    strBuilder.Append("\r\n /// </summary>");
        //  //  strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
        //    strBuilder.Append("\r\n /// <returns></returns>");
        //    strBuilder.AppendFormat("\r\n" + "public void btn{0}_Click(View myView) ",
        //        objWebSrvFunctionsENEx.FunctionName);
        //    strBuilder.Append("\r\n" + "{");

        //    strBuilder.AppendFormat("\r\n" + "icls{0}_{1}Ex iobj{0}_{1} = new icls{0}_{1}Ex(ac{0}4SD_UnitTest.this);",
        //        objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
        //    strBuilder.AppendFormat("\r\n" + "iobj{0}_{1}.main();",
        //        objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
        //    strBuilder.Append("\r\n" + "}");
        //    strBuilder.AppendFormat("\r\n" + "class icls{0}_{1}Ex extends cls{0}4SD_Controller.icls{0}_{1}",
        //        objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
        //    strBuilder.Append("\r\n" + "{");

        //    //strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
        //    //    objWebSrvClassENEx.TabName);

        //    strBuilder.AppendFormat("\r\n" + "public icls{0}_{1}Ex(Object pvcParent)",
        //        objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
        //    strBuilder.Append("\r\n" + "{");
        //    strBuilder.Append("\r\n" + "super(pvcParent);");
        //    strBuilder.Append("\r\n" + "}");
        //    strBuilder.Append("\r\n" + "@Override");

        //    strBuilder.Append("\r\n" + "public void main()");
        //    strBuilder.Append("\r\n" + "{");
        //    strBuilder.AppendFormat("\r\n" + "{0}WS4SDController obj{0}WS4SDController = new {0}WS4SDController();",
        //        objWebSrvClassENEx.ClsName);
        //    strBuilder.AppendFormat("\r\n" + "obj{0}WS4SDController.objTableObjWS4ControllerDelegate = this;",
        //        objWebSrvClassENEx.ClsName);

        //    StringBuilder sbParaList = new StringBuilder();
        //    StringBuilder sbParaVarList = new StringBuilder();

        //    foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
        //    {
        //        clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
        //        clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
        //        if (objDataTypeAbbrEN == null)
        //        {
        //            objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
        //            if (objSelfDefDataTypeEN_Para == null)
        //            {
        //                strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
        //                    objWebSrvFuncParaEN.ParameterType);
        //                throw new Exception(strMsg);
        //            }
        //        }
        //        if (objWebSrvFuncParaEN.IsByRef == true)
        //        {
        //            strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
        //               objWebSrvFuncParaEN.ParaName,
        //                 objWebSrvFuncParaEN.ParameterType);
        //            throw new Exception(strMsg);
        //        }
        //        else
        //        {
        //            if (objDataTypeAbbrEN.IsNeedQuote == true)
        //            {
        //                strBuilder.AppendFormat("\r\n" + "{0} {1} = txt{2}.getText().toString();",
        //                    objDataTypeAbbrEN.JavaType,
        //                    objWebSrvFuncParaEN.ParaName,
        //                    objWebSrvFuncParaEN._StrTag);
        //            }
        //            else
        //            {
        //                switch (objWebSrvFuncParaEN.DataTypeId)
        //                {
        //                    case enumDataTypeAbbr.float_07:
        //                        strBuilder.AppendFormat("\r\n" + "{0} {1} = Float.valueOf(txt{2}.getText().toString());",
        //                            objDataTypeAbbrEN.JavaType,
        //                            objWebSrvFuncParaEN.ParaName,
        //                            objWebSrvFuncParaEN._StrTag);
        //                        break;
        //                    case enumDataTypeAbbr.int_09:
        //                        strBuilder.AppendFormat("\r\n" + "{0} {1} = Integer.valueOf(txt{2}.getText().toString());",
        //                            objDataTypeAbbrEN.JavaType,
        //                            objWebSrvFuncParaEN.ParaName,
        //                            objWebSrvFuncParaEN._StrTag);
        //                        break;
        //                    case enumDataTypeAbbr.money_11:
        //                        strBuilder.AppendFormat("\r\n" + "{0} {1} = Double.valueOf(txt{2}.getText().toString());",
        //                            objDataTypeAbbrEN.JavaType,
        //                            objWebSrvFuncParaEN.ParaName,
        //                            objWebSrvFuncParaEN._StrTag);
        //                        break;
        //                    default:
        //                        strMsg = string.Format("数据类型：[{0}({1})](Java:{2})在函数中没有处理!({3})", 
        //                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
        //                            objDataTypeAbbrEN.JavaType, 
        //                            clsStackTrace.GetCurrClassFunction());
        //                        throw new Exception(strMsg);
        //                }
        //            }
        //            if (objSelfDefDataTypeEN_Para != null)
        //            {
        //                sbParaList.AppendFormat("{0} {1},",
        //                    objSelfDefDataTypeEN_Para.JavaType,
        //                    objWebSrvFuncParaEN.ParaName);
        //            }
        //            else
        //            {
        //                sbParaList.AppendFormat("{0} {1},",
        //                    objDataTypeAbbrEN.JavaType,
        //                    objWebSrvFuncParaEN.ParaName);
        //            }
        //            sbParaVarList.AppendFormat("{0},", objWebSrvFuncParaEN.ParaName);
        //        }
        //    }
        //    if (sbParaList.Length > 0)
        //    {
        //        sbParaList.Remove(sbParaList.Length - 1, 1);
        //        sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
        //    }
            
        //    strBuilder.AppendFormat("\r\n" + "obj{0}WS4SDController.{1}({2});",
        //            objWebSrvClassENEx.ClsName,
        //            objWebSrvFunctionsENEx.FunctionName,
        //            sbParaVarList.ToString());
            
        //    strBuilder.Append("\r\n" + "}");

        //    strBuilder.AppendFormat("\r\n" + "//通过WebService执行函数:[{0}],返回的事件函数,这是正确返回,不需要处理执行错误。",
        //        objWebSrvFunctionsENEx.FunctionName);
        //    strBuilder.Append("\r\n" + "@Override");
        //    strBuilder.AppendFormat("\r\n" + "public void {0}( String returnString, String strClassName, String strFunctionName)",
        //        clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
        //        enumDict4GC_DictKey2.conCorrectFinished));

        //    strBuilder.Append("\r\n" + "{");
           

        //    strBuilder.Append("\r\n" + "String strInfo = String.format(\"返回值为：[%s]!\", returnString);");
        //    strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
        //    strBuilder.Append("\r\n" + "//显示信息框");
        //  //  strBuilder.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
        //    strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, strInfo);",
        //        objWebSrvClassENEx.ClsName);
        //    strBuilder.Append("\r\n" + "}");
         
        //    strBuilder.Append("\r\n" + "}");



        //    return strBuilder.ToString();
        //}

        //public string Gen_Controller_Java_btnClickByCommonFunction(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        //{
        //    string strMsg = "";
        //    StringBuilder strBuilder = new StringBuilder();
        //    strBuilder.Append("\r\n /// <summary>");
        //    strBuilder.AppendFormat("\r\n /// {0}", objvFunction4GeneCodeEN.FuncName4Code);
        //    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
        //    strBuilder.Append("\r\n /// </summary>");
        //    //  strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
        //    strBuilder.Append("\r\n /// <returns></returns>");
        //    strBuilder.AppendFormat("\r\n" + "public void btn{0}_Click(View myView) ",
        //        objvFunction4GeneCodeEN.FuncName4Code);
        //    strBuilder.Append("\r\n" + "{");

        //    strBuilder.AppendFormat("\r\n" + "icls{0}_{1}Ex iobj{0}_{1} = new icls{0}_{1}Ex(ac{0}_UnitTest.this);",
        //        objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
        //    strBuilder.AppendFormat("\r\n" + "iobj{0}_{1}.main();",
        //        objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
        //    strBuilder.Append("\r\n" + "}");
        //    strBuilder.AppendFormat("\r\n" + "class icls{0}_{1}Ex extends cls{0}_Controller.icls{0}_{1}",
        //        objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
        //    strBuilder.Append("\r\n" + "{");

        //    //strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
        //    //    objWebSrvClassENEx.TabName);

        //    strBuilder.AppendFormat("\r\n" + "public icls{0}_{1}Ex(Object pvcParent)",
        //        objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
        //    strBuilder.Append("\r\n" + "{");
        //    strBuilder.Append("\r\n" + "super(pvcParent);");
        //    strBuilder.Append("\r\n" + "}");
        //    strBuilder.Append("\r\n" + "@Override");

        //    strBuilder.Append("\r\n" + "public void main()");
        //    strBuilder.Append("\r\n" + "{");
        //    strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
        //        objPrjTabENEx.TabName);
        //    strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
        //        objPrjTabENEx.TabName);

        //    StringBuilder sbParaList = new StringBuilder();
        //    StringBuilder sbParaVarList = new StringBuilder();
        //    List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
        //      clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objvFunction4GeneCodeEN.FuncId4Code);
        //    if (arrFuncPara4CodeObjLst != null)
        //    {
        //        foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
        //        {
        //            clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
        //            clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
        //            if (objDataTypeAbbrEN == null)
        //            {
        //                objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
        //                if (objSelfDefDataTypeEN_Para == null)
        //                {
        //                    strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
        //                        objFuncPara4CodeEN.ParameterType);
        //                    throw new Exception(strMsg);
        //                }
        //            }
        //            if (objFuncPara4CodeEN.IsByRef == true)
        //            {
        //                strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
        //                   objFuncPara4CodeEN.ParaName,
        //                     objFuncPara4CodeEN.ParameterType);
        //                throw new Exception(strMsg);
        //            }
        //            else
        //            {
        //                if (objDataTypeAbbrEN.IsNeedQuote == true)
        //                {
        //                    strBuilder.AppendFormat("\r\n" + "{0} {1} = txt{2}.getText().toString();",
        //                        objDataTypeAbbrEN.JavaType,
        //                        objFuncPara4CodeEN.ParaName,
        //                        objFuncPara4CodeEN._StrTag);
        //                }
        //                else
        //                {
        //                    switch (objFuncPara4CodeEN.DataTypeId)
        //                    {
        //                        case enumDataTypeAbbr.float_07:
        //                            strBuilder.AppendFormat("\r\n" + "{0} {1} = Float.valueOf(txt{2}.getText().toString());",
        //                                objDataTypeAbbrEN.JavaType,
        //                                objFuncPara4CodeEN.ParaName,
        //                                objFuncPara4CodeEN._StrTag);
        //                            break;
        //                        case enumDataTypeAbbr.int_09:
        //                            strBuilder.AppendFormat("\r\n" + "{0} {1} = Integer.valueOf(txt{2}.getText().toString());",
        //                                objDataTypeAbbrEN.JavaType,
        //                                objFuncPara4CodeEN.ParaName,
        //                                objFuncPara4CodeEN._StrTag);
        //                            break;
        //                        case enumDataTypeAbbr.money_11:
        //                            strBuilder.AppendFormat("\r\n" + "{0} {1} = Double.valueOf(txt{2}.getText().toString());",
        //                                objDataTypeAbbrEN.JavaType,
        //                                objFuncPara4CodeEN.ParaName,
        //                                objFuncPara4CodeEN._StrTag);
        //                            break;
        //                        default:
        //                            strMsg = string.Format("数据类型：[{0}({1})](Java:{2})在函数中没有处理!({3})",
        //                                objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
        //                                objDataTypeAbbrEN.JavaType,
        //                                clsStackTrace.GetCurrClassFunction());
        //                            throw new Exception(strMsg);
        //                    }
        //                }
        //                if (objSelfDefDataTypeEN_Para != null)
        //                {
        //                    sbParaList.AppendFormat("{0} {1},",
        //                        objSelfDefDataTypeEN_Para.JavaType,
        //                        objFuncPara4CodeEN.ParaName);
        //                }
        //                else
        //                {
        //                    sbParaList.AppendFormat("{0} {1},",
        //                        objDataTypeAbbrEN.JavaType,
        //                        objFuncPara4CodeEN.ParaName);
        //                }
        //                sbParaVarList.AppendFormat("{0},", objFuncPara4CodeEN.ParaName);
        //            }
        //        }
        //    }
        //    if (sbParaList.Length > 0)
        //    {
        //        sbParaList.Remove(sbParaList.Length - 1, 1);
        //        sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
        //    }

        //    strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.{1}({2});",
        //            objPrjTabENEx.TabName,
        //            objvFunction4GeneCodeEN.FuncName4Code,
        //            sbParaVarList.ToString());

        //    strBuilder.Append("\r\n" + "}");

        //    strBuilder.AppendFormat("\r\n" + "//通过WebService执行函数:[{0}],返回的事件函数,这是正确返回,不需要处理执行错误。",
        //        objvFunction4GeneCodeEN.FuncName4Code);
        //    strBuilder.Append("\r\n" + "@Override");
        //    strBuilder.AppendFormat("\r\n" + "public void {0}( String returnString, String strClassName, String strFunctionName)",
        //        clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
        //        enumDict4GC_DictKey2.conCorrectFinished));

        //    strBuilder.Append("\r\n" + "{");


        //    strBuilder.Append("\r\n" + "String strInfo = String.format(\"返回值为：[%s]!\", returnString);");
        //    strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
        //    strBuilder.Append("\r\n" + "//显示信息框");
        //    //  strBuilder.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
        //    strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, strInfo);",
        //        objPrjTabENEx.TabName);
        //    strBuilder.Append("\r\n" + "}");

        //    strBuilder.Append("\r\n" + "}");



        //    return strBuilder.ToString();
        //}

        /// <summary>
        /// 继承Runnable类必须实现的【run】函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Java_btnClickAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "public void btnAddNewRecord_Click(View myView) {");
            strBuilder.AppendFormat("\r\n" + "icls{0}_AddNewRecordEx iobj{0}_AddNewRecord = new icls{0}_AddNewRecordEx(ac{0}_UnitTest.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_AddNewRecord.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "class icls{0}_AddNewRecordEx extends cls{0}_Controller.icls{0}_AddNewRecord",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public icls{0}_AddNewRecordEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.JavaType == "boolean")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                }
                else if (objField.JavaType == "Date")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                }
                else if (objField.JavaType == "short")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}((short){2});",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(\"{2}\");",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                          objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                }
            }
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "String strWhereCond =String.format(\"{1} = '%s'\",obj{0}EN.get{1}());",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnBool == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"关键字为‘%s’的记录已经存在,不能再添加!\", obj{0}EN.get{1}());",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
               clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnBool == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "String strInfo = String.format(\"添加记录成功!\");");
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "String strInfo = String.format(\"添加记录不成功!\");");
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_btnClickAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "public void btnAddNewRecord4GetMaxStrId_Click(View myView) {");
            strBuilder.AppendFormat("\r\n" + "icls{0}_AddNewRecord4GetMaxStrIdEx iobj{0}_AddNewRecord4GetMaxStrId = new icls{0}_AddNewRecord4GetMaxStrIdEx(ac{0}_UnitTest.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_AddNewRecord4GetMaxStrId.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "class icls{0}_AddNewRecord4GetMaxStrIdEx extends cls{0}_Controller.icls{0}_AddNewRecord4GetMaxStrId",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public icls{0}_AddNewRecord4GetMaxStrIdEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetMaxStrId,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(String returnString, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(returnString);",
                    objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                }
                else
                {
                    if (objField.JavaType == "boolean")
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                    }
                    else  if (objField.JavaType == "Date")
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                    }
                    else if (objField.JavaType == "short")
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}((short){2});",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(\"{2}\");",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                              objPrjTabENEx.TabName,
                              objField.ObjFieldTabENEx.FldName,
                              objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                    }
                }
            }
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "String strWhereCond =String.format(\"{1} = '%s'\", obj{0}EN.get{1}());",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.IsExistRecord(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnBool == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.AddNewRecord(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"关键字为‘%s’的记录已经存在,不能再添加!\", obj{0}EN.get{1}());",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnBool == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "String strInfo = String.format(\"添加记录成功!\");");
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "String strInfo = String.format(\"添加记录不成功!\");");
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_btnClickGetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "public void btnGetMaxStrId_Click(View myView) {");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetMaxStrIdEx iobj{0}GetMaxStrId = new icls{0}GetMaxStrIdEx(ac{0}_UnitTest.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetMaxStrId.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "class icls{0}GetMaxStrIdEx extends cls{0}_Controller.icls{0}GetMaxStrId",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public icls{0}GetMaxStrIdEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetMaxStrId,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(String returnString, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnString == \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"获取表{0}的最大关键字为空,不成功,请检查!\");",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"获取表{0}的最大关键字为：%s!\", returnString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_btnClickGetMaxStrIdByPrefix(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "public void btnGetMaxStrIdByPrefix_Click(View myView) {");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetMaxStrIdByPrefixEx iobj{0}GetMaxStrIdByPrefix = new icls{0}GetMaxStrIdByPrefixEx(ac{0}_UnitTest.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetMaxStrIdByPrefix.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "class icls{0}GetMaxStrIdByPrefixEx extends cls{0}_Controller.icls{0}GetMaxStrIdByPrefix",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public icls{0}GetMaxStrIdByPrefixEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
//            strBuilder.AppendFormat("\r\n" + "String strPrefix = \"2\";");
             //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN.FuncId4Code, strBuilder);

            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrIdByPrefix(strPrefix);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetMaxStrIdByPrefix,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(String returnString, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnString == \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"获取表{0}的最大关键字为空,不成功,请检查!\");",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"获取表{0}的最大关键字为：%s!\", returnString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_btnClickUpdateRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 修改记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "public void btnUpdateRecord_Click(View myView) {");
            strBuilder.AppendFormat("\r\n" + "icls{0}_UpdateRecordEx iobj{0}_UpdateRecord = new icls{0}_UpdateRecordEx(ac{0}_UnitTest.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_UpdateRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}_UpdateRecordEx extends cls{0}_Controller.icls{0}_UpdateRecord",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public icls{0}_UpdateRecordEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.JavaType == "boolean")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                }
                else if (objField.JavaType == "Date")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                }
                else if (objField.JavaType == "short")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}((short){2});",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(\"{2}\");",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}({2});",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                          objField.ObjFieldTabENEx.DefaultValue4Test_Java);
                }
            }
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.UpdateRecord(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行UpdateRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                   clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnBool == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "String strInfo = String.format(\"修改记录成功!\");");
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "String strInfo = String.format(\"修改记录不成功!\");");
            strBuilder.Append("\r\n" + "tvMsg.setText(strInfo);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
     private void GC_GetInputValue4Para(string strFuncId4Code, StringBuilder strBuilder)
        {
            string strMsg = "";
//            StringBuilder strBuilder = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
  clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(strFuncId4Code, enumFunctionPurpose.GeneCode_01);
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
                            strBuilder.AppendFormat("\r\n" + "{0} {1} = txt{2}.getText().toString();",
                                objDataTypeAbbrEN.JavaType,
                                objFuncPara4CodeEN.ParaName,
                                objFuncPara4CodeEN._StrTag);
                        }
                        else
                        {
                            switch (objFuncPara4CodeEN.DataTypeId)
                            {
                                case enumDataTypeAbbr.float_07:
                                    strBuilder.AppendFormat("\r\n" + "{0} {1} = Float.valueOf(txt{2}.getText().toString());",
                                        objDataTypeAbbrEN.JavaType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.int_09:
                                    strBuilder.AppendFormat("\r\n" + "{0} {1} = Integer.valueOf(txt{2}.getText().toString());",
                                        objDataTypeAbbrEN.JavaType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.bigint_01:
                                case enumDataTypeAbbr.bigintidentity_26:

                                    strBuilder.AppendFormat("\r\n" + "{0} {1} = Long.valueOf(txt{2}.getText().toString());",
                                        objDataTypeAbbrEN.JavaType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.money_11:
                                    strBuilder.AppendFormat("\r\n" + "{0} {1} = Double.valueOf(txt{2}.getText().toString());",
                                        objDataTypeAbbrEN.JavaType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                default:
                                    strMsg = string.Format("数据类型：[{0}({1})](Java:{2})在函数中没有处理!({3})",
                                        objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                        objDataTypeAbbrEN.JavaType,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        //if (objSelfDefDataTypeEN_Para != null)
                        //{
                        //    sbParaList.AppendFormat("{0} {1},",
                        //        objSelfDefDataTypeEN_Para.JavaType,
                        //        objFuncPara4CodeEN.ParaName);
                        //}
                        //else
                        //{
                        //    sbParaList.AppendFormat("{0} {1},",
                        //        objDataTypeAbbrEN.JavaType,
                        //        objFuncPara4CodeEN.ParaName);
                        //}
                        //sbParaVarList.AppendFormat("{0},", objFuncPara4CodeEN.ParaName);
                    }
                }
            }

        }
    }
}
