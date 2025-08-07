
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvFieldTab_Sim3BLEx
表名:vFieldTab_Sim3(00050590)
生成代码版本:2021.07.03.1
生成日期:2021/07/05 16:43:12
生成者:pyf
生成服务器IP:103.116.76.183
工程名称:AGC
工程ID:0005
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护
模块英文名:Table_Field
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


namespace AGC.BusinessLogicEx
{
    public static class clsvFieldTab_Sim3BLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvFieldTab_Sim3ENS">源对象</param>
        /// <returns>目标对象=>clsvFieldTab_Sim3EN:objvFieldTab_Sim3ENT</returns>
        public static clsvFieldTab_Sim3ENEx CopyToEx(this clsvFieldTab_Sim3EN objvFieldTab_Sim3ENS)
        {
            try
            {
                clsvFieldTab_Sim3ENEx objvFieldTab_Sim3ENT = new clsvFieldTab_Sim3ENEx();
                clsvFieldTab_Sim3BL.vFieldTab_Sim3DA.CopyTo(objvFieldTab_Sim3ENS, objvFieldTab_Sim3ENT);
                return objvFieldTab_Sim3ENT;
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
        /// <param name = "objvFieldTab_Sim3ENS">源对象</param>
        /// <returns>目标对象=>clsvFieldTab_Sim3EN:objvFieldTab_Sim3ENT</returns>
        public static clsvFieldTab_Sim3EN CopyTo(this clsvFieldTab_Sim3ENEx objvFieldTab_Sim3ENS)
        {
            try
            {
                clsvFieldTab_Sim3EN objvFieldTab_Sim3ENT = new clsvFieldTab_Sim3EN();
                clsvFieldTab_Sim3BL.CopyTo(objvFieldTab_Sim3ENS, objvFieldTab_Sim3ENT);
                return objvFieldTab_Sim3ENT;
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
    /// v字段表_Sim(vFieldTab_Sim3)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvFieldTab_Sim3BLEx : clsvFieldTab_Sim3BL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvFieldTab_Sim3DAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvFieldTab_Sim3DAEx vFieldTab_Sim3DAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvFieldTab_Sim3DAEx();
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
        public static List<clsvFieldTab_Sim3ENEx> GetObjExLst(string strCondition)
        {
            List<clsvFieldTab_Sim3EN> arrObjLst = clsvFieldTab_Sim3BL.GetObjLst(strCondition);
            List<clsvFieldTab_Sim3ENEx> arrObjExLst = new List<clsvFieldTab_Sim3ENEx>();
            foreach (clsvFieldTab_Sim3EN objInFor in arrObjLst)
            {
                clsvFieldTab_Sim3ENEx objvFieldTab_Sim3ENEx = new clsvFieldTab_Sim3ENEx();
                clsvFieldTab_Sim3BL.CopyTo(objInFor, objvFieldTab_Sim3ENEx);
                arrObjExLst.Add(objvFieldTab_Sim3ENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strFldId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvFieldTab_Sim3ENEx GetObjExByFldId(string strFldId)
        {
            clsvFieldTab_Sim3EN objvFieldTab_Sim3EN = clsvFieldTab_Sim3BL.GetObjByFldId(strFldId);
            clsvFieldTab_Sim3ENEx objvFieldTab_Sim3ENEx = new clsvFieldTab_Sim3ENEx();
            clsvFieldTab_Sim3BL.CopyTo(objvFieldTab_Sim3EN, objvFieldTab_Sim3ENEx);
            return objvFieldTab_Sim3ENEx;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strPrjId">工程ID</param>
        public static void BindDdl_FldId_CacheEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v字段表_Sim]...", "0");
            string strCondition = string.Format("1 =1 Order By {0}", convFieldTab_Sim3.FldId);
            IEnumerable<clsvFieldTab_Sim3EN> arrObjLst = clsvFieldTab_Sim3BL.GetObjLst_Cache(strPrjId).OrderBy(x => x.FldName);
            arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = convFieldTab_Sim3.FldId;
            objDDL.DataTextField = convFieldTab_Sim3.FldName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 根据条件获取对象列表
        /// </summary>
        /// <param name = "strCmPrjId">CmPrjId</param>
        /// <returns>返回对象列表</returns>
        public static List<clsvFieldTab_Sim3EN> GetObjLstByCmPrjId(string strCmPrjId)
        {
            string strWhereCond = string.Format(" FldId in (select fldid from prjtabfld where tabid in (select tabid from CMProjectPrjTab where cmprjid = '{0}')", strCmPrjId);

            List<clsvFieldTab_Sim3EN> arrObjLst = new List<clsvFieldTab_Sim3EN>();
            System.Data.DataTable objDT;
            objDT = GetDataTable(strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvFieldTab_Sim3EN objvFieldTab_Sim3EN = new clsvFieldTab_Sim3EN();
                try
                {
                    objvFieldTab_Sim3EN.FldId = objRow[convFieldTab_Sim3.FldId].ToString().Trim(); //字段Id
                    objvFieldTab_Sim3EN.FldName = objRow[convFieldTab_Sim3.FldName].ToString().Trim(); //字段名
                    objvFieldTab_Sim3EN.DataTypeId = objRow[convFieldTab_Sim3.DataTypeId].ToString().Trim(); //数据类型Id
                    objvFieldTab_Sim3EN.PrjId = objRow[convFieldTab_Sim3.PrjId].ToString().Trim(); //工程ID
                    //objvFieldTab_Sim3EN.FieldTypeId = objRow[convFieldTab_Sim3.FieldTypeId].ToString().Trim(); //字段类型Id
                    objvFieldTab_Sim3EN.Caption = objRow[convFieldTab_Sim3.Caption].ToString().Trim(); //标题
                    //objvFieldTab_Sim3EN.FldLength = Int32.Parse(objRow[convFieldTab_Sim3.FldLength].ToString().Trim()); //字段长度
                    //objvFieldTab_Sim3EN.FldPrecision = clsEntityBase2.TransNullToInt_S(objRow[convFieldTab_Sim3.FldPrecision].ToString().Trim()); //精确度
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
                    objvFieldTab_Sim3EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                arrObjLst.Add(objvFieldTab_Sim3EN);
            }
            return arrObjLst;
        }
        /// <summary>
        /// 调用函数,根据用户和条件生成界面代码的日志视图
        /// </summary>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strCondition">条件</param>
        /// <returns>返回数据表DataTable</returns>
        public static System.Data.DataTable fn_getvFieldTab_Sim3(
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
                throw new Exception(string.Format("在输入条件中含有{0},请检查!(clsvFieldTab_Sim3BLEx: fn_getvFieldTab_Sim3)",
                    objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();


            //select * from  Edu.fn_GetvPKaoStudentResV2_SubtotalById_StuInPKaoEduCls('2015-2016','1','15200005' ,12)
            strSQL = string.Format(" Select * from fn_getvFieldTab_Sim3('{0}') where {1}; ",
                strCmPrjId, strCondition);

            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 根据条件获取对象列表
        /// </summary>
        /// <param name = "strCmPrjId">CmPrjId</param>
        /// <returns>返回对象列表</returns>
        public static List<clsvFieldTab_Sim3EN> GetObjLst3ByCmPrjId(string strCmPrjId, string strWhereCond)
        {
            //string strWhereCond = string.Format(" FldId in (select fldid from prjtabfld where tabid in (select tabid from CMProjectPrjTab where cmprjid = '{0}')", strCmPrjId);

            List<clsvFieldTab_Sim3EN> arrObjLst = new List<clsvFieldTab_Sim3EN>();
            System.Data.DataTable objDT;
            objDT = fn_getvFieldTab_Sim3(strCmPrjId, strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvFieldTab_Sim3EN objvFieldTab_Sim3EN = new clsvFieldTab_Sim3EN();
                try
                {
                    objvFieldTab_Sim3EN = clsvFieldTab_Sim3BL.GetObjByDataRow_S(objRow);
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
                    objvFieldTab_Sim3EN.FldId, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                arrObjLst.Add(objvFieldTab_Sim3EN);
            }
            return arrObjLst;
        }
    }
}