
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsFieldTabExWApi
表名:FieldTab(00050021)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 18:59:30
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护
模块英文名:Table_Field
框架-层名:WebApi访问扩展层(WA_AccessEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Collections;
using com.taishsoft.common;
using System.ServiceModel;
using AGC.Entity;

using System.Collections.Generic;
using com.taishsoft.json;


namespace AGC4WApi
{
    /// <summary>
    /// 工程字段(FieldTab)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsFieldTabExWApi
    {
        //private static readonly string mstrApiControllerName = "FieldTabExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsFieldTabEN> arrFieldTabObjLst_Cache = null;
        public static List<clsFieldTabENEx> arrFieldTabENExObjLstOrderByFldId_Cache = null;
        public static List<clsFieldTabENEx> arrFieldTabENExObjLst4WinApp = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;
        public static string strPrjId_Cache = "";

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsFieldTabExWApi()
        {
        }
        public static clsFieldTabENEx GetObjExByFldIDCache(string strFldID, string strPrjId)
        {
            string strCondition = "";

            strCondition = string.Format("PrjId = '{0}' order by FldId", strPrjId);

            if (arrFieldTabENExObjLstOrderByFldId_Cache == null || strFldID.Substring(0, 4) != strPrjId_Cache || strPrjId != strPrjId_Cache)
            {
                strPrjId_Cache = strPrjId;
                arrFieldTabENExObjLstOrderByFldId_Cache = clsFieldTabExWApi.GetFieldTabENExObjList(strCondition);
                //intFldNum = arrFieldTabENExObjLstOrderByFldId_Cache.Count;
            }

            clsFieldTabENEx objFieldTabEN = arrFieldTabENExObjLstOrderByFldId_Cache.Find(x => x.FldId == strFldID);
            if (objFieldTabEN != null)
            {
                clsFieldTabENEx objTarFieldTab = new clsFieldTabENEx();
                clsFieldTabWApi.CopyTo(objFieldTabEN, objTarFieldTab);

                return objTarFieldTab;
            }

            intFindFailCount++;
            // 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
            arrFieldTabENExObjLstOrderByFldId_Cache = null;
            if (intFindFailCount == 1)
            {
                return GetObjExByFldIDCache(strFldID, strPrjId);
            }
            clsFieldTabENEx objFieldTabEx = clsFieldTabExWApi.GetObjExByFldId(strFldID);
            if (objFieldTabEx != null) return objFieldTabEx;

            string strErrMsgForGetObjById = string.Format("在FieldTab表中,找不到记录[FldId = {0}](函数:GetObjExByFldID_Cache).", strFldID);
            clsLog.LogErrorS2("clsFieldTabBLEx", "GetObjExByFldID_Cache", strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }
        public static clsFieldTabENEx InitFieldTab(string strFldId, string strCmPrjId)
        {
            if (string.IsNullOrEmpty(strFldId))
                throw new Exception("字段ID为空,请检查!当前表为FieldTab,关键字为:" + strFldId);

            if (string.IsNullOrEmpty(strCmPrjId))
                throw new Exception("Cm工程ID为空,请检查!当前表为FieldTab,关键字为:" + strFldId);

            if ( strCmPrjId.Length != 6)
            {
                throw new Exception("字段[strCmPrjId]的长度应该等于6!");
            }
            string strPrjId = clsCMProjectExWApi.GetPrjIdByCmPrjIdCache(strCmPrjId);
            clsFieldTabENEx objFieldTabENEx = clsFieldTabExWApi.GetObjExByFldIDCache(strFldId, strPrjId);
            var objFieldTab4CodeConv = clsFieldTab4CodeConvWApi.GetObjByFldIdCache(objFieldTabENEx.FldId, objFieldTabENEx.PrjId);
            if (objFieldTab4CodeConv != null)
            {
                try
                {
                    if (string.IsNullOrEmpty(objFieldTab4CodeConv.CodeTabId) == true)
                    {
                        string strMsg = string.Format("字段：{0}为转换字段，转换表为空，请检查！", objFieldTabENEx.FldName);
                        clsPubVar4WApi.objLog4Error.WriteDebugLog(strMsg);
                    }
                    if (string.IsNullOrEmpty(objFieldTab4CodeConv.CodeTabNameId) == true)
                    {
                        string strMsg = string.Format("字段：{0}为转换字段，名称字段为空，请检查！", objFieldTabENEx.FldName);
                        clsPubVar4WApi.objLog4Error.WriteDebugLog(strMsg);
                    }

                    if (string.IsNullOrEmpty(objFieldTab4CodeConv.CodeTabCodeId) == true)
                    {
                        string strMsg = string.Format("字段：{0}为转换字段，代码字段为空，请检查！", objFieldTabENEx.FldName);
                        clsPubVar4WApi.objLog4Error.WriteDebugLog(strMsg);

                    }
                    if (objFieldTabENEx.FldName == "FeatureTypeId")
                    {
                        //string ss = "";
                    }
                    string strTabName = "";
                    var objPrjTab = clsPrjTabWApi.GetObjByTabId(objFieldTab4CodeConv.CodeTabId);
                    if (objPrjTab != null) strTabName = objPrjTab.TabName;
                    objFieldTabENEx.CodeTabName = strTabName;
                    objFieldTabENEx.CodeTabName = clsFieldTabExWApi.GetObjExByFldIDCache(
                                             objFieldTab4CodeConv.CodeTabNameId, objFieldTabENEx.PrjId).FldName;

                    objFieldTabENEx.CodeTabCode = clsFieldTabExWApi.GetObjExByFldIDCache(
                                             objFieldTab4CodeConv.CodeTabCodeId,
                                             objFieldTabENEx.PrjId).FldName;
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("处理字段：{0}的转换字段属性时出错：{1}。({2})",
                        objFieldTabENEx.FldName, objException.Message, clsStackTrace.GetCurrClassFunction());
                    //clsPubFun4WApi.objLog.WriteDebugLog(strMsg);
                }
            }

            if (objFieldTabENEx == null)
            {
                throw new Exception("objFieldTabENEx为空,请检查!");
            }
            objFieldTabENEx.objDataTypeAbbrEN = clsDataTypeAbbrWApi.GetObjByDataTypeIdCache(objFieldTabENEx.DataTypeId).CopyToEx();
            return objFieldTabENEx;
        }
        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strFldId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsFieldTabENEx GetObjExByFldId(string strFldId)
        {
            clsFieldTabEN objFieldTabEN = clsFieldTabWApi.GetObjByFldId(strFldId);
            clsFieldTabENEx objFieldTabENEx = new clsFieldTabENEx();
            clsFieldTabWApi.CopyTo(objFieldTabEN, objFieldTabENEx);
            return objFieldTabENEx;
        }

        public static List<clsFieldTabENEx> GetFieldTabENExObjList(string strCondition)
        {
            
            List<clsFieldTabEN> arrObjList = clsFieldTabWApi.GetObjLst(strCondition);
            List<clsFieldTabENEx> arrObjExList = new List<clsFieldTabENEx>();
            foreach (clsFieldTabEN objFieldTabEN in arrObjList)
            {
                clsFieldTabENEx objFieldTabENEx = new clsFieldTabENEx();
                clsFieldTabWApi.CopyTo(objFieldTabEN, objFieldTabENEx);

                //clsFieldTabENEx objFieldTabENEx =objFieldTabEN as  clsFieldTabENEx;

                arrObjExList.Add(objFieldTabENEx);
            }
            return arrObjExList;
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strFldName">字段名</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsFieldTabENEx GetObjExByFldName(string strFldName, string strPrjId)
        {
            //if (clsSpecSQLforSql.AppType = "WEBAPP")
            //{
            //  string strCondition = string.Format("PrjId = '{0}' And FldName = '{1}'", strPrjId, strFldName);
            //  clsFieldTabEN objFieldTabEN = clsFieldTabWApi.GetFirstFieldTab_S(strCondition);
            //  if (objFieldTabEN == null) return null;
            //  clsFieldTabENEx objFieldTabENEx = new clsFieldTabENEx();
            //  clsFieldTabWApi. CopyTo(objFieldTabEN, objFieldTabENEx);
            //  return objFieldTabENEx;
            //}
            string strCondition = "";
            if (arrFieldTabENExObjLst4WinApp == null || strPrjId != strPrjId_Cache)
            {
                strCondition = string.Format("PrjId = '{0}'", strPrjId);
                arrFieldTabENExObjLst4WinApp =  clsFieldTabExWApi.GetFieldTabENExObjList(strCondition);
            }
            foreach (clsFieldTabENEx objFieldTabENEx in arrFieldTabENExObjLst4WinApp)
            {
                if (objFieldTabENEx.FldName.Equals(strFldName, StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    return objFieldTabENEx;
                }
            }
            clsFieldTabENEx objFieldTabEN1 = clsFieldTabExWApi.GetObjExByFldName(strFldName, strPrjId);

            strPrjId = objFieldTabEN1.PrjId;
            strCondition = string.Format("PrjId = '{0}'", objFieldTabEN1.PrjId);
            arrFieldTabENExObjLst4WinApp =  clsFieldTabExWApi.GetFieldTabENExObjList(strCondition);

            foreach (clsFieldTabENEx objFieldTabENEx in arrFieldTabENExObjLst4WinApp)
            {
                if (objFieldTabENEx.FldName.Equals(strFldName, StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    return objFieldTabENEx;
                }
            }
            return null;
        }
    }
}