using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;

using com.taishsoft.commexception;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.datetime;
using System;
using System.Collections;
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
    partial class WS_Access_UDF4Java : clsGeneCodeBase4Tab
    {


        #region 构造函数

      
        public WS_Access_UDF4Java(string strTabId,  string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        #endregion
  
        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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

            objWebSrvClassENEx.ClsName = objWebSrvClassENEx.ClsName + "WS4SD";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".java";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);

            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".java";
            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //类名开始

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strBuilder.AppendFormat("\r\n" + "package {0}.GC.L3_ForWS.{1};",
                  objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC());

                //strBuilder.AppendFormat("\r\n" + "import {0}.L0Entity.cls{1}EN;",
                //      objProjectsENEx.JavaPackageName,
                //      objWebSrvClassENEx.ClsName);
                //strBuilder.AppendFormat("\r\n" + "import {0}.Logic.cls{1}BL;",
                //      objProjectsENEx.JavaPackageName,
                //      objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "import com.taishsoft.util.clsResponseData;");
                strBuilder.AppendFormat("\r\n" + "import {0}.PubFun.clsPubVar;",
                    objProjectsENEx.JavaPackageName);

                strBuilder.Append("\r\n" + "import android.os.Bundle;");
                strBuilder.Append("\r\n" + "import android.os.Handler;");
                strBuilder.Append("\r\n" + "import android.os.Looper;");
                strBuilder.Append("\r\n" + "import android.os.Message;");
                strBuilder.Append("\r\n" + "import android.widget.TextView;");
                strBuilder.Append("\r\n" + "import android.widget.Toast;");

                strBuilder.Append("\r\n" + "import org.json.JSONObject;");
                strBuilder.Append("\r\n" + "import org.ksoap2.SoapEnvelope;");
                strBuilder.Append("\r\n" + "import org.ksoap2.serialization.SoapObject;");
                strBuilder.Append("\r\n" + "import org.ksoap2.serialization.SoapPrimitive;");
                strBuilder.Append("\r\n" + "import org.ksoap2.serialization.SoapSerializationEnvelope;");
                strBuilder.Append("\r\n" + "import org.ksoap2.transport.HttpTransportSE;");
                strBuilder.Append("\r\n" + "import org.xmlpull.v1.XmlPullParserException;");

                strBuilder.Append("\r\n" + "import java.io.IOException;");
                strBuilder.Append("\r\n" + "import java.util.HashMap;");

                strBuilder.Append("\r\n" + "import java.util.Iterator;");
                strBuilder.Append("\r\n" + "import java.util.List;");
                strBuilder.Append("\r\n" + "import java.util.Map;");

                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objWebSrvClassENEx.PageName, objWebSrvClassENEx.ClsName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* 注意:该类必须与调用界面处于同一个包,否则调用不成功!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strBuilder.Append("\r\n" + "*/");
                strBuilder.AppendFormat("\r\n" + "public class  {0} implements Runnable",
                  objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "public static clsResponseData objResponseData = null;");

                strBuilder.Append("\r\n" + "private Handler mHandler = null;");
                strBuilder.Append("\r\n" + "private Map<String, String> Param = null;");
                strBuilder.Append("\r\n" + "private String NameSpace = \"http://tempuri.org/\";");
                strBuilder.Append("\r\n" + "private String MethodName = \"\";");
                strBuilder.Append("\r\n" + "private String WEB_SERVICE_URL = \"\";");
                strBuilder.Append("\r\n" + "private String soapAction = \"\";");

                //strBuilder.AppendFormat("\r\n" + "private cls{0}EN obj{0}EN = null;",
                //      objWebSrvClassENEx.ClsName);
                //私有属性名-----和属性过程
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                //strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                //       objWebSrvClassENEx.ClsName);

                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 从缓存中查找失败的次数");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "protected static int intFindFailCount = 0;");

                //私有属性名-----和属性过程

                strBuilder.AppendFormat("\r\n" + "public {0}WS4SD(Handler mmHandler, String strMethod, Map<String, String> mapParam)",
                  objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "{0}WS4SD.objResponseData = new clsResponseData();",
                        objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "this.mHandler = mmHandler;");
                strBuilder.Append("\r\n" + "this.MethodName = strMethod;");
                strBuilder.Append("\r\n" + "this.Param = mapParam;");
                strBuilder.Append("\r\n" + "if (this.Param == null)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "this.Param = new HashMap<String, String>();");
                strBuilder.Append("\r\n" + "}");

                //strBuilder.AppendFormat("\r\n" + "this.obj{0}EN = pobj{0}EN;",
                //      objWebSrvClassENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "WEB_SERVICE_URL = String.format(\"%s/%s/{1}/{0}.asmx\", clsPubVar.getCurrIPAndPort_{2}(), clsPubVar.getCurrPrx_{2}());",
                  objWebSrvClassENEx.ClsName, 
                  objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName4GC(),
                  objProjectsENEx.PrjDomain);
                strBuilder.Append("\r\n" + "}");
                //生成所有的函数


                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_4Ws_ByCommonFunction_Java(objWebSrvFunctionsENEx);
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
                strTemp = A_GeneFuncCode_Java("Gen_4Ws_run_Java_SelfDefWs");
                strBuilder.Append("\r\n" + strTemp);
                
                strTemp = A_GeneFuncCode_Java("Gen_4Ws_CallWebService_Java_SelfDefWs");
                strBuilder.Append("\r\n" + strTemp);

                strBuilder.Append("\r\n" + "}");

                //把生成写到文件中;
                ////检查该文件名的文件夹名,并判断是否存在;
                //strFolder = clsString.ParentDir_S(strClassFName);
                //if (System.IO.Directory.Exists(strFolder) == false)
                //{
                //    Directory.CreateDirectory(strFolder);
                //}

                //if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
                //{
                //    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                //    string strFindFileFullFile = clsFile.FindFileFromFolder(objWebSrvClassENEx.FolderName_Root, strSimpleFileName);
                //    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                //    {
                //        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
                //        throw new Exception(strMsg);

                //    }
                //}
                ////UTF8Encoding utf8 = new UTF8Encoding(false);
                //clsFile.CreateFileByString(strClassFName, strBuilder.ToString(), myEncoding);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }

        public string A_GeneFuncCode_Java(string strFuncName)
        {
            try
            {
                string strCode = "";
                Type t = typeof(WS_Srv4Front4CSharp);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("在类中没有相应的函数:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, newobject[] { "1234567890123"    });
                    strCode = (string)mt.Invoke(this, null);
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
       
        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetFirstObject_S_Java()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字获取相应的记录的对象");
            strBuilder.AppendFormat("\r\n /// mapParam样例: mapParam.put(\"strWhereCond\", \"1 = 1\");");
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"{0}GetFirstJSONObj_S\", values, null);",
                  objPrjTabENEx.TabName,
                  objKeyField.FldName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "private String GetFirstJSONObj(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetFirstJSONObj\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "return CallWebService(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"在调用WebService函数时出错,错误信息:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_ByCommonFunction_Java(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            clsDataTypeAbbrEN objFuncReturnTypeEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFunctionsENEx.ReturnTypeId);
            clsSelfDefDataTypeEN objSelfDefDataTypeEN = null;
            if (objFuncReturnTypeEN == null)
            {
                objSelfDefDataTypeEN = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFunctionsENEx.ReturnType);
                if (objSelfDefDataTypeEN == null)
                {
                    strMsg = string.Format("函数的返回类型：[{0}({1})]没有处理,不能生成相应代码。", objWebSrvFunctionsENEx.ReturnTypeId, objWebSrvFunctionsENEx.ReturnType);
                    throw new Exception(strMsg);
                }
            }

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
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

                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">引用型参数,返回:{1}</param>",
                        objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("ref {0} {1},", objSelfDefDataTypeEN_Para.CsType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("ref {0} {1},", objDataTypeAbbrEN.CsType, objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("ref {0},", objWebSrvFuncParaEN.ParaName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>",
                        objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objSelfDefDataTypeEN_Para.CsType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objDataTypeAbbrEN.CsType,
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
            strBuilder.AppendFormat("\r\n /// <returns>返回{0}</returns>",
                objWebSrvFunctionsENEx.ReturnValueDescription);
            if (objSelfDefDataTypeEN != null)
            {
                strBuilder.AppendFormat("\r\n" + "private String {1}WS(Map<String, String> mapParam) throws Exception",
                        objSelfDefDataTypeEN.CsType, objWebSrvFunctionsENEx.FunctionName,
                            sbParaList.ToString());
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "private String {1}WS(Map<String, String> mapParam) throws Exception",
                       objFuncReturnTypeEN.CsType, objWebSrvFunctionsENEx.FunctionName,
                           sbParaList.ToString());
            }
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"{0}\";",
              objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "return CallWebService(MethodName, mapParam);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"在调用WebService函数:[{0}]时出错,错误信息:%s\", objException.getMessage());",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetRecordJSONObjByKey_S_Java()
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
            strBuilder.AppendFormat("\r\n" + "private String GetJSONObjBy{1}(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetJSONObjBy{1}\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "return CallWebService(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"在调用WebService函数时出错,错误信息:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

      
        
        
        /// <summary>
        /// 调用WebService来添加记录,数据传递使用JSON串
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_AddNewRecordByJSON_S_Java()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 调用WebService来添加记录,数据传递使用JSON串");
            strBuilder.AppendFormat("\r\n /// mapParam样例:无", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"AddNewRecordByJSON\", values, obj{0}EN);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "private String AddNewRecordByJSON(Map<String, String> mapParam, cls{0}EN obj{0}EN) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"{0}_AddNewRecordBySql2ByJSON\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);


            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strJSON = cls{0}BL.GetJSONStrByObj(obj{0}EN);",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "mapParam.put(\"str{0}JSONObj\", strJSON);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return CallWebService(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"在调用WebService函数时出错,错误信息:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        
      
        /// <summary>
        /// 调用WebService来修改记录,数据传递使用JSON串
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_UpdateRecordByJSON_S_Java()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 调用WebService来修改记录,数据传递使用JSON串");
            strBuilder.AppendFormat("\r\n /// mapParam样例:无", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"UpdateRecordByJSON\", values, obj{0}EN);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "private String UpdateRecordByJSON(Map<String, String> mapParam, cls{0}EN obj{0}EN) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"{0}_UpdateBySql2ByJSON\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);


            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strJSON = cls{0}BL.GetJSONStrByObj(obj{0}EN);",
             objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "mapParam.put(\"str{0}JSONObj\", strJSON);",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return CallWebService(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"在调用WebService函数时出错,错误信息:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        

        /// <summary>
        /// 调用WebService来删除记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_DelRecord_S_Java()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 调用WebService来删除记录");
            strBuilder.AppendFormat("\r\n /// mapParam样例:{0} = \"01\"", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"DelRecord\", values, null);",
                 objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "private String DelRecord(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"{0}_DelRecord\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "return CallWebService(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"在调用WebService函数时出错,错误信息:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 调用WebService来删除记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_DelRecordsByJSON_Java()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 调用WebService来删除记录");
            strBuilder.AppendFormat("\r\n /// mapParam样例:{0} = \"01\"", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"DelRecord\", values, null);",
                 objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "private String DelRecordsByJSON(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"DelRecordsByJSON\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "return CallWebService(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"在调用WebService函数时出错,错误信息:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 调用WebService来检查是否存在记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_IsExistRecord_S_Java()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 调用WebService来检查是否存在记录");
            strBuilder.AppendFormat("\r\n /// mapParam样例:{0} = \"01\"", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"DelRecord\", values, null);",
                 objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "private String IsExistRecord(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"{0}_IsExistRecord\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "return CallWebService(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"在调用WebService函数时出错,错误信息:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 调用WebService来检查是否存在记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetRecCountByCond_Java()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取某一条件的记录数");
            strBuilder.AppendFormat("\r\n /// mapParam样例:{0} = \"01\"", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"DelRecord\", values, null);",
                 objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>");
            strBuilder.Append("\r\n /// <returns>获取某一条件的记录数</returns>");
            strBuilder.AppendFormat("\r\n" + "private String GetRecCountByCond(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"{0}GetRecCountByCond\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "return CallWebService(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"在调用WebService函数时出错,错误信息:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 调用WebService来检查是否存在记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetMaxStrId_S_Java()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 调用WebService来检查是否存在记录");
            strBuilder.AppendFormat("\r\n /// mapParam样例:{0} = \"01\"", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"DelRecord\", values, null);",
                 objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "private String GetMaxStrId(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"{0}GetMaxStrId\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "return CallWebService(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"在调用WebService函数时出错,错误信息:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 调用WebService来检查是否存在记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetMaxStrIdByPrefix_S_Java()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 调用WebService来检查是否存在记录");
            strBuilder.AppendFormat("\r\n /// mapParam样例:{0} = \"01\"", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"DelRecord\", values, null);",
                 objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "private String GetMaxStrIdByPrefix(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "MethodName = \"{0}GetMaxStrIdByPrefix\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return CallWebService(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"在调用WebService函数时出错,错误信息:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
    
        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetRecordJSONObjLst_S_Java()
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
            strBuilder.AppendFormat("\r\n" + "private String GetJSONObjLst(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetJSONObjLst\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "return CallWebService(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"在调用WebService函数时出错,错误信息:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetTopRecordJSONObjLst_S_Java()
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
            strBuilder.AppendFormat("\r\n" + "private String GetTopJSONObjLst(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetTopJSONObjLst\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "return CallWebService(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"在调用WebService函数时出错,错误信息:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetRecordJSONObjLstByPager_S_Java()
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
            strBuilder.AppendFormat("\r\n" + "private String GetJSONObjLstByPager(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetJSONObjLstByPager\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "return CallWebService(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"在调用WebService函数时出错,错误信息:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetRecordJSONObjLstByRange_S_Java()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的记录对象列表");
            strBuilder.AppendFormat("\r\n /// mapParam样例: mapParam.put(\"strWhereCond\", \"1 = 1\");");
            strBuilder.AppendFormat("\r\n ///调用样例:行1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjLstByRange\", values, null);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///调用样例:行3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns>获取的相应记录对象列表</returns>");
            strBuilder.AppendFormat("\r\n" + "private String GetJSONObjLstByRange(Map<String, String> mapParam) throws Exception",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "MethodName = \"GetJSONObjLstByRange\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "return CallWebService(MethodName, mapParam);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "String strMsg = String.format(\"在调用WebService函数时出错,错误信息:%s\", objException.getMessage());");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        /// <summary>
        /// 通用的调用WebService函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_CallWebService_Java()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 通用的调用WebService函数");
            strBuilder.AppendFormat("\r\n /// mapParam样例:{0} = \"01\"", objKeyField.PrivFuncName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"MethodName\">函数</param>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "private String CallWebService(String MethodName, Map<String, String> mapParam) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "soapAction = NameSpace + MethodName;");

            strBuilder.AppendFormat("\r\n" + "String result = \"\";");
            strBuilder.AppendFormat("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "//step1 指定WebService的命名空间和调用的方法名");
            strBuilder.AppendFormat("\r\n" + "SoapObject request = new SoapObject(NameSpace, MethodName);");

            strBuilder.AppendFormat("\r\n" + "//step2 设置调用方法的参数值,这里的参数名称最好和WebService一致");
            strBuilder.AppendFormat("\r\n" + "//request.addProperty(\"str{0}Id\", \"01\");",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "//request.addProperty(\"b\", 4);");
            strBuilder.AppendFormat("\r\n" + "if (mapParam != null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Iterator iter = mapParam.entrySet().iterator();");
            strBuilder.AppendFormat("\r\n" + "while (iter.hasNext())");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Map.Entry entry = (Map.Entry)iter.next();");
            strBuilder.AppendFormat("\r\n" + "request.addProperty((String)entry.getKey(),");
            strBuilder.AppendFormat("\r\n" + "(String)entry.getValue());");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "//step3 生成调用WebService方法的SOAP请求信息,并指定SOAP的版本");
            strBuilder.AppendFormat("\r\n" + "SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(");
            strBuilder.AppendFormat("\r\n" + "SoapEnvelope.VER11);");
            strBuilder.AppendFormat("\r\n" + "//设置是否调用的是dotNet下的WebService");
            strBuilder.AppendFormat("\r\n" + "envelope.dotNet = true;");
            strBuilder.AppendFormat("\r\n" + "//必须,等价于envelope.bodyOut = request;");
            strBuilder.AppendFormat("\r\n" + "envelope.setOutputSoapObject(request);");

            strBuilder.AppendFormat("\r\n" + "//step4 创建HttpTransportSE对象");
            strBuilder.AppendFormat("\r\n" + "HttpTransportSE ht = new HttpTransportSE(WEB_SERVICE_URL);");

            strBuilder.AppendFormat("\r\n" + "//step5 调用WebService");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            //第一个参数不仅仅是soapAction,还要是soapAction + MethodName
            strBuilder.AppendFormat("\r\n" + "ht.call(soapAction, envelope);");
            //            } catch (HttpResponseException e) {
            //                e.printStackTrace();
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (IOException e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.objResponseData.IsFinished = true;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.objResponseData.errorId = 4;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.objResponseData.faultString = String.format(\"调用远程WebService出错。地址：[%s]. 错误信息：[%s].\", WEB_SERVICE_URL, e.getMessage());",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "result = cls{0}WS.objResponseData.faultString;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "e.printStackTrace();");
            strBuilder.Append("\r\n" + "return result;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (XmlPullParserException e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.objResponseData.IsFinished = true;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.objResponseData.errorId = 3;",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.objResponseData.faultString = String.format(\"调用远程WebService出错。地址：[%s]. 错误信息：[%s].\", WEB_SERVICE_URL, e.getMessage());",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "result = cls{0}WS.objResponseData.faultString;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "e.printStackTrace();");
            strBuilder.Append("\r\n" + "return result;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "//step6 使用getResponse方法获得WebService方法的返回结果");
            strBuilder.AppendFormat("\r\n" + "if (envelope.getResponse() != null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "SoapPrimitive response = (SoapPrimitive)envelope.getResponse();");
            strBuilder.AppendFormat("\r\n" + "String strResult = response.toString();");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.objResponseData.IsFinished = true;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.objResponseData.errorId = 0;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.objResponseData.data = strResult;", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "return strResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.objResponseData.IsFinished = true;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.objResponseData.errorId = 1;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.objResponseData.faultString = \"从WebService没有收到数据!\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "result = \"从WebService没有收到数据!\";");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.objResponseData.IsFinished = true;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.objResponseData.errorId = 2;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "cls{0}WS.objResponseData.faultString = \"从WebService获取数据出现异常,有可能获取数据不存在!\";", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "result = e.getMessage();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return result;");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 通用的调用WebService函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_CallWebService_Java_SelfDefWs()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 通用的调用WebService函数,针对专门的");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"MethodName\">函数</param>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "private String CallWebService(String MethodName, Map<String, String> mapParam) ");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "soapAction = NameSpace + MethodName;");

            strBuilder.AppendFormat("\r\n" + "String result = \"\";");
            strBuilder.AppendFormat("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "//step1 指定WebService的命名空间和调用的方法名");
            strBuilder.AppendFormat("\r\n" + "SoapObject request = new SoapObject(NameSpace, MethodName);");

            strBuilder.AppendFormat("\r\n" + "//step2 设置调用方法的参数值,这里的参数名称最好和WebService一致");
            strBuilder.AppendFormat("\r\n" + "//request.addProperty(\"strKeyId\", \"01\");");
            strBuilder.AppendFormat("\r\n" + "//request.addProperty(\"b\", 4);");
            strBuilder.AppendFormat("\r\n" + "if (mapParam != null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Iterator iter = mapParam.entrySet().iterator();");
            strBuilder.AppendFormat("\r\n" + "while (iter.hasNext())");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "Map.Entry entry = (Map.Entry)iter.next();");
            strBuilder.AppendFormat("\r\n" + "request.addProperty((String)entry.getKey(),");
            strBuilder.AppendFormat("\r\n" + "(String)entry.getValue());");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "//step3 生成调用WebService方法的SOAP请求信息,并指定SOAP的版本");
            strBuilder.AppendFormat("\r\n" + "SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(");
            strBuilder.AppendFormat("\r\n" + "SoapEnvelope.VER11);");
            strBuilder.AppendFormat("\r\n" + "//设置是否调用的是dotNet下的WebService");
            strBuilder.AppendFormat("\r\n" + "envelope.dotNet = true;");
            strBuilder.AppendFormat("\r\n" + "//必须,等价于envelope.bodyOut = request;");
            strBuilder.AppendFormat("\r\n" + "envelope.setOutputSoapObject(request);");

            strBuilder.AppendFormat("\r\n" + "//step4 创建HttpTransportSE对象");
            strBuilder.AppendFormat("\r\n" + "HttpTransportSE ht = new HttpTransportSE(WEB_SERVICE_URL);");

            strBuilder.AppendFormat("\r\n" + "//step5 调用WebService");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            //第一个参数不仅仅是soapAction,还要是soapAction + MethodName
            strBuilder.AppendFormat("\r\n" + "ht.call(soapAction, envelope);");
            //            } catch (HttpResponseException e) {
            //                e.printStackTrace();
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (IOException e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}WS4SD.objResponseData.IsFinished = true;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}WS4SD.objResponseData.errorId = 4;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}WS4SD.objResponseData.faultString = String.format(\"调用远程WebService出错。地址：[%s]. 错误信息：[%s].\", WEB_SERVICE_URL, e.getMessage());",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "result = {0}WS4SD.objResponseData.faultString;",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "e.printStackTrace();");
            strBuilder.Append("\r\n" + "return result;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (XmlPullParserException e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}WS4SD.objResponseData.IsFinished = true;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}WS4SD.objResponseData.errorId = 3;",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}WS4SD.objResponseData.faultString = String.format(\"调用远程WebService出错。地址：[%s]. 错误信息：[%s].\", WEB_SERVICE_URL, e.getMessage());",
                objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "result = {0}WS4SD.objResponseData.faultString;",
                objWebSrvClassENEx.ClsName);
            strBuilder.Append("\r\n" + "e.printStackTrace();");
            strBuilder.Append("\r\n" + "return result;");
            strBuilder.Append("\r\n" + "}");


            strBuilder.AppendFormat("\r\n" + "//step6 使用getResponse方法获得WebService方法的返回结果");
            strBuilder.AppendFormat("\r\n" + "if (envelope.getResponse() != null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "SoapPrimitive response = (SoapPrimitive)envelope.getResponse();");
            strBuilder.AppendFormat("\r\n" + "String strResult = response.toString();");
            strBuilder.AppendFormat("\r\n" + "{0}.objResponseData.IsFinished = true;", objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}.objResponseData.errorId = 0;", objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}.objResponseData.data = strResult;", objWebSrvClassENEx.ClsName);

            strBuilder.AppendFormat("\r\n" + "return strResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}.objResponseData.IsFinished = true;", objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}.objResponseData.errorId = 1;", objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "{0}.objResponseData.data = \"从WebService没有收到数据!\";", objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "result = \"从WebService没有收到数据!\";");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "result = e.getMessage();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return result;");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

       
       
        /// <summary>
        /// 继承Runnable类必须实现的【run】函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_run_Java()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 继承Runnable类必须实现的【run】函数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "public void run()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "Looper.prepare();");
            strBuilder.Append("\r\n" + "String strResult = \"\";");            
            strBuilder.Append("\r\n" + "int intResult;");
            strBuilder.Append("\r\n" + "boolean bolResult;");

            strBuilder.Append("\r\n" + "Message msg = new Message();");
            strBuilder.Append("\r\n" + "Bundle data = new Bundle();");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "switch (MethodName)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "case \"GetJSONObjBy{1}\":",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "strResult = GetJSONObjBy{1}(Param);",
                  objPrjTabENEx.TabName,
                  objKeyField.FldName);
            strBuilder.Append("\r\n" + "msg.what = 1;");
            strBuilder.Append("\r\n" + "data.putString(\"strResultValue\", strResult);");

            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"GetJSONObjLst\":",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strResult = GetJSONObjLst(Param);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "msg.what = 2;");
            strBuilder.Append("\r\n" + "data.putString(\"strResultValue\", strResult);");

            strBuilder.Append("\r\n" + "break;");
            if (objPrjTabENEx.SqlDsTypeId ==enumSQLDSType.SqlTab_01)
            {
                strBuilder.Append("\r\n" + "case \"AddNewRecordByJSON\":");
                strBuilder.AppendFormat("\r\n" + "strResult = AddNewRecordByJSON(Param, obj{0}EN);",
                      objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "msg.what = 3;");
                strBuilder.Append("\r\n" + "bolResult = Boolean.valueOf(strResult).booleanValue();");
                strBuilder.Append("\r\n" + "data.putBoolean(\"bolResult\", bolResult);");

                strBuilder.Append("\r\n" + "break;");
                strBuilder.Append("\r\n" + "case \"UpdateRecordByJSON\":");
                strBuilder.AppendFormat("\r\n" + "strResult = UpdateRecordByJSON(Param, obj{0}EN);",
                      objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "msg.what = 4;");
                strBuilder.Append("\r\n" + "bolResult = Boolean.valueOf(strResult).booleanValue();");
                strBuilder.Append("\r\n" + "data.putBoolean(\"bolResult\", bolResult);");

                strBuilder.Append("\r\n" + "break;");
                strBuilder.Append("\r\n" + "case \"DelRecord\":");
                strBuilder.Append("\r\n" + "strResult = DelRecord(Param);");
                strBuilder.Append("\r\n" + "msg.what = 5;");
                strBuilder.Append("\r\n" + "intResult = Integer.parseInt(strResult);");
                strBuilder.Append("\r\n" + "data.putInt(\"intResult\", intResult);");

                strBuilder.Append("\r\n" + "break;");
                strBuilder.AppendFormat("\r\n" + "case \"DelRecordsByJSON\":",
                    objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "strResult = DelRecordsByJSON(Param);",
                        objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "msg.what = 13;");
                strBuilder.Append("\r\n" + "intResult = Integer.parseInt(strResult);");
                strBuilder.Append("\r\n" + "data.putInt(\"intResult\", intResult);");

                strBuilder.Append("\r\n" + "break;");
            }
            strBuilder.AppendFormat("\r\n" + "case \"GetFirstJSONObj\":", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strResult = GetFirstJSONObj(Param);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "msg.what = 6;");
            strBuilder.Append("\r\n" + "data.putString(\"strResultValue\", strResult);");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"IsExistRecord\":", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strResult = IsExistRecord(Param);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "msg.what = 7;");
            strBuilder.Append("\r\n" + "bolResult = Boolean.valueOf(strResult).booleanValue();");
            strBuilder.Append("\r\n" + "data.putBoolean(\"bolResult\", bolResult);");
            
            strBuilder.Append("\r\n" + "break;");

            strBuilder.AppendFormat("\r\n" + "case \"GetMaxStrId\":", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strResult = GetMaxStrId(Param);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "msg.what = 8;");
            strBuilder.Append("\r\n" + "data.putString(\"strResultValue\", strResult);");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.AppendFormat("\r\n" + "case \"GetMaxStrIdByPrefix\":", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strResult = GetMaxStrIdByPrefix(Param);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "msg.what = 9;");
            strBuilder.Append("\r\n" + "data.putString(\"strResultValue\", strResult);");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.AppendFormat("\r\n" + "case \"GetTopJSONObjLst\":",
     objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strResult = GetTopJSONObjLst(Param);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "msg.what = 10;");
            strBuilder.Append("\r\n" + "data.putString(\"strResultValue\", strResult);");

            strBuilder.Append("\r\n" + "break;");

            strBuilder.AppendFormat("\r\n" + "case \"GetJSONObjLstByPager\":",
objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strResult = GetJSONObjLstByPager(Param);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "msg.what = 11;");
            strBuilder.Append("\r\n" + "data.putString(\"strResultValue\", strResult);");

            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"GetRecCountByCond\":",
objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strResult = GetRecCountByCond(Param);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "msg.what = 12;");
            strBuilder.Append("\r\n" + "intResult = Integer.parseInt(strResult);");
            strBuilder.Append("\r\n" + "data.putInt(\"intResult\", intResult);");

            strBuilder.Append("\r\n" + "break;");

            strBuilder.AppendFormat("\r\n" + "case \"GetJSONObjLstByRange\":",
objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strResult = GetJSONObjLstByRange(Param);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "msg.what = 14;");
            strBuilder.Append("\r\n" + "data.putString(\"strResultValue\", strResult);");

            strBuilder.Append("\r\n" + "break;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//      throw objException;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//这三句可以传递数据");
            strBuilder.Append("\r\n" + "data.putInt(\"COUNT\", 100);//COUNT是标签,handleMessage中使用");

            strBuilder.Append("\r\n" + "msg.setData(data);");
            strBuilder.Append("\r\n" + "if (mHandler != null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "mHandler.sendMessage(msg); // 向Handler发送消息,更新UI");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "Looper.loop();");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 继承Runnable类必须实现的【run】函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_run_Java_SelfDefWs()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 继承Runnable类必须实现的【run】函数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "public void run()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "Looper.prepare();");
            strBuilder.Append("\r\n" + "String strResult = \"\";");
            strBuilder.Append("\r\n" + "boolean bolResult;");

            strBuilder.Append("\r\n" + "Message msg = new Message();");
            strBuilder.Append("\r\n" + "Bundle data = new Bundle();");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "switch (MethodName)");
            strBuilder.Append("\r\n" + "{");
            int intIndex = 50;
            foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
            {
                if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                strBuilder.AppendFormat("\r\n" + "case \"{0}\":",
              objWebSrvFunctionsENEx.FunctionName);
                strBuilder.AppendFormat("\r\n" + "strResult = {0}WS(Param);",
                      objWebSrvFunctionsENEx.FunctionName);
                strBuilder.AppendFormat("\r\n" + "msg.what = {0};", intIndex);
                strBuilder.Append("\r\n" + "data.putString(\"strResultValue\", strResult);");

                strBuilder.Append("\r\n" + "break;");
                intIndex++;
            }

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//      throw objException;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "//这三句可以传递数据");
            strBuilder.Append("\r\n" + "data.putInt(\"COUNT\", 100);//COUNT是标签,handleMessage中使用");

            strBuilder.Append("\r\n" + "msg.setData(data);");
            strBuilder.Append("\r\n" + "if (mHandler != null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "mHandler.sendMessage(msg); // 向Handler发送消息,更新UI");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "Looper.loop();");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
              string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WS_Access_UDF4Java);
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
        public override void GetClsName()
        {
            this.ClsName = string.Format("{0}WS", objWebSrvClassENEx.ClsName);
            objWebSrvClassENEx.ClsName = this.ClsName;
        }
    }
}
