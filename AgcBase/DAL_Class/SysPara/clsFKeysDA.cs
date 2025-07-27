
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFKeysDA
 表名:FKeys(00050237)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:14:19
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
 /// 表外键(FKeys)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsFKeysDA : clsCommBase4DA
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
 return clsFKeysEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFKeysEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFKeysEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFKeysEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFKeysEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
 strSQL = "Select * from FKeys where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "FKeys");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("FKeys_SelectByCond",values, "FKeys");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FKeys where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "FKeys");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFKeysDA: GetFKeysByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFKeysDA: GetFKeysByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFKeysDA: GetFKeysByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from FKeys a where {0} And a.Id not in (Select Top {2} Id From FKeys Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "FKeys");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFKeysDA: GetFKeysByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFKeysDA: GetFKeysByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFKeysDA: GetFKeysByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from FKeys a where {0} And a.Id not in (Select Top {2} Id From FKeys Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "FKeys");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFKeysDA: GetFKeysByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFKeysDA: GetFKeysByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFKeysDA: GetFKeysByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from FKeys a where {0} And a.Id not in (Select Top {2} Id From FKeys Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "FKeys");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
strSQL = "Select * from FKeys where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FKeys(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataTable_FKeys)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
strSQL = "Select * from FKeys where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
strSQL = "Select * from FKeys where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
strSQL = "Select * from FKeys where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FKeys where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FKeys where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FKeys where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FKeys where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFKeysDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FKeys.* from FKeys Left Join {1} on {2} where {3} and FKeys.Id not in (Select top {5} FKeys.Id from FKeys Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FKeys where {1} and Id not in (Select top {2} Id from FKeys where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FKeys where {1} and Id not in (Select top {3} Id from FKeys where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFKeysDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FKeys.* from FKeys Left Join {1} on {2} where {3} and FKeys.Id not in (Select top {5} FKeys.Id from FKeys Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FKeys where {1} and Id not in (Select top {2} Id from FKeys where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FKeys where {1} and Id not in (Select top {3} Id from FKeys where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsFKeysDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FKeys.* from FKeys Left Join {1} on {2} where {3} and FKeys.Id not in (Select top {5} FKeys.Id from FKeys Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FKeys where {1} and Id not in (Select top {2} Id from FKeys where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FKeys where {1} and Id not in (Select top {3} Id from FKeys where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFKeysDA: GetFKeysByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFKeysDA: GetFKeysByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFKeysDA: GetFKeysByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from FKeys a where {0} And a.Id not in (Select Top {2} Id From FKeys Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from FKeys a where {0} And a.Id not in (Select Top {2} Id From FKeys Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFKeysDA: GetFKeysByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFKeysDA: GetFKeysByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFKeysDA: GetFKeysByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from FKeys a where {0} And a.Id not in (Select Top {2} Id From FKeys Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from FKeys a where {0} And a.Id not in (Select Top {2} Id From FKeys Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFKeysDA: GetFKeysByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFKeysDA: GetFKeysByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFKeysDA: GetFKeysByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
strSQL = "Select * from FKeys where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsFKeysDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("FKeys_SelectByCond",values);
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
public List<clsFKeysEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFKeysDA:GetObjLst)", objException.Message));
}
List<clsFKeysEN> arrObjLst = new List<clsFKeysEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
strSQL = "Select * from FKeys where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFKeysEN objFKeysEN = new clsFKeysEN();
try
{
objFKeysEN.Id = TransNullToInt(objRow[conFKeys.Id].ToString().Trim()); //对象Id
objFKeysEN.FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(); //外键名称
objFKeysEN.FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id
objFKeysEN.FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名
objFKeysEN.FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID
objFKeysEN.FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称
objFKeysEN.PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID
objFKeysEN.PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名
objFKeysEN.PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id
objFKeysEN.PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名
objFKeysEN.Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(); //级联更新
objFKeysEN.Delete_Action = TransNullToInt(objRow[conFKeys.Delete_Action].ToString().Trim()); //级联删除
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFKeysDA: GetObjLst)", objException.Message));
}
objFKeysEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFKeysEN);
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
public List<clsFKeysEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFKeysDA:GetObjLstByTabName)", objException.Message));
}
List<clsFKeysEN> arrObjLst = new List<clsFKeysEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFKeysEN objFKeysEN = new clsFKeysEN();
try
{
objFKeysEN.Id = TransNullToInt(objRow[conFKeys.Id].ToString().Trim()); //对象Id
objFKeysEN.FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(); //外键名称
objFKeysEN.FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id
objFKeysEN.FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名
objFKeysEN.FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID
objFKeysEN.FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称
objFKeysEN.PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID
objFKeysEN.PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名
objFKeysEN.PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id
objFKeysEN.PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名
objFKeysEN.Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(); //级联更新
objFKeysEN.Delete_Action = TransNullToInt(objRow[conFKeys.Delete_Action].ToString().Trim()); //级联删除
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFKeysDA: GetObjLst)", objException.Message));
}
objFKeysEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFKeysEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsFKeysEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsFKeysDA:GetObjLstBySP)", objException.Message));
}
List<clsFKeysEN> arrObjLst = new List<clsFKeysEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("FKeys_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFKeysEN objFKeysEN = new clsFKeysEN();
try
{
objFKeysEN.Id = TransNullToInt(objRow[conFKeys.Id].ToString().Trim()); //对象Id
objFKeysEN.FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(); //外键名称
objFKeysEN.FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id
objFKeysEN.FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名
objFKeysEN.FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID
objFKeysEN.FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称
objFKeysEN.PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID
objFKeysEN.PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名
objFKeysEN.PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id
objFKeysEN.PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名
objFKeysEN.Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(); //级联更新
objFKeysEN.Delete_Action = TransNullToInt(objRow[conFKeys.Delete_Action].ToString().Trim()); //级联删除
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsFKeysDA: GetObjLstBySP)", objException.Message));
}
objFKeysEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFKeysEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFKeysEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFKeys(ref clsFKeysEN objFKeysEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
strSQL = "Select * from FKeys where Id = " + ""+ objFKeysEN.Id+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFKeysEN.Id = TransNullToInt(objDT.Rows[0][conFKeys.Id].ToString().Trim()); //对象Id(字段类型:bigint,字段长度:8,是否可空:False)
 objFKeysEN.FKeyName = objDT.Rows[0][conFKeys.FKeyName].ToString().Trim(); //外键名称(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.FKeyColumnID = objDT.Rows[0][conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.FKeyColumnName = objDT.Rows[0][conFKeys.FKeyColumnName].ToString().Trim(); //外键列名(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.FKeyTabID = objDT.Rows[0][conFKeys.FKeyTabID].ToString().Trim(); //外键表ID(字段类型:varchar,字段长度:128,是否可空:True)
 objFKeysEN.FKeyTabName = objDT.Rows[0][conFKeys.FKeyTabName].ToString().Trim(); //外键表名称(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.PKeyColumnID = objDT.Rows[0][conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.PKeyColumnName = objDT.Rows[0][conFKeys.PKeyColumnName].ToString().Trim(); //主键列名(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.PKeyTabId = objDT.Rows[0][conFKeys.PKeyTabId].ToString().Trim(); //主键表Id(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.PKeyTabName = objDT.Rows[0][conFKeys.PKeyTabName].ToString().Trim(); //主键表名(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.Update_Action = objDT.Rows[0][conFKeys.Update_Action].ToString().Trim(); //级联更新(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.Delete_Action = TransNullToInt(objDT.Rows[0][conFKeys.Delete_Action].ToString().Trim()); //级联删除(字段类型:int,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFKeysDA: GetFKeys)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngId">表关键字</param>
 /// <returns>表对象</returns>
public clsFKeysEN GetObjById(long lngId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
strSQL = "Select * from FKeys where Id = " + ""+ lngId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFKeysEN objFKeysEN = new clsFKeysEN();
try
{
 objFKeysEN.Id = Int32.Parse(objRow[conFKeys.Id].ToString().Trim()); //对象Id(字段类型:bigint,字段长度:8,是否可空:False)
 objFKeysEN.FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(); //外键名称(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID(字段类型:varchar,字段长度:128,是否可空:True)
 objFKeysEN.FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(); //级联更新(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.Delete_Action = Int32.Parse(objRow[conFKeys.Delete_Action].ToString().Trim()); //级联删除(字段类型:int,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFKeysDA: GetObjById)", objException.Message));
}
return objFKeysEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程FKeys_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objFKeysEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFKeysOneBySP(clsFKeysEN objFKeysEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objFKeysEN.Id
};
 objDT = objSQL.ExecSpReturnDT("FKeys_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objFKeysEN.Id = TransNullToInt(objDT.Rows[0][conFKeys.Id].ToString().Trim()); //对象Id(字段类型:bigint,字段长度:8,是否可空:False)
 objFKeysEN.FKeyName = objDT.Rows[0][conFKeys.FKeyName].ToString().Trim(); //外键名称(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.FKeyColumnID = objDT.Rows[0][conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.FKeyColumnName = objDT.Rows[0][conFKeys.FKeyColumnName].ToString().Trim(); //外键列名(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.FKeyTabID = objDT.Rows[0][conFKeys.FKeyTabID].ToString().Trim(); //外键表ID(字段类型:varchar,字段长度:128,是否可空:True)
 objFKeysEN.FKeyTabName = objDT.Rows[0][conFKeys.FKeyTabName].ToString().Trim(); //外键表名称(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.PKeyColumnID = objDT.Rows[0][conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.PKeyColumnName = objDT.Rows[0][conFKeys.PKeyColumnName].ToString().Trim(); //主键列名(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.PKeyTabId = objDT.Rows[0][conFKeys.PKeyTabId].ToString().Trim(); //主键表Id(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.PKeyTabName = objDT.Rows[0][conFKeys.PKeyTabName].ToString().Trim(); //主键表名(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.Update_Action = objDT.Rows[0][conFKeys.Update_Action].ToString().Trim(); //级联更新(字段类型:varchar,字段长度:128,是否可空:False)
 objFKeysEN.Delete_Action = TransNullToInt(objDT.Rows[0][conFKeys.Delete_Action].ToString().Trim()); //级联删除(字段类型:int,字段长度:4,是否可空:False)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFKeysEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFKeysDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
strSQL = "Select * from FKeys where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFKeysEN objFKeysEN = new clsFKeysEN()
{
Id = TransNullToInt(objRow[conFKeys.Id].ToString().Trim()), //对象Id
FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(), //外键名称
FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(), //外键列Id
FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(), //外键列名
FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(), //外键表ID
FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(), //外键表名称
PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(), //主键列ID
PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(), //主键列名
PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(), //主键表Id
PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(), //主键表名
Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(), //级联更新
Delete_Action = TransNullToInt(objRow[conFKeys.Delete_Action].ToString().Trim()) //级联删除
};
objFKeysEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFKeysEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFKeysDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFKeysEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsFKeysDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("FKeys_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsFKeysEN objFKeysEN = new clsFKeysEN()
{
Id = TransNullToInt(objRow[conFKeys.Id].ToString().Trim()), //对象Id
FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(), //外键名称
FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(), //外键列Id
FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(), //外键列名
FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(), //外键表ID
FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(), //外键表名称
PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(), //主键列ID
PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(), //主键列名
PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(), //主键表Id
PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(), //主键表名
Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(), //级联更新
Delete_Action = TransNullToInt(objRow[conFKeys.Delete_Action].ToString().Trim()) //级联删除
};
objFKeysEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFKeysEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFKeysEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFKeysEN objFKeysEN = new clsFKeysEN();
try
{
objFKeysEN.Id = TransNullToInt(objRow[conFKeys.Id].ToString().Trim()); //对象Id
objFKeysEN.FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(); //外键名称
objFKeysEN.FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id
objFKeysEN.FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名
objFKeysEN.FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID
objFKeysEN.FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称
objFKeysEN.PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID
objFKeysEN.PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名
objFKeysEN.PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id
objFKeysEN.PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名
objFKeysEN.Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(); //级联更新
objFKeysEN.Delete_Action = TransNullToInt(objRow[conFKeys.Delete_Action].ToString().Trim()); //级联删除
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFKeysDA: GetObjByDataRowFKeys)", objException.Message));
}
objFKeysEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFKeysEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFKeysEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFKeysEN objFKeysEN = new clsFKeysEN();
try
{
objFKeysEN.Id = TransNullToInt(objRow[conFKeys.Id].ToString().Trim()); //对象Id
objFKeysEN.FKeyName = objRow[conFKeys.FKeyName].ToString().Trim(); //外键名称
objFKeysEN.FKeyColumnID = objRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id
objFKeysEN.FKeyColumnName = objRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名
objFKeysEN.FKeyTabID = objRow[conFKeys.FKeyTabID] == DBNull.Value ? null : objRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID
objFKeysEN.FKeyTabName = objRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称
objFKeysEN.PKeyColumnID = objRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID
objFKeysEN.PKeyColumnName = objRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名
objFKeysEN.PKeyTabId = objRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id
objFKeysEN.PKeyTabName = objRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名
objFKeysEN.Update_Action = objRow[conFKeys.Update_Action].ToString().Trim(); //级联更新
objFKeysEN.Delete_Action = TransNullToInt(objRow[conFKeys.Delete_Action].ToString().Trim()); //级联删除
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFKeysDA: GetObjByDataRow)", objException.Message));
}
objFKeysEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFKeysEN;
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
objSQL = clsFKeysDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFKeysEN._CurrTabName, conFKeys.Id, 8, "");
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
objSQL = clsFKeysDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFKeysEN._CurrTabName, conFKeys.Id, 8, strPrefix);
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
 objSQL = clsFKeysDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select Id from FKeys where " + strCondition;
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
 objSQL = clsFKeysDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select Id from FKeys where " + strCondition;
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
 /// <param name = "lngId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FKeys", "Id = " + ""+ lngId+""))
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
 /// <param name = "lngId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(long lngId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("FKeys_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFKeysDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FKeys", strCondition))
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
objSQL = clsFKeysDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FKeys");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFKeysEN objFKeysEN)
 {
 if (objFKeysEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFKeysEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
strSQL = "Select * from FKeys where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FKeys");
objRow = objDS.Tables["FKeys"].NewRow();
objRow[conFKeys.FKeyName] = objFKeysEN.FKeyName; //外键名称
objRow[conFKeys.FKeyColumnID] = objFKeysEN.FKeyColumnID; //外键列Id
objRow[conFKeys.FKeyColumnName] = objFKeysEN.FKeyColumnName; //外键列名
 if (objFKeysEN.FKeyTabID !=  "")
 {
objRow[conFKeys.FKeyTabID] = objFKeysEN.FKeyTabID; //外键表ID
 }
objRow[conFKeys.FKeyTabName] = objFKeysEN.FKeyTabName; //外键表名称
objRow[conFKeys.PKeyColumnID] = objFKeysEN.PKeyColumnID; //主键列ID
objRow[conFKeys.PKeyColumnName] = objFKeysEN.PKeyColumnName; //主键列名
objRow[conFKeys.PKeyTabId] = objFKeysEN.PKeyTabId; //主键表Id
objRow[conFKeys.PKeyTabName] = objFKeysEN.PKeyTabName; //主键表名
objRow[conFKeys.Update_Action] = objFKeysEN.Update_Action; //级联更新
objRow[conFKeys.Delete_Action] = objFKeysEN.Delete_Action; //级联删除
objDS.Tables[clsFKeysEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFKeysEN._CurrTabName);
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
 /// <param name = "objFKeysEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFKeysEN objFKeysEN)
{
 if (objFKeysEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFKeysEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFKeysEN.FKeyName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyName);
 objFKeysEN.FKeyName = objFKeysEN.FKeyName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyName + "'");
 }
 
 if (objFKeysEN.FKeyColumnID !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyColumnID);
 objFKeysEN.FKeyColumnID = objFKeysEN.FKeyColumnID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyColumnID + "'");
 }
 
 if (objFKeysEN.FKeyColumnName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyColumnName);
 objFKeysEN.FKeyColumnName = objFKeysEN.FKeyColumnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyColumnName + "'");
 }
 
 if (objFKeysEN.FKeyTabID !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyTabID);
 objFKeysEN.FKeyTabID = objFKeysEN.FKeyTabID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyTabID + "'");
 }
 
 if (objFKeysEN.FKeyTabName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyTabName);
 objFKeysEN.FKeyTabName = objFKeysEN.FKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyTabName + "'");
 }
 
 if (objFKeysEN.PKeyColumnID !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.PKeyColumnID);
 objFKeysEN.PKeyColumnID = objFKeysEN.PKeyColumnID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.PKeyColumnID + "'");
 }
 
 if (objFKeysEN.PKeyColumnName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.PKeyColumnName);
 objFKeysEN.PKeyColumnName = objFKeysEN.PKeyColumnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.PKeyColumnName + "'");
 }
 
 if (objFKeysEN.PKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.PKeyTabId);
 objFKeysEN.PKeyTabId = objFKeysEN.PKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.PKeyTabId + "'");
 }
 
 if (objFKeysEN.PKeyTabName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.PKeyTabName);
 objFKeysEN.PKeyTabName = objFKeysEN.PKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.PKeyTabName + "'");
 }
 
 if (objFKeysEN.Update_Action !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.Update_Action);
 objFKeysEN.Update_Action = objFKeysEN.Update_Action.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.Update_Action + "'");
 }
 
 arrFieldListForInsert.Add(conFKeys.Delete_Action);
 arrValueListForInsert.Add(objFKeysEN.Delete_Action.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FKeys");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFKeysEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFKeysEN objFKeysEN)
{
 if (objFKeysEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFKeysEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFKeysEN.FKeyName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyName);
 objFKeysEN.FKeyName = objFKeysEN.FKeyName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyName + "'");
 }
 
 if (objFKeysEN.FKeyColumnID !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyColumnID);
 objFKeysEN.FKeyColumnID = objFKeysEN.FKeyColumnID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyColumnID + "'");
 }
 
 if (objFKeysEN.FKeyColumnName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyColumnName);
 objFKeysEN.FKeyColumnName = objFKeysEN.FKeyColumnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyColumnName + "'");
 }
 
 if (objFKeysEN.FKeyTabID !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyTabID);
 objFKeysEN.FKeyTabID = objFKeysEN.FKeyTabID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyTabID + "'");
 }
 
 if (objFKeysEN.FKeyTabName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyTabName);
 objFKeysEN.FKeyTabName = objFKeysEN.FKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyTabName + "'");
 }
 
 if (objFKeysEN.PKeyColumnID !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.PKeyColumnID);
 objFKeysEN.PKeyColumnID = objFKeysEN.PKeyColumnID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.PKeyColumnID + "'");
 }
 
 if (objFKeysEN.PKeyColumnName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.PKeyColumnName);
 objFKeysEN.PKeyColumnName = objFKeysEN.PKeyColumnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.PKeyColumnName + "'");
 }
 
 if (objFKeysEN.PKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.PKeyTabId);
 objFKeysEN.PKeyTabId = objFKeysEN.PKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.PKeyTabId + "'");
 }
 
 if (objFKeysEN.PKeyTabName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.PKeyTabName);
 objFKeysEN.PKeyTabName = objFKeysEN.PKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.PKeyTabName + "'");
 }
 
 if (objFKeysEN.Update_Action !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.Update_Action);
 objFKeysEN.Update_Action = objFKeysEN.Update_Action.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.Update_Action + "'");
 }
 
 arrFieldListForInsert.Add(conFKeys.Delete_Action);
 arrValueListForInsert.Add(objFKeysEN.Delete_Action.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FKeys");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFKeysEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFKeysEN objFKeysEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFKeysEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFKeysEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFKeysEN.FKeyName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyName);
 objFKeysEN.FKeyName = objFKeysEN.FKeyName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyName + "'");
 }
 
 if (objFKeysEN.FKeyColumnID !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyColumnID);
 objFKeysEN.FKeyColumnID = objFKeysEN.FKeyColumnID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyColumnID + "'");
 }
 
 if (objFKeysEN.FKeyColumnName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyColumnName);
 objFKeysEN.FKeyColumnName = objFKeysEN.FKeyColumnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyColumnName + "'");
 }
 
 if (objFKeysEN.FKeyTabID !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyTabID);
 objFKeysEN.FKeyTabID = objFKeysEN.FKeyTabID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyTabID + "'");
 }
 
 if (objFKeysEN.FKeyTabName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyTabName);
 objFKeysEN.FKeyTabName = objFKeysEN.FKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyTabName + "'");
 }
 
 if (objFKeysEN.PKeyColumnID !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.PKeyColumnID);
 objFKeysEN.PKeyColumnID = objFKeysEN.PKeyColumnID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.PKeyColumnID + "'");
 }
 
 if (objFKeysEN.PKeyColumnName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.PKeyColumnName);
 objFKeysEN.PKeyColumnName = objFKeysEN.PKeyColumnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.PKeyColumnName + "'");
 }
 
 if (objFKeysEN.PKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.PKeyTabId);
 objFKeysEN.PKeyTabId = objFKeysEN.PKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.PKeyTabId + "'");
 }
 
 if (objFKeysEN.PKeyTabName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.PKeyTabName);
 objFKeysEN.PKeyTabName = objFKeysEN.PKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.PKeyTabName + "'");
 }
 
 if (objFKeysEN.Update_Action !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.Update_Action);
 objFKeysEN.Update_Action = objFKeysEN.Update_Action.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.Update_Action + "'");
 }
 
 arrFieldListForInsert.Add(conFKeys.Delete_Action);
 arrValueListForInsert.Add(objFKeysEN.Delete_Action.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FKeys");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFKeysEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFKeysEN objFKeysEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objFKeysEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFKeysEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFKeysEN.FKeyName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyName);
 objFKeysEN.FKeyName = objFKeysEN.FKeyName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyName + "'");
 }
 
 if (objFKeysEN.FKeyColumnID !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyColumnID);
 objFKeysEN.FKeyColumnID = objFKeysEN.FKeyColumnID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyColumnID + "'");
 }
 
 if (objFKeysEN.FKeyColumnName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyColumnName);
 objFKeysEN.FKeyColumnName = objFKeysEN.FKeyColumnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyColumnName + "'");
 }
 
 if (objFKeysEN.FKeyTabID !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyTabID);
 objFKeysEN.FKeyTabID = objFKeysEN.FKeyTabID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyTabID + "'");
 }
 
 if (objFKeysEN.FKeyTabName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.FKeyTabName);
 objFKeysEN.FKeyTabName = objFKeysEN.FKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.FKeyTabName + "'");
 }
 
 if (objFKeysEN.PKeyColumnID !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.PKeyColumnID);
 objFKeysEN.PKeyColumnID = objFKeysEN.PKeyColumnID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.PKeyColumnID + "'");
 }
 
 if (objFKeysEN.PKeyColumnName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.PKeyColumnName);
 objFKeysEN.PKeyColumnName = objFKeysEN.PKeyColumnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.PKeyColumnName + "'");
 }
 
 if (objFKeysEN.PKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.PKeyTabId);
 objFKeysEN.PKeyTabId = objFKeysEN.PKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.PKeyTabId + "'");
 }
 
 if (objFKeysEN.PKeyTabName !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.PKeyTabName);
 objFKeysEN.PKeyTabName = objFKeysEN.PKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.PKeyTabName + "'");
 }
 
 if (objFKeysEN.Update_Action !=  null)
 {
 arrFieldListForInsert.Add(conFKeys.Update_Action);
 objFKeysEN.Update_Action = objFKeysEN.Update_Action.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFKeysEN.Update_Action + "'");
 }
 
 arrFieldListForInsert.Add(conFKeys.Delete_Action);
 arrValueListForInsert.Add(objFKeysEN.Delete_Action.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FKeys");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objFKeysEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewFKeysBySP(clsFKeysEN objFKeysEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objFKeysEN.FKeyName,
 objFKeysEN.FKeyColumnID,
 objFKeysEN.FKeyColumnName,
 objFKeysEN.FKeyTabID,
 objFKeysEN.FKeyTabName,
 objFKeysEN.PKeyColumnID,
 objFKeysEN.PKeyColumnName,
 objFKeysEN.PKeyTabId,
 objFKeysEN.PKeyTabName,
 objFKeysEN.Update_Action,
objFKeysEN.Delete_Action
};
 objSQL.ExecSP("FKeys_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFKeyss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
strSQL = "Select * from FKeys where Id = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FKeys");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngId = TransNullToInt(oRow[conFKeys.Id].ToString().Trim());
if (IsExist(lngId))
{
 string strResult = "关键字变量值为:" + string.Format("Id = {0}", lngId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFKeysEN._CurrTabName ].NewRow();
objRow[conFKeys.FKeyName] = oRow[conFKeys.FKeyName].ToString().Trim(); //外键名称
objRow[conFKeys.FKeyColumnID] = oRow[conFKeys.FKeyColumnID].ToString().Trim(); //外键列Id
objRow[conFKeys.FKeyColumnName] = oRow[conFKeys.FKeyColumnName].ToString().Trim(); //外键列名
objRow[conFKeys.FKeyTabID] = oRow[conFKeys.FKeyTabID].ToString().Trim(); //外键表ID
objRow[conFKeys.FKeyTabName] = oRow[conFKeys.FKeyTabName].ToString().Trim(); //外键表名称
objRow[conFKeys.PKeyColumnID] = oRow[conFKeys.PKeyColumnID].ToString().Trim(); //主键列ID
objRow[conFKeys.PKeyColumnName] = oRow[conFKeys.PKeyColumnName].ToString().Trim(); //主键列名
objRow[conFKeys.PKeyTabId] = oRow[conFKeys.PKeyTabId].ToString().Trim(); //主键表Id
objRow[conFKeys.PKeyTabName] = oRow[conFKeys.PKeyTabName].ToString().Trim(); //主键表名
objRow[conFKeys.Update_Action] = oRow[conFKeys.Update_Action].ToString().Trim(); //级联更新
objRow[conFKeys.Delete_Action] = oRow[conFKeys.Delete_Action].ToString().Trim(); //级联删除
 objDS.Tables[clsFKeysEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFKeysEN._CurrTabName);
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
 /// <param name = "objFKeysEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFKeysEN objFKeysEN)
{
 if (objFKeysEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFKeysEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
strSQL = "Select * from FKeys where Id = " + ""+ objFKeysEN.Id+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFKeysEN._CurrTabName);
if (objDS.Tables[clsFKeysEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:Id = " + ""+ objFKeysEN.Id+"");
return false;
}
objRow = objDS.Tables[clsFKeysEN._CurrTabName].Rows[0];
 if (objFKeysEN.IsUpdated(conFKeys.FKeyName))
 {
objRow[conFKeys.FKeyName] = objFKeysEN.FKeyName; //外键名称
 }
 if (objFKeysEN.IsUpdated(conFKeys.FKeyColumnID))
 {
objRow[conFKeys.FKeyColumnID] = objFKeysEN.FKeyColumnID; //外键列Id
 }
 if (objFKeysEN.IsUpdated(conFKeys.FKeyColumnName))
 {
objRow[conFKeys.FKeyColumnName] = objFKeysEN.FKeyColumnName; //外键列名
 }
 if (objFKeysEN.IsUpdated(conFKeys.FKeyTabID))
 {
objRow[conFKeys.FKeyTabID] = objFKeysEN.FKeyTabID; //外键表ID
 }
 if (objFKeysEN.IsUpdated(conFKeys.FKeyTabName))
 {
objRow[conFKeys.FKeyTabName] = objFKeysEN.FKeyTabName; //外键表名称
 }
 if (objFKeysEN.IsUpdated(conFKeys.PKeyColumnID))
 {
objRow[conFKeys.PKeyColumnID] = objFKeysEN.PKeyColumnID; //主键列ID
 }
 if (objFKeysEN.IsUpdated(conFKeys.PKeyColumnName))
 {
objRow[conFKeys.PKeyColumnName] = objFKeysEN.PKeyColumnName; //主键列名
 }
 if (objFKeysEN.IsUpdated(conFKeys.PKeyTabId))
 {
objRow[conFKeys.PKeyTabId] = objFKeysEN.PKeyTabId; //主键表Id
 }
 if (objFKeysEN.IsUpdated(conFKeys.PKeyTabName))
 {
objRow[conFKeys.PKeyTabName] = objFKeysEN.PKeyTabName; //主键表名
 }
 if (objFKeysEN.IsUpdated(conFKeys.Update_Action))
 {
objRow[conFKeys.Update_Action] = objFKeysEN.Update_Action; //级联更新
 }
 if (objFKeysEN.IsUpdated(conFKeys.Delete_Action))
 {
objRow[conFKeys.Delete_Action] = objFKeysEN.Delete_Action; //级联删除
 }
try
{
objDA.Update(objDS, clsFKeysEN._CurrTabName);
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
public bool UpdateBySP(clsFKeysEN objFKeysEN)
{
 if (objFKeysEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFKeysEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objFKeysEN.Id,
 objFKeysEN.FKeyName,
 objFKeysEN.FKeyColumnID,
 objFKeysEN.FKeyColumnName,
 objFKeysEN.FKeyTabID,
 objFKeysEN.FKeyTabName,
 objFKeysEN.PKeyColumnID,
 objFKeysEN.PKeyColumnName,
 objFKeysEN.PKeyTabId,
 objFKeysEN.PKeyTabName,
 objFKeysEN.Update_Action,
 objFKeysEN.Delete_Action
};
 objSQL.ExecSP("FKeys_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objFKeysEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFKeysEN objFKeysEN)
{
 if (objFKeysEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFKeysEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FKeys Set ");
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyName))
 {
 if (objFKeysEN.FKeyName !=  null)
 {
 objFKeysEN.FKeyName = objFKeysEN.FKeyName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.FKeyName, conFKeys.FKeyName); //外键名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.FKeyName); //外键名称
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyColumnID))
 {
 if (objFKeysEN.FKeyColumnID !=  null)
 {
 objFKeysEN.FKeyColumnID = objFKeysEN.FKeyColumnID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.FKeyColumnID, conFKeys.FKeyColumnID); //外键列Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.FKeyColumnID); //外键列Id
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyColumnName))
 {
 if (objFKeysEN.FKeyColumnName !=  null)
 {
 objFKeysEN.FKeyColumnName = objFKeysEN.FKeyColumnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.FKeyColumnName, conFKeys.FKeyColumnName); //外键列名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.FKeyColumnName); //外键列名
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyTabID))
 {
 if (objFKeysEN.FKeyTabID !=  null)
 {
 objFKeysEN.FKeyTabID = objFKeysEN.FKeyTabID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.FKeyTabID, conFKeys.FKeyTabID); //外键表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.FKeyTabID); //外键表ID
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyTabName))
 {
 if (objFKeysEN.FKeyTabName !=  null)
 {
 objFKeysEN.FKeyTabName = objFKeysEN.FKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.FKeyTabName, conFKeys.FKeyTabName); //外键表名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.FKeyTabName); //外键表名称
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.PKeyColumnID))
 {
 if (objFKeysEN.PKeyColumnID !=  null)
 {
 objFKeysEN.PKeyColumnID = objFKeysEN.PKeyColumnID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.PKeyColumnID, conFKeys.PKeyColumnID); //主键列ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.PKeyColumnID); //主键列ID
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.PKeyColumnName))
 {
 if (objFKeysEN.PKeyColumnName !=  null)
 {
 objFKeysEN.PKeyColumnName = objFKeysEN.PKeyColumnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.PKeyColumnName, conFKeys.PKeyColumnName); //主键列名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.PKeyColumnName); //主键列名
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.PKeyTabId))
 {
 if (objFKeysEN.PKeyTabId !=  null)
 {
 objFKeysEN.PKeyTabId = objFKeysEN.PKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.PKeyTabId, conFKeys.PKeyTabId); //主键表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.PKeyTabId); //主键表Id
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.PKeyTabName))
 {
 if (objFKeysEN.PKeyTabName !=  null)
 {
 objFKeysEN.PKeyTabName = objFKeysEN.PKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.PKeyTabName, conFKeys.PKeyTabName); //主键表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.PKeyTabName); //主键表名
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.Update_Action))
 {
 if (objFKeysEN.Update_Action !=  null)
 {
 objFKeysEN.Update_Action = objFKeysEN.Update_Action.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.Update_Action, conFKeys.Update_Action); //级联更新
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.Update_Action); //级联更新
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.Delete_Action))
 {
 sbSQL.AppendFormat("{1} = {0},",objFKeysEN.Delete_Action, conFKeys.Delete_Action); //级联删除
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where Id = {0}", objFKeysEN.Id); 
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
 /// <param name = "objFKeysEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFKeysEN objFKeysEN, string strCondition)
{
 if (objFKeysEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFKeysEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FKeys Set ");
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyName))
 {
 if (objFKeysEN.FKeyName !=  null)
 {
 objFKeysEN.FKeyName = objFKeysEN.FKeyName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FKeyName = '{0}',", objFKeysEN.FKeyName); //外键名称
 }
 else
 {
 sbSQL.Append(" FKeyName = null,"); //外键名称
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyColumnID))
 {
 if (objFKeysEN.FKeyColumnID !=  null)
 {
 objFKeysEN.FKeyColumnID = objFKeysEN.FKeyColumnID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FKeyColumnID = '{0}',", objFKeysEN.FKeyColumnID); //外键列Id
 }
 else
 {
 sbSQL.Append(" FKeyColumnID = null,"); //外键列Id
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyColumnName))
 {
 if (objFKeysEN.FKeyColumnName !=  null)
 {
 objFKeysEN.FKeyColumnName = objFKeysEN.FKeyColumnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FKeyColumnName = '{0}',", objFKeysEN.FKeyColumnName); //外键列名
 }
 else
 {
 sbSQL.Append(" FKeyColumnName = null,"); //外键列名
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyTabID))
 {
 if (objFKeysEN.FKeyTabID !=  null)
 {
 objFKeysEN.FKeyTabID = objFKeysEN.FKeyTabID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FKeyTabID = '{0}',", objFKeysEN.FKeyTabID); //外键表ID
 }
 else
 {
 sbSQL.Append(" FKeyTabID = null,"); //外键表ID
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyTabName))
 {
 if (objFKeysEN.FKeyTabName !=  null)
 {
 objFKeysEN.FKeyTabName = objFKeysEN.FKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FKeyTabName = '{0}',", objFKeysEN.FKeyTabName); //外键表名称
 }
 else
 {
 sbSQL.Append(" FKeyTabName = null,"); //外键表名称
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.PKeyColumnID))
 {
 if (objFKeysEN.PKeyColumnID !=  null)
 {
 objFKeysEN.PKeyColumnID = objFKeysEN.PKeyColumnID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PKeyColumnID = '{0}',", objFKeysEN.PKeyColumnID); //主键列ID
 }
 else
 {
 sbSQL.Append(" PKeyColumnID = null,"); //主键列ID
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.PKeyColumnName))
 {
 if (objFKeysEN.PKeyColumnName !=  null)
 {
 objFKeysEN.PKeyColumnName = objFKeysEN.PKeyColumnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PKeyColumnName = '{0}',", objFKeysEN.PKeyColumnName); //主键列名
 }
 else
 {
 sbSQL.Append(" PKeyColumnName = null,"); //主键列名
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.PKeyTabId))
 {
 if (objFKeysEN.PKeyTabId !=  null)
 {
 objFKeysEN.PKeyTabId = objFKeysEN.PKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PKeyTabId = '{0}',", objFKeysEN.PKeyTabId); //主键表Id
 }
 else
 {
 sbSQL.Append(" PKeyTabId = null,"); //主键表Id
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.PKeyTabName))
 {
 if (objFKeysEN.PKeyTabName !=  null)
 {
 objFKeysEN.PKeyTabName = objFKeysEN.PKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PKeyTabName = '{0}',", objFKeysEN.PKeyTabName); //主键表名
 }
 else
 {
 sbSQL.Append(" PKeyTabName = null,"); //主键表名
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.Update_Action))
 {
 if (objFKeysEN.Update_Action !=  null)
 {
 objFKeysEN.Update_Action = objFKeysEN.Update_Action.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Update_Action = '{0}',", objFKeysEN.Update_Action); //级联更新
 }
 else
 {
 sbSQL.Append(" Update_Action = null,"); //级联更新
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.Delete_Action))
 {
 sbSQL.AppendFormat(" Delete_Action = {0},", objFKeysEN.Delete_Action); //级联删除
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
 /// <param name = "objFKeysEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFKeysEN objFKeysEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFKeysEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFKeysEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FKeys Set ");
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyName))
 {
 if (objFKeysEN.FKeyName !=  null)
 {
 objFKeysEN.FKeyName = objFKeysEN.FKeyName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FKeyName = '{0}',", objFKeysEN.FKeyName); //外键名称
 }
 else
 {
 sbSQL.Append(" FKeyName = null,"); //外键名称
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyColumnID))
 {
 if (objFKeysEN.FKeyColumnID !=  null)
 {
 objFKeysEN.FKeyColumnID = objFKeysEN.FKeyColumnID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FKeyColumnID = '{0}',", objFKeysEN.FKeyColumnID); //外键列Id
 }
 else
 {
 sbSQL.Append(" FKeyColumnID = null,"); //外键列Id
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyColumnName))
 {
 if (objFKeysEN.FKeyColumnName !=  null)
 {
 objFKeysEN.FKeyColumnName = objFKeysEN.FKeyColumnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FKeyColumnName = '{0}',", objFKeysEN.FKeyColumnName); //外键列名
 }
 else
 {
 sbSQL.Append(" FKeyColumnName = null,"); //外键列名
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyTabID))
 {
 if (objFKeysEN.FKeyTabID !=  null)
 {
 objFKeysEN.FKeyTabID = objFKeysEN.FKeyTabID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FKeyTabID = '{0}',", objFKeysEN.FKeyTabID); //外键表ID
 }
 else
 {
 sbSQL.Append(" FKeyTabID = null,"); //外键表ID
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyTabName))
 {
 if (objFKeysEN.FKeyTabName !=  null)
 {
 objFKeysEN.FKeyTabName = objFKeysEN.FKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FKeyTabName = '{0}',", objFKeysEN.FKeyTabName); //外键表名称
 }
 else
 {
 sbSQL.Append(" FKeyTabName = null,"); //外键表名称
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.PKeyColumnID))
 {
 if (objFKeysEN.PKeyColumnID !=  null)
 {
 objFKeysEN.PKeyColumnID = objFKeysEN.PKeyColumnID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PKeyColumnID = '{0}',", objFKeysEN.PKeyColumnID); //主键列ID
 }
 else
 {
 sbSQL.Append(" PKeyColumnID = null,"); //主键列ID
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.PKeyColumnName))
 {
 if (objFKeysEN.PKeyColumnName !=  null)
 {
 objFKeysEN.PKeyColumnName = objFKeysEN.PKeyColumnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PKeyColumnName = '{0}',", objFKeysEN.PKeyColumnName); //主键列名
 }
 else
 {
 sbSQL.Append(" PKeyColumnName = null,"); //主键列名
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.PKeyTabId))
 {
 if (objFKeysEN.PKeyTabId !=  null)
 {
 objFKeysEN.PKeyTabId = objFKeysEN.PKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PKeyTabId = '{0}',", objFKeysEN.PKeyTabId); //主键表Id
 }
 else
 {
 sbSQL.Append(" PKeyTabId = null,"); //主键表Id
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.PKeyTabName))
 {
 if (objFKeysEN.PKeyTabName !=  null)
 {
 objFKeysEN.PKeyTabName = objFKeysEN.PKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PKeyTabName = '{0}',", objFKeysEN.PKeyTabName); //主键表名
 }
 else
 {
 sbSQL.Append(" PKeyTabName = null,"); //主键表名
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.Update_Action))
 {
 if (objFKeysEN.Update_Action !=  null)
 {
 objFKeysEN.Update_Action = objFKeysEN.Update_Action.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Update_Action = '{0}',", objFKeysEN.Update_Action); //级联更新
 }
 else
 {
 sbSQL.Append(" Update_Action = null,"); //级联更新
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.Delete_Action))
 {
 sbSQL.AppendFormat(" Delete_Action = {0},", objFKeysEN.Delete_Action); //级联删除
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
 /// <param name = "objFKeysEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFKeysEN objFKeysEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objFKeysEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFKeysEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FKeys Set ");
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyName))
 {
 if (objFKeysEN.FKeyName !=  null)
 {
 objFKeysEN.FKeyName = objFKeysEN.FKeyName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.FKeyName, conFKeys.FKeyName); //外键名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.FKeyName); //外键名称
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyColumnID))
 {
 if (objFKeysEN.FKeyColumnID !=  null)
 {
 objFKeysEN.FKeyColumnID = objFKeysEN.FKeyColumnID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.FKeyColumnID, conFKeys.FKeyColumnID); //外键列Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.FKeyColumnID); //外键列Id
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyColumnName))
 {
 if (objFKeysEN.FKeyColumnName !=  null)
 {
 objFKeysEN.FKeyColumnName = objFKeysEN.FKeyColumnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.FKeyColumnName, conFKeys.FKeyColumnName); //外键列名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.FKeyColumnName); //外键列名
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyTabID))
 {
 if (objFKeysEN.FKeyTabID !=  null)
 {
 objFKeysEN.FKeyTabID = objFKeysEN.FKeyTabID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.FKeyTabID, conFKeys.FKeyTabID); //外键表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.FKeyTabID); //外键表ID
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.FKeyTabName))
 {
 if (objFKeysEN.FKeyTabName !=  null)
 {
 objFKeysEN.FKeyTabName = objFKeysEN.FKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.FKeyTabName, conFKeys.FKeyTabName); //外键表名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.FKeyTabName); //外键表名称
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.PKeyColumnID))
 {
 if (objFKeysEN.PKeyColumnID !=  null)
 {
 objFKeysEN.PKeyColumnID = objFKeysEN.PKeyColumnID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.PKeyColumnID, conFKeys.PKeyColumnID); //主键列ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.PKeyColumnID); //主键列ID
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.PKeyColumnName))
 {
 if (objFKeysEN.PKeyColumnName !=  null)
 {
 objFKeysEN.PKeyColumnName = objFKeysEN.PKeyColumnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.PKeyColumnName, conFKeys.PKeyColumnName); //主键列名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.PKeyColumnName); //主键列名
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.PKeyTabId))
 {
 if (objFKeysEN.PKeyTabId !=  null)
 {
 objFKeysEN.PKeyTabId = objFKeysEN.PKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.PKeyTabId, conFKeys.PKeyTabId); //主键表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.PKeyTabId); //主键表Id
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.PKeyTabName))
 {
 if (objFKeysEN.PKeyTabName !=  null)
 {
 objFKeysEN.PKeyTabName = objFKeysEN.PKeyTabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.PKeyTabName, conFKeys.PKeyTabName); //主键表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.PKeyTabName); //主键表名
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.Update_Action))
 {
 if (objFKeysEN.Update_Action !=  null)
 {
 objFKeysEN.Update_Action = objFKeysEN.Update_Action.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFKeysEN.Update_Action, conFKeys.Update_Action); //级联更新
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFKeys.Update_Action); //级联更新
 }
 }
 
 if (objFKeysEN.IsUpdated(conFKeys.Delete_Action))
 {
 sbSQL.AppendFormat("{1} = {0},",objFKeysEN.Delete_Action, conFKeys.Delete_Action); //级联删除
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where Id = {0}", objFKeysEN.Id); 
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
 /// <param name = "lngId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngId,
};
 objSQL.ExecSP("FKeys_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
//删除FKeys本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FKeys where Id = " + ""+ lngId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFKeys(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
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
//删除FKeys本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FKeys where Id in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
//删除FKeys本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FKeys where Id = " + ""+ lngId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFKeys(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFKeysDA: DelFKeys)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FKeys where " + strCondition ;
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
public bool DelFKeysWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFKeysDA: DelFKeysWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFKeysDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FKeys where " + strCondition ;
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
 /// <param name = "objFKeysENS">源对象</param>
 /// <param name = "objFKeysENT">目标对象</param>
public void CopyTo(clsFKeysEN objFKeysENS, clsFKeysEN objFKeysENT)
{
objFKeysENT.Id = objFKeysENS.Id; //对象Id
objFKeysENT.FKeyName = objFKeysENS.FKeyName; //外键名称
objFKeysENT.FKeyColumnID = objFKeysENS.FKeyColumnID; //外键列Id
objFKeysENT.FKeyColumnName = objFKeysENS.FKeyColumnName; //外键列名
objFKeysENT.FKeyTabID = objFKeysENS.FKeyTabID; //外键表ID
objFKeysENT.FKeyTabName = objFKeysENS.FKeyTabName; //外键表名称
objFKeysENT.PKeyColumnID = objFKeysENS.PKeyColumnID; //主键列ID
objFKeysENT.PKeyColumnName = objFKeysENS.PKeyColumnName; //主键列名
objFKeysENT.PKeyTabId = objFKeysENS.PKeyTabId; //主键表Id
objFKeysENT.PKeyTabName = objFKeysENS.PKeyTabName; //主键表名
objFKeysENT.Update_Action = objFKeysENS.Update_Action; //级联更新
objFKeysENT.Delete_Action = objFKeysENS.Delete_Action; //级联删除
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFKeysEN objFKeysEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFKeysEN.FKeyName, conFKeys.FKeyName);
clsCheckSql.CheckFieldNotNull(objFKeysEN.FKeyColumnID, conFKeys.FKeyColumnID);
clsCheckSql.CheckFieldNotNull(objFKeysEN.FKeyColumnName, conFKeys.FKeyColumnName);
clsCheckSql.CheckFieldNotNull(objFKeysEN.FKeyTabName, conFKeys.FKeyTabName);
clsCheckSql.CheckFieldNotNull(objFKeysEN.PKeyColumnID, conFKeys.PKeyColumnID);
clsCheckSql.CheckFieldNotNull(objFKeysEN.PKeyColumnName, conFKeys.PKeyColumnName);
clsCheckSql.CheckFieldNotNull(objFKeysEN.PKeyTabId, conFKeys.PKeyTabId);
clsCheckSql.CheckFieldNotNull(objFKeysEN.PKeyTabName, conFKeys.PKeyTabName);
clsCheckSql.CheckFieldNotNull(objFKeysEN.Update_Action, conFKeys.Update_Action);
clsCheckSql.CheckFieldNotNull(objFKeysEN.Delete_Action, conFKeys.Delete_Action);
//检查字段长度
clsCheckSql.CheckFieldLen(objFKeysEN.FKeyName, 128, conFKeys.FKeyName);
clsCheckSql.CheckFieldLen(objFKeysEN.FKeyColumnID, 128, conFKeys.FKeyColumnID);
clsCheckSql.CheckFieldLen(objFKeysEN.FKeyColumnName, 128, conFKeys.FKeyColumnName);
clsCheckSql.CheckFieldLen(objFKeysEN.FKeyTabID, 128, conFKeys.FKeyTabID);
clsCheckSql.CheckFieldLen(objFKeysEN.FKeyTabName, 128, conFKeys.FKeyTabName);
clsCheckSql.CheckFieldLen(objFKeysEN.PKeyColumnID, 128, conFKeys.PKeyColumnID);
clsCheckSql.CheckFieldLen(objFKeysEN.PKeyColumnName, 128, conFKeys.PKeyColumnName);
clsCheckSql.CheckFieldLen(objFKeysEN.PKeyTabId, 128, conFKeys.PKeyTabId);
clsCheckSql.CheckFieldLen(objFKeysEN.PKeyTabName, 128, conFKeys.PKeyTabName);
clsCheckSql.CheckFieldLen(objFKeysEN.Update_Action, 128, conFKeys.Update_Action);
//检查字段外键固定长度
 objFKeysEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFKeysEN objFKeysEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFKeysEN.FKeyName, 128, conFKeys.FKeyName);
