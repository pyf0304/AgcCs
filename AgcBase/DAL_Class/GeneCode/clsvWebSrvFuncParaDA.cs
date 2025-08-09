
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWebSrvFuncParaDA
 表名:vWebSrvFuncPara(00050348)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:52
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
 /// vWebSrv函数参数(vWebSrvFuncPara)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvWebSrvFuncParaDA : clsCommBase4DA
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
 return clsvWebSrvFuncParaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvWebSrvFuncParaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvWebSrvFuncParaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvWebSrvFuncParaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvWebSrvFuncParaEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vWebSrvFuncPara中,检查关键字,长度不正确!(clsvWebSrvFuncParaDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strWebSrvFuncParaId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vWebSrvFuncPara中,关键字不能为空 或 null!(clsvWebSrvFuncParaDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWebSrvFuncParaId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvWebSrvFuncParaDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvWebSrvFuncParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvFuncPara where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vWebSrvFuncPara(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvWebSrvFuncParaDA: GetDataTable_vWebSrvFuncPara)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvFuncPara where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvWebSrvFuncParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvWebSrvFuncParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvFuncPara where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvWebSrvFuncParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvWebSrvFuncParaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvFuncPara where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvFuncPara where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvWebSrvFuncParaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vWebSrvFuncPara where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvWebSrvFuncParaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vWebSrvFuncPara.* " + 
$"from vWebSrvFuncPara " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vWebSrvFuncPara.WebSrvFuncParaId not in " + 
$"(Select top {intTop_In} vWebSrvFuncPara.WebSrvFuncParaId from vWebSrvFuncPara " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvFuncPara where {1} and WebSrvFuncParaId not in (Select top {2} WebSrvFuncParaId from vWebSrvFuncPara where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvFuncPara where {1} and WebSrvFuncParaId not in (Select top {3} WebSrvFuncParaId from vWebSrvFuncPara where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvWebSrvFuncParaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vWebSrvFuncPara.* " + 
$"from vWebSrvFuncPara " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vWebSrvFuncPara.WebSrvFuncParaId not in " + 
$"(Select top {intTop_In} vWebSrvFuncPara.WebSrvFuncParaId from vWebSrvFuncPara " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvFuncPara where {1} and WebSrvFuncParaId not in (Select top {2} WebSrvFuncParaId from vWebSrvFuncPara where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvFuncPara where {1} and WebSrvFuncParaId not in (Select top {3} WebSrvFuncParaId from vWebSrvFuncPara where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvWebSrvFuncParaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvWebSrvFuncParaDA:GetObjLst)", objException.Message));
}
List<clsvWebSrvFuncParaEN> arrObjLst = new List<clsvWebSrvFuncParaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvFuncPara where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = new clsvWebSrvFuncParaEN();
try
{
objvWebSrvFuncParaEN.WebSrvFuncParaId = objRow[convWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objvWebSrvFuncParaEN.WebSrvFunctionId = objRow[convWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFuncParaEN.WebSrvClassId = objRow[convWebSrvFuncPara.WebSrvClassId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFuncParaEN.FuncModuleAgcId = objRow[convWebSrvFuncPara.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFuncParaEN.PrjId = objRow[convWebSrvFuncPara.PrjId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.PrjId].ToString().Trim(); //工程Id
objvWebSrvFuncParaEN.FunctionName = objRow[convWebSrvFuncPara.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFuncParaEN.FunctionSignature = objRow[convWebSrvFuncPara.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFuncParaEN.IsAsyncFunc = TransNullToBool(objRow[convWebSrvFuncPara.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFuncParaEN.IsGeneCode = TransNullToBool(objRow[convWebSrvFuncPara.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFuncParaEN.DataTypeId = objRow[convWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvWebSrvFuncParaEN.DataTypeName = objRow[convWebSrvFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFuncParaEN.DataCnName = objRow[convWebSrvFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvWebSrvFuncParaEN.CsType = objRow[convWebSrvFuncPara.CsType].ToString().Trim(); //CS类型
objvWebSrvFuncParaEN.JavaType = objRow[convWebSrvFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFuncParaEN.JavaObjType = objRow[convWebSrvFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFuncParaEN.SwiftType = objRow[convWebSrvFuncPara.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFuncParaEN.IsNeedQuote = TransNullToBool(objRow[convWebSrvFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFuncParaEN.OraDbType = objRow[convWebSrvFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvWebSrvFuncParaEN.MySqlType = objRow[convWebSrvFuncPara.MySqlType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvWebSrvFuncParaEN.ParameterType = objRow[convWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objvWebSrvFuncParaEN.ParameterTypeFullName = objRow[convWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvWebSrvFuncParaEN.IsByRef = TransNullToBool(objRow[convWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvWebSrvFuncParaEN.ParaName = objRow[convWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objvWebSrvFuncParaEN.ParaCnName = objRow[convWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvWebSrvFuncParaEN.IsKnownType = TransNullToBool(objRow[convWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFuncParaEN.UpdDate = objRow[convWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFuncParaEN.UpdUser = objRow[convWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objvWebSrvFuncParaEN.Memo = objRow[convWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[convWebSrvFuncPara.Memo].ToString().Trim(); //说明
objvWebSrvFuncParaEN.ClsName = objRow[convWebSrvFuncPara.ClsName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvWebSrvFuncParaDA: GetObjLst)", objException.Message));
}
objvWebSrvFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvWebSrvFuncParaEN);
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
public List<clsvWebSrvFuncParaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvWebSrvFuncParaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvWebSrvFuncParaEN> arrObjLst = new List<clsvWebSrvFuncParaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = new clsvWebSrvFuncParaEN();
try
{
objvWebSrvFuncParaEN.WebSrvFuncParaId = objRow[convWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objvWebSrvFuncParaEN.WebSrvFunctionId = objRow[convWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFuncParaEN.WebSrvClassId = objRow[convWebSrvFuncPara.WebSrvClassId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFuncParaEN.FuncModuleAgcId = objRow[convWebSrvFuncPara.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFuncParaEN.PrjId = objRow[convWebSrvFuncPara.PrjId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.PrjId].ToString().Trim(); //工程Id
objvWebSrvFuncParaEN.FunctionName = objRow[convWebSrvFuncPara.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFuncParaEN.FunctionSignature = objRow[convWebSrvFuncPara.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFuncParaEN.IsAsyncFunc = TransNullToBool(objRow[convWebSrvFuncPara.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFuncParaEN.IsGeneCode = TransNullToBool(objRow[convWebSrvFuncPara.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFuncParaEN.DataTypeId = objRow[convWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvWebSrvFuncParaEN.DataTypeName = objRow[convWebSrvFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFuncParaEN.DataCnName = objRow[convWebSrvFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvWebSrvFuncParaEN.CsType = objRow[convWebSrvFuncPara.CsType].ToString().Trim(); //CS类型
objvWebSrvFuncParaEN.JavaType = objRow[convWebSrvFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFuncParaEN.JavaObjType = objRow[convWebSrvFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFuncParaEN.SwiftType = objRow[convWebSrvFuncPara.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFuncParaEN.IsNeedQuote = TransNullToBool(objRow[convWebSrvFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFuncParaEN.OraDbType = objRow[convWebSrvFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvWebSrvFuncParaEN.MySqlType = objRow[convWebSrvFuncPara.MySqlType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvWebSrvFuncParaEN.ParameterType = objRow[convWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objvWebSrvFuncParaEN.ParameterTypeFullName = objRow[convWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvWebSrvFuncParaEN.IsByRef = TransNullToBool(objRow[convWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvWebSrvFuncParaEN.ParaName = objRow[convWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objvWebSrvFuncParaEN.ParaCnName = objRow[convWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvWebSrvFuncParaEN.IsKnownType = TransNullToBool(objRow[convWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFuncParaEN.UpdDate = objRow[convWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFuncParaEN.UpdUser = objRow[convWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objvWebSrvFuncParaEN.Memo = objRow[convWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[convWebSrvFuncPara.Memo].ToString().Trim(); //说明
objvWebSrvFuncParaEN.ClsName = objRow[convWebSrvFuncPara.ClsName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvWebSrvFuncParaDA: GetObjLst)", objException.Message));
}
objvWebSrvFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvWebSrvFuncParaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvWebSrvFuncPara(ref clsvWebSrvFuncParaEN objvWebSrvFuncParaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvFuncPara where WebSrvFuncParaId = " + "'"+ objvWebSrvFuncParaEN.WebSrvFuncParaId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvWebSrvFuncParaEN.WebSrvFuncParaId = objDT.Rows[0][convWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvFuncParaEN.WebSrvFunctionId = objDT.Rows[0][convWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvFuncParaEN.WebSrvClassId = objDT.Rows[0][convWebSrvFuncPara.WebSrvClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvFuncParaEN.FuncModuleAgcId = objDT.Rows[0][convWebSrvFuncPara.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvFuncParaEN.PrjId = objDT.Rows[0][convWebSrvFuncPara.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvWebSrvFuncParaEN.FunctionName = objDT.Rows[0][convWebSrvFuncPara.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvWebSrvFuncParaEN.FunctionSignature = objDT.Rows[0][convWebSrvFuncPara.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvWebSrvFuncParaEN.IsAsyncFunc = TransNullToBool(objDT.Rows[0][convWebSrvFuncPara.IsAsyncFunc].ToString().Trim()); //是否异步函数(字段类型:bit,字段长度:1,是否可空:True)
 objvWebSrvFuncParaEN.IsGeneCode = TransNullToBool(objDT.Rows[0][convWebSrvFuncPara.IsGeneCode].ToString().Trim()); //是否生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objvWebSrvFuncParaEN.DataTypeId = objDT.Rows[0][convWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvWebSrvFuncParaEN.DataTypeName = objDT.Rows[0][convWebSrvFuncPara.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvFuncParaEN.DataCnName = objDT.Rows[0][convWebSrvFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvWebSrvFuncParaEN.CsType = objDT.Rows[0][convWebSrvFuncPara.CsType].ToString().Trim(); //CS类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvWebSrvFuncParaEN.JavaType = objDT.Rows[0][convWebSrvFuncPara.JavaType].ToString().Trim(); //JAVA类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvWebSrvFuncParaEN.JavaObjType = objDT.Rows[0][convWebSrvFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvFuncParaEN.SwiftType = objDT.Rows[0][convWebSrvFuncPara.SwiftType].ToString().Trim(); //SwiftType(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvFuncParaEN.IsNeedQuote = TransNullToBool(objDT.Rows[0][convWebSrvFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号(字段类型:bit,字段长度:1,是否可空:False)
 objvWebSrvFuncParaEN.OraDbType = objDT.Rows[0][convWebSrvFuncPara.OraDbType].ToString().Trim(); //Ora数据类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvWebSrvFuncParaEN.MySqlType = objDT.Rows[0][convWebSrvFuncPara.MySqlType].ToString().Trim(); //MySqlType(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvFuncParaEN.ParameterType = objDT.Rows[0][convWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvFuncParaEN.ParameterTypeFullName = objDT.Rows[0][convWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objvWebSrvFuncParaEN.IsByRef = TransNullToBool(objDT.Rows[0][convWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数(字段类型:bit,字段长度:1,是否可空:True)
 objvWebSrvFuncParaEN.ParaName = objDT.Rows[0][convWebSrvFuncPara.ParaName].ToString().Trim(); //参数名(字段类型:varchar,字段长度:50,是否可空:False)
 objvWebSrvFuncParaEN.ParaCnName = objDT.Rows[0][convWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvWebSrvFuncParaEN.IsKnownType = TransNullToBool(objDT.Rows[0][convWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型(字段类型:bit,字段长度:1,是否可空:True)
 objvWebSrvFuncParaEN.UpdDate = objDT.Rows[0][convWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvWebSrvFuncParaEN.UpdUser = objDT.Rows[0][convWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvWebSrvFuncParaEN.Memo = objDT.Rows[0][convWebSrvFuncPara.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvWebSrvFuncParaEN.ClsName = objDT.Rows[0][convWebSrvFuncPara.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvWebSrvFuncParaDA: GetvWebSrvFuncPara)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strWebSrvFuncParaId">表关键字</param>
 /// <returns>表对象</returns>
public clsvWebSrvFuncParaEN GetObjByWebSrvFuncParaId(string strWebSrvFuncParaId)
{
CheckPrimaryKey(strWebSrvFuncParaId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvFuncPara where WebSrvFuncParaId = " + "'"+ strWebSrvFuncParaId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = new clsvWebSrvFuncParaEN();
try
{
 objvWebSrvFuncParaEN.WebSrvFuncParaId = objRow[convWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvFuncParaEN.WebSrvFunctionId = objRow[convWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvFuncParaEN.WebSrvClassId = objRow[convWebSrvFuncPara.WebSrvClassId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.WebSrvClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvFuncParaEN.FuncModuleAgcId = objRow[convWebSrvFuncPara.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvFuncParaEN.PrjId = objRow[convWebSrvFuncPara.PrjId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvWebSrvFuncParaEN.FunctionName = objRow[convWebSrvFuncPara.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvWebSrvFuncParaEN.FunctionSignature = objRow[convWebSrvFuncPara.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvWebSrvFuncParaEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsAsyncFunc].ToString().Trim()); //是否异步函数(字段类型:bit,字段长度:1,是否可空:True)
 objvWebSrvFuncParaEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsGeneCode].ToString().Trim()); //是否生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objvWebSrvFuncParaEN.DataTypeId = objRow[convWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvWebSrvFuncParaEN.DataTypeName = objRow[convWebSrvFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvFuncParaEN.DataCnName = objRow[convWebSrvFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvWebSrvFuncParaEN.CsType = objRow[convWebSrvFuncPara.CsType].ToString().Trim(); //CS类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvWebSrvFuncParaEN.JavaType = objRow[convWebSrvFuncPara.JavaType].ToString().Trim(); //JAVA类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvWebSrvFuncParaEN.JavaObjType = objRow[convWebSrvFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvFuncParaEN.SwiftType = objRow[convWebSrvFuncPara.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.SwiftType].ToString().Trim(); //SwiftType(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvFuncParaEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号(字段类型:bit,字段长度:1,是否可空:False)
 objvWebSrvFuncParaEN.OraDbType = objRow[convWebSrvFuncPara.OraDbType].ToString().Trim(); //Ora数据类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvWebSrvFuncParaEN.MySqlType = objRow[convWebSrvFuncPara.MySqlType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.MySqlType].ToString().Trim(); //MySqlType(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvFuncParaEN.ParameterType = objRow[convWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvFuncParaEN.ParameterTypeFullName = objRow[convWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objvWebSrvFuncParaEN.IsByRef = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数(字段类型:bit,字段长度:1,是否可空:True)
 objvWebSrvFuncParaEN.ParaName = objRow[convWebSrvFuncPara.ParaName].ToString().Trim(); //参数名(字段类型:varchar,字段长度:50,是否可空:False)
 objvWebSrvFuncParaEN.ParaCnName = objRow[convWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名(字段类型:varchar,字段长度:50,是否可空:False)
 objvWebSrvFuncParaEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型(字段类型:bit,字段长度:1,是否可空:True)
 objvWebSrvFuncParaEN.UpdDate = objRow[convWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvWebSrvFuncParaEN.UpdUser = objRow[convWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvWebSrvFuncParaEN.Memo = objRow[convWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[convWebSrvFuncPara.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvWebSrvFuncParaEN.ClsName = objRow[convWebSrvFuncPara.ClsName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvWebSrvFuncParaDA: GetObjByWebSrvFuncParaId)", objException.Message));
}
return objvWebSrvFuncParaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvWebSrvFuncParaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvWebSrvFuncParaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvFuncPara where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = new clsvWebSrvFuncParaEN()
{
WebSrvFuncParaId = objRow[convWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(), //函数参数Id
WebSrvFunctionId = objRow[convWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(), //函数Id
WebSrvClassId = objRow[convWebSrvFuncPara.WebSrvClassId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.WebSrvClassId].ToString().Trim(), //类Id
FuncModuleAgcId = objRow[convWebSrvFuncPara.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FuncModuleAgcId].ToString().Trim(), //功能模块Id
PrjId = objRow[convWebSrvFuncPara.PrjId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.PrjId].ToString().Trim(), //工程Id
FunctionName = objRow[convWebSrvFuncPara.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FunctionName].ToString().Trim(), //功能名称
FunctionSignature = objRow[convWebSrvFuncPara.FunctionSignature].ToString().Trim(), //函数签名
IsAsyncFunc = TransNullToBool(objRow[convWebSrvFuncPara.IsAsyncFunc].ToString().Trim()), //是否异步函数
IsGeneCode = TransNullToBool(objRow[convWebSrvFuncPara.IsGeneCode].ToString().Trim()), //是否生成代码
DataTypeId = objRow[convWebSrvFuncPara.DataTypeId].ToString().Trim(), //数据类型Id
DataTypeName = objRow[convWebSrvFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.DataTypeName].ToString().Trim(), //数据类型名称
DataCnName = objRow[convWebSrvFuncPara.DataCnName].ToString().Trim(), //数据类型中文名称
CsType = objRow[convWebSrvFuncPara.CsType].ToString().Trim(), //CS类型
JavaType = objRow[convWebSrvFuncPara.JavaType].ToString().Trim(), //JAVA类型
JavaObjType = objRow[convWebSrvFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.JavaObjType].ToString().Trim(), //JAVA对象类型
SwiftType = objRow[convWebSrvFuncPara.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.SwiftType].ToString().Trim(), //SwiftType
IsNeedQuote = TransNullToBool(objRow[convWebSrvFuncPara.IsNeedQuote].ToString().Trim()), //是否需要引号
OraDbType = objRow[convWebSrvFuncPara.OraDbType].ToString().Trim(), //Ora数据类型
MySqlType = objRow[convWebSrvFuncPara.MySqlType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.MySqlType].ToString().Trim(), //MySqlType
ParameterType = objRow[convWebSrvFuncPara.ParameterType].ToString().Trim(), //参数类型
ParameterTypeFullName = objRow[convWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(), //参数类型全名
IsByRef = TransNullToBool(objRow[convWebSrvFuncPara.IsByRef].ToString().Trim()), //是否引用型参数
ParaName = objRow[convWebSrvFuncPara.ParaName].ToString().Trim(), //参数名
ParaCnName = objRow[convWebSrvFuncPara.ParaCnName].ToString().Trim(), //参数中文名
IsKnownType = TransNullToBool(objRow[convWebSrvFuncPara.IsKnownType].ToString().Trim()), //是否已知类型
UpdDate = objRow[convWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[convWebSrvFuncPara.Memo].ToString().Trim(), //说明
ClsName = objRow[convWebSrvFuncPara.ClsName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ClsName].ToString().Trim() //类名
};
objvWebSrvFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWebSrvFuncParaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvWebSrvFuncParaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvWebSrvFuncParaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = new clsvWebSrvFuncParaEN();
try
{
objvWebSrvFuncParaEN.WebSrvFuncParaId = objRow[convWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objvWebSrvFuncParaEN.WebSrvFunctionId = objRow[convWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFuncParaEN.WebSrvClassId = objRow[convWebSrvFuncPara.WebSrvClassId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFuncParaEN.FuncModuleAgcId = objRow[convWebSrvFuncPara.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFuncParaEN.PrjId = objRow[convWebSrvFuncPara.PrjId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.PrjId].ToString().Trim(); //工程Id
objvWebSrvFuncParaEN.FunctionName = objRow[convWebSrvFuncPara.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFuncParaEN.FunctionSignature = objRow[convWebSrvFuncPara.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFuncParaEN.IsAsyncFunc = TransNullToBool(objRow[convWebSrvFuncPara.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFuncParaEN.IsGeneCode = TransNullToBool(objRow[convWebSrvFuncPara.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFuncParaEN.DataTypeId = objRow[convWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvWebSrvFuncParaEN.DataTypeName = objRow[convWebSrvFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFuncParaEN.DataCnName = objRow[convWebSrvFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvWebSrvFuncParaEN.CsType = objRow[convWebSrvFuncPara.CsType].ToString().Trim(); //CS类型
objvWebSrvFuncParaEN.JavaType = objRow[convWebSrvFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFuncParaEN.JavaObjType = objRow[convWebSrvFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFuncParaEN.SwiftType = objRow[convWebSrvFuncPara.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFuncParaEN.IsNeedQuote = TransNullToBool(objRow[convWebSrvFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFuncParaEN.OraDbType = objRow[convWebSrvFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvWebSrvFuncParaEN.MySqlType = objRow[convWebSrvFuncPara.MySqlType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvWebSrvFuncParaEN.ParameterType = objRow[convWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objvWebSrvFuncParaEN.ParameterTypeFullName = objRow[convWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvWebSrvFuncParaEN.IsByRef = TransNullToBool(objRow[convWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvWebSrvFuncParaEN.ParaName = objRow[convWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objvWebSrvFuncParaEN.ParaCnName = objRow[convWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvWebSrvFuncParaEN.IsKnownType = TransNullToBool(objRow[convWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFuncParaEN.UpdDate = objRow[convWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFuncParaEN.UpdUser = objRow[convWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objvWebSrvFuncParaEN.Memo = objRow[convWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[convWebSrvFuncPara.Memo].ToString().Trim(); //说明
objvWebSrvFuncParaEN.ClsName = objRow[convWebSrvFuncPara.ClsName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvWebSrvFuncParaDA: GetObjByDataRowvWebSrvFuncPara)", objException.Message));
}
objvWebSrvFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWebSrvFuncParaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvWebSrvFuncParaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvWebSrvFuncParaEN objvWebSrvFuncParaEN = new clsvWebSrvFuncParaEN();
try
{
objvWebSrvFuncParaEN.WebSrvFuncParaId = objRow[convWebSrvFuncPara.WebSrvFuncParaId].ToString().Trim(); //函数参数Id
objvWebSrvFuncParaEN.WebSrvFunctionId = objRow[convWebSrvFuncPara.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFuncParaEN.WebSrvClassId = objRow[convWebSrvFuncPara.WebSrvClassId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFuncParaEN.FuncModuleAgcId = objRow[convWebSrvFuncPara.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFuncParaEN.PrjId = objRow[convWebSrvFuncPara.PrjId] == DBNull.Value ? null : objRow[convWebSrvFuncPara.PrjId].ToString().Trim(); //工程Id
objvWebSrvFuncParaEN.FunctionName = objRow[convWebSrvFuncPara.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFuncParaEN.FunctionSignature = objRow[convWebSrvFuncPara.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFuncParaEN.IsAsyncFunc = TransNullToBool(objRow[convWebSrvFuncPara.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFuncParaEN.IsGeneCode = TransNullToBool(objRow[convWebSrvFuncPara.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFuncParaEN.DataTypeId = objRow[convWebSrvFuncPara.DataTypeId].ToString().Trim(); //数据类型Id
objvWebSrvFuncParaEN.DataTypeName = objRow[convWebSrvFuncPara.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFuncParaEN.DataCnName = objRow[convWebSrvFuncPara.DataCnName].ToString().Trim(); //数据类型中文名称
objvWebSrvFuncParaEN.CsType = objRow[convWebSrvFuncPara.CsType].ToString().Trim(); //CS类型
objvWebSrvFuncParaEN.JavaType = objRow[convWebSrvFuncPara.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFuncParaEN.JavaObjType = objRow[convWebSrvFuncPara.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFuncParaEN.SwiftType = objRow[convWebSrvFuncPara.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFuncParaEN.IsNeedQuote = TransNullToBool(objRow[convWebSrvFuncPara.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFuncParaEN.OraDbType = objRow[convWebSrvFuncPara.OraDbType].ToString().Trim(); //Ora数据类型
objvWebSrvFuncParaEN.MySqlType = objRow[convWebSrvFuncPara.MySqlType] == DBNull.Value ? null : objRow[convWebSrvFuncPara.MySqlType].ToString().Trim(); //MySqlType
objvWebSrvFuncParaEN.ParameterType = objRow[convWebSrvFuncPara.ParameterType].ToString().Trim(); //参数类型
objvWebSrvFuncParaEN.ParameterTypeFullName = objRow[convWebSrvFuncPara.ParameterTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ParameterTypeFullName].ToString().Trim(); //参数类型全名
objvWebSrvFuncParaEN.IsByRef = TransNullToBool(objRow[convWebSrvFuncPara.IsByRef].ToString().Trim()); //是否引用型参数
objvWebSrvFuncParaEN.ParaName = objRow[convWebSrvFuncPara.ParaName].ToString().Trim(); //参数名
objvWebSrvFuncParaEN.ParaCnName = objRow[convWebSrvFuncPara.ParaCnName].ToString().Trim(); //参数中文名
objvWebSrvFuncParaEN.IsKnownType = TransNullToBool(objRow[convWebSrvFuncPara.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFuncParaEN.UpdDate = objRow[convWebSrvFuncPara.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFuncParaEN.UpdUser = objRow[convWebSrvFuncPara.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFuncPara.UpdUser].ToString().Trim(); //修改者
objvWebSrvFuncParaEN.Memo = objRow[convWebSrvFuncPara.Memo] == DBNull.Value ? null : objRow[convWebSrvFuncPara.Memo].ToString().Trim(); //说明
objvWebSrvFuncParaEN.ClsName = objRow[convWebSrvFuncPara.ClsName] == DBNull.Value ? null : objRow[convWebSrvFuncPara.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvWebSrvFuncParaDA: GetObjByDataRow)", objException.Message));
}
objvWebSrvFuncParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWebSrvFuncParaEN;
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
objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvWebSrvFuncParaEN._CurrTabName, convWebSrvFuncPara.WebSrvFuncParaId, 8, "");
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
objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvWebSrvFuncParaEN._CurrTabName, convWebSrvFuncPara.WebSrvFuncParaId, 8, strPrefix);
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
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select WebSrvFuncParaId from vWebSrvFuncPara where " + strCondition;
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
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select WebSrvFuncParaId from vWebSrvFuncPara where " + strCondition;
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
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vWebSrvFuncPara", "WebSrvFuncParaId = " + "'"+ strWebSrvFuncParaId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvWebSrvFuncParaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vWebSrvFuncPara", strCondition))
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
objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vWebSrvFuncPara");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvWebSrvFuncParaENS">源对象</param>
 /// <param name = "objvWebSrvFuncParaENT">目标对象</param>
public void CopyTo(clsvWebSrvFuncParaEN objvWebSrvFuncParaENS, clsvWebSrvFuncParaEN objvWebSrvFuncParaENT)
{
objvWebSrvFuncParaENT.WebSrvFuncParaId = objvWebSrvFuncParaENS.WebSrvFuncParaId; //函数参数Id
objvWebSrvFuncParaENT.WebSrvFunctionId = objvWebSrvFuncParaENS.WebSrvFunctionId; //函数Id
objvWebSrvFuncParaENT.WebSrvClassId = objvWebSrvFuncParaENS.WebSrvClassId; //类Id
objvWebSrvFuncParaENT.FuncModuleAgcId = objvWebSrvFuncParaENS.FuncModuleAgcId; //功能模块Id
objvWebSrvFuncParaENT.PrjId = objvWebSrvFuncParaENS.PrjId; //工程Id
objvWebSrvFuncParaENT.FunctionName = objvWebSrvFuncParaENS.FunctionName; //功能名称
objvWebSrvFuncParaENT.FunctionSignature = objvWebSrvFuncParaENS.FunctionSignature; //函数签名
objvWebSrvFuncParaENT.IsAsyncFunc = objvWebSrvFuncParaENS.IsAsyncFunc; //是否异步函数
objvWebSrvFuncParaENT.IsGeneCode = objvWebSrvFuncParaENS.IsGeneCode; //是否生成代码
objvWebSrvFuncParaENT.DataTypeId = objvWebSrvFuncParaENS.DataTypeId; //数据类型Id
objvWebSrvFuncParaENT.DataTypeName = objvWebSrvFuncParaENS.DataTypeName; //数据类型名称
objvWebSrvFuncParaENT.DataCnName = objvWebSrvFuncParaENS.DataCnName; //数据类型中文名称
objvWebSrvFuncParaENT.CsType = objvWebSrvFuncParaENS.CsType; //CS类型
objvWebSrvFuncParaENT.JavaType = objvWebSrvFuncParaENS.JavaType; //JAVA类型
objvWebSrvFuncParaENT.JavaObjType = objvWebSrvFuncParaENS.JavaObjType; //JAVA对象类型
objvWebSrvFuncParaENT.SwiftType = objvWebSrvFuncParaENS.SwiftType; //SwiftType
objvWebSrvFuncParaENT.IsNeedQuote = objvWebSrvFuncParaENS.IsNeedQuote; //是否需要引号
objvWebSrvFuncParaENT.OraDbType = objvWebSrvFuncParaENS.OraDbType; //Ora数据类型
objvWebSrvFuncParaENT.MySqlType = objvWebSrvFuncParaENS.MySqlType; //MySqlType
objvWebSrvFuncParaENT.ParameterType = objvWebSrvFuncParaENS.ParameterType; //参数类型
objvWebSrvFuncParaENT.ParameterTypeFullName = objvWebSrvFuncParaENS.ParameterTypeFullName; //参数类型全名
objvWebSrvFuncParaENT.IsByRef = objvWebSrvFuncParaENS.IsByRef; //是否引用型参数
objvWebSrvFuncParaENT.ParaName = objvWebSrvFuncParaENS.ParaName; //参数名
objvWebSrvFuncParaENT.ParaCnName = objvWebSrvFuncParaENS.ParaCnName; //参数中文名
objvWebSrvFuncParaENT.IsKnownType = objvWebSrvFuncParaENS.IsKnownType; //是否已知类型
objvWebSrvFuncParaENT.UpdDate = objvWebSrvFuncParaENS.UpdDate; //修改日期
objvWebSrvFuncParaENT.UpdUser = objvWebSrvFuncParaENS.UpdUser; //修改者
objvWebSrvFuncParaENT.Memo = objvWebSrvFuncParaENS.Memo; //说明
objvWebSrvFuncParaENT.ClsName = objvWebSrvFuncParaENS.ClsName; //类名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvWebSrvFuncParaEN objvWebSrvFuncParaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.WebSrvFuncParaId, 8, convWebSrvFuncPara.WebSrvFuncParaId);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.WebSrvFunctionId, 8, convWebSrvFuncPara.WebSrvFunctionId);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.WebSrvClassId, 8, convWebSrvFuncPara.WebSrvClassId);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.FuncModuleAgcId, 8, convWebSrvFuncPara.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.PrjId, 4, convWebSrvFuncPara.PrjId);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.FunctionName, 200, convWebSrvFuncPara.FunctionName);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.FunctionSignature, 500, convWebSrvFuncPara.FunctionSignature);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.DataTypeId, 2, convWebSrvFuncPara.DataTypeId);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.DataTypeName, 100, convWebSrvFuncPara.DataTypeName);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.DataCnName, 100, convWebSrvFuncPara.DataCnName);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.CsType, 100, convWebSrvFuncPara.CsType);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.JavaType, 100, convWebSrvFuncPara.JavaType);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.JavaObjType, 100, convWebSrvFuncPara.JavaObjType);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.SwiftType, 100, convWebSrvFuncPara.SwiftType);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.OraDbType, 100, convWebSrvFuncPara.OraDbType);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.MySqlType, 100, convWebSrvFuncPara.MySqlType);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.ParameterType, 100, convWebSrvFuncPara.ParameterType);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.ParameterTypeFullName, 500, convWebSrvFuncPara.ParameterTypeFullName);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.ParaName, 50, convWebSrvFuncPara.ParaName);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.ParaCnName, 50, convWebSrvFuncPara.ParaCnName);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.UpdDate, 20, convWebSrvFuncPara.UpdDate);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.UpdUser, 20, convWebSrvFuncPara.UpdUser);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.Memo, 1000, convWebSrvFuncPara.Memo);
clsCheckSql.CheckFieldLen(objvWebSrvFuncParaEN.ClsName, 100, convWebSrvFuncPara.ClsName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.WebSrvFuncParaId, convWebSrvFuncPara.WebSrvFuncParaId);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.WebSrvFunctionId, convWebSrvFuncPara.WebSrvFunctionId);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.WebSrvClassId, convWebSrvFuncPara.WebSrvClassId);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.FuncModuleAgcId, convWebSrvFuncPara.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.PrjId, convWebSrvFuncPara.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.FunctionName, convWebSrvFuncPara.FunctionName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.FunctionSignature, convWebSrvFuncPara.FunctionSignature);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.DataTypeId, convWebSrvFuncPara.DataTypeId);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.DataTypeName, convWebSrvFuncPara.DataTypeName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.DataCnName, convWebSrvFuncPara.DataCnName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.CsType, convWebSrvFuncPara.CsType);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.JavaType, convWebSrvFuncPara.JavaType);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.JavaObjType, convWebSrvFuncPara.JavaObjType);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.SwiftType, convWebSrvFuncPara.SwiftType);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.OraDbType, convWebSrvFuncPara.OraDbType);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.MySqlType, convWebSrvFuncPara.MySqlType);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.ParameterType, convWebSrvFuncPara.ParameterType);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.ParameterTypeFullName, convWebSrvFuncPara.ParameterTypeFullName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.ParaName, convWebSrvFuncPara.ParaName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.ParaCnName, convWebSrvFuncPara.ParaCnName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.UpdDate, convWebSrvFuncPara.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.UpdUser, convWebSrvFuncPara.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.Memo, convWebSrvFuncPara.Memo);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFuncParaEN.ClsName, convWebSrvFuncPara.ClsName);
//检查外键字段长度
 objvWebSrvFuncParaEN._IsCheckProperty = true;
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
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
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
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
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
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvWebSrvFuncParaEN._CurrTabName);
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
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvWebSrvFuncParaEN._CurrTabName, strCondition);
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
 objSQL = clsvWebSrvFuncParaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}