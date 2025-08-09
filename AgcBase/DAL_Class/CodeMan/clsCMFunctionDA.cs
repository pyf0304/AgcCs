
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFunctionDA
 表名:CMFunction(00050502)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:31
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
 框架-层名:数据处理层(CS)(DALCode,0002)
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
using PrjCommBase;
using AGC.Entity;

namespace AGC.DAL
{
 /// <summary>
 /// CM函数(CMFunction)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCMFunctionDA : clsCommBase4DA
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
 return clsCMFunctionEN._CurrTabName;
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
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
if (string.IsNullOrEmpty(clsCMFunctionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMFunctionEN._ConnectString);
}
return objSQL;
}


 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_GetSpecSQLObj_Obj)
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
 if (string.IsNullOrEmpty(clsCMFunctionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCMFunctionEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCmFunctionId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCmFunctionId)
{
strCmFunctionId = strCmFunctionId.Replace("'", "''");
if (strCmFunctionId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:CMFunction中,检查关键字,长度不正确!(clsCMFunctionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCmFunctionId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CMFunction中,关键字不能为空 或 null!(clsCMFunctionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCmFunctionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCMFunctionDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCMFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CMFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CMFunction(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCMFunctionDA: GetDataTable_CMFunction)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CMFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(给定表名)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTableByTabName_S)
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCMFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable_Exclude)
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCMFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CMFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTableByTabName_S_Exclude)
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCMFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)
{
 return GetDataTable_Top(objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_GetDataTable_Top_S)
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCMFunctionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMFunction where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMFunction where {1} order by {2}", intTopSize, strCondition, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_GetDataTable_Top_S_Exclude)
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCMFunctionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CMFunction where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTableByPager_S)
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCMFunctionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var sortInfo = clsSortLinkStrParse.ParseSortString(strOrderBy);
if (sortInfo.SortDirection == "" || sortInfo.SortField == "")
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]格式不正确,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strLeftLinkStr = clsSortLinkStrParse.BuildLeftJoinClause(sortInfo.JoinTables, sortInfo.JoinConditions);
strSQL = $"Select Top {intPageSize} CMFunction.* " + 
$"from CMFunction " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CMFunction.CmFunctionId not in " + 
$"(Select top {intTop_In} CMFunction.CmFunctionId from CMFunction " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMFunction where {1} and CmFunctionId not in (Select top {2} CmFunctionId from CMFunction where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMFunction where {1} and CmFunctionId not in (Select top {3} CmFunctionId from CMFunction where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTableByPager_S_Exclude)
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCMFunctionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var sortInfo = clsSortLinkStrParse.ParseSortString(strOrderBy);
if (sortInfo.SortDirection == "" || sortInfo.SortField == "")
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]格式不正确,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strLeftLinkStr = clsSortLinkStrParse.BuildLeftJoinClause(sortInfo.JoinTables, sortInfo.JoinConditions);
strSQL = $"Select Top {intPageSize} CMFunction.* " + 
$"from CMFunction " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CMFunction.CmFunctionId not in " + 
$"(Select top {intTop_In} CMFunction.CmFunctionId from CMFunction " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMFunction where {1} and CmFunctionId not in (Select top {2} CmFunctionId from CMFunction where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMFunction where {1} and CmFunctionId not in (Select top {3} CmFunctionId from CMFunction where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 #endregion 获取数据表的DataTable

 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetObjLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsCMFunctionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCMFunctionDA:GetObjLst)", objException.Message));
}
List<clsCMFunctionEN> arrObjLst = new List<clsCMFunctionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CMFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN();
try
{
objCMFunctionEN.CmFunctionId = objRow[conCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionEN.CmClassId = objRow[conCMFunction.CmClassId].ToString().Trim(); //类Id
objCMFunctionEN.FunctionName = objRow[conCMFunction.FunctionName].ToString().Trim(); //功能名称
objCMFunctionEN.FuncContent = objRow[conCMFunction.FuncContent] == DBNull.Value ? null : objRow[conCMFunction.FuncContent].ToString().Trim(); //函数内容
objCMFunctionEN.KeyWords = objRow[conCMFunction.KeyWords] == DBNull.Value ? null : objRow[conCMFunction.KeyWords].ToString().Trim(); //关键字
objCMFunctionEN.FuncParaLst = objRow[conCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[conCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objCMFunctionEN.FuncComments = objRow[conCMFunction.FuncComments] == DBNull.Value ? null : objRow[conCMFunction.FuncComments].ToString().Trim(); //函数注释
objCMFunctionEN.FunctionSignature = objRow[conCMFunction.FunctionSignature] == DBNull.Value ? null : objRow[conCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objCMFunctionEN.FuncTypeId = objRow[conCMFunction.FuncTypeId] == DBNull.Value ? null : objRow[conCMFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objCMFunctionEN.ReturnType = objRow[conCMFunction.ReturnType] == DBNull.Value ? null : objRow[conCMFunction.ReturnType].ToString().Trim(); //返回类型
objCMFunctionEN.ReturnTypeFullName = objRow[conCMFunction.ReturnTypeFullName] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objCMFunctionEN.IsKnownType = TransNullToBool(objRow[conCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objCMFunctionEN.ReturnTypeId = objRow[conCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objCMFunctionEN.IsAsyncFunc = TransNullToBool(objRow[conCMFunction.IsAsyncFunc].ToString().Trim()); //是否异步函数
objCMFunctionEN.SourceFunction = objRow[conCMFunction.SourceFunction] == DBNull.Value ? null : objRow[conCMFunction.SourceFunction].ToString().Trim(); //来源函数
objCMFunctionEN.IsGeneCode = TransNullToBool(objRow[conCMFunction.IsGeneCode].ToString().Trim()); //是否生成代码
objCMFunctionEN.ReturnValueDescription = objRow[conCMFunction.ReturnValueDescription] == DBNull.Value ? null : objRow[conCMFunction.ReturnValueDescription].ToString().Trim(); //返回值说明
objCMFunctionEN.IsSysFunction = TransNullToBool(objRow[conCMFunction.IsSysFunction].ToString().Trim()); //是否系统函数
objCMFunctionEN.GetCustomAttributes = objRow[conCMFunction.GetCustomAttributes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCMFunction.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objCMFunctionEN.ClassNameLst = objRow[conCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[conCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objCMFunctionEN.UpdDate = objRow[conCMFunction.UpdDate] == DBNull.Value ? null : objRow[conCMFunction.UpdDate].ToString().Trim(); //修改日期
objCMFunctionEN.UpdUser = objRow[conCMFunction.UpdUser] == DBNull.Value ? null : objRow[conCMFunction.UpdUser].ToString().Trim(); //修改者
objCMFunctionEN.Memo = objRow[conCMFunction.Memo] == DBNull.Value ? null : objRow[conCMFunction.Memo].ToString().Trim(); //说明
objCMFunctionEN.IsSynchToServer = TransNullToBool(objRow[conCMFunction.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionEN.SynchToServerDate = objRow[conCMFunction.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionEN.SynchToServerUser = objRow[conCMFunction.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionEN.IsSynchToClient = TransNullToBool(objRow[conCMFunction.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionEN.SynchToClientDate = objRow[conCMFunction.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionEN.SynchToClientUser = objRow[conCMFunction.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionEN.SynSource = objRow[conCMFunction.SynSource] == DBNull.Value ? null : objRow[conCMFunction.SynSource].ToString().Trim(); //同步来源
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCMFunctionDA: GetObjLst)", objException.Message));
}
objCMFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCMFunctionEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetObjLstByTabName)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回对象列表</returns>
public List<clsCMFunctionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCMFunctionDA:GetObjLstByTabName)", objException.Message));
}
List<clsCMFunctionEN> arrObjLst = new List<clsCMFunctionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN();
try
{
objCMFunctionEN.CmFunctionId = objRow[conCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionEN.CmClassId = objRow[conCMFunction.CmClassId].ToString().Trim(); //类Id
objCMFunctionEN.FunctionName = objRow[conCMFunction.FunctionName].ToString().Trim(); //功能名称
objCMFunctionEN.FuncContent = objRow[conCMFunction.FuncContent] == DBNull.Value ? null : objRow[conCMFunction.FuncContent].ToString().Trim(); //函数内容
objCMFunctionEN.KeyWords = objRow[conCMFunction.KeyWords] == DBNull.Value ? null : objRow[conCMFunction.KeyWords].ToString().Trim(); //关键字
objCMFunctionEN.FuncParaLst = objRow[conCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[conCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objCMFunctionEN.FuncComments = objRow[conCMFunction.FuncComments] == DBNull.Value ? null : objRow[conCMFunction.FuncComments].ToString().Trim(); //函数注释
objCMFunctionEN.FunctionSignature = objRow[conCMFunction.FunctionSignature] == DBNull.Value ? null : objRow[conCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objCMFunctionEN.FuncTypeId = objRow[conCMFunction.FuncTypeId] == DBNull.Value ? null : objRow[conCMFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objCMFunctionEN.ReturnType = objRow[conCMFunction.ReturnType] == DBNull.Value ? null : objRow[conCMFunction.ReturnType].ToString().Trim(); //返回类型
objCMFunctionEN.ReturnTypeFullName = objRow[conCMFunction.ReturnTypeFullName] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objCMFunctionEN.IsKnownType = TransNullToBool(objRow[conCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objCMFunctionEN.ReturnTypeId = objRow[conCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objCMFunctionEN.IsAsyncFunc = TransNullToBool(objRow[conCMFunction.IsAsyncFunc].ToString().Trim()); //是否异步函数
objCMFunctionEN.SourceFunction = objRow[conCMFunction.SourceFunction] == DBNull.Value ? null : objRow[conCMFunction.SourceFunction].ToString().Trim(); //来源函数
objCMFunctionEN.IsGeneCode = TransNullToBool(objRow[conCMFunction.IsGeneCode].ToString().Trim()); //是否生成代码
objCMFunctionEN.ReturnValueDescription = objRow[conCMFunction.ReturnValueDescription] == DBNull.Value ? null : objRow[conCMFunction.ReturnValueDescription].ToString().Trim(); //返回值说明
objCMFunctionEN.IsSysFunction = TransNullToBool(objRow[conCMFunction.IsSysFunction].ToString().Trim()); //是否系统函数
objCMFunctionEN.GetCustomAttributes = objRow[conCMFunction.GetCustomAttributes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCMFunction.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objCMFunctionEN.ClassNameLst = objRow[conCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[conCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objCMFunctionEN.UpdDate = objRow[conCMFunction.UpdDate] == DBNull.Value ? null : objRow[conCMFunction.UpdDate].ToString().Trim(); //修改日期
objCMFunctionEN.UpdUser = objRow[conCMFunction.UpdUser] == DBNull.Value ? null : objRow[conCMFunction.UpdUser].ToString().Trim(); //修改者
objCMFunctionEN.Memo = objRow[conCMFunction.Memo] == DBNull.Value ? null : objRow[conCMFunction.Memo].ToString().Trim(); //说明
objCMFunctionEN.IsSynchToServer = TransNullToBool(objRow[conCMFunction.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionEN.SynchToServerDate = objRow[conCMFunction.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionEN.SynchToServerUser = objRow[conCMFunction.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionEN.IsSynchToClient = TransNullToBool(objRow[conCMFunction.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionEN.SynchToClientDate = objRow[conCMFunction.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionEN.SynchToClientUser = objRow[conCMFunction.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionEN.SynSource = objRow[conCMFunction.SynSource] == DBNull.Value ? null : objRow[conCMFunction.SynSource].ToString().Trim(); //同步来源
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCMFunctionDA: GetObjLst)", objException.Message));
}
objCMFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCMFunctionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCMFunction(ref clsCMFunctionEN objCMFunctionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CMFunction where CmFunctionId = " + "'"+ objCMFunctionEN.CmFunctionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCMFunctionEN.CmFunctionId = objDT.Rows[0][conCMFunction.CmFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objCMFunctionEN.CmClassId = objDT.Rows[0][conCMFunction.CmClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objCMFunctionEN.FunctionName = objDT.Rows[0][conCMFunction.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objCMFunctionEN.FuncContent = objDT.Rows[0][conCMFunction.FuncContent].ToString().Trim(); //函数内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objCMFunctionEN.KeyWords = objDT.Rows[0][conCMFunction.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFunctionEN.FuncParaLst = objDT.Rows[0][conCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFunctionEN.FuncComments = objDT.Rows[0][conCMFunction.FuncComments].ToString().Trim(); //函数注释(字段类型:text,字段长度:5000,是否可空:True)
 objCMFunctionEN.FunctionSignature = objDT.Rows[0][conCMFunction.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objCMFunctionEN.FuncTypeId = objDT.Rows[0][conCMFunction.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objCMFunctionEN.ReturnType = objDT.Rows[0][conCMFunction.ReturnType].ToString().Trim(); //返回类型(字段类型:varchar,字段长度:500,是否可空:False)
 objCMFunctionEN.ReturnTypeFullName = objDT.Rows[0][conCMFunction.ReturnTypeFullName].ToString().Trim(); //返回类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFunctionEN.IsKnownType = TransNullToBool(objDT.Rows[0][conCMFunction.IsKnownType].ToString().Trim()); //是否已知类型(字段类型:bit,字段长度:1,是否可空:True)
 objCMFunctionEN.ReturnTypeId = objDT.Rows[0][conCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objCMFunctionEN.IsAsyncFunc = TransNullToBool(objDT.Rows[0][conCMFunction.IsAsyncFunc].ToString().Trim()); //是否异步函数(字段类型:bit,字段长度:1,是否可空:True)
 objCMFunctionEN.SourceFunction = objDT.Rows[0][conCMFunction.SourceFunction].ToString().Trim(); //来源函数(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFunctionEN.IsGeneCode = TransNullToBool(objDT.Rows[0][conCMFunction.IsGeneCode].ToString().Trim()); //是否生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objCMFunctionEN.ReturnValueDescription = objDT.Rows[0][conCMFunction.ReturnValueDescription].ToString().Trim(); //返回值说明(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFunctionEN.IsSysFunction = TransNullToBool(objDT.Rows[0][conCMFunction.IsSysFunction].ToString().Trim()); //是否系统函数(字段类型:bit,字段长度:1,是否可空:True)
 objCMFunctionEN.GetCustomAttributes = TransNullToInt(objDT.Rows[0][conCMFunction.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes(字段类型:int,字段长度:4,是否可空:False)
 objCMFunctionEN.ClassNameLst = objDT.Rows[0][conCMFunction.ClassNameLst].ToString().Trim(); //类名列表(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFunctionEN.UpdDate = objDT.Rows[0][conCMFunction.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionEN.UpdUser = objDT.Rows[0][conCMFunction.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionEN.Memo = objDT.Rows[0][conCMFunction.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objCMFunctionEN.IsSynchToServer = TransNullToBool(objDT.Rows[0][conCMFunction.IsSynchToServer].ToString().Trim()); //是否同步到Server(字段类型:bit,字段长度:1,是否可空:True)
 objCMFunctionEN.SynchToServerDate = objDT.Rows[0][conCMFunction.SynchToServerDate].ToString().Trim(); //同步到Server日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionEN.SynchToServerUser = objDT.Rows[0][conCMFunction.SynchToServerUser].ToString().Trim(); //同步到Server用户(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionEN.IsSynchToClient = TransNullToBool(objDT.Rows[0][conCMFunction.IsSynchToClient].ToString().Trim()); //是否同步到Client(字段类型:bit,字段长度:1,是否可空:True)
 objCMFunctionEN.SynchToClientDate = objDT.Rows[0][conCMFunction.SynchToClientDate].ToString().Trim(); //同步到Client库日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionEN.SynchToClientUser = objDT.Rows[0][conCMFunction.SynchToClientUser].ToString().Trim(); //同步到Client库用户(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionEN.SynSource = objDT.Rows[0][conCMFunction.SynSource].ToString().Trim(); //同步来源(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCMFunctionDA: GetCMFunction)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCmFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public clsCMFunctionEN GetObjByCmFunctionId(string strCmFunctionId)
{
CheckPrimaryKey(strCmFunctionId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CMFunction where CmFunctionId = " + "'"+ strCmFunctionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN();
try
{
 objCMFunctionEN.CmFunctionId = objRow[conCMFunction.CmFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objCMFunctionEN.CmClassId = objRow[conCMFunction.CmClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objCMFunctionEN.FunctionName = objRow[conCMFunction.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objCMFunctionEN.FuncContent = objRow[conCMFunction.FuncContent] == DBNull.Value ? null : objRow[conCMFunction.FuncContent].ToString().Trim(); //函数内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objCMFunctionEN.KeyWords = objRow[conCMFunction.KeyWords] == DBNull.Value ? null : objRow[conCMFunction.KeyWords].ToString().Trim(); //关键字(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFunctionEN.FuncParaLst = objRow[conCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[conCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFunctionEN.FuncComments = objRow[conCMFunction.FuncComments] == DBNull.Value ? null : objRow[conCMFunction.FuncComments].ToString().Trim(); //函数注释(字段类型:text,字段长度:5000,是否可空:True)
 objCMFunctionEN.FunctionSignature = objRow[conCMFunction.FunctionSignature] == DBNull.Value ? null : objRow[conCMFunction.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objCMFunctionEN.FuncTypeId = objRow[conCMFunction.FuncTypeId] == DBNull.Value ? null : objRow[conCMFunction.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objCMFunctionEN.ReturnType = objRow[conCMFunction.ReturnType] == DBNull.Value ? null : objRow[conCMFunction.ReturnType].ToString().Trim(); //返回类型(字段类型:varchar,字段长度:500,是否可空:False)
 objCMFunctionEN.ReturnTypeFullName = objRow[conCMFunction.ReturnTypeFullName] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeFullName].ToString().Trim(); //返回类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFunctionEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsKnownType].ToString().Trim()); //是否已知类型(字段类型:bit,字段长度:1,是否可空:True)
 objCMFunctionEN.ReturnTypeId = objRow[conCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objCMFunctionEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsAsyncFunc].ToString().Trim()); //是否异步函数(字段类型:bit,字段长度:1,是否可空:True)
 objCMFunctionEN.SourceFunction = objRow[conCMFunction.SourceFunction] == DBNull.Value ? null : objRow[conCMFunction.SourceFunction].ToString().Trim(); //来源函数(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFunctionEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsGeneCode].ToString().Trim()); //是否生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objCMFunctionEN.ReturnValueDescription = objRow[conCMFunction.ReturnValueDescription] == DBNull.Value ? null : objRow[conCMFunction.ReturnValueDescription].ToString().Trim(); //返回值说明(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFunctionEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSysFunction].ToString().Trim()); //是否系统函数(字段类型:bit,字段长度:1,是否可空:True)
 objCMFunctionEN.GetCustomAttributes = objRow[conCMFunction.GetCustomAttributes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCMFunction.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes(字段类型:int,字段长度:4,是否可空:False)
 objCMFunctionEN.ClassNameLst = objRow[conCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[conCMFunction.ClassNameLst].ToString().Trim(); //类名列表(字段类型:varchar,字段长度:500,是否可空:True)
 objCMFunctionEN.UpdDate = objRow[conCMFunction.UpdDate] == DBNull.Value ? null : objRow[conCMFunction.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionEN.UpdUser = objRow[conCMFunction.UpdUser] == DBNull.Value ? null : objRow[conCMFunction.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionEN.Memo = objRow[conCMFunction.Memo] == DBNull.Value ? null : objRow[conCMFunction.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objCMFunctionEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToServer].ToString().Trim()); //是否同步到Server(字段类型:bit,字段长度:1,是否可空:True)
 objCMFunctionEN.SynchToServerDate = objRow[conCMFunction.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerDate].ToString().Trim(); //同步到Server日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionEN.SynchToServerUser = objRow[conCMFunction.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerUser].ToString().Trim(); //同步到Server用户(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunction.IsSynchToClient].ToString().Trim()); //是否同步到Client(字段类型:bit,字段长度:1,是否可空:True)
 objCMFunctionEN.SynchToClientDate = objRow[conCMFunction.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientDate].ToString().Trim(); //同步到Client库日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionEN.SynchToClientUser = objRow[conCMFunction.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientUser].ToString().Trim(); //同步到Client库用户(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionEN.SynSource = objRow[conCMFunction.SynSource] == DBNull.Value ? null : objRow[conCMFunction.SynSource].ToString().Trim(); //同步来源(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCMFunctionDA: GetObjByCmFunctionId)", objException.Message));
}
return objCMFunctionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCMFunctionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCMFunctionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CMFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN()
{
CmFunctionId = objRow[conCMFunction.CmFunctionId].ToString().Trim(), //函数Id
CmClassId = objRow[conCMFunction.CmClassId].ToString().Trim(), //类Id
FunctionName = objRow[conCMFunction.FunctionName].ToString().Trim(), //功能名称
FuncContent = objRow[conCMFunction.FuncContent] == DBNull.Value ? null : objRow[conCMFunction.FuncContent].ToString().Trim(), //函数内容
KeyWords = objRow[conCMFunction.KeyWords] == DBNull.Value ? null : objRow[conCMFunction.KeyWords].ToString().Trim(), //关键字
FuncParaLst = objRow[conCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[conCMFunction.FuncParaLst].ToString().Trim(), //函数参数列表
FuncComments = objRow[conCMFunction.FuncComments] == DBNull.Value ? null : objRow[conCMFunction.FuncComments].ToString().Trim(), //函数注释
FunctionSignature = objRow[conCMFunction.FunctionSignature] == DBNull.Value ? null : objRow[conCMFunction.FunctionSignature].ToString().Trim(), //函数签名
FuncTypeId = objRow[conCMFunction.FuncTypeId] == DBNull.Value ? null : objRow[conCMFunction.FuncTypeId].ToString().Trim(), //函数类型Id
ReturnType = objRow[conCMFunction.ReturnType] == DBNull.Value ? null : objRow[conCMFunction.ReturnType].ToString().Trim(), //返回类型
ReturnTypeFullName = objRow[conCMFunction.ReturnTypeFullName] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeFullName].ToString().Trim(), //返回类型全名
IsKnownType = TransNullToBool(objRow[conCMFunction.IsKnownType].ToString().Trim()), //是否已知类型
ReturnTypeId = objRow[conCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeId].ToString().Trim(), //返回类型ID
IsAsyncFunc = TransNullToBool(objRow[conCMFunction.IsAsyncFunc].ToString().Trim()), //是否异步函数
SourceFunction = objRow[conCMFunction.SourceFunction] == DBNull.Value ? null : objRow[conCMFunction.SourceFunction].ToString().Trim(), //来源函数
IsGeneCode = TransNullToBool(objRow[conCMFunction.IsGeneCode].ToString().Trim()), //是否生成代码
ReturnValueDescription = objRow[conCMFunction.ReturnValueDescription] == DBNull.Value ? null : objRow[conCMFunction.ReturnValueDescription].ToString().Trim(), //返回值说明
IsSysFunction = TransNullToBool(objRow[conCMFunction.IsSysFunction].ToString().Trim()), //是否系统函数
GetCustomAttributes = objRow[conCMFunction.GetCustomAttributes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCMFunction.GetCustomAttributes].ToString().Trim()), //GetCustomAttributes
ClassNameLst = objRow[conCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[conCMFunction.ClassNameLst].ToString().Trim(), //类名列表
UpdDate = objRow[conCMFunction.UpdDate] == DBNull.Value ? null : objRow[conCMFunction.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conCMFunction.UpdUser] == DBNull.Value ? null : objRow[conCMFunction.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conCMFunction.Memo] == DBNull.Value ? null : objRow[conCMFunction.Memo].ToString().Trim(), //说明
IsSynchToServer = TransNullToBool(objRow[conCMFunction.IsSynchToServer].ToString().Trim()), //是否同步到Server
SynchToServerDate = objRow[conCMFunction.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerDate].ToString().Trim(), //同步到Server日期
SynchToServerUser = objRow[conCMFunction.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerUser].ToString().Trim(), //同步到Server用户
IsSynchToClient = TransNullToBool(objRow[conCMFunction.IsSynchToClient].ToString().Trim()), //是否同步到Client
SynchToClientDate = objRow[conCMFunction.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientDate].ToString().Trim(), //同步到Client库日期
SynchToClientUser = objRow[conCMFunction.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientUser].ToString().Trim(), //同步到Client库用户
SynSource = objRow[conCMFunction.SynSource] == DBNull.Value ? null : objRow[conCMFunction.SynSource].ToString().Trim() //同步来源
};
objCMFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMFunctionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCMFunctionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCMFunctionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN();
try
{
objCMFunctionEN.CmFunctionId = objRow[conCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionEN.CmClassId = objRow[conCMFunction.CmClassId].ToString().Trim(); //类Id
objCMFunctionEN.FunctionName = objRow[conCMFunction.FunctionName].ToString().Trim(); //功能名称
objCMFunctionEN.FuncContent = objRow[conCMFunction.FuncContent] == DBNull.Value ? null : objRow[conCMFunction.FuncContent].ToString().Trim(); //函数内容
objCMFunctionEN.KeyWords = objRow[conCMFunction.KeyWords] == DBNull.Value ? null : objRow[conCMFunction.KeyWords].ToString().Trim(); //关键字
objCMFunctionEN.FuncParaLst = objRow[conCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[conCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objCMFunctionEN.FuncComments = objRow[conCMFunction.FuncComments] == DBNull.Value ? null : objRow[conCMFunction.FuncComments].ToString().Trim(); //函数注释
objCMFunctionEN.FunctionSignature = objRow[conCMFunction.FunctionSignature] == DBNull.Value ? null : objRow[conCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objCMFunctionEN.FuncTypeId = objRow[conCMFunction.FuncTypeId] == DBNull.Value ? null : objRow[conCMFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objCMFunctionEN.ReturnType = objRow[conCMFunction.ReturnType] == DBNull.Value ? null : objRow[conCMFunction.ReturnType].ToString().Trim(); //返回类型
objCMFunctionEN.ReturnTypeFullName = objRow[conCMFunction.ReturnTypeFullName] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objCMFunctionEN.IsKnownType = TransNullToBool(objRow[conCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objCMFunctionEN.ReturnTypeId = objRow[conCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objCMFunctionEN.IsAsyncFunc = TransNullToBool(objRow[conCMFunction.IsAsyncFunc].ToString().Trim()); //是否异步函数
objCMFunctionEN.SourceFunction = objRow[conCMFunction.SourceFunction] == DBNull.Value ? null : objRow[conCMFunction.SourceFunction].ToString().Trim(); //来源函数
objCMFunctionEN.IsGeneCode = TransNullToBool(objRow[conCMFunction.IsGeneCode].ToString().Trim()); //是否生成代码
objCMFunctionEN.ReturnValueDescription = objRow[conCMFunction.ReturnValueDescription] == DBNull.Value ? null : objRow[conCMFunction.ReturnValueDescription].ToString().Trim(); //返回值说明
objCMFunctionEN.IsSysFunction = TransNullToBool(objRow[conCMFunction.IsSysFunction].ToString().Trim()); //是否系统函数
objCMFunctionEN.GetCustomAttributes = objRow[conCMFunction.GetCustomAttributes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCMFunction.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objCMFunctionEN.ClassNameLst = objRow[conCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[conCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objCMFunctionEN.UpdDate = objRow[conCMFunction.UpdDate] == DBNull.Value ? null : objRow[conCMFunction.UpdDate].ToString().Trim(); //修改日期
objCMFunctionEN.UpdUser = objRow[conCMFunction.UpdUser] == DBNull.Value ? null : objRow[conCMFunction.UpdUser].ToString().Trim(); //修改者
objCMFunctionEN.Memo = objRow[conCMFunction.Memo] == DBNull.Value ? null : objRow[conCMFunction.Memo].ToString().Trim(); //说明
objCMFunctionEN.IsSynchToServer = TransNullToBool(objRow[conCMFunction.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionEN.SynchToServerDate = objRow[conCMFunction.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionEN.SynchToServerUser = objRow[conCMFunction.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionEN.IsSynchToClient = TransNullToBool(objRow[conCMFunction.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionEN.SynchToClientDate = objRow[conCMFunction.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionEN.SynchToClientUser = objRow[conCMFunction.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionEN.SynSource = objRow[conCMFunction.SynSource] == DBNull.Value ? null : objRow[conCMFunction.SynSource].ToString().Trim(); //同步来源
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCMFunctionDA: GetObjByDataRowCMFunction)", objException.Message));
}
objCMFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMFunctionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCMFunctionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCMFunctionEN objCMFunctionEN = new clsCMFunctionEN();
try
{
objCMFunctionEN.CmFunctionId = objRow[conCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionEN.CmClassId = objRow[conCMFunction.CmClassId].ToString().Trim(); //类Id
objCMFunctionEN.FunctionName = objRow[conCMFunction.FunctionName].ToString().Trim(); //功能名称
objCMFunctionEN.FuncContent = objRow[conCMFunction.FuncContent] == DBNull.Value ? null : objRow[conCMFunction.FuncContent].ToString().Trim(); //函数内容
objCMFunctionEN.KeyWords = objRow[conCMFunction.KeyWords] == DBNull.Value ? null : objRow[conCMFunction.KeyWords].ToString().Trim(); //关键字
objCMFunctionEN.FuncParaLst = objRow[conCMFunction.FuncParaLst] == DBNull.Value ? null : objRow[conCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objCMFunctionEN.FuncComments = objRow[conCMFunction.FuncComments] == DBNull.Value ? null : objRow[conCMFunction.FuncComments].ToString().Trim(); //函数注释
objCMFunctionEN.FunctionSignature = objRow[conCMFunction.FunctionSignature] == DBNull.Value ? null : objRow[conCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objCMFunctionEN.FuncTypeId = objRow[conCMFunction.FuncTypeId] == DBNull.Value ? null : objRow[conCMFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objCMFunctionEN.ReturnType = objRow[conCMFunction.ReturnType] == DBNull.Value ? null : objRow[conCMFunction.ReturnType].ToString().Trim(); //返回类型
objCMFunctionEN.ReturnTypeFullName = objRow[conCMFunction.ReturnTypeFullName] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objCMFunctionEN.IsKnownType = TransNullToBool(objRow[conCMFunction.IsKnownType].ToString().Trim()); //是否已知类型
objCMFunctionEN.ReturnTypeId = objRow[conCMFunction.ReturnTypeId] == DBNull.Value ? null : objRow[conCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objCMFunctionEN.IsAsyncFunc = TransNullToBool(objRow[conCMFunction.IsAsyncFunc].ToString().Trim()); //是否异步函数
objCMFunctionEN.SourceFunction = objRow[conCMFunction.SourceFunction] == DBNull.Value ? null : objRow[conCMFunction.SourceFunction].ToString().Trim(); //来源函数
objCMFunctionEN.IsGeneCode = TransNullToBool(objRow[conCMFunction.IsGeneCode].ToString().Trim()); //是否生成代码
objCMFunctionEN.ReturnValueDescription = objRow[conCMFunction.ReturnValueDescription] == DBNull.Value ? null : objRow[conCMFunction.ReturnValueDescription].ToString().Trim(); //返回值说明
objCMFunctionEN.IsSysFunction = TransNullToBool(objRow[conCMFunction.IsSysFunction].ToString().Trim()); //是否系统函数
objCMFunctionEN.GetCustomAttributes = objRow[conCMFunction.GetCustomAttributes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCMFunction.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objCMFunctionEN.ClassNameLst = objRow[conCMFunction.ClassNameLst] == DBNull.Value ? null : objRow[conCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objCMFunctionEN.UpdDate = objRow[conCMFunction.UpdDate] == DBNull.Value ? null : objRow[conCMFunction.UpdDate].ToString().Trim(); //修改日期
objCMFunctionEN.UpdUser = objRow[conCMFunction.UpdUser] == DBNull.Value ? null : objRow[conCMFunction.UpdUser].ToString().Trim(); //修改者
objCMFunctionEN.Memo = objRow[conCMFunction.Memo] == DBNull.Value ? null : objRow[conCMFunction.Memo].ToString().Trim(); //说明
objCMFunctionEN.IsSynchToServer = TransNullToBool(objRow[conCMFunction.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionEN.SynchToServerDate = objRow[conCMFunction.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionEN.SynchToServerUser = objRow[conCMFunction.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionEN.IsSynchToClient = TransNullToBool(objRow[conCMFunction.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionEN.SynchToClientDate = objRow[conCMFunction.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionEN.SynchToClientUser = objRow[conCMFunction.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunction.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionEN.SynSource = objRow[conCMFunction.SynSource] == DBNull.Value ? null : objRow[conCMFunction.SynSource].ToString().Trim(); //同步来源
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCMFunctionDA: GetObjByDataRow)", objException.Message));
}
objCMFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMFunctionEN;
}

 #endregion 获取一个实体对象

 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetMaxStrID)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public static string GetMaxStrId()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMFunctionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCMFunctionEN._CurrTabName, conCMFunction.CmFunctionId, 8, "");
return strMaxValue;
}

 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public string GetMaxStrIdByPrefix(string strPrefix)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMFunctionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCMFunctionEN._CurrTabName, conCMFunction.CmFunctionId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CmFunctionId from CMFunction where " + strCondition;
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
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetPrimaryKeyID)
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
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CmFunctionId from CMFunction where " + strCondition;
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
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenIsExist_S)
 /// </summary>
 /// <param name = "strCmFunctionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCmFunctionId)
{
CheckPrimaryKey(strCmFunctionId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CMFunction", "CmFunctionId = " + "'"+ strCmFunctionId+"'"))
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
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenIsExistCondRec_S)
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCMFunctionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CMFunction", strCondition))
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
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenIsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsCMFunctionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CMFunction");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCMFunctionEN objCMFunctionEN)
 {
 objCMFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFunctionEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CMFunction where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CMFunction");
objRow = objDS.Tables["CMFunction"].NewRow();
objRow[conCMFunction.CmFunctionId] = objCMFunctionEN.CmFunctionId; //函数Id
objRow[conCMFunction.CmClassId] = objCMFunctionEN.CmClassId; //类Id
objRow[conCMFunction.FunctionName] = objCMFunctionEN.FunctionName; //功能名称
 if (objCMFunctionEN.FuncContent !=  "")
 {
objRow[conCMFunction.FuncContent] = objCMFunctionEN.FuncContent; //函数内容
 }
 if (objCMFunctionEN.KeyWords !=  "")
 {
objRow[conCMFunction.KeyWords] = objCMFunctionEN.KeyWords; //关键字
 }
 if (objCMFunctionEN.FuncParaLst !=  "")
 {
objRow[conCMFunction.FuncParaLst] = objCMFunctionEN.FuncParaLst; //函数参数列表
 }
 if (objCMFunctionEN.FuncComments !=  "")
 {
objRow[conCMFunction.FuncComments] = objCMFunctionEN.FuncComments; //函数注释
 }
 if (objCMFunctionEN.FunctionSignature !=  "")
 {
objRow[conCMFunction.FunctionSignature] = objCMFunctionEN.FunctionSignature; //函数签名
 }
 if (objCMFunctionEN.FuncTypeId !=  "")
 {
objRow[conCMFunction.FuncTypeId] = objCMFunctionEN.FuncTypeId; //函数类型Id
 }
 if (objCMFunctionEN.ReturnType !=  "")
 {
objRow[conCMFunction.ReturnType] = objCMFunctionEN.ReturnType; //返回类型
 }
 if (objCMFunctionEN.ReturnTypeFullName !=  "")
 {
objRow[conCMFunction.ReturnTypeFullName] = objCMFunctionEN.ReturnTypeFullName; //返回类型全名
 }
objRow[conCMFunction.IsKnownType] = objCMFunctionEN.IsKnownType; //是否已知类型
 if (objCMFunctionEN.ReturnTypeId !=  "")
 {
objRow[conCMFunction.ReturnTypeId] = objCMFunctionEN.ReturnTypeId; //返回类型ID
 }
objRow[conCMFunction.IsAsyncFunc] = objCMFunctionEN.IsAsyncFunc; //是否异步函数
 if (objCMFunctionEN.SourceFunction !=  "")
 {
objRow[conCMFunction.SourceFunction] = objCMFunctionEN.SourceFunction; //来源函数
 }
objRow[conCMFunction.IsGeneCode] = objCMFunctionEN.IsGeneCode; //是否生成代码
 if (objCMFunctionEN.ReturnValueDescription !=  "")
 {
objRow[conCMFunction.ReturnValueDescription] = objCMFunctionEN.ReturnValueDescription; //返回值说明
 }
objRow[conCMFunction.IsSysFunction] = objCMFunctionEN.IsSysFunction; //是否系统函数
objRow[conCMFunction.GetCustomAttributes] = objCMFunctionEN.GetCustomAttributes; //GetCustomAttributes
 if (objCMFunctionEN.ClassNameLst !=  "")
 {
objRow[conCMFunction.ClassNameLst] = objCMFunctionEN.ClassNameLst; //类名列表
 }
 if (objCMFunctionEN.UpdDate !=  "")
 {
objRow[conCMFunction.UpdDate] = objCMFunctionEN.UpdDate; //修改日期
 }
 if (objCMFunctionEN.UpdUser !=  "")
 {
objRow[conCMFunction.UpdUser] = objCMFunctionEN.UpdUser; //修改者
 }
 if (objCMFunctionEN.Memo !=  "")
 {
objRow[conCMFunction.Memo] = objCMFunctionEN.Memo; //说明
 }
objRow[conCMFunction.IsSynchToServer] = objCMFunctionEN.IsSynchToServer; //是否同步到Server
 if (objCMFunctionEN.SynchToServerDate !=  "")
 {
objRow[conCMFunction.SynchToServerDate] = objCMFunctionEN.SynchToServerDate; //同步到Server日期
 }
 if (objCMFunctionEN.SynchToServerUser !=  "")
 {
objRow[conCMFunction.SynchToServerUser] = objCMFunctionEN.SynchToServerUser; //同步到Server用户
 }
objRow[conCMFunction.IsSynchToClient] = objCMFunctionEN.IsSynchToClient; //是否同步到Client
 if (objCMFunctionEN.SynchToClientDate !=  "")
 {
objRow[conCMFunction.SynchToClientDate] = objCMFunctionEN.SynchToClientDate; //同步到Client库日期
 }
 if (objCMFunctionEN.SynchToClientUser !=  "")
 {
objRow[conCMFunction.SynchToClientUser] = objCMFunctionEN.SynchToClientUser; //同步到Client库用户
 }
 if (objCMFunctionEN.SynSource !=  "")
 {
objRow[conCMFunction.SynSource] = objCMFunctionEN.SynSource; //同步来源
 }
objDS.Tables[clsCMFunctionEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCMFunctionEN._CurrTabName);
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
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCMFunctionEN objCMFunctionEN)
{
 objCMFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFunctionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMFunctionEN.CmFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.CmFunctionId);
 var strCmFunctionId = objCMFunctionEN.CmFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFunctionId + "'");
 }
 
 if (objCMFunctionEN.CmClassId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.CmClassId);
 var strCmClassId = objCMFunctionEN.CmClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmClassId + "'");
 }
 
 if (objCMFunctionEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FunctionName);
 var strFunctionName = objCMFunctionEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 if (objCMFunctionEN.FuncContent !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FuncContent);
 var strFuncContent = objCMFunctionEN.FuncContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncContent + "'");
 }
 
 if (objCMFunctionEN.KeyWords !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.KeyWords);
 var strKeyWords = objCMFunctionEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyWords + "'");
 }
 
 if (objCMFunctionEN.FuncParaLst !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FuncParaLst);
 var strFuncParaLst = objCMFunctionEN.FuncParaLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncParaLst + "'");
 }
 
 if (objCMFunctionEN.FuncComments !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FuncComments);
 var strFuncComments = objCMFunctionEN.FuncComments.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncComments + "'");
 }
 
 if (objCMFunctionEN.FunctionSignature !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FunctionSignature);
 var strFunctionSignature = objCMFunctionEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignature + "'");
 }
 
 if (objCMFunctionEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FuncTypeId);
 var strFuncTypeId = objCMFunctionEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 if (objCMFunctionEN.ReturnType !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ReturnType);
 var strReturnType = objCMFunctionEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnType + "'");
 }
 
 if (objCMFunctionEN.ReturnTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ReturnTypeFullName);
 var strReturnTypeFullName = objCMFunctionEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsKnownType);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsKnownType  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ReturnTypeId);
 var strReturnTypeId = objCMFunctionEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsAsyncFunc);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsAsyncFunc  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.SourceFunction !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SourceFunction);
 var strSourceFunction = objCMFunctionEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceFunction + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsGeneCode);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsGeneCode  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.ReturnValueDescription !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ReturnValueDescription);
 var strReturnValueDescription = objCMFunctionEN.ReturnValueDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnValueDescription + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsSysFunction);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsSysFunction  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.GetCustomAttributes !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.GetCustomAttributes);
 arrValueListForInsert.Add(objCMFunctionEN.GetCustomAttributes.ToString());
 }
 
 if (objCMFunctionEN.ClassNameLst !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ClassNameLst);
 var strClassNameLst = objCMFunctionEN.ClassNameLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassNameLst + "'");
 }
 
 if (objCMFunctionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.UpdDate);
 var strUpdDate = objCMFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFunctionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.UpdUser);
 var strUpdUser = objCMFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFunctionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.Memo);
 var strMemo = objCMFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsSynchToServer);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsSynchToServer  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.SynchToServerDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynchToServerDate);
 var strSynchToServerDate = objCMFunctionEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerDate + "'");
 }
 
 if (objCMFunctionEN.SynchToServerUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynchToServerUser);
 var strSynchToServerUser = objCMFunctionEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerUser + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsSynchToClient);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsSynchToClient  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.SynchToClientDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynchToClientDate);
 var strSynchToClientDate = objCMFunctionEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientDate + "'");
 }
 
 if (objCMFunctionEN.SynchToClientUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynchToClientUser);
 var strSynchToClientUser = objCMFunctionEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientUser + "'");
 }
 
 if (objCMFunctionEN.SynSource !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynSource);
 var strSynSource = objCMFunctionEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynSource + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFunction");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCMFunctionEN objCMFunctionEN)
{
 objCMFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFunctionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMFunctionEN.CmFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.CmFunctionId);
 var strCmFunctionId = objCMFunctionEN.CmFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFunctionId + "'");
 }
 
 if (objCMFunctionEN.CmClassId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.CmClassId);
 var strCmClassId = objCMFunctionEN.CmClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmClassId + "'");
 }
 
 if (objCMFunctionEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FunctionName);
 var strFunctionName = objCMFunctionEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 if (objCMFunctionEN.FuncContent !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FuncContent);
 var strFuncContent = objCMFunctionEN.FuncContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncContent + "'");
 }
 
 if (objCMFunctionEN.KeyWords !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.KeyWords);
 var strKeyWords = objCMFunctionEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyWords + "'");
 }
 
 if (objCMFunctionEN.FuncParaLst !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FuncParaLst);
 var strFuncParaLst = objCMFunctionEN.FuncParaLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncParaLst + "'");
 }
 
 if (objCMFunctionEN.FuncComments !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FuncComments);
 var strFuncComments = objCMFunctionEN.FuncComments.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncComments + "'");
 }
 
 if (objCMFunctionEN.FunctionSignature !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FunctionSignature);
 var strFunctionSignature = objCMFunctionEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignature + "'");
 }
 
 if (objCMFunctionEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FuncTypeId);
 var strFuncTypeId = objCMFunctionEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 if (objCMFunctionEN.ReturnType !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ReturnType);
 var strReturnType = objCMFunctionEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnType + "'");
 }
 
 if (objCMFunctionEN.ReturnTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ReturnTypeFullName);
 var strReturnTypeFullName = objCMFunctionEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsKnownType);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsKnownType  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ReturnTypeId);
 var strReturnTypeId = objCMFunctionEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsAsyncFunc);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsAsyncFunc  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.SourceFunction !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SourceFunction);
 var strSourceFunction = objCMFunctionEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceFunction + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsGeneCode);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsGeneCode  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.ReturnValueDescription !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ReturnValueDescription);
 var strReturnValueDescription = objCMFunctionEN.ReturnValueDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnValueDescription + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsSysFunction);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsSysFunction  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.GetCustomAttributes !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.GetCustomAttributes);
 arrValueListForInsert.Add(objCMFunctionEN.GetCustomAttributes.ToString());
 }
 
 if (objCMFunctionEN.ClassNameLst !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ClassNameLst);
 var strClassNameLst = objCMFunctionEN.ClassNameLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassNameLst + "'");
 }
 
 if (objCMFunctionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.UpdDate);
 var strUpdDate = objCMFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFunctionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.UpdUser);
 var strUpdUser = objCMFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFunctionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.Memo);
 var strMemo = objCMFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsSynchToServer);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsSynchToServer  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.SynchToServerDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynchToServerDate);
 var strSynchToServerDate = objCMFunctionEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerDate + "'");
 }
 
 if (objCMFunctionEN.SynchToServerUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynchToServerUser);
 var strSynchToServerUser = objCMFunctionEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerUser + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsSynchToClient);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsSynchToClient  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.SynchToClientDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynchToClientDate);
 var strSynchToClientDate = objCMFunctionEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientDate + "'");
 }
 
 if (objCMFunctionEN.SynchToClientUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynchToClientUser);
 var strSynchToClientUser = objCMFunctionEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientUser + "'");
 }
 
 if (objCMFunctionEN.SynSource !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynSource);
 var strSynSource = objCMFunctionEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynSource + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFunction");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCMFunctionEN.CmFunctionId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCMFunctionEN objCMFunctionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCMFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFunctionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMFunctionEN.CmFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.CmFunctionId);
 var strCmFunctionId = objCMFunctionEN.CmFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFunctionId + "'");
 }
 
 if (objCMFunctionEN.CmClassId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.CmClassId);
 var strCmClassId = objCMFunctionEN.CmClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmClassId + "'");
 }
 
 if (objCMFunctionEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FunctionName);
 var strFunctionName = objCMFunctionEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 if (objCMFunctionEN.FuncContent !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FuncContent);
 var strFuncContent = objCMFunctionEN.FuncContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncContent + "'");
 }
 
 if (objCMFunctionEN.KeyWords !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.KeyWords);
 var strKeyWords = objCMFunctionEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyWords + "'");
 }
 
 if (objCMFunctionEN.FuncParaLst !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FuncParaLst);
 var strFuncParaLst = objCMFunctionEN.FuncParaLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncParaLst + "'");
 }
 
 if (objCMFunctionEN.FuncComments !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FuncComments);
 var strFuncComments = objCMFunctionEN.FuncComments.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncComments + "'");
 }
 
 if (objCMFunctionEN.FunctionSignature !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FunctionSignature);
 var strFunctionSignature = objCMFunctionEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignature + "'");
 }
 
 if (objCMFunctionEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FuncTypeId);
 var strFuncTypeId = objCMFunctionEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 if (objCMFunctionEN.ReturnType !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ReturnType);
 var strReturnType = objCMFunctionEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnType + "'");
 }
 
 if (objCMFunctionEN.ReturnTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ReturnTypeFullName);
 var strReturnTypeFullName = objCMFunctionEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsKnownType);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsKnownType  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ReturnTypeId);
 var strReturnTypeId = objCMFunctionEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsAsyncFunc);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsAsyncFunc  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.SourceFunction !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SourceFunction);
 var strSourceFunction = objCMFunctionEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceFunction + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsGeneCode);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsGeneCode  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.ReturnValueDescription !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ReturnValueDescription);
 var strReturnValueDescription = objCMFunctionEN.ReturnValueDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnValueDescription + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsSysFunction);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsSysFunction  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.GetCustomAttributes !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.GetCustomAttributes);
 arrValueListForInsert.Add(objCMFunctionEN.GetCustomAttributes.ToString());
 }
 
 if (objCMFunctionEN.ClassNameLst !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ClassNameLst);
 var strClassNameLst = objCMFunctionEN.ClassNameLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassNameLst + "'");
 }
 
 if (objCMFunctionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.UpdDate);
 var strUpdDate = objCMFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFunctionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.UpdUser);
 var strUpdUser = objCMFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFunctionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.Memo);
 var strMemo = objCMFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsSynchToServer);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsSynchToServer  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.SynchToServerDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynchToServerDate);
 var strSynchToServerDate = objCMFunctionEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerDate + "'");
 }
 
 if (objCMFunctionEN.SynchToServerUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynchToServerUser);
 var strSynchToServerUser = objCMFunctionEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerUser + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsSynchToClient);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsSynchToClient  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.SynchToClientDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynchToClientDate);
 var strSynchToClientDate = objCMFunctionEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientDate + "'");
 }
 
 if (objCMFunctionEN.SynchToClientUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynchToClientUser);
 var strSynchToClientUser = objCMFunctionEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientUser + "'");
 }
 
 if (objCMFunctionEN.SynSource !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynSource);
 var strSynSource = objCMFunctionEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynSource + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFunction");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCMFunctionEN.CmFunctionId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCMFunctionEN objCMFunctionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCMFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFunctionEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCMFunctionEN.CmFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.CmFunctionId);
 var strCmFunctionId = objCMFunctionEN.CmFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFunctionId + "'");
 }
 
 if (objCMFunctionEN.CmClassId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.CmClassId);
 var strCmClassId = objCMFunctionEN.CmClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmClassId + "'");
 }
 
 if (objCMFunctionEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FunctionName);
 var strFunctionName = objCMFunctionEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 if (objCMFunctionEN.FuncContent !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FuncContent);
 var strFuncContent = objCMFunctionEN.FuncContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncContent + "'");
 }
 
 if (objCMFunctionEN.KeyWords !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.KeyWords);
 var strKeyWords = objCMFunctionEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyWords + "'");
 }
 
 if (objCMFunctionEN.FuncParaLst !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FuncParaLst);
 var strFuncParaLst = objCMFunctionEN.FuncParaLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncParaLst + "'");
 }
 
 if (objCMFunctionEN.FuncComments !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FuncComments);
 var strFuncComments = objCMFunctionEN.FuncComments.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncComments + "'");
 }
 
 if (objCMFunctionEN.FunctionSignature !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FunctionSignature);
 var strFunctionSignature = objCMFunctionEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignature + "'");
 }
 
 if (objCMFunctionEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.FuncTypeId);
 var strFuncTypeId = objCMFunctionEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 if (objCMFunctionEN.ReturnType !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ReturnType);
 var strReturnType = objCMFunctionEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnType + "'");
 }
 
 if (objCMFunctionEN.ReturnTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ReturnTypeFullName);
 var strReturnTypeFullName = objCMFunctionEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsKnownType);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsKnownType  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ReturnTypeId);
 var strReturnTypeId = objCMFunctionEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsAsyncFunc);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsAsyncFunc  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.SourceFunction !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SourceFunction);
 var strSourceFunction = objCMFunctionEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceFunction + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsGeneCode);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsGeneCode  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.ReturnValueDescription !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ReturnValueDescription);
 var strReturnValueDescription = objCMFunctionEN.ReturnValueDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnValueDescription + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsSysFunction);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsSysFunction  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.GetCustomAttributes !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.GetCustomAttributes);
 arrValueListForInsert.Add(objCMFunctionEN.GetCustomAttributes.ToString());
 }
 
 if (objCMFunctionEN.ClassNameLst !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.ClassNameLst);
 var strClassNameLst = objCMFunctionEN.ClassNameLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassNameLst + "'");
 }
 
 if (objCMFunctionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.UpdDate);
 var strUpdDate = objCMFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFunctionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.UpdUser);
 var strUpdUser = objCMFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFunctionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.Memo);
 var strMemo = objCMFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsSynchToServer);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsSynchToServer  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.SynchToServerDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynchToServerDate);
 var strSynchToServerDate = objCMFunctionEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerDate + "'");
 }
 
 if (objCMFunctionEN.SynchToServerUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynchToServerUser);
 var strSynchToServerUser = objCMFunctionEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerUser + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunction.IsSynchToClient);
 arrValueListForInsert.Add("'" + (objCMFunctionEN.IsSynchToClient  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionEN.SynchToClientDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynchToClientDate);
 var strSynchToClientDate = objCMFunctionEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientDate + "'");
 }
 
 if (objCMFunctionEN.SynchToClientUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynchToClientUser);
 var strSynchToClientUser = objCMFunctionEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientUser + "'");
 }
 
 if (objCMFunctionEN.SynSource !=  null)
 {
 arrFieldListForInsert.Add(conCMFunction.SynSource);
 var strSynSource = objCMFunctionEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynSource + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFunction");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCMFunctions(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CMFunction where CmFunctionId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CMFunction");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCmFunctionId = oRow[conCMFunction.CmFunctionId].ToString().Trim();
