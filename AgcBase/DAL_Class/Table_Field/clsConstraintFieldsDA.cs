
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsConstraintFieldsDA
 表名:ConstraintFields(00050334)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:25
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
 /// 约束字段(ConstraintFields)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsConstraintFieldsDA : clsCommBase4DA
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
 return clsConstraintFieldsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsConstraintFieldsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsConstraintFieldsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsConstraintFieldsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsConstraintFieldsEN._ConnectString);
 }
 return objSQL;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsConstraintFieldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
strSQL = "Select * from ConstraintFields where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ConstraintFields(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsConstraintFieldsDA: GetDataTable_ConstraintFields)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
strSQL = "Select * from ConstraintFields where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsConstraintFieldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsConstraintFieldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
strSQL = "Select * from ConstraintFields where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsConstraintFieldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsConstraintFieldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ConstraintFields where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ConstraintFields where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsConstraintFieldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ConstraintFields where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsConstraintFieldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ConstraintFields.* " + 
$"from ConstraintFields " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ConstraintFields.mId not in " + 
$"(Select top {intTop_In} ConstraintFields.mId from ConstraintFields " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ConstraintFields where {1} and mId not in (Select top {2} mId from ConstraintFields where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ConstraintFields where {1} and mId not in (Select top {3} mId from ConstraintFields where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsConstraintFieldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ConstraintFields.* " + 
$"from ConstraintFields " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ConstraintFields.mId not in " + 
$"(Select top {intTop_In} ConstraintFields.mId from ConstraintFields " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ConstraintFields where {1} and mId not in (Select top {2} mId from ConstraintFields where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ConstraintFields where {1} and mId not in (Select top {3} mId from ConstraintFields where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsConstraintFieldsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsConstraintFieldsDA:GetObjLst)", objException.Message));
}
List<clsConstraintFieldsEN> arrObjLst = new List<clsConstraintFieldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
strSQL = "Select * from ConstraintFields where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConstraintFieldsEN objConstraintFieldsEN = new clsConstraintFieldsEN();
try
{
objConstraintFieldsEN.mId = TransNullToInt(objRow[conConstraintFields.mId].ToString().Trim()); //mId
objConstraintFieldsEN.PrjConstraintId = objRow[conConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objConstraintFieldsEN.TabId = objRow[conConstraintFields.TabId].ToString().Trim(); //表ID
objConstraintFieldsEN.FldId = objRow[conConstraintFields.FldId].ToString().Trim(); //字段Id
objConstraintFieldsEN.MaxValue = objRow[conConstraintFields.MaxValue] == DBNull.Value ? null : objRow[conConstraintFields.MaxValue].ToString().Trim(); //最大值
objConstraintFieldsEN.MinValue = objRow[conConstraintFields.MinValue] == DBNull.Value ? null : objRow[conConstraintFields.MinValue].ToString().Trim(); //最小值
objConstraintFieldsEN.SortTypeId = objRow[conConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objConstraintFieldsEN.InUse = TransNullToBool(objRow[conConstraintFields.InUse].ToString().Trim()); //是否在用
objConstraintFieldsEN.OrderNum = TransNullToInt(objRow[conConstraintFields.OrderNum].ToString().Trim()); //序号
objConstraintFieldsEN.PrjId = objRow[conConstraintFields.PrjId] == DBNull.Value ? null : objRow[conConstraintFields.PrjId].ToString().Trim(); //工程Id
objConstraintFieldsEN.UpdDate = objRow[conConstraintFields.UpdDate] == DBNull.Value ? null : objRow[conConstraintFields.UpdDate].ToString().Trim(); //修改日期
objConstraintFieldsEN.UpdUser = objRow[conConstraintFields.UpdUser] == DBNull.Value ? null : objRow[conConstraintFields.UpdUser].ToString().Trim(); //修改者
objConstraintFieldsEN.Memo = objRow[conConstraintFields.Memo] == DBNull.Value ? null : objRow[conConstraintFields.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsConstraintFieldsDA: GetObjLst)", objException.Message));
}
objConstraintFieldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objConstraintFieldsEN);
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
public List<clsConstraintFieldsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsConstraintFieldsDA:GetObjLstByTabName)", objException.Message));
}
List<clsConstraintFieldsEN> arrObjLst = new List<clsConstraintFieldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConstraintFieldsEN objConstraintFieldsEN = new clsConstraintFieldsEN();
try
{
objConstraintFieldsEN.mId = TransNullToInt(objRow[conConstraintFields.mId].ToString().Trim()); //mId
objConstraintFieldsEN.PrjConstraintId = objRow[conConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objConstraintFieldsEN.TabId = objRow[conConstraintFields.TabId].ToString().Trim(); //表ID
objConstraintFieldsEN.FldId = objRow[conConstraintFields.FldId].ToString().Trim(); //字段Id
objConstraintFieldsEN.MaxValue = objRow[conConstraintFields.MaxValue] == DBNull.Value ? null : objRow[conConstraintFields.MaxValue].ToString().Trim(); //最大值
objConstraintFieldsEN.MinValue = objRow[conConstraintFields.MinValue] == DBNull.Value ? null : objRow[conConstraintFields.MinValue].ToString().Trim(); //最小值
objConstraintFieldsEN.SortTypeId = objRow[conConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objConstraintFieldsEN.InUse = TransNullToBool(objRow[conConstraintFields.InUse].ToString().Trim()); //是否在用
objConstraintFieldsEN.OrderNum = TransNullToInt(objRow[conConstraintFields.OrderNum].ToString().Trim()); //序号
objConstraintFieldsEN.PrjId = objRow[conConstraintFields.PrjId] == DBNull.Value ? null : objRow[conConstraintFields.PrjId].ToString().Trim(); //工程Id
objConstraintFieldsEN.UpdDate = objRow[conConstraintFields.UpdDate] == DBNull.Value ? null : objRow[conConstraintFields.UpdDate].ToString().Trim(); //修改日期
objConstraintFieldsEN.UpdUser = objRow[conConstraintFields.UpdUser] == DBNull.Value ? null : objRow[conConstraintFields.UpdUser].ToString().Trim(); //修改者
objConstraintFieldsEN.Memo = objRow[conConstraintFields.Memo] == DBNull.Value ? null : objRow[conConstraintFields.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsConstraintFieldsDA: GetObjLst)", objException.Message));
}
objConstraintFieldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objConstraintFieldsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetConstraintFields(ref clsConstraintFieldsEN objConstraintFieldsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
strSQL = "Select * from ConstraintFields where mId = " + ""+ objConstraintFieldsEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objConstraintFieldsEN.mId = TransNullToInt(objDT.Rows[0][conConstraintFields.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objConstraintFieldsEN.PrjConstraintId = objDT.Rows[0][conConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id(字段类型:char,字段长度:8,是否可空:False)
 objConstraintFieldsEN.TabId = objDT.Rows[0][conConstraintFields.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objConstraintFieldsEN.FldId = objDT.Rows[0][conConstraintFields.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objConstraintFieldsEN.MaxValue = objDT.Rows[0][conConstraintFields.MaxValue].ToString().Trim(); //最大值(字段类型:varchar,字段长度:50,是否可空:True)
 objConstraintFieldsEN.MinValue = objDT.Rows[0][conConstraintFields.MinValue].ToString().Trim(); //最小值(字段类型:varchar,字段长度:50,是否可空:True)
 objConstraintFieldsEN.SortTypeId = objDT.Rows[0][conConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id(字段类型:char,字段长度:2,是否可空:False)
 objConstraintFieldsEN.InUse = TransNullToBool(objDT.Rows[0][conConstraintFields.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objConstraintFieldsEN.OrderNum = TransNullToInt(objDT.Rows[0][conConstraintFields.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objConstraintFieldsEN.PrjId = objDT.Rows[0][conConstraintFields.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objConstraintFieldsEN.UpdDate = objDT.Rows[0][conConstraintFields.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objConstraintFieldsEN.UpdUser = objDT.Rows[0][conConstraintFields.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objConstraintFieldsEN.Memo = objDT.Rows[0][conConstraintFields.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsConstraintFieldsDA: GetConstraintFields)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsConstraintFieldsEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
strSQL = "Select * from ConstraintFields where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsConstraintFieldsEN objConstraintFieldsEN = new clsConstraintFieldsEN();
try
{
 objConstraintFieldsEN.mId = Int32.Parse(objRow[conConstraintFields.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objConstraintFieldsEN.PrjConstraintId = objRow[conConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id(字段类型:char,字段长度:8,是否可空:False)
 objConstraintFieldsEN.TabId = objRow[conConstraintFields.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objConstraintFieldsEN.FldId = objRow[conConstraintFields.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objConstraintFieldsEN.MaxValue = objRow[conConstraintFields.MaxValue] == DBNull.Value ? null : objRow[conConstraintFields.MaxValue].ToString().Trim(); //最大值(字段类型:varchar,字段长度:50,是否可空:True)
 objConstraintFieldsEN.MinValue = objRow[conConstraintFields.MinValue] == DBNull.Value ? null : objRow[conConstraintFields.MinValue].ToString().Trim(); //最小值(字段类型:varchar,字段长度:50,是否可空:True)
 objConstraintFieldsEN.SortTypeId = objRow[conConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id(字段类型:char,字段长度:2,是否可空:False)
 objConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conConstraintFields.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objConstraintFieldsEN.OrderNum = Int32.Parse(objRow[conConstraintFields.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objConstraintFieldsEN.PrjId = objRow[conConstraintFields.PrjId] == DBNull.Value ? null : objRow[conConstraintFields.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objConstraintFieldsEN.UpdDate = objRow[conConstraintFields.UpdDate] == DBNull.Value ? null : objRow[conConstraintFields.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objConstraintFieldsEN.UpdUser = objRow[conConstraintFields.UpdUser] == DBNull.Value ? null : objRow[conConstraintFields.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objConstraintFieldsEN.Memo = objRow[conConstraintFields.Memo] == DBNull.Value ? null : objRow[conConstraintFields.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsConstraintFieldsDA: GetObjBymId)", objException.Message));
}
return objConstraintFieldsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsConstraintFieldsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsConstraintFieldsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
strSQL = "Select * from ConstraintFields where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsConstraintFieldsEN objConstraintFieldsEN = new clsConstraintFieldsEN()
{
mId = TransNullToInt(objRow[conConstraintFields.mId].ToString().Trim()), //mId
PrjConstraintId = objRow[conConstraintFields.PrjConstraintId].ToString().Trim(), //约束表Id
TabId = objRow[conConstraintFields.TabId].ToString().Trim(), //表ID
FldId = objRow[conConstraintFields.FldId].ToString().Trim(), //字段Id
MaxValue = objRow[conConstraintFields.MaxValue] == DBNull.Value ? null : objRow[conConstraintFields.MaxValue].ToString().Trim(), //最大值
MinValue = objRow[conConstraintFields.MinValue] == DBNull.Value ? null : objRow[conConstraintFields.MinValue].ToString().Trim(), //最小值
SortTypeId = objRow[conConstraintFields.SortTypeId].ToString().Trim(), //排序类型Id
InUse = TransNullToBool(objRow[conConstraintFields.InUse].ToString().Trim()), //是否在用
OrderNum = TransNullToInt(objRow[conConstraintFields.OrderNum].ToString().Trim()), //序号
PrjId = objRow[conConstraintFields.PrjId] == DBNull.Value ? null : objRow[conConstraintFields.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conConstraintFields.UpdDate] == DBNull.Value ? null : objRow[conConstraintFields.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conConstraintFields.UpdUser] == DBNull.Value ? null : objRow[conConstraintFields.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conConstraintFields.Memo] == DBNull.Value ? null : objRow[conConstraintFields.Memo].ToString().Trim() //说明
};
objConstraintFieldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objConstraintFieldsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsConstraintFieldsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsConstraintFieldsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsConstraintFieldsEN objConstraintFieldsEN = new clsConstraintFieldsEN();
try
{
objConstraintFieldsEN.mId = TransNullToInt(objRow[conConstraintFields.mId].ToString().Trim()); //mId
objConstraintFieldsEN.PrjConstraintId = objRow[conConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objConstraintFieldsEN.TabId = objRow[conConstraintFields.TabId].ToString().Trim(); //表ID
objConstraintFieldsEN.FldId = objRow[conConstraintFields.FldId].ToString().Trim(); //字段Id
objConstraintFieldsEN.MaxValue = objRow[conConstraintFields.MaxValue] == DBNull.Value ? null : objRow[conConstraintFields.MaxValue].ToString().Trim(); //最大值
objConstraintFieldsEN.MinValue = objRow[conConstraintFields.MinValue] == DBNull.Value ? null : objRow[conConstraintFields.MinValue].ToString().Trim(); //最小值
objConstraintFieldsEN.SortTypeId = objRow[conConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objConstraintFieldsEN.InUse = TransNullToBool(objRow[conConstraintFields.InUse].ToString().Trim()); //是否在用
objConstraintFieldsEN.OrderNum = TransNullToInt(objRow[conConstraintFields.OrderNum].ToString().Trim()); //序号
objConstraintFieldsEN.PrjId = objRow[conConstraintFields.PrjId] == DBNull.Value ? null : objRow[conConstraintFields.PrjId].ToString().Trim(); //工程Id
objConstraintFieldsEN.UpdDate = objRow[conConstraintFields.UpdDate] == DBNull.Value ? null : objRow[conConstraintFields.UpdDate].ToString().Trim(); //修改日期
objConstraintFieldsEN.UpdUser = objRow[conConstraintFields.UpdUser] == DBNull.Value ? null : objRow[conConstraintFields.UpdUser].ToString().Trim(); //修改者
objConstraintFieldsEN.Memo = objRow[conConstraintFields.Memo] == DBNull.Value ? null : objRow[conConstraintFields.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsConstraintFieldsDA: GetObjByDataRowConstraintFields)", objException.Message));
}
objConstraintFieldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objConstraintFieldsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsConstraintFieldsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsConstraintFieldsEN objConstraintFieldsEN = new clsConstraintFieldsEN();
try
{
objConstraintFieldsEN.mId = TransNullToInt(objRow[conConstraintFields.mId].ToString().Trim()); //mId
objConstraintFieldsEN.PrjConstraintId = objRow[conConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objConstraintFieldsEN.TabId = objRow[conConstraintFields.TabId].ToString().Trim(); //表ID
objConstraintFieldsEN.FldId = objRow[conConstraintFields.FldId].ToString().Trim(); //字段Id
objConstraintFieldsEN.MaxValue = objRow[conConstraintFields.MaxValue] == DBNull.Value ? null : objRow[conConstraintFields.MaxValue].ToString().Trim(); //最大值
objConstraintFieldsEN.MinValue = objRow[conConstraintFields.MinValue] == DBNull.Value ? null : objRow[conConstraintFields.MinValue].ToString().Trim(); //最小值
objConstraintFieldsEN.SortTypeId = objRow[conConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objConstraintFieldsEN.InUse = TransNullToBool(objRow[conConstraintFields.InUse].ToString().Trim()); //是否在用
objConstraintFieldsEN.OrderNum = TransNullToInt(objRow[conConstraintFields.OrderNum].ToString().Trim()); //序号
objConstraintFieldsEN.PrjId = objRow[conConstraintFields.PrjId] == DBNull.Value ? null : objRow[conConstraintFields.PrjId].ToString().Trim(); //工程Id
objConstraintFieldsEN.UpdDate = objRow[conConstraintFields.UpdDate] == DBNull.Value ? null : objRow[conConstraintFields.UpdDate].ToString().Trim(); //修改日期
objConstraintFieldsEN.UpdUser = objRow[conConstraintFields.UpdUser] == DBNull.Value ? null : objRow[conConstraintFields.UpdUser].ToString().Trim(); //修改者
objConstraintFieldsEN.Memo = objRow[conConstraintFields.Memo] == DBNull.Value ? null : objRow[conConstraintFields.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsConstraintFieldsDA: GetObjByDataRow)", objException.Message));
}
objConstraintFieldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objConstraintFieldsEN;
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
objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsConstraintFieldsEN._CurrTabName, conConstraintFields.mId, 8, "");
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
objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsConstraintFieldsEN._CurrTabName, conConstraintFields.mId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from ConstraintFields where " + strCondition;
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
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from ConstraintFields where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ConstraintFields", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsConstraintFieldsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ConstraintFields", strCondition))
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
objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ConstraintFields");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsConstraintFieldsEN objConstraintFieldsEN)
 {
 objConstraintFieldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objConstraintFieldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objConstraintFieldsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
strSQL = "Select * from ConstraintFields where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ConstraintFields");
objRow = objDS.Tables["ConstraintFields"].NewRow();
objRow[conConstraintFields.PrjConstraintId] = objConstraintFieldsEN.PrjConstraintId; //约束表Id
objRow[conConstraintFields.TabId] = objConstraintFieldsEN.TabId; //表ID
objRow[conConstraintFields.FldId] = objConstraintFieldsEN.FldId; //字段Id
 if (objConstraintFieldsEN.MaxValue !=  "")
 {
objRow[conConstraintFields.MaxValue] = objConstraintFieldsEN.MaxValue; //最大值
 }
 if (objConstraintFieldsEN.MinValue !=  "")
 {
objRow[conConstraintFields.MinValue] = objConstraintFieldsEN.MinValue; //最小值
 }
objRow[conConstraintFields.SortTypeId] = objConstraintFieldsEN.SortTypeId; //排序类型Id
objRow[conConstraintFields.InUse] = objConstraintFieldsEN.InUse; //是否在用
objRow[conConstraintFields.OrderNum] = objConstraintFieldsEN.OrderNum; //序号
 if (objConstraintFieldsEN.PrjId !=  "")
 {
objRow[conConstraintFields.PrjId] = objConstraintFieldsEN.PrjId; //工程Id
 }
 if (objConstraintFieldsEN.UpdDate !=  "")
 {
objRow[conConstraintFields.UpdDate] = objConstraintFieldsEN.UpdDate; //修改日期
 }
 if (objConstraintFieldsEN.UpdUser !=  "")
 {
objRow[conConstraintFields.UpdUser] = objConstraintFieldsEN.UpdUser; //修改者
 }
 if (objConstraintFieldsEN.Memo !=  "")
 {
objRow[conConstraintFields.Memo] = objConstraintFieldsEN.Memo; //说明
 }
objDS.Tables[clsConstraintFieldsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsConstraintFieldsEN._CurrTabName);
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
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsConstraintFieldsEN objConstraintFieldsEN)
{
 objConstraintFieldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objConstraintFieldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objConstraintFieldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objConstraintFieldsEN.PrjConstraintId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.PrjConstraintId);
 var strPrjConstraintId = objConstraintFieldsEN.PrjConstraintId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjConstraintId + "'");
 }
 
 if (objConstraintFieldsEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.TabId);
 var strTabId = objConstraintFieldsEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objConstraintFieldsEN.FldId  ==  "")
 {
 objConstraintFieldsEN.FldId = null;
 }
 if (objConstraintFieldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.FldId);
 var strFldId = objConstraintFieldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objConstraintFieldsEN.MaxValue !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.MaxValue);
 var strMaxValue = objConstraintFieldsEN.MaxValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMaxValue + "'");
 }
 
 if (objConstraintFieldsEN.MinValue !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.MinValue);
 var strMinValue = objConstraintFieldsEN.MinValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMinValue + "'");
 }
 
 if (objConstraintFieldsEN.SortTypeId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.SortTypeId);
 var strSortTypeId = objConstraintFieldsEN.SortTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSortTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conConstraintFields.InUse);
 arrValueListForInsert.Add("'" + (objConstraintFieldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conConstraintFields.OrderNum);
 arrValueListForInsert.Add(objConstraintFieldsEN.OrderNum.ToString());
 
 if (objConstraintFieldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.PrjId);
 var strPrjId = objConstraintFieldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objConstraintFieldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.UpdDate);
 var strUpdDate = objConstraintFieldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objConstraintFieldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.UpdUser);
 var strUpdUser = objConstraintFieldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objConstraintFieldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.Memo);
 var strMemo = objConstraintFieldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ConstraintFields");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsConstraintFieldsEN objConstraintFieldsEN)
{
 objConstraintFieldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objConstraintFieldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objConstraintFieldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objConstraintFieldsEN.PrjConstraintId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.PrjConstraintId);
 var strPrjConstraintId = objConstraintFieldsEN.PrjConstraintId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjConstraintId + "'");
 }
 
 if (objConstraintFieldsEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.TabId);
 var strTabId = objConstraintFieldsEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objConstraintFieldsEN.FldId  ==  "")
 {
 objConstraintFieldsEN.FldId = null;
 }
 if (objConstraintFieldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.FldId);
 var strFldId = objConstraintFieldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objConstraintFieldsEN.MaxValue !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.MaxValue);
 var strMaxValue = objConstraintFieldsEN.MaxValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMaxValue + "'");
 }
 
 if (objConstraintFieldsEN.MinValue !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.MinValue);
 var strMinValue = objConstraintFieldsEN.MinValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMinValue + "'");
 }
 
 if (objConstraintFieldsEN.SortTypeId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.SortTypeId);
 var strSortTypeId = objConstraintFieldsEN.SortTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSortTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conConstraintFields.InUse);
 arrValueListForInsert.Add("'" + (objConstraintFieldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conConstraintFields.OrderNum);
 arrValueListForInsert.Add(objConstraintFieldsEN.OrderNum.ToString());
 
 if (objConstraintFieldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.PrjId);
 var strPrjId = objConstraintFieldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objConstraintFieldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.UpdDate);
 var strUpdDate = objConstraintFieldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objConstraintFieldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.UpdUser);
 var strUpdUser = objConstraintFieldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objConstraintFieldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.Memo);
 var strMemo = objConstraintFieldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ConstraintFields");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsConstraintFieldsEN objConstraintFieldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objConstraintFieldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objConstraintFieldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objConstraintFieldsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objConstraintFieldsEN.PrjConstraintId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.PrjConstraintId);
 var strPrjConstraintId = objConstraintFieldsEN.PrjConstraintId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjConstraintId + "'");
 }
 
 if (objConstraintFieldsEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.TabId);
 var strTabId = objConstraintFieldsEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objConstraintFieldsEN.FldId  ==  "")
 {
 objConstraintFieldsEN.FldId = null;
 }
 if (objConstraintFieldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.FldId);
 var strFldId = objConstraintFieldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objConstraintFieldsEN.MaxValue !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.MaxValue);
 var strMaxValue = objConstraintFieldsEN.MaxValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMaxValue + "'");
 }
 
 if (objConstraintFieldsEN.MinValue !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.MinValue);
 var strMinValue = objConstraintFieldsEN.MinValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMinValue + "'");
 }
 
 if (objConstraintFieldsEN.SortTypeId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.SortTypeId);
 var strSortTypeId = objConstraintFieldsEN.SortTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSortTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conConstraintFields.InUse);
 arrValueListForInsert.Add("'" + (objConstraintFieldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conConstraintFields.OrderNum);
 arrValueListForInsert.Add(objConstraintFieldsEN.OrderNum.ToString());
 
 if (objConstraintFieldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.PrjId);
 var strPrjId = objConstraintFieldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objConstraintFieldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.UpdDate);
 var strUpdDate = objConstraintFieldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objConstraintFieldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.UpdUser);
 var strUpdUser = objConstraintFieldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objConstraintFieldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.Memo);
 var strMemo = objConstraintFieldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ConstraintFields");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsConstraintFieldsEN objConstraintFieldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objConstraintFieldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objConstraintFieldsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objConstraintFieldsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objConstraintFieldsEN.PrjConstraintId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.PrjConstraintId);
 var strPrjConstraintId = objConstraintFieldsEN.PrjConstraintId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjConstraintId + "'");
 }
 
 if (objConstraintFieldsEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.TabId);
 var strTabId = objConstraintFieldsEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objConstraintFieldsEN.FldId  ==  "")
 {
 objConstraintFieldsEN.FldId = null;
 }
 if (objConstraintFieldsEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.FldId);
 var strFldId = objConstraintFieldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objConstraintFieldsEN.MaxValue !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.MaxValue);
 var strMaxValue = objConstraintFieldsEN.MaxValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMaxValue + "'");
 }
 
 if (objConstraintFieldsEN.MinValue !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.MinValue);
 var strMinValue = objConstraintFieldsEN.MinValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMinValue + "'");
 }
 
 if (objConstraintFieldsEN.SortTypeId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.SortTypeId);
 var strSortTypeId = objConstraintFieldsEN.SortTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSortTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conConstraintFields.InUse);
 arrValueListForInsert.Add("'" + (objConstraintFieldsEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conConstraintFields.OrderNum);
 arrValueListForInsert.Add(objConstraintFieldsEN.OrderNum.ToString());
 
 if (objConstraintFieldsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.PrjId);
 var strPrjId = objConstraintFieldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objConstraintFieldsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.UpdDate);
 var strUpdDate = objConstraintFieldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objConstraintFieldsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.UpdUser);
 var strUpdUser = objConstraintFieldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objConstraintFieldsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conConstraintFields.Memo);
 var strMemo = objConstraintFieldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ConstraintFields");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewConstraintFieldss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
