
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvPrjFeatureDAEx
表名:vPrjFeature
生成代码版本:2017.05.06.1
生成日期:2017/05/07
生成者:
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:数据处理扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.commexception;
using com.taishsoft.commdb;

using AGC.Entity;

namespace AGC.DAL
{
    /// <summary>
    /// vPrjFeature(vPrjFeature)
    /// (AutoGCLib.AutoGC6Cs_M:A_GenDALExCode)
    /// </summary>
    public class clsvPrjFeatureDAEx : clsvPrjFeatureDA
    {
        
        /// <summary>
        /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查        
        /// </summary>
        /// <param name = "strCondition">条件串</param>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        /// <returns>返回数据表DataTable</returns>
        public System.Data.DataTable GetDataTableByAppId(string strCondition, int intApplicationTypeId)
        {
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPrjFeatureDA: GetDataTable)", objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsvPrjFeatureDA.GetSpecSQLObj();
            strSQL = string.Format("Select * from dbo.fn_getvPrjFeature({0}) where {1}",
                intApplicationTypeId,
                strCondition);
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }
    }
}