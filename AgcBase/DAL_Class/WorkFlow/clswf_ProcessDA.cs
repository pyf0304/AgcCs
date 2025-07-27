
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clswf_ProcessDA
 表名:wf_Process(00050484)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:18:53
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理(WorkFlow)
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
 /// 工作流过程(wf_Process)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clswf_ProcessDA : clsCommBase4DA
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
 return clswf_ProcessEN._CurrTabName;
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
if (string.IsNullOrEmpty(clswf_ProcessEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clswf_ProcessEN._ConnectString);
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
 if (string.IsNullOrEmpty(clswf_ProcessEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clswf_ProcessEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strProcessId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strProcessId)
{
strProcessId = strProcessId.Replace("'", "''");
if (strProcessId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:wf_Process中,检查关键字,长度不正确!(clswf_ProcessDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strProcessId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:wf_Process中,关键字不能为空 或 null!(clswf_ProcessDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strProcessId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clswf_ProcessDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strProcessId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strProcessId)
{
strProcessId = strProcessId.Replace("'", "''");
if (strProcessId.Length > 8 + 4)
{
throw new Exception("(errid:Data000004)在表:wf_Process中,检查关键字,长度不正确!(简化版)(clswf_ProcessDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strProcessId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:wf_Process中,关键字不能为空 或 null!(clswf_ProcessDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strProcessId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clswf_ProcessDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
 strSQL = "Select * from wf_Process where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "wf_Process");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("wf_Process_SelectByCond",values, "wf_Process");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from wf_Process where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "wf_Process");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clswf_ProcessDA: Getwf_ProcessByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clswf_ProcessDA: Getwf_ProcessByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clswf_ProcessDA: Getwf_ProcessByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from wf_Process a where {0} And a.ProcessId not in (Select Top {2} ProcessId From wf_Process Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "wf_Process");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clswf_ProcessDA: Getwf_ProcessByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clswf_ProcessDA: Getwf_ProcessByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clswf_ProcessDA: Getwf_ProcessByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from wf_Process a where {0} And a.ProcessId not in (Select Top {2} ProcessId From wf_Process Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "wf_Process");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clswf_ProcessDA: Getwf_ProcessByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clswf_ProcessDA: Getwf_ProcessByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clswf_ProcessDA: Getwf_ProcessByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from wf_Process a where {0} And a.ProcessId not in (Select Top {2} ProcessId From wf_Process Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "wf_Process");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
strSQL = "Select * from wf_Process where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_wf_Process(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataTable_wf_Process)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
strSQL = "Select * from wf_Process where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
strSQL = "Select * from wf_Process where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
strSQL = "Select * from wf_Process where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from wf_Process where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from wf_Process where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from wf_Process where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from wf_Process where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} wf_Process.* from wf_Process Left Join {1} on {2} where {3} and wf_Process.ProcessId not in (Select top {5} wf_Process.ProcessId from wf_Process Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from wf_Process where {1} and ProcessId not in (Select top {2} ProcessId from wf_Process where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from wf_Process where {1} and ProcessId not in (Select top {3} ProcessId from wf_Process where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} wf_Process.* from wf_Process Left Join {1} on {2} where {3} and wf_Process.ProcessId not in (Select top {5} wf_Process.ProcessId from wf_Process Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from wf_Process where {1} and ProcessId not in (Select top {2} ProcessId from wf_Process where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from wf_Process where {1} and ProcessId not in (Select top {3} ProcessId from wf_Process where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} wf_Process.* from wf_Process Left Join {1} on {2} where {3} and wf_Process.ProcessId not in (Select top {5} wf_Process.ProcessId from wf_Process Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from wf_Process where {1} and ProcessId not in (Select top {2} ProcessId from wf_Process where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from wf_Process where {1} and ProcessId not in (Select top {3} ProcessId from wf_Process where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clswf_ProcessDA: Getwf_ProcessByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clswf_ProcessDA: Getwf_ProcessByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clswf_ProcessDA: Getwf_ProcessByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from wf_Process a where {0} And a.ProcessId not in (Select Top {2} ProcessId From wf_Process Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from wf_Process a where {0} And a.ProcessId not in (Select Top {2} ProcessId From wf_Process Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clswf_ProcessDA: Getwf_ProcessByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clswf_ProcessDA: Getwf_ProcessByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clswf_ProcessDA: Getwf_ProcessByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from wf_Process a where {0} And a.ProcessId not in (Select Top {2} ProcessId From wf_Process Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from wf_Process a where {0} And a.ProcessId not in (Select Top {2} ProcessId From wf_Process Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clswf_ProcessDA: Getwf_ProcessByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clswf_ProcessDA: Getwf_ProcessByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clswf_ProcessDA: Getwf_ProcessByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
strSQL = "Select * from wf_Process where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("wf_Process_SelectByCond",values);
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
public List<clswf_ProcessEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clswf_ProcessDA:GetObjLst)", objException.Message));
}
List<clswf_ProcessEN> arrObjLst = new List<clswf_ProcessEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
strSQL = "Select * from wf_Process where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
try
{
objwf_ProcessEN.ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID
objwf_ProcessEN.ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称
objwf_ProcessEN.PrjId = objRow[conwf_Process.PrjId].ToString().Trim(); //工程ID
objwf_ProcessEN.EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(); //终点
objwf_ProcessEN.StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(); //起点
objwf_ProcessEN.WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面
objwf_ProcessEN.ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objwf_ProcessEN.DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id
objwf_ProcessEN.OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conwf_Process.OrderNum].ToString().Trim()); //序号
objwf_ProcessEN.UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期
objwf_ProcessEN.UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(); //修改者
objwf_ProcessEN.Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clswf_ProcessDA: GetObjLst)", objException.Message));
}
objwf_ProcessEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objwf_ProcessEN);
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
public List<clswf_ProcessEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clswf_ProcessDA:GetObjLstByTabName)", objException.Message));
}
List<clswf_ProcessEN> arrObjLst = new List<clswf_ProcessEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
try
{
objwf_ProcessEN.ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID
objwf_ProcessEN.ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称
objwf_ProcessEN.PrjId = objRow[conwf_Process.PrjId].ToString().Trim(); //工程ID
objwf_ProcessEN.EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(); //终点
objwf_ProcessEN.StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(); //起点
objwf_ProcessEN.WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面
objwf_ProcessEN.ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objwf_ProcessEN.DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id
objwf_ProcessEN.OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conwf_Process.OrderNum].ToString().Trim()); //序号
objwf_ProcessEN.UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期
objwf_ProcessEN.UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(); //修改者
objwf_ProcessEN.Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clswf_ProcessDA: GetObjLst)", objException.Message));
}
objwf_ProcessEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objwf_ProcessEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clswf_ProcessEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clswf_ProcessDA:GetObjLstBySP)", objException.Message));
}
List<clswf_ProcessEN> arrObjLst = new List<clswf_ProcessEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("wf_Process_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
try
{
objwf_ProcessEN.ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID
objwf_ProcessEN.ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称
objwf_ProcessEN.PrjId = objRow[conwf_Process.PrjId].ToString().Trim(); //工程ID
objwf_ProcessEN.EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(); //终点
objwf_ProcessEN.StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(); //起点
objwf_ProcessEN.WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面
objwf_ProcessEN.ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objwf_ProcessEN.DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id
objwf_ProcessEN.OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conwf_Process.OrderNum].ToString().Trim()); //序号
objwf_ProcessEN.UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期
objwf_ProcessEN.UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(); //修改者
objwf_ProcessEN.Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clswf_ProcessDA: GetObjLstBySP)", objException.Message));
}
objwf_ProcessEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objwf_ProcessEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getwf_Process(ref clswf_ProcessEN objwf_ProcessEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
strSQL = "Select * from wf_Process where ProcessId = " + "'"+ objwf_ProcessEN.ProcessId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objwf_ProcessEN.ProcessId = objDT.Rows[0][conwf_Process.ProcessId].ToString().Trim(); //过程ID(字段类型:char,字段长度:8,是否可空:False)
 objwf_ProcessEN.ProcessName = objDT.Rows[0][conwf_Process.ProcessName].ToString().Trim(); //过程名称(字段类型:varchar,字段长度:100,是否可空:False)
 objwf_ProcessEN.PrjId = objDT.Rows[0][conwf_Process.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objwf_ProcessEN.EndPoint = objDT.Rows[0][conwf_Process.EndPoint].ToString().Trim(); //终点(字段类型:char,字段长度:8,是否可空:False)
 objwf_ProcessEN.StartPoint = objDT.Rows[0][conwf_Process.StartPoint].ToString().Trim(); //起点(字段类型:char,字段长度:8,是否可空:False)
 objwf_ProcessEN.WorkPage = objDT.Rows[0][conwf_Process.WorkPage].ToString().Trim(); //工作页面(字段类型:varchar,字段长度:500,是否可空:True)
 objwf_ProcessEN.ExamPhaseId = objDT.Rows[0][conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id(字段类型:char,字段长度:2,是否可空:False)
 objwf_ProcessEN.DefaExamDepId = objDT.Rows[0][conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id(字段类型:varchar,字段长度:6,是否可空:True)
 objwf_ProcessEN.OrderNum = TransNullToInt(objDT.Rows[0][conwf_Process.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objwf_ProcessEN.UpdDate = objDT.Rows[0][conwf_Process.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objwf_ProcessEN.UpdUser = objDT.Rows[0][conwf_Process.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objwf_ProcessEN.Memo = objDT.Rows[0][conwf_Process.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clswf_ProcessDA: Getwf_Process)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strProcessId">表关键字</param>
 /// <returns>表对象</returns>
public clswf_ProcessEN GetObjByProcessId(string strProcessId)
{
CheckPrimaryKey(strProcessId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
strSQL = "Select * from wf_Process where ProcessId = " + "'"+ strProcessId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
try
{
 objwf_ProcessEN.ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID(字段类型:char,字段长度:8,是否可空:False)
 objwf_ProcessEN.ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称(字段类型:varchar,字段长度:100,是否可空:False)
 objwf_ProcessEN.PrjId = objRow[conwf_Process.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objwf_ProcessEN.EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(); //终点(字段类型:char,字段长度:8,是否可空:False)
 objwf_ProcessEN.StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(); //起点(字段类型:char,字段长度:8,是否可空:False)
 objwf_ProcessEN.WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面(字段类型:varchar,字段长度:500,是否可空:True)
 objwf_ProcessEN.ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id(字段类型:char,字段长度:2,是否可空:False)
 objwf_ProcessEN.DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id(字段类型:varchar,字段长度:6,是否可空:True)
 objwf_ProcessEN.OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conwf_Process.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objwf_ProcessEN.UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objwf_ProcessEN.UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objwf_ProcessEN.Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clswf_ProcessDA: GetObjByProcessId)", objException.Message));
}
return objwf_ProcessEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程wf_Process_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getwf_ProcessOneBySP(clswf_ProcessEN objwf_ProcessEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objwf_ProcessEN.ProcessId
};
 objDT = objSQL.ExecSpReturnDT("wf_Process_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objwf_ProcessEN.ProcessId = objDT.Rows[0][conwf_Process.ProcessId].ToString().Trim(); //过程ID(字段类型:char,字段长度:8,是否可空:False)
 objwf_ProcessEN.ProcessName = objDT.Rows[0][conwf_Process.ProcessName].ToString().Trim(); //过程名称(字段类型:varchar,字段长度:100,是否可空:False)
 objwf_ProcessEN.PrjId = objDT.Rows[0][conwf_Process.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objwf_ProcessEN.EndPoint = objDT.Rows[0][conwf_Process.EndPoint].ToString().Trim(); //终点(字段类型:char,字段长度:8,是否可空:False)
 objwf_ProcessEN.StartPoint = objDT.Rows[0][conwf_Process.StartPoint].ToString().Trim(); //起点(字段类型:char,字段长度:8,是否可空:False)
 objwf_ProcessEN.WorkPage = objDT.Rows[0][conwf_Process.WorkPage].ToString().Trim(); //工作页面(字段类型:varchar,字段长度:500,是否可空:True)
 objwf_ProcessEN.ExamPhaseId = objDT.Rows[0][conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id(字段类型:char,字段长度:2,是否可空:False)
 objwf_ProcessEN.DefaExamDepId = objDT.Rows[0][conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id(字段类型:varchar,字段长度:6,是否可空:True)
 objwf_ProcessEN.OrderNum = TransNullToInt(objDT.Rows[0][conwf_Process.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objwf_ProcessEN.UpdDate = objDT.Rows[0][conwf_Process.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objwf_ProcessEN.UpdUser = objDT.Rows[0][conwf_Process.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objwf_ProcessEN.Memo = objDT.Rows[0][conwf_Process.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clswf_ProcessEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clswf_ProcessDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
strSQL = "Select * from wf_Process where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN()
{
ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(), //过程ID
ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(), //过程名称
PrjId = objRow[conwf_Process.PrjId].ToString().Trim(), //工程ID
EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(), //终点
StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(), //起点
WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(), //工作页面
ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(), //考核阶段Id
DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(), //默认考核部门Id
OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conwf_Process.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim() //说明
};
objwf_ProcessEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objwf_ProcessEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clswf_ProcessDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clswf_ProcessEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clswf_ProcessDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("wf_Process_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN()
{
ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(), //过程ID
ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(), //过程名称
PrjId = objRow[conwf_Process.PrjId].ToString().Trim(), //工程ID
EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(), //终点
StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(), //起点
WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(), //工作页面
ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(), //考核阶段Id
DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(), //默认考核部门Id
OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conwf_Process.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim() //说明
};
objwf_ProcessEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objwf_ProcessEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clswf_ProcessEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
try
{
objwf_ProcessEN.ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID
objwf_ProcessEN.ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称
objwf_ProcessEN.PrjId = objRow[conwf_Process.PrjId].ToString().Trim(); //工程ID
objwf_ProcessEN.EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(); //终点
objwf_ProcessEN.StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(); //起点
objwf_ProcessEN.WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面
objwf_ProcessEN.ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objwf_ProcessEN.DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id
objwf_ProcessEN.OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conwf_Process.OrderNum].ToString().Trim()); //序号
objwf_ProcessEN.UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期
objwf_ProcessEN.UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(); //修改者
objwf_ProcessEN.Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clswf_ProcessDA: GetObjByDataRowwf_Process)", objException.Message));
}
objwf_ProcessEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objwf_ProcessEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clswf_ProcessEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clswf_ProcessEN objwf_ProcessEN = new clswf_ProcessEN();
try
{
objwf_ProcessEN.ProcessId = objRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID
objwf_ProcessEN.ProcessName = objRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称
objwf_ProcessEN.PrjId = objRow[conwf_Process.PrjId].ToString().Trim(); //工程ID
objwf_ProcessEN.EndPoint = objRow[conwf_Process.EndPoint].ToString().Trim(); //终点
objwf_ProcessEN.StartPoint = objRow[conwf_Process.StartPoint].ToString().Trim(); //起点
objwf_ProcessEN.WorkPage = objRow[conwf_Process.WorkPage] == DBNull.Value ? null : objRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面
objwf_ProcessEN.ExamPhaseId = objRow[conwf_Process.ExamPhaseId] == DBNull.Value ? null : objRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objwf_ProcessEN.DefaExamDepId = objRow[conwf_Process.DefaExamDepId] == DBNull.Value ? null : objRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id
objwf_ProcessEN.OrderNum = objRow[conwf_Process.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conwf_Process.OrderNum].ToString().Trim()); //序号
objwf_ProcessEN.UpdDate = objRow[conwf_Process.UpdDate] == DBNull.Value ? null : objRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期
objwf_ProcessEN.UpdUser = objRow[conwf_Process.UpdUser] == DBNull.Value ? null : objRow[conwf_Process.UpdUser].ToString().Trim(); //修改者
objwf_ProcessEN.Memo = objRow[conwf_Process.Memo] == DBNull.Value ? null : objRow[conwf_Process.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clswf_ProcessDA: GetObjByDataRow)", objException.Message));
}
objwf_ProcessEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objwf_ProcessEN;
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
objSQL = clswf_ProcessDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clswf_ProcessEN._CurrTabName, conwf_Process.ProcessId, 8, "");
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
objSQL = clswf_ProcessDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clswf_ProcessEN._CurrTabName, conwf_Process.ProcessId, 8, strPrefix);
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
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ProcessId from wf_Process where " + strCondition;
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
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ProcessId from wf_Process where " + strCondition;
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
 /// <param name = "strProcessId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strProcessId)
{
CheckPrimaryKey(strProcessId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("wf_Process", "ProcessId = " + "'"+ strProcessId+"'"))
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
 /// <param name = "strProcessId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strProcessId)
{
CheckPrimaryKey(strProcessId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strProcessId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("wf_Process_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clswf_ProcessDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("wf_Process", strCondition))
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
objSQL = clswf_ProcessDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("wf_Process");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clswf_ProcessEN objwf_ProcessEN)
 {
 if (objwf_ProcessEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objwf_ProcessEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
strSQL = "Select * from wf_Process where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "wf_Process");
objRow = objDS.Tables["wf_Process"].NewRow();
objRow[conwf_Process.ProcessId] = objwf_ProcessEN.ProcessId; //过程ID
objRow[conwf_Process.ProcessName] = objwf_ProcessEN.ProcessName; //过程名称
objRow[conwf_Process.PrjId] = objwf_ProcessEN.PrjId; //工程ID
objRow[conwf_Process.EndPoint] = objwf_ProcessEN.EndPoint; //终点
objRow[conwf_Process.StartPoint] = objwf_ProcessEN.StartPoint; //起点
 if (objwf_ProcessEN.WorkPage !=  "")
 {
objRow[conwf_Process.WorkPage] = objwf_ProcessEN.WorkPage; //工作页面
 }
 if (objwf_ProcessEN.ExamPhaseId !=  "")
 {
objRow[conwf_Process.ExamPhaseId] = objwf_ProcessEN.ExamPhaseId; //考核阶段Id
 }
 if (objwf_ProcessEN.DefaExamDepId !=  "")
 {
objRow[conwf_Process.DefaExamDepId] = objwf_ProcessEN.DefaExamDepId; //默认考核部门Id
 }
objRow[conwf_Process.OrderNum] = objwf_ProcessEN.OrderNum; //序号
 if (objwf_ProcessEN.UpdDate !=  "")
 {
objRow[conwf_Process.UpdDate] = objwf_ProcessEN.UpdDate; //修改日期
 }
 if (objwf_ProcessEN.UpdUser !=  "")
 {
objRow[conwf_Process.UpdUser] = objwf_ProcessEN.UpdUser; //修改者
 }
 if (objwf_ProcessEN.Memo !=  "")
 {
objRow[conwf_Process.Memo] = objwf_ProcessEN.Memo; //说明
 }
objDS.Tables[clswf_ProcessEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clswf_ProcessEN._CurrTabName);
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
 /// <param name = "objwf_ProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clswf_ProcessEN objwf_ProcessEN)
{
 if (objwf_ProcessEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objwf_ProcessEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objwf_ProcessEN.ProcessId !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.ProcessId);
 objwf_ProcessEN.ProcessId = objwf_ProcessEN.ProcessId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.ProcessId + "'");
 }
 
 if (objwf_ProcessEN.ProcessName !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.ProcessName);
 objwf_ProcessEN.ProcessName = objwf_ProcessEN.ProcessName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.ProcessName + "'");
 }
 
 if (objwf_ProcessEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.PrjId);
 objwf_ProcessEN.PrjId = objwf_ProcessEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.PrjId + "'");
 }
 
 if (objwf_ProcessEN.EndPoint !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.EndPoint);
 objwf_ProcessEN.EndPoint = objwf_ProcessEN.EndPoint.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.EndPoint + "'");
 }
 
 if (objwf_ProcessEN.StartPoint !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.StartPoint);
 objwf_ProcessEN.StartPoint = objwf_ProcessEN.StartPoint.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.StartPoint + "'");
 }
 
 if (objwf_ProcessEN.WorkPage !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.WorkPage);
 objwf_ProcessEN.WorkPage = objwf_ProcessEN.WorkPage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.WorkPage + "'");
 }
 
 if (objwf_ProcessEN.ExamPhaseId !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.ExamPhaseId);
 objwf_ProcessEN.ExamPhaseId = objwf_ProcessEN.ExamPhaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.ExamPhaseId + "'");
 }
 
 if (objwf_ProcessEN.DefaExamDepId !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.DefaExamDepId);
 objwf_ProcessEN.DefaExamDepId = objwf_ProcessEN.DefaExamDepId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.DefaExamDepId + "'");
 }
 
 arrFieldListForInsert.Add(conwf_Process.OrderNum);
 arrValueListForInsert.Add(objwf_ProcessEN.OrderNum.ToString());
 
 if (objwf_ProcessEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.UpdDate);
 objwf_ProcessEN.UpdDate = objwf_ProcessEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.UpdDate + "'");
 }
 
 if (objwf_ProcessEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.UpdUser);
 objwf_ProcessEN.UpdUser = objwf_ProcessEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.UpdUser + "'");
 }
 
 if (objwf_ProcessEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.Memo);
 objwf_ProcessEN.Memo = objwf_ProcessEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into wf_Process");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clswf_ProcessEN objwf_ProcessEN)
{
 if (objwf_ProcessEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objwf_ProcessEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objwf_ProcessEN.ProcessId !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.ProcessId);
 objwf_ProcessEN.ProcessId = objwf_ProcessEN.ProcessId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.ProcessId + "'");
 }
 
 if (objwf_ProcessEN.ProcessName !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.ProcessName);
 objwf_ProcessEN.ProcessName = objwf_ProcessEN.ProcessName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.ProcessName + "'");
 }
 
 if (objwf_ProcessEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.PrjId);
 objwf_ProcessEN.PrjId = objwf_ProcessEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.PrjId + "'");
 }
 
 if (objwf_ProcessEN.EndPoint !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.EndPoint);
 objwf_ProcessEN.EndPoint = objwf_ProcessEN.EndPoint.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.EndPoint + "'");
 }
 
 if (objwf_ProcessEN.StartPoint !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.StartPoint);
 objwf_ProcessEN.StartPoint = objwf_ProcessEN.StartPoint.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.StartPoint + "'");
 }
 
 if (objwf_ProcessEN.WorkPage !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.WorkPage);
 objwf_ProcessEN.WorkPage = objwf_ProcessEN.WorkPage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.WorkPage + "'");
 }
 
 if (objwf_ProcessEN.ExamPhaseId !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.ExamPhaseId);
 objwf_ProcessEN.ExamPhaseId = objwf_ProcessEN.ExamPhaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.ExamPhaseId + "'");
 }
 
 if (objwf_ProcessEN.DefaExamDepId !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.DefaExamDepId);
 objwf_ProcessEN.DefaExamDepId = objwf_ProcessEN.DefaExamDepId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.DefaExamDepId + "'");
 }
 
 arrFieldListForInsert.Add(conwf_Process.OrderNum);
 arrValueListForInsert.Add(objwf_ProcessEN.OrderNum.ToString());
 
 if (objwf_ProcessEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.UpdDate);
 objwf_ProcessEN.UpdDate = objwf_ProcessEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.UpdDate + "'");
 }
 
 if (objwf_ProcessEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.UpdUser);
 objwf_ProcessEN.UpdUser = objwf_ProcessEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.UpdUser + "'");
 }
 
 if (objwf_ProcessEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.Memo);
 objwf_ProcessEN.Memo = objwf_ProcessEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into wf_Process");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objwf_ProcessEN.ProcessId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clswf_ProcessEN objwf_ProcessEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objwf_ProcessEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objwf_ProcessEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objwf_ProcessEN.ProcessId !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.ProcessId);
 objwf_ProcessEN.ProcessId = objwf_ProcessEN.ProcessId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.ProcessId + "'");
 }
 
 if (objwf_ProcessEN.ProcessName !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.ProcessName);
 objwf_ProcessEN.ProcessName = objwf_ProcessEN.ProcessName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.ProcessName + "'");
 }
 
 if (objwf_ProcessEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.PrjId);
 objwf_ProcessEN.PrjId = objwf_ProcessEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.PrjId + "'");
 }
 
 if (objwf_ProcessEN.EndPoint !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.EndPoint);
 objwf_ProcessEN.EndPoint = objwf_ProcessEN.EndPoint.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.EndPoint + "'");
 }
 
 if (objwf_ProcessEN.StartPoint !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.StartPoint);
 objwf_ProcessEN.StartPoint = objwf_ProcessEN.StartPoint.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.StartPoint + "'");
 }
 
 if (objwf_ProcessEN.WorkPage !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.WorkPage);
 objwf_ProcessEN.WorkPage = objwf_ProcessEN.WorkPage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.WorkPage + "'");
 }
 
 if (objwf_ProcessEN.ExamPhaseId !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.ExamPhaseId);
 objwf_ProcessEN.ExamPhaseId = objwf_ProcessEN.ExamPhaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.ExamPhaseId + "'");
 }
 
 if (objwf_ProcessEN.DefaExamDepId !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.DefaExamDepId);
 objwf_ProcessEN.DefaExamDepId = objwf_ProcessEN.DefaExamDepId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.DefaExamDepId + "'");
 }
 
 arrFieldListForInsert.Add(conwf_Process.OrderNum);
 arrValueListForInsert.Add(objwf_ProcessEN.OrderNum.ToString());
 
 if (objwf_ProcessEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.UpdDate);
 objwf_ProcessEN.UpdDate = objwf_ProcessEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.UpdDate + "'");
 }
 
 if (objwf_ProcessEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.UpdUser);
 objwf_ProcessEN.UpdUser = objwf_ProcessEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.UpdUser + "'");
 }
 
 if (objwf_ProcessEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.Memo);
 objwf_ProcessEN.Memo = objwf_ProcessEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into wf_Process");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objwf_ProcessEN.ProcessId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clswf_ProcessEN objwf_ProcessEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objwf_ProcessEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objwf_ProcessEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objwf_ProcessEN.ProcessId !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.ProcessId);
 objwf_ProcessEN.ProcessId = objwf_ProcessEN.ProcessId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.ProcessId + "'");
 }
 
 if (objwf_ProcessEN.ProcessName !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.ProcessName);
 objwf_ProcessEN.ProcessName = objwf_ProcessEN.ProcessName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.ProcessName + "'");
 }
 
 if (objwf_ProcessEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.PrjId);
 objwf_ProcessEN.PrjId = objwf_ProcessEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.PrjId + "'");
 }
 
 if (objwf_ProcessEN.EndPoint !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.EndPoint);
 objwf_ProcessEN.EndPoint = objwf_ProcessEN.EndPoint.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.EndPoint + "'");
 }
 
 if (objwf_ProcessEN.StartPoint !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.StartPoint);
 objwf_ProcessEN.StartPoint = objwf_ProcessEN.StartPoint.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.StartPoint + "'");
 }
 
 if (objwf_ProcessEN.WorkPage !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.WorkPage);
 objwf_ProcessEN.WorkPage = objwf_ProcessEN.WorkPage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.WorkPage + "'");
 }
 
 if (objwf_ProcessEN.ExamPhaseId !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.ExamPhaseId);
 objwf_ProcessEN.ExamPhaseId = objwf_ProcessEN.ExamPhaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.ExamPhaseId + "'");
 }
 
 if (objwf_ProcessEN.DefaExamDepId !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.DefaExamDepId);
 objwf_ProcessEN.DefaExamDepId = objwf_ProcessEN.DefaExamDepId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.DefaExamDepId + "'");
 }
 
 arrFieldListForInsert.Add(conwf_Process.OrderNum);
 arrValueListForInsert.Add(objwf_ProcessEN.OrderNum.ToString());
 
 if (objwf_ProcessEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.UpdDate);
 objwf_ProcessEN.UpdDate = objwf_ProcessEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.UpdDate + "'");
 }
 
 if (objwf_ProcessEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.UpdUser);
 objwf_ProcessEN.UpdUser = objwf_ProcessEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.UpdUser + "'");
 }
 
 if (objwf_ProcessEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conwf_Process.Memo);
 objwf_ProcessEN.Memo = objwf_ProcessEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objwf_ProcessEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into wf_Process");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool Addnewwf_ProcessBySP(clswf_ProcessEN objwf_ProcessEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objwf_ProcessEN.ProcessId,
 objwf_ProcessEN.ProcessName,
 objwf_ProcessEN.PrjId,
 objwf_ProcessEN.EndPoint,
 objwf_ProcessEN.StartPoint,
 objwf_ProcessEN.WorkPage,
 objwf_ProcessEN.ExamPhaseId,
 objwf_ProcessEN.DefaExamDepId,
 objwf_ProcessEN.OrderNum,
 objwf_ProcessEN.UpdDate,
 objwf_ProcessEN.UpdUser,
