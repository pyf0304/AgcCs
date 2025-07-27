using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.commdb;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.sql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_PrjTabFldEx : RelatedActions_PrjTabFld
    {
        public override bool UpdRelaTabDate(long lngmId, string strOpUser)
        {
            var objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngmId);
            if (objPrjTabFld == null) return false;
            var objPrjTab = clsPrjTabBL.GetObjByTabId(objPrjTabFld.TabId);
            if (objPrjTab == null) return false;
            clsPrjTabBL.SetUpdDate(objPrjTabFld.TabId, strOpUser);
            return true;
        }
    }
    /// <summary>
    /// 全静态类，包含全静态函数，相当于全局函数
    /// </summary>
    public static class clsPrjTabFldBLEx_Static
    {

        /// <summary>
        /// 字段生成的属性名，根据bolIsFstLcase的值决定首字母是否小写
        /// </summary>
        /// <param name="objDGRegionFldsEN"></param>
        /// <returns></returns>
        public static string DataPropertyName_FstLcase(this clsPrjTabFldEN objPrjTabFldEN, bool bolIsFstLcase)
        {
            var objFieldTab = objPrjTabFldEN.ObjFieldTab();
            if (objFieldTab == null) return "";
            if (bolIsFstLcase == false)
            {
                return objFieldTab.FldName;
            }
            else
            {
                return clsString.FstLcaseS(objFieldTab.FldName);
            }
        }

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_AddRecordEx)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        public static bool AddRecordEx2(this clsPrjTabFldEN objPrjTabFldEN)
        {
            //操作步骤:
            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //2、检查唯一性
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
                            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            try
            {
                //2、检查传进去的对象属性是否合法
                objPrjTabFldEN.CheckPropertyNew();
                //5.2、检查唯一性
                if (objPrjTabFldEN.CheckUniqueness() == false)
                {
                    strMsg = string.Format("(表ID(TabId)=[{0}],字段Id(FldId)=[{1}])已经存在，不能重复!", objPrjTabFldEN.TabId, objPrjTabFldEN.FldId);
                    throw new Exception(strMsg);
                }
                //6、把数据实体层的数据存贮到数据库中
                objPrjTabFldEN.AddNewRecord();
            }
            catch (Exception objException)
            {
                strMsg = "(errid:BlEx000003)添加记录不成功!" + objException.Message;
                throw new Exception(strMsg);
            }
            return true;
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_UpdateRecordEx)
        /// </summary>
        /// <param name = "objPrjTabFldEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool UpdateRecordEx2(this clsPrjTabFldEN objPrjTabFldEN)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
            try
            {
                //1、检查传进去的对象属性是否合法
                objPrjTabFldEN.CheckPropertyNew();
                //2、检查唯一性
                if (objPrjTabFldEN.CheckUniqueness() == false)
                {
                    strMsg = "(表ID(TabId),字段Id(FldId))不能重复!";
                    throw new Exception(strMsg);
                }
                //4、把数据实体层的数据存贮到数据库中
                objPrjTabFldEN.Update();
            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                throw new Exception(strMsg);
            }
            return true;
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_EditRecordEx)
        /// </summary>
        /// <param name = "objPrjTabFld">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx2(this clsPrjTabFldEN objPrjTabFld)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsPrjTabFldEN objPrjTabFld_Cond = new clsPrjTabFldEN();
            string strCondition = objPrjTabFld_Cond
            .SetTabId(objPrjTabFld.TabId, "=")
            .SetFldId(objPrjTabFld.FldId, "=")
            .GetCombineCondition();
            objPrjTabFld._IsCheckProperty = true;
            bool bolIsExist = clsPrjTabFldBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objPrjTabFld.mId = clsPrjTabFldBL.GetFirstID_S(strCondition);
                objPrjTabFld.UpdateWithCondition(strCondition);
            }
            else
            {
                objPrjTabFld.AddNewRecord();
            }
            return true;
        }
        /// <summary>
        /// 字段生成的属性名，根据bolIsFstLcase的值决定首字母是否小写
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
                return clsString.FstLcaseS(objPrjTabFldENEx.ObjFieldTabENEx.FldName);
            }
        }
        public static string PropertyNameEx(this clsPrjTabFldENEx objPrjTabFldENEx, bool bolIsFstLcase)
        {
            if (bolIsFstLcase == false)
            {
                return objPrjTabFldENEx.ObjFieldTabENEx.FldName.Replace("_", "");
            }
            else
            {
                return clsString.FstLcaseS(objPrjTabFldENEx.ObjFieldTabENEx.FldName.Replace("_", ""));
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
        public static bool IsForExtendClass(this clsPrjTabFldENEx objPrjTabFldENEx)
        {
            return objPrjTabFldENEx.IsForExtendClass;
        }
        public static clsFieldTabENEx ObjFieldTabEx(this clsPrjTabFldENEx objPrjTabFldENEx)
        {
            try
            {
                clsFieldTabENEx objFieldTab = clsFieldTabBLEx.GetObjExByFldIDCache(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);
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
                clsPrimaryTypeEN objPrimaryType = clsPrimaryTypeBL.GetObjByPrimaryTypeIdCache(objPrjTabFldEN.PrimaryTypeId);
                return objPrimaryType;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表字段获取主键类型对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(), objException.Message);
                throw new Exception(strMsg);
            }
        }


        public static string DataTypeName(this clsPrjTabFldEN objPrjTabFldENEx)
        {
            try
            {
                clsFieldTabEN objFieldTab = clsFieldTabBLEx.GetObjExByFldIDCache(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);
                if (objFieldTab == null) return "";
                var objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTab.DataTypeId);
                if (objDataTypeAbbr == null) return "";
                return objDataTypeAbbr.DataTypeName;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表字段获取字段对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }


        public static string FldName(this clsPrjTabFldEN objPrjTabFldENEx)
        {
            try
            {
                clsFieldTabEN objFieldTab = clsFieldTabBLEx.GetObjExByFldIDCache(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);
                if (objFieldTab == null) return "";
                return objFieldTab.FldName;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表字段获取字段对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static clsFieldTabEN ObjFieldTab(this clsPrjTabFldEN objPrjTabFldENEx)
        {
            if (objPrjTabFldENEx == null) return null;
            try
            {
                clsFieldTabEN objFieldTab = clsFieldTabBLEx.GetObjExByFldIDCache(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);
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
        public static clsFieldTabEN ObjFieldTab0(this clsPrjTabFldEN objPrjTabFldENEx)
        {
            try
            {
                clsFieldTabEN objFieldTab = clsFieldTabBLEx.GetObjExByFldIDCache(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);
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
                var arrFieldTab4CodeConv = clsFieldTab4CodeConvBL.GetObjLstCache(objPrjTabFldENEx.PrjId);
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
    /// 表字段(clsPrjTabFldBL)的扩展类
    /// </summary>
    public partial class clsPrjTabFldBLEx : clsPrjTabFldBL
    {
        public static string strPrjIdCache = "";
        public static string strPrjIdCache_Init = "";

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strTabId">所给的关键字</param>        
        /// <param name = "strPrjId">strPrjId</param>        
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsPrjTabFldEN> GetObjLstByTabIdCache(string strTabId, string strPrjId)
        {
            //初始化列表缓存
            List<clsPrjTabFldEN> arrObjLstCache = clsPrjTabFldBL.GetObjLstCache(strPrjId);
            List<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel =
            arrObjLstCache.Where(x => x.TabId == strTabId).ToList();

            return arrPrjTabFldObjLst_Sel;
        }

        public static List<string> GetFldIdLstByTabIdCache(string strTabId, string strPrjId)
        {
            //初始化列表缓存
            List<clsPrjTabFldEN> arrObjLstCache = clsPrjTabFldBL.GetObjLstCache(strPrjId);

            IEnumerable<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel1 =
            from objPrjTabFldEN in arrObjLstCache
            where objPrjTabFldEN.TabId == strTabId
            select objPrjTabFldEN;

            //if (arrPrjTabFldObjLst_Sel.Count == 0)
            //{
            //    return null;
            //}
            return arrPrjTabFldObjLst_Sel1.Select(x => x.FldId).ToList();
        }


        public static List<clsPrjTabFldEN> GetObjLstByPrjIdCache1(string strPrjId)
        {
            //初始化列表缓存
            List<clsPrjTabFldEN> arrObjLstCache = clsPrjTabFldBL.GetObjLstCache(strPrjId);

            return arrObjLstCache;
        }


        public static List<clsPrjTabFldEN> GetObjLstByFldIdCacheB(string strFldId, string strTabId, string strPrjId)
        {
            //初始化列表缓存
            List<clsPrjTabFldEN> arrObjLstCache = clsPrjTabFldBL.GetObjLstCache(strPrjId);

            IEnumerable<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel1 = arrObjLstCache.
                Where(x => x.FldId == strFldId && x.TabId == strTabId);

            return arrPrjTabFldObjLst_Sel1.ToList(); ;
        }



        public static List<clsPrjTabFldENEx> GetObjExLst(string strTabId, string strPrjId)
        {
            List<clsPrjTabFldENEx> arrObjExList = new List<clsPrjTabFldENEx>();
            List<clsPrjTabFldEN> arrObjList = GetObjLstByTabIdCache(strTabId, strPrjId);
            foreach (clsPrjTabFldEN objPrjTabFldEN in arrObjList)
            {
                clsPrjTabFldENEx objPrjTabFldENEx = new clsPrjTabFldENEx();
                CopyTo(objPrjTabFldEN, objPrjTabFldENEx);
                arrObjExList.Add(objPrjTabFldENEx);
            }
            return arrObjExList;
        }

        /// <summary>
        /// 从表字段列表中查找某字段名的表字段对象
        /// </summary>
        /// <param name = "arrPrjTabFldObjList">表字段列表</param>
        /// <param name = "strFldName">字段名</param>
        /// <returns>表字段(clsvPrjTabFldEN)对象</returns>
        public static clsPrjTabFldEN GetvPrjTabFldENByFieldName(List<clsPrjTabFldEN> arrPrjTabFldObjList, string strFldName)
        {
            foreach (clsPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjList)
            {
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFldEN.FldId, objPrjTabFldEN.PrjId);
                if (objFieldTab.FldName.Equals(strFldName, StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    return objPrjTabFldEN;
                }
            }
            return null;
        }

        /// <summary>
        /// 从表字段列表中查找某字段Id的表字段对象
        /// </summary>
        /// <param name = "arrPrjTabFldObjList">表字段列表</param>
        /// <param name = "strFldId">字段Id</param>
        /// <returns>表字段(clsvPrjTabFldEN)对象</returns>
        public static clsvPrjTabFldEN GetvPrjTabFldENByFldId(List<clsvPrjTabFldEN> arrPrjTabFldObjList, string strFldId)
        {
            foreach (clsvPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjList)
            {
                if (objPrjTabFldEN.FldId == strFldId)
                {
                    return objPrjTabFldEN;
                }
            }
            return null;
        }

        /// <summary>
        /// 从表字段列表中查找某字段Id的表字段对象
        /// </summary>
        /// <param name = "arrPrjTabFldObjList">表字段列表</param>
        /// <param name = "strFldId">字段Id</param>
        /// <returns>表字段(clsvPrjTabFldEN)对象</returns>
        public static clsPrjTabFldEN GetObjByFldId(List<clsPrjTabFldEN> arrPrjTabFldObjList, string strFldId)
        {
            foreach (clsPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjList)
            {
                if (objPrjTabFldEN.FldId == strFldId)
                {
                    return objPrjTabFldEN;
                }
            }
            return null;
        }
        /// <summary>
        /// 从表字段列表中查找某字段名的相似的表字段对象
        /// </summary>
        /// <param name = "arrPrjTabFldObjList">表字段列表</param>
        /// <param name = "strFldName">字段名</param>
        /// <returns>表字段(clsvPrjTabFldEN)对象</returns>
        public static clsPrjTabFldEN GetLikevPrjTabFldENByFieldName(List<clsPrjTabFldEN> arrPrjTabFldObjList, string strFldName)
        {
            foreach (clsPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjList)
            {
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFldEN.FldId, objPrjTabFldEN.PrjId);
                if (objFieldTab.FldName.IndexOf(strFldName, 0, StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    return objPrjTabFldEN;
                }
            }
            return null;
        }

        /// <summary>
        /// 从表字段列表中查找某关键表字段对象
        /// </summary>
        /// <param name = "arrPrjTabFldObjList">表字段列表</param>
        /// <returns>表字段(clsvPrjTabFldEN)对象</returns>
        public static clsPrjTabFldEN GetKeyvPrjTabFldEN(List<clsPrjTabFldEN> arrPrjTabFldObjList)
        {
            foreach (clsPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjList)
            {
                if (objPrjTabFldEN.FieldTypeId == enumFieldType.KeyField_02) return objPrjTabFldEN;

                string strPrimaryTypeId2 = objPrjTabFldEN.PrimaryTypeId;
                if (strPrimaryTypeId2 == "01" || strPrimaryTypeId2 == "02")
                {
                    return objPrjTabFldEN;
                }
            }
            return null;
        }

        /// <summary>
        /// 从表字段列表中查找序号字段
        /// </summary>
        /// <param name = "strTabId">表字段列表</param>
        /// <param name = "strPrjId">表字段列表</param>
        /// <returns>序号字段</returns>
        public static clsPrjTabFldEN GetOrderNumObjCache(string strTabId, string strPrjId)
        {
            List<clsPrjTabFldEN> arrPrjTabFldObjList = GetObjLstByTabIdCache(strTabId, strPrjId);

            clsPrjTabFldEN objPrjTabFldEN = arrPrjTabFldObjList.Find(x => x.FieldTypeId == enumFieldType.OrderNumField_09);
            return objPrjTabFldEN;

        }

        /// <summary>
        /// 从表字段列表中查找分类字段
        /// </summary>
        /// <param name = "strPrjId">表字段列表</param>        
        /// <returns>分类字段</returns>
        public static clsPrjTabFldEN GetClassificationFieldObjCache(string strPrjId)
        {
            List<clsPrjTabFldEN> arrPrjTabFldObjList = GetObjLstByPrjIdCache1(strPrjId);

            clsPrjTabFldEN objPrjTabFldEN = arrPrjTabFldObjList.Find(x => x.FieldTypeId == enumFieldType.ClassificationField_10);
            return objPrjTabFldEN;

        }

        /// <summary>
        /// 从表字段列表中查找FldId的对象
        /// </summary>
        /// <param name = "strTabId">表Id</param>       
        /// <param name = "strFldId">字段Id</param>
        /// <returns>表字段</returns>
        //public static clsPrjTabFldEN GetObjByFldIdCache(string strPrjId, string strFldId)
        //{
        //    List<clsPrjTabFldEN> arrPrjTabFldObjList = GetObjLstByPrjIdCache1(strPrjId);

        //    clsPrjTabFldEN objPrjTabFldEN = arrPrjTabFldObjList.Find(x => x.FldId == strFldId);
        //    return objPrjTabFldEN;

        //}

        /// <summary>
        /// 从表Id获取关键表字段对象
        /// </summary>
        /// <param name = "strTabId">表字段列表</param>
        /// <returns>表字段(clsvPrjTabFldEN)对象</returns>
        public static clsvPrjTabFldEN GetKeyvPrjTabFldENByTabId(string strTabId)
        {
            string strCondition = string.Format("TabId = '{0}' And {1} = '{2}'", strTabId, convPrjTabFld.FieldTypeId, enumFieldType.KeyField_02);
            clsvPrjTabFldEN objvPrjTabFldEN = clsvPrjTabFldBL.GetFirstObj_S(strCondition);
            return objvPrjTabFldEN;
        }

        /// <summary>
        /// 根据表Id和字段Id获取的关键字Id
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strFldId">字段Id</param>
        /// <returns>表Id和字段Id所对应的关键字Id</returns>
        public static long GetPrimaryKeyByTabIdAndFldId(string strTabId, string strFldId)
        {
            string strCondition = string.Format("TabId = '{0}' And {1} = '{2}'", strTabId, convPrjTabFld.FldId, strFldId);
            List<string> arrKeyId = clsPrjTabFldBL.GetPrimaryKeyID_S(strCondition);
            if (arrKeyId.Count == 0) return 0;
            return long.Parse(arrKeyId[0]);
        }

        /// <summary>
        /// 从表Id获取关键表字段对象
        /// </summary>
        /// <param name = "strTabId">表字段列表</param>
        /// <returns>表字段(clsvPrjTabFldEN)对象</returns>
        public static List<clsPrjTabFldEN> GetPrimaryKeyObjLstByTabId(string strTabId)
        {
            string strCondition = string.Format("TabId = '{0}' And {1} = '{2}'", strTabId, convPrjTabFld.FieldTypeId, enumFieldType.KeyField_02);
            List<clsPrjTabFldEN> arrPrjTabFldENObjLst = clsPrjTabFldBL.GetObjLst(strCondition);
            return arrPrjTabFldENObjLst;
        }

        /// <summary>
        /// 从表Id获取关键表字段对象,从缓存中获取
        /// </summary>
        /// <param name = "strTabId">表字段列表</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>关键字表字段对象列表</returns>
        public static List<clsPrjTabFldEN> GetPrimaryKeyObjLstByTabIdCache(string strTabId, string strPrjId)
        {
            List<clsPrjTabFldEN> arrObjLstCache = clsPrjTabFldBL.GetObjLstCache(strPrjId);
            List<clsPrjTabFldEN> arrObjLst_Sel = arrObjLstCache.Where(x => x.TabId == strTabId && x.FieldTypeId == enumFieldType.KeyField_02).ToList();
            return arrObjLst_Sel;
        }
        /// <summary>
        /// 从表Id获取关键表字段对象
        /// </summary>
        /// <param name = "strTabId">表字段列表</param>
        /// <returns>表字段(clsvPrjTabFldEN)对象</returns>
        public static string GetPrimaryTypeIdByTabId(string strTabId)
        {
            string strCondition = string.Format("TabId = '{0}' And {1} = '{2}'", strTabId, convPrjTabFld.FieldTypeId, enumFieldType.KeyField_02);
            clsvPrjTabFldEN objvPrjTabFldEN = clsvPrjTabFldBL.GetFirstObj_S(strCondition);
            return objvPrjTabFldEN.PrimaryTypeId;
        }


        /// <summary>
        /// 添加一组字段到表中。
        /// </summary>
        /// <param name="strTabId">表Id</param>
        /// <param name="arrFldIdLst">字段列表 </param>
        /// <param name="strUserId">用户Id</param>
        /// <param name="strPrjId">工程Id</param>
        public static void Add_ObjectFldtoPrjTabFld(string strTabId, List<string> arrFldIdLst, string strUserId, string strPrjId)
        {
            bool bolIsnullable;
            int intTabFldCount;
            if (arrFldIdLst.Count == 0)
            {
                return;
            }
            else
            {
                clsPrjTabFldEN objPrjTabFldEN;
                intTabFldCount = clsGeneralTab2.funGetRecCountByCond("PrjTabFld", "TabId = '" + strTabId + "'");
                bool bolIsUpdTab = false;
                foreach (string strFldId in arrFldIdLst)
                {
                    clsFieldTabENEx objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(strFldId, strPrjId);
                    bolIsnullable = objFieldTabEN.IsNull;
                    objPrjTabFldEN = new clsPrjTabFldEN();
                    objPrjTabFldEN.TabId = strTabId;
                    objPrjTabFldEN.PrjId = strPrjId;
                    objPrjTabFldEN.FldId = strFldId;

                    objPrjTabFldEN.IsTabNullable = bolIsnullable;
                    objPrjTabFldEN.PrimaryTypeId = "00";
                    objPrjTabFldEN.FldOpTypeId = "0001";

                    objPrjTabFldEN.FieldTypeId = "01";	//默认字段类型为<一般字段>
                    //3.1、判断是否有相同的字段存在。					
                    if (clsPrjTabFldBLEx.IsExistSameFldId(strTabId, strFldId))	//判断是否有相同的关键字
                    {
                    }
                    else
                    {
                        objPrjTabFldEN.SequenceNumber = intTabFldCount + 1;
                        intTabFldCount++;
                        clsPrjTabFldBL.AddNewRecordBySql2(objPrjTabFldEN);

                        //clsvPrjTabFldBLEx.arrvPrjTabFldObjLstCache = null;

                        bolIsUpdTab = true;
                    }
                }
                if (bolIsUpdTab == true)
                {
                    clsPrjTabBLEx.SetUpdDate(strTabId, strUserId);
                }
            }
        }

        public static bool IsExistSameFldId(string strTabId, string strFldId)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("TabId = '{0}' and FldId = '{1}'", strTabId, strFldId);
            return IsExistRecord(strCondition.ToString());
        }
        public static bool IsForExtendClass(string strTabId, string strFldId, string strPrjId)
        {
            var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(strTabId, strFldId, strPrjId);
            if (objPrjTabFld == null) return false;
            return objPrjTabFld.IsForExtendClass;
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "lngmId">所给的关键字</param>
        /// <param name = "strPrjId">strPrjId</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsPrjTabFldEN GetObjBymIdCacheEx(long lngmId, string strPrjId)
        {
            string strMsg = "";
            if (lngmId == 0)
            {
                strMsg = string.Format("mId不能为空！({0})", clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            //初始化列表缓存
            List<clsPrjTabFldEN> arrObjLstCache = clsPrjTabFldBL.GetObjLstCache(strPrjId);

            IEnumerable<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel1 =
            from objPrjTabFldEN in arrObjLstCache
            where objPrjTabFldEN.mId == lngmId
            select objPrjTabFldEN;
            List<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel = new List<clsPrjTabFldEN>();
            foreach (clsPrjTabFldEN obj in arrPrjTabFldObjLst_Sel1)
            {
                arrPrjTabFldObjLst_Sel.Add(obj);
            }
            if (arrPrjTabFldObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrPrjTabFldObjLst_Sel[0];
        }


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "lngmId">所给的关键字</param>
        /// <param name = "strPrjId">strPrjId</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsPrjTabFldENEx GetObjExObjBymIdB(long lngmId, string strPrjId)
        {

            clsPrjTabFldEN objPrjTabFldEN = GetObjBymIdCacheEx(lngmId, strPrjId);
            if (objPrjTabFldEN != null)
            {
                clsPrjTabFldENEx objPrjTabFldENEx = new clsPrjTabFldENEx();
                CopyTo(objPrjTabFldEN, objPrjTabFldENEx);
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objPrjTabFldEN.TabId, objPrjTabFldEN.PrjId);
                if (objPrjTab != null)
                {
                    objPrjTabFldENEx.TabName = objPrjTab.TabName;
                }
                return objPrjTabFldENEx;
            }
            clsPrjTabFldBL.ReFreshCache(strPrjId);
            objPrjTabFldEN = GetObjBymIdCacheEx(lngmId, strPrjId);
            if (objPrjTabFldEN != null)
            {
                clsPrjTabFldENEx objPrjTabFldENEx = new clsPrjTabFldENEx();
                CopyTo(objPrjTabFldEN, objPrjTabFldENEx);
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objPrjTabFldEN.TabId, objPrjTabFldEN.PrjId);
                if (objPrjTab != null)
                {
                    objPrjTabFldENEx.TabName = objPrjTab.TabName;
                }
                return objPrjTabFldENEx;
            }

            return null;
        }

        public static clsPrjTabFldENEx GetObjExObjBymIdEx(long lngmId, string strPrjId)
        {

            clsPrjTabFldEN objPrjTabFldEN = GetObjBymIdCacheEx(lngmId, strPrjId);
            if (objPrjTabFldEN != null)
            {
                clsPrjTabFldENEx objPrjTabFldENEx = new clsPrjTabFldENEx();
                CopyTo(objPrjTabFldEN, objPrjTabFldENEx);
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objPrjTabFldEN.TabId, objPrjTabFldEN.PrjId);
                if (objPrjTab != null)
                {
                    objPrjTabFldENEx.TabName = objPrjTab.TabName;
                }
                objPrjTabFldENEx.ObjFieldTabENEx = clsFieldTabBLEx.GetObjExByFldIDCache(objPrjTabFldENEx.FldId, objPrjTabFldEN.PrjId);
                return objPrjTabFldENEx;
            }
            clsPrjTabFldBL.ReFreshCache(strPrjId);
            objPrjTabFldEN = GetObjBymIdCacheEx(lngmId, strPrjId);
            if (objPrjTabFldEN != null)
            {
                clsPrjTabFldENEx objPrjTabFldENEx = new clsPrjTabFldENEx();
                CopyTo(objPrjTabFldEN, objPrjTabFldENEx);
                clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objPrjTabFldEN.TabId, objPrjTabFldEN.PrjId);
                if (objPrjTab != null)
                {
                    objPrjTabFldENEx.TabName = objPrjTab.TabName;
                }
                objPrjTabFldENEx.ObjFieldTabENEx = clsFieldTabBLEx.GetObjExByFldIDCache(objPrjTabFldENEx.FldId, objPrjTabFldEN.PrjId);
                return objPrjTabFldENEx;
            }

            return null;
        }


        //public static void InitFieldTab(clsPrjTabFldENEx objPrjTabFldENEx)
        //{
        //    if (objPrjTabFldENEx.FldId == null || objPrjTabFldENEx.FldId == "")
        //        throw new clsDbObjException("字段ID为空,请检查!当前表为PrjTabFld,关键字为:" + objPrjTabFldENEx.mId.ToString());

        //    objPrjTabFldENEx.ObjFieldTabENEx = clsFieldTabBLEx.GetObjExByFldIDCache(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);

        //    if (objPrjTabFldENEx.ObjFieldTabENEx.IsNeedTransCode == true)
        //    {
        //        try
        //        {
        //            if (string.IsNullOrEmpty(objPrjTabFldENEx.ObjFieldTabENEx.CodeTabId) == true)
        //            {
        //                string strMsg = string.Format("字段：{0}为转换字段，转换表为空，请检查！", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
        //                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
        //            }
        //            if (string.IsNullOrEmpty(objPrjTabFldENEx.ObjFieldTabENEx.CodeTabNameId) == true)
        //            {
        //                string strMsg = string.Format("字段：{0}为转换字段，名称字段为空，请检查！", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
        //                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
        //            }

        //            if (string.IsNullOrEmpty(objPrjTabFldENEx.ObjFieldTabENEx.CodeTabCodeId) == true)
        //            {
        //                string strMsg = string.Format("字段：{0}为转换字段，代码字段为空，请检查！", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
        //                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);

        //            }
        //            if (objPrjTabFldENEx.ObjFieldTabENEx.FldName == "FeatureTypeId")
        //            {
        //                string ss = "";
        //            }
        //            objPrjTabFldENEx.ObjFieldTabENEx.CodeTabName = clsPrjTabBL.GetObjByTabIdCache(
        //                objPrjTabFldENEx.ObjFieldTabENEx.CodeTabId, objPrjTabFldENEx.ObjFieldTabENEx.PrjId).TabName;
        //            objPrjTabFldENEx.ObjFieldTabENEx.CodeTabName = clsFieldTabBLEx.GetObjExByFldIDCache(
        //                                     objPrjTabFldENEx.ObjFieldTabENEx.CodeTabNameId, objPrjTabFldENEx.ObjFieldTabENEx.PrjId).FldName;

        //            objPrjTabFldENEx.ObjFieldTabENEx.CodeTabCode = clsFieldTabBLEx.GetObjExByFldIDCache(
        //                                     objPrjTabFldENEx.ObjFieldTabENEx.CodeTabCodeId,
        //                                     objPrjTabFldENEx.ObjFieldTabENEx.PrjId).FldName;
        //        }
        //        catch (Exception objException)
        //        {
        //            string strMsg = string.Format("处理字段：{0}的转换字段属性时出错：{1}。({2})",
        //                objPrjTabFldENEx.ObjFieldTabENEx.FldName, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
        //        }
        //    }

        //    if (objPrjTabFldENEx.ObjFieldTabENEx == null)
        //    {
        //        throw new clsDbObjException("objFieldTabENEx为空,请检查!");
        //    }
        //    objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objPrjTabFldENEx.ObjFieldTabENEx.DataTypeId).CopyToEx();
        //}
        public static bool DelRecordEx(string strTabId)
        {
            List<string> arrLst = null;
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("TabId = '{0}'", strTabId);
            arrLst = clsPrjTabFldBL.GetPrimaryKeyID_S(sbCondition.ToString());
            if (arrLst == null) return true;
            foreach (string strMid in arrLst)
            {
                long lngMid = long.Parse(strMid);
                DelRecordEx(lngMid);
            }
            clsPrjTabBLEx.SetUpdDate(strTabId);
            return true;
        }
        /// <summary>
        /// 强化删除工程表字段,
        /// </summary>
        /// <param name = "lngMId">工程表字段的关键字</param>
        /// <returns></returns>
        public static bool DelRecordEx(long lngMId)
        {
            //操作步骤:
            //1、获取当前序号的步骤序号；
            //2、删除当前记录
            //3、把后面的记录的步骤序号都减1；
            //4、返回TRUE；
            long intCurrSeqNum;
            string strCurrTabId;
            var objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngMId);
            var strCondition = string.Format("{0}='{1}'", conViewRegion.TabId, objPrjTabFld);
            var arrRegionId = clsViewRegionBL.GetFldValueNoDistinct(conViewRegion.RegionId, strCondition);
            var strCondition_RegionFlds = string.Format("{0} in ({1}) and {2}='{3}'", conViewRegion.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true),
                conEditRegionFlds.FldId, objPrjTabFld.FldId);
            List<string> arrLst = null;
            //1、获取当前序号的步骤序号；
            arrLst = clsGeneralTab2.funGetFldValue("PrjTabFld", "SequenceNumber", "mId = " + lngMId.ToString());
            intCurrSeqNum = long.Parse(arrLst[0].ToString());
            //2、获取当前记录的表ID
            arrLst = clsGeneralTab2.funGetFldValue("PrjTabFld", "TabId", "mId = " + lngMId.ToString());
            strCurrTabId = arrLst[0].ToString();
            //2、删除当前记录
            if (arrRegionId.Count > 0)
            {
                clsEditRegionFldsBL.DelEditRegionFldssByCond(strCondition_RegionFlds);
                clsDetailRegionFldsBL.DelDetailRegionFldssByCond(strCondition_RegionFlds);
                clsDGRegionFldsBL.DelDGRegionFldssByCond(strCondition_RegionFlds);
                clsQryRegionFldsBL.DelQryRegionFldssByCond(strCondition_RegionFlds);
                //clsListViewRegionFldsBL.DelListViewRegionFldssByCond("TabFldId = " + lngMId);
                clsExcelExportRegionFldsBL.DelExcelExportRegionFldssByCond(strCondition_RegionFlds);
            }
            DelRecord(lngMId);
            //3、把后面的记录的步骤序号都减1；
            string strSQL;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            //删除PrjTabFld本表中与当前对象有关的记录
            strSQL = "Update PrjTabFld set SequenceNumber = SequenceNumber - 1 where TabId = '" + strCurrTabId + "' and SequenceNumber > " + intCurrSeqNum;
            objSQL.ExecSql(strSQL);
            clsPrjTabBLEx.SetUpdDate(strCurrTabId);
            //4、返回TRUE；
            return true;
        }



        /// <summary>
        /// 替换字段,在整个工程中替换字段
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strSourceFldId">源字段Id</param>
        /// <param name = "strTargetFldId">目标字段Id</param>
        /// <returns></returns>
        public static bool ReplaceField(string strPrjId, string strSourceFldId, string strTargetFldId, string strUserId)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strSQL;

            clsPrjTabFldBLEx.RefreshUpdDate4ReleTab(strSourceFldId, strUserId);

            strSQL = string.Format("Update PrjTabFld Set FldId = '{0}' where PrjId = '{1}' And FldId = '{2}'",
                                                strTargetFldId, strPrjId, strSourceFldId);

            return objSQL.ExecSql(strSQL);
        }
        /// <summary>
        /// 替换字段,在整个工程中替换字段
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strSourceFldId">源字段Id</param>
        /// <param name = "strTargetFldId">目标字段Id</param>
        /// <returns></returns>
        public static bool ReplaceField(string strPrjId, string strTabId, string strSourceFldId, string strTargetFldId, string strUserId)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strSQL;
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objPrjTabEN.UpdUserId = strUserId;
            clsPrjTabBL.UpdateBySql2(objPrjTabEN);
            strSQL = string.Format("Update PrjTabFld Set FldId = '{0}' where PrjId = '{1}' And TabId = '{3}' And FldId = '{2}'",
                                                strTargetFldId, strPrjId, strSourceFldId, strTabId);
            clsPrjTabBLEx.SetUpdDate(strTabId, strUserId);
            return objSQL.ExecSql(strSQL);
        }


        /// <summary>
        /// 替换表字段列表中的源字段名替换成新字段名1
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <param name="strTabId"></param>
        /// <param name="strSourceStr"></param>
        /// <param name="strTargetStr"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        public static bool ReplaceStringInField(string strPrjId, string strTabId, string strSourceStr, string strTargetStr, string strUserId)
        {
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("TabId = '{0}'", strTabId);
            List<clsvPrjTabFldEN> arrvPrjTabFldObjLst = clsvPrjTabFldBL.GetObjLst(sbCondition.ToString());
            foreach (clsvPrjTabFldEN objvPrjTabFldEN in arrvPrjTabFldObjLst)
            {
                if (objvPrjTabFldEN.FldName.IndexOf(strSourceStr) == -1) continue;
                string strFldName_T = objvPrjTabFldEN.FldName.Replace(strSourceStr, strTargetStr);
                string strFldId_T = clsFieldTabBLEx.GetFldId(strPrjId, strFldName_T, objvPrjTabFldEN.DataTypeId);
                if (string.IsNullOrEmpty(strFldId_T) == true)
                {
                    clsFieldTabENEx objFieldTab_S = clsFieldTabBLEx.GetObjExByFldIDCache(objvPrjTabFldEN.FldId, strPrjId);
                    clsFieldTabENEx objFieldTab_T = new clsFieldTabENEx();
                    clsFieldTabBL.CopyTo(objFieldTab_S, objFieldTab_T);
                    objFieldTab_T.FldName = strFldName_T;
                    objFieldTab_T.FldId = clsGeneralTab2.GetMaxStrId("FieldTab", "FldId", 8, strPrjId);
                    objFieldTab_T.AddRecordEx();
                    strFldId_T = objFieldTab_T.FldId;
                }
                ReplaceField(strPrjId, strTabId, objvPrjTabFldEN.FldId, strFldId_T, strUserId);
                clsPrjTabBLEx.SetUpdDate(strTabId);
                //   clsFldObjTabBLEx.ReplaceFieldByObjId(strPrjId, strObjId, objvPrjTabFldEN.FldId, strFldId_T, strUserId);
            }

            return true;
        }

        /// <summary>
        /// 功能:从[工程表]的相关对象中把对象相关字段列表复制到[工程表]的表字段中
        /// </summary>
        /// <param name = "strSouPrjId">指定的[工程表]</param>
        /// <param name = "strTarPrjId">指定的[工程表]</param>
        /// <param name = "strSouTabId">指定的[工程表]</param>
        /// <param name = "strTarTabId">指定的[工程表]</param>
        /// <param name = "strSouFldId">指定的[工程表]</param>
        /// <param name = "strTarFldId">指定的[工程表]</param>
        /// <returns>是否成功</returns>
        public static bool CopyPrjTabFld(string strSouPrjId, string strTarPrjId,
            string strSouTabId, string strTarTabId, string strSouFldId, string strTarFldId)
        {
            //操作步骤:
            //1、获取源<工程表字段>记录。根据源<表ID>和源<字段ID>,并获取该记录的属性。
            //2、新建一个目标<工程表字段>对象;
            //3、设置目标<工程表字段>对象的相关属性；
            //4、把目标<工程表字段>对象插入到数据库表中；
            //5、返回是否成功；

            long lngMid;
            clsPrjTabFldEN objSouPrjTabFld, objTarPrjTabFld;
            //1、获取源<工程表字段>记录。根据源<表ID>和源<字段ID>,并获取该记录的属性。
            lngMid = clsPrjTabFldBL.GetFirstID_S("TabId = '" + strSouTabId + "' AND FldId = '" + strSouFldId + "'");
            objSouPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngMid);

            //2、新建一个目标<工程表字段>对象;
            objTarPrjTabFld = new clsPrjTabFldEN();
            //3、设置目标<工程表字段>对象的相关属性；
            objTarPrjTabFld.PrjId = strTarPrjId;
            objTarPrjTabFld.TabId = strTarTabId;
            objTarPrjTabFld.FldId = strTarFldId;
            objTarPrjTabFld.IsParentObj = objSouPrjTabFld.IsParentObj;
            objTarPrjTabFld.IsTabForeignKey = objSouPrjTabFld.IsTabForeignKey;
            objTarPrjTabFld.IsTabNullable = objSouPrjTabFld.IsTabNullable;

            objTarPrjTabFld.IsTabUnique = objSouPrjTabFld.IsTabUnique;
            objTarPrjTabFld.PrimaryTypeId = objSouPrjTabFld.PrimaryTypeId;
            objTarPrjTabFld.MemoInTab = objSouPrjTabFld.MemoInTab;
            objTarPrjTabFld.SequenceNumber = objSouPrjTabFld.SequenceNumber;
            objTarPrjTabFld.FieldTypeId = objSouPrjTabFld.FieldTypeId;
            objTarPrjTabFld.FldOpTypeId = objSouPrjTabFld.FldOpTypeId;
            objTarPrjTabFld.UpdDate = clsDateTime.getTodayDateTimeStr(1);

            if (string.IsNullOrEmpty(objTarPrjTabFld.FieldTypeId) == true)
            {
                objTarPrjTabFld.FieldTypeId = "01";
            }
            //			objTarPrjTabFld.TabKeyFldName = objSouPrjTabFld.TabKeyFldName;

            //4、把目标<工程表字段>对象插入到数据库表中；
            if (clsPrjTabFldBLEx.IsExistSameFldId(strTarTabId, strTarFldId))	//判断是否有相同的关键字
            {
            }
            else
            {

                //clsvPrjTabFldBLEx.arrvPrjTabFldObjLstCache = null;

                return clsPrjTabFldBL.AddNewRecordBySql2(objTarPrjTabFld);
            }
            //5、返回是否成功；

            return true;
        }

        public static bool DelRecordEx(string strTabId, string strFldId)
        {
            long lngTabTabId = getTabFldId(strTabId, strFldId);
            if (lngTabTabId == 0)
            {
                StringBuilder sbMessage = new StringBuilder();

                string strTabName = clsPrjTabBL.GetObjByTabId(strTabId).TabName;
                var objFieldTab = clsFieldTabBL.GetObjByFldId(strFldId);
                if (objFieldTab == null)
                {
                    sbMessage.AppendFormat("表名:{0},字段id:{1}不存在!", strTabName, strFldId);
                }
                else
                {
                    string strFldName = objFieldTab.FldName;
                    sbMessage.AppendFormat("表名:{0},字段名:{1}不存在!", strTabName, strFldName);
                }

                throw new Exception(sbMessage.ToString());
            }
            clsPrjTabBLEx.SetUpdDate(strTabId);
            return DelRecordEx(lngTabTabId);
        }

        public static long getTabFldId(string strTabId, string strFldId)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("TabId = '{0}' and FldId = '{1}'", strTabId, strFldId);
            long lngTabFldId = clsPrjTabFldBL.GetFirstID_S(strCondition.ToString());
            return lngTabFldId;
        }
        /// <summary>
        /// 根据FldId获取相关的TabId列表
        /// </summary>
        /// <param name="strFldId">字段Id</param>
        /// <returns>相关的TabId列表</returns>
        public static List<string> getTabIdLstByFldId(string strFldId)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("{0} = '{1}'", conPrjTabFld.FldId, strFldId);
            List<string> arrTabId = clsPrjTabFldBL.GetFldValue(conPrjTabFld.TabId, strCondition.ToString());
            return arrTabId;
        }

        /// <summary>
        /// 从表字段中删除字段,即解除表与字段的关系
        /// </summary>
        /// <param name = "strTabId">表ID</param>
        /// <param name = "strFldId">字段Id</param>
        /// <returns>是否成功？</returns>
        public static bool DelFieldFromTab(string strTabId, string strFldId)
        {
            long lngTabTabId = getTabFldId(strTabId, strFldId);
            if (lngTabTabId == 0)
            {
                string strTabName = clsPrjTabBL.GetObjByTabId(strTabId).TabName;
                string strFldName = clsFieldTabBL.GetObjByFldId(strFldId).FldName;
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("表名:{0},字段名:{1}不存在!", strTabName, strFldName);
                throw new Exception(sbMessage.ToString());
            }
            clsPrjTabBLEx.SetUpdDate(strTabId);
            return DelRecordEx(lngTabTabId);
        }

        /// <summary>
        /// 功能:同步字段对象列表到给定表中
        /// </summary>
        /// <param name = "strTabId">表ID</param>
        /// <param name = "arrColumnsObjList">字段对象列表</param>
        /// <returns>成功？</returns>
        public static bool SynchFieldFromColumnObjList(string strTabId, ArrayList arrColumnsObjList)
        {
            //操作步骤:
            //1、表ID-->对象ID；
            //2、再向该工程表对象表中添加相关字段。
            //3、向视图表中添加该视图；
            //4、在视图表字段中添加相关字段。

            ArrayList objArr = new ArrayList();
            string strTabName;
            string strFldId;
            StringBuilder sbMessage = null;
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            strTabName = objPrjTabEN.TabName;
            //strObjId = objPrjTabEN.ObjId;
            //if (strObjId  ==  null || strObjId  ==  "")
            //{
            //    sbMessage = new StringBuilder();
            //    sbMessage.AppendFormat("表名:{0}没有相应的对象号,请检查!", strTabName);
            //    throw new Exception(sbMessage.ToString());
            //}

            //2、再向该视图表中添加相关字段。

            foreach (clsColumns objColumns in arrColumnsObjList)
            {
                //获取该表中字段名为所给字段名的FldId
                strFldId = getFldIdByFldName(strTabId, objColumns.Column_Name);
                clsFieldTabENEx objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(strFldId, objPrjTabEN.PrjId);

                objFieldTabEN.DataTypeId = clsDataTypeAbbrBLEx.GetDataTypeIdByName(objColumns.Type_Name);
                //objFieldTabEN.IsNull = (objColumns.Is_Nullable  ==  "YES");
                objFieldTabEN.FldLength = objColumns.length;

                objFieldTabEN.FldPrecision = objColumns.PRECISION;
                if (objFieldTabEN.UpdateRecordEx() == false)
                {
                    sbMessage = new StringBuilder();
                    sbMessage.AppendFormat("修改字段 :{0}不成功,请检查!", objColumns.Column_Name);
                    throw new Exception(sbMessage.ToString());
                }
                long lngMid = getTabFldId(strTabId, strFldId);
                clsPrjTabFldEN objPrjTabFldEN = new clsPrjTabFldEN(lngMid);
                objPrjTabFldEN.IsTabNullable = (objColumns.Is_Nullable == "YES");
                objPrjTabFldEN.PrjId = objPrjTabEN.PrjId;
                if (clsPrjTabFldBL.UpdateBySql2(objPrjTabFldEN) == false)
                {
                    sbMessage = new StringBuilder();
                    sbMessage.AppendFormat("修改字段 :{0}不成功,请检查!", objColumns.Column_Name);
                    throw new Exception(sbMessage.ToString());
                }
            }
            clsPrjTabBLEx.SetUpdDate(strTabId);
            return true;
        }

        /// <summary>
        /// 功能:同步Sql字段信息到代码系统中
        /// </summary>
        /// <param name = "strTabId">表ID</param>
        /// <param name = "strColumn_Name">字段名</param>
        /// <param name = "strType_Name">类型名</param>
        /// <param name = "intLength">字段长度</param>
        /// <param name = "intPrecision">小数位数</param>
        /// <param name = "strIs_Nullable">是否可空</param>
        /// <returns>成功？</returns>
        public static string SynchFieldFromColumnObj(string strTabId, string strColumn_Name, string strType_Name,
            int intLength, int intPrecision, bool bolIs_Nullable, string strUpdUser)
        {
            //操作步骤:
            //1、表ID-->对象ID；
            //2、再向该工程表对象表中添加相关字段。
            //3、向视图表中添加该视图；
            //4、在视图表字段中添加相关字段。

            ArrayList objArr = new ArrayList();
            string strTabName;
            string strFldId;
            StringBuilder sbMessage = null;
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            strTabName = objPrjTabEN.TabName;
            //strObjId = objPrjTabEN.ObjId;
            //if (strObjId  ==  null || strObjId  ==  "")
            //{
            //    sbMessage = new StringBuilder();
            //    sbMessage.AppendFormat("表名:{0}没有相应的对象号,请检查!", strTabName);
            //    throw new Exception(sbMessage.ToString());
            //}

            //2、再向该视图表中添加相关字段。


            //获取该表中字段名为所给字段名的FldId
            strFldId = getFldIdByFldName(strTabId, strColumn_Name);
            clsFieldTabENEx objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(strFldId, objPrjTabEN.PrjId);

            objFieldTabEN.DataTypeId = clsDataTypeAbbrBLEx.GetDataTypeIdByName(strType_Name);
            //objFieldTabEN.IsNull = (objColumns.Is_Nullable  ==  "YES");
            objFieldTabEN.FldLength = intLength;

            objFieldTabEN.FldPrecision = intPrecision;
            objFieldTabEN.UpdUser = strUpdUser;
            objFieldTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            if (objFieldTabEN.UpdateRecordEx() == false)
            {
                sbMessage = new StringBuilder();
                sbMessage.AppendFormat("修改字段 :{0}不成功,请检查!", strColumn_Name);
                throw new Exception(sbMessage.ToString());
            }
            long lngMid = getTabFldId(strTabId, strFldId);
            clsPrjTabFldEN objPrjTabFldEN = clsPrjTabFldBL.GetObjBymId(lngMid);
            objPrjTabFldEN.PrjId = objPrjTabEN.PrjId;
            objPrjTabFldEN.IsTabNullable = bolIs_Nullable;
            objPrjTabFldEN.UpdUser = strUpdUser;
            objPrjTabFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            if (clsPrjTabFldBL.UpdateBySql2(objPrjTabFldEN) == false)
            {
                sbMessage = new StringBuilder();
                sbMessage.AppendFormat("修改字段 :{0}不成功,请检查!", strColumn_Name);
                throw new Exception(sbMessage.ToString());
            }
            clsPrjTabBLEx.SetUpdDate(strTabId);
            return strFldId;
        }

        /// <summary>
        /// 根据字段名在表字段中打到相应的FldId
        /// </summary>
        /// <param name = "strTabId">表ID</param>
        /// <param name = "strFldName">字段名</param>
        /// <returns>返回的字段ID</returns>
        public static string getFldIdByFldName(string strTabId, string strFldName)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("TabId = '{0}' and FldName = '{1}'", strTabId, strFldName);
            string strFldId = clsvPrjTabFldBL.GetFirstObj_S(strCondition.ToString()).FldId;
            return strFldId;
        }

        /// <summary>
        /// 功能:导入字段对象列表到给定表中
        /// </summary>
        /// <param name = "strTabId">表ID</param>
        /// <param name = "arrColumnsObjList">字段对象列表</param>
        /// <param name = "strUpdUserId">修改用户Id</param>
        /// <returns>成功？</returns>
        public static bool ImportFieldFromColumnObjList(string strTabId, ArrayList arrColumnsObjList, string strUpdUserId)
        {
            //操作步骤:
            //1、表ID-->对象ID；
            //2、再向该工程表对象表中添加相关字段。
            //3、向视图表中添加该视图；
            //4、在视图表字段中添加相关字段。

            ArrayList objArr = new ArrayList();
            string strTabName;
            //string strObjId;
            string strFldId;
            //StringBuilder sbMessage = null;
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            strTabName = objPrjTabEN.TabName;
            //strObjId = objPrjTabEN.ObjId;
            //if (strObjId == null || strObjId == "")
            //{
            //    sbMessage = new StringBuilder();
            //    sbMessage.AppendFormat("表名:{0}没有相应的对象号,请检查!", strTabName);
            //    throw new Exception(sbMessage.ToString());
            //}

            //2、再向该视图表中添加相关字段。


            bool bolIsUpdTab = false;
            foreach (clsColumns objColumns in arrColumnsObjList)
            {
                strFldId = clsFieldTabBLEx.ImportFldToFieldTab(objColumns, objPrjTabEN.PrjId, strUpdUserId);
                if (strFldId != null && strFldId != "")
                {
                    bool bolIsTabNullable = (objColumns.Is_Nullable == "YES");
                    bool bolIsResult = AddNewRec(strTabId, strFldId, bolIsTabNullable, strUpdUserId);
                    if (bolIsResult == true)
                    {
                        bolIsUpdTab = true;
                    }
                }
            }
            if (bolIsUpdTab == true)
            {
                clsPrjTabBLEx.SetUpdDate(strTabId, strUpdUserId);
            }
            return true;
        }

        ///// <summary>
        ///// 功能:导入字段信息到FieldTab中
        ///// </summary>
        ///// <param name = "objColumns">字段对象</param>
        ///// <param name = "strObjId">对象ID</param>
        ///// <returns>是否成功？</returns>
        //public static string ImportFldToFieldTabBak20170706(clsColumns objColumns, string strObjId)
        //{
        //    clsFieldTabENEx objFieldTabEN;
        //    string strPrjId = clsPrjObjectsBL.GetPrjObjectsByObjId(strObjId).PrjId;
        //    objFieldTabEN = new clsFieldTabENEx();
        //    ///工程ID
        //    objFieldTabEN.PrjId = strPrjId;
        //    if (objColumns.Type_Name == "bigint identity")
        //    {
        //        objColumns.Type_Name = "bigint";
        //    }
        //    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBLEx.GetDataTypeAbbrObjByName(objColumns.Type_Name);

        //    if (objDataTypeAbbrEN == null)
        //    {
        //        throw new Exception(string.Format("Sql Server中数据类型名:{0}不存在,请检查!", objColumns.Type_Name));
        //    }
        //    ///检查是否存在相同的字段名
        //    if (clsFieldTabBLEx.IsExistSameFldName(strPrjId, objColumns.Column_Name, objDataTypeAbbrEN.DataTypeId) == true)
        //    {
        //        objFieldTabEN.FldId = clsFieldTabBLEx.GetFldId(strPrjId, objColumns.Column_Name, objDataTypeAbbrEN.DataTypeId);
        //        clsFldObjTabBLEx.CreateFldObjRelation(strObjId, objFieldTabEN.FldId);
        //    }
        //    else
        //    {
        //        objFieldTabEN.FldId = clsGeneralTab.GetMaxStrId("FieldTab", "FldId", 8, strPrjId);
        //        objFieldTabEN.FldName = objColumns.Column_Name;
        //        ///转换类型名称

        //        //clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBLEx.GetDataTypeAbbrObjByName(objColumns.Type_Name);
        //        //List<string> arrID = new List<string>();
        //        //arrID = clsDataTypeAbbrBL.GetPrimaryKeyID_S("DataTypeName = '" + objColumns.Type_Name + "'");
        //        //if (arrID.Count  ==  0)
        //        //{
        //        //    throw new Exception(string.Format("Sql Server中数据类型名:{0}不存在,请检查!", objColumns.Type_Name));
        //        //}

        //        objFieldTabEN.DataTypeId = objDataTypeAbbrEN.DataTypeId;
        //        objFieldTabEN.IsNull = (objColumns.Is_Nullable == "YES");
        //        objFieldTabEN.IsPrimaryKey = false;
        //        objFieldTabEN.FldLength = objColumns.length;
        //        objFieldTabEN.FldPrecision = objColumns.PRECISION;
        //        objFieldTabEN.Caption = objColumns.Column_Name;
        //        objFieldTabEN.IsOnlyOne = false;
        //        objFieldTabEN.FldStateId = "01";
        //        if (clsFieldTabBLEx.AddNewRecordEx(objFieldTabEN) == false)
        //        {
        //            StringBuilder sbMessage = new StringBuilder();
        //            sbMessage.AppendFormat("添加字段 :{0}不成功,请检查!", objColumns.Column_Name);
        //            throw new Exception(sbMessage.ToString());
        //        }
        //        clsFldObjTabBLEx.CreateFldObjRelation(strObjId, objFieldTabEN.FldId);
        //    }
        //    return objFieldTabEN.FldId;
        //}


        /// <summary>
        /// 功能:从[工程表]的相关对象中把对象相关字段列表复制到[工程表]的表字段中
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strFldId">字段Id</param>
        /// <param name = "bolIsTabNullable">是否可空</param>
        /// <param name = "strUpdUser">修改用户</param>
        /// <returns>是否成功</returns>
        public static bool AddNewRec(string strTabId, string strFldId,
            bool bolIsTabNullable, string strUpdUser, bool bolIsForExtendClass = false, string strDnPathId = "")
        {
            //操作步骤:
            //1、获取当前视图ID的相关对象ID；
            //2、获取相关对象ID的字段ID的DataTable;
            //3、对该表进行循环,把字段信息插入到一个ArrayList
            //4、在插入过程中,要注意字段ID的重复,不能插入重复

            string strPrjId;

            //ArrayList objArr = new ArrayList();
            //1、获取当前表ID的相关对象ID；
            strPrjId = clsPrjTabBL.GetObjByTabId(strTabId).PrjId;

            int intViewFldCount;
            clsFieldTabENEx objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(strFldId, strPrjId);

            clsPrjTabFldEN objPrjTabFldEN = null;
            intViewFldCount = clsGeneralTab2.funGetRecCountByCond("PrjTabFld", "TabId = '" + strTabId + "'");
            objPrjTabFldEN = new clsPrjTabFldEN();
            objPrjTabFldEN.TabId = strTabId;
            objPrjTabFldEN.PrjId = strPrjId;
            objPrjTabFldEN.FldId = strFldId;

            objPrjTabFldEN.PrimaryTypeId = "00";
            objPrjTabFldEN.FldOpTypeId = "0001";

            objPrjTabFldEN.IsTabForeignKey = false;
            objPrjTabFldEN.IsTabNullable = bolIsTabNullable;//;	//默认为可空
            objPrjTabFldEN.IsForExtendClass = bolIsForExtendClass;
            objPrjTabFldEN.DnPathId = strDnPathId;
            if (objPrjTabFldEN.DnPathId == "") objPrjTabFldEN.DnPathId = null;
            objPrjTabFldEN.FieldTypeId = "01";	//默认为一般字段
            objPrjTabFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objPrjTabFldEN.UpdUser = strUpdUser;

            //3.1、判断是否有相同的字段存在。					
            if (clsPrjTabFldBLEx.IsExistSameFldId(strTabId, objFieldTabEN.FldId))	//判断是否有相同的关键字
            {
                return false;
            }
            else
            {
                objPrjTabFldEN.SequenceNumber = intViewFldCount + 1;
                clsPrjTabFldBLEx.AddNewRecordBySql2(objPrjTabFldEN);
                clsvSqlViewFldBL.ReFreshThisCache(objPrjTabFldEN.PrjId);
                clsvSqlViewRelaTabBL.ReFreshThisCache(objPrjTabFldEN.PrjId);
                return true;
            }
            //return false;
        }


        /// <summary>
        /// 功能:把【字段（FldId）】添加到【工程表】的表字段中
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <param name = "strFldId">字段Id</param>
        /// <param name = "strUpdUser">修改用户Id</param>
        /// <returns>是否成功</returns>
        public static bool Add_FieldTabToPrjTabFld(string strTabId, string strFldId, string strUpdUser)
        {
            //操作步骤:
            //1、获取当前视图ID的相关对象ID；
            //2、获取相关对象ID的字段ID的DataTable;
            //3、对该表进行循环,把字段信息插入到一个ArrayList
            //4、在插入过程中,要注意字段ID的重复,不能插入重复

            string strPrjId;

            //ArrayList objArr = new ArrayList();
            //1、获取当前表ID的相关对象ID；
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            strPrjId = (objPrjTabEN.PrjId);
            //strObjId = objPrjTabEN.ObjId;
            int intViewFldCount;
            clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldId);
            clsPrjTabFldEN objPrjTabFldEN;
            intViewFldCount = clsGeneralTab2.funGetRecCountByCond("PrjTabFld", "TabId = '" + strTabId + "'");
            objPrjTabFldEN = new clsPrjTabFldEN();
            objPrjTabFldEN.TabId = strTabId;
            objPrjTabFldEN.PrjId = strPrjId;
            objPrjTabFldEN.FldId = objFieldTabEN.FldId;
            objPrjTabFldEN.FieldTypeId = objFieldTabEN.FieldTypeId;
            objPrjTabFldEN.PrimaryTypeId = "00";
            objPrjTabFldEN.FldOpTypeId = "0001";
            objPrjTabFldEN.IsGeneProp = true;
            objPrjTabFldEN.IsTabForeignKey = false;
            objPrjTabFldEN.IsTabNullable = objFieldTabEN.IsNull;	//默认为可空
            if (string.IsNullOrEmpty(objPrjTabFldEN.FieldTypeId) == true)
            {
                objPrjTabFldEN.FieldTypeId = "01";  //默认为一般字段
            }
            objPrjTabFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objPrjTabFldEN.UpdUser = strUpdUser;

            //3.1、判断是否有相同的字段存在。					
            if (clsPrjTabFldBLEx.IsExistSameFldId(strTabId, objFieldTabEN.FldId))	//判断是否有相同的关键字
            {
                //clsFldObjTabBLEx.CreateFldObjRelation(strObjId, strFldId);
                return false;
            }
            else
            {
                objPrjTabFldEN.SequenceNumber = intViewFldCount + 1;
                clsPrjTabFldBLEx.AddNewRecordBySql2(objPrjTabFldEN);
                clsPrjTabBLEx.SetUpdDate(strTabId, strUpdUser);
                //clsFldObjTabBLEx.CreateFldObjRelation(strObjId, strFldId);
                return true;
            }
            //return false;
        }



        /// <summary>
        /// 功能:把【字段（FldId）】添加到【工程表】的表字段中
        /// </summary>
        /// <param name = "arrTarTabIdLst">目标表Id列表</param>
        /// <param name = "strFldId">字段Id</param>
        /// <param name = "strUpdUser">修改用户Id</param>
        /// <returns>是否成功</returns>
        public static bool EditPrjTabFld4FieldTab(string strFldId, List<string> arrTarTabIdLst, string strUpdUser)
        {
            List<string> arrTabIdLst = getTabIdLstByFldId(strFldId);
            List<string> arrTabIdLst_Del = clsAggregate.TwoAggrDiff(arrTabIdLst, arrTarTabIdLst);
            if (arrTabIdLst_Del.Count > 0)
            {
                string strCondition_Del = string.Format("{0}='{1}' And {2} in ({3})",
                    conPrjTabFld.FldId, strFldId, conPrjTabFld.TabId,
                    clsArray.GetSqlInStrByArray(arrTabIdLst_Del, true));
                clsPrjTabFldBL.DelPrjTabFldsByCond(strCondition_Del);
            }
            List<string> arrTabIdLst_Add = clsAggregate.TwoAggrDiff(arrTarTabIdLst, arrTabIdLst);
            foreach (string strTabId in arrTabIdLst_Add)
            {
                Add_FieldTabToPrjTabFld(strTabId, strFldId, strUpdUser);
            }

            return true;
        }


        /// <summary>
        /// 功能:替换：【工程表】的字段，把源FldId替换成目录FldId
        /// </summary>
        /// <param name = "strTabId">指定的【表Id】</param>
        /// <param name = "strFldId_S">源字段Id</param>
        /// <param name = "strFldId_T">目标字段Id</param>
        /// <returns>是否成功</returns>
        public static bool ReplaceFieldInPrjTabFld(string strTabId, string strFldId_S, string strFldId_T)
        {
            //操作步骤:
            //1、获取当前视图ID的相关对象ID；
            //2、获取相关对象ID的字段ID的DataTable;
            //3、对该表进行循环,把字段信息插入到一个ArrayList
            //4、在插入过程中,要注意字段ID的重复,不能插入重复


            string strPrjId;
            //1、获取当前表ID的相关对象ID；
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            strPrjId = (objPrjTabEN.PrjId);
            //strObjId = objPrjTabEN.ObjId;

            //clsFieldTabENEx objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldId);
            string strSQL = "";
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPrjTabDA.GetSpecSQLObj();
            //删除PrjTabFld本表中与当前对象有关的记录
            strSQL = strSQL + string.Format("update PrjTabFld set fldid = '{0}' where tabid = '{1}' and FldId = '{2}';",
               strFldId_T, strTabId, strFldId_S);
            clsPrjTabBLEx.SetUpdDate(strTabId);
            //if (string.IsNullOrEmpty(strObjId) == false)
            //{
            //    strSQL = strSQL + string.Format("update FldObjTab set fldid = '{0}' where ObjId = '{1}' and FldId = '{2}';",
            //                   strFldId_T, strObjId, strFldId_S);
            //}
            return objSQL.ExecSql(strSQL);

            //return false;
        }

        /// <summary>
        /// 功能:刷新某FldId的相关表的修改日期，即使用过该FldId的相关表都刷新一下日期
        /// </summary>
        /// <param name = "strFldId">字段Id</param>
        /// <param name = "strUserId">用户Id</param>
        /// <returns>是否成功</returns>
        public static bool RefreshUpdDate4ReleTab(string strFldId, string strUserId)
        {
            //操作步骤:
            //1、获取当前视图ID的相关对象ID；
            //2、获取相关对象ID的字段ID的DataTable;
            //3、对该表进行循环,把字段信息插入到一个ArrayList
            //4、在插入过程中,要注意字段ID的重复,不能插入重复

            string strCondition = string.Format(" {0} in (select {0} From {1} Where {2} = '{3}')",
                conPrjTab.TabId,
                clsPrjTabFldEN._CurrTabName,
                conPrjTabFld.FldId, strFldId);
            List<clsPrjTabEN> arrPrjTabObjLst = clsPrjTabBL.GetObjLst(strCondition);

            foreach (clsPrjTabEN objPrjTabEN in arrPrjTabObjLst)
            {
                objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objPrjTabEN.UpdUserId = strUserId;

                if (string.IsNullOrEmpty(objPrjTabEN.RelaTabId4View) == true) objPrjTabEN.RelaTabId4View = null;
                clsPrjTabBL.UpdateBySql2(objPrjTabEN);
            }

            return true;

            //return false;
        }

        /// <summary>
        /// 功能:导入字段信息到FieldTab中
        /// </summary>
        /// <param name = "objColumns">字段对象</param>
        /// <param name = "strPrjId">对象ID</param>
        /// <returns>是否成功？</returns>
        public static string ImportFldToFieldTabForOra(com.taishsoft.sqlfororacle.clsColumns objColumns, string strPrjId)
        {
            clsFieldTabENEx objFieldTabEN;

            objFieldTabEN = new clsFieldTabENEx();
            //工程ID
            objFieldTabEN.PrjId = strPrjId;
            clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBLEx.GetObjByName(objColumns.Type_Name);

            if (objDataTypeAbbrEN == null)
            {
                throw new Exception(string.Format("ORACLE中数据类型名:{0}不存在,请检查!", objColumns.Type_Name));
            }
            //检查是否存在相同的字段名
            if (clsFieldTabBLEx.IsExistSameFldName(strPrjId, objColumns.Column_Name, objDataTypeAbbrEN.DataTypeId) == true)
            {
                objFieldTabEN.FldId = clsFieldTabBLEx.GetFldId(strPrjId, objColumns.Column_Name, objDataTypeAbbrEN.DataTypeId);
                //clsFldObjTabBLEx.CreateFldObjRelation(strObjId, objFieldTabEN.FldId);
            }
            else
            {
                objFieldTabEN.FldId = clsGeneralTab.GetMaxStrId("FieldTab", "FldId", 8, strPrjId);
                objFieldTabEN.FldName = objColumns.Column_Name;
                //转换类型名称

                //List<string> arrID = new List<string>();
                //arrID = clsDataTypeAbbrBL.GetPrimaryKeyID_S("OraDbType = '" + objColumns.Type_Name + "'");
                //if (arrID  ==  null || arrID.Count  ==  0)
                //{
                //    throw new Exception(string.Format("ORACLE中数据类型名:{0}不存在,请检查!", objColumns.Type_Name));
                //}
                objFieldTabEN.DataTypeId = objDataTypeAbbrEN.DataTypeId;
                objFieldTabEN.IsNull = (objColumns.Is_Nullable == "YES");
                objFieldTabEN.IsPrimaryKey = false;
                objFieldTabEN.FldLength = objColumns.length;
                objFieldTabEN.Caption = objColumns.Column_Name;
                objFieldTabEN.IsOnlyOne = false;
                objFieldTabEN.FldStateId = "01";
                if (clsFieldTabBLEx.AddNewRecordEx(objFieldTabEN) == false)
                {
                    StringBuilder sbMessage = new StringBuilder();
                    sbMessage.AppendFormat("添加字段 :{0}不成功,请检查!", objColumns.Column_Name);
                    throw new Exception(sbMessage.ToString());
                }
                //clsFldObjTabBLEx.CreateFldObjRelation(strObjId, objFieldTabEN.FldId);
            }
            return objFieldTabEN.FldId;
        }
        /// <summary>
        /// 功能:导入字段对象列表到给定表中
        /// </summary>
        /// <param name = "strTabId">表ID</param>
        /// <param name = "arrColumnsObjList">字段对象列表</param>
        /// <param name = "strUpdUser">修改用户</param>
        /// <returns>成功？</returns>
        public static bool ImportFieldFromColumnObjListForOra(string strTabId, ArrayList arrColumnsObjList, string strUpdUser)
        {
            //操作步骤:
            //1、表ID-->对象ID；
            //2、再向该工程表对象表中添加相关字段。
            //3、向视图表中添加该视图；
            //4、在视图表字段中添加相关字段。

            ArrayList objArr = new ArrayList();
            string strTabName;
            //string strObjId;
            string strFldId;
            //StringBuilder sbMessage = null;
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            strTabName = objPrjTabEN.TabName;
            //strObjId = objPrjTabEN.ObjId;
            //if (strObjId == null || strObjId == "")
            //{
            //    sbMessage = new StringBuilder();
            //    sbMessage.AppendFormat("表名:{0}没有相应的对象号,请检查!", strTabName);
            //    throw new Exception(sbMessage.ToString());
            //}

            //2、再向该视图表中添加相关字段。

            foreach (com.taishsoft.sqlfororacle.clsColumns objColumns in arrColumnsObjList)
            {
                strFldId = ImportFldToFieldTabForOra(objColumns, objPrjTabEN.PrjId);
                if (strFldId != null && strFldId != "")
                {
                    Add_FieldTabtoPrjTabFldForOra(strTabId, strFldId, objColumns, strUpdUser);
                }
            }
            return true;
        }

        /// <summary>
        /// 功能:从[工程表]的相关对象中把对象相关字段列表复制到[工程表]的表字段中
        /// </summary>
        /// <param name = "strTabId">指定的[工程表]</param>
        /// <param name = "strFldId">指定的[工程表]</param>
        /// <param name = "objColumns">指定的[工程表]</param>
        /// <param name = "strUpdUser">指定的[工程表]</param>
        /// <returns>是否成功</returns>
        public static bool Add_FieldTabtoPrjTabFldForOra(string strTabId, string strFldId,
            com.taishsoft.sqlfororacle.clsColumns objColumns, string strUpdUser)
        {
            //操作步骤:
            //1、获取当前视图ID的相关对象ID；
            //2、获取相关对象ID的字段ID的DataTable;
            //3、对该表进行循环,把字段信息插入到一个ArrayList
            //4、在插入过程中,要注意字段ID的重复,不能插入重复

            string strPrjId;

            ArrayList objArr = new ArrayList();
            //1、获取当前表ID的相关对象ID；
            strPrjId = (clsPrjTabBL.GetObjByTabId(strTabId).PrjId);

            int intViewFldCount;
            clsFieldTabENEx objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(strFldId, strPrjId);
            clsPrjTabFldEN objPrjTabFldEN;
            intViewFldCount = clsGeneralTab2.funGetRecCountByCond("PrjTabFld", "TabId = '" + strTabId + "'");
            objPrjTabFldEN = new clsPrjTabFldEN();
            objPrjTabFldEN.TabId = strTabId;
            objPrjTabFldEN.PrjId = strPrjId;
            objPrjTabFldEN.FldId = objFieldTabEN.FldId;

            objPrjTabFldEN.PrimaryTypeId = "00";
            objPrjTabFldEN.FldOpTypeId = "0001";

            objPrjTabFldEN.IsTabForeignKey = false;
            objPrjTabFldEN.IsTabNullable = (objColumns.Is_Nullable == "YES");	//默认为可空
            objPrjTabFldEN.FieldTypeId = "01";	//默认为一般字段
            objPrjTabFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objPrjTabFldEN.UpdUser = strUpdUser;

            //3.1、判断是否有相同的字段存在。					
            if (clsPrjTabFldBLEx.IsExistSameFldId(strTabId, objFieldTabEN.FldId))	//判断是否有相同的关键字
            {
            }
            else
            {
                objPrjTabFldEN.SequenceNumber = intViewFldCount + 1;
                clsPrjTabFldBLEx.AddNewRecordBySql2(objPrjTabFldEN);
            }
            return true;
        }



        public static void ReNumber(string strTabId)
        {
            //通过存储过程来
            //直接使用
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            //objSQL.SPConfigXMLFile = strFileFolder + "\\XML\\XMLSP.xml";
            //			 gobjSQL.SPConfigXMLFile = "..\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strTabId);

            objSQL.ExecSP2("ReNumberForPrjTabFld", values);
            clsPrjTabBLEx.SetUpdDate(strTabId);
            //			return true;
        }
        public new static void ReOrder(string strTabId)
        {
            List<clsPrjTabFldEN> arrPrjTabFldObjList = clsPrjTabFldBL.GetObjLst("TabId = '" + strTabId + "' order by SequenceNumber ");
            arrPrjTabFldObjList = arrPrjTabFldObjList.OrderBy(x => x.FieldTypeId).ToList();

            List<string> arrNoNeedFieldTypeId = new List<string>() {
                enumFieldType.ManageField_04,
                enumFieldType.BeingNot_18,
                enumFieldType.SynField_08,
                enumFieldType.CalcField_11
            };
            IDictionary<string, int> dicFieldTypeOrderNum = new Dictionary<string, int>();
            dicFieldTypeOrderNum.Add(enumFieldType.CalcField_11, 1);
            dicFieldTypeOrderNum.Add(enumFieldType.ManageField_04, 2);
            dicFieldTypeOrderNum.Add(enumFieldType.SynField_08, 3);
            dicFieldTypeOrderNum.Add(enumFieldType.BeingNot_18, 4);

            List<clsPrjTabFldEN> arrPrjTabFldObjList_Sel = arrPrjTabFldObjList.Where(x => arrNoNeedFieldTypeId.Contains(x.FieldTypeId)).ToList();
            arrPrjTabFldObjList_Sel.ForEach(x => x.SequenceNumber = x.SequenceNumber + dicFieldTypeOrderNum[x.FieldTypeId] * 200);
            arrPrjTabFldObjList = arrPrjTabFldObjList.OrderBy(x => x.SequenceNumber).ToList();
            int intIndex = 1;
            foreach (clsPrjTabFldEN objPrjTabFldEN in arrPrjTabFldObjList)
            {
                objPrjTabFldEN.SequenceNumber = intIndex;
                
                clsPrjTabFldBL.UpdateBySql2(objPrjTabFldEN);
                intIndex++;
            }
            clsPrjTabBLEx.SetUpdDate(strTabId);
        }
        /// <summary>
        /// 功能:移动到新的序号
        /// </summary>
        /// <param name = "strTabId">界面ID</param>
        /// <param name = "intSequenceNumber">当前序号</param>
        /// <param name = "intNewSequenceNumber">新的序号</param>
        /// <returns>如果增1成功就返回true, 否则返回false.</returns>
        public bool MoveRecSeqTo(string strTabId, int intSequenceNumber, int intNewSequenceNumber)
        {
            //操作步骤:
            //1、获取当前界面的操作步骤的数目(intStepsNum, 操作步骤的数目)；
            //2、如果当前步骤序号大于或等于(intStepsNum, 操作步骤的数目)记录数,就退出本过程,并返回false；
            //3、获取当前记录(本操作序号)的关键字(bintIdForCurrStep)；
            //4、获取下条记录(下一步骤序号)的关键字(bintIdForNextStep)；
            //5、修改当前步骤的序号,使之增1；
            //6、修改下一步骤的序号,使之减1；
            //7、返回TRUE；
            string strSQL;
            int intStepsNum; //操作步骤的数目
            long lngIdForCurrStep;		//, lngIdForNextStep;   //当前记录(本操作序号)的关键字,下条记录(下一步骤序号)的关键字
            //			int intNextSequenceNumber;
            List<string> arrLst;
            //1、获取当前界面的操作步骤的数目(intStepsNum, 操作步骤的数目)；
            intStepsNum = clsGeneralTab2.funGetRecCountByCond(clsPrjTabFldEN._CurrTabName, "TabId = '" + strTabId + "'");
            //2、如果当前步骤序号大于或等于(intStepsNum, 操作步骤的数目)记录数,就退出本过程,并返回false；
            if (intSequenceNumber > intStepsNum) return false;
            //3、获取当前记录(本操作序号)的关键字(lngIdForCurrStep)；
            arrLst = clsGeneralTab2.funGetFldValue(clsPrjTabFldEN._CurrTabName, "mId", "TabId = '" + strTabId + "' and SequenceNumber = " + intSequenceNumber.ToString());
            lngIdForCurrStep = long.Parse(arrLst[0].ToString());

            if (intNewSequenceNumber == 1)
            {
                //5、修改当前步骤的序号,使之为0；
                clsPrjTabFldBL.SetFldValue(clsPrjTabFldEN._CurrTabName, "SequenceNumber", "0", "mId = " + lngIdForCurrStep.ToString());
                clsPrjTabFldBLEx.ReNumber(strTabId);
            }
            else if (intNewSequenceNumber == -1)
            {
                //5、修改当前步骤的序号,使之为0；
                clsPrjTabFldBL.SetFldValue(clsPrjTabFldEN._CurrTabName, "SequenceNumber", "1000", "mId = " + lngIdForCurrStep.ToString());
                clsPrjTabFldBLEx.ReNumber(strTabId);
            }
            else
            {
                //5、修改当前步骤的序号,使之增1；
                strSQL = "update PrjTabFld set SequenceNumber = SequenceNumber +1 where TabId = '" + strTabId + "' and SequenceNumber >=  " + intNewSequenceNumber.ToString();
                new clsSpecSQLforSql().ExecSql(strSQL);
                clsPrjTabFldBL.SetFldValue(clsPrjTabFldEN._CurrTabName, "SequenceNumber", intNewSequenceNumber.ToString(), "mId = " + lngIdForCurrStep.ToString());
                clsPrjTabFldBLEx.ReNumber(strTabId);
            }
            //7、返回TRUE；
            return true;
        }

        public static string getFldName(long lngTabFldId)
        {
            string strFldId = clsPrjTabFldBL.GetObjBymId(lngTabFldId).FldId;
            string strFldName = clsFieldTabBL.GetObjByFldId(strFldId).FldName;
            return strFldName;
        }
        /// <summary>
        /// 定义私有属性
        /// </summary>
        /// <param name = "ltLangType"></param>
        /// <param name = "objPrjTabFldENEx"></param>
        /// <returns></returns>
        public static string DefPrivateProperty(clsPubConst.LangType ltLangType, clsPrjTabFldENEx objPrjTabFldENEx)
        {
            switch (ltLangType)
            {
                case clsPubConst.LangType.CSharp:// "C#.NET":
                    if (objPrjTabFldENEx.IsNumberType() == true && objPrjTabFldENEx.IsTabNullable == true)
                    {
                        return "protected " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + "? " + objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName + ";" + "    //" + objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                    }
                    else
                    {
                        return "protected " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName + ";" + "    //" + objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                    }
                case clsPubConst.LangType.SilverLight:// "SilverLight":
                    return "protected " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName + ";" + "    //" + objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                case clsPubConst.LangType.JAVA:
                    return "protected " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType + " " + objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName + ";" + "    //" + objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                case clsPubConst.LangType.JavaScript:
                    return "var " + objPrjTabFldENEx.ObjFieldTabENEx.FldName + ";" + "    //" + objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                case clsPubConst.LangType.TypeScript:
                    return string.Format("private {0} = {3};    //{2}",
                        objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName,
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                        objPrjTabFldENEx.ObjFieldTabENEx.Caption,
                        objPrjTabFldENEx.ObjFieldTabENEx.InitValue_TypeScript);
                case clsPubConst.LangType.Swift:
                    return string.Format("internal var {0} : {1};     //{2} ",
                         objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName,
                         objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                case clsPubConst.LangType.Swift3:
                    return string.Format("internal var {0} : {1};     //{2} ",
                         objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName,
                         objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                case clsPubConst.LangType.Swift4:
                    return string.Format("internal var {0} : {1};     //{2} ",
                         objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName,
                         objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                case clsPubConst.LangType.VB:// "VB.NET":
                    return "protected " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.VbNetType + " " + objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName + ";" + "    //" + objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                default:
                    string strMsg = string.Format("语言类型：{0}在相应函数中没有被处理!({1})", ltLangType.ToString(), clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }

        /// <summary>
        /// 定义私有属性
        /// </summary>
        /// <param name = "ltLangType"></param>
        /// <param name = "objPrjTabFldENEx"></param>
        /// <returns></returns>
        public static string DefPublicProperty(clsPubConst.LangType ltLangType, clsPrjTabFldENEx objPrjTabFldENEx, bool bolIsFstLcase, IImportClass objImportClass, string strBaseUrl)
        {
            switch (ltLangType)
            {
                case clsPubConst.LangType.CSharp:// "C#.NET":
                    return "protected " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName + ";" + "    //" + objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                case clsPubConst.LangType.SilverLight:// "SilverLight":
                    return "protected " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName + ";" + "    //" + objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                case clsPubConst.LangType.JAVA:
                    return "protected " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType + " " + objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName + ";" + "    //" + objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                case clsPubConst.LangType.JavaScript:
                    return "var " + objPrjTabFldENEx.ObjFieldTabENEx.FldName + ";" + "    //" + objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                case clsPubConst.LangType.TypeScript:
                    if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "Object")
                    {
                        string strFldName = objPrjTabFldENEx.ObjFieldTabENEx.FldName;
                        if (strFldName.Substring(0, 3).ToLower() == "obj")
                        {
                            strFldName = strFldName.Substring(3);
                        }
                        else
                        {
                            string strMsg1 = string.Format("字段类型:[{0}]的字段名:[{1}]建议以[Obj]开始！",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, strFldName);

                            throw new Exception(strMsg1);
                        }
                        string strClassName = "";
                        string strTabName = "";
                        string strEx = "";
                        int intLen = strFldName.Length;
                        if (strFldName.Substring(intLen - 4) == "ENEx")
                        {
                            strClassName = string.Format("cls{0}", strFldName);
                            strTabName = strFldName.Substring(0, intLen - 4);
                            strEx = "Ex";
                        }

                        else if (strFldName.Substring(intLen - 2) == "Ex")
                        {
                            strFldName = strFldName.Substring(0, intLen - 2);
                            strClassName = string.Format("cls{0}ENEx", strFldName);
                            strTabName = strFldName.Substring(0, intLen - 2);
                            strEx = "Ex";
                        }
                        else if (strFldName.Substring(intLen - 2) == "EN")
                        {
                            strFldName = strFldName.Substring(0, intLen - 2);
                            strClassName = string.Format("cls{0}EN", strFldName);
                            strTabName = strFldName.Substring(0, intLen - 2);
                        }
                        else
                        {
                            strClassName = string.Format("cls{0}EN", strFldName);
                            strTabName = strFldName;
                        }
                        string strTabId = clsPrjTabBLEx.GetTabIdByTabNameExCache(objPrjTabFldENEx.PrjId, strTabName);
                        objImportClass.AddImportClass(strTabId, strTabName, string.Format("cls{0}EN", strTabName, strEx),
                               string.IsNullOrEmpty(strEx) == true ? enumImportObjType.ENClass : enumImportObjType.ENExClass, strBaseUrl);

                        return string.Format("public {0} = new {1}();    //{2}",
                       objPrjTabFldENEx.ObjFieldTabENEx.PropertyName(bolIsFstLcase),
                       strClassName,
                       objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    }
                    else
                    {
                        return string.Format("public {0} = {3};    //{2}",
                            objPrjTabFldENEx.ObjFieldTabENEx.PropertyName(bolIsFstLcase),
                            objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                            objPrjTabFldENEx.ObjFieldTabENEx.Caption,
                            objPrjTabFldENEx.ObjFieldTabENEx.InitValue_TypeScript);
                    }
                case clsPubConst.LangType.Swift:
                    return string.Format("internal var {0} : {1};     //{2} ",
                         objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName,
                         objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                case clsPubConst.LangType.Swift3:
                    return string.Format("internal var {0} : {1};     //{2} ",
                         objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName,
                         objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                case clsPubConst.LangType.Swift4:
                    return string.Format("internal var {0} : {1};     //{2} ",
                         objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName,
                         objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                case clsPubConst.LangType.VB:// "VB.NET":
                    return "protected " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.VbNetType + " " + objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName + ";" + "    //" + objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                default:
                    string strMsg = string.Format("语言类型：{0}在相应函数中没有被处理!({1})", ltLangType.ToString(), clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }



        /// <summary>
        /// 定义私有属性
        /// </summary>
        /// <param name = "ltLangType"></param>
        /// <param name = "objPrjTabFldENEx"></param>
        /// <returns></returns>
        public static string DefPrivateProperty_Sim(clsPubConst.LangType ltLangType, clsPrjTabFldENEx objPrjTabFldENEx)
        {
            switch (ltLangType)
            {
                case clsPubConst.LangType.CSharp:// "C#.NET":
                    return "private " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName + ";" + "    //" + objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                case clsPubConst.LangType.SilverLight:// "SilverLight":
                    return "private " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName + ";" + "    //" + objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                case clsPubConst.LangType.Swift:// "Swift":
                    return string.Format("internal var {0} : {1};     //{2} ",
                         objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName,
                         objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                case clsPubConst.LangType.Swift3:
                    return string.Format("internal var {0} : {1};     //{2} ",
                         objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName,
                         objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                case clsPubConst.LangType.Swift4:
                    return string.Format("internal var {0} : {1};     //{2} ",
                         objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                         objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                case clsPubConst.LangType.JAVA:
                    return "private " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType + " " + objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName + ";" + "    //" + objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                case clsPubConst.LangType.JavaScript:
                    return "private " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType + " " + objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName + ";" + "    //" + objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                case clsPubConst.LangType.VB:// "VB.NET":
                    return "private " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.VbNetType + " " + objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName + ";" + "    //" + objPrjTabFldENEx.ObjFieldTabENEx.Caption;
                default:
                    string strMsg = string.Format("语言类型：{0}在相应函数中没有被处理!({1})", ltLangType.ToString(), clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }

        }

        /// <summary>
        /// 定义类属性名称的常量,用于正确引用类属性名称
        /// </summary>
        /// <param name = "ltLangType"></param>
        /// <param name = "objPrjTabFldENEx"></param>
        /// <returns></returns>
        public static string DefPropertyNameConst(clsPubConst.LangType ltLangType, clsPrjTabFldENEx objPrjTabFldENEx, bool bolIsFstLcase, string strFuncName4GC)
        {
            StringBuilder strBuilder = new StringBuilder();
            switch (ltLangType)
            {
                case clsPubConst.LangType.CSharp:// "C#.NET":
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 常量:\"{0}\"", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n /// ({0})", strFuncName4GC);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n public const string con{0} = \"{1}\";" + "    //{2}",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                                              objPrjTabFldENEx.ObjFieldTabENEx.PropertyName(bolIsFstLcase),
                       objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    return strBuilder.ToString();
                case clsPubConst.LangType.TypeScript:// "C#.NET":
                    strBuilder.Append("\r\n /**"); 
                    strBuilder.AppendFormat("\r\n * 常量:\"{0}\"", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n * ({0})", strFuncName4GC);
                    strBuilder.Append("\r\n */");
                    //public static get abc(): string { return "abc"; };

                    strBuilder.AppendFormat("\r\n public static readonly con_{0} = \"{1}\";" + "    //{2}",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                                    objPrjTabFldENEx.ObjFieldTabENEx.PropertyName(bolIsFstLcase),
                       objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    return strBuilder.ToString();
                case clsPubConst.LangType.SilverLight:// "SilverLight":
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 常量:\"{0}\"", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n /// ({0})", strFuncName4GC);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n public const string con{0} = \"{0}\";" + "    //{1}",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                       objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    return strBuilder.ToString();
                case clsPubConst.LangType.JAVA:
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 常量:\"{0}\"", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n /// ({0})", strFuncName4GC);

                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n public static final String con{0} = \"{0}\";" + "    //{1}",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                       objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    return strBuilder.ToString();
                case clsPubConst.LangType.JavaScript:
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 常量:\"{0}\"", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n /// ({0})", strFuncName4GC);

                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n var con{0} = \"{0}\";" + "    //{1}",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                       objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    return strBuilder.ToString();
                case clsPubConst.LangType.Swift:
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 常量:\"{0}\"", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n /// ({0})", strFuncName4GC);

                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n public static var con{0} : String = \"{0}\";" + "    //{1}",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                       objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    return strBuilder.ToString();
                case clsPubConst.LangType.Swift3:
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 常量:\"{0}\"", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n /// ({0})", strFuncName4GC);

                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n public static var con{0} : String = \"{0}\";" + "    //{1}",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                       objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    return strBuilder.ToString();
                case clsPubConst.LangType.Swift4:
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 常量:\"{0}\"", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n /// ({0})", strFuncName4GC);

                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n public static var con{0} : String = \"{0}\";" + "    //{1}",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                       objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    return strBuilder.ToString();
                case clsPubConst.LangType.VB:// "VB.NET":
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 常量:\"{0}\"", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n /// ({0})", strFuncName4GC);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n public const string con{0} = \"{0}\";" + "    //{1}",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                       objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    return strBuilder.ToString();
                default:
                    string strMsg = string.Format("语言类型：{0}在相应函数中没有被处理!({1})", ltLangType.ToString(), clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }

        }

        /// <summary>
        /// 定义类属性名称的常量,用于正确引用类属性名称
        /// </summary>
        /// <param name = "ltLangType"></param>
        /// <param name = "objPrjTabFldENEx"></param>
        /// <returns></returns>
        public static string DefPropertyNameConst4ConstLevel(clsPubConst.LangType ltLangType, clsPrjTabFldENEx objPrjTabFldENEx)
        {
            StringBuilder strBuilder = new StringBuilder();
            switch (ltLangType)
            {
                case clsPubConst.LangType.CSharp:// "C#.NET":
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 常量:\"{0}\"", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n public const string {0} = \"{0}\";" + "    //{1}",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                       objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    return strBuilder.ToString();
                case clsPubConst.LangType.SilverLight:// "SilverLight":
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 常量:\"{0}\"", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n public const string {0} = \"{0}\";" + "    //{1}",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                       objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    return strBuilder.ToString();
                case clsPubConst.LangType.JAVA:
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 常量:\"{0}\"", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());

                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n public static final String {0} = \"{0}\";" + "    //{1}",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                       objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    return strBuilder.ToString();
                case clsPubConst.LangType.JavaScript:
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 常量:\"{0}\"", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());

                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n var con_{0} = \"{0}\";" + "    //{1}",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                       objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    return strBuilder.ToString();
                case clsPubConst.LangType.Swift:
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 常量:\"{0}\"", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());

                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n public static var {0} : String = \"{0}\";" + "    //{1}",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                       objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    return strBuilder.ToString();
                case clsPubConst.LangType.Swift3:
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 常量:\"{0}\"", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());

                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n public static var {0} : String = \"{0}\";" + "    //{1}",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                       objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    return strBuilder.ToString();
                case clsPubConst.LangType.Swift4:
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 常量:\"{0}\"", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());

                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n public static var {0} : String = \"{0}\";" + "    //{1}",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                       objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    return strBuilder.ToString();
                case clsPubConst.LangType.VB:// "VB.NET":
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// 常量:\"{0}\"", objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n public const string {0} = \"{0}\";" + "    //{1}",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                       objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    return strBuilder.ToString();
                default:
                    string strMsg = string.Format("语言类型：{0}在相应函数中没有被处理!({1})", ltLangType.ToString(), clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }

        }

        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_InitListCache)
        /// </summary>
        //public static void InitListCache(string strPrjId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clsPrjTabFldBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsPrjTabFldBL没有刷新缓存机制(clsPrjTabFldBL.objCommFun4BL == null), 请联系程序员！({0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    //初始化列表缓存
        //    if (strPrjIdCache_Init != strPrjId) arrPrjTabFldObjLstCache = null;
        //    string strWhereCond = string.Format("{0} = '{1}' order by mId", conPrjTabFld.PrjId, strPrjId);
        //    if (arrPrjTabFldObjLstCache == null)
        //    {
        //        arrPrjTabFldObjLstCache = clsPrjTabFldBL.GetObjLst(strWhereCond);

        //        strMsg = string.Format("初始化成功！strPrjId={0}，strPrjIdCache_Init={1}.({2})",
        //            strPrjId, strPrjIdCache_Init, clsStackTrace.GetCurrClassFunction());
        //        clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
        //        strPrjIdCache_Init = strPrjId;
        //    }
        //}

        /// <summary>
        /// 检查表是否有关键字字段相关对象, 从缓存的对象列表中获取.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetRecObjByKeyCache)
        /// </summary>
        /// <param name = "strTabId">所给的关键字</param>
        /// <param name = "strFieldTypeId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsPrjTabFldEN GetObjByTabIdAndFieldTypeIdCache(string strTabId, string strFieldTypeId, string strPrjId)
        {
            //初始化列表缓存
            List<clsPrjTabFldEN> arrObjLstCache = clsPrjTabFldBL.GetObjLstCache(strPrjId);

            IEnumerable<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel1 =
            from objPrjTabFldEN in arrObjLstCache
            where objPrjTabFldEN.TabId == strTabId
                && objPrjTabFldEN.FieldTypeId == strFieldTypeId
            select objPrjTabFldEN;
            List<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel = new List<clsPrjTabFldEN>();
            foreach (clsPrjTabFldEN obj in arrPrjTabFldObjLst_Sel1)
            {
                arrPrjTabFldObjLst_Sel.Add(obj);
            }
            if (arrPrjTabFldObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrPrjTabFldObjLst_Sel[0];
        }

        public static List<clsPrjTabFldEN> GetObjLstByTabIdAndFieldTypeIdCache(string strTabId, string strFieldTypeId, string strPrjId)
        {
            //初始化列表缓存
            List<clsPrjTabFldEN> arrObjLstCache = clsPrjTabFldBL.GetObjLstCache(strPrjId);
            var arrPrjTabFldObjLst_Sel = arrObjLstCache.Where(x => x.TabId == strTabId
                && x.FieldTypeId == strFieldTypeId).ToList();
            return arrPrjTabFldObjLst_Sel;
        }


        /// <summary>
        /// 根据[表Id(TabId)]获取相关对象子表, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strTabId">表Id</param>
        /// <returns>根据[表Id(TabId)]获取的相关对象子表</returns>
        public static List<clsPrjTabFldEN> GetObjSubLstByTabIdExCache(string strTabId, string strPrjId)
        {
            //if (strTabId.Substring(0, 4) != strPrjId)
            //{
            //    string strMsg = string.Format("(errid:BlEx000040)工程Id:[{0}],表Id:[{1}], 两者不相配,请检查!在({4}-{3}-{2})",
            //        strPrjId, strTabId,
            //        clsStackTrace.GetCurrClassFunctionByLevel(1),
            //        clsStackTrace.GetCurrClassFunctionByLevel(2),
            //        clsStackTrace.GetCurrClassFunctionByLevel(3));
            //    throw new Exception(strMsg);
            //}
            List<clsPrjTabFldEN> arrObjLstCache = clsPrjTabFldBL.GetObjLstCache(strPrjId);
            arrObjLstCache = arrObjLstCache.Where(x => x.TabId == strTabId).ToList();
            return arrObjLstCache.OrderBy(x => x.SequenceNumber).ToList();
        }

        public static List<clsPrjTabFldEN> GetObjLstByTabIdFieldTypeIdCache(string strTabId, string strFieldTypeId, string strPrjId)
        {
            //if (strTabId.Substring(0, 4) != strPrjId)
            //{
            //    string strMsg = string.Format("(errid:BlEx000040)工程Id:[{0}],表Id:[{1}], 两者不相配,请检查!在({4}-{3}-{2})",
            //        strPrjId, strTabId,
            //        clsStackTrace.GetCurrClassFunctionByLevel(1),
            //        clsStackTrace.GetCurrClassFunctionByLevel(2),
            //        clsStackTrace.GetCurrClassFunctionByLevel(3));
            //    throw new Exception(strMsg);
            //}
            List<clsPrjTabFldEN> arrObjLstCache = clsPrjTabFldBL.GetObjLstCache(strPrjId);
            arrObjLstCache = arrObjLstCache.Where(x => x.TabId == strTabId && x.FieldTypeId == strFieldTypeId).ToList();
            return arrObjLstCache.OrderBy(x => x.SequenceNumber).ToList();
        }


        public static List<clsPrjTabFldEN> GetObjSubLstByTabIdExCacheBak(string strTabId, string strPrjId)
        {

            List<clsPrjTabFldEN> arrObjLstCache = clsPrjTabFldBL.GetObjLstCache(strPrjId);
            var arrObj = new List<clsPrjTabFldEN>();
            var arrFldId = clsPrjTabFldBL.GetFldValue(conPrjTabFld.FldId, $"{conPrjTabFld.TabId}='{strTabId}'");
            foreach (string strFldId in arrFldId)
            {
                var obj = arrObjLstCache.Find(x => x.FldId == strFldId);
                if (obj == null)
                {
                    var objFieldTab = clsFieldTabBL.GetObjByFldId(strFldId);
                    string strMsg = $"在工程：{strPrjId}中没有字段:{objFieldTab.FldName}({strFldId}), 请检查！";
                    throw new Exception(strMsg);
                }
                arrObj.Add(obj);
            }
            return arrObj.OrderBy(x => x.SequenceNumber).ToList();
        }

        public static List<clsPrjTabFldENEx> GetObjExLstOrderBySequence(string strPrjId, string strTabId)
        {
            //try
            //{
            //    clsCommonRegular.CheckStrSQL_Weak(strCondition);
            //}
            //catch (Exception objException)
            //{
            //    throw new Exception(string.Format("在输入条件中含有{0}，请检查！", objException.Message));
            //}
            List<clsPrjTabFldEN> arrObjList = GetObjSubLstByTabIdExCache(strTabId, strPrjId);
            List<clsPrjTabFldENEx> arrObjExList = new List<clsPrjTabFldENEx>();
            foreach (clsPrjTabFldEN objPrjTabFldEN in arrObjList)
            {
                clsPrjTabFldENEx objPrjTabFldENEx = new clsPrjTabFldENEx();
                CopyTo(objPrjTabFldEN, objPrjTabFldENEx);

                arrObjExList.Add(objPrjTabFldENEx);
            }
            return arrObjExList;
        }




        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetRecObjByKeyCache)
        /// </summary>
        /// <param name = "strPrjId">strPrjId</param>
        /// <param name = "lngmId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsPrjTabFldEN GetObjBymIdExCache(string strPrjId, long lngmId)
        {
            //初始化列表缓存
            List<clsPrjTabFldEN> arrObjLstCache = clsPrjTabFldBL.GetObjLstCache(strPrjId);

            IEnumerable<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel1 =
            from objPrjTabFldEN in arrObjLstCache
            where objPrjTabFldEN.mId == lngmId
            select objPrjTabFldEN;

            if (arrPrjTabFldObjLst_Sel1.Count() == 0)
            {
                return null;
            }
            return arrPrjTabFldObjLst_Sel1.First();
        }

        public static clsPrjTabFldEN GetObjByTabIdAndFldIdCache(string strTabId, string strFldId, string strPrjId)
        {
            //初始化列表缓存
            List<clsPrjTabFldEN> arrObjLstCache = clsPrjTabFldBL.GetObjLstCache(strPrjId);

            IEnumerable<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel =
                arrObjLstCache.Where(x => x.FldId == strFldId && x.TabId == strTabId);
            if (arrPrjTabFldObjLst_Sel.Count() == 0)
            {
                return null;
            }
            return arrPrjTabFldObjLst_Sel.First();
        }

        public static bool IsExistByTabIdAndFldIdCache(string strTabId, string strFldId, string strPrjId)
        {
            //初始化列表缓存
            List<clsPrjTabFldEN> arrObjLstCache = clsPrjTabFldBL.GetObjLstCache(strPrjId);

            IEnumerable<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel =
                arrObjLstCache.Where(x => x.FldId == strFldId && x.TabId == strTabId);
            if (arrPrjTabFldObjLst_Sel.Count() == 0)
            {
                return false;
            }
            return true;
        }

        public static clsPrjTabFldEN GetObjByTabIdAndFldId(string strTabId, string strFldId)
        {

            var strCondition = string.Format("{0}='{1}' and {2}='{3}'", conPrjTabFld.TabId, strTabId,
                conPrjTabFld.FldId, strFldId);
            clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetFirstObj_S(strCondition);
            return objPrjTabFld;
        }

        /// <summary>
        /// 判断该字段是否是表中的扩展字段
        /// </summary>
        /// <param name="strTabId"></param>
        /// <param name="strFldId"></param>
        /// <returns></returns>
        public static bool IsForExtendClass1(string strTabId, string strFldId)
        {

            var strCondition = string.Format("{0}='{1}' and {2}='{3}'", conPrjTabFld.TabId, strTabId,
                conPrjTabFld.FldId, strFldId);
            clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetFirstObj_S(strCondition);
            if (objPrjTabFld == null) { 
                return false; 
            }
            return objPrjTabFld.IsForExtendClass;
        }

        public static bool IsForExtendClassCache(string strTabId, string strFldId,string strPrjId)
        {

            var strCondition = string.Format("{0}='{1}' and {2}='{3}'", conPrjTabFld.TabId, strTabId,
                conPrjTabFld.FldId, strFldId);
            var arr = clsPrjTabFldBL.GetObjLstCache(strPrjId);
            clsPrjTabFldEN objPrjTabFld = arr.Find(x=>x.TabId == strTabId && x.FldId == strFldId);
            if (objPrjTabFld == null)
            {
                return false;
            }
            return objPrjTabFld.IsForExtendClass;
        }

        public static List<clsPrjTabFldEN> GetObjLstByFldId(string strPrjId, string strFldId)
        {
            var strCondition = string.Format("{0}='{1}' and {2}='{3}'", conPrjTabFld.PrjId, strPrjId,
                conPrjTabFld.FldId, strFldId);
            List<clsPrjTabFldEN> arrPrjTabFld = clsPrjTabFldBL.GetObjLst(strCondition);
            return arrPrjTabFld;
        }

        /// <summary>
        /// 替换字段,在整个工程中替换字段
        /// </summary>
        /// <param name = "strSourceFldId">源字段Id</param>
        /// <param name = "strTargetFldId">目标字段Id</param>
        /// <returns></returns>
        public static DataTable GetvPrjTab4IncludeSouTarField(string strSourceFldId, string strTargetFldId)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strSQL;
            List<string> lstTabIdLst4SourceFld = objSQL.GetFldDataOfTable("PrjTabFld", "TabId", string.Format("FldId = '{0}'", strSourceFldId));
            List<string> lstTabIdLst4TargetFld = objSQL.GetFldDataOfTable("PrjTabFld", "TabId", string.Format("FldId = '{0}'", strTargetFldId));
            List<string> lstIntersect = com.taishsoft.common.clsAggregate.IntersectTwoAggr(lstTabIdLst4SourceFld, lstTabIdLst4TargetFld);
            if (lstIntersect.Count == 0) return null;
            string strCondition = clsArray.GetSqlInStrByArray(lstIntersect, true);
            strSQL = string.Format(" Select * from vPrjTab where TabId in ({0})", strCondition);
            DataTable objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }
        /// <summary>
        /// 根据表字段Id，PrjId获取相应的表字段对象扩展
        /// </summary>
        /// <param name="lngTabFldId">表字段Id</param>
        /// <param name="strPrjId"></param>
        /// <returns>相应的表字段对象扩展</returns>
        public static clsPrjTabFldENEx InitPrjTabFldB(long lngTabFldId, string strTabId)
        {
            //clsPrjTabFldEN objPrjTabFldEN = clsPrjTabFldBLEx.GetObjBymIdCacheEx(lngTabFldId, strPrjId);

            clsPrjTabFldENEx objPrjTabFldENEx = clsPrjTabFldBLEx.GetObjExObjBymIdB(lngTabFldId, strTabId);
            if (objPrjTabFldENEx == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("不存在相应的表字段ID,TabFldId = {0}", lngTabFldId);
                throw new clsDbObjException(sbMessage.ToString());
            }

            //objQryRegionFldsEx.objPrjTabFldENEx.arrFieldTabExObjLstBak = objQryRegionFldsEx.arrFieldTabExObjLstBak;
            objPrjTabFldENEx.ObjFieldTabENEx = clsFieldTabBLEx.InitFieldTab(objPrjTabFldENEx.FldId, objPrjTabFldENEx.PrjId);
            return objPrjTabFldENEx;
        }


        //public List<clsPrjTabFldENEx> arrFieldTabExObjLst = null;           //界面相关详细表字段集合

        public static List<clsPrjTabFldENEx> GetObjLstEx(string strCondition)
        {
            List<clsPrjTabFldENEx> arrObjList = new List<clsPrjTabFldENEx>();
            System.Data.DataTable objDT;
            objDT = clsPrjTabFldBL.GetDataTable_PrjTabFld(strCondition);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsPrjTabFldENEx objPrjTabFldEN = new clsPrjTabFldENEx();
                objPrjTabFldEN.mId = Int32.Parse(objRow["mId"].ToString().Trim());
                objPrjTabFldEN.TabId = objRow["TabId"].ToString().Trim();
                objPrjTabFldEN.FldId = objRow["FldId"].ToString().Trim();
                objPrjTabFldEN.PrjId = objRow["PrjId"].ToString().Trim();

                objPrjTabFldEN.IsTabNullable = bool.Parse(objRow["IsTabNullable"].ToString().Trim());
                objPrjTabFldEN.IsTabForeignKey = clsGeneralTab2.TransNullToBool_S(objRow["IsTabForeignKey"].ToString().Trim());
                objPrjTabFldEN.ForeignKeyTabId = objRow["ForeignKeyTabId"].ToString().Trim();
                objPrjTabFldEN.IsParentObj = clsGeneralTab2.TransNullToBool_S(objRow["IsParentObj"].ToString().Trim());
                objPrjTabFldEN.PrimaryTypeId = objRow["PrimaryTypeId"].ToString().Trim();
                objPrjTabFldEN.FldOpTypeId = objRow["FldOpTypeId"].ToString().Trim();

                objPrjTabFldEN.SequenceNumber = clsGeneralTab2.TransNullToInt_S(objRow["SequenceNumber"].ToString().Trim());
                objPrjTabFldEN.MemoInTab = objRow["MemoInTab"].ToString().Trim();
                objPrjTabFldEN.FieldTypeId = objRow["FieldTypeId"].ToString().Trim();
                arrObjList.Add(objPrjTabFldEN);
            }
            objDT = null;
            return arrObjList;
        }


        //public static bool IsExistSameFldId(string strTabId, string strFldId)
        //{
        //    StringBuilder strCondition = new StringBuilder();
        //    strCondition.AppendFormat("TabId = '{0}' and FldId = '{1}'", strTabId, strFldId);
        //    return IsExistCondRec("PrjTabFld", strCondition.ToString());
        //}


        public static clsPrjTabFldEN getTabFldObject(string strTabId, string strFldId)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("TabId = '{0}' and FldId = '{1}'", strTabId, strFldId);
            clsPrjTabFldEN objPrjTabFldEN = clsPrjTabFldBL.GetFirstObj_S(strCondition.ToString());
            return objPrjTabFldEN;
        }


        public static bool IsTabPrimaryF(string strTabId, string strFldId)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("TabId = '{0}' and FldId = '{1}' and {2}='{3}'", strTabId, strFldId, conPrjTabFld.FieldTypeId, enumFieldType.KeyField_02);
            return clsPrjTabFldBL.IsExistRecord(strCondition.ToString());
        }
        /// <summary>
        /// 功能:获取某一条件的DataTable,其中的代码转换成相应的名称
        /// </summary>
        /// <param name = "strCondition">条件串</param>
        /// <returns>返回已经转换代码的DataTable</returns>
        public static System.Data.DataTable GetPrjTabFldT1(string strCondition)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL.Append("Select * ");
            strSQL.Append(" from vPrjTabFld ");
            strSQL.Append(" where " + strCondition);
            strSQL.Append(" order by SequenceNumber ");
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }
        //public static bool DelRecordEx(string strTabId)
        //{
        //    List<string> arrLst = null;
        //    StringBuilder sbCondition = new StringBuilder();
        //    sbCondition.AppendFormat("TabId = '{0}'", strTabId);
        //    arrLst = clsPrjTabFldBL.GetPrimaryKeyID_S(sbCondition.ToString());
        //    if (arrLst  ==  null) return true;
        //    foreach (string strMid in arrLst)
        //    {
        //        long lngMid = long.Parse(strMid);
        //        DelRecordEx(lngMid);
        //    }
        //    return true;
        //}


        /// <summary>
        /// 强化删除工程表字段,
        /// </summary>
        /// <param name = "lngMId">工程表字段的关键字</param>
        /// <returns></returns>
        //public static bool DelRecordEx(long lngMId)
        //{
        //    //操作步骤:
        //    //1、获取当前序号的步骤序号；
        //    //2、删除当前记录
        //    //3、把后面的记录的步骤序号都减1；
        //    //4、返回TRUE；
        //    long intCurrSeqNum;
        //    string strCurrTabId;
        //    List<string> arrLst = null;
        //    //1、获取当前序号的步骤序号；
        //    arrLst = clsGeneralTab2.funGetFldValue("PrjTabFld", "SequenceNumber", "mId = " + lngMId.ToString());
        //    intCurrSeqNum = long.Parse(arrLst[0].ToString());
        //    //2、获取当前记录的表ID
        //    arrLst = clsGeneralTab2.funGetFldValue("PrjTabFld", "TabId", "mId = " + lngMId.ToString());
        //    strCurrTabId = arrLst[0].ToString();
        //    //2、删除当前记录
        //    clsEditRegionFldsBL.DelMultiRec("EditRegionFlds", "TabFldId = " + lngMId);
        //    clsDGRegionFldsBL.DelMultiRec("DGRegionFlds", "TabFldId = " + lngMId);
        //    clsQryRegionFldsBL.DelMultiRec("QryRegionFlds", "TabFldId = " + lngMId);
        //    clsListViewRegionFldsBL.DelMultiRec("ListViewRegionFlds", "TabFldId = " + lngMId);
        //    clsExcelExportRegionFldsBL.DelMultiRec("ExcelExportRegionFlds", "TabFldId = " + lngMId);

        //    DelRecord(lngMId);
        //    //3、把后面的记录的步骤序号都减1；
        //    string strSQL;
        //    clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
        //    //删除PrjTabFld本表中与当前对象有关的记录
        //    strSQL = "Update PrjTabFld set SequenceNumber = SequenceNumber - 1 where TabId = '" + strCurrTabId + "' and SequenceNumber > " + intCurrSeqNum;
        //    objSQL.ExecSql(strSQL);

        //    //4、返回TRUE；
        //    return true;
        //}


        /// <summary>
        /// 功能:获取当前表中的符合条件的某字段的值,以列表返回
        /// </summary>
        /// <param name = "strFldName">字段名</param>
        /// <param name = "strCondition">条件串</param>
        /// <returns>获取的字段值列表</returns>
        public ArrayList funGetFldValue2(string strFldName, string strCondition, string strOrderBy)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            ArrayList arrList = objSQL.GetFldDataOfTable2("PrjTabFld", strFldName, strCondition, strOrderBy);
            return arrList;
        }

        /// <summary>
        /// 功能:获取给定表中的符合条件的某字段的值,以列表返回
        /// </summary>
        /// <param name = "strTabName">表名</param>
        /// <param name = "strFldName">字段名</param>
        /// <param name = "strCondition">条件串</param>
        /// <returns>获取的字段值列表</returns>
        public static ArrayList funGetFldValue2(string strTabName, string strFldName, string strCondition, string strOrderBy)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            ArrayList arrList = objSQL.GetFldDataOfTable2(strTabName, strFldName, strCondition, strOrderBy);
            return arrList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objPrjTabFldENEx"></param>
        /// <param name="ltLangType"></param>
        /// <param name="bolIsSimVersion"></param>
        /// <returns></returns>
        public static string ToString2(clsPrjTabFldENEx objPrjTabFldENEx, clsPubConst.LangType ltLangType, bool bolIsSimVersion)
        {
            clsPubFun4BLEx.CheckDataType(objPrjTabFldENEx, ltLangType);
            //bool mbolIsReadOnly = false;
            //bool mbolIsWriteOnly = false;
            StringBuilder strCodeForCs = new StringBuilder();
            //string PropStr = "");
            switch (ltLangType)
            {
                case clsPubConst.LangType.CSharp:// "C#.NET":
                    //0000	未知	
                    //0001	可读写	
                    //0002	只读	
                    //0003	只写	
                    //0004	不可读写	
                    switch (objPrjTabFldENEx.FldOpTypeId)
                    {
                        case "0002"://只读
                            //if ( mbolIsReadOnly  ==  true)
                            //{
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                 objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.AppendFormat("\r\n/// </summary>");
                            if (bolIsSimVersion == true)
                            {
                                strCodeForCs.AppendFormat("\r\n    [DataMember]//非常重要");
                            }
                            strCodeForCs.AppendFormat("\r\npublic {0} {1}",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.Append("\r\nget");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nreturn {0};",
                                 objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// 设置值:{4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                 objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            strCodeForCs.AppendFormat("\r\npublic void Set{0}({1} {2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\n {1} = {0};",
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName,
                                 objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            if (bolIsSimVersion == false)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "//记录修改过的字段");
                                strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con_{0});",
                                    objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            }

                            strCodeForCs.Append("\r\n}");

                            break;
                        //}
                        //else if (mbolIsWriteOnly  ==  true)
                        //{
                        case "0003"://只写
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                 objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            if (bolIsSimVersion == true)
                            {
                                strCodeForCs.AppendFormat("\r\n    [DataMember]//非常重要");
                            }
                            strCodeForCs.AppendFormat("\r\npublic {0} {1}",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.Append("\r\nset");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\n {0} = value;",
                                 objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n" + "//记录修改过的字段");
                            strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con_{0});",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");

                            strCodeForCs.Append("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// 获取值:{4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.AppendFormat("\r\n/// </summary>");
                            strCodeForCs.AppendFormat("\r\npublic " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " Get{0}()",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\n return {0};", objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            break;
                        //}
                        //else
                        //{
                        case "0001"://可读写
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            //if (bolIsSimVersion == true)
                            //{
                            strCodeForCs.AppendFormat("\r\n  [DataMember]//非常重要");
                            //}
                            strCodeForCs.AppendFormat("\r\n public {0} {1}",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nget");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nreturn {0};", objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.AppendFormat("\r\nset");
                            strCodeForCs.Append("\r\n{");
                            if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                            {
                                strCodeForCs.AppendFormat("\r\nif (value  ==  \"\")");
                                strCodeForCs.Append("\r\n{");
                                if (bolIsSimVersion == false)
                                {
                                    strCodeForCs.AppendFormat("\r\nmintErrNo = 1;");
                                }
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                     objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                                strCodeForCs.Append("\r\n}");
                                strCodeForCs.AppendFormat("\r\nelse");
                                strCodeForCs.Append("\r\n{");
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                    objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                                strCodeForCs.Append("\r\n}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                     objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            }
                            if (bolIsSimVersion == false)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "//记录修改过的字段");
                                strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con_{0});",
                                    objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            }
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");
                            break;
                        case "0004":
                        case "0000":
                            break;
                        default:
                            break;
                    }
                    break;
                case clsPubConst.LangType.SilverLight:// "SilverLight":
                    //0000	未知	
                    //0001	可读写	
                    //0002	只读	
                    //0003	只写	
                    //0004	不可读写	
                    switch (objPrjTabFldENEx.FldOpTypeId)
                    {
                        case "0002"://只读
                            //if ( mbolIsReadOnly  ==  true)
                            //{
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                 objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.AppendFormat("\r\n/// </summary>");
                            //if (bolIsSimVersion == true)
                            //{
                            strCodeForCs.AppendFormat("\r\n    [DataMember]//非常重要");
                            //}
                            strCodeForCs.AppendFormat("\r\npublic {0} {1}",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.Append("\r\nget");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nreturn {0};",
                                 objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// 设置值:{4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                 objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            strCodeForCs.AppendFormat("\r\npublic void Set{0}({1} {2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\n {1} = {0};",
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName,
                                 objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            if (bolIsSimVersion == false)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "//记录修改过的字段");
                                strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con_{0});",
                                    objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            }

                            strCodeForCs.Append("\r\n}");

                            break;
                        //}
                        //else if (mbolIsWriteOnly  ==  true)
                        //{
                        case "0003"://只写
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                 objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            //if (bolIsSimVersion == true)
                            //{
                            strCodeForCs.AppendFormat("\r\n    [DataMember]//非常重要");
                            //}
                            strCodeForCs.AppendFormat("\r\npublic {0} {1}",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.Append("\r\nset");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\n {0} = value;",
                                 objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n" + "//记录修改过的字段");
                            strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con_{0});",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");

                            strCodeForCs.Append("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// 获取值:{4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.AppendFormat("\r\n/// </summary>");
                            strCodeForCs.AppendFormat("\r\npublic " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " Get{0}()",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\n return {0};", objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            break;
                        //}
                        //else
                        //{
                        case "0001"://可读写
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            //if (bolIsSimVersion == true)
                            //{
                            strCodeForCs.AppendFormat("\r\n  [DataMember]//非常重要");
                            //}
                            strCodeForCs.AppendFormat("\r\n public {0} {1}",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nget");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nreturn {0};", objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.AppendFormat("\r\nset");
                            strCodeForCs.Append("\r\n{");
                            if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                            {
                                strCodeForCs.AppendFormat("\r\nif (value  ==  \"\")");
                                strCodeForCs.Append("\r\n{");
                                if (bolIsSimVersion == false)
                                {
                                    strCodeForCs.AppendFormat("\r\nmintErrNo = 1;");
                                }
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                     objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                                strCodeForCs.Append("\r\n}");
                                strCodeForCs.AppendFormat("\r\nelse");
                                strCodeForCs.Append("\r\n{");
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                    objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                                strCodeForCs.Append("\r\n}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                     objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            }
                            if (bolIsSimVersion == false)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "//记录修改过的字段");
                                strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con_{0});",
                                    objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            }
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");
                            break;
                        case "0004":
                        case "0000":
                            break;
                        default:
                            break;
                    }
                    break;

                case clsPubConst.LangType.Swift:
                case clsPubConst.LangType.Swift3:
                case clsPubConst.LangType.Swift4:
                    //0000	未知	
                    //0001	可读写	
                    //0002	只读	
                    //0003	只写	
                    //0004	不可读写	
                    switch (objPrjTabFldENEx.FldOpTypeId)
                    {
                        case "0002"://只读
                            //if ( mbolIsReadOnly  ==  true)
                            //{
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                 objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.AppendFormat("\r\n/// </summary>");

                            strCodeForCs.AppendFormat("\r\npublic var {1} : {0}",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.Append("\r\nget");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nreturn {0};",
                                 objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// 设置值:{4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                 objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            strCodeForCs.AppendFormat("\r\npublic void Set{0}({1} {2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\n {1} = {0};",
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName,
                                 objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            if (bolIsSimVersion == false)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "//记录修改过的字段");
                                strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con_{0});",
                                    objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            }

                            strCodeForCs.Append("\r\n}");

                            break;
                        //}
                        //else if (mbolIsWriteOnly  ==  true)
                        //{
                        case "0003"://只写
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                 objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            //if (bolIsSimVersion == true)
                            //{
                            //    strCodeForCs.AppendFormat("\r\n    [DataMember]//非常重要");
                            //}
                            strCodeForCs.AppendFormat("\r\npublic var {1} : {0}",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.Append("\r\nset(value)");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\n {0} = value;",
                                 objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n" + "//记录修改过的字段");
                            strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con_{0});",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");

                            strCodeForCs.Append("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// 获取值:{4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.AppendFormat("\r\n/// </summary>");
                            strCodeForCs.AppendFormat("\r\npublic " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " Get{0}()",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\n return {0};", objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            break;
                        //}
                        //else
                        //{
                        case "0001"://可读写
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            //if (bolIsSimVersion == true)
                            //{
                            //    strCodeForCs.AppendFormat("\r\n  [DataMember]//非常重要");
                            //}
                            strCodeForCs.AppendFormat("\r\n public var {1} : {0} ",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nget");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nreturn {0};", objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.AppendFormat("\r\nset(value)");
                            strCodeForCs.Append("\r\n{");
                            if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType == "String")
                            {
                                strCodeForCs.AppendFormat("\r\nif (value  ==  \"\")");
                                strCodeForCs.Append("\r\n{");
                                if (bolIsSimVersion == false)
                                {
                                    strCodeForCs.AppendFormat("\r\nmintErrNo = 1;");
                                }
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                     objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                                strCodeForCs.Append("\r\n}");
                                strCodeForCs.AppendFormat("\r\nelse");
                                strCodeForCs.Append("\r\n{");
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                    objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                                strCodeForCs.Append("\r\n}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                     objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            }
                            if (bolIsSimVersion == false)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "//记录修改过的字段");
                                strCodeForCs.AppendFormat("\r\n    hmProperty[\"{0}\"] = \"true\";",
                                       objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            }
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");
                            break;
                        case "0004":
                        case "0000":
                            break;
                        default:
                            break;
                    }
                    break;

                case clsPubConst.LangType.JAVA:
                    strCodeForCs.AppendFormat("\r\n/// <summary>");
                    strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                        objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                        objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n/// </summary>");
                    strCodeForCs.AppendFormat("\r\n public {0} get{1}()",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\nreturn {0};",
                         objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                    strCodeForCs.Append("\r\n}");
                    strCodeForCs.AppendFormat("\r\n/// <summary>");
                    strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                        objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                        objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n/// </summary>");
                    strCodeForCs.AppendFormat("\r\n public void set{0}({1} value)",
                            objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                             objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
                    strCodeForCs.Append("\r\n{");
                    if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType == "String")
                    {
                        //strCodeForCs.AppendFormat("\r\nif (value  ==  \"\")");
                        //strCodeForCs.Append("\r\n{");
                        //if (bolIsSimVersion  ==  false)
                        //{
                        //    strCodeForCs.AppendFormat("\r\nmintErrNo = 1;");
                        //}
                        //strCodeForCs.Append("\r\n}");
                        //strCodeForCs.AppendFormat("\r\nelse");
                        //strCodeForCs.Append("\r\n{");
                        strCodeForCs.AppendFormat("\r\n {0} = value;",
                             objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                        strCodeForCs.AppendFormat("\r\n    hmProperty.put(\"{0}\", \"true\");",
                            objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                        //strCodeForCs.Append("\r\n}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n {0} = value;",
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                        strCodeForCs.AppendFormat("\r\n    hmProperty.put(\"{0}\", \"true\");",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    }

                    strCodeForCs.Append("\r\n}");
                    break;
                case clsPubConst.LangType.JavaScript:
                    strCodeForCs.AppendFormat("\r\n/// <summary>");
                    strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                        objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                        objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n/// </summary>");
                    strCodeForCs.AppendFormat("\r\n this.get{1} = function()",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\nreturn this.{0};",
                         objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n};");
                    strCodeForCs.AppendFormat("\r\n/// <summary>");
                    strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                        objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                        objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n/// </summary>");
                    strCodeForCs.AppendFormat("\r\n this.set{0} = function(value)",
                            objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                             objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
                    strCodeForCs.Append("\r\n{");
                    if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType == "String")
                    {
                        //strCodeForCs.AppendFormat("\r\nif (value  ==  \"\")");
                        //strCodeForCs.Append("\r\n{");
                        //if (bolIsSimVersion  ==  false)
                        //{
                        //    strCodeForCs.AppendFormat("\r\nmintErrNo = 1;");
                        //}
                        //strCodeForCs.Append("\r\n}");
                        //strCodeForCs.AppendFormat("\r\nelse");
                        //strCodeForCs.Append("\r\n{");
                        strCodeForCs.AppendFormat("\r\n this.{0} = value;",
                             objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n    this.hmProperty.add(\"{0}\", \"true\");",
                            objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                        //strCodeForCs.Append("\r\n}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n this.{0} = value;",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n    this.hmProperty.add(\"{0}\", \"true\");",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    }

                    strCodeForCs.Append("\r\n};");
                    break;

                case clsPubConst.LangType.TypeScript:
                    strCodeForCs.AppendFormat("\r\n/// <summary>");
                    strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                        objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                        objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n/// </summary>");
                    strCodeForCs.AppendFormat("\r\n public get {1} ()",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\nreturn this.{0};",
                         objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                    strCodeForCs.Append("\r\n};");
                    strCodeForCs.AppendFormat("\r\n/// <summary>");
                    strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                        objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                        objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n/// </summary>");
                    strCodeForCs.AppendFormat("\r\n public set {0} (value: {1})",
                            objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                             objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType);
                    strCodeForCs.Append("\r\n{");
                    if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "String")
                    {
                        //strCodeForCs.AppendFormat("\r\nif (value  ==  \"\")");
                        //strCodeForCs.Append("\r\n{");
                        //if (bolIsSimVersion  ==  false)
                        //{
                        //    strCodeForCs.AppendFormat("\r\nmintErrNo = 1;");
                        //}
                        //strCodeForCs.Append("\r\n}");
                        //strCodeForCs.AppendFormat("\r\nelse");
                        //strCodeForCs.Append("\r\n{");
                        strCodeForCs.AppendFormat("\r\n this.{0} = value;",
                             objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                        strCodeForCs.AppendFormat("\r\n    this.hmProperty[\"{0}\"] = true;",
                            objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                        //strCodeForCs.Append("\r\n}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n this.{0} = value;",
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                        strCodeForCs.AppendFormat("\r\n    this.hmProperty[\"{0}\"] = true;",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    }

                    strCodeForCs.Append("\r\n};");
                    break;

                case clsPubConst.LangType.VB:// "VB.NET":
                    break;
                default:

                    string strMsg = string.Format("语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
            return strCodeForCs.ToString();
        }

        public static string SetFieldTypeId(long lngmId, string strFieldTypeId, string strUpdUserId)
        {
            clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngmId);
            objPrjTabFld.SetFieldTypeId(strFieldTypeId)
                .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                .SetUpdUser(strUpdUserId);
            if (strFieldTypeId == enumFieldType.KeyField_02)
            {
                clsFieldTabEN objFieldTab = clsFieldTabBL.GetObjByFldId(objPrjTabFld.FldId);
                switch (objFieldTab.DataTypeId)
                {
                    case enumDataTypeAbbr.bigintidentity_26:
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.int_09:
                        objPrjTabFld.PrimaryTypeId = enumPrimaryType.Identity_02;
                        break;
                    case enumDataTypeAbbr.char_04:
                    case enumDataTypeAbbr.varchar_25:
                        objPrjTabFld.PrimaryTypeId = enumPrimaryType.StringAutoAddPrimaryKey_03;
                        break;
                }
                clsPrjTabFldBL.UpdateBySql2(objPrjTabFld);
                //clsPrjTabEN objPrjTabEN = new clsPrjTabEN(objPrjTabFld.TabId);
                //objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                //clsPrjTabBL.UpdateBySql2(objPrjTabEN);

                clsPrjTabBLEx.SetKeyFld4PrjTabByTabId(objPrjTabFld.TabId, strUpdUserId);

            }
            else
            {
                clsPrjTabFldBL.UpdateBySql2(objPrjTabFld);
                clsPrjTabBLEx.SetUpdDate(objPrjTabFld.TabId, strUpdUserId);
            }
            return objPrjTabFld.FldId;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objPrjTabFldENEx"></param>
        /// <param name="ltLangType"></param>
        /// <returns></returns>
        public static string ToStringV2(clsPrjTabFldENEx objPrjTabFldENEx, bool bolIsFstLcase, clsPubConst.LangType ltLangType, string strTabName)
        {
            clsPubFun4BLEx.CheckDataType(objPrjTabFldENEx, ltLangType);
            var strIsNeedQuestion = "";
            if (objPrjTabFldENEx.IsNumberType() == true && objPrjTabFldENEx.IsTabNullable == true) strIsNeedQuestion = "?";
            //bool mbolIsReadOnly = false;
            //bool mbolIsWriteOnly = false;
            StringBuilder strCodeForCs = new StringBuilder();
            //string PropStr = "");
            switch (ltLangType)
            {
                case clsPubConst.LangType.CSharp:// "C#.NET":
                    //0000	未知	
                    //0001	可读写	
                    //0002	只读	
                    //0003	只写	
                    //0004	不可读写	
                    switch (objPrjTabFldENEx.FldOpTypeId)
                    {
                        case "0002"://只读
                            //if ( mbolIsReadOnly  ==  true)
                            //{
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                 objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.AppendFormat("\r\n/// </summary>");

                            strCodeForCs.AppendFormat("\r\n    [DataMember]//非常重要");

                            strCodeForCs.AppendFormat("\r\npublic {0}{2} {1}",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName, strIsNeedQuestion);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.Append("\r\nget;");
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// 设置值:{4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                 objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            strCodeForCs.AppendFormat("\r\npublic void Set{0}({1} {2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\n {1} = {0};",
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName,
                                 objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);

                            strCodeForCs.AppendFormat("\r\n" + "//记录修改过的字段");
                            strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con{0}.{1});",
                                strTabName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName);


                            strCodeForCs.Append("\r\n}");

                            break;
                        //}
                        //else if (mbolIsWriteOnly  ==  true)
                        //{
                        case "0003"://只写
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                 objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");

                            strCodeForCs.AppendFormat("\r\n    [DataMember]//非常重要");

                            strCodeForCs.AppendFormat("\r\npublic {0}{2} {1}",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName, strIsNeedQuestion);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.Append("\r\nset");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\n {0} = value;",
                                 objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n" + "//记录修改过的字段");
                            strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con{0}.{1});",
                                strTabName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");

                            strCodeForCs.Append("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// 获取值:{4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.AppendFormat("\r\n/// </summary>");
                            strCodeForCs.AppendFormat("\r\npublic " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " Get{0}()",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\n return {0};", objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            break;
                        //}
                        //else
                        //{
                        case "0001"://可读写
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            //if (bolIsSimVersion == true)
                            //{
                            strCodeForCs.AppendFormat("\r\n  [DataMember]//非常重要");
                            //}
                            strCodeForCs.AppendFormat("\r\n public {0}{2} {1}",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.PropertyName(bolIsFstLcase), strIsNeedQuestion);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nget");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nreturn {0};", objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.AppendFormat("\r\nset");
                            strCodeForCs.Append("\r\n{");
                            if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                            {
                                strCodeForCs.AppendFormat("\r\nif (value  ==  \"\")");
                                strCodeForCs.Append("\r\n{");

                                strCodeForCs.AppendFormat("\r\nmintErrNo = 1;");

                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                     objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                                strCodeForCs.Append("\r\n}");
                                strCodeForCs.AppendFormat("\r\nelse");
                                strCodeForCs.Append("\r\n{");
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                    objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                                strCodeForCs.Append("\r\n}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                     objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            }

                            strCodeForCs.AppendFormat("\r\n" + "//记录修改过的字段");
                            strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con{0}.{1});",
                                strTabName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName);

                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");
                            break;
                        case "0004":
                        case "0000":
                            break;
                        default:
                            break;
                    }
                    break;
                case clsPubConst.LangType.SilverLight:// "SilverLight":
                    //0000	未知	
                    //0001	可读写	
                    //0002	只读	
                    //0003	只写	
                    //0004	不可读写	
                    switch (objPrjTabFldENEx.FldOpTypeId)
                    {
                        case "0002"://只读
                            //if ( mbolIsReadOnly  ==  true)
                            //{
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                 objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.AppendFormat("\r\n/// </summary>");
                            //if (bolIsSimVersion == true)
                            //{
                            strCodeForCs.AppendFormat("\r\n    [DataMember]//非常重要");
                            //}
                            strCodeForCs.AppendFormat("\r\npublic {0} {1}",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.Append("\r\nget");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nreturn {0};",
                                 objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// 设置值:{4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                 objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            strCodeForCs.AppendFormat("\r\npublic void Set{0}({1} {2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\n {1} = {0};",
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName,
                                 objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);

                            strCodeForCs.AppendFormat("\r\n" + "//记录修改过的字段");
                            strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con{0}.{1});",
                                strTabName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName);

                            strCodeForCs.Append("\r\n}");

                            break;
                        //}
                        //else if (mbolIsWriteOnly  ==  true)
                        //{
                        case "0003"://只写
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                 objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            //if (bolIsSimVersion == true)
                            //{
                            strCodeForCs.AppendFormat("\r\n    [DataMember]//非常重要");
                            //}
                            strCodeForCs.AppendFormat("\r\npublic {0} {1}",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.Append("\r\nset");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\n {0} = value;",
                                 objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n" + "//记录修改过的字段");
                            strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con{0}.{1});",
                                strTabName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");

                            strCodeForCs.Append("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// 获取值:{4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.AppendFormat("\r\n/// </summary>");
                            strCodeForCs.AppendFormat("\r\npublic " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " Get{0}()",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\n return {0};", objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            break;
                        //}
                        //else
                        //{
                        case "0001"://可读写
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            //if (bolIsSimVersion == true)
                            //{
                            strCodeForCs.AppendFormat("\r\n  [DataMember]//非常重要");
                            //}
                            strCodeForCs.AppendFormat("\r\n public {0} {1}",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nget");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nreturn {0};", objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.AppendFormat("\r\nset");
                            strCodeForCs.Append("\r\n{");
                            if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                            {
                                strCodeForCs.AppendFormat("\r\nif (value  ==  \"\")");
                                strCodeForCs.Append("\r\n{");

                                strCodeForCs.AppendFormat("\r\nmintErrNo = 1;");

                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                     objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                                strCodeForCs.Append("\r\n}");
                                strCodeForCs.AppendFormat("\r\nelse");
                                strCodeForCs.Append("\r\n{");
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                    objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                                strCodeForCs.Append("\r\n}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                     objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            }

                            strCodeForCs.AppendFormat("\r\n" + "//记录修改过的字段");
                            strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con{0}.{1});",
                                strTabName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName);

                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");
                            break;
                        case "0004":
                        case "0000":
                            break;
                        default:
                            break;
                    }
                    break;

                case clsPubConst.LangType.Swift:
                case clsPubConst.LangType.Swift3:
                case clsPubConst.LangType.Swift4:
                    //0000	未知	
                    //0001	可读写	
                    //0002	只读	
                    //0003	只写	
                    //0004	不可读写	
                    switch (objPrjTabFldENEx.FldOpTypeId)
                    {
                        case "0002"://只读
                            //if ( mbolIsReadOnly  ==  true)
                            //{
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                 objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.AppendFormat("\r\n/// </summary>");

                            strCodeForCs.AppendFormat("\r\npublic var {1} : {0}",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.Append("\r\nget");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nreturn {0};",
                                 objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// 设置值:{4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                 objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            strCodeForCs.AppendFormat("\r\npublic void Set{0}({1} {2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\n {1} = {0};",
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName,
                                 objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);

                            strCodeForCs.AppendFormat("\r\n" + "//记录修改过的字段");
                            strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con{0}.{1});",
                                strTabName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName);

                            strCodeForCs.Append("\r\n}");

                            break;
                        //}
                        //else if (mbolIsWriteOnly  ==  true)
                        //{
                        case "0003"://只写
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                 objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            //if (bolIsSimVersion == true)
                            //{
                            //    strCodeForCs.AppendFormat("\r\n    [DataMember]//非常重要");
                            //}
                            strCodeForCs.AppendFormat("\r\npublic var {1} : {0}",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.Append("\r\nset(value)");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\n {0} = value;",
                                 objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n" + "//记录修改过的字段");
                            strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con{0}.{1});",
                                strTabName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");

                            strCodeForCs.Append("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// 获取值:{4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.AppendFormat("\r\n/// </summary>");
                            strCodeForCs.AppendFormat("\r\npublic " + objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " Get{0}()",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivFuncName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\n return {0};", objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            break;
                        //}
                        //else
                        //{
                        case "0001"://可读写
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            //if (bolIsSimVersion == true)
                            //{
                            //    strCodeForCs.AppendFormat("\r\n  [DataMember]//非常重要");
                            //}
                            strCodeForCs.AppendFormat("\r\n public var {1} : {0} ",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nget");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nreturn {0};", objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.AppendFormat("\r\nset(value)");
                            strCodeForCs.Append("\r\n{");
                            if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType == "String")
                            {
                                strCodeForCs.AppendFormat("\r\nif (value  ==  \"\")");
                                strCodeForCs.Append("\r\n{");

                                strCodeForCs.AppendFormat("\r\nmintErrNo = 1;");

                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                     objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                                strCodeForCs.Append("\r\n}");
                                strCodeForCs.AppendFormat("\r\nelse");
                                strCodeForCs.Append("\r\n{");
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                    objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                                strCodeForCs.Append("\r\n}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                     objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            }

                            strCodeForCs.AppendFormat("\r\n" + "//记录修改过的字段");
                            strCodeForCs.AppendFormat("\r\n    hmProperty[\"{0}\"] = \"true\";",
                                   objPrjTabFldENEx.ObjFieldTabENEx.FldName);

                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");
                            break;
                        case "0004":
                        case "0000":
                            break;
                        default:
                            break;
                    }
                    break;

                case clsPubConst.LangType.JAVA:
                    strCodeForCs.AppendFormat("\r\n/// <summary>");
                    strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                        objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                        objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n/// </summary>");
                    strCodeForCs.AppendFormat("\r\n public {0} get{1}()",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\nreturn {0};",
                         objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                    strCodeForCs.Append("\r\n}");
                    strCodeForCs.AppendFormat("\r\n/// <summary>");
                    strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                        objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                        objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n/// </summary>");
                    strCodeForCs.AppendFormat("\r\n public void set{0}({1} value)",
                            objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                             objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
                    strCodeForCs.Append("\r\n{");
                    if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType == "String")
                    {
                        //strCodeForCs.AppendFormat("\r\nif (value  ==  \"\")");
                        //strCodeForCs.Append("\r\n{");
                        //if (bolIsSimVersion  ==  false)
                        //{
                        //    strCodeForCs.AppendFormat("\r\nmintErrNo = 1;");
                        //}
                        //strCodeForCs.Append("\r\n}");
                        //strCodeForCs.AppendFormat("\r\nelse");
                        //strCodeForCs.Append("\r\n{");
                        strCodeForCs.AppendFormat("\r\n {0} = value;",
                             objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                        strCodeForCs.AppendFormat("\r\n    hmProperty.put(\"{0}\", \"true\");",
                            objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                        //strCodeForCs.Append("\r\n}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n {0} = value;",
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                        strCodeForCs.AppendFormat("\r\n    hmProperty.put(\"{0}\", \"true\");",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    }

                    strCodeForCs.Append("\r\n}");
                    break;
                case clsPubConst.LangType.JavaScript:
                    strCodeForCs.AppendFormat("\r\n/// <summary>");
                    strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                        objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                        objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n/// </summary>");
                    strCodeForCs.AppendFormat("\r\n this.get{1} = function()",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\nreturn this.{0};",
                         objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n};");
                    strCodeForCs.AppendFormat("\r\n/// <summary>");
                    strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                        objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                        objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n/// </summary>");
                    strCodeForCs.AppendFormat("\r\n this.set{0} = function(value)",
                            objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                             objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
                    strCodeForCs.Append("\r\n{");
                    if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType == "String")
                    {
                        //strCodeForCs.AppendFormat("\r\nif (value  ==  \"\")");
                        //strCodeForCs.Append("\r\n{");
                        //if (bolIsSimVersion  ==  false)
                        //{
                        //    strCodeForCs.AppendFormat("\r\nmintErrNo = 1;");
                        //}
                        //strCodeForCs.Append("\r\n}");
                        //strCodeForCs.AppendFormat("\r\nelse");
                        //strCodeForCs.Append("\r\n{");
                        strCodeForCs.AppendFormat("\r\n this.{0} = value;",
                             objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n    this.hmProperty.add(\"{0}\", \"true\");",
                            objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                        //strCodeForCs.Append("\r\n}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n this.{0} = value;",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n    this.hmProperty.add(\"{0}\", \"true\");",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    }

                    strCodeForCs.Append("\r\n};");
                    break;

                case clsPubConst.LangType.VB:// "VB.NET":
                    break;
                default:

                    string strMsg = string.Format("语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
            return strCodeForCs.ToString();
        }


        public static string ToString4PureClass(clsPrjTabFldENEx objPrjTabFldENEx, clsPubConst.LangType ltLangType)
        {
            clsPubFun4BLEx.CheckDataType(objPrjTabFldENEx, ltLangType);
            //bool mbolIsReadOnly = false;
            //bool mbolIsWriteOnly = false;
            StringBuilder strCodeForCs = new StringBuilder();
            //string PropStr = "");
            switch (ltLangType)
            {
                case clsPubConst.LangType.CSharp:// "C#.NET":
                    //0000	未知	
                    //0001	可读写	
                    //0002	只读	
                    //0003	只写	
                    //0004	不可读写	
                    switch (objPrjTabFldENEx.FldOpTypeId)
                    {

                        case "0001"://可读写
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            //if (bolIsSimVersion == true)
                            //{
                            strCodeForCs.AppendFormat("\r\n  [DataMember]//非常重要");
                            //}
                            strCodeForCs.AppendFormat("\r\n public {0} {1}",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nget");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nreturn {0};", objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.AppendFormat("\r\nset");
                            strCodeForCs.Append("\r\n{");
                            if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                            {
                                strCodeForCs.AppendFormat("\r\nif (value  ==  \"\")");
                                strCodeForCs.Append("\r\n{");

                                //strCodeForCs.AppendFormat("\r\nmintErrNo = 1;");

                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                     objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                                strCodeForCs.Append("\r\n}");
                                strCodeForCs.AppendFormat("\r\nelse");
                                strCodeForCs.Append("\r\n{");
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                    objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                                strCodeForCs.Append("\r\n}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                     objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            }

                            //strCodeForCs.AppendFormat("\r\n" + "//记录修改过的字段");
                            //strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con_{0});",
                            //    objPrjTabFldENEx.ObjFieldTabENEx.FldName);

                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");
                            break;
                        case "0004":
                        case "0000":
                            break;
                        default:
                            break;
                    }
                    break;
                case clsPubConst.LangType.SilverLight:// "SilverLight":
                    //0000	未知	
                    //0001	可读写	
                    //0002	只读	
                    //0003	只写	
                    //0004	不可读写	
                    switch (objPrjTabFldENEx.FldOpTypeId)
                    {

                        case "0001"://可读写
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            //if (bolIsSimVersion == true)
                            //{
                            strCodeForCs.AppendFormat("\r\n  [DataMember]//非常重要");
                            //}
                            strCodeForCs.AppendFormat("\r\n public {0} {1}",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nget");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nreturn {0};", objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.AppendFormat("\r\nset");
                            strCodeForCs.Append("\r\n{");
                            if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                            {
                                strCodeForCs.AppendFormat("\r\nif (value  ==  \"\")");
                                strCodeForCs.Append("\r\n{");

                                strCodeForCs.AppendFormat("\r\nmintErrNo = 1;");

                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                     objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                                strCodeForCs.Append("\r\n}");
                                strCodeForCs.AppendFormat("\r\nelse");
                                strCodeForCs.Append("\r\n{");
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                    objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                                strCodeForCs.Append("\r\n}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                     objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            }

                            strCodeForCs.AppendFormat("\r\n" + "//记录修改过的字段");
                            strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con_{0});",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName);

                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");
                            break;
                        case "0004":
                        case "0000":
                            break;
                        default:
                            break;
                    }
                    break;

                case clsPubConst.LangType.Swift:
                case clsPubConst.LangType.Swift3:
                case clsPubConst.LangType.Swift4:
                    //0000	未知	
                    //0001	可读写	
                    //0002	只读	
                    //0003	只写	
                    //0004	不可读写	
                    switch (objPrjTabFldENEx.FldOpTypeId)
                    {

                        case "0001"://可读写
                            strCodeForCs.AppendFormat("/// <summary>");
                            strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                                objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                                objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                                objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                                objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                            strCodeForCs.Append("\r\n/// </summary>");
                            //if (bolIsSimVersion == true)
                            //{
                            //    strCodeForCs.AppendFormat("\r\n  [DataMember]//非常重要");
                            //}
                            strCodeForCs.AppendFormat("\r\n public var {1} : {0} ",
                                 objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType,
                                 objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nget");
                            strCodeForCs.Append("\r\n{");
                            strCodeForCs.AppendFormat("\r\nreturn {0};", objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.AppendFormat("\r\nset(value)");
                            strCodeForCs.Append("\r\n{");
                            if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType == "String")
                            {
                                strCodeForCs.AppendFormat("\r\nif (value  ==  \"\")");
                                strCodeForCs.Append("\r\n{");

                                strCodeForCs.AppendFormat("\r\nmintErrNo = 1;");

                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                     objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                                strCodeForCs.Append("\r\n}");
                                strCodeForCs.AppendFormat("\r\nelse");
                                strCodeForCs.Append("\r\n{");
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                    objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                                strCodeForCs.Append("\r\n}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n {0} = value;",
                                     objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                            }

                            strCodeForCs.AppendFormat("\r\n" + "//记录修改过的字段");
                            strCodeForCs.AppendFormat("\r\n    hmProperty[\"{0}\"] = \"true\";",
                                   objPrjTabFldENEx.ObjFieldTabENEx.FldName);

                            strCodeForCs.Append("\r\n}");
                            strCodeForCs.Append("\r\n}");
                            break;
                        case "0004":
                        case "0000":
                            break;
                        default:
                            break;
                    }
                    break;

                case clsPubConst.LangType.JAVA:
                    strCodeForCs.AppendFormat("\r\n/// <summary>");
                    strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                        objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                        objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n/// </summary>");
                    strCodeForCs.AppendFormat("\r\n public {0} get{1}()",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\nreturn {0};",
                         objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                    strCodeForCs.Append("\r\n}");
                    strCodeForCs.AppendFormat("\r\n/// <summary>");
                    strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                        objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                        objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n/// </summary>");
                    strCodeForCs.AppendFormat("\r\n public void set{0}({1} value)",
                            objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                             objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
                    strCodeForCs.Append("\r\n{");
                    if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType == "String")
                    {
                        //strCodeForCs.AppendFormat("\r\nif (value  ==  \"\")");
                        //strCodeForCs.Append("\r\n{");
                        //if (bolIsSimVersion  ==  false)
                        //{
                        //    strCodeForCs.AppendFormat("\r\nmintErrNo = 1;");
                        //}
                        //strCodeForCs.Append("\r\n}");
                        //strCodeForCs.AppendFormat("\r\nelse");
                        //strCodeForCs.Append("\r\n{");
                        strCodeForCs.AppendFormat("\r\n {0} = value;",
                             objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                        strCodeForCs.AppendFormat("\r\n    hmProperty.put(\"{0}\", \"true\");",
                            objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                        //strCodeForCs.Append("\r\n}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n {0} = value;",
                                objPrjTabFldENEx.ObjFieldTabENEx.PrivPropName);
                        strCodeForCs.AppendFormat("\r\n    hmProperty.put(\"{0}\", \"true\");",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    }

                    strCodeForCs.Append("\r\n}");
                    break;
                case clsPubConst.LangType.JavaScript:
                    strCodeForCs.AppendFormat("\r\n/// <summary>");
                    strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                        objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                        objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n/// </summary>");
                    strCodeForCs.AppendFormat("\r\n this.get{1} = function()",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\nreturn this.{0};",
                         objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n};");
                    strCodeForCs.AppendFormat("\r\n/// <summary>");
                    strCodeForCs.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                        objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objPrjTabFldENEx.ObjFieldTabENEx.FldLength,
                        objPrjTabFldENEx.ObjFieldTabENEx.IsNull,
                        objPrjTabFldENEx.ObjFieldTabENEx.MemoInTab,
                         objPrjTabFldENEx.ObjFieldTabENEx.Caption);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n/// </summary>");
                    strCodeForCs.AppendFormat("\r\n this.set{0} = function(value)",
                            objPrjTabFldENEx.ObjFieldTabENEx.FldName,
                             objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType);
                    strCodeForCs.Append("\r\n{");
                    if (objPrjTabFldENEx.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType == "String")
                    {
                        //strCodeForCs.AppendFormat("\r\nif (value  ==  \"\")");
                        //strCodeForCs.Append("\r\n{");
                        //if (bolIsSimVersion  ==  false)
                        //{
                        //    strCodeForCs.AppendFormat("\r\nmintErrNo = 1;");
                        //}
                        //strCodeForCs.Append("\r\n}");
                        //strCodeForCs.AppendFormat("\r\nelse");
                        //strCodeForCs.Append("\r\n{");
                        strCodeForCs.AppendFormat("\r\n this.{0} = value;",
                             objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n    this.hmProperty.add(\"{0}\", \"true\");",
                            objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                        //strCodeForCs.Append("\r\n}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n this.{0} = value;",
                                objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                        strCodeForCs.AppendFormat("\r\n    this.hmProperty.add(\"{0}\", \"true\");",
                       objPrjTabFldENEx.ObjFieldTabENEx.FldName);
                    }

                    strCodeForCs.Append("\r\n};");
                    break;

                case clsPubConst.LangType.VB:// "VB.NET":
                    break;
                default:

                    string strMsg = string.Format("语言类型：{0}在相应函数中没有被处理!({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

            }
            return strCodeForCs.ToString();
        }


        public static bool AddColumn_SourceTabName(ref System.Data.DataTable objDT)
        {
            objDT.Columns.Add("SourceTabName");
            foreach (DataRow objDR in objDT.Rows)
            {
                string strPrjId = objDR[convPrjTabFld.PrjId].ToString();
                //string 1strFldID = objDR[convPrjTabFld.FldId].ToString();
                string strFldName = objDR[convPrjTabFld.FldName].ToString();
                string strTabId = objDR[convPrjTabFld.TabId].ToString();
                try
                {
                    clsvSqlViewFldEN objvSqlViewFldEN = clsvSqlViewFldBLEx.GetvSqlViewFldObjByTabIdFieldAliasesExCache(strPrjId, strTabId, strFldName);
                    if (objvSqlViewFldEN == null)
                    {
                        objvSqlViewFldEN = clsvSqlViewFldBLEx.GetvSqlViewFldObjByTabIdFldNameExCache(strPrjId, strTabId, strFldName);

                    }
                    if (objvSqlViewFldEN != null)
                    {
                        objDR["SourceTabName"] = objvSqlViewFldEN.TabName;
                    }
                }
                catch (Exception objException)
                {
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(objException.Message);
                }
            }

            return true;
        }
        /// <summary>
        /// 为字段设置一个新标题
        /// </summary>
        /// <param name="lngmId"></param>
        /// <param name="strCaption"></param>
        /// <param name="strOpUser"></param>
        /// <returns></returns>
        public static string SetNewCaption(long lngmId, string strCaption, string strOpUser)
        {
            if (lngmId == 0) return "";
            if (string.IsNullOrEmpty(strCaption) == true)
            {
                var strMsg = "请输入一个新的标题!";
                throw new Exception(strMsg);

            }

            clsPrjTabFldEN objPrjTabFldEN = clsPrjTabFldBL.GetObjBymId(lngmId);
            clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(objPrjTabFldEN.FldId);
            try
            {
                objFieldTabEN.SetCaption(strCaption)
                    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    .SetUpdUser(strOpUser)
                    .Update();
                clsPrjTabBLEx.SetUpdDate(objPrjTabFldEN.TabId);
                return objPrjTabFldEN.FldId;
            }
            catch (Exception objException)
            {
                var strMsg = string.Format("设置新标题出错.错误:{0}.(in {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            //return false;
        }

        /// <summary>
        /// 为表字段替换一个新的字段
        /// </summary>
        /// <param name="lngmId"></param>
        /// <param name="strFldName"></param>
        /// <param name="strOpUser"></param>
        /// <returns></returns>
        public static string ReplaceFldName(long lngmId, string strFldName, string strOpUser)
        {
            if (lngmId == 0) return "";

            if (string.IsNullOrEmpty(strFldName) == true)
            {
                var strMsg = "请输入一个新的字段名!";
                throw new Exception(strMsg);
            }

            clsPrjTabFldEN objPrjTabFldEN = clsPrjTabFldBL.GetObjBymId(lngmId);
            if (objPrjTabFldEN != null) clsPrjTabBLEx.SetUpdDate(objPrjTabFldEN.TabId);
            clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(objPrjTabFldEN.FldId);
            if (objFieldTabEN.FldName == strFldName)
            {
                var strMsg = "请输入一个新的字段名!";
                throw new Exception(strMsg);
            }
            string strCondition = string.Format("{0}='{1}' and {2}='{3}'",
                conFieldTab.FldName, strFldName, conFieldTab.PrjId, objFieldTabEN.PrjId);
            try
            {
                List<clsFieldTabEN> arrFieldTabObjLst = clsFieldTabBL.GetObjLst(strCondition);
                if (arrFieldTabObjLst.Count == 0)
                {
                    objFieldTabEN.FldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(objFieldTabEN.PrjId);
                    objFieldTabEN.SetFldName(strFldName)
                        .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetUpdUser(strOpUser)
                        .AddRecordEx();

                    objPrjTabFldEN.SetFldId(objFieldTabEN.FldId)
                        .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetUpdUser(strOpUser)
                        .Update();
                    return objFieldTabEN.FldId;

                }
                else if (arrFieldTabObjLst.Count == 1)
                {

                    objFieldTabEN = arrFieldTabObjLst[0];
                    objPrjTabFldEN.SetFldId(objFieldTabEN.FldId)
                        .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetUpdUser(strOpUser)
                        .Update();
                    return objFieldTabEN.FldId;
                }
                else
                {
                    clsFieldTabEN objFieldTabEN_New = arrFieldTabObjLst.Find(x => x.DataTypeId == objFieldTabEN.DataTypeId);
                    if (objFieldTabEN_New == null)
                    {
                        objFieldTabEN_New = arrFieldTabObjLst[0];
                    }
                    objPrjTabFldEN.SetFldId(objFieldTabEN_New.FldId)
                        .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                        .SetUpdUser(strOpUser)
                        .Update();
                    return objFieldTabEN_New.FldId;
                }
      
            }
            catch (Exception objException)
            {
                var strMsg = string.Format("替换新字段时出错.错误:{0}.(in {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 把记录移到新的位置
        /// </summary>
        /// <param name="lngMid">关键字</param>
        /// <param name="intNewSeqNum">新的序号</param>
        /// <param name="strTabId">表Id</param>
        /// <param name="strOpUser">修改用户</param>
        /// <returns></returns>
        public static bool MoveRecTo(long lngMid, int intNewSeqNum, string strTabId, string strOpUser)
        {

            //1、显示该关键字的数据让用户修改该关键字记录；
            clsPrjTabFldEN objPrjTabFldEN = clsPrjTabFldBL.GetObjBymId(lngMid);
            objPrjTabFldEN.SetSequenceNumber(intNewSeqNum).
                   SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                   .SetUpdUser(strOpUser)
                   .Update();

            clsPrjTabFldBL.ReOrder(strTabId);
            clsPrjTabBLEx.SetUpdDate(strTabId);
            return true;

        }
        /// <summary>
        /// 复制一些字段到其他表,并同步到数据库
        /// </summary>
        /// <param name="lstMId"></param>
        /// <param name="strTabId"></param>
        /// <param name="strPrjId"></param>
        /// <param name="strCurrPrjDataBaseId"></param>
        /// <param name="strOpUser"></param>
        /// <returns></returns>
        public static bool CopyToPrjTab(List<string> arrMId, string strTabId, string strPrjId, string strCurrPrjDataBaseId, string strOpUser)
        {
            string strMsg;
            if (string.IsNullOrEmpty(strTabId))
            {
                strMsg = "请选择复制到的工程表!";
                throw new Exception(strMsg);
            }
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            foreach (string strMid in arrMId)
            {
                var lngmId = long.Parse(strMid);
                clsPrjTabFldEN objPrjTabFld = clsPrjTabFldBL.GetObjBymId(lngmId);
                objPrjTabFld.SetTabId(strTabId)
                    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    .SetUpdUser(strOpUser)
                    .SetSequenceNumber(100);

                objPrjTabFld.EditRecordEx();
                try
                {
                    clsPrjTabBLEx.AlterTab4AddField(objPrjTabFld, strCurrPrjDataBaseId);
                }
                catch (Exception objException)
                {
                    strMsg = string.Format("复制字段到新表:[{0}]时出错.错误:{1}.(in {2})", objPrjTab.TabName, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
            }
            clsPrjTabBLEx.SetUpdDate(objPrjTab, strOpUser);
            return true;
        }

        public static clsPrjTabFldENEx GetObjEx(clsPrjTabFldEN objPrjTabFld)
        {
            clsPrjTabFldENEx objPrjTabFldENEx = new clsPrjTabFldENEx();
            CopyTo(objPrjTabFld, objPrjTabFldENEx);
            return objPrjTabFldENEx;
        }
        public static clsErrMsgENEx CheckTabFlds(string strTabId, string strPrjId, string strOpUserId)
        {
            //string strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);

            //1、获取当前区域ID的相关主表ID；
            //clsvViewRegionEN objvViewRegionEN = clsvViewRegionBL.GetObjByRegionId(lngRegionId);
            //string strTabName = objvViewRegionEN.TabName;
            //string strRelaTabId = objvViewRegionEN.TabId;
            //string strMsg = "";
            int intErrCount = 0;
            var arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(strTabId, strPrjId);
            var arrPrjTabFldEx = arrPrjTabFld.Select(clsPrjTabFldBLEx.GetObjEx).ToList();
            //StringBuilder sbErrMsg = new StringBuilder();
            //try
            //{

            foreach (var objInFor in arrPrjTabFldEx)
            {
                if (objInFor.IsForExtendClass == false) continue;
                try
                {
                    clsPubFun4BLEx.CheckDnPath_PrjTab(objInFor, strPrjId, strOpUserId);
                }
                catch (Exception ex)
                {
                    objInFor.ErrMsg = ex.Message;
                    if (objInFor.DnPathId == "") objInFor.DnPathId = null;
                    objInFor.Update();
                    intErrCount++;
                    continue;
                }
                if (objInFor.ErrMsg != null && objInFor.ErrMsg.Length>0)
                {
                    objInFor.ErrMsg = "";
                    if (objInFor.DnPathId == "") objInFor.DnPathId = null;
                    objInFor.Update();
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    sbErrMsg.AppendLine(ex.Message);
            //}
            //2、获取相关主表ID的字段的对象列表;

            return new clsErrMsgENEx(conErrType.TabField, intErrCount);

        }

        public static bool CheckTabFldsUp(string strTabId, string strPrjId, string strOpUserId)
        {
            //var strPrjId_p = clsCMProjectBLEx.GetPrjIdByCmPrjIdCache(strCmPrjId);
            var objErrMsg_New = CheckTabFlds(strTabId, strPrjId, strOpUserId);

            var objInFor = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            if (objErrMsg_New.ErrNum == 0)
            {
                if (objInFor.ErrMsg == null || objInFor.ErrMsg.Length == 0) return true;
                var arrErrMsg = clsErrMsgBLEx.GetErrMsgObjLstByErrMsg(objInFor.ErrMsg);
                if (arrErrMsg == null) return true;
                if (arrErrMsg.Count == 0) return true;
                var arrErrMsg_Del = arrErrMsg.Where(x => x.ErrType != objErrMsg_New.ErrType).ToList();
                string strErrMsg_New = clsErrMsgBLEx.GetErrMsgByObjLst(arrErrMsg_Del);
                objInFor.ErrMsg = strErrMsg_New;
                objInFor.Update();
            }
            else
            {
                var arrErrMsg = clsErrMsgBLEx.GetErrMsgObjLstByErrMsg(objInFor.ErrMsg);
                clsErrMsgBLEx.AddObj(arrErrMsg, objErrMsg_New);
                string strErrMsg_New = clsErrMsgBLEx.GetErrMsgByObjLst(arrErrMsg);
                objInFor.ErrMsg = strErrMsg_New;
                objInFor.Update();
            }
            return true;
        }
        public static string GetTabIdByDnPathId(string strDnPathId)
        {
            string strCondition = string.Format("{0}='{1}'", conPrjTabFld.DnPathId, strDnPathId);
            var objPrjTabFld = clsPrjTabFldBL.GetFirstObj_S(strCondition);
            if (objPrjTabFld == null) return "";
            return objPrjTabFld.TabId;
        }
        public static string GetFldIdByDnPathId(string strDnPathId)
        {
            string strCondition = string.Format("{0}='{1}'", conPrjTabFld.DnPathId, strDnPathId);
            var objPrjTabFld = clsPrjTabFldBL.GetFirstObj_S(strCondition);
            if (objPrjTabFld == null) return "";
            return objPrjTabFld.FldId;
        }
        public static List<clsPrjTabFldEN> GetObjLstByTabIdLst(List<string> arrTabId)
        {
            string strTabIdLst = clsArray.GetSqlInStrByArray(arrTabId, true);
            string strWhere = string.Format("TabId in ({0})", strTabIdLst);
            List<clsPrjTabFldEN> arrPrjTabFldObjLst_Sel = clsPrjTabFldBL.GetObjLst(strWhere);// new List<clsPrjTabFldEN>();            
            return arrPrjTabFldObjLst_Sel;
        }
        public static List<string> GetEdgeAddiFldIdLst(string strTabId, string strPrjId)
        {
            var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);

            List<string> arrTabId4MapFunc = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;

            List<clsPrjTabFldEN> arrPrjTabFld_Sel = clsPrjTabFldBLEx.GetObjLstByTabIdCache(strTabId, strPrjId);
            arrPrjTabFld_Sel = arrPrjTabFld_Sel.Where(x => x.IsForExtendClass == true).ToList();
            List<string> arrDataPropertyName = new List<string>();
            List<string> arrAddiFldId = new List<string>();

            //Graph g1 = clsDataNodeBLEx.InitGraph(this.CmPrjId,);
            foreach (clsPrjTabFldEN objPrjTabFld in arrPrjTabFld_Sel)
            {
                if (string.IsNullOrEmpty(objPrjTabFld.DnPathId) == true && objPrjTabFld.FieldTypeId != enumFieldType.DisplayUnit_20) continue;
                
                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFld.FldId, objPrjTabFld.PrjId);

                if (string.IsNullOrEmpty(objPrjTabFld.DnPathId) == false)
                {
                    var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(objPrjTabFld.DnPathId, strPrjId);
                    if (objDnPath == null) continue;
                    if (objDnPath.PrjId != objPrjTabFld.PrjId)
                    {
                        string strMsg = string.Format("在表:[{0}]中,扩展字段:[{1}]所引用的路径不正确!", objPrjTab.TabName, objFieldTab.FldName);
                        objPrjTabFld.ErrMsg = strMsg;
                        objPrjTabFld.Update();
                        //throw new Exception(strMsg);
                        continue;
                    }
                                        
                    string strLastVarName = "";
                    long strOutDataNodeId = objDnPath.OutDataNodeId;
                    List<clsDnFuncMapEN> arrEdge = null;
                    try
                    {
                        arrEdge = clsDnFuncMapBLEx.GetObjLstByDnPath(objDnPath, strPrjId);
                    }
                    catch (Exception objException)
                    {
                        
                        string strMsg = $"转换函数中,表TabId={strTabId}({objPrjTab.TabName}),字段FldId=[{objPrjTabFld.FldId}]==>{8}在获取转换路径时,出错:{objException.Message}。 VersionNo=1,请检查!(In {clsStackTrace.GetCurrClassFunction()})";
                        throw new Exception(strMsg);
                    }
                    List<string> arrConstVar = new List<string>();
                    foreach (var objInFor in arrEdge)
                    {
                        if (objInFor == null) continue;
                        string strIsToString = "";
                        var objDataNode_Start = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.InDataNodeId, objInFor.PrjId);
                        var objDataNode_End = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.OutDataNodeId, objInFor.PrjId);
                        var objFieldTab_Start = clsFieldTabBL.GetObjByFldIdCache(objDataNode_Start.FldId, objInFor.PrjId);
                        var objFieldTab_End = clsFieldTabBL.GetObjByFldIdCache(objDataNode_End.FldId, objInFor.PrjId);

                        if (objFieldTab_Start.IsNumberType()) strIsToString = ".toString()";

                        if (objInFor.FuncMapModeId != enumFuncMapMode.Table_01) continue;
                        var objPrjTab_Edge = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);
                        
                        if (string.IsNullOrEmpty(objPrjTab_Edge.CacheClassifyFieldTS) == false)
                        {
                            arrAddiFldId.Add(objPrjTab_Edge.CacheClassifyFieldTS);
                        }
                        if (string.IsNullOrEmpty(objPrjTab_Edge.CacheClassifyField2TS) == false)
                        {
                            arrAddiFldId.Add(objPrjTab_Edge.CacheClassifyField2TS);
                        }

                    }


                               


                }
            }
            return arrAddiFldId;
        }

        public static List<string> GetEdgeAddiFldIdLst(string strTabId, string strExportFldId, string strPrjId)
        {
            var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);

            List<string> arrTabId4MapFunc = new List<string>();
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;

            List<clsPrjTabFldEN> arrPrjTabFld_Sel = clsPrjTabFldBLEx.GetObjLstByTabIdCache(strTabId, strPrjId);
            arrPrjTabFld_Sel = arrPrjTabFld_Sel.Where(x => x.IsForExtendClass == true).ToList();
            List<string> arrDataPropertyName = new List<string>();
            List<string> arrAddiFldId = new List<string>();

            //Graph g1 = clsDataNodeBLEx.InitGraph(this.CmPrjId,);
            foreach (clsPrjTabFldEN objPrjTabFld in arrPrjTabFld_Sel)
            {
                if (objPrjTabFld.FldId != strExportFldId) continue;
                if (string.IsNullOrEmpty(objPrjTabFld.DnPathId) == true && objPrjTabFld.FieldTypeId != enumFieldType.DisplayUnit_20) continue;

                var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objPrjTabFld.FldId, objPrjTabFld.PrjId);

                if (string.IsNullOrEmpty(objPrjTabFld.DnPathId) == false)
                {
                    var objDnPath = clsDnPathBL.GetObjByDnPathIdCache(objPrjTabFld.DnPathId, strPrjId);
                    if (objDnPath == null) continue;
                    if (objDnPath.PrjId != objPrjTabFld.PrjId)
                    {
                        string strMsg = string.Format("在表:[{0}]中,扩展字段:[{1}]所引用的路径不正确!", objPrjTab.TabName, objFieldTab.FldName);
                        objPrjTabFld.ErrMsg = strMsg;
                        objPrjTabFld.Update();
                        //throw new Exception(strMsg);
                        continue;
                    }

                    string strLastVarName = "";
                    long strOutDataNodeId = objDnPath.OutDataNodeId;
                    List<clsDnFuncMapEN> arrEdge = null;
                    try
                    {
                        arrEdge = clsDnFuncMapBLEx.GetObjLstByDnPath(objDnPath, strPrjId);
                    }
                    catch (Exception objException)
                    {

                        string strMsg = $"转换函数中,表TabId={strTabId}({objPrjTab.TabName}),字段FldId=[{objPrjTabFld.FldId}]==>{8}在获取转换路径时,出错:{objException.Message}。 VersionNo=1,请检查!(In {clsStackTrace.GetCurrClassFunction()})";
                        throw new Exception(strMsg);
                    }
                    List<string> arrConstVar = new List<string>();
                    foreach (var objInFor in arrEdge)
                    {
                        if (objInFor == null) continue;
                        string strIsToString = "";
                        var objDataNode_Start = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.InDataNodeId, objInFor.PrjId);
                        var objDataNode_End = clsDataNodeBL.GetObjByDataNodeIdCache(objInFor.OutDataNodeId, objInFor.PrjId);
                        var objFieldTab_Start = clsFieldTabBL.GetObjByFldIdCache(objDataNode_Start.FldId, objInFor.PrjId);
                        var objFieldTab_End = clsFieldTabBL.GetObjByFldIdCache(objDataNode_End.FldId, objInFor.PrjId);

                        if (objFieldTab_Start.IsNumberType()) strIsToString = ".toString()";

                        if (objInFor.FuncMapModeId != enumFuncMapMode.Table_01) continue;
                        var objPrjTab_Edge = clsPrjTabBL.GetObjByTabIdCache(objInFor.TabId, objInFor.PrjId);

                        if (string.IsNullOrEmpty(objPrjTab_Edge.CacheClassifyFieldTS) == false)
                        {
                            arrAddiFldId.Add(objPrjTab_Edge.CacheClassifyFieldTS);
                        }
                        if (string.IsNullOrEmpty(objPrjTab_Edge.CacheClassifyField2TS) == false)
                        {
                            arrAddiFldId.Add(objPrjTab_Edge.CacheClassifyField2TS);
                        }

                    }





                }
            }
            return arrAddiFldId;
        }


    }
}
