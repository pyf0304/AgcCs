
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsTabCheckStatusBLEx
表名:TabCheckStatus(00050568)
生成代码版本:2020.06.27.1
生成日期:2020/06/27 10:45:39
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:日志管理
模块英文名:LogManage
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
using com.taishsoft.sql;

namespace AGC.BusinessLogicEx
{
    public static class clsTabCheckStatusBLEx_Static
    {
        public static bool AddErrMsg(this clsTabCheckStatusEN objPrjTabEN, string strErrMsg)
        {
            if (string.IsNullOrEmpty(strErrMsg) == true) return true;
            string strCurrDate = clsDateTime.getTodayStr(0);
            string strOldErrMsg = objPrjTabEN.ErrorMsg;
            strOldErrMsg = strOldErrMsg.Replace(strCurrDate, "");
            strOldErrMsg = strOldErrMsg.Replace(":", "; ");
            string strNewErrMsg = "";
            if (string.IsNullOrEmpty(strOldErrMsg) == false)
            {
                strNewErrMsg = strCurrDate + ":" + strErrMsg + strOldErrMsg;
            }
            else
            {
                strNewErrMsg = strCurrDate + ":" + strErrMsg;
            }
            int intRecNum = 0;
            try
            {
                intRecNum = clsTabCheckStatusBL.SetFldValue(conTabCheckStatus._CurrTabName, conTabCheckStatus.ErrorMsg, strNewErrMsg, string.Format("TabId = '{0}'", objPrjTabEN.TabId));
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsPrjTabBLEx", "AddErrMsg", objException.Message + "::" + strErrMsg, "pyfdebug");

            }
            if (intRecNum > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objTabCheckStatusENS">源对象</param>
        /// <returns>目标对象=>clsTabCheckStatusEN:objTabCheckStatusENT</returns>
        public static clsTabCheckStatusENEx CopyToEx(this clsTabCheckStatusEN objTabCheckStatusENS)
        {
            try
            {
                clsTabCheckStatusENEx objTabCheckStatusENT = new clsTabCheckStatusENEx();
                clsTabCheckStatusBL.TabCheckStatusDA.CopyTo(objTabCheckStatusENS, objTabCheckStatusENT);
                return objTabCheckStatusENT;
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
        /// <param name = "objTabCheckStatusENS">源对象</param>
        /// <returns>目标对象=>clsTabCheckStatusEN:objTabCheckStatusENT</returns>
        public static clsTabCheckStatusEN CopyTo(this clsTabCheckStatusENEx objTabCheckStatusENS)
        {
            try
            {
                clsTabCheckStatusEN objTabCheckStatusENT = new clsTabCheckStatusEN();
                clsTabCheckStatusBL.CopyTo(objTabCheckStatusENS, objTabCheckStatusENT);
                return objTabCheckStatusENT;
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
    /// 表检查状态(TabCheckStatus)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsTabCheckStatusBLEx : clsTabCheckStatusBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsTabCheckStatusDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsTabCheckStatusDAEx TabCheckStatusDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsTabCheckStatusDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objTabCheckStatusENS">源对象</param>
        /// <returns>目标对象=>clsTabCheckStatusEN:objTabCheckStatusENT</returns>
        public static clsTabCheckStatusENEx CopyToEx(clsTabCheckStatusEN objTabCheckStatusENS)
        {
            try
            {
                clsTabCheckStatusENEx objTabCheckStatusENT = new clsTabCheckStatusENEx();
                clsTabCheckStatusBL.TabCheckStatusDA.CopyTo(objTabCheckStatusENS, objTabCheckStatusENT);
                return objTabCheckStatusENT;
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
        public static List<clsTabCheckStatusENEx> GetObjExLst(string strCondition)
        {
            List<clsTabCheckStatusEN> arrObjLst = clsTabCheckStatusBL.GetObjLst(strCondition);
            List<clsTabCheckStatusENEx> arrObjExLst = new List<clsTabCheckStatusENEx>();
            foreach (clsTabCheckStatusEN objInFor in arrObjLst)
            {
                clsTabCheckStatusENEx objTabCheckStatusENEx = new clsTabCheckStatusENEx();
                clsTabCheckStatusBL.CopyTo(objInFor, objTabCheckStatusENEx);
                arrObjExLst.Add(objTabCheckStatusENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsTabCheckStatusENEx GetObjExBymId(long lngmId)
        {
            clsTabCheckStatusEN objTabCheckStatusEN = clsTabCheckStatusBL.GetObjBymId(lngmId);
            clsTabCheckStatusENEx objTabCheckStatusENEx = new clsTabCheckStatusENEx();
            clsTabCheckStatusBL.CopyTo(objTabCheckStatusEN, objTabCheckStatusENEx);
            return objTabCheckStatusENEx;
        }
        public static bool InitCheckAllTabField(string strPrjId, string strPrjDataBaseId)
        {
            clsTabCheckStatusBL.SetFldValue(clsTabCheckStatusEN._CurrTabName, "IsNeedCheckTab", "1", string.Format("PrjId = '{0}' and {1}='{2}'", strPrjId, conTabCheckStatus.PrjDataBaseId, strPrjDataBaseId));
            List<clsPrjTabEN> arrPrjTab = clsPrjTabBL.GetObjLstCache(strPrjId);
            string strCondition = string.Format("{0}='{1}' and {2}='{3}'", conTabCheckStatus.PrjId, strPrjId, conTabCheckStatus.PrjDataBaseId, strPrjDataBaseId);
            List<clsTabCheckStatusEN> arrTabCheckStatus = clsTabCheckStatusBL.GetObjLst(strCondition);
            List<string> arrTabId = arrTabCheckStatus.Select(x => x.TabId).ToList();
            List<clsPrjTabEN> arrPrjTab_UnExist = arrPrjTab.Where(x => arrTabId.Contains(x.TabId) == false).ToList();

            arrPrjTab_UnExist.ForEach(x =>
            {
                clsTabCheckStatusBLEx.InitNeedCheck(x.TabId, x.PrjId, strPrjDataBaseId);
            });
            return true;
        }
        public static int CheckAllTabField(string strPrjId, string strPrjDataBaseId, string strUserId)
        {
            string strMsg = "";
            clsSysParaEN.spIsUseQueue4Task = true;
            clsTabCheckResultBL.DelTabCheckResultsByCond(string.Format("PrjId = '{0}' And PrjDataBaseId = '{1}' And TabId in (Select TabId From PrjTab where PrjId = '{0}' And IsNeedCheckTab = '1')", strPrjId, strPrjDataBaseId));
            clsPrjTabBLEx.RemoveErrMsg(strPrjId);
            List<string> arrTabIdLst = null;
            clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(strPrjId);

            if (arrTabIdLst == null || arrTabIdLst.Count == 0)
            {
                arrTabIdLst = clsGeneralTab2.funGetFldValue(conTabCheckStatus._CurrTabName, "TabId", string.Format("PrjId = '{0}' And IsNeedCheckTab = '1' ", strPrjId));
            }

            if (arrTabIdLst.Count == 0)
            {
                strMsg = string.Format("工程:{0}({1})中没有需要检查的表,请【检查初始化】或者选择一个另一个工程!({2}->{3})",
                    objProjectsEN.PrjName, objProjectsEN.PrjId,
                    clsStackTrace.GetCurrClassFunctionByLevel(2),
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);

            }
            clsTabCheckStatusBLEx.CheckSQLTabByPrjTab(objProjectsEN, strPrjDataBaseId, strUserId);
            clsTabCheckStatusBLEx.CheckPrjTabBySQLTab(objProjectsEN, strPrjDataBaseId, strUserId);

            string strCurrDate = clsDateTime.getTodayDateTimeStr(1);
            int intCount = 0;
            foreach (string strTabId in arrTabIdLst)
            {
                try
                {
                    clsTabCheckStatusBLEx.CheckPrjTabvSqlViewFldBySQLView_Agc(strTabId, objProjectsEN, strPrjDataBaseId, strUserId);

                    clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTabDetail(strTabId, objProjectsEN, strPrjDataBaseId, strUserId);
                    //clsPrjTabBLEx.CheckTabField(strTabId, objProjectsEN, strUserId);
                    clsTabCheckStatusEN objTabCheckStatus1 = clsTabCheckStatusBLEx.GetObjByTabIdCacheEx(strTabId, objProjectsEN.PrjId, strPrjDataBaseId);
                    objTabCheckStatus1.IsNeedCheckTab = false;
                    clsTabCheckStatusBL.UpdateBySql2(objTabCheckStatus1);
                    intCount++;
                }
                catch (Exception objException)
                {
                    var objTabCheckStatusEN = clsTabCheckStatusBLEx.GetObjByTabIdCacheEx(strTabId, objProjectsEN.PrjId, strPrjDataBaseId);
                    objTabCheckStatusEN.AddErrMsg(objException.Message);

                    ErrorInformationBL.AddInformation("wfmPrjTab_QUDI3.aspx", "lbCheckAllTabField_Click", objException.Message, strUserId);
                } //显示生成代码区域
            }
            clsSysParaEN.spIsUseQueue4Task = false;
            if (clsSysParaEN.arrFunctionLst4Queue != null)
            {
                strMsg = string.Format("任务队列共有：{0}个任务。准备执行！", clsSysParaEN.arrFunctionLst4Queue.Count);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                com.taishsoft.dynamiccompiler.clsDynamicCompiler.ExecStaticFunctionLst(clsSysParaEN.arrFunctionLst4Queue);
                strMsg = string.Format("任务队列共有：{0}个任务。执行完毕！", clsSysParaEN.arrFunctionLst4Queue.Count);
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
            }
            return intCount;
            //            clsCommonJsFunc.Alert(this, "检查表字段完成!共计:" + intCount.ToString() + "个表。");


        }


        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strTabId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsTabCheckStatusENEx GetObjExByTabId(string strTabId, string strPrjDataBaseId)
        {
            string strCondition = string.Format("{0}='{1}' and {2}='{3}'", conTabCheckStatus.TabId, strTabId, conTabCheckStatus.PrjDataBaseId, strPrjDataBaseId);

            clsTabCheckStatusEN objTabCheckStatusEN = clsTabCheckStatusBL.GetFirstObj_S(strCondition);
            clsTabCheckStatusENEx objTabCheckStatusENEx = new clsTabCheckStatusENEx();
            clsTabCheckStatusBL.CopyTo(objTabCheckStatusEN, objTabCheckStatusENEx);
            return objTabCheckStatusENEx;
        }

        public static clsTabCheckStatusEN GetObjByTabIdCacheEx(string strTabId, string strPrjId, string strPrjDataBaseId)
        {
            var arrTabCheckStatus = clsTabCheckStatusBL.GetObjLstCache(strPrjId);
            clsTabCheckStatusEN objTabCheckStatusEN = arrTabCheckStatus.Find(x => x.TabId == strTabId && x.PrjDataBaseId == strPrjDataBaseId);
            if (objTabCheckStatusEN == null)
            {
                objTabCheckStatusEN = new clsTabCheckStatusEN();
                objTabCheckStatusEN.TabId = strTabId;
                objTabCheckStatusEN.PrjId = strPrjId;
                objTabCheckStatusEN.PrjDataBaseId = strPrjDataBaseId;
                objTabCheckStatusEN.ErrorLevelId = -1;
                objTabCheckStatusEN.ErrorMsg = "";
                objTabCheckStatusEN.IsNeedCheckTab = true;
                objTabCheckStatusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objTabCheckStatusEN.UpdUser = "sys";
                var strKey = objTabCheckStatusEN.AddNewRecordWithReturnKey();
                objTabCheckStatusEN.mId = long.Parse(strKey);
                clsTabCheckStatusBL.ReFreshCache(strPrjId);
            }
            return objTabCheckStatusEN;
        }
        public static clsTabCheckStatusEN InitNeedCheck(string strTabId, string strPrjId, string strPrjDataBaseId)
        {

            clsTabCheckStatusEN objTabCheckStatusEN = new clsTabCheckStatusEN();
            objTabCheckStatusEN = new clsTabCheckStatusEN();
            objTabCheckStatusEN.TabId = strTabId;
            objTabCheckStatusEN.PrjId = strPrjId;
            objTabCheckStatusEN.PrjDataBaseId = strPrjDataBaseId;
            objTabCheckStatusEN.ErrorLevelId = -1;
            objTabCheckStatusEN.ErrorMsg = "";
            objTabCheckStatusEN.IsNeedCheckTab = true;
            objTabCheckStatusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objTabCheckStatusEN.UpdUser = "sys";
            objTabCheckStatusEN.AddNewRecord();
            clsTabCheckStatusBL.ReFreshCache(strPrjId);
            return objTabCheckStatusEN;
        }
        public static int CheckCheckedTabField(string strPrjId, string strPrjDataBaseId, string strUserId, List<string> arrTabIdLst)
        {
            //clsTabCheckResultBL.DelTabCheckResultsByCond(string.Format("PrjId = '{0}'", strPrjId));

            //clsProjectsEN objProjectsEN = new clsProjectsEN(strPrjId);
            //clsProjectsBL.GetProjects(ref objProjectsEN);

            if (arrTabIdLst == null || arrTabIdLst.Count == 0)
            {
                arrTabIdLst = clsPrjTabBL.GetFldValue(clsPrjTabEN._CurrTabName, conPrjTab.TabId,
                    string.Format("{0} = '{1}'", conPrjTab.PrjId, strPrjId));
            }

            if (arrTabIdLst.Count == 0)
            {
                clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                string strMsg = string.Format("当前工程:[{0}({1})]中没有【工程表】记录,请选择一个有效的工程!");
                throw new Exception(strMsg);

            }

            string strCurrDate = clsDateTime.getTodayDateTimeStr(1);
            int intCount = 0;
            foreach (string strTabId in arrTabIdLst)
            {
                try
                {
                    if (strTabId == null) continue;
                    clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTab(strTabId, strPrjId, strPrjDataBaseId, true, strUserId);

                    //clsPrjTabBLEx.CheckTabField(strTabId, objProjectsEN, strUserId);

                    intCount++;
                }
                catch (Exception objException)
                {
                    var objTabCheckStatusEN = clsTabCheckStatusBLEx.GetObjByTabIdCacheEx(strTabId, strPrjId, strPrjDataBaseId);
                    objTabCheckStatusEN.AddErrMsg(objException.Message);
                    //objPrjTabEN.ErrMsg = objException.Message;
                    //objPrjTabEN.UpdDate = strCurrDate;
                    //objPrjTabEN.UpdUserId = strUserId;
                    //clsPrjTabBL.UpdateBySql2(objPrjTabEN);
                    ErrorInformationBL.AddInformation("wfmPrjTab_QUDI3.aspx", "lbCheckAllTabField_Click", objException.Message, strUserId);
                } //显示生成代码区域
            }
            clsTabCheckStatusBL.ReFreshCache(strPrjId);
            return intCount;
            //            clsCommonJsFunc.Alert(this, "检查表字段完成!共计:" + intCount.ToString() + "个表。");


        }

        /// <summary>
        /// 根据数据库中相关表来检查生成代码中的表对象字段,例如主键和相关字段
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <returns>是否成功!</returns>
        public static bool CheckPrjTabColumnBySQLTabDetail(string strTabId, clsProjectsEN objProjectsEN, string strPrjDataBaseId, string strUserId)
        {
            clsTabCheckStatusEN objTabCheckStatusEN = clsTabCheckStatusBLEx.GetObjByTabIdCacheEx(strTabId, objProjectsEN.PrjId, strPrjDataBaseId);
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(strTabId, objProjectsEN.PrjId);
            if (objPrjTabEN == null) return false;
            if (objPrjTabEN.IsReleToSqlTab == false)
            {
                return true;
            }
            string strCurrDate = clsDateTime.getTodayDateTimeStr(1);
            string strErrMsg = "";
            //操作步骤:
            //1、检查主键类型是否正确
            //2、检查表是否有主键   
            //3、检查生成代码字段在SQL表中是否存在
            //
            List<clsPrjTabFldEN> arrPrjTabFldObjList = clsPrjTabFldBLEx.GetObjLstByTabIdCache(strTabId, objProjectsEN.PrjId);
            if (arrPrjTabFldObjList.Count == 0)
            {
                clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId, strTabId,
                    "", "AGC没有表字段。", (int)enumErrorLevel.SeriousError_4, "14", strUserId);
                objTabCheckStatusEN.AddErrMsg("AGC没有表字段!");

                return true;
            }
            //2、检查主键类型是否正确
            string strPrimaryTypeId;
            bool bolIsHavePrimary = false;

            foreach (clsPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjList)
            {
                if (objPrjTabFldEN.IsForExtendClass == true) continue;
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFldEN.FldId, objPrjTabFldEN.PrjId);
                strPrimaryTypeId = objPrjTabFldEN.PrimaryTypeId;
                if (objPrjTabFldEN.FieldTypeId == enumFieldType.KeyField_02)
                {
                    bolIsHavePrimary = true;
                    if (strPrimaryTypeId == "00") //非关键字
                    {
                        //if (objPrjTabENEx.ErrMsg !=  "表主键字段的主键类型只能是主关键字或者Identity主键!")
                        //{
                        clsvPrjTabFldBL.ReFreshThisCache(objProjectsEN.PrjId);
                        strErrMsg = string.Format("表主键字段的主键类型只能是主关键字或者Identity主键!主键：[{0}]", objPrjTabFldEN.mId);
                        objTabCheckStatusEN.AddErrMsg(strErrMsg);


                        clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId,
                            strTabId, "", "AGC表主键字段的主键类型只能是主关键字或者Identity主键!", (int)enumErrorLevel.SeriousError_4, "12", strUserId);
                        //}
                        //throw new Exception(objPrjTabENEx.ErrMsg);
                    }
                    else if (strPrimaryTypeId == clsPrimaryTypeENEx.IDENTITY_PRIMARYKEY)
                    {
                        clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTab.DataTypeId);

                        if (objDataTypeAbbrEN.CsType == "string")
                        {
                            strErrMsg = "主键类型不正确。表主键类型Identity主键,而相应字段是字符型,不符合逻辑!";
                            objTabCheckStatusEN.AddErrMsg(strErrMsg);


                            clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId,
                                strTabId, "", strErrMsg, (int)enumErrorLevel.SeriousError_4, "09", strUserId);

                        }
                    }
                    else if (strPrimaryTypeId == clsPrimaryTypeENEx.PRIMARYKEY)
                    {
                        clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTab.DataTypeId);

                        if (objDataTypeAbbrEN.CsType == "int"
                            || objDataTypeAbbrEN.CsType == "long")
                        {
                            if (objPrjTabEN.SqlDsTypeId == clsSQLDSTypeBLEx.SQLTAB)
                            {
                                strErrMsg = "(errid:263808)主键类型不正确。表主键类型一般主键,而相应字段是int或long,不符合逻辑!";
                                objTabCheckStatusEN.AddErrMsg(strErrMsg);


                                clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId,
                                    strTabId, "", strErrMsg, (int)enumErrorLevel.MoreSeriousError_3, "10", strUserId);
                            }
                        }
                    }
                }
            }
            if (bolIsHavePrimary == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);

                string strConnectionString = clsPrjDataBaseBLEx.GetConnectString(objPrjDataBaseEN);
                List<clsPKeys> arrPKeysLst = clsSqlObject.GetPKeyObjList(strConnectionString, objPrjTabEN.TabName, objPrjDataBaseEN.DatabaseOwner);
                bool bolIsSetPKey = false;

                foreach (clsPKeys objPKeys in arrPKeysLst)
                {
                    string strFldName = objPKeys.COLUMN_NAME;
                    clsPrjTabFldEN objPrjTabFld_Key = clsPrjTabFldBLEx.GetvPrjTabFldENByFieldName(arrPrjTabFldObjList, strFldName);
                    if (objPrjTabFld_Key != null)
                    {
                        bolIsSetPKey = true;
                        bool bolIsIdentityColumn = clsSqlObject.IsIdentityColumn(strConnectionString, objPrjTabEN.TabName, objPrjDataBaseEN.DatabaseOwner, strFldName);
                        clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN(objPrjTabFld_Key.mId);
                        objPrjTabFldEN.FieldTypeId = "02";
                        objPrjTabFldEN.PrjId = objPrjTabFld_Key.PrjId;

                        if (bolIsIdentityColumn == true)
                        {
                            objPrjTabFldEN.PrimaryTypeId = "02";
                        }
                        else
                        {
                            objPrjTabFldEN.PrimaryTypeId = "01";
                        }
                        clsPrjTabFldBL.UpdateBySql2(objPrjTabFldEN);
                    }
                }
                if (bolIsSetPKey == false)
                {
                    while (objPrjTabEN.SqlDsTypeId == "02")//如果该表对象是视图类型
                    {
                        string strReleTabName = clsPrjTabBLEx.GetReleTabNameByViewName(objPrjTabEN.TabName);
                        if (string.IsNullOrEmpty(strReleTabName) == true) break;

                        clsPrjTabEN objRelePrjTabEN = clsPrjTabBLEx.GetObjByTabNameExCache(objPrjTabEN.PrjId, strReleTabName);
                        if (objRelePrjTabEN == null) break;
                        List<clsPrjTabFldEN> arrPrjTabFldObjList4RelaTab = clsPrjTabFldBLEx.GetObjLstByTabIdCache(objRelePrjTabEN.TabId, objPrjTabEN.PrjId);

                        clsPrjTabFldEN objvKeyPrjTabFldEN4RelaTab = clsPrjTabFldBLEx.GetKeyvPrjTabFldEN(arrPrjTabFldObjList4RelaTab);
                        if (objvKeyPrjTabFldEN4RelaTab == null) break;

                        string strFldName = objvKeyPrjTabFldEN4RelaTab.FldName();
                        clsPrjTabFldEN objPrjTabFld_Key = clsPrjTabFldBLEx.GetvPrjTabFldENByFieldName(arrPrjTabFldObjList, strFldName);
                        if (objPrjTabFld_Key == null) break;
                        bolIsSetPKey = true;
                        clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN(objPrjTabFld_Key.mId);
                        objPrjTabFldEN.FieldTypeId = "02";

                        objPrjTabFldEN.PrjId = objPrjTabFld_Key.PrjId;

                        objPrjTabFldEN.PrimaryTypeId = objvKeyPrjTabFldEN4RelaTab.PrimaryTypeId;
                        objPrjTabFldEN.SequenceNumber = 1;
                        clsPrjTabFldBL.UpdateBySql2(objPrjTabFldEN);

                        //根据表字段序号设置视图表字段的序号
                        foreach (clsPrjTabFldEN objvPrjTabFldEN in arrPrjTabFldObjList)
                        {
                            var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objvPrjTabFldEN.FldId, objvPrjTabFldEN.PrjId);
                            strFldName = objFieldTab.FldName;
                            clsPrjTabFldEN objvPrjTabFld4RelaTab = clsPrjTabFldBLEx.GetvPrjTabFldENByFieldName(arrPrjTabFldObjList4RelaTab, strFldName);
                            if (objvPrjTabFld4RelaTab == null) continue;

                            clsPrjTabFldEN objPrjTabFldEN_P = new clsPrjTabFldEN(objvPrjTabFldEN.mId);
                            objPrjTabFldEN_P.SequenceNumber = objvPrjTabFld4RelaTab.SequenceNumber;
                            objPrjTabFldEN_P.PrjId = objvPrjTabFld4RelaTab.PrjId;

                            clsPrjTabFldBL.UpdateBySql2(objPrjTabFldEN_P);
                            objvPrjTabFldEN._StrTag = "HaveAccess";//已经处理
                        }
                        foreach (clsPrjTabFldEN objvPrjTabFldEN in arrPrjTabFldObjList)
                        {
                            var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objvPrjTabFldEN.FldId, objvPrjTabFldEN.PrjId);
                            if (objvPrjTabFldEN._StrTag != "HaveAccess")
                            {
                                string strFldNameWithoutName = "";
                                int intPos_Name = objFieldTab.FldName.IndexOf("name", 0, StringComparison.InvariantCultureIgnoreCase);
                                if (intPos_Name == -1) continue;

                                strFldNameWithoutName = objFieldTab.FldName.Substring(0, objFieldTab.FldName.Length - intPos_Name);
                                clsPrjTabFldEN objvPrjTabFldEN_Like = clsPrjTabFldBLEx.GetLikevPrjTabFldENByFieldName(arrPrjTabFldObjList, strFldNameWithoutName);
                                if (objvPrjTabFldEN_Like == null) continue;
                                if (objvPrjTabFldEN_Like._StrTag != "HaveAccess") continue;

                                clsPrjTabFldEN objPrjTabFldEN_P = new clsPrjTabFldEN(objvPrjTabFldEN.mId);
                                objPrjTabFldEN_P.SequenceNumber = objvPrjTabFldEN_Like.SequenceNumber;
                                objPrjTabFldEN_P.PrjId = objvPrjTabFldEN_Like.PrjId;

                                clsPrjTabFldBL.UpdateBySql2(objPrjTabFldEN_P);
                                objvPrjTabFldEN._StrTag = "HaveAccess";//已经处理

                            }
                        }

                        break;
                    }

                    if (bolIsSetPKey == false)
                    {
                        if (objTabCheckStatusEN.ErrorMsg != "表没有主键,请添加主键!")
                        {
                            strErrMsg = "表没有主键,请添加主键!";
                            objTabCheckStatusEN.AddErrMsg(strErrMsg);

                            clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId, strTabId,
                                "", "AGC表没有主键!", (int)enumErrorLevel.SeriousError_4, "02", strUserId);
                        }
                    }
                }
                //throw new Exception(objPrjTabENEx.ErrMsg);
            }
            if (clsSpecSQLforSql.ConnectString.IndexOf("39") > 0)
            {
                //string ss = "aaa";
            }
            //2、检查表是否有主键

            if (clsPrjTabBLEx.IsExistTabKeyField(strTabId, objProjectsEN.PrjId) == false)
            {
                clsPrjTabFldEN objPrjTabFld_Key = clsPrjTabFldBLEx.GetKeyvPrjTabFldEN(arrPrjTabFldObjList);

                if (objPrjTabFld_Key != null)
                {
                    clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN(objPrjTabFld_Key.mId);
                    objPrjTabFldEN.FieldTypeId = "02";
                    objPrjTabFldEN.PrjId = objPrjTabFld_Key.PrjId;

                    clsPrjTabFldBL.UpdateBySql2(objPrjTabFldEN);
                }
                else
                {
                    StringBuilder sbMessage = new StringBuilder();
                    sbMessage.AppendFormat("当前表:{0}的没有关键字段!", objPrjTabEN.TabName);
                    strErrMsg = sbMessage.ToString();
                    objTabCheckStatusEN.AddErrMsg(strErrMsg);

                    clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId, strTabId,
                        "", "AGC表没有关键字段!", (int)enumErrorLevel.SeriousError_4, "03", strUserId);
                }
                //throw new Exception(sbMessage.ToString());
            }



