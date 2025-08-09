
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjUserCharEncodingRelaDA
 表名:PrjUserCharEncodingRela(00050264)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:23
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
 /// 项目用户字符编码关系(PrjUserCharEncodingRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPrjUserCharEncodingRelaDA : clsCommBase4DA
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
 return clsPrjUserCharEncodingRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPrjUserCharEncodingRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjUserCharEncodingRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPrjUserCharEncodingRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPrjUserCharEncodingRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPrjUserCharEncodingRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
strSQL = "Select * from PrjUserCharEncodingRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PrjUserCharEncodingRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPrjUserCharEncodingRelaDA: GetDataTable_PrjUserCharEncodingRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
strSQL = "Select * from PrjUserCharEncodingRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPrjUserCharEncodingRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPrjUserCharEncodingRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
strSQL = "Select * from PrjUserCharEncodingRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPrjUserCharEncodingRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPrjUserCharEncodingRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjUserCharEncodingRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjUserCharEncodingRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPrjUserCharEncodingRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PrjUserCharEncodingRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPrjUserCharEncodingRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjUserCharEncodingRela.* " + 
$"from PrjUserCharEncodingRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjUserCharEncodingRela.mId not in " + 
$"(Select top {intTop_In} PrjUserCharEncodingRela.mId from PrjUserCharEncodingRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjUserCharEncodingRela where {1} and mId not in (Select top {2} mId from PrjUserCharEncodingRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjUserCharEncodingRela where {1} and mId not in (Select top {3} mId from PrjUserCharEncodingRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPrjUserCharEncodingRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjUserCharEncodingRela.* " + 
$"from PrjUserCharEncodingRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjUserCharEncodingRela.mId not in " + 
$"(Select top {intTop_In} PrjUserCharEncodingRela.mId from PrjUserCharEncodingRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjUserCharEncodingRela where {1} and mId not in (Select top {2} mId from PrjUserCharEncodingRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjUserCharEncodingRela where {1} and mId not in (Select top {3} mId from PrjUserCharEncodingRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPrjUserCharEncodingRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPrjUserCharEncodingRelaDA:GetObjLst)", objException.Message));
}
List<clsPrjUserCharEncodingRelaEN> arrObjLst = new List<clsPrjUserCharEncodingRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
strSQL = "Select * from PrjUserCharEncodingRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN = new clsPrjUserCharEncodingRelaEN();
try
{
objPrjUserCharEncodingRelaEN.mId = TransNullToInt(objRow[conPrjUserCharEncodingRela.mId].ToString().Trim()); //mId
objPrjUserCharEncodingRelaEN.PrjId = objRow[conPrjUserCharEncodingRela.PrjId].ToString().Trim(); //工程Id
objPrjUserCharEncodingRelaEN.UserId = objRow[conPrjUserCharEncodingRela.UserId] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.UserId].ToString().Trim(); //用户Id
objPrjUserCharEncodingRelaEN.CharEncodingId = objRow[conPrjUserCharEncodingRela.CharEncodingId].ToString().Trim(); //字符编码
objPrjUserCharEncodingRelaEN.UpdDate = objRow[conPrjUserCharEncodingRela.UpdDate] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.UpdDate].ToString().Trim(); //修改日期
objPrjUserCharEncodingRelaEN.UpdUserId = objRow[conPrjUserCharEncodingRela.UpdUserId] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.UpdUserId].ToString().Trim(); //修改用户Id
objPrjUserCharEncodingRelaEN.Memo = objRow[conPrjUserCharEncodingRela.Memo] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjUserCharEncodingRelaDA: GetObjLst)", objException.Message));
}
objPrjUserCharEncodingRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjUserCharEncodingRelaEN);
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
public List<clsPrjUserCharEncodingRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPrjUserCharEncodingRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsPrjUserCharEncodingRelaEN> arrObjLst = new List<clsPrjUserCharEncodingRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN = new clsPrjUserCharEncodingRelaEN();
try
{
objPrjUserCharEncodingRelaEN.mId = TransNullToInt(objRow[conPrjUserCharEncodingRela.mId].ToString().Trim()); //mId
objPrjUserCharEncodingRelaEN.PrjId = objRow[conPrjUserCharEncodingRela.PrjId].ToString().Trim(); //工程Id
objPrjUserCharEncodingRelaEN.UserId = objRow[conPrjUserCharEncodingRela.UserId] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.UserId].ToString().Trim(); //用户Id
objPrjUserCharEncodingRelaEN.CharEncodingId = objRow[conPrjUserCharEncodingRela.CharEncodingId].ToString().Trim(); //字符编码
objPrjUserCharEncodingRelaEN.UpdDate = objRow[conPrjUserCharEncodingRela.UpdDate] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.UpdDate].ToString().Trim(); //修改日期
objPrjUserCharEncodingRelaEN.UpdUserId = objRow[conPrjUserCharEncodingRela.UpdUserId] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.UpdUserId].ToString().Trim(); //修改用户Id
objPrjUserCharEncodingRelaEN.Memo = objRow[conPrjUserCharEncodingRela.Memo] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjUserCharEncodingRelaDA: GetObjLst)", objException.Message));
}
objPrjUserCharEncodingRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjUserCharEncodingRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPrjUserCharEncodingRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPrjUserCharEncodingRela(ref clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
strSQL = "Select * from PrjUserCharEncodingRela where mId = " + ""+ objPrjUserCharEncodingRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPrjUserCharEncodingRelaEN.mId = TransNullToInt(objDT.Rows[0][conPrjUserCharEncodingRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objPrjUserCharEncodingRelaEN.PrjId = objDT.Rows[0][conPrjUserCharEncodingRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjUserCharEncodingRelaEN.UserId = objDT.Rows[0][conPrjUserCharEncodingRela.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objPrjUserCharEncodingRelaEN.CharEncodingId = objDT.Rows[0][conPrjUserCharEncodingRela.CharEncodingId].ToString().Trim(); //字符编码(字段类型:varchar,字段长度:20,是否可空:False)
 objPrjUserCharEncodingRelaEN.UpdDate = objDT.Rows[0][conPrjUserCharEncodingRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjUserCharEncodingRelaEN.UpdUserId = objDT.Rows[0][conPrjUserCharEncodingRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjUserCharEncodingRelaEN.Memo = objDT.Rows[0][conPrjUserCharEncodingRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPrjUserCharEncodingRelaDA: GetPrjUserCharEncodingRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsPrjUserCharEncodingRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
strSQL = "Select * from PrjUserCharEncodingRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN = new clsPrjUserCharEncodingRelaEN();
try
{
 objPrjUserCharEncodingRelaEN.mId = Int32.Parse(objRow[conPrjUserCharEncodingRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objPrjUserCharEncodingRelaEN.PrjId = objRow[conPrjUserCharEncodingRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjUserCharEncodingRelaEN.UserId = objRow[conPrjUserCharEncodingRela.UserId] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objPrjUserCharEncodingRelaEN.CharEncodingId = objRow[conPrjUserCharEncodingRela.CharEncodingId].ToString().Trim(); //字符编码(字段类型:varchar,字段长度:20,是否可空:False)
 objPrjUserCharEncodingRelaEN.UpdDate = objRow[conPrjUserCharEncodingRela.UpdDate] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjUserCharEncodingRelaEN.UpdUserId = objRow[conPrjUserCharEncodingRela.UpdUserId] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjUserCharEncodingRelaEN.Memo = objRow[conPrjUserCharEncodingRela.Memo] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPrjUserCharEncodingRelaDA: GetObjBymId)", objException.Message));
}
return objPrjUserCharEncodingRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPrjUserCharEncodingRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPrjUserCharEncodingRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
strSQL = "Select * from PrjUserCharEncodingRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN = new clsPrjUserCharEncodingRelaEN()
{
mId = TransNullToInt(objRow[conPrjUserCharEncodingRela.mId].ToString().Trim()), //mId
PrjId = objRow[conPrjUserCharEncodingRela.PrjId].ToString().Trim(), //工程Id
UserId = objRow[conPrjUserCharEncodingRela.UserId] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.UserId].ToString().Trim(), //用户Id
CharEncodingId = objRow[conPrjUserCharEncodingRela.CharEncodingId].ToString().Trim(), //字符编码
UpdDate = objRow[conPrjUserCharEncodingRela.UpdDate] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conPrjUserCharEncodingRela.UpdUserId] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conPrjUserCharEncodingRela.Memo] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.Memo].ToString().Trim() //说明
};
objPrjUserCharEncodingRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjUserCharEncodingRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPrjUserCharEncodingRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPrjUserCharEncodingRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN = new clsPrjUserCharEncodingRelaEN();
try
{
objPrjUserCharEncodingRelaEN.mId = TransNullToInt(objRow[conPrjUserCharEncodingRela.mId].ToString().Trim()); //mId
objPrjUserCharEncodingRelaEN.PrjId = objRow[conPrjUserCharEncodingRela.PrjId].ToString().Trim(); //工程Id
objPrjUserCharEncodingRelaEN.UserId = objRow[conPrjUserCharEncodingRela.UserId] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.UserId].ToString().Trim(); //用户Id
objPrjUserCharEncodingRelaEN.CharEncodingId = objRow[conPrjUserCharEncodingRela.CharEncodingId].ToString().Trim(); //字符编码
objPrjUserCharEncodingRelaEN.UpdDate = objRow[conPrjUserCharEncodingRela.UpdDate] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.UpdDate].ToString().Trim(); //修改日期
objPrjUserCharEncodingRelaEN.UpdUserId = objRow[conPrjUserCharEncodingRela.UpdUserId] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.UpdUserId].ToString().Trim(); //修改用户Id
objPrjUserCharEncodingRelaEN.Memo = objRow[conPrjUserCharEncodingRela.Memo] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPrjUserCharEncodingRelaDA: GetObjByDataRowPrjUserCharEncodingRela)", objException.Message));
}
objPrjUserCharEncodingRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjUserCharEncodingRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPrjUserCharEncodingRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN = new clsPrjUserCharEncodingRelaEN();
try
{
objPrjUserCharEncodingRelaEN.mId = TransNullToInt(objRow[conPrjUserCharEncodingRela.mId].ToString().Trim()); //mId
objPrjUserCharEncodingRelaEN.PrjId = objRow[conPrjUserCharEncodingRela.PrjId].ToString().Trim(); //工程Id
objPrjUserCharEncodingRelaEN.UserId = objRow[conPrjUserCharEncodingRela.UserId] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.UserId].ToString().Trim(); //用户Id
objPrjUserCharEncodingRelaEN.CharEncodingId = objRow[conPrjUserCharEncodingRela.CharEncodingId].ToString().Trim(); //字符编码
objPrjUserCharEncodingRelaEN.UpdDate = objRow[conPrjUserCharEncodingRela.UpdDate] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.UpdDate].ToString().Trim(); //修改日期
objPrjUserCharEncodingRelaEN.UpdUserId = objRow[conPrjUserCharEncodingRela.UpdUserId] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.UpdUserId].ToString().Trim(); //修改用户Id
objPrjUserCharEncodingRelaEN.Memo = objRow[conPrjUserCharEncodingRela.Memo] == DBNull.Value ? null : objRow[conPrjUserCharEncodingRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPrjUserCharEncodingRelaDA: GetObjByDataRow)", objException.Message));
}
objPrjUserCharEncodingRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjUserCharEncodingRelaEN;
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
objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjUserCharEncodingRelaEN._CurrTabName, conPrjUserCharEncodingRela.mId, 8, "");
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
objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjUserCharEncodingRelaEN._CurrTabName, conPrjUserCharEncodingRela.mId, 8, strPrefix);
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
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from PrjUserCharEncodingRela where " + strCondition;
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
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from PrjUserCharEncodingRela where " + strCondition;
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
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjUserCharEncodingRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPrjUserCharEncodingRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjUserCharEncodingRela", strCondition))
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
objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PrjUserCharEncodingRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN)
 {
 objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjUserCharEncodingRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjUserCharEncodingRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
strSQL = "Select * from PrjUserCharEncodingRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjUserCharEncodingRela");
objRow = objDS.Tables["PrjUserCharEncodingRela"].NewRow();
objRow[conPrjUserCharEncodingRela.PrjId] = objPrjUserCharEncodingRelaEN.PrjId; //工程Id
 if (objPrjUserCharEncodingRelaEN.UserId !=  "")
 {
objRow[conPrjUserCharEncodingRela.UserId] = objPrjUserCharEncodingRelaEN.UserId; //用户Id
 }
