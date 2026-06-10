
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCTCodeTypeGroupRelaDA
 表名:CTCodeTypeGroupRela(00050647)
 * 版本:2026.05.30(服务器:PYF-AI)
 日期:2026/06/07 13:58:55
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
 /// CTCodeTypeGroupRela(CTCodeTypeGroupRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCTCodeTypeGroupRelaDA : clsCommBase4DA
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
 return clsCTCodeTypeGroupRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCTCodeTypeGroupRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCTCodeTypeGroupRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCTCodeTypeGroupRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCTCodeTypeGroupRelaEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCtGroupId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCtGroupId)
{
strCtGroupId = strCtGroupId.Replace("'", "''");
if (strCtGroupId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:CTCodeTypeGroupRela中,检查关键字,长度不正确!(clsCTCodeTypeGroupRelaDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCtGroupId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CTCodeTypeGroupRela中,关键字不能为空 或 null!(clsCTCodeTypeGroupRelaDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCtGroupId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCTCodeTypeGroupRelaDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroupRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CTCodeTypeGroupRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupRelaDA: GetDataTable_CTCodeTypeGroupRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroupRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroupRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CTCodeTypeGroupRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CTCodeTypeGroupRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CTCodeTypeGroupRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCTCodeTypeGroupRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CTCodeTypeGroupRela.* " + 
$"from CTCodeTypeGroupRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CTCodeTypeGroupRela.CtGroupId not in " + 
$"(Select top {intTop_In} CTCodeTypeGroupRela.CtGroupId from CTCodeTypeGroupRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CTCodeTypeGroupRela where {1} and CtGroupId not in (Select top {2} CtGroupId from CTCodeTypeGroupRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CTCodeTypeGroupRela where {1} and CtGroupId not in (Select top {3} CtGroupId from CTCodeTypeGroupRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCTCodeTypeGroupRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CTCodeTypeGroupRela.* " + 
$"from CTCodeTypeGroupRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CTCodeTypeGroupRela.CtGroupId not in " + 
$"(Select top {intTop_In} CTCodeTypeGroupRela.CtGroupId from CTCodeTypeGroupRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CTCodeTypeGroupRela where {1} and CtGroupId not in (Select top {2} CtGroupId from CTCodeTypeGroupRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CTCodeTypeGroupRela where {1} and CtGroupId not in (Select top {3} CtGroupId from CTCodeTypeGroupRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCTCodeTypeGroupRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupRelaDA:GetObjLst)", objException.Message));
}
List<clsCTCodeTypeGroupRelaEN> arrObjLst = new List<clsCTCodeTypeGroupRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroupRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = new clsCTCodeTypeGroupRelaEN();
try
{
objCTCodeTypeGroupRelaEN.CtGroupId = objRow[conCTCodeTypeGroupRela.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupRelaEN.CodeTypeId = objRow[conCTCodeTypeGroupRela.CodeTypeId].ToString().Trim(); //代码类型Id
objCTCodeTypeGroupRelaEN.IsMainGroup = TransNullToBool(objRow[conCTCodeTypeGroupRela.IsMainGroup].ToString().Trim()); //IsMainGroup
objCTCodeTypeGroupRelaEN.OrderNum = objRow[conCTCodeTypeGroupRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupRelaEN.LayerNo = objRow[conCTCodeTypeGroupRela.LayerNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.LayerNo].ToString().Trim()); //LayerNo
objCTCodeTypeGroupRelaEN.PosX = objRow[conCTCodeTypeGroupRela.PosX] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosX].ToString().Trim()); //PosX
objCTCodeTypeGroupRelaEN.PosY = objRow[conCTCodeTypeGroupRela.PosY] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosY].ToString().Trim()); //PosY
objCTCodeTypeGroupRelaEN.PosXSmall = objRow[conCTCodeTypeGroupRela.PosXSmall] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosXSmall].ToString().Trim()); //PosXSmall
objCTCodeTypeGroupRelaEN.PosYSmall = objRow[conCTCodeTypeGroupRela.PosYSmall] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosYSmall].ToString().Trim()); //PosYSmall
objCTCodeTypeGroupRelaEN.PosXLarge = objRow[conCTCodeTypeGroupRela.PosXLarge] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosXLarge].ToString().Trim()); //PosXLarge
objCTCodeTypeGroupRelaEN.PosYLarge = objRow[conCTCodeTypeGroupRela.PosYLarge] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosYLarge].ToString().Trim()); //PosYLarge
objCTCodeTypeGroupRelaEN.LayoutVersion = TransNullToInt(objRow[conCTCodeTypeGroupRela.LayoutVersion].ToString().Trim()); //LayoutVersion
objCTCodeTypeGroupRelaEN.IsPinned = TransNullToBool(objRow[conCTCodeTypeGroupRela.IsPinned].ToString().Trim()); //IsPinned
objCTCodeTypeGroupRelaEN.LayoutUpdatedBy = objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy].ToString().Trim(); //LayoutUpdatedBy
objCTCodeTypeGroupRelaEN.LayoutUpdatedAt = objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt].ToString().Trim(); //LayoutUpdatedAt
objCTCodeTypeGroupRelaEN.UpdDate = objRow[conCTCodeTypeGroupRela.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupRelaEN.UpdUser = objRow[conCTCodeTypeGroupRela.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdUser].ToString().Trim(); //修改者
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCTCodeTypeGroupRelaDA: GetObjLst)", objException.Message));
}
objCTCodeTypeGroupRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCTCodeTypeGroupRelaEN);
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
public List<clsCTCodeTypeGroupRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsCTCodeTypeGroupRelaEN> arrObjLst = new List<clsCTCodeTypeGroupRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = new clsCTCodeTypeGroupRelaEN();
try
{
objCTCodeTypeGroupRelaEN.CtGroupId = objRow[conCTCodeTypeGroupRela.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupRelaEN.CodeTypeId = objRow[conCTCodeTypeGroupRela.CodeTypeId].ToString().Trim(); //代码类型Id
objCTCodeTypeGroupRelaEN.IsMainGroup = TransNullToBool(objRow[conCTCodeTypeGroupRela.IsMainGroup].ToString().Trim()); //IsMainGroup
objCTCodeTypeGroupRelaEN.OrderNum = objRow[conCTCodeTypeGroupRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupRelaEN.LayerNo = objRow[conCTCodeTypeGroupRela.LayerNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.LayerNo].ToString().Trim()); //LayerNo
objCTCodeTypeGroupRelaEN.PosX = objRow[conCTCodeTypeGroupRela.PosX] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosX].ToString().Trim()); //PosX
objCTCodeTypeGroupRelaEN.PosY = objRow[conCTCodeTypeGroupRela.PosY] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosY].ToString().Trim()); //PosY
objCTCodeTypeGroupRelaEN.PosXSmall = objRow[conCTCodeTypeGroupRela.PosXSmall] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosXSmall].ToString().Trim()); //PosXSmall
objCTCodeTypeGroupRelaEN.PosYSmall = objRow[conCTCodeTypeGroupRela.PosYSmall] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosYSmall].ToString().Trim()); //PosYSmall
objCTCodeTypeGroupRelaEN.PosXLarge = objRow[conCTCodeTypeGroupRela.PosXLarge] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosXLarge].ToString().Trim()); //PosXLarge
objCTCodeTypeGroupRelaEN.PosYLarge = objRow[conCTCodeTypeGroupRela.PosYLarge] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosYLarge].ToString().Trim()); //PosYLarge
objCTCodeTypeGroupRelaEN.LayoutVersion = TransNullToInt(objRow[conCTCodeTypeGroupRela.LayoutVersion].ToString().Trim()); //LayoutVersion
objCTCodeTypeGroupRelaEN.IsPinned = TransNullToBool(objRow[conCTCodeTypeGroupRela.IsPinned].ToString().Trim()); //IsPinned
objCTCodeTypeGroupRelaEN.LayoutUpdatedBy = objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy].ToString().Trim(); //LayoutUpdatedBy
objCTCodeTypeGroupRelaEN.LayoutUpdatedAt = objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt].ToString().Trim(); //LayoutUpdatedAt
objCTCodeTypeGroupRelaEN.UpdDate = objRow[conCTCodeTypeGroupRela.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupRelaEN.UpdUser = objRow[conCTCodeTypeGroupRela.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdUser].ToString().Trim(); //修改者
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCTCodeTypeGroupRelaDA: GetObjLst)", objException.Message));
}
objCTCodeTypeGroupRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCTCodeTypeGroupRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCTCodeTypeGroupRela(ref clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroupRela where CtGroupId = " + "'"+ objCTCodeTypeGroupRelaEN.CtGroupId+"'" + " and CodeTypeId = " + "'"+ objCTCodeTypeGroupRelaEN.CodeTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCTCodeTypeGroupRelaEN.CtGroupId = objDT.Rows[0][conCTCodeTypeGroupRela.CtGroupId].ToString().Trim(); //Ct组Id(字段类型:char,字段长度:4,是否可空:True)
 objCTCodeTypeGroupRelaEN.CodeTypeId = objDT.Rows[0][conCTCodeTypeGroupRela.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objCTCodeTypeGroupRelaEN.IsMainGroup = TransNullToBool(objDT.Rows[0][conCTCodeTypeGroupRela.IsMainGroup].ToString().Trim()); //IsMainGroup(字段类型:bit,字段长度:1,是否可空:True)
 objCTCodeTypeGroupRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][conCTCodeTypeGroupRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objCTCodeTypeGroupRelaEN.LayerNo = TransNullToInt(objDT.Rows[0][conCTCodeTypeGroupRela.LayerNo].ToString().Trim()); //LayerNo(字段类型:int,字段长度:4,是否可空:True)
 objCTCodeTypeGroupRelaEN.PosX = TransNullToInt(objDT.Rows[0][conCTCodeTypeGroupRela.PosX].ToString().Trim()); //PosX(字段类型:int,字段长度:4,是否可空:True)
 objCTCodeTypeGroupRelaEN.PosY = TransNullToInt(objDT.Rows[0][conCTCodeTypeGroupRela.PosY].ToString().Trim()); //PosY(字段类型:int,字段长度:4,是否可空:True)
 objCTCodeTypeGroupRelaEN.PosXSmall = TransNullToInt(objDT.Rows[0][conCTCodeTypeGroupRela.PosXSmall].ToString().Trim()); //PosXSmall(字段类型:int,字段长度:4,是否可空:True)
 objCTCodeTypeGroupRelaEN.PosYSmall = TransNullToInt(objDT.Rows[0][conCTCodeTypeGroupRela.PosYSmall].ToString().Trim()); //PosYSmall(字段类型:int,字段长度:4,是否可空:True)
 objCTCodeTypeGroupRelaEN.PosXLarge = TransNullToInt(objDT.Rows[0][conCTCodeTypeGroupRela.PosXLarge].ToString().Trim()); //PosXLarge(字段类型:int,字段长度:4,是否可空:True)
 objCTCodeTypeGroupRelaEN.PosYLarge = TransNullToInt(objDT.Rows[0][conCTCodeTypeGroupRela.PosYLarge].ToString().Trim()); //PosYLarge(字段类型:int,字段长度:4,是否可空:True)
 objCTCodeTypeGroupRelaEN.LayoutVersion = TransNullToInt(objDT.Rows[0][conCTCodeTypeGroupRela.LayoutVersion].ToString().Trim()); //LayoutVersion(字段类型:int,字段长度:4,是否可空:False)
 objCTCodeTypeGroupRelaEN.IsPinned = TransNullToBool(objDT.Rows[0][conCTCodeTypeGroupRela.IsPinned].ToString().Trim()); //IsPinned(字段类型:bit,字段长度:1,是否可空:False)
 objCTCodeTypeGroupRelaEN.LayoutUpdatedBy = objDT.Rows[0][conCTCodeTypeGroupRela.LayoutUpdatedBy].ToString().Trim(); //LayoutUpdatedBy(字段类型:nvarchar,字段长度:100,是否可空:True)
 objCTCodeTypeGroupRelaEN.LayoutUpdatedAt = objDT.Rows[0][conCTCodeTypeGroupRela.LayoutUpdatedAt].ToString().Trim(); //LayoutUpdatedAt(字段类型:varchar,字段长度:20,是否可空:True)
 objCTCodeTypeGroupRelaEN.UpdDate = objDT.Rows[0][conCTCodeTypeGroupRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCTCodeTypeGroupRelaEN.UpdUser = objDT.Rows[0][conCTCodeTypeGroupRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCTCodeTypeGroupRelaDA: GetCTCodeTypeGroupRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCtGroupId">表关键字</param>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsCTCodeTypeGroupRelaEN GetObjByKeyLst(string strCtGroupId,string strCodeTypeId)
{
CheckPrimaryKey(strCtGroupId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroupRela where CtGroupId = " + "'"+ strCtGroupId+"'" + " and CodeTypeId = " + "'"+ strCodeTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = new clsCTCodeTypeGroupRelaEN();
try
{
 objCTCodeTypeGroupRelaEN.CtGroupId = objRow[conCTCodeTypeGroupRela.CtGroupId].ToString().Trim(); //Ct组Id(字段类型:char,字段长度:4,是否可空:True)
 objCTCodeTypeGroupRelaEN.CodeTypeId = objRow[conCTCodeTypeGroupRela.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objCTCodeTypeGroupRelaEN.IsMainGroup = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsMainGroup].ToString().Trim()); //IsMainGroup(字段类型:bit,字段长度:1,是否可空:True)
 objCTCodeTypeGroupRelaEN.OrderNum = objRow[conCTCodeTypeGroupRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objCTCodeTypeGroupRelaEN.LayerNo = objRow[conCTCodeTypeGroupRela.LayerNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.LayerNo].ToString().Trim()); //LayerNo(字段类型:int,字段长度:4,是否可空:True)
 objCTCodeTypeGroupRelaEN.PosX = objRow[conCTCodeTypeGroupRela.PosX] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosX].ToString().Trim()); //PosX(字段类型:int,字段长度:4,是否可空:True)
 objCTCodeTypeGroupRelaEN.PosY = objRow[conCTCodeTypeGroupRela.PosY] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosY].ToString().Trim()); //PosY(字段类型:int,字段长度:4,是否可空:True)
 objCTCodeTypeGroupRelaEN.PosXSmall = objRow[conCTCodeTypeGroupRela.PosXSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXSmall].ToString().Trim()); //PosXSmall(字段类型:int,字段长度:4,是否可空:True)
 objCTCodeTypeGroupRelaEN.PosYSmall = objRow[conCTCodeTypeGroupRela.PosYSmall] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYSmall].ToString().Trim()); //PosYSmall(字段类型:int,字段长度:4,是否可空:True)
 objCTCodeTypeGroupRelaEN.PosXLarge = objRow[conCTCodeTypeGroupRela.PosXLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosXLarge].ToString().Trim()); //PosXLarge(字段类型:int,字段长度:4,是否可空:True)
 objCTCodeTypeGroupRelaEN.PosYLarge = objRow[conCTCodeTypeGroupRela.PosYLarge] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCTCodeTypeGroupRela.PosYLarge].ToString().Trim()); //PosYLarge(字段类型:int,字段长度:4,是否可空:True)
 objCTCodeTypeGroupRelaEN.LayoutVersion = Int32.Parse(objRow[conCTCodeTypeGroupRela.LayoutVersion].ToString().Trim()); //LayoutVersion(字段类型:int,字段长度:4,是否可空:False)
 objCTCodeTypeGroupRelaEN.IsPinned = clsEntityBase2.TransNullToBool_S(objRow[conCTCodeTypeGroupRela.IsPinned].ToString().Trim()); //IsPinned(字段类型:bit,字段长度:1,是否可空:False)
 objCTCodeTypeGroupRelaEN.LayoutUpdatedBy = objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy].ToString().Trim(); //LayoutUpdatedBy(字段类型:nvarchar,字段长度:100,是否可空:True)
 objCTCodeTypeGroupRelaEN.LayoutUpdatedAt = objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt].ToString().Trim(); //LayoutUpdatedAt(字段类型:varchar,字段长度:20,是否可空:True)
 objCTCodeTypeGroupRelaEN.UpdDate = objRow[conCTCodeTypeGroupRela.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCTCodeTypeGroupRelaEN.UpdUser = objRow[conCTCodeTypeGroupRela.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCTCodeTypeGroupRelaDA: GetObjByKeyLst)", objException.Message));
}
return objCTCodeTypeGroupRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCTCodeTypeGroupRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroupRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = new clsCTCodeTypeGroupRelaEN()
{
CtGroupId = objRow[conCTCodeTypeGroupRela.CtGroupId].ToString().Trim(), //Ct组Id
CodeTypeId = objRow[conCTCodeTypeGroupRela.CodeTypeId].ToString().Trim(), //代码类型Id
IsMainGroup = TransNullToBool(objRow[conCTCodeTypeGroupRela.IsMainGroup].ToString().Trim()), //IsMainGroup
OrderNum = objRow[conCTCodeTypeGroupRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.OrderNum].ToString().Trim()), //序号
LayerNo = objRow[conCTCodeTypeGroupRela.LayerNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.LayerNo].ToString().Trim()), //LayerNo
PosX = objRow[conCTCodeTypeGroupRela.PosX] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosX].ToString().Trim()), //PosX
PosY = objRow[conCTCodeTypeGroupRela.PosY] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosY].ToString().Trim()), //PosY
PosXSmall = objRow[conCTCodeTypeGroupRela.PosXSmall] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosXSmall].ToString().Trim()), //PosXSmall
PosYSmall = objRow[conCTCodeTypeGroupRela.PosYSmall] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosYSmall].ToString().Trim()), //PosYSmall
PosXLarge = objRow[conCTCodeTypeGroupRela.PosXLarge] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosXLarge].ToString().Trim()), //PosXLarge
PosYLarge = objRow[conCTCodeTypeGroupRela.PosYLarge] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosYLarge].ToString().Trim()), //PosYLarge
LayoutVersion = TransNullToInt(objRow[conCTCodeTypeGroupRela.LayoutVersion].ToString().Trim()), //LayoutVersion
IsPinned = TransNullToBool(objRow[conCTCodeTypeGroupRela.IsPinned].ToString().Trim()), //IsPinned
LayoutUpdatedBy = objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy].ToString().Trim(), //LayoutUpdatedBy
LayoutUpdatedAt = objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt].ToString().Trim(), //LayoutUpdatedAt
UpdDate = objRow[conCTCodeTypeGroupRela.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conCTCodeTypeGroupRela.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdUser].ToString().Trim() //修改者
};
objCTCodeTypeGroupRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCTCodeTypeGroupRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCTCodeTypeGroupRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCTCodeTypeGroupRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = new clsCTCodeTypeGroupRelaEN();
try
{
objCTCodeTypeGroupRelaEN.CtGroupId = objRow[conCTCodeTypeGroupRela.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupRelaEN.CodeTypeId = objRow[conCTCodeTypeGroupRela.CodeTypeId].ToString().Trim(); //代码类型Id
objCTCodeTypeGroupRelaEN.IsMainGroup = TransNullToBool(objRow[conCTCodeTypeGroupRela.IsMainGroup].ToString().Trim()); //IsMainGroup
objCTCodeTypeGroupRelaEN.OrderNum = objRow[conCTCodeTypeGroupRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupRelaEN.LayerNo = objRow[conCTCodeTypeGroupRela.LayerNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.LayerNo].ToString().Trim()); //LayerNo
objCTCodeTypeGroupRelaEN.PosX = objRow[conCTCodeTypeGroupRela.PosX] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosX].ToString().Trim()); //PosX
objCTCodeTypeGroupRelaEN.PosY = objRow[conCTCodeTypeGroupRela.PosY] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosY].ToString().Trim()); //PosY
objCTCodeTypeGroupRelaEN.PosXSmall = objRow[conCTCodeTypeGroupRela.PosXSmall] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosXSmall].ToString().Trim()); //PosXSmall
objCTCodeTypeGroupRelaEN.PosYSmall = objRow[conCTCodeTypeGroupRela.PosYSmall] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosYSmall].ToString().Trim()); //PosYSmall
objCTCodeTypeGroupRelaEN.PosXLarge = objRow[conCTCodeTypeGroupRela.PosXLarge] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosXLarge].ToString().Trim()); //PosXLarge
objCTCodeTypeGroupRelaEN.PosYLarge = objRow[conCTCodeTypeGroupRela.PosYLarge] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosYLarge].ToString().Trim()); //PosYLarge
objCTCodeTypeGroupRelaEN.LayoutVersion = TransNullToInt(objRow[conCTCodeTypeGroupRela.LayoutVersion].ToString().Trim()); //LayoutVersion
objCTCodeTypeGroupRelaEN.IsPinned = TransNullToBool(objRow[conCTCodeTypeGroupRela.IsPinned].ToString().Trim()); //IsPinned
objCTCodeTypeGroupRelaEN.LayoutUpdatedBy = objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy].ToString().Trim(); //LayoutUpdatedBy
objCTCodeTypeGroupRelaEN.LayoutUpdatedAt = objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt].ToString().Trim(); //LayoutUpdatedAt
objCTCodeTypeGroupRelaEN.UpdDate = objRow[conCTCodeTypeGroupRela.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupRelaEN.UpdUser = objRow[conCTCodeTypeGroupRela.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdUser].ToString().Trim(); //修改者
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCTCodeTypeGroupRelaDA: GetObjByDataRowCTCodeTypeGroupRela)", objException.Message));
}
objCTCodeTypeGroupRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCTCodeTypeGroupRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCTCodeTypeGroupRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN = new clsCTCodeTypeGroupRelaEN();
try
{
objCTCodeTypeGroupRelaEN.CtGroupId = objRow[conCTCodeTypeGroupRela.CtGroupId].ToString().Trim(); //Ct组Id
objCTCodeTypeGroupRelaEN.CodeTypeId = objRow[conCTCodeTypeGroupRela.CodeTypeId].ToString().Trim(); //代码类型Id
objCTCodeTypeGroupRelaEN.IsMainGroup = TransNullToBool(objRow[conCTCodeTypeGroupRela.IsMainGroup].ToString().Trim()); //IsMainGroup
objCTCodeTypeGroupRelaEN.OrderNum = objRow[conCTCodeTypeGroupRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.OrderNum].ToString().Trim()); //序号
objCTCodeTypeGroupRelaEN.LayerNo = objRow[conCTCodeTypeGroupRela.LayerNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.LayerNo].ToString().Trim()); //LayerNo
objCTCodeTypeGroupRelaEN.PosX = objRow[conCTCodeTypeGroupRela.PosX] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosX].ToString().Trim()); //PosX
objCTCodeTypeGroupRelaEN.PosY = objRow[conCTCodeTypeGroupRela.PosY] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosY].ToString().Trim()); //PosY
objCTCodeTypeGroupRelaEN.PosXSmall = objRow[conCTCodeTypeGroupRela.PosXSmall] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosXSmall].ToString().Trim()); //PosXSmall
objCTCodeTypeGroupRelaEN.PosYSmall = objRow[conCTCodeTypeGroupRela.PosYSmall] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosYSmall].ToString().Trim()); //PosYSmall
objCTCodeTypeGroupRelaEN.PosXLarge = objRow[conCTCodeTypeGroupRela.PosXLarge] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosXLarge].ToString().Trim()); //PosXLarge
objCTCodeTypeGroupRelaEN.PosYLarge = objRow[conCTCodeTypeGroupRela.PosYLarge] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCTCodeTypeGroupRela.PosYLarge].ToString().Trim()); //PosYLarge
objCTCodeTypeGroupRelaEN.LayoutVersion = TransNullToInt(objRow[conCTCodeTypeGroupRela.LayoutVersion].ToString().Trim()); //LayoutVersion
objCTCodeTypeGroupRelaEN.IsPinned = TransNullToBool(objRow[conCTCodeTypeGroupRela.IsPinned].ToString().Trim()); //IsPinned
objCTCodeTypeGroupRelaEN.LayoutUpdatedBy = objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy].ToString().Trim(); //LayoutUpdatedBy
objCTCodeTypeGroupRelaEN.LayoutUpdatedAt = objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt].ToString().Trim(); //LayoutUpdatedAt
objCTCodeTypeGroupRelaEN.UpdDate = objRow[conCTCodeTypeGroupRela.UpdDate] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdDate].ToString().Trim(); //修改日期
objCTCodeTypeGroupRelaEN.UpdUser = objRow[conCTCodeTypeGroupRela.UpdUser] == DBNull.Value ? null : objRow[conCTCodeTypeGroupRela.UpdUser].ToString().Trim(); //修改者
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCTCodeTypeGroupRelaDA: GetObjByDataRow)", objException.Message));
}
objCTCodeTypeGroupRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCTCodeTypeGroupRelaEN;
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
objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCTCodeTypeGroupRelaEN._CurrTabName, conCTCodeTypeGroupRela.CtGroupId, 4, "");
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
objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCTCodeTypeGroupRelaEN._CurrTabName, conCTCodeTypeGroupRela.CtGroupId, 4, strPrefix);
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
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CtGroupId,CodeTypeId from CTCodeTypeGroupRela where " + strCondition;
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
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CtGroupId,CodeTypeId from CTCodeTypeGroupRela where " + strCondition;
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
 /// <param name = "strCtGroupId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCtGroupId, string strCodeTypeId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CTCodeTypeGroupRela", "CtGroupId = " + "'"+ strCtGroupId+"'" + " and CodeTypeId = " + "'"+ strCodeTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CTCodeTypeGroupRela", strCondition))
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
objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CTCodeTypeGroupRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
 {
 objCTCodeTypeGroupRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCTCodeTypeGroupRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroupRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CTCodeTypeGroupRela");
objRow = objDS.Tables["CTCodeTypeGroupRela"].NewRow();
objRow[conCTCodeTypeGroupRela.CtGroupId] = objCTCodeTypeGroupRelaEN.CtGroupId; //Ct组Id
objRow[conCTCodeTypeGroupRela.CodeTypeId] = objCTCodeTypeGroupRelaEN.CodeTypeId; //代码类型Id
objRow[conCTCodeTypeGroupRela.IsMainGroup] = objCTCodeTypeGroupRelaEN.IsMainGroup; //IsMainGroup
objRow[conCTCodeTypeGroupRela.OrderNum] = objCTCodeTypeGroupRelaEN.OrderNum; //序号
objRow[conCTCodeTypeGroupRela.LayerNo] = objCTCodeTypeGroupRelaEN.LayerNo; //LayerNo
objRow[conCTCodeTypeGroupRela.PosX] = objCTCodeTypeGroupRelaEN.PosX; //PosX
objRow[conCTCodeTypeGroupRela.PosY] = objCTCodeTypeGroupRelaEN.PosY; //PosY
objRow[conCTCodeTypeGroupRela.PosXSmall] = objCTCodeTypeGroupRelaEN.PosXSmall; //PosXSmall
objRow[conCTCodeTypeGroupRela.PosYSmall] = objCTCodeTypeGroupRelaEN.PosYSmall; //PosYSmall
objRow[conCTCodeTypeGroupRela.PosXLarge] = objCTCodeTypeGroupRelaEN.PosXLarge; //PosXLarge
objRow[conCTCodeTypeGroupRela.PosYLarge] = objCTCodeTypeGroupRelaEN.PosYLarge; //PosYLarge
objRow[conCTCodeTypeGroupRela.LayoutVersion] = objCTCodeTypeGroupRelaEN.LayoutVersion; //LayoutVersion
objRow[conCTCodeTypeGroupRela.IsPinned] = objCTCodeTypeGroupRelaEN.IsPinned; //IsPinned
 if (objCTCodeTypeGroupRelaEN.LayoutUpdatedBy !=  "")
 {
objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy] = objCTCodeTypeGroupRelaEN.LayoutUpdatedBy; //LayoutUpdatedBy
 }
 if (objCTCodeTypeGroupRelaEN.LayoutUpdatedAt !=  "")
 {
objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt] = objCTCodeTypeGroupRelaEN.LayoutUpdatedAt; //LayoutUpdatedAt
 }
 if (objCTCodeTypeGroupRelaEN.UpdDate !=  "")
 {
objRow[conCTCodeTypeGroupRela.UpdDate] = objCTCodeTypeGroupRelaEN.UpdDate; //修改日期
 }
 if (objCTCodeTypeGroupRelaEN.UpdUser !=  "")
 {
objRow[conCTCodeTypeGroupRela.UpdUser] = objCTCodeTypeGroupRelaEN.UpdUser; //修改者
 }
objDS.Tables[clsCTCodeTypeGroupRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCTCodeTypeGroupRelaEN._CurrTabName);
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
 /// <param name = "objCTCodeTypeGroupRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
 objCTCodeTypeGroupRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCTCodeTypeGroupRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCTCodeTypeGroupRelaEN.CtGroupId !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.CtGroupId);
 var strCtGroupId = objCTCodeTypeGroupRelaEN.CtGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtGroupId + "'");
 }
 
 if (objCTCodeTypeGroupRelaEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.CodeTypeId);
 var strCodeTypeId = objCTCodeTypeGroupRelaEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.IsMainGroup);
 arrValueListForInsert.Add("'" + (objCTCodeTypeGroupRelaEN.IsMainGroup  ==  false ? "0" : "1") + "'");
 
 if (objCTCodeTypeGroupRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.OrderNum);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.OrderNum.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.LayerNo !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.LayerNo);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.LayerNo.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosX !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosX);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosX.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosY !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosY);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosY.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosXSmall !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosXSmall);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosXSmall.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosYSmall !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosYSmall);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosYSmall.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosXLarge !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosXLarge);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosXLarge.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosYLarge !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosYLarge);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosYLarge.ToString());
 }
 
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.LayoutVersion);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.LayoutVersion.ToString());
 
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.IsPinned);
 arrValueListForInsert.Add("'" + (objCTCodeTypeGroupRelaEN.IsPinned  ==  false ? "0" : "1") + "'");
 
 if (objCTCodeTypeGroupRelaEN.LayoutUpdatedBy !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.LayoutUpdatedBy);
 var strLayoutUpdatedBy = objCTCodeTypeGroupRelaEN.LayoutUpdatedBy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLayoutUpdatedBy + "'");
 }
 
 if (objCTCodeTypeGroupRelaEN.LayoutUpdatedAt !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.LayoutUpdatedAt);
 var strLayoutUpdatedAt = objCTCodeTypeGroupRelaEN.LayoutUpdatedAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLayoutUpdatedAt + "'");
 }
 
 if (objCTCodeTypeGroupRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.UpdDate);
 var strUpdDate = objCTCodeTypeGroupRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCTCodeTypeGroupRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.UpdUser);
 var strUpdUser = objCTCodeTypeGroupRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CTCodeTypeGroupRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
 objCTCodeTypeGroupRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCTCodeTypeGroupRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCTCodeTypeGroupRelaEN.CtGroupId !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.CtGroupId);
 var strCtGroupId = objCTCodeTypeGroupRelaEN.CtGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtGroupId + "'");
 }
 
 if (objCTCodeTypeGroupRelaEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.CodeTypeId);
 var strCodeTypeId = objCTCodeTypeGroupRelaEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.IsMainGroup);
 arrValueListForInsert.Add("'" + (objCTCodeTypeGroupRelaEN.IsMainGroup  ==  false ? "0" : "1") + "'");
 
 if (objCTCodeTypeGroupRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.OrderNum);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.OrderNum.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.LayerNo !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.LayerNo);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.LayerNo.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosX !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosX);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosX.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosY !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosY);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosY.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosXSmall !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosXSmall);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosXSmall.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosYSmall !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosYSmall);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosYSmall.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosXLarge !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosXLarge);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosXLarge.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosYLarge !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosYLarge);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosYLarge.ToString());
 }
 
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.LayoutVersion);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.LayoutVersion.ToString());
 
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.IsPinned);
 arrValueListForInsert.Add("'" + (objCTCodeTypeGroupRelaEN.IsPinned  ==  false ? "0" : "1") + "'");
 
 if (objCTCodeTypeGroupRelaEN.LayoutUpdatedBy !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.LayoutUpdatedBy);
 var strLayoutUpdatedBy = objCTCodeTypeGroupRelaEN.LayoutUpdatedBy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLayoutUpdatedBy + "'");
 }
 
 if (objCTCodeTypeGroupRelaEN.LayoutUpdatedAt !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.LayoutUpdatedAt);
 var strLayoutUpdatedAt = objCTCodeTypeGroupRelaEN.LayoutUpdatedAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLayoutUpdatedAt + "'");
 }
 
 if (objCTCodeTypeGroupRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.UpdDate);
 var strUpdDate = objCTCodeTypeGroupRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCTCodeTypeGroupRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.UpdUser);
 var strUpdUser = objCTCodeTypeGroupRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CTCodeTypeGroupRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCTCodeTypeGroupRelaEN.CtGroupId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCTCodeTypeGroupRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCTCodeTypeGroupRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCTCodeTypeGroupRelaEN.CtGroupId !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.CtGroupId);
 var strCtGroupId = objCTCodeTypeGroupRelaEN.CtGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtGroupId + "'");
 }
 
 if (objCTCodeTypeGroupRelaEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.CodeTypeId);
 var strCodeTypeId = objCTCodeTypeGroupRelaEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.IsMainGroup);
 arrValueListForInsert.Add("'" + (objCTCodeTypeGroupRelaEN.IsMainGroup  ==  false ? "0" : "1") + "'");
 
 if (objCTCodeTypeGroupRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.OrderNum);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.OrderNum.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.LayerNo !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.LayerNo);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.LayerNo.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosX !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosX);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosX.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosY !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosY);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosY.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosXSmall !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosXSmall);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosXSmall.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosYSmall !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosYSmall);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosYSmall.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosXLarge !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosXLarge);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosXLarge.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosYLarge !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosYLarge);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosYLarge.ToString());
 }
 
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.LayoutVersion);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.LayoutVersion.ToString());
 
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.IsPinned);
 arrValueListForInsert.Add("'" + (objCTCodeTypeGroupRelaEN.IsPinned  ==  false ? "0" : "1") + "'");
 
 if (objCTCodeTypeGroupRelaEN.LayoutUpdatedBy !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.LayoutUpdatedBy);
 var strLayoutUpdatedBy = objCTCodeTypeGroupRelaEN.LayoutUpdatedBy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLayoutUpdatedBy + "'");
 }
 
 if (objCTCodeTypeGroupRelaEN.LayoutUpdatedAt !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.LayoutUpdatedAt);
 var strLayoutUpdatedAt = objCTCodeTypeGroupRelaEN.LayoutUpdatedAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLayoutUpdatedAt + "'");
 }
 
 if (objCTCodeTypeGroupRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.UpdDate);
 var strUpdDate = objCTCodeTypeGroupRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCTCodeTypeGroupRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.UpdUser);
 var strUpdUser = objCTCodeTypeGroupRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CTCodeTypeGroupRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCTCodeTypeGroupRelaEN.CtGroupId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCTCodeTypeGroupRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCTCodeTypeGroupRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCTCodeTypeGroupRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCTCodeTypeGroupRelaEN.CtGroupId !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.CtGroupId);
 var strCtGroupId = objCTCodeTypeGroupRelaEN.CtGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCtGroupId + "'");
 }
 
 if (objCTCodeTypeGroupRelaEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.CodeTypeId);
 var strCodeTypeId = objCTCodeTypeGroupRelaEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.IsMainGroup);
 arrValueListForInsert.Add("'" + (objCTCodeTypeGroupRelaEN.IsMainGroup  ==  false ? "0" : "1") + "'");
 
 if (objCTCodeTypeGroupRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.OrderNum);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.OrderNum.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.LayerNo !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.LayerNo);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.LayerNo.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosX !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosX);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosX.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosY !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosY);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosY.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosXSmall !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosXSmall);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosXSmall.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosYSmall !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosYSmall);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosYSmall.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosXLarge !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosXLarge);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosXLarge.ToString());
 }
 
 if (objCTCodeTypeGroupRelaEN.PosYLarge !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.PosYLarge);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.PosYLarge.ToString());
 }
 
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.LayoutVersion);
 arrValueListForInsert.Add(objCTCodeTypeGroupRelaEN.LayoutVersion.ToString());
 
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.IsPinned);
 arrValueListForInsert.Add("'" + (objCTCodeTypeGroupRelaEN.IsPinned  ==  false ? "0" : "1") + "'");
 
 if (objCTCodeTypeGroupRelaEN.LayoutUpdatedBy !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.LayoutUpdatedBy);
 var strLayoutUpdatedBy = objCTCodeTypeGroupRelaEN.LayoutUpdatedBy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLayoutUpdatedBy + "'");
 }
 
 if (objCTCodeTypeGroupRelaEN.LayoutUpdatedAt !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.LayoutUpdatedAt);
 var strLayoutUpdatedAt = objCTCodeTypeGroupRelaEN.LayoutUpdatedAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLayoutUpdatedAt + "'");
 }
 
 if (objCTCodeTypeGroupRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.UpdDate);
 var strUpdDate = objCTCodeTypeGroupRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCTCodeTypeGroupRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCTCodeTypeGroupRela.UpdUser);
 var strUpdUser = objCTCodeTypeGroupRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CTCodeTypeGroupRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCTCodeTypeGroupRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroupRela where CtGroupId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CTCodeTypeGroupRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCtGroupId = oRow[conCTCodeTypeGroupRela.CtGroupId].ToString().Trim();
