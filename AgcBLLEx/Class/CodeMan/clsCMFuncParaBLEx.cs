
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsCMFuncParaBLEx
表名:CMFuncPara(00050503)
生成代码版本:2019.10.24.1
生成日期:2019/10/27 10:44:44
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
    public static class clsCMFuncParaBLEx_Static
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objCMFuncParaEN"></param>
        /// <param name="strProgLangTypeId"></param>
        /// <returns></returns>
        public static string GetParaTypeName4CM(this clsCMFuncParaEN objCMFuncParaEN, string strProgLangTypeId)
        {
            //            throw new NotImplementedException();
            switch (objCMFuncParaEN.DataTypeId)
            {
                case enumDataTypeAbbr.Object_29:
                    return objCMFuncParaEN.ParameterType;
                case enumDataTypeAbbr.ObjectLst_30:
                    string strParameterType = objCMFuncParaEN.ParameterType.Replace("[", "<")
                              .Replace("]", ">");
                    return strParameterType;
                case "99":
                    return "Other";
                default:
                    clsDataTypeAbbrEN objDataTypeAbbr = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objCMFuncParaEN.DataTypeId);
                    return objDataTypeAbbr.GetTypeString(strProgLangTypeId);
            }
          
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objCMFuncParaENS">源对象</param>
        /// <returns>目标对象=>clsCMFuncParaEN:objCMFuncParaENT</returns>
        public static clsCMFuncParaENEx CopyToEx(this clsCMFuncParaEN objCMFuncParaENS)
        {
            try
            {
                clsCMFuncParaENEx objCMFuncParaENT = new clsCMFuncParaENEx();
                clsCMFuncParaBL.CopyTo(objCMFuncParaENS, objCMFuncParaENT);
                return objCMFuncParaENT;
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
        /// <param name = "objCMFuncParaENS">源对象</param>
        /// <returns>目标对象=>clsCMFuncParaEN:objCMFuncParaENT</returns>
        public static clsCMFuncParaEN CopyTo(this clsCMFuncParaENEx objCMFuncParaENS)
        {
            try
            {
                clsCMFuncParaEN objCMFuncParaENT = new clsCMFuncParaEN();
                clsCMFuncParaBL.CopyTo(objCMFuncParaENS, objCMFuncParaENT);
                return objCMFuncParaENT;
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
    /// CM函数参数(CMFuncPara)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsCMFuncParaBLEx : clsCMFuncParaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsCMFuncParaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsCMFuncParaDAEx CMFuncParaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsCMFuncParaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="strCmFuncParaId">表关键字</param>
        /// <returns></returns>
        public new static bool DelRecordEx(string strCmFuncParaId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsCMFuncParaDA.GetSpecSQLObj();
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
                //删除与表:[CMFuncPara]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //conCMFuncPara.CmFuncParaId,
                //strCmFuncParaId);
                //        clsCMFuncParaBL.DelCMFuncParasByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsCMFuncParaBL.DelRecord(strCmFuncParaId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsCMFuncParaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strCmFuncParaId, clsStackTrace.GetCurrClassFunction());
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

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsCMFuncParaENEx> GetObjExLst(string strCondition)
        {
            List<clsCMFuncParaEN> arrObjLst = clsCMFuncParaBL.GetObjLst(strCondition);
            List<clsCMFuncParaENEx> arrObjExLst = new List<clsCMFuncParaENEx>();
            foreach (clsCMFuncParaEN objInFor in arrObjLst)
            {
                clsCMFuncParaENEx objCMFuncParaENEx = new clsCMFuncParaENEx();
                clsCMFuncParaBL.CopyTo(objInFor, objCMFuncParaENEx);
                arrObjExLst.Add(objCMFuncParaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strCmFuncParaId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsCMFuncParaENEx GetObjExByCmFuncParaId(string strCmFuncParaId)
        {
            clsCMFuncParaEN objCMFuncParaEN = clsCMFuncParaBL.GetObjByCmFuncParaId(strCmFuncParaId);
            clsCMFuncParaENEx objCMFuncParaENEx = new clsCMFuncParaENEx();
            clsCMFuncParaBL.CopyTo(objCMFuncParaEN, objCMFuncParaENEx);
            return objCMFuncParaENEx;
        }

        public static clsCMFuncParaEN AddCMFuncPara(clsCMFuncParaEN objCMFuncPara)
        {
            clsCMFuncParaEN objCMFuncPara_Cond = new clsCMFuncParaEN();
            string strCondition = objCMFuncPara_Cond
                .SetPrjId(objCMFuncPara.PrjId, "=")
                .SetParaName(objCMFuncPara.ParaName, "=")
                            .SetParameterType(objCMFuncPara.ParameterType, "=")
               .SetDataTypeId(objCMFuncPara.DataTypeId, "=")
.GetUniCondStr();

            bool bolIsExist = clsCMFuncParaBL.IsExistRecord(strCondition);

            if (bolIsExist)
            {
                objCMFuncPara.CmFuncParaId = clsCMFuncParaBL.GetFirstID_S(strCondition);
                objCMFuncPara.UpdateWithCondition(strCondition);
            }
            else
            {

                objCMFuncPara.SetCmFuncParaId(clsCMFuncParaBL.GetMaxStrId_S());
                objCMFuncPara.AddNewRecord();
            }

            return objCMFuncPara;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_CmFuncParaIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[函数参数4Code]...", "0");
            string strCondition = string.Format("1 =1 and {0}='{1}' Order By {2}",
                conCMFuncPara.PrjId, strPrjId, conCMFuncPara.ParaName);
            List<clsCMFuncParaEN> arrObjLst = clsCMFuncParaBL.GetObjLst(strCondition).OrderBy(x => x.ParaName).ToList();
            arrObjLst.ForEach(x => x.ParaName = string.Format("{1}({0}){2}", x.ParameterType, x.ParaName, x.IsByRef ? "(ByRef)" : ""));

            objDDL.DataValueField = conCMFuncPara.CmFuncParaId;
            objDDL.DataTextField = conCMFuncPara.ParaName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 克隆记录
        /// </summary>
        /// <param name="strCmFuncParaId">strCmFuncParaId</param>
        /// <returns></returns>
        public static clsCMFuncParaEN CloneRecord(string strCmFuncParaId, string strUserId)
        {
            clsCMFuncParaEN objCMFuncParaEN = clsCMFuncParaBL.GetObjByCmFuncParaId(strCmFuncParaId);

            objCMFuncParaEN.CmFuncParaId = clsCMFuncParaBL.GetMaxStrId_S();
            objCMFuncParaEN.ParaName = "Copy_" + objCMFuncParaEN.ParaName;
            objCMFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
            objCMFuncParaEN.UpdUser = strUserId;
            //if (string.IsNullOrEmpty(obj.ReturnTypeId))
            //{
            //    obj.ReturnTypeId = "29";
            //}
            try
            {
                clsCMFuncParaBL.AddNewRecordBySql2(objCMFuncParaEN);
                return objCMFuncParaEN;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("克隆记录出错！错误：{0}。(strCmFuncParaId:{1})({2})",
                     objException.Message,
                     strCmFuncParaId,
                     clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
        }

    }
}