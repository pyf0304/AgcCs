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
    partial class AutoGC6_Controller : AutoGCPubFuncV6
    {
        public string A_GeneFuncCode_JavaScript_Invoke(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {

                    case "Gen_Controller_JavaScript_InvokeGetFirstJSONObj":
                        return Gen_Controller_JavaScript_InvokeGetFirstJSONObj();

                    case "Gen_Controller_JavaScript_InvokeGetJSONObjByKey":
                        return Gen_Controller_JavaScript_InvokeGetJSONObjByKey();

                    case "Gen_Controller_JavaScript_InvokeDelRecord":
                        return Gen_Controller_JavaScript_InvokeDelRecord();

                    case "Gen_Controller_JavaScript_InvokeAddNewRecord":
                        return Gen_Controller_JavaScript_InvokeAddNewRecord();

                    case "Gen_Controller_JavaScript_InvokeAddNewRecord4GetMaxStrId":
                        return Gen_Controller_JavaScript_InvokeAddNewRecord4GetMaxStrId();
                    case "Gen_Controller_JavaScript_InvokeGetMaxStrId":
                        return Gen_Controller_JavaScript_InvokeGetMaxStrId();
                    case "Gen_Controller_JavaScript_InvokeGetMaxStrIdByPrefix":
                        return Gen_Controller_JavaScript_InvokeGetMaxStrIdByPrefix();

                    case "Gen_Controller_JavaScript_InvokeUpdateRecord":
                        return Gen_Controller_JavaScript_InvokeUpdateRecord();

                    case "Gen_Controller_JavaScript_InvokeIsExistRecord":
                        return Gen_Controller_JavaScript_InvokeIsExistRecord();

                    case "Gen_Controller_JavaScript_InvokeGetRecCountByCond":
                        return Gen_Controller_JavaScript_InvokeGetRecCountByCond();

                    case "Gen_Controller_JavaScript_InvokeGetJSONObjLst":
                        return Gen_Controller_JavaScript_InvokeGetJSONObjLst();

                    case "Gen_Controller_JavaScript_InvokeGetTopJSONObjLst":
                        return Gen_Controller_JavaScript_InvokeGetTopJSONObjLst();

                    case "Gen_Controller_JavaScript_InvokeGetJSONObjLstByPager":
                        return Gen_Controller_JavaScript_InvokeGetJSONObjLstByPager();

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


        /// <summary>
        /// 继承Runnable类必须实现的【run】函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_JavaScript_InvokeAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "this.InvokeAddNewRecord = function() {");
            strBuilder.AppendFormat("\r\n" + "const iobj{0}_AddNewRecord = new icls{0}_AddNewRecord();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_AddNewRecord.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
        
            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "this.InvokeAddNewRecord4GetMaxStrId = function() {");
            strBuilder.AppendFormat("\r\n" + "const iobj{0}_AddNewRecord4GetMaxStrId = new icls{0}_AddNewRecord4GetMaxStrId();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_AddNewRecord4GetMaxStrId.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
 
            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeGetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "this.InvokeGetMaxStrId = function() {");
            strBuilder.AppendFormat("\r\n" + "const iobj{0}GetMaxStrId = new icls{0}GetMaxStrId();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetMaxStrId.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "this.InvokeGetMaxStrIdByPrefix = function() {");
            strBuilder.AppendFormat("\r\n" + "const iobj{0}GetMaxStrIdByPrefix = new icls{0}GetMaxStrIdByPrefix();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetMaxStrIdByPrefix.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeUpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 修改记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "this.InvokeUpdateRecord = function() {");
            strBuilder.AppendFormat("\r\n" + "const iobj{0}_UpdateRecord = new icls{0}_UpdateRecord();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_UpdateRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 删除记录");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "this.InvokeDelRecord = function() {");

            strBuilder.AppendFormat("\r\n" + "const iobj{0}_DelRecord = new icls{0}_DelRecord();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_DelRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_JavaScript_InvokeIsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查相应关键字的记录是否存在");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strBuilder.Append("\r\n /// <returns>返回是否存在</returns>");

            strBuilder.Append("\r\n" + "this.InvokeIsExistRecord = function() {");


            strBuilder.AppendFormat("\r\n" + "const iobj{0}_IsExistRecord = new icls{0}_IsExistRecord();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_IsExistRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查相应关键字的记录是否存在");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strBuilder.Append("\r\n /// <returns>返回是否存在</returns>");

            strBuilder.Append("\r\n" + "this.InvokeGetRecCountByCond = function() {");

            strBuilder.AppendFormat("\r\n" + "const iobj{0}GetRecCountByCond = new icls{0}GetRecCountByCond();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetRecCountByCond.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_Controller_JavaScript_InvokeGetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "this.InvokeGetJSONObjLst = function() ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const iobj{0}GetJSONObjLst = new icls{0}GetJSONObjLst();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeGetTopJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "this.InvokeGetTopJSONObjLst = function() ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const iobj{0}GetTopJSONObjLst = new icls{0}GetTopJSONObjLst();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetTopJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeGetJSONObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "this.InvokeGetJSONObjLstByPager = function() ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const iobj{0}GetJSONObjLstByPager = new icls{0}GetJSONObjLstByPager();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetJSONObjLstByPager.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeGetJSONObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字获取相应的记录的对象");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "this.InvokeGetJSONObjByKey = function() {");

            strBuilder.AppendFormat("\r\n" + "const iobj{0}GetObjBy{1} = new icls{0}GetObjBy{1}();",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetObjBy{1}.main();",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeGetFirstJSONObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的第一条记录的对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "this.InvokeGetFirstJSONObj = function() {");

            strBuilder.AppendFormat("\r\n" + "const iobj{0}GetFirstObj = new icls{0}GetFirstObj();",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetFirstObj.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        public string Gen_Controller_JavaScript_InvokeByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            //string strMsg = "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查相应关键字的记录是否存在");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strBuilder.Append("\r\n /// <returns>返回是否存在</returns>");

            strBuilder.AppendFormat("\r\n" + "this.Invoke{0} = function() ",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "const iobj{0}_{1} = new icls{0}_{1}();",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_{1}.main();",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

    }
}
