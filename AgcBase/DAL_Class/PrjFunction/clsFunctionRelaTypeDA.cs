
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionRelaTypeDA
 表名:FunctionRelaType(00050320)
 * 版本:2023.05.26.1(服务器:WIN-SRV103-116)
 日期:2023/05/27 17:15:05
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
 /// 函数关系类型(FunctionRelaType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsFunctionRelaTypeDA : clsCommBase4DA
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
 return clsFunctionRelaTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFunctionRelaTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFunctionRelaTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFunctionRelaTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFunctionRelaTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFunctionRelaTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFunctionRelaTypeId)
{
strFunctionRelaTypeId = strFunctionRelaTypeId.Replace("'", "''");
if (strFunctionRelaTypeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:FunctionRelaType中,检查关键字,长度不正确!(clsFunctionRelaTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFunctionRelaTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:FunctionRelaType中,关键字不能为空 或 null!(clsFunctionRelaTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFunctionRelaTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsFunctionRelaTypeDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey_Sim)
 /// </summary>
 /// <param name = "strFunctionRelaTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey_Sim(string strFunctionRelaTypeId)
{
strFunctionRelaTypeId = strFunctionRelaTypeId.Replace("'", "''");
if (strFunctionRelaTypeId.Length > 2 + 4)
{
throw new Exception("(errid:Data000004)在表:FunctionRelaType中,检查关键字,长度不正确!(简化版)(clsFunctionRelaTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFunctionRelaTypeId)  ==  true)
{
throw new Exception("(errid:Data000005)在表:FunctionRelaType中,关键字不能为空 或 null!(clsFunctionRelaTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFunctionRelaTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000006)在关键字中含有{0},非法,请检查!(clsFunctionRelaTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000007)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
 strSQL = "Select * from FunctionRelaType where " + strCondition;
 objDS = objSQL.GetDataSet(strSQL, "FunctionRelaType");
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
throw new Exception(string.Format("(errid:Data000008)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataSetByCondBySP)", objException.Message));
}
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDS = objSQL.ExecSPReturnDS("FunctionRelaType_SelectByCond",values, "FunctionRelaType");
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
throw new Exception(string.Format("(errid:Data000009)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataSet_Top)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FunctionRelaType where {1}", intTopSize, strCondition);
 objDS = objSQL.GetDataSet(strSQL, "FunctionRelaType");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFunctionRelaTypeDA: GetFunctionRelaTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFunctionRelaTypeDA: GetFunctionRelaTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFunctionRelaTypeDA: GetFunctionRelaTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000010)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from FunctionRelaType a where {0} And a.FunctionRelaTypeId not in (Select Top {2} FunctionRelaTypeId From FunctionRelaType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "FunctionRelaType");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFunctionRelaTypeDA: GetFunctionRelaTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFunctionRelaTypeDA: GetFunctionRelaTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFunctionRelaTypeDA: GetFunctionRelaTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000066)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataSet)", objException.Message));
}
string strSQL; 
System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from FunctionRelaType a where {0} And a.FunctionRelaTypeId not in (Select Top {2} FunctionRelaTypeId From FunctionRelaType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "FunctionRelaType");
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFunctionRelaTypeDA: GetFunctionRelaTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFunctionRelaTypeDA: GetFunctionRelaTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFunctionRelaTypeDA: GetFunctionRelaTypeByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataSet)ByRange", objException.Message));
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
throw new Exception(string.Format("(errid:Data000067)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataSetByRange)", objException.Message));
}
string strSQL; 
 System.Data.DataSet objDS; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select top {1} * from FunctionRelaType a where {0} And a.FunctionRelaTypeId not in (Select Top {2} FunctionRelaTypeId From FunctionRelaType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 objDS = objSQL.GetDataSet(strSQL, "FunctionRelaType");
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionRelaType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FunctionRelaType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataTable_FunctionRelaType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionRelaType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionRelaType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000020)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionRelaType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000077)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FunctionRelaType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FunctionRelaType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FunctionRelaType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000023)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FunctionRelaType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FunctionRelaType.* from FunctionRelaType Left Join {1} on {2} where {3} and FunctionRelaType.FunctionRelaTypeId not in (Select top {5} FunctionRelaType.FunctionRelaTypeId from FunctionRelaType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FunctionRelaType where {1} and FunctionRelaTypeId not in (Select top {2} FunctionRelaTypeId from FunctionRelaType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FunctionRelaType where {1} and FunctionRelaTypeId not in (Select top {3} FunctionRelaTypeId from FunctionRelaType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FunctionRelaType.* from FunctionRelaType Left Join {1} on {2} where {3} and FunctionRelaType.FunctionRelaTypeId not in (Select top {5} FunctionRelaType.FunctionRelaTypeId from FunctionRelaType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FunctionRelaType where {1} and FunctionRelaTypeId not in (Select top {2} FunctionRelaTypeId from FunctionRelaType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FunctionRelaType where {1} and FunctionRelaTypeId not in (Select top {3} FunctionRelaTypeId from FunctionRelaType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000026)在分页查询中输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FunctionRelaType.* from FunctionRelaType Left Join {1} on {2} where {3} and FunctionRelaType.FunctionRelaTypeId not in (Select top {5} FunctionRelaType.FunctionRelaTypeId from FunctionRelaType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FunctionRelaType where {1} and FunctionRelaTypeId not in (Select top {2} FunctionRelaTypeId from FunctionRelaType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FunctionRelaType where {1} and FunctionRelaTypeId not in (Select top {3} FunctionRelaTypeId from FunctionRelaType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFunctionRelaTypeDA: GetFunctionRelaTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFunctionRelaTypeDA: GetFunctionRelaTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFunctionRelaTypeDA: GetFunctionRelaTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000027)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from FunctionRelaType a where {0} And a.FunctionRelaTypeId not in (Select Top {2} FunctionRelaTypeId From FunctionRelaType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from FunctionRelaType a where {0} And a.FunctionRelaTypeId not in (Select Top {2} FunctionRelaTypeId From FunctionRelaType Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFunctionRelaTypeDA: GetFunctionRelaTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFunctionRelaTypeDA: GetFunctionRelaTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFunctionRelaTypeDA: GetFunctionRelaTypeByRange)", intMaxNum, intMinNum));
 }
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000070)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select top {1} * from FunctionRelaType a where {0} And a.FunctionRelaTypeId not in (Select Top {2} FunctionRelaTypeId From FunctionRelaType Where {0})", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);
 }
 else
 {
 strSQL = string.Format("Select top {1} * from FunctionRelaType a where {0} And a.FunctionRelaTypeId not in (Select Top {2} FunctionRelaTypeId From FunctionRelaType Where {0} order by {3}) order by {3}", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);
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
 throw new Exception(string.Format("在输入范围的最小值{0}非法,应该不小于0,请检查!(clsFunctionRelaTypeDA: GetFunctionRelaTypeByRange)", intMinNum));
 }
 if (intMaxNum > 6553005)
 {
 throw new Exception(string.Format("在输入范围的最大值{0}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(clsFunctionRelaTypeDA: GetFunctionRelaTypeByRange)", intMaxNum));
 }
 if (intMaxNum < intMinNum)
 {
 throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法,请检查!(clsFunctionRelaTypeDA: GetFunctionRelaTypeByRange)", intMaxNum, intMinNum));
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
throw new Exception(string.Format("(errid:Data000071)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataTableByRange)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionRelaType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000030)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetDataTableByCondBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("FunctionRelaType_SelectByCond",values);
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
public List<clsFunctionRelaTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA:GetObjLst)", objException.Message));
}
List<clsFunctionRelaTypeEN> arrObjLst = new List<clsFunctionRelaTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionRelaType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionRelaTypeEN objFunctionRelaTypeEN = new clsFunctionRelaTypeEN();
try
{
objFunctionRelaTypeEN.FunctionRelaTypeId = objRow[conFunctionRelaType.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objFunctionRelaTypeEN.FunctionRelaTypeName = objRow[conFunctionRelaType.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objFunctionRelaTypeEN.UpdDate = objRow[conFunctionRelaType.UpdDate] == DBNull.Value ? null : objRow[conFunctionRelaType.UpdDate].ToString().Trim(); //修改日期
objFunctionRelaTypeEN.UpdUser = objRow[conFunctionRelaType.UpdUser] == DBNull.Value ? null : objRow[conFunctionRelaType.UpdUser].ToString().Trim(); //修改者
objFunctionRelaTypeEN.Memo = objRow[conFunctionRelaType.Memo] == DBNull.Value ? null : objRow[conFunctionRelaType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFunctionRelaTypeDA: GetObjLst)", objException.Message));
}
objFunctionRelaTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFunctionRelaTypeEN);
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
public List<clsFunctionRelaTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsFunctionRelaTypeEN> arrObjLst = new List<clsFunctionRelaTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionRelaTypeEN objFunctionRelaTypeEN = new clsFunctionRelaTypeEN();
try
{
objFunctionRelaTypeEN.FunctionRelaTypeId = objRow[conFunctionRelaType.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objFunctionRelaTypeEN.FunctionRelaTypeName = objRow[conFunctionRelaType.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objFunctionRelaTypeEN.UpdDate = objRow[conFunctionRelaType.UpdDate] == DBNull.Value ? null : objRow[conFunctionRelaType.UpdDate].ToString().Trim(); //修改日期
objFunctionRelaTypeEN.UpdUser = objRow[conFunctionRelaType.UpdUser] == DBNull.Value ? null : objRow[conFunctionRelaType.UpdUser].ToString().Trim(); //修改者
objFunctionRelaTypeEN.Memo = objRow[conFunctionRelaType.Memo] == DBNull.Value ? null : objRow[conFunctionRelaType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFunctionRelaTypeDA: GetObjLst)", objException.Message));
}
objFunctionRelaTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFunctionRelaTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表,使用存储过程
 /// (AutoGCLib.clsGeneCodeBase:GenGetObjLstBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsFunctionRelaTypeEN> GetObjLstBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000038)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA:GetObjLstBySP)", objException.Message));
}
List<clsFunctionRelaTypeEN> arrObjLst = new List<clsFunctionRelaTypeEN>(); 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("FunctionRelaType_SelectByCond",values);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunctionRelaTypeEN objFunctionRelaTypeEN = new clsFunctionRelaTypeEN();
try
{
objFunctionRelaTypeEN.FunctionRelaTypeId = objRow[conFunctionRelaType.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objFunctionRelaTypeEN.FunctionRelaTypeName = objRow[conFunctionRelaType.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objFunctionRelaTypeEN.UpdDate = objRow[conFunctionRelaType.UpdDate] == DBNull.Value ? null : objRow[conFunctionRelaType.UpdDate].ToString().Trim(); //修改日期
objFunctionRelaTypeEN.UpdUser = objRow[conFunctionRelaType.UpdUser] == DBNull.Value ? null : objRow[conFunctionRelaType.UpdUser].ToString().Trim(); //修改者
objFunctionRelaTypeEN.Memo = objRow[conFunctionRelaType.Memo] == DBNull.Value ? null : objRow[conFunctionRelaType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据条件获取对象列表时,发生:{0},请检查!(clsFunctionRelaTypeDA: GetObjLstBySP)", objException.Message));
}
objFunctionRelaTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFunctionRelaTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFunctionRelaTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFunctionRelaType(ref clsFunctionRelaTypeEN objFunctionRelaTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionRelaType where FunctionRelaTypeId = " + "'"+ objFunctionRelaTypeEN.FunctionRelaTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFunctionRelaTypeEN.FunctionRelaTypeId = objDT.Rows[0][conFunctionRelaType.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunctionRelaTypeEN.FunctionRelaTypeName = objDT.Rows[0][conFunctionRelaType.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objFunctionRelaTypeEN.UpdDate = objDT.Rows[0][conFunctionRelaType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFunctionRelaTypeEN.UpdUser = objDT.Rows[0][conFunctionRelaType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFunctionRelaTypeEN.Memo = objDT.Rows[0][conFunctionRelaType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFunctionRelaTypeDA: GetFunctionRelaType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFunctionRelaTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsFunctionRelaTypeEN GetObjByFunctionRelaTypeId(string strFunctionRelaTypeId)
{
CheckPrimaryKey(strFunctionRelaTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionRelaType where FunctionRelaTypeId = " + "'"+ strFunctionRelaTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFunctionRelaTypeEN objFunctionRelaTypeEN = new clsFunctionRelaTypeEN();
try
{
 objFunctionRelaTypeEN.FunctionRelaTypeId = objRow[conFunctionRelaType.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunctionRelaTypeEN.FunctionRelaTypeName = objRow[conFunctionRelaType.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objFunctionRelaTypeEN.UpdDate = objRow[conFunctionRelaType.UpdDate] == DBNull.Value ? null : objRow[conFunctionRelaType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFunctionRelaTypeEN.UpdUser = objRow[conFunctionRelaType.UpdUser] == DBNull.Value ? null : objRow[conFunctionRelaType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFunctionRelaTypeEN.Memo = objRow[conFunctionRelaType.Memo] == DBNull.Value ? null : objRow[conFunctionRelaType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFunctionRelaTypeDA: GetObjByFunctionRelaTypeId)", objException.Message));
}
return objFunctionRelaTypeEN;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程FunctionRelaType_SelectOne来获取。
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueBySP)
 /// </summary>
 /// <param name = "objFunctionRelaTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFunctionRelaTypeOneBySP(clsFunctionRelaTypeEN objFunctionRelaTypeEN)
{
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 objFunctionRelaTypeEN.FunctionRelaTypeId
};
 objDT = objSQL.ExecSpReturnDT("FunctionRelaType_SelectOne",values);
if (objDT.Rows.Count  ==  0)
{
return false;
}
 objFunctionRelaTypeEN.FunctionRelaTypeId = objDT.Rows[0][conFunctionRelaType.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunctionRelaTypeEN.FunctionRelaTypeName = objDT.Rows[0][conFunctionRelaType.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objFunctionRelaTypeEN.UpdDate = objDT.Rows[0][conFunctionRelaType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFunctionRelaTypeEN.UpdUser = objDT.Rows[0][conFunctionRelaType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFunctionRelaTypeEN.Memo = objDT.Rows[0][conFunctionRelaType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
return true;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFunctionRelaTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionRelaType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFunctionRelaTypeEN objFunctionRelaTypeEN = new clsFunctionRelaTypeEN()
{
FunctionRelaTypeId = objRow[conFunctionRelaType.FunctionRelaTypeId].ToString().Trim(), //函数关系类型Id
FunctionRelaTypeName = objRow[conFunctionRelaType.FunctionRelaTypeName].ToString().Trim(), //函数关系类型名称
UpdDate = objRow[conFunctionRelaType.UpdDate] == DBNull.Value ? null : objRow[conFunctionRelaType.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conFunctionRelaType.UpdUser] == DBNull.Value ? null : objRow[conFunctionRelaType.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conFunctionRelaType.Memo] == DBNull.Value ? null : objRow[conFunctionRelaType.Memo].ToString().Trim() //说明
};
objFunctionRelaTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunctionRelaTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFunctionRelaTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObjBySP)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFunctionRelaTypeEN GetFirstObjBySP(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000040)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA:GetFirstObjBySP)", objException.Message));
}
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
 ArrayList values = new ArrayList()
{
 strCondition
};
 objDT = objSQL.ExecSpReturnDT("FunctionRelaType_SelectTop1ByCond",values);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
	clsFunctionRelaTypeEN objFunctionRelaTypeEN = new clsFunctionRelaTypeEN()
{
FunctionRelaTypeId = objRow[conFunctionRelaType.FunctionRelaTypeId].ToString().Trim(), //函数关系类型Id
FunctionRelaTypeName = objRow[conFunctionRelaType.FunctionRelaTypeName].ToString().Trim(), //函数关系类型名称
UpdDate = objRow[conFunctionRelaType.UpdDate] == DBNull.Value ? null : objRow[conFunctionRelaType.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conFunctionRelaType.UpdUser] == DBNull.Value ? null : objRow[conFunctionRelaType.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conFunctionRelaType.Memo] == DBNull.Value ? null : objRow[conFunctionRelaType.Memo].ToString().Trim() //说明
};
objFunctionRelaTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunctionRelaTypeEN;
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFunctionRelaTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFunctionRelaTypeEN objFunctionRelaTypeEN = new clsFunctionRelaTypeEN();
try
{
objFunctionRelaTypeEN.FunctionRelaTypeId = objRow[conFunctionRelaType.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objFunctionRelaTypeEN.FunctionRelaTypeName = objRow[conFunctionRelaType.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objFunctionRelaTypeEN.UpdDate = objRow[conFunctionRelaType.UpdDate] == DBNull.Value ? null : objRow[conFunctionRelaType.UpdDate].ToString().Trim(); //修改日期
objFunctionRelaTypeEN.UpdUser = objRow[conFunctionRelaType.UpdUser] == DBNull.Value ? null : objRow[conFunctionRelaType.UpdUser].ToString().Trim(); //修改者
objFunctionRelaTypeEN.Memo = objRow[conFunctionRelaType.Memo] == DBNull.Value ? null : objRow[conFunctionRelaType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFunctionRelaTypeDA: GetObjByDataRowFunctionRelaType)", objException.Message));
}
objFunctionRelaTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunctionRelaTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFunctionRelaTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFunctionRelaTypeEN objFunctionRelaTypeEN = new clsFunctionRelaTypeEN();
try
{
objFunctionRelaTypeEN.FunctionRelaTypeId = objRow[conFunctionRelaType.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objFunctionRelaTypeEN.FunctionRelaTypeName = objRow[conFunctionRelaType.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objFunctionRelaTypeEN.UpdDate = objRow[conFunctionRelaType.UpdDate] == DBNull.Value ? null : objRow[conFunctionRelaType.UpdDate].ToString().Trim(); //修改日期
objFunctionRelaTypeEN.UpdUser = objRow[conFunctionRelaType.UpdUser] == DBNull.Value ? null : objRow[conFunctionRelaType.UpdUser].ToString().Trim(); //修改者
objFunctionRelaTypeEN.Memo = objRow[conFunctionRelaType.Memo] == DBNull.Value ? null : objRow[conFunctionRelaType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFunctionRelaTypeDA: GetObjByDataRow)", objException.Message));
}
objFunctionRelaTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunctionRelaTypeEN;
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
objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFunctionRelaTypeEN._CurrTabName, conFunctionRelaType.FunctionRelaTypeId, 2, "");
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
objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFunctionRelaTypeEN._CurrTabName, conFunctionRelaType.FunctionRelaTypeId, 2, strPrefix);
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
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FunctionRelaTypeId from FunctionRelaType where " + strCondition;
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
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FunctionRelaTypeId from FunctionRelaType where " + strCondition;
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
 /// <param name = "strFunctionRelaTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFunctionRelaTypeId)
{
CheckPrimaryKey(strFunctionRelaTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FunctionRelaType", "FunctionRelaTypeId = " + "'"+ strFunctionRelaTypeId+"'"))
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
 /// <param name = "strFunctionRelaTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExistBySP(string strFunctionRelaTypeId)
{
CheckPrimaryKey(strFunctionRelaTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
string strIsExist = "";
 ArrayList values = new ArrayList()
{
strFunctionRelaTypeId,
strIsExist
};
ArrayList arrReturn = objSQL.ExecSpWithOutPut("FunctionRelaType_IsExist", values);
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FunctionRelaType", strCondition))
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
objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FunctionRelaType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFunctionRelaTypeEN objFunctionRelaTypeEN)
 {
 objFunctionRelaTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionRelaTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionRelaTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionRelaType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FunctionRelaType");
objRow = objDS.Tables["FunctionRelaType"].NewRow();
objRow[conFunctionRelaType.FunctionRelaTypeId] = objFunctionRelaTypeEN.FunctionRelaTypeId; //函数关系类型Id
objRow[conFunctionRelaType.FunctionRelaTypeName] = objFunctionRelaTypeEN.FunctionRelaTypeName; //函数关系类型名称
 if (objFunctionRelaTypeEN.UpdDate !=  "")
 {
objRow[conFunctionRelaType.UpdDate] = objFunctionRelaTypeEN.UpdDate; //修改日期
 }
 if (objFunctionRelaTypeEN.UpdUser !=  "")
 {
objRow[conFunctionRelaType.UpdUser] = objFunctionRelaTypeEN.UpdUser; //修改者
 }
 if (objFunctionRelaTypeEN.Memo !=  "")
 {
objRow[conFunctionRelaType.Memo] = objFunctionRelaTypeEN.Memo; //说明
 }
objDS.Tables[clsFunctionRelaTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFunctionRelaTypeEN._CurrTabName);
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
 /// <param name = "objFunctionRelaTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFunctionRelaTypeEN objFunctionRelaTypeEN)
{
 objFunctionRelaTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionRelaTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionRelaTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionRelaTypeEN.FunctionRelaTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.FunctionRelaTypeId);
 objFunctionRelaTypeEN.FunctionRelaTypeId = objFunctionRelaTypeEN.FunctionRelaTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.FunctionRelaTypeId + "'");
 }
 
 if (objFunctionRelaTypeEN.FunctionRelaTypeName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.FunctionRelaTypeName);
 objFunctionRelaTypeEN.FunctionRelaTypeName = objFunctionRelaTypeEN.FunctionRelaTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.FunctionRelaTypeName + "'");
 }
 
 if (objFunctionRelaTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.UpdDate);
 objFunctionRelaTypeEN.UpdDate = objFunctionRelaTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.UpdDate + "'");
 }
 
 if (objFunctionRelaTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.UpdUser);
 objFunctionRelaTypeEN.UpdUser = objFunctionRelaTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.UpdUser + "'");
 }
 
 if (objFunctionRelaTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.Memo);
 objFunctionRelaTypeEN.Memo = objFunctionRelaTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionRelaType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFunctionRelaTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFunctionRelaTypeEN objFunctionRelaTypeEN)
{
 objFunctionRelaTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionRelaTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionRelaTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionRelaTypeEN.FunctionRelaTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.FunctionRelaTypeId);
 objFunctionRelaTypeEN.FunctionRelaTypeId = objFunctionRelaTypeEN.FunctionRelaTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.FunctionRelaTypeId + "'");
 }
 
 if (objFunctionRelaTypeEN.FunctionRelaTypeName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.FunctionRelaTypeName);
 objFunctionRelaTypeEN.FunctionRelaTypeName = objFunctionRelaTypeEN.FunctionRelaTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.FunctionRelaTypeName + "'");
 }
 
 if (objFunctionRelaTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.UpdDate);
 objFunctionRelaTypeEN.UpdDate = objFunctionRelaTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.UpdDate + "'");
 }
 
 if (objFunctionRelaTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.UpdUser);
 objFunctionRelaTypeEN.UpdUser = objFunctionRelaTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.UpdUser + "'");
 }
 
 if (objFunctionRelaTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.Memo);
 objFunctionRelaTypeEN.Memo = objFunctionRelaTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionRelaType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objFunctionRelaTypeEN.FunctionRelaTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFunctionRelaTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFunctionRelaTypeEN objFunctionRelaTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFunctionRelaTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionRelaTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionRelaTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionRelaTypeEN.FunctionRelaTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.FunctionRelaTypeId);
 objFunctionRelaTypeEN.FunctionRelaTypeId = objFunctionRelaTypeEN.FunctionRelaTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.FunctionRelaTypeId + "'");
 }
 
 if (objFunctionRelaTypeEN.FunctionRelaTypeName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.FunctionRelaTypeName);
 objFunctionRelaTypeEN.FunctionRelaTypeName = objFunctionRelaTypeEN.FunctionRelaTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.FunctionRelaTypeName + "'");
 }
 
 if (objFunctionRelaTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.UpdDate);
 objFunctionRelaTypeEN.UpdDate = objFunctionRelaTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.UpdDate + "'");
 }
 
 if (objFunctionRelaTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.UpdUser);
 objFunctionRelaTypeEN.UpdUser = objFunctionRelaTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.UpdUser + "'");
 }
 
 if (objFunctionRelaTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.Memo);
 objFunctionRelaTypeEN.Memo = objFunctionRelaTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionRelaType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objFunctionRelaTypeEN.FunctionRelaTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFunctionRelaTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFunctionRelaTypeEN objFunctionRelaTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFunctionRelaTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionRelaTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunctionRelaTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunctionRelaTypeEN.FunctionRelaTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.FunctionRelaTypeId);
 objFunctionRelaTypeEN.FunctionRelaTypeId = objFunctionRelaTypeEN.FunctionRelaTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.FunctionRelaTypeId + "'");
 }
 
 if (objFunctionRelaTypeEN.FunctionRelaTypeName !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.FunctionRelaTypeName);
 objFunctionRelaTypeEN.FunctionRelaTypeName = objFunctionRelaTypeEN.FunctionRelaTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.FunctionRelaTypeName + "'");
 }
 
 if (objFunctionRelaTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.UpdDate);
 objFunctionRelaTypeEN.UpdDate = objFunctionRelaTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.UpdDate + "'");
 }
 
 if (objFunctionRelaTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.UpdUser);
 objFunctionRelaTypeEN.UpdUser = objFunctionRelaTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.UpdUser + "'");
 }
 
 if (objFunctionRelaTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunctionRelaType.Memo);
 objFunctionRelaTypeEN.Memo = objFunctionRelaTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objFunctionRelaTypeEN.Memo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FunctionRelaType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:通过存储过程来插入记录
 /// (AutoGCLib.DALCode4CSharp:GenAddnewRecBySP)
 /// </summary>
 /// <param name = "objFunctionRelaTypeEN">需要添加到数据库中的对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddnewFunctionRelaTypeBySP(clsFunctionRelaTypeEN objFunctionRelaTypeEN)
{
//通过存储过程来
//直接使用
 objFunctionRelaTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objFunctionRelaTypeEN.FunctionRelaTypeId,
 objFunctionRelaTypeEN.FunctionRelaTypeName,
 objFunctionRelaTypeEN.UpdDate,
 objFunctionRelaTypeEN.UpdUser,
objFunctionRelaTypeEN.Memo
};
 objSQL.ExecSP("FunctionRelaType_Add",values);
