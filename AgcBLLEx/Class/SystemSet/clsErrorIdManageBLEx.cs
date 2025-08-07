using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public class clsErrorIdManageBLEx : clsErrorIdManageBL
    {
        public static string strPrjIdCache_Init = "";
        /// <summary>
        /// 静态的错误Id(ErrId)列表,用于缓存,检查是否重复
        /// </summary>
        public static List<string > arrErrIdLstCache = null;

        public static void InitCache4ErrIdLst()
        {
            arrErrIdLstCache = new List<string>();
        }


        /// <summary>
        /// 获取当前表最大字符型关键字ID
        /// </summary>
        /// <returns>返回的最大关键字值ID</returns>
        public static string GetMaxErrId(string strCodeTypeId)
        {
          
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
    
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsErrorIdManageDA.GetSpecSQLObj();
            string strMaxValue = objSQL.GetMaxStrId(clsErrorIdManageEN._CurrTabName, conErrorIdManage.ErrID, 10, objCodeTypeEN.Prefix);
            return strMaxValue;
        }
        ///// <summary>
        ///// 获取当前表最大字符型关键字ID
        ///// </summary>
        ///// <returns>返回的最大关键字值ID</returns>



        /// <summary>
        /// 获取最大错误Id , 并添加到数据表中
        /// </summary>
        /// <param name = "strCodeTypeId">程序分层类型Id</param>
        /// <param name = "strPrjId"></param>
        /// <param name = "strClassName"></param>
        /// <param name = "strFunctionName"></param>
        /// <param name = "strExplanation">详细说明</param>
        /// <param name = "strUserId"></param>
        /// <returns></returns>
        public static string GetMaxErrIdWithAddRec(string strCodeTypeId, string strPrjId,
            string strClassName, string strFunctionName, string strExplanation, string strUserId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("{0} = '{1}'", conErrorIdManage.CodeTypeId, strCodeTypeId);
            //sbCondition.AppendFormat(" And {0} = '{1}'", conErrorIdManage.PrjId, strPrjId);
            //sbCondition.AppendFormat(" And {0} = '{1}'", conErrorIdManage.ClsName, strClassName);
            sbCondition.AppendFormat(" And {0} = '{1}'", conErrorIdManage.FunctionName, strFunctionName);
            sbCondition.AppendFormat(" And {0} = '{1}'", conErrorIdManage.Explanation, strExplanation);
            //            clsErrorIdManageEN objErrorIdManageEN = clsErrorIdManageBL.GetFirstErrorIdManage_S(sbCondition.ToString());
            clsErrorIdManageEN objErrorIdManageEN = 
                clsErrorIdManageBLEx.GetErrorIdManageObjBymIdExCache(strPrjId, strCodeTypeId, strClassName, strFunctionName, strExplanation);
            if (objErrorIdManageEN !=  null) return objErrorIdManageEN.ErrID;

            string strErrId = GetMaxErrId(strCodeTypeId);

            clsErrorIdManageEN pobjErrorIdManageEN = new clsErrorIdManageEN();
            pobjErrorIdManageEN.ErrID = strErrId;// 错误Id
            //pobjErrorIdManageEN.PrjId = strPrjId;// 工程ID
            pobjErrorIdManageEN.CodeTypeId = strCodeTypeId;// 程序分层类型
            //pobjErrorIdManageEN.ClsName = strClassName;// 类名
            pobjErrorIdManageEN.FunctionName = strFunctionName;// 功能名称
            pobjErrorIdManageEN.Explanation = strExplanation;// 说明
            pobjErrorIdManageEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);// 修改日期
            pobjErrorIdManageEN.UpdUserId = strUserId;// 修改用户Id
            pobjErrorIdManageEN.Memo = "";// 说明
            clsErrorIdManageBL.AddNewRecordBySql2(pobjErrorIdManageEN);
            return strErrId;
        }

        /// <summary>
        /// 获取最大错误Id , 并添加到数据表中
        /// </summary>
        /// <param name = "strCodeTypeId">程序分层类型Id</param>
        /// <param name = "strPrjId"></param>
        /// <param name = "strClassName"></param>
        /// <param name = "strFunctionName"></param>
        /// <param name = "strExplanation">详细说明</param>
        /// <param name = "strUserId"></param>
        /// <returns></returns>
        public static string GetMaxErrIdWithAddRecAndCheckDuplicate(string strCodeTypeId, string strPrjId,
            string strClassName, string strFunctionName, string strExplanation, string strUserId)
        {

            string strErrId = GetMaxErrIdWithAddRec(strCodeTypeId, strPrjId, strClassName, strFunctionName, strExplanation, strUserId);
            if (arrErrIdLstCache  ==  null) arrErrIdLstCache = new List<string>();
            if (arrErrIdLstCache.Contains(strErrId)  ==  true)
            {
                StringBuilder sbCondition = new StringBuilder();
                sbCondition.AppendFormat("{0} = '{1}'", conErrorIdManage.CodeTypeId, strCodeTypeId);
                //sbCondition.AppendFormat(" And {0} = '{1}'", conErrorIdManage.PrjId, strPrjId);
                //sbCondition.AppendFormat(" And {0} = '{1}'", conErrorIdManage.ClsName, strClassName);
                sbCondition.AppendFormat(" And {0} = '{1}'", conErrorIdManage.FunctionName, strFunctionName);
                sbCondition.AppendFormat(" And {0} = '{1}'", conErrorIdManage.Explanation, strExplanation);
                string strMsg = string.Format("由条件:[{0}]决定的ErrId:[{1}]已经使用过,请检查!", sbCondition.ToString(), strErrId);
                //throw new Exception(strMsg);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                return strErrId;
            }
            arrErrIdLstCache.Add(strErrId);
            return strErrId;
        }

        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_InitListCache)
        /// </summary>
        //public static void InitListCache(string strPrjId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clsErrorIdManageBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsErrorIdManageBL没有刷新缓存机制(clsErrorIdManageBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (strPrjIdCache_Init != strPrjId) clsErrorIdManageBL.ReFreshThisCache();

        //    //初始化列表缓存
        //    string strWhereCond = string.Format(" 1 = 1 order by mId");
        //    if (arrErrorIdManageObjLstCache == null)
        //    {
        //        arrErrorIdManageObjLstCache = clsErrorIdManageBL.GetObjLst(strWhereCond);
        //        strMsg = string.Format("初始化成功！strPrjId={0}，strPrjIdCache_Init={1}.({2})",
        //        strPrjId, strPrjIdCache_Init, clsStackTrace.GetCurrClassFunction());
        //        clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
        //        strPrjIdCache_Init = strPrjId;
        //    }
        //}
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetRecObjByKeyCache)
        /// </summary>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <param name = "strCodeTypeId">所给的关键字</param>
        /// <param name = "strClassName">所给的关键字</param>
        /// <param name = "strFunctionName">所给的关键字</param>
        /// <param name = "strExplanation">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsErrorIdManageEN GetErrorIdManageObjBymIdExCache(string strPrjId, 
            string strCodeTypeId, 
            string strClassName, string strFunctionName, string strExplanation)
        {
            //初始化列表缓存
            List<clsErrorIdManageEN> arrObjLstCache = clsErrorIdManageBL.GetObjLstCache();

            IEnumerable<clsErrorIdManageEN> arrErrorIdManageObjLst_Sel1 =
            from objErrorIdManageEN in arrObjLstCache
            where objErrorIdManageEN.CodeTypeId == strCodeTypeId
            //&& objErrorIdManageEN.ClsName == strClassName
             && objErrorIdManageEN.FunctionName == strFunctionName
             && objErrorIdManageEN.Explanation == strExplanation
        
            select objErrorIdManageEN;
            List<clsErrorIdManageEN> arrErrorIdManageObjLst_Sel = new List<clsErrorIdManageEN>();
            foreach (clsErrorIdManageEN obj in arrErrorIdManageObjLst_Sel1)
            {
                arrErrorIdManageObjLst_Sel.Add(obj);
            }
            if (arrErrorIdManageObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrErrorIdManageObjLst_Sel[0];
        }

    }
}
