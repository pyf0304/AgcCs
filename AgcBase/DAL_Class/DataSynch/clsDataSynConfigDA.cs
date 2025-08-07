
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataSynConfigDA
 表名:DataSynConfig(00050346)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:13:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据同步(DataSynch)
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
 /// 同步配置(DataSynConfig)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsDataSynConfigDA : clsCommBase4DA
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
 return clsDataSynConfigEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsDataSynConfigEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDataSynConfigEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsDataSynConfigEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsDataSynConfigEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
 strSQL = "Select * from DataSynConfig where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "DataSynConfig");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("DataSynConfig_SelectByCond",values, "DataSynConfig");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DataSynConfig where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "DataSynConfig");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsDataSynConfigDA: GetDataSynConfigByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsDataSynConfigDA: GetDataSynConfigByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsDataSynConfigDA: GetDataSynConfigByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from DataSynConfig a where {0} And a.mId not in (Select Top {2} mId From DataSynConfig Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "DataSynConfig");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsDataSynConfigDA: GetDataSynConfigByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsDataSynConfigDA: GetDataSynConfigByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsDataSynConfigDA: GetDataSynConfigByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from DataSynConfig a where {0} And a.mId not in (Select Top {2} mId From DataSynConfig Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "DataSynConfig");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsDataSynConfigDA: GetDataSynConfigByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsDataSynConfigDA: GetDataSynConfigByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsDataSynConfigDA: GetDataSynConfigByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from DataSynConfig a where {0} And a.mId not in (Select Top {2} mId From DataSynConfig Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "DataSynConfig");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
