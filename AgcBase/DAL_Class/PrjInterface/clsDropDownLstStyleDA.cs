
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDropDownLstStyleDA
 表名:DropDownLstStyle(00050060)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:41
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
 /// 下拉框样式(DropDownLstStyle)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsDropDownLstStyleDA : clsCommBase4DA
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
 return clsDropDownLstStyleEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsDropDownLstStyleEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDropDownLstStyleEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsDropDownLstStyleEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsDropDownLstStyleEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strDropDownLstStyleId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strDropDownLstStyleId)
{
strDropDownLstStyleId = strDropDownLstStyleId.Replace("'", "''");
if (strDropDownLstStyleId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:DropDownLstStyle中,检查关键字,长度不正确!(clsDropDownLstStyleDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDropDownLstStyleId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:DropDownLstStyle中,关键字不能为空 或 null!(clsDropDownLstStyleDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDropDownLstStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsDropDownLstStyleDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsDropDownLstStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
strSQL = "Select * from DropDownLstStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_DropDownLstStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsDropDownLstStyleDA: GetDataTable_DropDownLstStyle)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
strSQL = "Select * from DropDownLstStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsDropDownLstStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsDropDownLstStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
strSQL = "Select * from DropDownLstStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsDropDownLstStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsDropDownLstStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DropDownLstStyle where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DropDownLstStyle where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsDropDownLstStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DropDownLstStyle where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsDropDownLstStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DropDownLstStyle.* " + 
$"from DropDownLstStyle " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DropDownLstStyle.DropDownLstStyleId not in " + 
$"(Select top {intTop_In} DropDownLstStyle.DropDownLstStyleId from DropDownLstStyle " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DropDownLstStyle where {1} and DropDownLstStyleId not in (Select top {2} DropDownLstStyleId from DropDownLstStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DropDownLstStyle where {1} and DropDownLstStyleId not in (Select top {3} DropDownLstStyleId from DropDownLstStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsDropDownLstStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DropDownLstStyle.* " + 
$"from DropDownLstStyle " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DropDownLstStyle.DropDownLstStyleId not in " + 
$"(Select top {intTop_In} DropDownLstStyle.DropDownLstStyleId from DropDownLstStyle " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DropDownLstStyle where {1} and DropDownLstStyleId not in (Select top {2} DropDownLstStyleId from DropDownLstStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DropDownLstStyle where {1} and DropDownLstStyleId not in (Select top {3} DropDownLstStyleId from DropDownLstStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsDropDownLstStyleEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsDropDownLstStyleDA:GetObjLst)", objException.Message));
}
List<clsDropDownLstStyleEN> arrObjLst = new List<clsDropDownLstStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
strSQL = "Select * from DropDownLstStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDropDownLstStyleEN objDropDownLstStyleEN = new clsDropDownLstStyleEN();
try
{
objDropDownLstStyleEN.DropDownLstStyleId = objRow[conDropDownLstStyle.DropDownLstStyleId].ToString().Trim(); //DropDownLstStyleId
objDropDownLstStyleEN.DropDownLstStyleName = objRow[conDropDownLstStyle.DropDownLstStyleName].ToString().Trim(); //DropDownLstStyleName
objDropDownLstStyleEN.Style = objRow[conDropDownLstStyle.Style] == DBNull.Value ? null : objRow[conDropDownLstStyle.Style].ToString().Trim(); //类型
objDropDownLstStyleEN.Runat = objRow[conDropDownLstStyle.Runat].ToString().Trim(); //运行在
objDropDownLstStyleEN.FontSize = objRow[conDropDownLstStyle.FontSize].ToString().Trim(); //字号
objDropDownLstStyleEN.FontName = objRow[conDropDownLstStyle.FontName].ToString().Trim(); //字体
objDropDownLstStyleEN.Width = objRow[conDropDownLstStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.Width].ToString().Trim()); //宽
objDropDownLstStyleEN.Height = objRow[conDropDownLstStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.Height].ToString().Trim()); //高度
objDropDownLstStyleEN.TextMode = objRow[conDropDownLstStyle.TextMode].ToString().Trim(); //TextMode
objDropDownLstStyleEN.ReadOnly = TransNullToBool(objRow[conDropDownLstStyle.ReadOnly].ToString().Trim()); //ReadOnly
objDropDownLstStyleEN.BackColor = objRow[conDropDownLstStyle.BackColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.BackColor].ToString().Trim(); //背景颜色
objDropDownLstStyleEN.ForeColor = objRow[conDropDownLstStyle.ForeColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.ForeColor].ToString().Trim(); //前景颜色
objDropDownLstStyleEN.DataTextField = objRow[conDropDownLstStyle.DataTextField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextField].ToString().Trim(); //DataTextField
objDropDownLstStyleEN.DataValueField = objRow[conDropDownLstStyle.DataValueField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataValueField].ToString().Trim(); //DataValueField
objDropDownLstStyleEN.DataTextFormatString = objRow[conDropDownLstStyle.DataTextFormatString] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextFormatString].ToString().Trim(); //DataTextFormatString
objDropDownLstStyleEN.AccessKey = objRow[conDropDownLstStyle.AccessKey] == DBNull.Value ? null : objRow[conDropDownLstStyle.AccessKey].ToString().Trim(); //AccessKey
objDropDownLstStyleEN.AutoPostBack = TransNullToBool(objRow[conDropDownLstStyle.AutoPostBack].ToString().Trim()); //AutoPostBack
objDropDownLstStyleEN.Visible = TransNullToBool(objRow[conDropDownLstStyle.Visible].ToString().Trim()); //Visible
objDropDownLstStyleEN.StyleZindex = objRow[conDropDownLstStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDropDownLstStyleEN.StyleLeft = objRow[conDropDownLstStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.StyleLeft].ToString().Trim()); //Style_Left
objDropDownLstStyleEN.StylePosition = objRow[conDropDownLstStyle.StylePosition] == DBNull.Value ? null : objRow[conDropDownLstStyle.StylePosition].ToString().Trim(); //Style_Position
objDropDownLstStyleEN.StyleTop = objRow[conDropDownLstStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDropDownLstStyleDA: GetObjLst)", objException.Message));
}
objDropDownLstStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDropDownLstStyleEN);
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
public List<clsDropDownLstStyleEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsDropDownLstStyleDA:GetObjLstByTabName)", objException.Message));
}
List<clsDropDownLstStyleEN> arrObjLst = new List<clsDropDownLstStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDropDownLstStyleEN objDropDownLstStyleEN = new clsDropDownLstStyleEN();
try
{
objDropDownLstStyleEN.DropDownLstStyleId = objRow[conDropDownLstStyle.DropDownLstStyleId].ToString().Trim(); //DropDownLstStyleId
objDropDownLstStyleEN.DropDownLstStyleName = objRow[conDropDownLstStyle.DropDownLstStyleName].ToString().Trim(); //DropDownLstStyleName
objDropDownLstStyleEN.Style = objRow[conDropDownLstStyle.Style] == DBNull.Value ? null : objRow[conDropDownLstStyle.Style].ToString().Trim(); //类型
objDropDownLstStyleEN.Runat = objRow[conDropDownLstStyle.Runat].ToString().Trim(); //运行在
objDropDownLstStyleEN.FontSize = objRow[conDropDownLstStyle.FontSize].ToString().Trim(); //字号
objDropDownLstStyleEN.FontName = objRow[conDropDownLstStyle.FontName].ToString().Trim(); //字体
objDropDownLstStyleEN.Width = objRow[conDropDownLstStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.Width].ToString().Trim()); //宽
objDropDownLstStyleEN.Height = objRow[conDropDownLstStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.Height].ToString().Trim()); //高度
objDropDownLstStyleEN.TextMode = objRow[conDropDownLstStyle.TextMode].ToString().Trim(); //TextMode
objDropDownLstStyleEN.ReadOnly = TransNullToBool(objRow[conDropDownLstStyle.ReadOnly].ToString().Trim()); //ReadOnly
objDropDownLstStyleEN.BackColor = objRow[conDropDownLstStyle.BackColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.BackColor].ToString().Trim(); //背景颜色
objDropDownLstStyleEN.ForeColor = objRow[conDropDownLstStyle.ForeColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.ForeColor].ToString().Trim(); //前景颜色
objDropDownLstStyleEN.DataTextField = objRow[conDropDownLstStyle.DataTextField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextField].ToString().Trim(); //DataTextField
objDropDownLstStyleEN.DataValueField = objRow[conDropDownLstStyle.DataValueField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataValueField].ToString().Trim(); //DataValueField
objDropDownLstStyleEN.DataTextFormatString = objRow[conDropDownLstStyle.DataTextFormatString] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextFormatString].ToString().Trim(); //DataTextFormatString
objDropDownLstStyleEN.AccessKey = objRow[conDropDownLstStyle.AccessKey] == DBNull.Value ? null : objRow[conDropDownLstStyle.AccessKey].ToString().Trim(); //AccessKey
objDropDownLstStyleEN.AutoPostBack = TransNullToBool(objRow[conDropDownLstStyle.AutoPostBack].ToString().Trim()); //AutoPostBack
objDropDownLstStyleEN.Visible = TransNullToBool(objRow[conDropDownLstStyle.Visible].ToString().Trim()); //Visible
objDropDownLstStyleEN.StyleZindex = objRow[conDropDownLstStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDropDownLstStyleEN.StyleLeft = objRow[conDropDownLstStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.StyleLeft].ToString().Trim()); //Style_Left
objDropDownLstStyleEN.StylePosition = objRow[conDropDownLstStyle.StylePosition] == DBNull.Value ? null : objRow[conDropDownLstStyle.StylePosition].ToString().Trim(); //Style_Position
objDropDownLstStyleEN.StyleTop = objRow[conDropDownLstStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDropDownLstStyleDA: GetObjLst)", objException.Message));
}
objDropDownLstStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDropDownLstStyleEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDropDownLstStyle(ref clsDropDownLstStyleEN objDropDownLstStyleEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
strSQL = "Select * from DropDownLstStyle where DropDownLstStyleId = " + "'"+ objDropDownLstStyleEN.DropDownLstStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objDropDownLstStyleEN.DropDownLstStyleId = objDT.Rows[0][conDropDownLstStyle.DropDownLstStyleId].ToString().Trim(); //DropDownLstStyleId(字段类型:varchar,字段长度:4,是否可空:False)
 objDropDownLstStyleEN.DropDownLstStyleName = objDT.Rows[0][conDropDownLstStyle.DropDownLstStyleName].ToString().Trim(); //DropDownLstStyleName(字段类型:varchar,字段长度:30,是否可空:False)
 objDropDownLstStyleEN.Style = objDT.Rows[0][conDropDownLstStyle.Style].ToString().Trim(); //类型(字段类型:varchar,字段长度:800,是否可空:True)
 objDropDownLstStyleEN.Runat = objDT.Rows[0][conDropDownLstStyle.Runat].ToString().Trim(); //运行在(字段类型:varchar,字段长度:30,是否可空:True)
 objDropDownLstStyleEN.FontSize = objDT.Rows[0][conDropDownLstStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objDropDownLstStyleEN.FontName = objDT.Rows[0][conDropDownLstStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objDropDownLstStyleEN.Width = TransNullToInt(objDT.Rows[0][conDropDownLstStyle.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objDropDownLstStyleEN.Height = TransNullToInt(objDT.Rows[0][conDropDownLstStyle.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objDropDownLstStyleEN.TextMode = objDT.Rows[0][conDropDownLstStyle.TextMode].ToString().Trim(); //TextMode(字段类型:varchar,字段长度:20,是否可空:False)
 objDropDownLstStyleEN.ReadOnly = TransNullToBool(objDT.Rows[0][conDropDownLstStyle.ReadOnly].ToString().Trim()); //ReadOnly(字段类型:bit,字段长度:1,是否可空:False)
 objDropDownLstStyleEN.BackColor = objDT.Rows[0][conDropDownLstStyle.BackColor].ToString().Trim(); //背景颜色(字段类型:varchar,字段长度:30,是否可空:False)
 objDropDownLstStyleEN.ForeColor = objDT.Rows[0][conDropDownLstStyle.ForeColor].ToString().Trim(); //前景颜色(字段类型:varchar,字段长度:30,是否可空:False)
 objDropDownLstStyleEN.DataTextField = objDT.Rows[0][conDropDownLstStyle.DataTextField].ToString().Trim(); //DataTextField(字段类型:varchar,字段长度:30,是否可空:True)
 objDropDownLstStyleEN.DataValueField = objDT.Rows[0][conDropDownLstStyle.DataValueField].ToString().Trim(); //DataValueField(字段类型:varchar,字段长度:30,是否可空:True)
 objDropDownLstStyleEN.DataTextFormatString = objDT.Rows[0][conDropDownLstStyle.DataTextFormatString].ToString().Trim(); //DataTextFormatString(字段类型:varchar,字段长度:30,是否可空:True)
 objDropDownLstStyleEN.AccessKey = objDT.Rows[0][conDropDownLstStyle.AccessKey].ToString().Trim(); //AccessKey(字段类型:varchar,字段长度:30,是否可空:True)
 objDropDownLstStyleEN.AutoPostBack = TransNullToBool(objDT.Rows[0][conDropDownLstStyle.AutoPostBack].ToString().Trim()); //AutoPostBack(字段类型:bit,字段长度:1,是否可空:True)
 objDropDownLstStyleEN.Visible = TransNullToBool(objDT.Rows[0][conDropDownLstStyle.Visible].ToString().Trim()); //Visible(字段类型:bit,字段长度:1,是否可空:True)
 objDropDownLstStyleEN.StyleZindex = TransNullToInt(objDT.Rows[0][conDropDownLstStyle.StyleZindex].ToString().Trim()); //Style_Zindex(字段类型:int,字段长度:4,是否可空:True)
 objDropDownLstStyleEN.StyleLeft = TransNullToInt(objDT.Rows[0][conDropDownLstStyle.StyleLeft].ToString().Trim()); //Style_Left(字段类型:int,字段长度:4,是否可空:True)
 objDropDownLstStyleEN.StylePosition = objDT.Rows[0][conDropDownLstStyle.StylePosition].ToString().Trim(); //Style_Position(字段类型:varchar,字段长度:20,是否可空:True)
 objDropDownLstStyleEN.StyleTop = TransNullToInt(objDT.Rows[0][conDropDownLstStyle.StyleTop].ToString().Trim()); //Style_Top(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsDropDownLstStyleDA: GetDropDownLstStyle)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDropDownLstStyleId">表关键字</param>
 /// <returns>表对象</returns>
public clsDropDownLstStyleEN GetObjByDropDownLstStyleId(string strDropDownLstStyleId)
{
CheckPrimaryKey(strDropDownLstStyleId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
strSQL = "Select * from DropDownLstStyle where DropDownLstStyleId = " + "'"+ strDropDownLstStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsDropDownLstStyleEN objDropDownLstStyleEN = new clsDropDownLstStyleEN();
try
{
 objDropDownLstStyleEN.DropDownLstStyleId = objRow[conDropDownLstStyle.DropDownLstStyleId].ToString().Trim(); //DropDownLstStyleId(字段类型:varchar,字段长度:4,是否可空:False)
 objDropDownLstStyleEN.DropDownLstStyleName = objRow[conDropDownLstStyle.DropDownLstStyleName].ToString().Trim(); //DropDownLstStyleName(字段类型:varchar,字段长度:30,是否可空:False)
 objDropDownLstStyleEN.Style = objRow[conDropDownLstStyle.Style] == DBNull.Value ? null : objRow[conDropDownLstStyle.Style].ToString().Trim(); //类型(字段类型:varchar,字段长度:800,是否可空:True)
 objDropDownLstStyleEN.Runat = objRow[conDropDownLstStyle.Runat].ToString().Trim(); //运行在(字段类型:varchar,字段长度:30,是否可空:True)
 objDropDownLstStyleEN.FontSize = objRow[conDropDownLstStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objDropDownLstStyleEN.FontName = objRow[conDropDownLstStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objDropDownLstStyleEN.Width = objRow[conDropDownLstStyle.Width] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objDropDownLstStyleEN.Height = objRow[conDropDownLstStyle.Height] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objDropDownLstStyleEN.TextMode = objRow[conDropDownLstStyle.TextMode].ToString().Trim(); //TextMode(字段类型:varchar,字段长度:20,是否可空:False)
 objDropDownLstStyleEN.ReadOnly = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.ReadOnly].ToString().Trim()); //ReadOnly(字段类型:bit,字段长度:1,是否可空:False)
 objDropDownLstStyleEN.BackColor = objRow[conDropDownLstStyle.BackColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.BackColor].ToString().Trim(); //背景颜色(字段类型:varchar,字段长度:30,是否可空:False)
 objDropDownLstStyleEN.ForeColor = objRow[conDropDownLstStyle.ForeColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.ForeColor].ToString().Trim(); //前景颜色(字段类型:varchar,字段长度:30,是否可空:False)
 objDropDownLstStyleEN.DataTextField = objRow[conDropDownLstStyle.DataTextField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextField].ToString().Trim(); //DataTextField(字段类型:varchar,字段长度:30,是否可空:True)
 objDropDownLstStyleEN.DataValueField = objRow[conDropDownLstStyle.DataValueField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataValueField].ToString().Trim(); //DataValueField(字段类型:varchar,字段长度:30,是否可空:True)
 objDropDownLstStyleEN.DataTextFormatString = objRow[conDropDownLstStyle.DataTextFormatString] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextFormatString].ToString().Trim(); //DataTextFormatString(字段类型:varchar,字段长度:30,是否可空:True)
 objDropDownLstStyleEN.AccessKey = objRow[conDropDownLstStyle.AccessKey] == DBNull.Value ? null : objRow[conDropDownLstStyle.AccessKey].ToString().Trim(); //AccessKey(字段类型:varchar,字段长度:30,是否可空:True)
 objDropDownLstStyleEN.AutoPostBack = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.AutoPostBack].ToString().Trim()); //AutoPostBack(字段类型:bit,字段长度:1,是否可空:True)
 objDropDownLstStyleEN.Visible = clsEntityBase2.TransNullToBool_S(objRow[conDropDownLstStyle.Visible].ToString().Trim()); //Visible(字段类型:bit,字段长度:1,是否可空:True)
 objDropDownLstStyleEN.StyleZindex = objRow[conDropDownLstStyle.StyleZindex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleZindex].ToString().Trim()); //Style_Zindex(字段类型:int,字段长度:4,是否可空:True)
 objDropDownLstStyleEN.StyleLeft = objRow[conDropDownLstStyle.StyleLeft] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleLeft].ToString().Trim()); //Style_Left(字段类型:int,字段长度:4,是否可空:True)
 objDropDownLstStyleEN.StylePosition = objRow[conDropDownLstStyle.StylePosition] == DBNull.Value ? null : objRow[conDropDownLstStyle.StylePosition].ToString().Trim(); //Style_Position(字段类型:varchar,字段长度:20,是否可空:True)
 objDropDownLstStyleEN.StyleTop = objRow[conDropDownLstStyle.StyleTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDropDownLstStyle.StyleTop].ToString().Trim()); //Style_Top(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsDropDownLstStyleDA: GetObjByDropDownLstStyleId)", objException.Message));
}
return objDropDownLstStyleEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDropDownLstStyleEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsDropDownLstStyleDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
strSQL = "Select * from DropDownLstStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsDropDownLstStyleEN objDropDownLstStyleEN = new clsDropDownLstStyleEN()
{
DropDownLstStyleId = objRow[conDropDownLstStyle.DropDownLstStyleId].ToString().Trim(), //DropDownLstStyleId
DropDownLstStyleName = objRow[conDropDownLstStyle.DropDownLstStyleName].ToString().Trim(), //DropDownLstStyleName
Style = objRow[conDropDownLstStyle.Style] == DBNull.Value ? null : objRow[conDropDownLstStyle.Style].ToString().Trim(), //类型
Runat = objRow[conDropDownLstStyle.Runat].ToString().Trim(), //运行在
FontSize = objRow[conDropDownLstStyle.FontSize].ToString().Trim(), //字号
FontName = objRow[conDropDownLstStyle.FontName].ToString().Trim(), //字体
Width = objRow[conDropDownLstStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.Width].ToString().Trim()), //宽
Height = objRow[conDropDownLstStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.Height].ToString().Trim()), //高度
TextMode = objRow[conDropDownLstStyle.TextMode].ToString().Trim(), //TextMode
ReadOnly = TransNullToBool(objRow[conDropDownLstStyle.ReadOnly].ToString().Trim()), //ReadOnly
BackColor = objRow[conDropDownLstStyle.BackColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.BackColor].ToString().Trim(), //背景颜色
ForeColor = objRow[conDropDownLstStyle.ForeColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.ForeColor].ToString().Trim(), //前景颜色
DataTextField = objRow[conDropDownLstStyle.DataTextField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextField].ToString().Trim(), //DataTextField
DataValueField = objRow[conDropDownLstStyle.DataValueField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataValueField].ToString().Trim(), //DataValueField
DataTextFormatString = objRow[conDropDownLstStyle.DataTextFormatString] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextFormatString].ToString().Trim(), //DataTextFormatString
AccessKey = objRow[conDropDownLstStyle.AccessKey] == DBNull.Value ? null : objRow[conDropDownLstStyle.AccessKey].ToString().Trim(), //AccessKey
AutoPostBack = TransNullToBool(objRow[conDropDownLstStyle.AutoPostBack].ToString().Trim()), //AutoPostBack
Visible = TransNullToBool(objRow[conDropDownLstStyle.Visible].ToString().Trim()), //Visible
StyleZindex = objRow[conDropDownLstStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.StyleZindex].ToString().Trim()), //Style_Zindex
StyleLeft = objRow[conDropDownLstStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.StyleLeft].ToString().Trim()), //Style_Left
StylePosition = objRow[conDropDownLstStyle.StylePosition] == DBNull.Value ? null : objRow[conDropDownLstStyle.StylePosition].ToString().Trim(), //Style_Position
StyleTop = objRow[conDropDownLstStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.StyleTop].ToString().Trim()) //Style_Top
};
objDropDownLstStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDropDownLstStyleEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsDropDownLstStyleDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsDropDownLstStyleEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDropDownLstStyleEN objDropDownLstStyleEN = new clsDropDownLstStyleEN();
try
{
objDropDownLstStyleEN.DropDownLstStyleId = objRow[conDropDownLstStyle.DropDownLstStyleId].ToString().Trim(); //DropDownLstStyleId
objDropDownLstStyleEN.DropDownLstStyleName = objRow[conDropDownLstStyle.DropDownLstStyleName].ToString().Trim(); //DropDownLstStyleName
objDropDownLstStyleEN.Style = objRow[conDropDownLstStyle.Style] == DBNull.Value ? null : objRow[conDropDownLstStyle.Style].ToString().Trim(); //类型
objDropDownLstStyleEN.Runat = objRow[conDropDownLstStyle.Runat].ToString().Trim(); //运行在
objDropDownLstStyleEN.FontSize = objRow[conDropDownLstStyle.FontSize].ToString().Trim(); //字号
objDropDownLstStyleEN.FontName = objRow[conDropDownLstStyle.FontName].ToString().Trim(); //字体
objDropDownLstStyleEN.Width = objRow[conDropDownLstStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.Width].ToString().Trim()); //宽
objDropDownLstStyleEN.Height = objRow[conDropDownLstStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.Height].ToString().Trim()); //高度
objDropDownLstStyleEN.TextMode = objRow[conDropDownLstStyle.TextMode].ToString().Trim(); //TextMode
objDropDownLstStyleEN.ReadOnly = TransNullToBool(objRow[conDropDownLstStyle.ReadOnly].ToString().Trim()); //ReadOnly
objDropDownLstStyleEN.BackColor = objRow[conDropDownLstStyle.BackColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.BackColor].ToString().Trim(); //背景颜色
objDropDownLstStyleEN.ForeColor = objRow[conDropDownLstStyle.ForeColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.ForeColor].ToString().Trim(); //前景颜色
objDropDownLstStyleEN.DataTextField = objRow[conDropDownLstStyle.DataTextField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextField].ToString().Trim(); //DataTextField
objDropDownLstStyleEN.DataValueField = objRow[conDropDownLstStyle.DataValueField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataValueField].ToString().Trim(); //DataValueField
objDropDownLstStyleEN.DataTextFormatString = objRow[conDropDownLstStyle.DataTextFormatString] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextFormatString].ToString().Trim(); //DataTextFormatString
objDropDownLstStyleEN.AccessKey = objRow[conDropDownLstStyle.AccessKey] == DBNull.Value ? null : objRow[conDropDownLstStyle.AccessKey].ToString().Trim(); //AccessKey
objDropDownLstStyleEN.AutoPostBack = TransNullToBool(objRow[conDropDownLstStyle.AutoPostBack].ToString().Trim()); //AutoPostBack
objDropDownLstStyleEN.Visible = TransNullToBool(objRow[conDropDownLstStyle.Visible].ToString().Trim()); //Visible
objDropDownLstStyleEN.StyleZindex = objRow[conDropDownLstStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDropDownLstStyleEN.StyleLeft = objRow[conDropDownLstStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.StyleLeft].ToString().Trim()); //Style_Left
objDropDownLstStyleEN.StylePosition = objRow[conDropDownLstStyle.StylePosition] == DBNull.Value ? null : objRow[conDropDownLstStyle.StylePosition].ToString().Trim(); //Style_Position
objDropDownLstStyleEN.StyleTop = objRow[conDropDownLstStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsDropDownLstStyleDA: GetObjByDataRowDropDownLstStyle)", objException.Message));
}
objDropDownLstStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDropDownLstStyleEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsDropDownLstStyleEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDropDownLstStyleEN objDropDownLstStyleEN = new clsDropDownLstStyleEN();
try
{
objDropDownLstStyleEN.DropDownLstStyleId = objRow[conDropDownLstStyle.DropDownLstStyleId].ToString().Trim(); //DropDownLstStyleId
objDropDownLstStyleEN.DropDownLstStyleName = objRow[conDropDownLstStyle.DropDownLstStyleName].ToString().Trim(); //DropDownLstStyleName
objDropDownLstStyleEN.Style = objRow[conDropDownLstStyle.Style] == DBNull.Value ? null : objRow[conDropDownLstStyle.Style].ToString().Trim(); //类型
objDropDownLstStyleEN.Runat = objRow[conDropDownLstStyle.Runat].ToString().Trim(); //运行在
objDropDownLstStyleEN.FontSize = objRow[conDropDownLstStyle.FontSize].ToString().Trim(); //字号
objDropDownLstStyleEN.FontName = objRow[conDropDownLstStyle.FontName].ToString().Trim(); //字体
objDropDownLstStyleEN.Width = objRow[conDropDownLstStyle.Width] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.Width].ToString().Trim()); //宽
objDropDownLstStyleEN.Height = objRow[conDropDownLstStyle.Height] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.Height].ToString().Trim()); //高度
objDropDownLstStyleEN.TextMode = objRow[conDropDownLstStyle.TextMode].ToString().Trim(); //TextMode
objDropDownLstStyleEN.ReadOnly = TransNullToBool(objRow[conDropDownLstStyle.ReadOnly].ToString().Trim()); //ReadOnly
objDropDownLstStyleEN.BackColor = objRow[conDropDownLstStyle.BackColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.BackColor].ToString().Trim(); //背景颜色
objDropDownLstStyleEN.ForeColor = objRow[conDropDownLstStyle.ForeColor] == DBNull.Value ? null : objRow[conDropDownLstStyle.ForeColor].ToString().Trim(); //前景颜色
objDropDownLstStyleEN.DataTextField = objRow[conDropDownLstStyle.DataTextField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextField].ToString().Trim(); //DataTextField
objDropDownLstStyleEN.DataValueField = objRow[conDropDownLstStyle.DataValueField] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataValueField].ToString().Trim(); //DataValueField
objDropDownLstStyleEN.DataTextFormatString = objRow[conDropDownLstStyle.DataTextFormatString] == DBNull.Value ? null : objRow[conDropDownLstStyle.DataTextFormatString].ToString().Trim(); //DataTextFormatString
objDropDownLstStyleEN.AccessKey = objRow[conDropDownLstStyle.AccessKey] == DBNull.Value ? null : objRow[conDropDownLstStyle.AccessKey].ToString().Trim(); //AccessKey
objDropDownLstStyleEN.AutoPostBack = TransNullToBool(objRow[conDropDownLstStyle.AutoPostBack].ToString().Trim()); //AutoPostBack
objDropDownLstStyleEN.Visible = TransNullToBool(objRow[conDropDownLstStyle.Visible].ToString().Trim()); //Visible
objDropDownLstStyleEN.StyleZindex = objRow[conDropDownLstStyle.StyleZindex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objDropDownLstStyleEN.StyleLeft = objRow[conDropDownLstStyle.StyleLeft] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.StyleLeft].ToString().Trim()); //Style_Left
objDropDownLstStyleEN.StylePosition = objRow[conDropDownLstStyle.StylePosition] == DBNull.Value ? null : objRow[conDropDownLstStyle.StylePosition].ToString().Trim(); //Style_Position
objDropDownLstStyleEN.StyleTop = objRow[conDropDownLstStyle.StyleTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDropDownLstStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsDropDownLstStyleDA: GetObjByDataRow)", objException.Message));
}
objDropDownLstStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDropDownLstStyleEN;
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
objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDropDownLstStyleEN._CurrTabName, conDropDownLstStyle.DropDownLstStyleId, 4, "");
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
objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDropDownLstStyleEN._CurrTabName, conDropDownLstStyle.DropDownLstStyleId, 4, strPrefix);
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
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DropDownLstStyleId from DropDownLstStyle where " + strCondition;
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
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DropDownLstStyleId from DropDownLstStyle where " + strCondition;
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
 /// <param name = "strDropDownLstStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strDropDownLstStyleId)
{
CheckPrimaryKey(strDropDownLstStyleId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DropDownLstStyle", "DropDownLstStyleId = " + "'"+ strDropDownLstStyleId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsDropDownLstStyleDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DropDownLstStyle", strCondition))
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
objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("DropDownLstStyle");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsDropDownLstStyleEN objDropDownLstStyleEN)
 {
 if (objDropDownLstStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDropDownLstStyleEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
strSQL = "Select * from DropDownLstStyle where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DropDownLstStyle");
objRow = objDS.Tables["DropDownLstStyle"].NewRow();
objRow[conDropDownLstStyle.DropDownLstStyleId] = objDropDownLstStyleEN.DropDownLstStyleId; //DropDownLstStyleId
objRow[conDropDownLstStyle.DropDownLstStyleName] = objDropDownLstStyleEN.DropDownLstStyleName; //DropDownLstStyleName
 if (objDropDownLstStyleEN.Style !=  "")
 {
objRow[conDropDownLstStyle.Style] = objDropDownLstStyleEN.Style; //类型
 }
objRow[conDropDownLstStyle.Runat] = objDropDownLstStyleEN.Runat; //运行在
objRow[conDropDownLstStyle.FontSize] = objDropDownLstStyleEN.FontSize; //字号
objRow[conDropDownLstStyle.FontName] = objDropDownLstStyleEN.FontName; //字体
objRow[conDropDownLstStyle.Width] = objDropDownLstStyleEN.Width; //宽
objRow[conDropDownLstStyle.Height] = objDropDownLstStyleEN.Height; //高度
objRow[conDropDownLstStyle.TextMode] = objDropDownLstStyleEN.TextMode; //TextMode
objRow[conDropDownLstStyle.ReadOnly] = objDropDownLstStyleEN.ReadOnly; //ReadOnly
 if (objDropDownLstStyleEN.BackColor !=  "")
 {
objRow[conDropDownLstStyle.BackColor] = objDropDownLstStyleEN.BackColor; //背景颜色
 }
 if (objDropDownLstStyleEN.ForeColor !=  "")
 {
objRow[conDropDownLstStyle.ForeColor] = objDropDownLstStyleEN.ForeColor; //前景颜色
 }
 if (objDropDownLstStyleEN.DataTextField !=  "")
 {
objRow[conDropDownLstStyle.DataTextField] = objDropDownLstStyleEN.DataTextField; //DataTextField
 }
 if (objDropDownLstStyleEN.DataValueField !=  "")
 {
objRow[conDropDownLstStyle.DataValueField] = objDropDownLstStyleEN.DataValueField; //DataValueField
 }
 if (objDropDownLstStyleEN.DataTextFormatString !=  "")
 {
objRow[conDropDownLstStyle.DataTextFormatString] = objDropDownLstStyleEN.DataTextFormatString; //DataTextFormatString
 }
 if (objDropDownLstStyleEN.AccessKey !=  "")
 {
objRow[conDropDownLstStyle.AccessKey] = objDropDownLstStyleEN.AccessKey; //AccessKey
 }
objRow[conDropDownLstStyle.AutoPostBack] = objDropDownLstStyleEN.AutoPostBack; //AutoPostBack
objRow[conDropDownLstStyle.Visible] = objDropDownLstStyleEN.Visible; //Visible
objRow[conDropDownLstStyle.StyleZindex] = objDropDownLstStyleEN.StyleZindex; //Style_Zindex
objRow[conDropDownLstStyle.StyleLeft] = objDropDownLstStyleEN.StyleLeft; //Style_Left
 if (objDropDownLstStyleEN.StylePosition !=  "")
 {
objRow[conDropDownLstStyle.StylePosition] = objDropDownLstStyleEN.StylePosition; //Style_Position
 }
objRow[conDropDownLstStyle.StyleTop] = objDropDownLstStyleEN.StyleTop; //Style_Top
objDS.Tables[clsDropDownLstStyleEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsDropDownLstStyleEN._CurrTabName);
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
 /// <param name = "objDropDownLstStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDropDownLstStyleEN objDropDownLstStyleEN)
{
 if (objDropDownLstStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDropDownLstStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDropDownLstStyleEN.DropDownLstStyleId !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DropDownLstStyleId);
 var strDropDownLstStyleId = objDropDownLstStyleEN.DropDownLstStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDropDownLstStyleId + "'");
 }
 
 if (objDropDownLstStyleEN.DropDownLstStyleName !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DropDownLstStyleName);
 var strDropDownLstStyleName = objDropDownLstStyleEN.DropDownLstStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDropDownLstStyleName + "'");
 }
 
 if (objDropDownLstStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.Style);
 var strStyle = objDropDownLstStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objDropDownLstStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.Runat);
 var strRunat = objDropDownLstStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objDropDownLstStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.FontSize);
 var strFontSize = objDropDownLstStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objDropDownLstStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.FontName);
 var strFontName = objDropDownLstStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objDropDownLstStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.Width);
 arrValueListForInsert.Add(objDropDownLstStyleEN.Width.ToString());
 }
 
 if (objDropDownLstStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.Height);
 arrValueListForInsert.Add(objDropDownLstStyleEN.Height.ToString());
 }
 
 if (objDropDownLstStyleEN.TextMode !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.TextMode);
 var strTextMode = objDropDownLstStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextMode + "'");
 }
 
 arrFieldListForInsert.Add(conDropDownLstStyle.ReadOnly);
 arrValueListForInsert.Add("'" + (objDropDownLstStyleEN.ReadOnly  ==  false ? "0" : "1") + "'");
 
 if (objDropDownLstStyleEN.BackColor !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.BackColor);
 var strBackColor = objDropDownLstStyleEN.BackColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBackColor + "'");
 }
 
 if (objDropDownLstStyleEN.ForeColor !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.ForeColor);
 var strForeColor = objDropDownLstStyleEN.ForeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeColor + "'");
 }
 
 if (objDropDownLstStyleEN.DataTextField !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DataTextField);
 var strDataTextField = objDropDownLstStyleEN.DataTextField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTextField + "'");
 }
 
 if (objDropDownLstStyleEN.DataValueField !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DataValueField);
 var strDataValueField = objDropDownLstStyleEN.DataValueField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataValueField + "'");
 }
 
 if (objDropDownLstStyleEN.DataTextFormatString !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DataTextFormatString);
 var strDataTextFormatString = objDropDownLstStyleEN.DataTextFormatString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTextFormatString + "'");
 }
 
 if (objDropDownLstStyleEN.AccessKey !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.AccessKey);
 var strAccessKey = objDropDownLstStyleEN.AccessKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAccessKey + "'");
 }
 
 arrFieldListForInsert.Add(conDropDownLstStyle.AutoPostBack);
 arrValueListForInsert.Add("'" + (objDropDownLstStyleEN.AutoPostBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDropDownLstStyle.Visible);
 arrValueListForInsert.Add("'" + (objDropDownLstStyleEN.Visible  ==  false ? "0" : "1") + "'");
 
 if (objDropDownLstStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.StyleZindex);
 arrValueListForInsert.Add(objDropDownLstStyleEN.StyleZindex.ToString());
 }
 
 if (objDropDownLstStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.StyleLeft);
 arrValueListForInsert.Add(objDropDownLstStyleEN.StyleLeft.ToString());
 }
 
 if (objDropDownLstStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.StylePosition);
 var strStylePosition = objDropDownLstStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objDropDownLstStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.StyleTop);
 arrValueListForInsert.Add(objDropDownLstStyleEN.StyleTop.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DropDownLstStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDropDownLstStyleEN objDropDownLstStyleEN)
{
 if (objDropDownLstStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDropDownLstStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDropDownLstStyleEN.DropDownLstStyleId !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DropDownLstStyleId);
 var strDropDownLstStyleId = objDropDownLstStyleEN.DropDownLstStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDropDownLstStyleId + "'");
 }
 
 if (objDropDownLstStyleEN.DropDownLstStyleName !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DropDownLstStyleName);
 var strDropDownLstStyleName = objDropDownLstStyleEN.DropDownLstStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDropDownLstStyleName + "'");
 }
 
 if (objDropDownLstStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.Style);
 var strStyle = objDropDownLstStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objDropDownLstStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.Runat);
 var strRunat = objDropDownLstStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objDropDownLstStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.FontSize);
 var strFontSize = objDropDownLstStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objDropDownLstStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.FontName);
 var strFontName = objDropDownLstStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objDropDownLstStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.Width);
 arrValueListForInsert.Add(objDropDownLstStyleEN.Width.ToString());
 }
 
 if (objDropDownLstStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.Height);
 arrValueListForInsert.Add(objDropDownLstStyleEN.Height.ToString());
 }
 
 if (objDropDownLstStyleEN.TextMode !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.TextMode);
 var strTextMode = objDropDownLstStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextMode + "'");
 }
 
 arrFieldListForInsert.Add(conDropDownLstStyle.ReadOnly);
 arrValueListForInsert.Add("'" + (objDropDownLstStyleEN.ReadOnly  ==  false ? "0" : "1") + "'");
 
 if (objDropDownLstStyleEN.BackColor !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.BackColor);
 var strBackColor = objDropDownLstStyleEN.BackColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBackColor + "'");
 }
 
 if (objDropDownLstStyleEN.ForeColor !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.ForeColor);
 var strForeColor = objDropDownLstStyleEN.ForeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeColor + "'");
 }
 
 if (objDropDownLstStyleEN.DataTextField !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DataTextField);
 var strDataTextField = objDropDownLstStyleEN.DataTextField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTextField + "'");
 }
 
 if (objDropDownLstStyleEN.DataValueField !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DataValueField);
 var strDataValueField = objDropDownLstStyleEN.DataValueField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataValueField + "'");
 }
 
 if (objDropDownLstStyleEN.DataTextFormatString !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DataTextFormatString);
 var strDataTextFormatString = objDropDownLstStyleEN.DataTextFormatString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTextFormatString + "'");
 }
 
 if (objDropDownLstStyleEN.AccessKey !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.AccessKey);
 var strAccessKey = objDropDownLstStyleEN.AccessKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAccessKey + "'");
 }
 
 arrFieldListForInsert.Add(conDropDownLstStyle.AutoPostBack);
 arrValueListForInsert.Add("'" + (objDropDownLstStyleEN.AutoPostBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDropDownLstStyle.Visible);
 arrValueListForInsert.Add("'" + (objDropDownLstStyleEN.Visible  ==  false ? "0" : "1") + "'");
 
 if (objDropDownLstStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.StyleZindex);
 arrValueListForInsert.Add(objDropDownLstStyleEN.StyleZindex.ToString());
 }
 
 if (objDropDownLstStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.StyleLeft);
 arrValueListForInsert.Add(objDropDownLstStyleEN.StyleLeft.ToString());
 }
 
 if (objDropDownLstStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.StylePosition);
 var strStylePosition = objDropDownLstStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objDropDownLstStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.StyleTop);
 arrValueListForInsert.Add(objDropDownLstStyleEN.StyleTop.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DropDownLstStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objDropDownLstStyleEN.DropDownLstStyleId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDropDownLstStyleEN objDropDownLstStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objDropDownLstStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDropDownLstStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDropDownLstStyleEN.DropDownLstStyleId !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DropDownLstStyleId);
 var strDropDownLstStyleId = objDropDownLstStyleEN.DropDownLstStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDropDownLstStyleId + "'");
 }
 
 if (objDropDownLstStyleEN.DropDownLstStyleName !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DropDownLstStyleName);
 var strDropDownLstStyleName = objDropDownLstStyleEN.DropDownLstStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDropDownLstStyleName + "'");
 }
 
 if (objDropDownLstStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.Style);
 var strStyle = objDropDownLstStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objDropDownLstStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.Runat);
 var strRunat = objDropDownLstStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objDropDownLstStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.FontSize);
 var strFontSize = objDropDownLstStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objDropDownLstStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.FontName);
 var strFontName = objDropDownLstStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objDropDownLstStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.Width);
 arrValueListForInsert.Add(objDropDownLstStyleEN.Width.ToString());
 }
 
 if (objDropDownLstStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.Height);
 arrValueListForInsert.Add(objDropDownLstStyleEN.Height.ToString());
 }
 
 if (objDropDownLstStyleEN.TextMode !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.TextMode);
 var strTextMode = objDropDownLstStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextMode + "'");
 }
 
 arrFieldListForInsert.Add(conDropDownLstStyle.ReadOnly);
 arrValueListForInsert.Add("'" + (objDropDownLstStyleEN.ReadOnly  ==  false ? "0" : "1") + "'");
 
 if (objDropDownLstStyleEN.BackColor !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.BackColor);
 var strBackColor = objDropDownLstStyleEN.BackColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBackColor + "'");
 }
 
 if (objDropDownLstStyleEN.ForeColor !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.ForeColor);
 var strForeColor = objDropDownLstStyleEN.ForeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeColor + "'");
 }
 
 if (objDropDownLstStyleEN.DataTextField !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DataTextField);
 var strDataTextField = objDropDownLstStyleEN.DataTextField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTextField + "'");
 }
 
 if (objDropDownLstStyleEN.DataValueField !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DataValueField);
 var strDataValueField = objDropDownLstStyleEN.DataValueField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataValueField + "'");
 }
 
 if (objDropDownLstStyleEN.DataTextFormatString !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DataTextFormatString);
 var strDataTextFormatString = objDropDownLstStyleEN.DataTextFormatString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTextFormatString + "'");
 }
 
 if (objDropDownLstStyleEN.AccessKey !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.AccessKey);
 var strAccessKey = objDropDownLstStyleEN.AccessKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAccessKey + "'");
 }
 
 arrFieldListForInsert.Add(conDropDownLstStyle.AutoPostBack);
 arrValueListForInsert.Add("'" + (objDropDownLstStyleEN.AutoPostBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDropDownLstStyle.Visible);
 arrValueListForInsert.Add("'" + (objDropDownLstStyleEN.Visible  ==  false ? "0" : "1") + "'");
 
 if (objDropDownLstStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.StyleZindex);
 arrValueListForInsert.Add(objDropDownLstStyleEN.StyleZindex.ToString());
 }
 
 if (objDropDownLstStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.StyleLeft);
 arrValueListForInsert.Add(objDropDownLstStyleEN.StyleLeft.ToString());
 }
 
 if (objDropDownLstStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.StylePosition);
 var strStylePosition = objDropDownLstStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objDropDownLstStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.StyleTop);
 arrValueListForInsert.Add(objDropDownLstStyleEN.StyleTop.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DropDownLstStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objDropDownLstStyleEN.DropDownLstStyleId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objDropDownLstStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDropDownLstStyleEN objDropDownLstStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objDropDownLstStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDropDownLstStyleEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objDropDownLstStyleEN.DropDownLstStyleId !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DropDownLstStyleId);
 var strDropDownLstStyleId = objDropDownLstStyleEN.DropDownLstStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDropDownLstStyleId + "'");
 }
 
 if (objDropDownLstStyleEN.DropDownLstStyleName !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DropDownLstStyleName);
 var strDropDownLstStyleName = objDropDownLstStyleEN.DropDownLstStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDropDownLstStyleName + "'");
 }
 
 if (objDropDownLstStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.Style);
 var strStyle = objDropDownLstStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objDropDownLstStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.Runat);
 var strRunat = objDropDownLstStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objDropDownLstStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.FontSize);
 var strFontSize = objDropDownLstStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objDropDownLstStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.FontName);
 var strFontName = objDropDownLstStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 if (objDropDownLstStyleEN.Width !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.Width);
 arrValueListForInsert.Add(objDropDownLstStyleEN.Width.ToString());
 }
 
 if (objDropDownLstStyleEN.Height !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.Height);
 arrValueListForInsert.Add(objDropDownLstStyleEN.Height.ToString());
 }
 
 if (objDropDownLstStyleEN.TextMode !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.TextMode);
 var strTextMode = objDropDownLstStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextMode + "'");
 }
 
 arrFieldListForInsert.Add(conDropDownLstStyle.ReadOnly);
 arrValueListForInsert.Add("'" + (objDropDownLstStyleEN.ReadOnly  ==  false ? "0" : "1") + "'");
 
 if (objDropDownLstStyleEN.BackColor !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.BackColor);
 var strBackColor = objDropDownLstStyleEN.BackColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBackColor + "'");
 }
 
 if (objDropDownLstStyleEN.ForeColor !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.ForeColor);
 var strForeColor = objDropDownLstStyleEN.ForeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strForeColor + "'");
 }
 
 if (objDropDownLstStyleEN.DataTextField !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DataTextField);
 var strDataTextField = objDropDownLstStyleEN.DataTextField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTextField + "'");
 }
 
 if (objDropDownLstStyleEN.DataValueField !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DataValueField);
 var strDataValueField = objDropDownLstStyleEN.DataValueField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataValueField + "'");
 }
 
 if (objDropDownLstStyleEN.DataTextFormatString !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.DataTextFormatString);
 var strDataTextFormatString = objDropDownLstStyleEN.DataTextFormatString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataTextFormatString + "'");
 }
 
 if (objDropDownLstStyleEN.AccessKey !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.AccessKey);
 var strAccessKey = objDropDownLstStyleEN.AccessKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAccessKey + "'");
 }
 
 arrFieldListForInsert.Add(conDropDownLstStyle.AutoPostBack);
 arrValueListForInsert.Add("'" + (objDropDownLstStyleEN.AutoPostBack  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conDropDownLstStyle.Visible);
 arrValueListForInsert.Add("'" + (objDropDownLstStyleEN.Visible  ==  false ? "0" : "1") + "'");
 
 if (objDropDownLstStyleEN.StyleZindex !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.StyleZindex);
 arrValueListForInsert.Add(objDropDownLstStyleEN.StyleZindex.ToString());
 }
 
 if (objDropDownLstStyleEN.StyleLeft !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.StyleLeft);
 arrValueListForInsert.Add(objDropDownLstStyleEN.StyleLeft.ToString());
 }
 
 if (objDropDownLstStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.StylePosition);
 var strStylePosition = objDropDownLstStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 if (objDropDownLstStyleEN.StyleTop !=  null)
 {
 arrFieldListForInsert.Add(conDropDownLstStyle.StyleTop);
 arrValueListForInsert.Add(objDropDownLstStyleEN.StyleTop.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DropDownLstStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewDropDownLstStyles(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
strSQL = "Select * from DropDownLstStyle where DropDownLstStyleId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DropDownLstStyle");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strDropDownLstStyleId = oRow[conDropDownLstStyle.DropDownLstStyleId].ToString().Trim();
if (IsExist(strDropDownLstStyleId))
{
 string strResult = "关键字变量值为:" + string.Format("DropDownLstStyleId = {0}", strDropDownLstStyleId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsDropDownLstStyleEN._CurrTabName ].NewRow();
objRow[conDropDownLstStyle.DropDownLstStyleId] = oRow[conDropDownLstStyle.DropDownLstStyleId].ToString().Trim(); //DropDownLstStyleId
objRow[conDropDownLstStyle.DropDownLstStyleName] = oRow[conDropDownLstStyle.DropDownLstStyleName].ToString().Trim(); //DropDownLstStyleName
objRow[conDropDownLstStyle.Style] = oRow[conDropDownLstStyle.Style].ToString().Trim(); //类型
objRow[conDropDownLstStyle.Runat] = oRow[conDropDownLstStyle.Runat].ToString().Trim(); //运行在
objRow[conDropDownLstStyle.FontSize] = oRow[conDropDownLstStyle.FontSize].ToString().Trim(); //字号
objRow[conDropDownLstStyle.FontName] = oRow[conDropDownLstStyle.FontName].ToString().Trim(); //字体
objRow[conDropDownLstStyle.Width] = oRow[conDropDownLstStyle.Width].ToString().Trim(); //宽
objRow[conDropDownLstStyle.Height] = oRow[conDropDownLstStyle.Height].ToString().Trim(); //高度
objRow[conDropDownLstStyle.TextMode] = oRow[conDropDownLstStyle.TextMode].ToString().Trim(); //TextMode
objRow[conDropDownLstStyle.ReadOnly] = oRow[conDropDownLstStyle.ReadOnly].ToString().Trim(); //ReadOnly
objRow[conDropDownLstStyle.BackColor] = oRow[conDropDownLstStyle.BackColor].ToString().Trim(); //背景颜色
objRow[conDropDownLstStyle.ForeColor] = oRow[conDropDownLstStyle.ForeColor].ToString().Trim(); //前景颜色
objRow[conDropDownLstStyle.DataTextField] = oRow[conDropDownLstStyle.DataTextField].ToString().Trim(); //DataTextField
objRow[conDropDownLstStyle.DataValueField] = oRow[conDropDownLstStyle.DataValueField].ToString().Trim(); //DataValueField
objRow[conDropDownLstStyle.DataTextFormatString] = oRow[conDropDownLstStyle.DataTextFormatString].ToString().Trim(); //DataTextFormatString
objRow[conDropDownLstStyle.AccessKey] = oRow[conDropDownLstStyle.AccessKey].ToString().Trim(); //AccessKey
objRow[conDropDownLstStyle.AutoPostBack] = oRow[conDropDownLstStyle.AutoPostBack].ToString().Trim(); //AutoPostBack
objRow[conDropDownLstStyle.Visible] = oRow[conDropDownLstStyle.Visible].ToString().Trim(); //Visible
objRow[conDropDownLstStyle.StyleZindex] = oRow[conDropDownLstStyle.StyleZindex].ToString().Trim(); //Style_Zindex
objRow[conDropDownLstStyle.StyleLeft] = oRow[conDropDownLstStyle.StyleLeft].ToString().Trim(); //Style_Left
objRow[conDropDownLstStyle.StylePosition] = oRow[conDropDownLstStyle.StylePosition].ToString().Trim(); //Style_Position
objRow[conDropDownLstStyle.StyleTop] = oRow[conDropDownLstStyle.StyleTop].ToString().Trim(); //Style_Top
 objDS.Tables[clsDropDownLstStyleEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsDropDownLstStyleEN._CurrTabName);
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
 /// <param name = "objDropDownLstStyleEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsDropDownLstStyleEN objDropDownLstStyleEN)
{
 if (objDropDownLstStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDropDownLstStyleEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
strSQL = "Select * from DropDownLstStyle where DropDownLstStyleId = " + "'"+ objDropDownLstStyleEN.DropDownLstStyleId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsDropDownLstStyleEN._CurrTabName);
if (objDS.Tables[clsDropDownLstStyleEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:DropDownLstStyleId = " + "'"+ objDropDownLstStyleEN.DropDownLstStyleId+"'");
return false;
}
objRow = objDS.Tables[clsDropDownLstStyleEN._CurrTabName].Rows[0];
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DropDownLstStyleId))
 {
objRow[conDropDownLstStyle.DropDownLstStyleId] = objDropDownLstStyleEN.DropDownLstStyleId; //DropDownLstStyleId
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DropDownLstStyleName))
 {
objRow[conDropDownLstStyle.DropDownLstStyleName] = objDropDownLstStyleEN.DropDownLstStyleName; //DropDownLstStyleName
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Style))
 {
objRow[conDropDownLstStyle.Style] = objDropDownLstStyleEN.Style; //类型
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Runat))
 {
objRow[conDropDownLstStyle.Runat] = objDropDownLstStyleEN.Runat; //运行在
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.FontSize))
 {
objRow[conDropDownLstStyle.FontSize] = objDropDownLstStyleEN.FontSize; //字号
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.FontName))
 {
objRow[conDropDownLstStyle.FontName] = objDropDownLstStyleEN.FontName; //字体
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Width))
 {
objRow[conDropDownLstStyle.Width] = objDropDownLstStyleEN.Width; //宽
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Height))
 {
objRow[conDropDownLstStyle.Height] = objDropDownLstStyleEN.Height; //高度
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.TextMode))
 {
objRow[conDropDownLstStyle.TextMode] = objDropDownLstStyleEN.TextMode; //TextMode
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.ReadOnly))
 {
objRow[conDropDownLstStyle.ReadOnly] = objDropDownLstStyleEN.ReadOnly; //ReadOnly
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.BackColor))
 {
objRow[conDropDownLstStyle.BackColor] = objDropDownLstStyleEN.BackColor; //背景颜色
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.ForeColor))
 {
objRow[conDropDownLstStyle.ForeColor] = objDropDownLstStyleEN.ForeColor; //前景颜色
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DataTextField))
 {
objRow[conDropDownLstStyle.DataTextField] = objDropDownLstStyleEN.DataTextField; //DataTextField
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DataValueField))
 {
objRow[conDropDownLstStyle.DataValueField] = objDropDownLstStyleEN.DataValueField; //DataValueField
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DataTextFormatString))
 {
objRow[conDropDownLstStyle.DataTextFormatString] = objDropDownLstStyleEN.DataTextFormatString; //DataTextFormatString
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.AccessKey))
 {
objRow[conDropDownLstStyle.AccessKey] = objDropDownLstStyleEN.AccessKey; //AccessKey
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.AutoPostBack))
 {
objRow[conDropDownLstStyle.AutoPostBack] = objDropDownLstStyleEN.AutoPostBack; //AutoPostBack
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Visible))
 {
objRow[conDropDownLstStyle.Visible] = objDropDownLstStyleEN.Visible; //Visible
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StyleZindex))
 {
objRow[conDropDownLstStyle.StyleZindex] = objDropDownLstStyleEN.StyleZindex; //Style_Zindex
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StyleLeft))
 {
objRow[conDropDownLstStyle.StyleLeft] = objDropDownLstStyleEN.StyleLeft; //Style_Left
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StylePosition))
 {
objRow[conDropDownLstStyle.StylePosition] = objDropDownLstStyleEN.StylePosition; //Style_Position
 }
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StyleTop))
 {
objRow[conDropDownLstStyle.StyleTop] = objDropDownLstStyleEN.StyleTop; //Style_Top
 }
