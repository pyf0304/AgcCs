
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabRelationDA
 表名:TabRelation(00050086)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:57
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// TabRelation(TabRelation)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsTabRelationDA : clsCommBase4DA
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
 return clsTabRelationEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsTabRelationEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTabRelationEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsTabRelationEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsTabRelationEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strRelationId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strRelationId)
{
strRelationId = strRelationId.Replace("'", "''");
if (strRelationId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:TabRelation中,检查关键字,长度不正确!(clsTabRelationDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strRelationId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:TabRelation中,关键字不能为空 或 null!(clsTabRelationDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRelationId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsTabRelationDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsTabRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from TabRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_TabRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsTabRelationDA: GetDataTable_TabRelation)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from TabRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsTabRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsTabRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from TabRelation where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsTabRelationDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsTabRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TabRelation where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TabRelation where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsTabRelationDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TabRelation where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsTabRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} TabRelation.* " + 
$"from TabRelation " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and TabRelation.RelationId not in " + 
$"(Select top {intTop_In} TabRelation.RelationId from TabRelation " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TabRelation where {1} and RelationId not in (Select top {2} RelationId from TabRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TabRelation where {1} and RelationId not in (Select top {3} RelationId from TabRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsTabRelationDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} TabRelation.* " + 
$"from TabRelation " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and TabRelation.RelationId not in " + 
$"(Select top {intTop_In} TabRelation.RelationId from TabRelation " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TabRelation where {1} and RelationId not in (Select top {2} RelationId from TabRelation where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TabRelation where {1} and RelationId not in (Select top {3} RelationId from TabRelation where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsTabRelationEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsTabRelationDA:GetObjLst)", objException.Message));
}
List<clsTabRelationEN> arrObjLst = new List<clsTabRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from TabRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabRelationEN objTabRelationEN = new clsTabRelationEN();
try
{
objTabRelationEN.RelationId = objRow[conTabRelation.RelationId].ToString().Trim(); //RelationId
objTabRelationEN.RelationName = objRow[conTabRelation.RelationName].ToString().Trim(); //关系名
objTabRelationEN.TabRelationTypeId = objRow[conTabRelation.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objTabRelationEN.PrimaryKeyTabId = objRow[conTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objTabRelationEN.PrimaryKeyFldId = objRow[conTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
objTabRelationEN.ForeignKeyTabId = objRow[conTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabRelationEN.ForeignKeyFldId = objRow[conTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objTabRelationEN.IsCheckCurrData = TransNullToBool(objRow[conTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objTabRelationEN.IsCopyForceRela = TransNullToBool(objRow[conTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objTabRelationEN.IsUpdRelateFld = TransNullToBool(objRow[conTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objTabRelationEN.IsDelRelateRec = TransNullToBool(objRow[conTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objTabRelationEN.Memo = objRow[conTabRelation.Memo] == DBNull.Value ? null : objRow[conTabRelation.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTabRelationDA: GetObjLst)", objException.Message));
}
objTabRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTabRelationEN);
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
public List<clsTabRelationEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsTabRelationDA:GetObjLstByTabName)", objException.Message));
}
List<clsTabRelationEN> arrObjLst = new List<clsTabRelationEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabRelationEN objTabRelationEN = new clsTabRelationEN();
try
{
objTabRelationEN.RelationId = objRow[conTabRelation.RelationId].ToString().Trim(); //RelationId
objTabRelationEN.RelationName = objRow[conTabRelation.RelationName].ToString().Trim(); //关系名
objTabRelationEN.TabRelationTypeId = objRow[conTabRelation.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objTabRelationEN.PrimaryKeyTabId = objRow[conTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objTabRelationEN.PrimaryKeyFldId = objRow[conTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
objTabRelationEN.ForeignKeyTabId = objRow[conTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabRelationEN.ForeignKeyFldId = objRow[conTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objTabRelationEN.IsCheckCurrData = TransNullToBool(objRow[conTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objTabRelationEN.IsCopyForceRela = TransNullToBool(objRow[conTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objTabRelationEN.IsUpdRelateFld = TransNullToBool(objRow[conTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objTabRelationEN.IsDelRelateRec = TransNullToBool(objRow[conTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objTabRelationEN.Memo = objRow[conTabRelation.Memo] == DBNull.Value ? null : objRow[conTabRelation.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTabRelationDA: GetObjLst)", objException.Message));
}
objTabRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTabRelationEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objTabRelationEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTabRelation(ref clsTabRelationEN objTabRelationEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from TabRelation where RelationId = " + "'"+ objTabRelationEN.RelationId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objTabRelationEN.RelationId = objDT.Rows[0][conTabRelation.RelationId].ToString().Trim(); //RelationId(字段类型:varchar,字段长度:8,是否可空:False)
 objTabRelationEN.RelationName = objDT.Rows[0][conTabRelation.RelationName].ToString().Trim(); //关系名(字段类型:varchar,字段长度:40,是否可空:False)
 objTabRelationEN.TabRelationTypeId = objDT.Rows[0][conTabRelation.TabRelationTypeId].ToString().Trim(); //表关系类型Id(字段类型:char,字段长度:2,是否可空:False)
 objTabRelationEN.PrimaryKeyTabId = objDT.Rows[0][conTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId(字段类型:varchar,字段长度:8,是否可空:False)
 objTabRelationEN.PrimaryKeyFldId = objDT.Rows[0][conTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId(字段类型:varchar,字段长度:8,是否可空:False)
 objTabRelationEN.ForeignKeyTabId = objDT.Rows[0][conTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID(字段类型:char,字段长度:8,是否可空:True)
 objTabRelationEN.ForeignKeyFldId = objDT.Rows[0][conTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id(字段类型:char,字段长度:8,是否可空:False)
 objTabRelationEN.IsCheckCurrData = TransNullToBool(objDT.Rows[0][conTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据(字段类型:bit,字段长度:1,是否可空:False)
 objTabRelationEN.IsCopyForceRela = TransNullToBool(objDT.Rows[0][conTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela(字段类型:bit,字段长度:1,是否可空:False)
 objTabRelationEN.IsUpdRelateFld = TransNullToBool(objDT.Rows[0][conTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段(字段类型:bit,字段长度:1,是否可空:False)
 objTabRelationEN.IsDelRelateRec = TransNullToBool(objDT.Rows[0][conTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录(字段类型:bit,字段长度:1,是否可空:False)
 objTabRelationEN.Memo = objDT.Rows[0][conTabRelation.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsTabRelationDA: GetTabRelation)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRelationId">表关键字</param>
 /// <returns>表对象</returns>
public clsTabRelationEN GetObjByRelationId(string strRelationId)
{
CheckPrimaryKey(strRelationId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from TabRelation where RelationId = " + "'"+ strRelationId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsTabRelationEN objTabRelationEN = new clsTabRelationEN();
try
{
 objTabRelationEN.RelationId = objRow[conTabRelation.RelationId].ToString().Trim(); //RelationId(字段类型:varchar,字段长度:8,是否可空:False)
 objTabRelationEN.RelationName = objRow[conTabRelation.RelationName].ToString().Trim(); //关系名(字段类型:varchar,字段长度:40,是否可空:False)
 objTabRelationEN.TabRelationTypeId = objRow[conTabRelation.TabRelationTypeId].ToString().Trim(); //表关系类型Id(字段类型:char,字段长度:2,是否可空:False)
 objTabRelationEN.PrimaryKeyTabId = objRow[conTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId(字段类型:varchar,字段长度:8,是否可空:False)
 objTabRelationEN.PrimaryKeyFldId = objRow[conTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId(字段类型:varchar,字段长度:8,是否可空:False)
 objTabRelationEN.ForeignKeyTabId = objRow[conTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID(字段类型:char,字段长度:8,是否可空:True)
 objTabRelationEN.ForeignKeyFldId = objRow[conTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id(字段类型:char,字段长度:8,是否可空:False)
 objTabRelationEN.IsCheckCurrData = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据(字段类型:bit,字段长度:1,是否可空:False)
 objTabRelationEN.IsCopyForceRela = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela(字段类型:bit,字段长度:1,是否可空:False)
 objTabRelationEN.IsUpdRelateFld = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段(字段类型:bit,字段长度:1,是否可空:False)
 objTabRelationEN.IsDelRelateRec = clsEntityBase2.TransNullToBool_S(objRow[conTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录(字段类型:bit,字段长度:1,是否可空:False)
 objTabRelationEN.Memo = objRow[conTabRelation.Memo] == DBNull.Value ? null : objRow[conTabRelation.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsTabRelationDA: GetObjByRelationId)", objException.Message));
}
return objTabRelationEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTabRelationEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsTabRelationDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from TabRelation where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsTabRelationEN objTabRelationEN = new clsTabRelationEN()
{
RelationId = objRow[conTabRelation.RelationId].ToString().Trim(), //RelationId
RelationName = objRow[conTabRelation.RelationName].ToString().Trim(), //关系名
TabRelationTypeId = objRow[conTabRelation.TabRelationTypeId].ToString().Trim(), //表关系类型Id
PrimaryKeyTabId = objRow[conTabRelation.PrimaryKeyTabId].ToString().Trim(), //PrimaryKeyTabId
PrimaryKeyFldId = objRow[conTabRelation.PrimaryKeyFldId].ToString().Trim(), //PrimaryKeyFldId
ForeignKeyTabId = objRow[conTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabRelation.ForeignKeyTabId].ToString().Trim(), //外键表ID
ForeignKeyFldId = objRow[conTabRelation.ForeignKeyFldId].ToString().Trim(), //外键字段Id
IsCheckCurrData = TransNullToBool(objRow[conTabRelation.IsCheckCurrData].ToString().Trim()), //是否检查当前数据
IsCopyForceRela = TransNullToBool(objRow[conTabRelation.IsCopyForceRela].ToString().Trim()), //IsCopyForceRela
IsUpdRelateFld = TransNullToBool(objRow[conTabRelation.IsUpdRelateFld].ToString().Trim()), //是否修改关系字段
IsDelRelateRec = TransNullToBool(objRow[conTabRelation.IsDelRelateRec].ToString().Trim()), //是否删除相关记录
Memo = objRow[conTabRelation.Memo] == DBNull.Value ? null : objRow[conTabRelation.Memo].ToString().Trim() //说明
};
objTabRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTabRelationEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsTabRelationDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsTabRelationEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTabRelationEN objTabRelationEN = new clsTabRelationEN();
try
{
objTabRelationEN.RelationId = objRow[conTabRelation.RelationId].ToString().Trim(); //RelationId
objTabRelationEN.RelationName = objRow[conTabRelation.RelationName].ToString().Trim(); //关系名
objTabRelationEN.TabRelationTypeId = objRow[conTabRelation.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objTabRelationEN.PrimaryKeyTabId = objRow[conTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objTabRelationEN.PrimaryKeyFldId = objRow[conTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
objTabRelationEN.ForeignKeyTabId = objRow[conTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabRelationEN.ForeignKeyFldId = objRow[conTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objTabRelationEN.IsCheckCurrData = TransNullToBool(objRow[conTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objTabRelationEN.IsCopyForceRela = TransNullToBool(objRow[conTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objTabRelationEN.IsUpdRelateFld = TransNullToBool(objRow[conTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objTabRelationEN.IsDelRelateRec = TransNullToBool(objRow[conTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objTabRelationEN.Memo = objRow[conTabRelation.Memo] == DBNull.Value ? null : objRow[conTabRelation.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsTabRelationDA: GetObjByDataRowTabRelation)", objException.Message));
}
objTabRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTabRelationEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsTabRelationEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTabRelationEN objTabRelationEN = new clsTabRelationEN();
try
{
objTabRelationEN.RelationId = objRow[conTabRelation.RelationId].ToString().Trim(); //RelationId
objTabRelationEN.RelationName = objRow[conTabRelation.RelationName].ToString().Trim(); //关系名
objTabRelationEN.TabRelationTypeId = objRow[conTabRelation.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objTabRelationEN.PrimaryKeyTabId = objRow[conTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objTabRelationEN.PrimaryKeyFldId = objRow[conTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
objTabRelationEN.ForeignKeyTabId = objRow[conTabRelation.ForeignKeyTabId] == DBNull.Value ? null : objRow[conTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objTabRelationEN.ForeignKeyFldId = objRow[conTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objTabRelationEN.IsCheckCurrData = TransNullToBool(objRow[conTabRelation.IsCheckCurrData].ToString().Trim()); //是否检查当前数据
objTabRelationEN.IsCopyForceRela = TransNullToBool(objRow[conTabRelation.IsCopyForceRela].ToString().Trim()); //IsCopyForceRela
objTabRelationEN.IsUpdRelateFld = TransNullToBool(objRow[conTabRelation.IsUpdRelateFld].ToString().Trim()); //是否修改关系字段
objTabRelationEN.IsDelRelateRec = TransNullToBool(objRow[conTabRelation.IsDelRelateRec].ToString().Trim()); //是否删除相关记录
objTabRelationEN.Memo = objRow[conTabRelation.Memo] == DBNull.Value ? null : objRow[conTabRelation.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsTabRelationDA: GetObjByDataRow)", objException.Message));
}
objTabRelationEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTabRelationEN;
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
objSQL = clsTabRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTabRelationEN._CurrTabName, conTabRelation.RelationId, 8, "");
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
objSQL = clsTabRelationDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTabRelationEN._CurrTabName, conTabRelation.RelationId, 8, strPrefix);
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
 objSQL = clsTabRelationDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select RelationId from TabRelation where " + strCondition;
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
 objSQL = clsTabRelationDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select RelationId from TabRelation where " + strCondition;
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
 /// <param name = "strRelationId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strRelationId)
{
CheckPrimaryKey(strRelationId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TabRelation", "RelationId = " + "'"+ strRelationId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsTabRelationDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TabRelation", strCondition))
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
objSQL = clsTabRelationDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("TabRelation");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsTabRelationEN objTabRelationEN)
 {
 if (objTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabRelationEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from TabRelation where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TabRelation");
objRow = objDS.Tables["TabRelation"].NewRow();
objRow[conTabRelation.RelationId] = objTabRelationEN.RelationId; //RelationId
objRow[conTabRelation.RelationName] = objTabRelationEN.RelationName; //关系名
objRow[conTabRelation.TabRelationTypeId] = objTabRelationEN.TabRelationTypeId; //表关系类型Id
objRow[conTabRelation.PrimaryKeyTabId] = objTabRelationEN.PrimaryKeyTabId; //PrimaryKeyTabId
objRow[conTabRelation.PrimaryKeyFldId] = objTabRelationEN.PrimaryKeyFldId; //PrimaryKeyFldId
 if (objTabRelationEN.ForeignKeyTabId !=  "")
 {
objRow[conTabRelation.ForeignKeyTabId] = objTabRelationEN.ForeignKeyTabId; //外键表ID
 }
objRow[conTabRelation.ForeignKeyFldId] = objTabRelationEN.ForeignKeyFldId; //外键字段Id
objRow[conTabRelation.IsCheckCurrData] = objTabRelationEN.IsCheckCurrData; //是否检查当前数据
objRow[conTabRelation.IsCopyForceRela] = objTabRelationEN.IsCopyForceRela; //IsCopyForceRela
objRow[conTabRelation.IsUpdRelateFld] = objTabRelationEN.IsUpdRelateFld; //是否修改关系字段
objRow[conTabRelation.IsDelRelateRec] = objTabRelationEN.IsDelRelateRec; //是否删除相关记录
 if (objTabRelationEN.Memo !=  "")
 {
objRow[conTabRelation.Memo] = objTabRelationEN.Memo; //说明
 }
objDS.Tables[clsTabRelationEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsTabRelationEN._CurrTabName);
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
 /// <param name = "objTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTabRelationEN objTabRelationEN)
{
 if (objTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTabRelationEN.RelationId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.RelationId);
 var strRelationId = objTabRelationEN.RelationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationId + "'");
 }
 
 if (objTabRelationEN.RelationName !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.RelationName);
 var strRelationName = objTabRelationEN.RelationName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationName + "'");
 }
 
 if (objTabRelationEN.TabRelationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.TabRelationTypeId);
 var strTabRelationTypeId = objTabRelationEN.TabRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabRelationTypeId + "'");
 }
 
 if (objTabRelationEN.PrimaryKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.PrimaryKeyTabId);
 var strPrimaryKeyTabId = objTabRelationEN.PrimaryKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyTabId + "'");
 }
 
 if (objTabRelationEN.PrimaryKeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.PrimaryKeyFldId);
 var strPrimaryKeyFldId = objTabRelationEN.PrimaryKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyFldId + "'");
 }
 
 if (objTabRelationEN.ForeignKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.ForeignKeyTabId);
 var strForeignKeyTabId = objTabRelationEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyTabId + "'");
 }
 
 if (objTabRelationEN.ForeignKeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.ForeignKeyFldId);
 var strForeignKeyFldId = objTabRelationEN.ForeignKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyFldId + "'");
 }
 
 arrFieldListForInsert.Add(conTabRelation.IsCheckCurrData);
 arrValueListForInsert.Add("'" + (objTabRelationEN.IsCheckCurrData  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabRelation.IsCopyForceRela);
 arrValueListForInsert.Add("'" + (objTabRelationEN.IsCopyForceRela  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabRelation.IsUpdRelateFld);
 arrValueListForInsert.Add("'" + (objTabRelationEN.IsUpdRelateFld  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabRelation.IsDelRelateRec);
 arrValueListForInsert.Add("'" + (objTabRelationEN.IsDelRelateRec  ==  false ? "0" : "1") + "'");
 
 if (objTabRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.Memo);
 var strMemo = objTabRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabRelation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTabRelationEN objTabRelationEN)
{
 if (objTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTabRelationEN.RelationId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.RelationId);
 var strRelationId = objTabRelationEN.RelationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationId + "'");
 }
 
 if (objTabRelationEN.RelationName !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.RelationName);
 var strRelationName = objTabRelationEN.RelationName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationName + "'");
 }
 
 if (objTabRelationEN.TabRelationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.TabRelationTypeId);
 var strTabRelationTypeId = objTabRelationEN.TabRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabRelationTypeId + "'");
 }
 
 if (objTabRelationEN.PrimaryKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.PrimaryKeyTabId);
 var strPrimaryKeyTabId = objTabRelationEN.PrimaryKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyTabId + "'");
 }
 
 if (objTabRelationEN.PrimaryKeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.PrimaryKeyFldId);
 var strPrimaryKeyFldId = objTabRelationEN.PrimaryKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyFldId + "'");
 }
 
 if (objTabRelationEN.ForeignKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.ForeignKeyTabId);
 var strForeignKeyTabId = objTabRelationEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyTabId + "'");
 }
 
 if (objTabRelationEN.ForeignKeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.ForeignKeyFldId);
 var strForeignKeyFldId = objTabRelationEN.ForeignKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyFldId + "'");
 }
 
 arrFieldListForInsert.Add(conTabRelation.IsCheckCurrData);
 arrValueListForInsert.Add("'" + (objTabRelationEN.IsCheckCurrData  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabRelation.IsCopyForceRela);
 arrValueListForInsert.Add("'" + (objTabRelationEN.IsCopyForceRela  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabRelation.IsUpdRelateFld);
 arrValueListForInsert.Add("'" + (objTabRelationEN.IsUpdRelateFld  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabRelation.IsDelRelateRec);
 arrValueListForInsert.Add("'" + (objTabRelationEN.IsDelRelateRec  ==  false ? "0" : "1") + "'");
 
 if (objTabRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.Memo);
 var strMemo = objTabRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabRelation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objTabRelationEN.RelationId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objTabRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTabRelationEN objTabRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabRelationEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTabRelationEN.RelationId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.RelationId);
 var strRelationId = objTabRelationEN.RelationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationId + "'");
 }
 
 if (objTabRelationEN.RelationName !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.RelationName);
 var strRelationName = objTabRelationEN.RelationName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationName + "'");
 }
 
 if (objTabRelationEN.TabRelationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.TabRelationTypeId);
 var strTabRelationTypeId = objTabRelationEN.TabRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabRelationTypeId + "'");
 }
 
 if (objTabRelationEN.PrimaryKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.PrimaryKeyTabId);
 var strPrimaryKeyTabId = objTabRelationEN.PrimaryKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyTabId + "'");
 }
 
 if (objTabRelationEN.PrimaryKeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.PrimaryKeyFldId);
 var strPrimaryKeyFldId = objTabRelationEN.PrimaryKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyFldId + "'");
 }
 
 if (objTabRelationEN.ForeignKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.ForeignKeyTabId);
 var strForeignKeyTabId = objTabRelationEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyTabId + "'");
 }
 
 if (objTabRelationEN.ForeignKeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.ForeignKeyFldId);
 var strForeignKeyFldId = objTabRelationEN.ForeignKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyFldId + "'");
 }
 
 arrFieldListForInsert.Add(conTabRelation.IsCheckCurrData);
 arrValueListForInsert.Add("'" + (objTabRelationEN.IsCheckCurrData  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabRelation.IsCopyForceRela);
 arrValueListForInsert.Add("'" + (objTabRelationEN.IsCopyForceRela  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabRelation.IsUpdRelateFld);
 arrValueListForInsert.Add("'" + (objTabRelationEN.IsUpdRelateFld  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabRelation.IsDelRelateRec);
 arrValueListForInsert.Add("'" + (objTabRelationEN.IsDelRelateRec  ==  false ? "0" : "1") + "'");
 
 if (objTabRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.Memo);
 var strMemo = objTabRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabRelation");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objTabRelationEN.RelationId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objTabRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTabRelationEN objTabRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabRelationEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTabRelationEN.RelationId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.RelationId);
 var strRelationId = objTabRelationEN.RelationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationId + "'");
 }
 
 if (objTabRelationEN.RelationName !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.RelationName);
 var strRelationName = objTabRelationEN.RelationName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationName + "'");
 }
 
 if (objTabRelationEN.TabRelationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.TabRelationTypeId);
 var strTabRelationTypeId = objTabRelationEN.TabRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabRelationTypeId + "'");
 }
 
 if (objTabRelationEN.PrimaryKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.PrimaryKeyTabId);
 var strPrimaryKeyTabId = objTabRelationEN.PrimaryKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyTabId + "'");
 }
 
 if (objTabRelationEN.PrimaryKeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.PrimaryKeyFldId);
 var strPrimaryKeyFldId = objTabRelationEN.PrimaryKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryKeyFldId + "'");
 }
 
 if (objTabRelationEN.ForeignKeyTabId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.ForeignKeyTabId);
 var strForeignKeyTabId = objTabRelationEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyTabId + "'");
 }
 
 if (objTabRelationEN.ForeignKeyFldId !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.ForeignKeyFldId);
 var strForeignKeyFldId = objTabRelationEN.ForeignKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeignKeyFldId + "'");
 }
 
 arrFieldListForInsert.Add(conTabRelation.IsCheckCurrData);
 arrValueListForInsert.Add("'" + (objTabRelationEN.IsCheckCurrData  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabRelation.IsCopyForceRela);
 arrValueListForInsert.Add("'" + (objTabRelationEN.IsCopyForceRela  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabRelation.IsUpdRelateFld);
 arrValueListForInsert.Add("'" + (objTabRelationEN.IsUpdRelateFld  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabRelation.IsDelRelateRec);
 arrValueListForInsert.Add("'" + (objTabRelationEN.IsDelRelateRec  ==  false ? "0" : "1") + "'");
 
 if (objTabRelationEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabRelation.Memo);
 var strMemo = objTabRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabRelation");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewTabRelations(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from TabRelation where RelationId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TabRelation");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strRelationId = oRow[conTabRelation.RelationId].ToString().Trim();
if (IsExist(strRelationId))
{
 string strResult = "关键字变量值为:" + string.Format("RelationId = {0}", strRelationId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsTabRelationEN._CurrTabName ].NewRow();
objRow[conTabRelation.RelationId] = oRow[conTabRelation.RelationId].ToString().Trim(); //RelationId
objRow[conTabRelation.RelationName] = oRow[conTabRelation.RelationName].ToString().Trim(); //关系名
objRow[conTabRelation.TabRelationTypeId] = oRow[conTabRelation.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objRow[conTabRelation.PrimaryKeyTabId] = oRow[conTabRelation.PrimaryKeyTabId].ToString().Trim(); //PrimaryKeyTabId
objRow[conTabRelation.PrimaryKeyFldId] = oRow[conTabRelation.PrimaryKeyFldId].ToString().Trim(); //PrimaryKeyFldId
objRow[conTabRelation.ForeignKeyTabId] = oRow[conTabRelation.ForeignKeyTabId].ToString().Trim(); //外键表ID
objRow[conTabRelation.ForeignKeyFldId] = oRow[conTabRelation.ForeignKeyFldId].ToString().Trim(); //外键字段Id
objRow[conTabRelation.IsCheckCurrData] = oRow[conTabRelation.IsCheckCurrData].ToString().Trim(); //是否检查当前数据
objRow[conTabRelation.IsCopyForceRela] = oRow[conTabRelation.IsCopyForceRela].ToString().Trim(); //IsCopyForceRela
objRow[conTabRelation.IsUpdRelateFld] = oRow[conTabRelation.IsUpdRelateFld].ToString().Trim(); //是否修改关系字段
objRow[conTabRelation.IsDelRelateRec] = oRow[conTabRelation.IsDelRelateRec].ToString().Trim(); //是否删除相关记录
objRow[conTabRelation.Memo] = oRow[conTabRelation.Memo].ToString().Trim(); //说明
 objDS.Tables[clsTabRelationEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsTabRelationEN._CurrTabName);
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
 /// <param name = "objTabRelationEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsTabRelationEN objTabRelationEN)
{
 if (objTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabRelationEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
strSQL = "Select * from TabRelation where RelationId = " + "'"+ objTabRelationEN.RelationId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsTabRelationEN._CurrTabName);
if (objDS.Tables[clsTabRelationEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:RelationId = " + "'"+ objTabRelationEN.RelationId+"'");
return false;
}
objRow = objDS.Tables[clsTabRelationEN._CurrTabName].Rows[0];
 if (objTabRelationEN.IsUpdated(conTabRelation.RelationId))
 {
objRow[conTabRelation.RelationId] = objTabRelationEN.RelationId; //RelationId
 }
 if (objTabRelationEN.IsUpdated(conTabRelation.RelationName))
 {
objRow[conTabRelation.RelationName] = objTabRelationEN.RelationName; //关系名
 }
 if (objTabRelationEN.IsUpdated(conTabRelation.TabRelationTypeId))
 {
objRow[conTabRelation.TabRelationTypeId] = objTabRelationEN.TabRelationTypeId; //表关系类型Id
 }
 if (objTabRelationEN.IsUpdated(conTabRelation.PrimaryKeyTabId))
 {
objRow[conTabRelation.PrimaryKeyTabId] = objTabRelationEN.PrimaryKeyTabId; //PrimaryKeyTabId
 }
 if (objTabRelationEN.IsUpdated(conTabRelation.PrimaryKeyFldId))
 {
objRow[conTabRelation.PrimaryKeyFldId] = objTabRelationEN.PrimaryKeyFldId; //PrimaryKeyFldId
 }
 if (objTabRelationEN.IsUpdated(conTabRelation.ForeignKeyTabId))
 {
objRow[conTabRelation.ForeignKeyTabId] = objTabRelationEN.ForeignKeyTabId; //外键表ID
 }
 if (objTabRelationEN.IsUpdated(conTabRelation.ForeignKeyFldId))
 {
objRow[conTabRelation.ForeignKeyFldId] = objTabRelationEN.ForeignKeyFldId; //外键字段Id
 }
 if (objTabRelationEN.IsUpdated(conTabRelation.IsCheckCurrData))
 {
objRow[conTabRelation.IsCheckCurrData] = objTabRelationEN.IsCheckCurrData; //是否检查当前数据
 }
 if (objTabRelationEN.IsUpdated(conTabRelation.IsCopyForceRela))
 {
objRow[conTabRelation.IsCopyForceRela] = objTabRelationEN.IsCopyForceRela; //IsCopyForceRela
 }
 if (objTabRelationEN.IsUpdated(conTabRelation.IsUpdRelateFld))
 {
objRow[conTabRelation.IsUpdRelateFld] = objTabRelationEN.IsUpdRelateFld; //是否修改关系字段
 }
 if (objTabRelationEN.IsUpdated(conTabRelation.IsDelRelateRec))
 {
objRow[conTabRelation.IsDelRelateRec] = objTabRelationEN.IsDelRelateRec; //是否删除相关记录
 }
 if (objTabRelationEN.IsUpdated(conTabRelation.Memo))
 {
objRow[conTabRelation.Memo] = objTabRelationEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsTabRelationEN._CurrTabName);
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
 /// <param name = "objTabRelationEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTabRelationEN objTabRelationEN)
{
 if (objTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update TabRelation Set ");
 
 if (objTabRelationEN.IsUpdated(conTabRelation.RelationName))
 {
 if (objTabRelationEN.RelationName !=  null)
 {
 var strRelationName = objTabRelationEN.RelationName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelationName, conTabRelation.RelationName); //关系名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabRelation.RelationName); //关系名
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.TabRelationTypeId))
 {
 if (objTabRelationEN.TabRelationTypeId !=  null)
 {
 var strTabRelationTypeId = objTabRelationEN.TabRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabRelationTypeId, conTabRelation.TabRelationTypeId); //表关系类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabRelation.TabRelationTypeId); //表关系类型Id
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.PrimaryKeyTabId))
 {
 if (objTabRelationEN.PrimaryKeyTabId !=  null)
 {
 var strPrimaryKeyTabId = objTabRelationEN.PrimaryKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryKeyTabId, conTabRelation.PrimaryKeyTabId); //PrimaryKeyTabId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabRelation.PrimaryKeyTabId); //PrimaryKeyTabId
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.PrimaryKeyFldId))
 {
 if (objTabRelationEN.PrimaryKeyFldId !=  null)
 {
 var strPrimaryKeyFldId = objTabRelationEN.PrimaryKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryKeyFldId, conTabRelation.PrimaryKeyFldId); //PrimaryKeyFldId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabRelation.PrimaryKeyFldId); //PrimaryKeyFldId
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.ForeignKeyTabId))
 {
 if (objTabRelationEN.ForeignKeyTabId !=  null)
 {
 var strForeignKeyTabId = objTabRelationEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForeignKeyTabId, conTabRelation.ForeignKeyTabId); //外键表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabRelation.ForeignKeyTabId); //外键表ID
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.ForeignKeyFldId))
 {
 if (objTabRelationEN.ForeignKeyFldId !=  null)
 {
 var strForeignKeyFldId = objTabRelationEN.ForeignKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForeignKeyFldId, conTabRelation.ForeignKeyFldId); //外键字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabRelation.ForeignKeyFldId); //外键字段Id
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.IsCheckCurrData))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabRelationEN.IsCheckCurrData == true?"1":"0", conTabRelation.IsCheckCurrData); //是否检查当前数据
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.IsCopyForceRela))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabRelationEN.IsCopyForceRela == true?"1":"0", conTabRelation.IsCopyForceRela); //IsCopyForceRela
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.IsUpdRelateFld))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabRelationEN.IsUpdRelateFld == true?"1":"0", conTabRelation.IsUpdRelateFld); //是否修改关系字段
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.IsDelRelateRec))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabRelationEN.IsDelRelateRec == true?"1":"0", conTabRelation.IsDelRelateRec); //是否删除相关记录
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.Memo))
 {
 if (objTabRelationEN.Memo !=  null)
 {
 var strMemo = objTabRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTabRelation.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabRelation.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RelationId = '{0}'", objTabRelationEN.RelationId); 
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
 /// <param name = "objTabRelationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsTabRelationEN objTabRelationEN, string strCondition)
{
 if (objTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TabRelation Set ");
 
 if (objTabRelationEN.IsUpdated(conTabRelation.RelationName))
 {
 if (objTabRelationEN.RelationName !=  null)
 {
 var strRelationName = objTabRelationEN.RelationName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelationName = '{0}',", strRelationName); //关系名
 }
 else
 {
 sbSQL.Append(" RelationName = null,"); //关系名
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.TabRelationTypeId))
 {
 if (objTabRelationEN.TabRelationTypeId !=  null)
 {
 var strTabRelationTypeId = objTabRelationEN.TabRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabRelationTypeId = '{0}',", strTabRelationTypeId); //表关系类型Id
 }
 else
 {
 sbSQL.Append(" TabRelationTypeId = null,"); //表关系类型Id
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.PrimaryKeyTabId))
 {
 if (objTabRelationEN.PrimaryKeyTabId !=  null)
 {
 var strPrimaryKeyTabId = objTabRelationEN.PrimaryKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryKeyTabId = '{0}',", strPrimaryKeyTabId); //PrimaryKeyTabId
 }
 else
 {
 sbSQL.Append(" PrimaryKeyTabId = null,"); //PrimaryKeyTabId
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.PrimaryKeyFldId))
 {
 if (objTabRelationEN.PrimaryKeyFldId !=  null)
 {
 var strPrimaryKeyFldId = objTabRelationEN.PrimaryKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryKeyFldId = '{0}',", strPrimaryKeyFldId); //PrimaryKeyFldId
 }
 else
 {
 sbSQL.Append(" PrimaryKeyFldId = null,"); //PrimaryKeyFldId
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.ForeignKeyTabId))
 {
 if (objTabRelationEN.ForeignKeyTabId !=  null)
 {
 var strForeignKeyTabId = objTabRelationEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForeignKeyTabId = '{0}',", strForeignKeyTabId); //外键表ID
 }
 else
 {
 sbSQL.Append(" ForeignKeyTabId = null,"); //外键表ID
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.ForeignKeyFldId))
 {
 if (objTabRelationEN.ForeignKeyFldId !=  null)
 {
 var strForeignKeyFldId = objTabRelationEN.ForeignKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForeignKeyFldId = '{0}',", strForeignKeyFldId); //外键字段Id
 }
 else
 {
 sbSQL.Append(" ForeignKeyFldId = null,"); //外键字段Id
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.IsCheckCurrData))
 {
 sbSQL.AppendFormat(" IsCheckCurrData = '{0}',", objTabRelationEN.IsCheckCurrData == true?"1":"0"); //是否检查当前数据
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.IsCopyForceRela))
 {
 sbSQL.AppendFormat(" IsCopyForceRela = '{0}',", objTabRelationEN.IsCopyForceRela == true?"1":"0"); //IsCopyForceRela
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.IsUpdRelateFld))
 {
 sbSQL.AppendFormat(" IsUpdRelateFld = '{0}',", objTabRelationEN.IsUpdRelateFld == true?"1":"0"); //是否修改关系字段
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.IsDelRelateRec))
 {
 sbSQL.AppendFormat(" IsDelRelateRec = '{0}',", objTabRelationEN.IsDelRelateRec == true?"1":"0"); //是否删除相关记录
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.Memo))
 {
 if (objTabRelationEN.Memo !=  null)
 {
 var strMemo = objTabRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTabRelationEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsTabRelationEN objTabRelationEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TabRelation Set ");
 
 if (objTabRelationEN.IsUpdated(conTabRelation.RelationName))
 {
 if (objTabRelationEN.RelationName !=  null)
 {
 var strRelationName = objTabRelationEN.RelationName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelationName = '{0}',", strRelationName); //关系名
 }
 else
 {
 sbSQL.Append(" RelationName = null,"); //关系名
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.TabRelationTypeId))
 {
 if (objTabRelationEN.TabRelationTypeId !=  null)
 {
 var strTabRelationTypeId = objTabRelationEN.TabRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabRelationTypeId = '{0}',", strTabRelationTypeId); //表关系类型Id
 }
 else
 {
 sbSQL.Append(" TabRelationTypeId = null,"); //表关系类型Id
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.PrimaryKeyTabId))
 {
 if (objTabRelationEN.PrimaryKeyTabId !=  null)
 {
 var strPrimaryKeyTabId = objTabRelationEN.PrimaryKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryKeyTabId = '{0}',", strPrimaryKeyTabId); //PrimaryKeyTabId
 }
 else
 {
 sbSQL.Append(" PrimaryKeyTabId = null,"); //PrimaryKeyTabId
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.PrimaryKeyFldId))
 {
 if (objTabRelationEN.PrimaryKeyFldId !=  null)
 {
 var strPrimaryKeyFldId = objTabRelationEN.PrimaryKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryKeyFldId = '{0}',", strPrimaryKeyFldId); //PrimaryKeyFldId
 }
 else
 {
 sbSQL.Append(" PrimaryKeyFldId = null,"); //PrimaryKeyFldId
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.ForeignKeyTabId))
 {
 if (objTabRelationEN.ForeignKeyTabId !=  null)
 {
 var strForeignKeyTabId = objTabRelationEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForeignKeyTabId = '{0}',", strForeignKeyTabId); //外键表ID
 }
 else
 {
 sbSQL.Append(" ForeignKeyTabId = null,"); //外键表ID
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.ForeignKeyFldId))
 {
 if (objTabRelationEN.ForeignKeyFldId !=  null)
 {
 var strForeignKeyFldId = objTabRelationEN.ForeignKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForeignKeyFldId = '{0}',", strForeignKeyFldId); //外键字段Id
 }
 else
 {
 sbSQL.Append(" ForeignKeyFldId = null,"); //外键字段Id
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.IsCheckCurrData))
 {
 sbSQL.AppendFormat(" IsCheckCurrData = '{0}',", objTabRelationEN.IsCheckCurrData == true?"1":"0"); //是否检查当前数据
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.IsCopyForceRela))
 {
 sbSQL.AppendFormat(" IsCopyForceRela = '{0}',", objTabRelationEN.IsCopyForceRela == true?"1":"0"); //IsCopyForceRela
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.IsUpdRelateFld))
 {
 sbSQL.AppendFormat(" IsUpdRelateFld = '{0}',", objTabRelationEN.IsUpdRelateFld == true?"1":"0"); //是否修改关系字段
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.IsDelRelateRec))
 {
 sbSQL.AppendFormat(" IsDelRelateRec = '{0}',", objTabRelationEN.IsDelRelateRec == true?"1":"0"); //是否删除相关记录
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.Memo))
 {
 if (objTabRelationEN.Memo !=  null)
 {
 var strMemo = objTabRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTabRelationEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTabRelationEN objTabRelationEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objTabRelationEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabRelationEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TabRelation Set ");
 
 if (objTabRelationEN.IsUpdated(conTabRelation.RelationName))
 {
 if (objTabRelationEN.RelationName !=  null)
 {
 var strRelationName = objTabRelationEN.RelationName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelationName, conTabRelation.RelationName); //关系名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabRelation.RelationName); //关系名
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.TabRelationTypeId))
 {
 if (objTabRelationEN.TabRelationTypeId !=  null)
 {
 var strTabRelationTypeId = objTabRelationEN.TabRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabRelationTypeId, conTabRelation.TabRelationTypeId); //表关系类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabRelation.TabRelationTypeId); //表关系类型Id
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.PrimaryKeyTabId))
 {
 if (objTabRelationEN.PrimaryKeyTabId !=  null)
 {
 var strPrimaryKeyTabId = objTabRelationEN.PrimaryKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryKeyTabId, conTabRelation.PrimaryKeyTabId); //PrimaryKeyTabId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabRelation.PrimaryKeyTabId); //PrimaryKeyTabId
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.PrimaryKeyFldId))
 {
 if (objTabRelationEN.PrimaryKeyFldId !=  null)
 {
 var strPrimaryKeyFldId = objTabRelationEN.PrimaryKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryKeyFldId, conTabRelation.PrimaryKeyFldId); //PrimaryKeyFldId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabRelation.PrimaryKeyFldId); //PrimaryKeyFldId
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.ForeignKeyTabId))
 {
 if (objTabRelationEN.ForeignKeyTabId !=  null)
 {
 var strForeignKeyTabId = objTabRelationEN.ForeignKeyTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForeignKeyTabId, conTabRelation.ForeignKeyTabId); //外键表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabRelation.ForeignKeyTabId); //外键表ID
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.ForeignKeyFldId))
 {
 if (objTabRelationEN.ForeignKeyFldId !=  null)
 {
 var strForeignKeyFldId = objTabRelationEN.ForeignKeyFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForeignKeyFldId, conTabRelation.ForeignKeyFldId); //外键字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabRelation.ForeignKeyFldId); //外键字段Id
 }
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.IsCheckCurrData))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabRelationEN.IsCheckCurrData == true?"1":"0", conTabRelation.IsCheckCurrData); //是否检查当前数据
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.IsCopyForceRela))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabRelationEN.IsCopyForceRela == true?"1":"0", conTabRelation.IsCopyForceRela); //IsCopyForceRela
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.IsUpdRelateFld))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabRelationEN.IsUpdRelateFld == true?"1":"0", conTabRelation.IsUpdRelateFld); //是否修改关系字段
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.IsDelRelateRec))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabRelationEN.IsDelRelateRec == true?"1":"0", conTabRelation.IsDelRelateRec); //是否删除相关记录
 }
 
 if (objTabRelationEN.IsUpdated(conTabRelation.Memo))
 {
 if (objTabRelationEN.Memo !=  null)
 {
 var strMemo = objTabRelationEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTabRelation.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabRelation.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RelationId = '{0}'", objTabRelationEN.RelationId); 
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
 /// <param name = "strRelationId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strRelationId) 
{
CheckPrimaryKey(strRelationId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strRelationId,
};
 objSQL.ExecSP("TabRelation_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strRelationId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strRelationId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strRelationId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
//删除TabRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TabRelation where RelationId = " + "'"+ strRelationId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelTabRelation(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
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
//删除TabRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TabRelation where RelationId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strRelationId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strRelationId) 
{
CheckPrimaryKey(strRelationId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
//删除TabRelation本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TabRelation where RelationId = " + "'"+ strRelationId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelTabRelation(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsTabRelationDA: DelTabRelation)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TabRelation where " + strCondition ;
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
public bool DelTabRelationWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsTabRelationDA: DelTabRelationWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabRelationDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TabRelation where " + strCondition ;
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
 /// <param name = "objTabRelationENS">源对象</param>
 /// <param name = "objTabRelationENT">目标对象</param>
public void CopyTo(clsTabRelationEN objTabRelationENS, clsTabRelationEN objTabRelationENT)
{
objTabRelationENT.RelationId = objTabRelationENS.RelationId; //RelationId
objTabRelationENT.RelationName = objTabRelationENS.RelationName; //关系名
objTabRelationENT.TabRelationTypeId = objTabRelationENS.TabRelationTypeId; //表关系类型Id
objTabRelationENT.PrimaryKeyTabId = objTabRelationENS.PrimaryKeyTabId; //PrimaryKeyTabId
objTabRelationENT.PrimaryKeyFldId = objTabRelationENS.PrimaryKeyFldId; //PrimaryKeyFldId
objTabRelationENT.ForeignKeyTabId = objTabRelationENS.ForeignKeyTabId; //外键表ID
objTabRelationENT.ForeignKeyFldId = objTabRelationENS.ForeignKeyFldId; //外键字段Id
objTabRelationENT.IsCheckCurrData = objTabRelationENS.IsCheckCurrData; //是否检查当前数据
objTabRelationENT.IsCopyForceRela = objTabRelationENS.IsCopyForceRela; //IsCopyForceRela
objTabRelationENT.IsUpdRelateFld = objTabRelationENS.IsUpdRelateFld; //是否修改关系字段
objTabRelationENT.IsDelRelateRec = objTabRelationENS.IsDelRelateRec; //是否删除相关记录
objTabRelationENT.Memo = objTabRelationENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsTabRelationEN objTabRelationEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objTabRelationEN.RelationName, conTabRelation.RelationName);
clsCheckSql.CheckFieldNotNull(objTabRelationEN.TabRelationTypeId, conTabRelation.TabRelationTypeId);
clsCheckSql.CheckFieldNotNull(objTabRelationEN.PrimaryKeyTabId, conTabRelation.PrimaryKeyTabId);
clsCheckSql.CheckFieldNotNull(objTabRelationEN.PrimaryKeyFldId, conTabRelation.PrimaryKeyFldId);
clsCheckSql.CheckFieldNotNull(objTabRelationEN.ForeignKeyFldId, conTabRelation.ForeignKeyFldId);
clsCheckSql.CheckFieldNotNull(objTabRelationEN.IsCheckCurrData, conTabRelation.IsCheckCurrData);
clsCheckSql.CheckFieldNotNull(objTabRelationEN.IsCopyForceRela, conTabRelation.IsCopyForceRela);
clsCheckSql.CheckFieldNotNull(objTabRelationEN.IsUpdRelateFld, conTabRelation.IsUpdRelateFld);
clsCheckSql.CheckFieldNotNull(objTabRelationEN.IsDelRelateRec, conTabRelation.IsDelRelateRec);
//检查字段长度
clsCheckSql.CheckFieldLen(objTabRelationEN.RelationId, 8, conTabRelation.RelationId);
clsCheckSql.CheckFieldLen(objTabRelationEN.RelationName, 40, conTabRelation.RelationName);
clsCheckSql.CheckFieldLen(objTabRelationEN.TabRelationTypeId, 2, conTabRelation.TabRelationTypeId);
clsCheckSql.CheckFieldLen(objTabRelationEN.PrimaryKeyTabId, 8, conTabRelation.PrimaryKeyTabId);
clsCheckSql.CheckFieldLen(objTabRelationEN.PrimaryKeyFldId, 8, conTabRelation.PrimaryKeyFldId);
clsCheckSql.CheckFieldLen(objTabRelationEN.ForeignKeyTabId, 8, conTabRelation.ForeignKeyTabId);
clsCheckSql.CheckFieldLen(objTabRelationEN.ForeignKeyFldId, 8, conTabRelation.ForeignKeyFldId);
clsCheckSql.CheckFieldLen(objTabRelationEN.Memo, 1000, conTabRelation.Memo);
//检查字段外键固定长度
 objTabRelationEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsTabRelationEN objTabRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTabRelationEN.RelationName, 40, conTabRelation.RelationName);
clsCheckSql.CheckFieldLen(objTabRelationEN.TabRelationTypeId, 2, conTabRelation.TabRelationTypeId);
clsCheckSql.CheckFieldLen(objTabRelationEN.PrimaryKeyTabId, 8, conTabRelation.PrimaryKeyTabId);
clsCheckSql.CheckFieldLen(objTabRelationEN.PrimaryKeyFldId, 8, conTabRelation.PrimaryKeyFldId);
clsCheckSql.CheckFieldLen(objTabRelationEN.ForeignKeyTabId, 8, conTabRelation.ForeignKeyTabId);
clsCheckSql.CheckFieldLen(objTabRelationEN.ForeignKeyFldId, 8, conTabRelation.ForeignKeyFldId);
clsCheckSql.CheckFieldLen(objTabRelationEN.Memo, 1000, conTabRelation.Memo);
//检查外键字段长度
 objTabRelationEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsTabRelationEN objTabRelationEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTabRelationEN.RelationId, 8, conTabRelation.RelationId);
clsCheckSql.CheckFieldLen(objTabRelationEN.RelationName, 40, conTabRelation.RelationName);
clsCheckSql.CheckFieldLen(objTabRelationEN.TabRelationTypeId, 2, conTabRelation.TabRelationTypeId);
clsCheckSql.CheckFieldLen(objTabRelationEN.PrimaryKeyTabId, 8, conTabRelation.PrimaryKeyTabId);
clsCheckSql.CheckFieldLen(objTabRelationEN.PrimaryKeyFldId, 8, conTabRelation.PrimaryKeyFldId);
clsCheckSql.CheckFieldLen(objTabRelationEN.ForeignKeyTabId, 8, conTabRelation.ForeignKeyTabId);
clsCheckSql.CheckFieldLen(objTabRelationEN.ForeignKeyFldId, 8, conTabRelation.ForeignKeyFldId);
clsCheckSql.CheckFieldLen(objTabRelationEN.Memo, 1000, conTabRelation.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objTabRelationEN.RelationId, conTabRelation.RelationId);
clsCheckSql.CheckSqlInjection4Field(objTabRelationEN.RelationName, conTabRelation.RelationName);
clsCheckSql.CheckSqlInjection4Field(objTabRelationEN.TabRelationTypeId, conTabRelation.TabRelationTypeId);
clsCheckSql.CheckSqlInjection4Field(objTabRelationEN.PrimaryKeyTabId, conTabRelation.PrimaryKeyTabId);
clsCheckSql.CheckSqlInjection4Field(objTabRelationEN.PrimaryKeyFldId, conTabRelation.PrimaryKeyFldId);
clsCheckSql.CheckSqlInjection4Field(objTabRelationEN.ForeignKeyTabId, conTabRelation.ForeignKeyTabId);
clsCheckSql.CheckSqlInjection4Field(objTabRelationEN.ForeignKeyFldId, conTabRelation.ForeignKeyFldId);
clsCheckSql.CheckSqlInjection4Field(objTabRelationEN.Memo, conTabRelation.Memo);
//检查外键字段长度
 objTabRelationEN._IsCheckProperty = true;
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
 objSQL = clsTabRelationDA.GetSpecSQLObj();
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
 objSQL = clsTabRelationDA.GetSpecSQLObj();
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
 objSQL = clsTabRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTabRelationEN._CurrTabName);
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
 objSQL = clsTabRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTabRelationEN._CurrTabName, strCondition);
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
 objSQL = clsTabRelationDA.GetSpecSQLObj();
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
 objSQL = clsTabRelationDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}