return true;
}

 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFunctionRelaTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionRelaType where FunctionRelaTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FunctionRelaType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strFunctionRelaTypeId = oRow[conFunctionRelaType.FunctionRelaTypeId].ToString().Trim();
if (IsExist(strFunctionRelaTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("FunctionRelaTypeId = {0}", strFunctionRelaTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFunctionRelaTypeEN._CurrTabName ].NewRow();
objRow[conFunctionRelaType.FunctionRelaTypeId] = oRow[conFunctionRelaType.FunctionRelaTypeId].ToString().Trim(); //函数关系类型Id
objRow[conFunctionRelaType.FunctionRelaTypeName] = oRow[conFunctionRelaType.FunctionRelaTypeName].ToString().Trim(); //函数关系类型名称
objRow[conFunctionRelaType.UpdDate] = oRow[conFunctionRelaType.UpdDate].ToString().Trim(); //修改日期
objRow[conFunctionRelaType.UpdUser] = oRow[conFunctionRelaType.UpdUser].ToString().Trim(); //修改者
objRow[conFunctionRelaType.Memo] = oRow[conFunctionRelaType.Memo].ToString().Trim(); //说明
 objDS.Tables[clsFunctionRelaTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFunctionRelaTypeEN._CurrTabName);
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
 /// <param name = "objFunctionRelaTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFunctionRelaTypeEN objFunctionRelaTypeEN)
{
 objFunctionRelaTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionRelaTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionRelaTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
strSQL = "Select * from FunctionRelaType where FunctionRelaTypeId = " + "'"+ objFunctionRelaTypeEN.FunctionRelaTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFunctionRelaTypeEN._CurrTabName);
if (objDS.Tables[clsFunctionRelaTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FunctionRelaTypeId = " + "'"+ objFunctionRelaTypeEN.FunctionRelaTypeId+"'");
return false;
}
objRow = objDS.Tables[clsFunctionRelaTypeEN._CurrTabName].Rows[0];
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.FunctionRelaTypeId))
 {
objRow[conFunctionRelaType.FunctionRelaTypeId] = objFunctionRelaTypeEN.FunctionRelaTypeId; //函数关系类型Id
 }
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.FunctionRelaTypeName))
 {
objRow[conFunctionRelaType.FunctionRelaTypeName] = objFunctionRelaTypeEN.FunctionRelaTypeName; //函数关系类型名称
 }
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.UpdDate))
 {
objRow[conFunctionRelaType.UpdDate] = objFunctionRelaTypeEN.UpdDate; //修改日期
 }
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.UpdUser))
 {
objRow[conFunctionRelaType.UpdUser] = objFunctionRelaTypeEN.UpdUser; //修改者
 }
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.Memo))
 {
objRow[conFunctionRelaType.Memo] = objFunctionRelaTypeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsFunctionRelaTypeEN._CurrTabName);
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
public bool UpdateBySP(clsFunctionRelaTypeEN objFunctionRelaTypeEN)
{
 objFunctionRelaTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionRelaTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionRelaTypeEN);
 }
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 objFunctionRelaTypeEN.FunctionRelaTypeId,
 objFunctionRelaTypeEN.FunctionRelaTypeName,
 objFunctionRelaTypeEN.UpdDate,
 objFunctionRelaTypeEN.UpdUser,
 objFunctionRelaTypeEN.Memo
};
 objSQL.ExecSP("FunctionRelaType_Update",values);
