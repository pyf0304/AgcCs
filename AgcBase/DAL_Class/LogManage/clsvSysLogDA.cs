
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysLogDA
 表名:vSysLog(00050262)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:15
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
 框架-层名:数据处理层(CS)(DALCode)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commdb;
using AGC.Entity;

namespace AGC.DAL
{
 /// <summary>
 /// v系统日志(vSysLog)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsvSysLogDA : clsCommBase4DA
{
 /// <summary>
 /// 错误信息
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected const string EXCEPTION_MSG = "出错:"; //there was an error in the method. please see the Application Log for details.";
 /// <summary>
 /// 模块名称
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected string mstrModuleName;
//以下是属性变量

 /// <summary>
 /// 当前表名
 /// </summary>
 public override string _CurrTabName
 {
 get
 {
 return clsvSysLogEN._CurrTabName;
 }
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.DALCode4CSharp:Gen_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvSysLogEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSysLogEN._ConnectString);
}
return objSQL;
}


 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetSpecSQLObj_Obj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public override clsSpecSQLforSql GetSpecSQLObj_Obj() 
{
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
 if (string.IsNullOrEmpty(clsvSysLogEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvSysLogEN._ConnectString);
 }
 return objSQL;
 }


 #region 获取数据表的DataSet

 /// <summary>
 /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCond_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSet(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
 strSQL = "Select * from vSysLog where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vSysLog");
 return objDS;
}

 /// <summary>
 /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查,用存储过程来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondBySP_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetByCondBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vSysLog_SelectByCond",values, "vSysLog");
return objDS;
}

 /// <summary>
 /// 根据条件获取当前表的顶部数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetTopDataSetByCond_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSet_Top(int intTopSize, string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vSysLog where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vSysLog");
 return objDS;
}

 /// <summary>
 /// 根据条件获取一定范围数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondByRange_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvSysLogDA: GetvSysLogByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvSysLogDA: GetvSysLogByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvSysLogDA: GetvSysLogByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vSysLog a where {0} And a.mId not in (Select Top {2} mId From vSysLog Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vSysLog");
return objDS;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataSet表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondByRange_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns>返回数据集DataSet</returns>
public System.Data.DataSet GetDataSetByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvSysLogDA: GetvSysLogByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvSysLogDA: GetvSysLogByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvSysLogDA: GetvSysLogByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vSysLog a where {0} And a.mId not in (Select Top {2} mId From vSysLog Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vSysLog");
return objDS;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataSet表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataSetByCondByRange_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns>返回满足条件一定范围的DataSet</returns>
public System.Data.DataSet GetDataSetByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvSysLogDA: GetvSysLogByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvSysLogDA: GetvSysLogByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvSysLogDA: GetvSysLogByRange)", intMaxNum, intMinNum));
 }
try
{
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataSet)ByRange", objException.Message));
}
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vSysLog a where {0} And a.mId not in (Select Top {2} mId From vSysLog Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vSysLog");
return objDS;
}

 #endregion 获取数据表的DataSet

 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
