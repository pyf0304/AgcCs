
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvFunction4CodeDAEx
表名:vFunction4Code
生成代码版本:2018.03.01.1
生成日期:2018/03/03 01:32:58
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:项目函数管理
模块英文名:PrjFunction
框架-层名:数据处理扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
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
    /// v函数4Code(vFunction4Code)
    /// (AutoGCLib.AutoGC6Cs_M:A_GenDALExCode)
    /// </summary>
    public class clsvFunction4CodeDAEx : clsvFunction4CodeDA
    {
        //以下是属性变量
        /// <summary>
        /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
        /// (AutoGCLib.AutoGCPubFuncV6:GenGetCondRecSet_S)
        /// </summary>
        /// <param name = "strCondition">条件串</param>
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
                throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFunction4CodeDA: GetDataTable)", objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
            strSQL = string.Format("Select * from dbo.fn_getvFunction4Code({0}) where {1}", 
                intApplicationTypeId, 
                strCondition);
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }
    }
}