clsCheckSql.CheckFieldLen(objFKeysEN.FKeyColumnID, 128, conFKeys.FKeyColumnID);
clsCheckSql.CheckFieldLen(objFKeysEN.FKeyColumnName, 128, conFKeys.FKeyColumnName);
clsCheckSql.CheckFieldLen(objFKeysEN.FKeyTabID, 128, conFKeys.FKeyTabID);
clsCheckSql.CheckFieldLen(objFKeysEN.FKeyTabName, 128, conFKeys.FKeyTabName);
clsCheckSql.CheckFieldLen(objFKeysEN.PKeyColumnID, 128, conFKeys.PKeyColumnID);
clsCheckSql.CheckFieldLen(objFKeysEN.PKeyColumnName, 128, conFKeys.PKeyColumnName);
clsCheckSql.CheckFieldLen(objFKeysEN.PKeyTabId, 128, conFKeys.PKeyTabId);
clsCheckSql.CheckFieldLen(objFKeysEN.PKeyTabName, 128, conFKeys.PKeyTabName);
clsCheckSql.CheckFieldLen(objFKeysEN.Update_Action, 128, conFKeys.Update_Action);
//检查外键字段长度
 objFKeysEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFKeysEN objFKeysEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFKeysEN.FKeyName, 128, conFKeys.FKeyName);