strSQL = "Select * from ConstraintFields where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ConstraintFields");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conConstraintFields.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsConstraintFieldsEN._CurrTabName ].NewRow();
objRow[conConstraintFields.PrjConstraintId] = oRow[conConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objRow[conConstraintFields.TabId] = oRow[conConstraintFields.TabId].ToString().Trim(); //表ID
objRow[conConstraintFields.FldId] = oRow[conConstraintFields.FldId].ToString().Trim(); //字段Id
objRow[conConstraintFields.MaxValue] = oRow[conConstraintFields.MaxValue].ToString().Trim(); //最大值
objRow[conConstraintFields.MinValue] = oRow[conConstraintFields.MinValue].ToString().Trim(); //最小值
objRow[conConstraintFields.SortTypeId] = oRow[conConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objRow[conConstraintFields.InUse] = oRow[conConstraintFields.InUse].ToString().Trim(); //是否在用
objRow[conConstraintFields.OrderNum] = oRow[conConstraintFields.OrderNum].ToString().Trim(); //序号
objRow[conConstraintFields.PrjId] = oRow[conConstraintFields.PrjId].ToString().Trim(); //工程Id
objRow[conConstraintFields.UpdDate] = oRow[conConstraintFields.UpdDate].ToString().Trim(); //修改日期
objRow[conConstraintFields.UpdUser] = oRow[conConstraintFields.UpdUser].ToString().Trim(); //修改者
objRow[conConstraintFields.Memo] = oRow[conConstraintFields.Memo].ToString().Trim(); //说明
 objDS.Tables[clsConstraintFieldsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsConstraintFieldsEN._CurrTabName);
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
 /// <param name = "objConstraintFieldsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsConstraintFieldsEN objConstraintFieldsEN)
{
 objConstraintFieldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objConstraintFieldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objConstraintFieldsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
strSQL = "Select * from ConstraintFields where mId = " + ""+ objConstraintFieldsEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsConstraintFieldsEN._CurrTabName);
if (objDS.Tables[clsConstraintFieldsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objConstraintFieldsEN.mId+"");
return false;
}
objRow = objDS.Tables[clsConstraintFieldsEN._CurrTabName].Rows[0];
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.PrjConstraintId))
 {
objRow[conConstraintFields.PrjConstraintId] = objConstraintFieldsEN.PrjConstraintId; //约束表Id
 }
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.TabId))
 {
objRow[conConstraintFields.TabId] = objConstraintFieldsEN.TabId; //表ID
 }
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.FldId))
 {
objRow[conConstraintFields.FldId] = objConstraintFieldsEN.FldId; //字段Id
 }
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.MaxValue))
 {
objRow[conConstraintFields.MaxValue] = objConstraintFieldsEN.MaxValue; //最大值
 }
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.MinValue))
 {
objRow[conConstraintFields.MinValue] = objConstraintFieldsEN.MinValue; //最小值
 }
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.SortTypeId))
 {
objRow[conConstraintFields.SortTypeId] = objConstraintFieldsEN.SortTypeId; //排序类型Id
 }
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.InUse))
 {
objRow[conConstraintFields.InUse] = objConstraintFieldsEN.InUse; //是否在用
 }
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.OrderNum))
 {
objRow[conConstraintFields.OrderNum] = objConstraintFieldsEN.OrderNum; //序号
 }
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.PrjId))
 {
objRow[conConstraintFields.PrjId] = objConstraintFieldsEN.PrjId; //工程Id
 }
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.UpdDate))
 {
objRow[conConstraintFields.UpdDate] = objConstraintFieldsEN.UpdDate; //修改日期
 }
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.UpdUser))
 {
objRow[conConstraintFields.UpdUser] = objConstraintFieldsEN.UpdUser; //修改者
 }
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.Memo))
 {
objRow[conConstraintFields.Memo] = objConstraintFieldsEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsConstraintFieldsEN._CurrTabName);
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
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsConstraintFieldsEN objConstraintFieldsEN)
{
 objConstraintFieldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objConstraintFieldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objConstraintFieldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ConstraintFields Set ");
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.PrjConstraintId))
 {
 if (objConstraintFieldsEN.PrjConstraintId !=  null)
 {
 var strPrjConstraintId = objConstraintFieldsEN.PrjConstraintId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjConstraintId, conConstraintFields.PrjConstraintId); //约束表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.PrjConstraintId); //约束表Id
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.TabId))
 {
 if (objConstraintFieldsEN.TabId !=  null)
 {
 var strTabId = objConstraintFieldsEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conConstraintFields.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.TabId); //表ID
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.FldId))
 {
 if (objConstraintFieldsEN.FldId  ==  "")
 {
 objConstraintFieldsEN.FldId = null;
 }
 if (objConstraintFieldsEN.FldId !=  null)
 {
 var strFldId = objConstraintFieldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conConstraintFields.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.FldId); //字段Id
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.MaxValue))
 {
 if (objConstraintFieldsEN.MaxValue !=  null)
 {
 var strMaxValue = objConstraintFieldsEN.MaxValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMaxValue, conConstraintFields.MaxValue); //最大值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.MaxValue); //最大值
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.MinValue))
 {
 if (objConstraintFieldsEN.MinValue !=  null)
 {
 var strMinValue = objConstraintFieldsEN.MinValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMinValue, conConstraintFields.MinValue); //最小值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.MinValue); //最小值
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.SortTypeId))
 {
 if (objConstraintFieldsEN.SortTypeId !=  null)
 {
 var strSortTypeId = objConstraintFieldsEN.SortTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSortTypeId, conConstraintFields.SortTypeId); //排序类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.SortTypeId); //排序类型Id
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objConstraintFieldsEN.InUse == true?"1":"0", conConstraintFields.InUse); //是否在用
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objConstraintFieldsEN.OrderNum, conConstraintFields.OrderNum); //序号
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.PrjId))
 {
 if (objConstraintFieldsEN.PrjId !=  null)
 {
 var strPrjId = objConstraintFieldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conConstraintFields.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.PrjId); //工程Id
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.UpdDate))
 {
 if (objConstraintFieldsEN.UpdDate !=  null)
 {
 var strUpdDate = objConstraintFieldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conConstraintFields.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.UpdDate); //修改日期
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.UpdUser))
 {
 if (objConstraintFieldsEN.UpdUser !=  null)
 {
 var strUpdUser = objConstraintFieldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conConstraintFields.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.UpdUser); //修改者
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.Memo))
 {
 if (objConstraintFieldsEN.Memo !=  null)
 {
 var strMemo = objConstraintFieldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conConstraintFields.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objConstraintFieldsEN.mId); 
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
 /// <param name = "objConstraintFieldsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsConstraintFieldsEN objConstraintFieldsEN, string strCondition)
{
 objConstraintFieldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objConstraintFieldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objConstraintFieldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ConstraintFields Set ");
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.PrjConstraintId))
 {
 if (objConstraintFieldsEN.PrjConstraintId !=  null)
 {
 var strPrjConstraintId = objConstraintFieldsEN.PrjConstraintId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjConstraintId = '{0}',", strPrjConstraintId); //约束表Id
 }
 else
 {
 sbSQL.Append(" PrjConstraintId = null,"); //约束表Id
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.TabId))
 {
 if (objConstraintFieldsEN.TabId !=  null)
 {
 var strTabId = objConstraintFieldsEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.FldId))
 {
 if (objConstraintFieldsEN.FldId  ==  "")
 {
 objConstraintFieldsEN.FldId = null;
 }
 if (objConstraintFieldsEN.FldId !=  null)
 {
 var strFldId = objConstraintFieldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.MaxValue))
 {
 if (objConstraintFieldsEN.MaxValue !=  null)
 {
 var strMaxValue = objConstraintFieldsEN.MaxValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MaxValue = '{0}',", strMaxValue); //最大值
 }
 else
 {
 sbSQL.Append(" MaxValue = null,"); //最大值
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.MinValue))
 {
 if (objConstraintFieldsEN.MinValue !=  null)
 {
 var strMinValue = objConstraintFieldsEN.MinValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MinValue = '{0}',", strMinValue); //最小值
 }
 else
 {
 sbSQL.Append(" MinValue = null,"); //最小值
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.SortTypeId))
 {
 if (objConstraintFieldsEN.SortTypeId !=  null)
 {
 var strSortTypeId = objConstraintFieldsEN.SortTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SortTypeId = '{0}',", strSortTypeId); //排序类型Id
 }
 else
 {
 sbSQL.Append(" SortTypeId = null,"); //排序类型Id
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objConstraintFieldsEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objConstraintFieldsEN.OrderNum); //序号
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.PrjId))
 {
 if (objConstraintFieldsEN.PrjId !=  null)
 {
 var strPrjId = objConstraintFieldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.UpdDate))
 {
 if (objConstraintFieldsEN.UpdDate !=  null)
 {
 var strUpdDate = objConstraintFieldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.UpdUser))
 {
 if (objConstraintFieldsEN.UpdUser !=  null)
 {
 var strUpdUser = objConstraintFieldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.Memo))
 {
 if (objConstraintFieldsEN.Memo !=  null)
 {
 var strMemo = objConstraintFieldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objConstraintFieldsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsConstraintFieldsEN objConstraintFieldsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objConstraintFieldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objConstraintFieldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objConstraintFieldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ConstraintFields Set ");
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.PrjConstraintId))
 {
 if (objConstraintFieldsEN.PrjConstraintId !=  null)
 {
 var strPrjConstraintId = objConstraintFieldsEN.PrjConstraintId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjConstraintId = '{0}',", strPrjConstraintId); //约束表Id
 }
 else
 {
 sbSQL.Append(" PrjConstraintId = null,"); //约束表Id
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.TabId))
 {
 if (objConstraintFieldsEN.TabId !=  null)
 {
 var strTabId = objConstraintFieldsEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.FldId))
 {
 if (objConstraintFieldsEN.FldId  ==  "")
 {
 objConstraintFieldsEN.FldId = null;
 }
 if (objConstraintFieldsEN.FldId !=  null)
 {
 var strFldId = objConstraintFieldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.MaxValue))
 {
 if (objConstraintFieldsEN.MaxValue !=  null)
 {
 var strMaxValue = objConstraintFieldsEN.MaxValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MaxValue = '{0}',", strMaxValue); //最大值
 }
 else
 {
 sbSQL.Append(" MaxValue = null,"); //最大值
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.MinValue))
 {
 if (objConstraintFieldsEN.MinValue !=  null)
 {
 var strMinValue = objConstraintFieldsEN.MinValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MinValue = '{0}',", strMinValue); //最小值
 }
 else
 {
 sbSQL.Append(" MinValue = null,"); //最小值
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.SortTypeId))
 {
 if (objConstraintFieldsEN.SortTypeId !=  null)
 {
 var strSortTypeId = objConstraintFieldsEN.SortTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SortTypeId = '{0}',", strSortTypeId); //排序类型Id
 }
 else
 {
 sbSQL.Append(" SortTypeId = null,"); //排序类型Id
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objConstraintFieldsEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objConstraintFieldsEN.OrderNum); //序号
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.PrjId))
 {
 if (objConstraintFieldsEN.PrjId !=  null)
 {
 var strPrjId = objConstraintFieldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.UpdDate))
 {
 if (objConstraintFieldsEN.UpdDate !=  null)
 {
 var strUpdDate = objConstraintFieldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.UpdUser))
 {
 if (objConstraintFieldsEN.UpdUser !=  null)
 {
 var strUpdUser = objConstraintFieldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.Memo))
 {
 if (objConstraintFieldsEN.Memo !=  null)
 {
 var strMemo = objConstraintFieldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objConstraintFieldsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsConstraintFieldsEN objConstraintFieldsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objConstraintFieldsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objConstraintFieldsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objConstraintFieldsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ConstraintFields Set ");
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.PrjConstraintId))
 {
 if (objConstraintFieldsEN.PrjConstraintId !=  null)
 {
 var strPrjConstraintId = objConstraintFieldsEN.PrjConstraintId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjConstraintId, conConstraintFields.PrjConstraintId); //约束表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.PrjConstraintId); //约束表Id
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.TabId))
 {
 if (objConstraintFieldsEN.TabId !=  null)
 {
 var strTabId = objConstraintFieldsEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conConstraintFields.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.TabId); //表ID
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.FldId))
 {
 if (objConstraintFieldsEN.FldId  ==  "")
 {
 objConstraintFieldsEN.FldId = null;
 }
 if (objConstraintFieldsEN.FldId !=  null)
 {
 var strFldId = objConstraintFieldsEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conConstraintFields.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.FldId); //字段Id
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.MaxValue))
 {
 if (objConstraintFieldsEN.MaxValue !=  null)
 {
 var strMaxValue = objConstraintFieldsEN.MaxValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMaxValue, conConstraintFields.MaxValue); //最大值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.MaxValue); //最大值
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.MinValue))
 {
 if (objConstraintFieldsEN.MinValue !=  null)
 {
 var strMinValue = objConstraintFieldsEN.MinValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMinValue, conConstraintFields.MinValue); //最小值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.MinValue); //最小值
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.SortTypeId))
 {
 if (objConstraintFieldsEN.SortTypeId !=  null)
 {
 var strSortTypeId = objConstraintFieldsEN.SortTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSortTypeId, conConstraintFields.SortTypeId); //排序类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.SortTypeId); //排序类型Id
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objConstraintFieldsEN.InUse == true?"1":"0", conConstraintFields.InUse); //是否在用
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objConstraintFieldsEN.OrderNum, conConstraintFields.OrderNum); //序号
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.PrjId))
 {
 if (objConstraintFieldsEN.PrjId !=  null)
 {
 var strPrjId = objConstraintFieldsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conConstraintFields.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.PrjId); //工程Id
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.UpdDate))
 {
 if (objConstraintFieldsEN.UpdDate !=  null)
 {
 var strUpdDate = objConstraintFieldsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conConstraintFields.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.UpdDate); //修改日期
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.UpdUser))
 {
 if (objConstraintFieldsEN.UpdUser !=  null)
 {
 var strUpdUser = objConstraintFieldsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conConstraintFields.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.UpdUser); //修改者
 }
 }
 
 if (objConstraintFieldsEN.IsUpdated(conConstraintFields.Memo))
 {
 if (objConstraintFieldsEN.Memo !=  null)
 {
 var strMemo = objConstraintFieldsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conConstraintFields.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConstraintFields.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objConstraintFieldsEN.mId); 
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
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("ConstraintFields_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
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
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
//删除ConstraintFields本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ConstraintFields where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelConstraintFields(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
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
//删除ConstraintFields本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ConstraintFields where mId in (" + strKeyList + ")";
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
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
//删除ConstraintFields本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ConstraintFields where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelConstraintFields(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsConstraintFieldsDA: DelConstraintFields)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ConstraintFields where " + strCondition ;
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
public bool DelConstraintFieldsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsConstraintFieldsDA: DelConstraintFieldsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ConstraintFields where " + strCondition ;
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
 /// <param name = "objConstraintFieldsENS">源对象</param>
 /// <param name = "objConstraintFieldsENT">目标对象</param>
public void CopyTo(clsConstraintFieldsEN objConstraintFieldsENS, clsConstraintFieldsEN objConstraintFieldsENT)
{
objConstraintFieldsENT.mId = objConstraintFieldsENS.mId; //mId
objConstraintFieldsENT.PrjConstraintId = objConstraintFieldsENS.PrjConstraintId; //约束表Id
objConstraintFieldsENT.TabId = objConstraintFieldsENS.TabId; //表ID
objConstraintFieldsENT.FldId = objConstraintFieldsENS.FldId; //字段Id
objConstraintFieldsENT.MaxValue = objConstraintFieldsENS.MaxValue; //最大值
objConstraintFieldsENT.MinValue = objConstraintFieldsENS.MinValue; //最小值
objConstraintFieldsENT.SortTypeId = objConstraintFieldsENS.SortTypeId; //排序类型Id
objConstraintFieldsENT.InUse = objConstraintFieldsENS.InUse; //是否在用
objConstraintFieldsENT.OrderNum = objConstraintFieldsENS.OrderNum; //序号
objConstraintFieldsENT.PrjId = objConstraintFieldsENS.PrjId; //工程Id
objConstraintFieldsENT.UpdDate = objConstraintFieldsENS.UpdDate; //修改日期
objConstraintFieldsENT.UpdUser = objConstraintFieldsENS.UpdUser; //修改者
objConstraintFieldsENT.Memo = objConstraintFieldsENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsConstraintFieldsEN objConstraintFieldsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objConstraintFieldsEN.PrjConstraintId, conConstraintFields.PrjConstraintId);
clsCheckSql.CheckFieldNotNull(objConstraintFieldsEN.TabId, conConstraintFields.TabId);
clsCheckSql.CheckFieldNotNull(objConstraintFieldsEN.FldId, conConstraintFields.FldId);
clsCheckSql.CheckFieldNotNull(objConstraintFieldsEN.SortTypeId, conConstraintFields.SortTypeId);
clsCheckSql.CheckFieldNotNull(objConstraintFieldsEN.OrderNum, conConstraintFields.OrderNum);
//检查字段长度
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.PrjConstraintId, 8, conConstraintFields.PrjConstraintId);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.TabId, 8, conConstraintFields.TabId);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.FldId, 8, conConstraintFields.FldId);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.MaxValue, 50, conConstraintFields.MaxValue);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.MinValue, 50, conConstraintFields.MinValue);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.SortTypeId, 2, conConstraintFields.SortTypeId);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.PrjId, 4, conConstraintFields.PrjId);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.UpdDate, 20, conConstraintFields.UpdDate);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.UpdUser, 20, conConstraintFields.UpdUser);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.Memo, 1000, conConstraintFields.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objConstraintFieldsEN.FldId, 8, conConstraintFields.FldId);
 objConstraintFieldsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsConstraintFieldsEN objConstraintFieldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.PrjConstraintId, 8, conConstraintFields.PrjConstraintId);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.TabId, 8, conConstraintFields.TabId);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.FldId, 8, conConstraintFields.FldId);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.MaxValue, 50, conConstraintFields.MaxValue);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.MinValue, 50, conConstraintFields.MinValue);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.SortTypeId, 2, conConstraintFields.SortTypeId);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.PrjId, 4, conConstraintFields.PrjId);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.UpdDate, 20, conConstraintFields.UpdDate);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.UpdUser, 20, conConstraintFields.UpdUser);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.Memo, 1000, conConstraintFields.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objConstraintFieldsEN.FldId, 8, conConstraintFields.FldId);
 objConstraintFieldsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsConstraintFieldsEN objConstraintFieldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.PrjConstraintId, 8, conConstraintFields.PrjConstraintId);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.TabId, 8, conConstraintFields.TabId);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.FldId, 8, conConstraintFields.FldId);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.MaxValue, 50, conConstraintFields.MaxValue);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.MinValue, 50, conConstraintFields.MinValue);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.SortTypeId, 2, conConstraintFields.SortTypeId);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.PrjId, 4, conConstraintFields.PrjId);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.UpdDate, 20, conConstraintFields.UpdDate);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.UpdUser, 20, conConstraintFields.UpdUser);