if (IsExist(strCmFunctionId))
{
 string strResult = "关键字变量值为:" + string.Format("CmFunctionId = {0}", strCmFunctionId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCMFunctionEN._CurrTabName ].NewRow();
objRow[conCMFunction.CmFunctionId] = oRow[conCMFunction.CmFunctionId].ToString().Trim(); //函数Id
objRow[conCMFunction.CmClassId] = oRow[conCMFunction.CmClassId].ToString().Trim(); //类Id
objRow[conCMFunction.FunctionName] = oRow[conCMFunction.FunctionName].ToString().Trim(); //功能名称
objRow[conCMFunction.FuncContent] = oRow[conCMFunction.FuncContent].ToString().Trim(); //函数内容
objRow[conCMFunction.KeyWords] = oRow[conCMFunction.KeyWords].ToString().Trim(); //关键字
objRow[conCMFunction.FuncParaLst] = oRow[conCMFunction.FuncParaLst].ToString().Trim(); //函数参数列表
objRow[conCMFunction.FuncComments] = oRow[conCMFunction.FuncComments].ToString().Trim(); //函数注释
objRow[conCMFunction.FunctionSignature] = oRow[conCMFunction.FunctionSignature].ToString().Trim(); //函数签名
objRow[conCMFunction.FuncTypeId] = oRow[conCMFunction.FuncTypeId].ToString().Trim(); //函数类型Id
objRow[conCMFunction.ReturnType] = oRow[conCMFunction.ReturnType].ToString().Trim(); //返回类型
objRow[conCMFunction.ReturnTypeFullName] = oRow[conCMFunction.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objRow[conCMFunction.IsKnownType] = oRow[conCMFunction.IsKnownType].ToString().Trim(); //是否已知类型
objRow[conCMFunction.ReturnTypeId] = oRow[conCMFunction.ReturnTypeId].ToString().Trim(); //返回类型ID
objRow[conCMFunction.IsAsyncFunc] = oRow[conCMFunction.IsAsyncFunc].ToString().Trim(); //是否异步函数
objRow[conCMFunction.SourceFunction] = oRow[conCMFunction.SourceFunction].ToString().Trim(); //来源函数
objRow[conCMFunction.IsGeneCode] = oRow[conCMFunction.IsGeneCode].ToString().Trim(); //是否生成代码
objRow[conCMFunction.ReturnValueDescription] = oRow[conCMFunction.ReturnValueDescription].ToString().Trim(); //返回值说明
objRow[conCMFunction.IsSysFunction] = oRow[conCMFunction.IsSysFunction].ToString().Trim(); //是否系统函数
objRow[conCMFunction.GetCustomAttributes] = oRow[conCMFunction.GetCustomAttributes].ToString().Trim(); //GetCustomAttributes
objRow[conCMFunction.ClassNameLst] = oRow[conCMFunction.ClassNameLst].ToString().Trim(); //类名列表
objRow[conCMFunction.UpdDate] = oRow[conCMFunction.UpdDate].ToString().Trim(); //修改日期
objRow[conCMFunction.UpdUser] = oRow[conCMFunction.UpdUser].ToString().Trim(); //修改者
objRow[conCMFunction.Memo] = oRow[conCMFunction.Memo].ToString().Trim(); //说明
objRow[conCMFunction.IsSynchToServer] = oRow[conCMFunction.IsSynchToServer].ToString().Trim(); //是否同步到Server
objRow[conCMFunction.SynchToServerDate] = oRow[conCMFunction.SynchToServerDate].ToString().Trim(); //同步到Server日期
objRow[conCMFunction.SynchToServerUser] = oRow[conCMFunction.SynchToServerUser].ToString().Trim(); //同步到Server用户
objRow[conCMFunction.IsSynchToClient] = oRow[conCMFunction.IsSynchToClient].ToString().Trim(); //是否同步到Client
objRow[conCMFunction.SynchToClientDate] = oRow[conCMFunction.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objRow[conCMFunction.SynchToClientUser] = oRow[conCMFunction.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objRow[conCMFunction.SynSource] = oRow[conCMFunction.SynSource].ToString().Trim(); //同步来源
 objDS.Tables[clsCMFunctionEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCMFunctionEN._CurrTabName);
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
 /// <param name = "objCMFunctionEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCMFunctionEN objCMFunctionEN)
{
 objCMFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFunctionEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CMFunction where CmFunctionId = " + "'"+ objCMFunctionEN.CmFunctionId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCMFunctionEN._CurrTabName);
if (objDS.Tables[clsCMFunctionEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CmFunctionId = " + "'"+ objCMFunctionEN.CmFunctionId+"'");
return false;
}
objRow = objDS.Tables[clsCMFunctionEN._CurrTabName].Rows[0];
 if (objCMFunctionEN.IsUpdated(conCMFunction.CmFunctionId))
 {
objRow[conCMFunction.CmFunctionId] = objCMFunctionEN.CmFunctionId; //函数Id
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.CmClassId))
 {
objRow[conCMFunction.CmClassId] = objCMFunctionEN.CmClassId; //类Id
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.FunctionName))
 {
objRow[conCMFunction.FunctionName] = objCMFunctionEN.FunctionName; //功能名称
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncContent))
 {
objRow[conCMFunction.FuncContent] = objCMFunctionEN.FuncContent; //函数内容
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.KeyWords))
 {
objRow[conCMFunction.KeyWords] = objCMFunctionEN.KeyWords; //关键字
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncParaLst))
 {
objRow[conCMFunction.FuncParaLst] = objCMFunctionEN.FuncParaLst; //函数参数列表
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncComments))
 {
objRow[conCMFunction.FuncComments] = objCMFunctionEN.FuncComments; //函数注释
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.FunctionSignature))
 {
objRow[conCMFunction.FunctionSignature] = objCMFunctionEN.FunctionSignature; //函数签名
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncTypeId))
 {
objRow[conCMFunction.FuncTypeId] = objCMFunctionEN.FuncTypeId; //函数类型Id
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnType))
 {
objRow[conCMFunction.ReturnType] = objCMFunctionEN.ReturnType; //返回类型
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnTypeFullName))
 {
objRow[conCMFunction.ReturnTypeFullName] = objCMFunctionEN.ReturnTypeFullName; //返回类型全名
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsKnownType))
 {
objRow[conCMFunction.IsKnownType] = objCMFunctionEN.IsKnownType; //是否已知类型
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnTypeId))
 {
objRow[conCMFunction.ReturnTypeId] = objCMFunctionEN.ReturnTypeId; //返回类型ID
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsAsyncFunc))
 {
objRow[conCMFunction.IsAsyncFunc] = objCMFunctionEN.IsAsyncFunc; //是否异步函数
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.SourceFunction))
 {
objRow[conCMFunction.SourceFunction] = objCMFunctionEN.SourceFunction; //来源函数
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsGeneCode))
 {
objRow[conCMFunction.IsGeneCode] = objCMFunctionEN.IsGeneCode; //是否生成代码
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnValueDescription))
 {
objRow[conCMFunction.ReturnValueDescription] = objCMFunctionEN.ReturnValueDescription; //返回值说明
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsSysFunction))
 {
objRow[conCMFunction.IsSysFunction] = objCMFunctionEN.IsSysFunction; //是否系统函数
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.GetCustomAttributes))
 {
objRow[conCMFunction.GetCustomAttributes] = objCMFunctionEN.GetCustomAttributes; //GetCustomAttributes
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.ClassNameLst))
 {
objRow[conCMFunction.ClassNameLst] = objCMFunctionEN.ClassNameLst; //类名列表
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.UpdDate))
 {
objRow[conCMFunction.UpdDate] = objCMFunctionEN.UpdDate; //修改日期
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.UpdUser))
 {
objRow[conCMFunction.UpdUser] = objCMFunctionEN.UpdUser; //修改者
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.Memo))
 {
objRow[conCMFunction.Memo] = objCMFunctionEN.Memo; //说明
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsSynchToServer))
 {
objRow[conCMFunction.IsSynchToServer] = objCMFunctionEN.IsSynchToServer; //是否同步到Server
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToServerDate))
 {
objRow[conCMFunction.SynchToServerDate] = objCMFunctionEN.SynchToServerDate; //同步到Server日期
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToServerUser))
 {
objRow[conCMFunction.SynchToServerUser] = objCMFunctionEN.SynchToServerUser; //同步到Server用户
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsSynchToClient))
 {
objRow[conCMFunction.IsSynchToClient] = objCMFunctionEN.IsSynchToClient; //是否同步到Client
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToClientDate))
 {
objRow[conCMFunction.SynchToClientDate] = objCMFunctionEN.SynchToClientDate; //同步到Client库日期
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToClientUser))
 {
objRow[conCMFunction.SynchToClientUser] = objCMFunctionEN.SynchToClientUser; //同步到Client库用户
 }
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynSource))
 {
objRow[conCMFunction.SynSource] = objCMFunctionEN.SynSource; //同步来源
 }
