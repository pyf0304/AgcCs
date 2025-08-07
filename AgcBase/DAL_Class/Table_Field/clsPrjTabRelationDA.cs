
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabRelationDA
 表名:PrjTabRelation(00050606)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:56
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// 工程表关系(PrjTabRelation)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPrjTabRelationDA : clsCommBase4DA
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
 return clsPrjTabRelationEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPrjTabRelationEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjTabRelationEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPrjTabRelationEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPrjTabRelationEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strPrjRelationId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strPrjRelationId)
{
strPrjRelationId = strPrjRelationId.Replace("'", "''");
if (strPrjRelationId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:PrjTabRelation中,检查关键字,长度不正确!(clsPrjTabRelationDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPrjRelationId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:PrjTabRelation中,关键字不能为空 或 null!(clsPrjTabRelationDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjRelationId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsPrjTabRelationDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPrjTabRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PrjTabRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPrjTabRelationDA: GetDataTable_PrjTabRelation)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPrjTabRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPrjTabRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPrjTabRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPrjTabRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjTabRelation where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjTabRelation where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPrjTabRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PrjTabRelation where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPrjTabRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjTabRelation.* " + 
$"from PrjTabRelation " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjTabRelation.PrjRelationId not in " + 
$"(Select top {intTop_In} PrjTabRelation.PrjRelationId from PrjTabRelation " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjTabRelation where {1} and PrjRelationId not in (Select top {2} PrjRelationId from PrjTabRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjTabRelation where {1} and PrjRelationId not in (Select top {3} PrjRelationId from PrjTabRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPrjTabRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjTabRelation.* " + 
$"from PrjTabRelation " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjTabRelation.PrjRelationId not in " + 
$"(Select top {intTop_In} PrjTabRelation.PrjRelationId from PrjTabRelation " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjTabRelation where {1} and PrjRelationId not in (Select top {2} PrjRelationId from PrjTabRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjTabRelation where {1} and PrjRelationId not in (Select top {3} PrjRelationId from PrjTabRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPrjTabRelationEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPrjTabRelationDA:GetObjLst)", objException.Message));
}
List<clsPrjTabRelationEN> arrObjLst = new List<clsPrjTabRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabRelationEN objPrjTabRelationEN = new clsPrjTabRelationEN();
try
{
objPrjTabRelationEN.PrjRelationId = objRow[conPrjTabRelation.PrjRelationId].ToString().Trim(); //关系Id
objPrjTabRelationEN.RelationName = objRow[conPrjTabRelation.RelationName].ToString().Trim(); //关系名
objPrjTabRelationEN.TabId = objRow[conPrjTabRelation.TabId].ToString().Trim(); //表ID
objPrjTabRelationEN.PrjTabRelaTypeId = objRow[conPrjTabRelation.PrjTabRelaTypeId].ToString().Trim(); //表关系类型Id
objPrjTabRelationEN.DnPathId = objRow[conPrjTabRelation.DnPathId] == DBNull.Value ? null : objRow[conPrjTabRelation.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabRelationEN.RelationTabId = objRow[conPrjTabRelation.RelationTabId].ToString().Trim(); //相关表Id
objPrjTabRelationEN.FldId4TabId = objRow[conPrjTabRelation.FldId4TabId].ToString().Trim(); //当前表的关系字段Id
objPrjTabRelationEN.FldId4RelaTabId = objRow[conPrjTabRelation.FldId4RelaTabId].ToString().Trim(); //关系表的关系字段Id
objPrjTabRelationEN.ForeignKeyTabId = objRow[conPrjTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabRelationEN.ForeignKeyFldId = objRow[conPrjTabRelation.ForeignKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objPrjTabRelationEN.IsCheckCurrData = TransNullToBool(objRow[conPrjTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objPrjTabRelationEN.IsCopyForceRela = TransNullToBool(objRow[conPrjTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objPrjTabRelationEN.IsUpdRelateFld = TransNullToBool(objRow[conPrjTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objPrjTabRelationEN.IsUpdMainTabDate = TransNullToBool(objRow[conPrjTabRelation.IsUpdMainTabDate].ToString().Trim()); //是否修改主表日期
objPrjTabRelationEN.IsRefreshMainTabCache = TransNullToBool(objRow[conPrjTabRelation.IsRefreshMainTabCache].ToString().Trim()); //是否刷新主表缓存
objPrjTabRelationEN.IsDelRelateRec = TransNullToBool(objRow[conPrjTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objPrjTabRelationEN.PrjId = objRow[conPrjTabRelation.PrjId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrjId].ToString().Trim(); //工程Id
objPrjTabRelationEN.Memo = objRow[conPrjTabRelation.Memo] == DBNull.Value ? null : objRow[conPrjTabRelation.Memo].ToString().Trim(); //说明
objPrjTabRelationEN.PrimaryKeyTabId = objRow[conPrjTabRelation.PrimaryKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objPrjTabRelationEN.PrimaryKeyFldId = objRow[conPrjTabRelation.PrimaryKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjTabRelationDA: GetObjLst)", objException.Message));
}
objPrjTabRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjTabRelationEN);
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
public List<clsPrjTabRelationEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPrjTabRelationDA:GetObjLstByTabName)", objException.Message));
}
List<clsPrjTabRelationEN> arrObjLst = new List<clsPrjTabRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabRelationEN objPrjTabRelationEN = new clsPrjTabRelationEN();
try
{
objPrjTabRelationEN.PrjRelationId = objRow[conPrjTabRelation.PrjRelationId].ToString().Trim(); //关系Id
objPrjTabRelationEN.RelationName = objRow[conPrjTabRelation.RelationName].ToString().Trim(); //关系名
objPrjTabRelationEN.TabId = objRow[conPrjTabRelation.TabId].ToString().Trim(); //表ID
objPrjTabRelationEN.PrjTabRelaTypeId = objRow[conPrjTabRelation.PrjTabRelaTypeId].ToString().Trim(); //表关系类型Id
objPrjTabRelationEN.DnPathId = objRow[conPrjTabRelation.DnPathId] == DBNull.Value ? null : objRow[conPrjTabRelation.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabRelationEN.RelationTabId = objRow[conPrjTabRelation.RelationTabId].ToString().Trim(); //相关表Id
objPrjTabRelationEN.FldId4TabId = objRow[conPrjTabRelation.FldId4TabId].ToString().Trim(); //当前表的关系字段Id
objPrjTabRelationEN.FldId4RelaTabId = objRow[conPrjTabRelation.FldId4RelaTabId].ToString().Trim(); //关系表的关系字段Id
objPrjTabRelationEN.ForeignKeyTabId = objRow[conPrjTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabRelationEN.ForeignKeyFldId = objRow[conPrjTabRelation.ForeignKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objPrjTabRelationEN.IsCheckCurrData = TransNullToBool(objRow[conPrjTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objPrjTabRelationEN.IsCopyForceRela = TransNullToBool(objRow[conPrjTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objPrjTabRelationEN.IsUpdRelateFld = TransNullToBool(objRow[conPrjTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objPrjTabRelationEN.IsUpdMainTabDate = TransNullToBool(objRow[conPrjTabRelation.IsUpdMainTabDate].ToString().Trim()); //是否修改主表日期
objPrjTabRelationEN.IsRefreshMainTabCache = TransNullToBool(objRow[conPrjTabRelation.IsRefreshMainTabCache].ToString().Trim()); //是否刷新主表缓存
objPrjTabRelationEN.IsDelRelateRec = TransNullToBool(objRow[conPrjTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objPrjTabRelationEN.PrjId = objRow[conPrjTabRelation.PrjId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrjId].ToString().Trim(); //工程Id
objPrjTabRelationEN.Memo = objRow[conPrjTabRelation.Memo] == DBNull.Value ? null : objRow[conPrjTabRelation.Memo].ToString().Trim(); //说明
objPrjTabRelationEN.PrimaryKeyTabId = objRow[conPrjTabRelation.PrimaryKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objPrjTabRelationEN.PrimaryKeyFldId = objRow[conPrjTabRelation.PrimaryKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjTabRelationDA: GetObjLst)", objException.Message));
}
objPrjTabRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjTabRelationEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPrjTabRelation(ref clsPrjTabRelationEN objPrjTabRelationEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabRelation where PrjRelationId = " + "'"+ objPrjTabRelationEN.PrjRelationId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPrjTabRelationEN.PrjRelationId = objDT.Rows[0][conPrjTabRelation.PrjRelationId].ToString().Trim(); //关系Id(字段类型:varchar,字段长度:8,是否可空:False)
 objPrjTabRelationEN.RelationName = objDT.Rows[0][conPrjTabRelation.RelationName].ToString().Trim(); //关系名(字段类型:varchar,字段长度:40,是否可空:False)
 objPrjTabRelationEN.TabId = objDT.Rows[0][conPrjTabRelation.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabRelationEN.PrjTabRelaTypeId = objDT.Rows[0][conPrjTabRelation.PrjTabRelaTypeId].ToString().Trim(); //表关系类型Id(字段类型:char,字段长度:2,是否可空:False)
 objPrjTabRelationEN.DnPathId = objDT.Rows[0][conPrjTabRelation.DnPathId].ToString().Trim(); //DN路径Id(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabRelationEN.RelationTabId = objDT.Rows[0][conPrjTabRelation.RelationTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabRelationEN.FldId4TabId = objDT.Rows[0][conPrjTabRelation.FldId4TabId].ToString().Trim(); //当前表的关系字段Id(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabRelationEN.FldId4RelaTabId = objDT.Rows[0][conPrjTabRelation.FldId4RelaTabId].ToString().Trim(); //关系表的关系字段Id(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabRelationEN.ForeignKeyTabId = objDT.Rows[0][conPrjTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabRelationEN.ForeignKeyFldId = objDT.Rows[0][conPrjTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabRelationEN.IsCheckCurrData = TransNullToBool(objDT.Rows[0][conPrjTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据(字段类型:bit,字段长度:1,是否可空:False)
 objPrjTabRelationEN.IsCopyForceRela = TransNullToBool(objDT.Rows[0][conPrjTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela(字段类型:bit,字段长度:1,是否可空:False)
 objPrjTabRelationEN.IsUpdRelateFld = TransNullToBool(objDT.Rows[0][conPrjTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段(字段类型:bit,字段长度:1,是否可空:False)
 objPrjTabRelationEN.IsUpdMainTabDate = TransNullToBool(objDT.Rows[0][conPrjTabRelation.IsUpdMainTabDate].ToString().Trim()); //是否修改主表日期(字段类型:bit,字段长度:1,是否可空:False)
 objPrjTabRelationEN.IsRefreshMainTabCache = TransNullToBool(objDT.Rows[0][conPrjTabRelation.IsRefreshMainTabCache].ToString().Trim()); //是否刷新主表缓存(字段类型:bit,字段长度:1,是否可空:False)
 objPrjTabRelationEN.IsDelRelateRec = TransNullToBool(objDT.Rows[0][conPrjTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录(字段类型:bit,字段长度:1,是否可空:False)
 objPrjTabRelationEN.PrjId = objDT.Rows[0][conPrjTabRelation.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjTabRelationEN.Memo = objDT.Rows[0][conPrjTabRelation.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objPrjTabRelationEN.PrimaryKeyTabId = objDT.Rows[0][conPrjTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId(字段类型:varchar,字段长度:8,是否可空:False)
 objPrjTabRelationEN.PrimaryKeyFldId = objDT.Rows[0][conPrjTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId(字段类型:varchar,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPrjTabRelationDA: GetPrjTabRelation)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjRelationId">表关键字</param>
 /// <returns>表对象</returns>
public clsPrjTabRelationEN GetObjByPrjRelationId(string strPrjRelationId)
{
CheckPrimaryKey(strPrjRelationId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabRelation where PrjRelationId = " + "'"+ strPrjRelationId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPrjTabRelationEN objPrjTabRelationEN = new clsPrjTabRelationEN();
try
{
 objPrjTabRelationEN.PrjRelationId = objRow[conPrjTabRelation.PrjRelationId].ToString().Trim(); //关系Id(字段类型:varchar,字段长度:8,是否可空:False)
 objPrjTabRelationEN.RelationName = objRow[conPrjTabRelation.RelationName].ToString().Trim(); //关系名(字段类型:varchar,字段长度:40,是否可空:False)
 objPrjTabRelationEN.TabId = objRow[conPrjTabRelation.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabRelationEN.PrjTabRelaTypeId = objRow[conPrjTabRelation.PrjTabRelaTypeId].ToString().Trim(); //表关系类型Id(字段类型:char,字段长度:2,是否可空:False)
 objPrjTabRelationEN.DnPathId = objRow[conPrjTabRelation.DnPathId] == DBNull.Value ? null : objRow[conPrjTabRelation.DnPathId].ToString().Trim(); //DN路径Id(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabRelationEN.RelationTabId = objRow[conPrjTabRelation.RelationTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabRelationEN.FldId4TabId = objRow[conPrjTabRelation.FldId4TabId].ToString().Trim(); //当前表的关系字段Id(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabRelationEN.FldId4RelaTabId = objRow[conPrjTabRelation.FldId4RelaTabId].ToString().Trim(); //关系表的关系字段Id(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabRelationEN.ForeignKeyTabId = objRow[conPrjTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabRelationEN.ForeignKeyFldId = objRow[conPrjTabRelation.ForeignKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据(字段类型:bit,字段长度:1,是否可空:False)
 objPrjTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela(字段类型:bit,字段长度:1,是否可空:False)
 objPrjTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段(字段类型:bit,字段长度:1,是否可空:False)
 objPrjTabRelationEN.IsUpdMainTabDate = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsUpdMainTabDate].ToString().Trim()); //是否修改主表日期(字段类型:bit,字段长度:1,是否可空:False)
 objPrjTabRelationEN.IsRefreshMainTabCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsRefreshMainTabCache].ToString().Trim()); //是否刷新主表缓存(字段类型:bit,字段长度:1,是否可空:False)
 objPrjTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conPrjTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录(字段类型:bit,字段长度:1,是否可空:False)
 objPrjTabRelationEN.PrjId = objRow[conPrjTabRelation.PrjId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjTabRelationEN.Memo = objRow[conPrjTabRelation.Memo] == DBNull.Value ? null : objRow[conPrjTabRelation.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objPrjTabRelationEN.PrimaryKeyTabId = objRow[conPrjTabRelation.PrimaryKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId(字段类型:varchar,字段长度:8,是否可空:False)
 objPrjTabRelationEN.PrimaryKeyFldId = objRow[conPrjTabRelation.PrimaryKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId(字段类型:varchar,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPrjTabRelationDA: GetObjByPrjRelationId)", objException.Message));
}
return objPrjTabRelationEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPrjTabRelationEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPrjTabRelationDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPrjTabRelationEN objPrjTabRelationEN = new clsPrjTabRelationEN()
{
PrjRelationId = objRow[conPrjTabRelation.PrjRelationId].ToString().Trim(), //关系Id
RelationName = objRow[conPrjTabRelation.RelationName].ToString().Trim(), //关系名
TabId = objRow[conPrjTabRelation.TabId].ToString().Trim(), //表ID
PrjTabRelaTypeId = objRow[conPrjTabRelation.PrjTabRelaTypeId].ToString().Trim(), //表关系类型Id
DnPathId = objRow[conPrjTabRelation.DnPathId] == DBNull.Value ? null : objRow[conPrjTabRelation.DnPathId].ToString().Trim(), //DN路径Id
RelationTabId = objRow[conPrjTabRelation.RelationTabId].ToString().Trim(), //相关表Id
FldId4TabId = objRow[conPrjTabRelation.FldId4TabId].ToString().Trim(), //当前表的关系字段Id
FldId4RelaTabId = objRow[conPrjTabRelation.FldId4RelaTabId].ToString().Trim(), //关系表的关系字段Id
ForeignKeyTabId = objRow[conPrjTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyTabId].ToString().Trim(), //外键表ID
ForeignKeyFldId = objRow[conPrjTabRelation.ForeignKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyFldId].ToString().Trim(), //外键字段Id
IsCheckCurrData = TransNullToBool(objRow[conPrjTabRelation.IsCheckCurrData].ToString().Trim()), //是否检查当前数据
IsCopyForceRela = TransNullToBool(objRow[conPrjTabRelation.IsCopyForceRela].ToString().Trim()), //IsCopyForceRela
IsUpdRelateFld = TransNullToBool(objRow[conPrjTabRelation.IsUpdRelateFld].ToString().Trim()), //是否修改关系字段
IsUpdMainTabDate = TransNullToBool(objRow[conPrjTabRelation.IsUpdMainTabDate].ToString().Trim()), //是否修改主表日期
IsRefreshMainTabCache = TransNullToBool(objRow[conPrjTabRelation.IsRefreshMainTabCache].ToString().Trim()), //是否刷新主表缓存
IsDelRelateRec = TransNullToBool(objRow[conPrjTabRelation.IsDelRelateRec].ToString().Trim()), //是否删除相关记录
PrjId = objRow[conPrjTabRelation.PrjId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrjId].ToString().Trim(), //工程Id
Memo = objRow[conPrjTabRelation.Memo] == DBNull.Value ? null : objRow[conPrjTabRelation.Memo].ToString().Trim(), //说明
PrimaryKeyTabId = objRow[conPrjTabRelation.PrimaryKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyTabId].ToString().Trim(), //PrimaryKeyTabId
PrimaryKeyFldId = objRow[conPrjTabRelation.PrimaryKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyFldId].ToString().Trim() //PrimaryKeyFldId
};
objPrjTabRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjTabRelationEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPrjTabRelationDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPrjTabRelationEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjTabRelationEN objPrjTabRelationEN = new clsPrjTabRelationEN();
try
{
objPrjTabRelationEN.PrjRelationId = objRow[conPrjTabRelation.PrjRelationId].ToString().Trim(); //关系Id
objPrjTabRelationEN.RelationName = objRow[conPrjTabRelation.RelationName].ToString().Trim(); //关系名
objPrjTabRelationEN.TabId = objRow[conPrjTabRelation.TabId].ToString().Trim(); //表ID
objPrjTabRelationEN.PrjTabRelaTypeId = objRow[conPrjTabRelation.PrjTabRelaTypeId].ToString().Trim(); //表关系类型Id
objPrjTabRelationEN.DnPathId = objRow[conPrjTabRelation.DnPathId] == DBNull.Value ? null : objRow[conPrjTabRelation.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabRelationEN.RelationTabId = objRow[conPrjTabRelation.RelationTabId].ToString().Trim(); //相关表Id
objPrjTabRelationEN.FldId4TabId = objRow[conPrjTabRelation.FldId4TabId].ToString().Trim(); //当前表的关系字段Id
objPrjTabRelationEN.FldId4RelaTabId = objRow[conPrjTabRelation.FldId4RelaTabId].ToString().Trim(); //关系表的关系字段Id
objPrjTabRelationEN.ForeignKeyTabId = objRow[conPrjTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabRelationEN.ForeignKeyFldId = objRow[conPrjTabRelation.ForeignKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objPrjTabRelationEN.IsCheckCurrData = TransNullToBool(objRow[conPrjTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objPrjTabRelationEN.IsCopyForceRela = TransNullToBool(objRow[conPrjTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objPrjTabRelationEN.IsUpdRelateFld = TransNullToBool(objRow[conPrjTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objPrjTabRelationEN.IsUpdMainTabDate = TransNullToBool(objRow[conPrjTabRelation.IsUpdMainTabDate].ToString().Trim()); //是否修改主表日期
objPrjTabRelationEN.IsRefreshMainTabCache = TransNullToBool(objRow[conPrjTabRelation.IsRefreshMainTabCache].ToString().Trim()); //是否刷新主表缓存
objPrjTabRelationEN.IsDelRelateRec = TransNullToBool(objRow[conPrjTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objPrjTabRelationEN.PrjId = objRow[conPrjTabRelation.PrjId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrjId].ToString().Trim(); //工程Id
objPrjTabRelationEN.Memo = objRow[conPrjTabRelation.Memo] == DBNull.Value ? null : objRow[conPrjTabRelation.Memo].ToString().Trim(); //说明
objPrjTabRelationEN.PrimaryKeyTabId = objRow[conPrjTabRelation.PrimaryKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objPrjTabRelationEN.PrimaryKeyFldId = objRow[conPrjTabRelation.PrimaryKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPrjTabRelationDA: GetObjByDataRowPrjTabRelation)", objException.Message));
}
objPrjTabRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjTabRelationEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPrjTabRelationEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjTabRelationEN objPrjTabRelationEN = new clsPrjTabRelationEN();
try
{
objPrjTabRelationEN.PrjRelationId = objRow[conPrjTabRelation.PrjRelationId].ToString().Trim(); //关系Id
objPrjTabRelationEN.RelationName = objRow[conPrjTabRelation.RelationName].ToString().Trim(); //关系名
objPrjTabRelationEN.TabId = objRow[conPrjTabRelation.TabId].ToString().Trim(); //表ID
objPrjTabRelationEN.PrjTabRelaTypeId = objRow[conPrjTabRelation.PrjTabRelaTypeId].ToString().Trim(); //表关系类型Id
objPrjTabRelationEN.DnPathId = objRow[conPrjTabRelation.DnPathId] == DBNull.Value ? null : objRow[conPrjTabRelation.DnPathId].ToString().Trim(); //DN路径Id
objPrjTabRelationEN.RelationTabId = objRow[conPrjTabRelation.RelationTabId].ToString().Trim(); //相关表Id
objPrjTabRelationEN.FldId4TabId = objRow[conPrjTabRelation.FldId4TabId].ToString().Trim(); //当前表的关系字段Id
objPrjTabRelationEN.FldId4RelaTabId = objRow[conPrjTabRelation.FldId4RelaTabId].ToString().Trim(); //关系表的关系字段Id
objPrjTabRelationEN.ForeignKeyTabId = objRow[conPrjTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objPrjTabRelationEN.ForeignKeyFldId = objRow[conPrjTabRelation.ForeignKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objPrjTabRelationEN.IsCheckCurrData = TransNullToBool(objRow[conPrjTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objPrjTabRelationEN.IsCopyForceRela = TransNullToBool(objRow[conPrjTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objPrjTabRelationEN.IsUpdRelateFld = TransNullToBool(objRow[conPrjTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objPrjTabRelationEN.IsUpdMainTabDate = TransNullToBool(objRow[conPrjTabRelation.IsUpdMainTabDate].ToString().Trim()); //是否修改主表日期
objPrjTabRelationEN.IsRefreshMainTabCache = TransNullToBool(objRow[conPrjTabRelation.IsRefreshMainTabCache].ToString().Trim()); //是否刷新主表缓存
objPrjTabRelationEN.IsDelRelateRec = TransNullToBool(objRow[conPrjTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objPrjTabRelationEN.PrjId = objRow[conPrjTabRelation.PrjId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrjId].ToString().Trim(); //工程Id
objPrjTabRelationEN.Memo = objRow[conPrjTabRelation.Memo] == DBNull.Value ? null : objRow[conPrjTabRelation.Memo].ToString().Trim(); //说明
objPrjTabRelationEN.PrimaryKeyTabId = objRow[conPrjTabRelation.PrimaryKeyTabId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objPrjTabRelationEN.PrimaryKeyFldId = objRow[conPrjTabRelation.PrimaryKeyFldId] == DBNull.Value ? null : objRow[conPrjTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPrjTabRelationDA: GetObjByDataRow)", objException.Message));
}
objPrjTabRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjTabRelationEN;
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
objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjTabRelationEN._CurrTabName, conPrjTabRelation.PrjRelationId, 8, "");
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
objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjTabRelationEN._CurrTabName, conPrjTabRelation.PrjRelationId, 8, strPrefix);
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
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PrjRelationId from PrjTabRelation where " + strCondition;
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
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PrjRelationId from PrjTabRelation where " + strCondition;
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
 /// <param name = "strPrjRelationId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strPrjRelationId)
{
CheckPrimaryKey(strPrjRelationId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjTabRelation", "PrjRelationId = " + "'"+ strPrjRelationId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPrjTabRelationDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjTabRelation", strCondition))
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
objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PrjTabRelation");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPrjTabRelationEN objPrjTabRelationEN)
 {
 if (objPrjTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjTabRelationEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabRelation where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjTabRelation");
objRow = objDS.Tables["PrjTabRelation"].NewRow();
objRow[conPrjTabRelation.PrjRelationId] = objPrjTabRelationEN.PrjRelationId; //关系Id
objRow[conPrjTabRelation.RelationName] = objPrjTabRelationEN.RelationName; //关系名
objRow[conPrjTabRelation.TabId] = objPrjTabRelationEN.TabId; //表ID
objRow[conPrjTabRelation.PrjTabRelaTypeId] = objPrjTabRelationEN.PrjTabRelaTypeId; //表关系类型Id
 if (objPrjTabRelationEN.DnPathId !=  "")
 {
objRow[conPrjTabRelation.DnPathId] = objPrjTabRelationEN.DnPathId; //DN路径Id
 }
objRow[conPrjTabRelation.RelationTabId] = objPrjTabRelationEN.RelationTabId; //相关表Id
objRow[conPrjTabRelation.FldId4TabId] = objPrjTabRelationEN.FldId4TabId; //当前表的关系字段Id
objRow[conPrjTabRelation.FldId4RelaTabId] = objPrjTabRelationEN.FldId4RelaTabId; //关系表的关系字段Id
 if (objPrjTabRelationEN.ForeignKeyTabId !=  "")
 {
objRow[conPrjTabRelation.ForeignKeyTabId] = objPrjTabRelationEN.ForeignKeyTabId; //外键表ID
 }
 if (objPrjTabRelationEN.ForeignKeyFldId !=  "")
 {
objRow[conPrjTabRelation.ForeignKeyFldId] = objPrjTabRelationEN.ForeignKeyFldId; //外键字段Id
 }
objRow[conPrjTabRelation.IsCheckCurrData] = objPrjTabRelationEN.IsCheckCurrData; //是否检查当前数据
objRow[conPrjTabRelation.IsCopyForceRela] = objPrjTabRelationEN.IsCopyForceRela; //IsCopyForceRela
objRow[conPrjTabRelation.IsUpdRelateFld] = objPrjTabRelationEN.IsUpdRelateFld; //是否修改关系字段
objRow[conPrjTabRelation.IsUpdMainTabDate] = objPrjTabRelationEN.IsUpdMainTabDate; //是否修改主表日期
objRow[conPrjTabRelation.IsRefreshMainTabCache] = objPrjTabRelationEN.IsRefreshMainTabCache; //是否刷新主表缓存
objRow[conPrjTabRelation.IsDelRelateRec] = objPrjTabRelationEN.IsDelRelateRec; //是否删除相关记录
 if (objPrjTabRelationEN.PrjId !=  "")
 {
objRow[conPrjTabRelation.PrjId] = objPrjTabRelationEN.PrjId; //工程Id
 }
 if (objPrjTabRelationEN.Memo !=  "")
 {
objRow[conPrjTabRelation.Memo] = objPrjTabRelationEN.Memo; //说明
 }
 if (objPrjTabRelationEN.PrimaryKeyTabId !=  "")
 {
objRow[conPrjTabRelation.PrimaryKeyTabId] = objPrjTabRelationEN.PrimaryKeyTabId; //PrimaryKeyTabId
 }
 if (objPrjTabRelationEN.PrimaryKeyFldId !=  "")
 {
objRow[conPrjTabRelation.PrimaryKeyFldId] = objPrjTabRelationEN.PrimaryKeyFldId; //PrimaryKeyFldId
 }
objDS.Tables[clsPrjTabRelationEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPrjTabRelationEN._CurrTabName);
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
 /// <param name = "objPrjTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjTabRelationEN objPrjTabRelationEN)
{
 if (objPrjTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjTabRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjTabRelationEN.PrjRelationId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrjRelationId);
 var strPrjRelationId = objPrjTabRelationEN.PrjRelationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjRelationId + "'");
 }
 
 if (objPrjTabRelationEN.RelationName !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.RelationName);
 var strRelationName = objPrjTabRelationEN.RelationName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationName + "'");
 }
 
 if (objPrjTabRelationEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.TabId);
 var strTabId = objPrjTabRelationEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objPrjTabRelationEN.PrjTabRelaTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrjTabRelaTypeId);
 var strPrjTabRelaTypeId = objPrjTabRelationEN.PrjTabRelaTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjTabRelaTypeId + "'");
 }
 
 if (objPrjTabRelationEN.DnPathId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.DnPathId);
 var strDnPathId = objPrjTabRelationEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathId + "'");
 }
 
 if (objPrjTabRelationEN.RelationTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.RelationTabId);
 var strRelationTabId = objPrjTabRelationEN.RelationTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationTabId + "'");
 }
 
 if (objPrjTabRelationEN.FldId4TabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.FldId4TabId);
 var strFldId4TabId = objPrjTabRelationEN.FldId4TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId4TabId + "'");
 }
 
 if (objPrjTabRelationEN.FldId4RelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.FldId4RelaTabId);
 var strFldId4RelaTabId = objPrjTabRelationEN.FldId4RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId4RelaTabId + "'");
 }
 
 if (objPrjTabRelationEN.ForeignKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.ForeignKeyTabId);
 var strForeignKeyTabId = objPrjTabRelationEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyTabId + "'");
 }
 
 if (objPrjTabRelationEN.ForeignKeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.ForeignKeyFldId);
 var strForeignKeyFldId = objPrjTabRelationEN.ForeignKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyFldId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsCheckCurrData);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsCheckCurrData  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsCopyForceRela);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsCopyForceRela  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsUpdRelateFld);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsUpdRelateFld  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsUpdMainTabDate);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsUpdMainTabDate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsRefreshMainTabCache);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsRefreshMainTabCache  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsDelRelateRec);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsDelRelateRec  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabRelationEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrjId);
 var strPrjId = objPrjTabRelationEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjTabRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.Memo);
 var strMemo = objPrjTabRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objPrjTabRelationEN.PrimaryKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrimaryKeyTabId);
 var strPrimaryKeyTabId = objPrjTabRelationEN.PrimaryKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyTabId + "'");
 }
 
 if (objPrjTabRelationEN.PrimaryKeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrimaryKeyFldId);
 var strPrimaryKeyFldId = objPrjTabRelationEN.PrimaryKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyFldId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjTabRelation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjTabRelationEN objPrjTabRelationEN)
{
 if (objPrjTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjTabRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjTabRelationEN.PrjRelationId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrjRelationId);
 var strPrjRelationId = objPrjTabRelationEN.PrjRelationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjRelationId + "'");
 }
 
 if (objPrjTabRelationEN.RelationName !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.RelationName);
 var strRelationName = objPrjTabRelationEN.RelationName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationName + "'");
 }
 
 if (objPrjTabRelationEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.TabId);
 var strTabId = objPrjTabRelationEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objPrjTabRelationEN.PrjTabRelaTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrjTabRelaTypeId);
 var strPrjTabRelaTypeId = objPrjTabRelationEN.PrjTabRelaTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjTabRelaTypeId + "'");
 }
 
 if (objPrjTabRelationEN.DnPathId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.DnPathId);
 var strDnPathId = objPrjTabRelationEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathId + "'");
 }
 
 if (objPrjTabRelationEN.RelationTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.RelationTabId);
 var strRelationTabId = objPrjTabRelationEN.RelationTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationTabId + "'");
 }
 
 if (objPrjTabRelationEN.FldId4TabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.FldId4TabId);
 var strFldId4TabId = objPrjTabRelationEN.FldId4TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId4TabId + "'");
 }
 
 if (objPrjTabRelationEN.FldId4RelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.FldId4RelaTabId);
 var strFldId4RelaTabId = objPrjTabRelationEN.FldId4RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId4RelaTabId + "'");
 }
 
 if (objPrjTabRelationEN.ForeignKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.ForeignKeyTabId);
 var strForeignKeyTabId = objPrjTabRelationEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyTabId + "'");
 }
 
 if (objPrjTabRelationEN.ForeignKeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.ForeignKeyFldId);
 var strForeignKeyFldId = objPrjTabRelationEN.ForeignKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyFldId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsCheckCurrData);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsCheckCurrData  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsCopyForceRela);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsCopyForceRela  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsUpdRelateFld);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsUpdRelateFld  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsUpdMainTabDate);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsUpdMainTabDate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsRefreshMainTabCache);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsRefreshMainTabCache  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsDelRelateRec);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsDelRelateRec  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabRelationEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrjId);
 var strPrjId = objPrjTabRelationEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjTabRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.Memo);
 var strMemo = objPrjTabRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objPrjTabRelationEN.PrimaryKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrimaryKeyTabId);
 var strPrimaryKeyTabId = objPrjTabRelationEN.PrimaryKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyTabId + "'");
 }
 
 if (objPrjTabRelationEN.PrimaryKeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrimaryKeyFldId);
 var strPrimaryKeyFldId = objPrjTabRelationEN.PrimaryKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyFldId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjTabRelation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objPrjTabRelationEN.PrjRelationId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjTabRelationEN objPrjTabRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPrjTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjTabRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjTabRelationEN.PrjRelationId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrjRelationId);
 var strPrjRelationId = objPrjTabRelationEN.PrjRelationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjRelationId + "'");
 }
 
 if (objPrjTabRelationEN.RelationName !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.RelationName);
 var strRelationName = objPrjTabRelationEN.RelationName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationName + "'");
 }
 
 if (objPrjTabRelationEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.TabId);
 var strTabId = objPrjTabRelationEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objPrjTabRelationEN.PrjTabRelaTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrjTabRelaTypeId);
 var strPrjTabRelaTypeId = objPrjTabRelationEN.PrjTabRelaTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjTabRelaTypeId + "'");
 }
 
 if (objPrjTabRelationEN.DnPathId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.DnPathId);
 var strDnPathId = objPrjTabRelationEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathId + "'");
 }
 
 if (objPrjTabRelationEN.RelationTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.RelationTabId);
 var strRelationTabId = objPrjTabRelationEN.RelationTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationTabId + "'");
 }
 
 if (objPrjTabRelationEN.FldId4TabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.FldId4TabId);
 var strFldId4TabId = objPrjTabRelationEN.FldId4TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId4TabId + "'");
 }
 
 if (objPrjTabRelationEN.FldId4RelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.FldId4RelaTabId);
 var strFldId4RelaTabId = objPrjTabRelationEN.FldId4RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId4RelaTabId + "'");
 }
 
 if (objPrjTabRelationEN.ForeignKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.ForeignKeyTabId);
 var strForeignKeyTabId = objPrjTabRelationEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyTabId + "'");
 }
 
 if (objPrjTabRelationEN.ForeignKeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.ForeignKeyFldId);
 var strForeignKeyFldId = objPrjTabRelationEN.ForeignKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyFldId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsCheckCurrData);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsCheckCurrData  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsCopyForceRela);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsCopyForceRela  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsUpdRelateFld);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsUpdRelateFld  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsUpdMainTabDate);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsUpdMainTabDate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsRefreshMainTabCache);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsRefreshMainTabCache  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsDelRelateRec);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsDelRelateRec  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabRelationEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrjId);
 var strPrjId = objPrjTabRelationEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjTabRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.Memo);
 var strMemo = objPrjTabRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objPrjTabRelationEN.PrimaryKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrimaryKeyTabId);
 var strPrimaryKeyTabId = objPrjTabRelationEN.PrimaryKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyTabId + "'");
 }
 
 if (objPrjTabRelationEN.PrimaryKeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrimaryKeyFldId);
 var strPrimaryKeyFldId = objPrjTabRelationEN.PrimaryKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyFldId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjTabRelation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objPrjTabRelationEN.PrjRelationId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjTabRelationEN objPrjTabRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPrjTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjTabRelationEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjTabRelationEN.PrjRelationId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrjRelationId);
 var strPrjRelationId = objPrjTabRelationEN.PrjRelationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjRelationId + "'");
 }
 
 if (objPrjTabRelationEN.RelationName !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.RelationName);
 var strRelationName = objPrjTabRelationEN.RelationName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationName + "'");
 }
 
 if (objPrjTabRelationEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.TabId);
 var strTabId = objPrjTabRelationEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objPrjTabRelationEN.PrjTabRelaTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrjTabRelaTypeId);
 var strPrjTabRelaTypeId = objPrjTabRelationEN.PrjTabRelaTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjTabRelaTypeId + "'");
 }
 
 if (objPrjTabRelationEN.DnPathId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.DnPathId);
 var strDnPathId = objPrjTabRelationEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnPathId + "'");
 }
 
 if (objPrjTabRelationEN.RelationTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.RelationTabId);
 var strRelationTabId = objPrjTabRelationEN.RelationTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationTabId + "'");
 }
 
 if (objPrjTabRelationEN.FldId4TabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.FldId4TabId);
 var strFldId4TabId = objPrjTabRelationEN.FldId4TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId4TabId + "'");
 }
 
 if (objPrjTabRelationEN.FldId4RelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.FldId4RelaTabId);
 var strFldId4RelaTabId = objPrjTabRelationEN.FldId4RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId4RelaTabId + "'");
 }
 
 if (objPrjTabRelationEN.ForeignKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.ForeignKeyTabId);
 var strForeignKeyTabId = objPrjTabRelationEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyTabId + "'");
 }
 
 if (objPrjTabRelationEN.ForeignKeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.ForeignKeyFldId);
 var strForeignKeyFldId = objPrjTabRelationEN.ForeignKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyFldId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsCheckCurrData);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsCheckCurrData  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsCopyForceRela);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsCopyForceRela  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsUpdRelateFld);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsUpdRelateFld  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsUpdMainTabDate);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsUpdMainTabDate  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsRefreshMainTabCache);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsRefreshMainTabCache  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTabRelation.IsDelRelateRec);
 arrValueListForInsert.Add("'" + (objPrjTabRelationEN.IsDelRelateRec  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabRelationEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrjId);
 var strPrjId = objPrjTabRelationEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjTabRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.Memo);
 var strMemo = objPrjTabRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objPrjTabRelationEN.PrimaryKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrimaryKeyTabId);
 var strPrimaryKeyTabId = objPrjTabRelationEN.PrimaryKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyTabId + "'");
 }
 
 if (objPrjTabRelationEN.PrimaryKeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTabRelation.PrimaryKeyFldId);
 var strPrimaryKeyFldId = objPrjTabRelationEN.PrimaryKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyFldId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjTabRelation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPrjTabRelations(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabRelation where PrjRelationId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjTabRelation");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strPrjRelationId = oRow[conPrjTabRelation.PrjRelationId].ToString().Trim();
if (IsExist(strPrjRelationId))
{
 string strResult = "关键字变量值为:" + string.Format("PrjRelationId = {0}", strPrjRelationId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPrjTabRelationEN._CurrTabName ].NewRow();
objRow[conPrjTabRelation.PrjRelationId] = oRow[conPrjTabRelation.PrjRelationId].ToString().Trim(); //关系Id
objRow[conPrjTabRelation.RelationName] = oRow[conPrjTabRelation.RelationName].ToString().Trim(); //关系名
objRow[conPrjTabRelation.TabId] = oRow[conPrjTabRelation.TabId].ToString().Trim(); //表ID
objRow[conPrjTabRelation.PrjTabRelaTypeId] = oRow[conPrjTabRelation.PrjTabRelaTypeId].ToString().Trim(); //表关系类型Id
objRow[conPrjTabRelation.DnPathId] = oRow[conPrjTabRelation.DnPathId].ToString().Trim(); //DN路径Id
objRow[conPrjTabRelation.RelationTabId] = oRow[conPrjTabRelation.RelationTabId].ToString().Trim(); //相关表Id
objRow[conPrjTabRelation.FldId4TabId] = oRow[conPrjTabRelation.FldId4TabId].ToString().Trim(); //当前表的关系字段Id
objRow[conPrjTabRelation.FldId4RelaTabId] = oRow[conPrjTabRelation.FldId4RelaTabId].ToString().Trim(); //关系表的关系字段Id
objRow[conPrjTabRelation.ForeignKeyTabId] = oRow[conPrjTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objRow[conPrjTabRelation.ForeignKeyFldId] = oRow[conPrjTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objRow[conPrjTabRelation.IsCheckCurrData] = oRow[conPrjTabRelation.IsCheckCurrData].ToString().Trim(); //是否检查当前数据
objRow[conPrjTabRelation.IsCopyForceRela] = oRow[conPrjTabRelation.IsCopyForceRela].ToString().Trim(); //IsCopyForceRela
objRow[conPrjTabRelation.IsUpdRelateFld] = oRow[conPrjTabRelation.IsUpdRelateFld].ToString().Trim(); //是否修改关系字段
objRow[conPrjTabRelation.IsUpdMainTabDate] = oRow[conPrjTabRelation.IsUpdMainTabDate].ToString().Trim(); //是否修改主表日期
objRow[conPrjTabRelation.IsRefreshMainTabCache] = oRow[conPrjTabRelation.IsRefreshMainTabCache].ToString().Trim(); //是否刷新主表缓存
objRow[conPrjTabRelation.IsDelRelateRec] = oRow[conPrjTabRelation.IsDelRelateRec].ToString().Trim(); //是否删除相关记录
objRow[conPrjTabRelation.PrjId] = oRow[conPrjTabRelation.PrjId].ToString().Trim(); //工程Id
objRow[conPrjTabRelation.Memo] = oRow[conPrjTabRelation.Memo].ToString().Trim(); //说明
objRow[conPrjTabRelation.PrimaryKeyTabId] = oRow[conPrjTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objRow[conPrjTabRelation.PrimaryKeyFldId] = oRow[conPrjTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
 objDS.Tables[clsPrjTabRelationEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPrjTabRelationEN._CurrTabName);
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
 /// <param name = "objPrjTabRelationEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPrjTabRelationEN objPrjTabRelationEN)
{
 if (objPrjTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjTabRelationEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from PrjTabRelation where PrjRelationId = " + "'"+ objPrjTabRelationEN.PrjRelationId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPrjTabRelationEN._CurrTabName);
if (objDS.Tables[clsPrjTabRelationEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PrjRelationId = " + "'"+ objPrjTabRelationEN.PrjRelationId+"'");
return false;
}
objRow = objDS.Tables[clsPrjTabRelationEN._CurrTabName].Rows[0];
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrjRelationId))
 {
objRow[conPrjTabRelation.PrjRelationId] = objPrjTabRelationEN.PrjRelationId; //关系Id
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.RelationName))
 {
objRow[conPrjTabRelation.RelationName] = objPrjTabRelationEN.RelationName; //关系名
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.TabId))
 {
objRow[conPrjTabRelation.TabId] = objPrjTabRelationEN.TabId; //表ID
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrjTabRelaTypeId))
 {
objRow[conPrjTabRelation.PrjTabRelaTypeId] = objPrjTabRelationEN.PrjTabRelaTypeId; //表关系类型Id
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.DnPathId))
 {
objRow[conPrjTabRelation.DnPathId] = objPrjTabRelationEN.DnPathId; //DN路径Id
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.RelationTabId))
 {
objRow[conPrjTabRelation.RelationTabId] = objPrjTabRelationEN.RelationTabId; //相关表Id
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.FldId4TabId))
 {
objRow[conPrjTabRelation.FldId4TabId] = objPrjTabRelationEN.FldId4TabId; //当前表的关系字段Id
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.FldId4RelaTabId))
 {
objRow[conPrjTabRelation.FldId4RelaTabId] = objPrjTabRelationEN.FldId4RelaTabId; //关系表的关系字段Id
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.ForeignKeyTabId))
 {
objRow[conPrjTabRelation.ForeignKeyTabId] = objPrjTabRelationEN.ForeignKeyTabId; //外键表ID
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.ForeignKeyFldId))
 {
objRow[conPrjTabRelation.ForeignKeyFldId] = objPrjTabRelationEN.ForeignKeyFldId; //外键字段Id
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsCheckCurrData))
 {
objRow[conPrjTabRelation.IsCheckCurrData] = objPrjTabRelationEN.IsCheckCurrData; //是否检查当前数据
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsCopyForceRela))
 {
objRow[conPrjTabRelation.IsCopyForceRela] = objPrjTabRelationEN.IsCopyForceRela; //IsCopyForceRela
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsUpdRelateFld))
 {
objRow[conPrjTabRelation.IsUpdRelateFld] = objPrjTabRelationEN.IsUpdRelateFld; //是否修改关系字段
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsUpdMainTabDate))
 {
objRow[conPrjTabRelation.IsUpdMainTabDate] = objPrjTabRelationEN.IsUpdMainTabDate; //是否修改主表日期
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsRefreshMainTabCache))
 {
objRow[conPrjTabRelation.IsRefreshMainTabCache] = objPrjTabRelationEN.IsRefreshMainTabCache; //是否刷新主表缓存
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsDelRelateRec))
 {
objRow[conPrjTabRelation.IsDelRelateRec] = objPrjTabRelationEN.IsDelRelateRec; //是否删除相关记录
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrjId))
 {
objRow[conPrjTabRelation.PrjId] = objPrjTabRelationEN.PrjId; //工程Id
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.Memo))
 {
objRow[conPrjTabRelation.Memo] = objPrjTabRelationEN.Memo; //说明
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrimaryKeyTabId))
 {
objRow[conPrjTabRelation.PrimaryKeyTabId] = objPrjTabRelationEN.PrimaryKeyTabId; //PrimaryKeyTabId
 }
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrimaryKeyFldId))
 {
objRow[conPrjTabRelation.PrimaryKeyFldId] = objPrjTabRelationEN.PrimaryKeyFldId; //PrimaryKeyFldId
 }
