
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsViewMasterBLEx
表名:ViewMaster(00050557)
生成代码版本:2020.05.28.1
生成日期:2020/06/03 15:49:30
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:界面管理
模块英文名:PrjInterface
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


namespace AGC.BusinessLogicEx
{
    public static class clsViewMasterBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objViewMasterENS">源对象</param>
        /// <returns>目标对象=>clsViewMasterEN:objViewMasterENT</returns>
        public static clsViewMasterENEx CopyToEx(this clsViewMasterEN objViewMasterENS)
        {
            try
            {
                clsViewMasterENEx objViewMasterENT = new clsViewMasterENEx();
                clsViewMasterBL.ViewMasterDA.CopyTo(objViewMasterENS, objViewMasterENT);
                return objViewMasterENT;
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
        /// <param name = "objViewMasterENS">源对象</param>
        /// <returns>目标对象=>clsViewMasterEN:objViewMasterENT</returns>
        public static clsViewMasterEN CopyTo(this clsViewMasterENEx objViewMasterENS)
        {
            try
            {
                clsViewMasterEN objViewMasterENT = new clsViewMasterEN();
                clsViewMasterBL.CopyTo(objViewMasterENS, objViewMasterENT);
                return objViewMasterENT;
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
    /// 界面母版(ViewMaster)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsViewMasterBLEx : clsViewMasterBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsViewMasterDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsViewMasterDAEx ViewMasterDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsViewMasterDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objViewMasterENS">源对象</param>
        /// <returns>目标对象=>clsViewMasterEN:objViewMasterENT</returns>
        public static clsViewMasterENEx CopyToEx(clsViewMasterEN objViewMasterENS)
        {
            try
            {
                clsViewMasterENEx objViewMasterENT = new clsViewMasterENEx();
                clsViewMasterBL.ViewMasterDA.CopyTo(objViewMasterENS, objViewMasterENT);
                return objViewMasterENT;
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
        public static List<clsViewMasterENEx> GetObjExLst(string strCondition)
        {
            List<clsViewMasterEN> arrObjLst = clsViewMasterBL.GetObjLst(strCondition);
            List<clsViewMasterENEx> arrObjExLst = new List<clsViewMasterENEx>();
            foreach (clsViewMasterEN objInFor in arrObjLst)
            {
                clsViewMasterENEx objViewMasterENEx = new clsViewMasterENEx();
                clsViewMasterBL.CopyTo(objInFor, objViewMasterENEx);
                arrObjExLst.Add(objViewMasterENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strViewMasterId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsViewMasterENEx GetObjExByViewMasterId(string strViewMasterId)
        {
            clsViewMasterEN objViewMasterEN = clsViewMasterBL.GetObjByViewMasterId(strViewMasterId);
            clsViewMasterENEx objViewMasterENEx = new clsViewMasterENEx();
            clsViewMasterBL.CopyTo(objViewMasterEN, objViewMasterENEx);
            return objViewMasterENEx;
        }

        /// <summary>
        /// 绑定基于Web的下拉框-使用Cache
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_ViewMasterIdCacheEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId, int intApplicationTypeId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[界面母版]...", "0");
            List<clsViewMasterEN> arrViewMasterObjLst = GetAllViewMasterObjLstCache(strPrjId);

            var arrViewMasterObjLst_Sel = arrViewMasterObjLst.Where(x=>x.ApplicationTypeId == intApplicationTypeId);
            if (arrViewMasterObjLst_Sel.Count() == 0) return;
            objDDL.DataValueField = conViewMaster.ViewMasterId;
            objDDL.DataTextField = conViewMaster.ViewMasterName;
            objDDL.DataSource = arrViewMasterObjLst_Sel;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
    }
}