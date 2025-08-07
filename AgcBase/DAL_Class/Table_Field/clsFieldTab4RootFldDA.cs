
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFieldTab4RootFldDA
 表名:FieldTab4RootFld(00050422)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:14
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
 /// 工程字段4RootFld(FieldTab4RootFld)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFieldTab4RootFldDA : clsCommBase4DA
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
 return clsFieldTab4RootFldEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFieldTab4RootFldEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFieldTab4RootFldEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFieldTab4RootFldEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFieldTab4RootFldEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFieldTab4RootFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4RootFld where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FieldTab4RootFld(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFieldTab4RootFldDA: GetDataTable_FieldTab4RootFld)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4RootFld where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFieldTab4RootFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFieldTab4RootFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4RootFld where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFieldTab4RootFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFieldTab4RootFldDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FieldTab4RootFld where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FieldTab4RootFld where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFieldTab4RootFldDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FieldTab4RootFld where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFieldTab4RootFldDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FieldTab4RootFld.* " + 
$"from FieldTab4RootFld " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FieldTab4RootFld.mId not in " + 
$"(Select top {intTop_In} FieldTab4RootFld.mId from FieldTab4RootFld " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FieldTab4RootFld where {1} and mId not in (Select top {2} mId from FieldTab4RootFld where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FieldTab4RootFld where {1} and mId not in (Select top {3} mId from FieldTab4RootFld where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFieldTab4RootFldDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FieldTab4RootFld.* " + 
$"from FieldTab4RootFld " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FieldTab4RootFld.mId not in " + 
$"(Select top {intTop_In} FieldTab4RootFld.mId from FieldTab4RootFld " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FieldTab4RootFld where {1} and mId not in (Select top {2} mId from FieldTab4RootFld where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FieldTab4RootFld where {1} and mId not in (Select top {3} mId from FieldTab4RootFld where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsFieldTab4RootFldEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFieldTab4RootFldDA:GetObjLst)", objException.Message));
}
List<clsFieldTab4RootFldEN> arrObjLst = new List<clsFieldTab4RootFldEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4RootFld where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTab4RootFldEN objFieldTab4RootFldEN = new clsFieldTab4RootFldEN();
try
{
objFieldTab4RootFldEN.mId = TransNullToInt(objRow[conFieldTab4RootFld.mId].ToString().Trim()); //mId
objFieldTab4RootFldEN.TabId = objRow[conFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objFieldTab4RootFldEN.FldId = objRow[conFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objFieldTab4RootFldEN.IsPrimaryKey = TransNullToBool(objRow[conFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTab4RootFldEN.IsRootFld = TransNullToBool(objRow[conFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objFieldTab4RootFldEN.Root4TabId = objRow[conFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objFieldTab4RootFldEN.RootFldId = objRow[conFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objFieldTab4RootFldEN.RootTabId = objRow[conFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objFieldTab4RootFldEN.PrjId = objRow[conFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objFieldTab4RootFldEN.UpdUser = objRow[conFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objFieldTab4RootFldEN.UpdDate = objRow[conFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objFieldTab4RootFldEN.Memo = objRow[conFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFieldTab4RootFldDA: GetObjLst)", objException.Message));
}
objFieldTab4RootFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFieldTab4RootFldEN);
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
public List<clsFieldTab4RootFldEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFieldTab4RootFldDA:GetObjLstByTabName)", objException.Message));
}
List<clsFieldTab4RootFldEN> arrObjLst = new List<clsFieldTab4RootFldEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFieldTab4RootFldEN objFieldTab4RootFldEN = new clsFieldTab4RootFldEN();
try
{
objFieldTab4RootFldEN.mId = TransNullToInt(objRow[conFieldTab4RootFld.mId].ToString().Trim()); //mId
objFieldTab4RootFldEN.TabId = objRow[conFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objFieldTab4RootFldEN.FldId = objRow[conFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objFieldTab4RootFldEN.IsPrimaryKey = TransNullToBool(objRow[conFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTab4RootFldEN.IsRootFld = TransNullToBool(objRow[conFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objFieldTab4RootFldEN.Root4TabId = objRow[conFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objFieldTab4RootFldEN.RootFldId = objRow[conFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objFieldTab4RootFldEN.RootTabId = objRow[conFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objFieldTab4RootFldEN.PrjId = objRow[conFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objFieldTab4RootFldEN.UpdUser = objRow[conFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objFieldTab4RootFldEN.UpdDate = objRow[conFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objFieldTab4RootFldEN.Memo = objRow[conFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFieldTab4RootFldDA: GetObjLst)", objException.Message));
}
objFieldTab4RootFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFieldTab4RootFldEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFieldTab4RootFld(ref clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4RootFld where mId = " + ""+ objFieldTab4RootFldEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFieldTab4RootFldEN.mId = TransNullToInt(objDT.Rows[0][conFieldTab4RootFld.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objFieldTab4RootFldEN.TabId = objDT.Rows[0][conFieldTab4RootFld.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objFieldTab4RootFldEN.FldId = objDT.Rows[0][conFieldTab4RootFld.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objFieldTab4RootFldEN.IsPrimaryKey = TransNullToBool(objDT.Rows[0][conFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键(字段类型:bit,字段长度:1,是否可空:False)
 objFieldTab4RootFldEN.IsRootFld = TransNullToBool(objDT.Rows[0][conFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段(字段类型:bit,字段长度:1,是否可空:True)
 objFieldTab4RootFldEN.Root4TabId = objDT.Rows[0][conFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id(字段类型:char,字段长度:8,是否可空:True)
 objFieldTab4RootFldEN.RootFldId = objDT.Rows[0][conFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id(字段类型:char,字段长度:8,是否可空:True)
 objFieldTab4RootFldEN.RootTabId = objDT.Rows[0][conFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id(字段类型:char,字段长度:8,是否可空:True)
 objFieldTab4RootFldEN.PrjId = objDT.Rows[0][conFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objFieldTab4RootFldEN.UpdUser = objDT.Rows[0][conFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFieldTab4RootFldEN.UpdDate = objDT.Rows[0][conFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFieldTab4RootFldEN.Memo = objDT.Rows[0][conFieldTab4RootFld.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFieldTab4RootFldDA: GetFieldTab4RootFld)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsFieldTab4RootFldEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4RootFld where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFieldTab4RootFldEN objFieldTab4RootFldEN = new clsFieldTab4RootFldEN();
try
{
 objFieldTab4RootFldEN.mId = Int32.Parse(objRow[conFieldTab4RootFld.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objFieldTab4RootFldEN.TabId = objRow[conFieldTab4RootFld.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objFieldTab4RootFldEN.FldId = objRow[conFieldTab4RootFld.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objFieldTab4RootFldEN.IsPrimaryKey = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键(字段类型:bit,字段长度:1,是否可空:False)
 objFieldTab4RootFldEN.IsRootFld = clsEntityBase2.TransNullToBool_S(objRow[conFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段(字段类型:bit,字段长度:1,是否可空:True)
 objFieldTab4RootFldEN.Root4TabId = objRow[conFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id(字段类型:char,字段长度:8,是否可空:True)
 objFieldTab4RootFldEN.RootFldId = objRow[conFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id(字段类型:char,字段长度:8,是否可空:True)
 objFieldTab4RootFldEN.RootTabId = objRow[conFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id(字段类型:char,字段长度:8,是否可空:True)
 objFieldTab4RootFldEN.PrjId = objRow[conFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objFieldTab4RootFldEN.UpdUser = objRow[conFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFieldTab4RootFldEN.UpdDate = objRow[conFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFieldTab4RootFldEN.Memo = objRow[conFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFieldTab4RootFldDA: GetObjBymId)", objException.Message));
}
return objFieldTab4RootFldEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFieldTab4RootFldEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFieldTab4RootFldDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4RootFld where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFieldTab4RootFldEN objFieldTab4RootFldEN = new clsFieldTab4RootFldEN()
{
mId = TransNullToInt(objRow[conFieldTab4RootFld.mId].ToString().Trim()), //mId
TabId = objRow[conFieldTab4RootFld.TabId].ToString().Trim(), //表ID
FldId = objRow[conFieldTab4RootFld.FldId].ToString().Trim(), //字段Id
IsPrimaryKey = TransNullToBool(objRow[conFieldTab4RootFld.IsPrimaryKey].ToString().Trim()), //是否主键
IsRootFld = TransNullToBool(objRow[conFieldTab4RootFld.IsRootFld].ToString().Trim()), //是否根字段
Root4TabId = objRow[conFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Root4TabId].ToString().Trim(), //主根表Id
RootFldId = objRow[conFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootFldId].ToString().Trim(), //根字段Id
RootTabId = objRow[conFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootTabId].ToString().Trim(), //根表Id
PrjId = objRow[conFieldTab4RootFld.PrjId].ToString().Trim(), //工程Id
UpdUser = objRow[conFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdUser].ToString().Trim(), //修改者
UpdDate = objRow[conFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Memo].ToString().Trim() //说明
};
objFieldTab4RootFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFieldTab4RootFldEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFieldTab4RootFldDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFieldTab4RootFldEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFieldTab4RootFldEN objFieldTab4RootFldEN = new clsFieldTab4RootFldEN();
try
{
objFieldTab4RootFldEN.mId = TransNullToInt(objRow[conFieldTab4RootFld.mId].ToString().Trim()); //mId
objFieldTab4RootFldEN.TabId = objRow[conFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objFieldTab4RootFldEN.FldId = objRow[conFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objFieldTab4RootFldEN.IsPrimaryKey = TransNullToBool(objRow[conFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTab4RootFldEN.IsRootFld = TransNullToBool(objRow[conFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objFieldTab4RootFldEN.Root4TabId = objRow[conFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objFieldTab4RootFldEN.RootFldId = objRow[conFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objFieldTab4RootFldEN.RootTabId = objRow[conFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objFieldTab4RootFldEN.PrjId = objRow[conFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objFieldTab4RootFldEN.UpdUser = objRow[conFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objFieldTab4RootFldEN.UpdDate = objRow[conFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objFieldTab4RootFldEN.Memo = objRow[conFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFieldTab4RootFldDA: GetObjByDataRowFieldTab4RootFld)", objException.Message));
}
objFieldTab4RootFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFieldTab4RootFldEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFieldTab4RootFldEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFieldTab4RootFldEN objFieldTab4RootFldEN = new clsFieldTab4RootFldEN();
try
{
objFieldTab4RootFldEN.mId = TransNullToInt(objRow[conFieldTab4RootFld.mId].ToString().Trim()); //mId
objFieldTab4RootFldEN.TabId = objRow[conFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objFieldTab4RootFldEN.FldId = objRow[conFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objFieldTab4RootFldEN.IsPrimaryKey = TransNullToBool(objRow[conFieldTab4RootFld.IsPrimaryKey].ToString().Trim()); //是否主键
objFieldTab4RootFldEN.IsRootFld = TransNullToBool(objRow[conFieldTab4RootFld.IsRootFld].ToString().Trim()); //是否根字段
objFieldTab4RootFldEN.Root4TabId = objRow[conFieldTab4RootFld.Root4TabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objFieldTab4RootFldEN.RootFldId = objRow[conFieldTab4RootFld.RootFldId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objFieldTab4RootFldEN.RootTabId = objRow[conFieldTab4RootFld.RootTabId] == DBNull.Value ? null : objRow[conFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objFieldTab4RootFldEN.PrjId = objRow[conFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objFieldTab4RootFldEN.UpdUser = objRow[conFieldTab4RootFld.UpdUser] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objFieldTab4RootFldEN.UpdDate = objRow[conFieldTab4RootFld.UpdDate] == DBNull.Value ? null : objRow[conFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objFieldTab4RootFldEN.Memo = objRow[conFieldTab4RootFld.Memo] == DBNull.Value ? null : objRow[conFieldTab4RootFld.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFieldTab4RootFldDA: GetObjByDataRow)", objException.Message));
}
objFieldTab4RootFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFieldTab4RootFldEN;
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
objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFieldTab4RootFldEN._CurrTabName, conFieldTab4RootFld.mId, 8, "");
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
objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFieldTab4RootFldEN._CurrTabName, conFieldTab4RootFld.mId, 8, strPrefix);
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
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from FieldTab4RootFld where " + strCondition;
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
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from FieldTab4RootFld where " + strCondition;
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
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FieldTab4RootFld", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFieldTab4RootFldDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FieldTab4RootFld", strCondition))
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
objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FieldTab4RootFld");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
 {
 objFieldTab4RootFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4RootFldEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFieldTab4RootFldEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4RootFld where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FieldTab4RootFld");
objRow = objDS.Tables["FieldTab4RootFld"].NewRow();
objRow[conFieldTab4RootFld.TabId] = objFieldTab4RootFldEN.TabId; //表ID
objRow[conFieldTab4RootFld.FldId] = objFieldTab4RootFldEN.FldId; //字段Id
objRow[conFieldTab4RootFld.IsPrimaryKey] = objFieldTab4RootFldEN.IsPrimaryKey; //是否主键
objRow[conFieldTab4RootFld.IsRootFld] = objFieldTab4RootFldEN.IsRootFld; //是否根字段
 if (objFieldTab4RootFldEN.Root4TabId !=  "")
 {
objRow[conFieldTab4RootFld.Root4TabId] = objFieldTab4RootFldEN.Root4TabId; //主根表Id
 }
 if (objFieldTab4RootFldEN.RootFldId !=  "")
 {
objRow[conFieldTab4RootFld.RootFldId] = objFieldTab4RootFldEN.RootFldId; //根字段Id
 }
 if (objFieldTab4RootFldEN.RootTabId !=  "")
 {
objRow[conFieldTab4RootFld.RootTabId] = objFieldTab4RootFldEN.RootTabId; //根表Id
 }
objRow[conFieldTab4RootFld.PrjId] = objFieldTab4RootFldEN.PrjId; //工程Id
 if (objFieldTab4RootFldEN.UpdUser !=  "")
 {
objRow[conFieldTab4RootFld.UpdUser] = objFieldTab4RootFldEN.UpdUser; //修改者
 }
 if (objFieldTab4RootFldEN.UpdDate !=  "")
 {
objRow[conFieldTab4RootFld.UpdDate] = objFieldTab4RootFldEN.UpdDate; //修改日期
 }
 if (objFieldTab4RootFldEN.Memo !=  "")
 {
objRow[conFieldTab4RootFld.Memo] = objFieldTab4RootFldEN.Memo; //说明
 }
objDS.Tables[clsFieldTab4RootFldEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFieldTab4RootFldEN._CurrTabName);
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
 /// <param name = "objFieldTab4RootFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
 objFieldTab4RootFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4RootFldEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFieldTab4RootFldEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFieldTab4RootFldEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.TabId);
 var strTabId = objFieldTab4RootFldEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objFieldTab4RootFldEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.FldId);
 var strFldId = objFieldTab4RootFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 arrFieldListForInsert.Add(conFieldTab4RootFld.IsPrimaryKey);
 arrValueListForInsert.Add("'" + (objFieldTab4RootFldEN.IsPrimaryKey  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab4RootFld.IsRootFld);
 arrValueListForInsert.Add("'" + (objFieldTab4RootFldEN.IsRootFld  ==  false ? "0" : "1") + "'");
 
 if (objFieldTab4RootFldEN.Root4TabId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.Root4TabId);
 var strRoot4TabId = objFieldTab4RootFldEN.Root4TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoot4TabId + "'");
 }
 
 if (objFieldTab4RootFldEN.RootFldId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.RootFldId);
 var strRootFldId = objFieldTab4RootFldEN.RootFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRootFldId + "'");
 }
 
 if (objFieldTab4RootFldEN.RootTabId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.RootTabId);
 var strRootTabId = objFieldTab4RootFldEN.RootTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRootTabId + "'");
 }
 
 if (objFieldTab4RootFldEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.PrjId);
 var strPrjId = objFieldTab4RootFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFieldTab4RootFldEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.UpdUser);
 var strUpdUser = objFieldTab4RootFldEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFieldTab4RootFldEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.UpdDate);
 var strUpdDate = objFieldTab4RootFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFieldTab4RootFldEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.Memo);
 var strMemo = objFieldTab4RootFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FieldTab4RootFld");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
 objFieldTab4RootFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4RootFldEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFieldTab4RootFldEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFieldTab4RootFldEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.TabId);
 var strTabId = objFieldTab4RootFldEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objFieldTab4RootFldEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.FldId);
 var strFldId = objFieldTab4RootFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 arrFieldListForInsert.Add(conFieldTab4RootFld.IsPrimaryKey);
 arrValueListForInsert.Add("'" + (objFieldTab4RootFldEN.IsPrimaryKey  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab4RootFld.IsRootFld);
 arrValueListForInsert.Add("'" + (objFieldTab4RootFldEN.IsRootFld  ==  false ? "0" : "1") + "'");
 
 if (objFieldTab4RootFldEN.Root4TabId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.Root4TabId);
 var strRoot4TabId = objFieldTab4RootFldEN.Root4TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoot4TabId + "'");
 }
 
 if (objFieldTab4RootFldEN.RootFldId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.RootFldId);
 var strRootFldId = objFieldTab4RootFldEN.RootFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRootFldId + "'");
 }
 
 if (objFieldTab4RootFldEN.RootTabId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.RootTabId);
 var strRootTabId = objFieldTab4RootFldEN.RootTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRootTabId + "'");
 }
 
 if (objFieldTab4RootFldEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.PrjId);
 var strPrjId = objFieldTab4RootFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFieldTab4RootFldEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.UpdUser);
 var strUpdUser = objFieldTab4RootFldEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFieldTab4RootFldEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.UpdDate);
 var strUpdDate = objFieldTab4RootFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFieldTab4RootFldEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.Memo);
 var strMemo = objFieldTab4RootFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FieldTab4RootFld");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFieldTab4RootFldEN objFieldTab4RootFldEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFieldTab4RootFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4RootFldEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFieldTab4RootFldEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFieldTab4RootFldEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.TabId);
 var strTabId = objFieldTab4RootFldEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objFieldTab4RootFldEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.FldId);
 var strFldId = objFieldTab4RootFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 arrFieldListForInsert.Add(conFieldTab4RootFld.IsPrimaryKey);
 arrValueListForInsert.Add("'" + (objFieldTab4RootFldEN.IsPrimaryKey  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab4RootFld.IsRootFld);
 arrValueListForInsert.Add("'" + (objFieldTab4RootFldEN.IsRootFld  ==  false ? "0" : "1") + "'");
 
 if (objFieldTab4RootFldEN.Root4TabId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.Root4TabId);
 var strRoot4TabId = objFieldTab4RootFldEN.Root4TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoot4TabId + "'");
 }
 
 if (objFieldTab4RootFldEN.RootFldId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.RootFldId);
 var strRootFldId = objFieldTab4RootFldEN.RootFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRootFldId + "'");
 }
 
 if (objFieldTab4RootFldEN.RootTabId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.RootTabId);
 var strRootTabId = objFieldTab4RootFldEN.RootTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRootTabId + "'");
 }
 
 if (objFieldTab4RootFldEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.PrjId);
 var strPrjId = objFieldTab4RootFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFieldTab4RootFldEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.UpdUser);
 var strUpdUser = objFieldTab4RootFldEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFieldTab4RootFldEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.UpdDate);
 var strUpdDate = objFieldTab4RootFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFieldTab4RootFldEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.Memo);
 var strMemo = objFieldTab4RootFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FieldTab4RootFld");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFieldTab4RootFldEN objFieldTab4RootFldEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFieldTab4RootFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4RootFldEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFieldTab4RootFldEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFieldTab4RootFldEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.TabId);
 var strTabId = objFieldTab4RootFldEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objFieldTab4RootFldEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.FldId);
 var strFldId = objFieldTab4RootFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 arrFieldListForInsert.Add(conFieldTab4RootFld.IsPrimaryKey);
 arrValueListForInsert.Add("'" + (objFieldTab4RootFldEN.IsPrimaryKey  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFieldTab4RootFld.IsRootFld);
 arrValueListForInsert.Add("'" + (objFieldTab4RootFldEN.IsRootFld  ==  false ? "0" : "1") + "'");
 
 if (objFieldTab4RootFldEN.Root4TabId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.Root4TabId);
 var strRoot4TabId = objFieldTab4RootFldEN.Root4TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoot4TabId + "'");
 }
 
 if (objFieldTab4RootFldEN.RootFldId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.RootFldId);
 var strRootFldId = objFieldTab4RootFldEN.RootFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRootFldId + "'");
 }
 
 if (objFieldTab4RootFldEN.RootTabId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.RootTabId);
 var strRootTabId = objFieldTab4RootFldEN.RootTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRootTabId + "'");
 }
 
 if (objFieldTab4RootFldEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.PrjId);
 var strPrjId = objFieldTab4RootFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFieldTab4RootFldEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.UpdUser);
 var strUpdUser = objFieldTab4RootFldEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFieldTab4RootFldEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.UpdDate);
 var strUpdDate = objFieldTab4RootFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFieldTab4RootFldEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFieldTab4RootFld.Memo);
 var strMemo = objFieldTab4RootFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FieldTab4RootFld");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFieldTab4RootFlds(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4RootFld where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FieldTab4RootFld");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conFieldTab4RootFld.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFieldTab4RootFldEN._CurrTabName ].NewRow();
objRow[conFieldTab4RootFld.TabId] = oRow[conFieldTab4RootFld.TabId].ToString().Trim(); //表ID
objRow[conFieldTab4RootFld.FldId] = oRow[conFieldTab4RootFld.FldId].ToString().Trim(); //字段Id
objRow[conFieldTab4RootFld.IsPrimaryKey] = oRow[conFieldTab4RootFld.IsPrimaryKey].ToString().Trim(); //是否主键
objRow[conFieldTab4RootFld.IsRootFld] = oRow[conFieldTab4RootFld.IsRootFld].ToString().Trim(); //是否根字段
objRow[conFieldTab4RootFld.Root4TabId] = oRow[conFieldTab4RootFld.Root4TabId].ToString().Trim(); //主根表Id
objRow[conFieldTab4RootFld.RootFldId] = oRow[conFieldTab4RootFld.RootFldId].ToString().Trim(); //根字段Id
objRow[conFieldTab4RootFld.RootTabId] = oRow[conFieldTab4RootFld.RootTabId].ToString().Trim(); //根表Id
objRow[conFieldTab4RootFld.PrjId] = oRow[conFieldTab4RootFld.PrjId].ToString().Trim(); //工程Id
objRow[conFieldTab4RootFld.UpdUser] = oRow[conFieldTab4RootFld.UpdUser].ToString().Trim(); //修改者
objRow[conFieldTab4RootFld.UpdDate] = oRow[conFieldTab4RootFld.UpdDate].ToString().Trim(); //修改日期
objRow[conFieldTab4RootFld.Memo] = oRow[conFieldTab4RootFld.Memo].ToString().Trim(); //说明
 objDS.Tables[clsFieldTab4RootFldEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFieldTab4RootFldEN._CurrTabName);
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
 /// <param name = "objFieldTab4RootFldEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
 objFieldTab4RootFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4RootFldEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFieldTab4RootFldEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
strSQL = "Select * from FieldTab4RootFld where mId = " + ""+ objFieldTab4RootFldEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFieldTab4RootFldEN._CurrTabName);
if (objDS.Tables[clsFieldTab4RootFldEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objFieldTab4RootFldEN.mId+"");
return false;
}
objRow = objDS.Tables[clsFieldTab4RootFldEN._CurrTabName].Rows[0];
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.TabId))
 {
objRow[conFieldTab4RootFld.TabId] = objFieldTab4RootFldEN.TabId; //表ID
 }
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.FldId))
 {
objRow[conFieldTab4RootFld.FldId] = objFieldTab4RootFldEN.FldId; //字段Id
 }
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.IsPrimaryKey))
 {
objRow[conFieldTab4RootFld.IsPrimaryKey] = objFieldTab4RootFldEN.IsPrimaryKey; //是否主键
 }
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.IsRootFld))
 {
objRow[conFieldTab4RootFld.IsRootFld] = objFieldTab4RootFldEN.IsRootFld; //是否根字段
 }
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.Root4TabId))
 {
objRow[conFieldTab4RootFld.Root4TabId] = objFieldTab4RootFldEN.Root4TabId; //主根表Id
 }
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.RootFldId))
 {
objRow[conFieldTab4RootFld.RootFldId] = objFieldTab4RootFldEN.RootFldId; //根字段Id
 }
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.RootTabId))
 {
objRow[conFieldTab4RootFld.RootTabId] = objFieldTab4RootFldEN.RootTabId; //根表Id
 }
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.PrjId))
 {
objRow[conFieldTab4RootFld.PrjId] = objFieldTab4RootFldEN.PrjId; //工程Id
 }
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.UpdUser))
 {
objRow[conFieldTab4RootFld.UpdUser] = objFieldTab4RootFldEN.UpdUser; //修改者
 }
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.UpdDate))
 {
objRow[conFieldTab4RootFld.UpdDate] = objFieldTab4RootFldEN.UpdDate; //修改日期
 }
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.Memo))
 {
objRow[conFieldTab4RootFld.Memo] = objFieldTab4RootFldEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsFieldTab4RootFldEN._CurrTabName);
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
 /// <param name = "objFieldTab4RootFldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
 objFieldTab4RootFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4RootFldEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFieldTab4RootFldEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FieldTab4RootFld Set ");
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.TabId))
 {
 if (objFieldTab4RootFldEN.TabId !=  null)
 {
 var strTabId = objFieldTab4RootFldEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conFieldTab4RootFld.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4RootFld.TabId); //表ID
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.FldId))
 {
 if (objFieldTab4RootFldEN.FldId !=  null)
 {
 var strFldId = objFieldTab4RootFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conFieldTab4RootFld.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4RootFld.FldId); //字段Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.IsPrimaryKey))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTab4RootFldEN.IsPrimaryKey == true?"1":"0", conFieldTab4RootFld.IsPrimaryKey); //是否主键
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.IsRootFld))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTab4RootFldEN.IsRootFld == true?"1":"0", conFieldTab4RootFld.IsRootFld); //是否根字段
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.Root4TabId))
 {
 if (objFieldTab4RootFldEN.Root4TabId !=  null)
 {
 var strRoot4TabId = objFieldTab4RootFldEN.Root4TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoot4TabId, conFieldTab4RootFld.Root4TabId); //主根表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4RootFld.Root4TabId); //主根表Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.RootFldId))
 {
 if (objFieldTab4RootFldEN.RootFldId !=  null)
 {
 var strRootFldId = objFieldTab4RootFldEN.RootFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRootFldId, conFieldTab4RootFld.RootFldId); //根字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4RootFld.RootFldId); //根字段Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.RootTabId))
 {
 if (objFieldTab4RootFldEN.RootTabId !=  null)
 {
 var strRootTabId = objFieldTab4RootFldEN.RootTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRootTabId, conFieldTab4RootFld.RootTabId); //根表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4RootFld.RootTabId); //根表Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.PrjId))
 {
 if (objFieldTab4RootFldEN.PrjId !=  null)
 {
 var strPrjId = objFieldTab4RootFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conFieldTab4RootFld.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4RootFld.PrjId); //工程Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.UpdUser))
 {
 if (objFieldTab4RootFldEN.UpdUser !=  null)
 {
 var strUpdUser = objFieldTab4RootFldEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFieldTab4RootFld.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4RootFld.UpdUser); //修改者
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.UpdDate))
 {
 if (objFieldTab4RootFldEN.UpdDate !=  null)
 {
 var strUpdDate = objFieldTab4RootFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFieldTab4RootFld.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4RootFld.UpdDate); //修改日期
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.Memo))
 {
 if (objFieldTab4RootFldEN.Memo !=  null)
 {
 var strMemo = objFieldTab4RootFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFieldTab4RootFld.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4RootFld.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objFieldTab4RootFldEN.mId); 
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
 /// <param name = "objFieldTab4RootFldEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strCondition)
{
 objFieldTab4RootFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4RootFldEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFieldTab4RootFldEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FieldTab4RootFld Set ");
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.TabId))
 {
 if (objFieldTab4RootFldEN.TabId !=  null)
 {
 var strTabId = objFieldTab4RootFldEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.FldId))
 {
 if (objFieldTab4RootFldEN.FldId !=  null)
 {
 var strFldId = objFieldTab4RootFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.IsPrimaryKey))
 {
 sbSQL.AppendFormat(" IsPrimaryKey = '{0}',", objFieldTab4RootFldEN.IsPrimaryKey == true?"1":"0"); //是否主键
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.IsRootFld))
 {
 sbSQL.AppendFormat(" IsRootFld = '{0}',", objFieldTab4RootFldEN.IsRootFld == true?"1":"0"); //是否根字段
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.Root4TabId))
 {
 if (objFieldTab4RootFldEN.Root4TabId !=  null)
 {
 var strRoot4TabId = objFieldTab4RootFldEN.Root4TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Root4TabId = '{0}',", strRoot4TabId); //主根表Id
 }
 else
 {
 sbSQL.Append(" Root4TabId = null,"); //主根表Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.RootFldId))
 {
 if (objFieldTab4RootFldEN.RootFldId !=  null)
 {
 var strRootFldId = objFieldTab4RootFldEN.RootFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RootFldId = '{0}',", strRootFldId); //根字段Id
 }
 else
 {
 sbSQL.Append(" RootFldId = null,"); //根字段Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.RootTabId))
 {
 if (objFieldTab4RootFldEN.RootTabId !=  null)
 {
 var strRootTabId = objFieldTab4RootFldEN.RootTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RootTabId = '{0}',", strRootTabId); //根表Id
 }
 else
 {
 sbSQL.Append(" RootTabId = null,"); //根表Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.PrjId))
 {
 if (objFieldTab4RootFldEN.PrjId !=  null)
 {
 var strPrjId = objFieldTab4RootFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.UpdUser))
 {
 if (objFieldTab4RootFldEN.UpdUser !=  null)
 {
 var strUpdUser = objFieldTab4RootFldEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.UpdDate))
 {
 if (objFieldTab4RootFldEN.UpdDate !=  null)
 {
 var strUpdDate = objFieldTab4RootFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.Memo))
 {
 if (objFieldTab4RootFldEN.Memo !=  null)
 {
 var strMemo = objFieldTab4RootFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFieldTab4RootFldEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFieldTab4RootFldEN objFieldTab4RootFldEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFieldTab4RootFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4RootFldEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFieldTab4RootFldEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FieldTab4RootFld Set ");
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.TabId))
 {
 if (objFieldTab4RootFldEN.TabId !=  null)
 {
 var strTabId = objFieldTab4RootFldEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.FldId))
 {
 if (objFieldTab4RootFldEN.FldId !=  null)
 {
 var strFldId = objFieldTab4RootFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.IsPrimaryKey))
 {
 sbSQL.AppendFormat(" IsPrimaryKey = '{0}',", objFieldTab4RootFldEN.IsPrimaryKey == true?"1":"0"); //是否主键
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.IsRootFld))
 {
 sbSQL.AppendFormat(" IsRootFld = '{0}',", objFieldTab4RootFldEN.IsRootFld == true?"1":"0"); //是否根字段
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.Root4TabId))
 {
 if (objFieldTab4RootFldEN.Root4TabId !=  null)
 {
 var strRoot4TabId = objFieldTab4RootFldEN.Root4TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Root4TabId = '{0}',", strRoot4TabId); //主根表Id
 }
 else
 {
 sbSQL.Append(" Root4TabId = null,"); //主根表Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.RootFldId))
 {
 if (objFieldTab4RootFldEN.RootFldId !=  null)
 {
 var strRootFldId = objFieldTab4RootFldEN.RootFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RootFldId = '{0}',", strRootFldId); //根字段Id
 }
 else
 {
 sbSQL.Append(" RootFldId = null,"); //根字段Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.RootTabId))
 {
 if (objFieldTab4RootFldEN.RootTabId !=  null)
 {
 var strRootTabId = objFieldTab4RootFldEN.RootTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RootTabId = '{0}',", strRootTabId); //根表Id
 }
 else
 {
 sbSQL.Append(" RootTabId = null,"); //根表Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.PrjId))
 {
 if (objFieldTab4RootFldEN.PrjId !=  null)
 {
 var strPrjId = objFieldTab4RootFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.UpdUser))
 {
 if (objFieldTab4RootFldEN.UpdUser !=  null)
 {
 var strUpdUser = objFieldTab4RootFldEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.UpdDate))
 {
 if (objFieldTab4RootFldEN.UpdDate !=  null)
 {
 var strUpdDate = objFieldTab4RootFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.Memo))
 {
 if (objFieldTab4RootFldEN.Memo !=  null)
 {
 var strMemo = objFieldTab4RootFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFieldTab4RootFldEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFieldTab4RootFldEN objFieldTab4RootFldEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFieldTab4RootFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFieldTab4RootFldEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFieldTab4RootFldEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FieldTab4RootFld Set ");
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.TabId))
 {
 if (objFieldTab4RootFldEN.TabId !=  null)
 {
 var strTabId = objFieldTab4RootFldEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conFieldTab4RootFld.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4RootFld.TabId); //表ID
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.FldId))
 {
 if (objFieldTab4RootFldEN.FldId !=  null)
 {
 var strFldId = objFieldTab4RootFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conFieldTab4RootFld.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4RootFld.FldId); //字段Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.IsPrimaryKey))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTab4RootFldEN.IsPrimaryKey == true?"1":"0", conFieldTab4RootFld.IsPrimaryKey); //是否主键
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.IsRootFld))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFieldTab4RootFldEN.IsRootFld == true?"1":"0", conFieldTab4RootFld.IsRootFld); //是否根字段
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.Root4TabId))
 {
 if (objFieldTab4RootFldEN.Root4TabId !=  null)
 {
 var strRoot4TabId = objFieldTab4RootFldEN.Root4TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoot4TabId, conFieldTab4RootFld.Root4TabId); //主根表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4RootFld.Root4TabId); //主根表Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.RootFldId))
 {
 if (objFieldTab4RootFldEN.RootFldId !=  null)
 {
 var strRootFldId = objFieldTab4RootFldEN.RootFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRootFldId, conFieldTab4RootFld.RootFldId); //根字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4RootFld.RootFldId); //根字段Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.RootTabId))
 {
 if (objFieldTab4RootFldEN.RootTabId !=  null)
 {
 var strRootTabId = objFieldTab4RootFldEN.RootTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRootTabId, conFieldTab4RootFld.RootTabId); //根表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4RootFld.RootTabId); //根表Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.PrjId))
 {
 if (objFieldTab4RootFldEN.PrjId !=  null)
 {
 var strPrjId = objFieldTab4RootFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conFieldTab4RootFld.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4RootFld.PrjId); //工程Id
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.UpdUser))
 {
 if (objFieldTab4RootFldEN.UpdUser !=  null)
 {
 var strUpdUser = objFieldTab4RootFldEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFieldTab4RootFld.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4RootFld.UpdUser); //修改者
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.UpdDate))
 {
 if (objFieldTab4RootFldEN.UpdDate !=  null)
 {
 var strUpdDate = objFieldTab4RootFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFieldTab4RootFld.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4RootFld.UpdDate); //修改日期
 }
 }
 
 if (objFieldTab4RootFldEN.IsUpdated(conFieldTab4RootFld.Memo))
 {
 if (objFieldTab4RootFldEN.Memo !=  null)
 {
 var strMemo = objFieldTab4RootFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFieldTab4RootFld.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFieldTab4RootFld.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objFieldTab4RootFldEN.mId); 
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
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("FieldTab4RootFld_Delete", values);
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
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
//删除FieldTab4RootFld本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FieldTab4RootFld where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFieldTab4RootFld(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
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
//删除FieldTab4RootFld本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FieldTab4RootFld where mId in (" + strKeyList + ")";
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
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
//删除FieldTab4RootFld本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FieldTab4RootFld where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFieldTab4RootFld(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFieldTab4RootFldDA: DelFieldTab4RootFld)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FieldTab4RootFld where " + strCondition ;
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
public bool DelFieldTab4RootFldWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFieldTab4RootFldDA: DelFieldTab4RootFldWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FieldTab4RootFld where " + strCondition ;
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
 /// <param name = "objFieldTab4RootFldENS">源对象</param>
 /// <param name = "objFieldTab4RootFldENT">目标对象</param>
public void CopyTo(clsFieldTab4RootFldEN objFieldTab4RootFldENS, clsFieldTab4RootFldEN objFieldTab4RootFldENT)
{
objFieldTab4RootFldENT.mId = objFieldTab4RootFldENS.mId; //mId
objFieldTab4RootFldENT.TabId = objFieldTab4RootFldENS.TabId; //表ID
objFieldTab4RootFldENT.FldId = objFieldTab4RootFldENS.FldId; //字段Id
objFieldTab4RootFldENT.IsPrimaryKey = objFieldTab4RootFldENS.IsPrimaryKey; //是否主键
objFieldTab4RootFldENT.IsRootFld = objFieldTab4RootFldENS.IsRootFld; //是否根字段
objFieldTab4RootFldENT.Root4TabId = objFieldTab4RootFldENS.Root4TabId; //主根表Id
objFieldTab4RootFldENT.RootFldId = objFieldTab4RootFldENS.RootFldId; //根字段Id
objFieldTab4RootFldENT.RootTabId = objFieldTab4RootFldENS.RootTabId; //根表Id
objFieldTab4RootFldENT.PrjId = objFieldTab4RootFldENS.PrjId; //工程Id
objFieldTab4RootFldENT.UpdUser = objFieldTab4RootFldENS.UpdUser; //修改者
objFieldTab4RootFldENT.UpdDate = objFieldTab4RootFldENS.UpdDate; //修改日期
objFieldTab4RootFldENT.Memo = objFieldTab4RootFldENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFieldTab4RootFldEN.TabId, conFieldTab4RootFld.TabId);
clsCheckSql.CheckFieldNotNull(objFieldTab4RootFldEN.FldId, conFieldTab4RootFld.FldId);
clsCheckSql.CheckFieldNotNull(objFieldTab4RootFldEN.IsPrimaryKey, conFieldTab4RootFld.IsPrimaryKey);
clsCheckSql.CheckFieldNotNull(objFieldTab4RootFldEN.PrjId, conFieldTab4RootFld.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.TabId, 8, conFieldTab4RootFld.TabId);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.FldId, 8, conFieldTab4RootFld.FldId);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.Root4TabId, 8, conFieldTab4RootFld.Root4TabId);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.RootFldId, 8, conFieldTab4RootFld.RootFldId);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.RootTabId, 8, conFieldTab4RootFld.RootTabId);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.PrjId, 4, conFieldTab4RootFld.PrjId);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.UpdUser, 20, conFieldTab4RootFld.UpdUser);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.UpdDate, 20, conFieldTab4RootFld.UpdDate);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.Memo, 1000, conFieldTab4RootFld.Memo);
//检查字段外键固定长度
 objFieldTab4RootFldEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.TabId, 8, conFieldTab4RootFld.TabId);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.FldId, 8, conFieldTab4RootFld.FldId);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.Root4TabId, 8, conFieldTab4RootFld.Root4TabId);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.RootFldId, 8, conFieldTab4RootFld.RootFldId);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.RootTabId, 8, conFieldTab4RootFld.RootTabId);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.PrjId, 4, conFieldTab4RootFld.PrjId);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.UpdUser, 20, conFieldTab4RootFld.UpdUser);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.UpdDate, 20, conFieldTab4RootFld.UpdDate);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.Memo, 1000, conFieldTab4RootFld.Memo);
