using AGC;
using AGC.BusinessLogic;using AGC.FunClass;
using AGC.Entity;
using AutoGCLib;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.util;
using CommFunc4WebForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AGC.Webform.TestDebug
{
    public partial class TestVar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVarReturn_Click(object sender, EventArgs e)
        {
            object obj;
            obj = 123;
            int a = ChangeType<int>(obj, typeof(int));
            Console.WriteLine(a);
            obj = "abc";
            string b = ChangeType<string>(obj, typeof(string));
            Console.WriteLine(b);
            obj = true;
            bool c = ChangeType<bool>(obj, typeof(bool));
            Console.WriteLine(c);

        }
        private T ChangeType<T>(object oj, Type myType)
        {
            T result = (T)Convert.ChangeType(oj, typeof(T));
            return result;
        }
        void ChangeType2<T>(Object o, out T result)
        {
            result = (T)Convert.ChangeType(o, typeof(T));
        }

        public Object GetVarReturn(string strTypeName)
        {
            //var arrObj ;
            switch (strTypeName)
            {
                case "NodeObj":
                    var arrObj = new List<clsNodeObj>
            {
                new clsNodeObj{Name="张三",Value="01"},
                new clsNodeObj{Name="李四",Value="02"}
            };
                    return arrObj;
                case "CboObject":
                    var arrObj2 = new List<clsCboObject>
            {
                new clsCboObject{Text="张三22",Value="01"},
                new clsCboObject{Text="李四22",Value="02"}
            };
                    return arrObj2;
                default:
                    return null;
            }
        }

        public Object GetObjByKeyId2(string strTabName, string strKeyId)
        {
            
            //var arrObj ;
            switch (strTabName)
            {
                case clsTabStateEN._CurrTabName:
                    clsTabStateEN objTabState = clsTabStateBL.GetObjByTabStateId(strKeyId);
                    return objTabState;
                case clsCodeTypeEN._CurrTabName:
                    clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeId(strKeyId);
                    return objCodeType;
                default:
                    return null;
            }
        }

    
        public Object GetObjByKeyId(string strClassName, string strFuncName, string strKeyId)
        {
            try
            {
                Object objReturn = null;
                Type t2 = typeof(clsTabStateBL);
                Type t = Type.GetType(strClassName);

                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Static | BindingFlags.Public);

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
                        objReturn = mt.Invoke(this, null);
                    }
                    else if (mt.GetParameters().Length == 1)
                    {
                        objReturn = mt.Invoke(this, new object[] { strKeyId });
                    }
                    //Console.WriteLine(str);
                }

                return objReturn;

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
                        objException.Message,
                        clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }


        public Object GetObjLst(string strClassName, string strFuncName, string strCondition)
        {
            try
            {
                Object objReturn = null;
                Type t2 = typeof(clsTabStateBL);
                Type t = Type.GetType(strClassName);
                MethodInfo mt = null;
                try
                {
                    mt = t.GetMethod(strFuncName,                         
                                            BindingFlags.Public | BindingFlags.Static,//筛选条件
                                            Type.DefaultBinder,//绑定
                                            new Type[] { strCondition.GetType()},//参数类型
                                            new ParameterModifier[] { new ParameterModifier(1) }//参数个数
                                        );

                    //"TryParse",//方法名
                    //                        BindingFlags.Public | BindingFlags.Static | BindingFlags.Default,//筛选条件
                    //                        Type.DefaultBinder,//绑定
                    //                        new Type[] { tmp.GetType(), t.MakeByRefType() },//参数类型
                    //                        new ParameterModifier[] { new ParameterModifier(2) }//参数个数
                    //                    );
                    
                    
                }
                catch(Exception objException)
                {
                    string strMsg = string.Format("在类中获取函数出错:{0}.{2}(In {1})", 
                        strFuncName, clsStackTrace.GetCurrClassFunction(), objException.Message);
                    throw new Exception(strMsg);
                }
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
                        objReturn = mt.Invoke(this, null);
                    }
                    else if (mt.GetParameters().Length == 1)
                    {
                        objReturn = mt.Invoke(this, new object[] { strCondition });
                    }
                    //Console.WriteLine(str);
                }

                return objReturn;

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
                        objException.Message,
                        clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }


        public Object GetObjByKeyId(string strTabName, string strKeyId)
        {

            string strClassName = string.Format("AGC.Entity.cls{0}EN", strTabName);
            clsEntityBase2 objEntity = clsPubFun. GetClassByName(strClassName); 
            if (objEntity == null)
            {
               string strMsg = string.Format("类型:{0}所对应的类不存在，请检查！", strClassName);
                throw new Exception(strMsg);
            }
            string strKeyFieldName = objEntity._TabKeyFldNames[0];
            string strFuncName = string.Format("GetObjBy{0}", strKeyFieldName);
            string strClassNameBL = string.Format("AGC.BusinessLogic.cls{0}BL, AgcBusinessLogic", strTabName);

            Object objReturn = GetObjByKeyId(strClassNameBL, strFuncName, strKeyId);
            return objReturn;
        }

        public T GetObjByKeyIdV2<T>(string strTabName, string strKeyId)
        {

            string strClassName = string.Format("AGC.Entity.cls{0}EN", strTabName);
            clsEntityBase2 objEntity = clsPubFun.GetClassByName(strClassName);
            if (objEntity == null)
            {
                string strMsg = string.Format("类型:{0}所对应的类不存在，请检查！", strClassName);
                throw new Exception(strMsg);
            }
            string strKeyFieldName = objEntity._TabKeyFldNames[0];
            string strFuncName = string.Format("GetObjBy{0}", strKeyFieldName);
            string strClassNameBL = string.Format("AGC.BusinessLogic.cls{0}BL, AgcBusinessLogic", strTabName);

            Object objReturn = GetObjByKeyId(strClassNameBL, strFuncName, strKeyId);
            T objT = (T)objReturn;
            return objT;
        }

        //public string TestOption(Option<string> op1)
        //{

        //}
        public T GetObjLst<T>(string strTabName, string strCondition)
        {

            //string strClassName = string.Format("AGC.Entity.cls{0}EN", strTabName);
            //clsEntityBase2 objEntity = clsPubFun.GetClassByName(strClassName);
            //if (objEntity == null)
            //{
            //    string strMsg = string.Format("类型:{0}所对应的类不存在，请检查！", strClassName);
            //    throw new Exception(strMsg);
            //}
            //string strKeyFieldName = objEntity._TabKeyFldNames[0];
            string strFuncName = string.Format("GetObjLst");
            string strClassNameBL = string.Format("AGC.BusinessLogic.cls{0}BL, AgcBusinessLogic", strTabName);

            Object objReturn = GetObjLst(strClassNameBL, strFuncName, strCondition);
            T objT = (T)objReturn;
            return objT;
        }
        protected void btnVarReturnObjLst_Click(object sender, EventArgs e)
        {
            //string strTypeName = "NodeObj";
            string strTypeName = "CboObject";

            Object myObj = GetVarReturn(strTypeName);
            var arrObj = myObj as List<clsCboObject>;
            lblResult.Text = arrObj[0].Text;
        }

        protected void btnReturnObjByKey_Click(object sender, EventArgs e)
        {
            try
            {
                string strTabName = clsTabStateEN._CurrTabName;

                Object myObj = GetObjByKeyId(strTabName, "01");
                var objTabState = myObj as clsTabStateEN;
                lblResult.Text = objTabState.TabStateName;
            }
            catch(Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

        protected void btnReturnObjByKeyV2_Click(object sender, EventArgs e)
        {
            try
            {
                string strTabName = clsTabStateEN._CurrTabName;

                var objTabState = GetObjByKeyIdV2<clsTabStateEN>(strTabName, "01");
                //var objTabState = myObj as clsTabStateEN;
                lblResult.Text = objTabState.TabStateName;
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }

        protected void btnGetObjLst_Click(object sender, EventArgs e)
        {
            try
            {
                Func<int, int, int> divide = (x, y) => x / y;
                int xx = divide(10, 5);
                string strTabName = clsTabStateEN._CurrTabName;

                var objLst = GetObjLst<List<clsTabStateEN>>(strTabName, "1=1");
                //var objTabState = myObj as clsTabStateEN;
                foreach(clsTabStateEN objInfor in objLst)
                {
                    lblResult.Text += objInfor.GetName();
                }
            }
            catch (Exception objException)
            {
                clsCommonJsFunc.Alert(this, objException.Message);
            }
        }
       
    }
  
}