            if (clsSpecSQLforSql.ConnectString.IndexOf("39") > 0)
            {
                //string ss = "aaa";
            }
            List<clsColumns> arrColumnObjList = GetColumnObjList(objPrjTabEN.TabName, strPrjDataBaseId);
            if (arrColumnObjList == null)
            {
                string strMsg = string.Format("从数据库获取表字段出错！表名:{0}.（In {0}）", objPrjTabEN.TabName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            if (arrColumnObjList == null || arrColumnObjList.Count == 0)
            {
                clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId, strTabId,
                    "", "SQL没有表字段或者没有相应表。", (int)enumErrorLevel.SeriousError_4, "01", strUserId);

                objTabCheckStatusEN.AddErrMsg("SQL没有表字段或者没有相应表!");
                return true;
            }
            //bool bolIsHaveWrong;    //是否有错

            //检查SQL数据库表字段与生成代码中的差异
            if (clsSpecSQLforSql.ConnectString.IndexOf("39") > 0)
            {
                //string ss = "aaa";
            }
            foreach (clsColumns objColumns in arrColumnObjList)
            {
                //bolIsHaveWrong = false;
                string strFldName = objColumns.Column_Name;
                clsPrjTabFldEN objvPrjTabFldT = clsPrjTabFldBLEx.GetvPrjTabFldENByFieldName(arrPrjTabFldObjList, strFldName);

                if (objvPrjTabFldT == null)
                {
                    strErrMsg = $"表:[{objPrjTabEN.TabName}],AGC字段不存在:{strFldName}不存在!";
                    clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId, strTabId,
                        "00000000", strErrMsg, (int)enumErrorLevel.GeneralError_2, "08", strUserId);
                    //bolIsHaveWrong = true;
                }
                else
                {
                    string strTypeName = objColumns.Type_Name;
                    int intLenght = objColumns.length;
                    int intPrecision = objColumns.PRECISION;

                    bool bolIs_Nullable_SQL = false;

                    if (objColumns.Is_Nullable == "YES")
                    {
                        bolIs_Nullable_SQL = true;
                    }
                    if (objColumns.Is_Nullable == "Y")
                    {
                        bolIs_Nullable_SQL = true;
                    }
                    //检查数据类型
                    CheckDataType(objvPrjTabFldT, strTypeName, objPrjTabEN, strPrjDataBaseId, strUserId);
                    //检查字段长度
                    CheckFldLength(objvPrjTabFldT, intLenght, intPrecision, objPrjTabEN, strPrjDataBaseId, strUserId);
                    //检查字段可空性
                    if (objPrjTabEN.SqlDsTypeId == "01")
                    {
                        CheckIsNullable(objvPrjTabFldT, bolIs_Nullable_SQL, objPrjTabEN, strPrjDataBaseId, strUserId);
                    }

                }

            }