clsCheckSql.CheckFieldLen(objConstraintFieldsEN.Memo, 1000, conConstraintFields.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objConstraintFieldsEN.PrjConstraintId, conConstraintFields.PrjConstraintId);
clsCheckSql.CheckSqlInjection4Field(objConstraintFieldsEN.TabId, conConstraintFields.TabId);
clsCheckSql.CheckSqlInjection4Field(objConstraintFieldsEN.FldId, conConstraintFields.FldId);
clsCheckSql.CheckSqlInjection4Field(objConstraintFieldsEN.MaxValue, conConstraintFields.MaxValue);
clsCheckSql.CheckSqlInjection4Field(objConstraintFieldsEN.MinValue, conConstraintFields.MinValue);
clsCheckSql.CheckSqlInjection4Field(objConstraintFieldsEN.SortTypeId, conConstraintFields.SortTypeId);
clsCheckSql.CheckSqlInjection4Field(objConstraintFieldsEN.PrjId, conConstraintFields.PrjId);
clsCheckSql.CheckSqlInjection4Field(objConstraintFieldsEN.UpdDate, conConstraintFields.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objConstraintFieldsEN.UpdUser, conConstraintFields.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objConstraintFieldsEN.Memo, conConstraintFields.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objConstraintFieldsEN.FldId, 8, conConstraintFields.FldId);
 objConstraintFieldsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ConstraintFields(约束字段),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objConstraintFieldsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsConstraintFieldsEN objConstraintFieldsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjConstraintId = '{0}'", objConstraintFieldsEN.PrjConstraintId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objConstraintFieldsEN.FldId);
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
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
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
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
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
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsConstraintFieldsEN._CurrTabName);
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
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsConstraintFieldsEN._CurrTabName, strCondition);
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
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
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
 objSQL = clsConstraintFieldsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}