strSQL = "Select * from vSysLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vSysLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataTable_vSysLog)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
strSQL = "Select * from vSysLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(给定表名)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
strSQL = "Select * from vSysLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
strSQL = "Select * from vSysLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByTabName_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)
{
 return GetDataTable_Top(objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysLog where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysLog where {1} order by {2}", intTopSize, strCondition, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S_Exclude)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vSysLog where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:Gen_GetDataTable_Top_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vSysLog where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvSysLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中，strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} vSysLog.* from vSysLog Left Join {1} on {2} where {3} and vSysLog.mId not in (Select top {5} vSysLog.mId from vSysLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysLog where {1} and mId not in (Select top {2} mId from vSysLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysLog where {1} and mId not in (Select top {3} mId from vSysLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S_Exclude)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvSysLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中，strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} vSysLog.* from vSysLog Left Join {1} on {2} where {3} and vSysLog.mId not in (Select top {5} vSysLog.mId from vSysLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysLog where {1} and mId not in (Select top {2} mId from vSysLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysLog where {1} and mId not in (Select top {3} mId from vSysLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByPager_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, bool bolIsCheckSQLAttack)
{
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvSysLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var IsAscOrDesc = "Asc";
if (strOrderBy.IndexOf(" Asc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Asc", "");
IsAscOrDesc = "Asc";
}
else if (strOrderBy.IndexOf(" Desc", StringComparison.InvariantCultureIgnoreCase) > 0)
{
strOrderBy = strOrderBy.Replace(" Desc", "");
IsAscOrDesc = "Desc";
}
var arrPart = strOrderBy.Split('|');
if (arrPart.Length != 3)
{
throw new Exception(string.Format("在带有特殊排序分页查询中，strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} vSysLog.* from vSysLog Left Join {1} on {2} where {3} and vSysLog.mId not in (Select top {5} vSysLog.mId from vSysLog Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysLog where {1} and mId not in (Select top {2} mId from vSysLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysLog where {1} and mId not in (Select top {3} mId from vSysLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByRange_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvSysLogDA: GetvSysLogByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvSysLogDA: GetvSysLogByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvSysLogDA: GetvSysLogByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vSysLog a where {0} And a.mId not in (Select Top {2} mId From vSysLog Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vSysLog a where {0} And a.mId not in (Select Top {2} mId From vSysLog Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByRange_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum, List<string> lstExclude)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvSysLogDA: GetvSysLogByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvSysLogDA: GetvSysLogByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvSysLogDA: GetvSysLogByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vSysLog a where {0} And a.mId not in (Select Top {2} mId From vSysLog Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vSysLog a where {0} And a.mId not in (Select Top {2} mId From vSysLog Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取一定范围的数据表,用DataTable表示,同时可以决定是否检查SQL攻击
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableByRange_S_IsCheckSQLAttack)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "bolIsCheckSQLAttack">是否检查Sql攻击</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "intMinNum">范围之最小值</param>
 /// <param name = "intMaxNum">范围之最大值</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum, bool bolIsCheckSQLAttack)
{
     if (intMinNum <=  0)
 {
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvSysLogDA: GetvSysLogByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvSysLogDA: GetvSysLogByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvSysLogDA: GetvSysLogByRange)", intMaxNum, intMinNum));
 }
try
 {
 if (bolIsCheckSQLAttack  ==  true)
 {
 clsCheckSql.CheckStrSQL(strCondition);
 }
 else
 {
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
 }
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
strSQL = "Select * from vSysLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查, 用存储过程来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTableBySP_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByCondBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvSysLogDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vSysLog_SelectByCond",values);
return objDT;
}

 #endregion 获取数据表的DataTable

 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvSysLogEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvSysLogDA:GetObjLst)", objException.Message));
}
List<clsvSysLogEN> arrObjLst = new List<clsvSysLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
strSQL = "Select * from vSysLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
try
{
objvSysLogEN.mId = TransNullToInt(objRow[convSysLog.mId].ToString().Trim()); //mId
objvSysLogEN.UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(); //用户名
objvSysLogEN.LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(); //登陆时间
objvSysLogEN.LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(); //登陆日期
objvSysLogEN.PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(); //工程名称
objvSysLogEN.TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(); //表名
objvSysLogEN.TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(); //数据表关键字值
objvSysLogEN.OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(); //操作类型名称
objvSysLogEN.UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(); //用户IP
objvSysLogEN.OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objvSysLogEN.OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(); //操作内容
objvSysLogEN.OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(); //操作日期
objvSysLogEN.PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(); //工程ID
objvSysLogEN.OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(); //操作时间
objvSysLogEN.UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(); //用户Id
objvSysLogEN.Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSysLogDA: GetObjLst)", objException.Message));
}
objvSysLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSysLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstByTabName)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回对象列表</returns>
public List<clsvSysLogEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvSysLogDA:GetObjLstByTabName)", objException.Message));
}
List<clsvSysLogEN> arrObjLst = new List<clsvSysLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
try
{
objvSysLogEN.mId = TransNullToInt(objRow[convSysLog.mId].ToString().Trim()); //mId
objvSysLogEN.UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(); //用户名
objvSysLogEN.LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(); //登陆时间
objvSysLogEN.LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(); //登陆日期
objvSysLogEN.PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(); //工程名称
objvSysLogEN.TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(); //表名
objvSysLogEN.TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(); //数据表关键字值
objvSysLogEN.OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(); //操作类型名称
objvSysLogEN.UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(); //用户IP
objvSysLogEN.OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objvSysLogEN.OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(); //操作内容
objvSysLogEN.OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(); //操作日期
objvSysLogEN.PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(); //工程ID
objvSysLogEN.OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(); //操作时间
objvSysLogEN.UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(); //用户Id
objvSysLogEN.Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSysLogDA: GetObjLst)", objException.Message));
}
objvSysLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSysLogEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvSysLogEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvSysLogDA:GetObjLstBySP)", objException.Message));
}
List<clsvSysLogEN> arrObjLst = new List<clsvSysLogEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vSysLog_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
try
{
objvSysLogEN.mId = TransNullToInt(objRow[convSysLog.mId].ToString().Trim()); //mId
objvSysLogEN.UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(); //用户名
objvSysLogEN.LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(); //登陆时间
objvSysLogEN.LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(); //登陆日期
objvSysLogEN.PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(); //工程名称
objvSysLogEN.TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(); //表名
objvSysLogEN.TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(); //数据表关键字值
objvSysLogEN.OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(); //操作类型名称
objvSysLogEN.UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(); //用户IP
objvSysLogEN.OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objvSysLogEN.OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(); //操作内容
objvSysLogEN.OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(); //操作日期
objvSysLogEN.PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(); //工程ID
objvSysLogEN.OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(); //操作时间
objvSysLogEN.UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(); //用户Id
objvSysLogEN.Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvSysLogDA: GetObjLstBySP)", objException.Message));
}
objvSysLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSysLogEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvSysLogEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvSysLog(ref clsvSysLogEN objvSysLogEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
strSQL = "Select * from vSysLog where mId = " + ""+ objvSysLogEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvSysLogEN.mId = TransNullToInt(objDT.Rows[0][convSysLog.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvSysLogEN.UserName = objDT.Rows[0][convSysLog.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvSysLogEN.LoginTime = objDT.Rows[0][convSysLog.LoginTime].ToString().Trim(); //登陆时间(字段类型:varchar,字段长度:6,是否可空:True)
 objvSysLogEN.LoginDate = objDT.Rows[0][convSysLog.LoginDate].ToString().Trim(); //登陆日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvSysLogEN.PrjName = objDT.Rows[0][convSysLog.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvSysLogEN.TableName = objDT.Rows[0][convSysLog.TableName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:True)
 objvSysLogEN.TableKey = objDT.Rows[0][convSysLog.TableKey].ToString().Trim(); //数据表关键字值(字段类型:varchar,字段长度:100,是否可空:True)
 objvSysLogEN.OpTypeName = objDT.Rows[0][convSysLog.OpTypeName].ToString().Trim(); //操作类型名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvSysLogEN.UserIp = objDT.Rows[0][convSysLog.UserIp].ToString().Trim(); //用户IP(字段类型:varchar,字段长度:40,是否可空:True)
 objvSysLogEN.OpTypeId = objDT.Rows[0][convSysLog.OpTypeId].ToString().Trim(); //操作类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvSysLogEN.OpContent = objDT.Rows[0][convSysLog.OpContent].ToString().Trim(); //操作内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSysLogEN.OpDate = objDT.Rows[0][convSysLog.OpDate].ToString().Trim(); //操作日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvSysLogEN.PrjId = objDT.Rows[0][convSysLog.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvSysLogEN.OpTime = objDT.Rows[0][convSysLog.OpTime].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:6,是否可空:True)
 objvSysLogEN.UserId = objDT.Rows[0][convSysLog.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvSysLogEN.Memo = objDT.Rows[0][convSysLog.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvSysLogDA: GetvSysLog)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvSysLogEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
strSQL = "Select * from vSysLog where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
try
{
 objvSysLogEN.mId = Int32.Parse(objRow[convSysLog.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvSysLogEN.UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvSysLogEN.LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(); //登陆时间(字段类型:varchar,字段长度:6,是否可空:True)
 objvSysLogEN.LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(); //登陆日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvSysLogEN.PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvSysLogEN.TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:True)
 objvSysLogEN.TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(); //数据表关键字值(字段类型:varchar,字段长度:100,是否可空:True)
 objvSysLogEN.OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(); //操作类型名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvSysLogEN.UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(); //用户IP(字段类型:varchar,字段长度:40,是否可空:True)
 objvSysLogEN.OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(); //操作类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvSysLogEN.OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(); //操作内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSysLogEN.OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(); //操作日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvSysLogEN.PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvSysLogEN.OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:6,是否可空:True)
 objvSysLogEN.UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvSysLogEN.Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvSysLogDA: GetObjBymId)", objException.Message));
}
return objvSysLogEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vSysLog_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvSysLogEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvSysLogOneBySP(clsvSysLogEN objvSysLogEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvSysLogEN.mId
};
 objDT = objSQL.ExecSpReturnDT("vSysLog_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvSysLogEN.mId = TransNullToInt(objDT.Rows[0][convSysLog.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvSysLogEN.UserName = objDT.Rows[0][convSysLog.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvSysLogEN.LoginTime = objDT.Rows[0][convSysLog.LoginTime].ToString().Trim(); //登陆时间(字段类型:varchar,字段长度:6,是否可空:True)
 objvSysLogEN.LoginDate = objDT.Rows[0][convSysLog.LoginDate].ToString().Trim(); //登陆日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvSysLogEN.PrjName = objDT.Rows[0][convSysLog.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvSysLogEN.TableName = objDT.Rows[0][convSysLog.TableName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:True)
 objvSysLogEN.TableKey = objDT.Rows[0][convSysLog.TableKey].ToString().Trim(); //数据表关键字值(字段类型:varchar,字段长度:100,是否可空:True)
 objvSysLogEN.OpTypeName = objDT.Rows[0][convSysLog.OpTypeName].ToString().Trim(); //操作类型名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvSysLogEN.UserIp = objDT.Rows[0][convSysLog.UserIp].ToString().Trim(); //用户IP(字段类型:varchar,字段长度:40,是否可空:True)
 objvSysLogEN.OpTypeId = objDT.Rows[0][convSysLog.OpTypeId].ToString().Trim(); //操作类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvSysLogEN.OpContent = objDT.Rows[0][convSysLog.OpContent].ToString().Trim(); //操作内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSysLogEN.OpDate = objDT.Rows[0][convSysLog.OpDate].ToString().Trim(); //操作日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvSysLogEN.PrjId = objDT.Rows[0][convSysLog.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvSysLogEN.OpTime = objDT.Rows[0][convSysLog.OpTime].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:6,是否可空:True)
 objvSysLogEN.UserId = objDT.Rows[0][convSysLog.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvSysLogEN.Memo = objDT.Rows[0][convSysLog.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvSysLogEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvSysLogDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
strSQL = "Select * from vSysLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN()
{
mId = TransNullToInt(objRow[convSysLog.mId].ToString().Trim()), //mId
UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(), //用户名
LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(), //登陆时间
LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(), //登陆日期
PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(), //工程名称
TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(), //表名
TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(), //数据表关键字值
OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(), //操作类型名称
UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(), //用户IP
OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(), //操作类型Id
OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(), //操作内容
OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(), //操作日期
PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(), //工程ID
OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(), //操作时间
UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(), //用户Id
Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim() //说明
};
objvSysLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysLogEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvSysLogDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvSysLogEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvSysLogDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vSysLog_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN()
{
mId = TransNullToInt(objRow[convSysLog.mId].ToString().Trim()), //mId
UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(), //用户名
LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(), //登陆时间
LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(), //登陆日期
PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(), //工程名称
TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(), //表名
TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(), //数据表关键字值
OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(), //操作类型名称
UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(), //用户IP
OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(), //操作类型Id
OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(), //操作内容
OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(), //操作日期
PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(), //工程ID
OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(), //操作时间
UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(), //用户Id
Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim() //说明
};
objvSysLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysLogEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvSysLogEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
try
{
objvSysLogEN.mId = TransNullToInt(objRow[convSysLog.mId].ToString().Trim()); //mId
objvSysLogEN.UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(); //用户名
objvSysLogEN.LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(); //登陆时间
objvSysLogEN.LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(); //登陆日期
objvSysLogEN.PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(); //工程名称
objvSysLogEN.TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(); //表名
objvSysLogEN.TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(); //数据表关键字值
objvSysLogEN.OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(); //操作类型名称
objvSysLogEN.UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(); //用户IP
objvSysLogEN.OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objvSysLogEN.OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(); //操作内容
objvSysLogEN.OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(); //操作日期
objvSysLogEN.PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(); //工程ID
objvSysLogEN.OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(); //操作时间
objvSysLogEN.UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(); //用户Id
objvSysLogEN.Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvSysLogDA: GetObjByDataRowvSysLog)", objException.Message));
}
objvSysLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysLogEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvSysLogEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSysLogEN objvSysLogEN = new clsvSysLogEN();
try
{
objvSysLogEN.mId = TransNullToInt(objRow[convSysLog.mId].ToString().Trim()); //mId
objvSysLogEN.UserName = objRow[convSysLog.UserName] == DBNull.Value ? null : objRow[convSysLog.UserName].ToString().Trim(); //用户名
objvSysLogEN.LoginTime = objRow[convSysLog.LoginTime] == DBNull.Value ? null : objRow[convSysLog.LoginTime].ToString().Trim(); //登陆时间
objvSysLogEN.LoginDate = objRow[convSysLog.LoginDate] == DBNull.Value ? null : objRow[convSysLog.LoginDate].ToString().Trim(); //登陆日期
objvSysLogEN.PrjName = objRow[convSysLog.PrjName] == DBNull.Value ? null : objRow[convSysLog.PrjName].ToString().Trim(); //工程名称
objvSysLogEN.TableName = objRow[convSysLog.TableName] == DBNull.Value ? null : objRow[convSysLog.TableName].ToString().Trim(); //表名
objvSysLogEN.TableKey = objRow[convSysLog.TableKey] == DBNull.Value ? null : objRow[convSysLog.TableKey].ToString().Trim(); //数据表关键字值
objvSysLogEN.OpTypeName = objRow[convSysLog.OpTypeName] == DBNull.Value ? null : objRow[convSysLog.OpTypeName].ToString().Trim(); //操作类型名称
objvSysLogEN.UserIp = objRow[convSysLog.UserIp] == DBNull.Value ? null : objRow[convSysLog.UserIp].ToString().Trim(); //用户IP
objvSysLogEN.OpTypeId = objRow[convSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objvSysLogEN.OpContent = objRow[convSysLog.OpContent] == DBNull.Value ? null : objRow[convSysLog.OpContent].ToString().Trim(); //操作内容
objvSysLogEN.OpDate = objRow[convSysLog.OpDate] == DBNull.Value ? null : objRow[convSysLog.OpDate].ToString().Trim(); //操作日期
objvSysLogEN.PrjId = objRow[convSysLog.PrjId] == DBNull.Value ? null : objRow[convSysLog.PrjId].ToString().Trim(); //工程ID
objvSysLogEN.OpTime = objRow[convSysLog.OpTime] == DBNull.Value ? null : objRow[convSysLog.OpTime].ToString().Trim(); //操作时间
objvSysLogEN.UserId = objRow[convSysLog.UserId] == DBNull.Value ? null : objRow[convSysLog.UserId].ToString().Trim(); //用户Id
objvSysLogEN.Memo = objRow[convSysLog.Memo] == DBNull.Value ? null : objRow[convSysLog.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvSysLogDA: GetObjByDataRow)", objException.Message));
}
objvSysLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysLogEN;
}

 #endregion 获取一个实体对象

 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrID)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public static string GetMaxStrId()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvSysLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSysLogEN._CurrTabName, convSysLog.mId, 8, "");
return strMaxValue;
}

 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase:GenGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public string GetMaxStrIdByPrefix(string strPrefix)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvSysLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSysLogEN._CurrTabName, convSysLog.mId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vSysLog where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
}

 #endregion 获取一个关键字值

 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的所有记录的关键字值列表
 /// (AutoGCLib.clsGeneCodeBase:GenGetPrimaryKeyID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的关键字值列表</returns>
public List<string> GetID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
List<string> arrList = new List<string>();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vSysLog where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return null;
}
for (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)
{
strKeyValue = "";
for (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)
{
if (iCol  ==  0)
{
strKeyValue +=  objDT.Rows[iRow][iCol].ToString();
}
else
{
strKeyValue +=  "//" + objDT.Rows[iRow][iCol].ToString();
}
}
arrList.Add(strKeyValue);
}
return arrList;
}

 #endregion 获取多个关键字值列表

 #region 判断记录是否存在

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExist_S)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSysLog", "mId = " + ""+ lngmId+""))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录, 用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistBySP)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vSysLog_IsExist", values);
if (arrReturn[0].ToString()  ==  "1")
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistCondRec_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public bool IsExistCondRec(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvSysLogDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSysLog", strCondition))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.clsGeneCodeBase:GenIsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvSysLogDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vSysLog");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvSysLogENS">源对象</param>
 /// <param name = "objvSysLogENT">目标对象</param>
