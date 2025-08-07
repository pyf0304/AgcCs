
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFeatureFieldTypeRelaDA
 表名:FeatureFieldTypeRela(00050457)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:11
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
 /// 功能字段类型关系(FeatureFieldTypeRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFeatureFieldTypeRelaDA : clsCommBase4DA
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
 return clsFeatureFieldTypeRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFeatureFieldTypeRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFeatureFieldTypeRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFeatureFieldTypeRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFeatureFieldTypeRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFeatureFieldTypeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from FeatureFieldTypeRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FeatureFieldTypeRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFeatureFieldTypeRelaDA: GetDataTable_FeatureFieldTypeRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from FeatureFieldTypeRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFeatureFieldTypeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFeatureFieldTypeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from FeatureFieldTypeRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFeatureFieldTypeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFeatureFieldTypeRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FeatureFieldTypeRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FeatureFieldTypeRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFeatureFieldTypeRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FeatureFieldTypeRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFeatureFieldTypeRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FeatureFieldTypeRela.* " + 
$"from FeatureFieldTypeRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FeatureFieldTypeRela.mId not in " + 
$"(Select top {intTop_In} FeatureFieldTypeRela.mId from FeatureFieldTypeRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FeatureFieldTypeRela where {1} and mId not in (Select top {2} mId from FeatureFieldTypeRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FeatureFieldTypeRela where {1} and mId not in (Select top {3} mId from FeatureFieldTypeRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFeatureFieldTypeRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FeatureFieldTypeRela.* " + 
$"from FeatureFieldTypeRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FeatureFieldTypeRela.mId not in " + 
$"(Select top {intTop_In} FeatureFieldTypeRela.mId from FeatureFieldTypeRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FeatureFieldTypeRela where {1} and mId not in (Select top {2} mId from FeatureFieldTypeRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FeatureFieldTypeRela where {1} and mId not in (Select top {3} mId from FeatureFieldTypeRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsFeatureFieldTypeRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFeatureFieldTypeRelaDA:GetObjLst)", objException.Message));
}
List<clsFeatureFieldTypeRelaEN> arrObjLst = new List<clsFeatureFieldTypeRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from FeatureFieldTypeRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN = new clsFeatureFieldTypeRelaEN();
try
{
objFeatureFieldTypeRelaEN.mId = TransNullToInt(objRow[conFeatureFieldTypeRela.mId].ToString().Trim()); //mId
objFeatureFieldTypeRelaEN.FeatureId = objRow[conFeatureFieldTypeRela.FeatureId].ToString().Trim(); //功能Id
objFeatureFieldTypeRelaEN.FieldTypeId = objRow[conFeatureFieldTypeRela.FieldTypeId].ToString().Trim(); //字段类型Id
objFeatureFieldTypeRelaEN.OrderNum = objRow[conFeatureFieldTypeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureFieldTypeRela.OrderNum].ToString().Trim()); //序号
objFeatureFieldTypeRelaEN.UpdDate = objRow[conFeatureFieldTypeRela.UpdDate] == DBNull.Value ? null : objRow[conFeatureFieldTypeRela.UpdDate].ToString().Trim(); //修改日期
objFeatureFieldTypeRelaEN.UpdUser = objRow[conFeatureFieldTypeRela.UpdUser].ToString().Trim(); //修改者
objFeatureFieldTypeRelaEN.Memo = objRow[conFeatureFieldTypeRela.Memo] == DBNull.Value ? null : objRow[conFeatureFieldTypeRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFeatureFieldTypeRelaDA: GetObjLst)", objException.Message));
}
objFeatureFieldTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFeatureFieldTypeRelaEN);
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
public List<clsFeatureFieldTypeRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFeatureFieldTypeRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsFeatureFieldTypeRelaEN> arrObjLst = new List<clsFeatureFieldTypeRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN = new clsFeatureFieldTypeRelaEN();
try
{
objFeatureFieldTypeRelaEN.mId = TransNullToInt(objRow[conFeatureFieldTypeRela.mId].ToString().Trim()); //mId
objFeatureFieldTypeRelaEN.FeatureId = objRow[conFeatureFieldTypeRela.FeatureId].ToString().Trim(); //功能Id
objFeatureFieldTypeRelaEN.FieldTypeId = objRow[conFeatureFieldTypeRela.FieldTypeId].ToString().Trim(); //字段类型Id
objFeatureFieldTypeRelaEN.OrderNum = objRow[conFeatureFieldTypeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureFieldTypeRela.OrderNum].ToString().Trim()); //序号
objFeatureFieldTypeRelaEN.UpdDate = objRow[conFeatureFieldTypeRela.UpdDate] == DBNull.Value ? null : objRow[conFeatureFieldTypeRela.UpdDate].ToString().Trim(); //修改日期
objFeatureFieldTypeRelaEN.UpdUser = objRow[conFeatureFieldTypeRela.UpdUser].ToString().Trim(); //修改者
objFeatureFieldTypeRelaEN.Memo = objRow[conFeatureFieldTypeRela.Memo] == DBNull.Value ? null : objRow[conFeatureFieldTypeRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFeatureFieldTypeRelaDA: GetObjLst)", objException.Message));
}
objFeatureFieldTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFeatureFieldTypeRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFeatureFieldTypeRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFeatureFieldTypeRela(ref clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from FeatureFieldTypeRela where mId = " + ""+ objFeatureFieldTypeRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFeatureFieldTypeRelaEN.mId = TransNullToInt(objDT.Rows[0][conFeatureFieldTypeRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objFeatureFieldTypeRelaEN.FeatureId = objDT.Rows[0][conFeatureFieldTypeRela.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objFeatureFieldTypeRelaEN.FieldTypeId = objDT.Rows[0][conFeatureFieldTypeRela.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objFeatureFieldTypeRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][conFeatureFieldTypeRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objFeatureFieldTypeRelaEN.UpdDate = objDT.Rows[0][conFeatureFieldTypeRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFeatureFieldTypeRelaEN.UpdUser = objDT.Rows[0][conFeatureFieldTypeRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFeatureFieldTypeRelaEN.Memo = objDT.Rows[0][conFeatureFieldTypeRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFeatureFieldTypeRelaDA: GetFeatureFieldTypeRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsFeatureFieldTypeRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from FeatureFieldTypeRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN = new clsFeatureFieldTypeRelaEN();
try
{
 objFeatureFieldTypeRelaEN.mId = Int32.Parse(objRow[conFeatureFieldTypeRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objFeatureFieldTypeRelaEN.FeatureId = objRow[conFeatureFieldTypeRela.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objFeatureFieldTypeRelaEN.FieldTypeId = objRow[conFeatureFieldTypeRela.FieldTypeId].ToString().Trim(); //字段类型Id(字段类型:char,字段长度:2,是否可空:True)
 objFeatureFieldTypeRelaEN.OrderNum = objRow[conFeatureFieldTypeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFeatureFieldTypeRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objFeatureFieldTypeRelaEN.UpdDate = objRow[conFeatureFieldTypeRela.UpdDate] == DBNull.Value ? null : objRow[conFeatureFieldTypeRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFeatureFieldTypeRelaEN.UpdUser = objRow[conFeatureFieldTypeRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFeatureFieldTypeRelaEN.Memo = objRow[conFeatureFieldTypeRela.Memo] == DBNull.Value ? null : objRow[conFeatureFieldTypeRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFeatureFieldTypeRelaDA: GetObjBymId)", objException.Message));
}
return objFeatureFieldTypeRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFeatureFieldTypeRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFeatureFieldTypeRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from FeatureFieldTypeRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN = new clsFeatureFieldTypeRelaEN()
{
mId = TransNullToInt(objRow[conFeatureFieldTypeRela.mId].ToString().Trim()), //mId
FeatureId = objRow[conFeatureFieldTypeRela.FeatureId].ToString().Trim(), //功能Id
FieldTypeId = objRow[conFeatureFieldTypeRela.FieldTypeId].ToString().Trim(), //字段类型Id
OrderNum = objRow[conFeatureFieldTypeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureFieldTypeRela.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[conFeatureFieldTypeRela.UpdDate] == DBNull.Value ? null : objRow[conFeatureFieldTypeRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conFeatureFieldTypeRela.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conFeatureFieldTypeRela.Memo] == DBNull.Value ? null : objRow[conFeatureFieldTypeRela.Memo].ToString().Trim() //说明
};
objFeatureFieldTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFeatureFieldTypeRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFeatureFieldTypeRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFeatureFieldTypeRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN = new clsFeatureFieldTypeRelaEN();
try
{
objFeatureFieldTypeRelaEN.mId = TransNullToInt(objRow[conFeatureFieldTypeRela.mId].ToString().Trim()); //mId
objFeatureFieldTypeRelaEN.FeatureId = objRow[conFeatureFieldTypeRela.FeatureId].ToString().Trim(); //功能Id
objFeatureFieldTypeRelaEN.FieldTypeId = objRow[conFeatureFieldTypeRela.FieldTypeId].ToString().Trim(); //字段类型Id
objFeatureFieldTypeRelaEN.OrderNum = objRow[conFeatureFieldTypeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureFieldTypeRela.OrderNum].ToString().Trim()); //序号
objFeatureFieldTypeRelaEN.UpdDate = objRow[conFeatureFieldTypeRela.UpdDate] == DBNull.Value ? null : objRow[conFeatureFieldTypeRela.UpdDate].ToString().Trim(); //修改日期
objFeatureFieldTypeRelaEN.UpdUser = objRow[conFeatureFieldTypeRela.UpdUser].ToString().Trim(); //修改者
objFeatureFieldTypeRelaEN.Memo = objRow[conFeatureFieldTypeRela.Memo] == DBNull.Value ? null : objRow[conFeatureFieldTypeRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFeatureFieldTypeRelaDA: GetObjByDataRowFeatureFieldTypeRela)", objException.Message));
}
objFeatureFieldTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFeatureFieldTypeRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFeatureFieldTypeRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN = new clsFeatureFieldTypeRelaEN();
try
{
objFeatureFieldTypeRelaEN.mId = TransNullToInt(objRow[conFeatureFieldTypeRela.mId].ToString().Trim()); //mId
objFeatureFieldTypeRelaEN.FeatureId = objRow[conFeatureFieldTypeRela.FeatureId].ToString().Trim(); //功能Id
objFeatureFieldTypeRelaEN.FieldTypeId = objRow[conFeatureFieldTypeRela.FieldTypeId].ToString().Trim(); //字段类型Id
objFeatureFieldTypeRelaEN.OrderNum = objRow[conFeatureFieldTypeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFeatureFieldTypeRela.OrderNum].ToString().Trim()); //序号
objFeatureFieldTypeRelaEN.UpdDate = objRow[conFeatureFieldTypeRela.UpdDate] == DBNull.Value ? null : objRow[conFeatureFieldTypeRela.UpdDate].ToString().Trim(); //修改日期
objFeatureFieldTypeRelaEN.UpdUser = objRow[conFeatureFieldTypeRela.UpdUser].ToString().Trim(); //修改者
objFeatureFieldTypeRelaEN.Memo = objRow[conFeatureFieldTypeRela.Memo] == DBNull.Value ? null : objRow[conFeatureFieldTypeRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFeatureFieldTypeRelaDA: GetObjByDataRow)", objException.Message));
}
objFeatureFieldTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFeatureFieldTypeRelaEN;
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
objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFeatureFieldTypeRelaEN._CurrTabName, conFeatureFieldTypeRela.mId, 8, "");
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
objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFeatureFieldTypeRelaEN._CurrTabName, conFeatureFieldTypeRela.mId, 8, strPrefix);
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
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from FeatureFieldTypeRela where " + strCondition;
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
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from FeatureFieldTypeRela where " + strCondition;
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
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FeatureFieldTypeRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFeatureFieldTypeRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FeatureFieldTypeRela", strCondition))
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
objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FeatureFieldTypeRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN)
 {
 objFeatureFieldTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureFieldTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFeatureFieldTypeRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from FeatureFieldTypeRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FeatureFieldTypeRela");
objRow = objDS.Tables["FeatureFieldTypeRela"].NewRow();
objRow[conFeatureFieldTypeRela.FeatureId] = objFeatureFieldTypeRelaEN.FeatureId; //功能Id
objRow[conFeatureFieldTypeRela.FieldTypeId] = objFeatureFieldTypeRelaEN.FieldTypeId; //字段类型Id
objRow[conFeatureFieldTypeRela.OrderNum] = objFeatureFieldTypeRelaEN.OrderNum; //序号
 if (objFeatureFieldTypeRelaEN.UpdDate !=  "")
 {
objRow[conFeatureFieldTypeRela.UpdDate] = objFeatureFieldTypeRelaEN.UpdDate; //修改日期
 }
objRow[conFeatureFieldTypeRela.UpdUser] = objFeatureFieldTypeRelaEN.UpdUser; //修改者
 if (objFeatureFieldTypeRelaEN.Memo !=  "")
 {
objRow[conFeatureFieldTypeRela.Memo] = objFeatureFieldTypeRelaEN.Memo; //说明
 }
objDS.Tables[clsFeatureFieldTypeRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFeatureFieldTypeRelaEN._CurrTabName);
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
 /// <param name = "objFeatureFieldTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN)
{
 objFeatureFieldTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureFieldTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFeatureFieldTypeRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFeatureFieldTypeRelaEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.FeatureId);
 var strFeatureId = objFeatureFieldTypeRelaEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objFeatureFieldTypeRelaEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.FieldTypeId);
 var strFieldTypeId = objFeatureFieldTypeRelaEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 if (objFeatureFieldTypeRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.OrderNum);
 arrValueListForInsert.Add(objFeatureFieldTypeRelaEN.OrderNum.ToString());
 }
 
 if (objFeatureFieldTypeRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.UpdDate);
 var strUpdDate = objFeatureFieldTypeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFeatureFieldTypeRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.UpdUser);
 var strUpdUser = objFeatureFieldTypeRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFeatureFieldTypeRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.Memo);
 var strMemo = objFeatureFieldTypeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FeatureFieldTypeRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFeatureFieldTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN)
{
 objFeatureFieldTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureFieldTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFeatureFieldTypeRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFeatureFieldTypeRelaEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.FeatureId);
 var strFeatureId = objFeatureFieldTypeRelaEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objFeatureFieldTypeRelaEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.FieldTypeId);
 var strFieldTypeId = objFeatureFieldTypeRelaEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 if (objFeatureFieldTypeRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.OrderNum);
 arrValueListForInsert.Add(objFeatureFieldTypeRelaEN.OrderNum.ToString());
 }
 
 if (objFeatureFieldTypeRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.UpdDate);
 var strUpdDate = objFeatureFieldTypeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFeatureFieldTypeRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.UpdUser);
 var strUpdUser = objFeatureFieldTypeRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFeatureFieldTypeRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.Memo);
 var strMemo = objFeatureFieldTypeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FeatureFieldTypeRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFeatureFieldTypeRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFeatureFieldTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureFieldTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFeatureFieldTypeRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFeatureFieldTypeRelaEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.FeatureId);
 var strFeatureId = objFeatureFieldTypeRelaEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objFeatureFieldTypeRelaEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.FieldTypeId);
 var strFieldTypeId = objFeatureFieldTypeRelaEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 if (objFeatureFieldTypeRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.OrderNum);
 arrValueListForInsert.Add(objFeatureFieldTypeRelaEN.OrderNum.ToString());
 }
 
 if (objFeatureFieldTypeRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.UpdDate);
 var strUpdDate = objFeatureFieldTypeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFeatureFieldTypeRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.UpdUser);
 var strUpdUser = objFeatureFieldTypeRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFeatureFieldTypeRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.Memo);
 var strMemo = objFeatureFieldTypeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FeatureFieldTypeRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFeatureFieldTypeRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFeatureFieldTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureFieldTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFeatureFieldTypeRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFeatureFieldTypeRelaEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.FeatureId);
 var strFeatureId = objFeatureFieldTypeRelaEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objFeatureFieldTypeRelaEN.FieldTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.FieldTypeId);
 var strFieldTypeId = objFeatureFieldTypeRelaEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldTypeId + "'");
 }
 
 if (objFeatureFieldTypeRelaEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.OrderNum);
 arrValueListForInsert.Add(objFeatureFieldTypeRelaEN.OrderNum.ToString());
 }
 
 if (objFeatureFieldTypeRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.UpdDate);
 var strUpdDate = objFeatureFieldTypeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFeatureFieldTypeRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.UpdUser);
 var strUpdUser = objFeatureFieldTypeRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFeatureFieldTypeRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFeatureFieldTypeRela.Memo);
 var strMemo = objFeatureFieldTypeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FeatureFieldTypeRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFeatureFieldTypeRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from FeatureFieldTypeRela where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FeatureFieldTypeRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conFeatureFieldTypeRela.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFeatureFieldTypeRelaEN._CurrTabName ].NewRow();