strSQL = "Select * from DataSynConfig where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_DataSynConfig(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataTable_DataSynConfig)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
strSQL = "Select * from DataSynConfig where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
strSQL = "Select * from DataSynConfig where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
strSQL = "Select * from DataSynConfig where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataSynConfig where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataSynConfig where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DataSynConfig where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DataSynConfig where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} DataSynConfig.* from DataSynConfig Left Join {1} on {2} where {3} and DataSynConfig.mId not in (Select top {5} DataSynConfig.mId from DataSynConfig Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataSynConfig where {1} and mId not in (Select top {2} mId from DataSynConfig where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataSynConfig where {1} and mId not in (Select top {3} mId from DataSynConfig where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} DataSynConfig.* from DataSynConfig Left Join {1} on {2} where {3} and DataSynConfig.mId not in (Select top {5} DataSynConfig.mId from DataSynConfig Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataSynConfig where {1} and mId not in (Select top {2} mId from DataSynConfig where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataSynConfig where {1} and mId not in (Select top {3} mId from DataSynConfig where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} DataSynConfig.* from DataSynConfig Left Join {1} on {2} where {3} and DataSynConfig.mId not in (Select top {5} DataSynConfig.mId from DataSynConfig Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataSynConfig where {1} and mId not in (Select top {2} mId from DataSynConfig where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataSynConfig where {1} and mId not in (Select top {3} mId from DataSynConfig where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsDataSynConfigDA: GetDataSynConfigByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsDataSynConfigDA: GetDataSynConfigByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsDataSynConfigDA: GetDataSynConfigByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from DataSynConfig a where {0} And a.mId not in (Select Top {2} mId From DataSynConfig Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from DataSynConfig a where {0} And a.mId not in (Select Top {2} mId From DataSynConfig Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsDataSynConfigDA: GetDataSynConfigByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsDataSynConfigDA: GetDataSynConfigByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsDataSynConfigDA: GetDataSynConfigByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from DataSynConfig a where {0} And a.mId not in (Select Top {2} mId From DataSynConfig Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from DataSynConfig a where {0} And a.mId not in (Select Top {2} mId From DataSynConfig Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsDataSynConfigDA: GetDataSynConfigByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsDataSynConfigDA: GetDataSynConfigByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsDataSynConfigDA: GetDataSynConfigByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
strSQL = "Select * from DataSynConfig where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("DataSynConfig_SelectByCond",values);
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
public List<clsDataSynConfigEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsDataSynConfigDA:GetObjLst)", objException.Message));
}
List<clsDataSynConfigEN> arrObjLst = new List<clsDataSynConfigEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
strSQL = "Select * from DataSynConfig where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataSynConfigEN objDataSynConfigEN = new clsDataSynConfigEN();
try
{
objDataSynConfigEN.mId = TransNullToInt(objRow[conDataSynConfig.mId].ToString().Trim()); //mId
objDataSynConfigEN.TabName = objRow[conDataSynConfig.TabName] == DBNull.Value ? null : objRow[conDataSynConfig.TabName].ToString().Trim(); //表名
objDataSynConfigEN.IsSynch = TransNullToBool(objRow[conDataSynConfig.IsSynch].ToString().Trim()); //是否同步
objDataSynConfigEN.SynCondition = objRow[conDataSynConfig.SynCondition].ToString().Trim(); //同步条件
objDataSynConfigEN.SynCondition4Web = objRow[conDataSynConfig.SynCondition4Web] == DBNull.Value ? null : objRow[conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web
objDataSynConfigEN.SynchCycle = objRow[conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期
objDataSynConfigEN.SynchDate = objRow[conDataSynConfig.SynchDate].ToString().Trim(); //同步日期
objDataSynConfigEN.SynchTime = objRow[conDataSynConfig.SynchTime].ToString().Trim(); //同步时间
objDataSynConfigEN.SenderUser = objRow[conDataSynConfig.SenderUser] == DBNull.Value ? null : objRow[conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户
objDataSynConfigEN.SenderPwd = objRow[conDataSynConfig.SenderPwd] == DBNull.Value ? null : objRow[conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令
objDataSynConfigEN.smtp = objRow[conDataSynConfig.smtp] == DBNull.Value ? null : objRow[conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器
objDataSynConfigEN.Receiver = objRow[conDataSynConfig.Receiver] == DBNull.Value ? null : objRow[conDataSynConfig.Receiver].ToString().Trim(); //接收者
objDataSynConfigEN.lastMailDate = objRow[conDataSynConfig.lastMailDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期
objDataSynConfigEN.lastExecuteDate = objRow[conDataSynConfig.lastExecuteDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期
objDataSynConfigEN.SynchStartTime = objRow[conDataSynConfig.SynchStartTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间
objDataSynConfigEN.SynchEndTime = objRow[conDataSynConfig.SynchEndTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间
objDataSynConfigEN.OrderNum = TransNullToInt(objRow[conDataSynConfig.OrderNum].ToString().Trim()); //序号
objDataSynConfigEN.Memo = objRow[conDataSynConfig.Memo] == DBNull.Value ? null : objRow[conDataSynConfig.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDataSynConfigDA: GetObjLst)", objException.Message));
}
objDataSynConfigEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDataSynConfigEN);
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
public List<clsDataSynConfigEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsDataSynConfigDA:GetObjLstByTabName)", objException.Message));
}
List<clsDataSynConfigEN> arrObjLst = new List<clsDataSynConfigEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataSynConfigEN objDataSynConfigEN = new clsDataSynConfigEN();
try
{
objDataSynConfigEN.mId = TransNullToInt(objRow[conDataSynConfig.mId].ToString().Trim()); //mId
objDataSynConfigEN.TabName = objRow[conDataSynConfig.TabName] == DBNull.Value ? null : objRow[conDataSynConfig.TabName].ToString().Trim(); //表名
objDataSynConfigEN.IsSynch = TransNullToBool(objRow[conDataSynConfig.IsSynch].ToString().Trim()); //是否同步
objDataSynConfigEN.SynCondition = objRow[conDataSynConfig.SynCondition].ToString().Trim(); //同步条件
objDataSynConfigEN.SynCondition4Web = objRow[conDataSynConfig.SynCondition4Web] == DBNull.Value ? null : objRow[conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web
objDataSynConfigEN.SynchCycle = objRow[conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期
objDataSynConfigEN.SynchDate = objRow[conDataSynConfig.SynchDate].ToString().Trim(); //同步日期
objDataSynConfigEN.SynchTime = objRow[conDataSynConfig.SynchTime].ToString().Trim(); //同步时间
objDataSynConfigEN.SenderUser = objRow[conDataSynConfig.SenderUser] == DBNull.Value ? null : objRow[conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户
objDataSynConfigEN.SenderPwd = objRow[conDataSynConfig.SenderPwd] == DBNull.Value ? null : objRow[conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令
objDataSynConfigEN.smtp = objRow[conDataSynConfig.smtp] == DBNull.Value ? null : objRow[conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器
objDataSynConfigEN.Receiver = objRow[conDataSynConfig.Receiver] == DBNull.Value ? null : objRow[conDataSynConfig.Receiver].ToString().Trim(); //接收者
objDataSynConfigEN.lastMailDate = objRow[conDataSynConfig.lastMailDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期
objDataSynConfigEN.lastExecuteDate = objRow[conDataSynConfig.lastExecuteDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期
objDataSynConfigEN.SynchStartTime = objRow[conDataSynConfig.SynchStartTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间
objDataSynConfigEN.SynchEndTime = objRow[conDataSynConfig.SynchEndTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间
objDataSynConfigEN.OrderNum = TransNullToInt(objRow[conDataSynConfig.OrderNum].ToString().Trim()); //序号
objDataSynConfigEN.Memo = objRow[conDataSynConfig.Memo] == DBNull.Value ? null : objRow[conDataSynConfig.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDataSynConfigDA: GetObjLst)", objException.Message));
}
objDataSynConfigEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDataSynConfigEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsDataSynConfigEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsDataSynConfigDA:GetObjLstBySP)", objException.Message));
}
List<clsDataSynConfigEN> arrObjLst = new List<clsDataSynConfigEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("DataSynConfig_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataSynConfigEN objDataSynConfigEN = new clsDataSynConfigEN();
try
{
objDataSynConfigEN.mId = TransNullToInt(objRow[conDataSynConfig.mId].ToString().Trim()); //mId
objDataSynConfigEN.TabName = objRow[conDataSynConfig.TabName] == DBNull.Value ? null : objRow[conDataSynConfig.TabName].ToString().Trim(); //表名
objDataSynConfigEN.IsSynch = TransNullToBool(objRow[conDataSynConfig.IsSynch].ToString().Trim()); //是否同步
objDataSynConfigEN.SynCondition = objRow[conDataSynConfig.SynCondition].ToString().Trim(); //同步条件
objDataSynConfigEN.SynCondition4Web = objRow[conDataSynConfig.SynCondition4Web] == DBNull.Value ? null : objRow[conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web
objDataSynConfigEN.SynchCycle = objRow[conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期
objDataSynConfigEN.SynchDate = objRow[conDataSynConfig.SynchDate].ToString().Trim(); //同步日期
objDataSynConfigEN.SynchTime = objRow[conDataSynConfig.SynchTime].ToString().Trim(); //同步时间
objDataSynConfigEN.SenderUser = objRow[conDataSynConfig.SenderUser] == DBNull.Value ? null : objRow[conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户
objDataSynConfigEN.SenderPwd = objRow[conDataSynConfig.SenderPwd] == DBNull.Value ? null : objRow[conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令
objDataSynConfigEN.smtp = objRow[conDataSynConfig.smtp] == DBNull.Value ? null : objRow[conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器
objDataSynConfigEN.Receiver = objRow[conDataSynConfig.Receiver] == DBNull.Value ? null : objRow[conDataSynConfig.Receiver].ToString().Trim(); //接收者
objDataSynConfigEN.lastMailDate = objRow[conDataSynConfig.lastMailDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期
objDataSynConfigEN.lastExecuteDate = objRow[conDataSynConfig.lastExecuteDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期
objDataSynConfigEN.SynchStartTime = objRow[conDataSynConfig.SynchStartTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间
objDataSynConfigEN.SynchEndTime = objRow[conDataSynConfig.SynchEndTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间
objDataSynConfigEN.OrderNum = TransNullToInt(objRow[conDataSynConfig.OrderNum].ToString().Trim()); //序号
objDataSynConfigEN.Memo = objRow[conDataSynConfig.Memo] == DBNull.Value ? null : objRow[conDataSynConfig.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsDataSynConfigDA: GetObjLstBySP)", objException.Message));
}
objDataSynConfigEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDataSynConfigEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDataSynConfig(ref clsDataSynConfigEN objDataSynConfigEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
strSQL = "Select * from DataSynConfig where mId = " + ""+ objDataSynConfigEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objDataSynConfigEN.mId = TransNullToInt(objDT.Rows[0][conDataSynConfig.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objDataSynConfigEN.TabName = objDT.Rows[0][conDataSynConfig.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objDataSynConfigEN.IsSynch = TransNullToBool(objDT.Rows[0][conDataSynConfig.IsSynch].ToString().Trim()); //是否同步(字段类型:bit,字段长度:1,是否可空:False)
 objDataSynConfigEN.SynCondition = objDT.Rows[0][conDataSynConfig.SynCondition].ToString().Trim(); //同步条件(字段类型:varchar,字段长度:5000,是否可空:False)
 objDataSynConfigEN.SynCondition4Web = objDT.Rows[0][conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web(字段类型:varchar,字段长度:5000,是否可空:True)
 objDataSynConfigEN.SynchCycle = objDT.Rows[0][conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期(字段类型:varchar,字段长度:30,是否可空:False)
 objDataSynConfigEN.SynchDate = objDT.Rows[0][conDataSynConfig.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:30,是否可空:False)
 objDataSynConfigEN.SynchTime = objDT.Rows[0][conDataSynConfig.SynchTime].ToString().Trim(); //同步时间(字段类型:varchar,字段长度:30,是否可空:False)
 objDataSynConfigEN.SenderUser = objDT.Rows[0][conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户(字段类型:varchar,字段长度:30,是否可空:False)
 objDataSynConfigEN.SenderPwd = objDT.Rows[0][conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令(字段类型:varchar,字段长度:30,是否可空:False)
 objDataSynConfigEN.smtp = objDT.Rows[0][conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器(字段类型:varchar,字段长度:50,是否可空:False)
 objDataSynConfigEN.Receiver = objDT.Rows[0][conDataSynConfig.Receiver].ToString().Trim(); //接收者(字段类型:varchar,字段长度:50,是否可空:False)
 objDataSynConfigEN.lastMailDate = objDT.Rows[0][conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期(字段类型:varchar,字段长度:50,是否可空:True)
 objDataSynConfigEN.lastExecuteDate = objDT.Rows[0][conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期(字段类型:varchar,字段长度:50,是否可空:True)
 objDataSynConfigEN.SynchStartTime = objDT.Rows[0][conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间(字段类型:varchar,字段长度:14,是否可空:True)
 objDataSynConfigEN.SynchEndTime = objDT.Rows[0][conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间(字段类型:varchar,字段长度:14,是否可空:True)
 objDataSynConfigEN.OrderNum = TransNullToInt(objDT.Rows[0][conDataSynConfig.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objDataSynConfigEN.Memo = objDT.Rows[0][conDataSynConfig.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsDataSynConfigDA: GetDataSynConfig)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsDataSynConfigEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
strSQL = "Select * from DataSynConfig where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsDataSynConfigEN objDataSynConfigEN = new clsDataSynConfigEN();
try
{
 objDataSynConfigEN.mId = Int32.Parse(objRow[conDataSynConfig.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objDataSynConfigEN.TabName = objRow[conDataSynConfig.TabName] == DBNull.Value ? null : objRow[conDataSynConfig.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objDataSynConfigEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conDataSynConfig.IsSynch].ToString().Trim()); //是否同步(字段类型:bit,字段长度:1,是否可空:False)
 objDataSynConfigEN.SynCondition = objRow[conDataSynConfig.SynCondition].ToString().Trim(); //同步条件(字段类型:varchar,字段长度:5000,是否可空:False)
 objDataSynConfigEN.SynCondition4Web = objRow[conDataSynConfig.SynCondition4Web] == DBNull.Value ? null : objRow[conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web(字段类型:varchar,字段长度:5000,是否可空:True)
 objDataSynConfigEN.SynchCycle = objRow[conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期(字段类型:varchar,字段长度:30,是否可空:False)
 objDataSynConfigEN.SynchDate = objRow[conDataSynConfig.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:30,是否可空:False)
 objDataSynConfigEN.SynchTime = objRow[conDataSynConfig.SynchTime].ToString().Trim(); //同步时间(字段类型:varchar,字段长度:30,是否可空:False)
 objDataSynConfigEN.SenderUser = objRow[conDataSynConfig.SenderUser] == DBNull.Value ? null : objRow[conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户(字段类型:varchar,字段长度:30,是否可空:False)
 objDataSynConfigEN.SenderPwd = objRow[conDataSynConfig.SenderPwd] == DBNull.Value ? null : objRow[conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令(字段类型:varchar,字段长度:30,是否可空:False)
 objDataSynConfigEN.smtp = objRow[conDataSynConfig.smtp] == DBNull.Value ? null : objRow[conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器(字段类型:varchar,字段长度:50,是否可空:False)
 objDataSynConfigEN.Receiver = objRow[conDataSynConfig.Receiver] == DBNull.Value ? null : objRow[conDataSynConfig.Receiver].ToString().Trim(); //接收者(字段类型:varchar,字段长度:50,是否可空:False)
 objDataSynConfigEN.lastMailDate = objRow[conDataSynConfig.lastMailDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期(字段类型:varchar,字段长度:50,是否可空:True)
 objDataSynConfigEN.lastExecuteDate = objRow[conDataSynConfig.lastExecuteDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期(字段类型:varchar,字段长度:50,是否可空:True)
 objDataSynConfigEN.SynchStartTime = objRow[conDataSynConfig.SynchStartTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间(字段类型:varchar,字段长度:14,是否可空:True)
 objDataSynConfigEN.SynchEndTime = objRow[conDataSynConfig.SynchEndTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间(字段类型:varchar,字段长度:14,是否可空:True)
 objDataSynConfigEN.OrderNum = Int32.Parse(objRow[conDataSynConfig.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objDataSynConfigEN.Memo = objRow[conDataSynConfig.Memo] == DBNull.Value ? null : objRow[conDataSynConfig.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsDataSynConfigDA: GetObjBymId)", objException.Message));
}
return objDataSynConfigEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程DataSynConfig_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDataSynConfigOneBySP(clsDataSynConfigEN objDataSynConfigEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objDataSynConfigEN.mId
};
 objDT = objSQL.ExecSpReturnDT("DataSynConfig_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objDataSynConfigEN.mId = TransNullToInt(objDT.Rows[0][conDataSynConfig.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objDataSynConfigEN.TabName = objDT.Rows[0][conDataSynConfig.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objDataSynConfigEN.IsSynch = TransNullToBool(objDT.Rows[0][conDataSynConfig.IsSynch].ToString().Trim()); //是否同步(字段类型:bit,字段长度:1,是否可空:False)
 objDataSynConfigEN.SynCondition = objDT.Rows[0][conDataSynConfig.SynCondition].ToString().Trim(); //同步条件(字段类型:varchar,字段长度:5000,是否可空:False)
 objDataSynConfigEN.SynCondition4Web = objDT.Rows[0][conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web(字段类型:varchar,字段长度:5000,是否可空:True)
 objDataSynConfigEN.SynchCycle = objDT.Rows[0][conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期(字段类型:varchar,字段长度:30,是否可空:False)
 objDataSynConfigEN.SynchDate = objDT.Rows[0][conDataSynConfig.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:30,是否可空:False)
 objDataSynConfigEN.SynchTime = objDT.Rows[0][conDataSynConfig.SynchTime].ToString().Trim(); //同步时间(字段类型:varchar,字段长度:30,是否可空:False)
 objDataSynConfigEN.SenderUser = objDT.Rows[0][conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户(字段类型:varchar,字段长度:30,是否可空:False)
 objDataSynConfigEN.SenderPwd = objDT.Rows[0][conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令(字段类型:varchar,字段长度:30,是否可空:False)
 objDataSynConfigEN.smtp = objDT.Rows[0][conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器(字段类型:varchar,字段长度:50,是否可空:False)
 objDataSynConfigEN.Receiver = objDT.Rows[0][conDataSynConfig.Receiver].ToString().Trim(); //接收者(字段类型:varchar,字段长度:50,是否可空:False)
 objDataSynConfigEN.lastMailDate = objDT.Rows[0][conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期(字段类型:varchar,字段长度:50,是否可空:True)
 objDataSynConfigEN.lastExecuteDate = objDT.Rows[0][conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期(字段类型:varchar,字段长度:50,是否可空:True)
 objDataSynConfigEN.SynchStartTime = objDT.Rows[0][conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间(字段类型:varchar,字段长度:14,是否可空:True)
 objDataSynConfigEN.SynchEndTime = objDT.Rows[0][conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间(字段类型:varchar,字段长度:14,是否可空:True)
 objDataSynConfigEN.OrderNum = TransNullToInt(objDT.Rows[0][conDataSynConfig.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objDataSynConfigEN.Memo = objDT.Rows[0][conDataSynConfig.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDataSynConfigEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsDataSynConfigDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
strSQL = "Select * from DataSynConfig where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsDataSynConfigEN objDataSynConfigEN = new clsDataSynConfigEN()
{
mId = TransNullToInt(objRow[conDataSynConfig.mId].ToString().Trim()), //mId
TabName = objRow[conDataSynConfig.TabName] == DBNull.Value ? null : objRow[conDataSynConfig.TabName].ToString().Trim(), //表名
IsSynch = TransNullToBool(objRow[conDataSynConfig.IsSynch].ToString().Trim()), //是否同步
SynCondition = objRow[conDataSynConfig.SynCondition].ToString().Trim(), //同步条件
SynCondition4Web = objRow[conDataSynConfig.SynCondition4Web] == DBNull.Value ? null : objRow[conDataSynConfig.SynCondition4Web].ToString().Trim(), //同步条件4Web
SynchCycle = objRow[conDataSynConfig.SynchCycle].ToString().Trim(), //同步周期
SynchDate = objRow[conDataSynConfig.SynchDate].ToString().Trim(), //同步日期
SynchTime = objRow[conDataSynConfig.SynchTime].ToString().Trim(), //同步时间
SenderUser = objRow[conDataSynConfig.SenderUser] == DBNull.Value ? null : objRow[conDataSynConfig.SenderUser].ToString().Trim(), //发送邮件用户
SenderPwd = objRow[conDataSynConfig.SenderPwd] == DBNull.Value ? null : objRow[conDataSynConfig.SenderPwd].ToString().Trim(), //发送邮件口令
smtp = objRow[conDataSynConfig.smtp] == DBNull.Value ? null : objRow[conDataSynConfig.smtp].ToString().Trim(), //发送邮件服务器
Receiver = objRow[conDataSynConfig.Receiver] == DBNull.Value ? null : objRow[conDataSynConfig.Receiver].ToString().Trim(), //接收者
lastMailDate = objRow[conDataSynConfig.lastMailDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastMailDate].ToString().Trim(), //最后发邮件日期
lastExecuteDate = objRow[conDataSynConfig.lastExecuteDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastExecuteDate].ToString().Trim(), //最后执行日期
SynchStartTime = objRow[conDataSynConfig.SynchStartTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchStartTime].ToString().Trim(), //同步开始时间
SynchEndTime = objRow[conDataSynConfig.SynchEndTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchEndTime].ToString().Trim(), //同步结束时间
OrderNum = TransNullToInt(objRow[conDataSynConfig.OrderNum].ToString().Trim()), //序号
Memo = objRow[conDataSynConfig.Memo] == DBNull.Value ? null : objRow[conDataSynConfig.Memo].ToString().Trim() //说明
};
objDataSynConfigEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataSynConfigEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsDataSynConfigDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDataSynConfigEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsDataSynConfigDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("DataSynConfig_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsDataSynConfigEN objDataSynConfigEN = new clsDataSynConfigEN()
{
mId = TransNullToInt(objRow[conDataSynConfig.mId].ToString().Trim()), //mId
TabName = objRow[conDataSynConfig.TabName] == DBNull.Value ? null : objRow[conDataSynConfig.TabName].ToString().Trim(), //表名
IsSynch = TransNullToBool(objRow[conDataSynConfig.IsSynch].ToString().Trim()), //是否同步
SynCondition = objRow[conDataSynConfig.SynCondition].ToString().Trim(), //同步条件
SynCondition4Web = objRow[conDataSynConfig.SynCondition4Web] == DBNull.Value ? null : objRow[conDataSynConfig.SynCondition4Web].ToString().Trim(), //同步条件4Web
SynchCycle = objRow[conDataSynConfig.SynchCycle].ToString().Trim(), //同步周期
SynchDate = objRow[conDataSynConfig.SynchDate].ToString().Trim(), //同步日期
SynchTime = objRow[conDataSynConfig.SynchTime].ToString().Trim(), //同步时间
SenderUser = objRow[conDataSynConfig.SenderUser] == DBNull.Value ? null : objRow[conDataSynConfig.SenderUser].ToString().Trim(), //发送邮件用户
SenderPwd = objRow[conDataSynConfig.SenderPwd] == DBNull.Value ? null : objRow[conDataSynConfig.SenderPwd].ToString().Trim(), //发送邮件口令
smtp = objRow[conDataSynConfig.smtp] == DBNull.Value ? null : objRow[conDataSynConfig.smtp].ToString().Trim(), //发送邮件服务器
Receiver = objRow[conDataSynConfig.Receiver] == DBNull.Value ? null : objRow[conDataSynConfig.Receiver].ToString().Trim(), //接收者
lastMailDate = objRow[conDataSynConfig.lastMailDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastMailDate].ToString().Trim(), //最后发邮件日期
lastExecuteDate = objRow[conDataSynConfig.lastExecuteDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastExecuteDate].ToString().Trim(), //最后执行日期
SynchStartTime = objRow[conDataSynConfig.SynchStartTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchStartTime].ToString().Trim(), //同步开始时间
SynchEndTime = objRow[conDataSynConfig.SynchEndTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchEndTime].ToString().Trim(), //同步结束时间
OrderNum = TransNullToInt(objRow[conDataSynConfig.OrderNum].ToString().Trim()), //序号
Memo = objRow[conDataSynConfig.Memo] == DBNull.Value ? null : objRow[conDataSynConfig.Memo].ToString().Trim() //说明
};
objDataSynConfigEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataSynConfigEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsDataSynConfigEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDataSynConfigEN objDataSynConfigEN = new clsDataSynConfigEN();
try
{
objDataSynConfigEN.mId = TransNullToInt(objRow[conDataSynConfig.mId].ToString().Trim()); //mId
objDataSynConfigEN.TabName = objRow[conDataSynConfig.TabName] == DBNull.Value ? null : objRow[conDataSynConfig.TabName].ToString().Trim(); //表名
objDataSynConfigEN.IsSynch = TransNullToBool(objRow[conDataSynConfig.IsSynch].ToString().Trim()); //是否同步
objDataSynConfigEN.SynCondition = objRow[conDataSynConfig.SynCondition].ToString().Trim(); //同步条件
objDataSynConfigEN.SynCondition4Web = objRow[conDataSynConfig.SynCondition4Web] == DBNull.Value ? null : objRow[conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web
objDataSynConfigEN.SynchCycle = objRow[conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期
objDataSynConfigEN.SynchDate = objRow[conDataSynConfig.SynchDate].ToString().Trim(); //同步日期
objDataSynConfigEN.SynchTime = objRow[conDataSynConfig.SynchTime].ToString().Trim(); //同步时间
objDataSynConfigEN.SenderUser = objRow[conDataSynConfig.SenderUser] == DBNull.Value ? null : objRow[conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户
objDataSynConfigEN.SenderPwd = objRow[conDataSynConfig.SenderPwd] == DBNull.Value ? null : objRow[conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令
objDataSynConfigEN.smtp = objRow[conDataSynConfig.smtp] == DBNull.Value ? null : objRow[conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器
objDataSynConfigEN.Receiver = objRow[conDataSynConfig.Receiver] == DBNull.Value ? null : objRow[conDataSynConfig.Receiver].ToString().Trim(); //接收者
objDataSynConfigEN.lastMailDate = objRow[conDataSynConfig.lastMailDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期
objDataSynConfigEN.lastExecuteDate = objRow[conDataSynConfig.lastExecuteDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期
objDataSynConfigEN.SynchStartTime = objRow[conDataSynConfig.SynchStartTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间
objDataSynConfigEN.SynchEndTime = objRow[conDataSynConfig.SynchEndTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间
objDataSynConfigEN.OrderNum = TransNullToInt(objRow[conDataSynConfig.OrderNum].ToString().Trim()); //序号
objDataSynConfigEN.Memo = objRow[conDataSynConfig.Memo] == DBNull.Value ? null : objRow[conDataSynConfig.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsDataSynConfigDA: GetObjByDataRowDataSynConfig)", objException.Message));
}
objDataSynConfigEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataSynConfigEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsDataSynConfigEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDataSynConfigEN objDataSynConfigEN = new clsDataSynConfigEN();
try
{
objDataSynConfigEN.mId = TransNullToInt(objRow[conDataSynConfig.mId].ToString().Trim()); //mId
objDataSynConfigEN.TabName = objRow[conDataSynConfig.TabName] == DBNull.Value ? null : objRow[conDataSynConfig.TabName].ToString().Trim(); //表名
objDataSynConfigEN.IsSynch = TransNullToBool(objRow[conDataSynConfig.IsSynch].ToString().Trim()); //是否同步
objDataSynConfigEN.SynCondition = objRow[conDataSynConfig.SynCondition].ToString().Trim(); //同步条件
objDataSynConfigEN.SynCondition4Web = objRow[conDataSynConfig.SynCondition4Web] == DBNull.Value ? null : objRow[conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web
objDataSynConfigEN.SynchCycle = objRow[conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期
objDataSynConfigEN.SynchDate = objRow[conDataSynConfig.SynchDate].ToString().Trim(); //同步日期
objDataSynConfigEN.SynchTime = objRow[conDataSynConfig.SynchTime].ToString().Trim(); //同步时间
objDataSynConfigEN.SenderUser = objRow[conDataSynConfig.SenderUser] == DBNull.Value ? null : objRow[conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户
objDataSynConfigEN.SenderPwd = objRow[conDataSynConfig.SenderPwd] == DBNull.Value ? null : objRow[conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令
objDataSynConfigEN.smtp = objRow[conDataSynConfig.smtp] == DBNull.Value ? null : objRow[conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器
objDataSynConfigEN.Receiver = objRow[conDataSynConfig.Receiver] == DBNull.Value ? null : objRow[conDataSynConfig.Receiver].ToString().Trim(); //接收者
objDataSynConfigEN.lastMailDate = objRow[conDataSynConfig.lastMailDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期
objDataSynConfigEN.lastExecuteDate = objRow[conDataSynConfig.lastExecuteDate] == DBNull.Value ? null : objRow[conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期
objDataSynConfigEN.SynchStartTime = objRow[conDataSynConfig.SynchStartTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间
objDataSynConfigEN.SynchEndTime = objRow[conDataSynConfig.SynchEndTime] == DBNull.Value ? null : objRow[conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间
objDataSynConfigEN.OrderNum = TransNullToInt(objRow[conDataSynConfig.OrderNum].ToString().Trim()); //序号
objDataSynConfigEN.Memo = objRow[conDataSynConfig.Memo] == DBNull.Value ? null : objRow[conDataSynConfig.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsDataSynConfigDA: GetObjByDataRow)", objException.Message));
}
objDataSynConfigEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataSynConfigEN;
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
objSQL = clsDataSynConfigDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDataSynConfigEN._CurrTabName, conDataSynConfig.mId, 8, "");
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
objSQL = clsDataSynConfigDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDataSynConfigEN._CurrTabName, conDataSynConfig.mId, 8, strPrefix);
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
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from DataSynConfig where " + strCondition;
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
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from DataSynConfig where " + strCondition;
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
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DataSynConfig", "mId = " + ""+ lngmId+""))
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
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("DataSynConfig_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsDataSynConfigDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DataSynConfig", strCondition))
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
objSQL = clsDataSynConfigDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("DataSynConfig");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsDataSynConfigEN objDataSynConfigEN)
 {
 if (objDataSynConfigEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataSynConfigEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
strSQL = "Select * from DataSynConfig where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DataSynConfig");
objRow = objDS.Tables["DataSynConfig"].NewRow();
 if (objDataSynConfigEN.TabName !=  "")
 {
objRow[conDataSynConfig.TabName] = objDataSynConfigEN.TabName; //表名
 }
objRow[conDataSynConfig.IsSynch] = objDataSynConfigEN.IsSynch; //是否同步
objRow[conDataSynConfig.SynCondition] = objDataSynConfigEN.SynCondition; //同步条件
 if (objDataSynConfigEN.SynCondition4Web !=  "")
 {
objRow[conDataSynConfig.SynCondition4Web] = objDataSynConfigEN.SynCondition4Web; //同步条件4Web
 }
objRow[conDataSynConfig.SynchCycle] = objDataSynConfigEN.SynchCycle; //同步周期
objRow[conDataSynConfig.SynchDate] = objDataSynConfigEN.SynchDate; //同步日期
objRow[conDataSynConfig.SynchTime] = objDataSynConfigEN.SynchTime; //同步时间
 if (objDataSynConfigEN.SenderUser !=  "")
 {
objRow[conDataSynConfig.SenderUser] = objDataSynConfigEN.SenderUser; //发送邮件用户
 }
 if (objDataSynConfigEN.SenderPwd !=  "")
 {
objRow[conDataSynConfig.SenderPwd] = objDataSynConfigEN.SenderPwd; //发送邮件口令
 }
 if (objDataSynConfigEN.smtp !=  "")
 {
objRow[conDataSynConfig.smtp] = objDataSynConfigEN.smtp; //发送邮件服务器
 }
 if (objDataSynConfigEN.Receiver !=  "")
 {
objRow[conDataSynConfig.Receiver] = objDataSynConfigEN.Receiver; //接收者
 }
 if (objDataSynConfigEN.lastMailDate !=  "")
 {
objRow[conDataSynConfig.lastMailDate] = objDataSynConfigEN.lastMailDate; //最后发邮件日期
 }
 if (objDataSynConfigEN.lastExecuteDate !=  "")
 {
objRow[conDataSynConfig.lastExecuteDate] = objDataSynConfigEN.lastExecuteDate; //最后执行日期
 }
 if (objDataSynConfigEN.SynchStartTime !=  "")
 {
objRow[conDataSynConfig.SynchStartTime] = objDataSynConfigEN.SynchStartTime; //同步开始时间
 }
 if (objDataSynConfigEN.SynchEndTime !=  "")
 {
objRow[conDataSynConfig.SynchEndTime] = objDataSynConfigEN.SynchEndTime; //同步结束时间
 }
objRow[conDataSynConfig.OrderNum] = objDataSynConfigEN.OrderNum; //序号
 if (objDataSynConfigEN.Memo !=  "")
 {
objRow[conDataSynConfig.Memo] = objDataSynConfigEN.Memo; //说明
 }
objDS.Tables[clsDataSynConfigEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsDataSynConfigEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDataSynConfigEN objDataSynConfigEN)
{
 if (objDataSynConfigEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataSynConfigEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDataSynConfigEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.TabName);
 objDataSynConfigEN.TabName = objDataSynConfigEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.TabName + "'");
 }
 
 arrFieldListForInsert.Add(conDataSynConfig.IsSynch);
 arrValueListForInsert.Add("'" + (objDataSynConfigEN.IsSynch  ==  false ? "0" : "1") + "'");
 
 if (objDataSynConfigEN.SynCondition !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynCondition);
 objDataSynConfigEN.SynCondition = objDataSynConfigEN.SynCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynCondition + "'");
 }
 
 if (objDataSynConfigEN.SynCondition4Web !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynCondition4Web);
 objDataSynConfigEN.SynCondition4Web = objDataSynConfigEN.SynCondition4Web.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynCondition4Web + "'");
 }
 
 if (objDataSynConfigEN.SynchCycle !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchCycle);
 objDataSynConfigEN.SynchCycle = objDataSynConfigEN.SynchCycle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchCycle + "'");
 }
 
 if (objDataSynConfigEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchDate);
 objDataSynConfigEN.SynchDate = objDataSynConfigEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchDate + "'");
 }
 
 if (objDataSynConfigEN.SynchTime !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchTime);
 objDataSynConfigEN.SynchTime = objDataSynConfigEN.SynchTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchTime + "'");
 }
 
 if (objDataSynConfigEN.SenderUser !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SenderUser);
 objDataSynConfigEN.SenderUser = objDataSynConfigEN.SenderUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SenderUser + "'");
 }
 
 if (objDataSynConfigEN.SenderPwd !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SenderPwd);
 objDataSynConfigEN.SenderPwd = objDataSynConfigEN.SenderPwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SenderPwd + "'");
 }
 
 if (objDataSynConfigEN.smtp !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.smtp);
 objDataSynConfigEN.smtp = objDataSynConfigEN.smtp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.smtp + "'");
 }
 
 if (objDataSynConfigEN.Receiver !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.Receiver);
 objDataSynConfigEN.Receiver = objDataSynConfigEN.Receiver.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.Receiver + "'");
 }
 
 if (objDataSynConfigEN.lastMailDate !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.lastMailDate);
 objDataSynConfigEN.lastMailDate = objDataSynConfigEN.lastMailDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.lastMailDate + "'");
 }
 
 if (objDataSynConfigEN.lastExecuteDate !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.lastExecuteDate);
 objDataSynConfigEN.lastExecuteDate = objDataSynConfigEN.lastExecuteDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.lastExecuteDate + "'");
 }
 
 if (objDataSynConfigEN.SynchStartTime !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchStartTime);
 objDataSynConfigEN.SynchStartTime = objDataSynConfigEN.SynchStartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchStartTime + "'");
 }
 
 if (objDataSynConfigEN.SynchEndTime !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchEndTime);
 objDataSynConfigEN.SynchEndTime = objDataSynConfigEN.SynchEndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchEndTime + "'");
 }
 
 arrFieldListForInsert.Add(conDataSynConfig.OrderNum);
 arrValueListForInsert.Add(objDataSynConfigEN.OrderNum.ToString());
 
 if (objDataSynConfigEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.Memo);
 objDataSynConfigEN.Memo = objDataSynConfigEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataSynConfig");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDataSynConfigEN objDataSynConfigEN)
{
 if (objDataSynConfigEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataSynConfigEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDataSynConfigEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.TabName);
 objDataSynConfigEN.TabName = objDataSynConfigEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.TabName + "'");
 }
 
 arrFieldListForInsert.Add(conDataSynConfig.IsSynch);
 arrValueListForInsert.Add("'" + (objDataSynConfigEN.IsSynch  ==  false ? "0" : "1") + "'");
 
 if (objDataSynConfigEN.SynCondition !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynCondition);
 objDataSynConfigEN.SynCondition = objDataSynConfigEN.SynCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynCondition + "'");
 }
 
 if (objDataSynConfigEN.SynCondition4Web !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynCondition4Web);
 objDataSynConfigEN.SynCondition4Web = objDataSynConfigEN.SynCondition4Web.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynCondition4Web + "'");
 }
 
 if (objDataSynConfigEN.SynchCycle !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchCycle);
 objDataSynConfigEN.SynchCycle = objDataSynConfigEN.SynchCycle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchCycle + "'");
 }
 
 if (objDataSynConfigEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchDate);
 objDataSynConfigEN.SynchDate = objDataSynConfigEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchDate + "'");
 }
 
 if (objDataSynConfigEN.SynchTime !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchTime);
 objDataSynConfigEN.SynchTime = objDataSynConfigEN.SynchTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchTime + "'");
 }
 
 if (objDataSynConfigEN.SenderUser !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SenderUser);
 objDataSynConfigEN.SenderUser = objDataSynConfigEN.SenderUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SenderUser + "'");
 }
 
 if (objDataSynConfigEN.SenderPwd !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SenderPwd);
 objDataSynConfigEN.SenderPwd = objDataSynConfigEN.SenderPwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SenderPwd + "'");
 }
 
 if (objDataSynConfigEN.smtp !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.smtp);
 objDataSynConfigEN.smtp = objDataSynConfigEN.smtp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.smtp + "'");
 }
 
 if (objDataSynConfigEN.Receiver !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.Receiver);
 objDataSynConfigEN.Receiver = objDataSynConfigEN.Receiver.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.Receiver + "'");
 }
 
 if (objDataSynConfigEN.lastMailDate !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.lastMailDate);
 objDataSynConfigEN.lastMailDate = objDataSynConfigEN.lastMailDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.lastMailDate + "'");
 }
 
 if (objDataSynConfigEN.lastExecuteDate !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.lastExecuteDate);
 objDataSynConfigEN.lastExecuteDate = objDataSynConfigEN.lastExecuteDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.lastExecuteDate + "'");
 }
 
 if (objDataSynConfigEN.SynchStartTime !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchStartTime);
 objDataSynConfigEN.SynchStartTime = objDataSynConfigEN.SynchStartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchStartTime + "'");
 }
 
 if (objDataSynConfigEN.SynchEndTime !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchEndTime);
 objDataSynConfigEN.SynchEndTime = objDataSynConfigEN.SynchEndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchEndTime + "'");
 }
 
 arrFieldListForInsert.Add(conDataSynConfig.OrderNum);
 arrValueListForInsert.Add(objDataSynConfigEN.OrderNum.ToString());
 
 if (objDataSynConfigEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.Memo);
 objDataSynConfigEN.Memo = objDataSynConfigEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataSynConfig");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDataSynConfigEN objDataSynConfigEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objDataSynConfigEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataSynConfigEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDataSynConfigEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.TabName);
 objDataSynConfigEN.TabName = objDataSynConfigEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.TabName + "'");
 }
 
 arrFieldListForInsert.Add(conDataSynConfig.IsSynch);
 arrValueListForInsert.Add("'" + (objDataSynConfigEN.IsSynch  ==  false ? "0" : "1") + "'");
 
 if (objDataSynConfigEN.SynCondition !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynCondition);
 objDataSynConfigEN.SynCondition = objDataSynConfigEN.SynCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynCondition + "'");
 }
 
 if (objDataSynConfigEN.SynCondition4Web !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynCondition4Web);
 objDataSynConfigEN.SynCondition4Web = objDataSynConfigEN.SynCondition4Web.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynCondition4Web + "'");
 }
 
 if (objDataSynConfigEN.SynchCycle !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchCycle);
 objDataSynConfigEN.SynchCycle = objDataSynConfigEN.SynchCycle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchCycle + "'");
 }
 
 if (objDataSynConfigEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchDate);
 objDataSynConfigEN.SynchDate = objDataSynConfigEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchDate + "'");
 }
 
 if (objDataSynConfigEN.SynchTime !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchTime);
 objDataSynConfigEN.SynchTime = objDataSynConfigEN.SynchTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchTime + "'");
 }
 
 if (objDataSynConfigEN.SenderUser !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SenderUser);
 objDataSynConfigEN.SenderUser = objDataSynConfigEN.SenderUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SenderUser + "'");
 }
 
 if (objDataSynConfigEN.SenderPwd !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SenderPwd);
 objDataSynConfigEN.SenderPwd = objDataSynConfigEN.SenderPwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SenderPwd + "'");
 }
 
 if (objDataSynConfigEN.smtp !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.smtp);
 objDataSynConfigEN.smtp = objDataSynConfigEN.smtp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.smtp + "'");
 }
 
 if (objDataSynConfigEN.Receiver !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.Receiver);
 objDataSynConfigEN.Receiver = objDataSynConfigEN.Receiver.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.Receiver + "'");
 }
 
 if (objDataSynConfigEN.lastMailDate !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.lastMailDate);
 objDataSynConfigEN.lastMailDate = objDataSynConfigEN.lastMailDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.lastMailDate + "'");
 }
 
 if (objDataSynConfigEN.lastExecuteDate !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.lastExecuteDate);
 objDataSynConfigEN.lastExecuteDate = objDataSynConfigEN.lastExecuteDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.lastExecuteDate + "'");
 }
 
 if (objDataSynConfigEN.SynchStartTime !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchStartTime);
 objDataSynConfigEN.SynchStartTime = objDataSynConfigEN.SynchStartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchStartTime + "'");
 }
 
 if (objDataSynConfigEN.SynchEndTime !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchEndTime);
 objDataSynConfigEN.SynchEndTime = objDataSynConfigEN.SynchEndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchEndTime + "'");
 }
 
 arrFieldListForInsert.Add(conDataSynConfig.OrderNum);
 arrValueListForInsert.Add(objDataSynConfigEN.OrderNum.ToString());
 
 if (objDataSynConfigEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.Memo);
 objDataSynConfigEN.Memo = objDataSynConfigEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataSynConfig");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDataSynConfigEN objDataSynConfigEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objDataSynConfigEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataSynConfigEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDataSynConfigEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.TabName);
 objDataSynConfigEN.TabName = objDataSynConfigEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.TabName + "'");
 }
 
 arrFieldListForInsert.Add(conDataSynConfig.IsSynch);
 arrValueListForInsert.Add("'" + (objDataSynConfigEN.IsSynch  ==  false ? "0" : "1") + "'");
 
 if (objDataSynConfigEN.SynCondition !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynCondition);
 objDataSynConfigEN.SynCondition = objDataSynConfigEN.SynCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynCondition + "'");
 }
 
 if (objDataSynConfigEN.SynCondition4Web !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynCondition4Web);
 objDataSynConfigEN.SynCondition4Web = objDataSynConfigEN.SynCondition4Web.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynCondition4Web + "'");
 }
 
 if (objDataSynConfigEN.SynchCycle !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchCycle);
 objDataSynConfigEN.SynchCycle = objDataSynConfigEN.SynchCycle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchCycle + "'");
 }
 
 if (objDataSynConfigEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchDate);
 objDataSynConfigEN.SynchDate = objDataSynConfigEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchDate + "'");
 }
 
 if (objDataSynConfigEN.SynchTime !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchTime);
 objDataSynConfigEN.SynchTime = objDataSynConfigEN.SynchTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchTime + "'");
 }
 
 if (objDataSynConfigEN.SenderUser !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SenderUser);
 objDataSynConfigEN.SenderUser = objDataSynConfigEN.SenderUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SenderUser + "'");
 }
 
 if (objDataSynConfigEN.SenderPwd !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SenderPwd);
 objDataSynConfigEN.SenderPwd = objDataSynConfigEN.SenderPwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SenderPwd + "'");
 }
 
 if (objDataSynConfigEN.smtp !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.smtp);
 objDataSynConfigEN.smtp = objDataSynConfigEN.smtp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.smtp + "'");
 }
 
 if (objDataSynConfigEN.Receiver !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.Receiver);
 objDataSynConfigEN.Receiver = objDataSynConfigEN.Receiver.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.Receiver + "'");
 }
 
 if (objDataSynConfigEN.lastMailDate !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.lastMailDate);
 objDataSynConfigEN.lastMailDate = objDataSynConfigEN.lastMailDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.lastMailDate + "'");
 }
 
 if (objDataSynConfigEN.lastExecuteDate !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.lastExecuteDate);
 objDataSynConfigEN.lastExecuteDate = objDataSynConfigEN.lastExecuteDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.lastExecuteDate + "'");
 }
 
 if (objDataSynConfigEN.SynchStartTime !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchStartTime);
 objDataSynConfigEN.SynchStartTime = objDataSynConfigEN.SynchStartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchStartTime + "'");
 }
 
 if (objDataSynConfigEN.SynchEndTime !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.SynchEndTime);
 objDataSynConfigEN.SynchEndTime = objDataSynConfigEN.SynchEndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.SynchEndTime + "'");
 }
 
 arrFieldListForInsert.Add(conDataSynConfig.OrderNum);
 arrValueListForInsert.Add(objDataSynConfigEN.OrderNum.ToString());
 
 if (objDataSynConfigEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataSynConfig.Memo);
 objDataSynConfigEN.Memo = objDataSynConfigEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objDataSynConfigEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataSynConfig");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewDataSynConfigBySP(clsDataSynConfigEN objDataSynConfigEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objDataSynConfigEN.TabName,
 objDataSynConfigEN.IsSynch,
 objDataSynConfigEN.SynCondition,
 objDataSynConfigEN.SynCondition4Web,
 objDataSynConfigEN.SynchCycle,
 objDataSynConfigEN.SynchDate,
 objDataSynConfigEN.SynchTime,
 objDataSynConfigEN.SenderUser,
 objDataSynConfigEN.SenderPwd,
 objDataSynConfigEN.smtp,
 objDataSynConfigEN.Receiver,
 objDataSynConfigEN.lastMailDate,
 objDataSynConfigEN.lastExecuteDate,
 objDataSynConfigEN.SynchStartTime,
 objDataSynConfigEN.SynchEndTime,
 objDataSynConfigEN.OrderNum,