string strCodeTypeId = oRow[conCTCodeTypeGroupRela.CodeTypeId].ToString().Trim();
if (IsExist(strCtGroupId,strCodeTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("CtGroupId = {0},CodeTypeId = {1}", strCtGroupId,strCodeTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCTCodeTypeGroupRelaEN._CurrTabName ].NewRow();
objRow[conCTCodeTypeGroupRela.CtGroupId] = oRow[conCTCodeTypeGroupRela.CtGroupId].ToString().Trim(); //Ct组Id
objRow[conCTCodeTypeGroupRela.CodeTypeId] = oRow[conCTCodeTypeGroupRela.CodeTypeId].ToString().Trim(); //代码类型Id
objRow[conCTCodeTypeGroupRela.IsMainGroup] = oRow[conCTCodeTypeGroupRela.IsMainGroup].ToString().Trim(); //IsMainGroup
objRow[conCTCodeTypeGroupRela.OrderNum] = oRow[conCTCodeTypeGroupRela.OrderNum].ToString().Trim(); //序号
objRow[conCTCodeTypeGroupRela.LayerNo] = oRow[conCTCodeTypeGroupRela.LayerNo].ToString().Trim(); //LayerNo
objRow[conCTCodeTypeGroupRela.PosX] = oRow[conCTCodeTypeGroupRela.PosX].ToString().Trim(); //PosX
objRow[conCTCodeTypeGroupRela.PosY] = oRow[conCTCodeTypeGroupRela.PosY].ToString().Trim(); //PosY
objRow[conCTCodeTypeGroupRela.PosXSmall] = oRow[conCTCodeTypeGroupRela.PosXSmall].ToString().Trim(); //PosXSmall
objRow[conCTCodeTypeGroupRela.PosYSmall] = oRow[conCTCodeTypeGroupRela.PosYSmall].ToString().Trim(); //PosYSmall
objRow[conCTCodeTypeGroupRela.PosXLarge] = oRow[conCTCodeTypeGroupRela.PosXLarge].ToString().Trim(); //PosXLarge
objRow[conCTCodeTypeGroupRela.PosYLarge] = oRow[conCTCodeTypeGroupRela.PosYLarge].ToString().Trim(); //PosYLarge
objRow[conCTCodeTypeGroupRela.LayoutVersion] = oRow[conCTCodeTypeGroupRela.LayoutVersion].ToString().Trim(); //LayoutVersion
objRow[conCTCodeTypeGroupRela.IsPinned] = oRow[conCTCodeTypeGroupRela.IsPinned].ToString().Trim(); //IsPinned
objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy] = oRow[conCTCodeTypeGroupRela.LayoutUpdatedBy].ToString().Trim(); //LayoutUpdatedBy
objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt] = oRow[conCTCodeTypeGroupRela.LayoutUpdatedAt].ToString().Trim(); //LayoutUpdatedAt
objRow[conCTCodeTypeGroupRela.UpdDate] = oRow[conCTCodeTypeGroupRela.UpdDate].ToString().Trim(); //修改日期
objRow[conCTCodeTypeGroupRela.UpdUser] = oRow[conCTCodeTypeGroupRela.UpdUser].ToString().Trim(); //修改者
 objDS.Tables[clsCTCodeTypeGroupRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCTCodeTypeGroupRelaEN._CurrTabName);
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
 /// <param name = "objCTCodeTypeGroupRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
 objCTCodeTypeGroupRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCTCodeTypeGroupRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
