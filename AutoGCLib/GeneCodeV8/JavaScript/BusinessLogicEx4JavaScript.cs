using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
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
    partial class BusinessLogicEx4JavaScript : clsGeneCodeBase
    {
        #region 构造函数

        public BusinessLogicEx4JavaScript()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            clsErrorIdManageBLEx.arrErrIdLst_Cache = null;
        }
        public BusinessLogicEx4JavaScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            clsErrorIdManageBLEx.arrErrIdLst_Cache = null;
        }
        #endregion

     
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



            objPrjTabENEx.ClsName = "js" + objPrjTabENEx.TabName + "BLEx";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.JavaScriptLevel;

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

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx));

                //类名开始

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                clsSQLDSTypeEN objSQLDSType = clsSQLDSTypeBL.GetObjBySqlDsTypeId_Cache(objPrjTabENEx.SqlDsTypeId);
                strCodeForCs.AppendFormat("\r\n /// 数据源类型:{0}",
                objSQLDSType.SqlDsTypeName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + " /// <reference path=\"../PubFun/tzDictionary.js\" />");
                strCodeForCs.Append("\r\n" + " /// <reference path=\"../PubFun/jsString.js\" />");

                strCodeForCs.Append("\r\n" + "const VirtualRootPath = getVirtualRootPath_web();//该函数存在于/js/PubFun/jsPubFun.js文件中");

                strCodeForCs.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzDictionary.js\");");
                strCodeForCs.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsString.js\");");

                strCodeForCs.AppendFormat("\r\n" + "const cls{0}BLEx = function()", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 单项的XML结点标签");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "const itemXmlNode = \"{0}ListItem\";",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 列表的XML结点标签");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "const listXmlNode = \"{0}List\";",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 集合的XML结点标签");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "const itemsXmlNode = \"Items\";");

                //私有属性名-----和属性过程
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = new Array();",
                       objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// 从缓存中查找失败的次数");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "const intFindFailCount = 0;");

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


        public string A_GeneFuncCode_JavaScript(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(BusinessLogicEx4JavaScript);
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
        /// 把一个JSON串转化为一个对象.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_JavaScript_getRecObjByJSONStr()
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
            strBuilder.AppendFormat("\r\n" + "this.GetObjByJSONStr = function(strJSON)",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const pobj{0}EN = new cls{0}EN();",
              objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "if (strJSON === \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return pobj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            //  var data : NSData! = NSJSONSerialization.dataWithJSONObject(strJSON, options: []);
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN = JSON.parse(strJSON);", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch(objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return pobj{0}EN;",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return pobj{0}EN;",
                    objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        /// <summary>
        /// 把一个JSON串转化为一个对象.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_JavaScript_getJSONStrByRecObj()
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
            strBuilder.AppendFormat("\r\n" + "this.GetJSONStrByObj = function(pobj{0}EN)",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "pobj{0}EN.sf_UpdFldSetStr = pobj{0}EN.getUpdFldString();",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "const strJson;");
            strBuilder.Append("\r\n" + "const jsonData;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strJson = JSON.stringify(pobj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(objException.message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return strJson;");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 把一个JSON串转化为一个对象.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_getDictionaryObjByRecObj_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 把一个对象转化为一个JSON串");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strJSON\">需要转化的JSON串</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>返回一个生成的对象</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "this.GetDictionaryObjByObj = function(pobj{0}EN)",
                  objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "pobj{0}EN.sf_UpdFldSetStr = pobj{0}EN.getUpdFldString();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "const objDict;");
            strBuilder.Append("\r\n" + "objDict = NSMutableDictionary();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
                {
                    case "Int32":
                        strBuilder.AppendFormat("\r\n" + "objDict.setValue(String(pobj{0}EN.{1}), forKey: cls{0}EN.con_{1});",
                             objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                        break;
                    default:
                        strBuilder.AppendFormat("\r\n" + "objDict.setValue(pobj{0}EN.{1}, forKey: cls{0}EN.con_{1});",
                             objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                        break;
                }
            }
            strBuilder.AppendFormat("\r\n" + "objDict.setValue(pobj{0}EN.sf_UpdFldSetStr, forKey: \"sf_UpdFldSetStr\");",
                 objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDict;");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 把一个JSON串转化为一个对象列表.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_JavaScript_getObjLstByJSONStr()
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
            strBuilder.AppendFormat("\r\n" + "this.GetObjLstByJSONStr = function(strJSON)",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = new Array();",
              objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "if (strJSON === \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = JSON.parse(strJSON);", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch(objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                    objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        private string SetPropertyByJson_JavaScript(clsPrjTabFldENEx objField)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n" + "if (jsonAllKeys.containsObject(\"{0}\") == true)",
                 objField.ObjFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "{");
            //  strBuilder.Append("\r\n" + "//print(\"Memo1 is Exist!\");");
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
            {
                case "String":
                    strBuilder.AppendFormat("\r\n" + "pobj{0}EN.{1} = String(json.objectForKey(\"{1}\")!);",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Int32":
                    strBuilder.AppendFormat("\r\n" + "pobj{0}EN.{1} = Int32(String(json.objectForKey(\"{1}\")!))!;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Int":
                    strBuilder.AppendFormat("\r\n" + "pobj{0}EN.{1} = Int(String(json.objectForKey(\"{1}\")!))!;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Bool":
                    strBuilder.AppendFormat("\r\n" + "pobj{0}EN.{1} = clsPubFun.myBool(json.objectForKey(\"{1}\")!);",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                default:
                    string strMsg = string.Format("Swift数据类型在switch中没有处理。({0})", clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_4BL_CheckPropertyNew_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n this.CheckPropertyNew = function(pobj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            string strFunctionName = string.Format("CheckPropertyNew", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "字段[{1}|{0}]不能为空(NULL)!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");
            strBuilder.Append("\r\n//检查字段非空， 即数据表要求非常非空的字段，不能为空！");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") return "";//只读就不需要检查
                if (objField.IsTabNullable == false && objField.FieldTypeId != "02")
                {
                    strBuilder.Append(inGen_CheckNull4Field(objField, strErrId, strFunctionName));
                }
            }

            //检查属性长度代码;
            strBuilder.Append(inGen_CheckFieldLength("CheckPropertyNew"));

            //检查字段的数据类型是否正确
            strBuilder.Append(inGen_CheckDataType(strFunctionName));

            //检查外键字段长度;

            strBuilder.Append(inGen_CheckFieldForeighKey("CheckPropertyNew"));


            strBuilder.Append("\r\n//设置说明该对象已经检查过了，后面不需要再检查，即非法！");

            strBuilder.AppendFormat("\r\n pobj{0}EN.setIsCheckProperty(true);", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");


            ///检查类中属性是否正确-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n this.CheckProperty4Update = function(pobj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            //检查属性长度代码;

            strBuilder.Append(inGen_CheckFieldLength("CheckProperty4Update"));

            //检查数据类型是否正确
            strBuilder.Append(inGen_CheckDataType("CheckProperty4Update"));

            //检查主键是否Null
            strFunctionName = string.Format("CheckProperty4Update", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "字段[{1}|{0}]不能为空(NULL)!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.Append("\r\n//检查主键是否为Null或者空！");

            strBuilder.Append(inGen_CheckNull4Field(objPrjTabENEx.objKeyField0, strErrId, "CheckProperty4Update"));
            ///检查外键字段长度;

            strBuilder.Append(inGen_CheckFieldForeighKey("CheckProperty4Update"));

            strBuilder.AppendFormat("\r\n pobj{0}EN.setIsCheckProperty(true);", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");

            ///检查类中属性是否正确 ==  ==  == = ;
            return strBuilder.ToString();
        }

        private string inGen_CheckDataType(string strFunctionName)
        {
            StringBuilder strBuilder = new StringBuilder();
            //检查字段的数据类型是否正确
            //   string strFunctionName = string.Format("CheckPropertyNew", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "字段[{0}|{1}]的值：【{2}】,非法，应该为数值型!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strBuilder.AppendFormat("\r\n" + "//检查字段的数据类型是否正确");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "pobj" + objPrjTabENEx.TabName + "EN");

                string strDataTypeName = "";
                switch (objField.JavaType)
                {
                    case "String":
                        strBuilder.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isString(pobj{0}EN.get{1}()) === false)",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "字符型";
                        break;
                    case "long":
                        strBuilder.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.get{1}()) === false)",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "长整型";
                        break;
                    case "int":
                        strBuilder.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.get{1}()) === false)",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "整型";
                        break;
                    case "double":
                        strBuilder.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.get{1}()) === false)",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "双精度";
                        break;
                    case "float":
                        strBuilder.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.get{1}()) === false)",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "浮点型";
                        break;
                    case "short":
                        strBuilder.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isNumber(pobj{0}EN.get{1}()) === false)",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "短整型";
                        break;
                    case "boolean":
                        strBuilder.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isBoolean(pobj{0}EN.get{1}()) === false)",
                         objPrjTabENEx.TabName,
                         objField.ObjFieldTabENEx.PropertyName(),
                            strPrivPropNameWithObjectName);
                        strDataTypeName = "布尔型";
                        break;
                    case "Date":
                        strBuilder.AppendFormat("\r\n" + "if (null !== {2} && undefined !== {2} && tzDataType.isBoolean(pobj{0}EN.get{1}()) === false)",
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
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n throw String.format(\"(errid:{7})字段[{2}({3})|{0}({4})]的值:[{{0}}], 非法，应该为{8}!(cls{3}BL:{9})\", pobj{3}EN.{4});",
                           objField.ColCaption,
                           objField.ObjFieldTabENEx.FldLength,
                           objPrjTabENEx.TabCnName,
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           "{", "}",
                           strErrId,
                           strDataTypeName,
                           strFunctionName);
                strBuilder.Append("\r\n" + "}");
            }
            return strBuilder.ToString();
        }
        private string inGen_CheckNull4Field(clsPrjTabFldENEx objField, string strErrId, string strFunctionName)
        {
            StringBuilder strBuilder = new StringBuilder();

            string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "pobj" + objPrjTabENEx.TabName + "EN");
            string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "pobj" + objPrjTabENEx.TabName + "EN");


            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
            {
                return "";
            }

            if (objField.FldOpTypeId == "0003")
            {

                strBuilder.AppendFormat("\r\n if (null === {0} ",
                    strPrivPropNameWithObjectName4Get);

                strBuilder.AppendFormat("\r\n || IsNullOrEmpty({0}) == false && {0}.ToString()  ===  \"\" ",
                    strPrivPropNameWithObjectName4Get);
                if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                {
                    strBuilder.AppendFormat("\r\n || IsNullOrEmpty({0}) == false && {1}.toString()  ===  \"0\"",
                        strPrivPropNameWithObjectName4Get,
                        strPrivPropNameWithObjectName4Get);
                }
                strBuilder.Append("\r\n )");
                strBuilder.Append("\r\n{");
                strBuilder.AppendFormat("\r\n throw \"(errid:{2})字段[{1}|{0}]不能为空(NULL)!(cls{3}BL:{4})\";",
                        objField.ColCaption,
                        objPrjTabENEx.TabCnName,
                        strErrId,
                        objPrjTabENEx.TabName,
                        strFunctionName);
                strBuilder.Append("\r\n}");
            }
            else
            {

                strBuilder.AppendFormat("\r\nif (null === {0} ", strPrivPropNameWithObjectName);
                strBuilder.AppendFormat("\r\n || IsNullOrEmpty({0}) == false && {0}.toString()  ===  \"\"", strPrivPropNameWithObjectName);
                if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                {
                    strBuilder.AppendFormat("\r\n || IsNullOrEmpty({0}) == false && {0}.toString()  ===  \"0\" ", strPrivPropNameWithObjectName);
                }
                strBuilder.Append(")");
                strBuilder.Append("\r\n{");
                strBuilder.AppendFormat("\r\n throw \"(errid:{2})字段[{1}|{0}]不能为空(NULL)!(cls{3}BL:{4})\";",
                            objField.ColCaption,
                            objPrjTabENEx.TabCnName,
                            strErrId,
                            objPrjTabENEx.TabName,
                            strFunctionName);
                strBuilder.Append("\r\n}");
            }

            return strBuilder.ToString();
        }
        private string inGen_CheckFieldLength(string strFunctionName)
        {
            StringBuilder strBuilder = new StringBuilder();
            //string strFunctionName = string.Format(strFuncName, objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "字段[{2}({3})|{0}({4})]的长度不能超过{1}!值:{{0}}";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");
            strBuilder.Append("\r\n//检查字段长度， 若字符型字段长度超出规定的长度，即非法！");


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
                        strBuilder.AppendFormat("\r\nif (IsNullOrEmpty({0}) == false && GetStrLen({0}) > {1})", strPrivPropNameWithObjectName4Get, objField.ObjFieldTabENEx.FldLength);
                        strBuilder.Append("\r\n{");
                        strBuilder.AppendFormat("\r\n throw(String.format(\"(errid:{7})字段[{2}({3})|{0}({4})]的长度不能超过{1}!值:{{0}}(cls{3}BL:{8})\", pobj{3}EN.{4}));",
                        objField.ColCaption,
                        objField.ObjFieldTabENEx.FldLength.ToString().Trim(),
                        objPrjTabENEx.TabCnName,
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName,
                        "{", "}",
                        strErrId,
                        strFunctionName);
                        strBuilder.Append("\r\n}");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\nif (IsNullOrEmpty({0}) == false && GetStrLen({0}) > {1})",
                             strPrivPropNameWithObjectName,
                              objField.ObjFieldTabENEx.FldLength);
                        strBuilder.Append("\r\n{");
                        strBuilder.AppendFormat("\r\n throw String.format(\"(errid:{7})字段[{2}({3})|{0}({4})]的长度不能超过{1}!值:{{0}}(cls{3}BL:{8})\", pobj{3}EN.{4});",
                        objField.ColCaption,
                        objField.ObjFieldTabENEx.FldLength.ToString().Trim(),
                        objPrjTabENEx.TabCnName,
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName,
                        "{", "}",
                        strErrId,
                        strFunctionName);
                        strBuilder.Append("\r\n}");
                    }
                }
            }

            return strBuilder.ToString();
        }


        private string inGen_CheckFieldForeighKey(string strFunctionName)
        {
            StringBuilder strBuilder = new StringBuilder();

            //string strFunctionName = string.Format("CheckPropertyNew", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "字段[{2}|{0}]作为外键字段,长度应该为{1}!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");
            strBuilder.Append("\r\n//检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！");

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
                        strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty({0})  ==  false && GetStrLen({0}) != {1})",
                             strPrivPropNameWithObjectName4Get,
                              objField.ObjFieldTabENEx.FldLength);
                        strBuilder.Append("\r\n{");
                        strBuilder.AppendFormat("\r\n throw \"(errid:{3})字段[{2}|{0}]作为外键字段,长度应该为{1}!(cls{4}BL:CheckPropertyNew)\";",
                              objField.ColCaption,
                              objField.ObjFieldTabENEx.FldLength,
                              objPrjTabENEx.TabCnName,
                              strErrId,
                              objPrjTabENEx.TabName);
                        strBuilder.Append("\r\n}");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\nif (string.IsNullOrEmpty({0})  ==  false && GetStrLen({0}) !=  {1})",
                            strPrivPropNameWithObjectName,
                            objField.ObjFieldTabENEx.FldLength);
                        strBuilder.Append("\r\n{");
                        strBuilder.AppendFormat("\r\n throw \"(errid:{3})字段[{2}|{0}]作为外键字段,长度应该为{1}!(cls{4}BL:CheckPropertyNew)\";",
                                 objField.ColCaption,
                                 objField.ObjFieldTabENEx.FldLength,
                                 objPrjTabENEx.TabCnName,
                              strErrId,
                              objPrjTabENEx.TabName);
                        strBuilder.Append("\r\n}");
                    }
                }
            }
            strBuilder.Append("\r\n");
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
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(BusinessLogicEx4JavaScript);
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
            this.ClsName = string.Format("cls{0}BLEx", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }

    }
}
