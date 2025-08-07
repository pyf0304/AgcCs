
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsRecExclusiveWayDA
 表名:RecExclusiveWay(00050273)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:15:41
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
 /// RecExclusiveWay(RecExclusiveWay)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsRecExclusiveWayDA : clsCommBase4DA
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
 return clsRecExclusiveWayEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsRecExclusiveWayEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsRecExclusiveWayEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsRecExclusiveWayEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsRecExclusiveWayEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strRecExclusiveWayId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strRecExclusiveWayId)
{
strRecExclusiveWayId = strRecExclusiveWayId.Replace("'", "''");
if (strRecExclusiveWayId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:RecExclusiveWay中,检查关键字,长度不正确!(clsRecExclusiveWayDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strRecExclusiveWayId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:RecExclusiveWay中,关键字不能为空 或 null!(clsRecExclusiveWayDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRecExclusiveWayId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsRecExclusiveWayDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strRecExclusiveWayId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strRecExclusiveWayId)
{
strRecExclusiveWayId = strRecExclusiveWayId.Replace("'", "''");
if (strRecExclusiveWayId.Length > 4 + 4)
{
throw new Exception("(errid:Data000004)在表:RecExclusiveWay中,检查关键字,长度不正确!(简化版)(clsRecExclusiveWayDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strRecExclusiveWayId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:RecExclusiveWay中,关键字不能为空 或 null!(clsRecExclusiveWayDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRecExclusiveWayId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsRecExclusiveWayDA:CheckPrimaryKey)", objException.Message));
}
return true;
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
 strSQL = "Select * from RecExclusiveWay where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "RecExclusiveWay");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("RecExclusiveWay_SelectByCond",values, "RecExclusiveWay");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from RecExclusiveWay where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "RecExclusiveWay");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsRecExclusiveWayDA: GetRecExclusiveWayByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsRecExclusiveWayDA: GetRecExclusiveWayByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsRecExclusiveWayDA: GetRecExclusiveWayByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from RecExclusiveWay a where {0} And a.RecExclusiveWayId not in (Select Top {2} RecExclusiveWayId From RecExclusiveWay Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "RecExclusiveWay");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsRecExclusiveWayDA: GetRecExclusiveWayByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsRecExclusiveWayDA: GetRecExclusiveWayByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsRecExclusiveWayDA: GetRecExclusiveWayByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from RecExclusiveWay a where {0} And a.RecExclusiveWayId not in (Select Top {2} RecExclusiveWayId From RecExclusiveWay Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "RecExclusiveWay");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsRecExclusiveWayDA: GetRecExclusiveWayByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsRecExclusiveWayDA: GetRecExclusiveWayByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsRecExclusiveWayDA: GetRecExclusiveWayByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from RecExclusiveWay a where {0} And a.RecExclusiveWayId not in (Select Top {2} RecExclusiveWayId From RecExclusiveWay Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "RecExclusiveWay");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
strSQL = "Select * from RecExclusiveWay where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_RecExclusiveWay(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataTable_RecExclusiveWay)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
strSQL = "Select * from RecExclusiveWay where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
strSQL = "Select * from RecExclusiveWay where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
strSQL = "Select * from RecExclusiveWay where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from RecExclusiveWay where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from RecExclusiveWay where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from RecExclusiveWay where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from RecExclusiveWay where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} RecExclusiveWay.* from RecExclusiveWay Left Join {1} on {2} where {3} and RecExclusiveWay.RecExclusiveWayId not in (Select top {5} RecExclusiveWay.RecExclusiveWayId from RecExclusiveWay Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from RecExclusiveWay where {1} and RecExclusiveWayId not in (Select top {2} RecExclusiveWayId from RecExclusiveWay where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from RecExclusiveWay where {1} and RecExclusiveWayId not in (Select top {3} RecExclusiveWayId from RecExclusiveWay where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} RecExclusiveWay.* from RecExclusiveWay Left Join {1} on {2} where {3} and RecExclusiveWay.RecExclusiveWayId not in (Select top {5} RecExclusiveWay.RecExclusiveWayId from RecExclusiveWay Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from RecExclusiveWay where {1} and RecExclusiveWayId not in (Select top {2} RecExclusiveWayId from RecExclusiveWay where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from RecExclusiveWay where {1} and RecExclusiveWayId not in (Select top {3} RecExclusiveWayId from RecExclusiveWay where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} RecExclusiveWay.* from RecExclusiveWay Left Join {1} on {2} where {3} and RecExclusiveWay.RecExclusiveWayId not in (Select top {5} RecExclusiveWay.RecExclusiveWayId from RecExclusiveWay Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from RecExclusiveWay where {1} and RecExclusiveWayId not in (Select top {2} RecExclusiveWayId from RecExclusiveWay where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from RecExclusiveWay where {1} and RecExclusiveWayId not in (Select top {3} RecExclusiveWayId from RecExclusiveWay where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsRecExclusiveWayDA: GetRecExclusiveWayByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsRecExclusiveWayDA: GetRecExclusiveWayByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsRecExclusiveWayDA: GetRecExclusiveWayByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from RecExclusiveWay a where {0} And a.RecExclusiveWayId not in (Select Top {2} RecExclusiveWayId From RecExclusiveWay Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from RecExclusiveWay a where {0} And a.RecExclusiveWayId not in (Select Top {2} RecExclusiveWayId From RecExclusiveWay Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsRecExclusiveWayDA: GetRecExclusiveWayByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsRecExclusiveWayDA: GetRecExclusiveWayByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsRecExclusiveWayDA: GetRecExclusiveWayByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from RecExclusiveWay a where {0} And a.RecExclusiveWayId not in (Select Top {2} RecExclusiveWayId From RecExclusiveWay Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from RecExclusiveWay a where {0} And a.RecExclusiveWayId not in (Select Top {2} RecExclusiveWayId From RecExclusiveWay Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsRecExclusiveWayDA: GetRecExclusiveWayByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsRecExclusiveWayDA: GetRecExclusiveWayByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsRecExclusiveWayDA: GetRecExclusiveWayByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
strSQL = "Select * from RecExclusiveWay where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("RecExclusiveWay_SelectByCond",values);
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
public List<clsRecExclusiveWayEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA:GetObjLst)", objException.Message));
}
List<clsRecExclusiveWayEN> arrObjLst = new List<clsRecExclusiveWayEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
strSQL = "Select * from RecExclusiveWay where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
try
{
objRecExclusiveWayEN.RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRecExclusiveWayEN.RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objRecExclusiveWayEN.Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsRecExclusiveWayDA: GetObjLst)", objException.Message));
}
objRecExclusiveWayEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objRecExclusiveWayEN);
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
public List<clsRecExclusiveWayEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA:GetObjLstByTabName)", objException.Message));
}
List<clsRecExclusiveWayEN> arrObjLst = new List<clsRecExclusiveWayEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
try
{
objRecExclusiveWayEN.RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRecExclusiveWayEN.RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objRecExclusiveWayEN.Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsRecExclusiveWayDA: GetObjLst)", objException.Message));
}
objRecExclusiveWayEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objRecExclusiveWayEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsRecExclusiveWayEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA:GetObjLstBySP)", objException.Message));
}
List<clsRecExclusiveWayEN> arrObjLst = new List<clsRecExclusiveWayEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("RecExclusiveWay_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
try
{
objRecExclusiveWayEN.RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRecExclusiveWayEN.RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objRecExclusiveWayEN.Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsRecExclusiveWayDA: GetObjLstBySP)", objException.Message));
}
objRecExclusiveWayEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objRecExclusiveWayEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objRecExclusiveWayEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetRecExclusiveWay(ref clsRecExclusiveWayEN objRecExclusiveWayEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
strSQL = "Select * from RecExclusiveWay where RecExclusiveWayId = " + "'"+ objRecExclusiveWayEN.RecExclusiveWayId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objRecExclusiveWayEN.RecExclusiveWayId = objDT.Rows[0][conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id(字段类型:char,字段长度:4,是否可空:False)
 objRecExclusiveWayEN.RecExclusiveWayName = objDT.Rows[0][conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称(字段类型:varchar,字段长度:30,是否可空:False)
 objRecExclusiveWayEN.Memo = objDT.Rows[0][conRecExclusiveWay.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsRecExclusiveWayDA: GetRecExclusiveWay)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRecExclusiveWayId">表关键字</param>
 /// <returns>表对象</returns>
public clsRecExclusiveWayEN GetObjByRecExclusiveWayId(string strRecExclusiveWayId)
{
CheckPrimaryKey(strRecExclusiveWayId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
strSQL = "Select * from RecExclusiveWay where RecExclusiveWayId = " + "'"+ strRecExclusiveWayId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
try
{
 objRecExclusiveWayEN.RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id(字段类型:char,字段长度:4,是否可空:False)
 objRecExclusiveWayEN.RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称(字段类型:varchar,字段长度:30,是否可空:False)
 objRecExclusiveWayEN.Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsRecExclusiveWayDA: GetObjByRecExclusiveWayId)", objException.Message));
}
return objRecExclusiveWayEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程RecExclusiveWay_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objRecExclusiveWayEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetRecExclusiveWayOneBySP(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objRecExclusiveWayEN.RecExclusiveWayId
};
 objDT = objSQL.ExecSpReturnDT("RecExclusiveWay_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objRecExclusiveWayEN.RecExclusiveWayId = objDT.Rows[0][conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id(字段类型:char,字段长度:4,是否可空:False)
 objRecExclusiveWayEN.RecExclusiveWayName = objDT.Rows[0][conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称(字段类型:varchar,字段长度:30,是否可空:False)
 objRecExclusiveWayEN.Memo = objDT.Rows[0][conRecExclusiveWay.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsRecExclusiveWayEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
strSQL = "Select * from RecExclusiveWay where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN()
{
RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(), //记录排他方式Id
RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(), //记录排他方式名称
Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim() //说明
};
objRecExclusiveWayEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objRecExclusiveWayEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsRecExclusiveWayDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsRecExclusiveWayEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("RecExclusiveWay_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN()
{
RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(), //记录排他方式Id
RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(), //记录排他方式名称
Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim() //说明
};
objRecExclusiveWayEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objRecExclusiveWayEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsRecExclusiveWayEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
try
{
objRecExclusiveWayEN.RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRecExclusiveWayEN.RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objRecExclusiveWayEN.Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsRecExclusiveWayDA: GetObjByDataRowRecExclusiveWay)", objException.Message));
}
objRecExclusiveWayEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objRecExclusiveWayEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsRecExclusiveWayEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsRecExclusiveWayEN objRecExclusiveWayEN = new clsRecExclusiveWayEN();
try
{
objRecExclusiveWayEN.RecExclusiveWayId = objRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRecExclusiveWayEN.RecExclusiveWayName = objRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objRecExclusiveWayEN.Memo = objRow[conRecExclusiveWay.Memo] == DBNull.Value ? null : objRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsRecExclusiveWayDA: GetObjByDataRow)", objException.Message));
}
objRecExclusiveWayEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objRecExclusiveWayEN;
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
objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsRecExclusiveWayEN._CurrTabName, conRecExclusiveWay.RecExclusiveWayId, 4, "");
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
objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsRecExclusiveWayEN._CurrTabName, conRecExclusiveWay.RecExclusiveWayId, 4, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select RecExclusiveWayId from RecExclusiveWay where " + strCondition;
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
return "";
}
strKeyValue = objDT.Rows[0][0].ToString();
return strKeyValue;
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
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select RecExclusiveWayId from RecExclusiveWay where " + strCondition;
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
 /// <param name = "strRecExclusiveWayId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strRecExclusiveWayId)
{
CheckPrimaryKey(strRecExclusiveWayId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("RecExclusiveWay", "RecExclusiveWayId = " + "'"+ strRecExclusiveWayId+"'"))
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
 /// <param name = "strRecExclusiveWayId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strRecExclusiveWayId)
{
CheckPrimaryKey(strRecExclusiveWayId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strRecExclusiveWayId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("RecExclusiveWay_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("RecExclusiveWay", strCondition))
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
objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("RecExclusiveWay");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsRecExclusiveWayEN objRecExclusiveWayEN)
 {
 if (objRecExclusiveWayEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRecExclusiveWayEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
strSQL = "Select * from RecExclusiveWay where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "RecExclusiveWay");
objRow = objDS.Tables["RecExclusiveWay"].NewRow();
objRow[conRecExclusiveWay.RecExclusiveWayId] = objRecExclusiveWayEN.RecExclusiveWayId; //记录排他方式Id
objRow[conRecExclusiveWay.RecExclusiveWayName] = objRecExclusiveWayEN.RecExclusiveWayName; //记录排他方式名称
 if (objRecExclusiveWayEN.Memo !=  "")
 {
objRow[conRecExclusiveWay.Memo] = objRecExclusiveWayEN.Memo; //说明
 }
objDS.Tables[clsRecExclusiveWayEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsRecExclusiveWayEN._CurrTabName);
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
 /// <param name = "objRecExclusiveWayEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
 if (objRecExclusiveWayEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRecExclusiveWayEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objRecExclusiveWayEN.RecExclusiveWayId !=  null)
 {
 arrFieldListForInsert.Add(conRecExclusiveWay.RecExclusiveWayId);
 objRecExclusiveWayEN.RecExclusiveWayId = objRecExclusiveWayEN.RecExclusiveWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objRecExclusiveWayEN.RecExclusiveWayId + "'");
 }
 
 if (objRecExclusiveWayEN.RecExclusiveWayName !=  null)
 {
 arrFieldListForInsert.Add(conRecExclusiveWay.RecExclusiveWayName);
 objRecExclusiveWayEN.RecExclusiveWayName = objRecExclusiveWayEN.RecExclusiveWayName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objRecExclusiveWayEN.RecExclusiveWayName + "'");
 }
 
 if (objRecExclusiveWayEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conRecExclusiveWay.Memo);
 objRecExclusiveWayEN.Memo = objRecExclusiveWayEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objRecExclusiveWayEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RecExclusiveWay");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objRecExclusiveWayEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
 if (objRecExclusiveWayEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRecExclusiveWayEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objRecExclusiveWayEN.RecExclusiveWayId !=  null)
 {
 arrFieldListForInsert.Add(conRecExclusiveWay.RecExclusiveWayId);
 objRecExclusiveWayEN.RecExclusiveWayId = objRecExclusiveWayEN.RecExclusiveWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objRecExclusiveWayEN.RecExclusiveWayId + "'");
 }
 
 if (objRecExclusiveWayEN.RecExclusiveWayName !=  null)
 {
 arrFieldListForInsert.Add(conRecExclusiveWay.RecExclusiveWayName);
 objRecExclusiveWayEN.RecExclusiveWayName = objRecExclusiveWayEN.RecExclusiveWayName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objRecExclusiveWayEN.RecExclusiveWayName + "'");
 }
 
 if (objRecExclusiveWayEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conRecExclusiveWay.Memo);
 objRecExclusiveWayEN.Memo = objRecExclusiveWayEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objRecExclusiveWayEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RecExclusiveWay");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objRecExclusiveWayEN.RecExclusiveWayId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objRecExclusiveWayEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsRecExclusiveWayEN objRecExclusiveWayEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objRecExclusiveWayEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRecExclusiveWayEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objRecExclusiveWayEN.RecExclusiveWayId !=  null)
 {
 arrFieldListForInsert.Add(conRecExclusiveWay.RecExclusiveWayId);
 objRecExclusiveWayEN.RecExclusiveWayId = objRecExclusiveWayEN.RecExclusiveWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objRecExclusiveWayEN.RecExclusiveWayId + "'");
 }
 
 if (objRecExclusiveWayEN.RecExclusiveWayName !=  null)
 {
 arrFieldListForInsert.Add(conRecExclusiveWay.RecExclusiveWayName);
 objRecExclusiveWayEN.RecExclusiveWayName = objRecExclusiveWayEN.RecExclusiveWayName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objRecExclusiveWayEN.RecExclusiveWayName + "'");
 }
 
 if (objRecExclusiveWayEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conRecExclusiveWay.Memo);
 objRecExclusiveWayEN.Memo = objRecExclusiveWayEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objRecExclusiveWayEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RecExclusiveWay");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objRecExclusiveWayEN.RecExclusiveWayId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objRecExclusiveWayEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsRecExclusiveWayEN objRecExclusiveWayEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objRecExclusiveWayEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objRecExclusiveWayEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objRecExclusiveWayEN.RecExclusiveWayId !=  null)
 {
 arrFieldListForInsert.Add(conRecExclusiveWay.RecExclusiveWayId);
 objRecExclusiveWayEN.RecExclusiveWayId = objRecExclusiveWayEN.RecExclusiveWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objRecExclusiveWayEN.RecExclusiveWayId + "'");
 }
 
 if (objRecExclusiveWayEN.RecExclusiveWayName !=  null)
 {
 arrFieldListForInsert.Add(conRecExclusiveWay.RecExclusiveWayName);
 objRecExclusiveWayEN.RecExclusiveWayName = objRecExclusiveWayEN.RecExclusiveWayName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objRecExclusiveWayEN.RecExclusiveWayName + "'");
 }
 
 if (objRecExclusiveWayEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conRecExclusiveWay.Memo);
 objRecExclusiveWayEN.Memo = objRecExclusiveWayEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objRecExclusiveWayEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into RecExclusiveWay");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objRecExclusiveWayEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewRecExclusiveWayBySP(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objRecExclusiveWayEN.RecExclusiveWayId,
 objRecExclusiveWayEN.RecExclusiveWayName,
objRecExclusiveWayEN.Memo
};
 objSQL.ExecSP("RecExclusiveWay_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewRecExclusiveWays(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
strSQL = "Select * from RecExclusiveWay where RecExclusiveWayId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "RecExclusiveWay");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strRecExclusiveWayId = oRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim();
if (IsExist(strRecExclusiveWayId))
{
 string strResult = "关键字变量值为:" + string.Format("RecExclusiveWayId = {0}", strRecExclusiveWayId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsRecExclusiveWayEN._CurrTabName ].NewRow();
objRow[conRecExclusiveWay.RecExclusiveWayId] = oRow[conRecExclusiveWay.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRow[conRecExclusiveWay.RecExclusiveWayName] = oRow[conRecExclusiveWay.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objRow[conRecExclusiveWay.Memo] = oRow[conRecExclusiveWay.Memo].ToString().Trim(); //说明
 objDS.Tables[clsRecExclusiveWayEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsRecExclusiveWayEN._CurrTabName);
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
 /// <param name = "objRecExclusiveWayEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
 if (objRecExclusiveWayEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRecExclusiveWayEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
strSQL = "Select * from RecExclusiveWay where RecExclusiveWayId = " + "'"+ objRecExclusiveWayEN.RecExclusiveWayId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsRecExclusiveWayEN._CurrTabName);
if (objDS.Tables[clsRecExclusiveWayEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:RecExclusiveWayId = " + "'"+ objRecExclusiveWayEN.RecExclusiveWayId+"'");
return false;
}
objRow = objDS.Tables[clsRecExclusiveWayEN._CurrTabName].Rows[0];
 if (objRecExclusiveWayEN.IsUpdated(conRecExclusiveWay.RecExclusiveWayId))
 {
objRow[conRecExclusiveWay.RecExclusiveWayId] = objRecExclusiveWayEN.RecExclusiveWayId; //记录排他方式Id
 }
 if (objRecExclusiveWayEN.IsUpdated(conRecExclusiveWay.RecExclusiveWayName))
 {
objRow[conRecExclusiveWay.RecExclusiveWayName] = objRecExclusiveWayEN.RecExclusiveWayName; //记录排他方式名称
 }
 if (objRecExclusiveWayEN.IsUpdated(conRecExclusiveWay.Memo))
 {
objRow[conRecExclusiveWay.Memo] = objRecExclusiveWayEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsRecExclusiveWayEN._CurrTabName);
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
public bool UpdateBySP(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
 if (objRecExclusiveWayEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRecExclusiveWayEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objRecExclusiveWayEN.RecExclusiveWayId,
 objRecExclusiveWayEN.RecExclusiveWayName,
 objRecExclusiveWayEN.Memo
};
 objSQL.ExecSP("RecExclusiveWay_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objRecExclusiveWayEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
 if (objRecExclusiveWayEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRecExclusiveWayEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update RecExclusiveWay Set ");
 
 if (objRecExclusiveWayEN.IsUpdated(conRecExclusiveWay.RecExclusiveWayName))
 {
 if (objRecExclusiveWayEN.RecExclusiveWayName !=  null)
 {
 objRecExclusiveWayEN.RecExclusiveWayName = objRecExclusiveWayEN.RecExclusiveWayName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objRecExclusiveWayEN.RecExclusiveWayName, conRecExclusiveWay.RecExclusiveWayName); //记录排他方式名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRecExclusiveWay.RecExclusiveWayName); //记录排他方式名称
 }
 }
 
 if (objRecExclusiveWayEN.IsUpdated(conRecExclusiveWay.Memo))
 {
 if (objRecExclusiveWayEN.Memo !=  null)
 {
 objRecExclusiveWayEN.Memo = objRecExclusiveWayEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objRecExclusiveWayEN.Memo, conRecExclusiveWay.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRecExclusiveWay.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RecExclusiveWayId = '{0}'", objRecExclusiveWayEN.RecExclusiveWayId); 
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
 /// <param name = "objRecExclusiveWayEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsRecExclusiveWayEN objRecExclusiveWayEN, string strCondition)
{
 if (objRecExclusiveWayEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRecExclusiveWayEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update RecExclusiveWay Set ");
 
 if (objRecExclusiveWayEN.IsUpdated(conRecExclusiveWay.RecExclusiveWayName))
 {
 if (objRecExclusiveWayEN.RecExclusiveWayName !=  null)
 {
 objRecExclusiveWayEN.RecExclusiveWayName = objRecExclusiveWayEN.RecExclusiveWayName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecExclusiveWayName = '{0}',", objRecExclusiveWayEN.RecExclusiveWayName); //记录排他方式名称
 }
 else
 {
 sbSQL.Append(" RecExclusiveWayName = null,"); //记录排他方式名称
 }
 }
 
 if (objRecExclusiveWayEN.IsUpdated(conRecExclusiveWay.Memo))
 {
 if (objRecExclusiveWayEN.Memo !=  null)
 {
 objRecExclusiveWayEN.Memo = objRecExclusiveWayEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objRecExclusiveWayEN.Memo); //说明
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
 /// <param name = "objRecExclusiveWayEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsRecExclusiveWayEN objRecExclusiveWayEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objRecExclusiveWayEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRecExclusiveWayEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update RecExclusiveWay Set ");
 
 if (objRecExclusiveWayEN.IsUpdated(conRecExclusiveWay.RecExclusiveWayName))
 {
 if (objRecExclusiveWayEN.RecExclusiveWayName !=  null)
 {
 objRecExclusiveWayEN.RecExclusiveWayName = objRecExclusiveWayEN.RecExclusiveWayName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecExclusiveWayName = '{0}',", objRecExclusiveWayEN.RecExclusiveWayName); //记录排他方式名称
 }
 else
 {
 sbSQL.Append(" RecExclusiveWayName = null,"); //记录排他方式名称
 }
 }
 
 if (objRecExclusiveWayEN.IsUpdated(conRecExclusiveWay.Memo))
 {
 if (objRecExclusiveWayEN.Memo !=  null)
 {
 objRecExclusiveWayEN.Memo = objRecExclusiveWayEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objRecExclusiveWayEN.Memo); //说明
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
 /// <param name = "objRecExclusiveWayEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsRecExclusiveWayEN objRecExclusiveWayEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objRecExclusiveWayEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objRecExclusiveWayEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update RecExclusiveWay Set ");
 
 if (objRecExclusiveWayEN.IsUpdated(conRecExclusiveWay.RecExclusiveWayName))
 {
 if (objRecExclusiveWayEN.RecExclusiveWayName !=  null)
 {
 objRecExclusiveWayEN.RecExclusiveWayName = objRecExclusiveWayEN.RecExclusiveWayName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objRecExclusiveWayEN.RecExclusiveWayName, conRecExclusiveWay.RecExclusiveWayName); //记录排他方式名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRecExclusiveWay.RecExclusiveWayName); //记录排他方式名称
 }
 }
 
 if (objRecExclusiveWayEN.IsUpdated(conRecExclusiveWay.Memo))
 {
 if (objRecExclusiveWayEN.Memo !=  null)
 {
 objRecExclusiveWayEN.Memo = objRecExclusiveWayEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objRecExclusiveWayEN.Memo, conRecExclusiveWay.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conRecExclusiveWay.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RecExclusiveWayId = '{0}'", objRecExclusiveWayEN.RecExclusiveWayId); 
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
 /// <param name = "strRecExclusiveWayId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strRecExclusiveWayId) 
{
CheckPrimaryKey(strRecExclusiveWayId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strRecExclusiveWayId,
};
 objSQL.ExecSP("RecExclusiveWay_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strRecExclusiveWayId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strRecExclusiveWayId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strRecExclusiveWayId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
//删除RecExclusiveWay本表中与当前对象有关的记录
strSQL = strSQL + "Delete from RecExclusiveWay where RecExclusiveWayId = " + "'"+ strRecExclusiveWayId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelRecExclusiveWay(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除RecExclusiveWay本表中与当前对象有关的记录
strSQL = strSQL + "Delete from RecExclusiveWay where RecExclusiveWayId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strRecExclusiveWayId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strRecExclusiveWayId) 
{
CheckPrimaryKey(strRecExclusiveWayId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
//删除RecExclusiveWay本表中与当前对象有关的记录
strSQL = strSQL + "Delete from RecExclusiveWay where RecExclusiveWayId = " + "'"+ strRecExclusiveWayId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelRecExclusiveWay(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: DelRecExclusiveWay)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from RecExclusiveWay where " + strCondition ;
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
public bool DelRecExclusiveWayWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsRecExclusiveWayDA: DelRecExclusiveWayWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from RecExclusiveWay where " + strCondition ;
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
 /// <param name = "objRecExclusiveWayENS">源对象</param>
 /// <param name = "objRecExclusiveWayENT">目标对象</param>
public void CopyTo(clsRecExclusiveWayEN objRecExclusiveWayENS, clsRecExclusiveWayEN objRecExclusiveWayENT)
{
objRecExclusiveWayENT.RecExclusiveWayId = objRecExclusiveWayENS.RecExclusiveWayId; //记录排他方式Id
objRecExclusiveWayENT.RecExclusiveWayName = objRecExclusiveWayENS.RecExclusiveWayName; //记录排他方式名称
objRecExclusiveWayENT.Memo = objRecExclusiveWayENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objRecExclusiveWayEN.RecExclusiveWayName, conRecExclusiveWay.RecExclusiveWayName);
//检查字段长度
clsCheckSql.CheckFieldLen(objRecExclusiveWayEN.RecExclusiveWayId, 4, conRecExclusiveWay.RecExclusiveWayId);
clsCheckSql.CheckFieldLen(objRecExclusiveWayEN.RecExclusiveWayName, 30, conRecExclusiveWay.RecExclusiveWayName);
clsCheckSql.CheckFieldLen(objRecExclusiveWayEN.Memo, 1000, conRecExclusiveWay.Memo);
//检查字段外键固定长度
 objRecExclusiveWayEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objRecExclusiveWayEN.RecExclusiveWayName, 30, conRecExclusiveWay.RecExclusiveWayName);
clsCheckSql.CheckFieldLen(objRecExclusiveWayEN.Memo, 1000, conRecExclusiveWay.Memo);
//检查外键字段长度
 objRecExclusiveWayEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsRecExclusiveWayEN objRecExclusiveWayEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objRecExclusiveWayEN.RecExclusiveWayId, 4, conRecExclusiveWay.RecExclusiveWayId);
clsCheckSql.CheckFieldLen(objRecExclusiveWayEN.RecExclusiveWayName, 30, conRecExclusiveWay.RecExclusiveWayName);
clsCheckSql.CheckFieldLen(objRecExclusiveWayEN.Memo, 1000, conRecExclusiveWay.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objRecExclusiveWayEN.RecExclusiveWayId, conRecExclusiveWay.RecExclusiveWayId);
clsCheckSql.CheckSqlInjection4Field(objRecExclusiveWayEN.RecExclusiveWayName, conRecExclusiveWay.RecExclusiveWayName);
clsCheckSql.CheckSqlInjection4Field(objRecExclusiveWayEN.Memo, conRecExclusiveWay.Memo);
//检查外键字段长度
 objRecExclusiveWayEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetRecExclusiveWayId()
{
//获取某学院所有专业信息
string strSQL = "select RecExclusiveWayId, RecExclusiveWayName from RecExclusiveWay ";
 clsSpecSQLforSql mySql = clsRecExclusiveWayDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
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
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
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
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsRecExclusiveWayEN._CurrTabName);
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
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsRecExclusiveWayEN._CurrTabName, strCondition);
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
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
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
 objSQL = clsRecExclusiveWayDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}