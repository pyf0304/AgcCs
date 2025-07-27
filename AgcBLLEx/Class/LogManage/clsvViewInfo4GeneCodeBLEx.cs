using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using com.taishsoft.commdb;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public class clsvViewInfo4GeneCodeBLEx
    {
        /// <summary>
        /// 调用函数,根据用户和条件生成界面代码的日志视图
        /// </summary>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strCondition">条件</param>
        /// <returns>返回数据表DataTable</returns>
        public static System.Data.DataTable fn_getvViewInfo4GeneCodeByUserIdBak(
            string strUserId, string strCondition)
        {
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strUserId);
                clsCommonRegular.CheckStrSQL_Weak(strCondition);

            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!(clsvViewInfo4GeneCodeBLEx: fn_getvViewInfo4GeneCodeByUserId)",
                    objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsvViewInfo4GeneCodeDA.GetSpecSQLObj();


            //select * from  Edu.fn_GetvPKaoStudentResV2_SubtotalById_StuInPKaoEduCls('2015-2016','1','15200005' ,12)
            strSQL = string.Format("Select * from fn_getvViewInfo4GeneCodeByUserId('{0}') where {1}; ",
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
        public static List<clsvViewInfo4GeneCodeEN> GetvViewInfo4GeneCodeObjListByUserIdAndConditionBak(
            string strUserId, string strCondition)
        {
            DataTable objDT = fn_getvViewInfo4GeneCodeByUserIdBak(strUserId, strCondition);
            //StringBuilder sbCondition = new StringBuilder();
            //sbCondition.AppendFormat("SchoolYear = '{1}' And SchoolTerm = '{2}' And Id_PKaoEduClass<>'{0}' And Id_Stu in (Select Id_Stu From PKaoEduClsStu Where Id_PKaoEduClass = '{0}') And {3} = {4}  Order By Id_PKaoWeekTime, Id_PKaoEduClass",
            //    strId_EduClass, strSchoolYear, strSchoolTerm, clsvViewInfo4GeneCodeEN.con_WeekSeq, shtWeekSeq);

            List<clsvViewInfo4GeneCodeEN> arrvViewInfo4GeneCodeObjLst = clsvViewInfo4GeneCodeBL.GetObjLstFromDataTable(objDT);
            return arrvViewInfo4GeneCodeObjLst;
        }

    }
}
