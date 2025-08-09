
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFieldTab4RootFldDA
 表名:vFieldTab4RootFld(00050406)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:10
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
 /// v工程字段4RootFld(vFieldTab4RootFld)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFieldTab4RootFldDA : clsCommBase4DA
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
 return clsvFieldTab4RootFldEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFieldTab4RootFldEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFieldTab4RootFldEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFieldTab4RootFldEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFieldTab4RootFldEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFieldTab4RootFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab4RootFld where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFieldTab4RootFld(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFieldTab4RootFldDA: GetDataTable_vFieldTab4RootFld)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab4RootFld where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFieldTab4RootFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFieldTab4RootFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab4RootFld where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFieldTab4RootFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFieldTab4RootFldDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab4RootFld where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab4RootFld where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFieldTab4RootFldDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFieldTab4RootFld where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFieldTab4RootFldDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFieldTab4RootFld.* " + 
$"from vFieldTab4RootFld " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFieldTab4RootFld.mId not in " + 
$"(Select top {intTop_In} vFieldTab4RootFld.mId from vFieldTab4RootFld " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab4RootFld where {1} and mId not in (Select top {2} mId from vFieldTab4RootFld where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab4RootFld where {1} and mId not in (Select top {3} mId from vFieldTab4RootFld where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFieldTab4RootFldDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFieldTab4RootFld.* " + 
$"from vFieldTab4RootFld " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFieldTab4RootFld.mId not in " + 
$"(Select top {intTop_In} vFieldTab4RootFld.mId from vFieldTab4RootFld " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab4RootFld where {1} and mId not in (Select top {2} mId from vFieldTab4RootFld where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFieldTab4RootFld where {1} and mId not in (Select top {3} mId from vFieldTab4RootFld where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFieldTab4RootFldEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFieldTab4RootFldDA:GetObjLst)", objException.Message));
}
List<clsvFieldTab4RootFldEN> arrObjLst = new List<clsvFieldTab4RootFldEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab4RootFld where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = new clsvFieldTab4RootFldEN();
try
{
objvFieldTab4RootFldEN.TabName = objRow[convFieldTab4RootFld.TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.TabName].ToString().Trim(); //表名
objvFieldTab4RootFldEN.TabNum = objRow[convFieldTab4RootFld.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab4RootFld.TabNum].ToString().Trim()); //表数
objvFieldTab4RootFldEN.FldName = objRow[convFieldTab4RootFld.FldName].ToString().Trim(); //字段名
objvFieldTab4RootFldEN.FldCnName = objRow[convFieldTab4RootFld.FldCnName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTab4RootFldEN.Caption = objRow[convFieldTab4RootFld.Caption].ToString().Trim(); //标题
objvFieldTab4RootFldEN.DataTypeId = objRow[convFieldTab4RootFld.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab4RootFldEN.DataTypeName = objRow[convFieldTab4RootFld.DataTypeName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab4RootFldEN.FldLength = TransNullToInt(objRow[convFieldTab4RootFld.FldLength].ToString().Trim()); //字段长度
objvFieldTab4RootFldEN.FldPrecision = objRow[convFieldTab4RootFld.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab4RootFld.FldPrecision].ToString().Trim()); //精确度
objvFieldTab4RootFldEN.FldInfo = objRow[convFieldTab4RootFld.FldInfo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldInfo].ToString().Trim(); //字段信息
objvFieldTab4RootFldEN.IsNull = TransNullToBool(objRow[convFieldTab4RootFld.IsNull].ToString().Trim()); //是否可空
objvFieldTab4RootFldEN.IsIdentity = TransNullToBool(objRow[convFieldTab4RootFld.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab4RootFldEN.IsOnlyOne = TransNullToBool(objRow[convFieldTab4RootFld.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab4RootFldEN.MaxValue = objRow[convFieldTab4RootFld.MaxValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MaxValue].ToString().Trim(); //最大值
objvFieldTab4RootFldEN.MinValue = objRow[convFieldTab4RootFld.MinValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MinValue].ToString().Trim(); //最小值
objvFieldTab4RootFldEN.DefaultValue = objRow[convFieldTab4RootFld.DefaultValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab4RootFldEN.FldStateId = objRow[convFieldTab4RootFld.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTab4RootFldEN.mId = TransNullToInt(objRow[convFieldTab4RootFld.mId].ToString().Trim()); //mId
objvFieldTab4RootFldEN.TabId = objRow[convFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objvFieldTab4RootFldEN.FldId = objRow[convFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objvFieldTab4RootFldEN.IsPrimaryKey = TransNullToBool(objRow[convFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab4RootFldEN.IsRootFld = TransNullToBool(objRow[convFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objvFieldTab4RootFldEN.Root4TabId = objRow[convFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objvFieldTab4RootFldEN.RootFldId = objRow[convFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objvFieldTab4RootFldEN.RootTabId = objRow[convFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objvFieldTab4RootFldEN.PrjId = objRow[convFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objvFieldTab4RootFldEN.UpdUser = objRow[convFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objvFieldTab4RootFldEN.UpdDate = objRow[convFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4RootFldEN.Memo = objRow[convFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Memo].ToString().Trim(); //说明
objvFieldTab4RootFldEN.RootFldName = objRow[convFieldTab4RootFld.RootFldName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldName].ToString().Trim(); //RootFldName
objvFieldTab4RootFldEN.RootTabName = objRow[convFieldTab4RootFld.RootTabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabName].ToString().Trim(); //根表
objvFieldTab4RootFldEN.Root4TabName = objRow[convFieldTab4RootFld.Root4TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabName].ToString().Trim(); //主根表
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFieldTab4RootFldDA: GetObjLst)", objException.Message));
}
objvFieldTab4RootFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFieldTab4RootFldEN);
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
public List<clsvFieldTab4RootFldEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFieldTab4RootFldDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFieldTab4RootFldEN> arrObjLst = new List<clsvFieldTab4RootFldEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = new clsvFieldTab4RootFldEN();
try
{
objvFieldTab4RootFldEN.TabName = objRow[convFieldTab4RootFld.TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.TabName].ToString().Trim(); //表名
objvFieldTab4RootFldEN.TabNum = objRow[convFieldTab4RootFld.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab4RootFld.TabNum].ToString().Trim()); //表数
objvFieldTab4RootFldEN.FldName = objRow[convFieldTab4RootFld.FldName].ToString().Trim(); //字段名
objvFieldTab4RootFldEN.FldCnName = objRow[convFieldTab4RootFld.FldCnName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTab4RootFldEN.Caption = objRow[convFieldTab4RootFld.Caption].ToString().Trim(); //标题
objvFieldTab4RootFldEN.DataTypeId = objRow[convFieldTab4RootFld.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab4RootFldEN.DataTypeName = objRow[convFieldTab4RootFld.DataTypeName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab4RootFldEN.FldLength = TransNullToInt(objRow[convFieldTab4RootFld.FldLength].ToString().Trim()); //字段长度
objvFieldTab4RootFldEN.FldPrecision = objRow[convFieldTab4RootFld.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab4RootFld.FldPrecision].ToString().Trim()); //精确度
objvFieldTab4RootFldEN.FldInfo = objRow[convFieldTab4RootFld.FldInfo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldInfo].ToString().Trim(); //字段信息
objvFieldTab4RootFldEN.IsNull = TransNullToBool(objRow[convFieldTab4RootFld.IsNull].ToString().Trim()); //是否可空
objvFieldTab4RootFldEN.IsIdentity = TransNullToBool(objRow[convFieldTab4RootFld.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab4RootFldEN.IsOnlyOne = TransNullToBool(objRow[convFieldTab4RootFld.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab4RootFldEN.MaxValue = objRow[convFieldTab4RootFld.MaxValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MaxValue].ToString().Trim(); //最大值
objvFieldTab4RootFldEN.MinValue = objRow[convFieldTab4RootFld.MinValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MinValue].ToString().Trim(); //最小值
objvFieldTab4RootFldEN.DefaultValue = objRow[convFieldTab4RootFld.DefaultValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab4RootFldEN.FldStateId = objRow[convFieldTab4RootFld.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTab4RootFldEN.mId = TransNullToInt(objRow[convFieldTab4RootFld.mId].ToString().Trim()); //mId
objvFieldTab4RootFldEN.TabId = objRow[convFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objvFieldTab4RootFldEN.FldId = objRow[convFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objvFieldTab4RootFldEN.IsPrimaryKey = TransNullToBool(objRow[convFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab4RootFldEN.IsRootFld = TransNullToBool(objRow[convFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objvFieldTab4RootFldEN.Root4TabId = objRow[convFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objvFieldTab4RootFldEN.RootFldId = objRow[convFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objvFieldTab4RootFldEN.RootTabId = objRow[convFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objvFieldTab4RootFldEN.PrjId = objRow[convFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objvFieldTab4RootFldEN.UpdUser = objRow[convFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objvFieldTab4RootFldEN.UpdDate = objRow[convFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4RootFldEN.Memo = objRow[convFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Memo].ToString().Trim(); //说明
objvFieldTab4RootFldEN.RootFldName = objRow[convFieldTab4RootFld.RootFldName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldName].ToString().Trim(); //RootFldName
objvFieldTab4RootFldEN.RootTabName = objRow[convFieldTab4RootFld.RootTabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabName].ToString().Trim(); //根表
objvFieldTab4RootFldEN.Root4TabName = objRow[convFieldTab4RootFld.Root4TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabName].ToString().Trim(); //主根表
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFieldTab4RootFldDA: GetObjLst)", objException.Message));
}
objvFieldTab4RootFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFieldTab4RootFldEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFieldTab4RootFld(ref clsvFieldTab4RootFldEN objvFieldTab4RootFldEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab4RootFld where mId = " + ""+ objvFieldTab4RootFldEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFieldTab4RootFldEN.TabName = objDT.Rows[0][convFieldTab4RootFld.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFieldTab4RootFldEN.TabNum = TransNullToInt(objDT.Rows[0][convFieldTab4RootFld.TabNum].ToString().Trim()); //表数(字段类型:int,字段长度:4,是否可空:True)
 objvFieldTab4RootFldEN.FldName = objDT.Rows[0][convFieldTab4RootFld.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFieldTab4RootFldEN.FldCnName = objDT.Rows[0][convFieldTab4RootFld.FldCnName].ToString().Trim(); //字段中文详名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFieldTab4RootFldEN.Caption = objDT.Rows[0][convFieldTab4RootFld.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objvFieldTab4RootFldEN.DataTypeId = objDT.Rows[0][convFieldTab4RootFld.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFieldTab4RootFldEN.DataTypeName = objDT.Rows[0][convFieldTab4RootFld.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvFieldTab4RootFldEN.FldLength = TransNullToInt(objDT.Rows[0][convFieldTab4RootFld.FldLength].ToString().Trim()); //字段长度(字段类型:int,字段长度:4,是否可空:False)
 objvFieldTab4RootFldEN.FldPrecision = TransNullToInt(objDT.Rows[0][convFieldTab4RootFld.FldPrecision].ToString().Trim()); //精确度(字段类型:int,字段长度:4,是否可空:True)
 objvFieldTab4RootFldEN.FldInfo = objDT.Rows[0][convFieldTab4RootFld.FldInfo].ToString().Trim(); //字段信息(字段类型:varchar,字段长度:100,是否可空:True)
 objvFieldTab4RootFldEN.IsNull = TransNullToBool(objDT.Rows[0][convFieldTab4RootFld.IsNull].ToString().Trim()); //是否可空(字段类型:bit,字段长度:1,是否可空:False)
 objvFieldTab4RootFldEN.IsIdentity = TransNullToBool(objDT.Rows[0][convFieldTab4RootFld.IsIdentity].ToString().Trim()); //是否Identity(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTab4RootFldEN.IsOnlyOne = TransNullToBool(objDT.Rows[0][convFieldTab4RootFld.IsOnlyOne].ToString().Trim()); //是否唯一(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTab4RootFldEN.MaxValue = objDT.Rows[0][convFieldTab4RootFld.MaxValue].ToString().Trim(); //最大值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTab4RootFldEN.MinValue = objDT.Rows[0][convFieldTab4RootFld.MinValue].ToString().Trim(); //最小值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTab4RootFldEN.DefaultValue = objDT.Rows[0][convFieldTab4RootFld.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTab4RootFldEN.FldStateId = objDT.Rows[0][convFieldTab4RootFld.FldStateId].ToString().Trim(); //字段状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvFieldTab4RootFldEN.mId = TransNullToInt(objDT.Rows[0][convFieldTab4RootFld.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvFieldTab4RootFldEN.TabId = objDT.Rows[0][convFieldTab4RootFld.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvFieldTab4RootFldEN.FldId = objDT.Rows[0][convFieldTab4RootFld.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvFieldTab4RootFldEN.IsPrimaryKey = TransNullToBool(objDT.Rows[0][convFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键(字段类型:bit,字段长度:1,是否可空:False)
 objvFieldTab4RootFldEN.IsRootFld = TransNullToBool(objDT.Rows[0][convFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTab4RootFldEN.Root4TabId = objDT.Rows[0][convFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id(字段类型:char,字段长度:8,是否可空:True)
 objvFieldTab4RootFldEN.RootFldId = objDT.Rows[0][convFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id(字段类型:char,字段长度:8,是否可空:True)
 objvFieldTab4RootFldEN.RootTabId = objDT.Rows[0][convFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id(字段类型:char,字段长度:8,是否可空:True)
 objvFieldTab4RootFldEN.PrjId = objDT.Rows[0][convFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFieldTab4RootFldEN.UpdUser = objDT.Rows[0][convFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFieldTab4RootFldEN.UpdDate = objDT.Rows[0][convFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFieldTab4RootFldEN.Memo = objDT.Rows[0][convFieldTab4RootFld.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFieldTab4RootFldEN.RootFldName = objDT.Rows[0][convFieldTab4RootFld.RootFldName].ToString().Trim(); //RootFldName(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTab4RootFldEN.RootTabName = objDT.Rows[0][convFieldTab4RootFld.RootTabName].ToString().Trim(); //根表(字段类型:varchar,字段长度:100,是否可空:True)
 objvFieldTab4RootFldEN.Root4TabName = objDT.Rows[0][convFieldTab4RootFld.Root4TabName].ToString().Trim(); //主根表(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFieldTab4RootFldDA: GetvFieldTab4RootFld)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvFieldTab4RootFldEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab4RootFld where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = new clsvFieldTab4RootFldEN();
try
{
 objvFieldTab4RootFldEN.TabName = objRow[convFieldTab4RootFld.TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFieldTab4RootFldEN.TabNum = objRow[convFieldTab4RootFld.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.TabNum].ToString().Trim()); //表数(字段类型:int,字段长度:4,是否可空:True)
 objvFieldTab4RootFldEN.FldName = objRow[convFieldTab4RootFld.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFieldTab4RootFldEN.FldCnName = objRow[convFieldTab4RootFld.FldCnName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldCnName].ToString().Trim(); //字段中文详名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFieldTab4RootFldEN.Caption = objRow[convFieldTab4RootFld.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objvFieldTab4RootFldEN.DataTypeId = objRow[convFieldTab4RootFld.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFieldTab4RootFldEN.DataTypeName = objRow[convFieldTab4RootFld.DataTypeName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvFieldTab4RootFldEN.FldLength = Int32.Parse(objRow[convFieldTab4RootFld.FldLength].ToString().Trim()); //字段长度(字段类型:int,字段长度:4,是否可空:False)
 objvFieldTab4RootFldEN.FldPrecision = objRow[convFieldTab4RootFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFieldTab4RootFld.FldPrecision].ToString().Trim()); //精确度(字段类型:int,字段长度:4,是否可空:True)
 objvFieldTab4RootFldEN.FldInfo = objRow[convFieldTab4RootFld.FldInfo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldInfo].ToString().Trim(); //字段信息(字段类型:varchar,字段长度:100,是否可空:True)
 objvFieldTab4RootFldEN.IsNull = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsNull].ToString().Trim()); //是否可空(字段类型:bit,字段长度:1,是否可空:False)
 objvFieldTab4RootFldEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsIdentity].ToString().Trim()); //是否Identity(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTab4RootFldEN.IsOnlyOne = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsOnlyOne].ToString().Trim()); //是否唯一(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTab4RootFldEN.MaxValue = objRow[convFieldTab4RootFld.MaxValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MaxValue].ToString().Trim(); //最大值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTab4RootFldEN.MinValue = objRow[convFieldTab4RootFld.MinValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MinValue].ToString().Trim(); //最小值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTab4RootFldEN.DefaultValue = objRow[convFieldTab4RootFld.DefaultValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTab4RootFldEN.FldStateId = objRow[convFieldTab4RootFld.FldStateId].ToString().Trim(); //字段状态Id(字段类型:char,字段长度:2,是否可空:False)
 objvFieldTab4RootFldEN.mId = Int32.Parse(objRow[convFieldTab4RootFld.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvFieldTab4RootFldEN.TabId = objRow[convFieldTab4RootFld.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvFieldTab4RootFldEN.FldId = objRow[convFieldTab4RootFld.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键(字段类型:bit,字段长度:1,是否可空:False)
 objvFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[convFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段(字段类型:bit,字段长度:1,是否可空:True)
 objvFieldTab4RootFldEN.Root4TabId = objRow[convFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id(字段类型:char,字段长度:8,是否可空:True)
 objvFieldTab4RootFldEN.RootFldId = objRow[convFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id(字段类型:char,字段长度:8,是否可空:True)
 objvFieldTab4RootFldEN.RootTabId = objRow[convFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id(字段类型:char,字段长度:8,是否可空:True)
 objvFieldTab4RootFldEN.PrjId = objRow[convFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFieldTab4RootFldEN.UpdUser = objRow[convFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFieldTab4RootFldEN.UpdDate = objRow[convFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFieldTab4RootFldEN.Memo = objRow[convFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFieldTab4RootFldEN.RootFldName = objRow[convFieldTab4RootFld.RootFldName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldName].ToString().Trim(); //RootFldName(字段类型:varchar,字段长度:50,是否可空:True)
 objvFieldTab4RootFldEN.RootTabName = objRow[convFieldTab4RootFld.RootTabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabName].ToString().Trim(); //根表(字段类型:varchar,字段长度:100,是否可空:True)
 objvFieldTab4RootFldEN.Root4TabName = objRow[convFieldTab4RootFld.Root4TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabName].ToString().Trim(); //主根表(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFieldTab4RootFldDA: GetObjBymId)", objException.Message));
}
return objvFieldTab4RootFldEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFieldTab4RootFldEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFieldTab4RootFldDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = "Select * from vFieldTab4RootFld where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = new clsvFieldTab4RootFldEN()
{
TabName = objRow[convFieldTab4RootFld.TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.TabName].ToString().Trim(), //表名
TabNum = objRow[convFieldTab4RootFld.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab4RootFld.TabNum].ToString().Trim()), //表数
FldName = objRow[convFieldTab4RootFld.FldName].ToString().Trim(), //字段名
FldCnName = objRow[convFieldTab4RootFld.FldCnName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldCnName].ToString().Trim(), //字段中文详名
Caption = objRow[convFieldTab4RootFld.Caption].ToString().Trim(), //标题
DataTypeId = objRow[convFieldTab4RootFld.DataTypeId].ToString().Trim(), //数据类型Id
DataTypeName = objRow[convFieldTab4RootFld.DataTypeName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DataTypeName].ToString().Trim(), //数据类型名称
FldLength = TransNullToInt(objRow[convFieldTab4RootFld.FldLength].ToString().Trim()), //字段长度
FldPrecision = objRow[convFieldTab4RootFld.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab4RootFld.FldPrecision].ToString().Trim()), //精确度
FldInfo = objRow[convFieldTab4RootFld.FldInfo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldInfo].ToString().Trim(), //字段信息
IsNull = TransNullToBool(objRow[convFieldTab4RootFld.IsNull].ToString().Trim()), //是否可空
IsIdentity = TransNullToBool(objRow[convFieldTab4RootFld.IsIdentity].ToString().Trim()), //是否Identity
IsOnlyOne = TransNullToBool(objRow[convFieldTab4RootFld.IsOnlyOne].ToString().Trim()), //是否唯一
MaxValue = objRow[convFieldTab4RootFld.MaxValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MaxValue].ToString().Trim(), //最大值
MinValue = objRow[convFieldTab4RootFld.MinValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MinValue].ToString().Trim(), //最小值
DefaultValue = objRow[convFieldTab4RootFld.DefaultValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DefaultValue].ToString().Trim(), //缺省值
FldStateId = objRow[convFieldTab4RootFld.FldStateId].ToString().Trim(), //字段状态Id
mId = TransNullToInt(objRow[convFieldTab4RootFld.mId].ToString().Trim()), //mId
TabId = objRow[convFieldTab4RootFld.TabId].ToString().Trim(), //表ID
FldId = objRow[convFieldTab4RootFld.FldId].ToString().Trim(), //字段Id
IsPrimaryKey = TransNullToBool(objRow[convFieldTab4RootFld.IsPrimaryKey].ToString().Trim()), //是否主键
IsRootFld = TransNullToBool(objRow[convFieldTab4RootFld.IsRootFld].ToString().Trim()), //是否根字段
Root4TabId = objRow[convFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabId].ToString().Trim(), //主根表Id
RootFldId = objRow[convFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldId].ToString().Trim(), //根字段Id
RootTabId = objRow[convFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabId].ToString().Trim(), //根表Id
PrjId = objRow[convFieldTab4RootFld.PrjId].ToString().Trim(), //工程Id
UpdUser = objRow[convFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[convFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Memo].ToString().Trim(), //说明
RootFldName = objRow[convFieldTab4RootFld.RootFldName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldName].ToString().Trim(), //RootFldName
RootTabName = objRow[convFieldTab4RootFld.RootTabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabName].ToString().Trim(), //根表
Root4TabName = objRow[convFieldTab4RootFld.Root4TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabName].ToString().Trim() //主根表
};
objvFieldTab4RootFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFieldTab4RootFldEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFieldTab4RootFldDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFieldTab4RootFldEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = new clsvFieldTab4RootFldEN();
try
{
objvFieldTab4RootFldEN.TabName = objRow[convFieldTab4RootFld.TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.TabName].ToString().Trim(); //表名
objvFieldTab4RootFldEN.TabNum = objRow[convFieldTab4RootFld.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab4RootFld.TabNum].ToString().Trim()); //表数
objvFieldTab4RootFldEN.FldName = objRow[convFieldTab4RootFld.FldName].ToString().Trim(); //字段名
objvFieldTab4RootFldEN.FldCnName = objRow[convFieldTab4RootFld.FldCnName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTab4RootFldEN.Caption = objRow[convFieldTab4RootFld.Caption].ToString().Trim(); //标题
objvFieldTab4RootFldEN.DataTypeId = objRow[convFieldTab4RootFld.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab4RootFldEN.DataTypeName = objRow[convFieldTab4RootFld.DataTypeName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab4RootFldEN.FldLength = TransNullToInt(objRow[convFieldTab4RootFld.FldLength].ToString().Trim()); //字段长度
objvFieldTab4RootFldEN.FldPrecision = objRow[convFieldTab4RootFld.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab4RootFld.FldPrecision].ToString().Trim()); //精确度
objvFieldTab4RootFldEN.FldInfo = objRow[convFieldTab4RootFld.FldInfo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldInfo].ToString().Trim(); //字段信息
objvFieldTab4RootFldEN.IsNull = TransNullToBool(objRow[convFieldTab4RootFld.IsNull].ToString().Trim()); //是否可空
objvFieldTab4RootFldEN.IsIdentity = TransNullToBool(objRow[convFieldTab4RootFld.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab4RootFldEN.IsOnlyOne = TransNullToBool(objRow[convFieldTab4RootFld.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab4RootFldEN.MaxValue = objRow[convFieldTab4RootFld.MaxValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MaxValue].ToString().Trim(); //最大值
objvFieldTab4RootFldEN.MinValue = objRow[convFieldTab4RootFld.MinValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MinValue].ToString().Trim(); //最小值
objvFieldTab4RootFldEN.DefaultValue = objRow[convFieldTab4RootFld.DefaultValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab4RootFldEN.FldStateId = objRow[convFieldTab4RootFld.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTab4RootFldEN.mId = TransNullToInt(objRow[convFieldTab4RootFld.mId].ToString().Trim()); //mId
objvFieldTab4RootFldEN.TabId = objRow[convFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objvFieldTab4RootFldEN.FldId = objRow[convFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objvFieldTab4RootFldEN.IsPrimaryKey = TransNullToBool(objRow[convFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab4RootFldEN.IsRootFld = TransNullToBool(objRow[convFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objvFieldTab4RootFldEN.Root4TabId = objRow[convFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objvFieldTab4RootFldEN.RootFldId = objRow[convFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objvFieldTab4RootFldEN.RootTabId = objRow[convFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objvFieldTab4RootFldEN.PrjId = objRow[convFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objvFieldTab4RootFldEN.UpdUser = objRow[convFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objvFieldTab4RootFldEN.UpdDate = objRow[convFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4RootFldEN.Memo = objRow[convFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Memo].ToString().Trim(); //说明
objvFieldTab4RootFldEN.RootFldName = objRow[convFieldTab4RootFld.RootFldName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldName].ToString().Trim(); //RootFldName
objvFieldTab4RootFldEN.RootTabName = objRow[convFieldTab4RootFld.RootTabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabName].ToString().Trim(); //根表
objvFieldTab4RootFldEN.Root4TabName = objRow[convFieldTab4RootFld.Root4TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabName].ToString().Trim(); //主根表
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFieldTab4RootFldDA: GetObjByDataRowvFieldTab4RootFld)", objException.Message));
}
objvFieldTab4RootFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFieldTab4RootFldEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFieldTab4RootFldEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFieldTab4RootFldEN objvFieldTab4RootFldEN = new clsvFieldTab4RootFldEN();
try
{
objvFieldTab4RootFldEN.TabName = objRow[convFieldTab4RootFld.TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.TabName].ToString().Trim(); //表名
objvFieldTab4RootFldEN.TabNum = objRow[convFieldTab4RootFld.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab4RootFld.TabNum].ToString().Trim()); //表数
objvFieldTab4RootFldEN.FldName = objRow[convFieldTab4RootFld.FldName].ToString().Trim(); //字段名
objvFieldTab4RootFldEN.FldCnName = objRow[convFieldTab4RootFld.FldCnName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldCnName].ToString().Trim(); //字段中文详名
objvFieldTab4RootFldEN.Caption = objRow[convFieldTab4RootFld.Caption].ToString().Trim(); //标题
objvFieldTab4RootFldEN.DataTypeId = objRow[convFieldTab4RootFld.DataTypeId].ToString().Trim(); //数据类型Id
objvFieldTab4RootFldEN.DataTypeName = objRow[convFieldTab4RootFld.DataTypeName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DataTypeName].ToString().Trim(); //数据类型名称
objvFieldTab4RootFldEN.FldLength = TransNullToInt(objRow[convFieldTab4RootFld.FldLength].ToString().Trim()); //字段长度
objvFieldTab4RootFldEN.FldPrecision = objRow[convFieldTab4RootFld.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFieldTab4RootFld.FldPrecision].ToString().Trim()); //精确度
objvFieldTab4RootFldEN.FldInfo = objRow[convFieldTab4RootFld.FldInfo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.FldInfo].ToString().Trim(); //字段信息
objvFieldTab4RootFldEN.IsNull = TransNullToBool(objRow[convFieldTab4RootFld.IsNull].ToString().Trim()); //是否可空
objvFieldTab4RootFldEN.IsIdentity = TransNullToBool(objRow[convFieldTab4RootFld.IsIdentity].ToString().Trim()); //是否Identity
objvFieldTab4RootFldEN.IsOnlyOne = TransNullToBool(objRow[convFieldTab4RootFld.IsOnlyOne].ToString().Trim()); //是否唯一
objvFieldTab4RootFldEN.MaxValue = objRow[convFieldTab4RootFld.MaxValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MaxValue].ToString().Trim(); //最大值
objvFieldTab4RootFldEN.MinValue = objRow[convFieldTab4RootFld.MinValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.MinValue].ToString().Trim(); //最小值
objvFieldTab4RootFldEN.DefaultValue = objRow[convFieldTab4RootFld.DefaultValue] == DBNull.Value ? null : objRow[convFieldTab4RootFld.DefaultValue].ToString().Trim(); //缺省值
objvFieldTab4RootFldEN.FldStateId = objRow[convFieldTab4RootFld.FldStateId].ToString().Trim(); //字段状态Id
objvFieldTab4RootFldEN.mId = TransNullToInt(objRow[convFieldTab4RootFld.mId].ToString().Trim()); //mId
objvFieldTab4RootFldEN.TabId = objRow[convFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objvFieldTab4RootFldEN.FldId = objRow[convFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objvFieldTab4RootFldEN.IsPrimaryKey = TransNullToBool(objRow[convFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objvFieldTab4RootFldEN.IsRootFld = TransNullToBool(objRow[convFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objvFieldTab4RootFldEN.Root4TabId = objRow[convFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objvFieldTab4RootFldEN.RootFldId = objRow[convFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objvFieldTab4RootFldEN.RootTabId = objRow[convFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objvFieldTab4RootFldEN.PrjId = objRow[convFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objvFieldTab4RootFldEN.UpdUser = objRow[convFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objvFieldTab4RootFldEN.UpdDate = objRow[convFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[convFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objvFieldTab4RootFldEN.Memo = objRow[convFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Memo].ToString().Trim(); //说明
objvFieldTab4RootFldEN.RootFldName = objRow[convFieldTab4RootFld.RootFldName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootFldName].ToString().Trim(); //RootFldName
objvFieldTab4RootFldEN.RootTabName = objRow[convFieldTab4RootFld.RootTabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.RootTabName].ToString().Trim(); //根表
objvFieldTab4RootFldEN.Root4TabName = objRow[convFieldTab4RootFld.Root4TabName] == DBNull.Value ? null : objRow[convFieldTab4RootFld.Root4TabName].ToString().Trim(); //主根表
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFieldTab4RootFldDA: GetObjByDataRow)", objException.Message));
}
objvFieldTab4RootFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFieldTab4RootFldEN;
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
objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFieldTab4RootFldEN._CurrTabName, convFieldTab4RootFld.mId, 8, "");
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
objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFieldTab4RootFldEN._CurrTabName, convFieldTab4RootFld.mId, 8, strPrefix);
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
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vFieldTab4RootFld where " + strCondition;
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
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vFieldTab4RootFld where " + strCondition;
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
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFieldTab4RootFld", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFieldTab4RootFldDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFieldTab4RootFld", strCondition))
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
objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFieldTab4RootFld");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFieldTab4RootFldENS">源对象</param>
 /// <param name = "objvFieldTab4RootFldENT">目标对象</param>
public void CopyTo(clsvFieldTab4RootFldEN objvFieldTab4RootFldENS, clsvFieldTab4RootFldEN objvFieldTab4RootFldENT)
{
objvFieldTab4RootFldENT.TabName = objvFieldTab4RootFldENS.TabName; //表名
objvFieldTab4RootFldENT.TabNum = objvFieldTab4RootFldENS.TabNum; //表数
objvFieldTab4RootFldENT.FldName = objvFieldTab4RootFldENS.FldName; //字段名
objvFieldTab4RootFldENT.FldCnName = objvFieldTab4RootFldENS.FldCnName; //字段中文详名
objvFieldTab4RootFldENT.Caption = objvFieldTab4RootFldENS.Caption; //标题
objvFieldTab4RootFldENT.DataTypeId = objvFieldTab4RootFldENS.DataTypeId; //数据类型Id
objvFieldTab4RootFldENT.DataTypeName = objvFieldTab4RootFldENS.DataTypeName; //数据类型名称
objvFieldTab4RootFldENT.FldLength = objvFieldTab4RootFldENS.FldLength; //字段长度
objvFieldTab4RootFldENT.FldPrecision = objvFieldTab4RootFldENS.FldPrecision; //精确度
objvFieldTab4RootFldENT.FldInfo = objvFieldTab4RootFldENS.FldInfo; //字段信息
objvFieldTab4RootFldENT.IsNull = objvFieldTab4RootFldENS.IsNull; //是否可空
objvFieldTab4RootFldENT.IsIdentity = objvFieldTab4RootFldENS.IsIdentity; //是否Identity
objvFieldTab4RootFldENT.IsOnlyOne = objvFieldTab4RootFldENS.IsOnlyOne; //是否唯一
objvFieldTab4RootFldENT.MaxValue = objvFieldTab4RootFldENS.MaxValue; //最大值
objvFieldTab4RootFldENT.MinValue = objvFieldTab4RootFldENS.MinValue; //最小值
objvFieldTab4RootFldENT.DefaultValue = objvFieldTab4RootFldENS.DefaultValue; //缺省值
objvFieldTab4RootFldENT.FldStateId = objvFieldTab4RootFldENS.FldStateId; //字段状态Id
objvFieldTab4RootFldENT.mId = objvFieldTab4RootFldENS.mId; //mId
objvFieldTab4RootFldENT.TabId = objvFieldTab4RootFldENS.TabId; //表ID
objvFieldTab4RootFldENT.FldId = objvFieldTab4RootFldENS.FldId; //字段Id
objvFieldTab4RootFldENT.IsPrimaryKey = objvFieldTab4RootFldENS.IsPrimaryKey; //是否主键
objvFieldTab4RootFldENT.IsRootFld = objvFieldTab4RootFldENS.IsRootFld; //是否根字段
objvFieldTab4RootFldENT.Root4TabId = objvFieldTab4RootFldENS.Root4TabId; //主根表Id
objvFieldTab4RootFldENT.RootFldId = objvFieldTab4RootFldENS.RootFldId; //根字段Id
objvFieldTab4RootFldENT.RootTabId = objvFieldTab4RootFldENS.RootTabId; //根表Id
objvFieldTab4RootFldENT.PrjId = objvFieldTab4RootFldENS.PrjId; //工程Id
objvFieldTab4RootFldENT.UpdUser = objvFieldTab4RootFldENS.UpdUser; //修改者
objvFieldTab4RootFldENT.UpdDate = objvFieldTab4RootFldENS.UpdDate; //修改日期
objvFieldTab4RootFldENT.Memo = objvFieldTab4RootFldENS.Memo; //说明
objvFieldTab4RootFldENT.RootFldName = objvFieldTab4RootFldENS.RootFldName; //RootFldName
objvFieldTab4RootFldENT.RootTabName = objvFieldTab4RootFldENS.RootTabName; //根表
objvFieldTab4RootFldENT.Root4TabName = objvFieldTab4RootFldENS.Root4TabName; //主根表
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFieldTab4RootFldEN objvFieldTab4RootFldEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.TabName, 100, convFieldTab4RootFld.TabName);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.FldName, 50, convFieldTab4RootFld.FldName);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.FldCnName, 200, convFieldTab4RootFld.FldCnName);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.Caption, 200, convFieldTab4RootFld.Caption);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.DataTypeId, 2, convFieldTab4RootFld.DataTypeId);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.DataTypeName, 100, convFieldTab4RootFld.DataTypeName);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.FldInfo, 100, convFieldTab4RootFld.FldInfo);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.MaxValue, 50, convFieldTab4RootFld.MaxValue);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.MinValue, 50, convFieldTab4RootFld.MinValue);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.DefaultValue, 50, convFieldTab4RootFld.DefaultValue);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.FldStateId, 2, convFieldTab4RootFld.FldStateId);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.TabId, 8, convFieldTab4RootFld.TabId);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.FldId, 8, convFieldTab4RootFld.FldId);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.Root4TabId, 8, convFieldTab4RootFld.Root4TabId);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.RootFldId, 8, convFieldTab4RootFld.RootFldId);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.RootTabId, 8, convFieldTab4RootFld.RootTabId);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.PrjId, 4, convFieldTab4RootFld.PrjId);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.UpdUser, 20, convFieldTab4RootFld.UpdUser);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.UpdDate, 20, convFieldTab4RootFld.UpdDate);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.Memo, 1000, convFieldTab4RootFld.Memo);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.RootFldName, 50, convFieldTab4RootFld.RootFldName);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.RootTabName, 100, convFieldTab4RootFld.RootTabName);
clsCheckSql.CheckFieldLen(objvFieldTab4RootFldEN.Root4TabName, 100, convFieldTab4RootFld.Root4TabName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.TabName, convFieldTab4RootFld.TabName);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.FldName, convFieldTab4RootFld.FldName);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.FldCnName, convFieldTab4RootFld.FldCnName);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.Caption, convFieldTab4RootFld.Caption);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.DataTypeId, convFieldTab4RootFld.DataTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.DataTypeName, convFieldTab4RootFld.DataTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.FldInfo, convFieldTab4RootFld.FldInfo);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.MaxValue, convFieldTab4RootFld.MaxValue);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.MinValue, convFieldTab4RootFld.MinValue);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.DefaultValue, convFieldTab4RootFld.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.FldStateId, convFieldTab4RootFld.FldStateId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.TabId, convFieldTab4RootFld.TabId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.FldId, convFieldTab4RootFld.FldId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.Root4TabId, convFieldTab4RootFld.Root4TabId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.RootFldId, convFieldTab4RootFld.RootFldId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.RootTabId, convFieldTab4RootFld.RootTabId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.PrjId, convFieldTab4RootFld.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.UpdUser, convFieldTab4RootFld.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.UpdDate, convFieldTab4RootFld.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.Memo, convFieldTab4RootFld.Memo);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.RootFldName, convFieldTab4RootFld.RootFldName);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.RootTabName, convFieldTab4RootFld.RootTabName);
clsCheckSql.CheckSqlInjection4Field(objvFieldTab4RootFldEN.Root4TabName, convFieldTab4RootFld.Root4TabName);
//检查外键字段长度
 objvFieldTab4RootFldEN._IsCheckProperty = true;
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
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
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
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
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
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFieldTab4RootFldEN._CurrTabName);
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
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFieldTab4RootFldEN._CurrTabName, strCondition);
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
 objSQL = clsvFieldTab4RootFldDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}