public void CopyTo(clsvSysLogEN objvSysLogENS, clsvSysLogEN objvSysLogENT)
{
objvSysLogENT.mId = objvSysLogENS.mId; //mId
objvSysLogENT.UserName = objvSysLogENS.UserName; //用户名
objvSysLogENT.LoginTime = objvSysLogENS.LoginTime; //登陆时间
objvSysLogENT.LoginDate = objvSysLogENS.LoginDate; //登陆日期
objvSysLogENT.PrjName = objvSysLogENS.PrjName; //工程名称
objvSysLogENT.TableName = objvSysLogENS.TableName; //表名
objvSysLogENT.TableKey = objvSysLogENS.TableKey; //数据表关键字值
objvSysLogENT.OpTypeName = objvSysLogENS.OpTypeName; //操作类型名称
objvSysLogENT.UserIp = objvSysLogENS.UserIp; //用户IP
objvSysLogENT.OpTypeId = objvSysLogENS.OpTypeId; //操作类型Id
objvSysLogENT.OpContent = objvSysLogENS.OpContent; //操作内容
objvSysLogENT.OpDate = objvSysLogENS.OpDate; //操作日期
objvSysLogENT.PrjId = objvSysLogENS.PrjId; //工程ID
objvSysLogENT.OpTime = objvSysLogENS.OpTime; //操作时间
objvSysLogENT.UserId = objvSysLogENS.UserId; //用户Id
objvSysLogENT.Memo = objvSysLogENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvSysLogEN objvSysLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvSysLogEN.UserName, 30, convSysLog.UserName);
clsCheckSql.CheckFieldLen(objvSysLogEN.LoginTime, 6, convSysLog.LoginTime);
clsCheckSql.CheckFieldLen(objvSysLogEN.LoginDate, 8, convSysLog.LoginDate);
clsCheckSql.CheckFieldLen(objvSysLogEN.PrjName, 30, convSysLog.PrjName);
clsCheckSql.CheckFieldLen(objvSysLogEN.TableName, 100, convSysLog.TableName);
clsCheckSql.CheckFieldLen(objvSysLogEN.TableKey, 100, convSysLog.TableKey);
clsCheckSql.CheckFieldLen(objvSysLogEN.OpTypeName, 100, convSysLog.OpTypeName);
clsCheckSql.CheckFieldLen(objvSysLogEN.UserIp, 40, convSysLog.UserIp);
clsCheckSql.CheckFieldLen(objvSysLogEN.OpTypeId, 4, convSysLog.OpTypeId);
clsCheckSql.CheckFieldLen(objvSysLogEN.OpContent, 1000, convSysLog.OpContent);
clsCheckSql.CheckFieldLen(objvSysLogEN.OpDate, 8, convSysLog.OpDate);
clsCheckSql.CheckFieldLen(objvSysLogEN.PrjId, 4, convSysLog.PrjId);
clsCheckSql.CheckFieldLen(objvSysLogEN.OpTime, 6, convSysLog.OpTime);
clsCheckSql.CheckFieldLen(objvSysLogEN.UserId, 18, convSysLog.UserId);
clsCheckSql.CheckFieldLen(objvSysLogEN.Memo, 1000, convSysLog.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvSysLogEN.UserName, convSysLog.UserName);
clsCheckSql.CheckSqlInjection4Field(objvSysLogEN.LoginTime, convSysLog.LoginTime);
clsCheckSql.CheckSqlInjection4Field(objvSysLogEN.LoginDate, convSysLog.LoginDate);
clsCheckSql.CheckSqlInjection4Field(objvSysLogEN.PrjName, convSysLog.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvSysLogEN.TableName, convSysLog.TableName);
clsCheckSql.CheckSqlInjection4Field(objvSysLogEN.TableKey, convSysLog.TableKey);
clsCheckSql.CheckSqlInjection4Field(objvSysLogEN.OpTypeName, convSysLog.OpTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSysLogEN.UserIp, convSysLog.UserIp);
clsCheckSql.CheckSqlInjection4Field(objvSysLogEN.OpTypeId, convSysLog.OpTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSysLogEN.OpContent, convSysLog.OpContent);
clsCheckSql.CheckSqlInjection4Field(objvSysLogEN.OpDate, convSysLog.OpDate);
clsCheckSql.CheckSqlInjection4Field(objvSysLogEN.PrjId, convSysLog.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvSysLogEN.OpTime, convSysLog.OpTime);
clsCheckSql.CheckSqlInjection4Field(objvSysLogEN.UserId, convSysLog.UserId);
clsCheckSql.CheckSqlInjection4Field(objvSysLogEN.Memo, convSysLog.Memo);
//检查外键字段长度
 objvSysLogEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 #endregion 检查唯一性

 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName, strCondition);
return intRecCount;
}



 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCount()
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSysLogEN._CurrTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond)
 /// </summary>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCountByCond(string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSysLogEN._CurrTabName, strCondition);
return intRecCount;
}

 /// <summary>
 /// 功能:获取给定表中的符合条件的某字段的值,以列表返回
 /// (AutoGCLib.DALCode4CSharp:GenGetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>获取的字段值列表</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysLogDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}