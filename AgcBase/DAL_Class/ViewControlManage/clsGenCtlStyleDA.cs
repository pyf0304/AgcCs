
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsGenCtlStyleDA
 表名:GenCtlStyle(00050064)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:28
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面控件管理(ViewControlManage)
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
 /// 一般控件样式(GenCtlStyle)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsGenCtlStyleDA : clsCommBase4DA
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
 return clsGenCtlStyleEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsGenCtlStyleEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsGenCtlStyleEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsGenCtlStyleEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsGenCtlStyleEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strGenCtlStyleId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strGenCtlStyleId)
{
strGenCtlStyleId = strGenCtlStyleId.Replace("'", "''");
if (strGenCtlStyleId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:GenCtlStyle中,检查关键字,长度不正确!(clsGenCtlStyleDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strGenCtlStyleId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:GenCtlStyle中,关键字不能为空 或 null!(clsGenCtlStyleDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGenCtlStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsGenCtlStyleDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsGenCtlStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
strSQL = "Select * from GenCtlStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_GenCtlStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsGenCtlStyleDA: GetDataTable_GenCtlStyle)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
strSQL = "Select * from GenCtlStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsGenCtlStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsGenCtlStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
strSQL = "Select * from GenCtlStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsGenCtlStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsGenCtlStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GenCtlStyle where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GenCtlStyle where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsGenCtlStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from GenCtlStyle where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsGenCtlStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} GenCtlStyle.* " + 
$"from GenCtlStyle " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and GenCtlStyle.GenCtlStyleId not in " + 
$"(Select top {intTop_In} GenCtlStyle.GenCtlStyleId from GenCtlStyle " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GenCtlStyle where {1} and GenCtlStyleId not in (Select top {2} GenCtlStyleId from GenCtlStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GenCtlStyle where {1} and GenCtlStyleId not in (Select top {3} GenCtlStyleId from GenCtlStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsGenCtlStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} GenCtlStyle.* " + 
$"from GenCtlStyle " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and GenCtlStyle.GenCtlStyleId not in " + 
$"(Select top {intTop_In} GenCtlStyle.GenCtlStyleId from GenCtlStyle " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from GenCtlStyle where {1} and GenCtlStyleId not in (Select top {2} GenCtlStyleId from GenCtlStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from GenCtlStyle where {1} and GenCtlStyleId not in (Select top {3} GenCtlStyleId from GenCtlStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsGenCtlStyleEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsGenCtlStyleDA:GetObjLst)", objException.Message));
}
List<clsGenCtlStyleEN> arrObjLst = new List<clsGenCtlStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
strSQL = "Select * from GenCtlStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGenCtlStyleEN objGenCtlStyleEN = new clsGenCtlStyleEN();
try
{
objGenCtlStyleEN.GenCtlStyleId = objRow[conGenCtlStyle.GenCtlStyleId].ToString().Trim(); //GenCtlStyleId
objGenCtlStyleEN.GenCtlStyleName = objRow[conGenCtlStyle.GenCtlStyleName].ToString().Trim(); //GenCtlStyleName
objGenCtlStyleEN.Style = objRow[conGenCtlStyle.Style] == DBNull.Value ? null : objRow[conGenCtlStyle.Style].ToString().Trim(); //类型
objGenCtlStyleEN.Runat = objRow[conGenCtlStyle.Runat] == DBNull.Value ? null : objRow[conGenCtlStyle.Runat].ToString().Trim(); //运行在
objGenCtlStyleEN.FontSize = objRow[conGenCtlStyle.FontSize] == DBNull.Value ? null : objRow[conGenCtlStyle.FontSize].ToString().Trim(); //字号
objGenCtlStyleEN.FontName = objRow[conGenCtlStyle.FontName] == DBNull.Value ? null : objRow[conGenCtlStyle.FontName].ToString().Trim(); //字体
objGenCtlStyleEN.Width = objRow[conGenCtlStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.Width].ToString().Trim()); //宽
objGenCtlStyleEN.Height = objRow[conGenCtlStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.Height].ToString().Trim()); //高度
objGenCtlStyleEN.TextMode = objRow[conGenCtlStyle.TextMode].ToString().Trim(); //TextMode
objGenCtlStyleEN.StyleZindex = objRow[conGenCtlStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objGenCtlStyleEN.StyleLeft = objRow[conGenCtlStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.StyleLeft].ToString().Trim()); //Style_Left
objGenCtlStyleEN.StylePosition = objRow[conGenCtlStyle.StylePosition] == DBNull.Value ? null : objRow[conGenCtlStyle.StylePosition].ToString().Trim(); //Style_Position
objGenCtlStyleEN.StyleTop = objRow[conGenCtlStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsGenCtlStyleDA: GetObjLst)", objException.Message));
}
objGenCtlStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objGenCtlStyleEN);
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
public List<clsGenCtlStyleEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsGenCtlStyleDA:GetObjLstByTabName)", objException.Message));
}
List<clsGenCtlStyleEN> arrObjLst = new List<clsGenCtlStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsGenCtlStyleEN objGenCtlStyleEN = new clsGenCtlStyleEN();
try
{
objGenCtlStyleEN.GenCtlStyleId = objRow[conGenCtlStyle.GenCtlStyleId].ToString().Trim(); //GenCtlStyleId
objGenCtlStyleEN.GenCtlStyleName = objRow[conGenCtlStyle.GenCtlStyleName].ToString().Trim(); //GenCtlStyleName
objGenCtlStyleEN.Style = objRow[conGenCtlStyle.Style] == DBNull.Value ? null : objRow[conGenCtlStyle.Style].ToString().Trim(); //类型
objGenCtlStyleEN.Runat = objRow[conGenCtlStyle.Runat] == DBNull.Value ? null : objRow[conGenCtlStyle.Runat].ToString().Trim(); //运行在
objGenCtlStyleEN.FontSize = objRow[conGenCtlStyle.FontSize] == DBNull.Value ? null : objRow[conGenCtlStyle.FontSize].ToString().Trim(); //字号
objGenCtlStyleEN.FontName = objRow[conGenCtlStyle.FontName] == DBNull.Value ? null : objRow[conGenCtlStyle.FontName].ToString().Trim(); //字体
objGenCtlStyleEN.Width = objRow[conGenCtlStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.Width].ToString().Trim()); //宽
objGenCtlStyleEN.Height = objRow[conGenCtlStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.Height].ToString().Trim()); //高度
objGenCtlStyleEN.TextMode = objRow[conGenCtlStyle.TextMode].ToString().Trim(); //TextMode
objGenCtlStyleEN.StyleZindex = objRow[conGenCtlStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objGenCtlStyleEN.StyleLeft = objRow[conGenCtlStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.StyleLeft].ToString().Trim()); //Style_Left
objGenCtlStyleEN.StylePosition = objRow[conGenCtlStyle.StylePosition] == DBNull.Value ? null : objRow[conGenCtlStyle.StylePosition].ToString().Trim(); //Style_Position
objGenCtlStyleEN.StyleTop = objRow[conGenCtlStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsGenCtlStyleDA: GetObjLst)", objException.Message));
}
objGenCtlStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objGenCtlStyleEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetGenCtlStyle(ref clsGenCtlStyleEN objGenCtlStyleEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
strSQL = "Select * from GenCtlStyle where GenCtlStyleId = " + "'"+ objGenCtlStyleEN.GenCtlStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objGenCtlStyleEN.GenCtlStyleId = objDT.Rows[0][conGenCtlStyle.GenCtlStyleId].ToString().Trim(); //GenCtlStyleId(字段类型:varchar,字段长度:4,是否可空:False)
 objGenCtlStyleEN.GenCtlStyleName = objDT.Rows[0][conGenCtlStyle.GenCtlStyleName].ToString().Trim(); //GenCtlStyleName(字段类型:varchar,字段长度:30,是否可空:False)
 objGenCtlStyleEN.Style = objDT.Rows[0][conGenCtlStyle.Style].ToString().Trim(); //类型(字段类型:varchar,字段长度:800,是否可空:True)
 objGenCtlStyleEN.Runat = objDT.Rows[0][conGenCtlStyle.Runat].ToString().Trim(); //运行在(字段类型:varchar,字段长度:30,是否可空:True)
 objGenCtlStyleEN.FontSize = objDT.Rows[0][conGenCtlStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objGenCtlStyleEN.FontName = objDT.Rows[0][conGenCtlStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objGenCtlStyleEN.Width = TransNullToInt(objDT.Rows[0][conGenCtlStyle.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objGenCtlStyleEN.Height = TransNullToInt(objDT.Rows[0][conGenCtlStyle.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objGenCtlStyleEN.TextMode = objDT.Rows[0][conGenCtlStyle.TextMode].ToString().Trim(); //TextMode(字段类型:varchar,字段长度:20,是否可空:False)
 objGenCtlStyleEN.StyleZindex = TransNullToInt(objDT.Rows[0][conGenCtlStyle.StyleZindex].ToString().Trim()); //Style_Zindex(字段类型:int,字段长度:4,是否可空:True)
 objGenCtlStyleEN.StyleLeft = TransNullToInt(objDT.Rows[0][conGenCtlStyle.StyleLeft].ToString().Trim()); //Style_Left(字段类型:int,字段长度:4,是否可空:True)
 objGenCtlStyleEN.StylePosition = objDT.Rows[0][conGenCtlStyle.StylePosition].ToString().Trim(); //Style_Position(字段类型:varchar,字段长度:20,是否可空:True)
 objGenCtlStyleEN.StyleTop = TransNullToInt(objDT.Rows[0][conGenCtlStyle.StyleTop].ToString().Trim()); //Style_Top(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsGenCtlStyleDA: GetGenCtlStyle)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strGenCtlStyleId">表关键字</param>
 /// <returns>表对象</returns>
public clsGenCtlStyleEN GetObjByGenCtlStyleId(string strGenCtlStyleId)
{
CheckPrimaryKey(strGenCtlStyleId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
strSQL = "Select * from GenCtlStyle where GenCtlStyleId = " + "'"+ strGenCtlStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsGenCtlStyleEN objGenCtlStyleEN = new clsGenCtlStyleEN();
try
{
 objGenCtlStyleEN.GenCtlStyleId = objRow[conGenCtlStyle.GenCtlStyleId].ToString().Trim(); //GenCtlStyleId(字段类型:varchar,字段长度:4,是否可空:False)
 objGenCtlStyleEN.GenCtlStyleName = objRow[conGenCtlStyle.GenCtlStyleName].ToString().Trim(); //GenCtlStyleName(字段类型:varchar,字段长度:30,是否可空:False)
 objGenCtlStyleEN.Style = objRow[conGenCtlStyle.Style] == DBNull.Value ? null : objRow[conGenCtlStyle.Style].ToString().Trim(); //类型(字段类型:varchar,字段长度:800,是否可空:True)
 objGenCtlStyleEN.Runat = objRow[conGenCtlStyle.Runat] == DBNull.Value ? null : objRow[conGenCtlStyle.Runat].ToString().Trim(); //运行在(字段类型:varchar,字段长度:30,是否可空:True)
 objGenCtlStyleEN.FontSize = objRow[conGenCtlStyle.FontSize] == DBNull.Value ? null : objRow[conGenCtlStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objGenCtlStyleEN.FontName = objRow[conGenCtlStyle.FontName] == DBNull.Value ? null : objRow[conGenCtlStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objGenCtlStyleEN.Width = objRow[conGenCtlStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objGenCtlStyleEN.Height = objRow[conGenCtlStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objGenCtlStyleEN.TextMode = objRow[conGenCtlStyle.TextMode].ToString().Trim(); //TextMode(字段类型:varchar,字段长度:20,是否可空:False)
 objGenCtlStyleEN.StyleZindex = objRow[conGenCtlStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleZindex].ToString().Trim()); //Style_Zindex(字段类型:int,字段长度:4,是否可空:True)
 objGenCtlStyleEN.StyleLeft = objRow[conGenCtlStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleLeft].ToString().Trim()); //Style_Left(字段类型:int,字段长度:4,是否可空:True)
 objGenCtlStyleEN.StylePosition = objRow[conGenCtlStyle.StylePosition] == DBNull.Value ? null : objRow[conGenCtlStyle.StylePosition].ToString().Trim(); //Style_Position(字段类型:varchar,字段长度:20,是否可空:True)
 objGenCtlStyleEN.StyleTop = objRow[conGenCtlStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conGenCtlStyle.StyleTop].ToString().Trim()); //Style_Top(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsGenCtlStyleDA: GetObjByGenCtlStyleId)", objException.Message));
}
return objGenCtlStyleEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsGenCtlStyleEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsGenCtlStyleDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
strSQL = "Select * from GenCtlStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsGenCtlStyleEN objGenCtlStyleEN = new clsGenCtlStyleEN()
{
GenCtlStyleId = objRow[conGenCtlStyle.GenCtlStyleId].ToString().Trim(), //GenCtlStyleId
GenCtlStyleName = objRow[conGenCtlStyle.GenCtlStyleName].ToString().Trim(), //GenCtlStyleName
Style = objRow[conGenCtlStyle.Style] == DBNull.Value ? null : objRow[conGenCtlStyle.Style].ToString().Trim(), //类型
Runat = objRow[conGenCtlStyle.Runat] == DBNull.Value ? null : objRow[conGenCtlStyle.Runat].ToString().Trim(), //运行在
FontSize = objRow[conGenCtlStyle.FontSize] == DBNull.Value ? null : objRow[conGenCtlStyle.FontSize].ToString().Trim(), //字号
FontName = objRow[conGenCtlStyle.FontName] == DBNull.Value ? null : objRow[conGenCtlStyle.FontName].ToString().Trim(), //字体
Width = objRow[conGenCtlStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.Width].ToString().Trim()), //宽
Height = objRow[conGenCtlStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.Height].ToString().Trim()), //高度
TextMode = objRow[conGenCtlStyle.TextMode].ToString().Trim(), //TextMode
StyleZindex = objRow[conGenCtlStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.StyleZindex].ToString().Trim()), //Style_Zindex
StyleLeft = objRow[conGenCtlStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.StyleLeft].ToString().Trim()), //Style_Left
StylePosition = objRow[conGenCtlStyle.StylePosition] == DBNull.Value ? null : objRow[conGenCtlStyle.StylePosition].ToString().Trim(), //Style_Position
StyleTop = objRow[conGenCtlStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.StyleTop].ToString().Trim()) //Style_Top
};
objGenCtlStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGenCtlStyleEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsGenCtlStyleDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsGenCtlStyleEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsGenCtlStyleEN objGenCtlStyleEN = new clsGenCtlStyleEN();
try
{
objGenCtlStyleEN.GenCtlStyleId = objRow[conGenCtlStyle.GenCtlStyleId].ToString().Trim(); //GenCtlStyleId
objGenCtlStyleEN.GenCtlStyleName = objRow[conGenCtlStyle.GenCtlStyleName].ToString().Trim(); //GenCtlStyleName
objGenCtlStyleEN.Style = objRow[conGenCtlStyle.Style] == DBNull.Value ? null : objRow[conGenCtlStyle.Style].ToString().Trim(); //类型
objGenCtlStyleEN.Runat = objRow[conGenCtlStyle.Runat] == DBNull.Value ? null : objRow[conGenCtlStyle.Runat].ToString().Trim(); //运行在
objGenCtlStyleEN.FontSize = objRow[conGenCtlStyle.FontSize] == DBNull.Value ? null : objRow[conGenCtlStyle.FontSize].ToString().Trim(); //字号
objGenCtlStyleEN.FontName = objRow[conGenCtlStyle.FontName] == DBNull.Value ? null : objRow[conGenCtlStyle.FontName].ToString().Trim(); //字体
objGenCtlStyleEN.Width = objRow[conGenCtlStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.Width].ToString().Trim()); //宽
objGenCtlStyleEN.Height = objRow[conGenCtlStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.Height].ToString().Trim()); //高度
objGenCtlStyleEN.TextMode = objRow[conGenCtlStyle.TextMode].ToString().Trim(); //TextMode
objGenCtlStyleEN.StyleZindex = objRow[conGenCtlStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objGenCtlStyleEN.StyleLeft = objRow[conGenCtlStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.StyleLeft].ToString().Trim()); //Style_Left
objGenCtlStyleEN.StylePosition = objRow[conGenCtlStyle.StylePosition] == DBNull.Value ? null : objRow[conGenCtlStyle.StylePosition].ToString().Trim(); //Style_Position
objGenCtlStyleEN.StyleTop = objRow[conGenCtlStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsGenCtlStyleDA: GetObjByDataRowGenCtlStyle)", objException.Message));
}
objGenCtlStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGenCtlStyleEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsGenCtlStyleEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsGenCtlStyleEN objGenCtlStyleEN = new clsGenCtlStyleEN();
try
{
objGenCtlStyleEN.GenCtlStyleId = objRow[conGenCtlStyle.GenCtlStyleId].ToString().Trim(); //GenCtlStyleId
objGenCtlStyleEN.GenCtlStyleName = objRow[conGenCtlStyle.GenCtlStyleName].ToString().Trim(); //GenCtlStyleName
objGenCtlStyleEN.Style = objRow[conGenCtlStyle.Style] == DBNull.Value ? null : objRow[conGenCtlStyle.Style].ToString().Trim(); //类型
objGenCtlStyleEN.Runat = objRow[conGenCtlStyle.Runat] == DBNull.Value ? null : objRow[conGenCtlStyle.Runat].ToString().Trim(); //运行在
objGenCtlStyleEN.FontSize = objRow[conGenCtlStyle.FontSize] == DBNull.Value ? null : objRow[conGenCtlStyle.FontSize].ToString().Trim(); //字号
objGenCtlStyleEN.FontName = objRow[conGenCtlStyle.FontName] == DBNull.Value ? null : objRow[conGenCtlStyle.FontName].ToString().Trim(); //字体
objGenCtlStyleEN.Width = objRow[conGenCtlStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.Width].ToString().Trim()); //宽
objGenCtlStyleEN.Height = objRow[conGenCtlStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.Height].ToString().Trim()); //高度
objGenCtlStyleEN.TextMode = objRow[conGenCtlStyle.TextMode].ToString().Trim(); //TextMode
objGenCtlStyleEN.StyleZindex = objRow[conGenCtlStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objGenCtlStyleEN.StyleLeft = objRow[conGenCtlStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.StyleLeft].ToString().Trim()); //Style_Left
objGenCtlStyleEN.StylePosition = objRow[conGenCtlStyle.StylePosition] == DBNull.Value ? null : objRow[conGenCtlStyle.StylePosition].ToString().Trim(); //Style_Position
objGenCtlStyleEN.StyleTop = objRow[conGenCtlStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conGenCtlStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsGenCtlStyleDA: GetObjByDataRow)", objException.Message));
}
objGenCtlStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objGenCtlStyleEN;
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
objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsGenCtlStyleEN._CurrTabName, conGenCtlStyle.GenCtlStyleId, 4, "");
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
objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsGenCtlStyleEN._CurrTabName, conGenCtlStyle.GenCtlStyleId, 4, strPrefix);
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
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select GenCtlStyleId from GenCtlStyle where " + strCondition;
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
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select GenCtlStyleId from GenCtlStyle where " + strCondition;
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
 /// <param name = "strGenCtlStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strGenCtlStyleId)
{
CheckPrimaryKey(strGenCtlStyleId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("GenCtlStyle", "GenCtlStyleId = " + "'"+ strGenCtlStyleId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsGenCtlStyleDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("GenCtlStyle", strCondition))
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
objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("GenCtlStyle");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsGenCtlStyleEN objGenCtlStyleEN)
 {
 if (objGenCtlStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGenCtlStyleEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
strSQL = "Select * from GenCtlStyle where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "GenCtlStyle");
objRow = objDS.Tables["GenCtlStyle"].NewRow();
objRow[conGenCtlStyle.GenCtlStyleId] = objGenCtlStyleEN.GenCtlStyleId; //GenCtlStyleId
objRow[conGenCtlStyle.GenCtlStyleName] = objGenCtlStyleEN.GenCtlStyleName; //GenCtlStyleName
 if (objGenCtlStyleEN.Style !=  "")
 {
objRow[conGenCtlStyle.Style] = objGenCtlStyleEN.Style; //类型
 }
 if (objGenCtlStyleEN.Runat !=  "")
 {
objRow[conGenCtlStyle.Runat] = objGenCtlStyleEN.Runat; //运行在
 }
 if (objGenCtlStyleEN.FontSize !=  "")
 {
objRow[conGenCtlStyle.FontSize] = objGenCtlStyleEN.FontSize; //字号
 }
 if (objGenCtlStyleEN.FontName !=  "")
 {
objRow[conGenCtlStyle.FontName] = objGenCtlStyleEN.FontName; //字体
 }
objRow[conGenCtlStyle.Width] = objGenCtlStyleEN.Width; //宽
objRow[conGenCtlStyle.Height] = objGenCtlStyleEN.Height; //高度
objRow[conGenCtlStyle.TextMode] = objGenCtlStyleEN.TextMode; //TextMode
objRow[conGenCtlStyle.StyleZindex] = objGenCtlStyleEN.StyleZindex; //Style_Zindex
objRow[conGenCtlStyle.StyleLeft] = objGenCtlStyleEN.StyleLeft; //Style_Left
 if (objGenCtlStyleEN.StylePosition !=  "")
 {
objRow[conGenCtlStyle.StylePosition] = objGenCtlStyleEN.StylePosition; //Style_Position
 }
objRow[conGenCtlStyle.StyleTop] = objGenCtlStyleEN.StyleTop; //Style_Top
objDS.Tables[clsGenCtlStyleEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsGenCtlStyleEN._CurrTabName);
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
 /// <param name = "objGenCtlStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsGenCtlStyleEN objGenCtlStyleEN)
{
 if (objGenCtlStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGenCtlStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGenCtlStyleEN.GenCtlStyleId !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.GenCtlStyleId);
 var strGenCtlStyleId = objGenCtlStyleEN.GenCtlStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGenCtlStyleId + "'");
 }
 
 if (objGenCtlStyleEN.GenCtlStyleName !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.GenCtlStyleName);
 var strGenCtlStyleName = objGenCtlStyleEN.GenCtlStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGenCtlStyleName + "'");
 }
 
 if (objGenCtlStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.Style);
 var strStyle = objGenCtlStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objGenCtlStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.Runat);
 var strRunat = objGenCtlStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objGenCtlStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.FontSize);
 var strFontSize = objGenCtlStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objGenCtlStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.FontName);
 var strFontName = objGenCtlStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objGenCtlStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.Width);
 arrValueListForInsert.Add(objGenCtlStyleEN.Width.ToString());
 }
 
 if (objGenCtlStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.Height);
 arrValueListForInsert.Add(objGenCtlStyleEN.Height.ToString());
 }
 
 if (objGenCtlStyleEN.TextMode !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.TextMode);
 var strTextMode = objGenCtlStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextMode + "'");
 }
 
 if (objGenCtlStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.StyleZindex);
 arrValueListForInsert.Add(objGenCtlStyleEN.StyleZindex.ToString());
 }
 
 if (objGenCtlStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.StyleLeft);
 arrValueListForInsert.Add(objGenCtlStyleEN.StyleLeft.ToString());
 }
 
 if (objGenCtlStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.StylePosition);
 var strStylePosition = objGenCtlStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objGenCtlStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.StyleTop);
 arrValueListForInsert.Add(objGenCtlStyleEN.StyleTop.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GenCtlStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsGenCtlStyleEN objGenCtlStyleEN)
{
 if (objGenCtlStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGenCtlStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGenCtlStyleEN.GenCtlStyleId !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.GenCtlStyleId);
 var strGenCtlStyleId = objGenCtlStyleEN.GenCtlStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGenCtlStyleId + "'");
 }
 
 if (objGenCtlStyleEN.GenCtlStyleName !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.GenCtlStyleName);
 var strGenCtlStyleName = objGenCtlStyleEN.GenCtlStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGenCtlStyleName + "'");
 }
 
 if (objGenCtlStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.Style);
 var strStyle = objGenCtlStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objGenCtlStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.Runat);
 var strRunat = objGenCtlStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objGenCtlStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.FontSize);
 var strFontSize = objGenCtlStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objGenCtlStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.FontName);
 var strFontName = objGenCtlStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objGenCtlStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.Width);
 arrValueListForInsert.Add(objGenCtlStyleEN.Width.ToString());
 }
 
 if (objGenCtlStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.Height);
 arrValueListForInsert.Add(objGenCtlStyleEN.Height.ToString());
 }
 
 if (objGenCtlStyleEN.TextMode !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.TextMode);
 var strTextMode = objGenCtlStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextMode + "'");
 }
 
 if (objGenCtlStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.StyleZindex);
 arrValueListForInsert.Add(objGenCtlStyleEN.StyleZindex.ToString());
 }
 
 if (objGenCtlStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.StyleLeft);
 arrValueListForInsert.Add(objGenCtlStyleEN.StyleLeft.ToString());
 }
 
 if (objGenCtlStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.StylePosition);
 var strStylePosition = objGenCtlStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objGenCtlStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.StyleTop);
 arrValueListForInsert.Add(objGenCtlStyleEN.StyleTop.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GenCtlStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objGenCtlStyleEN.GenCtlStyleId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsGenCtlStyleEN objGenCtlStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objGenCtlStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGenCtlStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGenCtlStyleEN.GenCtlStyleId !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.GenCtlStyleId);
 var strGenCtlStyleId = objGenCtlStyleEN.GenCtlStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGenCtlStyleId + "'");
 }
 
 if (objGenCtlStyleEN.GenCtlStyleName !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.GenCtlStyleName);
 var strGenCtlStyleName = objGenCtlStyleEN.GenCtlStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGenCtlStyleName + "'");
 }
 
 if (objGenCtlStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.Style);
 var strStyle = objGenCtlStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objGenCtlStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.Runat);
 var strRunat = objGenCtlStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objGenCtlStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.FontSize);
 var strFontSize = objGenCtlStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objGenCtlStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.FontName);
 var strFontName = objGenCtlStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objGenCtlStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.Width);
 arrValueListForInsert.Add(objGenCtlStyleEN.Width.ToString());
 }
 
 if (objGenCtlStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.Height);
 arrValueListForInsert.Add(objGenCtlStyleEN.Height.ToString());
 }
 
 if (objGenCtlStyleEN.TextMode !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.TextMode);
 var strTextMode = objGenCtlStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextMode + "'");
 }
 
 if (objGenCtlStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.StyleZindex);
 arrValueListForInsert.Add(objGenCtlStyleEN.StyleZindex.ToString());
 }
 
 if (objGenCtlStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.StyleLeft);
 arrValueListForInsert.Add(objGenCtlStyleEN.StyleLeft.ToString());
 }
 
 if (objGenCtlStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.StylePosition);
 var strStylePosition = objGenCtlStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objGenCtlStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.StyleTop);
 arrValueListForInsert.Add(objGenCtlStyleEN.StyleTop.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GenCtlStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objGenCtlStyleEN.GenCtlStyleId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objGenCtlStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsGenCtlStyleEN objGenCtlStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objGenCtlStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objGenCtlStyleEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objGenCtlStyleEN.GenCtlStyleId !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.GenCtlStyleId);
 var strGenCtlStyleId = objGenCtlStyleEN.GenCtlStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGenCtlStyleId + "'");
 }
 
 if (objGenCtlStyleEN.GenCtlStyleName !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.GenCtlStyleName);
 var strGenCtlStyleName = objGenCtlStyleEN.GenCtlStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGenCtlStyleName + "'");
 }
 
 if (objGenCtlStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.Style);
 var strStyle = objGenCtlStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objGenCtlStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.Runat);
 var strRunat = objGenCtlStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objGenCtlStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.FontSize);
 var strFontSize = objGenCtlStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objGenCtlStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.FontName);
 var strFontName = objGenCtlStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objGenCtlStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.Width);
 arrValueListForInsert.Add(objGenCtlStyleEN.Width.ToString());
 }
 
 if (objGenCtlStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.Height);
 arrValueListForInsert.Add(objGenCtlStyleEN.Height.ToString());
 }
 
 if (objGenCtlStyleEN.TextMode !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.TextMode);
 var strTextMode = objGenCtlStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextMode + "'");
 }
 
 if (objGenCtlStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.StyleZindex);
 arrValueListForInsert.Add(objGenCtlStyleEN.StyleZindex.ToString());
 }
 
 if (objGenCtlStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.StyleLeft);
 arrValueListForInsert.Add(objGenCtlStyleEN.StyleLeft.ToString());
 }
 
 if (objGenCtlStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.StylePosition);
 var strStylePosition = objGenCtlStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objGenCtlStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conGenCtlStyle.StyleTop);
 arrValueListForInsert.Add(objGenCtlStyleEN.StyleTop.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into GenCtlStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewGenCtlStyles(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
strSQL = "Select * from GenCtlStyle where GenCtlStyleId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "GenCtlStyle");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strGenCtlStyleId = oRow[conGenCtlStyle.GenCtlStyleId].ToString().Trim();
if (IsExist(strGenCtlStyleId))
{
 string strResult = "关键字变量值为:" + string.Format("GenCtlStyleId = {0}", strGenCtlStyleId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsGenCtlStyleEN._CurrTabName ].NewRow();
objRow[conGenCtlStyle.GenCtlStyleId] = oRow[conGenCtlStyle.GenCtlStyleId].ToString().Trim(); //GenCtlStyleId
objRow[conGenCtlStyle.GenCtlStyleName] = oRow[conGenCtlStyle.GenCtlStyleName].ToString().Trim(); //GenCtlStyleName
objRow[conGenCtlStyle.Style] = oRow[conGenCtlStyle.Style].ToString().Trim(); //类型
objRow[conGenCtlStyle.Runat] = oRow[conGenCtlStyle.Runat].ToString().Trim(); //运行在
objRow[conGenCtlStyle.FontSize] = oRow[conGenCtlStyle.FontSize].ToString().Trim(); //字号
objRow[conGenCtlStyle.FontName] = oRow[conGenCtlStyle.FontName].ToString().Trim(); //字体
objRow[conGenCtlStyle.Width] = oRow[conGenCtlStyle.Width].ToString().Trim(); //宽
objRow[conGenCtlStyle.Height] = oRow[conGenCtlStyle.Height].ToString().Trim(); //高度
objRow[conGenCtlStyle.TextMode] = oRow[conGenCtlStyle.TextMode].ToString().Trim(); //TextMode
objRow[conGenCtlStyle.StyleZindex] = oRow[conGenCtlStyle.StyleZindex].ToString().Trim(); //Style_Zindex
objRow[conGenCtlStyle.StyleLeft] = oRow[conGenCtlStyle.StyleLeft].ToString().Trim(); //Style_Left
objRow[conGenCtlStyle.StylePosition] = oRow[conGenCtlStyle.StylePosition].ToString().Trim(); //Style_Position
objRow[conGenCtlStyle.StyleTop] = oRow[conGenCtlStyle.StyleTop].ToString().Trim(); //Style_Top
 objDS.Tables[clsGenCtlStyleEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsGenCtlStyleEN._CurrTabName);
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
 /// <param name = "objGenCtlStyleEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsGenCtlStyleEN objGenCtlStyleEN)
{
 if (objGenCtlStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGenCtlStyleEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
strSQL = "Select * from GenCtlStyle where GenCtlStyleId = " + "'"+ objGenCtlStyleEN.GenCtlStyleId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsGenCtlStyleEN._CurrTabName);
if (objDS.Tables[clsGenCtlStyleEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:GenCtlStyleId = " + "'"+ objGenCtlStyleEN.GenCtlStyleId+"'");
return false;
}
objRow = objDS.Tables[clsGenCtlStyleEN._CurrTabName].Rows[0];
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.GenCtlStyleId))
 {
objRow[conGenCtlStyle.GenCtlStyleId] = objGenCtlStyleEN.GenCtlStyleId; //GenCtlStyleId
 }
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.GenCtlStyleName))
 {
objRow[conGenCtlStyle.GenCtlStyleName] = objGenCtlStyleEN.GenCtlStyleName; //GenCtlStyleName
 }
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Style))
 {
objRow[conGenCtlStyle.Style] = objGenCtlStyleEN.Style; //类型
 }
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Runat))
 {
objRow[conGenCtlStyle.Runat] = objGenCtlStyleEN.Runat; //运行在
 }
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.FontSize))
 {
objRow[conGenCtlStyle.FontSize] = objGenCtlStyleEN.FontSize; //字号
 }
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.FontName))
 {
objRow[conGenCtlStyle.FontName] = objGenCtlStyleEN.FontName; //字体
 }
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Width))
 {
objRow[conGenCtlStyle.Width] = objGenCtlStyleEN.Width; //宽
 }
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Height))
 {
objRow[conGenCtlStyle.Height] = objGenCtlStyleEN.Height; //高度
 }
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.TextMode))
 {
objRow[conGenCtlStyle.TextMode] = objGenCtlStyleEN.TextMode; //TextMode
 }
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StyleZindex))
 {
objRow[conGenCtlStyle.StyleZindex] = objGenCtlStyleEN.StyleZindex; //Style_Zindex
 }
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StyleLeft))
 {
objRow[conGenCtlStyle.StyleLeft] = objGenCtlStyleEN.StyleLeft; //Style_Left
 }
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StylePosition))
 {
objRow[conGenCtlStyle.StylePosition] = objGenCtlStyleEN.StylePosition; //Style_Position
 }
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StyleTop))
 {
objRow[conGenCtlStyle.StyleTop] = objGenCtlStyleEN.StyleTop; //Style_Top
 }
