
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvWebSrvClass4GeneCodeBLEx
表名:vWebSrvClass4GeneCode
生成代码版本:2018.01.16.1
生成日期:2018/02/06 23:38:23
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:生成C#代码
模块英文名:GeneCode
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
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
    /// vWebSrvClass4GeneCode(vWebSrvClass4GeneCode)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsvWebSrvClass4GeneCodeBLEx : clsvWebSrvClass4GeneCodeBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvWebSrvClass4GeneCodeDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvWebSrvClass4GeneCodeDAEx vWebSrvClass4GeneCodeDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvWebSrvClass4GeneCodeDAEx();
                }
                return uniqueInstanceEx;
            }
        }
        /// <summary>
        /// 调用函数,根据用户和条件生成界面代码的日志视图
        /// </summary>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strCondition">条件</param>
        /// <returns>返回数据表DataTable</returns>
        public static System.Data.DataTable fn_getvWebSrvClass4GeneCodeByUserId(
            string strUserId, string strCondition)
        {
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strUserId);
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!(clsvWebSrvClass4GeneCodeBLEx: fn_getvWebSrvClass4GeneCodeByUserId)",
                    objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsvWebSrvClass4GeneCodeDA.GetSpecSQLObj();


            //select * from  Edu.fn_GetvPKaoStudentResV2_SubtotalById_StuInPKaoEduCls('2015-2016','1','15200005' ,12)
            strSQL = string.Format(" Select * from fn_getvWebSrvClass4GeneCodeByUserId('{0}') where {1}; ",
                strUserId, strCondition);

            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 调用函数,根据用户和条件生成界面代码的日志视图对象列表
        /// </summary>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strCondition">条件</param>
        /// <returns>界面代码的日志视图对象列表</returns>
        public static List<clsvWebSrvClass4GeneCodeEN> GetObjLstByUserIdAndCondition(
            string strUserId, string strCondition)
        {

            DataTable objDT = fn_getvWebSrvClass4GeneCodeByUserId(strUserId, strCondition);
            //StringBuilder sbCondition = new StringBuilder();
            //sbCondition.AppendFormat("SchoolYear = '{1}' And SchoolTerm = '{2}' And Id_PKaoEduClass<>'{0}' And Id_Stu in (Select Id_Stu From PKaoEduClsStu Where Id_PKaoEduClass = '{0}') And {3} = {4}  Order By Id_PKaoWeekTime, Id_PKaoEduClass",
            //    strId_EduClass, strSchoolYear, strSchoolTerm, clsvWebSrvClass4GeneCodeEN.con_WeekSeq, shtWeekSeq);

            List<clsvWebSrvClass4GeneCodeEN> arrvWebSrvClass4GeneCodeObjLst = clsvWebSrvClass4GeneCodeBL.GetObjLstFromDataTable(objDT);
            return arrvWebSrvClass4GeneCodeObjLst;
        }
    }
}