strSQL = "Select * from CTCodeTypeGroupRela where CtGroupId = " + "'"+ objCTCodeTypeGroupRelaEN.CtGroupId+"'" + " and CodeTypeId = " + "'"+ objCTCodeTypeGroupRelaEN.CodeTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCTCodeTypeGroupRelaEN._CurrTabName);
if (objDS.Tables[clsCTCodeTypeGroupRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CtGroupId = " + "'"+ objCTCodeTypeGroupRelaEN.CtGroupId+"'" + " and CodeTypeId = " + "'"+ objCTCodeTypeGroupRelaEN.CodeTypeId+"'");
return false;
}
objRow = objDS.Tables[clsCTCodeTypeGroupRelaEN._CurrTabName].Rows[0];
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.CtGroupId))
 {
objRow[conCTCodeTypeGroupRela.CtGroupId] = objCTCodeTypeGroupRelaEN.CtGroupId; //Ct组Id
 }
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.CodeTypeId))
 {
objRow[conCTCodeTypeGroupRela.CodeTypeId] = objCTCodeTypeGroupRelaEN.CodeTypeId; //代码类型Id
 }
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.IsMainGroup))
 {
objRow[conCTCodeTypeGroupRela.IsMainGroup] = objCTCodeTypeGroupRelaEN.IsMainGroup; //IsMainGroup
 }
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.OrderNum))
 {
objRow[conCTCodeTypeGroupRela.OrderNum] = objCTCodeTypeGroupRelaEN.OrderNum; //序号
 }
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayerNo))
 {
objRow[conCTCodeTypeGroupRela.LayerNo] = objCTCodeTypeGroupRelaEN.LayerNo; //LayerNo
 }
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosX))
 {
objRow[conCTCodeTypeGroupRela.PosX] = objCTCodeTypeGroupRelaEN.PosX; //PosX
 }
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosY))
 {
objRow[conCTCodeTypeGroupRela.PosY] = objCTCodeTypeGroupRelaEN.PosY; //PosY
 }
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosXSmall))
 {
objRow[conCTCodeTypeGroupRela.PosXSmall] = objCTCodeTypeGroupRelaEN.PosXSmall; //PosXSmall
 }
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosYSmall))
 {
objRow[conCTCodeTypeGroupRela.PosYSmall] = objCTCodeTypeGroupRelaEN.PosYSmall; //PosYSmall
 }
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosXLarge))
 {
objRow[conCTCodeTypeGroupRela.PosXLarge] = objCTCodeTypeGroupRelaEN.PosXLarge; //PosXLarge
 }
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosYLarge))
 {
objRow[conCTCodeTypeGroupRela.PosYLarge] = objCTCodeTypeGroupRelaEN.PosYLarge; //PosYLarge
 }
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayoutVersion))
 {
objRow[conCTCodeTypeGroupRela.LayoutVersion] = objCTCodeTypeGroupRelaEN.LayoutVersion; //LayoutVersion
 }
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.IsPinned))
 {
objRow[conCTCodeTypeGroupRela.IsPinned] = objCTCodeTypeGroupRelaEN.IsPinned; //IsPinned
 }
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayoutUpdatedBy))
 {
objRow[conCTCodeTypeGroupRela.LayoutUpdatedBy] = objCTCodeTypeGroupRelaEN.LayoutUpdatedBy; //LayoutUpdatedBy
 }
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayoutUpdatedAt))
 {
objRow[conCTCodeTypeGroupRela.LayoutUpdatedAt] = objCTCodeTypeGroupRelaEN.LayoutUpdatedAt; //LayoutUpdatedAt
 }
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.UpdDate))
 {
objRow[conCTCodeTypeGroupRela.UpdDate] = objCTCodeTypeGroupRelaEN.UpdDate; //修改日期
 }
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.UpdUser))
 {
objRow[conCTCodeTypeGroupRela.UpdUser] = objCTCodeTypeGroupRelaEN.UpdUser; //修改者
 }