objRow[conFeatureFieldTypeRela.FeatureId] = oRow[conFeatureFieldTypeRela.FeatureId].ToString().Trim(); //功能Id
objRow[conFeatureFieldTypeRela.FieldTypeId] = oRow[conFeatureFieldTypeRela.FieldTypeId].ToString().Trim(); //字段类型Id
objRow[conFeatureFieldTypeRela.OrderNum] = oRow[conFeatureFieldTypeRela.OrderNum].ToString().Trim(); //序号
objRow[conFeatureFieldTypeRela.UpdDate] = oRow[conFeatureFieldTypeRela.UpdDate].ToString().Trim(); //修改日期
objRow[conFeatureFieldTypeRela.UpdUser] = oRow[conFeatureFieldTypeRela.UpdUser].ToString().Trim(); //修改者
objRow[conFeatureFieldTypeRela.Memo] = oRow[conFeatureFieldTypeRela.Memo].ToString().Trim(); //说明
 objDS.Tables[clsFeatureFieldTypeRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFeatureFieldTypeRelaEN._CurrTabName);
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
 /// <param name = "objFeatureFieldTypeRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN)
{
 objFeatureFieldTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureFieldTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFeatureFieldTypeRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from FeatureFieldTypeRela where mId = " + ""+ objFeatureFieldTypeRelaEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFeatureFieldTypeRelaEN._CurrTabName);
if (objDS.Tables[clsFeatureFieldTypeRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objFeatureFieldTypeRelaEN.mId+"");
return false;
}
objRow = objDS.Tables[clsFeatureFieldTypeRelaEN._CurrTabName].Rows[0];
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.FeatureId))
 {
objRow[conFeatureFieldTypeRela.FeatureId] = objFeatureFieldTypeRelaEN.FeatureId; //功能Id
 }
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.FieldTypeId))
 {
objRow[conFeatureFieldTypeRela.FieldTypeId] = objFeatureFieldTypeRelaEN.FieldTypeId; //字段类型Id
 }
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.OrderNum))
 {
objRow[conFeatureFieldTypeRela.OrderNum] = objFeatureFieldTypeRelaEN.OrderNum; //序号
 }
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.UpdDate))
 {
objRow[conFeatureFieldTypeRela.UpdDate] = objFeatureFieldTypeRelaEN.UpdDate; //修改日期
 }
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.UpdUser))
 {
objRow[conFeatureFieldTypeRela.UpdUser] = objFeatureFieldTypeRelaEN.UpdUser; //修改者
 }
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.Memo))
 {
objRow[conFeatureFieldTypeRela.Memo] = objFeatureFieldTypeRelaEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsFeatureFieldTypeRelaEN._CurrTabName);
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
 /// <param name = "objFeatureFieldTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN)
{
 objFeatureFieldTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureFieldTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFeatureFieldTypeRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FeatureFieldTypeRela Set ");
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.FeatureId))
 {
 if (objFeatureFieldTypeRelaEN.FeatureId !=  null)
 {
 var strFeatureId = objFeatureFieldTypeRelaEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureId, conFeatureFieldTypeRela.FeatureId); //功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureFieldTypeRela.FeatureId); //功能Id
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.FieldTypeId))
 {
 if (objFeatureFieldTypeRelaEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objFeatureFieldTypeRelaEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldTypeId, conFeatureFieldTypeRela.FieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureFieldTypeRela.FieldTypeId); //字段类型Id
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.OrderNum))
 {
 if (objFeatureFieldTypeRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFeatureFieldTypeRelaEN.OrderNum, conFeatureFieldTypeRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureFieldTypeRela.OrderNum); //序号
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.UpdDate))
 {
 if (objFeatureFieldTypeRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objFeatureFieldTypeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFeatureFieldTypeRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureFieldTypeRela.UpdDate); //修改日期
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.UpdUser))
 {
 if (objFeatureFieldTypeRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objFeatureFieldTypeRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFeatureFieldTypeRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureFieldTypeRela.UpdUser); //修改者
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.Memo))
 {
 if (objFeatureFieldTypeRelaEN.Memo !=  null)
 {
 var strMemo = objFeatureFieldTypeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFeatureFieldTypeRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureFieldTypeRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objFeatureFieldTypeRelaEN.mId); 
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
 /// <param name = "objFeatureFieldTypeRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN, string strCondition)
{
 objFeatureFieldTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureFieldTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFeatureFieldTypeRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FeatureFieldTypeRela Set ");
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.FeatureId))
 {
 if (objFeatureFieldTypeRelaEN.FeatureId !=  null)
 {
 var strFeatureId = objFeatureFieldTypeRelaEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureId = '{0}',", strFeatureId); //功能Id
 }
 else
 {
 sbSQL.Append(" FeatureId = null,"); //功能Id
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.FieldTypeId))
 {
 if (objFeatureFieldTypeRelaEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objFeatureFieldTypeRelaEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldTypeId = '{0}',", strFieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.Append(" FieldTypeId = null,"); //字段类型Id
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.OrderNum))
 {
 if (objFeatureFieldTypeRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFeatureFieldTypeRelaEN.OrderNum, conFeatureFieldTypeRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureFieldTypeRela.OrderNum); //序号
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.UpdDate))
 {
 if (objFeatureFieldTypeRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objFeatureFieldTypeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.UpdUser))
 {
 if (objFeatureFieldTypeRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objFeatureFieldTypeRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.Memo))
 {
 if (objFeatureFieldTypeRelaEN.Memo !=  null)
 {
 var strMemo = objFeatureFieldTypeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFeatureFieldTypeRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFeatureFieldTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureFieldTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFeatureFieldTypeRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FeatureFieldTypeRela Set ");
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.FeatureId))
 {
 if (objFeatureFieldTypeRelaEN.FeatureId !=  null)
 {
 var strFeatureId = objFeatureFieldTypeRelaEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureId = '{0}',", strFeatureId); //功能Id
 }
 else
 {
 sbSQL.Append(" FeatureId = null,"); //功能Id
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.FieldTypeId))
 {
 if (objFeatureFieldTypeRelaEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objFeatureFieldTypeRelaEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldTypeId = '{0}',", strFieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.Append(" FieldTypeId = null,"); //字段类型Id
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.OrderNum))
 {
 if (objFeatureFieldTypeRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFeatureFieldTypeRelaEN.OrderNum, conFeatureFieldTypeRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureFieldTypeRela.OrderNum); //序号
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.UpdDate))
 {
 if (objFeatureFieldTypeRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objFeatureFieldTypeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.UpdUser))
 {
 if (objFeatureFieldTypeRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objFeatureFieldTypeRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.Memo))
 {
 if (objFeatureFieldTypeRelaEN.Memo !=  null)
 {
 var strMemo = objFeatureFieldTypeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFeatureFieldTypeRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFeatureFieldTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFeatureFieldTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFeatureFieldTypeRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FeatureFieldTypeRela Set ");
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.FeatureId))
 {
 if (objFeatureFieldTypeRelaEN.FeatureId !=  null)
 {
 var strFeatureId = objFeatureFieldTypeRelaEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureId, conFeatureFieldTypeRela.FeatureId); //功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureFieldTypeRela.FeatureId); //功能Id
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.FieldTypeId))
 {
 if (objFeatureFieldTypeRelaEN.FieldTypeId !=  null)
 {
 var strFieldTypeId = objFeatureFieldTypeRelaEN.FieldTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldTypeId, conFeatureFieldTypeRela.FieldTypeId); //字段类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureFieldTypeRela.FieldTypeId); //字段类型Id
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.OrderNum))
 {
 if (objFeatureFieldTypeRelaEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFeatureFieldTypeRelaEN.OrderNum, conFeatureFieldTypeRela.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureFieldTypeRela.OrderNum); //序号
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.UpdDate))
 {
 if (objFeatureFieldTypeRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objFeatureFieldTypeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFeatureFieldTypeRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureFieldTypeRela.UpdDate); //修改日期
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.UpdUser))
 {
 if (objFeatureFieldTypeRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objFeatureFieldTypeRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFeatureFieldTypeRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureFieldTypeRela.UpdUser); //修改者
 }
 }
 
 if (objFeatureFieldTypeRelaEN.IsUpdated(conFeatureFieldTypeRela.Memo))
 {
 if (objFeatureFieldTypeRelaEN.Memo !=  null)
 {
 var strMemo = objFeatureFieldTypeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFeatureFieldTypeRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFeatureFieldTypeRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objFeatureFieldTypeRelaEN.mId); 
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
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("FeatureFieldTypeRela_Delete", values);
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
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
//删除FeatureFieldTypeRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FeatureFieldTypeRela where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFeatureFieldTypeRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
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
//删除FeatureFieldTypeRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FeatureFieldTypeRela where mId in (" + strKeyList + ")";
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
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
//删除FeatureFieldTypeRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FeatureFieldTypeRela where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFeatureFieldTypeRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFeatureFieldTypeRelaDA: DelFeatureFieldTypeRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FeatureFieldTypeRela where " + strCondition ;
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
public bool DelFeatureFieldTypeRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFeatureFieldTypeRelaDA: DelFeatureFieldTypeRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FeatureFieldTypeRela where " + strCondition ;
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
 /// <param name = "objFeatureFieldTypeRelaENS">源对象</param>
 /// <param name = "objFeatureFieldTypeRelaENT">目标对象</param>
public void CopyTo(clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaENS, clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaENT)
{
objFeatureFieldTypeRelaENT.mId = objFeatureFieldTypeRelaENS.mId; //mId
objFeatureFieldTypeRelaENT.FeatureId = objFeatureFieldTypeRelaENS.FeatureId; //功能Id
objFeatureFieldTypeRelaENT.FieldTypeId = objFeatureFieldTypeRelaENS.FieldTypeId; //字段类型Id
objFeatureFieldTypeRelaENT.OrderNum = objFeatureFieldTypeRelaENS.OrderNum; //序号
objFeatureFieldTypeRelaENT.UpdDate = objFeatureFieldTypeRelaENS.UpdDate; //修改日期
objFeatureFieldTypeRelaENT.UpdUser = objFeatureFieldTypeRelaENS.UpdUser; //修改者
objFeatureFieldTypeRelaENT.Memo = objFeatureFieldTypeRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFeatureFieldTypeRelaEN.FeatureId, conFeatureFieldTypeRela.FeatureId);
clsCheckSql.CheckFieldNotNull(objFeatureFieldTypeRelaEN.FieldTypeId, conFeatureFieldTypeRela.FieldTypeId);
clsCheckSql.CheckFieldNotNull(objFeatureFieldTypeRelaEN.UpdUser, conFeatureFieldTypeRela.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objFeatureFieldTypeRelaEN.FeatureId, 4, conFeatureFieldTypeRela.FeatureId);
clsCheckSql.CheckFieldLen(objFeatureFieldTypeRelaEN.FieldTypeId, 2, conFeatureFieldTypeRela.FieldTypeId);
clsCheckSql.CheckFieldLen(objFeatureFieldTypeRelaEN.UpdDate, 20, conFeatureFieldTypeRela.UpdDate);
clsCheckSql.CheckFieldLen(objFeatureFieldTypeRelaEN.UpdUser, 20, conFeatureFieldTypeRela.UpdUser);
clsCheckSql.CheckFieldLen(objFeatureFieldTypeRelaEN.Memo, 1000, conFeatureFieldTypeRela.Memo);
//检查字段外键固定长度
 objFeatureFieldTypeRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFeatureFieldTypeRelaEN.FeatureId, 4, conFeatureFieldTypeRela.FeatureId);
