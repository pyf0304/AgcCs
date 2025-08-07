using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.sql;



using AGC.Entity;

using AGC.BusinessLogic;
using AgcCommBase;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using System.Reflection;

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
    class RelaEntityLayer4CSharp : clsGeneCodeBase4Tab
    {
        #region 构造函数

      
        public RelaEntityLayer4CSharp(string strTabId,  string strPrjDataBaseId, string strPrjId)
          : base(strTabId,  strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
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
                         objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "EN";

            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.EntityLevel;

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


                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strCodeForCs.Append("\r\n" + "using System;"); //
                                                               //strCodeForCs.Append("\r\n" + "using System.Data; "); //
                                                               //strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.comm_db_obj;"); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;"); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                strCodeForCs.Append("\r\n" + "using System.Runtime.Serialization;");

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Entity",
                objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");



                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// 表{0}的关键字({1})的类型定义. 以便检查类型以及操作方便.", objPrjTabENEx.TabName, objKeyField.FldName);                
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public class K_{0}_{1}",
                    objKeyField.FldName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
             
                strCodeForCs.AppendFormat("\r\n" + "private {0} _value = {1};", objKeyField.CsType, 
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId()));
                //public static Key_UserStateId Key_None = new Key_UserStateId("");
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 关键字类型内面的值");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public {0} Value {{ get {{ return _value; }}set {{ _value = value;}} }}",
                    objKeyField.CsType);
                //public static Key_UserStateId Of(string strName)
                //    => IsValid(strName) ? new Key_UserStateId(strName) : Key_None;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 关键字类型构造函数");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"{0}\">表关键字</param>", objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "public K_{0}_{1}({2} {3})",
                    objKeyField.FldName, objPrjTabENEx.TabName,
                    objKeyField.CsType, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (IsValid({0})) Value = {0};",
                    objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                
                if (objKeyField.IsNumberType() == true)
                {
                    strCodeForCs.Append("\r\n" + "Value = 0;");
                }
                else
                {
                    if (objKeyField.CsType == "bool")
                    {
                        strCodeForCs.Append("\r\n" + "Value = false;");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "Value = null;");
                    }
                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "private static bool IsValid({0} {1})",
                    objKeyField.CsType, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                if (objKeyField.CsType != "bool")
                {
                    if (objKeyField.IsTabNullable == false)
                    {
                        if (objKeyField.IsNumberType() == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return false;", objKeyField.PrivFuncName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return false;", objKeyField.PrivFuncName);
                        }
                    }
                    if (objKeyField.IsNumberType() == false)
                    {
                        if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.Length != {1}) return false;",
                                objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldLength);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.Length > {1}) return false;",
                                objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldLength);
                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.IndexOf(' ') >= 0) return false;",
                                objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.IndexOf(')') >= 0) return false;",
                                objKeyField.PrivFuncName);
                            strCodeForCs.AppendFormat("\r\n" + "if ({0}.IndexOf('(') >= 0) return false;",
                                objKeyField.PrivFuncName);
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return false;",
                            objKeyField.PrivFuncName);
                    }
                }
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");
                //public static Key_UserStateId operator = (string strValue)
                //        => new Key_UserStateId(strValue);
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]");
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// <param name=\"value\">原类型表关键字</param>");
                strCodeForCs.AppendFormat("\r\n /// <returns>返回:[K_{0}_{1}]类型的对象</returns>", objKeyField.FldName, objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "public static implicit operator K_{0}_{1}({2} value)", objKeyField.FldName, objPrjTabENEx.TabName, objKeyField.CsType);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "return new K_{0}_{1}(value);", objKeyField.FldName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");


        strCodeForCs.Append("\r\n /// <summary>");
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n /// {0}({1}),专门针对SilverLight的实体类", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                //}
                //else
                //{
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                //}
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                //if (objPrjTabENEx.IsForSilverLight == false)
                //{
                strCodeForCs.Append("\r\n" + "[Serializable]");
                strCodeForCs.Append("\r\n" + "[DataContractAttribute]");
                //}
                if (string.IsNullOrEmpty(objPrjTabENEx.ParentClass) == true)
                {
                    strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName + " : clsEntityBase2");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public class  {0} : {1}",
                          objPrjTabENEx.ClsName ,
                         objPrjTabENEx.ParentClass);
                }
                strCodeForCs.Append("\r\n" + "{");

                //私有属性名-----和属性过程
                strCodeForCs.Append("\r\n" + "public const string _CurrTabName = \"" + objPrjTabENEx.TabName + "\"; //当前表名,与该类相关的表名");
                strCodeForCs.Append("\r\n" + "public const string _CurrTabKeyFldName_S = \"" + objPrjTabENEx.KeyFldNameLstStr + "\"; //当前表中的关键字名称,与该类相关的表中关键字名");
                //与属性名称相关的常量代码
                //if (objPrjTabENEx.I1sNeedGeneIndexer == true)
                //{
                    //与属性名称相关的代码
                    strCodeForCs.AppendFormat("\r\n" + "protected const int _AttributeCount = {0};",
                    objPrjTabENEx.arrFldSet.Count);
                    strTemp = "{";
                    foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                    {
                        if (strTemp == "{")
                        {
                            strTemp += "\"" + objField.ObjFieldTabENEx.FldName + "\"";
                        }
                        else
                        {
                            strTemp += ", \"" + objField.ObjFieldTabENEx.FldName + "\"";
                        }
                    }
                    strTemp += "}";
                    strCodeForCs.AppendFormat("\r\n" + "public static string[] _AttributeName = new string[] {0};",
                    strTemp);
                //}
                strCodeForCs.Append("\r\n" + "//以下是属性变量");



                //生成所有的函数

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                     strFuncName = objvFunction4GeneCodeEN.FuncName;
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

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



        /// <summary>
        /// 为字段设置条件字段值
        /// </summary>
        /// <returns></returns>
        public override string GenSetCondFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();


                //获取某一条件值的记录集-----------------------------;
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// 根据条件获取对象列表");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n /// <param name = \"strFldValue\">字段条件值</param>");
                strBuilder.Append("\r\n /// <param name = \"strComparisonOp\">比较运算符</param>");
                strBuilder.Append("\r\n /// <returns>void</returns>");
                strBuilder.Append("\r\npublic void SetCondFldValue(string strFldName, string strFldValue, string strComparisonOp)");
                strBuilder.Append("\r\n{");
                strBuilder.AppendFormat("\r\n" + "this[strFldName] = strFldValue;");
                strBuilder.AppendFormat("\r\n" + "if (dicFldComparisonOp.ContainsKey(strFldName) == false)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "dicFldComparisonOp.Add(strFldName, strComparisonOp);");
                strBuilder.Append("\r\n" + "}");
                strBuilder.AppendFormat("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "dicFldComparisonOp[strFldName] = strComparisonOp;");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n}");


            //获取某一条件值的记录集 ==  == = ;
            return strBuilder.ToString();
        }

       
        /// <summary>
        /// 生成Entity层代码
        /// </summary>
        /// <returns></returns>
        public override string A_GenEntityLayerCode_Sim(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
                objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "EN_Sim";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.EntityLevel;

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

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strCodeForCs.Append("\r\n" + "using System;"); //
                                                               //strCodeForCs.Append("\r\n" + "using System.Data; "); //
                                                               //strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                                                                            //strCodeForCs.Append("\r\n" + ""); //
                                                                            //strCodeForCs.Append("\r\n" + "using com.taishsoft.comm_db_obj;"); //
                                                                            //strCodeForCs.Append("\r\n" + "using com.taishsoft.common;"); //
                                                                            //strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                strCodeForCs.Append("\r\n" + "using System.Linq;");
                strCodeForCs.Append("\r\n" + "using System.Runtime.Serialization;");
                strCodeForCs.Append("\r\n" + "using System.Runtime.Serialization.Json;");
                strCodeForCs.Append("\r\n" + "using System.ServiceModel;");
                strCodeForCs.Append("\r\n" + "using System.ServiceModel.Web;");

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Entity",
                objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n /// {0}({1}),专门针对SilverLight的实体类", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                //}
                //else
                //{
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                //}
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                //if (objPrjTabENEx.IsForSilverLight == false)
                //{
                strCodeForCs.Append("\r\n" + "[Serializable]");
                strCodeForCs.Append("\r\n" + "[DataContractAttribute]");
                //}
                strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName + " ");
                strCodeForCs.Append("\r\n" + "{");

              //与属性名称相关的常量代码

                //与属性名称相关的代码
                //strCodeForCs.AppendFormat("\r\n" + "protected const int _AttributeCount = {0};",
                //objPrjTabENEx.arrFldSet.Count);
                //strTemp = "{";
                //foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                //{
                //  if (strTemp == "{")
                //  {
                //    strTemp += "\"" + objField.ObjFieldTabENEx.FldName + "\"";
                //  }
                //  else
                //  {
                //    strTemp += ", \"" + objField.ObjFieldTabENEx.FldName + "\"";
                //  }
                //}
                //strTemp += "}";
                //strCodeForCs.AppendFormat("\r\n" + "public static string[] _AttributeName = new string[] {0};",
                //strTemp);

                strCodeForCs.Append("\r\n" + "//以下是属性变量");

                //生成所有的函数

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

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


        /// <summary>
        /// 生成DAL(数据处理层)代码
        /// </summary>
        /// <returns></returns>
        public override string A_GenDALExCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
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
                objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "DAEx";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.DataAccessLevel;

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

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic; "); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");

                strCodeForCs.Append("\r\n" + "using com.taishsoft.commexception;");
                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;",
                objProject.PrjDomain); //

                strCodeForCs.Append("\r\n" + ""); //
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.DAL",
                objProject.PrjDomain);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public class  {0} : cls{1}DA", 
                    objPrjTabENEx.ClsName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

             
                strCodeForCs.Append("\r\n" + "//以下是属性变量");



                //生成所有的函数
                
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

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



        public string A_GenSQLCode4CreateTab(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
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

            StringBuilder strCreateTabCode = new StringBuilder();
            string strDatabaseOwner;
            string strFieldCode;
            string strRemark, strRemark0;
            string strFieldName;
            string strFieldType;
            //			string strFieldType0;
            string strIsNullable;       //, strIsNullable0;		// = " null ";
            string strPrimaryKey;       //, strPrimaryKey0;
            string strFieldLength, strFieldLength0;     //字段长度
            string strFldPrecision;
            ArrayList arrFieldCodes = new ArrayList();

            ///定义类中私有属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetAll)
            {
                //				strBuilder.Append("\r\n" +clsPrjTabFldBLEx.DefPrivateProperty(objPrjTabENEx.LangType, objField));

                ///计算字段名
                strFieldName = objField.ObjFieldTabENEx.FldName;
                ///计算字段类型
                strFieldType = objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///计算字段长度
                strFieldLength0 = objField.ObjFieldTabENEx.FldLength.ToString();
                strFldPrecision = objField.ObjFieldTabENEx.FldPrecision.ToString();
                if (strFieldLength0 == string.Empty)
                    strFieldLength = string.Empty;
                else if (strFieldType == "decimal" || strFieldType == "numeric")
                {
                    strFieldLength = string.Format("({0},{1})", strFieldLength0, strFldPrecision);
                }
                else
                {
                    strFieldLength = "(" + strFieldLength0 + ")";
                }
                //判断该数据类型是否需要长度
                if (clsSqlObject.IsNeedLength(strFieldType) == false)
                {
                    strFieldLength = string.Empty;
                }
                ///计算字段注释(即字段中文名称)
                strRemark0 = objField.ColCaption;
                if (strRemark0 == string.Empty)
                    strRemark = "/**/";
                else
                    strRemark = "/**" + strRemark0 + "*/";

                ///计算是否可空

                if (objField.IsTabNullable == true)
                {
                    strIsNullable = " Null";
                }
                else
                {
                    strIsNullable = " not Null";
                }
                ///计算主键
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strPrimaryKey = " primary key identity";
                    if (strFieldType == "bigint identity")
                    {
                        strFieldType = "bigint";
                    }
                }
                else if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strPrimaryKey = " primary key";
                }
                else
                {
                    strPrimaryKey = "";
                }
                if (strPrimaryKey == "")
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strIsNullable;
                }
                else
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strPrimaryKey;
                }
                arrFieldCodes.Add(strFieldCode);
            }
            string[] sstrFieldCode = (string[])(arrFieldCodes.ToArray(System.Type.GetType("System.String")));
            string strTabBodyCode = string.Join(",\r\r\n", sstrFieldCode);
            //clsProjectsENEx objProjects = new clsProjectsENEx(PrjId, true);

            strDatabaseOwner = objPrjDataBase.DatabaseOwner;
            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            strCreateTabCode.AppendFormat("CREATE table [{2}].[{0}] ({1}) \r\r\n", objPrjTabENEx.TabName, strTabBodyCode, strDatabaseOwner);
            strCreateTabCode.Append("ON [PRIMARY] ");
            //			strCreateTabCode.Append("\r\r\nGO");
            //						Response.Write(strCreateTabCode.ToString());
            return strCreateTabCode.ToString();

        }
        public override string Gen_GetSpecSQLObj()
        {
            //return "";
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取SQL服务器连接对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>SQL服务器连接对象</returns>");

            strBuilder.Append("\r\n public static clsSpecSQLforSql GetSpecSQLObj() ");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n clsSpecSQLforSql objSQL;");

            strBuilder.Append("\r\n //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串");
            strBuilder.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName  ==  true)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);");
            strBuilder.Append("\r\n return objSQL;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n //2. 如果类所指定的连接串非空,就用该类所指定的连接串");
            strBuilder.Append("\r\n //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串");
            strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}EN._ConnectString)  ==  true)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nobjSQL = new clsSpecSQLforSql();");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nelse");
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\nobjSQL = new clsSpecSQLforSql(cls{0}EN._ConnectString);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nreturn objSQL;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n");
            ///删除记录 == = ;
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
                Type t = typeof(RelaEntityLayer4CSharp);
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
        public override void GetClsName()
        {
            this.ClsName = string.Format("cls{0}EN", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
        public string GenClsProperty()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strTemp = "";
            ///定义类属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strTemp = clsPrjTabFldBLEx.ToString2(objField, objPrjTabENEx.LangType, false);
                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strBuilder.Append("\r\n" + strTemp);
                }
            }

            return strBuilder.ToString();
        }
        /// <summary>
        /// 类的私有变量,用于类属性的私有变量
        /// </summary>
        /// <returns></returns>
        public string Gen_Neo4JEN_ClsPrivateVar()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///定义类中私有属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.Append("\r\n" + clsPrjTabFldBLEx.DefPrivateProperty(objPrjTabENEx.LangType, objField));
            }

            return strBuilder.ToString();
        }
        /// <summary>
        /// 类的字段名称常量,用于类属性名称的引用
        /// </summary>
        /// <returns></returns>
        public string Gen_Neo4JEN_PropertyNameConst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //定义类中属性名称常量
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.Append("\r\n" + clsPrjTabFldBLEx.DefPropertyNameConst(objPrjTabENEx.LangType, objField, this.IsFstLcase, clsStackTrace.GetCurrClassFunction()));
            }

            return strBuilder.ToString();
        }
        /// <summary>
        /// 生成构造函数1
        /// </summary>
        /// <returns></returns>
        public string Gen_Neo4JEN_ClassConstructor1()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///类构造器----------------------------------------------;
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 构造函数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n SetInit();");
            strBuilder.Append("\r\n mbolIsCheckProperty = false;");
            strBuilder.AppendFormat("\r\n _CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.AppendFormat("\r\n lstKeyFldNames.Add(\"{0}\");", objField.ObjFieldTabENEx.FldName);
            }
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 生成构造函数2
        /// </summary>
        /// <returns></returns>
        public string Gen_Neo4JEN_ClassConstructor2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 构造函数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.AppendFormat("\r\n/// <param name = \"{0}\">关键字:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivFuncName,
                objKeyField.ColCaption);
            strBuilder.Append("\r\npublic " + objPrjTabENEx.ClsName + "(" + GetKeyPara() + ")");
            strBuilder.Append("\r\n {");
            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte[]":
                case "byte":
                    break;
                case "string":
                    strBuilder.AppendFormat("\r\n" + "{0} = {0}.Replace(\"'\", \"''\");",
                              objKeyField.PrivFuncName);
                    strBuilder.AppendFormat("\r\n" + "if ({0}.Length > {1})", objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldLength);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "throw new Exception(\"在表:{0}中,关键字长度不正确!\");", objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n" + "}");
                    strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0})  ==  true)", objKeyField.PrivFuncName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "throw new Exception(\"在表:{0}中,关键字不能为空 或 null!\");", objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n" + "}");
                    strBuilder.Append("\r\n" + "try");
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckStrSQL_Weak({0});", objKeyField.PrivFuncName);

                    strBuilder.Append("\r\n" + "}");
                    strBuilder.Append("\r\n" + "catch (Exception objException)");
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.Append("\r\n" + "throw new Exception(string.Format(\"在关键字中含有{" + "0" + "},请检查!\", objException.Message));");
                    strBuilder.Append("\r\n" + "}");
                    //strBuilder.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);

                    break;
                case "bool":
                    break;
                case "int":
                case "short":
                case "Int16":
                case "Int32":
                case "long":
                    strBuilder.AppendFormat("\r\n if ({0}  ==  0)", objKeyField.PrivFuncName);
                    strBuilder.Append("\r\n {");
                    strBuilder.Append("\r\n throw new Exception(\"关键字不能为0!\");");
                    strBuilder.Append("\r\n }");
                    break;
                case "float":
                case "double":
                    break;
                default:
                    break;
            }

            strBuilder.Append("\r\n" + GetKeyAssign());
            strBuilder.Append("\r\n SetInit();");
            strBuilder.Append("\r\n mbolIsCheckProperty = false;");
            strBuilder.AppendFormat("\r\n _CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strBuilder.AppendFormat("\r\n lstKeyFldNames.Add(\"{0}\");", objField.ObjFieldTabENEx.FldName);
            }
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 类索引器
        /// </summary>
        /// <returns></returns>
        public string Gen_Neo4JEN_ClsIndexer()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\npublic static int AttributeCount");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nreturn _AttributeCount;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            //类索引器,字符串参数
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// Indexer函数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"strAttributeName\">属性名</param>");
            strBuilder.Append("\r\npublic override object this[string strAttributeName]");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget");
            strBuilder.Append("\r\n{");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (strAttributeName  ==  con{0})",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PrivPropName);
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (strAttributeName  ==  con{0})",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PrivPropName);
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nset");
            strBuilder.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (strAttributeName  ==  con{0})",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};", objField.ObjFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true));
                    strBuilder.AppendFormat("\r\n AddUpdatedFld(con{0});", objField.ObjFieldTabENEx.FldName);

                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (strAttributeName  ==  con{0})",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]")
                    {
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n{0} = {1};",
                        objField.ObjFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true));
                        strBuilder.AppendFormat("\r\n AddUpdatedFld(con{0});", objField.ObjFieldTabENEx.FldName);

                    }
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");

            //类索引器,整型(INT)序号参数
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// Indexer函数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n/// <param name = \"intIndex\">属性序号</param>");

            strBuilder.Append("\r\npublic object this[int intIndex]");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget");
            strBuilder.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (con{0}  ==  AttributeName[intIndex])",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PrivPropName);
                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (con{0}  ==  AttributeName[intIndex])",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PrivPropName);
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\nreturn null;");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\nset");
            strBuilder.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strBuilder.AppendFormat("\r\nif (con{0}  ==  AttributeName[intIndex])",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n{0} = {1};",
                               objField.ObjFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true));
                    strBuilder.AppendFormat("\r\n AddUpdatedFld(con{0});", objField.ObjFieldTabENEx.FldName);

                    strBuilder.Append("\r\n}");
                }
                else
                {
                    strBuilder.AppendFormat("\r\nelse if (con{0}  ==  AttributeName[intIndex])",
                    objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n{");
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]")
                    {
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n{0} = {1};",
                              objField.ObjFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true));
                        strBuilder.AppendFormat("\r\n AddUpdatedFld(con{0});", objField.ObjFieldTabENEx.FldName);

                    }
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");

            return strBuilder.ToString();
        }
        /// <summary>
        /// 类公开的类属性
        /// </summary>
        /// <returns></returns>
        public string Gen_Neo4JEN_ClsPropertyV2()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strTemp = "";
            ///定义类属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strTemp = clsPrjTabFldBLEx.ToStringV2(objField, this.IsFstLcase, objPrjTabENEx.LangType, objPrjTabENEx.TabName);
                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strBuilder.Append("\r\n" + strTemp);
                }
            }

            return strBuilder.ToString();
        }
        /// <summary>
        /// 获取关键字Id(KeyId)
        /// </summary>
        /// <returns></returns>
        public string Gen_Neo4JEN_GetKeyId()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///类构造器----------------------------------------------;
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 获取关键字Id(KeyId)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n public override string _KeyId");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n get");
            strBuilder.Append("\r\n {");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n  return {0};", objKeyField.ObjFieldTabENEx.PrivPropName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n  return {0}.ToString();", objKeyField.ObjFieldTabENEx.PrivPropName);
            }
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 获取名称字段值(NameValue)
        /// </summary>
        /// <returns></returns>
        public string Gen_Neo4JEN_GetNameValue()
        {
            if (objPrjTabENEx.objPrjTabFld4NameFld == null) return "";
            StringBuilder strBuilder = new StringBuilder();

            ///类构造器----------------------------------------------;
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 获取名称字段值(NameValue)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n public override string _NameValue");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n get");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n  return {0};", objPrjTabENEx.objPrjTabFld4NameFld.ObjFieldTabENEx.PrivPropName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
    }
}
