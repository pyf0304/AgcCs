
///*-- -- -- -- -- -- -- -- -- -- --
//类名:clsCMProjectFuncModuleBLEx
//表名:CMProjectFuncModule(00050555)
//生成代码版本:2020.05.28.1
//生成日期:2020/06/02 12:30:10
//生成者:
//生成服务器IP:192.168.1.10
//工程名称:AGC
//工程ID:0005
//相关数据库:tzar.tpddns.cn,19433AGC_CS12
//PrjDataBaseId:0213
//模块中文名:代码管理
//模块英文名:CodeMan
//框架-层名:业务逻辑扩展层(BusinessLogicEx)
//编程语言:CSharp
//注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
//       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
//== == == == == == == == == == == == 
//*/
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

using System.Web.UI.WebControls;

namespace AGC.BusinessLogicEx
{
    //    public static class clsCMProjectFuncModuleBLEx_Static
    //    {

    //        /// <summary>
    //        /// 把同一个类的对象,复制到另一个对象
    //        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
    //        /// </summary>
    //        /// <param name = "objCMProjectFuncModuleENS">源对象</param>
    //        /// <returns>目标对象=>clsCMProjectFuncModuleEN:objCMProjectFuncModuleENT</returns>
    //        public static clsCMProjectFuncModuleENEx CopyToEx(this clsCMProjectFuncModuleEN objCMProjectFuncModuleENS)
    //        {
    //            try
    //            {
    //                clsCMProjectFuncModuleENEx objCMProjectFuncModuleENT = new clsCMProjectFuncModuleENEx();
    //                clsCMProjectFuncModuleBL.CMProjectFuncModuleDA.CopyTo(objCMProjectFuncModuleENS, objCMProjectFuncModuleENT);
    //                return objCMProjectFuncModuleENT;
    //            }
    //            catch (Exception objException)
    //            {
    //                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
    //                clsStackTrace.GetCurrClassFunction(),
    //                objException.Message);
    //                throw new Exception(strMsg);
    //            }
    //        }