objDataSynConfigEN.Memo
};
 objSQL.ExecSP("DataSynConfig_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewDataSynConfigs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
strSQL = "Select * from DataSynConfig where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DataSynConfig");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conDataSynConfig.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsDataSynConfigEN._CurrTabName ].NewRow();
objRow[conDataSynConfig.TabName] = oRow[conDataSynConfig.TabName].ToString().Trim(); //表名
objRow[conDataSynConfig.IsSynch] = oRow[conDataSynConfig.IsSynch].ToString().Trim(); //是否同步
objRow[conDataSynConfig.SynCondition] = oRow[conDataSynConfig.SynCondition].ToString().Trim(); //同步条件
objRow[conDataSynConfig.SynCondition4Web] = oRow[conDataSynConfig.SynCondition4Web].ToString().Trim(); //同步条件4Web
objRow[conDataSynConfig.SynchCycle] = oRow[conDataSynConfig.SynchCycle].ToString().Trim(); //同步周期
objRow[conDataSynConfig.SynchDate] = oRow[conDataSynConfig.SynchDate].ToString().Trim(); //同步日期
objRow[conDataSynConfig.SynchTime] = oRow[conDataSynConfig.SynchTime].ToString().Trim(); //同步时间
objRow[conDataSynConfig.SenderUser] = oRow[conDataSynConfig.SenderUser].ToString().Trim(); //发送邮件用户
objRow[conDataSynConfig.SenderPwd] = oRow[conDataSynConfig.SenderPwd].ToString().Trim(); //发送邮件口令
objRow[conDataSynConfig.smtp] = oRow[conDataSynConfig.smtp].ToString().Trim(); //发送邮件服务器
objRow[conDataSynConfig.Receiver] = oRow[conDataSynConfig.Receiver].ToString().Trim(); //接收者
objRow[conDataSynConfig.lastMailDate] = oRow[conDataSynConfig.lastMailDate].ToString().Trim(); //最后发邮件日期
objRow[conDataSynConfig.lastExecuteDate] = oRow[conDataSynConfig.lastExecuteDate].ToString().Trim(); //最后执行日期
objRow[conDataSynConfig.SynchStartTime] = oRow[conDataSynConfig.SynchStartTime].ToString().Trim(); //同步开始时间
objRow[conDataSynConfig.SynchEndTime] = oRow[conDataSynConfig.SynchEndTime].ToString().Trim(); //同步结束时间
objRow[conDataSynConfig.OrderNum] = oRow[conDataSynConfig.OrderNum].ToString().Trim(); //序号
objRow[conDataSynConfig.Memo] = oRow[conDataSynConfig.Memo].ToString().Trim(); //说明
 objDS.Tables[clsDataSynConfigEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsDataSynConfigEN._CurrTabName);
}
catch(Exception objException) 
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
objSQL.SQLConnect.Close();
}
return true;
}

 #endregion 添加记录

 #region 修改记录

 /// <summary>
 /// 功能:通过ADO修改记录
 /// (AutoGCLib.DALCode4CSharp:GenUpdate)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsDataSynConfigEN objDataSynConfigEN)
{
 if (objDataSynConfigEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataSynConfigEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
strSQL = "Select * from DataSynConfig where mId = " + ""+ objDataSynConfigEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsDataSynConfigEN._CurrTabName);
if (objDS.Tables[clsDataSynConfigEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objDataSynConfigEN.mId+"");
return false;
}
objRow = objDS.Tables[clsDataSynConfigEN._CurrTabName].Rows[0];
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.TabName))
 {
objRow[conDataSynConfig.TabName] = objDataSynConfigEN.TabName; //表名
 }
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.IsSynch))
 {
objRow[conDataSynConfig.IsSynch] = objDataSynConfigEN.IsSynch; //是否同步
 }
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynCondition))
 {
objRow[conDataSynConfig.SynCondition] = objDataSynConfigEN.SynCondition; //同步条件
 }
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynCondition4Web))
 {
objRow[conDataSynConfig.SynCondition4Web] = objDataSynConfigEN.SynCondition4Web; //同步条件4Web
 }
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchCycle))
 {
objRow[conDataSynConfig.SynchCycle] = objDataSynConfigEN.SynchCycle; //同步周期
 }
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchDate))
 {
objRow[conDataSynConfig.SynchDate] = objDataSynConfigEN.SynchDate; //同步日期
 }
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchTime))
 {
objRow[conDataSynConfig.SynchTime] = objDataSynConfigEN.SynchTime; //同步时间
 }
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SenderUser))
 {
objRow[conDataSynConfig.SenderUser] = objDataSynConfigEN.SenderUser; //发送邮件用户
 }
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SenderPwd))
 {
objRow[conDataSynConfig.SenderPwd] = objDataSynConfigEN.SenderPwd; //发送邮件口令
 }
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.smtp))
 {
objRow[conDataSynConfig.smtp] = objDataSynConfigEN.smtp; //发送邮件服务器
 }
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.Receiver))
 {
objRow[conDataSynConfig.Receiver] = objDataSynConfigEN.Receiver; //接收者
 }
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.lastMailDate))
 {
objRow[conDataSynConfig.lastMailDate] = objDataSynConfigEN.lastMailDate; //最后发邮件日期
 }
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.lastExecuteDate))
 {
objRow[conDataSynConfig.lastExecuteDate] = objDataSynConfigEN.lastExecuteDate; //最后执行日期
 }
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchStartTime))
 {
objRow[conDataSynConfig.SynchStartTime] = objDataSynConfigEN.SynchStartTime; //同步开始时间
 }
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchEndTime))
 {
objRow[conDataSynConfig.SynchEndTime] = objDataSynConfigEN.SynchEndTime; //同步结束时间
 }
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.OrderNum))
 {
objRow[conDataSynConfig.OrderNum] = objDataSynConfigEN.OrderNum; //序号
 }
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.Memo))
 {
objRow[conDataSynConfig.Memo] = objDataSynConfigEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsDataSynConfigEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}


 /// <summary>
 /// /// 功能:通过存储过程(StoreProcedure)来修改记录
 /// /// 缺点:1、不能支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySP)
 /// </summary>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySP(clsDataSynConfigEN objDataSynConfigEN)
{
 if (objDataSynConfigEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataSynConfigEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objDataSynConfigEN.mId,
 objDataSynConfigEN.TabName,
 objDataSynConfigEN.IsSynch,
 objDataSynConfigEN.SynCondition,
 objDataSynConfigEN.SynCondition4Web,
 objDataSynConfigEN.SynchCycle,
 objDataSynConfigEN.SynchDate,
 objDataSynConfigEN.SynchTime,
 objDataSynConfigEN.SenderUser,
 objDataSynConfigEN.SenderPwd,
 objDataSynConfigEN.smtp,
 objDataSynConfigEN.Receiver,
 objDataSynConfigEN.lastMailDate,
 objDataSynConfigEN.lastExecuteDate,
 objDataSynConfigEN.SynchStartTime,
 objDataSynConfigEN.SynchEndTime,
 objDataSynConfigEN.OrderNum,
 objDataSynConfigEN.Memo
};
 objSQL.ExecSP("DataSynConfig_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDataSynConfigEN objDataSynConfigEN)
{
 if (objDataSynConfigEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataSynConfigEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update DataSynConfig Set ");
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.TabName))
 {
 if (objDataSynConfigEN.TabName !=  null)
 {
 objDataSynConfigEN.TabName = objDataSynConfigEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.TabName, conDataSynConfig.TabName); //表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.TabName); //表名
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.IsSynch))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataSynConfigEN.IsSynch == true?"1":"0", conDataSynConfig.IsSynch); //是否同步
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynCondition))
 {
 if (objDataSynConfigEN.SynCondition !=  null)
 {
 objDataSynConfigEN.SynCondition = objDataSynConfigEN.SynCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.SynCondition, conDataSynConfig.SynCondition); //同步条件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.SynCondition); //同步条件
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynCondition4Web))
 {
 if (objDataSynConfigEN.SynCondition4Web !=  null)
 {
 objDataSynConfigEN.SynCondition4Web = objDataSynConfigEN.SynCondition4Web.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.SynCondition4Web, conDataSynConfig.SynCondition4Web); //同步条件4Web
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.SynCondition4Web); //同步条件4Web
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchCycle))
 {
 if (objDataSynConfigEN.SynchCycle !=  null)
 {
 objDataSynConfigEN.SynchCycle = objDataSynConfigEN.SynchCycle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.SynchCycle, conDataSynConfig.SynchCycle); //同步周期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.SynchCycle); //同步周期
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchDate))
 {
 if (objDataSynConfigEN.SynchDate !=  null)
 {
 objDataSynConfigEN.SynchDate = objDataSynConfigEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.SynchDate, conDataSynConfig.SynchDate); //同步日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.SynchDate); //同步日期
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchTime))
 {
 if (objDataSynConfigEN.SynchTime !=  null)
 {
 objDataSynConfigEN.SynchTime = objDataSynConfigEN.SynchTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.SynchTime, conDataSynConfig.SynchTime); //同步时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.SynchTime); //同步时间
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SenderUser))
 {
 if (objDataSynConfigEN.SenderUser !=  null)
 {
 objDataSynConfigEN.SenderUser = objDataSynConfigEN.SenderUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.SenderUser, conDataSynConfig.SenderUser); //发送邮件用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.SenderUser); //发送邮件用户
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SenderPwd))
 {
 if (objDataSynConfigEN.SenderPwd !=  null)
 {
 objDataSynConfigEN.SenderPwd = objDataSynConfigEN.SenderPwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.SenderPwd, conDataSynConfig.SenderPwd); //发送邮件口令
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.SenderPwd); //发送邮件口令
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.smtp))
 {
 if (objDataSynConfigEN.smtp !=  null)
 {
 objDataSynConfigEN.smtp = objDataSynConfigEN.smtp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.smtp, conDataSynConfig.smtp); //发送邮件服务器
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.smtp); //发送邮件服务器
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.Receiver))
 {
 if (objDataSynConfigEN.Receiver !=  null)
 {
 objDataSynConfigEN.Receiver = objDataSynConfigEN.Receiver.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.Receiver, conDataSynConfig.Receiver); //接收者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.Receiver); //接收者
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.lastMailDate))
 {
 if (objDataSynConfigEN.lastMailDate !=  null)
 {
 objDataSynConfigEN.lastMailDate = objDataSynConfigEN.lastMailDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.lastMailDate, conDataSynConfig.lastMailDate); //最后发邮件日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.lastMailDate); //最后发邮件日期
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.lastExecuteDate))
 {
 if (objDataSynConfigEN.lastExecuteDate !=  null)
 {
 objDataSynConfigEN.lastExecuteDate = objDataSynConfigEN.lastExecuteDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.lastExecuteDate, conDataSynConfig.lastExecuteDate); //最后执行日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.lastExecuteDate); //最后执行日期
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchStartTime))
 {
 if (objDataSynConfigEN.SynchStartTime !=  null)
 {
 objDataSynConfigEN.SynchStartTime = objDataSynConfigEN.SynchStartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.SynchStartTime, conDataSynConfig.SynchStartTime); //同步开始时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.SynchStartTime); //同步开始时间
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchEndTime))
 {
 if (objDataSynConfigEN.SynchEndTime !=  null)
 {
 objDataSynConfigEN.SynchEndTime = objDataSynConfigEN.SynchEndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.SynchEndTime, conDataSynConfig.SynchEndTime); //同步结束时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.SynchEndTime); //同步结束时间
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objDataSynConfigEN.OrderNum, conDataSynConfig.OrderNum); //序号
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.Memo))
 {
 if (objDataSynConfigEN.Memo !=  null)
 {
 objDataSynConfigEN.Memo = objDataSynConfigEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.Memo, conDataSynConfig.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objDataSynConfigEN.mId); 
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
string strMsg = string.Format("发生错误:[{0}].SQL:[{1}].({2})",
     objException.Message, sbSQL.ToString(), clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsDataSynConfigEN objDataSynConfigEN, string strCondition)
{
 if (objDataSynConfigEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataSynConfigEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataSynConfig Set ");
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.TabName))
 {
 if (objDataSynConfigEN.TabName !=  null)
 {
 objDataSynConfigEN.TabName = objDataSynConfigEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabName = '{0}',", objDataSynConfigEN.TabName); //表名
 }
 else
 {
 sbSQL.Append(" TabName = null,"); //表名
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.IsSynch))
 {
 sbSQL.AppendFormat(" IsSynch = '{0}',", objDataSynConfigEN.IsSynch == true?"1":"0"); //是否同步
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynCondition))
 {
 if (objDataSynConfigEN.SynCondition !=  null)
 {
 objDataSynConfigEN.SynCondition = objDataSynConfigEN.SynCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynCondition = '{0}',", objDataSynConfigEN.SynCondition); //同步条件
 }
 else
 {
 sbSQL.Append(" SynCondition = null,"); //同步条件
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynCondition4Web))
 {
 if (objDataSynConfigEN.SynCondition4Web !=  null)
 {
 objDataSynConfigEN.SynCondition4Web = objDataSynConfigEN.SynCondition4Web.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynCondition4Web = '{0}',", objDataSynConfigEN.SynCondition4Web); //同步条件4Web
 }
 else
 {
 sbSQL.Append(" SynCondition4Web = null,"); //同步条件4Web
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchCycle))
 {
 if (objDataSynConfigEN.SynchCycle !=  null)
 {
 objDataSynConfigEN.SynchCycle = objDataSynConfigEN.SynchCycle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchCycle = '{0}',", objDataSynConfigEN.SynchCycle); //同步周期
 }
 else
 {
 sbSQL.Append(" SynchCycle = null,"); //同步周期
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchDate))
 {
 if (objDataSynConfigEN.SynchDate !=  null)
 {
 objDataSynConfigEN.SynchDate = objDataSynConfigEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchDate = '{0}',", objDataSynConfigEN.SynchDate); //同步日期
 }
 else
 {
 sbSQL.Append(" SynchDate = null,"); //同步日期
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchTime))
 {
 if (objDataSynConfigEN.SynchTime !=  null)
 {
 objDataSynConfigEN.SynchTime = objDataSynConfigEN.SynchTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchTime = '{0}',", objDataSynConfigEN.SynchTime); //同步时间
 }
 else
 {
 sbSQL.Append(" SynchTime = null,"); //同步时间
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SenderUser))
 {
 if (objDataSynConfigEN.SenderUser !=  null)
 {
 objDataSynConfigEN.SenderUser = objDataSynConfigEN.SenderUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SenderUser = '{0}',", objDataSynConfigEN.SenderUser); //发送邮件用户
 }
 else
 {
 sbSQL.Append(" SenderUser = null,"); //发送邮件用户
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SenderPwd))
 {
 if (objDataSynConfigEN.SenderPwd !=  null)
 {
 objDataSynConfigEN.SenderPwd = objDataSynConfigEN.SenderPwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SenderPwd = '{0}',", objDataSynConfigEN.SenderPwd); //发送邮件口令
 }
 else
 {
 sbSQL.Append(" SenderPwd = null,"); //发送邮件口令
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.smtp))
 {
 if (objDataSynConfigEN.smtp !=  null)
 {
 objDataSynConfigEN.smtp = objDataSynConfigEN.smtp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" smtp = '{0}',", objDataSynConfigEN.smtp); //发送邮件服务器
 }
 else
 {
 sbSQL.Append(" smtp = null,"); //发送邮件服务器
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.Receiver))
 {
 if (objDataSynConfigEN.Receiver !=  null)
 {
 objDataSynConfigEN.Receiver = objDataSynConfigEN.Receiver.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Receiver = '{0}',", objDataSynConfigEN.Receiver); //接收者
 }
 else
 {
 sbSQL.Append(" Receiver = null,"); //接收者
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.lastMailDate))
 {
 if (objDataSynConfigEN.lastMailDate !=  null)
 {
 objDataSynConfigEN.lastMailDate = objDataSynConfigEN.lastMailDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" lastMailDate = '{0}',", objDataSynConfigEN.lastMailDate); //最后发邮件日期
 }
 else
 {
 sbSQL.Append(" lastMailDate = null,"); //最后发邮件日期
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.lastExecuteDate))
 {
 if (objDataSynConfigEN.lastExecuteDate !=  null)
 {
 objDataSynConfigEN.lastExecuteDate = objDataSynConfigEN.lastExecuteDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" lastExecuteDate = '{0}',", objDataSynConfigEN.lastExecuteDate); //最后执行日期
 }
 else
 {
 sbSQL.Append(" lastExecuteDate = null,"); //最后执行日期
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchStartTime))
 {
 if (objDataSynConfigEN.SynchStartTime !=  null)
 {
 objDataSynConfigEN.SynchStartTime = objDataSynConfigEN.SynchStartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchStartTime = '{0}',", objDataSynConfigEN.SynchStartTime); //同步开始时间
 }
 else
 {
 sbSQL.Append(" SynchStartTime = null,"); //同步开始时间
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchEndTime))
 {
 if (objDataSynConfigEN.SynchEndTime !=  null)
 {
 objDataSynConfigEN.SynchEndTime = objDataSynConfigEN.SynchEndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchEndTime = '{0}',", objDataSynConfigEN.SynchEndTime); //同步结束时间
 }
 else
 {
 sbSQL.Append(" SynchEndTime = null,"); //同步结束时间
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objDataSynConfigEN.OrderNum); //序号
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.Memo))
 {
 if (objDataSynConfigEN.Memo !=  null)
 {
 objDataSynConfigEN.Memo = objDataSynConfigEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objDataSynConfigEN.Memo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式,根据条件修改记录.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithConditionTransaction)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsDataSynConfigEN objDataSynConfigEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objDataSynConfigEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataSynConfigEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataSynConfig Set ");
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.TabName))
 {
 if (objDataSynConfigEN.TabName !=  null)
 {
 objDataSynConfigEN.TabName = objDataSynConfigEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabName = '{0}',", objDataSynConfigEN.TabName); //表名
 }
 else
 {
 sbSQL.Append(" TabName = null,"); //表名
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.IsSynch))
 {
 sbSQL.AppendFormat(" IsSynch = '{0}',", objDataSynConfigEN.IsSynch == true?"1":"0"); //是否同步
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynCondition))
 {
 if (objDataSynConfigEN.SynCondition !=  null)
 {
 objDataSynConfigEN.SynCondition = objDataSynConfigEN.SynCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynCondition = '{0}',", objDataSynConfigEN.SynCondition); //同步条件
 }
 else
 {
 sbSQL.Append(" SynCondition = null,"); //同步条件
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynCondition4Web))
 {
 if (objDataSynConfigEN.SynCondition4Web !=  null)
 {
 objDataSynConfigEN.SynCondition4Web = objDataSynConfigEN.SynCondition4Web.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynCondition4Web = '{0}',", objDataSynConfigEN.SynCondition4Web); //同步条件4Web
 }
 else
 {
 sbSQL.Append(" SynCondition4Web = null,"); //同步条件4Web
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchCycle))
 {
 if (objDataSynConfigEN.SynchCycle !=  null)
 {
 objDataSynConfigEN.SynchCycle = objDataSynConfigEN.SynchCycle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchCycle = '{0}',", objDataSynConfigEN.SynchCycle); //同步周期
 }
 else
 {
 sbSQL.Append(" SynchCycle = null,"); //同步周期
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchDate))
 {
 if (objDataSynConfigEN.SynchDate !=  null)
 {
 objDataSynConfigEN.SynchDate = objDataSynConfigEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchDate = '{0}',", objDataSynConfigEN.SynchDate); //同步日期
 }
 else
 {
 sbSQL.Append(" SynchDate = null,"); //同步日期
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchTime))
 {
 if (objDataSynConfigEN.SynchTime !=  null)
 {
 objDataSynConfigEN.SynchTime = objDataSynConfigEN.SynchTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchTime = '{0}',", objDataSynConfigEN.SynchTime); //同步时间
 }
 else
 {
 sbSQL.Append(" SynchTime = null,"); //同步时间
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SenderUser))
 {
 if (objDataSynConfigEN.SenderUser !=  null)
 {
 objDataSynConfigEN.SenderUser = objDataSynConfigEN.SenderUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SenderUser = '{0}',", objDataSynConfigEN.SenderUser); //发送邮件用户
 }
 else
 {
 sbSQL.Append(" SenderUser = null,"); //发送邮件用户
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SenderPwd))
 {
 if (objDataSynConfigEN.SenderPwd !=  null)
 {
 objDataSynConfigEN.SenderPwd = objDataSynConfigEN.SenderPwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SenderPwd = '{0}',", objDataSynConfigEN.SenderPwd); //发送邮件口令
 }
 else
 {
 sbSQL.Append(" SenderPwd = null,"); //发送邮件口令
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.smtp))
 {
 if (objDataSynConfigEN.smtp !=  null)
 {
 objDataSynConfigEN.smtp = objDataSynConfigEN.smtp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" smtp = '{0}',", objDataSynConfigEN.smtp); //发送邮件服务器
 }
 else
 {
 sbSQL.Append(" smtp = null,"); //发送邮件服务器
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.Receiver))
 {
 if (objDataSynConfigEN.Receiver !=  null)
 {
 objDataSynConfigEN.Receiver = objDataSynConfigEN.Receiver.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Receiver = '{0}',", objDataSynConfigEN.Receiver); //接收者
 }
 else
 {
 sbSQL.Append(" Receiver = null,"); //接收者
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.lastMailDate))
 {
 if (objDataSynConfigEN.lastMailDate !=  null)
 {
 objDataSynConfigEN.lastMailDate = objDataSynConfigEN.lastMailDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" lastMailDate = '{0}',", objDataSynConfigEN.lastMailDate); //最后发邮件日期
 }
 else
 {
 sbSQL.Append(" lastMailDate = null,"); //最后发邮件日期
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.lastExecuteDate))
 {
 if (objDataSynConfigEN.lastExecuteDate !=  null)
 {
 objDataSynConfigEN.lastExecuteDate = objDataSynConfigEN.lastExecuteDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" lastExecuteDate = '{0}',", objDataSynConfigEN.lastExecuteDate); //最后执行日期
 }
 else
 {
 sbSQL.Append(" lastExecuteDate = null,"); //最后执行日期
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchStartTime))
 {
 if (objDataSynConfigEN.SynchStartTime !=  null)
 {
 objDataSynConfigEN.SynchStartTime = objDataSynConfigEN.SynchStartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchStartTime = '{0}',", objDataSynConfigEN.SynchStartTime); //同步开始时间
 }
 else
 {
 sbSQL.Append(" SynchStartTime = null,"); //同步开始时间
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchEndTime))
 {
 if (objDataSynConfigEN.SynchEndTime !=  null)
 {
 objDataSynConfigEN.SynchEndTime = objDataSynConfigEN.SynchEndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchEndTime = '{0}',", objDataSynConfigEN.SynchEndTime); //同步结束时间
 }
 else
 {
 sbSQL.Append(" SynchEndTime = null,"); //同步结束时间
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objDataSynConfigEN.OrderNum); //序号
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.Memo))
 {
 if (objDataSynConfigEN.Memo !=  null)
 {
 objDataSynConfigEN.Memo = objDataSynConfigEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objDataSynConfigEN.Memo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithTransaction2)
 /// </summary>
 /// <param name = "objDataSynConfigEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDataSynConfigEN objDataSynConfigEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objDataSynConfigEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataSynConfigEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataSynConfig Set ");
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.TabName))
 {
 if (objDataSynConfigEN.TabName !=  null)
 {
 objDataSynConfigEN.TabName = objDataSynConfigEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.TabName, conDataSynConfig.TabName); //表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.TabName); //表名
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.IsSynch))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataSynConfigEN.IsSynch == true?"1":"0", conDataSynConfig.IsSynch); //是否同步
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynCondition))
 {
 if (objDataSynConfigEN.SynCondition !=  null)
 {
 objDataSynConfigEN.SynCondition = objDataSynConfigEN.SynCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.SynCondition, conDataSynConfig.SynCondition); //同步条件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.SynCondition); //同步条件
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynCondition4Web))
 {
 if (objDataSynConfigEN.SynCondition4Web !=  null)
 {
 objDataSynConfigEN.SynCondition4Web = objDataSynConfigEN.SynCondition4Web.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.SynCondition4Web, conDataSynConfig.SynCondition4Web); //同步条件4Web
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.SynCondition4Web); //同步条件4Web
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchCycle))
 {
 if (objDataSynConfigEN.SynchCycle !=  null)
 {
 objDataSynConfigEN.SynchCycle = objDataSynConfigEN.SynchCycle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.SynchCycle, conDataSynConfig.SynchCycle); //同步周期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.SynchCycle); //同步周期
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchDate))
 {
 if (objDataSynConfigEN.SynchDate !=  null)
 {
 objDataSynConfigEN.SynchDate = objDataSynConfigEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.SynchDate, conDataSynConfig.SynchDate); //同步日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.SynchDate); //同步日期
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchTime))
 {
 if (objDataSynConfigEN.SynchTime !=  null)
 {
 objDataSynConfigEN.SynchTime = objDataSynConfigEN.SynchTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.SynchTime, conDataSynConfig.SynchTime); //同步时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.SynchTime); //同步时间
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SenderUser))
 {
 if (objDataSynConfigEN.SenderUser !=  null)
 {
 objDataSynConfigEN.SenderUser = objDataSynConfigEN.SenderUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.SenderUser, conDataSynConfig.SenderUser); //发送邮件用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.SenderUser); //发送邮件用户
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SenderPwd))
 {
 if (objDataSynConfigEN.SenderPwd !=  null)
 {
 objDataSynConfigEN.SenderPwd = objDataSynConfigEN.SenderPwd.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.SenderPwd, conDataSynConfig.SenderPwd); //发送邮件口令
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.SenderPwd); //发送邮件口令
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.smtp))
 {
 if (objDataSynConfigEN.smtp !=  null)
 {
 objDataSynConfigEN.smtp = objDataSynConfigEN.smtp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.smtp, conDataSynConfig.smtp); //发送邮件服务器
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.smtp); //发送邮件服务器
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.Receiver))
 {
 if (objDataSynConfigEN.Receiver !=  null)
 {
 objDataSynConfigEN.Receiver = objDataSynConfigEN.Receiver.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.Receiver, conDataSynConfig.Receiver); //接收者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.Receiver); //接收者
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.lastMailDate))
 {
 if (objDataSynConfigEN.lastMailDate !=  null)
 {
 objDataSynConfigEN.lastMailDate = objDataSynConfigEN.lastMailDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.lastMailDate, conDataSynConfig.lastMailDate); //最后发邮件日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.lastMailDate); //最后发邮件日期
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.lastExecuteDate))
 {
 if (objDataSynConfigEN.lastExecuteDate !=  null)
 {
 objDataSynConfigEN.lastExecuteDate = objDataSynConfigEN.lastExecuteDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.lastExecuteDate, conDataSynConfig.lastExecuteDate); //最后执行日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.lastExecuteDate); //最后执行日期
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchStartTime))
 {
 if (objDataSynConfigEN.SynchStartTime !=  null)
 {
 objDataSynConfigEN.SynchStartTime = objDataSynConfigEN.SynchStartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.SynchStartTime, conDataSynConfig.SynchStartTime); //同步开始时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.SynchStartTime); //同步开始时间
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.SynchEndTime))
 {
 if (objDataSynConfigEN.SynchEndTime !=  null)
 {
 objDataSynConfigEN.SynchEndTime = objDataSynConfigEN.SynchEndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.SynchEndTime, conDataSynConfig.SynchEndTime); //同步结束时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.SynchEndTime); //同步结束时间
 }
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objDataSynConfigEN.OrderNum, conDataSynConfig.OrderNum); //序号
 }
 
 if (objDataSynConfigEN.IsUpdated(conDataSynConfig.Memo))
 {
 if (objDataSynConfigEN.Memo !=  null)
 {
 objDataSynConfigEN.Memo = objDataSynConfigEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objDataSynConfigEN.Memo, conDataSynConfig.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataSynConfig.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objDataSynConfigEN.mId); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 #endregion 修改记录

 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.DALCode4CSharp:GenDelRecordBySP)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("DataSynConfig_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
//删除DataSynConfig本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataSynConfig where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelDataSynConfig(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除DataSynConfig本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataSynConfig where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
//删除DataSynConfig本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataSynConfig where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelDataSynConfig(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsDataSynConfigDA: DelDataSynConfig)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DataSynConfig where " + strCondition ;
}
int intRecoCount = objSQL.ExecSql2(strSQL);
return intRecoCount;
}



 /// <summary>
 /// 功能:删除满足条件的多条记录,同时处理事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRecWithTransaction)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public bool DelDataSynConfigWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsDataSynConfigDA: DelDataSynConfigWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DataSynConfig where " + strCondition ;
}
 bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
