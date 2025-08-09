
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataGridStyleDA
 表名:DataGridStyle(00050005)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:27
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// DataGrid类型(DataGridStyle)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsDataGridStyleDA : clsCommBase4DA
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
 return clsDataGridStyleEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsDataGridStyleEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDataGridStyleEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsDataGridStyleEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsDataGridStyleEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strDgStyleId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strDgStyleId)
{
strDgStyleId = strDgStyleId.Replace("'", "''");
if (strDgStyleId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:DataGridStyle中,检查关键字,长度不正确!(clsDataGridStyleDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDgStyleId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:DataGridStyle中,关键字不能为空 或 null!(clsDataGridStyleDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDgStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsDataGridStyleDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsDataGridStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
strSQL = "Select * from DataGridStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_DataGridStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsDataGridStyleDA: GetDataTable_DataGridStyle)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
strSQL = "Select * from DataGridStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsDataGridStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsDataGridStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
strSQL = "Select * from DataGridStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsDataGridStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsDataGridStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataGridStyle where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataGridStyle where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsDataGridStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DataGridStyle where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsDataGridStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DataGridStyle.* " + 
$"from DataGridStyle " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DataGridStyle.DgStyleId not in " + 
$"(Select top {intTop_In} DataGridStyle.DgStyleId from DataGridStyle " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataGridStyle where {1} and DgStyleId not in (Select top {2} DgStyleId from DataGridStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataGridStyle where {1} and DgStyleId not in (Select top {3} DgStyleId from DataGridStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsDataGridStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DataGridStyle.* " + 
$"from DataGridStyle " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DataGridStyle.DgStyleId not in " + 
$"(Select top {intTop_In} DataGridStyle.DgStyleId from DataGridStyle " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataGridStyle where {1} and DgStyleId not in (Select top {2} DgStyleId from DataGridStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataGridStyle where {1} and DgStyleId not in (Select top {3} DgStyleId from DataGridStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsDataGridStyleEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsDataGridStyleDA:GetObjLst)", objException.Message));
}
List<clsDataGridStyleEN> arrObjLst = new List<clsDataGridStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
strSQL = "Select * from DataGridStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataGridStyleEN objDataGridStyleEN = new clsDataGridStyleEN();
try
{
objDataGridStyleEN.DgStyleId = objRow[conDataGridStyle.DgStyleId].ToString().Trim(); //DG模式ID
objDataGridStyleEN.DgStyleName = objRow[conDataGridStyle.DgStyleName].ToString().Trim(); //DG模式名
objDataGridStyleEN.Runat = objRow[conDataGridStyle.Runat] == DBNull.Value ? null : objRow[conDataGridStyle.Runat].ToString().Trim(); //运行在
objDataGridStyleEN.FontSize = objRow[conDataGridStyle.FontSize] == DBNull.Value ? null : objRow[conDataGridStyle.FontSize].ToString().Trim(); //字号
objDataGridStyleEN.FontName = objRow[conDataGridStyle.FontName] == DBNull.Value ? null : objRow[conDataGridStyle.FontName].ToString().Trim(); //字体
objDataGridStyleEN.AllowPaging = TransNullToBool(objRow[conDataGridStyle.AllowPaging].ToString().Trim()); //允许分页
objDataGridStyleEN.PageSize = objRow[conDataGridStyle.PageSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.PageSize].ToString().Trim()); //页大小
objDataGridStyleEN.AutoGenerateColumns = TransNullToBool(objRow[conDataGridStyle.AutoGenerateColumns].ToString().Trim()); //自动生成列
objDataGridStyleEN.AllowSorting = TransNullToBool(objRow[conDataGridStyle.AllowSorting].ToString().Trim()); //允许排序
objDataGridStyleEN.IsRadio = TransNullToBool(objRow[conDataGridStyle.IsRadio].ToString().Trim()); //是否单选框
objDataGridStyleEN.IsCheck = TransNullToBool(objRow[conDataGridStyle.IsCheck].ToString().Trim()); //是否复选框
objDataGridStyleEN.IsJumpPage = TransNullToBool(objRow[conDataGridStyle.IsJumpPage].ToString().Trim()); //是否跳页
objDataGridStyleEN.IsHaveUpdBtn = TransNullToBool(objRow[conDataGridStyle.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objDataGridStyleEN.IsHaveDelBtn = TransNullToBool(objRow[conDataGridStyle.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objDataGridStyleEN.IsHaveDetailBtn = TransNullToBool(objRow[conDataGridStyle.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objDataGridStyleEN.IsInTab = TransNullToBool(objRow[conDataGridStyle.IsInTab].ToString().Trim()); //是否生成DG在表中
objDataGridStyleEN.StyleZindex = objRow[conDataGridStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDataGridStyleEN.StyleLeft = objRow[conDataGridStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.StyleLeft].ToString().Trim()); //Style_Left
objDataGridStyleEN.StylePosition = objRow[conDataGridStyle.StylePosition] == DBNull.Value ? null : objRow[conDataGridStyle.StylePosition].ToString().Trim(); //Style_Position
objDataGridStyleEN.Width = objRow[conDataGridStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.Width].ToString().Trim()); //宽
objDataGridStyleEN.Height = objRow[conDataGridStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.Height].ToString().Trim()); //高度
objDataGridStyleEN.StyleTop = objRow[conDataGridStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.StyleTop].ToString().Trim()); //Style_Top
objDataGridStyleEN.Style = objRow[conDataGridStyle.Style] == DBNull.Value ? null : objRow[conDataGridStyle.Style].ToString().Trim(); //类型
objDataGridStyleEN.IsDefault = TransNullToBool(objRow[conDataGridStyle.IsDefault].ToString().Trim()); //是否默认
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDataGridStyleDA: GetObjLst)", objException.Message));
}
objDataGridStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDataGridStyleEN);
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
public List<clsDataGridStyleEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsDataGridStyleDA:GetObjLstByTabName)", objException.Message));
}
List<clsDataGridStyleEN> arrObjLst = new List<clsDataGridStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataGridStyleEN objDataGridStyleEN = new clsDataGridStyleEN();
try
{
objDataGridStyleEN.DgStyleId = objRow[conDataGridStyle.DgStyleId].ToString().Trim(); //DG模式ID
objDataGridStyleEN.DgStyleName = objRow[conDataGridStyle.DgStyleName].ToString().Trim(); //DG模式名
objDataGridStyleEN.Runat = objRow[conDataGridStyle.Runat] == DBNull.Value ? null : objRow[conDataGridStyle.Runat].ToString().Trim(); //运行在
objDataGridStyleEN.FontSize = objRow[conDataGridStyle.FontSize] == DBNull.Value ? null : objRow[conDataGridStyle.FontSize].ToString().Trim(); //字号
objDataGridStyleEN.FontName = objRow[conDataGridStyle.FontName] == DBNull.Value ? null : objRow[conDataGridStyle.FontName].ToString().Trim(); //字体
objDataGridStyleEN.AllowPaging = TransNullToBool(objRow[conDataGridStyle.AllowPaging].ToString().Trim()); //允许分页
objDataGridStyleEN.PageSize = objRow[conDataGridStyle.PageSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.PageSize].ToString().Trim()); //页大小
objDataGridStyleEN.AutoGenerateColumns = TransNullToBool(objRow[conDataGridStyle.AutoGenerateColumns].ToString().Trim()); //自动生成列
objDataGridStyleEN.AllowSorting = TransNullToBool(objRow[conDataGridStyle.AllowSorting].ToString().Trim()); //允许排序
objDataGridStyleEN.IsRadio = TransNullToBool(objRow[conDataGridStyle.IsRadio].ToString().Trim()); //是否单选框
objDataGridStyleEN.IsCheck = TransNullToBool(objRow[conDataGridStyle.IsCheck].ToString().Trim()); //是否复选框
objDataGridStyleEN.IsJumpPage = TransNullToBool(objRow[conDataGridStyle.IsJumpPage].ToString().Trim()); //是否跳页
objDataGridStyleEN.IsHaveUpdBtn = TransNullToBool(objRow[conDataGridStyle.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objDataGridStyleEN.IsHaveDelBtn = TransNullToBool(objRow[conDataGridStyle.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objDataGridStyleEN.IsHaveDetailBtn = TransNullToBool(objRow[conDataGridStyle.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objDataGridStyleEN.IsInTab = TransNullToBool(objRow[conDataGridStyle.IsInTab].ToString().Trim()); //是否生成DG在表中
objDataGridStyleEN.StyleZindex = objRow[conDataGridStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDataGridStyleEN.StyleLeft = objRow[conDataGridStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.StyleLeft].ToString().Trim()); //Style_Left
objDataGridStyleEN.StylePosition = objRow[conDataGridStyle.StylePosition] == DBNull.Value ? null : objRow[conDataGridStyle.StylePosition].ToString().Trim(); //Style_Position
objDataGridStyleEN.Width = objRow[conDataGridStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.Width].ToString().Trim()); //宽
objDataGridStyleEN.Height = objRow[conDataGridStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.Height].ToString().Trim()); //高度
objDataGridStyleEN.StyleTop = objRow[conDataGridStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.StyleTop].ToString().Trim()); //Style_Top
objDataGridStyleEN.Style = objRow[conDataGridStyle.Style] == DBNull.Value ? null : objRow[conDataGridStyle.Style].ToString().Trim(); //类型
objDataGridStyleEN.IsDefault = TransNullToBool(objRow[conDataGridStyle.IsDefault].ToString().Trim()); //是否默认
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDataGridStyleDA: GetObjLst)", objException.Message));
}
objDataGridStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDataGridStyleEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDataGridStyle(ref clsDataGridStyleEN objDataGridStyleEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
strSQL = "Select * from DataGridStyle where DgStyleId = " + "'"+ objDataGridStyleEN.DgStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objDataGridStyleEN.DgStyleId = objDT.Rows[0][conDataGridStyle.DgStyleId].ToString().Trim(); //DG模式ID(字段类型:varchar,字段长度:4,是否可空:False)
 objDataGridStyleEN.DgStyleName = objDT.Rows[0][conDataGridStyle.DgStyleName].ToString().Trim(); //DG模式名(字段类型:varchar,字段长度:30,是否可空:False)
 objDataGridStyleEN.Runat = objDT.Rows[0][conDataGridStyle.Runat].ToString().Trim(); //运行在(字段类型:varchar,字段长度:30,是否可空:True)
 objDataGridStyleEN.FontSize = objDT.Rows[0][conDataGridStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objDataGridStyleEN.FontName = objDT.Rows[0][conDataGridStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objDataGridStyleEN.AllowPaging = TransNullToBool(objDT.Rows[0][conDataGridStyle.AllowPaging].ToString().Trim()); //允许分页(字段类型:bit,字段长度:1,是否可空:False)
 objDataGridStyleEN.PageSize = TransNullToInt(objDT.Rows[0][conDataGridStyle.PageSize].ToString().Trim()); //页大小(字段类型:int,字段长度:4,是否可空:True)
 objDataGridStyleEN.AutoGenerateColumns = TransNullToBool(objDT.Rows[0][conDataGridStyle.AutoGenerateColumns].ToString().Trim()); //自动生成列(字段类型:bit,字段长度:1,是否可空:False)
 objDataGridStyleEN.AllowSorting = TransNullToBool(objDT.Rows[0][conDataGridStyle.AllowSorting].ToString().Trim()); //允许排序(字段类型:bit,字段长度:1,是否可空:False)
 objDataGridStyleEN.IsRadio = TransNullToBool(objDT.Rows[0][conDataGridStyle.IsRadio].ToString().Trim()); //是否单选框(字段类型:bit,字段长度:1,是否可空:True)
 objDataGridStyleEN.IsCheck = TransNullToBool(objDT.Rows[0][conDataGridStyle.IsCheck].ToString().Trim()); //是否复选框(字段类型:bit,字段长度:1,是否可空:True)
 objDataGridStyleEN.IsJumpPage = TransNullToBool(objDT.Rows[0][conDataGridStyle.IsJumpPage].ToString().Trim()); //是否跳页(字段类型:bit,字段长度:1,是否可空:True)
 objDataGridStyleEN.IsHaveUpdBtn = TransNullToBool(objDT.Rows[0][conDataGridStyle.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮(字段类型:bit,字段长度:1,是否可空:True)
 objDataGridStyleEN.IsHaveDelBtn = TransNullToBool(objDT.Rows[0][conDataGridStyle.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮(字段类型:bit,字段长度:1,是否可空:True)
 objDataGridStyleEN.IsHaveDetailBtn = TransNullToBool(objDT.Rows[0][conDataGridStyle.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮(字段类型:bit,字段长度:1,是否可空:True)
 objDataGridStyleEN.IsInTab = TransNullToBool(objDT.Rows[0][conDataGridStyle.IsInTab].ToString().Trim()); //是否生成DG在表中(字段类型:bit,字段长度:1,是否可空:True)
 objDataGridStyleEN.StyleZindex = TransNullToInt(objDT.Rows[0][conDataGridStyle.StyleZindex].ToString().Trim()); //Style_Zindex(字段类型:int,字段长度:4,是否可空:True)
 objDataGridStyleEN.StyleLeft = TransNullToInt(objDT.Rows[0][conDataGridStyle.StyleLeft].ToString().Trim()); //Style_Left(字段类型:int,字段长度:4,是否可空:True)
 objDataGridStyleEN.StylePosition = objDT.Rows[0][conDataGridStyle.StylePosition].ToString().Trim(); //Style_Position(字段类型:varchar,字段长度:20,是否可空:True)
 objDataGridStyleEN.Width = TransNullToInt(objDT.Rows[0][conDataGridStyle.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objDataGridStyleEN.Height = TransNullToInt(objDT.Rows[0][conDataGridStyle.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objDataGridStyleEN.StyleTop = TransNullToInt(objDT.Rows[0][conDataGridStyle.StyleTop].ToString().Trim()); //Style_Top(字段类型:int,字段长度:4,是否可空:True)
 objDataGridStyleEN.Style = objDT.Rows[0][conDataGridStyle.Style].ToString().Trim(); //类型(字段类型:varchar,字段长度:800,是否可空:True)
 objDataGridStyleEN.IsDefault = TransNullToBool(objDT.Rows[0][conDataGridStyle.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsDataGridStyleDA: GetDataGridStyle)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDgStyleId">表关键字</param>
 /// <returns>表对象</returns>
public clsDataGridStyleEN GetObjByDgStyleId(string strDgStyleId)
{
CheckPrimaryKey(strDgStyleId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
strSQL = "Select * from DataGridStyle where DgStyleId = " + "'"+ strDgStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsDataGridStyleEN objDataGridStyleEN = new clsDataGridStyleEN();
try
{
 objDataGridStyleEN.DgStyleId = objRow[conDataGridStyle.DgStyleId].ToString().Trim(); //DG模式ID(字段类型:varchar,字段长度:4,是否可空:False)
 objDataGridStyleEN.DgStyleName = objRow[conDataGridStyle.DgStyleName].ToString().Trim(); //DG模式名(字段类型:varchar,字段长度:30,是否可空:False)
 objDataGridStyleEN.Runat = objRow[conDataGridStyle.Runat] == DBNull.Value ? null : objRow[conDataGridStyle.Runat].ToString().Trim(); //运行在(字段类型:varchar,字段长度:30,是否可空:True)
 objDataGridStyleEN.FontSize = objRow[conDataGridStyle.FontSize] == DBNull.Value ? null : objRow[conDataGridStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objDataGridStyleEN.FontName = objRow[conDataGridStyle.FontName] == DBNull.Value ? null : objRow[conDataGridStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objDataGridStyleEN.AllowPaging = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowPaging].ToString().Trim()); //允许分页(字段类型:bit,字段长度:1,是否可空:False)
 objDataGridStyleEN.PageSize = objRow[conDataGridStyle.PageSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.PageSize].ToString().Trim()); //页大小(字段类型:int,字段长度:4,是否可空:True)
 objDataGridStyleEN.AutoGenerateColumns = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AutoGenerateColumns].ToString().Trim()); //自动生成列(字段类型:bit,字段长度:1,是否可空:False)
 objDataGridStyleEN.AllowSorting = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.AllowSorting].ToString().Trim()); //允许排序(字段类型:bit,字段长度:1,是否可空:False)
 objDataGridStyleEN.IsRadio = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsRadio].ToString().Trim()); //是否单选框(字段类型:bit,字段长度:1,是否可空:True)
 objDataGridStyleEN.IsCheck = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsCheck].ToString().Trim()); //是否复选框(字段类型:bit,字段长度:1,是否可空:True)
 objDataGridStyleEN.IsJumpPage = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsJumpPage].ToString().Trim()); //是否跳页(字段类型:bit,字段长度:1,是否可空:True)
 objDataGridStyleEN.IsHaveUpdBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮(字段类型:bit,字段长度:1,是否可空:True)
 objDataGridStyleEN.IsHaveDelBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮(字段类型:bit,字段长度:1,是否可空:True)
 objDataGridStyleEN.IsHaveDetailBtn = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮(字段类型:bit,字段长度:1,是否可空:True)
 objDataGridStyleEN.IsInTab = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsInTab].ToString().Trim()); //是否生成DG在表中(字段类型:bit,字段长度:1,是否可空:True)
 objDataGridStyleEN.StyleZindex = objRow[conDataGridStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleZindex].ToString().Trim()); //Style_Zindex(字段类型:int,字段长度:4,是否可空:True)
 objDataGridStyleEN.StyleLeft = objRow[conDataGridStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleLeft].ToString().Trim()); //Style_Left(字段类型:int,字段长度:4,是否可空:True)
 objDataGridStyleEN.StylePosition = objRow[conDataGridStyle.StylePosition] == DBNull.Value ? null : objRow[conDataGridStyle.StylePosition].ToString().Trim(); //Style_Position(字段类型:varchar,字段长度:20,是否可空:True)
 objDataGridStyleEN.Width = objRow[conDataGridStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objDataGridStyleEN.Height = objRow[conDataGridStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objDataGridStyleEN.StyleTop = objRow[conDataGridStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataGridStyle.StyleTop].ToString().Trim()); //Style_Top(字段类型:int,字段长度:4,是否可空:True)
 objDataGridStyleEN.Style = objRow[conDataGridStyle.Style] == DBNull.Value ? null : objRow[conDataGridStyle.Style].ToString().Trim(); //类型(字段类型:varchar,字段长度:800,是否可空:True)
 objDataGridStyleEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conDataGridStyle.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsDataGridStyleDA: GetObjByDgStyleId)", objException.Message));
}
return objDataGridStyleEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDataGridStyleEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsDataGridStyleDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
strSQL = "Select * from DataGridStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsDataGridStyleEN objDataGridStyleEN = new clsDataGridStyleEN()
{
DgStyleId = objRow[conDataGridStyle.DgStyleId].ToString().Trim(), //DG模式ID
DgStyleName = objRow[conDataGridStyle.DgStyleName].ToString().Trim(), //DG模式名
Runat = objRow[conDataGridStyle.Runat] == DBNull.Value ? null : objRow[conDataGridStyle.Runat].ToString().Trim(), //运行在
FontSize = objRow[conDataGridStyle.FontSize] == DBNull.Value ? null : objRow[conDataGridStyle.FontSize].ToString().Trim(), //字号
FontName = objRow[conDataGridStyle.FontName] == DBNull.Value ? null : objRow[conDataGridStyle.FontName].ToString().Trim(), //字体
AllowPaging = TransNullToBool(objRow[conDataGridStyle.AllowPaging].ToString().Trim()), //允许分页
PageSize = objRow[conDataGridStyle.PageSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.PageSize].ToString().Trim()), //页大小
AutoGenerateColumns = TransNullToBool(objRow[conDataGridStyle.AutoGenerateColumns].ToString().Trim()), //自动生成列
AllowSorting = TransNullToBool(objRow[conDataGridStyle.AllowSorting].ToString().Trim()), //允许排序
IsRadio = TransNullToBool(objRow[conDataGridStyle.IsRadio].ToString().Trim()), //是否单选框
IsCheck = TransNullToBool(objRow[conDataGridStyle.IsCheck].ToString().Trim()), //是否复选框
IsJumpPage = TransNullToBool(objRow[conDataGridStyle.IsJumpPage].ToString().Trim()), //是否跳页
IsHaveUpdBtn = TransNullToBool(objRow[conDataGridStyle.IsHaveUpdBtn].ToString().Trim()), //是否有修改按钮
IsHaveDelBtn = TransNullToBool(objRow[conDataGridStyle.IsHaveDelBtn].ToString().Trim()), //是否有删除按钮
IsHaveDetailBtn = TransNullToBool(objRow[conDataGridStyle.IsHaveDetailBtn].ToString().Trim()), //是否有详细按钮
IsInTab = TransNullToBool(objRow[conDataGridStyle.IsInTab].ToString().Trim()), //是否生成DG在表中
StyleZindex = objRow[conDataGridStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.StyleZindex].ToString().Trim()), //Style_Zindex
StyleLeft = objRow[conDataGridStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.StyleLeft].ToString().Trim()), //Style_Left
StylePosition = objRow[conDataGridStyle.StylePosition] == DBNull.Value ? null : objRow[conDataGridStyle.StylePosition].ToString().Trim(), //Style_Position
Width = objRow[conDataGridStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.Width].ToString().Trim()), //宽
Height = objRow[conDataGridStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.Height].ToString().Trim()), //高度
StyleTop = objRow[conDataGridStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.StyleTop].ToString().Trim()), //Style_Top
Style = objRow[conDataGridStyle.Style] == DBNull.Value ? null : objRow[conDataGridStyle.Style].ToString().Trim(), //类型
IsDefault = TransNullToBool(objRow[conDataGridStyle.IsDefault].ToString().Trim()) //是否默认
};
objDataGridStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataGridStyleEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsDataGridStyleDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsDataGridStyleEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDataGridStyleEN objDataGridStyleEN = new clsDataGridStyleEN();
try
{
objDataGridStyleEN.DgStyleId = objRow[conDataGridStyle.DgStyleId].ToString().Trim(); //DG模式ID
objDataGridStyleEN.DgStyleName = objRow[conDataGridStyle.DgStyleName].ToString().Trim(); //DG模式名
objDataGridStyleEN.Runat = objRow[conDataGridStyle.Runat] == DBNull.Value ? null : objRow[conDataGridStyle.Runat].ToString().Trim(); //运行在
objDataGridStyleEN.FontSize = objRow[conDataGridStyle.FontSize] == DBNull.Value ? null : objRow[conDataGridStyle.FontSize].ToString().Trim(); //字号
objDataGridStyleEN.FontName = objRow[conDataGridStyle.FontName] == DBNull.Value ? null : objRow[conDataGridStyle.FontName].ToString().Trim(); //字体
objDataGridStyleEN.AllowPaging = TransNullToBool(objRow[conDataGridStyle.AllowPaging].ToString().Trim()); //允许分页
objDataGridStyleEN.PageSize = objRow[conDataGridStyle.PageSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.PageSize].ToString().Trim()); //页大小
objDataGridStyleEN.AutoGenerateColumns = TransNullToBool(objRow[conDataGridStyle.AutoGenerateColumns].ToString().Trim()); //自动生成列
objDataGridStyleEN.AllowSorting = TransNullToBool(objRow[conDataGridStyle.AllowSorting].ToString().Trim()); //允许排序
objDataGridStyleEN.IsRadio = TransNullToBool(objRow[conDataGridStyle.IsRadio].ToString().Trim()); //是否单选框
objDataGridStyleEN.IsCheck = TransNullToBool(objRow[conDataGridStyle.IsCheck].ToString().Trim()); //是否复选框
objDataGridStyleEN.IsJumpPage = TransNullToBool(objRow[conDataGridStyle.IsJumpPage].ToString().Trim()); //是否跳页
objDataGridStyleEN.IsHaveUpdBtn = TransNullToBool(objRow[conDataGridStyle.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objDataGridStyleEN.IsHaveDelBtn = TransNullToBool(objRow[conDataGridStyle.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objDataGridStyleEN.IsHaveDetailBtn = TransNullToBool(objRow[conDataGridStyle.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objDataGridStyleEN.IsInTab = TransNullToBool(objRow[conDataGridStyle.IsInTab].ToString().Trim()); //是否生成DG在表中
objDataGridStyleEN.StyleZindex = objRow[conDataGridStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDataGridStyleEN.StyleLeft = objRow[conDataGridStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.StyleLeft].ToString().Trim()); //Style_Left
objDataGridStyleEN.StylePosition = objRow[conDataGridStyle.StylePosition] == DBNull.Value ? null : objRow[conDataGridStyle.StylePosition].ToString().Trim(); //Style_Position
objDataGridStyleEN.Width = objRow[conDataGridStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.Width].ToString().Trim()); //宽
objDataGridStyleEN.Height = objRow[conDataGridStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.Height].ToString().Trim()); //高度
objDataGridStyleEN.StyleTop = objRow[conDataGridStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.StyleTop].ToString().Trim()); //Style_Top
objDataGridStyleEN.Style = objRow[conDataGridStyle.Style] == DBNull.Value ? null : objRow[conDataGridStyle.Style].ToString().Trim(); //类型
objDataGridStyleEN.IsDefault = TransNullToBool(objRow[conDataGridStyle.IsDefault].ToString().Trim()); //是否默认
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsDataGridStyleDA: GetObjByDataRowDataGridStyle)", objException.Message));
}
objDataGridStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataGridStyleEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsDataGridStyleEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDataGridStyleEN objDataGridStyleEN = new clsDataGridStyleEN();
try
{
objDataGridStyleEN.DgStyleId = objRow[conDataGridStyle.DgStyleId].ToString().Trim(); //DG模式ID
objDataGridStyleEN.DgStyleName = objRow[conDataGridStyle.DgStyleName].ToString().Trim(); //DG模式名
objDataGridStyleEN.Runat = objRow[conDataGridStyle.Runat] == DBNull.Value ? null : objRow[conDataGridStyle.Runat].ToString().Trim(); //运行在
objDataGridStyleEN.FontSize = objRow[conDataGridStyle.FontSize] == DBNull.Value ? null : objRow[conDataGridStyle.FontSize].ToString().Trim(); //字号
objDataGridStyleEN.FontName = objRow[conDataGridStyle.FontName] == DBNull.Value ? null : objRow[conDataGridStyle.FontName].ToString().Trim(); //字体
objDataGridStyleEN.AllowPaging = TransNullToBool(objRow[conDataGridStyle.AllowPaging].ToString().Trim()); //允许分页
objDataGridStyleEN.PageSize = objRow[conDataGridStyle.PageSize] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.PageSize].ToString().Trim()); //页大小
objDataGridStyleEN.AutoGenerateColumns = TransNullToBool(objRow[conDataGridStyle.AutoGenerateColumns].ToString().Trim()); //自动生成列
objDataGridStyleEN.AllowSorting = TransNullToBool(objRow[conDataGridStyle.AllowSorting].ToString().Trim()); //允许排序
objDataGridStyleEN.IsRadio = TransNullToBool(objRow[conDataGridStyle.IsRadio].ToString().Trim()); //是否单选框
objDataGridStyleEN.IsCheck = TransNullToBool(objRow[conDataGridStyle.IsCheck].ToString().Trim()); //是否复选框
objDataGridStyleEN.IsJumpPage = TransNullToBool(objRow[conDataGridStyle.IsJumpPage].ToString().Trim()); //是否跳页
objDataGridStyleEN.IsHaveUpdBtn = TransNullToBool(objRow[conDataGridStyle.IsHaveUpdBtn].ToString().Trim()); //是否有修改按钮
objDataGridStyleEN.IsHaveDelBtn = TransNullToBool(objRow[conDataGridStyle.IsHaveDelBtn].ToString().Trim()); //是否有删除按钮
objDataGridStyleEN.IsHaveDetailBtn = TransNullToBool(objRow[conDataGridStyle.IsHaveDetailBtn].ToString().Trim()); //是否有详细按钮
objDataGridStyleEN.IsInTab = TransNullToBool(objRow[conDataGridStyle.IsInTab].ToString().Trim()); //是否生成DG在表中
objDataGridStyleEN.StyleZindex = objRow[conDataGridStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDataGridStyleEN.StyleLeft = objRow[conDataGridStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.StyleLeft].ToString().Trim()); //Style_Left
objDataGridStyleEN.StylePosition = objRow[conDataGridStyle.StylePosition] == DBNull.Value ? null : objRow[conDataGridStyle.StylePosition].ToString().Trim(); //Style_Position
objDataGridStyleEN.Width = objRow[conDataGridStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.Width].ToString().Trim()); //宽
objDataGridStyleEN.Height = objRow[conDataGridStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.Height].ToString().Trim()); //高度
objDataGridStyleEN.StyleTop = objRow[conDataGridStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataGridStyle.StyleTop].ToString().Trim()); //Style_Top
objDataGridStyleEN.Style = objRow[conDataGridStyle.Style] == DBNull.Value ? null : objRow[conDataGridStyle.Style].ToString().Trim(); //类型
objDataGridStyleEN.IsDefault = TransNullToBool(objRow[conDataGridStyle.IsDefault].ToString().Trim()); //是否默认
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsDataGridStyleDA: GetObjByDataRow)", objException.Message));
}
objDataGridStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataGridStyleEN;
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
objSQL = clsDataGridStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDataGridStyleEN._CurrTabName, conDataGridStyle.DgStyleId, 4, "");
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
objSQL = clsDataGridStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDataGridStyleEN._CurrTabName, conDataGridStyle.DgStyleId, 4, strPrefix);
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
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DgStyleId from DataGridStyle where " + strCondition;
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
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DgStyleId from DataGridStyle where " + strCondition;
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
 /// <param name = "strDgStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strDgStyleId)
{
CheckPrimaryKey(strDgStyleId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DataGridStyle", "DgStyleId = " + "'"+ strDgStyleId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsDataGridStyleDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DataGridStyle", strCondition))
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
objSQL = clsDataGridStyleDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("DataGridStyle");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsDataGridStyleEN objDataGridStyleEN)
 {
 if (objDataGridStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataGridStyleEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
strSQL = "Select * from DataGridStyle where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DataGridStyle");
objRow = objDS.Tables["DataGridStyle"].NewRow();
objRow[conDataGridStyle.DgStyleId] = objDataGridStyleEN.DgStyleId; //DG模式ID
objRow[conDataGridStyle.DgStyleName] = objDataGridStyleEN.DgStyleName; //DG模式名
 if (objDataGridStyleEN.Runat !=  "")
 {
objRow[conDataGridStyle.Runat] = objDataGridStyleEN.Runat; //运行在
 }
 if (objDataGridStyleEN.FontSize !=  "")
 {
objRow[conDataGridStyle.FontSize] = objDataGridStyleEN.FontSize; //字号
 }
 if (objDataGridStyleEN.FontName !=  "")
 {
objRow[conDataGridStyle.FontName] = objDataGridStyleEN.FontName; //字体
 }
objRow[conDataGridStyle.AllowPaging] = objDataGridStyleEN.AllowPaging; //允许分页
objRow[conDataGridStyle.PageSize] = objDataGridStyleEN.PageSize; //页大小
objRow[conDataGridStyle.AutoGenerateColumns] = objDataGridStyleEN.AutoGenerateColumns; //自动生成列
objRow[conDataGridStyle.AllowSorting] = objDataGridStyleEN.AllowSorting; //允许排序
objRow[conDataGridStyle.IsRadio] = objDataGridStyleEN.IsRadio; //是否单选框
objRow[conDataGridStyle.IsCheck] = objDataGridStyleEN.IsCheck; //是否复选框
objRow[conDataGridStyle.IsJumpPage] = objDataGridStyleEN.IsJumpPage; //是否跳页
objRow[conDataGridStyle.IsHaveUpdBtn] = objDataGridStyleEN.IsHaveUpdBtn; //是否有修改按钮
objRow[conDataGridStyle.IsHaveDelBtn] = objDataGridStyleEN.IsHaveDelBtn; //是否有删除按钮
objRow[conDataGridStyle.IsHaveDetailBtn] = objDataGridStyleEN.IsHaveDetailBtn; //是否有详细按钮
objRow[conDataGridStyle.IsInTab] = objDataGridStyleEN.IsInTab; //是否生成DG在表中
objRow[conDataGridStyle.StyleZindex] = objDataGridStyleEN.StyleZindex; //Style_Zindex
objRow[conDataGridStyle.StyleLeft] = objDataGridStyleEN.StyleLeft; //Style_Left
 if (objDataGridStyleEN.StylePosition !=  "")
 {
objRow[conDataGridStyle.StylePosition] = objDataGridStyleEN.StylePosition; //Style_Position
 }
objRow[conDataGridStyle.Width] = objDataGridStyleEN.Width; //宽
objRow[conDataGridStyle.Height] = objDataGridStyleEN.Height; //高度
objRow[conDataGridStyle.StyleTop] = objDataGridStyleEN.StyleTop; //Style_Top
 if (objDataGridStyleEN.Style !=  "")
 {
objRow[conDataGridStyle.Style] = objDataGridStyleEN.Style; //类型
 }
objRow[conDataGridStyle.IsDefault] = objDataGridStyleEN.IsDefault; //是否默认
objDS.Tables[clsDataGridStyleEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsDataGridStyleEN._CurrTabName);
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
 /// <param name = "objDataGridStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDataGridStyleEN objDataGridStyleEN)
{
 if (objDataGridStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataGridStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDataGridStyleEN.DgStyleId !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.DgStyleId);
 var strDgStyleId = objDataGridStyleEN.DgStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDgStyleId + "'");
 }
 
 if (objDataGridStyleEN.DgStyleName !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.DgStyleName);
 var strDgStyleName = objDataGridStyleEN.DgStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDgStyleName + "'");
 }
 
 if (objDataGridStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.Runat);
 var strRunat = objDataGridStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objDataGridStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.FontSize);
 var strFontSize = objDataGridStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objDataGridStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.FontName);
 var strFontName = objDataGridStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 arrFieldListForInsert.Add(conDataGridStyle.AllowPaging);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.AllowPaging  ==  false ? "0" : "1") + "'");
 
 if (objDataGridStyleEN.PageSize !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.PageSize);
 arrValueListForInsert.Add(objDataGridStyleEN.PageSize.ToString());
 }
 
 arrFieldListForInsert.Add(conDataGridStyle.AutoGenerateColumns);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.AutoGenerateColumns  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.AllowSorting);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.AllowSorting  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsRadio);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsRadio  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsCheck);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsCheck  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsJumpPage);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsJumpPage  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsHaveUpdBtn);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsHaveUpdBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsHaveDelBtn);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsHaveDelBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsHaveDetailBtn);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsHaveDetailBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsInTab);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsInTab  ==  false ? "0" : "1") + "'");
 
 if (objDataGridStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.StyleZindex);
 arrValueListForInsert.Add(objDataGridStyleEN.StyleZindex.ToString());
 }
 
 if (objDataGridStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.StyleLeft);
 arrValueListForInsert.Add(objDataGridStyleEN.StyleLeft.ToString());
 }
 
 if (objDataGridStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.StylePosition);
 var strStylePosition = objDataGridStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objDataGridStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.Width);
 arrValueListForInsert.Add(objDataGridStyleEN.Width.ToString());
 }
 
 if (objDataGridStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.Height);
 arrValueListForInsert.Add(objDataGridStyleEN.Height.ToString());
 }
 
 if (objDataGridStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.StyleTop);
 arrValueListForInsert.Add(objDataGridStyleEN.StyleTop.ToString());
 }
 
 if (objDataGridStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.Style);
 var strStyle = objDataGridStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 arrFieldListForInsert.Add(conDataGridStyle.IsDefault);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsDefault  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataGridStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDataGridStyleEN objDataGridStyleEN)
{
 if (objDataGridStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataGridStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDataGridStyleEN.DgStyleId !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.DgStyleId);
 var strDgStyleId = objDataGridStyleEN.DgStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDgStyleId + "'");
 }
 
 if (objDataGridStyleEN.DgStyleName !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.DgStyleName);
 var strDgStyleName = objDataGridStyleEN.DgStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDgStyleName + "'");
 }
 
 if (objDataGridStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.Runat);
 var strRunat = objDataGridStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objDataGridStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.FontSize);
 var strFontSize = objDataGridStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objDataGridStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.FontName);
 var strFontName = objDataGridStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 arrFieldListForInsert.Add(conDataGridStyle.AllowPaging);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.AllowPaging  ==  false ? "0" : "1") + "'");
 
 if (objDataGridStyleEN.PageSize !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.PageSize);
 arrValueListForInsert.Add(objDataGridStyleEN.PageSize.ToString());
 }
 
 arrFieldListForInsert.Add(conDataGridStyle.AutoGenerateColumns);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.AutoGenerateColumns  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.AllowSorting);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.AllowSorting  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsRadio);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsRadio  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsCheck);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsCheck  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsJumpPage);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsJumpPage  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsHaveUpdBtn);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsHaveUpdBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsHaveDelBtn);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsHaveDelBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsHaveDetailBtn);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsHaveDetailBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsInTab);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsInTab  ==  false ? "0" : "1") + "'");
 
 if (objDataGridStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.StyleZindex);
 arrValueListForInsert.Add(objDataGridStyleEN.StyleZindex.ToString());
 }
 
 if (objDataGridStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.StyleLeft);
 arrValueListForInsert.Add(objDataGridStyleEN.StyleLeft.ToString());
 }
 
 if (objDataGridStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.StylePosition);
 var strStylePosition = objDataGridStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objDataGridStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.Width);
 arrValueListForInsert.Add(objDataGridStyleEN.Width.ToString());
 }
 
 if (objDataGridStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.Height);
 arrValueListForInsert.Add(objDataGridStyleEN.Height.ToString());
 }
 
 if (objDataGridStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.StyleTop);
 arrValueListForInsert.Add(objDataGridStyleEN.StyleTop.ToString());
 }
 
 if (objDataGridStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.Style);
 var strStyle = objDataGridStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 arrFieldListForInsert.Add(conDataGridStyle.IsDefault);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsDefault  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataGridStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objDataGridStyleEN.DgStyleId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDataGridStyleEN objDataGridStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objDataGridStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataGridStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDataGridStyleEN.DgStyleId !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.DgStyleId);
 var strDgStyleId = objDataGridStyleEN.DgStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDgStyleId + "'");
 }
 
 if (objDataGridStyleEN.DgStyleName !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.DgStyleName);
 var strDgStyleName = objDataGridStyleEN.DgStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDgStyleName + "'");
 }
 
 if (objDataGridStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.Runat);
 var strRunat = objDataGridStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objDataGridStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.FontSize);
 var strFontSize = objDataGridStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objDataGridStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.FontName);
 var strFontName = objDataGridStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 arrFieldListForInsert.Add(conDataGridStyle.AllowPaging);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.AllowPaging  ==  false ? "0" : "1") + "'");
 
 if (objDataGridStyleEN.PageSize !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.PageSize);
 arrValueListForInsert.Add(objDataGridStyleEN.PageSize.ToString());
 }
 
 arrFieldListForInsert.Add(conDataGridStyle.AutoGenerateColumns);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.AutoGenerateColumns  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.AllowSorting);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.AllowSorting  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsRadio);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsRadio  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsCheck);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsCheck  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsJumpPage);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsJumpPage  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsHaveUpdBtn);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsHaveUpdBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsHaveDelBtn);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsHaveDelBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsHaveDetailBtn);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsHaveDetailBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsInTab);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsInTab  ==  false ? "0" : "1") + "'");
 
 if (objDataGridStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.StyleZindex);
 arrValueListForInsert.Add(objDataGridStyleEN.StyleZindex.ToString());
 }
 
 if (objDataGridStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.StyleLeft);
 arrValueListForInsert.Add(objDataGridStyleEN.StyleLeft.ToString());
 }
 
 if (objDataGridStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.StylePosition);
 var strStylePosition = objDataGridStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objDataGridStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.Width);
 arrValueListForInsert.Add(objDataGridStyleEN.Width.ToString());
 }
 
 if (objDataGridStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.Height);
 arrValueListForInsert.Add(objDataGridStyleEN.Height.ToString());
 }
 
 if (objDataGridStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.StyleTop);
 arrValueListForInsert.Add(objDataGridStyleEN.StyleTop.ToString());
 }
 
 if (objDataGridStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.Style);
 var strStyle = objDataGridStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 arrFieldListForInsert.Add(conDataGridStyle.IsDefault);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsDefault  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataGridStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objDataGridStyleEN.DgStyleId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objDataGridStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDataGridStyleEN objDataGridStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objDataGridStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataGridStyleEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDataGridStyleEN.DgStyleId !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.DgStyleId);
 var strDgStyleId = objDataGridStyleEN.DgStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDgStyleId + "'");
 }
 
 if (objDataGridStyleEN.DgStyleName !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.DgStyleName);
 var strDgStyleName = objDataGridStyleEN.DgStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDgStyleName + "'");
 }
 
 if (objDataGridStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.Runat);
 var strRunat = objDataGridStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objDataGridStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.FontSize);
 var strFontSize = objDataGridStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objDataGridStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.FontName);
 var strFontName = objDataGridStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 arrFieldListForInsert.Add(conDataGridStyle.AllowPaging);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.AllowPaging  ==  false ? "0" : "1") + "'");
 
 if (objDataGridStyleEN.PageSize !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.PageSize);
 arrValueListForInsert.Add(objDataGridStyleEN.PageSize.ToString());
 }
 
 arrFieldListForInsert.Add(conDataGridStyle.AutoGenerateColumns);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.AutoGenerateColumns  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.AllowSorting);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.AllowSorting  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsRadio);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsRadio  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsCheck);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsCheck  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsJumpPage);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsJumpPage  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsHaveUpdBtn);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsHaveUpdBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsHaveDelBtn);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsHaveDelBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsHaveDetailBtn);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsHaveDetailBtn  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDataGridStyle.IsInTab);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsInTab  ==  false ? "0" : "1") + "'");
 
 if (objDataGridStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.StyleZindex);
 arrValueListForInsert.Add(objDataGridStyleEN.StyleZindex.ToString());
 }
 
 if (objDataGridStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.StyleLeft);
 arrValueListForInsert.Add(objDataGridStyleEN.StyleLeft.ToString());
 }
 
 if (objDataGridStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.StylePosition);
 var strStylePosition = objDataGridStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objDataGridStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.Width);
 arrValueListForInsert.Add(objDataGridStyleEN.Width.ToString());
 }
 
 if (objDataGridStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.Height);
 arrValueListForInsert.Add(objDataGridStyleEN.Height.ToString());
 }
 
 if (objDataGridStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.StyleTop);
 arrValueListForInsert.Add(objDataGridStyleEN.StyleTop.ToString());
 }
 
 if (objDataGridStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conDataGridStyle.Style);
 var strStyle = objDataGridStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 arrFieldListForInsert.Add(conDataGridStyle.IsDefault);
 arrValueListForInsert.Add("'" + (objDataGridStyleEN.IsDefault  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataGridStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewDataGridStyles(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
strSQL = "Select * from DataGridStyle where DgStyleId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DataGridStyle");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strDgStyleId = oRow[conDataGridStyle.DgStyleId].ToString().Trim();
if (IsExist(strDgStyleId))
{
 string strResult = "关键字变量值为:" + string.Format("DgStyleId = {0}", strDgStyleId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsDataGridStyleEN._CurrTabName ].NewRow();
objRow[conDataGridStyle.DgStyleId] = oRow[conDataGridStyle.DgStyleId].ToString().Trim(); //DG模式ID
objRow[conDataGridStyle.DgStyleName] = oRow[conDataGridStyle.DgStyleName].ToString().Trim(); //DG模式名
objRow[conDataGridStyle.Runat] = oRow[conDataGridStyle.Runat].ToString().Trim(); //运行在
objRow[conDataGridStyle.FontSize] = oRow[conDataGridStyle.FontSize].ToString().Trim(); //字号
objRow[conDataGridStyle.FontName] = oRow[conDataGridStyle.FontName].ToString().Trim(); //字体
objRow[conDataGridStyle.AllowPaging] = oRow[conDataGridStyle.AllowPaging].ToString().Trim(); //允许分页
objRow[conDataGridStyle.PageSize] = oRow[conDataGridStyle.PageSize].ToString().Trim(); //页大小
objRow[conDataGridStyle.AutoGenerateColumns] = oRow[conDataGridStyle.AutoGenerateColumns].ToString().Trim(); //自动生成列
objRow[conDataGridStyle.AllowSorting] = oRow[conDataGridStyle.AllowSorting].ToString().Trim(); //允许排序
objRow[conDataGridStyle.IsRadio] = oRow[conDataGridStyle.IsRadio].ToString().Trim(); //是否单选框
objRow[conDataGridStyle.IsCheck] = oRow[conDataGridStyle.IsCheck].ToString().Trim(); //是否复选框
objRow[conDataGridStyle.IsJumpPage] = oRow[conDataGridStyle.IsJumpPage].ToString().Trim(); //是否跳页
objRow[conDataGridStyle.IsHaveUpdBtn] = oRow[conDataGridStyle.IsHaveUpdBtn].ToString().Trim(); //是否有修改按钮
objRow[conDataGridStyle.IsHaveDelBtn] = oRow[conDataGridStyle.IsHaveDelBtn].ToString().Trim(); //是否有删除按钮
objRow[conDataGridStyle.IsHaveDetailBtn] = oRow[conDataGridStyle.IsHaveDetailBtn].ToString().Trim(); //是否有详细按钮
objRow[conDataGridStyle.IsInTab] = oRow[conDataGridStyle.IsInTab].ToString().Trim(); //是否生成DG在表中
objRow[conDataGridStyle.StyleZindex] = oRow[conDataGridStyle.StyleZindex].ToString().Trim(); //Style_Zindex
objRow[conDataGridStyle.StyleLeft] = oRow[conDataGridStyle.StyleLeft].ToString().Trim(); //Style_Left
objRow[conDataGridStyle.StylePosition] = oRow[conDataGridStyle.StylePosition].ToString().Trim(); //Style_Position
objRow[conDataGridStyle.Width] = oRow[conDataGridStyle.Width].ToString().Trim(); //宽
objRow[conDataGridStyle.Height] = oRow[conDataGridStyle.Height].ToString().Trim(); //高度
objRow[conDataGridStyle.StyleTop] = oRow[conDataGridStyle.StyleTop].ToString().Trim(); //Style_Top
objRow[conDataGridStyle.Style] = oRow[conDataGridStyle.Style].ToString().Trim(); //类型
objRow[conDataGridStyle.IsDefault] = oRow[conDataGridStyle.IsDefault].ToString().Trim(); //是否默认
 objDS.Tables[clsDataGridStyleEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsDataGridStyleEN._CurrTabName);
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
 /// <param name = "objDataGridStyleEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsDataGridStyleEN objDataGridStyleEN)
{
 if (objDataGridStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataGridStyleEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
strSQL = "Select * from DataGridStyle where DgStyleId = " + "'"+ objDataGridStyleEN.DgStyleId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsDataGridStyleEN._CurrTabName);
if (objDS.Tables[clsDataGridStyleEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:DgStyleId = " + "'"+ objDataGridStyleEN.DgStyleId+"'");
return false;
}
objRow = objDS.Tables[clsDataGridStyleEN._CurrTabName].Rows[0];
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.DgStyleId))
 {
objRow[conDataGridStyle.DgStyleId] = objDataGridStyleEN.DgStyleId; //DG模式ID
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.DgStyleName))
 {
objRow[conDataGridStyle.DgStyleName] = objDataGridStyleEN.DgStyleName; //DG模式名
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Runat))
 {
objRow[conDataGridStyle.Runat] = objDataGridStyleEN.Runat; //运行在
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.FontSize))
 {
objRow[conDataGridStyle.FontSize] = objDataGridStyleEN.FontSize; //字号
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.FontName))
 {
objRow[conDataGridStyle.FontName] = objDataGridStyleEN.FontName; //字体
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.AllowPaging))
 {
objRow[conDataGridStyle.AllowPaging] = objDataGridStyleEN.AllowPaging; //允许分页
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.PageSize))
 {
objRow[conDataGridStyle.PageSize] = objDataGridStyleEN.PageSize; //页大小
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.AutoGenerateColumns))
 {
objRow[conDataGridStyle.AutoGenerateColumns] = objDataGridStyleEN.AutoGenerateColumns; //自动生成列
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.AllowSorting))
 {
objRow[conDataGridStyle.AllowSorting] = objDataGridStyleEN.AllowSorting; //允许排序
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsRadio))
 {
objRow[conDataGridStyle.IsRadio] = objDataGridStyleEN.IsRadio; //是否单选框
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsCheck))
 {
objRow[conDataGridStyle.IsCheck] = objDataGridStyleEN.IsCheck; //是否复选框
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsJumpPage))
 {
objRow[conDataGridStyle.IsJumpPage] = objDataGridStyleEN.IsJumpPage; //是否跳页
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsHaveUpdBtn))
 {
objRow[conDataGridStyle.IsHaveUpdBtn] = objDataGridStyleEN.IsHaveUpdBtn; //是否有修改按钮
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsHaveDelBtn))
 {
objRow[conDataGridStyle.IsHaveDelBtn] = objDataGridStyleEN.IsHaveDelBtn; //是否有删除按钮
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsHaveDetailBtn))
 {
objRow[conDataGridStyle.IsHaveDetailBtn] = objDataGridStyleEN.IsHaveDetailBtn; //是否有详细按钮
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsInTab))
 {
objRow[conDataGridStyle.IsInTab] = objDataGridStyleEN.IsInTab; //是否生成DG在表中
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StyleZindex))
 {
objRow[conDataGridStyle.StyleZindex] = objDataGridStyleEN.StyleZindex; //Style_Zindex
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StyleLeft))
 {
objRow[conDataGridStyle.StyleLeft] = objDataGridStyleEN.StyleLeft; //Style_Left
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StylePosition))
 {
objRow[conDataGridStyle.StylePosition] = objDataGridStyleEN.StylePosition; //Style_Position
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Width))
 {
objRow[conDataGridStyle.Width] = objDataGridStyleEN.Width; //宽
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Height))
 {
objRow[conDataGridStyle.Height] = objDataGridStyleEN.Height; //高度
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StyleTop))
 {
objRow[conDataGridStyle.StyleTop] = objDataGridStyleEN.StyleTop; //Style_Top
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Style))
 {
objRow[conDataGridStyle.Style] = objDataGridStyleEN.Style; //类型
 }
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsDefault))
 {
objRow[conDataGridStyle.IsDefault] = objDataGridStyleEN.IsDefault; //是否默认
 }
