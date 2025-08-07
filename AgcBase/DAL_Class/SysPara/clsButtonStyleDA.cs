
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsButtonStyleDA
 表名:ButtonStyle(00050054)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:44
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数(SysPara)
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
 /// 按钮样式(ButtonStyle)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsButtonStyleDA : clsCommBase4DA
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
 return clsButtonStyleEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsButtonStyleEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsButtonStyleEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsButtonStyleEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsButtonStyleEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strButtonStyleId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strButtonStyleId)
{
strButtonStyleId = strButtonStyleId.Replace("'", "''");
if (strButtonStyleId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:ButtonStyle中,检查关键字,长度不正确!(clsButtonStyleDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strButtonStyleId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ButtonStyle中,关键字不能为空 或 null!(clsButtonStyleDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strButtonStyleId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsButtonStyleDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsButtonStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
strSQL = "Select * from ButtonStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ButtonStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsButtonStyleDA: GetDataTable_ButtonStyle)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
strSQL = "Select * from ButtonStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsButtonStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsButtonStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
strSQL = "Select * from ButtonStyle where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsButtonStyleDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsButtonStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ButtonStyle where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ButtonStyle where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsButtonStyleDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ButtonStyle where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsButtonStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ButtonStyle.* " + 
$"from ButtonStyle " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ButtonStyle.ButtonStyleId not in " + 
$"(Select top {intTop_In} ButtonStyle.ButtonStyleId from ButtonStyle " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ButtonStyle where {1} and ButtonStyleId not in (Select top {2} ButtonStyleId from ButtonStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ButtonStyle where {1} and ButtonStyleId not in (Select top {3} ButtonStyleId from ButtonStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsButtonStyleDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ButtonStyle.* " + 
$"from ButtonStyle " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ButtonStyle.ButtonStyleId not in " + 
$"(Select top {intTop_In} ButtonStyle.ButtonStyleId from ButtonStyle " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ButtonStyle where {1} and ButtonStyleId not in (Select top {2} ButtonStyleId from ButtonStyle where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ButtonStyle where {1} and ButtonStyleId not in (Select top {3} ButtonStyleId from ButtonStyle where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsButtonStyleEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsButtonStyleDA:GetObjLst)", objException.Message));
}
List<clsButtonStyleEN> arrObjLst = new List<clsButtonStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
strSQL = "Select * from ButtonStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsButtonStyleEN objButtonStyleEN = new clsButtonStyleEN();
try
{
objButtonStyleEN.ButtonStyleId = objRow[conButtonStyle.ButtonStyleId].ToString().Trim(); //按钮样式Id
objButtonStyleEN.ButtonStyleName = objRow[conButtonStyle.ButtonStyleName].ToString().Trim(); //按钮样式名
objButtonStyleEN.CssClass = objRow[conButtonStyle.CssClass] == DBNull.Value ? null : objRow[conButtonStyle.CssClass].ToString().Trim(); //样式表
objButtonStyleEN.Style = objRow[conButtonStyle.Style].ToString().Trim(); //类型
objButtonStyleEN.Runat = objRow[conButtonStyle.Runat].ToString().Trim(); //运行在
objButtonStyleEN.FontSize = objRow[conButtonStyle.FontSize].ToString().Trim(); //字号
objButtonStyleEN.FontName = objRow[conButtonStyle.FontName].ToString().Trim(); //字体
objButtonStyleEN.Width = TransNullToInt(objRow[conButtonStyle.Width].ToString().Trim()); //宽
objButtonStyleEN.Height = TransNullToInt(objRow[conButtonStyle.Height].ToString().Trim()); //高度
objButtonStyleEN.StyleZindex = TransNullToInt(objRow[conButtonStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objButtonStyleEN.StyleLeft = TransNullToInt(objRow[conButtonStyle.StyleLeft].ToString().Trim()); //Style_Left
objButtonStyleEN.StylePosition = objRow[conButtonStyle.StylePosition].ToString().Trim(); //Style_Position
objButtonStyleEN.StyleTop = TransNullToInt(objRow[conButtonStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsButtonStyleDA: GetObjLst)", objException.Message));
}
objButtonStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objButtonStyleEN);
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
public List<clsButtonStyleEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsButtonStyleDA:GetObjLstByTabName)", objException.Message));
}
List<clsButtonStyleEN> arrObjLst = new List<clsButtonStyleEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsButtonStyleEN objButtonStyleEN = new clsButtonStyleEN();
try
{
objButtonStyleEN.ButtonStyleId = objRow[conButtonStyle.ButtonStyleId].ToString().Trim(); //按钮样式Id
objButtonStyleEN.ButtonStyleName = objRow[conButtonStyle.ButtonStyleName].ToString().Trim(); //按钮样式名
objButtonStyleEN.CssClass = objRow[conButtonStyle.CssClass] == DBNull.Value ? null : objRow[conButtonStyle.CssClass].ToString().Trim(); //样式表
objButtonStyleEN.Style = objRow[conButtonStyle.Style].ToString().Trim(); //类型
objButtonStyleEN.Runat = objRow[conButtonStyle.Runat].ToString().Trim(); //运行在
objButtonStyleEN.FontSize = objRow[conButtonStyle.FontSize].ToString().Trim(); //字号
objButtonStyleEN.FontName = objRow[conButtonStyle.FontName].ToString().Trim(); //字体
objButtonStyleEN.Width = TransNullToInt(objRow[conButtonStyle.Width].ToString().Trim()); //宽
objButtonStyleEN.Height = TransNullToInt(objRow[conButtonStyle.Height].ToString().Trim()); //高度
objButtonStyleEN.StyleZindex = TransNullToInt(objRow[conButtonStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objButtonStyleEN.StyleLeft = TransNullToInt(objRow[conButtonStyle.StyleLeft].ToString().Trim()); //Style_Left
objButtonStyleEN.StylePosition = objRow[conButtonStyle.StylePosition].ToString().Trim(); //Style_Position
objButtonStyleEN.StyleTop = TransNullToInt(objRow[conButtonStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsButtonStyleDA: GetObjLst)", objException.Message));
}
objButtonStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objButtonStyleEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objButtonStyleEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetButtonStyle(ref clsButtonStyleEN objButtonStyleEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
strSQL = "Select * from ButtonStyle where ButtonStyleId = " + "'"+ objButtonStyleEN.ButtonStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objButtonStyleEN.ButtonStyleId = objDT.Rows[0][conButtonStyle.ButtonStyleId].ToString().Trim(); //按钮样式Id(字段类型:char,字段长度:4,是否可空:False)
 objButtonStyleEN.ButtonStyleName = objDT.Rows[0][conButtonStyle.ButtonStyleName].ToString().Trim(); //按钮样式名(字段类型:varchar,字段长度:30,是否可空:False)
 objButtonStyleEN.CssClass = objDT.Rows[0][conButtonStyle.CssClass].ToString().Trim(); //样式表(字段类型:varchar,字段长度:50,是否可空:True)
 objButtonStyleEN.Style = objDT.Rows[0][conButtonStyle.Style].ToString().Trim(); //类型(字段类型:varchar,字段长度:800,是否可空:True)
 objButtonStyleEN.Runat = objDT.Rows[0][conButtonStyle.Runat].ToString().Trim(); //运行在(字段类型:varchar,字段长度:30,是否可空:True)
 objButtonStyleEN.FontSize = objDT.Rows[0][conButtonStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objButtonStyleEN.FontName = objDT.Rows[0][conButtonStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objButtonStyleEN.Width = TransNullToInt(objDT.Rows[0][conButtonStyle.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objButtonStyleEN.Height = TransNullToInt(objDT.Rows[0][conButtonStyle.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objButtonStyleEN.StyleZindex = TransNullToInt(objDT.Rows[0][conButtonStyle.StyleZindex].ToString().Trim()); //Style_Zindex(字段类型:int,字段长度:4,是否可空:True)
 objButtonStyleEN.StyleLeft = TransNullToInt(objDT.Rows[0][conButtonStyle.StyleLeft].ToString().Trim()); //Style_Left(字段类型:int,字段长度:4,是否可空:True)
 objButtonStyleEN.StylePosition = objDT.Rows[0][conButtonStyle.StylePosition].ToString().Trim(); //Style_Position(字段类型:varchar,字段长度:20,是否可空:True)
 objButtonStyleEN.StyleTop = TransNullToInt(objDT.Rows[0][conButtonStyle.StyleTop].ToString().Trim()); //Style_Top(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsButtonStyleDA: GetButtonStyle)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strButtonStyleId">表关键字</param>
 /// <returns>表对象</returns>
public clsButtonStyleEN GetObjByButtonStyleId(string strButtonStyleId)
{
CheckPrimaryKey(strButtonStyleId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
strSQL = "Select * from ButtonStyle where ButtonStyleId = " + "'"+ strButtonStyleId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsButtonStyleEN objButtonStyleEN = new clsButtonStyleEN();
try
{
 objButtonStyleEN.ButtonStyleId = objRow[conButtonStyle.ButtonStyleId].ToString().Trim(); //按钮样式Id(字段类型:char,字段长度:4,是否可空:False)
 objButtonStyleEN.ButtonStyleName = objRow[conButtonStyle.ButtonStyleName].ToString().Trim(); //按钮样式名(字段类型:varchar,字段长度:30,是否可空:False)
 objButtonStyleEN.CssClass = objRow[conButtonStyle.CssClass] == DBNull.Value ? null : objRow[conButtonStyle.CssClass].ToString().Trim(); //样式表(字段类型:varchar,字段长度:50,是否可空:True)
 objButtonStyleEN.Style = objRow[conButtonStyle.Style].ToString().Trim(); //类型(字段类型:varchar,字段长度:800,是否可空:True)
 objButtonStyleEN.Runat = objRow[conButtonStyle.Runat].ToString().Trim(); //运行在(字段类型:varchar,字段长度:30,是否可空:True)
 objButtonStyleEN.FontSize = objRow[conButtonStyle.FontSize].ToString().Trim(); //字号(字段类型:varchar,字段长度:20,是否可空:True)
 objButtonStyleEN.FontName = objRow[conButtonStyle.FontName].ToString().Trim(); //字体(字段类型:varchar,字段长度:20,是否可空:True)
 objButtonStyleEN.Width = Int32.Parse(objRow[conButtonStyle.Width].ToString().Trim()); //宽(字段类型:int,字段长度:4,是否可空:True)
 objButtonStyleEN.Height = Int32.Parse(objRow[conButtonStyle.Height].ToString().Trim()); //高度(字段类型:int,字段长度:4,是否可空:True)
 objButtonStyleEN.StyleZindex = Int32.Parse(objRow[conButtonStyle.StyleZindex].ToString().Trim()); //Style_Zindex(字段类型:int,字段长度:4,是否可空:True)
 objButtonStyleEN.StyleLeft = Int32.Parse(objRow[conButtonStyle.StyleLeft].ToString().Trim()); //Style_Left(字段类型:int,字段长度:4,是否可空:True)
 objButtonStyleEN.StylePosition = objRow[conButtonStyle.StylePosition].ToString().Trim(); //Style_Position(字段类型:varchar,字段长度:20,是否可空:True)
 objButtonStyleEN.StyleTop = Int32.Parse(objRow[conButtonStyle.StyleTop].ToString().Trim()); //Style_Top(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsButtonStyleDA: GetObjByButtonStyleId)", objException.Message));
}
return objButtonStyleEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsButtonStyleEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsButtonStyleDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
strSQL = "Select * from ButtonStyle where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsButtonStyleEN objButtonStyleEN = new clsButtonStyleEN()
{
ButtonStyleId = objRow[conButtonStyle.ButtonStyleId].ToString().Trim(), //按钮样式Id
ButtonStyleName = objRow[conButtonStyle.ButtonStyleName].ToString().Trim(), //按钮样式名
CssClass = objRow[conButtonStyle.CssClass] == DBNull.Value ? null : objRow[conButtonStyle.CssClass].ToString().Trim(), //样式表
Style = objRow[conButtonStyle.Style].ToString().Trim(), //类型
Runat = objRow[conButtonStyle.Runat].ToString().Trim(), //运行在
FontSize = objRow[conButtonStyle.FontSize].ToString().Trim(), //字号
FontName = objRow[conButtonStyle.FontName].ToString().Trim(), //字体
Width = TransNullToInt(objRow[conButtonStyle.Width].ToString().Trim()), //宽
Height = TransNullToInt(objRow[conButtonStyle.Height].ToString().Trim()), //高度
StyleZindex = TransNullToInt(objRow[conButtonStyle.StyleZindex].ToString().Trim()), //Style_Zindex
StyleLeft = TransNullToInt(objRow[conButtonStyle.StyleLeft].ToString().Trim()), //Style_Left
StylePosition = objRow[conButtonStyle.StylePosition].ToString().Trim(), //Style_Position
StyleTop = TransNullToInt(objRow[conButtonStyle.StyleTop].ToString().Trim()) //Style_Top
};
objButtonStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objButtonStyleEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsButtonStyleDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsButtonStyleEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsButtonStyleEN objButtonStyleEN = new clsButtonStyleEN();
try
{
objButtonStyleEN.ButtonStyleId = objRow[conButtonStyle.ButtonStyleId].ToString().Trim(); //按钮样式Id
objButtonStyleEN.ButtonStyleName = objRow[conButtonStyle.ButtonStyleName].ToString().Trim(); //按钮样式名
objButtonStyleEN.CssClass = objRow[conButtonStyle.CssClass] == DBNull.Value ? null : objRow[conButtonStyle.CssClass].ToString().Trim(); //样式表
objButtonStyleEN.Style = objRow[conButtonStyle.Style].ToString().Trim(); //类型
objButtonStyleEN.Runat = objRow[conButtonStyle.Runat].ToString().Trim(); //运行在
objButtonStyleEN.FontSize = objRow[conButtonStyle.FontSize].ToString().Trim(); //字号
objButtonStyleEN.FontName = objRow[conButtonStyle.FontName].ToString().Trim(); //字体
objButtonStyleEN.Width = TransNullToInt(objRow[conButtonStyle.Width].ToString().Trim()); //宽
objButtonStyleEN.Height = TransNullToInt(objRow[conButtonStyle.Height].ToString().Trim()); //高度
objButtonStyleEN.StyleZindex = TransNullToInt(objRow[conButtonStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objButtonStyleEN.StyleLeft = TransNullToInt(objRow[conButtonStyle.StyleLeft].ToString().Trim()); //Style_Left
objButtonStyleEN.StylePosition = objRow[conButtonStyle.StylePosition].ToString().Trim(); //Style_Position
objButtonStyleEN.StyleTop = TransNullToInt(objRow[conButtonStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsButtonStyleDA: GetObjByDataRowButtonStyle)", objException.Message));
}
objButtonStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objButtonStyleEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsButtonStyleEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsButtonStyleEN objButtonStyleEN = new clsButtonStyleEN();
try
{
objButtonStyleEN.ButtonStyleId = objRow[conButtonStyle.ButtonStyleId].ToString().Trim(); //按钮样式Id
objButtonStyleEN.ButtonStyleName = objRow[conButtonStyle.ButtonStyleName].ToString().Trim(); //按钮样式名
objButtonStyleEN.CssClass = objRow[conButtonStyle.CssClass] == DBNull.Value ? null : objRow[conButtonStyle.CssClass].ToString().Trim(); //样式表
objButtonStyleEN.Style = objRow[conButtonStyle.Style].ToString().Trim(); //类型
objButtonStyleEN.Runat = objRow[conButtonStyle.Runat].ToString().Trim(); //运行在
objButtonStyleEN.FontSize = objRow[conButtonStyle.FontSize].ToString().Trim(); //字号
objButtonStyleEN.FontName = objRow[conButtonStyle.FontName].ToString().Trim(); //字体
objButtonStyleEN.Width = TransNullToInt(objRow[conButtonStyle.Width].ToString().Trim()); //宽
objButtonStyleEN.Height = TransNullToInt(objRow[conButtonStyle.Height].ToString().Trim()); //高度
objButtonStyleEN.StyleZindex = TransNullToInt(objRow[conButtonStyle.StyleZindex].ToString().Trim()); //Style_Zindex
objButtonStyleEN.StyleLeft = TransNullToInt(objRow[conButtonStyle.StyleLeft].ToString().Trim()); //Style_Left
objButtonStyleEN.StylePosition = objRow[conButtonStyle.StylePosition].ToString().Trim(); //Style_Position
objButtonStyleEN.StyleTop = TransNullToInt(objRow[conButtonStyle.StyleTop].ToString().Trim()); //Style_Top
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsButtonStyleDA: GetObjByDataRow)", objException.Message));
}
objButtonStyleEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objButtonStyleEN;
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
objSQL = clsButtonStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsButtonStyleEN._CurrTabName, conButtonStyle.ButtonStyleId, 4, "");
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
objSQL = clsButtonStyleDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsButtonStyleEN._CurrTabName, conButtonStyle.ButtonStyleId, 4, strPrefix);
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
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ButtonStyleId from ButtonStyle where " + strCondition;
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
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ButtonStyleId from ButtonStyle where " + strCondition;
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
 /// <param name = "strButtonStyleId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strButtonStyleId)
{
CheckPrimaryKey(strButtonStyleId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ButtonStyle", "ButtonStyleId = " + "'"+ strButtonStyleId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsButtonStyleDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ButtonStyle", strCondition))
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
objSQL = clsButtonStyleDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ButtonStyle");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsButtonStyleEN objButtonStyleEN)
 {
 if (objButtonStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objButtonStyleEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
strSQL = "Select * from ButtonStyle where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ButtonStyle");
objRow = objDS.Tables["ButtonStyle"].NewRow();
objRow[conButtonStyle.ButtonStyleId] = objButtonStyleEN.ButtonStyleId; //按钮样式Id
objRow[conButtonStyle.ButtonStyleName] = objButtonStyleEN.ButtonStyleName; //按钮样式名
 if (objButtonStyleEN.CssClass !=  "")
 {
objRow[conButtonStyle.CssClass] = objButtonStyleEN.CssClass; //样式表
 }
objRow[conButtonStyle.Style] = objButtonStyleEN.Style; //类型
objRow[conButtonStyle.Runat] = objButtonStyleEN.Runat; //运行在
objRow[conButtonStyle.FontSize] = objButtonStyleEN.FontSize; //字号
objRow[conButtonStyle.FontName] = objButtonStyleEN.FontName; //字体
objRow[conButtonStyle.Width] = objButtonStyleEN.Width; //宽
objRow[conButtonStyle.Height] = objButtonStyleEN.Height; //高度
objRow[conButtonStyle.StyleZindex] = objButtonStyleEN.StyleZindex; //Style_Zindex
objRow[conButtonStyle.StyleLeft] = objButtonStyleEN.StyleLeft; //Style_Left
objRow[conButtonStyle.StylePosition] = objButtonStyleEN.StylePosition; //Style_Position
objRow[conButtonStyle.StyleTop] = objButtonStyleEN.StyleTop; //Style_Top
objDS.Tables[clsButtonStyleEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsButtonStyleEN._CurrTabName);
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
 /// <param name = "objButtonStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsButtonStyleEN objButtonStyleEN)
{
 if (objButtonStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objButtonStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objButtonStyleEN.ButtonStyleId !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.ButtonStyleId);
 var strButtonStyleId = objButtonStyleEN.ButtonStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonStyleId + "'");
 }
 
 if (objButtonStyleEN.ButtonStyleName !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.ButtonStyleName);
 var strButtonStyleName = objButtonStyleEN.ButtonStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonStyleName + "'");
 }
 
 if (objButtonStyleEN.CssClass !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.CssClass);
 var strCssClass = objButtonStyleEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCssClass + "'");
 }
 
 if (objButtonStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.Style);
 var strStyle = objButtonStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objButtonStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.Runat);
 var strRunat = objButtonStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objButtonStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.FontSize);
 var strFontSize = objButtonStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objButtonStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.FontName);
 var strFontName = objButtonStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 arrFieldListForInsert.Add(conButtonStyle.Width);
 arrValueListForInsert.Add(objButtonStyleEN.Width.ToString());
 
 arrFieldListForInsert.Add(conButtonStyle.Height);
 arrValueListForInsert.Add(objButtonStyleEN.Height.ToString());
 
 arrFieldListForInsert.Add(conButtonStyle.StyleZindex);
 arrValueListForInsert.Add(objButtonStyleEN.StyleZindex.ToString());
 
 arrFieldListForInsert.Add(conButtonStyle.StyleLeft);
 arrValueListForInsert.Add(objButtonStyleEN.StyleLeft.ToString());
 
 if (objButtonStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.StylePosition);
 var strStylePosition = objButtonStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 arrFieldListForInsert.Add(conButtonStyle.StyleTop);
 arrValueListForInsert.Add(objButtonStyleEN.StyleTop.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ButtonStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objButtonStyleEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsButtonStyleEN objButtonStyleEN)
{
 if (objButtonStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objButtonStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objButtonStyleEN.ButtonStyleId !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.ButtonStyleId);
 var strButtonStyleId = objButtonStyleEN.ButtonStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonStyleId + "'");
 }
 
 if (objButtonStyleEN.ButtonStyleName !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.ButtonStyleName);
 var strButtonStyleName = objButtonStyleEN.ButtonStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonStyleName + "'");
 }
 
 if (objButtonStyleEN.CssClass !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.CssClass);
 var strCssClass = objButtonStyleEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCssClass + "'");
 }
 
 if (objButtonStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.Style);
 var strStyle = objButtonStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objButtonStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.Runat);
 var strRunat = objButtonStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objButtonStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.FontSize);
 var strFontSize = objButtonStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objButtonStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.FontName);
 var strFontName = objButtonStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 arrFieldListForInsert.Add(conButtonStyle.Width);
 arrValueListForInsert.Add(objButtonStyleEN.Width.ToString());
 
 arrFieldListForInsert.Add(conButtonStyle.Height);
 arrValueListForInsert.Add(objButtonStyleEN.Height.ToString());
 
 arrFieldListForInsert.Add(conButtonStyle.StyleZindex);
 arrValueListForInsert.Add(objButtonStyleEN.StyleZindex.ToString());
 
 arrFieldListForInsert.Add(conButtonStyle.StyleLeft);
 arrValueListForInsert.Add(objButtonStyleEN.StyleLeft.ToString());
 
 if (objButtonStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.StylePosition);
 var strStylePosition = objButtonStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 arrFieldListForInsert.Add(conButtonStyle.StyleTop);
 arrValueListForInsert.Add(objButtonStyleEN.StyleTop.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ButtonStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objButtonStyleEN.ButtonStyleId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objButtonStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsButtonStyleEN objButtonStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objButtonStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objButtonStyleEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objButtonStyleEN.ButtonStyleId !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.ButtonStyleId);
 var strButtonStyleId = objButtonStyleEN.ButtonStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonStyleId + "'");
 }
 
 if (objButtonStyleEN.ButtonStyleName !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.ButtonStyleName);
 var strButtonStyleName = objButtonStyleEN.ButtonStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonStyleName + "'");
 }
 
 if (objButtonStyleEN.CssClass !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.CssClass);
 var strCssClass = objButtonStyleEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCssClass + "'");
 }
 
 if (objButtonStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.Style);
 var strStyle = objButtonStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objButtonStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.Runat);
 var strRunat = objButtonStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objButtonStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.FontSize);
 var strFontSize = objButtonStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objButtonStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.FontName);
 var strFontName = objButtonStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 arrFieldListForInsert.Add(conButtonStyle.Width);
 arrValueListForInsert.Add(objButtonStyleEN.Width.ToString());
 
 arrFieldListForInsert.Add(conButtonStyle.Height);
 arrValueListForInsert.Add(objButtonStyleEN.Height.ToString());
 
 arrFieldListForInsert.Add(conButtonStyle.StyleZindex);
 arrValueListForInsert.Add(objButtonStyleEN.StyleZindex.ToString());
 
 arrFieldListForInsert.Add(conButtonStyle.StyleLeft);
 arrValueListForInsert.Add(objButtonStyleEN.StyleLeft.ToString());
 
 if (objButtonStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.StylePosition);
 var strStylePosition = objButtonStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 arrFieldListForInsert.Add(conButtonStyle.StyleTop);
 arrValueListForInsert.Add(objButtonStyleEN.StyleTop.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ButtonStyle");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objButtonStyleEN.ButtonStyleId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objButtonStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsButtonStyleEN objButtonStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objButtonStyleEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objButtonStyleEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objButtonStyleEN.ButtonStyleId !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.ButtonStyleId);
 var strButtonStyleId = objButtonStyleEN.ButtonStyleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonStyleId + "'");
 }
 
 if (objButtonStyleEN.ButtonStyleName !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.ButtonStyleName);
 var strButtonStyleName = objButtonStyleEN.ButtonStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strButtonStyleName + "'");
 }
 
 if (objButtonStyleEN.CssClass !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.CssClass);
 var strCssClass = objButtonStyleEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCssClass + "'");
 }
 
 if (objButtonStyleEN.Style !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.Style);
 var strStyle = objButtonStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStyle + "'");
 }
 
 if (objButtonStyleEN.Runat !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.Runat);
 var strRunat = objButtonStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRunat + "'");
 }
 
 if (objButtonStyleEN.FontSize !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.FontSize);
 var strFontSize = objButtonStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontSize + "'");
 }
 
 if (objButtonStyleEN.FontName !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.FontName);
 var strFontName = objButtonStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFontName + "'");
 }
 
 arrFieldListForInsert.Add(conButtonStyle.Width);
 arrValueListForInsert.Add(objButtonStyleEN.Width.ToString());
 
 arrFieldListForInsert.Add(conButtonStyle.Height);
 arrValueListForInsert.Add(objButtonStyleEN.Height.ToString());
 
 arrFieldListForInsert.Add(conButtonStyle.StyleZindex);
 arrValueListForInsert.Add(objButtonStyleEN.StyleZindex.ToString());
 
 arrFieldListForInsert.Add(conButtonStyle.StyleLeft);
 arrValueListForInsert.Add(objButtonStyleEN.StyleLeft.ToString());
 
 if (objButtonStyleEN.StylePosition !=  null)
 {
 arrFieldListForInsert.Add(conButtonStyle.StylePosition);
 var strStylePosition = objButtonStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStylePosition + "'");
 }
 
 arrFieldListForInsert.Add(conButtonStyle.StyleTop);
 arrValueListForInsert.Add(objButtonStyleEN.StyleTop.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ButtonStyle");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewButtonStyles(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
strSQL = "Select * from ButtonStyle where ButtonStyleId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ButtonStyle");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strButtonStyleId = oRow[conButtonStyle.ButtonStyleId].ToString().Trim();
if (IsExist(strButtonStyleId))
{
 string strResult = "关键字变量值为:" + string.Format("ButtonStyleId = {0}", strButtonStyleId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsButtonStyleEN._CurrTabName ].NewRow();
objRow[conButtonStyle.ButtonStyleId] = oRow[conButtonStyle.ButtonStyleId].ToString().Trim(); //按钮样式Id
objRow[conButtonStyle.ButtonStyleName] = oRow[conButtonStyle.ButtonStyleName].ToString().Trim(); //按钮样式名
objRow[conButtonStyle.CssClass] = oRow[conButtonStyle.CssClass].ToString().Trim(); //样式表
objRow[conButtonStyle.Style] = oRow[conButtonStyle.Style].ToString().Trim(); //类型
objRow[conButtonStyle.Runat] = oRow[conButtonStyle.Runat].ToString().Trim(); //运行在
objRow[conButtonStyle.FontSize] = oRow[conButtonStyle.FontSize].ToString().Trim(); //字号
objRow[conButtonStyle.FontName] = oRow[conButtonStyle.FontName].ToString().Trim(); //字体
objRow[conButtonStyle.Width] = oRow[conButtonStyle.Width].ToString().Trim(); //宽
objRow[conButtonStyle.Height] = oRow[conButtonStyle.Height].ToString().Trim(); //高度
objRow[conButtonStyle.StyleZindex] = oRow[conButtonStyle.StyleZindex].ToString().Trim(); //Style_Zindex
objRow[conButtonStyle.StyleLeft] = oRow[conButtonStyle.StyleLeft].ToString().Trim(); //Style_Left
objRow[conButtonStyle.StylePosition] = oRow[conButtonStyle.StylePosition].ToString().Trim(); //Style_Position
objRow[conButtonStyle.StyleTop] = oRow[conButtonStyle.StyleTop].ToString().Trim(); //Style_Top
 objDS.Tables[clsButtonStyleEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsButtonStyleEN._CurrTabName);
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
 /// <param name = "objButtonStyleEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsButtonStyleEN objButtonStyleEN)
{
 if (objButtonStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objButtonStyleEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
strSQL = "Select * from ButtonStyle where ButtonStyleId = " + "'"+ objButtonStyleEN.ButtonStyleId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsButtonStyleEN._CurrTabName);
if (objDS.Tables[clsButtonStyleEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ButtonStyleId = " + "'"+ objButtonStyleEN.ButtonStyleId+"'");
return false;
}
objRow = objDS.Tables[clsButtonStyleEN._CurrTabName].Rows[0];
 if (objButtonStyleEN.IsUpdated(conButtonStyle.ButtonStyleId))
 {
objRow[conButtonStyle.ButtonStyleId] = objButtonStyleEN.ButtonStyleId; //按钮样式Id
 }
 if (objButtonStyleEN.IsUpdated(conButtonStyle.ButtonStyleName))
 {
objRow[conButtonStyle.ButtonStyleName] = objButtonStyleEN.ButtonStyleName; //按钮样式名
 }
 if (objButtonStyleEN.IsUpdated(conButtonStyle.CssClass))
 {
objRow[conButtonStyle.CssClass] = objButtonStyleEN.CssClass; //样式表
 }
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Style))
 {
objRow[conButtonStyle.Style] = objButtonStyleEN.Style; //类型
 }
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Runat))
 {
objRow[conButtonStyle.Runat] = objButtonStyleEN.Runat; //运行在
 }
 if (objButtonStyleEN.IsUpdated(conButtonStyle.FontSize))
 {
objRow[conButtonStyle.FontSize] = objButtonStyleEN.FontSize; //字号
 }
 if (objButtonStyleEN.IsUpdated(conButtonStyle.FontName))
 {
objRow[conButtonStyle.FontName] = objButtonStyleEN.FontName; //字体
 }
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Width))
 {
objRow[conButtonStyle.Width] = objButtonStyleEN.Width; //宽
 }
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Height))
 {
objRow[conButtonStyle.Height] = objButtonStyleEN.Height; //高度
 }
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StyleZindex))
 {
objRow[conButtonStyle.StyleZindex] = objButtonStyleEN.StyleZindex; //Style_Zindex
 }
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StyleLeft))
 {
objRow[conButtonStyle.StyleLeft] = objButtonStyleEN.StyleLeft; //Style_Left
 }
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StylePosition))
 {
objRow[conButtonStyle.StylePosition] = objButtonStyleEN.StylePosition; //Style_Position
 }
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StyleTop))
 {
objRow[conButtonStyle.StyleTop] = objButtonStyleEN.StyleTop; //Style_Top
 }