try
{
objDA.Update(objDS, clsCMFunctionEN._CurrTabName);
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
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCMFunctionEN objCMFunctionEN)
{
 objCMFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFunctionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CMFunction Set ");
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.CmClassId))
 {
 if (objCMFunctionEN.CmClassId !=  null)
 {
 var strCmClassId = objCMFunctionEN.CmClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmClassId, conCMFunction.CmClassId); //类Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.CmClassId); //类Id
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FunctionName))
 {
 if (objCMFunctionEN.FunctionName !=  null)
 {
 var strFunctionName = objCMFunctionEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionName, conCMFunction.FunctionName); //功能名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.FunctionName); //功能名称
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncContent))
 {
 if (objCMFunctionEN.FuncContent !=  null)
 {
 var strFuncContent = objCMFunctionEN.FuncContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncContent, conCMFunction.FuncContent); //函数内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.FuncContent); //函数内容
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.KeyWords))
 {
 if (objCMFunctionEN.KeyWords !=  null)
 {
 var strKeyWords = objCMFunctionEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyWords, conCMFunction.KeyWords); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.KeyWords); //关键字
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncParaLst))
 {
 if (objCMFunctionEN.FuncParaLst !=  null)
 {
 var strFuncParaLst = objCMFunctionEN.FuncParaLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncParaLst, conCMFunction.FuncParaLst); //函数参数列表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.FuncParaLst); //函数参数列表
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncComments))
 {
 if (objCMFunctionEN.FuncComments !=  null)
 {
 var strFuncComments = objCMFunctionEN.FuncComments.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncComments, conCMFunction.FuncComments); //函数注释
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.FuncComments); //函数注释
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FunctionSignature))
 {
 if (objCMFunctionEN.FunctionSignature !=  null)
 {
 var strFunctionSignature = objCMFunctionEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionSignature, conCMFunction.FunctionSignature); //函数签名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.FunctionSignature); //函数签名
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncTypeId))
 {
 if (objCMFunctionEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objCMFunctionEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncTypeId, conCMFunction.FuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.FuncTypeId); //函数类型Id
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnType))
 {
 if (objCMFunctionEN.ReturnType !=  null)
 {
 var strReturnType = objCMFunctionEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnType, conCMFunction.ReturnType); //返回类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.ReturnType); //返回类型
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnTypeFullName))
 {
 if (objCMFunctionEN.ReturnTypeFullName !=  null)
 {
 var strReturnTypeFullName = objCMFunctionEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTypeFullName, conCMFunction.ReturnTypeFullName); //返回类型全名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.ReturnTypeFullName); //返回类型全名
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsKnownType))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFunctionEN.IsKnownType == true?"1":"0", conCMFunction.IsKnownType); //是否已知类型
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnTypeId))
 {
 if (objCMFunctionEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objCMFunctionEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTypeId, conCMFunction.ReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.ReturnTypeId); //返回类型ID
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsAsyncFunc))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFunctionEN.IsAsyncFunc == true?"1":"0", conCMFunction.IsAsyncFunc); //是否异步函数
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SourceFunction))
 {
 if (objCMFunctionEN.SourceFunction !=  null)
 {
 var strSourceFunction = objCMFunctionEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceFunction, conCMFunction.SourceFunction); //来源函数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.SourceFunction); //来源函数
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsGeneCode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFunctionEN.IsGeneCode == true?"1":"0", conCMFunction.IsGeneCode); //是否生成代码
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnValueDescription))
 {
 if (objCMFunctionEN.ReturnValueDescription !=  null)
 {
 var strReturnValueDescription = objCMFunctionEN.ReturnValueDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnValueDescription, conCMFunction.ReturnValueDescription); //返回值说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.ReturnValueDescription); //返回值说明
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsSysFunction))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFunctionEN.IsSysFunction == true?"1":"0", conCMFunction.IsSysFunction); //是否系统函数
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.GetCustomAttributes))
 {
 if (objCMFunctionEN.GetCustomAttributes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCMFunctionEN.GetCustomAttributes, conCMFunction.GetCustomAttributes); //GetCustomAttributes
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.GetCustomAttributes); //GetCustomAttributes
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ClassNameLst))
 {
 if (objCMFunctionEN.ClassNameLst !=  null)
 {
 var strClassNameLst = objCMFunctionEN.ClassNameLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClassNameLst, conCMFunction.ClassNameLst); //类名列表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.ClassNameLst); //类名列表
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.UpdDate))
 {
 if (objCMFunctionEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCMFunction.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.UpdDate); //修改日期
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.UpdUser))
 {
 if (objCMFunctionEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCMFunction.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.UpdUser); //修改者
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.Memo))
 {
 if (objCMFunctionEN.Memo !=  null)
 {
 var strMemo = objCMFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCMFunction.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.Memo); //说明
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsSynchToServer))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFunctionEN.IsSynchToServer == true?"1":"0", conCMFunction.IsSynchToServer); //是否同步到Server
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToServerDate))
 {
 if (objCMFunctionEN.SynchToServerDate !=  null)
 {
 var strSynchToServerDate = objCMFunctionEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToServerDate, conCMFunction.SynchToServerDate); //同步到Server日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.SynchToServerDate); //同步到Server日期
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToServerUser))
 {
 if (objCMFunctionEN.SynchToServerUser !=  null)
 {
 var strSynchToServerUser = objCMFunctionEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToServerUser, conCMFunction.SynchToServerUser); //同步到Server用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.SynchToServerUser); //同步到Server用户
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsSynchToClient))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFunctionEN.IsSynchToClient == true?"1":"0", conCMFunction.IsSynchToClient); //是否同步到Client
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToClientDate))
 {
 if (objCMFunctionEN.SynchToClientDate !=  null)
 {
 var strSynchToClientDate = objCMFunctionEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToClientDate, conCMFunction.SynchToClientDate); //同步到Client库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.SynchToClientDate); //同步到Client库日期
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToClientUser))
 {
 if (objCMFunctionEN.SynchToClientUser !=  null)
 {
 var strSynchToClientUser = objCMFunctionEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToClientUser, conCMFunction.SynchToClientUser); //同步到Client库用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.SynchToClientUser); //同步到Client库用户
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynSource))
 {
 if (objCMFunctionEN.SynSource !=  null)
 {
 var strSynSource = objCMFunctionEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynSource, conCMFunction.SynSource); //同步来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.SynSource); //同步来源
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CmFunctionId = '{0}'", objCMFunctionEN.CmFunctionId); 
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
 /// <param name = "objCMFunctionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCMFunctionEN objCMFunctionEN, string strCondition)
{
 objCMFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFunctionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMFunction Set ");
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.CmClassId))
 {
 if (objCMFunctionEN.CmClassId !=  null)
 {
 var strCmClassId = objCMFunctionEN.CmClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmClassId = '{0}',", strCmClassId); //类Id
 }
 else
 {
 sbSQL.Append(" CmClassId = null,"); //类Id
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FunctionName))
 {
 if (objCMFunctionEN.FunctionName !=  null)
 {
 var strFunctionName = objCMFunctionEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionName = '{0}',", strFunctionName); //功能名称
 }
 else
 {
 sbSQL.Append(" FunctionName = null,"); //功能名称
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncContent))
 {
 if (objCMFunctionEN.FuncContent !=  null)
 {
 var strFuncContent = objCMFunctionEN.FuncContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncContent = '{0}',", strFuncContent); //函数内容
 }
 else
 {
 sbSQL.Append(" FuncContent = null,"); //函数内容
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.KeyWords))
 {
 if (objCMFunctionEN.KeyWords !=  null)
 {
 var strKeyWords = objCMFunctionEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyWords = '{0}',", strKeyWords); //关键字
 }
 else
 {
 sbSQL.Append(" KeyWords = null,"); //关键字
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncParaLst))
 {
 if (objCMFunctionEN.FuncParaLst !=  null)
 {
 var strFuncParaLst = objCMFunctionEN.FuncParaLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncParaLst = '{0}',", strFuncParaLst); //函数参数列表
 }
 else
 {
 sbSQL.Append(" FuncParaLst = null,"); //函数参数列表
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncComments))
 {
 if (objCMFunctionEN.FuncComments !=  null)
 {
 var strFuncComments = objCMFunctionEN.FuncComments.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncComments = '{0}',", strFuncComments); //函数注释
 }
 else
 {
 sbSQL.Append(" FuncComments = null,"); //函数注释
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FunctionSignature))
 {
 if (objCMFunctionEN.FunctionSignature !=  null)
 {
 var strFunctionSignature = objCMFunctionEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionSignature = '{0}',", strFunctionSignature); //函数签名
 }
 else
 {
 sbSQL.Append(" FunctionSignature = null,"); //函数签名
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncTypeId))
 {
 if (objCMFunctionEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objCMFunctionEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncTypeId = '{0}',", strFuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.Append(" FuncTypeId = null,"); //函数类型Id
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnType))
 {
 if (objCMFunctionEN.ReturnType !=  null)
 {
 var strReturnType = objCMFunctionEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnType = '{0}',", strReturnType); //返回类型
 }
 else
 {
 sbSQL.Append(" ReturnType = null,"); //返回类型
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnTypeFullName))
 {
 if (objCMFunctionEN.ReturnTypeFullName !=  null)
 {
 var strReturnTypeFullName = objCMFunctionEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTypeFullName = '{0}',", strReturnTypeFullName); //返回类型全名
 }
 else
 {
 sbSQL.Append(" ReturnTypeFullName = null,"); //返回类型全名
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsKnownType))
 {
 sbSQL.AppendFormat(" IsKnownType = '{0}',", objCMFunctionEN.IsKnownType == true?"1":"0"); //是否已知类型
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnTypeId))
 {
 if (objCMFunctionEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objCMFunctionEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTypeId = '{0}',", strReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.Append(" ReturnTypeId = null,"); //返回类型ID
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsAsyncFunc))
 {
 sbSQL.AppendFormat(" IsAsyncFunc = '{0}',", objCMFunctionEN.IsAsyncFunc == true?"1":"0"); //是否异步函数
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SourceFunction))
 {
 if (objCMFunctionEN.SourceFunction !=  null)
 {
 var strSourceFunction = objCMFunctionEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceFunction = '{0}',", strSourceFunction); //来源函数
 }
 else
 {
 sbSQL.Append(" SourceFunction = null,"); //来源函数
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsGeneCode))
 {
 sbSQL.AppendFormat(" IsGeneCode = '{0}',", objCMFunctionEN.IsGeneCode == true?"1":"0"); //是否生成代码
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnValueDescription))
 {
 if (objCMFunctionEN.ReturnValueDescription !=  null)
 {
 var strReturnValueDescription = objCMFunctionEN.ReturnValueDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnValueDescription = '{0}',", strReturnValueDescription); //返回值说明
 }
 else
 {
 sbSQL.Append(" ReturnValueDescription = null,"); //返回值说明
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsSysFunction))
 {
 sbSQL.AppendFormat(" IsSysFunction = '{0}',", objCMFunctionEN.IsSysFunction == true?"1":"0"); //是否系统函数
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.GetCustomAttributes))
 {
 if (objCMFunctionEN.GetCustomAttributes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCMFunctionEN.GetCustomAttributes, conCMFunction.GetCustomAttributes); //GetCustomAttributes
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.GetCustomAttributes); //GetCustomAttributes
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ClassNameLst))
 {
 if (objCMFunctionEN.ClassNameLst !=  null)
 {
 var strClassNameLst = objCMFunctionEN.ClassNameLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassNameLst = '{0}',", strClassNameLst); //类名列表
 }
 else
 {
 sbSQL.Append(" ClassNameLst = null,"); //类名列表
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.UpdDate))
 {
 if (objCMFunctionEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.UpdUser))
 {
 if (objCMFunctionEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.Memo))
 {
 if (objCMFunctionEN.Memo !=  null)
 {
 var strMemo = objCMFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsSynchToServer))
 {
 sbSQL.AppendFormat(" IsSynchToServer = '{0}',", objCMFunctionEN.IsSynchToServer == true?"1":"0"); //是否同步到Server
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToServerDate))
 {
 if (objCMFunctionEN.SynchToServerDate !=  null)
 {
 var strSynchToServerDate = objCMFunctionEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToServerDate = '{0}',", strSynchToServerDate); //同步到Server日期
 }
 else
 {
 sbSQL.Append(" SynchToServerDate = null,"); //同步到Server日期
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToServerUser))
 {
 if (objCMFunctionEN.SynchToServerUser !=  null)
 {
 var strSynchToServerUser = objCMFunctionEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToServerUser = '{0}',", strSynchToServerUser); //同步到Server用户
 }
 else
 {
 sbSQL.Append(" SynchToServerUser = null,"); //同步到Server用户
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsSynchToClient))
 {
 sbSQL.AppendFormat(" IsSynchToClient = '{0}',", objCMFunctionEN.IsSynchToClient == true?"1":"0"); //是否同步到Client
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToClientDate))
 {
 if (objCMFunctionEN.SynchToClientDate !=  null)
 {
 var strSynchToClientDate = objCMFunctionEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToClientDate = '{0}',", strSynchToClientDate); //同步到Client库日期
 }
 else
 {
 sbSQL.Append(" SynchToClientDate = null,"); //同步到Client库日期
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToClientUser))
 {
 if (objCMFunctionEN.SynchToClientUser !=  null)
 {
 var strSynchToClientUser = objCMFunctionEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToClientUser = '{0}',", strSynchToClientUser); //同步到Client库用户
 }
 else
 {
 sbSQL.Append(" SynchToClientUser = null,"); //同步到Client库用户
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynSource))
 {
 if (objCMFunctionEN.SynSource !=  null)
 {
 var strSynSource = objCMFunctionEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynSource = '{0}',", strSynSource); //同步来源
 }
 else
 {
 sbSQL.Append(" SynSource = null,"); //同步来源
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
 /// <param name = "objCMFunctionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCMFunctionEN objCMFunctionEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCMFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFunctionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMFunction Set ");
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.CmClassId))
 {
 if (objCMFunctionEN.CmClassId !=  null)
 {
 var strCmClassId = objCMFunctionEN.CmClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmClassId = '{0}',", strCmClassId); //类Id
 }
 else
 {
 sbSQL.Append(" CmClassId = null,"); //类Id
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FunctionName))
 {
 if (objCMFunctionEN.FunctionName !=  null)
 {
 var strFunctionName = objCMFunctionEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionName = '{0}',", strFunctionName); //功能名称
 }
 else
 {
 sbSQL.Append(" FunctionName = null,"); //功能名称
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncContent))
 {
 if (objCMFunctionEN.FuncContent !=  null)
 {
 var strFuncContent = objCMFunctionEN.FuncContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncContent = '{0}',", strFuncContent); //函数内容
 }
 else
 {
 sbSQL.Append(" FuncContent = null,"); //函数内容
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.KeyWords))
 {
 if (objCMFunctionEN.KeyWords !=  null)
 {
 var strKeyWords = objCMFunctionEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyWords = '{0}',", strKeyWords); //关键字
 }
 else
 {
 sbSQL.Append(" KeyWords = null,"); //关键字
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncParaLst))
 {
 if (objCMFunctionEN.FuncParaLst !=  null)
 {
 var strFuncParaLst = objCMFunctionEN.FuncParaLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncParaLst = '{0}',", strFuncParaLst); //函数参数列表
 }
 else
 {
 sbSQL.Append(" FuncParaLst = null,"); //函数参数列表
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncComments))
 {
 if (objCMFunctionEN.FuncComments !=  null)
 {
 var strFuncComments = objCMFunctionEN.FuncComments.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncComments = '{0}',", strFuncComments); //函数注释
 }
 else
 {
 sbSQL.Append(" FuncComments = null,"); //函数注释
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FunctionSignature))
 {
 if (objCMFunctionEN.FunctionSignature !=  null)
 {
 var strFunctionSignature = objCMFunctionEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionSignature = '{0}',", strFunctionSignature); //函数签名
 }
 else
 {
 sbSQL.Append(" FunctionSignature = null,"); //函数签名
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncTypeId))
 {
 if (objCMFunctionEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objCMFunctionEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncTypeId = '{0}',", strFuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.Append(" FuncTypeId = null,"); //函数类型Id
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnType))
 {
 if (objCMFunctionEN.ReturnType !=  null)
 {
 var strReturnType = objCMFunctionEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnType = '{0}',", strReturnType); //返回类型
 }
 else
 {
 sbSQL.Append(" ReturnType = null,"); //返回类型
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnTypeFullName))
 {
 if (objCMFunctionEN.ReturnTypeFullName !=  null)
 {
 var strReturnTypeFullName = objCMFunctionEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTypeFullName = '{0}',", strReturnTypeFullName); //返回类型全名
 }
 else
 {
 sbSQL.Append(" ReturnTypeFullName = null,"); //返回类型全名
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsKnownType))
 {
 sbSQL.AppendFormat(" IsKnownType = '{0}',", objCMFunctionEN.IsKnownType == true?"1":"0"); //是否已知类型
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnTypeId))
 {
 if (objCMFunctionEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objCMFunctionEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTypeId = '{0}',", strReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.Append(" ReturnTypeId = null,"); //返回类型ID
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsAsyncFunc))
 {
 sbSQL.AppendFormat(" IsAsyncFunc = '{0}',", objCMFunctionEN.IsAsyncFunc == true?"1":"0"); //是否异步函数
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SourceFunction))
 {
 if (objCMFunctionEN.SourceFunction !=  null)
 {
 var strSourceFunction = objCMFunctionEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceFunction = '{0}',", strSourceFunction); //来源函数
 }
 else
 {
 sbSQL.Append(" SourceFunction = null,"); //来源函数
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsGeneCode))
 {
 sbSQL.AppendFormat(" IsGeneCode = '{0}',", objCMFunctionEN.IsGeneCode == true?"1":"0"); //是否生成代码
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnValueDescription))
 {
 if (objCMFunctionEN.ReturnValueDescription !=  null)
 {
 var strReturnValueDescription = objCMFunctionEN.ReturnValueDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnValueDescription = '{0}',", strReturnValueDescription); //返回值说明
 }
 else
 {
 sbSQL.Append(" ReturnValueDescription = null,"); //返回值说明
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsSysFunction))
 {
 sbSQL.AppendFormat(" IsSysFunction = '{0}',", objCMFunctionEN.IsSysFunction == true?"1":"0"); //是否系统函数
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.GetCustomAttributes))
 {
 if (objCMFunctionEN.GetCustomAttributes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCMFunctionEN.GetCustomAttributes, conCMFunction.GetCustomAttributes); //GetCustomAttributes
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.GetCustomAttributes); //GetCustomAttributes
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ClassNameLst))
 {
 if (objCMFunctionEN.ClassNameLst !=  null)
 {
 var strClassNameLst = objCMFunctionEN.ClassNameLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassNameLst = '{0}',", strClassNameLst); //类名列表
 }
 else
 {
 sbSQL.Append(" ClassNameLst = null,"); //类名列表
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.UpdDate))
 {
 if (objCMFunctionEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.UpdUser))
 {
 if (objCMFunctionEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.Memo))
 {
 if (objCMFunctionEN.Memo !=  null)
 {
 var strMemo = objCMFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsSynchToServer))
 {
 sbSQL.AppendFormat(" IsSynchToServer = '{0}',", objCMFunctionEN.IsSynchToServer == true?"1":"0"); //是否同步到Server
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToServerDate))
 {
 if (objCMFunctionEN.SynchToServerDate !=  null)
 {
 var strSynchToServerDate = objCMFunctionEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToServerDate = '{0}',", strSynchToServerDate); //同步到Server日期
 }
 else
 {
 sbSQL.Append(" SynchToServerDate = null,"); //同步到Server日期
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToServerUser))
 {
 if (objCMFunctionEN.SynchToServerUser !=  null)
 {
 var strSynchToServerUser = objCMFunctionEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToServerUser = '{0}',", strSynchToServerUser); //同步到Server用户
 }
 else
 {
 sbSQL.Append(" SynchToServerUser = null,"); //同步到Server用户
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsSynchToClient))
 {
 sbSQL.AppendFormat(" IsSynchToClient = '{0}',", objCMFunctionEN.IsSynchToClient == true?"1":"0"); //是否同步到Client
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToClientDate))
 {
 if (objCMFunctionEN.SynchToClientDate !=  null)
 {
 var strSynchToClientDate = objCMFunctionEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToClientDate = '{0}',", strSynchToClientDate); //同步到Client库日期
 }
 else
 {
 sbSQL.Append(" SynchToClientDate = null,"); //同步到Client库日期
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToClientUser))
 {
 if (objCMFunctionEN.SynchToClientUser !=  null)
 {
 var strSynchToClientUser = objCMFunctionEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToClientUser = '{0}',", strSynchToClientUser); //同步到Client库用户
 }
 else
 {
 sbSQL.Append(" SynchToClientUser = null,"); //同步到Client库用户
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynSource))
 {
 if (objCMFunctionEN.SynSource !=  null)
 {
 var strSynSource = objCMFunctionEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynSource = '{0}',", strSynSource); //同步来源
 }
 else
 {
 sbSQL.Append(" SynSource = null,"); //同步来源
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
 /// <param name = "objCMFunctionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCMFunctionEN objCMFunctionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCMFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFunctionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMFunction Set ");
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.CmClassId))
 {
 if (objCMFunctionEN.CmClassId !=  null)
 {
 var strCmClassId = objCMFunctionEN.CmClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmClassId, conCMFunction.CmClassId); //类Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.CmClassId); //类Id
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FunctionName))
 {
 if (objCMFunctionEN.FunctionName !=  null)
 {
 var strFunctionName = objCMFunctionEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionName, conCMFunction.FunctionName); //功能名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.FunctionName); //功能名称
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncContent))
 {
 if (objCMFunctionEN.FuncContent !=  null)
 {
 var strFuncContent = objCMFunctionEN.FuncContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncContent, conCMFunction.FuncContent); //函数内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.FuncContent); //函数内容
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.KeyWords))
 {
 if (objCMFunctionEN.KeyWords !=  null)
 {
 var strKeyWords = objCMFunctionEN.KeyWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyWords, conCMFunction.KeyWords); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.KeyWords); //关键字
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncParaLst))
 {
 if (objCMFunctionEN.FuncParaLst !=  null)
 {
 var strFuncParaLst = objCMFunctionEN.FuncParaLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncParaLst, conCMFunction.FuncParaLst); //函数参数列表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.FuncParaLst); //函数参数列表
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncComments))
 {
 if (objCMFunctionEN.FuncComments !=  null)
 {
 var strFuncComments = objCMFunctionEN.FuncComments.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncComments, conCMFunction.FuncComments); //函数注释
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.FuncComments); //函数注释
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FunctionSignature))
 {
 if (objCMFunctionEN.FunctionSignature !=  null)
 {
 var strFunctionSignature = objCMFunctionEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionSignature, conCMFunction.FunctionSignature); //函数签名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.FunctionSignature); //函数签名
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.FuncTypeId))
 {
 if (objCMFunctionEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objCMFunctionEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncTypeId, conCMFunction.FuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.FuncTypeId); //函数类型Id
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnType))
 {
 if (objCMFunctionEN.ReturnType !=  null)
 {
 var strReturnType = objCMFunctionEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnType, conCMFunction.ReturnType); //返回类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.ReturnType); //返回类型
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnTypeFullName))
 {
 if (objCMFunctionEN.ReturnTypeFullName !=  null)
 {
 var strReturnTypeFullName = objCMFunctionEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTypeFullName, conCMFunction.ReturnTypeFullName); //返回类型全名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.ReturnTypeFullName); //返回类型全名
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsKnownType))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFunctionEN.IsKnownType == true?"1":"0", conCMFunction.IsKnownType); //是否已知类型
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnTypeId))
 {
 if (objCMFunctionEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objCMFunctionEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTypeId, conCMFunction.ReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.ReturnTypeId); //返回类型ID
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsAsyncFunc))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFunctionEN.IsAsyncFunc == true?"1":"0", conCMFunction.IsAsyncFunc); //是否异步函数
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SourceFunction))
 {
 if (objCMFunctionEN.SourceFunction !=  null)
 {
 var strSourceFunction = objCMFunctionEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceFunction, conCMFunction.SourceFunction); //来源函数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.SourceFunction); //来源函数
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsGeneCode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFunctionEN.IsGeneCode == true?"1":"0", conCMFunction.IsGeneCode); //是否生成代码
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ReturnValueDescription))
 {
 if (objCMFunctionEN.ReturnValueDescription !=  null)
 {
 var strReturnValueDescription = objCMFunctionEN.ReturnValueDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnValueDescription, conCMFunction.ReturnValueDescription); //返回值说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.ReturnValueDescription); //返回值说明
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsSysFunction))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFunctionEN.IsSysFunction == true?"1":"0", conCMFunction.IsSysFunction); //是否系统函数
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.GetCustomAttributes))
 {
 if (objCMFunctionEN.GetCustomAttributes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCMFunctionEN.GetCustomAttributes, conCMFunction.GetCustomAttributes); //GetCustomAttributes
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.GetCustomAttributes); //GetCustomAttributes
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.ClassNameLst))
 {
 if (objCMFunctionEN.ClassNameLst !=  null)
 {
 var strClassNameLst = objCMFunctionEN.ClassNameLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClassNameLst, conCMFunction.ClassNameLst); //类名列表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.ClassNameLst); //类名列表
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.UpdDate))
 {
 if (objCMFunctionEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCMFunction.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.UpdDate); //修改日期
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.UpdUser))
 {
 if (objCMFunctionEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCMFunction.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.UpdUser); //修改者
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.Memo))
 {
 if (objCMFunctionEN.Memo !=  null)
 {
 var strMemo = objCMFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCMFunction.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.Memo); //说明
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsSynchToServer))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFunctionEN.IsSynchToServer == true?"1":"0", conCMFunction.IsSynchToServer); //是否同步到Server
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToServerDate))
 {
 if (objCMFunctionEN.SynchToServerDate !=  null)
 {
 var strSynchToServerDate = objCMFunctionEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToServerDate, conCMFunction.SynchToServerDate); //同步到Server日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.SynchToServerDate); //同步到Server日期
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToServerUser))
 {
 if (objCMFunctionEN.SynchToServerUser !=  null)
 {
 var strSynchToServerUser = objCMFunctionEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToServerUser, conCMFunction.SynchToServerUser); //同步到Server用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.SynchToServerUser); //同步到Server用户
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.IsSynchToClient))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFunctionEN.IsSynchToClient == true?"1":"0", conCMFunction.IsSynchToClient); //是否同步到Client
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToClientDate))
 {
 if (objCMFunctionEN.SynchToClientDate !=  null)
 {
 var strSynchToClientDate = objCMFunctionEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToClientDate, conCMFunction.SynchToClientDate); //同步到Client库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.SynchToClientDate); //同步到Client库日期
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynchToClientUser))
 {
 if (objCMFunctionEN.SynchToClientUser !=  null)
 {
 var strSynchToClientUser = objCMFunctionEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToClientUser, conCMFunction.SynchToClientUser); //同步到Client库用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.SynchToClientUser); //同步到Client库用户
 }
 }
 
 if (objCMFunctionEN.IsUpdated(conCMFunction.SynSource))
 {
 if (objCMFunctionEN.SynSource !=  null)
 {
 var strSynSource = objCMFunctionEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynSource, conCMFunction.SynSource); //同步来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunction.SynSource); //同步来源
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CmFunctionId = '{0}'", objCMFunctionEN.CmFunctionId); 
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
 /// <param name = "strCmFunctionId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCmFunctionId) 
{
CheckPrimaryKey(strCmFunctionId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCmFunctionId,
};
 objSQL.ExecSP("CMFunction_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCmFunctionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCmFunctionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCmFunctionId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
//删除CMFunction本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMFunction where CmFunctionId = " + "'"+ strCmFunctionId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCMFunction(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
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
//删除CMFunction本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMFunction where CmFunctionId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCmFunctionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCmFunctionId) 
{
CheckPrimaryKey(strCmFunctionId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
//删除CMFunction本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMFunction where CmFunctionId = " + "'"+ strCmFunctionId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCMFunction(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCMFunctionDA: DelCMFunction)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CMFunction where " + strCondition ;
}
int intRecoCount = objSQL.ExecSql2(strSQL);
return intRecoCount;
}



 /// <summary>
 /// 功能:删除满足条件的多条记录,同时处理事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRecWithTransaction)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public bool DelCMFunctionWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCMFunctionDA: DelCMFunctionWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CMFunction where " + strCondition ;
}
 bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
return bolResult;
}


 #endregion 删除记录

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objCMFunctionENS">源对象</param>
 /// <param name = "objCMFunctionENT">目标对象</param>
public void CopyTo(clsCMFunctionEN objCMFunctionENS, clsCMFunctionEN objCMFunctionENT)
{
objCMFunctionENT.CmFunctionId = objCMFunctionENS.CmFunctionId; //函数Id
objCMFunctionENT.CmClassId = objCMFunctionENS.CmClassId; //类Id
objCMFunctionENT.FunctionName = objCMFunctionENS.FunctionName; //功能名称
objCMFunctionENT.FuncContent = objCMFunctionENS.FuncContent; //函数内容
objCMFunctionENT.KeyWords = objCMFunctionENS.KeyWords; //关键字
objCMFunctionENT.FuncParaLst = objCMFunctionENS.FuncParaLst; //函数参数列表
objCMFunctionENT.FuncComments = objCMFunctionENS.FuncComments; //函数注释
objCMFunctionENT.FunctionSignature = objCMFunctionENS.FunctionSignature; //函数签名
objCMFunctionENT.FuncTypeId = objCMFunctionENS.FuncTypeId; //函数类型Id
objCMFunctionENT.ReturnType = objCMFunctionENS.ReturnType; //返回类型
objCMFunctionENT.ReturnTypeFullName = objCMFunctionENS.ReturnTypeFullName; //返回类型全名
objCMFunctionENT.IsKnownType = objCMFunctionENS.IsKnownType; //是否已知类型
objCMFunctionENT.ReturnTypeId = objCMFunctionENS.ReturnTypeId; //返回类型ID
objCMFunctionENT.IsAsyncFunc = objCMFunctionENS.IsAsyncFunc; //是否异步函数
objCMFunctionENT.SourceFunction = objCMFunctionENS.SourceFunction; //来源函数
objCMFunctionENT.IsGeneCode = objCMFunctionENS.IsGeneCode; //是否生成代码
objCMFunctionENT.ReturnValueDescription = objCMFunctionENS.ReturnValueDescription; //返回值说明
objCMFunctionENT.IsSysFunction = objCMFunctionENS.IsSysFunction; //是否系统函数
objCMFunctionENT.GetCustomAttributes = objCMFunctionENS.GetCustomAttributes; //GetCustomAttributes
objCMFunctionENT.ClassNameLst = objCMFunctionENS.ClassNameLst; //类名列表
objCMFunctionENT.UpdDate = objCMFunctionENS.UpdDate; //修改日期
objCMFunctionENT.UpdUser = objCMFunctionENS.UpdUser; //修改者
objCMFunctionENT.Memo = objCMFunctionENS.Memo; //说明
objCMFunctionENT.IsSynchToServer = objCMFunctionENS.IsSynchToServer; //是否同步到Server
objCMFunctionENT.SynchToServerDate = objCMFunctionENS.SynchToServerDate; //同步到Server日期
objCMFunctionENT.SynchToServerUser = objCMFunctionENS.SynchToServerUser; //同步到Server用户
objCMFunctionENT.IsSynchToClient = objCMFunctionENS.IsSynchToClient; //是否同步到Client
objCMFunctionENT.SynchToClientDate = objCMFunctionENS.SynchToClientDate; //同步到Client库日期
objCMFunctionENT.SynchToClientUser = objCMFunctionENS.SynchToClientUser; //同步到Client库用户
objCMFunctionENT.SynSource = objCMFunctionENS.SynSource; //同步来源
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCMFunctionEN objCMFunctionEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCMFunctionEN.CmClassId, conCMFunction.CmClassId);
clsCheckSql.CheckFieldNotNull(objCMFunctionEN.FunctionName, conCMFunction.FunctionName);
//检查字段长度
clsCheckSql.CheckFieldLen(objCMFunctionEN.CmFunctionId, 8, conCMFunction.CmFunctionId);
clsCheckSql.CheckFieldLen(objCMFunctionEN.CmClassId, 8, conCMFunction.CmClassId);
clsCheckSql.CheckFieldLen(objCMFunctionEN.FunctionName, 200, conCMFunction.FunctionName);
clsCheckSql.CheckFieldLen(objCMFunctionEN.KeyWords, 500, conCMFunction.KeyWords);
clsCheckSql.CheckFieldLen(objCMFunctionEN.FuncParaLst, 500, conCMFunction.FuncParaLst);
clsCheckSql.CheckFieldLen(objCMFunctionEN.FunctionSignature, 500, conCMFunction.FunctionSignature);
clsCheckSql.CheckFieldLen(objCMFunctionEN.FuncTypeId, 2, conCMFunction.FuncTypeId);
clsCheckSql.CheckFieldLen(objCMFunctionEN.ReturnType, 500, conCMFunction.ReturnType);
clsCheckSql.CheckFieldLen(objCMFunctionEN.ReturnTypeFullName, 500, conCMFunction.ReturnTypeFullName);
clsCheckSql.CheckFieldLen(objCMFunctionEN.ReturnTypeId, 2, conCMFunction.ReturnTypeId);
clsCheckSql.CheckFieldLen(objCMFunctionEN.SourceFunction, 500, conCMFunction.SourceFunction);
clsCheckSql.CheckFieldLen(objCMFunctionEN.ReturnValueDescription, 500, conCMFunction.ReturnValueDescription);
clsCheckSql.CheckFieldLen(objCMFunctionEN.ClassNameLst, 500, conCMFunction.ClassNameLst);
clsCheckSql.CheckFieldLen(objCMFunctionEN.UpdDate, 20, conCMFunction.UpdDate);
clsCheckSql.CheckFieldLen(objCMFunctionEN.UpdUser, 20, conCMFunction.UpdUser);
clsCheckSql.CheckFieldLen(objCMFunctionEN.Memo, 1000, conCMFunction.Memo);
clsCheckSql.CheckFieldLen(objCMFunctionEN.SynchToServerDate, 20, conCMFunction.SynchToServerDate);
clsCheckSql.CheckFieldLen(objCMFunctionEN.SynchToServerUser, 20, conCMFunction.SynchToServerUser);
clsCheckSql.CheckFieldLen(objCMFunctionEN.SynchToClientDate, 20, conCMFunction.SynchToClientDate);
clsCheckSql.CheckFieldLen(objCMFunctionEN.SynchToClientUser, 20, conCMFunction.SynchToClientUser);
clsCheckSql.CheckFieldLen(objCMFunctionEN.SynSource, 50, conCMFunction.SynSource);
//检查字段外键固定长度
 objCMFunctionEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCMFunctionEN objCMFunctionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCMFunctionEN.CmClassId, 8, conCMFunction.CmClassId);