objRow[conPrjUserCharEncodingRela.CharEncodingId] = objPrjUserCharEncodingRelaEN.CharEncodingId; //字符编码
 if (objPrjUserCharEncodingRelaEN.UpdDate !=  "")
 {
objRow[conPrjUserCharEncodingRela.UpdDate] = objPrjUserCharEncodingRelaEN.UpdDate; //修改日期
 }
 if (objPrjUserCharEncodingRelaEN.UpdUserId !=  "")
 {
objRow[conPrjUserCharEncodingRela.UpdUserId] = objPrjUserCharEncodingRelaEN.UpdUserId; //修改用户Id
 }
 if (objPrjUserCharEncodingRelaEN.Memo !=  "")
 {
objRow[conPrjUserCharEncodingRela.Memo] = objPrjUserCharEncodingRelaEN.Memo; //说明
 }
objDS.Tables[clsPrjUserCharEncodingRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPrjUserCharEncodingRelaEN._CurrTabName);
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
 /// <param name = "objPrjUserCharEncodingRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN)
{
 objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjUserCharEncodingRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjUserCharEncodingRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPrjUserCharEncodingRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.PrjId);
 var strPrjId = objPrjUserCharEncodingRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.UserId);
 var strUserId = objPrjUserCharEncodingRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.CharEncodingId !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.CharEncodingId);
 var strCharEncodingId = objPrjUserCharEncodingRelaEN.CharEncodingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCharEncodingId + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.UpdDate);
 var strUpdDate = objPrjUserCharEncodingRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.UpdUserId);
 var strUpdUserId = objPrjUserCharEncodingRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.Memo);
 var strMemo = objPrjUserCharEncodingRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjUserCharEncodingRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPrjUserCharEncodingRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN)
{
 objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjUserCharEncodingRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjUserCharEncodingRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPrjUserCharEncodingRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.PrjId);
 var strPrjId = objPrjUserCharEncodingRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.UserId);
 var strUserId = objPrjUserCharEncodingRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.CharEncodingId !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.CharEncodingId);
 var strCharEncodingId = objPrjUserCharEncodingRelaEN.CharEncodingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCharEncodingId + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.UpdDate);
 var strUpdDate = objPrjUserCharEncodingRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.UpdUserId);
 var strUpdUserId = objPrjUserCharEncodingRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.Memo);
 var strMemo = objPrjUserCharEncodingRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjUserCharEncodingRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPrjUserCharEncodingRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjUserCharEncodingRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjUserCharEncodingRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPrjUserCharEncodingRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.PrjId);
 var strPrjId = objPrjUserCharEncodingRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.UserId);
 var strUserId = objPrjUserCharEncodingRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.CharEncodingId !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.CharEncodingId);
 var strCharEncodingId = objPrjUserCharEncodingRelaEN.CharEncodingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCharEncodingId + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.UpdDate);
 var strUpdDate = objPrjUserCharEncodingRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.UpdUserId);
 var strUpdUserId = objPrjUserCharEncodingRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.Memo);
 var strMemo = objPrjUserCharEncodingRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjUserCharEncodingRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPrjUserCharEncodingRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjUserCharEncodingRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjUserCharEncodingRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPrjUserCharEncodingRelaEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.PrjId);
 var strPrjId = objPrjUserCharEncodingRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.UserId);
 var strUserId = objPrjUserCharEncodingRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.CharEncodingId !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.CharEncodingId);
 var strCharEncodingId = objPrjUserCharEncodingRelaEN.CharEncodingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCharEncodingId + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.UpdDate);
 var strUpdDate = objPrjUserCharEncodingRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.UpdUserId);
 var strUpdUserId = objPrjUserCharEncodingRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objPrjUserCharEncodingRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjUserCharEncodingRela.Memo);
 var strMemo = objPrjUserCharEncodingRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjUserCharEncodingRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPrjUserCharEncodingRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
