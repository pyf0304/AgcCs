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
using AgcCommBase;
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
    partial class WA_ViewUTScriptCS_TS4TypeScript : clsGeneCodeBase4Tab
    {
      


        #region 构造函数

        public WA_ViewUTScriptCS_TS4TypeScript(string strTabId,  string strPrjDataBaseId, string strPrjId)
          : base(strTabId,  strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //

            //if (thisCacheClassify4View.IsHasCacheClassfyFld == true)
            //{
            //    thisCacheClassify4View.VarDef4Fld = string.Format("{0}.{1}Cache", objViewInfoENEx.ClsName, thisCacheClassify4View.FldName);
            //}
            //if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true)
            //{
            //    thisCacheClassify4View.VarDef4Fld2 = string.Format("{0}.{1}Cache", objViewInfoENEx.ClsName, thisCacheClassify4View.FldName2);
            //}

            this.strDataBaseType = clsPubConst.con_MsSql;
            this.arrImportClass = new List<ImportClass>();
        }
        #endregion

        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        public string A_GenCode4Function_Ts_btnClick(string strFuncId4GC)
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


        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_ViewUTScriptCS_TS4TypeScript);
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
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", objvFunction4GeneCodeEN.FuncName, objException.Message);
                throw new Exception(sbMessage.ToString());
            }
        }
       
        /// <summary>
        /// 生成App页面后台代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            //if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层({1})",
                        objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层({1})",
                   objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //GetCacheParaVarStr();
            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp = ""; ///临时变量;

            objPrjTabENEx.ClsName = string.Format("WApi{0}_UT_TS", objPrjTabENEx.TabName);;
            string strXmlFileName = string.Format("WApi{0}_UT_TS", objPrjTabENEx.TabName);;
            strXmlFileName = strXmlFileName.ToLower();
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

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

                //strCodeForCs.Append("\r\n ///生成查询删除记录的控制层代码");
                //strCodeForCs.Append("\r\n" + GenRefDomainName());    //生成参考域名
                strCodeForCs.Append("\r\n" + "///// <reference path=\"../../../scripts/typings/jquery/jquery.d.ts\" />");
                
                strCodeForCs.Append("\r\n" + "/////import * as $ from \"jquery\";");

                strCodeForCs.AppendFormat("\r\n" + "import {{ cls{1}EN }} from \"../TS/L0Entity/{0}/cls{1}EN.js\";",
                     objFuncModule.FuncModuleEnName4GC(),
                       objPrjTabENEx.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "import {{ cls{1}BL }} from \"../TS/L2_BLL/{0}/cls{1}BL.js\";",
                //                     objFuncModule.FuncModuleEnName4GC()
                //                       objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "import {{ cls{1}WApi, cls{1}BL }} from \"../TS/L3ForWApi/{0}/cls{1}WApi.js\";",
                     objFuncModule.FuncModuleEnName4GC(),
                       objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "import { clsCommFunc4Web } from \"../TS/PubFun/clsCommFunc4Web.js\";");
                
                strCodeForCs.Append("\r\n" + "import { stuTopPara } from \"../TS/PubFun/stuTopPara.js\";");
                strCodeForCs.Append("\r\n" + "import { stuRangePara } from \"../TS/PubFun/stuRangePara.js\";");
                strCodeForCs.Append("\r\n" + "import { stuPagerPara } from \"../TS/PubFun/stuPagerPara.js\";");
                //strCodeForCs.Append("\r\n" + "import { clsPubFun } from \"../TS/PubFun/clsPubFun.js\";");
                //strCodeForCs.Append("\r\n" + "import { C1acheHelper } from \"../TS/PubFun/CacheHelper.js\";");
                strCodeForCs.Append("\r\n" + "import { clsFldComparisonObj } from \"../TS/PubFun/clsFldComparisonObj.js\";");
                strCodeForCs.Append("\r\n" + "declare var $;");
                //strCodeForCs.AppendFormat("\r\n" + "namespace {0}.WApiForm", objProject.PrjDomain);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0} 的摘要说明。其中Q代表查询,U代表修改", objPrjTabENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "export class  {0} ", objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "private strInfo = \"\";");
                //strCodeForCs.Append("\r\n" + "private strWhereCond = \"\";");

                strCodeForCs.Append("\r\n" + "");

                if (objPrjTabENEx.objCacheClassifyFld != null)
                {

                    strCodeForCs.AppendFormat("\r\n" + "public static {0}Cache = \"\";",
                        objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                }
                            
                //生成所有的函数
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);
                //为所有的函数定义相关输入控件
                List<string> arrValueLst = new List<string>();
                             
                //为函数的参数输入控件进行绑定
                arrValueLst = new List<string>();
                       

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";
                    //if (strFuncName.IndexOf("Ts_btnClick") > 0)
                    //{
                        //string strFuncName4Code = objvFunction4GeneCodeEN.FuncName4Code;
                        //if (strFuncName4Code.Contains("AddNew") == true
                        //    || strFuncName4Code.Contains("Update") == true
                        //    || strFuncName4Code.Contains("GetObjByKey") == true)
                        //{
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                        //string strSource = string.Format("ac{0}_UnitTest", objPrjTabENEx.TabName);
                        //string strTarget = string.Format("ac{0}_UTScript", objPrjTabENEx.TabName);

                        //strTemp = strTemp.Replace(strSource, strTarget);
                    //}
                    //else
                    //{
                    //    strTemp = "";
                    //}
                    //strTemp = A_GeneFuncCode_Java(strFuncName);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
                //strCodeForCs.Append("\r\n" + "}");
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
      
        public string Gen_WApi_Ts_UT_BindTab(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
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
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"BindTab_{0}\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
      
            strCodeForCs.Append("\r\n" + "if (divContainer == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}不存在!\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divContainer, 'divDataLst');");

            strCodeForCs.Append("\r\n" + "const sstrFldName: Array < string > = new Array<string>();");
            strCodeForCs.Append("\r\n" + "const sstrColHeader: Array < string > = new Array<string>();");
            
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n" + "sstrFldName.push(\"{0}\"); sstrColHeader.push(\"{1}\");",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ColCaption);
            }
            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.BindTab(divContainer, arr{0}ObjLst, sstrFldName, sstrColHeader, \"{1}\"); ",
                objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "}");
         

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_UT_ShowTabObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
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
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"Show{0}Obj\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            
            strCodeForCs.Append("\r\n" + "if (divContainer == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}不存在!\",divContainer));");
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

        public string Gen_WApi_Ts_btnClickGetObjByKey(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName4Code = TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code);

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字获取相应的记录的对象");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">参数列表</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btn{0}_Click() ",
                strFuncName4Code);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btn{0}_Click\";",       strFuncName4Code);

            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            strCodeForCs.AppendFormat("\r\n" + "const strKeyId: string = $('#txtvarKeyId{0}').val();",
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


            strCodeForCs.AppendFormat("\r\n" + "       if (obj{0}ENConst == null)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "        {");

            strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"根据关键字获取相应的记录的对象为空.(in {0}.{1})\", this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "            alert(strMsg);");
            strCodeForCs.Append("\r\n" + "            return false;");
            strCodeForCs.Append("\r\n" + "        }");

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据关键字:[{{0}}]获取对象：{{1}}!\", strKeyId, obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "this.Show{1}Obj(\"divList{0}\", obj{1}EN);", 
                objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

    

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetObjByKey_WACache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            string strFuncName4Code = TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code);

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字获取相应的记录的对象");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">参数列表</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btn{0}_Click() ",
                strFuncName4Code);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btn{0}_Click\";",        strFuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            strCodeForCs.AppendFormat("\r\n" + "const strKeyId: string = $('#txtvarKeyId{0}').val();",
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

            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}GetObjBy{1}_WACacheAsync({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}:{1} = {2}.{0}Cache;",
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.TypeScriptType, objPrjTabENEx.ClsName);

                strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}GetObjBy{1}_WACacheAsync({2}, {3});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName
                );
            }
            
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据关键字:[{{0}}]获取对象：{{1}}!\", strKeyId, obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "this.Show{1}Obj(\"divList{0}\", obj{1}EN);",
                objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetObjByKeyCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            string strFuncName4Code = TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code);

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字获取相应的记录的对象");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">参数列表</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btn{0}_Click() ",
                strFuncName4Code);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btn{0}_Click\";",        strFuncName4Code, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            strCodeForCs.AppendFormat("\r\n" + "const strKeyId: string = $('#txtvarKeyId{0}').val();",
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

            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}GetObjBy{1}Cache({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}:{1} = {2}.{0}Cache;",
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.TypeScriptType, objPrjTabENEx.ClsName);

                strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}GetObjBy{1}Cache({2}, {3});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName
                );
            }

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据关键字:[{{0}}]获取对象：{{1}}!\", strKeyId, obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "this.Show{1}Obj(\"divList{0}\", obj{1}EN);",
                objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_CreateCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
                        
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 建立缓存");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "CreateCache() ");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"CreateCache\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "clsPubFun.SetCommFun4BL();");
            strCodeForCs.Append("\r\n" + "let strKey = \"\";");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"开始获取缓存：{0}\");", objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "strKey = cls{0}EN._CurrTabName;", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + $"await {thisWA_F(WA_F.GetObjLst_Cache)}();");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}:{1} = {2}.{0}Cache;",
               objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
               objPrjTabENEx.objCacheClassifyFld.TypeScriptType, objPrjTabENEx.ClsName);
                if (objPrjTabENEx.objCacheClassifyFld.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                           objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                         objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + $"await {thisWA_F(WA_F.GetObjLst_Cache)}({objPrjTabENEx.objCacheClassifyFld.PrivFuncName});");
            }
            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"获取缓存完成!{0}\");", objPrjTabENEx.TabName);
            
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst: Array < cls{0}EN > = CacheHelper.Get(strKey);", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst != null)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"建立缓存Key=[{{0}}]完成: 共获取对象列表数：{{1}}!\", strKey, arr{0}ObjLst.length);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "$('#lblPageStatusContent').html(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"建立缓存Key=[{0}]不成功!\", strKey);");
            strCodeForCs.Append("\r\n" + "$('#lblPageStatusContent').html(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e) {");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"建立缓存Key=[${strKey}]失败:${e}!\");");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "$('#lblPageStatusContent').html(strInfo);");
            strCodeForCs.Append("\r\n" + "}  ");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_GetFldNameLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
                        
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取当前表的字段名列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "public static GetFldNameLst(func: (strKey: string) => any) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetFldNameLst\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const arrFldName: Array<string> = cls{0}EN._AttributeName;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "const strFldNameLst1 = arrFldName.join(\",\");");
            strCodeForCs.Append("\r\n" + "clsFldComparisonObj.arrFldNameLst = arrFldName;");
            strCodeForCs.Append("\r\n" + "func(strFldNameLst1);");
            strCodeForCs.Append("\r\n" + "}");
            
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_GetArray(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把Html控件集合转换成Array列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "public static GetArray(arr): Array < HTMLElement > {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetArray\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "let arrLst: Array < HTMLElement > = new Array<HTMLElement>();");
            strCodeForCs.Append("\r\n" + "for (let i = 0; i < arr.length; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const chk: HTMLElement = arr[i];// as HTMLElement;");
            strCodeForCs.Append("\r\n" + "arrLst.push(chk);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return arrLst;");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_GetLocalObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取当前表的字段名列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "   public static GetLocalObjLst(): Array < clsFldComparisonObj > {");
            strCodeForCs.Append("\r\n" + "const strFldComparisonObjLst = $(\"#hidFldComparisonObjLst\").val();");
                   strCodeForCs.Append("\r\n" + "if (strFldComparisonObjLst == null || strFldComparisonObjLst == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return new Array<clsFldComparisonObj>();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "const arrFldComparisonObj: Array < clsFldComparisonObj > = JSON.parse(strFldComparisonObjLst);");
            strCodeForCs.Append("\r\n" + "return arrFldComparisonObj;");
            strCodeForCs.Append("\r\n" + "}");
            
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_AddDPV_FldComparison(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取当前表的字段名列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "public static AddDPV_FldComparison(divName4Edit: string) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"AddDPV_FldComparison\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "const objLst = document.getElementsByTagName(\"div\");");
            strCodeForCs.Append("\r\n" + "const strStartName = \"divEditFldComparison\";");
            strCodeForCs.AppendFormat("\r\n" + "let arrElement: Array < HTMLElement > = WApi{0}_UT_TS.GetArray(objLst) as Array<HTMLElement>;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "let arrDiv: Array < HTMLDivElement > = arrElement as Array<HTMLDivElement>;");
            strCodeForCs.Append("\r\n" + "let arrFind: Array < HTMLDivElement > = arrDiv.filter(x => x.id.indexOf(strStartName) > -1);");
            strCodeForCs.Append("\r\n" + "arrFind.forEach(x => x.innerHTML = \"\");");
            
            strCodeForCs.Append("\r\n" + "const strUrl = \"../Test/_FldComparison/\";");
            strCodeForCs.Append("\r\n" + "//console.log(\"divName4Edit:(In AddDPV_FldComparison)\" + divName4Edit);");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "method: \"GET\",");
            strCodeForCs.Append("\r\n" + "dataType: \"html\",");
            strCodeForCs.Append("\r\n" + "data: { },");
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            strCodeForCs.Append("\r\n" + "console.log(\"已经成功获取页面:\" + strUrl + \"  字节数: \" + data.length.toString());");
            strCodeForCs.Append("\r\n" + "$('#' + divName4Edit).html(data);");
            strCodeForCs.Append("\r\n" + "//setTimeout(() => { clsFldComparisonObj.BindTab(); }, 100);");
            strCodeForCs.Append("\r\n" + "clsFldComparisonObj.BindTab();");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: (e:any) => {");
            strCodeForCs.Append("\r\n" + "console.error(e);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnClickGetFirstObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
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
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetFirstObj_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
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
            strCodeForCs.AppendFormat("\r\n" + "this.Show{1}Obj(\"divList{0}\", obj{1}EN);",
    objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据条件获取相应的第一条记录的对象不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

                   

            return strCodeForCs.ToString();
        }     

        public string Gen_WApi_Ts_btnClickGetObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
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
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetObjLst_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //            strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLst = await {thisWA_F(WA_F.GetObjLstAsync)}(strWhereCond);");
                        
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}]共获取对象列表数：{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "//alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据条件获取相应的对象列表不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)"); 
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
     
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
       
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnClickGetObjLstByKeyLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字列表获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetObjLstByKeyLst_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetObjLstByKeyLst_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //            strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "number")
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "const arr{0}2:Array<string> = strKeyIdLst.split(',');", objKeyField.FldName);
            //    strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<number> = arr{0}2.map(x=>Number(x));", objKeyField.FldName);
            //}
            //else
            //{
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<string> = strKeyIdLst.split(',');", objKeyField.FldName);
            //}
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}GetObjLstBy{1}LstAsync(arr{1});",
                objPrjTabENEx.TabName, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据关键字列表:[{{0}}]共获取对象列表数：{{1}}!\", strKeyIdLst, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "//alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据关键字列表获取相应对象列表不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)"); 
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetObjLstByKeyLst_WACache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字列表获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetObjLstByKeyLst_WACache_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetObjLstByKeyLst_WACache_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //            strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "number")
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "const arr{0}2:Array<string> = strKeyIdLst.split(',');", objKeyField.FldName);
            //    strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<number> = arr{0}2.map(x=>Number(x));", objKeyField.FldName);
            //}
            //else
            //{
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<string> = strKeyIdLst.split(',');", objKeyField.FldName);
            //}
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLs = await {0}GetObjLstBy{1}Lst_WACacheAsync(arr{1});",
                objPrjTabENEx.TabName, objKeyField.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}:{1} = {2}.{0}Cache;",
               objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
               objPrjTabENEx.objCacheClassifyFld.TypeScriptType, objPrjTabENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLs = await {0}GetObjLstBy{1}Lst_WACacheAsync(arr{1}, {2});",
                objPrjTabENEx.TabName, objKeyField.FldName, 
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据关键字列表:[{{0}}]共获取对象列表数：{{1}}!\", strKeyIdLst, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "//alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据关键字列表获取相应对象列表不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetObjLstByKeyLstCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字列表获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetObjLstByKeyLstCache_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetObjLstByKeyLstCache_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //            strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "number")
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}2:Array<string> = strKeyIdLst.split(',');", objKeyField.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<number> = arr{0}2.map(x=>Number(x));", objKeyField.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<string> = strKeyIdLst.split(',');", objKeyField.FldName);
            }
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}GetObjLstBy{1}LstCache(arr{1});",
                objPrjTabENEx.TabName, objKeyField.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}:{1} = {2}.{0}Cache;",
               objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
               objPrjTabENEx.objCacheClassifyFld.TypeScriptType, objPrjTabENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}GetObjLstBy{1}LstCache(arr{1}, {2});",
                objPrjTabENEx.TabName, objKeyField.FldName,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据关键字列表:[{{0}}]共获取对象列表数：{{1}}!\", strKeyIdLst, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "//alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据关键字列表获取相应对象列表不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_UT_GetObjLst4DdlBind(string strTabName, string strValueFld, string strTextFld)
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
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetObjLst_Click\";",
         objPrjTabENEx.TabName, objKeyField.FldName);
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
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetTopObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
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
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetTopObjLst_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "const objTopPara: stuTopPara =");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            strCodeForCs.Append("\r\n" + "topSize: intTopSize,");
            strCodeForCs.Append("\r\n" + "orderBy: \"\",");
            strCodeForCs.Append("\r\n" + "IsCheckSQLAttack: \"false\",");
            strCodeForCs.Append("\r\n" + "Exclude:\"\"");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}GetTopObjLstAsync(objTopPara);",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}],顶部数:[{{1}}]共获取顶部对象列表数：{{2}}!\", strWhereCond, intTopSize, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "//alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据条件获取相应的顶部对象列表不成功, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
       
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetObjLstByPager(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
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
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetObjLstByPager_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //strCodeForCs.Append("\r\n" + "Integer intPageIndex = 2;");
            //strCodeForCs.Append("\r\n" + "Integer intPageSize = 2;");
            //strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            //strCodeForCs.Append("\r\n" + "string strOrderBy =\"\";");

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //strCodeForCs.Append("\r\n" + GC_GetObjExLst(enumRegionType.ListRegion_0002, ""));
                        
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}],每页记录数:[{{1}}],第[{{2}}]页,共获取分页对象列表数：{{3}}!\", strWhereCond, intPageSize, intPageIndex, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "//alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据条件获取相应的分页对象列表不成功, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");
         
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnClickGetObjLstByRange(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
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
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetObjLstByRange_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "const objRangePara: stuRangePara = {");
            strCodeForCs.Append("\r\n" + "  MaxNum: intMaxNum,");
            strCodeForCs.Append("\r\n" + "MinNum: intMinNum,");
            strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            strCodeForCs.Append("\r\n" + "orderBy: strOrderBy");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}GetObjLstByRangeAsync(objRangePara);",
                objPrjTabENEx.TabName);
            
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}],最小记录号:[{{1}}],最大记录号:[{{2}}],共获取分页对象列表数：{{3}}!\", strWhereCond, intMinNum, intMaxNum, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "//alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据条件获取范围内相应的对象列表不成功, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
  
            return strCodeForCs.ToString();
        }

      

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_Ts_btnClickIsExistRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 检查相应关键字的记录是否存在");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strCodeForCs.Append("\r\n /// <returns>返回是否存在</returns>");

            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnIsExistRecord_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnIsExistRecord_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F(WA_F.IsExistRecordAsync)}(strWhereCond);");

            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");
     
            strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                objvFunction4GeneCodeEN.OrderNum);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}] 的记录不存在!\", strWhereCond);",
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            
            strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}]的相关记录存在!\", strWhereCond);",
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"检查条件的记录存在不成功, ${(e)}.\");");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_Ts_btnClickIsExist(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 检查相应关键字的记录是否存在");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strCodeForCs.Append("\r\n /// <returns>返回是否存在</returns>");

            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnIsExist_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnIsExist_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
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
            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F(WA_F.IsExistAsync)}({objKeyField.PrivFuncName});");
                        
            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
            //    objvFunction4GeneCodeEN.OrderNum);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"关键字:[{{0}}] 的记录不存在!\", strKeyId);",
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
            //    objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"关键字:[{{0}}]的相关记录存在!\", strKeyId);",
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"检查相应关键字的记录存在不成功, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickIsExistCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 检查相应关键字的记录是否存在");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strCodeForCs.Append("\r\n /// <returns>返回是否存在</returns>");

            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnIsExistCache_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnIsExistCache_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
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
            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "await {0}IsExistCache({1});",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}:{1} = {2}.{0}Cache;",
objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
objPrjTabENEx.objCacheClassifyFld.TypeScriptType, objPrjTabENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "const returnBool = await {0}IsExistCache({1}, {2});",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            
            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
            //    objvFunction4GeneCodeEN.OrderNum);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"关键字:[{{0}}] 的记录不存在!\", strKeyId);",
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
            //    objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"关键字:[{{0}}]的相关记录存在!\", strKeyId);",
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"检查相应关键字的记录存在不成功, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        

        public string Gen_WApi_Ts_btnClickDelRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 删除记录");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnDelRecord_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnDelRecord_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strCodeForCs.AppendFormat("\r\n" + "const strKeyId: string = $('#txtstrKeyId{0}').val();",
                  objvFunction4GeneCodeEN.OrderNum);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

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
            strCodeForCs.Append("\r\n" + $"const returnInt = await {thisWA_F(WA_F.DelRecordAsync)}({objKeyField.PrivFuncName});");

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"删除记录成功, 共删除了${returnInt}条记录!\");");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"删除记录不成功!\");");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"删除记录不成功. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
        
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_btnClickDelRecords(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 删除记录");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnDelRecords_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnDelRecords_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strCodeForCs.AppendFormat("\r\n" + "string strKeyIdLst = txtstrKeyIdLst{0}.Text.Trim();",
                  objvFunction4GeneCodeEN.OrderNum);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseText = await {0}DelRecordsAsync(strKeyIdLst);",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n" + "const returnInt: number = Number(responseText);");

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"删除记录成功,共删除{0}条记录!\", returnInt);");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"删除记录不成功!\");");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"删除记录不成功. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
         
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnClickDelMultiRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName4Code = TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code);


            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据关键字列表删除记录");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btn{0}_Click() {{",
                strFuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btn{0}_Click\";",        strFuncName4Code, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            //   GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

            strCodeForCs.AppendFormat("\r\n" + "const strKeyIdLst:string = $('#txtarrKeyId{0}').val();",
                  objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<string> = strKeyIdLst.split(',');", objKeyField.FldName);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const returnInt = await {thisWA_F(WA_F.DelMultiRecordAsync)}(arr{objKeyField.FldName});");

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"删除记录成功,共删除{0}条记录!\", returnInt);");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"删除记录不成功!\");");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"删除记录不成功. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnClickDelMultiRecordByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件删除多条记录");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnDelMultiRecordByCond_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnDelMultiRecordByCond_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //strCodeForCs.AppendFormat("\r\n" + "const strKeyIdLst:string = $('#txtstrKeyIdLst{0}').val();",
            //      objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<string> = strKeyIdLst.split(',');", objKeyField.FldName);
            //clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const returnInt = await {thisWA_F(WA_F.DelMultiRecordByCondAsync)}(strWhereCond);");

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"删除记录成功,共删除{0}条记录!\", returnInt);");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"删除记录不成功!\");");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"删除记录不成功. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnClickByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
          //  strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btn{0}_Click() ",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btn{0}_Click\";",        objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objWebSrvFunctionsENEx.FunctionName);

            strCodeForCs.AppendFormat("\r\n" + "{0}WS4SDController obj{0}WS4SDController = new {0}WS4SDController();",
                objWebSrvClassENEx.ClsName);

            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();

            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {
                    strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
                       objWebSrvFuncParaEN.ParaName,
                         objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = txt{2}.Text.Trim();",
                            objDataTypeAbbrEN.CsType,
                            objWebSrvFuncParaEN.ParaName,
                            objWebSrvFuncParaEN._StrTag);
                    }
                    else
                    {
                        switch (objWebSrvFuncParaEN.DataTypeId)
                        {
                            case enumDataTypeAbbr.float_07:
                                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = float.Parse(txt{2}.Text.ToString());",
                                    objDataTypeAbbrEN.CsType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            case enumDataTypeAbbr.int_09:
                                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = int.Parse(txt{2}.Text.ToString());",
                                    objDataTypeAbbrEN.CsType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            case enumDataTypeAbbr.money_11:
                                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = double.Parse(txt{2}.Text.ToString());",
                                    objDataTypeAbbrEN.CsType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            default:
                                strMsg = string.Format("数据类型：[{0}({1})](Java:{2})在函数中没有处理!({3})", 
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
            
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4SDController.{1}({2});",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvFunctionsENEx.FunctionName,
                    sbParaVarList.ToString());
            
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//通过WebService执行函数:[{0}],返回的事件函数,这是正确返回,不需要处理执行错误。",
                objWebSrvFunctionsENEx.FunctionName);
          
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(string returnString, string strClassName, string strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}.name;",
       clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"返回值为：{{0}}!\", returnString);");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
         
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickByCommonFunction(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
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
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btn{0}_Click\";",       objvFunction4GeneCodeEN.FuncName4Code);
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
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}.name;",
        clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"返回值为：${returnString}!\");");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

       
        public string Gen_WApi_Ts_btnClickGetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnGetMaxStrId_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetMaxStrId_Click\";",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const returnString = await {thisWA_F(WA_F.GetMaxStrIdAsync)}();");
            
            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为空,不成功,请检查!\");",
                objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为：{{0}}!\", returnString);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"获取表关键字的最大值不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetMaxStrIdByPrefix(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnGetMaxStrIdByPrefix_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetMaxStrIdByPrefix_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            //            strCodeForCs.AppendFormat("\r\n" + "string strPrefix = \"2\";");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const returnString = await {thisWA_F(WA_F.GetMaxStrIdByPrefixAsync)}(strPrefix);");

            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为空,不成功,请检查!\");",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为：{{0}}!\", returnString);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"获取表关键字的最大值不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
    


            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickUpdateRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 修改记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnUpdateRecord_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnUpdateRecord_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = new cls{0}EN();",
           objPrjTabENEx.TabName);

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "Date" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "DateTime")
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "short")
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                          objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.sfUpdFldSetStr = obj{0}EN.updFldString;//设置哪些字段被修改(脏字段)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F(WA_F.UpdateRecordAsync)}(obj{ThisTabName4GC}EN);");
                        
            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"修改记录成功!\");");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"修改记录不成功!\");");

            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"修改记录不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
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
                                case enumDataTypeAbbr.Object_29:
                                    strCodeForCs.AppendFormat("\r\n" + "const {1}:{0} = $('#txt{1}{2}').val();",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.Array_31:
                                    string strTypeScriptType = objDataTypeAbbrEN.TypeScriptType
                                        .Replace("[", "<")
                                        .Replace("]",">")
                                        .Replace("(", "<")
                                        .Replace(")", ">");
                                    strCodeForCs.AppendFormat("\r\n" + "const strKeyIdLst:string = $('#txt{0}{1}').val();",
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    //strCodeForCs.AppendFormat("\r\n" + "const {1}:{0} = strKeyIdLst.split(\",\");",
                                    //    strTypeScriptType,
                                    //    objFuncPara4CodeEN.ParaName);
                                    break;
                                default:
                                    strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理!({3})",
                                        objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                        objDataTypeAbbrEN.TypeScriptType,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        //if (objSelfDefDataTypeEN_Para != null)
                        //{
                        //    sbParaList.AppendFormat("{0} {1},",
                        //        objSelfDefDataTypeEN_Para.CsType,
                        //        objFuncPara4CodeEN.ParaName);
                        //}
                        //else
                        //{
                        //    sbParaList.AppendFormat("{0} {1},",
                        //        objDataTypeAbbrEN.CsType,
                        //        objFuncPara4CodeEN.ParaName);
                        //}
                        //sbParaVarList.AppendFormat("{0},", objFuncPara4CodeEN.ParaName);
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

        public override void GetClsName()
        {
            this.ClsName = string.Format("WApi{0}_UT_TS", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
    }
}