try
{
objDA.Update(objDS, clsGenCtlStyleEN._CurrTabName);
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
 /// <param name = "objGenCtlStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsGenCtlStyleEN objGenCtlStyleEN)
{
 if (objGenCtlStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGenCtlStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update GenCtlStyle Set ");
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.GenCtlStyleName))
 {
 if (objGenCtlStyleEN.GenCtlStyleName !=  null)
 {
 var strGenCtlStyleName = objGenCtlStyleEN.GenCtlStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGenCtlStyleName, conGenCtlStyle.GenCtlStyleName); //GenCtlStyleName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.GenCtlStyleName); //GenCtlStyleName
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Style))
 {
 if (objGenCtlStyleEN.Style !=  null)
 {
 var strStyle = objGenCtlStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyle, conGenCtlStyle.Style); //类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.Style); //类型
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Runat))
 {
 if (objGenCtlStyleEN.Runat !=  null)
 {
 var strRunat = objGenCtlStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRunat, conGenCtlStyle.Runat); //运行在
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.Runat); //运行在
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.FontSize))
 {
 if (objGenCtlStyleEN.FontSize !=  null)
 {
 var strFontSize = objGenCtlStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontSize, conGenCtlStyle.FontSize); //字号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.FontSize); //字号
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.FontName))
 {
 if (objGenCtlStyleEN.FontName !=  null)
 {
 var strFontName = objGenCtlStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontName, conGenCtlStyle.FontName); //字体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.FontName); //字体
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Width))
 {
 if (objGenCtlStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.Width, conGenCtlStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.Width); //宽
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Height))
 {
 if (objGenCtlStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.Height, conGenCtlStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.Height); //高度
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.TextMode))
 {
 if (objGenCtlStyleEN.TextMode !=  null)
 {
 var strTextMode = objGenCtlStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextMode, conGenCtlStyle.TextMode); //TextMode
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.TextMode); //TextMode
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StyleZindex))
 {
 if (objGenCtlStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.StyleZindex, conGenCtlStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StyleLeft))
 {
 if (objGenCtlStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.StyleLeft, conGenCtlStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StylePosition))
 {
 if (objGenCtlStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objGenCtlStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStylePosition, conGenCtlStyle.StylePosition); //Style_Position
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.StylePosition); //Style_Position
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StyleTop))
 {
 if (objGenCtlStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.StyleTop, conGenCtlStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.StyleTop); //Style_Top
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where GenCtlStyleId = '{0}'", objGenCtlStyleEN.GenCtlStyleId); 
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
 /// <param name = "objGenCtlStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsGenCtlStyleEN objGenCtlStyleEN, string strCondition)
{
 if (objGenCtlStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGenCtlStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GenCtlStyle Set ");
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.GenCtlStyleName))
 {
 if (objGenCtlStyleEN.GenCtlStyleName !=  null)
 {
 var strGenCtlStyleName = objGenCtlStyleEN.GenCtlStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GenCtlStyleName = '{0}',", strGenCtlStyleName); //GenCtlStyleName
 }
 else
 {
 sbSQL.Append(" GenCtlStyleName = null,"); //GenCtlStyleName
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Style))
 {
 if (objGenCtlStyleEN.Style !=  null)
 {
 var strStyle = objGenCtlStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Style = '{0}',", strStyle); //类型
 }
 else
 {
 sbSQL.Append(" Style = null,"); //类型
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Runat))
 {
 if (objGenCtlStyleEN.Runat !=  null)
 {
 var strRunat = objGenCtlStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Runat = '{0}',", strRunat); //运行在
 }
 else
 {
 sbSQL.Append(" Runat = null,"); //运行在
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.FontSize))
 {
 if (objGenCtlStyleEN.FontSize !=  null)
 {
 var strFontSize = objGenCtlStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontSize = '{0}',", strFontSize); //字号
 }
 else
 {
 sbSQL.Append(" FontSize = null,"); //字号
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.FontName))
 {
 if (objGenCtlStyleEN.FontName !=  null)
 {
 var strFontName = objGenCtlStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontName = '{0}',", strFontName); //字体
 }
 else
 {
 sbSQL.Append(" FontName = null,"); //字体
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Width))
 {
 if (objGenCtlStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.Width, conGenCtlStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.Width); //宽
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Height))
 {
 if (objGenCtlStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.Height, conGenCtlStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.Height); //高度
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.TextMode))
 {
 if (objGenCtlStyleEN.TextMode !=  null)
 {
 var strTextMode = objGenCtlStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextMode = '{0}',", strTextMode); //TextMode
 }
 else
 {
 sbSQL.Append(" TextMode = null,"); //TextMode
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StyleZindex))
 {
 if (objGenCtlStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.StyleZindex, conGenCtlStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StyleLeft))
 {
 if (objGenCtlStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.StyleLeft, conGenCtlStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StylePosition))
 {
 if (objGenCtlStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objGenCtlStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StylePosition = '{0}',", strStylePosition); //Style_Position
 }
 else
 {
 sbSQL.Append(" StylePosition = null,"); //Style_Position
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StyleTop))
 {
 if (objGenCtlStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.StyleTop, conGenCtlStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.StyleTop); //Style_Top
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
 /// <param name = "objGenCtlStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsGenCtlStyleEN objGenCtlStyleEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objGenCtlStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGenCtlStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GenCtlStyle Set ");
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.GenCtlStyleName))
 {
 if (objGenCtlStyleEN.GenCtlStyleName !=  null)
 {
 var strGenCtlStyleName = objGenCtlStyleEN.GenCtlStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GenCtlStyleName = '{0}',", strGenCtlStyleName); //GenCtlStyleName
 }
 else
 {
 sbSQL.Append(" GenCtlStyleName = null,"); //GenCtlStyleName
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Style))
 {
 if (objGenCtlStyleEN.Style !=  null)
 {
 var strStyle = objGenCtlStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Style = '{0}',", strStyle); //类型
 }
 else
 {
 sbSQL.Append(" Style = null,"); //类型
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Runat))
 {
 if (objGenCtlStyleEN.Runat !=  null)
 {
 var strRunat = objGenCtlStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Runat = '{0}',", strRunat); //运行在
 }
 else
 {
 sbSQL.Append(" Runat = null,"); //运行在
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.FontSize))
 {
 if (objGenCtlStyleEN.FontSize !=  null)
 {
 var strFontSize = objGenCtlStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontSize = '{0}',", strFontSize); //字号
 }
 else
 {
 sbSQL.Append(" FontSize = null,"); //字号
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.FontName))
 {
 if (objGenCtlStyleEN.FontName !=  null)
 {
 var strFontName = objGenCtlStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontName = '{0}',", strFontName); //字体
 }
 else
 {
 sbSQL.Append(" FontName = null,"); //字体
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Width))
 {
 if (objGenCtlStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.Width, conGenCtlStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.Width); //宽
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Height))
 {
 if (objGenCtlStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.Height, conGenCtlStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.Height); //高度
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.TextMode))
 {
 if (objGenCtlStyleEN.TextMode !=  null)
 {
 var strTextMode = objGenCtlStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextMode = '{0}',", strTextMode); //TextMode
 }
 else
 {
 sbSQL.Append(" TextMode = null,"); //TextMode
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StyleZindex))
 {
 if (objGenCtlStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.StyleZindex, conGenCtlStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StyleLeft))
 {
 if (objGenCtlStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.StyleLeft, conGenCtlStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StylePosition))
 {
 if (objGenCtlStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objGenCtlStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StylePosition = '{0}',", strStylePosition); //Style_Position
 }
 else
 {
 sbSQL.Append(" StylePosition = null,"); //Style_Position
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StyleTop))
 {
 if (objGenCtlStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.StyleTop, conGenCtlStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.StyleTop); //Style_Top
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
 /// <param name = "objGenCtlStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsGenCtlStyleEN objGenCtlStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objGenCtlStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objGenCtlStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update GenCtlStyle Set ");
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.GenCtlStyleName))
 {
 if (objGenCtlStyleEN.GenCtlStyleName !=  null)
 {
 var strGenCtlStyleName = objGenCtlStyleEN.GenCtlStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGenCtlStyleName, conGenCtlStyle.GenCtlStyleName); //GenCtlStyleName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.GenCtlStyleName); //GenCtlStyleName
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Style))
 {
 if (objGenCtlStyleEN.Style !=  null)
 {
 var strStyle = objGenCtlStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyle, conGenCtlStyle.Style); //类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.Style); //类型
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Runat))
 {
 if (objGenCtlStyleEN.Runat !=  null)
 {
 var strRunat = objGenCtlStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRunat, conGenCtlStyle.Runat); //运行在
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.Runat); //运行在
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.FontSize))
 {
 if (objGenCtlStyleEN.FontSize !=  null)
 {
 var strFontSize = objGenCtlStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontSize, conGenCtlStyle.FontSize); //字号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.FontSize); //字号
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.FontName))
 {
 if (objGenCtlStyleEN.FontName !=  null)
 {
 var strFontName = objGenCtlStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontName, conGenCtlStyle.FontName); //字体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.FontName); //字体
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Width))
 {
 if (objGenCtlStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.Width, conGenCtlStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.Width); //宽
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.Height))
 {
 if (objGenCtlStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.Height, conGenCtlStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.Height); //高度
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.TextMode))
 {
 if (objGenCtlStyleEN.TextMode !=  null)
 {
 var strTextMode = objGenCtlStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextMode, conGenCtlStyle.TextMode); //TextMode
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.TextMode); //TextMode
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StyleZindex))
 {
 if (objGenCtlStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.StyleZindex, conGenCtlStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StyleLeft))
 {
 if (objGenCtlStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.StyleLeft, conGenCtlStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StylePosition))
 {
 if (objGenCtlStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objGenCtlStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStylePosition, conGenCtlStyle.StylePosition); //Style_Position
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.StylePosition); //Style_Position
 }
 }
 
 if (objGenCtlStyleEN.IsUpdated(conGenCtlStyle.StyleTop))
 {
 if (objGenCtlStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objGenCtlStyleEN.StyleTop, conGenCtlStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conGenCtlStyle.StyleTop); //Style_Top
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where GenCtlStyleId = '{0}'", objGenCtlStyleEN.GenCtlStyleId); 
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
 /// <param name = "strGenCtlStyleId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strGenCtlStyleId) 
{
CheckPrimaryKey(strGenCtlStyleId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strGenCtlStyleId,
};
 objSQL.ExecSP("GenCtlStyle_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strGenCtlStyleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strGenCtlStyleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strGenCtlStyleId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
//删除GenCtlStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GenCtlStyle where GenCtlStyleId = " + "'"+ strGenCtlStyleId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelGenCtlStyle(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
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
//删除GenCtlStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GenCtlStyle where GenCtlStyleId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strGenCtlStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strGenCtlStyleId) 
{
CheckPrimaryKey(strGenCtlStyleId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
//删除GenCtlStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from GenCtlStyle where GenCtlStyleId = " + "'"+ strGenCtlStyleId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelGenCtlStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsGenCtlStyleDA: DelGenCtlStyle)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from GenCtlStyle where " + strCondition ;
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
public bool DelGenCtlStyleWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsGenCtlStyleDA: DelGenCtlStyleWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from GenCtlStyle where " + strCondition ;
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
 /// <param name = "objGenCtlStyleENS">源对象</param>
 /// <param name = "objGenCtlStyleENT">目标对象</param>
public void CopyTo(clsGenCtlStyleEN objGenCtlStyleENS, clsGenCtlStyleEN objGenCtlStyleENT)
{
objGenCtlStyleENT.GenCtlStyleId = objGenCtlStyleENS.GenCtlStyleId; //GenCtlStyleId
objGenCtlStyleENT.GenCtlStyleName = objGenCtlStyleENS.GenCtlStyleName; //GenCtlStyleName
objGenCtlStyleENT.Style = objGenCtlStyleENS.Style; //类型
objGenCtlStyleENT.Runat = objGenCtlStyleENS.Runat; //运行在
objGenCtlStyleENT.FontSize = objGenCtlStyleENS.FontSize; //字号
objGenCtlStyleENT.FontName = objGenCtlStyleENS.FontName; //字体
objGenCtlStyleENT.Width = objGenCtlStyleENS.Width; //宽
objGenCtlStyleENT.Height = objGenCtlStyleENS.Height; //高度
objGenCtlStyleENT.TextMode = objGenCtlStyleENS.TextMode; //TextMode
objGenCtlStyleENT.StyleZindex = objGenCtlStyleENS.StyleZindex; //Style_Zindex
objGenCtlStyleENT.StyleLeft = objGenCtlStyleENS.StyleLeft; //Style_Left
objGenCtlStyleENT.StylePosition = objGenCtlStyleENS.StylePosition; //Style_Position
objGenCtlStyleENT.StyleTop = objGenCtlStyleENS.StyleTop; //Style_Top
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsGenCtlStyleEN objGenCtlStyleEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objGenCtlStyleEN.GenCtlStyleName, conGenCtlStyle.GenCtlStyleName);
clsCheckSql.CheckFieldNotNull(objGenCtlStyleEN.TextMode, conGenCtlStyle.TextMode);
//检查字段长度
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.GenCtlStyleId, 4, conGenCtlStyle.GenCtlStyleId);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.GenCtlStyleName, 30, conGenCtlStyle.GenCtlStyleName);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.Style, 800, conGenCtlStyle.Style);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.Runat, 30, conGenCtlStyle.Runat);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.FontSize, 20, conGenCtlStyle.FontSize);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.FontName, 20, conGenCtlStyle.FontName);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.TextMode, 20, conGenCtlStyle.TextMode);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.StylePosition, 20, conGenCtlStyle.StylePosition);
//检查字段外键固定长度
 objGenCtlStyleEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsGenCtlStyleEN objGenCtlStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.GenCtlStyleName, 30, conGenCtlStyle.GenCtlStyleName);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.Style, 800, conGenCtlStyle.Style);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.Runat, 30, conGenCtlStyle.Runat);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.FontSize, 20, conGenCtlStyle.FontSize);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.FontName, 20, conGenCtlStyle.FontName);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.TextMode, 20, conGenCtlStyle.TextMode);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.StylePosition, 20, conGenCtlStyle.StylePosition);
