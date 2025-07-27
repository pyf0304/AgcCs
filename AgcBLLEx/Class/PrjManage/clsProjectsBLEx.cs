using AGC.BusinessLogic;

using AGC.DAL;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;


using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace AGC.BusinessLogicEx
{
    public static class clsProjectsBLEx_Static
    {
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
        /// </summary>
        /// <param name = "objProjectsENS">源对象</param>
        /// <param name = "objProjectsENT">目标对象</param>
        public static void CopyToEx(this clsProjectsEN objProjectsENS, clsProjectsENEx objProjectsENT)
        {
            try
            {
                clsProjectsBL.CopyTo(objProjectsENS, objProjectsENT);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000093)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
        /// </summary>
        /// <param name = "objProjectsENS">源对象</param>
        /// <returns>目标对象=>clsProjectsEN:objProjectsENT</returns>
        public static clsProjectsENEx CopyToEx(this clsProjectsEN objProjectsENS)
        {
            try
            {
                clsProjectsENEx objProjectsENT = new clsProjectsENEx();
                clsProjectsBL.CopyTo(objProjectsENS, objProjectsENT);
                return objProjectsENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000094)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

    }

    public partial class clsProjectsBLEx : clsProjectsBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsProjectsDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsProjectsDAEx ProjectsDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsProjectsDAEx();
                }
                return uniqueInstanceEx;
            }
        }


        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsProjectsENEx> GetObjExLst(string strCondition)
        {
            List<clsProjectsEN> arrObjLst = clsProjectsBL.GetObjLst(strCondition);
            List<clsProjectsENEx> arrObjExLst = new List<clsProjectsENEx>();
            foreach (clsProjectsEN objInFor in arrObjLst)
            {
                clsProjectsENEx objProjectsENEx = new clsProjectsENEx();
                clsProjectsBL.CopyTo(objInFor, objProjectsENEx);
                arrObjExLst.Add(objProjectsENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strPrjId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsProjectsENEx GetObjExByPrjId(string strPrjId)
        {
            clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjId(strPrjId);
            clsProjectsENEx objProjectsENEx = new clsProjectsENEx();
            clsProjectsBL.CopyTo(objProjectsEN, objProjectsENEx);
            return objProjectsENEx;
        }


    

        /// <summary>
        /// 从缓存中获取所有正在使用的工程对象列表.
        /// </summary>
        /// <returns>从缓存中获取所有正在使用的工程对象列表</returns>
        public static List<clsProjectsEN> GetAllProjectsObjLstCacheEx(string strUseStateId)
        {
           
            List<clsProjectsEN> arrObjLstCache = clsProjectsBL.GetObjLstCache();

            IEnumerable<clsProjectsEN> arrProjectsObjLst_Sel1 =
                from objProjectsEN in arrObjLstCache
                where objProjectsEN.UseStateId == strUseStateId
                select objProjectsEN;


            List<clsProjectsEN> arrProjectsObjLst_Sel = arrProjectsObjLst_Sel1.OrderBy(x=>x.PrjName).ToList();
            return arrProjectsObjLst_Sel;
        }

        /// <summary>
        /// 绑定基于Web的下拉框-使用Cache
        /// (AGC.BusinessLogicEx.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_PrjIdCacheEx(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            List<clsProjectsEN> arrProjectsObjLst = GetAllProjectsObjLstCacheEx("0001");//正在使用中的工程对象
            objDDL.DataValueField = conProjects.PrjId;
            objDDL.DataTextField = conProjects.PrjName;
            objDDL.DataSource = arrProjectsObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

     

        /// <summary>
        /// 设置工程使用
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static bool SetInUse(string strPrjId)
        {
            clsProjectsBL.SetFldValue(clsProjectsEN._CurrTabName, conProjects.UseStateId, "0001", string.Format("PrjId = '{0}'", strPrjId));

            return true;
        }

        /// <summary>
        /// 设置工程不使用
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static bool SetNotInUse(string strPrjId)
        {
            clsProjectsBL.SetFldValue(clsProjectsEN._CurrTabName, conProjects.UseStateId, "0002", string.Format("PrjId = '{0}'", strPrjId));

            return true;
        }
      
            /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsProjectsENEx GetProjectsENExObjByPrjId(string strPrjId)
        {
            List<clsProjectsEN> arrObjLstCache = clsProjectsBL.GetObjLstCache();

            foreach (clsProjectsEN objProjectsEN in arrObjLstCache)
            {
                if (objProjectsEN.PrjId == strPrjId)
                {
                    clsProjectsENEx objProjectsENEx = new clsProjectsENEx();
                    clsProjectsBL.CopyTo(objProjectsEN, objProjectsENEx);
                    return objProjectsENEx;
                }
            }
            return null;
        }
        
        //public clsPrjDataBaseEN objPrjDataBase = null;
        private int mintConnectWay;

        public int ConnectWay
        {
            get { return mintConnectWay; }
            set { mintConnectWay = value; }
        }
        ///// <summary>
        ///// 数据库类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
        ///// </summary>
        //public string DataBaseTypeId
        //{
        //    get
        //    {
        //        clsPrjDataBaseEN objPrjDataBase = new clsPrjDataBaseEN(objViewInfoENEx.PrjDataBaseId, true);
        //        return objPrjDataBase.DataBaseTypeId;
        //    }
        //}



        //public bool GetProjectsEx()
        //{
        //    //GetProjects();
        //    //objPrjDataBase = new clsPrjDataBaseEN(objViewInfoENEx.PrjDataBaseId, true);
        //    return true;
        //}
        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public System.Data.DataTable getTables(string strPrjDataBaseId)
        {

            return clsPrjDataBaseBLEx.getTables(strPrjDataBaseId);
        }
        /// <summary>
        /// 功能:获取给定表的所有字段名
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable getTabColumns(string strTabName, string strPrjDataBaseId)
        {

            return clsPrjDataBaseBLEx.getTabColumns(strTabName, strPrjDataBaseId);
        }


        /// <summary>
        /// 功能:同时删除多条记录
        /// </summary>
        /// <param name = "lstKey">给定的关键字值列表</param>
        /// <returns>返回删除是否成功?</returns>
        public static bool DelProjectsEx(List<string> lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsProjectsDA.GetSpecSQLObj();
            string strSQL;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < lstKey.Count; i++)
            {
                if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
                else strKeyList += "," + "'" + lstKey[i].ToString() + "'";
            }
            strSQL = "";
            //删除Projects本表中与当前对象有关的记录

            strSQL = strSQL + "Delete from ViewRegion where viewid  in (select ViewId from viewinfo where PrjId in (" + strKeyList + "));";
            strSQL = strSQL + "Delete from ViewOptSteps where viewid  in (select ViewId from viewinfo where PrjId in (" + strKeyList + "));";
            strSQL = strSQL + "Delete from ViewBtnOptSteps where viewid in (select ViewId from viewinfo where PrjId in (" + strKeyList + "));";
            strSQL = strSQL + "Delete from PrjTab where PrjId in (" + strKeyList + ");";
            strSQL = strSQL + "Delete from ViewInfo where PrjId in (" + strKeyList + ");";
            strSQL = strSQL + "Delete from Projects where PrjId in (" + strKeyList + ");";
            return objSQL.ExecSql(strSQL);
        }
        //同时删除多条记录
        public static bool p_Del_Projects(string strPrjId)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            ArrayList arrValue = new ArrayList();
            arrValue.Add(strPrjId);
            bool bolResult = objSQL.ExecSP2("p_Del_Projects", arrValue, 240);
            return bolResult;
        }

    }
}