return bolResult;
}


 #endregion 删除记录

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objDataSynConfigENS">源对象</param>
 /// <param name = "objDataSynConfigENT">目标对象</param>
public void CopyTo(clsDataSynConfigEN objDataSynConfigENS, clsDataSynConfigEN objDataSynConfigENT)
{
objDataSynConfigENT.mId = objDataSynConfigENS.mId; //mId
objDataSynConfigENT.TabName = objDataSynConfigENS.TabName; //表名
objDataSynConfigENT.IsSynch = objDataSynConfigENS.IsSynch; //是否同步
objDataSynConfigENT.SynCondition = objDataSynConfigENS.SynCondition; //同步条件
objDataSynConfigENT.SynCondition4Web = objDataSynConfigENS.SynCondition4Web; //同步条件4Web
objDataSynConfigENT.SynchCycle = objDataSynConfigENS.SynchCycle; //同步周期
objDataSynConfigENT.SynchDate = objDataSynConfigENS.SynchDate; //同步日期
objDataSynConfigENT.SynchTime = objDataSynConfigENS.SynchTime; //同步时间
objDataSynConfigENT.SenderUser = objDataSynConfigENS.SenderUser; //发送邮件用户
objDataSynConfigENT.SenderPwd = objDataSynConfigENS.SenderPwd; //发送邮件口令
objDataSynConfigENT.smtp = objDataSynConfigENS.smtp; //发送邮件服务器
objDataSynConfigENT.Receiver = objDataSynConfigENS.Receiver; //接收者
objDataSynConfigENT.lastMailDate = objDataSynConfigENS.lastMailDate; //最后发邮件日期
objDataSynConfigENT.lastExecuteDate = objDataSynConfigENS.lastExecuteDate; //最后执行日期
objDataSynConfigENT.SynchStartTime = objDataSynConfigENS.SynchStartTime; //同步开始时间
objDataSynConfigENT.SynchEndTime = objDataSynConfigENS.SynchEndTime; //同步结束时间
objDataSynConfigENT.OrderNum = objDataSynConfigENS.OrderNum; //序号
objDataSynConfigENT.Memo = objDataSynConfigENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDataSynConfigEN objDataSynConfigEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objDataSynConfigEN.IsSynch, conDataSynConfig.IsSynch);
clsCheckSql.CheckFieldNotNull(objDataSynConfigEN.SynCondition, conDataSynConfig.SynCondition);
clsCheckSql.CheckFieldNotNull(objDataSynConfigEN.SynchCycle, conDataSynConfig.SynchCycle);
clsCheckSql.CheckFieldNotNull(objDataSynConfigEN.SynchDate, conDataSynConfig.SynchDate);
clsCheckSql.CheckFieldNotNull(objDataSynConfigEN.SynchTime, conDataSynConfig.SynchTime);
clsCheckSql.CheckFieldNotNull(objDataSynConfigEN.OrderNum, conDataSynConfig.OrderNum);
//检查字段长度
clsCheckSql.CheckFieldLen(objDataSynConfigEN.TabName, 100, conDataSynConfig.TabName);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynCondition, 5000, conDataSynConfig.SynCondition);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynCondition4Web, 5000, conDataSynConfig.SynCondition4Web);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynchCycle, 30, conDataSynConfig.SynchCycle);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynchDate, 30, conDataSynConfig.SynchDate);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynchTime, 30, conDataSynConfig.SynchTime);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SenderUser, 30, conDataSynConfig.SenderUser);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SenderPwd, 30, conDataSynConfig.SenderPwd);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.smtp, 50, conDataSynConfig.smtp);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.Receiver, 50, conDataSynConfig.Receiver);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.lastMailDate, 50, conDataSynConfig.lastMailDate);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.lastExecuteDate, 50, conDataSynConfig.lastExecuteDate);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynchStartTime, 14, conDataSynConfig.SynchStartTime);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynchEndTime, 14, conDataSynConfig.SynchEndTime);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.Memo, 1000, conDataSynConfig.Memo);
//检查字段外键固定长度
 objDataSynConfigEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsDataSynConfigEN objDataSynConfigEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDataSynConfigEN.TabName, 100, conDataSynConfig.TabName);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynCondition, 5000, conDataSynConfig.SynCondition);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynCondition4Web, 5000, conDataSynConfig.SynCondition4Web);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynchCycle, 30, conDataSynConfig.SynchCycle);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynchDate, 30, conDataSynConfig.SynchDate);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynchTime, 30, conDataSynConfig.SynchTime);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SenderUser, 30, conDataSynConfig.SenderUser);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SenderPwd, 30, conDataSynConfig.SenderPwd);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.smtp, 50, conDataSynConfig.smtp);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.Receiver, 50, conDataSynConfig.Receiver);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.lastMailDate, 50, conDataSynConfig.lastMailDate);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.lastExecuteDate, 50, conDataSynConfig.lastExecuteDate);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynchStartTime, 14, conDataSynConfig.SynchStartTime);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynchEndTime, 14, conDataSynConfig.SynchEndTime);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.Memo, 1000, conDataSynConfig.Memo);
