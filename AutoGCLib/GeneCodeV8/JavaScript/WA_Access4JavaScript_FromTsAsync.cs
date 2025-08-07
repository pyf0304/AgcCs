using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using System;
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
    partial class WA_Access4JavaScript : clsGeneCodeBase
    {        
        public string A_GeneFuncCode_TypeScript(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_Srv4CSharp);
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
        /// 调用WebApi来添加记录，数据传递使用JSON串
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_AddNewRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 调用WebApi来添加记录，数据传递使用JSON串");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.AddNewRecord = function(obj{0}EN) ",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName, 
                    objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strMsg = \"\";");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"AddNewRecord\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);

            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03
             && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
             && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool"
             && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "int"
              && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "long")
            {

                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} === null || obj{0}EN.{1} === 0)",
                      objPrjTabENEx.TabName,
                   objKeyField.FldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} === null || obj{0}EN.{1} === \"\")",
                     objPrjTabENEx.TabName,
                  objKeyField.FldName);
                }
          
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strMsg = \"需要的对象的关键字为空，不能添加!\";");
            strCodeForCs.Append("\r\n" + "throw strMsg;");
            strCodeForCs.Append("\r\n" + "}");
            }

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = {1}.GetSimObjFromObj(obj{0}EN);",
                    objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}BL", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.AppendFormat("\r\n" + " //var strJSON = JSON.stringify(obj{0}EN_Sim);",
                    objPrjTabENEx.TabName);
            //var strJSON = JSON.stringify(objMyTest1EN);
            //strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"str{0}JSONObj\", strJSON);",
            //  objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, obj{0}EN_Sim);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");
            
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 调用WebApi来添加记录，数据传递使用JSON串
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_AddNewRecordWithMaxId()
        {
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 调用WebApi来添加记录，数据传递使用JSON串");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.AddNewRecordWithMaxId = function(obj{0}EN) ",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName, 
                    objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strMsg = \"\";");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"AddNewRecordWithMaxId\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = {1}.GetSimObjFromObj(obj{0}EN);",
                    objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}BL", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.AppendFormat("\r\n" + " //var strJSON = JSON.stringify(obj{0}EN_Sim);",
                    objPrjTabENEx.TabName);
            //var strJSON = JSON.stringify(objMyTest1EN);
            //strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"str{0}JSONObj\", strJSON);",
            //  objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, obj{0}EN_Sim);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return (data.returnBool);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Js_GoTop()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把所给的关键字列表相关的记录移顶");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.GoTop = function(objOrderByData) ",
                objPrjTabENEx.TabName,
                objKeyField.FldName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strMsg = \"\";");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GoTop\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            
                strCodeForCs.AppendFormat("\r\n" + "if (objOrderByData.KeyIdLst.length == 0)",
                  objPrjTabENEx.TabName,
               objKeyField.FldName);
            
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strMsg = \"根据关键字列表置顶时，给定的关键字值列表不能为空!\";");
            strCodeForCs.Append("\r\n" + "throw strMsg;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + " //var strJSON = JSON.stringify(obj{0}EN_Sim);",
                    objPrjTabENEx.TabName);
            //var strJSON = JSON.stringify(objMyTest1EN);
            //strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"str{0}JSONObj\", strJSON);",
            //  objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "type: \"POST\",");
            strCodeForCs.Append("\r\n" + "contentType: \"application/json; charset=utf-8\",");

            //      data: obj{0}EN,
            strCodeForCs.AppendFormat("\r\n" + "data: JSON.stringify(objOrderByData),",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "resolve(data.returnBool);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");    

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Js_GoBottom()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把所给的关键字列表相关的记录移底");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.GoBottom = function(objOrderByData) ",
                objPrjTabENEx.TabName,
                objKeyField.FldName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strMsg = \"\";");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GoBottom\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "if (objOrderByData.KeyIdLst.length == 0)",
              objPrjTabENEx.TabName,
           objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strMsg = \"根据关键字列表置底时，给定的关键字值列表不能为空!\";");
            strCodeForCs.Append("\r\n" + "throw strMsg;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + " //var strJSON = JSON.stringify(obj{0}EN_Sim);",
                    objPrjTabENEx.TabName);
            //var strJSON = JSON.stringify(objMyTest1EN);
            //strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"str{0}JSONObj\", strJSON);",
            //  objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "type: \"POST\",");
            strCodeForCs.Append("\r\n" + "contentType: \"application/json; charset=utf-8\",");

            //      data: obj{0}EN,
            strCodeForCs.AppendFormat("\r\n" + "data: JSON.stringify(objOrderByData),",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "resolve(data.returnBool);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Js_ReOrder()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把列表记录重序");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.ReOrder = function(objOrderByData) ",
                objPrjTabENEx.TabName,
                objKeyField.FldName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strMsg = \"\";");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"ReOrder\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);

           // strCodeForCs.AppendFormat("\r\n" + "if (objOrderByData.KeyIdLst.length == 0)",
           //   objPrjTabENEx.TabName,
           //objKeyField.FldName);

           // strCodeForCs.Append("\r\n" + "{");
           // strCodeForCs.Append("\r\n" + "strMsg = \"根据关键字列表置顶时，给定的关键字值列表不能为空!\";");
           // strCodeForCs.Append("\r\n" + "throw strMsg;");
           // strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + " //var strJSON = JSON.stringify(obj{0}EN_Sim);",
                    objPrjTabENEx.TabName);
            //var strJSON = JSON.stringify(objMyTest1EN);
            //strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"str{0}JSONObj\", strJSON);",
            //  objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "type: \"POST\",");
            strCodeForCs.Append("\r\n" + "contentType: \"application/json; charset=utf-8\",");

            //      data: obj{0}EN,
            strCodeForCs.AppendFormat("\r\n" + "data: JSON.stringify(objOrderByData),",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "resolve(data.returnBool);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Js_UpMove()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把所给的关键字列表相关的记录上移");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.UpMove = function(objOrderByData) ",
                objPrjTabENEx.TabName,
                objKeyField.FldName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strMsg = \"\";");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"UpMove\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "if (objOrderByData.KeyIdLst.length == 0)",
              objPrjTabENEx.TabName,
           objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strMsg = \"根据关键字列表上移时，给定的关键字值列表不能为空!\";");
            strCodeForCs.Append("\r\n" + "throw strMsg;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + " //var strJSON = JSON.stringify(obj{0}EN_Sim);",
                    objPrjTabENEx.TabName);
            //var strJSON = JSON.stringify(objMyTest1EN);
            //strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"str{0}JSONObj\", strJSON);",
            //  objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "type: \"POST\",");
            strCodeForCs.Append("\r\n" + "contentType: \"application/json; charset=utf-8\",");

            //      data: obj{0}EN,
            strCodeForCs.AppendFormat("\r\n" + "data: JSON.stringify(objOrderByData),",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "resolve(data.returnBool);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Js_DownMove()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把所给的关键字列表相关的记录下移");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.DownMove = function(objOrderByData)",
                objPrjTabENEx.TabName,
                objKeyField.FldName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strMsg = \"\";");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"DownMove\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "if (objOrderByData.KeyIdLst.length == 0)",
              objPrjTabENEx.TabName,
           objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strMsg = \"根据关键字列表下移时，给定的关键字值列表不能为空!\";");
            strCodeForCs.Append("\r\n" + "throw strMsg;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + " //var strJSON = JSON.stringify(obj{0}EN_Sim);",
                    objPrjTabENEx.TabName);
            //var strJSON = JSON.stringify(objMyTest1EN);
            //strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"str{0}JSONObj\", strJSON);",
            //  objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "type: \"POST\",");
            strCodeForCs.Append("\r\n" + "contentType: \"application/json; charset=utf-8\",");

            //      data: obj{0}EN,
            strCodeForCs.AppendFormat("\r\n" + "data: JSON.stringify(objOrderByData),",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "resolve(data.returnBool);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 调用WebApi来修改记录，数据传递使用JSON串
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_UpdateRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 调用WebApi来修改记录，数据传递使用JSON串");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns>获取修改是否成功？</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.UpdateRecord = function(obj{0}EN)  ",
                objPrjTabENEx.TabName,
                objKeyField.FldName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strMsg = \"\";");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"UpdateRecord\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + " if (obj{0}EN.sf_UpdFldSetStr === undefined || obj{0}EN.sf_UpdFldSetStr === null || obj{0}EN.sf_UpdFldSetStr === \"\")",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "strMsg = \"对象(关键字: \" + obj{0}EN.{1} + \")的【修改字段集】为空，不能修改!\";",
                objPrjTabENEx.TabName, objKeyField.FldName, "{", "}");
            strCodeForCs.Append("\r\n" + " throw strMsg;");
            strCodeForCs.Append("\r\n" + " }");
            //strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"str{0}JSONObj\", strJSON);",
            //  objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = {1}.GetSimObjFromObj(obj{0}EN);",
              objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}BL", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, obj{0}EN_Sim);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return (data.returnBool);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }



        /// <summary>
        /// 调用WebApi来删除记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_DelRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 调用WebApi来删除记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">关键字</param>", objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n /// <returns>获取删除的结果</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.DelRecord = function({0})  ",
                            objKeyField.PrivFuncName, 
                            KeyDataType, 
                            objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"DelRecord\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "strUrl =  strUrl+ \"/\" +  {0};", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n" + "const mapParam = new {0}();", ImportClass.GetOutString(string.Format("Dictionary", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"{0}\", {0});", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");

            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "method: \"DELETE\",");
            strCodeForCs.Append("\r\n" + "dataType: \"json\",");
            strCodeForCs.AppendFormat("\r\n" + "data: {{ \"\": {0} }},", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "resolve(data.returnInt);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");


            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }



        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_IsExistRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取是否存在相应的记录？");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件</param>");
            strCodeForCs.Append("\r\n /// <returns>是否存在记录？</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.IsExistRecord = function(strWhereCond)  ",
                objPrjTabENEx.TabName,
                objKeyField.FldName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"IsExistRecord\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
                        
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "params: { \"strWhereCond\": strWhereCond}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_GetRecCountByCond()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取某一条件的记录数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件</param>");
            strCodeForCs.Append("\r\n /// <returns>获取某一条件的记录数</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.GetRecCountByCond = function(strWhereCond)  ",
                objPrjTabENEx.TabName,
                objKeyField.FldName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetRecCountByCond\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);

            
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "params: { \"strWhereCond\": strWhereCond}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnInt;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_GetObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的记录对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件</param>");

            strCodeForCs.Append("\r\n /// <returns>获取的相应对象列表</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.GetObjLst = function(strWhereCond)  ",
                objPrjTabENEx.TabName,
                objKeyField.FldName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetObjLst\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);

            
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "params: { \"strWhereCond\": strWhereCond}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObjLst = JSON.parse(data.returnObjLst);");
            strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
            strCodeForCs.AppendFormat("\r\n" + "const arrObjLst = cls{0}BL.GetObjLstByJSONObjLst(returnObjLst);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return arrObjLst;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
                strCodeForCs.Append("\r\n" + "reject(strInfo);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "reject(result.statusText);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

 //函数:GengetStrLen_TypeScript不存在！]
        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_GetObjLst_WA_Cache()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取服务器缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件</param>");

            strCodeForCs.Append("\r\n /// <returns>获取的相应对象列表</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.GetObjLst_WA_Cache = function()  ",
                objPrjTabENEx.TabName,
                objKeyField.FldName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetObjLst_Cache\";",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);

            strCodeForCs.AppendFormat("\r\n" + "const mapParam = new {0}();", ImportClass.GetOutString(string.Format("Dictionary", objPrjTabENEx.TabName), this.Is4RJ));            
            strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");

            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "method: \"GET\",");
            strCodeForCs.Append("\r\n" + "dataType: \"json\",");

            strCodeForCs.Append("\r\n" + "data: strData,");
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObjLst = JSON.parse(data.returnObjLst);");
            strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
            strCodeForCs.AppendFormat("\r\n" + "const arrObjLst = cls{0}BL.GetObjLstByJSONObjLst(returnObjLst);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "resolve(arrObjLst);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_GetObjLst_Cache()
        {
            if (objPrjTabENEx.IsUseCache == false) return "//该表不需要使用Cache;";

            StringBuilder strCodeForCs = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <returns>从本地缓存中获取的对象列表</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{1}.GetObjLst_Cache = async function() ",
                objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{2}.GetObjLst_Cache = async function({1})",
                      objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                      objPrjTabENEx.objCacheClassifyFld.PrivFuncName, 
                      objPrjTabENEx.ClsName);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache;", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "switch (cls{0}EN.CacheModeId)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.Append("\r\n" + "case \"04\"://sessionStorage");
                strCodeForCs.AppendFormat("\r\n" + "arr{1}ObjLst_Cache = await {1}_GetObjLst_sessionStorage();", 
                    objPrjTabENEx.ClsName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"03\"://localStorage");
                strCodeForCs.AppendFormat("\r\n" + "arr{1}ObjLst_Cache = await {1}_GetObjLst_localStorage();", objPrjTabENEx.ClsName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"02\"://ClientCache");
                strCodeForCs.AppendFormat("\r\n" + "arr{1}ObjLst_Cache = await {1}_GetObjLst_ClientCache();", objPrjTabENEx.ClsName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.AppendFormat("\r\n" + "arr{1}ObjLst_Cache = await {1}_GetObjLst_ClientCache();", objPrjTabENEx.ClsName, objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "case \"04\"://sessionStorage");
                strCodeForCs.AppendFormat("\r\n" + "arr{1}ObjLst_Cache = await {1}_GetObjLst_sessionStorage({2});", 
                    objPrjTabENEx.ClsName, objPrjTabENEx.TabName,
                      objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"03\"://localStorage");
                strCodeForCs.AppendFormat("\r\n" + "arr{1}ObjLst_Cache = await {1}_GetObjLst_localStorage({2});", 
                    objPrjTabENEx.ClsName, objPrjTabENEx.TabName,
                      objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"02\"://ClientCache");
                strCodeForCs.AppendFormat("\r\n" + "arr{1}ObjLst_Cache = await {1}_GetObjLst_ClientCache({2});", 
                    objPrjTabENEx.ClsName, objPrjTabENEx.TabName,
                      objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.AppendFormat("\r\n" + "arr{1}ObjLst_Cache = await {1}_GetObjLst_ClientCache({2});", 
                    objPrjTabENEx.ClsName, objPrjTabENEx.TabName,
                      objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst_Cache;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Js_GetObjLst_CacheBak20200416()
        {
            if (objPrjTabENEx.IsUseCache == false) return "//该表不需要使用Cache;";

            StringBuilder strCodeForCs = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <returns>从本地缓存中获取的对象列表</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{1}.GetObjLst_Cache = async function() ",
                objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{2}.GetObjLst_Cache = async function({1})",
                      objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                      objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                      objPrjTabENEx.ClsName);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//初始化列表缓存");
            strCodeForCs.Append("\r\n" + "const strWhereCond = \"1=1\";");
            //strCodeForCs.AppendFormat("\r\n" + "{0}_InitListCache(); ", objPrjTabENEx.TabName);

            //strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst_Cache;",
            //  objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = {1}._CurrTabName;",
                 objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            }
            else
            {

                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = \"{0}='\" +  {1} + \"'\";", objPrjTabENEx.objCacheClassifyFld.FldName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                if (objPrjTabENEx.objCacheClassifyFld.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = {2}._CurrTabName+ \"_\" +  {1};",
                           objPrjTabENEx.TabName,
                           objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey =   {2}._CurrTabName+ \"_\" +  {1};",
                         objPrjTabENEx.TabName,
                         objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
                }
            }
            strCodeForCs.Append("\r\n" + "if (strKey == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(\"关键字为空！不正确\");");
            strCodeForCs.Append("\r\n" + "throw new Error(\"关键字为空！不正确\");");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + " if ({0}.Exsits(strKey))",
                           ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//缓存存在，直接取出返回");

            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst_Cache;", objPrjTabENEx.TabName);

            //            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}_GetObjLst(strWhereCond);", objPrjTabENEx.TabName);

            //strCodeForCs.AppendFormat("\r\n" + "{0}_arr{0}ObjLst_Cache = arr{0}ObjLst;", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "{1}.Add(strKey, arr{0}ObjLst);", objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"Key:[\" + strKey+ \" ]的缓存已经建立，对象列表数：\" + arr{0}ObjLst.length+ \" !\";", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "console.log(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"从缓存中获取所有对象列表出错,\" +e + \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "throw (strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Js_GetObjLst_ClientCache()
        {
            if (objPrjTabENEx.IsUseCache == false) return "//该表不需要使用Cache;";

            StringBuilder strCodeForCs = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <returns>从本地缓存中获取的对象列表</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{1}.GetObjLst_ClientCache = async function() ",
                objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{2}.GetObjLst_ClientCache = async function({1})",
                      objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                      objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                      objPrjTabENEx.ClsName);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//初始化列表缓存");
            strCodeForCs.Append("\r\n" + "const strWhereCond = \"1=1\";");
            //strCodeForCs.AppendFormat("\r\n" + "{0}_InitListCache(); ", objPrjTabENEx.TabName);

            //strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst_Cache;",
            //  objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = {1}._CurrTabName;",
                 objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            }
            else
            {

                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = \"{0}='\" +  {1} + \"'\";", objPrjTabENEx.objCacheClassifyFld.FldName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                if (objPrjTabENEx.objCacheClassifyFld.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = {2}._CurrTabName+ \"_\" +  {1};",
                           objPrjTabENEx.TabName,
                           objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey =   {2}._CurrTabName+ \"_\" +  {1};",
                         objPrjTabENEx.TabName,
                         objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
                }
            }
            strCodeForCs.Append("\r\n" + "if (strKey == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(\"关键字为空！不正确\");");
            strCodeForCs.Append("\r\n" + "throw new Error(\"关键字为空！不正确\");");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + " if ({0}.Exsits(strKey))",
                           ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//缓存存在，直接取出返回");

            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst_Cache;", objPrjTabENEx.TabName);

            //            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}_GetObjLst(strWhereCond);", objPrjTabENEx.TabName);

            //strCodeForCs.AppendFormat("\r\n" + "{0}_arr{0}ObjLst_Cache = arr{0}ObjLst;", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "{1}.Add(strKey, arr{0}ObjLst);", objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"Key:[\" + strKey+ \" ]的缓存已经建立，对象列表数：\" + arr{0}ObjLst.length+ \" !\";", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "console.log(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"从缓存中获取所有对象列表出错,\" +e + \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "throw (strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Js_GetObjLst_localStorage()
        {
            if (objPrjTabENEx.IsUseCache == false) return "//该表不需要使用Cache;";

            StringBuilder strCodeForCs = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <returns>从本地缓存中获取的对象列表</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{1}.GetObjLst_localStorage = async function() ",
                objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{2}.GetObjLst_localStorage = async function({1})",
                      objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                      objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                      objPrjTabENEx.ClsName);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//初始化列表缓存");
            strCodeForCs.Append("\r\n" + "const strWhereCond = \"1=1\";");
            //strCodeForCs.AppendFormat("\r\n" + "{0}_InitListCache(); ", objPrjTabENEx.TabName);

            //strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst_Cache;",
            //  objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = {1}._CurrTabName;",
                 objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            }
            else
            {

                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = \"{0}='\" +  {1} + \"'\";", objPrjTabENEx.objCacheClassifyFld.FldName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                if (objPrjTabENEx.objCacheClassifyFld.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = {2}._CurrTabName+ \"_\" +  {1};",
                           objPrjTabENEx.TabName,
                           objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey =   {2}._CurrTabName+ \"_\" +  {1};",
                         objPrjTabENEx.TabName,
                         objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
                }
            }
            strCodeForCs.Append("\r\n" + "if (strKey == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(\"关键字为空！不正确\");");
            strCodeForCs.Append("\r\n" + "throw new Error(\"关键字为空！不正确\");");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + " if (Object.prototype.hasOwnProperty.call(localStorage, strKey))",
                           ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//缓存存在，直接取出返回");

            strCodeForCs.AppendFormat("\r\n" + "const strTempObjLst = localStorage.getItem(strKey);", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = JSON.parse(strTempObjLst);", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst_Cache;", objPrjTabENEx.TabName);

            //            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}_GetObjLst(strWhereCond);", objPrjTabENEx.TabName);
            
            //strCodeForCs.AppendFormat("\r\n" + "{0}_arr{0}ObjLst_Cache = arr{0}ObjLst;", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "localStorage.setItem(strKey, JSON.stringify(arr{0}ObjLst));", objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"Key:[\" + strKey+ \" ]的缓存已经建立，对象列表数：\" + arr{0}ObjLst.length+ \" !\";", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "console.log(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"从缓存中获取所有对象列表出错,\" +e + \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "throw (strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Js_GetObjLst_sessionStorage()
        {
            if (objPrjTabENEx.IsUseCache == false) return "//该表不需要使用Cache;";

            StringBuilder strCodeForCs = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <returns>从本地缓存中获取的对象列表</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{1}.GetObjLst_sessionStorage = async function() ",
                objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{2}.GetObjLst_sessionStorage = async function({1})",
                      objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                      objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                      objPrjTabENEx.ClsName);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//初始化列表缓存");
            strCodeForCs.Append("\r\n" + "const strWhereCond = \"1=1\";");
            //strCodeForCs.AppendFormat("\r\n" + "{0}_InitListCache(); ", objPrjTabENEx.TabName);

            //strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst_Cache;",
            //  objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = {1}._CurrTabName;",
                 objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            }
            else
            {

                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = \"{0}='\" +  {1} + \"'\";", objPrjTabENEx.objCacheClassifyFld.FldName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                if (objPrjTabENEx.objCacheClassifyFld.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = {2}._CurrTabName+ \"_\" +  {1};",
                           objPrjTabENEx.TabName,
                           objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey =   {2}._CurrTabName+ \"_\" +  {1};",
                         objPrjTabENEx.TabName,
                         objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
                }
            }
            strCodeForCs.Append("\r\n" + "if (strKey == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(\"关键字为空！不正确\");");
            strCodeForCs.Append("\r\n" + "throw new Error(\"关键字为空！不正确\");");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))",
                           ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//缓存存在，直接取出返回");
            strCodeForCs.AppendFormat("\r\n" + "const strTempObjLst = sessionStorage.getItem(strKey);", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = JSON.parse(strTempObjLst);", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst_Cache;", objPrjTabENEx.TabName);

            //            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}_GetObjLst(strWhereCond);", objPrjTabENEx.TabName);
            
            //strCodeForCs.AppendFormat("\r\n" + "{0}_arr{0}ObjLst_Cache = arr{0}ObjLst;", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "sessionStorage.setItem(strKey, JSON.stringify(arr{0}ObjLst));", objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"Key:[\" + strKey+ \" ]的缓存已经建立，对象列表数：\" + arr{0}ObjLst.length+ \" !\";", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "console.log(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"从缓存中获取所有对象列表出错,\" +e + \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "throw (strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Js_GetObjLstByKeyLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字列表获取相关对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"arr{0}\">关键字列表</param>", objKeyField.FldName);
            strCodeForCs.Append("\r\n /// <returns>对象列表</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.GetObjLstBy{1}Lst = function(arr{1})  ",
                objPrjTabENEx.TabName,
                objKeyField.FldName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetObjLstBy{1}Lst\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);

            strCodeForCs.AppendFormat("\r\n" + "const mapParam = new {0}();", ImportClass.GetOutString(string.Format("Dictionary", objPrjTabENEx.TabName), this.Is4RJ));
            
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "type: \"POST\",");
            strCodeForCs.Append("\r\n" + "contentType: \"application/json; charset=utf-8\",");

            strCodeForCs.AppendFormat("\r\n" + "data: JSON.stringify(arr{0}),", objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObjLst = JSON.parse(data.returnObjLst);");
            strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
            strCodeForCs.AppendFormat("\r\n" + "const arrObjLst = cls{0}BL.GetObjLstByJSONObjLst(returnObjLst);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "resolve(arrObjLst);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Js_GetObjLstByKeyLst_WA_Cache()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字列表获取相关对象列表, 从WebApi缓存中获取");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"arr{0}\">关键字列表</param>", objKeyField.FldName);
            strCodeForCs.Append("\r\n /// <returns>对象列表</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{2}.GetObjLstBy{1}Lst_WA_Cache = function(arr{1})  ",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName, 
                    objPrjTabENEx.ClsName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{4}.GetObjLstBy{1}Lst_WA_Cache = function(arr{1}, {2})  ",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName,
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.TypeScriptType, 
                    objPrjTabENEx.ClsName);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetObjLstBy{1}Lst_Cache\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);

            strCodeForCs.AppendFormat("\r\n" + "const mapParam = new {0}();", ImportClass.GetOutString(string.Format("Dictionary", objPrjTabENEx.TabName), this.Is4RJ));
            if (objPrjTabENEx.objCacheClassifyFld != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"{0}\", {1});", objPrjTabENEx.objCacheClassifyFld.FldName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "type: \"POST\",");
            strCodeForCs.Append("\r\n" + "contentType: \"application/json; charset=utf-8\",");

            strCodeForCs.AppendFormat("\r\n" + "data: JSON.stringify(arr{0}),", objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObjLst = JSON.parse(data.returnObjLst);");
            strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
            strCodeForCs.AppendFormat("\r\n" + "const arrObjLst = cls{0}BL.GetObjLstByJSONObjLst(returnObjLst);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "resolve(arrObjLst);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_GetTopObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的记录对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"objTopPara\">获取顶部对象列表的参数对象</param>");    
            strCodeForCs.Append("\r\n /// <returns>获取的相应对象列表</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.GetTopObjLst = function(objTopPara)  ",
              objPrjTabENEx.TabName,
              objKeyField.FldName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetTopObjLst\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", 
                objPrjTabENEx.ClsName);

            strCodeForCs.AppendFormat("\r\n" + "const mapParam =  {0}.GetMapParam(objTopPara);",
                           ImportClass.GetOutString(string.Format("stuTopPara", objPrjTabENEx.TabName), this.Is4RJ));

            strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");

            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "type: \"POST\",");
            strCodeForCs.Append("\r\n" + "contentType: \"application/json; charset=utf-8\",");

            strCodeForCs.Append("\r\n" + "data: JSON.stringify(objTopPara),");
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObjLst = JSON.parse(data.returnObjLst);");
            strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
            strCodeForCs.AppendFormat("\r\n" + "const arrObjLst = cls{0}BL.GetObjLstByJSONObjLst(returnObjLst);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "resolve(arrObjLst);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");


            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_GetObjLstByPager()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的记录对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"objPagerPara\">分页获取对象列表的参数对象</param>");
            strCodeForCs.Append("\r\n /// <returns>获取的相应记录对象列表</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.GetObjLstByPager = function(objPagerPara)  ",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName, 
                    objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetObjLstByPager\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);

            strCodeForCs.AppendFormat("\r\n" + "const mapParam = {0}.GetMapParam(objPagerPara);",
                           ImportClass.GetOutString(string.Format("stuPagerPara", objPrjTabENEx.TabName), this.Is4RJ));

            strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");

            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "type: \"POST\",");
            strCodeForCs.Append("\r\n" + "contentType: \"application/json; charset=utf-8\",");

            strCodeForCs.Append("\r\n" + "data: JSON.stringify(objPagerPara),");
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObjLst = JSON.parse(data.returnObjLst);");
            strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
            strCodeForCs.AppendFormat("\r\n" + "const arrObjLst = cls{0}BL.GetObjLstByJSONObjLst(returnObjLst);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "resolve(arrObjLst);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Js_GetObjLstByPager_WA_Cache()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的记录对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"objPagerPara\">分页获取对象列表的参数对象</param>");
            strCodeForCs.Append("\r\n /// <returns>获取的相应记录对象列表</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.GetObjLstByPager_WA_Cache = function(objPagerPara)  ",
                objPrjTabENEx.TabName,
                objKeyField.FldName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetObjLstByPager_Cache\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);

            strCodeForCs.AppendFormat("\r\n" + "const mapParam = {0}.GetMapParam(objPagerPara);",
                           ImportClass.GetOutString(string.Format("stuPagerPara", objPrjTabENEx.TabName), this.Is4RJ));

            strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");

            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "type: \"POST\",");
            strCodeForCs.Append("\r\n" + "contentType: \"application/json; charset=utf-8\",");

            strCodeForCs.Append("\r\n" + "data: JSON.stringify(objPagerPara),");
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObjLst = JSON.parse(data.returnObjLst);");
            strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
            strCodeForCs.AppendFormat("\r\n" + "const arrObjLst = cls{0}BL.GetObjLstByJSONObjLst(returnObjLst);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "resolve(arrObjLst);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Js_GetSubObjLst_WA_Cache()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的记录对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}_Cond\">条件对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns>获取的相应记录对象列表</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.GetSubObjLst_WA_Cache = function(obj{0}_Cond)  ",
                objPrjTabENEx.TabName,
                objKeyField.FldName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetSubObjLst_Cache\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = {1}.GetSimObjFromObj(obj{0}_Cond);",
                 objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}BL", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, obj{0}EN_Sim);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObjLst = JSON.parse(data.returnObjLst);");
            strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
            strCodeForCs.AppendFormat("\r\n" + "const arrObjLst = cls{0}BL.GetObjLstByJSONObjLst(returnObjLst);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return (arrObjLst);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }



        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_GetFirstObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的记录对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件</param>");
            strCodeForCs.Append("\r\n /// <returns>获取的相应对象</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.GetFirstObj = function(strWhereCond)  ",
                objPrjTabENEx.TabName,
                objKeyField.FldName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetFirstObj\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);

            strCodeForCs.AppendFormat("\r\n" + "const mapParam = new {0}();", ImportClass.GetOutString(string.Format("Dictionary", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "mapParam.add(\"strWhereCond\", strWhereCond);");
            strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "params: { \"strWhereCond\": strWhereCond}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObj = JSON.parse(data.returnObj);");
            strCodeForCs.Append("\r\n" + "//console.log(returnObj);");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0} = cls{0}BL.GetObjFromJsonObj(returnObj);",              objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "return obj{0};",              objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");


            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_GetMaxStrId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取表的最大关键字");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>获取表的最大关键字</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.GetMaxStrId = function()  ",
                objPrjTabENEx.TabName,
                objKeyField.FldName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetMaxStrId\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "method: \"GET\",");
            strCodeForCs.Append("\r\n" + "dataType: \"json\",");

            //strCodeForCs.Append("\r\n" + "data: strData,");
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "resolve(data.returnStr);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_GetMaxStrIdByPrefix()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strCodeForCs.Append("\r\n /// <returns>获取当前表关键字值的最大值</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.GetMaxStrIdByPrefix = function(strPrefix)  ",
                objPrjTabENEx.TabName,
                objKeyField.FldName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetMaxStrIdByPrefix\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);

            strCodeForCs.AppendFormat("\r\n" + "const mapParam = new {0}();", ImportClass.GetOutString(string.Format("Dictionary", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "mapParam.add(\"strPrefix\", strPrefix);");
            strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");

            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "method: \"GET\",");
            strCodeForCs.Append("\r\n" + "dataType: \"json\",");

            strCodeForCs.Append("\r\n" + "data: strData,");
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "resolve(data.returnStr);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }



        /// <summary>
        /// 通用的调用WebApi函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_CallWebApi()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 通用的调用WebApi函数");
            strCodeForCs.AppendFormat("\r\n /// mapParam样例:{0} = \"01\"", objKeyField.PrivFuncName);

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"MethodName\">函数</param>");
            strCodeForCs.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strCodeForCs.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{0}.CallWebApi = function(strFunctionName, dictPara, myURL) ", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
           
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 通用的调用WebApi函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_CallWebApi_Ts_SelfDefWs()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 通用的调用WebApi函数");
//            strCodeForCs.AppendFormat("\r\n /// mapParam样例:{0} = \"01\"", objWebSrvClassENEx.ClassName);

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"MethodName\">函数</param>");
            strCodeForCs.Append("\r\n /// <param name = \"mapParam\">参数列表</param>");
            strCodeForCs.Append("\r\n /// <returns>获取相应的记录的对象</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{0}.CallWebApi = function(strFunctionName, dictPara, myURL) ", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            //strFunctionName = "mySum";
            strCodeForCs.Append("\r\n" + "const strPara;");
            strCodeForCs.Append("\r\n" + "strPara = \"\";");
            strCodeForCs.Append("\r\n" + "  var myKeyss = dictPara.keys();");
            strCodeForCs.Append("\r\n" + "             var intLength = dictPara.length();");
            strCodeForCs.Append("\r\n" + "for (let i = 0; i < intLength; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const key = myKeyss[i];");
            strCodeForCs.Append("\r\n" + "const value = dictPara.getItem(key);");
            strCodeForCs.Append("\r\n" + "const strTemp = \"<\" +key + \">\" +value + \"</\" +key + \">\", ;");
            strCodeForCs.Append("\r\n" + "strPara = strPara + strTemp;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "const data;");
            strCodeForCs.Append("\r\n" + "data = '<?xml version=\"1.0\" encoding=\"utf-8\"?>';");
            strCodeForCs.Append("\r\n" + "data = data + '<soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">';");
            strCodeForCs.Append("\r\n" + "data = data + '<soap:Body>';");
            strCodeForCs.Append("\r\n" + "data = data + \"<\" +strFunctionName + \" xmlns=\"http://tempuri.org/\">' ;");
            strCodeForCs.Append("\r\n" + "            data = data + strPara;");
            strCodeForCs.Append("\r\n" + "data = data + \"</\" +strFunctionName + \">\";");
            strCodeForCs.Append("\r\n" + "data = data + '</soap:Body>';");
            strCodeForCs.Append("\r\n" + "data = data + '</soap:Envelope>';");
            strCodeForCs.Append("\r\n" + "            xmlhttp = getXmlHttp();");
            strCodeForCs.Append("\r\n" + "const URL = myURL;//WEB_SERVICE_URL;//\"http://localhost:2408/ExamLib/WebApi/MyTest1Service.asmx\";");
            strCodeForCs.Append("\r\n" + "xmlhttp.open(\"POST\", URL, true);");
            strCodeForCs.Append("\r\n" + "xmlhttp.setRequestHeader(\"Content-Type\", \"text/xml; charset=gb2312\";");
            strCodeForCs.Append("\r\n" + "const strSOAPAction = \"http://tempuri.org/\" +strFunctionName;");
            strCodeForCs.Append("\r\n" + "xmlhttp.setRequestHeader(\"SOAPAction\", strSOAPAction);");
            strCodeForCs.Append("\r\n" + "xmlhttp.send(data);");
            strCodeForCs.Append("\r\n" + "xmlhttp.onreadystatechange = function() {");
            strCodeForCs.Append("\r\n" + "//HTTP 请求的状态.当一个 XMLHttpRequest 初次创建时，这个属性的值从 0 开始，直到接收到完整的 HTTP 响应，这个值增加到 4  ");
            strCodeForCs.Append("\r\n" + "if (xmlhttp.readyState === 4)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "getReturnValue(strFunctionName);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 继承Runnable类必须实现的【run】函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_main()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 继承Runnable类必须实现的【run】函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "{0}.main = function()", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "switch (this.MethodName)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "case \"GetJSONObjBy{1}\":",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 1;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{2}.GetJSONObjBy{1}(this.Param);",
                objPrjTabENEx.TabName,
                objKeyField.FldName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case \"GetJSONObjLst\":",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 2;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{1}.GetJSONObjLst(this.Param);",
                objPrjTabENEx.TabName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"AddNewRecordByJSON\":");
            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 3;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{1}.AddNewRecordByJSON(this.Param, this.obj{0}EN);",
                objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case \"UpdateRecordByJSON\":");
            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 4;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{1}.UpdateRecordByJSON(this.Param, this.obj{0}EN);",
                objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case \"DelRecord\":");
            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 5;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}.DelRecord(this.Param);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case \"GetFirstJSONObj\":",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 6;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{1}.GetFirstJSONObj(this.Param);",
                objPrjTabENEx.TabName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case \"IsExistRecord\":",
    objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 7;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{1}.IsExistRecord(this.Param);",
                objPrjTabENEx.TabName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case \"GetMaxStrId\":",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 8;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{1}.GetMaxStrId(this.Param);",
                objPrjTabENEx.TabName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.AppendFormat("\r\n" + "case \"GetMaxStrIdByPrefix\":",
             objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 9;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{1}.GetMaxStrIdByPrefix(this.Param);",
                objPrjTabENEx.TabName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case \"GetTopJSONObjLst\":",
objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 10;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{1}.GetTopJSONObjLst(this.Param);",
                objPrjTabENEx.TabName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case \"GetJSONObjLstByPager\":",
objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 11;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{1}.GetJSONObjLstByPager(this.Param);",
                objPrjTabENEx.TabName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.AppendFormat("\r\n" + "case \"GetRecCountByCond\":",
objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = 12;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{1}.GetRecCountByCond(this.Param);",
                objPrjTabENEx.TabName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(err)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 继承Runnable类必须实现的【run】函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_main_Ts_SelfDefWs()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 继承Runnable类必须实现的【run】函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "{0}.main = function()", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "switch (this.MethodName)");
            strCodeForCs.Append("\r\n" + "{");
            int intIndex = 50;
            foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
            {
                if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                strCodeForCs.AppendFormat("\r\n" + "case \"{0}\":",
              objWebSrvFunctionsENEx.FunctionName);
                strCodeForCs.AppendFormat("\r\n" + "ResponseData.what = {0};", intIndex);

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}.{1}(this.Param);",
                    objWebSrvClassENEx.ClassName,
                    objWebSrvFunctionsENEx.FunctionName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(err)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "myShowErrorMsg(err.message);");
                strCodeForCs.Append("\r\n" + "}");
                             
               
                strCodeForCs.Append("\r\n" + "break;");
                intIndex++;
            }
            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 继承Runnable类必须实现的【run】函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_start()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 继承Runnable类必须实现的【run】函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "{0}.start = function()", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_GetObjByKeyId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字获取相应的记录的对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">关键字</param>", objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n /// <returns>对象</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{4}.GetObjBy{0} = function({1})  ",
                KeyFldName,
                objKeyField.PrivFuncName, 
                KeyDataType, 
                objPrjTabENEx.TabName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetObjBy{1}\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);

            strCodeForCs.AppendFormat("\r\n" + "const mapParam = new {0}();", ImportClass.GetOutString(string.Format("Dictionary", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"{0}\", {1});", objKeyField.FldName, objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");

            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "method: \"GET\",");
            strCodeForCs.Append("\r\n" + "dataType: \"json\",");

            strCodeForCs.Append("\r\n" + "data: strData,");

            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");            
            strCodeForCs.Append("\r\n" + "const returnObj = JSON.parse(data.returnObj);");
            strCodeForCs.Append("\r\n" + "//console.log(returnObj);");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0} = cls{0}BL.GetObjFromJsonObj(returnObj);", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "resolve(obj{0});", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");
            
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_GetObjByKeyId_WA_Cache()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字获取相应的对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">关键字</param>", objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n /// <returns>对象</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{4}.GetObjBy{0}_WA_Cache = function({1})  ",
                        KeyFldName,
                        objKeyField.PrivFuncName, 
                        KeyDataType, 
                        objPrjTabENEx.TabName, 
                        objPrjTabENEx.ClsName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{6}.GetObjBy{0}_WA_Cache = function({1}, {4})  ",
                        KeyFldName,
                        objKeyField.PrivFuncName, 
                        KeyDataType, 
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                        objPrjTabENEx.objCacheClassifyFld.TypeScriptType, 
                        objPrjTabENEx.ClsName);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetObjBy{1}_Cache\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);

            strCodeForCs.AppendFormat("\r\n" + "const mapParam = new {0}();", ImportClass.GetOutString(string.Format("Dictionary", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"{0}\", {1});", objKeyField.FldName, objKeyField.PrivFuncName);
            if (objPrjTabENEx.objCacheClassifyFld != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"{0}\", {1});", objPrjTabENEx.objCacheClassifyFld.FldName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");

            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "method: \"GET\",");
            strCodeForCs.Append("\r\n" + "dataType: \"json\",");

            strCodeForCs.Append("\r\n" + "data: strData,");

            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObj = JSON.parse(data.returnObj);");
            strCodeForCs.Append("\r\n" + "//console.log(returnObj);");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0} = cls{0}BL.GetObjFromJsonObj(returnObj);", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "resolve(obj{0});", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");
            
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 获取返回值函数
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_getReturnValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取返回值函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "  function getReturnValue(strFunctionName) {");
            strCodeForCs.Append("\r\n" + "//alert(xmlhttp.readyState);");
            strCodeForCs.Append("\r\n" + "////5。接收响应数据");
            strCodeForCs.Append("\r\n" + "////判断对象的状态是交互完成");
            strCodeForCs.Append("\r\n" + "                //判断http的交互是否成功");
            strCodeForCs.Append("\r\n" + "if (xmlhttp.status !== 200)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(\"出错了!!!\";");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//使用responseXML的方式来接收XML数据对象的DOM对象");
            strCodeForCs.Append("\r\n" + "const domObj = xmlhttp.responseXML;");
            strCodeForCs.Append("\r\n" + "if (domObj)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//<message>123123123</message>");
            strCodeForCs.Append("\r\n" + "//dom中利用getElementsByTagName可以根据标签名来获取元素节点，返回的是一个数组");
            strCodeForCs.Append("\r\n" + "const strReturnTag = strFunctionName + \"Result\";");
            strCodeForCs.Append("\r\n" + "const messageNodes = domObj.getElementsByTagName(strReturnTag);");

            strCodeForCs.Append("\r\n" + "if (messageNodes.length > 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//获取message节点中的文本内容");
            strCodeForCs.Append("\r\n" + "//message标签中的文本在dom中是message标签所对应的元素节点的字节点，firstChild可以获取到当前节点的第一个子节点");
            strCodeForCs.Append("\r\n" + "//通过以下方式就可以获取到文本内容所对应的节点");
            strCodeForCs.Append("\r\n" + "const textNode = messageNodes[0].firstChild;");
            strCodeForCs.Append("\r\n" + "//对于文本节点来说，可以通过nodeValue的方式返回文本节点的文本内容");
