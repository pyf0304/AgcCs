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
    public class clsvPrjTab4GeneCodeBLEx
    {
        /// <summary>
        /// 调用函数,根据用户和条件生成界面代码的日志视图
        /// </summary>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        /// <param name = "strCondition">条件</param>
        /// <returns>返回数据表DataTable</returns>
        public static System.Data.DataTable fn_getvPrjTab4GeneCodeByUserIdBak(
            string strUserId, int intApplicationTypeId, string strCondition)
        {
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strUserId);
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0},请检查!(clsvPrjTab4GeneCodeBLEx: fn_getvPrjTab4GeneCodeByUserId)",
                    objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();


            //select * from  Edu.fn_GetvPKaoStudentResV2_SubtotalById_StuInPKaoEduCls('2015-2016','1','15200005' ,12)
            strSQL = string.Format(" Select * from fn_getvPrjTab4GeneCodeByUserId('{0}', {1}) where {2}; ",
                strUserId, intApplicationTypeId, strCondition);
            
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// 调用函数,根据用户和条件生成界面代码的日志视图
        /// </summary>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        /// <param name = "strCondition">条件</param>
        /// <returns>返回数据表DataTable</returns>
        public static List<clsvPrjTab4GeneCodeEN> fn_getObjLstByUserIdBak(
            string strUserId, int intApplicationTypeId, string strCondition)
        {
            
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();


            //select * from  Edu.fn_GetvPKaoStudentResV2_SubtotalById_StuInPKaoEduCls('2015-2016','1','15200005' ,12)
            strSQL = string.Format(" Select * from fn_getvPrjTab4GeneCodeByUserId('{0}', {1}) where {2}; ",
                strUserId, intApplicationTypeId, strCondition);

            objDT = fn_getvPrjTab4GeneCodeByUserIdBak(strUserId, intApplicationTypeId, strCondition);
            List<clsvPrjTab4GeneCodeEN> arrvPrjTab4GeneCodeObjLst = clsvPrjTab4GeneCodeBL.GetObjLstFromDataTable(objDT);
            return arrvPrjTab4GeneCodeObjLst;
    
        }


        /// <summary>
        /// 调用函数,根据用户和条件生成界面代码的日志视图对象列表
        /// </summary>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strCondition">条件</param>
        /// <returns>界面代码的日志视图对象列表</returns>
        public static List<clsvPrjTab4GeneCodeEN> GetvPrjTab4GeneCodeObjListByUserIdAndConditionBak(
            string strUserId, int intApplicationTypeId, string strCondition)
        {

            DataTable objDT = fn_getvPrjTab4GeneCodeByUserIdBak(strUserId, intApplicationTypeId, strCondition);
            //StringBuilder sbCondition = new StringBuilder();
            //sbCondition.AppendFormat("SchoolYear = '{1}' And SchoolTerm = '{2}' And Id_PKaoEduClass<>'{0}' And Id_Stu in (Select Id_Stu From PKaoEduClsStu Where Id_PKaoEduClass = '{0}') And {3} = {4}  Order By Id_PKaoWeekTime, Id_PKaoEduClass",
            //    strId_EduClass, strSchoolYear, strSchoolTerm, clsvPrjTab4GeneCodeEN.con_WeekSeq, shtWeekSeq);

            List<clsvPrjTab4GeneCodeEN> arrvPrjTab4GeneCodeObjLst = clsvPrjTab4GeneCodeBL.GetObjLstFromDataTable(objDT);
            return arrvPrjTab4GeneCodeObjLst;
        }
    }
}