try
{
objDA.Update(objDS, clsDropDownLstStyleEN._CurrTabName);
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
 /// <param name = "objDropDownLstStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDropDownLstStyleEN objDropDownLstStyleEN)
{
 if (objDropDownLstStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDropDownLstStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update DropDownLstStyle Set ");
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DropDownLstStyleName))
 {
 if (objDropDownLstStyleEN.DropDownLstStyleName !=  null)
 {
 var strDropDownLstStyleName = objDropDownLstStyleEN.DropDownLstStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDropDownLstStyleName, conDropDownLstStyle.DropDownLstStyleName); //DropDownLstStyleName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.DropDownLstStyleName); //DropDownLstStyleName
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Style))
 {
 if (objDropDownLstStyleEN.Style !=  null)
 {
 var strStyle = objDropDownLstStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyle, conDropDownLstStyle.Style); //类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.Style); //类型
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Runat))
 {
 if (objDropDownLstStyleEN.Runat !=  null)
 {
 var strRunat = objDropDownLstStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRunat, conDropDownLstStyle.Runat); //运行在
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.Runat); //运行在
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.FontSize))
 {
 if (objDropDownLstStyleEN.FontSize !=  null)
 {
 var strFontSize = objDropDownLstStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontSize, conDropDownLstStyle.FontSize); //字号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.FontSize); //字号
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.FontName))
 {
 if (objDropDownLstStyleEN.FontName !=  null)
 {
 var strFontName = objDropDownLstStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontName, conDropDownLstStyle.FontName); //字体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.FontName); //字体
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Width))
 {
 if (objDropDownLstStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.Width, conDropDownLstStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.Width); //宽
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Height))
 {
 if (objDropDownLstStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.Height, conDropDownLstStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.Height); //高度
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.TextMode))
 {
 if (objDropDownLstStyleEN.TextMode !=  null)
 {
 var strTextMode = objDropDownLstStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextMode, conDropDownLstStyle.TextMode); //TextMode
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.TextMode); //TextMode
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.ReadOnly))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDropDownLstStyleEN.ReadOnly == true?"1":"0", conDropDownLstStyle.ReadOnly); //ReadOnly
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.BackColor))
 {
 if (objDropDownLstStyleEN.BackColor !=  null)
 {
 var strBackColor = objDropDownLstStyleEN.BackColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBackColor, conDropDownLstStyle.BackColor); //背景颜色
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.BackColor); //背景颜色
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.ForeColor))
 {
 if (objDropDownLstStyleEN.ForeColor !=  null)
 {
 var strForeColor = objDropDownLstStyleEN.ForeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForeColor, conDropDownLstStyle.ForeColor); //前景颜色
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.ForeColor); //前景颜色
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DataTextField))
 {
 if (objDropDownLstStyleEN.DataTextField !=  null)
 {
 var strDataTextField = objDropDownLstStyleEN.DataTextField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTextField, conDropDownLstStyle.DataTextField); //DataTextField
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.DataTextField); //DataTextField
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DataValueField))
 {
 if (objDropDownLstStyleEN.DataValueField !=  null)
 {
 var strDataValueField = objDropDownLstStyleEN.DataValueField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataValueField, conDropDownLstStyle.DataValueField); //DataValueField
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.DataValueField); //DataValueField
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DataTextFormatString))
 {
 if (objDropDownLstStyleEN.DataTextFormatString !=  null)
 {
 var strDataTextFormatString = objDropDownLstStyleEN.DataTextFormatString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTextFormatString, conDropDownLstStyle.DataTextFormatString); //DataTextFormatString
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.DataTextFormatString); //DataTextFormatString
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.AccessKey))
 {
 if (objDropDownLstStyleEN.AccessKey !=  null)
 {
 var strAccessKey = objDropDownLstStyleEN.AccessKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAccessKey, conDropDownLstStyle.AccessKey); //AccessKey
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.AccessKey); //AccessKey
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.AutoPostBack))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDropDownLstStyleEN.AutoPostBack == true?"1":"0", conDropDownLstStyle.AutoPostBack); //AutoPostBack
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Visible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDropDownLstStyleEN.Visible == true?"1":"0", conDropDownLstStyle.Visible); //Visible
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StyleZindex))
 {
 if (objDropDownLstStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.StyleZindex, conDropDownLstStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StyleLeft))
 {
 if (objDropDownLstStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.StyleLeft, conDropDownLstStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StylePosition))
 {
 if (objDropDownLstStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objDropDownLstStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStylePosition, conDropDownLstStyle.StylePosition); //Style_Position
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.StylePosition); //Style_Position
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StyleTop))
 {
 if (objDropDownLstStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.StyleTop, conDropDownLstStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.StyleTop); //Style_Top
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DropDownLstStyleId = '{0}'", objDropDownLstStyleEN.DropDownLstStyleId); 
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
 /// <param name = "objDropDownLstStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsDropDownLstStyleEN objDropDownLstStyleEN, string strCondition)
{
 if (objDropDownLstStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDropDownLstStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DropDownLstStyle Set ");
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DropDownLstStyleName))
 {
 if (objDropDownLstStyleEN.DropDownLstStyleName !=  null)
 {
 var strDropDownLstStyleName = objDropDownLstStyleEN.DropDownLstStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DropDownLstStyleName = '{0}',", strDropDownLstStyleName); //DropDownLstStyleName
 }
 else
 {
 sbSQL.Append(" DropDownLstStyleName = null,"); //DropDownLstStyleName
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Style))
 {
 if (objDropDownLstStyleEN.Style !=  null)
 {
 var strStyle = objDropDownLstStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Style = '{0}',", strStyle); //类型
 }
 else
 {
 sbSQL.Append(" Style = null,"); //类型
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Runat))
 {
 if (objDropDownLstStyleEN.Runat !=  null)
 {
 var strRunat = objDropDownLstStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Runat = '{0}',", strRunat); //运行在
 }
 else
 {
 sbSQL.Append(" Runat = null,"); //运行在
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.FontSize))
 {
 if (objDropDownLstStyleEN.FontSize !=  null)
 {
 var strFontSize = objDropDownLstStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontSize = '{0}',", strFontSize); //字号
 }
 else
 {
 sbSQL.Append(" FontSize = null,"); //字号
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.FontName))
 {
 if (objDropDownLstStyleEN.FontName !=  null)
 {
 var strFontName = objDropDownLstStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontName = '{0}',", strFontName); //字体
 }
 else
 {
 sbSQL.Append(" FontName = null,"); //字体
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Width))
 {
 if (objDropDownLstStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.Width, conDropDownLstStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.Width); //宽
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Height))
 {
 if (objDropDownLstStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.Height, conDropDownLstStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.Height); //高度
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.TextMode))
 {
 if (objDropDownLstStyleEN.TextMode !=  null)
 {
 var strTextMode = objDropDownLstStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextMode = '{0}',", strTextMode); //TextMode
 }
 else
 {
 sbSQL.Append(" TextMode = null,"); //TextMode
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.ReadOnly))
 {
 sbSQL.AppendFormat(" ReadOnly = '{0}',", objDropDownLstStyleEN.ReadOnly == true?"1":"0"); //ReadOnly
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.BackColor))
 {
 if (objDropDownLstStyleEN.BackColor !=  null)
 {
 var strBackColor = objDropDownLstStyleEN.BackColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BackColor = '{0}',", strBackColor); //背景颜色
 }
 else
 {
 sbSQL.Append(" BackColor = null,"); //背景颜色
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.ForeColor))
 {
 if (objDropDownLstStyleEN.ForeColor !=  null)
 {
 var strForeColor = objDropDownLstStyleEN.ForeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForeColor = '{0}',", strForeColor); //前景颜色
 }
 else
 {
 sbSQL.Append(" ForeColor = null,"); //前景颜色
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DataTextField))
 {
 if (objDropDownLstStyleEN.DataTextField !=  null)
 {
 var strDataTextField = objDropDownLstStyleEN.DataTextField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTextField = '{0}',", strDataTextField); //DataTextField
 }
 else
 {
 sbSQL.Append(" DataTextField = null,"); //DataTextField
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DataValueField))
 {
 if (objDropDownLstStyleEN.DataValueField !=  null)
 {
 var strDataValueField = objDropDownLstStyleEN.DataValueField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataValueField = '{0}',", strDataValueField); //DataValueField
 }
 else
 {
 sbSQL.Append(" DataValueField = null,"); //DataValueField
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DataTextFormatString))
 {
 if (objDropDownLstStyleEN.DataTextFormatString !=  null)
 {
 var strDataTextFormatString = objDropDownLstStyleEN.DataTextFormatString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTextFormatString = '{0}',", strDataTextFormatString); //DataTextFormatString
 }
 else
 {
 sbSQL.Append(" DataTextFormatString = null,"); //DataTextFormatString
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.AccessKey))
 {
 if (objDropDownLstStyleEN.AccessKey !=  null)
 {
 var strAccessKey = objDropDownLstStyleEN.AccessKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AccessKey = '{0}',", strAccessKey); //AccessKey
 }
 else
 {
 sbSQL.Append(" AccessKey = null,"); //AccessKey
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.AutoPostBack))
 {
 sbSQL.AppendFormat(" AutoPostBack = '{0}',", objDropDownLstStyleEN.AutoPostBack == true?"1":"0"); //AutoPostBack
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Visible))
 {
 sbSQL.AppendFormat(" Visible = '{0}',", objDropDownLstStyleEN.Visible == true?"1":"0"); //Visible
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StyleZindex))
 {
 if (objDropDownLstStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.StyleZindex, conDropDownLstStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StyleLeft))
 {
 if (objDropDownLstStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.StyleLeft, conDropDownLstStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StylePosition))
 {
 if (objDropDownLstStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objDropDownLstStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StylePosition = '{0}',", strStylePosition); //Style_Position
 }
 else
 {
 sbSQL.Append(" StylePosition = null,"); //Style_Position
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StyleTop))
 {
 if (objDropDownLstStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.StyleTop, conDropDownLstStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.StyleTop); //Style_Top
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
 /// <param name = "objDropDownLstStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsDropDownLstStyleEN objDropDownLstStyleEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objDropDownLstStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDropDownLstStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DropDownLstStyle Set ");
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DropDownLstStyleName))
 {
 if (objDropDownLstStyleEN.DropDownLstStyleName !=  null)
 {
 var strDropDownLstStyleName = objDropDownLstStyleEN.DropDownLstStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DropDownLstStyleName = '{0}',", strDropDownLstStyleName); //DropDownLstStyleName
 }
 else
 {
 sbSQL.Append(" DropDownLstStyleName = null,"); //DropDownLstStyleName
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Style))
 {
 if (objDropDownLstStyleEN.Style !=  null)
 {
 var strStyle = objDropDownLstStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Style = '{0}',", strStyle); //类型
 }
 else
 {
 sbSQL.Append(" Style = null,"); //类型
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Runat))
 {
 if (objDropDownLstStyleEN.Runat !=  null)
 {
 var strRunat = objDropDownLstStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Runat = '{0}',", strRunat); //运行在
 }
 else
 {
 sbSQL.Append(" Runat = null,"); //运行在
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.FontSize))
 {
 if (objDropDownLstStyleEN.FontSize !=  null)
 {
 var strFontSize = objDropDownLstStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontSize = '{0}',", strFontSize); //字号
 }
 else
 {
 sbSQL.Append(" FontSize = null,"); //字号
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.FontName))
 {
 if (objDropDownLstStyleEN.FontName !=  null)
 {
 var strFontName = objDropDownLstStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontName = '{0}',", strFontName); //字体
 }
 else
 {
 sbSQL.Append(" FontName = null,"); //字体
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Width))
 {
 if (objDropDownLstStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.Width, conDropDownLstStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.Width); //宽
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Height))
 {
 if (objDropDownLstStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.Height, conDropDownLstStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.Height); //高度
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.TextMode))
 {
 if (objDropDownLstStyleEN.TextMode !=  null)
 {
 var strTextMode = objDropDownLstStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextMode = '{0}',", strTextMode); //TextMode
 }
 else
 {
 sbSQL.Append(" TextMode = null,"); //TextMode
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.ReadOnly))
 {
 sbSQL.AppendFormat(" ReadOnly = '{0}',", objDropDownLstStyleEN.ReadOnly == true?"1":"0"); //ReadOnly
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.BackColor))
 {
 if (objDropDownLstStyleEN.BackColor !=  null)
 {
 var strBackColor = objDropDownLstStyleEN.BackColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BackColor = '{0}',", strBackColor); //背景颜色
 }
 else
 {
 sbSQL.Append(" BackColor = null,"); //背景颜色
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.ForeColor))
 {
 if (objDropDownLstStyleEN.ForeColor !=  null)
 {
 var strForeColor = objDropDownLstStyleEN.ForeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ForeColor = '{0}',", strForeColor); //前景颜色
 }
 else
 {
 sbSQL.Append(" ForeColor = null,"); //前景颜色
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DataTextField))
 {
 if (objDropDownLstStyleEN.DataTextField !=  null)
 {
 var strDataTextField = objDropDownLstStyleEN.DataTextField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTextField = '{0}',", strDataTextField); //DataTextField
 }
 else
 {
 sbSQL.Append(" DataTextField = null,"); //DataTextField
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DataValueField))
 {
 if (objDropDownLstStyleEN.DataValueField !=  null)
 {
 var strDataValueField = objDropDownLstStyleEN.DataValueField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataValueField = '{0}',", strDataValueField); //DataValueField
 }
 else
 {
 sbSQL.Append(" DataValueField = null,"); //DataValueField
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DataTextFormatString))
 {
 if (objDropDownLstStyleEN.DataTextFormatString !=  null)
 {
 var strDataTextFormatString = objDropDownLstStyleEN.DataTextFormatString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataTextFormatString = '{0}',", strDataTextFormatString); //DataTextFormatString
 }
 else
 {
 sbSQL.Append(" DataTextFormatString = null,"); //DataTextFormatString
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.AccessKey))
 {
 if (objDropDownLstStyleEN.AccessKey !=  null)
 {
 var strAccessKey = objDropDownLstStyleEN.AccessKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AccessKey = '{0}',", strAccessKey); //AccessKey
 }
 else
 {
 sbSQL.Append(" AccessKey = null,"); //AccessKey
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.AutoPostBack))
 {
 sbSQL.AppendFormat(" AutoPostBack = '{0}',", objDropDownLstStyleEN.AutoPostBack == true?"1":"0"); //AutoPostBack
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Visible))
 {
 sbSQL.AppendFormat(" Visible = '{0}',", objDropDownLstStyleEN.Visible == true?"1":"0"); //Visible
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StyleZindex))
 {
 if (objDropDownLstStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.StyleZindex, conDropDownLstStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StyleLeft))
 {
 if (objDropDownLstStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.StyleLeft, conDropDownLstStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StylePosition))
 {
 if (objDropDownLstStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objDropDownLstStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StylePosition = '{0}',", strStylePosition); //Style_Position
 }
 else
 {
 sbSQL.Append(" StylePosition = null,"); //Style_Position
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StyleTop))
 {
 if (objDropDownLstStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.StyleTop, conDropDownLstStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.StyleTop); //Style_Top
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
 /// <param name = "objDropDownLstStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDropDownLstStyleEN objDropDownLstStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objDropDownLstStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDropDownLstStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DropDownLstStyle Set ");
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DropDownLstStyleName))
 {
 if (objDropDownLstStyleEN.DropDownLstStyleName !=  null)
 {
 var strDropDownLstStyleName = objDropDownLstStyleEN.DropDownLstStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDropDownLstStyleName, conDropDownLstStyle.DropDownLstStyleName); //DropDownLstStyleName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.DropDownLstStyleName); //DropDownLstStyleName
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Style))
 {
 if (objDropDownLstStyleEN.Style !=  null)
 {
 var strStyle = objDropDownLstStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyle, conDropDownLstStyle.Style); //类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.Style); //类型
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Runat))
 {
 if (objDropDownLstStyleEN.Runat !=  null)
 {
 var strRunat = objDropDownLstStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRunat, conDropDownLstStyle.Runat); //运行在
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.Runat); //运行在
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.FontSize))
 {
 if (objDropDownLstStyleEN.FontSize !=  null)
 {
 var strFontSize = objDropDownLstStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontSize, conDropDownLstStyle.FontSize); //字号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.FontSize); //字号
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.FontName))
 {
 if (objDropDownLstStyleEN.FontName !=  null)
 {
 var strFontName = objDropDownLstStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontName, conDropDownLstStyle.FontName); //字体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.FontName); //字体
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Width))
 {
 if (objDropDownLstStyleEN.Width !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.Width, conDropDownLstStyle.Width); //宽
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.Width); //宽
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Height))
 {
 if (objDropDownLstStyleEN.Height !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.Height, conDropDownLstStyle.Height); //高度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.Height); //高度
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.TextMode))
 {
 if (objDropDownLstStyleEN.TextMode !=  null)
 {
 var strTextMode = objDropDownLstStyleEN.TextMode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextMode, conDropDownLstStyle.TextMode); //TextMode
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.TextMode); //TextMode
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.ReadOnly))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDropDownLstStyleEN.ReadOnly == true?"1":"0", conDropDownLstStyle.ReadOnly); //ReadOnly
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.BackColor))
 {
 if (objDropDownLstStyleEN.BackColor !=  null)
 {
 var strBackColor = objDropDownLstStyleEN.BackColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBackColor, conDropDownLstStyle.BackColor); //背景颜色
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.BackColor); //背景颜色
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.ForeColor))
 {
 if (objDropDownLstStyleEN.ForeColor !=  null)
 {
 var strForeColor = objDropDownLstStyleEN.ForeColor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strForeColor, conDropDownLstStyle.ForeColor); //前景颜色
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.ForeColor); //前景颜色
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DataTextField))
 {
 if (objDropDownLstStyleEN.DataTextField !=  null)
 {
 var strDataTextField = objDropDownLstStyleEN.DataTextField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTextField, conDropDownLstStyle.DataTextField); //DataTextField
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.DataTextField); //DataTextField
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DataValueField))
 {
 if (objDropDownLstStyleEN.DataValueField !=  null)
 {
 var strDataValueField = objDropDownLstStyleEN.DataValueField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataValueField, conDropDownLstStyle.DataValueField); //DataValueField
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.DataValueField); //DataValueField
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.DataTextFormatString))
 {
 if (objDropDownLstStyleEN.DataTextFormatString !=  null)
 {
 var strDataTextFormatString = objDropDownLstStyleEN.DataTextFormatString.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataTextFormatString, conDropDownLstStyle.DataTextFormatString); //DataTextFormatString
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.DataTextFormatString); //DataTextFormatString
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.AccessKey))
 {
 if (objDropDownLstStyleEN.AccessKey !=  null)
 {
 var strAccessKey = objDropDownLstStyleEN.AccessKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAccessKey, conDropDownLstStyle.AccessKey); //AccessKey
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.AccessKey); //AccessKey
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.AutoPostBack))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDropDownLstStyleEN.AutoPostBack == true?"1":"0", conDropDownLstStyle.AutoPostBack); //AutoPostBack
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.Visible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objDropDownLstStyleEN.Visible == true?"1":"0", conDropDownLstStyle.Visible); //Visible
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StyleZindex))
 {
 if (objDropDownLstStyleEN.StyleZindex !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.StyleZindex, conDropDownLstStyle.StyleZindex); //Style_Zindex
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.StyleZindex); //Style_Zindex
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StyleLeft))
 {
 if (objDropDownLstStyleEN.StyleLeft !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.StyleLeft, conDropDownLstStyle.StyleLeft); //Style_Left
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.StyleLeft); //Style_Left
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StylePosition))
 {
 if (objDropDownLstStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objDropDownLstStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStylePosition, conDropDownLstStyle.StylePosition); //Style_Position
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.StylePosition); //Style_Position
 }
 }
 
 if (objDropDownLstStyleEN.IsUpdated(conDropDownLstStyle.StyleTop))
 {
 if (objDropDownLstStyleEN.StyleTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDropDownLstStyleEN.StyleTop, conDropDownLstStyle.StyleTop); //Style_Top
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDropDownLstStyle.StyleTop); //Style_Top
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DropDownLstStyleId = '{0}'", objDropDownLstStyleEN.DropDownLstStyleId); 
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
 /// <param name = "strDropDownLstStyleId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strDropDownLstStyleId) 
{
CheckPrimaryKey(strDropDownLstStyleId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strDropDownLstStyleId,
};
 objSQL.ExecSP("DropDownLstStyle_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strDropDownLstStyleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strDropDownLstStyleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strDropDownLstStyleId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
//删除DropDownLstStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DropDownLstStyle where DropDownLstStyleId = " + "'"+ strDropDownLstStyleId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelDropDownLstStyle(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
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
//删除DropDownLstStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DropDownLstStyle where DropDownLstStyleId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strDropDownLstStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strDropDownLstStyleId) 
{
CheckPrimaryKey(strDropDownLstStyleId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
//删除DropDownLstStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DropDownLstStyle where DropDownLstStyleId = " + "'"+ strDropDownLstStyleId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelDropDownLstStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsDropDownLstStyleDA: DelDropDownLstStyle)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DropDownLstStyle where " + strCondition ;
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
public bool DelDropDownLstStyleWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsDropDownLstStyleDA: DelDropDownLstStyleWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DropDownLstStyle where " + strCondition ;
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
 /// <param name = "objDropDownLstStyleENS">源对象</param>
 /// <param name = "objDropDownLstStyleENT">目标对象</param>
public void CopyTo(clsDropDownLstStyleEN objDropDownLstStyleENS, clsDropDownLstStyleEN objDropDownLstStyleENT)
{
objDropDownLstStyleENT.DropDownLstStyleId = objDropDownLstStyleENS.DropDownLstStyleId; //DropDownLstStyleId
objDropDownLstStyleENT.DropDownLstStyleName = objDropDownLstStyleENS.DropDownLstStyleName; //DropDownLstStyleName
objDropDownLstStyleENT.Style = objDropDownLstStyleENS.Style; //类型
objDropDownLstStyleENT.Runat = objDropDownLstStyleENS.Runat; //运行在
objDropDownLstStyleENT.FontSize = objDropDownLstStyleENS.FontSize; //字号
objDropDownLstStyleENT.FontName = objDropDownLstStyleENS.FontName; //字体
objDropDownLstStyleENT.Width = objDropDownLstStyleENS.Width; //宽
objDropDownLstStyleENT.Height = objDropDownLstStyleENS.Height; //高度
objDropDownLstStyleENT.TextMode = objDropDownLstStyleENS.TextMode; //TextMode
objDropDownLstStyleENT.ReadOnly = objDropDownLstStyleENS.ReadOnly; //ReadOnly
objDropDownLstStyleENT.BackColor = objDropDownLstStyleENS.BackColor; //背景颜色
objDropDownLstStyleENT.ForeColor = objDropDownLstStyleENS.ForeColor; //前景颜色
objDropDownLstStyleENT.DataTextField = objDropDownLstStyleENS.DataTextField; //DataTextField
objDropDownLstStyleENT.DataValueField = objDropDownLstStyleENS.DataValueField; //DataValueField
objDropDownLstStyleENT.DataTextFormatString = objDropDownLstStyleENS.DataTextFormatString; //DataTextFormatString
objDropDownLstStyleENT.AccessKey = objDropDownLstStyleENS.AccessKey; //AccessKey
objDropDownLstStyleENT.AutoPostBack = objDropDownLstStyleENS.AutoPostBack; //AutoPostBack
objDropDownLstStyleENT.Visible = objDropDownLstStyleENS.Visible; //Visible
objDropDownLstStyleENT.StyleZindex = objDropDownLstStyleENS.StyleZindex; //Style_Zindex
objDropDownLstStyleENT.StyleLeft = objDropDownLstStyleENS.StyleLeft; //Style_Left
objDropDownLstStyleENT.StylePosition = objDropDownLstStyleENS.StylePosition; //Style_Position
objDropDownLstStyleENT.StyleTop = objDropDownLstStyleENS.StyleTop; //Style_Top
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDropDownLstStyleEN objDropDownLstStyleEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objDropDownLstStyleEN.DropDownLstStyleName, conDropDownLstStyle.DropDownLstStyleName);
clsCheckSql.CheckFieldNotNull(objDropDownLstStyleEN.Runat, conDropDownLstStyle.Runat);
clsCheckSql.CheckFieldNotNull(objDropDownLstStyleEN.FontSize, conDropDownLstStyle.FontSize);
clsCheckSql.CheckFieldNotNull(objDropDownLstStyleEN.FontName, conDropDownLstStyle.FontName);
clsCheckSql.CheckFieldNotNull(objDropDownLstStyleEN.TextMode, conDropDownLstStyle.TextMode);
clsCheckSql.CheckFieldNotNull(objDropDownLstStyleEN.ReadOnly, conDropDownLstStyle.ReadOnly);
//检查字段长度
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.DropDownLstStyleId, 4, conDropDownLstStyle.DropDownLstStyleId);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.DropDownLstStyleName, 30, conDropDownLstStyle.DropDownLstStyleName);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.Style, 800, conDropDownLstStyle.Style);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.Runat, 30, conDropDownLstStyle.Runat);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.FontSize, 20, conDropDownLstStyle.FontSize);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.FontName, 20, conDropDownLstStyle.FontName);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.TextMode, 20, conDropDownLstStyle.TextMode);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.BackColor, 30, conDropDownLstStyle.BackColor);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.ForeColor, 30, conDropDownLstStyle.ForeColor);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.DataTextField, 30, conDropDownLstStyle.DataTextField);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.DataValueField, 30, conDropDownLstStyle.DataValueField);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.DataTextFormatString, 30, conDropDownLstStyle.DataTextFormatString);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.AccessKey, 30, conDropDownLstStyle.AccessKey);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.StylePosition, 20, conDropDownLstStyle.StylePosition);
//检查字段外键固定长度
 objDropDownLstStyleEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsDropDownLstStyleEN objDropDownLstStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.DropDownLstStyleName, 30, conDropDownLstStyle.DropDownLstStyleName);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.Style, 800, conDropDownLstStyle.Style);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.Runat, 30, conDropDownLstStyle.Runat);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.FontSize, 20, conDropDownLstStyle.FontSize);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.FontName, 20, conDropDownLstStyle.FontName);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.TextMode, 20, conDropDownLstStyle.TextMode);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.BackColor, 30, conDropDownLstStyle.BackColor);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.ForeColor, 30, conDropDownLstStyle.ForeColor);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.DataTextField, 30, conDropDownLstStyle.DataTextField);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.DataValueField, 30, conDropDownLstStyle.DataValueField);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.DataTextFormatString, 30, conDropDownLstStyle.DataTextFormatString);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.AccessKey, 30, conDropDownLstStyle.AccessKey);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.StylePosition, 20, conDropDownLstStyle.StylePosition);
