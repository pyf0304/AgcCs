using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;

namespace Agc_CsWin.frm.Test
{
    public partial class frm即时编译 : Form
    {
        public frm即时编译()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string className = txtClassName.Text;
            string methodName = txtFuncName.Text;

           


            //ICodeCompiler complier = (new CSharpCodeProvider().CreateCompiler());

            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            // 设置编译参数。 
            CompilerParameters paras = new CompilerParameters();
            paras.ReferencedAssemblies.Add("System.dll");
            paras.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            paras.GenerateExecutable = false;
            paras.GenerateInMemory = true;
            //paras.OutputAssembly = "myasm.dll";
            // 动态创建代码。 
            StringBuilder classSrc = new StringBuilder();
            classSrc.Append("public class " + className );
            classSrc.Append("{");
            classSrc.Append(txtContent.Text);
            classSrc.Append("}");

            //…… 构造类源码结构
            // 编译代码。 
            CompilerResults result = null;// provider.CompileAssemblyFromSource(paras, classSrc.ToString());
            try
            {
                result = provider.CompileAssemblyFromSource(paras, classSrc.ToString());
            }
            catch(Exception objException)
            {
                MessageBox.Show(objException.Message);
            }

            if (result.Errors.HasErrors)
            {
                Console.WriteLine("编译错误：");
                foreach (CompilerError err in result.Errors)
                {
                    Console.WriteLine(err.ErrorText);
                }
            }
            // 获取编译后的程序集。 
            try
            {
                Assembly assembly = result.CompiledAssembly;
                // 动态调用方法。 
                object eval = assembly.CreateInstance(className);
                MethodInfo method = eval.GetType().GetMethod(methodName);
                object reobj = method.Invoke(eval, null);
                string ss = reobj.ToString();
                lblResult.Text = ss;
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ICodeCompiler loCompiler = new CSharpCodeProvider().CreateCompiler();
            //CompilerParameters loParameters = new CompilerParameters();
            //loParameters.ReferencedAssemblies.Add("System.Wind ows.Forms.dll");
            //loParameters.GenerateInMemory = false;
            //loParameters.OutputAssembly = "myasm.dll";


            //CompilerResults loCompiled =
            // loCompiler.CompileAssemblyFromSource(loParameters, lcCode);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string className = txtClassName.Text;
            string methodName = txtFuncName.Text;

            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
 CompilerParameters cp = new CompilerParameters();
 cp.ReferencedAssemblies.Add("System.Windows.Forms. dll");
 cp.GenerateInMemory = false;
 cp.OutputAssembly = "myasm.dll";
 StringBuilder classSrc = new StringBuilder();
 classSrc.Append("public class " + className + "/r/n");
 classSrc.Append("{" + "/r/n");
 classSrc.Append(txtContent.Text + "/r/n");
 classSrc.Append("}" + "/r/n");

CompilerResults result =
 provider.CompileAssemblyFromSource(cp, classSrc.ToString());
 
//Orcas beta2 doesnt throw any deprecation warnings
// for this snippet ;).
 
        }
    }
}
