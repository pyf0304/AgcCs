
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsWebSrvFunctionsBLEx
表名:WebSrvFunctions
生成代码版本:2017.05.08.1
生成日期:2017/05/18 11:52:22
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
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

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// WebSrv函数(WebSrvFunctions)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsWebSrvFunctionsBLEx : clsWebSrvFunctionsBL
    {
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineObjList4Cache)
        /// </summary>
        protected static List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst4SysFunctionCache = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsWebSrvFunctionsDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsWebSrvFunctionsDAEx WebSrvFunctionsDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsWebSrvFunctionsDAEx();
                }
                return uniqueInstanceEx;
            }
        }


        /// <summary>
        /// 根据所给的函数名相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// </summary>
        /// <param name = "strWebSrvFunctionName">所给的函数名</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsWebSrvFunctionsEN GetWebSrvFunctionsObjByWebSrvFunctionNameCache(string strWebSrvFunctionName)
        {
            if (string.IsNullOrEmpty(strWebSrvFunctionName) == true) return null;
            //初始化列表缓存
            List<clsWebSrvFunctionsEN> arrObjLstCache = clsWebSrvFunctionsBL.GetObjLstCache();

            IEnumerable<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst_Sel1 =
            from objWebSrvFunctionsEN in arrObjLstCache
            where objWebSrvFunctionsEN.FunctionName == strWebSrvFunctionName
            select objWebSrvFunctionsEN;
            List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst_Sel = new List<clsWebSrvFunctionsEN>();
            foreach (clsWebSrvFunctionsEN obj in arrWebSrvFunctionsObjLst_Sel1)
            {
                arrWebSrvFunctionsObjLst_Sel.Add(obj);
            }
            if (arrWebSrvFunctionsObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrWebSrvFunctionsObjLst_Sel[0];
        }
        /// <summary>
        /// 根据[类Id]获取对象列表
        /// </summary>
        /// <param name = "strWebSrvClassId">类Id</param>
        /// <returns>返回对象列表</returns>
        public static List<clsWebSrvFunctionsEN> GetObjLstByClassId(string strWebSrvClassId)
        {
            string strCondition = string.Format("{0}='{1}",
                conWebSrvFunctions.WebSrvClassId, strWebSrvClassId);
            List<clsWebSrvFunctionsEN> arrObjList = GetObjLst(strCondition);
            return arrObjList;
        }

        /// <summary>
        /// 根据[类Id]获取对象列表
        /// </summary>
        /// <param name = "strWebSrvClassId">类Id</param>
        /// <returns>返回对象列表</returns>
        public static List<clsWebSrvFunctionsENEx> GetWebSrvFunctionsENExObjListByClassId(string strWebSrvClassId)
        {
            string strCondition = string.Format("{0}='{1}'",
                conWebSrvFunctions.WebSrvClassId, strWebSrvClassId);
            List<clsWebSrvFunctionsEN> arrObjList = GetObjLst(strCondition);
            List<clsWebSrvFunctionsENEx> arrObjExList = new List<clsWebSrvFunctionsENEx>();
            foreach(clsWebSrvFunctionsEN objWebSrvFunctionsEN in arrObjList)
            {
                clsWebSrvFunctionsENEx objWebSrvFunctionsENEx = new clsWebSrvFunctionsENEx();
                clsWebSrvFunctionsBL.CopyTo(objWebSrvFunctionsEN, objWebSrvFunctionsENEx);
                objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst = clsWebSrvFuncParaBLEx.GetObjLstByFuncId(objWebSrvFunctionsEN.WebSrvFunctionId);
                arrObjExList.Add(objWebSrvFunctionsENEx);
            }
            return arrObjExList;
        }

        /// <summary>
        /// 获取系统函数对象列表
        /// </summary>
        /// <returns>返回对象列表</returns>
        public static void GetWebSrvFunctionsENExObjListBySysFunction()
        {
            if (arrWebSrvFunctionsObjLst4SysFunctionCache != null) return;
            string strCondition = string.Format("{0}='1'",  conWebSrvFunctions.IsSysFunction);
            List<clsWebSrvFunctionsEN> arrObjList = GetObjLst(strCondition);
            arrWebSrvFunctionsObjLst4SysFunctionCache = arrObjList;          
        }
        /// <summary>
        /// 判断所给的WebService函数是否是系统函数
        /// </summary>
        /// <param name="strWebSrvFunctionName"></param>
        /// <returns></returns>
        public static bool IsSysFunction(string strWebSrvFunctionName)
        {
            if (string.IsNullOrEmpty(strWebSrvFunctionName) == true) return false;
            //初始化列表缓存
            GetWebSrvFunctionsENExObjListBySysFunction();
            IEnumerable<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst_Sel1 =
            from objWebSrvFunctionsEN in arrWebSrvFunctionsObjLst4SysFunctionCache
            where objWebSrvFunctionsEN.FunctionName == strWebSrvFunctionName
            select objWebSrvFunctionsEN;
            
            List<clsWebSrvFunctionsEN> arrWebSrvFunctionsObjLst_Sel = new List<clsWebSrvFunctionsEN>();
            foreach (clsWebSrvFunctionsEN obj in arrWebSrvFunctionsObjLst_Sel1)
            {
                arrWebSrvFunctionsObjLst_Sel.Add(obj);
            }
            if (arrWebSrvFunctionsObjLst_Sel.Count == 0)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 设置是否生成代码
        /// </summary>
        /// <param name="strWebSrvFunctionId"></param>
        /// <param name="bolIsGeneCode"></param>
        /// <returns></returns>
        public static bool SetGeneCode(string strWebSrvFunctionId, bool bolIsGeneCode)
        {
            string strCondition = string.Format("{0}='{1}'", conWebSrvFunctions.WebSrvFunctionId, strWebSrvFunctionId);
            string strValue = bolIsGeneCode ? "1" : "0";
            clsWebSrvFunctionsBL.SetFldValue(clsWebSrvFunctionsEN._CurrTabName,
                conWebSrvFunctions.IsGeneCode,
                strValue, strCondition);
            return true;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strPrjId">strPrjId</param>
        public static void BindDdl_WebSrvFunctionIdByPrjId(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format("{0}='{1}'", convWebSrvFunctions.PrjId, strPrjId);

            System.Data.DataTable objDT = clsvWebSrvFunctionsBL.GetDataTable_vWebSrvFunctions(strCondition);
            objDDL.DataValueField = conWebSrvFunctions.WebSrvFunctionId;
            objDDL.DataTextField = conWebSrvFunctions.FunctionName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strWebSrvClassId">strWebSrvClassId</param>
        public static void BindDdl_WebSrvFunctionIdByWebSrvClassId(System.Web.UI.WebControls.DropDownList objDDL, 
            string strWebSrvClassId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format("{0}='{1}'", convWebSrvFunctions.WebSrvClassId,
                strWebSrvClassId);

            System.Data.DataTable objDT = clsvWebSrvFunctionsBL.GetDataTable_vWebSrvFunctions(strCondition);
            objDDL.DataValueField = conWebSrvFunctions.WebSrvFunctionId;
            objDDL.DataTextField = conWebSrvFunctions.FunctionName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
    }
}