objwf_ProcessEN.Memo
};
 objSQL.ExecSP("wf_Process_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewwf_Processs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
strSQL = "Select * from wf_Process where ProcessId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "wf_Process");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strProcessId = oRow[conwf_Process.ProcessId].ToString().Trim();
if (IsExist(strProcessId))
{
 string strResult = "关键字变量值为:" + string.Format("ProcessId = {0}", strProcessId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clswf_ProcessEN._CurrTabName ].NewRow();
objRow[conwf_Process.ProcessId] = oRow[conwf_Process.ProcessId].ToString().Trim(); //过程ID
objRow[conwf_Process.ProcessName] = oRow[conwf_Process.ProcessName].ToString().Trim(); //过程名称
objRow[conwf_Process.PrjId] = oRow[conwf_Process.PrjId].ToString().Trim(); //工程ID
objRow[conwf_Process.EndPoint] = oRow[conwf_Process.EndPoint].ToString().Trim(); //终点
objRow[conwf_Process.StartPoint] = oRow[conwf_Process.StartPoint].ToString().Trim(); //起点
objRow[conwf_Process.WorkPage] = oRow[conwf_Process.WorkPage].ToString().Trim(); //工作页面
objRow[conwf_Process.ExamPhaseId] = oRow[conwf_Process.ExamPhaseId].ToString().Trim(); //考核阶段Id
objRow[conwf_Process.DefaExamDepId] = oRow[conwf_Process.DefaExamDepId].ToString().Trim(); //默认考核部门Id
objRow[conwf_Process.OrderNum] = oRow[conwf_Process.OrderNum].ToString().Trim(); //序号
objRow[conwf_Process.UpdDate] = oRow[conwf_Process.UpdDate].ToString().Trim(); //修改日期
objRow[conwf_Process.UpdUser] = oRow[conwf_Process.UpdUser].ToString().Trim(); //修改者
objRow[conwf_Process.Memo] = oRow[conwf_Process.Memo].ToString().Trim(); //说明
 objDS.Tables[clswf_ProcessEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clswf_ProcessEN._CurrTabName);
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
 /// <param name = "objwf_ProcessEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clswf_ProcessEN objwf_ProcessEN)
{
 if (objwf_ProcessEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objwf_ProcessEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
strSQL = "Select * from wf_Process where ProcessId = " + "'"+ objwf_ProcessEN.ProcessId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clswf_ProcessEN._CurrTabName);
if (objDS.Tables[clswf_ProcessEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ProcessId = " + "'"+ objwf_ProcessEN.ProcessId+"'");
return false;
}
objRow = objDS.Tables[clswf_ProcessEN._CurrTabName].Rows[0];
 if (objwf_ProcessEN.IsUpdated(conwf_Process.ProcessId))
 {
objRow[conwf_Process.ProcessId] = objwf_ProcessEN.ProcessId; //过程ID
 }
 if (objwf_ProcessEN.IsUpdated(conwf_Process.ProcessName))
 {
objRow[conwf_Process.ProcessName] = objwf_ProcessEN.ProcessName; //过程名称
 }
 if (objwf_ProcessEN.IsUpdated(conwf_Process.PrjId))
 {
objRow[conwf_Process.PrjId] = objwf_ProcessEN.PrjId; //工程ID
 }
 if (objwf_ProcessEN.IsUpdated(conwf_Process.EndPoint))
 {
objRow[conwf_Process.EndPoint] = objwf_ProcessEN.EndPoint; //终点
 }
 if (objwf_ProcessEN.IsUpdated(conwf_Process.StartPoint))
 {
objRow[conwf_Process.StartPoint] = objwf_ProcessEN.StartPoint; //起点
 }
 if (objwf_ProcessEN.IsUpdated(conwf_Process.WorkPage))
 {
objRow[conwf_Process.WorkPage] = objwf_ProcessEN.WorkPage; //工作页面
 }
 if (objwf_ProcessEN.IsUpdated(conwf_Process.ExamPhaseId))
 {
objRow[conwf_Process.ExamPhaseId] = objwf_ProcessEN.ExamPhaseId; //考核阶段Id
 }
 if (objwf_ProcessEN.IsUpdated(conwf_Process.DefaExamDepId))
 {
objRow[conwf_Process.DefaExamDepId] = objwf_ProcessEN.DefaExamDepId; //默认考核部门Id
 }
 if (objwf_ProcessEN.IsUpdated(conwf_Process.OrderNum))
 {
objRow[conwf_Process.OrderNum] = objwf_ProcessEN.OrderNum; //序号
 }
 if (objwf_ProcessEN.IsUpdated(conwf_Process.UpdDate))
 {
objRow[conwf_Process.UpdDate] = objwf_ProcessEN.UpdDate; //修改日期
 }
 if (objwf_ProcessEN.IsUpdated(conwf_Process.UpdUser))
 {
objRow[conwf_Process.UpdUser] = objwf_ProcessEN.UpdUser; //修改者
 }
 if (objwf_ProcessEN.IsUpdated(conwf_Process.Memo))
 {
objRow[conwf_Process.Memo] = objwf_ProcessEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clswf_ProcessEN._CurrTabName);
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
public bool UpdateBySP(clswf_ProcessEN objwf_ProcessEN)
{
 if (objwf_ProcessEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objwf_ProcessEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objwf_ProcessEN.ProcessId,
 objwf_ProcessEN.ProcessName,
 objwf_ProcessEN.PrjId,
 objwf_ProcessEN.EndPoint,
 objwf_ProcessEN.StartPoint,
 objwf_ProcessEN.WorkPage,
 objwf_ProcessEN.ExamPhaseId,
 objwf_ProcessEN.DefaExamDepId,
 objwf_ProcessEN.OrderNum,
 objwf_ProcessEN.UpdDate,
 objwf_ProcessEN.UpdUser,
 objwf_ProcessEN.Memo
};
 objSQL.ExecSP("wf_Process_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objwf_ProcessEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clswf_ProcessEN objwf_ProcessEN)
{
 if (objwf_ProcessEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objwf_ProcessEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update wf_Process Set ");
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.ProcessName))
 {
 if (objwf_ProcessEN.ProcessName !=  null)
 {
 objwf_ProcessEN.ProcessName = objwf_ProcessEN.ProcessName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.ProcessName, conwf_Process.ProcessName); //过程名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.ProcessName); //过程名称
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.PrjId))
 {
 if (objwf_ProcessEN.PrjId !=  null)
 {
 objwf_ProcessEN.PrjId = objwf_ProcessEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.PrjId, conwf_Process.PrjId); //工程ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.PrjId); //工程ID
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.EndPoint))
 {
 if (objwf_ProcessEN.EndPoint !=  null)
 {
 objwf_ProcessEN.EndPoint = objwf_ProcessEN.EndPoint.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.EndPoint, conwf_Process.EndPoint); //终点
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.EndPoint); //终点
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.StartPoint))
 {
 if (objwf_ProcessEN.StartPoint !=  null)
 {
 objwf_ProcessEN.StartPoint = objwf_ProcessEN.StartPoint.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.StartPoint, conwf_Process.StartPoint); //起点
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.StartPoint); //起点
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.WorkPage))
 {
 if (objwf_ProcessEN.WorkPage !=  null)
 {
 objwf_ProcessEN.WorkPage = objwf_ProcessEN.WorkPage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.WorkPage, conwf_Process.WorkPage); //工作页面
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.WorkPage); //工作页面
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.ExamPhaseId))
 {
 if (objwf_ProcessEN.ExamPhaseId !=  null)
 {
 objwf_ProcessEN.ExamPhaseId = objwf_ProcessEN.ExamPhaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.ExamPhaseId, conwf_Process.ExamPhaseId); //考核阶段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.ExamPhaseId); //考核阶段Id
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.DefaExamDepId))
 {
 if (objwf_ProcessEN.DefaExamDepId !=  null)
 {
 objwf_ProcessEN.DefaExamDepId = objwf_ProcessEN.DefaExamDepId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.DefaExamDepId, conwf_Process.DefaExamDepId); //默认考核部门Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.DefaExamDepId); //默认考核部门Id
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objwf_ProcessEN.OrderNum, conwf_Process.OrderNum); //序号
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.UpdDate))
 {
 if (objwf_ProcessEN.UpdDate !=  null)
 {
 objwf_ProcessEN.UpdDate = objwf_ProcessEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.UpdDate, conwf_Process.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.UpdDate); //修改日期
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.UpdUser))
 {
 if (objwf_ProcessEN.UpdUser !=  null)
 {
 objwf_ProcessEN.UpdUser = objwf_ProcessEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.UpdUser, conwf_Process.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.UpdUser); //修改者
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.Memo))
 {
 if (objwf_ProcessEN.Memo !=  null)
 {
 objwf_ProcessEN.Memo = objwf_ProcessEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.Memo, conwf_Process.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ProcessId = '{0}'", objwf_ProcessEN.ProcessId); 
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
 /// <param name = "objwf_ProcessEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clswf_ProcessEN objwf_ProcessEN, string strCondition)
{
 if (objwf_ProcessEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objwf_ProcessEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update wf_Process Set ");
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.ProcessName))
 {
 if (objwf_ProcessEN.ProcessName !=  null)
 {
 objwf_ProcessEN.ProcessName = objwf_ProcessEN.ProcessName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProcessName = '{0}',", objwf_ProcessEN.ProcessName); //过程名称
 }
 else
 {
 sbSQL.Append(" ProcessName = null,"); //过程名称
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.PrjId))
 {
 if (objwf_ProcessEN.PrjId !=  null)
 {
 objwf_ProcessEN.PrjId = objwf_ProcessEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", objwf_ProcessEN.PrjId); //工程ID
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程ID
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.EndPoint))
 {
 if (objwf_ProcessEN.EndPoint !=  null)
 {
 objwf_ProcessEN.EndPoint = objwf_ProcessEN.EndPoint.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EndPoint = '{0}',", objwf_ProcessEN.EndPoint); //终点
 }
 else
 {
 sbSQL.Append(" EndPoint = null,"); //终点
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.StartPoint))
 {
 if (objwf_ProcessEN.StartPoint !=  null)
 {
 objwf_ProcessEN.StartPoint = objwf_ProcessEN.StartPoint.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StartPoint = '{0}',", objwf_ProcessEN.StartPoint); //起点
 }
 else
 {
 sbSQL.Append(" StartPoint = null,"); //起点
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.WorkPage))
 {
 if (objwf_ProcessEN.WorkPage !=  null)
 {
 objwf_ProcessEN.WorkPage = objwf_ProcessEN.WorkPage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkPage = '{0}',", objwf_ProcessEN.WorkPage); //工作页面
 }
 else
 {
 sbSQL.Append(" WorkPage = null,"); //工作页面
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.ExamPhaseId))
 {
 if (objwf_ProcessEN.ExamPhaseId !=  null)
 {
 objwf_ProcessEN.ExamPhaseId = objwf_ProcessEN.ExamPhaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamPhaseId = '{0}',", objwf_ProcessEN.ExamPhaseId); //考核阶段Id
 }
 else
 {
 sbSQL.Append(" ExamPhaseId = null,"); //考核阶段Id
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.DefaExamDepId))
 {
 if (objwf_ProcessEN.DefaExamDepId !=  null)
 {
 objwf_ProcessEN.DefaExamDepId = objwf_ProcessEN.DefaExamDepId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaExamDepId = '{0}',", objwf_ProcessEN.DefaExamDepId); //默认考核部门Id
 }
 else
 {
 sbSQL.Append(" DefaExamDepId = null,"); //默认考核部门Id
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objwf_ProcessEN.OrderNum); //序号
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.UpdDate))
 {
 if (objwf_ProcessEN.UpdDate !=  null)
 {
 objwf_ProcessEN.UpdDate = objwf_ProcessEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", objwf_ProcessEN.UpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.UpdUser))
 {
 if (objwf_ProcessEN.UpdUser !=  null)
 {
 objwf_ProcessEN.UpdUser = objwf_ProcessEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", objwf_ProcessEN.UpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.Memo))
 {
 if (objwf_ProcessEN.Memo !=  null)
 {
 objwf_ProcessEN.Memo = objwf_ProcessEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objwf_ProcessEN.Memo); //说明
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
 /// <param name = "objwf_ProcessEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clswf_ProcessEN objwf_ProcessEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objwf_ProcessEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objwf_ProcessEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update wf_Process Set ");
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.ProcessName))
 {
 if (objwf_ProcessEN.ProcessName !=  null)
 {
 objwf_ProcessEN.ProcessName = objwf_ProcessEN.ProcessName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProcessName = '{0}',", objwf_ProcessEN.ProcessName); //过程名称
 }
 else
 {
 sbSQL.Append(" ProcessName = null,"); //过程名称
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.PrjId))
 {
 if (objwf_ProcessEN.PrjId !=  null)
 {
 objwf_ProcessEN.PrjId = objwf_ProcessEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", objwf_ProcessEN.PrjId); //工程ID
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程ID
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.EndPoint))
 {
 if (objwf_ProcessEN.EndPoint !=  null)
 {
 objwf_ProcessEN.EndPoint = objwf_ProcessEN.EndPoint.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EndPoint = '{0}',", objwf_ProcessEN.EndPoint); //终点
 }
 else
 {
 sbSQL.Append(" EndPoint = null,"); //终点
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.StartPoint))
 {
 if (objwf_ProcessEN.StartPoint !=  null)
 {
 objwf_ProcessEN.StartPoint = objwf_ProcessEN.StartPoint.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StartPoint = '{0}',", objwf_ProcessEN.StartPoint); //起点
 }
 else
 {
 sbSQL.Append(" StartPoint = null,"); //起点
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.WorkPage))
 {
 if (objwf_ProcessEN.WorkPage !=  null)
 {
 objwf_ProcessEN.WorkPage = objwf_ProcessEN.WorkPage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WorkPage = '{0}',", objwf_ProcessEN.WorkPage); //工作页面
 }
 else
 {
 sbSQL.Append(" WorkPage = null,"); //工作页面
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.ExamPhaseId))
 {
 if (objwf_ProcessEN.ExamPhaseId !=  null)
 {
 objwf_ProcessEN.ExamPhaseId = objwf_ProcessEN.ExamPhaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamPhaseId = '{0}',", objwf_ProcessEN.ExamPhaseId); //考核阶段Id
 }
 else
 {
 sbSQL.Append(" ExamPhaseId = null,"); //考核阶段Id
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.DefaExamDepId))
 {
 if (objwf_ProcessEN.DefaExamDepId !=  null)
 {
 objwf_ProcessEN.DefaExamDepId = objwf_ProcessEN.DefaExamDepId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaExamDepId = '{0}',", objwf_ProcessEN.DefaExamDepId); //默认考核部门Id
 }
 else
 {
 sbSQL.Append(" DefaExamDepId = null,"); //默认考核部门Id
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objwf_ProcessEN.OrderNum); //序号
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.UpdDate))
 {
 if (objwf_ProcessEN.UpdDate !=  null)
 {
 objwf_ProcessEN.UpdDate = objwf_ProcessEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", objwf_ProcessEN.UpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.UpdUser))
 {
 if (objwf_ProcessEN.UpdUser !=  null)
 {
 objwf_ProcessEN.UpdUser = objwf_ProcessEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", objwf_ProcessEN.UpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.Memo))
 {
 if (objwf_ProcessEN.Memo !=  null)
 {
 objwf_ProcessEN.Memo = objwf_ProcessEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objwf_ProcessEN.Memo); //说明
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
 /// <param name = "objwf_ProcessEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clswf_ProcessEN objwf_ProcessEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objwf_ProcessEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objwf_ProcessEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update wf_Process Set ");
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.ProcessName))
 {
 if (objwf_ProcessEN.ProcessName !=  null)
 {
 objwf_ProcessEN.ProcessName = objwf_ProcessEN.ProcessName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.ProcessName, conwf_Process.ProcessName); //过程名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.ProcessName); //过程名称
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.PrjId))
 {
 if (objwf_ProcessEN.PrjId !=  null)
 {
 objwf_ProcessEN.PrjId = objwf_ProcessEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.PrjId, conwf_Process.PrjId); //工程ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.PrjId); //工程ID
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.EndPoint))
 {
 if (objwf_ProcessEN.EndPoint !=  null)
 {
 objwf_ProcessEN.EndPoint = objwf_ProcessEN.EndPoint.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.EndPoint, conwf_Process.EndPoint); //终点
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.EndPoint); //终点
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.StartPoint))
 {
 if (objwf_ProcessEN.StartPoint !=  null)
 {
 objwf_ProcessEN.StartPoint = objwf_ProcessEN.StartPoint.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.StartPoint, conwf_Process.StartPoint); //起点
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.StartPoint); //起点
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.WorkPage))
 {
 if (objwf_ProcessEN.WorkPage !=  null)
 {
 objwf_ProcessEN.WorkPage = objwf_ProcessEN.WorkPage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.WorkPage, conwf_Process.WorkPage); //工作页面
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.WorkPage); //工作页面
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.ExamPhaseId))
 {
 if (objwf_ProcessEN.ExamPhaseId !=  null)
 {
 objwf_ProcessEN.ExamPhaseId = objwf_ProcessEN.ExamPhaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.ExamPhaseId, conwf_Process.ExamPhaseId); //考核阶段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.ExamPhaseId); //考核阶段Id
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.DefaExamDepId))
 {
 if (objwf_ProcessEN.DefaExamDepId !=  null)
 {
 objwf_ProcessEN.DefaExamDepId = objwf_ProcessEN.DefaExamDepId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.DefaExamDepId, conwf_Process.DefaExamDepId); //默认考核部门Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.DefaExamDepId); //默认考核部门Id
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objwf_ProcessEN.OrderNum, conwf_Process.OrderNum); //序号
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.UpdDate))
 {
 if (objwf_ProcessEN.UpdDate !=  null)
 {
 objwf_ProcessEN.UpdDate = objwf_ProcessEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.UpdDate, conwf_Process.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.UpdDate); //修改日期
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.UpdUser))
 {
 if (objwf_ProcessEN.UpdUser !=  null)
 {
 objwf_ProcessEN.UpdUser = objwf_ProcessEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.UpdUser, conwf_Process.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.UpdUser); //修改者
 }
 }
 
 if (objwf_ProcessEN.IsUpdated(conwf_Process.Memo))
 {
 if (objwf_ProcessEN.Memo !=  null)
 {
 objwf_ProcessEN.Memo = objwf_ProcessEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objwf_ProcessEN.Memo, conwf_Process.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conwf_Process.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ProcessId = '{0}'", objwf_ProcessEN.ProcessId); 
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
 /// <param name = "strProcessId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strProcessId) 
{
CheckPrimaryKey(strProcessId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strProcessId,
};
 objSQL.ExecSP("wf_Process_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strProcessId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strProcessId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strProcessId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
//删除wf_Process本表中与当前对象有关的记录
strSQL = strSQL + "Delete from wf_Process where ProcessId = " + "'"+ strProcessId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delwf_Process(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
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
//删除wf_Process本表中与当前对象有关的记录
strSQL = strSQL + "Delete from wf_Process where ProcessId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strProcessId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strProcessId) 
{
CheckPrimaryKey(strProcessId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
//删除wf_Process本表中与当前对象有关的记录
strSQL = strSQL + "Delete from wf_Process where ProcessId = " + "'"+ strProcessId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delwf_Process(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clswf_ProcessDA: Delwf_Process)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from wf_Process where " + strCondition ;
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
public bool Delwf_ProcessWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clswf_ProcessDA: Delwf_ProcessWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from wf_Process where " + strCondition ;
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
 /// <param name = "objwf_ProcessENS">源对象</param>
 /// <param name = "objwf_ProcessENT">目标对象</param>
public void CopyTo(clswf_ProcessEN objwf_ProcessENS, clswf_ProcessEN objwf_ProcessENT)
{
objwf_ProcessENT.ProcessId = objwf_ProcessENS.ProcessId; //过程ID
objwf_ProcessENT.ProcessName = objwf_ProcessENS.ProcessName; //过程名称
objwf_ProcessENT.PrjId = objwf_ProcessENS.PrjId; //工程ID
objwf_ProcessENT.EndPoint = objwf_ProcessENS.EndPoint; //终点
objwf_ProcessENT.StartPoint = objwf_ProcessENS.StartPoint; //起点
objwf_ProcessENT.WorkPage = objwf_ProcessENS.WorkPage; //工作页面
objwf_ProcessENT.ExamPhaseId = objwf_ProcessENS.ExamPhaseId; //考核阶段Id
objwf_ProcessENT.DefaExamDepId = objwf_ProcessENS.DefaExamDepId; //默认考核部门Id
objwf_ProcessENT.OrderNum = objwf_ProcessENS.OrderNum; //序号
objwf_ProcessENT.UpdDate = objwf_ProcessENS.UpdDate; //修改日期
objwf_ProcessENT.UpdUser = objwf_ProcessENS.UpdUser; //修改者
objwf_ProcessENT.Memo = objwf_ProcessENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clswf_ProcessEN objwf_ProcessEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objwf_ProcessEN.ProcessName, conwf_Process.ProcessName);
clsCheckSql.CheckFieldNotNull(objwf_ProcessEN.PrjId, conwf_Process.PrjId);
clsCheckSql.CheckFieldNotNull(objwf_ProcessEN.EndPoint, conwf_Process.EndPoint);
clsCheckSql.CheckFieldNotNull(objwf_ProcessEN.StartPoint, conwf_Process.StartPoint);
//检查字段长度
clsCheckSql.CheckFieldLen(objwf_ProcessEN.ProcessId, 8, conwf_Process.ProcessId);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.ProcessName, 100, conwf_Process.ProcessName);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.PrjId, 4, conwf_Process.PrjId);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.EndPoint, 8, conwf_Process.EndPoint);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.StartPoint, 8, conwf_Process.StartPoint);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.WorkPage, 500, conwf_Process.WorkPage);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.ExamPhaseId, 2, conwf_Process.ExamPhaseId);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.DefaExamDepId, 6, conwf_Process.DefaExamDepId);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.UpdDate, 20, conwf_Process.UpdDate);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.UpdUser, 20, conwf_Process.UpdUser);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.Memo, 1000, conwf_Process.Memo);
//检查字段外键固定长度
 objwf_ProcessEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clswf_ProcessEN objwf_ProcessEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objwf_ProcessEN.ProcessName, 100, conwf_Process.ProcessName);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.PrjId, 4, conwf_Process.PrjId);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.EndPoint, 8, conwf_Process.EndPoint);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.StartPoint, 8, conwf_Process.StartPoint);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.WorkPage, 500, conwf_Process.WorkPage);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.ExamPhaseId, 2, conwf_Process.ExamPhaseId);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.DefaExamDepId, 6, conwf_Process.DefaExamDepId);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.UpdDate, 20, conwf_Process.UpdDate);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.UpdUser, 20, conwf_Process.UpdUser);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.Memo, 1000, conwf_Process.Memo);
