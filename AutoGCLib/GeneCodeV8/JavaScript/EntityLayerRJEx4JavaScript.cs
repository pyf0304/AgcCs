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
    class EntityLayerRJEx4JavaScript : clsGeneCodeBase
    {
        public bool Is4RJ { get; set; }
        //protected CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();

        //public string ClsName;


        #region 构造函数

        public EntityLayerRJEx4JavaScript()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public EntityLayerRJEx4JavaScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
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
            
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsGeneralTab", objPrjTabENEx.TabName),
                FilePath = string.Format("clsgeneraltab", objFuncModule.FuncModuleEnName,
        objPrjTabENEx.TabName)
            });

            return arrImportClass;
        }

        /// <summary>
        /// 生成Entity层代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            this.Is4RJ = true;
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

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId,
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);


            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "ENEx";
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
               
                strCodeForCs.AppendFormat("\r\n" + "const {0} = /** @class **/ (function (_super) {{", //extends clsGeneralTab",
                    objPrjTabENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "__extends({0}, _super);", objPrjTabENEx.ClsName);

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

                strCodeForCs.AppendFormat("\r\n" + "}}({0}));",
                         ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
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


        /// <summary>
        /// 生成表字段名常量
        /// </summary>
        /// <returns></returns>
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
                Type t = typeof(EntityLayerRJEx4JavaScript);
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
            this.ClsName = string.Format("cls{0}ENEx", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
        public string Gen_ENEx_ClassConstructor1()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;            
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 构造函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            //function clsUserStateEN()
            //{
            //    var _this = _super.call(this) || this;
            //    _this.mintAttributeCount = 3;
            //    _this.AttributeName = new Array("UserStateId", "UserStateName", "Memo");
            //    _this.mstrUserStateId = ""; //用户状态号
            //    _this.mstrUserStateName = ""; //用户状态名
            //    _this.mstrMemo = ""; //备注
            //    return _this;
            //}
            strCodeForCs.AppendFormat("\r\n function {0}()",
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n var _this = _super.call(this) || this;");
            strCodeForCs.AppendFormat("\r\n" + "  return _this;");
            //strCodeForCs.Append("\r\n this.hmProperty =  new collections.Dictionary <string, boolean>();");
            //strCodeForCs.Append("\r\n this.SetInit();");
            //strCodeForCs.AppendFormat("\r\n cls{0}EN._CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n cls{0}EN._KeyFldName = \"{1}\";", objPrjTabENEx.TabName, objKeyField.FldName);

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 类公开的类属性
        /// </summary>
        /// <returns></returns>
        public string Gen_EN_ClsProperty()
        {
        //    Object.defineProperty(clsUserStateEN.prototype, "UserStateId", {
        //    /// <summary>
        //    /// 用户状态号(说明:;字段类型:char;字段长度:2;是否可空:False)
        //    /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
        //    /// </summary>
        //    get: function() {
        //            return this.mstrUserStateId;
        //        },
        //    /// <summary>
        //    /// 用户状态号(说明:;字段类型:char;字段长度:2;是否可空:False)
        //    /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
        //    /// </summary>
        //    set: function(value) {
        //            this.mstrUserStateId = value;
        //            this.hmProperty["UserStateId"] = true;
        //        },
        //    enumerable: true,
        //    configurable: true
        //});

            StringBuilder strCodeForCs = new StringBuilder();
            ///定义类属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n/// <summary>");
                strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength,
                    objField.ObjFieldTabENEx.IsNull,
                    objField.ObjFieldTabENEx.MemoInTab,
                     objField.ColCaption);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "Object.defineProperty({0}.prototype, \"{1}\", {{", objPrjTabENEx.ClsName, objField.FldName);

                strCodeForCs.Append("\r\n get: function ()");
                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\nreturn this.{0};",
                     objField.ObjFieldTabENEx.PrivPropName);
                strCodeForCs.Append("\r\n},");
                strCodeForCs.AppendFormat("\r\n set: function(value)");
                strCodeForCs.Append("\r\n{");
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "String")
                {
                    strCodeForCs.AppendFormat("\r\n this.{0} = value;",
                         objField.ObjFieldTabENEx.PrivPropName);
                    strCodeForCs.AppendFormat("\r\n    this.hmProperty[\"{0}\"] = true;",
                        objField.ObjFieldTabENEx.FldName);
                    //strCodeForCs.Append("\r\n}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n this.{0} = value;",
                            objField.ObjFieldTabENEx.PrivPropName);
                    strCodeForCs.AppendFormat("\r\n    this.hmProperty[\"{0}\"] = true;",
                   objField.ObjFieldTabENEx.FldName);
                }

                strCodeForCs.Append("\r\n},");
                strCodeForCs.AppendFormat("\r\n" + "    enumerable: true,");
                strCodeForCs.AppendFormat("\r\n" + "    configurable: true");
                strCodeForCs.Append("\r\n" + "});");
            }
            return strCodeForCs.ToString();
        }
        public string Gen_EN_SetCondFldValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.SetCondFldValue = function(strFldName, strFldValue, strComparisonOp){{                ", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "this[strFldName] = strFldValue;");
            strCodeForCs.Append("\r\n" + "if (Object.prototype.hasOwnProperty.call(this.dicFldComparisonOp, strFldName) == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "this.dicFldComparisonOp[strFldName] = strComparisonOp;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "this.dicFldComparisonOp[strFldName] = strComparisonOp;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);");
            strCodeForCs.Append("\r\n" + "}");
            ///定义类属性
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 类的私有变量,用于类属性的私有变量
        /// </summary>
        /// <returns></returns>
        public string Gen_EN_ClsPrivateVar()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///定义类中私有属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                strCodeForCs.Append("\r\n" + clsPrjTabFldBLEx.DefPrivateProperty(objPrjTabENEx.LangType, objField));
            }

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 类的字段名称常量,用于类属性名称的引用
        /// </summary>
        /// <returns></returns>
        public string Gen_EN_PropertyNameConst()
        {
        //    Object.defineProperty(clsUserStateEN, "con_UserStateId", {
        //    /// <summary>
        //    /// 常量:"UserStateId"
        //    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        //    /// </summary>
        //    get: function() { return "UserStateId"; } //用户状态号
        //    ,
        //    enumerable: true,
        //    configurable: true
        //});
            StringBuilder strCodeForCs = new StringBuilder();
            //定义类中属性名称常量
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// 常量:\"{0}\"", objField.ObjFieldTabENEx.FldName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "Object.defineProperty({0}, \"con_{1}\", {{", objPrjTabENEx.ClsName, objField.FldName);

                strCodeForCs.AppendFormat("\r\n get: function () {{return \"{0}\";}}  // {1}", objField.FldName, objField.ObjFieldTabENEx.Caption);
                strCodeForCs.Append("\r\n" + ",");
                strCodeForCs.AppendFormat("\r\n" + "    enumerable: true,");
                strCodeForCs.AppendFormat("\r\n" + "    configurable: true");
                strCodeForCs.Append("\r\n" + "});");
                
            }

            return strCodeForCs.ToString();
        }

    }
}
