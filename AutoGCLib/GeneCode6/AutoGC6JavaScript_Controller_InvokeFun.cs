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
        public string A_GeneFuncCode_JavaScript_InvokeFun(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {

                    case "Gen_Controller_JavaScript_InvokeFunGetFirstJSONObj":
                        return Gen_Controller_JavaScript_InvokeFunGetFirstJSONObj();

                    case "Gen_Controller_JavaScript_InvokeFunGetJSONObjByKey":
                        return Gen_Controller_JavaScript_InvokeFunGetJSONObjByKey();

                    case "Gen_Controller_JavaScript_InvokeFunDelRecord":
                        return Gen_Controller_JavaScript_InvokeFunDelRecord();

                    case "Gen_Controller_JavaScript_InvokeFunAddNewRecord":
                        return Gen_Controller_JavaScript_InvokeFunAddNewRecord();

                    case "Gen_Controller_JavaScript_InvokeFunAddNewRecord4GetMaxStrId":
                        return Gen_Controller_JavaScript_InvokeFunAddNewRecord4GetMaxStrId();
                    case "Gen_Controller_JavaScript_InvokeFunGetMaxStrId":
                        return Gen_Controller_JavaScript_InvokeFunGetMaxStrId();
                    case "Gen_Controller_JavaScript_InvokeFunGetMaxStrIdByPrefix":
                        return Gen_Controller_JavaScript_InvokeFunGetMaxStrIdByPrefix();

                    case "Gen_Controller_JavaScript_InvokeFunUpdateRecord":
                        return Gen_Controller_JavaScript_InvokeFunUpdateRecord();

                    case "Gen_Controller_JavaScript_InvokeFunIsExistRecord":
                        return Gen_Controller_JavaScript_InvokeFunIsExistRecord();

                    case "Gen_Controller_JavaScript_InvokeFunGetRecCountByCond":
                        return Gen_Controller_JavaScript_InvokeFunGetRecCountByCond();

                    case "Gen_Controller_JavaScript_InvokeFunGetJSONObjLst":
                        return Gen_Controller_JavaScript_InvokeFunGetJSONObjLst();

                    case "Gen_Controller_JavaScript_InvokeFunGetTopJSONObjLst":
                        return Gen_Controller_JavaScript_InvokeFunGetTopJSONObjLst();

                    case "Gen_Controller_JavaScript_InvokeFunGetJSONObjLstByPager":
                        return Gen_Controller_JavaScript_InvokeFunGetJSONObjLstByPager();

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
        public string Gen_Controller_JavaScript_InvokeFunAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");
        
            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord4GetMaxStrId";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunGetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrId";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrIdByPrefix";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunUpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "UpdateRecord";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecord";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_JavaScript_InvokeFunIsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "IsExistRecord";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetRecCountByCond";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_Controller_JavaScript_InvokeFunGetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjLst";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunGetTopJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetTopJSONObjLst";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunGetJSONObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjLstByPager";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunGetJSONObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjByKey";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_InvokeFunGetFirstJSONObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstJSONObj";
            strBuilder.AppendFormat("\r\n" + "function {0}()", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", strFunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}_UnitTest = new ac{0}_UnitTest();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}_UnitTest.btn{1}_Click();", objPrjTabENEx.TabName, strFunctionName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        public string Gen_Controller_JavaScript_InvokeFunByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            //string strFunctionName_CN = "获取满足条件的第一条记录对象";
            strBuilder.AppendFormat("\r\n" + "function {0}()", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "alert(\"{0}()\");", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n" + "const obj{0}4SD_UnitTest = new vc{0}4SD_UnitTest();", objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "obj{0}4SD_UnitTest.btn{1}_Click();", objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }
    }
}