try
{
objDA.Update(objDS, clsButtonStyleEN._CurrTabName);
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
 /// <param name = "objButtonStyleEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsButtonStyleEN objButtonStyleEN)
{
 if (objButtonStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objButtonStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ButtonStyle Set ");
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.ButtonStyleName))
 {
 if (objButtonStyleEN.ButtonStyleName !=  null)
 {
 var strButtonStyleName = objButtonStyleEN.ButtonStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strButtonStyleName, conButtonStyle.ButtonStyleName); //按钮样式名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonStyle.ButtonStyleName); //按钮样式名
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.CssClass))
 {
 if (objButtonStyleEN.CssClass !=  null)
 {
 var strCssClass = objButtonStyleEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCssClass, conButtonStyle.CssClass); //样式表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonStyle.CssClass); //样式表
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Style))
 {
 if (objButtonStyleEN.Style !=  null)
 {
 var strStyle = objButtonStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyle, conButtonStyle.Style); //类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonStyle.Style); //类型
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Runat))
 {
 if (objButtonStyleEN.Runat !=  null)
 {
 var strRunat = objButtonStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRunat, conButtonStyle.Runat); //运行在
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonStyle.Runat); //运行在
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.FontSize))
 {
 if (objButtonStyleEN.FontSize !=  null)
 {
 var strFontSize = objButtonStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontSize, conButtonStyle.FontSize); //字号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonStyle.FontSize); //字号
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.FontName))
 {
 if (objButtonStyleEN.FontName !=  null)
 {
 var strFontName = objButtonStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontName, conButtonStyle.FontName); //字体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonStyle.FontName); //字体
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Width))
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonStyleEN.Width, conButtonStyle.Width); //宽
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Height))
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonStyleEN.Height, conButtonStyle.Height); //高度
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StyleZindex))
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonStyleEN.StyleZindex, conButtonStyle.StyleZindex); //Style_Zindex
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StyleLeft))
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonStyleEN.StyleLeft, conButtonStyle.StyleLeft); //Style_Left
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StylePosition))
 {
 if (objButtonStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objButtonStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStylePosition, conButtonStyle.StylePosition); //Style_Position
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonStyle.StylePosition); //Style_Position
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StyleTop))
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonStyleEN.StyleTop, conButtonStyle.StyleTop); //Style_Top
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ButtonStyleId = '{0}'", objButtonStyleEN.ButtonStyleId); 
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
 /// <param name = "objButtonStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsButtonStyleEN objButtonStyleEN, string strCondition)
{
 if (objButtonStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objButtonStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ButtonStyle Set ");
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.ButtonStyleName))
 {
 if (objButtonStyleEN.ButtonStyleName !=  null)
 {
 var strButtonStyleName = objButtonStyleEN.ButtonStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ButtonStyleName = '{0}',", strButtonStyleName); //按钮样式名
 }
 else
 {
 sbSQL.Append(" ButtonStyleName = null,"); //按钮样式名
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.CssClass))
 {
 if (objButtonStyleEN.CssClass !=  null)
 {
 var strCssClass = objButtonStyleEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CssClass = '{0}',", strCssClass); //样式表
 }
 else
 {
 sbSQL.Append(" CssClass = null,"); //样式表
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Style))
 {
 if (objButtonStyleEN.Style !=  null)
 {
 var strStyle = objButtonStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Style = '{0}',", strStyle); //类型
 }
 else
 {
 sbSQL.Append(" Style = null,"); //类型
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Runat))
 {
 if (objButtonStyleEN.Runat !=  null)
 {
 var strRunat = objButtonStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Runat = '{0}',", strRunat); //运行在
 }
 else
 {
 sbSQL.Append(" Runat = null,"); //运行在
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.FontSize))
 {
 if (objButtonStyleEN.FontSize !=  null)
 {
 var strFontSize = objButtonStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontSize = '{0}',", strFontSize); //字号
 }
 else
 {
 sbSQL.Append(" FontSize = null,"); //字号
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.FontName))
 {
 if (objButtonStyleEN.FontName !=  null)
 {
 var strFontName = objButtonStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontName = '{0}',", strFontName); //字体
 }
 else
 {
 sbSQL.Append(" FontName = null,"); //字体
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Width))
 {
 sbSQL.AppendFormat(" Width = {0},", objButtonStyleEN.Width); //宽
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Height))
 {
 sbSQL.AppendFormat(" Height = {0},", objButtonStyleEN.Height); //高度
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StyleZindex))
 {
 sbSQL.AppendFormat(" StyleZindex = {0},", objButtonStyleEN.StyleZindex); //Style_Zindex
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StyleLeft))
 {
 sbSQL.AppendFormat(" StyleLeft = {0},", objButtonStyleEN.StyleLeft); //Style_Left
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StylePosition))
 {
 if (objButtonStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objButtonStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StylePosition = '{0}',", strStylePosition); //Style_Position
 }
 else
 {
 sbSQL.Append(" StylePosition = null,"); //Style_Position
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StyleTop))
 {
 sbSQL.AppendFormat(" StyleTop = {0},", objButtonStyleEN.StyleTop); //Style_Top
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
 /// <param name = "objButtonStyleEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsButtonStyleEN objButtonStyleEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objButtonStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objButtonStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ButtonStyle Set ");
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.ButtonStyleName))
 {
 if (objButtonStyleEN.ButtonStyleName !=  null)
 {
 var strButtonStyleName = objButtonStyleEN.ButtonStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ButtonStyleName = '{0}',", strButtonStyleName); //按钮样式名
 }
 else
 {
 sbSQL.Append(" ButtonStyleName = null,"); //按钮样式名
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.CssClass))
 {
 if (objButtonStyleEN.CssClass !=  null)
 {
 var strCssClass = objButtonStyleEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CssClass = '{0}',", strCssClass); //样式表
 }
 else
 {
 sbSQL.Append(" CssClass = null,"); //样式表
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Style))
 {
 if (objButtonStyleEN.Style !=  null)
 {
 var strStyle = objButtonStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Style = '{0}',", strStyle); //类型
 }
 else
 {
 sbSQL.Append(" Style = null,"); //类型
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Runat))
 {
 if (objButtonStyleEN.Runat !=  null)
 {
 var strRunat = objButtonStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Runat = '{0}',", strRunat); //运行在
 }
 else
 {
 sbSQL.Append(" Runat = null,"); //运行在
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.FontSize))
 {
 if (objButtonStyleEN.FontSize !=  null)
 {
 var strFontSize = objButtonStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontSize = '{0}',", strFontSize); //字号
 }
 else
 {
 sbSQL.Append(" FontSize = null,"); //字号
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.FontName))
 {
 if (objButtonStyleEN.FontName !=  null)
 {
 var strFontName = objButtonStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FontName = '{0}',", strFontName); //字体
 }
 else
 {
 sbSQL.Append(" FontName = null,"); //字体
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Width))
 {
 sbSQL.AppendFormat(" Width = {0},", objButtonStyleEN.Width); //宽
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Height))
 {
 sbSQL.AppendFormat(" Height = {0},", objButtonStyleEN.Height); //高度
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StyleZindex))
 {
 sbSQL.AppendFormat(" StyleZindex = {0},", objButtonStyleEN.StyleZindex); //Style_Zindex
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StyleLeft))
 {
 sbSQL.AppendFormat(" StyleLeft = {0},", objButtonStyleEN.StyleLeft); //Style_Left
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StylePosition))
 {
 if (objButtonStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objButtonStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StylePosition = '{0}',", strStylePosition); //Style_Position
 }
 else
 {
 sbSQL.Append(" StylePosition = null,"); //Style_Position
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StyleTop))
 {
 sbSQL.AppendFormat(" StyleTop = {0},", objButtonStyleEN.StyleTop); //Style_Top
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
 /// <param name = "objButtonStyleEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsButtonStyleEN objButtonStyleEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objButtonStyleEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objButtonStyleEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ButtonStyle Set ");
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.ButtonStyleName))
 {
 if (objButtonStyleEN.ButtonStyleName !=  null)
 {
 var strButtonStyleName = objButtonStyleEN.ButtonStyleName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strButtonStyleName, conButtonStyle.ButtonStyleName); //按钮样式名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonStyle.ButtonStyleName); //按钮样式名
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.CssClass))
 {
 if (objButtonStyleEN.CssClass !=  null)
 {
 var strCssClass = objButtonStyleEN.CssClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCssClass, conButtonStyle.CssClass); //样式表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonStyle.CssClass); //样式表
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Style))
 {
 if (objButtonStyleEN.Style !=  null)
 {
 var strStyle = objButtonStyleEN.Style.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStyle, conButtonStyle.Style); //类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonStyle.Style); //类型
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Runat))
 {
 if (objButtonStyleEN.Runat !=  null)
 {
 var strRunat = objButtonStyleEN.Runat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRunat, conButtonStyle.Runat); //运行在
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonStyle.Runat); //运行在
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.FontSize))
 {
 if (objButtonStyleEN.FontSize !=  null)
 {
 var strFontSize = objButtonStyleEN.FontSize.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontSize, conButtonStyle.FontSize); //字号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonStyle.FontSize); //字号
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.FontName))
 {
 if (objButtonStyleEN.FontName !=  null)
 {
 var strFontName = objButtonStyleEN.FontName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFontName, conButtonStyle.FontName); //字体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonStyle.FontName); //字体
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Width))
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonStyleEN.Width, conButtonStyle.Width); //宽
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.Height))
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonStyleEN.Height, conButtonStyle.Height); //高度
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StyleZindex))
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonStyleEN.StyleZindex, conButtonStyle.StyleZindex); //Style_Zindex
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StyleLeft))
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonStyleEN.StyleLeft, conButtonStyle.StyleLeft); //Style_Left
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StylePosition))
 {
 if (objButtonStyleEN.StylePosition !=  null)
 {
 var strStylePosition = objButtonStyleEN.StylePosition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStylePosition, conButtonStyle.StylePosition); //Style_Position
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conButtonStyle.StylePosition); //Style_Position
 }
 }
 
 if (objButtonStyleEN.IsUpdated(conButtonStyle.StyleTop))
 {
 sbSQL.AppendFormat("{1} = {0},",objButtonStyleEN.StyleTop, conButtonStyle.StyleTop); //Style_Top
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ButtonStyleId = '{0}'", objButtonStyleEN.ButtonStyleId); 
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
 /// <param name = "strButtonStyleId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strButtonStyleId) 
{
CheckPrimaryKey(strButtonStyleId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strButtonStyleId,
};
 objSQL.ExecSP("ButtonStyle_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strButtonStyleId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strButtonStyleId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strButtonStyleId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
//删除ButtonStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ButtonStyle where ButtonStyleId = " + "'"+ strButtonStyleId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelButtonStyle(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
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
//删除ButtonStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ButtonStyle where ButtonStyleId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strButtonStyleId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strButtonStyleId) 
{
CheckPrimaryKey(strButtonStyleId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
//删除ButtonStyle本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ButtonStyle where ButtonStyleId = " + "'"+ strButtonStyleId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelButtonStyle(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsButtonStyleDA: DelButtonStyle)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ButtonStyle where " + strCondition ;
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
public bool DelButtonStyleWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsButtonStyleDA: DelButtonStyleWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ButtonStyle where " + strCondition ;
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
 /// <param name = "objButtonStyleENS">源对象</param>
 /// <param name = "objButtonStyleENT">目标对象</param>
public void CopyTo(clsButtonStyleEN objButtonStyleENS, clsButtonStyleEN objButtonStyleENT)
{
objButtonStyleENT.ButtonStyleId = objButtonStyleENS.ButtonStyleId; //按钮样式Id
objButtonStyleENT.ButtonStyleName = objButtonStyleENS.ButtonStyleName; //按钮样式名
objButtonStyleENT.CssClass = objButtonStyleENS.CssClass; //样式表
objButtonStyleENT.Style = objButtonStyleENS.Style; //类型
objButtonStyleENT.Runat = objButtonStyleENS.Runat; //运行在
objButtonStyleENT.FontSize = objButtonStyleENS.FontSize; //字号
objButtonStyleENT.FontName = objButtonStyleENS.FontName; //字体
objButtonStyleENT.Width = objButtonStyleENS.Width; //宽
objButtonStyleENT.Height = objButtonStyleENS.Height; //高度
objButtonStyleENT.StyleZindex = objButtonStyleENS.StyleZindex; //Style_Zindex
objButtonStyleENT.StyleLeft = objButtonStyleENS.StyleLeft; //Style_Left
objButtonStyleENT.StylePosition = objButtonStyleENS.StylePosition; //Style_Position
objButtonStyleENT.StyleTop = objButtonStyleENS.StyleTop; //Style_Top
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsButtonStyleEN objButtonStyleEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objButtonStyleEN.ButtonStyleName, conButtonStyle.ButtonStyleName);
clsCheckSql.CheckFieldNotNull(objButtonStyleEN.Style, conButtonStyle.Style);
clsCheckSql.CheckFieldNotNull(objButtonStyleEN.Runat, conButtonStyle.Runat);
clsCheckSql.CheckFieldNotNull(objButtonStyleEN.FontSize, conButtonStyle.FontSize);
clsCheckSql.CheckFieldNotNull(objButtonStyleEN.FontName, conButtonStyle.FontName);
clsCheckSql.CheckFieldNotNull(objButtonStyleEN.Width, conButtonStyle.Width);
clsCheckSql.CheckFieldNotNull(objButtonStyleEN.Height, conButtonStyle.Height);
clsCheckSql.CheckFieldNotNull(objButtonStyleEN.StyleZindex, conButtonStyle.StyleZindex);
clsCheckSql.CheckFieldNotNull(objButtonStyleEN.StyleLeft, conButtonStyle.StyleLeft);
clsCheckSql.CheckFieldNotNull(objButtonStyleEN.StylePosition, conButtonStyle.StylePosition);
clsCheckSql.CheckFieldNotNull(objButtonStyleEN.StyleTop, conButtonStyle.StyleTop);
//检查字段长度
clsCheckSql.CheckFieldLen(objButtonStyleEN.ButtonStyleId, 4, conButtonStyle.ButtonStyleId);
clsCheckSql.CheckFieldLen(objButtonStyleEN.ButtonStyleName, 30, conButtonStyle.ButtonStyleName);
clsCheckSql.CheckFieldLen(objButtonStyleEN.CssClass, 50, conButtonStyle.CssClass);
clsCheckSql.CheckFieldLen(objButtonStyleEN.Style, 800, conButtonStyle.Style);
clsCheckSql.CheckFieldLen(objButtonStyleEN.Runat, 30, conButtonStyle.Runat);
clsCheckSql.CheckFieldLen(objButtonStyleEN.FontSize, 20, conButtonStyle.FontSize);
clsCheckSql.CheckFieldLen(objButtonStyleEN.FontName, 20, conButtonStyle.FontName);
clsCheckSql.CheckFieldLen(objButtonStyleEN.StylePosition, 20, conButtonStyle.StylePosition);
//检查字段外键固定长度
 objButtonStyleEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsButtonStyleEN objButtonStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objButtonStyleEN.ButtonStyleName, 30, conButtonStyle.ButtonStyleName);
clsCheckSql.CheckFieldLen(objButtonStyleEN.CssClass, 50, conButtonStyle.CssClass);
clsCheckSql.CheckFieldLen(objButtonStyleEN.Style, 800, conButtonStyle.Style);
clsCheckSql.CheckFieldLen(objButtonStyleEN.Runat, 30, conButtonStyle.Runat);
clsCheckSql.CheckFieldLen(objButtonStyleEN.FontSize, 20, conButtonStyle.FontSize);
clsCheckSql.CheckFieldLen(objButtonStyleEN.FontName, 20, conButtonStyle.FontName);
clsCheckSql.CheckFieldLen(objButtonStyleEN.StylePosition, 20, conButtonStyle.StylePosition);
//检查外键字段长度
 objButtonStyleEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsButtonStyleEN objButtonStyleEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objButtonStyleEN.ButtonStyleId, 4, conButtonStyle.ButtonStyleId);
clsCheckSql.CheckFieldLen(objButtonStyleEN.ButtonStyleName, 30, conButtonStyle.ButtonStyleName);
clsCheckSql.CheckFieldLen(objButtonStyleEN.CssClass, 50, conButtonStyle.CssClass);
clsCheckSql.CheckFieldLen(objButtonStyleEN.Style, 800, conButtonStyle.Style);
clsCheckSql.CheckFieldLen(objButtonStyleEN.Runat, 30, conButtonStyle.Runat);
clsCheckSql.CheckFieldLen(objButtonStyleEN.FontSize, 20, conButtonStyle.FontSize);
clsCheckSql.CheckFieldLen(objButtonStyleEN.FontName, 20, conButtonStyle.FontName);
clsCheckSql.CheckFieldLen(objButtonStyleEN.StylePosition, 20, conButtonStyle.StylePosition);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objButtonStyleEN.ButtonStyleId, conButtonStyle.ButtonStyleId);
clsCheckSql.CheckSqlInjection4Field(objButtonStyleEN.ButtonStyleName, conButtonStyle.ButtonStyleName);
clsCheckSql.CheckSqlInjection4Field(objButtonStyleEN.CssClass, conButtonStyle.CssClass);
clsCheckSql.CheckSqlInjection4Field(objButtonStyleEN.Style, conButtonStyle.Style);
clsCheckSql.CheckSqlInjection4Field(objButtonStyleEN.Runat, conButtonStyle.Runat);
clsCheckSql.CheckSqlInjection4Field(objButtonStyleEN.FontSize, conButtonStyle.FontSize);
clsCheckSql.CheckSqlInjection4Field(objButtonStyleEN.FontName, conButtonStyle.FontName);
clsCheckSql.CheckSqlInjection4Field(objButtonStyleEN.StylePosition, conButtonStyle.StylePosition);
//检查外键字段长度
 objButtonStyleEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetButtonStyleId()
{
//获取某学院所有专业信息
string strSQL = "select ButtonStyleId, ButtonStyleName from ButtonStyle ";
 clsSpecSQLforSql mySql = clsButtonStyleDA.GetSpecSQLObj();
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
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
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
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
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
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsButtonStyleEN._CurrTabName);
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
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsButtonStyleEN._CurrTabName, strCondition);
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
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
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
 objSQL = clsButtonStyleDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}