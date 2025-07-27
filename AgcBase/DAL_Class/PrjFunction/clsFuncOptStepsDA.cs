
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncOptStepsDA
 表名:FuncOptSteps(00050062)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:14:32
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcWeb(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// 函数操作步骤(FuncOptSteps)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsFuncOptStepsDA : clsCommBase4DA
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
 return clsFuncOptStepsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFuncOptStepsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFuncOptStepsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFuncOptStepsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFuncOptStepsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
 strSQL = "Select * from FuncOptSteps where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "FuncOptSteps");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("FuncOptSteps_SelectByCond",values, "FuncOptSteps");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FuncOptSteps where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "FuncOptSteps");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFuncOptStepsDA: GetFuncOptStepsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFuncOptStepsDA: GetFuncOptStepsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFuncOptStepsDA: GetFuncOptStepsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from FuncOptSteps a where {0} And a.mId not in (Select Top {2} mId From FuncOptSteps Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "FuncOptSteps");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFuncOptStepsDA: GetFuncOptStepsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFuncOptStepsDA: GetFuncOptStepsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFuncOptStepsDA: GetFuncOptStepsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from FuncOptSteps a where {0} And a.mId not in (Select Top {2} mId From FuncOptSteps Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "FuncOptSteps");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFuncOptStepsDA: GetFuncOptStepsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFuncOptStepsDA: GetFuncOptStepsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFuncOptStepsDA: GetFuncOptStepsByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from FuncOptSteps a where {0} And a.mId not in (Select Top {2} mId From FuncOptSteps Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "FuncOptSteps");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from FuncOptSteps where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FuncOptSteps(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataTable_FuncOptSteps)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from FuncOptSteps where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from FuncOptSteps where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from FuncOptSteps where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FuncOptSteps where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FuncOptSteps where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FuncOptSteps where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FuncOptSteps where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FuncOptSteps.* from FuncOptSteps Left Join {1} on {2} where {3} and FuncOptSteps.mId not in (Select top {5} FuncOptSteps.mId from FuncOptSteps Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FuncOptSteps where {1} and mId not in (Select top {2} mId from FuncOptSteps where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FuncOptSteps where {1} and mId not in (Select top {3} mId from FuncOptSteps where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FuncOptSteps.* from FuncOptSteps Left Join {1} on {2} where {3} and FuncOptSteps.mId not in (Select top {5} FuncOptSteps.mId from FuncOptSteps Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FuncOptSteps where {1} and mId not in (Select top {2} mId from FuncOptSteps where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FuncOptSteps where {1} and mId not in (Select top {3} mId from FuncOptSteps where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FuncOptSteps.* from FuncOptSteps Left Join {1} on {2} where {3} and FuncOptSteps.mId not in (Select top {5} FuncOptSteps.mId from FuncOptSteps Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FuncOptSteps where {1} and mId not in (Select top {2} mId from FuncOptSteps where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FuncOptSteps where {1} and mId not in (Select top {3} mId from FuncOptSteps where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFuncOptStepsDA: GetFuncOptStepsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFuncOptStepsDA: GetFuncOptStepsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFuncOptStepsDA: GetFuncOptStepsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from FuncOptSteps a where {0} And a.mId not in (Select Top {2} mId From FuncOptSteps Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from FuncOptSteps a where {0} And a.mId not in (Select Top {2} mId From FuncOptSteps Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFuncOptStepsDA: GetFuncOptStepsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFuncOptStepsDA: GetFuncOptStepsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFuncOptStepsDA: GetFuncOptStepsByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from FuncOptSteps a where {0} And a.mId not in (Select Top {2} mId From FuncOptSteps Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from FuncOptSteps a where {0} And a.mId not in (Select Top {2} mId From FuncOptSteps Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFuncOptStepsDA: GetFuncOptStepsByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFuncOptStepsDA: GetFuncOptStepsByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFuncOptStepsDA: GetFuncOptStepsByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from FuncOptSteps where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("FuncOptSteps_SelectByCond",values);
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
public List<clsFuncOptStepsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFuncOptStepsDA:GetObjLst)", objException.Message));
}
List<clsFuncOptStepsEN> arrObjLst = new List<clsFuncOptStepsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from FuncOptSteps where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
try
{
objFuncOptStepsEN.mId = TransNullToInt(objRow[conFuncOptSteps.mId].ToString().Trim()); //mId
objFuncOptStepsEN.FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID
objFuncOptStepsEN.StepIndex = TransNullToInt(objRow[conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex
objFuncOptStepsEN.StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName
objFuncOptStepsEN.StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode
objFuncOptStepsEN.StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail
objFuncOptStepsEN.IsTemplate = TransNullToBool(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFuncOptStepsDA: GetObjLst)", objException.Message));
}
objFuncOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFuncOptStepsEN);
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
public List<clsFuncOptStepsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFuncOptStepsDA:GetObjLstByTabName)", objException.Message));
}
List<clsFuncOptStepsEN> arrObjLst = new List<clsFuncOptStepsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
try
{
objFuncOptStepsEN.mId = TransNullToInt(objRow[conFuncOptSteps.mId].ToString().Trim()); //mId
objFuncOptStepsEN.FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID
objFuncOptStepsEN.StepIndex = TransNullToInt(objRow[conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex
objFuncOptStepsEN.StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName
objFuncOptStepsEN.StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode
objFuncOptStepsEN.StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail
objFuncOptStepsEN.IsTemplate = TransNullToBool(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFuncOptStepsDA: GetObjLst)", objException.Message));
}
objFuncOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFuncOptStepsEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsFuncOptStepsEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsFuncOptStepsDA:GetObjLstBySP)", objException.Message));
}
List<clsFuncOptStepsEN> arrObjLst = new List<clsFuncOptStepsEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("FuncOptSteps_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
try
{
objFuncOptStepsEN.mId = TransNullToInt(objRow[conFuncOptSteps.mId].ToString().Trim()); //mId
objFuncOptStepsEN.FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID
objFuncOptStepsEN.StepIndex = TransNullToInt(objRow[conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex
objFuncOptStepsEN.StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName
objFuncOptStepsEN.StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode
objFuncOptStepsEN.StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail
objFuncOptStepsEN.IsTemplate = TransNullToBool(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsFuncOptStepsDA: GetObjLstBySP)", objException.Message));
}
objFuncOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFuncOptStepsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFuncOptSteps(ref clsFuncOptStepsEN objFuncOptStepsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from FuncOptSteps where mId = " + ""+ objFuncOptStepsEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFuncOptStepsEN.mId = TransNullToInt(objDT.Rows[0][conFuncOptSteps.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objFuncOptStepsEN.FuncId = objDT.Rows[0][conFuncOptSteps.FuncId].ToString().Trim(); //函数ID(字段类型:varchar,字段长度:10,是否可空:False)
 objFuncOptStepsEN.StepIndex = TransNullToInt(objDT.Rows[0][conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex(字段类型:int,字段长度:4,是否可空:False)
 objFuncOptStepsEN.StepName = objDT.Rows[0][conFuncOptSteps.StepName].ToString().Trim(); //StepName(字段类型:varchar,字段长度:50,是否可空:False)
 objFuncOptStepsEN.StepCode = objDT.Rows[0][conFuncOptSteps.StepCode].ToString().Trim(); //StepCode(字段类型:varchar,字段长度:1000,是否可空:True)
 objFuncOptStepsEN.StepDetail = objDT.Rows[0][conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail(字段类型:varchar,字段长度:1000,是否可空:True)
 objFuncOptStepsEN.IsTemplate = TransNullToBool(objDT.Rows[0][conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFuncOptStepsDA: GetFuncOptSteps)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsFuncOptStepsEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from FuncOptSteps where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
try
{
 objFuncOptStepsEN.mId = Int32.Parse(objRow[conFuncOptSteps.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objFuncOptStepsEN.FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID(字段类型:varchar,字段长度:10,是否可空:False)
 objFuncOptStepsEN.StepIndex = Int32.Parse(objRow[conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex(字段类型:int,字段长度:4,是否可空:False)
 objFuncOptStepsEN.StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName(字段类型:varchar,字段长度:50,是否可空:False)
 objFuncOptStepsEN.StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode(字段类型:varchar,字段长度:1000,是否可空:True)
 objFuncOptStepsEN.StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail(字段类型:varchar,字段长度:1000,是否可空:True)
 objFuncOptStepsEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFuncOptStepsDA: GetObjBymId)", objException.Message));
}
return objFuncOptStepsEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程FuncOptSteps_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFuncOptStepsOneBySP(clsFuncOptStepsEN objFuncOptStepsEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objFuncOptStepsEN.mId
};
 objDT = objSQL.ExecSpReturnDT("FuncOptSteps_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objFuncOptStepsEN.mId = TransNullToInt(objDT.Rows[0][conFuncOptSteps.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objFuncOptStepsEN.FuncId = objDT.Rows[0][conFuncOptSteps.FuncId].ToString().Trim(); //函数ID(字段类型:varchar,字段长度:10,是否可空:False)
 objFuncOptStepsEN.StepIndex = TransNullToInt(objDT.Rows[0][conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex(字段类型:int,字段长度:4,是否可空:False)
 objFuncOptStepsEN.StepName = objDT.Rows[0][conFuncOptSteps.StepName].ToString().Trim(); //StepName(字段类型:varchar,字段长度:50,是否可空:False)
 objFuncOptStepsEN.StepCode = objDT.Rows[0][conFuncOptSteps.StepCode].ToString().Trim(); //StepCode(字段类型:varchar,字段长度:1000,是否可空:True)
 objFuncOptStepsEN.StepDetail = objDT.Rows[0][conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail(字段类型:varchar,字段长度:1000,是否可空:True)
 objFuncOptStepsEN.IsTemplate = TransNullToBool(objDT.Rows[0][conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFuncOptStepsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from FuncOptSteps where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN()
{
mId = TransNullToInt(objRow[conFuncOptSteps.mId].ToString().Trim()), //mId
FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(), //函数ID
StepIndex = TransNullToInt(objRow[conFuncOptSteps.StepIndex].ToString().Trim()), //StepIndex
StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(), //StepName
StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(), //StepCode
StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(), //StepDetail
IsTemplate = TransNullToBool(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()) //是否模板
};
objFuncOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFuncOptStepsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFuncOptStepsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFuncOptStepsEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsFuncOptStepsDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("FuncOptSteps_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN()
{
mId = TransNullToInt(objRow[conFuncOptSteps.mId].ToString().Trim()), //mId
FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(), //函数ID
StepIndex = TransNullToInt(objRow[conFuncOptSteps.StepIndex].ToString().Trim()), //StepIndex
StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(), //StepName
StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(), //StepCode
StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(), //StepDetail
IsTemplate = TransNullToBool(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()) //是否模板
};
objFuncOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFuncOptStepsEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFuncOptStepsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
try
{
objFuncOptStepsEN.mId = TransNullToInt(objRow[conFuncOptSteps.mId].ToString().Trim()); //mId
objFuncOptStepsEN.FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID
objFuncOptStepsEN.StepIndex = TransNullToInt(objRow[conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex
objFuncOptStepsEN.StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName
objFuncOptStepsEN.StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode
objFuncOptStepsEN.StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail
objFuncOptStepsEN.IsTemplate = TransNullToBool(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFuncOptStepsDA: GetObjByDataRowFuncOptSteps)", objException.Message));
}
objFuncOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFuncOptStepsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFuncOptStepsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFuncOptStepsEN objFuncOptStepsEN = new clsFuncOptStepsEN();
try
{
objFuncOptStepsEN.mId = TransNullToInt(objRow[conFuncOptSteps.mId].ToString().Trim()); //mId
objFuncOptStepsEN.FuncId = objRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID
objFuncOptStepsEN.StepIndex = TransNullToInt(objRow[conFuncOptSteps.StepIndex].ToString().Trim()); //StepIndex
objFuncOptStepsEN.StepName = objRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName
objFuncOptStepsEN.StepCode = objRow[conFuncOptSteps.StepCode] == DBNull.Value ? null : objRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode
objFuncOptStepsEN.StepDetail = objRow[conFuncOptSteps.StepDetail] == DBNull.Value ? null : objRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail
objFuncOptStepsEN.IsTemplate = TransNullToBool(objRow[conFuncOptSteps.IsTemplate].ToString().Trim()); //是否模板
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFuncOptStepsDA: GetObjByDataRow)", objException.Message));
}
objFuncOptStepsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFuncOptStepsEN;
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
objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFuncOptStepsEN._CurrTabName, conFuncOptSteps.mId, 8, "");
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
objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFuncOptStepsEN._CurrTabName, conFuncOptSteps.mId, 8, strPrefix);
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
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from FuncOptSteps where " + strCondition;
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
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from FuncOptSteps where " + strCondition;
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
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FuncOptSteps", "mId = " + ""+ lngmId+""))
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
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
lngmId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("FuncOptSteps_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFuncOptStepsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FuncOptSteps", strCondition))
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
objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FuncOptSteps");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFuncOptStepsEN objFuncOptStepsEN)
 {
 if (objFuncOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncOptStepsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from FuncOptSteps where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FuncOptSteps");
objRow = objDS.Tables["FuncOptSteps"].NewRow();
objRow[conFuncOptSteps.FuncId] = objFuncOptStepsEN.FuncId; //函数ID
objRow[conFuncOptSteps.StepIndex] = objFuncOptStepsEN.StepIndex; //StepIndex
objRow[conFuncOptSteps.StepName] = objFuncOptStepsEN.StepName; //StepName
 if (objFuncOptStepsEN.StepCode !=  "")
 {
objRow[conFuncOptSteps.StepCode] = objFuncOptStepsEN.StepCode; //StepCode
 }
 if (objFuncOptStepsEN.StepDetail !=  "")
 {
objRow[conFuncOptSteps.StepDetail] = objFuncOptStepsEN.StepDetail; //StepDetail
 }
objRow[conFuncOptSteps.IsTemplate] = objFuncOptStepsEN.IsTemplate; //是否模板
objDS.Tables[clsFuncOptStepsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFuncOptStepsEN._CurrTabName);
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
 /// <param name = "objFuncOptStepsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFuncOptStepsEN objFuncOptStepsEN)
{
 if (objFuncOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncOptStepsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFuncOptStepsEN.FuncId !=  null)
 {
 arrFieldListForInsert.Add(conFuncOptSteps.FuncId);
 objFuncOptStepsEN.FuncId = objFuncOptStepsEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFuncOptStepsEN.FuncId + "'");
 }
 
 arrFieldListForInsert.Add(conFuncOptSteps.StepIndex);
 arrValueListForInsert.Add(objFuncOptStepsEN.StepIndex.ToString());
 
 if (objFuncOptStepsEN.StepName !=  null)
 {
 arrFieldListForInsert.Add(conFuncOptSteps.StepName);
 objFuncOptStepsEN.StepName = objFuncOptStepsEN.StepName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFuncOptStepsEN.StepName + "'");
 }
 
 if (objFuncOptStepsEN.StepCode !=  null)
 {
 arrFieldListForInsert.Add(conFuncOptSteps.StepCode);
 objFuncOptStepsEN.StepCode = objFuncOptStepsEN.StepCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFuncOptStepsEN.StepCode + "'");
 }
 
 if (objFuncOptStepsEN.StepDetail !=  null)
 {
 arrFieldListForInsert.Add(conFuncOptSteps.StepDetail);
 objFuncOptStepsEN.StepDetail = objFuncOptStepsEN.StepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFuncOptStepsEN.StepDetail + "'");
 }
 
 arrFieldListForInsert.Add(conFuncOptSteps.IsTemplate);
 arrValueListForInsert.Add("'" + (objFuncOptStepsEN.IsTemplate  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncOptSteps");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFuncOptStepsEN objFuncOptStepsEN)
{
 if (objFuncOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncOptStepsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFuncOptStepsEN.FuncId !=  null)
 {
 arrFieldListForInsert.Add(conFuncOptSteps.FuncId);
 objFuncOptStepsEN.FuncId = objFuncOptStepsEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFuncOptStepsEN.FuncId + "'");
 }
 
 arrFieldListForInsert.Add(conFuncOptSteps.StepIndex);
 arrValueListForInsert.Add(objFuncOptStepsEN.StepIndex.ToString());
 
 if (objFuncOptStepsEN.StepName !=  null)
 {
 arrFieldListForInsert.Add(conFuncOptSteps.StepName);
 objFuncOptStepsEN.StepName = objFuncOptStepsEN.StepName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFuncOptStepsEN.StepName + "'");
 }
 
 if (objFuncOptStepsEN.StepCode !=  null)
 {
 arrFieldListForInsert.Add(conFuncOptSteps.StepCode);
 objFuncOptStepsEN.StepCode = objFuncOptStepsEN.StepCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFuncOptStepsEN.StepCode + "'");
 }
 
 if (objFuncOptStepsEN.StepDetail !=  null)
 {
 arrFieldListForInsert.Add(conFuncOptSteps.StepDetail);
 objFuncOptStepsEN.StepDetail = objFuncOptStepsEN.StepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFuncOptStepsEN.StepDetail + "'");
 }
 
 arrFieldListForInsert.Add(conFuncOptSteps.IsTemplate);
 arrValueListForInsert.Add("'" + (objFuncOptStepsEN.IsTemplate  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncOptSteps");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFuncOptStepsEN objFuncOptStepsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFuncOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncOptStepsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFuncOptStepsEN.FuncId !=  null)
 {
 arrFieldListForInsert.Add(conFuncOptSteps.FuncId);
 objFuncOptStepsEN.FuncId = objFuncOptStepsEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFuncOptStepsEN.FuncId + "'");
 }
 
 arrFieldListForInsert.Add(conFuncOptSteps.StepIndex);
 arrValueListForInsert.Add(objFuncOptStepsEN.StepIndex.ToString());
 
 if (objFuncOptStepsEN.StepName !=  null)
 {
 arrFieldListForInsert.Add(conFuncOptSteps.StepName);
 objFuncOptStepsEN.StepName = objFuncOptStepsEN.StepName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFuncOptStepsEN.StepName + "'");
 }
 
 if (objFuncOptStepsEN.StepCode !=  null)
 {
 arrFieldListForInsert.Add(conFuncOptSteps.StepCode);
 objFuncOptStepsEN.StepCode = objFuncOptStepsEN.StepCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFuncOptStepsEN.StepCode + "'");
 }
 
 if (objFuncOptStepsEN.StepDetail !=  null)
 {
 arrFieldListForInsert.Add(conFuncOptSteps.StepDetail);
 objFuncOptStepsEN.StepDetail = objFuncOptStepsEN.StepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFuncOptStepsEN.StepDetail + "'");
 }
 
 arrFieldListForInsert.Add(conFuncOptSteps.IsTemplate);
 arrValueListForInsert.Add("'" + (objFuncOptStepsEN.IsTemplate  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncOptSteps");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFuncOptStepsEN objFuncOptStepsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objFuncOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncOptStepsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFuncOptStepsEN.FuncId !=  null)
 {
 arrFieldListForInsert.Add(conFuncOptSteps.FuncId);
 objFuncOptStepsEN.FuncId = objFuncOptStepsEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFuncOptStepsEN.FuncId + "'");
 }
 
 arrFieldListForInsert.Add(conFuncOptSteps.StepIndex);
 arrValueListForInsert.Add(objFuncOptStepsEN.StepIndex.ToString());
 
 if (objFuncOptStepsEN.StepName !=  null)
 {
 arrFieldListForInsert.Add(conFuncOptSteps.StepName);
 objFuncOptStepsEN.StepName = objFuncOptStepsEN.StepName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFuncOptStepsEN.StepName + "'");
 }
 
 if (objFuncOptStepsEN.StepCode !=  null)
 {
 arrFieldListForInsert.Add(conFuncOptSteps.StepCode);
 objFuncOptStepsEN.StepCode = objFuncOptStepsEN.StepCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFuncOptStepsEN.StepCode + "'");
 }
 
 if (objFuncOptStepsEN.StepDetail !=  null)
 {
 arrFieldListForInsert.Add(conFuncOptSteps.StepDetail);
 objFuncOptStepsEN.StepDetail = objFuncOptStepsEN.StepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFuncOptStepsEN.StepDetail + "'");
 }
 
 arrFieldListForInsert.Add(conFuncOptSteps.IsTemplate);
 arrValueListForInsert.Add("'" + (objFuncOptStepsEN.IsTemplate  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncOptSteps");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewFuncOptStepsBySP(clsFuncOptStepsEN objFuncOptStepsEN)
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objFuncOptStepsEN.FuncId,
 objFuncOptStepsEN.StepIndex,
 objFuncOptStepsEN.StepName,
 objFuncOptStepsEN.StepCode,
 objFuncOptStepsEN.StepDetail,
objFuncOptStepsEN.IsTemplate
};
 objSQL.ExecSP("FuncOptSteps_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFuncOptStepss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from FuncOptSteps where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FuncOptSteps");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conFuncOptSteps.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFuncOptStepsEN._CurrTabName ].NewRow();
objRow[conFuncOptSteps.FuncId] = oRow[conFuncOptSteps.FuncId].ToString().Trim(); //函数ID
objRow[conFuncOptSteps.StepIndex] = oRow[conFuncOptSteps.StepIndex].ToString().Trim(); //StepIndex
objRow[conFuncOptSteps.StepName] = oRow[conFuncOptSteps.StepName].ToString().Trim(); //StepName
objRow[conFuncOptSteps.StepCode] = oRow[conFuncOptSteps.StepCode].ToString().Trim(); //StepCode
objRow[conFuncOptSteps.StepDetail] = oRow[conFuncOptSteps.StepDetail].ToString().Trim(); //StepDetail
objRow[conFuncOptSteps.IsTemplate] = oRow[conFuncOptSteps.IsTemplate].ToString().Trim(); //是否模板
 objDS.Tables[clsFuncOptStepsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFuncOptStepsEN._CurrTabName);
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
 /// <param name = "objFuncOptStepsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFuncOptStepsEN objFuncOptStepsEN)
{
 if (objFuncOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncOptStepsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
strSQL = "Select * from FuncOptSteps where mId = " + ""+ objFuncOptStepsEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFuncOptStepsEN._CurrTabName);
if (objDS.Tables[clsFuncOptStepsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objFuncOptStepsEN.mId+"");
return false;
}
objRow = objDS.Tables[clsFuncOptStepsEN._CurrTabName].Rows[0];
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.FuncId))
 {
objRow[conFuncOptSteps.FuncId] = objFuncOptStepsEN.FuncId; //函数ID
 }
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepIndex))
 {
objRow[conFuncOptSteps.StepIndex] = objFuncOptStepsEN.StepIndex; //StepIndex
 }
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepName))
 {
objRow[conFuncOptSteps.StepName] = objFuncOptStepsEN.StepName; //StepName
 }
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepCode))
 {
objRow[conFuncOptSteps.StepCode] = objFuncOptStepsEN.StepCode; //StepCode
 }
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepDetail))
 {
objRow[conFuncOptSteps.StepDetail] = objFuncOptStepsEN.StepDetail; //StepDetail
 }
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.IsTemplate))
 {
objRow[conFuncOptSteps.IsTemplate] = objFuncOptStepsEN.IsTemplate; //是否模板
 }