//检查外键字段长度
 objFieldTab4RootFldEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.TabId, 8, conFieldTab4RootFld.TabId);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.FldId, 8, conFieldTab4RootFld.FldId);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.Root4TabId, 8, conFieldTab4RootFld.Root4TabId);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.RootFldId, 8, conFieldTab4RootFld.RootFldId);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.RootTabId, 8, conFieldTab4RootFld.RootTabId);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.PrjId, 4, conFieldTab4RootFld.PrjId);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.UpdUser, 20, conFieldTab4RootFld.UpdUser);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.UpdDate, 20, conFieldTab4RootFld.UpdDate);
clsCheckSql.CheckFieldLen(objFieldTab4RootFldEN.Memo, 1000, conFieldTab4RootFld.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFieldTab4RootFldEN.TabId, conFieldTab4RootFld.TabId);
clsCheckSql.CheckSqlInjection4Field(objFieldTab4RootFldEN.FldId, conFieldTab4RootFld.FldId);
clsCheckSql.CheckSqlInjection4Field(objFieldTab4RootFldEN.Root4TabId, conFieldTab4RootFld.Root4TabId);
clsCheckSql.CheckSqlInjection4Field(objFieldTab4RootFldEN.RootFldId, conFieldTab4RootFld.RootFldId);
clsCheckSql.CheckSqlInjection4Field(objFieldTab4RootFldEN.RootTabId, conFieldTab4RootFld.RootTabId);
clsCheckSql.CheckSqlInjection4Field(objFieldTab4RootFldEN.PrjId, conFieldTab4RootFld.PrjId);
clsCheckSql.CheckSqlInjection4Field(objFieldTab4RootFldEN.UpdUser, conFieldTab4RootFld.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objFieldTab4RootFldEN.UpdDate, conFieldTab4RootFld.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objFieldTab4RootFldEN.Memo, conFieldTab4RootFld.Memo);
//检查外键字段长度
 objFieldTab4RootFldEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--FieldTab4RootFld(工程字段4RootFld),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFieldTab4RootFldEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsFieldTab4RootFldEN objFieldTab4RootFldEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objFieldTab4RootFldEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objFieldTab4RootFldEN.FldId);
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
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
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
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
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
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFieldTab4RootFldEN._CurrTabName);
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
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFieldTab4RootFldEN._CurrTabName, strCondition);
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
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
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
 objSQL = clsFieldTab4RootFldDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}