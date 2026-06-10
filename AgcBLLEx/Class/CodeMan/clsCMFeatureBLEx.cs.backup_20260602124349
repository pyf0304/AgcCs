
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCMFeatureBLEx
表名:CMFeature(00050517)
生成代码版本:2019.11.08.1
生成日期:2019/11/12 15:47:11
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:代码管理
模块英文名:CodeMan
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

namespace AGC.BusinessLogicEx
{
    public static class clsCMFeatureBLEx_Static
    {


        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_AddRecordEx)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        public static bool AddRecordEx2(this clsCMFeatureEN objCMFeatureEN)
        {
            //操作步骤:
            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //2、检查唯一性
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
                            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            if (clsCMFeatureBL.IsExist(objCMFeatureEN.CmFeatureId)) //判断是否有相同的关键字
            {
                strMsg = "(errid:BlEx000004)关键字字段已有相同的值";
                throw new Exception(strMsg);
            }
            try
            {
                //2、检查传进去的对象属性是否合法
                objCMFeatureEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objCMFeatureEN.AddNewRecord();
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
        /// <param name = "objCMFeatureEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool UpdateRecordEx2(this clsCMFeatureEN objCMFeatureEN)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
            try
            {
                //1、检查传进去的对象属性是否合法
                objCMFeatureEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objCMFeatureEN.Update();
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
        /// <param name = "objCMFeature">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx2(this clsCMFeatureEN objCMFeature)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsCMFeatureEN objCMFeature_Cond = new clsCMFeatureEN();
            string strCondition = objCMFeature_Cond
            .SetCmFeatureId(objCMFeature.CmFeatureId, "=")
            .GetCombineCondition();
            objCMFeature._IsCheckProperty = true;
            bool bolIsExist = clsCMFeatureBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objCMFeature.CmFeatureId = clsCMFeatureBL.GetFirstID_S(strCondition);
                objCMFeature.UpdateWithCondition(strCondition);
            }
            else
            {
                objCMFeature.AddNewRecord();
            }
            return true;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objCMFeatureENS">源对象</param>
        /// <returns>目标对象=>clsCMFeatureEN:objCMFeatureENT</returns>
        public static clsCMFeatureENEx CopyToEx(this clsCMFeatureEN objCMFeatureENS)
        {
            try
            {
                clsCMFeatureENEx objCMFeatureENT = new clsCMFeatureENEx();
                clsCMFeatureBL.CopyTo(objCMFeatureENS, objCMFeatureENT);
                return objCMFeatureENT;
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
        /// <param name = "objCMFeatureENS">源对象</param>
        /// <returns>目标对象=>clsCMFeatureEN:objCMFeatureENT</returns>
        public static clsCMFeatureEN CopyTo(this clsCMFeatureENEx objCMFeatureENS)
        {
            try
            {
                clsCMFeatureEN objCMFeatureENT = new clsCMFeatureEN();
                clsCMFeatureBL.CopyTo(objCMFeatureENS, objCMFeatureENT);
                return objCMFeatureENT;
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
    /// CM功能(CMFeature)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsCMFeatureBLEx : clsCMFeatureBL
    {
        public static string strPrjIdCache_Init = "";
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsCMFeatureDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsCMFeatureDAEx CMFeatureDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsCMFeatureDAEx();
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
        public static List<clsCMFeatureENEx> GetObjExLst(string strCondition)
        {
            List<clsCMFeatureEN> arrObjLst = clsCMFeatureBL.GetObjLst(strCondition);
            List<clsCMFeatureENEx> arrObjExLst = new List<clsCMFeatureENEx>();
            foreach (clsCMFeatureEN objInFor in arrObjLst)
            {
                clsCMFeatureENEx objCMFeatureENEx = new clsCMFeatureENEx();
                clsCMFeatureBL.CopyTo(objInFor, objCMFeatureENEx);
                arrObjExLst.Add(objCMFeatureENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strCmFeatureId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsCMFeatureENEx GetObjExByCmFeatureId(string strCmFeatureId)
        {
            clsCMFeatureEN objCMFeatureEN = clsCMFeatureBL.GetObjByCmFeatureId(strCmFeatureId);
            clsCMFeatureENEx objCMFeatureENEx = new clsCMFeatureENEx();
            clsCMFeatureBL.CopyTo(objCMFeatureEN, objCMFeatureENEx);
            return objCMFeatureENEx;
        }

        public static void BindDdl_CmFeatureIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strCmPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format(" 1=1 And {0} in ({1}) Order by {2}",
                conCMFeature.CmPrjId, strCmPrjId, conCMFeature.FeatureName, conCMFeature.OrderNum);
            List<clsvCMFeatureEN> arrObjLst = clsvCMFeatureBL.GetObjLst(strCondition);
            //arrObjLst.ForEach(x => { x.FeatureName = string.Format("{0}-{1}", x.FeatureName, x.FeatureTypeName); });
            objDDL.DataValueField = conCMFeature.CmFeatureId;
            objDDL.DataTextField = conCMFeature.FeatureName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static void BindDdl_CmFeatureId4ParentEx(System.Web.UI.WebControls.DropDownList objDDL, string strCmPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format(" 1=1 And {0} in ({1}) Order by {2}",
                conCMFeature.CmPrjId, strCmPrjId, conCMFeature.FeatureName, conCMFeature.OrderNum);
            List<clsvCMFeatureEN> arrObjLst = clsvCMFeatureBL.GetObjLst(strCondition).Where(x=>string.IsNullOrEmpty(x.CmParentFeatureId) == true).ToList();

            //arrObjLst.ForEach(x => { x.FeatureName = string.Format("{0}-{1}", x.FeatureName, x.FeatureTypeName); });
            objDDL.DataValueField = conCMFeature.CmFeatureId;
            objDDL.DataTextField = conCMFeature.FeatureName;
            objDDL.DataSource = arrObjLst;
            try
            {
                objDDL.DataBind();
            }
            catch(Exception objException)
            {
                string strSS = objException.Message;
            }
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 克隆记录
        /// </summary>
        /// <param name="strCmFeatureId">strCmFeatureId</param>
        /// <param name="strUserId">strUserId</param>
        /// <returns></returns>
        public static clsCMFeatureEN CloneRecord(string strCmFeatureId, string strUserId)
        {
            clsCMFeatureEN objCMFeatureEN = clsCMFeatureBL.GetObjByCmFeatureId(strCmFeatureId);
            objCMFeatureEN.CmFeatureId = clsCMFeatureBL.GetMaxStrIdByPrefix_S(objCMFeatureEN.PrjId);
            objCMFeatureEN.FeatureName = "Copy_" + objCMFeatureEN.FeatureName;
            //if (string.IsNullOrEmpty(objCMFeatureEN.ReturnTypeId))
            //{
            //    objCMFeatureEN.ReturnTypeId = "29";
            //}
            objCMFeatureEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objCMFeatureEN.UpdUser = strUserId;

            try
            {
                clsCMFeatureBL.AddNewRecordBySql2(objCMFeatureEN);

                return objCMFeatureEN;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("克隆记录出错！错误：{0}。(strFuncId4GC:{1})({2})",
                    objException.Message,
                    strCmFeatureId,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        public static void BindDdl_PrjIdEx(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[工程]...", "0");
            string strCondition = string.Format("{0} in (Select {0} From {1} ) Order By {2}",
                conProjects.PrjId, convCMFeature._CurrTabName,
                conProjects.PrjName);
            IEnumerable<clsProjectsEN> arrObjLst = clsProjectsBL.GetObjLst(strCondition)
                .Where(x => x.UseStateId == enumUseState.InUse_0001)
                .OrderBy(x => x.PrjName);
            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conProjects.PrjId;
            objDDL.DataTextField = conProjects.PrjName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        public static void BindDdl_UserIdEx(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[用户]...", "0");
            string strCondition = string.Format("{0} in (Select {1} From {2} ) Order By {3}",
                conUsers.UserId, convCMFeature.UpdUser, convCMFeature._CurrTabName,
                conUsers.UserName);
            IEnumerable<clsUsersEN> arrObjLst = clsUsersBL.GetObjLst(strCondition);
            //arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conUsers.UserId;
            objDDL.DataTextField = conUsers.UserName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        ///// <summary>
        ///// 同步满足条件的记录，从Server到Client
        ///// </summary>
        ///// <param name="strCondition">同步的条件</param>
        ///// <param name="strOpUserId">操作同步的用户</param>
        ///// <returns></returns>
        //public static int SynchToClientByCondition(string strCondition, string strOpUserId)
        //{
        //    if (string.IsNullOrEmpty(strOpUserId) == true)
        //    {
        //        throw new Exception("上传到Client库时，同步人不能为空！");
        //    }
        //    int intCount = 0;
        //    string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();
        //    clsSysParaEN.strConnectStrName = "ConnectionString";

        //    List<clsCMFeatureEN> arrCMFeatureENObjLst = clsCMFeatureBL.GetObjLst(strCondition);

        //    foreach (clsCMFeatureEN objCMFeatureEN4Main in arrCMFeatureENObjLst)
        //    {
        //        //如果这条记录的来源就是Client,就不需要同步了
        //        if (objCMFeatureEN4Main.SynSource == "Client") continue;
        //        objCMFeatureEN4Main.IsSynchToClient = true;
        //        objCMFeatureEN4Main.SynchToClientDate = strCurrDate14;
        //        objCMFeatureEN4Main.SynchToClientUser = strOpUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionStringClient";

        //        try
        //        {
        //            clsCMFeatureEN objCMFeatureEN4Main2 = new clsCMFeatureEN();
        //            clsCMFeatureBL.CopyTo(objCMFeatureEN4Main, objCMFeatureEN4Main2);
        //            objCMFeatureEN4Main2.SynSource = "Server";
        //            strCondition = objCMFeatureEN4Main.GetUniquenessConditionString();
        //            clsCMFeatureEN objCMFeature_Target = clsCMFeatureBL.GetFirstObj_S(strCondition);

        //            if (objCMFeature_Target != null)
        //            {
        //                //如果目标地的对象日期小于来源对象的日期就更新
        //                int intResult = objCMFeature_Target.UpdDate.CompareTo(objCMFeatureEN4Main.UpdDate);
        //                if (intResult < 0)
        //                {

        //                    objCMFeatureEN4Main2.UpdateWithCondition(strCondition);
        //                    intCount++;
        //                }
        //            }
        //            else
        //            {
        //                string strPrjId = clsCMProjectBLEx.GetObjByCmPrjIdCache(objCMFeatureEN4Main2.CmPrjId).PrjId;
        //                objCMFeatureEN4Main2.CmFeatureId = clsCMFeatureBL.GetMaxStrIdByPrefix_S(strPrjId);
        //                objCMFeatureEN4Main2.AddRecordEx();
        //                intCount++;
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionString";
        //            objCMFeatureEN4Main.UpdateRecordEx();
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Client库，字段表：{0}({1})时出错。({3}).[上级抛错:{2}]", objCMFeatureEN4Main.CmFeatureId,
        //                        objCMFeatureEN4Main.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}

        ///// <summary>
        ///// 同步满足条件的记录，从Client到Server
        ///// </summary>
        ///// <param name="strCondition">同步的条件</param>
        ///// <param name="strOpUserId">操作同步的用户</param>
        ///// <returns></returns>
        //public static int SynchToServerByCondition(string strCondition, string strOpUserId)
        //{

        //    if (string.IsNullOrEmpty(strOpUserId) == true)
        //    {
        //        throw new Exception("同步到服务端时，同步人不能为空！");
        //    }
        //    int intCount = 0;

        //    string strCurrDate14 = clsDateTime_Db.GetDataBaseDateTime14();
        //    clsSysParaEN.strConnectStrName = "ConnectionStringClient";

        //    List<clsCMFeatureEN> arrCMFeatureENObjLst = clsCMFeatureBL.GetObjLst(strCondition);

        //    foreach (clsCMFeatureEN objCMFeatureEN4Web in arrCMFeatureENObjLst)
        //    {
        //        //如果这条记录的来源就是Server,就不需要同步了
        //        if (objCMFeatureEN4Web.SynSource == "Server") continue;
        //        objCMFeatureEN4Web.IsSynchToServer = true;
        //        objCMFeatureEN4Web.SynchToServerDate = strCurrDate14;
        //        objCMFeatureEN4Web.SynchToServerUser = strOpUserId;
        //        clsSysParaEN.strConnectStrName = "ConnectionString";

        //        objCMFeatureEN4Web.SynSource = "Client";
        //        try
        //        {
        //            strCondition = objCMFeatureEN4Web.GetUniquenessConditionString();
        //            clsCMFeatureEN objCMFeature_Target = clsCMFeatureBL.GetFirstObj_S(strCondition);
        //            if (objCMFeature_Target != null)
        //            {
        //                int intResult = (objCMFeature_Target.UpdDate.CompareTo(objCMFeatureEN4Web.UpdDate));
        //                if (intResult < 0)
        //                {
        //                    objCMFeatureEN4Web.UpdateWithCondition(strCondition);
        //                }
        //            }
        //            else
        //            {
        //                string strPrjId = clsCMProjectBLEx.GetObjByCmPrjIdCache(objCMFeatureEN4Web.CmPrjId).PrjId;
        //                objCMFeatureEN4Web.CmFeatureId = clsCMFeatureBL.GetMaxStrIdByPrefix_S(strPrjId);
        //                objCMFeatureEN4Web.AddRecordEx();
        //            }

        //            clsSysParaEN.strConnectStrName = "ConnectionStringClient";
        //            objCMFeatureEN4Web.UpdateRecordEx();
        //        }
        //        catch (Exception objException)
        //        {
        //            StringBuilder sbMsg = new StringBuilder();
        //            sbMsg.AppendFormat("在同步到Server端时，字段表：{0}({1})时出错。({3}).[上级抛错:{2}]",
        //                        clsCMFeatureEN._CurrTabName,
        //                        objCMFeatureEN4Web.CmFeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
        //            throw new Exception(sbMsg.ToString());
        //        }
        //    }
        //    clsSysParaEN.strConnectStrName = "ConnectionString";
        //    return intCount;
        //}

        /// <summary>
        /// 重新排序。根据分类字段：CmFeatureTypeId单独排序
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ReOrder)
        /// </summary>
        /// <param name="strCmPrjId">分类字段</param>
        /// <returns></returns>
        public static bool ReOrderEx(string strCmPrjId)
        {
            try
            {
                string strCondition = " 1=1 ";
                strCondition += string.Format(" And {0} = '{1}' ", conCMFeature.CmPrjId, strCmPrjId);
                strCondition += string.Format(" order by OrderNum ");
                List<clsCMFeatureEN> arrCMFeatureObjList = new clsCMFeatureDA().GetObjLst(strCondition);
                List<clsCMFeatureEN> arrCMFeatureObjList_Parent = arrCMFeatureObjList.Where(x=>string.IsNullOrEmpty(x.CmParentFeatureId) == true).ToList();
                List<clsCMFeatureEN> arrCMFeatureObjList_Sub = arrCMFeatureObjList.Where(x => string.IsNullOrEmpty(x.CmParentFeatureId) == false).ToList();

                int intIndex = 100;
                foreach (clsCMFeatureEN objCMFeature in arrCMFeatureObjList_Parent)
                {
                    objCMFeature.OrderNum = intIndex;
                    objCMFeature.Update();
                   
                    int intIndex_sub = 1;
                    foreach (clsCMFeatureEN objCMFeature_Sub in arrCMFeatureObjList_Sub)
                    {
                        if (objCMFeature_Sub.CmParentFeatureId != objCMFeature.CmFeatureId) continue;
                        objCMFeature_Sub.OrderNum = intIndex + intIndex_sub;
                        objCMFeature_Sub.Update();
                        intIndex_sub += 1;
                    }
                    intIndex += 100;
                }
                return true;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("重序出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 把所给的关键字列表所对应的对象置顶。根据分类字段：CmPrjId单独排序
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoTop)
        /// </summary>
        /// <param name="arrKeyId">所给的关键字列表</param>
        ///// <param name="strCmPrjId">分类字段</param>
        /// <returns></returns>
        public static bool GoTopEx(List<string> arrKeyId)
        {
            try
            {
                if (arrKeyId.Count == 0) return true;
                string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
                string strCondition = string.Format("{0} in ({1})", conCMFeature.CmFeatureId, strKeyList);
                List<clsCMFeatureEN> arrCMFeatureLst = GetObjLst(strCondition);
                string strCmPrjId = "";
                foreach (clsCMFeatureEN objCMFeature in arrCMFeatureLst)
                {
                    strCmPrjId = objCMFeature.CmPrjId;
                    objCMFeature.OrderNum = objCMFeature.OrderNum - 10000;
                    UpdateBySql2(objCMFeature);
                }
                ReOrderEx(strCmPrjId);
                return true;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置顶出错,{0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把所给的关键字列表所对应的对象置顶。根据分类字段：CmPrjId单独排序
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_GoBottom)
        /// </summary>
        /// <param name="arrKeyId">所给的关键字列表</param>
        /// <returns></returns>
        public static bool GoBottomEx(List<string> arrKeyId)
        {
            try
            {
                if (arrKeyId.Count == 0) return true;
                string strKeyList = clsArray.GetSqlInStrByArray(arrKeyId, true);
                string strCondition = string.Format("{0} in ({1})", conCMFeature.CmFeatureId, strKeyList);
                List<clsCMFeatureEN> arrCMFeatureLst = GetObjLst(strCondition);
                string strCmPrjId = "";
                foreach (clsCMFeatureEN objCMFeature in arrCMFeatureLst)
                {
                    strCmPrjId = objCMFeature.CmPrjId;
                    objCMFeature.OrderNum = objCMFeature.OrderNum + 10000;
                    UpdateBySql2(objCMFeature);
                }
                ReOrderEx(strCmPrjId);
                return true;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("置顶出错, {0}. (from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 调整所给关键字记录的序号。根据分类字段：CmPrjId单独排序
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_AdjustOrderNum)
        /// </summary>
        /// <param name="strDirect">方向：用"Up","Down"表示</param>
        /// <param name="strCmFeatureId">所给的关键字</param>
        /// <param name="strCmPrjId">分类字段</param>
        /// <returns>是否成功?</returns>
        public static bool AdjustOrderNumEx(string strDirect, string strCmFeatureId)
        {
            try
            {
                //操作步骤：
                //1、根据所给定的关键字[CmFeatureId]，获取相应的序号[OrderNum]；
                //2、如果当前序号是否是末端序号；
                //3、如果是末端序号，就退出；
                //   3.1、如果是向下移动，判断当前序号是否“小于”当前表中的字段数，
                //	   即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
                //   3.2、如果是向上移动，就判断当前序号是否“大于”1，
                //	   即不是第一条记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
                //4、获取下(上)一个序号记录的关键字CmFeatureId
                //5、把当前关键字CmFeatureId所对应记录的序号加(减)1
                //6、把下(上)一个序号关键字CmFeatureId所对应的记录序号减(加)1
                string strMsg = "";
                string strCmPrjId = "";
                int intOrderNum;    //当前记录的序号
                int intPrevOrderNum, intNextOrderNum;   //上下两条记录的序号
                string strPrevCmFeatureId = "";    //上一条序号的关键字CmFeatureId
                string strNextCmFeatureId = "";    //下一条序号的关键字CmFeatureId
                int intTabRecNum;       //当前表中字段的记录数
                StringBuilder sbCondition = new StringBuilder();
                //1、根据所给定的关键字[CmFeatureId]，获取相应的序号[OrderNum]。

                clsCMFeatureEN objCMFeature = clsCMFeatureBL.GetObjByCmFeatureId(strCmFeatureId);
                strCmPrjId = objCMFeature.CmPrjId;
                if (string.IsNullOrEmpty(objCMFeature.CmParentFeatureId) == true)
                {
                    intOrderNum = objCMFeature.OrderNum;//当前序号
                    intPrevOrderNum = intOrderNum - 100;//前一条记录的序号
                    intNextOrderNum = intOrderNum + 100;//后一条记录的序号
                                                      //3、如果当前序号是否是末端序号，
                                                      //		3.1 如果是末端序号，就退出，

                    string strCondition = " 1=1 ";
                    strCondition += string.Format(" And {0} = '{1}' ", conCMFeature.CmPrjId, strCmPrjId);
                    intTabRecNum = clsCMFeatureBL.GetRecCountByCond(clsCMFeatureEN._CurrTabName, strCondition);    //获取当前表的记录数
                    switch (strDirect)
                    {
                        case "UP":
                        case "Up":
                        case "up":
                            //3、如果是末端序号，就退出；
                            //  3.2、如果是向上移动，就判断当前序号是否“大于”1，
                            //	     即不是第一条记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
                            if (intOrderNum <= 100)
                            {
                                strMsg = string.Format("已经是第一条记录，不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }
                            //		3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
                            //		    即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
                            //		    如果是向上移动，就判断当前序号是否“大于”1，
                            //		    即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
                            sbCondition.AppendFormat(" {0} = {1} ", conCMFeature.OrderNum, intOrderNum - 100);
                            sbCondition.AppendFormat(" And {0} = '{1}' ", conCMFeature.CmPrjId, strCmPrjId);
                            //4、获取上一个序号字段的关键字CmFeatureId
                            strPrevCmFeatureId = clsCMFeatureBL.GetFirstID_S(sbCondition.ToString());
                            if (string.IsNullOrEmpty(strPrevCmFeatureId) == true)
                            {
                                strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }
                            //5、把当前关键字CmFeatureId所对应记录的序号减1
                            //6、把下(上)一个序号关键字CmFeatureId所对应的记录序号加1
                            clsCMFeatureBL.SetFldValue(clsCMFeatureEN._CurrTabName, conCMFeature.OrderNum,
                                      intOrderNum - 100,
                                       string.Format("{0} = '{1}'", conCMFeature.CmFeatureId, strCmFeatureId));
                            clsCMFeatureBL.SetFldValue(clsCMFeatureEN._CurrTabName, conCMFeature.OrderNum,
                                      intPrevOrderNum + 100,
                                      string.Format("{0} = '{1}'", conCMFeature.CmFeatureId, strPrevCmFeatureId));
                            break;
                        case "DOWN":
                        case "Down":
                        case "down":
                            //3、如果是末端序号，就退出；
                            //   3.1、如果是向下移动，判断当前序号是否“小于”当前表中的字段数，
                            //	   即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
                            if (intOrderNum >= intTabRecNum*100)    //如果当前序号大于表记录数
                            {
                                strMsg = string.Format("已经是最后一条记录，不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }

                            //4、获取下一个序号字段的关键字CmFeatureId
                            sbCondition.AppendFormat(" {0} = {1} ", conCMFeature.OrderNum, intOrderNum + 100);
                            sbCondition.AppendFormat(" And {0} = '{1}' ", conCMFeature.CmPrjId, strCmPrjId);

                            strNextCmFeatureId = clsCMFeatureBL.GetFirstID_S(sbCondition.ToString());
                            if (string.IsNullOrEmpty(strNextCmFeatureId) == true)
                            {
                                strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

                                throw new Exception(strMsg);
                            }
                            //5、把当前关键字CmFeatureId所对应记录的序号加1
                            //6、把下(上)一个序号关键字CmFeatureId所对应的记录序号减1
                            clsCMFeatureBL.SetFldValue(clsCMFeatureEN._CurrTabName, conCMFeature.OrderNum,
                                      intOrderNum + 100,
                                      string.Format("{0} = '{1}'", conCMFeature.CmFeatureId, strCmFeatureId));
                            clsCMFeatureBL.SetFldValue(clsCMFeatureEN._CurrTabName, conCMFeature.OrderNum,
                                      intNextOrderNum - 100,
                                      string.Format("{0} = '{1}'", conCMFeature.CmFeatureId, strNextCmFeatureId));
                            break;
                        default:
                            strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
                                      strDirect,
                                      clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }
                }
                else
                {
                    clsCMFeatureEN objCMFeature_Parent = clsCMFeatureBL.GetObjByCmFeatureId(objCMFeature.CmParentFeatureId);

                    intOrderNum = objCMFeature.OrderNum;//当前序号
                    intPrevOrderNum = intOrderNum - 1;//前一条记录的序号
                    intNextOrderNum = intOrderNum + 1;//后一条记录的序号
                                                      //3、如果当前序号是否是末端序号，
                                                      //		3.1 如果是末端序号，就退出，

                    string strCondition = " 1=1 ";
                    strCondition += string.Format(" And {0} = '{1}' ", conCMFeature.CmParentFeatureId, objCMFeature_Parent.CmFeatureId);
                    intTabRecNum = clsCMFeatureBL.GetRecCountByCond(clsCMFeatureEN._CurrTabName, strCondition);    //获取当前表的记录数
                    switch (strDirect)
                    {
                        case "UP":
                        case "Up":
                        case "up":
                            //3、如果是末端序号，就退出；
                            //  3.2、如果是向上移动，就判断当前序号是否“大于”1，
                            //	     即不是第一条记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
                            if (intOrderNum <= objCMFeature_Parent.OrderNum+1)
                            {
                                strMsg = string.Format("已经是第一条记录，不能再上移.(from {0})", clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }
                            //		3.2 如果不是，即如果是向下移动，就判断当前序号是否“小于”当前表中的字段数，
                            //		    即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
                            //		    如果是向上移动，就判断当前序号是否“大于”1，
                            //		    即不是最开始一个记录，就准备把当前字段项的序号减1，而上一字段的序号加1。
                            sbCondition.AppendFormat(" {0} = {1} ", conCMFeature.OrderNum, intOrderNum - 1);
                            sbCondition.AppendFormat(" And {0} = '{1}' ", conCMFeature.CmPrjId, strCmPrjId);
                            //4、获取上一个序号字段的关键字CmFeatureId
                            strPrevCmFeatureId = clsCMFeatureBL.GetFirstID_S(sbCondition.ToString());
                            if (string.IsNullOrEmpty(strPrevCmFeatureId) == true)
                            {
                                strMsg = string.Format("获取上一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }
                            //5、把当前关键字CmFeatureId所对应记录的序号减1
                            //6、把下(上)一个序号关键字CmFeatureId所对应的记录序号加1
                            clsCMFeatureBL.SetFldValue(clsCMFeatureEN._CurrTabName, conCMFeature.OrderNum,
                                      intOrderNum - 1,
                                       string.Format("{0} = '{1}'", conCMFeature.CmFeatureId, strCmFeatureId));
                            clsCMFeatureBL.SetFldValue(clsCMFeatureEN._CurrTabName, conCMFeature.OrderNum,
                                      intPrevOrderNum + 1,
                                      string.Format("{0} = '{1}'", conCMFeature.CmFeatureId, strPrevCmFeatureId));
                            break;
                        case "DOWN":
                        case "Down":
                        case "down":
                            //3、如果是末端序号，就退出；
                            //   3.1、如果是向下移动，判断当前序号是否“小于”当前表中的字段数，
                            //	   即不是最后一个记录，就准备把当前字段项的序号加1，而下一字段的序号减1，
                            if (intOrderNum >= objCMFeature_Parent.OrderNum+ intTabRecNum)    //如果当前序号大于表记录数
                            {
                                strMsg = string.Format("已经是最后一条记录，不能再下移.(from {0})", clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }

                            //4、获取下一个序号字段的关键字CmFeatureId
                            sbCondition.AppendFormat(" {0} = {1} ", conCMFeature.OrderNum, intOrderNum + 1);
                            sbCondition.AppendFormat(" And {0} = '{1}' ", conCMFeature.CmPrjId, strCmPrjId);

                            strNextCmFeatureId = clsCMFeatureBL.GetFirstID_S(sbCondition.ToString());
                            if (string.IsNullOrEmpty(strNextCmFeatureId) == true)
                            {
                                strMsg = string.Format("获取下一条记录的关键字出错.(from {0})", clsStackTrace.GetCurrClassFunction());

                                throw new Exception(strMsg);
                            }
                            //5、把当前关键字CmFeatureId所对应记录的序号加1
                            //6、把下(上)一个序号关键字CmFeatureId所对应的记录序号减1
                            clsCMFeatureBL.SetFldValue(clsCMFeatureEN._CurrTabName, conCMFeature.OrderNum,
                                      intOrderNum + 1,
                                      string.Format("{0} = '{1}'", conCMFeature.CmFeatureId, strCmFeatureId));
                            clsCMFeatureBL.SetFldValue(clsCMFeatureEN._CurrTabName, conCMFeature.OrderNum,
                                      intNextOrderNum - 1,
                                      string.Format("{0} = '{1}'", conCMFeature.CmFeatureId, strNextCmFeatureId));
                            break;
                        default:
                            strMsg = string.Format("方向参数出错!strDirect=[{0}]({1})",
                                      strDirect,
                                      clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                    }
                }
                ReOrderEx(strCmPrjId);
                return true;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("调整记录次序出错！错误:[{0}]({1})",
                          objException.Message,
                          clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 初始化列表缓存.
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
        /// </summary>
        //public static void InitListCache(string strPrjId)
        //{
        //    //检查缓存刷新机制
        //    string strMsg = "";
        //    if (clsCMFeatureBL.objCommFun4BL == null)
        //    {
        //        strMsg = string.Format("类clsCMFeatureBL没有刷新缓存机制(clsCMFeatureBL.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
        //        throw new Exception(strMsg);
        //    }
        //    if (strPrjIdCache_Init != strPrjId) arrCMFeatureObjLstCache = null;
                     
        //    //初始化列表缓存
        //    string strWhereCond = string.Format("{0} in (Select {0} From {1} where {2}= '{3}') order by CmFeatureId",
        //        conCMFeature.CmPrjId,
        //        conCMProject._CurrTabName,
        //        conCMProject.PrjId, strPrjId);
        //    if (arrCMFeatureObjLstCache == null)
        //    {
        //        strPrjIdCache_Init = strPrjId;
        //        arrCMFeatureObjLstCache = CMFeatureDA.GetObjLst(strWhereCond);
        //    }
        //}

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strCmFeatureId">所给的关键字</param>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static IEnumerable<clsCMFeatureEN> GetSubObjLstByCmFeatureIdCache(string strCmFeatureId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strCmFeatureId) == true) return null;
            //初始化列表缓存
            //InitListCache(strPrjId);
            List<clsCMFeatureEN> arrObjLstCache = clsCMFeatureBL.GetObjLstCache(strPrjId);

            IEnumerable<clsCMFeatureEN> arrCMFeatureObjLst_Sel =
            arrObjLstCache
            .Where(x => x.CmParentFeatureId == strCmFeatureId);
          
            return arrCMFeatureObjLst_Sel;
        }


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strCmFeatureId">所给的关键字</param>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static IEnumerable<string> GetSubFeatureIdLstByCmFeatureIdCache(string strCmFeatureId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strCmFeatureId) == true) return null;
            //初始化列表缓存
            //InitListCache(strPrjId);
            List<clsCMFeatureEN> arrObjLstCache = clsCMFeatureBL.GetObjLstCache(strPrjId);

            IEnumerable<clsCMFeatureEN> arrCMFeatureObjLst_Sel =
            arrObjLstCache
            .Where(x => x.CmParentFeatureId == strCmFeatureId);

            return arrCMFeatureObjLst_Sel.Select(x=>x.CmFeatureId);
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strCmFeatureId">所给的关键字</param>
        /// <param name = "strPrjId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsCMFeatureEN GetObjByCmFeatureIdExCache(string strCmFeatureId, string strPrjId)
        {
            if (string.IsNullOrEmpty(strCmFeatureId) == true) return null;
            //初始化列表缓存
            //InitListCache(strPrjId);
            List<clsCMFeatureEN> arrObjLstCache = clsCMFeatureBL.GetObjLstCache(strPrjId);

            IEnumerable<clsCMFeatureEN> arrCMFeatureObjLst_Sel =
            arrObjLstCache
            .Where(x => x.CmFeatureId == strCmFeatureId);
            if (arrCMFeatureObjLst_Sel.Count() == 0)
            {
                clsCMFeatureEN obj = clsCMFeatureBL.GetObjByCmFeatureId(strCmFeatureId);
                if (obj != null)
                {
                    CacheHelper.Remove(clsCMFeatureEN._CurrTabName);
                    return obj;
                }
                return null;
            }
            return arrCMFeatureObjLst_Sel.First();
        }

    }
}