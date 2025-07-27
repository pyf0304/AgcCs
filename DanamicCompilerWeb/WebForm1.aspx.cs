using CommFunc4WebForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DanamicCompilerWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Configer configer = Configer.Current(filePath);

                //获取调用的代码
                string code = configer.GetNodeProperty(
                    "FunBtn//btndetail//btn[@name='" + ((Button)sender).Name + "']", "code");

                //获取调用方法的返回值类型
                string returnType =
                    configer.GetNodeProperty("FunBtn//btndetail//btn[@name='" + ((Button)sender).Name + "']",
                                             "returntype");
                //根据返回值类型，判断调用那个动态生成的接口
                switch (returnType)
                {
                    case "void":
                        Evaluator.EvaluateToVoid(code);
                        break;
                    case "object":
                        Evaluator.EvaluateToObject(code);
                        break;
                    case "int":
                        Evaluator.EvaluateToInteger(code);
                        break;
                    case "bool":
                        Evaluator.EvaluateToBool(code);
                        break;
                    case "string":
                        Evaluator.EvaluateToString(code);
                        break;
                }
            }
            catch (Exception exception)
            {
              clsCommonJsFunc.Alert(this, exception.Message);
            }
        }
    }
}