//检查外键字段长度
 objDropDownLstStyleEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsDropDownLstStyleEN objDropDownLstStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.DropDownLstStyleId, 4, conDropDownLstStyle.DropDownLstStyleId);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.DropDownLstStyleName, 30, conDropDownLstStyle.DropDownLstStyleName);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.Style, 800, conDropDownLstStyle.Style);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.Runat, 30, conDropDownLstStyle.Runat);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.FontSize, 20, conDropDownLstStyle.FontSize);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.FontName, 20, conDropDownLstStyle.FontName);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.TextMode, 20, conDropDownLstStyle.TextMode);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.BackColor, 30, conDropDownLstStyle.BackColor);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.ForeColor, 30, conDropDownLstStyle.ForeColor);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.DataTextField, 30, conDropDownLstStyle.DataTextField);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.DataValueField, 30, conDropDownLstStyle.DataValueField);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.DataTextFormatString, 30, conDropDownLstStyle.DataTextFormatString);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.AccessKey, 30, conDropDownLstStyle.AccessKey);
clsCheckSql.CheckFieldLen(objDropDownLstStyleEN.StylePosition, 20, conDropDownLstStyle.StylePosition);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objDropDownLstStyleEN.DropDownLstStyleId, conDropDownLstStyle.DropDownLstStyleId);
clsCheckSql.CheckSqlInjection4Field(objDropDownLstStyleEN.DropDownLstStyleName, conDropDownLstStyle.DropDownLstStyleName);
clsCheckSql.CheckSqlInjection4Field(objDropDownLstStyleEN.Style, conDropDownLstStyle.Style);
clsCheckSql.CheckSqlInjection4Field(objDropDownLstStyleEN.Runat, conDropDownLstStyle.Runat);
clsCheckSql.CheckSqlInjection4Field(objDropDownLstStyleEN.FontSize, conDropDownLstStyle.FontSize);
clsCheckSql.CheckSqlInjection4Field(objDropDownLstStyleEN.FontName, conDropDownLstStyle.FontName);
clsCheckSql.CheckSqlInjection4Field(objDropDownLstStyleEN.TextMode, conDropDownLstStyle.TextMode);
clsCheckSql.CheckSqlInjection4Field(objDropDownLstStyleEN.BackColor, conDropDownLstStyle.BackColor);
clsCheckSql.CheckSqlInjection4Field(objDropDownLstStyleEN.ForeColor, conDropDownLstStyle.ForeColor);
clsCheckSql.CheckSqlInjection4Field(objDropDownLstStyleEN.DataTextField, conDropDownLstStyle.DataTextField);
clsCheckSql.CheckSqlInjection4Field(objDropDownLstStyleEN.DataValueField, conDropDownLstStyle.DataValueField);
clsCheckSql.CheckSqlInjection4Field(objDropDownLstStyleEN.DataTextFormatString, conDropDownLstStyle.DataTextFormatString);
clsCheckSql.CheckSqlInjection4Field(objDropDownLstStyleEN.AccessKey, conDropDownLstStyle.AccessKey);
clsCheckSql.CheckSqlInjection4Field(objDropDownLstStyleEN.StylePosition, conDropDownLstStyle.StylePosition);
//检查外键字段长度
 objDropDownLstStyleEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetDropDownLstStyleId()
{
//获取某学院所有专业信息
string strSQL = "select DropDownLstStyleId, DropDownLstStyleName from DropDownLstStyle ";
 clsSpecSQLforSql mySql = clsDropDownLstStyleDA.GetSpecSQLObj();
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
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
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
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
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
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDropDownLstStyleEN._CurrTabName);
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
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDropDownLstStyleEN._CurrTabName, strCondition);
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
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
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
 objSQL = clsDropDownLstStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}