
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeFunctionDA
 表名:CodeFunction(00050439)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:53
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 代码函数(CodeFunction)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCodeFunctionDA : clsCommBase4DA
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
 return clsCodeFunctionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCodeFunctionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCodeFunctionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCodeFunctionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCodeFunctionEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCodeFuncId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCodeFuncId)
{
strCodeFuncId = strCodeFuncId.Replace("'", "''");
if (strCodeFuncId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:CodeFunction中,检查关键字,长度不正确!(clsCodeFunctionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCodeFuncId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CodeFunction中,关键字不能为空 或 null!(clsCodeFunctionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCodeFuncId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCodeFunctionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCodeFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CodeFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CodeFunction(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCodeFunctionDA: GetDataTable_CodeFunction)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CodeFunction where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCodeFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCodeFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CodeFunction where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCodeFunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCodeFunctionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CodeFunction where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CodeFunction where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCodeFunctionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CodeFunction where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCodeFunctionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CodeFunction.* " + 
$"from CodeFunction " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CodeFunction.CodeFuncId not in " + 
$"(Select top {intTop_In} CodeFunction.CodeFuncId from CodeFunction " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CodeFunction where {1} and CodeFuncId not in (Select top {2} CodeFuncId from CodeFunction where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CodeFunction where {1} and CodeFuncId not in (Select top {3} CodeFuncId from CodeFunction where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCodeFunctionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CodeFunction.* " + 
$"from CodeFunction " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CodeFunction.CodeFuncId not in " + 
$"(Select top {intTop_In} CodeFunction.CodeFuncId from CodeFunction " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CodeFunction where {1} and CodeFuncId not in (Select top {2} CodeFuncId from CodeFunction where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CodeFunction where {1} and CodeFuncId not in (Select top {3} CodeFuncId from CodeFunction where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCodeFunctionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCodeFunctionDA:GetObjLst)", objException.Message));
}
List<clsCodeFunctionEN> arrObjLst = new List<clsCodeFunctionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CodeFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeFunctionEN objCodeFunctionEN = new clsCodeFunctionEN();
try
{
objCodeFunctionEN.CodeFuncId = objRow[conCodeFunction.CodeFuncId].ToString().Trim(); //代码函数Id
objCodeFunctionEN.CodeFuncName = objRow[conCodeFunction.CodeFuncName] == DBNull.Value ? null : objRow[conCodeFunction.CodeFuncName].ToString().Trim(); //代码函数名
objCodeFunctionEN.FuncSignature = objRow[conCodeFunction.FuncSignature] == DBNull.Value ? null : objRow[conCodeFunction.FuncSignature].ToString().Trim(); //函数签名
objCodeFunctionEN.UpdDate = objRow[conCodeFunction.UpdDate] == DBNull.Value ? null : objRow[conCodeFunction.UpdDate].ToString().Trim(); //修改日期
objCodeFunctionEN.UpdUser = objRow[conCodeFunction.UpdUser] == DBNull.Value ? null : objRow[conCodeFunction.UpdUser].ToString().Trim(); //修改者
objCodeFunctionEN.Memo = objRow[conCodeFunction.Memo] == DBNull.Value ? null : objRow[conCodeFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCodeFunctionDA: GetObjLst)", objException.Message));
}
objCodeFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCodeFunctionEN);
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
public List<clsCodeFunctionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCodeFunctionDA:GetObjLstByTabName)", objException.Message));
}
List<clsCodeFunctionEN> arrObjLst = new List<clsCodeFunctionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeFunctionEN objCodeFunctionEN = new clsCodeFunctionEN();
try
{
objCodeFunctionEN.CodeFuncId = objRow[conCodeFunction.CodeFuncId].ToString().Trim(); //代码函数Id
objCodeFunctionEN.CodeFuncName = objRow[conCodeFunction.CodeFuncName] == DBNull.Value ? null : objRow[conCodeFunction.CodeFuncName].ToString().Trim(); //代码函数名
objCodeFunctionEN.FuncSignature = objRow[conCodeFunction.FuncSignature] == DBNull.Value ? null : objRow[conCodeFunction.FuncSignature].ToString().Trim(); //函数签名
objCodeFunctionEN.UpdDate = objRow[conCodeFunction.UpdDate] == DBNull.Value ? null : objRow[conCodeFunction.UpdDate].ToString().Trim(); //修改日期
objCodeFunctionEN.UpdUser = objRow[conCodeFunction.UpdUser] == DBNull.Value ? null : objRow[conCodeFunction.UpdUser].ToString().Trim(); //修改者
objCodeFunctionEN.Memo = objRow[conCodeFunction.Memo] == DBNull.Value ? null : objRow[conCodeFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCodeFunctionDA: GetObjLst)", objException.Message));
}
objCodeFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCodeFunctionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCodeFunctionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCodeFunction(ref clsCodeFunctionEN objCodeFunctionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CodeFunction where CodeFuncId = " + "'"+ objCodeFunctionEN.CodeFuncId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCodeFunctionEN.CodeFuncId = objDT.Rows[0][conCodeFunction.CodeFuncId].ToString().Trim(); //代码函数Id(字段类型:char,字段长度:4,是否可空:True)
 objCodeFunctionEN.CodeFuncName = objDT.Rows[0][conCodeFunction.CodeFuncName].ToString().Trim(); //代码函数名(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeFunctionEN.FuncSignature = objDT.Rows[0][conCodeFunction.FuncSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:300,是否可空:True)
 objCodeFunctionEN.UpdDate = objDT.Rows[0][conCodeFunction.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCodeFunctionEN.UpdUser = objDT.Rows[0][conCodeFunction.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCodeFunctionEN.Memo = objDT.Rows[0][conCodeFunction.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCodeFunctionDA: GetCodeFunction)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCodeFuncId">表关键字</param>
 /// <returns>表对象</returns>
public clsCodeFunctionEN GetObjByCodeFuncId(string strCodeFuncId)
{
CheckPrimaryKey(strCodeFuncId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CodeFunction where CodeFuncId = " + "'"+ strCodeFuncId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCodeFunctionEN objCodeFunctionEN = new clsCodeFunctionEN();
try
{
 objCodeFunctionEN.CodeFuncId = objRow[conCodeFunction.CodeFuncId].ToString().Trim(); //代码函数Id(字段类型:char,字段长度:4,是否可空:True)
 objCodeFunctionEN.CodeFuncName = objRow[conCodeFunction.CodeFuncName] == DBNull.Value ? null : objRow[conCodeFunction.CodeFuncName].ToString().Trim(); //代码函数名(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeFunctionEN.FuncSignature = objRow[conCodeFunction.FuncSignature] == DBNull.Value ? null : objRow[conCodeFunction.FuncSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:300,是否可空:True)
 objCodeFunctionEN.UpdDate = objRow[conCodeFunction.UpdDate] == DBNull.Value ? null : objRow[conCodeFunction.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCodeFunctionEN.UpdUser = objRow[conCodeFunction.UpdUser] == DBNull.Value ? null : objRow[conCodeFunction.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCodeFunctionEN.Memo = objRow[conCodeFunction.Memo] == DBNull.Value ? null : objRow[conCodeFunction.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCodeFunctionDA: GetObjByCodeFuncId)", objException.Message));
}
return objCodeFunctionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCodeFunctionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCodeFunctionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CodeFunction where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCodeFunctionEN objCodeFunctionEN = new clsCodeFunctionEN()
{
CodeFuncId = objRow[conCodeFunction.CodeFuncId].ToString().Trim(), //代码函数Id
CodeFuncName = objRow[conCodeFunction.CodeFuncName] == DBNull.Value ? null : objRow[conCodeFunction.CodeFuncName].ToString().Trim(), //代码函数名
FuncSignature = objRow[conCodeFunction.FuncSignature] == DBNull.Value ? null : objRow[conCodeFunction.FuncSignature].ToString().Trim(), //函数签名
UpdDate = objRow[conCodeFunction.UpdDate] == DBNull.Value ? null : objRow[conCodeFunction.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conCodeFunction.UpdUser] == DBNull.Value ? null : objRow[conCodeFunction.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conCodeFunction.Memo] == DBNull.Value ? null : objRow[conCodeFunction.Memo].ToString().Trim() //说明
};
objCodeFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCodeFunctionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCodeFunctionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCodeFunctionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCodeFunctionEN objCodeFunctionEN = new clsCodeFunctionEN();
try
{
objCodeFunctionEN.CodeFuncId = objRow[conCodeFunction.CodeFuncId].ToString().Trim(); //代码函数Id
objCodeFunctionEN.CodeFuncName = objRow[conCodeFunction.CodeFuncName] == DBNull.Value ? null : objRow[conCodeFunction.CodeFuncName].ToString().Trim(); //代码函数名
objCodeFunctionEN.FuncSignature = objRow[conCodeFunction.FuncSignature] == DBNull.Value ? null : objRow[conCodeFunction.FuncSignature].ToString().Trim(); //函数签名
objCodeFunctionEN.UpdDate = objRow[conCodeFunction.UpdDate] == DBNull.Value ? null : objRow[conCodeFunction.UpdDate].ToString().Trim(); //修改日期
objCodeFunctionEN.UpdUser = objRow[conCodeFunction.UpdUser] == DBNull.Value ? null : objRow[conCodeFunction.UpdUser].ToString().Trim(); //修改者
objCodeFunctionEN.Memo = objRow[conCodeFunction.Memo] == DBNull.Value ? null : objRow[conCodeFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCodeFunctionDA: GetObjByDataRowCodeFunction)", objException.Message));
}
objCodeFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCodeFunctionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCodeFunctionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCodeFunctionEN objCodeFunctionEN = new clsCodeFunctionEN();
try
{
objCodeFunctionEN.CodeFuncId = objRow[conCodeFunction.CodeFuncId].ToString().Trim(); //代码函数Id
objCodeFunctionEN.CodeFuncName = objRow[conCodeFunction.CodeFuncName] == DBNull.Value ? null : objRow[conCodeFunction.CodeFuncName].ToString().Trim(); //代码函数名
objCodeFunctionEN.FuncSignature = objRow[conCodeFunction.FuncSignature] == DBNull.Value ? null : objRow[conCodeFunction.FuncSignature].ToString().Trim(); //函数签名
objCodeFunctionEN.UpdDate = objRow[conCodeFunction.UpdDate] == DBNull.Value ? null : objRow[conCodeFunction.UpdDate].ToString().Trim(); //修改日期
objCodeFunctionEN.UpdUser = objRow[conCodeFunction.UpdUser] == DBNull.Value ? null : objRow[conCodeFunction.UpdUser].ToString().Trim(); //修改者
objCodeFunctionEN.Memo = objRow[conCodeFunction.Memo] == DBNull.Value ? null : objRow[conCodeFunction.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCodeFunctionDA: GetObjByDataRow)", objException.Message));
}
objCodeFunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCodeFunctionEN;
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
objSQL = clsCodeFunctionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCodeFunctionEN._CurrTabName, conCodeFunction.CodeFuncId, 4, "");
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
objSQL = clsCodeFunctionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCodeFunctionEN._CurrTabName, conCodeFunction.CodeFuncId, 4, strPrefix);
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
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CodeFuncId from CodeFunction where " + strCondition;
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
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CodeFuncId from CodeFunction where " + strCondition;
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
 /// <param name = "strCodeFuncId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCodeFuncId)
{
CheckPrimaryKey(strCodeFuncId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CodeFunction", "CodeFuncId = " + "'"+ strCodeFuncId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCodeFunctionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CodeFunction", strCondition))
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
objSQL = clsCodeFunctionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CodeFunction");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCodeFunctionEN objCodeFunctionEN)
 {
 objCodeFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeFunctionEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CodeFunction where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CodeFunction");
objRow = objDS.Tables["CodeFunction"].NewRow();
objRow[conCodeFunction.CodeFuncId] = objCodeFunctionEN.CodeFuncId; //代码函数Id
 if (objCodeFunctionEN.CodeFuncName !=  "")
 {
objRow[conCodeFunction.CodeFuncName] = objCodeFunctionEN.CodeFuncName; //代码函数名
 }
 if (objCodeFunctionEN.FuncSignature !=  "")
 {
objRow[conCodeFunction.FuncSignature] = objCodeFunctionEN.FuncSignature; //函数签名
 }
 if (objCodeFunctionEN.UpdDate !=  "")
 {
objRow[conCodeFunction.UpdDate] = objCodeFunctionEN.UpdDate; //修改日期
 }
 if (objCodeFunctionEN.UpdUser !=  "")
 {
objRow[conCodeFunction.UpdUser] = objCodeFunctionEN.UpdUser; //修改者
 }
 if (objCodeFunctionEN.Memo !=  "")
 {
objRow[conCodeFunction.Memo] = objCodeFunctionEN.Memo; //说明
 }
objDS.Tables[clsCodeFunctionEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCodeFunctionEN._CurrTabName);
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
 /// <param name = "objCodeFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCodeFunctionEN objCodeFunctionEN)
{
 objCodeFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeFunctionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCodeFunctionEN.CodeFuncId !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.CodeFuncId);
 var strCodeFuncId = objCodeFunctionEN.CodeFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeFuncId + "'");
 }
 
 if (objCodeFunctionEN.CodeFuncName !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.CodeFuncName);
 var strCodeFuncName = objCodeFunctionEN.CodeFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeFuncName + "'");
 }
 
 if (objCodeFunctionEN.FuncSignature !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.FuncSignature);
 var strFuncSignature = objCodeFunctionEN.FuncSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncSignature + "'");
 }
 
 if (objCodeFunctionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.UpdDate);
 var strUpdDate = objCodeFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCodeFunctionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.UpdUser);
 var strUpdUser = objCodeFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCodeFunctionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.Memo);
 var strMemo = objCodeFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CodeFunction");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCodeFunctionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCodeFunctionEN objCodeFunctionEN)
{
 objCodeFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeFunctionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCodeFunctionEN.CodeFuncId !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.CodeFuncId);
 var strCodeFuncId = objCodeFunctionEN.CodeFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeFuncId + "'");
 }
 
 if (objCodeFunctionEN.CodeFuncName !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.CodeFuncName);
 var strCodeFuncName = objCodeFunctionEN.CodeFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeFuncName + "'");
 }
 
 if (objCodeFunctionEN.FuncSignature !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.FuncSignature);
 var strFuncSignature = objCodeFunctionEN.FuncSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncSignature + "'");
 }
 
 if (objCodeFunctionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.UpdDate);
 var strUpdDate = objCodeFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCodeFunctionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.UpdUser);
 var strUpdUser = objCodeFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCodeFunctionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.Memo);
 var strMemo = objCodeFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CodeFunction");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCodeFunctionEN.CodeFuncId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCodeFunctionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCodeFunctionEN objCodeFunctionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCodeFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeFunctionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCodeFunctionEN.CodeFuncId !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.CodeFuncId);
 var strCodeFuncId = objCodeFunctionEN.CodeFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeFuncId + "'");
 }
 
 if (objCodeFunctionEN.CodeFuncName !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.CodeFuncName);
 var strCodeFuncName = objCodeFunctionEN.CodeFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeFuncName + "'");
 }
 
 if (objCodeFunctionEN.FuncSignature !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.FuncSignature);
 var strFuncSignature = objCodeFunctionEN.FuncSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncSignature + "'");
 }
 
 if (objCodeFunctionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.UpdDate);
 var strUpdDate = objCodeFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCodeFunctionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.UpdUser);
 var strUpdUser = objCodeFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCodeFunctionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.Memo);
 var strMemo = objCodeFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CodeFunction");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCodeFunctionEN.CodeFuncId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCodeFunctionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCodeFunctionEN objCodeFunctionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCodeFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeFunctionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeFunctionEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCodeFunctionEN.CodeFuncId !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.CodeFuncId);
 var strCodeFuncId = objCodeFunctionEN.CodeFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeFuncId + "'");
 }
 
 if (objCodeFunctionEN.CodeFuncName !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.CodeFuncName);
 var strCodeFuncName = objCodeFunctionEN.CodeFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeFuncName + "'");
 }
 
 if (objCodeFunctionEN.FuncSignature !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.FuncSignature);
 var strFuncSignature = objCodeFunctionEN.FuncSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncSignature + "'");
 }
 
 if (objCodeFunctionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.UpdDate);
 var strUpdDate = objCodeFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCodeFunctionEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.UpdUser);
 var strUpdUser = objCodeFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCodeFunctionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCodeFunction.Memo);
 var strMemo = objCodeFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CodeFunction");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCodeFunctions(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CodeFunction where CodeFuncId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CodeFunction");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCodeFuncId = oRow[conCodeFunction.CodeFuncId].ToString().Trim();
