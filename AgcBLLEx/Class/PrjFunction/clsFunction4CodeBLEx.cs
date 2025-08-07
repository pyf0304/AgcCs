
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsFunction4CodeBLEx
表名:Function4Code
生成代码版本:2018.03.01.1
生成日期:2018/03/03 01:33:08
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;

using AGC.Entity;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;
using com.taishsoft.datetime;
using com.taishsoft.util;



namespace AGC.BusinessLogicEx
{

    public static class clsFunction4CodeBLEx_Static
    {
        

        /// <summary>
        /// 获取函数签名
        /// </summary>
        /// <param name = "objFunction4CodeEN">函数对象</param>
        /// <returns>函数签名</returns>
        public static string GetFunctionSignature(this clsFunction4CodeEN objFunction4CodeEN, string strProgLangTypeId = "")
        {
            //                    e.Row.Attributes.Add("onclick", "alert('onclick')");
            //e.Row.Attributes["class"] = "text-muted bg-info";
            //e.Row.CssClass = "text-muted bg-info";
            if (string.IsNullOrEmpty(strProgLangTypeId) == true) strProgLangTypeId = enumProgLangType.CSharp_01;
            IEnumerable<clsFuncParaRelaEN> arrFuncParaRela = clsFuncParaRelaBLEx.GetObjListByFuncId4CodeCacheEx(objFunction4CodeEN.FuncId4Code);
            StringBuilder sbParaList = new StringBuilder();
            if (arrFuncParaRela != null)
            {
                arrFuncParaRela = arrFuncParaRela.OrderBy(x => x.OrderNum);

                foreach (clsFuncParaRelaEN objInFor in arrFuncParaRela)
                {
                    try
                    {
                        clsFuncPara4CodeEN objFuncPara4Code = clsFuncPara4CodeBL.GetObjByFuncParaId4CodeCache(objInFor.FuncParaId4Code, objFunction4CodeEN.FuncPurposeId);
                        if (objFuncPara4Code == null) continue;
                        string strParameterType = objFuncPara4Code.GetParaTypeName(strProgLangTypeId);
                        switch (objFunction4CodeEN.ApplicationTypeId)
                        {
                            case (int)enumApplicationType.WebApp_2:
                            case (int)enumApplicationType.PubApp4WinWeb_7:

                                if (strParameterType == "Int32") strParameterType = "int";
                                break;
                        }

                        if (objFuncPara4Code.IsByRef == true)
                        {
                            sbParaList.AppendFormat("ref {0} {1}, ", strParameterType, objFuncPara4Code.ParaName);
                        }
                        else
                        {
                            sbParaList.AppendFormat("{0} {1}, ", strParameterType, objFuncPara4Code.ParaName);
                        }
                    }
                    catch(Exception objEx)
                    {
                        Console.WriteLine(objEx.ToString());
                        continue;
                    }
                }
                if (sbParaList.Length > 2)
                {
                    sbParaList.Remove(sbParaList.Length - 2, 2);
                }
            }
            string strFunctionSignature = string.Format("{0}({1})", objFunction4CodeEN.FuncName4Code, sbParaList.ToString());
            if (objFunction4CodeEN.FuncTypeId == enumFunctionType.GenericFunctions_14)
            {
                strFunctionSignature = string.Format("{0}[T]({1})", objFunction4CodeEN.FuncName4Code, sbParaList.ToString());
            }
            else                 if (objFunction4CodeEN.FuncTypeId == enumFunctionType.PureStaticFunction_12)
            {
                strFunctionSignature = string.Format("{0}(this {1})", objFunction4CodeEN.FuncName4Code, sbParaList.ToString());
            }
            return strFunctionSignature;

        }

