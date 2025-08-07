
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWebSrvFuncParaDA
 表名:WebSrvFuncPara(00050347)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:46
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// WebSrv函数参数(WebSrvFuncPara)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsWebSrvFuncParaDA : clsCommBase4DA
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
 return clsWebSrvFuncParaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsWebSrvFuncParaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsWebSrvFuncParaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsWebSrvFuncParaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsWebSrvFuncParaEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strWebSrvFuncParaId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strWebSrvFuncParaId)
{
strWebSrvFuncParaId = strWebSrvFuncParaId.Replace("'", "''");
if (strWebSrvFuncParaId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:WebSrvFuncPara中,检查关键字,长度不正确!(clsWebSrvFuncParaDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strWebSrvFuncParaId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:WebSrvFuncPara中,关键字不能为空 或 null!(clsWebSrvFuncParaDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWebSrvFuncParaId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsWebSrvFuncParaDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsWebSrvFuncParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFuncPara where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_WebSrvFuncPara(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsWebSrvFuncParaDA: GetDataTable_WebSrvFuncPara)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFuncPara where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsWebSrvFuncParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsWebSrvFuncParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFuncPara where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsWebSrvFuncParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsWebSrvFuncParaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from WebSrvFuncPara where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from WebSrvFuncPara where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsWebSrvFuncParaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from WebSrvFuncPara where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsWebSrvFuncParaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} WebSrvFuncPara.* " + 
$"from WebSrvFuncPara " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and WebSrvFuncPara.WebSrvFuncParaId not in " + 
$"(Select top {intTop_In} WebSrvFuncPara.WebSrvFuncParaId from WebSrvFuncPara " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from WebSrvFuncPara where {1} and WebSrvFuncParaId not in (Select top {2} WebSrvFuncParaId from WebSrvFuncPara where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from WebSrvFuncPara where {1} and WebSrvFuncParaId not in (Select top {3} WebSrvFuncParaId from WebSrvFuncPara where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsWebSrvFuncParaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} WebSrvFuncPara.* " + 
$"from WebSrvFuncPara " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and WebSrvFuncPara.WebSrvFuncParaId not in " + 
$"(Select top {intTop_In} WebSrvFuncPara.WebSrvFuncParaId from WebSrvFuncPara " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from WebSrvFuncPara where {1} and WebSrvFuncParaId not in (Select top {2} WebSrvFuncParaId from WebSrvFuncPara where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from WebSrvFuncPara where {1} and WebSrvFuncParaId not in (Select top {3} WebSrvFuncParaId from WebSrvFuncPara where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsWebSrvFuncParaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsWebSrvFuncParaDA:GetObjLst)", objException.Message));
}
List<clsWebSrvFuncParaEN> arrObjLst = new List<clsWebSrvFuncParaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFuncPara where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvFuncParaEN objWebSrvFuncParaEN = new clsWebSrvFuncParaEN();
try
{
objWebSrvFuncParaEN.WebSrvFuncParaId = objRow[conWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objWebSrvFuncParaEN.WebSrvFunctionId = objRow[conWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objWebSrvFuncParaEN.DataTypeId = objRow[conWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objWebSrvFuncParaEN.ParameterType = objRow[conWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objWebSrvFuncParaEN.ParameterTypeFullName = objRow[conWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objWebSrvFuncParaEN.IsByRef = TransNullToBool(objRow[conWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objWebSrvFuncParaEN.ParaName = objRow[conWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objWebSrvFuncParaEN.ParaCnName = objRow[conWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objWebSrvFuncParaEN.IsKnownType = TransNullToBool(objRow[conWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objWebSrvFuncParaEN.UpdDate = objRow[conWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objWebSrvFuncParaEN.UpdUser = objRow[conWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objWebSrvFuncParaEN.Memo = objRow[conWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[conWebSrvFuncPara.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsWebSrvFuncParaDA: GetObjLst)", objException.Message));
}
objWebSrvFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objWebSrvFuncParaEN);
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
public List<clsWebSrvFuncParaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsWebSrvFuncParaDA:GetObjLstByTabName)", objException.Message));
}
List<clsWebSrvFuncParaEN> arrObjLst = new List<clsWebSrvFuncParaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvFuncParaEN objWebSrvFuncParaEN = new clsWebSrvFuncParaEN();
try
{
objWebSrvFuncParaEN.WebSrvFuncParaId = objRow[conWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objWebSrvFuncParaEN.WebSrvFunctionId = objRow[conWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objWebSrvFuncParaEN.DataTypeId = objRow[conWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objWebSrvFuncParaEN.ParameterType = objRow[conWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objWebSrvFuncParaEN.ParameterTypeFullName = objRow[conWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objWebSrvFuncParaEN.IsByRef = TransNullToBool(objRow[conWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objWebSrvFuncParaEN.ParaName = objRow[conWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objWebSrvFuncParaEN.ParaCnName = objRow[conWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objWebSrvFuncParaEN.IsKnownType = TransNullToBool(objRow[conWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objWebSrvFuncParaEN.UpdDate = objRow[conWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objWebSrvFuncParaEN.UpdUser = objRow[conWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objWebSrvFuncParaEN.Memo = objRow[conWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[conWebSrvFuncPara.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsWebSrvFuncParaDA: GetObjLst)", objException.Message));
}
objWebSrvFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objWebSrvFuncParaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetWebSrvFuncPara(ref clsWebSrvFuncParaEN objWebSrvFuncParaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFuncPara where WebSrvFuncParaId = " + "'"+ objWebSrvFuncParaEN.WebSrvFuncParaId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objWebSrvFuncParaEN.WebSrvFuncParaId = objDT.Rows[0][conWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id(字段类型:char,字段长度:8,是否可空:False)
 objWebSrvFuncParaEN.WebSrvFunctionId = objDT.Rows[0][conWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objWebSrvFuncParaEN.DataTypeId = objDT.Rows[0][conWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objWebSrvFuncParaEN.ParameterType = objDT.Rows[0][conWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objWebSrvFuncParaEN.ParameterTypeFullName = objDT.Rows[0][conWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objWebSrvFuncParaEN.IsByRef = TransNullToBool(objDT.Rows[0][conWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数(字段类型:bit,字段长度:1,是否可空:True)
 objWebSrvFuncParaEN.ParaName = objDT.Rows[0][conWebSrvFuncPara.ParaName].ToString().Trim(); //参数名(字段类型:varchar,字段长度:50,是否可空:False)
 objWebSrvFuncParaEN.ParaCnName = objDT.Rows[0][conWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objWebSrvFuncParaEN.IsKnownType = TransNullToBool(objDT.Rows[0][conWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型(字段类型:bit,字段长度:1,是否可空:True)
 objWebSrvFuncParaEN.UpdDate = objDT.Rows[0][conWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objWebSrvFuncParaEN.UpdUser = objDT.Rows[0][conWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objWebSrvFuncParaEN.Memo = objDT.Rows[0][conWebSrvFuncPara.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsWebSrvFuncParaDA: GetWebSrvFuncPara)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strWebSrvFuncParaId">表关键字</param>
 /// <returns>表对象</returns>
public clsWebSrvFuncParaEN GetObjByWebSrvFuncParaId(string strWebSrvFuncParaId)
{
CheckPrimaryKey(strWebSrvFuncParaId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFuncPara where WebSrvFuncParaId = " + "'"+ strWebSrvFuncParaId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsWebSrvFuncParaEN objWebSrvFuncParaEN = new clsWebSrvFuncParaEN();
try
{
 objWebSrvFuncParaEN.WebSrvFuncParaId = objRow[conWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id(字段类型:char,字段长度:8,是否可空:False)
 objWebSrvFuncParaEN.WebSrvFunctionId = objRow[conWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objWebSrvFuncParaEN.DataTypeId = objRow[conWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objWebSrvFuncParaEN.ParameterType = objRow[conWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objWebSrvFuncParaEN.ParameterTypeFullName = objRow[conWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objWebSrvFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数(字段类型:bit,字段长度:1,是否可空:True)
 objWebSrvFuncParaEN.ParaName = objRow[conWebSrvFuncPara.ParaName].ToString().Trim(); //参数名(字段类型:varchar,字段长度:50,是否可空:False)
 objWebSrvFuncParaEN.ParaCnName = objRow[conWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objWebSrvFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型(字段类型:bit,字段长度:1,是否可空:True)
 objWebSrvFuncParaEN.UpdDate = objRow[conWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objWebSrvFuncParaEN.UpdUser = objRow[conWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objWebSrvFuncParaEN.Memo = objRow[conWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[conWebSrvFuncPara.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsWebSrvFuncParaDA: GetObjByWebSrvFuncParaId)", objException.Message));
}
return objWebSrvFuncParaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsWebSrvFuncParaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsWebSrvFuncParaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFuncPara where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsWebSrvFuncParaEN objWebSrvFuncParaEN = new clsWebSrvFuncParaEN()
{
WebSrvFuncParaId = objRow[conWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(), //函数参数Id
WebSrvFunctionId = objRow[conWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(), //函数Id
DataTypeId = objRow[conWebSrvFuncPara.DataTypeId].ToString().Trim(), //数据类型Id
ParameterType = objRow[conWebSrvFuncPara.ParameterType].ToString().Trim(), //参数类型
ParameterTypeFullName = objRow[conWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(), //参数类型全名
IsByRef = TransNullToBool(objRow[conWebSrvFuncPara.IsByRef].ToString().Trim()), //是否引用型参数
ParaName = objRow[conWebSrvFuncPara.ParaName].ToString().Trim(), //参数名
ParaCnName = objRow[conWebSrvFuncPara.ParaCnName].ToString().Trim(), //参数中文名
IsKnownType = TransNullToBool(objRow[conWebSrvFuncPara.IsKnownType].ToString().Trim()), //是否已知类型
UpdDate = objRow[conWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFuncPara.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFuncPara.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[conWebSrvFuncPara.Memo].ToString().Trim() //说明
};
objWebSrvFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objWebSrvFuncParaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsWebSrvFuncParaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsWebSrvFuncParaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsWebSrvFuncParaEN objWebSrvFuncParaEN = new clsWebSrvFuncParaEN();
try
{
objWebSrvFuncParaEN.WebSrvFuncParaId = objRow[conWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objWebSrvFuncParaEN.WebSrvFunctionId = objRow[conWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objWebSrvFuncParaEN.DataTypeId = objRow[conWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objWebSrvFuncParaEN.ParameterType = objRow[conWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objWebSrvFuncParaEN.ParameterTypeFullName = objRow[conWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objWebSrvFuncParaEN.IsByRef = TransNullToBool(objRow[conWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objWebSrvFuncParaEN.ParaName = objRow[conWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objWebSrvFuncParaEN.ParaCnName = objRow[conWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objWebSrvFuncParaEN.IsKnownType = TransNullToBool(objRow[conWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objWebSrvFuncParaEN.UpdDate = objRow[conWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objWebSrvFuncParaEN.UpdUser = objRow[conWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objWebSrvFuncParaEN.Memo = objRow[conWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[conWebSrvFuncPara.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsWebSrvFuncParaDA: GetObjByDataRowWebSrvFuncPara)", objException.Message));
}
objWebSrvFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objWebSrvFuncParaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsWebSrvFuncParaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsWebSrvFuncParaEN objWebSrvFuncParaEN = new clsWebSrvFuncParaEN();
try
{
objWebSrvFuncParaEN.WebSrvFuncParaId = objRow[conWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objWebSrvFuncParaEN.WebSrvFunctionId = objRow[conWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objWebSrvFuncParaEN.DataTypeId = objRow[conWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objWebSrvFuncParaEN.ParameterType = objRow[conWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objWebSrvFuncParaEN.ParameterTypeFullName = objRow[conWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objWebSrvFuncParaEN.IsByRef = TransNullToBool(objRow[conWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objWebSrvFuncParaEN.ParaName = objRow[conWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objWebSrvFuncParaEN.ParaCnName = objRow[conWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objWebSrvFuncParaEN.IsKnownType = TransNullToBool(objRow[conWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objWebSrvFuncParaEN.UpdDate = objRow[conWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objWebSrvFuncParaEN.UpdUser = objRow[conWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objWebSrvFuncParaEN.Memo = objRow[conWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[conWebSrvFuncPara.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsWebSrvFuncParaDA: GetObjByDataRow)", objException.Message));
}
objWebSrvFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objWebSrvFuncParaEN;
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
objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsWebSrvFuncParaEN._CurrTabName, conWebSrvFuncPara.WebSrvFuncParaId, 8, "");
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
objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsWebSrvFuncParaEN._CurrTabName, conWebSrvFuncPara.WebSrvFuncParaId, 8, strPrefix);
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
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select WebSrvFuncParaId from WebSrvFuncPara where " + strCondition;
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
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select WebSrvFuncParaId from WebSrvFuncPara where " + strCondition;
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
 /// <param name = "strWebSrvFuncParaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strWebSrvFuncParaId)
{
CheckPrimaryKey(strWebSrvFuncParaId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("WebSrvFuncPara", "WebSrvFuncParaId = " + "'"+ strWebSrvFuncParaId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsWebSrvFuncParaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("WebSrvFuncPara", strCondition))
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
objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("WebSrvFuncPara");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsWebSrvFuncParaEN objWebSrvFuncParaEN)
 {
 objWebSrvFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebSrvFuncParaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFuncPara where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "WebSrvFuncPara");
objRow = objDS.Tables["WebSrvFuncPara"].NewRow();
objRow[conWebSrvFuncPara.WebSrvFuncParaId] = objWebSrvFuncParaEN.WebSrvFuncParaId; //函数参数Id
objRow[conWebSrvFuncPara.WebSrvFunctionId] = objWebSrvFuncParaEN.WebSrvFunctionId; //函数Id
objRow[conWebSrvFuncPara.DataTypeId] = objWebSrvFuncParaEN.DataTypeId; //数据类型Id
objRow[conWebSrvFuncPara.ParameterType] = objWebSrvFuncParaEN.ParameterType; //参数类型
 if (objWebSrvFuncParaEN.ParameterTypeFullName !=  "")
 {
objRow[conWebSrvFuncPara.ParameterTypeFullName] = objWebSrvFuncParaEN.ParameterTypeFullName; //参数类型全名
 }
objRow[conWebSrvFuncPara.IsByRef] = objWebSrvFuncParaEN.IsByRef; //是否引用型参数
objRow[conWebSrvFuncPara.ParaName] = objWebSrvFuncParaEN.ParaName; //参数名
objRow[conWebSrvFuncPara.ParaCnName] = objWebSrvFuncParaEN.ParaCnName; //参数中文名
objRow[conWebSrvFuncPara.IsKnownType] = objWebSrvFuncParaEN.IsKnownType; //是否已知类型
 if (objWebSrvFuncParaEN.UpdDate !=  "")
 {
objRow[conWebSrvFuncPara.UpdDate] = objWebSrvFuncParaEN.UpdDate; //修改日期
 }
 if (objWebSrvFuncParaEN.UpdUser !=  "")
 {
objRow[conWebSrvFuncPara.UpdUser] = objWebSrvFuncParaEN.UpdUser; //修改者
 }
 if (objWebSrvFuncParaEN.Memo !=  "")
 {
objRow[conWebSrvFuncPara.Memo] = objWebSrvFuncParaEN.Memo; //说明
 }
objDS.Tables[clsWebSrvFuncParaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsWebSrvFuncParaEN._CurrTabName);
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
 /// <param name = "objWebSrvFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsWebSrvFuncParaEN objWebSrvFuncParaEN)
{
 objWebSrvFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebSrvFuncParaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objWebSrvFuncParaEN.WebSrvFuncParaId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.WebSrvFuncParaId);
 var strWebSrvFuncParaId = objWebSrvFuncParaEN.WebSrvFuncParaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvFuncParaId + "'");
 }
 
 if (objWebSrvFuncParaEN.WebSrvFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.WebSrvFunctionId);
 var strWebSrvFunctionId = objWebSrvFuncParaEN.WebSrvFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvFunctionId + "'");
 }
 
 if (objWebSrvFuncParaEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.DataTypeId);
 var strDataTypeId = objWebSrvFuncParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objWebSrvFuncParaEN.ParameterType !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.ParameterType);
 var strParameterType = objWebSrvFuncParaEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterType + "'");
 }
 
 if (objWebSrvFuncParaEN.ParameterTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.ParameterTypeFullName);
 var strParameterTypeFullName = objWebSrvFuncParaEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFuncPara.IsByRef);
 arrValueListForInsert.Add("'" + (objWebSrvFuncParaEN.IsByRef  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFuncParaEN.ParaName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.ParaName);
 var strParaName = objWebSrvFuncParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaName + "'");
 }
 
 if (objWebSrvFuncParaEN.ParaCnName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.ParaCnName);
 var strParaCnName = objWebSrvFuncParaEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaCnName + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFuncPara.IsKnownType);
 arrValueListForInsert.Add("'" + (objWebSrvFuncParaEN.IsKnownType  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFuncParaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.UpdDate);
 var strUpdDate = objWebSrvFuncParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWebSrvFuncParaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.UpdUser);
 var strUpdUser = objWebSrvFuncParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objWebSrvFuncParaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.Memo);
 var strMemo = objWebSrvFuncParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WebSrvFuncPara");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsWebSrvFuncParaEN objWebSrvFuncParaEN)
{
 objWebSrvFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebSrvFuncParaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objWebSrvFuncParaEN.WebSrvFuncParaId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.WebSrvFuncParaId);
 var strWebSrvFuncParaId = objWebSrvFuncParaEN.WebSrvFuncParaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvFuncParaId + "'");
 }
 
 if (objWebSrvFuncParaEN.WebSrvFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.WebSrvFunctionId);
 var strWebSrvFunctionId = objWebSrvFuncParaEN.WebSrvFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvFunctionId + "'");
 }
 
 if (objWebSrvFuncParaEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.DataTypeId);
 var strDataTypeId = objWebSrvFuncParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objWebSrvFuncParaEN.ParameterType !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.ParameterType);
 var strParameterType = objWebSrvFuncParaEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterType + "'");
 }
 
 if (objWebSrvFuncParaEN.ParameterTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.ParameterTypeFullName);
 var strParameterTypeFullName = objWebSrvFuncParaEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFuncPara.IsByRef);
 arrValueListForInsert.Add("'" + (objWebSrvFuncParaEN.IsByRef  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFuncParaEN.ParaName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.ParaName);
 var strParaName = objWebSrvFuncParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaName + "'");
 }
 
 if (objWebSrvFuncParaEN.ParaCnName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.ParaCnName);
 var strParaCnName = objWebSrvFuncParaEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaCnName + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFuncPara.IsKnownType);
 arrValueListForInsert.Add("'" + (objWebSrvFuncParaEN.IsKnownType  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFuncParaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.UpdDate);
 var strUpdDate = objWebSrvFuncParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWebSrvFuncParaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.UpdUser);
 var strUpdUser = objWebSrvFuncParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objWebSrvFuncParaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.Memo);
 var strMemo = objWebSrvFuncParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WebSrvFuncPara");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objWebSrvFuncParaEN.WebSrvFuncParaId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsWebSrvFuncParaEN objWebSrvFuncParaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objWebSrvFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebSrvFuncParaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objWebSrvFuncParaEN.WebSrvFuncParaId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.WebSrvFuncParaId);
 var strWebSrvFuncParaId = objWebSrvFuncParaEN.WebSrvFuncParaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvFuncParaId + "'");
 }
 
 if (objWebSrvFuncParaEN.WebSrvFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.WebSrvFunctionId);
 var strWebSrvFunctionId = objWebSrvFuncParaEN.WebSrvFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvFunctionId + "'");
 }
 
 if (objWebSrvFuncParaEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.DataTypeId);
 var strDataTypeId = objWebSrvFuncParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objWebSrvFuncParaEN.ParameterType !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.ParameterType);
 var strParameterType = objWebSrvFuncParaEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterType + "'");
 }
 
 if (objWebSrvFuncParaEN.ParameterTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.ParameterTypeFullName);
 var strParameterTypeFullName = objWebSrvFuncParaEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFuncPara.IsByRef);
 arrValueListForInsert.Add("'" + (objWebSrvFuncParaEN.IsByRef  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFuncParaEN.ParaName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.ParaName);
 var strParaName = objWebSrvFuncParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaName + "'");
 }
 
 if (objWebSrvFuncParaEN.ParaCnName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.ParaCnName);
 var strParaCnName = objWebSrvFuncParaEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaCnName + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFuncPara.IsKnownType);
 arrValueListForInsert.Add("'" + (objWebSrvFuncParaEN.IsKnownType  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFuncParaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.UpdDate);
 var strUpdDate = objWebSrvFuncParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWebSrvFuncParaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.UpdUser);
 var strUpdUser = objWebSrvFuncParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objWebSrvFuncParaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.Memo);
 var strMemo = objWebSrvFuncParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WebSrvFuncPara");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objWebSrvFuncParaEN.WebSrvFuncParaId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsWebSrvFuncParaEN objWebSrvFuncParaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objWebSrvFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebSrvFuncParaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objWebSrvFuncParaEN.WebSrvFuncParaId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.WebSrvFuncParaId);
 var strWebSrvFuncParaId = objWebSrvFuncParaEN.WebSrvFuncParaId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvFuncParaId + "'");
 }
 
 if (objWebSrvFuncParaEN.WebSrvFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.WebSrvFunctionId);
 var strWebSrvFunctionId = objWebSrvFuncParaEN.WebSrvFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvFunctionId + "'");
 }
 
 if (objWebSrvFuncParaEN.DataTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.DataTypeId);
 var strDataTypeId = objWebSrvFuncParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTypeId + "'");
 }
 
 if (objWebSrvFuncParaEN.ParameterType !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.ParameterType);
 var strParameterType = objWebSrvFuncParaEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterType + "'");
 }
 
 if (objWebSrvFuncParaEN.ParameterTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.ParameterTypeFullName);
 var strParameterTypeFullName = objWebSrvFuncParaEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParameterTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFuncPara.IsByRef);
 arrValueListForInsert.Add("'" + (objWebSrvFuncParaEN.IsByRef  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFuncParaEN.ParaName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.ParaName);
 var strParaName = objWebSrvFuncParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaName + "'");
 }
 
 if (objWebSrvFuncParaEN.ParaCnName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.ParaCnName);
 var strParaCnName = objWebSrvFuncParaEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaCnName + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFuncPara.IsKnownType);
 arrValueListForInsert.Add("'" + (objWebSrvFuncParaEN.IsKnownType  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFuncParaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.UpdDate);
 var strUpdDate = objWebSrvFuncParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWebSrvFuncParaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.UpdUser);
 var strUpdUser = objWebSrvFuncParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objWebSrvFuncParaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFuncPara.Memo);
 var strMemo = objWebSrvFuncParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WebSrvFuncPara");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewWebSrvFuncParas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFuncPara where WebSrvFuncParaId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "WebSrvFuncPara");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strWebSrvFuncParaId = oRow[conWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim();
if (IsExist(strWebSrvFuncParaId))
{
 string strResult = "关键字变量值为:" + string.Format("WebSrvFuncParaId = {0}", strWebSrvFuncParaId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsWebSrvFuncParaEN._CurrTabName ].NewRow();
objRow[conWebSrvFuncPara.WebSrvFuncParaId] = oRow[conWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objRow[conWebSrvFuncPara.WebSrvFunctionId] = oRow[conWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objRow[conWebSrvFuncPara.DataTypeId] = oRow[conWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objRow[conWebSrvFuncPara.ParameterType] = oRow[conWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objRow[conWebSrvFuncPara.ParameterTypeFullName] = oRow[conWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objRow[conWebSrvFuncPara.IsByRef] = oRow[conWebSrvFuncPara.IsByRef].ToString().Trim(); //是否引用型参数
objRow[conWebSrvFuncPara.ParaName] = oRow[conWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objRow[conWebSrvFuncPara.ParaCnName] = oRow[conWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objRow[conWebSrvFuncPara.IsKnownType] = oRow[conWebSrvFuncPara.IsKnownType].ToString().Trim(); //是否已知类型
objRow[conWebSrvFuncPara.UpdDate] = oRow[conWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objRow[conWebSrvFuncPara.UpdUser] = oRow[conWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objRow[conWebSrvFuncPara.Memo] = oRow[conWebSrvFuncPara.Memo].ToString().Trim(); //说明
 objDS.Tables[clsWebSrvFuncParaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsWebSrvFuncParaEN._CurrTabName);
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
 /// <param name = "objWebSrvFuncParaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsWebSrvFuncParaEN objWebSrvFuncParaEN)
{
 objWebSrvFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebSrvFuncParaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFuncPara where WebSrvFuncParaId = " + "'"+ objWebSrvFuncParaEN.WebSrvFuncParaId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsWebSrvFuncParaEN._CurrTabName);
if (objDS.Tables[clsWebSrvFuncParaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:WebSrvFuncParaId = " + "'"+ objWebSrvFuncParaEN.WebSrvFuncParaId+"'");
return false;
}
objRow = objDS.Tables[clsWebSrvFuncParaEN._CurrTabName].Rows[0];
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.WebSrvFuncParaId))
 {
objRow[conWebSrvFuncPara.WebSrvFuncParaId] = objWebSrvFuncParaEN.WebSrvFuncParaId; //函数参数Id
 }
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.WebSrvFunctionId))
 {
objRow[conWebSrvFuncPara.WebSrvFunctionId] = objWebSrvFuncParaEN.WebSrvFunctionId; //函数Id
 }
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.DataTypeId))
 {
objRow[conWebSrvFuncPara.DataTypeId] = objWebSrvFuncParaEN.DataTypeId; //数据类型Id
 }
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParameterType))
 {
objRow[conWebSrvFuncPara.ParameterType] = objWebSrvFuncParaEN.ParameterType; //参数类型
 }
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParameterTypeFullName))
 {
objRow[conWebSrvFuncPara.ParameterTypeFullName] = objWebSrvFuncParaEN.ParameterTypeFullName; //参数类型全名
 }
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.IsByRef))
 {
objRow[conWebSrvFuncPara.IsByRef] = objWebSrvFuncParaEN.IsByRef; //是否引用型参数
 }
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParaName))
 {
objRow[conWebSrvFuncPara.ParaName] = objWebSrvFuncParaEN.ParaName; //参数名
 }
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParaCnName))
 {
objRow[conWebSrvFuncPara.ParaCnName] = objWebSrvFuncParaEN.ParaCnName; //参数中文名
 }
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.IsKnownType))
 {
objRow[conWebSrvFuncPara.IsKnownType] = objWebSrvFuncParaEN.IsKnownType; //是否已知类型
 }
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.UpdDate))
 {
objRow[conWebSrvFuncPara.UpdDate] = objWebSrvFuncParaEN.UpdDate; //修改日期
 }
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.UpdUser))
 {
objRow[conWebSrvFuncPara.UpdUser] = objWebSrvFuncParaEN.UpdUser; //修改者
 }
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.Memo))
 {
objRow[conWebSrvFuncPara.Memo] = objWebSrvFuncParaEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsWebSrvFuncParaEN._CurrTabName);
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
 /// <param name = "objWebSrvFuncParaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsWebSrvFuncParaEN objWebSrvFuncParaEN)
{
 objWebSrvFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebSrvFuncParaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update WebSrvFuncPara Set ");
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.WebSrvFunctionId))
 {
 if (objWebSrvFuncParaEN.WebSrvFunctionId !=  null)
 {
 var strWebSrvFunctionId = objWebSrvFuncParaEN.WebSrvFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebSrvFunctionId, conWebSrvFuncPara.WebSrvFunctionId); //函数Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFuncPara.WebSrvFunctionId); //函数Id
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.DataTypeId))
 {
 if (objWebSrvFuncParaEN.DataTypeId !=  null)
 {
 var strDataTypeId = objWebSrvFuncParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeId, conWebSrvFuncPara.DataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFuncPara.DataTypeId); //数据类型Id
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParameterType))
 {
 if (objWebSrvFuncParaEN.ParameterType !=  null)
 {
 var strParameterType = objWebSrvFuncParaEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParameterType, conWebSrvFuncPara.ParameterType); //参数类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFuncPara.ParameterType); //参数类型
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParameterTypeFullName))
 {
 if (objWebSrvFuncParaEN.ParameterTypeFullName !=  null)
 {
 var strParameterTypeFullName = objWebSrvFuncParaEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParameterTypeFullName, conWebSrvFuncPara.ParameterTypeFullName); //参数类型全名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFuncPara.ParameterTypeFullName); //参数类型全名
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.IsByRef))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWebSrvFuncParaEN.IsByRef == true?"1":"0", conWebSrvFuncPara.IsByRef); //是否引用型参数
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParaName))
 {
 if (objWebSrvFuncParaEN.ParaName !=  null)
 {
 var strParaName = objWebSrvFuncParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaName, conWebSrvFuncPara.ParaName); //参数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFuncPara.ParaName); //参数名
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParaCnName))
 {
 if (objWebSrvFuncParaEN.ParaCnName !=  null)
 {
 var strParaCnName = objWebSrvFuncParaEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaCnName, conWebSrvFuncPara.ParaCnName); //参数中文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFuncPara.ParaCnName); //参数中文名
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.IsKnownType))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWebSrvFuncParaEN.IsKnownType == true?"1":"0", conWebSrvFuncPara.IsKnownType); //是否已知类型
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.UpdDate))
 {
 if (objWebSrvFuncParaEN.UpdDate !=  null)
 {
 var strUpdDate = objWebSrvFuncParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conWebSrvFuncPara.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFuncPara.UpdDate); //修改日期
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.UpdUser))
 {
 if (objWebSrvFuncParaEN.UpdUser !=  null)
 {
 var strUpdUser = objWebSrvFuncParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conWebSrvFuncPara.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFuncPara.UpdUser); //修改者
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.Memo))
 {
 if (objWebSrvFuncParaEN.Memo !=  null)
 {
 var strMemo = objWebSrvFuncParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conWebSrvFuncPara.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFuncPara.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where WebSrvFuncParaId = '{0}'", objWebSrvFuncParaEN.WebSrvFuncParaId); 
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
 /// <param name = "objWebSrvFuncParaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsWebSrvFuncParaEN objWebSrvFuncParaEN, string strCondition)
{
 objWebSrvFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebSrvFuncParaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update WebSrvFuncPara Set ");
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.WebSrvFunctionId))
 {
 if (objWebSrvFuncParaEN.WebSrvFunctionId !=  null)
 {
 var strWebSrvFunctionId = objWebSrvFuncParaEN.WebSrvFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebSrvFunctionId = '{0}',", strWebSrvFunctionId); //函数Id
 }
 else
 {
 sbSQL.Append(" WebSrvFunctionId = null,"); //函数Id
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.DataTypeId))
 {
 if (objWebSrvFuncParaEN.DataTypeId !=  null)
 {
 var strDataTypeId = objWebSrvFuncParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeId = '{0}',", strDataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.Append(" DataTypeId = null,"); //数据类型Id
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParameterType))
 {
 if (objWebSrvFuncParaEN.ParameterType !=  null)
 {
 var strParameterType = objWebSrvFuncParaEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParameterType = '{0}',", strParameterType); //参数类型
 }
 else
 {
 sbSQL.Append(" ParameterType = null,"); //参数类型
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParameterTypeFullName))
 {
 if (objWebSrvFuncParaEN.ParameterTypeFullName !=  null)
 {
 var strParameterTypeFullName = objWebSrvFuncParaEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParameterTypeFullName = '{0}',", strParameterTypeFullName); //参数类型全名
 }
 else
 {
 sbSQL.Append(" ParameterTypeFullName = null,"); //参数类型全名
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.IsByRef))
 {
 sbSQL.AppendFormat(" IsByRef = '{0}',", objWebSrvFuncParaEN.IsByRef == true?"1":"0"); //是否引用型参数
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParaName))
 {
 if (objWebSrvFuncParaEN.ParaName !=  null)
 {
 var strParaName = objWebSrvFuncParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaName = '{0}',", strParaName); //参数名
 }
 else
 {
 sbSQL.Append(" ParaName = null,"); //参数名
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParaCnName))
 {
 if (objWebSrvFuncParaEN.ParaCnName !=  null)
 {
 var strParaCnName = objWebSrvFuncParaEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaCnName = '{0}',", strParaCnName); //参数中文名
 }
 else
 {
 sbSQL.Append(" ParaCnName = null,"); //参数中文名
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.IsKnownType))
 {
 sbSQL.AppendFormat(" IsKnownType = '{0}',", objWebSrvFuncParaEN.IsKnownType == true?"1":"0"); //是否已知类型
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.UpdDate))
 {
 if (objWebSrvFuncParaEN.UpdDate !=  null)
 {
 var strUpdDate = objWebSrvFuncParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.UpdUser))
 {
 if (objWebSrvFuncParaEN.UpdUser !=  null)
 {
 var strUpdUser = objWebSrvFuncParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.Memo))
 {
 if (objWebSrvFuncParaEN.Memo !=  null)
 {
 var strMemo = objWebSrvFuncParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objWebSrvFuncParaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsWebSrvFuncParaEN objWebSrvFuncParaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objWebSrvFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebSrvFuncParaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update WebSrvFuncPara Set ");
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.WebSrvFunctionId))
 {
 if (objWebSrvFuncParaEN.WebSrvFunctionId !=  null)
 {
 var strWebSrvFunctionId = objWebSrvFuncParaEN.WebSrvFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebSrvFunctionId = '{0}',", strWebSrvFunctionId); //函数Id
 }
 else
 {
 sbSQL.Append(" WebSrvFunctionId = null,"); //函数Id
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.DataTypeId))
 {
 if (objWebSrvFuncParaEN.DataTypeId !=  null)
 {
 var strDataTypeId = objWebSrvFuncParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTypeId = '{0}',", strDataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.Append(" DataTypeId = null,"); //数据类型Id
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParameterType))
 {
 if (objWebSrvFuncParaEN.ParameterType !=  null)
 {
 var strParameterType = objWebSrvFuncParaEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParameterType = '{0}',", strParameterType); //参数类型
 }
 else
 {
 sbSQL.Append(" ParameterType = null,"); //参数类型
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParameterTypeFullName))
 {
 if (objWebSrvFuncParaEN.ParameterTypeFullName !=  null)
 {
 var strParameterTypeFullName = objWebSrvFuncParaEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParameterTypeFullName = '{0}',", strParameterTypeFullName); //参数类型全名
 }
 else
 {
 sbSQL.Append(" ParameterTypeFullName = null,"); //参数类型全名
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.IsByRef))
 {
 sbSQL.AppendFormat(" IsByRef = '{0}',", objWebSrvFuncParaEN.IsByRef == true?"1":"0"); //是否引用型参数
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParaName))
 {
 if (objWebSrvFuncParaEN.ParaName !=  null)
 {
 var strParaName = objWebSrvFuncParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaName = '{0}',", strParaName); //参数名
 }
 else
 {
 sbSQL.Append(" ParaName = null,"); //参数名
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParaCnName))
 {
 if (objWebSrvFuncParaEN.ParaCnName !=  null)
 {
 var strParaCnName = objWebSrvFuncParaEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaCnName = '{0}',", strParaCnName); //参数中文名
 }
 else
 {
 sbSQL.Append(" ParaCnName = null,"); //参数中文名
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.IsKnownType))
 {
 sbSQL.AppendFormat(" IsKnownType = '{0}',", objWebSrvFuncParaEN.IsKnownType == true?"1":"0"); //是否已知类型
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.UpdDate))
 {
 if (objWebSrvFuncParaEN.UpdDate !=  null)
 {
 var strUpdDate = objWebSrvFuncParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.UpdUser))
 {
 if (objWebSrvFuncParaEN.UpdUser !=  null)
 {
 var strUpdUser = objWebSrvFuncParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.Memo))
 {
 if (objWebSrvFuncParaEN.Memo !=  null)
 {
 var strMemo = objWebSrvFuncParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objWebSrvFuncParaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsWebSrvFuncParaEN objWebSrvFuncParaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objWebSrvFuncParaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFuncParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebSrvFuncParaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update WebSrvFuncPara Set ");
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.WebSrvFunctionId))
 {
 if (objWebSrvFuncParaEN.WebSrvFunctionId !=  null)
 {
 var strWebSrvFunctionId = objWebSrvFuncParaEN.WebSrvFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebSrvFunctionId, conWebSrvFuncPara.WebSrvFunctionId); //函数Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFuncPara.WebSrvFunctionId); //函数Id
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.DataTypeId))
 {
 if (objWebSrvFuncParaEN.DataTypeId !=  null)
 {
 var strDataTypeId = objWebSrvFuncParaEN.DataTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTypeId, conWebSrvFuncPara.DataTypeId); //数据类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFuncPara.DataTypeId); //数据类型Id
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParameterType))
 {
 if (objWebSrvFuncParaEN.ParameterType !=  null)
 {
 var strParameterType = objWebSrvFuncParaEN.ParameterType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParameterType, conWebSrvFuncPara.ParameterType); //参数类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFuncPara.ParameterType); //参数类型
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParameterTypeFullName))
 {
 if (objWebSrvFuncParaEN.ParameterTypeFullName !=  null)
 {
 var strParameterTypeFullName = objWebSrvFuncParaEN.ParameterTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParameterTypeFullName, conWebSrvFuncPara.ParameterTypeFullName); //参数类型全名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFuncPara.ParameterTypeFullName); //参数类型全名
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.IsByRef))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWebSrvFuncParaEN.IsByRef == true?"1":"0", conWebSrvFuncPara.IsByRef); //是否引用型参数
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParaName))
 {
 if (objWebSrvFuncParaEN.ParaName !=  null)
 {
 var strParaName = objWebSrvFuncParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaName, conWebSrvFuncPara.ParaName); //参数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFuncPara.ParaName); //参数名
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.ParaCnName))
 {
 if (objWebSrvFuncParaEN.ParaCnName !=  null)
 {
 var strParaCnName = objWebSrvFuncParaEN.ParaCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaCnName, conWebSrvFuncPara.ParaCnName); //参数中文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFuncPara.ParaCnName); //参数中文名
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.IsKnownType))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWebSrvFuncParaEN.IsKnownType == true?"1":"0", conWebSrvFuncPara.IsKnownType); //是否已知类型
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.UpdDate))
 {
 if (objWebSrvFuncParaEN.UpdDate !=  null)
 {
 var strUpdDate = objWebSrvFuncParaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conWebSrvFuncPara.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFuncPara.UpdDate); //修改日期
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.UpdUser))
 {
 if (objWebSrvFuncParaEN.UpdUser !=  null)
 {
 var strUpdUser = objWebSrvFuncParaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conWebSrvFuncPara.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFuncPara.UpdUser); //修改者
 }
 }
 
 if (objWebSrvFuncParaEN.IsUpdated(conWebSrvFuncPara.Memo))
 {
 if (objWebSrvFuncParaEN.Memo !=  null)
 {
 var strMemo = objWebSrvFuncParaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conWebSrvFuncPara.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFuncPara.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where WebSrvFuncParaId = '{0}'", objWebSrvFuncParaEN.WebSrvFuncParaId); 
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
 /// <param name = "strWebSrvFuncParaId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strWebSrvFuncParaId) 
{
CheckPrimaryKey(strWebSrvFuncParaId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strWebSrvFuncParaId,
};
 objSQL.ExecSP("WebSrvFuncPara_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strWebSrvFuncParaId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strWebSrvFuncParaId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strWebSrvFuncParaId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
//删除WebSrvFuncPara本表中与当前对象有关的记录
strSQL = strSQL + "Delete from WebSrvFuncPara where WebSrvFuncParaId = " + "'"+ strWebSrvFuncParaId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelWebSrvFuncPara(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
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
//删除WebSrvFuncPara本表中与当前对象有关的记录
strSQL = strSQL + "Delete from WebSrvFuncPara where WebSrvFuncParaId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strWebSrvFuncParaId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strWebSrvFuncParaId) 
{
CheckPrimaryKey(strWebSrvFuncParaId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
//删除WebSrvFuncPara本表中与当前对象有关的记录
strSQL = strSQL + "Delete from WebSrvFuncPara where WebSrvFuncParaId = " + "'"+ strWebSrvFuncParaId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelWebSrvFuncPara(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsWebSrvFuncParaDA: DelWebSrvFuncPara)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from WebSrvFuncPara where " + strCondition ;
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
public bool DelWebSrvFuncParaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsWebSrvFuncParaDA: DelWebSrvFuncParaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from WebSrvFuncPara where " + strCondition ;
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
 /// <param name = "objWebSrvFuncParaENS">源对象</param>
 /// <param name = "objWebSrvFuncParaENT">目标对象</param>
public void CopyTo(clsWebSrvFuncParaEN objWebSrvFuncParaENS, clsWebSrvFuncParaEN objWebSrvFuncParaENT)
{
objWebSrvFuncParaENT.WebSrvFuncParaId = objWebSrvFuncParaENS.WebSrvFuncParaId; //函数参数Id
objWebSrvFuncParaENT.WebSrvFunctionId = objWebSrvFuncParaENS.WebSrvFunctionId; //函数Id
objWebSrvFuncParaENT.DataTypeId = objWebSrvFuncParaENS.DataTypeId; //数据类型Id
objWebSrvFuncParaENT.ParameterType = objWebSrvFuncParaENS.ParameterType; //参数类型
objWebSrvFuncParaENT.ParameterTypeFullName = objWebSrvFuncParaENS.ParameterTypeFullName; //参数类型全名
objWebSrvFuncParaENT.IsByRef = objWebSrvFuncParaENS.IsByRef; //是否引用型参数
objWebSrvFuncParaENT.ParaName = objWebSrvFuncParaENS.ParaName; //参数名
objWebSrvFuncParaENT.ParaCnName = objWebSrvFuncParaENS.ParaCnName; //参数中文名
objWebSrvFuncParaENT.IsKnownType = objWebSrvFuncParaENS.IsKnownType; //是否已知类型
objWebSrvFuncParaENT.UpdDate = objWebSrvFuncParaENS.UpdDate; //修改日期
objWebSrvFuncParaENT.UpdUser = objWebSrvFuncParaENS.UpdUser; //修改者
objWebSrvFuncParaENT.Memo = objWebSrvFuncParaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsWebSrvFuncParaEN objWebSrvFuncParaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objWebSrvFuncParaEN.WebSrvFunctionId, conWebSrvFuncPara.WebSrvFunctionId);
clsCheckSql.CheckFieldNotNull(objWebSrvFuncParaEN.DataTypeId, conWebSrvFuncPara.DataTypeId);
clsCheckSql.CheckFieldNotNull(objWebSrvFuncParaEN.ParameterType, conWebSrvFuncPara.ParameterType);
clsCheckSql.CheckFieldNotNull(objWebSrvFuncParaEN.IsByRef, conWebSrvFuncPara.IsByRef);
clsCheckSql.CheckFieldNotNull(objWebSrvFuncParaEN.ParaName, conWebSrvFuncPara.ParaName);
clsCheckSql.CheckFieldNotNull(objWebSrvFuncParaEN.ParaCnName, conWebSrvFuncPara.ParaCnName);
//检查字段长度
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.WebSrvFuncParaId, 8, conWebSrvFuncPara.WebSrvFuncParaId);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.WebSrvFunctionId, 8, conWebSrvFuncPara.WebSrvFunctionId);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.DataTypeId, 2, conWebSrvFuncPara.DataTypeId);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.ParameterType, 100, conWebSrvFuncPara.ParameterType);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.ParameterTypeFullName, 500, conWebSrvFuncPara.ParameterTypeFullName);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.ParaName, 50, conWebSrvFuncPara.ParaName);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.ParaCnName, 50, conWebSrvFuncPara.ParaCnName);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.UpdDate, 20, conWebSrvFuncPara.UpdDate);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.UpdUser, 20, conWebSrvFuncPara.UpdUser);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.Memo, 1000, conWebSrvFuncPara.Memo);
//检查字段外键固定长度
 objWebSrvFuncParaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsWebSrvFuncParaEN objWebSrvFuncParaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.WebSrvFunctionId, 8, conWebSrvFuncPara.WebSrvFunctionId);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.DataTypeId, 2, conWebSrvFuncPara.DataTypeId);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.ParameterType, 100, conWebSrvFuncPara.ParameterType);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.ParameterTypeFullName, 500, conWebSrvFuncPara.ParameterTypeFullName);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.ParaName, 50, conWebSrvFuncPara.ParaName);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.ParaCnName, 50, conWebSrvFuncPara.ParaCnName);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.UpdDate, 20, conWebSrvFuncPara.UpdDate);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.UpdUser, 20, conWebSrvFuncPara.UpdUser);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.Memo, 1000, conWebSrvFuncPara.Memo);
