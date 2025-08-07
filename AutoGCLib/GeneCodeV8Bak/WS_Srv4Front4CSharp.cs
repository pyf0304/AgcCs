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
using System.Linq;

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
    partial class WS_Srv4Front4CSharp : clsGeneCodeBase4Tab
    {
        private string strKeyFldName_ObjName = "";

        #region 构造函数

        public WS_Srv4Front4CSharp(string strTabId,  string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        #endregion
            
     
        /// <summary>
        /// 生成Web服务层前台代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
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
            //string strTemp; ///临时变量;

            //arrFuncList.Add("ExposeLogicExClass");

            objPrjTabENEx.ClsName = string.Format("{0}Service", objPrjTabENEx.TabName);
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".asmx";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".asmx";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //

            try
            {
                //类名开始


                strBuilder.AppendFormat("\r\n" + "<%@ WebService Language=\"C#\" CodeBehind=\"{0}Service.asmx.cs\" Class=\"{1}.WebSrv.{0}Service\" %>",
                    objPrjTabENEx.TabName,
                    objProject.PrjDomain); //
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

        public string gfunConnectString()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串;
            strBuilder.Append("\r\n//用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串");
            strBuilder.Append("\r\nprivate static string m_strConnectString;");

            strBuilder.Append("\r\npublic static string ConnectString");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget { return m_strConnectString; }");
            strBuilder.Append("\r\nset { m_strConnectString = value; }");
            strBuilder.Append("\r\n}");

            return strBuilder.ToString();
        }

        public string gfunpErrNo()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///属性过程;
            ///每个表类都应该有的错误代码类;
            strBuilder.Append("\r\npublic int ErrNo");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n get");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n return mintErrNo;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n set");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n mintErrNo = value;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string gfunDispErrMsg()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///每个表类都应该有的对外显示的错误信息;
            strBuilder.Append("\r\npublic string DispErrMsg //对外显示的错误信息");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n get");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n return objPrjTabENEx.DispErrMsg;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n set");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objPrjTabENEx.DispErrMsg = value;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }

        public string Gen_GetDataSet()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetDataSet(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSet(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_GetTopDataSet()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetTopDataSet(int intTopSize, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSet_Top(intTopSize, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetDataSetByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "[\"strOrderBy\"] = strOrderBy, ");
            strBuilder.AppendFormat("\r\n" + "[\"intMinNum\"] = intMinNum.ToString(),", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "[\"intMaxNum\"] = intMaxNum.ToString()", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_GetDataSetV()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取当前表视图的数据集,用DataSet表示");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回当前表视图的数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetDataSetV(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetDataSetVByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 根据条件获取数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strBuilder.AppendFormat("\r\n /// <returns>返回数据集,用DataSet表示</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetDataSetVByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "[\"strOrderBy\"] = strOrderBy, ");
            strBuilder.AppendFormat("\r\n" + "[\"intMinNum\"] = intMinNum.ToString(),", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "[\"intMaxNum\"] = intMaxNum.ToString()", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

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
        public string Gen_GetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public List<cls{0}EN> {0}GetObjLst(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLst(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 获取记录属性
        /// </summary>
        /// <returns></returns>
        public string Gen_GetTopObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <returns>返回对象列表</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public List<cls{0}EN> {0}GetTopObjLst(int intTopSize, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetTopObjLst(intTopSize, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:获取某一条件的记录数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>某一条件的记录数</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public int {0}GetRecCountByCond(string strWhereCond)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "int intCount = cls{0}BL.GetRecCountByCond(strWhereCond);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return intCount;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");
                strBuilder.Append("\r\n" + "[WebMethod]");
                strBuilder.AppendFormat("\r\n" + "public string {0}GetMaxStrId()",
                        objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
                strBuilder.Append("\r\n" + "{");

                strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
                strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
                //  strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

                strBuilder.AppendFormat("\r\n" + "string strMax{1} = cls{0}BL.GetMaxStrId_S();",
                        objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr, objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "return strMax{0};",
                        objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strBuilder.Append("\r\n" + "}");
            }
            return strBuilder.ToString();
        }

        public string Gen_GetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <returns>当前表关键字值的最大值,再加1</returns>");
                strBuilder.Append("\r\n" + "[WebMethod]");
                strBuilder.AppendFormat("\r\n" + "public string {0}GetMaxStrIdByPrefix(string strPrefix)",
                        objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
                strBuilder.Append("\r\n" + "{");

                strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
                strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
                //  strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

                strBuilder.AppendFormat("\r\n" + "string strMax{1} = cls{0}BL.GetMaxStrIdByPrefix_S(strPrefix);",
                        objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr, objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "return strMax{0};",
                        objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strBuilder.Append("\r\n" + "}");
            }
            return strBuilder.ToString();
        }


        public string Gen_AddNewRecordBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 通过对象来添加记录对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">JSON对象字符串</param>",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>是否成功</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_AddNewRecordBySql2(cls{0}EN obj{0}EN)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WS.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileName为空,请检查!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");


            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"obj{0}EN\", cls{0}BL.SerializeObjToXMLStr(obj{0}EN));", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " }");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.AddNewRecord();",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_AddNewRecordBySql2ByJSON()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 通过JSON对象来添加记录对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}JSONObj\">JSON对象字符串</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>是否成功</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_AddNewRecordBySql2ByJSON(string str{0}JSONObj)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = clsJSON.GetObjFromJson<cls{0}EN>(str{0}JSONObj);",
                   objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjFromSimObj(obj{0}EN_Sim);",
            //        objPrjTabENEx.TabName);
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.AddNewRecord();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"通过JSON对象来添加记录对象出错!({0}Service:{0}_AddNewRecordBySql2ByJSON)\\r\\n\" + objException.Message;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_AddNewRecordBySql_XML()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来插入记录,数据来源为代表实体对象的XML串");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、使用XML串来源来插入");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}ObjXml\">代表实体对象的XML串</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_AddNewRecordBySql_XML(string str{0}ObjXml)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}ObjXml\", str{0}ObjXml);",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.AddNewRecordBySql_XML(str{0}ObjXml);",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_UpdateBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 通过对象来修改记录对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}JSONObj\">JSON对象字符串</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>是否成功</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_UpdateBySql2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WS.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileName为空,请检查!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");



            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"obj{0}EN\", cls{0}BL.SerializeObjToXMLStr(obj{0}EN));",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " }");


            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.Update();",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_UpdateBySql2ByJSON()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 通过JSON对象来修改记录对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}JSONObj\">JSON对象字符串</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>是否成功</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_UpdateBySql2ByJSON(string str{0}JSONObj)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);",
                      objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = clsJSON.GetObjFromJson<cls{0}EN>(str{0}JSONObj);",
                    objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjFromSimObj4Upd(obj{0}EN_Sim);",
            //        objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "cls{0}BL.SetUpdFlag(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.Update();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"通过JSON对象来修改记录对象出错!({0}Service:{0}_UpdateBySql2ByJSON)\\r\\n\" + objException.Message;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_UpdateBySql_XML()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式提供XML串来代表实体对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}ObjXml\">需要修改的对象,用XML来表示</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_UpdateBySql_XML(string str{0}ObjXml)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}ObjXml\", str{0}ObjXml);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.UpdateBySql_XML(str{0}ObjXml);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_DelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除关键字所指定的记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>返回删除的记录数</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public int {0}_DelRecord({1})",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
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

            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.DelRecord({1});",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_DelRecordBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_DelRecordBySP({1})",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0});",
                      objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.DelRecordBySP({1});",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_DelMultiRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:同时删除多条记录,删除给定关键字列表的记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}Lst\">给定的关键字值列表</param>", objKeyField.FldName);
            strBuilder.Append("\r\n /// <returns>返回删除的记录数</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public int {0}_Del{0}s(string strJSON4Keys)",
                 objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<string> arr{0} = clsJSON.GetObjLstFromJson<string>(strJSON4Keys);",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arr{0}, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.Del{0}s(arr{1});",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_DelMultiRecordByJSON()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:同时删除多条记录,删除给定关键字列表的记录, 通过JSON串");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strKeyIdLst\">给定的关键字值列表的JSON串</param>", objKeyField.FldName);
            strBuilder.Append("\r\n /// <returns>返回删除的记录数</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public int DelRecordsByJSON(string strKeyIdLst)",
                 objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"strKeyIdLst\", strKeyIdLst);",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.AppendFormat("\r\n" + "string[] sstr{0} = strKeyIdLst.Trim().Split(',');",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "List <string> arr{0} = new();",
                objKeyField.FldName);

            strBuilder.AppendFormat("\r\n" + "foreach (string {0} in sstr{1})",
                objKeyField.PrivFuncName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == false)",
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}.Add({1});",
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.Del{0}s(arr{1});",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_DelMultiRecordByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 功能:删除满足条件的多条记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">需要删除的记录条件</param>");
            strBuilder.Append("\r\n /// <returns>返回删除的记录数。</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public int {0}_Del{0}sByCond(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.Del{0}sByCond(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_ExposeLogicClass()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public cls{0}EN ExposeLogicClass(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{ ");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WS.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileName为空,请检查!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"obj{0}EN\", cls{0}BL.SerializeObjToXMLStr(obj{0}EN));", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n" + " }");

            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_ExposeLogicExClass()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public cls{0}Ex ExposeLogicExClass(cls{0}Ex obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WS.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileName为空,请检查!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WS.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileName为空,请检查!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"obj{0}EN\", cls{0}BL.SerializeObjToXMLStr(obj{0}EN));", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " }");


            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "} ");
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

 
        public string gfunDispose()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///类中析构函数---------------------------------------;
            strBuilder.Append("\r\n public void Dispose()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (mblnDisposed == false)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n //Free up the database connection resource by ");
            strBuilder.Append("\r\n //calling its Dispose method");
            strBuilder.Append("\r\n //mobjConnection.Dispose()");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n //Because this Dispose method has done the necessary cleanup,");
            strBuilder.Append("\r\n //prevent the Finalize method from being called.");
            strBuilder.Append("\r\n GC.SuppressFinalize(this);");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n //Let our class know that Dispose() has been called");
            strBuilder.Append("\r\n mblnDisposed = true;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            ///类中析构函数 == = ;
            return strBuilder.ToString();
        }
        public string gfunLogError()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///获取字符串长度,其中汉字为2个字节,英文为1个字节 = ;
            ///错误日志;
            strBuilder.Append("\r\nprotected void LogError" + "(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n //Log the error information to the Application Log");
            strBuilder.Append("\r\n string strLogMsg ;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n strLogMsg = \"An error occurred in the following module: \"");
            strBuilder.Append("\r\n+ mstrModuleName + \"Source: \" + objException.Source \r\n");
            strBuilder.Append("\r\n+ \"Message: \" + objException.Message ");
            strBuilder.Append("\r\n+ \"Stack Trace: \" + objException.StackTrace \r\n");
            strBuilder.Append("\r\n+ \"Target Site: \" + objException.TargetSite.ToString();");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n //Write error to event log");
            strBuilder.Append("\r\nSystem.Diagnostics.EventLog.WriteEntry(mstrModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
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

        /// <summary>
        /// 生成代码:提供条件,查询相关记录对象,结果有多个对象,获取其中的第一个,返回类型是类类型
        /// </summary>
        /// <returns></returns>
        public string Gen_GetFirstObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的第一条记录的对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的第一条记录的对象</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\npublic cls{0}EN {0}GetFirstObj_S(string strWhereCond) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = cls{0}BL.GetFirstObj_S(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"获取First记录对象出错!\\r\\n\" + objException.Message;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strBuilder.ToString();
        }

   

        /// <summary>
        /// 生成代码:获取当前表满足条件的第一条记录的JSON对象
        /// </summary>
        /// <returns></returns>
        public string Gen_GetFirstJSONObj()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表满足条件的第一条记录的JSON对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strBuilder.Append("\r\n /// <returns>返回的第一条记录的JSON对象</returns>");
            strBuilder.Append("\r\n [WebMethod]");
            strBuilder.AppendFormat("\r\n public string GetFirstJSONObj(string strWhereCond)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = null;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n obj{0}EN = cls{0}BL.GetFirstObj_S(strWhereCond);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"根据条件获取第一条记录的对象出错!({0}Service:GetFirstJSONObj)\\r\\n\" + objException.Message;",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n }");

            //strBuilder.AppendFormat("\r\n cls{0}EN_Sim obj{0}EN_Sim = cls{0}BL.GetSimObjFromObj(obj{0}EN);", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n string strJSON = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return strJSON;");
            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }



        /// <summary>
        /// 生成代码:根据条件获取JSON对象列表
        /// </summary>
        /// <returns></returns>
        public string Gen_GetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取JSON对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <returns>返回JSON对象列表</returns>");
            strBuilder.Append("\r\n [WebMethod]");
            strBuilder.AppendFormat("\r\n public string GetJSONObjLst(string strWhereCond)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n List<cls{0}EN> arr{0}ObjLst;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n arr{0}ObjLst = cls{0}BL.GetObjLst(strWhereCond);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"根据条件获取的对象列表出错!({0}Service:GetJSONObjLst)\\r\\n\" + objException.Message;",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");

            strBuilder.Append("\r\n }");

            //strBuilder.AppendFormat("\r\n List<cls{0}EN_Sim> arr{0}SimObjLst = cls{0}BL.GetSimObjLstFromObjLst(arr{0}ObjLst);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n string strJSON = clsJSON.GetJsonFromObjLst(arr{0}ObjLst);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return strJSON;");
            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成代码:根据条件获取JSON对象列表
        /// </summary>
        /// <returns></returns>
        public string Gen_GetJSONObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取JSON对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intPageIndex\">页序号</param>");
            strBuilder.Append("\r\n /// <param name = \"intPageSize\">页记录数</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.Append("\r\n /// <returns>返回JSON对象列表</returns>");
            strBuilder.Append("\r\n [WebMethod]");
            strBuilder.AppendFormat("\r\n public string GetJSONObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "[\"strOrderBy\"] = strOrderBy, ");
            strBuilder.AppendFormat("\r\n" + "[\"intPageIndex\"] = intPageIndex.ToString(),", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "[\"intPageSize\"] = intPageSize.ToString()", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n List<cls{0}EN> arr{0}ObjLst;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n arr{0}ObjLst = cls{0}BL.GetObjLstByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"根据条件分页获取的对象列表出错!({0}Service:GetJSONObjLstByPager)\\r\\n\" + objException.Message;",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n }");

            //strBuilder.AppendFormat("\r\n List<cls{0}EN_Sim> arr{0}SimObjLst = cls{0}BL.GetSimObjLstFromObjLst(arr{0}ObjLst);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n string strJSON = clsJSON.GetJsonFromObjLst(arr{0}ObjLst);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return strJSON;");
            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 生成代码:根据条件获取JSON对象列表
        /// </summary>
        /// <returns></returns>
        public string Gen_GetJSONObjLstByRange()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取范围内的JSON对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">最小记录号</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">最大记录号</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.Append("\r\n /// <returns>返回JSON对象列表</returns>");
            strBuilder.Append("\r\n [WebMethod]");
            strBuilder.AppendFormat("\r\n public string GetJSONObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "[\"strOrderBy\"] = strOrderBy, ");
            strBuilder.AppendFormat("\r\n" + "[\"intMinNum\"] = intMinNum.ToString(),", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "[\"intMaxNum\"] = intMaxNum.ToString()", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n List<cls{0}EN> arr{0}ObjLst;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n arr{0}ObjLst = cls{0}BL.GetObjLstByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"根据条件获取指定范围内的对象列表出错!({0}Service:GetJSONObjLstByRange)\\r\\n\" + objException.Message;",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n }");

            //strBuilder.AppendFormat("\r\n List<cls{0}EN_Sim> arr{0}SimObjLst = cls{0}BL.GetSimObjLstFromObjLst(arr{0}ObjLst);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n string strJSON = clsJSON.GetJsonFromObjLst(arr{0}ObjLst);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return strJSON;");
            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }



        /// <summary>
        /// 生成代码:根据条件获取JSON对象列表
        /// </summary>
        /// <returns></returns>
        public string Gen_GetObjLstByRange()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取范围内的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">最小记录号</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">最大记录号</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">给定条件</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strBuilder.Append("\r\n /// <returns>返回范围内的对象列表</returns>");
            strBuilder.Append("\r\n [WebMethod]");
            strBuilder.AppendFormat("\r\n public List<cls{0}EN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "[\"strOrderBy\"] = strOrderBy, ");
            strBuilder.AppendFormat("\r\n" + "[\"intMinNum\"] = intMinNum.ToString(),", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "[\"intMaxNum\"] = intMaxNum.ToString()", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n List<cls{0}EN> arr{0}ObjLst;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n arr{0}ObjLst = cls{0}BL.GetObjLstByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"根据条件获取指定范围内的对象列表出错!({0}Service:GetJSONObjLstByRange)\\r\\n\" + objException.Message;",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n }");

            //strBuilder.AppendFormat("\r\n List<cls{0}EN_Sim> arr{0}SimObjLst = cls{0}BL.GetSimObjLstFromObjLst(arr{0}ObjLst);", objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n string strJSON = clsJSON.GetJsonFromObjLst(arr{0}ObjLst);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return arr{0}ObjLst;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }

        public string Gen_UpdateBySqlWithCondition()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_UpdateBySqlWithCondition(cls{0}EN obj{0}EN, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WS.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileName为空,请检查!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"obj{0}EN\", cls{0}BL.SerializeObjToXMLStr(obj{0}EN));", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"strWhereCond\", strWhereCond);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " }");


            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.UpdateBySqlWithCondition(obj{0}EN, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"修改记录出错!\\r\\n\" + objException.Message;");
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_AddNewRecordBySql2WithReturnKey()
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

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public string {0}_AddNewRecordBySql2WithReturnKey(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WS.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileName为空,请检查!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"obj{0}EN\", cls{0}BL.SerializeObjToXMLStr(obj{0}EN));", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " }");


            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.AppendFormat("\r\n" + "string strKey = cls{0}BL.AddNewRecordBySql2WithReturnKey(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return strKey;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"添加记录出错!\\r\\n\" + objException.Message;");
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
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
        //            public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
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
            this.ClsName = string.Format("{0}Service", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }

    }
}
