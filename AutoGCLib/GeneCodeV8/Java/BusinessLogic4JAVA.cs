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
    partial class BusinessLogic4JAVA : clsGeneCodeBase4Tab
    {

        #region 构造函数

        public BusinessLogic4JAVA(string strTabId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
        }
        #endregion

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
        /// 生成业务逻辑层代码－－C#.NET
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
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
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(1);
            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);



            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "BL";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.BusinessLogicLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".java";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".java";
            objPrjTabENEx.FileName = strClassFName;

            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4Java(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                //类名开始
                strCodeForCs.AppendFormat("\r\n" + "package {0}.GC.L2_Business.{1};",
                  objProjectsENEx.JavaPackageName, objFuncModule.FuncModuleEnName4GC());

                strCodeForCs.AppendFormat("\r\n" + "import {0}.GC.L0Entity.{2}.cls{1}EN;",
                   objProjectsENEx.JavaPackageName,
                   objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC());
                strCodeForCs.Append("\r\n" + "import com.taishsoft.util.clsDate;");

                strCodeForCs.Append("\r\n" + "import org.json.JSONArray;");
                strCodeForCs.Append("\r\n" + "import org.json.JSONObject;");

                strCodeForCs.Append("\r\n" + "import java.util.List;");
                strCodeForCs.Append("\r\n" + "import java.util.ArrayList;");





                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                clsSQLDSTypeEN objSQLDSType = clsSQLDSTypeBL.GetObjBySqlDsTypeIdCache(objPrjTabENEx.SqlDsTypeId);
                strCodeForCs.AppendFormat("\r\n /// 数据源类型:{0}",
                objSQLDSType.SqlDsTypeName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// 单项的XML结点标签");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.AppendFormat("\r\n" + "public final String itemXmlNode = \"{0}ListItem\";",
                //objPrjTabENEx.TabName);
                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// 列表的XML结点标签");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.AppendFormat("\r\n" + "public final String listXmlNode = \"{0}List\";",
                //objPrjTabENEx.TabName);
                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// 集合的XML结点标签");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.Append("\r\n" + "public final String itemsXmlNode = \"Items\";");

                ////私有属性名-----和属性过程
                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.AppendFormat("\r\n" + "public final List<cls{0}EN> arr{0}ObjLstCache = null;",
                //       objPrjTabENEx.TabName);

                //strCodeForCs.AppendFormat("\r\n /// <summary>");
                //strCodeForCs.AppendFormat("\r\n /// 从缓存中查找失败的次数");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.AppendFormat("\r\n /// </summary>");
                //strCodeForCs.AppendFormat("\r\n" + "private final int intFindFailCount = 0;");


                //生成所有的函数


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
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
                        string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
                                objException.Message,
                                clsStackTrace.GetCurrClassFunction());
                        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                        throw new Exception(strMsg);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }


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

      
        public string A_GeneFuncCode_Java(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(BusinessLogic4JAVA);
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
                string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
                        objException.Message,
                        clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }
                
        /// <summary>
        /// 把一个JSON串转化为一个对象.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Java_getRecObjByJSONStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 把一个JSON串转化为一个对象");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strJSON\">需要转化的JSON串</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>返回一个生成的对象</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjByJSONStr(String strJSON)",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
              objPrjTabENEx.TabName);


            strBuilder.AppendFormat("\r\n" + "JSONObject json;");
            strBuilder.AppendFormat("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "json = new JSONObject(strJSON);");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(json.getString(\"{1}\"));",
                //     objPrjTabENEx.TabName,
                //     objField.ObjFieldTabENEx.FldName
                //    );
                string strResult = SetPropertyByJson_Java(objField);
                strBuilder.Append(strResult);
            }
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
                    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
              
        
        /// <summary>
        /// 把一个JSON串转化为一个对象.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Java_getJSONStrByRecObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 把一个对象转化为一个JSON串");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strJSON\">需要转化的JSON串</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>返回一个生成的对象</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static String GetJSONStrByObj(cls{0}EN obj{0}EN)",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "JSONObject json = new JSONObject();");
            strBuilder.AppendFormat("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "json.put(\"{1}\", obj{0}EN.get{1}());",
                     objPrjTabENEx.TabName,
                     objField.ObjFieldTabENEx.FldName
                    );
            }
            strBuilder.AppendFormat("\r\n" + "String strUpdFldNameStr = obj{0}EN.getUpdFldString();",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "json.put(\"sfUpdFldSetStr\", strUpdFldNameStr);//把该对象已经修改过的字段名集合加到JSON串中",
              objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return \"\";");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return json.toString();");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 把一个JSON串转化为一个对象列表.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Java_getObjLstByJSONStr()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 把一个JSON串转化为一个对象列表");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strJSON\">需要转化的JSON串</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>返回一个生成的对象列表</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> GetObjLstByJSONStr(String strJSON)",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
              objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = new ArrayList<>();",
              objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "JSONArray jsonArray = new JSONArray(strJSON);",
              objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "json = new JSONObject(strJSON);");
            strBuilder.AppendFormat("\r\n" + "for (int i = 0; i < jsonArray.length(); i++)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "JSONObject json = jsonArray.getJSONObject(i);");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                  objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(json.getString(\"{1}\"));",
                //     objPrjTabENEx.TabName,
                //     objField.ObjFieldTabENEx.FldName
                //    );
                string strResult = SetPropertyByJson_Java(objField);
                strBuilder.Append(strResult);
            }
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst.add(obj{0}EN);",
              objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        private string SetPropertyByJson_Java(clsPrjTabFldENEx objField)
        {
            StringBuilder strBuilder = new StringBuilder();
            switch (objField.JavaType)
            {
                case "String":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(json.getString(\"{1}\"));",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "long":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(json.getLong(\"{1}\"));",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "int":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(json.getInt(\"{1}\"));",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "short":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}((short)json.getInt(\"{1}\"));",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "double":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(json.getDouble(\"{1}\"));",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "float":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}((float)json.getDouble(\"{1}\"));",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "boolean":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(json.getBoolean(\"{1}\"));",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Date":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(clsDate.StrToDate(json.getString(\"{1}\")));",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                default:
                    string strMsg = string.Format("Java数据类型:[{1}]在switch中没有处理。({0})",
                        clsStackTrace.GetCurrClassFunction(),
                        objField.JavaType);
                    throw new Exception(strMsg);

            }
            return strBuilder.ToString();
        }
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
              string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(BusinessLogic4JAVA);
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