try
{
objDA.Update(objDS, clsPrjTabRelationEN._CurrTabName);
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
 /// <param name = "objPrjTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjTabRelationEN objPrjTabRelationEN)
{
 if (objPrjTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjTabRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PrjTabRelation Set ");
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.RelationName))
 {
 if (objPrjTabRelationEN.RelationName !=  null)
 {
 var strRelationName = objPrjTabRelationEN.RelationName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelationName, conPrjTabRelation.RelationName); //关系名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.RelationName); //关系名
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.TabId))
 {
 if (objPrjTabRelationEN.TabId !=  null)
 {
 var strTabId = objPrjTabRelationEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conPrjTabRelation.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.TabId); //表ID
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrjTabRelaTypeId))
 {
 if (objPrjTabRelationEN.PrjTabRelaTypeId !=  null)
 {
 var strPrjTabRelaTypeId = objPrjTabRelationEN.PrjTabRelaTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjTabRelaTypeId, conPrjTabRelation.PrjTabRelaTypeId); //表关系类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.PrjTabRelaTypeId); //表关系类型Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.DnPathId))
 {
 if (objPrjTabRelationEN.DnPathId !=  null)
 {
 var strDnPathId = objPrjTabRelationEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDnPathId, conPrjTabRelation.DnPathId); //DN路径Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.DnPathId); //DN路径Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.RelationTabId))
 {
 if (objPrjTabRelationEN.RelationTabId !=  null)
 {
 var strRelationTabId = objPrjTabRelationEN.RelationTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelationTabId, conPrjTabRelation.RelationTabId); //相关表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.RelationTabId); //相关表Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.FldId4TabId))
 {
 if (objPrjTabRelationEN.FldId4TabId !=  null)
 {
 var strFldId4TabId = objPrjTabRelationEN.FldId4TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId4TabId, conPrjTabRelation.FldId4TabId); //当前表的关系字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.FldId4TabId); //当前表的关系字段Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.FldId4RelaTabId))
 {
 if (objPrjTabRelationEN.FldId4RelaTabId !=  null)
 {
 var strFldId4RelaTabId = objPrjTabRelationEN.FldId4RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId4RelaTabId, conPrjTabRelation.FldId4RelaTabId); //关系表的关系字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.FldId4RelaTabId); //关系表的关系字段Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.ForeignKeyTabId))
 {
 if (objPrjTabRelationEN.ForeignKeyTabId !=  null)
 {
 var strForeignKeyTabId = objPrjTabRelationEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForeignKeyTabId, conPrjTabRelation.ForeignKeyTabId); //外键表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.ForeignKeyTabId); //外键表ID
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.ForeignKeyFldId))
 {
 if (objPrjTabRelationEN.ForeignKeyFldId !=  null)
 {
 var strForeignKeyFldId = objPrjTabRelationEN.ForeignKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForeignKeyFldId, conPrjTabRelation.ForeignKeyFldId); //外键字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.ForeignKeyFldId); //外键字段Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsCheckCurrData))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabRelationEN.IsCheckCurrData == true?"1":"0", conPrjTabRelation.IsCheckCurrData); //是否检查当前数据
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsCopyForceRela))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabRelationEN.IsCopyForceRela == true?"1":"0", conPrjTabRelation.IsCopyForceRela); //IsCopyForceRela
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsUpdRelateFld))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabRelationEN.IsUpdRelateFld == true?"1":"0", conPrjTabRelation.IsUpdRelateFld); //是否修改关系字段
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsUpdMainTabDate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabRelationEN.IsUpdMainTabDate == true?"1":"0", conPrjTabRelation.IsUpdMainTabDate); //是否修改主表日期
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsRefreshMainTabCache))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabRelationEN.IsRefreshMainTabCache == true?"1":"0", conPrjTabRelation.IsRefreshMainTabCache); //是否刷新主表缓存
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsDelRelateRec))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabRelationEN.IsDelRelateRec == true?"1":"0", conPrjTabRelation.IsDelRelateRec); //是否删除相关记录
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrjId))
 {
 if (objPrjTabRelationEN.PrjId !=  null)
 {
 var strPrjId = objPrjTabRelationEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conPrjTabRelation.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.PrjId); //工程Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.Memo))
 {
 if (objPrjTabRelationEN.Memo !=  null)
 {
 var strMemo = objPrjTabRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjTabRelation.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.Memo); //说明
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrimaryKeyTabId))
 {
 if (objPrjTabRelationEN.PrimaryKeyTabId !=  null)
 {
 var strPrimaryKeyTabId = objPrjTabRelationEN.PrimaryKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryKeyTabId, conPrjTabRelation.PrimaryKeyTabId); //PrimaryKeyTabId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.PrimaryKeyTabId); //PrimaryKeyTabId
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrimaryKeyFldId))
 {
 if (objPrjTabRelationEN.PrimaryKeyFldId !=  null)
 {
 var strPrimaryKeyFldId = objPrjTabRelationEN.PrimaryKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryKeyFldId, conPrjTabRelation.PrimaryKeyFldId); //PrimaryKeyFldId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.PrimaryKeyFldId); //PrimaryKeyFldId
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PrjRelationId = '{0}'", objPrjTabRelationEN.PrjRelationId); 
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
 /// <param name = "objPrjTabRelationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPrjTabRelationEN objPrjTabRelationEN, string strCondition)
{
 if (objPrjTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjTabRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjTabRelation Set ");
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.RelationName))
 {
 if (objPrjTabRelationEN.RelationName !=  null)
 {
 var strRelationName = objPrjTabRelationEN.RelationName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelationName = '{0}',", strRelationName); //关系名
 }
 else
 {
 sbSQL.Append(" RelationName = null,"); //关系名
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.TabId))
 {
 if (objPrjTabRelationEN.TabId !=  null)
 {
 var strTabId = objPrjTabRelationEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrjTabRelaTypeId))
 {
 if (objPrjTabRelationEN.PrjTabRelaTypeId !=  null)
 {
 var strPrjTabRelaTypeId = objPrjTabRelationEN.PrjTabRelaTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjTabRelaTypeId = '{0}',", strPrjTabRelaTypeId); //表关系类型Id
 }
 else
 {
 sbSQL.Append(" PrjTabRelaTypeId = null,"); //表关系类型Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.DnPathId))
 {
 if (objPrjTabRelationEN.DnPathId !=  null)
 {
 var strDnPathId = objPrjTabRelationEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DnPathId = '{0}',", strDnPathId); //DN路径Id
 }
 else
 {
 sbSQL.Append(" DnPathId = null,"); //DN路径Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.RelationTabId))
 {
 if (objPrjTabRelationEN.RelationTabId !=  null)
 {
 var strRelationTabId = objPrjTabRelationEN.RelationTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelationTabId = '{0}',", strRelationTabId); //相关表Id
 }
 else
 {
 sbSQL.Append(" RelationTabId = null,"); //相关表Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.FldId4TabId))
 {
 if (objPrjTabRelationEN.FldId4TabId !=  null)
 {
 var strFldId4TabId = objPrjTabRelationEN.FldId4TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId4TabId = '{0}',", strFldId4TabId); //当前表的关系字段Id
 }
 else
 {
 sbSQL.Append(" FldId4TabId = null,"); //当前表的关系字段Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.FldId4RelaTabId))
 {
 if (objPrjTabRelationEN.FldId4RelaTabId !=  null)
 {
 var strFldId4RelaTabId = objPrjTabRelationEN.FldId4RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId4RelaTabId = '{0}',", strFldId4RelaTabId); //关系表的关系字段Id
 }
 else
 {
 sbSQL.Append(" FldId4RelaTabId = null,"); //关系表的关系字段Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.ForeignKeyTabId))
 {
 if (objPrjTabRelationEN.ForeignKeyTabId !=  null)
 {
 var strForeignKeyTabId = objPrjTabRelationEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForeignKeyTabId = '{0}',", strForeignKeyTabId); //外键表ID
 }
 else
 {
 sbSQL.Append(" ForeignKeyTabId = null,"); //外键表ID
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.ForeignKeyFldId))
 {
 if (objPrjTabRelationEN.ForeignKeyFldId !=  null)
 {
 var strForeignKeyFldId = objPrjTabRelationEN.ForeignKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForeignKeyFldId = '{0}',", strForeignKeyFldId); //外键字段Id
 }
 else
 {
 sbSQL.Append(" ForeignKeyFldId = null,"); //外键字段Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsCheckCurrData))
 {
 sbSQL.AppendFormat(" IsCheckCurrData = '{0}',", objPrjTabRelationEN.IsCheckCurrData == true?"1":"0"); //是否检查当前数据
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsCopyForceRela))
 {
 sbSQL.AppendFormat(" IsCopyForceRela = '{0}',", objPrjTabRelationEN.IsCopyForceRela == true?"1":"0"); //IsCopyForceRela
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsUpdRelateFld))
 {
 sbSQL.AppendFormat(" IsUpdRelateFld = '{0}',", objPrjTabRelationEN.IsUpdRelateFld == true?"1":"0"); //是否修改关系字段
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsUpdMainTabDate))
 {
 sbSQL.AppendFormat(" IsUpdMainTabDate = '{0}',", objPrjTabRelationEN.IsUpdMainTabDate == true?"1":"0"); //是否修改主表日期
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsRefreshMainTabCache))
 {
 sbSQL.AppendFormat(" IsRefreshMainTabCache = '{0}',", objPrjTabRelationEN.IsRefreshMainTabCache == true?"1":"0"); //是否刷新主表缓存
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsDelRelateRec))
 {
 sbSQL.AppendFormat(" IsDelRelateRec = '{0}',", objPrjTabRelationEN.IsDelRelateRec == true?"1":"0"); //是否删除相关记录
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrjId))
 {
 if (objPrjTabRelationEN.PrjId !=  null)
 {
 var strPrjId = objPrjTabRelationEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.Memo))
 {
 if (objPrjTabRelationEN.Memo !=  null)
 {
 var strMemo = objPrjTabRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrimaryKeyTabId))
 {
 if (objPrjTabRelationEN.PrimaryKeyTabId !=  null)
 {
 var strPrimaryKeyTabId = objPrjTabRelationEN.PrimaryKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryKeyTabId = '{0}',", strPrimaryKeyTabId); //PrimaryKeyTabId
 }
 else
 {
 sbSQL.Append(" PrimaryKeyTabId = null,"); //PrimaryKeyTabId
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrimaryKeyFldId))
 {
 if (objPrjTabRelationEN.PrimaryKeyFldId !=  null)
 {
 var strPrimaryKeyFldId = objPrjTabRelationEN.PrimaryKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryKeyFldId = '{0}',", strPrimaryKeyFldId); //PrimaryKeyFldId
 }
 else
 {
 sbSQL.Append(" PrimaryKeyFldId = null,"); //PrimaryKeyFldId
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
 /// <param name = "objPrjTabRelationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPrjTabRelationEN objPrjTabRelationEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objPrjTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjTabRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjTabRelation Set ");
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.RelationName))
 {
 if (objPrjTabRelationEN.RelationName !=  null)
 {
 var strRelationName = objPrjTabRelationEN.RelationName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelationName = '{0}',", strRelationName); //关系名
 }
 else
 {
 sbSQL.Append(" RelationName = null,"); //关系名
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.TabId))
 {
 if (objPrjTabRelationEN.TabId !=  null)
 {
 var strTabId = objPrjTabRelationEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrjTabRelaTypeId))
 {
 if (objPrjTabRelationEN.PrjTabRelaTypeId !=  null)
 {
 var strPrjTabRelaTypeId = objPrjTabRelationEN.PrjTabRelaTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjTabRelaTypeId = '{0}',", strPrjTabRelaTypeId); //表关系类型Id
 }
 else
 {
 sbSQL.Append(" PrjTabRelaTypeId = null,"); //表关系类型Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.DnPathId))
 {
 if (objPrjTabRelationEN.DnPathId !=  null)
 {
 var strDnPathId = objPrjTabRelationEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DnPathId = '{0}',", strDnPathId); //DN路径Id
 }
 else
 {
 sbSQL.Append(" DnPathId = null,"); //DN路径Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.RelationTabId))
 {
 if (objPrjTabRelationEN.RelationTabId !=  null)
 {
 var strRelationTabId = objPrjTabRelationEN.RelationTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelationTabId = '{0}',", strRelationTabId); //相关表Id
 }
 else
 {
 sbSQL.Append(" RelationTabId = null,"); //相关表Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.FldId4TabId))
 {
 if (objPrjTabRelationEN.FldId4TabId !=  null)
 {
 var strFldId4TabId = objPrjTabRelationEN.FldId4TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId4TabId = '{0}',", strFldId4TabId); //当前表的关系字段Id
 }
 else
 {
 sbSQL.Append(" FldId4TabId = null,"); //当前表的关系字段Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.FldId4RelaTabId))
 {
 if (objPrjTabRelationEN.FldId4RelaTabId !=  null)
 {
 var strFldId4RelaTabId = objPrjTabRelationEN.FldId4RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId4RelaTabId = '{0}',", strFldId4RelaTabId); //关系表的关系字段Id
 }
 else
 {
 sbSQL.Append(" FldId4RelaTabId = null,"); //关系表的关系字段Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.ForeignKeyTabId))
 {
 if (objPrjTabRelationEN.ForeignKeyTabId !=  null)
 {
 var strForeignKeyTabId = objPrjTabRelationEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForeignKeyTabId = '{0}',", strForeignKeyTabId); //外键表ID
 }
 else
 {
 sbSQL.Append(" ForeignKeyTabId = null,"); //外键表ID
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.ForeignKeyFldId))
 {
 if (objPrjTabRelationEN.ForeignKeyFldId !=  null)
 {
 var strForeignKeyFldId = objPrjTabRelationEN.ForeignKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForeignKeyFldId = '{0}',", strForeignKeyFldId); //外键字段Id
 }
 else
 {
 sbSQL.Append(" ForeignKeyFldId = null,"); //外键字段Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsCheckCurrData))
 {
 sbSQL.AppendFormat(" IsCheckCurrData = '{0}',", objPrjTabRelationEN.IsCheckCurrData == true?"1":"0"); //是否检查当前数据
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsCopyForceRela))
 {
 sbSQL.AppendFormat(" IsCopyForceRela = '{0}',", objPrjTabRelationEN.IsCopyForceRela == true?"1":"0"); //IsCopyForceRela
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsUpdRelateFld))
 {
 sbSQL.AppendFormat(" IsUpdRelateFld = '{0}',", objPrjTabRelationEN.IsUpdRelateFld == true?"1":"0"); //是否修改关系字段
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsUpdMainTabDate))
 {
 sbSQL.AppendFormat(" IsUpdMainTabDate = '{0}',", objPrjTabRelationEN.IsUpdMainTabDate == true?"1":"0"); //是否修改主表日期
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsRefreshMainTabCache))
 {
 sbSQL.AppendFormat(" IsRefreshMainTabCache = '{0}',", objPrjTabRelationEN.IsRefreshMainTabCache == true?"1":"0"); //是否刷新主表缓存
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsDelRelateRec))
 {
 sbSQL.AppendFormat(" IsDelRelateRec = '{0}',", objPrjTabRelationEN.IsDelRelateRec == true?"1":"0"); //是否删除相关记录
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrjId))
 {
 if (objPrjTabRelationEN.PrjId !=  null)
 {
 var strPrjId = objPrjTabRelationEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.Memo))
 {
 if (objPrjTabRelationEN.Memo !=  null)
 {
 var strMemo = objPrjTabRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrimaryKeyTabId))
 {
 if (objPrjTabRelationEN.PrimaryKeyTabId !=  null)
 {
 var strPrimaryKeyTabId = objPrjTabRelationEN.PrimaryKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryKeyTabId = '{0}',", strPrimaryKeyTabId); //PrimaryKeyTabId
 }
 else
 {
 sbSQL.Append(" PrimaryKeyTabId = null,"); //PrimaryKeyTabId
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrimaryKeyFldId))
 {
 if (objPrjTabRelationEN.PrimaryKeyFldId !=  null)
 {
 var strPrimaryKeyFldId = objPrjTabRelationEN.PrimaryKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryKeyFldId = '{0}',", strPrimaryKeyFldId); //PrimaryKeyFldId
 }
 else
 {
 sbSQL.Append(" PrimaryKeyFldId = null,"); //PrimaryKeyFldId
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
 /// <param name = "objPrjTabRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjTabRelationEN objPrjTabRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objPrjTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjTabRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjTabRelation Set ");
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.RelationName))
 {
 if (objPrjTabRelationEN.RelationName !=  null)
 {
 var strRelationName = objPrjTabRelationEN.RelationName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelationName, conPrjTabRelation.RelationName); //关系名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.RelationName); //关系名
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.TabId))
 {
 if (objPrjTabRelationEN.TabId !=  null)
 {
 var strTabId = objPrjTabRelationEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conPrjTabRelation.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.TabId); //表ID
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrjTabRelaTypeId))
 {
 if (objPrjTabRelationEN.PrjTabRelaTypeId !=  null)
 {
 var strPrjTabRelaTypeId = objPrjTabRelationEN.PrjTabRelaTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjTabRelaTypeId, conPrjTabRelation.PrjTabRelaTypeId); //表关系类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.PrjTabRelaTypeId); //表关系类型Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.DnPathId))
 {
 if (objPrjTabRelationEN.DnPathId !=  null)
 {
 var strDnPathId = objPrjTabRelationEN.DnPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDnPathId, conPrjTabRelation.DnPathId); //DN路径Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.DnPathId); //DN路径Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.RelationTabId))
 {
 if (objPrjTabRelationEN.RelationTabId !=  null)
 {
 var strRelationTabId = objPrjTabRelationEN.RelationTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelationTabId, conPrjTabRelation.RelationTabId); //相关表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.RelationTabId); //相关表Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.FldId4TabId))
 {
 if (objPrjTabRelationEN.FldId4TabId !=  null)
 {
 var strFldId4TabId = objPrjTabRelationEN.FldId4TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId4TabId, conPrjTabRelation.FldId4TabId); //当前表的关系字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.FldId4TabId); //当前表的关系字段Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.FldId4RelaTabId))
 {
 if (objPrjTabRelationEN.FldId4RelaTabId !=  null)
 {
 var strFldId4RelaTabId = objPrjTabRelationEN.FldId4RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId4RelaTabId, conPrjTabRelation.FldId4RelaTabId); //关系表的关系字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.FldId4RelaTabId); //关系表的关系字段Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.ForeignKeyTabId))
 {
 if (objPrjTabRelationEN.ForeignKeyTabId !=  null)
 {
 var strForeignKeyTabId = objPrjTabRelationEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForeignKeyTabId, conPrjTabRelation.ForeignKeyTabId); //外键表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.ForeignKeyTabId); //外键表ID
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.ForeignKeyFldId))
 {
 if (objPrjTabRelationEN.ForeignKeyFldId !=  null)
 {
 var strForeignKeyFldId = objPrjTabRelationEN.ForeignKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForeignKeyFldId, conPrjTabRelation.ForeignKeyFldId); //外键字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.ForeignKeyFldId); //外键字段Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsCheckCurrData))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabRelationEN.IsCheckCurrData == true?"1":"0", conPrjTabRelation.IsCheckCurrData); //是否检查当前数据
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsCopyForceRela))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabRelationEN.IsCopyForceRela == true?"1":"0", conPrjTabRelation.IsCopyForceRela); //IsCopyForceRela
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsUpdRelateFld))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabRelationEN.IsUpdRelateFld == true?"1":"0", conPrjTabRelation.IsUpdRelateFld); //是否修改关系字段
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsUpdMainTabDate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabRelationEN.IsUpdMainTabDate == true?"1":"0", conPrjTabRelation.IsUpdMainTabDate); //是否修改主表日期
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsRefreshMainTabCache))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabRelationEN.IsRefreshMainTabCache == true?"1":"0", conPrjTabRelation.IsRefreshMainTabCache); //是否刷新主表缓存
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.IsDelRelateRec))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabRelationEN.IsDelRelateRec == true?"1":"0", conPrjTabRelation.IsDelRelateRec); //是否删除相关记录
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrjId))
 {
 if (objPrjTabRelationEN.PrjId !=  null)
 {
 var strPrjId = objPrjTabRelationEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conPrjTabRelation.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.PrjId); //工程Id
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.Memo))
 {
 if (objPrjTabRelationEN.Memo !=  null)
 {
 var strMemo = objPrjTabRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjTabRelation.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.Memo); //说明
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrimaryKeyTabId))
 {
 if (objPrjTabRelationEN.PrimaryKeyTabId !=  null)
 {
 var strPrimaryKeyTabId = objPrjTabRelationEN.PrimaryKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryKeyTabId, conPrjTabRelation.PrimaryKeyTabId); //PrimaryKeyTabId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.PrimaryKeyTabId); //PrimaryKeyTabId
 }
 }
 
 if (objPrjTabRelationEN.IsUpdated(conPrjTabRelation.PrimaryKeyFldId))
 {
 if (objPrjTabRelationEN.PrimaryKeyFldId !=  null)
 {
 var strPrimaryKeyFldId = objPrjTabRelationEN.PrimaryKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryKeyFldId, conPrjTabRelation.PrimaryKeyFldId); //PrimaryKeyFldId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTabRelation.PrimaryKeyFldId); //PrimaryKeyFldId
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PrjRelationId = '{0}'", objPrjTabRelationEN.PrjRelationId); 
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
 /// <param name = "strPrjRelationId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strPrjRelationId) 
{
CheckPrimaryKey(strPrjRelationId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strPrjRelationId,
};
 objSQL.ExecSP("PrjTabRelation_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strPrjRelationId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strPrjRelationId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strPrjRelationId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
//删除PrjTabRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjTabRelation where PrjRelationId = " + "'"+ strPrjRelationId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPrjTabRelation(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
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
//删除PrjTabRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjTabRelation where PrjRelationId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strPrjRelationId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strPrjRelationId) 
{
CheckPrimaryKey(strPrjRelationId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
//删除PrjTabRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjTabRelation where PrjRelationId = " + "'"+ strPrjRelationId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPrjTabRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPrjTabRelationDA: DelPrjTabRelation)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjTabRelation where " + strCondition ;
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
public bool DelPrjTabRelationWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPrjTabRelationDA: DelPrjTabRelationWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjTabRelation where " + strCondition ;
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
 /// <param name = "objPrjTabRelationENS">源对象</param>
 /// <param name = "objPrjTabRelationENT">目标对象</param>
public void CopyTo(clsPrjTabRelationEN objPrjTabRelationENS, clsPrjTabRelationEN objPrjTabRelationENT)
{
objPrjTabRelationENT.PrjRelationId = objPrjTabRelationENS.PrjRelationId; //关系Id
objPrjTabRelationENT.RelationName = objPrjTabRelationENS.RelationName; //关系名
objPrjTabRelationENT.TabId = objPrjTabRelationENS.TabId; //表ID
objPrjTabRelationENT.PrjTabRelaTypeId = objPrjTabRelationENS.PrjTabRelaTypeId; //表关系类型Id
objPrjTabRelationENT.DnPathId = objPrjTabRelationENS.DnPathId; //DN路径Id
objPrjTabRelationENT.RelationTabId = objPrjTabRelationENS.RelationTabId; //相关表Id
objPrjTabRelationENT.FldId4TabId = objPrjTabRelationENS.FldId4TabId; //当前表的关系字段Id
objPrjTabRelationENT.FldId4RelaTabId = objPrjTabRelationENS.FldId4RelaTabId; //关系表的关系字段Id
objPrjTabRelationENT.ForeignKeyTabId = objPrjTabRelationENS.ForeignKeyTabId; //外键表ID
objPrjTabRelationENT.ForeignKeyFldId = objPrjTabRelationENS.ForeignKeyFldId; //外键字段Id
objPrjTabRelationENT.IsCheckCurrData = objPrjTabRelationENS.IsCheckCurrData; //是否检查当前数据
objPrjTabRelationENT.IsCopyForceRela = objPrjTabRelationENS.IsCopyForceRela; //IsCopyForceRela
objPrjTabRelationENT.IsUpdRelateFld = objPrjTabRelationENS.IsUpdRelateFld; //是否修改关系字段
objPrjTabRelationENT.IsUpdMainTabDate = objPrjTabRelationENS.IsUpdMainTabDate; //是否修改主表日期
objPrjTabRelationENT.IsRefreshMainTabCache = objPrjTabRelationENS.IsRefreshMainTabCache; //是否刷新主表缓存
objPrjTabRelationENT.IsDelRelateRec = objPrjTabRelationENS.IsDelRelateRec; //是否删除相关记录
objPrjTabRelationENT.PrjId = objPrjTabRelationENS.PrjId; //工程Id
objPrjTabRelationENT.Memo = objPrjTabRelationENS.Memo; //说明
objPrjTabRelationENT.PrimaryKeyTabId = objPrjTabRelationENS.PrimaryKeyTabId; //PrimaryKeyTabId
objPrjTabRelationENT.PrimaryKeyFldId = objPrjTabRelationENS.PrimaryKeyFldId; //PrimaryKeyFldId
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPrjTabRelationEN objPrjTabRelationEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPrjTabRelationEN.RelationName, conPrjTabRelation.RelationName);
clsCheckSql.CheckFieldNotNull(objPrjTabRelationEN.TabId, conPrjTabRelation.TabId);
clsCheckSql.CheckFieldNotNull(objPrjTabRelationEN.PrjTabRelaTypeId, conPrjTabRelation.PrjTabRelaTypeId);
clsCheckSql.CheckFieldNotNull(objPrjTabRelationEN.RelationTabId, conPrjTabRelation.RelationTabId);
clsCheckSql.CheckFieldNotNull(objPrjTabRelationEN.FldId4TabId, conPrjTabRelation.FldId4TabId);
clsCheckSql.CheckFieldNotNull(objPrjTabRelationEN.FldId4RelaTabId, conPrjTabRelation.FldId4RelaTabId);
clsCheckSql.CheckFieldNotNull(objPrjTabRelationEN.IsCheckCurrData, conPrjTabRelation.IsCheckCurrData);
clsCheckSql.CheckFieldNotNull(objPrjTabRelationEN.IsCopyForceRela, conPrjTabRelation.IsCopyForceRela);
clsCheckSql.CheckFieldNotNull(objPrjTabRelationEN.IsUpdRelateFld, conPrjTabRelation.IsUpdRelateFld);
clsCheckSql.CheckFieldNotNull(objPrjTabRelationEN.IsUpdMainTabDate, conPrjTabRelation.IsUpdMainTabDate);
clsCheckSql.CheckFieldNotNull(objPrjTabRelationEN.IsDelRelateRec, conPrjTabRelation.IsDelRelateRec);
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.PrjRelationId, 8, conPrjTabRelation.PrjRelationId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.RelationName, 40, conPrjTabRelation.RelationName);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.TabId, 8, conPrjTabRelation.TabId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.PrjTabRelaTypeId, 2, conPrjTabRelation.PrjTabRelaTypeId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.DnPathId, 8, conPrjTabRelation.DnPathId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.RelationTabId, 8, conPrjTabRelation.RelationTabId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.FldId4TabId, 8, conPrjTabRelation.FldId4TabId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.FldId4RelaTabId, 8, conPrjTabRelation.FldId4RelaTabId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.ForeignKeyTabId, 8, conPrjTabRelation.ForeignKeyTabId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.ForeignKeyFldId, 8, conPrjTabRelation.ForeignKeyFldId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.PrjId, 4, conPrjTabRelation.PrjId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.Memo, 1000, conPrjTabRelation.Memo);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.PrimaryKeyTabId, 8, conPrjTabRelation.PrimaryKeyTabId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.PrimaryKeyFldId, 8, conPrjTabRelation.PrimaryKeyFldId);
//检查字段外键固定长度
 objPrjTabRelationEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPrjTabRelationEN objPrjTabRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.RelationName, 40, conPrjTabRelation.RelationName);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.TabId, 8, conPrjTabRelation.TabId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.PrjTabRelaTypeId, 2, conPrjTabRelation.PrjTabRelaTypeId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.DnPathId, 8, conPrjTabRelation.DnPathId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.RelationTabId, 8, conPrjTabRelation.RelationTabId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.FldId4TabId, 8, conPrjTabRelation.FldId4TabId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.FldId4RelaTabId, 8, conPrjTabRelation.FldId4RelaTabId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.ForeignKeyTabId, 8, conPrjTabRelation.ForeignKeyTabId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.ForeignKeyFldId, 8, conPrjTabRelation.ForeignKeyFldId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.PrjId, 4, conPrjTabRelation.PrjId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.Memo, 1000, conPrjTabRelation.Memo);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.PrimaryKeyTabId, 8, conPrjTabRelation.PrimaryKeyTabId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.PrimaryKeyFldId, 8, conPrjTabRelation.PrimaryKeyFldId);