if (IsExist(strCodeFuncId))
{
 string strResult = "关键字变量值为:" + string.Format("CodeFuncId = {0}", strCodeFuncId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCodeFunctionEN._CurrTabName ].NewRow();
objRow[conCodeFunction.CodeFuncId] = oRow[conCodeFunction.CodeFuncId].ToString().Trim(); //代码函数Id
objRow[conCodeFunction.CodeFuncName] = oRow[conCodeFunction.CodeFuncName].ToString().Trim(); //代码函数名
objRow[conCodeFunction.FuncSignature] = oRow[conCodeFunction.FuncSignature].ToString().Trim(); //函数签名
objRow[conCodeFunction.UpdDate] = oRow[conCodeFunction.UpdDate].ToString().Trim(); //修改日期
objRow[conCodeFunction.UpdUser] = oRow[conCodeFunction.UpdUser].ToString().Trim(); //修改者
objRow[conCodeFunction.Memo] = oRow[conCodeFunction.Memo].ToString().Trim(); //说明
 objDS.Tables[clsCodeFunctionEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCodeFunctionEN._CurrTabName);
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
 /// <param name = "objCodeFunctionEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCodeFunctionEN objCodeFunctionEN)
{
 objCodeFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeFunctionEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
strSQL = "Select * from CodeFunction where CodeFuncId = " + "'"+ objCodeFunctionEN.CodeFuncId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCodeFunctionEN._CurrTabName);
if (objDS.Tables[clsCodeFunctionEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CodeFuncId = " + "'"+ objCodeFunctionEN.CodeFuncId+"'");
return false;
}
objRow = objDS.Tables[clsCodeFunctionEN._CurrTabName].Rows[0];
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.CodeFuncId))
 {
objRow[conCodeFunction.CodeFuncId] = objCodeFunctionEN.CodeFuncId; //代码函数Id
 }
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.CodeFuncName))
 {
objRow[conCodeFunction.CodeFuncName] = objCodeFunctionEN.CodeFuncName; //代码函数名
 }
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.FuncSignature))
 {
objRow[conCodeFunction.FuncSignature] = objCodeFunctionEN.FuncSignature; //函数签名
 }
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.UpdDate))
 {
objRow[conCodeFunction.UpdDate] = objCodeFunctionEN.UpdDate; //修改日期
 }
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.UpdUser))
 {
objRow[conCodeFunction.UpdUser] = objCodeFunctionEN.UpdUser; //修改者
 }
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.Memo))
 {
objRow[conCodeFunction.Memo] = objCodeFunctionEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsCodeFunctionEN._CurrTabName);
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
 /// <param name = "objCodeFunctionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCodeFunctionEN objCodeFunctionEN)
{
 objCodeFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeFunctionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CodeFunction Set ");
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.CodeFuncName))
 {
 if (objCodeFunctionEN.CodeFuncName !=  null)
 {
 var strCodeFuncName = objCodeFunctionEN.CodeFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeFuncName, conCodeFunction.CodeFuncName); //代码函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeFunction.CodeFuncName); //代码函数名
 }
 }
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.FuncSignature))
 {
 if (objCodeFunctionEN.FuncSignature !=  null)
 {
 var strFuncSignature = objCodeFunctionEN.FuncSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncSignature, conCodeFunction.FuncSignature); //函数签名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeFunction.FuncSignature); //函数签名
 }
 }
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.UpdDate))
 {
 if (objCodeFunctionEN.UpdDate !=  null)
 {
 var strUpdDate = objCodeFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCodeFunction.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeFunction.UpdDate); //修改日期
 }
 }
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.UpdUser))
 {
 if (objCodeFunctionEN.UpdUser !=  null)
 {
 var strUpdUser = objCodeFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCodeFunction.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeFunction.UpdUser); //修改者
 }
 }
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.Memo))
 {
 if (objCodeFunctionEN.Memo !=  null)
 {
 var strMemo = objCodeFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCodeFunction.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeFunction.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CodeFuncId = '{0}'", objCodeFunctionEN.CodeFuncId); 
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
 /// <param name = "objCodeFunctionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCodeFunctionEN objCodeFunctionEN, string strCondition)
{
 objCodeFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeFunctionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CodeFunction Set ");
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.CodeFuncName))
 {
 if (objCodeFunctionEN.CodeFuncName !=  null)
 {
 var strCodeFuncName = objCodeFunctionEN.CodeFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeFuncName = '{0}',", strCodeFuncName); //代码函数名
 }
 else
 {
 sbSQL.Append(" CodeFuncName = null,"); //代码函数名
 }
 }
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.FuncSignature))
 {
 if (objCodeFunctionEN.FuncSignature !=  null)
 {
 var strFuncSignature = objCodeFunctionEN.FuncSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncSignature = '{0}',", strFuncSignature); //函数签名
 }
 else
 {
 sbSQL.Append(" FuncSignature = null,"); //函数签名
 }
 }
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.UpdDate))
 {
 if (objCodeFunctionEN.UpdDate !=  null)
 {
 var strUpdDate = objCodeFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.UpdUser))
 {
 if (objCodeFunctionEN.UpdUser !=  null)
 {
 var strUpdUser = objCodeFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.Memo))
 {
 if (objCodeFunctionEN.Memo !=  null)
 {
 var strMemo = objCodeFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
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
 /// <param name = "objCodeFunctionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCodeFunctionEN objCodeFunctionEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCodeFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeFunctionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CodeFunction Set ");
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.CodeFuncName))
 {
 if (objCodeFunctionEN.CodeFuncName !=  null)
 {
 var strCodeFuncName = objCodeFunctionEN.CodeFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeFuncName = '{0}',", strCodeFuncName); //代码函数名
 }
 else
 {
 sbSQL.Append(" CodeFuncName = null,"); //代码函数名
 }
 }
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.FuncSignature))
 {
 if (objCodeFunctionEN.FuncSignature !=  null)
 {
 var strFuncSignature = objCodeFunctionEN.FuncSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncSignature = '{0}',", strFuncSignature); //函数签名
 }
 else
 {
 sbSQL.Append(" FuncSignature = null,"); //函数签名
 }
 }
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.UpdDate))
 {
 if (objCodeFunctionEN.UpdDate !=  null)
 {
 var strUpdDate = objCodeFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.UpdUser))
 {
 if (objCodeFunctionEN.UpdUser !=  null)
 {
 var strUpdUser = objCodeFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.Memo))
 {
 if (objCodeFunctionEN.Memo !=  null)
 {
 var strMemo = objCodeFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
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
 /// <param name = "objCodeFunctionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCodeFunctionEN objCodeFunctionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCodeFunctionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeFunctionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeFunctionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CodeFunction Set ");
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.CodeFuncName))
 {
 if (objCodeFunctionEN.CodeFuncName !=  null)
 {
 var strCodeFuncName = objCodeFunctionEN.CodeFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeFuncName, conCodeFunction.CodeFuncName); //代码函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeFunction.CodeFuncName); //代码函数名
 }
 }
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.FuncSignature))
 {
 if (objCodeFunctionEN.FuncSignature !=  null)
 {
 var strFuncSignature = objCodeFunctionEN.FuncSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncSignature, conCodeFunction.FuncSignature); //函数签名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeFunction.FuncSignature); //函数签名
 }
 }
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.UpdDate))
 {
 if (objCodeFunctionEN.UpdDate !=  null)
 {
 var strUpdDate = objCodeFunctionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCodeFunction.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeFunction.UpdDate); //修改日期
 }
 }
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.UpdUser))
 {
 if (objCodeFunctionEN.UpdUser !=  null)
 {
 var strUpdUser = objCodeFunctionEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCodeFunction.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeFunction.UpdUser); //修改者
 }
 }
 
 if (objCodeFunctionEN.IsUpdated(conCodeFunction.Memo))
 {
 if (objCodeFunctionEN.Memo !=  null)
 {
 var strMemo = objCodeFunctionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCodeFunction.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeFunction.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CodeFuncId = '{0}'", objCodeFunctionEN.CodeFuncId); 
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
 /// <param name = "strCodeFuncId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCodeFuncId) 
{
CheckPrimaryKey(strCodeFuncId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCodeFuncId,
};
 objSQL.ExecSP("CodeFunction_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCodeFuncId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCodeFuncId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCodeFuncId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
//删除CodeFunction本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CodeFunction where CodeFuncId = " + "'"+ strCodeFuncId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCodeFunction(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
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
//删除CodeFunction本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CodeFunction where CodeFuncId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCodeFuncId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCodeFuncId) 
{
CheckPrimaryKey(strCodeFuncId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
//删除CodeFunction本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CodeFunction where CodeFuncId = " + "'"+ strCodeFuncId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCodeFunction(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCodeFunctionDA: DelCodeFunction)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CodeFunction where " + strCondition ;
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
public bool DelCodeFunctionWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCodeFunctionDA: DelCodeFunctionWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CodeFunction where " + strCondition ;
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
 /// <param name = "objCodeFunctionENS">源对象</param>
 /// <param name = "objCodeFunctionENT">目标对象</param>
public void CopyTo(clsCodeFunctionEN objCodeFunctionENS, clsCodeFunctionEN objCodeFunctionENT)
{
objCodeFunctionENT.CodeFuncId = objCodeFunctionENS.CodeFuncId; //代码函数Id
objCodeFunctionENT.CodeFuncName = objCodeFunctionENS.CodeFuncName; //代码函数名
objCodeFunctionENT.FuncSignature = objCodeFunctionENS.FuncSignature; //函数签名
objCodeFunctionENT.UpdDate = objCodeFunctionENS.UpdDate; //修改日期
objCodeFunctionENT.UpdUser = objCodeFunctionENS.UpdUser; //修改者
objCodeFunctionENT.Memo = objCodeFunctionENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCodeFunctionEN objCodeFunctionEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objCodeFunctionEN.CodeFuncId, 4, conCodeFunction.CodeFuncId);
clsCheckSql.CheckFieldLen(objCodeFunctionEN.CodeFuncName, 50, conCodeFunction.CodeFuncName);
clsCheckSql.CheckFieldLen(objCodeFunctionEN.FuncSignature, 300, conCodeFunction.FuncSignature);
clsCheckSql.CheckFieldLen(objCodeFunctionEN.UpdDate, 20, conCodeFunction.UpdDate);
clsCheckSql.CheckFieldLen(objCodeFunctionEN.UpdUser, 20, conCodeFunction.UpdUser);
clsCheckSql.CheckFieldLen(objCodeFunctionEN.Memo, 1000, conCodeFunction.Memo);
//检查字段外键固定长度
 objCodeFunctionEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCodeFunctionEN objCodeFunctionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCodeFunctionEN.CodeFuncName, 50, conCodeFunction.CodeFuncName);
clsCheckSql.CheckFieldLen(objCodeFunctionEN.FuncSignature, 300, conCodeFunction.FuncSignature);
clsCheckSql.CheckFieldLen(objCodeFunctionEN.UpdDate, 20, conCodeFunction.UpdDate);
clsCheckSql.CheckFieldLen(objCodeFunctionEN.UpdUser, 20, conCodeFunction.UpdUser);
clsCheckSql.CheckFieldLen(objCodeFunctionEN.Memo, 1000, conCodeFunction.Memo);
//检查外键字段长度
 objCodeFunctionEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCodeFunctionEN objCodeFunctionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCodeFunctionEN.CodeFuncId, 4, conCodeFunction.CodeFuncId);
clsCheckSql.CheckFieldLen(objCodeFunctionEN.CodeFuncName, 50, conCodeFunction.CodeFuncName);
clsCheckSql.CheckFieldLen(objCodeFunctionEN.FuncSignature, 300, conCodeFunction.FuncSignature);
clsCheckSql.CheckFieldLen(objCodeFunctionEN.UpdDate, 20, conCodeFunction.UpdDate);
clsCheckSql.CheckFieldLen(objCodeFunctionEN.UpdUser, 20, conCodeFunction.UpdUser);
clsCheckSql.CheckFieldLen(objCodeFunctionEN.Memo, 1000, conCodeFunction.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCodeFunctionEN.CodeFuncId, conCodeFunction.CodeFuncId);
clsCheckSql.CheckSqlInjection4Field(objCodeFunctionEN.CodeFuncName, conCodeFunction.CodeFuncName);
clsCheckSql.CheckSqlInjection4Field(objCodeFunctionEN.FuncSignature, conCodeFunction.FuncSignature);
clsCheckSql.CheckSqlInjection4Field(objCodeFunctionEN.UpdDate, conCodeFunction.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCodeFunctionEN.UpdUser, conCodeFunction.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objCodeFunctionEN.Memo, conCodeFunction.Memo);
//检查外键字段长度
 objCodeFunctionEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCodeFuncId()
{
//获取某学院所有专业信息
string strSQL = "select CodeFuncId, CodeFuncName from CodeFunction ";
 clsSpecSQLforSql mySql = clsCodeFunctionDA.GetSpecSQLObj();
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
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
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
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
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
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCodeFunctionEN._CurrTabName);
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
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCodeFunctionEN._CurrTabName, strCondition);
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
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
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
 objSQL = clsCodeFunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}