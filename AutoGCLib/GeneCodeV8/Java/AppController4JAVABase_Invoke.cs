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

        public string A_GeneFuncCode_Java_Invoke(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {                  

                    case "Gen_Controller_Java_InvokeGetFirstJSONObj":
                        return Gen_Controller_Java_InvokeGetFirstJSONObj();

                    case "Gen_Controller_Java_InvokeGetJSONObjByKey":
                        return Gen_Controller_Java_InvokeGetJSONObjByKey();
                        
                    case "Gen_Controller_Java_InvokeDelRecord":
                        return Gen_Controller_Java_InvokeDelRecord();
                    case "Gen_Controller_Java_InvokeDelRecordsByJSON":
                        return Gen_Controller_Java_InvokeDelRecordsByJSON();
                    case "Gen_Controller_Java_InvokeAddNewRecord":
                        return Gen_Controller_Java_InvokeAddNewRecord();

                    case "Gen_Controller_Java_InvokeAddNewRecord4GetMaxStrId":
                        return Gen_Controller_Java_InvokeAddNewRecord4GetMaxStrId();
                    case "Gen_Controller_Java_InvokeGetMaxStrId":
                        return Gen_Controller_Java_InvokeGetMaxStrId();
                    case "Gen_Controller_Java_InvokeGetMaxStrIdByPrefix":
                        return Gen_Controller_Java_InvokeGetMaxStrIdByPrefix();

                    case "Gen_Controller_Java_InvokeUpdateRecord":
                        return Gen_Controller_Java_InvokeUpdateRecord();
                        
                    case "Gen_Controller_Java_InvokeIsExistRecord":
                        return Gen_Controller_Java_InvokeIsExistRecord();

                    case "Gen_Controller_Java_InvokeGetRecCountByCond":
                        return Gen_Controller_Java_InvokeGetRecCountByCond();

                    case "Gen_Controller_Java_InvokeGetJSONObjLst":
                        return Gen_Controller_Java_InvokeGetJSONObjLst();

                    case "Gen_Controller_Java_InvokeGetTopJSONObjLst":
                        return Gen_Controller_Java_InvokeGetTopJSONObjLst();

                    case "Gen_Controller_Java_InvokeGetJSONObjLstByPager":
                        return Gen_Controller_Java_InvokeGetJSONObjLstByPager();

                    case "Gen_Controller_Java_InvokeGetJSONObjLstByRange":
                        return Gen_Controller_Java_InvokeGetJSONObjLstByRange();

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

        public string Gen_Controller_Java_InvokeGetJSONObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字获取相应的记录的对象");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public void GetJSONObjByKey(Object vcParentView) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetObjBy{1} iobj{0}GetObjBy{1} = new icls{0}GetObjBy{1}(vcParentView);",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetObjBy{1}.main();",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_InvokeGetFirstJSONObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的第一条记录的对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "public void GetFirstJSONObj(Object vcParentView) {");

            strBuilder.AppendFormat("\r\n" + "icls{0}GetFirstJSONObj iobj{0}GetFirstJSONObj = new icls{0}GetFirstJSONObj(vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetFirstJSONObj.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }     

        public string Gen_Controller_Java_InvokeGetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "public void GetJSONObjLst(Object vcParentView) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetJSONObjLst iobj{0}GetJSONObjLst = new icls{0}GetJSONObjLst(vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_InvokeGetTopJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的顶部对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "public void GetTopJSONObjLst(Object vcParentView) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetTopJSONObjLst iobj{0}GetTopJSONObjLst = new icls{0}GetTopJSONObjLst(vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetTopJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_InvokeGetJSONObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的分页对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "public void GetJSONObjLstByPager(Object vcParentView) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetJSONObjLstByPager iobj{0}GetJSONObjLstByPager = new icls{0}GetJSONObjLstByPager(vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetJSONObjLstByPager.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_InvokeGetJSONObjLstByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取范围内的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "public void GetJSONObjLstByRange(Object vcParentView) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetJSONObjLstByRange iobj{0}GetJSONObjLstByRange = new icls{0}GetJSONObjLstByRange(vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetJSONObjLstByRange.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Java_InvokeIsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查相应关键字的记录是否存在");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strBuilder.Append("\r\n /// <returns>返回是否存在</returns>");

            strBuilder.Append("\r\n" + "public void IsExistRecord(Object vcParentView) {");


            strBuilder.AppendFormat("\r\n" + "icls{0}_IsExistRecord iobj{0}_IsExistRecord = new icls{0}_IsExistRecord(vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_IsExistRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Java_InvokeGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查相应关键字的记录是否存在");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strBuilder.Append("\r\n /// <returns>返回是否存在</returns>");

            strBuilder.Append("\r\n" + "public void GetRecCountByCond(Object vcParentView) {");


            strBuilder.AppendFormat("\r\n" + "icls{0}GetRecCountByCond iobj{0}GetRecCountByCond = new icls{0}GetRecCountByCond(vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetRecCountByCond.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }
    
        public string Gen_Controller_Java_InvokeDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 删除记录");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "public void DelRecord(Object vcParentView) {");

            strBuilder.AppendFormat("\r\n" + "icls{0}_DelRecord iobj{0}_DelRecord = new icls{0}_DelRecord(vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_DelRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_InvokeDelRecordsByJSON()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 删除记录");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "public void DelRecordsByJSON(Object vcParentView) {");

            strBuilder.AppendFormat("\r\n" + "icls{0}_DelRecordsByJSON iobj{0}_DelRecordsByJSON = new icls{0}_DelRecordsByJSON(vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_DelRecordsByJSON.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_InvokeByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            //string strMsg = "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
          //  strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "public void Invoke_{0}(Object vcParentView) ",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "icls{0} iobj{0} = new icls{0}(vcParentView);",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}.main();",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 继承Runnable类必须实现的【run】函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Java_InvokeAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "public void AddNewRecord(Object vcParentView) {");
            strBuilder.AppendFormat("\r\n" + "icls{0}_AddNewRecord iobj{0}_AddNewRecord = new icls{0}_AddNewRecord(vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_AddNewRecord.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_InvokeAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "public void AddNewRecord4GetMaxStrId(Object vcParentView) {");
            strBuilder.AppendFormat("\r\n" + "icls{0}_AddNewRecord4GetMaxStrId iobj{0}_AddNewRecord4GetMaxStrId = new icls{0}_AddNewRecord4GetMaxStrId(vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_AddNewRecord4GetMaxStrId.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_InvokeGetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "public void GetMaxStrId(Object vcParentView) {");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetMaxStrId iobj{0}GetMaxStrId = new icls{0}GetMaxStrId(vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetMaxStrId.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_InvokeGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "public void GetMaxStrIdByPrefix(Object vcParentView) {");
            strBuilder.AppendFormat("\r\n" + "icls{0}GetMaxStrIdByPrefix iobj{0}GetMaxStrIdByPrefix = new icls{0}GetMaxStrIdByPrefix(vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetMaxStrIdByPrefix.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Java_InvokeUpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 修改记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "public void UpdateRecord(Object vcParentView) {");
            strBuilder.AppendFormat("\r\n" + "icls{0}_UpdateRecord iobj{0}_UpdateRecord = new icls{0}_UpdateRecord(vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_UpdateRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
   
    }
}