try
{
objDA.Update(objDS, clsFuncOptStepsEN._CurrTabName);
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
public bool UpdateBySP(clsFuncOptStepsEN objFuncOptStepsEN)
{
 if (objFuncOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncOptStepsEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objFuncOptStepsEN.mId,
 objFuncOptStepsEN.FuncId,
 objFuncOptStepsEN.StepIndex,
 objFuncOptStepsEN.StepName,
 objFuncOptStepsEN.StepCode,
 objFuncOptStepsEN.StepDetail,
 objFuncOptStepsEN.IsTemplate
};
 objSQL.ExecSP("FuncOptSteps_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFuncOptStepsEN objFuncOptStepsEN)
{
 if (objFuncOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncOptStepsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FuncOptSteps Set ");
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.FuncId))
 {
 if (objFuncOptStepsEN.FuncId !=  null)
 {
 objFuncOptStepsEN.FuncId = objFuncOptStepsEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFuncOptStepsEN.FuncId, conFuncOptSteps.FuncId); //函数ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncOptSteps.FuncId); //函数ID
 }
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepIndex))
 {
 sbSQL.AppendFormat("{1} = {0},",objFuncOptStepsEN.StepIndex, conFuncOptSteps.StepIndex); //StepIndex
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepName))
 {
 if (objFuncOptStepsEN.StepName !=  null)
 {
 objFuncOptStepsEN.StepName = objFuncOptStepsEN.StepName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFuncOptStepsEN.StepName, conFuncOptSteps.StepName); //StepName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncOptSteps.StepName); //StepName
 }
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepCode))
 {
 if (objFuncOptStepsEN.StepCode !=  null)
 {
 objFuncOptStepsEN.StepCode = objFuncOptStepsEN.StepCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFuncOptStepsEN.StepCode, conFuncOptSteps.StepCode); //StepCode
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncOptSteps.StepCode); //StepCode
 }
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepDetail))
 {
 if (objFuncOptStepsEN.StepDetail !=  null)
 {
 objFuncOptStepsEN.StepDetail = objFuncOptStepsEN.StepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFuncOptStepsEN.StepDetail, conFuncOptSteps.StepDetail); //StepDetail
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncOptSteps.StepDetail); //StepDetail
 }
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.IsTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFuncOptStepsEN.IsTemplate == true?"1":"0", conFuncOptSteps.IsTemplate); //是否模板
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objFuncOptStepsEN.mId); 
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
 /// <param name = "objFuncOptStepsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFuncOptStepsEN objFuncOptStepsEN, string strCondition)
{
 if (objFuncOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncOptStepsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FuncOptSteps Set ");
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.FuncId))
 {
 if (objFuncOptStepsEN.FuncId !=  null)
 {
 objFuncOptStepsEN.FuncId = objFuncOptStepsEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncId = '{0}',", objFuncOptStepsEN.FuncId); //函数ID
 }
 else
 {
 sbSQL.Append(" FuncId = null,"); //函数ID
 }
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepIndex))
 {
 sbSQL.AppendFormat(" StepIndex = {0},", objFuncOptStepsEN.StepIndex); //StepIndex
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepName))
 {
 if (objFuncOptStepsEN.StepName !=  null)
 {
 objFuncOptStepsEN.StepName = objFuncOptStepsEN.StepName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StepName = '{0}',", objFuncOptStepsEN.StepName); //StepName
 }
 else
 {
 sbSQL.Append(" StepName = null,"); //StepName
 }
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepCode))
 {
 if (objFuncOptStepsEN.StepCode !=  null)
 {
 objFuncOptStepsEN.StepCode = objFuncOptStepsEN.StepCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StepCode = '{0}',", objFuncOptStepsEN.StepCode); //StepCode
 }
 else
 {
 sbSQL.Append(" StepCode = null,"); //StepCode
 }
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepDetail))
 {
 if (objFuncOptStepsEN.StepDetail !=  null)
 {
 objFuncOptStepsEN.StepDetail = objFuncOptStepsEN.StepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StepDetail = '{0}',", objFuncOptStepsEN.StepDetail); //StepDetail
 }
 else
 {
 sbSQL.Append(" StepDetail = null,"); //StepDetail
 }
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.IsTemplate))
 {
 sbSQL.AppendFormat(" IsTemplate = '{0}',", objFuncOptStepsEN.IsTemplate == true?"1":"0"); //是否模板
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
 /// <param name = "objFuncOptStepsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFuncOptStepsEN objFuncOptStepsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFuncOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncOptStepsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FuncOptSteps Set ");
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.FuncId))
 {
 if (objFuncOptStepsEN.FuncId !=  null)
 {
 objFuncOptStepsEN.FuncId = objFuncOptStepsEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncId = '{0}',", objFuncOptStepsEN.FuncId); //函数ID
 }
 else
 {
 sbSQL.Append(" FuncId = null,"); //函数ID
 }
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepIndex))
 {
 sbSQL.AppendFormat(" StepIndex = {0},", objFuncOptStepsEN.StepIndex); //StepIndex
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepName))
 {
 if (objFuncOptStepsEN.StepName !=  null)
 {
 objFuncOptStepsEN.StepName = objFuncOptStepsEN.StepName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StepName = '{0}',", objFuncOptStepsEN.StepName); //StepName
 }
 else
 {
 sbSQL.Append(" StepName = null,"); //StepName
 }
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepCode))
 {
 if (objFuncOptStepsEN.StepCode !=  null)
 {
 objFuncOptStepsEN.StepCode = objFuncOptStepsEN.StepCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StepCode = '{0}',", objFuncOptStepsEN.StepCode); //StepCode
 }
 else
 {
 sbSQL.Append(" StepCode = null,"); //StepCode
 }
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepDetail))
 {
 if (objFuncOptStepsEN.StepDetail !=  null)
 {
 objFuncOptStepsEN.StepDetail = objFuncOptStepsEN.StepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StepDetail = '{0}',", objFuncOptStepsEN.StepDetail); //StepDetail
 }
 else
 {
 sbSQL.Append(" StepDetail = null,"); //StepDetail
 }
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.IsTemplate))
 {
 sbSQL.AppendFormat(" IsTemplate = '{0}',", objFuncOptStepsEN.IsTemplate == true?"1":"0"); //是否模板
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
 /// <param name = "objFuncOptStepsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFuncOptStepsEN objFuncOptStepsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objFuncOptStepsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncOptStepsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FuncOptSteps Set ");
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.FuncId))
 {
 if (objFuncOptStepsEN.FuncId !=  null)
 {
 objFuncOptStepsEN.FuncId = objFuncOptStepsEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFuncOptStepsEN.FuncId, conFuncOptSteps.FuncId); //函数ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncOptSteps.FuncId); //函数ID
 }
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepIndex))
 {
 sbSQL.AppendFormat("{1} = {0},",objFuncOptStepsEN.StepIndex, conFuncOptSteps.StepIndex); //StepIndex
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepName))
 {
 if (objFuncOptStepsEN.StepName !=  null)
 {
 objFuncOptStepsEN.StepName = objFuncOptStepsEN.StepName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFuncOptStepsEN.StepName, conFuncOptSteps.StepName); //StepName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncOptSteps.StepName); //StepName
 }
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepCode))
 {
 if (objFuncOptStepsEN.StepCode !=  null)
 {
 objFuncOptStepsEN.StepCode = objFuncOptStepsEN.StepCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFuncOptStepsEN.StepCode, conFuncOptSteps.StepCode); //StepCode
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncOptSteps.StepCode); //StepCode
 }
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.StepDetail))
 {
 if (objFuncOptStepsEN.StepDetail !=  null)
 {
 objFuncOptStepsEN.StepDetail = objFuncOptStepsEN.StepDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFuncOptStepsEN.StepDetail, conFuncOptSteps.StepDetail); //StepDetail
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncOptSteps.StepDetail); //StepDetail
 }
 }
 
 if (objFuncOptStepsEN.IsUpdated(conFuncOptSteps.IsTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFuncOptStepsEN.IsTemplate == true?"1":"0", conFuncOptSteps.IsTemplate); //是否模板
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objFuncOptStepsEN.mId); 
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
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("FuncOptSteps_Delete", values);
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
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
//删除FuncOptSteps本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FuncOptSteps where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFuncOptSteps(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
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
//删除FuncOptSteps本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FuncOptSteps where mId in (" + strKeyList + ")";
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
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
//删除FuncOptSteps本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FuncOptSteps where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFuncOptSteps(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: DelFuncOptSteps)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FuncOptSteps where " + strCondition ;
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
public bool DelFuncOptStepsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFuncOptStepsDA: DelFuncOptStepsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FuncOptSteps where " + strCondition ;
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
 /// <param name = "objFuncOptStepsENS">源对象</param>
 /// <param name = "objFuncOptStepsENT">目标对象</param>
