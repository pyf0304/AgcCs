
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvPrjTabKeyFldV2BLEx
表名:vPrjTabKeyFldV2(00050612)
生成代码版本:2022.11.02.1
生成日期:2022/11/02 23:22:32
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
    public class RelatedActions_vPrjTabKeyFldV2Ex : RelatedActions_vPrjTabKeyFldV2
    {
        public override bool UpdRelaTabDate(string strTabId, string strOpUser)
        {
            return true;
        }
    }
    public static class clsvPrjTabKeyFldV2BLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvPrjTabKeyFldV2ENS">源对象</param>
        /// <returns>目标对象=>clsvPrjTabKeyFldV2EN:objvPrjTabKeyFldV2ENT</returns>
        public static clsvPrjTabKeyFldV2ENEx CopyToEx(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2ENS)
        {
            try
            {
                clsvPrjTabKeyFldV2ENEx objvPrjTabKeyFldV2ENT = new clsvPrjTabKeyFldV2ENEx();
                clsvPrjTabKeyFldV2BL.vPrjTabKeyFldV2DA.CopyTo(objvPrjTabKeyFldV2ENS, objvPrjTabKeyFldV2ENT);
                return objvPrjTabKeyFldV2ENT;
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
        /// <param name = "objvPrjTabKeyFldV2ENS">源对象</param>
        /// <returns>目标对象=>clsvPrjTabKeyFldV2EN:objvPrjTabKeyFldV2ENT</returns>
        public static clsvPrjTabKeyFldV2EN CopyTo(this clsvPrjTabKeyFldV2ENEx objvPrjTabKeyFldV2ENS)
        {
            try
            {
                clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2ENT = new clsvPrjTabKeyFldV2EN();
                clsvPrjTabKeyFldV2BL.CopyTo(objvPrjTabKeyFldV2ENS, objvPrjTabKeyFldV2ENT);
                return objvPrjTabKeyFldV2ENT;
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
    /// vPrjTabKeyFldV2(vPrjTabKeyFldV2)
    /// 数据源类型:视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvPrjTabKeyFldV2BLEx : clsvPrjTabKeyFldV2BL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvPrjTabKeyFldV2DAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvPrjTabKeyFldV2DAEx vPrjTabKeyFldV2DAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvPrjTabKeyFldV2DAEx();
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
        public static List<clsvPrjTabKeyFldV2ENEx> GetObjExLst(string strCondition)
        {
            List<clsvPrjTabKeyFldV2EN> arrObjLst = clsvPrjTabKeyFldV2BL.GetObjLst(strCondition);
            List<clsvPrjTabKeyFldV2ENEx> arrObjExLst = new List<clsvPrjTabKeyFldV2ENEx>();
            foreach (clsvPrjTabKeyFldV2EN objInFor in arrObjLst)
            {
                clsvPrjTabKeyFldV2ENEx objvPrjTabKeyFldV2ENEx = new clsvPrjTabKeyFldV2ENEx();
                clsvPrjTabKeyFldV2BL.CopyTo(objInFor, objvPrjTabKeyFldV2ENEx);
                arrObjExLst.Add(objvPrjTabKeyFldV2ENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strTabId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvPrjTabKeyFldV2ENEx GetObjExByTabId(string strTabId)
        {
            clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN = clsvPrjTabKeyFldV2BL.GetObjByTabId(strTabId);
            clsvPrjTabKeyFldV2ENEx objvPrjTabKeyFldV2ENEx = new clsvPrjTabKeyFldV2ENEx();
            clsvPrjTabKeyFldV2BL.CopyTo(objvPrjTabKeyFldV2EN, objvPrjTabKeyFldV2ENEx);
            return objvPrjTabKeyFldV2ENEx;
        }

        /// <summary>
        /// 调用函数,根据用户和条件生成界面代码的日志视图
        /// </summary>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strCondition">条件</param>
        /// <returns>返回数据表DataTable</returns>
        public static System.Data.DataTable fn_getvPrjTabKeyFldV2(
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
                throw new Exception(string.Format("在输入条件中含有{0},请检查!(clsvPrjTabKeyFldV2BLEx: fn_getvPrjTabKeyFldV2)",
                    objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();


            //select * from  Edu.fn_GetvPKaoStudentResV2_SubtotalById_StuInPKaoEduCls('2015-2016','1','15200005' ,12)
            strSQL = string.Format(" Select * from fn_getvPrjTabKeyFldV2('{0}') where {1}; ",
                strCmPrjId, strCondition);

            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 根据条件获取对象列表
        /// </summary>
        /// <param name = "strCmPrjId">CmPrjId</param>
        /// <returns>返回对象列表</returns>
        public static List<clsvPrjTabKeyFldV2EN> GetObjLstByCmPrjId(string strCmPrjId, string strWhereCond)
        {
            //string strWhereCond = string.Format(" FldId in (select fldid from prjtabfld where tabid in (select tabid from CMProjectPrjTab where cmprjid = '{0}')", strCmPrjId);

            List<clsvPrjTabKeyFldV2EN> arrObjLst = new List<clsvPrjTabKeyFldV2EN>();
            System.Data.DataTable objDT;
            objDT = fn_getvPrjTabKeyFldV2(strCmPrjId, strWhereCond);
            if (objDT.Rows.Count == 0)
            {
                return arrObjLst;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN = new clsvPrjTabKeyFldV2EN();
                try
                {
                    objvPrjTabKeyFldV2EN.TabId = objRow[convPrjTabKeyFldV2.TabId].ToString().Trim(); //表ID
                    objvPrjTabKeyFldV2EN.FldId = objRow[convPrjTabKeyFldV2.FldId].ToString().Trim(); //字段Id
                    objvPrjTabKeyFldV2EN.PrimaryTypeId = objRow[convPrjTabKeyFldV2.PrimaryTypeId].ToString().Trim(); //主键类型ID
                    objvPrjTabKeyFldV2EN.KeyFldName = objRow[convPrjTabKeyFldV2.KeyFldName].ToString().Trim(); //关键字段名
                    objvPrjTabKeyFldV2EN.PrimaryTypeName = objRow[convPrjTabKeyFldV2.PrimaryTypeName].ToString().Trim(); //主键类型名
                    objvPrjTabKeyFldV2EN.FieldTypeId = objRow[convPrjTabKeyFldV2.FieldTypeId].ToString().Trim(); //字段类型Id
                    objvPrjTabKeyFldV2EN.CmPrjId = objRow[convPrjTabKeyFldV2.CmPrjId].ToString().Trim(); //CmPrjId
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
                    objvPrjTabKeyFldV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                arrObjLst.Add(objvPrjTabKeyFldV2EN);
            }
            return arrObjLst;
        }

    }
}