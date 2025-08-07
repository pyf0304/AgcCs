using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using AutoGCLib;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.dynamiccompiler;
using CommonTable.Entity;
using MyCalc;
using SpecData;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;


namespace DynamicCompilerWin
{
    public partial class frmTestGeneCodeByDynamicCompiler : Form
    {
        private clsPrjTabENEx objPrjTabENEx = null;
        public frmTestGeneCodeByDynamicCompiler()
        {
            InitializeComponent();
            clsCalc.intTimes = 10;
        }
        public void AA()
        {
            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            CompilerParameters cp = new CompilerParameters();
            cp.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            cp.GenerateInMemory = false;
            cp.OutputAssembly = "myasm.dll";

            //CompilerResults result =
            //provider.CompileAssemblyFromSource(cp, sourceCode);
        }
        private void btnDynCompAndExec_Click(object sender, EventArgs e)
        {
            CodeDomProvider objCSharpCodePrivoder = CodeDomProvider.CreateProvider("CSharp");

            //CSharpCodeProvider objCSharpCodePrivoder = new CSharpCodeProvider();

            // 2.ICodeComplier  
            //ICodeCompiler objICodeCompiler = objCSharpCodePrivoder.CreateCompiler();

            // 3.CompilerParameters  
            CompilerParameters objCompilerParameters = new CompilerParameters();
            objCompilerParameters.ReferencedAssemblies.Add("System.dll");
            objCompilerParameters.GenerateExecutable = false;
            objCompilerParameters.GenerateInMemory = true;

            // 4.CompilerResults  
            CompilerResults cr = objCSharpCodePrivoder.CompileAssemblyFromSource(objCompilerParameters, GenerateCode());



            if (cr.Errors.HasErrors)
            {
                Console.WriteLine("编译错误：");
                foreach (CompilerError err in cr.Errors)
                {
                    Console.WriteLine(err.ErrorText);
                }
            }
            else
            {
                // 通过反射，调用HelloWorld的实例  
                Assembly objAssembly = cr.CompiledAssembly;
                object objHelloWorld = objAssembly.CreateInstance("DynamicCodeGenerate.HelloWorld");
                MethodInfo objMI = objHelloWorld.GetType().GetMethod("OutPut");

                string strResult = objMI.Invoke(objHelloWorld, null).ToString();
                lblResult.Text = strResult;
            }

        }

        private void btnDynCompAndExec_ClickBak(object sender, EventArgs e)
        {
            CodeDomProvider objCSharpCodePrivoder = CodeDomProvider.CreateProvider("CSharp");

            //CSharpCodeProvider objCSharpCodePrivoder = new CSharpCodeProvider();

            // 2.ICodeComplier  
            ICodeCompiler objICodeCompiler = objCSharpCodePrivoder.CreateCompiler();

            // 3.CompilerParameters  
            CompilerParameters objCompilerParameters = new CompilerParameters();
            objCompilerParameters.ReferencedAssemblies.Add("System.dll");
            objCompilerParameters.GenerateExecutable = false;
            objCompilerParameters.GenerateInMemory = true;

            // 4.CompilerResults  
            CompilerResults cr = objICodeCompiler.CompileAssemblyFromSource(objCompilerParameters, GenerateCode());



            if (cr.Errors.HasErrors)
            {
                Console.WriteLine("编译错误：");
                foreach (CompilerError err in cr.Errors)
                {
                    Console.WriteLine(err.ErrorText);
                }
            }
            else
            {
                // 通过反射，调用HelloWorld的实例  
                Assembly objAssembly = cr.CompiledAssembly;
                object objHelloWorld = objAssembly.CreateInstance("DynamicCodeGenerate.HelloWorld");
                MethodInfo objMI = objHelloWorld.GetType().GetMethod("OutPut");

                string strResult = objMI.Invoke(objHelloWorld, null).ToString();
                lblResult.Text = strResult;
            }

        }

