
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvLog4CreateView4SqlDA
 表名:vLog4CreateView4Sql(00050295)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:17:55
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
 /// v建立视图日志(vLog4CreateView4Sql)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsvLog4CreateView4SqlDA : clsCommBase4DA
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
 return clsvLog4CreateView4SqlEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvLog4CreateView4SqlEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvLog4CreateView4SqlEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvLog4CreateView4SqlEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvLog4CreateView4SqlEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
 strSQL = "Select * from vLog4CreateView4Sql where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "vLog4CreateView4Sql");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("vLog4CreateView4Sql_SelectByCond",values, "vLog4CreateView4Sql");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vLog4CreateView4Sql where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "vLog4CreateView4Sql");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4SqlByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4SqlByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4SqlByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vLog4CreateView4Sql a where {0} And a.mId not in (Select Top {2} mId From vLog4CreateView4Sql Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vLog4CreateView4Sql");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4SqlByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4SqlByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4SqlByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vLog4CreateView4Sql a where {0} And a.mId not in (Select Top {2} mId From vLog4CreateView4Sql Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vLog4CreateView4Sql");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4SqlByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4SqlByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4SqlByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from vLog4CreateView4Sql a where {0} And a.mId not in (Select Top {2} mId From vLog4CreateView4Sql Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "vLog4CreateView4Sql");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
strSQL = "Select * from vLog4CreateView4Sql where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vLog4CreateView4Sql(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataTable_vLog4CreateView4Sql)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
strSQL = "Select * from vLog4CreateView4Sql where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
strSQL = "Select * from vLog4CreateView4Sql where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
strSQL = "Select * from vLog4CreateView4Sql where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vLog4CreateView4Sql where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vLog4CreateView4Sql where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vLog4CreateView4Sql where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vLog4CreateView4Sql where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vLog4CreateView4Sql.* from vLog4CreateView4Sql Left Join {1} on {2} where {3} and vLog4CreateView4Sql.mId not in (Select top {5} vLog4CreateView4Sql.mId from vLog4CreateView4Sql Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vLog4CreateView4Sql where {1} and mId not in (Select top {2} mId from vLog4CreateView4Sql where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vLog4CreateView4Sql where {1} and mId not in (Select top {3} mId from vLog4CreateView4Sql where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vLog4CreateView4Sql.* from vLog4CreateView4Sql Left Join {1} on {2} where {3} and vLog4CreateView4Sql.mId not in (Select top {5} vLog4CreateView4Sql.mId from vLog4CreateView4Sql Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vLog4CreateView4Sql where {1} and mId not in (Select top {2} mId from vLog4CreateView4Sql where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vLog4CreateView4Sql where {1} and mId not in (Select top {3} mId from vLog4CreateView4Sql where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vLog4CreateView4Sql.* from vLog4CreateView4Sql Left Join {1} on {2} where {3} and vLog4CreateView4Sql.mId not in (Select top {5} vLog4CreateView4Sql.mId from vLog4CreateView4Sql Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vLog4CreateView4Sql where {1} and mId not in (Select top {2} mId from vLog4CreateView4Sql where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vLog4CreateView4Sql where {1} and mId not in (Select top {3} mId from vLog4CreateView4Sql where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4SqlByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4SqlByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4SqlByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vLog4CreateView4Sql a where {0} And a.mId not in (Select Top {2} mId From vLog4CreateView4Sql Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vLog4CreateView4Sql a where {0} And a.mId not in (Select Top {2} mId From vLog4CreateView4Sql Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4SqlByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4SqlByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4SqlByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from vLog4CreateView4Sql a where {0} And a.mId not in (Select Top {2} mId From vLog4CreateView4Sql Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from vLog4CreateView4Sql a where {0} And a.mId not in (Select Top {2} mId From vLog4CreateView4Sql Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4SqlByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4SqlByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4SqlByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
strSQL = "Select * from vLog4CreateView4Sql where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vLog4CreateView4Sql_SelectByCond",values);
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
public List<clsvLog4CreateView4SqlEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA:GetObjLst)", objException.Message));
}
List<clsvLog4CreateView4SqlEN> arrObjLst = new List<clsvLog4CreateView4SqlEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
strSQL = "Select * from vLog4CreateView4Sql where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
try
{
objvLog4CreateView4SqlEN.mId = TransNullToInt(objRow[convLog4CreateView4Sql.mId].ToString().Trim()); //mId
objvLog4CreateView4SqlEN.SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id
objvLog4CreateView4SqlEN.PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvLog4CreateView4SqlEN.PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvLog4CreateView4SqlEN.CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期
objvLog4CreateView4SqlEN.PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID
objvLog4CreateView4SqlEN.PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称
objvLog4CreateView4SqlEN.UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id
objvLog4CreateView4SqlEN.Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvLog4CreateView4SqlDA: GetObjLst)", objException.Message));
}
objvLog4CreateView4SqlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvLog4CreateView4SqlEN);
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
public List<clsvLog4CreateView4SqlEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA:GetObjLstByTabName)", objException.Message));
}
List<clsvLog4CreateView4SqlEN> arrObjLst = new List<clsvLog4CreateView4SqlEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
try
{
objvLog4CreateView4SqlEN.mId = TransNullToInt(objRow[convLog4CreateView4Sql.mId].ToString().Trim()); //mId
objvLog4CreateView4SqlEN.SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id
objvLog4CreateView4SqlEN.PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvLog4CreateView4SqlEN.PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvLog4CreateView4SqlEN.CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期
objvLog4CreateView4SqlEN.PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID
objvLog4CreateView4SqlEN.PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称
objvLog4CreateView4SqlEN.UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id
objvLog4CreateView4SqlEN.Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvLog4CreateView4SqlDA: GetObjLst)", objException.Message));
}
objvLog4CreateView4SqlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvLog4CreateView4SqlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvLog4CreateView4SqlEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA:GetObjLstBySP)", objException.Message));
}
List<clsvLog4CreateView4SqlEN> arrObjLst = new List<clsvLog4CreateView4SqlEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vLog4CreateView4Sql_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
try
{
objvLog4CreateView4SqlEN.mId = TransNullToInt(objRow[convLog4CreateView4Sql.mId].ToString().Trim()); //mId
objvLog4CreateView4SqlEN.SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id
objvLog4CreateView4SqlEN.PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvLog4CreateView4SqlEN.PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvLog4CreateView4SqlEN.CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期
objvLog4CreateView4SqlEN.PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID
objvLog4CreateView4SqlEN.PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称
objvLog4CreateView4SqlEN.UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id
objvLog4CreateView4SqlEN.Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsvLog4CreateView4SqlDA: GetObjLstBySP)", objException.Message));
}
objvLog4CreateView4SqlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvLog4CreateView4SqlEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvLog4CreateView4Sql(ref clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
strSQL = "Select * from vLog4CreateView4Sql where mId = " + ""+ objvLog4CreateView4SqlEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvLog4CreateView4SqlEN.mId = TransNullToInt(objDT.Rows[0][convLog4CreateView4Sql.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvLog4CreateView4SqlEN.SqlViewId = objDT.Rows[0][convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id(字段类型:char,字段长度:8,是否可空:False)
 objvLog4CreateView4SqlEN.PrjDataBaseId = objDT.Rows[0][convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id(字段类型:char,字段长度:4,是否可空:False)
 objvLog4CreateView4SqlEN.PrjDataBaseName = objDT.Rows[0][convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名(字段类型:varchar,字段长度:50,是否可空:True)
 objvLog4CreateView4SqlEN.CreateViewDate = objDT.Rows[0][convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvLog4CreateView4SqlEN.PrjId = objDT.Rows[0][convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvLog4CreateView4SqlEN.PrjName = objDT.Rows[0][convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvLog4CreateView4SqlEN.UserId = objDT.Rows[0][convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvLog4CreateView4SqlEN.Memo = objDT.Rows[0][convLog4CreateView4Sql.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvLog4CreateView4SqlDA: GetvLog4CreateView4Sql)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvLog4CreateView4SqlEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
strSQL = "Select * from vLog4CreateView4Sql where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
try
{
 objvLog4CreateView4SqlEN.mId = Int32.Parse(objRow[convLog4CreateView4Sql.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvLog4CreateView4SqlEN.SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id(字段类型:char,字段长度:8,是否可空:False)
 objvLog4CreateView4SqlEN.PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id(字段类型:char,字段长度:4,是否可空:False)
 objvLog4CreateView4SqlEN.PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名(字段类型:varchar,字段长度:50,是否可空:True)
 objvLog4CreateView4SqlEN.CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvLog4CreateView4SqlEN.PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvLog4CreateView4SqlEN.PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvLog4CreateView4SqlEN.UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvLog4CreateView4SqlEN.Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvLog4CreateView4SqlDA: GetObjBymId)", objException.Message));
}
return objvLog4CreateView4SqlEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程vLog4CreateView4Sql_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvLog4CreateView4SqlOneBySP(clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objvLog4CreateView4SqlEN.mId
};
 objDT = objSQL.ExecSpReturnDT("vLog4CreateView4Sql_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objvLog4CreateView4SqlEN.mId = TransNullToInt(objDT.Rows[0][convLog4CreateView4Sql.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvLog4CreateView4SqlEN.SqlViewId = objDT.Rows[0][convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id(字段类型:char,字段长度:8,是否可空:False)
 objvLog4CreateView4SqlEN.PrjDataBaseId = objDT.Rows[0][convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id(字段类型:char,字段长度:4,是否可空:False)
 objvLog4CreateView4SqlEN.PrjDataBaseName = objDT.Rows[0][convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名(字段类型:varchar,字段长度:50,是否可空:True)
 objvLog4CreateView4SqlEN.CreateViewDate = objDT.Rows[0][convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvLog4CreateView4SqlEN.PrjId = objDT.Rows[0][convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvLog4CreateView4SqlEN.PrjName = objDT.Rows[0][convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvLog4CreateView4SqlEN.UserId = objDT.Rows[0][convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvLog4CreateView4SqlEN.Memo = objDT.Rows[0][convLog4CreateView4Sql.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvLog4CreateView4SqlEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
strSQL = "Select * from vLog4CreateView4Sql where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN()
{
mId = TransNullToInt(objRow[convLog4CreateView4Sql.mId].ToString().Trim()), //mId
SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(), //Sql视图Id
PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(), //项目数据库Id
PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(), //项目数据库名
CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(), //建立视图日期
PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(), //工程ID
PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(), //工程名称
UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(), //用户Id
Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim() //说明
};
objvLog4CreateView4SqlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvLog4CreateView4SqlEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvLog4CreateView4SqlDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvLog4CreateView4SqlEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("vLog4CreateView4Sql_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN()
{
mId = TransNullToInt(objRow[convLog4CreateView4Sql.mId].ToString().Trim()), //mId
SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(), //Sql视图Id
PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(), //项目数据库Id
PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(), //项目数据库名
CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(), //建立视图日期
PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(), //工程ID
PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(), //工程名称
UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(), //用户Id
Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim() //说明
};
objvLog4CreateView4SqlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvLog4CreateView4SqlEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvLog4CreateView4SqlEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
try
{
objvLog4CreateView4SqlEN.mId = TransNullToInt(objRow[convLog4CreateView4Sql.mId].ToString().Trim()); //mId
objvLog4CreateView4SqlEN.SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id
objvLog4CreateView4SqlEN.PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvLog4CreateView4SqlEN.PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvLog4CreateView4SqlEN.CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期
objvLog4CreateView4SqlEN.PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID
objvLog4CreateView4SqlEN.PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称
objvLog4CreateView4SqlEN.UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id
objvLog4CreateView4SqlEN.Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvLog4CreateView4SqlDA: GetObjByDataRowvLog4CreateView4Sql)", objException.Message));
}
objvLog4CreateView4SqlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvLog4CreateView4SqlEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvLog4CreateView4SqlEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN = new clsvLog4CreateView4SqlEN();
try
{
objvLog4CreateView4SqlEN.mId = TransNullToInt(objRow[convLog4CreateView4Sql.mId].ToString().Trim()); //mId
objvLog4CreateView4SqlEN.SqlViewId = objRow[convLog4CreateView4Sql.SqlViewId].ToString().Trim(); //Sql视图Id
objvLog4CreateView4SqlEN.PrjDataBaseId = objRow[convLog4CreateView4Sql.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvLog4CreateView4SqlEN.PrjDataBaseName = objRow[convLog4CreateView4Sql.PrjDataBaseName] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvLog4CreateView4SqlEN.CreateViewDate = objRow[convLog4CreateView4Sql.CreateViewDate] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.CreateViewDate].ToString().Trim(); //建立视图日期
objvLog4CreateView4SqlEN.PrjId = objRow[convLog4CreateView4Sql.PrjId].ToString().Trim(); //工程ID
objvLog4CreateView4SqlEN.PrjName = objRow[convLog4CreateView4Sql.PrjName].ToString().Trim(); //工程名称
objvLog4CreateView4SqlEN.UserId = objRow[convLog4CreateView4Sql.UserId] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.UserId].ToString().Trim(); //用户Id
objvLog4CreateView4SqlEN.Memo = objRow[convLog4CreateView4Sql.Memo] == DBNull.Value ? null : objRow[convLog4CreateView4Sql.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvLog4CreateView4SqlDA: GetObjByDataRow)", objException.Message));
}
objvLog4CreateView4SqlEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvLog4CreateView4SqlEN;
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
objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvLog4CreateView4SqlEN._CurrTabName, convLog4CreateView4Sql.mId, 8, "");
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
objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvLog4CreateView4SqlEN._CurrTabName, convLog4CreateView4Sql.mId, 8, strPrefix);
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
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vLog4CreateView4Sql where " + strCondition;
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
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vLog4CreateView4Sql where " + strCondition;
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
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vLog4CreateView4Sql", "mId = " + ""+ lngmId+""))
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
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("vLog4CreateView4Sql_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvLog4CreateView4SqlDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vLog4CreateView4Sql", strCondition))
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
objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vLog4CreateView4Sql");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvLog4CreateView4SqlENS">源对象</param>
 /// <param name = "objvLog4CreateView4SqlENT">目标对象</param>
public void CopyTo(clsvLog4CreateView4SqlEN objvLog4CreateView4SqlENS, clsvLog4CreateView4SqlEN objvLog4CreateView4SqlENT)
{
objvLog4CreateView4SqlENT.mId = objvLog4CreateView4SqlENS.mId; //mId
objvLog4CreateView4SqlENT.SqlViewId = objvLog4CreateView4SqlENS.SqlViewId; //Sql视图Id
objvLog4CreateView4SqlENT.PrjDataBaseId = objvLog4CreateView4SqlENS.PrjDataBaseId; //项目数据库Id
objvLog4CreateView4SqlENT.PrjDataBaseName = objvLog4CreateView4SqlENS.PrjDataBaseName; //项目数据库名
objvLog4CreateView4SqlENT.CreateViewDate = objvLog4CreateView4SqlENS.CreateViewDate; //建立视图日期
objvLog4CreateView4SqlENT.PrjId = objvLog4CreateView4SqlENS.PrjId; //工程ID
objvLog4CreateView4SqlENT.PrjName = objvLog4CreateView4SqlENS.PrjName; //工程名称
objvLog4CreateView4SqlENT.UserId = objvLog4CreateView4SqlENS.UserId; //用户Id
objvLog4CreateView4SqlENT.Memo = objvLog4CreateView4SqlENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvLog4CreateView4SqlEN objvLog4CreateView4SqlEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvLog4CreateView4SqlEN.SqlViewId, 8, convLog4CreateView4Sql.SqlViewId);
clsCheckSql.CheckFieldLen(objvLog4CreateView4SqlEN.PrjDataBaseId, 4, convLog4CreateView4Sql.PrjDataBaseId);
clsCheckSql.CheckFieldLen(objvLog4CreateView4SqlEN.PrjDataBaseName, 50, convLog4CreateView4Sql.PrjDataBaseName);
clsCheckSql.CheckFieldLen(objvLog4CreateView4SqlEN.CreateViewDate, 14, convLog4CreateView4Sql.CreateViewDate);
clsCheckSql.CheckFieldLen(objvLog4CreateView4SqlEN.PrjId, 4, convLog4CreateView4Sql.PrjId);
clsCheckSql.CheckFieldLen(objvLog4CreateView4SqlEN.PrjName, 30, convLog4CreateView4Sql.PrjName);
clsCheckSql.CheckFieldLen(objvLog4CreateView4SqlEN.UserId, 18, convLog4CreateView4Sql.UserId);
clsCheckSql.CheckFieldLen(objvLog4CreateView4SqlEN.Memo, 1000, convLog4CreateView4Sql.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvLog4CreateView4SqlEN.SqlViewId, convLog4CreateView4Sql.SqlViewId);
clsCheckSql.CheckSqlInjection4Field(objvLog4CreateView4SqlEN.PrjDataBaseId, convLog4CreateView4Sql.PrjDataBaseId);
clsCheckSql.CheckSqlInjection4Field(objvLog4CreateView4SqlEN.PrjDataBaseName, convLog4CreateView4Sql.PrjDataBaseName);
clsCheckSql.CheckSqlInjection4Field(objvLog4CreateView4SqlEN.CreateViewDate, convLog4CreateView4Sql.CreateViewDate);
clsCheckSql.CheckSqlInjection4Field(objvLog4CreateView4SqlEN.PrjId, convLog4CreateView4Sql.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvLog4CreateView4SqlEN.PrjName, convLog4CreateView4Sql.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvLog4CreateView4SqlEN.UserId, convLog4CreateView4Sql.UserId);
clsCheckSql.CheckSqlInjection4Field(objvLog4CreateView4SqlEN.Memo, convLog4CreateView4Sql.Memo);
//检查外键字段长度
 objvLog4CreateView4SqlEN._IsCheckProperty = true;
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
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
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
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
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
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvLog4CreateView4SqlEN._CurrTabName);
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
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvLog4CreateView4SqlEN._CurrTabName, strCondition);
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
 objSQL = clsvLog4CreateView4SqlDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}