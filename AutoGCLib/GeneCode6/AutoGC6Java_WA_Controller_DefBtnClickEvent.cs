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
    partial class AutoGC6_WA_Controller : AutoGCPubFuncV6
    {
        public string A_GeneFuncCode_Java_DefBtnClickEvent(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {

                    case "Gen_WA_Controller_Java_DefBtnClickEventGetFirstObj":
                        return Gen_WA_Controller_Java_DefBtnClickEventGetFirstObj();

                    case "Gen_WA_Controller_Java_DefBtnClickEventGetObjByKey":
                        return Gen_WA_Controller_Java_DefBtnClickEventGetObjByKey();

                    case "Gen_WA_Controller_Java_DefBtnClickEventDelRecord":
                        return Gen_WA_Controller_Java_DefBtnClickEventDelRecord();
                    case "Gen_WA_Controller_Java_DefBtnClickEventDelRecordsByJSON":
                        return Gen_WA_Controller_Java_DefBtnClickEventDelRecordsByJSON();
                        
                    case "Gen_WA_Controller_Java_DefBtnClickEventAddNewRecord":
                        return Gen_WA_Controller_Java_DefBtnClickEventAddNewRecord();

                    case "Gen_WA_Controller_Java_DefBtnClickEventAddNewRecord4GetMaxStrId":
                        return Gen_WA_Controller_Java_DefBtnClickEventAddNewRecord4GetMaxStrId();
                    case "Gen_WA_Controller_Java_DefBtnClickEventGetMaxStrId":
                        return Gen_WA_Controller_Java_DefBtnClickEventGetMaxStrId();
                    case "Gen_WA_Controller_Java_DefBtnClickEventGetMaxStrIdByPrefix":
                        return Gen_WA_Controller_Java_DefBtnClickEventGetMaxStrIdByPrefix();

                    case "Gen_WA_Controller_Java_DefBtnClickEventUpdateRecord":
                        return Gen_WA_Controller_Java_DefBtnClickEventUpdateRecord();

                    case "Gen_WA_Controller_Java_DefBtnClickEventIsExistRecord":
                        return Gen_WA_Controller_Java_DefBtnClickEventIsExistRecord();

                    case "Gen_WA_Controller_Java_DefBtnClickEventGetRecCountByCond":
                        return Gen_WA_Controller_Java_DefBtnClickEventGetRecCountByCond();

                    case "Gen_WA_Controller_Java_DefBtnClickEventGetObjLst":
                        return Gen_WA_Controller_Java_DefBtnClickEventGetObjLst();

                    case "Gen_WA_Controller_Java_DefBtnClickEventGetTopObjLst":
                        return Gen_WA_Controller_Java_DefBtnClickEventGetTopObjLst();

                    case "Gen_WA_Controller_Java_DefBtnClickEventGetObjLstByPager":
                        return Gen_WA_Controller_Java_DefBtnClickEventGetObjLstByPager();
                    case "Gen_WA_Controller_Java_DefBtnClickEventtvMsg":
                        return Gen_WA_Controller_Java_DefBtnClickEventtvMsg();
                        
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
        public string Gen_WA_Controller_Java_DefBtnClickEventAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");
            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord4GetMaxStrId";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventGetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrId";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrIdByPrefix";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventUpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "UpdateRecord";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }
        public string Gen_WA_Controller_Java_DefBtnClickEventDelRecordsByJSON()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecordsByJSON";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecord";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_Controller_Java_DefBtnClickEventIsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "IsExistRecord";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetRecCountByCond";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }


        public string Gen_WA_Controller_Java_DefBtnClickEventGetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetObjLst";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventGetTopObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetTopObjLst";

            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventGetObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetObjLstByPager";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventGetObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetObjByKey";

            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventGetFirstObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstObj";

            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventtvMsg()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstObj";
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", strFunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", strFunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DefBtnClickEventByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            
            strBuilder.AppendFormat("\r\n" + "btn{0}.setOnClickListener(new View.OnClickListener() ", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "@Override");
            strBuilder.Append("\r\n" + "public void onClick(View v) {");
            strBuilder.AppendFormat("\r\n" + "btn{0}_Click();", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");
                   

            return strBuilder.ToString();
        }
    }
}
