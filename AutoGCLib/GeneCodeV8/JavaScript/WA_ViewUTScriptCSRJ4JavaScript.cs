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
    partial class WA_ViewUTScriptCSRJ4JavaScript : WA_ViewUTScriptCS4JavaScript
    {


        #region 构造函数

        public WA_ViewUTScriptCSRJ4JavaScript()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public WA_ViewUTScriptCSRJ4JavaScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
        }
        #endregion


        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_ViewUTScriptCSRJ4JavaScript);
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
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", objvFunction4GeneCodeEN.FuncName, objException.Message);
                throw new Exception(sbMessage.ToString());
            }
        }

        private List<ImportClass> GetImportClassLst(clsFuncModule_AgcEN objFuncModule)
        {

            List<ImportClass> arrImportClass = new List<ImportClass>();
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}EN", objPrjTabENEx.TabName),
                FilePath = string.Format("../../Js/L0_Entity/{0}/cls{1}EN.js", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}WApi", objPrjTabENEx.TabName),
                FilePath = string.Format("../../Js/L3_ForWApi/{0}/cls{1}WApi.js", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });


            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}BL", objPrjTabENEx.TabName),
                FilePath = string.Format("../../Js/L2_BLL/{0}/cls{1}BL.js", objFuncModule.FuncModuleEnName,
                                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsCommFunc4Web", objPrjTabENEx.TabName),
                FilePath = string.Format("clscommonfunc4web", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("stuTopPara", objPrjTabENEx.TabName),
                FilePath = string.Format("../../Js/PubFun/stuTopPara.js", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("stuRangePara", objPrjTabENEx.TabName),
                FilePath = string.Format("../../Js/PubFun/stuRangePara.js", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("stuPagerPara", objPrjTabENEx.TabName),
                FilePath = string.Format("../../Js/PubFun/stuPagerPara.js", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsPubFun", objPrjTabENEx.TabName),
                FilePath = string.Format("../../Js/PubFun/clsPubFun.js", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("CacheHelper", objPrjTabENEx.TabName),
                FilePath = string.Format("cachehelper", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsFldComparisonObj", objPrjTabENEx.TabName),
                FilePath = string.Format("clsfldcomparisonobj", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });
            return arrImportClass;
        }

        /// <summary>
        /// 生成App页面后台代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            this.Is4RJ = true;
            string strFuncName = "";
            //if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层({1})",
                        objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层({1})",
                   objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp = ""; ///临时变量;

            objPrjTabENEx.ClsName = string.Format("WA_{0}_UT_JS", objPrjTabENEx.TabName);
            string strXmlFileName = string.Format("WA_{0}_UT_JS", objPrjTabENEx.TabName);
            strXmlFileName = strXmlFileName.ToLower();
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".js";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName, objPrjTabENEx.SimpleFileName);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".js";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjId_Cache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始
                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objPrjTabENEx.UserId, objPrjTabENEx));

                List<ImportClass> arrImportClass = GetImportClassLst(objFuncModule);

            //strBuilder.Append("\r\n ///生成查询删除记录的控制层代码");
            //strBuilder.Append("\r\n" + GenRefDomainName());    //生成参考域名
            strBuilder.Append("\r\n" + "(function(factory) {");
                strBuilder.Append("\r\n" + "if (typeof module === \"object\" && typeof module.exports === \"object\")");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "const v = factory(require, exports);");
                strBuilder.Append("\r\n" + "if (v !== undefined) module.exports = v;");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else if (typeof define === \"function\" && define.amd)");
                strBuilder.Append("\r\n" + "{");
                IEnumerable<string> arrFilePath = arrImportClass.Select(x=>string.Format("\"{0}\"", x.FilePath));
                string strFilePathStr = string.Join(",", arrFilePath);
                strBuilder.AppendFormat("\r\n" + "define([\"require\", \"exports\", {0}], factory);", strFilePathStr);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "})(function(require, exports) {");
                strBuilder.Append("\r\n" + "\"use strict\";");
                strBuilder.Append("\r\n" + "Object.defineProperty(exports, \"__esModule\", { value: true });");


                strBuilder.Append("\r\n" + "///// <reference path=\"../../../scripts/typings/jquery/jquery.d.ts\" />");
                
                strBuilder.Append("\r\n" + "/////import * as $ from \"jquery\";");

                arrImportClass.ForEach(x=> {
                    strBuilder.AppendFormat("\r\n" + "const {0}_js_1 = require(\"{1}\");", x.ClassName, x.FilePath);
                });

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0} 的摘要说明。其中Q代表查询,U代表修改", objPrjTabENEx.ClsName);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "const {0} = /** @class **/ (function() {{", objPrjTabENEx.ClsName);
                strBuilder.AppendFormat("\r\n" + "function {0}()", objPrjTabENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "}");

                    //strBuilder.Append("\r\n" + "private strInfo = \"\";");
                    //strBuilder.Append("\r\n" + "private strWhereCond = \"\";");

                    strBuilder.Append("\r\n" + "");
                /////生成界面中Page_Load代码;
                //strBuilder.Append("\r\n" + "#region 页面启动函数");

                /////生成界面中Page_Load代码;
                //strTemp = GenPage_LoadCode(false);
                //strBuilder.Append(strTemp);
                //strBuilder.Append("\r\n" + "#endregion 页面启动函数");
                //生成所有的函数
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId,
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);
                //为所有的函数定义相关输入控件
                List<string> arrValueLst = new List<string>();
                             
                //为函数的参数输入控件进行绑定
                arrValueLst = new List<string>();

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_ClassStatic =
                    arrvFunction4GeneCodeObjLst.Where(x=>x.FuncTypeId == enumFunctionType.ClassStaticFunction_15);

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_NotClassStatic =
                    arrvFunction4GeneCodeObjLst.Where(x => x.FuncTypeId != enumFunctionType.ClassStaticFunction_15);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_NotClassStatic)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);                 
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }

              
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_ClassStatic)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }
                
                strBuilder.AppendFormat("\r\n" + "return {0};", objPrjTabENEx.ClsName);
                strBuilder.Append("\r\n" + "}());");
                strBuilder.AppendFormat("\r\n" + "exports.{0} = {0};", objPrjTabENEx.ClsName);
                strBuilder.Append("\r\n" + "});");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strBuilder.ToString();
        }
   

        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
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
            this.ClsName = string.Format("WA_{0}_UT_JS", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
    }
}
