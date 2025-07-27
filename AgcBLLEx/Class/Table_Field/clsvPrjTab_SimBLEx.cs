
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvPrjTab_SimBLEx
表名:vPrjTab_Sim(00050610)
生成代码版本:2022.05.07.1
生成日期:2022/10/29 11:27:48
生成者:pyf
生成服务器IP:
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)-WebApi函数集
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护(Table_Field)
框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
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

using com.taishsoft.comm_db_obj;
using AGC.Entity;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;
using com.taishsoft.commdb;

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_vPrjTab_SimEx : RelatedActions_vPrjTab_Sim
    {
        public override bool UpdRelaTabDate(string strTabId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsvPrjTab_SimBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvPrjTab_SimENS">源对象</param>
        /// <returns>目标对象=>clsvPrjTab_SimEN:objvPrjTab_SimENT</returns>
        public static clsvPrjTab_SimENEx CopyToEx(this clsvPrjTab_SimEN objvPrjTab_SimENS)
        {
            try
            {
                clsvPrjTab_SimENEx objvPrjTab_SimENT = new clsvPrjTab_SimENEx();
                clsvPrjTab_SimBL.vPrjTab_SimDA.CopyTo(objvPrjTab_SimENS, objvPrjTab_SimENT);
                return objvPrjTab_SimENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objvPrjTab_SimENS">源对象</param>
        /// <returns>目标对象=>clsvPrjTab_SimEN:objvPrjTab_SimENT</returns>
        public static clsvPrjTab_SimEN CopyTo(this clsvPrjTab_SimENEx objvPrjTab_SimENS)
        {
            try
            {
                clsvPrjTab_SimEN objvPrjTab_SimENT = new clsvPrjTab_SimEN();
                clsvPrjTab_SimBL.CopyTo(objvPrjTab_SimENS, objvPrjTab_SimENT);
                return objvPrjTab_SimENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// v工程表_SimV2(vPrjTab_Sim)
    /// 数据源类型:视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvPrjTab_SimBLEx : clsvPrjTab_SimBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvPrjTab_SimDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvPrjTab_SimDAEx vPrjTab_SimDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvPrjTab_SimDAEx();
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
        public static List<clsvPrjTab_SimENEx> GetObjExLst(string strCondition)
        {
            List<clsvPrjTab_SimEN> arrObjLst = clsvPrjTab_SimBL.GetObjLst(strCondition);
            List<clsvPrjTab_SimENEx> arrObjExLst = new List<clsvPrjTab_SimENEx>();
            foreach (clsvPrjTab_SimEN objInFor in arrObjLst)
            {
                clsvPrjTab_SimENEx objvPrjTab_SimENEx = new clsvPrjTab_SimENEx();
                clsvPrjTab_SimBL.CopyTo(objInFor, objvPrjTab_SimENEx);
                arrObjExLst.Add(objvPrjTab_SimENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strTabId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvPrjTab_SimENEx GetObjExByTabId(string strTabId)
        {
            clsvPrjTab_SimEN objvPrjTab_SimEN = clsvPrjTab_SimBL.GetObjByTabId(strTabId);
            clsvPrjTab_SimENEx objvPrjTab_SimENEx = new clsvPrjTab_SimENEx();
            clsvPrjTab_SimBL.CopyTo(objvPrjTab_SimEN, objvPrjTab_SimENEx);
            return objvPrjTab_SimENEx;
        }
        /// <summary>
        /// 调用函数,根据用户和条件生成界面代码的日志视图
        /// </summary>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strCondition">条件</param>
        /// <returns>返回数据表DataTable</returns>
        public static System.Data.DataTable fn_getvPrjTab_Sim(
            string strCmPrjId, string strCondition)
        {
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCmPrjId);
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!(clsvPrjTab_SimBLEx: fn_getvPrjTab_Sim)",
                    objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();


            //select * from  Edu.fn_GetvPKaoStudentResV2_SubtotalById_StuInPKaoEduCls('2015-2016','1','15200005' ,12)
            strSQL = string.Format(" Select * from fn_getvPrjTab_Sim('{0}') where {1}; ",
                strCmPrjId, strCondition);

            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        static Func<clsvPrjTab_SimEN, clsvPrjTab_SimENEx> GetObjEx = (x) =>
        {
            clsvPrjTab_SimENEx objPrjTabEx = new clsvPrjTab_SimENEx();
            CopyTo(x, objPrjTabEx);
            return objPrjTabEx;
        };
        /// <summary>
        /// 根据条件获取对象列表
        /// </summary>
        /// <param name = "strCmPrjId">CmPrjId</param>
        /// <returns>返回对象列表</returns>
        public static List<clsvPrjTab_SimEN> GetObjLstByCmPrjId(string strCmPrjId, string strWhereCond)
        {
            //string strWhereCond = string.Format(" FldId in (select fldid from prjtabfld where tabid in (select tabid from CMProjectPrjTab where cmprjid = '{0}')", strCmPrjId);

            List<clsvPrjTab_SimEN> arrObjLst = new List<clsvPrjTab_SimEN>();
            System.Data.DataTable objDT;
            objDT = fn_getvPrjTab_Sim(strCmPrjId, strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN();
                try
                {
                    objvPrjTab_SimEN = clsvPrjTab_SimBL.GetObjByDataRow_S(objRow);
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
                    objvPrjTab_SimEN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                arrObjLst.Add(objvPrjTab_SimEN);
            }
            return arrObjLst;
        }
        public static List<clsvPrjTab_SimENEx> GetObjExLstByPrjIdEx(string strPrjId)
        {
            if (string.IsNullOrEmpty(strPrjId) == true) return null;
            List<clsvPrjTab_SimEN> arr = clsvPrjTab_SimBL.GetObjLst(string.Format("PrjId='{0}'", strPrjId));
            List<clsvPrjTab_SimENEx> arrEx = arr.Select(GetObjEx).ToList();
            return arrEx;
        }
    }
}