    //        /// <summary>
    //        /// 把同一个类的对象,复制到另一个对象
    //        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
    //        /// </summary>
    //        /// <param name = "objCMProjectFuncModuleENS">源对象</param>
    //        /// <returns>目标对象=>clsCMProjectFuncModuleEN:objCMProjectFuncModuleENT</returns>
    //        public static clsCMProjectFuncModuleEN CopyTo(this clsCMProjectFuncModuleENEx objCMProjectFuncModuleENS)
    //        {
    //            try
    //            {
    //                clsCMProjectFuncModuleEN objCMProjectFuncModuleENT = new clsCMProjectFuncModuleEN();
    //                clsCMProjectFuncModuleBL.CopyTo(objCMProjectFuncModuleENS, objCMProjectFuncModuleENT);
    //                return objCMProjectFuncModuleENT;
    //            }
    //            catch (Exception objException)
    //            {
    //                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
    //                clsStackTrace.GetCurrClassFunction(),
    //                objException.Message);
    //                throw new Exception(strMsg);
    //            }
    //        }
    //    }
    /// <summary>
    /// CM项目模块关系(CMProjectFuncModule)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsCMProjectFuncModuleBLEx
    {

        //        /// <summary>
        //        /// 单例模式:访问数据访问扩展层的单例模式
        //        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        //        /// </summary>
        //        private static clsCMProjectFuncModuleDAEx uniqueInstanceEx = null;
        //        /// <summary>
        //        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        //        /// </summary>
        //        private static clsCMProjectFuncModuleDAEx CMProjectFuncModuleDAEx
        //        {
        //            get
        //            {
        //                if (uniqueInstanceEx == null)
        //                {
        //                    uniqueInstanceEx = new clsCMProjectFuncModuleDAEx();
        //                }
        //                return uniqueInstanceEx;
        //            }
        //        }

        //        /// <summary>
        //        /// 把同一个类的对象,复制到另一个对象
        //        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        //        /// </summary>
        //        /// <param name = "objCMProjectFuncModuleENS">源对象</param>
        //        /// <returns>目标对象=>clsCMProjectFuncModuleEN:objCMProjectFuncModuleENT</returns>
        //        public static clsCMProjectFuncModuleENEx CopyToEx(clsCMProjectFuncModuleEN objCMProjectFuncModuleENS)
        //        {
        //            try
        //            {
        //                clsCMProjectFuncModuleENEx objCMProjectFuncModuleENT = new clsCMProjectFuncModuleENEx();
        //                clsCMProjectFuncModuleBL.CMProjectFuncModuleDA.CopyTo(objCMProjectFuncModuleENS, objCMProjectFuncModuleENT);
        //                return objCMProjectFuncModuleENT;
        //            }
        //            catch (Exception objException)
        //            {
        //                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
        //                clsStackTrace.GetCurrClassFunction(),
        //                objException.Message);
        //                throw new Exception(strMsg);
        //            }
        //        }

        //        /// <summary>
        //        /// 根据条件获取扩展对象列表
        //        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        //        /// </summary>
        //        /// <param name = "strCondition">给定条件</param>
        //        /// <returns>返回扩展对象列表</returns>
        //        public static List<clsCMProjectFuncModuleENEx> GetObjExLst(string strCondition)
        //        {
        //            List<clsCMProjectFuncModuleEN> arrObjLst = clsCMProjectFuncModuleBL.GetObjLst(strCondition);
        //            List<clsCMProjectFuncModuleENEx> arrObjExLst = new List<clsCMProjectFuncModuleENEx>();
        //            foreach (clsCMProjectFuncModuleEN objInFor in arrObjLst)
        //            {
        //                clsCMProjectFuncModuleENEx objCMProjectFuncModuleENEx = new clsCMProjectFuncModuleENEx();
        //                clsCMProjectFuncModuleBL.CopyTo(objInFor, objCMProjectFuncModuleENEx);
        //                arrObjExLst.Add(objCMProjectFuncModuleENEx);
        //            }
        //            return arrObjExLst;
        //        }

        //        /// <summary>
        //        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        //        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        //        /// </summary>
        //        /// <param name = "lngmId">表关键字</param>
        //        /// <returns>表扩展对象</returns>
        //        public static clsCMProjectFuncModuleENEx GetObjExBymId(long lngmId)
        //        {
        //            clsCMProjectFuncModuleEN objCMProjectFuncModuleEN = clsCMProjectFuncModuleBL.GetObjBymId(lngmId);
        //            clsCMProjectFuncModuleENEx objCMProjectFuncModuleENEx = new clsCMProjectFuncModuleENEx();
        //            clsCMProjectFuncModuleBL.CopyTo(objCMProjectFuncModuleEN, objCMProjectFuncModuleENEx);
        //            return objCMProjectFuncModuleENEx;
        //        }

        public static void BindDdl_FuncModuleId(System.Web.UI.WebControls.DropDownList objDDL, string strCmPrjId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            //            System.Data.DataTable objDT = GetFuncModuleId(strCurrSelPrjId, strPrjDataBaseId);
            var strCurrSelPrjId = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            var arrCMProjectPrjTab = clsvCmProjectPrjTabBL.GetObjLstCache(strCurrSelPrjId);
            var arrFuncModuleAgcId_Sel = arrCMProjectPrjTab.Where(x => x.CmPrjId == strCmPrjId).Select(x => x.FuncModuleAgcId);
       
            List<clsFuncModule_AgcEN> arrFuncModule_AgcObjLst = clsFuncModule_AgcBL.GetObjLstCache(strCurrSelPrjId);
            var arrFuncModule_Agc_Sel = arrFuncModule_AgcObjLst.Where(x => arrFuncModuleAgcId_Sel.Contains(x.FuncModuleAgcId)).OrderBy(x => x.FuncModuleName);

            objDDL.DataValueField = "FuncModuleAgcId";
            objDDL.DataTextField = "FuncModuleName";
            objDDL.DataSource = arrFuncModule_Agc_Sel;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


    }
}