using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;

using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using AGC.PureClassEx;

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
    partial class WA_Access4CSharp : clsGeneCodeBase4Tab
    {
        private string strKeyFldName_ObjName = "";
        private string strKeyFldName_PrivateVar = "";
        #region 构造函数

        public WA_Access4CSharp(string strTabId, string strPrjDataBaseId, string strPrjId)
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
            var arrKeyPrivateVar = arrPrjTabFldEx.Select(x => x.PrivFuncName).ToList();
            strKeyFldName_PrivateVar = string.Join(",", arrKeyPrivateVar);

            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);


            objPrjTabENEx.ClsName = string.Format("cls{0}WApi", objPrjTabENEx.TabName); ;
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebApiTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                //类名开始

                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Web;"); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;"); //
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;"); //
                strCodeForCs.Append("\r\n" + "using System.Linq;"); //
                strCodeForCs.Append("\r\n" + "using System.Reflection;"); //

                strCodeForCs.AppendFormat("\r\n" + "using Newtonsoft.Json;"); //
                strCodeForCs.AppendFormat("\r\n" + "using Newtonsoft.Json.Linq; "); //
                //strCodeForCs.AppendFormat("\r\n" + "using Comm.WebApi;"); //

                // strCodeForCs.AppendFormat("\r\n" + "using {1}4WS.ServiceReference{0};", objPrjTabENEx.TabName, objProject.PrjDomain); //

                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;"); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.comm_db_obj;"); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.dynamiccompiler;"); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.json;"); //
                //strCodeForCs.Append("\r\n" + "using System.ServiceModel;"); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProjectsENEx.PrjDomain);


                //strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProjectsENEx.PrjDomain);


                strCodeForCs.Append("\r\n" + ""); //
                                                  //if (objPrjTabENEx.IsForSilverLight == true)
                                                  //{
                                                  //    strCodeForCs.AppendFormat("\r\n" + "namespace SL4WS",
                                                  //    objProject.PrjDomain);
                                                  //}
                                                  //else
                                                  //{
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}4WApi",
                objProject.PrjDomain);
                //}
                strCodeForCs.Append("\r\n" + "{");

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Static = arrvFunction4GeneCodeObjLst.Where(x => x.FuncTypeId == enumFunctionType.PureStaticFunction_12);
                if (arrvFunction4GeneCodeObjLst_Static.Count() > 0)
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// 静态类");
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public static class  {0}_Static", objPrjTabENEx.ClsName);
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_Static)
                    {
                        //clsFunction4GeneCodeEN objFunction4GeneCodeEN1 = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                        strFuncName = objvFunction4GeneCodeEN.FuncName;

                        if (strFuncName.Substring(0, 6) == "Print:")
                        {
                            strCodeForCs.Append("\r\n" + "");
                            strCodeForCs.Append("\r\n" + "");
                            strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
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
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    strCodeForCs.Append("\r\n" + "}");

                }





                //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN21 = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4WA_GeneEnumConstList");
                strTemp = A_GeneFuncCodeByFuncName("Gen_4WA_GeneEnumConstList");
                strCodeForCs.Append(strTemp);
                //objvFunction4GeneCodeEN1 = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4WA_GeneEnumConstList4Field");
                strTemp = A_GeneFuncCodeByFuncName("Gen_4WA_GeneEnumConstList4Field");
                strCodeForCs.Append(strTemp);

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n /// For SilverLight");
                //}
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");


                strCodeForCs.AppendFormat("\r\n" + "private static readonly string mstrApiControllerName = \"{0}Api\";",
                    objPrjTabENEx.TabName);
                //strCodeForCs.Append("\r\n" + "private static string mstrDir = \"0\";");

                //私有属性名-----和属性过程
                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                //       objPrjTabENEx.TabName);

                //strCodeForCs.AppendFormat("\r\n /// <summary>");
                //strCodeForCs.AppendFormat("\r\n /// 从缓存中查找失败的次数");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.AppendFormat("\r\n /// </summary>");
                //strCodeForCs.AppendFormat("\r\n" + "protected static int intFindFailCount = 0;");

                //私有属性名-----和属性过程
                //strCodeForCs.AppendFormat("\r\n" + "private static {0}ServiceSoapClient obj{0}ServiceSoapClient = null;",
                //objPrjTabENEx.TabName);
                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// ");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.Append("\r\n /// <returns></returns>");
                //strCodeForCs.AppendFormat("\r\n" + "public static {0}ServiceSoapClient Get{0}ServiceSoapClient()",
                //objPrjTabENEx.TabName);
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "if (obj{0}ServiceSoapClient == null)",
                //objPrjTabENEx.TabName);
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "BasicHttpBinding binding = new BasicHttpBinding();");
                //strCodeForCs.AppendFormat("\r\n" + "binding.Name = \"{0}ServiceSoap\";",
                //objPrjTabENEx.TabName);
                //strCodeForCs.Append("\r\n" + "binding.CloseTimeout = new System.TimeSpan(6000);");
                //strCodeForCs.Append("\r\n" + "binding.MaxReceivedMessageSize = 2147483647;");
                ////                strCodeForCs.Append("\r\n" + "String strServiceUrl = String.Empty;");
                //strCodeForCs.Append("\r\n" + "string strServiceUrl = GetServiceUrl(mstrApiControllerName, ref mstrDir);");
                ////strCodeForCs.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false)");
                ////strCodeForCs.Append("\r\n" + "{");
                ////strCodeForCs.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{{1}}/{2}Service.asmx\", clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx);",
                ////"{", "}", objPrjTabENEx.TabName);
                ////strCodeForCs.Append("\r\n" + "}");
                ////strCodeForCs.Append("\r\n" + "else");
                ////strCodeForCs.Append("\r\n" + "{");
                ////strCodeForCs.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{2}Service.asmx\", clsSysPara4WebApi.strCurrIPAddressAndPort_Local);",
                ////"{", "}", objPrjTabENEx.TabName);
                ////strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "EndpointAddress address = new EndpointAddress(strServiceUrl);");

                //strCodeForCs.AppendFormat("\r\n" + "return new {0}ServiceSoapClient(binding, address);",
                //objPrjTabENEx.TabName);
                //strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n" + "else");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "return obj{0}ServiceSoapClient;",
                //objPrjTabENEx.TabName);
                //strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n" + "}");
                //生成所有的函数

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_NotStatic = arrvFunction4GeneCodeObjLst.Where(x => x.FuncTypeId != enumFunctionType.PureStaticFunction_12);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_NotStatic)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN1 = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

                strCodeForCs.Append("\r\n" + "}");


                string strCommFun4WACode = new CommFun4WA4CSharp().GeneCode_This(objPrjTabENEx, this.CmPrjId);
                if (strCommFun4WACode.IndexOf("没有可以生成的函数4GC") == -1)
                {
                    strCodeForCs.AppendLine(strCommFun4WACode);
                }

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
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
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

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                //类名开始

                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;"); //
                strCodeForCs.Append("\r\n" + "using System.ServiceModel;"); //
                strCodeForCs.AppendFormat("\r\n" + "using {1}4WS.ServiceReference{0};", objWebSrvClassENEx.ClsName, objProject.PrjDomain); //
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;"); //

                strCodeForCs.Append("\r\n" + ""); //
                                                  //if (objWebSrvClassENEx.IsForSilverLight == true)
                                                  //{
                                                  //    strCodeForCs.AppendFormat("\r\n" + "namespace SL4WS",
                                                  //    objProject.PrjDomain);
                                                  //}
                                                  //else
                                                  //{
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}4WS",
                objProject.PrjDomain);
                //}
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}",
                    objWebSrvClassENEx.ClsName);
                //if (objWebSrvClassENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n /// For SilverLight");
                //}
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");


                strCodeForCs.AppendFormat("\r\n" + "private static string mstrApiControllerName = \"{0}\";",
                    objWebSrvClassENEx.PageName);
                strCodeForCs.Append("\r\n" + "private static string mstrDir = \"0\";");

                //私有属性名-----和属性过程
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                //       objWebSrvClassENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// 从缓存中查找失败的次数");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected static int intFindFailCount = 0;");

                //私有属性名-----和属性过程
                strCodeForCs.AppendFormat("\r\n" + "private static {0}SoapClient obj{0}SoapClient = null;",
                objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static {0}SoapClient Get{0}SoapClient()",
                objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}SoapClient == null)",
                objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "BasicHttpBinding binding = new BasicHttpBinding();");
                strCodeForCs.AppendFormat("\r\n" + "binding.Name = \"{0}ServiceSoap\";",
                objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "binding.CloseTimeout = new System.TimeSpan(6000);");
                strCodeForCs.Append("\r\n" + "binding.MaxReceivedMessageSize = 2147483647;");
                //                strCodeForCs.Append("\r\n" + "String strServiceUrl = String.Empty;");
                strCodeForCs.Append("\r\n" + "string strServiceUrl = GetServiceUrl(mstrApiControllerName, ref mstrDir);");
                //strCodeForCs.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false)");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{{1}}/{2}Service.asmx\", clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx);",
                //"{", "}", objWebSrvClassENEx.TabName);
                //strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n" + "else");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{2}Service.asmx\", clsSysPara4WebApi.strCurrIPAddressAndPort_Local);",
                //"{", "}", objWebSrvClassENEx.TabName);
                //strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "EndpointAddress address = new EndpointAddress(strServiceUrl);");

                strCodeForCs.AppendFormat("\r\n" + "return new {0}SoapClient(binding, address);",
                objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "return obj{0}SoapClient;",
                objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
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
                            strCodeForCs.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//该函数：[{0}]无法生成.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//该函数：[{0}]无法生成.错误:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
                strFuncName = "Gen_4WA_GetServiceUrl";
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx(strFuncName);

                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }

                strCodeForCs.Append("\r\n" + "}");
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


        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_Access4CSharp);
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
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;
            strCodeForCs.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strCodeForCs.Append("\r\n {");

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_CheckPropertyNew()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\npublic static void CheckPropertyNew(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.IsTabNullable = false && objField.FieldTypeId != "02")
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                        continue;
                    }
                    strCodeForCs.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        strPrivPropNameWithObjectName);
                    strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString() == \"\")",
                         strPrivPropNameWithObjectName);

                    if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                    {
                        strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString() == \"0\")",
                             strPrivPropNameWithObjectName);
                    }
                    strCodeForCs.Append(")");
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\n throw new Exception(\"字段[{0}]不能为空(NULL)!\");",
                    objField.ColCaption);
                    strCodeForCs.Append("\r\n}");
                }


            }
            ///检查属性长度代码;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strCodeForCs.AppendFormat("\r\nif (!Object.Equals(null, {0}) && GetStrLen({0}) > {1})",
                         strPrivPropNameWithObjectName,
                          objField.ObjFieldTabENEx.FldLength);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\n throw new Exception(\"字段[{0}]的长度不能超过{1}!\");",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldLength.ToString().Trim());
                    strCodeForCs.Append("\r\n}");
                }
            }
            strCodeForCs.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n }");
            ///检查类中属性是否正确 == == ;
            return strCodeForCs.ToString();
        }

        /// <summary>");
        /// 根据条件获取数据表,用DataTable表示");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">表对象</param>");
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public string Gen_4WA_GetDataTable()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取数据表,用DataTable表示");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回满足条件一定范围的DataTable</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataSet objDS;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSet(strWhereCond);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strCodeForCs.Append("\r\n" + "return objDT;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
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
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
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
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">引用型参数,返回:{1}</param>",
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
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>",
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
            strCodeForCs.AppendFormat("\r\n /// <returns>返回{0}</returns>",
                objWebSrvFunctionsENEx.ReturnValueDescription);
            if (objSelfDefDataTypeEN != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "public static {0} {1}({2})",
                        objSelfDefDataTypeEN.CsType, objWebSrvFunctionsENEx.FunctionName,
                        sbParaList.ToString());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "public static {0} {1}({2})",
                            objFuncReturnTypeEN.CsType, objWebSrvFunctionsENEx.FunctionName,
                            sbParaList.ToString());
            }
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "{0}SoapClient obj{0}Service = Get{0}SoapClient();",
                    objWebSrvClassENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "DataSet objDS;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objSelfDefDataTypeEN != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = obj{2}Service.{3}({4});",
                     objSelfDefDataTypeEN.CsType,
                     objSelfDefDataTypeEN.DefaVarName,
                     objWebSrvClassENEx.ClsName,
                     objWebSrvFunctionsENEx.FunctionName,
                     sbParaVarList.ToString());
                strCodeForCs.AppendFormat("\r\n" + "return {0};", objSelfDefDataTypeEN.DefaVarName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{0} {1}Temp = obj{2}Service.{3}({4});",
                    objFuncReturnTypeEN.CsType,
                    objFuncReturnTypeEN.DataTypeAbbr,
                    objWebSrvClassENEx.ClsName,
                    objWebSrvFunctionsENEx.FunctionName,
                    sbParaVarList.ToString());
                strCodeForCs.AppendFormat("\r\n" + "return {0}Temp;", objFuncReturnTypeEN.DataTypeAbbr);
            }
            //strCodeForCs.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        /// <summary>");
        /// 根据条件获取数据表,用DataTable表示");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">表对象</param>");
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public string Gen_4WA_GetTopDataTable()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取数据表,用DataTable表示");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回满足条件一定范围的DataTable</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataSet objDS;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "objDS = obj{0}Service.GetTopDataSet(intTopSize, strWhereCond);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strCodeForCs.Append("\r\n" + "return objDT;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>");
        /// 根据条件获取一定范围的数据表,用DataTable表示");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">表对象</param>");
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public string Gen_4WA_GetDataTableByRange()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取一定范围的数据表,用DataTable表示");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strCodeForCs.Append("\r\n /// <returns>返回满足条件一定范围的DataTable</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataSet objDS;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
                    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strCodeForCs.Append("\r\n" + "return objDT;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 获取表View的DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetDataTableV()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取表视图的DataTable");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>表视图的DataTable</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static DataTable GetDataTableV(string strWhereCond)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataSet objDS;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strCodeForCs.Append("\r\n" + "return objDT;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        /// <summary>");
        /// 根据条件获取一定范围的数据表,用DataTable表示");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">表对象</param>");
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public string Gen_4WA_GetDataTableVByRange()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取一定范围的数据表,用DataTable表示");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strCodeForCs.Append("\r\n /// <returns>返回满足条件一定范围的DataTable</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static DataTable GetDataTableVByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataSet objDS;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetVByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strCodeForCs.Append("\r\n" + "return objDT;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 获取表View的DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetDataTableV2()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取满足条件的表视图的DataTable");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>表视图的DataTable</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static DataTable Get{0}V(string strWhereCond)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataSet objDS;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strCodeForCs.Append("\r\n" + "return objDT;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>");
        /// 根据条件获取一定范围的数据表,用DataTable表示");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">表对象</param>");
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public string Gen_4WA_GetDataTableV2ByRange()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取一定范围的数据表,用DataTable表示");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strCodeForCs.Append("\r\n /// <returns>返回满足条件一定范围的DataTable</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static DataTable GetDataTableVByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataSet objDS;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetVByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strCodeForCs.Append("\r\n" + "return objDT;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_4WA_GetObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strCodeForCs.Append("\r\n /// <returns>返回对象列表</returns>");
            strCodeForCs.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLst(string strWhereCond)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "string strAction = \"GetObjLst\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strCodeForCs.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"获取条件对象列表出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_GetObjLstByKeyLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字列表获取对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objInFor.PrivFuncName);
                }
                strCodeForCs.Append("\r\n /// <returns>返回对象列表</returns>");
                strCodeForCs.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByKeyLsts(List<{2}> arr{1})",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName_FstUcase,
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "string strAction = \"GetObjLstByKeyLsts\";",
                    objKeyField.FldName_FstUcase);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n /// <param name = \"arr{0}\">关键字列表</param>", objKeyField.FldName_FstUcase);
                strCodeForCs.Append("\r\n /// <returns>返回对象列表</returns>");
                strCodeForCs.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstBy{1}Lst(List<{2}> arr{1})",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName_FstUcase,
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "string strAction = \"GetObjLstBy{0}Lst\";",
                    objKeyField.FldName_FstUcase);
            }


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            //strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst(arr{0});", objKeyField.FldName_FstUcase);
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strCodeForCs.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"根据关键字列表获取对象列表出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_GetObjLstByKeyLst_WACache()
        {
            string strFuncParaCode = clsPubFun4GC.GetFuncParaDef4CacheClassfy(this, false, enumProgLangType.CSharp_01);
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字列表获取对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objInFor.PrivFuncName);
                }
                strCodeForCs.Append("\r\n /// <returns>返回对象列表</returns>");
              
                strCodeForCs.Append("\r\n"+$"public static List<cls{objPrjTabENEx.TabName}EN> GetObjLstByKeyLsts_WACache(List<{objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType}> arr{objKeyField.FldName_FstUcase}, {strFuncParaCode})");
              

                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "string strAction = \"GetObjLstByKeyLstsCache\";",
                    objKeyField.FldName_FstUcase);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n /// <param name = \"arr{0}\">关键字列表</param>", objKeyField.FldName_FstUcase);
                strCodeForCs.Append("\r\n /// <returns>返回对象列表</returns>");

                strCodeForCs.Append("\r\n"+$"public static List<cls{objPrjTabENEx.TabName}EN> GetObjLstBy{objKeyField.FldName_FstUcase}Lst_WACache(List<{objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType}> arr{objKeyField.FldName_FstUcase}{strFuncParaCode})");

                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "string strAction = \"GetObjLstBy{0}LstCache\";",
                    objKeyField.FldName_FstUcase);
            }

            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {1}",
                        objPrjTabENEx.objCacheClassifyFld.FldName,
                        objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst(arr{0});", objKeyField.FldName_FstUcase);
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strCodeForCs.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"根据关键字列表获取对象列表出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_GetDataTableByObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据对象列表获取DataTable");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"arrObjLst\">给定的对象列表</param>");
            strCodeForCs.Append("\r\n /// <returns>返回DataTable</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static DataTable GetDataTableByObjLst(List<cls{0}EN> arrObjLst)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "DataTable objDT = new DataTable();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n" + "objDT.Columns.Add(con{0}.{1}, Type.GetType(\"{2}\"));",
                    objPrjTabENEx.TabName, objField.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.NetSysType);
            }
            strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in arrObjLst)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "DataRow objDR = objDT.NewRow();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n" + "objDR[con{0}.{1}] = objInFor[con{0}.{1}];",
                    objPrjTabENEx.TabName, objField.FldName);
            }
            strCodeForCs.Append("\r\n" + "objDT.Rows.Add(objDR);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return objDT;");
            strCodeForCs.Append("\r\n" + "}");

            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_GetTopObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取顶部对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"objTopPara\">获取顶部对象列表的参数对象</param>");
            strCodeForCs.Append("\r\n /// <returns>返回对象列表</returns>");
            strCodeForCs.AppendFormat("\r\npublic static List<cls{0}EN> GetTopObjLst(stuTopPara objTopPara)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "string strAction = \"GetTopObjLst\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = objTopPara.GetDictParam();");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strCodeForCs.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"根据条件获取顶部对象列表,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_GetServiceUrl()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取Web服务的地址");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>返回当前文件中Web服务的地址</returns>");

            strCodeForCs.Append("\r\npublic static string GetServiceUrl(string strPageName, ref string strDir)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n" + "String strServiceUrl = String.Empty;");
            strCodeForCs.Append("\r\n" + "if (strDir == \"0\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strDir = clsDict_PageName_Dic.GetDir4PageName(strPageName);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}/{2}\",");
            strCodeForCs.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx, strPageName);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}/{2}/{3}\",");
            strCodeForCs.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx, strDir, strPageName);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}\",");
            strCodeForCs.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort_Local,");
            strCodeForCs.Append("\r\n" + "strPageName);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}/{2}\",");
            strCodeForCs.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort_Local, strDir, strPageName);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return strServiceUrl;");
            strCodeForCs.Append("\r\n" + "}");

            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_GetWebApiUrl_SelfDefWS()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取Web服务的地址");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>返回当前文件中Web服务的地址</returns>");

            strCodeForCs.Append("\r\npublic static string GetServiceUrl(string strApiControllerName, string strAction, ref string strDir)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n" + "String strServiceUrl = String.Empty;");
            strCodeForCs.Append("\r\n" + "if (strDir == \"0\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strDir = clsDict_PageName_Dic.GetDir4PageName(strApiControllerName);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/api/{1}/{2}/{3}\",");
            strCodeForCs.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx, strApiControllerName, strAction);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/api/{1}/{2}/{3}/{4}\",");
            strCodeForCs.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx, strDir, strApiControllerName, strAction);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/api/{1}/{2}\",");
            strCodeForCs.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort_Local,");
            strCodeForCs.Append("\r\n" + "strApiControllerName, strAction);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/api/{1}/{2}/{3}\",");
            strCodeForCs.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort_Local, strDir, strApiControllerName, strAction);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return strServiceUrl;");
            strCodeForCs.Append("\r\n" + "}");

            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_GetObjLstByRange()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取范围内的对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"objRangePara\">根据范围获取记录的参数对象</param>");

            strCodeForCs.Append("\r\n /// <returns>返回对象列表</returns>");
            strCodeForCs.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByRange(stuRangePara objRangePara)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "string strAction = \"GetObjLstByRange\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam =  objRangePara.GetDictParam();");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strCodeForCs.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_GetObjLstByPager()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件分页获取JSON对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"objPagerPara\">分页获取记录的参数对象</param>");
            strCodeForCs.Append("\r\n /// <returns>返回JSON对象列表</returns>");
            strCodeForCs.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByPager(stuPagerPara objPagerPara)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "string strAction = \"GetObjLstByPager\";");



            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = objPagerPara.GetDictParam();");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strCodeForCs.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_GetObjLstByPagerCache()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件分页获取JSON对象列表, 使用缓存");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"objPagerPara\">分页获取记录的参数对象</param>");
            strCodeForCs.Append("\r\n /// <returns>返回JSON对象列表</returns>");
            strCodeForCs.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByPagerCache(stuPagerPara objPagerPara)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "string strAction = \"GetObjLstByPagerCache\";");



            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = objPagerPara.GetDictParam();");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strCodeForCs.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 获取表对象的所有属性
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetRecordProperty4Object()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据对象的关键字值,获取对象的全部属性");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">相关对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "/// <returns>是否成功</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool Get{0}(ref cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "bool bolResult = obj{0}Service.Get{0}(ref obj{0}EN);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return bolResult;");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 获取表对象的所有属性
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjByKeyId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 获取当前关键字的记录对象,用对象的形式表示.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objInFor.PrivFuncName);
                }
                strCodeForCs.AppendFormat("\r\n /// <returns>表对象</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static cls{0}EN GetObjByKeyLst({2})",
                objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyVarDefineLstStr);
                strCodeForCs.Append("\r\n" + "{");
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    if (objInFor.IsNumberType())
                    {
                        strCodeForCs.Append("\r\n" + $"if ({objInFor.PrivFuncName} == 0) return null;");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"if ({objInFor.PrivFuncName} == \"\") return null;");
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "string strAction = \"GetObjByKeyLst\";", objKeyField.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n /// <returns>表对象</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}({2})",
                objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyVarDefineLstStr);
                strCodeForCs.Append("\r\n" + "{");
                if (objKeyField.IsNumberType())
                {
                    strCodeForCs.Append("\r\n" + $"if ({objKeyField.PrivFuncName} == 0) return null;");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"if ({objKeyField.PrivFuncName} == \"\") return null;");
                }
                strCodeForCs.AppendFormat("\r\n" + "string strAction = \"GetObjBy{0}\";", objKeyField.FldName);
            }

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (objInFor.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString(),", objInFor.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0},", objInFor.PrivFuncName);
                }
            }
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = clsJSON.GetObjFromJson<cls{0}EN>(strResult);", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObj\"]);");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = JsonConvert.DeserializeObject<cls{0}EN>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\n" + "return bolReturnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"获取条件记录出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);

            //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = obj{0}Service.GetObjBy{2}({1});",
            //objPrjTabENEx.TabName, objKeyField.PrivFuncName, objKeyField.FldName);
            //strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 获取表对象的所有属性
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjByKeyId_WACache()
        {
            string strFuncParaCode = clsPubFun4GC.GetFuncParaDef4CacheClassfy(this, false, enumProgLangType.CSharp_01);
            if (strFuncParaCode.Length > 5) strFuncParaCode = $",{strFuncParaCode}";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 获取当前关键字的记录对象,用对象的形式表示.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objInFor.PrivFuncName);
                }
                strCodeForCs.AppendFormat("\r\n /// <returns>表对象</returns>");

                    strCodeForCs.Append("\r\n" + $"public static cls{objPrjTabENEx.TabName}EN GetObjByKeyLst_WACache({objPrjTabENEx.KeyVarDefineLstStr} {strFuncParaCode})");

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string strAction = \"GetObjByKeyLstCache\";", objKeyField.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n /// <returns>表对象</returns>");

                    strCodeForCs.Append("\r\n" + $"public static cls{objPrjTabENEx.TabName}EN GetObjBy{objKeyField.FldName}_WACache({objPrjTabENEx.KeyVarDefineLstStr} {strFuncParaCode})");

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string strAction = \"GetObjBy{0}Cache\";", objKeyField.FldName);
            }

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {1}.ToString(){2}", objKeyField.FldName, objKeyField.PrivFuncName, objPrjTabENEx.objCacheClassifyFld == null ? "" : ",");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {1}{2}", objKeyField.FldName, objKeyField.PrivFuncName, objPrjTabENEx.objCacheClassifyFld == null ? "" : ",");
            }
            if (objPrjTabENEx.objCacheClassifyFld != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {1}",
                objPrjTabENEx.objCacheClassifyFld.FldName,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = clsJSON.GetObjFromJson<cls{0}EN>(strResult);", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObj\"]);");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = JsonConvert.DeserializeObject<cls{0}EN>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\n" + "return bolReturnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"获取条件记录出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);

            //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = obj{0}Service.GetObjBy{2}({1});",
            //objPrjTabENEx.TabName, objKeyField.PrivFuncName, objKeyField.FldName);
            //strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 删除单条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_DelRecord()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字删除记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>实际删除记录的个数</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static int DelRecord({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strAction = \"DelRecord\";");




            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.AppendFormat("\r\n cls{0}EN obj{0}EN = cls{0}WApi.GetObjByKeyLst({1});",
    objPrjTabENEx.TabName, strKeyFldName_PrivateVar);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n cls{0}EN obj{0}EN = cls{0}WApi.GetObjBy{1}({2});",
       objPrjTabENEx.TabName, objKeyField.FldName, strKeyFldName_PrivateVar);
            }
            strCodeForCs.AppendFormat("\r\n" + "if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, {0}.ToString(), out string strResult, out string strErrMsg) == true)",
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "int intResult  = int.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return intResult;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            if (thisCacheClassify.IsForExtendClass == false)
            {
                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache();", objPrjTabENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PropertyName(this.IsFstLcase));
                }
            }
                strCodeForCs.Append("\r\n" + "var intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strCodeForCs.Append("\r\n" + "return intReturnInt;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return 0;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_DelMultiRecord()
        {
            if (objPrjTabENEx.arrKeyFldSet.Count > 1) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字列表删除记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>实际删除记录的个数</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static int Del{0}s(List<string> arr{1})",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "string strAction = \"Del{0}s\";", objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst(arr{0});",
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "int intResult  = int.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return intResult;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            if (thisCacheClassify.IsForExtendClass == false)
            {
                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache();", objPrjTabENEx.TabName);
                }
                else
                {
                    if (objKeyField.IsNumberType())
                    {
                        strCodeForCs.AppendFormat("\r\n cls{0}EN obj{0}EN = cls{0}WApi.GetObjBy{1}({2}.Parse(arr{1}[0]));",
        objPrjTabENEx.TabName, objKeyField.FldName, objKeyField.CsType);

                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n cls{0}EN obj{0}EN = cls{0}WApi.GetObjBy{1}(arr{1}[0]);",
        objPrjTabENEx.TabName, objKeyField.FldName, objKeyField.PrivFuncName);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PropertyName(this.IsFstLcase));
                }
            }
            strCodeForCs.Append("\r\n" + "var intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strCodeForCs.Append("\r\n" + "return intReturnInt;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return 0;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_DelRecords()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字列表删除记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>实际删除记录的个数</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static int DelRecords(string strKeyIdLst)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "string strAction = \"DelRecords\";", objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst(strKeyIdLst);",
            //    objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "int intResult  = int.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return intResult;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strCodeForCs.Append("\r\n" + "return intReturnInt;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return 0;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_DelMultiRecordByCond()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件删除记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>实际删除记录的个数</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static int Del{0}sByCond(string strWhereCond)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "string strAction = \"Del{0}sByCond\";", objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strCodeForCs.Append("\r\n" + "};");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "  int intRecCount =  int.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return intRecCount;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strCodeForCs.Append("\r\n" + "return intReturnInt;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return 0;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_AddNewRecordWithMaxId()
        {
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 添加记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>新建记录的关键字</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static {1} AddNewRecordWithMaxId(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName, objKeyField.CsType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strAction = \"AddNewRecordWithMaxId\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "bool bolResult = bool.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return bolResult;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (thisCacheClassify.IsForExtendClass == false)
            {
                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache();", objPrjTabENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PropertyName(this.IsFstLcase));
                }
            }
                strCodeForCs.AppendFormat("\r\n" + "var {0} = ({1})jobjReturn0[\"returnStr\"];", objKeyField.PrivFuncName, objKeyField.CsType);
            strCodeForCs.AppendFormat("\r\n" + "return {0};", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return \"\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_AddNewRecord()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 添加记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>是否成功?</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool AddNewRecord(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strAction = \"AddNewRecord\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "bool bolResult = bool.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return bolResult;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (thisCacheClassify.IsForExtendClass == false)
            {
                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache();", objPrjTabENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PropertyName(this.IsFstLcase));
                }
            }
            strCodeForCs.Append("\r\n" + "var bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strCodeForCs.Append("\r\n" + "return bolReturnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return false;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_DefineObjCommFun4BL()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;
            strCodeForCs.Append("\r\n" + " /// <summary>");
            strCodeForCs.Append("\r\n" + "/// 专门在逻辑层用于处理缓存等公共函数的对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.Append("\r\n" + "public static clsCommFun4BL objCommFun4WApi = null;");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "public static clsCommFun4BLV2 objCommFun4WApi = null;");
            }
            //strCodeForCs.Append("\r\n" + "public static event OnAddNewRecord onAddNewRecord;");
            //strCodeForCs.Append("\r\n" + "public static event OnUpdateRecord onUpdateRecord;");
            //strCodeForCs.Append("\r\n" + "public static event OnDeleteRecord onDelRecord;");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_CopyObj_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把同一个类的对象,复制到另一个对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n public static void CopyTo(cls{0}EN obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //只写
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{2}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                      objField.ObjFieldTabENEx.FldName,
                      objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                }
            }

            //strCodeForCs.AppendFormat("\r\n" + "{0}DA.CopyTo(obj{0}ENS, obj{0}ENT);",
            //objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyTo", "Copy表:{0} 对象数据出错!", "生成代码");

            strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})Copy表对象数据出错,{{1}}.({{0}})\",", strErrId, "{", "}");
            strCodeForCs.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.AppendFormat("\r\n" + "objException.Message); ");
            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy表:{0} 对象数据出错!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"Copy表:{0} 对象数据出错!({1}: CopyTo)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_ToDataTable()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// 对象列表 转换为 DataTable数据集合");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "/// <param name=\"arrObj\">原对象列表</param>");
            strCodeForCs.Append("\r\n" + "/// <returns>返回的DataTable</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static DataTable ToDataTable(List<cls{0}EN> arrObj)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "DataTable dataTable = new DataTable(); //实例化");
            strCodeForCs.Append("\r\n" + "DataTable result;");

            strCodeForCs.Append("\r\n" + "if (arrObj.Count == 0) return null;");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}EN._AttributeName.Length == 0)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "result = dataTable;");
            strCodeForCs.Append("\r\n" + "return result;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "Type type = typeof(cls{0}EN);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "PropertyInfo[] arrPropertyInfo = type.GetProperties();");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//Columns");
            strCodeForCs.AppendFormat("\r\n" + "foreach (string strAttrName in cls{0}EN._AttributeName)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();");
            strCodeForCs.Append("\r\n" + "dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in arrObj)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//Rows");
            strCodeForCs.Append("\r\n" + "DataRow dataRow = dataTable.NewRow();");
            strCodeForCs.AppendFormat("\r\n" + "foreach (string strAttrName in cls{0}EN._AttributeName)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "dataRow[strAttrName] = objInFor[strAttrName];");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "dataTable.Rows.Add(dataRow); //循环添加行到DataTable中");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objExceptoin)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw objExceptoin;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "result = dataTable;");
            strCodeForCs.Append("\r\n" + "return result;");
            strCodeForCs.Append("\r\n" + "}");

            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
        }



        public string Gen_4WA_UpdateRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 修改记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>是否成功?</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool UpdateRecord(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.sfUpdFldSetStr) == true)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).\",");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1}, clsStackTrace.GetCurrClassFunction());", objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "string strAction = \"UpdateRecord\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "bool bolResult = bool.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return bolResult;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strCodeForCs.Append("\r\n" + "return bolReturnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return false;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_EditRecordEx()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 编辑记录，根据条件存在就修改，不存在就添加");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>是否成功?</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool EditRecordEx(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.sfUpdFldSetStr) == true)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).\",");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1}, clsStackTrace.GetCurrClassFunction());", objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "string strAction = \"EditRecordEx\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "bool bolResult = bool.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return bolResult;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strCodeForCs.Append("\r\n" + "return bolReturnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return false;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_IsExistRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件判断是否存在记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>是否存在?存在返回True</returns>");
            strCodeForCs.Append("\r\n" + "public static bool IsExistRecord(string strWhereCond)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//检测记录是否存在");
            strCodeForCs.Append("\r\n" + "string strAction = \"IsExistRecord\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strCodeForCs.Append("\r\n" + "};");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strCodeForCs.Append("\r\n" + "return bolReturnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return false;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"获取条件记录出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "bool bolIsExist = obj{0}Service.IsExistRecord(strWhereCond);",
            //objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return bolIsExist;");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_GetRecCountByCond()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相关记录数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>记录数</returns>");
            strCodeForCs.Append("\r\n" + "public static int GetRecCountByCond(string strWhereCond)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "string strAction = \"GetRecCountByCond\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "return int.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strCodeForCs.Append("\r\n" + "return intReturnInt;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return 0;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"获取条件记录出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "int intRecCount = obj{0}Service.GetRecCountByCond(strWhereCond);",
            //objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return intRecCount;");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_GetFldValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相关记录数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>记录数</returns>");
            strCodeForCs.Append("\r\n" + "public static List<string> GetFldValue(string strFldName, string strWhereCond)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "string strAction = \"GetFldValue\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "[\"strFldName\"] = strFldName,");
            strCodeForCs.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "return int.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "var arrReturnStrLst = (List<string>)jobjReturn0[\"returnStrLst\"];");
            //strCodeForCs.Append("\r\n" + "return arrReturnStrLst;");
            strCodeForCs.Append("\r\n" + "string strReturnStrLst = (string)jobjReturn0[\"returnStrLst\"];");
            strCodeForCs.Append("\r\n" + "var arrReturnStrLst = strReturnStrLst.Split(\",\".ToCharArray());");
            strCodeForCs.Append("\r\n" + "return arrReturnStrLst.Select(x => x).ToList();");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"获取条件记录出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "int intRecCount = obj{0}Service.GetRecCountByCond(strWhereCond);",
            //objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return intRecCount;");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_funSetFldValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件设置字段值");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strFldName\">字段名</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strValue\">值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>记录数</returns>");
            strCodeForCs.Append("\r\n" + "public static int SetFldValue(string strFldName, string strValue, string strWhereCond)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "string strAction = \"SetFldValue\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "[\"strFldName\"] = strFldName,");
            strCodeForCs.Append("\r\n" + "[\"strValue\"] = strValue,");
            strCodeForCs.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "return int.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "var arrReturnStrLst = (List<string>)jobjReturn0[\"returnStrLst\"];");
            //strCodeForCs.Append("\r\n" + "return arrReturnStrLst;");
            strCodeForCs.Append("\r\n" + "var intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strCodeForCs.Append("\r\n" + "return intReturnInt;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return 0;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"根据条件设置字段值,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "int intRecCount = obj{0}Service.GetRecCountByCond(strWhereCond);",
            //objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return intRecCount;");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_IsExist()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字判断是否存在记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>是否存在?存在返回True</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool IsExist({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//检测记录是否存在");
            strCodeForCs.Append("\r\n" + "string strAction = \"IsExist\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {                   
                    
                    if (objInFor.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString(),", objInFor.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0},", objInFor.PrivFuncName);
                    }
                }
            }
            else
            {

                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString()", objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0}", objKeyField.PrivFuncName);
                }
            }
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "bool bolIsExist = bool.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return bolIsExist;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strCodeForCs.Append("\r\n" + "return bolReturnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return false;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"获取条件记录出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "bool bolIsExist = obj{0}Service.IsExist({1});",
            //objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            //strCodeForCs.Append("\r\n" + "return bolIsExist;");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_GetMaxStrId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static string GetMaxStrId()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strAction = \"GetMaxStrId\";");


                strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");


                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "string strMax{0} = strResult;",
                //objKeyField.FldName_FstUcase);
                //strCodeForCs.AppendFormat("\r\n" + "return strMax{0};",
                //objKeyField.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
                strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "var strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                strCodeForCs.Append("\r\n" + "return strReturnStr;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else return \"\";");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"获取最大值出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_GetMaxStrIdByPrefix()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static string GetMaxStrIdByPrefix(string strPrefix)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//检测记录是否存在");
                strCodeForCs.Append("\r\n" + "string strAction = \"GetMaxStrIdByPrefix\";");


                strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "{\"strPrefix\", strPrefix}");
                strCodeForCs.Append("\r\n" + "};");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "string strMax{0} = strResult;",
                //objKeyField.FldName_FstUcase);
                //strCodeForCs.AppendFormat("\r\n" + "return strMax{0};",
                //objKeyField.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
                strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "var strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                strCodeForCs.Append("\r\n" + "return strReturnStr;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else return \"\";");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"根据前缀获取最大值出错,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetFirstID()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取当前表满足条件的第一条记录的关键字值");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static {0} GetFirstID(string strWhereCond)",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "string strAction = \"GetFirstID\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            switch (objKeyField.CsType)
            {
                case "long":
                    //strCodeForCs.Append("\r\n" + "return long.Parse(strResult);");
                    strCodeForCs.Append("\r\n" + "var strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                    strCodeForCs.Append("\r\n" + "return long.Parse(strReturnStr);");
                    break;
                case "int":
                    //strCodeForCs.Append("\r\n" + "return int.Parse(strResult);");
                    strCodeForCs.Append("\r\n" + "var strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                    strCodeForCs.Append("\r\n" + "return int.Parse(strReturnStr);");
                    break;
                default:
                    //strCodeForCs.Append("\r\n" + "return strResult;");
                    strCodeForCs.Append("\r\n" + "var strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                    strCodeForCs.Append("\r\n" + "return strReturnStr;");
                    break;
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
            {
                strCodeForCs.Append("\r\n" + "else return 0;");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "else return \"\";");
            }
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetFirstObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取当前表满足条件的第一条记录的对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static cls{1}EN GetFirstObj(string strWhereCond)",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "string strAction = \"GetFirstObj\";", objPrjTabENEx.TabName);


            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = clsJSON.GetObjFromJson<cls{0}EN>(strResult);", objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObj\"]);");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = JsonConvert.DeserializeObject<cls{0}EN>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\n" + "return bolReturnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");


            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 添加记录,并且返回关键字
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_AddNewRecordWithReturnKey()
        {
            if (objKeyField.PrimaryTypeId != "02") return "";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的表对象</param>",
                    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns>返回新添加记录的关键字</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static string AddNewRecordWithReturnKey(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strAction = \"AddNewRecordWithReturnKey\";");

            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "string strKey = strResult;",
            //objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return strKey;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (thisCacheClassify.IsForExtendClass == false)
            {
                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache();", objPrjTabENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PropertyName(this.IsFstLcase));
                }
            }
                strCodeForCs.Append("\r\n" + "var strReturnStr = (string)jobjReturn0[\"returnStr\"];");
            strCodeForCs.Append("\r\n" + "return strReturnStr;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return \"\";");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 添加记录,并且返回关键字
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_UpdateWithCondition()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取当前表满足条件的第一条记录的对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的对象</param>",
                  objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool UpdateWithCondition(cls{0}EN obj{0}EN, string strWhereCond)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.sfUpdFldSetStr) == true)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).\",");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1}, clsStackTrace.GetCurrClassFunction());", objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strWhereCond) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).\",");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1}, clsStackTrace.GetCurrClassFunction());", objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "string strAction = \"UpdateWithCondition\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "bool bolResult = bool.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return bolResult;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strCodeForCs.Append("\r\n" + "return bolReturnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return false;");

            strCodeForCs.Append("\r\n" + "}");



            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
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
        //    if (objPrjTabENEx.IsUseCache == false) return string.Format("//该表没有使用Cache,不需要生成[Get{0}By{1}Cache]函数;",
        //strTextFieldName, objKeyField.FldName);
        //    if (objPrjTabENEx.IsUseCache_TS() == false) return $"//该表没有使用Cache,不需要生成[Get{strTextFieldName}By{objKeyField.FldName}Cache]函数;(in {clsStackTrace.GetCurrClassFunction()})";

            StringBuilder strCodeForCs = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 根据关键字获取相关名称, 从缓存的对象列表中获取.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n /// <returns>根据关键字获取的名称</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static string Get{4}By{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName,
            strTextFieldName);
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "//初始化列表缓存");
            strCodeForCs.Append("\r\n" + "InitListCache(); ");


            strCodeForCs.Append("\r\n" + "int intStart = 0;");
            strCodeForCs.AppendFormat("\r\n" + "int intEnd = arr{0}ObjLstCache.Count - 1;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "int intMid = 0;");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                 objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "while (intEnd >= intStart)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intMid = (intStart + intEnd) / 2;");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = arr{0}ObjLstCache[intMid];",
              objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
                objPrjTabENEx.TabName,
                objKeyField.PropertyName(this.IsFstLcase),
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intFindFailCount = 0;");
            strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN.{1};",
                  objPrjTabENEx.TabName,
                  strTextFieldName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if (obj{0}EN.{1}.CompareTo({2}) > 0)",
                  objPrjTabENEx.TabName,
                  objKeyField.PropertyName(this.IsFstLcase),
                  objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intEnd = intMid - 1;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intStart = intMid + 1;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLstCache)",
            //objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
            //objPrjTabENEx.TabName,
            //objKeyField.FldName,
            //objKeyField.PrivFuncName);
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN.{1};",
            //objPrjTabENEx.TabName,
            //strTextFieldName);
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "intFindFailCount++;");
            strCodeForCs.AppendFormat("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (intFindFailCount == 1) return Get{0}By{1}Cache({2});",
                strTextFieldName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"在{2}对象缓存列表中,找不到记录[{3} = {{0}}][intFindFailCount = {{1}}](函数:{{2}})\", {4}, intFindFailCount, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN != null)",
                  objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"最后一次查找的对象相关字段属性值:{{0}}.[intMid = {{1}}]\", obj{2}EN.{3}, intMid);",
               "{", "}",
               objPrjTabENEx.TabName,
               objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"最后一次查找的对象为null, 请检查![intMid = {{0}}]\", intMid);",
               "{", "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName,
                strTextFieldName);
            //strCodeForCs.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            //strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "throw new Exception(strErrMsgForGetObjById);");
            //strCodeForCs.AppendFormat("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 初始化列表缓存.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_InitListCache()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //初始化列表缓存.-----------------------------;


            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 初始化列表缓存.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.Append("\r\n" + "public static void InitListCache()");
            strCodeForCs.Append("\r\n" + "{");

            if (objPrjTabENEx.SqlDsTypeId == clsSQLDSTypeBLEx.SQLTAB)
            {
                strCodeForCs.Append("\r\n" + "//检查缓存刷新机制");
                strCodeForCs.Append("\r\n" + "string strMsg;");
                strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WApi.objCommFun4WApi == null)", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"类cls{2}WApi没有刷新缓存机制({2}_objCommFun4WApi == null), 请联系程序员!(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                    "{", "}", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
            }
            else if (objPrjTabENEx.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW)
            {
                List<string> arrTabId = clsPrjTabBLEx.GetRelaParentNodeByTabId(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
                bool bolIsDef_strMsg = false;
                foreach (string strRelaTabId in arrTabId)
                {
                    clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strRelaTabId, objPrjTabENEx.PrjId);
                    if (objPrjTab.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW) continue;
                    if (objPrjTab.TabName == "Sex")
                    {
                        string strMsg = string.Format("objPrjTab.TabName={0},objPrjTab.TabStateId='{1}'",
                            objPrjTab.TabName, objPrjTab.TabStateId);
                        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                    }
                    if (objPrjTab.TabStateId != "01") continue;

                    if (bolIsDef_strMsg == false)
                    {
                        strCodeForCs.Append("\r\n" + "//检查缓存刷新机制");
                        strCodeForCs.Append("\r\n" + "string strMsg;");
                        bolIsDef_strMsg = true;
                    }
                    strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WApi.objCommFun4WApi == null)", objPrjTab.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"类cls{2}WApi没有刷新缓存机制(cls{2}WApi.objCommFun4WApi == null), 请联系程序员!(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        "{", "}", objPrjTab.TabName);
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }

            strCodeForCs.Append("\r\n" + "//初始化列表缓存");
            strCodeForCs.AppendFormat("\r\n" + "//string strWhereCond = string.Format(\"1 = 1 order by {0}\");", objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "//if (arr{0}ObjLstCache == null)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//{");
            strCodeForCs.AppendFormat("\r\n" + "//arr{0}ObjLstCache = await cls{0}WApi.GetObjLst(strWhereCond);",
                  objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "intFldNumCache = arr{0}ObjLstCache.Count;", 
            //      objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//}");
            strCodeForCs.Append("\r\n" + "}");

            //初始化列表缓存.======================= = ;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjByKeyCache()
        {
            //if (objPrjTabENEx.IsUseCache == false) return string.Format("//该表没有使用Cache,不需要生成[GetObjByKeyLstCache()]函数;",
            //                   objKeyField.FldName);
            //if (objPrjTabENEx.IsUseCache_TS() == false) return $"//该表没有使用Cache,不需要生成[GetObjByKeyLstCache()]函数;(in {clsStackTrace.GetCurrClassFunction()})";
            Tuple<string,string, string> tup = thisWA_FP(WA_F.GetObjByKeyId_Cache, "CSharp");

            string strParaVarLstStr_KeyField = clsPubFun4GC.GetParaVarLstStr4KeyField(this, false, enumProgLangType.CSharp_01);

            //var strFuncParamsLst_Cache = tup.Item3;

            string strFuncParaCode4KeyField = clsPubFun4GC.GetFuncParaDef4KeyField(this, false, enumProgLangType.CSharp_01);
            string strFuncParaCode = clsPubFun4GC.GetFuncParaDef4CacheClassfy(this, false, enumProgLangType.CSharp_01);
            if (strFuncParaCode.Length > 5) strFuncParaCode = $",{strFuncParaCode}";

            Tuple<string, string, string> tup_GetObjLstCache = thisWA_FP(WA_F.GetObjLst_Cache, "CSharp");
               
            string strFuncParamsLst_Cache = clsPubFun4GC.GetParaVarLstStr4CacheClassfy(this, false, enumProgLangType.CSharp_01);
   
            StringBuilder strCodeForCs = new StringBuilder();
            //根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objInFor.PrivFuncName);
                }
                strCodeForCs.AppendFormat("\r\n /// <returns>根据关键字获取的对象</returns>");

                strCodeForCs.Append("\r\n" + $"public static cls{objPrjTabENEx.TabName}EN GetObjByKeyLstCache({strFuncParaCode4KeyField}{strFuncParaCode})");

                strCodeForCs.Append("\r\n" + "{");
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    if (objInFor.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return null;",
                          objKeyField.PrivFuncName);
                    }
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n /// <returns>根据关键字获取的对象</returns>");


                strCodeForCs.Append("\r\n" + $"public static cls{objPrjTabENEx.TabName}EN GetObjBy{objKeyField.FldName}Cache({strFuncParaCode4KeyField}{strFuncParaCode})");

                strCodeForCs.Append("\r\n" + "{");
                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return null;",
                      objKeyField.PrivFuncName);
                }
            }
            strCodeForCs.Append("\r\n" + "//初始化列表缓存");
            //strCodeForCs.Append("\r\n" + "InitListCache(); ");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache();",
                    objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache({1});",
                    objPrjTabENEx.TabName, strFuncParamsLst_Cache);
            }
            strCodeForCs.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel =", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "from obj{0}EN in arr{0}ObjLstCache", objPrjTabENEx.TabName);
            int intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "where obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + " && obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                intIndex++;
            }
            strCodeForCs.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst_Sel.Count() == 0)",
      objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.AppendFormat("\r\n" + "   cls{0}EN obj = cls{0}WApi.GetObjByKeyLst({2});",
                         objPrjTabENEx.TabName,
                         objKeyField.FldName,
                         objPrjTabENEx.KeyPrivFuncFldNameLstStr);

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "   cls{0}EN obj = cls{0}WApi.GetObjBy{1}({2});",
                            objPrjTabENEx.TabName,
                            objKeyField.FldName,
                            objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            }
            strCodeForCs.Append("\r\n" + "   if (obj != null)");
            strCodeForCs.Append("\r\n" + " {");
            //strCodeForCs.AppendFormat("\r\n" + "     cls{0}BL.arr{0}ObjLstCache = null;",
            //            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "CacheHelper.Remove(strKey);", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "     return obj;");
            strCodeForCs.Append("\r\n" + " }");
            strCodeForCs.Append("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel.First();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            //根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strCodeForCs.ToString();
        }

        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjLstByKeyLstCache()
        {

            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;     
            //if (objPrjTabENEx.IsUseCache == false) return string.Format("//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache()]函数;",
            //                  objKeyField.FldName);

            //if (objPrjTabENEx.IsUseCache_TS() == false) return $"//该表没有使用Cache,不需要生成[GetObjLstByKeyLstsCache()]函数;(in {clsStackTrace.GetCurrClassFunction()})";


            Tuple<string, string, string> tup = thisWA_FP(WA_F.GetObjLst_Cache, "CSharp");


            string strFuncParaCode = clsPubFun4GC.GetFuncParaDef4CacheClassfy(this, false, enumProgLangType.CSharp_01);
            string strParaVarLstStr_Cache = clsPubFun4GC.GetParaVarLstStr4CacheClassfy(this, false, enumProgLangType.CSharp_01);
            string strParaVarLstStr_KeyField = clsPubFun4GC.GetParaVarLstStr4KeyField(this, false, enumProgLangType.CSharp_01);
            
            StringBuilder strCodeForCs = new StringBuilder();
            //根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {


                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                    {
                        strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objInFor.PrivFuncName);
                    }
                    strCodeForCs.AppendFormat("\r\n /// <returns>根据关键字列表获取的对象</returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static IEnumerable<cls{0}EN> GetObjLstByKeyLstsCache(List<{2}> arr{1})",
                objPrjTabENEx.TabName,
                objKeyField.FldName_FstUcase,
                objKeyField.CsType,
                objKeyField.PrivFuncName);
                }
                else
                {
                    foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                    {
                        strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objInFor.PrivFuncName);
                    }
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">分类字段值</param>", objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n /// <returns>根据关键字列表获取的对象</returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static IEnumerable<cls{0}EN> GetObjLstByKeyLstsCache(List<{2}> arr{1}, {3})",
             objPrjTabENEx.TabName,
             objKeyField.FldName_FstUcase,
             objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
             strFuncParaCode);
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n /// <param name = \"arr{0}\">所给的关键字列表</param>", objKeyField.FldName_FstUcase);
                strCodeForCs.AppendFormat("\r\n /// <returns>根据关键字列表获取的对象</returns>");
                              
                strCodeForCs.Append("\r\n" + $"public static IEnumerable<cls{objPrjTabENEx.TabName}EN> GetObjLstBy{objKeyField.FldName_FstUcase}LstCache(List<{objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType}> arr{objKeyField.FldName_FstUcase}, {strFuncParaCode})");
              
            }

            strCodeForCs.Append("\r\n" + "{");
            //if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return null;",
            //      objKeyField.PrivFuncName);
            //}
            strCodeForCs.Append("\r\n" + "//初始化列表缓存");
            //strCodeForCs.Append("\r\n" + "InitListCache(); ");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache();",
                    objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache({1});",
                    objPrjTabENEx.TabName, strParaVarLstStr_Cache);
            }
            strCodeForCs.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel =", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "from obj{0}EN in arr{0}ObjLstCache", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "where arr{1}.Contains(obj{0}EN.{2})",
                objPrjTabENEx.TabName,
                objKeyField.FldName_FstUcase,
                objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            //根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strCodeForCs.ToString();
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
        //    if (objPrjTabENEx.IsUseCache == false) return string.Format("//该表没有使用Cache,不需要生成[Get{0}By{1}Cache]函数;",
        //strTextFieldName, objKeyField.FldName);
        //    if (objPrjTabENEx.IsUseCache() == false) return $"//该表没有使用Cache,不需要生成[Get{strTextFieldName}By{objKeyField.FldName}Cache]函数;(in {clsStackTrace.GetCurrClassFunction()})";

            Tuple<string, string, string> tup = thisWA_FP(WA_F.GetRecNameByKeyCache, "CSharp");
            string strFuncParaCode = clsPubFun4GC.GetFuncParaDef4CacheClassfy(this, false, enumProgLangType.CSharp_01);
            if (strFuncParaCode.Length > 5) strFuncParaCode = $",{strFuncParaCode}";
            string strParaVarLstStr_KeyField = clsPubFun4GC.GetParaVarLstStr4KeyField(this, false, enumProgLangType.CSharp_01);

            //var strFuncParamsLst_Cache = tup.Item3;


            Tuple<string, string, string> tup_GetObjLstCache = thisWA_FP(WA_F.GetObjLst_Cache, "CSharp");

            
            string strFuncParamsLst_Cache = clsPubFun4GC.GetParaVarLstStr4CacheClassfy(this, false, enumProgLangType.CSharp_01);
            string strFuncParaCode4KeyField = clsPubFun4GC.GetFuncParaDef4KeyField(this, false, enumProgLangType.CSharp_01);

            StringBuilder strCodeForCs = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 根据关键字获取相关名称, 从缓存的对象列表中获取.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n /// <returns>根据关键字获取的名称</returns>");
          
                strCodeForCs.Append("\r\n" + $"public static string Get{strTextFieldName}By{objKeyField.FldName}Cache({strFuncParaCode4KeyField}{strFuncParaCode})");
          
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "//初始化列表缓存");
            //strCodeForCs.Append("\r\n" + "InitListCache(); ");

            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache({1});",
                objPrjTabENEx.TabName, strFuncParamsLst_Cache);

            strCodeForCs.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel1 =", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "from obj{0}EN in arr{0}ObjLstCache", objPrjTabENEx.TabName);
            int intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "where obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + " && obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                intIndex++;
            }
            strCodeForCs.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst_Sel = new List<cls{0}EN>();", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj in arr{0}ObjLst_Sel1)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst_Sel.Add(obj);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst_Sel.Count > 0)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel[0].{1};",
                objPrjTabENEx.TabName, strTextFieldName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"在{2}对象缓存列表中,找不到记录[{3} = {{0}}](函数:{{1}})\", {4}, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
            strCodeForCs.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName,
                strTextFieldName);
            //strCodeForCs.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            //strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "throw new Exception(strErrMsgForGetObjById);");
            //strCodeForCs.AppendFormat("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 根据关键字获取相关名称, 从缓存的对象列表中获取.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n /// <returns>根据关键字获取的名称</returns>");

                strCodeForCs.Append("\r\n" + $"public static string GetNameBy{objKeyField.FldName}Cache({strFuncParaCode4KeyField}{strFuncParaCode})");

            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "//初始化列表缓存");
            //strCodeForCs.Append("\r\n" + "InitListCache(); ");

         
                //strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                //                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache({1});",
                    objPrjTabENEx.TabName, strFuncParamsLst_Cache);
         
            strCodeForCs.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel1 =", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "from obj{0}EN in arr{0}ObjLstCache", objPrjTabENEx.TabName);
            intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "where obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + " && obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                intIndex++;
            }
            strCodeForCs.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst_Sel = new List<cls{0}EN>();", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj in arr{0}ObjLst_Sel1)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst_Sel.Add(obj);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst_Sel.Count > 0)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel[0].{1};",
                objPrjTabENEx.TabName, strTextFieldName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"在{2}对象缓存列表中,找不到记录的相关名称[{3} = {{0}}](函数:{{1}})\", {4}, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
            strCodeForCs.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName,
                strTextFieldName);
            //strCodeForCs.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            //strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "throw new Exception(strErrMsgForGetObjById);");
            //strCodeForCs.AppendFormat("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 把表中内容绑定到ListView。
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_BindListView()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //strCodeForCs.Append("\r\n //1/生成绑定ListView的代码");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:根据界面上查询控件中所设置内容查询表记录,");
                strCodeForCs.Append("\r\n ///			 并显示在ListView中。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public static int BindLv_{0}(System.Windows.Forms.ListView lv{0}, string strWhereCond)",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:(共4步)");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.Append("\r\n" + "//	3、设置ListView的列头信息");
                strCodeForCs.Append("\r\n" + "//	4、设置ListView的Item信息。即把所有记录显示在ListView中");
                strCodeForCs.Append("\r\n" + "//		在本界面中是把状态显示在控件lblRecCount中。");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "System.Windows.Forms.ListViewItem lvi{0}; ",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst;",
                objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = GetObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	3、设置ListView的列头信息");
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Clear();//清除原来所有Item",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Clear();//清除原来所有列头信息",
                objPrjTabENEx.TabName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId != "04" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "byte[]")	//不是管理字段
                    {
                        strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Add(\"{1}\", 100, System.Windows.Forms.HorizontalAlignment.Left);",
                        objPrjTabENEx.TabName, objField.ColCaption);
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.View = System.Windows.Forms.View.Details;",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	4、设置ListView的Item信息。即把所有记录显示在ListView中");
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLst)",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "lvi{0} = new System.Windows.Forms.ListViewItem();",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Tag = obj{0}EN.{1};",
                objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Text = obj{0}EN.{1}.ToString();",
                objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
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
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1});",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1}.ToString());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                        }
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Add(lvi{0});",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//	4、设置记录数的状态,");
                strCodeForCs.Append("\r\n" + "//		在本界面中是把状态显示在控件txtRecCount中。");
                strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst.Count;",
                objPrjTabENEx.TabName);
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
        public string Gen_4WA_TabFeature_ComboBoxBindFunction()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            bool bolIsNeedQuote = true;
            //clsDataTypeAbbrEN objDataTypeAbbr4ValueField = null;
            try
            {
                List<clsTabFeatureEN> arrTabFeature = objPrjTabENEx.arrTabFeatureSet().Where(x => x.FeatureId == enumPrjFeature.Tab_BindDdl_0173).ToList();
                foreach (var objTabFeature_BindDdl in arrTabFeature)
                {
                    if (objTabFeature_BindDdl == null) continue;
                    if (objTabFeature_BindDdl.IsNeedGC == false)
                    {
                        strCodeForCs.Append("\r\n//该表下拉框功能不需要生成;");
                        continue;
                    }
                    if (objTabFeature_BindDdl.IsExtendedClass == true)
                    {
                        strCodeForCs.Append("\r\n//该表下拉框功能仅仅使用在扩展类;");
                        continue;
                    }
                    //clsTabFeatureFldsENEx objField_OrderNum = objTabFeature_AdjustOrderNum.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.OrderNumField_09);

                    if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.NameField_03) == false)
                    {
                        continue;
                        //                        throw new Exception("当前表没有名称字段,不能添加绑定下拉框功能!");
                    }
                    if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.KeyField_02) == false)
                    {
                        continue;
                        //                        throw new Exception("当前表没有关键字段,不能添加绑定下拉框功能!");
                    }
                    List<clsTabFeatureFldsENEx> arrFieldLst_Cond = objTabFeature_BindDdl.arrTabFeatureFldsSetEx().Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();

                    List<string> arrCondFldId = objTabFeature_BindDdl.GetCondFldIdLst();
                    var objFuncParaLst = new FuncParaLst("DdlParaLst", this.IsFstLcase, enumAppLevel.DefindFunc);
                    objFuncParaLst.AddParaByTabFeature(objTabFeature_BindDdl, arrFieldLst_Cond, enumProgLangType.CSharp_01);
                    objFuncParaLst.AddParaByCacheClassify(thisCacheClassify, arrCondFldId, enumProgLangType.CSharp_01);
                    string strFuncPara = objFuncParaLst.GetCondFldLst4Para4CSharp();
                    string strPrivFuncName_Additional = objFuncParaLst.GetCondFldLst();
                    string strCodeText_CheckEmpty = objFuncParaLst.Gc_CheckVarEmpty_Cs(this.ClsName,
                        objTabFeature_BindDdl.FuncNameJs, true);
                    string strFuncRemark = objFuncParaLst.GetFuncRemark4CSharp();

                    clsTabFeatureFldsEN objField_Key = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.KeyField_02);
                    clsTabFeatureFldsEN objField_Name = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.NameField_03);
                    string strTextFieldName = objField_Name.ObjFieldTab().FldName;
                    string strValueFieldName = objField_Key.ObjFieldTab().FldName;
                    bolIsNeedQuote = objField_Key.ObjFieldTab().ObjDataTypeAbbr1().IsNeedQuote;
                    //第0步:把控件中下拉框ComboBox转换成ComboBox


                    if (strValueFieldName != "" && strTextFieldName != "")
                    {
                        strCodeForCs.Append("\r\n /// <summary>");
                        strCodeForCs.Append("\r\n /// 绑定基于Win的下拉框");
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n /// </summary>");
                        strCodeForCs.Append("\r\n /// <param name = \"objComboBox\">需要绑定当前表的下拉框</param>");
                        //生成与条件参数的函数说明
                        strCodeForCs.Append("\r\n" + strFuncRemark);

                        strCodeForCs.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox {1})",
                            strValueFieldName, strFuncPara == "" ? "" : ", " + strFuncPara);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "//为数据源为表的下拉框设置内容");
                        strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"1 =1 Order By {{0}}\", con{0}.{1}); ",
                            objPrjTabENEx.TabName, strValueFieldName);
                        if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.SortField_06) == true)
                        {
                            clsTabFeatureFldsEN objField_Sort = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.SortField_06);
                            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = cls{0}WApi.GetObjLst(strCondition).OrderBy(x=>x.{1}).ToList();",
                                 objPrjTabENEx.TabName,
                                 objField_Sort.ObjFieldTab().FldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = cls{0}WApi.GetObjLst(strCondition);",
                                 objPrjTabENEx.TabName);
                        }
                        //生成过滤条件语句
                        string strFilterCondition = objFuncParaLst.GeneFilterCondition4CSharp(false);
                        strCodeForCs.Append(strFilterCondition);
                        string strObjLstName = "arrObjLst";
                        if (strFilterCondition.Length > 5)
                        {
                            strObjLstName = "arrObjLstSel";
                        }
                        //strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = cls{1}BL.GetDataTable(strCondition);",
                        //    strValueFieldName, objPrjTabENEx.TabName);

                        strCodeForCs.AppendFormat("\r\n" + "//初始化一个对象列表");

                        strCodeForCs.Append("\r\n" + "//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。");
                        strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN()",
                        objPrjTabENEx.TabName);
                        strCodeForCs.Append("\r\n" + "{");
                        if (bolIsNeedQuote == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{1} = \"0\",",
                            objPrjTabENEx.TabName, strValueFieldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{1} = 0,",
                            objPrjTabENEx.TabName, strValueFieldName);

                        }

                        strCodeForCs.AppendFormat("\r\n" + "{1} = \"选[{2}]...\"",
                            objPrjTabENEx.TabName, strTextFieldName, objPrjTabENEx.TabCnName);
                        strCodeForCs.Append("\r\n" + "};");

                        strCodeForCs.AppendFormat("\r\n" + "{1}.Insert(0, obj{0}EN);",
                        objPrjTabENEx.TabName, strObjLstName);

                        strCodeForCs.Append("\r\n" + "//设置下拉框的数据源、以及设置值项、显示项");

                        strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember = con{0}.{1};",
                         objPrjTabENEx.TabName, strValueFieldName);
                        strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember = con{0}.{1};",
                         objPrjTabENEx.TabName, strTextFieldName);
                        strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = {0};", strObjLstName);
                        strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_ComboBoxBindFunction()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
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
                    //strCodeForCs.AppendFormat("\r\n" + "public static System.Data.DataTable Get{0}()",
                    //strValueFieldName);
                    //strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
                    //strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
                    //strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    ////						if (objField.DsCondStr.Trim() == "" )
                    ////						{
                    ////							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    ////								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    ////						}
                    ////						else
                    ////						{
                    ////							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    ////								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName, objField.DsCondStr);
                    ////						}
                    ////strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql=new 1clsSpecSQLforSql();");
                    //strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

                    //strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                    //strCodeForCs.Append("\r\n" + "return objDT;");
                    //strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 绑定基于Win的下拉框");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name=\"objComboBox\">需要绑定当前表的下拉框</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//为数据源为表的下拉框设置内容");
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = GetObjLst(\"1=1\");",
                    objPrjTabENEx.TabName);


                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "//初始化一个对象列表");
                    //strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                    //objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                    objPrjTabENEx.TabName);
                    if (bolIsNumber4ValueFieldName)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = 0;",
                        objPrjTabENEx.TabName, strValueFieldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"0\";",
                        objPrjTabENEx.TabName, strValueFieldName);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"选[{2}]...\";",
                        objPrjTabENEx.TabName, strTextFieldName, objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "arrObjLst.Insert(0, obj{0}EN);",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//把DataTable中的所有项均加到对象列表中");

                    strCodeForCs.Append("\r\n" + "//设置下拉框的数据源、以及设置值项、显示项");
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = arrObjLst;",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember=\"{1}\";",
                            objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember=\"{1}\";",
                           objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_DdlBindFunction()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
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

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 绑定基于Web的下拉框");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name=\"objDDL\">需要绑定当前表的下拉框</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");

                    strCodeForCs.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"选[{0}]...\",\"0\");",
                          objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = GetObjLst(\"1=1\");",
                        objPrjTabENEx.TabName);

                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField=\"{1}\";",
                        objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField=\"{1}\";",
                        objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = arrObjLst;");
                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
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

            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据表内容设置enum列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\npublic class enum{0}WA",
                       objPrjTabENEx.TabName,
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n{");

                foreach (DataRow objRow in objDT.Rows)
                {
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// {0}", objRow[strNamedFieldName]);
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public const string {0}_{1} = \"{1}\";",
                        objRow[strEnglishNameFieldName], objRow[strKeyFieldName]);
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\npublic enum enum{0} : {1}",
                objPrjTabENEx.TabName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n{");

                foreach (DataRow objRow in objDT.Rows)
                {
                    strCodeForCs.AppendFormat("\r\n" + "[Description(\"{0}\")]", objRow[strNamedFieldName]);
                    strCodeForCs.AppendFormat("\r\n" + "{0}_{1} = {1},", objRow[strEnglishNameFieldName], objRow[strKeyFieldName]);
                }
            }
            strCodeForCs.Append("\r\n}");

            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
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

            StringBuilder strCodeForCs = new StringBuilder();
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") continue;
                if (objField.FieldTypeId != "07") continue;
                //获取某一条件值的记录集-----------------------------;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// 根据表字段内容设置enum列表-字段名：[{0}]", objField.ObjFieldTabENEx.FldName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\npublic class enum{0}_{1}WS",
                       objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                strCodeForCs.Append("\r\n{");
                List<string> arrExistItem = new List<string>();
                foreach (DataRow objRow in objDT.Rows)
                {
                    string strFieldValue = objRow[objField.ObjFieldTabENEx.FldName].ToString();
                    if (arrExistItem.Contains(strFieldValue)) continue;
                    arrExistItem.Add(strFieldValue);
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// {0}", strFieldValue);
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public const string con{0} = \"{0}\";",
                        strFieldValue);
                }

                strCodeForCs.Append("\r\n}");
            }
            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
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
                Type t = typeof(WA_Access4CSharp);
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

        public void Gen_4WA_Static_SetFieldValue4OneField(clsPrjTabFldENEx objField, StringBuilder strCodeForCs)
        {
            if (objField.FldOpTypeId == "0004") return;//不读不写
            if (objField.FldOpTypeId == "0002") return;//只读不写
            string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
            string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// /// 功能:为对象设置字段值");
            strCodeForCs.Append("\r\n /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要设置字段值的实体对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>", objField.PrivFuncName, objField.ObjFieldTab().Caption);
            strCodeForCs.Append("\r\n /// <param name = \"strComparisonOp\">比较运算符,如果有值,可用于组织条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回对象,可以继续连写</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static cls{0}EN Set{1}(this cls{0}EN obj{0}EN, {2} {3}, string strComparisonOp=\"\")",
            objPrjTabENEx.TabName, objField.FldName, objField.CsType, objField.PrivFuncName);
            strCodeForCs.Append("\r\n	{");
            //objUserStateEN.Memo = strMemo;


            //检查非空
            if (objField.IsTabNullable == false && objField.FieldTypeId != "02")
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                {

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, con{2}.{3});",
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

                strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
         objField.PrivFuncName,
         objField.ObjFieldTabENEx.FldLength,
         objPrjTabENEx.TabName,
         objField.ObjFieldTabENEx.FldName);

            }
            //检查外键
            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
               && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
            {

                strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
           objField.PrivFuncName,
           objField.ObjFieldTabENEx.FldLength,
           objPrjTabENEx.TabName,
           objField.ObjFieldTabENEx.FldName);

            }

            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2}; //{3}",
             objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase), objField.PrivFuncName, objField.ColCaption);
            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(strComparisonOp) == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.dicFldComparisonOp.ContainsKey(con{0}.{1}) == false)",
                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.dicFldComparisonOp.Add(con{0}.{1}, strComparisonOp);",
                objPrjTabENEx.TabName,
                objField.ObjFieldTabENEx.FldName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.dicFldComparisonOp[con{0}.{1}] = strComparisonOp;", objPrjTabENEx.TabName,
                objField.ObjFieldTabENEx.FldName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n	}");


        }

        public string Gen_4WA_Static_SetFieldValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            objPrjTabENEx.arrFldSet.ForEach(obj => Gen_4WA_Static_SetFieldValue4OneField(obj, strCodeForCs));

            return strCodeForCs.ToString();
        }
        public string Gen_4WA_ReFreshThisCache()
        {
            string strFuncName = "ReFreshThisCache";// string.Format($"{thisWA_F(WA_F.GetObjLst_Cache)}");

            var objFuncParaLst = new FuncParaLst("ReFreshThisCache", this.IsFstLcase, enumAppLevel.DefindFunc);
            List<string> arrCondFldId = new List<string>();
            objFuncParaLst.AddParaByCacheClassify(thisCacheClassify, arrCondFldId, enumProgLangType.CSharp_01);

            string strFuncParaLst = objFuncParaLst.GetCondFldLst4Para();
            string strCheckEmptyCode = objFuncParaLst.Gc_CheckVarEmpty_Cs(ThisClsName, strFuncName, true);
            string strFuncParaCode = clsPubFun4GC.GetFuncParaDef4CacheClassfy(this, false, enumProgLangType.CSharp_01);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 刷新本类中的缓存.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + $"public static void ReFreshThisCache({strFuncParaCode})");
      
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + strCheckEmptyCode);
            strCodeForCs.Append("\r\n" + "string strMsg0;");
            strCodeForCs.Append("\r\n" + "if (clsSysParaEN.spSetRefreshCacheOn == true)");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                    objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.AppendFormat("\r\n" + "CacheHelper.Remove(strKey);", objPrjTabENEx.TabName);

            //strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"刷1新缓存成功!({{2}}->{{1}}->{{0}})\",");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3)); ");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strMsg0 = string.Format(\"刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})\",");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3));");
            strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg0);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
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
        public string Gen_4WA_Static_Update()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Update_Static", "修改记录时关键字不能为空!", "生成代码");

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式");
            strCodeForCs.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool Update(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool")
            {
                if (IsNumberType4Key == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + " if (obj{0}EN.{1} == 0)",
                     objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                        objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
                }
                strCodeForCs.Append("\r\n" + " {");

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})修改记录时关键字不能为空!(from {{0}})\\r\\n\",", strErrId);
                strCodeForCs.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strCodeForCs.AppendFormat("\r\n" + "throw new Exception(strMsg); ");
                strCodeForCs.Append("\r\n" + " }");
            }
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.sfUpdFldSetStr = obj{0}EN.getsfUpdFldSetStr();", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.CheckPropertyNew(obj{0}EN); ", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "bool bolResult = cls{0}WApi.UpdateRecord(obj{0}EN);",
            objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "  //引发修改记录的事件");
            //strCodeForCs.Append("\r\n" + "try");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "    onUpdateRecord?.Invoke(obj{0}EN);", TabName);
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "string strMsg2 = string.Format(\"在调用修改记录代理事件时出错。错误：{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strCodeForCs.Append("\r\n" + "throw new Exception(strMsg2);");
            //strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if ( thisCacheClassify.IsForExtendClass == false)
            {
                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache();", objPrjTabENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PropertyName(this.IsFstLcase));
                }
            }
                strCodeForCs.Append("\r\n" + "return bolResult;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Update_Static", "修改记录出错!", "生成代码");

            strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})修改记录出错,{{1}}!(from {{0}})\",", strErrId);
            strCodeForCs.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.AppendFormat("\r\n" + "objException.Message); ");
            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Static_AddNewRecord()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// /// 功能:通过SQL命令来插入记录,该方式是优化方式");
            strCodeForCs.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool AddNewRecord(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03
                && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool"
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "int"
                 && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "long")
            {
                strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                    objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字不能为空!(from {0})\\r\\n\", ");
                strCodeForCs.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strCodeForCs.Append("\r\n throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + " }");

                strCodeForCs.AppendFormat("\r\n" + " if (cls{0}WApi.IsExist({1}) == true)",
                   objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"添加记录时,关键字:[{{0}}]已经存在!(from {{1}})\\r\\n\", obj{0}EN.{1}, ",
                    objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strCodeForCs.Append("\r\n throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + " }");
            }

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}WApi.IsExist({2}) == true)",
                    objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase), strKeyFldName_ObjName);
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}WApi.GetMaxStrId();",
                    objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.Append("\r\n" + " }");
            }
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.CheckPropertyNew(obj{0}EN); ", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "bool bolResult = cls{0}WApi.AddNewRecord(obj{0}EN);",
            objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "  //引发添加新记录的事件");
            //strCodeForCs.Append("\r\n" + "try");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "    onAddNewRecord?.Invoke(obj{0}EN);", TabName);
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "string strMsg2 = string.Format(\"在调用添加记录代理事件时出错。错误：{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strCodeForCs.Append("\r\n" + "throw new Exception(strMsg2);");
            //strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if ( thisCacheClassify.IsForExtendClass == false)
            {
                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache();", objPrjTabENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PropertyName(this.IsFstLcase));
                }
            }
            strCodeForCs.Append("\r\n" + "return bolResult;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecord_Static", "纯静态添加记录出错!", "生成代码");

            strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})添加记录出错, {{1}}.(from {{0}})\",", strErrId);
            strCodeForCs.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.AppendFormat("\r\n" + "objException.Message); ");
            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})添加记录出错!({1}:AddNewRecordBySql2)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"添加记录出错!({1}: AddNewRecordBySQL2)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Static_AddNewRecordWithMaxId()
        {
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式");
            strCodeForCs.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static {1} AddNewRecordWithMaxId(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName, objKeyField.CsType);
            strCodeForCs.Append("\r\n" + "{");



            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.CheckPropertyNew(obj{0}EN); ", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "{1} {2} = cls{0}WApi.AddNewRecordWithMaxId(obj{0}EN);",
            objPrjTabENEx.TabName, objKeyField.CsType, objKeyField.PrivFuncName);
            //strCodeForCs.Append("\r\n" + "  //引发添加新记录的事件");
            //strCodeForCs.Append("\r\n" + "try");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "    onAddNewRecord?.Invoke(obj{0}EN);", TabName);
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "string strMsg2 = string.Format(\"在调用添加记录代理事件时出错。错误：{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strCodeForCs.Append("\r\n" + "throw new Exception(strMsg2);");
            //strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if ( thisCacheClassify.IsForExtendClass == false)
            {
                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache();", objPrjTabENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PropertyName(this.IsFstLcase));
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "return {0};", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordWithMaxId_Static", "纯静态添加记录出错!", "生成代码");

            strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})添加记录出错, {{1}}.(from {{0}})\",", strErrId);
            strCodeForCs.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.AppendFormat("\r\n" + "objException.Message); ");
            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})添加记录出错!({1}:AddNewRecordBySql2)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"添加记录出错!({1}: AddNewRecordBySQL2)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Static_UpdateWithCondition()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录");
            strCodeForCs.Append("\r\n /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">修改记录时的条件</param>");
            strCodeForCs.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool UpdateWithCondition(this cls{0}EN obj{0}EN, string strWhereCond)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.CheckPropertyNew(obj{0}EN); ", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "bool bolResult = cls{0}WApi.UpdateWithCondition(obj{0}EN, strWhereCond);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if ( thisCacheClassify.IsForExtendClass == false)
            {
                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache();", objPrjTabENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PropertyName(this.IsFstLcase));
                }
            }
            strCodeForCs.Append("\r\n" + "return bolResult;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateWithCondition_Static", "根据条件修改记录出错!", "生成代码");

            strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})根据条件修改记录出错, {{1}}.(from {{0}})\\r\\n\",", strErrId);
            strCodeForCs.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.AppendFormat("\r\n" + "objException.Message); ");
            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjLstCache()
        {

            //if (objPrjTabENEx.IsUseCache == false) return string.Format("//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;",
            //                 objKeyField.FldName);
            //if (objPrjTabENEx.IsUseCache_TS() == false) return $"//该表没有使用Cache,不需要生成[GetObjLstCache()]函数;(in {clsStackTrace.GetCurrClassFunction()})";
            string strFuncName = "GetObjLstCache";// string.Format($"{thisWA_F(WA_F.GetObjLst_Cache)}");


            var objFuncParaLst = new FuncParaLst("GetObjLstCache", this.IsFstLcase, enumAppLevel.DefindFunc);
            List<string> arrCondFldId = new List<string>();
            objFuncParaLst.AddParaByCacheClassify(thisCacheClassify, arrCondFldId, enumProgLangType.TypeScript_09);

            string strFuncParaLst = objFuncParaLst.GetCondFldLst4Para();
            string strCheckEmptyCode = objFuncParaLst.Gc_CheckVarEmpty_Cs(ThisClsName, strFuncName, true);

            Tuple<string, string, string> tup = thisWA_FP(WA_F.GetObjLst_Cache, "CSharp");

            string strParaVarLstStr_KeyField = clsPubFun4GC.GetParaVarLstStr4KeyField(this, false, enumProgLangType.CSharp_01);


            string strFuncParaCode = clsPubFun4GC.GetFuncParaDef4CacheClassfy(this, false, enumProgLangType.CSharp_01);

            StringBuilder strCodeForCs = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 从缓存中获取所有对象列表.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <returns>从缓存中获取的所有对象列表</returns>");


            strCodeForCs.Append("\r\n" + $"public static List<cls{objPrjTabENEx.TabName}EN> GetObjLstCache({strFuncParaCode})");



            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + strCheckEmptyCode);
            strCodeForCs.Append("\r\n" + "//初始化列表缓存");
            strCodeForCs.Append("\r\n" + "var strWhereCond = \"1=1\";");

            if (thisCacheClassify.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + $"var strKey = {thisWA_F(WA_F._CurrTabName)};");
            }
            else if (thisCacheClassify.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}._WhereFormat) == false)", ThisClsName4EN);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond =string.Format({0}._WhereFormat, {1});",
                    ThisClsName4EN, thisCacheClassify.PriVarName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                if (thisCacheClassify.IsForExtendClass == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond = string.Format(\"{{0}}='{{1}}'\",con{0}.{1}, {2});", ThisTabName4GC, thisCacheClassify.FldName, thisCacheClassify.PriVarName);
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "var strMsg =$\"分类字段为扩展字段,此时_WhereFormat不能为空!({clsStackTrace.GetCurrFunction()})\";");             
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                }
                strCodeForCs.Append("\r\n" + "}");

                if (thisCacheClassify.IsNumberType == true)
                {
                    strCodeForCs.Append("\r\n" + $"var strKey = string.Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify.PriVarName});");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"var strKey = string.Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify.PriVarName});");
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}._WhereFormat) == false)", ThisClsName4EN);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = string.Format({0}._WhereFormat, {1}, {2});",
                    ThisClsName4EN, thisCacheClassify.PriVarName, thisCacheClassify.PriVarName2);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = string.Format(\"{0}='{{0}}' and {2}='{{1}}'\", {1}, {3});",
                    thisCacheClassify.FldName, thisCacheClassify.PriVarName,
                    thisCacheClassify.FldName2, thisCacheClassify.PriVarName2);
                strCodeForCs.Append("\r\n" + "}");

                if (thisCacheClassify.IsNumberType == true)
                {
                    strCodeForCs.Append("\r\n" + $"var strKey = string.Format(\"{{0}}_{{1}}_{{2}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify.PriVarName}, {thisCacheClassify.PriVarName2});");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"var strKey = string.Format(\"{{0}}_{{1}}_{{2}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify.PriVarName}, {thisCacheClassify.PriVarName2});");
                }
            }

            //strCodeForCs.Append("\r\n" + "InitListCache(); ");

            strCodeForCs.Append("\r\n" + $"List<cls{objPrjTabENEx.TabName}EN> arr{objPrjTabENEx.TabName}ObjLstCache = CacheHelper.GetCache(strKey, () => {{ return GetObjLst(strWhereCond); }});");

            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLstCache;",
                     objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_GetObjLstCacheFromObjLst()
        {

            //if (objPrjTabENEx.IsUseCache == false) return string.Format("//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;",
            //                 objKeyField.FldName);
            //if (objPrjTabENEx.IsUseCache_TS() == false) return $"//该表没有使用Cache,不需要生成[GetObjLstCacheFromObjLst()]函数;(in {clsStackTrace.GetCurrClassFunction()})";
            if (thisCacheClassify.FldName == "") return $"//该表没有缓存分类字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in {clsStackTrace.GetCurrClassFunction()})";
            if (thisCacheClassify.IsForExtendClass == true) return $"//该表缓存分类字段是扩展字段,不需要生成[GetObjLstCacheFromObjLst()]函数;(in {clsStackTrace.GetCurrClassFunction()})";

            string strFuncName = "GetObjLstCacheFromObjLst";// string.Format($"{thisWA_F(WA_F.GetObjLst_Cache)}");


            var objFuncParaLst = new FuncParaLst("GetObjLstCacheFromObjLst", this.IsFstLcase, enumAppLevel.DefindFunc);
            List<string> arrCondFldId = new List<string>();
            objFuncParaLst.AddParaByCacheClassify(thisCacheClassify, arrCondFldId, enumProgLangType.TypeScript_09);

            string strFuncParaLst = objFuncParaLst.GetCondFldLst4Para();
            string strCheckEmptyCode = objFuncParaLst.Gc_CheckVarEmpty_Cs(ThisClsName, strFuncName, true);


            Tuple<string, string, string> tup = thisWA_FP(WA_F.GetObjLst_CacheFromObjLst, "CSharp");

            string strParaVarLstStr_KeyField = clsPubFun4GC.GetParaVarLstStr4KeyField(this, false, enumProgLangType.CSharp_01);

            string strFuncParaCode = clsPubFun4GC.GetFuncParaDef4CacheClassfy(this, false, enumProgLangType.CSharp_01);

            string strFuncParaDef4ObjLst = "";
            //if (strProgLangType == "TypeScript")
            //{
            //    strVariableType = string.Format("Array<cls{0}EN>", ThisTabName4GC);
            //}
            //else
            //{
            strFuncParaDef4ObjLst = string.Format("List<cls{0}EN> arrObjLst_P", ThisTabName4GC);
            if (strFuncParaCode.Length > 5) strFuncParaDef4ObjLst = $",{strFuncParaDef4ObjLst}";
            //}


            StringBuilder strCodeForCs = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <returns>从缓存中获取的所有对象列表</returns>");


            strCodeForCs.Append("\r\n" + $"public static List<cls{objPrjTabENEx.TabName}EN> GetObjLstCacheFromObjLst({strFuncParaCode}{strFuncParaDef4ObjLst})");


            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + strCheckEmptyCode);
            if (thisCacheClassify.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + $"var strKey = {thisWA_F(WA_F._CurrTabName)};");
            }
            else if (thisCacheClassify.IsHasCacheClassfyFld2 == false)
            {
                if (thisCacheClassify.IsNumberType == true)
                {
                    strCodeForCs.Append("\r\n" + $"var strKey = string.Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify.PriVarName});");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"var strKey = string.Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify.PriVarName});");
                }
            }
            else
            {
                if (thisCacheClassify.IsNumberType == true)
                {
                    strCodeForCs.Append("\r\n" + $"var strKey = string.Format(\"{{0}}_{{1}}_{{2}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify.PriVarName}, {thisCacheClassify.PriVarName2});");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"var strKey = string.Format(\"{{0}}_{{1}}_{{2}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify.PriVarName}, {thisCacheClassify.PriVarName2});");
                }
            }


            strCodeForCs.Append("\r\n" + $"List<cls{ThisTabName4GC}EN> arr{ThisTabName4GC}ObjLstCache = null;");
            strCodeForCs.Append("\r\n" + $"if (CacheHelper.Exsits(strKey) == true)");
            strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = CacheHelper.Get<List<cls{ThisTabName4GC}EN>>(strKey);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"var arrObjLst_Sel = arrObjLst_P.Where(x => x.{thisCacheClassify.FldName} == {thisCacheClassify.PriVarName}).ToList();");
                strCodeForCs.Append("\r\n" + $"CacheHelper.Add(strKey, arrObjLst_Sel);");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = CacheHelper.Get<List<cls{ThisTabName4GC}EN>>(strKey);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLstCache;",
                     objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_ReFreshCache()
        {


            string strFuncParaCode = clsPubFun4GC.GetFuncParaDef4CacheClassfy(this, false, enumProgLangType.CSharp_01);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");

            strCodeForCs.Append("\r\n" + $"public static void ReFreshCache({strFuncParaCode})");

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
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WApi.objCommFun4WApi != null) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + " string strMsg = string.Format(\"刷1新缓存成功!({{2}}->{{1}}->{{0}})\",", "{", "}");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3)); ");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");

            strCodeForCs.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                    objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }

            strCodeForCs.AppendFormat("\r\n" + "CacheHelper.Remove(strKey);", objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.objCommFun4WApi.ReFreshCache();",
                objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.objCommFun4WApi.ReFreshCache({1}.ToString());",
             objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Static_GetConditionString4Constraint()
        {
            int intVerCount = 1;
            StringBuilder strCodeForCs = new StringBuilder();
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

                        strCodeForCs.Append("\r\n /// <summary>");
                        strCodeForCs.AppendFormat("\r\n /// 获取唯一性条件串--{0}({1}), 即由对象中唯一性条件字段关键字与值组成的条件串",
                                                  objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        strCodeForCs.Append($"\r\n /// 唯一性条件:{objInFor.ConstraintName4GC()}");
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n /// </summary>");
                        strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">要求唯一的对象</param>",
                               objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        strCodeForCs.Append("\r\n /// <returns></returns>");
                        strCodeForCs.Append($"\r\npublic static string GetUniConditionStr{strVersion}(this cls{ThisTabName4GC}EN obj{ThisTabName4GC}EN)"); strCodeForCs.Append("\r\n{");
                        strCodeForCs.Append("\r\n" + "//检测记录是否存在");

                        //strCodeForCs.Append("\r\n" + "bool bolIsUniqueness;");
                        strCodeForCs.Append("\r\nStringBuilder sbCondition = new StringBuilder();");

                        strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN == null) return \"\";",
                        objPrjTabENEx.TabName);

                        switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "int":
                            case "long":
                            case "short":
                                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0)",
                                objPrjTabENEx.TabName,
                                objKeyField.PropertyName(this.IsFstLcase));
                                break;
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == null || obj{0}EN.{1} == \"\")",
                                objPrjTabENEx.TabName,
                                objKeyField.PropertyName(this.IsFstLcase));
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == null || obj{0}EN.{1} == \"\")",
                                objPrjTabENEx.TabName,
                                objKeyField.PropertyName(this.IsFstLcase));
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "{");


                        strCodeForCs.AppendFormat("\r\nsbCondition.AppendFormat(\"1 = 1\");",
                           objKeyField.FldName,
                           objKeyField.PrivFuncName,
                           "{", "}");

                        foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                        {

                            strCodeForCs.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", obj{1}EN.{2});",
                                        objField.ObjFieldTab().FldName,
                                        objPrjTabENEx.TabName,
                                                objField.ObjFieldTab().PropertyName(this.IsFstLcase));
                        }
                        strCodeForCs.AppendFormat("\r\nreturn sbCondition.ToString();",
                                objPrjTabENEx.TabName);


                        strCodeForCs.Append("\r\n}");

                        //bool bolIsFirst = true;


                        strCodeForCs.Append("\r\n else {");

                        if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
                        {
                            strCodeForCs.AppendFormat("\r\nsbCondition.AppendFormat(\"{0} !=  {{0}}\", obj{1}EN.{2});",
                               objKeyField.FldName,
                               objPrjTabENEx.TabName,
                                                objKeyField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\nsbCondition.AppendFormat(\"{0} !=  '{{0}}'\", obj{1}EN.{2});",
                               objKeyField.FldName,
                               objPrjTabENEx.TabName,
                                                objKeyField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                        }
                        foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                        {

                            strCodeForCs.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", obj{1}EN.{2});",
                                        objField.ObjFieldTab().FldName,
                                        objPrjTabENEx.TabName,
                                                objField.ObjFieldTab().PropertyName(this.IsFstLcase));
                        }
                        strCodeForCs.AppendFormat("\r\n return sbCondition.ToString();",
                                objPrjTabENEx.TabName);
                        strCodeForCs.Append("\r\n}");

                        strCodeForCs.Append("\r\n" + "}");
                        break;

                    case enumConstraintType.MaxMinValue_02:

                        //strCodeForCs.Append("\r\n /// <summary>");
                        //strCodeForCs.AppendFormat("\r\n /// 检查最大最小值(MaxMinValue)--{0}({1}), 如果超过最大值,就返回False; 如果低于最小值,就返回False; ",
                        //  objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        //strCodeForCs.Append("\r\n /// </summary>");
                        //strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">要求限制最大值的对象</param>",
                        //       objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        //strCodeForCs.Append("\r\n /// <returns></returns>");
                        //strCodeForCs.AppendFormat("\r\npublic static bool CheckMaxMinValue_{1}(this cls{0}EN obj{0}EN)",
                        //             objPrjTabENEx.TabName, objInFor.ConstraintName4GC());
                        //strCodeForCs.Append("\r\n{");

                        //strCodeForCs.Append("\r\n" + "bool bolResult;");

                        //strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN == null) return true;",
                        //objPrjTabENEx.TabName);

                        //foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                        //{
                        //    if (string.IsNullOrEmpty(objField.MaxValue) == false)
                        //    {
                        //        strCodeForCs.AppendFormat("\r\n " + "if (obj{1}EN.{0}> {2}) bolResult = false;",
                        //                    objField.ObjFieldTabENEx.FldName,
                        //                    objPrjTabENEx.TabName, objField.MaxValue);
                        //    }
                        //    if (string.IsNullOrEmpty(objField.MinValue) == false)
                        //    {
                        //        strCodeForCs.AppendFormat("\r\n " + "if (obj{1}EN.{0}< {2}) bolResult = false;",
                        //               objField.ObjFieldTabENEx.FldName,
                        //               objPrjTabENEx.TabName, objField.MinValue);
                        //    }

                        //}

                        //strCodeForCs.Append("\r\n" + "return true;");

                        //strCodeForCs.Append("\r\n" + "}");
                        break;


                }
            }

            ///检查类中某属性(非主键)是否唯一 == == == == == == == == = ;
            return strCodeForCs.ToString();
        }


    }
}
