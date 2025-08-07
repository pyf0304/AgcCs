using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;


using AGC.Entity;

using AGC.BusinessLogic;
using com.taishsoft.datetime;
using AgcCommBase;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
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
    partial class BusinessLogicRJ4JavaScript : clsGeneCodeBase
    {
        public bool Is4RJ { get; set; }
        #region 构造函数

        public BusinessLogicRJ4JavaScript()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            clsErrorIdManageBLEx.arrErrIdLst_Cache = null;
        }
        public BusinessLogicRJ4JavaScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            clsErrorIdManageBLEx.arrErrIdLst_Cache = null;
        }
        #endregion

        private List<ImportClass> GetImportClassLst(clsFuncModule_AgcEN objFuncModule)
        {

            List<ImportClass> arrImportClass = new List<ImportClass>();
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}EN", objPrjTabENEx.TabName),
                FilePath = string.Format("../../L0_Entity/{0}/cls{1}EN.js", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}EN_Sim", objPrjTabENEx.TabName),
                FilePath = string.Format("../../L0_Entity/{0}/cls{1}EN_Sim.js", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("tzDataType", objPrjTabENEx.TabName),
                FilePath = string.Format("../../PubFun/jsString.js", objFuncModule.FuncModuleEnName,
        objPrjTabENEx.TabName)
            });

           
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("tzPubFun", objPrjTabENEx.TabName),
                FilePath = string.Format("../../PubFun/tzPubFun.js", objFuncModule.FuncModuleEnName,
                   objPrjTabENEx.TabName)
            });
            return arrImportClass;
        }



        /// <summary>
        /// 生成业务逻辑层代码－－C#.NET
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            this.Is4RJ = true;
            string strFuncName = "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strResult;
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
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId,
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "BL";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.TypeScriptLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".js";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName, objPrjTabENEx.SimpleFileName);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".js";
            objPrjTabENEx.FileName = strClassFName;
            //clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjId_Cache(objPrjTabENEx.PrjId); //

            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objPrjTabENEx.UserId, objPrjTabENEx));
                List<ImportClass> arrImportClass = GetImportClassLst(objFuncModule);

                strCodeForCs.Append("\r\n" + "const __importStar = (this && this.__importStar) || function(mod) {");
                strCodeForCs.Append("\r\n" + "if (mod && mod.__esModule) return mod;");
                strCodeForCs.Append("\r\n" + "const result = { };");
                strCodeForCs.Append("\r\n" + "if (mod != null) for (var k in mod) if (Object.hasOwnProperty.call(mod, k)) result[k] = mod[k];");
                strCodeForCs.Append("\r\n" + "result[\"default\"] = mod;");
                strCodeForCs.Append("\r\n" + "return result;");
                strCodeForCs.Append("\r\n" + "}");

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
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                clsSQLDSTypeEN objSQLDSType = clsSQLDSTypeBL.GetObjBySqlDsTypeId_Cache(objPrjTabENEx.SqlDsTypeId);
                strCodeForCs.AppendFormat("\r\n /// 数据源类型:{0}",
                objSQLDSType.SqlDsTypeName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                //strCodeForCs.Append("\r\n" + "const VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中");

                //strCodeForCs.AppendFormat("\r\n" + "import {{ cls{0}EN }}  from '../../l0_Entity/SysPara/cls{0}EN';",
                //    objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "const {0} = /** @class **/ (function () {{",
                    objPrjTabENEx.ClsName);

                strCodeForCs.AppendFormat("\r\n" + "function {0}()", objPrjTabENEx.ClsName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //私有属性名-----和属性过程
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
                       strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "this.arr{0}ObjLst_Cache = new Array();",
                       objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// 从缓存中查找失败的次数");
                strCodeForCs.AppendFormat("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "this.intFindFailCount = 0;");

                strCodeForCs.Append("\r\n" + "}");


    

                //生成所有的函数

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC_Cache(objvFunction4GeneCodeEN.FuncId4GC);
                     strFuncName = objvFunction4GeneCodeEN.FuncName;

                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        if (objPrjTabENEx.LangType == clsPubConst.LangType.CSharp)
                        {
                            strCodeForCs.Append("\r\n" + "");
                            strCodeForCs.Append("\r\n" + "");
                            strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        }
                        continue;
                    }
                    try
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.", strFuncName, objException.Message);
                        throw new Exception(strMsg);
                    }
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
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 把一个JSON串转化为一个对象.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Ts_getRecObjByJSONStr()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 把一个JSON串转化为一个对象");
            strCodeForCs.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"strJSON\">需要转化的JSON串</param>",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <returns>返回一个生成的对象</returns>",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "{0}.GetObjByJSONStr  = function(strJSON)",
                objPrjTabENEx.ClsName,
                  objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "let pobj{0}EN = new cls{0}EN();",
              objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "if (strJSON === \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "return pobj{0}EN;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            //  var data : NSData! = NSJSONSerialization.dataWithJSONObject(strJSON, options: []);
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN = JSON.parse(strJSON);", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "catch(objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "return pobj{0}EN;",
                    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "return pobj{0}EN;",
                    objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 把一个JSON串转化为一个对象.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Ts_getJSONStrByRecObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 把一个对象转化为一个JSON串");
            strCodeForCs.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"strJSON\">需要转化的JSON串</param>",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <returns>返回一个生成的对象</returns>",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "{0}.GetJSONStrByObj  = function(pobj{1}EN)",
                objPrjTabENEx.ClsName,
                  objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.sf_UpdFldSetStr = pobj{0}EN.UpdFldString;",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "let strJson = \"\";");
            
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "strJson = JSON.stringify(pobj{0}EN);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strEx = clsCommFunc4Web.GetExceptionStr(objException);");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(strEx);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (strJson == undefined) return \"\";");
            strCodeForCs.Append("\r\n" + "else return strJson;");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 把一个JSON串转化为一个对象.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Ts_getDictionaryObjByRecObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 把一个对象转化为一个JSON串");
            strCodeForCs.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"strJSON\">需要转化的JSON串</param>",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <returns>返回一个生成的对象</returns>",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "{0}.GetDictionaryObjByObj  = function(pobj{1}EN)",
                objPrjTabENEx.ClsName,
                  objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.sf_UpdFldSetStr = pobj{0}EN.UpdFldString;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "const objDict;");
            strCodeForCs.Append("\r\n" + "objDict = NSMutableDictionary();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
                {
                    case "Int32":
                        strCodeForCs.AppendFormat("\r\n" + "objDict.setValue(String(pobj{0}EN.{1}), forKey.con_{1});",
                             objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" + "objDict.setValue(pobj{0}EN.{1}, forKey.con_{1});",
                             objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                        break;
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "objDict.setValue(pobj{0}EN.sf_UpdFldSetStr, forKey: \"sf_UpdFldSetStr\");",
                 objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return objDict;");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 把一个JSON串转化为一个对象列表.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Ts_getObjLstByJSONStr()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 把一个JSON串转化为一个对象列表");
            strCodeForCs.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"strJSON\">需要转化的JSON串</param>",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <returns>返回一个生成的对象列表</returns>",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "{0}.GetObjLstByJSONStr  = function(strJSON)",
                objPrjTabENEx.ClsName,
                  objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "let arr{0}ObjLst = new Array<cls{0}EN>();",
              objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "if (strJSON === \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = JSON.parse(strJSON);", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "catch(objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                    objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        private string SetPropertyByJson_TypeScript(clsPrjTabFldENEx objField)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n" + "if (jsonAllKeys.containsObject(\"{0}\") == true)",
                 objField.ObjFieldTabENEx.FldName);
            strCodeForCs.Append("\r\n" + "{");
            //  strCodeForCs.Append("\r\n" + "//print(\"Memo1 is Exist!\");");
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
            {
                case "String":
                    strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = String(json.objectForKey(\"{1}\")!);",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Int32":
                    strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = Int32(String(json.objectForKey(\"{1}\")!))!;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Int":
                    strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = Int(String(json.objectForKey(\"{1}\")!))!;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Bool":
                    strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = clsPubFun.myBool(json.objectForKey(\"{1}\")!);",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                default:
                    string strMsg = string.Format("Swift数据类型在switch中没有处理。({0})", clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4BL_Ts_CheckPropertyNew()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n {0}.prototype.CheckPropertyNew = function(pobj{1}EN)",
                        objPrjTabENEx.ClsName, 
                        objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("CheckPropertyNew", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "字段[{1}|{0}]不能为空(NULL)!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");
            strCodeForCs.Append("\r\n//检查字段非空， 即数据表要求非常非空的字段，不能为空！");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") return "";//只读就不需要检查
                if (objField.IsTabNullable == false && objField.FieldTypeId != "02")
                {
                    strCodeForCs.Append(inGen_CheckNull4Field_Ts(objField, strErrId, strFunctionName));
                }
            }

            //检查属性长度代码;
            strCodeForCs.Append(inGen_CheckFieldLength_Ts("CheckPropertyNew"));

            //检查字段的数据类型是否正确
            strCodeForCs.Append(inGen_CheckDataType_Ts(strFunctionName));

            //检查外键字段长度;

            strCodeForCs.Append(inGen_CheckFieldForeighKey_Ts("CheckPropertyNew"));


            strCodeForCs.Append("\r\n//设置说明该对象已经检查过了，后面不需要再检查，即非法！");

            strCodeForCs.AppendFormat("\r\n pobj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n}");


            ///检查类中属性是否正确-------------------------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n {0}.prototype.CheckProperty4Update  = function(pobj{1}EN)",
                objPrjTabENEx.ClsName,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            //检查属性长度代码;

            strCodeForCs.Append(inGen_CheckFieldLength_Ts("CheckProperty4Update"));

            //检查数据类型是否正确
            strCodeForCs.Append(inGen_CheckDataType_Ts("CheckProperty4Update"));

            //检查主键是否Null
            strFunctionName = string.Format("CheckProperty4Update", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "字段[{1}|{0}]不能为空(NULL)!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.Append("\r\n//检查主键是否为Null或者空！");

            strCodeForCs.Append(inGen_CheckNull4Field_Ts(objPrjTabENEx.objKeyField0, strErrId, "CheckProperty4Update"));
            ///检查外键字段长度;

            strCodeForCs.Append(inGen_CheckFieldForeighKey_Ts("CheckProperty4Update"));

            strCodeForCs.AppendFormat("\r\n pobj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n}");

            ///检查类中属性是否正确 ==  ==  == = ;
            return strCodeForCs.ToString();
        }

        private string inGen_CheckDataType_Ts(string strFunctionName)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //检查字段的数据类型是否正确
            //   string strFunctionName = string.Format("CheckPropertyNew", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "字段[{0}|{1}]的值：【{2}】,非法，应该为数值型!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\n" + "//检查字段的数据类型是否正确");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "pobj" + objPrjTabENEx.TabName + "EN");

                string strDataTypeName = "";
                switch (objField.TypeScriptType)
                {
                    case "string":
                        strCodeForCs.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isString(pobj{0}EN.{1}) === false)",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "字符型";
                        break;
                    case "number":
                        strCodeForCs.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.{1}) === false)",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "数值型";
                        break;
                    case "any":

                        strDataTypeName = "any型";
                        break;
                    case "long":
                        strCodeForCs.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.{1}) === false)",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "长整型";
                        break;
                    case "int":
                        strCodeForCs.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.{1}) === false)",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "整型";
                        break;
                    case "double":
                        strCodeForCs.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.{1}) === false)",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "双精度";
                        break;
                    case "float":
                        strCodeForCs.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.{1}) === false)",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "浮点型";
                        break;
                    case "short":
                        strCodeForCs.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.{1}) === false)",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "短整型";
                        break;
                    case "boolean":
                        strCodeForCs.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isBoolean(pobj{0}EN.{1}) === false)",
                         objPrjTabENEx.TabName,
                         objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "布尔型";
                        break;
                    case "Date":
                        strCodeForCs.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isBoolean(pobj{0}EN.{1}) === false)",
                         objPrjTabENEx.TabName,
                         objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "日期型";
                        break;
                    default:
                        string strMsg = string.Format("Java数据类型:【{0}】在switch中没有处理。({0})",
                            clsStackTrace.GetCurrClassFunction(),
                            objField.JavaType);
                        throw new Exception(strMsg);

                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n throw new Error(\"(errid:{7})字段[{2}({3})|{0}({4})]的值:[$(pobj{3}EN.{4})], 非法，应该为{8}!(cls{3}BL:{9})\");",
                           objField.ColCaption,
                           objField.ObjFieldTabENEx.FldLength,
                           objPrjTabENEx.TabCnName,
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           "{", "}",
                           strErrId,
                           strDataTypeName,
                           strFunctionName);
                strCodeForCs.Append("\r\n" + "}");
            }
            return strCodeForCs.ToString();
        }
        private string inGen_CheckNull4Field_Ts(clsPrjTabFldENEx objField, string strErrId, string strFunctionName)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "pobj" + objPrjTabENEx.TabName + "EN");
            string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "pobj" + objPrjTabENEx.TabName + "EN");


            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
            {
                return "";
            }

            if (objField.FldOpTypeId == "0003")
            {

                strCodeForCs.AppendFormat("\r\n if (null === {0} ",
                    strPrivPropNameWithObjectName4Get);

                strCodeForCs.AppendFormat("\r\n || IsNullOrEmpty({0}) == false && {0}.ToString()  ===  \"\" ",
                    strPrivPropNameWithObjectName4Get);
                if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                {
                    strCodeForCs.AppendFormat("\r\n || IsNullOrEmpty({0}) == false && {1}.toString()  ===  \"0\"",
                        strPrivPropNameWithObjectName4Get,
                        strPrivPropNameWithObjectName4Get);
                }
                strCodeForCs.Append("\r\n )");
                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\n throw new Error(\"(errid:{2})字段[{1}|{0}]不能为空(NULL)!(cls{3}BL:{4})\");",
                        objField.ColCaption,
                        objPrjTabENEx.TabCnName,
                        strErrId,
                        objPrjTabENEx.TabName,
                        strFunctionName);
                strCodeForCs.Append("\r\n}");
            }
            else
            {

                strCodeForCs.AppendFormat("\r\nif (null === {0} ", strPrivPropNameWithObjectName);
                strCodeForCs.AppendFormat("\r\n || IsNullOrEmpty({0}) == false && {0}.toString()  ===  \"\"", strPrivPropNameWithObjectName);
                if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                {
                    strCodeForCs.AppendFormat("\r\n || IsNullOrEmpty({0}) == false && {0}.toString()  ===  \"0\" ", strPrivPropNameWithObjectName);
                }
                strCodeForCs.Append(")");
                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\n throw new Error(\"(errid:{2})字段[{1}|{0}]不能为空(NULL)!(cls{3}BL:{4})\");",
                            objField.ColCaption,
                            objPrjTabENEx.TabCnName,
                            strErrId,
                            objPrjTabENEx.TabName,
                            strFunctionName);
                strCodeForCs.Append("\r\n}");
            }

            return strCodeForCs.ToString();
        }
        private string inGen_CheckFieldLength_Ts(string strFunctionName)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = string.Format(strFuncName, objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "字段[{2}({3})|{0}({4})]的长度不能超过{1}!值:{{0}}";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");
            strCodeForCs.Append("\r\n//检查字段长度， 若字符型字段长度超出规定的长度，即非法！");


            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查

                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "pobj" + objPrjTabENEx.TabName + "EN");
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "pobj" + objPrjTabENEx.TabName + "EN");

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                  && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                  && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strCodeForCs.AppendFormat("\r\nif (IsNullOrEmpty({0}) == false && GetStrLen({0}) > {1})", strPrivPropNameWithObjectName4Get, objField.ObjFieldTabENEx.FldLength);
                        strCodeForCs.Append("\r\n{");
                        strCodeForCs.AppendFormat("\r\n throw new Error(\"(errid:{7})字段[{2}({3})|{0}({4})]的长度不能超过{1}!值:$(pobj{3}EN.{4}))(cls{3}BL:{8})\";",
                        objField.ColCaption,
                        objField.ObjFieldTabENEx.FldLength.ToString().Trim(),
                        objPrjTabENEx.TabCnName,
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName,
                        "{", "}",
                        strErrId,
                        strFunctionName);
                        strCodeForCs.Append("\r\n}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\nif (IsNullOrEmpty({0}) == false && GetStrLen({0}) > {1})",
                             strPrivPropNameWithObjectName,
                              objField.ObjFieldTabENEx.FldLength);
                        strCodeForCs.Append("\r\n{");
                        strCodeForCs.AppendFormat("\r\n throw new Error(\"(errid:{7})字段[{2}({3})|{0}({4})]的长度不能超过{1}!值:$(pobj{3}EN.{4})(cls{3}BL:{8})\");",
                        objField.ColCaption,
                        objField.ObjFieldTabENEx.FldLength.ToString().Trim(),
                        objPrjTabENEx.TabCnName,
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName,
                        "{", "}",
                        strErrId,
                        strFunctionName);
                        strCodeForCs.Append("\r\n}");
                    }
                }
            }

            return strCodeForCs.ToString();
        }


        private string inGen_CheckFieldForeighKey_Ts(string strFunctionName)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            //string strFunctionName = string.Format("CheckPropertyNew", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "字段[{2}|{0}]作为外键字段,长度应该为{1}!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");
            strCodeForCs.Append("\r\n//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.IsTabForeignKey == false) continue;//如果不是外键,就不需要检查
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "pobj" + objPrjTabENEx.TabName + "EN");
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "pobj" + objPrjTabENEx.TabName + "EN");

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strCodeForCs.AppendFormat("\r\nif ({0} != null && GetStrLen({0}) != {1})",
                             strPrivPropNameWithObjectName4Get,
                              objField.ObjFieldTabENEx.FldLength);
                        strCodeForCs.Append("\r\n{");
                        strCodeForCs.AppendFormat("\r\n throw (\"(errid:{3})字段[{2}|{0}]作为外键字段,长度应该为{1}!(cls{4}BL:CheckPropertyNew)\");",
                              objField.ColCaption,
                              objField.ObjFieldTabENEx.FldLength,
                              objPrjTabENEx.TabCnName,
                              strErrId,
                              objPrjTabENEx.TabName);
                        strCodeForCs.Append("\r\n}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\nif ({0} != null && GetStrLen({0}) !=  {1})",
                            strPrivPropNameWithObjectName,
                            objField.ObjFieldTabENEx.FldLength);
                        strCodeForCs.Append("\r\n{");
                        strCodeForCs.AppendFormat("\r\n throw (\"(errid:{3})字段[{2}|{0}]作为外键字段,长度应该为{1}!(cls{4}BL:CheckPropertyNew)\");",
                                 objField.ColCaption,
                                 objField.ObjFieldTabENEx.FldLength,
                                 objPrjTabENEx.TabCnName,
                              strErrId,
                              objPrjTabENEx.TabName);
                        strCodeForCs.Append("\r\n}");
                    }
                }
            }
            strCodeForCs.Append("\r\n");
            return strCodeForCs.ToString();
        }


        public string Gen_4BL_Ts_CopyObjToSimObj()
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
            {
                //return "";
            }

            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把同一个类的对象,复制到另一个对象(简单)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n{0}.CopyObjToSimObj = function(obj{1}ENS , obj{1}ENT ) ",
                objPrjTabENEx.ClsName, 
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n{");
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
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.sf_UpdFldSetStr = obj{0}ENS.UpdFldString; //专门用于记录某字段属性是否修改",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.sf_FldComparisonOp = obj{0}ENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符",
                objPrjTabENEx.TabName);
            
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4BL_Ts_CopyObjTo()
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
            {
                return "";
            }

            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把同一个类的对象,复制到另一个对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n{0}.CopyObjTo = function(obj{1}ENS , obj{1}ENT ) ",
                objPrjTabENEx.ClsName, 
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
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
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.sf_UpdFldSetStr = obj{0}ENS.UpdFldString; //sf_UpdFldSetStr",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4BL_Ts_GetSimObjFromObj()
        {
            //if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
            //{
            //    return "";
            //}
                StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把同一个类的对象,复制到另一个对象(简单)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n{0}.GetSimObjFromObj = function(obj{1}ENS)",
                objPrjTabENEx.ClsName, 
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nvar obj{0}ENT = new {1}();", objPrjTabENEx.TabName,
                         ImportClass.GetOutString(string.Format("cls{0}EN_Sim", objPrjTabENEx.TabName), this.Is4RJ));

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
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.sf_UpdFldSetStr = obj{0}ENS.UpdFldString; //专门用于记录某字段属性是否修改",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.sf_FldComparisonOp = obj{0}ENS.sf_FldComparisonOp; //专门用于记录条件对象某字段的比较运算符",
                         objPrjTabENEx.TabName);


            strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4BL_Ts_CopyObjFromSimObj()
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
            {
                return "";
            }

            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把同一个类的对象,从简化对象复制到对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源简化对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n{0}.CopyObjFromSimObj = function(obj{1}ENS, obj{1}ENT) ",
                objPrjTabENEx.ClsName,
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
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
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4BL_Ts_CopyObjFromSimObj4Upd()
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02)
            {
                return "";
            }

            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录，即脏字段才复制");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源简化对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n{0}.CopyObjFromSimObj4Upd = function(obj{1}ENS, obj{1}ENT )",
                objPrjTabENEx.ClsName, 
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n   const strsf_UpdFldSetStr = obj{0}ENS.sf_UpdFldSetStr;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n    const sstrFldSet = strsf_UpdFldSetStr.split('|');");
            //strCodeForCs.Append("\r\n   var arrFldSet : Array<string> = new Array<string>(sstrFldSet);");

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
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (sstrFldSet.indexOf(cls{0}EN.con_{1})  >= 0)",
                         objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                               objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                    strCodeForCs.Append("\r\n" + "}");

                }
            }
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
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
                Type t = typeof(BusinessLogicRJ4JavaScript);
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
            this.ClsName = string.Format("cls{0}BL", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }

    }
}
