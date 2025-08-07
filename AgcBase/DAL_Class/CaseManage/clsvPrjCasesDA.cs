
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjCasesDA
 表名:vPrjCases(00050258)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:50
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:用例管理(CaseManage)
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
 /// v工程用例(vPrjCases)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPrjCasesDA : clsCommBase4DA
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
 return clsvPrjCasesEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPrjCasesEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjCasesEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPrjCasesEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPrjCasesEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCaseId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCaseId)
{
strCaseId = strCaseId.Replace("'", "''");
if (strCaseId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vPrjCases中,检查关键字,长度不正确!(clsvPrjCasesDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCaseId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vPrjCases中,关键字不能为空 或 null!(clsvPrjCasesDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCaseId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvPrjCasesDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPrjCasesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
strSQL = "Select * from vPrjCases where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPrjCases(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPrjCasesDA: GetDataTable_vPrjCases)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
strSQL = "Select * from vPrjCases where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPrjCasesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPrjCasesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
strSQL = "Select * from vPrjCases where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPrjCasesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPrjCasesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjCases where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjCases where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPrjCasesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPrjCases where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPrjCasesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjCases.* " + 
$"from vPrjCases " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjCases.CaseId not in " + 
$"(Select top {intTop_In} vPrjCases.CaseId from vPrjCases " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjCases where {1} and CaseId not in (Select top {2} CaseId from vPrjCases where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjCases where {1} and CaseId not in (Select top {3} CaseId from vPrjCases where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPrjCasesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjCases.* " + 
$"from vPrjCases " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjCases.CaseId not in " + 
$"(Select top {intTop_In} vPrjCases.CaseId from vPrjCases " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjCases where {1} and CaseId not in (Select top {2} CaseId from vPrjCases where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjCases where {1} and CaseId not in (Select top {3} CaseId from vPrjCases where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPrjCasesEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPrjCasesDA:GetObjLst)", objException.Message));
}
List<clsvPrjCasesEN> arrObjLst = new List<clsvPrjCasesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
strSQL = "Select * from vPrjCases where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjCasesEN objvPrjCasesEN = new clsvPrjCasesEN();
try
{
objvPrjCasesEN.CaseId = objRow[convPrjCases.CaseId].ToString().Trim(); //CaseId
objvPrjCasesEN.CaseName = objRow[convPrjCases.CaseName].ToString().Trim(); //CaseName
objvPrjCasesEN.PrjId = objRow[convPrjCases.PrjId].ToString().Trim(); //工程Id
objvPrjCasesEN.PrjName = objRow[convPrjCases.PrjName] == DBNull.Value ? null : objRow[convPrjCases.PrjName].ToString().Trim(); //工程名称
objvPrjCasesEN.CaseContent = objRow[convPrjCases.CaseContent].ToString().Trim(); //CaseContent
objvPrjCasesEN.CaseTypeId = objRow[convPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objvPrjCasesEN.CaseTypeName = objRow[convPrjCases.CaseTypeName] == DBNull.Value ? null : objRow[convPrjCases.CaseTypeName].ToString().Trim(); //案例类型名
objvPrjCasesEN.ImportLevelId = objRow[convPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objvPrjCasesEN.UserId = objRow[convPrjCases.UserId] == DBNull.Value ? null : objRow[convPrjCases.UserId].ToString().Trim(); //用户Id
objvPrjCasesEN.UpdDate = objRow[convPrjCases.UpdDate] == DBNull.Value ? null : objRow[convPrjCases.UpdDate].ToString().Trim(); //修改日期
objvPrjCasesEN.ImportLevelName = objRow[convPrjCases.ImportLevelName] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelName].ToString().Trim(); //重要程度名称
objvPrjCasesEN.Memo = objRow[convPrjCases.Memo] == DBNull.Value ? null : objRow[convPrjCases.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjCasesDA: GetObjLst)", objException.Message));
}
objvPrjCasesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjCasesEN);
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
public List<clsvPrjCasesEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPrjCasesDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPrjCasesEN> arrObjLst = new List<clsvPrjCasesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjCasesEN objvPrjCasesEN = new clsvPrjCasesEN();
try
{
objvPrjCasesEN.CaseId = objRow[convPrjCases.CaseId].ToString().Trim(); //CaseId
objvPrjCasesEN.CaseName = objRow[convPrjCases.CaseName].ToString().Trim(); //CaseName
objvPrjCasesEN.PrjId = objRow[convPrjCases.PrjId].ToString().Trim(); //工程Id
objvPrjCasesEN.PrjName = objRow[convPrjCases.PrjName] == DBNull.Value ? null : objRow[convPrjCases.PrjName].ToString().Trim(); //工程名称
objvPrjCasesEN.CaseContent = objRow[convPrjCases.CaseContent].ToString().Trim(); //CaseContent
objvPrjCasesEN.CaseTypeId = objRow[convPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objvPrjCasesEN.CaseTypeName = objRow[convPrjCases.CaseTypeName] == DBNull.Value ? null : objRow[convPrjCases.CaseTypeName].ToString().Trim(); //案例类型名
objvPrjCasesEN.ImportLevelId = objRow[convPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objvPrjCasesEN.UserId = objRow[convPrjCases.UserId] == DBNull.Value ? null : objRow[convPrjCases.UserId].ToString().Trim(); //用户Id
objvPrjCasesEN.UpdDate = objRow[convPrjCases.UpdDate] == DBNull.Value ? null : objRow[convPrjCases.UpdDate].ToString().Trim(); //修改日期
objvPrjCasesEN.ImportLevelName = objRow[convPrjCases.ImportLevelName] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelName].ToString().Trim(); //重要程度名称
objvPrjCasesEN.Memo = objRow[convPrjCases.Memo] == DBNull.Value ? null : objRow[convPrjCases.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjCasesDA: GetObjLst)", objException.Message));
}
objvPrjCasesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjCasesEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPrjCasesEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPrjCases(ref clsvPrjCasesEN objvPrjCasesEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
strSQL = "Select * from vPrjCases where CaseId = " + "'"+ objvPrjCasesEN.CaseId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPrjCasesEN.CaseId = objDT.Rows[0][convPrjCases.CaseId].ToString().Trim(); //CaseId(字段类型:varchar,字段长度:8,是否可空:False)
 objvPrjCasesEN.CaseName = objDT.Rows[0][convPrjCases.CaseName].ToString().Trim(); //CaseName(字段类型:varchar,字段长度:20,是否可空:False)
 objvPrjCasesEN.PrjId = objDT.Rows[0][convPrjCases.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjCasesEN.PrjName = objDT.Rows[0][convPrjCases.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjCasesEN.CaseContent = objDT.Rows[0][convPrjCases.CaseContent].ToString().Trim(); //CaseContent(字段类型:varchar,字段长度:1000,是否可空:False)
 objvPrjCasesEN.CaseTypeId = objDT.Rows[0][convPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId(字段类型:varchar,字段长度:4,是否可空:False)
 objvPrjCasesEN.CaseTypeName = objDT.Rows[0][convPrjCases.CaseTypeName].ToString().Trim(); //案例类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjCasesEN.ImportLevelId = objDT.Rows[0][convPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id(字段类型:varchar,字段长度:4,是否可空:False)
 objvPrjCasesEN.UserId = objDT.Rows[0][convPrjCases.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvPrjCasesEN.UpdDate = objDT.Rows[0][convPrjCases.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjCasesEN.ImportLevelName = objDT.Rows[0][convPrjCases.ImportLevelName].ToString().Trim(); //重要程度名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvPrjCasesEN.Memo = objDT.Rows[0][convPrjCases.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPrjCasesDA: GetvPrjCases)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCaseId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPrjCasesEN GetObjByCaseId(string strCaseId)
{
CheckPrimaryKey(strCaseId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
strSQL = "Select * from vPrjCases where CaseId = " + "'"+ strCaseId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPrjCasesEN objvPrjCasesEN = new clsvPrjCasesEN();
try
{
 objvPrjCasesEN.CaseId = objRow[convPrjCases.CaseId].ToString().Trim(); //CaseId(字段类型:varchar,字段长度:8,是否可空:False)
 objvPrjCasesEN.CaseName = objRow[convPrjCases.CaseName].ToString().Trim(); //CaseName(字段类型:varchar,字段长度:20,是否可空:False)
 objvPrjCasesEN.PrjId = objRow[convPrjCases.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjCasesEN.PrjName = objRow[convPrjCases.PrjName] == DBNull.Value ? null : objRow[convPrjCases.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjCasesEN.CaseContent = objRow[convPrjCases.CaseContent].ToString().Trim(); //CaseContent(字段类型:varchar,字段长度:1000,是否可空:False)
 objvPrjCasesEN.CaseTypeId = objRow[convPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId(字段类型:varchar,字段长度:4,是否可空:False)
 objvPrjCasesEN.CaseTypeName = objRow[convPrjCases.CaseTypeName] == DBNull.Value ? null : objRow[convPrjCases.CaseTypeName].ToString().Trim(); //案例类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjCasesEN.ImportLevelId = objRow[convPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id(字段类型:varchar,字段长度:4,是否可空:False)
 objvPrjCasesEN.UserId = objRow[convPrjCases.UserId] == DBNull.Value ? null : objRow[convPrjCases.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvPrjCasesEN.UpdDate = objRow[convPrjCases.UpdDate] == DBNull.Value ? null : objRow[convPrjCases.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjCasesEN.ImportLevelName = objRow[convPrjCases.ImportLevelName] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelName].ToString().Trim(); //重要程度名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvPrjCasesEN.Memo = objRow[convPrjCases.Memo] == DBNull.Value ? null : objRow[convPrjCases.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPrjCasesDA: GetObjByCaseId)", objException.Message));
}
return objvPrjCasesEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPrjCasesEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPrjCasesDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
strSQL = "Select * from vPrjCases where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPrjCasesEN objvPrjCasesEN = new clsvPrjCasesEN()
{
CaseId = objRow[convPrjCases.CaseId].ToString().Trim(), //CaseId
CaseName = objRow[convPrjCases.CaseName].ToString().Trim(), //CaseName
PrjId = objRow[convPrjCases.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convPrjCases.PrjName] == DBNull.Value ? null : objRow[convPrjCases.PrjName].ToString().Trim(), //工程名称
CaseContent = objRow[convPrjCases.CaseContent].ToString().Trim(), //CaseContent
CaseTypeId = objRow[convPrjCases.CaseTypeId].ToString().Trim(), //CaseTypeId
CaseTypeName = objRow[convPrjCases.CaseTypeName] == DBNull.Value ? null : objRow[convPrjCases.CaseTypeName].ToString().Trim(), //案例类型名
ImportLevelId = objRow[convPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelId].ToString().Trim(), //重要程度Id
UserId = objRow[convPrjCases.UserId] == DBNull.Value ? null : objRow[convPrjCases.UserId].ToString().Trim(), //用户Id
UpdDate = objRow[convPrjCases.UpdDate] == DBNull.Value ? null : objRow[convPrjCases.UpdDate].ToString().Trim(), //修改日期
ImportLevelName = objRow[convPrjCases.ImportLevelName] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelName].ToString().Trim(), //重要程度名称
Memo = objRow[convPrjCases.Memo] == DBNull.Value ? null : objRow[convPrjCases.Memo].ToString().Trim() //说明
};
objvPrjCasesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjCasesEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPrjCasesDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPrjCasesEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjCasesEN objvPrjCasesEN = new clsvPrjCasesEN();
try
{
objvPrjCasesEN.CaseId = objRow[convPrjCases.CaseId].ToString().Trim(); //CaseId
objvPrjCasesEN.CaseName = objRow[convPrjCases.CaseName].ToString().Trim(); //CaseName
objvPrjCasesEN.PrjId = objRow[convPrjCases.PrjId].ToString().Trim(); //工程Id
objvPrjCasesEN.PrjName = objRow[convPrjCases.PrjName] == DBNull.Value ? null : objRow[convPrjCases.PrjName].ToString().Trim(); //工程名称
objvPrjCasesEN.CaseContent = objRow[convPrjCases.CaseContent].ToString().Trim(); //CaseContent
objvPrjCasesEN.CaseTypeId = objRow[convPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objvPrjCasesEN.CaseTypeName = objRow[convPrjCases.CaseTypeName] == DBNull.Value ? null : objRow[convPrjCases.CaseTypeName].ToString().Trim(); //案例类型名
objvPrjCasesEN.ImportLevelId = objRow[convPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objvPrjCasesEN.UserId = objRow[convPrjCases.UserId] == DBNull.Value ? null : objRow[convPrjCases.UserId].ToString().Trim(); //用户Id
objvPrjCasesEN.UpdDate = objRow[convPrjCases.UpdDate] == DBNull.Value ? null : objRow[convPrjCases.UpdDate].ToString().Trim(); //修改日期
objvPrjCasesEN.ImportLevelName = objRow[convPrjCases.ImportLevelName] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelName].ToString().Trim(); //重要程度名称
objvPrjCasesEN.Memo = objRow[convPrjCases.Memo] == DBNull.Value ? null : objRow[convPrjCases.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPrjCasesDA: GetObjByDataRowvPrjCases)", objException.Message));
}
objvPrjCasesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjCasesEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPrjCasesEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjCasesEN objvPrjCasesEN = new clsvPrjCasesEN();
try
{
objvPrjCasesEN.CaseId = objRow[convPrjCases.CaseId].ToString().Trim(); //CaseId
objvPrjCasesEN.CaseName = objRow[convPrjCases.CaseName].ToString().Trim(); //CaseName
objvPrjCasesEN.PrjId = objRow[convPrjCases.PrjId].ToString().Trim(); //工程Id
objvPrjCasesEN.PrjName = objRow[convPrjCases.PrjName] == DBNull.Value ? null : objRow[convPrjCases.PrjName].ToString().Trim(); //工程名称
objvPrjCasesEN.CaseContent = objRow[convPrjCases.CaseContent].ToString().Trim(); //CaseContent
objvPrjCasesEN.CaseTypeId = objRow[convPrjCases.CaseTypeId].ToString().Trim(); //CaseTypeId
objvPrjCasesEN.CaseTypeName = objRow[convPrjCases.CaseTypeName] == DBNull.Value ? null : objRow[convPrjCases.CaseTypeName].ToString().Trim(); //案例类型名
objvPrjCasesEN.ImportLevelId = objRow[convPrjCases.ImportLevelId] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelId].ToString().Trim(); //重要程度Id
objvPrjCasesEN.UserId = objRow[convPrjCases.UserId] == DBNull.Value ? null : objRow[convPrjCases.UserId].ToString().Trim(); //用户Id
objvPrjCasesEN.UpdDate = objRow[convPrjCases.UpdDate] == DBNull.Value ? null : objRow[convPrjCases.UpdDate].ToString().Trim(); //修改日期
objvPrjCasesEN.ImportLevelName = objRow[convPrjCases.ImportLevelName] == DBNull.Value ? null : objRow[convPrjCases.ImportLevelName].ToString().Trim(); //重要程度名称
objvPrjCasesEN.Memo = objRow[convPrjCases.Memo] == DBNull.Value ? null : objRow[convPrjCases.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPrjCasesDA: GetObjByDataRow)", objException.Message));
}
objvPrjCasesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjCasesEN;
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
objSQL = clsvPrjCasesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjCasesEN._CurrTabName, convPrjCases.CaseId, 8, "");
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
objSQL = clsvPrjCasesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjCasesEN._CurrTabName, convPrjCases.CaseId, 8, strPrefix);
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
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CaseId from vPrjCases where " + strCondition;
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
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CaseId from vPrjCases where " + strCondition;
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
 /// <param name = "strCaseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCaseId)
{
CheckPrimaryKey(strCaseId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjCases", "CaseId = " + "'"+ strCaseId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPrjCasesDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjCases", strCondition))
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
objSQL = clsvPrjCasesDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPrjCases");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPrjCasesENS">源对象</param>
 /// <param name = "objvPrjCasesENT">目标对象</param>
public void CopyTo(clsvPrjCasesEN objvPrjCasesENS, clsvPrjCasesEN objvPrjCasesENT)
{
objvPrjCasesENT.CaseId = objvPrjCasesENS.CaseId; //CaseId
objvPrjCasesENT.CaseName = objvPrjCasesENS.CaseName; //CaseName
objvPrjCasesENT.PrjId = objvPrjCasesENS.PrjId; //工程Id
objvPrjCasesENT.PrjName = objvPrjCasesENS.PrjName; //工程名称
objvPrjCasesENT.CaseContent = objvPrjCasesENS.CaseContent; //CaseContent
objvPrjCasesENT.CaseTypeId = objvPrjCasesENS.CaseTypeId; //CaseTypeId
objvPrjCasesENT.CaseTypeName = objvPrjCasesENS.CaseTypeName; //案例类型名
objvPrjCasesENT.ImportLevelId = objvPrjCasesENS.ImportLevelId; //重要程度Id
objvPrjCasesENT.UserId = objvPrjCasesENS.UserId; //用户Id
objvPrjCasesENT.UpdDate = objvPrjCasesENS.UpdDate; //修改日期
objvPrjCasesENT.ImportLevelName = objvPrjCasesENS.ImportLevelName; //重要程度名称
objvPrjCasesENT.Memo = objvPrjCasesENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPrjCasesEN objvPrjCasesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPrjCasesEN.CaseId, 8, convPrjCases.CaseId);
clsCheckSql.CheckFieldLen(objvPrjCasesEN.CaseName, 20, convPrjCases.CaseName);
clsCheckSql.CheckFieldLen(objvPrjCasesEN.PrjId, 4, convPrjCases.PrjId);
clsCheckSql.CheckFieldLen(objvPrjCasesEN.PrjName, 30, convPrjCases.PrjName);
clsCheckSql.CheckFieldLen(objvPrjCasesEN.CaseContent, 1000, convPrjCases.CaseContent);
clsCheckSql.CheckFieldLen(objvPrjCasesEN.CaseTypeId, 4, convPrjCases.CaseTypeId);
clsCheckSql.CheckFieldLen(objvPrjCasesEN.CaseTypeName, 30, convPrjCases.CaseTypeName);
clsCheckSql.CheckFieldLen(objvPrjCasesEN.ImportLevelId, 4, convPrjCases.ImportLevelId);
clsCheckSql.CheckFieldLen(objvPrjCasesEN.UserId, 18, convPrjCases.UserId);
clsCheckSql.CheckFieldLen(objvPrjCasesEN.UpdDate, 20, convPrjCases.UpdDate);
clsCheckSql.CheckFieldLen(objvPrjCasesEN.ImportLevelName, 20, convPrjCases.ImportLevelName);
clsCheckSql.CheckFieldLen(objvPrjCasesEN.Memo, 1000, convPrjCases.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPrjCasesEN.CaseId, convPrjCases.CaseId);
clsCheckSql.CheckSqlInjection4Field(objvPrjCasesEN.CaseName, convPrjCases.CaseName);
clsCheckSql.CheckSqlInjection4Field(objvPrjCasesEN.PrjId, convPrjCases.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvPrjCasesEN.PrjName, convPrjCases.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvPrjCasesEN.CaseContent, convPrjCases.CaseContent);
clsCheckSql.CheckSqlInjection4Field(objvPrjCasesEN.CaseTypeId, convPrjCases.CaseTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjCasesEN.CaseTypeName, convPrjCases.CaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjCasesEN.ImportLevelId, convPrjCases.ImportLevelId);
clsCheckSql.CheckSqlInjection4Field(objvPrjCasesEN.UserId, convPrjCases.UserId);
clsCheckSql.CheckSqlInjection4Field(objvPrjCasesEN.UpdDate, convPrjCases.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvPrjCasesEN.ImportLevelName, convPrjCases.ImportLevelName);
clsCheckSql.CheckSqlInjection4Field(objvPrjCasesEN.Memo, convPrjCases.Memo);
//检查外键字段长度
 objvPrjCasesEN._IsCheckProperty = true;
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
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
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
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
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
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjCasesEN._CurrTabName);
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
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjCasesEN._CurrTabName, strCondition);
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
 objSQL = clsvPrjCasesDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}