public void CopyTo(clsFuncOptStepsEN objFuncOptStepsENS, clsFuncOptStepsEN objFuncOptStepsENT)
{
objFuncOptStepsENT.mId = objFuncOptStepsENS.mId; //mId
objFuncOptStepsENT.FuncId = objFuncOptStepsENS.FuncId; //函数ID
objFuncOptStepsENT.StepIndex = objFuncOptStepsENS.StepIndex; //StepIndex
objFuncOptStepsENT.StepName = objFuncOptStepsENS.StepName; //StepName
objFuncOptStepsENT.StepCode = objFuncOptStepsENS.StepCode; //StepCode
objFuncOptStepsENT.StepDetail = objFuncOptStepsENS.StepDetail; //StepDetail
objFuncOptStepsENT.IsTemplate = objFuncOptStepsENS.IsTemplate; //是否模板
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFuncOptStepsEN objFuncOptStepsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFuncOptStepsEN.FuncId, conFuncOptSteps.FuncId);
clsCheckSql.CheckFieldNotNull(objFuncOptStepsEN.StepIndex, conFuncOptSteps.StepIndex);
clsCheckSql.CheckFieldNotNull(objFuncOptStepsEN.StepName, conFuncOptSteps.StepName);
clsCheckSql.CheckFieldNotNull(objFuncOptStepsEN.IsTemplate, conFuncOptSteps.IsTemplate);
//检查字段长度
clsCheckSql.CheckFieldLen(objFuncOptStepsEN.FuncId, 10, conFuncOptSteps.FuncId);
clsCheckSql.CheckFieldLen(objFuncOptStepsEN.StepName, 50, conFuncOptSteps.StepName);
clsCheckSql.CheckFieldLen(objFuncOptStepsEN.StepCode, 1000, conFuncOptSteps.StepCode);
clsCheckSql.CheckFieldLen(objFuncOptStepsEN.StepDetail, 1000, conFuncOptSteps.StepDetail);
//检查字段外键固定长度
 objFuncOptStepsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFuncOptStepsEN objFuncOptStepsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFuncOptStepsEN.FuncId, 10, conFuncOptSteps.FuncId);
