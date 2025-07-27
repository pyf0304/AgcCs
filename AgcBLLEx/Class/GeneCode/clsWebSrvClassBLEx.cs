
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsWebSrvClassBLEx
表名:WebSrvClass
生成代码版本:2017.05.18.1
生成日期:2017/05/19 17:35:06
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
    /// WebSrv类(WebSrvClass)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsWebSrvClassBLEx : clsWebSrvClassBL
    {
        public static string strPrjIdCache_Init = "";
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsWebSrvClassDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsWebSrvClassDAEx WebSrvClassDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsWebSrvClassDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_WebSrvClassIdByPrjId(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format("{0}='{1}'", conWebSrvClass.PrjId, strPrjId);
            System.Data.DataTable objDT = GetDataTable_WebSrvClass(strCondition);
            objDDL.DataValueField = conWebSrvClass.WebSrvClassId;
            objDDL.DataTextField = conWebSrvClass.ClsName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static bool p_Init_Log4GC_WebSrvClass(string strPrjId, string strUserId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsElecDictDA.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strPrjId);
            values.Add(strUserId);
            objSQL.ExecSP2("p_Init_Log4GC_WebSrvClass", values);
            return true;
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strTabId">所给的关键字</param>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsWebSrvClassEN GetWebSrvClassObjByWebSrvClassIdCacheEx(string strWebSrvClassId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strWebSrvClassId) == true) return null;
            //string strCondition = string.Format("{0} = '{1}' order by WebSrvClassId", conWebSrvClass.PrjId, strPrjId);
            //if (arrWebSrvClassObjLstCacheEx  ==  null)
            //{
            //    arrWebSrvClassObjLstCacheEx = new clsWebSrvClassDA().GetObjLst(strCondition);
            //}
            List<clsWebSrvClassEN> arrObjLstCache = clsWebSrvClassBL.GetObjLstCache(strPrjId);

            IEnumerable<clsWebSrvClassEN> arrWebSrvClassObjLst_Sel1 =
                from objWebSrvClassEN in arrObjLstCache
                where objWebSrvClassEN.WebSrvClassId == strWebSrvClassId
                select objWebSrvClassEN;
            List<clsWebSrvClassEN> arrWebSrvClassObjLst_Sel = new List<clsWebSrvClassEN>();
            foreach (clsWebSrvClassEN obj in arrWebSrvClassObjLst_Sel1)
            {
                arrWebSrvClassObjLst_Sel.Add(obj);
            }
            if (arrWebSrvClassObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrWebSrvClassObjLst_Sel[0];
        }

        ///// <summary>
        ///// 初始化列表缓存.
        ///// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_InitListCache)
        ///// </summary>
        //public static void InitListCache(string strPrjId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clsWebSrvClassBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsWebSrvClassBL没有刷新缓存机制(clsWebSrvClassBL.objCommFun4BL == null), 请联系程序员！({1}->{0})", clsStackTrace.GetCurrClassFunction(), clsStackTrace.GetCurrClassFunctionByLevel(2));
        //        throw new Exception(strMsg);
        //    }
        //    if (strPrjIdCache_Init != strPrjId) arrWebSrvClassObjLstCache = null;

        //    //初始化列表缓存
        //    //string strWhereCond = string.Format("1 = 1 order by WebSrvClassId");
        //    if (arrWebSrvClassObjLstCache == null)
        //    {
        //        string strWhereCond = string.Format("{0} = '{1}' order by {2}",
        //         conWebSrvClass.PrjId, strPrjId, conWebSrvClass.WebSrvClassId);

        //        arrWebSrvClassObjLstCache = new clsWebSrvClassDA().GetObjLst(strWhereCond);
        //        strPrjIdCache_Init = strPrjId;
        //    }
        //}
    }
}