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
using AgcCommBase;
using System.Reflection;

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
    partial class AppController4Swift4Base : clsGeneCodeBase4Tab
    {      


        public string Gen_Controller_Swift4_InvokeGetJSONObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字获取相应的记录的对象");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">调用该函数的父界面对象</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "func invokeGetJSONObjByKey(vcParentView : NSObject) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetObjBy{1} : icls{0}GetObjBy{1} = icls{0}GetObjBy{1}(pvcParent: vcParentView);",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetObjBy{1}.main();",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_InvokeGetFirstJSONObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的第一条记录的对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">调用该函数的父界面对象</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "func invokeGetFirstJSONObj(vcParentView : NSObject) {");

            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetFirstObj : icls{0}GetFirstObj = icls{0}GetFirstObj(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetFirstObj.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_InvokeByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
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
                    strMsg = string.Format("Swift函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
                       objWebSrvFuncParaEN.ParaName,
                         objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);
                }
            }
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 调用函数：[{0}]", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">调用该函数的父界面对象</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "func Invoke{0}(vcParentView : NSObject) ",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}_{1} : icls{0}_{1} = icls{0}_{1}(pvcParent: vcParentView);",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_{1}.main();",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
              
        public string Gen_Controller_Swift4_InvokeGetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">调用该函数的父界面对象</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "func invokeGetJSONObjLst(vcParentView : NSObject) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetJSONObjLst : icls{0}GetJSONObjLst = icls{0}GetJSONObjLst(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_Controller_Swift4_InvokeGetTopJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的顶部多条对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">调用该函数的父界面对象</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "func invokeGetTopJSONObjLst(vcParentView : NSObject) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetTopJSONObjLst : icls{0}GetTopJSONObjLst = icls{0}GetTopJSONObjLst(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetTopJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
          
            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_InvokeGetJSONObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的分页多条对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">调用该函数的父界面对象</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "func invokeGetJSONObjLstByPager(vcParentView : NSObject) ",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetJSONObjLstByPager : icls{0}GetJSONObjLstByPager = icls{0}GetJSONObjLstByPager(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetJSONObjLstByPager.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Swift4_InvokeIsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查相应关键字的记录是否存在");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">调用该函数的父界面对象</param>");
            strBuilder.Append("\r\n /// <returns>返回是否存在</returns>");

            strBuilder.Append("\r\n" + "func invokeIsExistRecord(vcParentView : NSObject) {");

            strBuilder.AppendFormat("\r\n" + "let iobj{0}_IsExistRecord : icls{0}_IsExistRecord = icls{0}_IsExistRecord(pvcParent: vcParentView);",
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
        public string Gen_Controller_Swift4_InvokeGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取表中相应的记录数");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">调用该函数的父界面对象</param>");
            strBuilder.Append("\r\n /// <returns>返回记录数</returns>");

            strBuilder.Append("\r\n" + "func invokeGetRecCountByCond(vcParentView : NSObject) {");

            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetRecCountByCond : icls{0}GetRecCountByCond = icls{0}GetRecCountByCond(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetRecCountByCond.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_InvokeDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 删除记录");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">调用该函数的父界面对象</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "func invokeDelRecord(vcParentView : NSObject) {");

            strBuilder.AppendFormat("\r\n" + "let iobj{0}_DelRecord : icls{0}_DelRecord = icls{0}_DelRecord(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_DelRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        /// <summary>
        /// 继承Runnable类必须实现的【run】函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_Controller_Swift4_InvokeAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">调用该函数的父界面对象</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "func invokeAddNewRecord(vcParentView : NSObject) {");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}_AddNewRecord : icls{0}_AddNewRecord = icls{0}_AddNewRecord(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_AddNewRecord.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_InvokeAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">调用该函数的父界面对象</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "func invokeAddNewRecord4GetMaxStrId(vcParentView : NSObject) {");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}_AddNewRecord4GetMaxStrId : icls{0}_AddNewRecord4GetMaxStrId = icls{0}_AddNewRecord4GetMaxStrId(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_AddNewRecord4GetMaxStrId.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_InvokeGetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">调用该函数的父界面对象</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "func invokeGetMaxStrId(vcParentView : NSObject) {");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetMaxStrId : icls{0}GetMaxStrId = icls{0}GetMaxStrId(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetMaxStrId.main();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_Controller_Swift4_InvokeGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">调用该函数的父界面对象</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "func invokeGetMaxStrIdByPrefix(vcParentView : NSObject) {");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}GetMaxStrIdByPrefix : icls{0}GetMaxStrIdByPrefix = icls{0}GetMaxStrIdByPrefix(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}GetMaxStrIdByPrefix.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

      

        public string Gen_Controller_Swift4_InvokeUpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 修改记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"vcParentView\">调用该函数的父界面对象</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "func invokeUpdateRecord(vcParentView : NSObject) {");
            strBuilder.AppendFormat("\r\n" + "let iobj{0}_UpdateRecord : icls{0}_UpdateRecord = icls{0}_UpdateRecord(pvcParent: vcParentView);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "iobj{0}_UpdateRecord.main();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        public string A_GeneFuncCode_Swift4_Invoke(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {


                    case "Gen_Controller_Swift4_InvokeGetFirstJSONObj":
                    case "Gen_Controller_Swift4_InvokeGetFirstJSONObj_Click4tvc":
                        return Gen_Controller_Swift4_InvokeGetFirstJSONObj();

                    case "Gen_Controller_Swift4_InvokeGetJSONObjByKey":
                    case "Gen_Controller_Swift4_InvokeGetJSONObjByKey_Click4tvc":
                        return Gen_Controller_Swift4_InvokeGetJSONObjByKey();


                    case "Gen_Controller_Swift4_InvokeDelRecord":
                    case "Gen_Controller_Swift4_InvokeDelRecord_Click4tvc":
                        return Gen_Controller_Swift4_InvokeDelRecord();


                    case "Gen_Controller_Swift4_InvokeAddNewRecord":
                    case "Gen_Controller_Swift4_InvokeAddNewRecord_Click4tvc":
                        return Gen_Controller_Swift4_InvokeAddNewRecord();


                    case "Gen_Controller_Swift4_InvokeAddNewRecord4GetMaxStrId":
                    case "Gen_Controller_Swift4_InvokeAddNewRecord4GetMaxStrId_Click4tvc":
                        return Gen_Controller_Swift4_InvokeAddNewRecord4GetMaxStrId();
                    case "Gen_Controller_Swift4_InvokeGetMaxStrId":
                    case "Gen_Controller_Swift4_InvokeGetMaxStrId_Click4tvc":
                        return Gen_Controller_Swift4_InvokeGetMaxStrId();
                    case "Gen_Controller_Swift4_InvokeGetMaxStrIdByPrefix":
                    case "Gen_Controller_Swift4_InvokeGetMaxStrIdByPrefix_Click4tvc":
                        return Gen_Controller_Swift4_InvokeGetMaxStrIdByPrefix();


                    case "Gen_Controller_Swift4_InvokeUpdateRecord":
                    case "Gen_Controller_Swift4_InvokeUpdateRecord_Click4tvc":
                        return Gen_Controller_Swift4_InvokeUpdateRecord();

                    case "Gen_Controller_Swift4_InvokeIsExistRecord":
                    case "Gen_Controller_Swift4_InvokeIsExistRecord_Click4tvc":
                        return Gen_Controller_Swift4_InvokeIsExistRecord();

                    case "Gen_Controller_Swift4_InvokeGetRecCountByCond":          
                        return Gen_Controller_Swift4_InvokeGetRecCountByCond();

                    case "Gen_Controller_Swift4_InvokeGetJSONObjLst":
                    case "Gen_Controller_Swift4_InvokeGetJSONObjLst_Click4tvc":
                        return Gen_Controller_Swift4_InvokeGetJSONObjLst();
                    case "Gen_Controller_Swift4_InvokeGetTopJSONObjLst":
                    case "Gen_Controller_Swift4_InvokeGetTopJSONObjLst_Click4tvc":
                        return Gen_Controller_Swift4_InvokeGetTopJSONObjLst();

                    case "Gen_Controller_Swift4_InvokeGetJSONObjLstByPager":
                        return Gen_Controller_Swift4_InvokeGetJSONObjLstByPager();

                    default:
                        string strMsg = string.Format("功能名:{1}在Switch没有处理,请检查!({0})",
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
      

     }
}
