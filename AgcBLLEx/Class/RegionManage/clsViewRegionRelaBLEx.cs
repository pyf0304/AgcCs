
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsViewRegionRelaBLEx
表名:ViewRegionRela(00050573)
生成代码版本:2020.09.24.1
生成日期:2020/10/01 16:09:05
生成者:pyf
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:区域管理
模块英文名:RegionManage
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
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

namespace AGC.BusinessLogicEx
{
    public static class clsViewRegionRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objViewRegionRelaENS">源对象</param>
        /// <returns>目标对象=>clsViewRegionRelaEN:objViewRegionRelaENT</returns>
        public static clsViewRegionRelaENEx CopyToEx(this clsViewRegionRelaEN objViewRegionRelaENS)
        {
            try
            {
                clsViewRegionRelaENEx objViewRegionRelaENT = new clsViewRegionRelaENEx();
                clsViewRegionRelaBL.ViewRegionRelaDA.CopyTo(objViewRegionRelaENS, objViewRegionRelaENT);
                return objViewRegionRelaENT;
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
        /// <param name = "objViewRegionRelaENS">源对象</param>
        /// <returns>目标对象=>clsViewRegionRelaEN:objViewRegionRelaENT</returns>
        public static clsViewRegionRelaEN CopyTo(this clsViewRegionRelaENEx objViewRegionRelaENS)
        {
            try
            {
                clsViewRegionRelaEN objViewRegionRelaENT = new clsViewRegionRelaEN();
                clsViewRegionRelaBL.CopyTo(objViewRegionRelaENS, objViewRegionRelaENT);
                return objViewRegionRelaENT;
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
    /// 界面区域关系(ViewRegionRela)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsViewRegionRelaBLEx : clsViewRegionRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsViewRegionRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsViewRegionRelaDAEx ViewRegionRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsViewRegionRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objViewRegionRelaENS">源对象</param>
        /// <returns>目标对象=>clsViewRegionRelaEN:objViewRegionRelaENT</returns>
        public static clsViewRegionRelaENEx CopyToEx(clsViewRegionRelaEN objViewRegionRelaENS)
        {
            try
            {
                clsViewRegionRelaENEx objViewRegionRelaENT = new clsViewRegionRelaENEx();
                clsViewRegionRelaBL.ViewRegionRelaDA.CopyTo(objViewRegionRelaENS, objViewRegionRelaENT);
                return objViewRegionRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsViewRegionRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsViewRegionRelaEN> arrObjLst = clsViewRegionRelaBL.GetObjLst(strCondition);
            List<clsViewRegionRelaENEx> arrObjExLst = new List<clsViewRegionRelaENEx>();
            foreach (clsViewRegionRelaEN objInFor in arrObjLst)
            {
                clsViewRegionRelaENEx objViewRegionRelaENEx = new clsViewRegionRelaENEx();
                clsViewRegionRelaBL.CopyTo(objInFor, objViewRegionRelaENEx);
                arrObjExLst.Add(objViewRegionRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsViewRegionRelaENEx GetObjExBymId(long lngmId)
        {
            clsViewRegionRelaEN objViewRegionRelaEN = clsViewRegionRelaBL.GetObjBymId(lngmId);
            clsViewRegionRelaENEx objViewRegionRelaENEx = new clsViewRegionRelaENEx();
            clsViewRegionRelaBL.CopyTo(objViewRegionRelaEN, objViewRegionRelaENEx);
            return objViewRegionRelaENEx;
        }

        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        /// <param name = "strViewId">界面Id</param>
        //public static void BindCbo_RegionId(System.Windows.Forms.ComboBox objComboBox, string strViewId)
        //{
        //    //为数据源为表的下拉框设置内容
        //    string strCondition = string.Format("1 =1 Order By {0}", clsViewRegionEN.con_RegionId);
        //    List<clsViewRegionEN> arrObjLst = clsViewRegionBL.GetObjLst(strCondition);
        //    arrObjLst = arrObjLst.Where(x => x.ViewId == strViewId).ToList();
        //    //初始化一个对象列表
        //    //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
        //    clsViewRegionEN objViewRegionEN = new clsViewRegionEN()
        //    {
        //        RegionId = "0",
        //        RegionName = "选[界面区域]..."
        //    };
        //    arrObjLst.Insert(0, objViewRegionEN);
        //    //设置下拉框的数据源、以及设置值项、显示项
        //    objComboBox.ValueMember = clsViewRegionEN.con_RegionId;
        //    objComboBox.DisplayMember = clsViewRegionEN.con_RegionName;
        //    objComboBox.DataSource = arrObjLst;
        //    objComboBox.SelectedIndex = 0;
        //}

        ///// <summary>
        ///// 绑定基于Web的下拉框
        ///// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
        ///// </summary>
        ///// <param name = "objDDL">需要绑定当前表的下拉框</param>
        ///// <param name = "strViewId">界面Id</param>
        //public static void BindDdl_RegionId(System.Web.UI.WebControls.DropDownList objDDL, string strViewId)
        //{
        //    //为数据源于表的下拉框设置内容
        //    System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面区域]...", "0");
        //    string strCondition = string.Format("1 =1 Order By {0}", clsViewRegionEN.con_RegionId);
        //    IEnumerable<clsViewRegionEN> arrObjLst = clsViewRegionBL.GetObjLst(strCondition);
        //    arrObjLst = arrObjLst.Where(x => x.ViewId == strViewId);
        //    objDDL.DataValueField = clsViewRegionEN.con_RegionId;
        //    objDDL.DataTextField = clsViewRegionEN.con_RegionName;
        //    objDDL.DataSource = arrObjLst;
        //    objDDL.DataBind();
        //    objDDL.Items.Insert(0, li);
        //    objDDL.SelectedIndex = 0;
        //}

        /// <summary>
        /// 根据界面Id获取相关区域对象列表
        /// </summary>
        /// <param name="strViewId"></param>
        /// <returns>区域对象列表</returns>
        public static List<clsViewRegionRelaEN> GetObjLstByViewId(string strViewId)
        {
            string strCondition = string.Format("{0}='{1}'", conViewRegionRela.ViewId, strViewId);
            List<clsViewRegionRelaEN> arrObjLst = clsViewRegionRelaBL.GetObjLst(strCondition);
            return arrObjLst;
        }
        public static List<clsViewRegionRelaEN> GetObjLstByViewIdCache(string strViewId, string strPrjId)
        {
            List<clsViewRegionRelaEN> arrObjLst = clsViewRegionRelaBL.GetObjLstCache(strPrjId);

            List<clsViewRegionRelaEN> arrObjLst_Sel = arrObjLst.Where(x=>x.ViewId == strViewId).ToList();
            return arrObjLst_Sel;
        }

        public static clsViewRegionRelaEN GetObjByViewIdAndRegionId(string strViewId, string strRegionId)
        {
            string strCondition = string.Format("{0}='{1}' and {2}='{3}'", conViewRegionRela.ViewId, strViewId, conViewRegionRela.RegionId, strRegionId);
            clsViewRegionRelaEN obj = clsViewRegionRelaBL.GetFirstObj_S(strCondition);
            return obj;
        }

        public static int DeleteByViewIdAndRegionId(string strViewId, string strRegionId)
        {
            string strCondition = string.Format("{0}='{1}' and {2}='{3}'", conViewRegionRela.ViewId, strViewId, conViewRegionRela.RegionId, strRegionId);

            int intRecNum = clsViewRegionRelaBL.DelViewRegionRelasByCond(strCondition);
            return intRecNum;
        }
        public static clsViewRegionRelaEN GetObjByViewIdAndRegionIdCache(string strViewId, string strRegionId, string strCmPrjId, string strPrjId)
        {
            string strCondition = string.Format("{0}='{1}' and {2}='{3}'", conViewRegionRela.ViewId, strViewId, conViewRegionRela.RegionId, strRegionId);
            var arrObjLst = clsViewRegionRelaBL.GetObjLstCache(strCmPrjId);
            var arrObjLst_Sel = arrObjLst.Where(x=>x.ViewId == strViewId && x.RegionId == strRegionId).ToList();
            if (arrObjLst_Sel.Count == 0) return null;
            return arrObjLst_Sel[0];
        }
        /// <summary>
        /// 根据界面Id获取相关区域对象列表
        /// </summary>
        /// <param name="strViewId"></param>
        /// <returns>区域对象列表</returns>
        public static List<string> GetRegionIdLstByViewId(string strViewId)
        {
            string strCondition = string.Format("{0}='{1}'", conViewRegionRela.ViewId, strViewId);
            List<clsViewRegionRelaEN> arrObjLst = clsViewRegionRelaBL.GetObjLst(strCondition);
            if (arrObjLst.Count == 0) return new List<string>();
            return arrObjLst.Select(x=>x.RegionId).ToList();
        }

        public static List<string> GetRegionIdLstByViewIdAndRegionTypeId(string strViewId, string strRegionTypeId)
        {
            string strCondition = $"{conViewRegionRela.ViewId}='{strViewId}' and {conViewRegionRela.RegionId} in (select {conViewRegion.RegionId} from {conViewRegion._CurrTabName} where {conViewRegion.RegionTypeId} = '{strRegionTypeId}')";
            List<clsViewRegionRelaEN> arrObjLst = clsViewRegionRelaBL.GetObjLst(strCondition);
            if (arrObjLst.Count == 0) return new List<string>();
            return arrObjLst.Select(x => x.RegionId).ToList();
        }

        /// <summary>
        /// 根据界面Id获取相关区域数
        /// </summary>
        /// <param name="strViewId"></param>
        /// <returns>区域数</returns>
        public static int GetRegionNumByViewId(string strViewId)
        {
            string strCondition = string.Format("{0}='{1}'", conViewRegionRela.ViewId, strViewId);
            int intRegionNum = clsViewRegionRelaBL.GetRecCountByCond(strCondition);

            return intRegionNum;
        }
        public static bool CheckDuplicate(clsViewRegionRelaEN objViewRegionRelaEN)
        {
            StringBuilder sbWhereCond = new StringBuilder();
            sbWhereCond.AppendFormat("ViewId = '{0}'", objViewRegionRelaEN.ViewId);
            sbWhereCond.AppendFormat("And RegionId = '{0}'", objViewRegionRelaEN.RegionId);
            return clsViewRegionRelaBL.IsExistRecord(sbWhereCond.ToString());
        }

        public static List<string> GetRegionIdLstByViewIdCache(string strViewId, string strPrjId)
        {
            //string strCondition = string.Format("{0}='{1}'", conViewRegionRela.ViewId, strViewId);
            IEnumerable<clsViewRegionRelaEN> arrObjLstCache = clsViewRegionRelaBL.GetObjLstCache(strPrjId);
            IEnumerable<clsViewRegionRelaEN> arrObjLst = arrObjLstCache.Where(x => x.ViewId == strViewId);
            List<string> arrRegionId = arrObjLst.Select(x => x.RegionId).ToList();
            //List<string> arrRegionId  = clsViewRegionRelaBL.GetPrimaryKeyID_S(strCondition).Select(x => long.Parse(x)).ToList();
            return arrRegionId;
        }

        public static List<string> GetViewIdLstByRegionIdCache(string strRegionId, string strPrjId)
        {
            //string strCondition = string.Format("{0}='{1}'", conViewRegionRela.ViewId, strViewId);
            IEnumerable<clsViewRegionRelaEN> arrObjLstCache = clsViewRegionRelaBL.GetObjLstCache(strPrjId);
            IEnumerable<clsViewRegionRelaEN> arrObjLst = arrObjLstCache.Where(x => x.RegionId == strRegionId);
            List<string> arrViewId = arrObjLst.Select(x => x.ViewId).ToList();
            //List<string> arrRegionId  = clsViewRegionRelaBL.GetPrimaryKeyID_S(strCondition).Select(x => long.Parse(x)).ToList();
            return arrViewId;
        }
        public static bool AddRelaRegion(string strViewId, string strRegionId, string strPrjId, string strOpUserId)
        {
       
            if (string.IsNullOrEmpty(strViewId))
            {
       throw new Exception("界面Id不能为空！");
                
            }
            if (string.IsNullOrEmpty(strRegionId))
            {
                throw new Exception("区域Id不能为空！");
            }
            clsViewRegionRelaEN objViewRegionRelaEN = new clsViewRegionRelaEN();    //初始化新对象

            objViewRegionRelaEN.RegionId = strRegionId;
            objViewRegionRelaEN.ViewId = strViewId;
            objViewRegionRelaEN.PrjId = strPrjId;
            objViewRegionRelaEN.InUse = true;
            objViewRegionRelaEN.IsDisp = true;
            objViewRegionRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
            objViewRegionRelaEN.UpdUser = strOpUserId;
            return objViewRegionRelaEN.EditRecordEx();
        }


    }
}