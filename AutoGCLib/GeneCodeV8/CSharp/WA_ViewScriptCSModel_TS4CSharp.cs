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
using com.taishsoft.util;
using AgcCommBase;
using System.Reflection;
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
    partial class WA_ViewScriptCSModel_TS4CSharp : clsGeneCodeBase4View
    {
   
        #region 构造函数
        public WA_ViewScriptCSModel_TS4CSharp()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
        }
        public WA_ViewScriptCSModel_TS4CSharp(string strViewId)
       : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public WA_ViewScriptCSModel_TS4CSharp( string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        /// <summary>
        /// 初始化页面设置
        /// </summary>
        public void InitPageSetup()
        {
  
        }

        #endregion



        public string Gen_WApi_Model_SeUserId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// Session属性-用户Id");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "public string seUserId");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "get");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strValue = HttpContext.Session.GetString(\"UserId\");");
            strCodeForCs.Append("\r\n" + "return strValue;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "set");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "HttpContext.Session.SetString(\"UserId\", value);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Model_SetSession(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// 设置Session属性");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "/// <param name=\"strKey\"></param>");
            strCodeForCs.Append("\r\n" + "/// <param name=\"strValue\"></param>");
            strCodeForCs.Append("\r\n" + "public void SetSession(string strKey, string strValue)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "HttpContext.Session.SetString(strKey, strValue);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Model_WebRoot(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// 当前的虚拟根目录,在appsettings.json设置：environmentVariables:ASPNETCORE_PATHBASE");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "public string WebRoot");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "get");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//物理路径");
            strCodeForCs.Append("\r\n" + "string strPhysicalRoot = AppContext.BaseDirectory;");
            strCodeForCs.Append("\r\n" + "//获取设置：虚拟根目录");
            strCodeForCs.Append("\r\n" + "const pathBase = Environment.GetEnvironmentVariable(\"ASPNETCORE_PATHBASE\");");
            strCodeForCs.Append("\r\n" + "//获取公共变量：WebRoot");
            strCodeForCs.Append("\r\n" + "return clsPubVar.WebRoot;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
       

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Model_CurrPrjId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// 当前的工程Id");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "public string CurrPrjId");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "get");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//获取公共变量：CurrPrjId");
            strCodeForCs.Append("\r\n" + "return clsPubVar.CurrPrjId;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Model_GetSession(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// 获取Session属性");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "/// <param name=\"strKey\">关键字-Session属性名</param>");
            strCodeForCs.Append("\r\n" + "/// <returns>返回当前关键字的值</returns>");
            strCodeForCs.Append("\r\n" + "public string GetSession(string strKey)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strValue = HttpContext.Session.GetString(strKey);");
            strCodeForCs.Append("\r\n" + "return strValue;");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Model_Url_Session_GetString(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// 获取Session属性的地址");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");            
            strCodeForCs.Append("\r\n" + "public string Url_Session_GetString");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "get");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "  return clsPubVar.Url_Session_GetString;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Model_Url_Session_SetString(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// 设置Session属性的地址");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "public string Url_Session_SetString");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "get");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "  return clsPubVar.Url_Session_SetString;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_ViewScriptCSModel_TS4CSharp);
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
            

            this.ClsName = objViewInfoENEx.ViewName;
            objViewInfoENEx.ClsName = this.ClsName;
        }
    

        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
          
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            this.GetClsName();
            objViewInfoENEx.WebFormName = this.ClsName;
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + this.ClsName + ".cshtml.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            
            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                //strCodeForCs.Append("\r\n ///生成查询,修改,删除,添加记录的控制层代码");

                
                strCodeForCs.AppendFormat("\r\n" + "using System;");
                strCodeForCs.AppendFormat("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.AppendFormat("\r\n" + "using System.Diagnostics;");
                strCodeForCs.AppendFormat("\r\n" + "using System.Linq;");
                strCodeForCs.AppendFormat("\r\n" + "using System.Threading.Tasks;");
                strCodeForCs.AppendFormat("\r\n" + "using Microsoft.AspNetCore.Http;");
                strCodeForCs.AppendFormat("\r\n" + "using Microsoft.AspNetCore.Mvc;");
                strCodeForCs.AppendFormat("\r\n" + "using Microsoft.AspNetCore.Mvc.RazorPages;");
                strCodeForCs.AppendFormat("\r\n" + "using {0}.FunClass;", objViewInfoENEx.NameSpace);

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Pages", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0} 的摘要说明。其中Q代表查询,U代表修改", objViewInfoENEx.WebFormName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public class  {0}Model : PageModel", objViewInfoENEx.WebFormName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "public string Message { get; set; }");

                strCodeForCs.Append("\r\n" + "public void OnGet()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "Message = \"{0}({1})({2})页面.\";", objViewInfoENEx.ViewName, objViewInfoENEx.ViewCnName, objViewInfoENEx.ViewId);
                strCodeForCs.Append("\r\n" + "}");

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
           clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }
                    try
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        throw objException;
                    }
                }


                strCodeForCs.Append("\r\n" + "");
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


    }
}
