using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
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
    partial class NodeWA_Access4CSharp : clsGeneCodeBase4Tab
    {
        private string strKeyFldName_ObjName = "";

        #region 构造函数

        public NodeWA_Access4CSharp(string strTabId,  string strPrjDataBaseId, string strPrjId)
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
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);


            objPrjTabENEx.ClsName = string.Format("cls{0}WApi", objPrjTabENEx.TabName);
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebApiTransferLevel;

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

                //类名开始

                strBuilder.Append("\r\n" + "using System;"); //
                strBuilder.Append("\r\n" + "using System.Data; "); //
                strBuilder.Append("\r\n" + "using System.Data.SqlClient;");
                strBuilder.Append("\r\n" + "using System.Text; "); //
                strBuilder.Append("\r\n" + "using System.Web;"); //
                strBuilder.Append("\r\n" + "using System.Collections; "); //
                strBuilder.Append("\r\n" + "using System.Collections.Generic;"); //
                strBuilder.Append("\r\n" + "using System.ComponentModel;"); //
                strBuilder.Append("\r\n" + "using System.Linq;"); //
                strBuilder.Append("\r\n" + "using System.Reflection;"); //

                strBuilder.AppendFormat("\r\n" + "using Newtonsoft.Json;"); //
                strBuilder.AppendFormat("\r\n" + "using Newtonsoft.Json.Linq; using Comm.WebApi;"); //
                                                                                 // strBuilder.AppendFormat("\r\n" + "using {1}4WS.ServiceReference{0};", objPrjTabENEx.TabName, objProject.PrjDomain); //

                strBuilder.Append("\r\n" + "using com.taishsoft.common;"); //
                strBuilder.Append("\r\n" + "using com.taishsoft.comm_db_obj;"); //
                strBuilder.Append("\r\n" + "using com.taishsoft.dynamiccompiler;"); //
                strBuilder.Append("\r\n" + "using com.taishsoft.json;"); //
                //strBuilder.Append("\r\n" + "using System.ServiceModel;"); //
                strBuilder.AppendFormat("\r\n" + "using {0}.Entity;", objProjectsENEx.PrjDomain);

           
                //strBuilder.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProjectsENEx.PrjDomain);


                strBuilder.Append("\r\n" + ""); //
                                                //if (objPrjTabENEx.IsForSilverLight == true)
                                                //{
                                                //    strBuilder.AppendFormat("\r\n" + "namespace SL4WS",
                                                //    objProject.PrjDomain);
                                                //}
                                                //else
                                                //{
                strBuilder.AppendFormat("\r\n" + "namespace {0}4WApi",
                objProject.PrjDomain);
                //}
                strBuilder.Append("\r\n" + "{");

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Static = arrvFunction4GeneCodeObjLst.Where(x => x.FuncTypeId == enumFunctionType.PureStaticFunction_12);
                if (arrvFunction4GeneCodeObjLst_Static.Count() > 0)
                {
                    strBuilder.AppendFormat("\r\n" + "public static class  {0}_Static", objPrjTabENEx.ClsName);
                    strBuilder.Append("\r\n" + "{");
                    foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_Static)
                    {
                        //clsFunction4GeneCodeEN objFunction4GeneCodeEN1 = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                        strFuncName = objvFunction4GeneCodeEN.FuncName;

                        if (strFuncName.Substring(0, 6) == "Print:")
                        {
                            strBuilder.Append("\r\n" + "");
                            strBuilder.Append("\r\n" + "");
                            strBuilder.Append("\r\n " + strFuncName.Substring(6));
                            continue;
                        }
                        try
                        {
                            objPrjTabENEx.FuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
                            if (objvFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                            {
                                strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                                    objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                            }
                            else
                            {
                                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
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
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strBuilder.Append("\r\n" + strTemp);
                        }
                    }
                    strBuilder.Append("\r\n" + "}");

                }





                //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN21 = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4WA_GeneEnumConstList");
                strTemp = A_GeneFuncCodeByFuncName("Gen_4WA_GeneEnumConstList");
                strBuilder.Append(strTemp);
                //objvFunction4GeneCodeEN1 = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4WA_GeneEnumConstList4Field");
                strTemp = A_GeneFuncCodeByFuncName("Gen_4WA_GeneEnumConstList4Field");
                strBuilder.Append(strTemp);

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strBuilder.AppendFormat("\r\n /// For SilverLight");
                //}
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.Append("\r\n" + "public class " + objPrjTabENEx.ClsName);
                strBuilder.Append("\r\n" + "{");


                strBuilder.AppendFormat("\r\n" + "private static readonly string mstrApiControllerName = \"{0}Api\";",
                    objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "private static string mstrDir = \"0\";");

                //私有属性名-----和属性过程
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                       objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 从缓存中查找失败的次数");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "protected static int intFindFailCount = 0;");

                //私有属性名-----和属性过程
                //strBuilder.AppendFormat("\r\n" + "private static {0}ServiceSoapClient obj{0}ServiceSoapClient = null;",
                //objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n /// <summary>");
                //strBuilder.Append("\r\n /// ");
                //strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strBuilder.Append("\r\n /// </summary>");
                //strBuilder.Append("\r\n /// <returns></returns>");
                //strBuilder.AppendFormat("\r\n" + "public static {0}ServiceSoapClient Get{0}ServiceSoapClient()",
                //objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.AppendFormat("\r\n" + "if (obj{0}ServiceSoapClient == null)",
                //objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.Append("\r\n" + "BasicHttpBinding binding = new BasicHttpBinding();");
                //strBuilder.AppendFormat("\r\n" + "binding.Name = \"{0}ServiceSoap\";",
                //objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "binding.CloseTimeout = new System.TimeSpan(6000);");
                //strBuilder.Append("\r\n" + "binding.MaxReceivedMessageSize = 2147483647;");
                ////                strBuilder.Append("\r\n" + "String strServiceUrl = String.Empty;");
                //strBuilder.Append("\r\n" + "string strServiceUrl = GetServiceUrl(mstrApiControllerName, ref mstrDir);");
                ////strBuilder.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false)");
                ////strBuilder.Append("\r\n" + "{");
                ////strBuilder.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{{1}}/{2}Service.asmx\", clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx);",
                ////"{", "}", objPrjTabENEx.TabName);
                ////strBuilder.Append("\r\n" + "}");
                ////strBuilder.Append("\r\n" + "else");
                ////strBuilder.Append("\r\n" + "{");
                ////strBuilder.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{2}Service.asmx\", clsSysPara4WebApi.strCurrIPAddressAndPort_Local);",
                ////"{", "}", objPrjTabENEx.TabName);
                ////strBuilder.Append("\r\n" + "}");

                //strBuilder.Append("\r\n" + "EndpointAddress address = new EndpointAddress(strServiceUrl);");

                //strBuilder.AppendFormat("\r\n" + "return new {0}ServiceSoapClient(binding, address);",
                //objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "}");
                //strBuilder.Append("\r\n" + "else");
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.AppendFormat("\r\n" + "return obj{0}ServiceSoapClient;",
                //objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "}");
                //strBuilder.Append("\r\n" + "}");
                //生成所有的函数

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_NotStatic = arrvFunction4GeneCodeObjLst.Where(x => x.FuncTypeId != enumFunctionType.PureStaticFunction_12);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_NotStatic)
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
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
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
                Type t = typeof(NodeWA_Access4CSharp);
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


        public string Gen_4WA_ClassConstructor1()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///类构造器----------------------------------------------;
            strBuilder.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }

        public string Gen_4WA_CheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckPropertyNew(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.IsTabNullable = false && objField.FieldTypeId != "02")
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                        continue;
                    }
                    strBuilder.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        strPrivPropNameWithObjectName);
                    strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString() == \"\")",
                         strPrivPropNameWithObjectName);

                    if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                    {
                        strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString() == \"0\")",
                             strPrivPropNameWithObjectName);
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
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strBuilder.AppendFormat("\r\nif (!Object.Equals(null, {0}) && GetStrLen({0}) > {1})",
                         strPrivPropNameWithObjectName,
                          objField.ObjFieldTabENEx.FldLength);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n throw new Exception(\"字段[{0}]的长度不能超过{1}!\");",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            ///检查类中属性是否正确 == == ;
            return strBuilder.ToString();
        }

        /// <summary>");
        /// 根据条件获取数据表,用DataTable表示");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">表对象</param>");
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public string Gen_4WA_GetDataTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取数据表,用DataTable表示");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回满足条件一定范围的DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSet(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
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

        /// <summary>;
        /// 根据函数对象,生成相关的服务转换层函数;
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">表对象</param>;
        /// <returns>返回满足条件一定范围的DataTable</returns>
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
        /// <summary>");
        /// 根据条件获取数据表,用DataTable表示");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">表对象</param>");
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public string Gen_4WA_GetTopDataTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取数据表,用DataTable表示");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回满足条件一定范围的DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.GetTopDataSet(intTopSize, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
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


        /// <summary>");
        /// 根据条件获取一定范围的数据表,用DataTable表示");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">表对象</param>");
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public string Gen_4WA_GetDataTableByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取一定范围的数据表,用DataTable表示");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.Append("\r\n /// <returns>返回满足条件一定范围的DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
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
        /// <summary>
        /// 获取表View的DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetDataTableV()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取表视图的DataTable");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>表视图的DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableV(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
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
        /// <summary>");
        /// 根据条件获取一定范围的数据表,用DataTable表示");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">表对象</param>");
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public string Gen_4WA_GetDataTableVByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取一定范围的数据表,用DataTable表示");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.Append("\r\n /// <returns>返回满足条件一定范围的DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableVByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetVByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
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

        /// <summary>
        /// 获取表View的DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetDataTableV2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取满足条件的表视图的DataTable");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>表视图的DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable Get{0}V(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
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

        /// <summary>");
        /// 根据条件获取一定范围的数据表,用DataTable表示");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">表对象</param>");
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public string Gen_4WA_GetDataTableV2ByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取一定范围的数据表,用DataTable表示");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.Append("\r\n /// <returns>返回满足条件一定范围的DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableVByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetVByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
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
        public string Gen_4WA_GetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}Cond\">给定条件的条件对象</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLst(cls{0}EN obj{0}Cond)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "string strAction = \"GetObjLst\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}Cond);", objPrjTabENEx.TabName);
            //if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)

                strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strBuilder.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return null;");
         

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"获取条件对象列表出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4WA_GetObjLstByKeyLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字列表获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstBy{1}Lst(List<{2}> arr{1})", 
                    objPrjTabENEx.TabName                ,
                    objKeyField.FldName_FstUcase,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "string strAction = \"GetObjLstBy{0}Lst\";",
                objKeyField.FldName_FstUcase);
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            //strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst(arr{0});", objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strBuilder.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return null;");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据关键字列表获取对象列表出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }


        public string Gen_4WA_GetTopObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取顶部对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objTopPara\">获取顶部对象列表的参数对象</param>");     
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetTopObjLst(stuTopPara objTopPara)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "string strAction = \"GetTopObjLst\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = objTopPara.GetDictParam();");
 
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strBuilder.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return null;");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据条件获取顶部对象列表,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4WA_GetServiceUrl()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取Web服务的地址");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>返回当前文件中Web服务的地址</returns>");

            strBuilder.Append("\r\npublic static string GetServiceUrl(string strPageName, ref string strDir)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n" + "String strServiceUrl = String.Empty;");
            strBuilder.Append("\r\n" + "if (strDir == \"0\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strDir = clsDict_PageName_Dic.GetDir4PageName(strPageName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}/{2}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx, strPageName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}/{2}/{3}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx, strDir, strPageName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort_Local,");
            strBuilder.Append("\r\n" + "strPageName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}/{2}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort_Local, strDir, strPageName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return strServiceUrl;");
            strBuilder.Append("\r\n" + "}");

            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public string Gen_4WA_GetWebApiUrl_SelfDefWS()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取Web服务的地址");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>返回当前文件中Web服务的地址</returns>");

            strBuilder.Append("\r\npublic static string GetServiceUrl(string strApiControllerName, string strAction, ref string strDir)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n" + "String strServiceUrl = String.Empty;");
            strBuilder.Append("\r\n" + "if (strDir == \"0\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strDir = clsDict_PageName_Dic.GetDir4PageName(strApiControllerName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/api/{1}/{2}/{3}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx, strApiControllerName, strAction);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/api/{1}/{2}/{3}/{4}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx, strDir, strApiControllerName, strAction);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/api/{1}/{2}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort_Local,");
            strBuilder.Append("\r\n" + "strApiControllerName, strAction);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/api/{1}/{2}/{3}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort_Local, strDir, strApiControllerName, strAction);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return strServiceUrl;");
            strBuilder.Append("\r\n" + "}");

            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }


        public string Gen_4WA_GetObjLstByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取范围内的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objRangePara\">根据范围获取记录的参数对象</param>");

            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByRange(stuRangePara objRangePara)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "string strAction = \"GetObjLstByRange\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam =  objRangePara.GetDictParam();");
         
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strBuilder.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return null;");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strBuilder.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strBuilder.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public string Gen_4WA_GetObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件分页获取JSON对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objPagerPara\">分页获取记录的参数对象</param>");
            strBuilder.Append("\r\n /// <returns>返回JSON对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByPager(stuPagerPara objPagerPara)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "string strAction = \"GetObjLstByPager\";");
            
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = objPagerPara.GetDictParam();");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strBuilder.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return null;");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strBuilder.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strBuilder.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// 获取表对象的所有属性
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetNodeProperty4Object()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据对象的关键字值,获取对象的全部属性");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">相关对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "/// <returns>是否成功</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool Get{0}(ref cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}Service.Get{0}(ref obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 获取表对象的所有属性
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjByKeyId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 获取当前关键字的记录对象,用对象的形式表示.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>表对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}({2})",
            objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strAction = \"GetObjBy{0}\";", objKeyField.FldName);
            
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
            {
                strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {1}.ToString()", objKeyField.FldName, objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {1}", objKeyField.FldName, objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "obj{0}EN = clsJSON.GetObjFromJson<cls{0}EN>(strResult);", objPrjTabENEx.TabName);
            
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObj\"]);");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = JsonConvert.DeserializeObject<cls{0}EN>(strJson);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\n" + "return bolReturnBool;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return null;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"获取条件记录出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");


            //strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);

            //strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = obj{0}Service.GetObjBy{2}({1});",
            //objPrjTabENEx.TabName, objKeyField.PrivFuncName, objKeyField.FldName);
            //strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 删除单条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_DelNode()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字删除记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>实际删除记录的个数</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int DelNode({1} {0})",
            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strAction = \"DelNode\";");
            
            
     

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, {0}.ToString(), out string strResult, out string strErrMsg) == true)",
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "int intResult  = int.Parse(strResult);");
            //strBuilder.Append("\r\n" + "return intResult;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strBuilder.Append("\r\n" + "return intReturnInt;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return 0;");

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

        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_DelMultiNode()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字列表删除记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>实际删除记录的个数</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int Del{0}s(List<string> arr{1})",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strAction = \"Del{0}s\";", objPrjTabENEx.TabName);
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
           

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst(arr{0});",
                objKeyField.FldName);

            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "int intResult  = int.Parse(strResult);");
            //strBuilder.Append("\r\n" + "return intResult;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strBuilder.Append("\r\n" + "return intReturnInt;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return 0;");

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


        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_DelNodes()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字列表删除记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>实际删除记录的个数</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int DelNodes(string strKeyIdLst)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strAction = \"DelNodes\";", objPrjTabENEx.TabName);
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");


            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst(strKeyIdLst);",
            //    objKeyField.FldName);

            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "int intResult  = int.Parse(strResult);");
            //strBuilder.Append("\r\n" + "return intResult;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strBuilder.Append("\r\n" + "return intReturnInt;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return 0;");

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

        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_DelMultiNodeByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件删除记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>实际删除记录的个数</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int Del{0}sByCond(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strAction = \"Del{0}sByCond\";", objPrjTabENEx.TabName);
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");          
            //strBuilder.Append("\r\n" + "  int intRecCount =  int.Parse(strResult);");
            //strBuilder.Append("\r\n" + "return intRecCount;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strBuilder.Append("\r\n" + "return intReturnInt;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return 0;");

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


        public string Gen_4WA_AddNewNodeWithMaxId()
        {
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>是否成功?</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewNodeWithMaxId(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strAction = \"AddNewNodeWithMaxId\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "bool bolResult = bool.Parse(strResult);");
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strBuilder.Append("\r\n" + "return bolReturnBool;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return false;");
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

        public string Gen_4WA_AddNewNode()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>是否成功?</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewNode(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strAction = \"AddNewNode\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
         
            strBuilder.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
                objPrjTabENEx.TabName);
            
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "bool bolResult = bool.Parse(strResult);");
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strBuilder.Append("\r\n" + "return bolReturnBool;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return false;");
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
        public string Gen_4WA_DefineObjCommFun4BL()
        {

            StringBuilder strBuilder = new StringBuilder();

            ///类构造器----------------------------------------------;
            strBuilder.Append("\r\n" + " /// <summary>");
            strBuilder.Append("\r\n" + "/// 专门在逻辑层用于处理缓存等公共函数的对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n" + "/// </summary>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.Append("\r\n" + "public static clsCommFun4BL objCommFun4BL = null;");
            }
            else
            {
                strBuilder.Append("\r\n" + "public static clsCommFun4BLV2 objCommFun4BL = null;");
            }
            //strBuilder.Append("\r\n" + "public static event OnAddNewNode onAddNewNode;");
            //strBuilder.Append("\r\n" + "public static event OnUpdateNode onUpdateNode;");
            //strBuilder.Append("\r\n" + "public static event OnDeleteNode onDelNode;");

            return strBuilder.ToString();
        }

        public string Gen_4WA_CopyObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把同一个类的对象,复制到另一个对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static void CopyTo(cls{0}EN obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //只写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }

            //strBuilder.AppendFormat("\r\n" + "{0}DA.CopyTo(obj{0}ENS, obj{0}ENT);",
            //objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyTo", "Copy表:{0} 对象数据出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})Copy表对象数据出错,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy表:{0} 对象数据出错!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy表:{0} 对象数据出错!({1}: CopyTo)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4WA_ToDataTable()
        {
            StringBuilder strBuilder = new StringBuilder();
 
            strBuilder.Append("\r\n" + "/// <summary>");
            strBuilder.Append("\r\n" + "/// 对象列表 转换为 DataTable数据集合");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n" + "/// </summary>");
            strBuilder.Append("\r\n" + "/// <param name=\"arrObj\">原对象列表</param>");
            strBuilder.Append("\r\n" + "/// <returns>返回的DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable ToDataTable(List<cls{0}EN> arrObj)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable dataTable = new DataTable(); //实例化");
            strBuilder.Append("\r\n" + "DataTable result;");

            strBuilder.Append("\r\n" + "if (arrObj.Count == 0) return null;");
            strBuilder.AppendFormat("\r\n" + "if (cls{0}EN._AttributeName.Length == 0)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "result = dataTable;");
            strBuilder.Append("\r\n" + "return result;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "Type type = typeof(cls{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "PropertyInfo[] arrPropertyInfo = type.GetProperties();");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//Columns");
            strBuilder.AppendFormat("\r\n" + "foreach (string strAttrName in cls{0}EN._AttributeName)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();");
            strBuilder.Append("\r\n" + "dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in arrObj)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//Rows");
            strBuilder.Append("\r\n" + "DataRow dataRow = dataTable.NewRow();");
            strBuilder.AppendFormat("\r\n" + "foreach (string strAttrName in cls{0}EN._AttributeName)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "dataRow[strAttrName] = objInFor[strAttrName];");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "dataTable.Rows.Add(dataRow); //循环添加行到DataTable中");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objExceptoin)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw objExceptoin;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "result = dataTable;");
            strBuilder.Append("\r\n" + "return result;");
            strBuilder.Append("\r\n" + "}");

            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }



        public string Gen_4WA_UpdateNode()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 修改记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>是否成功?</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateNode(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.sfUpdFldSetStr) == true)", objPrjTabENEx.TabName); 
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).\",");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1}, clsStackTrace.GetCurrClassFunction());", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "string strAction = \"UpdateNode\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
                       
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "bool bolResult = bool.Parse(strResult);");
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strBuilder.Append("\r\n" + "return bolReturnBool;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return false;");

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

        public string Gen_4WA_IsExistNode()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件判断是否存在记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>是否存在?存在返回True</returns>");
            strBuilder.Append("\r\n" + "public static bool IsExistNode(string strWhereCond)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//检测记录是否存在");
            strBuilder.Append("\r\n" + "string strAction = \"IsExistNode\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");       
            strBuilder.Append("\r\n" + "return bolReturnBool;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");          
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return false;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"获取条件记录出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            //strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "bool bolIsExist = obj{0}Service.IsExistNode(strWhereCond);",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4WA_GetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相关记录数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}Cond\">给定条件的条件对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>记录数</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int GetRecCountByCond(cls{0}EN obj{0}Cond)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strAction = \"GetRecCountByCond\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}Cond);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "return int.Parse(strResult);");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strBuilder.Append("\r\n" + "return intReturnInt;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return 0;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"获取条件记录出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");


            //strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "int intRecCount = obj{0}Service.GetRecCountByCond(strWhereCond);",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return intRecCount;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4WA_GetFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相关记录数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>记录数</returns>");
            strBuilder.Append("\r\n" + "public static List<string> GetFldValue(string strFldName, string strWhereCond)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strAction = \"GetFldValue\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strFldName\"] = strFldName,");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "return int.Parse(strResult);");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "const arrReturnStrLst = (List<string>)jobjReturn0[\"returnStrLst\"];");
            //strBuilder.Append("\r\n" + "return arrReturnStrLst;");
            strBuilder.Append("\r\n" + "string strReturnStrLst = (string)jobjReturn0[\"returnStrLst\"];");
            strBuilder.Append("\r\n" + "const arrReturnStrLst = strReturnStrLst.Split(\",\".ToCharArray());");
            strBuilder.Append("\r\n" + "return arrReturnStrLst.Select(x => x).ToList();");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return null;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"获取条件记录出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");


            //strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "int intRecCount = obj{0}Service.GetRecCountByCond(strWhereCond);",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return intRecCount;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_4WA_funSetFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件设置字段值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">值</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>记录数</returns>");
            strBuilder.Append("\r\n" + "public static int SetFldValue(string strFldName, string strValue, string strWhereCond)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strAction = \"SetFldValue\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strFldName\"] = strFldName,");
            strBuilder.Append("\r\n" + "[\"strValue\"] = strValue,");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "return int.Parse(strResult);");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "const arrReturnStrLst = (List<string>)jobjReturn0[\"returnStrLst\"];");
            //strBuilder.Append("\r\n" + "return arrReturnStrLst;");
            strBuilder.Append("\r\n" + "const intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strBuilder.Append("\r\n" + "return intReturnInt;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return 0;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据条件设置字段值,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");


            //strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "int intRecCount = obj{0}Service.GetRecCountByCond(strWhereCond);",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return intRecCount;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4WA_IsExist()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字判断是否存在记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>是否存在?存在返回True</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool IsExist({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//检测记录是否存在");
            strBuilder.Append("\r\n" + "string strAction = \"IsExist\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
            {
                strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {1}.ToString()", objKeyField.FldName, objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {1}", objKeyField.FldName, objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "bool bolIsExist = bool.Parse(strResult);");
            //strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");            
            strBuilder.Append("\r\n" + "return bolReturnBool;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return false;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"获取条件记录出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            //strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "bool bolIsExist = obj{0}Service.IsExist({1});",
            //objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            //strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_4WA_GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");
                strBuilder.AppendFormat("\r\n" + "public static string GetMaxStrId()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "string strAction = \"GetMaxStrId\";");
                
                
                strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
              

                strBuilder.Append("\r\n" + "try");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
                strBuilder.Append("\r\n" + "{");
                //strBuilder.AppendFormat("\r\n" + "string strMax{0} = strResult;",
                //objKeyField.FldName_FstUcase);
                //strBuilder.AppendFormat("\r\n" + "return strMax{0};",
                //objKeyField.FldName_FstUcase);
                strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
                strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "const strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                strBuilder.Append("\r\n" + "return strReturnStr;");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
                strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else return \"\";");

                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "catch (Exception objException)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"获取最大值出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
                strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
                               
                strBuilder.Append("\r\n" + "}");
            }
            return strBuilder.ToString();
        }
        public string Gen_4WA_GetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");
                strBuilder.AppendFormat("\r\n" + "public static string GetMaxStrIdByPrefix(string strPrefix)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "//检测记录是否存在");
                strBuilder.Append("\r\n" + "string strAction = \"GetMaxStrIdByPrefix\";");
                
                
                strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
                strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"strPrefix\", strPrefix);", objPrjTabENEx.TabName);

                strBuilder.Append("\r\n" + "try");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
                strBuilder.Append("\r\n" + "{");
                //strBuilder.AppendFormat("\r\n" + "string strMax{0} = strResult;",
                //objKeyField.FldName_FstUcase);
                //strBuilder.AppendFormat("\r\n" + "return strMax{0};",
                //objKeyField.FldName_FstUcase);
                strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
                strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "const strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                strBuilder.Append("\r\n" + "return strReturnStr;");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
                strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");

                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else return \"\";");

                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "catch (Exception objException)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"根据前缀获取最大值出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
                strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");

                strBuilder.Append("\r\n" + "}");
            }
            return strBuilder.ToString();
        }
        
        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetFirstID()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的第一条记录的关键字值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");
            strBuilder.AppendFormat("\r\n" + "public static {0} GetFirstID(string strWhereCond)",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n" + "{");       

            strBuilder.Append("\r\n" + "string strAction = \"GetFirstID\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            switch (objKeyField.CsType)
            {
                case "long":
                    //strBuilder.Append("\r\n" + "return long.Parse(strResult);");
                    strBuilder.Append("\r\n" + "const strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                    strBuilder.Append("\r\n" + "return long.Parse(strReturnStr);");
                    break;
                case "int":
                    //strBuilder.Append("\r\n" + "return int.Parse(strResult);");
                    strBuilder.Append("\r\n" + "const strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                    strBuilder.Append("\r\n" + "return int.Parse(strReturnStr);");
                    break;
                default:
                    //strBuilder.Append("\r\n" + "return strResult;");
                    strBuilder.Append("\r\n" + "const strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                    strBuilder.Append("\r\n" + "return strReturnStr;");
                    break;
            }
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
            {
                strBuilder.Append("\r\n" + "else return 0;");
            }
            else
            {
                strBuilder.Append("\r\n" + "else return \"\";");
            }
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

        /// <summary>
        /// 获取当前表满足条件的第一条记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetFirstObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的第一条记录的对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{1}EN GetFirstObj(string strWhereCond)",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strAction = \"GetFirstObj\";", objPrjTabENEx.TabName);
            
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "obj{0}EN = clsJSON.GetObjFromJson<cls{0}EN>(strResult);", objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObj\"]);");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = JsonConvert.DeserializeObject<cls{0}EN>(strJson);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\n" + "return bolReturnBool;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return null;");


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


        /// <summary>
        /// 添加记录,并且返回关键字
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_AddNewNodeWithReturnKey()
        {
            if (objKeyField.PrimaryTypeId != "02") return "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的表对象</param>",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>返回新添加记录的关键字</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string AddNewNodeWithReturnKey(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strAction = \"AddNewNode\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "string strKey = strResult;",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return strKey;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strReturnStr = (string)jobjReturn0[\"returnStr\"];");
            strBuilder.Append("\r\n" + "return strReturnStr;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return \"\";");

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

        /// <summary>
        /// 添加记录,并且返回关键字
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_UpdateWithCondition()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的第一条记录的对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的对象</param>",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateWithCondition(cls{0}EN obj{0}EN, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.sfUpdFldSetStr) == true)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).\",");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1}, clsStackTrace.GetCurrClassFunction());", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(strWhereCond) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).\",");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1}, clsStackTrace.GetCurrClassFunction());", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "string strAction = \"UpdateWithCondition\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");


            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "bool bolResult = bool.Parse(strResult);");
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strBuilder.Append("\r\n" + "return bolReturnBool;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return false;");

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
        /// <summary>
        /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetNameByKeyCache()
        {
            string strTextFieldName = "";
            string strValueFieldName = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")
                {
                    strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                }
                if (objField.FieldTypeId == "03")
                {
                    strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                }
            }
            if (strValueFieldName == "" || strTextFieldName == "")
            {
                return "";
            }
            if (objPrjTabENEx.IsUseCache == false) return string.Format("//该表没有使用Cache,不需要生成[Get{0}By{1}Cache]函数;",
        strTextFieldName, objKeyField.FldName);


            StringBuilder strBuilder = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据关键字获取相关名称, 从缓存的对象列表中获取.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的名称</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string Get{4}By{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName,
            strTextFieldName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//初始化列表缓存");
            strBuilder.Append("\r\n" + "InitListCache(); ");


            strBuilder.Append("\r\n" + "int intStart = 0;");
            strBuilder.AppendFormat("\r\n" + "int intEnd = arr{0}ObjLstCache.Count - 1;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "int intMid = 0;");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                 objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "while (intEnd >= intStart)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intMid = (intStart + intEnd) / 2;");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = arr{0}ObjLstCache[intMid];",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intFindFailCount = 0;");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN.{1};",
                  objPrjTabENEx.TabName,
                  strTextFieldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "else if (obj{0}EN.{1}.CompareTo({2}) > 0)",
                  objPrjTabENEx.TabName,
                  objKeyField.FldName,
                  objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intEnd = intMid - 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intStart = intMid + 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            //strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLstCache)",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
            //objPrjTabENEx.TabName,
            //objKeyField.FldName,
            //objKeyField.PrivFuncName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "return obj{0}EN.{1};",
            //objPrjTabENEx.TabName,
            //strTextFieldName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "intFindFailCount++;");
            strBuilder.AppendFormat("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (intFindFailCount == 1) return Get{0}By{1}Cache({2});",
                strTextFieldName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"在{2}对象缓存列表中,找不到记录[{3} = {{0}}][intFindFailCount = {{1}}](函数:{{2}})\", {4}, intFindFailCount, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN != null)",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"最后一次查找的对象相关字段属性值:{{0}}.[intMid = {{1}}]\", obj{2}EN.{3}, intMid);",
               "{", "}",
               objPrjTabENEx.TabName,
               objKeyField.FldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"最后一次查找的对象为null, 请检查![intMid = {{0}}]\", intMid);",
               "{", "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName,
                strTextFieldName);
            //strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            //strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "throw new Exception(strErrMsgForGetObjById);");
            //strBuilder.AppendFormat("\r\n" + "return \"\";");
            strBuilder.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// 初始化列表缓存.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_InitListCache()
        {
            StringBuilder strBuilder = new StringBuilder();
            //初始化列表缓存.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 初始化列表缓存.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n" + "public static void InitListCache()");
            strBuilder.Append("\r\n" + "{");
            //if (objPrjTabENEx.SqlDsTypeId == clsSQLDSTypeBLEx.SQLTAB)
            //{
            //    strBuilder.Append("\r\n" + "//检查缓存刷新机制");
            //    strBuilder.Append("\r\n" + "string strMsg;");
            //    strBuilder.AppendFormat("\r\n" + "if (cls{0}BL.objCommFun4BL == null)", objPrjTabENEx.TabName);
            //    strBuilder.Append("\r\n" + "{");
            //    strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"类cls{2}BL没有刷新缓存机制(cls{2}BL.objCommFun4BL == null), 请联系程序员!({{0}})\", clsStackTrace.GetCurrClassFunction());",
            //        "{", "}", objPrjTabENEx.TabName);
            //    strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            //    strBuilder.Append("\r\n" + "}");
            //}
            //else if (objPrjTabENEx.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW)
            //{
            //    List<string> arrTabId = clsPrjTabBLEx.GetRelaParentNodeByTabId(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
            //    bool bolIsDef_strMsg = false;
            //    foreach (string strRelaTabId in arrTabId)
            //    {
            //        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strRelaTabId, objPrjTabENEx.PrjId);
            //        if (objPrjTab.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW) continue;

            //        if (bolIsDef_strMsg == false)
            //        {
            //            strBuilder.Append("\r\n" + "//检查缓存刷新机制");
            //            strBuilder.Append("\r\n" + "string strMsg;");
            //            bolIsDef_strMsg = true;
            //        }
            //        strBuilder.AppendFormat("\r\n" + "if (cls{0}BL.objCommFun4BL == null)", objPrjTab.TabName);
            //        strBuilder.Append("\r\n" + "{");
            //        strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"类cls{2}BL没有刷新缓存机制(cls{2}BL.objCommFun4BL == null), 请联系程序员!({{0}})\", clsStackTrace.GetCurrClassFunction());",
            //            "{", "}", objPrjTab.TabName);
            //        strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            //        strBuilder.Append("\r\n" + "}");
            //    }
            //}
            strBuilder.Append("\r\n" + "//初始化列表缓存");
            strBuilder.AppendFormat("\r\n" + "string strWhereCond = string.Format(\"1 = 1 order by {0}\");", objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "if (arr{0}ObjLstCache == null)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = await {0}GetObjLst(strWhereCond);",
                  objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "intFldNumCache = arr{0}ObjLstCache.Count;", 
            //      objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            //初始化列表缓存.======================= = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjByKeyCache()
        {
         
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;
            if (objPrjTabENEx.IsUseCache == false) return "//该表不需要使用Cache;";
            StringBuilder strBuilder = new StringBuilder();
            //根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return null;",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//初始化列表缓存");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel1 =", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "from obj{0}EN in arr{0}ObjLstCache", objPrjTabENEx.TabName);
            int intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strBuilder.AppendFormat("\r\n" + "where obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " && obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                intIndex++;
            }
            strBuilder.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst_Sel = new List<cls{0}EN>();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj in arr{0}ObjLst_Sel1)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst_Sel.Add(obj);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "if (arr{0}ObjLst_Sel.Count == 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel[0];", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");


            //根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetRecNameByKeyCache()
        {
            string strTextFieldName = "";
            string strValueFieldName = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")
                {
                    strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                }
                if (objField.FieldTypeId == "03")
                {
                    strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                }
            }
            if (strValueFieldName == "" || strTextFieldName == "")
            {
                return "";
            }
            if (objPrjTabENEx.IsUseCache == false) return string.Format("//该表没有使用Cache,不需要生成[Get{0}By{1}Cache]函数;",
        strTextFieldName, objKeyField.FldName);
            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//该表没有使用Cache,不需要生成[Get{strTextFieldName}By{objKeyField.FldName}Cache]函数;(in {clsStackTrace.GetCurrClassFunction()})";

            StringBuilder strBuilder = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据关键字获取相关名称, 从缓存的对象列表中获取.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的名称</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string Get{4}By{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName,
            strTextFieldName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//初始化列表缓存");
            strBuilder.Append("\r\n" + "InitListCache(); ");


            strBuilder.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel1 =", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "from obj{0}EN in arr{0}ObjLstCache", objPrjTabENEx.TabName);
            int intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strBuilder.AppendFormat("\r\n" + "where obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " && obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                intIndex++;
            }
            strBuilder.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst_Sel = new List<cls{0}EN>();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj in arr{0}ObjLst_Sel1)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst_Sel.Add(obj);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "if (arr{0}ObjLst_Sel.Count > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel[0].{1};",
                objPrjTabENEx.TabName, strTextFieldName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"在{2}对象缓存列表中,找不到记录[{3} = {{0}}](函数:{{1}})\", {4}, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName,
                strTextFieldName);
            //strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            //strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "throw new Exception(strErrMsgForGetObjById);");
            //strBuilder.AppendFormat("\r\n" + "return \"\";");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据关键字获取相关名称, 从缓存的对象列表中获取.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>根据关键字获取的名称</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string GetNameBy{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName,
            strTextFieldName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//初始化列表缓存");
            strBuilder.Append("\r\n" + "InitListCache(); ");


            strBuilder.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel1 =", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "from obj{0}EN in arr{0}ObjLstCache", objPrjTabENEx.TabName);
            intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strBuilder.AppendFormat("\r\n" + "where obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " && obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                intIndex++;
            }
            strBuilder.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst_Sel = new List<cls{0}EN>();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj in arr{0}ObjLst_Sel1)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst_Sel.Add(obj);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "if (arr{0}ObjLst_Sel.Count > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel[0].{1};",
                objPrjTabENEx.TabName, strTextFieldName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"在{2}对象缓存列表中,找不到记录的相关名称[{3} = {{0}}](函数:{{1}})\", {4}, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName,
                strTextFieldName);
            //strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            //strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "throw new Exception(strErrMsgForGetObjById);");
            //strBuilder.AppendFormat("\r\n" + "return \"\";");
            strBuilder.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// 把表中内容绑定到ListView。
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_BindListView()
        {
            string strFuncName = "";
            StringBuilder strBuilder = new StringBuilder();
            try
            {
                //strBuilder.Append("\r\n //1/生成绑定ListView的代码");
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 函数功能:根据界面上查询控件中所设置内容查询表记录,");
                strBuilder.Append("\r\n ///			 并显示在ListView中。");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public static int BindLv_{0}(System.Windows.Forms.ListView lv{0}, string strWhereCond)",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "//操作步骤:(共4步)");
                strBuilder.Append("\r\n" + "//	1、组合界面条件串；");
                strBuilder.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strBuilder.Append("\r\n" + "//	3、设置ListView的列头信息");
                strBuilder.Append("\r\n" + "//	4、设置ListView的Item信息。即把所有记录显示在ListView中");
                strBuilder.Append("\r\n" + "//		在本界面中是把状态显示在控件lblRecCount中。");
                strBuilder.Append("\r\n" + "");
                strBuilder.AppendFormat("\r\n" + "System.Windows.Forms.ListViewItem lvi{0}; ",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst;",
                objPrjTabENEx.TabName);

                strBuilder.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = GetObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "//	3、设置ListView的列头信息");
                strBuilder.AppendFormat("\r\n" + "lv{0}.Items.Clear();//清除原来所有Item",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "lv{0}.Columns.Clear();//清除原来所有列头信息",
                objPrjTabENEx.TabName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId != "04" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "byte[]")	//不是管理字段
                    {
                        strBuilder.AppendFormat("\r\n" + "lv{0}.Columns.Add(\"{1}\", 100, System.Windows.Forms.HorizontalAlignment.Left);",
                        objPrjTabENEx.TabName, objField.ColCaption);
                    }
                }
                strBuilder.AppendFormat("\r\n" + "lv{0}.View = System.Windows.Forms.View.Details;",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "//	4、设置ListView的Item信息。即把所有记录显示在ListView中");
                strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLst)",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "lvi{0} = new System.Windows.Forms.ListViewItem();",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "lvi{0}.Tag = obj{0}EN.{1};",
                objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "lvi{0}.Text = obj{0}EN.{1}.ToString();",
                objPrjTabENEx.TabName, objKeyField.FldName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objKeyField.FldId == objField.FldId)
                    {
                        continue;
                    }
                    if (objField.FieldTypeId != "04"
                    && objField.IsTabForeignKey == false
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "byte[]")
                    {
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                        {
                            strBuilder.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1});",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        }
                        else
                        {
                            strBuilder.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1}.ToString());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        }
                    }
                }
                strBuilder.AppendFormat("\r\n" + "lv{0}.Items.Add(lvi{0});",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "//	4、设置记录数的状态,");
                strBuilder.Append("\r\n" + "//		在本界面中是把状态显示在控件txtRecCount中。");
                strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst.Count;",
                objPrjTabENEx.TabName);
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
      
        public string Gen_4WA_ComboBoxBindFunction()
        {
            string strFuncName = "";
            StringBuilder strBuilder = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";
            bool bolIsNumber4ValueFieldName = false;
            try
            {
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                        bolIsNumber4ValueFieldName = objField.IsNumberType();
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    //strBuilder.AppendFormat("\r\n" + "public static System.Data.DataTable Get{0}()",
                    //strValueFieldName);
                    //strBuilder.Append("\r\n" + "{");
                    //strBuilder.Append("\r\n" + "//获取某学院所有专业信息");
                    //strBuilder.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
                    //strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    ////						if (objField.DsCondStr.Trim() == "" )
                    ////						{
                    ////							strBuilder.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    ////								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    ////						}
                    ////						else
                    ////						{
                    ////							strBuilder.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    ////								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName, objField.DsCondStr);
                    ////						}
                    ////strBuilder.Append("\r\n" + "clsSpecSQLforSql mySql=new 1clsSpecSQLforSql();");
                    //strBuilder.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

                    //strBuilder.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                    //strBuilder.Append("\r\n" + "return objDT;");
                    //strBuilder.Append("\r\n" + "}");
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.Append("\r\n /// 绑定基于Win的下拉框");
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.Append("\r\n /// <param name=\"objComboBox\">需要绑定当前表的下拉框</param>");
                    strBuilder.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
                    strValueFieldName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.Append("\r\n" + "//为数据源为表的下拉框设置内容");
                    strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = GetObjLst(\"1=1\");",
                    objPrjTabENEx.TabName);


                    strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                    objPrjTabENEx.TabName);
                    strBuilder.AppendFormat("\r\n" + "//初始化一个对象列表");
                    //strBuilder.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                    //objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n" + "//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。");
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                    objPrjTabENEx.TabName);
                    if (bolIsNumber4ValueFieldName)
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = 0;",
                        objPrjTabENEx.TabName, strValueFieldName);
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"0\";",
                        objPrjTabENEx.TabName, strValueFieldName);
                    }
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"选[{2}]...\";",
                        objPrjTabENEx.TabName, strTextFieldName, objPrjTabENEx.TabCnName);

                    strBuilder.AppendFormat("\r\n" + "arrObjLst.Insert(0, obj{0}EN);",
                    objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n" + "//把DataTable中的所有项均加到对象列表中");

                    strBuilder.Append("\r\n" + "//设置下拉框的数据源、以及设置值项、显示项");
                    strBuilder.AppendFormat("\r\n" + "objComboBox.DataSource = arrObjLst;",
                    objPrjTabENEx.TabName);
                    strBuilder.AppendFormat("\r\n" + "objComboBox.ValueMember=\"{1}\";",
                            objPrjTabENEx.TabName, strValueFieldName);
                    strBuilder.AppendFormat("\r\n" + "objComboBox.DisplayMember=\"{1}\";",
                           objPrjTabENEx.TabName, strTextFieldName);
                    strBuilder.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
                    strBuilder.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strBuilder.ToString();
        }
        public string Gen_4WA_DdlBindFunction()
        {
            string strFuncName = "";
            StringBuilder strBuilder = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";
            try
            {
                ///生成仅有变量;
                //绑定下拉框的函数 代码;
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                   
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.Append("\r\n /// 绑定基于Web的下拉框");
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.Append("\r\n /// <param name=\"objDDL\">需要绑定当前表的下拉框</param>");
                    strBuilder.AppendFormat("\r\n" + "public static void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                    strValueFieldName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.Append("\r\n" + "//为数据源于表的下拉框设置内容");

                    strBuilder.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"选[{0}]...\",\"0\");",
                          objPrjTabENEx.TabCnName);

                    strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = GetObjLst(\"1=1\");",
                        objPrjTabENEx.TabName);

                    strBuilder.AppendFormat("\r\n" + "objDDL.DataValueField=\"{1}\";",
                        objPrjTabENEx.TabName, strValueFieldName);
                    strBuilder.AppendFormat("\r\n" + "objDDL.DataTextField=\"{1}\";",
                        objPrjTabENEx.TabName, strTextFieldName);
                    strBuilder.Append("\r\n" + "objDDL.DataSource = arrObjLst;");
                    strBuilder.Append("\r\n" + "objDDL.DataBind();");
                    strBuilder.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strBuilder.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                    strBuilder.Append("\r\n" + "}");
                }
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

 
        public string Gen_4WA_GeneEnumConstList()
        {
            string strKeyFieldName = "";
            string strNamedFieldName = "";
            string strEnglishNameFieldName = "";

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")
                {
                    strKeyFieldName = objField.ObjFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == "03")
                {
                    strNamedFieldName = objField.ObjFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == "05")
                {
                    strEnglishNameFieldName = objField.ObjFieldTabENEx.FldName;
                }
            }
            if (string.IsNullOrEmpty(strKeyFieldName) == true) return "";
            if (string.IsNullOrEmpty(strNamedFieldName) == true) return "";
            if (string.IsNullOrEmpty(strEnglishNameFieldName) == true) return "";
            DataTable objDT;
            try
            {
                objDT = clsTablesBLEx.GetDataTableByTabName(objPrjTabENEx.TabName, this.objPrjDataBaseEN.PrjDataBaseId);
            }
            catch (Exception objException)
            {
                clsEntityBase.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("在获取表内容（GetDataTableByTabName）时出错!表名：{0},出错信息：{1}。({2})",
                    objPrjTabENEx.TabName, objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(sbMsg.ToString());
                throw new Exception(sbMsg.ToString());
            }

            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据表内容设置enum列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\npublic class enum{0}WA",
                       objPrjTabENEx.TabName,
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strBuilder.Append("\r\n{");

                foreach (DataRow objRow in objDT.Rows)
                {
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// {0}", objRow[strNamedFieldName]);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n" + "public const string {0}_{1} = \"{1}\";",
                        objRow[strEnglishNameFieldName], objRow[strKeyFieldName]);
                }
            }
            else
            {
                strBuilder.AppendFormat("\r\npublic enum enum{0} : {1}",
                objPrjTabENEx.TabName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strBuilder.Append("\r\n{");

                foreach (DataRow objRow in objDT.Rows)
                {
                    strBuilder.AppendFormat("\r\n" + "[Description(\"{0}\")]", objRow[strNamedFieldName]);
                    strBuilder.AppendFormat("\r\n" + "{0}_{1} = {1},", objRow[strEnglishNameFieldName], objRow[strKeyFieldName]);                    
                }
            }
            strBuilder.Append("\r\n}");

            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public string Gen_4WA_GeneEnumConstList4Field()
        {

            string strStrConstFieldName = "";

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                if (objField.FieldTypeId == "07")
                {
                    strStrConstFieldName = objField.ObjFieldTabENEx.FldName;
                }
            }

            if (string.IsNullOrEmpty(strStrConstFieldName) == true) return "";
            DataTable objDT;
            try
            {
                objDT = clsTablesBLEx.GetDataTableByTabName(objPrjTabENEx.TabName, this.objPrjDataBaseEN.PrjDataBaseId);
            }
            catch (Exception objException)
            {
                clsEntityBase.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("在获取表内容（GetDataTableByTabName）时出错!表名：{0},出错信息：{1}。({2})",
                    objPrjTabENEx.TabName, objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(sbMsg.ToString());
                throw new Exception(sbMsg.ToString());
            }

            StringBuilder strBuilder = new StringBuilder();
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") continue;
                if (objField.FieldTypeId != "07") continue;
                //获取某一条件值的记录集-----------------------------;
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 根据表字段内容设置enum列表-字段名：[{0}]", objField.ObjFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.AppendFormat("\r\npublic class enum{0}_{1}WS",
                       objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                strBuilder.Append("\r\n{");
                List<string> arrExistItem = new List<string>();
                foreach (DataRow objRow in objDT.Rows)
                {
                    string strFieldValue = objRow[objField.ObjFieldTabENEx.FldName].ToString();
                    if (arrExistItem.Contains(strFieldValue)) continue;
                    arrExistItem.Add(strFieldValue);
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// {0}", strFieldValue);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n" + "public const string con{0} = \"{0}\";",
                        strFieldValue);
                }

                strBuilder.Append("\r\n}");
            }
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }


        public override void GetClsName()
        {
            this.ClsName = string.Format("{0}ApiController", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
        public string A_GeneFuncCodeByFuncName(string strFuncName)
        {
            //string strFuncName = objvFunction4GeneCodeEN.FuncName;
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBLEx.GetObjByFuncNameCache(strFuncName);
            try
            {
                string strCode = "";
                Type t = typeof(NodeWA_Access4CSharp);
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
                        strCode = (string)mt.Invoke(this, new object[] { objFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
                        objException.Message,
                        clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }

        public void Gen_4WA_Static_SetFieldValue4OneField(clsPrjTabFldENEx objField, StringBuilder strBuilder)
        {
            if (objField.FldOpTypeId == "0004") return;//不读不写
            if (objField.FldOpTypeId == "0002") return;//只读不写
            string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
            string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:为对象设置字段值");
            strBuilder.Append("\r\n /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要设置字段值的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strComparisonOp\">比较运算符,如果有值,可用于组织条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回对象,可以继续连写</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN Set{1}(this cls{0}EN obj{0}EN, {2} {3}, string strComparisonOp=\"\")",
            objPrjTabENEx.TabName, objField.FldName, objField.CsType, objField.PrivFuncName);
            strBuilder.Append("\r\n	{");
            //objUserStateEN.Memo = strMemo;


            //检查非空
            if (objField.IsTabNullable == false && objField.FieldTypeId != "02")
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                {

                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, con{2}.{3});",
                   objField.PrivFuncName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                }

            }
            //检查字段长度

            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                && objField.ObjFieldTabENEx.FldLength > 0)
            {

                strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
         objField.PrivFuncName,
         objField.ObjFieldTabENEx.FldLength,
         objPrjTabENEx.TabName,
         objField.ObjFieldTabENEx.FldName);

            }
            //检查外键
            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
               && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
            {

                strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
           objField.PrivFuncName,
           objField.ObjFieldTabENEx.FldLength,
           objPrjTabENEx.TabName,
           objField.ObjFieldTabENEx.FldName);

            }

            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2}; //{3}",
             objPrjTabENEx.TabName, objField.FldName, objField.PrivFuncName, objField.ColCaption);
            strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(strComparisonOp) == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.dicFldComparisonOp.ContainsKey(con{0}.{1}) == false)",
                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.dicFldComparisonOp.Add(con{0}.{1}, strComparisonOp);",
                objPrjTabENEx.TabName,
                objField.ObjFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.dicFldComparisonOp[con{0}.{1}] = strComparisonOp;", objPrjTabENEx.TabName,
                objField.ObjFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");


        }

        public string Gen_4WA_Static_SetFieldValue()
        {
            StringBuilder strBuilder = new StringBuilder();

            objPrjTabENEx.arrFldSet.ForEach(obj => Gen_4WA_Static_SetFieldValue4OneField(obj, strBuilder));

            return strBuilder.ToString();
        }
        public string Gen_4WA_ReFreshThisCache()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 刷新本类中的缓存.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n" + "public static void ReFreshThisCache()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg;");
            strBuilder.Append("\r\n" + "if (clsSysParaEN.spSetRefreshCacheOn == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
          objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"刷1新缓存成功!({{2}}->{{1}}->{{0}})\",");
            //strBuilder.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            //strBuilder.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            //strBuilder.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3)); ");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strMsg = string.Format(\"刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})\",");
            strBuilder.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            strBuilder.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3));");
            strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objViewInfoENEx"></param>
        /// <returns></returns>
        public string Gen_4WA_Static_CombineConditionByCondObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 根据条件对象中的字段内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>条件串(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static string GetCombineCondition(this cls{0}EN obj{0}Cond)", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");


                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {

                    switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeId) //objEditRegionFldsEx.objCtlType.CtlTypeName
                    {
                        case enumDataTypeAbbr.bit_03:
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                                 objPrjTabENEx.TabName,
                                        objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.{1} == true)",
                                        objPrjTabENEx.TabName,
                                        objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                            strCodeForCs.Append("\r\n" + "{");


                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0});",
                                     objField.ObjFieldTabENEx.FldName,
                                     objPrjTabENEx.TabName,
                                     "{", "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                 objField.ObjFieldTabENEx.FldName,
                                     objPrjTabENEx.TabName,
                                    "{", "}");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "}");

                            break;

                        case enumDataTypeAbbr.char_04:
                        case enumDataTypeAbbr.varchar_25:
                        case enumDataTypeAbbr.nvarchar_15:
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                      objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} {{2}} '{{1}}'\", con{1}.{0}, obj{1}Cond.{2}, strComparisonOp{0});",
                                objField.ObjFieldTabENEx.FldName,
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case enumDataTypeAbbr.datetime_05:
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                      objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} {{2}} '{{1}}'\", con{1}.{0}, obj{1}Cond.{2}, strComparisonOp{0});",
                                objField.ObjFieldTabENEx.FldName,
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case enumDataTypeAbbr.decimal_06:
                        case enumDataTypeAbbr.float_07:
                        case enumDataTypeAbbr.int_09:
                        case enumDataTypeAbbr.bigint_01:
                        case enumDataTypeAbbr.bigintidentity_26:


                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                      objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} {{2}} {{1}}\", con{1}.{0}, obj{1}Cond.{2}, strComparisonOp{0});",
                                objField.ObjFieldTabENEx.FldName,
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "//数据类型{0}({1})在函数:[{2}]中没有处理!",
                                  objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                  clsStackTrace.GetCurrClassFunction());
                            break;
                    }
                }

                strCodeForCs.Append("\r\n" + " return strWhereCond;");

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Static_UpdateNode()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateNode_Static", "修改记录时关键字不能为空!", "生成代码");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateNode(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool")
            {
                if (IsNumberType4Key == true)
                {
                    strBuilder.AppendFormat("\r\n" + " if (obj{0}EN.{1} == 0)",
                     objPrjTabENEx.TabName, objKeyField.FldName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                        objPrjTabENEx.TabName, objKeyField.FldName);
                }
                strBuilder.Append("\r\n" + " {");

                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})修改记录时关键字不能为空!(from {{0}})\\r\\n\",", strErrId);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "obj{0}EN.sfUpdFldSetStr = obj{0}EN.getsfUpdFldSetStr();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew(); ", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}_UpdateNode(obj{0}EN);",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "  //引发修改记录的事件");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "    onUpdateNode?.Invoke(obj{0}EN);", TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch (Exception objException)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg2 = string.Format(\"在调用修改记录代理事件时出错。错误：{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strBuilder.Append("\r\n" + "throw new Exception(strMsg2);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "{0}_ReFreshCache();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateNode_Static", "修改结点出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})修改结点出错,{{1}}!(from {{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_4WA_Static_AddNewNode()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewNode(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03
                && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool"
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "int"
                 && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "long")
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字不能为空!(from {0})\\r\\n\", ");
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");

                strBuilder.Append("\r\n" + " }");

                strBuilder.AppendFormat("\r\n" + " if ({0}_IsExist({1}) == true)",
                   objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字:[{{0}}]已经存在!(from {{1}})\\r\\n\", obj{0}EN.{1}, ",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + " }");
            }

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || {0}_IsExist({2}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "     obj{0}EN.{1} = {0}GetMaxStrId();",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew(); ", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}_AddNewNode(obj{0}EN);",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "  //引发添加新记录的事件");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "    onAddNewNode?.Invoke(obj{0}EN);", TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch (Exception objException)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg2 = string.Format(\"在调用添加记录代理事件时出错。错误：{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strBuilder.Append("\r\n" + "throw new Exception(strMsg2);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "{0}_ReFreshCache();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewNode_Static", "纯静态添加记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})添加记录出错, {{1}}.(from {{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})添加记录出错!({1}:AddNewNodeBySql2)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"添加记录出错!({1}: AddNewNodeBySQL2)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4WA_Static_AddNewNodeWithMaxId()
        {
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewNodeWithMaxId(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

          
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew(); ", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.AddNewNodeWithMaxId();",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "  //引发添加新记录的事件");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "    onAddNewNode?.Invoke(obj{0}EN);", TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch (Exception objException)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg2 = string.Format(\"在调用添加记录代理事件时出错。错误：{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strBuilder.Append("\r\n" + "throw new Exception(strMsg2);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "{0}_ReFreshCache();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewNodeWithMaxId_Static", "纯静态添加记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})添加记录出错, {{1}}.(from {{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})添加记录出错!({1}:AddNewNodeBySql2)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"添加记录出错!({1}: AddNewNodeBySQL2)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4WA_Static_UpdateWithCondition()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录");
            strBuilder.Append("\r\n /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">修改记录时的条件</param>");
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateWithCondition(this cls{0}EN obj{0}EN, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew(); ", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.UpdateWithCondition(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "{0}_ReFreshCache();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateWithCondition_Static", "根据条件修改记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})根据条件修改记录出错, {{1}}.(from {{0}})\\r\\n\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjLstCache()
        {
            if (objPrjTabENEx.IsUseCache == false) return "//该表不需要使用Cache;";
            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in {clsStackTrace.GetCurrClassFunction()})";

            StringBuilder strBuilder = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 从缓存中获取所有对象列表.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <returns>从缓存中获取的所有对象列表</returns>");
            strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> GetObjLstCache()",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//初始化列表缓存");
            //strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLstCache;",
              objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strBuilder.ToString();
        }

        public string Gen_4WA_ReFreshCache()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "public static void ReFreshCache()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "  if (clsSysParaEN.spIsUseQueue4Task == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsSysParaEN.arrFunctionLst4Queue == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "clsDynamicFunction objDynamicFunction = new clsDynamicFunction()");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "NameSpace = \"{0}.BusinessLogic\",", objProjectsENEx.PrjDomain);
            //strCodeForCs.AppendFormat("\r\n" + "ClassName = \"cls{0}BL\",", objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "AssemblyType = typeof({0}.BusinessLogic.cls{1}BL),", objProjectsENEx.PrjDomain, objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "FunctionName = clsStackTrace.GetCurrFunction()");
            //strCodeForCs.Append("\r\n" + "};");

            //strCodeForCs.Append("\r\n" + "if (clsDynamicFunction.IsExistSameFunction(clsSysParaEN.arrFunctionLst4Queue, objDynamicFunction) == true)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "return;");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.arrFunctionLst4Queue.Enqueue(objDynamicFunction);");
            //strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if ({0}_objCommFun4BL != null) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + " string strMsg = string.Format(\"刷1新缓存成功!({{2}}->{{1}}->{{0}})\",", "{", "}");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3)); ");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");

            strCodeForCs.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "{0}_objCommFun4BL.ReFreshCache();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Static_GetConditionString4Constraint()
        {
            int intVerCount = 1;
            StringBuilder strBuilder = new StringBuilder();
            //检查类中某属性(非主键)是否唯一-------------------------------------------;
            foreach (clsPrjConstraintEN objInFor in objPrjTabENEx.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = string.Format($"_V{intVerCount}"); intVerCount++;
                
                IEnumerable<clsConstraintFieldsEN> arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId); 
                switch (objInFor.ConstraintTypeId)
                {
                    case enumConstraintType.Uniqueness_01:

                        strBuilder.Append("\r\n /// <summary>");
                        strBuilder.AppendFormat("\r\n /// 获取唯一性条件串--{0}({1}), 即由对象中唯一性条件字段关键字与值组成的条件串",
                                                  objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        strBuilder.Append($"\r\n /// 唯一性条件:{objInFor.ConstraintName4GC()}");
                        strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strBuilder.Append("\r\n /// </summary>");
                        strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">要求唯一的对象</param>",
                               objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        strBuilder.Append("\r\n /// <returns></returns>");
                        strBuilder.Append($"\r\npublic static string GetUniConditionStr{strVersion}(this cls{ThisTabName4GC}EN obj{ThisTabName4GC}EN)");
                        strBuilder.Append("\r\n{");
                        strBuilder.Append("\r\n" + "//检测记录是否存在");

                        //strBuilder.Append("\r\n" + "bool bolIsUniqueness;");
                        strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");

                        strBuilder.AppendFormat("\r\n" + "if (obj{0}EN == null) return \"\";",
                        objPrjTabENEx.TabName);

                        switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "int":
                            case "long":
                            case "short":
                                strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0)",
                                objPrjTabENEx.TabName,
                                objKeyField.PropertyName(this.IsFstLcase));
                                break;
                            case "string":
                                strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == null || obj{0}EN.{1} == \"\")",
                                objPrjTabENEx.TabName,
                                objKeyField.PropertyName(this.IsFstLcase));
                                break;
                            default:
                                strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == null || obj{0}EN.{1} == \"\")",
                                objPrjTabENEx.TabName,
                                objKeyField.PropertyName(this.IsFstLcase));
                                break;
                        }
                        strBuilder.Append("\r\n" + "{");

                  

                        strBuilder.AppendFormat("\r\nsbCondition.AppendFormat(\"1 = 1\");",
                           objKeyField.FldName,
                           objKeyField.PrivFuncName,
                           "{", "}");

                        foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                        {

                            strBuilder.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", obj{1}EN.{0});",
                                        objField.ObjFieldTab().FldName,
                                        objPrjTabENEx.TabName);
                        }
                        strBuilder.AppendFormat("\r\nreturn sbCondition.ToString();",
                                objPrjTabENEx.TabName);


                        strBuilder.Append("\r\n}");

                        //bool bolIsFirst = true;


                        strBuilder.Append("\r\n else {");

                        if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
                        {
                            strBuilder.AppendFormat("\r\nsbCondition.AppendFormat(\"{0} !=  {{0}}\", obj{1}EN.{0});",
                               objKeyField.FldName,
                               objPrjTabENEx.TabName);
                        }
                        else
                        {
                            strBuilder.AppendFormat("\r\nsbCondition.AppendFormat(\"{0} !=  '{{0}}'\", obj{1}EN.{0});",
                               objKeyField.FldName,
                               objPrjTabENEx.TabName);
                        }
                        foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                        {

                            strBuilder.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", obj{1}EN.{0});",
                                        objField.ObjFieldTab().FldName,
                                        objPrjTabENEx.TabName);
                        }
                        strBuilder.AppendFormat("\r\n return sbCondition.ToString();",
                                objPrjTabENEx.TabName);
                        strBuilder.Append("\r\n}");

                        strBuilder.Append("\r\n" + "}");
                        break;

                    case enumConstraintType.MaxMinValue_02:

                        //strBuilder.Append("\r\n /// <summary>");
                        //strBuilder.AppendFormat("\r\n /// 检查最大最小值(MaxMinValue)--{0}({1}), 如果超过最大值,就返回False; 如果低于最小值,就返回False; ",
                        //  objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        //strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        //strBuilder.Append("\r\n /// </summary>");
                        //strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">要求限制最大值的对象</param>",
                        //       objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        //strBuilder.Append("\r\n /// <returns></returns>");
                        //strBuilder.AppendFormat("\r\npublic static bool CheckMaxMinValue_{1}(this cls{0}EN obj{0}EN)",
                        //             objPrjTabENEx.TabName, objInFor.ConstraintName4GC());
                        //strBuilder.Append("\r\n{");

                        //strBuilder.Append("\r\n" + "bool bolResult;");

                        //strBuilder.AppendFormat("\r\n" + "if (obj{0}EN == null) return true;",
                        //objPrjTabENEx.TabName);

                        //foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                        //{
                        //    if (string.IsNullOrEmpty(objField.MaxValue) == false)
                        //    {
                        //        strBuilder.AppendFormat("\r\n " + "if (obj{1}EN.{0}> {2}) bolResult = false;",
                        //                    objField.ObjFieldTabENEx.FldName,
                        //                    objPrjTabENEx.TabName, objField.MaxValue);
                        //    }
                        //    if (string.IsNullOrEmpty(objField.MinValue) == false)
                        //    {
                        //        strBuilder.AppendFormat("\r\n " + "if (obj{1}EN.{0}< {2}) bolResult = false;",
                        //               objField.ObjFieldTabENEx.FldName,
                        //               objPrjTabENEx.TabName, objField.MinValue);
                        //    }

                        //}

                        //strBuilder.Append("\r\n" + "return true;");

                        //strBuilder.Append("\r\n" + "}");
                        break;


                }
            }

            ///检查类中某属性(非主键)是否唯一 == == == == == == == == = ;
            return strBuilder.ToString();
        }

        public string Gen_4WA_Static_CheckProperty4Condition()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckProperty4Condition(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            //检测记录是否存在

            ///检查属性长度代码;
            string strFunctionName = string.Format("CheckProperty4Condition", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "字段[{2}({3})|{0}({4})]的长度不能超过{1}!值:{{0}}";
            string strErrId1 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strExplanation = "字段[{2}({3})|{0}({4})]的不能包含【 = 】!值:{{0}}";
            string strErrId2 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strExplanation = "字段[{2}({3})|{0}({4})]的不能包含【 and】!值:{{0}}";
            string strErrId3 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strExplanation = "字段[{2}({3})|{0}({4})]的不能包含【and 】!值:{{0}}";
            string strErrId4 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");
            strBuilder.AppendFormat("\r\n" + "//检查字段长度");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {

                    strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                        strPrivPropNameWithObjectName,
                        objField.ObjFieldTabENEx.FldLength,
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                }
            }
            strBuilder.AppendFormat("\r\n" + "//检查Sql注入");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {

                    //  strBuilder.AppendFormat("\r\n" + "//检查Sql注入");
                    strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckSqlInjection4Field({0}, con{1}.{2});",
                      strPrivPropNameWithObjectName,
                      objPrjTabENEx.TabName,
                      objField.ObjFieldTabENEx.FldName);


                }
            }
            strBuilder.AppendFormat("\r\n" + "//检查外键字段长度");

            ///检查外键字段长度;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabForeignKey == false) continue;//如果不是外键,就不需要检查
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                     strPrivPropNameWithObjectName,
                     objField.ObjFieldTabENEx.FldLength,
                     objPrjTabENEx.TabName,
                     objField.ObjFieldTabENEx.FldName);

                }
            }
            strBuilder.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");

            ///检查类中属性是否正确 == == ;
            return strBuilder.ToString();
        }
        public string Gen_4WA_Static_CheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckPropertyNew(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            //检测记录是否存在
            string strFunctionName = string.Format("CheckPropertyNew[{2}]",
             objPrjTabENEx.TabName, objKeyField.FldName, this.strDataBaseType);
            string strExplanation = "字段[{1}|{0}]不能为空(NULL)!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");
            strBuilder.AppendFormat("\r\n" + "//检查字段不能为空(NULL)");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.IsTabNullable == false && objField.FieldTypeId != "02")
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                        continue;
                    }

                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);
                        //strBuilder.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        //    strPrivPropNameWithObjectName4Get);
                        //strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"\")",
                        //    strPrivPropNameWithObjectName4Get );
                        //if (string.IsNullOrEmpty(objField.ObjFieldTabENEx.CodeTabId) != true)
                        //{
                        //    strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"0\")",
                        //         strPrivPropNameWithObjectName4Get );
                        //}
                        //strBuilder.Append(")");
                        //strBuilder.Append("\r\n{");
                        //strBuilder.AppendFormat("\r\n throw new clsDbObjException(\"(errid:{2})字段[{1}|{0}]不能为空(NULL)!(cls{3}DA:CheckPropertyNew)\");",
                        //        objField.ColCaption,
                        //        objPrjTabENEx.TabCnName,
                        //        strErrId,
                        //        objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n}");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, con{2}.{3});",
                  strPrivPropNameWithObjectName,
                  objField.ObjFieldTabENEx.FldLength,
                  objPrjTabENEx.TabName,
                  objField.ObjFieldTabENEx.FldName);
                        //strBuilder.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        //    strPrivPropNameWithObjectName );
                        //strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"\")",
                        //     strPrivPropNameWithObjectName );
                        //if (string.IsNullOrEmpty(objField.ObjFieldTabENEx.CodeTabId) != true)
                        //{
                        //    strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"0\")",
                        //         strPrivPropNameWithObjectName );
                        //}
                        //strBuilder.Append(")");
                        //strBuilder.Append("\r\n{");
                        //strBuilder.AppendFormat("\r\n throw new clsDbObjException(\"(errid:{2})字段[{1}|{0}]不能为空(NULL)!(cls{3}DA:CheckPropertyNew)\");",
                        //            objField.ColCaption,
                        //            objPrjTabENEx.TabCnName,
                        //            strErrId,
                        //            objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n}");
                    }
                }


            }
            //检查属性长度代码;

            strFunctionName = string.Format("CheckPropertyNew1", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "字段[{2}({3})|{0}({4})]的长度不能超过{1}!值:{{0}}";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");
            strBuilder.AppendFormat("\r\n" + "//检查字段长度");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                 strPrivPropNameWithObjectName,
                 objField.ObjFieldTabENEx.FldLength,
                 objPrjTabENEx.TabName,
                 objField.ObjFieldTabENEx.FldName);
                        //strBuilder.AppendFormat("\r\nif (!Object.Equals(null, {0}) && GetStrLen({0}) > {1})", strPrivPropNameWithObjectName4Get, objField.ObjFieldTabENEx.FldLength);
                        //strBuilder.Append("\r\n{");
                        //strBuilder.AppendFormat("\r\n throw new clsDbObjException(string.Format(\"(errid:{7})字段[{2}({3})|{0}({4})]的长度不能超过{1}!值:{{0}}(cls{3}DA:CheckPropertyNew)\", obj{3}EN.{4}));",
                        //objField.ColCaption,
                        //objField.ObjFieldTabENEx.FldLength.ToString().Trim(),
                        //objPrjTabENEx.TabCnName,
                        //objPrjTabENEx.TabName,
                        //objField.ObjFieldTabENEx.FldName,
                        //"{", "}",
                        //strErrId);
                        // strBuilder.Append("\r\n}");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                             strPrivPropNameWithObjectName,
                            objField.ObjFieldTabENEx.FldLength,
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName);

                    }
                }
            }

            //检查外键字段长度;

            strFunctionName = string.Format("CheckPropertyNew2", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "字段[{2}|{0}]作为外键字段,长度应该为{1}!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");
            strBuilder.AppendFormat("\r\n" + "//检查字段外键固定长度");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.IsTabForeignKey == false) continue;//如果不是外键,就不需要检查
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                }
            }
      
            strBuilder.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");

            ///检查类中属性是否正确-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckProperty4Update(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            //检查属性长度代码;
            strFunctionName = string.Format("CheckProperty4Update", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "字段[{2}({3})|{0}({4})]的长度不能超过{1}!值:{{0}}";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");
            strBuilder.AppendFormat("\r\n" + "//检查字段长度");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FieldTypeId == enumFieldType.KeyField_02) continue;
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                         strPrivPropNameWithObjectName,
                        objField.ObjFieldTabENEx.FldLength,
                      objPrjTabENEx.TabName,
                      objField.ObjFieldTabENEx.FldName);


                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                         strPrivPropNameWithObjectName,
                        objField.ObjFieldTabENEx.FldLength,
                      objPrjTabENEx.TabName,
                      objField.ObjFieldTabENEx.FldName);

                    }
                }
            }
            ///检查外键字段长度;
            strFunctionName = string.Format("CheckProperty4Update", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "字段[{2}|{0}]作为外键字段,长度应该为{1}!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");
            strBuilder.AppendFormat("\r\n" + "//检查外键字段长度");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.IsTabForeignKey == false) continue;//如果不是外键,就不需要检查
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                }
            }
         
            strBuilder.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");
            ///检查类中属性是否正确 == == ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_DefineObjCommFun4BL()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;
            strCodeForCs.Append("\r\n" + " /// <summary>");
            strCodeForCs.Append("\r\n" + "/// 专门在逻辑层用于处理缓存等公共函数的对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.Append("\r\n" + "public static clsCommFun4BL objCommFun4BL = null;");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "public static clsCommFun4BLV2 objCommFun4BL = null;");
            }
            //strCodeForCs.Append("\r\n" + "public static event OnAddNewNode onAddNewNode;");
            //strCodeForCs.Append("\r\n" + "public static event OnUpdateNode onUpdateNode;");
            //strCodeForCs.Append("\r\n" + "public static event OnDeleteNode onDelNode;");

            return strCodeForCs.ToString();
        }
        public string Gen_4WA_GetDataTableByObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据对象列表获取DataTable");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"arrObjLst\">给定的对象列表</param>");
            strBuilder.Append("\r\n /// <returns>返回DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByObjLst(List<cls{0}EN> arrObjLst)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT = new DataTable();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "objDT.Columns.Add(con{0}.{1}, Type.GetType(\"{2}\"));",
                    objPrjTabENEx.TabName, objField.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.NetSysType);
            }
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in arrObjLst)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataRow objDR = objDT.NewRow();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "objDR[con{0}.{1}] = objInFor[con{0}.{1}];",
                    objPrjTabENEx.TabName, objField.FldName);
            }
            strBuilder.Append("\r\n" + "objDT.Rows.Add(objDR);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");

            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_SetUpdFlag_S()
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">源简化对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static void SetUpdFlag(cls{0}EN obj{0}EN)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n   string strsfUpdFldSetStr = obj{0}EN.sfUpdFldSetStr;",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');");
            strBuilder.Append("\r\n   List<string> arrFldSet = new List<string>(sstrFldSet);");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(obj{0}EN.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //只写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = obj{0}EN.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "if (arrFldSet.Contains(con{0}.{1}, new clsStrCompareIgnoreCase())  ==  true)",
                         objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = obj{0}EN.{1}; //{3}",
                               objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                    strBuilder.Append("\r\n" + "}");

                }
            }

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                  objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "SetUpdFlag", "设置表的修改标志出错!表:{0}.", "生成代码");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})设置表的修改标志出错,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy表:{0} 对象数据(针对修改)出错!({1}:CopyObjFromSimObj4Upd)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy表:{0} 对象数据出错!({1}: CopyObjFromSimObj4Upd)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

    }
}
