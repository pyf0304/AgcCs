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
        public string A_GeneFuncCode_JavaScript_DefButton(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {

                    case "Gen_Controller_JavaScript_DefButtonGetFirstJSONObj":
                        return Gen_Controller_JavaScript_DefButtonGetFirstJSONObj();

                    case "Gen_Controller_JavaScript_DefButtonGetJSONObjByKey":
                        return Gen_Controller_JavaScript_DefButtonGetJSONObjByKey();

                    case "Gen_Controller_JavaScript_DefButtonDelRecord":
                        return Gen_Controller_JavaScript_DefButtonDelRecord();

                    case "Gen_Controller_JavaScript_DefButtonAddNewRecord":
                        return Gen_Controller_JavaScript_DefButtonAddNewRecord();

                    case "Gen_Controller_JavaScript_DefButtonAddNewRecord4GetMaxStrId":
                        return Gen_Controller_JavaScript_DefButtonAddNewRecord4GetMaxStrId();
                    case "Gen_Controller_JavaScript_DefButtonGetMaxStrId":
                        return Gen_Controller_JavaScript_DefButtonGetMaxStrId();
                    case "Gen_Controller_JavaScript_DefButtonGetMaxStrIdByPrefix":
                        return Gen_Controller_JavaScript_DefButtonGetMaxStrIdByPrefix();

                    case "Gen_Controller_JavaScript_DefButtonUpdateRecord":
                        return Gen_Controller_JavaScript_DefButtonUpdateRecord();

                    case "Gen_Controller_JavaScript_DefButtonIsExistRecord":
                        return Gen_Controller_JavaScript_DefButtonIsExistRecord();

                    case "Gen_Controller_JavaScript_DefButtonGetRecCountByCond":
                        return Gen_Controller_JavaScript_DefButtonGetRecCountByCond();

                    case "Gen_Controller_JavaScript_DefButtonGetJSONObjLst":
                        return Gen_Controller_JavaScript_DefButtonGetJSONObjLst();

                    case "Gen_Controller_JavaScript_DefButtonGetTopJSONObjLst":
                        return Gen_Controller_JavaScript_DefButtonGetTopJSONObjLst();

                    case "Gen_Controller_JavaScript_DefButtonGetJSONObjLstByPager":
                        return Gen_Controller_JavaScript_DefButtonGetJSONObjLstByPager();

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
        public string Gen_Controller_JavaScript_DefButtonAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord";
            string strFunctionName_CN = "添加新记录";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />", 
                strFunctionName, strFunctionName_CN);
        
            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord4GetMaxStrId";
            string strFunctionName_CN = "添加新记录(获取最大关键字)";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonGetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrId";
            string strFunctionName_CN = "获取最大关键字值";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);


            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrIdByPrefix";
            string strFunctionName_CN = "获取最大关键字值,根据前缀";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);


            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonUpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "UpdateRecord";
            string strFunctionName_CN = "修改记录";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);


            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecord";
            string strFunctionName_CN = "删除记录";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);


            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_JavaScript_DefButtonIsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "IsExistRecord";
            string strFunctionName_CN = "检查是否存在记录";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);


            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetRecCountByCond";
            string strFunctionName_CN = "根据条件获取记录数";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);

            return strBuilder.ToString();
        }


        public string Gen_Controller_JavaScript_DefButtonGetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjLst";
            string strFunctionName_CN = "获取记录对象列表";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);


            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonGetTopJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetTopJSONObjLst";
            string strFunctionName_CN = "获取顶部记录对象列表";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonGetJSONObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjLstByPager";
            string strFunctionName_CN = "获取分页记录对象列表";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonGetJSONObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetJSONObjByKey";
            string strFunctionName_CN = "根据关键字获取对象";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);

            return strBuilder.ToString();
        }

        public string Gen_Controller_JavaScript_DefButtonGetFirstJSONObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstJSONObj";
            string strFunctionName_CN = "获取满足条件的第一条记录对象";
            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                strFunctionName, strFunctionName_CN);

            return strBuilder.ToString();
        }
        public string Gen_Controller_JavaScript_DefButtonByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            //string strFunctionName_CN = "获取满足条件的第一条记录对象";

            strBuilder.AppendFormat("\r\n" + "<input id=\"btn{0}\" type=\"button\" value=\"{1}\" onclick=\"{0}();\" />",
                objWebSrvFunctionsENEx.FunctionName, objWebSrvFunctionsENEx.FunctionName);

            return strBuilder.ToString();
        }
    }
}