try
{
objDA.Update(objDS, clsCTCodeTypeGroupRelaEN._CurrTabName);
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
 /// <param name = "objCTCodeTypeGroupRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
 objCTCodeTypeGroupRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCTCodeTypeGroupRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CTCodeTypeGroupRela Set ");
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.IsMainGroup))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCTCodeTypeGroupRelaEN.IsMainGroup == true?"1":"0", conCTCodeTypeGroupRela.IsMainGroup); //IsMainGroup
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.OrderNum))
 {
 if (objCTCodeTypeGroupRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.OrderNum, conCTCodeTypeGroupRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.OrderNum); //序号
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayerNo))
 {
 if (objCTCodeTypeGroupRelaEN.LayerNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.LayerNo, conCTCodeTypeGroupRela.LayerNo); //LayerNo
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.LayerNo); //LayerNo
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosX))
 {
 if (objCTCodeTypeGroupRelaEN.PosX !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosX, conCTCodeTypeGroupRela.PosX); //PosX
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosX); //PosX
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosY))
 {
 if (objCTCodeTypeGroupRelaEN.PosY !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosY, conCTCodeTypeGroupRela.PosY); //PosY
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosY); //PosY
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosXSmall))
 {
 if (objCTCodeTypeGroupRelaEN.PosXSmall !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosXSmall, conCTCodeTypeGroupRela.PosXSmall); //PosXSmall
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosXSmall); //PosXSmall
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosYSmall))
 {
 if (objCTCodeTypeGroupRelaEN.PosYSmall !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosYSmall, conCTCodeTypeGroupRela.PosYSmall); //PosYSmall
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosYSmall); //PosYSmall
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosXLarge))
 {
 if (objCTCodeTypeGroupRelaEN.PosXLarge !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosXLarge, conCTCodeTypeGroupRela.PosXLarge); //PosXLarge
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosXLarge); //PosXLarge
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosYLarge))
 {
 if (objCTCodeTypeGroupRelaEN.PosYLarge !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosYLarge, conCTCodeTypeGroupRela.PosYLarge); //PosYLarge
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosYLarge); //PosYLarge
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayoutVersion))
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.LayoutVersion, conCTCodeTypeGroupRela.LayoutVersion); //LayoutVersion
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.IsPinned))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCTCodeTypeGroupRelaEN.IsPinned == true?"1":"0", conCTCodeTypeGroupRela.IsPinned); //IsPinned
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayoutUpdatedBy))
 {
 if (objCTCodeTypeGroupRelaEN.LayoutUpdatedBy !=  null)
 {
 var strLayoutUpdatedBy = objCTCodeTypeGroupRelaEN.LayoutUpdatedBy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLayoutUpdatedBy, conCTCodeTypeGroupRela.LayoutUpdatedBy); //LayoutUpdatedBy
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.LayoutUpdatedBy); //LayoutUpdatedBy
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayoutUpdatedAt))
 {
 if (objCTCodeTypeGroupRelaEN.LayoutUpdatedAt !=  null)
 {
 var strLayoutUpdatedAt = objCTCodeTypeGroupRelaEN.LayoutUpdatedAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLayoutUpdatedAt, conCTCodeTypeGroupRela.LayoutUpdatedAt); //LayoutUpdatedAt
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.LayoutUpdatedAt); //LayoutUpdatedAt
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.UpdDate))
 {
 if (objCTCodeTypeGroupRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCTCodeTypeGroupRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCTCodeTypeGroupRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.UpdDate); //修改日期
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.UpdUser))
 {
 if (objCTCodeTypeGroupRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objCTCodeTypeGroupRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCTCodeTypeGroupRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.UpdUser); //修改者
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CtGroupId = '{0}' And CodeTypeId = '{1}'", objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId); 
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
 /// <param name = "objCTCodeTypeGroupRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, string strCondition)
{
 objCTCodeTypeGroupRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCTCodeTypeGroupRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CTCodeTypeGroupRela Set ");
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.IsMainGroup))
 {
 sbSQL.AppendFormat(" IsMainGroup = '{0}',", objCTCodeTypeGroupRelaEN.IsMainGroup == true?"1":"0"); //IsMainGroup
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.OrderNum))
 {
 if (objCTCodeTypeGroupRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.OrderNum, conCTCodeTypeGroupRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.OrderNum); //序号
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayerNo))
 {
 if (objCTCodeTypeGroupRelaEN.LayerNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.LayerNo, conCTCodeTypeGroupRela.LayerNo); //LayerNo
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.LayerNo); //LayerNo
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosX))
 {
 if (objCTCodeTypeGroupRelaEN.PosX !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosX, conCTCodeTypeGroupRela.PosX); //PosX
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosX); //PosX
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosY))
 {
 if (objCTCodeTypeGroupRelaEN.PosY !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosY, conCTCodeTypeGroupRela.PosY); //PosY
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosY); //PosY
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosXSmall))
 {
 if (objCTCodeTypeGroupRelaEN.PosXSmall !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosXSmall, conCTCodeTypeGroupRela.PosXSmall); //PosXSmall
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosXSmall); //PosXSmall
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosYSmall))
 {
 if (objCTCodeTypeGroupRelaEN.PosYSmall !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosYSmall, conCTCodeTypeGroupRela.PosYSmall); //PosYSmall
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosYSmall); //PosYSmall
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosXLarge))
 {
 if (objCTCodeTypeGroupRelaEN.PosXLarge !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosXLarge, conCTCodeTypeGroupRela.PosXLarge); //PosXLarge
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosXLarge); //PosXLarge
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosYLarge))
 {
 if (objCTCodeTypeGroupRelaEN.PosYLarge !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosYLarge, conCTCodeTypeGroupRela.PosYLarge); //PosYLarge
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosYLarge); //PosYLarge
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayoutVersion))
 {
 sbSQL.AppendFormat(" LayoutVersion = {0},", objCTCodeTypeGroupRelaEN.LayoutVersion); //LayoutVersion
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.IsPinned))
 {
 sbSQL.AppendFormat(" IsPinned = '{0}',", objCTCodeTypeGroupRelaEN.IsPinned == true?"1":"0"); //IsPinned
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayoutUpdatedBy))
 {
 if (objCTCodeTypeGroupRelaEN.LayoutUpdatedBy !=  null)
 {
 var strLayoutUpdatedBy = objCTCodeTypeGroupRelaEN.LayoutUpdatedBy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LayoutUpdatedBy = '{0}',", strLayoutUpdatedBy); //LayoutUpdatedBy
 }
 else
 {
 sbSQL.Append(" LayoutUpdatedBy = null,"); //LayoutUpdatedBy
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayoutUpdatedAt))
 {
 if (objCTCodeTypeGroupRelaEN.LayoutUpdatedAt !=  null)
 {
 var strLayoutUpdatedAt = objCTCodeTypeGroupRelaEN.LayoutUpdatedAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LayoutUpdatedAt = '{0}',", strLayoutUpdatedAt); //LayoutUpdatedAt
 }
 else
 {
 sbSQL.Append(" LayoutUpdatedAt = null,"); //LayoutUpdatedAt
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.UpdDate))
 {
 if (objCTCodeTypeGroupRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCTCodeTypeGroupRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.UpdUser))
 {
 if (objCTCodeTypeGroupRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objCTCodeTypeGroupRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
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
 /// <param name = "objCTCodeTypeGroupRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCTCodeTypeGroupRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCTCodeTypeGroupRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CTCodeTypeGroupRela Set ");
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.IsMainGroup))
 {
 sbSQL.AppendFormat(" IsMainGroup = '{0}',", objCTCodeTypeGroupRelaEN.IsMainGroup == true?"1":"0"); //IsMainGroup
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.OrderNum))
 {
 if (objCTCodeTypeGroupRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.OrderNum, conCTCodeTypeGroupRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.OrderNum); //序号
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayerNo))
 {
 if (objCTCodeTypeGroupRelaEN.LayerNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.LayerNo, conCTCodeTypeGroupRela.LayerNo); //LayerNo
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.LayerNo); //LayerNo
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosX))
 {
 if (objCTCodeTypeGroupRelaEN.PosX !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosX, conCTCodeTypeGroupRela.PosX); //PosX
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosX); //PosX
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosY))
 {
 if (objCTCodeTypeGroupRelaEN.PosY !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosY, conCTCodeTypeGroupRela.PosY); //PosY
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosY); //PosY
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosXSmall))
 {
 if (objCTCodeTypeGroupRelaEN.PosXSmall !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosXSmall, conCTCodeTypeGroupRela.PosXSmall); //PosXSmall
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosXSmall); //PosXSmall
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosYSmall))
 {
 if (objCTCodeTypeGroupRelaEN.PosYSmall !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosYSmall, conCTCodeTypeGroupRela.PosYSmall); //PosYSmall
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosYSmall); //PosYSmall
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosXLarge))
 {
 if (objCTCodeTypeGroupRelaEN.PosXLarge !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosXLarge, conCTCodeTypeGroupRela.PosXLarge); //PosXLarge
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosXLarge); //PosXLarge
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosYLarge))
 {
 if (objCTCodeTypeGroupRelaEN.PosYLarge !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosYLarge, conCTCodeTypeGroupRela.PosYLarge); //PosYLarge
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosYLarge); //PosYLarge
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayoutVersion))
 {
 sbSQL.AppendFormat(" LayoutVersion = {0},", objCTCodeTypeGroupRelaEN.LayoutVersion); //LayoutVersion
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.IsPinned))
 {
 sbSQL.AppendFormat(" IsPinned = '{0}',", objCTCodeTypeGroupRelaEN.IsPinned == true?"1":"0"); //IsPinned
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayoutUpdatedBy))
 {
 if (objCTCodeTypeGroupRelaEN.LayoutUpdatedBy !=  null)
 {
 var strLayoutUpdatedBy = objCTCodeTypeGroupRelaEN.LayoutUpdatedBy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LayoutUpdatedBy = '{0}',", strLayoutUpdatedBy); //LayoutUpdatedBy
 }
 else
 {
 sbSQL.Append(" LayoutUpdatedBy = null,"); //LayoutUpdatedBy
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayoutUpdatedAt))
 {
 if (objCTCodeTypeGroupRelaEN.LayoutUpdatedAt !=  null)
 {
 var strLayoutUpdatedAt = objCTCodeTypeGroupRelaEN.LayoutUpdatedAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LayoutUpdatedAt = '{0}',", strLayoutUpdatedAt); //LayoutUpdatedAt
 }
 else
 {
 sbSQL.Append(" LayoutUpdatedAt = null,"); //LayoutUpdatedAt
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.UpdDate))
 {
 if (objCTCodeTypeGroupRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCTCodeTypeGroupRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.UpdUser))
 {
 if (objCTCodeTypeGroupRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objCTCodeTypeGroupRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
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
 /// <param name = "objCTCodeTypeGroupRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCTCodeTypeGroupRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCTCodeTypeGroupRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCTCodeTypeGroupRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CTCodeTypeGroupRela Set ");
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.IsMainGroup))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCTCodeTypeGroupRelaEN.IsMainGroup == true?"1":"0", conCTCodeTypeGroupRela.IsMainGroup); //IsMainGroup
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.OrderNum))
 {
 if (objCTCodeTypeGroupRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.OrderNum, conCTCodeTypeGroupRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.OrderNum); //序号
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayerNo))
 {
 if (objCTCodeTypeGroupRelaEN.LayerNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.LayerNo, conCTCodeTypeGroupRela.LayerNo); //LayerNo
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.LayerNo); //LayerNo
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosX))
 {
 if (objCTCodeTypeGroupRelaEN.PosX !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosX, conCTCodeTypeGroupRela.PosX); //PosX
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosX); //PosX
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosY))
 {
 if (objCTCodeTypeGroupRelaEN.PosY !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosY, conCTCodeTypeGroupRela.PosY); //PosY
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosY); //PosY
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosXSmall))
 {
 if (objCTCodeTypeGroupRelaEN.PosXSmall !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosXSmall, conCTCodeTypeGroupRela.PosXSmall); //PosXSmall
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosXSmall); //PosXSmall
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosYSmall))
 {
 if (objCTCodeTypeGroupRelaEN.PosYSmall !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosYSmall, conCTCodeTypeGroupRela.PosYSmall); //PosYSmall
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosYSmall); //PosYSmall
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosXLarge))
 {
 if (objCTCodeTypeGroupRelaEN.PosXLarge !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosXLarge, conCTCodeTypeGroupRela.PosXLarge); //PosXLarge
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosXLarge); //PosXLarge
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.PosYLarge))
 {
 if (objCTCodeTypeGroupRelaEN.PosYLarge !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.PosYLarge, conCTCodeTypeGroupRela.PosYLarge); //PosYLarge
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.PosYLarge); //PosYLarge
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayoutVersion))
 {
 sbSQL.AppendFormat("{1} = {0},",objCTCodeTypeGroupRelaEN.LayoutVersion, conCTCodeTypeGroupRela.LayoutVersion); //LayoutVersion
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.IsPinned))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCTCodeTypeGroupRelaEN.IsPinned == true?"1":"0", conCTCodeTypeGroupRela.IsPinned); //IsPinned
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayoutUpdatedBy))
 {
 if (objCTCodeTypeGroupRelaEN.LayoutUpdatedBy !=  null)
 {
 var strLayoutUpdatedBy = objCTCodeTypeGroupRelaEN.LayoutUpdatedBy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLayoutUpdatedBy, conCTCodeTypeGroupRela.LayoutUpdatedBy); //LayoutUpdatedBy
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.LayoutUpdatedBy); //LayoutUpdatedBy
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.LayoutUpdatedAt))
 {
 if (objCTCodeTypeGroupRelaEN.LayoutUpdatedAt !=  null)
 {
 var strLayoutUpdatedAt = objCTCodeTypeGroupRelaEN.LayoutUpdatedAt.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLayoutUpdatedAt, conCTCodeTypeGroupRela.LayoutUpdatedAt); //LayoutUpdatedAt
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.LayoutUpdatedAt); //LayoutUpdatedAt
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.UpdDate))
 {
 if (objCTCodeTypeGroupRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objCTCodeTypeGroupRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCTCodeTypeGroupRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.UpdDate); //修改日期
 }
 }
 
 if (objCTCodeTypeGroupRelaEN.IsUpdated(conCTCodeTypeGroupRela.UpdUser))
 {
 if (objCTCodeTypeGroupRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objCTCodeTypeGroupRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCTCodeTypeGroupRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCTCodeTypeGroupRela.UpdUser); //修改者
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CtGroupId = '{0}' And CodeTypeId = '{1}'", objCTCodeTypeGroupRelaEN.CtGroupId,objCTCodeTypeGroupRelaEN.CodeTypeId); 
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
 /// <param name = "strCtGroupId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCtGroupId,string strCodeTypeId) 
{
CheckPrimaryKey(strCtGroupId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCtGroupId,
 strCodeTypeId,
};
 objSQL.ExecSP("CTCodeTypeGroupRela_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCtGroupId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCtGroupId,string strCodeTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCtGroupId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
//删除CTCodeTypeGroupRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CTCodeTypeGroupRela where CtGroupId = " + "'"+ strCtGroupId+"'" + " and CodeTypeId = " + "'"+ strCodeTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelRecKeyLsts(List<string> arrKeyLsts)
{
if (arrKeyLsts.Count  == 0) return 0;
int intCount = 0;
foreach (var strKeyLst in arrKeyLsts)
{
string[] sstrKey = strKeyLst.Split('|');
string strCtGroupId = sstrKey[0];
string strCodeTypeId = sstrKey[1];
 int intRecNum  = this.DelRecord(strCtGroupId,strCodeTypeId);
 intCount += intRecNum;
}
 return intCount;
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCtGroupId">给定的关键字值</param>
 /// <param name = "strCodeTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCtGroupId,string strCodeTypeId) 
{
CheckPrimaryKey(strCtGroupId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
//删除CTCodeTypeGroupRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CTCodeTypeGroupRela where CtGroupId = " + "'"+ strCtGroupId+"'" + " and CodeTypeId = " + "'"+ strCodeTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCTCodeTypeGroupRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupRelaDA: DelCTCodeTypeGroupRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CTCodeTypeGroupRela where " + strCondition ;
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
public bool DelCTCodeTypeGroupRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCTCodeTypeGroupRelaDA: DelCTCodeTypeGroupRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CTCodeTypeGroupRela where " + strCondition ;
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
 /// <param name = "objCTCodeTypeGroupRelaENS">源对象</param>
 /// <param name = "objCTCodeTypeGroupRelaENT">目标对象</param>
public void CopyTo(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaENS, clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaENT)
{
objCTCodeTypeGroupRelaENT.CtGroupId = objCTCodeTypeGroupRelaENS.CtGroupId; //Ct组Id
objCTCodeTypeGroupRelaENT.CodeTypeId = objCTCodeTypeGroupRelaENS.CodeTypeId; //代码类型Id
objCTCodeTypeGroupRelaENT.IsMainGroup = objCTCodeTypeGroupRelaENS.IsMainGroup; //IsMainGroup
objCTCodeTypeGroupRelaENT.OrderNum = objCTCodeTypeGroupRelaENS.OrderNum; //序号
objCTCodeTypeGroupRelaENT.LayerNo = objCTCodeTypeGroupRelaENS.LayerNo; //LayerNo
objCTCodeTypeGroupRelaENT.PosX = objCTCodeTypeGroupRelaENS.PosX; //PosX
objCTCodeTypeGroupRelaENT.PosY = objCTCodeTypeGroupRelaENS.PosY; //PosY
objCTCodeTypeGroupRelaENT.PosXSmall = objCTCodeTypeGroupRelaENS.PosXSmall; //PosXSmall
objCTCodeTypeGroupRelaENT.PosYSmall = objCTCodeTypeGroupRelaENS.PosYSmall; //PosYSmall
objCTCodeTypeGroupRelaENT.PosXLarge = objCTCodeTypeGroupRelaENS.PosXLarge; //PosXLarge
objCTCodeTypeGroupRelaENT.PosYLarge = objCTCodeTypeGroupRelaENS.PosYLarge; //PosYLarge
objCTCodeTypeGroupRelaENT.LayoutVersion = objCTCodeTypeGroupRelaENS.LayoutVersion; //LayoutVersion
objCTCodeTypeGroupRelaENT.IsPinned = objCTCodeTypeGroupRelaENS.IsPinned; //IsPinned
objCTCodeTypeGroupRelaENT.LayoutUpdatedBy = objCTCodeTypeGroupRelaENS.LayoutUpdatedBy; //LayoutUpdatedBy
objCTCodeTypeGroupRelaENT.LayoutUpdatedAt = objCTCodeTypeGroupRelaENS.LayoutUpdatedAt; //LayoutUpdatedAt
objCTCodeTypeGroupRelaENT.UpdDate = objCTCodeTypeGroupRelaENS.UpdDate; //修改日期
objCTCodeTypeGroupRelaENT.UpdUser = objCTCodeTypeGroupRelaENS.UpdUser; //修改者
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCTCodeTypeGroupRelaEN.IsMainGroup, conCTCodeTypeGroupRela.IsMainGroup);
clsCheckSql.CheckFieldNotNull(objCTCodeTypeGroupRelaEN.LayoutVersion, conCTCodeTypeGroupRela.LayoutVersion);
clsCheckSql.CheckFieldNotNull(objCTCodeTypeGroupRelaEN.IsPinned, conCTCodeTypeGroupRela.IsPinned);
//检查字段长度
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupRelaEN.CtGroupId, 4, conCTCodeTypeGroupRela.CtGroupId);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupRelaEN.CodeTypeId, 4, conCTCodeTypeGroupRela.CodeTypeId);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupRelaEN.LayoutUpdatedBy, 100, conCTCodeTypeGroupRela.LayoutUpdatedBy);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupRelaEN.LayoutUpdatedAt, 20, conCTCodeTypeGroupRela.LayoutUpdatedAt);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupRelaEN.UpdDate, 20, conCTCodeTypeGroupRela.UpdDate);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupRelaEN.UpdUser, 20, conCTCodeTypeGroupRela.UpdUser);
//检查字段外键固定长度
 objCTCodeTypeGroupRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupRelaEN.LayoutUpdatedBy, 100, conCTCodeTypeGroupRela.LayoutUpdatedBy);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupRelaEN.LayoutUpdatedAt, 20, conCTCodeTypeGroupRela.LayoutUpdatedAt);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupRelaEN.UpdDate, 20, conCTCodeTypeGroupRela.UpdDate);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupRelaEN.UpdUser, 20, conCTCodeTypeGroupRela.UpdUser);