clsCheckSql.CheckFieldLen(objFuncOptStepsEN.StepName, 50, conFuncOptSteps.StepName);
clsCheckSql.CheckFieldLen(objFuncOptStepsEN.StepCode, 1000, conFuncOptSteps.StepCode);
clsCheckSql.CheckFieldLen(objFuncOptStepsEN.StepDetail, 1000, conFuncOptSteps.StepDetail);
//检查外键字段长度
 objFuncOptStepsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFuncOptStepsEN objFuncOptStepsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFuncOptStepsEN.FuncId, 10, conFuncOptSteps.FuncId);
clsCheckSql.CheckFieldLen(objFuncOptStepsEN.StepName, 50, conFuncOptSteps.StepName);
clsCheckSql.CheckFieldLen(objFuncOptStepsEN.StepCode, 1000, conFuncOptSteps.StepCode);
clsCheckSql.CheckFieldLen(objFuncOptStepsEN.StepDetail, 1000, conFuncOptSteps.StepDetail);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFuncOptStepsEN.FuncId, conFuncOptSteps.FuncId);
clsCheckSql.CheckSqlInjection4Field(objFuncOptStepsEN.StepName, conFuncOptSteps.StepName);
clsCheckSql.CheckSqlInjection4Field(objFuncOptStepsEN.StepCode, conFuncOptSteps.StepCode);
clsCheckSql.CheckSqlInjection4Field(objFuncOptStepsEN.StepDetail, conFuncOptSteps.StepDetail);
//检查外键字段长度
 objFuncOptStepsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--FuncOptSteps(函数操作步骤),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFuncOptStepsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStrFuncId_StepIndex_StepName(clsFuncOptStepsEN objFuncOptStepsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncId = '{0}'", objFuncOptStepsEN.FuncId);
 sbCondition.AppendFormat(" and StepIndex = '{0}'", objFuncOptStepsEN.StepIndex);
 sbCondition.AppendFormat(" and StepName = '{0}'", objFuncOptStepsEN.StepName);
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
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
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
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
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
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFuncOptStepsEN._CurrTabName);
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
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFuncOptStepsEN._CurrTabName, strCondition);
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
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
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
 objSQL = clsFuncOptStepsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}