//检查外键字段长度
 objwf_ProcessEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clswf_ProcessEN objwf_ProcessEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objwf_ProcessEN.ProcessId, 8, conwf_Process.ProcessId);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.ProcessName, 100, conwf_Process.ProcessName);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.PrjId, 4, conwf_Process.PrjId);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.EndPoint, 8, conwf_Process.EndPoint);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.StartPoint, 8, conwf_Process.StartPoint);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.WorkPage, 500, conwf_Process.WorkPage);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.ExamPhaseId, 2, conwf_Process.ExamPhaseId);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.DefaExamDepId, 6, conwf_Process.DefaExamDepId);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.UpdDate, 20, conwf_Process.UpdDate);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.UpdUser, 20, conwf_Process.UpdUser);
clsCheckSql.CheckFieldLen(objwf_ProcessEN.Memo, 1000, conwf_Process.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objwf_ProcessEN.ProcessId, conwf_Process.ProcessId);
clsCheckSql.CheckSqlInjection4Field(objwf_ProcessEN.ProcessName, conwf_Process.ProcessName);
clsCheckSql.CheckSqlInjection4Field(objwf_ProcessEN.PrjId, conwf_Process.PrjId);
clsCheckSql.CheckSqlInjection4Field(objwf_ProcessEN.EndPoint, conwf_Process.EndPoint);
clsCheckSql.CheckSqlInjection4Field(objwf_ProcessEN.StartPoint, conwf_Process.StartPoint);
clsCheckSql.CheckSqlInjection4Field(objwf_ProcessEN.WorkPage, conwf_Process.WorkPage);
clsCheckSql.CheckSqlInjection4Field(objwf_ProcessEN.ExamPhaseId, conwf_Process.ExamPhaseId);
clsCheckSql.CheckSqlInjection4Field(objwf_ProcessEN.DefaExamDepId, conwf_Process.DefaExamDepId);
clsCheckSql.CheckSqlInjection4Field(objwf_ProcessEN.UpdDate, conwf_Process.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objwf_ProcessEN.UpdUser, conwf_Process.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objwf_ProcessEN.Memo, conwf_Process.Memo);
//检查外键字段长度
 objwf_ProcessEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetProcessId()
{
//获取某学院所有专业信息
string strSQL = "select ProcessId, ProcessName from wf_Process ";
 clsSpecSQLforSql mySql = clswf_ProcessDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--wf_Process(工作流过程),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objwf_ProcessEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStrProcessName_PrjId(clswf_ProcessEN objwf_ProcessEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ProcessName = '{0}'", objwf_ProcessEN.ProcessName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objwf_ProcessEN.PrjId);
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
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
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
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
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
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clswf_ProcessEN._CurrTabName);
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
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clswf_ProcessEN._CurrTabName, strCondition);
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
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
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
 objSQL = clswf_ProcessDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}