//检查外键字段长度
 objCTCodeTypeGroupRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCTCodeTypeGroupRelaEN objCTCodeTypeGroupRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupRelaEN.CtGroupId, 4, conCTCodeTypeGroupRela.CtGroupId);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupRelaEN.CodeTypeId, 4, conCTCodeTypeGroupRela.CodeTypeId);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupRelaEN.LayoutUpdatedBy, 100, conCTCodeTypeGroupRela.LayoutUpdatedBy);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupRelaEN.LayoutUpdatedAt, 20, conCTCodeTypeGroupRela.LayoutUpdatedAt);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupRelaEN.UpdDate, 20, conCTCodeTypeGroupRela.UpdDate);
clsCheckSql.CheckFieldLen(objCTCodeTypeGroupRelaEN.UpdUser, 20, conCTCodeTypeGroupRela.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCTCodeTypeGroupRelaEN.CtGroupId, conCTCodeTypeGroupRela.CtGroupId);
clsCheckSql.CheckSqlInjection4Field(objCTCodeTypeGroupRelaEN.CodeTypeId, conCTCodeTypeGroupRela.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objCTCodeTypeGroupRelaEN.LayoutUpdatedBy, conCTCodeTypeGroupRela.LayoutUpdatedBy);
clsCheckSql.CheckSqlInjection4Field(objCTCodeTypeGroupRelaEN.LayoutUpdatedAt, conCTCodeTypeGroupRela.LayoutUpdatedAt);
clsCheckSql.CheckSqlInjection4Field(objCTCodeTypeGroupRelaEN.UpdDate, conCTCodeTypeGroupRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCTCodeTypeGroupRelaEN.UpdUser, conCTCodeTypeGroupRela.UpdUser);
//检查外键字段长度
 objCTCodeTypeGroupRelaEN._IsCheckProperty = true;
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
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
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
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
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
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCTCodeTypeGroupRelaEN._CurrTabName);
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
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCTCodeTypeGroupRelaEN._CurrTabName, strCondition);
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
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
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
 objSQL = clsCTCodeTypeGroupRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}