try
{
objDA.Update(objDS, clsDataGridStyleEN._CurrTabName);
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
 /// <param name = "objDataGridStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDataGridStyleEN objDataGridStyleEN)
{
 if (objDataGridStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataGridStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update DataGridStyle Set ");
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.DgStyleName))
 {
 if (objDataGridStyleEN.DgStyleName !=  null)
 {
 var strDgStyleName = objDataGridStyleEN.DgStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDgStyleName, conDataGridStyle.DgStyleName); //DG模式名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.DgStyleName); //DG模式名
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Runat))
 {
 if (objDataGridStyleEN.Runat !=  null)
 {
 var strRunat = objDataGridStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRunat, conDataGridStyle.Runat); //运行在
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.Runat); //运行在
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.FontSize))
 {
 if (objDataGridStyleEN.FontSize !=  null)
 {
 var strFontSize = objDataGridStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontSize, conDataGridStyle.FontSize); //字号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.FontSize); //字号
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.FontName))
 {
 if (objDataGridStyleEN.FontName !=  null)
 {
 var strFontName = objDataGridStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontName, conDataGridStyle.FontName); //字体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.FontName); //字体
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.AllowPaging))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.AllowPaging == true?"1":"0", conDataGridStyle.AllowPaging); //允许分页
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.PageSize))
 {
 if (objDataGridStyleEN.PageSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.PageSize, conDataGridStyle.PageSize); //页大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.PageSize); //页大小
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.AutoGenerateColumns))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.AutoGenerateColumns == true?"1":"0", conDataGridStyle.AutoGenerateColumns); //自动生成列
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.AllowSorting))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.AllowSorting == true?"1":"0", conDataGridStyle.AllowSorting); //允许排序
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsRadio))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.IsRadio == true?"1":"0", conDataGridStyle.IsRadio); //是否单选框
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsCheck))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.IsCheck == true?"1":"0", conDataGridStyle.IsCheck); //是否复选框
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsJumpPage))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.IsJumpPage == true?"1":"0", conDataGridStyle.IsJumpPage); //是否跳页
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsHaveUpdBtn))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.IsHaveUpdBtn == true?"1":"0", conDataGridStyle.IsHaveUpdBtn); //是否有修改按钮
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsHaveDelBtn))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.IsHaveDelBtn == true?"1":"0", conDataGridStyle.IsHaveDelBtn); //是否有删除按钮
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsHaveDetailBtn))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.IsHaveDetailBtn == true?"1":"0", conDataGridStyle.IsHaveDetailBtn); //是否有详细按钮
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsInTab))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.IsInTab == true?"1":"0", conDataGridStyle.IsInTab); //是否生成DG在表中
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StyleZindex))
 {
 if (objDataGridStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.StyleZindex, conDataGridStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StyleLeft))
 {
 if (objDataGridStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.StyleLeft, conDataGridStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StylePosition))
 {
 if (objDataGridStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objDataGridStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStylePosition, conDataGridStyle.StylePosition); //Style_Position
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.StylePosition); //Style_Position
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Width))
 {
 if (objDataGridStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.Width, conDataGridStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.Width); //宽
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Height))
 {
 if (objDataGridStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.Height, conDataGridStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.Height); //高度
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StyleTop))
 {
 if (objDataGridStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.StyleTop, conDataGridStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.StyleTop); //Style_Top
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Style))
 {
 if (objDataGridStyleEN.Style !=  null)
 {
 var strStyle = objDataGridStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyle, conDataGridStyle.Style); //类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.Style); //类型
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsDefault))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.IsDefault == true?"1":"0", conDataGridStyle.IsDefault); //是否默认
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DgStyleId = '{0}'", objDataGridStyleEN.DgStyleId); 
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
 /// <param name = "objDataGridStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsDataGridStyleEN objDataGridStyleEN, string strCondition)
{
 if (objDataGridStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataGridStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataGridStyle Set ");
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.DgStyleName))
 {
 if (objDataGridStyleEN.DgStyleName !=  null)
 {
 var strDgStyleName = objDataGridStyleEN.DgStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DgStyleName = '{0}',", strDgStyleName); //DG模式名
 }
 else
 {
 sbSQL.Append(" DgStyleName = null,"); //DG模式名
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Runat))
 {
 if (objDataGridStyleEN.Runat !=  null)
 {
 var strRunat = objDataGridStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Runat = '{0}',", strRunat); //运行在
 }
 else
 {
 sbSQL.Append(" Runat = null,"); //运行在
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.FontSize))
 {
 if (objDataGridStyleEN.FontSize !=  null)
 {
 var strFontSize = objDataGridStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontSize = '{0}',", strFontSize); //字号
 }
 else
 {
 sbSQL.Append(" FontSize = null,"); //字号
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.FontName))
 {
 if (objDataGridStyleEN.FontName !=  null)
 {
 var strFontName = objDataGridStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontName = '{0}',", strFontName); //字体
 }
 else
 {
 sbSQL.Append(" FontName = null,"); //字体
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.AllowPaging))
 {
 sbSQL.AppendFormat(" AllowPaging = '{0}',", objDataGridStyleEN.AllowPaging == true?"1":"0"); //允许分页
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.PageSize))
 {
 if (objDataGridStyleEN.PageSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.PageSize, conDataGridStyle.PageSize); //页大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.PageSize); //页大小
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.AutoGenerateColumns))
 {
 sbSQL.AppendFormat(" AutoGenerateColumns = '{0}',", objDataGridStyleEN.AutoGenerateColumns == true?"1":"0"); //自动生成列
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.AllowSorting))
 {
 sbSQL.AppendFormat(" AllowSorting = '{0}',", objDataGridStyleEN.AllowSorting == true?"1":"0"); //允许排序
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsRadio))
 {
 sbSQL.AppendFormat(" IsRadio = '{0}',", objDataGridStyleEN.IsRadio == true?"1":"0"); //是否单选框
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsCheck))
 {
 sbSQL.AppendFormat(" IsCheck = '{0}',", objDataGridStyleEN.IsCheck == true?"1":"0"); //是否复选框
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsJumpPage))
 {
 sbSQL.AppendFormat(" IsJumpPage = '{0}',", objDataGridStyleEN.IsJumpPage == true?"1":"0"); //是否跳页
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsHaveUpdBtn))
 {
 sbSQL.AppendFormat(" IsHaveUpdBtn = '{0}',", objDataGridStyleEN.IsHaveUpdBtn == true?"1":"0"); //是否有修改按钮
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsHaveDelBtn))
 {
 sbSQL.AppendFormat(" IsHaveDelBtn = '{0}',", objDataGridStyleEN.IsHaveDelBtn == true?"1":"0"); //是否有删除按钮
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsHaveDetailBtn))
 {
 sbSQL.AppendFormat(" IsHaveDetailBtn = '{0}',", objDataGridStyleEN.IsHaveDetailBtn == true?"1":"0"); //是否有详细按钮
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsInTab))
 {
 sbSQL.AppendFormat(" IsInTab = '{0}',", objDataGridStyleEN.IsInTab == true?"1":"0"); //是否生成DG在表中
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StyleZindex))
 {
 if (objDataGridStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.StyleZindex, conDataGridStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StyleLeft))
 {
 if (objDataGridStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.StyleLeft, conDataGridStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StylePosition))
 {
 if (objDataGridStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objDataGridStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StylePosition = '{0}',", strStylePosition); //Style_Position
 }
 else
 {
 sbSQL.Append(" StylePosition = null,"); //Style_Position
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Width))
 {
 if (objDataGridStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.Width, conDataGridStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.Width); //宽
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Height))
 {
 if (objDataGridStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.Height, conDataGridStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.Height); //高度
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StyleTop))
 {
 if (objDataGridStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.StyleTop, conDataGridStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.StyleTop); //Style_Top
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Style))
 {
 if (objDataGridStyleEN.Style !=  null)
 {
 var strStyle = objDataGridStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Style = '{0}',", strStyle); //类型
 }
 else
 {
 sbSQL.Append(" Style = null,"); //类型
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsDefault))
 {
 sbSQL.AppendFormat(" IsDefault = '{0}',", objDataGridStyleEN.IsDefault == true?"1":"0"); //是否默认
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
 /// <param name = "objDataGridStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsDataGridStyleEN objDataGridStyleEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objDataGridStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataGridStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataGridStyle Set ");
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.DgStyleName))
 {
 if (objDataGridStyleEN.DgStyleName !=  null)
 {
 var strDgStyleName = objDataGridStyleEN.DgStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DgStyleName = '{0}',", strDgStyleName); //DG模式名
 }
 else
 {
 sbSQL.Append(" DgStyleName = null,"); //DG模式名
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Runat))
 {
 if (objDataGridStyleEN.Runat !=  null)
 {
 var strRunat = objDataGridStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Runat = '{0}',", strRunat); //运行在
 }
 else
 {
 sbSQL.Append(" Runat = null,"); //运行在
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.FontSize))
 {
 if (objDataGridStyleEN.FontSize !=  null)
 {
 var strFontSize = objDataGridStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontSize = '{0}',", strFontSize); //字号
 }
 else
 {
 sbSQL.Append(" FontSize = null,"); //字号
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.FontName))
 {
 if (objDataGridStyleEN.FontName !=  null)
 {
 var strFontName = objDataGridStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontName = '{0}',", strFontName); //字体
 }
 else
 {
 sbSQL.Append(" FontName = null,"); //字体
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.AllowPaging))
 {
 sbSQL.AppendFormat(" AllowPaging = '{0}',", objDataGridStyleEN.AllowPaging == true?"1":"0"); //允许分页
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.PageSize))
 {
 if (objDataGridStyleEN.PageSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.PageSize, conDataGridStyle.PageSize); //页大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.PageSize); //页大小
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.AutoGenerateColumns))
 {
 sbSQL.AppendFormat(" AutoGenerateColumns = '{0}',", objDataGridStyleEN.AutoGenerateColumns == true?"1":"0"); //自动生成列
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.AllowSorting))
 {
 sbSQL.AppendFormat(" AllowSorting = '{0}',", objDataGridStyleEN.AllowSorting == true?"1":"0"); //允许排序
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsRadio))
 {
 sbSQL.AppendFormat(" IsRadio = '{0}',", objDataGridStyleEN.IsRadio == true?"1":"0"); //是否单选框
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsCheck))
 {
 sbSQL.AppendFormat(" IsCheck = '{0}',", objDataGridStyleEN.IsCheck == true?"1":"0"); //是否复选框
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsJumpPage))
 {
 sbSQL.AppendFormat(" IsJumpPage = '{0}',", objDataGridStyleEN.IsJumpPage == true?"1":"0"); //是否跳页
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsHaveUpdBtn))
 {
 sbSQL.AppendFormat(" IsHaveUpdBtn = '{0}',", objDataGridStyleEN.IsHaveUpdBtn == true?"1":"0"); //是否有修改按钮
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsHaveDelBtn))
 {
 sbSQL.AppendFormat(" IsHaveDelBtn = '{0}',", objDataGridStyleEN.IsHaveDelBtn == true?"1":"0"); //是否有删除按钮
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsHaveDetailBtn))
 {
 sbSQL.AppendFormat(" IsHaveDetailBtn = '{0}',", objDataGridStyleEN.IsHaveDetailBtn == true?"1":"0"); //是否有详细按钮
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsInTab))
 {
 sbSQL.AppendFormat(" IsInTab = '{0}',", objDataGridStyleEN.IsInTab == true?"1":"0"); //是否生成DG在表中
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StyleZindex))
 {
 if (objDataGridStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.StyleZindex, conDataGridStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StyleLeft))
 {
 if (objDataGridStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.StyleLeft, conDataGridStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StylePosition))
 {
 if (objDataGridStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objDataGridStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StylePosition = '{0}',", strStylePosition); //Style_Position
 }
 else
 {
 sbSQL.Append(" StylePosition = null,"); //Style_Position
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Width))
 {
 if (objDataGridStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.Width, conDataGridStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.Width); //宽
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Height))
 {
 if (objDataGridStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.Height, conDataGridStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.Height); //高度
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StyleTop))
 {
 if (objDataGridStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.StyleTop, conDataGridStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.StyleTop); //Style_Top
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Style))
 {
 if (objDataGridStyleEN.Style !=  null)
 {
 var strStyle = objDataGridStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Style = '{0}',", strStyle); //类型
 }
 else
 {
 sbSQL.Append(" Style = null,"); //类型
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsDefault))
 {
 sbSQL.AppendFormat(" IsDefault = '{0}',", objDataGridStyleEN.IsDefault == true?"1":"0"); //是否默认
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
 /// <param name = "objDataGridStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDataGridStyleEN objDataGridStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objDataGridStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataGridStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataGridStyle Set ");
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.DgStyleName))
 {
 if (objDataGridStyleEN.DgStyleName !=  null)
 {
 var strDgStyleName = objDataGridStyleEN.DgStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDgStyleName, conDataGridStyle.DgStyleName); //DG模式名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.DgStyleName); //DG模式名
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Runat))
 {
 if (objDataGridStyleEN.Runat !=  null)
 {
 var strRunat = objDataGridStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRunat, conDataGridStyle.Runat); //运行在
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.Runat); //运行在
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.FontSize))
 {
 if (objDataGridStyleEN.FontSize !=  null)
 {
 var strFontSize = objDataGridStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontSize, conDataGridStyle.FontSize); //字号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.FontSize); //字号
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.FontName))
 {
 if (objDataGridStyleEN.FontName !=  null)
 {
 var strFontName = objDataGridStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontName, conDataGridStyle.FontName); //字体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.FontName); //字体
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.AllowPaging))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.AllowPaging == true?"1":"0", conDataGridStyle.AllowPaging); //允许分页
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.PageSize))
 {
 if (objDataGridStyleEN.PageSize !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.PageSize, conDataGridStyle.PageSize); //页大小
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.PageSize); //页大小
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.AutoGenerateColumns))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.AutoGenerateColumns == true?"1":"0", conDataGridStyle.AutoGenerateColumns); //自动生成列
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.AllowSorting))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.AllowSorting == true?"1":"0", conDataGridStyle.AllowSorting); //允许排序
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsRadio))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.IsRadio == true?"1":"0", conDataGridStyle.IsRadio); //是否单选框
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsCheck))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.IsCheck == true?"1":"0", conDataGridStyle.IsCheck); //是否复选框
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsJumpPage))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.IsJumpPage == true?"1":"0", conDataGridStyle.IsJumpPage); //是否跳页
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsHaveUpdBtn))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.IsHaveUpdBtn == true?"1":"0", conDataGridStyle.IsHaveUpdBtn); //是否有修改按钮
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsHaveDelBtn))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.IsHaveDelBtn == true?"1":"0", conDataGridStyle.IsHaveDelBtn); //是否有删除按钮
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsHaveDetailBtn))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.IsHaveDetailBtn == true?"1":"0", conDataGridStyle.IsHaveDetailBtn); //是否有详细按钮
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsInTab))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.IsInTab == true?"1":"0", conDataGridStyle.IsInTab); //是否生成DG在表中
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StyleZindex))
 {
 if (objDataGridStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.StyleZindex, conDataGridStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StyleLeft))
 {
 if (objDataGridStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.StyleLeft, conDataGridStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StylePosition))
 {
 if (objDataGridStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objDataGridStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStylePosition, conDataGridStyle.StylePosition); //Style_Position
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.StylePosition); //Style_Position
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Width))
 {
 if (objDataGridStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.Width, conDataGridStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.Width); //宽
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Height))
 {
 if (objDataGridStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.Height, conDataGridStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.Height); //高度
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.StyleTop))
 {
 if (objDataGridStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataGridStyleEN.StyleTop, conDataGridStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.StyleTop); //Style_Top
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.Style))
 {
 if (objDataGridStyleEN.Style !=  null)
 {
 var strStyle = objDataGridStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyle, conDataGridStyle.Style); //类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataGridStyle.Style); //类型
 }
 }
 
 if (objDataGridStyleEN.IsUpdated(conDataGridStyle.IsDefault))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDataGridStyleEN.IsDefault == true?"1":"0", conDataGridStyle.IsDefault); //是否默认
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DgStyleId = '{0}'", objDataGridStyleEN.DgStyleId); 
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
 /// <param name = "strDgStyleId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strDgStyleId) 
{
CheckPrimaryKey(strDgStyleId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strDgStyleId,
};
 objSQL.ExecSP("DataGridStyle_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strDgStyleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strDgStyleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strDgStyleId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
//删除DataGridStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataGridStyle where DgStyleId = " + "'"+ strDgStyleId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelDataGridStyle(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
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
//删除DataGridStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataGridStyle where DgStyleId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strDgStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strDgStyleId) 
{
CheckPrimaryKey(strDgStyleId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
//删除DataGridStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataGridStyle where DgStyleId = " + "'"+ strDgStyleId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelDataGridStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsDataGridStyleDA: DelDataGridStyle)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DataGridStyle where " + strCondition ;
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
public bool DelDataGridStyleWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsDataGridStyleDA: DelDataGridStyleWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DataGridStyle where " + strCondition ;
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
 /// <param name = "objDataGridStyleENS">源对象</param>
 /// <param name = "objDataGridStyleENT">目标对象</param>
public void CopyTo(clsDataGridStyleEN objDataGridStyleENS, clsDataGridStyleEN objDataGridStyleENT)
{
objDataGridStyleENT.DgStyleId = objDataGridStyleENS.DgStyleId; //DG模式ID
objDataGridStyleENT.DgStyleName = objDataGridStyleENS.DgStyleName; //DG模式名
objDataGridStyleENT.Runat = objDataGridStyleENS.Runat; //运行在
objDataGridStyleENT.FontSize = objDataGridStyleENS.FontSize; //字号
objDataGridStyleENT.FontName = objDataGridStyleENS.FontName; //字体
objDataGridStyleENT.AllowPaging = objDataGridStyleENS.AllowPaging; //允许分页
objDataGridStyleENT.PageSize = objDataGridStyleENS.PageSize; //页大小
objDataGridStyleENT.AutoGenerateColumns = objDataGridStyleENS.AutoGenerateColumns; //自动生成列
objDataGridStyleENT.AllowSorting = objDataGridStyleENS.AllowSorting; //允许排序
objDataGridStyleENT.IsRadio = objDataGridStyleENS.IsRadio; //是否单选框
objDataGridStyleENT.IsCheck = objDataGridStyleENS.IsCheck; //是否复选框
objDataGridStyleENT.IsJumpPage = objDataGridStyleENS.IsJumpPage; //是否跳页
objDataGridStyleENT.IsHaveUpdBtn = objDataGridStyleENS.IsHaveUpdBtn; //是否有修改按钮
objDataGridStyleENT.IsHaveDelBtn = objDataGridStyleENS.IsHaveDelBtn; //是否有删除按钮
objDataGridStyleENT.IsHaveDetailBtn = objDataGridStyleENS.IsHaveDetailBtn; //是否有详细按钮
objDataGridStyleENT.IsInTab = objDataGridStyleENS.IsInTab; //是否生成DG在表中
objDataGridStyleENT.StyleZindex = objDataGridStyleENS.StyleZindex; //Style_Zindex
objDataGridStyleENT.StyleLeft = objDataGridStyleENS.StyleLeft; //Style_Left
objDataGridStyleENT.StylePosition = objDataGridStyleENS.StylePosition; //Style_Position
objDataGridStyleENT.Width = objDataGridStyleENS.Width; //宽
objDataGridStyleENT.Height = objDataGridStyleENS.Height; //高度
objDataGridStyleENT.StyleTop = objDataGridStyleENS.StyleTop; //Style_Top
objDataGridStyleENT.Style = objDataGridStyleENS.Style; //类型
objDataGridStyleENT.IsDefault = objDataGridStyleENS.IsDefault; //是否默认
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDataGridStyleEN objDataGridStyleEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objDataGridStyleEN.DgStyleName, conDataGridStyle.DgStyleName);
clsCheckSql.CheckFieldNotNull(objDataGridStyleEN.AllowPaging, conDataGridStyle.AllowPaging);
clsCheckSql.CheckFieldNotNull(objDataGridStyleEN.AutoGenerateColumns, conDataGridStyle.AutoGenerateColumns);
clsCheckSql.CheckFieldNotNull(objDataGridStyleEN.AllowSorting, conDataGridStyle.AllowSorting);
//检查字段长度
clsCheckSql.CheckFieldLen(objDataGridStyleEN.DgStyleId, 4, conDataGridStyle.DgStyleId);
clsCheckSql.CheckFieldLen(objDataGridStyleEN.DgStyleName, 30, conDataGridStyle.DgStyleName);
clsCheckSql.CheckFieldLen(objDataGridStyleEN.Runat, 30, conDataGridStyle.Runat);
clsCheckSql.CheckFieldLen(objDataGridStyleEN.FontSize, 20, conDataGridStyle.FontSize);
clsCheckSql.CheckFieldLen(objDataGridStyleEN.FontName, 20, conDataGridStyle.FontName);
clsCheckSql.CheckFieldLen(objDataGridStyleEN.StylePosition, 20, conDataGridStyle.StylePosition);
clsCheckSql.CheckFieldLen(objDataGridStyleEN.Style, 800, conDataGridStyle.Style);
//检查字段外键固定长度
 objDataGridStyleEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsDataGridStyleEN objDataGridStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDataGridStyleEN.DgStyleName, 30, conDataGridStyle.DgStyleName);
clsCheckSql.CheckFieldLen(objDataGridStyleEN.Runat, 30, conDataGridStyle.Runat);
clsCheckSql.CheckFieldLen(objDataGridStyleEN.FontSize, 20, conDataGridStyle.FontSize);
clsCheckSql.CheckFieldLen(objDataGridStyleEN.FontName, 20, conDataGridStyle.FontName);
clsCheckSql.CheckFieldLen(objDataGridStyleEN.StylePosition, 20, conDataGridStyle.StylePosition);
clsCheckSql.CheckFieldLen(objDataGridStyleEN.Style, 800, conDataGridStyle.Style);
//检查外键字段长度
 objDataGridStyleEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsDataGridStyleEN objDataGridStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDataGridStyleEN.DgStyleId, 4, conDataGridStyle.DgStyleId);
clsCheckSql.CheckFieldLen(objDataGridStyleEN.DgStyleName, 30, conDataGridStyle.DgStyleName);
clsCheckSql.CheckFieldLen(objDataGridStyleEN.Runat, 30, conDataGridStyle.Runat);
clsCheckSql.CheckFieldLen(objDataGridStyleEN.FontSize, 20, conDataGridStyle.FontSize);
clsCheckSql.CheckFieldLen(objDataGridStyleEN.FontName, 20, conDataGridStyle.FontName);
clsCheckSql.CheckFieldLen(objDataGridStyleEN.StylePosition, 20, conDataGridStyle.StylePosition);
clsCheckSql.CheckFieldLen(objDataGridStyleEN.Style, 800, conDataGridStyle.Style);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objDataGridStyleEN.DgStyleId, conDataGridStyle.DgStyleId);
clsCheckSql.CheckSqlInjection4Field(objDataGridStyleEN.DgStyleName, conDataGridStyle.DgStyleName);
clsCheckSql.CheckSqlInjection4Field(objDataGridStyleEN.Runat, conDataGridStyle.Runat);
clsCheckSql.CheckSqlInjection4Field(objDataGridStyleEN.FontSize, conDataGridStyle.FontSize);
clsCheckSql.CheckSqlInjection4Field(objDataGridStyleEN.FontName, conDataGridStyle.FontName);
clsCheckSql.CheckSqlInjection4Field(objDataGridStyleEN.StylePosition, conDataGridStyle.StylePosition);
clsCheckSql.CheckSqlInjection4Field(objDataGridStyleEN.Style, conDataGridStyle.Style);
//检查外键字段长度
 objDataGridStyleEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetDgStyleId()
{
//获取某学院所有专业信息
string strSQL = "select DgStyleId, DgStyleName from DataGridStyle ";
 clsSpecSQLforSql mySql = clsDataGridStyleDA.GetSpecSQLObj();
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
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
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
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
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
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDataGridStyleEN._CurrTabName);
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
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDataGridStyleEN._CurrTabName, strCondition);
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
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
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
 objSQL = clsDataGridStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}