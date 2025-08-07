
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvConstraintFieldsDA
 表名:vConstraintFields(00050413)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:42
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
 /// v约束字段(vConstraintFields)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvConstraintFieldsDA : clsCommBase4DA
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
 return clsvConstraintFieldsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvConstraintFieldsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvConstraintFieldsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvConstraintFieldsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvConstraintFieldsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvConstraintFieldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
strSQL = "Select * from vConstraintFields where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vConstraintFields(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvConstraintFieldsDA: GetDataTable_vConstraintFields)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
strSQL = "Select * from vConstraintFields where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvConstraintFieldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvConstraintFieldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
strSQL = "Select * from vConstraintFields where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvConstraintFieldsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvConstraintFieldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vConstraintFields where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vConstraintFields where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvConstraintFieldsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vConstraintFields where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvConstraintFieldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vConstraintFields.* " + 
$"from vConstraintFields " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vConstraintFields.mId not in " + 
$"(Select top {intTop_In} vConstraintFields.mId from vConstraintFields " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vConstraintFields where {1} and mId not in (Select top {2} mId from vConstraintFields where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vConstraintFields where {1} and mId not in (Select top {3} mId from vConstraintFields where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvConstraintFieldsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vConstraintFields.* " + 
$"from vConstraintFields " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vConstraintFields.mId not in " + 
$"(Select top {intTop_In} vConstraintFields.mId from vConstraintFields " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vConstraintFields where {1} and mId not in (Select top {2} mId from vConstraintFields where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vConstraintFields where {1} and mId not in (Select top {3} mId from vConstraintFields where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvConstraintFieldsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvConstraintFieldsDA:GetObjLst)", objException.Message));
}
List<clsvConstraintFieldsEN> arrObjLst = new List<clsvConstraintFieldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
strSQL = "Select * from vConstraintFields where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConstraintFieldsEN objvConstraintFieldsEN = new clsvConstraintFieldsEN();
try
{
objvConstraintFieldsEN.mId = TransNullToInt(objRow[convConstraintFields.mId].ToString().Trim()); //mId
objvConstraintFieldsEN.PrjConstraintId = objRow[convConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objvConstraintFieldsEN.ConstraintName = objRow[convConstraintFields.ConstraintName].ToString().Trim(); //约束名
objvConstraintFieldsEN.ConstraintTypeId = objRow[convConstraintFields.ConstraintTypeId] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvConstraintFieldsEN.ConstraintTypeName = objRow[convConstraintFields.ConstraintTypeName] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeName].ToString().Trim(); //约束类型名
objvConstraintFieldsEN.TabId = objRow[convConstraintFields.TabId].ToString().Trim(); //表ID
objvConstraintFieldsEN.TabName = objRow[convConstraintFields.TabName].ToString().Trim(); //表名
objvConstraintFieldsEN.TabCnName = objRow[convConstraintFields.TabCnName] == DBNull.Value ? null : objRow[convConstraintFields.TabCnName].ToString().Trim(); //表中文名
objvConstraintFieldsEN.FldId = objRow[convConstraintFields.FldId].ToString().Trim(); //字段Id
objvConstraintFieldsEN.FldName = objRow[convConstraintFields.FldName].ToString().Trim(); //字段名
objvConstraintFieldsEN.FldCnName = objRow[convConstraintFields.FldCnName] == DBNull.Value ? null : objRow[convConstraintFields.FldCnName].ToString().Trim(); //字段中文详名
objvConstraintFieldsEN.MaxValue = objRow[convConstraintFields.MaxValue] == DBNull.Value ? null : objRow[convConstraintFields.MaxValue].ToString().Trim(); //最大值
objvConstraintFieldsEN.MinValue = objRow[convConstraintFields.MinValue] == DBNull.Value ? null : objRow[convConstraintFields.MinValue].ToString().Trim(); //最小值
objvConstraintFieldsEN.SortTypeId = objRow[convConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objvConstraintFieldsEN.SortTypeName = objRow[convConstraintFields.SortTypeName].ToString().Trim(); //排序类型名称
objvConstraintFieldsEN.InUse = TransNullToBool(objRow[convConstraintFields.InUse].ToString().Trim()); //是否在用
objvConstraintFieldsEN.OrderNum = TransNullToInt(objRow[convConstraintFields.OrderNum].ToString().Trim()); //序号
objvConstraintFieldsEN.PrjId = objRow[convConstraintFields.PrjId] == DBNull.Value ? null : objRow[convConstraintFields.PrjId].ToString().Trim(); //工程Id
objvConstraintFieldsEN.UpdDate = objRow[convConstraintFields.UpdDate] == DBNull.Value ? null : objRow[convConstraintFields.UpdDate].ToString().Trim(); //修改日期
objvConstraintFieldsEN.UpdUser = objRow[convConstraintFields.UpdUser] == DBNull.Value ? null : objRow[convConstraintFields.UpdUser].ToString().Trim(); //修改者
objvConstraintFieldsEN.Memo = objRow[convConstraintFields.Memo] == DBNull.Value ? null : objRow[convConstraintFields.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvConstraintFieldsDA: GetObjLst)", objException.Message));
}
objvConstraintFieldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvConstraintFieldsEN);
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
public List<clsvConstraintFieldsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvConstraintFieldsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvConstraintFieldsEN> arrObjLst = new List<clsvConstraintFieldsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConstraintFieldsEN objvConstraintFieldsEN = new clsvConstraintFieldsEN();
try
{
objvConstraintFieldsEN.mId = TransNullToInt(objRow[convConstraintFields.mId].ToString().Trim()); //mId
objvConstraintFieldsEN.PrjConstraintId = objRow[convConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objvConstraintFieldsEN.ConstraintName = objRow[convConstraintFields.ConstraintName].ToString().Trim(); //约束名
objvConstraintFieldsEN.ConstraintTypeId = objRow[convConstraintFields.ConstraintTypeId] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvConstraintFieldsEN.ConstraintTypeName = objRow[convConstraintFields.ConstraintTypeName] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeName].ToString().Trim(); //约束类型名
objvConstraintFieldsEN.TabId = objRow[convConstraintFields.TabId].ToString().Trim(); //表ID
objvConstraintFieldsEN.TabName = objRow[convConstraintFields.TabName].ToString().Trim(); //表名
objvConstraintFieldsEN.TabCnName = objRow[convConstraintFields.TabCnName] == DBNull.Value ? null : objRow[convConstraintFields.TabCnName].ToString().Trim(); //表中文名
objvConstraintFieldsEN.FldId = objRow[convConstraintFields.FldId].ToString().Trim(); //字段Id
objvConstraintFieldsEN.FldName = objRow[convConstraintFields.FldName].ToString().Trim(); //字段名
objvConstraintFieldsEN.FldCnName = objRow[convConstraintFields.FldCnName] == DBNull.Value ? null : objRow[convConstraintFields.FldCnName].ToString().Trim(); //字段中文详名
objvConstraintFieldsEN.MaxValue = objRow[convConstraintFields.MaxValue] == DBNull.Value ? null : objRow[convConstraintFields.MaxValue].ToString().Trim(); //最大值
objvConstraintFieldsEN.MinValue = objRow[convConstraintFields.MinValue] == DBNull.Value ? null : objRow[convConstraintFields.MinValue].ToString().Trim(); //最小值
objvConstraintFieldsEN.SortTypeId = objRow[convConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objvConstraintFieldsEN.SortTypeName = objRow[convConstraintFields.SortTypeName].ToString().Trim(); //排序类型名称
objvConstraintFieldsEN.InUse = TransNullToBool(objRow[convConstraintFields.InUse].ToString().Trim()); //是否在用
objvConstraintFieldsEN.OrderNum = TransNullToInt(objRow[convConstraintFields.OrderNum].ToString().Trim()); //序号
objvConstraintFieldsEN.PrjId = objRow[convConstraintFields.PrjId] == DBNull.Value ? null : objRow[convConstraintFields.PrjId].ToString().Trim(); //工程Id
objvConstraintFieldsEN.UpdDate = objRow[convConstraintFields.UpdDate] == DBNull.Value ? null : objRow[convConstraintFields.UpdDate].ToString().Trim(); //修改日期
objvConstraintFieldsEN.UpdUser = objRow[convConstraintFields.UpdUser] == DBNull.Value ? null : objRow[convConstraintFields.UpdUser].ToString().Trim(); //修改者
objvConstraintFieldsEN.Memo = objRow[convConstraintFields.Memo] == DBNull.Value ? null : objRow[convConstraintFields.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvConstraintFieldsDA: GetObjLst)", objException.Message));
}
objvConstraintFieldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvConstraintFieldsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvConstraintFieldsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvConstraintFields(ref clsvConstraintFieldsEN objvConstraintFieldsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
strSQL = "Select * from vConstraintFields where mId = " + ""+ objvConstraintFieldsEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvConstraintFieldsEN.mId = TransNullToInt(objDT.Rows[0][convConstraintFields.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvConstraintFieldsEN.PrjConstraintId = objDT.Rows[0][convConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id(字段类型:char,字段长度:8,是否可空:False)
 objvConstraintFieldsEN.ConstraintName = objDT.Rows[0][convConstraintFields.ConstraintName].ToString().Trim(); //约束名(字段类型:varchar,字段长度:100,是否可空:False)
 objvConstraintFieldsEN.ConstraintTypeId = objDT.Rows[0][convConstraintFields.ConstraintTypeId].ToString().Trim(); //约束类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvConstraintFieldsEN.ConstraintTypeName = objDT.Rows[0][convConstraintFields.ConstraintTypeName].ToString().Trim(); //约束类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvConstraintFieldsEN.TabId = objDT.Rows[0][convConstraintFields.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvConstraintFieldsEN.TabName = objDT.Rows[0][convConstraintFields.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvConstraintFieldsEN.TabCnName = objDT.Rows[0][convConstraintFields.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvConstraintFieldsEN.FldId = objDT.Rows[0][convConstraintFields.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvConstraintFieldsEN.FldName = objDT.Rows[0][convConstraintFields.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvConstraintFieldsEN.FldCnName = objDT.Rows[0][convConstraintFields.FldCnName].ToString().Trim(); //字段中文详名(字段类型:varchar,字段长度:200,是否可空:True)
 objvConstraintFieldsEN.MaxValue = objDT.Rows[0][convConstraintFields.MaxValue].ToString().Trim(); //最大值(字段类型:varchar,字段长度:50,是否可空:True)
 objvConstraintFieldsEN.MinValue = objDT.Rows[0][convConstraintFields.MinValue].ToString().Trim(); //最小值(字段类型:varchar,字段长度:50,是否可空:True)
 objvConstraintFieldsEN.SortTypeId = objDT.Rows[0][convConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvConstraintFieldsEN.SortTypeName = objDT.Rows[0][convConstraintFields.SortTypeName].ToString().Trim(); //排序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvConstraintFieldsEN.InUse = TransNullToBool(objDT.Rows[0][convConstraintFields.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvConstraintFieldsEN.OrderNum = TransNullToInt(objDT.Rows[0][convConstraintFields.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvConstraintFieldsEN.PrjId = objDT.Rows[0][convConstraintFields.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvConstraintFieldsEN.UpdDate = objDT.Rows[0][convConstraintFields.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvConstraintFieldsEN.UpdUser = objDT.Rows[0][convConstraintFields.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvConstraintFieldsEN.Memo = objDT.Rows[0][convConstraintFields.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvConstraintFieldsDA: GetvConstraintFields)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvConstraintFieldsEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
strSQL = "Select * from vConstraintFields where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvConstraintFieldsEN objvConstraintFieldsEN = new clsvConstraintFieldsEN();
try
{
 objvConstraintFieldsEN.mId = Int32.Parse(objRow[convConstraintFields.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvConstraintFieldsEN.PrjConstraintId = objRow[convConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id(字段类型:char,字段长度:8,是否可空:False)
 objvConstraintFieldsEN.ConstraintName = objRow[convConstraintFields.ConstraintName].ToString().Trim(); //约束名(字段类型:varchar,字段长度:100,是否可空:False)
 objvConstraintFieldsEN.ConstraintTypeId = objRow[convConstraintFields.ConstraintTypeId] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeId].ToString().Trim(); //约束类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvConstraintFieldsEN.ConstraintTypeName = objRow[convConstraintFields.ConstraintTypeName] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeName].ToString().Trim(); //约束类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvConstraintFieldsEN.TabId = objRow[convConstraintFields.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvConstraintFieldsEN.TabName = objRow[convConstraintFields.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvConstraintFieldsEN.TabCnName = objRow[convConstraintFields.TabCnName] == DBNull.Value ? null : objRow[convConstraintFields.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvConstraintFieldsEN.FldId = objRow[convConstraintFields.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvConstraintFieldsEN.FldName = objRow[convConstraintFields.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvConstraintFieldsEN.FldCnName = objRow[convConstraintFields.FldCnName] == DBNull.Value ? null : objRow[convConstraintFields.FldCnName].ToString().Trim(); //字段中文详名(字段类型:varchar,字段长度:200,是否可空:True)
 objvConstraintFieldsEN.MaxValue = objRow[convConstraintFields.MaxValue] == DBNull.Value ? null : objRow[convConstraintFields.MaxValue].ToString().Trim(); //最大值(字段类型:varchar,字段长度:50,是否可空:True)
 objvConstraintFieldsEN.MinValue = objRow[convConstraintFields.MinValue] == DBNull.Value ? null : objRow[convConstraintFields.MinValue].ToString().Trim(); //最小值(字段类型:varchar,字段长度:50,是否可空:True)
 objvConstraintFieldsEN.SortTypeId = objRow[convConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvConstraintFieldsEN.SortTypeName = objRow[convConstraintFields.SortTypeName].ToString().Trim(); //排序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvConstraintFieldsEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convConstraintFields.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvConstraintFieldsEN.OrderNum = Int32.Parse(objRow[convConstraintFields.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvConstraintFieldsEN.PrjId = objRow[convConstraintFields.PrjId] == DBNull.Value ? null : objRow[convConstraintFields.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvConstraintFieldsEN.UpdDate = objRow[convConstraintFields.UpdDate] == DBNull.Value ? null : objRow[convConstraintFields.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvConstraintFieldsEN.UpdUser = objRow[convConstraintFields.UpdUser] == DBNull.Value ? null : objRow[convConstraintFields.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvConstraintFieldsEN.Memo = objRow[convConstraintFields.Memo] == DBNull.Value ? null : objRow[convConstraintFields.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvConstraintFieldsDA: GetObjBymId)", objException.Message));
}
return objvConstraintFieldsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvConstraintFieldsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvConstraintFieldsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
strSQL = "Select * from vConstraintFields where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvConstraintFieldsEN objvConstraintFieldsEN = new clsvConstraintFieldsEN()
{
mId = TransNullToInt(objRow[convConstraintFields.mId].ToString().Trim()), //mId
PrjConstraintId = objRow[convConstraintFields.PrjConstraintId].ToString().Trim(), //约束表Id
ConstraintName = objRow[convConstraintFields.ConstraintName].ToString().Trim(), //约束名
ConstraintTypeId = objRow[convConstraintFields.ConstraintTypeId] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeId].ToString().Trim(), //约束类型Id
ConstraintTypeName = objRow[convConstraintFields.ConstraintTypeName] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeName].ToString().Trim(), //约束类型名
TabId = objRow[convConstraintFields.TabId].ToString().Trim(), //表ID
TabName = objRow[convConstraintFields.TabName].ToString().Trim(), //表名
TabCnName = objRow[convConstraintFields.TabCnName] == DBNull.Value ? null : objRow[convConstraintFields.TabCnName].ToString().Trim(), //表中文名
FldId = objRow[convConstraintFields.FldId].ToString().Trim(), //字段Id
FldName = objRow[convConstraintFields.FldName].ToString().Trim(), //字段名
FldCnName = objRow[convConstraintFields.FldCnName] == DBNull.Value ? null : objRow[convConstraintFields.FldCnName].ToString().Trim(), //字段中文详名
MaxValue = objRow[convConstraintFields.MaxValue] == DBNull.Value ? null : objRow[convConstraintFields.MaxValue].ToString().Trim(), //最大值
MinValue = objRow[convConstraintFields.MinValue] == DBNull.Value ? null : objRow[convConstraintFields.MinValue].ToString().Trim(), //最小值
SortTypeId = objRow[convConstraintFields.SortTypeId].ToString().Trim(), //排序类型Id
SortTypeName = objRow[convConstraintFields.SortTypeName].ToString().Trim(), //排序类型名称
InUse = TransNullToBool(objRow[convConstraintFields.InUse].ToString().Trim()), //是否在用
OrderNum = TransNullToInt(objRow[convConstraintFields.OrderNum].ToString().Trim()), //序号
PrjId = objRow[convConstraintFields.PrjId] == DBNull.Value ? null : objRow[convConstraintFields.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[convConstraintFields.UpdDate] == DBNull.Value ? null : objRow[convConstraintFields.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convConstraintFields.UpdUser] == DBNull.Value ? null : objRow[convConstraintFields.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convConstraintFields.Memo] == DBNull.Value ? null : objRow[convConstraintFields.Memo].ToString().Trim() //说明
};
objvConstraintFieldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvConstraintFieldsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvConstraintFieldsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvConstraintFieldsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvConstraintFieldsEN objvConstraintFieldsEN = new clsvConstraintFieldsEN();
try
{
objvConstraintFieldsEN.mId = TransNullToInt(objRow[convConstraintFields.mId].ToString().Trim()); //mId
objvConstraintFieldsEN.PrjConstraintId = objRow[convConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objvConstraintFieldsEN.ConstraintName = objRow[convConstraintFields.ConstraintName].ToString().Trim(); //约束名
objvConstraintFieldsEN.ConstraintTypeId = objRow[convConstraintFields.ConstraintTypeId] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvConstraintFieldsEN.ConstraintTypeName = objRow[convConstraintFields.ConstraintTypeName] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeName].ToString().Trim(); //约束类型名
objvConstraintFieldsEN.TabId = objRow[convConstraintFields.TabId].ToString().Trim(); //表ID
objvConstraintFieldsEN.TabName = objRow[convConstraintFields.TabName].ToString().Trim(); //表名
objvConstraintFieldsEN.TabCnName = objRow[convConstraintFields.TabCnName] == DBNull.Value ? null : objRow[convConstraintFields.TabCnName].ToString().Trim(); //表中文名
objvConstraintFieldsEN.FldId = objRow[convConstraintFields.FldId].ToString().Trim(); //字段Id
objvConstraintFieldsEN.FldName = objRow[convConstraintFields.FldName].ToString().Trim(); //字段名
objvConstraintFieldsEN.FldCnName = objRow[convConstraintFields.FldCnName] == DBNull.Value ? null : objRow[convConstraintFields.FldCnName].ToString().Trim(); //字段中文详名
objvConstraintFieldsEN.MaxValue = objRow[convConstraintFields.MaxValue] == DBNull.Value ? null : objRow[convConstraintFields.MaxValue].ToString().Trim(); //最大值
objvConstraintFieldsEN.MinValue = objRow[convConstraintFields.MinValue] == DBNull.Value ? null : objRow[convConstraintFields.MinValue].ToString().Trim(); //最小值
objvConstraintFieldsEN.SortTypeId = objRow[convConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objvConstraintFieldsEN.SortTypeName = objRow[convConstraintFields.SortTypeName].ToString().Trim(); //排序类型名称
objvConstraintFieldsEN.InUse = TransNullToBool(objRow[convConstraintFields.InUse].ToString().Trim()); //是否在用
objvConstraintFieldsEN.OrderNum = TransNullToInt(objRow[convConstraintFields.OrderNum].ToString().Trim()); //序号
objvConstraintFieldsEN.PrjId = objRow[convConstraintFields.PrjId] == DBNull.Value ? null : objRow[convConstraintFields.PrjId].ToString().Trim(); //工程Id
objvConstraintFieldsEN.UpdDate = objRow[convConstraintFields.UpdDate] == DBNull.Value ? null : objRow[convConstraintFields.UpdDate].ToString().Trim(); //修改日期
objvConstraintFieldsEN.UpdUser = objRow[convConstraintFields.UpdUser] == DBNull.Value ? null : objRow[convConstraintFields.UpdUser].ToString().Trim(); //修改者
objvConstraintFieldsEN.Memo = objRow[convConstraintFields.Memo] == DBNull.Value ? null : objRow[convConstraintFields.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvConstraintFieldsDA: GetObjByDataRowvConstraintFields)", objException.Message));
}
objvConstraintFieldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvConstraintFieldsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvConstraintFieldsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvConstraintFieldsEN objvConstraintFieldsEN = new clsvConstraintFieldsEN();
try
{
objvConstraintFieldsEN.mId = TransNullToInt(objRow[convConstraintFields.mId].ToString().Trim()); //mId
objvConstraintFieldsEN.PrjConstraintId = objRow[convConstraintFields.PrjConstraintId].ToString().Trim(); //约束表Id
objvConstraintFieldsEN.ConstraintName = objRow[convConstraintFields.ConstraintName].ToString().Trim(); //约束名
objvConstraintFieldsEN.ConstraintTypeId = objRow[convConstraintFields.ConstraintTypeId] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeId].ToString().Trim(); //约束类型Id
objvConstraintFieldsEN.ConstraintTypeName = objRow[convConstraintFields.ConstraintTypeName] == DBNull.Value ? null : objRow[convConstraintFields.ConstraintTypeName].ToString().Trim(); //约束类型名
objvConstraintFieldsEN.TabId = objRow[convConstraintFields.TabId].ToString().Trim(); //表ID
objvConstraintFieldsEN.TabName = objRow[convConstraintFields.TabName].ToString().Trim(); //表名
objvConstraintFieldsEN.TabCnName = objRow[convConstraintFields.TabCnName] == DBNull.Value ? null : objRow[convConstraintFields.TabCnName].ToString().Trim(); //表中文名
objvConstraintFieldsEN.FldId = objRow[convConstraintFields.FldId].ToString().Trim(); //字段Id
objvConstraintFieldsEN.FldName = objRow[convConstraintFields.FldName].ToString().Trim(); //字段名
objvConstraintFieldsEN.FldCnName = objRow[convConstraintFields.FldCnName] == DBNull.Value ? null : objRow[convConstraintFields.FldCnName].ToString().Trim(); //字段中文详名
objvConstraintFieldsEN.MaxValue = objRow[convConstraintFields.MaxValue] == DBNull.Value ? null : objRow[convConstraintFields.MaxValue].ToString().Trim(); //最大值
objvConstraintFieldsEN.MinValue = objRow[convConstraintFields.MinValue] == DBNull.Value ? null : objRow[convConstraintFields.MinValue].ToString().Trim(); //最小值
objvConstraintFieldsEN.SortTypeId = objRow[convConstraintFields.SortTypeId].ToString().Trim(); //排序类型Id
objvConstraintFieldsEN.SortTypeName = objRow[convConstraintFields.SortTypeName].ToString().Trim(); //排序类型名称
objvConstraintFieldsEN.InUse = TransNullToBool(objRow[convConstraintFields.InUse].ToString().Trim()); //是否在用
objvConstraintFieldsEN.OrderNum = TransNullToInt(objRow[convConstraintFields.OrderNum].ToString().Trim()); //序号
objvConstraintFieldsEN.PrjId = objRow[convConstraintFields.PrjId] == DBNull.Value ? null : objRow[convConstraintFields.PrjId].ToString().Trim(); //工程Id
objvConstraintFieldsEN.UpdDate = objRow[convConstraintFields.UpdDate] == DBNull.Value ? null : objRow[convConstraintFields.UpdDate].ToString().Trim(); //修改日期
objvConstraintFieldsEN.UpdUser = objRow[convConstraintFields.UpdUser] == DBNull.Value ? null : objRow[convConstraintFields.UpdUser].ToString().Trim(); //修改者
objvConstraintFieldsEN.Memo = objRow[convConstraintFields.Memo] == DBNull.Value ? null : objRow[convConstraintFields.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvConstraintFieldsDA: GetObjByDataRow)", objException.Message));
}
objvConstraintFieldsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvConstraintFieldsEN;
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
objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvConstraintFieldsEN._CurrTabName, convConstraintFields.mId, 8, "");
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
objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvConstraintFieldsEN._CurrTabName, convConstraintFields.mId, 8, strPrefix);
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
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vConstraintFields where " + strCondition;
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
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vConstraintFields where " + strCondition;
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
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vConstraintFields", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvConstraintFieldsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vConstraintFields", strCondition))
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
objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vConstraintFields");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvConstraintFieldsENS">源对象</param>
 /// <param name = "objvConstraintFieldsENT">目标对象</param>
public void CopyTo(clsvConstraintFieldsEN objvConstraintFieldsENS, clsvConstraintFieldsEN objvConstraintFieldsENT)
{
objvConstraintFieldsENT.mId = objvConstraintFieldsENS.mId; //mId
objvConstraintFieldsENT.PrjConstraintId = objvConstraintFieldsENS.PrjConstraintId; //约束表Id
objvConstraintFieldsENT.ConstraintName = objvConstraintFieldsENS.ConstraintName; //约束名
objvConstraintFieldsENT.ConstraintTypeId = objvConstraintFieldsENS.ConstraintTypeId; //约束类型Id
objvConstraintFieldsENT.ConstraintTypeName = objvConstraintFieldsENS.ConstraintTypeName; //约束类型名
objvConstraintFieldsENT.TabId = objvConstraintFieldsENS.TabId; //表ID
objvConstraintFieldsENT.TabName = objvConstraintFieldsENS.TabName; //表名
objvConstraintFieldsENT.TabCnName = objvConstraintFieldsENS.TabCnName; //表中文名
objvConstraintFieldsENT.FldId = objvConstraintFieldsENS.FldId; //字段Id
objvConstraintFieldsENT.FldName = objvConstraintFieldsENS.FldName; //字段名
objvConstraintFieldsENT.FldCnName = objvConstraintFieldsENS.FldCnName; //字段中文详名
objvConstraintFieldsENT.MaxValue = objvConstraintFieldsENS.MaxValue; //最大值
objvConstraintFieldsENT.MinValue = objvConstraintFieldsENS.MinValue; //最小值
objvConstraintFieldsENT.SortTypeId = objvConstraintFieldsENS.SortTypeId; //排序类型Id
objvConstraintFieldsENT.SortTypeName = objvConstraintFieldsENS.SortTypeName; //排序类型名称
objvConstraintFieldsENT.InUse = objvConstraintFieldsENS.InUse; //是否在用
objvConstraintFieldsENT.OrderNum = objvConstraintFieldsENS.OrderNum; //序号
objvConstraintFieldsENT.PrjId = objvConstraintFieldsENS.PrjId; //工程Id
objvConstraintFieldsENT.UpdDate = objvConstraintFieldsENS.UpdDate; //修改日期
objvConstraintFieldsENT.UpdUser = objvConstraintFieldsENS.UpdUser; //修改者
objvConstraintFieldsENT.Memo = objvConstraintFieldsENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvConstraintFieldsEN objvConstraintFieldsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvConstraintFieldsEN.PrjConstraintId, 8, convConstraintFields.PrjConstraintId);
clsCheckSql.CheckFieldLen(objvConstraintFieldsEN.ConstraintName, 100, convConstraintFields.ConstraintName);
clsCheckSql.CheckFieldLen(objvConstraintFieldsEN.ConstraintTypeId, 2, convConstraintFields.ConstraintTypeId);
clsCheckSql.CheckFieldLen(objvConstraintFieldsEN.ConstraintTypeName, 50, convConstraintFields.ConstraintTypeName);
clsCheckSql.CheckFieldLen(objvConstraintFieldsEN.TabId, 8, convConstraintFields.TabId);
clsCheckSql.CheckFieldLen(objvConstraintFieldsEN.TabName, 100, convConstraintFields.TabName);
clsCheckSql.CheckFieldLen(objvConstraintFieldsEN.TabCnName, 200, convConstraintFields.TabCnName);
clsCheckSql.CheckFieldLen(objvConstraintFieldsEN.FldId, 8, convConstraintFields.FldId);
clsCheckSql.CheckFieldLen(objvConstraintFieldsEN.FldName, 50, convConstraintFields.FldName);
clsCheckSql.CheckFieldLen(objvConstraintFieldsEN.FldCnName, 200, convConstraintFields.FldCnName);
clsCheckSql.CheckFieldLen(objvConstraintFieldsEN.MaxValue, 50, convConstraintFields.MaxValue);
clsCheckSql.CheckFieldLen(objvConstraintFieldsEN.MinValue, 50, convConstraintFields.MinValue);
clsCheckSql.CheckFieldLen(objvConstraintFieldsEN.SortTypeId, 2, convConstraintFields.SortTypeId);
clsCheckSql.CheckFieldLen(objvConstraintFieldsEN.SortTypeName, 30, convConstraintFields.SortTypeName);
clsCheckSql.CheckFieldLen(objvConstraintFieldsEN.PrjId, 4, convConstraintFields.PrjId);
clsCheckSql.CheckFieldLen(objvConstraintFieldsEN.UpdDate, 20, convConstraintFields.UpdDate);
clsCheckSql.CheckFieldLen(objvConstraintFieldsEN.UpdUser, 20, convConstraintFields.UpdUser);
clsCheckSql.CheckFieldLen(objvConstraintFieldsEN.Memo, 1000, convConstraintFields.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvConstraintFieldsEN.PrjConstraintId, convConstraintFields.PrjConstraintId);
clsCheckSql.CheckSqlInjection4Field(objvConstraintFieldsEN.ConstraintName, convConstraintFields.ConstraintName);
clsCheckSql.CheckSqlInjection4Field(objvConstraintFieldsEN.ConstraintTypeId, convConstraintFields.ConstraintTypeId);
clsCheckSql.CheckSqlInjection4Field(objvConstraintFieldsEN.ConstraintTypeName, convConstraintFields.ConstraintTypeName);
clsCheckSql.CheckSqlInjection4Field(objvConstraintFieldsEN.TabId, convConstraintFields.TabId);
clsCheckSql.CheckSqlInjection4Field(objvConstraintFieldsEN.TabName, convConstraintFields.TabName);
clsCheckSql.CheckSqlInjection4Field(objvConstraintFieldsEN.TabCnName, convConstraintFields.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objvConstraintFieldsEN.FldId, convConstraintFields.FldId);
clsCheckSql.CheckSqlInjection4Field(objvConstraintFieldsEN.FldName, convConstraintFields.FldName);
clsCheckSql.CheckSqlInjection4Field(objvConstraintFieldsEN.FldCnName, convConstraintFields.FldCnName);
clsCheckSql.CheckSqlInjection4Field(objvConstraintFieldsEN.MaxValue, convConstraintFields.MaxValue);
clsCheckSql.CheckSqlInjection4Field(objvConstraintFieldsEN.MinValue, convConstraintFields.MinValue);
clsCheckSql.CheckSqlInjection4Field(objvConstraintFieldsEN.SortTypeId, convConstraintFields.SortTypeId);
clsCheckSql.CheckSqlInjection4Field(objvConstraintFieldsEN.SortTypeName, convConstraintFields.SortTypeName);
clsCheckSql.CheckSqlInjection4Field(objvConstraintFieldsEN.PrjId, convConstraintFields.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvConstraintFieldsEN.UpdDate, convConstraintFields.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvConstraintFieldsEN.UpdUser, convConstraintFields.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvConstraintFieldsEN.Memo, convConstraintFields.Memo);
//检查外键字段长度
 objvConstraintFieldsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetmId()
{
//获取某学院所有专业信息
string strSQL = "select mId, ConstraintName from vConstraintFields ";
 clsSpecSQLforSql mySql = clsvConstraintFieldsDA.GetSpecSQLObj();
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
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
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
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
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
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvConstraintFieldsEN._CurrTabName);
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
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvConstraintFieldsEN._CurrTabName, strCondition);
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
 objSQL = clsvConstraintFieldsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}