//检查外键字段长度
 objPrjTabRelationEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPrjTabRelationEN objPrjTabRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.PrjRelationId, 8, conPrjTabRelation.PrjRelationId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.RelationName, 40, conPrjTabRelation.RelationName);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.TabId, 8, conPrjTabRelation.TabId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.PrjTabRelaTypeId, 2, conPrjTabRelation.PrjTabRelaTypeId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.DnPathId, 8, conPrjTabRelation.DnPathId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.RelationTabId, 8, conPrjTabRelation.RelationTabId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.FldId4TabId, 8, conPrjTabRelation.FldId4TabId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.FldId4RelaTabId, 8, conPrjTabRelation.FldId4RelaTabId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.ForeignKeyTabId, 8, conPrjTabRelation.ForeignKeyTabId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.ForeignKeyFldId, 8, conPrjTabRelation.ForeignKeyFldId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.PrjId, 4, conPrjTabRelation.PrjId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.Memo, 1000, conPrjTabRelation.Memo);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.PrimaryKeyTabId, 8, conPrjTabRelation.PrimaryKeyTabId);
clsCheckSql.CheckFieldLen(objPrjTabRelationEN.PrimaryKeyFldId, 8, conPrjTabRelation.PrimaryKeyFldId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPrjTabRelationEN.PrjRelationId, conPrjTabRelation.PrjRelationId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabRelationEN.RelationName, conPrjTabRelation.RelationName);
clsCheckSql.CheckSqlInjection4Field(objPrjTabRelationEN.TabId, conPrjTabRelation.TabId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabRelationEN.PrjTabRelaTypeId, conPrjTabRelation.PrjTabRelaTypeId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabRelationEN.DnPathId, conPrjTabRelation.DnPathId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabRelationEN.RelationTabId, conPrjTabRelation.RelationTabId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabRelationEN.FldId4TabId, conPrjTabRelation.FldId4TabId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabRelationEN.FldId4RelaTabId, conPrjTabRelation.FldId4RelaTabId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabRelationEN.ForeignKeyTabId, conPrjTabRelation.ForeignKeyTabId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabRelationEN.ForeignKeyFldId, conPrjTabRelation.ForeignKeyFldId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabRelationEN.PrjId, conPrjTabRelation.PrjId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabRelationEN.Memo, conPrjTabRelation.Memo);
clsCheckSql.CheckSqlInjection4Field(objPrjTabRelationEN.PrimaryKeyTabId, conPrjTabRelation.PrimaryKeyTabId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabRelationEN.PrimaryKeyFldId, conPrjTabRelation.PrimaryKeyFldId);
//检查外键字段长度
 objPrjTabRelationEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetPrjRelationId()
{
//获取某学院所有专业信息
string strSQL = "select PrjRelationId, RelationName from PrjTabRelation ";
 clsSpecSQLforSql mySql = clsPrjTabRelationDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--PrjTabRelation(工程表关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjTabRelationEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsPrjTabRelationEN objPrjTabRelationEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objPrjTabRelationEN.TabId);
 sbCondition.AppendFormat(" and PrjTabRelaTypeId = '{0}'", objPrjTabRelationEN.PrjTabRelaTypeId);
 sbCondition.AppendFormat(" and RelationTabId = '{0}'", objPrjTabRelationEN.RelationTabId);
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
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
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
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
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
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjTabRelationEN._CurrTabName);
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
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjTabRelationEN._CurrTabName, strCondition);
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
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
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
 objSQL = clsPrjTabRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}