using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.Entity;

using System.Collections;
using com.taishsoft.commdb;
using AGC.DAL;
using com.taishsoft.common;
using System.Data;
using com.taishsoft.datetime;
using AGC.BusinessLogic;
using System.Web.UI.WebControls;

using com.taishsoft.commexception;
using System.Data.SqlClient;
using com.taishsoft.sql;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 全静态类，包含全静态函数，相当于全局函数
    /// </summary>
    public static class clsFieldTabBLEx_Static
    {
        public static clsDataTypeAbbrEN ObjDataTypeAbbr(this clsFieldTabEN objFieldTab)
        {
            clsDataTypeAbbrEN objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTab.DataTypeId);
            return objDataTypeAbbr;
        }
                


        public static string DataTypeName(this clsFieldTabEN objFieldTab)
        {
            try
            {
                var objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTab.DataTypeId);
                if (objDataTypeAbbr == null) return "";
                return objDataTypeAbbr.DataTypeName;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据字段类型获取对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static clsFieldTab4CodeConvEN ObjFieldTab4CodeConv(this clsFieldTabEN objFieldTab)
        {
            try
            {
                var arrFieldTab4CodeConv = clsFieldTab4CodeConvBL.GetObjLstCache(objFieldTab.PrjId);
                clsFieldTab4CodeConvEN objFieldTab4CodeConv = arrFieldTab4CodeConv.Find(x=>x.FldId == objFieldTab.FldId);
                return objFieldTab4CodeConv;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表字段获取字段代码转换对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static string TypeScriptType(this clsFieldTabEN objFieldTab)
        {
            if (objFieldTab == null) return "";
            var ObjDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTab.DataTypeId);
            return ObjDataTypeAbbr.TypeScriptType;
        }

        public static string CsType(this clsFieldTabEN objFieldTab)
        {
            var ObjDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTab.DataTypeId);
            return ObjDataTypeAbbr.CsType;
        }
        /// <summary>
        /// 是否数字类型
        /// </summary>
        /// <param name="objFieldTab"></param>
        /// <returns></returns>
        public static bool IsNumberType(this clsFieldTabEN objFieldTab)
        {
            var objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTab.DataTypeId);
            switch (objDataTypeAbbrEN.CsType)
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
        //public static bool IsBoolType(this clsFieldTabEN objFieldTab)
        //{
        //    var objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTab.DataTypeId);
        //    switch (objDataTypeAbbrEN.CsType)
        //    {
        //        case "bit":
        //        case "Bit":
        //        case "boolean":
        //        case "Boolean":
        //        case "bool":
        //        case "Bool":
        //            return true;
        //        default:
        //            return false;
        //    }
        //}
        public static bool IsBoolType(this clsFieldTabEN objFieldTab)
        {
            var objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTab.DataTypeId);
            switch (objDataTypeAbbrEN.CsType)
            {
                case "bool":
                case "boolean":
                    return true;
                default:
                    return false;
            }
        }
        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_AddRecordEx)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        public static bool AddRecordEx2(this clsFieldTabEN objFieldTabEN)
        {
            //操作步骤:
            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //2、检查唯一性
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
                            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsFieldTabBL.IsExist(objFieldTabEN.FldId)) //判断是否有相同的关键字
            {
                strMsg = "(errid:BlEx000004)关键字字段已有相同的值";
                throw new Exception(strMsg);
            }
            try
            {
                if (new List<string>() {enumDataTypeAbbr.bigint_01,
enumDataTypeAbbr.int_09,
enumDataTypeAbbr.char_04,
enumDataTypeAbbr.varchar_25,
enumDataTypeAbbr.nvarchar_15,
enumDataTypeAbbr.text_20,
enumDataTypeAbbr.bit_03}.Contains(objFieldTabEN.DataTypeId)
                )
                {
                    objFieldTabEN.FldPrecision = 0;
                }

                //2、检查传进去的对象属性是否合法
                objFieldTabEN.CheckPropertyNew();
                //5.2、检查唯一性
                if (objFieldTabEN.CheckUniqueness() == false)
                {
                    strMsg = string.Format("(工程ID(PrjId)=[{0}],字段名(FldName)=[{1}],数据类型Id(DataTypeId)=[{2}])已经存在，不能重复!", objFieldTabEN.PrjId, objFieldTabEN.FldName, objFieldTabEN.DataTypeId);
                    throw new Exception(strMsg);
                }
         
                //6、把数据实体层的数据存贮到数据库中
                objFieldTabEN.AddNewRecord();
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
        /// <param name = "objFieldTabEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool UpdateRecordEx2(this clsFieldTabEN objFieldTabEN)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
            try
            {
                if (new List<string>() {enumDataTypeAbbr.bigint_01,
enumDataTypeAbbr.int_09,
enumDataTypeAbbr.char_04,
enumDataTypeAbbr.varchar_25,
enumDataTypeAbbr.nvarchar_15,
enumDataTypeAbbr.text_20,
enumDataTypeAbbr.bit_03}.Contains(objFieldTabEN.DataTypeId)
               )
                {
                    objFieldTabEN.FldPrecision = 0;
                }
                //1、检查传进去的对象属性是否合法
                objFieldTabEN.CheckPropertyNew();
                //2、检查唯一性
                if (objFieldTabEN.CheckUniqueness() == false)
                {
                    strMsg = "(工程ID(PrjId),字段名(FldName),数据类型Id(DataTypeId))不能重复!";
                    throw new Exception(strMsg);
                }
                //4、把数据实体层的数据存贮到数据库中
                objFieldTabEN.Update();
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
        /// <param name = "objFieldTab">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx2(this clsFieldTabEN objFieldTab)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsFieldTabEN objFieldTab_Cond = new clsFieldTabEN();
            string strCondition = objFieldTab_Cond
            .SetFldId(objFieldTab.FldId, "=")
            .GetCombineCondition();
            objFieldTab._IsCheckProperty = true;
            bool bolIsExist = clsFieldTabBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objFieldTab.FldId = clsFieldTabBL.GetFirstID_S(strCondition);
                objFieldTab.UpdateWithCondition(strCondition);
            }
            else
            {
                objFieldTab.AddRecordEx();
            }
            return true;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objFieldTabENS">源对象</param>
        /// <returns>目标对象=>clsFieldTabEN:objFieldTabENT</returns>
        public static clsFieldTabENEx CopyToEx(this clsFieldTabEN objFieldTabENS)
        {
            try
            {
                clsFieldTabENEx objFieldTabENT = new clsFieldTabENEx();
                clsFieldTabBL.CopyTo(objFieldTabENS, objFieldTabENT);
                return objFieldTabENT;
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
        /// <param name = "objFieldTabENS">源对象</param>
        /// <returns>目标对象=>clsFieldTabEN:objFieldTabENT</returns>
        public static clsFieldTabEN CopyTo(this clsFieldTabENEx objFieldTabENS)
        {
            try
            {
                clsFieldTabEN objFieldTabENT = new clsFieldTabEN();
                clsFieldTabBL.CopyTo(objFieldTabENS, objFieldTabENT);
                return objFieldTabENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 是否数字类型
        /// </summary>
        /// <param name="objFieldTabENEx"></param>
        /// <returns></returns>
        public static bool IsNumberType(this clsFieldTabENEx objFieldTabENEx)
        {
            switch (objFieldTabENEx.objDataTypeAbbrEN.CsType)
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

        public static string PrivFuncName2(this clsFieldTabEN objFieldTabEN)
        {
            var objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTabEN.DataTypeId);
            return objDataTypeAbbr.DataTypeAbbr + objFieldTabEN.FldName;

        }

        public static clsDataTypeAbbrEN ObjDataTypeAbbr1(this clsFieldTabEN objFieldTabEN)
        {
            if (objFieldTabEN == null) return null;
            try
            {

                clsDataTypeAbbrEN objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTabEN.DataTypeId);
                return objDataTypeAbbr;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)根据表功能字段获取字段对象出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        public static string PrivFuncName1(this clsFieldTabEN objFieldTabEN)
        {
            if (objFieldTabEN == null) return "";
            return objFieldTabEN.ObjDataTypeAbbr1().DataTypeAbbr + objFieldTabEN.FldName;
        }
        /// <summary>
        /// 字段生成的属性名，根据bolIsFstLcase的值决定首字母是否小写
        /// </summary>
        /// <param name="objFieldTabEN"></param>
        /// <returns></returns>
        public static string PropertyName(this clsFieldTabEN objFieldTabEN, bool bolIsFstLcase)
        {
            if (bolIsFstLcase == false)
            {
                return objFieldTabEN.FldName; 
            }
            else
            {
                return clsString.FstLcaseS( objFieldTabEN.FldName);
            }
        }
        public static string PropertyNameEx(this clsFieldTabEN objFieldTabEN, bool bolIsFstLcase)
        {
            if (bolIsFstLcase == false)
            {
                return objFieldTabEN.FldName.Replace("_", "");
            }
            else
            {
                return clsString.FstLcaseS(objFieldTabEN.FldName.Replace("_", ""));
            }
        }
        public static string PropertyName_TS(this clsFieldTabEN objFieldTabEN, bool bolIsFstLcase)
        {
            if (bolIsFstLcase == false)
            {
                return objFieldTabEN.FldName;
            }
            else
            {
                return clsString.FstLcaseS(objFieldTabEN.FldName);
            }
        }

    }

    public partial class clsFieldTabBLEx
    {
        /// <summary>
        /// 从缓存中查找失败的次数
        /// </summary>
        protected static int intFindFailCount = 0;
        //public static List<clsFieldTabENEx> arrFieldTabENExObjLst4WinApp = null;
        //public static List<clsFieldTabENEx> arrFieldTabENExObjLstOrderByFldIdCache = null;
        //public static string strPrjIdCache = "";
        //public static int intFldNum = 0;
        ///导入字段到表FieldTab中
        public static string ImportFldToFieldTab(string strFldName, string strCaption,
            string strTypeName, int intFldLength, bool bolIsNull, string strPrjId)
        {
            clsFieldTabENEx objFieldTabEN;
            objFieldTabEN = new clsFieldTabENEx();
            //工程ID
            objFieldTabEN.PrjId = strPrjId;
            //检查是否存在相同的字段名
            if (IsExistSameFldName(strPrjId, strFldName) == true)
            {
                objFieldTabEN.FldId = clsFieldTabBLEx.GetFldId(strPrjId, strFldName);
                //clsFldObjTabBLEx.CreateFldObjRelation(strObjId, objFieldTabEN.FldId);
            }
            else
            {
                objFieldTabEN.FldId = clsGeneralTab.GetMaxStrId("FieldTab", "FldId", 8, strPrjId);
                objFieldTabEN.FldName = strFldName;
                //转换类型名称
                ArrayList arrID = new ArrayList();

                if (strTypeName == "bigint identity") strTypeName = "bigint";
                if (strTypeName == "int identity") strTypeName = "int";

                string strFldType = clsDataTypeAbbrBL.GetFirstID_S("DataTypeName = '" + strTypeName + "'");
                objFieldTabEN.DataTypeId = strFldType;
                objFieldTabEN.IsNull = bolIsNull;
                objFieldTabEN.IsPrimaryKey = false;
                objFieldTabEN.FldLength = intFldLength;
                objFieldTabEN.Caption = strCaption;
                objFieldTabEN.IsOnlyOne = false;
                objFieldTabEN.FldStateId = "01";
                objFieldTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                //objFieldTabEN.UserId = clsCommonSession.UserId;
                if (AddNewRecordEx(objFieldTabEN) == false)
                {

                    throw new Exception("添加不成功!");
                }
                else
                {
                    //clsFldObjTabBLEx.CreateFldObjRelation(strObjId, objFieldTabEN.FldId);
                    throw new Exception("添加记录成功!");
                }

            }
            return objFieldTabEN.FldId;
        }
        /// <summary>
        /// 是否在同一个工程中存在相同的字段名
        /// </summary>
        /// <param name = "strPrjId"></param>
        /// <param name = "strFldName"></param>
        /// <returns></returns>
        public static bool IsExistSameFldName(string strPrjId, string strFldName)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("PrjId = '{0}' and FldName = '{1}'", strPrjId, strFldName);
            return clsFieldTabBL.IsExistRecord(strCondition.ToString());
        }
        /// <summary>
        /// 功能:根据工程名(strPrjId)和字段名称(strFldName)获取相应的字段ID
        /// </summary>
        /// <param name = "strPrjId">工程ID</param>
        /// <param name = "strFldName">字段名称</param>
        /// <returns>字段ID</returns>
        public static string GetFldId(string strPrjId, string strFldName)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("PrjId = '{0}' and FldName = '{1}'", strPrjId, strFldName);
            List<string> arrFldId = clsGeneralTab2.funGetFldValue("FieldTab", "FldId", strCondition.ToString());
            if (arrFldId == null || arrFldId.Count == 0)
            {
                return "";
            }
            return arrFldId[0].ToString();
        }
  

        /// <summary>
        /// 根据表Id获取《字段》对象列表
        /// </summary>
        /// <param name="strTabId">表Id</param>
        /// <returns></returns>
        public static List<clsFieldTabEN> GetObjLstByTabId(string strTabId)
        {
            string strCondition = string.Format("{0} in (Select {0} From {1} Where {2}='{3}')",
             conFieldTab.FldId,
             clsPrjTabFldEN._CurrTabName,
             conPrjTabFld.TabId, strTabId);
            List<clsFieldTabEN> arrObjLst = clsFieldTabBL.GetObjLst(strCondition);
            return arrObjLst;
        }
        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strFldName">字段名</param>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsFieldTabENEx GetObjExByFldName(string strFldName, string strPrjId)
        {      
            var arrFieldTabENExObjLst4WinApp = clsFieldTabBL.GetObjLstCache(strPrjId);
            var objFieldTab = arrFieldTabENExObjLst4WinApp.Find(x => x.FldName.Equals(strFldName, StringComparison.InvariantCultureIgnoreCase) == true);
            if (objFieldTab == null)
            {
                var objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                string strMsg = string.Format("在工程:{0}中，没有字段名:{1},请检查！请重试！(In {2})", objProject.PrjName, strFldName, clsStackTrace.GetCurrClassFunction());
                clsFieldTabBL.ReFreshCache(strPrjId);
                throw new Exception(strMsg);
            }
            var objFieldTabENEx = objFieldTab.CopyToEx();
            return objFieldTabENEx;

        }
        public static List<clsFieldTabEN> GetObjLstByTabIdCache(string strTabId, string strPrjId)
        {
            List<clsPrjTabFldEN> arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(strTabId, strPrjId);
            var arrFldId = arrPrjTabFld.Select(x=>x.FldId).ToList();
            var arrFieldTabObjLst = clsFieldTabBL.GetObjLstCache(strPrjId);
            var arrFieldTab_Sel = arrFieldTabObjLst.Where(x => arrFldId.Contains( x.FldId)).ToList();
            return arrFieldTab_Sel;
        }

        public static clsFieldTabENEx GetObjExByFldIDCache(string strFldId, string strPrjId)
        {
            var arrFieldTabENExObjLst4WinApp = clsFieldTabBL.GetObjLstCache(strPrjId);
            var objFieldTab = arrFieldTabENExObjLst4WinApp.Find(x => x.FldId == strFldId);
            if (objFieldTab == null)
            {
                var objProject = clsProjectsBL.GetObjByPrjIdCache(strPrjId);
                string strMsg = string.Format("在工程:{0}中，没有字段Id:{1},请检查！请重试！(In {2})", objProject.PrjName, strFldId, clsStackTrace.GetCurrClassFunction());
                clsFieldTabBL.ReFreshCache(strPrjId);
                throw new Exception(strMsg);
            }
            var objFieldTabENEx = objFieldTab.CopyToEx();
            return objFieldTabENEx;
        }
            

        /// <summary>
        /// 检查字段,专门针对代码表
        /// </summary>
        /// <param name = "objFieldTabEN">字段对象</param>
        /// <returns>是否成功？</returns>
        public static bool CheckFieldTabByCodeTab(clsFieldTabEN objFieldTabEN)
        {
            var objFieldTab4CodeConv = objFieldTabEN.ObjFieldTab4CodeConv();
            if (objFieldTab4CodeConv == null) return true;
            if (string.IsNullOrEmpty(objFieldTab4CodeConv.CodeTabId) == true)
            {
                if (objFieldTabEN.Memo != "需要转换代码的字段的转换代码表不能为空!")
                {
                    objFieldTabEN.Memo = "需要转换代码的字段的转换代码表不能为空!";
                    objFieldTabEN.UpdateRecordEx();
                }
                return false;
            }


            if (string.IsNullOrEmpty(objFieldTab4CodeConv.CodeTabCodeId) == true)
            {
                if (objFieldTabEN.Memo != "需要转换代码的字段的转换代码表--代码不能为空!")
                {
                    objFieldTabEN.Memo = "需要转换代码的字段的转换代码表--代码不能为空!";
                    objFieldTabEN.UpdateRecordEx();
                }
                return false;
            }


            if (string.IsNullOrEmpty(objFieldTab4CodeConv.CodeTabNameId) == true)
            {
                if (objFieldTabEN.Memo != "需要转换代码的字段的转换代码表--名称不能为空!")
                {
                    objFieldTabEN.Memo = "需要转换代码的字段的转换代码表--名称不能为空!";
                    objFieldTabEN.UpdateRecordEx();
                }
                return false;
            }


            if (string.IsNullOrEmpty(objFieldTabEN.Memo) == true)
            {
                return true;
            }
            objFieldTabEN.Memo = objFieldTabEN.Memo.Replace("需要转换代码的字段的转换代码表不能为空!", "");
            objFieldTabEN.Memo = objFieldTabEN.Memo.Replace("需要转换代码的字段的转换代码表--代码不能为空!", "");
            objFieldTabEN.Memo = objFieldTabEN.Memo.Replace("需要转换代码的字段的转换代码表--名称不能为空!", "");
            objFieldTabEN.UpdateRecordEx();

            return true;
        }


        /// <summary>
        /// 功能:根据工程名(strPrjId)和字段名称(strFldName)获取相应的字段ID
        /// </summary>
        /// <param name = "strPrjId">工程ID</param>
        /// <param name = "strFldName">字段名称</param>
        /// <returns>字段ID</returns>
        public static string GetFldId(string strPrjId, string strFldName, string strFldTypeId, int intFldLength)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("PrjId = '{0}' and FldName = '{1}' and DataTypeId = '{2}' and FldLength = {3}",
              strPrjId,
              strFldName,
              strFldTypeId,
              intFldLength);

            List<string> arrFldId = clsGeneralTab2.funGetFldValue("FieldTab", "FldId", strCondition.ToString());
            if (arrFldId == null || arrFldId.Count == 0)
            {
                return "";
            }
            return arrFldId[0].ToString();
        }


        /// <summary>
        /// 添加字段到数据库中
        /// </summary>
        /// <returns></returns>
        public static bool AddNewRecordEx(clsFieldTabENEx objFieldTabEN)
        {
            //						///3.1、判断是否有相同的字段存在。					
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("PrjId = '{0}' and FldName = '{1}' and DataTypeId = '{2}' and FldLength = {3}",
             objFieldTabEN.PrjId,
               objFieldTabEN.FldName,
              objFieldTabEN.DataTypeId,
              objFieldTabEN.FldLength);

            if (clsFieldTabBL.IsExistRecord(strCondition.ToString()) == true)   //判断是否有相同的关键字
            {
                return true;
            }
            else
            {
                return objFieldTabEN.AddRecordEx();
            }

        }


        /// <summary>
        /// 是否在同一个工程中存在相同的字段名
        /// </summary>
        /// <param name = "strPrjId"></param>
        /// <param name = "strFldName"></param>
        /// <returns></returns>
        public static bool IsExistSameFldName(string strPrjId, string strFldName, string strFldTypeId)
        {
            //DataTypeId
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("PrjId = '{0}' and FldName = '{1}' And DataTypeId = '{2}'",
              strPrjId, strFldName, strFldTypeId);
            return clsFieldTabBL.IsExistRecord(strCondition.ToString());
        }



        /// <summary>
        /// 是否在同一个工程中存在相同的字段名
        /// </summary>
        /// <param name = "strPrjId"></param>
        /// <param name = "strFldName"></param>
        /// <param name = "strFldTypeId"></param>
        /// <param name = "intFldLength"></param>
        /// <returns></returns>
        public static bool IsExistSameFldName(string strPrjId, string strFldName,
          string strFldTypeId,
          int intFldLength)
        {

            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("PrjId = '{0}' and FldName = '{1}' and DataTypeId = '{2}' and FldLength = {3}",
              strPrjId,
              strFldName,
              strFldTypeId,
              intFldLength);
            return clsFieldTabBL.IsExistRecord(strCondition.ToString());
        }

        /// <summary>
        /// 是否能够删除和修改
        /// </summary>
        /// <param name = "strFldId">字段ID</param>
        /// <returns></returns>
        public static bool IsCanDelUpd(string strFldId)
        {
            clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldId);

            bool bolIsArchive = objFieldTabEN.IsArchive;
            if (bolIsArchive == true) return false;
            bool bolIsChecked = objFieldTabEN.IsChecked;
            return !bolIsChecked;
        }

        //同时删除多条记录,扩展删除,是全功能删除
        public static bool DelFieldTabEx2(List<string> lstKey)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strSQL;
            bool bolIsFirstItem = true;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < lstKey.Count; i++)
            {
                if (IsCanDelUpd(lstKey[i].ToString()) == false) continue;
                if (bolIsFirstItem == true)
                {
                    strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
                    bolIsFirstItem = false;
                }
                else strKeyList += ", " + "'" + lstKey[i].ToString() + "'";
            }
            if (strKeyList == "") return true;
            //删除相关的工程表字段
            List<string> arrRelaMid = clsPrjTabFldBL.GetPrimaryKeyID_S("FldId in (" + strKeyList + ")");
            if (arrRelaMid != null)
            {
                foreach (string strMid in arrRelaMid)
                {
                    long lngMid = long.Parse(strMid);
                    clsPrjTabFldBLEx.DelRecordEx(lngMid);
                }
            }
            strSQL = "";
            //删除与FieldTab表有关的外键表中的内容
