using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 系统缺省值名称业务逻辑层的扩展类
    /// </summary>
    public class clsvPrjTab4DdlBLEx: clsvPrjTab4DdlBL
    {
        public static string strPrjIdCache_Init = "";
        /// <summary>
        /// 从缓存中获取满足条件所有【工程表】对象列表.
        /// </summary>
        /// <param name = "strPrjId">工程</param>      
        /// <returns>从缓存中获取所有正在使用的用户缺省值列表</returns>
        public static List<clsvPrjTab4DdlEN> GetAllvPrjTab4DdlObjLstCacheEx(string strPrjId)
        {
           List<clsvPrjTab4DdlEN> arrObjLstCache = clsvPrjTab4DdlBL.GetObjLstCache(strPrjId);

            IEnumerable<clsvPrjTab4DdlEN> arrvPrjTab4DdlObjLst_Sel1 =
                from objvPrjTab4DdlEN in arrObjLstCache
                where objvPrjTab4DdlEN.PrjId == strPrjId
                select objvPrjTab4DdlEN;


            List<clsvPrjTab4DdlEN> arrvPrjTab4DdlObjLst_Sel = new List<clsvPrjTab4DdlEN>();
            foreach (clsvPrjTab4DdlEN obj in arrvPrjTab4DdlObjLst_Sel1)
            {
                arrvPrjTab4DdlObjLst_Sel.Add(obj);
            }

            return arrvPrjTab4DdlObjLst_Sel;
        }


        /// <summary>
        /// 从缓存中获取满足条件所有【工程表】对象列表.
        /// </summary>
        /// <param name = "strPrjId">工程</param>      
        /// <returns>从缓存中获取所有正在使用的用户缺省值列表</returns>
        public static List<clsvPrjTab4DdlEN> GetAllvPrjTab4DdlObjLstCacheEx(string strPrjId, string strSqlDsTypeId)
        {
            List<clsvPrjTab4DdlEN> arrObjLstCache = clsvPrjTab4DdlBL.GetObjLstCache(strPrjId);
                       
            IEnumerable<clsvPrjTab4DdlEN> arrvPrjTab4DdlObjLst_Sel1 =
                from objvPrjTab4DdlEN in arrObjLstCache
                where objvPrjTab4DdlEN.PrjId == strPrjId
                 && objvPrjTab4DdlEN.SqlDsTypeId == strSqlDsTypeId

                select objvPrjTab4DdlEN;


            List<clsvPrjTab4DdlEN> arrvPrjTab4DdlObjLst_Sel = new List<clsvPrjTab4DdlEN>();
            foreach (clsvPrjTab4DdlEN obj in arrvPrjTab4DdlObjLst_Sel1)
            {
                arrvPrjTab4DdlObjLst_Sel.Add(obj);
            }

            return arrvPrjTab4DdlObjLst_Sel;
        }


        /// <summary>
        /// 从缓存中获取某模块的【工程表】对象列表.
        /// </summary>
        /// <param name = "strPrjId">工程</param>      
        /// <returns>从缓存中获取某模块的【工程表】对象列表</returns>
        public static List<clsvPrjTab4DdlEN> GetAllvPrjTab4DdlObjLstByFuncModuleIdCacheEx(string strPrjId, string strFuncModuleAgcId)
        {
            List<clsvPrjTab4DdlEN> arrObjLstCache = clsvPrjTab4DdlBL.GetObjLstCache(strPrjId);

            IEnumerable<clsvPrjTab4DdlEN> arrvPrjTab4DdlObjLst_Sel1 =
                from objvPrjTab4DdlEN in arrObjLstCache
                where objvPrjTab4DdlEN.PrjId == strPrjId
                 && objvPrjTab4DdlEN.FuncModuleAgcId == strFuncModuleAgcId

                select objvPrjTab4DdlEN;


            List<clsvPrjTab4DdlEN> arrvPrjTab4DdlObjLst_Sel = new List<clsvPrjTab4DdlEN>();
            foreach (clsvPrjTab4DdlEN obj in arrvPrjTab4DdlObjLst_Sel1)
            {
                arrvPrjTab4DdlObjLst_Sel.Add(obj);
            }

            return arrvPrjTab4DdlObjLst_Sel;
        }



        //public static System.Data.DataTable GetPrjTabViewId(string strPrjId)
        //{
        //    //获取某学院所有专业信息
        //    string strSQL = string.Format("select TabId, TabName from PrjTab where PrjId = '{0}' order by TabName", strPrjId);
        //    clsSpecSQLforSql mySql = new clsSpecSQLforSql();
        //    System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
        //    return objDT;
        //}
      
        
        public static System.Data.DataTable GetTabId(string strPrjId, string strFuncModuleId)
        {
            //获取某学院所有专业信息
            string strSQL = "select TabId, TabName from PrjTab where PrjId = '" + strPrjId + "' and  FuncModuleAgcId = '" + strFuncModuleId + "'";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
   
        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_InitListCache)
        /// </summary>
        //public static void InitListCache(string strPrjId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    //if (clsvPrjTab4DdlBL.objCommFun4BL == null)
        //    //{
        //    //    strMsg = string.Format("类clsvPrjTab4DdlBL没有刷新缓存机制(clsvPrjTab4DdlBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //    //    throw new Exception(strMsg);
        //    //}
        //    if (strPrjIdCache_Init != strPrjId) arrvPrjTab4DdlObjLstCache = null;

        //    //初始化列表缓存
        //    if (arrvPrjTab4DdlObjLstCache == null)
        //    {
        //        string strWhereCond = string.Format("{0} = '{1}' order by TabId",
        //            convPrjTab4Ddl.PrjId, strPrjId);

        //        arrvPrjTab4DdlObjLstCache = clsvPrjTab4DdlBL.GetObjLst(strWhereCond);

        //        strMsg = string.Format("初始化成功！strPrjId={0}，strPrjIdCache_Init={1}.({4}->{3}->{2})",
        //            strPrjId, strPrjIdCache_Init,
        //            clsStackTrace.GetCurrClassFunction(),
        //            clsStackTrace.GetCurrClassFunctionByLevel(2),
        //            clsStackTrace.GetCurrClassFunctionByLevel(3));
        //        clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
        //        strPrjIdCache_Init = strPrjId;
        //    }
        //}
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsvPrjTab4DdlEN> GetvPrjTab4DdlObjLstByPrjIdCacheExBak(string strPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true) return null;
            List<clsvPrjTab4DdlEN> arrObjLstCache = clsvPrjTab4DdlBL.GetObjLstCache(strPrjId).OrderBy(x=>x.TabId).ToList();

            return arrObjLstCache;
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strTabId">所给的关键字</param>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsvPrjTab4DdlEN GetvPrjTab4DdlObjByTabIdCacheExBak(string strTabId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strTabId) == true) return null;
            //string strCondition = string.Format("{0} = '{1}' order by TabId", convPrjTab4Ddl.PrjId, strPrjId);
            //if (arrvPrjTab4DdlObjLstCacheEx  ==  null)
            //{
            //    arrvPrjTab4DdlObjLstCacheEx = new clsvPrjTab4DdlDA().GetObjLst(strCondition);
            //}
            List<clsvPrjTab4DdlEN> arrObjLstCache = clsvPrjTab4DdlBL.GetObjLstCache(strPrjId);

            IEnumerable<clsvPrjTab4DdlEN> arrvPrjTab4DdlObjLst_Sel1 =
                from objvPrjTab4DdlEN in arrObjLstCache
                where objvPrjTab4DdlEN.TabId == strTabId
                select objvPrjTab4DdlEN;
            List<clsvPrjTab4DdlEN> arrvPrjTab4DdlObjLst_Sel = new List<clsvPrjTab4DdlEN>();
            foreach (clsvPrjTab4DdlEN obj in arrvPrjTab4DdlObjLst_Sel1)
            {
                arrvPrjTab4DdlObjLst_Sel.Add(obj);
            }
            if (arrvPrjTab4DdlObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrvPrjTab4DdlObjLst_Sel[0];
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strSqlDsTypeId">所给的关键字</param>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsvPrjTab4DdlEN> GetvPrjTab4DdlObjLstBySqlDsTypeIdExCacheBak(string strSqlDsTypeId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strSqlDsTypeId) == true) return null;
            //string strCondition = string.Format("{0} = '{1}' order by TabId", convPrjTab4Ddl.PrjId, strPrjId);
            //if (arrvPrjTab4DdlObjLstCacheEx  ==  null)
            //{
            //    arrvPrjTab4DdlObjLstCacheEx = new clsvPrjTab4DdlDA().GetObjLst(strCondition);
            //}
            List<clsvPrjTab4DdlEN> arrObjLstCache = clsvPrjTab4DdlBL.GetObjLstCache(strPrjId);

            IEnumerable<clsvPrjTab4DdlEN> arrvPrjTab4DdlObjLst_Sel1 =
                from objvPrjTab4DdlEN in arrObjLstCache
                where objvPrjTab4DdlEN.SqlDsTypeId == strSqlDsTypeId
                select objvPrjTab4DdlEN;
            List<clsvPrjTab4DdlEN> arrvPrjTab4DdlObjLst_Sel = new List<clsvPrjTab4DdlEN>();
            foreach (clsvPrjTab4DdlEN obj in arrvPrjTab4DdlObjLst_Sel1)
            {
                arrvPrjTab4DdlObjLst_Sel.Add(obj);
            }
            if (arrvPrjTab4DdlObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrvPrjTab4DdlObjLst_Sel;
        }


        public static void BindLB_TabId(System.Web.UI.WebControls.ListBox objLB, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            //            System.Data.DataTable objDT = GetObjId(strPrjId);
            List<clsvPrjTab4DdlEN> arrvPrjTab4DdlObjLst = GetAllvPrjTab4DdlObjLstCacheEx(strPrjId);

            objLB.DataValueField = convPrjTab4Ddl.TabId;
            objLB.DataTextField = convPrjTab4Ddl.TabName;
            objLB.DataSource = arrvPrjTab4DdlObjLst;
            objLB.DataBind();
            objLB.Items.Insert(0, li);
            objLB.SelectedIndex = 0;
        }

      
    }
}
