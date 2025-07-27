
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
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AGC4WApi
{
    /// <summary>
    /// 全静态类，包含全静态函数，相当于全局函数
    /// </summary>
    public static class clsPrjTabFldExWApi_Static
    {
     
        /// <summary>
        /// 字段生成的属性名，根据clsSysParaEN.spIsFstLcase的值决定首字母是否小写
        /// </summary>
        /// <param name="objFieldTabEN"></param>
        /// <returns></returns>
        public static string PropertyName(this clsPrjTabFldENEx objPrjTabFldENEx, bool bolIsFstLcase)
        {
            if (bolIsFstLcase == false)
            {
                return objPrjTabFldENEx.ObjFieldTabENEx.FldName;
            }
            else
            {
                return clsString.Fst2LcaseS(objPrjTabFldENEx.ObjFieldTabENEx.FldName);
            }
        }
        /// <summary>
        /// 是否数字类型
        /// </summary>
        /// <param name="objPrjTabFldENEx"></param>
        /// <returns></returns>
        public static bool IsNumberType(this clsPrjTabFldENEx objPrjTabFldENEx)
        {
            switch (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "Int":
                case "int":
                case "long":
                case "float":
                case "short":
                case "double":
                    return true;
                default:
                    return false;
            }
        }
        public static clsFieldTabENEx ObjFieldTabEx(this clsPrjTabFldENEx objPrjTabFldENEx)
        {
            try
            {
                clsFieldTabENEx objFieldTab = clsFieldTabExWApi.GetObjExByFldIDCache(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);
                return objFieldTab;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表字段获取字段对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static clsPrimaryTypeEN ObjPrimaryType(this clsPrjTabFldEN objPrjTabFldEN)
        {
            try
            {
                clsPrimaryTypeEN objPrimaryType = clsPrimaryTypeWApi.GetObjByPrimaryTypeIdCache(objPrjTabFldEN.PrimaryTypeId);
                return objPrimaryType;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表字段获取主键类型对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(), objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static clsFieldTabEN ObjFieldTab(this clsPrjTabFldEN objPrjTabFldENEx)
        {
            try
            {
                clsFieldTabEN objFieldTab = clsFieldTabExWApi.GetObjExByFldIDCache(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);
                return objFieldTab;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表字段获取字段对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static clsFieldTab4CodeConvEN ObjFieldTab4CodeConv(this clsPrjTabFldEN objPrjTabFldENEx)
        {
            try
            {
                var arrFieldTab4CodeConv = clsFieldTab4CodeConvWApi.GetObjLstCache(objPrjTabFldENEx.PrjId);
                clsFieldTab4CodeConvEN objFieldTab = arrFieldTab4CodeConv.Find(x => x.FldId == objPrjTabFldENEx.FldId);
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


    /// <summary>
    /// 工程表字段(PrjTabFld)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsPrjTabFldExWApi
    {
        private static readonly string mstrApiControllerName = "PrjTabFldExApi";
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;


        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsPrjTabFldExWApi()
        {
        }

        public static List<clsPrjTabFldENEx> GetPrjTabFldENExObjListOrderBySequence( string strTabId)
        {
            //try
            //{
            //    clsCommonRegular.CheckStrSQL_Weak(strCondition);
            //}
            //catch (Exception objException)
            //{
            //    throw new Exception(string.Format("在输入条件中含有{0}，请检查！", objException.Message));
            //}
            List<clsPrjTabFldEN> arrObjList = clsPrjTabFldWApi.GetObjLstCache(strTabId);
            List<clsPrjTabFldENEx> arrObjExList = new List<clsPrjTabFldENEx>();
            foreach (clsPrjTabFldEN objPrjTabFldEN in arrObjList)
            {
                clsPrjTabFldENEx objPrjTabFldENEx = new clsPrjTabFldENEx();
                clsPrjTabFldWApi.CopyTo(objPrjTabFldEN, objPrjTabFldENEx);

                arrObjExList.Add(objPrjTabFldENEx);
            }
            return arrObjExList;
        }
        /// <summary>
        /// 根据[表Id(TabId)]获取相关对象子表, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strPrjId">项目Id</param>
        /// <param name = "strTabId">表Id</param>
        /// <returns>根据[表Id(TabId)]获取的相关对象子表</returns>
        //public static List<clsPrjTabFldEN> GetObjLstByTabIdLst(List<string> arrTabId)
        //{            
        //    string strTabIdLst = clsArray.GetSqlInStrByArray(arrTabId, true);
        //    string strWhere = string.Format("TabId in ({0})", strTabIdLst);
        //    List<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel = clsPrjTabFldWApi.GetObjLst(strWhere);// new List<clsPrjTabFldEN>();            
        //    return arrPrjTabFldObjLst_Sel.OrderBy(x=>x.SequenceNumber).ToList();
        //}

        /// <summary>
        /// 根据关键字列表获取对象列表
        /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
        /// </summary>
        /// <param name = "arrMId">关键字列表</param>
        /// <returns>返回对象列表</returns>
        public static List<clsPrjTabFldEN> GetObjLstByTabIdLst(List<string> arrTabId)
        {
            List<clsPrjTabFldEN> arrObjLst;
            string strAction = "GetObjLstByTabIdLst";
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            try
            {
                string strJSON = clsJSON.GetJsonFromObjLst(arrTabId);
                if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
                {
                    JObject jobjReturn0 = JObject.Parse(strResult);
                    if ((int)jobjReturn0["errorId"] == 0)
                    {
                        string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
                        arrObjLst = JsonConvert.DeserializeObject<List<clsPrjTabFldEN>>(strJson);
                        return arrObjLst;
                    }
                    else
                    {
                        string strMsg = string.Format("{0}", jobjReturn0["errorMsg"]);
                        throw new Exception(strMsg);
                    }
                }
                else return null;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }


        /// <summary>
        /// 根据[表Id(TabId)]获取相关对象子表, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strPrjId">项目Id</param>
        /// <param name = "strTabId">表Id</param>
        /// <returns>根据[表Id(TabId)]获取的相关对象子表</returns>
        public static List<clsPrjTabFldEN> GetObjLstByTabId_CacheExBak(string strTabId, string strPrjId)
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
            List<clsPrjTabFldEN> arrPrjTabFldObjLst_Cache = clsPrjTabFldWApi.GetObjLstCache(strPrjId);


            IEnumerable<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel1 =
                from objPrjTabFldEN in arrPrjTabFldObjLst_Cache
                where objPrjTabFldEN.TabId == strTabId
                select objPrjTabFldEN;


            List<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel = new List<clsPrjTabFldEN>();
            foreach (clsPrjTabFldEN obj in arrPrjTabFldObjLst_Sel1)
            {
                arrPrjTabFldObjLst_Sel.Add(obj);
            }

            return arrPrjTabFldObjLst_Sel.OrderBy(x => x.SequenceNumber).ToList();

        }


        /// <summary>
        /// 从表字段列表中查找某字段名的表字段对象
        /// </summary>
        /// <param name = "arrPrjTabFldObjList">表字段列表</param>
        /// <param name = "strFldName">字段名</param>
        /// <returns>表字段(clsvPrjTabFldEN)对象</returns>
        public static clsvPrjTabFldEN GetvPrjTabFldENByFieldName(List<clsvPrjTabFldEN> arrPrjTabFldObjList, string strFldName)
        {
            foreach (clsvPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjList)
            {
                if (objPrjTabFldEN.FldName.Equals(strFldName, StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    return objPrjTabFldEN;
                }
            }
            return null;
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKey_Cache)
        /// </summary>
        /// <param name = "lngmId">所给的关键字</param>
        /// <param name = "strPrjId">strPrjId</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsPrjTabFldEN GetObjBymId_CacheEx(long lngmId, string strPrjId)
        {
            string strMsg = "";
            if (lngmId == 0)
            {
                strMsg = string.Format("mId不能为空！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            //初始化列表缓存
            //List<clsPrjTabFldEN> arrPrjTabFldObjLst_Cache = clsPrjTabFldWApi.GetObjLstCache(strPrjId);
            //IEnumerable<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel1 =
            //from objPrjTabFldEN in arrPrjTabFldObjLst_Cache
            //where objPrjTabFldEN.mId == lngmId
            //select objPrjTabFldEN;
            //List<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel = new List<clsPrjTabFldEN>();
            //foreach (clsPrjTabFldEN obj in arrPrjTabFldObjLst_Sel1)
            //{
            //    arrPrjTabFldObjLst_Sel.Add(obj);
            //}

            //string strWhere = string.Format("TabId='{0}'", strTabId);
            //List<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel = clsPrjTabFldBL.GetObjLst(strWhere);// new List<clsPrjTabFldEN>();
            var obj = clsPrjTabFldWApi.GetObjBymId(lngmId);
            //if (arrPrjTabFldObjLst_Sel.Count == 0)
            //{
            //    return null;
            //}
            return obj;// arrPrjTabFldObjLst_Sel[0];
        }


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "lngmId">所给的关键字</param>
        /// <param name = "strPrjId">strPrjId</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsPrjTabFldENEx GetObjExObjBymId(long lngmId, string strCmPrjId)
        {
            string strPrjId = clsCMProjectExWApi.GetPrjIdByCmPrjIdCache(strCmPrjId);
            clsPrjTabFldEN objPrjTabFldEN = GetObjBymId_CacheEx(lngmId, strPrjId);
            if (objPrjTabFldEN != null)
            {
                clsPrjTabFldENEx objPrjTabFldENEx = new clsPrjTabFldENEx();
                clsPrjTabFldWApi.CopyTo(objPrjTabFldEN, objPrjTabFldENEx);
                clsPrjTabEN objPrjTab = clsPrjTabWApi.GetObjByTabId(objPrjTabFldEN.TabId);
                if (objPrjTab != null)
                {
                    objPrjTabFldENEx.TabName = objPrjTab.TabName;
                }
                return objPrjTabFldENEx;
            }
            clsPrjTabFldWApi.ReFreshCache(strPrjId);
            objPrjTabFldEN = GetObjBymId_CacheEx(lngmId, strPrjId);
            if (objPrjTabFldEN != null)
            {
                clsPrjTabFldENEx objPrjTabFldENEx = new clsPrjTabFldENEx();
                clsPrjTabFldWApi. CopyTo(objPrjTabFldEN, objPrjTabFldENEx);
                clsPrjTabEN objPrjTab = clsPrjTabWApi.GetObjByTabId(objPrjTabFldEN.TabId);
                if (objPrjTab != null)
                {
                    objPrjTabFldENEx.TabName = objPrjTab.TabName;
                }
                return objPrjTabFldENEx;
            }

            return null;
        }
    }
}