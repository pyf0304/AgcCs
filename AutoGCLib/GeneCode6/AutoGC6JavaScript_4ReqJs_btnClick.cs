using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;


using AGC.Entity;

using com.taishsoft.datetime;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using System.Reflection;
using AgcCommBase;
using CodeStruct;

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
    partial class AutoGC6_WApi : clsGeneCodeBase4Tab
    {


        #region 构造函数

        public AutoGC6_WApi(string strTabId,  string strPrjDataBaseId, string strPrjId)
          : base(strTabId,  strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
        }
        #endregion
        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        public string A_GenCode4Function_4ReqJs_Js_btnClick(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                // clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                string strCondition = string.Format("{0}='{1}'", convFunction4GeneCode.FuncId4GC, strFuncId4GC);
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBL.GetFirstObj_S(strCondition);

                //strFuncName = objFunction4GeneCodeEN.FuncName;

                //if (objFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                //{
                //    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
                //        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                //}
                //else
                //{
                //    strTemp = A_GeneFuncCode_Ts_btnClick(strFuncName);
                //}
                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
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


        public string A_GeneFuncCode_4ReqJs_Js_btnClick(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            try
            {               
                switch (objvFunction4GeneCodeEN.FuncName)
                {                  

                    case "Gen_4ReqJs_Js_btnClickGetFirstObj":
                        return Gen_4ReqJs_Js_btnClickGetFirstObj(objvFunction4GeneCodeEN);

                    case "Gen_4ReqJs_Js_btnClickGetObjByKey":
                        return Gen_4ReqJs_Js_btnClickGetObjByKey(objvFunction4GeneCodeEN);

                    case "Gen_4ReqJs_Js_btnClickDelRecord":
                        return Gen_4ReqJs_Js_btnClickDelRecord(objvFunction4GeneCodeEN);
                    case "Gen_4ReqJs_Js_btnClickDelRecords":
                        return Gen_4ReqJs_Js_btnClickDelRecords(objvFunction4GeneCodeEN);
                    case "Gen_4ReqJs_Js_btnClickDelMultiRecord":
                        return Gen_4ReqJs_Js_btnClickDelMultiRecord(objvFunction4GeneCodeEN);
                    case "Gen_4ReqJs_Js_btnClickDelMultiRecordByCond":
                        return Gen_4ReqJs_Js_btnClickDelMultiRecordByCond(objvFunction4GeneCodeEN);


                    case "Gen_4ReqJs_Js_btnClickAddNewRecord":
                        return Gen_4ReqJs_Js_btnClickAddNewRecord(objvFunction4GeneCodeEN);

                    case "Gen_4ReqJs_Js_btnClickAddNewRecord4GetMaxStrId":
                        return Gen_4ReqJs_Js_btnClickAddNewRecord4GetMaxStrId(objvFunction4GeneCodeEN);
                    case "Gen_4ReqJs_Js_btnClickGetMaxStrId":
                        return Gen_4ReqJs_Js_btnClickGetMaxStrId(objvFunction4GeneCodeEN);
                    case "Gen_4ReqJs_Js_btnClickGetMaxStrIdByPrefix":
                        return Gen_4ReqJs_Js_btnClickGetMaxStrIdByPrefix(objvFunction4GeneCodeEN);

                    case "Gen_4ReqJs_Js_btnClickUpdateRecord":
                        return Gen_4ReqJs_Js_btnClickUpdateRecord(objvFunction4GeneCodeEN);
                        
                    case "Gen_4ReqJs_Js_btnClickIsExistRecord":
                        return Gen_4ReqJs_Js_btnClickIsExistRecord(objvFunction4GeneCodeEN);

                    case "Gen_4ReqJs_Js_btnClickGetRecCountByCond":
                        return Gen_4ReqJs_Js_btnClickGetRecCountByCond(objvFunction4GeneCodeEN);

                    case "Gen_4ReqJs_Js_btnClickGetObjLst":
                        return Gen_4ReqJs_Js_btnClickGetObjLst(objvFunction4GeneCodeEN);

                    case "Gen_4ReqJs_Js_btnClickGetTopObjLst":
                        return Gen_4ReqJs_Js_btnClickGetTopObjLst(objvFunction4GeneCodeEN);

                    case "Gen_4ReqJs_Js_btnClickGetObjLstByPager":
                        return Gen_4ReqJs_Js_btnClickGetObjLstByPager(objvFunction4GeneCodeEN);

                    case "Gen_4ReqJs_Js_btnClickGetObjLstByRange":
                        return Gen_4ReqJs_Js_btnClickGetObjLstByRange(objvFunction4GeneCodeEN);
                    case "Gen_4ReqJs_Js_UT_ShowTabObj":
                        return Gen_4ReqJs_Js_UT_ShowTabObj(objvFunction4GeneCodeEN);
                    case "Gen_4ReqJs_Js_UT_BindTab":
                        return Gen_4ReqJs_Js_UT_BindTab(objvFunction4GeneCodeEN);

                    default:
                        string strMsg = string.Format("功能名:{1}在Switch没有处理,请检查({0})",
                             clsStackTrace.GetCurrClassFunction(), objvFunction4GeneCodeEN.FuncName);
                        throw new Exception(strMsg);
                        //            return "///该1函数不存在:" + strFuncName;
                }
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", objvFunction4GeneCodeEN.FuncName, objException.Message);
                throw new Exception(sbMessage.ToString());
            }
        }
                  
        public string Gen_4ReqJs_Js_UT_BindTab(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 显示{0}对象的所有属性值", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"divContainer\">显示容器</param>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"arr{0}ObjLst\">需要绑定的对象列表</param>",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "BindTab_{0}(divContainer: HTMLDivElement, arr{0}ObjLst: Array<cls{0}EN>) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "if (divContainer == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}不存在!\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divContainer, 'divDataLst');");
            ImportClass objImportClass = AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetDivObjInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

            CodeElement objCodeElement_Import = clsPubFun4GC.GetCodeElementByImportClass(objImportClass);
            clsPubFun4GC.AddCodeElement_Import(this.objCodeElement_Imports, objCodeElement_Import);

            strCodeForCs.Append("\r\n" + "const sstrFldName: Array < string > = new Array<string>();");
            strCodeForCs.Append("\r\n" + "const sstrColHeader: Array < string > = new Array<string>();");
            
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n" + "sstrFldName.push(\"{0}\"); sstrColHeader.push(\"{1}\");",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ColCaption);
            }
            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.BindTab(divDataLst, arr{0}ObjLst, sstrFldName, sstrColHeader, \"{1}\"); ",
                objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "}");
         

            return strCodeForCs.ToString();
        }


        public string Gen_4ReqJs_Js_UT_ShowTabObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 显示{0}对象的所有属性值");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"divContainer\">显示容器</param>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}\">需要显示的对象</param>",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static Show{0}Obj(divContainer: HTMLDivElement, obj{0}: cls{0}EN) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
  
            strCodeForCs.Append("\r\n" + "if (divContainer == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}不存在!\",divContainer.id));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const sstrKeys = clsCommFunc4Web.GetObjKeys(obj{0});",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "const ul: HTMLUListElement = document.createElement(\"ul\");");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}.GetFldValue(strKey);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "const li: HTMLLIElement = document.createElement(\"li\");");
            strCodeForCs.Append("\r\n" + "li.innerHTML = Format(\"{0}:{1}\", strKey, strValue);");
            strCodeForCs.Append("\r\n" + "ul.appendChild(li);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "divContainer.appendChild(ul);");
            strCodeForCs.Append("\r\n" + "}");
        
            return strCodeForCs.ToString();
        }

        public string Gen_4ReqJs_Js_btnClickGetObjByKey(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字获取相应的记录的对象");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">参数列表</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetObjByKey_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            strCodeForCs.AppendFormat("\r\n" + "const strKeyId: string = $('#txtstrKeyId{0}').val();",
                    objvFunction4GeneCodeEN.OrderNum);
     
            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}: {1} = strKeyId;",
                  objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            }
            else
            {
                switch (objDataTypeAbbrEN.DataTypeId)
                {
                    case enumDataTypeAbbr.float_07:                       
                    case enumDataTypeAbbr.int_09:
                    case enumDataTypeAbbr.money_11:
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:

                        strCodeForCs.AppendFormat("\r\n" + "const {1}: {0} = Number(strKeyId);",
                            objDataTypeAbbrEN.TypeScriptType,
                            objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理!({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

           
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}GetObjBy{1}Async({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据关键字:[{{0}}]获取对象：{{1}}!\", strKeyId, obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "this.Show{1}Obj(\"divResult{0}\", obj{1}EN);", 
                objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

    

            return strCodeForCs.ToString();
        }

        public string Gen_4ReqJs_Js_btnClickGetFirstObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN
            //objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的第一条记录的对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnGetFirstObj_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            //strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}GetFirstObjAsync(strWhereCond);",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                        objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}] 获取第一个记录对象：{{1}}!\", strWhereCond, obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "this.Show{1}Obj(\"divResult{0}\", obj{1}EN);",
    objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据条件获取相应的第一条记录的对象不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

                   

            return strCodeForCs.ToString();
        }     

        public string Gen_4ReqJs_Js_btnClickGetObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetObjLst_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //            strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLst = await {thisWA_F(WA_F.GetObjLstAsync)}(strWhereCond);");
                        
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}]共获取对象列表数：{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divResult{0}\", arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据条件获取相应的对象列表不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
     
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
       
            return strCodeForCs.ToString();
        }

        public string Gen_4ReqJs_Js_UT_GetObjLst4DdlBind(string strTabName, string strValueFld, string strTextFld)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetObjLst_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
          
            strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLst: Array<cls{ThisTabName4GC}EN> = await {thisWA_F(WA_F.GetObjLstAsync)}(strWhereCond);");
                   
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN objFirstObj = new cls{0}EN();", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.{0} = \"0\";",
               strValueFld, strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.{0} = \"请选择...\";", strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst.add(0, objFirstObj);",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "{1}.arr{0}ObjLstCache = arr{0}ObjLst;",
                strTabName, objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setPrompt(\"请选择您的{0}: \");", objPrjTabENEx.TabCnName);

            strCodeForCs.AppendFormat("\r\n" + "if (mobjDdlAdapter{0} == null)", strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "mobjDdlAdapter{0} = new ddlAdapter{0}(macPage, arr{0}ObjLst);",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            //            userStateAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setAdapter(mobjDdlAdapter{0});",
                strTabName);
            //strCodeForCs.Append("\r\n" + "SendMessage(\"没有使用缓存!\");");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"BindDdl_{0}, 没有使用缓存!\", 1);",
                strTabName);

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据条件获取下拉框的相应对象列表不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4ReqJs_Js_btnClickGetTopObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的顶部对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetTopObjLst_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}GetTopObjLstAsync(strWhereCond, intTopSize);",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}],顶部数:[{{1}}]共获取顶部对象列表数：{{2}}!\", strWhereCond, intTopSize, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divResult{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据条件获取相应的顶部对象列表不成功, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
       
            return strCodeForCs.ToString();
        }

        public string Gen_4ReqJs_Js_btnClickGetObjLstByPager(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的分页对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetObjLstByPager_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //strCodeForCs.Append("\r\n" + "Integer intPageIndex = 2;");
            //strCodeForCs.Append("\r\n" + "Integer intPageSize = 2;");
            //strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            //strCodeForCs.Append("\r\n" + "string strOrderBy =\"\";");

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}GetObjLstByPagerAsync(intPageIndex, intPageSize, strWhereCond, strOrderBy);",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}],每页记录数:[{{1}}],第[{{2}}]页,共获取分页对象列表数：{{3}}!\", strWhereCond, intPageSize, intPageIndex, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divResult{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据条件获取相应的分页对象列表不成功, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");
         
            return strCodeForCs.ToString();
        }

        public string Gen_4ReqJs_Js_btnClickGetObjLstByRange(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取范围内相应的对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetObjLstByRange_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const resparr{0}ObjLstonseText = await {0}GetObjLstByRangeAsync( intMinNum, intMaxNum, strWhereCond, strOrderBy);",
                objPrjTabENEx.TabName);
            
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}],最小记录号:[{{1}}],最大记录号:[{{2}}],共获取分页对象列表数：{{3}}!\", strWhereCond, intMinNum, intMaxNum, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divResult{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据条件获取范围内相应的对象列表不成功, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
  
            return strCodeForCs.ToString();
        }

      

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4ReqJs_Js_btnClickIsExistRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 检查相应关键字的记录是否存在");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "function btn{0}_Click() {", objvFunction4GeneCodeEN.FuncName4Code);
            string strClsName4UT_TS = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName);
            string strClsName4UT_Ts_Lower = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName).ToLower();
            string strTabName_Lower = objPrjTabENEx.TabName.ToLower();
            strCodeForCs.AppendFormat("\r\n" + "require([\"{0}\"], function({1}) {",
                strClsName4UT_Ts_Lower, strTabName_Lower);
            strCodeForCs.AppendFormat("\r\n" + "{0}.{1}.btn{2}_Click();",
                strTabName_Lower, strClsName4UT_TS, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_4ReqJs_Js_btnClickGetRecCountByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取某一条件的记录数");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strCodeForCs.Append("\r\n /// <returns>返回是否存在</returns>");

            strCodeForCs.AppendFormat("\r\n" + "function btn{0}_Click() {", objvFunction4GeneCodeEN.FuncName4Code);
            string strClsName4UT_TS = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName);
            string strClsName4UT_Ts_Lower = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName).ToLower();
            string strTabName_Lower = objPrjTabENEx.TabName.ToLower();
            strCodeForCs.AppendFormat("\r\n" + "require([\"{0}\"], function({1}) {",
                strClsName4UT_Ts_Lower, strTabName_Lower);
            strCodeForCs.AppendFormat("\r\n" + "{0}.{1}.btn{2}_Click();",
                strTabName_Lower, strClsName4UT_TS, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

   

        public string Gen_4ReqJs_Js_btnClickDelRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 删除记录");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "function btn{0}_Click() {", objvFunction4GeneCodeEN.FuncName4Code);
            string strClsName4UT_TS = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName);
            string strClsName4UT_Ts_Lower = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName).ToLower();
            string strTabName_Lower = objPrjTabENEx.TabName.ToLower();
            strCodeForCs.AppendFormat("\r\n" + "require([\"{0}\"], function({1}) {",
                strClsName4UT_Ts_Lower, strTabName_Lower);
            strCodeForCs.AppendFormat("\r\n" + "{0}.{1}.btn{2}_Click();",
                strTabName_Lower, strClsName4UT_TS, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_4ReqJs_Js_btnClickDelRecords(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 删除记录");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "function btn{0}_Click() {", objvFunction4GeneCodeEN.FuncName4Code);
            string strClsName4UT_TS = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName);
            string strClsName4UT_Ts_Lower = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName).ToLower();
            string strTabName_Lower = objPrjTabENEx.TabName.ToLower();
            strCodeForCs.AppendFormat("\r\n" + "require([\"{0}\"], function({1}) {",
                strClsName4UT_Ts_Lower, strTabName_Lower);
            strCodeForCs.AppendFormat("\r\n" + "{0}.{1}.btn{2}_Click();",
                strTabName_Lower, strClsName4UT_TS, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_4ReqJs_Js_btnClickDelMultiRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字列表删除记录");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "function btn{0}_Click() {", objvFunction4GeneCodeEN.FuncName4Code);
            string strClsName4UT_TS = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName);
            string strClsName4UT_Ts_Lower = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName).ToLower();
            string strTabName_Lower = objPrjTabENEx.TabName.ToLower();
            strCodeForCs.AppendFormat("\r\n" + "require([\"{0}\"], function({1}) {",
                strClsName4UT_Ts_Lower, strTabName_Lower);
            strCodeForCs.AppendFormat("\r\n" + "{0}.{1}.btn{2}_Click();",
                strTabName_Lower, strClsName4UT_TS, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_4ReqJs_Js_btnClickDelMultiRecordByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件删除多条记录");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "function btn{0}_Click() {", objvFunction4GeneCodeEN.FuncName4Code);
            string strClsName4UT_TS = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName);
            string strClsName4UT_Ts_Lower = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName).ToLower();
            string strTabName_Lower = objPrjTabENEx.TabName.ToLower();
            strCodeForCs.AppendFormat("\r\n" + "require([\"{0}\"], function({1}) {",
                strClsName4UT_Ts_Lower, strTabName_Lower);
            strCodeForCs.AppendFormat("\r\n" + "{0}.{1}.btn{2}_Click();",
                strTabName_Lower, strClsName4UT_TS, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_4ReqJs_Js_btnClickByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
          //  strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "function btn{0}_Click() {", objWebSrvFunctionsENEx.FunctionName);
            string strClsName4UT_TS = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName);
            string strClsName4UT_Ts_Lower = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName).ToLower();
            string strTabName_Lower = objPrjTabENEx.TabName.ToLower();
            strCodeForCs.AppendFormat("\r\n" + "require([\"{0}\"], function({1}) {",
                strClsName4UT_Ts_Lower, strTabName_Lower);
            strCodeForCs.AppendFormat("\r\n" + "{0}.{1}.btn{2}_Click();",
                strTabName_Lower, strClsName4UT_TS, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4ReqJs_Js_btnClickByCommonFunction(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strMsg = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            //  strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btn{0}_Click() ",
                objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
              clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objvFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                    clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                    if (objDataTypeAbbrEN == null)
                    {
                        objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                        if (objSelfDefDataTypeEN_Para == null)
                        {
                            strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                                objFuncPara4CodeEN.ParameterType);
                            throw new Exception(strMsg);
                        }
                    }
                    if (objFuncPara4CodeEN.IsByRef == true)
                    {
                        strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
                           objFuncPara4CodeEN.ParaName,
                             objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        if (objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1} = txt{2}.Text.Trim();",
                                objDataTypeAbbrEN.CsType,
                                objFuncPara4CodeEN.ParaName,
                                objFuncPara4CodeEN._StrTag);
                        }
                        else
                        {
                            switch (objFuncPara4CodeEN.DataTypeId)
                            {
                                case enumDataTypeAbbr.float_07:
                                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = float.Parse(txt{2}.Text.ToString());",
                                        objDataTypeAbbrEN.CsType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.int_09:
                                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = int.Parse(txt{2}.Text.ToString());",
                                        objDataTypeAbbrEN.CsType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.money_11:
                                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = double.Parse(txt{2}.Text.ToString());",
                                        objDataTypeAbbrEN.CsType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                default:
                                    strMsg = string.Format("数据类型：[{0}({1})](CSharp:{2})在函数中没有处理!({3})",
                                        objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                        objDataTypeAbbrEN.CsType,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        if (objSelfDefDataTypeEN_Para != null)
                        {
                            sbParaList.AppendFormat("{0} {1},",
                                objSelfDefDataTypeEN_Para.CsType,
                                objFuncPara4CodeEN.ParaName);
                        }
                        else
                        {
                            sbParaList.AppendFormat("{0} {1},",
                                objDataTypeAbbrEN.CsType,
                                objFuncPara4CodeEN.ParaName);
                        }
                        sbParaVarList.AppendFormat("{0},", objFuncPara4CodeEN.ParaName);
                    }
                }
            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }

            strCodeForCs.AppendFormat("\r\n" + "{0}_{1}Async({2});",
                    objPrjTabENEx.TabName,
                    objvFunction4GeneCodeEN.FuncName4Code,
                    sbParaVarList.ToString());

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//通过WebService执行函数:[{0}],返回的事件函数,这是正确返回,不需要处理执行错误。",
                objvFunction4GeneCodeEN.FuncName4Code);
          
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(string returnString, string strClassName, string strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"返回值为：{0}!\", returnString);");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 继承Runnable类必须实现的【run】函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_4ReqJs_Js_btnClickAddNewRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 添加新记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "function btn{0}_Click() {", objvFunction4GeneCodeEN.FuncName4Code);
            string strClsName4UT_TS = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName);
            string strClsName4UT_Ts_Lower = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName).ToLower();
            string strTabName_Lower = objPrjTabENEx.TabName.ToLower();
            strCodeForCs.AppendFormat("\r\n" + "require([\"{0}\"], function({1}) {",
                strClsName4UT_Ts_Lower, strTabName_Lower);
            strCodeForCs.AppendFormat("\r\n" + "{0}.{1}.btn{2}_Click();",
                strTabName_Lower, strClsName4UT_TS, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4ReqJs_Js_btnClickAddNewRecord4GetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 添加新记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "function btn{0}_Click() {", objvFunction4GeneCodeEN.FuncName4Code);
            string strClsName4UT_TS = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName);
            string strClsName4UT_Ts_Lower = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName).ToLower();
            string strTabName_Lower = objPrjTabENEx.TabName.ToLower();
            strCodeForCs.AppendFormat("\r\n" + "require([\"{0}\"], function({1}) {",
                strClsName4UT_Ts_Lower, strTabName_Lower);
            strCodeForCs.AppendFormat("\r\n" + "{0}.{1}.btn{2}_Click();",
                strTabName_Lower, strClsName4UT_TS, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4ReqJs_Js_btnClickGetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "function btn{0}_Click() {", objvFunction4GeneCodeEN.FuncName4Code);
            string strClsName4UT_TS = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName);
            string strClsName4UT_Ts_Lower = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName).ToLower();
            string strTabName_Lower = objPrjTabENEx.TabName.ToLower();
            strCodeForCs.AppendFormat("\r\n" + "require([\"{0}\"], function({1}) {",
                strClsName4UT_Ts_Lower, strTabName_Lower);
            strCodeForCs.AppendFormat("\r\n" + "{0}.{1}.btn{2}_Click();",
                strTabName_Lower, strClsName4UT_TS, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4ReqJs_Js_btnClickGetMaxStrIdByPrefix(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "function btn{0}_Click() {", objvFunction4GeneCodeEN.FuncName4Code);
            string strClsName4UT_TS = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName);
            string strClsName4UT_Ts_Lower = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName).ToLower();
            string strTabName_Lower = objPrjTabENEx.TabName.ToLower();
            strCodeForCs.AppendFormat("\r\n" + "require([\"{0}\"], function({1}) {",
                strClsName4UT_Ts_Lower, strTabName_Lower);
            strCodeForCs.AppendFormat("\r\n" + "{0}.{1}.btn{2}_Click();",
                strTabName_Lower, strClsName4UT_TS, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4ReqJs_Js_btnClickUpdateRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 修改记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "function btn{0}_Click() {", objvFunction4GeneCodeEN.FuncName4Code);
            string strClsName4UT_TS = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName);
            string strClsName4UT_Ts_Lower = string.Format("wapi{0}_ut_ts", objPrjTabENEx.TabName).ToLower();
            string strTabName_Lower = objPrjTabENEx.TabName.ToLower();
            strCodeForCs.AppendFormat("\r\n" + "require([\"{0}\"], function({1}) {",
                strClsName4UT_Ts_Lower, strTabName_Lower);
            strCodeForCs.AppendFormat("\r\n" + "{0}.{1}.btn{2}_Click();",
                strTabName_Lower, strClsName4UT_TS, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        private void GC_GetInputValue4Para_TS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, StringBuilder strCodeForCs)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            string strMsg = "";
            //            StringBuilder strCodeForCs = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
  clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                    clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                    if (objDataTypeAbbrEN == null)
                    {
                        objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                        if (objSelfDefDataTypeEN_Para == null)
                        {
                            strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                                objFuncPara4CodeEN.ParameterType);
                            throw new Exception(strMsg);
                        }
                    }
                    if (objFuncPara4CodeEN.IsByRef == true)
                    {
                        strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
                           objFuncPara4CodeEN.ParaName,
                             objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        if (objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {1}: {0} = $('#txt{1}{2}').val();",
                                objDataTypeAbbrEN.TypeScriptType,
                                objFuncPara4CodeEN.ParaName,
                                objvFunction4GeneCodeEN.OrderNum);
                        }
                        else
                        {
                            switch (objFuncPara4CodeEN.DataTypeId)
                            {
                                case enumDataTypeAbbr.float_07:
                                case enumDataTypeAbbr.int_09:
                                case enumDataTypeAbbr.bigint_01:
                                case enumDataTypeAbbr.bigintidentity_26:

                                case enumDataTypeAbbr.money_11:
                                    strCodeForCs.AppendFormat("\r\n" + "const {1}:{0} = Number($('#txt{1}{2}').val());",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.Array_31:
                                    strCodeForCs.AppendFormat("\r\n" + "const {1}:{0} = $('#txt{1}{2}').val();",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                default:
                                    strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理!({3})",
                                        objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                        objDataTypeAbbrEN.TypeScriptType,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }                       
                    }
                }
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
                Type t = typeof(DALCode4CSharp);
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
            this.ClsName = string.Format("cls{0}DA1", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            return "";
        }
        }
}