strSQL = "Select * from PrjUserCharEncodingRela where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjUserCharEncodingRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conPrjUserCharEncodingRela.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPrjUserCharEncodingRelaEN._CurrTabName ].NewRow();
objRow[conPrjUserCharEncodingRela.PrjId] = oRow[conPrjUserCharEncodingRela.PrjId].ToString().Trim(); //工程Id
objRow[conPrjUserCharEncodingRela.UserId] = oRow[conPrjUserCharEncodingRela.UserId].ToString().Trim(); //用户Id
objRow[conPrjUserCharEncodingRela.CharEncodingId] = oRow[conPrjUserCharEncodingRela.CharEncodingId].ToString().Trim(); //字符编码
objRow[conPrjUserCharEncodingRela.UpdDate] = oRow[conPrjUserCharEncodingRela.UpdDate].ToString().Trim(); //修改日期
objRow[conPrjUserCharEncodingRela.UpdUserId] = oRow[conPrjUserCharEncodingRela.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conPrjUserCharEncodingRela.Memo] = oRow[conPrjUserCharEncodingRela.Memo].ToString().Trim(); //说明
 objDS.Tables[clsPrjUserCharEncodingRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPrjUserCharEncodingRelaEN._CurrTabName);
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
 /// <param name = "objPrjUserCharEncodingRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN)
{
 objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjUserCharEncodingRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjUserCharEncodingRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
strSQL = "Select * from PrjUserCharEncodingRela where mId = " + ""+ objPrjUserCharEncodingRelaEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPrjUserCharEncodingRelaEN._CurrTabName);
if (objDS.Tables[clsPrjUserCharEncodingRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objPrjUserCharEncodingRelaEN.mId+"");
return false;
}
objRow = objDS.Tables[clsPrjUserCharEncodingRelaEN._CurrTabName].Rows[0];
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.PrjId))
 {
objRow[conPrjUserCharEncodingRela.PrjId] = objPrjUserCharEncodingRelaEN.PrjId; //工程Id
 }
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.UserId))
 {
objRow[conPrjUserCharEncodingRela.UserId] = objPrjUserCharEncodingRelaEN.UserId; //用户Id
 }
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.CharEncodingId))
 {
objRow[conPrjUserCharEncodingRela.CharEncodingId] = objPrjUserCharEncodingRelaEN.CharEncodingId; //字符编码
 }
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.UpdDate))
 {
objRow[conPrjUserCharEncodingRela.UpdDate] = objPrjUserCharEncodingRelaEN.UpdDate; //修改日期
 }
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.UpdUserId))
 {
objRow[conPrjUserCharEncodingRela.UpdUserId] = objPrjUserCharEncodingRelaEN.UpdUserId; //修改用户Id
 }
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.Memo))
 {
objRow[conPrjUserCharEncodingRela.Memo] = objPrjUserCharEncodingRelaEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsPrjUserCharEncodingRelaEN._CurrTabName);
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
 /// <param name = "objPrjUserCharEncodingRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN)
{
 objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjUserCharEncodingRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjUserCharEncodingRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PrjUserCharEncodingRela Set ");
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.PrjId))
 {
 if (objPrjUserCharEncodingRelaEN.PrjId !=  null)
 {
 var strPrjId = objPrjUserCharEncodingRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conPrjUserCharEncodingRela.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjUserCharEncodingRela.PrjId); //工程Id
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.UserId))
 {
 if (objPrjUserCharEncodingRelaEN.UserId !=  null)
 {
 var strUserId = objPrjUserCharEncodingRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conPrjUserCharEncodingRela.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjUserCharEncodingRela.UserId); //用户Id
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.CharEncodingId))
 {
 if (objPrjUserCharEncodingRelaEN.CharEncodingId !=  null)
 {
 var strCharEncodingId = objPrjUserCharEncodingRelaEN.CharEncodingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCharEncodingId, conPrjUserCharEncodingRela.CharEncodingId); //字符编码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjUserCharEncodingRela.CharEncodingId); //字符编码
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.UpdDate))
 {
 if (objPrjUserCharEncodingRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjUserCharEncodingRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPrjUserCharEncodingRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjUserCharEncodingRela.UpdDate); //修改日期
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.UpdUserId))
 {
 if (objPrjUserCharEncodingRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objPrjUserCharEncodingRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conPrjUserCharEncodingRela.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjUserCharEncodingRela.UpdUserId); //修改用户Id
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.Memo))
 {
 if (objPrjUserCharEncodingRelaEN.Memo !=  null)
 {
 var strMemo = objPrjUserCharEncodingRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjUserCharEncodingRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjUserCharEncodingRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objPrjUserCharEncodingRelaEN.mId); 
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
 /// <param name = "objPrjUserCharEncodingRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN, string strCondition)
{
 objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjUserCharEncodingRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjUserCharEncodingRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjUserCharEncodingRela Set ");
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.PrjId))
 {
 if (objPrjUserCharEncodingRelaEN.PrjId !=  null)
 {
 var strPrjId = objPrjUserCharEncodingRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.UserId))
 {
 if (objPrjUserCharEncodingRelaEN.UserId !=  null)
 {
 var strUserId = objPrjUserCharEncodingRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.CharEncodingId))
 {
 if (objPrjUserCharEncodingRelaEN.CharEncodingId !=  null)
 {
 var strCharEncodingId = objPrjUserCharEncodingRelaEN.CharEncodingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CharEncodingId = '{0}',", strCharEncodingId); //字符编码
 }
 else
 {
 sbSQL.Append(" CharEncodingId = null,"); //字符编码
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.UpdDate))
 {
 if (objPrjUserCharEncodingRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjUserCharEncodingRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.UpdUserId))
 {
 if (objPrjUserCharEncodingRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objPrjUserCharEncodingRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.Memo))
 {
 if (objPrjUserCharEncodingRelaEN.Memo !=  null)
 {
 var strMemo = objPrjUserCharEncodingRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPrjUserCharEncodingRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjUserCharEncodingRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjUserCharEncodingRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjUserCharEncodingRela Set ");
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.PrjId))
 {
 if (objPrjUserCharEncodingRelaEN.PrjId !=  null)
 {
 var strPrjId = objPrjUserCharEncodingRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.UserId))
 {
 if (objPrjUserCharEncodingRelaEN.UserId !=  null)
 {
 var strUserId = objPrjUserCharEncodingRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.CharEncodingId))
 {
 if (objPrjUserCharEncodingRelaEN.CharEncodingId !=  null)
 {
 var strCharEncodingId = objPrjUserCharEncodingRelaEN.CharEncodingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CharEncodingId = '{0}',", strCharEncodingId); //字符编码
 }
 else
 {
 sbSQL.Append(" CharEncodingId = null,"); //字符编码
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.UpdDate))
 {
 if (objPrjUserCharEncodingRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjUserCharEncodingRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.UpdUserId))
 {
 if (objPrjUserCharEncodingRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objPrjUserCharEncodingRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.Memo))
 {
 if (objPrjUserCharEncodingRelaEN.Memo !=  null)
 {
 var strMemo = objPrjUserCharEncodingRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPrjUserCharEncodingRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPrjUserCharEncodingRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjUserCharEncodingRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjUserCharEncodingRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjUserCharEncodingRela Set ");
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.PrjId))
 {
 if (objPrjUserCharEncodingRelaEN.PrjId !=  null)
 {
 var strPrjId = objPrjUserCharEncodingRelaEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conPrjUserCharEncodingRela.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjUserCharEncodingRela.PrjId); //工程Id
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.UserId))
 {
 if (objPrjUserCharEncodingRelaEN.UserId !=  null)
 {
 var strUserId = objPrjUserCharEncodingRelaEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conPrjUserCharEncodingRela.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjUserCharEncodingRela.UserId); //用户Id
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.CharEncodingId))
 {
 if (objPrjUserCharEncodingRelaEN.CharEncodingId !=  null)
 {
 var strCharEncodingId = objPrjUserCharEncodingRelaEN.CharEncodingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCharEncodingId, conPrjUserCharEncodingRela.CharEncodingId); //字符编码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjUserCharEncodingRela.CharEncodingId); //字符编码
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.UpdDate))
 {
 if (objPrjUserCharEncodingRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjUserCharEncodingRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPrjUserCharEncodingRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjUserCharEncodingRela.UpdDate); //修改日期
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.UpdUserId))
 {
 if (objPrjUserCharEncodingRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objPrjUserCharEncodingRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conPrjUserCharEncodingRela.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjUserCharEncodingRela.UpdUserId); //修改用户Id
 }
 }
 
 if (objPrjUserCharEncodingRelaEN.IsUpdated(conPrjUserCharEncodingRela.Memo))
 {
 if (objPrjUserCharEncodingRelaEN.Memo !=  null)
 {
 var strMemo = objPrjUserCharEncodingRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjUserCharEncodingRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjUserCharEncodingRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objPrjUserCharEncodingRelaEN.mId); 
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
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("PrjUserCharEncodingRela_Delete", values);
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
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
//删除PrjUserCharEncodingRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjUserCharEncodingRela where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPrjUserCharEncodingRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
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
//删除PrjUserCharEncodingRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjUserCharEncodingRela where mId in (" + strKeyList + ")";
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
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
//删除PrjUserCharEncodingRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjUserCharEncodingRela where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPrjUserCharEncodingRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPrjUserCharEncodingRelaDA: DelPrjUserCharEncodingRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjUserCharEncodingRela where " + strCondition ;
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
public bool DelPrjUserCharEncodingRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPrjUserCharEncodingRelaDA: DelPrjUserCharEncodingRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjUserCharEncodingRela where " + strCondition ;
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
 /// <param name = "objPrjUserCharEncodingRelaENS">源对象</param>
 /// <param name = "objPrjUserCharEncodingRelaENT">目标对象</param>
public void CopyTo(clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaENS, clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaENT)
{
objPrjUserCharEncodingRelaENT.mId = objPrjUserCharEncodingRelaENS.mId; //mId
objPrjUserCharEncodingRelaENT.PrjId = objPrjUserCharEncodingRelaENS.PrjId; //工程Id
objPrjUserCharEncodingRelaENT.UserId = objPrjUserCharEncodingRelaENS.UserId; //用户Id
objPrjUserCharEncodingRelaENT.CharEncodingId = objPrjUserCharEncodingRelaENS.CharEncodingId; //字符编码
objPrjUserCharEncodingRelaENT.UpdDate = objPrjUserCharEncodingRelaENS.UpdDate; //修改日期
objPrjUserCharEncodingRelaENT.UpdUserId = objPrjUserCharEncodingRelaENS.UpdUserId; //修改用户Id
objPrjUserCharEncodingRelaENT.Memo = objPrjUserCharEncodingRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPrjUserCharEncodingRelaEN.PrjId, conPrjUserCharEncodingRela.PrjId);
clsCheckSql.CheckFieldNotNull(objPrjUserCharEncodingRelaEN.CharEncodingId, conPrjUserCharEncodingRela.CharEncodingId);
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjUserCharEncodingRelaEN.PrjId, 4, conPrjUserCharEncodingRela.PrjId);
clsCheckSql.CheckFieldLen(objPrjUserCharEncodingRelaEN.UserId, 18, conPrjUserCharEncodingRela.UserId);
clsCheckSql.CheckFieldLen(objPrjUserCharEncodingRelaEN.CharEncodingId, 20, conPrjUserCharEncodingRela.CharEncodingId);
clsCheckSql.CheckFieldLen(objPrjUserCharEncodingRelaEN.UpdDate, 20, conPrjUserCharEncodingRela.UpdDate);
clsCheckSql.CheckFieldLen(objPrjUserCharEncodingRelaEN.UpdUserId, 20, conPrjUserCharEncodingRela.UpdUserId);
clsCheckSql.CheckFieldLen(objPrjUserCharEncodingRelaEN.Memo, 1000, conPrjUserCharEncodingRela.Memo);
//检查字段外键固定长度
 objPrjUserCharEncodingRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjUserCharEncodingRelaEN.PrjId, 4, conPrjUserCharEncodingRela.PrjId);