clsCheckSql.CheckFieldLen(objCMFunctionEN.FunctionName, 200, conCMFunction.FunctionName);
clsCheckSql.CheckFieldLen(objCMFunctionEN.KeyWords, 500, conCMFunction.KeyWords);
clsCheckSql.CheckFieldLen(objCMFunctionEN.FuncParaLst, 500, conCMFunction.FuncParaLst);
clsCheckSql.CheckFieldLen(objCMFunctionEN.FunctionSignature, 500, conCMFunction.FunctionSignature);
clsCheckSql.CheckFieldLen(objCMFunctionEN.FuncTypeId, 2, conCMFunction.FuncTypeId);
clsCheckSql.CheckFieldLen(objCMFunctionEN.ReturnType, 500, conCMFunction.ReturnType);
clsCheckSql.CheckFieldLen(objCMFunctionEN.ReturnTypeFullName, 500, conCMFunction.ReturnTypeFullName);
clsCheckSql.CheckFieldLen(objCMFunctionEN.ReturnTypeId, 2, conCMFunction.ReturnTypeId);
clsCheckSql.CheckFieldLen(objCMFunctionEN.SourceFunction, 500, conCMFunction.SourceFunction);
clsCheckSql.CheckFieldLen(objCMFunctionEN.ReturnValueDescription, 500, conCMFunction.ReturnValueDescription);
clsCheckSql.CheckFieldLen(objCMFunctionEN.ClassNameLst, 500, conCMFunction.ClassNameLst);
clsCheckSql.CheckFieldLen(objCMFunctionEN.UpdDate, 20, conCMFunction.UpdDate);
clsCheckSql.CheckFieldLen(objCMFunctionEN.UpdUser, 20, conCMFunction.UpdUser);
clsCheckSql.CheckFieldLen(objCMFunctionEN.Memo, 1000, conCMFunction.Memo);
clsCheckSql.CheckFieldLen(objCMFunctionEN.SynchToServerDate, 20, conCMFunction.SynchToServerDate);
clsCheckSql.CheckFieldLen(objCMFunctionEN.SynchToServerUser, 20, conCMFunction.SynchToServerUser);
clsCheckSql.CheckFieldLen(objCMFunctionEN.SynchToClientDate, 20, conCMFunction.SynchToClientDate);
clsCheckSql.CheckFieldLen(objCMFunctionEN.SynchToClientUser, 20, conCMFunction.SynchToClientUser);
clsCheckSql.CheckFieldLen(objCMFunctionEN.SynSource, 50, conCMFunction.SynSource);
//检查外键字段长度
 objCMFunctionEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCMFunctionEN objCMFunctionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCMFunctionEN.CmFunctionId, 8, conCMFunction.CmFunctionId);