        private string GenerateCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("using System;");
            sb.Append(Environment.NewLine);
            sb.Append("namespace DynamicCodeGenerate");
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            sb.Append("      public class HelloWorld");
            sb.Append(Environment.NewLine);
            sb.Append("      {");
            sb.Append(Environment.NewLine);
            sb.Append("          public string OutPut()");
            sb.Append(Environment.NewLine);
            sb.Append("          {");
            sb.Append(Environment.NewLine);
            sb.Append("               return \"Hello world!\";");
            sb.Append(Environment.NewLine);
            sb.Append("          }");
            sb.Append(Environment.NewLine);
            sb.Append("      }");
            sb.Append(Environment.NewLine);
            sb.Append("}");

            string code = sb.ToString();
            Console.WriteLine(code);
            Console.WriteLine();

            return code;
        }

        private void btnTestDynamicCompilerClass_Click(object sender, EventArgs e)
        {
            clsDynamicCompiler objDynamicCompiler = new clsDynamicCompiler();
            objDynamicCompiler.NameSpace = "MyTest";
            objDynamicCompiler.ClassName = "Hello";
            clsDynamicFunction objDynamicFunction = new clsDynamicFunction();
            objDynamicFunction.FunctionName = "OutPut";
            objDynamicFunction.FunctionSignature = "public string OutPut()";
            objDynamicFunction.AddCommandLine("string strName=\"Pyf\";");
            objDynamicFunction.AddCommandLine("return string.Format(\"Hello world!{0}\", strName);");
            objDynamicCompiler.AddFunction(objDynamicFunction);
            objDynamicCompiler.CompilerCode();
            objDynamicCompiler.ExecFunction(objDynamicFunction);
            lblResult.Text = objDynamicFunction.ExecReturn.ToString();
        }

        private void btnTestCalc_Click(object sender, EventArgs e)
        {
            clsCalc objCalc = new clsCalc();
            double dblArea = objCalc.Area(10);
            lblResult.Text = dblArea.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsDynamicCompiler objDynamicCompiler = new clsDynamicCompiler();
            objDynamicCompiler.NameSpace = "MyTest";
            objDynamicCompiler.ClassName = "TestCalc";
            objDynamicCompiler.AddReferencedAssemblie("MyCalc.dll");
            objDynamicCompiler.AddUsing("MyCalc");
            clsDynamicFunction objDynamicFunction = new clsDynamicFunction();
            objDynamicFunction.FunctionName = "GetArea";
            objDynamicFunction.FunctionSignature = "public double GetArea(double dblR)";
            objDynamicFunction.AddCommandLine("clsCalc objCalc = new clsCalc();");
            objDynamicFunction.AddCommandLine(" double dblArea = objCalc.Area(dblR);");
            objDynamicFunction.AddCommandLine("return dblArea;");
            objDynamicCompiler.AddFunction(objDynamicFunction);
            objDynamicCompiler.CompilerCode();
            objDynamicFunction.AddParameter(10.0);
            objDynamicCompiler.ExecFunction(objDynamicFunction);
            lblResult.Text = objDynamicFunction.ExecReturn.ToString();
        }
        public void ReFreshCache()
        {
            string strMsg = string.Format("刷新缓存成功！({2}->{1}->{0})",
           clsStackTrace.GetCurrClassFunction(),
           clsStackTrace.GetCurrClassFunctionByLevel(2),
           clsStackTrace.GetCurrClassFunctionByLevel(3));
            clsSysParaEN.objLog.WriteDebugLog(strMsg);
            // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
            clsPrjTabBL.ReFreshThisCache();
            if (clsPrjTabBL.objCommFun4BL != null) clsPrjTabBL.objCommFun4BL.ReFreshCache();
        }

