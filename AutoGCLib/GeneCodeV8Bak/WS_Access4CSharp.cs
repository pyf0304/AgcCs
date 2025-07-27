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
    partial class WS_Access4CSharp : clsGeneCodeBase4Tab
    {
       
        #region 构造函数

        public WS_Access4CSharp(string strTabId, string strPrjDataBaseId, string strPrjId)
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


            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "WS";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

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
                strBuilder.Append("\r\n" + "using System.Collections; "); //
                strBuilder.Append("\r\n" + "using com.taishsoft.common;"); //
                strBuilder.Append("\r\n" + "using com.taishsoft.json;"); //

                strBuilder.Append("\r\n" + "using System.ServiceModel;"); //
                strBuilder.AppendFormat("\r\n" + "using {1}4WS.ServiceReference{0};", objPrjTabENEx.TabName, objProject.PrjDomain); //
                strBuilder.Append("\r\n" + "using System.Collections.Generic;"); //

                strBuilder.Append("\r\n" + ""); //
                                                //if (objPrjTabENEx.IsForSilverLight == true)
                                                //{
                                                //    strBuilder.AppendFormat("\r\n" + "namespace {0}_SL4WS",
                                                //    objProject.PrjDomain);
                                                //}
                                                //else
                                                //{
                strBuilder.AppendFormat("\r\n" + "namespace {0}4WS",
                objProject.PrjDomain);
                //}
                strBuilder.Append("\r\n" + "{");
                //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN21 = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4WS_GeneEnumConstList");

                strTemp = A_GeneFuncCodeByFuncName("Gen_4WS_GeneEnumConstList");
                strBuilder.Append(strTemp);
                //objvFunction4GeneCodeEN1 = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4WS_GeneEnumConstList4Field");

                strTemp = A_GeneFuncCodeByFuncName("Gen_4WS_GeneEnumConstList4Field");
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

                strBuilder.AppendFormat("\r\n" + "private static string mstrPageName = \"{0}Service.asmx\";",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "private static string mstrDir = \"0\";");

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
                strBuilder.AppendFormat("\r\n" + "private static {0}ServiceSoapClient obj{0}ServiceSoapClient = null;",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <returns></returns>");
                strBuilder.AppendFormat("\r\n" + "public static {0}ServiceSoapClient Get{0}ServiceSoapClient()",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "if (obj{0}ServiceSoapClient == null)",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "BasicHttpBinding binding = new BasicHttpBinding();");
                strBuilder.AppendFormat("\r\n" + "binding.Name = \"{0}ServiceSoap\";",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "binding.CloseTimeout = new System.TimeSpan(6000);");
                strBuilder.Append("\r\n" + "binding.MaxReceivedMessageSize = 2147483647;");
                //                strBuilder.Append("\r\n" + "String strServiceUrl = String.Empty;");
                strBuilder.Append("\r\n" + "string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);");
                //strBuilder.Append("\r\n" + "if (clsSysPara4WS.bolIsLocalHost == false)");
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{{1}}/{2}Service.asmx\", clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx);",
                //"{", "}", objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "}");
                //strBuilder.Append("\r\n" + "else");
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{2}Service.asmx\", clsSysPara4WS.strCurrIPAddressAndPort_Local);",
                //"{", "}", objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "}");

                strBuilder.Append("\r\n" + "EndpointAddress address = new EndpointAddress(strServiceUrl);");

                strBuilder.AppendFormat("\r\n" + "return new {0}ServiceSoapClient(binding, address);",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "return obj{0}ServiceSoapClient;",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "}");
                //生成所有的函数

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN1 = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

                    string strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }

                strBuilder.Append("\r\n" + "}");
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
                //    string strFindFileFullFile = clsFile.FindFileFromFolder(objPrjTabENEx.FolderName_Root, strSimpleFileName);
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

        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public string A_GenWebServiceTransCode_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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


            objWebSrvClassENEx.ClsName = string.Format("{0}WS", objWebSrvClassENEx.ClsName);
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

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
                                                //    strBuilder.AppendFormat("\r\n" + "namespace {0}_SL4WS",
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


                strBuilder.AppendFormat("\r\n" + "private static string mstrPageName = \"{0}\";",
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
                strBuilder.Append("\r\n" + "string strServiceUrl = GetServiceUrl(mstrPageName, ref mstrDir);");
                //strBuilder.Append("\r\n" + "if (clsSysPara4WS.bolIsLocalHost == false)");
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{{1}}/{2}Service.asmx\", clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx);",
                //"{", "}", objWebSrvClassENEx.TabName);
                //strBuilder.Append("\r\n" + "}");
                //strBuilder.Append("\r\n" + "else");
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{2}Service.asmx\", clsSysPara4WS.strCurrIPAddressAndPort_Local);",
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
                        strTemp = Gen_4Ws_ByCommonFunction(objWebSrvFunctionsENEx);
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

                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4Ws_GetServiceUrl");
              
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
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }



        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
              string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WS_Access4CSharp);
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


        public string Gen_4Ws_ClassConstructor1()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///类构造器----------------------------------------------;
            strBuilder.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }




        /// <summary>");
        /// 根据条件获取数据表,用DataTable表示");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">表对象</param>");
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public string Gen_4Ws_GetDataTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取数据表,用DataTable表示");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回满足条件一定范围的DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableWs(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.{0}GetDataSet(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}GetDataSet\", \"{1}:GetDataTableWs\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 数1据出错!\\r\\n({1}:GetDataTableWs)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>;
        /// 根据函数对象,生成相关的服务转换层函数;
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">表对象</param>;
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public string Gen_4Ws_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
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
                strBuilder.AppendFormat("\r\n" + "public static {0} {1}Ws({2})",
                        objSelfDefDataTypeEN.CsType, objWebSrvFunctionsENEx.FunctionName,
                        sbParaList.ToString());
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "public static {0} {1}Ws({2})",
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
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}\", \"{1}:{0}Ws\", objException.Message);",
                      objWebSrvFunctionsENEx.FunctionName, objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objWebSrvClassENEx.ClsName, objWebSrvClassENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 数1据出错!\\r\\n({1}:GetDataTableWs)\" + objException.Message);",
            //objWebSrvClassENEx.TabName, objWebSrvClassENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>");
        /// 根据条件获取数据表,用DataTable表示");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">表对象</param>");
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public string Gen_4Ws_GetTopDataTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取数据表,用DataTable表示");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回满足条件一定范围的DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_TopWs(int intTopSize, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.{0}GetTopDataSet(intTopSize, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}GetTopDataSet\", \"{1}:GetDataTable_TopWs\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
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
        public string Gen_4Ws_GetDataTableByRange()
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
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByRangeWs(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.{0}GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}GetDataSetByRange\", \"{1}:GetDataTableByRangeWs\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 数1据出错!\\r\\n({1}:GetDataTableByRangeWs)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 获取表View的DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetDataTableV()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableVWs(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.{0}GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}GetDataSetV\", \"{1}:GetDataTableVWs\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} View 数1据出错!\\r\\n({1}:GetDataTableVWs)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>");
        /// 根据条件获取一定范围的数据表,用DataTable表示");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">表对象</param>");
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public string Gen_4Ws_GetDataTableVByRange()
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
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableVByRangeWs(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.{0}GetDataSetVByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}GetDataSetVByRange\", \"{1}:GetDataTableVByRangeWs\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 数1据出错!\\r\\n({1}:GetDataTableVByRangeWs)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 获取表View的DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetDataTableV2()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.AppendFormat("\r\n" + "public static DataTable Get{0}VWs(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.{0}GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}GetDataSetV\", \"{1}:GetDataTableVWs\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            //strBuilder.AppendFormat("\r\n" + "throw new Exception (\"获取表View数1据出错!\\r\\n({1}:Get{0}VWs)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>");
        /// 根据条件获取一定范围的数据表,用DataTable表示");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">表对象</param>");
        /// <returns>返回满足条件一定范围的DataTable</returns>
        public string Gen_4Ws_GetDataTableV2ByRange()
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
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableVByRangeWs(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.{0}GetDataSetVByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}GetDataSetVByRange\", \"{1}:GetDataTableVByRangeWs\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"获取表:{0} 数1据出错!\\r\\n({1}:GetDataTableVByRangeWs)\" + objException.Message);",
            //objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        public string Gen_4Ws_GetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLst(string strWhereCond)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n List<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTableWs(strWhereCond);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull4WS(objField) + "; //{2}",
                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.Caption);
            }
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }


        public string Gen_4Ws_GetServiceUrl()
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
            strBuilder.Append("\r\n" + "if (clsSysPara4WS.bolIsLocalHost == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}/{2}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx, strPageName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}/{2}/{3}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx, strDir, strPageName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WS.strCurrIPAddressAndPort_Local,");
            strBuilder.Append("\r\n" + "strPageName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}/{2}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WS.strCurrIPAddressAndPort_Local, strDir, strPageName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return strServiceUrl;");
            strBuilder.Append("\r\n" + "}");

            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public string Gen_4Ws_GetServiceUrl_SelfDefWS()
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
            strBuilder.Append("\r\n" + "if (clsSysPara4WS.bolIsLocalHost == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}/{2}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx, strPageName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}/{2}/{3}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WS.strCurrIPAddressAndPort, clsSysPara4WS.strCurrPrx, strDir, strPageName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WS.strCurrIPAddressAndPort_Local,");
            strBuilder.Append("\r\n" + "strPageName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}/{2}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WS.strCurrIPAddressAndPort_Local, strDir, strPageName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return strServiceUrl;");
            strBuilder.Append("\r\n" + "}");

            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }


        public string Gen_4Ws_GetObjLstByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取范围内的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">最小记录号</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">最大记录号</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.Append("\r\n /// <returns>返回范围内的对象列表</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n List<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nstring strSQL; ");
            strBuilder.Append("\r\nSystem.Data.DataTable objDT; ");

            //strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");
            //strBuilder.Append("\r\n //获取连接对象");
            //strBuilder.AppendFormat("\r\n objSQL = cls{0}.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strWhereCond;");
            //strBuilder.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strBuilder.AppendFormat("\r\n objDT = GetDataTableByRangeWs(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\nif (objDT.Rows.Count == 0)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull4WS(objField) + "; //{2}",
                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.Caption);
            }
            strBuilder.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");
            

            strBuilder.Append("\r\nreturn arrObjLst;");
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// 获取表对象的所有属性
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetRecordProperty4Object()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据对象的关键字值,获取对象的全部属性");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">相关对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "/// <returns>是否成功</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool Get{0}Ws(ref cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}Service.{0}Get{0}(ref obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 获取表对象的所有属性
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetObjByKeyId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 获取当前关键字的记录对象,用对象的形式表示.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">表关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>表对象</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}Ws({2})",
            objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "{0} = {0}.Replace(\"'\", \"\");", objKeyField.PrivFuncName);
                strBuilder.AppendFormat("\r\n" + "{0} = {0}.Replace(\" \", \"\");", objKeyField.PrivFuncName);
                strBuilder.AppendFormat("\r\n" + "{0} = {0}.Replace(\"(\", \"\");", objKeyField.PrivFuncName);
                strBuilder.AppendFormat("\r\n" + "{0} = {0}.Replace(\")\", \"\");", objKeyField.PrivFuncName);
            }
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = obj{0}Service.{0}GetObjBy{2}({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName, objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 删除单条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_DelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字删除记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>实际删除记录的个数</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int DelRecordWs({1} {0})",
            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int intResult = obj{0}Service.{0}_DelRecord({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "return intResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}_DelRecord\", \"{1}:DelRecordWs\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            //strBuilder.Append("\r\n" + "throw new Exception(\"删1除记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_DelMultiRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字列表删除记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>实际删除记录的个数</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int Del{0}sWs(List<string> arr{1})",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst<string>(arr{0});", objKeyField.FldName);

            //int intResult = objExamTypeService.ExamType_DelExamTypes(strJSON);

            //strBuilder.AppendFormat("\r\n" + "string[] s{0} = (string[])(arr{1}.ToArray());",
            //objKeyField.PrivFuncName, objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "int intResult = obj{0}Service.{0}_Del{0}s(strJSON);",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "return intResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}_Del{0}s\", \"{1}:Del{0}sWs\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            //strBuilder.Append("\r\n" + "throw new Exception(\"删1除记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_DelMultiRecordByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件删除记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>实际删除记录的个数</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int Del{0}sByCondWs(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = obj{0}Service.{0}_Del{0}sByCond(strWhereCond);",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}_Del{0}sByCond\", \"{1}:Del{0}sByCondWs\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            //strBuilder.Append("\r\n" + "throw new Exception(\"删1除记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4Ws_AddNewRecordBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>是否成功?</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewRecordBySql2Ws(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}Service.{0}_AddNewRecordBySql2(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}_AddNewRecordBySql2\", \"{1}:AddNewRecordBySql2Ws\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            //strBuilder.Append("\r\n" + "throw new Exception(\"添1加记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4Ws_UpdateBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 修改记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>是否成功?</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySql2Ws(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}Service.{0}_UpdateBySql2(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}_UpdateBySql2\", \"{1}:UpdateBySql2Ws\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            //strBuilder.Append("\r\n" + "throw new Exception(\"添1加记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4Ws_IsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件判断是否存在记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>是否存在?存在返回True</returns>");
            strBuilder.Append("\r\n" + "public static bool IsExistRecordWs(string strWhereCond)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//检测记录是否存在");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = obj{0}Service.{0}_IsExistRecord(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4Ws_GetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相关记录数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>记录数</returns>");
            strBuilder.Append("\r\n" + "public static int GetRecCountByCondWs(string strWhereCond)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//检测记录是否存在");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "int intRecCount = obj{0}Service.{0}GetRecCountByCond(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return intRecCount;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4Ws_IsExist()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字判断是否存在记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>是否存在?存在返回True</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool IsExistWs({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//检测记录是否存在");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = obj{0}Service.{0}_IsExist({1});",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_4Ws_GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");
                strBuilder.AppendFormat("\r\n" + "public static string GetMaxStrIdWs()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "//检测记录是否存在");
                strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n" + "string strMax{1} = obj{0}Service.{0}GetMaxStrId();",
                objPrjTabENEx.TabName, objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "return strMax{0};",
                objKeyField.FldName_FstUcase);
                strBuilder.Append("\r\n" + "}");
            }
            return strBuilder.ToString();
        }
        public string Gen_4Ws_GetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");
                strBuilder.AppendFormat("\r\n" + "public static string GetMaxStrIdByPrefixWs(string strPrefix)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "//检测记录是否存在");
                strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
                objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n" + "string strMax{1} = obj{0}Service.{0}GetMaxStrIdByPrefix(strPrefix);",
                objPrjTabENEx.TabName, objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "return strMax{0};",
                objKeyField.FldName_FstUcase);
                strBuilder.Append("\r\n" + "}");
            }
            return strBuilder.ToString();
        }

        /// <summary>
        /// 序列化一个对象到Xml串
        /// </summary>
        /// <returns></returns>
        public string Gen_Ws_SerializeObjToXMLStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 序列化一个对象到Xml串");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", objPrjTabENEx.CurrDate);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">需要序列化的对象关键字</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>返回一个<cls{0}EN>对象XML串</returns>",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public string {2}_SerializeObjToXMLStr({0} {1})",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
            {
                strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0}.ToString());", objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0});", objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            }
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n" + "string strXmlString = \"\";");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(\"XML输出文件:\" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));");
            strBuilder.AppendFormat("\r\n" + "cls{0}BL.Get{0}(ref obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strXmlString = cls{0}BL.SerializeObjToXMLStr(obj{0}EN);",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS(objException, \"{0}Service\"); ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return strXmlString;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        /// <summary>
        /// 序列化一个对象列表到Xml串
        /// </summary>
        /// <returns></returns>
        public string Gen_Ws_SerializeObjLstToXMLStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 序列化一个对象列表到Xml串");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", objPrjTabENEx.CurrDate);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">需要序列化的对象列表的条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回一个<cls{0}EN>对象列表XML串</returns>",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public string {0}_SerializeObjLstToXMLStr(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n" + "string strXmlString = \"\";");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> lst{0}ObjLst = cls{0}BL.GetObjLst(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(\"XML输出文件:\" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));");
            strBuilder.AppendFormat("\r\n" + "strXmlString = cls{0}BL.SerializeObjLstToXMLStr(lst{0}ObjLst);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(objException.Message);");
            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS(objException, \"{0}Service\");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return strXmlString;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 序列化一个对象列表到Xml串
        /// </summary>
        /// <returns></returns>
        public string Gen_Ws_SerializeTopObjLstToXMLStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 序列化一个对象列表到Xml串");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", objPrjTabENEx.CurrDate);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">需要序列化的对象列表的条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回一个<cls{0}EN>对象列表XML串</returns>",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public string {0}_SerializeTopObjLstToXMLStr(int intTopSize, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n" + "string strXmlString = \"\";");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> lst{0}ObjLst = cls{0}BL.GetTopObjLst(intTopSize, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(\"XML输出文件:\" + clsSysParaEN.strTempXMLFileName + clsDateTime.getTodayDateTimeStr(0));");
            strBuilder.AppendFormat("\r\n" + "strXmlString = cls{0}BL.SerializeObjLstToXMLStr(lst{0}ObjLst);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(objException.Message);");
            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS(objException, \"{0}Service\");",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return strXmlString;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成代码:提供条件,查询关键字,结果有多个关键字,获取其中的第一个,返回类型是根据字段本身的类型
        /// </summary>
        /// <returns></returns>
        public string Gen_GetFirstID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的第一条记录的关键字值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\npublic {0} {1}GetFirstID_S(string strWhereCond) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n {0} {1};",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n {0} = cls{1}BL.GetFirstID_S(strWhereCond);",
            objKeyField.PrivFuncName, objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return {0};", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"获取First关键字出错!\\r\\n\" + objException.Message;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }

        public string Gen_4WS_CheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic void CheckPropertyNew(cls{0}EN obj{0}EN)",
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
            //strBuilder.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            ///检查类中属性是否正确 == == ;
            return strBuilder.ToString();
        }
        
        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetFirstID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的第一条记录的关键字值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");
            strBuilder.AppendFormat("\r\n" + "public static {0} GetFirstID_S(string strWhereCond)",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{3} {2} = obj{0}Service.{0}GetFirstID_S(strWhereCond);",
                  objPrjTabENEx.TabName,
                  objKeyField.PrivFuncName,
                  objKeyField.PrivFuncName,
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType
                 );
            strBuilder.AppendFormat("\r\n" + "return {0};", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}GetFirstID_S\", \"{1}:GetFirstID_S\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            //strBuilder.Append("\r\n" + "throw new Exception(\"删1除记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetFirstObject_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的第一条记录的对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{1}EN GetFirst{1}_S(string strWhereCond)",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = obj{0}Service.{0}GetFirstObj_S(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}GetFirstObj_S\", \"{1}:GetFirstObj_S\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            //strBuilder.Append("\r\n" + "throw new Exception(\"获1取First记录对象出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        /// <summary>
        /// 添加记录,并且返回关键字
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_AddNewRecordBySql2WithReturnKey()
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
            strBuilder.AppendFormat("\r\n" + "public static string AddNewRecordBySql2WithReturnKey(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strKey = obj{0}Service.{0}_AddNewRecordBySql2WithReturnKey(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return strKey;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}_AddNewRecordBySql2WithReturnKey\", \"{1}:AddNewRecordBySql2WithReturnKey\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            //strBuilder.Append("\r\n" + "throw new Exception(\"添1加记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_4WS_GeneEnumConstList()
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
                strBuilder.AppendFormat("\r\npublic class enum{0}WS",
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
                    strBuilder.AppendFormat("\r\n" + "{0} = {1},", objRow[strEnglishNameFieldName], objRow[strKeyFieldName]);
                }
            }
            strBuilder.Append("\r\n}");

            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public string Gen_4WS_GeneEnumConstList4Field()
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
        /// <summary>
        /// 添加记录,并且返回关键字
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_UpdateBySqlWithCondition()
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
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateBySqlWithCondition(cls{0}EN obj{0}EN, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}Service.{0}_UpdateBySqlWithCondition(obj{0}EN, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n string strMsg = string.Format(\"执行WebSrv功能出错。文件地址:{{0}},函数名:{{1}}. 调用函数名:{{2}}.\", ", "{", "}");
            strBuilder.AppendFormat("\r\n      GetServiceUrl(mstrPageName, ref mstrDir), \"{0}_UpdateBySqlWithCondition\", \"{1}:UpdateBySqlWithCondition\", objException.Message);",
                      objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n strMsg += string.Format(\"出错信息:{{0}}\",", "{", "}");
            strBuilder.AppendFormat("\r\n      objException.Message);", objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            //strBuilder.Append("\r\n" + "throw new Exception(\"修1改记录出错!\\r\\n\" + objException.Message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetRecNameByKeyCache()
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
        public string Gen_4Ws_InitListCache()
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
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = cls{0}WS.GetObjLst(strWhereCond);",
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
        public string Gen_4Ws_GetObjByKeyCache()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据关键字获取相关对象, 从缓存的对象列表中获取.");
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
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
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
            //strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "}");
            //clsSysParaEN_Local.strVersion
            strBuilder.Append("\r\n" + "intFindFailCount++;");
            strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (intFindFailCount == 1) return GetObjBy{1}Cache({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);

            strBuilder.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"在{2}对象缓存列表中,找不到记录[{3} = {{0}}][intFindFailCount = {{1}}](函数:{{2}})\", {4}, intFindFailCount, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName);

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
                objKeyField.FldName);
            //strBuilder.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            //strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strErrMsgForGetObjById);");

            //strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// 把表中内容绑定到ListView。
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_BindListView()
        {
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
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }


        public string Gen_4Ws_ComboBoxBindFunction()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";

            try
            {
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.FldName;
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
                    strBuilder.AppendFormat("\r\n" + "//初始化一个对象列表");
                    strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = GetObjLst(\"1 = 1\");",
                    objPrjTabENEx.TabName);

                    strBuilder.Append("\r\n" + "//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。");
                    strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                    objPrjTabENEx.TabName);
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"0\";",
                    objPrjTabENEx.TabName, strValueFieldName);

                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"选[{2}]...\";",
                        objPrjTabENEx.TabName, strTextFieldName, objPrjTabENEx.TabCnName);

                    strBuilder.AppendFormat("\r\n" + "arrObjLst.Insert(0, obj{0}EN);",
                    objPrjTabENEx.TabName);

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
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }
        public string Gen_4Ws_DdlBindFunction()
        {
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
                        strValueFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    //					strBuilder.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}()", 
                    //						strValueFieldName);
                    //					strBuilder.Append("\r\n" + "{");
                    //					strBuilder.Append("\r\n" + "//获取某学院所有专业信息");
                    //					strBuilder.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //						strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //					//									if (objViewCtlField.DsCondStr.Trim() == "" )
                    //					//									{
                    //					//										strBuilder.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //					//											strValueFieldName, strTextFieldName, objViewCtlField.DsTabName);
                    //					//									}
                    //					//									else
                    //					//									{
                    //					//										strBuilder.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    //					//											strValueFieldName, strTextFieldName, objViewCtlField.DsTabName, objViewCtlField.DsCondStr);
                    //					//									}
                    //					strBuilder.Append("\r\n" + "clsSpecSQLforSql mySql=new 1clsSpecSQLforSql();");
                    //					strBuilder.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                    //					strBuilder.Append("\r\n" + "return objDT;");
                    //					strBuilder.Append("\r\n" + "}");
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
                    strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = GetObjLst(\"1 = 1\");",
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
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
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

        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        //public string A_GenCode4Function_Java(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
        //    string strTemp; //临时变量;
        //    string strFuncName = "";
        //    try
        //    {
        //        //类名开始
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_Java(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}

        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        //public string A_GenCode4Function_JavaScript(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
        //    string strTemp; //临时变量;
        //    string strFuncName = "";
        //    try
        //    {
        //        //类名开始
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_JavaScript(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}


        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        //public string A_GenCode4Function_SilverLight(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
        //    string strTemp; //临时变量;
        //    string strFuncName = "";
        //    try
        //    {
        //        //类名开始
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_SilverLight(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}

        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        //public string A_GenCode4Function_Swift(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
        //    string strTemp; //临时变量;
        //    string strFuncName = "";
        //    try
        //    {
        //        //类名开始
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}
        public override void GetClsName()
        {
            this.ClsName = string.Format("cls{0}WS", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
        public string A_GeneFuncCodeByFuncName(string strFuncName)
        {
            //string strFuncName = objvFunction4GeneCodeEN.FuncName;
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBLEx.GetObjByFuncNameCache(strFuncName);
            try
            {
                string strCode = "";
                Type t = typeof(WS_Access4CSharp);
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
    }
}
