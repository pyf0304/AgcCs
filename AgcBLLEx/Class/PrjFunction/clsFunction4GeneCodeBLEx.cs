using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.DAL;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public static class clsFunction4GeneCodeBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objFunction4GeneCodeENS">源对象</param>
        /// <returns>目标对象=>clsFunction4GeneCodeEN:objFunction4GeneCodeENT</returns>
        public static clsFunction4GeneCodeEN CopyTo(this clsFunction4GeneCodeENEx objFunction4GeneCodeENS)
        {
            try
            {
                clsFunction4GeneCodeEN objFunction4GeneCodeENT = new clsFunction4GeneCodeEN();
                clsFunction4GeneCodeBL.CopyTo(objFunction4GeneCodeENS, objFunction4GeneCodeENT);
                return objFunction4GeneCodeENT;
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
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objFunction4GeneCodeENS">源对象</param>
        /// <returns>目标对象=>clsFunction4GeneCodeEN:objFunction4GeneCodeENT</returns>
        public static clsFunction4GeneCodeENEx CopyToEx(this clsFunction4GeneCodeEN objFunction4GeneCodeENS)
        {
            try
            {
                clsFunction4GeneCodeENEx objFunction4GeneCodeENT = new clsFunction4GeneCodeENEx();
                clsFunction4GeneCodeBL.Function4GeneCodeDA.CopyTo(objFunction4GeneCodeENS, objFunction4GeneCodeENT);
                return objFunction4GeneCodeENT;
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
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_UpdateRecordEx)
        /// </summary>
        /// <param name = "objFunction4GeneCodeEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool UpdateRecordEx2(this clsFunction4GeneCodeEN objFunction4GeneCodeEN)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
            try
            {
                //1、检查传进去的对象属性是否合法
                objFunction4GeneCodeEN.CheckPropertyNew();
                clsFunction4GeneCodeEN objFunction4GeneCode_Cond = new clsFunction4GeneCodeEN();
                string strCondition = objFunction4GeneCode_Cond
                    .SetFuncId4GC(objFunction4GeneCodeEN.FuncId4GC, "<>")
                .SetFuncName(objFunction4GeneCodeEN.FuncName, "=")
                .SetFuncCodeTypeId(objFunction4GeneCodeEN.FuncCodeTypeId, "=")
                .GetCombineCondition();
                objFunction4GeneCodeEN._IsCheckProperty = true;
                bool bolIsExist = clsFunction4GeneCodeBL.IsExistRecord(strCondition);
                if (bolIsExist)
                {
                    strMsg = "(FuncName_CodeTypeId)不能重复!";
                    throw new Exception(strMsg);
                }
                //4、把数据实体层的数据存贮到数据库中
                objFunction4GeneCodeEN.Update();
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
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_EditRecordEx)
        /// </summary>
        /// <param name = "objFunction4GeneCode">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx2(this clsFunction4GeneCodeEN objFunction4GeneCode)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsFunction4GeneCodeEN objFunction4GeneCode_Cond = new clsFunction4GeneCodeEN();
            string strCondition = objFunction4GeneCode_Cond
            .SetFuncName(objFunction4GeneCode.FuncName, "=")
            .SetFuncCodeTypeId(objFunction4GeneCode.FuncCodeTypeId, "=")
            .GetCombineCondition();
            objFunction4GeneCode._IsCheckProperty = true;
            bool bolIsExist = clsFunction4GeneCodeBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objFunction4GeneCode.FuncId4GC = clsFunction4GeneCodeBL.GetFirstID_S(strCondition);
                objFunction4GeneCode.UpdateWithCondition(strCondition);
            }
            else
            {
                objFunction4GeneCode.AddNewRecord();
            }
            return true;
        }

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_AddRecordEx)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        public static bool AddRecordEx2(this clsFunction4GeneCodeEN objFunction4GeneCodeEN)
        {
            //操作步骤:
            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //2、检查唯一性
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
                            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsFunction4GeneCodeBL.IsExist(objFunction4GeneCodeEN.FuncId4GC))   //判断是否有相同的关键字
            {
                strMsg = "(errid:BlEx000004)关键字字段已有相同的值";
                throw new Exception(strMsg);
            }
            try
            {
                //2、检查传进去的对象属性是否合法
                objFunction4GeneCodeEN.CheckPropertyNew();
                //5.2、检查唯一性
                if (objFunction4GeneCodeEN.CheckUniqueness() == false)
                {
                    strMsg = string.Format("(函数名(FuncName)=[{0}],编程语言类型Id(ProgLangTypeId)=[{1}])已经存在，不能重复!", objFunction4GeneCodeEN.FuncName, objFunction4GeneCodeEN.ProgLangTypeId);
                    throw new Exception(strMsg);
                }
                //6、把数据实体层的数据存贮到数据库中
                objFunction4GeneCodeEN.AddNewRecord();
            }
            catch (Exception objException)
            {
                strMsg = "(errid:BlEx000003)添加记录不成功!" + objException.Message;
                throw new Exception(strMsg);
            }
            return true;
        }
    }
    public partial class clsFunction4GeneCodeBLEx: clsFunction4GeneCodeBL
    {

        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "intApplicationTypeId">intApplicationTypeId</param>
        public static void BindDdl_FuncId4GCByAppliationTypeId(System.Web.UI.WebControls.DropDownList objDDL, int intApplicationTypeId)
        {

            List<string> arrProgLangTypeId = clsApplicationTypeBLEx.GetProgLangTypeIdLst(intApplicationTypeId);
            string sstrProgLangTypeId = clsArray.GetSqlInStrByArray(arrProgLangTypeId, true);
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format(" {0} in ({1}) Order By {2}",
                conFunction4GeneCode.ProgLangTypeId, sstrProgLangTypeId,
                conFunction4GeneCode.FuncName);
            System.Data.DataTable objDT = clsFunction4GeneCodeBL.GetDataTable(strCondition);
            objDDL.DataValueField = conFunction4GeneCode.FuncId4GC;
            objDDL.DataTextField = conFunction4GeneCode.FuncName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        /// <summary>
        /// 添加一个函数
        /// </summary>
        /// <param name="strFuncName">函数名</param>
        /// <param name="ltLangType">编程语言类型</param>
        /// <param name="strCodeTypeId">编程层类型</param>
        /// <param name="strSqlDsTypeId">Sql数据源类型</param>
        /// <param name="strUpdUser">修改用户</param>
        /// <returns>是否成功？</returns>
        public static bool AddNewFunction4GC( string strFuncName, clsPubConst.LangType ltLangType, 
            string strCodeTypeId, string strSqlDsTypeId, string strUpdUser)
        {
            string strProgLangTypeId = clsProgLangTypeBLEx.GetProgLangTypeIdByLangTypeCache(ltLangType);
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN();
            objFunction4GeneCodeEN.FuncId4GC = clsFunction4GeneCodeBL.GetMaxStrId_S();
            objFunction4GeneCodeEN.FuncName = strFuncName;
            objFunction4GeneCodeEN.ProgLangTypeId = strProgLangTypeId;
            objFunction4GeneCodeEN.FuncCodeTypeId = strCodeTypeId;
            objFunction4GeneCodeEN.SqlDsTypeId = strSqlDsTypeId;
            objFunction4GeneCodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objFunction4GeneCodeEN.UpdUser = strUpdUser;
                clsFunction4GeneCodeBL.CheckPropertyNew(objFunction4GeneCodeEN);
            string strCondition = objFunction4GeneCodeEN.GetUniCondStr();
            clsFunction4GeneCodeEN objFunction4GeneCodeEN_U = clsFunction4GeneCodeBL.GetFirstObj_S(strCondition);
            if (objFunction4GeneCodeEN_U != null)
            {
                if (objFunction4GeneCodeEN_U.SqlDsTypeId == "00") return true;
                if (objFunction4GeneCodeEN_U.SqlDsTypeId != strSqlDsTypeId)
                {
                    objFunction4GeneCodeEN_U.SqlDsTypeId = "00";
                    return clsFunction4GeneCodeBL.UpdateBySql2(objFunction4GeneCodeEN_U);
                }
                //string strMsg = string.Format("条件：{0}的记录已经存在！",  clsFunction4GeneCodeBL.GetUniquenessConditionString(objFunction4GeneCodeEN));
                //throw new Exception(strMsg);
            }
            return clsFunction4GeneCodeBL.AddNewRecordBySql2(objFunction4GeneCodeEN);
 
        }
        /// <summary>
        /// 设置是否在用
        /// </summary>
        /// <param name="strFuncId4GC"></param>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        public static bool SetInUse(string strFuncId4GC, string strUserId)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC(strFuncId4GC);
            objFunction4GeneCodeEN.InUse = !objFunction4GeneCodeEN.InUse;
            objFunction4GeneCodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objFunction4GeneCodeEN.UpdUser = strUserId;
            return clsFunction4GeneCodeBL.UpdateBySql2(objFunction4GeneCodeEN);

        }
        public static bool SetIsTemplate(string strFuncId4GC, string strUserId)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC(strFuncId4GC);
            objFunction4GeneCodeEN.IsTemplate = !objFunction4GeneCodeEN.IsTemplate;
            objFunction4GeneCodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objFunction4GeneCodeEN.UpdUser = strUserId;
            return clsFunction4GeneCodeBL.UpdateBySql2(objFunction4GeneCodeEN);

        }
        public static bool SetIsFuncTemplate(string strFuncId4GC, string strUserId)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC(strFuncId4GC);
            objFunction4GeneCodeEN.IsFuncTemplate = !objFunction4GeneCodeEN.IsFuncTemplate;
            objFunction4GeneCodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objFunction4GeneCodeEN.UpdUser = strUserId;
            return clsFunction4GeneCodeBL.UpdateBySql2(objFunction4GeneCodeEN);

        }
        /// <summary>
        /// 根据函数名获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strFuncName">所给的函数名</param>
        /// <returns>根据函数名获取的对象</returns>
        public static clsFunction4GeneCodeEN GetObjByFuncNameCache(string strFuncName)
        {
            if (string.IsNullOrEmpty(strFuncName) == true) return null;
            //初始化列表缓存
            List<clsFunction4GeneCodeEN> arrObjLstCache = clsFunction4GeneCodeBL.GetObjLstCache();

            IEnumerable<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjLst_Sel1 =
            from objFunction4GeneCodeEN in arrObjLstCache
            where objFunction4GeneCodeEN.FuncName == strFuncName
            select objFunction4GeneCodeEN;
            List<clsFunction4GeneCodeEN> arrFunction4GeneCodeObjLst_Sel = new List<clsFunction4GeneCodeEN>();
            foreach (clsFunction4GeneCodeEN obj in arrFunction4GeneCodeObjLst_Sel1)
            {
                arrFunction4GeneCodeObjLst_Sel.Add(obj);
            }
            if (arrFunction4GeneCodeObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrFunction4GeneCodeObjLst_Sel[0];
        }

    }
}