return true;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objFunctionRelaTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFunctionRelaTypeEN objFunctionRelaTypeEN)
{
 objFunctionRelaTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionRelaTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionRelaTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FunctionRelaType Set ");
 
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.FunctionRelaTypeName))
 {
 if (objFunctionRelaTypeEN.FunctionRelaTypeName !=  null)
 {
 objFunctionRelaTypeEN.FunctionRelaTypeName = objFunctionRelaTypeEN.FunctionRelaTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFunctionRelaTypeEN.FunctionRelaTypeName, conFunctionRelaType.FunctionRelaTypeName); //函数关系类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionRelaType.FunctionRelaTypeName); //函数关系类型名称
 }
 }
 
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.UpdDate))
 {
 if (objFunctionRelaTypeEN.UpdDate !=  null)
 {
 objFunctionRelaTypeEN.UpdDate = objFunctionRelaTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFunctionRelaTypeEN.UpdDate, conFunctionRelaType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionRelaType.UpdDate); //修改日期
 }
 }
 
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.UpdUser))
 {
 if (objFunctionRelaTypeEN.UpdUser !=  null)
 {
 objFunctionRelaTypeEN.UpdUser = objFunctionRelaTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFunctionRelaTypeEN.UpdUser, conFunctionRelaType.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionRelaType.UpdUser); //修改者
 }
 }
 
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.Memo))
 {
 if (objFunctionRelaTypeEN.Memo !=  null)
 {
 objFunctionRelaTypeEN.Memo = objFunctionRelaTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFunctionRelaTypeEN.Memo, conFunctionRelaType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionRelaType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FunctionRelaTypeId = '{0}'", objFunctionRelaTypeEN.FunctionRelaTypeId); 
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
 /// <param name = "objFunctionRelaTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFunctionRelaTypeEN objFunctionRelaTypeEN, string strCondition)
{
 objFunctionRelaTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionRelaTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionRelaTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FunctionRelaType Set ");
 
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.FunctionRelaTypeName))
 {
 if (objFunctionRelaTypeEN.FunctionRelaTypeName !=  null)
 {
 objFunctionRelaTypeEN.FunctionRelaTypeName = objFunctionRelaTypeEN.FunctionRelaTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionRelaTypeName = '{0}',", objFunctionRelaTypeEN.FunctionRelaTypeName); //函数关系类型名称
 }
 else
 {
 sbSQL.Append(" FunctionRelaTypeName = null,"); //函数关系类型名称
 }
 }
 
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.UpdDate))
 {
 if (objFunctionRelaTypeEN.UpdDate !=  null)
 {
 objFunctionRelaTypeEN.UpdDate = objFunctionRelaTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", objFunctionRelaTypeEN.UpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.UpdUser))
 {
 if (objFunctionRelaTypeEN.UpdUser !=  null)
 {
 objFunctionRelaTypeEN.UpdUser = objFunctionRelaTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", objFunctionRelaTypeEN.UpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.Memo))
 {
 if (objFunctionRelaTypeEN.Memo !=  null)
 {
 objFunctionRelaTypeEN.Memo = objFunctionRelaTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objFunctionRelaTypeEN.Memo); //说明
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
 /// <param name = "objFunctionRelaTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFunctionRelaTypeEN objFunctionRelaTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFunctionRelaTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionRelaTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionRelaTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FunctionRelaType Set ");
 
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.FunctionRelaTypeName))
 {
 if (objFunctionRelaTypeEN.FunctionRelaTypeName !=  null)
 {
 objFunctionRelaTypeEN.FunctionRelaTypeName = objFunctionRelaTypeEN.FunctionRelaTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionRelaTypeName = '{0}',", objFunctionRelaTypeEN.FunctionRelaTypeName); //函数关系类型名称
 }
 else
 {
 sbSQL.Append(" FunctionRelaTypeName = null,"); //函数关系类型名称
 }
 }
 
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.UpdDate))
 {
 if (objFunctionRelaTypeEN.UpdDate !=  null)
 {
 objFunctionRelaTypeEN.UpdDate = objFunctionRelaTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", objFunctionRelaTypeEN.UpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.UpdUser))
 {
 if (objFunctionRelaTypeEN.UpdUser !=  null)
 {
 objFunctionRelaTypeEN.UpdUser = objFunctionRelaTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", objFunctionRelaTypeEN.UpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.Memo))
 {
 if (objFunctionRelaTypeEN.Memo !=  null)
 {
 objFunctionRelaTypeEN.Memo = objFunctionRelaTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objFunctionRelaTypeEN.Memo); //说明
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
 /// <param name = "objFunctionRelaTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFunctionRelaTypeEN objFunctionRelaTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFunctionRelaTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunctionRelaTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunctionRelaTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FunctionRelaType Set ");
 
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.FunctionRelaTypeName))
 {
 if (objFunctionRelaTypeEN.FunctionRelaTypeName !=  null)
 {
 objFunctionRelaTypeEN.FunctionRelaTypeName = objFunctionRelaTypeEN.FunctionRelaTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFunctionRelaTypeEN.FunctionRelaTypeName, conFunctionRelaType.FunctionRelaTypeName); //函数关系类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionRelaType.FunctionRelaTypeName); //函数关系类型名称
 }
 }
 
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.UpdDate))
 {
 if (objFunctionRelaTypeEN.UpdDate !=  null)
 {
 objFunctionRelaTypeEN.UpdDate = objFunctionRelaTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFunctionRelaTypeEN.UpdDate, conFunctionRelaType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionRelaType.UpdDate); //修改日期
 }
 }
 
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.UpdUser))
 {
 if (objFunctionRelaTypeEN.UpdUser !=  null)
 {
 objFunctionRelaTypeEN.UpdUser = objFunctionRelaTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFunctionRelaTypeEN.UpdUser, conFunctionRelaType.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionRelaType.UpdUser); //修改者
 }
 }
 
 if (objFunctionRelaTypeEN.IsUpdated(conFunctionRelaType.Memo))
 {
 if (objFunctionRelaTypeEN.Memo !=  null)
 {
 objFunctionRelaTypeEN.Memo = objFunctionRelaTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objFunctionRelaTypeEN.Memo, conFunctionRelaType.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunctionRelaType.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FunctionRelaTypeId = '{0}'", objFunctionRelaTypeEN.FunctionRelaTypeId); 
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
 /// <param name = "strFunctionRelaTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFunctionRelaTypeId) 
{
CheckPrimaryKey(strFunctionRelaTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strFunctionRelaTypeId,
};
 objSQL.ExecSP("FunctionRelaType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strFunctionRelaTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strFunctionRelaTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strFunctionRelaTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
//删除FunctionRelaType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FunctionRelaType where FunctionRelaTypeId = " + "'"+ strFunctionRelaTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFunctionRelaType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
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
//删除FunctionRelaType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FunctionRelaType where FunctionRelaTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strFunctionRelaTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strFunctionRelaTypeId) 
{
CheckPrimaryKey(strFunctionRelaTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
//删除FunctionRelaType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FunctionRelaType where FunctionRelaTypeId = " + "'"+ strFunctionRelaTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFunctionRelaType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: DelFunctionRelaType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FunctionRelaType where " + strCondition ;
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
public bool DelFunctionRelaTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFunctionRelaTypeDA: DelFunctionRelaTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FunctionRelaType where " + strCondition ;
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
 /// <param name = "objFunctionRelaTypeENS">源对象</param>
 /// <param name = "objFunctionRelaTypeENT">目标对象</param>
public void CopyTo(clsFunctionRelaTypeEN objFunctionRelaTypeENS, clsFunctionRelaTypeEN objFunctionRelaTypeENT)
{
objFunctionRelaTypeENT.FunctionRelaTypeId = objFunctionRelaTypeENS.FunctionRelaTypeId; //函数关系类型Id
objFunctionRelaTypeENT.FunctionRelaTypeName = objFunctionRelaTypeENS.FunctionRelaTypeName; //函数关系类型名称
objFunctionRelaTypeENT.UpdDate = objFunctionRelaTypeENS.UpdDate; //修改日期
objFunctionRelaTypeENT.UpdUser = objFunctionRelaTypeENS.UpdUser; //修改者
objFunctionRelaTypeENT.Memo = objFunctionRelaTypeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFunctionRelaTypeEN objFunctionRelaTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFunctionRelaTypeEN.FunctionRelaTypeName, conFunctionRelaType.FunctionRelaTypeName);
//检查字段长度
clsCheckSql.CheckFieldLen(objFunctionRelaTypeEN.FunctionRelaTypeId, 2, conFunctionRelaType.FunctionRelaTypeId);
clsCheckSql.CheckFieldLen(objFunctionRelaTypeEN.FunctionRelaTypeName, 30, conFunctionRelaType.FunctionRelaTypeName);
clsCheckSql.CheckFieldLen(objFunctionRelaTypeEN.UpdDate, 20, conFunctionRelaType.UpdDate);
clsCheckSql.CheckFieldLen(objFunctionRelaTypeEN.UpdUser, 20, conFunctionRelaType.UpdUser);
clsCheckSql.CheckFieldLen(objFunctionRelaTypeEN.Memo, 1000, conFunctionRelaType.Memo);
//检查字段外键固定长度
 objFunctionRelaTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFunctionRelaTypeEN objFunctionRelaTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFunctionRelaTypeEN.FunctionRelaTypeName, 30, conFunctionRelaType.FunctionRelaTypeName);
clsCheckSql.CheckFieldLen(objFunctionRelaTypeEN.UpdDate, 20, conFunctionRelaType.UpdDate);
clsCheckSql.CheckFieldLen(objFunctionRelaTypeEN.UpdUser, 20, conFunctionRelaType.UpdUser);
clsCheckSql.CheckFieldLen(objFunctionRelaTypeEN.Memo, 1000, conFunctionRelaType.Memo);
//检查外键字段长度
 objFunctionRelaTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFunctionRelaTypeEN objFunctionRelaTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFunctionRelaTypeEN.FunctionRelaTypeId, 2, conFunctionRelaType.FunctionRelaTypeId);
clsCheckSql.CheckFieldLen(objFunctionRelaTypeEN.FunctionRelaTypeName, 30, conFunctionRelaType.FunctionRelaTypeName);
clsCheckSql.CheckFieldLen(objFunctionRelaTypeEN.UpdDate, 20, conFunctionRelaType.UpdDate);
clsCheckSql.CheckFieldLen(objFunctionRelaTypeEN.UpdUser, 20, conFunctionRelaType.UpdUser);
clsCheckSql.CheckFieldLen(objFunctionRelaTypeEN.Memo, 1000, conFunctionRelaType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFunctionRelaTypeEN.FunctionRelaTypeId, conFunctionRelaType.FunctionRelaTypeId);
clsCheckSql.CheckSqlInjection4Field(objFunctionRelaTypeEN.FunctionRelaTypeName, conFunctionRelaType.FunctionRelaTypeName);
clsCheckSql.CheckSqlInjection4Field(objFunctionRelaTypeEN.UpdDate, conFunctionRelaType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objFunctionRelaTypeEN.UpdUser, conFunctionRelaType.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objFunctionRelaTypeEN.Memo, conFunctionRelaType.Memo);
//检查外键字段长度
 objFunctionRelaTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetFunctionRelaTypeId()
{
//获取某学院所有专业信息
string strSQL = "select FunctionRelaTypeId, FunctionRelaTypeName from FunctionRelaType ";
 clsSpecSQLforSql mySql = clsFunctionRelaTypeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--FunctionRelaType(函数关系类型),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFunctionRelaTypeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStrFunctionRelaTypeName(clsFunctionRelaTypeEN objFunctionRelaTypeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FunctionRelaTypeName = '{0}'", objFunctionRelaTypeEN.FunctionRelaTypeName);
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
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
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
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
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
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFunctionRelaTypeEN._CurrTabName);
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
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFunctionRelaTypeEN._CurrTabName, strCondition);
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
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
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
 objSQL = clsFunctionRelaTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}