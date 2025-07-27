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
    partial class WA_ViewUTScriptCS4JavaScript : clsGeneCodeBase
    {

        public bool Is4RJ { get; set; }
        #region 构造函数

        public WA_ViewUTScriptCS4JavaScript()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public WA_ViewUTScriptCS4JavaScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
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
        public string A_GenCode4Function_Ts_btnClick(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                // clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
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
                Type t = typeof(WA_ViewUTScriptCS4JavaScript);
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
            this.Is4RJ = false;
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

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp = ""; ///临时变量;

            objPrjTabENEx.ClsName = string.Format("WA_{0}_UT_JS", objPrjTabENEx.TabName );
            string strXmlFileName = string.Format("WA_{0}_UT_JS", objPrjTabENEx.TabName);
            strXmlFileName = strXmlFileName.ToLower();
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

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
                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objPrjTabENEx.UserId, objPrjTabENEx));

                //strBuilder.Append("\r\n ///生成查询删除记录的控制层代码");
                //strBuilder.Append("\r\n" + GenRefDomainName());    //生成参考域名
                strBuilder.Append("\r\n" + "///// <reference path=\"../../../scripts/typings/jquery/jquery.d.ts\" />");
                
                strBuilder.Append("\r\n" + "/////import * as $ from \"jquery\";");

                strBuilder.AppendFormat("\r\n" + "import {{ cls{1}EN }} from \"../JS/L0_Entity/{0}/cls{1}EN.js\";",
                     objFuncModule.FuncModuleEnName,
                       objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "import {{ cls{1}BL }} from \"../JS/L2_BLL/{0}/cls{1}BL.js\";",
                                     objFuncModule.FuncModuleEnName,
                                       objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n" + "import {{ cls{1}WApi }} from \"../JS/L3_ForWApi/{0}/cls{1}WApi.js\";",
                     objFuncModule.FuncModuleEnName,
                       objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "import { clsCommFunc4Web } from \"../JS/PubFun/clsCommFunc4Web.js\";");
                
                strBuilder.Append("\r\n" + "import { stuTopPara } from \"../JS/PubFun/stuTopPara.js\";");
                strBuilder.Append("\r\n" + "import { stuRangePara } from \"../JS/PubFun/stuRangePara.js\";");
                strBuilder.Append("\r\n" + "import { stuPagerPara } from \"../JS/PubFun/stuPagerPara.js\";");
                strBuilder.Append("\r\n" + "import { clsPubFun } from \"../JS/PubFun/clsPubFun.js\";");
                strBuilder.Append("\r\n" + "import { CacheHelper } from \"../JS/PubFun/CacheHelper.js\";");
                strBuilder.Append("\r\n" + "import { clsFldComparisonObj } from \"../JS/PubFun/clsFldComparisonObj.js\";");

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0} 的摘要说明。其中Q代表查询,U代表修改", objPrjTabENEx.ClsName);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "const {0} = function() ", objPrjTabENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                //strBuilder.Append("\r\n" + "private strInfo = \"\";");
                //strBuilder.Append("\r\n" + "private strWhereCond = \"\";");

                strBuilder.Append("\r\n" + "");
                /////生成界面中Page_Load代码;
                //strBuilder.Append("\r\n" + "#region 页面启动函数");

                /////生成界面中Page_Load代码;
                //strTemp = GenPage_LoadCode(false);
                //strBuilder.Append(strTemp);
                //strBuilder.Append("\r\n" + "#endregion 页面启动函数");
                //生成所有的函数
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId,
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);
                //为所有的函数定义相关输入控件
                List<string> arrValueLst = new List<string>();
                             
                //为函数的参数输入控件进行绑定
                arrValueLst = new List<string>();

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_ClassStatic =
                    arrvFunction4GeneCodeObjLst.Where(x=>x.FuncTypeId == enumFunctionType.ClassStaticFunction_15);

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_NotClassStatic =
                    arrvFunction4GeneCodeObjLst.Where(x => x.FuncTypeId != enumFunctionType.ClassStaticFunction_15);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_NotClassStatic)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);                 
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }

                strBuilder.Append("\r\n" + "}");

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_ClassStatic)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strBuilder.ToString();
        }
      
        public string Gen_WA_WCSUT_Js_UT_BindTab(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// 显示{0}对象的所有属性值", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"divContainer\">显示容器</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}ObjLst\">需要绑定的对象列表</param>",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "{0}.BindTab_{1} = function(divContainer, arr{1}ObjLst) ",
                this.ClsName, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "const o = document.getElementById(divContainer) ;");
            strBuilder.Append("\r\n" + "if (o == null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "alert(divContainer + \"不存在！\");");
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "const sstrFldName = new Array<string>();");
            strBuilder.Append("\r\n" + "const sstrColHeader = new Array<string>();");
            
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "sstrFldName.push(\"{0}\"); sstrColHeader.push(\"{1}\");",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ColCaption);
            }
            strBuilder.AppendFormat("\r\n" + "{2}.BindTab(o, arr{0}ObjLst, sstrFldName, sstrColHeader, \"{1}\"); ",
                objPrjTabENEx.TabName, objKeyField.FldName,
                           ImportClass.GetOutString(string.Format("clsCommFunc4Web", objPrjTabENEx.TabName), this.Is4RJ));
            strBuilder.Append("\r\n" + "}");
         

            return strBuilder.ToString();
        }


        public string Gen_WA_WCSUT_Js_UT_ShowTabObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 显示{0}对象的所有属性值");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"divContainer\">显示容器</param>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}\">需要显示的对象</param>",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "{0}.Show{1}Obj = function(divContainer, obj{1}) ",
                this.ClsName, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const o = document.getElementById(divContainer);");
            strBuilder.Append("\r\n" + "if (o == null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "alert(divContainer + \"不存在！\");");
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "const sstrKeys = {1}.GetObjKeys(obj{0});",
                objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("clsCommFunc4Web", objPrjTabENEx.TabName), this.Is4RJ));
            strBuilder.Append("\r\n" + "const ul = document.createElement(\"ul\");");

            strBuilder.Append("\r\n" + "for (const strKey of sstrKeys)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const strValue = obj{0}.GetFldValue(strKey);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "const li = document.createElement(\"li\");");
            strBuilder.Append("\r\n" + "li.innerHTML =  strKey + \":\" + strValue;");
            strBuilder.Append("\r\n" + "ul.appendChild(li);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "o.appendChild(ul);");
            strBuilder.Append("\r\n" + "}");
        
            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_btnClickGetObjByKey(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName4Code = TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字获取相应的记录的对象");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "{0}.btn{1}_Click = async function() ",
                this.ClsName, strFuncName4Code);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            strBuilder.AppendFormat("\r\n" + "const strKeyId = $('#txtvarKeyId{0}').val();",
                    objvFunction4GeneCodeEN.OrderNum);
     
            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = strKeyId;",
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

                        strBuilder.AppendFormat("\r\n" + "const {1} = Number(strKeyId);",
                            objDataTypeAbbrEN.TypeScriptType,
                            objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理！({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

           
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN = await {3}.GetObjBy{1}({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));

            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据关键字:[\" +strKeyId + \"]获取对象：\" +obj{0}EN.{1}  + \"!\";",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");
            strBuilder.AppendFormat("\r\n" + "this.Show{1}Obj(\"divList{0}\", obj{1}EN);", 
                objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"根据关键字获取相应的记录的对象不成功,\" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

    

            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_btnClickGetObjByKey_WA_Cache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            string strFuncName4Code = TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字获取相应的记录的对象");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "{0}.btn{1}_Click = async function() ",
                this.ClsName, strFuncName4Code);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            strBuilder.AppendFormat("\r\n" + "const strKeyId = $('#txtvarKeyId{0}').val();",
                    objvFunction4GeneCodeEN.OrderNum);

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = strKeyId;",
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

                        strBuilder.AppendFormat("\r\n" + "const {1} = Number(strKeyId);",
                            objDataTypeAbbrEN.TypeScriptType,
                            objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理！({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "const responseText = await {3}.GetObjBy{1}_WA_Cache({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = \"{2}1\";",
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.TypeScriptType, clsString.combineStrS("9", objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength - 1));

                strBuilder.AppendFormat("\r\n" + "const obj{0}EN = await {4}.GetObjBy{1}_WA_Cache({2}, {3});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                    ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ)
                );
            }

            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据关键字:[\" +strKeyId + \"]获取对象：\" +obj{0}EN.{1}  + \"!\";",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");
            strBuilder.AppendFormat("\r\n" + "this.Show{1}Obj(\"divList{0}\", obj{1}EN);",
                objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"根据关键字获取相应的记录的对象不成功,\" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_btnClickGetObjByKey_Cache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            string strFuncName4Code = TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字获取相应的记录的对象");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">参数列表</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "{0}.btn{1}_Click = async function() ",
                this.ClsName, strFuncName4Code);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            strBuilder.AppendFormat("\r\n" + "const strKeyId = $('#txtvarKeyId{0}').val();",
                    objvFunction4GeneCodeEN.OrderNum);

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = strKeyId;",
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

                        strBuilder.AppendFormat("\r\n" + "const {1} = Number(strKeyId);",
                            objDataTypeAbbrEN.TypeScriptType,
                            objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理！({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "const responseText = await {3}.GetObjBy{1}_Cache({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = \"{2}1\";",
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.TypeScriptType, clsString.combineStrS("9", objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength - 1));

                strBuilder.AppendFormat("\r\n" + "const obj{0}EN = await {4}.GetObjBy{1}_Cache({2}, {3});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                    ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ)
                );
            }
            
            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据关键字:[\" +strKeyId + \"]获取对象：\" +obj{0}EN.{1}  + \"!\";",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");
            strBuilder.AppendFormat("\r\n" + "this.Show{1}Obj(\"divList{0}\", obj{1}EN);",
                objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"根据关键字获取相应的记录的对象不成功,\" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_CreateCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
                        
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 建立缓存");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "{0}.CreateCache = async function() ",
                this.ClsName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}.SetCommFun4BL();",
                         ImportClass.GetOutString(string.Format("clsPubFun", objPrjTabENEx.TabName), this.Is4RJ));
            strBuilder.Append("\r\n" + "const strKey = \"\";");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "//console.log(\"开始获取缓存：{0}\");", objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "strKey = {1}._CurrTabName;", objPrjTabENEx.TabName,
                         ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
                strBuilder.AppendFormat("\r\n" + "const responseText = await {1}.GetObjLst_Cache();", objPrjTabENEx.TabName,
                    ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = \"{2}1\";",
               objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
               objPrjTabENEx.objCacheClassifyFld.TypeScriptType, clsString.combineStrS("9", objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength-1));
                if (objPrjTabENEx.objCacheClassifyFld.IsNumberType() == true)
                {
                    strBuilder.AppendFormat("\r\n" + "const strKey =  {2}._CurrTabName + \"_\" + {1} ;",
                           objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                                ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "const strKey =  {2}._CurrTabName + \"_\" + {1} ;",
                         objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                              ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
                }
                strBuilder.AppendFormat("\r\n" + "const responseText = await {2}.GetObjLst_Cache({1});", 
                    objPrjTabENEx.TabName, 
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                    ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }
            strBuilder.AppendFormat("\r\n" + "console.log(\"获取缓存完成！{0}\");", objPrjTabENEx.TabName);
            
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = {1}.Get(strKey);", objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            strBuilder.AppendFormat("\r\n" + "if (arr{0}ObjLst != null)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const strInfo = \"建立缓存Key=[\" +strKey + \"]完成: 共获取对象列表数：\" + arr{0}ObjLst.length  + \"!\";", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "$('#lblPageStatusContent').html(strInfo);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"建立缓存Key=[\" +strKey + \"]不成功!\";");
            strBuilder.Append("\r\n" + "$('#lblPageStatusContent').html(strInfo);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (e) {");
            strBuilder.Append("\r\n" + "const strInfo = \"建立缓存Key=[\" +strKey + \"]失败:\" +e + \"!\";");
            strBuilder.Append("\r\n" + "console.error(strInfo);");
            strBuilder.Append("\r\n" + "$('#lblPageStatusContent').html(strInfo);");
            strBuilder.Append("\r\n" + "}  ");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_WA_WCSUT_Js_GetFldNameLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
                        
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表的字段名列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "{0}.GetFldNameLst = function(func) {{",
                this.ClsName);
            strBuilder.AppendFormat("\r\n" + "const arrFldName = new {1}().AttributeName;", 
                objPrjTabENEx.TabName,
                     ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            strBuilder.Append("\r\n" + "const strFldNameLst1 = arrFldName.join(\",\");");
            strBuilder.AppendFormat("\r\n" + "{0}.arrFldNameLst = arrFldName;",
                ImportClass.GetOutString(string.Format("clsFldComparisonObj", objPrjTabENEx.TabName), this.Is4RJ));
            strBuilder.Append("\r\n" + "func(strFldNameLst1);");
            strBuilder.Append("\r\n" + "}");
            
            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_GetArray(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 把Html控件集合转换成Array列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "{0}.GetArray = function(arr) {{", 
                this.ClsName);
            strBuilder.Append("\r\n" + "let arrLst = new Array();");
            strBuilder.Append("\r\n" + "for (let i = 0; i < arr.length; i++)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const chk = arr[i];");
            strBuilder.Append("\r\n" + "arrLst.push(chk);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return arrLst;");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_GetLocalObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表的字段名列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "   {0}.GetLocalObjLst = function() {{",
                this.ClsName);
            strBuilder.Append("\r\n" + "const strFldComparisonObjLst = $(\"#hidFldComparisonObjLst\").val();");
                   strBuilder.Append("\r\n" + "if (strFldComparisonObjLst == null || strFldComparisonObjLst == \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "const arrFldComparisonObj = JSON.parse(strFldComparisonObjLst);");
            strBuilder.Append("\r\n" + "return arrFldComparisonObj;");
            strBuilder.Append("\r\n" + "}");
            
            return strBuilder.ToString();
        }
        public string Gen_WA_WCSUT_Js_AddDPV_FldComparison(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表的字段名列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "{0}.AddDPV_FldComparison = function(divName4Edit) {{",
                this.ClsName);
            strBuilder.Append("\r\n" + "const objLst = document.getElementsByTagName(\"div\");");
            strBuilder.Append("\r\n" + "const strStartName = \"divEditFldComparison\";");
            strBuilder.AppendFormat("\r\n" + "let arrElement = WA_{0}_UT_JS.GetArray(objLst) ;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "let arrDiv = arrElement ;");
            strBuilder.Append("\r\n" + "let arrFind = arrDiv.filter(x => x.id.indexOf(strStartName) > -1);");
            strBuilder.Append("\r\n" + "arrFind.forEach(x => x.innerHTML = \"\");");
            strBuilder.Append("\r\n" + "//var o = document.getElementById(\"div\") ;");
            strBuilder.Append("\r\n" + "const strUrl = \"../../Js/ShareView/_FldComparison.html\";");
            strBuilder.Append("\r\n" + "//console.log(\"divName4Edit:(In AddDPV_FldComparison)\" + divName4Edit);");
            strBuilder.Append("\r\n" + "$.ajax({");
            strBuilder.Append("\r\n" + "url: strUrl,");
            strBuilder.Append("\r\n" + "method: \"GET\",");
            strBuilder.Append("\r\n" + "dataType: \"html\",");
            strBuilder.Append("\r\n" + "data: { },");
            strBuilder.Append("\r\n" + "success: function(data:any) {");
            strBuilder.Append("\r\n" + "console.log(\"已经成功获取页面:\" + strUrl + \"  字节数: \" + data.length.toString());");
            strBuilder.Append("\r\n" + "$('#' + divName4Edit).html(data);");
            strBuilder.AppendFormat("\r\n" + "//setTimeout(() => {{ {0}.BindTab(); }}, 100);",
                ImportClass.GetOutString(string.Format("clsFldComparisonObj", objPrjTabENEx.TabName), this.Is4RJ));
            strBuilder.AppendFormat("\r\n" + "{0}.BindTab();",
                ImportClass.GetOutString(string.Format("clsFldComparisonObj", objPrjTabENEx.TabName), this.Is4RJ));
            strBuilder.Append("\r\n" + "},");
            strBuilder.Append("\r\n" + "error: (e:any) => {");
            strBuilder.Append("\r\n" + "console.error(e);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_WA_WCSUT_Js_btnClickGetFirstObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN
            //objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的第一条记录的对象");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnGetFirstObj_Click = async function() {{",
                this.ClsName);
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            //strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN = await {1}.GetFirstObj(strWhereCond);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));

            strBuilder.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                        objvFunction4GeneCodeEN.OrderNum);
            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" +strWhereCond + \"] 获取第一个记录对象：\" +obj{0}EN.{1}  + \"!\";",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");
            strBuilder.AppendFormat("\r\n" + "this.Show{1}Obj(\"divList{0}\", obj{1}EN);",
    objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"根据条件获取相应的第一条记录的对象不成功,\" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

                   

            return strBuilder.ToString();
        }     

        public string Gen_WA_WCSUT_Js_btnClickGetObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnGetObjLst_Click = async function() ",                
                this.ClsName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //            strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = await {1}.GetObjLst(strWhereCond);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));

            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" +strWhereCond + \"]共获取对象列表数：\" +arr{0}ObjLst.length + \"!\";",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "//alert(strInfo);");
            strBuilder.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"根据条件获取相应的对象列表不成功,\" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");
     
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
       
            return strBuilder.ToString();
        }


        public string Gen_WA_WCSUT_Js_btnClickGetObjLstByKeyLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字列表获取相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnGetObjLstByKeyLst_Click = async function() ",
                this.ClsName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //            strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);
            //if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "number")
            //{
            //    strBuilder.AppendFormat("\r\n" + "const arr{0}2 = strKeyIdLst.split(',');", objKeyField.FldName);
            //    strBuilder.AppendFormat("\r\n" + "const arr{0} = arr{0}2.map(x=>Number(x));", objKeyField.FldName);
            //}
            //else
            //{
                strBuilder.AppendFormat("\r\n" + "const arr{0} = strKeyIdLst.split(',');", objKeyField.FldName);
            //}
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = await {2}.GetObjLstBy{1}Lst(arr{1});",
                objPrjTabENEx.TabName, objKeyField.FldName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));

            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据关键字列表:[\" +strKeyIdLst + \"]共获取对象列表数：\" +arr{0}ObjLst.length + \"!\";",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "//alert(strInfo);");
            strBuilder.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"根据关键字列表获取相应对象列表不成功,\" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_btnClickGetObjLstByKeyLst_WA_Cache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字列表获取相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnGetObjLstByKeyLst_WA_Cache_Click = async function() ",
                this.ClsName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //            strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);
            //if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "number")
            //{
            //    strBuilder.AppendFormat("\r\n" + "const arr{0}2 = strKeyIdLst.split(',');", objKeyField.FldName);
            //    strBuilder.AppendFormat("\r\n" + "const arr{0} = arr{0}2.map(x=>Number(x));", objKeyField.FldName);
            //}
            //else
            //{
                strBuilder.AppendFormat("\r\n" + "const arr{0} = strKeyIdLst.split(',');", objKeyField.FldName);
            //}
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "const responseText = await {2}.GetObjLstBy{1}Lst_WA_Cache(arr{1});",
                objPrjTabENEx.TabName, objKeyField.FldName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = \"{2}1\";",
               objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
               objPrjTabENEx.objCacheClassifyFld.TypeScriptType, clsString.combineStrS("9", objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength - 1));
                strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = await {3}.GetObjLstBy{1}Lst_WA_Cache(arr{1}, {2});",
                objPrjTabENEx.TabName, 
                objKeyField.FldName, 
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }
            
            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据关键字列表:[\" +strKeyIdLst + \"]共获取对象列表数：\" +arr{0}ObjLst.length + \"!\";",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "//alert(strInfo);");
            strBuilder.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"根据关键字列表获取相应对象列表不成功,\" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_btnClickGetObjLstByKeyLst_Cache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字列表获取相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnGetObjLstByKeyLst_Cache_Click = async function() ",
                this.ClsName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //            strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "number")
            {
                strBuilder.AppendFormat("\r\n" + "const arr{0}2 = strKeyIdLst.split(',');", objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "const arr{0} = arr{0}2.map(x=>Number(x));", objKeyField.FldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "const arr{0} = strKeyIdLst.split(',');", objKeyField.FldName);
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "const responseText = await {2}.GetObjLstBy{1}Lst_Cache(arr{1});",
                objPrjTabENEx.TabName, objKeyField.FldName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = \"{2}1\";",
               objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
               objPrjTabENEx.objCacheClassifyFld.TypeScriptType, clsString.combineStrS("9", objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength - 1));
                strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = await {3}.GetObjLstBy{1}Lst_Cache(arr{1}, {2});",
                objPrjTabENEx.TabName, objKeyField.FldName,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }
            
            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据关键字列表:[\" +strKeyIdLst + \"]共获取对象列表数：\" +arr{0}ObjLst.length + \"!\";",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "//alert(strInfo);");
            strBuilder.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"根据关键字列表获取相应对象列表不成功,\" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_UT_GetObjLst4DdlBind(string strTabName, string strValueFld, string strTextFld)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnGetObjLst_Click = async function() ",
                this.ClsName);
            strBuilder.Append("\r\n" + "{");
          
            strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = await {1}.GetObjLst(strWhereCond);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
                   
            strBuilder.AppendFormat("\r\n" + "{1} objFirstObj = new {1}();", objPrjTabENEx.TabName,
                     ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            strBuilder.AppendFormat("\r\n" + "objFirstObj.{0} = \"0\";",
               strValueFld, strTextFld);
            strBuilder.AppendFormat("\r\n" + "objFirstObj.{0} = \"请选择...\";", strTextFld);
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst.add(0, objFirstObj);",
                strTabName);
            strBuilder.AppendFormat("\r\n" + "{1}.arr{0}ObjLst_Cache = arr{0}ObjLst;",
                strTabName, objPrjTabENEx.ClsName);
            strBuilder.AppendFormat("\r\n" + "mspnObject.setPrompt(\"请选择您的{0}: \");", objPrjTabENEx.TabCnName);

            strBuilder.AppendFormat("\r\n" + "if (mobjDdlAdapter{0} == null)", strTabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "mobjDdlAdapter{0} = new ddlAdapter{0}(macPage, arr{0}ObjLst);",
                strTabName);
            strBuilder.Append("\r\n" + "}");
            //            userStateAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
            strBuilder.AppendFormat("\r\n" + "mspnObject.setAdapter(mobjDdlAdapter{0});",
                strTabName);
            //strBuilder.Append("\r\n" + "SendMessage(\"没有使用缓存！\");");
            strBuilder.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"BindDdl_{0}, 没有使用缓存！\", 1);",
                strTabName);

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"根据条件获取下拉框的相应对象列表不成功,\" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_btnClickGetTopObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的顶部对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnGetTopObjLst_Click = async function() ",
                this.ClsName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "const objTopPara =");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "whereCond: strWhereCond,");
            strBuilder.Append("\r\n" + "topSize: intTopSize,");
            strBuilder.Append("\r\n" + "orderBy: \"\",");
            strBuilder.Append("\r\n" + "IsCheckSQLAttack: \"false\",");
            strBuilder.Append("\r\n" + "Exclude:\"\"");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = await {1}.GetTopObjLst(objTopPara);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
                        
            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" +strWhereCond + \"],顶部数:[\" +intTopSize + \"]共获取顶部对象列表数：\" +arr{0}ObjLst.length + \"!\";",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "//alert(strInfo);");
            strBuilder.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"根据条件获取相应的顶部对象列表不成功, \" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
       
            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_btnClickGetObjLstByPager(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的分页对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnGetObjLstByPager_Click = async function() ",
                this.ClsName);

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //strBuilder.Append("\r\n" + "Integer intPageIndex = 2;");
            //strBuilder.Append("\r\n" + "Integer intPageSize = 2;");
            //strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            //strBuilder.Append("\r\n" + "string strOrderBy =\"\";");

            GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "const objPagerPara = {");
            strBuilder.Append("\r\n" + "pageIndex: intPageIndex,");
            strBuilder.Append("\r\n" + "pageSize: intPageSize,");
            strBuilder.Append("\r\n" + "whereCond: strWhereCond,");
            strBuilder.Append("\r\n" + "orderBy: strOrderBy");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = await {1}.GetObjLstByPager(objPagerPara);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));

            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" +strWhereCond + \"],每页记录数:[\" +intPageSize + \"],第[\" +intPageIndex + \"]页,共获取分页对象列表数：\" +arr{0}ObjLst.length + \"!\";",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "//alert(strInfo);");
            strBuilder.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"根据条件获取相应的分页对象列表不成功, \" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "}");
         
            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_btnClickGetObjLstByPager_WA_Cache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的分页对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnGetObjLstByPager_WA_Cache_Click = async function() ",
                this.ClsName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
    
            //strBuilder.Append("\r\n" + "Integer intPageIndex = 2;");
            //strBuilder.Append("\r\n" + "Integer intPageSize = 2;");
            //strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            //strBuilder.Append("\r\n" + "string strOrderBy =\"\";");

            GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);

            strBuilder.AppendFormat("\r\n" + "const obj{0}_Cond = new {1}();", objPrjTabENEx.TabName,
                     ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            if (objPrjTabENEx.objCacheClassifyFld != null)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({3}.con_{1},\"{2}1\", \"=\");", objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.FldName, clsString.combineStrS("9", objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength-1),
                         ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            }
            else
            {
            }

            strBuilder.AppendFormat("\r\n" + "const arrFldComparisonObj = WA_{0}_UT_JS.GetLocalObjLst();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//console.log(\"字段比较对象记录数(本地获取)：\" + arrFldComparisonObj.length);");
            strBuilder.AppendFormat("\r\n" + "arrFldComparisonObj.forEach(x => {{ obj{0}_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); }});",
                objPrjTabENEx.TabName);


            strBuilder.AppendFormat("\r\n" + "const obj{0}EN_Sim = {1}.GetSimObjFromObj(obj{0}_Cond);", objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}BL", objPrjTabENEx.TabName), this.Is4RJ));
            //strBuilder.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strWhereCond = JSON.stringify(obj{0}EN_Sim);", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "const objPagerPara = {");
            strBuilder.Append("\r\n" + "pageIndex: intPageIndex,");
            strBuilder.Append("\r\n" + "pageSize: intPageSize,");
            strBuilder.Append("\r\n" + "whereCond: strWhereCond,");
            strBuilder.Append("\r\n" + "orderBy: strOrderBy");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");


            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = await {1}.GetObjLstByPager_WA_Cache(objPagerPara);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));

            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" +strWhereCond + \"],每页记录数:[\" +intPageSize + \"],第[\" +intPageIndex + \"]页,共获取分页对象列表数：\" +arr{0}ObjLst.length + \"!\";",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "//alert(strInfo);");
            strBuilder.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"根据条件获取相应的分页对象列表不成功, \" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_btnClickGetObjLstByPager_Cache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的分页对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnGetObjLstByPager_Cache_Click = async function() " ,
                this.ClsName);

            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //strBuilder.Append("\r\n" + "Integer intPageIndex = 2;");
            //strBuilder.Append("\r\n" + "Integer intPageSize = 2;");
            //strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            //strBuilder.Append("\r\n" + "string strOrderBy =\"\";");

            GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);

            strBuilder.AppendFormat("\r\n" + "const obj{0}_Cond = new {1}();", objPrjTabENEx.TabName,
                     ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            if (objPrjTabENEx.objCacheClassifyFld != null)
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = \"{2}1\";",
                 objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                 objPrjTabENEx.objCacheClassifyFld.TypeScriptType, clsString.combineStrS("9", objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength - 1));

                strBuilder.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({3}.con_{1},\"{2}1\", \"=\");", 
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.FldName, 
                    clsString.combineStrS("9", objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength - 1),
                         ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            }
            else
            {
                //strBuilder.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue(cls{0}EN.con_{1},\"{2}1\", \"=\");", objPrjTabENEx.TabName,
                //    objKeyField.FldName, clsString.combineStrS("9", objKeyField.ObjFieldTabENEx.FldLength - 1));
            }
            strBuilder.AppendFormat("\r\n" + "const arrFldComparisonObj = WA_{0}_UT_JS.GetLocalObjLst();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//console.log(\"字段比较对象记录数(本地获取)：\" + arrFldComparisonObj.length);");
            strBuilder.AppendFormat("\r\n" + "arrFldComparisonObj.forEach(x => {{ obj{0}_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); }});",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "const obj{0}EN_Sim = {1}.GetSimObjFromObj(obj{0}_Cond);", objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}BL", objPrjTabENEx.TabName), this.Is4RJ));
            //strBuilder.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "strWhereCond = JSON.stringify(obj{0}EN_Sim);", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "const objPagerPara = {");
            strBuilder.Append("\r\n" + "pageIndex: intPageIndex,");
            strBuilder.Append("\r\n" + "pageSize: intPageSize,");
            strBuilder.Append("\r\n" + "whereCond: strWhereCond,");
            strBuilder.Append("\r\n" + "orderBy: strOrderBy");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "const responseText = await {1}.GetObjLstByPager_Cache(objPagerPara);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = await {2}.GetObjLstByPager_Cache(objPagerPara, {1});",
                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }

            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" +strWhereCond + \"],每页记录数:[\" +intPageSize + \"],第[\" +intPageIndex + \"]页,共获取分页对象列表数：\" +arr{0}ObjLst.length + \"!\";",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "//alert(strInfo);");
            strBuilder.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"根据条件获取相应的分页对象列表不成功, \" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_btnClickGetSubObjLst_Cache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {


            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的分页对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnGetSubObjLst_Cache_Click = async function() ",
                this.ClsName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //strBuilder.Append("\r\n" + "Integer intPageIndex = 2;");
            //strBuilder.Append("\r\n" + "Integer intPageSize = 2;");
            //strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            //strBuilder.Append("\r\n" + "string strOrderBy =\"\";");

            GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);

            strBuilder.AppendFormat("\r\n" + "const obj{0}_Cond = new {1}();", objPrjTabENEx.TabName,
                     ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            if (objPrjTabENEx.objCacheClassifyFld != null)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({3}.con_{1},\"{2}1\", \"=\");", 
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.FldName, 
                    clsString.combineStrS("9", objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength - 1),
                         ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            }
            else
            {
         
            }
            strBuilder.AppendFormat("\r\n" + "const arrFldComparisonObj = WA_{0}_UT_JS.GetLocalObjLst();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//console.log(\"字段比较对象记录数(本地获取)：\" + arrFldComparisonObj.length);");
            strBuilder.AppendFormat("\r\n" + "arrFldComparisonObj.forEach(x => {{ obj{0}_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); }});",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "const obj{0}EN_Sim = {1}.GetSimObjFromObj(obj{0}_Cond);", objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}BL", objPrjTabENEx.TabName), this.Is4RJ));
            //strBuilder.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", objPrjTabENEx.TabName);
      
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "const responseText = await {1}.GetSubObjLst_Cache(obj{0}_Cond);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = \"{2}1\";",
       objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
       objPrjTabENEx.objCacheClassifyFld.TypeScriptType, clsString.combineStrS("9", objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength - 1));
                strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = await {2}.GetSubObjLst_Cache(obj{0}_Cond, {1});",
            objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
            ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }

            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" +JSON.stringify(obj{0}_Cond) + \"],共获取对象列表子集数：\" +arr{0}ObjLst.length + \"!\";",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "//alert(strInfo);");
            strBuilder.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"根据条件对象获取相应的对象列表子集不成功, \" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_btnClickGetSubObjLst_WA_Cache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {


            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取相应的分页对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnGetSubObjLst_WA_Cache_Click = async function() ",
                this.ClsName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //strBuilder.Append("\r\n" + "Integer intPageIndex = 2;");
            //strBuilder.Append("\r\n" + "Integer intPageSize = 2;");
            //strBuilder.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            //strBuilder.Append("\r\n" + "string strOrderBy =\"\";");

            GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);

            strBuilder.AppendFormat("\r\n" + "const obj{0}_Cond = new {1}();", objPrjTabENEx.TabName,
                     ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            if (objPrjTabENEx.objCacheClassifyFld != null)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({3}.con_{1},\"{2}1\", \"=\");", objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.FldName, 
                    clsString.combineStrS("9", objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength - 1),
                         ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            }
            else
            {
            }
            strBuilder.AppendFormat("\r\n" + "const arrFldComparisonObj = WA_{0}_UT_JS.GetLocalObjLst();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//console.log(\"字段比较对象记录数(本地获取)：\" + arrFldComparisonObj.length);");
            strBuilder.AppendFormat("\r\n" + "arrFldComparisonObj.forEach(x => {{ obj{0}_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); }});",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "const obj{0}EN_Sim = {1}.GetSimObjFromObj(obj{0}_Cond);", objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}BL", objPrjTabENEx.TabName), this.Is4RJ));
            //strBuilder.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            //if (objPrjTabENEx.objCacheClassifyFld == null)
            //{
                strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = await {1}.GetSubObjLst_WA_Cache(obj{0}_Cond);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            //     }
            //     else
            //     {
            //         strBuilder.AppendFormat("\r\n" + "const {0} = \"{2}1\";",
            //objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
            //objPrjTabENEx.objCacheClassifyFld.TypeScriptType, clsString.combineStrS("9", objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength - 1));
            //         strBuilder.AppendFormat("\r\n" + "const responseText = await {0}_GetSubObjLst_WA_Cache(obj{0}_Cond, {1});",
            //     objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            //     }

            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" +JSON.stringify(obj{0}_Cond) + \"],共获取对象列表子集数：\" +arr{0}ObjLst.length + \"!\";",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "//alert(strInfo);");
            strBuilder.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"根据条件对象获取相应的对象列表子集不成功, \" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_WA_WCSUT_Js_btnClickGetObjLstByRange(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件获取范围内相应的对象列表");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnGetObjLstByRange_Click = async function() ",
                this.ClsName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "const objRangePara = {");
            strBuilder.Append("\r\n" + "  MaxNum: intMaxNum,");
            strBuilder.Append("\r\n" + "MinNum: intMinNum,");
            strBuilder.Append("\r\n" + "whereCond: strWhereCond,");
            strBuilder.Append("\r\n" + "orderBy: strOrderBy");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const arr{0}ObjLst = await {1}.GetObjLstByRange(objRangePara);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            
            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" +strWhereCond + \"],最小记录号:[\" +intMinNum + \"],最大记录号:[\" +intMaxNum + \"],共获取分页对象列表数：\" +arr{0}ObjLst.length + \"!\";",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "//alert(strInfo);");
            strBuilder.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"根据条件获取范围内相应的对象列表不成功, \" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
  
            return strBuilder.ToString();
        }

      

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_WCSUT_Js_btnClickIsExistRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查相应关键字的记录是否存在");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strBuilder.Append("\r\n /// <returns>返回是否存在</returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnIsExistRecord_Click = async function() {{",
                this.ClsName);
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            //strBuilder.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const returnBool = await {1}.IsExistRecord(strWhereCond);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
                        
            strBuilder.Append("\r\n" + "if (returnBool == false)");
            strBuilder.Append("\r\n" + "{");
     
            strBuilder.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                objvFunction4GeneCodeEN.OrderNum);

            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" +strWhereCond + \"] 的记录不存在!\";",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                objvFunction4GeneCodeEN.OrderNum);
            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" +strWhereCond + \"]的相关记录存在!\";",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"检查条件的记录存在不成功, \" +(e) + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_btnClickIsExistRecord_Cache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查相应关键字的记录是否存在");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strBuilder.Append("\r\n /// <returns>返回是否存在</returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnIsExistRecord_Cache_Click = async function() {{",
                this.ClsName);
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            
            //strBuilder.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);

            strBuilder.AppendFormat("\r\n" + "const obj{0}_Cond = new {1}();", 
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ)
                );
            if (objPrjTabENEx.objCacheClassifyFld != null)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({3}.con_{1},\"{2}1\", \"=\");", 
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.FldName, 
                    clsString.combineStrS("9", objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength - 1),
                    ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ)
                    );
            }
            else
            {
            }

            strBuilder.AppendFormat("\r\n" + "const arrFldComparisonObj = WA_{0}_UT_JS.GetLocalObjLst();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//console.log(\"字段比较对象记录数(本地获取)：\" + arrFldComparisonObj.length);");
            strBuilder.AppendFormat("\r\n" + "arrFldComparisonObj.forEach(x => {{ obj{0}_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); }});",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "const obj{0}EN_Sim = {1}.GetSimObjFromObj(obj{0}_Cond);", 
                objPrjTabENEx.TabName,
                     ImportClass.GetOutString(string.Format("cls{0}BL", objPrjTabENEx.TabName), this.Is4RJ));
            //strBuilder.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "const responseText = await {1}.IsExistRecord_Cache(obj{0}_Cond);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = \"{2}1\";",
       objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
       objPrjTabENEx.objCacheClassifyFld.TypeScriptType, clsString.combineStrS("9", objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength - 1));
                strBuilder.AppendFormat("\r\n" + "const returnBool = await {2}.IsExistRecord_Cache(obj{0}_Cond, {1});",
                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }

            strBuilder.Append("\r\n" + "if (returnBool == false)");
            strBuilder.Append("\r\n" + "{");
                        
            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" +JSON.stringify(obj{0}_Cond) + \"]的记录不存在!\";",
                objPrjTabENEx.TabName); 
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" +JSON.stringify(obj{0}_Cond) + \"]的相关记录存在!\";",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"检查条件的记录存在不成功, \" +(e) + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_WCSUT_Js_btnClickIsExist(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查相应关键字的记录是否存在");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strBuilder.Append("\r\n /// <returns>返回是否存在</returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnIsExist_Click = async function() {{",
                this.ClsName);
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            strBuilder.AppendFormat("\r\n" + "const strKeyId = $('#txtstrKeyId{0}').val();",
                  objvFunction4GeneCodeEN.OrderNum);
            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = strKeyId;",
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

                        strBuilder.AppendFormat("\r\n" + "const {1} = Number(strKeyId);",
                            objDataTypeAbbrEN.TypeScriptType,
                            objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理！({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            //strBuilder.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            //GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const returnBool = await {2}.IsExist({1});",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));

            strBuilder.Append("\r\n" + "if (returnBool == false)");
            strBuilder.Append("\r\n" + "{");

            //strBuilder.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
            //    objvFunction4GeneCodeEN.OrderNum);

            strBuilder.AppendFormat("\r\n" + "const strInfo = \"关键字:[\" +strKeyId + \"] 的记录不存在!\";",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");

            //strBuilder.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
            //    objvFunction4GeneCodeEN.OrderNum);
            strBuilder.AppendFormat("\r\n" + "const strInfo = \"关键字:[\" +strKeyId + \"]的相关记录存在!\";",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"检查相应关键字的记录存在不成功, \" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_btnClickIsExist_Cache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 检查相应关键字的记录是否存在");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strBuilder.Append("\r\n /// <returns>返回是否存在</returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnIsExist_Cache_Click = async function() {{",
                this.ClsName);
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            strBuilder.AppendFormat("\r\n" + "const strKeyId = $('#txtstrKeyId{0}').val();",
                  objvFunction4GeneCodeEN.OrderNum);
            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = strKeyId;",
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

                        strBuilder.AppendFormat("\r\n" + "const {1} = Number(strKeyId);",
                            objDataTypeAbbrEN.TypeScriptType,
                            objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理！({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            //strBuilder.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            //GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "const responseText = await {2}.IsExist_Cache({1});",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = \"{2}1\";",
objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
objPrjTabENEx.objCacheClassifyFld.TypeScriptType, clsString.combineStrS("9", objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength - 1));
                strBuilder.AppendFormat("\r\n" + "const returnBool = await {3}.IsExist_Cache({1}, {2});",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName, 
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }
            
            strBuilder.Append("\r\n" + "if (returnBool == false)");
            strBuilder.Append("\r\n" + "{");

            //strBuilder.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
            //    objvFunction4GeneCodeEN.OrderNum);

            strBuilder.AppendFormat("\r\n" + "const strInfo = \"关键字:[\" +strKeyId + \"] 的记录不存在!\";",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");

            //strBuilder.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
            //    objvFunction4GeneCodeEN.OrderNum);
            strBuilder.AppendFormat("\r\n" + "const strInfo = \"关键字:[\" +strKeyId + \"]的相关记录存在!\";",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"检查相应关键字的记录存在不成功, \" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_WCSUT_Js_btnClickGetRecCountByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取某一条件的记录数");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strBuilder.Append("\r\n /// <returns>返回是否存在</returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnGetRecCountByCond_Click = async function() {{",
                this.ClsName);
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            //strBuilder.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const responseText = await {1}.GetRecCountByCond(strWhereCond);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));

            strBuilder.Append("\r\n" + "const returnInt = Number(responseText);");

            strBuilder.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                objvFunction4GeneCodeEN.OrderNum);

            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据条件:\" +strWhereCond + \"的记录数:\" +returnInt + \"!\";",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"获取某一条件的记录数不成功,\" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_btnClickGetRecCountByCond_Cache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取某一条件的记录数");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">发送者</param>");
            strBuilder.Append("\r\n /// <returns>返回是否存在</returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnGetRecCountByCond_Cache_Click = async function() {{",
                this.ClsName);
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            //strBuilder.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);

            strBuilder.AppendFormat("\r\n" + "const obj{0}_Cond = new {1}();", objPrjTabENEx.TabName,
                     ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            if (objPrjTabENEx.objCacheClassifyFld != null)
            {
                strBuilder.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({3}.con_{1},\"{2}1\", \"=\");", 
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.FldName, 
                    clsString.combineStrS("9", objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength - 1),
                         ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            }
            else
            {
             }

            strBuilder.AppendFormat("\r\n" + "const arrFldComparisonObj = WA_{0}_UT_JS.GetLocalObjLst();", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "//console.log(\"字段比较对象记录数(本地获取)：\" + arrFldComparisonObj.length );");
            strBuilder.AppendFormat("\r\n" + "arrFldComparisonObj.forEach(x => {{ obj{0}_Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); }});",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "const obj{0}EN_Sim = {1}.GetSimObjFromObj(obj{0}_Cond);", objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}BL", objPrjTabENEx.TabName), this.Is4RJ));
            //strBuilder.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "const responseText = await {1}.GetRecCountByCond_Cache(obj{0}_Cond);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = \"{2}1\";",
objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
objPrjTabENEx.objCacheClassifyFld.TypeScriptType, clsString.combineStrS("9", objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength - 1));
                strBuilder.AppendFormat("\r\n" + "const responseText = await {2}.GetRecCountByCond_Cache(obj{0}_Cond, {1});",
                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            }
            strBuilder.Append("\r\n" + "const returnInt = Number(responseText);");
                        
            strBuilder.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" +JSON.stringify(obj{0}_Cond) + \"]的记录数:\" +returnInt + \"!\";",
                    objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"获取某一条件的记录数不成功,\" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }




        public string Gen_WA_WCSUT_Js_btnClickDelRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 删除记录");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "{0}.btnDelRecord_Click = async function() {{",
                this.ClsName);
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strBuilder.AppendFormat("\r\n" + "const strKeyId = $('#txtstrKeyId{0}').val();",
                  objvFunction4GeneCodeEN.OrderNum);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strBuilder.AppendFormat("\r\n" + "const {0} = strKeyId;",
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

                        strBuilder.AppendFormat("\r\n" + "const {1} = Number(strKeyId);",
                            objDataTypeAbbrEN.TypeScriptType,
                            objKeyField.PrivFuncName);
                        break;
                    
                    default:
                        string strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理！({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const returnInt = await {2}.DelRecord({1});",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));

            strBuilder.Append("\r\n" + "if (returnInt > 0)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "const strInfo = \"删除记录成功, 共删除了\" +returnInt + \"条记录!\";");
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"删除记录不成功!\";");
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"删除记录不成功. \" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
        
            return strBuilder.ToString();
        }
        public string Gen_WA_WCSUT_Js_btnClickDelRecords(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 删除记录");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "{0}.btnDelRecords_Click = async function() {{",
                this.ClsName);
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strBuilder.AppendFormat("\r\n" + "string strKeyIdLst = txtstrKeyIdLst{0}.Text.Trim();",
                  objvFunction4GeneCodeEN.OrderNum);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const responseText = await {2}.DelRecords(strKeyIdLst);",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));

            strBuilder.Append("\r\n" + "const returnInt = Number(responseText);");

            strBuilder.Append("\r\n" + "if (returnInt > 0)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "const strInfo = \"删除记录成功,共删除\" +returnInt + \"条记录!\";");
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"删除记录不成功!\";");
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"删除记录不成功. \" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
         
            return strBuilder.ToString();
        }


        public string Gen_WA_WCSUT_Js_btnClickDelMultiRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName4Code = TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code);


            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据关键字列表删除记录");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "{0}.btn{1}_Click = async function() {{",
                this.ClsName, strFuncName4Code);
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            //   GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);

            strBuilder.AppendFormat("\r\n" + "const strKeyIdLst = $('#txtarrKeyId{0}').val();",
                  objvFunction4GeneCodeEN.OrderNum);
            strBuilder.AppendFormat("\r\n" + "const arr{0} = strKeyIdLst.split(',');", objKeyField.FldName);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const returnInt = await {2}.Del{0}s(arr{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));

            strBuilder.Append("\r\n" + "if (returnInt > 0)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "const strInfo = \"删除记录成功,共删除\" +returnInt + \"条记录!\";");
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"删除记录不成功!\";");
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"删除记录不成功. \" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_WA_WCSUT_Js_btnClickDelMultiRecordByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据条件删除多条记录");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "{0}.btnDelMultiRecordByCond_Click = async function() {{",
                this.ClsName);
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);
            //strBuilder.AppendFormat("\r\n" + "const strKeyIdLst = $('#txtstrKeyIdLst{0}').val();",
            //      objvFunction4GeneCodeEN.OrderNum);
            //strBuilder.AppendFormat("\r\n" + "const arr{0} = strKeyIdLst.split(',');", objKeyField.FldName);
            //clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const returnInt = await {1}.Del{0}sByCond(strWhereCond);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));

            strBuilder.Append("\r\n" + "if (returnInt > 0)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "const strInfo = \"删除记录成功,共删除\" +returnInt + \"条记录!\";");
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"删除记录不成功!\";");
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"删除记录不成功. \" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }


        public string Gen_WA_WCSUT_Js_btnClickByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
          //  strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "{0}.btn{1}_Click = async function() ",
                this.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objWebSrvFunctionsENEx.FunctionName);

            strBuilder.AppendFormat("\r\n" + "{0}WS4SDController obj{0}WS4SDController = new {0}WS4SDController();",
                objWebSrvClassENEx.ClassName);

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
                        strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理，不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {
                    strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}]，数据类型：[{1}]没有处理，不能生成相应代码。",
                       objWebSrvFuncParaEN.ParaName,
                         objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strBuilder.AppendFormat("\r\n" + "{0} {1} = txt{2}.Text.Trim();",
                            objDataTypeAbbrEN.CsType,
                            objWebSrvFuncParaEN.ParaName,
                            objWebSrvFuncParaEN._StrTag);
                    }
                    else
                    {
                        switch (objWebSrvFuncParaEN.DataTypeId)
                        {
                            case enumDataTypeAbbr.float_07:
                                strBuilder.AppendFormat("\r\n" + "{0} {1} = float.Parse(txt{2}.Text.ToString());",
                                    objDataTypeAbbrEN.CsType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            case enumDataTypeAbbr.int_09:
                                strBuilder.AppendFormat("\r\n" + "{0} {1} = int.Parse(txt{2}.Text.ToString());",
                                    objDataTypeAbbrEN.CsType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            case enumDataTypeAbbr.money_11:
                                strBuilder.AppendFormat("\r\n" + "{0} {1} = double.Parse(txt{2}.Text.ToString());",
                                    objDataTypeAbbrEN.CsType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            default:
                                strMsg = string.Format("数据类型：[{0}({1})](Java:{2})在函数中没有处理！({3})", 
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
            
            strBuilder.AppendFormat("\r\n" + "obj{0}WS4SDController.{1}({2});",
                    objWebSrvClassENEx.ClassName,
                    objWebSrvFunctionsENEx.FunctionName,
                    sbParaVarList.ToString());
            
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "//通过WebService执行函数:[{0}]，返回的事件函数，这是正确返回，不需要处理执行错误。",
                objWebSrvFunctionsENEx.FunctionName);
          
            strBuilder.AppendFormat("\r\n" + "public void {0}(string returnString, string strClassName, string strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKey_Cache(enumDict4GC_DictKey1.con_SelfDefFunc,
                enumDict4GC_DictKey2.con_CorrectFinished));

            strBuilder.Append("\r\n" + "{");
           

            strBuilder.AppendFormat("\r\n" + "const strInfo = \"返回值为：\" +returnString + \"!\";");
            //strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            
            strBuilder.Append("\r\n" + "alert(strInfo);");
            strBuilder.Append("\r\n" + "}");
         
            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_btnClickByCommonFunction(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strMsg = "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// {0}", objvFunction4GeneCodeEN.FuncName4Code);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            //  strBuilder.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "{0}.btn{1}_Click = async function() ",
                this.ClsName, objvFunction4GeneCodeEN.FuncName4Code);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
              clsFuncPara4CodeBLEx.GetObjListByFuncId4Code_CacheEx(objvFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeId_Cache(objFuncPara4CodeEN.DataTypeId);
                    clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                    if (objDataTypeAbbrEN == null)
                    {
                        objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                        if (objSelfDefDataTypeEN_Para == null)
                        {
                            strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理，不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                                objFuncPara4CodeEN.ParameterType);
                            throw new Exception(strMsg);
                        }
                    }
                    if (objFuncPara4CodeEN.IsByRef == true)
                    {
                        strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}]，数据类型：[{1}]没有处理，不能生成相应代码。",
                           objFuncPara4CodeEN.ParaName,
                             objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        if (objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strBuilder.AppendFormat("\r\n" + "{0} {1} = txt{2}.Text.Trim();",
                                objDataTypeAbbrEN.CsType,
                                objFuncPara4CodeEN.ParaName,
                                objFuncPara4CodeEN._StrTag);
                        }
                        else
                        {
                            switch (objFuncPara4CodeEN.DataTypeId)
                            {
                                case enumDataTypeAbbr.float_07:
                                    strBuilder.AppendFormat("\r\n" + "{0} {1} = float.Parse(txt{2}.Text.ToString());",
                                        objDataTypeAbbrEN.CsType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.int_09:
                                    strBuilder.AppendFormat("\r\n" + "{0} {1} = int.Parse(txt{2}.Text.ToString());",
                                        objDataTypeAbbrEN.CsType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.money_11:
                                    strBuilder.AppendFormat("\r\n" + "{0} {1} = double.Parse(txt{2}.Text.ToString());",
                                        objDataTypeAbbrEN.CsType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                default:
                                    strMsg = string.Format("数据类型：[{0}({1})](CSharp:{2})在函数中没有处理！({3})",
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

            strBuilder.AppendFormat("\r\n" + "{3}.{1}({2});",
                    objPrjTabENEx.TabName,
                    objvFunction4GeneCodeEN.FuncName4Code,
                    sbParaVarList.ToString(),
                    ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));

            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "//通过WebService执行函数:[{0}]，返回的事件函数，这是正确返回，不需要处理执行错误。",
                objvFunction4GeneCodeEN.FuncName4Code);
          
            strBuilder.AppendFormat("\r\n" + "public void {0}(string returnString, string strClassName, string strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKey_Cache(enumDict4GC_DictKey1.con_SelfDefFunc,
                enumDict4GC_DictKey2.con_CorrectFinished));

            strBuilder.Append("\r\n" + "{");


            strBuilder.Append("\r\n" + "const strInfo = \"返回值为：\" +returnString + \"!\";");
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            
            strBuilder.Append("\r\n" + "alert(strInfo);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }

        /// <summary>
        /// 继承Runnable类必须实现的【run】函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_WCSUT_Js_btnClickAddNewRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnAddNewRecord_Click = async function() {{",
                this.ClsName);
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strBuilder.AppendFormat("\r\n" + "const obj{0}EN = new {1}();",
               objPrjTabENEx.TabName,
                    ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "Date" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "DateTime")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "short")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                          objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
            }
       
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "const bolIsExist = await {2}.IsExist(obj{0}EN.{1});",
                objPrjTabENEx.TabName, objKeyField.FldName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));

            strBuilder.Append("\r\n" + "if (bolIsExist == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const strMsg = \"添加记录时，关键字：\" +obj{0}EN.{1}  + \"已经存在！\";",
                objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "alert(strMsg);");
            strBuilder.Append("\r\n" + "return false;//一定要有一个返回值，否则会出错！");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "const responseText2 = await {1}.AddNewRecord(obj{0}EN);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));

            strBuilder.AppendFormat("\r\n" + "const returnBool = !!responseText2;",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "if (returnBool == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"添加记录成功!\";");
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"添加记录不成功!\";");
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");

     
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"添加记录不成功,\" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            return strBuilder.ToString();
        }

 
        public string Gen_WA_WCSUT_Js_btnClickAddNewRecord4GetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 添加新记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnAddNewRecord4GetMaxStrId_Click = async function() {{",
                this.ClsName);

            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strBuilder.AppendFormat("\r\n" + "const returnString = await {1}.GetMaxStrId();",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
                        
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN = new {1}();",
                objPrjTabENEx.TabName,
                     ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    if (objField.TypeScriptType == "number")
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = Number(returnString);",
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = returnString;",
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                    }
                }
                else
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "boolean")
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                    }
                    else  if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "Date")
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "short")
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = (short){2};",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                              objPrjTabENEx.TabName,
                              objField.ObjFieldTabENEx.FldName,
                              objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                    }
                }
            }
          
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const returnBool = await {1}.AddNewRecord(obj{0}EN);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));

            strBuilder.Append("\r\n" + "if (returnBool == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"添加记录成功!\";");
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"添加记录不成功!\";");
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");
      
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"添加记录不成功, \" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_btnClickGetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnGetMaxStrId_Click = async function() {{",
                this.ClsName);

            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const returnString = await {1}.GetMaxStrId();",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
            
            strBuilder.Append("\r\n" + "if (returnString == \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const strInfo = \"获取表{0}的最大关键字为空，不成功，请检查!\";",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const strInfo = \"获取表{0}的最大关键字为：\" +returnString + \"!\";",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"获取表关键字的最大值不成功,\" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");



            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_btnClickGetMaxStrIdByPrefix(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.AppendFormat("\r\n" + "{0}.btnGetMaxStrIdByPrefix_Click = async function() {{",
                this.ClsName);
            //            strBuilder.AppendFormat("\r\n" + "string strPrefix = \"2\";");
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            GC_GetInputValue4Para_JS(objvFunction4GeneCodeEN, strBuilder);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const returnString = await {1}.GetMaxStrIdByPrefix(strPrefix);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));
                        
            strBuilder.Append("\r\n" + "if (returnString == \"\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const strInfo = \"获取表{0}的最大关键字为空，不成功，请检查!\";",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const strInfo = \"获取表{0}的最大关键字为：\" +returnString + \"!\";",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"获取表关键字的最大值不成功,\" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
    


            return strBuilder.ToString();
        }

        public string Gen_WA_WCSUT_Js_btnClickUpdateRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 修改记录");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "{0}.btnUpdateRecord_Click = async function() {{",
                this.ClsName);
            strBuilder.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            strBuilder.AppendFormat("\r\n" + "const obj{0}EN = new {1}();",
           objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "Date" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "DateTime")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "short")
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                          objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
            }
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.sf_UpdFldSetStr = obj{0}EN.updFldString;//设置哪些字段被修改(脏字段)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const returnBool = await {1}.UpdateRecord(obj{0}EN);",
                objPrjTabENEx.TabName,
                ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));

            strBuilder.Append("\r\n" + "if (returnBool == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"修改记录成功!\";");
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strInfo = \"修改记录不成功!\";");
            strBuilder.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strBuilder.Append("\r\n" + "//显示信息框");
            strBuilder.Append("\r\n" + "alert(strInfo);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(e)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"修改记录不成功,\" +e + \".\";");
            strBuilder.Append("\r\n" + "alert(strMsg);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
 
            return strBuilder.ToString();
        }

        private void GC_GetInputValue4Para_JS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, StringBuilder strBuilder)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC_Cache(objvFunction4GeneCodeEN.FuncId4GC);

            string strMsg = "";
            //            StringBuilder strBuilder = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
  clsFuncPara4CodeBLEx.GetObjListByFuncId4Code_CacheEx(objFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeId_Cache(objFuncPara4CodeEN.DataTypeId);
                    clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                    if (objDataTypeAbbrEN == null)
                    {
                        objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                        if (objSelfDefDataTypeEN_Para == null)
                        {
                            strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理，不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                                objFuncPara4CodeEN.ParameterType);
                            throw new Exception(strMsg);
                        }
                    }
                    if (objFuncPara4CodeEN.IsByRef == true)
                    {
                        strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}]，数据类型：[{1}]没有处理，不能生成相应代码。",
                           objFuncPara4CodeEN.ParaName,
                             objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        if (objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strBuilder.AppendFormat("\r\n" + "const {1} = $('#txt{1}{2}').val();",
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
                                    strBuilder.AppendFormat("\r\n" + "const {1} = Number($('#txt{1}{2}').val());",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.Object_29:
                                    strBuilder.AppendFormat("\r\n" + "const {1} = $('#txt{1}{2}').val();",
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
                                    strBuilder.AppendFormat("\r\n" + "const strKeyIdLst = $('#txt{0}{1}').val();",
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    //strBuilder.AppendFormat("\r\n" + "const {1} = strKeyIdLst.split(\",\");",
                                    //    strTypeScriptType,
                                    //    objFuncPara4CodeEN.ParaName);
                                    break;
                                default:
                                    strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理！({3})",
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

        public override void GetClsName()
        {
            this.ClsName = string.Format("WA_{0}_UT_JS", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
    }
}