clsCheckSql.CheckFieldLen(objFKeysEN.FKeyColumnID, 128, conFKeys.FKeyColumnID);
clsCheckSql.CheckFieldLen(objFKeysEN.FKeyColumnName, 128, conFKeys.FKeyColumnName);
clsCheckSql.CheckFieldLen(objFKeysEN.FKeyTabID, 128, conFKeys.FKeyTabID);
clsCheckSql.CheckFieldLen(objFKeysEN.FKeyTabName, 128, conFKeys.FKeyTabName);
clsCheckSql.CheckFieldLen(objFKeysEN.PKeyColumnID, 128, conFKeys.PKeyColumnID);
clsCheckSql.CheckFieldLen(objFKeysEN.PKeyColumnName, 128, conFKeys.PKeyColumnName);
clsCheckSql.CheckFieldLen(objFKeysEN.PKeyTabId, 128, conFKeys.PKeyTabId);
clsCheckSql.CheckFieldLen(objFKeysEN.PKeyTabName, 128, conFKeys.PKeyTabName);
clsCheckSql.CheckFieldLen(objFKeysEN.Update_Action, 128, conFKeys.Update_Action);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFKeysEN.FKeyName, conFKeys.FKeyName);
clsCheckSql.CheckSqlInjection4Field(objFKeysEN.FKeyColumnID, conFKeys.FKeyColumnID);
clsCheckSql.CheckSqlInjection4Field(objFKeysEN.FKeyColumnName, conFKeys.FKeyColumnName);
clsCheckSql.CheckSqlInjection4Field(objFKeysEN.FKeyTabID, conFKeys.FKeyTabID);
clsCheckSql.CheckSqlInjection4Field(objFKeysEN.FKeyTabName, conFKeys.FKeyTabName);
clsCheckSql.CheckSqlInjection4Field(objFKeysEN.PKeyColumnID, conFKeys.PKeyColumnID);
clsCheckSql.CheckSqlInjection4Field(objFKeysEN.PKeyColumnName, conFKeys.PKeyColumnName);
clsCheckSql.CheckSqlInjection4Field(objFKeysEN.PKeyTabId, conFKeys.PKeyTabId);
clsCheckSql.CheckSqlInjection4Field(objFKeysEN.PKeyTabName, conFKeys.PKeyTabName);
clsCheckSql.CheckSqlInjection4Field(objFKeysEN.Update_Action, conFKeys.Update_Action);
//检查外键字段长度
 objFKeysEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--FKeys(表外键),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFKeysEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStrPKeyTabId_PKeyColumnID(clsFKeysEN objFKeysEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PKeyTabId = '{0}'", objFKeysEN.PKeyTabId);
 sbCondition.AppendFormat(" and PKeyColumnID = '{0}'", objFKeysEN.PKeyColumnID);
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
 objSQL = clsFKeysDA.GetSpecSQLObj();
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
 objSQL = clsFKeysDA.GetSpecSQLObj();
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
 objSQL = clsFKeysDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFKeysEN._CurrTabName);
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
 objSQL = clsFKeysDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFKeysEN._CurrTabName, strCondition);
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
 objSQL = clsFKeysDA.GetSpecSQLObj();
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
 objSQL = clsFKeysDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}