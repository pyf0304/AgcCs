using AGC.BusinessLogicEx;
using com.taishsoft.common;
using CommFunc4WebForm;
using LaYumba.Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static LaYumba.Functional.F;

namespace AGC.Webform.Test
{
    public partial class TestAIProgramming : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAIProgramming_Click(object sender, EventArgs e)
        {
            string strFunName1 = "Fun1";
            string strFunName2 = "Fun2";
            int x = 5;
            try
            {
                object obj1 = ExecFunc(strFunName1, x);
                object obj2 = ExecFunc(strFunName2, obj1);
                int yy = (int)obj2;
                lblResult.Text = yy.ToString();
            }
            catch(Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }

        }
        public int Fun1(int x)
        {
            int y = 2 * x;
            return y;
        }
        public int Fun2(int x)
        {
            int y = x * x;
            return y;
        }

        public Object Fun3(Object x)
        {
            var ab = (Tuple<int, int>)x;
            int y1 = 2 * ab.Item1;
            int y2 = 2*ab.Item2;
            return new Tuple<int, int>(y1,y2);
        }
        public int Fun4(Object x)
        {
            var tt = (Tuple<int, int>)x;
            int y = tt.Item1 + tt.Item2;
            return y;
        }
        public object ExecFunc(string strFuncName, object objPara)
        {
            //string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                object objResult = null;
                Type t = typeof(TestAIProgramming);
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
                        objResult = mt.Invoke(this, null);
                    }
                    else if (mt.GetParameters().Length == 1)
                    {
                        objResult = mt.Invoke(this, new object[] { objPara });
                    }
                    //Console.WriteLine(str);
                }

                return objResult;
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", strFuncName, objException.Message);
                throw new Exception(sbMessage.ToString());
            }
        }

        protected void btnAIProgramming2_Click(object sender, EventArgs e)
        {
            string strFunName1 = "Fun3";
            string strFunName2 = "Fun4";
            int a = 5, b = 6;

            var x = new Tuple<int, int>(a,b);
            
            try
            {
                object obj1 = ExecFunc(strFunName1, x);
                object obj2 = ExecFunc(strFunName2, obj1);
                int yy = (int)obj2;
                lblResult.Text = yy.ToString();
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }

        }

        protected void btnTestOption_Click(object sender, EventArgs e)
        {
            Option<string> _ = None;
            Option<string> john = Some("John");
            string greet(Option<string> greetee)
                => greetee.Match(
                    None:()=> $"Sorry, who?",
                    Some:(name) => $"hello, {name}");
            string aa = greet(None);
            string bb = greet(Some("John"));
            clsCommonJsFunc.Alert(this, aa + bb);

        }
    }
}