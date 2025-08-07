
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsAppCodeTypeRelaBLEx
表名:AppCodeTypeRela(00050418)
生成代码版本:2018.09.02.1
生成日期:2018/09/03 08:09:39
生成者:潘以锋
生成服务器IP:202.121.63.42
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成代码
模块英文名:GeneCode
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2018.07.27.01
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
using System.Web.UI.WebControls;
using com.taishsoft.util;
using System.Net;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 应用程序代码类型关系(AppCodeTypeRela)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsAppCodeTypeRelaBLEx : clsAppCodeTypeRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsAppCodeTypeRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsAppCodeTypeRelaDAEx AppCodeTypeRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsAppCodeTypeRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DelRecordEx)
        /// </summary>
        /// <param name="lngmId">表关键字</param>
        /// <returns></returns>
        private new static bool DelRecordEx(long lngmId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
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
                //删除与表:[AppCodeTypeRela]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //constStudent.id_College,
                //strid_College);
                //        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsAppCodeTypeRelaBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsAppCodeTypeRelaBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                lngmId, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog4Error.WriteDebugLog(strMsg);
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
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "lngmId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsAppCodeTypeRelaEN GetObjByAppAndCodeType(int intApplicationTypeId, string strCodeTypeId)
        {
            //初始化列表缓存
       
            IEnumerable<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLstCache = clsAppCodeTypeRelaBL.GetObjLstCache();
            IEnumerable<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLst_Sel1 =
            from objAppCodeTypeRelaEN in arrAppCodeTypeRelaObjLstCache
            where objAppCodeTypeRelaEN.ApplicationTypeId == intApplicationTypeId
            && objAppCodeTypeRelaEN.CodeTypeId == strCodeTypeId
            select objAppCodeTypeRelaEN;

            List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLst_Sel = new List<clsAppCodeTypeRelaEN>();
            foreach (clsAppCodeTypeRelaEN obj in arrAppCodeTypeRelaObjLst_Sel1)
            {
                arrAppCodeTypeRelaObjLst_Sel.Add(obj);
            }
            if (arrAppCodeTypeRelaObjLst_Sel.Count == 0)
            {
                return null;
            }
            return arrAppCodeTypeRelaObjLst_Sel[0];
        }
        public static void BindDdl_DependsOn(DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");

            IEnumerable<clsvAppCodeTypeRelaEN> arrvAppCodeTypeRela = clsvAppCodeTypeRelaBL.GetObjLstCache();
            List<string> arrDependsOn = arrvAppCodeTypeRela.Select(x => x.DependsOn).ToList();
            List<string> arrDependsOn_Split = new List<string>();

            arrDependsOn.ForEach(x =>
            {
                if (x != null)
                {
                    string[] sstrDependsOn = x.Split(",".ToCharArray());
                    foreach (string strInFor in sstrDependsOn)
                    {
                        if (string.IsNullOrEmpty(strInFor) == true) continue;
                        if (arrDependsOn_Split.Contains(strInFor) == false) arrDependsOn_Split.Add(strInFor);
                    }
                }
            });


            IEnumerable<clsCboObject> arrCboObject = arrDependsOn_Split
                    .OrderBy(x => x)
                    .Select(x => new clsCboObject(x, x));
            objDDL.DataValueField = clsCboObject.con_Value;
            objDDL.DataTextField = clsCboObject.con_Text;
            objDDL.DataSource = arrCboObject;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;

        }


        public static void BindDdl_FrontOrBack(DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");

            IEnumerable<clsvAppCodeTypeRelaEN> arrvAppCodeTypeRela = clsvAppCodeTypeRelaBL.GetObjLstCache();
            List<string> arrFrontOrBack = arrvAppCodeTypeRela.Select(x => x.FrontOrBack).ToList();
            List<string> arrFrontOrBack_Split = new List<string>();

            arrFrontOrBack.ForEach(x =>
            {
                if (x != null)
                {
                    string[] sstrFrontOrBack = x.Split(",".ToCharArray());
                    foreach (string strInFor in sstrFrontOrBack)
                    {
                        if (string.IsNullOrEmpty(strInFor) == true) continue;
                        if (arrFrontOrBack_Split.Contains(strInFor) == false) arrFrontOrBack_Split.Add(strInFor);
                    }
                }
            });


            IEnumerable<clsCboObject> arrCboObject = arrFrontOrBack_Split
                    .OrderBy(x => x)
                    .Select(x => new clsCboObject(x, x));
            objDDL.DataValueField = clsCboObject.con_Value;
            objDDL.DataTextField = clsCboObject.con_Text;
            objDDL.DataSource = arrCboObject;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;

        }

    }
}