            bool bolIsSameFldName = false;      //字段名是否一致
            //检查生成代码中表字段与SQL数据库的差异

            if (clsSpecSQLforSql.ConnectString.IndexOf("39") > 0)
            {
                //string ss = "aaa";
            }
            foreach (clsPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjList)
            {
                if (objPrjTabFldEN.IsForExtendClass == true) continue;
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFldEN.FldId, objPrjTabFldEN.PrjId);
                if (objFieldTab == null) continue;
                string strFldName_Agc = objFieldTab.FldName;
                string strFldType_Agc = objFieldTab.DataTypeId;
                int intFldLenght_Agc = objFieldTab.FldLength;
                //bool bolIs_Nullable_Agc = objPrjTabFldEN.IsNull;

                strFldName_Agc = strFldName_Agc.ToLower().Trim();
                bolIsSameFldName = false;
                //bolIsHaveWrong = false;

                foreach (clsColumns objColumns in arrColumnObjList)
                {
                    string strFldName_Sql = objColumns.Column_Name;
                    strFldName_Sql = strFldName_Sql.ToLower().Trim();
                    if (strFldName_Agc == strFldName_Sql)
                    {
                        bolIsSameFldName = true;

                        break;
                    }
                }
                if (bolIsSameFldName == false)
                {
                    string strTemp = string.Format("SQL字段不存在:{0}不存在! ", objFieldTab.FldName);
                    strErrMsg += strTemp;
                    clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId, strTabId,
                        objPrjTabFldEN.FldId, strTemp, (int)enumErrorLevel.SeriousError_4, "13", strUserId);


