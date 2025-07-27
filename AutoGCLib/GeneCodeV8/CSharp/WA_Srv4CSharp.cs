using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;

using com.taishsoft.commexception;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
    partial class WA_Srv4CSharp : clsGeneCodeBase4Tab
    {
        private string strKeyFldName_ObjName = "";

        #region 构造函数

       
        public WA_Srv4CSharp(string strTabId,  string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        #endregion

    
        /// <summary>
        /// 生成Web服务层后台代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult;
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

            var arrPrjTabFldEx = objPrjTabENEx.arrKeyFldSet;
            var arrKeyFldName = arrPrjTabFldEx.Select(x => x.FldName).ToList();
            var arrKeyFldName_ObjName = arrKeyFldName.Select(x => string.Format("obj{0}EN.{1}", objPrjTabENEx.TabName, x));
            strKeyFldName_ObjName = string.Join(",", arrKeyFldName_ObjName);

            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;


            objPrjTabENEx.ClsName = string.Format("{0}ApiController", objPrjTabENEx.TabName);
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WA_SrvLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //

            try
            {
                //类名开始

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strBuilder.Append("\r\n" + "using System;"); //
                strBuilder.Append("\r\n" + "using System.Data; "); //
                strBuilder.Append("\r\n" + "using System.Text; "); //
                strBuilder.Append("\r\n" + "using System.Collections; "); //
                strBuilder.Append("\r\n" + "using System.Collections.Generic;");
                //strBuilder.Append("\r\n" + "using System.Web.Services;");
                //strBuilder.Append("\r\n" + "using System.Web.Services.Protocols;");
                strBuilder.Append("\r\n" + "using System.ComponentModel;");
                strBuilder.Append("\r\n" + "using com.taishsoft.json;");
                strBuilder.AppendFormat("\r\n" + "using {0}.Entity;",
                objProject.PrjDomain);
                strBuilder.AppendFormat("\r\n" + "using {0}.BusinessLogic;",
                objProject.PrjDomain);
                //strBuilder.Append("\r\n" + ""); //
                strBuilder.Append("\r\n" + "using com.taishsoft.common;");
                //strBuilder.Append("\r\n" + "using com.taishsoft.datetime;");
                strBuilder.Append("\r\n" + "using Microsoft.AspNetCore.Mvc;");
                strBuilder.Append("\r\n" + "using System.Net;");
                strBuilder.Append("\r\n" + "using System.Linq;");
                strBuilder.Append("\r\n" + "using Newtonsoft.Json;");
                strBuilder.Append("\r\n" + "using Newtonsoft.Json.Linq; using Comm.WebApi;");
                strBuilder.Append("\r\n" + ""); //
                strBuilder.AppendFormat("\r\n" + "namespace {0}.WebApi",
                        objProject.PrjDomain);
                strBuilder.Append("\r\n" + "{");


                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}Controller 的摘要说明",
                        objPrjTabENEx.TabName);
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strBuilder.AppendFormat("\r\n /// For SilverLight");
                //}
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "[ApiController]");
                strBuilder.Append("\r\n" + "[Route(\"[controller]\")]");
                strBuilder.Append("\r\n" + "[ApiExplorerSettings(IgnoreApi = true)]");                
                strBuilder.AppendFormat("\r\n" + "public class  {0} : ControllerBase",
                          objPrjTabENEx.ClsName);
                strBuilder.Append("\r\n" + "{ ");

                //生成所有的函数

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                 clsvFunction4GeneCodeBLEx.GetObjLstByPrjTabEx(objPrjTabENEx, (int)enumApplicationType.WebApi_19, this.CmPrjId);

                           
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strBuilder.Append("\r\n" + "");
                        strBuilder.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }

                strBuilder.Append("\r\n" + "}");
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
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenWebApiTransCode_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
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


            objWebSrvClassENEx.ClsName = string.Format("{0}WS", objWebSrvClassENEx.ClsName);
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebApiTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".cs";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);

            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".cs";
            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //类名开始

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                //类名开始

                strBuilder.Append("\r\n" + "using System;"); //
                strBuilder.Append("\r\n" + "using System.Data; "); //
                strBuilder.Append("\r\n" + "using System.Data.SqlClient;");
                strBuilder.Append("\r\n" + "using System.Text; "); //
                strBuilder.Append("\r\n" + "using System.Collections; "); //
                strBuilder.Append("\r\n" + "using com.taishsoft.common;"); //
                strBuilder.Append("\r\n" + "using System.ServiceModel;"); //
                strBuilder.AppendFormat("\r\n" + "using {1}4WS.ServiceReference{0};", objWebSrvClassENEx.ClsName, objProject.PrjDomain); //
                strBuilder.Append("\r\n" + "using System.Collections.Generic;"); //

                strBuilder.Append("\r\n" + ""); //
                                                //if (objWebSrvClassENEx.IsForSilverLight == true)
                                                //{
                                                //    strBuilder.AppendFormat("\r\n" + "namespace SL4WS",
                                                //    objProject.PrjDomain);
                                                //}
                                                //else
                                                //{
                strBuilder.AppendFormat("\r\n" + "namespace {0}4WS",
                objProject.PrjDomain);
                //}
                strBuilder.Append("\r\n" + "{");

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}",
                    objWebSrvClassENEx.ClsName);
                //if (objWebSrvClassENEx.IsForSilverLight == true)
                //{
                //    strBuilder.AppendFormat("\r\n /// For SilverLight");
                //}
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.Append("\r\n" + "public class " + objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");


                strBuilder.AppendFormat("\r\n" + "private static string mstrApiControllerName = \"{0}\";",
                    objWebSrvClassENEx.PageName);
                strBuilder.Append("\r\n" + "private static string mstrDir = \"0\";");

                //私有属性名-----和属性过程
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                //strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                //       objWebSrvClassENEx.TabName);

                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 从缓存中查找失败的次数");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "protected static int intFindFailCount = 0;");

                //私有属性名-----和属性过程
                strBuilder.AppendFormat("\r\n" + "private static {0}SoapClient obj{0}SoapClient = null;",
                objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <returns></returns>");
                strBuilder.AppendFormat("\r\n" + "public static {0}SoapClient Get{0}SoapClient()",
                objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "if (obj{0}SoapClient == null)",
                objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "BasicHttpBinding binding = new BasicHttpBinding();");
                strBuilder.AppendFormat("\r\n" + "binding.Name = \"{0}ServiceSoap\";",
                objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "binding.CloseTimeout = new System.TimeSpan(6000);");
                strBuilder.Append("\r\n" + "binding.MaxReceivedMessageSize = 2147483647;");
                //                strBuilder.Append("\r\n" + "String strServiceUrl = String.Empty;");
                strBuilder.Append("\r\n" + "string strServiceUrl = GetServiceUrl(mstrApiControllerName, ref mstrDir);");
                //strBuilder.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false)");
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{{1}}/{2}Service.asmx\", clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx);",
                //"{", "}", objWebSrvClassENEx.TabName);
                //strBuilder.Append("\r\n" + "}");
                //strBuilder.Append("\r\n" + "else");
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{2}Service.asmx\", clsSysPara4WebApi.strCurrIPAddressAndPort_Local);",
                //"{", "}", objWebSrvClassENEx.TabName);
                //strBuilder.Append("\r\n" + "}");

                strBuilder.Append("\r\n" + "EndpointAddress address = new EndpointAddress(strServiceUrl);");

                strBuilder.AppendFormat("\r\n" + "return new {0}SoapClient(binding, address);",
                objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "return obj{0}SoapClient;",
                objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "}");
                //生成所有的函数

                //List<clsvWebSrvFunctionsEN> arrvWebSrvFunctionsObjLst =
                //  clsvWebSrvFunctionsBLEx.getFunction4GeneCodeObjLstByTemplateId(objWebSrvClassENEx.FunctionTemplateId,
                //  objWebSrvClassENEx.LangType, objWebSrvClassENEx.ProgLevelTypeId, objWebSrvClassENEx.SqlDsTypeId);
                //List<clsvWebSrvFunctionsEN> arrvWebSrvFunctionsObjLst =
                //    clsvWebSrvFunctionsBLEx.GetvWebSrvFunctionsObjLstByClassId(objWebSrvClassENEx.WebSrvClassId);
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_4WA_ByCommonFunction(objWebSrvFunctionsENEx);
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
                strFuncName = "Gen_4WA_GetServiceUrl";
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx(strFuncName);

                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strBuilder.Append("\r\n" + strTemp);
                }

                strBuilder.Append("\r\n" + "}");
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



        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
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


        public string Gen_GetDataSet(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\n" + "[HttpGet(\"GetDataSet\")]");
            strBuilder.AppendFormat("\r\n" + "public DataSet GetDataSet(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");            
            strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSet(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_GetTopDataSet(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\n" + "[HttpGet(\"GetTopDataSet/{intTopSize},{strWhereCond}\")]");
            strBuilder.AppendFormat("\r\n" + "public DataSet GetTopDataSet(int intTopSize, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSet_Top(intTopSize, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetDataSetByRange(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\n" + "[HttpGet(\"GetDataSetByRange\")]");
            strBuilder.AppendFormat("\r\n" + "public DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "[\"strOrderBy\"] = strOrderBy, ");
            strBuilder.AppendFormat("\r\n" + "[\"intMinNum\"] = intMinNum.ToString(),", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "[\"intMaxNum\"] = intMaxNum.ToString()", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_GetDataSetV(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取当前表视图的数据集,用DataSet表示");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回当前表视图的数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\n" + "[HttpGet(\"GetDataSetV\")]");
            strBuilder.AppendFormat("\r\n" + "public DataSet GetDataSetV(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetDataSetVByRange(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\n" + "[HttpGet(\"GetDataSetVByRange\")]");
            strBuilder.AppendFormat("\r\n" + "public DataSet GetDataSetVByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "[\"strOrderBy\"] = strOrderBy, ");
            strBuilder.AppendFormat("\r\n" + "[\"intMinNum\"] = intMinNum.ToString(),", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "[\"intMaxNum\"] = intMaxNum.ToString()", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "};");
            
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSetVByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 获取记录属性
        /// </summary>
        /// <returns></returns>
        public string Gen_GetRecordProperty(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据对象的关键字值,获取对象的全部属性");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">相关对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "/// <returns>是否成功</returns>");
            strBuilder.AppendFormat("\r\n" + "[HttpGet(\"Get{0}\")]", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public ActionResult Get{0}(ref cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WebApi.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileName为空,请检查!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + " {");
            strBuilder.AppendFormat("\r\n" + "[\"obj{0}EN\"] = cls{0}BL.SerializeObjToXMLStr(obj{0}EN)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + " };");
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " }");


            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.Get{0}(ref obj{0}EN);",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        
        /// <summary>
        /// 获取记录属性通过关键字
        /// </summary>
        /// <returns></returns>
        public string Gen_GetObjByKeyId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 获取当前关键字的记录对象,用对象的形式表示.");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}=value",
              objPrjTabENEx.TabName,
              TransKeyWords4FuncName(clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code)),
              objKeyField.FldName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objInFor.PrivFuncName);
                }
                strBuilder.AppendFormat("\r\n /// <returns>表对象</returns>");
                strBuilder.AppendFormat("\r\n" + "[HttpGet(\"GetObjByKeyLst\")]", objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjByKeyLst({2})",
                objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyVarDefineLstStr);

            }
            else
            {
                strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objKeyField.PrivFuncName);
                strBuilder.AppendFormat("\r\n /// <returns>表对象</returns>");
                strBuilder.AppendFormat("\r\n" + "[HttpGet(\"GetObjBy{0}\")]", objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjBy{1}({2})",
                objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyVarDefineLstStr);
            }
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString(),", objInFor.PrivFuncName);
                }
            }
            else
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    if (objInFor.ObjFieldTab().IsNumberType() == true)
                    {
                        strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString(),", objInFor.PrivFuncName);
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {0},", objInFor.PrivFuncName);
                    }
                }
            }
            strBuilder.Append("\r\n };");
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (objInFor.IsNumberType() == true)
                {
                    strBuilder.AppendFormat("\r\n" + " if ({0} <= 0)",
                            objInFor.PrivFuncName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty({0}) == true)",
                          objInFor.PrivFuncName);
                }
            }
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据关键字获取对象时,关键字不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjByKeyLst({2});",
             objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);

            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjBy{1}({2});",
                objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            }
            strBuilder.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnObj = obj{0}EN }});", objPrjTabENEx.TabName);

            //strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 获取记录属性通过关键字
        /// </summary>
        /// <returns></returns>
        public string Gen_GetObjByKeyIdCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
            string strFuncAddiParaVar = clsPubFun4GC.Gen_4BL_GetFuncAddiParaVar(objPrjTabENEx);
            string strFuncAddiPara = clsPubFun4GC.Gen_4BL_GetFuncAddiPara(objPrjTabENEx);
            string strFuncAddiParam = clsPubFun4GC.Gen_4BL_GetFuncAddiParam(objPrjTabENEx);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 获取当前关键字的记录对象,用对象的形式表示.");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}=value",
              objPrjTabENEx.TabName,
              TransKeyWords4FuncName(clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code)),
              objKeyField.FldName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count>1)
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objInFor.PrivFuncName);
                }
                strBuilder.Append(strFuncAddiParam);
                strBuilder.AppendFormat("\r\n /// <returns>表对象</returns>");

                strBuilder.AppendFormat("\r\n" + "[HttpGet(\"GetObjByKeyLstCache\")]", objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjByKeyLstCache({2}{3})",
                        objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyVarDefineLstStr,
                        strFuncAddiPara);
            }
            else
            {
                strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objKeyField.PrivFuncName);
                strBuilder.Append(strFuncAddiParam);
                strBuilder.AppendFormat("\r\n /// <returns>表对象</returns>");

                strBuilder.AppendFormat("\r\n" + "[HttpGet(\"GetObjBy{0}Cache\")]", objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjBy{1}Cache({2}{3})",
                        objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyVarDefineLstStr,
                        strFuncAddiPara);

            }
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (objInFor.ObjFieldTab().IsNumberType() == true)
                {
                    strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString(),", objInFor.PrivFuncName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {0},", objInFor.PrivFuncName);
                }
            }
            if (clsPubFun4GC.IsPrjmaryKeyFldNameContainsCache1FldName(objPrjTabENEx) == false)
            {
                strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {0},", objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            if (clsPubFun4GC.IsPrjmaryKeyFldNameContainsCache2FldName(objPrjTabENEx) == false)
            {
                strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {0},", objPrjTabENEx.objCacheClassifyFld2.PrivFuncName);
            }
            strBuilder.Append("\r\n };");
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (objInFor.ObjFieldTab().IsNumberType() == true)
                {
                    strBuilder.AppendFormat("\r\n" + " if ({0} <= 0)",
                            objInFor.PrivFuncName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty({0}) == true)",
                          objInFor.PrivFuncName);
                }
            }
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据关键字获取对象时,关键字不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                    strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjByKeyLstCache({2}{3});",
                objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyPrivFuncFldNameLstStr,
                 strFuncAddiParaVar);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjBy{1}Cache({2}{3});",
            objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyPrivFuncFldNameLstStr,
             strFuncAddiParaVar);
            }
            strBuilder.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnObj = obj{0}EN }});", objPrjTabENEx.TabName);

            //strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 获取记录属性
        /// </summary>
        /// <returns></returns>
        public string Gen_GetObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.Append("\r\n" + "[HttpGet(\"GetObjLst\")]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjLst(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(strWhereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据条件获取对象列表,条件不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLst(strWhereCond);",
            objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
            //objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnObjLst = arr{0}ObjLst }});", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");

            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetObjLstCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            //strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.Append("\r\n" + "[HttpGet(\"GetObjLstCache\")]");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjLstCache()",
            objPrjTabENEx.TabName);
            }            
            else if (objPrjTabENEx.objCacheClassifyFld2 == null)
            {
                strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjLstCache({0} {1})",
                    objPrjTabENEx.objCacheClassifyFld.CsType, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjLstCache({0} {1}, {2} {3})",
    objPrjTabENEx.objCacheClassifyFld.CsType, objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
    objPrjTabENEx.objCacheClassifyFld2.CsType, objPrjTabENEx.objCacheClassifyFld2.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "{");
            
            //strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
      
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLstCache();",
            objPrjTabENEx.TabName);
            }         
            else if (objPrjTabENEx.objCacheClassifyFld2 == null)
            {
                strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLstCache({1});",
                    objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLstCache({1}, {2});",
                    objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName, objPrjTabENEx.objCacheClassifyFld2.PrivFuncName);
            }
            //strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
            //objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnObjLst = arr{0}ObjLst }});", objPrjTabENEx.TabName);


            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_GetObjLstByKeyLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objPrjTabENEx.arrKeyFldSet.Count > 1) return "";
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字列表获取相关对象列表");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: POST /api/{0}api/GetObjLstBy{1}Lst",
              objPrjTabENEx.TabName,
            objKeyField.FldName_FstUcase);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count>1 )
            {
                strBuilder.AppendFormat("\r\n /// <param name = \"arrKeyLst\">所给的关键字</param>", objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的对象</returns>");
                strBuilder.AppendFormat("\r\n" + "[HttpPost(\"GetObjLstByKeyLsts\")]",
                        objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjLstByKeyLsts([FromBody]string[] arrKeyLst)",
                        objPrjTabENEx.TabName);
            }
            else
            {


                strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}Lst\">所给的关键字</param>", objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的对象</returns>");
                strBuilder.AppendFormat("\r\n" + "[HttpPost(\"GetObjLstBy{0}Lst\")]",
                        objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjLstBy{1}Lst([FromBody]string[] arr{1})",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName_FstUcase);
            }
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strBuilder.AppendFormat("\r\n" + "List<string> arrLst = new(arrKeyLst);", objKeyField.FldName_FstUcase);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<string> arrLst = new(arr{0});", objKeyField.FldName_FstUcase);
            }
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strBuilder.AppendFormat("\r\n" + "if (arrKeyLst.Length == 0)", objKeyField.FldName_FstUcase);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "if (arr{0}.Length == 0)", objKeyField.FldName_FstUcase);
            }
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据关键字列表串获取对象列表时,给定的关键字值列表的JSON串不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "string[] sstrCollegeId = strKeyIdLst.Trim().Split(','); ");
            if (objKeyField.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0} = new(arr{0});", objKeyField.FldName_FstUcase                    );
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0}_Str = new List<string>(arr{0});", objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_Str.Select(x=>{0}.Parse(x)).ToList();", 
                    objKeyField.CsType,
                    objKeyField.FldName_FstUcase);

            }


            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLstByKeyLsts(lst{1});",
                        objPrjTabENEx.TabName, objKeyField.FldName_FstUcase);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLstBy{1}Lst(lst{1});",
                objPrjTabENEx.TabName, objKeyField.FldName_FstUcase);
            }
            //strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
            //objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnObjLst = arr{0}ObjLst }});", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetObjLstByKeyLstCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
    
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字列表获取相关对象列表");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: POST /api/{0}api/GetObjLstBy{1}Lst",
              objPrjTabENEx.TabName,
            objKeyField.FldName_FstUcase);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strBuilder.AppendFormat("\r\n /// <param name = \"arrKeyLst\">所给的关键字</param>", objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的对象</returns>");
                strBuilder.AppendFormat("\r\n" + "[HttpPost(\"GetObjLstByKeyLstsCache\")]", objKeyField.FldName_FstUcase);
                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjLstByKeyLstsCache([FromBody]string[] arrKeyLst)",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName_FstUcase);
                }
                else if (objPrjTabENEx.objCacheClassifyFld2 == null)
                {
                    strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjLstByKeyLstsCache([FromBody]string[] arrKeyLst, {2} {3})",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName_FstUcase,
                            objPrjTabENEx.objCacheClassifyFld.CsType,
                            objPrjTabENEx.objCacheClassifyFld.FldName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjLstByKeyLstsCache([FromBody]string[] arrKeyLst, {2} {3}, {4} {5})",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName_FstUcase,
                            objPrjTabENEx.objCacheClassifyFld.CsType,
                            objPrjTabENEx.objCacheClassifyFld.FldName,
                            objPrjTabENEx.objCacheClassifyFld2.CsType,
                            objPrjTabENEx.objCacheClassifyFld2.FldName);
                }
            }
            else
            {
                strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}Lst\">所给的关键字</param>", objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的对象</returns>");
                strBuilder.AppendFormat("\r\n" + "[HttpPost(\"GetObjLstBy{0}LstCache\")]", objKeyField.FldName_FstUcase);
                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjLstBy{1}LstCache([FromBody]string[] arr{1})",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName_FstUcase);
                }
                else if (objPrjTabENEx.objCacheClassifyFld2 == null)
                {
                    strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjLstBy{1}LstCache([FromBody]string[] arr{1}, {2} {3})",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName_FstUcase,
                            objPrjTabENEx.objCacheClassifyFld.CsType,
                            objPrjTabENEx.objCacheClassifyFld.FldName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjLstBy{1}LstCache([FromBody]string[] arr{1}, {2} {3}, {4} {5})",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName_FstUcase,
                            objPrjTabENEx.objCacheClassifyFld.CsType,
                            objPrjTabENEx.objCacheClassifyFld.FldName,
                            objPrjTabENEx.objCacheClassifyFld2.CsType,
                            objPrjTabENEx.objCacheClassifyFld2.FldName);
                }
            }
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strBuilder.AppendFormat("\r\n" + "List<string> arrLst = new(arrKeyLst);", objKeyField.FldName_FstUcase);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<string> arrLst = new(arr{0});", objKeyField.FldName_FstUcase);
            }
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strBuilder.AppendFormat("\r\n" + "if (arrKeyLst.Length == 0)", objKeyField.FldName_FstUcase);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "if (arr{0}.Length == 0)", objKeyField.FldName_FstUcase);
            }
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据关键字列表串获取对象列表时,给定的关键字值列表的JSON串不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "string[] sstrCollegeId = strKeyIdLst.Trim().Split(','); ");
            if (objPrjTabENEx.arrKeyFldSet.Count == 1)
            {
                if (objKeyField.CsType == "string")
                {
                    strBuilder.AppendFormat("\r\n" + "List<string> lst{0} = new(arr{0});", objKeyField.FldName_FstUcase);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "List<string> lst{0}_Str = new List<string>(arr{0});", objKeyField.FldName_FstUcase);
                    strBuilder.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_Str.Select(x=>{0}.Parse(x)).ToList();",
                        objKeyField.CsType,
                        objKeyField.FldName_FstUcase);
                }
            }
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lstKeyLst = new(arrKeyLst);", objKeyField.FldName_FstUcase);

                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLstByKeyLstsCache(lstKeyLst);",
                        objPrjTabENEx.TabName);
                }
                else if (objPrjTabENEx.objCacheClassifyFld2 == null)
                {
                    strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLstByKeyLstsCache(lstKeyLst, {1});",
                        objPrjTabENEx.TabName, 
                            objPrjTabENEx.objCacheClassifyFld.FldName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLstByKeyLstsCache(lstKeyLst, {1}, {2});",
                        objPrjTabENEx.TabName, 
                            objPrjTabENEx.objCacheClassifyFld.FldName,
                            objPrjTabENEx.objCacheClassifyFld2.FldName);
                }
            }
            else
            {
                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLstBy{1}LstCache(lst{1});",
                        objPrjTabENEx.TabName, objKeyField.FldName_FstUcase);
                }
                else if (objPrjTabENEx.objCacheClassifyFld2 == null)
                {
                    strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLstBy{1}LstCache(lst{1}, {2});",
                        objPrjTabENEx.TabName, objKeyField.FldName_FstUcase,
                            objPrjTabENEx.objCacheClassifyFld.FldName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLstBy{1}LstCache(lst{1}, {2}, {3});",
                        objPrjTabENEx.TabName, objKeyField.FldName_FstUcase,
                            objPrjTabENEx.objCacheClassifyFld.FldName,
                            objPrjTabENEx.objCacheClassifyFld2.FldName);
                }
            }
            //strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
            //objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnObjLst = arr{0}ObjLst }});", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }



        public string Gen_DelRecordBySign(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据标志删除关键字列表");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: POST /api/{0}api/DelRecordBySign",
              objPrjTabENEx.TabName,
            objKeyField.FldName_FstUcase);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}Lst\">所给的关键字列表</param>", objKeyField.FldName_FstUcase);
            strBuilder.AppendFormat("\r\n /// <returns>删除的记录数</returns>");
            strBuilder.AppendFormat("\r\n" + "[HttpPost(\"DelRecordBySign\")]", objKeyField.FldName_FstUcase);
            strBuilder.AppendFormat("\r\n" + "public ActionResult DelRecordBySign([FromBody]string[] arr{1})",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "List<string> arrLst = new(arr{0});", objKeyField.FldName_FstUcase);
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.AppendFormat("\r\n" + "if (arr{0}.Length == 0)", objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据标志删除记录时,给定的关键字值列表不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "string[] sstrCollegeId = strKeyIdLst.Trim().Split(','); ");
            if (objKeyField.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0} = new(arr{0});", objKeyField.FldName_FstUcase);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0}_Str = new List<string>(arr{0});", objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_Str.Select(x=>{0}.Parse(x)).ToList();",
                    objKeyField.CsType,
                    objKeyField.FldName_FstUcase);
            }
            
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.DelRecordBySign(lst{1});",
            objPrjTabENEx.TabName, objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnInt = intRecNum });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_UnDelRecordBySign(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据标志恢复删除的记录列表");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: POST /api/{0}api/UnDelRecordBySign",
              objPrjTabENEx.TabName,
            objKeyField.FldName_FstUcase);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}Lst\">所给的关键字列表</param>", objKeyField.FldName_FstUcase);
            strBuilder.AppendFormat("\r\n /// <returns>恢复删除的记录数</returns>");
            strBuilder.AppendFormat("\r\n" + "[HttpPost(\"UnDelRecordBySign\")]",
                    objKeyField.FldName_FstUcase);
            strBuilder.AppendFormat("\r\n" + "public ActionResult UnDelRecordBySign([FromBody]string[] arr{1})",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "List<string> arrLst = new(arr{0});", objKeyField.FldName_FstUcase);
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.AppendFormat("\r\n" + "if (arr{0}.Length == 0)", objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据标志恢复删除记录时,给定的关键字值列表不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "string[] sstrCollegeId = strKeyIdLst.Trim().Split(','); ");
            if (objKeyField.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0} = new(arr{0});", objKeyField.FldName_FstUcase);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0}_Str = new List<string>(arr{0});", objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_Str.Select(x=>{0}.Parse(x)).ToList();",
                    objKeyField.CsType,
                    objKeyField.FldName_FstUcase);
            }

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.UnDelRecordBySign(lst{1});",
            objPrjTabENEx.TabName, objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnInt = intRecNum });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        /// <summary>
        /// 获取记录属性
        /// </summary>
        /// <returns></returns>
        public string Gen_GetTopObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取顶部对象列表");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objTopPara\">获取顶部对象列表的参数对象</param>");     
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.Append("\r\n" + "[HttpPost(\"GetTopObjLst\")]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult GetTopObjLst([FromBody]stuTopPara objTopPara)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "objTopPara.whereCond = objTopPara.whereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = objTopPara.GetDictParam();");
    
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(objTopPara.whereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据条件获取顶部对象列表,条件不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " if (objTopPara.topSize <= 0)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据条件获取顶部对象列表,顶部记录数:[{0}]不能小于等于0!({1})\", objTopPara.topSize, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetTopObjLst(objTopPara);",
            objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
            //objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnObjLst = arr{0}ObjLst }});", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetRecordPropertyV(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据对象的关键字值,获取对象的全部属性");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">相关对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "/// <returns>是否成功</returns>");
            strBuilder.AppendFormat("\r\n" + "[HttpGet(\"Get{0}V\")]", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public ActionResult Get{0}V(ref cls{0}EN obj{0}EN)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WebApi.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileName为空,请检查!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + " {");
            strBuilder.AppendFormat("\r\n" + "[\"obj{0}EN\"] = cls{0}BL.SerializeObjToXMLStr(obj{0}EN)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + " };");
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " }");


            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.Get{0}(ref obj{0}EN);",
                    objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_IsExistRecordByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:判断是否存在某一条件的记录");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>包含结果的Jobject, 如果存在就返回TRUE,否则返回FALSE</returns>");
            strBuilder.Append("\r\n" + "[HttpGet(\"IsExistRecord\")]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult IsExistRecord(string strWhereCond)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(strWhereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"判断是否存在某一条件的记录,条件不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");

            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}BL.IsExistRecord(strWhereCond);",
                    objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnBool = bolIsExist });");

            //strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
    
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            //strBuilder.Append("\r\n" + "return false;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_GetRecCountByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取某一条件的记录数");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>某一条件的记录数</returns>");
            strBuilder.Append("\r\n" + "[HttpGet(\"GetRecCountByCond\")]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult GetRecCountByCond(string strWhereCond)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(strWhereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"获取某一条件的记录数,条件不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "int intCount = cls{0}BL.GetRecCountByCond(strWhereCond);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnInt = intCount });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetFldValue(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
                   strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">所给定的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\n" + "[HttpGet(\"GetFldValue\")]");
            strBuilder.Append("\r\npublic ActionResult GetFldValue(string strFldName, string strWhereCond)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strFldName\"] = strFldName,");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(strWhereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"获取某一条件的字段值,条件不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "List<string> arrList = cls{0}BL.GetFldValue(strFldName, strWhereCond);",
                    objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnStrLst = string.Join(\",\", arrList) });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
            //strBuilder.AppendFormat("\r\n List<string> arrList = {0}DA.GetFldValue(strFldName, strWhereCond);", objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nreturn arrList;");        
        }
        public string Gen_funSetFldValue(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
                   strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">所给定的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>记录数,为整型</returns>");
            strBuilder.Append("\r\n" + "[HttpGet(\"SetFldValue\")]");
            strBuilder.Append("\r\npublic ActionResult SetFldValue(string strFldName, string strValue, string strWhereCond)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strFldName\"] = strFldName,");
            strBuilder.Append("\r\n" + "[\"strValue\"] = strValue,");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(strWhereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"获取某一条件的字段值,条件不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "int intRecCount = cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, strFldName, strValue, strWhereCond);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnInt = intRecCount });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
            //strBuilder.AppendFormat("\r\n List<string> arrList = {0}DA.GetFldValue(strFldName, strWhereCond);", objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nreturn arrList;");        
        }


        public string Gen_IsExist(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 判断当前表中是否存在给定关键字值的记录");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}=value",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              objKeyField.FldName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>返回是否存在?</returns>");
            strBuilder.AppendFormat("\r\n" + "[HttpGet(\"IsExist\")]", objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "public ActionResult IsExist({1})",
                    objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
            {
                strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString()", objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {0}", objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n };");
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            if (IsNumberType4Key == true)
            {
                strBuilder.AppendFormat("\r\n" + " if ({0} <= 0)",
                        objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty({0}) == true)",
                      objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"判断表中是否存在给定关键字的记录时,关键字不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}BL.IsExist({1});",
                    objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr_TS);
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnBool = bolIsExist });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return false;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03) return "";
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
                string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
                strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
                  objPrjTabENEx.TabName,
                  clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
                  strQueryString4ParaLst);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");
                strBuilder.Append("\r\n" + "[HttpGet(\"GetMaxStrId\")]");
                strBuilder.AppendFormat("\r\n" + "public ActionResult GetMaxStrId()",
                        objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
                strBuilder.Append("\r\n" + "{");
                
                strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
                strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
                //  strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
                strBuilder.Append("\r\n try");
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\n" + "string strMax{1} = cls{0}BL.GetMaxStrId_S();",
                        objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr, objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnStr =  strMax{0} }});", objPrjTabENEx.KeyPrivFuncFldNameLstStr);

                strBuilder.Append("\r\n }");
                strBuilder.Append("\r\n catch (Exception objException)");
                strBuilder.Append("\r\n {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
                //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
                //strBuilder.Append("\r\n" + "return \"\";");
                strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
                strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
                strBuilder.Append("\r\n }");
                strBuilder.Append("\r\n" + "}");
            }
            return strBuilder.ToString();
        }

        public string Gen_GetMaxStrIdByPrefix(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06) return "";

            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
                string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
                strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
                  objPrjTabENEx.TabName,
                  clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
                  strQueryString4ParaLst);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");
                strBuilder.Append("\r\n" + "[HttpGet(\"GetMaxStrIdByPrefix\")]");
                strBuilder.AppendFormat("\r\n" + "public ActionResult GetMaxStrIdByPrefix(string strPrefix)",
                        objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
                strBuilder.Append("\r\n" + "{");
                
                strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
                strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
                strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"strPrefix\", strPrefix);", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
                strBuilder.Append("\r\n try");
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\n" + "string strMax{1} = cls{0}BL.GetMaxStrIdByPrefix_S(strPrefix);",
                        objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr, objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnStr =  strMax{0} }});", objPrjTabENEx.KeyPrivFuncFldNameLstStr);

                strBuilder.Append("\r\n }");
                strBuilder.Append("\r\n catch (Exception objException)");
                strBuilder.Append("\r\n {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
                //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
                //strBuilder.Append("\r\n" + "return \"\";");
                strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
                strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
                strBuilder.Append("\r\n }");
                strBuilder.Append("\r\n" + "}");
            }
            return strBuilder.ToString();
        }




        public string Gen_AddNewRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 通过JSON对象来添加记录对象");
            strBuilder.AppendFormat("\r\n /// 调用方法: POST /api/{0}Api/{1}",
             objPrjTabENEx.TabName,
             clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// 在Body区传输obj{0}EN的JSON对象", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">对象</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>是否成功</returns>");
            strBuilder.AppendFormat("\r\n" + "[HttpPost(\"AddNewRecord\")]",
                    objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public ActionResult AddNewRecord([FromBody]cls{0}EN obj{0}EN)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "string str{0}JSONObj = clsJSON.GetJsonFromObj(obj{0}EN);",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03
                && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool")
            {
                if (objKeyField.ObjFieldTabENEx.IsNumberType() == false)
                {
                    strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                        objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " if (obj{0}EN.{1} == 0)",
                        objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
                }
                strBuilder.Append("\r\n" + " {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
                //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

                strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
                //strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
                //strBuilder.Append("\r\n throw new Exception(strMsg);");

                strBuilder.Append("\r\n" + " }");

                strBuilder.AppendFormat("\r\n" + " if (cls{0}BL.IsExist({1}) == true)",
                   objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字:[{{0}}]已经存在!({{1}})\", obj{0}EN.{1}, clsStackTrace.GetCurrClassFunction());",
                    objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
                //strBuilder.Append("\r\n" + " clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

                strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
                //strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
                //strBuilder.Append("\r\n throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + " }");
            }


            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            List<clsConstraintFieldsEN> arrObjLst_Flds = null;
            foreach (clsPrjConstraintEN objInFor in objPrjTabENEx.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                if (objInFor.ConstraintTypeId != enumConstraintType.Uniqueness_01) continue;
                arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId).ToList();

            }


            if (arrObjLst_Flds != null && arrObjLst_Flds.Count() > 0)
            {
                bool bolIsKey = false;
                if (arrObjLst_Flds.Count() == 1)
                {
                    string strKey = arrObjLst_Flds[0].ObjFieldTab().FldName;
                    if (strKey == objKeyField.FldName) bolIsKey = true;
                }
                if (bolIsKey == false)
                {
                    strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}Cond = new();",
                        objPrjTabENEx.TabName);
                    strBuilder.AppendFormat("\r\n" + "string strCondition = obj{0}Cond",
                        objPrjTabENEx.TabName);
                    foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                    {

                        strBuilder.AppendFormat("\r\n" + ".Set{1}(obj{0}EN.{2}, \"=\")",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTab().FldName,
                            objField.ObjFieldTab().PropertyName(this.IsFstLcase));
                    }
                    strBuilder.Append("\r\n" + ".GetCombineCondition();");
              



                strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}BL.IsExistRecord(strCondition);",
                    objPrjTabENEx.TabName);

                strBuilder.Append("\r\n" + "if (bolIsExist)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"满足条件:{0}的记录表中已经存在,违反了唯一性.(from {1})\", strCondition,  clsStackTrace.GetCurrClassFunction());");
                //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
                strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
                    strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");

                    strBuilder.Append("\r\n" + "}");
                }
            }

            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                    objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase), strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                    objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.AppendFormat("\r\n" + "    cls{0}BL.AccessFldValueNull(obj{0}EN);",
      objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.AddNewRecord();",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_AddNewRecordWithMaxId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            List<string> arrKey = new List<string>() {
                enumPrimaryType.StringAutoAddPrimaryKey_03,
                enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06};
            if (arrKey.Contains(objKeyField.PrimaryTypeId) == false) return "";

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";


                clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06)
            {
                if (objPrjTabENEx.PrefixField == null)
                {
                    strBuilder.AppendFormat("\r\n // 表:{0}的主键是前缀自增,但该表中没有一个相关的前缀字段。请检查!(In {1})",
                        objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                    return strBuilder.ToString();
                }
            }
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 通过JSON对象来添加记录对象");
            strBuilder.AppendFormat("\r\n /// 调用方法: POST /api/{0}Api/{1}",
             objPrjTabENEx.TabName,
             clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// 在Body区传输obj{0}EN的JSON对象", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">对象</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>是否成功</returns>");
            strBuilder.AppendFormat("\r\n" + "[HttpPost(\"AddNewRecordWithMaxId\")]",
                    objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public ActionResult AddNewRecordWithMaxId([FromBody]cls{0}EN obj{0}EN)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "string str{0}JSONObj = clsJSON.GetJsonFromObj(obj{0}EN);",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
           


            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "    cls{0}BL.AccessFldValueNull(obj{0}EN);",
      objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "{1} {2} = obj{0}EN.AddNewRecordWithMaxId();",
            objPrjTabENEx.TabName, objKeyField.CsType, objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnStr =  {0} }});", objKeyField.PrivFuncName);

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GoTop(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);

            if (objAdjustOrderNum == null) return "";
            if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把所给的关键字列表相关的记录移顶");
            strBuilder.AppendFormat("\r\n /// 调用方法: POST /api/{0}Api/{1}",
             objPrjTabENEx.TabName,
             clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// 在Body区传输clsOrderByData的JSON对象", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">对象</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>是否成功</returns>");
            strBuilder.Append("\r\n" + "[HttpPost(\"GoTop\")]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult GoTop([FromBody]clsOrderByData objOrderByData)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.Append("\r\n" + "List<string> arrLst = new(objOrderByData.KeyIdLst);");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValueLst\", objOrderByData.ClassificationFieldValueLst);");
            //strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValue2\", objOrderByData.ClassificationFieldValue2);");

                 
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n" + "if (objOrderByData.KeyIdLst.Length == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据关键字列表置顶时,给定的关键字值列表的JSON串不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            if (objKeyField.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0} = new(objOrderByData.KeyIdLst);", objKeyField.FldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0}_T = new(objOrderByData.KeyIdLst);", objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_T.Select(x=>{0}.Parse(x)).ToList();",
                objKeyField.CsType,
                objKeyField.FldName);
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            if (objAdjustOrderNum.arrFieldLst_Classify.Count() > 0)
            {
                strBuilder.Append("\r\n" + "JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);");

                foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                {                    
                    if (string.IsNullOrEmpty(objInFor.FldId) == true) continue;
                    string strTemp = clsPubFun4GC.Gene_GetKeyData(objInFor);
                    strBuilder.Append("\r\n" + strTemp);
                }
                strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.GoTop(lst{1} {2});",
                        objPrjTabENEx.TabName, objKeyField.FldName,
                        objAdjustOrderNum.VarLst == ""? "":$",{objAdjustOrderNum.VarLst}");
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.GoTop(lst{1});", objPrjTabENEx.TabName, objKeyField.FldName);
            }

            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GoBottom(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);
            if (objAdjustOrderNum == null) return "";

            if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把所给的关键字列表相关的记录移底");
            strBuilder.AppendFormat("\r\n /// 调用方法: POST /api/{0}Api/{1}",
             objPrjTabENEx.TabName,
             clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// 在Body区传输clsOrderByData的JSON对象", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">对象</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>是否成功</returns>");
            strBuilder.Append("\r\n" + "[HttpPost(\"GoBottom\")]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult GoBottom([FromBody]clsOrderByData objOrderByData)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
                        
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.Append("\r\n" + "List<string> arrLst = new(objOrderByData.KeyIdLst);");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValueLst\", objOrderByData.ClassificationFieldValueLst);");
            //strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValue2\", objOrderByData.ClassificationFieldValue2);");


            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n" + "if (objOrderByData.KeyIdLst.Length == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据关键字列表置底时,给定的关键字值列表的JSON串不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            if (objKeyField.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0} = new(objOrderByData.KeyIdLst);", objKeyField.FldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0}_T = new(objOrderByData.KeyIdLst);", objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_T.Select(x=>{0}.Parse(x)).ToList();",
                objKeyField.CsType,
                objKeyField.FldName);
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            if (objAdjustOrderNum.arrFieldLst_Classify.Count() > 0)
            {
                strBuilder.Append("\r\n" + "JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);");

                foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                {
                    if (string.IsNullOrEmpty(objInFor.FldId) == true) continue;
                    string strTemp = clsPubFun4GC.Gene_GetKeyData(objInFor);
                    strBuilder.Append("\r\n" + strTemp);
               
                }
                strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.GoBottom(lst{1} {2});",
               objPrjTabENEx.TabName, objKeyField.FldName,
               objAdjustOrderNum.VarLst == "" ? "" : $",{objAdjustOrderNum.VarLst}");
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.GoBottom(lst{1});", objPrjTabENEx.TabName, objKeyField.FldName);
            }

            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");


            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");

            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_ReOrder(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);
            if (objAdjustOrderNum == null) return "";

            if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把所给的关键字列表相关的记录移底");
            strBuilder.AppendFormat("\r\n /// 调用方法: POST /api/{0}Api/{1}",
             objPrjTabENEx.TabName,
             clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// 在Body区传输clsOrderByData的JSON对象", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">对象</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>是否成功</returns>");
            strBuilder.Append("\r\n" + "[HttpPost(\"ReOrder\")]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult ReOrder([FromBody]clsOrderByData objOrderByData)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            //strBuilder.Append("\r\n" + "List<string> arrLst = new(objOrderByData.KeyIdLst);");
            //strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValueLst\", objOrderByData.ClassificationFieldValueLst);");
            //strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValue2\", objOrderByData.ClassificationFieldValue2);");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            //strBuilder.Append("\r\n" + "if (objOrderByData.KeyIdLst.Length == 0)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据关键字列表置底时,给定的关键字值列表的JSON串不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.AppendFormat("\r\n" + "List<string> lst{0} = new(objOrderByData.KeyIdLst);", objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            if (objAdjustOrderNum.arrFieldLst_Classify.Count() > 0)
            {
                strBuilder.Append("\r\n" + "JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);");

                foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                {
                    if (string.IsNullOrEmpty(objInFor.FldId) == true) continue;
                    string strTemp = clsPubFun4GC.Gene_GetKeyData(objInFor);
                    strBuilder.Append("\r\n" + strTemp);
                }
                strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.ReOrder({1});",
                    objPrjTabENEx.TabName, objAdjustOrderNum.VarLst);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.ReOrder();", objPrjTabENEx.TabName, objKeyField.FldName);
            }

            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_UpMove(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);
            if (objAdjustOrderNum == null) return "";

            if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把所给的关键字列表相关的记录上移");
            strBuilder.AppendFormat("\r\n /// 调用方法: POST /api/{0}Api/{1}",
             objPrjTabENEx.TabName,
             clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// 在Body区传输clsOrderByData的JSON对象", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">对象</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>是否成功</returns>");
            strBuilder.Append("\r\n" + "[HttpPost(\"UpMove\")]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult UpMove([FromBody]clsOrderByData objOrderByData)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.Append("\r\n" + "List<string> arrLst = new(objOrderByData.KeyIdLst);");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValueLst\", objOrderByData.ClassificationFieldValueLst);");
            //strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValue2\", objOrderByData.ClassificationFieldValue2);");
            
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n" + "if (objOrderByData.KeyIdLst.Length == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据关键字列表上移时,给定的关键字值列表的JSON串不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            if (objKeyField.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0} = new(objOrderByData.KeyIdLst);", objKeyField.FldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0}_T = new(objOrderByData.KeyIdLst);", objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_T.Select(x=>{0}.Parse(x)).ToList();",
                objKeyField.CsType,
                objKeyField.FldName);
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "foreach(var x in lst{0})", objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            if (objAdjustOrderNum.arrFieldLst_Classify.Count() > 0)
            {
                strBuilder.Append("\r\n" + "JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);");

                foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                {
                    if (string.IsNullOrEmpty(objInFor.FldId) == true) continue;
                    string strTemp = clsPubFun4GC.Gene_GetKeyData(objInFor);
                    strBuilder.Append("\r\n" + strTemp);
                }
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(\"UP\", x {1});",
                        objPrjTabENEx.TabName, objAdjustOrderNum.VarLst == "" ? "" : $",{objAdjustOrderNum.VarLst}");
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(\"UP\", x);",
                 objPrjTabENEx.TabName, objKeyField.FldName);
            }
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnBool = true });");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_DownMove(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);
            if (objAdjustOrderNum == null) return "";

            if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把所给的关键字列表相关的记录下移");
            strBuilder.AppendFormat("\r\n /// 调用方法: POST /api/{0}Api/{1}",
             objPrjTabENEx.TabName,
             clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// 在Body区传输clsOrderByData的JSON对象", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">对象</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>是否成功</returns>");
            strBuilder.Append("\r\n" + "[HttpPost(\"DownMove\")]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult DownMove([FromBody]clsOrderByData objOrderByData)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.Append("\r\n" + "List<string> arrLst = new(objOrderByData.KeyIdLst);");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValueLst\", objOrderByData.ClassificationFieldValueLst);");
            //strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValue2\", objOrderByData.ClassificationFieldValue2);");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n" + "if (objOrderByData.KeyIdLst.Length == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据关键字列表下移时,给定的关键字值列表的JSON串不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            if (objKeyField.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0} = new(objOrderByData.KeyIdLst);", objKeyField.FldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0}_T = new(objOrderByData.KeyIdLst);", objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_T.Select(x=>{0}.Parse(x)).ToList();",
                objKeyField.CsType,
                objKeyField.FldName);
            }
            strBuilder.AppendFormat("\r\n" + "lst{0}.Reverse();", objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "foreach(var x in lst{0})", objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            if (objAdjustOrderNum.arrFieldLst_Classify.Count() > 0)
            {
                strBuilder.Append("\r\n" + "JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);");

                foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                {
                    if (string.IsNullOrEmpty(objInFor.FldId) == true) continue;
                    string strTemp = clsPubFun4GC.Gene_GetKeyData(objInFor);
                    strBuilder.Append("\r\n" + strTemp);
                 
                }
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(\"DOWN\", x {1});",
                  objPrjTabENEx.TabName, objAdjustOrderNum.VarLst == "" ? "" : $",{objAdjustOrderNum.VarLst}");
            }
            else
            {

                strBuilder.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(\"DOWN\", x);",
                 objPrjTabENEx.TabName, objKeyField.FldName);
            }
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnBool = true });");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_UpdateRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 通过JSON对象来修改记录对象");
            strBuilder.AppendFormat("\r\n /// 调用方法: Post /api/{0}Api/{1}",
            objPrjTabENEx.TabName,
            clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// 在Body区传输obj{0}EN的JSON对象", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}JSONObj\">JSON对象字符串</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>是否成功</returns>");
            strBuilder.AppendFormat("\r\n" + "[HttpPost(\"UpdateRecord\")]",
                    objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public ActionResult UpdateRecord([FromBody]cls{0}EN obj{0}EN)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");

            strBuilder.AppendFormat("\r\n" + "string str{0}JSONObj = clsJSON.GetJsonFromObj(obj{0}EN);",
                      objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);",
                      objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            if (IsNumberType4Key == true)
            {
                strBuilder.AppendFormat("\r\n" + " if (obj{0}EN.{1} <= 0)",
                        objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                  objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
            }
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"修改记录时,关键字不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "    cls{0}BL.SetUpdFlag(obj{0}EN);",
                    objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "    cls{0}BL.AccessFldValueNull(obj{0}EN);",
      objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.Update();",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_EditRecordEx(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            IEnumerable<clsConstraintFieldsEN> arrObjLst_Flds = null;
            foreach (clsPrjConstraintEN objInFor in objPrjTabENEx.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                if (objInFor.ConstraintTypeId != enumConstraintType.Uniqueness_01) continue;
                arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId);

            }
            if (arrObjLst_Flds == null || arrObjLst_Flds.Count() == 0) return "";

            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 通过JSON对象来编辑记录对象，存在就修改，不存在就添加");
            strBuilder.AppendFormat("\r\n /// 调用方法: Post /api/{0}Api/{1}",
            objPrjTabENEx.TabName,
            clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// 在Body区传输obj{0}EN的JSON对象", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}JSONObj\">JSON对象字符串</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>是否成功</returns>");
            strBuilder.AppendFormat("\r\n" + "[HttpPost(\"EditRecordEx\")]",
                    objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public ActionResult EditRecordEx([FromBody]cls{0}EN obj{0}EN)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");

            strBuilder.AppendFormat("\r\n" + "string str{0}JSONObj = clsJSON.GetJsonFromObj(obj{0}EN);",
                      objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);",
                      objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            //if (IsNumberType4Key == true)
            //{
            //    strBuilder.AppendFormat("\r\n" + " if (obj{0}EN.{1} <= 0)",
            //            objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
            //}
            //else
            //{
            //    strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
            //      objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
            //}
            //strBuilder.Append("\r\n" + " {");
            //strBuilder.Append("\r\n" + "string strMsg = string.Format(\"修改记录时,关键字不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            ////strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            //strBuilder.Append("\r\n" + " }");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "    cls{0}BL.SetUpdFlag(obj{0}EN);",
                    objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "    cls{0}BL.AccessFldValueNull(obj{0}EN);",
      objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.EditRecordEx();",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_UpdateBySql_XML(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式提供XML串来代表实体对象");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}ObjXml\">需要修改的对象,用XML来表示</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "[HttpGet(\"UpdateBySql_XML\")]", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public ActionResult UpdateBySql_XML(string str{0}ObjXml)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}ObjXml\", str{0}ObjXml);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.UpdateBySql_XML(str{0}ObjXml);",
                    objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_DelRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            //if (objPrjTabENEx.arrKeyFldSet.Count > 1) return "";
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除关键字所指定的记录");
            strBuilder.AppendFormat("\r\n /// 调用方法: DELETE /api/{0}Api/{1}/Id",
                objPrjTabENEx.TabName,
                clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objInFor.ObjFieldTab0().PrivFuncName1());
                }
            }
            else
            {
                strBuilder.AppendFormat("\r\n /// <param name = \"Id\">给定的关键字值</param>", objKeyField.PrivFuncName);
            }
                
            strBuilder.Append("\r\n /// <returns>返回删除的记录数</returns>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strBuilder.Append("\r\n" + "[HttpGet(\"DelRecKeyLst\")]");
                strBuilder.AppendFormat("\r\n" + "public ActionResult DelRecKeyLst({1})",
                objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
                strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
                strBuilder.Append("\r\n" + "{");
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    if (objInFor.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
                    {
                        strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {1}.ToString(),", objInFor.FldName, objInFor.PrivFuncName);
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {1},", objInFor.FldName, objInFor.PrivFuncName);
                    }
                }
                strBuilder.Append("\r\n };");

            }
            else
            {
                strBuilder.Append("\r\n" + "[HttpDelete(\"DelRecord\")]");
                strBuilder.AppendFormat("\r\n" + "public ActionResult DelRecord({1} Id)",
                objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strBuilder.Append("\r\n" + "{");

                strBuilder.AppendFormat("\r\n" + "{0} {1} = Id;",
        objPrjTabENEx.objKeyField0.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
         objPrjTabENEx.objKeyField0.ObjFieldTabENEx.PrivFuncName);
                strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
                strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
                strBuilder.Append("\r\n" + "{");
                if (objKeyField.ObjFieldTab0().IsNumberType() == true)
                {
                    strBuilder.AppendFormat("\r\n" + "[\"Id\"] = {0}.ToString()", objKeyField.PrivFuncName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "[\"Id\"] = {0}", objKeyField.PrivFuncName);
                }
                strBuilder.Append("\r\n };");
            }
           
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    if (objInFor.ObjFieldTab0().IsNumberType() == true)
                    {
                        strBuilder.AppendFormat("\r\n" + " if ({0} <= 0)",
                                objInFor.ObjFieldTab0().PrivFuncName1());
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty({0}) == true)",
                              objInFor.ObjFieldTab0().PrivFuncName1());
                    }
                    strBuilder.Append("\r\n" + " {");
                    strBuilder.Append("\r\n" + "string strMsg = string.Format(\"删除关键字所指定的记录,关键字不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
                    //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
                    strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
                    strBuilder.Append("\r\n" + " }");
                }
            }
            else
            {
                if (IsNumberType4Key == true)
                {
                    strBuilder.AppendFormat("\r\n" + " if ({0} <= 0)",
                            objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty({0}) == true)",
                          objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                }
          
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"删除关键字所指定的记录,关键字不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            }
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.DelRecord({1});",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnInt = intRecNum });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_DelRecordBySP(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "[HttpGet(\"DelRecordBySP\")]", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n" + "public ActionResult DelRecordBySP({1})",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0});",
                      objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.DelRecordBySP({1});",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_DelMultiRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objPrjTabENEx.arrKeyFldSet.Count > 1) return "";
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:同时删除多条记录,删除给定关键字列表的记录");
            strBuilder.AppendFormat("\r\n /// 调用方法: POST /api/{0}Api/{1}",
             objPrjTabENEx.TabName,
            TransKeyWords4FuncName(clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code)));
            strBuilder.AppendFormat("\r\n /// 在Body区传输arr{0}(关键字值列表)的JSON串", objKeyField.FldName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}\">给定的关键字值列表</param>", objKeyField.FldName);
            strBuilder.Append("\r\n /// <returns>返回删除的记录数</returns>");
            strBuilder.AppendFormat("\r\n" + "[HttpPost(\"Del{0}s\")]", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "public ActionResult Del{0}s([FromBody]string[] arr{1})",
                 objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "List<string> arrLst = new(arr{0});", objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.Del{0}s(arrLst);",
                 objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnInt = intRecNum });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_DelRecords(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            //if (objPrjTabENEx.arrKeyFldSet.Count > 1) return "";
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
            string strKeyLstName = "strKeyIdLst";
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strKeyLstName = "arrKeyLsts";
            }
                StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:同时删除多条记录,删除给定关键字列表的记录, 通过JSON串");
            strBuilder.AppendFormat("\r\n /// 调用方法: POST /api/{0}Api/{1}",
             objPrjTabENEx.TabName,
             clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// 在Body区传输strKeyIdLst字符串列表的JSON串", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");            
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值列表的JSON串</param>", strKeyLstName);            
            strBuilder.Append("\r\n /// <returns>返回删除的记录数</returns>");

            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strBuilder.Append("\r\n" + "[HttpPost(\"DelRecKeyLsts\")]");
                strBuilder.AppendFormat("\r\n" + "public ActionResult DelRecKeyLsts([FromBody]string[] arrKeyLsts)",
                     objPrjTabENEx.TabName, objKeyField.FldName);
            }
            else
            {
                strBuilder.Append("\r\n" + "[HttpPost(\"DelRecords\")]");
                strBuilder.AppendFormat("\r\n" + "public ActionResult DelRecords([FromBody]string[] strKeyIdLst)",
                     objPrjTabENEx.TabName, objKeyField.FldName);
            }
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");

            strBuilder.AppendFormat("\r\n" + "List<string> arrKey = new({0});", strKeyLstName);

            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", clsArray.GetSqlInStrByArray(arrKey,true));",
             strKeyLstName);

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.AppendFormat("\r\n" + "  if ({0}.Length == 0)", strKeyLstName);
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据关键字列表串删除记录时,给定的关键字值列表的JSON串不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");

            //strBuilder.AppendFormat("\r\n" + "string[] sstrKeyLst = {0}.Trim().Split(',');",
            //    strKeyLstName);
            //if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            //{
            //    strBuilder.AppendFormat("\r\n" + "List <string> arrKey = new();");
            //}
            //else
            //{
            //    strBuilder.AppendFormat("\r\n" + "List <string> arr{0} = new();", objKeyField.FldName);
            //}
            //strBuilder.AppendFormat("\r\n" + "foreach (string sstrKey in sstrKeyLst)",
            //    objKeyField.PrivFuncName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(sstrKey) == false)");
            //strBuilder.Append("\r\n" + "{");
            //if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            //{
            //    strBuilder.AppendFormat("\r\n" + "arrKey.Add(sstrKey);");
            //}
            //else
            //{
            //    strBuilder.AppendFormat("\r\n" + "arr{0}.Add(sstrKey);", objKeyField.FldName);
            //}
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.DelRecKeyLsts(arrKey);",
            objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.Del{0}s(arrKey);",
            objPrjTabENEx.TabName);
            }
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnInt = intRecNum });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_DelMultiRecordByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
            
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除满足条件的多条记录");
            strBuilder.AppendFormat("\r\n /// 调用方法: POST /api/{0}Api/Del{0}sByCond",
             objPrjTabENEx.TabName,
             clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// 在Body区传输{{\"strWhereCond\":\"1=1\"}}", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">需要删除的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>返回删除的记录数。</returns>");
            strBuilder.AppendFormat("\r\n" + "[HttpGet(\"Del{0}sByCond\")]",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "public ActionResult Del{0}sByCond(string strWhereCond)",
            objPrjTabENEx.TabName);
           
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(strWhereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"删除满足条件的多条记录,条件不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
           
                strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.Del{0}sByCond(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnInt = intRecNum });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string gfunCheckUniqueness()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中某属性(非主键)是否唯一-------------------------------------------;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                if (objField.IsTabUnique == true && objField.FieldTypeId != enumFieldType.KeyField_02)
                {

                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 检查唯一性(Uniqueness)--{0}({1}), 如果不唯一,即存在相同的记录,就返回False",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(主键)</param>",
                    objKeyField.PrivFuncName,
                    objKeyField.ColCaption);
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(要求唯一的字段)</param>",
                    objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
                    strBuilder.Append("\r\n /// <returns></returns>");
                    strBuilder.AppendFormat("\r\npublic static bool Check{0}Uniqueness({1} {2}, {3} {4})",
                    objField.ObjFieldTabENEx.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objField.ObjFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                    strBuilder.Append("\r\nsbCondition.AppendFormat(\"" + objKeyField.FldName + " != '{0}' and "
                  + objField.ObjFieldTabENEx.FldName + " = '{1}'\", " + objKeyField.PrivFuncName + ", " + objField.ObjFieldTabENEx.PrivFuncName + ");");
                    strBuilder.AppendFormat("\r\nif (new cls{0}BL.IsExistRecord(sbCondition.ToString()) == true)",
                    objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nreturn false;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\nelse");
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nreturn true;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\n}");

                }
            }
            ///检查类中某属性(非主键)是否唯一 == == == == == == == == = ;
            return strBuilder.ToString();
        }

        public string gfunCheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\npublic void CheckPropertyNew()");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabNullable == false && objField.ObjFieldTabENEx.IsIdentity == false)
                {
                    strBuilder.Append("\r\nif (Object.Equals(null, " + objField.ObjFieldTabENEx.PrivPropName + ") ");
                    strBuilder.Append("\r\n|| (!Object.Equals(null, " + objField.ObjFieldTabENEx.PrivPropName + ") && " + objField.ObjFieldTabENEx.PrivPropName + " .ToString() == \"\")");
                    if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                    {
                        strBuilder.Append("\r\n|| (!Object.Equals(null, " + objField.ObjFieldTabENEx.PrivPropName + ") && " + objField.ObjFieldTabENEx.PrivPropName + " .ToString() == \"0\")");
                    }
                    strBuilder.Append(")");
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n throw new Exception(\"字段[{0}]不能为空(NULL)!\");",
                    objField.ColCaption);
                    strBuilder.Append("\r\n}");
                }
            }
            ///检查属性长度代码;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strBuilder.Append("\r\nif (!Object.Equals(null, " + objField.ObjFieldTabENEx.PrivPropName + ") && GetStrLen(" + objField.ObjFieldTabENEx.PrivPropName + ") > " + objField.ObjFieldTabENEx.FldLength.ToString().Trim() + ")");
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n throw new Exception(\"字段[{0}]的长度不能超过{1}!\");",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n}");
            ///检查类中属性是否正确 == == ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// 生成代码:提供条件,查询关键字,结果有多个关键字,获取其中的第一个,返回类型是根据字段本身的类型
        /// </summary>
        /// <returns></returns>
        public string Gen_GetFirstID(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的第一条记录的关键字值");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");
            strBuilder.Append("\r\n" + "[HttpGet(\"GetFirstID\")]");
            strBuilder.AppendFormat("\r\npublic ActionResult GetFirstID(string strWhereCond) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(strWhereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据条件获取第一条记录的关键字值时,条件不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");

            strBuilder.Append("\r\n" + " }");
            strBuilder.AppendFormat("\r\n {0} {1};",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n {0} = cls{1}BL.GetFirstID_S(strWhereCond);",
            objKeyField.PrivFuncName, objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnStr = {0} }});", objKeyField.PrivFuncName);

            //strBuilder.AppendFormat("\r\n return {0};", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");

            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //if (IsNumberType4Key == true)
            //{
            //    strBuilder.Append("\r\n return 0;");
            //}
            //else
            //{
            //    strBuilder.Append("\r\n return \"\";");
            //}
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成代码:提供条件,查询相关记录对象,结果有多个对象,获取其中的第一个,返回类型是类类型
        /// </summary>
        /// <returns></returns>
        public string Gen_GetFirstObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的第一条记录的对象");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的第一条记录的对象</returns>");
            strBuilder.Append("\r\n" + "[HttpGet(\"GetFirstObj\")]");
            strBuilder.AppendFormat("\r\npublic ActionResult GetFirstObj(string strWhereCond) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(strWhereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据条件获取第一条对象时,条件不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = cls{0}BL.GetFirstObj_S(strWhereCond);",
            objPrjTabENEx.TabName);

            //strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnObj = obj{0}EN }});", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成代码:根据条件获取JSON对象列表
        /// </summary>
        /// <returns></returns>
        public string Gen_GetObjLstByPager(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件分页获取JSON对象列表");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objPagerPara\">分页获取记录的参数对象</param>");
            strBuilder.Append("\r\n /// <returns>返回JSON对象列表</returns>");
            strBuilder.Append("\r\n [HttpPost(\"GetObjLstByPager\")]");
            strBuilder.AppendFormat("\r\n public ActionResult GetObjLstByPager([FromBody]stuPagerPara objPagerPara)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");


            strBuilder.Append("\r\n" + "objPagerPara.whereCond = objPagerPara.whereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = objPagerPara.GetDictParam();");
      
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(objPagerPara.whereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据条件分页获取JSON对象列表,条件不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " if (objPagerPara.pageSize <=0)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据条件分页获取JSON对象列表,每页记录数:[{0}]不能小于等于0!({1})\", objPagerPara.pageSize, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " if (objPagerPara.pageIndex <=0)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据条件分页获取JSON对象列表,页序号:[{0}]不能小于等于0!({1})\", objPagerPara.pageIndex, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");

            strBuilder.AppendFormat("\r\n List<cls{0}EN> arr{0}ObjLst;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n arr{0}ObjLst = cls{0}BL.GetObjLstByPager(objPagerPara);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            //strBuilder.AppendFormat("\r\n return arr{0}ObjLst;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnObjLst = arr{0}ObjLst }});", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }

        public string Gen_GetObjLstByPagerCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件分页获取JSON对象列表");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objPagerPara\">分页获取记录的参数对象</param>");
            strBuilder.Append("\r\n /// <returns>返回JSON对象列表</returns>");
            strBuilder.Append("\r\n [HttpPost(\"GetObjLstByPagerCache\")]");
            strBuilder.AppendFormat("\r\n public ActionResult GetObjLstByPagerCache([FromBody]stuPagerPara objPagerPara)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n" + "objPagerPara.whereCond = objPagerPara.whereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = objPagerPara.GetDictParam();");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(objPagerPara.whereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据条件分页获取JSON对象列表,条件不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " if (objPagerPara.pageSize <=0)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据条件分页获取JSON对象列表,每页记录数:[{0}]不能小于等于0!({1})\", objPagerPara.pageSize, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " if (objPagerPara.pageIndex <=0)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据条件分页获取JSON对象列表,页序号:[{0}]不能小于等于0!({1})\", objPagerPara.pageIndex, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");

            strBuilder.AppendFormat("\r\n IEnumerable<cls{0}EN> arr{0}ObjLst;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n arr{0}ObjLst = cls{0}BL.GetObjLstByPagerCache(objPagerPara);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            //strBuilder.AppendFormat("\r\n return arr{0}ObjLst;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnObjLst = arr{0}ObjLst }});", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }

        public string Gen_GetSubObjLstCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件分页获取JSON对象列表");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objPagerPara\">分页获取记录的参数对象</param>");
            strBuilder.Append("\r\n /// <returns>返回JSON对象列表</returns>");
            strBuilder.AppendFormat("\r\n [HttpPost(\"GetSubObjLstCache\")]", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public ActionResult GetSubObjLstCache([FromBody]cls{0}EN obj{0}Cond)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "string str{0}JSONObj = clsJSON.GetJsonFromObj(obj{0}Cond);",
  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
  
            strBuilder.AppendFormat("\r\n IEnumerable<cls{0}EN> arr{0}ObjLst;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "if (obj{0}Cond.sfFldComparisonOp == null)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}Cond.dicFldComparisonOp = null;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}Cond.dicFldComparisonOp = JsonConvert.DeserializeObject<Dictionary<string, string>>(obj{0}Cond.sfFldComparisonOp);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "cls{0}BL.SetUpdFlag(obj{0}Cond);", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n arr{0}ObjLst = cls{0}BL.GetSubObjLstCache(obj{0}Cond);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            //strBuilder.AppendFormat("\r\n return arr{0}ObjLst;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnObjLst = arr{0}ObjLst }});", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }


        /// <summary>
        /// 生成代码:根据条件获取JSON对象列表
        /// </summary>
        /// <returns></returns>
        public string Gen_GetObjLstByRange(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取范围内的对象列表");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// 调用方法: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objRangePara\">根据范围获取记录的参数对象</param>");
 
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.Append("\r\n [HttpPost(\"GetObjLstByRange\")]");
            strBuilder.AppendFormat("\r\n public ActionResult GetObjLstByRange([FromBody]stuRangePara objRangePara)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            
            strBuilder.Append("\r\n" + "objRangePara.whereCond = objRangePara.whereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = objRangePara.GetDictParam();");
     
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(objRangePara.whereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据条件获取范围内的对象列表,条件不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " if (objRangePara.minNum <0)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据条件分页获取JSON对象列表,最小记录号:[{0}]不能小于0!({1})\", objRangePara.minNum, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " if (objRangePara.maxNum <0)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据条件分页获取JSON对象列表,最大记录号:[{0}]不能小于0!({1})\", objRangePara.maxNum, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " if (objRangePara.maxNum <= objRangePara.minNum)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据条件分页获取JSON对象列表,最大记录号:[{0}]不能小于等于最小记录号:[{1}]!({2})\", objRangePara.maxNum, objRangePara.minNum, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.AppendFormat("\r\n List<cls{0}EN> arr{0}ObjLst;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n arr{0}ObjLst = cls{0}BL.GetObjLstByRange(objRangePara);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            //strBuilder.AppendFormat("\r\n return arr{0}ObjLst;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnObjLst = arr{0}ObjLst }});", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }

        public string Gen_UpdateWithCondition(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件来修改记录对象");
            strBuilder.AppendFormat("\r\n /// 调用方法: Post /api/{0}Api/{1}",
            objPrjTabENEx.TabName,
            clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// 在Body区传输obj{0}EN的JSON对象和strWhereCond条件串", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}JSONObj\">JSON对象字符串</param>",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>是否成功</returns>");
            strBuilder.Append("\r\n" + "[HttpPost(\"UpdateWithCondition\")]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult UpdateWithCondition(cls{0}EN obj{0}EN, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WebApi.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileName为空,请检查!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " }");

            strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(strWhereCond) == true)");

            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据条件修改记录时,条件不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "    cls{0}BL.AccessFldValueNull(obj{0}EN);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.UpdateWithCondition(strWhereCond);",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_AddNewRecordWithReturnKey(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
            List<string> arrKey = new List<string>() { enumPrimaryType.Identity_02 , enumPrimaryType.StringAutoAddPrimaryKey_03, enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06, enumPrimaryType.PrimaryKey_01};
            if (arrKey.Contains( objKeyField.PrimaryTypeId) == false) return "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)");
            strBuilder.AppendFormat("\r\n /// 调用方法: POST /api/{0}Api/{1}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// 在Body区传输obj{0}EN的JSON对象", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的表对象</param>",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>返回新添加记录的关键字</returns>");

            strBuilder.AppendFormat("\r\n" + "[HttpPost(\"AddNewRecordWithReturnKey\")]",
                        objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public ActionResult AddNewRecordWithReturnKey(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WebApi.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileName为空,请检查!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"obj{0}EN\", JsonConvert.SerializeObject(obj{0}EN));", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " }");


            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "    cls{0}BL.AccessFldValueNull(obj{0}EN);",
      objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "string strKey = cls{0}BL.AddNewRecordBySql2WithReturnKey(obj{0}EN);",
            objPrjTabENEx.TabName);
 
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 0, errorMsg = \"\", returnStr =  strKey });");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //            strBuilder.Append("\r\n return \"\";");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

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
                    strBuilder.Append("\r\n" + strTemp);
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
            return strBuilder.ToString();
        }

        public override void GetClsName()
        {
            this.ClsName = string.Format("{0}ApiController", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }

        public string Gen_4WA_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            //            string[] sstrParaLst = objWebSrvFunctionsENEx.FuncParaLst.Split('|');
            //List<clsvWebSrvFuncParaEN> arrvWebSrvFuncParaObjLst =
            //    clsvWebSrvFuncParaBLEx.GetvWebSrvFuncParaObjLstByFuncId(objWebSrvFunctionsENEx.WebSrvFunctionId);
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
                strBuilder.AppendFormat("\r\n" + "public static {0} {1}({2})",
                        objSelfDefDataTypeEN.CsType, objWebSrvFunctionsENEx.FunctionName,
                        sbParaList.ToString());
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "public static {0} {1}({2})",
                            objFuncReturnTypeEN.CsType, objWebSrvFunctionsENEx.FunctionName,
                            sbParaList.ToString());
            }
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}SoapClient obj{0}Service = Get{0}SoapClient();",
                    objWebSrvClassENEx.ClsName);
            //strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objSelfDefDataTypeEN != null)
            {
                strBuilder.AppendFormat("\r\n" + "{0} {1} = obj{2}Service.{3}({4});",
                     objSelfDefDataTypeEN.CsType,
                     objSelfDefDataTypeEN.DefaVarName,
                     objWebSrvClassENEx.ClsName,
                     objWebSrvFunctionsENEx.FunctionName,
                     sbParaVarList.ToString());
                strBuilder.AppendFormat("\r\n" + "return {0};", objSelfDefDataTypeEN.DefaVarName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "{0} {1}Temp = obj{2}Service.{3}({4});",
                    objFuncReturnTypeEN.CsType,
                    objFuncReturnTypeEN.DataTypeAbbr,
                    objWebSrvClassENEx.ClsName,
                    objWebSrvFunctionsENEx.FunctionName,
                    sbParaVarList.ToString());
                strBuilder.AppendFormat("\r\n" + "return {0}Temp;", objFuncReturnTypeEN.DataTypeAbbr);
            }
            //strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strBuilder.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strBuilder.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

    }
}
