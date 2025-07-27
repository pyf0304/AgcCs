using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;

using AGC.Entity;


using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.file;
using com.taishsoft.commexception;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using AgcCommBase;

namespace AutoGCLib
{
    /// <summary>
    /// 该类专门用生成数据表的表代理层，该代理层是逻辑层的一部分，体系结构从下到下，
    /// 共分以下几层:
    ///		1、界面层
    ///			通用界面层，专门提供一些界面控件的公共操作函数
    ///		2、逻辑层
    ///			2.1 业务逻辑层
    ///			2.2 表代理层。包括:
    ///					1)表记录的添加、
    ///					2)表记录的删除
    ///					3)表记录的修改
    ///					4)表记录的查询
    ///					5)获取某些表记录的有关字段属性
    ///					6)设置表记录的有关字段属性等。
    ///		3、数据层，即通用数据层，专门用于操作数据库的一些操作，以及操作表的一些通用操作
    /// </summary>
    class EntityLayerRJ_Sim4JavaScript : clsGeneCodeBase
    {
        

        #region 构造函数

        public EntityLayerRJ_Sim4JavaScript()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public EntityLayerRJ_Sim4JavaScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {

            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        #endregion

        private List<ImportClass> GetImportClassLst(clsFuncModule_AgcEN objFuncModule)
        {

            List<ImportClass> arrImportClass = new List<ImportClass>();

        //    arrImportClass.Add(new ImportClass
        //    {
        //        ClassName = string.Format("clsGeneralTab", objPrjTabENEx.TabName),
        //        FilePath = string.Format("clsgeneraltab", objFuncModule.FuncModuleEnName,
        //objPrjTabENEx.TabName)
        //    });

            return arrImportClass;
        }

        /// <summary>
        /// 生成Entity层代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            //if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
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

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId,
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);


            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "EN_Sim";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.EntityLevel;

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

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objPrjTabENEx.UserId, objPrjTabENEx));
                List<ImportClass> arrImportClass = GetImportClassLst(objFuncModule);
                strCodeForCs.Append("\r\n" + "const __extends = (this && this.__extends) || (function() {");
                strCodeForCs.Append("\r\n" + "const extendStatics = function(d, b) {");
                strCodeForCs.Append("\r\n" + "extendStatics = Object.setPrototypeOf ||");
                strCodeForCs.Append("\r\n" + "({ __proto__: [] }");
                strCodeForCs.Append("\r\n" + "instanceof Array && function(d, b) { d.__proto__ = b; }) ||");
                strCodeForCs.Append("\r\n" + "function(d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };");
                strCodeForCs.Append("\r\n" + "return extendStatics(d, b);");
                strCodeForCs.Append("\r\n" + "};");
                strCodeForCs.Append("\r\n" + "return function(d, b) {");
                strCodeForCs.Append("\r\n" + "extendStatics(d, b);");
                strCodeForCs.Append("\r\n" + "function __() { this.constructor = d; }");
                strCodeForCs.Append("\r\n" + "d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());");
                strCodeForCs.Append("\r\n" + "};");
                strCodeForCs.Append("\r\n" + "})();");

                strCodeForCs.Append("\r\n" + "const __importStar = (this && this.__importStar) || function(mod) {");
                strCodeForCs.Append("\r\n" + "if (mod && mod.__esModule) return mod;");
                strCodeForCs.Append("\r\n" + "const result = { };");
                strCodeForCs.Append("\r\n" + "if (mod != null) for (var k in mod) if (Object.hasOwnProperty.call(mod, k)) result[k] = mod[k];");
                strCodeForCs.Append("\r\n" + "result[\"default\"] = mod;");
                strCodeForCs.Append("\r\n" + "return result;");
                strCodeForCs.Append("\r\n" + "};");

                strCodeForCs.Append("\r\n" + "(function(factory) {");
                strCodeForCs.Append("\r\n" + "if (typeof module === \"object\" && typeof module.exports === \"object\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const v = factory(require, exports);");
                strCodeForCs.Append("\r\n" + "if (v !== undefined) module.exports = v;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else if (typeof define === \"function\" && define.amd)");
                strCodeForCs.Append("\r\n" + "{");
                IEnumerable<string> arrFilePath = arrImportClass.Select(x => string.Format("\"{0}\"", x.FilePath));
                string strFilePathStr = string.Join(",", arrFilePath);
                strCodeForCs.AppendFormat("\r\n" + "define([\"require\", \"exports\", \"jquery\", {0}], factory);", strFilePathStr);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "})(function(require, exports) {");
                strCodeForCs.Append("\r\n" + "\"use strict\";");
                strCodeForCs.Append("\r\n" + "Object.defineProperty(exports, \"__esModule\", { value: true });");

                strCodeForCs.Append("\r\n" + "const $ = __importStar(require(\"jquery\"));");

                arrImportClass.ForEach(x => {
                    if (string.IsNullOrEmpty(x.ModuleName) == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "const {0}_js_1 = require(\"{1}\");", x.ClassName, x.FilePath);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "const {2} = require(\"{1}\");", x.ClassName, x.FilePath, x.ModuleName);
                    }
                });


                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "const {0} = /** @class **/ (function () {{",
                    objPrjTabENEx.ClsName);

                //生成所有的函数

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                     strFuncName = objvFunction4GeneCodeEN.FuncName;
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC_Cache(objvFunction4GeneCodeEN.FuncId4GC);
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }
                strCodeForCs.AppendFormat("\r\n" + "return {0};", objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}());");
                strCodeForCs.AppendFormat("\r\n" + "exports.{0} = {0};", objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "});");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
  
            }
            return strCodeForCs.ToString();
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

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
              string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(EntityLayerRJ_Sim4JavaScript);
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
                string strErrMsg = ""; 
                if (objException.InnerException != null)
                {
                    strErrMsg = objException.InnerException.Message;
                }
                else
                { 
                    strErrMsg = objException.Message;
                }
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", strFuncName, strErrMsg);
                throw new Exception(sbMessage.ToString());
            }
        }
        public override void GetClsName()
        {
            this.ClsName = string.Format("cls{0}EN_Sim", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
        public string Gen_EN_ClassConstructor1()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;            
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 构造函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n constructor()",
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n super();");
            //strCodeForCs.Append("\r\n this.hmProperty =  new collections.Dictionary <string, boolean>();");
            //strCodeForCs.Append("\r\n this.SetInit();");
            strCodeForCs.AppendFormat("\r\n this.CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n this.KeyFldName = \"{0}\";", objKeyField.FldName);

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 类公开的类属性
        /// </summary>
        /// <returns></returns>
        public string Gen_EN_ClsProperty()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n/// <summary>");
    
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n function {0}()",
       objPrjTabENEx.ClsName);

            strCodeForCs.Append("\r\n {");
            ///定义类属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                 objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                 objField.ObjFieldTabENEx.FldLength,
                 objField.ObjFieldTabENEx.IsNull,
                 objField.ObjFieldTabENEx.MemoInTab,
                  objField.ColCaption);
                strCodeForCs.AppendFormat("\r\n this.{1} = {2};",
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.InitValue_TypeScript);

                strCodeForCs.Append("\r\n");
            }

            strCodeForCs.Append("\r\n" + "this.sf_UpdFldSetStr = \"\";     //专门用于记录某字段属性是否修改");
            strCodeForCs.Append("\r\n" + "this.sf_FldComparisonOp = \"\";     //专门用于记录条件对象某字段的比较运算符");

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
    
    }
}
