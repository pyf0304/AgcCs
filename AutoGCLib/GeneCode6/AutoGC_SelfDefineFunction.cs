using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;

using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using com.taishsoft.commdb;

namespace AutoGCLib
{
    public class AutoGC_SelfDefineFunction
    {
        private static string mstrTabId_Static = "";
        private static clsDynamicCompiler mobjDynamicCompiler = null;
        public static List<clsDynamicFunction> marrDynamicFunctionLst = null;// new List<clsDynamicFunction>();
        public static clsDynamicFunction mobjDF_SetTabId4GC = null;
        private static List<string> arrReferencedAssemblies = new List<string>();// null;

        /// <summary>
        /// 添加引用的程序集
        /// </summary>
        /// <param name="strReferencedAssemblie"></param>
        /// <returns></returns>
        public static bool AddReferencedAssemblie(string strReferencedAssemblie)
        {
            if (File.Exists(strReferencedAssemblie) == false)
            {
                string strMsg = string.Format("所引用的程序集:[{0}]不存在!({1}->{2})",
                    strReferencedAssemblie,
                    clsStackTrace.GetCurrClassFunctionByLevel(2),
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            arrReferencedAssemblies.Add(strReferencedAssemblie);
            return true;
        }
        private void btnInitGeneCodeByDynCompiler4Tab_Click(object sender, EventArgs e)
        {
           StringBuilder sbAllCode = new StringBuilder();
            try
            {
                foreach (clsDynamicFunction objDynamicFunction2 in marrDynamicFunctionLst)
                {
                    mobjDynamicCompiler.ExecFunction(objDynamicFunction2);
                    string strResult = objDynamicFunction2.ExecReturn.ToString();
                    sbAllCode.Append(strResult);
                }
            }
            catch (Exception objException)
            {

                clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);
                //MessageBox.Show("出现错误!" + objException.ToString());
                return;
            }
            //MessageBox.Show("初始化完成!" + sbAllCode.ToString());
            //lblResult.Text = sbAllCode.ToString();
        }
        private  static bool InitDynamicCompiler()
        {
            
            if (mobjDynamicCompiler != null
                && marrDynamicFunctionLst != null
                && mobjDF_SetTabId4GC != null)
            {
                return true;
            }
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
               clsvFunctionTemplateRelaBLEx.getUSFFunction4GeneCodeObjLstByTemplateId("0003")
               .OrderBy(x => x.OrderNum);

            clsSpecSQLforSql objSpecSQL = new clsSpecSQLforSql();

            mobjDynamicCompiler = new clsDynamicCompiler();
            mobjDynamicCompiler.NameSpace = "GC_AutoDefineFunc";
            mobjDynamicCompiler.ClassName = "AgcCs";
            //objDynamicCompiler.AddReferencedAssemblie("AgcBusinessLogic.dll");
            //objDynamicCompiler.AddReferencedAssemblie("AgcBusinessLogicEx.dll");
            //objDynamicCompiler.AddReferencedAssemblie("AgcDA.dll");
            //objDynamicCompiler.AddReferencedAssemblie("AgcEN.dll");
            //objDynamicCompiler.AddReferencedAssemblie("AutoGCLib.dll");
            //objDynamicCompiler.AddReferencedAssemblie("CommonTableENDABL.dll");
            //objDynamicCompiler.AddReferencedAssemblie("PubDataBase.dll");
            //objDynamicCompiler.AddReferencedAssemblie("TzPubFunction.dll");
            foreach (string strReferencedAssemblie in arrReferencedAssemblies)
            {
                mobjDynamicCompiler.AddReferencedAssemblie(strReferencedAssemblie);
            }
            mobjDynamicCompiler.AddUsing("AGC.BusinessLogic");
            mobjDynamicCompiler.AddUsing("AGC.BusinessLogicEx");
            mobjDynamicCompiler.AddUsing("AGC.Entity");
            mobjDynamicCompiler.AddUsing("AutoGCLib");
            mobjDynamicCompiler.AddUsing("com.taishsoft.comm_db_obj");
            mobjDynamicCompiler.AddUsing("com.taishsoft.commdb");
            mobjDynamicCompiler.AddUsing("com.taishsoft.common");
            mobjDynamicCompiler.AddUsing("com.taishsoft.syspara");
            mobjDynamicCompiler.AddUsing("CommonTable.Entity");
            mobjDynamicCompiler.AddUsing(" System.Text");

            mobjDynamicCompiler.AddDefineClassVar("private clsPrjTabENEx objPrjTabENEx = null;");
            clsDynamicFunction objDF_InitGeneCode = new clsDynamicFunction();
            objDF_InitGeneCode.FunctionName = "InitGeneCode";
            //objDynamicFunction.ReturnType = Type.GetType("System.String");
            objDF_InitGeneCode.ReturnType = Type.GetType("void");

            objDF_InitGeneCode.FunctionSignature = "public void InitGeneCode()";
            objDF_InitGeneCode.AddCommandLine("try");
            objDF_InitGeneCode.AddCommandLine("{");

            objDF_InitGeneCode.AddCommandLine("Console.WriteLine(\"执行开始!\");");
            objDF_InitGeneCode.AddCommandLine("clsSysParaEN.objLog.WriteDebugLog(\"执行开始!\");");

            //objDF_InitGeneCode.AddCommandLine("  string strTabId = \"01160052\";");
            //objDF_InitGeneCode.AddCommandLine(" string strPrjDataBaseId = \"0111\";");
            //objDF_InitGeneCode.AddCommandLine(" string strPrjId = \"0116\";");
            string strCommandLine = string.Format("  AutoGCEx.AppSet(\"{0}\");", objSpecSQL.ConnectionString);
            objDF_InitGeneCode.AddCommandLine(strCommandLine);
            objDF_InitGeneCode.AddCommandLine("  AutoGCEx.SetCommFun4BL();");
            //objDF_InitGeneCode.AddCommandLine("  objPrjTabENEx = AutoGCEx.InitGC(strTabId, strPrjDataBaseId, strPrjId);");
            //       objDynamicFunction.AddCommandLine("  string strResult = GenIsExist();");
            //objDynamicFunction.AddCommandLine("    Console.WriteLine(\"执行完成!\" + strResult);");
            objDF_InitGeneCode.AddCommandLine("Console.WriteLine(\"执行完成!\");");
            objDF_InitGeneCode.AddCommandLine("clsSysParaEN.objLog.WriteDebugLog(\"执行完成!\");");
            objDF_InitGeneCode.AddCommandLine("}");
            objDF_InitGeneCode.AddCommandLine("catch (Exception objException)");
            objDF_InitGeneCode.AddCommandLine("{");
            objDF_InitGeneCode.AddCommandLine("Console.WriteLine(objException.Message);");
            objDF_InitGeneCode.AddCommandLine("clsSysParaEN.objLog.WriteDebugLog(objException.Message);");

            //    objDynamicFunction.AddCommandLine("MessageBox.Show(objException.Message);");
            objDF_InitGeneCode.AddCommandLine("}");
            mobjDynamicCompiler.AddFunction(objDF_InitGeneCode);
            clsDynamicFunction objDF_KeyWhereStr = GetFunction_KeyWhereStr();
            mobjDynamicCompiler.AddFunction(objDF_KeyWhereStr);
            clsDynamicFunction objDF_SetTabId4GC = GetFunction_SetTabId4GC();
            mobjDynamicCompiler.AddFunction(objDF_SetTabId4GC);

            marrDynamicFunctionLst = new List<clsDynamicFunction>();
            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
            {
                clsvFunction4GeneCodeEN obj = clsvFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                clsDynamicFunction objDynamicFunction1 = GetFunction_ByFuncId(obj);
                mobjDynamicCompiler.AddFunction(objDynamicFunction1);
                marrDynamicFunctionLst.Add(objDynamicFunction1);
            }
            //clsDynamicFunction objDynamicFunction1 = GetFunction_GenIsExist();
            //objDynamicCompiler.AddFunction(objDynamicFunction1);
            //clsDynamicFunction objDynamicFunction2 = GetFunction_KeyWhereStr();
            //objDynamicCompiler.AddFunction(objDynamicFunction2);
            try
            {
                mobjDynamicCompiler.CompilerCode();

                mobjDynamicCompiler.ExecFunction(objDF_InitGeneCode);
            }
            catch(Exception objException)
            {
                throw objException;
            }

            return true;
        }
        public static string GeneCodeByFuncId(string strFuncId, string strTabId, string strPrjDataBaseId, string strPrjId)
        {
            InitDynamicCompiler();
            if (mstrTabId_Static != strTabId)
            {
                string strTabName = SetTabId4GC(strTabId, strPrjDataBaseId, strPrjId);
                if (string.IsNullOrEmpty(strTabName) == false)
                {
                    mstrTabId_Static = strTabId;
                }
            }
            clsDynamicFunction objDynamicFunction = GetDynamicFunctionByFuncId(strFuncId);
            if (objDynamicFunction == null)
            {
                string strMsg = string.Format("根据函数Id:[{0}]查找已经编译过的动态函数失败!({1}->{2})",
                     strFuncId,
                     clsStackTrace.GetCurrClassFunctionByLevel(2),
                     clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            mobjDynamicCompiler.ExecFunction(objDynamicFunction);
            string strResult = objDynamicFunction.ExecReturn.ToString();   
            return strResult;
        }

        public static string GeneCodeByFuncId4View(string strFuncId, string strViewId, string strPrjDataBaseId, string strPrjId)
        {
            //InitDynamicCompiler();
            //if (mstrTabId_Static != strViewId)
            //{
            //    string strTabName = SetTabId4GC(strViewId, strPrjDataBaseId, strPrjId);
            //    if (string.IsNullOrEmpty(strTabName) == false)
            //    {
            //        mstrTabId_Static = strViewId;
            //    }
            //}
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(strFuncId);
            if (objFunction4GeneCodeEN == null)
            {
                string strMsg = string.Format("根据函数Id:[{0}]查找已经编译过的动态函数失败!({1}->{2})",
                     strFuncId,
                     clsStackTrace.GetCurrClassFunctionByLevel(2),
                     clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }      
            string strResult = clsTzGCScript.ExecFunction(objFunction4GeneCodeEN);
            return strResult;
        }


        private static clsDynamicFunction GetDynamicFunctionByFuncId(string strFuncId)
        {
            foreach (clsDynamicFunction objDynamicFunction in marrDynamicFunctionLst)
            {
                if (objDynamicFunction.FuncId == strFuncId)
                {
                    return objDynamicFunction;
                }
            }
            return null;
        }
        private static clsDynamicFunction GetFunction_ByFuncId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            clsDynamicFunction objDynamicFunction = new clsDynamicFunction();
            objDynamicFunction.FuncId = objvFunction4GeneCodeEN.FuncId4GC;
            objDynamicFunction.FunctionName = objvFunction4GeneCodeEN.FuncName;
            objDynamicFunction.ReturnType = Type.GetType(objvFunction4GeneCodeEN.ReturnTypeName);// Type.GetType("System.String");
            objDynamicFunction.FunctionSignature = objvFunction4GeneCodeEN.FunctionSignature;
            string strCodeText = objvFunction4GeneCodeEN.FuncCode;
            objDynamicFunction.AddCommandLine(strCodeText);
            return objDynamicFunction;
        }


        private static clsDynamicFunction GetFunction_KeyWhereStr()
        {
            clsDynamicFunction objDynamicFunction = new clsDynamicFunction();
            objDynamicFunction.FunctionName = "KeyWhereStr";
            objDynamicFunction.ReturnType = Type.GetType("System.String");
            objDynamicFunction.FunctionSignature = "private string KeyWhereStr()";

            objDynamicFunction.AddCommandLine(" return \"\";");
            return objDynamicFunction;
        }
        private static clsDynamicFunction GetFunction_SetTabId4GC()
        {            
            mobjDF_SetTabId4GC = new clsDynamicFunction();
            mobjDF_SetTabId4GC.FunctionName = "SetTabId4GC";
            mobjDF_SetTabId4GC.ReturnType = Type.GetType("System.String");
            //objDF_SetTabId4GC.ReturnType = Type.GetType("void");

            mobjDF_SetTabId4GC.FunctionSignature = "public string SetTabId4GC(string strTabId ,string strPrjDataBaseId ,string strPrjId)";
            mobjDF_SetTabId4GC.AddCommandLine("try");
            mobjDF_SetTabId4GC.AddCommandLine("{");

            mobjDF_SetTabId4GC.AddCommandLine("Console.WriteLine(\"执行开始!\");");

            mobjDF_SetTabId4GC.AddCommandLine("  objPrjTabENEx = AutoGCEx.InitGC(strTabId, strPrjDataBaseId, strPrjId);");
            mobjDF_SetTabId4GC.AddCommandLine("Console.WriteLine(\"执行完成!\"  + objPrjTabENEx.TabName);");
            mobjDF_SetTabId4GC.AddCommandLine("return objPrjTabENEx.TabName;");
            mobjDF_SetTabId4GC.AddCommandLine("}");
            mobjDF_SetTabId4GC.AddCommandLine("catch (Exception objException)");
            mobjDF_SetTabId4GC.AddCommandLine("{");
            mobjDF_SetTabId4GC.AddCommandLine("Console.WriteLine(objException.Message);");
            mobjDF_SetTabId4GC.AddCommandLine("clsSysParaEN.objLog.WriteDebugLog(objException.Message);");

            //    objDynamicFunction.AddCommandLine("MessageBox.Show(objException.Message);");
            mobjDF_SetTabId4GC.AddCommandLine("}");
            mobjDF_SetTabId4GC.AddCommandLine("return \"\";");

            return mobjDF_SetTabId4GC;
        }
        /// <summary>
        /// 为生成代码设置TabId
        /// </summary>
        /// <param name="strTabId">表Id</param>
        /// <param name="strPrjDataBaseId">数据库Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>返回表名</returns>
        private static string SetTabId4GC(string strTabId, string strPrjDataBaseId, string strPrjId)
        {
            string strResult = "";
            try
            {
                //InitDynamicCompiler();
                mobjDF_SetTabId4GC.AddParameter(strTabId);
                mobjDF_SetTabId4GC.AddParameter(strPrjDataBaseId);
                mobjDF_SetTabId4GC.AddParameter(strPrjId);
                mobjDynamicCompiler.ExecFunction(mobjDF_SetTabId4GC);
                strResult = mobjDF_SetTabId4GC.ExecReturn.ToString();
            }
            catch(Exception objException)
            {
                string strMsg = string.Format("在生成代码设置TabId:[{0}]时出错：[{1}].strPrjDataBaseId={2},strPrjId={3}.({4}->{5})",
                    strTabId, objException.Message, strPrjDataBaseId, strPrjId, 
                    clsStackTrace.GetCurrClassFunctionByLevel(2),
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }

            return strResult;
        }


    }
}
