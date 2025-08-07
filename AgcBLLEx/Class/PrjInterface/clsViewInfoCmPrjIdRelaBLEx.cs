
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsViewInfoCmPrjIdRelaBLEx
表名:ViewInfoCmPrjIdRela(00050621)
* 版本:2023.02.24.1(服务器:WIN-SRV103-116)
日期:2023/03/01 22:26:53
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:界面管理(PrjInterface)
框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
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

using com.taishsoft.comm_db_obj;
using AGC.Entity;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;
using com.taishsoft.datetime;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_ViewInfoCmPrjIdRelaEx : RelatedActions_ViewInfoCmPrjIdRela
    {
        public override bool UpdRelaTabDate(string strViewId, string strCmPrjId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsViewInfoCmPrjIdRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objViewInfoCmPrjIdRelaENS">源对象</param>
        /// <returns>目标对象=>clsViewInfoCmPrjIdRelaEN:objViewInfoCmPrjIdRelaENT</returns>
        public static clsViewInfoCmPrjIdRelaENEx CopyToEx(this clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaENS)
        {
            try
            {
                clsViewInfoCmPrjIdRelaENEx objViewInfoCmPrjIdRelaENT = new clsViewInfoCmPrjIdRelaENEx();
                clsViewInfoCmPrjIdRelaBL.ViewInfoCmPrjIdRelaDA.CopyTo(objViewInfoCmPrjIdRelaENS, objViewInfoCmPrjIdRelaENT);
                return objViewInfoCmPrjIdRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objViewInfoCmPrjIdRelaENS">源对象</param>
        /// <returns>目标对象=>clsViewInfoCmPrjIdRelaEN:objViewInfoCmPrjIdRelaENT</returns>
        public static clsViewInfoCmPrjIdRelaEN CopyTo(this clsViewInfoCmPrjIdRelaENEx objViewInfoCmPrjIdRelaENS)
        {
            try
            {
                clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaENT = new clsViewInfoCmPrjIdRelaEN();
                clsViewInfoCmPrjIdRelaBL.CopyTo(objViewInfoCmPrjIdRelaENS, objViewInfoCmPrjIdRelaENT);
                return objViewInfoCmPrjIdRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 界面CmPrjId关系(ViewInfoCmPrjIdRela)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsViewInfoCmPrjIdRelaBLEx : clsViewInfoCmPrjIdRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsViewInfoCmPrjIdRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsViewInfoCmPrjIdRelaDAEx ViewInfoCmPrjIdRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsViewInfoCmPrjIdRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objViewInfoCmPrjIdRelaENS">源对象</param>
        /// <returns>目标对象=>clsViewInfoCmPrjIdRelaEN:objViewInfoCmPrjIdRelaENT</returns>
        public static clsViewInfoCmPrjIdRelaENEx CopyToEx(clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaENS)
        {
            try
            {
                clsViewInfoCmPrjIdRelaENEx objViewInfoCmPrjIdRelaENT = new clsViewInfoCmPrjIdRelaENEx();
                clsViewInfoCmPrjIdRelaBL.ViewInfoCmPrjIdRelaDA.CopyTo(objViewInfoCmPrjIdRelaENS, objViewInfoCmPrjIdRelaENT);
                return objViewInfoCmPrjIdRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
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
        public static List<clsViewInfoCmPrjIdRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsViewInfoCmPrjIdRelaEN> arrObjLst = clsViewInfoCmPrjIdRelaBL.GetObjLst(strCondition);
            List<clsViewInfoCmPrjIdRelaENEx> arrObjExLst = new List<clsViewInfoCmPrjIdRelaENEx>();
            foreach (clsViewInfoCmPrjIdRelaEN objInFor in arrObjLst)
            {
                clsViewInfoCmPrjIdRelaENEx objViewInfoCmPrjIdRelaENEx = new clsViewInfoCmPrjIdRelaENEx();
                clsViewInfoCmPrjIdRelaBL.CopyTo(objInFor, objViewInfoCmPrjIdRelaENEx);
                arrObjExLst.Add(objViewInfoCmPrjIdRelaENEx);
            }
            return arrObjExLst;
        }

        public static List<string> GetViewIdLstByCmPrjId(string strCmPrjId)
        {
            string strCondition = $"{conViewInfoCmPrjIdRela.CmPrjId} = '{strCmPrjId}'";
            var arrViewIdLst = clsViewInfoCmPrjIdRelaBL.GetFldValue(conViewInfoCmPrjIdRela.ViewId, strCondition);
            return arrViewIdLst;
        }

        public static List<string> GetViewIdLstByCmPrjIdCache(string strCmPrjId)
        {            
            var arrViewInfoCmPrjIdRela = clsViewInfoCmPrjIdRelaBL.GetObjLstCache(strCmPrjId);
            var arrViewIdLst = arrViewInfoCmPrjIdRela.Select(x=>x.ViewId).ToList();
            return arrViewIdLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strViewId">表关键字</param>
        /// <param name = "strCmPrjId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsViewInfoCmPrjIdRelaENEx GetObjExByKeyLst(string strViewId, string strCmPrjId)
        {
            clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRelaEN = clsViewInfoCmPrjIdRelaBL.GetObjByKeyLst(strViewId, strCmPrjId);
            clsViewInfoCmPrjIdRelaENEx objViewInfoCmPrjIdRelaENEx = new clsViewInfoCmPrjIdRelaENEx();
            clsViewInfoCmPrjIdRelaBL.CopyTo(objViewInfoCmPrjIdRelaEN, objViewInfoCmPrjIdRelaENEx);
            return objViewInfoCmPrjIdRelaENEx;
        }
        /// <summary>
        /// 建立Cm工程与表的关系
        /// </summary>
        /// <param name = "strCmPrjId">Cm工程Id</param>
        /// <param name = "strViewId">表Id</param>
        /// <param name = "strOpUser">操作用户</param>
        /// <returns>修改是否成功？</returns>
        public static bool CreateRela(string strCmPrjId, string strViewId, string strOpUserId)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRela = new clsViewInfoCmPrjIdRelaEN();
            string strCondition = objViewInfoCmPrjIdRela
            .SetViewId(strViewId, "=")
            .SetCmPrjId(strCmPrjId, "=")
            .GetCombineCondition();
            objViewInfoCmPrjIdRela._IsCheckProperty = true;
            bool bolIsExist = clsViewInfoCmPrjIdRelaBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                //objViewInfoCmPrjIdRela.mId = clsViewInfoCmPrjIdRelaBL.GetFirstID_S(strCondition);
                //objViewInfoCmPrjIdRela.UpdateWithCondition(strCondition);
            }
            else
            {
                //objViewInfoCmPrjIdRela.OrderNum = 1;
                objViewInfoCmPrjIdRela.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objViewInfoCmPrjIdRela.UpdUserId = strOpUserId;
                //var objCmProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
                //objViewInfoCmPrjIdRela.PrjId = objCmProject.PrjId;
                objViewInfoCmPrjIdRela.AddNewRecord();
            }
            return true;
        }

        /// <summary>
        /// 删除Cm工程与表的关系
        /// </summary>
        /// <param name = "strCmPrjId">Cm工程Id</param>
        /// <param name = "strTabId">表Id</param>
        /// <returns>删除记录数</returns>
        public static int DelRela(string strCmPrjId, string strViewId)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsViewInfoCmPrjIdRelaEN objViewInfoCmPrjIdRela = new clsViewInfoCmPrjIdRelaEN();
            string strCondition = objViewInfoCmPrjIdRela
            .SetViewId(strViewId, "=")
            .SetCmPrjId(strCmPrjId, "=")
            .GetCombineCondition();
            int intRecNum = clsViewInfoCmPrjIdRelaBL.DelViewInfoCmPrjIdRelasByCond(strCondition);
            return intRecNum;
        }


    }
}