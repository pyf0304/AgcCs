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

        public string A_GeneFuncCode_Java_icls(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
          
            try
            {
                switch (strFuncName)
                {                  

                    case "Gen_Controller_Java_iclsGetFirstJSONObj":
                        return Gen_Controller_Java_iclsGetFirstJSONObj(objvFunction4GeneCodeEN);

                    case "Gen_Controller_Java_iclsGetJSONObjByKey":
                        return Gen_Controller_Java_iclsGetJSONObjByKey();
                        
                    case "Gen_Controller_Java_iclsDelRecord":
                        return Gen_Controller_Java_iclsDelRecord();

                    case "Gen_Controller_Java_iclsDelRecordsByJSON":
                        return Gen_Controller_Java_iclsDelRecordsByJSON();

                    case "Gen_Controller_Java_iclsAddNewRecord":
                        return Gen_Controller_Java_iclsAddNewRecord();

                    case "Gen_Controller_Java_iclsAddNewRecord4GetMaxStrId":
                        return Gen_Controller_Java_iclsAddNewRecord4GetMaxStrId();
                    case "Gen_Controller_Java_iclsGetMaxStrId":
                        return Gen_Controller_Java_iclsGetMaxStrId();
                    case "Gen_Controller_Java_iclsGetMaxStrIdByPrefix":
                        return Gen_Controller_Java_iclsGetMaxStrIdByPrefix();

                    case "Gen_Controller_Java_iclsUpdateRecord":
                        return Gen_Controller_Java_iclsUpdateRecord();
                        
                    case "Gen_Controller_Java_iclsIsExistRecord":
                        return Gen_Controller_Java_iclsIsExistRecord(objvFunction4GeneCodeEN);

                    case "Gen_Controller_Java_iclsGetRecCountByCond":
                        return Gen_Controller_Java_iclsGetRecCountByCond(objvFunction4GeneCodeEN);

                    case "Gen_Controller_Java_iclsGetJSONObjLst":
                        return Gen_Controller_Java_iclsGetJSONObjLst();

                    case "Gen_Controller_Java_iclsGetTopJSONObjLst":
                        return Gen_Controller_Java_iclsGetTopJSONObjLst();

                    case "Gen_Controller_Java_iclsGetJSONObjLstByPager":
                        return Gen_Controller_Java_iclsGetJSONObjLstByPager();

                    case "Gen_Controller_Java_iclsGetJSONObjLstByRange":
                        return Gen_Controller_Java_iclsGetJSONObjLstByRange();
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

        public string Gen_Controller_Java_iclsGetJSONObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字获取相应的记录的对象");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");

            strBuilder.AppendFormat("\r\n" + "public static class icls{0}GetObjBy{1} extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "public Object vcParent = null;");
            strBuilder.AppendFormat("\r\n" + "public icls{0}GetObjBy{1}(Object pvcParent)",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "{1} {0} = \"{2}\";",
                    objKeyField.ObjFieldTabENEx.PrivPropName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Java);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "{1} {0} = {2};",
                    objKeyField.ObjFieldTabENEx.PrivPropName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Java);
            }
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetObjBy{1}({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.PrivPropName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjByKey,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "if (vcParent != null){");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");
  
            strBuilder.AppendFormat("\r\n" + "Log.d(\"{0}\", objResponseData.faultString);", enumDict4GC_DictKey1.conGetRecordJSONObjByKey);
            
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjByKey,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObject, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjByKey,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = (cls{0}EN)returnObject;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据关键字’01‘ 获取对象：%s!\", obj{0}EN.get{1}());",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_iclsGetFirstJSONObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
        
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的第一条记录的对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n" + "public static class icls{0}GetFirstJSONObj extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "public Object vcParent = null;");
            strBuilder.AppendFormat("\r\n" + "public icls{0}GetFirstJSONObj(Object pvcParent)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");


            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetFirstJSONObj(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetFirstJSONObj,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "if (vcParent != null){");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");

            strBuilder.AppendFormat("\r\n" + "Log.d(\"{0}\", objResponseData.faultString);", enumDict4GC_DictKey1.conGetFirstJSONObj);

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetFirstJSONObj,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObject, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetFirstJSONObj,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = (cls{0}EN)returnObject;",
                objPrjTabENEx.TabName);
            
            //strBuilder.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
            //    GetNewParaCtrlName(objvFunction4GeneCodeEN, "strWhereCond"));
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:1=1 获取第一个记录对象：%s!\", obj{0}EN.get{1}());",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");
            
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }     

        public string Gen_Controller_Java_iclsGetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n" + "public static class icls{0}GetJSONObjLst extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "public Object vcParent = null;");
            strBuilder.AppendFormat("\r\n" + "public icls{0}GetJSONObjLst(Object pvcParent)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLst,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "if (vcParent != null){");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");

            strBuilder.AppendFormat("\r\n" + "Log.d(\"{0}\", objResponseData.faultString);", enumDict4GC_DictKey1.conGetRecordJSONObjLst);

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLst,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
                objPrjTabENEx.TabName);
         
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"共获取对象列表数：%s!\", arr{0}ObjLst.size());",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_iclsGetTopJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的顶部对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n" + "public static class icls{0}GetTopJSONObjLst extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "public Object vcParent = null;");
            strBuilder.AppendFormat("\r\n" + "public icls{0}GetTopJSONObjLst(Object pvcParent)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "Integer intTopSize = 2;");
            strBuilder.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetTopJSONObjLst(intTopSize, strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetTopRecordObjLst,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "if (vcParent != null){");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");

            strBuilder.AppendFormat("\r\n" + "Log.d(\"{0}\", objResponseData.faultString);", enumDict4GC_DictKey1.conGetTopRecordJSONObjLst);

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetTopRecordObjLst,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetTopRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"共获取对象列表数：%s!\", arr{0}ObjLst.size());",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_iclsGetJSONObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的分页对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n" + "public static class icls{0}GetJSONObjLstByPager extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "public Object vcParent = null;");
            strBuilder.AppendFormat("\r\n" + "public icls{0}GetJSONObjLstByPager(Object pvcParent)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "Integer intPageIndex = 2;");
            strBuilder.Append("\r\n" + "Integer intPageSize = 2;");
            strBuilder.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
            strBuilder.Append("\r\n" + "String strOrderBy =\"\";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLstByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLstByPager,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "if (vcParent != null){");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");

            strBuilder.AppendFormat("\r\n" + "Log.d(\"{0}\", objResponseData.faultString);", enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager.Substring(0, 23));

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLstByPager,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByPager,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"共获取对象列表数：%s!\", arr{0}ObjLst.size());",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        public string Gen_Controller_Java_iclsGetJSONObjLstByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取范围内相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n" + "public static class icls{0}GetJSONObjLstByRange extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "public Object vcParent = null;");
            strBuilder.AppendFormat("\r\n" + "public icls{0}GetJSONObjLstByRange(Object pvcParent)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "int intMinNum = 2;");
            strBuilder.Append("\r\n" + "int intMaxNum = 5;");
            strBuilder.Append("\r\n" + "String strWhereCond =\" 1=1 \";");
            strBuilder.Append("\r\n" + "String strOrderBy =\"\";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLstByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLstByRange,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByRange,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "if (vcParent != null){");            
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");

            strBuilder.AppendFormat("\r\n" + "Log.d(\"{0}\", objResponseData.faultString);", enumDict4GC_DictKey1.conGetRecordJSONObjLstByRange.Substring(0,23));

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetRecordObjLstByRange,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLstByRange,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"共获取对象列表数：%s!\", arr{0}ObjLst.size());",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        //public string Gen_Controller_Java_BindDdl(string strTabName, string strValueFld, string strTextFld)
        //{
        //    StringBuilder strBuilder = new StringBuilder();
        //    strBuilder.Append("\r\n /// <summary>");
        //    strBuilder.Append("\r\n /// 绑定下拉框");
        //    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
        //    strBuilder.Append("\r\n /// </summary>");
        //    strBuilder.AppendFormat("\r\n" + "public void BindDdl_{0}(Spinner spnObject, Activity acPage)",
        //        strValueFld);
        //    strBuilder.Append("\r\n" + "{");
        //    strBuilder.Append("\r\n" + "mspnObject = spnObject;");
        //    strBuilder.Append("\r\n" + "macPage = acPage;");
        //    strBuilder.AppendFormat("\r\n" + "if ({1}.arr{0}ObjLstCache != null)",
        //        strTabName, objPrjTabENEx.ClsName);
        //    strBuilder.Append("\r\n" + "{");
        //    strBuilder.AppendFormat("\r\n" + "if (mobjDdlAdapter{0} == null)",
        //        strTabName);
        //    strBuilder.Append("\r\n" + "{");
        //    strBuilder.AppendFormat("\r\n" + "mobjDdlAdapter{0} = new ddlAdapter{0}(macPage, {1}.arr{0}ObjLstCache);",
        //        strTabName, objPrjTabENEx.ClsName);
        //    strBuilder.Append("\r\n" + "}");
        //    //            userStateAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        //    strBuilder.AppendFormat("\r\n" + "mspnObject.setAdapter(mobjDdlAdapter{0});",
        //        strTabName);
        //  //  strBuilder.Append("\r\n" + "SendMessage(\"使用缓存!\");");
        //    strBuilder.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"BindDdl_{0}使用缓存!\", 1);",
        //        strTabName);
        //    strBuilder.Append("\r\n" + "}");
        //    strBuilder.Append("\r\n" + "else");
        //    strBuilder.Append("\r\n" + "{");
        //    strBuilder.AppendFormat("\r\n" + "{1}.icls{0}GetJSONObjLstEx iobj{0}GetJSONObjLst = new {1}.icls{0}GetJSONObjLstEx({1}.this);",
        //        strTabName, objPrjTabENEx.ClsName);
        //    strBuilder.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
        //        strTabName);
        //    strBuilder.Append("\r\n" + "}");
        //    strBuilder.Append("\r\n" + "}");

        //    return strBuilder.ToString();
        //}

        public string Gen_Controller_Java_SendMessage(string strTabName, string strValueFld, string strTextFld)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 向Handler发送消息,告诉任务调度当前任务已经过程");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n" + "private void SendMessage(String strUseMode)",
                strValueFld);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "Message msg = new Message();");
            strBuilder.Append("\r\n" + "           msg.what = 2;");
            strBuilder.Append("\r\n" + "//这三句可以传递数据");
            strBuilder.Append("\r\n" + "Bundle data = new Bundle();");
            strBuilder.Append("\r\n" + "data.putInt(\"COUNT\", 100);//COUNT是标签,handleMessage中使用");
            strBuilder.Append("\r\n" + "data.putString(\"strUseMode\", strUseMode);");
            strBuilder.Append("\r\n" + "msg.setData(data);");
            strBuilder.Append("\r\n" + "mobjHandler.sendMessage(msg); // 向Handler发送消息,告诉任务调度当前任务已经过程");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Java_iclsIsExistRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查相应关键字的记录是否存在");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");

            strBuilder.AppendFormat("\r\n" + "public static class icls{0}_IsExistRecord extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "public Object vcParent = null;");
            strBuilder.AppendFormat("\r\n" + "public icls{0}_IsExistRecord(Object pvcParent)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "String strWhereCond = \"{0} ='12'\";",
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
            
            strBuilder.Append("\r\n" + "if (vcParent != null){");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");

            strBuilder.AppendFormat("\r\n" + "Log.d(\"{0}\", objResponseData.faultString);", enumDict4GC_DictKey1.conIsExistRecord);

            strBuilder.Append("\r\n" + "}");

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
            
          
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:{0} ='12' 不存在!\");",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            
            //strBuilder.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
            //    GetNewParaCtrlName(objvFunction4GeneCodeEN, "strWhereCond"));
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:{0} ='12' 存在!\");",
                objKeyField.FldName);
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
        public string Gen_Controller_Java_iclsGetRecCountByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查相应关键字的记录是否存在");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");

            strBuilder.AppendFormat("\r\n" + "public static class icls{0}GetRecCountByCond extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "public Object vcParent = null;");
            strBuilder.AppendFormat("\r\n" + "public icls{0}GetRecCountByCond(Object pvcParent)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "String strWhereCond = \"{0} ='12'\";",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetRecCountByCond(strWhereCond);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetRecCountByCond,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "if (vcParent != null){");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");

            strBuilder.AppendFormat("\r\n" + "Log.d(\"{0}\", objResponseData.faultString);", enumDict4GC_DictKey1.conGetRecCountByCond);

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//通过WebService执行GetRecCountByCond,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(int returnInt, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecCountByCond,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            
            //strBuilder.AppendFormat("\r\n" + "String strWhereCond = txt{0}.getText().toString();",
            //    GetNewParaCtrlName(objvFunction4GeneCodeEN, "strWhereCond"));
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:{0} ='12'的记录数:[%s]!\", returnInt);",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, strInfo);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
    
        public string Gen_Controller_Java_iclsDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 删除记录");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n" + "public static class icls{0}_DelRecord extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "public Object vcParent = null;");
            strBuilder.AppendFormat("\r\n" + "public icls{0}_DelRecord(Object pvcParent)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.DelRecord(\"{1}\");",
                    objPrjTabENEx.TabName,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Java);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.DelRecord({1});",
                    objPrjTabENEx.TabName,
                    objKeyField.ObjFieldTabENEx.DefaultValue4Test_Java);
            }
            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "//通过WebService执行DelRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecord,
                enumDict4GC_DictKey2.conFinished));
            
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "if (vcParent != null){");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");

            strBuilder.AppendFormat("\r\n" + "Log.d(\"{0}\", objResponseData.faultString);", enumDict4GC_DictKey1.conDelRecord);

            strBuilder.Append("\r\n" + "}");

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
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "String strInfo = String.format(\"删除记录不成功!\");");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");


            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }
        public string Gen_Controller_Java_iclsDelRecordsByJSON()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 删除记录");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n" + "public static class icls{0}_DelRecordsByJSON extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "public Object vcParent = null;");
            strBuilder.AppendFormat("\r\n" + "public icls{0}_DelRecordsByJSON(Object pvcParent)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "String strKeyIdLst = \"'01','02'\";",
           objKeyField.FldName);
            
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.DelRecordsByJSON(strKeyIdLst);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行DelRecordsByJSON,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecordsByJSON,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "if (vcParent != null){");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");
            strBuilder.Append("\r\n" + "Log.d(\"DelRecordsByJSON\", objResponseData.faultString);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行DelRecordsByJSON,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(int returnInt, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conDelRecordsByJSON,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (returnInt > 0)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "String strInfo = String.format(\"删除记录成功, 共删除了%s条记录!\", returnInt);");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "String strInfo = String.format(\"删除记录不成功!\");");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");


            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }


        public string Gen_Controller_Java_iclsByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n" + "public static class icls{0} extends clsTableObjWS4ControllerDelegate",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "{");

            //strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
            //    objWebSrvClassENEx.TabName);
            strBuilder.Append("\r\n" + "public Object vcParent = null;");
            strBuilder.AppendFormat("\r\n" + "public icls{0}(Object pvcParent)",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}WS4Controller obj{0}WS4Controller = new {0}WS4Controller();",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objWebSrvClassENEx.ClsName);

            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();

            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {
                    strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
                       objWebSrvFuncParaEN.ParaName,
                         objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = \"{2}\";",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName,
                            "0");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = {2};",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName,
                            "0");
                    }
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objSelfDefDataTypeEN_Para.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("{0},", objWebSrvFuncParaEN.ParaName);
                }
            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }
            
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.{1}({2});",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvFunctionsENEx.FunctionName,
                    sbParaVarList.ToString());
            
            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n" + "//通过WebService执行函数:[{0}],返回的事件函数,可能需要处理执行错误。",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName, String strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "if (vcParent != null){");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");
            strBuilder.Append("\r\n" + "Log.d(\"SelfDefFunc\", objResponseData.faultString);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "//通过WebService执行函数:[{0}],返回的事件函数,这是正确返回,不需要处理执行错误。",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}( String returnString, String strClassName, String strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strBuilder.Append("\r\n" + "{");
           
            strBuilder.Append("\r\n" + "String strInfo = String.format(\"返回值为：[%s]!\", returnString);");
            strBuilder.Append("\r\n" + "//显示信息框");
          //  strBuilder.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage(vc{0}.this, strInfo);",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
         
            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }

        /// <summary>
        /// 继承Runnable类必须实现的【run】函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Java_iclsAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");

            strBuilder.AppendFormat("\r\n" + "public static class icls{0}_AddNewRecord extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "public Object vcParent = null;");
            strBuilder.AppendFormat("\r\n" + "public icls{0}_AddNewRecord(Object pvcParent)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "}");

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
            strBuilder.Append("\r\n" + "//通过WebService执行IsExistRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conIsExistRecord,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "if (vcParent != null){");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");
            strBuilder.Append("\r\n" + "Log.d(\"IsExistRecord\", objResponseData.faultString);");
            strBuilder.Append("\r\n" + "}");

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

            strBuilder.Append("\r\n" + "if (vcParent != null){");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");
            strBuilder.Append("\r\n" + "Log.d(\"AddNewRecordByJSON\", objResponseData.faultString);");
            strBuilder.Append("\r\n" + "}");

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
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "String strInfo = String.format(\"添加记录不成功!\");");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_iclsAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n" + "public static class icls{0}_AddNewRecord4GetMaxStrId extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "public Object vcParent = null;");
            strBuilder.AppendFormat("\r\n" + "public icls{0}_AddNewRecord4GetMaxStrId(Object pvcParent)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetMaxStrId,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "if (vcParent != null){");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");
            strBuilder.AppendFormat("\r\n" + "Log.d(\"{0}\", objResponseData.faultString);", enumDict4GC_DictKey1.conGetMaxStrId);
            strBuilder.Append("\r\n" + "}");

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

            strBuilder.Append("\r\n" + "if (vcParent != null){");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");
     
            strBuilder.AppendFormat("\r\n" + "Log.d(\"{0}\", objResponseData.faultString);", enumDict4GC_DictKey1.conIsExistRecord);
            strBuilder.Append("\r\n" + "}");

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

            strBuilder.Append("\r\n" + "if (vcParent != null){");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");

            strBuilder.AppendFormat("\r\n" + "Log.d(\"{0}\", objResponseData.faultString);", enumDict4GC_DictKey1.conAddNewRecordByJSON);

            strBuilder.Append("\r\n" + "}");

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
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "String strInfo = String.format(\"添加记录不成功!\");");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_iclsGetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");

            strBuilder.AppendFormat("\r\n" + "public static class icls{0}GetMaxStrId extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "public Object vcParent = null;");
            strBuilder.AppendFormat("\r\n" + "public icls{0}GetMaxStrId(Object pvcParent)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrId();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetMaxStrId,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrId,
                enumDict4GC_DictKey2.conFinished));
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "if (vcParent != null){");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");

            strBuilder.AppendFormat("\r\n" + "Log.d(\"{0}\", objResponseData.faultString);", enumDict4GC_DictKey1.conGetMaxStrId);

            strBuilder.Append("\r\n" + "}");

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
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"获取表{0}的最大关键字为：%s!\", returnString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_iclsGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");

            strBuilder.AppendFormat("\r\n" + "public static class icls{0}GetMaxStrIdByPrefix extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "public Object vcParent = null;");
            strBuilder.AppendFormat("\r\n" + "public icls{0}GetMaxStrIdByPrefix(Object pvcParent)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "public void main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
           objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "String strPrefix = \"2\";");
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4Controller.GetMaxStrIdByPrefix(strPrefix);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//通过WebService执行GetMaxStrIdByPrefix,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetMaxStrIdByPrefix,
                enumDict4GC_DictKey2.conFinished));

            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "if (vcParent != null){");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");

            strBuilder.AppendFormat("\r\n" + "Log.d(\"{0}\", objResponseData.faultString);", enumDict4GC_DictKey1.conGetMaxStrIdByPrefix);

            strBuilder.Append("\r\n" + "}");

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
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "String strInfo = String.format(\"获取表{0}的最大关键字为：%s!\", returnString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_iclsUpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 修改记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n" + "public static class icls{0}_UpdateRecord extends clsTableObjWS4ControllerDelegate",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "public Object vcParent = null;");
            strBuilder.AppendFormat("\r\n" + "public icls{0}_UpdateRecord(Object pvcParent)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "vcParent = pvcParent;");
            strBuilder.Append("\r\n" + "}");

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
            strBuilder.Append("\r\n" + "//通过WebService执行UpdateRecord,返回的事件函数,可能需要处理执行错误。");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.AppendFormat("\r\n" + "public void {0}(clsResponseData objResponseData, String strClassName)",
                      clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conUpdateRecordByJSON,
                enumDict4GC_DictKey2.conFinished));
            
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "if (vcParent != null){");
            strBuilder.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, objResponseData.faultString);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "else{");

            strBuilder.AppendFormat("\r\n" + "Log.d(\"{0}\", objResponseData.faultString);", enumDict4GC_DictKey1.conUpdateRecordByJSON);

            strBuilder.Append("\r\n" + "}");

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
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "String strInfo = String.format(\"修改记录不成功!\");");
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
   
    }
}