        private void btnTestDynCompiler4CacheInit_Click(object sender, EventArgs e)
        {
            clsDynamicCompiler objDynamicCompiler = new clsDynamicCompiler();
            objDynamicCompiler.NameSpace = "MyTest";
            objDynamicCompiler.ClassName = "AgcCs";
            objDynamicCompiler.AddReferencedAssemblie("TzPubFunction.dll");
            objDynamicCompiler.AddReferencedAssemblie("PubDataBase.dll");
            objDynamicCompiler.AddReferencedAssemblie("CommonTableENDABL.dll");
            objDynamicCompiler.AddReferencedAssemblie("AgcEN.dll");
            objDynamicCompiler.AddReferencedAssemblie("AgcDA.dll");
            objDynamicCompiler.AddReferencedAssemblie("AgcBusinessLogic.dll");
            objDynamicCompiler.AddUsing("com.taishsoft.common");
            objDynamicCompiler.AddUsing("AGC_CSV7.BusinessLogic");
            objDynamicCompiler.AddUsing("CommonTable.Entity");
            clsDynamicFunction objDynamicFunction = new clsDynamicFunction();
            objDynamicFunction.FunctionName = "ReFreshCache";
            //objDynamicFunction.ReturnType = Type.GetType("System.String");
            objDynamicFunction.ReturnType = Type.GetType("void");

            objDynamicFunction.FunctionSignature = "public void ReFreshCache()";
            objDynamicFunction.AddCommandLine("try");
            objDynamicFunction.AddCommandLine("{");
            objDynamicFunction.AddCommandLine("Console.WriteLine(\"执行开始！\");");
            objDynamicFunction.AddCommandLine("clsSysParaEN.objLog = new clsLog();");

            objDynamicFunction.AddCommandLine("clsSysParaEN.objLog.LogDir = @\"D:\\Log\\AgcCs_Win\\\";");
            objDynamicFunction.AddCommandLine("clsSysParaEN.objLog.LogFileName = \"Debug4Win\";");
            objDynamicFunction.AddCommandLine("string strMsg = string.Format(\"刷新缓存成功！({2}->{1}->{0})\",");
            objDynamicFunction.AddCommandLine(" clsStackTrace.GetCurrClassFunction(),");
            objDynamicFunction.AddCommandLine("clsStackTrace.GetCurrClassFunctionByLevel(2),");
            objDynamicFunction.AddCommandLine("clsStackTrace.GetCurrClassFunctionByLevel(3));");
            objDynamicFunction.AddCommandLine("clsSysParaEN.objLog.WriteDebugLog(strMsg);");
            objDynamicFunction.AddCommandLine("// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用");
            objDynamicFunction.AddCommandLine("clsPrjTabBL.ReFreshThisCache();");
            objDynamicFunction.AddCommandLine("if (clsPrjTabBL.objCommFun4BL != null) clsPrjTabBL.objCommFun4BL.ReFreshCache();");
            objDynamicFunction.AddCommandLine("Console.WriteLine(\"执行完成！\");");
            objDynamicFunction.AddCommandLine("}");
            objDynamicFunction.AddCommandLine("catch (Exception objException)");
            objDynamicFunction.AddCommandLine("{");
            objDynamicFunction.AddCommandLine("Console.WriteLine(objException.Message);");
            //    objDynamicFunction.AddCommandLine("MessageBox.Show(objException.Message);");
            objDynamicFunction.AddCommandLine("}");
            objDynamicCompiler.AddFunction(objDynamicFunction);
            objDynamicCompiler.CompilerCode();

            objDynamicCompiler.ExecFunction(objDynamicFunction);
            //lblResult.Text = objDynamicFunction.ExecReturn.ToString();
        }

        private void btnTestCacheInit_Click(object sender, EventArgs e)
        {
            try
            {
                clsSysParaEN.objLog = new clsLog();
                clsSysParaEN.objLog.LogDir = @"D:\Log\AgcCs_Win\";
                clsSysParaEN.objLog.LogFileName = "Debug4Win";
                ReFreshCache();
                Console.WriteLine("执行完成！");
            }
            catch(Exception objException)
            {
                Console.WriteLine(objException.Message);
                MessageBox.Show(objException.Message);
            }
        }