//            strCodeForCs.Append("\r\n" + "const responseMessage = textNode.nodeValue;");
            strCodeForCs.Append("\r\n" + "const responseMessage = \"\";");
            strCodeForCs.Append("\r\n" + "if (textNode === null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "responseMessage = \"\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "responseMessage = textNode.nodeValue;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "ResponseData.errorId = 0;");
            strCodeForCs.Append("\r\n" + "ResponseData.IsFinished = true;");
            strCodeForCs.Append("\r\n" + "ResponseData.data = responseMessage;");
            strCodeForCs.Append("\r\n" + "ReCallFunc();");
            strCodeForCs.Append("\r\n" + "//alert(ResponseData.data);");
            strCodeForCs.Append("\r\n" + "//将数据显示在页面上");
            strCodeForCs.Append("\r\n" + "//通过dom的方式找到div标签所对应的元素节点");
            strCodeForCs.Append("\r\n" + "//var divNode = document.getElementById(\"result\";");
            strCodeForCs.Append("\r\n" + "////设置元素节点中的html内容");
            strCodeForCs.Append("\r\n" + "//divNode.innerHTML = responseMessage;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "ResponseData.IsFinished = true;");
            strCodeForCs.Append("\r\n" + "ResponseData.errorId = 1;");
            strCodeForCs.Append("\r\n" + "ResponseData.faultString = \"XML数据格式错误\";");

            strCodeForCs.Append("\r\n" + "myShowErrorMsg(\"XML数据格式错误，原始文本内容为: \" + xmlhttp.responseText);");
            strCodeForCs.Append("\r\n" + "ReCallFunc();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "myShowErrorMsg(\"XML数据格式错误，原始文本内容为: \" + xmlhttp.responseText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            clsDataTypeAbbrEN objFuncReturnTypeEN = clsDataTypeAbbrBL.GetObjByDataTypeId_Cache(objWebSrvFunctionsENEx.ReturnTypeID);
            clsSelfDefDataTypeEN objSelfDefDataTypeEN = null;
            if (objFuncReturnTypeEN == null)
            {
                objSelfDefDataTypeEN = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFunctionsENEx.ReturnType);
                if (objSelfDefDataTypeEN == null)
                {
                    strMsg = string.Format("函数的返回类型: [{0}({1})]没有处理，不能生成相应代码。", objWebSrvFunctionsENEx.ReturnTypeID, objWebSrvFunctionsENEx.ReturnType);
                    throw new Exception(strMsg);
                }
            }

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();

            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeId_Cache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("函数参数的数据类型: [{0}({1})]没有处理，不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {

                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">引用型参数,返回:{1}</param>",
                        objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("ref {0} {1},", objSelfDefDataTypeEN_Para.CsType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("ref {0} {1},", objDataTypeAbbrEN.CsType, objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("ref {0},", objWebSrvFuncParaEN.ParaName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>",
                        objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objSelfDefDataTypeEN_Para.CsType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objDataTypeAbbrEN.CsType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("{0},", objWebSrvFuncParaEN.ParaName);
                }

            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }
            strCodeForCs.AppendFormat("\r\n /// <returns>返回{0}</returns>",
                objWebSrvFunctionsENEx.ReturnValueDescription);
            if (objSelfDefDataTypeEN != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{3}.{1} = function(mapParam)",
                        objSelfDefDataTypeEN.CsType, 
                        objWebSrvFunctionsENEx.FunctionName,
                        sbParaList.ToString(), 
                        objPrjTabENEx.ClsName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{3}.{1} = function(mapParam)",
                       objFuncReturnTypeEN.CsType, 
                       objWebSrvFunctionsENEx.FunctionName,
                       sbParaList.ToString(), 
                       objPrjTabENEx.ClsName);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMethodName = \"{0}\";",
              objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{        ");
            strCodeForCs.AppendFormat("\r\n" + "return this.CallWebApi(strMethodName, mapParam, this.WEB_SERVICE_URL);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "catch (objException)");
            strCodeForCs.Append("\r\n" + "{        ");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"在调用WebApi函数:[{0}]时出错，错误信息:\" + objException.message;",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n" + "throw strMsg;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        
        public string Gen_4WA_Js_ClassConstructor1()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;
            strCodeForCs.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strCodeForCs.Append("\r\n {");

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Js_ComboBoxBindFunction()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";

            try
            {
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                   
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 绑定基于Win的下拉框");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name=\"objComboBox\">需要绑定当前表的下拉框</param>");
                    strCodeForCs.AppendFormat("\r\n" + "{1}.BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox) ",
                            strValueFieldName, 
                            objPrjTabENEx.ClsName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//为数据源为表的下拉框设置内容");
                    strCodeForCs.AppendFormat("\r\n" + "Array<{1}> arrObjLst = GetObjLst(\"1=1\";",
                    objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));


                    strCodeForCs.AppendFormat("\r\n" + "{1} obj{0}EN;",
                    objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
                    strCodeForCs.AppendFormat("\r\n" + "//初始化一个对象列表");
                    //strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                    //objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new {1}();",
                    objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"0\";",
                    objPrjTabENEx.TabName, strValueFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"选[{2}]...\";",
                        objPrjTabENEx.TabName, strTextFieldName, objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "arrObjLst.Insert(0, obj{0}EN);",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//把DataTable中的所有项均加到对象列表中");
            
                    strCodeForCs.Append("\r\n" + "//设置下拉框的数据源、以及设置值项、显示项");
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = arrObjLst;",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember=\"{1}\";",
                            objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember=\"{1}\";",
                           objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Js_DdlBindFunction()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";
            try
            {
                ///生成仅有变量;
                //绑定下拉框的函数 代码;
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                   
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 绑定基于Web的下拉框");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name=\"objDDL\">需要绑定当前表的下拉框</param>");
                    strCodeForCs.AppendFormat("\r\n" + "this.BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL) ",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");

                    strCodeForCs.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"选[{0}]...\",\"0\";",
                          objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "Array<{1}> arrObjLst = GetObjLst(\"1=1\";",
                        objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField=\"{1}\";",
                        objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField=\"{1}\";",
                        objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = arrObjLst;");
                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }

            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Js_CheckPropertyNew()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\npublic void CheckPropertyNew({1} obj{0}EN)",
            objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.IsTabNullable = false && objField.FieldTypeId != "02")
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                        continue;
                    }
                    strCodeForCs.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        strPrivPropNameWithObjectName);
                    strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString() == \"\")",
                         strPrivPropNameWithObjectName);

                    if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                    {
                        strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString() == \"0\")",
                             strPrivPropNameWithObjectName);
                    }
                    strCodeForCs.Append(")");
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\n throw new Exception(\"字段[{0}]不能为空(NULL)!\";",
                    objField.ColCaption);
                    strCodeForCs.Append("\r\n}");
                }


            }
            ///检查属性长度代码;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strCodeForCs.AppendFormat("\r\nif (!Object.Equals(null, {0}) && GetStrLen({0}) > {1})",
                         strPrivPropNameWithObjectName,
                          objField.ObjFieldTabENEx.FldLength);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\n throw new Exception(\"字段[{0}]的长度不能超过{1}!\";",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldLength.ToString().Trim());
                    strCodeForCs.Append("\r\n}");
                }
            }
            strCodeForCs.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n }");
            ///检查类中属性是否正确 == == ;
            return strCodeForCs.ToString();
        }
            
        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_GetFirstId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的记录对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件</param>");
            strCodeForCs.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.GetFirstID = function(strWhereCond)  ",
              objPrjTabENEx.TabName,
              objKeyField.FldName, 
              objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetFirstID\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
                        
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "params: { \"strWhereCond\": strWhereCond}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return data.returnStr;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_GetNameByKeyId_Cache()
        {
            string strTextFieldName = "";
            string strValueFieldName = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")
                {
                    strValueFieldName = objField.ObjFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == "03")
                {
                    strTextFieldName = objField.ObjFieldTabENEx.FldName;
                }
            }
            if (strValueFieldName == "" || strTextFieldName == "")
            {
                return "";
            }
            StringBuilder strCodeForCs = new StringBuilder();
            ///根据关键字获取相关对象, 从缓存的对象列表中获取.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 根据关键字获取相关名称, 从缓存的对象列表中获取.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">所给的关键字</param>", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n /// <returns>根据关键字获取的名称</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{5}.Get{4}By{1}_Cache = function({2} {3}) ",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    strTextFieldName, 
                    objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "//初始化列表缓存");
            strCodeForCs.Append("\r\n" + "InitListCache(); ");


            strCodeForCs.Append("\r\n" + "int intStart = 0;");
            strCodeForCs.AppendFormat("\r\n" + "int intEnd = arr{0}ObjLst_Cache.Count - 1;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "int intMid = 0;");
            strCodeForCs.AppendFormat("\r\n" + "{1} obj{0}EN = null;",
                 objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "while (intEnd >= intStart)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intMid = (intStart + intEnd) / 2;");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = arr{0}ObjLst_Cache[intMid];",
              objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intFindFailCount = 0;");
            strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN.{1};",
                  objPrjTabENEx.TabName,
                  strTextFieldName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if (obj{0}EN.{1}.CompareTo({2}) > 0)",
                  objPrjTabENEx.TabName,
                  objKeyField.FldName,
                  objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intEnd = intMid - 1;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intStart = intMid + 1;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "intFindFailCount++;");
            strCodeForCs.AppendFormat("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst_Cache = null;", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (intFindFailCount == 1) return Get{0}By{1}_Cache({2});",
                strTextFieldName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n" + "string strErrMsgForGetObjById = \"在{2}对象缓存列表中,找不到记录[{3} = {{ {4} }}][intFindFailCount = {{intFindFailCount}}](函数:{{clsStackTrace.GetCurrFunction()}})\";",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN != null)",
                  objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "strErrMsgForGetObjById += \"最后一次查找的对象相关字段属性值:{{obj{2}EN.{3} }}.[intMid = {{intMid}}]\";",
               "{", "}",
               objPrjTabENEx.TabName,
               objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "strErrMsgForGetObjById += \"最后一次查找的对象为null, 请检查![intMid = {{intMid}}]\";",
               "{", "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"{3}\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\";",
               objPrjTabENEx.TabName,
                objKeyField.FldName,
                strTextFieldName,
                           ImportClass.GetOutString(string.Format("cls{0}BL", objPrjTabENEx.TabName), this.Is4RJ));
            //strCodeForCs.Append("\r\n" + "// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用");
            //strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst_Cache = null;",
            //       objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "throw new Exception(strErrMsgForGetObjById);");
            //strCodeForCs.AppendFormat("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            ///根据关键字获取相关对象, 从缓存的对象列表中获取. == = ;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 初始化列表缓存.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_InitListCache()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //初始化列表缓存.-----------------------------;


            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 初始化列表缓存.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "{0}.InitListCache = function() ", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
           
            strCodeForCs.Append("\r\n" + "//初始化列表缓存");
            
            if (objPrjTabENEx.SqlDsTypeId == clsSQLDSTypeBLEx.SQLTAB)
            {
                strCodeForCs.Append("\r\n" + "//检查缓存刷新机制");
                strCodeForCs.Append("\r\n" + "let strMsg = \"\";");
                strCodeForCs.AppendFormat("\r\n" + "if ({0}_objCommFun4BL == null)", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strMsg = \"类cls{0}WApi没有刷新缓存机制({0}_objCommFun4BL == null), 请联系程序员！\";",
                     objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
            }
            else if (objPrjTabENEx.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW)
            {
                string strRelaTabId4View = objPrjTabENEx.RelaTabId4View;

                //List<string> arrTabId = clsPrjTabBLEx.GetRelaParentNodeByTabId(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabId_Cache(strRelaTabId4View, objPrjTabENEx.PrjId);
                if (objPrjTab.SqlDsTypeId != clsSQLDSTypeBLEx.SQLVIEW)
                {                    
                    strCodeForCs.AppendFormat("\r\n" + "if ({1}.objCommFun4BL == null)", objPrjTab.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTab.TabName), this.Is4RJ));
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = \"类cls{0}WApi没有刷新缓存机制({0}_objCommFun4BL == null), 请联系程序员！(from {{clsStackTrace.GetCurrClassFunction()}})\";",
                         objPrjTab.TabName);
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                    strCodeForCs.Append("\r\n" + "}");

                }
                //bool bolIsDef_strMsg = false;
                //foreach (string strRelaTabId in arrTabId)
                //{
                //    clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabId_Cache(strRelaTabId, objPrjTabENEx.PrjId);
                //    if (objPrjTab.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW) continue;
                //    if (objPrjTab.TabName == "Sex")
                //    {
                //        string strMsg = string.Format("objPrjTab.TabName={0}，objPrjTab.TabStateId='{1}'",
                //            objPrjTab.TabName, objPrjTab.TabStateId);
                //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                //    }
                //    if (objPrjTab.TabStateId != "01") continue;

                //    if (bolIsDef_strMsg == false)
                //    {
                //        strCodeForCs.Append("\r\n" + "//检查缓存刷新机制");
                //        strCodeForCs.Append("\r\n" + "let strMsg = \"\";");
                //        bolIsDef_strMsg = true;
                //    }
                //    strCodeForCs.AppendFormat("\r\n" + "if ({1}.objCommFun4BL == null)", objPrjTab.TabName,
                //           ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTab.TabName), this.Is4RJ));
                //    strCodeForCs.Append("\r\n" + "{");
                //    strCodeForCs.AppendFormat("\r\n" + "strMsg = \"类cls{2}WApi没有刷新缓存机制({2}_objCommFun4BL == null), 请联系程序员！(from {{clsStackTrace.GetCurrClassFunction()}})\";",
                //        "{", "}", objPrjTab.TabName);
                //strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                //    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                //    strCodeForCs.Append("\r\n" + "}");
                //}
            }
            strCodeForCs.Append("\r\n" + "}");

            //初始化列表缓存.======================= = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Js_ReFreshCache()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{0}.ReFreshCache = function()", objPrjTabENEx.ClsName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{2}.ReFreshCache = function({0})",
                        objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                        objPrjTabENEx.objCacheClassifyFld.TypeScriptType, 
                        objPrjTabENEx.ClsName);
            }
            strCodeForCs.Append("\r\n" + "{");
                
            strCodeForCs.AppendFormat("\r\n" + "if ({0}_objCommFun4BL != null) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + " const strMsg = \"刷新缓存成功！\";");
  
            strCodeForCs.Append("\r\n" + "console.log(strMsg);");

            strCodeForCs.Append("\r\n" + "// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
       
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = {1}._CurrTabName;",
                    objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = {2}._CurrTabName + \"_\" + {1};",
                                objPrjTabENEx.TabName, 
                                objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            }

            strCodeForCs.AppendFormat("\r\n" + "switch (cls{0}EN.CacheModeId)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "case \"04\"://sessionStorage");
            strCodeForCs.AppendFormat("\r\n" + "sessionStorage.removeItem(strKey);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case \"03\"://localStorage");
            strCodeForCs.AppendFormat("\r\n" + "localStorage.removeItem(strKey);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case \"02\"://ClientCache");
            strCodeForCs.AppendFormat("\r\n" + "{1}.Remove(strKey);", objPrjTabENEx.TabName,
                      ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.AppendFormat("\r\n" + "{1}.Remove(strKey);", objPrjTabENEx.TabName,
                                  ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ)); 
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");

            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{0}_objCommFun4BL.ReFreshCache();",
                objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{0}_objCommFun4BL.ReFreshCache({1});",
             objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
        
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Js_ReFreshThisCache()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 刷新本类中的缓存.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{0}. ReFreshThisCache = function()", 
                    objPrjTabENEx.ClsName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{2}. ReFreshThisCache = function({0})",
                        objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                        objPrjTabENEx.objCacheClassifyFld.TypeScriptType, 
                        objPrjTabENEx.ClsName);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strMsg = \"\";");
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.spSetRefreshCacheOn == true)",
                           ImportClass.GetOutString(string.Format("clsSysPara4WebApi", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = {1}._CurrTabName;",
                    objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = {2}._CurrTabName + \"_\" + {1} ;",
                                objPrjTabENEx.TabName, 
                                objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            }

            strCodeForCs.AppendFormat("\r\n" + "switch (cls{0}EN.CacheModeId)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "case \"04\"://sessionStorage");
            strCodeForCs.AppendFormat("\r\n" + "sessionStorage.removeItem(strKey);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case \"03\"://localStorage");
            strCodeForCs.AppendFormat("\r\n" + "localStorage.removeItem(strKey);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "case \"02\"://ClientCache");
            strCodeForCs.AppendFormat("\r\n" + "{1}.Remove(strKey);", objPrjTabENEx.TabName,
                      ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "default:");
            strCodeForCs.AppendFormat("\r\n" + "{1}.Remove(strKey);", objPrjTabENEx.TabName,
                                  ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            
            strCodeForCs.AppendFormat("\r\n" + "strMsg = \"刷新缓存成功\";");

            strCodeForCs.Append("\r\n" + "console.trace(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "strMsg = \"刷新缓存已经关闭。({0}.spSetRefreshCacheOn == false)\";",
                           ImportClass.GetOutString(string.Format("clsSysPara4WebApi", objPrjTabENEx.TabName), this.Is4RJ)                           );
            strCodeForCs.Append("\r\n" + "console.log(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Js_DefineObjCommFun4BL()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;
            strCodeForCs.Append("\r\n" + " /// <summary>");
            strCodeForCs.Append("\r\n" + "/// 专门在逻辑层用于处理缓存等公共函数的对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{0}.objCommFun4BL;", objPrjTabENEx.ClsName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{0}.objCommFun4BL;", objPrjTabENEx.ClsName);
            }
      
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Js_GetObjLstByRange()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的记录对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"objRangePara\">根据范围获取对象列表的参数对象</param>");
            strCodeForCs.Append("\r\n /// <returns>获取的相应记录对象列表</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.GetObjLstByRange = function(objRangePara)  ",
                objPrjTabENEx.TabName,
                objKeyField.FldName, 
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n{");
  
            strCodeForCs.Append("\r\n" + "const strAction = \"GetObjLstByRange\";");
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);

            strCodeForCs.AppendFormat("\r\n" + "const mapParam = {0}.GetMapParam(objRangePara);",
                           ImportClass.GetOutString(string.Format("stuRangePara", objPrjTabENEx.TabName), this.Is4RJ));

            strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");

            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "type: \"POST\",");
            strCodeForCs.Append("\r\n" + "contentType: \"application/json; charset=utf-8\",");

            strCodeForCs.Append("\r\n" + "data: JSON.stringify(objRangePara),");

            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const returnObjLst = JSON.parse(data.returnObjLst);");
            strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
            strCodeForCs.AppendFormat("\r\n" + "const arrObjLst = cls{0}BL.GetObjLstByJSONObjLst(returnObjLst);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "resolve(arrObjLst);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_DelRecords()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字列表删除记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>实际删除记录的个数</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.DelRecords = function(strKeyIdLst) ",
                    objPrjTabENEx.TabName, 
                    objKeyField.FldName, 
                    objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "string strAction = \"DelRecords\";", objPrjTabENEx.TabName);
            
            
            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new();");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "int intResult  = int.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "return intResult;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return 0;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = \"执行WebApi功能出错, {HttpUtility.UrlDecode(objException.Message)}.(from {clsStackTrace.GetCurrClassFunction()}). WebApi地址:{2}).\",");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 按标志删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_DelRecordBySign()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字列表按标志删除记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"arr{0}\">关键字列表</param>", objKeyField.FldName);
            strCodeForCs.Append("\r\n /// <returns>实际删除记录的个数</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.DelRecordBySign = function(arr{1}) ",
                    objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"DelRecordBySign\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "type: \"POST\",");
            strCodeForCs.Append("\r\n" + "contentType: \"application/json; charset=utf-8\",");

            strCodeForCs.AppendFormat("\r\n" + "data: JSON.stringify(arr{0}),", objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "resolve(data.returnInt);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 按标志删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_UnDelRecordBySign()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字列表按标志恢复记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"arr{0}\">关键字列表</param>", objKeyField.FldName);
            strCodeForCs.Append("\r\n /// <returns>实际恢复记录的个数</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.UnDelRecordBySign = function(arr{1}) ",
                    objPrjTabENEx.TabName, 
                    objKeyField.FldName, 
                    objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"UnDelRecordBySign\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "type: \"POST\",");
            strCodeForCs.Append("\r\n" + "contentType: \"application/json; charset=utf-8\",");

            strCodeForCs.AppendFormat("\r\n" + "data: JSON.stringify(arr{0}),", objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "resolve(data.returnInt);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Js_DelMultiRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字列表删除记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"arr{0}\">关键字列表</param>", objKeyField.FldName);
            strCodeForCs.Append("\r\n /// <returns>实际删除记录的个数</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.Del{0}s = function(arr{1}) ",
                    objPrjTabENEx.TabName, 
                    objKeyField.FldName, 
                    objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"Del{0}s\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "type: \"POST\",");
            strCodeForCs.Append("\r\n" + "contentType: \"application/json; charset=utf-8\",");

            strCodeForCs.AppendFormat("\r\n" + "data: JSON.stringify(arr{0}),", objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "resolve(data.returnInt);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }



        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_DelMultiRecordByCond()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件删除记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>实际删除记录的个数</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{1}.Del{0}sByCond = function(strWhereCond) ",
                    objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"Del{0}sByCond\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
                      
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "type: \"POST\",");
            strCodeForCs.Append("\r\n" + "contentType: \"application/json; charset=utf-8\",");

            strCodeForCs.Append("\r\n" + "data: {\"\":strWhereCond},");
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "resolve(data.returnInt);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 添加记录,并且返回关键字
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_AddNewRecordWithReturnKey()
        {
            //if (objKeyField.PrimaryTypeId != "02") return "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加的表对象</param>",
                    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns>返回新添加记录的关键字</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{1}.AddNewRecordWithReturnKey = function(obj{0}EN) ",
                    objPrjTabENEx.TabName, 
                    objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strAction = \"AddNewRecordWithReturnKey\";");
           
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = {1}.GetSimObjFromObj(obj{0}EN);",
               objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}BL", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, obj{0}EN_Sim);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "const data = response.data;");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return (data.returnStr);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 添加记录,并且返回关键字
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_UpdateWithCondition()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件来修改记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的对象</param>",
                  objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{1}.UpdateWithCondition = function(obj{0}EN, strWhereCond ) ",
                    objPrjTabENEx.TabName, 
                    objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strAction = \"UpdateWithCondition\";");
            strCodeForCs.AppendFormat("\r\n" + " if (obj{0}EN.sf_UpdFldSetStr === undefined || obj{0}EN.sf_UpdFldSetStr === null || obj{0}EN.sf_UpdFldSetStr === \"\")",
             objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"对象(关键字:\" + obj{0}EN.{1} + \")的【修改字段集】为空，不能修改!\";",
                objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + " throw new Error(strMsg);");
            strCodeForCs.Append("\r\n" + " }");

            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);


            strCodeForCs.AppendFormat("\r\n" + "const mapParam = new {0}();", ImportClass.GetOutString(string.Format("Dictionary", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "mapParam.add(\"strWhereCond\", strWhereCond);");
            strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");

            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "type: \"POST\",");
            strCodeForCs.Append("\r\n" + "contentType: \"application/json; charset=utf-8\",");

            //      data: obj{0}EN,
            strCodeForCs.Append("\r\n" + "data: strData,");
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "resolve(data.returnBool);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Js_IsExist()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字判断是否存在记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">关键字</param>", objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n /// <returns>是否存在?存在返回True</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.IsExist = function({0}) ",
                        objKeyField.PrivFuncName, 
                        KeyDataType, 
                        objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//检测记录是否存在");
            strCodeForCs.Append("\r\n" + "const strAction = \"IsExist\";");
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "const mapParam = new {0}();", ImportClass.GetOutString(string.Format("Dictionary", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"{0}\", {1});", objKeyField.FldName, objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "const strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");

            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "method: \"GET\",");
            strCodeForCs.Append("\r\n" + "dataType: \"json\",");

            strCodeForCs.Append("\r\n" + "data: strData,");
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            //strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "resolve(data.returnBool);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问地址:\" + strUrl + \"不成功！\";");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Js_GetWebApiUrl()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取WebApi的地址");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>返回当前文件中Web服务的地址</returns>");
            strCodeForCs.AppendFormat("\r\n"+ "{0}.GetWebApiUrl = function(strController, strAction) {{", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "const strServiceUrl;");
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.bolIsLocalHost == false) {{",
                           ImportClass.GetOutString(string.Format("clsSysPara4WebApi", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.AppendFormat("\r\n" + "strServiceUrl = \"http://\" + {0}.CurrIPAddressAndPort+ \"/\" + {0}.CurrPrx+ \"/\" + strController+ \"/\" + strAction;",
                           ImportClass.GetOutString(string.Format("clsSysPara4WebApi", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else {");
            strCodeForCs.AppendFormat("\r\n" + "strServiceUrl = \"http://\" +  {0}.CurrIPAddressAndPort_Local+ \"/\" +  {0}.CurrPrx+ \"/\" + strController+ \"/\" + strAction;",
                           ImportClass.GetOutString(string.Format("clsSysPara4WebApi", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return strServiceUrl;");
            strCodeForCs.Append("\r\n" + "}");

            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        public string A_GenCode4Function_TypeScript(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                if (objvFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                {
                    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                }
                else
                {
                    strTemp = A_GeneFuncCode_TypeScript(objvFunction4GeneCodeEN);
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

    }
}
