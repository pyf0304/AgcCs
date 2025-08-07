
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAppCodeTypeRelaDA
 表名:AppCodeTypeRela(00050418)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:31:24
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 应用程序代码类型关系(AppCodeTypeRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsAppCodeTypeRelaDA : clsCommBase4DA
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
 return clsAppCodeTypeRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsAppCodeTypeRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsAppCodeTypeRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsAppCodeTypeRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsAppCodeTypeRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsAppCodeTypeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from AppCodeTypeRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_AppCodeTypeRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsAppCodeTypeRelaDA: GetDataTable_AppCodeTypeRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from AppCodeTypeRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsAppCodeTypeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsAppCodeTypeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from AppCodeTypeRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsAppCodeTypeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsAppCodeTypeRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from AppCodeTypeRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from AppCodeTypeRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsAppCodeTypeRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from AppCodeTypeRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsAppCodeTypeRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} AppCodeTypeRela.* " + 
$"from AppCodeTypeRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and AppCodeTypeRela.mId not in " + 
$"(Select top {intTop_In} AppCodeTypeRela.mId from AppCodeTypeRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from AppCodeTypeRela where {1} and mId not in (Select top {2} mId from AppCodeTypeRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from AppCodeTypeRela where {1} and mId not in (Select top {3} mId from AppCodeTypeRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsAppCodeTypeRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} AppCodeTypeRela.* " + 
$"from AppCodeTypeRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and AppCodeTypeRela.mId not in " + 
$"(Select top {intTop_In} AppCodeTypeRela.mId from AppCodeTypeRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from AppCodeTypeRela where {1} and mId not in (Select top {2} mId from AppCodeTypeRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from AppCodeTypeRela where {1} and mId not in (Select top {3} mId from AppCodeTypeRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsAppCodeTypeRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsAppCodeTypeRelaDA:GetObjLst)", objException.Message));
}
List<clsAppCodeTypeRelaEN> arrObjLst = new List<clsAppCodeTypeRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from AppCodeTypeRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN();
try
{
objAppCodeTypeRelaEN.mId = TransNullToInt(objRow[conAppCodeTypeRela.mId].ToString().Trim()); //mId
objAppCodeTypeRelaEN.ApplicationTypeId = TransNullToInt(objRow[conAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objAppCodeTypeRelaEN.CodeTypeId = objRow[conAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objAppCodeTypeRelaEN.ViewTypeCode = objRow[conAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objAppCodeTypeRelaEN.TabMainTypeId = objRow[conAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[conAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objAppCodeTypeRelaEN.IsVisible = TransNullToBool(objRow[conAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objAppCodeTypeRelaEN.IsInGroupGeneCode = TransNullToBool(objRow[conAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objAppCodeTypeRelaEN.OrderNum = TransNullToInt(objRow[conAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objAppCodeTypeRelaEN.UpdDate = objRow[conAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objAppCodeTypeRelaEN.UpdUser = objRow[conAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objAppCodeTypeRelaEN.Memo = objRow[conAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[conAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsAppCodeTypeRelaDA: GetObjLst)", objException.Message));
}
objAppCodeTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objAppCodeTypeRelaEN);
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
public List<clsAppCodeTypeRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsAppCodeTypeRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsAppCodeTypeRelaEN> arrObjLst = new List<clsAppCodeTypeRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN();
try
{
objAppCodeTypeRelaEN.mId = TransNullToInt(objRow[conAppCodeTypeRela.mId].ToString().Trim()); //mId
objAppCodeTypeRelaEN.ApplicationTypeId = TransNullToInt(objRow[conAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objAppCodeTypeRelaEN.CodeTypeId = objRow[conAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objAppCodeTypeRelaEN.ViewTypeCode = objRow[conAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objAppCodeTypeRelaEN.TabMainTypeId = objRow[conAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[conAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objAppCodeTypeRelaEN.IsVisible = TransNullToBool(objRow[conAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objAppCodeTypeRelaEN.IsInGroupGeneCode = TransNullToBool(objRow[conAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objAppCodeTypeRelaEN.OrderNum = TransNullToInt(objRow[conAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objAppCodeTypeRelaEN.UpdDate = objRow[conAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objAppCodeTypeRelaEN.UpdUser = objRow[conAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objAppCodeTypeRelaEN.Memo = objRow[conAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[conAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsAppCodeTypeRelaDA: GetObjLst)", objException.Message));
}
objAppCodeTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objAppCodeTypeRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetAppCodeTypeRela(ref clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from AppCodeTypeRela where mId = " + ""+ objAppCodeTypeRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objAppCodeTypeRelaEN.mId = TransNullToInt(objDT.Rows[0][conAppCodeTypeRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objAppCodeTypeRelaEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][conAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objAppCodeTypeRelaEN.CodeTypeId = objDT.Rows[0][conAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objAppCodeTypeRelaEN.ViewTypeCode = TransNullToInt(objDT.Rows[0][conAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码(字段类型:int,字段长度:4,是否可空:False)
 objAppCodeTypeRelaEN.TabMainTypeId = objDT.Rows[0][conAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id(字段类型:char,字段长度:4,是否可空:True)
 objAppCodeTypeRelaEN.IsVisible = TransNullToBool(objDT.Rows[0][conAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objAppCodeTypeRelaEN.IsInGroupGeneCode = TransNullToBool(objDT.Rows[0][conAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objAppCodeTypeRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][conAppCodeTypeRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objAppCodeTypeRelaEN.UpdDate = objDT.Rows[0][conAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objAppCodeTypeRelaEN.UpdUser = objDT.Rows[0][conAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objAppCodeTypeRelaEN.Memo = objDT.Rows[0][conAppCodeTypeRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsAppCodeTypeRelaDA: GetAppCodeTypeRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsAppCodeTypeRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from AppCodeTypeRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN();
try
{
 objAppCodeTypeRelaEN.mId = Int32.Parse(objRow[conAppCodeTypeRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objAppCodeTypeRelaEN.ApplicationTypeId = Int32.Parse(objRow[conAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objAppCodeTypeRelaEN.CodeTypeId = objRow[conAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objAppCodeTypeRelaEN.ViewTypeCode = objRow[conAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码(字段类型:int,字段长度:4,是否可空:False)
 objAppCodeTypeRelaEN.TabMainTypeId = objRow[conAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[conAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id(字段类型:char,字段长度:4,是否可空:True)
 objAppCodeTypeRelaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objAppCodeTypeRelaEN.IsInGroupGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objAppCodeTypeRelaEN.OrderNum = Int32.Parse(objRow[conAppCodeTypeRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objAppCodeTypeRelaEN.UpdDate = objRow[conAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objAppCodeTypeRelaEN.UpdUser = objRow[conAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objAppCodeTypeRelaEN.Memo = objRow[conAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[conAppCodeTypeRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsAppCodeTypeRelaDA: GetObjBymId)", objException.Message));
}
return objAppCodeTypeRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsAppCodeTypeRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsAppCodeTypeRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from AppCodeTypeRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN()
{
mId = TransNullToInt(objRow[conAppCodeTypeRela.mId].ToString().Trim()), //mId
ApplicationTypeId = TransNullToInt(objRow[conAppCodeTypeRela.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
CodeTypeId = objRow[conAppCodeTypeRela.CodeTypeId].ToString().Trim(), //代码类型Id
ViewTypeCode = objRow[conAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conAppCodeTypeRela.ViewTypeCode].ToString().Trim()), //界面类型码
TabMainTypeId = objRow[conAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[conAppCodeTypeRela.TabMainTypeId].ToString().Trim(), //表主类型Id
IsVisible = TransNullToBool(objRow[conAppCodeTypeRela.IsVisible].ToString().Trim()), //是否显示
IsInGroupGeneCode = TransNullToBool(objRow[conAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()), //是否参与组生成代码
OrderNum = TransNullToInt(objRow[conAppCodeTypeRela.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[conAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[conAppCodeTypeRela.Memo].ToString().Trim() //说明
};
objAppCodeTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAppCodeTypeRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsAppCodeTypeRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsAppCodeTypeRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN();
try
{
objAppCodeTypeRelaEN.mId = TransNullToInt(objRow[conAppCodeTypeRela.mId].ToString().Trim()); //mId
objAppCodeTypeRelaEN.ApplicationTypeId = TransNullToInt(objRow[conAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objAppCodeTypeRelaEN.CodeTypeId = objRow[conAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objAppCodeTypeRelaEN.ViewTypeCode = objRow[conAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objAppCodeTypeRelaEN.TabMainTypeId = objRow[conAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[conAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objAppCodeTypeRelaEN.IsVisible = TransNullToBool(objRow[conAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objAppCodeTypeRelaEN.IsInGroupGeneCode = TransNullToBool(objRow[conAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objAppCodeTypeRelaEN.OrderNum = TransNullToInt(objRow[conAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objAppCodeTypeRelaEN.UpdDate = objRow[conAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objAppCodeTypeRelaEN.UpdUser = objRow[conAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objAppCodeTypeRelaEN.Memo = objRow[conAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[conAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsAppCodeTypeRelaDA: GetObjByDataRowAppCodeTypeRela)", objException.Message));
}
objAppCodeTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAppCodeTypeRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsAppCodeTypeRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = new clsAppCodeTypeRelaEN();
try
{
objAppCodeTypeRelaEN.mId = TransNullToInt(objRow[conAppCodeTypeRela.mId].ToString().Trim()); //mId
objAppCodeTypeRelaEN.ApplicationTypeId = TransNullToInt(objRow[conAppCodeTypeRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objAppCodeTypeRelaEN.CodeTypeId = objRow[conAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objAppCodeTypeRelaEN.ViewTypeCode = objRow[conAppCodeTypeRela.ViewTypeCode] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conAppCodeTypeRela.ViewTypeCode].ToString().Trim()); //界面类型码
objAppCodeTypeRelaEN.TabMainTypeId = objRow[conAppCodeTypeRela.TabMainTypeId] == DBNull.Value ? null : objRow[conAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objAppCodeTypeRelaEN.IsVisible = TransNullToBool(objRow[conAppCodeTypeRela.IsVisible].ToString().Trim()); //是否显示
objAppCodeTypeRelaEN.IsInGroupGeneCode = TransNullToBool(objRow[conAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim()); //是否参与组生成代码
objAppCodeTypeRelaEN.OrderNum = TransNullToInt(objRow[conAppCodeTypeRela.OrderNum].ToString().Trim()); //序号
objAppCodeTypeRelaEN.UpdDate = objRow[conAppCodeTypeRela.UpdDate] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objAppCodeTypeRelaEN.UpdUser = objRow[conAppCodeTypeRela.UpdUser] == DBNull.Value ? null : objRow[conAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objAppCodeTypeRelaEN.Memo = objRow[conAppCodeTypeRela.Memo] == DBNull.Value ? null : objRow[conAppCodeTypeRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsAppCodeTypeRelaDA: GetObjByDataRow)", objException.Message));
}
objAppCodeTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAppCodeTypeRelaEN;
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
objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsAppCodeTypeRelaEN._CurrTabName, conAppCodeTypeRela.mId, 8, "");
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
objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsAppCodeTypeRelaEN._CurrTabName, conAppCodeTypeRela.mId, 8, strPrefix);
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
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from AppCodeTypeRela where " + strCondition;
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
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from AppCodeTypeRela where " + strCondition;
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
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("AppCodeTypeRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsAppCodeTypeRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("AppCodeTypeRela", strCondition))
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
objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("AppCodeTypeRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
 {
 objAppCodeTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppCodeTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAppCodeTypeRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from AppCodeTypeRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "AppCodeTypeRela");
objRow = objDS.Tables["AppCodeTypeRela"].NewRow();
objRow[conAppCodeTypeRela.ApplicationTypeId] = objAppCodeTypeRelaEN.ApplicationTypeId; //应用程序类型ID
objRow[conAppCodeTypeRela.CodeTypeId] = objAppCodeTypeRelaEN.CodeTypeId; //代码类型Id
objRow[conAppCodeTypeRela.ViewTypeCode] = objAppCodeTypeRelaEN.ViewTypeCode; //界面类型码
 if (objAppCodeTypeRelaEN.TabMainTypeId !=  "")
 {
objRow[conAppCodeTypeRela.TabMainTypeId] = objAppCodeTypeRelaEN.TabMainTypeId; //表主类型Id
 }
objRow[conAppCodeTypeRela.IsVisible] = objAppCodeTypeRelaEN.IsVisible; //是否显示
objRow[conAppCodeTypeRela.IsInGroupGeneCode] = objAppCodeTypeRelaEN.IsInGroupGeneCode; //是否参与组生成代码
objRow[conAppCodeTypeRela.OrderNum] = objAppCodeTypeRelaEN.OrderNum; //序号
 if (objAppCodeTypeRelaEN.UpdDate !=  "")
 {
objRow[conAppCodeTypeRela.UpdDate] = objAppCodeTypeRelaEN.UpdDate; //修改日期
 }
 if (objAppCodeTypeRelaEN.UpdUser !=  "")
 {
objRow[conAppCodeTypeRela.UpdUser] = objAppCodeTypeRelaEN.UpdUser; //修改者
 }
 if (objAppCodeTypeRelaEN.Memo !=  "")
 {
objRow[conAppCodeTypeRela.Memo] = objAppCodeTypeRelaEN.Memo; //说明
 }
objDS.Tables[clsAppCodeTypeRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsAppCodeTypeRelaEN._CurrTabName);
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
 /// <param name = "objAppCodeTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
 objAppCodeTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppCodeTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAppCodeTypeRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conAppCodeTypeRela.ApplicationTypeId);
 arrValueListForInsert.Add(objAppCodeTypeRelaEN.ApplicationTypeId.ToString());
 
 if (objAppCodeTypeRelaEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.CodeTypeId);
 var strCodeTypeId = objAppCodeTypeRelaEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objAppCodeTypeRelaEN.ViewTypeCode !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.ViewTypeCode);
 arrValueListForInsert.Add(objAppCodeTypeRelaEN.ViewTypeCode.ToString());
 }
 
 if (objAppCodeTypeRelaEN.TabMainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.TabMainTypeId);
 var strTabMainTypeId = objAppCodeTypeRelaEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabMainTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conAppCodeTypeRela.IsVisible);
 arrValueListForInsert.Add("'" + (objAppCodeTypeRelaEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conAppCodeTypeRela.IsInGroupGeneCode);
 arrValueListForInsert.Add("'" + (objAppCodeTypeRelaEN.IsInGroupGeneCode  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conAppCodeTypeRela.OrderNum);
 arrValueListForInsert.Add(objAppCodeTypeRelaEN.OrderNum.ToString());
 
 if (objAppCodeTypeRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.UpdDate);
 var strUpdDate = objAppCodeTypeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAppCodeTypeRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.UpdUser);
 var strUpdUser = objAppCodeTypeRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objAppCodeTypeRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.Memo);
 var strMemo = objAppCodeTypeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AppCodeTypeRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
 objAppCodeTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppCodeTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAppCodeTypeRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conAppCodeTypeRela.ApplicationTypeId);
 arrValueListForInsert.Add(objAppCodeTypeRelaEN.ApplicationTypeId.ToString());
 
 if (objAppCodeTypeRelaEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.CodeTypeId);
 var strCodeTypeId = objAppCodeTypeRelaEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objAppCodeTypeRelaEN.ViewTypeCode !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.ViewTypeCode);
 arrValueListForInsert.Add(objAppCodeTypeRelaEN.ViewTypeCode.ToString());
 }
 
 if (objAppCodeTypeRelaEN.TabMainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.TabMainTypeId);
 var strTabMainTypeId = objAppCodeTypeRelaEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabMainTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conAppCodeTypeRela.IsVisible);
 arrValueListForInsert.Add("'" + (objAppCodeTypeRelaEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conAppCodeTypeRela.IsInGroupGeneCode);
 arrValueListForInsert.Add("'" + (objAppCodeTypeRelaEN.IsInGroupGeneCode  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conAppCodeTypeRela.OrderNum);
 arrValueListForInsert.Add(objAppCodeTypeRelaEN.OrderNum.ToString());
 
 if (objAppCodeTypeRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.UpdDate);
 var strUpdDate = objAppCodeTypeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAppCodeTypeRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.UpdUser);
 var strUpdUser = objAppCodeTypeRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objAppCodeTypeRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.Memo);
 var strMemo = objAppCodeTypeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AppCodeTypeRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objAppCodeTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppCodeTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAppCodeTypeRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conAppCodeTypeRela.ApplicationTypeId);
 arrValueListForInsert.Add(objAppCodeTypeRelaEN.ApplicationTypeId.ToString());
 
 if (objAppCodeTypeRelaEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.CodeTypeId);
 var strCodeTypeId = objAppCodeTypeRelaEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objAppCodeTypeRelaEN.ViewTypeCode !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.ViewTypeCode);
 arrValueListForInsert.Add(objAppCodeTypeRelaEN.ViewTypeCode.ToString());
 }
 
 if (objAppCodeTypeRelaEN.TabMainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.TabMainTypeId);
 var strTabMainTypeId = objAppCodeTypeRelaEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabMainTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conAppCodeTypeRela.IsVisible);
 arrValueListForInsert.Add("'" + (objAppCodeTypeRelaEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conAppCodeTypeRela.IsInGroupGeneCode);
 arrValueListForInsert.Add("'" + (objAppCodeTypeRelaEN.IsInGroupGeneCode  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conAppCodeTypeRela.OrderNum);
 arrValueListForInsert.Add(objAppCodeTypeRelaEN.OrderNum.ToString());
 
 if (objAppCodeTypeRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.UpdDate);
 var strUpdDate = objAppCodeTypeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAppCodeTypeRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.UpdUser);
 var strUpdUser = objAppCodeTypeRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objAppCodeTypeRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.Memo);
 var strMemo = objAppCodeTypeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AppCodeTypeRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objAppCodeTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppCodeTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAppCodeTypeRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conAppCodeTypeRela.ApplicationTypeId);
 arrValueListForInsert.Add(objAppCodeTypeRelaEN.ApplicationTypeId.ToString());
 
 if (objAppCodeTypeRelaEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.CodeTypeId);
 var strCodeTypeId = objAppCodeTypeRelaEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objAppCodeTypeRelaEN.ViewTypeCode !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.ViewTypeCode);
 arrValueListForInsert.Add(objAppCodeTypeRelaEN.ViewTypeCode.ToString());
 }
 
 if (objAppCodeTypeRelaEN.TabMainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.TabMainTypeId);
 var strTabMainTypeId = objAppCodeTypeRelaEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabMainTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conAppCodeTypeRela.IsVisible);
 arrValueListForInsert.Add("'" + (objAppCodeTypeRelaEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conAppCodeTypeRela.IsInGroupGeneCode);
 arrValueListForInsert.Add("'" + (objAppCodeTypeRelaEN.IsInGroupGeneCode  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conAppCodeTypeRela.OrderNum);
 arrValueListForInsert.Add(objAppCodeTypeRelaEN.OrderNum.ToString());
 
 if (objAppCodeTypeRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.UpdDate);
 var strUpdDate = objAppCodeTypeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAppCodeTypeRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.UpdUser);
 var strUpdUser = objAppCodeTypeRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objAppCodeTypeRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAppCodeTypeRela.Memo);
 var strMemo = objAppCodeTypeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AppCodeTypeRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewAppCodeTypeRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from AppCodeTypeRela where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "AppCodeTypeRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conAppCodeTypeRela.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsAppCodeTypeRelaEN._CurrTabName ].NewRow();
objRow[conAppCodeTypeRela.ApplicationTypeId] = oRow[conAppCodeTypeRela.ApplicationTypeId].ToString().Trim(); //应用程序类型ID
objRow[conAppCodeTypeRela.CodeTypeId] = oRow[conAppCodeTypeRela.CodeTypeId].ToString().Trim(); //代码类型Id
objRow[conAppCodeTypeRela.ViewTypeCode] = oRow[conAppCodeTypeRela.ViewTypeCode].ToString().Trim(); //界面类型码
objRow[conAppCodeTypeRela.TabMainTypeId] = oRow[conAppCodeTypeRela.TabMainTypeId].ToString().Trim(); //表主类型Id
objRow[conAppCodeTypeRela.IsVisible] = oRow[conAppCodeTypeRela.IsVisible].ToString().Trim(); //是否显示
objRow[conAppCodeTypeRela.IsInGroupGeneCode] = oRow[conAppCodeTypeRela.IsInGroupGeneCode].ToString().Trim(); //是否参与组生成代码
objRow[conAppCodeTypeRela.OrderNum] = oRow[conAppCodeTypeRela.OrderNum].ToString().Trim(); //序号
objRow[conAppCodeTypeRela.UpdDate] = oRow[conAppCodeTypeRela.UpdDate].ToString().Trim(); //修改日期
objRow[conAppCodeTypeRela.UpdUser] = oRow[conAppCodeTypeRela.UpdUser].ToString().Trim(); //修改者
objRow[conAppCodeTypeRela.Memo] = oRow[conAppCodeTypeRela.Memo].ToString().Trim(); //说明
 objDS.Tables[clsAppCodeTypeRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsAppCodeTypeRelaEN._CurrTabName);
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
 /// <param name = "objAppCodeTypeRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
 objAppCodeTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppCodeTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAppCodeTypeRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from AppCodeTypeRela where mId = " + ""+ objAppCodeTypeRelaEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsAppCodeTypeRelaEN._CurrTabName);
if (objDS.Tables[clsAppCodeTypeRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objAppCodeTypeRelaEN.mId+"");
return false;
}
objRow = objDS.Tables[clsAppCodeTypeRelaEN._CurrTabName].Rows[0];
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.ApplicationTypeId))
 {
objRow[conAppCodeTypeRela.ApplicationTypeId] = objAppCodeTypeRelaEN.ApplicationTypeId; //应用程序类型ID
 }
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.CodeTypeId))
 {
objRow[conAppCodeTypeRela.CodeTypeId] = objAppCodeTypeRelaEN.CodeTypeId; //代码类型Id
 }
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.ViewTypeCode))
 {
objRow[conAppCodeTypeRela.ViewTypeCode] = objAppCodeTypeRelaEN.ViewTypeCode; //界面类型码
 }
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.TabMainTypeId))
 {
objRow[conAppCodeTypeRela.TabMainTypeId] = objAppCodeTypeRelaEN.TabMainTypeId; //表主类型Id
 }
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.IsVisible))
 {
objRow[conAppCodeTypeRela.IsVisible] = objAppCodeTypeRelaEN.IsVisible; //是否显示
 }
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.IsInGroupGeneCode))
 {
objRow[conAppCodeTypeRela.IsInGroupGeneCode] = objAppCodeTypeRelaEN.IsInGroupGeneCode; //是否参与组生成代码
 }
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.OrderNum))
 {
objRow[conAppCodeTypeRela.OrderNum] = objAppCodeTypeRelaEN.OrderNum; //序号
 }
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.UpdDate))
 {
objRow[conAppCodeTypeRela.UpdDate] = objAppCodeTypeRelaEN.UpdDate; //修改日期
 }
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.UpdUser))
 {
objRow[conAppCodeTypeRela.UpdUser] = objAppCodeTypeRelaEN.UpdUser; //修改者
 }
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.Memo))
 {
objRow[conAppCodeTypeRela.Memo] = objAppCodeTypeRelaEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsAppCodeTypeRelaEN._CurrTabName);
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
 /// <param name = "objAppCodeTypeRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
 objAppCodeTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppCodeTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAppCodeTypeRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update AppCodeTypeRela Set ");
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objAppCodeTypeRelaEN.ApplicationTypeId, conAppCodeTypeRela.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.CodeTypeId))
 {
 if (objAppCodeTypeRelaEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objAppCodeTypeRelaEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTypeId, conAppCodeTypeRela.CodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppCodeTypeRela.CodeTypeId); //代码类型Id
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.ViewTypeCode))
 {
 if (objAppCodeTypeRelaEN.ViewTypeCode !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objAppCodeTypeRelaEN.ViewTypeCode, conAppCodeTypeRela.ViewTypeCode); //界面类型码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppCodeTypeRela.ViewTypeCode); //界面类型码
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.TabMainTypeId))
 {
 if (objAppCodeTypeRelaEN.TabMainTypeId !=  null)
 {
 var strTabMainTypeId = objAppCodeTypeRelaEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabMainTypeId, conAppCodeTypeRela.TabMainTypeId); //表主类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppCodeTypeRela.TabMainTypeId); //表主类型Id
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objAppCodeTypeRelaEN.IsVisible == true?"1":"0", conAppCodeTypeRela.IsVisible); //是否显示
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.IsInGroupGeneCode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objAppCodeTypeRelaEN.IsInGroupGeneCode == true?"1":"0", conAppCodeTypeRela.IsInGroupGeneCode); //是否参与组生成代码
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objAppCodeTypeRelaEN.OrderNum, conAppCodeTypeRela.OrderNum); //序号
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.UpdDate))
 {
 if (objAppCodeTypeRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objAppCodeTypeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conAppCodeTypeRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppCodeTypeRela.UpdDate); //修改日期
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.UpdUser))
 {
 if (objAppCodeTypeRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objAppCodeTypeRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conAppCodeTypeRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppCodeTypeRela.UpdUser); //修改者
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.Memo))
 {
 if (objAppCodeTypeRelaEN.Memo !=  null)
 {
 var strMemo = objAppCodeTypeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conAppCodeTypeRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppCodeTypeRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objAppCodeTypeRelaEN.mId); 
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
 /// <param name = "objAppCodeTypeRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, string strCondition)
{
 objAppCodeTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppCodeTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAppCodeTypeRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update AppCodeTypeRela Set ");
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objAppCodeTypeRelaEN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.CodeTypeId))
 {
 if (objAppCodeTypeRelaEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objAppCodeTypeRelaEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeId = '{0}',", strCodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.Append(" CodeTypeId = null,"); //代码类型Id
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.ViewTypeCode))
 {
 if (objAppCodeTypeRelaEN.ViewTypeCode !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objAppCodeTypeRelaEN.ViewTypeCode, conAppCodeTypeRela.ViewTypeCode); //界面类型码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppCodeTypeRela.ViewTypeCode); //界面类型码
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.TabMainTypeId))
 {
 if (objAppCodeTypeRelaEN.TabMainTypeId !=  null)
 {
 var strTabMainTypeId = objAppCodeTypeRelaEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabMainTypeId = '{0}',", strTabMainTypeId); //表主类型Id
 }
 else
 {
 sbSQL.Append(" TabMainTypeId = null,"); //表主类型Id
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objAppCodeTypeRelaEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.IsInGroupGeneCode))
 {
 sbSQL.AppendFormat(" IsInGroupGeneCode = '{0}',", objAppCodeTypeRelaEN.IsInGroupGeneCode == true?"1":"0"); //是否参与组生成代码
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objAppCodeTypeRelaEN.OrderNum); //序号
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.UpdDate))
 {
 if (objAppCodeTypeRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objAppCodeTypeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.UpdUser))
 {
 if (objAppCodeTypeRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objAppCodeTypeRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.Memo))
 {
 if (objAppCodeTypeRelaEN.Memo !=  null)
 {
 var strMemo = objAppCodeTypeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objAppCodeTypeRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objAppCodeTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppCodeTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAppCodeTypeRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update AppCodeTypeRela Set ");
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objAppCodeTypeRelaEN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.CodeTypeId))
 {
 if (objAppCodeTypeRelaEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objAppCodeTypeRelaEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeId = '{0}',", strCodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.Append(" CodeTypeId = null,"); //代码类型Id
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.ViewTypeCode))
 {
 if (objAppCodeTypeRelaEN.ViewTypeCode !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objAppCodeTypeRelaEN.ViewTypeCode, conAppCodeTypeRela.ViewTypeCode); //界面类型码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppCodeTypeRela.ViewTypeCode); //界面类型码
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.TabMainTypeId))
 {
 if (objAppCodeTypeRelaEN.TabMainTypeId !=  null)
 {
 var strTabMainTypeId = objAppCodeTypeRelaEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabMainTypeId = '{0}',", strTabMainTypeId); //表主类型Id
 }
 else
 {
 sbSQL.Append(" TabMainTypeId = null,"); //表主类型Id
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objAppCodeTypeRelaEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.IsInGroupGeneCode))
 {
 sbSQL.AppendFormat(" IsInGroupGeneCode = '{0}',", objAppCodeTypeRelaEN.IsInGroupGeneCode == true?"1":"0"); //是否参与组生成代码
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objAppCodeTypeRelaEN.OrderNum); //序号
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.UpdDate))
 {
 if (objAppCodeTypeRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objAppCodeTypeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.UpdUser))
 {
 if (objAppCodeTypeRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objAppCodeTypeRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.Memo))
 {
 if (objAppCodeTypeRelaEN.Memo !=  null)
 {
 var strMemo = objAppCodeTypeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objAppCodeTypeRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objAppCodeTypeRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppCodeTypeRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAppCodeTypeRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update AppCodeTypeRela Set ");
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objAppCodeTypeRelaEN.ApplicationTypeId, conAppCodeTypeRela.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.CodeTypeId))
 {
 if (objAppCodeTypeRelaEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objAppCodeTypeRelaEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTypeId, conAppCodeTypeRela.CodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppCodeTypeRela.CodeTypeId); //代码类型Id
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.ViewTypeCode))
 {
 if (objAppCodeTypeRelaEN.ViewTypeCode !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objAppCodeTypeRelaEN.ViewTypeCode, conAppCodeTypeRela.ViewTypeCode); //界面类型码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppCodeTypeRela.ViewTypeCode); //界面类型码
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.TabMainTypeId))
 {
 if (objAppCodeTypeRelaEN.TabMainTypeId !=  null)
 {
 var strTabMainTypeId = objAppCodeTypeRelaEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabMainTypeId, conAppCodeTypeRela.TabMainTypeId); //表主类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppCodeTypeRela.TabMainTypeId); //表主类型Id
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objAppCodeTypeRelaEN.IsVisible == true?"1":"0", conAppCodeTypeRela.IsVisible); //是否显示
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.IsInGroupGeneCode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objAppCodeTypeRelaEN.IsInGroupGeneCode == true?"1":"0", conAppCodeTypeRela.IsInGroupGeneCode); //是否参与组生成代码
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objAppCodeTypeRelaEN.OrderNum, conAppCodeTypeRela.OrderNum); //序号
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.UpdDate))
 {
 if (objAppCodeTypeRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objAppCodeTypeRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conAppCodeTypeRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppCodeTypeRela.UpdDate); //修改日期
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.UpdUser))
 {
 if (objAppCodeTypeRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objAppCodeTypeRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conAppCodeTypeRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppCodeTypeRela.UpdUser); //修改者
 }
 }
 
 if (objAppCodeTypeRelaEN.IsUpdated(conAppCodeTypeRela.Memo))
 {
 if (objAppCodeTypeRelaEN.Memo !=  null)
 {
 var strMemo = objAppCodeTypeRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conAppCodeTypeRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppCodeTypeRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objAppCodeTypeRelaEN.mId); 
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
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("AppCodeTypeRela_Delete", values);
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
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
//删除AppCodeTypeRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from AppCodeTypeRela where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelAppCodeTypeRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
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
//删除AppCodeTypeRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from AppCodeTypeRela where mId in (" + strKeyList + ")";
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
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
//删除AppCodeTypeRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from AppCodeTypeRela where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelAppCodeTypeRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsAppCodeTypeRelaDA: DelAppCodeTypeRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from AppCodeTypeRela where " + strCondition ;
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
public bool DelAppCodeTypeRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsAppCodeTypeRelaDA: DelAppCodeTypeRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from AppCodeTypeRela where " + strCondition ;
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
 /// <param name = "objAppCodeTypeRelaENS">源对象</param>
 /// <param name = "objAppCodeTypeRelaENT">目标对象</param>
public void CopyTo(clsAppCodeTypeRelaEN objAppCodeTypeRelaENS, clsAppCodeTypeRelaEN objAppCodeTypeRelaENT)
{
objAppCodeTypeRelaENT.mId = objAppCodeTypeRelaENS.mId; //mId
objAppCodeTypeRelaENT.ApplicationTypeId = objAppCodeTypeRelaENS.ApplicationTypeId; //应用程序类型ID
objAppCodeTypeRelaENT.CodeTypeId = objAppCodeTypeRelaENS.CodeTypeId; //代码类型Id
objAppCodeTypeRelaENT.ViewTypeCode = objAppCodeTypeRelaENS.ViewTypeCode; //界面类型码
objAppCodeTypeRelaENT.TabMainTypeId = objAppCodeTypeRelaENS.TabMainTypeId; //表主类型Id
objAppCodeTypeRelaENT.IsVisible = objAppCodeTypeRelaENS.IsVisible; //是否显示
objAppCodeTypeRelaENT.IsInGroupGeneCode = objAppCodeTypeRelaENS.IsInGroupGeneCode; //是否参与组生成代码
objAppCodeTypeRelaENT.OrderNum = objAppCodeTypeRelaENS.OrderNum; //序号
objAppCodeTypeRelaENT.UpdDate = objAppCodeTypeRelaENS.UpdDate; //修改日期
objAppCodeTypeRelaENT.UpdUser = objAppCodeTypeRelaENS.UpdUser; //修改者
objAppCodeTypeRelaENT.Memo = objAppCodeTypeRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objAppCodeTypeRelaEN.ApplicationTypeId, conAppCodeTypeRela.ApplicationTypeId);
clsCheckSql.CheckFieldNotNull(objAppCodeTypeRelaEN.CodeTypeId, conAppCodeTypeRela.CodeTypeId);
clsCheckSql.CheckFieldNotNull(objAppCodeTypeRelaEN.OrderNum, conAppCodeTypeRela.OrderNum);
//检查字段长度
clsCheckSql.CheckFieldLen(objAppCodeTypeRelaEN.CodeTypeId, 4, conAppCodeTypeRela.CodeTypeId);
clsCheckSql.CheckFieldLen(objAppCodeTypeRelaEN.TabMainTypeId, 4, conAppCodeTypeRela.TabMainTypeId);
clsCheckSql.CheckFieldLen(objAppCodeTypeRelaEN.UpdDate, 20, conAppCodeTypeRela.UpdDate);
clsCheckSql.CheckFieldLen(objAppCodeTypeRelaEN.UpdUser, 20, conAppCodeTypeRela.UpdUser);
clsCheckSql.CheckFieldLen(objAppCodeTypeRelaEN.Memo, 1000, conAppCodeTypeRela.Memo);
//检查字段外键固定长度
 objAppCodeTypeRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objAppCodeTypeRelaEN.CodeTypeId, 4, conAppCodeTypeRela.CodeTypeId);
clsCheckSql.CheckFieldLen(objAppCodeTypeRelaEN.TabMainTypeId, 4, conAppCodeTypeRela.TabMainTypeId);
clsCheckSql.CheckFieldLen(objAppCodeTypeRelaEN.UpdDate, 20, conAppCodeTypeRela.UpdDate);
clsCheckSql.CheckFieldLen(objAppCodeTypeRelaEN.UpdUser, 20, conAppCodeTypeRela.UpdUser);
clsCheckSql.CheckFieldLen(objAppCodeTypeRelaEN.Memo, 1000, conAppCodeTypeRela.Memo);
//检查外键字段长度
 objAppCodeTypeRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objAppCodeTypeRelaEN.CodeTypeId, 4, conAppCodeTypeRela.CodeTypeId);
clsCheckSql.CheckFieldLen(objAppCodeTypeRelaEN.TabMainTypeId, 4, conAppCodeTypeRela.TabMainTypeId);
clsCheckSql.CheckFieldLen(objAppCodeTypeRelaEN.UpdDate, 20, conAppCodeTypeRela.UpdDate);
clsCheckSql.CheckFieldLen(objAppCodeTypeRelaEN.UpdUser, 20, conAppCodeTypeRela.UpdUser);
clsCheckSql.CheckFieldLen(objAppCodeTypeRelaEN.Memo, 1000, conAppCodeTypeRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objAppCodeTypeRelaEN.CodeTypeId, conAppCodeTypeRela.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objAppCodeTypeRelaEN.TabMainTypeId, conAppCodeTypeRela.TabMainTypeId);
clsCheckSql.CheckSqlInjection4Field(objAppCodeTypeRelaEN.UpdDate, conAppCodeTypeRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objAppCodeTypeRelaEN.UpdUser, conAppCodeTypeRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objAppCodeTypeRelaEN.Memo, conAppCodeTypeRela.Memo);
//检查外键字段长度
 objAppCodeTypeRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--AppCodeTypeRela(应用程序代码类型关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objAppCodeTypeRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsAppCodeTypeRelaEN objAppCodeTypeRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objAppCodeTypeRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objAppCodeTypeRelaEN.CodeTypeId);
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
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
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
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
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
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsAppCodeTypeRelaEN._CurrTabName);
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
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsAppCodeTypeRelaEN._CurrTabName, strCondition);
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
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
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
 objSQL = clsAppCodeTypeRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}