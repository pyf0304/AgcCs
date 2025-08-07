using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;

using com.taishsoft.commexception;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

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
    partial class WA_Access4Swift4 : clsGeneCodeBase4Tab
    {
        #region 构造函数

        public WA_Access4Swift4(string strTabId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        #endregion
        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjByKey_Swift4()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字获取相应的记录的对象");
            strBuilder.AppendFormat("\r\n /// mapParam样例:{0} = \"01\"", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjBy{1}\", values, null);",
                  objPrjTabENEx.TabName,
                  objKeyField.FldName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "private func GetJSONObjBy{1}(mapParam : Dictionary<String, String>) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetJSONObjBy{1}\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "CallWebApi(strFunctionName: MethodName, dictPara: mapParam);");

            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let objException as NSException");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "let strMsg : String = \"在调用WebApi函数时出错,错误信息：\\(String(describing: objException.reason))\";");
            //strBuilder.Append("\r\n" + "throw tzErrorType(reason: strMsg);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjLst_Swift4()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的记录对象列表");
            strBuilder.AppendFormat("\r\n /// mapParam样例: mapParam.put(\"strWhereCond\", \"1 = 1\");");
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjLst\", values, null);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns>获取的相应记录对象列表</returns>");
            strBuilder.AppendFormat("\r\n" + "private func GetJSONObjLst( mapParam : Dictionary<String, String>) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetJSONObjLst\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "CallWebApi(strFunctionName: MethodName, dictPara: mapParam);");

            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let objException as NSException");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "let strMsg : String = \"在调用WebApi函数时出错,错误信息：\\(String(describing: objException.reason))\";");
            //strBuilder.Append("\r\n" + "throw tzErrorType(reason: strMsg);");
            //strBuilder.Append("\r\n" + "}");



            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetTopObjLst_Swift4()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的记录对象列表");
            strBuilder.AppendFormat("\r\n /// mapParam样例: mapParam.put(\"strWhereCond\", \"1 = 1\");");
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetTopJSONObjLst\", values, null);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns>获取的相应记录对象列表</returns>");
            strBuilder.AppendFormat("\r\n" + "private func GetTopJSONObjLst( mapParam : Dictionary<String, String>) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetTopJSONObjLst\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "CallWebApi(strFunctionName: MethodName, dictPara: mapParam);");

            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let objException as NSException");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "let strMsg : String = \"在调用WebApi函数时出错,错误信息：\\(String(describing: objException.reason))\";");
            //strBuilder.Append("\r\n" + "throw tzErrorType(reason: strMsg);");
            //strBuilder.Append("\r\n" + "}");



            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjLstByPager_Swift4()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的记录对象列表");
            strBuilder.AppendFormat("\r\n /// mapParam样例: mapParam.put(\"strWhereCond\", \"1 = 1\");");
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjLstByPager\", values, null);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns>获取的相应记录对象列表</returns>");
            strBuilder.AppendFormat("\r\n" + "private func GetJSONObjLstByPager( mapParam : Dictionary<String, String>) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetJSONObjLstByPager\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "CallWebApi(strFunctionName: MethodName, dictPara: mapParam);");

            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let objException as NSException");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "let strMsg : String = \"在调用WebApi函数时出错,错误信息：\\(String(describing: objException.reason))\";");
            //strBuilder.Append("\r\n" + "throw tzErrorType(reason: strMsg);");
            //strBuilder.Append("\r\n" + "}");



            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 调用WebApi来修改记录,数据传递使用JSON串
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_UpdateRecord_Swift4()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 调用WebApi来修改记录,数据传递使用JSON串");
            strBuilder.AppendFormat("\r\n /// mapParam样例:无", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"UpdateRecordByJSON\", values, obj{0}EN);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "private func UpdateRecordByJSON(mapParam : Dictionary<String, String>, obj{0}EN : cls{0}EN) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const myMapParam = mapParam;");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"{0}_UpdateBySql2ByJSON\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);


            strBuilder.AppendFormat("\r\n" + "let strJSON : String = cls{0}BL.GetJSONStrByObj(obj{0}EN: obj{0}EN);",
                      objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "myMapParam[\"str{0}JSONObj\"] = strJSON;",
              objPrjTabENEx.TabName);

            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "CallWebApi(strFunctionName: MethodName, dictPara: myMapParam);");

            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let objException as NSException");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "let strMsg : String = \"在调用WebApi函数时出错,错误信息：\\(String(describing: objException.reason))\";");
            //strBuilder.Append("\r\n" + "throw tzErrorType(reason: strMsg);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 继承Runnable类必须实现的【run】函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_main_Swift4_SelfDefWA()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 继承Runnable类必须实现的【run】函数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "override public func main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if self.isCancelled {");
            strBuilder.Append("\r\n" + "return");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "switch (MethodName)");
            strBuilder.Append("\r\n" + "{");
            int intIndex = 50;
            foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
            {
                if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                strBuilder.AppendFormat("\r\n" + "case \"{0}\":",
                objWebSrvFunctionsENEx.FunctionName);

                strBuilder.AppendFormat("\r\n" + "{0}WS.ResponseData.what = {1};",
                    objWebSrvClassENEx.ClsName, intIndex);
                //strBuilder.Append("\r\n" + "do");
                //strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + " {0}(mapParam: Param);",
                    objWebSrvFunctionsENEx.FunctionName);
                //strBuilder.Append("\r\n" + "}");
                //strBuilder.Append("\r\n" + "catch let err as tzErrorType");
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.Append("\r\n" + "print(err);");
                //strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "break;");
                intIndex++;
            }
            strBuilder.Append("\r\n" + "default:");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_IsExistRecord_Swift4()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的记录对象列表");
            strBuilder.AppendFormat("\r\n /// mapParam样例: mapParam.put(\"strWhereCond\", \"{0} = '01'\");",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjLst\", values, null);",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns>获取的相应记录对象列表</returns>");
            strBuilder.AppendFormat("\r\n" + "private func IsExistRecord( mapParam : Dictionary<String, String>) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"{0}_IsExistRecord\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "CallWebApi(strFunctionName: MethodName, dictPara: mapParam);");

            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let objException as NSException");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "let strMsg : String = \"在调用WebApi函数时出错,错误信息：\\(String(describing: objException.reason))\";");
            //strBuilder.Append("\r\n" + "throw tzErrorType(reason: strMsg);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetRecCountByCond_Swift4()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取某一条件的记录数");
            strBuilder.AppendFormat("\r\n /// mapParam样例: mapParam.put(\"strWhereCond\", \"{0} = '01'\");",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjLst\", values, null);",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns>获取某一条件的记录数</returns>");
            strBuilder.AppendFormat("\r\n" + "private func GetRecCountByCond( mapParam : Dictionary<String, String>) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"{0}GetRecCountByCond\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "CallWebApi(strFunctionName: MethodName, dictPara: mapParam);");

            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let objException as NSException");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "let strMsg : String = \"在调用WebApi函数时出错,错误信息：\\(String(describing: objException.reason))\";");
            //strBuilder.Append("\r\n" + "throw tzErrorType(reason: strMsg);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetFirstObj_Swift4()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的记录对象列表");
            strBuilder.AppendFormat("\r\n /// mapParam样例: mapParam.put(\"strWhereCond\", \"1 = 1\");");
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjLst\", values, null);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns>获取的相应记录对象列表</returns>");
            strBuilder.AppendFormat("\r\n" + "private func GetFirstJSONObj( mapParam : Dictionary<String, String>) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetFirstJSONObj\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + " CallWebApi(strFunctionName: MethodName, dictPara: mapParam);");

            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let objException as NSException");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "let strMsg : String = \"在调用WebApi函数时出错,错误信息：\\(String(describing: objException.reason))\";");
            //strBuilder.Append("\r\n" + "throw tzErrorType(reason: strMsg);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetMaxStrId_Swift4()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的记录对象列表");
            strBuilder.AppendFormat("\r\n /// mapParam样例: mapParam.put(\"strWhereCond\", \"1 = 1\");");
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjLst\", values, null);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns>获取的相应记录对象列表</returns>");
            strBuilder.AppendFormat("\r\n" + "private func GetMaxStrId( mapParam : Dictionary<String, String>) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"{0}GetMaxStrId\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + " CallWebApi(strFunctionName: MethodName, dictPara: mapParam);");

            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let objException as NSException");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "let strMsg : String = \"在调用WebApi函数时出错,错误信息：\\(String(describing: objException.reason))\";");
            //strBuilder.Append("\r\n" + "throw tzErrorType(reason: strMsg);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetMaxStrIdByPrefix_Swift4()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns>获取的相应记录对象列表</returns>");
            strBuilder.AppendFormat("\r\n" + "private func GetMaxStrIdByPrefix( mapParam : Dictionary<String, String>) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"{0}GetMaxStrIdByPrefix\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + " CallWebApi(strFunctionName: MethodName, dictPara: mapParam);");

            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let objException as NSException");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "let strMsg : String = \"在调用WebApi函数时出错,错误信息：\\(String(describing: objException.reason))\";");
            //strBuilder.Append("\r\n" + "throw tzErrorType(reason: strMsg);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 通用的调用WebApi函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_CallWebApi_Swift4()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 通用的调用WebApi函数");
            strBuilder.AppendFormat("\r\n /// mapParam样例:{0} = \"01\"", objKeyField.PrivFuncName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"MethodName\">函数</param>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.Append("\r\n" + "func CallWebApi(strFunctionName:String, dictPara: Dictionary<String, String>)  ");
            strBuilder.Append("\r\n" + "{");
            //strFunctionName = "mySum";
            strBuilder.Append("\r\n" + "const strPara:String!");
            strBuilder.Append("\r\n" + "strPara = \"\";");
            strBuilder.Append("\r\n" + "for (key, value) in dictPara {");
            strBuilder.Append("\r\n" + "let strTemp = \" <\\(key)>\\(value)</\\(key)> \";");
            strBuilder.Append("\r\n" + "strPara = strPara + strTemp;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "let url8: NSURL = NSURL(string : WEB_SERVICE_URL)!");
            strBuilder.Append("\r\n" + "let soapMsg = \"<?xml version='1.0' encoding='utf-8'?><soap:Envelope xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:xsd='http://www.w3.org/2001/XMLSchema' xmlns:soap='http://schemas.xmlsoap.org/soap/envelope/'> <soap:Body><\\(strFunctionName) xmlns='http://tempuri.org/' >\\(strPara!)</\\(strFunctionName)></soap:Body></soap:Envelope>\"");
            strBuilder.Append("\r\n" + "let request = NSMutableURLRequest(url: url8 as URL)");
            strBuilder.Append("\r\n" + "let msgLength = String(soapMsg.characters.count)");
            strBuilder.Append("\r\n" + "request.httpMethod = \"POST\"");
            strBuilder.Append("\r\n" + "request.httpBody = soapMsg.data(using: String.Encoding.utf8, allowLossyConversion: false)");
            strBuilder.Append("\r\n" + "request.addValue(\"text/xml; charset=utf-8\", forHTTPHeaderField: \"Content-Type\")");
            strBuilder.Append("\r\n" + "request.addValue(msgLength, forHTTPHeaderField: \"Content-Length\")");
            strBuilder.Append("\r\n" + "request.addValue(\"\\(WEB_SERVICE_URL)/\\(strFunctionName)\", forHTTPHeaderField: \"Action\")");
            strBuilder.Append("\r\n" + "let session = URLSession.shared");
            strBuilder.Append("\r\n" + "let task = session.dataTask(with: request as URLRequest) {");
            strBuilder.Append("\r\n" + "(data, response, error) in");
            strBuilder.Append("\r\n" + "guard error == nil else {");
            strBuilder.Append("\r\n" + "print(\"error calling GET on /todos/1\")");
       //     strBuilder.Append("\r\n" + "print(error)");
            strBuilder.Append("\r\n" + "return");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "guard let responseData = data else {");
            strBuilder.Append("\r\n" + "print(\"Error: did not receive data\")");
            strBuilder.Append("\r\n" + "return");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "let xmlData = responseData;// NSData(contentsOfFile: strPathXml!)");
            strBuilder.Append("\r\n" + "let strReturnData = NSString(data: xmlData, encoding: String.Encoding.utf8.rawValue)");

            //     let range = strReturnData?.range(of: "<soap:Body>");
            strBuilder.Append("\r\n" + "  let bolIsExist = (strReturnData! as NSString).contains(\"<soap:Body>\");");

            //            let intStartIndex = range.?.startIndex;
            strBuilder.Append("\r\n" + "if (bolIsExist == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let range2 = strReturnData?.range(of: \"<html>\");");

            strBuilder.Append("\r\n" + "let range3 = strReturnData?.range(of: \"无法找到资源\");");
            strBuilder.Append("\r\n" + "if (range3 != nil && range2 != nil)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.IsFinished = true;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.errorId = 3;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.faultString = \"无法找到资源. URL=[\\(self.WEB_SERVICE_URL)]\";",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "self.cancel();");
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "if (range2 != nil)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.IsFinished = true;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.errorId = 4;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.faultString = \"无法找到资源. URL=[\\(self.WEB_SERVICE_URL)]\";",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "self.cancel();");
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//输出json字符串");
            strBuilder.Append("\r\n" + "// print(\"Json Str: \"); print(strReturnData)");
            strBuilder.Append("\r\n" + "let strFaultString = clsPubFun.getResponseFaultString(strResponse: strReturnData!);");
            strBuilder.Append("\r\n" + "if (strFaultString.lengthOfBytes(using: String.Encoding.utf8) > 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.IsFinished = true;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.errorId = 1;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.faultString = strFaultString;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "self.cancel();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strResult = clsPubFun.getResponseContent(strResponse: strReturnData!, strFunctionName: strFunctionName)");
            strBuilder.Append("\r\n" + "print(\"Json strResult: \"); print(strResult)");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.errorId = 0;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.IsFinished = true;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.data = strResult;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "self.cancel();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "task.resume()");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 通用的调用WebApi函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_CallWebApi_Swift4_SelfDefWs()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 通用的调用WebApi函数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"MethodName\">函数</param>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.Append("\r\n" + "func CallWebApi(strFunctionName:String, dictPara: Dictionary<String, String>)  ");
            strBuilder.Append("\r\n" + "{");
            //strFunctionName = "mySum";
            strBuilder.Append("\r\n" + "const strPara:String!");
            strBuilder.Append("\r\n" + "strPara = \"\";");
            strBuilder.Append("\r\n" + "for (key, value) in dictPara {");
            strBuilder.Append("\r\n" + "let strTemp = \" <\\(key)>\\(value)</\\(key)> \";");
            strBuilder.Append("\r\n" + "strPara = strPara + strTemp;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "let url8: NSURL = NSURL(string : WEB_SERVICE_URL)!");
            strBuilder.Append("\r\n" + "let soapMsg = \"<?xml version='1.0' encoding='utf-8'?><soap:Envelope xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:xsd='http://www.w3.org/2001/XMLSchema' xmlns:soap='http://schemas.xmlsoap.org/soap/envelope/'> <soap:Body><\\(strFunctionName) xmlns='http://tempuri.org/' >\\(strPara!)</\\(strFunctionName)></soap:Body></soap:Envelope>\"");
            strBuilder.Append("\r\n" + "let request = NSMutableURLRequest(url: url8 as URL)");
            strBuilder.Append("\r\n" + "let msgLength = String(soapMsg.characters.count)");
            strBuilder.Append("\r\n" + "request.httpMethod = \"POST\"");
            strBuilder.Append("\r\n" + "request.httpBody = soapMsg.data(using: String.Encoding.utf8, allowLossyConversion: false)");
            strBuilder.Append("\r\n" + "request.addValue(\"text/xml; charset=utf-8\", forHTTPHeaderField: \"Content-Type\")");
            strBuilder.Append("\r\n" + "request.addValue(msgLength, forHTTPHeaderField: \"Content-Length\")");
            strBuilder.Append("\r\n" + "request.addValue(\"\\(WEB_SERVICE_URL)/\\(strFunctionName)\", forHTTPHeaderField: \"Action\")");
            strBuilder.Append("\r\n" + "let session = URLSession.shared");
            strBuilder.Append("\r\n" + "let task = session.dataTask(with: request as URLRequest) {");
            strBuilder.Append("\r\n" + "(data, response, error) in");
            strBuilder.Append("\r\n" + "guard error == nil else {");
            strBuilder.Append("\r\n" + "print(\"error calling GET on /todos/1\")");
            //strBuilder.Append("\r\n" + "print(error)");
            strBuilder.Append("\r\n" + "return");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "guard let responseData = data else {");
            strBuilder.Append("\r\n" + "print(\"Error: did not receive data\")");
            strBuilder.Append("\r\n" + "return");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "let xmlData = responseData;// NSData(contentsOfFile: strPathXml!)");
            strBuilder.Append("\r\n" + "let strReturnData = NSString(data: xmlData, encoding: String.Encoding.utf8.rawValue)");


            //     let range = strReturnData?.range(of: "<soap:Body>");
            strBuilder.Append("\r\n" + "  let bolIsExist = (strReturnData! as NSString).contains(\"<soap:Body>\");");

            //            let intStartIndex = range.?.startIndex;
            strBuilder.Append("\r\n" + "if (bolIsExist == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let range2 = strReturnData?.range(of: \"<html>\");");

            strBuilder.Append("\r\n" + "let range3 = strReturnData?.range(of: \"无法找到资源\");");
            strBuilder.Append("\r\n" + "if (range3 != nil && range2 != nil)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}WS.ResponseData.IsFinished = true;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}WS.ResponseData.errorId = 3;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}WS.ResponseData.faultString = \"无法找到资源. URL=[\\(self.WEB_SERVICE_URL)]\";",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "self.cancel();");
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "if (range2 != nil)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}WS.ResponseData.IsFinished = true;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}WS.ResponseData.errorId = 4;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}WS.ResponseData.faultString = \"无法找到资源. URL=[\\(self.WEB_SERVICE_URL)]\";",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "self.cancel();");
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//输出json字符串");
            strBuilder.Append("\r\n" + "// print(\"Json Str: \"); print(strReturnData)");
            strBuilder.Append("\r\n" + "let strFaultString = clsPubFun.getResponseFaultString(strResponse: strReturnData!);");
            strBuilder.Append("\r\n" + "if (strFaultString.lengthOfBytes(using: String.Encoding.utf8) > 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}WS.ResponseData.IsFinished = true;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}WS.ResponseData.errorId = 1;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}WS.ResponseData.faultString = strFaultString;",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "self.cancel();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strResult = clsPubFun.getResponseContent(strResponse: strReturnData!, strFunctionName: strFunctionName)");
            strBuilder.Append("\r\n" + "print(\"Json strResult: \"); print(strResult)");
            strBuilder.AppendFormat("\r\n" + "{0}WS.ResponseData.errorId = 0;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}WS.ResponseData.IsFinished = true;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}WS.ResponseData.data = strResult;",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "self.cancel();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "task.resume()");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 继承Runnable类必须实现的【run】函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_main_Swift4()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 继承Runnable类必须实现的【run】函数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "override public func main()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if self.isCancelled {");
            strBuilder.Append("\r\n" + "return");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "switch (MethodName)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "case \"GetJSONObjBy{1}\":",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.what = 1;",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + " GetJSONObjBy{1}(mapParam: Param);",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let err as tzErrorType");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "print(err);");
            //strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"GetJSONObjLst\":",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.what = 2;",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + " GetJSONObjLst(mapParam: Param);",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let err as tzErrorType");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "print(err);");
            //strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                strBuilder.Append("\r\n" + "case \"AddNewRecordByJSON\":");
                strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.what = 3;",
                    objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "do");
                //strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + " AddNewRecordByJSON(mapParam: Param, obj{0}EN: obj{0}EN);",
                    objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "}");
                //strBuilder.Append("\r\n" + "catch let err as tzErrorType");
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.Append("\r\n" + "print(err);");
                //strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "break;");
                strBuilder.Append("\r\n" + "case \"UpdateRecordByJSON\":");
                strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.what = 4;",
                    objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "do");
                //strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + " UpdateRecordByJSON(mapParam: Param, obj{0}EN: obj{0}EN);",
                    objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "}");
                //strBuilder.Append("\r\n" + "catch let err as tzErrorType");
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.Append("\r\n" + "print(err);");
                //strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "break;");
                strBuilder.Append("\r\n" + "case \"DelRecord\":");
                strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.what = 5;",
                    objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "do");
                //strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "DelRecord(mapParam: Param);");
                //strBuilder.Append("\r\n" + "}");
                //strBuilder.Append("\r\n" + "catch let err as tzErrorType");
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.Append("\r\n" + "print(err);");
                //strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "break;");
            }
            strBuilder.AppendFormat("\r\n" + "case \"GetFirstJSONObj\":",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.what = 6;",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + " GetFirstJSONObj(mapParam: Param);",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let err as tzErrorType");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "print(err);");
            //strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"IsExistRecord\":",
    objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.what = 7;",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + " IsExistRecord(mapParam: Param);",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let err as tzErrorType");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "print(err);");
            //strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"GetMaxStrId\":",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.what = 8;",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + " GetMaxStrId(mapParam: Param);",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let err as tzErrorType");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "print(err);");
            //strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.AppendFormat("\r\n" + "case \"GetMaxStrIdByPrefix\":",
             objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.what = 9;",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + " GetMaxStrIdByPrefix(mapParam: Param);",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let err as tzErrorType");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "print(err);");
            //strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"GetTopJSONObjLst\":",
  objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.what = 10;",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + " GetTopJSONObjLst(mapParam: Param);",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let err as tzErrorType");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "print(err);");
            //strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"GetJSONObjLstByPager\":",
          objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.what = 11;",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + " GetJSONObjLstByPager(mapParam: Param);",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let err as tzErrorType");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "print(err);");
            //strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.AppendFormat("\r\n" + "case \"GetRecCountByCond\":",
         objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData.what = 12;",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + " GetRecCountByCond(mapParam: Param);",
                objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let err as tzErrorType");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "print(err);");
            //strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "default:");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 继承Runnable类必须实现的【run】函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_start_Swift4()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 继承Runnable类必须实现的【run】函数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "override public func start()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "super.start();");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 调用WebApi来添加记录,数据传递使用JSON串
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_AddNewRecord_Swift4()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 调用WebApi来添加记录,数据传递使用JSON串");
            strBuilder.AppendFormat("\r\n /// mapParam样例:无", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"AddNewRecordByJSON\", values, obj{0}EN);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "private func AddNewRecordByJSON(mapParam : Dictionary<String, String>, obj{0}EN : cls{0}EN) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const myMapParam = mapParam;");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"{0}_AddNewRecordBySql2ByJSON\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);

            strBuilder.AppendFormat("\r\n" + "let strJSON : String = cls{0}BL.GetJSONStrByObj(obj{0}EN: obj{0}EN);",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "myMapParam[\"str{0}JSONObj\"] = strJSON;",
              objPrjTabENEx.TabName);

            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + " CallWebApi(strFunctionName: MethodName, dictPara: myMapParam);");

            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let objException as NSException");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "let strMsg : String = \"在调用WebApi函数时出错,错误信息：\\(String(describing: objException.reason))\";");
            //strBuilder.Append("\r\n" + "throw tzErrorType(reason: strMsg);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 调用WebApi来删除记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_DelRecord_Swift4()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 调用WebApi来删除记录");
            strBuilder.AppendFormat("\r\n /// mapParam样例:{0} = \"01\"", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"DelRecord\", values, null);",
                 objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "private func DelRecord( mapParam : Dictionary<String, String>) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"{0}_DelRecord\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + " CallWebApi(strFunctionName: MethodName, dictPara: mapParam);");

            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let objException as NSException");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "let strMsg : String = \"在调用WebApi函数时出错,错误信息：\\(String(describing: objException.reason))\";");
            //strBuilder.Append("\r\n" + "throw tzErrorType(reason: strMsg);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成Web Service转换层代码--Swift2
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
                       objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                              objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;           

            objPrjTabENEx.ClsName = string.Format("cls{0}WApi", objPrjTabENEx.TabName);;
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebApiTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strBuilder.AppendFormat("\r\n" + "import Foundation",
                      objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName);


                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* 注意:该类必须与调用界面处于同一个包,否则调用不成功!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strBuilder.Append("\r\n" + "*/");
                strBuilder.AppendFormat("\r\n" + "class  {0} : Operation, URLSessionDelegate, URLSessionDataDelegate , XMLParserDelegate",
                  objPrjTabENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "public static var ResponseData : tzResponseData!");
                strBuilder.Append("\r\n" + "private var Param : Dictionary<String, String>;");
                strBuilder.Append("\r\n" + "private var NameSpace : String = \"http://tempuri.org/\";");
                strBuilder.Append("\r\n" + "private var MethodName : String = \"\";");
                strBuilder.Append("\r\n" + "private var WEB_SERVICE_URL : String = \"\";");
                strBuilder.Append("\r\n" + "private var soapAction : String = \"\";");

                strBuilder.AppendFormat("\r\n" + "private var obj{0}EN : cls{0}EN ;",
                      objPrjTabENEx.TabName);
                //私有属性名-----和属性过程
                //strBuilder.Append("\r\n /// <summary>");
                //strBuilder.Append("\r\n /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
                //strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strBuilder.Append("\r\n /// </summary>");
                //strBuilder.AppendFormat("\r\n" + "public static var arr{0}ObjLstCache : Array<cls{0}EN>= nil;",
                //       objPrjTabENEx.TabName);

                //strBuilder.AppendFormat("\r\n /// <summary>");
                //strBuilder.AppendFormat("\r\n /// 从缓存中查找失败的次数");
                //strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strBuilder.AppendFormat("\r\n /// </summary>");
                //strBuilder.AppendFormat("\r\n" + "private static var intFindFailCount : Int = 0;");

                //私有属性名-----和属性过程

                strBuilder.Append("\r\n" + "override init()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "self.Param = Dictionary<String, String>();");
                strBuilder.AppendFormat("\r\n" + "self.obj{0}EN = cls{0}EN();",
                     objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData = tzResponseData(data: \"\", what: 0, IsFinished: false, faultString: \"\", errorId: 0);",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "super.init();");
                strBuilder.Append("\r\n" + "}");

                strBuilder.AppendFormat("\r\n" + "init(strMethod : String, mapParam : Dictionary<String, String>, pobj{0}EN : cls{0}EN)",
                  objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "Param = Dictionary<String, String>();");
                //strBuilder.Append("\r\n" + "obj{0}EN = cls{0}EN();");
                //strBuilder.Append("\r\n" + "self.currentElementValue = \"\";");
                strBuilder.AppendFormat("\r\n" + "self.obj{0}EN = pobj{0}EN;",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "cls{0}WS.ResponseData = tzResponseData(data: \"\", what: 0, IsFinished: false, faultString: \"\", errorId: 0);",
                     objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "super.init();");
                strBuilder.Append("\r\n" + "self.MethodName = strMethod;");
                strBuilder.Append("\r\n" + "self.Param = mapParam;");
                strBuilder.Append("\r\n" + "if (self.Param.count == 0)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "self.Param = Dictionary<String, String>();");
                strBuilder.Append("\r\n" + "}");

                strBuilder.AppendFormat("\r\n" + "WEB_SERVICE_URL = \"\\(clsPubVar.CurrIPAndPort_{2})/\\(clsPubVar.CurrPrx_{2})/{0}/{1}Service.asmx\";",
                            objPrjTabENEx.ObjFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.TabName,
                            objProjectsENEx.PrjDomain);

                strBuilder.Append("\r\n" + "}");
                //生成所有的函数

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN1 = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }


                strBuilder.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
              
            }
            return strBuilder.ToString();
        }
        /// <summary>
        /// 生成Web Service转换层代码--Swift2
        /// </summary>
        /// <returns></returns>
        public string A_GenWebApiTransCode_Swift4_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strResult = "";
            if (objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst.Count == 0)
            {
                strResult = string.Format("当前类:[{0}]的函数数为0,无法生成相关层!({1})",
                      objWebSrvClassENEx.ClsName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;           

            objWebSrvClassENEx.ClsName = objWebSrvClassENEx.ClsName + "WS";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebApiTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".swift";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);

            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".swift";
            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //类名开始

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strBuilder.AppendFormat("\r\n" + "import Foundation",
                      objProjectsENEx.JavaPackageName);


                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objWebSrvClassENEx.ClsName,
                    objWebSrvClassENEx.PageName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* 注意:该类必须与调用界面处于同一个包,否则调用不成功!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strBuilder.Append("\r\n" + "*/");
                strBuilder.AppendFormat("\r\n" + "class  {0} : Operation, URLSessionDelegate, URLSessionDataDelegate , XMLParserDelegate",
                  objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "public static var ResponseData : tzResponseData!");
                strBuilder.Append("\r\n" + "private var Param : Dictionary<String, String>;");
                strBuilder.Append("\r\n" + "private var NameSpace : String = \"http://tempuri.org/\";");
                strBuilder.Append("\r\n" + "private var MethodName : String = \"\";");
                strBuilder.Append("\r\n" + "private var WEB_SERVICE_URL : String = \"\";");
                strBuilder.Append("\r\n" + "private var soapAction : String = \"\";");
                
                //私有属性名-----和属性过程

                strBuilder.Append("\r\n" + "override init()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "self.Param = Dictionary<String, String>();");
                //strBuilder.AppendFormat("\r\n" + "self.obj{0}EN = cls{0}EN();",
                //     objWebSrvClassENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "{0}WS.ResponseData = tzResponseData(data: \"\", what: 0, IsFinished: false, faultString: \"\", errorId: 0);",
                    objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "super.init();");
                strBuilder.Append("\r\n" + "}");

                strBuilder.AppendFormat("\r\n" + "init(strMethod : String, mapParam : Dictionary<String, String> )",
                  objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "Param = Dictionary<String, String>();");
                //strBuilder.Append("\r\n" + "obj{0}EN = cls{0}EN();");
                //strBuilder.Append("\r\n" + "self.currentElementValue = \"\";");
                //strBuilder.AppendFormat("\r\n" + "self.obj{0}EN = pobj{0}EN;",
                //objWebSrvClassENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "{0}WS.ResponseData = tzResponseData(data: \"\", what: 0, IsFinished: false, faultString: \"\", errorId: 0);",
                     objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "super.init();");
                strBuilder.Append("\r\n" + "self.MethodName = strMethod;");
                strBuilder.Append("\r\n" + "self.Param = mapParam;");
                strBuilder.Append("\r\n" + "if (self.Param.count == 0)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "self.Param = Dictionary<String, String>();");
                strBuilder.Append("\r\n" + "}");

                strBuilder.AppendFormat("\r\n" + "WEB_SERVICE_URL = \"\\(clsPubVar.CurrIPAndPort_{2})/\\(clsPubVar.CurrPrx_{2})/{0}/{1}\";",
                            objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName4GC(), 
                            objWebSrvClassENEx.PageName,
                            objProjectsENEx.PrjDomain);

                strBuilder.Append("\r\n" + "}");
                //生成所有的函数

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_4WA_ByCommonFunction_Swift4(objWebSrvFunctionsENEx);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strBuilder.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//该函数：[{0}]无法生成.", objWebSrvFunctionsENEx.FunctionSignature);
                            strBuilder.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//该函数：[{0}]无法生成.错误:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4WA_main_Swift4_SelfDefWs");

                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                strBuilder.Append("\r\n" + strTemp);
                objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4WA_start_Swift4");

                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                strBuilder.Append("\r\n" + strTemp);

                objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4WA_CallWebApi_Swift4_SelfDefWs");
                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                strBuilder.Append("\r\n" + strTemp);


                strBuilder.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_ByCommonFunction_Swift4(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的记录对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns>获取的相应记录对象列表</returns>");
            strBuilder.AppendFormat("\r\n" + "private func {0}( mapParam : Dictionary<String, String>) ",
              objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"{0}\";",
              objWebSrvFunctionsENEx.FunctionName);
            //strBuilder.Append("\r\n" + "do");
            //strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + " CallWebApi(strFunctionName: MethodName, dictPara: mapParam);");

            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch let objException as NSException");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "let strMsg : String = \"在调用WebApi函数:[{0}]时出错,错误信息：\\(String(describing: objException.reason))\";",
            //    objWebSrvFunctionsENEx.FunctionName);
            //strBuilder.Append("\r\n" + "throw tzErrorType(reason: strMsg);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        public string A_GeneFuncCode_Swift(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_Srv4CSharp);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("在类中没有相应的函数:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
                    if (mt.GetParameters().Length == 0)
                    {
                        strCode = (string)mt.Invoke(this, null);
                    }
                    else if (mt.GetParameters().Length == 1)
                    {
                        strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;

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
        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    return strCodeForCs.ToString();
                }

                if (objvFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                {
                    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                }
                else
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                }

                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_Access4Swift4);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("在类中没有相应的函数:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
                    if (mt.GetParameters().Length == 0)
                    {
                        strCode = (string)mt.Invoke(this, null);
                    }
                    else if (mt.GetParameters().Length == 1)
                    {
                        strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;
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
        public override void GetClsName()
        {
            this.ClsName = string.Format("cls{0}WApi", objPrjTabENEx.TabName);


        }

    }
}
