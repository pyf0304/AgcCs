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
    partial class WA_AppController4JAVABase : clsGeneCodeBase4Tab
    {

        #region 构造函数

        public WA_AppController4JAVABase(string strTabId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
        }
        #endregion
        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
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
            string strTemp; ///临时变量;

            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "_WA_Controller";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".java";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".java";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate4Java(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strBuilder.AppendFormat("\r\n" + "package {0}.GC.L5_WA_Controller.{1};",
                       objProject.JavaPackageName, objFuncModule.FuncModuleEnName4GC());
                strBuilder.Append("\r\n" + "import android.app.Activity;");
                strBuilder.Append("\r\n" + "import android.util.Log;");
                strBuilder.Append("\r\n" + "import android.widget.TextView;");
                strBuilder.Append("\r\n" + "import android.widget.EditText;");

                strBuilder.AppendFormat("\r\n" + "import {0}.GC.L0Entity.{2}.cls{1}EN;",
                    objProjectsENEx.JavaPackageName,
                      objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC()); //
                strBuilder.AppendFormat("\r\n" + "import {0}.GC.L4_Controller4WA.{2}.cls{1}WA4Controller;",
                            objProjectsENEx.JavaPackageName,
                              objPrjTabENEx.TabName, objFuncModule.FuncModuleEnName4GC()); //

                strBuilder.AppendFormat("\r\n" + "import {0}.PubFun.clsPubFun;",
                                  objProjectsENEx.JavaPackageName,
                                    objPrjTabENEx.TabName); //

                strBuilder.Append("\r\n" + "import com.taishsoft.util.clsResponseData;"); //
                strBuilder.Append("\r\n" + "import com.taishsoft.commdb.clsTableObjWA4ControllerDelegate;"); //
                strBuilder.Append("\r\n" + "import com.taishsoft.util.clsDate;"); //

                strBuilder.Append("\r\n" + "import java.util.List;"); //


                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.",
                    objPrjTabENEx.UserId,
                    clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* 注意:该类必须与调用界面处于同一个包,否则调用不成功!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strBuilder.Append("\r\n" + "*/");
                strBuilder.AppendFormat("\r\n" + "public class  cls{0}_WA_Controller",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "private TextView tvMsg;");

                //生成所有的函数
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);

                //为所有的函数定义相关输入控件
                List<string> arrValueLst = new List<string>();
                int intIndex = 1;
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Invoke") <= 0) continue;

                    //string strTemp = "";
                    try
                    {
                        strTemp = GC_DeclareCtrlVar4FuncPara(objvFunction4GeneCodeEN, arrValueLst);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strBuilder.AppendFormat("\r\n" + "//为函数[{0}、{1}]的参数定义输入控件：",
                                intIndex,
                                objvFunction4GeneCodeEN.FuncName4Code);
                            strBuilder.Append(strTemp + "\r\n");
                        }
                        else
                        {
                            strTemp = string.Format("//该函数：[{0}、{1}]无法生成.",
                                 intIndex,
                                 objvFunction4GeneCodeEN.FuncName4Code);
                            strBuilder.Append("\r\n" + strTemp);
                        }
                        intIndex++;
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//该函数：[{0}]无法生成.错误:[{1}]({2}->{3})",
                            objvFunction4GeneCodeEN.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Java_icls") > 0) continue;

                    if (strFuncName.IndexOf("Java_btnClick") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Java_Invoke") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    //strTemp = A_GeneFuncCode_Java(strFuncName);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.IndexOf("Java_icls") < 0) continue;
                    if (strFuncName.IndexOf("Java_btnClick") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Java_icls") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else if (strFuncName.IndexOf("Java_Invoke") > 0)
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    else
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }
                strBuilder.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
                
            }
            return strBuilder.ToString();
        }

        public string A_GeneFuncCode_Java_DeclareButton(string strFuncName)
        {
            try
            {
                switch (strFuncName)
                {

                    case "Gen_WA_Controller_Java_DeclareButtonGetFirstObj":
                        return Gen_WA_Controller_Java_DeclareButtonGetFirstObj();

                    case "Gen_WA_Controller_Java_DeclareButtonGetObjByKey":
                        return Gen_WA_Controller_Java_DeclareButtonGetObjByKey();

                    case "Gen_WA_Controller_Java_DeclareButtonDelRecord":
                        return Gen_WA_Controller_Java_DeclareButtonDelRecord();
                    case "Gen_WA_Controller_Java_DeclareButtonDelRecordsByJSON":
                        return Gen_WA_Controller_Java_DeclareButtonDelRecordsByJSON();
                        
                    case "Gen_WA_Controller_Java_DeclareButtonAddNewRecord":
                        return Gen_WA_Controller_Java_DeclareButtonAddNewRecord();

                    case "Gen_WA_Controller_Java_DeclareButtonAddNewRecord4GetMaxStrId":
                        return Gen_WA_Controller_Java_DeclareButtonAddNewRecord4GetMaxStrId();
                    case "Gen_WA_Controller_Java_DeclareButtonGetMaxStrId":
                        return Gen_WA_Controller_Java_DeclareButtonGetMaxStrId();
                    case "Gen_WA_Controller_Java_DeclareButtonGetMaxStrIdByPrefix":
                        return Gen_WA_Controller_Java_DeclareButtonGetMaxStrIdByPrefix();

                    case "Gen_WA_Controller_Java_DeclareButtonUpdateRecord":
                        return Gen_WA_Controller_Java_DeclareButtonUpdateRecord();

                    case "Gen_WA_Controller_Java_DeclareButtonIsExistRecord":
                        return Gen_WA_Controller_Java_DeclareButtonIsExistRecord();

                    case "Gen_WA_Controller_Java_DeclareButtonGetRecCountByCond":
                        return Gen_WA_Controller_Java_DeclareButtonGetRecCountByCond();

                    case "Gen_WA_Controller_Java_DeclareButtonGetObjLst":
                        return Gen_WA_Controller_Java_DeclareButtonGetObjLst();

                    case "Gen_WA_Controller_Java_DeclareButtonGetTopObjLst":
                        return Gen_WA_Controller_Java_DeclareButtonGetTopObjLst();

                    case "Gen_WA_Controller_Java_DeclareButtonGetObjLstByPager":
                        return Gen_WA_Controller_Java_DeclareButtonGetObjLstByPager();
                    case "Gen_WA_Controller_Java_DeclareButtontvMsg":
                        return Gen_WA_Controller_Java_DeclareButtontvMsg();
                        
                    default:
                        string strMsg = string.Format("功能名:{1}在Switch没有处理,请检查({0})",
                             clsStackTrace.GetCurrClassFunction(), strFuncName);
                        throw new Exception(strMsg);
                        //            return "///该1函数不存在:" + strFuncName;
                }
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
        /// 继承Runnable类必须实现的【run】函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_Controller_Java_DeclareButtonAddNewRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord";
            //string strFunctionName_CN = "添加新记录";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);
        
            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonAddNewRecord4GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "AddNewRecord4GetMaxStrId";
            //string strFunctionName_CN = "添加新记录(获取最大关键字)";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonGetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrId";
            //string strFunctionName_CN = "获取最大关键字值";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonGetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetMaxStrIdByPrefix";
            //string strFunctionName_CN = "获取最大关键字值,根据前缀";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);

            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonUpdateRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "UpdateRecord";
            //string strFunctionName_CN = "修改记录";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonDelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecord";
            //string strFunctionName_CN = "删除记录";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);

            return strBuilder.ToString();
        }
               
        public string Gen_WA_Controller_Java_DeclareButtonDelRecordsByJSON()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "DelRecordsByJSON";
            //string strFunctionName_CN = "通过JSON删除多条记录";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);

            return strBuilder.ToString();
        }
        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_Controller_Java_DeclareButtonIsExistRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "IsExistRecord";
            //string strFunctionName_CN = "检查是否存在记录";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonGetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetRecCountByCond";
            //string strFunctionName_CN = "根据条件获取记录数";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }


        public string Gen_WA_Controller_Java_DeclareButtonGetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetObjLst";
            //string strFunctionName_CN = "获取记录对象列表";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonGetTopObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetTopObjLst";
            //string strFunctionName_CN = "获取顶部记录对象列表";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonGetObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetObjLstByPager";
            //string strFunctionName_CN = "获取分页记录对象列表";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonGetObjByKey()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetObjByKey";
            //string strFunctionName_CN = "根据关键字获取对象";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtonGetFirstObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstObj";
            //string strFunctionName_CN = "获取满足条件的第一条记录对象";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);


            return strBuilder.ToString();
        }

        public string Gen_WA_Controller_Java_DeclareButtontvMsg()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFunctionName = "GetFirstObj";
            //string strFunctionName_CN = "获取满足条件的第一条记录对象";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", strFunctionName);
            
            return strBuilder.ToString();
        }
        public string Gen_WA_Controller_Java_DeclareButtonByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            //string strFunctionName_CN = "获取满足条件的第一条记录对象";
            strBuilder.AppendFormat("\r\n" + "private Button btn{0};", objWebSrvFunctionsENEx.FunctionName);

            return strBuilder.ToString();
        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(AppController4JAVA);
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
            this.ClsName = string.Format("cls{0}_WA_Controller", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
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
        private string GC_DeclareCtrlVar4FuncPara(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx,
                 List<string> arrValueLst)
        {
            StringBuilder sbCode = new StringBuilder();
            //objAndroidConstraintLayoutENEx.orientation = "vertical";
            string strMsg = "";

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

                }
                else
                {
                    string strParaName_New = clsString.GetUniqueStrValue_S(objWebSrvFuncParaEN.ParaName, arrValueLst);
                    arrValueLst.Add(strParaName_New);
                    objWebSrvFuncParaEN._StrTag = strParaName_New;
                    sbCode.AppendFormat("\r\n" + "private EditText txt{0};", strParaName_New);
                }
            }
            return sbCode.ToString();
        }
        private string GC_DeclareCtrlVar4FuncPara(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN,
            List<string> arrValueLst)
        {
            StringBuilder sbCode = new StringBuilder();
            //objAndroidConstraintLayoutENEx.orientation = "vertical";
            string strMsg = "";
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

                    }
                    else
                    {
                        string strParaName_New = clsString.GetUniqueStrValue_S(objFuncPara4CodeEN.ParaName, arrValueLst);
                        arrValueLst.Add(strParaName_New);
                        objFuncPara4CodeEN._StrTag = strParaName_New;
                        sbCode.AppendFormat("\r\n" + "private EditText txt{0};", strParaName_New);
                    }
                }
            }
            return sbCode.ToString();
        }
    }
}