//检查外键字段长度
 objDataSynConfigEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsDataSynConfigEN objDataSynConfigEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDataSynConfigEN.TabName, 100, conDataSynConfig.TabName);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynCondition, 5000, conDataSynConfig.SynCondition);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynCondition4Web, 5000, conDataSynConfig.SynCondition4Web);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynchCycle, 30, conDataSynConfig.SynchCycle);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynchDate, 30, conDataSynConfig.SynchDate);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynchTime, 30, conDataSynConfig.SynchTime);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SenderUser, 30, conDataSynConfig.SenderUser);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SenderPwd, 30, conDataSynConfig.SenderPwd);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.smtp, 50, conDataSynConfig.smtp);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.Receiver, 50, conDataSynConfig.Receiver);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.lastMailDate, 50, conDataSynConfig.lastMailDate);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.lastExecuteDate, 50, conDataSynConfig.lastExecuteDate);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynchStartTime, 14, conDataSynConfig.SynchStartTime);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.SynchEndTime, 14, conDataSynConfig.SynchEndTime);
clsCheckSql.CheckFieldLen(objDataSynConfigEN.Memo, 1000, conDataSynConfig.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objDataSynConfigEN.TabName, conDataSynConfig.TabName);
clsCheckSql.CheckSqlInjection4Field(objDataSynConfigEN.SynCondition, conDataSynConfig.SynCondition);
clsCheckSql.CheckSqlInjection4Field(objDataSynConfigEN.SynCondition4Web, conDataSynConfig.SynCondition4Web);
clsCheckSql.CheckSqlInjection4Field(objDataSynConfigEN.SynchCycle, conDataSynConfig.SynchCycle);
clsCheckSql.CheckSqlInjection4Field(objDataSynConfigEN.SynchDate, conDataSynConfig.SynchDate);
clsCheckSql.CheckSqlInjection4Field(objDataSynConfigEN.SynchTime, conDataSynConfig.SynchTime);
clsCheckSql.CheckSqlInjection4Field(objDataSynConfigEN.SenderUser, conDataSynConfig.SenderUser);
clsCheckSql.CheckSqlInjection4Field(objDataSynConfigEN.SenderPwd, conDataSynConfig.SenderPwd);
clsCheckSql.CheckSqlInjection4Field(objDataSynConfigEN.smtp, conDataSynConfig.smtp);
clsCheckSql.CheckSqlInjection4Field(objDataSynConfigEN.Receiver, conDataSynConfig.Receiver);
clsCheckSql.CheckSqlInjection4Field(objDataSynConfigEN.lastMailDate, conDataSynConfig.lastMailDate);
clsCheckSql.CheckSqlInjection4Field(objDataSynConfigEN.lastExecuteDate, conDataSynConfig.lastExecuteDate);
clsCheckSql.CheckSqlInjection4Field(objDataSynConfigEN.SynchStartTime, conDataSynConfig.SynchStartTime);
clsCheckSql.CheckSqlInjection4Field(objDataSynConfigEN.SynchEndTime, conDataSynConfig.SynchEndTime);
clsCheckSql.CheckSqlInjection4Field(objDataSynConfigEN.Memo, conDataSynConfig.Memo);
//检查外键字段长度
 objDataSynConfigEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--DataSynConfig(同步配置),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDataSynConfigEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStrTabName(clsDataSynConfigEN objDataSynConfigEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objDataSynConfigEN.TabName == null)
{
 sbCondition.AppendFormat(" and TabName is null");
}
else
{
 sbCondition.AppendFormat(" and TabName = '{0}'", objDataSynConfigEN.TabName);
}
return sbCondition.ToString();
}

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
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
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
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
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
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDataSynConfigEN._CurrTabName);
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
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDataSynConfigEN._CurrTabName, strCondition);
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
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.DALCode4CSharp:GenfunSetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "varValue">值</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue<T>(string strTabName, string strFldName, T varValue, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataSynConfigDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}