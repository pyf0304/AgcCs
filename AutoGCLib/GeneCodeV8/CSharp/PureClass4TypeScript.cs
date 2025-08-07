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
    class PureClass4TypeScript : clsGeneCodeBase4Tab
    {
        //protected CommProgramSet.clsComm objComm = new CommProgramSet.clsComm();

        //public string ClsName;
 

        #region 构造函数

        public PureClass4TypeScript(string strTabId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strPrjDataBaseId, strPrjId)
        {

            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        #endregion
   

        /// <summary>
        /// 生成Entity层代码
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

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);


            objPrjTabENEx.ClsName =  objPrjTabENEx.TabName ;
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.EntityLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".ts";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".ts";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));


                strCodeForCs.Append("\r\n /// <summary>");

                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                if (string.IsNullOrEmpty(objPrjTabENEx.ParentClass) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from './{0}.js';", objPrjTabENEx.ParentClass);
                }
                if (string.IsNullOrEmpty(objPrjTabENEx.ParentClass) == true)
                {
                    strCodeForCs.Append("\r\n" + "export class " + objPrjTabENEx.ClsName + " ");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "export class  {0} extends {1}",
                          objPrjTabENEx.ClsName,
                         objPrjTabENEx.ParentClass);
                }
                            
                strCodeForCs.Append("\r\n" + "{");
               


                //私有属性名-----和属性过程
                strCodeForCs.AppendFormat("\r\n" + "public static _CurrTabName = \"{0}\"; //当前表名,与该类相关的表名", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "public static _KeyFldName = \"{0}\"; //当前表中的关键字名称,与该类相关的表中关键字名", objPrjTabENEx.KeyFldNameLstStr);
                //与属性名称相关的常量代码

                //与属性名称相关的代码
                strCodeForCs.AppendFormat("\r\n" + "public mintAttributeCount = {0};",
                objPrjTabENEx.arrFldSet.Count);
                strTemp = "";
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (strTemp == "")
                    {
                        strTemp += "\"" + objField.ObjFieldTabENEx.FldName + "\"";
                    }
                    else
                    {
                        strTemp += ", \"" + objField.ObjFieldTabENEx.FldName + "\"";
                    }
                }

                strCodeForCs.AppendFormat("\r\n" + "public AttributeName = new Array({0});",
                strTemp);

                strCodeForCs.Append("\r\n" + "//以下是属性变量");

                //生成所有的函数

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }

                //strCodeForCs.Append("\r\n" + "this.init();");
                strCodeForCs.Append("\r\n" + "};");
   
 

                clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objPrjTabENEx.CodeTypeId);
                var arrCodeTypeCache = clsCodeTypeBL.GetObjLstCache();
                string strCodeTypeENName_Sim = objCodeType.CodeTypeENName + "_Sim";
                clsCodeTypeEN objCodeType_Sim = arrCodeTypeCache.Find(x => x.ProgLangTypeId == objCodeType.ProgLangTypeId && x.CodeTypeENName == strCodeTypeENName_Sim);
                if (objCodeType_Sim != null)
                {
                    IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Sim =
             clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                         objPrjTabENEx.LangType, objCodeType_Sim.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
               .OrderBy(x => x.OrderNum);

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "export class  {0}_Sim", objPrjTabENEx.ClsName);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.Append("\r\n" + "//以下是属性变量");

                    //生成所有的函数

                    foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_Sim)
                    {
                        strFuncName = objvFunction4GeneCodeEN.FuncName;
                        clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    strCodeForCs.Append("\r\n" + "public sfUpdFldSetStr = \"\";     //专门用于记录某字段属性是否修改");
                    strCodeForCs.Append("\r\n" + "public sfFldComparisonOp = \"\";     //专门用于记录条件对象某字段的比较运算符");
                    strCodeForCs.Append("\r\n" + "};");
                }

                strTemp = A_GeneFuncCodeByFuncName("Gen_PC_GeneEnumConstList");
                strCodeForCs.Append(strTemp);
                //objvFunction4GeneCodeEN21 = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4BL_GeneEnumConstList4Field");

                strTemp = A_GeneFuncCodeByFuncName("Gen_PC_GeneEnumConstList4Field");
                strCodeForCs.Append(strTemp);

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
      
            }
            return strCodeForCs.ToString();
        }

        public string Gen_PC_GeneEnumConstList()
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
                strBuilder.AppendFormat("\r\n export class enum{0}",
                       objPrjTabENEx.TabName,
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strBuilder.Append("\r\n{");

                foreach (DataRow objRow in objDT.Rows)
                {
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// {0}", objRow[strNamedFieldName]);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n" + "static readonly {0}_{1} = \"{1}\";",
                        objRow[strEnglishNameFieldName].ToString().Replace(" ", "_"), objRow[strKeyFieldName]);
                }
            }
            else
            {
                strBuilder.AppendFormat("\r\n export enum enum{0} ",
                objPrjTabENEx.TabName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strBuilder.Append("\r\n{");

                foreach (DataRow objRow in objDT.Rows)
                {
                    strBuilder.AppendFormat("\r\n" + "{0}_{1} = {1}, //{2}",                         
                        objRow[strEnglishNameFieldName].ToString().Replace(" ", "_"), 
                        objRow[strKeyFieldName],
                        objRow[strNamedFieldName]);
                }
            }
            strBuilder.Append("\r\n}");

            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public string Gen_PC_GeneEnumConstList4Field()
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

                strBuilder.AppendFormat("\r\n export class enum{0}_{1}",
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
                    strBuilder.AppendFormat("\r\n" + "static readonly con{0} = \"{0}\";",
                        strFieldValue);
                }

                strBuilder.Append("\r\n}");
            }
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }


        public string A_GeneFuncCodeByFuncName(string strFuncName)
        {

            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBLEx.GetObjByFuncNameCache(strFuncName);
            try
            {
                string strCode = "";
                Type t = typeof(PureClass4TypeScript);
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

        /// <summary>
        /// 类公开的类属性
        /// </summary>
        /// <returns></returns>
        public string Gen_SimEN_ClsProperty()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///定义类属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n/**");
                strBuilder.AppendFormat("\r\n {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength,
                    objField.ObjFieldTabENEx.IsNull,
                    objField.ObjFieldTabENEx.MemoInTab,
                     objField.ColCaption);
                strBuilder.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n*/");
                strBuilder.AppendFormat("\r\n public {1}: {0} = {2};",
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.InitValue_TypeScript);

                strBuilder.Append("\r\n");
            }
            return strBuilder.ToString();
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
                 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
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
                Type t = typeof(PureClass4TypeScript);
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
            this.ClsName = string.Format("cls{0}EN", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
        public string Gen_PC_ClassConstructor1()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;            
            strCodeForCs.Append("\r\n/**");
            strCodeForCs.Append("\r\n 构造函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n*/");
            strCodeForCs.AppendFormat("\r\n constructor()",
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n super();");
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
        public string Gen_PC_ClsProperty()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///定义类属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n/**");
                strCodeForCs.AppendFormat("\r\n {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength,
                    objField.ObjFieldTabENEx.IsNull,
                    objField.ObjFieldTabENEx.MemoInTab,
                     objField.ColCaption);
                strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n*/");
                strCodeForCs.AppendFormat("\r\n public get {1} ()",
                    objField.JavaType,
                    objField.ObjFieldTabENEx.FldName);
                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\nreturn this.{0};",
                     objField.ObjFieldTabENEx.PrivPropName);
                strCodeForCs.Append("\r\n};");
                strCodeForCs.AppendFormat("\r\n/**");
                strCodeForCs.AppendFormat("\r\n * {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength,
                    objField.ObjFieldTabENEx.IsNull,
                    objField.ObjFieldTabENEx.MemoInTab,
                     objField.ColCaption);
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n*/");
                strCodeForCs.AppendFormat("\r\n public set {0} (value: {1})",
                        objField.ObjFieldTabENEx.FldName,
                         objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType);
                strCodeForCs.Append("\r\n{");
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "String")
                {
                    //strCodeForCs.AppendFormat("\r\nif (value  ==  \"\")");
                    //strCodeForCs.Append("\r\n{");
                    //if (bolIsSimVersion  ==  false)
                    //{
                    //    strCodeForCs.AppendFormat("\r\nmintErrNo = 1;");
                    //}
                    //strCodeForCs.Append("\r\n}");
                    //strCodeForCs.AppendFormat("\r\nelse");
                    //strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\n this.{0} = value;",
                         objField.ObjFieldTabENEx.PrivPropName);
                          //strCodeForCs.Append("\r\n}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n this.{0} = value;",
                            objField.ObjFieldTabENEx.PrivPropName);
                }

                strCodeForCs.Append("\r\n};");
                strCodeForCs.Append("\r\n");
            }
            return strCodeForCs.ToString();
        }
        public string Gen_PC_SetCondFldValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "public SetCondFldValue(strFldName: string, strFldValue: any, strComparisonOp: string): void {                ");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SetCondFldValue.name;");
            
            strCodeForCs.Append("\r\n" + "this[strFldName] = strFldValue;");
            strCodeForCs.Append("\r\n" + "if (Object.prototype.hasOwnProperty.call(this.dicFldComparisonOp, strFldName) == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "this.dicFldComparisonOp[strFldName] = strComparisonOp;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "this.dicFldComparisonOp[strFldName] = strComparisonOp;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "this.sfFldComparisonOp = JSON.stringify(this.dicFldComparisonOp);");
            strCodeForCs.Append("\r\n" + "}");
            ///定义类属性
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 类的私有变量,用于类属性的私有变量
        /// </summary>
        /// <returns></returns>
        public string Gen_PC_ClsPrivateVar()
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
        public string Gen_PC_PropertyNameConst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //定义类中属性名称常量
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.Append("\r\n" + clsPrjTabFldBLEx.DefPropertyNameConst(objPrjTabENEx.LangType,  objField, this.IsFstLcase, clsStackTrace.GetCurrClassFunction()));
            }

            return strCodeForCs.ToString();
        }

    }
}