clsCheckSql.CheckFieldLen(objFeatureFieldTypeRelaEN.FieldTypeId, 2, conFeatureFieldTypeRela.FieldTypeId);
clsCheckSql.CheckFieldLen(objFeatureFieldTypeRelaEN.UpdDate, 20, conFeatureFieldTypeRela.UpdDate);
clsCheckSql.CheckFieldLen(objFeatureFieldTypeRelaEN.UpdUser, 20, conFeatureFieldTypeRela.UpdUser);
clsCheckSql.CheckFieldLen(objFeatureFieldTypeRelaEN.Memo, 1000, conFeatureFieldTypeRela.Memo);
//检查外键字段长度
 objFeatureFieldTypeRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFeatureFieldTypeRelaEN.FeatureId, 4, conFeatureFieldTypeRela.FeatureId);
clsCheckSql.CheckFieldLen(objFeatureFieldTypeRelaEN.FieldTypeId, 2, conFeatureFieldTypeRela.FieldTypeId);
clsCheckSql.CheckFieldLen(objFeatureFieldTypeRelaEN.UpdDate, 20, conFeatureFieldTypeRela.UpdDate);
clsCheckSql.CheckFieldLen(objFeatureFieldTypeRelaEN.UpdUser, 20, conFeatureFieldTypeRela.UpdUser);
clsCheckSql.CheckFieldLen(objFeatureFieldTypeRelaEN.Memo, 1000, conFeatureFieldTypeRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFeatureFieldTypeRelaEN.FeatureId, conFeatureFieldTypeRela.FeatureId);
clsCheckSql.CheckSqlInjection4Field(objFeatureFieldTypeRelaEN.FieldTypeId, conFeatureFieldTypeRela.FieldTypeId);
clsCheckSql.CheckSqlInjection4Field(objFeatureFieldTypeRelaEN.UpdDate, conFeatureFieldTypeRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objFeatureFieldTypeRelaEN.UpdUser, conFeatureFieldTypeRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objFeatureFieldTypeRelaEN.Memo, conFeatureFieldTypeRela.Memo);
//检查外键字段长度
 objFeatureFieldTypeRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--FeatureFieldTypeRela(功能字段类型关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFeatureFieldTypeRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsFeatureFieldTypeRelaEN objFeatureFieldTypeRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FieldTypeId = '{0}'", objFeatureFieldTypeRelaEN.FieldTypeId);
 sbCondition.AppendFormat(" and FeatureId = '{0}'", objFeatureFieldTypeRelaEN.FeatureId);
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
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
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
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
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
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFeatureFieldTypeRelaEN._CurrTabName);
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
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFeatureFieldTypeRelaEN._CurrTabName, strCondition);
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
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
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
 objSQL = clsFeatureFieldTypeRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}