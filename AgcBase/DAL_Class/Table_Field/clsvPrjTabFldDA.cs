
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabFldDA
 表名:vPrjTabFld(00050122)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:54
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
 /// v工程表字段(vPrjTabFld)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPrjTabFldDA : clsCommBase4DA
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
 return clsvPrjTabFldEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPrjTabFldEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjTabFldEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPrjTabFldEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPrjTabFldEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPrjTabFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTabFld where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPrjTabFld(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPrjTabFldDA: GetDataTable_vPrjTabFld)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTabFld where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPrjTabFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPrjTabFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTabFld where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPrjTabFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPrjTabFldDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjTabFld where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjTabFld where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPrjTabFldDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPrjTabFld where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPrjTabFldDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjTabFld.* " + 
$"from vPrjTabFld " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjTabFld.mId not in " + 
$"(Select top {intTop_In} vPrjTabFld.mId from vPrjTabFld " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjTabFld where {1} and mId not in (Select top {2} mId from vPrjTabFld where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjTabFld where {1} and mId not in (Select top {3} mId from vPrjTabFld where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPrjTabFldDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjTabFld.* " + 
$"from vPrjTabFld " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjTabFld.mId not in " + 
$"(Select top {intTop_In} vPrjTabFld.mId from vPrjTabFld " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjTabFld where {1} and mId not in (Select top {2} mId from vPrjTabFld where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjTabFld where {1} and mId not in (Select top {3} mId from vPrjTabFld where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPrjTabFldEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPrjTabFldDA:GetObjLst)", objException.Message));
}
List<clsvPrjTabFldEN> arrObjLst = new List<clsvPrjTabFldEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTabFld where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabFldEN objvPrjTabFldEN = new clsvPrjTabFldEN();
try
{
objvPrjTabFldEN.mId = TransNullToInt(objRow[convPrjTabFld.mId].ToString().Trim()); //mId
objvPrjTabFldEN.TabId = objRow[convPrjTabFld.TabId].ToString().Trim(); //表ID
objvPrjTabFldEN.TabName = objRow[convPrjTabFld.TabName].ToString().Trim(); //表名
objvPrjTabFldEN.TabCnName = objRow[convPrjTabFld.TabCnName] == DBNull.Value ? null : objRow[convPrjTabFld.TabCnName].ToString().Trim(); //表中文名
objvPrjTabFldEN.PrjName = objRow[convPrjTabFld.PrjName] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName].ToString().Trim(); //工程名称
objvPrjTabFldEN.SqlDsTypeName = objRow[convPrjTabFld.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabFldEN.FuncModuleAgcId = objRow[convPrjTabFld.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabFldEN.FuncModuleName = objRow[convPrjTabFld.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabFldEN.OrderNum4Refer = objRow[convPrjTabFld.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTabFld.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabFldEN.FldId = objRow[convPrjTabFld.FldId].ToString().Trim(); //字段Id
objvPrjTabFldEN.OraDbType = objRow[convPrjTabFld.OraDbType] == DBNull.Value ? null : objRow[convPrjTabFld.OraDbType].ToString().Trim(); //Ora数据类型
objvPrjTabFldEN.IsNeedTransCode = TransNullToBool(objRow[convPrjTabFld.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabFldEN.FldName = objRow[convPrjTabFld.FldName].ToString().Trim(); //字段名
objvPrjTabFldEN.FldCnName = objRow[convPrjTabFld.FldCnName] == DBNull.Value ? null : objRow[convPrjTabFld.FldCnName].ToString().Trim(); //字段中文详名
objvPrjTabFldEN.Caption = objRow[convPrjTabFld.Caption].ToString().Trim(); //标题
objvPrjTabFldEN.DataTypeId = objRow[convPrjTabFld.DataTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.DataTypeId].ToString().Trim(); //数据类型Id
objvPrjTabFldEN.DataTypeName = objRow[convPrjTabFld.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjTabFldEN.FldLength = TransNullToInt(objRow[convPrjTabFld.FldLength].ToString().Trim()); //字段长度
objvPrjTabFldEN.FldPrecision = objRow[convPrjTabFld.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTabFld.FldPrecision].ToString().Trim()); //精确度
objvPrjTabFldEN.MaxValue = objRow[convPrjTabFld.MaxValue].ToString().Trim(); //最大值
objvPrjTabFldEN.MinValue = objRow[convPrjTabFld.MinValue].ToString().Trim(); //最小值
objvPrjTabFldEN.DefaultValue = objRow[convPrjTabFld.DefaultValue].ToString().Trim(); //缺省值
objvPrjTabFldEN.HomologousFldId = objRow[convPrjTabFld.HomologousFldId] == DBNull.Value ? null : objRow[convPrjTabFld.HomologousFldId].ToString().Trim(); //同源字段Id
objvPrjTabFldEN.PrjId = objRow[convPrjTabFld.PrjId].ToString().Trim(); //工程Id
objvPrjTabFldEN.FieldTypeId = objRow[convPrjTabFld.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFldEN.FieldTypeName = objRow[convPrjTabFld.FieldTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeName].ToString().Trim(); //字段类型名
objvPrjTabFldEN.IsTabNullable = TransNullToBool(objRow[convPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objvPrjTabFldEN.IsTabUnique = TransNullToBool(objRow[convPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objvPrjTabFldEN.IsTabForeignKey = TransNullToBool(objRow[convPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objvPrjTabFldEN.IsSortFld = TransNullToBool(objRow[convPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objvPrjTabFldEN.IsForExtendClass = TransNullToBool(objRow[convPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objvPrjTabFldEN.IsParentObj = TransNullToBool(objRow[convPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objvPrjTabFldEN.PrimaryTypeId = objRow[convPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabFldEN.PrimaryTypeName = objRow[convPrjTabFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabFldEN.ForeignKeyTabId = objRow[convPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objvPrjTabFldEN.FldOpTypeId = objRow[convPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objvPrjTabFldEN.FldOpTypeName = objRow[convPrjTabFld.FldOpTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objvPrjTabFldEN.SequenceNumber = TransNullToInt(objRow[convPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFldEN.MemoInTab = objRow[convPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[convPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objvPrjTabFldEN.PrjId4Fld = objRow[convPrjTabFld.PrjId4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjId4Fld].ToString().Trim(); //PrjId4Fld
objvPrjTabFldEN.PrjName4Fld = objRow[convPrjTabFld.PrjName4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName4Fld].ToString().Trim(); //PrjName4Fld
objvPrjTabFldEN.ForeignTabName = objRow[convPrjTabFld.ForeignTabName].ToString().Trim(); //外键表
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjTabFldDA: GetObjLst)", objException.Message));
}
objvPrjTabFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjTabFldEN);
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
public List<clsvPrjTabFldEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPrjTabFldDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPrjTabFldEN> arrObjLst = new List<clsvPrjTabFldEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabFldEN objvPrjTabFldEN = new clsvPrjTabFldEN();
try
{
objvPrjTabFldEN.mId = TransNullToInt(objRow[convPrjTabFld.mId].ToString().Trim()); //mId
objvPrjTabFldEN.TabId = objRow[convPrjTabFld.TabId].ToString().Trim(); //表ID
objvPrjTabFldEN.TabName = objRow[convPrjTabFld.TabName].ToString().Trim(); //表名
objvPrjTabFldEN.TabCnName = objRow[convPrjTabFld.TabCnName] == DBNull.Value ? null : objRow[convPrjTabFld.TabCnName].ToString().Trim(); //表中文名
objvPrjTabFldEN.PrjName = objRow[convPrjTabFld.PrjName] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName].ToString().Trim(); //工程名称
objvPrjTabFldEN.SqlDsTypeName = objRow[convPrjTabFld.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabFldEN.FuncModuleAgcId = objRow[convPrjTabFld.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabFldEN.FuncModuleName = objRow[convPrjTabFld.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabFldEN.OrderNum4Refer = objRow[convPrjTabFld.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTabFld.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabFldEN.FldId = objRow[convPrjTabFld.FldId].ToString().Trim(); //字段Id
objvPrjTabFldEN.OraDbType = objRow[convPrjTabFld.OraDbType] == DBNull.Value ? null : objRow[convPrjTabFld.OraDbType].ToString().Trim(); //Ora数据类型
objvPrjTabFldEN.IsNeedTransCode = TransNullToBool(objRow[convPrjTabFld.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabFldEN.FldName = objRow[convPrjTabFld.FldName].ToString().Trim(); //字段名
objvPrjTabFldEN.FldCnName = objRow[convPrjTabFld.FldCnName] == DBNull.Value ? null : objRow[convPrjTabFld.FldCnName].ToString().Trim(); //字段中文详名
objvPrjTabFldEN.Caption = objRow[convPrjTabFld.Caption].ToString().Trim(); //标题
objvPrjTabFldEN.DataTypeId = objRow[convPrjTabFld.DataTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.DataTypeId].ToString().Trim(); //数据类型Id
objvPrjTabFldEN.DataTypeName = objRow[convPrjTabFld.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjTabFldEN.FldLength = TransNullToInt(objRow[convPrjTabFld.FldLength].ToString().Trim()); //字段长度
objvPrjTabFldEN.FldPrecision = objRow[convPrjTabFld.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTabFld.FldPrecision].ToString().Trim()); //精确度
objvPrjTabFldEN.MaxValue = objRow[convPrjTabFld.MaxValue].ToString().Trim(); //最大值
objvPrjTabFldEN.MinValue = objRow[convPrjTabFld.MinValue].ToString().Trim(); //最小值
objvPrjTabFldEN.DefaultValue = objRow[convPrjTabFld.DefaultValue].ToString().Trim(); //缺省值
objvPrjTabFldEN.HomologousFldId = objRow[convPrjTabFld.HomologousFldId] == DBNull.Value ? null : objRow[convPrjTabFld.HomologousFldId].ToString().Trim(); //同源字段Id
objvPrjTabFldEN.PrjId = objRow[convPrjTabFld.PrjId].ToString().Trim(); //工程Id
objvPrjTabFldEN.FieldTypeId = objRow[convPrjTabFld.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFldEN.FieldTypeName = objRow[convPrjTabFld.FieldTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeName].ToString().Trim(); //字段类型名
objvPrjTabFldEN.IsTabNullable = TransNullToBool(objRow[convPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objvPrjTabFldEN.IsTabUnique = TransNullToBool(objRow[convPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objvPrjTabFldEN.IsTabForeignKey = TransNullToBool(objRow[convPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objvPrjTabFldEN.IsSortFld = TransNullToBool(objRow[convPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objvPrjTabFldEN.IsForExtendClass = TransNullToBool(objRow[convPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objvPrjTabFldEN.IsParentObj = TransNullToBool(objRow[convPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objvPrjTabFldEN.PrimaryTypeId = objRow[convPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabFldEN.PrimaryTypeName = objRow[convPrjTabFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabFldEN.ForeignKeyTabId = objRow[convPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objvPrjTabFldEN.FldOpTypeId = objRow[convPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objvPrjTabFldEN.FldOpTypeName = objRow[convPrjTabFld.FldOpTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objvPrjTabFldEN.SequenceNumber = TransNullToInt(objRow[convPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFldEN.MemoInTab = objRow[convPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[convPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objvPrjTabFldEN.PrjId4Fld = objRow[convPrjTabFld.PrjId4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjId4Fld].ToString().Trim(); //PrjId4Fld
objvPrjTabFldEN.PrjName4Fld = objRow[convPrjTabFld.PrjName4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName4Fld].ToString().Trim(); //PrjName4Fld
objvPrjTabFldEN.ForeignTabName = objRow[convPrjTabFld.ForeignTabName].ToString().Trim(); //外键表
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjTabFldDA: GetObjLst)", objException.Message));
}
objvPrjTabFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjTabFldEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPrjTabFldEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPrjTabFld(ref clsvPrjTabFldEN objvPrjTabFldEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTabFld where mId = " + ""+ objvPrjTabFldEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPrjTabFldEN.mId = TransNullToInt(objDT.Rows[0][convPrjTabFld.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvPrjTabFldEN.TabId = objDT.Rows[0][convPrjTabFld.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTabFldEN.TabName = objDT.Rows[0][convPrjTabFld.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjTabFldEN.TabCnName = objDT.Rows[0][convPrjTabFld.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPrjTabFldEN.PrjName = objDT.Rows[0][convPrjTabFld.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTabFldEN.SqlDsTypeName = objDT.Rows[0][convPrjTabFld.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvPrjTabFldEN.FuncModuleAgcId = objDT.Rows[0][convPrjTabFld.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTabFldEN.FuncModuleName = objDT.Rows[0][convPrjTabFld.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTabFldEN.OrderNum4Refer = TransNullToInt(objDT.Rows[0][convPrjTabFld.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTabFldEN.FldId = objDT.Rows[0][convPrjTabFld.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTabFldEN.OraDbType = objDT.Rows[0][convPrjTabFld.OraDbType].ToString().Trim(); //Ora数据类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjTabFldEN.IsNeedTransCode = TransNullToBool(objDT.Rows[0][convPrjTabFld.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objvPrjTabFldEN.FldName = objDT.Rows[0][convPrjTabFld.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjTabFldEN.FldCnName = objDT.Rows[0][convPrjTabFld.FldCnName].ToString().Trim(); //字段中文详名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPrjTabFldEN.Caption = objDT.Rows[0][convPrjTabFld.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objvPrjTabFldEN.DataTypeId = objDT.Rows[0][convPrjTabFld.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTabFldEN.DataTypeName = objDT.Rows[0][convPrjTabFld.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvPrjTabFldEN.FldLength = TransNullToInt(objDT.Rows[0][convPrjTabFld.FldLength].ToString().Trim()); //字段长度(字段类型:int,字段长度:4,是否可空:False)
 objvPrjTabFldEN.FldPrecision = TransNullToInt(objDT.Rows[0][convPrjTabFld.FldPrecision].ToString().Trim()); //精确度(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTabFldEN.MaxValue = objDT.Rows[0][convPrjTabFld.MaxValue].ToString().Trim(); //最大值(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTabFldEN.MinValue = objDT.Rows[0][convPrjTabFld.MinValue].ToString().Trim(); //最小值(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTabFldEN.DefaultValue = objDT.Rows[0][convPrjTabFld.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTabFldEN.HomologousFldId = objDT.Rows[0][convPrjTabFld.HomologousFldId].ToString().Trim(); //同源字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTabFldEN.PrjId = objDT.Rows[0][convPrjTabFld.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTabFldEN.FieldTypeId = objDT.Rows[0][convPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvPrjTabFldEN.FieldTypeName = objDT.Rows[0][convPrjTabFld.FieldTypeName].ToString().Trim(); //字段类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjTabFldEN.IsTabNullable = TransNullToBool(objDT.Rows[0][convPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabFldEN.IsTabUnique = TransNullToBool(objDT.Rows[0][convPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabFldEN.IsTabForeignKey = TransNullToBool(objDT.Rows[0][convPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabFldEN.IsSortFld = TransNullToBool(objDT.Rows[0][convPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabFldEN.IsForExtendClass = TransNullToBool(objDT.Rows[0][convPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabFldEN.IsParentObj = TransNullToBool(objDT.Rows[0][convPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabFldEN.PrimaryTypeId = objDT.Rows[0][convPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTabFldEN.PrimaryTypeName = objDT.Rows[0][convPrjTabFld.PrimaryTypeName].ToString().Trim(); //主键类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTabFldEN.ForeignKeyTabId = objDT.Rows[0][convPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID(字段类型:char,字段长度:8,是否可空:True)
 objvPrjTabFldEN.FldOpTypeId = objDT.Rows[0][convPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTabFldEN.FldOpTypeName = objDT.Rows[0][convPrjTabFld.FldOpTypeName].ToString().Trim(); //字段操作类型名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjTabFldEN.SequenceNumber = TransNullToInt(objDT.Rows[0][convPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTabFldEN.MemoInTab = objDT.Rows[0][convPrjTabFld.MemoInTab].ToString().Trim(); //表中说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPrjTabFldEN.PrjId4Fld = objDT.Rows[0][convPrjTabFld.PrjId4Fld].ToString().Trim(); //PrjId4Fld(字段类型:char,字段长度:4,是否可空:True)
 objvPrjTabFldEN.PrjName4Fld = objDT.Rows[0][convPrjTabFld.PrjName4Fld].ToString().Trim(); //PrjName4Fld(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjTabFldEN.ForeignTabName = objDT.Rows[0][convPrjTabFld.ForeignTabName].ToString().Trim(); //外键表(字段类型:varchar,字段长度:40,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPrjTabFldDA: GetvPrjTabFld)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPrjTabFldEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTabFld where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPrjTabFldEN objvPrjTabFldEN = new clsvPrjTabFldEN();
try
{
 objvPrjTabFldEN.mId = Int32.Parse(objRow[convPrjTabFld.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvPrjTabFldEN.TabId = objRow[convPrjTabFld.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTabFldEN.TabName = objRow[convPrjTabFld.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjTabFldEN.TabCnName = objRow[convPrjTabFld.TabCnName] == DBNull.Value ? null : objRow[convPrjTabFld.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPrjTabFldEN.PrjName = objRow[convPrjTabFld.PrjName] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTabFldEN.SqlDsTypeName = objRow[convPrjTabFld.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvPrjTabFldEN.FuncModuleAgcId = objRow[convPrjTabFld.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTabFldEN.FuncModuleName = objRow[convPrjTabFld.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTabFldEN.OrderNum4Refer = objRow[convPrjTabFld.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTabFldEN.FldId = objRow[convPrjTabFld.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTabFldEN.OraDbType = objRow[convPrjTabFld.OraDbType] == DBNull.Value ? null : objRow[convPrjTabFld.OraDbType].ToString().Trim(); //Ora数据类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjTabFldEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objvPrjTabFldEN.FldName = objRow[convPrjTabFld.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjTabFldEN.FldCnName = objRow[convPrjTabFld.FldCnName] == DBNull.Value ? null : objRow[convPrjTabFld.FldCnName].ToString().Trim(); //字段中文详名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPrjTabFldEN.Caption = objRow[convPrjTabFld.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objvPrjTabFldEN.DataTypeId = objRow[convPrjTabFld.DataTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.DataTypeId].ToString().Trim(); //数据类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTabFldEN.DataTypeName = objRow[convPrjTabFld.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvPrjTabFldEN.FldLength = Int32.Parse(objRow[convPrjTabFld.FldLength].ToString().Trim()); //字段长度(字段类型:int,字段长度:4,是否可空:False)
 objvPrjTabFldEN.FldPrecision = objRow[convPrjTabFld.FldPrecision] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld.FldPrecision].ToString().Trim()); //精确度(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTabFldEN.MaxValue = objRow[convPrjTabFld.MaxValue].ToString().Trim(); //最大值(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTabFldEN.MinValue = objRow[convPrjTabFld.MinValue].ToString().Trim(); //最小值(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTabFldEN.DefaultValue = objRow[convPrjTabFld.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTabFldEN.HomologousFldId = objRow[convPrjTabFld.HomologousFldId] == DBNull.Value ? null : objRow[convPrjTabFld.HomologousFldId].ToString().Trim(); //同源字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTabFldEN.PrjId = objRow[convPrjTabFld.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTabFldEN.FieldTypeId = objRow[convPrjTabFld.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvPrjTabFldEN.FieldTypeName = objRow[convPrjTabFld.FieldTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeName].ToString().Trim(); //字段类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjTabFldEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabFldEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabFldEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabFldEN.IsSortFld = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabFldEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabFldEN.IsParentObj = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabFldEN.PrimaryTypeId = objRow[convPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTabFldEN.PrimaryTypeName = objRow[convPrjTabFld.PrimaryTypeName].ToString().Trim(); //主键类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTabFldEN.ForeignKeyTabId = objRow[convPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID(字段类型:char,字段长度:8,是否可空:True)
 objvPrjTabFldEN.FldOpTypeId = objRow[convPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTabFldEN.FldOpTypeName = objRow[convPrjTabFld.FldOpTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FldOpTypeName].ToString().Trim(); //字段操作类型名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjTabFldEN.SequenceNumber = Int32.Parse(objRow[convPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTabFldEN.MemoInTab = objRow[convPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[convPrjTabFld.MemoInTab].ToString().Trim(); //表中说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPrjTabFldEN.PrjId4Fld = objRow[convPrjTabFld.PrjId4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjId4Fld].ToString().Trim(); //PrjId4Fld(字段类型:char,字段长度:4,是否可空:True)
 objvPrjTabFldEN.PrjName4Fld = objRow[convPrjTabFld.PrjName4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName4Fld].ToString().Trim(); //PrjName4Fld(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjTabFldEN.ForeignTabName = objRow[convPrjTabFld.ForeignTabName].ToString().Trim(); //外键表(字段类型:varchar,字段长度:40,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPrjTabFldDA: GetObjBymId)", objException.Message));
}
return objvPrjTabFldEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPrjTabFldEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPrjTabFldDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTabFld where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPrjTabFldEN objvPrjTabFldEN = new clsvPrjTabFldEN()
{
mId = TransNullToInt(objRow[convPrjTabFld.mId].ToString().Trim()), //mId
TabId = objRow[convPrjTabFld.TabId].ToString().Trim(), //表ID
TabName = objRow[convPrjTabFld.TabName].ToString().Trim(), //表名
TabCnName = objRow[convPrjTabFld.TabCnName] == DBNull.Value ? null : objRow[convPrjTabFld.TabCnName].ToString().Trim(), //表中文名
PrjName = objRow[convPrjTabFld.PrjName] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName].ToString().Trim(), //工程名称
SqlDsTypeName = objRow[convPrjTabFld.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.SqlDsTypeName].ToString().Trim(), //Sql数据源名
FuncModuleAgcId = objRow[convPrjTabFld.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convPrjTabFld.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleName].ToString().Trim(), //功能模块名称
OrderNum4Refer = objRow[convPrjTabFld.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTabFld.OrderNum4Refer].ToString().Trim()), //引用序号
FldId = objRow[convPrjTabFld.FldId].ToString().Trim(), //字段Id
OraDbType = objRow[convPrjTabFld.OraDbType] == DBNull.Value ? null : objRow[convPrjTabFld.OraDbType].ToString().Trim(), //Ora数据类型
IsNeedTransCode = TransNullToBool(objRow[convPrjTabFld.IsNeedTransCode].ToString().Trim()), //是否需要转换代码
FldName = objRow[convPrjTabFld.FldName].ToString().Trim(), //字段名
FldCnName = objRow[convPrjTabFld.FldCnName] == DBNull.Value ? null : objRow[convPrjTabFld.FldCnName].ToString().Trim(), //字段中文详名
Caption = objRow[convPrjTabFld.Caption].ToString().Trim(), //标题
DataTypeId = objRow[convPrjTabFld.DataTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.DataTypeId].ToString().Trim(), //数据类型Id
DataTypeName = objRow[convPrjTabFld.DataTypeName].ToString().Trim(), //数据类型名称
FldLength = TransNullToInt(objRow[convPrjTabFld.FldLength].ToString().Trim()), //字段长度
FldPrecision = objRow[convPrjTabFld.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTabFld.FldPrecision].ToString().Trim()), //精确度
MaxValue = objRow[convPrjTabFld.MaxValue].ToString().Trim(), //最大值
MinValue = objRow[convPrjTabFld.MinValue].ToString().Trim(), //最小值
DefaultValue = objRow[convPrjTabFld.DefaultValue].ToString().Trim(), //缺省值
HomologousFldId = objRow[convPrjTabFld.HomologousFldId] == DBNull.Value ? null : objRow[convPrjTabFld.HomologousFldId].ToString().Trim(), //同源字段Id
PrjId = objRow[convPrjTabFld.PrjId].ToString().Trim(), //工程Id
FieldTypeId = objRow[convPrjTabFld.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeId].ToString().Trim(), //字段类型Id
FieldTypeName = objRow[convPrjTabFld.FieldTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeName].ToString().Trim(), //字段类型名
IsTabNullable = TransNullToBool(objRow[convPrjTabFld.IsTabNullable].ToString().Trim()), //是否表中可空
IsTabUnique = TransNullToBool(objRow[convPrjTabFld.IsTabUnique].ToString().Trim()), //是否表中唯一
IsTabForeignKey = TransNullToBool(objRow[convPrjTabFld.IsTabForeignKey].ToString().Trim()), //是否表外键
IsSortFld = TransNullToBool(objRow[convPrjTabFld.IsSortFld].ToString().Trim()), //是否排序字段
IsForExtendClass = TransNullToBool(objRow[convPrjTabFld.IsForExtendClass].ToString().Trim()), //用于扩展类
IsParentObj = TransNullToBool(objRow[convPrjTabFld.IsParentObj].ToString().Trim()), //是否父对象
PrimaryTypeId = objRow[convPrjTabFld.PrimaryTypeId].ToString().Trim(), //主键类型ID
PrimaryTypeName = objRow[convPrjTabFld.PrimaryTypeName].ToString().Trim(), //主键类型名
ForeignKeyTabId = objRow[convPrjTabFld.ForeignKeyTabId].ToString().Trim(), //外键表ID
FldOpTypeId = objRow[convPrjTabFld.FldOpTypeId].ToString().Trim(), //字段操作类型Id
FldOpTypeName = objRow[convPrjTabFld.FldOpTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FldOpTypeName].ToString().Trim(), //字段操作类型名称
SequenceNumber = TransNullToInt(objRow[convPrjTabFld.SequenceNumber].ToString().Trim()), //顺序号
MemoInTab = objRow[convPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[convPrjTabFld.MemoInTab].ToString().Trim(), //表中说明
PrjId4Fld = objRow[convPrjTabFld.PrjId4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjId4Fld].ToString().Trim(), //PrjId4Fld
PrjName4Fld = objRow[convPrjTabFld.PrjName4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName4Fld].ToString().Trim(), //PrjName4Fld
ForeignTabName = objRow[convPrjTabFld.ForeignTabName].ToString().Trim() //外键表
};
objvPrjTabFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjTabFldEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPrjTabFldDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPrjTabFldEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjTabFldEN objvPrjTabFldEN = new clsvPrjTabFldEN();
try
{
objvPrjTabFldEN.mId = TransNullToInt(objRow[convPrjTabFld.mId].ToString().Trim()); //mId
objvPrjTabFldEN.TabId = objRow[convPrjTabFld.TabId].ToString().Trim(); //表ID
objvPrjTabFldEN.TabName = objRow[convPrjTabFld.TabName].ToString().Trim(); //表名
objvPrjTabFldEN.TabCnName = objRow[convPrjTabFld.TabCnName] == DBNull.Value ? null : objRow[convPrjTabFld.TabCnName].ToString().Trim(); //表中文名
objvPrjTabFldEN.PrjName = objRow[convPrjTabFld.PrjName] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName].ToString().Trim(); //工程名称
objvPrjTabFldEN.SqlDsTypeName = objRow[convPrjTabFld.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabFldEN.FuncModuleAgcId = objRow[convPrjTabFld.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabFldEN.FuncModuleName = objRow[convPrjTabFld.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabFldEN.OrderNum4Refer = objRow[convPrjTabFld.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTabFld.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabFldEN.FldId = objRow[convPrjTabFld.FldId].ToString().Trim(); //字段Id
objvPrjTabFldEN.OraDbType = objRow[convPrjTabFld.OraDbType] == DBNull.Value ? null : objRow[convPrjTabFld.OraDbType].ToString().Trim(); //Ora数据类型
objvPrjTabFldEN.IsNeedTransCode = TransNullToBool(objRow[convPrjTabFld.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabFldEN.FldName = objRow[convPrjTabFld.FldName].ToString().Trim(); //字段名
objvPrjTabFldEN.FldCnName = objRow[convPrjTabFld.FldCnName] == DBNull.Value ? null : objRow[convPrjTabFld.FldCnName].ToString().Trim(); //字段中文详名
objvPrjTabFldEN.Caption = objRow[convPrjTabFld.Caption].ToString().Trim(); //标题
objvPrjTabFldEN.DataTypeId = objRow[convPrjTabFld.DataTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.DataTypeId].ToString().Trim(); //数据类型Id
objvPrjTabFldEN.DataTypeName = objRow[convPrjTabFld.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjTabFldEN.FldLength = TransNullToInt(objRow[convPrjTabFld.FldLength].ToString().Trim()); //字段长度
objvPrjTabFldEN.FldPrecision = objRow[convPrjTabFld.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTabFld.FldPrecision].ToString().Trim()); //精确度
objvPrjTabFldEN.MaxValue = objRow[convPrjTabFld.MaxValue].ToString().Trim(); //最大值
objvPrjTabFldEN.MinValue = objRow[convPrjTabFld.MinValue].ToString().Trim(); //最小值
objvPrjTabFldEN.DefaultValue = objRow[convPrjTabFld.DefaultValue].ToString().Trim(); //缺省值
objvPrjTabFldEN.HomologousFldId = objRow[convPrjTabFld.HomologousFldId] == DBNull.Value ? null : objRow[convPrjTabFld.HomologousFldId].ToString().Trim(); //同源字段Id
objvPrjTabFldEN.PrjId = objRow[convPrjTabFld.PrjId].ToString().Trim(); //工程Id
objvPrjTabFldEN.FieldTypeId = objRow[convPrjTabFld.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFldEN.FieldTypeName = objRow[convPrjTabFld.FieldTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeName].ToString().Trim(); //字段类型名
objvPrjTabFldEN.IsTabNullable = TransNullToBool(objRow[convPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objvPrjTabFldEN.IsTabUnique = TransNullToBool(objRow[convPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objvPrjTabFldEN.IsTabForeignKey = TransNullToBool(objRow[convPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objvPrjTabFldEN.IsSortFld = TransNullToBool(objRow[convPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objvPrjTabFldEN.IsForExtendClass = TransNullToBool(objRow[convPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objvPrjTabFldEN.IsParentObj = TransNullToBool(objRow[convPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objvPrjTabFldEN.PrimaryTypeId = objRow[convPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabFldEN.PrimaryTypeName = objRow[convPrjTabFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabFldEN.ForeignKeyTabId = objRow[convPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objvPrjTabFldEN.FldOpTypeId = objRow[convPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objvPrjTabFldEN.FldOpTypeName = objRow[convPrjTabFld.FldOpTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objvPrjTabFldEN.SequenceNumber = TransNullToInt(objRow[convPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFldEN.MemoInTab = objRow[convPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[convPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objvPrjTabFldEN.PrjId4Fld = objRow[convPrjTabFld.PrjId4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjId4Fld].ToString().Trim(); //PrjId4Fld
objvPrjTabFldEN.PrjName4Fld = objRow[convPrjTabFld.PrjName4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName4Fld].ToString().Trim(); //PrjName4Fld
objvPrjTabFldEN.ForeignTabName = objRow[convPrjTabFld.ForeignTabName].ToString().Trim(); //外键表
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPrjTabFldDA: GetObjByDataRowvPrjTabFld)", objException.Message));
}
objvPrjTabFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjTabFldEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPrjTabFldEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjTabFldEN objvPrjTabFldEN = new clsvPrjTabFldEN();
try
{
objvPrjTabFldEN.mId = TransNullToInt(objRow[convPrjTabFld.mId].ToString().Trim()); //mId
objvPrjTabFldEN.TabId = objRow[convPrjTabFld.TabId].ToString().Trim(); //表ID
objvPrjTabFldEN.TabName = objRow[convPrjTabFld.TabName].ToString().Trim(); //表名
objvPrjTabFldEN.TabCnName = objRow[convPrjTabFld.TabCnName] == DBNull.Value ? null : objRow[convPrjTabFld.TabCnName].ToString().Trim(); //表中文名
objvPrjTabFldEN.PrjName = objRow[convPrjTabFld.PrjName] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName].ToString().Trim(); //工程名称
objvPrjTabFldEN.SqlDsTypeName = objRow[convPrjTabFld.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabFldEN.FuncModuleAgcId = objRow[convPrjTabFld.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabFldEN.FuncModuleName = objRow[convPrjTabFld.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTabFld.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabFldEN.OrderNum4Refer = objRow[convPrjTabFld.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTabFld.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabFldEN.FldId = objRow[convPrjTabFld.FldId].ToString().Trim(); //字段Id
objvPrjTabFldEN.OraDbType = objRow[convPrjTabFld.OraDbType] == DBNull.Value ? null : objRow[convPrjTabFld.OraDbType].ToString().Trim(); //Ora数据类型
objvPrjTabFldEN.IsNeedTransCode = TransNullToBool(objRow[convPrjTabFld.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabFldEN.FldName = objRow[convPrjTabFld.FldName].ToString().Trim(); //字段名
objvPrjTabFldEN.FldCnName = objRow[convPrjTabFld.FldCnName] == DBNull.Value ? null : objRow[convPrjTabFld.FldCnName].ToString().Trim(); //字段中文详名
objvPrjTabFldEN.Caption = objRow[convPrjTabFld.Caption].ToString().Trim(); //标题
objvPrjTabFldEN.DataTypeId = objRow[convPrjTabFld.DataTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.DataTypeId].ToString().Trim(); //数据类型Id
objvPrjTabFldEN.DataTypeName = objRow[convPrjTabFld.DataTypeName].ToString().Trim(); //数据类型名称
objvPrjTabFldEN.FldLength = TransNullToInt(objRow[convPrjTabFld.FldLength].ToString().Trim()); //字段长度
objvPrjTabFldEN.FldPrecision = objRow[convPrjTabFld.FldPrecision] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTabFld.FldPrecision].ToString().Trim()); //精确度
objvPrjTabFldEN.MaxValue = objRow[convPrjTabFld.MaxValue].ToString().Trim(); //最大值
objvPrjTabFldEN.MinValue = objRow[convPrjTabFld.MinValue].ToString().Trim(); //最小值
objvPrjTabFldEN.DefaultValue = objRow[convPrjTabFld.DefaultValue].ToString().Trim(); //缺省值
objvPrjTabFldEN.HomologousFldId = objRow[convPrjTabFld.HomologousFldId] == DBNull.Value ? null : objRow[convPrjTabFld.HomologousFldId].ToString().Trim(); //同源字段Id
objvPrjTabFldEN.PrjId = objRow[convPrjTabFld.PrjId].ToString().Trim(); //工程Id
objvPrjTabFldEN.FieldTypeId = objRow[convPrjTabFld.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFldEN.FieldTypeName = objRow[convPrjTabFld.FieldTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FieldTypeName].ToString().Trim(); //字段类型名
objvPrjTabFldEN.IsTabNullable = TransNullToBool(objRow[convPrjTabFld.IsTabNullable].ToString().Trim()); //是否表中可空
objvPrjTabFldEN.IsTabUnique = TransNullToBool(objRow[convPrjTabFld.IsTabUnique].ToString().Trim()); //是否表中唯一
objvPrjTabFldEN.IsTabForeignKey = TransNullToBool(objRow[convPrjTabFld.IsTabForeignKey].ToString().Trim()); //是否表外键
objvPrjTabFldEN.IsSortFld = TransNullToBool(objRow[convPrjTabFld.IsSortFld].ToString().Trim()); //是否排序字段
objvPrjTabFldEN.IsForExtendClass = TransNullToBool(objRow[convPrjTabFld.IsForExtendClass].ToString().Trim()); //用于扩展类
objvPrjTabFldEN.IsParentObj = TransNullToBool(objRow[convPrjTabFld.IsParentObj].ToString().Trim()); //是否父对象
objvPrjTabFldEN.PrimaryTypeId = objRow[convPrjTabFld.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabFldEN.PrimaryTypeName = objRow[convPrjTabFld.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabFldEN.ForeignKeyTabId = objRow[convPrjTabFld.ForeignKeyTabId].ToString().Trim(); //外键表ID
objvPrjTabFldEN.FldOpTypeId = objRow[convPrjTabFld.FldOpTypeId].ToString().Trim(); //字段操作类型Id
objvPrjTabFldEN.FldOpTypeName = objRow[convPrjTabFld.FldOpTypeName] == DBNull.Value ? null : objRow[convPrjTabFld.FldOpTypeName].ToString().Trim(); //字段操作类型名称
objvPrjTabFldEN.SequenceNumber = TransNullToInt(objRow[convPrjTabFld.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFldEN.MemoInTab = objRow[convPrjTabFld.MemoInTab] == DBNull.Value ? null : objRow[convPrjTabFld.MemoInTab].ToString().Trim(); //表中说明
objvPrjTabFldEN.PrjId4Fld = objRow[convPrjTabFld.PrjId4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjId4Fld].ToString().Trim(); //PrjId4Fld
objvPrjTabFldEN.PrjName4Fld = objRow[convPrjTabFld.PrjName4Fld] == DBNull.Value ? null : objRow[convPrjTabFld.PrjName4Fld].ToString().Trim(); //PrjName4Fld
objvPrjTabFldEN.ForeignTabName = objRow[convPrjTabFld.ForeignTabName].ToString().Trim(); //外键表
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPrjTabFldDA: GetObjByDataRow)", objException.Message));
}
objvPrjTabFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjTabFldEN;
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
objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjTabFldEN._CurrTabName, convPrjTabFld.mId, 8, "");
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
objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjTabFldEN._CurrTabName, convPrjTabFld.mId, 8, strPrefix);
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
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vPrjTabFld where " + strCondition;
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
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vPrjTabFld where " + strCondition;
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
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjTabFld", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPrjTabFldDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjTabFld", strCondition))
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
objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPrjTabFld");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPrjTabFldENS">源对象</param>
 /// <param name = "objvPrjTabFldENT">目标对象</param>
public void CopyTo(clsvPrjTabFldEN objvPrjTabFldENS, clsvPrjTabFldEN objvPrjTabFldENT)
{
objvPrjTabFldENT.mId = objvPrjTabFldENS.mId; //mId
objvPrjTabFldENT.TabId = objvPrjTabFldENS.TabId; //表ID
objvPrjTabFldENT.TabName = objvPrjTabFldENS.TabName; //表名
objvPrjTabFldENT.TabCnName = objvPrjTabFldENS.TabCnName; //表中文名
objvPrjTabFldENT.PrjName = objvPrjTabFldENS.PrjName; //工程名称
objvPrjTabFldENT.SqlDsTypeName = objvPrjTabFldENS.SqlDsTypeName; //Sql数据源名
objvPrjTabFldENT.FuncModuleAgcId = objvPrjTabFldENS.FuncModuleAgcId; //功能模块Id
objvPrjTabFldENT.FuncModuleName = objvPrjTabFldENS.FuncModuleName; //功能模块名称
objvPrjTabFldENT.OrderNum4Refer = objvPrjTabFldENS.OrderNum4Refer; //引用序号
objvPrjTabFldENT.FldId = objvPrjTabFldENS.FldId; //字段Id
objvPrjTabFldENT.OraDbType = objvPrjTabFldENS.OraDbType; //Ora数据类型
objvPrjTabFldENT.IsNeedTransCode = objvPrjTabFldENS.IsNeedTransCode; //是否需要转换代码
objvPrjTabFldENT.FldName = objvPrjTabFldENS.FldName; //字段名
objvPrjTabFldENT.FldCnName = objvPrjTabFldENS.FldCnName; //字段中文详名
objvPrjTabFldENT.Caption = objvPrjTabFldENS.Caption; //标题
objvPrjTabFldENT.DataTypeId = objvPrjTabFldENS.DataTypeId; //数据类型Id
objvPrjTabFldENT.DataTypeName = objvPrjTabFldENS.DataTypeName; //数据类型名称
objvPrjTabFldENT.FldLength = objvPrjTabFldENS.FldLength; //字段长度
objvPrjTabFldENT.FldPrecision = objvPrjTabFldENS.FldPrecision; //精确度
objvPrjTabFldENT.MaxValue = objvPrjTabFldENS.MaxValue; //最大值
objvPrjTabFldENT.MinValue = objvPrjTabFldENS.MinValue; //最小值
objvPrjTabFldENT.DefaultValue = objvPrjTabFldENS.DefaultValue; //缺省值
objvPrjTabFldENT.HomologousFldId = objvPrjTabFldENS.HomologousFldId; //同源字段Id
objvPrjTabFldENT.PrjId = objvPrjTabFldENS.PrjId; //工程Id
objvPrjTabFldENT.FieldTypeId = objvPrjTabFldENS.FieldTypeId; //字段类型Id
objvPrjTabFldENT.FieldTypeName = objvPrjTabFldENS.FieldTypeName; //字段类型名
objvPrjTabFldENT.IsTabNullable = objvPrjTabFldENS.IsTabNullable; //是否表中可空
objvPrjTabFldENT.IsTabUnique = objvPrjTabFldENS.IsTabUnique; //是否表中唯一
objvPrjTabFldENT.IsTabForeignKey = objvPrjTabFldENS.IsTabForeignKey; //是否表外键
objvPrjTabFldENT.IsSortFld = objvPrjTabFldENS.IsSortFld; //是否排序字段
objvPrjTabFldENT.IsForExtendClass = objvPrjTabFldENS.IsForExtendClass; //用于扩展类
objvPrjTabFldENT.IsParentObj = objvPrjTabFldENS.IsParentObj; //是否父对象
objvPrjTabFldENT.PrimaryTypeId = objvPrjTabFldENS.PrimaryTypeId; //主键类型ID
objvPrjTabFldENT.PrimaryTypeName = objvPrjTabFldENS.PrimaryTypeName; //主键类型名
objvPrjTabFldENT.ForeignKeyTabId = objvPrjTabFldENS.ForeignKeyTabId; //外键表ID
objvPrjTabFldENT.FldOpTypeId = objvPrjTabFldENS.FldOpTypeId; //字段操作类型Id
objvPrjTabFldENT.FldOpTypeName = objvPrjTabFldENS.FldOpTypeName; //字段操作类型名称
objvPrjTabFldENT.SequenceNumber = objvPrjTabFldENS.SequenceNumber; //顺序号
objvPrjTabFldENT.MemoInTab = objvPrjTabFldENS.MemoInTab; //表中说明
objvPrjTabFldENT.PrjId4Fld = objvPrjTabFldENS.PrjId4Fld; //PrjId4Fld
objvPrjTabFldENT.PrjName4Fld = objvPrjTabFldENS.PrjName4Fld; //PrjName4Fld
objvPrjTabFldENT.ForeignTabName = objvPrjTabFldENS.ForeignTabName; //外键表
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPrjTabFldEN objvPrjTabFldEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.TabId, 8, convPrjTabFld.TabId);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.TabName, 100, convPrjTabFld.TabName);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.TabCnName, 200, convPrjTabFld.TabCnName);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.PrjName, 30, convPrjTabFld.PrjName);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.SqlDsTypeName, 20, convPrjTabFld.SqlDsTypeName);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.FuncModuleAgcId, 8, convPrjTabFld.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.FuncModuleName, 30, convPrjTabFld.FuncModuleName);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.FldId, 8, convPrjTabFld.FldId);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.OraDbType, 100, convPrjTabFld.OraDbType);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.FldName, 50, convPrjTabFld.FldName);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.FldCnName, 200, convPrjTabFld.FldCnName);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.Caption, 200, convPrjTabFld.Caption);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.DataTypeId, 2, convPrjTabFld.DataTypeId);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.DataTypeName, 100, convPrjTabFld.DataTypeName);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.MaxValue, 50, convPrjTabFld.MaxValue);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.MinValue, 50, convPrjTabFld.MinValue);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.DefaultValue, 50, convPrjTabFld.DefaultValue);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.HomologousFldId, 8, convPrjTabFld.HomologousFldId);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.PrjId, 4, convPrjTabFld.PrjId);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.FieldTypeId, 2, convPrjTabFld.FieldTypeId);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.FieldTypeName, 30, convPrjTabFld.FieldTypeName);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.PrimaryTypeId, 2, convPrjTabFld.PrimaryTypeId);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.PrimaryTypeName, 30, convPrjTabFld.PrimaryTypeName);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.ForeignKeyTabId, 8, convPrjTabFld.ForeignKeyTabId);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.FldOpTypeId, 4, convPrjTabFld.FldOpTypeId);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.FldOpTypeName, 100, convPrjTabFld.FldOpTypeName);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.MemoInTab, 1000, convPrjTabFld.MemoInTab);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.PrjId4Fld, 4, convPrjTabFld.PrjId4Fld);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.PrjName4Fld, 30, convPrjTabFld.PrjName4Fld);
clsCheckSql.CheckFieldLen(objvPrjTabFldEN.ForeignTabName, 40, convPrjTabFld.ForeignTabName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.TabId, convPrjTabFld.TabId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.TabName, convPrjTabFld.TabName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.TabCnName, convPrjTabFld.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.PrjName, convPrjTabFld.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.SqlDsTypeName, convPrjTabFld.SqlDsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.FuncModuleAgcId, convPrjTabFld.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.FuncModuleName, convPrjTabFld.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.FldId, convPrjTabFld.FldId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.OraDbType, convPrjTabFld.OraDbType);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.FldName, convPrjTabFld.FldName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.FldCnName, convPrjTabFld.FldCnName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.Caption, convPrjTabFld.Caption);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.DataTypeId, convPrjTabFld.DataTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.DataTypeName, convPrjTabFld.DataTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.MaxValue, convPrjTabFld.MaxValue);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.MinValue, convPrjTabFld.MinValue);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.DefaultValue, convPrjTabFld.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.HomologousFldId, convPrjTabFld.HomologousFldId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.PrjId, convPrjTabFld.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.FieldTypeId, convPrjTabFld.FieldTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.FieldTypeName, convPrjTabFld.FieldTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.PrimaryTypeId, convPrjTabFld.PrimaryTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.PrimaryTypeName, convPrjTabFld.PrimaryTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.ForeignKeyTabId, convPrjTabFld.ForeignKeyTabId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.FldOpTypeId, convPrjTabFld.FldOpTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.FldOpTypeName, convPrjTabFld.FldOpTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.MemoInTab, convPrjTabFld.MemoInTab);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.PrjId4Fld, convPrjTabFld.PrjId4Fld);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.PrjName4Fld, convPrjTabFld.PrjName4Fld);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabFldEN.ForeignTabName, convPrjTabFld.ForeignTabName);
//检查外键字段长度
 objvPrjTabFldEN._IsCheckProperty = true;
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
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
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
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
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
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjTabFldEN._CurrTabName);
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
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjTabFldEN._CurrTabName, strCondition);
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
 objSQL = clsvPrjTabFldDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}