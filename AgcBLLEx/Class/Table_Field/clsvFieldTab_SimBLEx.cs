
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvFieldTab_SimBLEx
表名:vFieldTab_Sim(00050590)
生成代码版本:2022.05.07.1
生成日期:2022/10/27 00:26:41
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
    public class RelatedActions_vFieldTab_SimEx : RelatedActions_vFieldTab_Sim
    {
        public override bool UpdRelaTabDate(string strFldId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsvFieldTab_SimBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvFieldTab_SimENS">源对象</param>
        /// <returns>目标对象=>clsvFieldTab_SimEN:objvFieldTab_SimENT</returns>
        public static clsvFieldTab_SimENEx CopyToEx(this clsvFieldTab_SimEN objvFieldTab_SimENS)
        {
            try
            {
                clsvFieldTab_SimENEx objvFieldTab_SimENT = new clsvFieldTab_SimENEx();
                clsvFieldTab_SimBL.vFieldTab_SimDA.CopyTo(objvFieldTab_SimENS, objvFieldTab_SimENT);
                return objvFieldTab_SimENT;
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
        /// <param name = "objvFieldTab_SimENS">源对象</param>
        /// <returns>目标对象=>clsvFieldTab_SimEN:objvFieldTab_SimENT</returns>
        public static clsvFieldTab_SimEN CopyTo(this clsvFieldTab_SimENEx objvFieldTab_SimENS)
        {
            try
            {
                clsvFieldTab_SimEN objvFieldTab_SimENT = new clsvFieldTab_SimEN();
                clsvFieldTab_SimBL.CopyTo(objvFieldTab_SimENS, objvFieldTab_SimENT);
                return objvFieldTab_SimENT;
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
    /// v字段表_Sim(vFieldTab_Sim)
    /// 数据源类型:视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvFieldTab_SimBLEx : clsvFieldTab_SimBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvFieldTab_SimDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvFieldTab_SimDAEx vFieldTab_SimDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvFieldTab_SimDAEx();
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
        public static List<clsvFieldTab_SimENEx> GetObjExLst(string strCondition)
        {
            List<clsvFieldTab_SimEN> arrObjLst = clsvFieldTab_SimBL.GetObjLst(strCondition);
            List<clsvFieldTab_SimENEx> arrObjExLst = new List<clsvFieldTab_SimENEx>();
            foreach (clsvFieldTab_SimEN objInFor in arrObjLst)
            {
                clsvFieldTab_SimENEx objvFieldTab_SimENEx = new clsvFieldTab_SimENEx();
                clsvFieldTab_SimBL.CopyTo(objInFor, objvFieldTab_SimENEx);
                arrObjExLst.Add(objvFieldTab_SimENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strFldId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvFieldTab_SimENEx GetObjExByFldId(string strFldId)
        {
            clsvFieldTab_SimEN objvFieldTab_SimEN = clsvFieldTab_SimBL.GetObjByFldId(strFldId);
            clsvFieldTab_SimENEx objvFieldTab_SimENEx = new clsvFieldTab_SimENEx();
            clsvFieldTab_SimBL.CopyTo(objvFieldTab_SimEN, objvFieldTab_SimENEx);
            return objvFieldTab_SimENEx;
        }
        /// <summary>
        /// 调用函数,根据用户和条件生成界面代码的日志视图
        /// </summary>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strCondition">条件</param>
        /// <returns>返回数据表DataTable</returns>
        public static System.Data.DataTable fn_getvFieldTab_Sim(
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
                throw new Exception(string.Format("在输入条件中含有{0},请检查!(clsvFieldTab_SimBLEx: fn_getvFieldTab_Sim)",
                    objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();


            //select * from  Edu.fn_GetvPKaoStudentResV2_SubtotalById_StuInPKaoEduCls('2015-2016','1','15200005' ,12)
            strSQL = string.Format(" Select * from fn_getvFieldTab_Sim('{0}') where {1}; ",
                strCmPrjId, strCondition);

            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 根据条件获取对象列表
        /// </summary>
        /// <param name = "strCmPrjId">CmPrjId</param>
        /// <returns>返回对象列表</returns>
        public static List<clsvFieldTab_SimEN> GetObjLstByCmPrjId(string strCmPrjId, string strWhereCond)
        {
            //string strWhereCond = string.Format(" FldId in (select fldid from prjtabfld where tabid in (select tabid from CMProjectPrjTab where cmprjid = '{0}')", strCmPrjId);

            List<clsvFieldTab_SimEN> arrObjLst = new List<clsvFieldTab_SimEN>();
            System.Data.DataTable objDT;
            objDT = fn_getvFieldTab_Sim(strCmPrjId, strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvFieldTab_SimEN objvFieldTab_SimEN = new clsvFieldTab_SimEN();
                try
                {
                    objvFieldTab_SimEN = clsvFieldTab_SimBL.GetObjByDataRow_S(objRow);

                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
                    objvFieldTab_SimEN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                arrObjLst.Add(objvFieldTab_SimEN);
            }
            return arrObjLst;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strPrjId">工程ID</param>
        public static void BindDdl_FldIdCacheEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v字段表_Sim]...", "0");
            string strCondition = string.Format("1 =1 Order By {0}", convFieldTab_Sim2.FldId);
            IEnumerable<clsvFieldTab_Sim2EN> arrObjLst = clsvFieldTab_Sim2BL.GetObjLstCache(strPrjId).OrderBy(x => x.FldName);
            arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = convFieldTab_Sim2.FldId;
            objDDL.DataTextField = convFieldTab_Sim2.FldName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

    }
}