//检查外键字段长度
 objGenCtlStyleEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsGenCtlStyleEN objGenCtlStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.GenCtlStyleId, 4, conGenCtlStyle.GenCtlStyleId);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.GenCtlStyleName, 30, conGenCtlStyle.GenCtlStyleName);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.Style, 800, conGenCtlStyle.Style);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.Runat, 30, conGenCtlStyle.Runat);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.FontSize, 20, conGenCtlStyle.FontSize);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.FontName, 20, conGenCtlStyle.FontName);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.TextMode, 20, conGenCtlStyle.TextMode);
clsCheckSql.CheckFieldLen(objGenCtlStyleEN.StylePosition, 20, conGenCtlStyle.StylePosition);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objGenCtlStyleEN.GenCtlStyleId, conGenCtlStyle.GenCtlStyleId);
clsCheckSql.CheckSqlInjection4Field(objGenCtlStyleEN.GenCtlStyleName, conGenCtlStyle.GenCtlStyleName);
clsCheckSql.CheckSqlInjection4Field(objGenCtlStyleEN.Style, conGenCtlStyle.Style);
clsCheckSql.CheckSqlInjection4Field(objGenCtlStyleEN.Runat, conGenCtlStyle.Runat);
clsCheckSql.CheckSqlInjection4Field(objGenCtlStyleEN.FontSize, conGenCtlStyle.FontSize);
clsCheckSql.CheckSqlInjection4Field(objGenCtlStyleEN.FontName, conGenCtlStyle.FontName);
clsCheckSql.CheckSqlInjection4Field(objGenCtlStyleEN.TextMode, conGenCtlStyle.TextMode);
clsCheckSql.CheckSqlInjection4Field(objGenCtlStyleEN.StylePosition, conGenCtlStyle.StylePosition);
//检查外键字段长度
 objGenCtlStyleEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetGenCtlStyleId()
{
//获取某学院所有专业信息
string strSQL = "select GenCtlStyleId, GenCtlStyleName from GenCtlStyle ";
 clsSpecSQLforSql mySql = clsGenCtlStyleDA.GetSpecSQLObj();
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
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
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
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
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
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsGenCtlStyleEN._CurrTabName);
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
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsGenCtlStyleEN._CurrTabName, strCondition);
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
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
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
 objSQL = clsGenCtlStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}