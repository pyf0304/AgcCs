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
        public string A_GeneFuncCode_Java_BindButton(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {

                    case "Gen_WA_Controller_Java_BindButtonGetFirstObj":
                        return Gen_WA_Controller_Java_BindButtonGetFirstObj();

                    case "Gen_WA_Controller_Java_BindButtonGetObjByKey":
                        return Gen_WA_Controller_Java_BindButtonGetObjByKey();

                    case "Gen_WA_Controller_Java_BindButtonDelRecord":
                        return Gen_WA_Controller_Java_BindButtonDelRecord();

                    case "Gen_WA_Controller_Java_BindButtonDelRecordsByJSON":
                        return Gen_WA_Controller_Java_BindButtonDelRecordsByJSON();

                    case "Gen_WA_Controller_Java_BindButtonAddNewRecord":
                        return Gen_WA_Controller_Java_BindButtonAddNewRecord();

                    case "Gen_WA_Controller_Java_BindButtonAddNewRecord4GetMaxStrId":
                        return Gen_WA_Controller_Java_BindButtonAddNewRecord4GetMaxStrId();
                    case "Gen_WA_Controller_Java_BindButtonGetMaxStrId":
                        return Gen_WA_Controller_Java_BindButtonGetMaxStrId();
                    case "Gen_WA_Controller_Java_BindButtonGetMaxStrIdByPrefix":
                        return Gen_WA_Controller_Java_BindButtonGetMaxStrIdByPrefix();

                    case "Gen_WA_Controller_Java_BindButtonUpdateRecord":
                        return Gen_WA_Controller_Java_BindButtonUpdateRecord();

                    case "Gen_WA_Controller_Java_BindButtonIsExistRecord":
                        return Gen_WA_Controller_Java_BindButtonIsExistRecord();

                    case "Gen_WA_Controller_Java_BindButtonGetRecCountByCond":
                        return Gen_WA_Controller_Java_BindButtonGetRecCountByCond();

                    case "Gen_WA_Controller_Java_BindButtonGetObjLst":
                        return Gen_WA_Controller_Java_BindButtonGetObjLst();

                    case "Gen_WA_Controller_Java_BindButtonGetTopObjLst":
                        return Gen_WA_Controller_Java_BindButtonGetTopObjLst();

                    case "Gen_WA_Controller_Java_BindButtonGetObjLstByPager":
                        return Gen_WA_Controller_Java_BindButtonGetObjLstByPager();
                    case "Gen_WA_Controller_Java_BindButtontvMsg":
                        return Gen_WA_Controller_Java_BindButtontvMsg();
                        
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
        public string Gen_WA_Controller_Java_BindButtonAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord";
            //string strFunctionName_CN = "添加新记录";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);
        
            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord4GetMaxStrId";
            //string strFunctionName_CN = "添加新记录(获取最大关键字)";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonGetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrId";
            //string strFunctionName_CN = "获取最大关键字值";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrIdByPrefix";
            //string strFunctionName_CN = "获取最大关键字值,根据前缀";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonUpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "UpdateRecord";
            //string strFunctionName_CN = "修改记录";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecord";
            //string strFunctionName_CN = "删除记录";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);

            return strBuilder.ToString();
        }
        public string Gen_WA_Controller_Java_BindButtonDelRecordsByJSON()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecordsByJSON";
            //string strFunctionName_CN = "删除记录ByJSON";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);

            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_Controller_Java_BindButtonIsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "IsExistRecord";
            //string strFunctionName_CN = "检查是否存在记录";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetRecCountByCond";
            //string strFunctionName_CN = "根据条件获取记录数";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);


            return strBuilder.ToString();
        }


        public string Gen_WA_Controller_Java_BindButtonGetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetObjLst";
            //string strFunctionName_CN = "获取记录对象列表";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonGetTopObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetTopObjLst";
            //string strFunctionName_CN = "获取顶部记录对象列表";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonGetObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetObjLstByPager";
            //string strFunctionName_CN = "获取分页记录对象列表";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonGetObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetObjByKey";
            //string strFunctionName_CN = "根据关键字获取对象";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonGetFirstObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstObj";
            //string strFunctionName_CN = "获取满足条件的第一条记录对象";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtontvMsg()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstObj";
            //string strFunctionName_CN = "获取满足条件的第一条记录对象";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", strFunctionName);

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_BindButtonByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            //string strFunctionName_CN = "获取满足条件的第一条记录对象";
            strBuilder.AppendFormat("\r\n" + "  btn{0} = (Button) findViewById(R.id.btn{0});", 
                objWebSrvFunctionsENEx.FunctionName);

            return strBuilder.ToString();
        }
    }
}