clsCheckSql.CheckFieldLen(objCMFunctionEN.CmClassId, 8, conCMFunction.CmClassId);
clsCheckSql.CheckFieldLen(objCMFunctionEN.FunctionName, 200, conCMFunction.FunctionName);
clsCheckSql.CheckFieldLen(objCMFunctionEN.KeyWords, 500, conCMFunction.KeyWords);
clsCheckSql.CheckFieldLen(objCMFunctionEN.FuncParaLst, 500, conCMFunction.FuncParaLst);
clsCheckSql.CheckFieldLen(objCMFunctionEN.FunctionSignature, 500, conCMFunction.FunctionSignature);
clsCheckSql.CheckFieldLen(objCMFunctionEN.FuncTypeId, 2, conCMFunction.FuncTypeId);
clsCheckSql.CheckFieldLen(objCMFunctionEN.ReturnType, 500, conCMFunction.ReturnType);
clsCheckSql.CheckFieldLen(objCMFunctionEN.ReturnTypeFullName, 500, conCMFunction.ReturnTypeFullName);
clsCheckSql.CheckFieldLen(objCMFunctionEN.ReturnTypeId, 2, conCMFunction.ReturnTypeId);
clsCheckSql.CheckFieldLen(objCMFunctionEN.SourceFunction, 500, conCMFunction.SourceFunction);
clsCheckSql.CheckFieldLen(objCMFunctionEN.ReturnValueDescription, 500, conCMFunction.ReturnValueDescription);
clsCheckSql.CheckFieldLen(objCMFunctionEN.ClassNameLst, 500, conCMFunction.ClassNameLst);
clsCheckSql.CheckFieldLen(objCMFunctionEN.UpdDate, 20, conCMFunction.UpdDate);
clsCheckSql.CheckFieldLen(objCMFunctionEN.UpdUser, 20, conCMFunction.UpdUser);
clsCheckSql.CheckFieldLen(objCMFunctionEN.Memo, 1000, conCMFunction.Memo);
clsCheckSql.CheckFieldLen(objCMFunctionEN.SynchToServerDate, 20, conCMFunction.SynchToServerDate);
clsCheckSql.CheckFieldLen(objCMFunctionEN.SynchToServerUser, 20, conCMFunction.SynchToServerUser);
clsCheckSql.CheckFieldLen(objCMFunctionEN.SynchToClientDate, 20, conCMFunction.SynchToClientDate);
clsCheckSql.CheckFieldLen(objCMFunctionEN.SynchToClientUser, 20, conCMFunction.SynchToClientUser);
clsCheckSql.CheckFieldLen(objCMFunctionEN.SynSource, 50, conCMFunction.SynSource);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.CmFunctionId, conCMFunction.CmFunctionId);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.CmClassId, conCMFunction.CmClassId);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.FunctionName, conCMFunction.FunctionName);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.KeyWords, conCMFunction.KeyWords);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.FuncParaLst, conCMFunction.FuncParaLst);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.FunctionSignature, conCMFunction.FunctionSignature);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.FuncTypeId, conCMFunction.FuncTypeId);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.ReturnType, conCMFunction.ReturnType);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.ReturnTypeFullName, conCMFunction.ReturnTypeFullName);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.ReturnTypeId, conCMFunction.ReturnTypeId);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.SourceFunction, conCMFunction.SourceFunction);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.ReturnValueDescription, conCMFunction.ReturnValueDescription);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.ClassNameLst, conCMFunction.ClassNameLst);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.UpdDate, conCMFunction.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.UpdUser, conCMFunction.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.Memo, conCMFunction.Memo);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.SynchToServerDate, conCMFunction.SynchToServerDate);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.SynchToServerUser, conCMFunction.SynchToServerUser);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.SynchToClientDate, conCMFunction.SynchToClientDate);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.SynchToClientUser, conCMFunction.SynchToClientUser);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionEN.SynSource, conCMFunction.SynSource);
//检查外键字段长度
 objCMFunctionEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCmFunctionId()
{
//获取某学院所有专业信息
string strSQL = "select CmFunctionId, FunctionName from CMFunction ";
 clsSpecSQLforSql mySql = clsCMFunctionDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CMFunction(CM函数),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMFunctionEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCMFunctionEN objCMFunctionEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objCMFunctionEN.FunctionName);
 if (objCMFunctionEN.FuncParaLst == null)
{
 sbCondition.AppendFormat(" and FuncParaLst is null");
}
else
{
 sbCondition.AppendFormat(" and FuncParaLst = '{0}'", objCMFunctionEN.FuncParaLst);
}
 sbCondition.AppendFormat(" and CmClassId = '{0}'", objCMFunctionEN.CmClassId);
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
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
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
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
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
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCMFunctionEN._CurrTabName);
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
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCMFunctionEN._CurrTabName, strCondition);
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
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
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
 objSQL = clsCMFunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}