                    //bolIsHaveWrong = true;
                }

            }
            if (clsSpecSQLforSql.ConnectString.IndexOf("39") > 0)
            {
                //string ss = "aaa";
            }
            if (string.IsNullOrEmpty(strErrMsg) == false)
            {

                objTabCheckStatusEN.AddErrMsg(strErrMsg);

                //clsTabCheckResultBLEx.DeleteErrorResult(objPrjTabENEx.PrjId, strPrjDataBaseId, strTabId, "", strUserId);
                return true;
            }
            return true;
        }
        private static bool CheckFldLength(clsPrjTabFldEN objvPrjTabFldT,
    int intLenght, int intPrecision, clsPrjTabEN objPrjTabEN, string strPrjDataBaseId, string strUserId)
        {
            var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objvPrjTabFldT.FldId, objvPrjTabFldT.PrjId);
            string strErrMsg = "";
            if (objFieldTab.FldLength != intLenght
    && objFieldTab.DataTypeName().ToLower() != "decimal"
    && objFieldTab.DataTypeName().ToLower() != "text"
    && objFieldTab.DataTypeName().ToLower() != "image")
            {
                if (objPrjTabEN.SqlDsTypeId == "01")
                {
                    strErrMsg = string.Format("长度不一致!({2})SQL:{0}|AGC:{1}。", intLenght,
                        objFieldTab.FldLength,
                        objFieldTab.FldName);
                    clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId, objPrjTabEN.TabId, objvPrjTabFldT.FldId,
                        strErrMsg, (int)enumErrorLevel.MoreSeriousError_3, "06", strUserId);

                    //bolIsHaveWrong = true;
                }
            }
            if (objFieldTab.FldPrecision != intPrecision
                && objFieldTab.DataTypeName().ToLower() != "datetime"
                && objFieldTab.DataTypeName().ToLower() != "char"
                && objFieldTab.DataTypeName().ToLower() != "text"
                && objFieldTab.DataTypeName().ToLower() != "nvarchar"
                && objFieldTab.DataTypeName().ToLower() != "bool"
                && objFieldTab.DataTypeName().ToLower() != "bit"
                && objFieldTab.DataTypeName().ToLower() != "int"
                && objFieldTab.DataTypeName().ToLower() != "bigint"
                && objFieldTab.DataTypeName().ToLower() != "varchar")
            {
                if (objPrjTabEN.SqlDsTypeId == "01")
                {
                    strErrMsg = string.Format("小数不一致!({2})SQL:{0}|AGC:{1}。", intPrecision,
                        objFieldTab.FldPrecision,
                        objFieldTab.FldName);
                    clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId, objPrjTabEN.TabId, objvPrjTabFldT.FldId,
                        strErrMsg, (int)enumErrorLevel.SeriousError_4, "17", strUserId);

                    //bolIsHaveWrong = true;
                }
            }

            return true;
        }

        private static bool CheckIsNullable(clsPrjTabFldEN objvPrjTabFldT,
           bool bolIs_Nullable_SQL, clsPrjTabEN objPrjTabEN, string strPrjDataBaseId, string strUserId)
        {
            string strErrMsg = "";
            if (objvPrjTabFldT.IsTabNullable != bolIs_Nullable_SQL)
            {
                string strTemp = string.Format("<可空>不一致!({2})SQL:{0}|AGC:{1}。",
                    bolIs_Nullable_SQL, objvPrjTabFldT.IsTabNullable,
                    objvPrjTabFldT.FldName());
                strErrMsg += strTemp;
                clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId, objPrjTabEN.TabId, objvPrjTabFldT.FldId,
                    strTemp, (int)enumErrorLevel.GeneralError_2, "07", strUserId);

                //bolIsHaveWrong = true;

            }

            return true;
        }


        private static bool CheckSqlViewFld(List<clsvSqlViewFldEN> arrvSqlViewFldObjList,
                List<clsPrjTabFldEN> arrPrjTabFldObjList,
                clsPrjTabEN objPrjTabEN, string strPrjDataBaseId, string strUserId)
        {

            string strErrMsg = "";
            if (objPrjTabEN.IsReleToSqlTab == false)
            {
                return true;
            }
            if (arrvSqlViewFldObjList.Count == 0)
            {
                clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId, objPrjTabEN.TabId,
                    "", "SQLView没有字段, 请导入Sql视图并分析。", (int)enumErrorLevel.SeriousError_4, "16", strUserId);
                var objTabCheckStatusEN = clsTabCheckStatusBLEx.GetObjByTabIdCacheEx(objPrjTabEN.TabId, objPrjTabEN.PrjId, strPrjDataBaseId);
                objTabCheckStatusEN.AddErrMsg("SQLView没有字段, 请导入Sql视图并分析");
                return true;
            }

            foreach (clsvSqlViewFldEN objvSqlViewFlds in arrvSqlViewFldObjList)
            {
                //bolIsHaveWrong = false;
                string strFldName = objvSqlViewFlds.FieldAliases;
                if (string.IsNullOrEmpty(strFldName) == true)
                {
                    strFldName = objvSqlViewFlds.FldName;
                }
                clsPrjTabFldEN objvPrjTabFldT = clsPrjTabFldBLEx.GetvPrjTabFldENByFieldName(arrPrjTabFldObjList, strFldName);

                if (objvPrjTabFldT == null)
                {
                    string strTemp = string.Format("检查视图字段时，视图中有的字段在AGC字段不存在:{0}不存在!({1})",
                        strFldName, clsStackTrace.GetCurrClassFunction());
                    strErrMsg += strTemp;

                    clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId, objPrjTabEN.TabId,
                        "00000000", strTemp, (int)enumErrorLevel.GeneralError_2, "08", strUserId);
                    //bolIsHaveWrong = true;
                }
                else
                {

                }
            }
            return true;
        }

        /// <summary>
        /// 根据数据库中相关表来检查生成代码中的表对象字段,例如主键和相关字段
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <returns>是否成功!</returns>
        public static bool CheckPrjTabvSqlViewFldBySQLView_Agc(string strTabId, clsProjectsEN objProjectsEN, string strPrjDataBaseId, string strUserId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(strTabId, objProjectsEN.PrjId);
            if (objPrjTabEN == null) return false;
            var objTabCheckStatusEN = clsTabCheckStatusBLEx.GetObjByTabIdCacheEx(strTabId, objPrjTabEN.PrjId, strPrjDataBaseId);

            if (objPrjTabEN.SqlDsTypeId == clsSQLDSTypeENEx.SQLTAB) return true;

            string strCurrDate = clsDateTime.getTodayDateTimeStr(1);
            string strErrMsg = "";
            //操作步骤:
            //1、检查主键类型是否正确
            //2、检查表是否有主键   
            //3、检查生成代码字段在SQL表中是否存在
            //
            List<clsPrjTabFldEN> arrPrjTabFldObjList = clsPrjTabFldBLEx.GetObjLstByTabIdCache(strTabId, objProjectsEN.PrjId);
            if (arrPrjTabFldObjList.Count == 0)
            {
                clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId, strTabId,
                    "", "AGC没有表字段。", (int)enumErrorLevel.SeriousError_4, "14", strUserId);

                objTabCheckStatusEN.AddErrMsg("AGC没有表字段");
                return true;
            }

            //2、检查主键类型是否正确
            //string strPrimaryTypeId;
            //bool bolIsHavePrimary = false;

            //string strCondition = string.Format("SqlViewName = '{0}' And PrjId = '{1}'", objPrjTabEN.TabName, objPrjTabEN.PrjId);
            List<clsvSqlViewFldEN> arrvSqlViewFldObjList = clsvSqlViewFldBLEx.GetvSqlViewFldObjSubLstBySqlViewNameExCache(objPrjTabEN.PrjId, objPrjTabEN.TabName);
            if (arrvSqlViewFldObjList == null)
            {
                clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId, objPrjTabEN.TabId,
                    "", "SQLView没有字段, 请导入Sql视图并分析。", (int)enumErrorLevel.SeriousError_4, "16", strUserId);

                objTabCheckStatusEN.AddErrMsg("SQLView没有字段, 请导入Sql视图并分析");
                return false;
            }
            //bool bolIsHaveWrong;    //是否有错

            //检查SQL数据库表字段与生成代码中的差异
            CheckSqlViewFld(arrvSqlViewFldObjList, arrPrjTabFldObjList,
                objPrjTabEN, strPrjDataBaseId, strUserId);

            bool bolIsSameFldName = false;      //字段名是否一致
            //检查生成代码中表字段与SQL数据库的差异

            foreach (clsPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjList)
            {
                if (objPrjTabFldEN.IsForExtendClass == true) continue;
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFldEN.FldId, objPrjTabFldEN.PrjId);
                string strFldName_Agc = objFieldTab.FldName;
                string strFldType_Agc = objFieldTab.DataTypeId;
                int intFldLenght_Agc = objFieldTab.FldLength;
                //bool bolIs_Nullable_Agc = objPrjTabFldEN.IsNull;

                strFldName_Agc = strFldName_Agc.ToLower().Trim();
                bolIsSameFldName = false;
                //bolIsHaveWrong = false;

                foreach (clsvSqlViewFldEN objvSqlViewFlds in arrvSqlViewFldObjList)
                {
                    string strFldName_Sql = objvSqlViewFlds.FieldAliases;
                    if (string.IsNullOrEmpty(strFldName_Sql) == true)
                    {
                        strFldName_Sql = objvSqlViewFlds.FldName;
                    }
                    strFldName_Sql = strFldName_Sql.ToLower().Trim();
                    if (strFldName_Agc == strFldName_Sql)
                    {
                        bolIsSameFldName = true;
                        break;
                    }
                }
                if (bolIsSameFldName == false)
                {
                    string strTemp = string.Format("SQLVIEW字段不存在:{0}不存在!该数据库比Agc库少字段。 ", objFieldTab.FldName);
                    strErrMsg += strTemp;
                    clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId, strTabId,
                        objPrjTabFldEN.FldId, strTemp, (int)enumErrorLevel.SeriousError_4, "15", strUserId);
                    //bolIsHaveWrong = true;
                }

            }

            objTabCheckStatusEN.AddErrMsg(strErrMsg);

            return true;
        }

        /// <summary>
        /// 根据数据库中相关表来检查生成代码中的表对象字段,例如主键和相关字段
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <returns>是否成功!</returns>
        public static bool SetPrjTabFldNullBySQLTab(string strTabId, clsProjectsEN objProjectsEN, string strPrjDataBaseId, string strUserId)
        {
            clsPrjTabEN objPrjTabENEx = clsPrjTabBL.GetObjByTabId(strTabId);

            string strCurrDate = clsDateTime.getTodayDateTimeStr(1);
            string strErrMsg = "";
            //操作步骤:
            //1、检查主键类型是否正确
            //2、检查表是否有主键   
            //3、检查生成代码字段在SQL表中是否存在
            //
            List<clsPrjTabFldEN> arrPrjTabFldObjList = clsPrjTabFldBLEx.GetObjLstByTabIdCache(strTabId, objProjectsEN.PrjId);
            List<clsColumns> arrColumnObjList = GetColumnObjList(objPrjTabENEx.TabName, strPrjDataBaseId);
            //检查SQL数据库表字段与生成代码中的差异
            if (arrColumnObjList.Count == 0)
            {
                clsTabCheckResultBLEx.AddErrorResult(objPrjTabENEx.PrjId, strPrjDataBaseId, strTabId,
                    "", "SQL没有表字段或者没有相应表。", (int)enumErrorLevel.SeriousError_4, "01", strUserId);
                return true;
            }

            foreach (clsColumns objColumns in arrColumnObjList)
            {

                string strFldName = objColumns.Column_Name;
                clsPrjTabFldEN objvPrjTabFldT = clsPrjTabFldBLEx.GetvPrjTabFldENByFieldName(arrPrjTabFldObjList, strFldName);

                if (objvPrjTabFldT == null)
                {

                    strErrMsg = $"表:[{objPrjTabENEx.TabName}],AGC字段不存在:{strFldName}不存在!";
                    clsTabCheckResultBLEx.AddErrorResult(objPrjTabENEx.PrjId, strPrjDataBaseId, strTabId,
                        "00000000", strErrMsg, (int)enumErrorLevel.GeneralError_2, "08", strUserId);
                    continue;
                }

                string strTypeName = objColumns.Type_Name;
                int intLenght = objColumns.length;
                bool bolIs_Nullable_SQL = false;

                if (objColumns.Is_Nullable == "YES")
                {
                    bolIs_Nullable_SQL = true;
                }
                if (objColumns.Is_Nullable == "Y")
                {
                    bolIs_Nullable_SQL = true;
                }
                if (objvPrjTabFldT.IsTabNullable != bolIs_Nullable_SQL)
                {
                    clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN(objvPrjTabFldT.mId);

                    objPrjTabFldEN.IsTabNullable = bolIs_Nullable_SQL;
                    objPrjTabFldEN.PrjId = objPrjTabENEx.PrjId;

                    clsPrjTabFldBL.UpdateBySql2(objPrjTabFldEN);
                }
            }

            return true;
        }
        /// <summary>
        /// 根据数据库中相关表来检查生成代码中的表对象,检查工程中所有表对象
        /// </summary>
        /// <param name = "objProjectsEN">工程对象</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <returns>是否成功!</returns>
        public static bool CheckPrjTabBySQLTab(clsProjectsEN objProjectsEN, string strPrjDataBaseId, string strUserId)
        {
            string strCurrDate = clsDateTime.getTodayDateTimeStr(1);

            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);

            string strConnectString = clsPrjDataBaseBLEx.GetConnectString(strPrjDataBaseId);
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            DataTable objDT = objSQL.getTableAndViews();


            IEnumerable<clsTabCheckStatusEN> arrTabCheckStatusObjLst = null;
            string strCondition = string.Format("prjId = '{0}' And IsNeedCheckTab = '1'", objProjectsEN.PrjId);
            List<clsTabCheckStatusEN> arrTabCheckStatusCache = clsTabCheckStatusBL.GetObjLstCache(objProjectsEN.PrjId);
            arrTabCheckStatusObjLst = arrTabCheckStatusCache.Where(x => x.IsNeedCheckTab == true);

            foreach (clsTabCheckStatusEN objTabCheckStatusEN in arrTabCheckStatusObjLst)
            {
                try
                {
                    var objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objTabCheckStatusEN.TabId, objTabCheckStatusEN.PrjId);
                    if (objPrjTabEN == null) continue;
                    if (objPrjTabEN.IsReleToSqlTab == false) continue;
                    bool bolIsSuccess = false;
                    string strTabName_S = objPrjTabEN.TabName.ToLower().Trim();
                    try
                    {
                        clsTabCheckStatusBLEx.CheckTabForeignKeyByTabName(objPrjTabEN.PrjId, strPrjDataBaseId, objPrjTabEN.TabName, strUserId);

                        foreach (DataRow objDR in objDT.Rows)
                        {
                            string strTabName_T = objDR["name"].ToString().ToLower().Trim();

                            if (strTabName_S.Equals(strTabName_T, StringComparison.InvariantCultureIgnoreCase) == true)
                            {
                                bolIsSuccess = true;
                                break;
                            }
                        }
                        if (bolIsSuccess == false)
                        {
                            clsTabCheckResultBLEx.AddErrorResult(objProjectsEN.PrjId, objPrjDataBaseEN.PrjDataBaseId,
                                objPrjTabEN.TabId, "", "SQL中没有表:" + strTabName_S, (int)enumErrorLevel.SeriousError_4, "04", strUserId);

                            objTabCheckStatusEN.AddErrMsg("SQL中没有表|" + strTabName_S);
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("在函数:【CheckPrjTabBySQLTab】中,在处理表:{0}时出问题。错误:{1}", objPrjTabEN.TabName, objException.Message);
                        throw new Exception(strMsg);
                    }
                }
                catch (Exception objException)
                {
                    string strMsg = objException.Message;
                    throw new Exception(strMsg);
                }
                //objPrjTabEN.IsNeedCheckTab = false;
                //clsPrjTabBL.UpdateBySql2(objPrjTabEN);
            }

            return true;
        }

        /// <summary>
        /// 根据表检查表相关的主外键关系
        /// </summary>
        /// <param name = "strPrjId"></param>
        /// <param name = "strTabName"></param>
        /// <param name = "strUserId"></param>
        /// <returns></returns>
        public static bool CheckTabForeignKeyByTabName(string strPrjId, string strPrjDataBaseId, string strTabName, string strUserId)
        {
            List<clsFKeys> arrFKeysObjList = clsTabCheckStatusBLEx.GetForeignKeyObjLstByTabName(strPrjId, strPrjDataBaseId, strTabName, strUserId);
            //string strCondition = string.Format("TabName = '{0}' And PrjId = '{1}'", strTabName, strPrjId);
            bool bolIsUpdate4Tab = false;
            clsPrjTabEN objRelePrjTab = clsPrjTabBLEx.GetObjByTabNameExCache(strPrjId, strTabName);
            if (strTabName == "SetFieldVisibility")
            {
                //string ss = "SS";
            }
            List<clsvPrjTabFldEN> arrvPrjTabFldObjLst = clsvPrjTabFldBLEx.GetObjLstByTabIdCache0(objRelePrjTab.TabId, strPrjId);
            try
            {
                foreach (clsFKeys objFKeys in arrFKeysObjList)
                {
                    string strFldName = objFKeys.FKeyColumnName;
                    foreach (clsvPrjTabFldEN objvPrjTabFldEN in arrvPrjTabFldObjLst)
                    {
                        if (strFldName.Equals(objvPrjTabFldEN.FldName, StringComparison.InvariantCultureIgnoreCase) == false) continue;

                        clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objvPrjTabFldEN.DataTypeId);
                        clsPrjTabFldEN objPrjTabFldEN = clsPrjTabFldBL.GetObjBymIdCache(objvPrjTabFldEN.mId, objvPrjTabFldEN.PrjId);

                        if (objDataTypeAbbrEN.DataTypeName == "varchar")
                        {
                            if (objPrjTabFldEN.IsTabForeignKey == true)
                            {
                                objPrjTabFldEN.IsTabForeignKey = false;
                                string strCondition2 = string.Format("TabName = '{0}' And PrjId = '{1}'", objFKeys.PKeyTabName, strPrjId);
                                clsPrjTabEN objPKeysPrjTabEN = clsPrjTabBL.GetFirstObj_S(strCondition2);
                                if (objPKeysPrjTabEN == null)
                                {
                                    StringBuilder sbMsg = new StringBuilder();
                                    sbMsg.AppendFormat("在生成代码系统中,没有表:{0},请检查!", objFKeys.PKeyTabName);
                                    throw new Exception(sbMsg.ToString());
                                }
                                objPrjTabFldEN.ForeignKeyTabId = "";

                                try
                                {
                                    clsPrjTabFldBL.UpdateBySql2(objPrjTabFldEN);
                                }
                                catch (Exception objException)
                                {
                                    StringBuilder sbMsg = new StringBuilder();
                                    sbMsg.AppendFormat("在设置字段:{0}的外键属性时出错,出错信息:{1}。", objvPrjTabFldEN.FldName, objException.Message);
                                    throw new Exception(sbMsg.ToString());
                                }
                                bolIsUpdate4Tab = true;
                            }
                        }
                        else
                        {
                            if (objPrjTabFldEN.IsTabForeignKey == false)
                            {
                                objPrjTabFldEN.IsTabForeignKey = true;
                                string strCondition2 = string.Format("TabName = '{0}' And PrjId = '{1}'", objFKeys.PKeyTabName, strPrjId);
                                clsPrjTabEN objPKeysPrjTabEN = clsPrjTabBL.GetFirstObj_S(strCondition2);
                                if (objPKeysPrjTabEN == null)
                                {
                                    //StringBuilder sbMsg = new StringBuilder();
                                    //sbMsg.AppendFormat("在生成代码系统中,没有表:{0},请检查!", objFKeys.PKeyTabName);
                                    //throw new Exception(sbMsg.ToString());
                                    continue;
                                }

                                objPrjTabFldEN.ForeignKeyTabId = objPKeysPrjTabEN.TabId;
                                try
                                {
                                    clsPrjTabFldBL.UpdateBySql2(objPrjTabFldEN);
                                }
                                catch (Exception objException)
                                {
                                    StringBuilder sbMsg = new StringBuilder();
                                    sbMsg.AppendFormat("在设置字段:{0}的外键属性时出错,出错信息:{1}。", objvPrjTabFldEN.FldName, objException.Message);
                                    throw new Exception(sbMsg.ToString());
                                }
                                bolIsUpdate4Tab = true;
                            }
                        }

                    }//foreach (clsvPrjTabFldEN objvPrjTabFldEN
                }//foreach(clsFKeys objFKeys
                if (bolIsUpdate4Tab == true)
                {
                    var objTabCheckStatus = clsTabCheckStatusBLEx.GetObjByTabIdCacheEx(objRelePrjTab.TabId, objRelePrjTab.PrjId, strPrjDataBaseId);

                    objTabCheckStatus.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objTabCheckStatus.UpdUser = strUserId;
                    objTabCheckStatus.IsNeedCheckTab = false;
                    clsTabCheckStatusBL.UpdateBySql2(objTabCheckStatus);
                }
            }

            catch (Exception objException)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("在类:{0}的函数{1}中,", "clsPrjTabBLEx", "CheckTabForeignKeyByTabName");
                sbMsg.AppendFormat("根据表检查表相关的主外键关系,检查表:{0}时出错,错误信息:{1}。", strTabName, objException.Message);
                throw new Exception(sbMsg.ToString());
            }


            return true;
        }


        /// <summary>
        /// 根据数据库中相关表来检查生成代码中的表对象,仅仅检查一个表
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <returns>是否成功!</returns>
        public static bool CheckPrjTabBySQLTab4OneTab(string strTabId, string strPrjId, string strPrjDataBaseId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            clsTabCheckStatusEN objTabCheckStatusEN = clsTabCheckStatusBLEx.GetObjByTabIdCacheEx(strTabId, strPrjId, strPrjDataBaseId);

            //操作步骤:
            //1、检查表是否有主键
            //2、检查主键类型是否正确
            //3、检查生成代码字段在SQL表中是否存在
            if (objPrjTabEN.TabTypeId == enumTabType.PureClass_0008) return true;

            if (objPrjTabEN.IsReleToSqlTab == false) return true;
            //1、检查表是否有主键

            if (clsPrjTabBLEx.IsExistTabKeyField(strTabId, strPrjId) == false)
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("当前表:{0}的没有关键字段!", objPrjTabEN.TabName);
                throw new Exception(sbMessage.ToString());
            }
            //2、检查主键类型是否正确
            string strPrimaryTypeId;
            bool bolIsHavePrimary = false;
            List<clsPrjTabFldEN> arrPrjTabFldObjList = clsPrjTabFldBLEx.GetObjLstByTabIdCache(strTabId, objPrjTabEN.PrjId);
            arrPrjTabFldObjList = arrPrjTabFldObjList.Where(x => x.IsForExtendClass == false).ToList();
            foreach (clsPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjList)
            {
                if (objPrjTabFldEN.IsForExtendClass == true) continue;
                strPrimaryTypeId = objPrjTabFldEN.PrimaryTypeId;
                if (objPrjTabFldEN.FieldTypeId == enumFieldType.KeyField_02)
                {
                    bolIsHavePrimary = true;
                    bool bolIsSuccess = false;
                    switch (strPrimaryTypeId)
                    {
                        case "00": //非关键字

                            if (objTabCheckStatusEN.ErrorMsg != "表主键字段的主键类型只能是主关键字或者Identity主键!")
                            {
                                objTabCheckStatusEN.AddErrMsg("表主键字段的主键类型只能是主关键字或者Identity主键!");
                            }
                            objPrjTabFldEN.ErrMsg = "表主键字段的主键类型只能是主关键字或者Identity主键!";
                            objPrjTabFldEN.Update();
                            throw new Exception(objTabCheckStatusEN.ErrorMsg);
                        case enumPrimaryType.Identity_02:
                            //List<string> arr = clsPrjConstraintBLEx.GetObjLstByTabName();
                            bolIsSuccess = clsPrjConstraintBLEx.CheckUniqueness(strTabId, strPrjId);
                            if (bolIsSuccess == false)
                            {
                                objTabCheckStatusEN.AddErrMsg($"表[{objPrjTabEN.TabName}]主键类型为Identity, 但表没有相关约束!");
                                objPrjTabFldEN.ErrMsg = $"表[{objPrjTabEN.TabName}]主键类型为Identity, 但表没有相关约束!";
                                objPrjTabFldEN.Update();
                                throw new Exception(objTabCheckStatusEN.ErrorMsg);
                            }
                            break;
                        case enumPrimaryType.StringAutoAddPrimaryKey_03:
                            //List<string> arr = clsPrjConstraintBLEx.GetObjLstByTabName();
                            bolIsSuccess = clsPrjConstraintBLEx.CheckUniqueness(strTabId, strPrjId);
                            if (bolIsSuccess == false)
                            {
                                objTabCheckStatusEN.AddErrMsg($"表[{objPrjTabEN.TabName}]主键类型为自动增加字符串, 但表没有相关约束!");
                                objPrjTabFldEN.ErrMsg = $"表[{objPrjTabEN.TabName}]主键类型为自动增加字符串, 但表没有相关约束!";
                                objPrjTabFldEN.Update();
                                throw new Exception(objTabCheckStatusEN.ErrorMsg);
                            }
                            break;
                        default:
                            break;
                    }

                }
            }
            if (bolIsHavePrimary == false)
            {
                if (objTabCheckStatusEN.ErrorMsg != "表没有主键,请添加主键!")
                {
                    objPrjTabEN.ErrMsg = $"表没有主键,请添加主键";
                    objPrjTabEN.Update();
                    objTabCheckStatusEN.AddErrMsg("表没有主键,请添加主键!");

                }
                throw new Exception(objTabCheckStatusEN.ErrorMsg);
            }
            //3、检查生成代码字段在SQL表中是否存在
            clsProjectsENEx objProjects = clsProjectsBLEx.GetProjectsENExObjByPrjId(objPrjTabEN.PrjId);
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            foreach (clsPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjList)
            {
                if (objPrjTabFldEN.IsForExtendClass == true) continue;
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFldEN.FldId, strPrjId);
                if (objFieldTab == null) continue;
                string strConnectStr = clsPrjDataBaseBLEx.GetConnectString(strPrjDataBaseId);
                if (clsSqlObject.IsExistColumnInTable(strConnectStr, objPrjTabEN.TabName,
                                objPrjDataBaseEN.DatabaseOwner,
                                objFieldTab.FldName) == false)
                {
                    StringBuilder sbMessage = new StringBuilder();
                    sbMessage.AppendFormat("当前表:{0}没有{1}({2})字段!请检查!",
                        objPrjTabEN.TabName,
                        objFieldTab.FldName,
                        objFieldTab.Caption);
                    objPrjTabFldEN.ErrMsg = sbMessage.ToString();
                    objPrjTabFldEN.Update();
                    throw new Exception(sbMessage.ToString());
                }
            }

            if (objTabCheckStatusEN.ErrorMsg != "")
            {
                //objPrjTabEN.ErrMsg = "";
                //clsPrjTabBL.UpdateBySql2(objPrjTabEN);

                return true;
            }
            return true;
        }

        /// <summary>
        /// 获取与表相关的主外键关系
        /// </summary>
        /// <param name = "strPrjId"></param>
        /// <param name = "strTabName"></param>
        /// <param name = "strUserId"></param>
        /// <returns></returns>
        public static List<clsFKeys> GetForeignKeyObjLstByTabName(string strPrjId, string strPrjDataBaseId, string strTabName, string strUserId)
        {
            //clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strConnectString = clsPrjDataBaseBLEx.GetConnectString(objPrjDataBaseEN);
            //bool bolResult = true;

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);

            //string strTabId;

            string strObjName;
            string strObjFunction;
            //string strFldCaption;
            //string strFldName;
            //string strFldType;
            //string strTabCnName, strTabMemo;
            //string strIsNull;
            //int intFldLength;
            //string strResult = "";
            //bool bolIsNull;

            //string strFuncModuleId = "";

            strObjName = strTabName;
            strObjFunction = strTabName;

            //4、再向该视图对象表中添加相关字段。
            List<clsFKeys> arrFKeysObjList = clsSqlObject.GetFKeyObjList(strConnectString, strTabName,
                objPrjDataBaseEN.DatabaseOwner);
            return arrFKeysObjList;

        }
        /// <summary>
        /// 功能:获取给定表的所有列信息
        /// </summary>
        /// <param name = "strTabName">给定的表名</param>
        /// <returns>给定表的所有列信息,以DataTable形式</returns>
        public static List<clsColumns> GetColumnObjList(string strTabName, string strPrjDataBaseId)
        {
            List<clsColumns> arrColumnObjList = new List<clsColumns>();
            System.Data.DataTable objDT;
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);

            clsSpecSQLforSql objSQL = getSpecSQLByPrjId(strPrjDataBaseId);
            objDT = objSQL.GetColumns(strTabName, objPrjDataBaseEN.DatabaseOwner);

            foreach (DataRow objRow in objDT.Rows)
            {
                clsColumns objColumns = new clsColumns();
                objColumns.Column_Name = objRow["Column_Name"].ToString().Trim();
                objColumns.Type_Name = objRow["Type_Name"].ToString().Trim();
                objColumns.length = int.Parse(objRow["length"].ToString());
                objColumns.PRECISION = clsGeneralTab2.TransNullToInt_S(objRow["SCALE"].ToString());
                objColumns.Is_Nullable = objRow["Is_Nullable"].ToString();
                arrColumnObjList.Add(objColumns);
            }
            return arrColumnObjList;
        }

        public static clsSpecSQLforSql getSpecSQLByPrjId(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(objPrjDataBaseEN.IpAddress,
                objPrjDataBaseEN.DataBaseName,
                objPrjDataBaseEN.DataBaseUserId,
                objPrjDataBaseEN.DataBasePwd);
            return objSQL;
        }

        private static bool CheckDataType(clsPrjTabFldEN objvPrjTabFldT, string strTypeName, clsPrjTabEN objPrjTabEN, string strPrjDataBaseId, string strUserId)
        {
            var objDataType = objvPrjTabFldT.ObjFieldTab().ObjDataTypeAbbr();
            if (objDataType.DataTypeName != strTypeName && objDataType.OraDbType != strTypeName)
            {
                //类型不一致!(mId)SQL:bigint identity|AGC:bigint
                if (objDataType.DataTypeName.ToLower() == "bigint" && strTypeName == "bigint identity"
                    || objDataType.DataTypeName.ToLower() == "int" && strTypeName == "int identity")
                {
                }
                else
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN1 = clsDataTypeAbbrBLEx.GetObjByDataTypeNameCache(objDataType.DataTypeName);
                    clsDataTypeAbbrEN objDataTypeAbbrEN2 = clsDataTypeAbbrBLEx.GetObjByDataTypeNameCache(strTypeName);

                    string strErrMsg = string.Format("类型不一致!({2})SQL:{0}|AGC:{1}。", strTypeName,
                        objDataType.DataTypeName,
                        objvPrjTabFldT.FldName());
                    if (objDataTypeAbbrEN1.CsType != objDataTypeAbbrEN2.CsType)
                    {
                        clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId, objPrjTabEN.TabId, objvPrjTabFldT.FldId,
                             strErrMsg, (int)enumErrorLevel.SeriousError_4, "05", strUserId);
                    }
                    else
                    {
                        clsTabCheckResultBLEx.AddErrorResult(objPrjTabEN.PrjId, strPrjDataBaseId, objPrjTabEN.TabId, objvPrjTabFldT.FldId,
                            strErrMsg, (int)enumErrorLevel.GeneralError_2, "05", strUserId);
                    }
                    //bolIsHaveWrong = true;
                }
            }

            return true;
        }


        /// <summary>
        /// 根据数据库中相关表来检查生成代码中的表对象
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <returns>是否成功!</returns>
        public static bool CheckSQLTabByPrjTab(clsProjectsEN objProjectsEN, string strPrjDataBaseId, string strUserId)
        {
            string strCurrDate = clsDateTime.getTodayDateTimeStr(1);
            //string strErrMsg = "";
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);

            string strConnectString = clsPrjDataBaseBLEx.GetConnectString(strPrjDataBaseId);
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            DataTable objDT = objSQL.getTableAndViews();


            List<clsTabCheckStatusEN> arrTabCheckStatusObjLst = null;
            string strCondition = string.Format("prjId = '{0}' And IsNeedCheckTab = '1'", objProjectsEN.PrjId);
            arrTabCheckStatusObjLst = clsTabCheckStatusBL.GetObjLst(strCondition);
            string strTabName_T = "";
            foreach (DataRow objDR in objDT.Rows)
            {
                try
                {
                    strTabName_T = objDR["name"].ToString().ToLower().Trim();
                    bool bolIsSuccess = false;
                    foreach (clsTabCheckStatusEN objTabCheckStatus in arrTabCheckStatusObjLst)
                    {
                        try
                        {
                            var objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objTabCheckStatus.TabId, objTabCheckStatus.PrjId);
                            if (objPrjTabEN == null) continue;
                            string strTabName_S = objPrjTabEN.TabName.ToLower().Trim();

                            if (strTabName_S.Equals(strTabName_T, StringComparison.InvariantCultureIgnoreCase) == true)
                            {
                                bolIsSuccess = true;
                                break;
                            }
                        }
                        catch (Exception objException1)
                        {
                            string strMsg = string.Format("检查Sql表出错！表名:{0}. in ({1})。错误:{2}",
                                strTabName_T, clsStackTrace.GetCurrClassFunction(), objException1.Message);
                            throw new Exception(strMsg);
                        }
                    }
                    if (bolIsSuccess == false)
                    {
                        clsTabCheckResultBLEx.AddErrorResult(objProjectsEN.PrjId, objPrjDataBaseEN.PrjDataBaseId,
                            "", "", "AGC表没有表:" + strTabName_T, (int)enumErrorLevel.MoreSeriousError_3, "11", strUserId);
                    }
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("检查Sql表出错！表名:{0}. in ({1})。错误:{2}",
                        strTabName_T, clsStackTrace.GetCurrClassFunction(), objException.Message);
                    throw new Exception(strMsg);
                }
            }

            return true;
        }
        /// <summary>
        /// 根据数据库中相关表来检查生成代码中的表对象字段,例如主键和相关字段
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strPrjDataBaseId">工程数据库Id</param>
        /// <param name = "bolIsDelOldCheckData">是否删除老的检查数据</param>
        /// <param name = "strUserId">用户Id</param>
        /// <returns>是否成功!</returns>
        public static bool CheckPrjTabColumnBySQLTab(string strTabId, string strPrjId, string strPrjDataBaseId, bool bolIsDelOldCheckData, string strUserId)
        {
            if (strTabId.Substring(0, 4) != strPrjId)
            {
                string strMsg = string.Format("(errid:BlEx000041)工程Id:[{0}],表Id:[{1}], 两者不相配,请检查!(clsPrjTabBLEx:CheckPrjTabColumnBySQLTab)", strPrjId, strTabId);
                throw new Exception(strMsg);
            }
            clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(strPrjId);

            if (bolIsDelOldCheckData == true)
            {
                string strCondition = string.Format("PrjId = '{0}' And TabId = '{1}'", objProjectsEN.PrjId, strTabId);
                clsTabCheckResultBL.DelTabCheckResultsByCond(strCondition);
                clsTabCheckStatusBLEx.RemoveErrMsg(objProjectsEN.PrjId, strTabId);
            }
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            clsTabCheckStatusBLEx.CheckPrjTabvSqlViewFldBySQLView_Agc(strTabId, objProjectsEN, strPrjDataBaseId, strUserId);
            return clsTabCheckStatusBLEx.CheckPrjTabColumnBySQLTabDetail(strTabId, objProjectsEN, objPrjDataBaseEN.PrjDataBaseId, strUserId);
        }


        /// <summary>
        /// 功能:移去错误信息
        /// </summary>
        /// <param name = "strPrjId">工程id</param>
        /// <returns>返回修改的记录数。</returns>
        public static int RemoveErrMsg(string strPrjId, string strTabId)
        {
            if (strTabId.Substring(0, 4) != strPrjId)
            {
                string strMsg = string.Format("(errid:BlEx000042)工程Id:[{0}],表Id:[{1}], 两者不相配,请检查!(clsTabCheckStatusBLEx:RemoveErrMsg)", strPrjId, strTabId);
                throw new Exception(strMsg);
            }
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
            string strSQL;
            if (string.IsNullOrEmpty(strPrjId))
            {
                return 0;	//表示删除0条记录,实际上是不能该表的所有记录
            }
            else
            {
                strSQL = string.Format("Update TabCheckStatus Set ErrorMsg = '', ErrorLevelId = -1 where PrjId = '{0}' And TabId = '{1}'", strPrjId, strTabId);
            }
            int intRecoCount = objSQL.ExecSql2(strSQL);
            clsTabCheckStatusBL.ReFreshCache(strPrjId);
            return intRecoCount;
        }

    }
}
