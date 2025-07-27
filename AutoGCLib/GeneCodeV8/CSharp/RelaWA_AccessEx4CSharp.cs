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
    partial class RelaWA_AccessEx4CSharp : clsGeneCodeBase4Tab
    {

        #region 构造函数

      
        public RelaWA_AccessEx4CSharp(string strTabId,  string strPrjDataBaseId, string strPrjId)
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
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);


            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "ExWApi";
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
                strBuilder.Append("\r\n" + "using com.taishsoft.common;"); //
                strBuilder.Append("\r\n" + "using System.ServiceModel;"); //
                strBuilder.AppendFormat("\r\n" + "using {0}.Entity;", objProjectsENEx.PrjDomain);
                //strBuilder.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProjectsENEx.PrjDomain);
      
                // strBuilder.AppendFormat("\r\n" + "using {1}4WS.ServiceReference{0};", objPrjTabENEx.TabName, objProject.PrjDomain); //
                strBuilder.Append("\r\n" + "using System.Collections.Generic;"); //
                strBuilder.Append("\r\n" + "using com.taishsoft.json;"); //
                strBuilder.Append("\r\n" + "using Newtonsoft.Json.Linq; using Comm.WebApi;"); //

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
                        //clsvFunction4GeneCodeEN objFunction4GeneCodeEN1 = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
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


                strBuilder.AppendFormat("\r\n" + "//private static readonly string mstrApiControllerName = \"{0}ExApi\";",
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
                //生成用户自定义的函数
                string strCode = clsFunction4CodeBLEx.GeneCode4Class(objPrjTabENEx.ClsName, objPrjTabENEx.CodeTypeId, objPrjTabENEx.PrjId);
                strBuilder.Append("\r\n" + strCode);

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
        /// 生成构造函数1
        /// </summary>
        /// <returns></returns>
        public string Gen_4WAEx_ClassConstructor1()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///类构造器----------------------------------------------;
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 构造函数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
              string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(RelaWA_AccessEx4CSharp);
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
                Type t = typeof(RelaWA_AccessEx4CSharp);
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
        public string Gen_4WAEx_Static_CopyToEx()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把同一个类的对象,复制到另一个对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>目标对象=>cls{0}EN:obj{0}ENT</returns>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static cls{0}ENEx CopyToEx(this cls{0}EN obj{0}ENS)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n cls{0}ENEx obj{0}ENT = new cls{0}ENEx();", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "cls{0}WApi.CopyTo(obj{0}ENS, obj{0}ENT);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}ENT;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyToEx_Static", "静态Copy表:{0} 对象数据出错!", "生成代码");

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
        public string Gen_4WAEx_EditRelationEx()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 修改记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>是否成功?</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool EditRelationEx(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.sfUpdFldSetStr) == true)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).\",");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1}, clsStackTrace.GetCurrClassFunction());", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "string strAction = \"EditRelationEx\";");
            
            
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

        public string Gen_4WAEx_UpdateRelationEx()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 修改记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>是否成功?</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateRelationEx(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.sfUpdFldSetStr) == true)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).\",");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1}, clsStackTrace.GetCurrClassFunction());", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "string strAction = \"UpdateRelationEx\";");
            
            
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

        public string Gen_4WAEx_AddRelationEx()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 修改记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>是否成功?</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddRelationEx(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
        

            strBuilder.Append("\r\n" + "string strAction = \"AddRelationEx\";");
            
            
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

        public string Gen_4WAEx_Static_EditRelationEx()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "EditRelationEx_Static", "编辑记录时关键字不能为空!", "生成代码");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// 功能:通过SQL命令来修改记录,该方式是优化方式");
            strBuilder.Append("\r\n /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的实体对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool EditRelationEx(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "{");
            //if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool")
            //{
            //    if (IsNumberType4Key == true)
            //    {
            //        strBuilder.AppendFormat("\r\n" + " if (obj{0}EN.{1} == 0)",
            //         objPrjTabENEx.TabName, objKeyField.FldName);
            //    }
            //    else
            //    {
            //        strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
            //            objPrjTabENEx.TabName, objKeyField.FldName);
            //    }
            //    strBuilder.Append("\r\n" + " {");

            //    strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})修改记录时关键字不能为空!(from {{0}})\\r\\n\",", strErrId);
            //    strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
            //    strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");
            //    strBuilder.Append("\r\n" + " }");
            //}
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "obj{0}EN.sfUpdFldSetStr = obj{0}EN.getsfUpdFldSetStr();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}ExWApi.EditRelationEx(obj{0}EN);",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "  //引发修改记录的事件");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "    onUpdateRelation?.Invoke(obj{0}EN);", TabName);
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
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "EditRelationEx_Static", "编辑记录出错!", "生成代码");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})编辑记录出错,{{1}}!(from {{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4WAEx_Static_AddRelationEx()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //插入记录存盘过程代码for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 插入记录存盘到数据表中");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>插入记录是否成功？</returns>");

                strCodeForCs.AppendFormat("\r\n" + "public static bool AddRelationEx(this cls{0}EN obj{0}EN)",
                       objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:");
                strCodeForCs.Append("\r\n" + "//1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在");
                strCodeForCs.Append("\r\n" + "//2、检查唯一性");
                strCodeForCs.Append("\r\n" + "//3、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "//4、把数据实体层的数据存贮到数据库中");
                strCodeForCs.Append("\r\n" + "string strMsg;	//专门用于传递信息的变量");

                string strErrId = "";
                               
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "bool bolResult = cls{0}ExWApi.AddRelationEx(obj{0}EN);",
                         objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
                strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshCache();", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "return bolResult;");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");

                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                    objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Add{0}RelationSave", "添加记录不成功!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "strMsg = \"(errid:{0})添加记录不成功!\" + objException.Message;", strErrId);
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "return true;");

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
        public string Gen_4WAEx_Static_UpdateRelationEx()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                //修改存盘准备过程代码 for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 修改记录存盘到数据表中");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的实体对象</param>", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <returns>修改是否成功？</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static bool UpdateRelationEx(this cls{0}EN obj{0}EN)",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:");
                strCodeForCs.Append("\r\n" + "//1、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "//2、检查唯一性");
                strCodeForCs.Append("\r\n" + "//3、把数据实体层的数据存贮到数据库中");
                strCodeForCs.Append("\r\n" + "string strMsg;	//专门用于传递信息的变量");

                //string strErrId = "";

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//1、检查传进去的对象属性是否合法");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.sfUpdFldSetStr = obj{0}EN.getsfUpdFldSetStr();", objPrjTabENEx.TabName);
          
                strCodeForCs.AppendFormat("\r\n" + "bool bolResult = cls{0}ExWApi.UpdateRelationEx(obj{0}EN);",
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
                strCodeForCs.AppendFormat("\r\n" + "{0}_ReFreshCache();", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "return bolResult;");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strMsg = \"修改记录不成功!\" + objException.Message;");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "return true; ");

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
               
    }
}