        private void btnInvokeFunctionByStrName_Click(object sender, EventArgs e)
        {
         
            //clsDynamicCompiler objDynamicCompiler = new clsDynamicCompiler();
            //objDynamicCompiler.NameSpace = "MyTest";
            //objDynamicCompiler.ClassName = "TestCalc";
            //objDynamicCompiler.AddReferencedAssemblie("MyCalc.dll");
            //objDynamicCompiler.AddUsing("MyCalc");
            clsDynamicFunction objDynamicFunction = new clsDynamicFunction();
            objDynamicFunction.AssemblyFile = "MyCalc.dll";
            objDynamicFunction.NameSpace = "MyCalc";
            objDynamicFunction.ClassName = "clsCalc";
            objDynamicFunction.AssemblyType = typeof(MyCalc.clsCalc);
            objDynamicFunction.FunctionName = "Area_S";
            //objDynamicCompiler.AddFunction(objDynamicFunction);
            //objDynamicCompiler.CompilerCode();
            objDynamicFunction.AddParameter(10.0);
            try
            {
                clsDynamicCompiler.ExecStaticFunction(objDynamicFunction);
                lblResult.Text = string.Format("intTime={0}, Result={1}", clsCalc.intTimes, objDynamicFunction.ExecReturn.ToString());
            }
            catch(Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void btnAddCacheInitFunction_Click(object sender, EventArgs e)
        {
            clsPrjTabBL.objCommFun4BL = new clsCommFun4BL4PrjTab();

            clsSysParaEN.spIsUseQueue4Task = true;
            clsPrjTabBL.ReFreshCache();
            clsPrjTabFldBL.ReFreshCache();
            clsPrjTabBL.ReFreshCache();
            clsPrjTabFldBL.ReFreshCache();

//            clsPrjTabBL.ReFreshCache();
            clsPrjTabFldBL.ReFreshCache();
            int intCount = clsSysParaEN.arrFunctionLst4Queue.Count;
        }

        private void btnExecCacheInitFunction_Click(object sender, EventArgs e)
        {
            try
            {
                clsSysParaEN.spIsUseQueue4Task = false;
                clsDynamicCompiler.ExecStaticFunctionLst(clsSysParaEN.arrFunctionLst4Queue);
                MessageBox.Show(clsSysParaEN.arrFunctionLst4Queue.Count.ToString());
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

      
        private void btnInitGeneCodeByDynCompiler_Click(object sender, EventArgs e)
        {
            clsSpecSQLforSql objSpecSQL = new clsSpecSQLforSql();

            clsDynamicCompiler objDynamicCompiler = new clsDynamicCompiler();
            objDynamicCompiler.NameSpace = "MyTest";
            objDynamicCompiler.ClassName = "AgcCs";
            objDynamicCompiler.AddReferencedAssemblie("AgcBusinessLogic.dll");
            objDynamicCompiler.AddReferencedAssemblie("AgcBusinessLogicEx.dll");
            objDynamicCompiler.AddReferencedAssemblie("AgcDA.dll");
            objDynamicCompiler.AddReferencedAssemblie("AgcEN.dll");
            objDynamicCompiler.AddReferencedAssemblie("AutoGCLib.dll");
            objDynamicCompiler.AddReferencedAssemblie("CommonTableENDABL.dll");
            objDynamicCompiler.AddReferencedAssemblie("PubDataBase.dll");
            objDynamicCompiler.AddReferencedAssemblie("TzPubFunction.dll");
            objDynamicCompiler.AddUsing("AGC_CSV7.BusinessLogic");
            objDynamicCompiler.AddUsing("AGC_CSV7.BusinessLogicEx");
            objDynamicCompiler.AddUsing("AGC_CSV7.Entity");
            objDynamicCompiler.AddUsing("AutoGCLib");
            objDynamicCompiler.AddUsing("com.taishsoft.comm_db_obj");
            objDynamicCompiler.AddUsing("com.taishsoft.commdb");
            objDynamicCompiler.AddUsing("com.taishsoft.common");
            objDynamicCompiler.AddUsing("com.taishsoft.syspara");
            objDynamicCompiler.AddUsing("CommonTable.Entity");
            objDynamicCompiler.AddUsing(" System.Text");

            objDynamicCompiler.AddDefineClassVar("private clsPrjTabENEx objPrjTabENEx = null;");
            clsDynamicFunction objDynamicFunction = new clsDynamicFunction();
            objDynamicFunction.FunctionName = "InitGeneCode";
            //objDynamicFunction.ReturnType = Type.GetType("System.String");
            objDynamicFunction.ReturnType = Type.GetType("void");

            objDynamicFunction.FunctionSignature = "public void InitGeneCode()";
            objDynamicFunction.AddCommandLine("try");
            objDynamicFunction.AddCommandLine("{");

            objDynamicFunction.AddCommandLine("Console.WriteLine(\"执行开始！\");");

            objDynamicFunction.AddCommandLine("  string strTabId = \"01160052\";");
            objDynamicFunction.AddCommandLine(" string strPrjDataBaseId = \"0111\";");
            objDynamicFunction.AddCommandLine(" string strPrjId = \"0116\";");
            string strCommandLine = string.Format("  AutoGCEx.AppSet(\"{0}\");", objSpecSQL.ConnectionString);
            objDynamicFunction.AddCommandLine(strCommandLine);
            objDynamicFunction.AddCommandLine("  AutoGCEx.SetCommFun4BL();");
            objDynamicFunction.AddCommandLine("  objPrjTabENEx = AutoGCEx.InitGC(strTabId, strPrjDataBaseId, strPrjId);");
            //       objDynamicFunction.AddCommandLine("  string strResult = GenIsExist();");
            //objDynamicFunction.AddCommandLine("    Console.WriteLine(\"执行完成！\" + strResult);");
            objDynamicFunction.AddCommandLine("Console.WriteLine(\"执行完成！\"  + objPrjTabENEx.TabName);");
            objDynamicFunction.AddCommandLine("}");
            objDynamicFunction.AddCommandLine("catch (Exception objException)");
            objDynamicFunction.AddCommandLine("{");
            objDynamicFunction.AddCommandLine("Console.WriteLine(objException.Message);");
            //    objDynamicFunction.AddCommandLine("MessageBox.Show(objException.Message);");
            objDynamicFunction.AddCommandLine("}");
            objDynamicCompiler.AddFunction(objDynamicFunction);
            clsDynamicFunction objDynamicFunction1 = GetFunction_GenIsExist();
            objDynamicCompiler.AddFunction(objDynamicFunction1);
            clsDynamicFunction objDynamicFunction2 = GetFunction_KeyWhereStr();
            objDynamicCompiler.AddFunction(objDynamicFunction2);

            objDynamicCompiler.CompilerCode();

            objDynamicCompiler.ExecFunction(objDynamicFunction);
            objDynamicCompiler.ExecFunction(objDynamicFunction1);
            string strResult = objDynamicFunction1.ExecReturn.ToString();
            MessageBox.Show("初始化完成！" + strResult);
            lblResult.Text =  strResult;
        }

        private void btnInitGeneCode_Click(object sender, EventArgs e)
        {
            clsSpecSQLforSql objSpecSQL = new clsSpecSQLforSql();

            string strTabId= "01160052";
            string strPrjDataBaseId="0111";
            string strPrjId="0116";
            AutoGCEx.AppSet(objSpecSQL.ConnectionString);
            AutoGCEx.SetCommFun4BL();
      objPrjTabENEx = AutoGCEx.InitGC(strTabId, strPrjDataBaseId, strPrjId);

            string strResult = GenIsExist();
            MessageBox.Show("初始化完成！" + objPrjTabENEx.TabName + strResult);
        }
        public string GenIsExist()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///在数据库中是否存在当前对象-----------------------;
            strBuilder.Append("public bool IsExist()");
            strBuilder.Append(Environment.NewLine);
            strBuilder.Append("{");
            strBuilder.Append(Environment.NewLine);
            strBuilder.Append("clsSpecSQLforSql objSQL = null;");
            strBuilder.Append(Environment.NewLine);
            strBuilder.Append("//获取连接对象");
            strBuilder.Append(Environment.NewLine);
            strBuilder.AppendFormat("objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strBuilder.Append(Environment.NewLine);

            strBuilder.AppendFormat("if (objSQL.IsExistRecord(\"{0}\", {1}))", objPrjTabENEx.TabName, KeyWhereStr());
            strBuilder.Append(Environment.NewLine);
            strBuilder.Append("{");
            strBuilder.Append(Environment.NewLine);
            strBuilder.Append("return true;");
            strBuilder.Append(Environment.NewLine);
            strBuilder.Append("}");
            strBuilder.Append(Environment.NewLine);
            strBuilder.Append("else");
            strBuilder.Append(Environment.NewLine);
            strBuilder.Append("{");
            strBuilder.Append(Environment.NewLine);
            strBuilder.Append("return false;");
            strBuilder.Append(Environment.NewLine);
            strBuilder.Append("}");
            strBuilder.Append(Environment.NewLine);
            strBuilder.Append("}");
            strBuilder.Append(Environment.NewLine);
            ///在数据库中是否存在当前对象 ==  == ;
            return strBuilder.ToString();
        }

        public clsDynamicFunction GetFunction_GenIsExist()
        {
            clsDynamicFunction objDynamicFunction = new clsDynamicFunction();
            objDynamicFunction.FunctionName = "GenIsExist";
            objDynamicFunction.ReturnType = Type.GetType("System.String");
            objDynamicFunction.FunctionSignature = "public string GenIsExist()";
            objDynamicFunction.AddCommandLine("StringBuilder strBuilder = new StringBuilder();");
            ///在数据库中是否存在当前对象-----------------------;
            objDynamicFunction.AddCommandLine("strBuilder.Append(\"public bool IsExist()\");");
            objDynamicFunction.AddCommandLine("strBuilder.Append(Environment.NewLine);");
            objDynamicFunction.AddCommandLine("strBuilder.Append(\"{\");");
            objDynamicFunction.AddCommandLine("strBuilder.Append(Environment.NewLine);");
            objDynamicFunction.AddCommandLine("strBuilder.Append(\" clsSpecSQLforSql objSQL = null; \");");
            objDynamicFunction.AddCommandLine("strBuilder.Append(Environment.NewLine);");
            objDynamicFunction.AddCommandLine("strBuilder.Append(\" //获取连接对象\"); ");
            objDynamicFunction.AddCommandLine("strBuilder.Append(Environment.NewLine);");
            objDynamicFunction.AddCommandLine("strBuilder.AppendFormat(\" objSQL = cls{0}DA.GetSpecSQLObj(); \", objPrjTabENEx.TabName);");
            objDynamicFunction.AddCommandLine("strBuilder.Append(Environment.NewLine);");

            //objDynamicFunction.AddCommandLine("strBuilder.Append(\"}\");");
            //objDynamicFunction.AddCommandLine("strBuilder.Append(Environment.NewLine);");
            /////在数据库中是否存在当前对象 ==  == ;
            //objDynamicFunction.AddCommandLine("return strBuilder.ToString();");
            //return objDynamicFunction;

            //    strBuilder.AppendFormat("if (objSQL.IsExistRecord(\"{0}\", {1}))", objPrjTabENEx.TabName, KeyWhereStr());
            objDynamicFunction.AddCommandLine(" strBuilder.AppendFormat(\"if (objSQL.IsExistRecord(\\\"{0}\\\", {1}))\", objPrjTabENEx.TabName, KeyWhereStr()); ");
            objDynamicFunction.AddCommandLine("strBuilder.Append(Environment.NewLine);");
            objDynamicFunction.AddCommandLine("strBuilder.Append(\"{\");");
            objDynamicFunction.AddCommandLine("strBuilder.Append(Environment.NewLine);");
            objDynamicFunction.AddCommandLine("strBuilder.Append(\"return true; \");");
            objDynamicFunction.AddCommandLine("strBuilder.Append(Environment.NewLine);");
            objDynamicFunction.AddCommandLine("strBuilder.Append(\"}\");");
            objDynamicFunction.AddCommandLine("strBuilder.Append(Environment.NewLine);");
            objDynamicFunction.AddCommandLine("strBuilder.Append(\"else\");");
            objDynamicFunction.AddCommandLine("strBuilder.Append(Environment.NewLine);");
            objDynamicFunction.AddCommandLine("strBuilder.Append(\"{\");");
            objDynamicFunction.AddCommandLine("strBuilder.Append(Environment.NewLine);");
            objDynamicFunction.AddCommandLine("strBuilder.Append(\"return false; \");");
            objDynamicFunction.AddCommandLine("strBuilder.Append(Environment.NewLine);");
            objDynamicFunction.AddCommandLine("strBuilder.Append(\"}\");");
            objDynamicFunction.AddCommandLine("strBuilder.Append(Environment.NewLine);");
            objDynamicFunction.AddCommandLine("strBuilder.Append(\"}\");");
            objDynamicFunction.AddCommandLine("strBuilder.Append(Environment.NewLine);");
            ///在数据库中是否存在当前对象 ==  == ;
            objDynamicFunction.AddCommandLine("return strBuilder.ToString();");
            return objDynamicFunction;
        }

        private string KeyWhereStr()
        {
            return "";
        }

        private clsDynamicFunction GetFunction_KeyWhereStr()
        {
            clsDynamicFunction objDynamicFunction = new clsDynamicFunction();
            objDynamicFunction.FunctionName = "KeyWhereStr";
            objDynamicFunction.ReturnType = Type.GetType("System.String");
            objDynamicFunction.FunctionSignature = "private string KeyWhereStr()";
                       
            objDynamicFunction.AddCommandLine(" return \"\";");
            return objDynamicFunction;
        }

        private void btnInitGeneCode_ByGeneCode_Click(object sender, EventArgs e)
        {
            AgcCs objAgcCs = new AgcCs();
            objAgcCs.InitGeneCode();
            string ss = objAgcCs.GenIsExist();
            string ss2 = objAgcCs.GenGetDataTable_S();


        }

        private void btnInitGeneCodeByDynCompiler4Tab_Click(object sender, EventArgs e)
        {
            //string strProgLevelTypeId = clsProgLevelTypeBLEx.GetProgLevelTypeIdByClassName_Cache(clsPubConst.ClassName.BusinessLogic);
            clsCodeTypeEN objCodeType = clsCodeTypeBLEx.GetObjByClassNameAndLangType_Cache(clsPubConst.ClassName.BusinessLogic, clsPubConst.LangType.CSharp);
            //string strProgLevelTypeId = clsProgLevelTypeBLEx.GetProgLevelTypeIdByCodeTypeId_Cache(objCodeType.CodeTypeId);

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunctionTemplateRelaObjLst =
               clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId("0003",
                           clsPubConst.LangType.CSharp, objCodeType.CodeTypeId,
                           clsSQLDSTypeENEx.SQLTAB);

            clsSpecSQLforSql objSpecSQL = new clsSpecSQLforSql();

            clsDynamicCompiler objDynamicCompiler = new clsDynamicCompiler();
            objDynamicCompiler.NameSpace = "MyTest";
            objDynamicCompiler.ClassName = "AgcCs";
            objDynamicCompiler.AddReferencedAssemblie("AgcBusinessLogic.dll");
            objDynamicCompiler.AddReferencedAssemblie("AgcBusinessLogicEx.dll");
            objDynamicCompiler.AddReferencedAssemblie("AgcDA.dll");
            objDynamicCompiler.AddReferencedAssemblie("AgcEN.dll");
            objDynamicCompiler.AddReferencedAssemblie("AutoGCLib.dll");
            objDynamicCompiler.AddReferencedAssemblie("CommonTableENDABL.dll");
            objDynamicCompiler.AddReferencedAssemblie("PubDataBase.dll");
            objDynamicCompiler.AddReferencedAssemblie("TzPubFunction.dll");
            objDynamicCompiler.AddUsing("AGC_CSV7.BusinessLogic");
            objDynamicCompiler.AddUsing("AGC_CSV7.BusinessLogicEx");
            objDynamicCompiler.AddUsing("AGC_CSV7.Entity");
            objDynamicCompiler.AddUsing("AutoGCLib");
            objDynamicCompiler.AddUsing("com.taishsoft.comm_db_obj");
            objDynamicCompiler.AddUsing("com.taishsoft.commdb");
            objDynamicCompiler.AddUsing("com.taishsoft.common");
            objDynamicCompiler.AddUsing("com.taishsoft.syspara");
            objDynamicCompiler.AddUsing("CommonTable.Entity");
            objDynamicCompiler.AddUsing(" System.Text");

            objDynamicCompiler.AddDefineClassVar("private clsPrjTabENEx objPrjTabENEx = null;");
            clsDynamicFunction objDF_InitGeneCode = new clsDynamicFunction();
            objDF_InitGeneCode.FunctionName = "InitGeneCode";
            //objDynamicFunction.ReturnType = Type.GetType("System.String");
            objDF_InitGeneCode.ReturnType = Type.GetType("void");

            objDF_InitGeneCode.FunctionSignature = "public void InitGeneCode()";
            objDF_InitGeneCode.AddCommandLine("try");
            objDF_InitGeneCode.AddCommandLine("{");

            objDF_InitGeneCode.AddCommandLine("Console.WriteLine(\"执行开始！\");");

            objDF_InitGeneCode.AddCommandLine("  string strTabId = \"01160052\";");
            objDF_InitGeneCode.AddCommandLine(" string strPrjDataBaseId = \"0111\";");
            objDF_InitGeneCode.AddCommandLine(" string strPrjId = \"0116\";");
            string strCommandLine = string.Format("  AutoGCEx.AppSet(\"{0}\");", objSpecSQL.ConnectionString);
            objDF_InitGeneCode.AddCommandLine(strCommandLine);
            objDF_InitGeneCode.AddCommandLine("  AutoGCEx.SetCommFun4BL();");
            objDF_InitGeneCode.AddCommandLine("  objPrjTabENEx = AutoGCEx.InitGC(strTabId, strPrjDataBaseId, strPrjId);");
            //       objDynamicFunction.AddCommandLine("  string strResult = GenIsExist();");
            //objDynamicFunction.AddCommandLine("    Console.WriteLine(\"执行完成！\" + strResult);");
            objDF_InitGeneCode.AddCommandLine("Console.WriteLine(\"执行完成！\"  + objPrjTabENEx.TabName);");
            objDF_InitGeneCode.AddCommandLine("}");
            objDF_InitGeneCode.AddCommandLine("catch (Exception objException)");
            objDF_InitGeneCode.AddCommandLine("{");
            objDF_InitGeneCode.AddCommandLine("Console.WriteLine(objException.Message);");
            //    objDynamicFunction.AddCommandLine("MessageBox.Show(objException.Message);");
            objDF_InitGeneCode.AddCommandLine("}");
            objDynamicCompiler.AddFunction(objDF_InitGeneCode);
            clsDynamicFunction objDF_KeyWhereStr = GetFunction_KeyWhereStr();
            objDynamicCompiler.AddFunction(objDF_KeyWhereStr);

            List<clsDynamicFunction> arrDynamicFunctionLst = new List<clsDynamicFunction>();
            foreach (clsvFunction4GeneCodeEN vFunction4GeneCode in arrvFunctionTemplateRelaObjLst)
            {
                clsvFunction4GeneCodeEN obj = vFunction4GeneCode;// clsvFunction4GeneCodeBL.GetObjByFuncId4GC_Cache(objvFunctionTemplateRelaEN.FuncId4GC);
                clsDynamicFunction objDynamicFunction1 = GetFunction_ByFuncId(obj);
                objDynamicCompiler.AddFunction(objDynamicFunction1);
                arrDynamicFunctionLst.Add(objDynamicFunction1);
            }
            //clsDynamicFunction objDynamicFunction1 = GetFunction_GenIsExist();
            //objDynamicCompiler.AddFunction(objDynamicFunction1);
            //clsDynamicFunction objDynamicFunction2 = GetFunction_KeyWhereStr();
            //objDynamicCompiler.AddFunction(objDynamicFunction2);

            objDynamicCompiler.CompilerCode();

            objDynamicCompiler.ExecFunction(objDF_InitGeneCode);
            StringBuilder sbAllCode = new StringBuilder();
            try
            {
                foreach (clsDynamicFunction objDynamicFunction2 in arrDynamicFunctionLst)
                {
                    objDynamicCompiler.ExecFunction(objDynamicFunction2);
                    string strResult = objDynamicFunction2.ExecReturn.ToString();
                    sbAllCode.Append(strResult);
                }
            }
            catch(Exception objException)
            {
                MessageBox.Show("出现错误！" + objException.ToString());
                return;
            }
            MessageBox.Show("初始化完成！" + sbAllCode.ToString());
            lblResult.Text = sbAllCode.ToString();
        }

        private clsDynamicFunction GetFunction_ByFuncId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            clsDynamicFunction objDynamicFunction = new clsDynamicFunction();
            objDynamicFunction.FunctionName = objvFunction4GeneCodeEN.FuncName;
            objDynamicFunction.ReturnType = Type.GetType(objvFunction4GeneCodeEN.ReturnTypeName);// Type.GetType("System.String");
            objDynamicFunction.FunctionSignature = objvFunction4GeneCodeEN.FunctionSignature;
            string strCodeText = objvFunction4GeneCodeEN.FuncCode;
            objDynamicFunction.AddCommandLine(strCodeText);
            return objDynamicFunction;
        }
    }
}