//            strSQL = strSQL + "Delete FldObjTab where FldId in (" + strKeyList + ")";
            strSQL = strSQL + "Delete EditRegionFlds where FldId in (" + strKeyList + ")";
            //删除FieldTab本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from ConstraintFields where FldId in (" + strKeyList + ")";

            strSQL = strSQL + "Delete from FieldTab where FldId in (" + strKeyList + ")";
         
            bool bolResult = objSQL.ExecSql(strSQL);
            return bolResult;
        }


        //同时删除多条记录
        public static bool DelFieldTabEx(List<string> lstKey)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strSQL;
            bool bolIsFirstItem = true;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < lstKey.Count; i++)
            {
                if (IsCanDelUpd(lstKey[i].ToString()) == false) continue;
                if (bolIsFirstItem == true)
                {
                    strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
                    bolIsFirstItem = false;
                }
                else strKeyList += ", " + "'" + lstKey[i].ToString() + "'";
            }
            if (strKeyList == "") return true;
            //删除相关的工程表字段
            List<string> arrRelaMid = clsPrjTabFldBL.GetPrimaryKeyID_S("FldId in (" + strKeyList + ")");
            if (arrRelaMid != null)
            {
                foreach (string strMid in arrRelaMid)
                {
                    long lngMid = long.Parse(strMid);
                    clsPrjTabFldBLEx.DelRecordEx(lngMid);
                }
            }
            strSQL = "";
            //删除与FieldTab表有关的外键表中的内容
            //			strSQL = strSQL + "Delete FldObjTab where FldId in (" + strKeyList + ")";
            strSQL = strSQL + "Delete EditRegionFlds where DsDataValueFieldId in (" + strKeyList + ")";
            //删除FieldTab本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from FieldTab where FldId in (" + strKeyList + ")";
            bool bolResult = objSQL.ExecSql(strSQL);
            return bolResult;
        }



        public static bool DelFieldTabBySp(string strFldId, string strTabId)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            ArrayList arrValue = new ArrayList();
            arrValue.Add(strFldId);
            arrValue.Add(strTabId);
            bool bolResult = objSQL.ExecSP2("DelTabFieldByPrjTab", arrValue);
            return bolResult;
        }


        public static bool UpdateTabNumForFldId(string strFldId)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            ArrayList arrValue = new ArrayList();
            arrValue.Add(strFldId);
         
            bool bolResult = objSQL.ExecSP2("UpdateTabNumForFldId", arrValue);
            return bolResult;
        }


        /// <summary>
        /// 功能:从一个工程(源工程)复制一组字段到新工程中。
        /// </summary>
        /// <param name = "strPrjId">源工程</param>    
        /// <param name = "strSouFldId">源字段Id</param>
        /// <param name = "strNewFieldName">新字段名</param>
        /// <param name = "strTarTabId">目标TabId</param>
        /// <param name = "strUserId">当前用户ID</param>
        /// <returns>新工程中字段ID</returns>
        public static string CopyField4PrjTab(string strPrjId, string strSouFldId,
            string strNewFieldName, string strTarTabId, string strUserId)
        {
            //操作步骤:
            //1、根据<源字段ID>新建一个字段对象。并且获取该字段对象的所有属性。
            //2、检查是否存在相同的字段名,
            //		2.1 如果存在就获取相同字段名的<字段ID>,退出返回；
            //3、建立一个新字段对象；
            //4、为新字段对象设置FldId值,即新工程中字段ID的最大值；
            //5、把源字段对象的所有属性都复制到新字段对象中。
            //6、返回新字段ID
            //
            string strTarFldId = "";        //目标字段ID,即新工程中字段ID
            clsFieldTabENEx objSouFieldTab, objTarFieldTab;
            objSouFieldTab = clsFieldTabBLEx.GetObjExByFldIDCache(strSouFldId, strPrjId);

            //2、检查是否存在相同的字段名,如果存在就退出返回；
            if (IsExistSameFldName(strPrjId, strNewFieldName, objSouFieldTab.DataTypeId) == true)
            {
                strTarFldId = GetFldId(strPrjId, strNewFieldName, objSouFieldTab.DataTypeId);
                clsPrjTabFldBLEx.Add_FieldTabToPrjTabFld(strTarTabId, strTarFldId, strUserId);
                //                clsFldObjTabBLEx.CreateFldObjRelation(strTarObjId, strTarFldId);

                return strTarFldId;
            }
            else
            {
                objTarFieldTab = new clsFieldTabENEx();
                strTarFldId = clsGeneralTab.GetMaxStrId("FieldTab", "FldId", 8, strPrjId);
                objTarFieldTab.FldId = strTarFldId;
                objTarFieldTab.PrjId = strPrjId;
                objTarFieldTab.FldName = strNewFieldName;
                objTarFieldTab.DataTypeId = objSouFieldTab.DataTypeId;
                objTarFieldTab.IsNull = objSouFieldTab.IsNull;
                objTarFieldTab.IsPrimaryKey = objSouFieldTab.IsPrimaryKey;
                objTarFieldTab.FldLength = objSouFieldTab.FldLength;
                objTarFieldTab.FldPrecision = objSouFieldTab.FldPrecision;

                objTarFieldTab.Caption = objSouFieldTab.Caption;
                objTarFieldTab.IsOnlyOne = objSouFieldTab.IsOnlyOne;
                objTarFieldTab.UpdUser = strUserId;
                //objTarFieldTab.IsNeedTransCode = objSouFieldTab.IsNeedTransCode;
                //objTarFieldTab.CodeTabId = objSouFieldTab.CodeTabId;
                //objTarFieldTab.CodeTabCodeId = objSouFieldTab.CodeTabCodeId;
                //objTarFieldTab.CodeTabNameId = objSouFieldTab.CodeTabNameId;
                objTarFieldTab.FldStateId = objSouFieldTab.FldStateId;

                objTarFieldTab.UpdDate = clsDateTime.getTodayStr(0);        
                objTarFieldTab.AddRecordEx();
                clsPrjTabFldBLEx.Add_FieldTabToPrjTabFld(strTarTabId, strTarFldId, strUserId);
                return strTarFldId;
            }

        }

        /// <summary>
        /// 检查字段
        /// </summary>
        /// <param name = "objFieldTabEN">需要检查的字段对象</param>
        /// <returns></returns>
        public static bool CheckFieldTabNnUpdate(clsFieldTabEN objFieldTabEN)
        {
            string strFieldTypeName = clsDataTypeAbbrBL.GetDataTypeNameByDataTypeIdCache(objFieldTabEN.DataTypeId);
            if (strFieldTypeName == "char" || strFieldTypeName == "varchar")
            {
                if (objFieldTabEN.IsIdentity == true)
                {
                    if (objFieldTabEN.Memo != "字符型字段不能定义成Identity主键!")
                    {
                        objFieldTabEN.Memo = "字符型字段不能定义成Identity主键!";
                        //            objFieldTabEN.Update();
                    }
                    return false;
                }
            }
            else if (objFieldTabEN.IsIdentity == true && objFieldTabEN.IsPrimaryKey == false)
            {
                if (objFieldTabEN.Memo == "作为Identity字段应该是主键字段!")
                {
                    objFieldTabEN.Memo = "作为Identity字段应该是主键字段!";
                    //objFieldTabEN.Update();
                }
                return false;
            }
            else if (objFieldTabEN.IsIdentity == true)
            {
                if (strFieldTypeName != "int" && strFieldTypeName != "bigint")
                {
                    if (objFieldTabEN.Memo != "作为Identity字段应该是整型(int)或者长整型(bigint)!")
                    {
                        objFieldTabEN.Memo = "作为Identity字段应该是整型(int)或者长整型(bigint)!";
                        //objFieldTabEN.Update();
                    }
                    return false;

                }
            }
            else if (objFieldTabEN.IsPrimaryKey == true)
            {
                if (strFieldTypeName != "int"
                  && strFieldTypeName != "bigint"
                  && strFieldTypeName != "char"
                  && strFieldTypeName != "varchar"
                 )
                {
                    if (objFieldTabEN.Memo != "作为主键字段应该是(int,bigint,char,varchar)类型!")
                    {
                        objFieldTabEN.Memo = "作为主键字段应该是(int,bigint,char,varchar)类型!";
                        //objFieldTabEN.Update();

                    }
                    return false;
                }
            }
            if (objFieldTabEN.Memo != "")
            {
                objFieldTabEN.Memo = "";
                //objFieldTabEN.Update();
                return true;
            }
            return true;
        }

        public static bool CheckFieldTab(string strFldId, string strPrjId)
        {
            clsFieldTabENEx objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(strFldId, strPrjId);
            //clsFieldTabBL.GetFieldTab(ref objFieldTabEN);
            string strFieldTypeName = GetFldType(strFldId, strPrjId);
            if (strFieldTypeName == "char" || strFieldTypeName == "varchar")
            {
                if (objFieldTabEN.IsIdentity == true)
                {
                    if (objFieldTabEN.Memo != "字符型字段不能定义成Identity主键!")
                    {
                        objFieldTabEN.Memo = "字符型字段不能定义成Identity主键!";
                        objFieldTabEN.UpdateRecordEx();
                    }
                    return false;
                }
            }
            else if (objFieldTabEN.IsIdentity == true && objFieldTabEN.IsPrimaryKey == false)
            {
                if (objFieldTabEN.Memo == "作为Identity字段应该是主键字段!")
                {
                    objFieldTabEN.Memo = "作为Identity字段应该是主键字段!";
                    objFieldTabEN.UpdateRecordEx();
                }
                return false;
            }
            else if (objFieldTabEN.IsIdentity == true)
            {
                if (strFieldTypeName != "int" && strFieldTypeName != "bigint")
                {
                    if (objFieldTabEN.Memo != "作为Identity字段应该是整型(int)或者长整型(bigint)!")
                    {
                        objFieldTabEN.Memo = "作为Identity字段应该是整型(int)或者长整型(bigint)!";
                        objFieldTabEN.UpdateRecordEx();
                    }
                    return false;

                }
            }
            else if (objFieldTabEN.IsPrimaryKey == true)
            {
                if (strFieldTypeName != "int"
                  && strFieldTypeName != "bigint"
                  && strFieldTypeName != "char"
                  && strFieldTypeName != "varchar"
                 )
                {
                    if (objFieldTabEN.Memo != "作为主键字段应该是(int,bigint,char,varchar)类型!")
                    {
                        objFieldTabEN.Memo = "作为主键字段应该是(int,bigint,char,varchar)类型!";
                        objFieldTabEN.UpdateRecordEx();

                    }
                    return false;
                }
            }

            if (objFieldTabEN.Memo != "")
            {
                objFieldTabEN.Memo = "";
                objFieldTabEN.UpdateRecordEx();
                return true;
            }
            return true;
        }
        /// <summary>
        /// 功能:根据字段ID得到字段类型名
        /// </summary>
        /// <param name = "strFldId">所给的字段ID</param>
        /// <returns>返回的字段类型名</returns>
        public static string GetFldType(string strFldId, string strPrjId)
        {
            clsFieldTabENEx objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(strFldId, strPrjId);
            //clsFieldTabBL.GetFieldTab(ref objFieldTabEN);
            string strFldTypeId = objFieldTabEN.DataTypeId;
            string strFldTypeName = clsDataTypeAbbrBLEx.GetDataTypeNameByDataTypeIdCache(strFldTypeId);
            return strFldTypeName;
        }


        public static bool BackupFldInfo(ArrayList arrRec)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            string strSQL;
            string strKeyList;
            if (arrRec.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < arrRec.Count; i++)
            {
                if (i == 0) strKeyList = strKeyList + "'" + arrRec[i].ToString() + "'";
                else strKeyList += "," + "'" + arrRec[i].ToString() + "'";
            }
            strSQL = "";
            //删除FieldTab本表中与当前对象有关的记录
            strSQL = strSQL + "Update FieldTab Set FldName_B = FldName where FldId in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL);
        }
        ///导入字段到表FieldTab中
        public static string ImportFldToFieldTab(string strFldName, string strCaption, string strTypeName, int intFldLength, int intFldPrecision, bool bolIsNull, string strPrjId, string strUpdUser)
        {
            clsFieldTabENEx objFieldTabEN;
            objFieldTabEN = new clsFieldTabENEx();

            clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBLEx.GetObjByDataTypeNameCache(strTypeName);

            if (objDataTypeAbbrEN == null)
            {
                throw new Exception(string.Format("Sql Server中数据类型名:{0}不存在,请检查!", strTypeName));
            }
            //工程ID
            objFieldTabEN.PrjId = strPrjId;
            //检查是否存在相同的字段名
            if (IsExistSameFldName(strPrjId, strFldName, objDataTypeAbbrEN.DataTypeId) == true)
            {
                objFieldTabEN.FldId = GetFldId(strPrjId, strFldName, objDataTypeAbbrEN.DataTypeId);
            }
            else
            {
                objFieldTabEN.FldId = clsGeneralTab.GetMaxStrId("FieldTab", "FldId", 8, strPrjId);
                objFieldTabEN.FldName = strFldName;
                //转换类型名称
                List<string> arrID = new List<string>();

                if (strTypeName == "bigint identity") strTypeName = "bigint";
                if (strTypeName == "int identity") strTypeName = "int";


                objFieldTabEN.DataTypeId = objDataTypeAbbrEN.DataTypeId;
                objFieldTabEN.IsNull = bolIsNull;
                objFieldTabEN.IsPrimaryKey = false;
                objFieldTabEN.FldLength = intFldLength;
                objFieldTabEN.FldPrecision = intFldPrecision;
                objFieldTabEN.Caption = strCaption;
                objFieldTabEN.IsOnlyOne = false;
                objFieldTabEN.FldStateId = "01";
                objFieldTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objFieldTabEN.UpdUser = strUpdUser;
                if (AddNewRecordEx(objFieldTabEN) == false)
                {
                    string strMsg = string.Format("添加字段：{0}不成功！({1})", strFldName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //  throw new Exception("添加记录成功!");
                }

            }
            return objFieldTabEN.FldId;
        }

        /// <summary>
        /// 功能:导入字段信息到FieldTab中
        /// </summary>
        /// <param name = "objColumns">字段对象</param>   
        /// <param name = "strPrjId">对象ID</param>
        /// <param name = "strUserId">用户Id</param>
        /// <returns>是否成功？</returns>
        public static string ImportFldToFieldTab(clsColumns objColumns, string strPrjId, string strUserId)
        {
            clsFieldTabENEx objFieldTabEN;

            objFieldTabEN = new clsFieldTabENEx();
            //工程ID
            objFieldTabEN.PrjId = strPrjId;
            if (objColumns.Type_Name == "bigint identity")
            {
                objColumns.Type_Name = "bigint";
            }
            clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBLEx.GetObjByName(objColumns.Type_Name);

            if (objDataTypeAbbrEN == null)
            {
                throw new Exception(string.Format("Sql Server中数据类型名:{0}不存在,请检查!", objColumns.Type_Name));
            }
            //检查是否存在相同的字段名
            if (clsFieldTabBLEx.IsExistSameFldName(strPrjId, objColumns.Column_Name, objDataTypeAbbrEN.DataTypeId) == true)
            {
                objFieldTabEN.FldId = clsFieldTabBLEx.GetFldId(strPrjId, objColumns.Column_Name, objDataTypeAbbrEN.DataTypeId);
            }
            else
            {
                objFieldTabEN.FldId = clsGeneralTab.GetMaxStrId("FieldTab", "FldId", 8, strPrjId);
                objFieldTabEN.FldName = objColumns.Column_Name;
                //转换类型名称

                //clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBLEx.GetDataTypeAbbrObjByName(objColumns.Type_Name);
                //List<string> arrID = new List<string>();
                //arrID = clsDataTypeAbbrBL.GetPrimaryKeyID_S("DataTypeName = '" + objColumns.Type_Name + "'");
                //if (arrID.Count  ==  0)
                //{
                //    throw new Exception(string.Format("Sql Server中数据类型名:{0}不存在,请检查!", objColumns.Type_Name));
                //}

                objFieldTabEN.DataTypeId = objDataTypeAbbrEN.DataTypeId;
                objFieldTabEN.IsNull = (objColumns.Is_Nullable == "YES");
                objFieldTabEN.IsPrimaryKey = false;
                objFieldTabEN.FldLength = objColumns.length;
                objFieldTabEN.FldPrecision = objColumns.PRECISION;
                objFieldTabEN.Caption = objColumns.Column_Name;
                objFieldTabEN.IsOnlyOne = false;
                objFieldTabEN.FldStateId = "01";
                objFieldTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objFieldTabEN.UpdUser = strUserId;

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



        public static string AddNewRec(string strFldName, string strCaption, string strDataTypeId, int intFldLength, int intFldPrecision, bool bolIsNull, string strPrjId, string strUpdUser)
        {
            clsFieldTabENEx objFieldTabEN;
            objFieldTabEN = new clsFieldTabENEx();

            //clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBLEx.GetObjByDataTypeNameCache(strTypeName);

            //if (objDataTypeAbbrEN == null)
            //{
            //    throw new Exception(string.Format("Sql Server中数据类型名:{0}不存在,请检查!", strTypeName));
            //}
            //工程ID
            objFieldTabEN.PrjId = strPrjId;
            //检查是否存在相同的字段名
            if (IsExistSameFldName(strPrjId, strFldName, strDataTypeId) == true)
            {
                objFieldTabEN.FldId = GetFldId(strPrjId, strFldName, strDataTypeId);
                //clsFldObjTabBLEx.CreateFldObjRelation(strObjId, objFieldTabEN.FldId);
            }
            else
            {
                objFieldTabEN.FldId = clsGeneralTab.GetMaxStrId("FieldTab", "FldId", 8, strPrjId);
                objFieldTabEN.FldName = strFldName;
                //转换类型名称
                List<string> arrID = new List<string>();

                //if (strTypeName == "bigint identity") strTypeName = "bigint";
                //if (strTypeName == "int identity") strTypeName = "int";

                objFieldTabEN.DataTypeId = strDataTypeId;
                objFieldTabEN.IsNull = bolIsNull;
                objFieldTabEN.IsPrimaryKey = false;
                objFieldTabEN.FldLength = intFldLength;
                objFieldTabEN.FldPrecision = intFldPrecision;
                objFieldTabEN.Caption = strCaption;
                objFieldTabEN.IsOnlyOne = false;
                objFieldTabEN.FldStateId = "01";
                objFieldTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                objFieldTabEN.UpdUser = strUpdUser;
                if (AddNewRecordEx(objFieldTabEN) == false)
                {
                    string strMsg = string.Format("添加字段：{0}不成功！({1})", strFldName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //clsFldObjTabBLEx.CreateFldObjRelation(strObjId, objFieldTabEN.FldId);
                    //  throw new Exception("添加记录成功!");
                }

            }
            return objFieldTabEN.FldId;
        }

        /// <summary>
        /// 功能:从一个工程(源工程)复制一组字段到新工程中。
        /// </summary>
        /// <param name = "strSouPrjId">源工程</param>
        /// <param name = "strTarPrjId">目标工程</param>
        /// <param name = "strSouFldId">源字段Id</param>
        /// <param name = "strUserId">当前用户ID</param>
        /// <returns>新工程中字段ID</returns>
        public static string CopyField(string strSouPrjId, string strTarPrjId, string strSouFldId, string strUserId)
        {
            //操作步骤:
            //1、根据<源字段ID>新建一个字段对象。并且获取该字段对象的所有属性。
            //2、检查是否存在相同的字段名,
            //		2.1 如果存在就获取相同字段名的<字段ID>,退出返回；
            //3、建立一个新字段对象；
            //4、为新字段对象设置FldId值,即新工程中字段ID的最大值；
            //5、把源字段对象的所有属性都复制到新字段对象中。
            //6、返回新字段ID
            //
            string strTarFldId = "";        //目标字段ID,即新工程中字段ID
            clsFieldTabENEx objSouFieldTab;//, objTarFieldTab;
            objSouFieldTab = clsFieldTabBLEx.GetObjExByFldIDCache(strSouFldId, strSouPrjId);
            if (objSouFieldTab == null) return "";


            //2、检查是否存在相同的字段名,如果存在就退出返回；
            string strCondition = string.Format("PrjId = '{0}' And FldName = '{1}' And DataTypeId = '{2}'", strTarPrjId, objSouFieldTab.FldName, objSouFieldTab.DataTypeId);
            clsvFieldTabEN objvFieldTabEN = clsvFieldTabBL.GetFirstObj_S(strCondition);
            if (objvFieldTabEN != null)
            {
                //if (objvFieldTabEN.ObjNum == 0)
                //{
                //    objSouFieldTab.FldId = objvFieldTabEN.FldId;
                //    objSouFieldTab.PrjId = strTarPrjId;
                //    clsFieldTabBL.UpdateWithCondition(objSouFieldTab, strCondition);
                //}
                strTarFldId = objvFieldTabEN.FldId;
                return strTarFldId;
            }
            else
            {
                //objTarFieldTab = new clsFieldTabENEx();
                strTarFldId = clsGeneralTab.GetMaxStrId("FieldTab", "FldId", 8, strTarPrjId);
                objSouFieldTab.FldId = strTarFldId;
                objSouFieldTab.PrjId = strTarPrjId;

                objSouFieldTab.UpdUser = strUserId;


                objSouFieldTab.UpdDate = clsDateTime.getTodayStr(0);
                if (objSouFieldTab.AddRecordEx() == false)
                {
                    throw new Exception("添加不成功!");
                }
                else
                {
                    return strTarFldId;
                    //                    throw new Exception("添加记录成功!");
                }

            }

        }

        /// <summary>
        /// 功能:根据工程名(strPrjId)和字段名称(strFldName)获取相应的字段ID
        /// </summary>
        /// <param name = "strPrjId">工程ID</param>
        /// <param name = "strFldName">字段名称</param>
        /// <param name = "strFldTypeId">字段类型Id</param>
        /// <returns>字段ID</returns>
        public static string GetFldId(string strPrjId, string strFldName, string strFldTypeId)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("PrjId = '{0}' and FldName = '{1}' And DataTypeId = '{2}'", strPrjId, strFldName, strFldTypeId);
            List<string> arrFldId = clsGeneralTab2.funGetFldValue("FieldTab", "FldId", strCondition.ToString());
            if (arrFldId == null || arrFldId.Count == 0)
            {
                return "";
            }
            return arrFldId[0].ToString();
        }


        /// <summary>
        /// 功能:把源工程的一个对象复制到新工程中,同时复制该对象相关的字段。
        /// </summary>
        /// <param name = "strUserId">源工程ID</param>
        /// <param name = "strTarPrjId">目标工程ID</param>
        /// <param name = "strSouTabId">源表ID</param>
        /// <returns>返回在目标工程中的新表ID</returns>
        public static string CopyPrjTab(string strTarPrjId, string strSouTabId, string strUserId)
        {
            //操作步骤:
            //1、对源工程中的源表ID进行操作
            //2、根据<表ID>获取所有属性
            //3、根据当前<表ID>的属性<表名(TabName)>检查是否在目标工程中存在相同的<表名>。
            //    如果存在相同的<表名>就放弃该表名,不需要复制。
            //4、复制源表的相关对象到新工程中。
            //5、把当前<工程表>复制 到新工程中。
            //  5.1 在目标工程中新建一个<工程表>记录
            //  5.2 把当前<工程表>的属性都复制到新建的<工程表>记录中
            //  5.3 当新建<工程表>记录添加到数据库中；
            //6、获取当前<工程表>记录的相关字段列表；
            //7、对该表进行循环,把字段ID(源字段ID)插入到一个ArrayList
            //8、把这组源字段ID列表从源工程中复制到目标工程中,同时获取一组插入到目标工程中的字段ID列表
            //9、把获取的一组新字段ID列表复制到<工程表字段>表中。
            //

            string strSouFldId, strTarFldId;    //源字段ID,目标字段ID
            System.Data.DataTable objDT_SouTabFld;      //, objDT_Tab;
            ArrayList arrTabFld = new ArrayList();
            //			ArrayList arrTarFldId;
            clsPrjTabEN objSouPrjTab = null;
            clsPrjTabEN objNewPrjTab = null;

            string strNewTabId = "";
            //1、对源工程中的源对象ID进行操作
            //2、根据<表ID>获取所有属性
            objSouPrjTab = clsPrjTabBL.GetObjByTabId(strSouTabId);

            //3、根据当前<表ID>的属性<表名(TabName)>检查是否在目标工程中存在相同的<表名>。
            //    如果存在相同的<表名>就放弃该表名,不需要复制。
            if (clsPrjTabBL.IsExistRecord("PrjId = '" + strTarPrjId + "' and TabName = '" + objSouPrjTab.TabName + "'") == true)
            {
                strNewTabId = clsPrjTabBLEx.GetTabId(strTarPrjId, objSouPrjTab.TabName);
                return strNewTabId;
            }
            string strFuncModuleId_S = objSouPrjTab.FuncModuleAgcId;
            string strFuncModuleId_T = "";
            if (string.IsNullOrEmpty(strFuncModuleId_S) == false)
            {
                clsFuncModule_AgcEN objFuncModuleEN_S = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(strFuncModuleId_S, objSouPrjTab.PrjId);
                string strCondition = string.Format("FuncModuleName = '{0}' And PrjId = '{1}' ",
                  objFuncModuleEN_S.FuncModuleName, strTarPrjId);
                clsFuncModule_AgcEN objFuncModuleEN_T = clsFuncModule_AgcBL.GetFirstObj_S(strCondition);
                if (objFuncModuleEN_T == null)
                {
                    clsFuncModule_AgcBL.CopyTo(objFuncModuleEN_S, objFuncModuleEN_T);
                    objFuncModuleEN_T.FuncModuleAgcId = clsFuncModule_AgcBLEx.GetMaxStrIdEx_S(strTarPrjId);
                    objFuncModuleEN_T.PrjId = strTarPrjId;
                    objFuncModuleEN_T.UpdDate = clsDateTime.getTodayDateTimeStr(1);
                    objFuncModuleEN_T.UpdUser = strUserId;
                    objFuncModuleEN_T.Memo = "在复制表时生成模块名称!";
                    clsFuncModule_AgcBL.AddNewRecordBySql2(objFuncModuleEN_T);
                }
                strFuncModuleId_T = objFuncModuleEN_T.FuncModuleAgcId;
            }

            //4、复制源表的相关对象到新工程中。
            //strSouObjId = objSouPrjTab.ObjId;
            //strTarObjId = clsPrjObjectsBLEx.CopyObject(objSouPrjTab.PrjId, strTarPrjId, strSouObjId, strFuncModuleId_T, strUserId);
            //5、把当前<工程表>复制 到新工程中。
            //  5.1 在目标工程中新建一个<工程表>记录
            strNewTabId = clsGeneralTab.GetMaxStrId("PrjTab", "TabId", 8, strTarPrjId);
            objNewPrjTab = new clsPrjTabEN(strNewTabId);
            //  5.2 把当前<工程表>的属性都复制到新建的<工程表>记录中
            //			objNewPrjTab.UserId = strUserId;
            objNewPrjTab.PrjId = strTarPrjId;
            objNewPrjTab.TabCnName = objSouPrjTab.TabCnName;
            //			objNewPrjTab.TabKeyFldName = objSouPrjTab.TabKeyFldName;//只读属性,不能修改
            objNewPrjTab.TabName = objSouPrjTab.TabName;
            //objNewPrjTab.ObjId = strTarObjId;
            objNewPrjTab.TabStateId = objSouPrjTab.TabStateId;
            //新数据表的数据库名,默认的数据库名使用目标工程相关的数据库名
            objNewPrjTab.DataBaseName = objSouPrjTab.DataBaseName;
            //			objNewPrjTab.TabName_Curr = objSouPrjTab.TabName_Curr;	//只读属性,不能修改
            objNewPrjTab.TabNameB = objSouPrjTab.TabNameB;
            objNewPrjTab.TabName = objSouPrjTab.TabName;
            objNewPrjTab.SqlDsTypeId = objSouPrjTab.SqlDsTypeId;
            objNewPrjTab.IsReleToSqlTab = objSouPrjTab.IsReleToSqlTab;
            objNewPrjTab.TabTypeId = "0001";
            objNewPrjTab.FuncModuleAgcId = strFuncModuleId_T;
            objNewPrjTab.UpdDate = clsDateTime_Db.GetDataBaseDateTime14();
            objNewPrjTab.UpdUserId = strUserId;
            objNewPrjTab.Memo = objSouPrjTab.Memo;
            objNewPrjTab.IsUseCache = objSouPrjTab.IsUseCache;

            //  5.3 当新建<工程表>记录添加到数据库中；
            if (clsPrjTabBL.AddNewRecordBySql2(objNewPrjTab) == false)
            {
                return "";
            }
            else
            {
                //					strResult = "添加记录成功!";
            }

            //6、获取当前<工程表>记录的相关字段列表；
            objDT_SouTabFld = clsPrjTabFldBL.GetDataTable_PrjTabFld("TabId = '" + strSouTabId + "'");
            //7、对该表进行循环,把字段ID(源字段ID)依次进行处理,插入到目标工程中,

            foreach (DataRow objRow in objDT_SouTabFld.Rows)
            {
                strSouFldId = objRow["FldId"].ToString();
                //8、把源字段ID列表从源工程中复制到目标工程中,同时获取一个插入到目标工程中的字段ID
                strTarFldId = clsFieldTabBLEx.CopyField(objSouPrjTab.PrjId, strTarPrjId, strSouFldId, strUserId);
                //9、把获取的一个新字段ID列表添加到目标工程中的<工程表字段>表中。
                clsPrjTabFldBLEx.CopyPrjTabFld(objSouPrjTab.PrjId, strTarPrjId, strSouTabId, strNewTabId, strSouFldId, strTarFldId);
            }
            return strNewTabId;
        }


        /// <summary>
        /// 功能:从一个工程(源工程)复制一组字段到新工程中。
        /// </summary>
        /// <param name = "strSouPrjId">源工程</param>
        /// <param name = "strTarPrjId">目标工程</param>
        /// <param name = "arrSouFldId">源字段列表</param>
        /// <param name = "strUserId">当前用户ID</param>
        /// <returns>返回一组在目标工程中的字段ID</returns>
        public static ArrayList CopyField(string strSouPrjId, string strTarPrjId, ArrayList arrSouFldId, string strUserId)
        {
            //操作步骤:
            //1、对源字段列表进行遍历
            //2、把每个代表字段的字段ID插入到目标工程中
            //3、把插入到目标工程的字段ID添加到ArrayList；
            //4、返回一组在目标工程中的字段ID；
            //
            ArrayList arrTarFldId = new ArrayList();
            string strTarFldId;

            //1、对源字段列表进行遍历
            foreach (string strSouFldId in arrSouFldId)
            {
                //2、把每个代表字段的字段ID插入到目标工程中
                strTarFldId = CopyField(strSouPrjId, strTarPrjId, strSouFldId, strUserId);
                if (strTarFldId != "")
                {
                    //3、把插入到目标工程的字段ID添加到ArrayList；
                    arrTarFldId.Add(strTarFldId);
                }
            }
            //4、返回一组在目标工程中的字段ID；
            return arrTarFldId;
        }

        /////导入字段到表FieldTab中
        //public static void ImportFldToFieldTab(string strFldName, string strCaption, string strTypeName, int intFldLength, int intFldPrecision, bool bolIsNull, string strObjId, string strPrjId)
        //{
        //  clsFieldTabENEx objFieldTabEN;
        //  objFieldTabEN = new clsFieldTabENEx();

        //  clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBLEx.GetDataTypeAbbrObjByName(strTypeName);

        //  if (objDataTypeAbbrEN == null)
        //  {
        //    throw new Exception(string.Format("Sql Server中数据类型名:{0}不存在,请检查!", strTypeName));
        //  }
        //  ///工程ID
        //  objFieldTabEN.PrjId = strPrjId;
        //  ///检查是否存在相同的字段名
        //  if (clsFieldTabBLEx.IsExistSameFldName(strPrjId, strFldName, objDataTypeAbbrEN.DataTypeId) == true)
        //  {
        //    objFieldTabEN.FldId = clsFieldTabBLEx.GetFldId(strPrjId, strFldName, objDataTypeAbbrEN.DataTypeId);
        //    clsFldObjTabBLEx.CreateFldObjRelation(strObjId, objFieldTabEN.FldId);
        //  }
        //  else
        //  {
        //    objFieldTabEN.FldId = clsGeneralTab.GetMaxStrId("FieldTab", "FldId", 8, strPrjId);
        //    objFieldTabEN.FldName = strFldName;
        //    ///转换类型名称
        //    List<string> arrID = new List<string>();

        //    if (strTypeName == "bigint identity") strTypeName = "bigint";
        //    if (strTypeName == "int identity") strTypeName = "int";


        //    objFieldTabEN.DataTypeId = objDataTypeAbbrEN.DataTypeId;
        //    objFieldTabEN.IsNull = bolIsNull;
        //    objFieldTabEN.IsPrimaryKey = false;
        //    objFieldTabEN.FldLength = intFldLength;
        //    objFieldTabEN.FldPrecision = intFldPrecision;
        //    objFieldTabEN.Caption = strCaption;
        //    objFieldTabEN.IsOnlyOne = false;
        //    objFieldTabEN.FldStateId = "01";
        //    if (objFieldTabEN.AddNewRecordEx() == false)
        //    {

        //      strResult = "添加不成功!";
        //    }
        //    else
        //    {
        //      strResult = "添加记录成功!";
        //    }
        //    clsFldObjTabBLEx.CreateFldObjRelation(strObjId, objFieldTabEN.FldId);
        //  }

        //}
        public static System.Data.DataTable GetFldID(string strPrjId)
        {
            //获取某学院所有专业信息
            string strSQL = string.Format("select FldId, FldName from FieldTab where {0} = '{1}' Order by {2}",
              conFieldTab.PrjId, strPrjId,
              conFieldTab.FldName);
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static System.Data.DataTable GetFldID4Root(string strPrjId)
        {
            //获取某学院所有专业信息
            string strSQL = string.Format("select FldId, FldName from FieldTab where {0} = '{1}' And {2}='1' Order by {3}",
              conFieldTab.PrjId, strPrjId,
              conFieldTab4RootFld.IsRootFld,
              conFieldTab.FldName);
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindDdl_FldIDEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetFldID(strPrjId);
            objDDL.DataValueField = "FldId";
            objDDL.DataTextField = "FldName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static void BindDdl_FldIdByTabIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId, string strTabId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("选[字段]...", "0");

            IEnumerable<clsPrjTabFldEN> arrObjLst = clsPrjTabFldBLEx.GetObjLstByTabIdCache( strTabId, strPrjId);
            
            var arrFieldTab = arrObjLst.Select(x=>clsFieldTabBL.GetObjByFldIdCache(x.FldId, strPrjId));
            arrFieldTab = arrFieldTab.OrderBy(x => x.FldName);
            objDDL.DataValueField = conFieldTab.FldId;
            objDDL.DataTextField = conFieldTab.FldName;
            objDDL.DataSource = arrFieldTab;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static void BindDdl_FldIdByCmPrjIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId, string strCmPrjId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("选[字段]...", "0");

            List<clsFieldTabEN> arrFieldTabObjLst = clsFieldTabBL.GetObjLstCache(strPrjId);
            List<string> arrTabId = clsCmProjectPrjTabBLEx.GetTabIdLstCache(strCmPrjId);

            IEnumerable<clsvPrjTabFld_SimEN> arrPrjTabFldObjLst = clsvPrjTabFld_SimBL.GetObjLstCache(strPrjId).Where(x=>arrTabId.Contains(x.TabId));
            var arrFldId = arrPrjTabFldObjLst.Select(x=>x.FldId).ToList();

            var arrFieldTab_Sel = arrFieldTabObjLst.Where(x => arrFldId.Contains(x.FldId)).OrderBy(x=>x.FldName);

            objDDL.DataValueField = conFieldTab.FldId;
            objDDL.DataTextField = conFieldTab.FldName;
            objDDL.DataSource = arrFieldTab_Sel;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static void BindDdl_FldIDByTabIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId, string strTabId, List<string> arrFldId_Exclude = null)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("选[字段]...", "0");

            IEnumerable<clsvPrjTabFldEN> arrObjLst = clsvPrjTabFldBLEx.GetObjLstByTabIdCache0(strTabId, strPrjId).OrderBy(x => x.SequenceNumber);
            
            if (arrFldId_Exclude != null)
            {
                arrObjLst = arrObjLst.Where(x => arrFldId_Exclude.Contains(x.FldId) == false);
            }

            List<clsvPrjTabFldEN> arrObjLst_Sel = arrObjLst.ToList();
            //arrObjLst_Sel.ForEach( x => x.FldName = string.Format("{0}({1})({2})", x.FldName, x.Caption, clsFieldTypeBL.GetNameByFieldTypeIdCache(x.FieldTypeId)));

            foreach (clsvPrjTabFldEN objInFor in arrObjLst_Sel)
            {
                
                string strName = clsFieldTypeBL.GetNameByFieldTypeIdCache(objInFor.FieldTypeId);
                objInFor._StrTag = string.Format("{0}({1})", objInFor.FldName, strName);
               
            }
            objDDL.DataValueField = "FldId";
            objDDL.DataTextField = "_StrTag";
            objDDL.DataSource = arrObjLst_Sel;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static void BindDdl_FldID4RootEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            ListItem li = new ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetFldID4Root(strPrjId);
            objDDL.DataValueField = "FldId";
            objDDL.DataTextField = "FldName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        //public static void RefreshCache()
        //{

        //    //clsFieldTabBL.arrFieldTabObjLstCache = null;
        //    clsFieldTabBLEx.arrFieldTabENExObjLst4WinApp = null;
        //    clsFieldTabBLEx.arrFieldTabENExObjLstOrderByFldIdCache = null;

        //}

        /// <summary>
        /// 同步满足条件的记录，从Client到Server
        /// </summary>
        /// <param name="strCondition">同步的条件</param>
        /// <param name="strOpUserId">操作同步的用户</param>
        /// <returns></returns>
        //public static int SynchToServerByCondition(string strCondition, string strOpUserId)
        //{

        //    if (string.IsNullOrEmpty(strOpUserId) == true)
        //    {
        //        throw new Exception("同步到服务端时，同步人不能为空！");
        //    }
        //    int intCount = 0;

        //    string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();
        //    clsSysParaEN.strConnectStrName = "ConnectionStringClient";

        //    List<clsFieldTabEN> arrFieldTabENObjLst = clsFieldTabBL.GetObjLst(strCondition);

        //    foreach (clsFieldTabEN objFieldTabEN4Web in arrFieldTabENObjLst)
        //    {
        //        //如果这条记录的来源就是Server,就不需要同步了
        //        if (objFieldTabEN4Web.SynSource == "Server") continue;
        //        objFieldTabEN4Web.IsSynchToServer = true;
        //        objFieldTabEN4Web.SynchToServerDate = strCurrDate14;
        //        objFieldTabEN4Web.SynchToServerUser = strOpUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionString";

        //        objFieldTabEN4Web.SynSource = "Client";
        //        try
        //        {
        //            strCondition = objFieldTabEN4Web.GetUniquenessConditionString();
        //            clsFieldTabEN objFieldTab_Target = clsFieldTabBL.GetFirstObj_S(strCondition);
        //            if (objFieldTab_Target != null)
        //            {
        //                int intResult = (objFieldTab_Target.UpdDate.CompareTo(objFieldTabEN4Web.UpdDate));
        //                if (intResult < 0)
        //                {
        //                    objFieldTabEN4Web.UpdateWithCondition(strCondition);
        //                }
        //            }
        //            else
        //            {
        //                objFieldTabEN4Web.FldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(objFieldTabEN4Web.PrjId);
        //                objFieldTabEN4Web.AddRecordEx();
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionStringClient";
        //            objFieldTabEN4Web.UpdateRecordEx();
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Server端时，字段表：{0}({1})时出错。({3}).[上级抛错:{2}]",
        //                        clsFieldTabEN._CurrTabName,
        //                        objFieldTabEN4Web.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}

        /// <summary>
        /// 同步满足条件的记录，从Client到Server
        /// </summary>
        /// <param name="strFldId">同步的条件</param>
        /// <param name="strOpUserId">操作同步的用户</param>
        /// <returns></returns>
        //public static int SynchToServerByFldId(string strFldId, string strOpUserId)
        //{

        //    if (string.IsNullOrEmpty(strOpUserId) == true)
        //    {
        //        throw new Exception("同步到服务端时，同步人不能为空！");
        //    }
        //    int intCount = 0;

        //    string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();
        //    clsSysParaEN.strConnectStrName = "ConnectionStringClient";

        //    clsFieldTabEN objFieldTabEN4Client = clsFieldTabBL.GetObjByFldId(strFldId);


        //    //如果这条记录的来源就是Server,就不需要同步了
        //    if (objFieldTabEN4Client.SynSource == "Server") return 0;
        //    objFieldTabEN4Client.IsSynchToServer = true;
        //    objFieldTabEN4Client.SynchToServerDate = strCurrDate14;
        //    objFieldTabEN4Client.SynchToServerUser = strOpUserId;
        //    clsSysParaEN.strConnectStrName = "ConnectionString";

        //    objFieldTabEN4Client.SynSource = "Client";
        //    try
        //    {
        //        clsFieldTabEN objFieldTab_Target = clsFieldTabBL.GetObjByFldId(objFieldTabEN4Client.FldId);
        //        if (objFieldTab_Target != null)
        //        {
        //            int intResult = (objFieldTab_Target.UpdDate.CompareTo(objFieldTabEN4Client.UpdDate));
        //            if (intResult < 0)
        //            {
        //                objFieldTabEN4Client.UpdateRecordEx();
        //            }
        //        }
        //        else
        //        {
        //            objFieldTabEN4Client.AddRecordEx();
        //        }

        //        clsSysParaEN.strConnectStrName = "ConnectionStringClient";
        //        objFieldTabEN4Client.UpdateRecordEx();
        //    }
        //    catch (Exception objException)
        //    {
        //        StringBuilder sbMsg = new StringBuilder();
        //        sbMsg.AppendFormat("在同步到Server端时，字段表：{0}({1})时出错。({3}).[上级抛错:{2}]",
        //                    clsFieldTabEN._CurrTabName,
        //                    objFieldTabEN4Client.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(sbMsg.ToString());
        //    }

        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}


        /// <summary>
        /// 同步满足条件的记录，从Server到Client
        /// </summary>
        /// <param name="strCondition">同步的条件</param>
        /// <param name="strOpUserId">操作同步的用户</param>
        /// <returns></returns>
        //public static int SynchToClientByCondition(string strCondition, string strOpUserId)
        //{
        //    if (string.IsNullOrEmpty(strOpUserId) == true)
        //    {
        //        throw new Exception("上传到Client库时，同步人不能为空！");
        //    }
        //    int intCount = 0;
        //    string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();
        //    clsSysParaEN.strConnectStrName = "ConnectionString";

        //    List<clsFieldTabEN> arrFieldTabENObjLst = clsFieldTabBL.GetObjLst(strCondition);

        //    foreach (clsFieldTabEN objFieldTabEN4Main in arrFieldTabENObjLst)
        //    {
        //        //如果这条记录的来源就是Client,就不需要同步了
        //        if (objFieldTabEN4Main.SynSource == "Client") continue;
        //        objFieldTabEN4Main.IsSynchToClient = true;
        //        objFieldTabEN4Main.SynchToClientDate = strCurrDate14;
        //        objFieldTabEN4Main.SynchToClientUser = strOpUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionStringClient";

        //        try
        //        {
        //            clsFieldTabEN objFieldTabEN4Main2 = new clsFieldTabEN();
        //            clsFieldTabBL.CopyTo(objFieldTabEN4Main, objFieldTabEN4Main2);
        //            objFieldTabEN4Main2.SynSource = "Server";
        //            strCondition = objFieldTabEN4Main.GetUniquenessConditionString();
        //            clsFieldTabEN objFieldTab_Target = clsFieldTabBL.GetFirstObj_S(strCondition);

        //            if (objFieldTab_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objFieldTab_Target.UpdDate.CompareTo(objFieldTabEN4Main.UpdDate);
        //                if (intResult < 0)
        //                {

        //                    objFieldTabEN4Main2.UpdateWithCondition(strCondition);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                objFieldTabEN4Main2.FldId = clsFieldTabBL.GetMaxStrIdByPrefix_S(objFieldTabEN4Main2.PrjId);
        //                objFieldTabEN4Main2.AddRecordEx();
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionString";
        //            objFieldTabEN4Main.UpdateRecordEx();
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Client库，字段表：{0}({1})时出错。({3}).[上级抛错:{2}]", objFieldTabEN4Main.FldId,
        //                        objFieldTabEN4Main.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}


        /// <summary>
        /// 同步关键字Id的记录，从Server到Client
        /// </summary>
        /// <param name="strFldId">关键字Id</param>
        /// <param name="strOpUserId">操作同步的用户</param>
        /// <returns></returns>
        //public static int SynchToClientByFldId(string strFldId, string strOpUserId)
        //{
        //    if (string.IsNullOrEmpty(strOpUserId) == true)
        //    {
        //        throw new Exception("上传到Client库时，同步人不能为空！");
        //    }
        //    int intCount = 0;
        //    string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();
        //    clsSysParaEN.strConnectStrName = "ConnectionString";

        //    clsFieldTabEN objFieldTabEN4Main = clsFieldTabBL.GetObjByFldId(strFldId);


        //    //如果这条记录的来源就是Client,就不需要同步了
        //    if (objFieldTabEN4Main.SynSource == "Client") return 0;
        //    objFieldTabEN4Main.IsSynchToClient = true;
        //    objFieldTabEN4Main.SynchToClientDate = strCurrDate14;
        //    objFieldTabEN4Main.SynchToClientUser = strOpUserId;
        //    clsSysParaEN.strConnectStrName = "ConnectionStringClient";

        //    try
        //    {
        //        clsFieldTabEN objFieldTabEN4Main2 = new clsFieldTabEN();
        //        clsFieldTabBL.CopyTo(objFieldTabEN4Main, objFieldTabEN4Main2);
        //        objFieldTabEN4Main2.SynSource = "Server";
        //        clsFieldTabEN objFieldTab_Target = clsFieldTabBL.GetObjByFldId(objFieldTabEN4Main.FldId);

        //        if (objFieldTab_Target != null)
        //        {
        //            //如果目标地的对象日期小于来源对象的日期就更新
        //            int intResult = objFieldTab_Target.UpdDate.CompareTo(objFieldTabEN4Main.UpdDate);
        //            if (intResult < 0)
        //            {

        //                objFieldTabEN4Main2.UpdateRecordEx();
        //                intCount++;
        //            }
        //        }
        //        else
        //        {

        //            objFieldTabEN4Main2.AddRecordEx();
        //            intCount++;
        //        }

        //        clsSysParaEN.strConnectStrName = "ConnectionString";
        //        objFieldTabEN4Main.UpdateRecordEx();
        //    }
        //    catch (Exception objException)
        //    {
        //        StringBuilder sbMsg = new StringBuilder();
        //        sbMsg.AppendFormat("在同步到Client库，字段表：{0}({1})时出错。({3}).[上级抛错:{2}]", objFieldTabEN4Main.FldId,
        //                    objFieldTabEN4Main.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(sbMsg.ToString());
        //    }

        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}

        public static clsFieldTabENEx InitFieldTab(string strFldId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strFldId))
                throw new clsDbObjException("字段ID为空,请检查!当前表为FieldTab,关键字为:" + strFldId);

            if (string.IsNullOrEmpty(strPrjId))
                throw new clsDbObjException("工程ID为空,请检查!当前表为FieldTab,关键字为:" + strFldId);

            clsFieldTabENEx objFieldTabENEx = clsFieldTabBLEx.GetObjExByFldIDCache(strFldId, strPrjId);
            if (objFieldTabENEx == null)
            {
                return null;
            }
            var objFieldTab4CodeConv = objFieldTabENEx.ObjFieldTab4CodeConv();
            if (objFieldTab4CodeConv != null)
            {
                try
                {
                    if (string.IsNullOrEmpty(objFieldTab4CodeConv.CodeTabId) == true)
                    {
                        string strMsg = string.Format("字段：{0}为转换字段，转换表为空，请检查！", objFieldTabENEx.FldName);
                        clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                    }
                    if (string.IsNullOrEmpty(objFieldTab4CodeConv.CodeTabNameId) == true)
                    {
                        string strMsg = string.Format("字段：{0}为转换字段，名称字段为空，请检查！", objFieldTabENEx.FldName);
                        clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                    }

                    if (string.IsNullOrEmpty(objFieldTab4CodeConv.CodeTabCodeId) == true)
                    {
                        string strMsg = string.Format("字段：{0}为转换字段，代码字段为空，请检查！", objFieldTabENEx.FldName);
                        clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);

                    }
                    if (objFieldTabENEx.FldName == "FeatureTypeId")
                    {
                        //string ss = "";
                    }
                    var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(
                        objFieldTab4CodeConv.CodeTabId, objFieldTabENEx.PrjId);
                    if (objPrjTab != null)
                    {
                        objFieldTabENEx.CodeTabName = objPrjTab.TabName;
                    }
                    var objFieldTab_NameId = clsFieldTabBL.GetObjByFldIdCache(
                                             objFieldTab4CodeConv.CodeTabNameId, objFieldTabENEx.PrjId);
                    if (objFieldTab_NameId != null)
                    {
                        objFieldTabENEx.CodeTabName = objFieldTab_NameId.FldName;
                    }
                    var objFieldTab_CodeId = clsFieldTabBL.GetObjByFldIdCache(
                                             objFieldTab4CodeConv.CodeTabCodeId,
                                             objFieldTabENEx.PrjId);
                    if (objFieldTab_CodeId != null)
                    {
                        objFieldTabENEx.CodeTabCode = objFieldTab_CodeId.FldName;
                    }
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("处理字段：{0}的转换字段属性时出错：{1}。({2})",
                        objFieldTabENEx.FldName, objException.Message, clsStackTrace.GetCurrClassFunction());
                    clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
                }
            }

            if (objFieldTabENEx == null)
            {
                throw new clsDbObjException("objFieldTabENEx为空,请检查!");
            }
            objFieldTabENEx.objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTabENEx.DataTypeId).CopyToEx();
            return objFieldTabENEx;
        }




        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsFieldTabDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsFieldTabDAEx FieldTabDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsFieldTabDAEx();
                }
                return uniqueInstanceEx;
            }
        }

    
        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsFieldTabENEx> GetObjExLst(string strCondition)
        {
            List<clsFieldTabEN> arrObjLst = clsFieldTabBL.GetObjLst(strCondition);
            List<clsFieldTabENEx> arrObjExLst = new List<clsFieldTabENEx>();
            foreach (clsFieldTabEN objInFor in arrObjLst)
            {
                clsFieldTabENEx objFieldTabENEx = new clsFieldTabENEx();
                clsFieldTabBL.CopyTo(objInFor, objFieldTabENEx);
                arrObjExLst.Add(objFieldTabENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strFldId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsFieldTabENEx GetObjExByFldId(string strFldId)
        {
            clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldId);
            if (objFieldTabEN == null) return null;
            clsFieldTabENEx objFieldTabENEx = new clsFieldTabENEx();
            clsFieldTabBL.CopyTo(objFieldTabEN, objFieldTabENEx);
            return objFieldTabENEx;
        }

        /// <summary>
        /// 加上对象名的私有属性名
        /// </summary>
        /// <param name = "objFieldTabENEx">objFieldTabENEx</param>
        /// <param name = "strObjName">对象名</param>
        /// <returns>返回的加上对象名的私有属性名</returns>
        public static string PrivPropNameWithObjectName(clsFieldTabENEx objFieldTabENEx, string strObjName, bool bolIsFstLcase)
        {
            return strObjName + "." + objFieldTabENEx.PropertyName(bolIsFstLcase);
        }

        /// <summary>
        /// 加上对象名的私有属性名
        /// </summary>
        /// <param name = "objPrjTabFldENEx">objPrjTabFldENEx</param>
        /// <param name = "strObjName">对象名</param>
        /// <returns>返回的加上对象名的私有属性名</returns>
        public static string PrivPropNameWithObjectName(clsPrjTabFldENEx objPrjTabFldENEx, string strObjName, bool bolIsFstLcase)
        {
            return strObjName + "." + objPrjTabFldENEx.ObjFieldTabENEx.PropertyName(bolIsFstLcase);
        }

        /// <summary>
        /// 加上对象名的私有属性名,专业针对Get属性函数
        /// </summary>
        /// <param name = "objFieldTabENEx">objFieldTabENEx</param>
        /// <param name = "strObjName">对象名</param>
        /// <returns>返回的加上对象名的私有属性名</returns>
        public static string PrivPropNameWithObjectName4Get1(clsFieldTabENEx objFieldTabENEx, string strObjName)
        {
            return strObjName + ".Get" + objFieldTabENEx.FldName + "()";
        }

        public static string PrivPropNameWithObjectName4Get(clsPrjTabFldENEx objPrjTabFldENEx, string strObjName)
        {
            return strObjName + ".Get" + objPrjTabFldENEx.ObjFieldTabENEx.FldName + "()";
        }
        /// <summary>
        /// 功能:获取某一条件的DataTable,其中的代码转换成相应的名称
        /// </summary>
        /// <param name = "strCondition">条件串</param>
        /// <returns>返回已经转换代码的DataTable</returns>
        public static System.Data.DataTable GetFieldTabTEx(string strCondition)
        {
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            strSQL.Append("Select * ");
            strSQL.Append(" from vFieldTab ");
            strSQL.Append(" where " + strCondition);
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }


        /// <summary>
        /// 是否能够删除和修改
        /// </summary>
        /// <param name = "strFldId">字段ID</param>
        /// <returns></returns>
        //public static bool IsCanDelUpd(string strFldId)
        //{
        //  bool bolIsArchive = clsFieldTabBL.GetObjByFldId(strFldId).IsArchive;
        //  if (bolIsArchive == true) return false;
        //  bool bolIsChecked = clsFieldTabBL.GetObjByFldId(strFldId).IsChecked;
        //  return !bolIsChecked;
        //}
        //同时删除多条记录
        //public static bool DelFieldTabEx(List<string> lstKey)
        //{
        //  clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
        //  string strSQL;
        //  bool bolIsFirstItem = true;
        //  string strKeyList;
        //  if (lstKey.Count == 0) return true;
        //  strKeyList = "";
        //  for (int i = 0; i < lstKey.Count; i++)
        //  {
        //    if (IsCanDelUpd(lstKey[i].ToString()) == false) continue;
        //    if (bolIsFirstItem == true)
        //    {
        //      strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
        //      bolIsFirstItem = false;
        //    }
        //    else strKeyList += ", " + "'" + lstKey[i].ToString() + "'";
        //  }
        //  if (strKeyList == "") return true;
        //  //删除相关的工程表字段
        //  List<string> arrRelaMid = clsPrjTabFldBL.GetPrimaryKeyID_S("FldId in (" + strKeyList + ")");
        //  if (arrRelaMid != null)
        //  {
        //    foreach (string strMid in arrRelaMid)
        //    {
        //      long lngMid = long.Parse(strMid);
        //      clsPrjTabFldBLEx.DelRecordEx(lngMid);
        //    }
        //  }
        //  strSQL = "";
        //  //删除与FieldTab表有关的外键表中的内容
        //  //			strSQL = strSQL + "Delete FldObjTab where FldId in (" + strKeyList + ")";
        //  strSQL = strSQL + "Delete EditRegionFlds where DsDataValueFieldId in (" + strKeyList + ")";
        //  //删除FieldTab本表中与当前对象有关的记录
        //  strSQL = strSQL + "Delete from FieldTab where FldId in (" + strKeyList + ")";
        //  bool bolResult = objSQL.ExecSql(strSQL);
        //  return bolResult;
        //}


        public static bool DelFieldTabBySP(string strFldId)
        {
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql();
            ArrayList arrValue = new ArrayList();
            arrValue.Add(strFldId);

            bool bolResult = objSQL.ExecSP2("DelTabField", arrValue);
            return bolResult;
        }



        /// <summary>
        /// 功能:获取当前日期的字符串
        /// 日期格式:
        ///  日期的字符串的格式有三种:
        ///		1、YYYYMMDD。	例如20050120
        ///		2、YYYY-MM-DD	例如2005-01-20
        ///		3、YYYY/MM/DD	例如2005/01/20
        /// </summary>
        /// <param name = "intFormat">日期格式,共有3种,传入参数0,1,2
        ///							参数不同,函数返回值就不同,
        ///							参见上面的日期格式
        ///	</param>
        /// <returns>返回当前日期的字符串</returns>
        public static string getTodayStr(int intFormat)
        {
            string strToday;
            string strYear, strMonth, strDay;
            int intYear, intMonth, intDay;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            intDay = System.DateTime.Today.Day;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();
            strToday = strYear + strMonth + strDay;
            switch (intFormat)
            {
                case 0:
                    strToday = strYear + strMonth + strDay;
                    break;
                case 1:
                    strToday = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case 2:
                    strToday = strYear + "/" + strMonth + "/" + strDay;
                    break;
            }
            return strToday;
        }
        //public static bool CheckFieldTab(string strFldId)
        //{
        //  clsFieldTabENEx objFieldTabEN = clsFieldTabBL.GetObjByFldId(strFldId);
        //  string strFieldTypeName = GetFldType(strFldId);
        //  if (strFieldTypeName == "char" || strFieldTypeName == "varchar")
        //  {
        //    if (objFieldTabEN.IsIdentity == true)
        //    {
        //      if (objFieldTabEN.Memo != "字符型字段不能定义成Identity主键!")
        //      {
        //        objFieldTabEN.Memo = "字符型字段不能定义成Identity主键!";
        //        objFieldTabEN.UpdateBySql();
        //      }
        //      return false;
        //    }
        //  }
        //  else if (objFieldTabEN.IsIdentity == true && objFieldTabEN.IsPrimaryKey == false)
        //  {
        //    if (objFieldTabEN.Memo == "作为Identity字段应该是主键字段!")
        //    {
        //      objFieldTabEN.Memo = "作为Identity字段应该是主键字段!";
        //      objFieldTabEN.UpdateBySql();
        //    }
        //    return false;
        //  }
        //  else if (objFieldTabEN.IsIdentity == true)
        //  {
        //    if (strFieldTypeName != "int" && strFieldTypeName != "bigint")
        //    {
        //      if (objFieldTabEN.Memo != "作为Identity字段应该是整型(int)或者长整型(bigint)!")
        //      {
        //        objFieldTabEN.Memo = "作为Identity字段应该是整型(int)或者长整型(bigint)!";
        //        objFieldTabEN.UpdateBySql();
        //      }
        //      return false;

        //    }
        //  }
        //  else if (objFieldTabEN.IsPrimaryKey == true)
        //  {
        //    if (strFieldTypeName != "int"
        //      && strFieldTypeName != "bigint"
        //      && strFieldTypeName != "char"
        //      && strFieldTypeName != "varchar"
        //     )
        //    {
        //      if (objFieldTabEN.Memo != "作为主键字段应该是(int,bigint,char,varchar)类型!")
        //      {
        //        objFieldTabEN.Memo = "作为主键字段应该是(int,bigint,char,varchar)类型!";
        //        objFieldTabEN.UpdateBySql();

        //      }
        //      return false;
        //    }
        //  }

        //  if (objFieldTabEN.Memo != "")
        //  {
        //    objFieldTabEN.Memo = "";
        //    objFieldTabEN.UpdateBySql();
        //    return true;
        //  }
        //  return true;
        //}

        /// <summary>
        /// 检查字段,专门针对代码表
        /// </summary>
        /// <param name = "strFldId">字段ID</param>
        /// <param name = "strPrjId">strPrjId</param>
        /// <returns>是否成功？</returns>
        public static bool CheckFieldTabByCodeTab(string strFldId, string strPrjId)
        {
            clsFieldTabENEx objFieldTabEN = clsFieldTabBLEx.GetObjExByFldIDCache(strFldId, strPrjId);
            var objFieldTab4CodeConv = objFieldTabEN.ObjFieldTab4CodeConv();
            if (objFieldTab4CodeConv == null) return true;
            if (string.IsNullOrEmpty(objFieldTab4CodeConv.CodeTabId) == true)
            {
                if (objFieldTabEN.Memo != "需要转换代码的字段的转换代码表不能为空!")
                {
                    objFieldTabEN.Memo = "需要转换代码的字段的转换代码表不能为空!";
                    objFieldTabEN.UpdateRecordEx();
                }
                return false;
            }


            if (string.IsNullOrEmpty(objFieldTab4CodeConv.CodeTabCodeId) == true)
            {
                if (objFieldTabEN.Memo != "需要转换代码的字段的转换代码表--代码不能为空!")
                {
                    objFieldTabEN.Memo = "需要转换代码的字段的转换代码表--代码不能为空!";
                    objFieldTabEN.UpdateRecordEx();
                }
                return false;
            }


            if (string.IsNullOrEmpty(objFieldTab4CodeConv.CodeTabNameId) == true)
            {
                if (objFieldTabEN.Memo != "需要转换代码的字段的转换代码表--名称不能为空!")
                {
                    objFieldTabEN.Memo = "需要转换代码的字段的转换代码表--名称不能为空!";
                    objFieldTabEN.UpdateRecordEx();
                }
                return false;
            }


            if (string.IsNullOrEmpty(objFieldTabEN.Memo) == true)
            {
                return true;
            }
            objFieldTabEN.Memo = objFieldTabEN.Memo.Replace("需要转换代码的字段的转换代码表不能为空!", "");
            objFieldTabEN.Memo = objFieldTabEN.Memo.Replace("需要转换代码的字段的转换代码表--代码不能为空!", "");
            objFieldTabEN.Memo = objFieldTabEN.Memo.Replace("需要转换代码的字段的转换代码表--名称不能为空!", "");
            objFieldTabEN.UpdateRecordEx();

            return true;
        }

        /// <summary>
        /// 检查字段
        /// </summary>
        /// <param name = "objFieldTabEN">需要检查的字段对象</param>
        /// <returns></returns>
        public static bool CheckFieldTabNnUpdate(clsFieldTabENEx objFieldTabEN)
        {
            string strFieldTypeName = clsDataTypeAbbrBLEx.GetDataTypeNameByDataTypeId(objFieldTabEN.DataTypeId);
            if (strFieldTypeName == "char" || strFieldTypeName == "varchar")
            {
                if (objFieldTabEN.IsIdentity == true)
                {
                    if (objFieldTabEN.Memo != "字符型字段不能定义成Identity主键!")
                    {
                        objFieldTabEN.Memo = "字符型字段不能定义成Identity主键!";
                        //            objFieldTabEN.Update();
                    }
                    return false;
                }
            }
            else if (objFieldTabEN.IsIdentity == true && objFieldTabEN.IsPrimaryKey == false)
            {
                if (objFieldTabEN.Memo == "作为Identity字段应该是主键字段!")
                {
                    objFieldTabEN.Memo = "作为Identity字段应该是主键字段!";
                    //objFieldTabEN.Update();
                }
                return false;
            }
            else if (objFieldTabEN.IsIdentity == true)
            {
                if (strFieldTypeName != "int" && strFieldTypeName != "bigint")
                {
                    if (objFieldTabEN.Memo != "作为Identity字段应该是整型(int)或者长整型(bigint)!")
                    {
                        objFieldTabEN.Memo = "作为Identity字段应该是整型(int)或者长整型(bigint)!";
                        //objFieldTabEN.Update();
                    }
                    return false;

                }
            }
            else if (objFieldTabEN.IsPrimaryKey == true)
            {
                if (strFieldTypeName != "int"
                  && strFieldTypeName != "bigint"
                  && strFieldTypeName != "char"
                  && strFieldTypeName != "varchar"
                 )
                {
                    if (objFieldTabEN.Memo != "作为主键字段应该是(int,bigint,char,varchar)类型!")
                    {
                        objFieldTabEN.Memo = "作为主键字段应该是(int,bigint,char,varchar)类型!";
                        //objFieldTabEN.Update();

                    }
                    return false;
                }
            }
            if (objFieldTabEN.Memo != "")
            {
                objFieldTabEN.Memo = "";
                //objFieldTabEN.Update();
                return true;
            }
            return true;
        }
        public static string GetFieldCnNameByFieldName(string strPrjId, string strTabName, string strFieldName)
        {
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("PrjId = '{0}' and FldName = '{1}' and TabName = '{2}'",
              strPrjId,
              strFieldName,
              strTabName);
            List<string> arrFldId = null;
            try
            {
                arrFldId = clsGeneralTab2.funGetFldValue("vPrjTabFld", "Caption", strCondition.ToString());
            }
            catch (Exception objException)
            {
                throw objException;
            }
            if (arrFldId == null || arrFldId.Count == 0)
            {
                return "";
            }
            return arrFldId[0].ToString();

        }
        /// <summary>
        /// 获取满足条件的所有记录对象列表,用对象列表的形式表示
        /// </summary>
        /// <param name = "strCondition">条件串</param>
        /// <returns>满足条件的所有记录对象列表</returns>
        public static List<clsFieldTabENEx> GetObjLstEx(string strCondition)
        {
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!", objException.Message));
            }
            List<clsFieldTabENEx> arrObjList = new List<clsFieldTabENEx>();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsFieldTabDA.GetSpecSQLObj();
            strSQL = "Select * from FieldTab where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsFieldTabENEx objFieldTabEN = new clsFieldTabENEx();
                objFieldTabEN.FldId = objRow["FldId"].ToString().Trim(); //字段ID
                objFieldTabEN.PrjId = objRow["PrjId"].ToString().Trim(); //工程ID
                objFieldTabEN.FldName = objRow["FldName"].ToString().Trim(); //字段名
                objFieldTabEN.DataTypeId = objRow["DataTypeId"].ToString().Trim(); //字段类型
                objFieldTabEN.FldLength = Int32.Parse(objRow["FldLength"].ToString().Trim()); //字段长度
                objFieldTabEN.Caption = objRow["Caption"].ToString().Trim(); //标题
                objFieldTabEN.FldInfo = objRow["FldInfo"].ToString().Trim(); //字段信息
                objFieldTabEN.IsNull = clsGeneralTab2.TransNullToBool_S(objRow["IsNull"].ToString().Trim()); //是否可空
                objFieldTabEN.IsPrimaryKey = clsGeneralTab2.TransNullToBool_S(objRow["IsPrimaryKey"].ToString().Trim()); //是否主键
                objFieldTabEN.IsIdentity = clsGeneralTab2.TransNullToBool_S(objRow["IsIdentity"].ToString().Trim()); //是否Identity
                objFieldTabEN.IsChecked = clsGeneralTab2.TransNullToBool_S(objRow["IsChecked"].ToString().Trim()); //是否核实
                objFieldTabEN.IsArchive = clsGeneralTab2.TransNullToBool_S(objRow["IsArchive"].ToString().Trim()); //是否存档
                objFieldTabEN.IsOnlyOne = clsGeneralTab2.TransNullToBool_S(objRow["IsOnlyOne"].ToString().Trim()); //是否唯一
                objFieldTabEN.MaxValue = objRow["MaxValue"].ToString().Trim(); //最大值
                objFieldTabEN.MinValue = objRow["MinValue"].ToString().Trim(); //最小值
                objFieldTabEN.DefaultValue = objRow["DefaultValue"].ToString().Trim(); //缺省值
                
                objFieldTabEN.UpdUser = objRow["UpdUser"].ToString().Trim(); //用户ID

                objFieldTabEN.FldStateId = objRow["FldStateId"].ToString().Trim(); //字段状态Id
                objFieldTabEN.UpdDate = objRow["UpdDate"].ToString().Trim(); //修改日期
                objFieldTabEN.FldPrecision = clsGeneralTab2.TransNullToInt_S(objRow["FldPrecision"].ToString().Trim()); //精确度
                objFieldTabEN.Memo = objRow["Memo"].ToString().Trim(); //说明
                objFieldTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
                arrObjList.Add(objFieldTabEN);
            }
            objDT = null;
            return arrObjList;
        }


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "arrFieldTabExObjLst">arrFieldTabExObjLst</param>
        /// <param name = "strFldID">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsFieldTabENEx GetFieldTabExObjByFldID_List(string strFldID, List<clsFieldTabENEx> arrFieldTabExObjLst)
        {
            foreach (clsFieldTabENEx objFieldTabEN in arrFieldTabExObjLst)
            {
                if (objFieldTabEN.FldId == strFldID)
                {
                    return objFieldTabEN;
                }
            }
            return null;
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
        public static bool CopyToPrjTab(string[] arrFldId, string strTabId, string strPrjId, string strCurrPrjDataBaseId, string strOpUser)
        {
            string strMsg;
            if (string.IsNullOrEmpty(strTabId))
            {
                strMsg = "请选择复制到的工程表!";
                throw new Exception(strMsg);
            }
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            foreach (string strFldId in arrFldId)
            {
                clsPrjTabFldEN objPrjTabFld = null;
                List<clsPrjTabFldEN> arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByFldId(strPrjId, strFldId);
                if (arrPrjTabFld.Count > 0) objPrjTabFld = arrPrjTabFld[0];
                else
                {
                    arrPrjTabFld = clsPrjTabFldBLEx.GetObjLstByTabIdCache(strTabId, strPrjId);
                    if (arrPrjTabFld.Count > 0) objPrjTabFld = arrPrjTabFld.Find(x=>x.FieldTypeId == enumFieldType.NormalField_01);
                }
                if (objPrjTabFld == null)
                {
                    objPrjTabFld = new clsPrjTabFldEN();
                    objPrjTabFld.FldId = strFldId;
                    objPrjTabFld.PrjId = strPrjId;
                    objPrjTabFld.FieldTypeId = enumFieldType.NormalField_01;
                    objPrjTabFld.IsForExtendClass = false;
                    objPrjTabFld.IsTabNullable = true;
                    objPrjTabFld.IsTabUnique = false;
                }
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


    }
}