//检查外键字段长度
 objWebSrvFuncParaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsWebSrvFuncParaEN objWebSrvFuncParaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.WebSrvFuncParaId, 8, conWebSrvFuncPara.WebSrvFuncParaId);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.WebSrvFunctionId, 8, conWebSrvFuncPara.WebSrvFunctionId);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.DataTypeId, 2, conWebSrvFuncPara.DataTypeId);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.ParameterType, 100, conWebSrvFuncPara.ParameterType);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.ParameterTypeFullName, 500, conWebSrvFuncPara.ParameterTypeFullName);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.ParaName, 50, conWebSrvFuncPara.ParaName);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.ParaCnName, 50, conWebSrvFuncPara.ParaCnName);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.UpdDate, 20, conWebSrvFuncPara.UpdDate);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.UpdUser, 20, conWebSrvFuncPara.UpdUser);
clsCheckSql.CheckFieldLen(objWebSrvFuncParaEN.Memo, 1000, conWebSrvFuncPara.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objWebSrvFuncParaEN.WebSrvFuncParaId, conWebSrvFuncPara.WebSrvFuncParaId);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFuncParaEN.WebSrvFunctionId, conWebSrvFuncPara.WebSrvFunctionId);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFuncParaEN.DataTypeId, conWebSrvFuncPara.DataTypeId);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFuncParaEN.ParameterType, conWebSrvFuncPara.ParameterType);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFuncParaEN.ParameterTypeFullName, conWebSrvFuncPara.ParameterTypeFullName);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFuncParaEN.ParaName, conWebSrvFuncPara.ParaName);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFuncParaEN.ParaCnName, conWebSrvFuncPara.ParaCnName);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFuncParaEN.UpdDate, conWebSrvFuncPara.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFuncParaEN.UpdUser, conWebSrvFuncPara.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFuncParaEN.Memo, conWebSrvFuncPara.Memo);
//检查外键字段长度
 objWebSrvFuncParaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--WebSrvFuncPara(WebSrv函数参数),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objWebSrvFuncParaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsWebSrvFuncParaEN objWebSrvFuncParaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and WebSrvFunctionId = '{0}'", objWebSrvFuncParaEN.WebSrvFunctionId);
 sbCondition.AppendFormat(" and ParaName = '{0}'", objWebSrvFuncParaEN.ParaName);
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
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
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
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
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
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsWebSrvFuncParaEN._CurrTabName);
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
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsWebSrvFuncParaEN._CurrTabName, strCondition);
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
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
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
 objSQL = clsWebSrvFuncParaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}