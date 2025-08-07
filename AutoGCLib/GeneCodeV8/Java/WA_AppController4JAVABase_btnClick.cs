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
    partial class WA_AppController4JAVABase : clsGeneCodeBase4Tab
    {       

        public string A_GeneFuncCode_Java_btnClick(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
               
                switch (strFuncName)
                {                  

                    case "Gen_WA_Controller_Java_btnClickGetFirstObj":
                        return Gen_WA_Controller_Java_btnClickGetFirstObj(objvFunction4GeneCodeEN);

                    case "Gen_WA_Controller_Java_btnClickGetObjByKey":
                        return Gen_WA_Controller_Java_btnClickGetObjByKey(objvFunction4GeneCodeEN);

                    case "Gen_WA_Controller_Java_btnClickDelRecord":
                        return Gen_WA_Controller_Java_btnClickDelRecord(objvFunction4GeneCodeEN);
                    case "Gen_WA_Controller_Java_btnClickDelRecordsByJSON":
                        return Gen_WA_Controller_Java_btnClickDelRecordsByJSON(objvFunction4GeneCodeEN);

                    case "Gen_WA_Controller_Java_btnClickAddNewRecord":
                        return Gen_WA_Controller_Java_btnClickAddNewRecord();

                    case "Gen_WA_Controller_Java_btnClickAddNewRecord4GetMaxStrId":
                        return Gen_WA_Controller_Java_btnClickAddNewRecord4GetMaxStrId();
                    case "Gen_WA_Controller_Java_btnClickGetMaxStrId":
                        return Gen_WA_Controller_Java_btnClickGetMaxStrId(objvFunction4GeneCodeEN);
                    case "Gen_WA_Controller_Java_btnClickGetMaxStrIdByPrefix":
                        return Gen_WA_Controller_Java_btnClickGetMaxStrIdByPrefix(objvFunction4GeneCodeEN);

                    case "Gen_WA_Controller_Java_btnClickUpdateRecord":
                        return Gen_WA_Controller_Java_btnClickUpdateRecord(objvFunction4GeneCodeEN);
                        
                    case "Gen_WA_Controller_Java_btnClickIsExistRecord":
                        return Gen_WA_Controller_Java_btnClickIsExistRecord(objvFunction4GeneCodeEN);

                    case "Gen_WA_Controller_Java_btnClickGetRecCountByCond":
                        return Gen_WA_Controller_Java_btnClickGetRecCountByCond(objvFunction4GeneCodeEN);

                    case "Gen_WA_Controller_Java_btnClickGetObjLst":
                        return Gen_WA_Controller_Java_btnClickGetObjLst(objvFunction4GeneCodeEN);

                    case "Gen_WA_Controller_Java_btnClickGetTopObjLst":
                        return Gen_WA_Controller_Java_btnClickGetTopObjLst(objvFunction4GeneCodeEN);

                    case "Gen_WA_Controller_Java_btnClickGetObjLstByPager":
                        return Gen_WA_Controller_Java_btnClickGetObjLstByPager(objvFunction4GeneCodeEN);

                    case "Gen_WA_Controller_Java_btnClickGetObjLstByRange":
                        return Gen_WA_Controller_Java_btnClickGetObjLstByRange(objvFunction4GeneCodeEN);

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

        public string Gen_WA_Controller_Java_btnClickGetObjByKey(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字获取相应的记录的对象");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public void btnGetObjByKey_Click(View myView) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetObjBy{1}Ex iobj{0}GetObjBy{1} = new icls{0}GetObjBy{1}Ex(ac{0}_WA_UT.this);",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetObjBy{1}.main();",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "class icls{0}GetObjBy{1}Ex extends cls{0}_WA_Controller.icls{0}GetObjBy{1}",
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

            strBuilder.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
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
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.GetObjBy{1}({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjByKey,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObject, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetObjByKey,
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

        public string Gen_WA_Controller_Java_btnClickGetFirstObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
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

            strBuilder.Append("\r\n" + "public void btnGetFirstObj_Click(View myView) {");

            strBuilder.AppendFormat("\r\n" + "icls{0}GetFirstObjEx iobj{0}GetFirstObj = new icls{0}GetFirstObjEx(ac{0}_WA_UT.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetFirstObj.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}GetFirstObjEx extends cls{0}_WA_Controller.icls{0}GetFirstObj",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public icls{0}GetFirstObjEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
             //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN.FuncId4Code, strBuilder);

            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.GetFirstObj(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetFirstObj,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObject, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstObj,
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

        public string Gen_WA_Controller_Java_btnClickGetObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "public void btnGetObjLst_Click(View myView) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetObjLstEx iobj{0}GetObjLst = new icls{0}GetObjLstEx(ac{0}_WA_UT.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetObjLst.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}GetObjLstEx extends cls{0}_WA_Controller.icls{0}GetObjLst",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public icls{0}GetObjLstEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
//            strBuilder.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
             //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN.FuncId4Code, strBuilder);

            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.GetObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLst,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetObjLst,
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

      
        public string Gen_WA_Controller_Java_btnClickGetTopObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的顶部对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "public void btnGetTopObjLst_Click(View myView) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetTopObjLstEx iobj{0}GetTopObjLst = new icls{0}GetTopObjLstEx(ac{0}_WA_UT.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetTopObjLst.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}GetTopObjLstEx extends cls{0}_WA_Controller.icls{0}GetTopObjLst",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public icls{0}GetTopObjLstEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "Integer intTopSize = 2;");
            //strBuilder.Append("\r\n" + "String strWhereCond =\" 1=1 \";");            
             //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN.FuncId4Code, strBuilder);

            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.GetTopObjLst(intTopSize, strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetTopRecordObjLst,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopObjLst,
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

        public string Gen_WA_Controller_Java_btnClickGetObjLstByPager(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的分页对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "public void btnGetObjLstByPager_Click(View myView) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetObjLstByPagerEx iobj{0}GetObjLstByPager = new icls{0}GetObjLstByPagerEx(ac{0}_WA_UT.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetObjLstByPager.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}GetObjLstByPagerEx extends cls{0}_WA_Controller.icls{0}GetObjLstByPager",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public icls{0}GetObjLstByPagerEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "Integer intPageIndex = 2;");
            //strBuilder.Append("\r\n" + "Integer intPageSize = 2;");
            //strBuilder.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
            //strBuilder.Append("\r\n" + "String strOrderBy =\"\";");

             //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN.FuncId4Code, strBuilder);

            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.GetObjLstByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLstByPager,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetObjLstByPager,
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

        public string Gen_WA_Controller_Java_btnClickGetObjLstByRange(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取范围内相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "public void btnGetObjLstByRange_Click(View myView) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetObjLstByRangeEx iobj{0}GetObjLstByRange = new icls{0}GetObjLstByRangeEx(ac{0}_WA_UT.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetObjLstByRange.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}GetObjLstByRangeEx extends cls{0}_WA_Controller.icls{0}GetObjLstByRange",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public icls{0}GetObjLstByRangeEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super(pvcParent);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "@Override");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            //int intMinNum = Long.valueOf(txtintMaxNum.getText().toString());
            //int intMinNum = Long.valueOf(txtintMinNum.getText().toString());

            //strBuilder.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
            //strBuilder.Append("\r\n" + "String strOrderBy =\"\";");

             //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN.FuncId4Code, strBuilder);

            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.GetObjLstByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLstByRange,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetObjLstByRange,
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
        public string Gen_WA_Controller_Java_btnClickIsExistRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
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


            strBuilder.AppendFormat("\r\n" + "icls{0}_IsExistRecordEx iobj{0}_IsExistRecord = new icls{0}_IsExistRecordEx(ac{0}_WA_UT.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_IsExistRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "class icls{0}_IsExistRecordEx extends cls{0}_WA_Controller.icls{0}_IsExistRecord",
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
            strBuilder.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "String strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
             //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN.FuncId4Code, strBuilder);

            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.IsExistRecord(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "switch (strClassName) {");
            strBuilder.AppendFormat("\r\n" + "case \"cls{0}WA4Controller\":",
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
            strBuilder.AppendFormat("\r\n" + "case \"cls{0}WA4Controller2\":",
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
        public string Gen_WA_Controller_Java_btnClickGetRecCountByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
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


            strBuilder.AppendFormat("\r\n" + "icls{0}GetRecCountByCondEx iobj{0}GetRecCountByCond = new icls{0}GetRecCountByCondEx(ac{0}_WA_UT.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetRecCountByCond.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "class icls{0}GetRecCountByCondEx extends cls{0}_WA_Controller.icls{0}GetRecCountByCond",
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
            strBuilder.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "String strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
             //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN.FuncId4Code, strBuilder);

            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.GetRecCountByCond(strWhereCond);",
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
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((ac{0}_WA_UT)vcParent, strInfo);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

   

        public string Gen_WA_Controller_Java_btnClickDelRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
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

            strBuilder.AppendFormat("\r\n" + "icls{0}_DelRecordEx iobj{0}_DelRecord = new icls{0}_DelRecordEx(ac{0}_WA_UT.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_DelRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}_DelRecordEx extends cls{0}_WA_Controller.icls{0}_DelRecord",
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
            strBuilder.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
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

            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.DelRecord({1});",
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
        public string Gen_WA_Controller_Java_btnClickDelRecordsByJSON(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
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

            strBuilder.AppendFormat("\r\n" + "icls{0}_DelRecordsByJSONEx iobj{0}_DelRecordsByJSON = new icls{0}_DelRecordsByJSONEx(ac{0}_WA_UT.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_DelRecordsByJSON.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}_DelRecordsByJSONEx extends cls{0}_WA_Controller.icls{0}_DelRecordsByJSON",
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
            strBuilder.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "String strKeyIdLst = txt{0}.getText().toString();",
                  GetNewParaCtrlName(strFuncId4GC, "strKeyIdLst"));
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
                   

            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.DelRecordsByJSON(strKeyIdLst);",
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


    
      
        /// <summary>
        /// 继承Runnable类必须实现的【run】函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_Controller_Java_btnClickAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "public void btnAddNewRecord_Click(View myView) {");
            strBuilder.AppendFormat("\r\n" + "icls{0}_AddNewRecordEx iobj{0}_AddNewRecord = new icls{0}_AddNewRecordEx(ac{0}_WA_UT.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_AddNewRecord.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "class icls{0}_AddNewRecordEx extends cls{0}_WA_Controller.icls{0}_AddNewRecord",
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
            strBuilder.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "String strWhereCond =String.format(\"{1} = '%s'\",obj{0}EN.get{1}());",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.IsExistRecord(strWhereCond);",
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
            strBuilder.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.AddNewRecord(obj{0}EN);",
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
               clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecord,
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

        public string Gen_WA_Controller_Java_btnClickAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "public void btnAddNewRecord4GetMaxStrId_Click(View myView) {");
            strBuilder.AppendFormat("\r\n" + "icls{0}_AddNewRecord4GetMaxStrIdEx iobj{0}_AddNewRecord4GetMaxStrId = new icls{0}_AddNewRecord4GetMaxStrIdEx(ac{0}_WA_UT.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_AddNewRecord4GetMaxStrId.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "class icls{0}_AddNewRecord4GetMaxStrIdEx extends cls{0}_WA_Controller.icls{0}_AddNewRecord4GetMaxStrId",
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
            strBuilder.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.GetMaxStrId();",
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
            strBuilder.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "String strWhereCond =String.format(\"{1} = '%s'\", obj{0}EN.get{1}());",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.IsExistRecord(strWhereCond);",
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
            strBuilder.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.AddNewRecord(obj{0}EN);",
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
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecord,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行AddNewRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conAddNewRecord,
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

        public string Gen_WA_Controller_Java_btnClickGetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "public void btnGetMaxStrId_Click(View myView) {");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetMaxStrIdEx iobj{0}GetMaxStrId = new icls{0}GetMaxStrIdEx(ac{0}_WA_UT.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetMaxStrId.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "class icls{0}GetMaxStrIdEx extends cls{0}_WA_Controller.icls{0}GetMaxStrId",
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
            strBuilder.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.GetMaxStrId();",
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

        public string Gen_WA_Controller_Java_btnClickGetMaxStrIdByPrefix(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "public void btnGetMaxStrIdByPrefix_Click(View myView) {");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetMaxStrIdByPrefixEx iobj{0}GetMaxStrIdByPrefix = new icls{0}GetMaxStrIdByPrefixEx(ac{0}_WA_UT.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetMaxStrIdByPrefix.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "class icls{0}GetMaxStrIdByPrefixEx extends cls{0}_WA_Controller.icls{0}GetMaxStrIdByPrefix",
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
            strBuilder.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
//            strBuilder.AppendFormat("\r\n" + "String strPrefix = \"2\";");
             //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
            GC_GetInputValue4Para(objvFunction4GeneCodeEN.FuncId4Code, strBuilder);

            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.GetMaxStrIdByPrefix(strPrefix);",
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

        public string Gen_WA_Controller_Java_btnClickUpdateRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 修改记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "public void btnUpdateRecord_Click(View myView) {");
            strBuilder.AppendFormat("\r\n" + "icls{0}_UpdateRecordEx iobj{0}_UpdateRecord = new icls{0}_UpdateRecordEx(ac{0}_WA_UT.this);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_UpdateRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "class icls{0}_UpdateRecordEx extends cls{0}_WA_Controller.icls{0}_UpdateRecord",
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
            strBuilder.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WA4Controller.UpdateRecord(obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行UpdateRecord,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(boolean returnBool, String strClassName)",
                   clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecord,
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
