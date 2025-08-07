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
    partial class AutoGC6Cs_Business : AutoGCPubFuncV6
    {
        
        /// <summary>
        /// 生成业务逻辑层代码－－Swift2
        /// </summary>
        /// <returns></returns>
        public string A_GenBusinessLogicCode_Swift(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            this.CmPrjId = "没有赋值,请重新考虑!";
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

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".swift";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".swift";
            objPrjTabENEx.FileName = strClassFName;

            try
            {
                //类名开始

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                //类名开始


                strCodeForCs.AppendFormat("\r\n" + "import Foundation",
                   objProjectsENEx.JavaPackageName,
                   objPrjTabENEx.TabName);


                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})",
                objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                clsSQLDSTypeEN objSQLDSType = clsSQLDSTypeBL.GetObjBySqlDsTypeIdCache(objPrjTabENEx.SqlDsTypeId);
                strCodeForCs.AppendFormat("\r\n /// 数据源类型:{0}",
                objSQLDSType.SqlDsTypeName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "public class  {0} : NSObject", objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 单项的XML结点标签");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public var itemXmlNode : String = \"{0}ListItem\";",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 列表的XML结点标签");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public var listXmlNode : String = \"{0}List\";",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 集合的XML结点标签");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public var itemsXmlNode :String = \"Items\";");

                //私有属性名-----和属性过程
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public static var arr{0}ObjLstCache : Array<cls{0}EN> = Array<cls{0}EN>();",
                       objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// 从缓存中查找失败的次数");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "private var intFindFailCount : Int = 0;");

                //生成所有的函数

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
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
                        strTemp = A_GeneFuncCode_Swift(strFuncName);
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
                
        public string A_GeneFuncCode_Swift(string strFuncName)
        {
            try
            {

                switch (strFuncName)
                {

                    case "Gen_4BL_getRecObjByJSONStr_Swift":
                        return Gen_4BL_Swift_getRecObjByJSONStr();


                    case "Gen_4BL_getObjLstByJSONStr_Swift":
                        return Gen_4BL_Swift_getObjLstByJSONStr();

                    case "Gen_4BL_getJSONStrByRecObj_Swift":
                        return Gen_4BL_Swift_getJSONStrByRecObj();


                    case "Gen_4BL_getDictionaryObjByRecObj_Swift":
                        return Gen_4BL_Swift_getDictionaryObjByRecObj();

                  
                    case "ErrNo":
                        return GenpErrNo();

                    case "ConnectString":
                        return GenConnectString();
                 
                    case "GenBindListView":
                        return GenBindListView();
                    case "Gen_4BL_SerializeObjToXMLStrIso_SilverLight":
                        return Gen_4BL_SerializeObjToXMLStrIso_SilverLight();

                    case "TransNullToStr":
                        return GenTransNullToStr();
                    case "TransNullToInt":
                        return GenTransNullToInt();
                    case "TransNullToDate":
                        return GenTransNullToDate();
                    case "TransNullToFloat":
                        return GenTransNullToFloat();
                    case "TransNullToDouble":
                        return GenTransNullToDouble();
                    case "TransNullToBool":
                        return GenTransNullToBool();
                    case "GetStrLen":
                        return GengetStrLen();
                    case "Dispose":
                        return GenDispose();
                    case "LogError":
                        return GenLogError();
                    default:
                        string strMsg = string.Format("功能名:{1}在Switch没有处理,请检查!({0})",
                            clsStackTrace.GetCurrClassFunction(), strFuncName);
                        throw new Exception(strMsg);
                        //            return "///该1函数不存在:" + strFuncName;
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
        }
                
    
        /// <summary>
        /// 把一个JSON串转化为一个对象.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Swift_getRecObjByJSONStr()
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
            strBuilder.AppendFormat("\r\n" + "public static func GetObjByJSONStr(strJSON : String) -> cls{0}EN",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN : cls{0}EN = cls{0}EN();",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "const json : AnyObject!");

            strBuilder.AppendFormat("\r\n" + "let data : NSData! = strJSON.dataUsingEncoding(NSUTF8StringEncoding);");

            strBuilder.AppendFormat("\r\n" + "if (strJSON == \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "do");
            strBuilder.Append("\r\n" + "{");
            //  let data : NSData! = try? NSJSONSerialization.dataWithJSONObject(strJSON, options: []);

            strBuilder.AppendFormat("\r\n" + "json = try? NSJSONSerialization.JSONObjectWithData(data, options: NSJSONReadingOptions.AllowFragments);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch let objException as NSError");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//获取JSON对象中所有的关键字集合");
            strBuilder.Append("\r\n" + "let jsonAllKeys : NSArray = json.allKeys;");
            strBuilder.Append("\r\n" + "//遍历关键字集合,并打印出来!");
            strBuilder.Append("\r\n" + "//for strKey in jsonAllKeys");
            strBuilder.Append("\r\n" + "//{");
            strBuilder.Append("\r\n" + "//print(strKey);");
            strBuilder.Append("\r\n" + "//}");
            strBuilder.Append("\r\n" + "//检查关键字：\"Memo1\"在关键字集合中是否存在!");
            strBuilder.Append("\r\n" + "//if (jsonAllKeys.containsObject(\"Memo1\") == true)");
            strBuilder.Append("\r\n" + "//{");
            strBuilder.Append("\r\n" + "//print(\"Memo1 is Exist!\");");
            strBuilder.Append("\r\n" + "//}");
            strBuilder.Append("\r\n" + "//else");
            strBuilder.Append("\r\n" + "//{");
            strBuilder.Append("\r\n" + "//print(\"Memo1 is not Exist!\");");
            strBuilder.Append("\r\n" + "//}");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(json.getString(\"{1}\"));",
                //     objPrjTabENEx.TabName,
                //     objField.ObjFieldTabENEx.FldName
                //    );
                string strResult = SetPropertyByJson_Swift(objField);
                strBuilder.Append(strResult);
            }


            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
                    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        
        /// <summary>
        /// 把一个JSON串转化为一个对象.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Swift_getJSONStrByRecObj()
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
            strBuilder.AppendFormat("\r\n" + "public static func GetJSONStrByObj(obj{0}EN : cls{0}EN) -> String",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "obj{0}EN.sfUpdFldSetStr = obj{0}EN.getUpdFldString();",
                objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "const objDict : NSMutableDictionary!");

            strBuilder.AppendFormat("\r\n" + "objDict = GetDictionaryObjByObj(obj{0}EN);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "const strJson : NSString!");
            strBuilder.Append("\r\n" + "const jsonData: NSData!");
            strBuilder.Append("\r\n" + "do");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "jsonData = try? NSJSONSerialization.dataWithJSONObject(objDict, options: NSJSONWritingOptions());");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch let objException as NSException");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "return String(objException);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "strJson = NSString(data: jsonData!, encoding: NSUTF8StringEncoding);");
            strBuilder.Append("\r\n" + "return String(strJson);");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
    
        /// <summary>
        /// 把一个JSON串转化为一个对象.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Swift_getDictionaryObjByRecObj()
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
            strBuilder.AppendFormat("\r\n" + "public static func GetDictionaryObjByObj(obj{0}EN : cls{0}EN) -> NSMutableDictionary",
                  objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.sfUpdFldSetStr = obj{0}EN.getUpdFldString();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "const objDict : NSMutableDictionary!");
            strBuilder.Append("\r\n" + "objDict = NSMutableDictionary();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
                {
                    case "Int32":
                        strBuilder.AppendFormat("\r\n" + "objDict.setValue(String(obj{0}EN.{1}), forKey: cls{0}EN.con_{1});",
                             objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                        break;
                    default:
                        strBuilder.AppendFormat("\r\n" + "objDict.setValue(obj{0}EN.{1}, forKey: cls{0}EN.con_{1});",
                             objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                        break;
                }
            }
            strBuilder.AppendFormat("\r\n" + "objDict.setValue(obj{0}EN.sfUpdFldSetStr, forKey: \"sfUpdFldSetStr\");",
                 objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDict;");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
    
        /// <summary>
        /// 把一个JSON串转化为一个对象列表.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Swift_getObjLstByJSONStr()
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
            strBuilder.AppendFormat("\r\n" + "public static func GetObjLstByJSONStr(strJSON : String) -> Array<cls{0}EN> ",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
              objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "let data = strJSON.dataUsingEncoding(NSUTF8StringEncoding);");

            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst : Array<cls{0}EN>= Array<cls{0}EN>();",
              objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "if (strJSON == \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "do");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "let jsonArr = try! NSJSONSerialization.JSONObjectWithData(data!, options: NSJSONReadingOptions.MutableContainers) as!NSArray;",
              objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "json = new JSONObject(strJSON);");
            strBuilder.AppendFormat("\r\n" + "for json in jsonArr");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//获取JSON对象中所有的关键字集合");
            strBuilder.Append("\r\n" + "let jsonAllKeys : NSArray = json.allKeys;");
            strBuilder.Append("\r\n" + "//遍历关键字集合,并打印出来!");
            strBuilder.Append("\r\n" + "//for strKey in jsonAllKeys");
            strBuilder.Append("\r\n" + "//{");
            strBuilder.Append("\r\n" + "//print(strKey);");
            strBuilder.Append("\r\n" + "//}");
            strBuilder.Append("\r\n" + "//检查关键字：\"Memo1\"在关键字集合中是否存在!");
            strBuilder.Append("\r\n" + "//if (jsonAllKeys.containsObject(\"Memo1\") == true)");
            strBuilder.Append("\r\n" + "//{");
            strBuilder.Append("\r\n" + "//print(\"Memo1 is Exist!\");");
            strBuilder.Append("\r\n" + "//}");
            strBuilder.Append("\r\n" + "//else");
            strBuilder.Append("\r\n" + "//{");
            strBuilder.Append("\r\n" + "//print(\"Memo1 is not Exist!\");");
            strBuilder.Append("\r\n" + "//}");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = cls{0}EN();",
                  objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //strBuilder.AppendFormat("\r\n" + "obj{0}EN.set{1}(json.getString(\"{1}\"));",
                //     objPrjTabENEx.TabName,
                //     objField.ObjFieldTabENEx.FldName
                //    );
                string strResult = SetPropertyByJson_Swift(objField);
                strBuilder.Append(strResult);
            }
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst.append(obj{0}EN);",
              objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch let objException as tzErrorType");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        private string SetPropertyByJson_Swift(clsPrjTabFldENEx objField)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n" + "if (jsonAllKeys.containsObject(\"{0}\") == true)",
                 objField.ObjFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "{");
            //  strBuilder.Append("\r\n" + "//print(\"Memo1 is Exist!\");");
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
            {
                case "String":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = String(json.objectForKey(\"{1}\")!);",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Int32":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = Int32(String(json.objectForKey(\"{1}\")!))!;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Int":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = Int(String(json.objectForKey(\"{1}\")!))!;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Double":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = Double(String(json.objectForKey(\"{1}\")!))!;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Float":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = Float(String(json.objectForKey(\"{1}\")!))!;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Short":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = Short(String(json.objectForKey(\"{1}\")!))!;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Bool":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = clsPubFun.myBool(json.objectForKey(\"{1}\")!);",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                default:
                    string strMsg = string.Format("Swift数据类型:[{1}]在switch中没有处理。({0})",
                        clsStackTrace.GetCurrClassFunction(),
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
                    throw new Exception(strMsg);

            }
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
     
    }
}