clsCheckSql.CheckFieldLen(objPrjUserCharEncodingRelaEN.UserId, 18, conPrjUserCharEncodingRela.UserId);
clsCheckSql.CheckFieldLen(objPrjUserCharEncodingRelaEN.CharEncodingId, 20, conPrjUserCharEncodingRela.CharEncodingId);
clsCheckSql.CheckFieldLen(objPrjUserCharEncodingRelaEN.UpdDate, 20, conPrjUserCharEncodingRela.UpdDate);
clsCheckSql.CheckFieldLen(objPrjUserCharEncodingRelaEN.UpdUserId, 20, conPrjUserCharEncodingRela.UpdUserId);
clsCheckSql.CheckFieldLen(objPrjUserCharEncodingRelaEN.Memo, 1000, conPrjUserCharEncodingRela.Memo);
//检查外键字段长度
 objPrjUserCharEncodingRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjUserCharEncodingRelaEN.PrjId, 4, conPrjUserCharEncodingRela.PrjId);
clsCheckSql.CheckFieldLen(objPrjUserCharEncodingRelaEN.UserId, 18, conPrjUserCharEncodingRela.UserId);
clsCheckSql.CheckFieldLen(objPrjUserCharEncodingRelaEN.CharEncodingId, 20, conPrjUserCharEncodingRela.CharEncodingId);
clsCheckSql.CheckFieldLen(objPrjUserCharEncodingRelaEN.UpdDate, 20, conPrjUserCharEncodingRela.UpdDate);
clsCheckSql.CheckFieldLen(objPrjUserCharEncodingRelaEN.UpdUserId, 20, conPrjUserCharEncodingRela.UpdUserId);
clsCheckSql.CheckFieldLen(objPrjUserCharEncodingRelaEN.Memo, 1000, conPrjUserCharEncodingRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPrjUserCharEncodingRelaEN.PrjId, conPrjUserCharEncodingRela.PrjId);
clsCheckSql.CheckSqlInjection4Field(objPrjUserCharEncodingRelaEN.UserId, conPrjUserCharEncodingRela.UserId);
clsCheckSql.CheckSqlInjection4Field(objPrjUserCharEncodingRelaEN.CharEncodingId, conPrjUserCharEncodingRela.CharEncodingId);
clsCheckSql.CheckSqlInjection4Field(objPrjUserCharEncodingRelaEN.UpdDate, conPrjUserCharEncodingRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objPrjUserCharEncodingRelaEN.UpdUserId, conPrjUserCharEncodingRela.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objPrjUserCharEncodingRelaEN.Memo, conPrjUserCharEncodingRela.Memo);
//检查外键字段长度
 objPrjUserCharEncodingRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--PrjUserCharEncodingRela(项目用户字符编码关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjUserCharEncodingRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsPrjUserCharEncodingRelaEN objPrjUserCharEncodingRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjUserCharEncodingRelaEN.PrjId);
 if (objPrjUserCharEncodingRelaEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null");
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objPrjUserCharEncodingRelaEN.UserId);
}
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
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
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
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
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
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjUserCharEncodingRelaEN._CurrTabName);
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
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjUserCharEncodingRelaEN._CurrTabName, strCondition);
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
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
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
 objSQL = clsPrjUserCharEncodingRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}