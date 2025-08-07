
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabFieldRelaDA
 表名:vTabFieldRela(00050267)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:33:39
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据同步(DataSynch)
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
 /// v表字段关系(vTabFieldRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTabFieldRelaDA : clsCommBase4DA
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
 return clsvTabFieldRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTabFieldRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTabFieldRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTabFieldRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTabFieldRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTabFieldRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
strSQL = "Select * from vTabFieldRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTabFieldRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTabFieldRelaDA: GetDataTable_vTabFieldRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
strSQL = "Select * from vTabFieldRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTabFieldRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTabFieldRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
strSQL = "Select * from vTabFieldRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTabFieldRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTabFieldRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTabFieldRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTabFieldRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTabFieldRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTabFieldRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTabFieldRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vTabFieldRela.* " + 
$"from vTabFieldRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vTabFieldRela.IdFieldTabRela not in " + 
$"(Select top {intTop_In} vTabFieldRela.IdFieldTabRela from vTabFieldRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTabFieldRela where {1} and IdFieldTabRela not in (Select top {2} IdFieldTabRela from vTabFieldRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTabFieldRela where {1} and IdFieldTabRela not in (Select top {3} IdFieldTabRela from vTabFieldRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTabFieldRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vTabFieldRela.* " + 
$"from vTabFieldRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vTabFieldRela.IdFieldTabRela not in " + 
$"(Select top {intTop_In} vTabFieldRela.IdFieldTabRela from vTabFieldRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTabFieldRela where {1} and IdFieldTabRela not in (Select top {2} IdFieldTabRela from vTabFieldRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTabFieldRela where {1} and IdFieldTabRela not in (Select top {3} IdFieldTabRela from vTabFieldRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTabFieldRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTabFieldRelaDA:GetObjLst)", objException.Message));
}
List<clsvTabFieldRelaEN> arrObjLst = new List<clsvTabFieldRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
strSQL = "Select * from vTabFieldRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFieldRelaEN objvTabFieldRelaEN = new clsvTabFieldRelaEN();
try
{
objvTabFieldRelaEN.IdFieldTabRela = TransNullToInt(objRow[convTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objvTabFieldRelaEN.TabId = objRow[convTabFieldRela.TabId].ToString().Trim(); //表ID
objvTabFieldRelaEN.FldId = objRow[convTabFieldRela.FldId].ToString().Trim(); //字段Id
objvTabFieldRelaEN.FldName = objRow[convTabFieldRela.FldName] == DBNull.Value ? null : objRow[convTabFieldRela.FldName].ToString().Trim(); //字段名
objvTabFieldRelaEN.Caption = objRow[convTabFieldRela.Caption] == DBNull.Value ? null : objRow[convTabFieldRela.Caption].ToString().Trim(); //标题
objvTabFieldRelaEN.SqlFldName = objRow[convTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[convTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objvTabFieldRelaEN.ExcelFieldName = objRow[convTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objvTabFieldRelaEN.IsNeedTrans = TransNullToBool(objRow[convTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objvTabFieldRelaEN.TransOutFldName = objRow[convTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objvTabFieldRelaEN.TransInFldName = objRow[convTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objvTabFieldRelaEN.PrimaryTypeId = objRow[convTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvTabFieldRelaEN.PrimaryTypeName = objRow[convTabFieldRela.PrimaryTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeName].ToString().Trim(); //主键类型名
objvTabFieldRelaEN.TransTabName = objRow[convTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[convTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objvTabFieldRelaEN.IsIdentity = TransNullToBool(objRow[convTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objvTabFieldRelaEN.IsVisible = TransNullToBool(objRow[convTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objvTabFieldRelaEN.IsTabPrimary = TransNullToBool(objRow[convTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objvTabFieldRelaEN.IsTabNullable = TransNullToBool(objRow[convTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objvTabFieldRelaEN.IsTabUnique = TransNullToBool(objRow[convTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objvTabFieldRelaEN.DataTypeName = objRow[convTabFieldRela.DataTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFieldRelaEN.SequenceNumber = objRow[convTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objvTabFieldRelaEN.IsNeedCheckPriForeignKey = TransNullToBool(objRow[convTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objvTabFieldRelaEN.IsTabForeignKey = TransNullToBool(objRow[convTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objvTabFieldRelaEN.PrimaryKeyFieldName = objRow[convTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objvTabFieldRelaEN.PrimaryKeyTabName = objRow[convTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objvTabFieldRelaEN.DefaultValue = objRow[convTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[convTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objvTabFieldRelaEN.TransWayId = objRow[convTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objvTabFieldRelaEN.TransWayName = objRow[convTabFieldRela.TransWayName] == DBNull.Value ? null : objRow[convTabFieldRela.TransWayName].ToString().Trim(); //转换方式名称
objvTabFieldRelaEN.FldLength = objRow[convTabFieldRela.FldLength] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFieldRela.FldLength].ToString().Trim()); //字段长度
objvTabFieldRelaEN.TransMissingValue = objRow[convTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objvTabFieldRelaEN.TransNullValue = objRow[convTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objvTabFieldRelaEN.PrjName = objRow[convTabFieldRela.PrjName] == DBNull.Value ? null : objRow[convTabFieldRela.PrjName].ToString().Trim(); //工程名称
objvTabFieldRelaEN.PrjId = objRow[convTabFieldRela.PrjId].ToString().Trim(); //工程Id
objvTabFieldRelaEN.PrefixFldName = objRow[convTabFieldRela.PrefixFldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrefixFldName].ToString().Trim(); //前缀字段名
objvTabFieldRelaEN.Keyword = objRow[convTabFieldRela.Keyword] == DBNull.Value ? null : objRow[convTabFieldRela.Keyword].ToString().Trim(); //关键字
objvTabFieldRelaEN.TabCnName = objRow[convTabFieldRela.TabCnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabCnName].ToString().Trim(); //表中文名
objvTabFieldRelaEN.TabEnName = objRow[convTabFieldRela.TabEnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabEnName].ToString().Trim(); //表英文详细名
objvTabFieldRelaEN.Memo = objRow[convTabFieldRela.Memo] == DBNull.Value ? null : objRow[convTabFieldRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTabFieldRelaDA: GetObjLst)", objException.Message));
}
objvTabFieldRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTabFieldRelaEN);
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
public List<clsvTabFieldRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTabFieldRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTabFieldRelaEN> arrObjLst = new List<clsvTabFieldRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabFieldRelaEN objvTabFieldRelaEN = new clsvTabFieldRelaEN();
try
{
objvTabFieldRelaEN.IdFieldTabRela = TransNullToInt(objRow[convTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objvTabFieldRelaEN.TabId = objRow[convTabFieldRela.TabId].ToString().Trim(); //表ID
objvTabFieldRelaEN.FldId = objRow[convTabFieldRela.FldId].ToString().Trim(); //字段Id
objvTabFieldRelaEN.FldName = objRow[convTabFieldRela.FldName] == DBNull.Value ? null : objRow[convTabFieldRela.FldName].ToString().Trim(); //字段名
objvTabFieldRelaEN.Caption = objRow[convTabFieldRela.Caption] == DBNull.Value ? null : objRow[convTabFieldRela.Caption].ToString().Trim(); //标题
objvTabFieldRelaEN.SqlFldName = objRow[convTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[convTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objvTabFieldRelaEN.ExcelFieldName = objRow[convTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objvTabFieldRelaEN.IsNeedTrans = TransNullToBool(objRow[convTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objvTabFieldRelaEN.TransOutFldName = objRow[convTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objvTabFieldRelaEN.TransInFldName = objRow[convTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objvTabFieldRelaEN.PrimaryTypeId = objRow[convTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvTabFieldRelaEN.PrimaryTypeName = objRow[convTabFieldRela.PrimaryTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeName].ToString().Trim(); //主键类型名
objvTabFieldRelaEN.TransTabName = objRow[convTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[convTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objvTabFieldRelaEN.IsIdentity = TransNullToBool(objRow[convTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objvTabFieldRelaEN.IsVisible = TransNullToBool(objRow[convTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objvTabFieldRelaEN.IsTabPrimary = TransNullToBool(objRow[convTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objvTabFieldRelaEN.IsTabNullable = TransNullToBool(objRow[convTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objvTabFieldRelaEN.IsTabUnique = TransNullToBool(objRow[convTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objvTabFieldRelaEN.DataTypeName = objRow[convTabFieldRela.DataTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFieldRelaEN.SequenceNumber = objRow[convTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objvTabFieldRelaEN.IsNeedCheckPriForeignKey = TransNullToBool(objRow[convTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objvTabFieldRelaEN.IsTabForeignKey = TransNullToBool(objRow[convTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objvTabFieldRelaEN.PrimaryKeyFieldName = objRow[convTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objvTabFieldRelaEN.PrimaryKeyTabName = objRow[convTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objvTabFieldRelaEN.DefaultValue = objRow[convTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[convTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objvTabFieldRelaEN.TransWayId = objRow[convTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objvTabFieldRelaEN.TransWayName = objRow[convTabFieldRela.TransWayName] == DBNull.Value ? null : objRow[convTabFieldRela.TransWayName].ToString().Trim(); //转换方式名称
objvTabFieldRelaEN.FldLength = objRow[convTabFieldRela.FldLength] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFieldRela.FldLength].ToString().Trim()); //字段长度
objvTabFieldRelaEN.TransMissingValue = objRow[convTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objvTabFieldRelaEN.TransNullValue = objRow[convTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objvTabFieldRelaEN.PrjName = objRow[convTabFieldRela.PrjName] == DBNull.Value ? null : objRow[convTabFieldRela.PrjName].ToString().Trim(); //工程名称
objvTabFieldRelaEN.PrjId = objRow[convTabFieldRela.PrjId].ToString().Trim(); //工程Id
objvTabFieldRelaEN.PrefixFldName = objRow[convTabFieldRela.PrefixFldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrefixFldName].ToString().Trim(); //前缀字段名
objvTabFieldRelaEN.Keyword = objRow[convTabFieldRela.Keyword] == DBNull.Value ? null : objRow[convTabFieldRela.Keyword].ToString().Trim(); //关键字
objvTabFieldRelaEN.TabCnName = objRow[convTabFieldRela.TabCnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabCnName].ToString().Trim(); //表中文名
objvTabFieldRelaEN.TabEnName = objRow[convTabFieldRela.TabEnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabEnName].ToString().Trim(); //表英文详细名
objvTabFieldRelaEN.Memo = objRow[convTabFieldRela.Memo] == DBNull.Value ? null : objRow[convTabFieldRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTabFieldRelaDA: GetObjLst)", objException.Message));
}
objvTabFieldRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTabFieldRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTabFieldRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTabFieldRela(ref clsvTabFieldRelaEN objvTabFieldRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
strSQL = "Select * from vTabFieldRela where IdFieldTabRela = " + ""+ objvTabFieldRelaEN.IdFieldTabRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTabFieldRelaEN.IdFieldTabRela = TransNullToInt(objDT.Rows[0][convTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvTabFieldRelaEN.TabId = objDT.Rows[0][convTabFieldRela.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvTabFieldRelaEN.FldId = objDT.Rows[0][convTabFieldRela.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvTabFieldRelaEN.FldName = objDT.Rows[0][convTabFieldRela.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvTabFieldRelaEN.Caption = objDT.Rows[0][convTabFieldRela.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objvTabFieldRelaEN.SqlFldName = objDT.Rows[0][convTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvTabFieldRelaEN.ExcelFieldName = objDT.Rows[0][convTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFieldRelaEN.IsNeedTrans = TransNullToBool(objDT.Rows[0][convTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换(字段类型:bit,字段长度:1,是否可空:False)
 objvTabFieldRelaEN.TransOutFldName = objDT.Rows[0][convTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFieldRelaEN.TransInFldName = objDT.Rows[0][convTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFieldRelaEN.PrimaryTypeId = objDT.Rows[0][convTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvTabFieldRelaEN.PrimaryTypeName = objDT.Rows[0][convTabFieldRela.PrimaryTypeName].ToString().Trim(); //主键类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabFieldRelaEN.TransTabName = objDT.Rows[0][convTabFieldRela.TransTabName].ToString().Trim(); //转换表名(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFieldRelaEN.IsIdentity = TransNullToBool(objDT.Rows[0][convTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFieldRelaEN.IsVisible = TransNullToBool(objDT.Rows[0][convTabFieldRela.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFieldRelaEN.IsTabPrimary = TransNullToBool(objDT.Rows[0][convTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键(字段类型:bit,字段长度:1,是否可空:False)
 objvTabFieldRelaEN.IsTabNullable = TransNullToBool(objDT.Rows[0][convTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFieldRelaEN.IsTabUnique = TransNullToBool(objDT.Rows[0][convTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFieldRelaEN.DataTypeName = objDT.Rows[0][convTabFieldRela.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvTabFieldRelaEN.SequenceNumber = TransNullToInt(objDT.Rows[0][convTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号(字段类型:int,字段长度:4,是否可空:True)
 objvTabFieldRelaEN.IsNeedCheckPriForeignKey = TransNullToBool(objDT.Rows[0][convTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFieldRelaEN.IsTabForeignKey = TransNullToBool(objDT.Rows[0][convTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFieldRelaEN.PrimaryKeyFieldName = objDT.Rows[0][convTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFieldRelaEN.PrimaryKeyTabName = objDT.Rows[0][convTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFieldRelaEN.DefaultValue = objDT.Rows[0][convTabFieldRela.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFieldRelaEN.TransWayId = objDT.Rows[0][convTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID(字段类型:char,字段长度:2,是否可空:False)
 objvTabFieldRelaEN.TransWayName = objDT.Rows[0][convTabFieldRela.TransWayName].ToString().Trim(); //转换方式名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabFieldRelaEN.FldLength = TransNullToInt(objDT.Rows[0][convTabFieldRela.FldLength].ToString().Trim()); //字段长度(字段类型:int,字段长度:4,是否可空:False)
 objvTabFieldRelaEN.TransMissingValue = objDT.Rows[0][convTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFieldRelaEN.TransNullValue = objDT.Rows[0][convTabFieldRela.TransNullValue].ToString().Trim(); //转换空值(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFieldRelaEN.PrjName = objDT.Rows[0][convTabFieldRela.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabFieldRelaEN.PrjId = objDT.Rows[0][convTabFieldRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFieldRelaEN.PrefixFldName = objDT.Rows[0][convTabFieldRela.PrefixFldName].ToString().Trim(); //前缀字段名(字段类型:varchar,字段长度:100,是否可空:True)
 objvTabFieldRelaEN.Keyword = objDT.Rows[0][convTabFieldRela.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFieldRelaEN.TabCnName = objDT.Rows[0][convTabFieldRela.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTabFieldRelaEN.TabEnName = objDT.Rows[0][convTabFieldRela.TabEnName].ToString().Trim(); //表英文详细名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTabFieldRelaEN.Memo = objDT.Rows[0][convTabFieldRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTabFieldRelaDA: GetvTabFieldRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdFieldTabRela">表关键字</param>
 /// <returns>表对象</returns>
public clsvTabFieldRelaEN GetObjByIdFieldTabRela(long lngIdFieldTabRela)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
strSQL = "Select * from vTabFieldRela where IdFieldTabRela = " + ""+ lngIdFieldTabRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTabFieldRelaEN objvTabFieldRelaEN = new clsvTabFieldRelaEN();
try
{
 objvTabFieldRelaEN.IdFieldTabRela = Int32.Parse(objRow[convTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvTabFieldRelaEN.TabId = objRow[convTabFieldRela.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvTabFieldRelaEN.FldId = objRow[convTabFieldRela.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvTabFieldRelaEN.FldName = objRow[convTabFieldRela.FldName] == DBNull.Value ? null : objRow[convTabFieldRela.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvTabFieldRelaEN.Caption = objRow[convTabFieldRela.Caption] == DBNull.Value ? null : objRow[convTabFieldRela.Caption].ToString().Trim(); //标题(字段类型:varchar,字段长度:200,是否可空:False)
 objvTabFieldRelaEN.SqlFldName = objRow[convTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[convTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvTabFieldRelaEN.ExcelFieldName = objRow[convTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabFieldRelaEN.IsNeedTrans = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换(字段类型:bit,字段长度:1,是否可空:False)
 objvTabFieldRelaEN.TransOutFldName = objRow[convTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFieldRelaEN.TransInFldName = objRow[convTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFieldRelaEN.PrimaryTypeId = objRow[convTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvTabFieldRelaEN.PrimaryTypeName = objRow[convTabFieldRela.PrimaryTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeName].ToString().Trim(); //主键类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabFieldRelaEN.TransTabName = objRow[convTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[convTabFieldRela.TransTabName].ToString().Trim(); //转换表名(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFieldRelaEN.IsIdentity = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFieldRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFieldRelaEN.IsTabPrimary = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键(字段类型:bit,字段长度:1,是否可空:False)
 objvTabFieldRelaEN.IsTabNullable = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFieldRelaEN.IsTabUnique = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFieldRelaEN.DataTypeName = objRow[convTabFieldRela.DataTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvTabFieldRelaEN.SequenceNumber = objRow[convTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号(字段类型:int,字段长度:4,是否可空:True)
 objvTabFieldRelaEN.IsNeedCheckPriForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFieldRelaEN.IsTabForeignKey = clsEntityBase2.TransNullToBool_S(objRow[convTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键(字段类型:bit,字段长度:1,是否可空:True)
 objvTabFieldRelaEN.PrimaryKeyFieldName = objRow[convTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFieldRelaEN.PrimaryKeyTabName = objRow[convTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFieldRelaEN.DefaultValue = objRow[convTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[convTabFieldRela.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFieldRelaEN.TransWayId = objRow[convTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID(字段类型:char,字段长度:2,是否可空:False)
 objvTabFieldRelaEN.TransWayName = objRow[convTabFieldRela.TransWayName] == DBNull.Value ? null : objRow[convTabFieldRela.TransWayName].ToString().Trim(); //转换方式名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabFieldRelaEN.FldLength = objRow[convTabFieldRela.FldLength] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabFieldRela.FldLength].ToString().Trim()); //字段长度(字段类型:int,字段长度:4,是否可空:False)
 objvTabFieldRelaEN.TransMissingValue = objRow[convTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFieldRelaEN.TransNullValue = objRow[convTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransNullValue].ToString().Trim(); //转换空值(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFieldRelaEN.PrjName = objRow[convTabFieldRela.PrjName] == DBNull.Value ? null : objRow[convTabFieldRela.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabFieldRelaEN.PrjId = objRow[convTabFieldRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabFieldRelaEN.PrefixFldName = objRow[convTabFieldRela.PrefixFldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrefixFldName].ToString().Trim(); //前缀字段名(字段类型:varchar,字段长度:100,是否可空:True)
 objvTabFieldRelaEN.Keyword = objRow[convTabFieldRela.Keyword] == DBNull.Value ? null : objRow[convTabFieldRela.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabFieldRelaEN.TabCnName = objRow[convTabFieldRela.TabCnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTabFieldRelaEN.TabEnName = objRow[convTabFieldRela.TabEnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabEnName].ToString().Trim(); //表英文详细名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTabFieldRelaEN.Memo = objRow[convTabFieldRela.Memo] == DBNull.Value ? null : objRow[convTabFieldRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTabFieldRelaDA: GetObjByIdFieldTabRela)", objException.Message));
}
return objvTabFieldRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTabFieldRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTabFieldRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
strSQL = "Select * from vTabFieldRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTabFieldRelaEN objvTabFieldRelaEN = new clsvTabFieldRelaEN()
{
IdFieldTabRela = TransNullToInt(objRow[convTabFieldRela.IdFieldTabRela].ToString().Trim()), //字段表关系流水号
TabId = objRow[convTabFieldRela.TabId].ToString().Trim(), //表ID
FldId = objRow[convTabFieldRela.FldId].ToString().Trim(), //字段Id
FldName = objRow[convTabFieldRela.FldName] == DBNull.Value ? null : objRow[convTabFieldRela.FldName].ToString().Trim(), //字段名
Caption = objRow[convTabFieldRela.Caption] == DBNull.Value ? null : objRow[convTabFieldRela.Caption].ToString().Trim(), //标题
SqlFldName = objRow[convTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[convTabFieldRela.SqlFldName].ToString().Trim(), //Sql字段名称
ExcelFieldName = objRow[convTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.ExcelFieldName].ToString().Trim(), //Excel字段名称
IsNeedTrans = TransNullToBool(objRow[convTabFieldRela.IsNeedTrans].ToString().Trim()), //是否需要转换
TransOutFldName = objRow[convTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransOutFldName].ToString().Trim(), //转换Out字段名
TransInFldName = objRow[convTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransInFldName].ToString().Trim(), //转换IN字段名
PrimaryTypeId = objRow[convTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeId].ToString().Trim(), //主键类型ID
PrimaryTypeName = objRow[convTabFieldRela.PrimaryTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeName].ToString().Trim(), //主键类型名
TransTabName = objRow[convTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[convTabFieldRela.TransTabName].ToString().Trim(), //转换表名
IsIdentity = TransNullToBool(objRow[convTabFieldRela.IsIdentity].ToString().Trim()), //是否Identity
IsVisible = TransNullToBool(objRow[convTabFieldRela.IsVisible].ToString().Trim()), //是否显示
IsTabPrimary = TransNullToBool(objRow[convTabFieldRela.IsTabPrimary].ToString().Trim()), //是否作为表中主键
IsTabNullable = TransNullToBool(objRow[convTabFieldRela.IsTabNullable].ToString().Trim()), //是否表中可空
IsTabUnique = TransNullToBool(objRow[convTabFieldRela.IsTabUnique].ToString().Trim()), //是否表中唯一
DataTypeName = objRow[convTabFieldRela.DataTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.DataTypeName].ToString().Trim(), //数据类型名称
SequenceNumber = objRow[convTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFieldRela.SequenceNumber].ToString().Trim()), //顺序号
IsNeedCheckPriForeignKey = TransNullToBool(objRow[convTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()), //是否检查主外键
IsTabForeignKey = TransNullToBool(objRow[convTabFieldRela.IsTabForeignKey].ToString().Trim()), //是否表外键
PrimaryKeyFieldName = objRow[convTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyFieldName].ToString().Trim(), //主键字段名
PrimaryKeyTabName = objRow[convTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyTabName].ToString().Trim(), //主键表
DefaultValue = objRow[convTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[convTabFieldRela.DefaultValue].ToString().Trim(), //缺省值
TransWayId = objRow[convTabFieldRela.TransWayId].ToString().Trim(), //转换方式ID
TransWayName = objRow[convTabFieldRela.TransWayName] == DBNull.Value ? null : objRow[convTabFieldRela.TransWayName].ToString().Trim(), //转换方式名称
FldLength = objRow[convTabFieldRela.FldLength] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFieldRela.FldLength].ToString().Trim()), //字段长度
TransMissingValue = objRow[convTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransMissingValue].ToString().Trim(), //转换失败值
TransNullValue = objRow[convTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransNullValue].ToString().Trim(), //转换空值
PrjName = objRow[convTabFieldRela.PrjName] == DBNull.Value ? null : objRow[convTabFieldRela.PrjName].ToString().Trim(), //工程名称
PrjId = objRow[convTabFieldRela.PrjId].ToString().Trim(), //工程Id
PrefixFldName = objRow[convTabFieldRela.PrefixFldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrefixFldName].ToString().Trim(), //前缀字段名
Keyword = objRow[convTabFieldRela.Keyword] == DBNull.Value ? null : objRow[convTabFieldRela.Keyword].ToString().Trim(), //关键字
TabCnName = objRow[convTabFieldRela.TabCnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabCnName].ToString().Trim(), //表中文名
TabEnName = objRow[convTabFieldRela.TabEnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabEnName].ToString().Trim(), //表英文详细名
Memo = objRow[convTabFieldRela.Memo] == DBNull.Value ? null : objRow[convTabFieldRela.Memo].ToString().Trim() //说明
};
objvTabFieldRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTabFieldRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTabFieldRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTabFieldRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTabFieldRelaEN objvTabFieldRelaEN = new clsvTabFieldRelaEN();
try
{
objvTabFieldRelaEN.IdFieldTabRela = TransNullToInt(objRow[convTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objvTabFieldRelaEN.TabId = objRow[convTabFieldRela.TabId].ToString().Trim(); //表ID
objvTabFieldRelaEN.FldId = objRow[convTabFieldRela.FldId].ToString().Trim(); //字段Id
objvTabFieldRelaEN.FldName = objRow[convTabFieldRela.FldName] == DBNull.Value ? null : objRow[convTabFieldRela.FldName].ToString().Trim(); //字段名
objvTabFieldRelaEN.Caption = objRow[convTabFieldRela.Caption] == DBNull.Value ? null : objRow[convTabFieldRela.Caption].ToString().Trim(); //标题
objvTabFieldRelaEN.SqlFldName = objRow[convTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[convTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objvTabFieldRelaEN.ExcelFieldName = objRow[convTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objvTabFieldRelaEN.IsNeedTrans = TransNullToBool(objRow[convTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objvTabFieldRelaEN.TransOutFldName = objRow[convTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objvTabFieldRelaEN.TransInFldName = objRow[convTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objvTabFieldRelaEN.PrimaryTypeId = objRow[convTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvTabFieldRelaEN.PrimaryTypeName = objRow[convTabFieldRela.PrimaryTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeName].ToString().Trim(); //主键类型名
objvTabFieldRelaEN.TransTabName = objRow[convTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[convTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objvTabFieldRelaEN.IsIdentity = TransNullToBool(objRow[convTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objvTabFieldRelaEN.IsVisible = TransNullToBool(objRow[convTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objvTabFieldRelaEN.IsTabPrimary = TransNullToBool(objRow[convTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objvTabFieldRelaEN.IsTabNullable = TransNullToBool(objRow[convTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objvTabFieldRelaEN.IsTabUnique = TransNullToBool(objRow[convTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objvTabFieldRelaEN.DataTypeName = objRow[convTabFieldRela.DataTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFieldRelaEN.SequenceNumber = objRow[convTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objvTabFieldRelaEN.IsNeedCheckPriForeignKey = TransNullToBool(objRow[convTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objvTabFieldRelaEN.IsTabForeignKey = TransNullToBool(objRow[convTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objvTabFieldRelaEN.PrimaryKeyFieldName = objRow[convTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objvTabFieldRelaEN.PrimaryKeyTabName = objRow[convTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objvTabFieldRelaEN.DefaultValue = objRow[convTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[convTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objvTabFieldRelaEN.TransWayId = objRow[convTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objvTabFieldRelaEN.TransWayName = objRow[convTabFieldRela.TransWayName] == DBNull.Value ? null : objRow[convTabFieldRela.TransWayName].ToString().Trim(); //转换方式名称
objvTabFieldRelaEN.FldLength = objRow[convTabFieldRela.FldLength] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFieldRela.FldLength].ToString().Trim()); //字段长度
objvTabFieldRelaEN.TransMissingValue = objRow[convTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objvTabFieldRelaEN.TransNullValue = objRow[convTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objvTabFieldRelaEN.PrjName = objRow[convTabFieldRela.PrjName] == DBNull.Value ? null : objRow[convTabFieldRela.PrjName].ToString().Trim(); //工程名称
objvTabFieldRelaEN.PrjId = objRow[convTabFieldRela.PrjId].ToString().Trim(); //工程Id
objvTabFieldRelaEN.PrefixFldName = objRow[convTabFieldRela.PrefixFldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrefixFldName].ToString().Trim(); //前缀字段名
objvTabFieldRelaEN.Keyword = objRow[convTabFieldRela.Keyword] == DBNull.Value ? null : objRow[convTabFieldRela.Keyword].ToString().Trim(); //关键字
objvTabFieldRelaEN.TabCnName = objRow[convTabFieldRela.TabCnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabCnName].ToString().Trim(); //表中文名
objvTabFieldRelaEN.TabEnName = objRow[convTabFieldRela.TabEnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabEnName].ToString().Trim(); //表英文详细名
objvTabFieldRelaEN.Memo = objRow[convTabFieldRela.Memo] == DBNull.Value ? null : objRow[convTabFieldRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTabFieldRelaDA: GetObjByDataRowvTabFieldRela)", objException.Message));
}
objvTabFieldRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTabFieldRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTabFieldRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTabFieldRelaEN objvTabFieldRelaEN = new clsvTabFieldRelaEN();
try
{
objvTabFieldRelaEN.IdFieldTabRela = TransNullToInt(objRow[convTabFieldRela.IdFieldTabRela].ToString().Trim()); //字段表关系流水号
objvTabFieldRelaEN.TabId = objRow[convTabFieldRela.TabId].ToString().Trim(); //表ID
objvTabFieldRelaEN.FldId = objRow[convTabFieldRela.FldId].ToString().Trim(); //字段Id
objvTabFieldRelaEN.FldName = objRow[convTabFieldRela.FldName] == DBNull.Value ? null : objRow[convTabFieldRela.FldName].ToString().Trim(); //字段名
objvTabFieldRelaEN.Caption = objRow[convTabFieldRela.Caption] == DBNull.Value ? null : objRow[convTabFieldRela.Caption].ToString().Trim(); //标题
objvTabFieldRelaEN.SqlFldName = objRow[convTabFieldRela.SqlFldName] == DBNull.Value ? null : objRow[convTabFieldRela.SqlFldName].ToString().Trim(); //Sql字段名称
objvTabFieldRelaEN.ExcelFieldName = objRow[convTabFieldRela.ExcelFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.ExcelFieldName].ToString().Trim(); //Excel字段名称
objvTabFieldRelaEN.IsNeedTrans = TransNullToBool(objRow[convTabFieldRela.IsNeedTrans].ToString().Trim()); //是否需要转换
objvTabFieldRelaEN.TransOutFldName = objRow[convTabFieldRela.TransOutFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransOutFldName].ToString().Trim(); //转换Out字段名
objvTabFieldRelaEN.TransInFldName = objRow[convTabFieldRela.TransInFldName] == DBNull.Value ? null : objRow[convTabFieldRela.TransInFldName].ToString().Trim(); //转换IN字段名
objvTabFieldRelaEN.PrimaryTypeId = objRow[convTabFieldRela.PrimaryTypeId] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvTabFieldRelaEN.PrimaryTypeName = objRow[convTabFieldRela.PrimaryTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryTypeName].ToString().Trim(); //主键类型名
objvTabFieldRelaEN.TransTabName = objRow[convTabFieldRela.TransTabName] == DBNull.Value ? null : objRow[convTabFieldRela.TransTabName].ToString().Trim(); //转换表名
objvTabFieldRelaEN.IsIdentity = TransNullToBool(objRow[convTabFieldRela.IsIdentity].ToString().Trim()); //是否Identity
objvTabFieldRelaEN.IsVisible = TransNullToBool(objRow[convTabFieldRela.IsVisible].ToString().Trim()); //是否显示
objvTabFieldRelaEN.IsTabPrimary = TransNullToBool(objRow[convTabFieldRela.IsTabPrimary].ToString().Trim()); //是否作为表中主键
objvTabFieldRelaEN.IsTabNullable = TransNullToBool(objRow[convTabFieldRela.IsTabNullable].ToString().Trim()); //是否表中可空
objvTabFieldRelaEN.IsTabUnique = TransNullToBool(objRow[convTabFieldRela.IsTabUnique].ToString().Trim()); //是否表中唯一
objvTabFieldRelaEN.DataTypeName = objRow[convTabFieldRela.DataTypeName] == DBNull.Value ? null : objRow[convTabFieldRela.DataTypeName].ToString().Trim(); //数据类型名称
objvTabFieldRelaEN.SequenceNumber = objRow[convTabFieldRela.SequenceNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFieldRela.SequenceNumber].ToString().Trim()); //顺序号
objvTabFieldRelaEN.IsNeedCheckPriForeignKey = TransNullToBool(objRow[convTabFieldRela.IsNeedCheckPriForeignKey].ToString().Trim()); //是否检查主外键
objvTabFieldRelaEN.IsTabForeignKey = TransNullToBool(objRow[convTabFieldRela.IsTabForeignKey].ToString().Trim()); //是否表外键
objvTabFieldRelaEN.PrimaryKeyFieldName = objRow[convTabFieldRela.PrimaryKeyFieldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyFieldName].ToString().Trim(); //主键字段名
objvTabFieldRelaEN.PrimaryKeyTabName = objRow[convTabFieldRela.PrimaryKeyTabName] == DBNull.Value ? null : objRow[convTabFieldRela.PrimaryKeyTabName].ToString().Trim(); //主键表
objvTabFieldRelaEN.DefaultValue = objRow[convTabFieldRela.DefaultValue] == DBNull.Value ? null : objRow[convTabFieldRela.DefaultValue].ToString().Trim(); //缺省值
objvTabFieldRelaEN.TransWayId = objRow[convTabFieldRela.TransWayId].ToString().Trim(); //转换方式ID
objvTabFieldRelaEN.TransWayName = objRow[convTabFieldRela.TransWayName] == DBNull.Value ? null : objRow[convTabFieldRela.TransWayName].ToString().Trim(); //转换方式名称
objvTabFieldRelaEN.FldLength = objRow[convTabFieldRela.FldLength] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabFieldRela.FldLength].ToString().Trim()); //字段长度
objvTabFieldRelaEN.TransMissingValue = objRow[convTabFieldRela.TransMissingValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransMissingValue].ToString().Trim(); //转换失败值
objvTabFieldRelaEN.TransNullValue = objRow[convTabFieldRela.TransNullValue] == DBNull.Value ? null : objRow[convTabFieldRela.TransNullValue].ToString().Trim(); //转换空值
objvTabFieldRelaEN.PrjName = objRow[convTabFieldRela.PrjName] == DBNull.Value ? null : objRow[convTabFieldRela.PrjName].ToString().Trim(); //工程名称
objvTabFieldRelaEN.PrjId = objRow[convTabFieldRela.PrjId].ToString().Trim(); //工程Id
objvTabFieldRelaEN.PrefixFldName = objRow[convTabFieldRela.PrefixFldName] == DBNull.Value ? null : objRow[convTabFieldRela.PrefixFldName].ToString().Trim(); //前缀字段名
objvTabFieldRelaEN.Keyword = objRow[convTabFieldRela.Keyword] == DBNull.Value ? null : objRow[convTabFieldRela.Keyword].ToString().Trim(); //关键字
objvTabFieldRelaEN.TabCnName = objRow[convTabFieldRela.TabCnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabCnName].ToString().Trim(); //表中文名
objvTabFieldRelaEN.TabEnName = objRow[convTabFieldRela.TabEnName] == DBNull.Value ? null : objRow[convTabFieldRela.TabEnName].ToString().Trim(); //表英文详细名
objvTabFieldRelaEN.Memo = objRow[convTabFieldRela.Memo] == DBNull.Value ? null : objRow[convTabFieldRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTabFieldRelaDA: GetObjByDataRow)", objException.Message));
}
objvTabFieldRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTabFieldRelaEN;
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
objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTabFieldRelaEN._CurrTabName, convTabFieldRela.IdFieldTabRela, 8, "");
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
objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTabFieldRelaEN._CurrTabName, convTabFieldRela.IdFieldTabRela, 8, strPrefix);
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
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdFieldTabRela from vTabFieldRela where " + strCondition;
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
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdFieldTabRela from vTabFieldRela where " + strCondition;
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
 /// <param name = "lngIdFieldTabRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdFieldTabRela)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTabFieldRela", "IdFieldTabRela = " + ""+ lngIdFieldTabRela+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTabFieldRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTabFieldRela", strCondition))
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
objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTabFieldRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTabFieldRelaENS">源对象</param>
 /// <param name = "objvTabFieldRelaENT">目标对象</param>
public void CopyTo(clsvTabFieldRelaEN objvTabFieldRelaENS, clsvTabFieldRelaEN objvTabFieldRelaENT)
{
objvTabFieldRelaENT.IdFieldTabRela = objvTabFieldRelaENS.IdFieldTabRela; //字段表关系流水号
objvTabFieldRelaENT.TabId = objvTabFieldRelaENS.TabId; //表ID
objvTabFieldRelaENT.FldId = objvTabFieldRelaENS.FldId; //字段Id
objvTabFieldRelaENT.FldName = objvTabFieldRelaENS.FldName; //字段名
objvTabFieldRelaENT.Caption = objvTabFieldRelaENS.Caption; //标题
objvTabFieldRelaENT.SqlFldName = objvTabFieldRelaENS.SqlFldName; //Sql字段名称
objvTabFieldRelaENT.ExcelFieldName = objvTabFieldRelaENS.ExcelFieldName; //Excel字段名称
objvTabFieldRelaENT.IsNeedTrans = objvTabFieldRelaENS.IsNeedTrans; //是否需要转换
objvTabFieldRelaENT.TransOutFldName = objvTabFieldRelaENS.TransOutFldName; //转换Out字段名
objvTabFieldRelaENT.TransInFldName = objvTabFieldRelaENS.TransInFldName; //转换IN字段名
objvTabFieldRelaENT.PrimaryTypeId = objvTabFieldRelaENS.PrimaryTypeId; //主键类型ID
objvTabFieldRelaENT.PrimaryTypeName = objvTabFieldRelaENS.PrimaryTypeName; //主键类型名
objvTabFieldRelaENT.TransTabName = objvTabFieldRelaENS.TransTabName; //转换表名
objvTabFieldRelaENT.IsIdentity = objvTabFieldRelaENS.IsIdentity; //是否Identity
objvTabFieldRelaENT.IsVisible = objvTabFieldRelaENS.IsVisible; //是否显示
objvTabFieldRelaENT.IsTabPrimary = objvTabFieldRelaENS.IsTabPrimary; //是否作为表中主键
objvTabFieldRelaENT.IsTabNullable = objvTabFieldRelaENS.IsTabNullable; //是否表中可空
objvTabFieldRelaENT.IsTabUnique = objvTabFieldRelaENS.IsTabUnique; //是否表中唯一
objvTabFieldRelaENT.DataTypeName = objvTabFieldRelaENS.DataTypeName; //数据类型名称
objvTabFieldRelaENT.SequenceNumber = objvTabFieldRelaENS.SequenceNumber; //顺序号
objvTabFieldRelaENT.IsNeedCheckPriForeignKey = objvTabFieldRelaENS.IsNeedCheckPriForeignKey; //是否检查主外键
objvTabFieldRelaENT.IsTabForeignKey = objvTabFieldRelaENS.IsTabForeignKey; //是否表外键
objvTabFieldRelaENT.PrimaryKeyFieldName = objvTabFieldRelaENS.PrimaryKeyFieldName; //主键字段名
objvTabFieldRelaENT.PrimaryKeyTabName = objvTabFieldRelaENS.PrimaryKeyTabName; //主键表
objvTabFieldRelaENT.DefaultValue = objvTabFieldRelaENS.DefaultValue; //缺省值
objvTabFieldRelaENT.TransWayId = objvTabFieldRelaENS.TransWayId; //转换方式ID
objvTabFieldRelaENT.TransWayName = objvTabFieldRelaENS.TransWayName; //转换方式名称
objvTabFieldRelaENT.FldLength = objvTabFieldRelaENS.FldLength; //字段长度
objvTabFieldRelaENT.TransMissingValue = objvTabFieldRelaENS.TransMissingValue; //转换失败值
objvTabFieldRelaENT.TransNullValue = objvTabFieldRelaENS.TransNullValue; //转换空值
objvTabFieldRelaENT.PrjName = objvTabFieldRelaENS.PrjName; //工程名称
objvTabFieldRelaENT.PrjId = objvTabFieldRelaENS.PrjId; //工程Id
objvTabFieldRelaENT.PrefixFldName = objvTabFieldRelaENS.PrefixFldName; //前缀字段名
objvTabFieldRelaENT.Keyword = objvTabFieldRelaENS.Keyword; //关键字
objvTabFieldRelaENT.TabCnName = objvTabFieldRelaENS.TabCnName; //表中文名
objvTabFieldRelaENT.TabEnName = objvTabFieldRelaENS.TabEnName; //表英文详细名
objvTabFieldRelaENT.Memo = objvTabFieldRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTabFieldRelaEN objvTabFieldRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.TabId, 8, convTabFieldRela.TabId);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.FldId, 8, convTabFieldRela.FldId);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.FldName, 50, convTabFieldRela.FldName);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.Caption, 200, convTabFieldRela.Caption);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.SqlFldName, 100, convTabFieldRela.SqlFldName);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.ExcelFieldName, 100, convTabFieldRela.ExcelFieldName);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.TransOutFldName, 50, convTabFieldRela.TransOutFldName);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.TransInFldName, 50, convTabFieldRela.TransInFldName);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.PrimaryTypeId, 2, convTabFieldRela.PrimaryTypeId);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.PrimaryTypeName, 30, convTabFieldRela.PrimaryTypeName);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.TransTabName, 50, convTabFieldRela.TransTabName);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.DataTypeName, 100, convTabFieldRela.DataTypeName);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.PrimaryKeyFieldName, 50, convTabFieldRela.PrimaryKeyFieldName);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.PrimaryKeyTabName, 50, convTabFieldRela.PrimaryKeyTabName);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.DefaultValue, 50, convTabFieldRela.DefaultValue);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.TransWayId, 2, convTabFieldRela.TransWayId);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.TransWayName, 30, convTabFieldRela.TransWayName);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.TransMissingValue, 50, convTabFieldRela.TransMissingValue);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.TransNullValue, 50, convTabFieldRela.TransNullValue);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.PrjName, 30, convTabFieldRela.PrjName);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.PrjId, 4, convTabFieldRela.PrjId);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.PrefixFldName, 100, convTabFieldRela.PrefixFldName);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.Keyword, 50, convTabFieldRela.Keyword);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.TabCnName, 200, convTabFieldRela.TabCnName);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.TabEnName, 200, convTabFieldRela.TabEnName);
clsCheckSql.CheckFieldLen(objvTabFieldRelaEN.Memo, 1000, convTabFieldRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.TabId, convTabFieldRela.TabId);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.FldId, convTabFieldRela.FldId);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.FldName, convTabFieldRela.FldName);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.Caption, convTabFieldRela.Caption);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.SqlFldName, convTabFieldRela.SqlFldName);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.ExcelFieldName, convTabFieldRela.ExcelFieldName);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.TransOutFldName, convTabFieldRela.TransOutFldName);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.TransInFldName, convTabFieldRela.TransInFldName);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.PrimaryTypeId, convTabFieldRela.PrimaryTypeId);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.PrimaryTypeName, convTabFieldRela.PrimaryTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.TransTabName, convTabFieldRela.TransTabName);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.DataTypeName, convTabFieldRela.DataTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.PrimaryKeyFieldName, convTabFieldRela.PrimaryKeyFieldName);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.PrimaryKeyTabName, convTabFieldRela.PrimaryKeyTabName);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.DefaultValue, convTabFieldRela.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.TransWayId, convTabFieldRela.TransWayId);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.TransWayName, convTabFieldRela.TransWayName);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.TransMissingValue, convTabFieldRela.TransMissingValue);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.TransNullValue, convTabFieldRela.TransNullValue);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.PrjName, convTabFieldRela.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.PrjId, convTabFieldRela.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.PrefixFldName, convTabFieldRela.PrefixFldName);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.Keyword, convTabFieldRela.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.TabCnName, convTabFieldRela.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.TabEnName, convTabFieldRela.TabEnName);
clsCheckSql.CheckSqlInjection4Field(objvTabFieldRelaEN.Memo, convTabFieldRela.Memo);
//检查外键字段长度
 objvTabFieldRelaEN._IsCheckProperty = true;
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
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
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
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
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
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTabFieldRelaEN._CurrTabName);
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
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTabFieldRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvTabFieldRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}