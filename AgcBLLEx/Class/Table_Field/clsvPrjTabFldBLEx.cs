using System;
using System.Collections.Generic;
using System.Linq;
using AGC.BusinessLogic;

using AGC.Entity;
using com.taishsoft.common;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 全静态类，包含全静态函数，相当于全局函数
    /// </summary>
    public static class clsvPrjTabFldBLEx_Static
    {
        public static clsvFieldTab4CodeConvEN ObjvFieldTab4CodeConv(this clsvPrjTabFldEN objvPrjTabFld)
        {
            try
            {
                clsvFieldTab4CodeConvEN objFieldTab = clsvFieldTab4CodeConvBL.GetObjByFldIdCache(objvPrjTabFld.FldId, objvPrjTabFld.PrjId);
                return objFieldTab;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表字段获取字段代码转换对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    public class clsvPrjTabFldBLEx : clsvPrjTabFldBL
    {
        //public static List<clsvPrjTabFldEN> arrvPrjTabFldObjLstExCache = null;
        //public static List<clsvPrjTabFldEN> arrvPrjTabFldObjLstOrderByTabIdExCache = null;

        public static  string strPrjIdCache_Init = "";
        ///绑定下拉框的函数代码
        public static void BindDdl_FldIDByTabId(System.Web.UI.WebControls.DropDownList objDDL, string strTabId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format("TabId = '{0}' order by {1}", strTabId, convPrjTabFld.FldName);
            System.Data.DataTable objDT = GetDataTable_vPrjTabFld(strCondition);
            objDDL.DataValueField = "FldId";
            objDDL.DataTextField = "FldName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_InitListCache)
        /// </summary>
        //public static void InitListCache(string strPrjId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clsPrjTabBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsPrjTabFldBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsPrjTabFldBL没有刷新缓存机制(clsPrjTabFldBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsPrimaryTypeBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsPrimaryTypeBL没有刷新缓存机制(clsPrimaryTypeBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsFieldTypeBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsFieldTypeBL没有刷新缓存机制(clsFieldTypeBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsFldOperationTypeBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsFldOperationTypeBL没有刷新缓存机制(clsFldOperationTypeBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsProjectsBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsProjectsBL没有刷新缓存机制(clsProjectsBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsFieldTabBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsDataTypeAbbrBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsDataTypeAbbrBL没有刷新缓存机制(clsDataTypeAbbrBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    //if (clsPrjObjectsBL.objCommFun4BL == null)
        //    //{
        //    //    strMsg = string.Format("类clsPrjObjectsBL没有刷新缓存机制(clsPrjObjectsBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //    //    throw new Exception(strMsg);
        //    //}
        //    if (clsSQLDSTypeBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsSQLDSTypeBL没有刷新缓存机制(clsSQLDSTypeBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsFuncModule_AgcBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsFuncModule_AgcBL没有刷新缓存机制(clsFuncModule_AgcBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsTabStateBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsTabStateBL没有刷新缓存机制(clsTabStateBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsTabTypeBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsTabTypeBL没有刷新缓存机制(clsTabTypeBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    //if (clsFldObjTabBL.objCommFun4BL == null)
        //    //{
        //    //    strMsg = string.Format("类clsFldObjTabBL没有刷新缓存机制(clsFldObjTabBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //    //    throw new Exception(strMsg);
        //    //}
        //    if (clsApplicationTypeBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (clsSoftStructureBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsSoftStructureBL没有刷新缓存机制(clsSoftStructureBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    //初始化列表缓存
        //    if (strPrjIdCache_Init != strPrjId) arrvPrjTabFldObjLstCache = null;
        //    if (arrvPrjTabFldObjLstCache == null)
        //    {
        //        string strWhereCond = string.Format("{0} = '{1}' order by mId", clsvPrjTabFldEN.con_PrjId, strPrjId);
        //        arrvPrjTabFldObjLstCache = clsvPrjTabFldBL.GetObjLst(strWhereCond);
             
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
        /// <param name = "strFldName">字段名</param>
        /// <param name = "strTabId">strTabId</param>
        /// <param name = "strPrjId">strPrjId</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsvPrjTabFldEN GetObjByFldNameExCache(string strFldName, 
            string strTabId, string strPrjId)
        {
            if (strTabId.Substring(0, 4) !=  strPrjId)
            {
                string strMsg = string.Format("(errid:BlEx000039)工程Id:[{0}],表Id:[{1}], 两者不相配,请检查!在(clsvPrjTabFldBLEx:GetvPrjTabFldObjByFldNameExCache)", strPrjId, strTabId);
                throw new Exception(strMsg);
            }
       
            List<clsvPrjTabFldEN> arrObjLstCache = clsvPrjTabFldBL.GetObjLstCache(strPrjId);

            foreach (clsvPrjTabFldEN objvPrjTabFldEN in arrObjLstCache)
            {
                if (objvPrjTabFldEN.FldName.Equals(strFldName, StringComparison.InvariantCultureIgnoreCase)
                    && objvPrjTabFldEN.TabId  ==  strTabId)
                {
                    return objvPrjTabFldEN;
                }
            }
            return null;
        }



        #region 缓存操作

        ///// <summary>
        ///// 根据[表Id(TabId)]获取相关对象子表, 从缓存的对象列表中获取.
        ///// </summary>
        ///// <param name = "strPrjId">项目Id</param>
        ///// <param name = "strTabId">表Id</param>
        ///// <returns>根据[表Id(TabId)]获取的相关对象子表</returns>
        //public static List<clsvPrjTabFldEN> GetvPrjTabFldObjSubLstByTabIdExCacheBak20170215(string strPrjId, string strTabId)
        //{
        //    if (strTabId.Substring(0,4) !=  strPrjId)
        //    {
        //        string strMsg = string.Format("(errid:BlEx000040)工程Id:[{0}],表Id:[{1}], 两者不相配,请检查!在({4}-{3}-{2})", 
        //            strPrjId, strTabId,
        //            clsStackTrace.GetCurrClassFunctionByLevel(1),
        //            clsStackTrace.GetCurrClassFunctionByLevel(2),
        //            clsStackTrace.GetCurrClassFunctionByLevel(3));
        //        throw new Exception(strMsg);
        //    }
        //    string strCondition = string.Format(" PrjId = '{0}' order by TabId", strPrjId);
        //    if (arrvPrjTabFldObjLstOrderByTabIdExCache  ==  null)
        //    {
        //        arrvPrjTabFldObjLstOrderByTabIdExCache = new clsvPrjTabFldDA().GetObjLst(strCondition);
        //    }
        //    List<clsvPrjTabFldEN> arrvPrjTabFldObjLst = new List<clsvPrjTabFldEN>();
        //    int intStart = 0;
        //    int intEnd = arrvPrjTabFldObjLstOrderByTabIdExCache.Count - 1;
        //    int intMid = 0;
        //    clsvPrjTabFldEN objvPrjTabFldEN = null;
        //    while (intEnd >=  intStart)
        //    {
        //        intMid = (intStart + intEnd) / 2;
        //        objvPrjTabFldEN = arrvPrjTabFldObjLstOrderByTabIdExCache[intMid];
        //        if (objvPrjTabFldEN.TabId  ==  strTabId)
        //        {
                
        //            int intFirst = intMid;
        //            while (true)
        //            {
        //                objvPrjTabFldEN = arrvPrjTabFldObjLstOrderByTabIdExCache[intFirst];
        //                if (objvPrjTabFldEN.TabId  ==  strTabId)
        //                {
        //                    intFirst--;
        //                    if (intFirst  ==  -1)
        //                    {
        //                        break;
        //                    }
        //                }
        //                else
        //                {
        //                    break;
        //                }
        //            }
        //            intFirst++;
        //            while (true)
        //            {
        //                objvPrjTabFldEN = arrvPrjTabFldObjLstOrderByTabIdExCache[intFirst];
        //                if (objvPrjTabFldEN.TabId  ==  strTabId)
        //                {
        //                    intFindFailCount = 0;
        //                    arrvPrjTabFldObjLst.Add(objvPrjTabFldEN);
        //                    intFirst++;
        //                    if (intFirst > intEnd) break;
        //                }
        //                else
        //                {
        //                    break;
        //                }
        //            }
        //            intFindFailCount = 0; 
        //            return arrvPrjTabFldObjLst;
        //        }
        //        else if (objvPrjTabFldEN.TabId.CompareTo(strTabId) > 0)
        //        {
        //            intEnd = intMid - 1;
        //        }
        //        else
        //        {
        //            intStart = intMid + 1;
        //        }
        //    }
        //    intFindFailCount++;
        //    // 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        //    arrvPrjTabFldObjLstOrderByTabIdExCache = null;
        //    if (intFindFailCount  ==  1) return GetvPrjTabFldObjSubLstByTabIdExCache( strPrjId,  strTabId);
        //    string strErrMsgForGetObjById = string.Format("在vPrjTabFld对象缓存列表中,找不到记录[TabId = {0}][intFindFailCount = {1}](函数:GetvPrjTabFldObjSubLstByTabIdExCache)",
        //        strTabId, intFindFailCount);

        //    if (objvPrjTabFldEN !=  null)
        //    {
        //        strErrMsgForGetObjById +=  string.Format("最后一次查找的对象相关字段属性值:{0}.[intMid = {1}]", objvPrjTabFldEN.TabId, intMid);
        //    }
        //    else
        //    {
        //        strErrMsgForGetObjById +=  string.Format("最后一次查找的对象为null, 请检查![intMid = {0}]", intMid);
        //    }

        //    clsLog.LogErrorS2("clsvPrjTabFldBL", "GetvPrjTabFldObjSubLstByTabIdExCache", strErrMsgForGetObjById, "", "");
        //    throw new Exception(strErrMsgForGetObjById);
        //}



        /// <summary>
        /// 根据[表Id(TabId)]获取相关对象子表, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strPrjId">项目Id</param>
        /// <param name = "strTabId">表Id</param>
        /// <returns>根据[表Id(TabId)]获取的相关对象子表</returns>
        public static List<clsvPrjTabFldEN> GetObjLstByTabIdCache0(string strTabId, string strPrjId)
        {
            if (strTabId.Substring(0, 4) != strPrjId)
            {
                string strMsg = string.Format("(errid:BlEx000040)工程Id:[{0}],表Id:[{1}], 两者不相配,请检查!在({4}-{3}-{2})",
                    strPrjId, strTabId,
                    clsStackTrace.GetCurrClassFunctionByLevel(1),
                    clsStackTrace.GetCurrClassFunctionByLevel(2),
                    clsStackTrace.GetCurrClassFunctionByLevel(3));
                throw new Exception(strMsg);
            }
            List<clsvPrjTabFldEN> arrObjLstCache = clsvPrjTabFldBL.GetObjLstCache(strPrjId);

            IEnumerable<clsvPrjTabFldEN> arrvPrjTabFldObjLst_Sel1 =
                from objvPrjTabFldEN in arrObjLstCache
                where objvPrjTabFldEN.TabId == strTabId
                select objvPrjTabFldEN;


            List<clsvPrjTabFldEN> arrvPrjTabFldObjLst_Sel = arrvPrjTabFldObjLst_Sel1.OrderBy(x=>x.FldId).ToList();
          
            return arrvPrjTabFldObjLst_Sel;
        }


        /// <summary>
        /// 根据[表Id(TabId)]获取相关对象子表, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strPrjId">项目Id</param>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strFldName">字段名</param>
        /// <returns>根据[表Id(TabId)]获取的相关对象子表</returns>
        public static List<clsvPrjTabFldEN> GetObjLstByTabIdAndFldNameExCache(string strPrjId, string strTabId, string strFldName)
        {
            if (strTabId.Substring(0, 4) != strPrjId)
            {
                string strMsg = string.Format("(errid:BlEx000040)工程Id:[{0}],表Id:[{1}], 两者不相配,请检查!在({4}-{3}-{2})",
                    strPrjId, strTabId,
                    clsStackTrace.GetCurrClassFunctionByLevel(1),
                    clsStackTrace.GetCurrClassFunctionByLevel(2),
                    clsStackTrace.GetCurrClassFunctionByLevel(3));
                throw new Exception(strMsg);
            }
            List<clsvPrjTabFldEN> arrObjLstCache = clsvPrjTabFldBL.GetObjLstCache(strPrjId);
            
            IEnumerable<clsvPrjTabFldEN> arrvPrjTabFldObjLst_Sel1 =
                from objvPrjTabFldEN in arrObjLstCache
                where objvPrjTabFldEN.TabId == strTabId
                && objvPrjTabFldEN.FldName == strFldName
                select objvPrjTabFldEN;


            List<clsvPrjTabFldEN> arrvPrjTabFldObjLst_Sel = new List<clsvPrjTabFldEN>();
            foreach (clsvPrjTabFldEN obj in arrvPrjTabFldObjLst_Sel1)
            {
                arrvPrjTabFldObjLst_Sel.Add(obj);
            }

            return arrvPrjTabFldObjLst_Sel;
        }

        /// <summary>
        /// 从表字段列表中查找某关键表字段对象
        /// </summary>
        /// <param name = "arrPrjTabFldObjList">表字段列表</param>
        /// <returns>表字段(clsvPrjTabFldEN)对象</returns>
        public static clsvPrjTabFldEN GetOrderNumObj(List<clsvPrjTabFldEN> arrPrjTabFldObjList)
        {
            foreach (clsvPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjList)
            {
                if (objPrjTabFldEN.FieldTypeId == enumFieldType.KeyField_02) return objPrjTabFldEN;
                if (objPrjTabFldEN.FieldTypeId == enumFieldType.OrderNumField_09)
                {
                    return objPrjTabFldEN;
                }
            }
            return null;
        }

        #endregion 缓存操作

        /// <summary>
        /// 根据[表Id(TabId)]获取相关扩展对象子表, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strPrjId">项目Id</param>
        /// <param name = "strTabId">表Id</param>
        /// <returns>根据[表Id(TabId)]获取的相关扩展对象子表</returns>
        public static List<clsvPrjTabFldENEx> GetObjExLstByTabIdExCache(string strPrjId, string strTabId)
        {
            if (strTabId.Substring(0, 4) != strPrjId)
            {
                string strMsg = string.Format("(errid:BlEx000040)工程Id:[{0}],表Id:[{1}], 两者不相配,请检查!在({4}-{3}-{2})",
                    strPrjId, strTabId,
                    clsStackTrace.GetCurrClassFunctionByLevel(1),
                    clsStackTrace.GetCurrClassFunctionByLevel(2),
                    clsStackTrace.GetCurrClassFunctionByLevel(3));
                throw new Exception(strMsg);
            }
            List<clsvPrjTabFldEN> arrObjLstCache = clsvPrjTabFldBL.GetObjLstCache(strPrjId);


            IEnumerable<clsvPrjTabFldEN> arrvPrjTabFldObjLst_Sel1 =
                from objvPrjTabFldEN in arrObjLstCache
                where objvPrjTabFldEN.TabId == strTabId
                select objvPrjTabFldEN;


            List<clsvPrjTabFldENEx> arrvPrjTabFldObjLst_Sel = new List<clsvPrjTabFldENEx>();
            foreach (clsvPrjTabFldEN obj in arrvPrjTabFldObjLst_Sel1)
            {
                clsvPrjTabFldENEx objEx = new clsvPrjTabFldENEx();
                objEx = obj as clsvPrjTabFldENEx;

                string strFldName = obj.FldName;
                try
                {
                    clsvSqlViewFldEN objvSqlViewFldEN = clsvSqlViewFldBLEx.GetvSqlViewFldObjByTabIdFieldAliasesExCache(strPrjId, strTabId, strFldName);
                    if (objvSqlViewFldEN == null)
                    {
                        objvSqlViewFldEN = clsvSqlViewFldBLEx.GetvSqlViewFldObjByTabIdFldNameExCache(strPrjId, strTabId, strFldName);

                    }
                    if (objvSqlViewFldEN != null)
                    {
                        objEx.SourceTabName = objvSqlViewFldEN.TabName;
                    }
                }
                catch (Exception objException)
                {
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);
                }           
                arrvPrjTabFldObjLst_Sel.Add(objEx);
            }
            return arrvPrjTabFldObjLst_Sel;
        }

        /// <summary>
        /// 根据[表Id(TabId)]获取相关扩展对象子表, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "arrObjLst">源对象殂</param>
        /// <returns>根据[源对象列表]获取的相关扩展对象子表</returns>
        public static List<clsvPrjTabFldENEx> GetObjExLstByObjLst(List<clsvPrjTabFldEN> arrObjLst)
        {
            List<clsvPrjTabFldENEx> arrvPrjTabFldObjLst_Sel = new List<clsvPrjTabFldENEx>();
            foreach (clsvPrjTabFldEN obj in arrObjLst)
            {
                clsvPrjTabFldENEx objEx = new clsvPrjTabFldENEx();
                clsvPrjTabFldBL.CopyTo(obj, objEx);

                string strFldName = obj.FldName;
                try
                {
                    clsvSqlViewFldEN objvSqlViewFldEN = clsvSqlViewFldBLEx.GetvSqlViewFldObjByTabIdFieldAliasesExCache(obj.PrjId, obj.TabId, strFldName);
                    if (objvSqlViewFldEN == null)
                    {
                        objvSqlViewFldEN = clsvSqlViewFldBLEx.GetvSqlViewFldObjByTabIdFldNameExCache(obj.PrjId, obj.TabId, strFldName);
                    }
                    if (objvSqlViewFldEN != null)
                    {
                        objEx.SourceTabName = objvSqlViewFldEN.TabName;
                    }
                }
                catch (Exception objException)
                {
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);
                }
                arrvPrjTabFldObjLst_Sel.Add(objEx);
            }
            return arrvPrjTabFldObjLst_Sel;
        }
        /// <summary>
        /// 根据[表Id(TabId)]获取相关对象子表, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strPrjId">项目Id</param>
        /// <param name = "strTabId">表Id</param>
        /// <returns>根据[表Id(TabId)]获取的相关对象子表</returns>
        public static bool IsExistFldInObjLst(string strFldName, List<clsvPrjTabFldEN> arrObjLst)
        {
            foreach (clsvPrjTabFldEN obj in arrObjLst)
            {
                if (obj.FldName == strFldName) return true;
            }
            return false;
        }
        /// <summary>
        /// 从表字段列表中查找FldId的对象
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strFldId">字段Id</param>
        /// <returns>表字段</returns>
        public static clsvPrjTabFldEN GetObjByFldIdCache(string strTabId, string strPrjId, string strFldId)
        {
            List<clsvPrjTabFldEN> arrPrjTabFldObjList = GetObjLstByTabIdCache0(strTabId, strPrjId);
            clsvPrjTabFldEN objPrjTabFldEN = arrPrjTabFldObjList.Find(x => x.FldId == strFldId);
            return objPrjTabFldEN;

        }

        /// <summary>
        /// 从表字段列表中查找分类字段
        /// </summary>
        /// <param name = "strTabId">表字段列表</param>
        /// <param name = "strPrjId">表字段列表</param>
        /// <returns>分类字段</returns>
        public static clsvPrjTabFldEN GetClassificationFieldObjCache(string strTabId, string strPrjId)
        {
            List<clsvPrjTabFldEN> arrPrjTabFldObjList = GetObjLstByTabIdCache0(strTabId, strPrjId);

            clsvPrjTabFldEN objPrjTabFldEN = arrPrjTabFldObjList.Find(x => x.FieldTypeId == enumFieldType.ClassificationField_10);
            return objPrjTabFldEN;

        }
    }
}