        /// <summary>
        /// 获取函数签名
        /// </summary>
        /// <param name = "objFunction4CodeEN">函数对象</param>
        /// <returns>函数签名</returns>
        public static string GetFunctionSignatureSim(this clsFunction4CodeEN objFunction4CodeEN, string strProgLangTypeId = "")
        {
            //                    e.Row.Attributes.Add("onclick", "alert('onclick')");
            //e.Row.Attributes["class"] = "text-muted bg-info";
            //e.Row.CssClass = "text-muted bg-info";

            if (string.IsNullOrEmpty(strProgLangTypeId) == true) strProgLangTypeId = enumProgLangType.CSharp_01;
            IEnumerable<clsFuncParaRelaEN> arrFuncParaRela = clsFuncParaRelaBLEx.GetObjListByFuncId4CodeCacheEx(objFunction4CodeEN.FuncId4Code);
            StringBuilder sbParaList = new StringBuilder();
            if (arrFuncParaRela != null)
            {
                arrFuncParaRela = arrFuncParaRela.OrderBy(x => x.OrderNum);

                foreach (clsFuncParaRelaEN objInFor in arrFuncParaRela)
                {
                    clsFuncPara4CodeEN objFuncPara4Code = clsFuncPara4CodeBL.GetObjByFuncParaId4CodeCache(objInFor.FuncParaId4Code, objFunction4CodeEN.FuncPurposeId);
                    //string strProgLangTypeId = objCodeType.ProgLangTypeId;
                    string strParameterType = objFuncPara4Code.GetParaTypeName(strProgLangTypeId);
                    switch (objFunction4CodeEN.ApplicationTypeId)
                    {
                        case (int)enumApplicationType.WebApp_2:
                        case (int)enumApplicationType.PubApp4WinWeb_7:

                            if (strParameterType == "Int32") strParameterType = "int";
                            break;
                    }
                    if (objFuncPara4Code.IsByRef == true)
                    {
                        sbParaList.AppendFormat("ref {0}, ", strParameterType, objFuncPara4Code.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{0}, ", strParameterType, objFuncPara4Code.ParaName);
                    }
                }
                sbParaList.Remove(sbParaList.Length - 2, 2);
            }
            string strFunctionSignature = string.Format("{0}({1})", objFunction4CodeEN.FuncName4Code, sbParaList.ToString());
            if (objFunction4CodeEN.FuncTypeId == enumFunctionType.GenericFunctions_14)
            {
                strFunctionSignature = string.Format("{0}[T]({1})", objFunction4CodeEN.FuncName4Code, sbParaList.ToString());
            }
            else if (objFunction4CodeEN.FuncTypeId == enumFunctionType.PureStaticFunction_12)
            {
                strFunctionSignature = string.Format("{0}(this {1})", objFunction4CodeEN.FuncName4Code, sbParaList.ToString());
            }
            return strFunctionSignature;

        }
        /// <summary>
        /// 获取函数参数列表串
        /// </summary>
        /// <param name = "objFunction4CodeEN">函数对象</param>
        /// <returns>函数参数列表串</returns>
        public static string GetParaListStr(this clsFunction4CodeEN objFunction4CodeEN)
        {
            //                    e.Row.Attributes.Add("onclick", "alert('onclick')");
            //e.Row.Attributes["class"] = "text-muted bg-info";
            //e.Row.CssClass = "text-muted bg-info";
            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objFunction4CodeEN.CodeTypeId);
            IEnumerable<clsFuncParaRelaEN> arrFuncParaRela = clsFuncParaRelaBLEx.GetObjListByFuncId4CodeCacheEx(objFunction4CodeEN.FuncId4Code);
            StringBuilder sbParaList = new StringBuilder();
            if (arrFuncParaRela != null)
            {
                arrFuncParaRela = arrFuncParaRela.OrderBy(x => x.OrderNum);
         
                foreach (clsFuncParaRelaEN objInFor in arrFuncParaRela)
                {
                    clsFuncPara4CodeEN objFuncPara4Code 
                        = clsFuncPara4CodeBL.GetObjByFuncParaId4CodeCache(objInFor.FuncParaId4Code, objFunction4CodeEN.FuncPurposeId);
                    string strProgLangTypeId = objCodeType.ProgLangTypeId;
                    string strParameterType = objFuncPara4Code.GetParaTypeName(strProgLangTypeId);
                    switch (objFunction4CodeEN.ApplicationTypeId)
                    {
                        case (int)enumApplicationType.WebApp_2:
                        case (int)enumApplicationType.PubApp4WinWeb_7:

                            if (strParameterType == "Int32") strParameterType = "int";
                            break;
                    }
                    sbParaList.AppendFormat("{0} {1}, ", strParameterType, objFuncPara4Code.ParaName);

                }
                sbParaList.Remove(sbParaList.Length - 2, 2);
            }
            return sbParaList.ToString();
   
        }


        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_AddRecordEx)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        public static bool AddRecordEx2(this clsFunction4CodeEN objFunction4CodeEN)
        {
            //操作步骤:
            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //2、检查唯一性
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
                            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsFunction4CodeBL.IsExist(objFunction4CodeEN.FuncId4Code)) //判断是否有相同的关键字
            {
                strMsg = "(errid:BlEx000004)关键字字段已有相同的值";
                throw new Exception(strMsg);
            }
            try
            {
                //2、检查传进去的对象属性是否合法
                objFunction4CodeEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objFunction4CodeEN.AddNewRecord();
            }
            catch (Exception objException)
            {
                strMsg = "(errid:BlEx000003)添加记录不成功!" + objException.Message;
                throw new Exception(strMsg);
            }
            return true;
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_UpdateRecordEx)
        /// </summary>
        /// <param name = "objFunction4CodeEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool UpdateRecordEx2(this clsFunction4CodeEN objFunction4CodeEN)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
            try
            {
                //1、检查传进去的对象属性是否合法
                objFunction4CodeEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objFunction4CodeEN.Update();
            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                throw new Exception(strMsg);
            }
            return true;
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_EditRecordEx)
        /// </summary>
        /// <param name = "objFunction4CodeEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx2(this clsFunction4CodeEN objFunction4Code)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
     
            clsFunction4CodeEN objFunction4Code_Cond = new clsFunction4CodeEN();
            string strCondition = objFunction4Code_Cond
            .SetFuncId4Code(objFunction4Code.FuncId4Code, "=")
            .GetCombineCondition();
            objFunction4Code._IsCheckProperty = true;
            bool bolIsExist = clsFunction4CodeBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objFunction4Code.FuncId4Code = clsFunction4CodeBL.GetFirstID_S(strCondition);
                objFunction4Code.UpdateWithCondition(strCondition);
            }
            else
            {
                objFunction4Code.AddNewRecord();
            }
            return true;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objFunction4CodeENS">源对象</param>
        /// <returns>目标对象=>clsFunction4CodeEN:objFunction4CodeENT</returns>
        public static clsFunction4CodeENEx CopyToEx(this clsFunction4CodeEN objFunction4CodeENS)
        {
            try
            {
                clsFunction4CodeENEx objFunction4CodeENT = new clsFunction4CodeENEx();
                clsFunction4CodeBL.CopyTo(objFunction4CodeENS, objFunction4CodeENT);
                return objFunction4CodeENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objFunction4CodeENS">源对象</param>
        /// <returns>目标对象=>clsFunction4CodeEN:objFunction4CodeENT</returns>
        public static clsFunction4CodeEN CopyTo(this clsFunction4CodeENEx objFunction4CodeENS)
        {
            try
            {
                clsFunction4CodeEN objFunction4CodeENT = new clsFunction4CodeEN();
                clsFunction4CodeBL.CopyTo(objFunction4CodeENS, objFunction4CodeENT);
                return objFunction4CodeENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 函数名4Code(Function4Code)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsFunction4CodeBLEx : clsFunction4CodeBL
    {
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineObjList4Cache)
        /// </summary>
        protected static List<clsFunction4CodeEN> arrFunction4CodeObjLst4SysFunctionCache = null;

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsFunction4CodeDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsFunction4CodeDAEx Function4CodeDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsFunction4CodeDAEx();
                }
                return uniqueInstanceEx;
            }
        }


        /// <summary>
        /// 把一批记录移到最顶部
        /// </summary>
        /// <param name="arrKeyId">需要移动的记录关键字列表</param>
        /// <param name="strFuncTypeId">函数类型Id</param>
        /// <returns></returns>
        public static bool GoTop(List<string> arrKeyId, string strFuncTypeId)
        {
            try
            {
                bool bolResult = new clsFunction4CodeDAEx().GoTop(arrKeyId, strFuncTypeId);
                bolResult = new clsFunction4CodeDAEx().ReOrder(strFuncTypeId);

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错!\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 把一批记录移到最底部
        /// </summary>
        /// <param name="arrKeyId">需要移动的记录关键字列表</param>
        /// <param name="strFuncTypeId">函数类型Id</param>
        /// <returns></returns>
        public static bool GoBottom(List<string> arrKeyId, string strFuncTypeId)
        {
            try
            {
                bool bolResult = new clsFunction4CodeDAEx().GoBottom(arrKeyId, strFuncTypeId);
                bolResult = new clsFunction4CodeDAEx().ReOrder(strFuncTypeId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错!\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 调整次序。
        /// </summary>
        /// <param name="strDirect">方向：向上、向下</param>
        /// <param name="strCurrKey">需要调整记录的关键字</param>
        /// <returns></returns>
        public static bool AdjustSequenceNumber(string strDirect, string strCurrKey)
        {
            try
            {
                bool bolResult = new clsFunction4CodeDAEx().AdjustSequenceNumber(strDirect, strCurrKey);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("调整记录次序出错!\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 重序。针对模板Id的所有函数重序
        /// </summary>
        /// <returns></returns>
        public static bool ReOrder(string strFuncTypeId)
        {
            try
            {
                bool bolResult = new clsFunction4CodeDAEx().ReOrder(strFuncTypeId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错!\r\n" + objException.Message);
            }

        }
        /// <summary>
        /// 判断所给的WebService函数是否是系统函数
        /// </summary>
        /// <param name="strFuncName4Code"></param>
        /// <returns></returns>
        public static bool IsSysFunction(string strFuncName4Code)
        {
            if (string.IsNullOrEmpty(strFuncName4Code) == true) return false;
            //初始化列表缓存
            GetFunction4CodeENExObjListBySysFunction();
            IEnumerable<clsFunction4CodeEN> arrFunction4CodeObjLst_Sel1 =
            from objFunction4CodeEN in arrFunction4CodeObjLst4SysFunctionCache
            where objFunction4CodeEN.FuncName4Code == strFuncName4Code
            select objFunction4CodeEN;

            List<clsFunction4CodeEN> arrFunction4CodeObjLst_Sel = new List<clsFunction4CodeEN>();
            foreach (clsFunction4CodeEN obj in arrFunction4CodeObjLst_Sel1)
            {
                arrFunction4CodeObjLst_Sel.Add(obj);
            }
            if (arrFunction4CodeObjLst_Sel.Count == 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 获取系统函数对象列表
        /// </summary>
        /// <returns>返回对象列表</returns>
        public static void GetFunction4CodeENExObjListBySysFunction()
        {
            if (arrFunction4CodeObjLst4SysFunctionCache != null) return;
            string strCondition = string.Format("{0}='1'", conFunction4Code.IsSysFunction);
            List<clsFunction4CodeEN> arrObjList = GetObjLst(strCondition);
            arrFunction4CodeObjLst4SysFunctionCache = arrObjList;
        }

        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_FuncId4CodeEx(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
        
            List<clsFunction4CodeEN> arrObjListCache = clsFunction4CodeBL.GetObjLstCache();
            IEnumerable<clsFunction4CodeEN> arrObjList_Sel = arrObjListCache
                .Where(x => x.IsAsyncFunc == false && x.IsAsyncFunc == false)
                .OrderBy(x=>x.FuncName4Code);
            objDDL.DataValueField = conFunction4Code.FuncId4Code;
            objDDL.DataTextField = conFunction4Code.FuncName4Code;
            objDDL.DataSource = arrObjList_Sel;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_FuncId4CodeWithSignatureEx(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");

            List<clsFunction4CodeEN> arrObjListCache = clsFunction4CodeBL.GetObjLstCache();
            IEnumerable<clsFunction4CodeEN> arrObjList_Sel = arrObjListCache
                .Where(x => x.FuncPurposeId == enumFunctionPurpose.GeneCode_01)
                .OrderBy(x => x.FunctionSignatureSim);
            objDDL.DataValueField = conFunction4Code.FuncId4Code;
            objDDL.DataTextField = conFunction4Code.FunctionSignatureSim;
            objDDL.DataSource = arrObjList_Sel;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public class CboObjectComparer : IEqualityComparer<clsCboObject>
        {
            public bool Equals(clsCboObject t1, clsCboObject t2)
            {
                return (t1.Value == t2.Value);
            }
            public int GetHashCode(clsCboObject t)
            {
                return t.ToString().GetHashCode();
            }
        }

        public static void BindDdl_ClassNameEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format("1 = 1 and {0}='{1}' ",
                conFunction4Code.PrjId,
                strPrjId);
            List<clsFunction4CodeEN> arrFunction4Code = clsFunction4CodeBL.GetObjLst(strCondition).Where(x => string.IsNullOrEmpty(x.CodeTypeId) == false).ToList();
            arrFunction4Code.ForEach(x =>
            {
                clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(x.CodeTypeId);
                clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeType.ProgLangTypeId);
                x._StrTag = objProgLangType.ProgLangTypeSimName;
            });
            IEnumerable<clsCboObject> arrCboObject = arrFunction4Code.Select(x => new clsCboObject(string.Format("{0}-{1}", x.CodeTypeId, x.ClsName),
                string.Format("{0}({1})", x.ClsName, x._StrTag))).Distinct(new CboObjectComparer()).OrderBy(x => x.Text);
            objDDL.DataValueField = clsCboObject.con_Value;
            objDDL.DataTextField = clsCboObject.con_Text;
            objDDL.DataSource = arrCboObject;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static void BindDdl_TabNameEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format("1 = 1 and {0}='{1}'",
                conFunction4Code.PrjId,
                strPrjId);
            List<string> arrTabName = clsFunction4CodeBL.GetFldValue(conFunction4Code.TabName, strCondition);
            arrTabName = arrTabName.OrderBy(x => x).ToList();
            IEnumerable<clsCboObject> arrCboObject = arrTabName.Select(x => new clsCboObject(x, x));
            objDDL.DataValueField = clsCboObject.con_Value;
            objDDL.DataTextField = clsCboObject.con_Text;
            objDDL.DataSource = arrCboObject;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static void BindDdl_RootFuncIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId, string strTabName = "")
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = "";
            if (string.IsNullOrEmpty(strTabName) == true)
            {
                strCondition = string.Format("1 = 1 and {0}='{1}' and {2}={3}",
                    conFunction4Code.PrjId,
                    strPrjId, conFunction4Code.FuncId4Code, conFunction4Code.RootFuncId);
            }
            else
            {
                strCondition = string.Format("1 = 1 and {0}='{1}' and {2}={3} and {4}='{5}'",
                    conFunction4Code.PrjId,
                    strPrjId, conFunction4Code.FuncId4Code, conFunction4Code.RootFuncId,
                    conFunction4Code.TabName, strTabName);
            }
            List<clsFunction4CodeEN> arrFunction4Code = clsFunction4CodeBL.GetObjLst(strCondition);
            objDDL.DataValueField = conFunction4Code.FuncId4Code;
            objDDL.DataTextField = conFunction4Code.FuncName4Code;
            objDDL.DataSource = arrFunction4Code;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strFuncTypeID">函数类型Id</param>
        public static void BindDdl_FuncId4CodeByFuncTypeID(System.Web.UI.WebControls.DropDownList objDDL, string strFuncTypeID)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format("1 = 1 and {0}='0' And {1}='0' And {2}='{3}' Order By {4}",
                conFunction4Code.IsSysFunction,
                conFunction4Code.IsAsyncFunc,
                conFunction4Code.FuncTypeId,
                strFuncTypeID,
                conFunction4Code.FuncName4Code);
            System.Data.DataTable objDT = clsFunction4CodeBL.GetDataTable(strCondition);
            objDDL.DataValueField = conFunction4Code.FuncId4Code;
            objDDL.DataTextField = conFunction4Code.FuncName4Code;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static clsFunction4CodeEN GetObjByFuncName(string strFuncName)
        {
            return null;
        }


        /// <summary>
        /// 根据函数名称获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strFuncName4Code">所给的函数名称</param>
        /// <returns>根据函数名称获取的对象</returns>
        public static clsFunction4CodeEN GetObjByFuncName4CodeCache(string strFuncName4Code)
        {
            if (string.IsNullOrEmpty(strFuncName4Code) == true) return null;
            //初始化列表缓存
            List<clsFunction4CodeEN> arrObjLstCache = clsFunction4CodeBL.GetObjLstCache();

            IEnumerable<clsFunction4CodeEN> arrFunction4CodeObjLst_Sel1 =
            from objFunction4CodeEN in arrObjLstCache
            where objFunction4CodeEN.FuncName4Code == strFuncName4Code
            select objFunction4CodeEN;
            List<clsFunction4CodeEN> arrFunction4CodeObjLst_Sel = new List<clsFunction4CodeEN>();
            foreach (clsFunction4CodeEN obj in arrFunction4CodeObjLst_Sel1)
            {
                arrFunction4CodeObjLst_Sel.Add(obj);
            }
            if (arrFunction4CodeObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrFunction4CodeObjLst_Sel[0];
        }
        /// <summary>
        /// 根据功能Id获取函数对象列表
        /// </summary>
        /// <param name="strFeatureId">功能Id</param>
        /// <returns>函数对象列表</returns>
        public static List<clsFunction4CodeEN> GetObjLstByFeatureId(string strFeatureId)
        {
            string strCondtion = string.Format("{0} in (Select {0} From {1} Where {2}='{3}')",
                conFunction4Code.FuncId4Code,
                clsFeatureFuncRelaEN._CurrTabName,
                conFeatureFuncRela.FeatureId,
                strFeatureId);
            List<clsFunction4CodeEN> arrFunction4CodeObjLst = clsFunction4CodeBL.GetObjLst(strCondtion);
            return arrFunction4CodeObjLst;
        }
        /// <summary>
        /// 判断在一个函数对象列表中，是否存在某一个函数名的对象
        /// </summary>
        /// <param name="arrFunction4CodeObjLst">函数对象列表</param>
        /// <param name="strFuncName4Code">所给的函数名</param>
        /// <returns></returns>
        public static bool IsExistFuncNameInObjLst(List<clsFunction4CodeEN> arrFunction4CodeObjLst, string strFuncName4Code)
        {
            foreach (clsFunction4CodeEN objFunction4CodeEN in arrFunction4CodeObjLst)
            {
                if (objFunction4CodeEN.FuncName4Code == strFuncName4Code) return true;
            }
            return false;
        }
        /// <summary>
        /// 克隆记录
        /// </summary>
        /// <param name="strFuncId4Code">strFuncId4Code</param>
        /// <param name="strUserId">strUserId</param>
        /// <returns></returns>
        public static clsFunction4CodeEN CloneRecord(string strFuncId4Code, string strUserId)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4Code(strFuncId4Code);
            objFunction4CodeEN.FuncId4Code = clsFunction4CodeBL.GetMaxStrId_S();
            objFunction4CodeEN.FuncName4Code = "Copy_" + objFunction4CodeEN.FuncName4Code;
            if (string.IsNullOrEmpty(objFunction4CodeEN.ReturnTypeId))
            {
                objFunction4CodeEN.ReturnTypeId = "29";
            }
            objFunction4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objFunction4CodeEN.UpdUser = strUserId;
            objFunction4CodeEN.RootFuncId = objFunction4CodeEN.FuncId4Code;
            objFunction4CodeEN.FuncAccessModeId = objFunction4CodeEN.FuncAccessModeId;
            try
            {
                clsFunction4CodeBL.AddNewRecordBySql2(objFunction4CodeEN);
                List<string> arrmId = clsFuncParaRelaBLEx.GetmIdLstByFuncId4Code(strFuncId4Code);
                IEnumerable<long> lstmId = arrmId.Select(x => long.Parse(x));
                foreach (long strFuncParaId4Code in lstmId)
                {
                    clsFuncParaRelaEN objFuncParaRelaEN = clsFuncParaRelaBLEx.CloneRecord(strFuncParaId4Code, strUserId);
                    objFuncParaRelaEN.FuncId4Code = objFunction4CodeEN.FuncId4Code;
                    clsFuncParaRelaBL.UpdateBySql2(objFuncParaRelaEN);
                }
                return objFunction4CodeEN;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("克隆记录出错！错误：{0}。(strFuncId4GC:{1})({2})",
                    objException.Message,
                    strFuncId4Code,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 克隆记录
        /// </summary>
        /// <param name="strFuncId4Code">strFuncId4Code</param>
        /// <param name="strUserId">strUserId</param>
        /// <returns></returns>
        public static bool CloneRecordFromTemplate(string strFuncId4Code, string strPrjId, string strUserId)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4Code(strFuncId4Code);
            objFunction4CodeEN.FuncId4Code = clsFunction4CodeBL.GetMaxStrId_S();
            objFunction4CodeEN.PrjId = strPrjId;
            if (string.IsNullOrEmpty(objFunction4CodeEN.ReturnTypeId))
            {
                objFunction4CodeEN.ReturnTypeId = "29";
            }
            objFunction4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objFunction4CodeEN.UpdUser = strUserId;
            objFunction4CodeEN.RootFuncId = objFunction4CodeEN.FuncId4Code;
            try
            {
                clsFunction4CodeEN objFunction4Code_Condition = new clsFunction4CodeEN();
                string strCondition = objFunction4Code_Condition.SetPrjId(strPrjId, "=")
                    .SetFuncName4Code(objFunction4CodeEN.FuncName4Code, "=")
                    .SetCodeTypeId(objFunction4CodeEN.CodeTypeId, "=")
                    .GetCombineCondition();
                if (clsFunction4CodeBL.IsExistRecord(strCondition) == true) return true;
                clsFunction4CodeBL.AddNewRecordBySql2(objFunction4CodeEN);
                List<string> arrmId = clsFuncParaRelaBLEx.GetmIdLstByFuncId4Code(strFuncId4Code);
                IEnumerable<long> lstmId = arrmId.Select(x => long.Parse(x));
                foreach (long strFuncParaId4Code in lstmId)
                {
                    clsFuncParaRelaEN objFuncParaRelaEN = clsFuncParaRelaBL.GetObjBymId(strFuncParaId4Code);

                    clsFuncPara4CodeEN objFuncPara4Code = clsFuncPara4CodeBLEx.CloneRecordFromTemplate(objFuncParaRelaEN.FuncParaId4Code, strPrjId, strUserId);
                    objFuncParaRelaEN.SetFuncParaId4Code(objFuncPara4Code.FuncParaId4Code)
                        .SetFuncId4Code(objFunction4CodeEN.FuncId4Code)
                        .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetUpdUser(strUserId)
                        .AddNewRecord();

                }
                return true;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("克隆记录出错！错误：{0}。(strFuncId4GC:{1})({2})",
                    objException.Message,
                    strFuncId4Code,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }
      
        public static string GeneCodeV2Bak20220316(string strWorkFlowId, string strFuncId4Code, string strCodeTypeId)
        {
            string strMsg = "";
            clsFunction4CodeEN objFunction4Code = clsFunction4CodeBL.GetObjByFuncId4CodeCache(strFuncId4Code);

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeType.ProgLangTypeId);

            clsDataTypeAbbrEN objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFunction4Code.ReturnTypeId);
            string strReturnType = objFunction4Code.ReturnTypeNameCustom;
            if (string.IsNullOrEmpty(strReturnType) == true)
            {

                strReturnType = objDataTypeAbbr.GetTypeString(objCodeType.ProgLangTypeId);
            }
            strReturnType = strReturnType.Replace("[", "<")
                                  .Replace("]", ">");

            string strInitValue = objDataTypeAbbr.GetInitValue4Var(objCodeType.ProgLangTypeId);

            clswf_PointEN objPoint = clswf_PointBLEx.GetObjByTabKeyIdCache(conCodeType._CurrTabName, strCodeTypeId);
            if (objPoint == null)
            {
                strMsg = string.Format("表名:{0}，关键字:{1} 没有相关端点，请检查！(In {2})",
                                                           conCodeType._CurrTabName, objCodeType.CodeTypeId, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            string strPointId = objPoint.PointId;

            List<string> arrPrevPointId = clswf_StepProcessRelaBLEx.GetPrevPointLstCache(strWorkFlowId, strPointId).ToList();
            //clsFunction4CodeEN objFunction4Code_Prev = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objFunction4Code.PrevFuncId);
            if (arrPrevPointId.Count == 0)
            {
                strMsg = string.Format("代码类型:{0}({1})没有前置代码类型，请检查！(In {2})",
                                                            objCodeType.CodeTypeName, objCodeType.CodeTypeId, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            clswf_PointEN objPoint_Prev = clswf_PointBLEx.GetObjByPointIdCache(arrPrevPointId[0]);
            //if (objPoint_Prev == null)
            //{
            //    strMsg = string.Format("表名:{0}，关键字:{1} 没有相关端点，请检查！(In {2})",
            //                                               conCodeType._CurrTabName, arrPrevPointId[0], clsStackTrace.GetCurrClassFunction());
            //    throw new Exception(strMsg);
            //}
            clsCodeTypeEN objCodeType_Prev = clsCodeTypeBL.GetObjByCodeTypeIdCache(objPoint_Prev.TabKeyId);
            string strClassName_Prev = string.Format(objCodeType_Prev.ClassNameFormat, objFunction4Code.TabName);
            List<clsvFuncParaRelaEN> arrvFuncParaRela = clsvFuncParaRelaBLEx.GetObjListByFuncId4CodeCacheEx(strFuncId4Code);

            StringBuilder strCodeForCs = new StringBuilder();
            switch (objProgLangType.ProgLangTypeId)
            {
                case enumProgLangType.CSharp_01:
                    switch (objCodeType.CodeTypeId)
                    {
                        case enumCodeType.WA_SrvEx_0185://WA_服务扩展层(CSharp)
                        case enumCodeType.WA_Srv_0044:

                            //clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

                            strCodeForCs.Append("\r\n /// <summary>");
                            strCodeForCs.AppendFormat("\r\n /// {0}", objFunction4Code.FuncCHName4Code);
                            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(strFuncId4Code);
                            switch (objFunction4Code.FuncAccessModeId)
                            {
                                case enumFuncAccessMode.Get_01:
                                    string strParaList = "";
                                    if (arrvFuncParaRela != null)
                                    {
                                        IEnumerable<string> arrParaList = arrvFuncParaRela.Select(x => string.Format("{0}=value", x.ParaName));
                                        strParaList = string.Join("&", arrParaList);
                                    }

                                    strCodeForCs.AppendFormat("\r\n /// 调用方法: {0} /api/{1}Api/{2}?{3}",
                                      clsFuncAccessModeBL.GetNameByFuncAccessModeIdCache(objFunction4Code.FuncAccessModeId),
                                      objFunction4Code.ClsName,
                                        objFunction4Code.FuncName4Code,
                                      strParaList);
                                    break;
                            }
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n /// </summary>");
                            if (arrvFuncParaRela != null)
                            {

                                arrvFuncParaRela.ForEach(x =>
                                {
                                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>", x.ParaName, x.ParaCnName);
                                });
                            }
                            strCodeForCs.Append("\r\n /// <returns>返回是否存在?</returns>");
                            string strParaList01 = "";
                            if (arrvFuncParaRela != null)
                            {
                                IEnumerable<string> arrParaList01 = arrvFuncParaRela
                                    .Select(x => string.Format("{0} {1}", x.GetParaTypeName4Rela(objCodeType.ProgLangTypeId), x.ParaName));
                                strParaList01 = string.Join(",", arrParaList01);
                            }

                            switch (objFunction4Code.FuncAccessModeId)
                            {
                                case enumFuncAccessMode.Get_01:

                                    strCodeForCs.AppendFormat("\r\n" + "[HttpGet(\"{0}\")]", objFunction4Code.FuncName4Code);
                                    strCodeForCs.AppendFormat("\r\n" + "public ActionResult {1}({2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList01);
                                    break;
                                case enumFuncAccessMode.Post_02:
                                    strCodeForCs.AppendFormat("\r\n" + "[HttpPost(\"{0}\")]", objFunction4Code.FuncName4Code);
                                    strCodeForCs.AppendFormat("\r\n" + "public ActionResult {1}([FromBody]{2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList01);
                                    break;
                                case enumFuncAccessMode.Put_03:
                                    strCodeForCs.AppendFormat("\r\n" + "[HttpPut(\"{0}\")]", objFunction4Code.FuncName4Code);
                                    strCodeForCs.AppendFormat("\r\n" + "public ActionResult {1}([FromBody]{2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList01);

                                    break;
                                case enumFuncAccessMode.Delete_04:
                                    strCodeForCs.AppendFormat("\r\n" + "[HttpDelete(\"{0}\")]", objFunction4Code.FuncName4Code);
                                    strCodeForCs.AppendFormat("\r\n" + "public ActionResult {1}({2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList01);

                                    break;
                            }

                            strCodeForCs.Append("\r\n" + "{");
                            
                            strCodeForCs.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
                            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");
                            //strCodeForCs.Append("\r\n" + "{");
                            if (arrvFuncParaRela != null)
                            {
                                arrvFuncParaRela.ForEach(x =>
                                {
                                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(x.DataTypeId);
                                    string strTypeString = "";
                                    switch (x.DataTypeId)
                                    {
                                        case enumDataTypeAbbr.bit_03:
                                            strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0}.ToString());", x.ParaName);
                                            break;
                                        case enumDataTypeAbbr.Object_29:
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSONString = clsJSON.GetJsonFromObj({0});", x.ParaName);
                                            strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", strJSONString);", x.ParaName);
                                            break;
                                        case enumDataTypeAbbr.ObjectLst_30:
                                            strTypeString = clsDataTypeAbbrBLEx.GetTypeNameByArrayType(x.ParameterType);
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSONString = clsJSON.GetJsonFromObjLst<{1}>({0});", x.ParaName, strTypeString);
                                            strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", strJSONString);", x.ParaName);
                                            break;
                                        case enumDataTypeAbbr.Array_31:
                                            string strParameterType = x.ParameterType.Replace("[", "<")
                                                        .Replace("]", ">");
                                            strTypeString = clsDataTypeAbbrBLEx.GetTypeNameByArrayType(strParameterType);
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSONString = string.Join(\",\",{0});", x.ParaName, strTypeString);
                                            strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", strJSONString);", x.ParaName);
                                            break;

                                        default:
                                            if (objDataTypeAbbrEN.IsNeedQuote == false)
                                            {
                                                strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0}.ToString());", x.ParaName);
                                            }
                                            else
                                            {
                                                strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0});", x.ParaName);
                                            }
                                            break;
                                    }

                                });
                            }
                            //strCodeForCs.Append("\r\n };");
                            strCodeForCs.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
                            //if (IsNumberType4Key == true)
                            //{
                            //    strCodeForCs.AppendFormat("\r\n" + " if ({0} <= 0)",
                            //            objKeyField.FldName);
                            //}
                            //else
                            //{
                            //    strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty({0}) == true)",
                            //          objKeyField.FldName);
                            //}
                            //strCodeForCs.Append("\r\n" + " {");
                            //strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"判断表中是否存在给定关键字的记录时，关键字不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
                            //strCodeForCs.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

                            //strCodeForCs.Append("\r\n" + " }");
                            strCodeForCs.Append("\r\n try");
                            strCodeForCs.Append("\r\n {");
                            string strParaList05 = "";
                            if (arrvFuncParaRela != null)
                            {
                                IEnumerable<string> arrParaList05 = arrvFuncParaRela.Select(x => x.ParaName);
                                strParaList05 = string.Join(",", arrParaList05);
                            }
                            if (objFunction4Code.ReturnTypeId == enumDataTypeAbbr.void_27)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0}.{1}({2});",
                                     strClassName_Prev, objFunction4Code.FuncName4Code, strParaList05);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "var varResult = {0}.{1}({2});",
                                        strClassName_Prev, objFunction4Code.FuncName4Code, strParaList05);
                            }
                            switch (objFunction4Code.ReturnTypeId)
                            {
                                case enumDataTypeAbbr.void_27:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnStr = \"true\" }});");

                                    break;
                                case enumDataTypeAbbr.bit_03:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnBool = varResult }});");

                                    break;
                                case enumDataTypeAbbr.int_09:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnInt = varResult }});");

                                    break;
                                case enumDataTypeAbbr.char_04:
                                case enumDataTypeAbbr.varchar_25:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnStr = varResult }});");

                                    break;
                                case enumDataTypeAbbr.Array_31:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnStrLst = string.Join(\",\", varResult) }});");

                                    break;
                                case enumDataTypeAbbr.Object_29:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnObj = varResult }});");

                                    break;
                                case enumDataTypeAbbr.ObjectLst_30:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnObjLst = varResult }});");

                                    break;
                                default:
                                    strMsg = string.Format("返回类型:{0}在函数中没有被处理！(In {1})",
                                  strReturnType, clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                            //strCodeForCs.Append("\r\n" + "return varResult;");
                            strCodeForCs.Append("\r\n }");
                            strCodeForCs.Append("\r\n catch (Exception objException)");
                            strCodeForCs.Append("\r\n {");
                            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
                            //strCodeForCs.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

                            //strCodeForCs.AppendFormat("\r\n" + "return {0};", strInitValue);
                           
                            strCodeForCs.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");

                            strCodeForCs.Append("\r\n }");
                            strCodeForCs.Append("\r\n" + "}");
                            return strCodeForCs.ToString();
                        case enumCodeType.WA_AccessEx_0186://WA_访问扩展层(0186)(CSharp)
                            string strParaList02 = "";
                            if (arrvFuncParaRela != null)
                            {
                                //string strParaType = clsFuncPara4CodeBLEx.GetParaTypeName(objProgLangType.ProgLangTypeId);
                                IEnumerable<string> arrParaList02 = arrvFuncParaRela.Select(x => string.Format("{0} {1}", x.GetParaTypeName4Rela(objCodeType.ProgLangTypeId), x.ParaName));
                                strParaList02 = string.Join(",", arrParaList02);
                            }
                            strCodeForCs.Append("\r\n /// <summary>");
                            strCodeForCs.AppendFormat("\r\n /// {0}", objFunction4Code.FuncCHName4Code);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n /// </summary>");
                            if (arrvFuncParaRela != null)
                            {
                                arrvFuncParaRela.ForEach(x =>
                                {
                                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>", x.ParaName, x.ParaCnName);
                                });
                            }
                            strCodeForCs.Append("\r\n /// <returns>返回对象列表</returns>");
                            strCodeForCs.AppendFormat("\r\npublic static {0} {1}({2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList02);
                            strCodeForCs.Append("\r\n{");

                            //strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst = null; ",
                            //objPrjTabENEx.TabName);
                            strCodeForCs.AppendFormat("\r\n" + "string strAction = \"{0}\";",
                                objFunction4Code.FuncName4Code);
                            strCodeForCs.Append("\r\n" + "string strErrMsg = string.Empty;");
                            strCodeForCs.Append("\r\n" + "string strResult = \"\";");
                            if (arrvFuncParaRela == null || arrvFuncParaRela.Count == 0)
                            {
                                strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");

                                strCodeForCs.Append("\r\n" + "{");
                                if (arrvFuncParaRela != null)
                                {
                                    arrvFuncParaRela.ForEach(x =>
                                    {
                                        clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(x.DataTypeId);
                                        if (objDataTypeAbbrEN.IsNeedQuote == false)
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString(),", x.ParaName);
                                        }
                                        else if (objDataTypeAbbrEN.DataTypeId == enumDataTypeAbbr.bit_03)
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString(),", x.ParaName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0},", x.ParaName);
                                        }
                                    });
                                }
                                strCodeForCs.Append("\r\n" + "};");
                            }


                            strCodeForCs.Append("\r\n" + "try");
                            strCodeForCs.Append("\r\n" + "{");
                            if (string.IsNullOrEmpty(objFunction4Code.FuncAccessModeId) == true)
                            {
                                strMsg = string.Format("函数:[{0}]({1}({2}))操作模式为空！出错(In {3})",
                                    objFunction4Code.FuncName4Code, objCodeType.CodeTypeName, objFunction4Code.CodeTypeId, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }
                            switch (objFunction4Code.FuncAccessModeId)
                            {
                                case enumFuncAccessMode.Get_01:
                                    strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)");

                                    break;
                                case enumFuncAccessMode.Post_02:
                                    switch (arrvFuncParaRela[0].DataTypeId)
                                    {
                                        case enumDataTypeAbbr.ObjectLst_30:
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst({0});", arrvFuncParaRela[0].ParaName);
                                            break;
                                        case enumDataTypeAbbr.Object_29:
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObj<{1}>({0});",
                                                arrvFuncParaRela[0].ParaName, arrvFuncParaRela[0].ParameterType);

                                            break;
                                        default:
                                            clsDataTypeAbbrEN objDataTypeAbbr1 = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(arrvFuncParaRela[0].DataTypeId);
                                            string strParaType = objDataTypeAbbr1.GetTypeString(objCodeType.ProgLangTypeId);
                                            strMsg = string.Format("参数类型:{0}在函数中没有被处理！(In {1})",
                                                strParaType, clsStackTrace.GetCurrClassFunction());
                                            throw new Exception(strMsg);
                                            //break;
                                    }
                                    strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)");
                                    break;
                                case enumFuncAccessMode.Put_03:
                                    break;
                                case enumFuncAccessMode.Delete_04:
                                    strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, id.ToString(), out strResult, out strErrMsg) == true)");

                                    break;
                                default:

                                    break;
                            }
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "JObject jobjReturn = JObject.Parse(strResult);");
                            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn[\"errorId\"] == 0)");
                            strCodeForCs.Append("\r\n" + "{");
                            //strCodeForCs.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>((string)jobjReturn[\"returnObjLst\"]);",
                            //    objPrjTabENEx.TabName);
                            //strCodeForCs.Append("\r\n" + "return arrObjLst;");


                            switch (objFunction4Code.ReturnTypeId)
                            {
                                case enumDataTypeAbbr.ObjectLst_30:
                                    string strObjType = clsDataTypeAbbrBLEx.GetTypeNameByArrayType(strReturnType);
                                    strCodeForCs.AppendFormat("\r\n" + "var varResult = clsJSON.GetObjLstFromJson<{0}>((string)jobjReturn[\"returnObjLst\"]);",
                                         strObjType);
                                    break;
                                case enumDataTypeAbbr.Object_29:
                                    strCodeForCs.AppendFormat("\r\n" + "var varResult = clsJSON.GetObjFromJson<{0}>((string)jobjReturn[\"returnObj\"]);", strReturnType);

                                    break;
                                case enumDataTypeAbbr.varchar_25:
                                case enumDataTypeAbbr.char_04:
                                    strCodeForCs.AppendFormat("\r\n" + "var varResult = (string)jobjReturn[\"returnStr\"];", strReturnType);
                                    break;
                                case enumDataTypeAbbr.bit_03:

                                    strCodeForCs.Append("\r\n" + "var varResult = (bool)jobjReturn[\"returnBool\"];");
                                    break;
                                case enumDataTypeAbbr.int_09:

                                    strCodeForCs.Append("\r\n" + "var varResult = (int)jobjReturn[\"returnInt\"];");
                                    break;
                                case enumDataTypeAbbr.bigint_01:
                                    strCodeForCs.Append("\r\n" + "var varResult = (long)jobjReturn[\"returnLong\"];");
                                    break;
                                case enumDataTypeAbbr.numeric_14:
                                case enumDataTypeAbbr.money_11:
                                case enumDataTypeAbbr.decimal_06:
                                    strCodeForCs.AppendFormat("\r\n" + "var varResult = {0}.Parse(jobjReturn[\"returnLong\"].ToString()));", strReturnType);
                                    break;

                                default:

                                    strMsg = string.Format("返回类型:{0}在函数中没有被处理！(In {1})",
                                        strReturnType, clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }

                            strCodeForCs.Append("\r\n" + "return varResult;");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn[\"ErrorMsg\"]);");
                            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else return {0};", strInitValue);


                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"{0}出错,{{0}}.(from {{1}})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());",
                                objFunction4Code.FuncCHName4Code);
                            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                            strCodeForCs.Append("\r\n" + "}");



                            //strCodeForCs.Append("\r\nreturn arrObjLst;");
                            strCodeForCs.Append("\r\n}");
                            //获取某一条件值的记录集 == = ;
                            return strCodeForCs.ToString();

                        default:

                            strMsg = string.Format("代码类型:{0}({1})({2})在函数中没有被处理！(In {3})",
                                objCodeType.CodeTypeName, objFunction4Code.CodeTypeId, objProgLangType.ProgLangTypeName, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }
                //break;
                case enumProgLangType.TypeScript_09:
                    switch (objCodeType.CodeTypeId)
                    {
                        case enumCodeType.WA_Access_0155:
                        case enumCodeType.WA_AccessEx_0190:
                            strCodeForCs.Append("\r\n /**");
                            strCodeForCs.AppendFormat("\r\n * {0}", objFunction4Code.FuncCHName4Code);
                            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                            if (arrvFuncParaRela != null)
                            {
                                arrvFuncParaRela.ForEach(x =>
                                {
                                    strCodeForCs.AppendFormat("\r\n * @param {0}: {1}", x.ParaName, x.ParaCnName);
                                });
                            }
                            strCodeForCs.Append("\r\n * @returns 获取的相应对象列表");
                            strCodeForCs.Append("\r\n */");
                            string strParaList06 = "";
                            if (arrvFuncParaRela != null)
                            {
                                IEnumerable<string> arrParaList06 = arrvFuncParaRela.Select(x => string.Format("{0}: {1}", x.ParaName, x.GetParaTypeName4Rela(objCodeType.ProgLangTypeId)));
                                strParaList06 = string.Join(",", arrParaList06);
                                strParaList06 = strParaList06.Replace("List", "Array");
                            }
                            strCodeForCs.AppendFormat("\r\n" + "public static {0}({1}): Promise<{2}>  ",
                              objFunction4Code.FuncName4Code,
                              strParaList06,
                              strReturnType.Replace("[", "<")
                                    .Replace("]", ">")
                                    .Replace("List", "Array"));
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "var strAction = \"{0}\";",
                              objFunction4Code.FuncName4Code);
                            strCodeForCs.Append("\r\n" + "let strUrl = this.GetWebApiUrl(this.mstrController, strAction);");

                            strCodeForCs.Append("\r\n" + "var mapParam: Dictionary = new Dictionary();");
                            string strFirstParaName = "";
                            string strParaType = "";
                            if (arrvFuncParaRela != null)
                            {
                                foreach (clsvFuncParaRelaEN objInFor in arrvFuncParaRela)
                                {
                                    if (string.IsNullOrEmpty(strFirstParaName))
                                    {
                                        strFirstParaName = objInFor.ParaName;
                                        strParaType = objInFor.DataTypeId;
                                    }
                                    strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"{0}\", {0});", objInFor.ParaName);
                                }
                            }
                            strCodeForCs.Append("\r\n" + "let strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");

                            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
                            strCodeForCs.Append("\r\n" + "$.ajax({");
                            strCodeForCs.Append("\r\n" + "url: strUrl,");

                            switch (objFunction4Code.FuncAccessModeId)
                            {
                                case enumFuncAccessMode.Post_02:
                               
                                    strCodeForCs.AppendFormat("\r\n" + "type: \"{0}\",", clsFuncAccessModeBL.GetNameByFuncAccessModeIdCache(objFunction4Code.FuncAccessModeId));
                                    strCodeForCs.Append("\r\n" + "contentType: \"application/json; charset=utf-8\",");
                                    if (strParaType == enumDataTypeAbbr.Array_31)
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "data: JSON.stringify({0}),", strFirstParaName);

                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "data: JSON.stringify({0}),", strFirstParaName);

                                    }
                                    break;
                                case enumFuncAccessMode.Delete_04:
                                    strCodeForCs.AppendFormat("\r\n" + "type: \"{0}\",", clsFuncAccessModeBL.GetNameByFuncAccessModeIdCache(objFunction4Code.FuncAccessModeId));
                                    strCodeForCs.Append("\r\n" + "contentType: \"application/json; charset=utf-8\",");
                                    //strCodeForCs.AppendFormat("\r\n" + "data: {{ \"\": {0} }},", strFirstParaName);
                                    break;
                                default:
                                    strCodeForCs.AppendFormat("\r\n" + "method: \"{0}\",", clsFuncAccessModeBL.GetNameByFuncAccessModeIdCache(objFunction4Code.FuncAccessModeId));
                                    strCodeForCs.Append("\r\n" + "dataType: \"json\",");
                                    strCodeForCs.Append("\r\n" + "data: strData,");
                                    break;
                            }
                            strCodeForCs.Append("\r\n" + "success: function(data) {");

                            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
                            strCodeForCs.Append("\r\n" + "{");
                            switch (objFunction4Code.ReturnTypeId)
                            {
                                case enumDataTypeAbbr.void_27:
                                    strCodeForCs.Append("\r\n" + "resolve(data.returnStr);");
                                    break;
                                case enumDataTypeAbbr.Array_31:

                                    strCodeForCs.Append("\r\n" + "var returnStrLst = data.returnStrLst.split(',');");
                                    strCodeForCs.Append("\r\n" + "//console.log(\"returnStrLst\", returnStrLst);");
                                    strCodeForCs.Append("\r\n" + "resolve(returnStrLst);");
                                    break;
                                case enumDataTypeAbbr.ObjectLst_30:

                                    strCodeForCs.Append("\r\n" + "var returnObjLst = data.returnObjLst;");
                                    strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
                                    strCodeForCs.Append("\r\n" + "resolve(returnObjLst);");
                                    break;
                                case enumDataTypeAbbr.Object_29:
                                    strCodeForCs.Append("\r\n" + "var returnObj = data.returnObj;");
                                    strCodeForCs.Append("\r\n" + "//console.log(returnObj);");
                                    strCodeForCs.Append("\r\n" + "resolve(returnObj);");
                                    break;
                                case enumDataTypeAbbr.varchar_25:
                                case enumDataTypeAbbr.char_04:
                                    strCodeForCs.Append("\r\n" + "resolve(data.returnStr);");

                                    break;
                                case enumDataTypeAbbr.bit_03:

                                    strCodeForCs.Append("\r\n" + "resolve(data.returnBool);");

                                    break;
                                case enumDataTypeAbbr.int_09:

                                    strCodeForCs.Append("\r\n" + "resolve(data.returnInt);");

                                    break;
                                case enumDataTypeAbbr.bigint_01:
                                    strCodeForCs.Append("\r\n" + "resolve(data.returnLong);");

                                    break;
                                case enumDataTypeAbbr.numeric_14:
                                case enumDataTypeAbbr.money_11:
                                case enumDataTypeAbbr.decimal_06:

                                    strCodeForCs.Append("\r\n" + "resolve(data.returnLong);");
                                    break;

                                default:

                                    strMsg = string.Format("返回类型:{0}在函数中没有被处理！(In {1})",
                                        strReturnType, clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }

                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
                            strCodeForCs.Append("\r\n" + "reject(data.errorMsg);");
                            strCodeForCs.Append("\r\n" + "}");

                            //error: function(result) {
                            //        console.error(result);
                            //        console.error(JSON.stringify(result));
                            //        if (result.statusText == "error")
                            //        {
                            //            var strInfo = `网络错误！访问地址:${ strUrl}
                            //            不成功！`;
                            //            reject(strInfo);
                            //        }
                            //        else
                            //        {
                            //            reject(result.statusText);
                            //        }
                            //    }


                            strCodeForCs.Append("\r\n" + "},");
                            strCodeForCs.Append("\r\n" + "error: function(result) {");
                            strCodeForCs.Append("\r\n" + "console.error(result);");
                            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
                            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "var strInfo = `网络错误！访问地址:${ strUrl} 不成功！`;");
                            strCodeForCs.Append("\r\n" + "reject(strInfo);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "});");
                            strCodeForCs.Append("\r\n" + "});");

                            strCodeForCs.Append("\r\n" + "};");

                            return strCodeForCs.ToString();

                        default:

                            strMsg = string.Format("代码类型:{0}({1})({2})在函数中没有被处理！(In {3})",
                                objCodeType.CodeTypeName, objFunction4Code.CodeTypeId, objProgLangType.ProgLangTypeName, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }
                //break;
                default:

                    strMsg = string.Format("语言类型:{0}在函数中没有被处理！(In {1})",
                         objProgLangType.ProgLangTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
            //return strCodeForCs.ToString();
        }
        public static string GeneCodeV2Bake0230719(string strWorkFlowId, string strFuncId4Code, string strCodeTypeId)
        {
            string strMsg = "";
            clsFunction4CodeEN objFunction4Code = clsFunction4CodeBL.GetObjByFuncId4CodeCache(strFuncId4Code);
            var strTabName_FstLcase = clsString.FstLcaseS(objFunction4Code.TabName);
            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeType.ProgLangTypeId);

            clsDataTypeAbbrEN objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFunction4Code.ReturnTypeId);
            string strReturnType = objFunction4Code.ReturnTypeNameCustom;
            if (string.IsNullOrEmpty(strReturnType) == true)
            {

                strReturnType = objDataTypeAbbr.GetTypeString(objCodeType.ProgLangTypeId);
            }
            strReturnType = strReturnType.Replace("[", "<")
                                  .Replace("]", ">");

            string strInitValue = objDataTypeAbbr.GetInitValue4Var(objCodeType.ProgLangTypeId);

            clswf_PointEN objPoint = clswf_PointBLEx.GetObjByTabKeyIdCache(conCodeType._CurrTabName, strCodeTypeId);
            if (objPoint == null)
            {
                strMsg = string.Format("表名:{0}，关键字:{1} 没有相关端点，请检查！(In {2})",
                                                           conCodeType._CurrTabName, objCodeType.CodeTypeId, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            string strPointId = objPoint.PointId;

            List<string> arrPrevPointId = clswf_StepProcessRelaBLEx.GetPrevPointLstCache(strWorkFlowId, strPointId).ToList();
            //clsFunction4CodeEN objFunction4Code_Prev = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objFunction4Code.PrevFuncId);
            if (arrPrevPointId.Count == 0)
            {
                strMsg = string.Format("代码类型:{0}({1})没有前置代码类型，请检查！(In {2})",
                                                            objCodeType.CodeTypeName, objCodeType.CodeTypeId, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            clswf_PointEN objPoint_Prev = clswf_PointBLEx.GetObjByPointIdCache(arrPrevPointId[0]);
            //if (objPoint_Prev == null)
            //{
            //    strMsg = string.Format("表名:{0}，关键字:{1} 没有相关端点，请检查！(In {2})",
            //                                               conCodeType._CurrTabName, arrPrevPointId[0], clsStackTrace.GetCurrClassFunction());
            //    throw new Exception(strMsg);
            //}
            clsCodeTypeEN objCodeType_Prev = clsCodeTypeBL.GetObjByCodeTypeIdCache(objPoint_Prev.TabKeyId);
            string strClassName_Prev = string.Format(objCodeType_Prev.ClassNameFormat, objFunction4Code.TabName);
            List<clsvFuncParaRelaEN> arrvFuncParaRela = clsvFuncParaRelaBLEx.GetObjListByFuncId4CodeCacheEx(strFuncId4Code);

            StringBuilder strCodeForCs = new StringBuilder();
            switch (objProgLangType.ProgLangTypeId)
            {
                case enumProgLangType.CSharp_01:
                    switch (objCodeType.CodeTypeId)
                    {
                        case enumCodeType.WA_SrvEx_0185://WA_服务扩展层(CSharp)
                        case enumCodeType.WA_Srv_0044:

                            //clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

                            strCodeForCs.Append("\r\n /// <summary>");
                            strCodeForCs.AppendFormat("\r\n /// {0}", objFunction4Code.FuncCHName4Code);
                            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(strFuncId4Code);
                            switch (objFunction4Code.FuncAccessModeId)
                            {
                                case enumFuncAccessMode.Get_01:
                                    string strParaList = "";
                                    if (arrvFuncParaRela != null)
                                    {
                                        IEnumerable<string> arrParaList = arrvFuncParaRela.Select(x => string.Format("{0}=value", x.ParaName));
                                        strParaList = string.Join("&", arrParaList);
                                    }

                                    strCodeForCs.AppendFormat("\r\n /// 调用方法: {0} /api/{1}Api/{2}?{3}",
                                      clsFuncAccessModeBL.GetNameByFuncAccessModeIdCache(objFunction4Code.FuncAccessModeId),
                                      objFunction4Code.ClsName,
                                        objFunction4Code.FuncName4Code,
                                      strParaList);
                                    break;
                            }
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n /// </summary>");
                            if (arrvFuncParaRela != null)
                            {

                                arrvFuncParaRela.ForEach(x =>
                                {
                                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>", x.ParaName, x.ParaCnName);
                                });
                            }
                            strCodeForCs.Append("\r\n /// <returns>返回是否存在?</returns>");
                            string strParaList01 = "";
                            if (arrvFuncParaRela != null)
                            {
                                IEnumerable<string> arrParaList01 = arrvFuncParaRela
                                    .Select(x => string.Format("{0} {1}", x.GetParaTypeName4Rela(objCodeType.ProgLangTypeId), x.ParaName));
                                strParaList01 = string.Join(",", arrParaList01);
                            }

                            switch (objFunction4Code.FuncAccessModeId)
                            {
                                case enumFuncAccessMode.Get_01:

                                    strCodeForCs.AppendFormat("\r\n" + "[HttpGet(\"{0}\")]", objFunction4Code.FuncName4Code);
                                    strCodeForCs.AppendFormat("\r\n" + "public ActionResult {1}({2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList01);
                                    break;
                                case enumFuncAccessMode.Post_02:
                                    strCodeForCs.AppendFormat("\r\n" + "[HttpPost(\"{0}\")]", objFunction4Code.FuncName4Code);
                                    strCodeForCs.AppendFormat("\r\n" + "public ActionResult {1}([FromBody]{2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList01);
                                    break;
                                case enumFuncAccessMode.Put_03:
                                    strCodeForCs.AppendFormat("\r\n" + "[HttpPut(\"{0}\")]", objFunction4Code.FuncName4Code);
                                    strCodeForCs.AppendFormat("\r\n" + "public ActionResult {1}([FromBody]{2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList01);

                                    break;
                                case enumFuncAccessMode.Delete_04:
                                    strCodeForCs.AppendFormat("\r\n" + "[HttpDelete(\"{0}\")]", objFunction4Code.FuncName4Code);
                                    strCodeForCs.AppendFormat("\r\n" + "public ActionResult {1}({2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList01);

                                    break;
                            }

                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
                            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");
                            //strCodeForCs.Append("\r\n" + "{");
                            if (arrvFuncParaRela != null)
                            {
                                arrvFuncParaRela.ForEach(x =>
                                {
                                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(x.DataTypeId);
                                    string strTypeString = "";
                                    switch (x.DataTypeId)
                                    {
                                        case enumDataTypeAbbr.bit_03:
                                            strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0}.ToString());", x.ParaName);
                                            break;
                                        case enumDataTypeAbbr.Object_29:
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSONString = clsJSON.GetJsonFromObj({0});", x.ParaName);
                                            strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", strJSONString);", x.ParaName);
                                            break;
                                        case enumDataTypeAbbr.ObjectLst_30:
                                            strTypeString = clsDataTypeAbbrBLEx.GetTypeNameByArrayType(x.ParameterType);
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSONString = clsJSON.GetJsonFromObjLst<{1}>({0});", x.ParaName, strTypeString);
                                            strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", strJSONString);", x.ParaName);
                                            break;
                                        case enumDataTypeAbbr.Array_31:
                                            string strParameterType = x.ParameterType.Replace("[", "<")
                                                        .Replace("]", ">");
                                            strTypeString = clsDataTypeAbbrBLEx.GetTypeNameByArrayType(strParameterType);
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSONString = string.Join(\",\",{0});", x.ParaName, strTypeString);
                                            strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", strJSONString);", x.ParaName);
                                            break;

                                        default:
                                            if (objDataTypeAbbrEN.IsNeedQuote == false)
                                            {
                                                strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0}.ToString());", x.ParaName);
                                            }
                                            else
                                            {
                                                strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0});", x.ParaName);
                                            }
                                            break;
                                    }

                                });
                            }
                            //strCodeForCs.Append("\r\n };");
                            strCodeForCs.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
                            //if (IsNumberType4Key == true)
                            //{
                            //    strCodeForCs.AppendFormat("\r\n" + " if ({0} <= 0)",
                            //            objKeyField.FldName);
                            //}
                            //else
                            //{
                            //    strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty({0}) == true)",
                            //          objKeyField.FldName);
                            //}
                            //strCodeForCs.Append("\r\n" + " {");
                            //strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"判断表中是否存在给定关键字的记录时，关键字不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
                            //strCodeForCs.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

                            //strCodeForCs.Append("\r\n" + " }");
                            strCodeForCs.Append("\r\n try");
                            strCodeForCs.Append("\r\n {");
                            string strParaList05 = "";
                            if (arrvFuncParaRela != null)
                            {
                                IEnumerable<string> arrParaList05 = arrvFuncParaRela.Select(x => x.ParaName);
                                strParaList05 = string.Join(",", arrParaList05);
                            }
                            if (objFunction4Code.ReturnTypeId == enumDataTypeAbbr.void_27)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0}.{1}({2});",
                                     strClassName_Prev, objFunction4Code.FuncName4Code, strParaList05);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "var varResult = {0}.{1}({2});",
                                        strClassName_Prev, objFunction4Code.FuncName4Code, strParaList05);
                            }
                            switch (objFunction4Code.ReturnTypeId)
                            {
                                case enumDataTypeAbbr.void_27:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnStr = \"true\" }});");

                                    break;
                                case enumDataTypeAbbr.bit_03:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnBool = varResult }});");

                                    break;
                                case enumDataTypeAbbr.int_09:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnInt = varResult }});");

                                    break;
                                case enumDataTypeAbbr.char_04:
                                case enumDataTypeAbbr.varchar_25:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnStr = varResult }});");

                                    break;
                                case enumDataTypeAbbr.Array_31:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnStrLst = string.Join(\",\", varResult) }});");

                                    break;
                                case enumDataTypeAbbr.Object_29:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnObj = varResult }});");

                                    break;
                                case enumDataTypeAbbr.ObjectLst_30:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnObjLst = varResult }});");

                                    break;
                                default:
                                    strMsg = string.Format("返回类型:{0}在函数中没有被处理！(In {1})",
                                  strReturnType, clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                            //strCodeForCs.Append("\r\n" + "return varResult;");
                            strCodeForCs.Append("\r\n }");
                            strCodeForCs.Append("\r\n catch (Exception objException)");
                            strCodeForCs.Append("\r\n {");
                            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
                            //strCodeForCs.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

                            //strCodeForCs.AppendFormat("\r\n" + "return {0};", strInitValue);

                            strCodeForCs.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");

                            strCodeForCs.Append("\r\n }");
                            strCodeForCs.Append("\r\n" + "}");
                            return strCodeForCs.ToString();
                        case enumCodeType.WA_AccessEx_0186://WA_访问扩展层(0186)(CSharp)
                            string strParaList02 = "";
                            if (arrvFuncParaRela != null)
                            {
                                //string strParaType = clsFuncPara4CodeBLEx.GetParaTypeName(objProgLangType.ProgLangTypeId);
                                IEnumerable<string> arrParaList02 = arrvFuncParaRela.Select(x => string.Format("{0} {1}", x.GetParaTypeName4Rela(objCodeType.ProgLangTypeId), x.ParaName));
                                strParaList02 = string.Join(",", arrParaList02);
                            }
                            strCodeForCs.Append("\r\n /// <summary>");
                            strCodeForCs.AppendFormat("\r\n /// {0}", objFunction4Code.FuncCHName4Code);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n /// </summary>");
                            if (arrvFuncParaRela != null)
                            {
                                arrvFuncParaRela.ForEach(x =>
                                {
                                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>", x.ParaName, x.ParaCnName);
                                });
                            }
                            strCodeForCs.Append("\r\n /// <returns>返回对象列表</returns>");
                            strCodeForCs.AppendFormat("\r\n public static {0} {1}({2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList02);
                            strCodeForCs.Append("\r\n{");

                            //strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst = null; ",
                            //objPrjTabENEx.TabName);
                            strCodeForCs.AppendFormat("\r\n" + "string strAction = \"{0}\";",
                                objFunction4Code.FuncName4Code);
                            strCodeForCs.Append("\r\n" + "string strErrMsg = string.Empty;");
                            strCodeForCs.Append("\r\n" + "string strResult = \"\";");
                            if (arrvFuncParaRela == null || arrvFuncParaRela.Count == 0)
                            {
                                strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");

                                strCodeForCs.Append("\r\n" + "{");
                                if (arrvFuncParaRela != null)
                                {
                                    arrvFuncParaRela.ForEach(x =>
                                    {
                                        clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(x.DataTypeId);
                                        if (objDataTypeAbbrEN.IsNeedQuote == false)
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString(),", x.ParaName);
                                        }
                                        else if (objDataTypeAbbrEN.DataTypeId == enumDataTypeAbbr.bit_03)
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString(),", x.ParaName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0},", x.ParaName);
                                        }
                                    });
                                }
                                strCodeForCs.Append("\r\n" + "};");
                            }


                            strCodeForCs.Append("\r\n" + "try");
                            strCodeForCs.Append("\r\n" + "{");
                            if (string.IsNullOrEmpty(objFunction4Code.FuncAccessModeId) == true)
                            {
                                strMsg = string.Format("函数:[{0}]({1}({2}))操作模式为空！出错(In {3})",
                                    objFunction4Code.FuncName4Code, objCodeType.CodeTypeName, objFunction4Code.CodeTypeId, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }
                            switch (objFunction4Code.FuncAccessModeId)
                            {
                                case enumFuncAccessMode.Get_01:
                                    strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)");

                                    break;
                                case enumFuncAccessMode.Post_02:
                                    switch (arrvFuncParaRela[0].DataTypeId)
                                    {
                                        case enumDataTypeAbbr.ObjectLst_30:
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst({0});", arrvFuncParaRela[0].ParaName);
                                            break;
                                        case enumDataTypeAbbr.Object_29:
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObj<{1}>({0});",
                                                arrvFuncParaRela[0].ParaName, arrvFuncParaRela[0].ParameterType);

                                            break;
                                        default:
                                            clsDataTypeAbbrEN objDataTypeAbbr1 = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(arrvFuncParaRela[0].DataTypeId);
                                            string strParaType = objDataTypeAbbr1.GetTypeString(objCodeType.ProgLangTypeId);
                                            strMsg = string.Format("参数类型:{0}在函数中没有被处理！(In {1})",
                                                strParaType, clsStackTrace.GetCurrClassFunction());
                                            throw new Exception(strMsg);
                                            //break;
                                    }
                                    strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)");
                                    break;
                                case enumFuncAccessMode.Put_03:
                                    break;
                                case enumFuncAccessMode.Delete_04:
                                    strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, id.ToString(), out strResult, out strErrMsg) == true)");

                                    break;
                                default:

                                    break;
                            }
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "JObject jobjReturn = JObject.Parse(strResult);");
                            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn[\"errorId\"] == 0)");
                            strCodeForCs.Append("\r\n" + "{");
                            //strCodeForCs.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>((string)jobjReturn[\"returnObjLst\"]);",
                            //    objPrjTabENEx.TabName);
                            //strCodeForCs.Append("\r\n" + "return arrObjLst;");


                            switch (objFunction4Code.ReturnTypeId)
                            {
                                case enumDataTypeAbbr.ObjectLst_30:
                                    string strObjType = clsDataTypeAbbrBLEx.GetTypeNameByArrayType(strReturnType);
                                    strCodeForCs.AppendFormat("\r\n" + "var varResult = clsJSON.GetObjLstFromJson<{0}>((string)jobjReturn[\"returnObjLst\"]);",
                                         strObjType);
                                    break;
                                case enumDataTypeAbbr.Object_29:
                                    strCodeForCs.AppendFormat("\r\n" + "var varResult = clsJSON.GetObjFromJson<{0}>((string)jobjReturn[\"returnObj\"]);", strReturnType);

                                    break;
                                case enumDataTypeAbbr.varchar_25:
                                case enumDataTypeAbbr.char_04:
                                    strCodeForCs.AppendFormat("\r\n" + "var varResult = (string)jobjReturn[\"returnStr\"];", strReturnType);
                                    break;
                                case enumDataTypeAbbr.bit_03:

                                    strCodeForCs.Append("\r\n" + "var varResult = (bool)jobjReturn[\"returnBool\"];");
                                    break;
                                case enumDataTypeAbbr.int_09:

                                    strCodeForCs.Append("\r\n" + "var varResult = (int)jobjReturn[\"returnInt\"];");
                                    break;
                                case enumDataTypeAbbr.bigint_01:
                                    strCodeForCs.Append("\r\n" + "var varResult = (long)jobjReturn[\"returnLong\"];");
                                    break;
                                case enumDataTypeAbbr.numeric_14:
                                case enumDataTypeAbbr.money_11:
                                case enumDataTypeAbbr.decimal_06:
                                    strCodeForCs.AppendFormat("\r\n" + "var varResult = {0}.Parse(jobjReturn[\"returnLong\"].ToString()));", strReturnType);
                                    break;

                                default:

                                    strMsg = string.Format("返回类型:{0}在函数中没有被处理！(In {1})",
                                        strReturnType, clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }

                            strCodeForCs.Append("\r\n" + "return varResult;");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn[\"ErrorMsg\"]);");
                            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else return {0};", strInitValue);


                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"{0}出错,{{0}}.(from {{1}})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());",
                                objFunction4Code.FuncCHName4Code);
                            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                            strCodeForCs.Append("\r\n" + "}");



                            //strCodeForCs.Append("\r\nreturn arrObjLst;");
                            strCodeForCs.Append("\r\n}");
                            //获取某一条件值的记录集 == = ;
                            return strCodeForCs.ToString();

                        default:

                            strMsg = string.Format("代码类型:{0}({1})({2})在函数中没有被处理！(In {3})",
                                objCodeType.CodeTypeName, objFunction4Code.CodeTypeId, objProgLangType.ProgLangTypeName, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }
                //break;
                case enumProgLangType.TypeScript_09:
                    switch (objCodeType.CodeTypeId)
                    {
                        case enumCodeType.WA_Access_0155:
                        case enumCodeType.WA_AccessEx_0190:
                            strCodeForCs.Append("\r\n /**");
                            strCodeForCs.AppendFormat("\r\n * {0}", objFunction4Code.FuncCHName4Code);
                            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                            if (arrvFuncParaRela != null)
                            {
                                arrvFuncParaRela.ForEach(x =>
                                {
                                    strCodeForCs.AppendFormat("\r\n * @param {0}: {1}", x.ParaName, x.ParaCnName);
                                });
                            }
                            strCodeForCs.Append("\r\n * @returns 获取的相应对象列表");
                            strCodeForCs.Append("\r\n */");
                            string strParaList06 = "";
                            if (arrvFuncParaRela != null)
                            {
                                IEnumerable<string> arrParaList06 = arrvFuncParaRela.Select(x => string.Format("{0}: {1}", x.ParaName, x.GetParaTypeName4Rela(objCodeType.ProgLangTypeId)));
                                strParaList06 = string.Join(",", arrParaList06);
                                strParaList06 = strParaList06.Replace("List", "Array");
                            }
                            strCodeForCs.AppendFormat("\r\n" + " export async function {3}Ex_{0}({1}): Promise<{2}>  ",
                              objFunction4Code.FuncName4Code,
                              strParaList06,
                              strReturnType.Replace("[", "<")
                                    .Replace("]", ">")
                                    .Replace("List", "Array"), objFunction4Code.TabName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = {0}Ex_{1}.name;",
                                objFunction4Code.TabName, objFunction4Code.FuncName4Code);
                            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"{0}\";",
                              objFunction4Code.FuncName4Code);
                            strCodeForCs.AppendFormat("\r\n" + "const strUrl = {0}Ex_GetWebApiUrl({1}Ex_Controller, strAction);", objFunction4Code.TabName, strTabName_FstLcase);

                            //strCodeForCs.Append("\r\n" + "var mapParam: Dictionary = new Dictionary();");
                            string strFirstParaName = "";
                            string strParaType = "";
                            //if (arrvFuncParaRela != null)
                            //{
                            foreach (clsvFuncParaRelaEN objInFor in arrvFuncParaRela)
                            {
                                if (string.IsNullOrEmpty(strFirstParaName))
                                {
                                    strFirstParaName = objInFor.ParaName;
                                    strParaType = objInFor.DataTypeId;
                                }
                                //strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"{0}\", {0});", objInFor.ParaName);
                            }
                            //}
                            //strCodeForCs.Append("\r\n" + "let strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");

                            strCodeForCs.Append("\r\n" + "try");
                            strCodeForCs.Append("\r\n" + "{");
                            switch (objFunction4Code.FuncAccessModeId)
                            {
                                case enumFuncAccessMode.Post_02:
                                    strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl,{0});", strFirstParaName);

                                    break;
                                case enumFuncAccessMode.Delete_04:
                                    strCodeForCs.AppendFormat("\r\n" + "const response = await axios.delete(strUrl,);", strFirstParaName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "params: {{ \"Id\": {0}, }}", strFirstParaName);
                                    strCodeForCs.Append("\r\n" + "});");

                                    break;

                                case enumFuncAccessMode.Get_01:
                                    strCodeForCs.AppendFormat("\r\n" + "const response = await axios.get(strUrl,", strFirstParaName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "params: {");
                                    foreach (clsvFuncParaRelaEN objInFor in arrvFuncParaRela)
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {0},", objInFor.ParaName);
                                    }
                                    //strCodeForCs.AppendFormat("\r\n" + "params: {{ \"Id\": {0}, }}", strFirstParaName);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "});");

                                    break;
                                default:
                                    strCodeForCs.AppendFormat("\r\n" + "const response = await axios.{0}(strUrl,);", clsFuncAccessModeBL.GetNameByFuncAccessModeIdCache(objFunction4Code.FuncAccessModeId).ToLower());
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "params: {");
                                    foreach (clsvFuncParaRelaEN objInFor in arrvFuncParaRela)
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {0},", objInFor.ParaName);
                                    }
                                    //strCodeForCs.AppendFormat("\r\n" + "params: {{ \"Id\": {0}, }}", strFirstParaName);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "});");

                                    break;
                            }
                            strCodeForCs.Append("\r\n" + "const data = response.data;");

                            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
                            strCodeForCs.Append("\r\n" + "{");
                            switch (objFunction4Code.ReturnTypeId)
                            {
                                case enumDataTypeAbbr.void_27:
                                    strCodeForCs.Append("\r\n" + "return data.returnStr;");
                                    break;
                                case enumDataTypeAbbr.Array_31:

                                    strCodeForCs.Append("\r\n" + "const returnStrLst = data.returnStrLst.split(',');");
                                    strCodeForCs.Append("\r\n" + "//console.log(\"returnStrLst\", returnStrLst);");
                                    strCodeForCs.Append("\r\n" + "return returnStrLst;");
                                    break;
                                case enumDataTypeAbbr.ObjectLst_30:

                                    strCodeForCs.Append("\r\n" + "const returnObjLst = data.returnObjLst;");
                                    strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
                                    strCodeForCs.Append("\r\n" + "return returnObjLst;");
                                    break;
                                case enumDataTypeAbbr.Object_29:
                                    strCodeForCs.Append("\r\n" + "const returnObj = data.returnObj;");
                                    strCodeForCs.Append("\r\n" + "//console.log(returnObj);");
                                    strCodeForCs.Append("\r\n" + "return returnObj;");
                                    break;
                                case enumDataTypeAbbr.varchar_25:
                                case enumDataTypeAbbr.char_04:
                                    strCodeForCs.Append("\r\n" + "return data.returnStr;");

                                    break;
                                case enumDataTypeAbbr.bit_03:

                                    strCodeForCs.Append("\r\n" + "return data.returnBool;");

                                    break;
                                case enumDataTypeAbbr.int_09:

                                    strCodeForCs.Append("\r\n" + "return data.returnInt;");

                                    break;
                                case enumDataTypeAbbr.bigint_01:
                                    strCodeForCs.Append("\r\n" + "return data.returnLong;");

                                    break;
                                case enumDataTypeAbbr.numeric_14:
                                case enumDataTypeAbbr.money_11:
                                case enumDataTypeAbbr.decimal_06:

                                    strCodeForCs.Append("\r\n" + "return data.returnLong;");
                                    break;

                                default:

                                    strMsg = string.Format("返回类型:{0}在函数中没有被处理！(In {1})",
                                        strReturnType, clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }

                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
                            strCodeForCs.Append("\r\n" + "throw (data.errorMsg);");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

                            strCodeForCs.Append("\r\n" + "console.error(error);");

                            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "throw error;");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"网络错误！访问地址:{0}不成功！(in {1}.{2})\", strUrl, " + strTabName_FstLcase + "Ex_ConstructorName, strThisFuncName);");
                            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
                            strCodeForCs.Append("\r\n" + "throw(strInfo);");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"网络错误！访问地址:{0}可能不存在！(in {1}.{2})\", strUrl, " + strTabName_FstLcase + "Ex_ConstructorName, strThisFuncName);");
                            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
                            strCodeForCs.Append("\r\n" + "throw(strInfo);");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.Append("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "}");
                            return strCodeForCs.ToString();

                        default:

                            strMsg = string.Format("代码类型:{0}({1})({2})在函数中没有被处理！(In {3})",
                                objCodeType.CodeTypeName, objFunction4Code.CodeTypeId, objProgLangType.ProgLangTypeName, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }
                //break;
                default:

                    strMsg = string.Format("语言类型:{0}在函数中没有被处理！(In {1})",
                         objProgLangType.ProgLangTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
            //return strCodeForCs.ToString();
        }

        public static string GeneCodeV2(string strWorkFlowId, string strFuncId4Code, string strCodeTypeId)
        {
            string strMsg = "";
            clsFunction4CodeEN objFunction4Code = clsFunction4CodeBL.GetObjByFuncId4CodeCache(strFuncId4Code);
            var strTabName_FstLcase = clsString.FstLcaseS(objFunction4Code.TabName);
            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeType.ProgLangTypeId);

            clsDataTypeAbbrEN objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFunction4Code.ReturnTypeId);
            string strReturnType = objFunction4Code.ReturnTypeNameCustom;
            if (string.IsNullOrEmpty(strReturnType) == true)
            {

                strReturnType = objDataTypeAbbr.GetTypeString(objCodeType.ProgLangTypeId);
            }
            strReturnType = strReturnType.Replace("[", "<")
                                  .Replace("]", ">");

            string strInitValue = objDataTypeAbbr.GetInitValue4Var(objCodeType.ProgLangTypeId);

            clswf_PointEN objPoint = clswf_PointBLEx.GetObjByTabKeyIdCache(conCodeType._CurrTabName, strCodeTypeId);
            if (objPoint == null)
            {
                strMsg = string.Format("表名:{0}，关键字:{1} 没有相关端点，请检查！(In {2})",
                                                           conCodeType._CurrTabName, objCodeType.CodeTypeId, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            string strPointId = objPoint.PointId;

            List<string> arrPrevPointId = clswf_StepProcessRelaBLEx.GetPrevPointLstCache(strWorkFlowId, strPointId).ToList();
            //clsFunction4CodeEN objFunction4Code_Prev = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objFunction4Code.PrevFuncId);
            if (arrPrevPointId.Count == 0)
            {
                strMsg = string.Format("代码类型:{0}({1})没有前置代码类型，请检查！(In {2})",
                                                            objCodeType.CodeTypeName, objCodeType.CodeTypeId, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            clswf_PointEN objPoint_Prev = clswf_PointBLEx.GetObjByPointIdCache(arrPrevPointId[0]);
            //if (objPoint_Prev == null)
            //{
            //    strMsg = string.Format("表名:{0}，关键字:{1} 没有相关端点，请检查！(In {2})",
            //                                               conCodeType._CurrTabName, arrPrevPointId[0], clsStackTrace.GetCurrClassFunction());
            //    throw new Exception(strMsg);
            //}
            clsCodeTypeEN objCodeType_Prev = clsCodeTypeBL.GetObjByCodeTypeIdCache(objPoint_Prev.TabKeyId);
            string strClassName_Prev = string.Format(objCodeType_Prev.ClassNameFormat, objFunction4Code.TabName);
            List<clsvFuncParaRelaEN> arrvFuncParaRela = clsvFuncParaRelaBLEx.GetObjListByFuncId4CodeCacheEx(strFuncId4Code);

            StringBuilder strCodeForCs = new StringBuilder();
            switch (objProgLangType.ProgLangTypeId)
            {
                case enumProgLangType.CSharp_01:
                    switch (objCodeType.CodeTypeId)
                    {
                        case enumCodeType.WA_SrvEx_0185://WA_服务扩展层(CSharp)
                        case enumCodeType.WA_Srv_0044:

                            //clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

                            strCodeForCs.Append("\r\n /// <summary>");
                            strCodeForCs.AppendFormat("\r\n /// {0}", objFunction4Code.FuncCHName4Code);
                            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(strFuncId4Code);
                            switch (objFunction4Code.FuncAccessModeId)
                            {
                                case enumFuncAccessMode.Get_01:
                                    string strParaList = "";
                                    if (arrvFuncParaRela != null)
                                    {
                                        IEnumerable<string> arrParaList = arrvFuncParaRela.Select(x => string.Format("{0}=value", x.ParaName));
                                        strParaList = string.Join("&", arrParaList);
                                    }

                                    strCodeForCs.AppendFormat("\r\n /// 调用方法: {0} /api/{1}Api/{2}?{3}",
                                      clsFuncAccessModeBL.GetNameByFuncAccessModeIdCache(objFunction4Code.FuncAccessModeId),
                                      objFunction4Code.ClsName,
                                        objFunction4Code.FuncName4Code,
                                      strParaList);
                                    break;
                            }
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n /// </summary>");
                            if (arrvFuncParaRela != null)
                            {

                                arrvFuncParaRela.ForEach(x =>
                                {
                                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>", x.ParaName, x.ParaCnName);
                                });
                            }
                            strCodeForCs.Append("\r\n /// <returns>返回是否存在?</returns>");
                            string strParaList01 = "";
                            if (arrvFuncParaRela != null)
                            {
                                IEnumerable<string> arrParaList01 = arrvFuncParaRela
                                    .Select(x => string.Format("{0} {1}", x.GetParaTypeName4Rela(objCodeType.ProgLangTypeId), x.ParaName));
                                strParaList01 = string.Join(",", arrParaList01);
                            }

                            switch (objFunction4Code.FuncAccessModeId)
                            {
                                case enumFuncAccessMode.Get_01:

                                    strCodeForCs.AppendFormat("\r\n" + "[HttpGet(\"{0}\")]", objFunction4Code.FuncName4Code);
                                    strCodeForCs.AppendFormat("\r\n" + "public ActionResult {1}({2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList01);
                                    break;
                                case enumFuncAccessMode.Post_02:
                                    strCodeForCs.AppendFormat("\r\n" + "[HttpPost(\"{0}\")]", objFunction4Code.FuncName4Code);
                                    strCodeForCs.AppendFormat("\r\n" + "public ActionResult {1}([FromBody]{2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList01);
                                    break;
                                case enumFuncAccessMode.Put_03:
                                    strCodeForCs.AppendFormat("\r\n" + "[HttpPut(\"{0}\")]", objFunction4Code.FuncName4Code);
                                    strCodeForCs.AppendFormat("\r\n" + "public ActionResult {1}([FromBody]{2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList01);

                                    break;
                                case enumFuncAccessMode.Delete_04:
                                    strCodeForCs.AppendFormat("\r\n" + "[HttpDelete(\"{0}\")]", objFunction4Code.FuncName4Code);
                                    strCodeForCs.AppendFormat("\r\n" + "public ActionResult {1}({2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList01);

                                    break;
                            }

                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
                            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");
                            //strCodeForCs.Append("\r\n" + "{");
                            if (arrvFuncParaRela != null)
                            {
                                arrvFuncParaRela.ForEach(x =>
                                {
                                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(x.DataTypeId);
                                    string strTypeString = "";
                                    switch (x.DataTypeId)
                                    {
                                        case enumDataTypeAbbr.bit_03:
                                            strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0}.ToString());", x.ParaName);
                                            break;
                                        case enumDataTypeAbbr.Object_29:
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSONString = clsJSON.GetJsonFromObj({0});", x.ParaName);
                                            strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", strJSONString);", x.ParaName);
                                            break;
                                        case enumDataTypeAbbr.ObjectLst_30:
                                            strTypeString = clsDataTypeAbbrBLEx.GetTypeNameByArrayType(x.ParameterType);
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSONString = clsJSON.GetJsonFromObjLst<{1}>({0});", x.ParaName, strTypeString);
                                            strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", strJSONString);", x.ParaName);
                                            break;
                                        case enumDataTypeAbbr.Array_31:
                                            string strParameterType = x.ParameterType.Replace("[", "<")
                                                        .Replace("]", ">");
                                            strTypeString = clsDataTypeAbbrBLEx.GetTypeNameByArrayType(strParameterType);
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSONString = string.Join(\",\",{0});", x.ParaName, strTypeString);
                                            strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", strJSONString);", x.ParaName);
                                            break;

                                        default:
                                            if (objDataTypeAbbrEN.IsNeedQuote == false)
                                            {
                                                strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0}.ToString());", x.ParaName);
                                            }
                                            else
                                            {
                                                strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0});", x.ParaName);
                                            }
                                            break;
                                    }

                                });
                            }
                            //strCodeForCs.Append("\r\n };");
                            strCodeForCs.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
                            //if (IsNumberType4Key == true)
                            //{
                            //    strCodeForCs.AppendFormat("\r\n" + " if ({0} <= 0)",
                            //            objKeyField.FldName);
                            //}
                            //else
                            //{
                            //    strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty({0}) == true)",
                            //          objKeyField.FldName);
                            //}
                            //strCodeForCs.Append("\r\n" + " {");
                            //strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"判断表中是否存在给定关键字的记录时，关键字不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
                            //strCodeForCs.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

                            //strCodeForCs.Append("\r\n" + " }");
                            strCodeForCs.Append("\r\n try");
                            strCodeForCs.Append("\r\n {");
                            string strParaList05 = "";
                            if (arrvFuncParaRela != null)
                            {
                                IEnumerable<string> arrParaList05 = arrvFuncParaRela.Select(x => x.ParaName);
                                strParaList05 = string.Join(",", arrParaList05);
                            }
                            if (objFunction4Code.ReturnTypeId == enumDataTypeAbbr.void_27)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{0}.{1}({2});",
                                     strClassName_Prev, objFunction4Code.FuncName4Code, strParaList05);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "var varResult = {0}.{1}({2});",
                                        strClassName_Prev, objFunction4Code.FuncName4Code, strParaList05);
                            }
                            switch (objFunction4Code.ReturnTypeId)
                            {
                                case enumDataTypeAbbr.void_27:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnStr = \"true\" }});");

                                    break;
                                case enumDataTypeAbbr.bit_03:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnBool = varResult }});");

                                    break;
                                case enumDataTypeAbbr.int_09:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnInt = varResult }});");

                                    break;
                                case enumDataTypeAbbr.char_04:
                                case enumDataTypeAbbr.varchar_25:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnStr = varResult }});");

                                    break;
                                case enumDataTypeAbbr.Array_31:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnStrLst = string.Join(\",\", varResult) }});");

                                    break;
                                case enumDataTypeAbbr.Object_29:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnObj = varResult }});");

                                    break;
                                case enumDataTypeAbbr.ObjectLst_30:

                                    strCodeForCs.AppendFormat("\r\n" + "return Ok(new {{ errorId = 0, errorMsg = \"\", returnObjLst = varResult }});");

                                    break;
                                default:
                                    strMsg = string.Format("返回类型:{0}在函数中没有被处理！(In {1})",
                                  strReturnType, clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                            //strCodeForCs.Append("\r\n" + "return varResult;");
                            strCodeForCs.Append("\r\n }");
                            strCodeForCs.Append("\r\n catch (Exception objException)");
                            strCodeForCs.Append("\r\n {");
                            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
                            //strCodeForCs.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

                            //strCodeForCs.AppendFormat("\r\n" + "return {0};", strInitValue);

                            strCodeForCs.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");

                            strCodeForCs.Append("\r\n }");
                            strCodeForCs.Append("\r\n" + "}");
                            return strCodeForCs.ToString();
                        case enumCodeType.WA_AccessEx_0186://WA_访问扩展层(0186)(CSharp)
                            string strParaList02 = "";
                            if (arrvFuncParaRela != null)
                            {
                                //string strParaType = clsFuncPara4CodeBLEx.GetParaTypeName(objProgLangType.ProgLangTypeId);
                                IEnumerable<string> arrParaList02 = arrvFuncParaRela.Select(x => string.Format("{0} {1}", x.GetParaTypeName4Rela(objCodeType.ProgLangTypeId), x.ParaName));
                                strParaList02 = string.Join(",", arrParaList02);
                            }
                            strCodeForCs.Append("\r\n /// <summary>");
                            strCodeForCs.AppendFormat("\r\n /// {0}", objFunction4Code.FuncCHName4Code);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n /// </summary>");
                            if (arrvFuncParaRela != null)
                            {
                                arrvFuncParaRela.ForEach(x =>
                                {
                                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>", x.ParaName, x.ParaCnName);
                                });
                            }
                            strCodeForCs.Append("\r\n /// <returns>返回对象列表</returns>");
                            strCodeForCs.AppendFormat("\r\n public static {0} {1}({2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList02);
                            strCodeForCs.Append("\r\n{");

                            //strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst = null; ",
                            //objPrjTabENEx.TabName);
                            strCodeForCs.AppendFormat("\r\n" + "string strAction = \"{0}\";",
                                objFunction4Code.FuncName4Code);
                            strCodeForCs.Append("\r\n" + "string strErrMsg = string.Empty;");
                            strCodeForCs.Append("\r\n" + "string strResult = \"\";");
                            if (arrvFuncParaRela == null || arrvFuncParaRela.Count == 0)
                            {
                                strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");

                                strCodeForCs.Append("\r\n" + "{");
                                if (arrvFuncParaRela != null)
                                {
                                    arrvFuncParaRela.ForEach(x =>
                                    {
                                        clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(x.DataTypeId);
                                        if (objDataTypeAbbrEN.IsNeedQuote == false)
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString(),", x.ParaName);
                                        }
                                        else if (objDataTypeAbbrEN.DataTypeId == enumDataTypeAbbr.bit_03)
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString(),", x.ParaName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0},", x.ParaName);
                                        }
                                    });
                                }
                                strCodeForCs.Append("\r\n" + "};");
                            }


                            strCodeForCs.Append("\r\n" + "try");
                            strCodeForCs.Append("\r\n" + "{");
                            if (string.IsNullOrEmpty(objFunction4Code.FuncAccessModeId) == true)
                            {
                                strMsg = string.Format("函数:[{0}]({1}({2}))操作模式为空！出错(In {3})",
                                    objFunction4Code.FuncName4Code, objCodeType.CodeTypeName, objFunction4Code.CodeTypeId, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }
                            switch (objFunction4Code.FuncAccessModeId)
                            {
                                case enumFuncAccessMode.Get_01:
                                    strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)");

                                    break;
                                case enumFuncAccessMode.Post_02:
                                    switch (arrvFuncParaRela[0].DataTypeId)
                                    {
                                        case enumDataTypeAbbr.ObjectLst_30:
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst({0});", arrvFuncParaRela[0].ParaName);
                                            break;
                                        case enumDataTypeAbbr.Object_29:
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObj<{1}>({0});",
                                                arrvFuncParaRela[0].ParaName, arrvFuncParaRela[0].ParameterType);

                                            break;
                                        default:
                                            clsDataTypeAbbrEN objDataTypeAbbr1 = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(arrvFuncParaRela[0].DataTypeId);
                                            string strParaType = objDataTypeAbbr1.GetTypeString(objCodeType.ProgLangTypeId);
                                            strMsg = string.Format("参数类型:{0}在函数中没有被处理！(In {1})",
                                                strParaType, clsStackTrace.GetCurrClassFunction());
                                            throw new Exception(strMsg);
                                            //break;
                                    }
                                    strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)");
                                    break;
                                case enumFuncAccessMode.Put_03:
                                    break;
                                case enumFuncAccessMode.Delete_04:
                                    strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, id.ToString(), out strResult, out strErrMsg) == true)");

                                    break;
                                default:

                                    break;
                            }
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "JObject jobjReturn = JObject.Parse(strResult);");
                            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn[\"errorId\"] == 0)");
                            strCodeForCs.Append("\r\n" + "{");
                            //strCodeForCs.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>((string)jobjReturn[\"returnObjLst\"]);",
                            //    objPrjTabENEx.TabName);
                            //strCodeForCs.Append("\r\n" + "return arrObjLst;");


                            switch (objFunction4Code.ReturnTypeId)
                            {
                                case enumDataTypeAbbr.ObjectLst_30:
                                    string strObjType = clsDataTypeAbbrBLEx.GetTypeNameByArrayType(strReturnType);
                                    strCodeForCs.AppendFormat("\r\n" + "var varResult = clsJSON.GetObjLstFromJson<{0}>((string)jobjReturn[\"returnObjLst\"]);",
                                         strObjType);
                                    break;
                                case enumDataTypeAbbr.Object_29:
                                    strCodeForCs.AppendFormat("\r\n" + "var varResult = clsJSON.GetObjFromJson<{0}>((string)jobjReturn[\"returnObj\"]);", strReturnType);

                                    break;
                                case enumDataTypeAbbr.varchar_25:
                                case enumDataTypeAbbr.char_04:
                                    strCodeForCs.AppendFormat("\r\n" + "var varResult = (string)jobjReturn[\"returnStr\"];", strReturnType);
                                    break;
                                case enumDataTypeAbbr.bit_03:

                                    strCodeForCs.Append("\r\n" + "var varResult = (bool)jobjReturn[\"returnBool\"];");
                                    break;
                                case enumDataTypeAbbr.int_09:

                                    strCodeForCs.Append("\r\n" + "var varResult = (int)jobjReturn[\"returnInt\"];");
                                    break;
                                case enumDataTypeAbbr.bigint_01:
                                    strCodeForCs.Append("\r\n" + "var varResult = (long)jobjReturn[\"returnLong\"];");
                                    break;
                                case enumDataTypeAbbr.numeric_14:
                                case enumDataTypeAbbr.money_11:
                                case enumDataTypeAbbr.decimal_06:
                                    strCodeForCs.AppendFormat("\r\n" + "var varResult = {0}.Parse(jobjReturn[\"returnLong\"].ToString()));", strReturnType);
                                    break;

                                default:

                                    strMsg = string.Format("返回类型:{0}在函数中没有被处理！(In {1})",
                                        strReturnType, clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }

                            strCodeForCs.Append("\r\n" + "return varResult;");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn[\"ErrorMsg\"]);");
                            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else return {0};", strInitValue);


                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"{0}出错,{{0}}.(from {{1}})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());",
                                objFunction4Code.FuncCHName4Code);
                            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                            strCodeForCs.Append("\r\n" + "}");



                            //strCodeForCs.Append("\r\nreturn arrObjLst;");
                            strCodeForCs.Append("\r\n}");
                            //获取某一条件值的记录集 == = ;
                            return strCodeForCs.ToString();

                        default:

                            strMsg = string.Format("代码类型:{0}({1})({2})在函数中没有被处理！(In {3})",
                                objCodeType.CodeTypeName, objFunction4Code.CodeTypeId, objProgLangType.ProgLangTypeName, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }
                //break;
                case enumProgLangType.TypeScript_09:
                    switch (objCodeType.CodeTypeId)
                    {
                        case enumCodeType.WA_Access_0155:
                        case enumCodeType.WA_AccessEx_0190:
                            strCodeForCs.Append("\r\n /**");
                            strCodeForCs.AppendFormat("\r\n * {0}", objFunction4Code.FuncCHName4Code);
                            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                            if (arrvFuncParaRela != null)
                            {
                                arrvFuncParaRela.ForEach(x =>
                                {
                                    strCodeForCs.AppendFormat("\r\n * @param {0}: {1}", x.ParaName, x.ParaCnName);
                                });
                            }
                            strCodeForCs.Append("\r\n * @returns 获取的相应对象列表");
                            strCodeForCs.Append("\r\n */");
                            string strParaList06 = "";
                            if (arrvFuncParaRela != null)
                            {
                                IEnumerable<string> arrParaList06 = arrvFuncParaRela.Select(x => string.Format("{0}: {1}", x.ParaName, x.GetParaTypeName4Rela(objCodeType.ProgLangTypeId)));
                                strParaList06 = string.Join(",", arrParaList06);
                                strParaList06 = strParaList06.Replace("List", "Array");
                            }
                            strCodeForCs.AppendFormat("\r\n" + " export async function {3}Ex_{0}({1}): Promise<{2}>  ",
                              objFunction4Code.FuncName4Code,
                              strParaList06,
                              strReturnType.Replace("[", "<")
                                    .Replace("]", ">")
                                    .Replace("List", "Array"), objFunction4Code.TabName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = {0}Ex_{1}.name;",
                                objFunction4Code.TabName, objFunction4Code.FuncName4Code);
                            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"{0}\";",
                              objFunction4Code.FuncName4Code);
                            strCodeForCs.AppendFormat("\r\n" + "const strUrl = {0}Ex_GetWebApiUrl({1}Ex_Controller, strAction);", objFunction4Code.TabName, strTabName_FstLcase);
                            strCodeForCs.Append("\r\n" + "const token = Storage.get(ACCESS_TOKEN_KEY);");
                            strCodeForCs.Append("\r\n" + "//console.error('token:', token);");
                            strCodeForCs.Append("\r\n" + "const config = {");
                            strCodeForCs.Append("\r\n" + "headers: {");
                            strCodeForCs.Append("\r\n" + "Authorization: `${ token}`,");
                            strCodeForCs.Append("\r\n" + "},");
                            strCodeForCs.Append("\r\n" + "params: {");
                            //strCodeForCs.Append("\r\n" + "strTabId,");
                            //strCodeForCs.Append("\r\n" + "strPrjDataBaseId,");
                            foreach (clsvFuncParaRelaEN objInFor in arrvFuncParaRela)
                            {
                                strCodeForCs.Append("\r\n" + $"{objInFor.ParaName},");
                            }
                            strCodeForCs.Append("\r\n" + "},");
                            strCodeForCs.Append("\r\n" + "};");
                            //strCodeForCs.Append("\r\n" + "var mapParam: Dictionary = new Dictionary();");
                            string strFirstParaName = "";
                            string strParaType = "";
                            //if (arrvFuncParaRela != null)
                            //{
                            foreach (clsvFuncParaRelaEN objInFor in arrvFuncParaRela)
                            {
                                if (string.IsNullOrEmpty(strFirstParaName))
                                {
                                    strFirstParaName = objInFor.ParaName;
                                    strParaType = objInFor.DataTypeId;
                                }
                                //strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"{0}\", {0});", objInFor.ParaName);
                            }
                            //}
                            //strCodeForCs.Append("\r\n" + "let strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");

                            strCodeForCs.Append("\r\n" + "try");
                            strCodeForCs.Append("\r\n" + "{");
                            switch (objFunction4Code.FuncAccessModeId)
                            {
                                case enumFuncAccessMode.Post_02:
                                    strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl,{0});", strFirstParaName);

                                    break;
                                case enumFuncAccessMode.Delete_04:
                                    strCodeForCs.AppendFormat("\r\n" + "const response = await axios.delete(strUrl,);", strFirstParaName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "params: {{ \"Id\": {0}, }}", strFirstParaName);
                                    strCodeForCs.Append("\r\n" + "});");

                                    break;
                         
                                case enumFuncAccessMode.Get_01:
                                    strCodeForCs.AppendFormat("\r\n" + "const response = await axios.get(strUrl,config);");

                                    break;
                                default:
                                    strCodeForCs.AppendFormat("\r\n" + "const response = await axios.{0}(strUrl,);", clsFuncAccessModeBL.GetNameByFuncAccessModeIdCache(objFunction4Code.FuncAccessModeId).ToLower());
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "params: {");
                                    foreach (clsvFuncParaRelaEN objInFor in arrvFuncParaRela)
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {0},", objInFor.ParaName);
                                    }
                                    //strCodeForCs.AppendFormat("\r\n" + "params: {{ \"Id\": {0}, }}", strFirstParaName);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "});");

                                    break;
                            }
                            strCodeForCs.Append("\r\n" + "const data = response.data;");
                                                        
                            strCodeForCs.Append("\r\n" + "if (data.errorId == 0)");
                            strCodeForCs.Append("\r\n" + "{");
                            switch (objFunction4Code.ReturnTypeId)
                            {
                                case enumDataTypeAbbr.void_27:
                                    strCodeForCs.Append("\r\n" + "return data.returnStr;");
                                    break;
                                case enumDataTypeAbbr.Array_31:

                                    strCodeForCs.Append("\r\n" + "const returnStrLst = data.returnStrLst.split(',');");
                                    strCodeForCs.Append("\r\n" + "//console.log(\"returnStrLst\", returnStrLst);");
                                    strCodeForCs.Append("\r\n" + "return returnStrLst;");
                                    break;
                                case enumDataTypeAbbr.ObjectLst_30:

                                    strCodeForCs.Append("\r\n" + "const returnObjLst = data.returnObjLst;");
                                    strCodeForCs.Append("\r\n" + "//console.log(returnObjLst);");
                                    strCodeForCs.Append("\r\n" + "return returnObjLst;");
                                    break;
                                case enumDataTypeAbbr.Object_29:
                                    strCodeForCs.Append("\r\n" + "const returnObj = data.returnObj;");
                                    strCodeForCs.Append("\r\n" + "//console.log(returnObj);");
                                    strCodeForCs.Append("\r\n" + "return returnObj;");
                                    break;
                                case enumDataTypeAbbr.varchar_25:
                                case enumDataTypeAbbr.char_04:
                                    strCodeForCs.Append("\r\n" + "return data.returnStr;");

                                    break;
                                case enumDataTypeAbbr.bit_03:

                                    strCodeForCs.Append("\r\n" + "return data.returnBool;");

                                    break;
                                case enumDataTypeAbbr.int_09:

                                    strCodeForCs.Append("\r\n" + "return data.returnInt;");

                                    break;
                                case enumDataTypeAbbr.bigint_01:
                                    strCodeForCs.Append("\r\n" + "return data.returnLong;");

                                    break;
                                case enumDataTypeAbbr.numeric_14:
                                case enumDataTypeAbbr.money_11:
                                case enumDataTypeAbbr.decimal_06:

                                    strCodeForCs.Append("\r\n" + "return data.returnLong;");
                                    break;

                                default:

                                    strMsg = string.Format("返回类型:{0}在函数中没有被处理！(In {1})",
                                        strReturnType, clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }

                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.Append("\r\n" + "console.error(data.errorMsg);");
                            strCodeForCs.Append("\r\n" + "throw (data.errorMsg);");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.Append("\r\n" + "} catch (error: any) {");

                            strCodeForCs.Append("\r\n" + "console.error(error);");

                            strCodeForCs.Append("\r\n" + "if (error.statusText == undefined)");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "throw error;");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "if (error.statusText == \"error\")");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"网络错误！访问地址:{0}不成功！(in {1}.{2})\", strUrl, " + strTabName_FstLcase + "Ex_ConstructorName, strThisFuncName);");
                            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
                            strCodeForCs.Append("\r\n" + "throw(strInfo);");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.Append("\r\n" + "else if (error.statusText == \"Not Found\")");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"网络错误！访问地址:{0}可能不存在！(in {1}.{2})\", strUrl, " + strTabName_FstLcase + "Ex_ConstructorName, strThisFuncName);");
                            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
                            strCodeForCs.Append("\r\n" + "throw(strInfo);");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.Append("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "throw(error.statusText);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "}");
                            return strCodeForCs.ToString();

                        default:

                            strMsg = string.Format("代码类型:{0}({1})({2})在函数中没有被处理！(In {3})",
                                objCodeType.CodeTypeName, objFunction4Code.CodeTypeId, objProgLangType.ProgLangTypeName, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }
                //break;
                default:

                    strMsg = string.Format("语言类型:{0}在函数中没有被处理！(In {1})",
                         objProgLangType.ProgLangTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
            //return strCodeForCs.ToString();
        }

        public static string GeneCode(string strFuncId4Code)
        {
            string strMsg = "";
            clsFunction4CodeEN objFunction4Code = clsFunction4CodeBL.GetObjByFuncId4CodeCache(strFuncId4Code);

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objFunction4Code.CodeTypeId);
            clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeType.ProgLangTypeId);

            clsDataTypeAbbrEN objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFunction4Code.ReturnTypeId);
            string strReturnType = objFunction4Code.ReturnTypeNameCustom;
            if (string.IsNullOrEmpty(strReturnType) == true)
            {

                strReturnType = objDataTypeAbbr.GetTypeString(objCodeType.ProgLangTypeId);
            }
            strReturnType = strReturnType.Replace("[", "<")
                                  .Replace("]", ">");

            string strInitValue = objDataTypeAbbr.GetInitValue4Var(objCodeType.ProgLangTypeId);

            clsFunction4CodeEN objFunction4Code_Prev = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objFunction4Code.PrevFuncId);
            if (objFunction4Code_Prev == null)
            {
                strMsg = string.Format("函数:{0}({1})没有前置函数，请检查！(In {2})",
                                                            objFunction4Code.FuncName4Code, objFunction4Code.FuncId4Code, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            List<clsvFuncParaRelaEN> arrvFuncParaRela = clsvFuncParaRelaBLEx.GetObjListByFuncId4CodeCacheEx(strFuncId4Code);

            StringBuilder strCodeForCs = new StringBuilder();
            switch (objProgLangType.ProgLangTypeId)
            {
                case enumProgLangType.CSharp_01:
                    switch (objCodeType.CodeTypeId)
                    {
                        case enumCodeType.WA_SrvEx_0185://WA_服务扩展层(CSharp)
                        case enumCodeType.WA_Srv_0044:

                            //clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

                            strCodeForCs.Append("\r\n /// <summary>");
                            strCodeForCs.AppendFormat("\r\n /// {0}", objFunction4Code.FuncCHName4Code);
                            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(strFuncId4Code);
                            switch (objFunction4Code.FuncAccessModeId)
                            {
                                case enumFuncAccessMode.Get_01:
                                    string strParaList = "";
                                    if (arrvFuncParaRela != null)
                                    {
                                        IEnumerable<string> arrParaList = arrvFuncParaRela.Select(x => string.Format("{0}=value", x.ParaName));
                                        strParaList = string.Join("&", arrParaList);
                                    }

                                    strCodeForCs.AppendFormat("\r\n /// 调用方法: {0} /api/{1}Api/{2}?{3}",
                                      clsFuncAccessModeBL.GetNameByFuncAccessModeIdCache(objFunction4Code.FuncAccessModeId),
                                      objFunction4Code.ClsName,
                                        objFunction4Code.FuncName4Code,
                                      strParaList);
                                    break;
                            }
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n /// </summary>");
                            if (arrvFuncParaRela != null)
                            {

                                arrvFuncParaRela.ForEach(x =>
                                {
                                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>", x.ParaName, x.ParaCnName);
                                });
                            }
                            strCodeForCs.Append("\r\n /// <returns>返回是否存在?</returns>");
                            string strParaList01 = "";
                            if (arrvFuncParaRela != null)
                            {
                                IEnumerable<string> arrParaList01 = arrvFuncParaRela
                                    .Select(x => string.Format("{0} {1}", x.GetParaTypeName4Rela(objCodeType.ProgLangTypeId), x.ParaName));
                                strParaList01 = string.Join(",", arrParaList01);
                            }

                            switch (objFunction4Code.FuncAccessModeId)
                            {
                                case enumFuncAccessMode.Get_01:

                                    strCodeForCs.AppendFormat("\r\n" + "[HttpGet(\"{0}\")]", objFunction4Code.FuncName4Code);
                                    strCodeForCs.AppendFormat("\r\n" + "public ActionResult {1}({2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList01);
                                    break;
                                case enumFuncAccessMode.Post_02:
                                    strCodeForCs.Append("\r\n" + "[HttpPost(\"\")]");
                                    strCodeForCs.AppendFormat("\r\n" + "public ActionResult {1}([FromBody]{2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList01);
                                    break;
                                case enumFuncAccessMode.Put_03:
                                    strCodeForCs.Append("\r\n" + "[HttpPut(\"\")]");
                                    strCodeForCs.AppendFormat("\r\n" + "public ActionResult {1}([FromBody]{2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList01);

                                    break;
                                case enumFuncAccessMode.Delete_04:
                                    strCodeForCs.Append("\r\n" + "[HttpDelete(\"\")]");
                                    strCodeForCs.AppendFormat("\r\n" + "public ActionResult {1}({2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList01);

                                    break;
                            }

                            strCodeForCs.Append("\r\n" + "{");
                            
                            strCodeForCs.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
                            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");
                            //strCodeForCs.Append("\r\n" + "{");
                            if (arrvFuncParaRela != null)
                            {
                                arrvFuncParaRela.ForEach(x =>
                                {
                                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(x.DataTypeId);
                                    string strTypeString = "";
                                    switch (x.DataTypeId)
                                    {
                                        case enumDataTypeAbbr.bit_03:
                                            strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0}.ToString());", x.ParaName);
                                            break;
                                        case enumDataTypeAbbr.Object_29:
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSONString = clsJSON.GetJsonFromObj({0});", x.ParaName);
                                            strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", strJSONString);", x.ParaName);
                                            break;
                                        case enumDataTypeAbbr.ObjectLst_30:
                                            strTypeString = clsDataTypeAbbrBLEx.GetTypeNameByArrayType(x.ParameterType);
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSONString = clsJSON.GetJsonFromObjLst<{1}>({0});", x.ParaName, strTypeString);
                                            strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", strJSONString);", x.ParaName);
                                            break;
                                        case enumDataTypeAbbr.Array_31:
                                            string strParameterType = x.ParameterType.Replace("[", "<")
                                                        .Replace("]", ">");
                                            strTypeString = clsDataTypeAbbrBLEx.GetTypeNameByArrayType(strParameterType);
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSONString = string.Join(\",\",{0});", x.ParaName, strTypeString);
                                            strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", strJSONString);", x.ParaName);
                                            break;

                                        default:
                                            if (objDataTypeAbbrEN.IsNeedQuote == false)
                                            {
                                                strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0}.ToString());", x.ParaName);
                                            }
                                            else
                                            {
                                                strCodeForCs.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0});", x.ParaName);
                                            }
                                            break;
                                    }

                                });
                            }
                            //strCodeForCs.Append("\r\n };");
                            strCodeForCs.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
                            //if (IsNumberType4Key == true)
                            //{
                            //    strCodeForCs.AppendFormat("\r\n" + " if ({0} <= 0)",
                            //            objKeyField.FldName);
                            //}
                            //else
                            //{
                            //    strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty({0}) == true)",
                            //          objKeyField.FldName);
                            //}
                            //strCodeForCs.Append("\r\n" + " {");
                            //strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"判断表中是否存在给定关键字的记录时，关键字不能为空!({0})\", clsStackTrace.GetCurrClassFunction());");
                            //strCodeForCs.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

                            //strCodeForCs.Append("\r\n" + " }");
                            strCodeForCs.Append("\r\n try");
                            strCodeForCs.Append("\r\n {");
                            string strParaList05 = "";
                            if (arrvFuncParaRela != null)
                            {
                                IEnumerable<string> arrParaList05 = arrvFuncParaRela.Select(x => x.ParaName);
                                strParaList05 = string.Join(",", arrParaList05);
                            }
                            strCodeForCs.AppendFormat("\r\n" + "var varResult = {0}.{1}({2});",
                                    objFunction4Code_Prev.ClsName, objFunction4Code_Prev.FuncName4Code, strParaList05);
                            switch(objFunction4Code.ReturnTypeId)
                            {
                                case enumDataTypeAbbr.bit_03:
                                    strCodeForCs.Append("\r\n" + "jobjReturn[\"returnBool\"] = varResult;");
                                    strCodeForCs.Append("\r\n" + "return jobjReturn;");
                                    break;
                                case enumDataTypeAbbr.int_09:
                                    strCodeForCs.Append("\r\n" + "jobjReturn[\"returnInt\"] = varResult;");
                                    strCodeForCs.Append("\r\n" + "return jobjReturn;");
                                    break;
                                case enumDataTypeAbbr.char_04:
                                case enumDataTypeAbbr.varchar_25:
                                    strCodeForCs.Append("\r\n" + "jobjReturn[\"returnStr\"] = varResult;");
                                    strCodeForCs.Append("\r\n" + "return jobjReturn;");
                                    break;
                                case enumDataTypeAbbr.Array_31:
                                    strCodeForCs.Append("\r\n" + "jobjReturn[\"returnStrLst\"] = string.Join(\",\", varResult);");
                                    strCodeForCs.Append("\r\n" + "return jobjReturn;");
                                    break;
                                case enumDataTypeAbbr.Object_29:
                                    strCodeForCs.Append("\r\n" + "jobjReturn[\"returnObj\"] = JsonConvert.SerializeObject(varResult);");
                                    strCodeForCs.Append("\r\n" + "return jobjReturn;");
                                    break;
                                case enumDataTypeAbbr.ObjectLst_30:
                                    strCodeForCs.Append("\r\n" + "jobjReturn[\"returnObjLst\"] = JsonConvert.SerializeObject(varResult);");
                                    strCodeForCs.Append("\r\n" + "return jobjReturn;");
                                    break;
                            }
                            //strCodeForCs.Append("\r\n" + "return varResult;");
                            strCodeForCs.Append("\r\n }");
                            strCodeForCs.Append("\r\n catch (Exception objException)");
                            strCodeForCs.Append("\r\n {");
                            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
                            //strCodeForCs.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

                            //strCodeForCs.AppendFormat("\r\n" + "return {0};", strInitValue);

                            strCodeForCs.Append("\r\n" + "return Ok(new { errorId = 1, errorMsg = strMsg });");
                            strCodeForCs.Append("\r\n }");
                            strCodeForCs.Append("\r\n" + "}");
                            return strCodeForCs.ToString();
                        case enumCodeType.WA_AccessEx_0186://WA_访问扩展层(0186)(CSharp)
                            string strParaList02 = "";
                            if (arrvFuncParaRela != null)
                            {
                                //string strParaType = clsFuncPara4CodeBLEx.GetParaTypeName(objProgLangType.ProgLangTypeId);
                                IEnumerable<string> arrParaList02 = arrvFuncParaRela.Select(x => string.Format("{0} {1}", x.GetParaTypeName4Rela(objCodeType.ProgLangTypeId), x.ParaName));
                                strParaList02 = string.Join(",", arrParaList02);
                            }
                            strCodeForCs.Append("\r\n /// <summary>");
                            strCodeForCs.AppendFormat("\r\n /// {0}", objFunction4Code.FuncCHName4Code);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n /// </summary>");
                            if (arrvFuncParaRela != null)
                            {
                                arrvFuncParaRela.ForEach(x =>
                                {
                                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>", x.ParaName, x.ParaCnName);
                                });
                            }
                            strCodeForCs.Append("\r\n /// <returns>返回对象列表</returns>");
                            strCodeForCs.AppendFormat("\r\npublic static {0} {1}({2})",
                                    strReturnType,
                                    objFunction4Code.FuncName4Code,
                                    strParaList02);
                            strCodeForCs.Append("\r\n{");

                            //strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst = null; ",
                            //objPrjTabENEx.TabName);
                            strCodeForCs.AppendFormat("\r\n" + "string strAction = \"{0}\";",
                                objFunction4Code_Prev.FuncName4Code);
                            strCodeForCs.Append("\r\n" + "string strErrMsg = string.Empty;");
                            strCodeForCs.Append("\r\n" + "string strResult = \"\";");
                            if (arrvFuncParaRela == null || arrvFuncParaRela.Count == 0)
                            {
                                strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");

                                strCodeForCs.Append("\r\n" + "{");
                                if (arrvFuncParaRela != null)
                                {
                                    arrvFuncParaRela.ForEach(x =>
                                    {
                                        clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(x.DataTypeId);
                                        if (objDataTypeAbbrEN.IsNeedQuote == false)
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString(),", x.ParaName);
                                        }
                                        else if (objDataTypeAbbrEN.DataTypeId == enumDataTypeAbbr.bit_03)
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString(),", x.ParaName);
                                        }
                                        else
                                        {
                                            strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0},", x.ParaName);
                                        }
                                    });
                                }
                                strCodeForCs.Append("\r\n" + "};");
                            }


                            strCodeForCs.Append("\r\n" + "try");
                            strCodeForCs.Append("\r\n" + "{");
                            if (string.IsNullOrEmpty(objFunction4Code.FuncAccessModeId) == true)
                            {
                                strMsg = string.Format("函数:[{0}]({1}({2}))操作模式为空！出错(In {3})",
                                    objFunction4Code.FuncName4Code, objCodeType.CodeTypeName, objFunction4Code.CodeTypeId, clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }
                            switch (objFunction4Code.FuncAccessModeId)
                            {
                                case enumFuncAccessMode.Get_01:
                                    strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)");

                                    break;
                                case enumFuncAccessMode.Post_02:
                                    switch (arrvFuncParaRela[0].DataTypeId)
                                    {
                                        case enumDataTypeAbbr.ObjectLst_30:
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst({0});", arrvFuncParaRela[0].ParaName);
                                            break;
                                        case enumDataTypeAbbr.Object_29:
                                            strCodeForCs.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObj<{1}>({0});",
                                                arrvFuncParaRela[0].ParaName, arrvFuncParaRela[0].ParameterType);

                                            break;
                                        default:
                                            clsDataTypeAbbrEN objDataTypeAbbr1 = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(arrvFuncParaRela[0].DataTypeId);
                                            string strParaType = objDataTypeAbbr1.GetTypeString(objCodeType.ProgLangTypeId);
                                            strMsg = string.Format("参数类型:{0}在函数中没有被处理！(In {1})",
                                                strParaType, clsStackTrace.GetCurrClassFunction());
                                            throw new Exception(strMsg);
                                            //break;
                                    }
                                    strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)");
                                    break;
                                case enumFuncAccessMode.Put_03:
                                    break;
                                case enumFuncAccessMode.Delete_04:
                                    strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, id.ToString(), out strResult, out strErrMsg) == true)");

                                    break;
                                default:

                                    break;
                            }
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "JObject jobjReturn = JObject.Parse(strResult);");
                            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn[\"errorId\"] == 0)");
                            strCodeForCs.Append("\r\n" + "{");
                            //strCodeForCs.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>((string)jobjReturn[\"returnObjLst\"]);",
                            //    objPrjTabENEx.TabName);
                            //strCodeForCs.Append("\r\n" + "return arrObjLst;");
                         

                            switch (objFunction4Code.ReturnTypeId)
                            {
                                case enumDataTypeAbbr.ObjectLst_30:
                                    string strObjType = clsDataTypeAbbrBLEx.GetTypeNameByArrayType(strReturnType);
                                    strCodeForCs.AppendFormat("\r\n" + "var varResult = clsJSON.GetObjLstFromJson<{0}>((string)jobjReturn[\"returnObjLst\"]);",
                                         strObjType);
                                    break;
                                case enumDataTypeAbbr.Object_29:
                                    strCodeForCs.AppendFormat("\r\n" + "var varResult = clsJSON.GetObjFromJson<{0}>((string)jobjReturn[\"returnObj\"]);", strReturnType);

                                    break;
                                case enumDataTypeAbbr.varchar_25:
                                case enumDataTypeAbbr.char_04:
                                    strCodeForCs.AppendFormat("\r\n" + "var varResult = (string)jobjReturn[\"returnStr\"];", strReturnType);
                                    break;
                                case enumDataTypeAbbr.bit_03:

                                    strCodeForCs.Append("\r\n" + "var varResult = (bool)jobjReturn[\"returnBool\"];");
                                    break;
                                case enumDataTypeAbbr.int_09:

                                    strCodeForCs.Append("\r\n" + "var varResult = (int)jobjReturn[\"returnInt\"];");
                                    break;
                                case enumDataTypeAbbr.bigint_01:
                                    strCodeForCs.Append("\r\n" + "var varResult = (long)jobjReturn[\"returnLong\"];");
                                    break;
                                case enumDataTypeAbbr.numeric_14:
                                case enumDataTypeAbbr.money_11:
                                case enumDataTypeAbbr.decimal_06:
                                    strCodeForCs.AppendFormat("\r\n" + "var varResult = {0}.Parse(jobjReturn[\"returnLong\"].ToString()));", strReturnType);
                                    break;

                                default:

                                    strMsg = string.Format("返回类型:{0}在函数中没有被处理！(In {1})",
                                        strReturnType, clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }

                            strCodeForCs.Append("\r\n" + "return varResult;");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn[\"ErrorMsg\"]);");
                            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else return {0};", strInitValue);


                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"{0}出错,{{0}}.(from {{1}})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());",
                                objFunction4Code.FuncCHName4Code);
                            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                            strCodeForCs.Append("\r\n" + "}");



                            //strCodeForCs.Append("\r\nreturn arrObjLst;");
                            strCodeForCs.Append("\r\n}");
                            //获取某一条件值的记录集 == = ;
                            return strCodeForCs.ToString();

                        default:

                            strMsg = string.Format("代码类型:{0}({1})({2})在函数中没有被处理！(In {3})",
                                objCodeType.CodeTypeName, objFunction4Code.CodeTypeId, objProgLangType.ProgLangTypeName, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }
          
                case enumProgLangType.TypeScript_09:
                    switch (objCodeType.CodeTypeId)
                    {
                        case enumCodeType.WA_Access_0155:
                        case enumCodeType.WA_AccessEx_0190:
                            strCodeForCs.Append("\r\n /// <summary>");
                            strCodeForCs.AppendFormat("\r\n /// {0}", objFunction4Code.FuncCHName4Code);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n /// </summary>");
                            if (arrvFuncParaRela != null)
                            {
                                arrvFuncParaRela.ForEach(x =>
                                {
                                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>", x.ParaName, x.ParaCnName);
                                });
                            }
                            strCodeForCs.Append("\r\n /// <returns>获取的相应对象列表</returns>");
                            string strParaList06 = "";
                            if (arrvFuncParaRela != null)
                            {
                                IEnumerable<string> arrParaList06 = arrvFuncParaRela.Select(x => string.Format("{0}: {1}", x.ParaName, x.GetParaTypeName4Rela(objCodeType.ProgLangTypeId)));
                                strParaList06 = string.Join(",", arrParaList06);
                            }
                            strCodeForCs.AppendFormat("\r\n" + "public static {0}({1}): Promise<{2}>  ",
                              objFunction4Code.FuncName4Code,
                              strParaList06,
                              strReturnType.Replace("[", "<")
                                    .Replace("]", ">")
                                    .Replace("List", "Array"));
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "var strAction = \"{0}\";",
                              objFunction4Code_Prev.FuncName4Code);
                            strCodeForCs.Append("\r\n" + "let strUrl = this.GetWebApiUrl(this.mstrController, strAction);");

                            strCodeForCs.Append("\r\n" + "var mapParam: Dictionary = new Dictionary();");
                            string strFirstParaName = "";
                            if (arrvFuncParaRela != null)
                            {
                                foreach (clsvFuncParaRelaEN objInFor in arrvFuncParaRela)
                                {
                                    if (string.IsNullOrEmpty(strFirstParaName)) strFirstParaName = objInFor.ParaName;
                                    strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"{0}\", {0});", objInFor.ParaName);
                                }
                            }
                            strCodeForCs.Append("\r\n" + "let strData = mapParam.getParamText();// \"例如: strIdentityID =01\";");

                            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
                            strCodeForCs.Append("\r\n" + "$.ajax({");
                            strCodeForCs.Append("\r\n" + "url: strUrl,");
                            strCodeForCs.AppendFormat("\r\n" + "method: \"{0}\",", clsFuncAccessModeBL.GetNameByFuncAccessModeIdCache(objFunction4Code.FuncAccessModeId));
                            strCodeForCs.Append("\r\n" + "dataType: \"json\",");
                            if (objFunction4Code.FuncAccessModeId == enumFuncAccessMode.Delete_04)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "data: {{ \"\": {0} }},", strFirstParaName);
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "data: strData,");
                            }
                            strCodeForCs.Append("\r\n" + "success: function(data) {");
                            strCodeForCs.Append("\r\n" + "resolve(data);");
                            strCodeForCs.Append("\r\n" + "},");
                            strCodeForCs.Append("\r\n" + "error: (e) => {");
                            strCodeForCs.Append("\r\n" + "console.error(e);");
                            strCodeForCs.Append("\r\n" + "var strErrMsg = decodeURIComponent(e.responseText)");
                            strCodeForCs.Append("\r\n" + "reject(e);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "});");
                            strCodeForCs.Append("\r\n" + "});");

                            strCodeForCs.Append("\r\n" + "};");

                            return strCodeForCs.ToString();

                        default:

                            strMsg = string.Format("代码类型:{0}({1})({2})在函数中没有被处理！(In {3})",
                                objCodeType.CodeTypeName, objFunction4Code.CodeTypeId, objProgLangType.ProgLangTypeName, clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }
                    //break;
                default:

                    strMsg = string.Format("语言类型:{0}在函数中没有被处理！(In {1})",
                         objProgLangType.ProgLangTypeName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
            //return strCodeForCs.ToString();
        }
        public static string GeneCode4Class(string strClassName, string strCodeTypeId, string strPrjId)
        {
            //string strCondition = string.Format("{0}='{1}' and {2}='{3}' and {4}='{5}'",
            //    conFunction4Code.ClsName, strClassName,
            //    conFunction4Code.CodeTypeId, strCodeTypeId,
            //    conFunction4Code.PrjId, strPrjId);

            List<clsFunction4CodeEN> arrFunction4Code0 = clsFunction4CodeBL.GetObjLstCache();

            List<clsFunction4CodeEN> arrFunction4Code_Sel = arrFunction4Code0
                .Where(x => x.PrjId == strPrjId
                          && x.CodeTypeId == strCodeTypeId
                          && x.ClsName == strClassName).ToList();
         

            StringBuilder strCodeForCs = new StringBuilder();
            arrFunction4Code_Sel.ForEach(x =>
            {
                try
                {
                    string strCode = GeneCode(x.FuncId4Code);
                    strCodeForCs.Append(strCode);
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("生成函数:[{0}({1})]出现错误。错误:{2}", x.FuncName4Code, x.FuncId4Code, objException.Message);
                    throw new Exception(strMsg);
                }
            });
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 从对象列表类型串中找出对象的类型
        /// </summary>
        /// <param name="strDataType"></param>
        /// <returns></returns>

        public static clsFunction4CodeEN GeneFunction(string strFuncId4Code, string strCodeTypeId, string strOpUserId, string strFuncAccessModeId = "")
        {
            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            clsProgLangTypeEN objProgLangType = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objCodeType.ProgLangTypeId);
            clsFunction4CodeEN objFunction4Code = clsFunction4CodeBL.GetObjByFuncId4CodeCache(strFuncId4Code);
            if (string.IsNullOrEmpty(strFuncAccessModeId) == true)
            {
                strFuncAccessModeId = objFunction4Code.FuncAccessModeId;
            }
            List<clsFuncParaRelaEN> arrFuncParaRela = clsFuncParaRelaBLEx.GetObjListByFuncId4CodeCacheEx(strFuncId4Code);

            clsFunction4CodeEN objFunction4Code_Cond = new clsFunction4CodeEN();
            string strCondition = objFunction4Code_Cond.SetPrevFuncId(objFunction4Code.FuncId4Code, "=")
                .SetCodeTypeId(strCodeTypeId, "=")
                .GetCombineCondition();
            clsFunction4CodeEN objFunction4Code_New = clsFunction4CodeBL.GetFirstObj_S(strCondition);
            if (objFunction4Code_New == null)
            {
                objFunction4Code_New = new clsFunction4CodeEN();
                objFunction4Code.CopyTo(objFunction4Code_New);
                string strClassName = "";
                string strFuncName = "";
                switch (strCodeTypeId)
                {
                    case enumCodeType.WA_Access_0155://                     WA_访问层（TS）
                    case enumCodeType.WA_AccessEx_0190://                     WA_访问扩展层（TS）
                        if (string.IsNullOrEmpty(strFuncAccessModeId) == true)
                        {
                            throw new Exception("请输入函数操作模式！");
                        }
                        strClassName = "cls" + objFunction4Code.ClsName
                           .Replace("cls", "")
                           .Replace("BLEx", "")
                           .Replace("ApiController", "")
                           + "WApi";
                        strFuncName = objFunction4Code.FuncName4Code + "Async";
                        break;
                    case enumCodeType.WA_Srv_0044:
                    case enumCodeType.WA_SrvEx_0185:
                        if (string.IsNullOrEmpty(strFuncAccessModeId) == true)
                        {
                            throw new Exception("请输入函数操作模式！");
                        }
                        strClassName = objFunction4Code.ClsName
                           .Replace("cls", "")
                           .Replace("BLEx", "") + "ExApiController";
                        strFuncName = objFunction4Code.FuncName4Code;
                        break;
                    case enumCodeType.WA_Access_0045://                     WA_访问层（CSharp）

                        strClassName = "cls" + objFunction4Code.ClsName
                           .Replace("cls", "")
                           .Replace("BLEx", "")
                           .Replace("ApiController", "")
                           + "ExWApi";
                        strFuncName = objFunction4Code.FuncName4Code;
                        break;
                    case enumCodeType.WA_AccessEx_0186://访问扩展层（CSharp）
                        if (string.IsNullOrEmpty(strFuncAccessModeId) == true)
                        {
                            throw new Exception("请输入函数操作模式！");
                        }
                        strClassName = "cls" + objFunction4Code.ClsName
                     .Replace("cls", "")
                     .Replace("BLEx", "")
                     .Replace("ApiController", "")
                     + "WApi";
                        strFuncName = objFunction4Code.FuncName4Code;
                        break;
                    case enumCodeType.WA_ViewUTScriptCS_TS_0161://WA_界面UT脚本后台_TS(0161)(TypeScript)
                        strClassName = "WApi" + objFunction4Code.ClsName
                         .Replace("cls", "")
                         .Replace("BLEx", "")
                         .Replace("ApiController", "")
                         .Replace("WApi", "")
                         + "_UT_TS";
                        strFuncName = string.Format("btn{0}_Click", objFunction4Code.FuncName4Code.Replace("Async", ""));
                        break;
                    case enumCodeType.WA_ViewUTScriptCS_0053://WA_界面UT脚本后台_TS(0161)(TypeScript)
                        strClassName = "WApi" + objFunction4Code.ClsName
                         .Replace("cls", "")
                         .Replace("BLEx", "")
                         .Replace("ApiController", "")
                         .Replace("WApi", "")
                         + "_UT";
                        strFuncName = string.Format("btn{0}_Click", objFunction4Code.FuncName4Code.Replace("Async", ""));
                        break;

                    default:

                        string strMsg = string.Format("代码类型:{0}({1})({2})在函数中没有被处理！(In {3})",
                            objCodeType.CodeTypeName, strCodeTypeId, objProgLangType.ProgLangTypeName, clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
                objFunction4Code_New.SetFuncId4Code(clsFunction4CodeBL.GetMaxStrId_S())
                    .SetPrevFuncId(objFunction4Code.FuncId4Code)
                    .SetCodeTypeId(strCodeTypeId)
                           .SetFuncAccessModeId(strFuncAccessModeId)
                           .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                           .SetUpdUser(strOpUserId)
                           .SetClsName(strClassName)
                           .SetFuncName4Code(strFuncName)
                    .AddNewRecord();

            }
            else
            {
                objFunction4Code_New.SetFuncAccessModeId(strFuncAccessModeId)
                     .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                           .SetUpdUser(strOpUserId)
                    .Update();

            }
            if (arrFuncParaRela != null)
            {
                foreach (clsFuncParaRelaEN objInFor in arrFuncParaRela)
                {
                    if (objFunction4Code_New.FuncAccessModeId == enumFuncAccessMode.Delete_04)
                    {
                        clsFuncPara4CodeEN objFuncPara4Code_Old = clsFuncPara4CodeBL.GetObjByFuncParaId4CodeCache(objInFor.FuncParaId4Code, objFunction4Code.FuncPurposeId);
                        clsFuncPara4CodeEN objFuncPara4Code_Cond = new clsFuncPara4CodeEN();
                        strCondition = objFuncPara4Code_Cond.SetParaName("id", "=")
                            .SetDataTypeId(objFuncPara4Code_Old.DataTypeId, "=")
                            .GetCombineCondition();
                        if (clsFuncPara4CodeBL.IsExistRecord(strCondition) == true)
                        {
                            objFuncPara4Code_Old = clsFuncPara4CodeBL.GetFirstObj_S(strCondition);
                        }
                        else
                        {
                            objFuncPara4Code_Old.SetParaName("id")
                                .SetFuncParaId4Code(clsFuncPara4CodeBL.GetMaxStrId_S())
                                     .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                               .SetUpdUser(strOpUserId)
                               .AddNewRecord();
                        }
                        clsFuncParaRelaEN objFuncParaRela = new clsFuncParaRelaEN();
                        objFuncParaRela.SetFuncId4Code(objFunction4Code_New.FuncId4Code)
                            .SetFuncParaId4Code(objFuncPara4Code_Old.FuncParaId4Code)
                             .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                            .SetUpdUser(strOpUserId)
                            .AddNewRecord();
                        break;
                    }
                    else
                    {
                        objInFor.SetFuncId4Code(objFunction4Code_New.FuncId4Code)
                             .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                            .SetUpdUser(strOpUserId);
//                        strCondition = objInFor.GetUniConditionStr_FuncParaId4Code_FuncId4Code();
                        strCondition = objInFor.GetUniCondStr();
                        if (clsFuncParaRelaBL.IsExistRecord(strCondition) == false)
                        {
                            objInFor.AddNewRecord();
                        }
                    }
                }
            }
            return objFunction4Code_New;

        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="strFuncId4Code">表关键字</param>
        /// <returns></returns>
        public new static bool DelRecordEx(string strFuncId4Code)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsFunction4CodeDA.GetSpecSQLObj();
            //删除TeacherInfo本表中与当前对象有关的记录
            SqlConnection objConnection = null;
            SqlTransaction objSqlTransaction = null;
            try
            {
                //获取连接对象
                objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
                //获取该连接对象中的事务
                objSqlTransaction = objConnection.BeginTransaction();
                //
                //删除与表:[Function4Code]相关的表的代码，需要时去除注释，编写相关的代码
                string strCondition = string.Format("{0} = '{1}'", conFunction4Code.FuncId4Code, strFuncId4Code);
                clsFuncParaRelaBL.DelFuncParaRelasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);

                clsFunction4CodeBL.DelRecord(strFuncId4Code, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsFunction4CodeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strFuncId4Code, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                if (objSqlTransaction != null)
                {
                    objSqlTransaction.Rollback();
                }
                throw new Exception(strMsg);
            }
            finally
            {
                objConnection.Close();
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsFunction4CodeENEx> GetObjExLst(string strCondition)
        {
            List<clsFunction4CodeEN> arrObjLst = clsFunction4CodeBL.GetObjLst(strCondition);
            List<clsFunction4CodeENEx> arrObjExLst = new List<clsFunction4CodeENEx>();
            foreach (clsFunction4CodeEN objInFor in arrObjLst)
            {
                clsFunction4CodeENEx objFunction4CodeENEx = new clsFunction4CodeENEx();
                clsFunction4CodeBL.CopyTo(objInFor, objFunction4CodeENEx);
                arrObjExLst.Add(objFunction4CodeENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strFuncId4Code">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsFunction4CodeENEx GetObjExByFuncId4Code(string strFuncId4Code)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4Code(strFuncId4Code);
            clsFunction4CodeENEx objFunction4CodeENEx = new clsFunction4CodeENEx();
            clsFunction4CodeBL.CopyTo(objFunction4CodeEN, objFunction4CodeENEx);
            return objFunction4CodeENEx;
        }

        public static bool CalcFunctionSignature(string strFuncId4Code)
        {
            if (string.IsNullOrEmpty(strFuncId4Code) == false)
            {
                clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(strFuncId4Code);
                objFunction4CodeEN.FunctionSignature = objFunction4CodeEN.GetFunctionSignature();
                objFunction4CodeEN.FunctionSignatureSim = objFunction4CodeEN.GetFunctionSignatureSim();
                objFunction4CodeEN.UpdateRecordEx();
            }
            return true;
        }
    }


}