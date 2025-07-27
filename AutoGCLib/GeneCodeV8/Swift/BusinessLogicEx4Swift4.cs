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
    partial class BusinessLogicEx4Swift4 : clsGeneCodeBase4Tab
    {
        #region 构造函数

        public BusinessLogicEx4Swift4(string strTabId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
        }
        #endregion
        /// <summary>
        /// 把一个JSON串转化为一个对象.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Swift4_getRecObjByJSONStr()
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
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
              objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "const json : AnyObject!");

            strBuilder.AppendFormat("\r\n" + "let jsonData = strJSON.data(using: String.Encoding.utf8);");

            strBuilder.AppendFormat("\r\n" + "if (strJSON == \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return cls{0}EN();",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "do");
            strBuilder.Append("\r\n" + "{");
            //  let data : NSData! = try? NSJSONSerialization.dataWithJSONObject(strJSON, options: []);

            //strBuilder.AppendFormat("\r\n" + "json = try JSONSerialization.jsonObject(with: data as Data, options: JSONSerialization.ReadingOptions.allowFragments) as AnyObject!;");

            strBuilder.Append("\r\n" + "let decoder = JSONDecoder()");
            strBuilder.AppendFormat("\r\n" + "let obj{0}EN_Sim = try decoder.decode(cls{0}EN_Sim.self, from: jsonData!)",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = GetObjFromSimObj(obj{0}EN_Sim: obj{0}EN_Sim);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch _ as NSError");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return cls{0}EN();",
                    objPrjTabENEx.TabName);
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
        public string Gen_4BL_Swift4_getJSONStrByRecObj()
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

            strBuilder.AppendFormat("\r\n" + "objDict = GetDictionaryObjByObj(obj{0}EN : obj{0}EN);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "const strJson : NSString!");
            strBuilder.Append("\r\n" + "const jsonData: NSData!");
            strBuilder.Append("\r\n" + "do");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "jsonData = try? NSJSONSerialization.dataWithJSONObject(objDict, options: NSJSONWritingOptions());");
            strBuilder.Append("\r\n" + "jsonData = try JSONSerialization.data(withJSONObject: objDict, options: JSONSerialization.WritingOptions()) as NSData!;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch let objException");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "return String(describing: objException);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "strJson = NSString(data: jsonData! as Data, encoding: String.Encoding.utf8.rawValue);");
            
            strBuilder.Append("\r\n" + "return String(strJson);");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// 把一个JSON串转化为一个对象.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Swift4_getJSONStrByObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 把一个对象数组转化为一个JSON串");
            strBuilder.AppendFormat("\r\n /// 作者:{0}", objPrjTabENEx.UserId);
            strBuilder.AppendFormat("\r\n /// 日期:{0}", clsDateTime.getDateStr(objPrjTabENEx.CurrDate, 1));
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}ObjLst\">需要转化的对象数组</param>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <returns>返回一个JSON串</returns>",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "public static func GetJSONStrByObjLst(arr{0}ObjLst : Array<cls{0}EN>) -> String",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n let arr{0}SimObjLst = GetSimObjLstFromObjLst(arr{0}ObjLst: arr{0}ObjLst);", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "const strJson : NSString!");
            strBuilder.Append("\r\n" + "do");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "jsonData = try? NSJSONSerialization.dataWithJSONObject(objDict, options: NSJSONWritingOptions());");
            strBuilder.Append("\r\n" + "let encoder = JSONEncoder()");
            strBuilder.AppendFormat("\r\n" + "let jsonData = try encoder.encode(arr{0}SimObjLst);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "strJson = NSString(data: jsonData as Data, encoding: String.Encoding.utf8.rawValue);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch let objException");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "return String(describing: objException);");

            strBuilder.Append("\r\n" + "}");
         
            strBuilder.Append("\r\n" + "return String(strJson);");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 把一个JSON串转化为一个对象列表.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Swift4_getObjLstByJSONStr()
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
            //strBuilder.AppendFormat("\r\n" + "const obj{0}EN : cls{0}EN = cls{0}EN();",
            //  objPrjTabENEx.TabName);

            //strBuilder.Append("\r\n" + "let myData = strJSON.data(using: String.Encoding.utf8) as NSData!;");

            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst : Array<cls{0}EN> = Array<cls{0}EN>();",
              objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "if (strJSON == \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "do");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "let jsonArr = try! NSJSONSerialization.JSONObjectWithData(data!, options: NSJSONReadingOptions.MutableContainers) as!NSArray;",
            //  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "let decoder = JSONDecoder()");
            strBuilder.Append("\r\n" + "let jsonData = strJSON.data(using: String.Encoding.utf8);");
            strBuilder.AppendFormat("\r\n" + "let arr{0}SimObjLst = try decoder.decode([cls{0}EN_Sim].self, from: jsonData!)",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = GetObjLstFromSimObjLst(arr{0}SimObjLst: arr{0}SimObjLst);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch let objException");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
                    objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 把一个JSON串转化为一个对象.
        /// </summary>
        /// <returns></returns>
        public string Gen_4BL_Swift4_getDictionaryObjByRecObj()
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

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "BLEx";
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

                strCodeForCs.AppendFormat("\r\n" + "public class  {0} : cls{1}BL", objPrjTabENEx.ClsName, objPrjTabENEx.TabName);
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


        private string SetPropertyByJson_Swift4(clsPrjTabFldENEx objField)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n" + "if (jsonAllKeys.contains(\"{0}\") == true)",
                 objField.ObjFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "{");
            //  strBuilder.Append("\r\n" + "//print(\"Memo1 is Exist!\");");
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
            {
                case "String":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = json?[\"{1}\"] as! String;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Int32":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = json?[\"{1}\"] as! Int32;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Int":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = json?[\"{1}\"] as! Int;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Double":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = json?[\"{1}\"] as! Double;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Float":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = json?[\"{1}\"] as! Float;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Short":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = json?[\"{1}\"] as! Short;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Bool":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = clsPubFun.myBool(myObj: json.object(forKey: \"{1}\") as AnyObject);",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Date":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = clsDate.getDateFromString(json.object(forKey: \"{1}\") as AnyObject);",
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

        private string SetPropertyByJson4ObjLst_Swift4(clsPrjTabFldENEx objField)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n" + "if (jsonAllKeys.contains(\"{0}\") == true)",
                 objField.ObjFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "{");
            //  strBuilder.Append("\r\n" + "//print(\"Memo1 is Exist!\");");
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
            {
                case "String":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = (json as AnyObject)[\"{1}\"] as! String;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Int32":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = (json as AnyObject)[\"{1}\"] as! Int32;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Int":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = (json as AnyObject)[\"{1}\"] as! Int;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Double":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = (json as AnyObject)[\"{1}\"] as! Double;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Float":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = (json as AnyObject)[\"{1}\"] as! Float;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Short":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = (json as AnyObject)[\"{1}\"] as! Short;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Bool":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = clsPubFun.myBool(myObj: (json as AnyObject).object(forKey: \"{1}\") as AnyObject);",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName
                         );
                    break;
                case "Date":
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = clsDate.getDateFromString((json as AnyObject).object(forKey: \"{1}\") as AnyObject);",
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

        public string Gen_4BL_Swift4_GetSimObjFromObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把对象转换成简化对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>简化对象</returns>");
            strBuilder.AppendFormat("\r\n public static func GetSimObjFromObj(obj{0}EN: cls{0}EN )-> cls{0}EN_Sim ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            //strBuilder.Append("\r\n let decoder = JSONDecoder()");
            strBuilder.AppendFormat("\r\n let obj{0}EN_Sim: cls{0}EN_Sim = cls{0}EN_Sim();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n cls{0}BL.CopyObjToSimObj(obj{0}ENS: obj{0}EN, obj{0}ENT: obj{0}EN_Sim);", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n return obj{0}EN_Sim;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string Gen_4BL_Swift4_GetObjFromSimObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把简化对象转换成对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>简化对象</returns>");
            strBuilder.AppendFormat("\r\n public static func GetObjFromSimObj(obj{0}EN_Sim: cls{0}EN_Sim)->cls{0}EN ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n let obj{0}EN: cls{0}EN = cls{0}EN();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n cls{0}BL.CopyObjFromSimObj(obj{0}ENS: obj{0}EN_Sim, obj{0}ENT: obj{0}EN);", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_Swift4_GetObjFromSimObj4Upd_S()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把简化对象转换成对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">对象</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>简化对象</returns>");
            strBuilder.AppendFormat("\r\n public static func GetObjFromSimObj4Upd(obj{0}EN_Sim: cls{0}EN_Sim)->cls{0}EN ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n let obj{0}EN: cls{0}EN = cls{0}EN();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n cls{0}BL.CopyObjFromSimObj4Upd(obj{0}ENS: obj{0}EN_Sim, obj{0}ENT: obj{0}EN);", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_Swift4_GetSimObjLstFromObjLst_S()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把对象列表转换成简化对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}ObjLst\">对象列表</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>简化对象列表</returns>");
            strBuilder.AppendFormat("\r\n public static func GetSimObjLstFromObjLst(arr{0}ObjLst: Array<cls{0}EN>)->Array<cls{0}EN_Sim>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n var arr{0}SimObjLst: Array<cls{0}EN_Sim> = Array<cls{0}EN_Sim>();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n for obj{0}EN in arr{0}ObjLst", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");

            //strBuilder.Append("\r\n let decoder = JSONDecoder()");
            strBuilder.AppendFormat("\r\n let obj{0}EN_Sim: cls{0}EN_Sim = cls{0}EN_Sim();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n cls{0}BL.CopyObjToSimObj(obj{0}ENS: obj{0}EN, obj{0}ENT: obj{0}EN_Sim);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n arr{0}SimObjLst.append(obj{0}EN_Sim);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.AppendFormat("\r\n return arr{0}SimObjLst;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_Swift4_GetObjLstFromSimObjLst_S()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把对象列表转换成简化对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}ObjLst\">对象列表</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>简化对象列表</returns>");
            strBuilder.AppendFormat("\r\n public static func GetObjLstFromSimObjLst(arr{0}SimObjLst: Array<cls{0}EN_Sim>)->Array<cls{0}EN>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n var arr{0}ObjLst: Array<cls{0}EN> = Array<cls{0}EN>();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n for obj{0}EN_Sim in arr{0}SimObjLst", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");

            //strBuilder.Append("\r\n let decoder = JSONDecoder()");
            strBuilder.AppendFormat("\r\n var obj{0}EN: cls{0}EN = cls{0}EN();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n obj{0}EN = cls{0}BL.GetObjFromSimObj(obj{0}EN_Sim: obj{0}EN_Sim);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n arr{0}ObjLst.append(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.AppendFormat("\r\n return arr{0}ObjLst;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_Swift4_CopyObjFromSimObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把同一个类的对象,从简化对象复制到对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源简化对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static func CopyObjFromSimObj(obj{0}ENS: cls{0}EN_Sim, obj{0}ENT: cls{0}EN)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //只写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            //strBuilder.AppendFormat("\r\n" + "{0}DA.CopyObjFromSimObj(obj{0}ENS, obj{0}ENT);",
            //objPrjTabENEx.TabName);
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_Swift4_CopyObjFromSimObj4Upd_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把同一个类的对象,从简化对象复制到对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源简化对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static func CopyObjFromSimObj4Upd(obj{0}ENS: cls{0}EN_Sim, obj{0}ENT: cls{0}EN)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n   let strsfUpdFldSetStr = obj{0}ENS.sfUpdFldSetStr;",
             objPrjTabENEx.TabName);
            strBuilder.Append("\r\n    let arrFldSet = strsfUpdFldSetStr.characters.split{$0 == \"|\"}.map(String.init);");
//            strBuilder.Append("\r\n   List<string> arrFldSet = new List<string>(sstrFldSet);");
//            let fullName = "First Last"
//let fullNameArr = fullName.characters.split{$0 == " "}.map(String.init)
// or simply:
// let fullNameArr = fullName.characters.split{" "}.map(String.init)

//strBuilder.AppendFormat("\r\n" + "{0}DA.CopyObjFromSimObj4Upd(obj{0}ENS, obj{0}ENT);",
//    objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //只写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "if (arrFldSet.contains(cls{0}EN.con_{1})  ==  true)",
                         objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                               objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                    strBuilder.Append("\r\n" + "}");

                }
            }

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy表:{0} 对象数据(针对修改)出错!({1}:CopyObjFromSimObj4Upd)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_Swift4_CopyObjToSimObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把同一个类的对象,复制到另一个对象(简单)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static func CopyObjToSimObj(obj{0}ENS: cls{0}EN, obj{0}ENT: cls{0}EN_Sim)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            //strBuilder.AppendFormat("\r\n" + "{0}DA.CopyObjToSimObj(obj{0}ENS, obj{0}ENT);",
            //objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //只写
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }          
            strBuilder.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strBuilder.ToString();
        }

        public string A_GeneFuncCode_Swift4(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(BusinessLogicEx4Swift4);
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
                Type t = typeof(BusinessLogicEx4Swift4);
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
