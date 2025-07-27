
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsButtonTabBLEx
表名:ButtonTab(00050427)
生成代码版本:2019.03.05.1
生成日期:2019/03/06 09:43:18
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成代码
模块英文名:GeneCode
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.02.22.01
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

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// ButtonTab(ButtonTab)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public class clsButtonTabBLEx : clsButtonTabBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsButtonTabDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsButtonTabDAEx ButtonTabDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsButtonTabDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BL_DelRecordEx)
        /// </summary>
        /// <param name="strButtonId">表关键字</param>
        /// <returns></returns>
        private new static bool DelRecordEx(string strButtonId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsButtonTabDA.GetSpecSQLObj();
            //删除TeacherInfo本表中与当前对象有关的记录
            SqlConnection objConnection = null;
            SqlTransaction objSqlTransaction = null;
            try
            {
                //获取连接对象
                objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
                //获取该连接对象中的事务
                objSqlTransaction = objConnection.BeginTransaction();
                //
                //删除与表:[ButtonTab]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //constStudent.id_College,
                //strid_College);
                //        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsButtonTabBL.DelRecord(strButtonId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsButtonTabBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strButtonId, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                if (objSqlTransaction != null)
                {
                    objSqlTransaction.Rollback();
                }
                throw new Exception(strMsg);
            }
            finally
            {
                objConnection.Close();
            }
        }

        public static List<clsButtonTabENEx> GetObjExLstByViewId(string strViewId, int intAppTypeId, string strPrjId)
        {
            //string strCondition = string.Format("RegionId = {0} And {1}1='1' order by SeqNum", lngRegionId, conPrjFeature.InUse);

            //List<clsPrjFeatureENEx> arrObjENExList = new List<clsPrjFeatureENEx>();
            var arrRegionId = clsViewRegionRelaBLEx.GetRegionIdLstByViewIdCache(strViewId, strPrjId);

            string strCondition = string.Format("{0} in (select {0} From {1} where {2} in ({3}))",
                conPrjFeature.FeatureId, clsvFeatureRegionFldsEN._CurrTabName, convFeatureRegionFlds.RegionId, clsArray.GetSqlInStrByArray(arrRegionId, true));
            List<clsPrjFeatureEN> arrObjList = clsPrjFeatureBL.GetObjLst(strCondition);
            List<clsButtonTabENEx> arrButtonTabSet = new List<clsButtonTabENEx>();
            foreach (clsPrjFeatureEN objPrjFeatureEN in arrObjList)
            {
                clsPrjFeatureENEx objPrjFeatureENEx = new clsPrjFeatureENEx();
                clsPrjFeatureBL.CopyTo(objPrjFeatureEN, objPrjFeatureENEx);
                objPrjFeatureENEx.ButtonSet = clsvFeatureButtonRelaBLEx.GetObjLstByFeatureIdCacheEx(intAppTypeId, objPrjFeatureEN.FeatureId);
                if (objPrjFeatureENEx.ButtonSet == null)
                {
                    string strMsg = string.Format("应用:{0}({1}),功能:{2}({3})没有相关的按钮，请管理员！",
                        clsApplicationTypeBL.GetObjByApplicationTypeIdCache(intAppTypeId).ApplicationTypeName, intAppTypeId,
                        objPrjFeatureEN.FeatureName, objPrjFeatureEN.FeatureId);
                    throw new Exception(strMsg);
                }

                foreach (clsvFeatureButtonRelaEN objInFor2 in objPrjFeatureENEx.ButtonSet)
                {
                    clsButtonTabEN objButtonTabEN = clsButtonTabBL.GetObjByButtonIdCache(objInFor2.ButtonId);
                    clsButtonTabENEx objButtonTabENEx = new clsButtonTabENEx();
                    clsButtonTabBL.CopyTo(objButtonTabEN, objButtonTabENEx);
                    objButtonTabENEx.OrderNum4Feature = objInFor2.OrderNum;
                    arrButtonTabSet.Add(objButtonTabENEx);
                }
                //arrObjENExList.Add(objPrjFeatureENEx);
            }
            return arrButtonTabSet;
        }

        public static List<clsButtonTabENEx> GetObjExLstByFeatureRegionFldsLst(List<clsFeatureRegionFldsENEx> arrFeatureRegionFldsENEx, int intAppTypeId, string strPrjId)
        {
            List<clsButtonTabENEx> arrButtonTabSet = new List<clsButtonTabENEx>();
            foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsENEx)
            {
                List<clsButtonTabENEx> arrButtonTabSet_In = GetObjExLstByFeatureRegionFlds(objInFor, intAppTypeId, strPrjId);
                arrButtonTabSet_In.ForEach(x => 
                {
                    x.GroupName = objInFor.GroupName;

                    //x.ButtonName = string.Format("{0}_{1}", x.ButtonName, objInFor.ViewFeatureId);//生成Web应用出错
                    x.ButtonName = string.Format("btn{0}", x.ButtonName, objInFor.ViewFeatureId);
                    if (string.IsNullOrEmpty(x.CommandName) == true)
                    {
                        x.CommandName = objInFor.CommandName;
                        x.ButtonName = objInFor.ButtonName;
                        x.Text = objInFor.Text;
                    }
                    arrButtonTabSet.Add(x);
                    }
                );
            }
            return arrButtonTabSet;
        }
        public static List<clsButtonTabENEx> GetObjExLstByFeatureRegionFlds(clsFeatureRegionFldsEN objFeatureRegionFldsEN, int intAppTypeId, string strPrjId)
        {

            List<clsButtonTabENEx> arrButtonTabSet = new List<clsButtonTabENEx>();
            clsPrjFeatureEN objPrjFeatureEN = clsPrjFeatureBL.GetObjByFeatureIdCache(objFeatureRegionFldsEN.FeatureId);

            clsPrjFeatureENEx objPrjFeatureENEx = new clsPrjFeatureENEx();
            clsPrjFeatureBL.CopyTo(objPrjFeatureEN, objPrjFeatureENEx);

            objPrjFeatureENEx.ButtonSet = clsvFeatureButtonRelaBLEx.GetObjLstByFeatureIdCacheEx(intAppTypeId, objPrjFeatureEN.FeatureId);
            if (objPrjFeatureENEx.ButtonSet == null)
            {
                string strMsg = string.Format("应用:{0}({1}),功能:{2}({3})没有相关的按钮，请管理员！",
                    clsApplicationTypeBL.GetObjByApplicationTypeIdCache(intAppTypeId).ApplicationTypeName, intAppTypeId,
                    objPrjFeatureEN.FeatureName, objPrjFeatureEN.FeatureId);
                throw new Exception(strMsg);
            }

            foreach (clsvFeatureButtonRelaEN objInFor2 in objPrjFeatureENEx.ButtonSet)
            {
                clsButtonTabEN objButtonTabEN = clsButtonTabBL.GetObjByButtonIdCache(objInFor2.ButtonId);
                clsButtonTabENEx objButtonTabENEx = new clsButtonTabENEx();
                clsButtonTabBL.CopyTo(objButtonTabEN, objButtonTabENEx);
                objButtonTabENEx.OrderNum4Feature = objInFor2.OrderNum;
                arrButtonTabSet.Add(objButtonTabENEx);
            }
            //arrObjENExList.Add(objPrjFeatureENEx);

            return arrButtonTabSet;
        }


    }
}